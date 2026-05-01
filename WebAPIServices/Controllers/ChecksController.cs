using System.Web.Http;
using WebAPIBusiness.Checks;
using WEbAPIEntities.Common;
using WebAPIServices.Filters;

namespace WebAPIServices.Controllers
{
    [RoutePrefix("api/Checks")]
    [APIAuthorize]
    public class ChecksController : ApiController
    {
        [HttpPost]
        public TResultStream ChecksProcessedToStream([FromBody]TParametersInput param)
        {
            TResultStream rs = new TResultStream();
            if (param != null && param.parameters != null)
            {
                rs = new BSChecks().CheckProcessedToStream(param, param.Format ?? "PDF");
            }
            return rs;
        }

        [HttpPost]
        public TResultStream ChecksProcessedToStreamSmall([FromBody] TParametersInput param)
        {
            TResultStream rs = new TResultStream();
            if (param != null && param.parameters != null)
            {
                rs = new BSChecks().CheckProcessedToStreamSmall(param, param.Format ?? "PDF");
            }
            return rs;
        }

        [HttpPost]
        public TResultStream ChecksRegulatoryLogsToStream([FromBody]TParametersInput param)
        {
            TResultStream rs = new TResultStream();
            if (param != null && param.parameters != null)
            {
                rs = new BSChecks().CheckRegulatoryLogToStream(param, param.Format ?? "PDF");
            }
            return rs;
        }

        [HttpPost]
        public TResultStream CheckItemsToStream([FromBody]TParametersInput param)
        {
            TResultStream rs = new TResultStream();
            if (param != null && param.parameters != null)
            {
                rs = new BSChecks().CheckItemsToStream(param, param.Format ?? "PDF");
            }
            return rs;
        }

        [HttpPost]
        public TResultStream CheckFeeCommissionToStream([FromBody]TParametersInput param)
        {
            TResultStream rs = new TResultStream();
            if (param != null && param.parameters != null)
            {
                rs = new BSChecks().CheckFeeCommissionToStream(param, param.Format ?? "PDF");
            }
            return rs;
        }

        [HttpPost]
        public TResultStream CheckFeeCommissionToStreamSmall([FromBody] TParametersInput param)
        {
            TResultStream rs = new TResultStream();
            if (param != null && param.parameters != null)
            {
                rs = new BSChecks().CheckFeeCommissionToStreamSmall(param, param.Format ?? "PDF");
            }
            return rs;
        }

        [HttpPost]
        public TResultStream CheckItemsToStreamV2([FromBody]TParametersInput param)
        {
            TResultStream rs = new TResultStream();
            if (param != null && param.parameters != null)
            {
                rs = new BSChecks().CheckItemsToStreamV2(param, param.Format ?? "PDF");
            }
            return rs;
        }

        [HttpPost]
        public TResultStream ChecksBatchToStream([FromBody] TParametersInput param)
        {

            TResultStream rs = new TResultStream();
            if (param != null && param.parameters != null)
            {
                rs = new BSChecks().CheckBatchToStream(param, param.Format ?? "PDF");
            }
            return rs;
            
        }

        [HttpPost]
        public TResultStream ChecksBatchSummaryToStream([FromBody] TParametersInput param)
        {
            TResultStream rs = new TResultStream();

            if (param != null && param.parameters != null)
            {
                rs = new BSChecks().CheckBatchSummaryToStream(param, param.Format ?? "PDF");
            }

            return rs;
        }
    }
}
