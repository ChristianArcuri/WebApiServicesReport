using WEbAPIEntities.Common;
using WebAPIReports.Reports.Checks;

namespace WebAPIReports.Tools.Checks
{
    public class ToolChecks:Tools
    {
        #region public


        public TResultStream CheckProcessedToStream(TParameters param, string format)
        {
            RptCompanyChecksProcessed report = new RptCompanyChecksProcessed();
            return ReportToStream(report, param, format);
        }

        public TResultStream CheckProcessedToStreamSmall(TParameters param, string format)
        {
            var report = new RptCompanyChecksProcessedSm();
            return ReportToStream(report, param, format);
        }

        public TResultStream RegulatoryLogToStream(TParameters param, string format)
        {
            RptCompanyChecksRegulatoryLog report = new RptCompanyChecksRegulatoryLog();
            return ReportToStream(report, param, format);
        }

        public TResultStream CheckItemsToStream(TParameters param, string format)
        {
            RptCheckItems report = new RptCheckItems();
            return ReportToStream(report, param, format);
        }

        public TResultStream CheckFeeCommissionToStream(TParameters param, string format)
        {
            CheckFeeCommissionsReport report = new CheckFeeCommissionsReport();
            return ReportToStream(report, param, format);
        }

        public TResultStream CheckFeeCommissionToStreamSmall(TParameters param, string format)
        {
            RptCheckFeeCommissionsSm report = new RptCheckFeeCommissionsSm();
            return ReportToStream(report, param, format);
        }

        public TResultStream CheckItemsToStreamV2(TParameters param, string format)
        {
            RptCompanyCheckItemV2 report = new RptCompanyCheckItemV2();
            return ReportToStream(report, param, format);
        }

        public TResultStream CheckBatchToStream(TParameters param, string format)
        {
            RptCompanyChecksBatch report = new RptCompanyChecksBatch();
            return ReportToStream(report, param, format);
        }

        public TResultStream CheckBatchSummaryToStream(TParameters param, string format)
        {
            RptCompanyChecksBatchSummary report = new RptCompanyChecksBatchSummary();
            return ReportToStream(report, param, format);
        }

        #endregion
    }
}
