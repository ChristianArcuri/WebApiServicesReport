using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using WebAPIReports.Reports.Invoice;

namespace WebAPIReports.Reports.FXFAX
{
    public partial class FxFaxByCountrySm : DevExpress.XtraReports.UI.XtraReport
    {
        public FxFaxByCountrySm()
        {
            InitializeComponent();
        }

        private void FxFaxByCountrySm_DataSourceDemanded(object sender, EventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WirePricingConnectionString);
            (sender as FxFaxByCountrySm).WirePricing.ConnectionParameters = dataConnectionParametersBase;
        }

        private void xrLabel3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var fx = Convert.ToDecimal(GetCurrentColumnValue("ExRate"));
            int fontSize = fx >= 100 && fx < 1000 ? 42 : (fx < 100 ? 48 : 36);
            int topPadding = fx >= 100 && fx < 1000 ? 25 : (fx < 100 ? 25 : 30);

            (sender as XRLabel).Font = new Font((sender as XRLabel).Font.FontFamily, fontSize, FontStyle.Bold);
            (sender as XRLabel).Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, topPadding, 0);
        }

    }
}
