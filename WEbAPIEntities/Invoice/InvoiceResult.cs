using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEbAPIEntities.Common;

namespace WEbAPIEntities.Invoice
{
    public class InvoiceResult
    {
        public int ErrorCode {get;set;}

        public string ErrorMessage {get;set;}

        public InvoiceResult()
        {
            ErrorCode = 0;
            ErrorMessage = string.Empty;
        }
        public InvoiceResult(int error)
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
