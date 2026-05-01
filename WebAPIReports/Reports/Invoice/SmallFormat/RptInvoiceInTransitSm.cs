using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

using System.Globalization;

namespace WebAPIReports.Reports.Invoice.SmallFormat
{
    public partial class RptInvoiceInTransitSm : DevExpress.XtraReports.UI.XtraReport
    {
        public RptInvoiceInTransitSm()
        {
            InitializeComponent();
        }

        private void xrTableCell13_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
          //  (sender as XRTableCell).Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase((sender as XRTableCell).Text.ToLower().Trim());
        }

        private void RptInvoiceInTransit_DataSourceDemanded(object sender, EventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);
            (sender as RptInvoiceInTransitSm).WireTransac.ConnectionParameters = dataConnectionParametersBase;
        }

        private void xrTableCell4_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            (sender as XRTableCell).Text = (sender as XRTableCell).Text.ToUpper();
        }

    }
}
