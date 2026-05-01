using System;
using System.Collections.Generic;
using System.Web.Http;
using WebAPIBusiness.AgencyOverview;
using WEbAPIEntities.Invoice;
using WebAPIServices.Filters;

namespace WebAPIServices.Controllers
{
    [RoutePrefix("api/combinedReports")]
    [APIAuthorize]
    public class CombinedRptController : ApiController
    {
        [HttpPost]
        public InvoiceResultStream CombinedRptToStreamPDF([FromBody] InvoiceParameters param)
        {
            InvoiceResultStream rs = new InvoiceResultStream();

            if (param != null && param.parameters != null)
            {
                rs = new BSCombinedRpt().CombinedRptToStreamPDF(param);
            }

            return rs;
        }

        [HttpPost]
        public InvoiceResultStream CombinedSummaryRptToStreamPDF([FromBody] InvoiceParameters param)
        {
            InvoiceResultStream rs = new InvoiceResultStream();

            if (param != null && param.parameters != null)
            {
                rs = new BSCombinedRpt().CombinedSummaryRptToStreamPDF(param);
            }

            return rs;
        }
    }
}
