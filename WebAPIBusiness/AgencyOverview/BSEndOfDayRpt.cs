using System;
using WEbAPIEntities.Common;
using WEbAPIEntities.Invoice;
using WebAPIReports.Tools.AgencyOverview;

namespace WebAPIBusiness.AgencyOverview
{
    public class BSEndOfDayRpt
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(BSEndOfDayRpt));

        public BSEndOfDayRpt()
        {

        }


        public InvoiceResultStream EndOfDayRptToStreamPDF(InvoiceParameters param)
        {
            //log.Info("Stream To PDF");
            InvoiceResultStream rs = new InvoiceResultStream();
            try
            {
                rs = ToolAgencyOverview.EndOfDayRptToStreamPDF(param);
            }
            catch (Exception ex)
            {
                log.ErrorFormat("EndOfDayRptToStreamPDF ERROR: {0}", ex.Message);
                rs.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return rs;
        }

        public InvoiceResultStream EndOfDayRptToStreamPDFV2(InvoiceParameters param)
        {
            //log.Info("Stream To PDF");
            InvoiceResultStream rs = new InvoiceResultStream();
            try
            {
                rs = ToolAgencyOverview.EndOfDayRptToStreamPDFV2(param);
            }
            catch (Exception ex)
            {
                log.ErrorFormat("EndOfDayRptToStreamPDFV2 ERROR: {0}", ex.Message);
                rs.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return rs;
        }

        public InvoiceResultStream EndOfDayRptToStreamPDFV3(InvoiceParameters param)
        {
            //log.Info("Stream To PDF");
            InvoiceResultStream rs = new InvoiceResultStream();
            try
            {
                rs = ToolAgencyOverview.EndOfDayRptToStreamPDFV3(param);
            }
            catch (Exception ex)
            {
                log.ErrorFormat("EndOfDayRptToStreamPDFV3 ERROR: {0}", ex.Message);
                rs.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return rs;
        }
    }
}
