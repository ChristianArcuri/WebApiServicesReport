using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace WebAPIDataAccess.WireSecurity
{
    public class DAConfigParam : DABase
    {
        protected override string ConnectionString
        {
            get { return DAConnectionStrings.WireSecurityConnectionString; }
        }

        public string GetValueFromConfigParam(string ParamValue)
        {
            var command = GetStoreProcedureCommand("Sec_AppSecurityParameters_Read");
            command.Parameters.Add(CreateParameter("@SecurityParameterNameId", ParamValue));
            var result = ExecuteDataTable(command);
            var paramValue = result.Rows.Count > 0 ? result.Rows[0]["SecurityParameterValue"].ToString() : string.Empty;
            return paramValue;
        }

        public  DataTable GetConnectionInformation(string dbName, int environmentId, int applicationId)
        {
            var command = GetStoreProcedureCommand("Sec_AppSecurity_GetConnection",DAConnectionStrings.DefaultConnectionString);
            command.Parameters.Add(CreateParameter("@DatabaseAliasName", dbName));
            command.Parameters.Add(CreateParameter("@EnvironmentId", environmentId));
            command.Parameters.Add(CreateParameter("@ApplicationId", applicationId));

            return ExecuteDataTable(command);
  
        }
    }
}
