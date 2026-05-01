using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEbAPIEntities.Common;
using WebAPIReports.Tools.MoneyOrders;

namespace WebAPIBusiness.MoneyOrders
{
    public class BSMoneyOrders
    {
        #region properties
             private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(BSInvoice));
        #endregion
        public BSMoneyOrders()
        {

        }

        #region publics

        public TResultStream MOInvoiceToStream(TParameters param, string format)
        {
            TResultStream rs = new TResultStream();
            try
            {
                rs = new ToolMoneyOrders().MOInvoiceToStream(param, format);
               
            }
            catch (Exception ex)
            {
                log.ErrorFormat("MOInvoiceToStream ERROR: {0}", ex.Message);
                rs.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return rs;
        }

        public TResultStream MOInvoiceToStreamSmall(TParameters param, string format)
        {
            TResultStream rs = new TResultStream();
            try
            {
                rs = new ToolMoneyOrders().MOInvoiceToStreamSmall(param, format);

            }
            catch (Exception ex)
            {
                log.ErrorFormat("MOInvoiceToStreamSmall ERROR: {0}", ex.Message);
                rs.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return rs;
        }

        public TResultStream MOIssuedToStream(TParameters param, string format)
        {
            TResultStream rs = new TResultStream();
            try
            {
                rs = new ToolMoneyOrders().MOIssuedToStream(param, format);

            }
            catch (Exception ex)
            {
                log.ErrorFormat("MOIssuedToStream ERROR: {0}", ex.Message);
                rs.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return rs;
        }

        public TResultStream MOIssuedToStreamSmall(TParameters param, string format)
        {
            TResultStream rs = new TResultStream();
            try
            {
                rs = new ToolMoneyOrders().MOIssuedToStreamSmall(param, format);

            }
            catch (Exception ex)
            {
                log.ErrorFormat("MOIssuedToStreamSmall ERROR: {0}", ex.Message);
                rs.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return rs;
        }
        #endregion

    }
}
