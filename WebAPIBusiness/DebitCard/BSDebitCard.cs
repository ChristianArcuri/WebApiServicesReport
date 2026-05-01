using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEbAPIEntities.Common;
using WebAPIReports.Tools.Checks;
using WebAPIReports.Tools.DebitCard;

namespace WebAPIBusiness.DebitCard
{
    public class BSDebitCard
    {
        #region properties
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(BSDebitCard));
        #endregion

        public BSDebitCard()
        {
        }


        public TResultStream EndOfTheDaysReportToStream(TParameters param, string format)
        {
            TResultStream rs = new TResultStream();
            try
            {
                rs = new ToolDebitCard().EndOfTheDayReportToStream(param, format);

            }
            catch (Exception ex)
            {
                log.ErrorFormat("CheckProcessedToStream ERROR: {0}", ex.Message);
                rs.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return rs;
        }

    }
}
