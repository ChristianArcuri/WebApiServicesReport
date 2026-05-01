using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WEbAPIEntities.Invoice;
using WEbAPIEntities.Common;
using WEbAPIEntities.FXFAX;

namespace WebAPIDataAccess.FAXOutgoing
{
    public class DAFaxEmail : DABase
    {
        protected override string ConnectionString
        {
            get { return DAConnectionStrings.FaxOutgoingConnectionString; }
        }

        #region InvoicesFax
        public async Task<int> FaxEmailBatchCreate(string userName, DateTime startTime)
        {
            var command = GetStoreProcedureCommand("LogAgFaxInvoicesBatch_Create");
            command.Parameters.Add(CreateParameter("@UserName", userName));
            command.Parameters.Add(CreateParameter("@FaxStartTime", startTime));

            var result = await ExecuteScalarAsync(command);
            return result != null ? Convert.ToInt32(result): -1;
        }

        public async Task FaxEmailBatchClose(int batchID, string sendingMethod)
        {
            var command = GetStoreProcedureCommand("LogAgFaxInvoicesBatch_Close");
            command.Parameters.Add(CreateParameter("@BatchID", batchID.ToString()));
            command.Parameters.Add(CreateParameter("@SendingMethod", sendingMethod));
            await ExecuteNonQueryAsync(command);
        }

        public async Task FaxEmailBatchDetailInsert(int batchID, string agencyCode, DateTime sendingTime, string sendingMethod)
        {
            var command = GetStoreProcedureCommand("LogAgFaxInvoicesBatchDetail_Insert");
            command.Parameters.Add(CreateParameter("@BatchID", batchID));
            command.Parameters.Add(CreateParameter("@AgencyCode", agencyCode));
            command.Parameters.Add(CreateParameter("@SentTime", sendingTime));
            command.Parameters.Add(CreateParameter("@SendingMethod", sendingMethod));

            await ExecuteNonQueryAsync(command);
        }

        public InvoiceResultBatch FaxEmailBatchInfo(int batchID)
        {
            InvoiceResultBatch result = new InvoiceResultBatch();

            try
            { 
                var command = GetStoreProcedureCommand("LogAgFaxInvoicesBatch_GetStatus");
                command.Parameters.Add(CreateParameter("@BatchID", batchID));
          
                DataTable dt = ExecuteDataTable(command);
                if (dt.Rows.Count > 0)
                {
                    result.BatchID = batchID;
                    result.EmailSent = dt.Rows[0]["EmailProcessed"] is DBNull ? 0 : Convert.ToInt32(dt.Rows[0]["EmailProcessed"]);
                    result.FaxesSent = dt.Rows[0]["FaxProcessed"] is DBNull ? 0 : Convert.ToInt32(dt.Rows[0]["FaxProcessed"]);
                    result.IsProcessing = Convert.ToBoolean(dt.Rows[0]["IsProcessing"]);
                    result.LastAgencyFaxProcessed = dt.Rows[0]["LastAgFaxProcessed"] as string;
                    result.LastAgencyEmailProcessed = dt.Rows[0]["LastAgEmailProcessed"] as string;
                }
            }
            catch (Exception ex)
            {
                result.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return result;
        }

        public List<InvoiceBatchInfo> FaxEmailLogRead()
        {
            List<InvoiceBatchInfo> result = new List<InvoiceBatchInfo>();

            try { 
                var command = GetStoreProcedureCommand("LogAgFaxInvoices_Read");
         
               DataTable dt = ExecuteDataTable(command);
               foreach(DataRow row in dt.Rows)
               {
                    result.Add(new InvoiceBatchInfo()
                    {
                        BatchID = Convert.ToInt32(row["ID"]),
                        TotalFaxes = Convert.ToInt32(row["TotalFaxes"]),
                        FaxStartTime = Convert.ToString(row["FaxStartTime"]),
                        FaxEndTime = Convert.ToString(row["FaxEndTime"]),
                        FaxTime = Convert.ToInt32(row["FaxTime"]),
                        TotalEmails = Convert.ToInt32(row["TotalEmails"]),
                        EmailStartTime = Convert.ToString(row["EMailStartTime"]),
                        EmailEndTime = Convert.ToString(row["EMailEndTime"]),
                        EmailTime = Convert.ToInt32(row["EmailTime"]),
                        Created = Convert.ToDateTime(row["Created"]),
                        UserName = Convert.ToString(row["UserName"]),
                        EmailsError = Convert.ToString(row["EmailsError"])
                    });
               
         
                }
            }
            catch (Exception ex)
            {
                throw ex; 
            }
            return result;
        }

        public async Task LogEmailErrorSendingInvoice(string email, string errorMsg, string userName)
        {
            var command = GetStoreProcedureCommand("LogEmailErrorSendingInvoice");
            command.Parameters.Add(CreateParameter("@EMail", email));
            command.Parameters.Add(CreateParameter("@ErrorMsg", errorMsg));
            command.Parameters.Add(CreateParameter("@UserName", userName));

            await ExecuteNonQueryAsync(command);
        }

        #endregion

        #region FXFax

        public async Task<int> FxFaxBatchCreate(string userName, DateTime startTime)
        {
            var command = GetStoreProcedureCommand("LogAgFxFaxBatch_Create");
            command.Parameters.Add(CreateParameter("@UserName", userName));
            command.Parameters.Add(CreateParameter("@FaxStartTime", startTime));

            var result = await ExecuteScalarAsync(command);
            return result != null ? Convert.ToInt32(result) : -1;
        }

        public async Task FxFaxBatchClose(int batchID)
        {
            var command = GetStoreProcedureCommand("LogAgFxFaxBatch_Close");
            command.Parameters.Add(CreateParameter("@BatchID", batchID.ToString()));
        
            await ExecuteNonQueryAsync(command);

        }

        public async Task FxFaxBatchDetailInsert(int batchID, string agencyCode, DateTime sendingTime)
        {
            var command = GetStoreProcedureCommand("LogAgFxFaxBatchDetail_Insert");
            command.Parameters.Add(CreateParameter("@BatchID", batchID));
            command.Parameters.Add(CreateParameter("@AgencyCode", agencyCode));
            command.Parameters.Add(CreateParameter("@SentTime", sendingTime));
      
            await ExecuteNonQueryAsync(command);

        }

        public FxFaxResultBatch FxFaxBatchInfo(int batchID)
        {
            FxFaxResultBatch result = new FxFaxResultBatch();

            try
            {
                var command = GetStoreProcedureCommand("LogAgFxFaxBatch_GetStatus");
                command.Parameters.Add(CreateParameter("@BatchID", batchID));

                DataTable dt = ExecuteDataTable(command);
                if (dt.Rows.Count > 0)
                {
                    result.BatchID = batchID;
                    result.FaxesSent = dt.Rows[0]["FaxProcessed"] is DBNull ? 0 : Convert.ToInt32(dt.Rows[0]["FaxProcessed"]);
                    result.IsProcessing = Convert.ToBoolean(dt.Rows[0]["IsProcessing"]);
                    result.LastAgencyFaxProcessed = dt.Rows[0]["LastAgFaxProcessed"] as string;
                 }
            }
            catch (Exception ex)
            {
                result.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return result;
        }  

        #endregion
    }
}
