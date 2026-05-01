using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEbAPIEntities.Common;
using WEbAPIEntities.Invoice;
using WebAPIReports.Tools.AgencyOverview;

namespace WebAPIBusiness.AgencyOverview
{
    public class BSCombinedRpt
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(BSSentWiresRpt));

        public BSCombinedRpt()
        {

        }

        public InvoiceResultStream CombinedRptToStreamPDF(InvoiceParameters param)
        {
            //log.Info("Stream To PDF");
            InvoiceResultStream rs = new InvoiceResultStream();
            try
            {
                rs = ToolAgencyOverview.CombinedRptToStreamPDF(param);
            }
            catch (Exception ex)
            {
                log.ErrorFormat("CombinedRptToStreamPDF ERROR: {0}", ex.Message);
                rs.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return rs;
        }

        public InvoiceResultStream CombinedSummaryRptToStreamPDF(InvoiceParameters param)
        {
            //log.Info("Stream To PDF");
            InvoiceResultStream rs = new InvoiceResultStream();
            try
            {
                rs = ToolAgencyOverview.CombinedSummaryRptToStreamPDF(param);
            }
            catch (Exception ex)
            {
                log.ErrorFormat("CombinedSummaryRptToStreamPDF ERROR: {0}", ex.Message);
                rs.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return rs;
        }
    }
}
