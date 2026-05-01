using System;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using WebAPIReports.Reports.Invoice.Common.Interfaces;
using WebAPIReports.Reports.Invoice.Common.Model;

namespace WebAPIReports.Reports.Invoice
{
    public partial class RptInvoice : DevExpress.XtraReports.UI.XtraReport, IRptInvoiceBase
    {
        #region properties
        public decimal currentBalance { get; set; }
        public int qtyPayments { get; set; }
        public decimal amountPayments { get; set; }
        public int qtyOther { get; set; }
        public decimal amountOther { get; set; }
        public int qtyCancellation { get; set; }
        public decimal amountCancellation{ get; set; }
        public int qtyBP { get; set; }
        public decimal amountBP { get; set; }

        public int qtyTopUp { get; set; }
        public decimal amountTopUp { get; set; }

        public int qtyDebitCard { get; set; }
        public decimal amountDebitCard { get; set; }
        public decimal totalPayDueInbound { get; set; }
        public List<WiresByDate> wiresPaid { get; set; }
        public List<WiresByDate> wiresSent { get; set; }

        public List<SummaryCommision> Commissions { get; set; }
        public List<SummaryCardPayments> CardPayment { get; set; }

        int pages;

        #endregion
        public RptInvoice()
        {
            InitializeComponent();

            this.wiresSent = new List<WiresByDate>();
            currentBalance = 0;
            qtyPayments = 0;
            amountPayments = 0;
            qtyOther =0;
            amountOther = 0;
            qtyCancellation = 0;
            amountCancellation = 0;
            qtyBP = 0;
            amountBP = 0;
            pages = 0;
            qtyDebitCard = 0;
            amountDebitCard = 0;
            this.wiresPaid = new List<WiresByDate>();

        }


        private void xrPaymentAmount_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            (sender as XRLabel).Text = string.Format("{0:$#,##0.00}", amountPayments);
        }

