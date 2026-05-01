using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIDataAccess.WireTransac
{
    public class DAConfigParamWT: DABase
    {
        protected override string ConnectionString
        {
            get { return DAConnectionStrings.WireTransacConnectionString; }
        }

        public string GetValueFromConfigParam(string ParamValue)
        {
            var command = GetStoreProcedureCommand("GetConfigParamValues");
            command.Parameters.Add(CreateParameter("@ParamName", ParamValue));
            var result = ExecuteDataTable(command);
            var paramValue = result.Rows.Count > 0 ? result.Rows[0]["ParamValue"].ToString() : string.Empty;
            return paramValue;
        }
    }
}
