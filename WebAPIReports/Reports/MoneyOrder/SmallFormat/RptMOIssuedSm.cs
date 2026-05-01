using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using WebAPIReports.Reports.Invoice;

namespace WebAPIReports.Reports.MoneyOrder.SmallFormat
{
    public partial class RptMOIssuedSm : DevExpress.XtraReports.UI.XtraReport
    {
        public RptMOIssuedSm()
        {
            InitializeComponent();
        }

        private void RptMOIssued_DataSourceDemanded(object sender, EventArgs e)
        {
            try
            {
                var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.MoneyOrderConnectionString);
                (sender as RptMOIssuedSm).MoneyOrders.ConnectionParameters = dataConnectionParametersBase;
            }
            catch
            {

            }
        }

    }
}
