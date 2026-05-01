using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using WebAPIReports.Reports.Invoice;

namespace WebAPIReports.Reports.Checks
{
    public partial class EndOfTheDayReportDebitCard : DevExpress.XtraReports.UI.XtraReport
    {
        public EndOfTheDayReportDebitCard()
        {
            InitializeComponent();
        }

        private void EndOfTheDayReportDebitCard_DataSourceDemanded(object sender, EventArgs e)
        {
            try
            {
                var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.DebitCardConnectionString);
                (sender as EndOfTheDayReportDebitCard).DebitCardConnectionString.ConnectionParameters = dataConnectionParametersBase;
            }
            catch
            {

            }
        }

        private void topMarginBand1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void DebitCardConnectionString_ConfigureDataConnection(object sender, DevExpress.DataAccess.Sql.ConfigureDataConnectionEventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.DebitCardConnectionString);
             
            if (e.ConnectionName == "DebitCardConnectionString")
                e.ConnectionParameters = dataConnectionParametersBase;
        }

        private void EndOfTheDayReportDebitCard_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var currRow = GetCurrentRow(); 
            var visible = currRow != null ? true : false;
            EmptyLeyend.Visible = !visible;
            xrTable1.Visible = visible;
            xrLabel9.Visible = visible;
            xrLabel23.Visible = visible;
            xrLabel18.Visible = visible;
            xrLabel20.Visible = visible;
            xrLabel21.Visible = visible;
            xrLabel16.Visible = visible;
            xrLabel22.Visible = visible;
            xrLabel17.Visible = visible;
            xrLabel19.Visible = visible;
            GroupFooter1.Visible = visible; 
        }
    }
}
