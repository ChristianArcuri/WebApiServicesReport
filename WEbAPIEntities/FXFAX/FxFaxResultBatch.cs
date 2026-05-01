using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEbAPIEntities.Common;


namespace WEbAPIEntities.FXFAX
{
    public class FxFaxResultBatch : TResult
    {
        public int BatchID { get; set; }
        public int FaxesSent { get; set; }
        public bool IsProcessing { get; set; }
        public string LastAgencyFaxProcessed { get; set; }

        public FxFaxResultBatch()
            : base()
         {
             BatchID = 0;
             FaxesSent = 0;
             IsProcessing = false;
             LastAgencyFaxProcessed = string.Empty;
            
         }
    }
}
