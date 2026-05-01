using System;
using DevExpress.XtraReports.UI;
using WebAPIReports.Reports.Invoice.Common.Interfaces;
using DevExpress.DataAccess.ConnectionParameters;
using WebAPIReports.Reports.Invoice.Common.Model;
using System.Globalization;

namespace WebAPIReports.Reports.Invoice
{
    public partial class RptWiresPaid : DevExpress.XtraReports.UI.XtraReport
    {
        public RptWiresPaid()
        {
            InitializeComponent();
        }

        private void xrBalance_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            (sender as XRLabel).Text = string.Format("{0:$#,##0.00}", (MasterReport as IRptInvoiceBase).currentBalance);
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
             decimal amountValue = Convert.ToDecimal(GetCurrentColumnValue("ActivityBalance"));
            (MasterReport as IRptInvoiceBase).currentBalance += amountValue;
        }

        private void xrTransactionDate_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            IFormatProvider fp;

            if (Convert.ToInt32(this.Parameters["LanguageId"].Value) == 1)
            {
                fp = new CultureInfo("en-Us");
            }
            else
                fp = new CultureInfo("es-MX");

            DateTime dt = Convert.ToDateTime(GetCurrentColumnValue("TransactionDate"));

            (sender as XRLabel).Text = dt.ToString("dddd", fp).ToUpper() + " " + dt.ToString("MM/dd/yy");

        }
    }
}
