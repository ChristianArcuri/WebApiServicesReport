using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

using System.Globalization;

namespace WebAPIReports.Reports.Invoice.SmallFormat
{
    public partial class RptInvoicePaymentSm : DevExpress.XtraReports.UI.XtraReport
    {
        public RptInvoicePaymentSm()
        {
            InitializeComponent();
          }
 
        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal amountValue = Convert.ToDecimal(GetCurrentColumnValue("Amount"));

          
            if (amountValue != 0) 
            {
                (MasterReport as CompanyRptInvoiceSm).qtyPayments++;
                (MasterReport as CompanyRptInvoiceSm).amountPayments += amountValue;
            }
        }

        private void xrTableCell11_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            //(sender as XRTableCell).Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase((sender as XRTableCell).Text.ToLower().Trim());
        }

        private void RptInvoicePayment_DataSourceDemanded(object sender, EventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);
            (sender as RptInvoicePaymentSm).WireTransac.ConnectionParameters = dataConnectionParametersBase;
        }


    }
}
