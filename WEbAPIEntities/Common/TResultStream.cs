using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEbAPIEntities.Common
{
    public class TResultStream: TResult
    {
        public byte[] StreamInfo { get; set; }
        public TResultStream()
            : base()
         {
             StreamInfo = null;
         }
    }
}
