using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEbAPIEntities.Invoice;
using WEbAPIEntities.Common;
using WebAPIBusiness.Utilities;
using WebAPIReports.Tools.Invoice;
using System.Threading;
using System.IO;

//using WebAPIDataAccess.WireSecurity;
using WebAPIDataAccess.WireTransac;
using WebAPIDataAccess.FAXOutgoing;
using System.Text.RegularExpressions;

using System.Configuration;
using System.Xml;
using WebAPIBusiness.WireTransac;
using WebAPIReports.Tools.PartnerInvoiceProcFee;

namespace WebAPIBusiness
{
    public class BSPartnerInvoice
    {
        #region properties


        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(BSInvoice));
        #endregion
        public BSPartnerInvoice()
        {

        }

        #region publics
      
        public TResultStream PartnerInvoiceToStream(TParameters param, string format)
        {
            TResultStream rs = new TResultStream();
            try
            {
                rs = new ToolPartnerInvoice().InvoiceToStream(param, format);
               
            }
            catch (Exception ex)
            {
                log.ErrorFormat("PartnerInvoiceToStream ERROR: {0}", ex.Message);
                rs.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return rs;
        }
        #endregion

       
    }
}
