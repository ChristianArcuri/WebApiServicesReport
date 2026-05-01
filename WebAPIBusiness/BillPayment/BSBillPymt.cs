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
    public class   BSBillPymt
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(BSBillPymt));

        public BSBillPymt()
        {
        }
        public InvoiceResultStream BillPymtEndOfDayRptToStreamPDF(InvoiceParameters param)
        {
            //log.Info("Stream To PDF");
            InvoiceResultStream rs = new InvoiceResultStream();
            try
            {
                rs = ToolBillPayment.BillPymtEndOfDayRptToStreamPDF(param);
            }
            catch (Exception ex)
            {
                log.ErrorFormat("BillPymtEndOfDayRptToStreamPDF ERROR: {0}", ex.Message);
                rs.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return rs;
        }
    }
}
