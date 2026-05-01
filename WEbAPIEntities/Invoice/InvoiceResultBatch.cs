using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEbAPIEntities.Invoice
{
    public class InvoiceResultBatch : InvoiceResult
    {
        public int BatchID { get; set; }
        public int FaxesSent { get; set; }
        public int EmailSent { get; set; }
        public bool IsProcessing { get; set; }
        public string LastAgencyFaxProcessed { get; set; }
        public string LastAgencyEmailProcessed { get; set; }

        public InvoiceResultBatch()
            : base()
         {
             BatchID = 0;
             FaxesSent = 0;
             EmailSent = 0;
             IsProcessing = false;
             LastAgencyFaxProcessed = string.Empty;
             LastAgencyEmailProcessed = string.Empty;
         }
    }
}
