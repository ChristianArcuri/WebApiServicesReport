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
    public partial class CombinedCompanyReport : DevExpress.XtraReports.UI.XtraReport
    {
        #region properties

        #endregion
        public CombinedCompanyReport()
        {
            InitializeComponent();
        }

        private void CombinedReport_DataSourceDemanded(object sender, EventArgs e)
        {
            try
            {
                var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);
                (sender as CombinedCompanyReport).DataSourceCombined.ConnectionParameters = dataConnectionParametersBase;
            }
            catch (Exception ex)
            {

            }
        }

        private void DataSourceCombined_ConfigureDataConnection(object sender, DevExpress.DataAccess.Sql.ConfigureDataConnectionEventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);

            if (e.ConnectionName == ReportCommon.WireTransacDB)
                e.ConnectionParameters = dataConnectionParametersBase;
        }
    }
}