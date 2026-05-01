using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using WebAPIReports.Reports.Invoice;

namespace WebAPIReports.Reports.AgencyOverview
{
    public partial class CombinedReportMO : DevExpress.XtraReports.UI.XtraReport
    {
        public CombinedReportMO()
        {
            InitializeComponent();

            this.xrLabel8.DataBindings.AddRange(new XRBinding[] {
            new XRBinding(this.Color, "HexaForeColor", string.Empty)});
        }

        private void CombinedReportMO_DataSourceDemanded(object sender, EventArgs e)
        {
            try
            {
                var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.MoneyOrderConnectionString);
                (sender as CombinedReportMO).DataSourceMO.ConnectionParameters = dataConnectionParametersBase;
            }
            catch
            {

            }
        }

        private void DataSourceMO_ConfigureDataConnection(object sender, DevExpress.DataAccess.Sql.ConfigureDataConnectionEventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.MoneyOrderConnectionString);

            if (e.ConnectionName == ReportCommon.MoneyOrderConnectionString)
                e.ConnectionParameters = dataConnectionParametersBase;
        }

        private void reportFooterBand1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ReportCommon.SetSmallerLabelFontSize(xrLabel2, false);
            ReportCommon.SetSmallerLabelFontSize(xrLabel3, false);
            ReportCommon.SetSmallerLabelFontSize(xrLabel4, false);
            ReportCommon.SetSmallerLabelFontSize(xrLabel12, false);
            ReportCommon.SetSmallerLabelFontSize(xrLabel16, false);
            ReportCommon.SetSmallerLabelFontSize(xrLabel17, false);

            ReportCommon.SetSmallerLabelFontSize(xrLabel20, true);
            ReportCommon.SetSmallerLabelFontSize(xrLabel21, true);
            ReportCommon.SetSmallerLabelFontSize(xrLabel22, true);

        }        
    }
}