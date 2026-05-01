using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using WebAPIReports.Reports.Invoice;

namespace WebAPIReports.Reports.AgencyOverview
{
    public partial class EndOfDayCompanyReportTopUps : DevExpress.XtraReports.UI.XtraReport
    {
        public EndOfDayCompanyReportTopUps()
        {
            InitializeComponent();
        }

        private void EndOfDayReportCompanyTopUp_DataSourceDemanded(object sender, EventArgs e)
        {           
           var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);
           (sender as EndOfDayCompanyReportTopUps).sqlDataSource1.ConnectionParameters = dataConnectionParametersBase;
            
        }

        private void sqlDataSource1_ConfigureDataConnection(object sender, DevExpress.DataAccess.Sql.ConfigureDataConnectionEventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);

            if (e.ConnectionName == ReportCommon.WireTransacDB)
                e.ConnectionParameters = dataConnectionParametersBase;
        }

        private void EmptyLeyend_BeforePrint_1(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var visible = GetCurrentRow() != null ? true : false;
            
            xrPanel2.Visible = visible;            
            xrPanel4.Visible = visible;
        }
    }
}
