using System;
using WebAPIReports.Reports.Invoice;

namespace WebAPIReports.Reports.Checks
{
    public partial class RptCompanyChecksProcessedSm : DevExpress.XtraReports.UI.XtraReport
    {
        public RptCompanyChecksProcessedSm()
        {
            InitializeComponent();
        }

        private void ChecksProcessed_DataSourceDemanded(object sender, EventArgs e)
        {
            try
            {
                var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.ChecksConnectionString);
                (sender as RptCompanyChecksProcessedSm).ChecksConnectionString.ConnectionParameters = dataConnectionParametersBase;
            }
            catch
            {

            }
        }

       
    }
}
