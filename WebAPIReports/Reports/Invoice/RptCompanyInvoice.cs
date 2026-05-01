using System;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.Globalization;
using WebAPIReports.Reports.Invoice.Common.Interfaces;
using WebAPIReports.Reports.Invoice.Common.Model;
using DevExpress.DataAccess.ConnectionParameters;
using System.Linq;
using DevExpress.DataAccess.Sql.DataApi;

namespace WebAPIReports.Reports.Invoice
{
    public partial class RptCompanyInvoice : DevExpress.XtraReports.UI.XtraReport, IRptInvoiceBase
    {
        #region properties
        public decimal currentBalance { get; set; }
        public int qtyPayments { get; set; }
        public decimal amountPayments { get; set; }
        public int qtyOther { get; set; }
        public decimal amountOther { get; set; }
        public int qtyCancellation { get; set; }
        public decimal amountCancellation { get; set; }
        public int qtyBP { get; set; }
        public decimal amountBP { get; set; }

        public int qtyTopUp { get; set; }
        public decimal amountTopUp { get; set; }

        public int qtyDebitCard { get; set; }
        public decimal amountDebitCard { get; set; }
        public List<WiresByDate> wiresSent { get; set; }
        public List<WiresByDate> wiresPaid { get; set; }

        public List<SummaryCommision> Commissions { get; set; }
        public List<SummaryCardPayments> CardPayment { get; set; }
        public decimal totalPayDueInbound { get; set; }

        int pages;
        int InitialPosWires = 0;
        public bool isAgPayerDomestic = false;
        IEnumerable<DateTime> FinalWiresDateRange = null,
                              FinalCrdPymntsDtRange = null,
                              FinalWiresPaidDateRange = null;
        #endregion
        public RptCompanyInvoice()
        {
            InitializeComponent();
            xrLine3.DataBindings.Add(new XRBinding("Color", this.WireTransac, "Acc_Invoice_Agency_Header(@StatementId).ReportColorForeground"));
            xrLine4.DataBindings.Add(new XRBinding("Color", this.WireTransac, "Acc_Invoice_Agency_Header(@StatementId).ReportColorForeground"));
            xrLine5.DataBindings.Add(new XRBinding("Color", this.WireTransac, "Acc_Invoice_Agency_Header(@StatementId).ReportColorForeground"));
            wiresSent = new List<WiresByDate>();
            Commissions = new List<SummaryCommision>();
            CardPayment = new List<SummaryCardPayments>();
            wiresPaid = new List<WiresByDate>();
        }

        /// <summary>
        /// Event for adding summary for wires, only structure, we need await call to subreport for getting data.
        /// </summary>
        private void xrTSummary_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            InitialPosWires = xrTSummary.Rows.Count - 1;
            ITable Labels = this.WireSecurity.Result[0];
            (sender as XRTable).BeginInit();

            if (qtyPayments >= 0)
                InitialPosWires = AddRegisterSummary(InitialPosWires, ((string)Labels[0]["Payments"]).Trim(), qtyPayments, amountPayments);

            if (qtyOther >= 0)
                InitialPosWires = AddRegisterSummary(InitialPosWires, ((string)Labels[0]["OtherDebitCredit"]).Trim(), qtyOther, amountOther);

            if (qtyCancellation >= 0)
                InitialPosWires = AddRegisterSummary(InitialPosWires, ((string)Labels[0]["Cancellations"]).Trim(), qtyCancellation, amountCancellation);

            if (qtyDebitCard > 0)
                InitialPosWires = AddRegisterSummary(InitialPosWires, ((string)Labels[0]["DebitCard"]).Trim(), qtyDebitCard, amountDebitCard);

            //Wirs by range in the statement
            InitialPosWires = FinalWiresDateRange.GroupJoin(wiresSent, A => A, W => DateTime.ParseExact(W.dateSent, Constants.DateFormat, CultureInfo.InvariantCulture), (D, W) => new { D, W = W.FirstOrDefault() })
            .Aggregate(InitialPosWires, (Ac, WireInfo) =>
            {
                return AddRegisterSummary(Ac, string.Format("{0} {1}", (string)Labels[0]["Wires"], WireInfo.D.ToString(Constants.DateFormat)), WireInfo.W != null ? WireInfo.W.qty : 0, WireInfo.W != null ? WireInfo.W.amount : 0M);
            });

