using System;

namespace WebAPIReports.Reports.Checks
{
    public partial class RptCompanyChecksRegulatoryLog : DevExpress.XtraReports.UI.XtraReport
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(RptCompanyChecksRegulatoryLog));
        public RptCompanyChecksRegulatoryLog()
        {
            InitializeComponent();
            if (this.Landscape)
            {
                ReportCommon.SetAsLandscapeReport(this.Parameters, this.xrSubreporHeaderCustom, this.xrSubreportFooterCustom);
            }
        }

        private void RptChecksRegulatoryLog_DataSourceDemanded(object sender, EventArgs e)
        {
            try
            {
                var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.ChecksConnectionString);
                (sender as RptCompanyChecksRegulatoryLog).Checks.ConnectionParameters = dataConnectionParametersBase;
            }
            catch (Exception ex)
            {
                log.ErrorFormat("RptCompanyChecksRegulatoryLog ERROR: {0}", ex.Message);
            }
        }

        private void RptChecksRegulatoryLog_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var isVisible = GetCurrentRow() != null;
            EmptyLeyend.Visible = !isVisible;
            xrPanel1.Visible = isVisible;
            xrPanel2.Visible = isVisible;
            xrPanel3.Visible = isVisible;
            xrPanel4.Visible = isVisible;
            xrPanel5.Visible = isVisible;
            xrPanel6.Visible = isVisible;
        }
    }
}
