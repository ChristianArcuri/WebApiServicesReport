using System;
using WebAPIReports.Reports.Invoice;

namespace WebAPIReports.Reports.Checks
{
    public partial class RptChecksProcessedSm : DevExpress.XtraReports.UI.XtraReport
    {
        public RptChecksProcessedSm()
        {
            InitializeComponent();
        }

        private void ChecksProcessed_DataSourceDemanded(object sender, EventArgs e)
        {
            try
            {
                var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.ChecksConnectionString);
                (sender as RptChecksProcessedSm).ChecksConnectionString.ConnectionParameters = dataConnectionParametersBase;
            }
            catch
            {

            }
        }

       
    }
}
