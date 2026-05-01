using System;
using System.Drawing;
using DevExpress.XtraReports.UI;
using DevExpress.DataAccess.ConnectionParameters;

namespace WebAPIReports.Reports.FXFAX
{
    public partial class FxFaxByCountry : DevExpress.XtraReports.UI.XtraReport
    {
        public FxFaxByCountry()
        {
            InitializeComponent();
        }

        private void FxFaxByCountry_DataSourceDemanded(object sender, EventArgs e)
        {
            FxFaxByCountry rpt = sender as FxFaxByCountry;
            rpt.WirePricing.ConnectionParameters = new MsSqlConnectionParameters();
            rpt.WirePricing.Connection.ConnectionString = WebAPIDataAccess.DAConnectionStrings.WirePricingReadOnlyConnectionString;
        }

        private void xrLabel3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {            
            decimal valueToFormat = (xrLabel3.Value != null) ? (decimal)xrLabel3.Value : 0m;
            xrLabel3.Text = (Math.Truncate(valueToFormat * 100) / 100).ToString("$0.00");            
            var fx = Convert.ToDecimal(GetCurrentColumnValue("ExRate"));
            int fontSize = fx >= 100 && fx < 1000 ? 65 : (fx < 100 ? 75 : 50);
            int topPadding = fx >= 100 && fx < 1000 ? 0 : (fx < 100 ? 10 : 20);

            (sender as XRLabel).Font = new Font(ReportCommon.Font, fontSize, FontStyle.Bold);
            (sender as XRLabel).Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, topPadding, 0);
        }

        private void xrTableCell2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrTableCell2.Text = (Math.Truncate((decimal)xrTableCell2.Value * 100) / 100).ToString("$0.00");
        }
    }
}
