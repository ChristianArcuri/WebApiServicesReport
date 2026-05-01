using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using WebAPIReports.Reports.Invoice;

namespace WebAPIReports.Reports.MoneyOrder
{
    public partial class RptMOInvoice : DevExpress.XtraReports.UI.XtraReport
    {
       
        public RptMOInvoice()
        {
            InitializeComponent();
        }

        private void RptMOInvoice_DataSourceDemanded(object sender, EventArgs e)
        {
            try 
            { 
                var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.MoneyOrderConnectionString);
                (sender as RptMOInvoice).MoneyOrders.ConnectionParameters = dataConnectionParametersBase;
             }
            catch
            {

            }
        }
    }
}
