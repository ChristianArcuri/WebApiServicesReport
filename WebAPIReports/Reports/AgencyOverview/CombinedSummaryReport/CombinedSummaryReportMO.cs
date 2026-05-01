using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using WebAPIReports.Reports.Invoice;

namespace WebAPIReports.Reports.AgencyOverview
{
    public partial class CombinedSummaryReportMO : DevExpress.XtraReports.UI.XtraReport
    {
        public CombinedSummaryReportMO()
        {
            InitializeComponent();
        }

        private void CombinedSummaryReportMO_DataSourceDemanded(object sender, EventArgs e)
        {
            try
            {
                var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.MoneyOrderConnectionString);
                (sender as CombinedSummaryReportMO).DataSourceMO.ConnectionParameters = dataConnectionParametersBase;
            }
            catch
            {

            }
        }

        private void DataSourceMO_ConfigureDataConnection(object sender, DevExpress.DataAccess.Sql.ConfigureDataConnectionEventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.MoneyOrderConnectionString);

            if (e.ConnectionName == Reports.ReportCommon.MoneyOrderConnectionString)
                e.ConnectionParameters = dataConnectionParametersBase;
        }
    }
}
