using System;
using WEbAPIEntities.Common;
using WebAPIReports.Tools.Checks;

namespace WebAPIBusiness.Checks
{
    public class BSChecks
    {
        #region properties
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(BSInvoice));
        #endregion

        #region public

        public TResultStream CheckProcessedToStream(TParameters param, string format)
        {
            TResultStream rs = new TResultStream();
            try
            {
                rs = new ToolChecks().CheckProcessedToStream(param, format);

            }
            catch (Exception ex)
            {
                log.ErrorFormat("CheckProcessedToStream ERROR: {0}", ex.Message);
                rs.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return rs;
        }

        public TResultStream CheckProcessedToStreamSmall(TParameters param, string format)
        {
            TResultStream rs = new TResultStream();
            try
            {
                rs = new ToolChecks().CheckProcessedToStreamSmall(param, format);

            }
            catch (Exception ex)
            {
                log.ErrorFormat("CheckProcessedToStreamSmall ERROR: {0}", ex.Message);
                rs.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return rs;
        }

        public TResultStream CheckRegulatoryLogToStream(TParameters param, string format)
        {
            TResultStream rs = new TResultStream();
            try
            {
                rs = new ToolChecks().RegulatoryLogToStream(param, format);

            }
            catch (Exception ex)
            {
                log.ErrorFormat("CheckRegulatoryLogToStream ERROR: {0}", ex.Message);
                rs.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return rs;
        }

        public TResultStream CheckItemsToStream(TParameters param, string format)
        {
            TResultStream rs = new TResultStream();
            try
            {
                rs = new ToolChecks().CheckItemsToStream(param, format);

            }
            catch (Exception ex)
            {
                log.ErrorFormat("CheckItemsToStream ERROR: {0}", ex.Message);
                rs.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return rs;
        }

        public TResultStream CheckFeeCommissionToStream(TParameters param, string format)
        {
            TResultStream rs = new TResultStream();
            try
            {
                rs = new ToolChecks().CheckFeeCommissionToStream(param, format);

            }
            catch (Exception ex)
            {
                log.ErrorFormat("CheckFeeCommissions ERROR: {0}", ex.Message);
                rs.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return rs;
        }

        public TResultStream CheckFeeCommissionToStreamSmall(TParameters param, string format)
        {
            TResultStream rs = new TResultStream();
            try
            {
                rs = new ToolChecks().CheckFeeCommissionToStreamSmall(param, format);

            }
            catch (Exception ex)
            {
                log.ErrorFormat("CheckFeeCommissionToStreamSmall ERROR: {0}", ex.Message);
                rs.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return rs;
        }

        public TResultStream CheckItemsToStreamV2(TParameters param, string format)
        {
            TResultStream rs = new TResultStream();
            try
            {
                rs = new ToolChecks().CheckItemsToStreamV2(param, format);

            }
            catch (Exception ex)
            {
                log.ErrorFormat("CheckItemsToStream ERROR: {0}", ex.Message);
                rs.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return rs;
        }

        public TResultStream CheckBatchToStream(TParameters param, string format)
        {
            TResultStream rs = new TResultStream();
            try
            {
                rs = new ToolChecks().CheckBatchToStream(param, format);

            }
            catch (Exception ex)
            {
                log.ErrorFormat("CheckBatchToStream ERROR: {0}", ex.Message);
                rs.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return rs;
        }

        public TResultStream CheckBatchSummaryToStream(TParameters param, string format)
        {
            TResultStream rs = new TResultStream();
            try
            {
                rs = new ToolChecks().CheckBatchSummaryToStream(param, format);

            }
            catch (Exception ex)
            {
                log.ErrorFormat("CheckBatchSummaryToStream ERROR: {0}", ex.Message);
                rs.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return rs;
        }
        #endregion
    }
}
