using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEbAPIEntities.Invoice;
using WEbAPIEntities.Common;
using WebAPIBusiness.Utilities;
using WebAPIReports.Tools.Invoice;
using System.Threading;
using System.IO;

//using WebAPIDataAccess.WireSecurity;
using WebAPIDataAccess.WireTransac;
using WebAPIDataAccess.FAXOutgoing;
using System.Text.RegularExpressions;

using System.Xml;
using WebAPIBusiness.WireTransac;
using WebAPIBusiness.Common;

namespace WebAPIBusiness
{
    public class BSInvoice
    {
        #region properties

        private string userName;
        private string computerName;
        private string smtpServer;
        private string smtpUser;
        private string smtpPassword;
        private string fromEmail;
        private string filePath;
        private string faxServerIP;
        private int    batchID;
        private string fileDate;
        private int faxesToSend = 0;
        private int emailsToSend = 0;
        private XmlDocument docEmailSpanish;
        private XmlDocument docEmailEnglish;
        private Func<InvoiceParameters, InvoiceResultStream> _OneInvoiceStreamPDF;
        private Func<InvoiceParameters, string, InvoiceResult> _OneInvoiceToPDFFile;

        private static readonly ConcurrentExecutor executor;
        private static readonly log4net.ILog log;
        #endregion
        public BSInvoice()
        {
            _OneInvoiceStreamPDF = ToolInvoice.OneInvoiceToStreamPDF;
            _OneInvoiceToPDFFile = ToolInvoice.OneInvoiceToPDFFile;
        }

        static BSInvoice()
        {
            executor = new ConcurrentExecutor("MaxConcurrentThreadForInvoice", "AwaitMSAfterReportExecutionInvoice", "MaxQueueInvoice");
            log= log4net.LogManager.GetLogger(typeof(BSInvoice));
        }


        #region publics
        public InvoiceResultStream InvoiceToStreamPDF(InvoiceParameters param)
        {
            //log.Info("Stream To PDF");
            InvoiceResultStream rs = new InvoiceResultStream();
             try
             { 
                rs = ToolInvoice.InvoiceToStreamPDF(param);
             }
                catch (Exception ex)
             {
                 log.ErrorFormat("InvoiceToStreamPDF ERROR: {0}", ex.Message);
                 rs.SetMessages(ErrorResult.UnexpectedError, ex.Message);
             }
            return rs;
        }

