using DevExpress.XtraReports.UI;
using System;
using System.Drawing;

namespace WebAPIReports.Reports.AgencyOverview
{
    public partial class CombinedReportSummaryChecks : DevExpress.XtraReports.UI.XtraReport
    {
        public string TotalChecks { get; set; }
        public string TotalAmount { get; set; }
        public string TotalFee { get; set; }
        public string TotalDeposit { get; set; }
        public string TotalComm { get; set; }
        public string TotalVoid { get; set; }
        public CombinedReportSummaryChecks()
        {
            InitializeComponent();
        }

        private void CombinedReportSummaryChecks_DataSourceDemanded(object sender, EventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.ChecksConnectionString);
            (sender as CombinedReportSummaryChecks).DataSourceChecks.ConnectionParameters = dataConnectionParametersBase;

        }

        private void DataSourceChecks_ConfigureDataConnection(object sender, DevExpress.DataAccess.Sql.ConfigureDataConnectionEventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.ChecksConnectionString);

            if (e.ConnectionName == ReportCommon.ChecksConnectionString)
                e.ConnectionParameters = dataConnectionParametersBase;
        }

        private void xrTableCell5_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            TotalChecks = (sender as XRTableCell).Text;
        }

        private void xrTableCell10_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            TotalAmount = (sender as XRTableCell).Text?.Replace("$", string.Empty);
        }
        private void hVoid_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            TotalVoid = (sender as XRTableCell).Text?.Replace("$", string.Empty);
        }

        private void hCommission_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            TotalComm = (sender as XRTableCell).Text?.Replace("$", string.Empty);
        }

        private void hDeposit_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            TotalDeposit = (sender as XRTableCell).Text?.Replace("$", string.Empty);
        }

        private void hFee_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            TotalFee = (sender as XRTableCell).Text?.Replace("$", string.Empty);
        }
    }
}
