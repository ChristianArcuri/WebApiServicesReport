using DevExpress.XtraReports.UI;
using System;
using System.Globalization;
using System.Threading;
using WebAPIReports.Reports.Invoice;

namespace WebAPIReports.Reports.AgencyOverview
{
    public partial class SentWiresCompanyReportV2 : DevExpress.XtraReports.UI.XtraReport
    {
        public SentWiresCompanyReportV2()
        {
            InitializeComponent();
        }

        private void SentWiresReportV2_DataSourceDemanded(object sender, EventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);
            (sender as SentWiresCompanyReportV2).sqlDataSource1.ConnectionParameters = dataConnectionParametersBase;

        }

        private void sqlDataSource1_ConfigureDataConnection(object sender, DevExpress.DataAccess.Sql.ConfigureDataConnectionEventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);

            if (e.ConnectionName == "WireTransacConn")
                e.ConnectionParameters = dataConnectionParametersBase;
        }

        private void xrTableCell3_PrintOnPage(object sender, DevExpress.XtraReports.UI.PrintOnPageEventArgs e)
        {
            (sender as XRTableCell).Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase((sender as XRTableCell).Text.ToLower().Trim());

        }



        private void GroupFooter1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var row = (this as XtraReportBase).RowCount;
            rowsVisible(row);
        }
        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var row = (this as XtraReportBase).RowCount;
            rowsVisible(row);
        }
        private void GroupHeader2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var row = (this as XtraReportBase).RowCount;
            rowsVisible(row);
        }
        private void rowsVisible(int row)
        {
            if (row == 0)
            {
                Detail.Visible = false;
                GroupHeader2.Visible = false;
                GroupHeader3.Visible = false;
                ReportFooter.Visible = false;
                GroupFooter3.Visible = false;
                GroupFooter2.Visible = true;
            }
            else
            {
                Detail.Visible = true;
                GroupHeader2.Visible = true;
                GroupHeader3.Visible = true;
                GroupFooter3.Visible = true;
                ReportFooter.Visible = true;
                GroupFooter2.Visible = false;
            }
        }
    }
}
