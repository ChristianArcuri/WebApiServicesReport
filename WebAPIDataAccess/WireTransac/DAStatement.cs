using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WebAPIDataAccess.WireTransac
{
    public class DAStatement : DABase
    {
        protected override string ConnectionString
        {
            get { return DAConnectionStrings.WireTransacConnectionString; }
        }
        public async Task UpdateFaxSent(string statementId, string status, string user)
        {
            var command = GetStoreProcedureCommand("Acc_Invoice_UpdateFaxSent");
            command.Parameters.Add(CreateParameter("@StatementId", statementId.ToString()));
            command.Parameters.Add(CreateParameter("@FaxStatementStatus", status));
            command.Parameters.Add(CreateParameter("@FaxStatementUser", user));

            await ExecuteNonQueryAsync(command);
        }

        public async Task UpdateFaxSentAsync(string statementId, string status, string user)
        {
            var command = GetStoreProcedureCommand("Acc_Invoice_UpdateFaxSent");
            command.Parameters.Add(CreateParameter("@StatementId", statementId.ToString()));
            command.Parameters.Add(CreateParameter("@FaxStatementStatus", status));
            command.Parameters.Add(CreateParameter("@FaxStatementUser", user));

            await ExecuteNonQueryAsync(command);
        }
    

        public DataTable InvoicePayments(string statementId)
        {
            var command = GetStoreProcedureCommand("Acc_Invoice_Payments");
            command.Parameters.Add(CreateParameter("@StatementId", statementId));

            return ExecuteDataTable(command);
        }

        public DataTable InvoiceCancellations(string statementId)
        {
            var command = GetStoreProcedureCommand("Acc_Invoice_Cancellations");
            command.Parameters.Add(CreateParameter("@StatementId", statementId));

            return ExecuteDataTable(command);
        }
        public DataTable InvoiceOther(string statementId)
        {
            var command = GetStoreProcedureCommand("Acc_Invoice_OtherCreditsDebits");
            command.Parameters.Add(CreateParameter("@StatementId", statementId));

            return ExecuteDataTable(command);
        }

        public DataTable InvoiceWires(string statementId)
        {
            var command = GetStoreProcedureCommand("Acc_Invoice_WireTransfers");
            command.Parameters.Add(CreateParameter("@StatementId", statementId));

            return ExecuteDataTable(command);
        }

        public DataTable InvoiceHeader(string statementId)
        {
            var command = GetStoreProcedureCommand("Acc_Invoice_Header");
            command.Parameters.Add(CreateParameter("@StatementId", statementId));

            return ExecuteDataTable(command);
        }

        public DataTable InvoiceInTransit(string statementId, int languageId)
        {
            var command = GetStoreProcedureCommand("Acc_SndDailyStatements_PrintDepositsInTransit");
            command.Parameters.Add(CreateParameter("@StatementId", statementId));
            command.Parameters.Add(CreateParameter("@LanguageId", languageId));

            return ExecuteDataTable(command);
        }

        public DataTable InvoiceBillPayment(string statementId)
        {
            var command = GetStoreProcedureCommand("Acc_Invoice_BillPayment");
            command.Parameters.Add(CreateParameter("@StatementId", statementId));
          
            return ExecuteDataTable(command);
        }
    }       
}
