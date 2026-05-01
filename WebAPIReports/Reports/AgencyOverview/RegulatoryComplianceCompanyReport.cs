using DevExpress.XtraReports.UI;
using System;
using System.Globalization;
using System.Threading;
using WebAPIReports.Reports.Invoice;

namespace WebAPIReports.Reports.AgencyOverview
{
    public partial class RegulatoryComplianceCompanyReport : DevExpress.XtraReports.UI.XtraReport
    {       
        public RegulatoryComplianceCompanyReport()
        {
            InitializeComponent();
        }

        private void RegulatoryComplianceReport_DataSourceDemanded(object sender, EventArgs e)
        {
            var dataConnectionParametersBase = Reports.ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);
            (sender as RegulatoryComplianceCompanyReport).sqlDataSource2.ConnectionParameters = dataConnectionParametersBase;

        }

        private void sqlDataSource1_ConfigureDataConnection(object sender, DevExpress.DataAccess.Sql.ConfigureDataConnectionEventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);

            if (e.ConnectionName == ReportCommon.WireTransacDB)
                e.ConnectionParameters = dataConnectionParametersBase;
        }

        private void xrTableCell3_PrintOnPage(object sender, DevExpress.XtraReports.UI.PrintOnPageEventArgs e)
        {
            (sender as XRTableCell).Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase((sender as XRTableCell).Text.ToLower().Trim());

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
                GroupFooter1.Visible = false;
                GroupFooter2.Visible = true;
            }
            else
            {
                GroupHeader1.Visible = true;
                Detail.Visible = true;
                GroupFooter1.Visible = true;
                GroupFooter2.Visible = false;
            }
        }

        private void GroupFooter1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ReportCommon.SetSmallerLabelFontSize(xrLabel6);
            ReportCommon.SetSmallerLabelFontSize(xrLabel8);
            ReportCommon.SetSmallerLabelFontSize(xrLabel9);
            ReportCommon.SetSmallerLabelFontSize(xrLabel34);
            ReportCommon.SetSmallerLabelFontSize(xrLabel33);
            ReportCommon.SetSmallerLabelFontSize(xrLabel14);
                      
        }

       
    }
}
