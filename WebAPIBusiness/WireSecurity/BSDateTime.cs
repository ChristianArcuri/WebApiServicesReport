using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIDataAccess.WireSecurity;

namespace WebAPIBusiness.WireSecurity
{
    public class BSDateTime
    {
        public DateTime GetDateTimeFromDb()
        {
            return new DADateTime().GetDateTimeFromDb();
        }
    }
}
