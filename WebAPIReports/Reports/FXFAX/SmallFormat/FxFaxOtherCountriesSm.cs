using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using WebAPIReports.Reports.Invoice;

namespace WebAPIReports.Reports.FXFAX
{
    public partial class FxFaxOtherCountriesSm : DevExpress.XtraReports.UI.XtraReport
    {
        public FxFaxOtherCountriesSm()
        {
            InitializeComponent();
        }

        private void FxFaxOtherCountries_DataSourceDemanded(object sender, EventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WirePricingConnectionString);
            (sender as FxFaxOtherCountriesSm).WirePricing.ConnectionParameters = dataConnectionParametersBase;
        }

    }
}
