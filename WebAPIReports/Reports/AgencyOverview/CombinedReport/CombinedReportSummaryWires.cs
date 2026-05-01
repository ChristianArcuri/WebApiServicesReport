using DevExpress.XtraReports.UI;
using System;

namespace WebAPIReports.Reports.AgencyOverview
{
    public partial class CombinedReportSummaryWires : DevExpress.XtraReports.UI.XtraReport
    {
        public string TotalWires { get; set; }
        public string TotalAmount { get; set; }
        public string TotalFee { get; set; }
        public string TotalDeposit { get; set; }
        public string TotalComm { get; set; }
        public string TotalVoid { get; set; }

        public CombinedReportSummaryWires()
        {
            InitializeComponent();

            TotalAmount = xrTableCell1.Value?.ToString();
            TotalAmount = xrTableCell1.Text;

            this.xrTableCell2.DataBindings.AddRange(new XRBinding[] {
            new XRBinding(this.Color, "HexaForeColor", string.Empty)});
        }

        private void CombinedReportWires_DataSourceDemanded(object sender, EventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);
            (sender as CombinedReportSummaryWires).DataSourceWires.ConnectionParameters = dataConnectionParametersBase;
     
        }

        private void DataSourceWires_ConfigureDataConnection(object sender, DevExpress.DataAccess.Sql.ConfigureDataConnectionEventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);

            if (e.ConnectionName == ReportCommon.WireTransacDB)
                e.ConnectionParameters = dataConnectionParametersBase;
        }

        private void xrTableCell5_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            TotalWires = (sender as XRTableCell).Text;
        }

        private void xrTableCell10_PrintOnPage_1(object sender, PrintOnPageEventArgs e)
        {
            TotalAmount = (sender as XRTableCell).Text?.Replace("$", string.Empty);
        }

        private void xrTableCell3_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            TotalFee = (sender as XRTableCell).Text?.Replace("$", string.Empty);
        }

        private void xrTableCell4_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            TotalDeposit = (sender as XRTableCell).Text?.Replace("$", string.Empty);
        }

        private void xrTableCell6_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            TotalComm = (sender as XRTableCell).Text?.Replace("$", string.Empty);
        }

        private void xrTableCell7_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            TotalVoid = (sender as XRTableCell).Text;
        }
    }
}
