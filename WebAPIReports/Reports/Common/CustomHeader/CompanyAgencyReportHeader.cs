using DevExpress.XtraReports.UI;
using System;
using System.Drawing.Printing;
using System.Globalization;
using System.Threading;

namespace WebAPIReports.Reports.Common.CustomHeader
{
    public partial class CompanyAgencyReportHeader : DevExpress.XtraReports.UI.XtraReport
    {
        public CompanyAgencyReportHeader()
        {
            InitializeComponent();
        }

        private void CompanyAgencyReportHeader_DataSourceDemanded(object sender, EventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);
            (sender as CompanyAgencyReportHeader).sqlDataSource1.ConnectionParameters = dataConnectionParametersBase;

        }

        private void sqlDataSource1_ConfigureDataConnection(object sender, DevExpress.DataAccess.Sql.ConfigureDataConnectionEventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);

            if (e.ConnectionName == ReportCommon.WireTransacDB)
                e.ConnectionParameters = dataConnectionParametersBase;
        }

        private void CompanyAgencyReportHeader_BeforePrint(object sender, PrintEventArgs e)
        {
            this.xrLabel4.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt", CultureInfo.InvariantCulture);
            var isLandscape = (bool)this.IsLandscape.Value;
            if (!isLandscape) { return; }
            this.Landscape = true;
            this.xrLabel3.WidthF = ReportCommon.LandscapeWidth;
            this.xrLabel2.WidthF = ReportCommon.LandscapeWidth;
            this.xrLabel1.LocationF = new System.Drawing.PointF(ReportCommon.LandscapeWidth - this.xrLabel1.WidthF, this.xrLabel1.LocationF.Y);;
            this.xrLabel4.LocationF = new System.Drawing.PointF(ReportCommon.LandscapeWidth - this.xrLabel4.WidthF, this.xrLabel4.LocationF.Y);
            this.xrLabel5.LocationF = new System.Drawing.PointF(ReportCommon.LandscapeWidth - this.xrLabel5.WidthF - this.xrLabel4.WidthF, this.xrLabel5.LocationF.Y);
        }
    }
}
