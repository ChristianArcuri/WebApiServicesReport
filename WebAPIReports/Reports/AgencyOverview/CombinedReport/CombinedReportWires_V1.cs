using DevExpress.XtraReports.UI;
using System;
using System.Drawing;
using System.Globalization;
using System.Threading;
using WebAPIReports.Reports.Invoice;

namespace WebAPIReports.Reports.AgencyOverview
{
    public partial class CombinedReportWires_V1 : DevExpress.XtraReports.UI.XtraReport
    {
        public CombinedReportWires_V1()
        {
            InitializeComponent();
        }

        private void CombinedReportWires_DataSourceDemanded(object sender, EventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);
            (sender as CombinedReportWires_V1).DataSourceWires.ConnectionParameters = dataConnectionParametersBase;
     
        }

        private void DataSourceWires_ConfigureDataConnection(object sender, DevExpress.DataAccess.Sql.ConfigureDataConnectionEventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);

            if (e.ConnectionName == "WireTransacConn")
                e.ConnectionParameters = dataConnectionParametersBase;
        }
    
        private void GroupFooter1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ReportCommon.SetSmallerLabelFontSize(xrLabel8, false);
            ReportCommon.SetSmallerLabelFontSize(xrLabel22, false);
            ReportCommon.SetSmallerLabelFontSize(xrLabel14, false);
            ReportCommon.SetSmallerLabelFontSize(xrLabel9, false);
            ReportCommon.SetSmallerLabelFontSize(xrLabel2, false);
            ReportCommon.SetSmallerLabelFontSize(xrLabel10, false);
            ReportCommon.SetSmallerLabelFontSize(xrLabel24, false);
            ReportCommon.SetSmallerLabelFontSize(xrLabel16, false);
            ReportCommon.SetSmallerLabelFontSize(xrLabel12, false);
            ReportCommon.SetSmallerLabelFontSize(xrLabel15, false);
            ReportCommon.SetSmallerLabelFontSize(xrLabel11, false);
            ReportCommon.SetSmallerLabelFontSize(xrLabel13, false);

            ReportCommon.SetSmallerLabelFontSize(xrLabel35, true);
            ReportCommon.SetSmallerLabelFontSize(xrLabel34, true);
            ReportCommon.SetSmallerLabelFontSize(xrLabel33, true);
            ReportCommon.SetSmallerLabelFontSize(xrLabel32, true);
            ReportCommon.SetSmallerLabelFontSize(xrLabel31, true);
            ReportCommon.SetSmallerLabelFontSize(xrLabel30, true);

        }
    }
}
