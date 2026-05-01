using DevExpress.XtraReports.UI;
using System;
using WebAPIReports.Reports.Invoice;

namespace WebAPIReports.Reports.AgencyOverview
{
    public partial class EndOfDayCompanyReportWires : DevExpress.XtraReports.UI.XtraReport
    {
        public EndOfDayCompanyReportWires()
        {
            InitializeComponent();
        }      

        private void EndOfDayReport_DataSourceDemanded(object sender, EventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);
            (sender as EndOfDayCompanyReportWires).sqlDataSource1.ConnectionParameters = dataConnectionParametersBase; 
                  
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
                GroupHeader2.Visible = false;
                Detail.Visible = false;
                GroupFooter1.Visible = false;               
            }
            else
            {
                GroupHeader2.Visible = true;
                Detail.Visible = true;                
                GroupFooter1.Visible = true;               
            }
        }

        private void GroupFooter1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {            
            ReportCommon.SetSmallerLabelFontSize(xrLabel9, false);           
            ReportCommon.SetSmallerLabelFontSize(xrLabel10, false);            
            ReportCommon.SetSmallerLabelFontSize(xrLabel11, false);  
            ReportCommon.SetSmallerLabelFontSize(xrLabel6, true);
            
        }      
    }
}
