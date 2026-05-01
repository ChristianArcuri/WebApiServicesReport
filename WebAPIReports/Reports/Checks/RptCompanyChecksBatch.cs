using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using WebAPIReports.Reports.Invoice;
using log4net;

namespace WebAPIReports.Reports.Checks
{
    public partial class RptCompanyChecksBatch : DevExpress.XtraReports.UI.XtraReport
    {
        ILog log = LogManager.GetLogger(typeof(RptCompanyChecksBatch));
        public RptCompanyChecksBatch()
        {
            InitializeComponent();
        }

        private void ChecksProcessed_DataSourceDemanded(object sender, EventArgs e)
        {
            try
            {
                var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.ChecksConnectionString);
                (sender as RptCompanyChecksBatch).ChecksConnectionString.ConnectionParameters = dataConnectionParametersBase;
            }
            catch (Exception ex)
            {
                log.ErrorFormat("RptCompanyChecksBatch ERROR: {0}", ex.Message);
            }
        }

        private void RptChecksBatch_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var isVisible = GetCurrentRow() != null && GetCurrentColumnValue("CheckId") != null;
            EmptyLeyend.Visible = !isVisible;
            xrPanel1.Visible = isVisible;
            xrPanel2.Visible = isVisible;
            xrPanel3.Visible = isVisible;
        }
    }
}
