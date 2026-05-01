using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

using System.Globalization;
using WebAPIReports.Reports.Invoice.Common.Model;

namespace WebAPIReports.Reports.Invoice.SmallFormat
{
    public partial class RptInvoiceWiresSm : DevExpress.XtraReports.UI.XtraReport
    {
        #region Properties
        private int qtyWires;
        private decimal grpAmount;
        private int qtyDebitCard;
        private decimal AmountDebitCard;

        #endregion

        public RptInvoiceWiresSm()
        {
            InitializeComponent();
            this.qtyWires = 0;
      
        }

    
        private void xrSummary_SummaryCalculated(object sender, TextFormatEventArgs e)
        {
            if (e.Value != null)
            {
                this.grpAmount = Convert.ToDecimal(e.Value);
            }
        }

        private void grpCount_SummaryCalculated(object sender, TextFormatEventArgs e)
        {
            this.qtyWires = Convert.ToInt32(e.Value);
        }

        private void grpCommission_SummaryCalculated(object sender, TextFormatEventArgs e)
        {
          
            if (e.Value != null)
            {
                WiresByDate wb = new WiresByDate()
                {
                    dateSent = Convert.ToDateTime(GetCurrentColumnValue("TransactionDate")).ToString("MM/dd/yy"),
                    qty = qtyWires,
                    amount = grpAmount,
                    commission = Convert.ToDecimal(e.Value),
                    qtyDebitCard = qtyDebitCard,
                    amountDebitCard = AmountDebitCard
                };

                (MasterReport as CompanyRptInvoiceSm).wiresSent.Add(wb);
            }
        }

        private void xrTableCell25_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            (sender as XRTableCell).Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase((sender as XRTableCell).Text.ToLower().Trim());
        }

        private void RptInvoiceWires_DataSourceDemanded(object sender, EventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);
            (sender as RptInvoiceWiresSm).WireTransac.ConnectionParameters = dataConnectionParametersBase;
        }

        private void xrLabel1_SummaryCalculated(object sender, TextFormatEventArgs e)
        {
            if (e.Value != null)
            {
                this.qtyDebitCard = Convert.ToInt32(e.Value);
            }
        }

        private void xrLabel3_SummaryCalculated(object sender, TextFormatEventArgs e)
        {
            if (e.Value != null)
            {
                this.AmountDebitCard = Convert.ToDecimal(e.Value);
            }
        }

    }
 
}
