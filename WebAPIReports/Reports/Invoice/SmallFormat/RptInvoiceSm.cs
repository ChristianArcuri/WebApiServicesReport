using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Core.ConditionalFormatting;

using System.Collections.Generic;
using System.Globalization;
using WebAPIReports.Reports.Invoice.Common.Model;

namespace WebAPIReports.Reports.Invoice.SmallFormat
{
    public partial class RptInvoiceSm : DevExpress.XtraReports.UI.XtraReport
    {
        #region properties
      
        public int qtyPayments { get; set; }
        public decimal amountPayments { get; set; }
        public int qtyOther { get; set; }
        public decimal amountOther { get; set; }
        public int qtyCancellation { get; set; }
        public decimal amountCancellation{ get; set; }
        public int qtyDebitCard { get; set; }
        public decimal amountDebitCard { get; set; }
        public List<WiresByDate> wiresSent { get; set; }
        public int qtyBP { get; set; }
        public decimal amountBP { get; set; }

        int pages;
        #endregion
        public RptInvoiceSm()
        {
            InitializeComponent();

            this.wiresSent = new List<WiresByDate>();
        }


        private void xrPaymentAmount_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            (sender as XRLabel).Text = string.Format(Constants.MoneyFormat, amountPayments);
        }

        private void xrQtyOtherCredits_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            (sender as XRLabel).Text = qtyOther.ToString();
         }

        private void xrOtherAmount_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            (sender as XRLabel).Text = string.Format(Constants.MoneyFormat, amountOther);
        }

        private void xrQtyCancellations_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            (sender as XRLabel).Text = qtyCancellation.ToString();
        }

        private void xrCancellationAmount_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            (sender as XRLabel).Text = string.Format(Constants.MoneyFormat, amountCancellation);
          }

       private void xrTSummary_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            DateTime fDate = Convert.ToDateTime(GetCurrentColumnValue("TransactionDateFrom"));
            DateTime tDate = Convert.ToDateTime(GetCurrentColumnValue("TransactionDateTo"));
            int diff = tDate.Subtract(fDate).Days;

                   
           int posInitial = xrTSummary.Rows.Count - 3;
            (sender as XRTable).BeginInit();
             for (int i = 0; i <= diff; i ++)
                {
                    this.xrTSummary.InsertRowBelow(this.xrTSummary.Rows[posInitial + i]);


                    (this.xrTSummary.Rows[posInitial + i + 1].Cells[0] as XRLabel).Text = xrWiresLabel.Text + " " + fDate.AddDays(i).ToString(Constants.DateFormat);

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
            if (pages > 0)
                xrRightInfoHeader.Visible = false;
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
                        tc.Text = string.Format(Constants.MoneyFormat, amt);
                    }
              
            }
      

        }

        private void xrTCommission_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            DateTime fDate = Convert.ToDateTime(GetCurrentColumnValue("TransactionDateFrom")); 
            DateTime tDate = Convert.ToDateTime(GetCurrentColumnValue("TransactionDateTo")); 
            int diff = tDate.Subtract(fDate).Days;

         
            int posInitial = xrTCommission.Rows.Count - 1;
            xrTCommission.BeginInit();
            for (int i = 0; i <= diff; i++)
            {
                this.xrTCommission.InsertRowBelow(this.xrTCommission.Rows[posInitial + i]);

               (this.xrTCommission.Rows[posInitial + i + 1].Cells[0] as XRLabel).Text = fDate.AddDays(i).ToString(Constants.DateFormat);

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
                        tc.Text = string.Format(Constants.MoneyFormat, amt);
                    }

            }


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
            (sender as RptInvoiceSm).WireTransac.ConnectionParameters = dataConnectionParametersBase;

            dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireSecurityConnectionString);
            (sender as RptInvoiceSm).WireSecurity.ConnectionParameters = dataConnectionParametersBase;
        }

        private void fromDate_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            DateTime fDate = Convert.ToDateTime(GetCurrentColumnValue("TransactionDateFrom"));
            DateTime tDate = Convert.ToDateTime(GetCurrentColumnValue("TransactionDateTo"));

            string st = string.Empty;

            if (fDate == tDate)
            {
                st = fDate.ToString(Constants.DateFormat);
            }
            else
                st = string.Format("{0} - {1}", fDate.ToString(Constants.DateFormat), tDate.ToString(Constants.DateFormat));

            (sender as XRLabel).Text = st;
        }

        private void xrPanel8_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            var qtyDC = this.wiresSent != null ? this.wiresSent.FindAll(c => c.qtyDebitCard != 0).Count : 0;

            (sender as XRPanel).Visible = qtyDC != 0;
        }

        private void xrTDebitCard_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            DateTime fDate = Convert.ToDateTime(GetCurrentColumnValue("TransactionDateFrom"));
            DateTime tDate = Convert.ToDateTime(GetCurrentColumnValue("TransactionDateTo")); 
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

                (this.xrTDebitCard.Rows[posInitial + i + 1].Cells[0] as XRLabel).Text = s + " " + fDate.AddDays(i).ToString(Constants.DateFormat);

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
                        tc.Text = string.Format(Constants.DateFormat, amt);
                    }

            }


        }

        private void xrTableCell8_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            (sender as XRTableCell).Text = (sender as XRTableCell).Text.ToUpper();
        }

        private void xrTableCell7_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            (sender as XRTableCell).Text = (sender as XRTableCell).Text.ToUpper();
        }

        private void xrLine4_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            var qtyDC = this.wiresSent != null ? this.wiresSent.FindAll(c => c.qtyDebitCard != 0).Count : 0;

            (sender as XRLine).Visible = qtyDC != 0;
        }

        private void xrQtyBP_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            (sender as XRLabel).Text = qtyBP.ToString();
        }

        private void xrAmountBP_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            (sender as XRLabel).Text = string.Format(Constants.MoneyFormat, amountBP);
        }

        private void xrTableRow9_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            (sender as XRTableRow).Visible = qtyBP > 0;  
        }

        private void xrDebitCardAmount_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            (sender as XRLabel).Text = string.Format(Constants.MoneyFormat, amountDebitCard);
        }

        private void xrQtyDebitCard_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            (sender as XRLabel).Text = qtyDebitCard.ToString();
        }

        private void xrTableRow10_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            e.Cancel = qtyDebitCard == 0;
        }

      
    }

    
}
