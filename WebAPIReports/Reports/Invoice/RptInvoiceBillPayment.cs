using System;
using System.Globalization;
using DevExpress.XtraReports.UI;
using WebAPIReports.Reports.Invoice.Common.Interfaces;

namespace WebAPIReports.Reports.Invoice
{
    public partial class RptInvoiceBillPayment : DevExpress.XtraReports.UI.XtraReport
    {
        IRptInvoiceBase _base = null;
        public RptInvoiceBillPayment()
        {
            InitializeComponent();
            BeforePrint += RptInvoiceBillPayment_BeforePrint;
        }

        private void RptInvoiceBillPayment_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _base = MasterReport as IRptInvoiceBase;
        }

        private void xrBalance_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            (sender as XRLabel).Text = string.Format("{0:$#,##0.00}", _base.currentBalance);
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal amountValue = Convert.ToDecimal(GetCurrentColumnValue("BTTotAmountInv"));
            _base.currentBalance += amountValue;
        }

        private void ToTitleCaseString(object sender, BindingEventArgs e)
        {
            e.Value = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(((string)e.Value).Trim().ToLower());
        }
    }
}