            if (qtyBP > 0)
                InitialPosWires = AddRegisterSummary(InitialPosWires, ((string)Labels[0]["BillPayment"]).Trim(), qtyBP, amountBP);

            if (qtyTopUp > 0)
                InitialPosWires = AddRegisterSummary(InitialPosWires, ((string)Labels[0]["TopUpsTittle"]).Trim(), qtyTopUp, amountTopUp);


            //Wires Paid
            isAgPayerDomestic = Convert.ToBoolean(xrAgPayerDomestic.Text);
            if (isAgPayerDomestic)
            {
                InitialPosWires = FinalWiresPaidDateRange.GroupJoin(wiresPaid, A => A, W => DateTime.ParseExact(W.dateSent, Constants.DateFormat, CultureInfo.InvariantCulture), (D, W) => new { D, W = W.FirstOrDefault() })
                .Aggregate(InitialPosWires, (Ac, WireInfo) =>
                {
                    return AddRegisterSummary(Ac, string.Format("{0} {1}", (string)Labels[0]["WiresPaid"], WireInfo.D.ToString(Constants.DateFormat)), WireInfo.W != null ? WireInfo.W.qty : 0, WireInfo.W != null ? WireInfo.W.amount : 0M);
                });
            }

            (sender as XRTable).AdjustSize();
            (sender as XRTable).EndInit();
        }

        private int AddRegisterSummary(int postion, string Tittle, int Qty, decimal Amount)
        {
            XRTableRow current = null;
            xrTSummary.InsertRowBelow(xrTSummary.Rows[postion]);
            current = xrTSummary.Rows[postion + 1];
            current.Cells[0].Text = Tittle;
            current.Cells[1].Text = Qty.ToString();
            current.Cells[2].Text = string.Format(Constants.MoneyFormat, Amount);
            return ++postion;
        }

