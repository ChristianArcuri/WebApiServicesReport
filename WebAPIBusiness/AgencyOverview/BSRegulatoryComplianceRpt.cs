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
    public class BSRegulatoryComplianceRpt
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(BSRegulatoryComplianceRpt));

        public BSRegulatoryComplianceRpt()
        {
        }        

        public InvoiceResultStream RegulatoryComplianceRptToStream(InvoiceParameters param, string format)
        {
            //log.Info("Stream To PDF");
            InvoiceResultStream rs = new InvoiceResultStream();
            try
            {
                rs = ToolAgencyOverview.RegulatoryComplianceRptToStream(param, format);
            }
            catch (Exception ex)
            {
                log.ErrorFormat("RegulatoryComplianceRptSmallToStreamPDF ERROR: {0}", ex.Message);
                rs.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return rs;
        }

        public InvoiceResultStream RegulatoryComplianceRptToStreamV2(InvoiceParameters param, string format)
        {
            //log.Info("Stream To PDF");
            InvoiceResultStream rs = new InvoiceResultStream();
            try
            {
                rs = ToolAgencyOverview.RegulatoryComplianceRptToStreamV2(param, format);
            }
            catch (Exception ex)
            {
                log.ErrorFormat("RegulatoryComplianceRptSmallToStreamPDF ERROR: {0}", ex.Message);
                rs.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return rs;
        }
    }
}
