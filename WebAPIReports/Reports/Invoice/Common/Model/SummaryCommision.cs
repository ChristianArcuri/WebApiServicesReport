using System;

namespace WebAPIReports.Reports.Invoice.Common.Model
{
    public enum KindSummary : short { Wires = 0, BillPayment = 1, TopUpsTittle = 2, WiresPaid = 3, Payments = 4, Other = 5, Cancellations = 6, DebitCredit = 7, WiresInbound = 8 }

    public class SummaryCommision
    {
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public KindSummary Summary { get; set; }
    }

    
}
