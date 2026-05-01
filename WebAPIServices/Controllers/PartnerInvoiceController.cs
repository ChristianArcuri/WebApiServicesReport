using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIBusiness;
using WEbAPIEntities.Common;
using WebAPIServices.Filters;

namespace WebAPIServices.Controllers
{
    [RoutePrefix("api/PartnerInvoice")]
    [APIAuthorize]
    public class PartnerInvoiceController : ApiController
    {
        [HttpPost]
        public TResultStream InvoiceToStream([FromBody]TParametersInput param)
        {
            TResultStream rs = new TResultStream();
            if (param != null && param.parameters != null)
            {
                rs = new BSPartnerInvoice().PartnerInvoiceToStream(param, param.Format ?? "PDF");
            }
            return rs;
        }
    }
}
