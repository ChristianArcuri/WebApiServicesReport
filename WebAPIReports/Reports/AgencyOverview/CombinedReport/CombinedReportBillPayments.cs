using DevExpress.XtraReports.UI;
using System;
using System.Drawing;
using System.Globalization;
using System.Threading;
using WebAPIReports.Reports.Invoice;

namespace WebAPIReports.Reports.AgencyOverview
{
    public partial class CombinedReportBillPayments : DevExpress.XtraReports.UI.XtraReport
    {
        public CombinedReportBillPayments()
        {
            InitializeComponent();

            this.xrLabel3.DataBindings.AddRange(new XRBinding[] {
            new XRBinding(this.Color, "HexaForeColor", string.Empty)});
        }

        private void CombinedReportBillPayments_DataSourceDemanded(object sender, EventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);
            (sender as CombinedReportBillPayments).DataSourceBillPayment.ConnectionParameters = dataConnectionParametersBase;
        }

        private void DataSourceBillPayment_ConfigureDataConnection(object sender, DevExpress.DataAccess.Sql.ConfigureDataConnectionEventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);

            if (e.ConnectionName == ReportCommon.WireTransacDB)
                e.ConnectionParameters = dataConnectionParametersBase;
        }

        private void GroupFooter1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ReportCommon.SetSmallerLabelFontSize(xrLabel22, false);
            ReportCommon.SetSmallerLabelFontSize(xrLabel14, false);
            ReportCommon.SetSmallerLabelFontSize(xrLabel9, false);
            ReportCommon.SetSmallerLabelFontSize(xrLabel10, false);
            ReportCommon.SetSmallerLabelFontSize(xrLabel13, false);
            ReportCommon.SetSmallerLabelFontSize(xrLabel8, false);
            ReportCommon.SetSmallerLabelFontSize(xrLabel12, false);
            ReportCommon.SetSmallerLabelFontSize(xrLabel11, false);

            ReportCommon.SetSmallerLabelFontSize(xrLabel26, true);
            ReportCommon.SetSmallerLabelFontSize(xrLabel20, true);
            ReportCommon.SetSmallerLabelFontSize(xrLabel25, true);
            ReportCommon.SetSmallerLabelFontSize(xrLabel24, true);
        }
    }
}
