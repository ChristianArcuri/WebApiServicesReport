using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEbAPIEntities.Invoice;
using WEbAPIEntities.Common;
using WebAPIReports.Reports.PartnerInvoiceProcFee;

using System.IO;
using System.Data;
using WebAPIDataAccess.WireTransac;
using WebAPIDataAccess.WireSecurity;

using System.Globalization;

namespace WebAPIReports.Tools.PartnerInvoiceProcFee
{
    public  class ToolPartnerInvoice:Tools
    {
        private  readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(ToolPartnerInvoice));

       
        #region publics


        public TResultStream InvoiceToStream(TParameters param, string format)
        {
            PartnerInvoice report = new PartnerInvoice();
            return ReportToStream(report, param, format);
        }


        #endregion
    }

  
}
