using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using WebAPIReports.Reports.Invoice;

namespace WebAPIReports.Reports.Checks
{
    public partial class CheckFeeCommissionsReport : DevExpress.XtraReports.UI.XtraReport
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(CheckFeeCommissionsReport));

        public CheckFeeCommissionsReport()
        {
            InitializeComponent();
            if (this.Landscape)
            {
                ReportCommon.SetAsLandscapeReport(this.Parameters, this.xrSubreporHeaderCustom, this.xrSubreportFooterCustom);
            }
        }

        private void RptCheckFeeCommissions_DataSourceDemanded(object sender, EventArgs e)
        {
            try
            {
                var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.ChecksConnectionString);
                (sender as CheckFeeCommissionsReport).Checks.ConnectionParameters = dataConnectionParametersBase;
            }
            catch(Exception ex)
            {
                log.ErrorFormat("CombinedRptToStreamPDF ERROR: {0}", ex.Message);
            }
        }

        private void RptCheckFeeCommissions_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var visible = GetCurrentRow() != null ? true : false;
            EmptyLeyend.Visible = !visible;
            xrPanel1.Visible = visible;
            xrPanel2.Visible = visible;
            xrPanel3.Visible = visible;
        }
    }
}
