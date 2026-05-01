using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WEbAPIEntities.Invoice;
using WebAPIServices.Filters;
using WebAPIBusiness.AgencyOverview;

namespace WebAPIServices.Controllers
{
    [RoutePrefix("api/RegulatoryComplianceRpt")]
    [APIAuthorize]
    public class RegulatoryComplianceRptController:  ApiController
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
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/SentWiresRpt/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/SentWiresRpt/5
        public void Delete(int id)
        {
        }
        #endregion        

        [HttpPost]
        public InvoiceResultStream RegulatoryComplianceRptToStream([FromBody] InvoiceParameters param)
        {
            InvoiceResultStream rs = new InvoiceResultStream();

            if (param != null && param.parameters != null)
            {
                rs = new BSRegulatoryComplianceRpt().RegulatoryComplianceRptToStream(param, param.Format ?? "PDF");
            }

            return rs;
        }

        [HttpPost]
        public InvoiceResultStream RegulatoryComplianceRptToStreamV2([FromBody] InvoiceParameters param)
        {
            InvoiceResultStream rs = new InvoiceResultStream();

            if (param != null && param.parameters != null)
            {
                rs = new BSRegulatoryComplianceRpt().RegulatoryComplianceRptToStreamV2(param, param.Format ?? "PDF");
            }

            return rs;
        }
    }
}