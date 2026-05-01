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
    public class BSSentWiresRpt
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(BSSentWiresRpt));

        public BSSentWiresRpt()
        {

        }


        public InvoiceResultStream SentWiresRptToStreamPDF(InvoiceParameters param)
        {
            //log.Info("Stream To PDF");
            InvoiceResultStream rs = new InvoiceResultStream();
            try
            {
                rs = ToolAgencyOverview.SentWiresRptToStreamPDF(param);
            }
            catch (Exception ex)
            {
                log.ErrorFormat("SentWiresRptToStreamPDF ERROR: {0}", ex.Message);
                rs.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return rs;
        }
        public InvoiceResultStream SentWiresRptSmallToStreamPDF(InvoiceParameters param)
        {
            //log.Info("Stream To PDF");
            InvoiceResultStream rs = new InvoiceResultStream();
            try
            {
                rs = ToolAgencyOverview.SentWiresRptSmallToStreamPDF(param);
            }
            catch (Exception ex)
            {
                log.ErrorFormat("SentWiresRptSmallToStreamPDF ERROR: {0}", ex.Message);
                rs.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return rs;
        }

        public InvoiceResultStream SentWiresRptSmallToStream(InvoiceParameters param, string format)
        {
            //log.Info("Stream To PDF");
            InvoiceResultStream rs = new InvoiceResultStream();
            try
            {
                rs = ToolAgencyOverview.SentWiresRptSmallToStream(param, format);
            }
            catch (Exception ex)
            {
                log.ErrorFormat("SentWiresRptSmallToStreamPDF ERROR: {0}", ex.Message);
                rs.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return rs;
        }

        public InvoiceResultStream SentWiresRptToStream(InvoiceParameters param, string format)
        {
            //log.Info("Stream To PDF");
            InvoiceResultStream rs = new InvoiceResultStream();
            try
            {
                rs = ToolAgencyOverview.SentWiresRptToStream(param, format);
            }
            catch (Exception ex)
            {
                log.ErrorFormat("SentWiresRptSmallToStreamPDF ERROR: {0}", ex.Message);
                rs.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return rs;
        }

    }
}
