using DevExpress.XtraReports.UI;
using System;
using System.Linq;
using WebAPIReports.Reports.Invoice;

namespace WebAPIReports.Reports.AgencyOverview
{
    public partial class EndOfDayCompanyReportSummary : DevExpress.XtraReports.UI.XtraReport
    {
        public int TotalSummary { get; set; }
        public EndOfDayCompanyReportSummary()
        {
            InitializeComponent();
        }

        private void EndOfDayReport_DataSourceDemanded(object sender, EventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);
            (sender as EndOfDayCompanyReportSummary).sqlDataSource1.ConnectionParameters = dataConnectionParametersBase;

        }

        private void sqlDataSource1_ConfigureDataConnection(object sender, DevExpress.DataAccess.Sql.ConfigureDataConnectionEventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);

            if (e.ConnectionName == ReportCommon.WireTransacDB)
                e.ConnectionParameters = dataConnectionParametersBase;
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var row = (this as XtraReportBase).RowCount;
            rowsVisible(row);
        }

        private void GroupHeader2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var sum = ((((this as EndOfDayCompanyReportSummary).DataSource) as DevExpress.DataAccess.Sql.SqlDataSource).Result as DevExpress.DataAccess.Native.Sql.ResultSet).Tables.First();
            var sumDebit = (sum[0] as DevExpress.DataAccess.Native.Sql.ResultRow).ElementAt(3);            
            Double nWiresDebit = Convert.ToDouble(sumDebit);     

            panelVisible(nWiresDebit);

            int sumTotal = Convert.ToInt32((sum[0] as DevExpress.DataAccess.Native.Sql.ResultRow).ElementAt(0)) + Convert.ToInt32((sum[0] as DevExpress.DataAccess.Native.Sql.ResultRow).ElementAt(1))
                           + Convert.ToInt32((sum[0] as DevExpress.DataAccess.Native.Sql.ResultRow).ElementAt(2)) + Convert.ToInt32((sum[0] as DevExpress.DataAccess.Native.Sql.ResultRow).ElementAt(3))
                           + Convert.ToInt32((sum[0] as DevExpress.DataAccess.Native.Sql.ResultRow).ElementAt(4));
            TotalSummary = sumTotal;

            var row = (this as XtraReportBase).RowCount;            

            if (sumTotal == 0 && row == 1)
            {
                rowsVisible(sumTotal);
            }
            
        }

        private void xrPanel2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var sum = ((((this as EndOfDayCompanyReportSummary).DataSource) as DevExpress.DataAccess.Sql.SqlDataSource).Result as DevExpress.DataAccess.Native.Sql.ResultSet).Tables.First();
            var sumDebit = (sum[0] as DevExpress.DataAccess.Native.Sql.ResultRow).ElementAt(3);

            Double nWiresDebit = Convert.ToDouble(sumDebit);

            panelVisible(nWiresDebit);
        }

        private void xrPanel12_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var sum = ((((this as EndOfDayCompanyReportSummary).DataSource) as DevExpress.DataAccess.Sql.SqlDataSource).Result as DevExpress.DataAccess.Native.Sql.ResultSet).Tables.First();
            var sumDebit = (sum[0] as DevExpress.DataAccess.Native.Sql.ResultRow).ElementAt(3);

            Double nWiresDebit = Convert.ToDouble(sumDebit);

            panelVisible(nWiresDebit);
        }

        private void xrPanel18_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var sum = ((((this as EndOfDayCompanyReportSummary).DataSource) as DevExpress.DataAccess.Sql.SqlDataSource).Result as DevExpress.DataAccess.Native.Sql.ResultSet).Tables.First();
            var sumDebit = (sum[0] as DevExpress.DataAccess.Native.Sql.ResultRow).ElementAt(3);

            Double nWiresDebit = Convert.ToDouble(sumDebit);

            panelVisible(nWiresDebit);
        }

        private void xrPanel1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var sum = ((((this as EndOfDayCompanyReportSummary).DataSource) as DevExpress.DataAccess.Sql.SqlDataSource).Result as DevExpress.DataAccess.Native.Sql.ResultSet).Tables.First();
            var sumDebit = (sum[0] as DevExpress.DataAccess.Native.Sql.ResultRow).ElementAt(3);

            Double nWiresDebit = Convert.ToDouble(sumDebit);

            panelVisible(nWiresDebit);
        }

        private void xrPanel3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var sum = ((((this as EndOfDayCompanyReportSummary).DataSource) as DevExpress.DataAccess.Sql.SqlDataSource).Result as DevExpress.DataAccess.Native.Sql.ResultSet).Tables.First();
            var sumDebit = (sum[0] as DevExpress.DataAccess.Native.Sql.ResultRow).ElementAt(3);

            Double nWiresDebit = Convert.ToDouble(sumDebit);

            panelVisible(nWiresDebit);
        }

        private void rowsVisible(int row)
        {
            if (row == 0)
            {                
                //GroupHeader2.Visible = false;
                Detail.Visible = false;
            }
            else
            {
                ///GroupHeader2.Visible = true;
                Detail.Visible = true; 
            }
        }

        private void panelVisible(double nWiresDebit)
        {
            if (nWiresDebit > 0)
            {
                xrPanel2.Visible = true;
                xrPanel12.Visible = true;
                xrPanel10.Visible = true;
                xrPanel18.Visible = true;
                xrPanel1.Visible = false;
                xrPanel3.Visible = false;
            }
            else
            {
                xrPanel1.Visible = true;
                xrPanel3.Visible = true;
                xrPanel2.Visible = false;
                xrPanel12.Visible = false;
                xrPanel10.Visible = false;
                xrPanel18.Visible = false;                
            }
        }

    }
}
