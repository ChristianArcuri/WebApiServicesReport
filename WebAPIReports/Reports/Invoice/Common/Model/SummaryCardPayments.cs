using System;

namespace WebAPIReports.Reports.Invoice.Common.Model
{
    public class SummaryCardPayments
    {
        public DateTime Date { get; set; }
        public int QtyMovs { get; set; }
        public decimal Amount { get; set; }
        public KindSummary Summary { get; set; }
    }
}
