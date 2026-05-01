using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using WebAPIReports.Reports.Invoice;

namespace WebAPIReports.Reports.AgencyOverview
{
    public partial class EndOfDayCompanyReportSummaryChecks : DevExpress.XtraReports.UI.XtraReport
    {
        public EndOfDayCompanyReportSummaryChecks()
        {
            InitializeComponent();

            this.xrLabel2.DataBindings.AddRange(new XRBinding[] {
            new XRBinding(this.Color, "HexaForeColor", string.Empty)});
        }

        private void CombinedReportChecks_DataSourceDemanded(object sender, EventArgs e)
        {
            try
            {
                var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.ChecksConnectionString);
                (sender as EndOfDayCompanyReportSummaryChecks).DataSourceChecks.ConnectionParameters = dataConnectionParametersBase;
            }
            catch
            {

            }
        }

        private void DataSourceChecks_ConfigureDataConnection(object sender, DevExpress.DataAccess.Sql.ConfigureDataConnectionEventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.ChecksConnectionString);

            if (e.ConnectionName == ReportCommon.ChecksConnectionString)
                e.ConnectionParameters = dataConnectionParametersBase;
        }
     
    }
}