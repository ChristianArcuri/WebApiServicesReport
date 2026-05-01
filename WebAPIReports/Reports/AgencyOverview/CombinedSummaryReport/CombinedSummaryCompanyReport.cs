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
    public partial class CombinedSummaryCompanyReport : DevExpress.XtraReports.UI.XtraReport
    {
        #region properties

        #endregion
        public CombinedSummaryCompanyReport()
        {
            InitializeComponent();
        }

        private void CombinedSummaryReport_DataSourceDemanded(object sender, EventArgs e)
        {
            var dataConnectionParametersBase = Reports.ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);
            (sender as CombinedSummaryCompanyReport).DataSourceCombined.ConnectionParameters = dataConnectionParametersBase;
        }

        private void DataSourceCombined_ConfigureDataConnection(object sender, DevExpress.DataAccess.Sql.ConfigureDataConnectionEventArgs e)
        {
            var dataConnectionParametersBase = Reports.ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);

            if (e.ConnectionName == Reports.ReportCommon.WireTransacDB)
                e.ConnectionParameters = dataConnectionParametersBase;
        }
    }
}