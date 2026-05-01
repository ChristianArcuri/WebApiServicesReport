using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEbAPIEntities.Common;

using WebAPIReports.Tools.Receipt;

namespace WebAPIBusiness.Receipt
{
    public class BSReceipt
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(BSInvoice));
        public BSReceipt()
        {

        }

        #region publics
        public TResultStream ReceiptToStreamPDF(TParameters param)
        {
            TResultStream rs = new TResultStream();
             try
             { 
                rs = new ToolReceipt().ReceiptToStreamPDF(param);
             }
                catch (Exception ex)
             {
                 log.ErrorFormat("InvoiceToStreamPDF ERROR: {0}", ex.Message);
                 rs.SetMessages(ErrorResult.UnexpectedError, ex.Message);
             }
            return rs;
        }
        #endregion
    }
}
