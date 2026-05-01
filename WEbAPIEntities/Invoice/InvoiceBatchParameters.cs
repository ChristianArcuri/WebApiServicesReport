using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEbAPIEntities.Invoice
{
    public class InvoiceBatchParameters
    {
        public string UserName;
        public string ComputerName;
        public IList<Invoice> Statements;

    }

    public class Invoice
    {
        public string   StatementId;
        public string   AgencyCode;
        public string   SendingMethod;
        public int      DeliverHour;
        public int      DeliverMin;
        public string   AgencyEmail;
        public int      LanguageId;
        public int      WiresSent;
        public int      TimeZone;

    }
}
