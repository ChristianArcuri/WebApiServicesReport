using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using WebAPIReports.Reports.Invoice;

namespace WebAPIReports.Reports.Checks
{
    public partial class RptChecksBatch : DevExpress.XtraReports.UI.XtraReport
    {
        public RptChecksBatch()
        {
            InitializeComponent();
        }

        private void ChecksProcessed_DataSourceDemanded(object sender, EventArgs e)
        {
            try
            {
                var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.ChecksConnectionString);
                (sender as RptChecksBatch).ChecksConnectionString.ConnectionParameters = dataConnectionParametersBase;
            }
            catch
            {

            }
        }

        private void RptChecksBatch_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var currRow = GetCurrentRow();
            var ChkId = (int)GetCurrentColumnValue("CheckId");
            var visible = currRow != null && ChkId != 0 ? true : false;
            EmptyLeyend.Visible = !visible;
            xrPanel1.Visible = visible;
            xrPanel2.Visible = visible;
            xrPanel3.Visible = visible;
        }
    }
}
