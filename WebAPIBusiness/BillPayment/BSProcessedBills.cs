using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEbAPIEntities.Common;
using WEbAPIEntities.Invoice;
using WebAPIReports.Tools.BillPayment;

namespace WebAPIBusiness.BillPayment
{
    public class BSProcessedBills
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(BSProcessedBills));

        public BSProcessedBills()
        {
        }
        public InvoiceResultStream ProcessedBillsRptToStreamPDF(InvoiceParameters param)
        {
            //log.Info("Stream To PDF");
            InvoiceResultStream rs = new InvoiceResultStream();
            try
            {
                rs = ToolBillPayment.ProcessedBillsRptToStreamPDF(param);
            }
            catch (Exception ex)
            {
                log.ErrorFormat("ProcessedBillsRptToStreamPDF ERROR: {0}", ex.Message);
                rs.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return rs;
        }
    }
}