        private void PageHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            pages++;
        }

        private IEnumerable<DateTime> EnumerateDates(DateTime from, DateTime to)
        {
            while (from <= to)
            {
                yield return from;
                from = from.AddDays(1);
            }
        }

        private void xrTCommission_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //Fake values for days without commission only for wires.
            IEnumerable<DateTime> wiresRange = EnumerateDates((DateTime)GetCurrentColumnValue("TransactionDateFrom"), (DateTime)GetCurrentColumnValue("TransactionDateTo"));
            wiresRange.GroupJoin(Commissions.Where(D => D.Summary == KindSummary.Wires), A => A, B => B.Date, (A, B) => new { Fecha = A, Exists = B.Count() > 0 })
                       .Aggregate(Commissions, (Ac, Nxt) =>
                       {
                           if (!Nxt.Exists)
                               Ac.Add(new SummaryCommision() { Date = Nxt.Fecha, Summary = KindSummary.Wires, Amount = 0 });
                           return Ac;
                       });

            IFormatProvider fp = Convert.ToInt32(this.Parameters["LanguageId"].Value) == 1 ? new CultureInfo("en-Us") : new CultureInfo("es-MX");
            ITable Multilanguaje = WireSecurity.Result.Where(T => T.Name == "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)").FirstOrDefault();

            xrTCommission.BeginInit();
            string NameDay = string.Empty;
            Commissions.GroupBy(S => S.Summary).OrderBy(S => (int)S.Key).Aggregate(xrTCommission, (table, NxC) =>
            {
                string Tittle = (string)Multilanguaje[0][NxC.Key.ToString()];
                NxC.OrderBy(S => S.Date).Aggregate(table, (tbl, NxRw) =>
                {
                    NameDay = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(NxRw.Date.ToString("dddd", fp));
                    tbl.InsertRowBelow(table.Rows[table.Rows.Count - 1]);
                    tbl.Rows[tbl.Rows.Count - 1].Cells[0].Text = string.Format("{0} {1}", NameDay, NxRw.Date.ToString(Constants.DateFormat));
                    tbl.Rows[tbl.Rows.Count - 1].Cells[1].Text = Tittle;
                    tbl.Rows[tbl.Rows.Count - 1].Cells[2].Text = string.Format(Constants.MoneyFormat, NxRw.Amount);
                    return tbl;
                });
                return table;
            });
            //remove first row "Model Row"
            xrTCommission.DeleteRow(xrTCommission.Rows[1]);
            xrTCommission.EndInit();
        }

        private void RptInvoice_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            currentBalance = Convert.ToDecimal(GetCurrentColumnValue("BeginingBalance"));
            IRow rset = WireSecurity.Result[0].FirstOrDefault();
            xrPagerInfo1.TextFormatString = xrPageInfo2.TextFormatString = rset["Page"] + " {0} " + rset["Of"] + " {1}";

            //Process for summary actions
            if (!(bool)this.IsInvoiceForCaribe.Value)
            { (new SummaryByReport(KindSummary.Wires, xrSubWires)).Process(); }
            else
            { (new SummaryByReport(KindSummary.WiresInbound, xrSubWiresInbound)).Process(); }
            (new SummaryByReport(KindSummary.TopUpsTittle, xrSRTopUps)).Process();
            (new SummaryByReport(KindSummary.BillPayment, xrSubBillPayment)).Process();
            (new SummaryByReport(KindSummary.Cancellations, xrSubCancellations)).Process();
            (new SummaryByReport(KindSummary.Payments, xrSubPayment)).Process();
            (new SummaryByReport(KindSummary.Other, xrSubOther)).Process();
            (new SummaryByReport(KindSummary.WiresPaid, xrSRWiresPaid)).Process();
            (new SummaryByReport(KindSummary.DebitCredit, xrSubDebitCard)).Process();

            //range according statement
            FinalWiresDateRange = EnumerateDates((DateTime)GetCurrentColumnValue("TransactionDateFrom"), (DateTime)GetCurrentColumnValue("TransactionDateTo"));
            FinalWiresDateRange = wiresSent.GroupJoin(FinalWiresDateRange, A => A.dateSent, D => D.ToString(Constants.DateFormat), (A, B) => new { _Date = DateTime.ParseExact(A.dateSent, Constants.DateFormat, CultureInfo.InvariantCulture), exists = B.Count() > 0 })
                           .Where(D => !D.exists)
                           .Select(D => D._Date)
                           .OrderBy(S => S.Date)
                           .Concat(FinalWiresDateRange);

            //Range creditCard payments
            FinalCrdPymntsDtRange = EnumerateDates((DateTime)GetCurrentColumnValue("TransactionDateFrom"), (DateTime)GetCurrentColumnValue("TransactionDateTo"));
            FinalCrdPymntsDtRange = CardPayment.GroupBy(S => S.Date)
                                    .GroupJoin(FinalWiresDateRange, A => A.Key, B => B.Date, (A, B) => new { _Date = A.Key, exists = B.Count() > 0 })
                                    .Where(D => !D.exists)
                                    .Select(D => D._Date)
                                    .OrderBy(D => D)
                                    .Concat(FinalCrdPymntsDtRange);

            FinalWiresPaidDateRange = EnumerateDates((DateTime)GetCurrentColumnValue("TransactionDateFrom"), (DateTime)GetCurrentColumnValue("TransactionDateTo"));
            FinalWiresPaidDateRange = wiresPaid.GroupJoin(FinalWiresPaidDateRange, A => A.dateSent, D => D.ToString(Constants.DateFormat), (A, B) => new { _Date = DateTime.ParseExact(A.dateSent, Constants.DateFormat, CultureInfo.InvariantCulture), exists = B.Count() > 0 })
                            .Where(D => !D.exists)
                            .Select(D => D._Date)
                            .OrderBy(S => S.Date)
                            .Concat(FinalWiresPaidDateRange);

        }

        private void RptInvoice_DataSourceDemanded(object sender, EventArgs e)
        {
            RptCompanyInvoice rpt = sender as RptCompanyInvoice;
            rpt.WireTransac.ConnectionParameters = new MsSqlConnectionParameters();
            rpt.WireTransac.Connection.ConnectionString = WebAPIDataAccess.DAConnectionStrings.WireTransacReadOnlyConnectionString;

            rpt.WireSecurity.ConnectionParameters = new MsSqlConnectionParameters();
            rpt.WireSecurity.Connection.ConnectionString = WebAPIDataAccess.DAConnectionStrings.WireSecurityReadonlyConnectionString;
        }

        private void xrPanel8_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            var qtyDC = this.wiresSent != null ? this.wiresSent.FindAll(c => c.qtyDebitCard != 0).Count : 0;

            (sender as XRPanel).Visible = qtyDC != 0;
        }

        /// <summary>
        /// it adds summary for debit card,
        /// it happens after wires subreport and we have available data for rendering structure and data
        /// </summary>
        private void xrTDebitCard_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            int posInitial = xrTDebitCard.Rows.Count - 1;
            IEnumerable<DateTime> rangeDates = EnumerateDates((DateTime)GetCurrentColumnValue("TransactionDateFrom"), (DateTime)GetCurrentColumnValue("TransactionDateTo"));
            IFormatProvider fp = Convert.ToInt32(this.Parameters["LanguageId"].Value) == 1 ? new CultureInfo("en-Us") : new CultureInfo("es-MX");

            string dayName = string.Empty;
            XRTableRow currenrRw = null;
            xrTDebitCard.BeginInit();
            FinalCrdPymntsDtRange.GroupJoin(CardPayment, A => A, B => B.Date, (A, B) => new Tuple<DateTime, IEnumerable<SummaryCardPayments>>(A, B))
                      .Aggregate(0, (Acc, Nxt) =>
                      {
                          dayName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Nxt.Item1.ToString("dddd", fp));
                          xrTDebitCard.InsertRowBelow(xrTDebitCard.Rows[posInitial + Acc]);
                          currenrRw = xrTDebitCard.Rows[posInitial + Acc + 1];
                          currenrRw.Cells[0].Text = string.Format("{0} {1}", dayName, Nxt.Item1.ToString(Constants.DateFormat));
                          currenrRw.Cells[1].Text = string.Format("{0}", Nxt.Item2 != null ? Nxt.Item2.Sum(Q => Q.QtyMovs) : 0);
                          currenrRw.Cells[2].Text = string.Format(Constants.MoneyFormat, Nxt.Item2 != null ? Nxt.Item2.Sum(Q => Q.Amount) : 0);
                          return ++Acc;
                      });
            xrTDebitCard.DeleteRow(xrTDebitCard.Rows[1]);
            xrTDebitCard.AdjustSize();
            xrTDebitCard.EndInit();
        }

        private void xrTransDate_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            DateTime dt1 = Convert.ToDateTime(GetCurrentColumnValue("TransactionDateFrom"));
            DateTime dt2 = Convert.ToDateTime(GetCurrentColumnValue("TransactionDateTo"));
            string st = string.Empty;

            if (dt1 == dt2)
            {
                st = dt1.ToString(Constants.DateFormat);
            }
            else
                st = string.Format("{0} - {1}", dt1.ToString(Constants.DateFormat), dt2.ToString(Constants.DateFormat));

            (sender as XRLabel).Text = st;
        }

        private void xrLabel25_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if ((bool)this.IsInvoiceForCaribe.Value)
            {
                (sender as XRLabel).Text = string.Format("{0:$#,##0.00}", totalPayDueInbound);
            }
        }

        private void xrLabel11_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if ((bool)this.IsInvoiceForCaribe.Value)
            {
                totalPayDueInbound = currentBalance + totalPayDueInbound;
                xrLabel11.Text = string.Format("{0:$#,##0.00}", totalPayDueInbound);
            }
        }

        private void xrLabel6_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            (sender as XRLabel).Text = string.Format("{0} {1}", xrCommiPaidNote.Text, xrCommyType.Text);
        }

        private void GroupFooter1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            bool showAgComm = Convert.ToBoolean(GetCurrentColumnValue("ShowAgCommiStatement"));
            bool showAgFax = !string.IsNullOrEmpty(GetCurrentColumnValue("AgFaxMessageText") as string);
            int inTransit = Convert.ToInt32(GetCurrentColumnValue("QTransit"));

            var qtyDC = this.wiresSent != null ? this.wiresSent.FindAll(c => c.qtyDebitCard != 0).Count : 0;

            (sender as GroupFooterBand).Visible = (showAgComm || showAgFax || qtyDC > 0 || inTransit > 0);
        }
    }
}
