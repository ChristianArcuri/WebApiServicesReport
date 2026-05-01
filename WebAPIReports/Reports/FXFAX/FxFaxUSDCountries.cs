using System;
using DevExpress.XtraReports.UI;
using DevExpress.DataAccess.ConnectionParameters;

namespace WebAPIReports.Reports.FXFAX
{
    public partial class FxFaxUSDCountries : DevExpress.XtraReports.UI.XtraReport
    {
        public FxFaxUSDCountries()
        {
            InitializeComponent();
        }

        private void FxFaxUSDCountries_DataSourceDemanded(object sender, EventArgs e)
        {
            FxFaxUSDCountries rpt = sender as FxFaxUSDCountries;
            rpt.WirePricing.ConnectionParameters = new MsSqlConnectionParameters();
            rpt.WirePricing.Connection.ConnectionString = WebAPIDataAccess.DAConnectionStrings.WirePricingReadOnlyConnectionString;
        }

        private void xrLabel1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            (sender as XRLabelExtension).BackColor = Parameters["Color"].Value as string;
        }
    }
}
