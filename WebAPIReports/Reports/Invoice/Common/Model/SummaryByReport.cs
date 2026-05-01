using DevExpress.Data;
using DevExpress.DataAccess;
using DevExpress.DataAccess.Sql;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using WebAPIReports.Reports.Invoice.Common.Interfaces;

namespace WebAPIReports.Reports.Invoice.Common.Model
{
    public class SummaryByReport
    {
        KindSummary _type;
        XRSubreport _rpt = null;
        public SummaryByReport(KindSummary type, XRSubreport rpt)
        {
            _type = type;
            _rpt = rpt;
        }

        public void Process()
        {
            SqlDataSource srcReport = null;
            _rpt.ApplyParameterBindings();
            if (_type == KindSummary.Wires)
                srcReport = (_rpt.ReportSource as RptInvoiceWires).WireTransac;
            else if (_type == KindSummary.TopUpsTittle)
                srcReport = (_rpt.ReportSource as RptTopUp).WireTransac;
            else if (_type == KindSummary.BillPayment)
                srcReport = (_rpt.ReportSource as RptInvoiceBillPayment).WireTransac;
            else if (_type == KindSummary.Other)
                srcReport = (_rpt.ReportSource as RptInvoiceOther).WireTransac;
            else if (_type == KindSummary.Payments)
                srcReport = (_rpt.ReportSource as RptInvoicePayment).WireTransac;
            else if (_type == KindSummary.Cancellations)
                srcReport = (_rpt.ReportSource as RptInvoiceCancellations).WireTransac;
            else if (_type == KindSummary.WiresPaid)
                srcReport = (_rpt.ReportSource as RptWiresPaid).WireTransac;
            else if (_type == KindSummary.DebitCredit)
                srcReport = (_rpt.ReportSource as RptInvoiceDebitCard).WireTransac;
            else if (_type == KindSummary.WiresInbound)
                srcReport = (_rpt.ReportSource as RptInvoiceWiresInbound).WireTransac;
            _rpt.ReportSource.DataSource = ExecuteQuery(srcReport, WebAPIDataAccess.DAConnectionStrings.WireTransacReadOnlyConnectionString);
            ProcessSummary();
        }

        private void ProcessSummary()
        {
            DataSet Source = _rpt.ReportSource.DataSource as DataSet;
            IRptInvoiceBase masterReport = _rpt.ReportSource.MasterReport as IRptInvoiceBase;
            switch (_type)
            {
                case KindSummary.Wires:
                    ProcessWires(Source, "Acc_Invoice_WireTransfers(@StatementId)", masterReport);
                    break;
                case KindSummary.TopUpsTittle:
                    ProcessTopUps(Source, "Acc_Invoice_TopUps(@StatementId)", masterReport);
                    break;
                case KindSummary.BillPayment:
                    PorcessBillPayment(Source, "Acc_Invoice_BillPayment(@StatementId)", masterReport);
                    break;
                case KindSummary.Other:
                    ProcessOther(Source, "Acc_Invoice_OtherCreditsDebits(@StatementId)", masterReport);
                    break;
                case KindSummary.Payments:
                    ProcessPayments(Source, "Acc_Invoice_Payments(@StatementId)", masterReport);
                    break;
                case KindSummary.Cancellations:
                    ProcessCancellations(Source, "Acc_Invoice_Cancellations(@StatementId)", masterReport);
                    break;
                case KindSummary.WiresPaid:
                    ProcessWiresPaid(Source, "Acc_Invoice_WiresPaid(@StatementId)", masterReport);
                    break;
                case KindSummary.DebitCredit:
                    ProcessDebitAndCredit(Source, "Acc_Invoice_DebitCard(@StatementId)", masterReport);
                    break;
                case KindSummary.WiresInbound:
                    ProcessWiresInboud(Source, "Acc_Invoice_WireTransfers_Inbound(@StatementId)", masterReport);
                    break;
            }
        }

