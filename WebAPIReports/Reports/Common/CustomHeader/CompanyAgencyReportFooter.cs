using DevExpress.XtraReports.UI;
using System;
using System.Drawing.Printing;
using System.Globalization;
using System.Threading;

namespace WebAPIReports.Reports.Common.CustomHeader
{
    public partial class CompanyAgencyReportFooter : DevExpress.XtraReports.UI.XtraReport
    {
        public CompanyAgencyReportFooter()
        {
            InitializeComponent();
        }

        private void CompanyAgencyReportHeader_DataSourceDemanded(object sender, EventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);
            (sender as CompanyAgencyReportFooter).sqlDataSource1.ConnectionParameters = dataConnectionParametersBase;

        }

        private void CompanyAgencyReportFooter_BeforePrint(object sender, PrintEventArgs e)
        {            
            var isLandscape = (bool)this.IsLandscape.Value; 
            if (!isLandscape) { return; }
            this.Landscape = true;
            this.xrLine3.WidthF = ReportCommon.LandscapeWidth;
            this.xrLabel14.WidthF = ReportCommon.LandscapeWidth;
        }

        private void sqlDataSource1_ConfigureDataConnection(object sender, DevExpress.DataAccess.Sql.ConfigureDataConnectionEventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);

            if (e.ConnectionName == ReportCommon.WireTransacDB)
                e.ConnectionParameters = dataConnectionParametersBase;
        }

        private void xrLabel14_PrintOnPage_1(object sender, PrintOnPageEventArgs e)
        {
            XRLabel label= (XRLabel)sender;
            label.Text = string.Format(label.Text, e.PageIndex + 1, e.PageCount);
        }
    }
}
