using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

using System.Globalization;
using DevExpress.DataAccess.ConnectionParameters;

namespace WebAPIReports.Reports.Invoice
{
    public partial class RptInvoiceInTransit : DevExpress.XtraReports.UI.XtraReport
    {
        public RptInvoiceInTransit()
        {
            InitializeComponent();
        }

        private void xrTableCell13_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
          //  (sender as XRTableCell).Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase((sender as XRTableCell).Text.ToLower().Trim());
        }

        private void RptInvoiceInTransit_DataSourceDemanded(object sender, EventArgs e)
        {
            RptInvoiceInTransit report = sender as RptInvoiceInTransit;
            report.WireTransac.ConnectionParameters = new MsSqlConnectionParameters();
            report.WireTransac.Connection.ConnectionString = WebAPIDataAccess.DAConnectionStrings.WireTransacReadOnlyConnectionString;
        }

    }
}
