using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebAPIBusiness.FXFAX;
using WEbAPIEntities.Common;
using WEbAPIEntities.FXFAX;
using WebAPIServices.Filters;

namespace WebAPIServices.Controllers
{
    [RoutePrefix("api/FxFax")]
    [APIAuthorize]
    public class FxFaxController : ApiController
    {
        [HttpPost]
        public TResultStream ReportFXToStream([FromBody]TParametersInput param)
        {
            TResultStream rs = new TResultStream();
            if (param != null && param.parameters != null)
            {
                rs = new BSFxFax().FXFAXToStream(param, param.Format ?? "PDF");
            }
            return rs;
        }

        [HttpPost]
        public TResultStream ReportFXSmallToStream([FromBody]TParametersInput param)
        {
            TResultStream rs = new TResultStream();
            if (param != null && param.parameters != null)
            {
                rs = new BSFxFax().FXFAXSmallToStream(param, param.Format ?? "PDF");
            }
            return rs;
        }
        [HttpPost]
        public TResultStream ReportFXMultiplesToStream([FromBody]TParametersInput param)
        {
            TResultStream rs = new TResultStream();
            if (param != null && param.parameters != null)
            {
                rs = new BSFxFax().FXFAXMultiplesToStream(param, param.Format ?? "PDF");
            }
            return rs;
        }

        [HttpPost]
        public async Task<FxFaxResultBatch> FxFaxBatchProcess([FromBody] FxFaxBatchParameters param)
        {
            FxFaxResultBatch result = new FxFaxResultBatch();
            if (param != null && param.Reports != null && param.Reports.Count > 0)
            {
                result = await new BSFxFax().FXFAXBatchProcess(param);
            }
            return result;
        }

        
        [HttpPost]
        public async Task<FxFaxResultBatch> FxFaxBatchProcessAsync([FromBody] FxFaxBatchParameters param)
        {
            FxFaxResultBatch result = new FxFaxResultBatch();

            if (param != null && param.Reports != null && param.Reports.Count > 0)
            {
                result = await new BSFxFax().FXFAXBatchProcessAsync(param);
            }

            return result;
        }


        [HttpPost]
        public FxFaxResultBatch FxFaxBatchInfo([FromBody]int param)
        {
            return new BSFxFax().FXFAXBatchInfo(param);
        }
    }
}
