using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEbAPIEntities.Common
{
    public class ErrorResult
    {
        public const int InvalidReportName      = 101,
                         InvalidReportParameter = 102,
                         InvalidFilePath        = 103,
                         MissingReportParameter = 104,
                         UnexpectedError        = 105;

        public static string GetMessageDesc(int error)
        {
            switch (error)
            {
                case 101: 
                    return "Invalid Report Name";
                case 102: 
                    return "Invalid Report Parameter";
                case 103: 
                    return "Invalid File Path";
                case 104:
                    return "Missing Report Parameter";
                default: 
                    return "Error";
            }
        }
    }
}
