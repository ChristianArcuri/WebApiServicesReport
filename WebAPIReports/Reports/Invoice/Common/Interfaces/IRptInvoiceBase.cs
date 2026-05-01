using System.Collections.Generic;
using WebAPIReports.Reports.Invoice.Common.Model;

namespace WebAPIReports.Reports.Invoice.Common.Interfaces
{
    public interface IRptInvoiceBase
    {
        decimal currentBalance { get; set; }
        int qtyPayments { get; set; }
        decimal amountPayments { get; set; }
        int qtyOther { get; set; }
        decimal amountOther { get; set; }
        int qtyCancellation { get; set; }
        decimal amountCancellation { get; set; }
        int qtyBP { get; set; }
        decimal amountBP { get; set; }

        int qtyTopUp { get; set; }
        decimal amountTopUp { get; set; }

        int qtyDebitCard { get; set; }
        decimal amountDebitCard { get; set; }
        decimal totalPayDueInbound { get; set; }
        List<WiresByDate> wiresPaid { get; set; }
        List<WiresByDate> wiresSent { get; set; }
        List<SummaryCommision> Commissions { get; set; }
        List<SummaryCardPayments> CardPayment { get; set; }

    }
}
