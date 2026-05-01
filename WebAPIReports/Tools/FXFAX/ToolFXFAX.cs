using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEbAPIEntities.Common;
using WebAPIReports.Reports.FXFAX;

namespace WebAPIReports.Tools.FXFAX
{
    public class ToolFXFAX : Tools
    {
        private readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(ToolFXFAX));
      
        #region public

        public TResultStream FXFAXToStream(TParameters param, string format)
        {
            ExchangeRateReport report = new ExchangeRateReport();
            return ReportToStream(report, param, format);
        }

        public TResult FXFAXToPDFFile(TParameters param, string fpath)
        {
            ExchangeRateReport report = new ExchangeRateReport();
            return ReportToFilePDF(report, param, fpath);
        }

        public TResultStream FXFAXMultiplesToStream(TParameters param, string format)
        {
            FxFaxMultiples report = new FxFaxMultiples();
            return ReportToStream(report, param, format);
        }

        public TResultStream FXFAXSmallToStream(TParameters param, string format)
        {
            FxFaxMainSm report = new FxFaxMainSm();
            return ReportToStream(report, param, format);
        }

       
        #endregion

    }
}
