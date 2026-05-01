using DevExpress.XtraReports.UI;
using System;
using System.Drawing;
using System.Globalization;
using System.Threading;
using WebAPIReports.Reports.Invoice;

namespace WebAPIReports.Reports.AgencyOverview
{
    public partial class CombinedReportSummaryMO : DevExpress.XtraReports.UI.XtraReport
    {
        public string TotalMO { get; set; }
        public string TotalAmount { get; set; }
        public string TotalFee { get; set; }
        public string TotalDeposit { get; set; }
        public string TotalComm { get; set; }
        public string TotalVoid { get; set; }

        public CombinedReportSummaryMO()
        {
            InitializeComponent();
        }

        private void CombinedReportWires_DataSourceDemanded(object sender, EventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.MoneyOrderConnectionString);
            (sender as CombinedReportSummaryMO).sqlDataSource1.ConnectionParameters = dataConnectionParametersBase;

        }

        private void DataSourceMO_ConfigureDataConnection(object sender, DevExpress.DataAccess.Sql.ConfigureDataConnectionEventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.MoneyOrderConnectionString);

            if (e.ConnectionName == ReportCommon.MoneyOrderConnectionString)
                e.ConnectionParameters = dataConnectionParametersBase;
        }

        private void xrTableCell5_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            TotalMO = (sender as XRTableCell).Text;
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
