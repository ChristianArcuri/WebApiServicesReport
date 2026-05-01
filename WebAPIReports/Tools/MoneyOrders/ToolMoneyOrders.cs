using WEbAPIEntities.Common;
using WebAPIReports.Reports.MoneyOrder;
using WebAPIReports.Reports.MoneyOrder.SmallFormat;

namespace WebAPIReports.Tools.MoneyOrders
{
   public class ToolMoneyOrders:Tools
    {
       private readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(ToolMoneyOrders));


        #region publics
        public TResultStream MOInvoiceToStream(TParameters param, string format)
        {
            var report = new RptCompanyMOInvoice();
            return ReportToStream(report, param, format);
        }

        public TResultStream MOInvoiceToStreamSmall(TParameters param, string format)
        {
            RptMOInvoiceSm report = new RptMOInvoiceSm();
            return ReportToStream(report, param, format);
        }

        public TResultStream MOIssuedToStream(TParameters param, string format)
        {
            RptCompanyMOIssued report = new RptCompanyMOIssued();
            return ReportToStream(report, param, format);
        }

        public TResultStream MOIssuedToStreamSmall(TParameters param, string format)
        {
            RptMOIssuedSm report = new RptMOIssuedSm();
            return ReportToStream(report, param, format);
        }
        #endregion
    }
}
