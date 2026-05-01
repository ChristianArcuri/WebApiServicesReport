using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WebAPIDataAccess.WireSecurity
{
    public class DAMultiLanguage : DABase
    {
        protected override string ConnectionString
        {
            get { return DAConnectionStrings.WireSecurityConnectionString; }
        }

        public DataTable ReportMultiLanguage(string formName, int languageID)
        {
            var command = GetStoreProcedureCommand("ConvertRowsInColumns_MultiLangLabels");
            command.Parameters.Add(CreateParameter("@FormName", formName));
            command.Parameters.Add(CreateParameter("@LanguageId", languageID.ToString()));

            return ExecuteDataTable(command);
        }
    }
}
