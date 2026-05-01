using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using WebAPIReports.Reports.Invoice;

namespace WebAPIReports.Reports.Checks
{
    public partial class RptCompanyChecksProcessed : DevExpress.XtraReports.UI.XtraReport
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(RptCompanyChecksProcessed));
        public RptCompanyChecksProcessed()
        {
            InitializeComponent();
            if (this.Landscape)
            {
                ReportCommon.SetAsLandscapeReport(this.Parameters, this.xrSubreporHeaderCustom, this.xrSubreportFooterCustom);
            }
        }

        private void ChecksProcessed_DataSourceDemanded(object sender, EventArgs e)
        {
            try
            {
                var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.ChecksConnectionString);
                (sender as RptCompanyChecksProcessed).ChecksConnectionString.ConnectionParameters = dataConnectionParametersBase;
            }
            catch (Exception ex)
            {
                log.ErrorFormat("RptCompanyChecksProcessed ERROR: {0}", ex.Message);
            }
        }

        private void RptChecksProcessed_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var isVisible = GetCurrentRow() != null;
            EmptyLeyend.Visible = !isVisible;
            xrPanel1.Visible = isVisible;
            xrPanel2.Visible = isVisible;
            xrPanel3.Visible = isVisible;
            xrPanel4.Visible = isVisible;
        }
    }
}
