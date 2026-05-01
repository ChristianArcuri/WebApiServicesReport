using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEbAPIEntities.Common;

namespace WEbAPIEntities.SSRS
{
    public class SSRSResponseStream
    {
        public byte[] StreamInfo { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public string FaxFilePath { get; set; }

        public SSRSResponseStream()
        {
            StreamInfo = null;
            ErrorCode = 0;
            ErrorMessage = string.Empty;
            FaxFilePath = string.Empty;
        }

        public void SetMessages(int errorCode, string aditionlMsg)
        {
            ErrorCode = errorCode;
            aditionlMsg += !string.IsNullOrWhiteSpace(aditionlMsg) ? ". " : string.Empty;

            ErrorMessage = string.Format("{0}{1}", aditionlMsg, ErrorResult.GetMessageDesc(errorCode));
        }
    }
}
