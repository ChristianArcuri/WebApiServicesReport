using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEbAPIEntities.Common
{
    public class TResult
    {
        public int ErrorCode {get;set;}

        public string ErrorMessage {get;set;}

        public TResult()
        {
            ErrorCode = 0;
            ErrorMessage = string.Empty;
        }
        public TResult(int error)
        { 
            ErrorCode = 0;
            ErrorMessage = string.Empty;

            if (error > 0)
            {
                ErrorCode = error;
                ErrorMessage = ErrorResult.GetMessageDesc(error);
            }
        }

        public void SetMessages(int errorCode, string aditionlMsg)
        {
            ErrorCode = errorCode;
            aditionlMsg += !string.IsNullOrWhiteSpace(aditionlMsg)? ". ": string.Empty;

            ErrorMessage = string.Format("{0}{1}", aditionlMsg, ErrorResult.GetMessageDesc(errorCode));
        }
    }
}
