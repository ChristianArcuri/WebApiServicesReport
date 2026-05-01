using DevExpress.XtraReports.UI;
using System;

namespace WebAPIReports.Reports.AgencyOverview
{
    public partial class CombinedReportSummaryGraphic : DevExpress.XtraReports.UI.XtraReport
    {        

        public CombinedReportSummaryGraphic()
        {
            InitializeComponent();            
        }

        private void CombinedReportWires_DataSourceDemanded(object sender, EventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);
            (sender as CombinedReportSummaryGraphic).DataSourceWires.ConnectionParameters = dataConnectionParametersBase;
     
        }

        private void DataSourceWires_ConfigureDataConnection(object sender, DevExpress.DataAccess.Sql.ConfigureDataConnectionEventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);

            if (e.ConnectionName == "WireTransacConn")
                e.ConnectionParameters = dataConnectionParametersBase;
        }
       
    }
}
