using System.Collections.Generic;
using System.Web.Http;
using WebAPIBusiness.AgencyOverview;
using WEbAPIEntities.Invoice;
using WebAPIServices.Filters;

namespace WebAPIServices.Controllers
{
    [RoutePrefix("api/EndOfDayRpt")]
   [APIAuthorize]
    public class EndOfDayRptController : ApiController
    {
        #region defaults
        // GET: api/EndOfDayRpt
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/EndOfDayRpt/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/EndOfDayRpt
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/EndOfDayRpt/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/EndOfDayRpt/5
        public void Delete(int id)
        {
        }
        #endregion
       
        [HttpPost]
        public InvoiceResultStream EndOfDayRptToStreamPDF([FromBody]InvoiceParameters param)
        {
            InvoiceResultStream rs = new InvoiceResultStream();

            if (param != null && param.parameters != null)
            {
                rs = new BSEndOfDayRpt().EndOfDayRptToStreamPDF(param);
            }

            return rs;
        }

        [HttpPost]
        public InvoiceResultStream EndOfDayRptToStreamPDFV2([FromBody] InvoiceParameters param)
        {
            InvoiceResultStream rs = new InvoiceResultStream();

            if (param != null && param.parameters != null)
            {
                rs = new BSEndOfDayRpt().EndOfDayRptToStreamPDFV2(param);
            }

            return rs;
        }

        [HttpPost]
        public InvoiceResultStream EndOfDayRptToStreamPDFV3([FromBody] InvoiceParameters param)
        {
            InvoiceResultStream rs = new InvoiceResultStream();

            if (param != null && param.parameters != null)
            {
                rs = new BSEndOfDayRpt().EndOfDayRptToStreamPDFV3(param);
            }

            return rs;
        }
    }
}
