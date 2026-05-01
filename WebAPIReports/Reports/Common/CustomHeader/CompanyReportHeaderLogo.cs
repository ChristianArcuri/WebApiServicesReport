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


namespace WebAPIReports.Reports.Common.CustomHeader
{
    public partial class CompanyReportHeaderLogo : DevExpress.XtraReports.UI.XtraReport
    {
        #region properties

        #endregion
        public CompanyReportHeaderLogo()
        {
            InitializeComponent();
        }

        private void CompanyReportHeader_DataSourceDemanded(object sender, EventArgs e)
        {
            try
            {
                var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);
                (sender as CompanyReportHeaderLogo).DataSourceCompanyReportHeader.ConnectionParameters = dataConnectionParametersBase;
            }
            catch (Exception ex)
            {

            }
        }

        private void DataSourceCompanyReportHeader_ConfigureDataConnection(object sender, DevExpress.DataAccess.Sql.ConfigureDataConnectionEventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);

            if (e.ConnectionName == ReportCommon.WireTransacDB)
                e.ConnectionParameters = dataConnectionParametersBase;
        }
    }
}