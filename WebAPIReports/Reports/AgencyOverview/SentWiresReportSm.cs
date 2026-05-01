using System;
using WebAPIReports.Reports.Invoice;

namespace WebAPIReports.Reports.AgencyOverview
{
    public partial class SentWiresSMReport : DevExpress.XtraReports.UI.XtraReport
    {
        public SentWiresSMReport()
        {
            InitializeComponent();
        }

        private void SentWiresReport_DataSourceDemanded(object sender, EventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);
            (sender as SentWiresSMReport).sqlDataSource1.ConnectionParameters = dataConnectionParametersBase;
     
        }

        private void sqlDataSource1_ConfigureDataConnection(object sender, DevExpress.DataAccess.Sql.ConfigureDataConnectionEventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);

            if (e.ConnectionName == "WireTransacConn")
                e.ConnectionParameters = dataConnectionParametersBase;
        }

     
    }
}