        //Map SqlDatasource to Native ADO objects to avoid multiple executions
        private DataSet ExecuteQuery(SqlDataSource sourceinfo, string ConnectionString)
        {
            DataSet _DataSet = new DataSet("WireTransac");
            using (SqlDataAdapter adp = new SqlDataAdapter())
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    //Mapping only for Store procedure query.
                    sourceinfo.Queries
                        .Select(D => D as StoredProcQuery)
                        .Where(S => S != null)
                        .Select(D => new { cmd = new SqlCommand(D.StoredProcName, con), qparams = D.Parameters, Member = D.Name })
                        .Select(R =>
                        {
                            //find values linked between parameter in query and parameter in report.
                            //When parameter is associated to parmeter report it uses expressionString 
                            //for specify the parametr [Paramaters.Parametername].
                            R.qparams.Join(_rpt.ReportSource.Parameters.Cast<IParameter>()
                                           , Qp => (Qp.Value as Expression).ExpressionString
                                           , Rp => string.Format("[Parameters.{0}]", Rp.Name)
                                           , (Qp, Rp) => new SqlParameter(Qp.Name, Rp.Value))
                                     .Aggregate(R.cmd, (Ac, Nxt) => { Ac.Parameters.Add(Nxt); return Ac; });
                            R.cmd.CommandType = CommandType.StoredProcedure;
                            R.cmd.CommandTimeout = 45;
                            return new { R.cmd, R.Member };
                        })
                        .Aggregate(adp, (ad, nxt) =>
                        {
                            try
                            {
                                using (adp.SelectCommand = nxt.cmd)
                                {
                                    adp.Fill(_DataSet, nxt.Member);
                                    nxt.cmd.Connection = null;
                                }
                            }
                            catch (SqlException ex)
                            {
                                throw new Exception(string.Format("Error on executing {0}, Message: {1}", adp.SelectCommand.CommandText, ex.Message));
                            }
                            return ad;
                        });
                }
            }
            return _DataSet;
        }

        private void ProcessTopUps(DataSet source, string Name, IRptInvoiceBase Report)
        {
            int qtyDebitCard = 0;
            decimal AmountDebitCard = 0M;
            //Summary by day
            source.Tables.Cast<DataTable>().Where(T => T.TableName == Name).Aggregate(0, (Ac, tbl) =>
            {
                decimal current = 0;
                tbl.Rows.Cast<DataRow>()
                   .GroupBy(rtpup => (DateTime)rtpup["Date"])
                   .Aggregate(Report, (mReport, Gpos) =>
                   {
                       //Summary Commision by day
                       current = Gpos.Aggregate(0M, (TotalDayTpUp, day) =>
                       {
                           //WE have an amount by credit/debit card
                           if ((string)day["Type"] == "PY")
                           {
                               qtyDebitCard++;
                               AmountDebitCard += (decimal)day["ActivityBalance"] * -1;
                           }
                           //countin de top up, only movment that has amount
                           mReport.qtyTopUp += (decimal)day["Amount"] != 0 ? 1 : 0;
                           //Add accumulate value for put in summary
                           mReport.amountTopUp = (long)day["Position"] == 1 ? (decimal)day["Accumulate"] : 0M;
                           //after we will work with commisions.
                           return TotalDayTpUp + (decimal)day["MontlyCommission"];
                       });

                       //Adding summary for cards
                       if (qtyDebitCard > 0)
                           mReport.CardPayment.Add(new SummaryCardPayments() { Date = Gpos.Key, Amount = AmountDebitCard, QtyMovs = qtyDebitCard, Summary = KindSummary.TopUpsTittle });
                       //commission by day
                       mReport.Commissions.Add(new SummaryCommision() { Date = Gpos.Key, Summary = KindSummary.TopUpsTittle, Amount = current });
                       return mReport;
                   });
                return Ac;
            });
        }

        private void ProcessWires(DataSet source, string Name, IRptInvoiceBase Report)
        {
            int qtyDebitCard;
            decimal AmountDebitCard;
            source.Tables.Cast<DataTable>().Where(T => T.TableName == Name).Aggregate(0, (A, B) =>
            {
                WiresByDate current = null;
                //Summaty by date
                B.Rows.Cast<DataRow>().GroupBy(S => (DateTime)S["TransactionDate"]).Aggregate(Report, (AG, Nxt) =>
                {
                    qtyDebitCard = Nxt.Count(R => (string)R["Type"] == "PY");
                    AmountDebitCard = Nxt.Sum(R => (string)R["Type"] == "PY" ? -1 * (decimal)R["ActivityBalance"] : 0);

                    current = new WiresByDate()
                    {
                        dateSent = Nxt.Key.ToString(Constants.DateFormat),
                        amount = Nxt.Sum(R => (decimal)R["ActivityBalance"]),
                        commission = Nxt.Sum(R => (decimal)R["MonthlyCommission"]),
                        qty = Nxt.Count(R => (string)R["Type"] == "WS"),
                        amountDebitCard = AmountDebitCard,
                        qtyDebitCard = qtyDebitCard
                    };

                    //Counting payments card
                    if (qtyDebitCard > 0)
                        AG.CardPayment.Add(new SummaryCardPayments() { QtyMovs = qtyDebitCard, Amount = AmountDebitCard, Date = Nxt.Key, Summary = KindSummary.Wires });

                    AG.Commissions.Add(new SummaryCommision() { Amount = current.commission, Date = Nxt.Key, Summary = KindSummary.Wires });
                    AG.wiresSent.Add(current);
                    return AG;
                });
                return A;
            });
        }

        private void PorcessBillPayment(DataSet source, string Name, IRptInvoiceBase Report)
        {
            //We create summary for each day and create global result by day.
            source.Tables.Cast<DataTable>().Where(S => S.TableName == Name).Aggregate(0, (A, B) =>
            {
                decimal current = 0;
                B.Rows
                 .Cast<DataRow>()
                 .GroupBy(D => (DateTime)D["TransactionDate"])
                 .Aggregate(Report, (mReport, dayBP) =>
                 {
                     current += dayBP.Aggregate(0M, (BpAcc, curPay) =>
                     {
                         current = (decimal)curPay["BTTotAmountInv"];
                         mReport.qtyBP += current != 0 ? 1 : 0;
                         mReport.amountBP += current;
                         return BpAcc + (decimal)curPay["MonthlyCommission"];
                     });

                     //Comission by day
                     mReport.Commissions.Add(new SummaryCommision() { Date = dayBP.Key, Amount = current, Summary = KindSummary.BillPayment });
                     return mReport;
                 });
                return A;
            });
        }

        private void ProcessOther(DataSet source, string Name, IRptInvoiceBase Report)
        {
            source.Tables.Cast<DataTable>().Where(S => S.TableName == Name).Aggregate(0, (A, B) =>
            {
                B.Rows.Cast<DataRow>().Select(D => (decimal)D["Amount"]).Where(S => S != 0).Aggregate(Report, (Ac, Am) =>
                {
                    Ac.qtyOther++;
                    Ac.amountOther += Am;
                    return Ac;
                });
                return A;
            });
        }

        private void ProcessPayments(DataSet source, string Name, IRptInvoiceBase Report)
        {
            source.Tables.Cast<DataTable>().Where(S => S.TableName == Name).Aggregate(0, (A, B) =>
            {
                B.Rows.Cast<DataRow>().Select(D => (decimal)D["Amount"]).Where(S => S != 0).Aggregate(Report, (Ac, Am) =>
                {
                    Ac.qtyPayments++;
                    Ac.amountPayments += Am;
                    return Ac;
                });
                return A;
            });
        }

        private void ProcessCancellations(DataSet source, string Name, IRptInvoiceBase Report)
        {
            source.Tables.Cast<DataTable>().Where(S => S.TableName == Name).Aggregate(0, (A, B) =>
            {
                B.Rows.Cast<DataRow>().Select(D => new KeyValuePair<string, decimal>((string)D["Type"], (decimal)D["ActivityBalance"]))
                .Aggregate(Report, (Ac, Am) =>
                {
                    if (Am.Key == "WC")
                        Ac.qtyCancellation++;
                    Ac.amountCancellation += Am.Value;
                    return Ac;
                });
                return A;
            });
        }

        private void ProcessWiresPaid(DataSet source, string Name, IRptInvoiceBase Report)
        {
            source.Tables.Cast<DataTable>().Where(T => T.TableName == Name).Aggregate(0, (A, B) =>
            {
                WiresByDate current = null;
                //Summaty by date
                B.Rows.Cast<DataRow>().GroupBy(S => (DateTime)S["TransactionDate"]).Aggregate(Report, (AG, Nxt) =>
                {
                    current = new WiresByDate()
                    {
                        dateSent = Nxt.Key.ToString(Constants.DateFormat),
                        amount = Nxt.Sum(R => (decimal)R["ActivityBalance"]),
                        qty = Nxt.Count(R => (int)R["Control"] > 0)
                    };

                    AG.wiresPaid.Add(current);
                    return AG;
                });
                return A;
            });
        }

        private void ProcessDebitAndCredit(DataSet source, string Name, IRptInvoiceBase Report)
        {
            source.Tables.Cast<DataTable>().Where(S => S.TableName == Name).Aggregate(0, (A, B) =>
            {
                B.Rows.Cast<DataRow>().Select(D => (decimal)D["TranAmountInv"]).Where(S => S != 0).Aggregate(Report, (Ac, Am) =>
                {
                    Ac.qtyDebitCard++;
                    Ac.amountDebitCard += Am;
                    return Ac;
                });
                return A;
            });
        }

        private void ProcessWiresInboud(DataSet source, string Name, IRptInvoiceBase Report)
        {
            int qtyDebitCard;
            decimal AmountDebitCard;
            source.Tables.Cast<DataTable>().Where(T => T.TableName == Name).Aggregate(0, (A, B) =>
            {
                WiresByDate current = null;
                //Summary by date
                B.Rows.Cast<DataRow>().GroupBy(S => (DateTime)S["TransactionDate"]).Aggregate(Report, (AG, Nxt) =>
                {
                    qtyDebitCard = Nxt.Count(R => (string)R["Type"] == "PY");
                    AmountDebitCard = Nxt.Sum(R => (string)R["Type"] == "PY" ? -1 * (decimal)R["ActivityBalance"] : 0);

                    current = new WiresByDate()
                    {
                        dateSent = Nxt.Key.ToString(Constants.DateFormat),
                        amount = Nxt.Sum(R => (decimal)R["ActivityBalance"]),
                        commission = Nxt.Sum(R => (decimal)R["MonthlyCommission"]),
                        qty = Nxt.Count(R => (string)R["Type"] == "WS"),
                        amountDebitCard = AmountDebitCard,
                        qtyDebitCard = qtyDebitCard
                    };

                    AG.totalPayDueInbound = AG.totalPayDueInbound + current.amount;

                    //Counting payments card
                    if (qtyDebitCard > 0)
                        AG.CardPayment.Add(new SummaryCardPayments() { QtyMovs = qtyDebitCard, Amount = AmountDebitCard, Date = Nxt.Key, Summary = KindSummary.Wires });

                    AG.Commissions.Add(new SummaryCommision() { Amount = current.commission, Date = Nxt.Key, Summary = KindSummary.Wires });
                    AG.wiresSent.Add(current);
                    return AG;
                });
                return A;
            });
        }
    }

}
