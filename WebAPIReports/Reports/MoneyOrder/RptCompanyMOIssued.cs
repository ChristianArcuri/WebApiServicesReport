using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using WebAPIReports.Reports.Invoice;
using log4net;

namespace WebAPIReports.Reports.MoneyOrder
{
    public partial class RptCompanyMOIssued : DevExpress.XtraReports.UI.XtraReport
    {
        ILog log = LogManager.GetLogger(typeof(RptCompanyMOIssued));
        public RptCompanyMOIssued()
        {
            InitializeComponent();
        }

        private void RptMOIssued_DataSourceDemanded(object sender, EventArgs e)
        {
            try
            {
                var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.MoneyOrderConnectionString);
                (sender as RptCompanyMOIssued).MoneyOrders.ConnectionParameters = dataConnectionParametersBase;
            }
            catch (Exception ex)
            {
                log.ErrorFormat("RptCompanyMOIssued ERROR: {0}", ex.Message);
            }
        }

        private void EmptyLeyend_BeforePrint_1(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var visible = GetCurrentRow() != null;
            EmptyLeyend.Visible = !visible;
            xrPanel1.Visible = visible;
            xrPanel2.Visible = visible;
            xrPanel3.Visible = visible;
            xrPanel4.Visible = visible;
        }
    }
}
