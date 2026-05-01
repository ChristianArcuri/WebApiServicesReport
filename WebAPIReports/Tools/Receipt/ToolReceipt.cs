using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEbAPIEntities.Common;


namespace WebAPIReports.Tools.Receipt
{
    public class ToolReceipt:Tools
    {
         #region public
        public ToolReceipt()
         {
         }
        public TResultStream ReceiptToStreamPDF(TParameters param)
        {
            WebAPIReports.Reports.Receipt.Receipt report = new WebAPIReports.Reports.Receipt.Receipt();
            return ReportToStream(report, param, "PDF");
        }
        #endregion
    }
}
