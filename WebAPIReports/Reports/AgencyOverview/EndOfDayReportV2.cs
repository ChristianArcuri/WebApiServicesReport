using DevExpress.XtraReports.UI;
using System;
using WebAPIReports.Reports.Invoice;

namespace WebAPIReports.Reports.AgencyOverview
{
    public partial class EndOfDayReportV2 : DevExpress.XtraReports.UI.XtraReport
    {
        public EndOfDayReportV2()
        {
            InitializeComponent();
        }      

        private void EndOfDayReport_DataSourceDemanded(object sender, EventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);
            (sender as EndOfDayReportV2).sqlDataSource1.ConnectionParameters = dataConnectionParametersBase; 
                  
        }

        private void sqlDataSource1_ConfigureDataConnection(object sender, DevExpress.DataAccess.Sql.ConfigureDataConnectionEventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);

            if (e.ConnectionName == "WireTransacConn")
                e.ConnectionParameters = dataConnectionParametersBase;
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var row = ((XtraReportBase)this).RowCount;           
            rowsVisible(row);  
        }

        private void GroupHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var row = ((XtraReportBase)this).RowCount; 
            rowsVisible(row);
        }

        private void rowsVisible(int row)
        {
            if (row == 0)
            {                
                GroupHeader1.Visible = false;
                Detail.Visible = false;
                GroupFooter1.Visible = false;
                GroupFooter2.Visible = true;
                ReportFooter.Visible = false;
            }
            else
            {
                GroupHeader1.Visible = true;
                Detail.Visible = true;                
                GroupFooter1.Visible = true;
                GroupFooter2.Visible = false;
                ReportFooter.Visible = true;
            }
        }

        private void GroupFooter1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {            
            ReportCommon.SetSmallerLabelFontSize(xrLabel28, false);
            ReportCommon.SetSmallerLabelFontSize(xrLabel36, false);
            ReportCommon.SetSmallerLabelFontSize(xrLabel9, false);
            ReportCommon.SetSmallerLabelFontSize(xrLabel27, false);
            ReportCommon.SetSmallerLabelFontSize(xrLabel35, false);
            ReportCommon.SetSmallerLabelFontSize(xrLabel10, false);
            ReportCommon.SetSmallerLabelFontSize(xrLabel26, false);
            ReportCommon.SetSmallerLabelFontSize(xrLabel34, false);
            ReportCommon.SetSmallerLabelFontSize(xrLabel11, false);
            ReportCommon.SetSmallerLabelFontSize(xrLabel25, false);
            ReportCommon.SetSmallerLabelFontSize(xrLabel33, false);            
            ReportCommon.SetSmallerLabelFontSize(xrLabel24, false);
            ReportCommon.SetSmallerLabelFontSize(xrLabel32, false);
            ReportCommon.SetSmallerLabelFontSize(xrLabel14, false);
            ReportCommon.SetSmallerLabelFontSize(xrLabel23, false);
            ReportCommon.SetSmallerLabelFontSize(xrLabel31, false);

            ReportCommon.SetSmallerLabelFontSize(xrLabel6, true);
            ReportCommon.SetSmallerLabelFontSize(xrLabel29, true);
            ReportCommon.SetSmallerLabelFontSize(xrLabel37, true);
        }      
    }
}
