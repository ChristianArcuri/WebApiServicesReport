using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEbAPIEntities.FXFAX
{
    public class FxFaxBatchParameters
    {
        public string UserName;
        public string ComputerName;
        public IList<FxFax> Reports;
    }

    public class FxFax
    {
        public string AgencyCode;
        public int LanguageId;
   
    }
}
