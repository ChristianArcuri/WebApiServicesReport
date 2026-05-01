using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIServices.Filters;
using WebAPIBusiness.MoneyOrders;
using WEbAPIEntities.Common;


namespace WebAPIServices.Controllers
{
    [RoutePrefix("api/MoneyOrders")]
    [APIAuthorize]
    public class MoneyOrdersController : ApiController
    {
        [HttpPost]
        public TResultStream InvoiceToStream([FromBody]TParametersInput param)
        {
            TResultStream rs = new TResultStream();
            if (param != null && param.parameters != null)
            {
                rs = new BSMoneyOrders().MOInvoiceToStream(param, param.Format ?? "PDF");
            }
            return rs;
        }

        [HttpPost]
        public TResultStream InvoiceToStreamSmall([FromBody] TParametersInput param)
        {
            TResultStream rs = new TResultStream();
            if (param != null && param.parameters != null)
            {
                rs = new BSMoneyOrders().MOInvoiceToStreamSmall(param, param.Format ?? "PDF");
            }
            return rs;
        }

        [HttpPost]
        public TResultStream IssuedToStream([FromBody]TParametersInput param)
        {
            TResultStream rs = new TResultStream();
            if (param != null && param.parameters != null)
            {
                rs = new BSMoneyOrders().MOIssuedToStream(param, param.Format ?? "PDF");
            }
            return rs;
        }

        [HttpPost]
        public TResultStream IssuedToStreamSmall([FromBody] TParametersInput param)
        {
            TResultStream rs = new TResultStream();
            if (param != null && param.parameters != null)
            {
                rs = new BSMoneyOrders().MOIssuedToStreamSmall(param, param.Format ?? "PDF");
            }
            return rs;
        }
    }
}
