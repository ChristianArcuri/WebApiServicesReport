using DevExpress.XtraReports.UI;
using WebAPIReports.Reports.Invoice.Common.Interfaces;
using System.Globalization;

namespace WebAPIReports.Reports.Invoice
{
    public partial class RptTopUp : DevExpress.XtraReports.UI.XtraReport
    {
        IRptInvoiceBase _base = null;
        decimal stepAccumulate = 0;
        public RptTopUp()
        {
            InitializeComponent();
            this.BeforePrint += RptTopUp_BeforePrint;
        }

        private void RptTopUp_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _base = MasterReport as IRptInvoiceBase;
        }

        private void xrBalance_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            (sender as XRLabel).Text = string.Format("{0:$#,##0.00}", stepAccumulate);
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal currentAccumulate = (decimal)GetCurrentColumnValue("Accumulate");
            stepAccumulate = _base.currentBalance + currentAccumulate;

            if ((long)GetCurrentColumnValue("Position") == 1)
            {
                _base.currentBalance += currentAccumulate;
                _base.amountTopUp = currentAccumulate;
            }
        }

        private void ToTitleCaseString(object sender, BindingEventArgs e)
        {
          e.Value = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(((string)e.Value).Trim().ToLower());
        }
    }
}
