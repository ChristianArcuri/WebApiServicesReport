using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using WebAPIReports.Reports.Invoice;

namespace WebAPIReports.Reports.AgencyOverview
{
    public partial class EndOfDayCompanyReportMOIssued : DevExpress.XtraReports.UI.XtraReport
    {
        public EndOfDayCompanyReportMOIssued()
        {
            InitializeComponent();
        }

        private void EndOfDayReportCompanyMOIssued_DataSourceDemanded(object sender, EventArgs e)
        {
            try
            {
                var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.MoneyOrderConnectionString);
                (sender as EndOfDayCompanyReportMOIssued).MoneyOrders.ConnectionParameters = dataConnectionParametersBase;
            }
            catch
            {

            }
        }

        private void EmptyLeyend_BeforePrint_1(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var visible = GetCurrentRow() != null ? true : false;
            
            xrPanel2.Visible = visible;            
            xrPanel4.Visible = visible;
        }
    }
}
