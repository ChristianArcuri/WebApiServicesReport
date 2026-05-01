using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using WebAPIReports.Reports.Invoice;

namespace WebAPIReports.Reports.AgencyOverview
{
    public partial class CombinedReportChecks_V1 : DevExpress.XtraReports.UI.XtraReport
    {
        public CombinedReportChecks_V1()
        {
            InitializeComponent();
        }

        private void CombinedReportChecks_DataSourceDemanded(object sender, EventArgs e)
        {
            try
            {
                var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.ChecksConnectionString);
                (sender as CombinedReportChecks_V1).DataSourceChecks.ConnectionParameters = dataConnectionParametersBase;
            }
            catch
            {

            }
        }

        private void DataSourceChecks_ConfigureDataConnection(object sender, DevExpress.DataAccess.Sql.ConfigureDataConnectionEventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.ChecksConnectionString);

            if (e.ConnectionName == "ChecksConnectionString")
                e.ConnectionParameters = dataConnectionParametersBase;
        }

     

        private void GroupFooter1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ReportCommon.SetSmallerLabelFontSize(xrLabel10, false);
            ReportCommon.SetSmallerLabelFontSize(xrLabel13, false);

            ReportCommon.SetSmallerLabelFontSize(xrLabel9, true);

        }        
    }
}