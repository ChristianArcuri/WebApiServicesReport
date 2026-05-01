using DevExpress.XtraReports.UI;
using System;
using WebAPIReports.Reports.Invoice;

namespace WebAPIReports.Reports.AgencyOverview
{
    public partial class EndOfDayCompanyReportSummaryWires : DevExpress.XtraReports.UI.XtraReport
    {
        public string TotalAmount { get; set; }
        public string TotalCash { get; set; }
        public string TotalCashBack { get; set; }
        public string TotalDebit { get; set; }

        public EndOfDayCompanyReportSummaryWires()
        {
            InitializeComponent();
            TotalAmount = xrLabel15.Value?.ToString();
            TotalAmount = xrLabel15.Text;
        }      

        private void EndOfDayReport_DataSourceDemanded(object sender, EventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);
            (sender as EndOfDayCompanyReportSummaryWires).sqlDataSource1.ConnectionParameters = dataConnectionParametersBase; 
                  
        }

        private void sqlDataSource1_ConfigureDataConnection(object sender, DevExpress.DataAccess.Sql.ConfigureDataConnectionEventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);

            if (e.ConnectionName == ReportCommon.WireTransacDB)
                e.ConnectionParameters = dataConnectionParametersBase;
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var row = (this as XtraReportBase).RowCount;           
            rowsVisible(row);  
        }

        private void GroupHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var row = (this as XtraReportBase).RowCount; 
            rowsVisible(row);
        }

        private void rowsVisible(int row)
        {
            if (row == 0)
            {                
                GroupHeader1.Visible = false;
                Detail.Visible = false;
            }
            else
            {
                GroupHeader1.Visible = true;
                Detail.Visible = false; 
            }
        }

        private void xrLabel15_PrintOnPage_1(object sender, PrintOnPageEventArgs e)
        {
            
            TotalAmount = (sender as XRLabel).Text?.Replace("$", string.Empty);
        }

        private void xrLabel25_PrintOnPage_1(object sender, PrintOnPageEventArgs e)
        {
            TotalCash = (sender as XRLabel).Text?.Replace("$", string.Empty);
        }

    }
}
