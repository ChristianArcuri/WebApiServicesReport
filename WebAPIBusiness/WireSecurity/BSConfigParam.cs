using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIDataAccess.WireSecurity;

using System.Data;

namespace WebAPIBusiness.WireSecurity
{
    public class BSConfigParam
    {
        public string GetValueFromConfigParam(string ParamValue)
        {
            return new DAConfigParam().GetValueFromConfigParam(ParamValue);
        }

        public DataTable GetConnectionInformation(string dbName, int environmentId, int applicationId)
        {
            return new DAConfigParam().GetConnectionInformation(dbName, environmentId, applicationId);
        }
    }
}
