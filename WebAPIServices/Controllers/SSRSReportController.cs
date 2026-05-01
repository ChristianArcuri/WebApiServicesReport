using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIBusiness.SSRS;
using WEbAPIEntities.SSRS;
using WebAPIServices.Filters;

namespace WebAPIServices.Controllers
{
    [RoutePrefix("api/SSRSReport")]
    [APIAuthorize]
    public class SSRSReportController : ApiController
    {
        [HttpPost]
        public SSRSResponseStream FxRptToStreamPDF([FromBody]ReportParameters param)
        {
            SSRSResponseStream rs = new SSRSResponseStream();

            if (param != null)
            {
                rs = new BSReportingSvcRpt().FxRptToStreamPDF(param);
            }

            return rs;
        }
    }
}
