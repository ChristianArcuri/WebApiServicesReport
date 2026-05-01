using System;
using System.Collections.Generic;
using System.Web.Http;
using WebAPIBusiness.BillPayment;
using WEbAPIEntities.Invoice;
using WebAPIServices.Filters;


namespace WebAPIServices.Controllers
{
    [RoutePrefix("api/BillPymtRpt")]
    [APIAuthorize]
    public class BillPymtController : ApiController
    {
        [HttpPost]
        public InvoiceResultStream BillPymtProcessedBillsRptToStreamPDF([FromBody] InvoiceParameters param)
        {
            InvoiceResultStream rs = new InvoiceResultStream();

            if (param != null && param.parameters != null)
            {
                rs = new BSProcessedBills().ProcessedBillsRptToStreamPDF(param);
            }
            return rs;
        }
    }
}