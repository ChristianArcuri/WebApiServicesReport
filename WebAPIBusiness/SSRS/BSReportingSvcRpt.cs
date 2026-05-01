using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIBusiness.Utilities;
using WebAPIDataAccess.SSRS;
using WEbAPIEntities.Common;
using WEbAPIEntities.SSRS;

namespace WebAPIBusiness.SSRS
{
    public class BSReportingSvcRpt
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(BSReportingSvcRpt));

        public BSReportingSvcRpt() { }

        public SSRSResponseStream FxRptToStreamPDF(ReportParameters param)
        {
            var result = new SSRSResponseStream();
            DAReportingSvc svc = new DAReportingSvc();

            try
            {
                result = svc.FxRptToStreamPDF(param);

                if (param.Fax && string.IsNullOrEmpty(result.ErrorMessage))
                {
                    SendFaxReport(param, result.FaxFilePath);
                    svc.DeleteFaxTempReport(param.AgencyCode);
                }
            }
            catch (Exception ex)
            {
                svc.DeleteFaxTempReport(param.AgencyCode);
                log.ErrorFormat("FxRptToStreamPDF ERROR: {0}", ex.Message);
                result.SetMessages(ErrorResult.UnexpectedError, ex.Message);
                result.StreamInfo = null;
            }

            return result;
        }

        private void SendFaxReport(ReportParameters param, string faxFilePath)
        {
            var faxServerIP = new WebAPIBusiness.WireTransac.BSConfigParamWT().GetValueFromConfigParam("ServerIpFaxes"); //ConfigurationManager.AppSettings["FaxAppServerIP"].ToString();
            FaxSender.SendMarketingFaxInt(faxServerIP, param.AgencyCode, param.UserName, param.ComputerName, faxFilePath);
        }
    }
}
