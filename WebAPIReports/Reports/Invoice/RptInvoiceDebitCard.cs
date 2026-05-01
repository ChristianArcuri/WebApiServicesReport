using System;
using System.Globalization;
using DevExpress.XtraReports.UI;
using WebAPIReports.Reports.Invoice.Common.Interfaces;

namespace WebAPIReports.Reports.Invoice
{
    public partial class RptInvoiceDebitCard : DevExpress.XtraReports.UI.XtraReport
    {
        public RptInvoiceDebitCard()
        {
            InitializeComponent();
        }

        private void xrBalance_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            (sender as XRLabel).Text = string.Format("{0:$#,##0.00}", (MasterReport as IRptInvoiceBase).currentBalance);
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal amountValue = Convert.ToDecimal(GetCurrentColumnValue("TranAmountInv"));
            (MasterReport as IRptInvoiceBase).currentBalance += amountValue;
        }

        private void ToTitleCaseString(object sender, BindingEventArgs e)
        {
            e.Value = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(((string)e.Value).Trim().ToLower());
        }
    }
}
