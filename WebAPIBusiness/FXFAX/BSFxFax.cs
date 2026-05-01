using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WebAPIBusiness.Common;
using WebAPIBusiness.Utilities;
using WebAPIBusiness.WireTransac;
using WebAPIDataAccess.FAXOutgoing;
using WEbAPIEntities.Common;
using WEbAPIEntities.FXFAX;
using WebAPIReports.Tools.FXFAX;

namespace WebAPIBusiness.FXFAX
{
    public class BSFxFax
    {
        private static readonly log4net.ILog log;
        private static readonly ConcurrentExecutor executor;

        private string userName;
        private string computerName;

        private string filePath;
        private string faxServerIP;
        private int batchID;

        private int faxesToSend = 0;

        private Func<TParameters, string, TResult> FXFAXToPDFFile;

        static BSFxFax()
        {
            executor = new ConcurrentExecutor();
            log = log4net.LogManager.GetLogger(typeof(BSFxFax));
        }

        public BSFxFax()
        {
            ToolFXFAX instance = new ToolFXFAX();
            FXFAXToPDFFile = instance.FXFAXToPDFFile;
        }

        #region public

        public TResultStream FXFAXToStream(TParameters param, string format)
        {
            TResultStream rs = new TResultStream();
            try
            {
                rs = new ToolFXFAX().FXFAXToStream(param, format);
            }
            catch (Exception ex)
            {
                log.ErrorFormat("FXFAXToStream ERROR: {0}", ex.Message);
                rs.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return rs;
        }

        public TResultStream FXFAXMultiplesToStream(TParameters param, string format)
        {
            TResultStream rs = new TResultStream();
            try
            {
                rs = new ToolFXFAX().FXFAXMultiplesToStream(param, format);

            }
            catch (Exception ex)
            {
                log.ErrorFormat("FXFAXMultiplesToStream ERROR: {0}", ex.Message);
                rs.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return rs;
        }
        
        public async Task<FxFaxResultBatch> FXFAXBatchProcess(FxFaxBatchParameters param)
        {
            batchID = 0;
            FxFaxResultBatch result = new FxFaxResultBatch();
            try
            {
                if (param != null && param.Reports.Count > 0)
                {
                    filePath = System.Web.HttpContext.Current.Server.MapPath("~/App_Data/");
                    if (string.IsNullOrWhiteSpace(filePath))
                    {
                        log.Error("App_Data does not exist");
                        result.SetMessages(ErrorResult.UnexpectedError, "App_Data does not exist");
                        return result;
                    }
                    batchID = await new DAFaxEmail().FxFaxBatchCreate(param.UserName, DateTime.Now);

                    if (batchID > 0)
                    {
                        log.InfoFormat("Start FxFax BatchProcess, User {0} - {1}", param.UserName, batchID);
                        userName = param.UserName;
                        computerName = param.ComputerName;
                        //Shoot without await
                        _ = Task.Factory.StartNew(async () => await SendFaxes(param), TaskCreationOptions.LongRunning);
                    }
                }
                else
                    result.SetMessages(ErrorResult.UnexpectedError, "There is no statements to send");

                result.BatchID = batchID;
            }
            catch (Exception ex)
            {
                log.ErrorFormat("FXFAXBatchProcess ERROR: {0}", ex.Message);
                result.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return result;
        }

        public async Task<FxFaxResultBatch> FXFAXBatchProcessAsync(FxFaxBatchParameters param)
        {
            batchID = 0;
            log.InfoFormat("Start FxFax BatchProcess, User {0}", param.UserName);
            FxFaxResultBatch result = new FxFaxResultBatch();

            try
            {
                if (param != null && param.Reports.Count > 0)
                {                    
                    batchID =await new DAFaxEmail().FxFaxBatchCreate(param.UserName, DateTime.Now);

                    if (batchID > 0)
                    {
                        userName = param.UserName;
                        computerName = param.ComputerName;
                        var tsk = Task.Run(() => SendFaxesAsync(param));
                        result.BatchID = batchID;                        
                    }
                }
                else
                {
                    result.SetMessages(ErrorResult.UnexpectedError, "There is no statements to send");
                }
            }
            catch (Exception ex)
            {
                log.ErrorFormat("FXFAXBatchProcess ERROR: {0}", ex.Message);
                result.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return result;
        }
        
        public FxFaxResultBatch FXFAXBatchInfo(int batchId)
        {

            return new DAFaxEmail().FxFaxBatchInfo(batchId);
        }

        public TResultStream FXFAXSmallToStream(TParameters param, string format)
        {
            TResultStream rs = new TResultStream();
            try
            {
                rs = new ToolFXFAX().FXFAXSmallToStream(param, format);

            }
            catch (Exception ex)
            {
                log.ErrorFormat("FXFAXSmallToStream ERROR: {0}", ex.Message);
                rs.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return rs;
        }

        #endregion


        #region private

        private async Task SendFaxes(FxFaxBatchParameters param)
        {
            try
            {
                if (param.Reports.Count == 0)
                {
                    log.Error("FxFax.There is no Agencies to send faxes");
                    await new DAFaxEmail().FxFaxBatchClose(batchID);
                    return;
                }

                faxServerIP = new BSConfigParamWT().GetValueFromConfigParam("ServerIpFaxes");

                faxesToSend = param.Reports.Count;
                List<Task> allTasks = new List<Task>();
                log.Info(string.Format("Starting {1} tasks for all fx reports by fax - {0}", batchID, faxesToSend));
                foreach (FxFax elem in param.Reports)
                {
                    //Limit the number of pending tasks to 300 at same time with 4 excutions to database. 
                    await executor.LimitQueue.WaitAsync();
                    allTasks.Add(Task.Run(executor.ExecuterTask(GenerateAndSendFax, elem)));
                }
                log.Info(string.Format("Ending task generation for fx report by fax - {0}", batchID));
                await Task.WhenAll(allTasks);
                log.Info(string.Format("All tasks finished for fx report by fax - {0}", batchID));
                allTasks.Clear();
            }
            catch (Exception ex)
            {
                log.Error(string.Format("Ther was a unhandled error in SendFaxes Fx Method - {0}", batchID), ex);
                await CloseBatch (batchID);
            }
        }
        
        
        private async Task SendFaxesAsync(FxFaxBatchParameters param)
        {
            if (param.Reports.Count == 0)
            {
                log.Error("FxFax.There is no Agencies to send faxes");
                await new  DAFaxEmail().FxFaxBatchClose(batchID);
                return;
            }
            try
            {
                string fxServerIP = new BSConfigParamWT().GetValueFromConfigParam("ServerIpFaxes");
                var sendFaxTasks = param.Reports.Select(elem => GenerateAndSendFaxNew(elem, fxServerIP)).ToArray();
                await Task.WhenAll(sendFaxTasks);
            }
            catch (Exception ex)
            {
                log.ErrorFormat("Error sending Faxes {0}", ex.Message);
            }
            finally
            {
                await new DAFaxEmail().FxFaxBatchClose(batchID);
            }
        }
        

        private async Task GenerateAndSendFax(FxFax elem)
        {
            string fPath = string.Empty;
            TResult res = null;
            try
            {
                fPath = string.Format("{0}FXFax_{1}{2}", filePath, elem.AgencyCode.Trim(), ".pdf");
                TParameters inParam = new TParameters();
                inParam.parameters = new Dictionary<string, string>();
                inParam.parameters.Add("AgencyCode", elem.AgencyCode);
                inParam.parameters.Add("LanguageId", elem.LanguageId.ToString());
                inParam.parameters.Add("BlackAndWhite", (true).ToString());

                res = await Task.Factory.FromAsync(FXFAXToPDFFile.BeginInvoke, FXFAXToPDFFile.EndInvoke, inParam, fPath, null);

                if (res.ErrorCode == 0)
                {
                    await Task.Factory.FromAsync(FaxSender.SendFaxFxDelegate.BeginInvoke(faxServerIP,//"192.168.4.60",//
                                                   elem.AgencyCode,
                                                   userName,
                                                   computerName,
                                                   fPath, null, null), FaxSender.SendFaxFxDelegate.EndInvoke);


                    await new DAFaxEmail().FxFaxBatchDetailInsert(batchID, elem.AgencyCode.Trim(), DateTime.Now);
                    log.InfoFormat("User {0} sent FX FAX to {1} by fax - {2}", userName, elem.AgencyCode, batchID);
                }
                else
                    log.ErrorFormat("There was a error on generate PDF for FXFAX - {0} - {1}", elem.AgencyCode, batchID);
            }
            catch (Exception ex)
            {
                log.Error(string.Format("Error sending FX FAX to Agency {0}. {1} - {2}", elem.AgencyCode, userName, batchID), ex);
            }
            finally
            {
                //only if is the thread who creates the file.
                if (res != null && res.ErrorCode == 0 && File.Exists(fPath))
                    try
                    {
                        File.Delete(fPath);
                    }
                    catch (Exception ex) { log.ErrorFormat("There was a error on delete file FXFax {0} Ex: {1}", batchID, ex.Message); }

                if (Interlocked.Decrement(ref faxesToSend) <= 0)
                {
                    await CloseBatch(batchID);
                }
            }
        }
        
        private async Task GenerateAndSendFaxNew(Object obj, string fxServerIP)
        {
            FxFax elem = (FxFax)obj;
            string fPath = string.Format("{0}FXFax_{1}{2}", filePath, elem.AgencyCode.Trim(), ".pdf");

            TParameters inParam = new TParameters();
            inParam.parameters = new Dictionary<string, string>();
            inParam.parameters.Add("AgencyCode", elem.AgencyCode);
            inParam.parameters.Add("LanguageId", elem.LanguageId.ToString());
            inParam.parameters.Add("BlackAndWhite", (true).ToString());

            try
            {                
                TResult res = new ToolFXFAX().FXFAXToPDFFile(inParam, fPath);
                
                FaxSender.SendMarketingFaxInt(fxServerIP,//"192.168.4.60",//
                                               elem.AgencyCode,
                                               userName,
                                               computerName,
                                               fPath);

                await new DAFaxEmail().FxFaxBatchDetailInsert(batchID, elem.AgencyCode.Trim(), DateTime.Now);
                log.InfoFormat("User {0} sent FX FAX to {1} by fax", userName, elem.AgencyCode);
            }
            catch (Exception ex)
            {
                log.ErrorFormat("Error sending FX FAX to Agency {0}. {1}, {2}", elem.AgencyCode, ex.Message, ex.InnerException != null ? ex.InnerException.Message : string.Empty);
            }
            finally
            {
                if (File.Exists(fPath))
                    File.Delete(fPath);
                
            }
        }

        private async Task CloseBatch(int BatchId)
        {
            try
            {
                await new DAFaxEmail().FxFaxBatchClose(BatchId);
            }
            catch (Exception ex)
            {
                log.Error(string.Format("There was a error on closing FxFax batch - {0}", batchID), ex);
            }
        }

        #endregion

    }
}
