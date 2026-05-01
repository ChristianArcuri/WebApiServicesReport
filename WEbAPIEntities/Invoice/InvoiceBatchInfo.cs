using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEbAPIEntities.Invoice
{
    public class InvoiceBatchInfo
    {
        public int BatchID { get; set; }
        public int TotalFaxes{ get; set; }
        public string FaxStartTime { get; set; }
        public string FaxEndTime { get; set; }
        public int FaxTime { get; set; }
        public int TotalEmails { get; set; }
        public string EmailStartTime { get; set; }
        public string EmailEndTime { get; set; }
        public int EmailTime { get; set; }
        public DateTime Created { get; set; }
        public string UserName { get; set; }

        public string EmailsError { get; set; }
    }
}
