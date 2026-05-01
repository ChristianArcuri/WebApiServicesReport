using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Globalization;


namespace WebAPIReports.Reports.Invoice.SmallFormat
{
    public partial class RptInvoiceCancellationsSm : DevExpress.XtraReports.UI.XtraReport
    {
        private const string WireCancelled = "WC";

        public RptInvoiceCancellationsSm()
        {
            InitializeComponent();

        }

       
        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal amountValue = Convert.ToDecimal(GetCurrentColumnValue("ActivityBalance"));
          
            string cancellationType = GetCurrentColumnValue("Type").ToString();
            if (cancellationType == WireCancelled)
                (MasterReport as CompanyRptInvoiceSm).qtyCancellation++;
           
            (MasterReport as CompanyRptInvoiceSm).amountCancellation += amountValue;
            
        }

        private void xrTableCell22_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
           // (sender as XRTableCell).Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase((sender as XRTableCell).Text.ToLower().Trim());
        }

        private void RptInvoiceCancellations_DataSourceDemanded(object sender, EventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);
            (sender as RptInvoiceCancellationsSm).WireTransac.ConnectionParameters = dataConnectionParametersBase;
        }


    }
}
