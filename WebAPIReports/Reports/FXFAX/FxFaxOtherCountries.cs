using System;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.XtraReports.UI;

namespace WebAPIReports.Reports.FXFAX
{
    public partial class FxFaxOtherCountries : DevExpress.XtraReports.UI.XtraReport
    {
        public FxFaxOtherCountries()
        {
            InitializeComponent();
        }

        private void FxFaxOtherCountries_DataSourceDemanded(object sender, EventArgs e)
        {
            FxFaxOtherCountries rpt = sender as FxFaxOtherCountries;
            rpt.WirePricing.ConnectionParameters = new MsSqlConnectionParameters();
            rpt.WirePricing.Connection.ConnectionString = WebAPIDataAccess.DAConnectionStrings.WirePricingReadOnlyConnectionString;
        }

        private void xrTableCell3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal valueToFormat = (xrTableCell3.Value != null) ? (decimal)xrTableCell3.Value : 0m;
            xrTableCell3.Text = (Math.Truncate(valueToFormat * 100) / 100).ToString("$0.00");
        }

        private void xrLabel1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            (sender as XRLabelExtension).BackColor = Parameters["Color"].Value as string;
        }
    }
}
