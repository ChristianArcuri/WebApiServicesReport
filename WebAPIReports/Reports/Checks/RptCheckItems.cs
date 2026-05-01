using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using WebAPIReports.Reports.Invoice;

namespace WebAPIReports.Reports.Checks
{
    public partial class RptCheckItems : DevExpress.XtraReports.UI.XtraReport
    {
        public RptCheckItems()
        {
            InitializeComponent();
        }

        private void RptCheckItems_DataSourceDemanded(object sender, EventArgs e)
        {
            try
            {
                var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.ChecksConnectionString);
                (sender as RptCheckItems).Checks.ConnectionParameters = dataConnectionParametersBase;
            }
            catch
            {

            }
        }

    }
}