        private void xrQtyOtherCredits_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            (sender as XRLabel).Text = qtyOther.ToString();
         }

        private void xrOtherAmount_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            (sender as XRLabel).Text = string.Format("{0:$#,##0.00}", amountOther);
        }

        private void xrQtyCancellations_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            (sender as XRLabel).Text = qtyCancellation.ToString();
        }

        private void xrCancellationAmount_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            (sender as XRLabel).Text = string.Format("{0:$#,##0.00}", amountCancellation);
          }

       private void xrTSummary_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            DateTime fDate = Convert.ToDateTime(GetCurrentColumnValue("TransactionDateFrom"));//Convert.ToDateTime(fromDate.Text);
            DateTime tDate = Convert.ToDateTime(GetCurrentColumnValue("TransactionDateTo")); //Convert.ToDateTime(toDate.Text);
            int diff = tDate.Subtract(fDate).Days;

            int posInitial = xrTSummary.Rows.Count - 3;
            (sender as XRTable).BeginInit();
             for (int i = 0; i <= diff; i ++)
                {
                    this.xrTSummary.InsertRowBelow(this.xrTSummary.Rows[posInitial + i]);


                    (this.xrTSummary.Rows[posInitial + i + 1].Cells[0] as XRLabel).Text = xrWiresLabel.Text + " " + fDate.AddDays(i).ToString("MM/dd/yy");

                    this.xrTSummary.Rows[posInitial + i + 1].Cells[1].Name = "Qty_" + i.ToString();
                    this.xrTSummary.Rows[posInitial + i + 1].Cells[1].PrintOnPage += new PrintOnPageEventHandler(cell_PrintOnPage);

                    this.xrTSummary.Rows[posInitial + i + 1].Cells[2].Name = "Amt_" + i.ToString();
                    this.xrTSummary.Rows[posInitial + i + 1].Cells[2].PrintOnPage += new PrintOnPageEventHandler(cell_PrintOnPage);

                   
               }
             (sender as XRTable).AdjustSize();
             (sender as XRTable).EndInit();
        }

        private void PageHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            pages++;
        }

     
        void cell_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRTableCell tc = sender as XRTableCell;
            if (tc.Name.IndexOf('_') > 0 )
            { 
                if (tc.Name.StartsWith("Qty"))
                {
                    string dt = tc.PreviousCell.Text;
                    dt = dt.Substring(dt.IndexOf(" ") + 1);
                    int qty = 0;

                    if (this.wiresSent != null)
                    { 
                        var elem = this.wiresSent.Find(c => c.dateSent == dt);
                        if (elem != null)  
                            qty = elem.qty;
                    }
                    tc.Text = qty.ToString();
                }
                else
                    if (tc.Name.StartsWith("Amt"))
                    {
                        string dt = tc.PreviousCell.PreviousCell.Text;
                        dt = dt.Substring(dt.IndexOf(" ") + 1);
                        decimal amt = 0;
                      
                        if (this.wiresSent != null)
                        {
                            var elem = this.wiresSent.Find(c => c.dateSent == dt);
                            if (elem != null)
                                amt = elem.amount;
                         }
                        tc.Text = string.Format("{0:$#,##0.00}", amt);
                    }
              
            }
      

        }

        private void xrTCommission_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            DateTime fDate = Convert.ToDateTime(GetCurrentColumnValue("TransactionDateFrom"));//Convert.ToDateTime(fromDate.Text);
            DateTime tDate = Convert.ToDateTime(GetCurrentColumnValue("TransactionDateTo")); //Convert.ToDateTime(toDate.Text);
            int diff = tDate.Subtract(fDate).Days;
          
            IFormatProvider fp;

            if (Convert.ToInt32(this.Parameters["LanguageId"].Value) == 1)
            {
                fp = new CultureInfo("en-Us");
            }
            else
                fp = new CultureInfo("es-MX");

         
            int posInitial = xrTCommission.Rows.Count - 1;
            xrTCommission.BeginInit();
            for (int i = 0; i <= diff; i++)
            {
                this.xrTCommission.InsertRowBelow(this.xrTCommission.Rows[posInitial + i]);

                var s = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(fDate.AddDays(i).ToString("dddd", fp));

               (this.xrTCommission.Rows[posInitial + i + 1].Cells[0] as XRLabel).Text = s + " "  + fDate.AddDays(i).ToString("MM/dd/yy");

                this.xrTCommission.Rows[posInitial + i + 1].Cells[1].Name = "Comm_" + i.ToString();
                this.xrTCommission.Rows[posInitial + i + 1].Cells[1].PrintOnPage += new PrintOnPageEventHandler(cellCommission_PrintOnPage);


            }

            this.xrTCommission.DeleteRow((xrTCommission.Rows[1]));

            xrTCommission.AdjustSize();
            xrTCommission.EndInit();
        }


        void cellCommission_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRTableCell tc = sender as XRTableCell;
            if (tc.Name.IndexOf('_') > 0)
            {
                if (tc.Name.StartsWith("Comm"))
                    {
                        string dt = tc.PreviousCell.Text;
                        dt = dt.Substring(dt.IndexOf(" ") + 1);
                        decimal amt = 0;

                        if (this.wiresSent != null)
                        {
                            var elem =this.wiresSent.Find(c => c.dateSent == dt);
                            if (elem != null)
                                amt = elem.commission;
                        }
                        tc.Text = string.Format("{0:$#,##0.00}", amt);
                    }

            }


        }

        private void RptInvoice_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            currentBalance = Convert.ToDecimal(GetCurrentColumnValue("BeginingBalance"));
        }

      
        private void xrQtyPayments_PrintOnPage_1(object sender, PrintOnPageEventArgs e)
        {
            (sender as XRLabel).Text = qtyPayments.ToString();
        }

        private void xrLabel17_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            (sender as XRLabel).Text = (sender as XRLabel).Text.ToLower().Trim();
        }

        private void xrLabel20_PrintOnPage_1(object sender, PrintOnPageEventArgs e)
        {
            (sender as XRLabel).Text = (sender as XRLabel).Text.ToLower().Trim();
        }

        private void RptInvoice_DataSourceDemanded(object sender, EventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);
            (sender as RptInvoice).WireTransac.ConnectionParameters = dataConnectionParametersBase;

            dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireSecurityConnectionString);
            (sender as RptInvoice).WireSecurity.ConnectionParameters = dataConnectionParametersBase;
        }

        private void xrInfoHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            (sender as XRLabel).Text = string.Format("{0}\n{1}: {2}\n{3}: {4}\n{5}: {6}\n\n{7} {8}",
                                                       xrIHLine1.Text.Trim(),
                                                       xrIHFax.Text.Trim(),
                                                       xrIHFaxValue.Text.Trim(),
                                                       xrIHEmail.Text.Trim(),
                                                       xrIHEmailValue.Text.Trim(),
                                                       xrIHPhone.Text.Trim(),
                                                       xrIHPhoneValue.Text.Trim(),
                                                       xrIHLineEnd.Text.Trim(),
                                                       xrIHLineEndValue.Text.Trim());
        }

        private void xrPanel8_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            var qtyDC = this.wiresSent != null ? this.wiresSent.FindAll(c => c.qtyDebitCard != 0).Count : 0;

            (sender as XRPanel).Visible = qtyDC != 0;
        }

        private void xrTDebitCard_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            DateTime fDate = Convert.ToDateTime(GetCurrentColumnValue("TransactionDateFrom"));//Convert.ToDateTime(fromDate.Text);
            DateTime tDate = Convert.ToDateTime(GetCurrentColumnValue("TransactionDateTo")); //Convert.ToDateTime(toDate.Text);
            int diff = tDate.Subtract(fDate).Days;

            IFormatProvider fp;

            if (Convert.ToInt32(this.Parameters["LanguageId"].Value) == 1)
            {
                fp = new CultureInfo("en-Us");
            }
            else
                fp = new CultureInfo("es-MX");


            int posInitial = xrTDebitCard.Rows.Count - 1;
            xrTDebitCard.BeginInit();
            for (int i = 0; i <= diff; i++)
            {
                this.xrTDebitCard.InsertRowBelow(this.xrTDebitCard.Rows[posInitial + i]);

                var s = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(fDate.AddDays(i).ToString("dddd", fp));

                (this.xrTDebitCard.Rows[posInitial + i + 1].Cells[0] as XRLabel).Text = s + " " + fDate.AddDays(i).ToString("MM/dd/yy");

                this.xrTDebitCard.Rows[posInitial + i + 1].Cells[1].Name = "Qty_" + i.ToString();
                this.xrTDebitCard.Rows[posInitial + i + 1].Cells[1].PrintOnPage += new PrintOnPageEventHandler(cellDebitCard_PrintOnPage);

                this.xrTDebitCard.Rows[posInitial + i + 1].Cells[2].Name = "Amt_" + i.ToString();
                this.xrTDebitCard.Rows[posInitial + i + 1].Cells[2].PrintOnPage += new PrintOnPageEventHandler(cellDebitCard_PrintOnPage);

              
            }

            this.xrTDebitCard.DeleteRow((xrTDebitCard.Rows[1]));

            xrTDebitCard.AdjustSize();
            xrTDebitCard.EndInit();
        }

        void cellDebitCard_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            XRTableCell tc = sender as XRTableCell;
            if (tc.Name.IndexOf('_') > 0)
            {
                if (tc.Name.StartsWith("Qty"))
                { 
                   string dt = tc.PreviousCell.Text;
                   dt = dt.Substring(dt.IndexOf(" ") + 1);
                   int qty = 0;
                   if (this.wiresSent != null)
                    {
                        var elem = this.wiresSent.Find(c => c.dateSent == dt);
                        if (elem != null)
                            qty = elem.qtyDebitCard;
                    }
                   tc.Text = string.Format("{0}", qty);
                }
                else
                    if (tc.Name.StartsWith("Amt"))
                    {
                        string dt = tc.PreviousCell.PreviousCell.Text;
                        dt = dt.Substring(dt.IndexOf(" ") + 1);
                        decimal amt = 0;
                        if (this.wiresSent != null)
                        {
                            var elem = this.wiresSent.Find(c => c.dateSent == dt);
                            if (elem != null)
                                amt = elem.amountDebitCard;
                        }
                        tc.Text = string.Format("{0:$#,##0.00}", amt);
                    }

            }


        }

        private void xrTransDate_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            DateTime dt1 = Convert.ToDateTime(GetCurrentColumnValue("TransactionDateFrom"));
            DateTime dt2 = Convert.ToDateTime(GetCurrentColumnValue("TransactionDateTo"));
            string st = string.Empty;

            if (dt1 == dt2)
            {
                st = dt1.ToString("MM/dd/yy");
            }
            else
                st = string.Format("{0} - {1}", dt1.ToString("MM/dd/yy"), dt2.ToString("MM/dd/yy"));

            (sender as XRLabel).Text = st;
        }

       

        private void xrLabel6_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            (sender as XRLabel).Text = string.Format("{0} {1}", xrCommiPaidNote.Text, xrCommyType.Text);
        }

        private void GroupFooter1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            bool showAgComm = Convert.ToBoolean(GetCurrentColumnValue("ShowAgCommiStatement"));
            bool showAgFax = GetCurrentColumnValue("AgFaxMessageText") != null && !string.IsNullOrEmpty(GetCurrentColumnValue("AgFaxMessageText").ToString());
            int inTransit = Convert.ToInt32(GetCurrentColumnValue("QTransit"));

            var qtyDC = this.wiresSent != null ? this.wiresSent.FindAll(c => c.qtyDebitCard != 0).Count : 0;

            (sender as GroupFooterBand).Visible = (showAgComm || showAgFax || qtyDC > 0 || inTransit > 0);
        }

        private void xrQtyBP_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            (sender as XRLabel).Text = qtyBP.ToString();
        }

        private void xrAmountBP_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            (sender as XRLabel).Text = string.Format("{0:$#,##0.00}", amountBP);
        }

        private void xrTableRow9_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            (sender as XRTableRow).Visible = qtyBP > 0;  
        }

        private void xrQtyDebitCard_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            (sender as XRLabel).Text = qtyDebitCard.ToString();
        }

        private void xrDebitCardAmount_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            (sender as XRLabel).Text = string.Format("{0:$#,##0.00}", amountDebitCard);
        }

        private void xrTableRow10_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            (sender as XRTableRow).Visible = qtyDebitCard > 0;  
        }

        private void xrTableRow10_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            e.Cancel = qtyDebitCard ==  0;
        }

        private void xrTableRow9_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            e.Cancel = qtyBP == 0;
        }
      
    }
}
