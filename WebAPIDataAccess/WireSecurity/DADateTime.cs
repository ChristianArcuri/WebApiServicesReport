using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIDataAccess.WireSecurity
{
    public class DADateTime:DABase
    {
        protected override string ConnectionString
        {
            get { return DAConnectionStrings.WireSecurityConnectionString; }
        }

        public DateTime GetDateTimeFromDb()
        {
            var command = GetTextCommand("SELECT GETDATE();");
            var result = ExecuteScalar(command);
            return result != null ? (DateTime)(result) : DateTime.Now; 
        }
    }
}
