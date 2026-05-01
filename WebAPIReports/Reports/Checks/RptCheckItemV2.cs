using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using WebAPIReports.Reports.Invoice;

namespace WebAPIReports.Reports.Checks
{
    public partial class RptCheckItemsV2 : DevExpress.XtraReports.UI.XtraReport
    {
        public RptCheckItemsV2()
        {
            InitializeComponent();
        }

        private void RptCheckItems_DataSourceDemanded(object sender, EventArgs e)
        {
            try
            {
                var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.ChecksConnectionString);
                (sender as RptCheckItemsV2).Checks.ConnectionParameters = dataConnectionParametersBase;
            }
            catch
            {

            }
        }
    }
}
