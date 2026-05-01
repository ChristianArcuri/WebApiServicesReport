using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using WebAPIReports.Reports.Invoice;
using log4net;

namespace WebAPIReports.Reports.Checks
{
    public partial class RptCompanyChecksBatchSummary : DevExpress.XtraReports.UI.XtraReport
    {

        int secondRow = 1;
        ILog log = LogManager.GetLogger(typeof(RptCompanyChecksBatch));
        public RptCompanyChecksBatchSummary()
        {
            InitializeComponent();
        }

        private void ChecksProcessed_DataSourceDemanded(object sender, EventArgs e)
        {
            try
            {
                var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.ChecksConnectionString);
                (sender as RptCompanyChecksBatchSummary).ChecksConnectionString.ConnectionParameters = dataConnectionParametersBase;
            }
            catch (Exception ex)
            {
                log.ErrorFormat("RptCompanyChecksBatchSummary ERROR: {0}", ex.Message);
            }
        }

        private void RptChecksBatchSummary_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var isVisible = GetCurrentRow() != null && GetCurrentColumnValue("CheckId") != null;
            EmptyLeyend.Visible = !isVisible;
            xrPanel1.Visible = isVisible;
            xrPanel2.Visible = isVisible;
            xrPanel3.Visible = isVisible;
        }
        private void GroupHeader2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ReportCommon.GridZebraStyle(sender, secondRow);
            secondRow++;
        }
    }
}
