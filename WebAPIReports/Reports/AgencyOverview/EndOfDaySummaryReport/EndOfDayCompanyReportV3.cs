using DevExpress.XtraReports.UI;
using System;
using System.Linq;
using WebAPIReports.Reports.Invoice;

namespace WebAPIReports.Reports.AgencyOverview
{
    public partial class EndOfDayCompanyReportV3 : DevExpress.XtraReports.UI.XtraReport
    {
        public EndOfDayCompanyReportV3()
        {
            InitializeComponent();
        }      

        private void EndOfDayReport_DataSourceDemanded(object sender, EventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);
            (sender as EndOfDayCompanyReportV3).sqlDataSource1.ConnectionParameters = dataConnectionParametersBase; 
                  
        }

        private void sqlDataSource1_ConfigureDataConnection(object sender, DevExpress.DataAccess.Sql.ConfigureDataConnectionEventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);

            if (e.ConnectionName == ReportCommon.WireTransacDB)
                e.ConnectionParameters = dataConnectionParametersBase;
        }       

        private void rowsVisible(int row)
        {
            if (row == 0)
            {
                SummaryHeader.Visible = false;
                Detail.Visible = false;
                GroupFooter2.Visible = true;
                ReportFooter.Visible = false;
            }
            else
            {
                SummaryHeader.Visible = true;
                Detail.Visible = true; 
                GroupFooter2.Visible = false;
                ReportFooter.Visible = true;
            }
        }          

        private void ReportFooter_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var rowSummary = ((EndOfDayCompanyReportSummary)xrSubreportEndOfDaySummary.ReportSource).TotalSummary;
            var row = (this as XtraReportBase).RowCount;
            if (rowSummary == 0 && row == 1)
            {
                rowsVisible(rowSummary);
            }
            
        }      

        private void GroupFooter2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var rowSummary = ((EndOfDayCompanyReportSummary)xrSubreportEndOfDaySummary.ReportSource).TotalSummary;
            var row = (this as XtraReportBase).RowCount;
            if (rowSummary == 0 && row == 1)
            {                
                rowsVisible(rowSummary);
            }           
            
        }
    }
}
