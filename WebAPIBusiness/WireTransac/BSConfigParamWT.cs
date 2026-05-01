using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIDataAccess.WireTransac;

namespace WebAPIBusiness.WireTransac
{
    public class BSConfigParamWT
    {
        public string GetValueFromConfigParam(string ParamValue)
        {
            return new DAConfigParamWT().GetValueFromConfigParam(ParamValue);
        }
    }
}
