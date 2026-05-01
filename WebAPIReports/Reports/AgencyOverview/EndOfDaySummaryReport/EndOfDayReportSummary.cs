using DevExpress.XtraReports.UI;
using System;
using System.Data;
using System.Drawing;

namespace WebAPIReports.Reports.AgencyOverview
{
    public partial class EndOfDayReportSummary : DevExpress.XtraReports.UI.XtraReport
    {
        public EndOfDayReportSummary()
        {
            InitializeComponent();

            this.xrLabel3.DataBindings.AddRange(new XRBinding[] {
            new XRBinding(this.Color, "HexaForeColor", string.Empty)});
        }

        private void EndOfDayReportWires_DataSourceDemanded(object sender, EventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);
            (sender as EndOfDayReportSummary).sqlDataSource1.ConnectionParameters = dataConnectionParametersBase;
     
        }

        private void DataSourceWires_ConfigureDataConnection(object sender, DevExpress.DataAccess.Sql.ConfigureDataConnectionEventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);

            if (e.ConnectionName == ReportCommon.WireTransacDB)            
            e.ConnectionParameters = dataConnectionParametersBase;
        } 
        

        private void EndOfDayReportSummary_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {           
                this.GroupHeader1.Visible = true;                
                this.Detail.Visible = true;
        }
    }
}
