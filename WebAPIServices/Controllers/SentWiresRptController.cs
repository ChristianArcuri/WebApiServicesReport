using System;
using System.Collections.Generic;
using System.Web.Http;
using WebAPIBusiness.AgencyOverview;
using WEbAPIEntities.Invoice;
using WebAPIServices.Filters;

namespace WebAPIServices.Controllers
{
    [RoutePrefix("api/SentWiresRpt")]
    [APIAuthorize]
    public class SentWiresRptController : ApiController
    {
        #region defaults
        // GET: api/SentWiresRpt
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SentWiresRpt/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SentWiresRpt
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/SentWiresRpt/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SentWiresRpt/5
        public void Delete(int id)
        {
        }
        #endregion

        [HttpPost]
        public InvoiceResultStream SentWiresRptToStreamPDF([FromBody]InvoiceParameters param)
        {
            InvoiceResultStream rs = new InvoiceResultStream();

            if (param != null && param.parameters != null)
            {
                if (!param.parameters.ContainsKey("AllowViewCommissions"))
                    param.parameters.Add(new KeyValuePair<string,string>("AllowViewCommissions", "false"));

                rs = new BSSentWiresRpt().SentWiresRptToStreamPDF(param);
            }

            return rs;
        }

        [HttpPost]
        public InvoiceResultStream SentWiresRptSmallToStreamPDF([FromBody]InvoiceParameters param)
        {
            InvoiceResultStream rs = new InvoiceResultStream();

            if (param != null && param.parameters != null)
            {
                rs = new BSSentWiresRpt().SentWiresRptSmallToStreamPDF(param);
            }

            return rs;
        }

        [HttpPost]
        public InvoiceResultStream SentWiresRptToStream([FromBody] InvoiceParameters param)
        {
            InvoiceResultStream rs = new InvoiceResultStream();

            if (param != null && param.parameters != null)
            {
                rs = new BSSentWiresRpt().SentWiresRptToStream(param, param.Format ?? "PDF");
            }

            return rs;
        }

        [HttpPost]
        public InvoiceResultStream SentWiresRptSmallToStream([FromBody] InvoiceParameters param)
        {
            InvoiceResultStream rs = new InvoiceResultStream();

            if (param != null && param.parameters != null)
            {
                rs = new BSSentWiresRpt().SentWiresRptSmallToStream(param, param.Format ?? "PDF");
            }

            return rs;
        }
    }
}
