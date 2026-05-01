using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEbAPIEntities.Common;
using WebAPIReports.Reports.Checks;

namespace WebAPIReports.Tools.DebitCard
{
    public class ToolDebitCard : Tools
    {
        public TResultStream EndOfTheDayReportToStream(TParameters param, string format)
        {
            EndOfTheDayReportDebitCard report = new EndOfTheDayReportDebitCard();
            return ReportToStream(report, param, format);
        }
    }
}
