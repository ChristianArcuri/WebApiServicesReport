using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEbAPIEntities.SSRS
{
    public class ReportParameters
    {
        public string ReportFolder { get; set; }
        public string ReportName { get; set; }
        public string AgencyCode { get; set; }
        public string ListCountries { get; set; }
        
        //Fax Parameters
        public bool Fax { get; set; }
        public string UserName { get; set; }
        public string ComputerName { get; set; }
    }
}
