using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Core.ConditionalFormatting;

using System.Collections.Generic;
using System.Globalization;
using System.Drawing.Printing;


namespace WebAPIReports.Reports.Invoice
{
    public partial class RptInvoiceCompanyHeader : DevExpress.XtraReports.UI.XtraReport
    {
        public RptInvoiceCompanyHeader()
        {
            InitializeComponent();
            
        }

        private void RptInvoice_DataSourceDemanded(object sender, EventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);
            (sender as RptInvoiceCompanyHeader).WireTransac.ConnectionParameters = dataConnectionParametersBase;

            dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireSecurityConnectionString);
            (sender as RptInvoiceCompanyHeader).WireSecurity.ConnectionParameters = dataConnectionParametersBase;
        }

        private void xrInfoHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            string text=string.Format("{0}\n{1}: {2}\n{3}: {4}\n{5}: {6}\n\n{7} {8}",
                                                       xrIHLine1.Text.Trim(),
                                                       xrIHFax.Text.Trim(),
                                                       xrIHFaxValue.Text.Trim(),
                                                       xrIHEmail.Text.Trim(),
                                                       xrIHEmailValue.Text.Trim(),
                                                       xrIHPhone.Text.Trim(),
                                                       xrIHPhoneValue.Text.Trim(),
                                                       xrIHLineEnd.Text.Trim(),
                                                       xrIHLineEndValue.Text.Trim());
            if (this.xrCompany.Text == ReportCommon.LAN_BRAND_NAME)
            {
                this.xrLabel2.Visible = false;
                text = string.Format("{0}\n{1}: {2}\n{3}\n\n{4} {5}",
                                                       xrIHLine1.Text.Trim(),
                                                       xrIHEmail.Text.Trim(),
                                                       xrIHEmailValue.Text.Trim(),
                                                       xrBankDeposit.Text.Trim(),
                                                       xrIHLineEnd.Text.Trim(),
                                                       xrIHLineEndValue.Text.Trim());
            }
            (sender as XRLabel).Text = text;
        }

    }
}
