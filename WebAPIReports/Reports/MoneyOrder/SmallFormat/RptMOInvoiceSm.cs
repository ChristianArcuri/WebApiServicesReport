using System;
using WebAPIReports.Reports.Invoice;

namespace WebAPIReports.Reports.MoneyOrder
{
    public partial class RptMOInvoiceSm : DevExpress.XtraReports.UI.XtraReport
    {
       
        public RptMOInvoiceSm()
        {
            InitializeComponent();
        }

        private void RptMOInvoiceSm_DataSourceDemanded(object sender, EventArgs e)
        {
            try 
            { 
                var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.MoneyOrderConnectionString);
                (sender as RptMOInvoiceSm).MoneyOrders.ConnectionParameters = dataConnectionParametersBase;
             }
            catch
            {

            }
        }

       
    }
}
