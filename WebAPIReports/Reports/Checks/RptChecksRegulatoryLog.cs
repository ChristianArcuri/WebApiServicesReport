using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using WebAPIReports.Reports.Invoice;

namespace WebAPIReports.Reports.Checks
{
    public partial class RptChecksRegulatoryLog : DevExpress.XtraReports.UI.XtraReport
    {
        public RptChecksRegulatoryLog()
        {
            InitializeComponent();
        }

        private void RptChecksRegulatoryLog_DataSourceDemanded(object sender, EventArgs e)
        {
            try
            {
                var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.ChecksConnectionString);
                (sender as RptChecksRegulatoryLog).Checks.ConnectionParameters = dataConnectionParametersBase;
            }
            catch
            {

            }
        }

        private void RptChecksRegulatoryLog_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var visible = GetCurrentRow() != null ? true : false;
            EmptyLeyend.Visible = !visible;
            xrPanel1.Visible = visible;
            xrPanel2.Visible = visible;
            xrPanel3.Visible = visible;
            xrPanel4.Visible = visible;
            xrPanel5.Visible = visible;
            xrPanel6.Visible = visible;
        }
    }
}
