using System;
using DevExpress.XtraReports.UI;
using System.Globalization;
using System.Collections.Generic;
using DevExpress.DataAccess.ConnectionParameters;

namespace WebAPIReports.Reports.FXFAX
{
    public partial class ExchangeRateReport : DevExpress.XtraReports.UI.XtraReport
    {
        readonly Queue<int> currentLanguage;
        public ExchangeRateReport()
        {
            InitializeComponent();
            currentLanguage = new Queue<int>();
        }

       
        private void xrLabel1_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            if (sender == null) return;
            string header = (sender as XRLabel).Text;
            DateTime dt = DateTime.Now;
            IFormatProvider fp = SetCultureInfo(currentLanguage.Dequeue() == 1?ReportCommon.CultureInfoEnUs:ReportCommon.CultureInfoEsMX);
            (sender as XRLabel).Text = string.Format(header,
                                                       dt.ToString(ReportCommon.StringFormatDay, fp),
                                                       dt.ToString(ReportCommon.StringFormatMonth, fp),
                                                       dt.Day.ToString(),
                                                       dt.Year.ToString()
                                                       ).ToUpper();
        }

        private CultureInfo SetCultureInfo(string culture)
        {
            return new CultureInfo(culture);
        }

        private void FxFaxMain_DataSourceDemanded(object sender, EventArgs e)
        {
            ExchangeRateReport rpt = sender as ExchangeRateReport;
            rpt.WireTransac.ConnectionParameters = new MsSqlConnectionParameters();
            rpt.WireTransac.Connection.ConnectionString = WebAPIDataAccess.DAConnectionStrings.WireTransacReadOnlyConnectionString;
        }

        protected override void BeforeReportPrint()
        {
            base.BeforeReportPrint();
            this.imxrule.Condition = $"Iif([CoBrandName]=='{ReportCommon.INTERMEX_BRAND_NAME}', true, false)";
            this.lanRule.Condition = $"Iif([CoBrandName]=='{ReportCommon.LAN_BRAND_NAME}', true, false)";
            if (int.TryParse(this.Parameters["LanguageId"].Value.ToString(), out int icurrentLanguage))
            {
                currentLanguage.Enqueue(icurrentLanguage);
            }
        }

    }
}
