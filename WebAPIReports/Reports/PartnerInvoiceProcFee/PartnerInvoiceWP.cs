using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace WebAPIReports.Reports.PartnerInvoiceProcFee
{
    public partial class PartnerInvoiceWP : DevExpress.XtraReports.UI.XtraReport
    {
        public PartnerInvoiceWP()
        {
            InitializeComponent();
        }

        private void PartnerInvoiceWP_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (((sender as PartnerInvoiceWP).MasterReport as PartnerInvoice).WireTransac != null)
            (sender as PartnerInvoiceWP).WireTransac.ConnectionParameters = ((sender as PartnerInvoiceWP).MasterReport as PartnerInvoice).WireTransac.ConnectionParameters;
        }

        private void PartnerInvoiceWP_DataSourceDemanded(object sender, EventArgs e)
        {
            if (((sender as PartnerInvoiceWP).MasterReport as PartnerInvoice).WireTransac != null)
            (sender as PartnerInvoiceWP).WireTransac.ConnectionParameters = ((sender as PartnerInvoiceWP).MasterReport as PartnerInvoice).WireTransac.ConnectionParameters;
        }

    }
}
