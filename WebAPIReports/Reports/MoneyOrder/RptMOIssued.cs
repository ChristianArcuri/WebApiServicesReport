using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using WebAPIReports.Reports.Invoice;

namespace WebAPIReports.Reports.MoneyOrder
{
    public partial class RptMOIssued : DevExpress.XtraReports.UI.XtraReport
    {
        public RptMOIssued()
        {
            InitializeComponent();
        }

        private void RptMOIssued_DataSourceDemanded(object sender, EventArgs e)
        {
            try
            {
                var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.MoneyOrderConnectionString);
                (sender as RptMOIssued).MoneyOrders.ConnectionParameters = dataConnectionParametersBase;
            }
            catch
            {

            }
        }

        private void EmptyLeyend_BeforePrint_1(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var visible = GetCurrentRow() != null ? true : false;
            EmptyLeyend.Visible = !visible;
            xrPanel1.Visible = visible;
            xrPanel2.Visible = visible;
            xrPanel3.Visible = visible;
            xrPanel4.Visible = visible;
        }
    }
}
