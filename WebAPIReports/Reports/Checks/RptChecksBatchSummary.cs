using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using WebAPIReports.Reports.Invoice;

namespace WebAPIReports.Reports.Checks
{
    public partial class RptChecksBatchSummary : DevExpress.XtraReports.UI.XtraReport
    {
        public RptChecksBatchSummary()
        {
            InitializeComponent();
        }

        private void ChecksProcessed_DataSourceDemanded(object sender, EventArgs e)
        {
            try
            {
                var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.ChecksConnectionString);
                (sender as RptChecksBatchSummary).ChecksConnectionString.ConnectionParameters = dataConnectionParametersBase;
            }
            catch
            {

            }
        }

        private void RptChecksBatchSummary_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var currRow = GetCurrentRow();
            var ChkId = (int)GetCurrentColumnValue("CheckId");
            var visible = currRow != null && ChkId != 0 ? true : false;
            EmptyLeyend.Visible = !visible;
            xrPanel1.Visible = visible;
            xrPanel2.Visible = visible;
            xrPanel3.Visible = visible;
        }
        int row = 1;
        private void GroupHeader2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            Color gray = ColorTranslator.FromHtml("#E7E7E7");
            if (row % 2 == 0)
                ((DevExpress.XtraReports.UI.GroupBand)(sender)).BackColor = gray;
            else
                ((DevExpress.XtraReports.UI.GroupBand)(sender)).BackColor = Color.White;
            row++;   
        }
    }
}
