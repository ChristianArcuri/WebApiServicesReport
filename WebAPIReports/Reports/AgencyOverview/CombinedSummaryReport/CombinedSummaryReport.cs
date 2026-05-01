using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Core.ConditionalFormatting;
using System.Collections.Generic;
using System.Globalization;
using System.Drawing.Printing;


namespace WebAPIReports.Reports.AgencyOverview
{
    public partial class CombinedSummaryReport : DevExpress.XtraReports.UI.XtraReport
    {
        #region properties

        #endregion
        public CombinedSummaryReport()
        {
            InitializeComponent();
        }

        private void CombinedSummaryReport_DataSourceDemanded(object sender, EventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);
            (sender as CombinedSummaryReport).DataSourceCombined.ConnectionParameters = dataConnectionParametersBase;
        }

        private void DataSourceCombined_ConfigureDataConnection(object sender, DevExpress.DataAccess.Sql.ConfigureDataConnectionEventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);

            if (e.ConnectionName == "WireTransacConn")
                e.ConnectionParameters = dataConnectionParametersBase;
        }
    }
}