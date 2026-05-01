using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIBusiness.Receipt;
using WEbAPIEntities.Common;
using WebAPIServices.Filters;

namespace WebAPIServices.Controllers
{
    [RoutePrefix("api/Receipt")]
    [APIAuthorize]
    public class ReceiptController : ApiController
    {
        [HttpPost]
        public TResultStream ReceiptToStreamPDF([FromBody]TParameters param)
        {
            TResultStream rs = new TResultStream();
            if (param != null && param.parameters != null)
            {
                rs = new BSReceipt().ReceiptToStreamPDF(param);
            }
            return rs;
        }
    }
}
