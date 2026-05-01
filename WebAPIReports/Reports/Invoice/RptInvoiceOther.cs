using System;
using DevExpress.XtraReports.UI;

using WebAPIReports.Reports.Invoice.Common.Interfaces;
using DevExpress.DataAccess.ConnectionParameters;
using System.Linq;

namespace WebAPIReports.Reports.Invoice
{
    public partial class RptInvoiceOther : DevExpress.XtraReports.UI.XtraReport
    {
        public RptInvoiceOther()
        {
            InitializeComponent();
        }

        private void xrBalance_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            (sender as XRLabel).Text = string.Format("{0:$#,##0.00}", (MasterReport as IRptInvoiceBase).currentBalance);
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal amountValue = Convert.ToDecimal(GetCurrentColumnValue("Amount"));
            (MasterReport as IRptInvoiceBase).currentBalance += amountValue;
        }

        private void xrTableCell11_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
         //   (sender as XRTableCell).Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase((sender as XRTableCell).Text.ToLower().Trim());
        }

    }
}
