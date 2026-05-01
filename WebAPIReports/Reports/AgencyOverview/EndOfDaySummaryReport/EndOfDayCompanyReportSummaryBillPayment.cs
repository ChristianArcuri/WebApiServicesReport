using DevExpress.XtraReports.UI;
using System;
using WebAPIReports.Reports.Invoice;

namespace WebAPIReports.Reports.AgencyOverview
{
    public partial class EndOfDayCompanyReportSummaryBillPayment : DevExpress.XtraReports.UI.XtraReport
    {
        
        public EndOfDayCompanyReportSummaryBillPayment()
        {
            InitializeComponent();
        }      

        private void EndOfDayReport_DataSourceDemanded(object sender, EventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);
            (sender as EndOfDayCompanyReportSummaryBillPayment).sqlDataSource1.ConnectionParameters = dataConnectionParametersBase; 
                  
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

    }
}
