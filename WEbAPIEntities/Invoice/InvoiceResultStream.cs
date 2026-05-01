using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEbAPIEntities.Invoice
{
    public class InvoiceResultStream: InvoiceResult
    {
        public byte[] StreamInfo { get; set; }
     
        public InvoiceResultStream()
            : base()
         {
             StreamInfo = null;
         }
    }
}
