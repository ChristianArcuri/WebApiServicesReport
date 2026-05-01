using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace WebAPIReports.Reports.PartnerInvoiceProcFee
{
    public partial class PartnerInvoiceChB : DevExpress.XtraReports.UI.XtraReport
    {
        public PartnerInvoiceChB()
        {
            InitializeComponent();
        }

        private void PartnerInvoiceChB_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (((sender as PartnerInvoiceChB).MasterReport as PartnerInvoice).WireTransac != null)
            (sender as PartnerInvoiceChB).WireTransac.ConnectionParameters = ((sender as PartnerInvoiceChB).MasterReport as PartnerInvoice).WireTransac.ConnectionParameters;
        }

        private void PartnerInvoiceChB_DataSourceDemanded(object sender, EventArgs e)
        {
            if (((sender as PartnerInvoiceChB).MasterReport as PartnerInvoice).WireTransac != null)
            (sender as PartnerInvoiceChB).WireTransac.ConnectionParameters = ((sender as PartnerInvoiceChB).MasterReport as PartnerInvoice).WireTransac.ConnectionParameters;
        }

    }
}