        public InvoiceResultStream InvoiceToStreamXLSX(InvoiceParameters param)
        {
            InvoiceResultStream rs = new InvoiceResultStream();
            try
            {
                rs = ToolInvoice.InvoiceToStreamXLSX(param);
            }
            catch (Exception ex)
            {
                log.ErrorFormat("InvoiceToStreamXLSX ERROR: {0}", ex.Message);
                rs.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return rs;
        }



        public InvoiceResultStream OneInvoiceToStreamPDF(InvoiceParameters param)
        {
             InvoiceResultStream rs = new InvoiceResultStream();
             try
             {
                 rs = ToolInvoice.OneInvoiceToStreamPDF(param);
             }
                catch (Exception ex)
             {
                 log.ErrorFormat("OneInvoiceToStreamPDF ERROR: {0}", ex.Message);
                 rs.SetMessages(ErrorResult.UnexpectedError, ex.Message);
             }
            return rs;
        }
        public InvoiceResultStream InvoiceToStreamPRNX(InvoiceParameters param)
        {
         //   log.Info("Stream To PRNX");
            InvoiceResultStream rs = new InvoiceResultStream();
            try
            {
                rs = ToolInvoice.InvoiceToStreamPRNX(param);
            }
            catch (Exception ex)
            {
                log.ErrorFormat("InvoiceToStreamPRNX ERROR: {0}", ex.Message);
                rs.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return rs;
        }

        public InvoiceResultStream InvoiceToStreamPNG(InvoiceParameters param)
        {
          //  log.Info("Stream To PNG");
            InvoiceResultStream rs = new InvoiceResultStream();
            try
            { 
                 rs = ToolInvoice.InvoiceToStreamPNG(param);
            }
            catch (Exception ex)
            {
                log.ErrorFormat("InvoiceToStreamPNG ERROR: {0}", ex.Message);
                rs.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return rs;
        }

        public InvoiceResultStream InvoiceToStreamHTML(InvoiceParameters param)
        {
          //  log.Info("Stream To HTML");
            InvoiceResultStream rs = new InvoiceResultStream();
            try 
            { 
               rs = ToolInvoice.InvoiceToStreamHTML(param);
            }
            catch (Exception ex)
            {
                log.ErrorFormat("InvoiceToStreamHTML ERROR: {0}", ex.Message);
                rs.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return rs;
        }

        public InvoiceResultStream InvoiceToStreamTXTSmall(InvoiceParameters param)
        {
        //    log.Info("Stream To Txt Small Format");
            InvoiceResultStream rs = new InvoiceResultStream();
            try
            {
                rs = ToolInvoice.InvoiceToStreamTXTSmall(param);
            }
            catch (Exception ex)
            {
                log.ErrorFormat("InvoiceToStreamTXTSmall ERROR: {0}", ex.Message);
                rs.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return rs;
        }

        public InvoiceResultStream InvoiceToStreamHTMLSmall(InvoiceParameters param)
        {
          //  log.Info("Stream To HTML Small Format");
            InvoiceResultStream rs = new InvoiceResultStream();
            try
            {
                rs = ToolInvoice.InvoiceToStreamHTMLSmall(param);
            }
            catch (Exception ex)
            {
                log.ErrorFormat("InvoiceToStreamHTMLSmall ERROR: {0}", ex.Message);
                rs.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return rs;
        }
        public InvoiceResultStream InvoiceToStreamPDFSmall(InvoiceParameters param)
        {
          //  log.Info("Stream To PDF Small Format");
            InvoiceResultStream rs = new InvoiceResultStream();
            try
            {
                rs = ToolInvoice.InvoiceToStreamPDFSmall(param);
            }
            catch (Exception ex)
            {
                log.ErrorFormat("InvoiceToStreamPDFSmall ERROR: {0}", ex.Message);
                rs.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return rs;
        }
        public async Task<InvoiceResultBatch> InvoiceBatchProcess(InvoiceBatchParameters param)
        {
            batchID = 0;
            InvoiceResultBatch result = new InvoiceResultBatch();

            try 
            { 
                if (param != null && param.Statements.Count > 0)
                {              
                    filePath = System.Web.HttpContext.Current.Server.MapPath("~/App_Data/");
                    if (string.IsNullOrWhiteSpace(filePath))
                    {
                        log.Error("App_Data does not exist");
                        result.SetMessages(ErrorResult.UnexpectedError, "App_Data does not exist");
                        return result;
                    }
                    batchID = await new DAFaxEmail().FaxEmailBatchCreate(param.UserName, DateTime.Now);

                    if (batchID > 0)
                    {
                        log.InfoFormat("Start Invoice BatchProcess, User {0} - {1}", param.UserName, batchID);
                        userName = param.UserName;
                        computerName = param.ComputerName;
                        _=Task.Factory.StartNew(async () => { await SendFaxes(param); }, TaskCreationOptions.LongRunning);
                        _=Task.Factory.StartNew(async () => { await SendEmail(param); }, TaskCreationOptions.LongRunning);
                    }
                }
                else
                    result.SetMessages(ErrorResult.UnexpectedError, "There is no statements to send");

                result.BatchID = batchID;
            }
            catch (Exception ex)
            {
                log.ErrorFormat("InvoiceBatchProcess ERROR: {0}", ex.Message);
                result.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return result;
        }

        public InvoiceResultBatch InvoiceBatchInfo(int batchId)
        {
           
            return new DAFaxEmail().FaxEmailBatchInfo(batchId);
        }

        public List<InvoiceBatchInfo> InvoiceFaxEmailLogRead()
        {

            return new DAFaxEmail().FaxEmailLogRead();
        }

        #endregion

        #region privates
        private async Task SendFaxes(InvoiceBatchParameters param)
        {
            try
            {
                var invoiceToSend = param.Statements.Where(p => p.SendingMethod == "F").OrderBy(p => p.TimeZone).ThenByDescending(p => p.WiresSent).ToArray();
                if (invoiceToSend.Count() == 0)
                {
                    log.Error(string.Format("There is no Agencies to send faxes - {0}", batchID));
                    await new DAFaxEmail().FaxEmailBatchClose(batchID, "F");
                    return;
                }

                faxServerIP = new BSConfigParamWT().GetValueFromConfigParam("ServerIpFaxes");
                List<Task> allTasks = new List<Task>();

                faxesToSend = invoiceToSend.Count();
                log.Info(string.Format("Starting {1} tasks for all invoice by faxes - {0} ", batchID, faxesToSend));
                foreach (var elem in invoiceToSend)
                {
                    await executor.LimitQueue.WaitAsync();
                    allTasks.Add(Task.Run(executor.ExecuterTask(GenerateAndSendFax, elem)));
                }
                log.Info(string.Format("Ending tasks generation for invoice by fax - {0}", batchID));
                await Task.WhenAll(allTasks);
                log.Info(string.Format("All tasks finished invoice by fax {0}", batchID));
                allTasks.Clear();
            }
            catch (Exception ex)
            {
                log.Error(string.Format("There was an unhandled error on SendFaxes for invoices method - {0}", batchID), ex);
                await CloseBatch(batchID, "F");
            }
        }

        private async Task GenerateAndSendFax(Invoice elem)
        {
            string fPath = string.Empty;
            InvoiceResult res = null;
            try
            {
                fPath = string.Format("{0}FaxAccountingInvoice_{1}_{2}{3}", filePath, elem.AgencyCode.Trim(), elem.StatementId.Trim(), ".pdf");
                InvoiceParameters invParam = new InvoiceParameters();
                invParam.parameters = new Dictionary<string, string>();
                invParam.parameters.Add("AgencyCode", elem.AgencyCode);
                invParam.parameters.Add("StatementId", elem.StatementId);
                invParam.parameters.Add("LanguageId", elem.LanguageId.ToString());
                invParam.parameters.Add("BlackAndWhite", (true).ToString());

                res = await Task.Factory.FromAsync(_OneInvoiceToPDFFile.BeginInvoke, _OneInvoiceToPDFFile.EndInvoke, invParam, fPath, null);

                if (res.ErrorCode == 0)
                {
                    await Task.Factory.FromAsync(FaxSender.SendFaxInvoiceDelegate.BeginInvoke(faxServerIP,
                                                         elem.AgencyCode,
                                                         elem.DeliverHour,
                                                         elem.DeliverMin,
                                                         userName,
                                                         computerName,
                                                         fPath, null, null), FaxSender.SendFaxInvoiceDelegate.EndInvoke);

                    await new DAStatement().UpdateFaxSent(elem.StatementId, "S", userName);

                    await new DAFaxEmail().FaxEmailBatchDetailInsert(batchID, elem.AgencyCode.Trim(), DateTime.Now, "F");

                    log.InfoFormat("User {0} sent statement {1} to {2} by fax - {3}", userName, elem.StatementId, elem.AgencyCode, batchID);
                }
                else
                    log.ErrorFormat("There was a error on generating PDF for Invoice FAX - {0} - {1}", elem.AgencyCode, batchID);
            }
            catch (Exception ex)
            {
                log.Error(string.Format("Statement {0} to {1} by fax. {2}", elem.StatementId, elem.AgencyCode, batchID), ex);
            }
            finally
            {
                //only if is the thread who creates the file.
                if (res != null && res.ErrorCode == 0 && File.Exists(fPath))
                    try
                    {
                        File.Delete(fPath);
                    }
                    catch (Exception ex) { log.ErrorFormat("There was a error on delete file Invoice FAX {0} Ex: {1}", batchID, ex.Message); }

                if (Interlocked.Decrement(ref faxesToSend) <= 0)
                {
                    await CloseBatch(batchID, "F");
                }
            }
        }

        private async Task CloseBatch(int BatchId,string Method)
        {
            try
            {
                await new DAFaxEmail().FaxEmailBatchClose(BatchId, Method);
            }
            catch (Exception ex)
            {
                log.Error(string.Format("There was a error on closing the batch fax invoices - {0}", batchID), ex);
            }
        }

        private async Task SendEmail(InvoiceBatchParameters param)
        {
            try
            {
                var invoiceToSend = param.Statements.Where(p => p.SendingMethod == "E").OrderBy(p => p.TimeZone).ThenByDescending(p => p.WiresSent).ToArray();

                if (invoiceToSend.Count() == 0)
                {
                    log.ErrorFormat("There is no Agencies to send Email - {0}", batchID);
                    await new DAFaxEmail().FaxEmailBatchClose(batchID, "E");
                    return;
                }

                var dasConfig = new WebAPIBusiness.WireSecurity.BSConfigParam();
                smtpServer = dasConfig.GetValueFromConfigParam("SMTP_SERVER");
                smtpUser = dasConfig.GetValueFromConfigParam("SMTP_USERNAME");
                smtpPassword = dasConfig.GetValueFromConfigParam("SMTP_PASSWORD");

                fromEmail = dasConfig.GetValueFromConfigParam("EmailFromIntermexAccountReceivableDepartment");

                docEmailEnglish = new XmlDocument();
                docEmailEnglish.Load(filePath + "EnglishInvoiceEmail.xml");
                docEmailSpanish = new XmlDocument();
                docEmailSpanish.Load(filePath + "SpanishInvoiceEmail.xml");

                DateTime DateNow = new WebAPIBusiness.WireSecurity.BSDateTime().GetDateTimeFromDb();
                fileDate = DateNow.Month.ToString().PadLeft(2, '0') + DateNow.Day.ToString().PadLeft(2, '0') + DateNow.Year.ToString().Substring(2, 2);
                List<Task> allTask = new List<Task>();

                emailsToSend = invoiceToSend.Count();
                log.Info(string.Format("Starting {1} tasks for all Invoices by E-Mail - {0}", batchID, emailsToSend));
                foreach (var elem in invoiceToSend)
                {
                    await executor.LimitQueue.WaitAsync();
                    allTask.Add(Task.Run(executor.ExecuterTask(GenerateAndSendEmail, elem)));
                }
                log.Info(string.Format("Ending task generation for Invoices by E-Mail - {0}", batchID));
                await Task.WhenAll(allTask);
                log.Info(string.Format("Ending Tasks Invoice By E-Mail - {0}", batchID));
                allTask.Clear();
            }
            catch (Exception ex)
            {
                log.Error(string.Format("There was a unhandled exception on SendEmail for invoice method - {0}", batchID), ex);
                await CloseBatch(batchID, "E");
            }
        }

        private async Task GenerateAndSendEmail(Invoice elem)
        {
            string emails = null;
            try
            {
                emails = await GetValidEmails(elem.AgencyCode, elem.AgencyEmail);
            }
            catch (Exception ex)
            {
                log.Error(string.Format("Error mail validation, statement: {0} to {1} by email {2} - {3}", elem.StatementId, elem.AgencyCode, emails, batchID), ex);
                emails = null;
            }

            if (!string.IsNullOrEmpty(emails))
            {
                InvoiceResultStream rs = null;
                try
                {
                    InvoiceParameters invParam = new InvoiceParameters();
                    invParam.parameters = new Dictionary<string, string>();
                    invParam.parameters.Add("AgencyCode", elem.AgencyCode);
                    invParam.parameters.Add("StatementId", elem.StatementId);
                    invParam.parameters.Add("LanguageId", elem.LanguageId.ToString());
                    invParam.parameters.Add("BlackAndWhite", (false).ToString());

                    rs = await Task.Factory.FromAsync(_OneInvoiceStreamPDF.BeginInvoke, _OneInvoiceStreamPDF.EndInvoke, invParam, null);
                }
                catch (Exception ex)
                {
                    log.Error(string.Format("Error on invoking PDF creation for invoice mail AgencyCode: {0}, StatementId: {1} - {2}", elem.AgencyCode, elem.StatementId, batchID), ex);
                    rs = new InvoiceResultStream() { ErrorCode = 1 };
                }

                if (rs.ErrorCode == 0)
                {
                    XmlElement root;
                    XmlNode nodeType, nodeSubject, nodeBody;
                    if (elem.LanguageId == 1)
                    {
                        root = docEmailEnglish.DocumentElement;
                        nodeType = docEmailEnglish.DocumentElement.SelectSingleNode(@"/Email/Type");
                        nodeSubject = docEmailEnglish.DocumentElement.SelectSingleNode(@"/Email/Subject");
                        nodeBody = docEmailEnglish.DocumentElement.SelectSingleNode(@"/Email/Body");
                    }
                    else
                    {
                        root = docEmailSpanish.DocumentElement;
                        nodeType = docEmailSpanish.DocumentElement.SelectSingleNode(@"/Email/Type");
                        nodeSubject = docEmailSpanish.DocumentElement.SelectSingleNode(@"/Email/Subject");
                        nodeBody = docEmailSpanish.DocumentElement.SelectSingleNode(@"/Email/Body");
                    }

                    XmlNode childNode = nodeType.ChildNodes[0];

                    string typeInv = string.Empty;
                    if (childNode is XmlCDataSection)
                    {
                        XmlCDataSection bodySection = childNode as XmlCDataSection;
                        typeInv = bodySection.Value;
                    }

                    string subject = string.Empty;
                    childNode = nodeSubject.ChildNodes[0];
                    if (childNode is XmlCDataSection)
                    {
                        XmlCDataSection bodySection = childNode as XmlCDataSection;
                        subject = bodySection.Value;
                    }

                    subject = subject + "(" + elem.AgencyCode.Trim() + "_" + fileDate + ")"; ;

                    string body = string.Empty;
                    childNode = nodeBody.ChildNodes[0];
                    if (childNode is XmlCDataSection)
                    {
                        XmlCDataSection cdataSection = childNode as XmlCDataSection;
                        body = cdataSection.Value;
                    }

                    try
                    {
                        InvoiceAttachFile[] att = { new InvoiceAttachFile() { streamInfo = rs.StreamInfo.ToArray(),
                                                                              fileName = string.Format("{0}_{1}_{2}.pdf",
                                                                                                  elem.AgencyCode.Trim(),
                                                                                                  typeInv,
                                                                                                  fileDate) } };

                        EmailSender emailSender = new EmailSender(smtpServer, smtpUser, smtpPassword);

                        await emailSender.SendEmail(fromEmail, emails, subject, body, att);

                        await new DAFaxEmail().FaxEmailBatchDetailInsert(batchID, elem.AgencyCode.Trim(), DateTime.Now, "E");

                        await new DAStatement().UpdateFaxSent(elem.StatementId, "S", userName);

                        log.InfoFormat("User {0} sent statement {1} to {2} by Email {3} - {4}", userName, elem.StatementId, elem.AgencyCode, emails, batchID);

                    }
                    catch (Exception ex)
                    {
                        log.Error(string.Format("Statement {0} to {1} by email {2} - {3}", elem.StatementId, elem.AgencyCode, emails, batchID), ex);
                        await new DAFaxEmail().LogEmailErrorSendingInvoice(elem.AgencyEmail, ex.Message, userName);
                    }
                }
                else
                {
                    log.ErrorFormat("There was a error on generate PDF invoice for Send by E-mail AgencyCode: {0} - {1}", elem.AgencyCode, batchID);
                }

            }

            if (Interlocked.Decrement(ref emailsToSend) <= 0)
            {
                try
                {
                    await new DAFaxEmail().FaxEmailBatchClose(batchID, "E");
                }
                catch (Exception ex)
                {
                    log.Error(string.Format("There was a error on closing the batch email invoices - {0}", batchID), ex);
                }
            }
        }

        private async Task<string> GetValidEmails(string agencyCode, string emails)
        {
            string result = string.Empty;

            if (string.IsNullOrEmpty(emails))
            {
                log.ErrorFormat("Invalid Agency Email {0} {1}", agencyCode, emails);
                return result;
            }

            var splitEmails = emails.Replace(",", ";").Trim().Split(';');

            foreach (var elem in splitEmails)
            {
                if (IsValidEmail(elem.Trim()))
                {
                    if (!string.IsNullOrEmpty(result))
                        result += ";";

                    result += elem.Trim();
                }
                else
                {
                    log.ErrorFormat("Invalid Agency Email {0} {1}", agencyCode, elem);
                    await new DAFaxEmail().LogEmailErrorSendingInvoice(elem, "Invalid Email", userName);
                }
            }
            return result;

        }
        private bool IsValidEmail(string Email)
        {
            bool result = false;

            if (Email == "")
                return result;

            Email = Email.Replace("'", "");

            Regex regex = new Regex(@"^[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$", RegexOptions.IgnoreCase);

            if (regex.IsMatch(Email))
                result = true;

            return result;
        }
        #endregion
    }
}
