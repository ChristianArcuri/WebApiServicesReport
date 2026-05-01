using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace WebAPIReports.Reports.PartnerInvoiceProcFee
{
    public partial class PartnerInvoiceBC : DevExpress.XtraReports.UI.XtraReport
    {
        public PartnerInvoiceBC()
        {
            InitializeComponent();
        }

        private void PartnerInvoiceBC_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (((sender as PartnerInvoiceBC).MasterReport as PartnerInvoice).WireTransac != null)
            (sender as PartnerInvoiceBC).WireTransac.ConnectionParameters = ((sender as PartnerInvoiceBC).MasterReport as PartnerInvoice).WireTransac.ConnectionParameters;
        }

        private void PartnerInvoiceBC_DataSourceDemanded(object sender, EventArgs e)
        {
            if (((sender as PartnerInvoiceBC).MasterReport as PartnerInvoice).WireTransac != null)
            (sender as PartnerInvoiceBC).WireTransac.ConnectionParameters = ((sender as PartnerInvoiceBC).MasterReport as PartnerInvoice).WireTransac.ConnectionParameters;
        }

    }
}
