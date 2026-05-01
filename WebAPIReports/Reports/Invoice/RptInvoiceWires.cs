using System;
using DevExpress.XtraReports.UI;

using System.Globalization;
using WebAPIReports.Reports.Invoice.Common.Interfaces;
using WebAPIReports.Reports.Invoice.Common.Model;
using DevExpress.DataAccess.ConnectionParameters;
using System.Linq;

namespace WebAPIReports.Reports.Invoice
{
    public partial class RptInvoiceWires : DevExpress.XtraReports.UI.XtraReport
    {
        #region Properties
        private int qtyDebitCard;
        private decimal AmountDebitCard;
        #endregion

        public RptInvoiceWires()
        {
            InitializeComponent();
            qtyDebitCard = 0;
            AmountDebitCard = 0;
            xrTableCell33.BeforePrint += XrTableCell33_BeforePrint;
            Disposed += RptInvoiceWires_Disposed;
        }

        private void RptInvoiceWires_Disposed(object sender, EventArgs e)
        {
            xrTableCell33.BeforePrint -= XrTableCell33_BeforePrint;
            Disposed -= RptInvoiceWires_Disposed;
        }

        private void XrTableCell33_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            float currentFontSize = 7.5F;
            if (xrTableCell33.Text.Length >= 11)
            {
                float range = (xrTableCell33.Text.Length - 10) / 1.3F;
                float smallFontSize = currentFontSize - range;
                xrTableCell33.Font = new System.Drawing.Font("Open Sans Semibold", smallFontSize);
            }
            else
                xrTableCell33.Font = new System.Drawing.Font("Open Sans Semibold", currentFontSize);
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
            IFormatProvider fp = (int)Parameters["LanguageId"].Value == 1 ? new CultureInfo("en-Us") : new CultureInfo("es-MX");
            DateTime dt = Convert.ToDateTime(GetCurrentColumnValue("TransactionDate"));
            (sender as XRLabel).Text = dt.ToString("dddd", fp).ToUpper() + " " + dt.ToString(Constants.DateFormat);
        }

        private void xrTableCell25_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            (sender as XRTableCell).Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase((sender as XRTableCell).Text.ToLower().Trim());
        }
    }
 
}
