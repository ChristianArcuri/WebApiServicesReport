using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using WebAPIReports.Reports.Invoice;

namespace WebAPIReports.Reports.FXFAX
{
    public partial class FxFaxMultiples : DevExpress.XtraReports.UI.XtraReport
    {
        public FxFaxMultiples()
        {
            InitializeComponent();
        }

        private void FxFaxMultiples_DataSourceDemanded(object sender, EventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WirePricingConnectionString);
            (sender as FxFaxMultiples).WirePricing.ConnectionParameters = dataConnectionParametersBase;

        }

    }
}
