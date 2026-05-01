using DevExpress.XtraReports.UI;
using System;
using WebAPIReports.Reports.Invoice;

namespace WebAPIReports.Reports.MoneyOrder
{
    public partial class RptMOInvoiceDetailSm : DevExpress.XtraReports.UI.XtraReport
    {
        private decimal currentBalance = 0;
        public RptMOInvoiceDetailSm()
        {
            InitializeComponent();
        }

        private void xrLabel5_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (currentBalance == 0)
                currentBalance = Convert.ToDecimal(this.Parameters["BeginingBalance"].Value);

            currentBalance += Convert.ToDecimal(GetCurrentColumnValue("Debits")) - Convert.ToDecimal(GetCurrentColumnValue("Credits"));
            (sender as XRLabel).Text = string.Format("{0:$#,##0.00}", currentBalance);
        }

        private void xrLabel8_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            (sender as XRLabel).Text = string.Format("{0:$#,##0.00}", currentBalance);
        }

        private void RptMOInvoiceDetailSm_DataSourceDemanded(object sender, EventArgs e)
        {

            try
            {
                var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.MoneyOrderConnectionString);
                (sender as RptMOInvoiceDetailSm).MoneyOrders.ConnectionParameters = dataConnectionParametersBase;
            }
            catch
            {
                
            }
        }

            

    }
}
