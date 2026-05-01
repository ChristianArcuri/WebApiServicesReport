using System.Collections.Generic;
using System.Web.Http;
using WEbAPIEntities.Invoice;
using WebAPIBusiness;
using WebAPIServices.Filters;
using System.Threading.Tasks;

namespace WebAPIServices.Controllers
{
    [RoutePrefix("api/Invoice")]
    [APIAuthorize]
    public class InvoiceController : ApiController
    {
        #region defaults
        //// GET api/<controller>
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<controller>
        //public void Post([FromBody]string value)
        //{
        //    value += "hhh";
        //}

        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
        #endregion

       
        #region actions
    
        [HttpPost]
        public InvoiceResultStream InvoiceToStreamPDF([FromBody]InvoiceParameters param)
        {
            InvoiceResultStream rs = new InvoiceResultStream();
            if (param != null && param.parameters != null)
            {
                rs = new BSInvoice().InvoiceToStreamPDF(param);
            }
            return rs;
        }

        [HttpPost]
        public InvoiceResultStream InvoiceToStreamXLSX([FromBody] InvoiceParameters param)
        {
            InvoiceResultStream rs = new InvoiceResultStream();
            if (param != null && param.parameters != null)
            {
                rs = new BSInvoice().InvoiceToStreamXLSX(param);
            }
            return rs;
        }

        [HttpPost]
        public InvoiceResultStream InvoiceToStreamPRNX([FromBody]InvoiceParameters param)
        {
            InvoiceResultStream rs = new InvoiceResultStream();
            if (param != null && param.parameters != null)
            {
                rs = new BSInvoice().InvoiceToStreamPRNX(param);
            }
            return rs;
        }


        [HttpPost]
        public InvoiceResultStream InvoiceToStreamPNG(InvoiceParameters param)
        {
        InvoiceResultStream rs = new InvoiceResultStream();
        if (param != null && param.parameters != null)
        {
            rs = new BSInvoice().InvoiceToStreamPNG(param);
        }
    
        return rs;
        }

        [HttpPost]
        public InvoiceResultStream InvoiceToStreamHTML(InvoiceParameters param)
        {
            InvoiceResultStream rs = new InvoiceResultStream();
            if (param != null && param.parameters != null)
            {
                rs = new BSInvoice().InvoiceToStreamHTML(param);
            }

            return rs;
        }

        [HttpPost]
        public InvoiceResultStream InvoiceToStreamTXTSmall(InvoiceParameters param)
        {
            InvoiceResultStream rs = new InvoiceResultStream();
            if (param != null && param.parameters != null)
            {
                rs = new BSInvoice().InvoiceToStreamTXTSmall(param);
            }
          
            return rs;
        }

        [HttpPost]
        public InvoiceResultStream InvoiceToStreamHTMLSmall(InvoiceParameters param)
        {
            InvoiceResultStream rs = new InvoiceResultStream();
            if (param != null && param.parameters != null)
            {
                rs = new BSInvoice().InvoiceToStreamHTMLSmall(param);
            }

            return rs;
        }

        [HttpPost]
        public InvoiceResultStream InvoiceToStreamPDFSmall(InvoiceParameters param)
        {
            InvoiceResultStream rs = new InvoiceResultStream();
            if (param != null && param.parameters != null)
            {
                rs = new BSInvoice().InvoiceToStreamPDFSmall(param);
            }

            return rs;
        }
       
        [HttpPost]
        public async Task<InvoiceResultBatch> InvoiceBatchProcess([FromBody]InvoiceBatchParameters param)
        {
            InvoiceResultBatch result = new InvoiceResultBatch();
            if (param != null && param.Statements != null && param.Statements.Count > 0)
            {
                result = await new BSInvoice().InvoiceBatchProcess(param);
            }
            return result;
        }

        [HttpPost]
        public InvoiceResultBatch InvoiceBatchInfo([FromBody]int param)
        {
           return new BSInvoice().InvoiceBatchInfo(param);
        }

        [HttpGet]
        public List<InvoiceBatchInfo> InvoiceFaxEmailLogRead()
        {
            return new BSInvoice().InvoiceFaxEmailLogRead();
        }

        [HttpPost]
        public InvoiceResultStream OneInvoiceToStreamPDF([FromBody]InvoiceParameters param)
        {
            InvoiceResultStream rs = new InvoiceResultStream();
            if (param != null && param.parameters != null)
            {
                rs = new BSInvoice().OneInvoiceToStreamPDF(param);
            }
            return rs;
        }
     
        #endregion
    }

}