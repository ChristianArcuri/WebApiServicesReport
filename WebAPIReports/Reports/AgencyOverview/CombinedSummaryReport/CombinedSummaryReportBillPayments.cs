using DevExpress.XtraReports.UI;
using System;
using System.Globalization;
using System.Threading;
using WebAPIReports.Reports.Invoice;

namespace WebAPIReports.Reports.AgencyOverview
{
    public partial class CombinedSummaryReportBillPayments : DevExpress.XtraReports.UI.XtraReport
    {
        public CombinedSummaryReportBillPayments()
        {
            InitializeComponent();
        }

        private void CombinedSummaryReportBillPayments_DataSourceDemanded(object sender, EventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);
            (sender as CombinedSummaryReportBillPayments).DataSourceBillPayment.ConnectionParameters = dataConnectionParametersBase;
     
        }

        private void DataSourceBillPayment_ConfigureDataConnection(object sender, DevExpress.DataAccess.Sql.ConfigureDataConnectionEventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);

            if (e.ConnectionName == Reports.ReportCommon.WireTransacDB)
                e.ConnectionParameters = dataConnectionParametersBase;
        }
    }
}
