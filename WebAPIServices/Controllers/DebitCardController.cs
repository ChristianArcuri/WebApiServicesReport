using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebAPIBusiness.DebitCard;
using WEbAPIEntities.Common;
using WebAPIServices.Filters;

namespace WebAPIServices.Controllers
{
    [RoutePrefix("api/DebitCard")]
    [APIAuthorize]
    public class DebitCardController : ApiController
    {
        [HttpPost]
        public TResultStream EndOfTheDaysReportToStream([FromBody] TParametersInput param)
        {
            TResultStream rs = new TResultStream();
            if (param != null && param.parameters != null)
            {
                rs = new BSDebitCard().EndOfTheDaysReportToStream(param, param.Format ?? "PDF");
            }
            return rs;
        }

    }
}