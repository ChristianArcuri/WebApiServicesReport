using System;
using System.Collections.Generic;
using System.Web.Http;
using WebAPIBusiness.BillPayment;
using WEbAPIEntities.Invoice;
using WebAPIServices.Filters;


namespace WebAPIServices.Controllers
{
    [RoutePrefix("api/BillPymtEndOfDayRpt")]
    [APIAuthorize]
    public class BillPymtEndOfDayReportController : ApiController
    {
        [HttpPost]
        public InvoiceResultStream BillPymtEndOfDayRptToStreamPDF([FromBody] InvoiceParameters param)
        {
            InvoiceResultStream rs = new InvoiceResultStream();

            if (param != null && param.parameters != null)
            {
                rs = new BSBillPymt().BillPymtEndOfDayRptToStreamPDF(param);
            }

            return rs;
        }

    }
}