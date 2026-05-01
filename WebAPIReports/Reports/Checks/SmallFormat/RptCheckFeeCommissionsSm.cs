using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using WebAPIReports.Reports.Invoice;

namespace WebAPIReports.Reports.Checks
{
    public partial class RptCheckFeeCommissionsSm : DevExpress.XtraReports.UI.XtraReport
    {
        public RptCheckFeeCommissionsSm()
        {
            InitializeComponent();
        }

        private void RptCheckFeeCommissions_DataSourceDemanded(object sender, EventArgs e)
        {
            try
            {
                var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.ChecksConnectionString);
                (sender as RptCheckFeeCommissionsSm).Checks.ConnectionParameters = dataConnectionParametersBase;
            }
            catch
            {

            }
        }

    }
}
