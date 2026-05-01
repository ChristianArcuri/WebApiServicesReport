using DevExpress.XtraReports.UI;
using System;
using System.Data;
using System.Drawing;

namespace WebAPIReports.Reports.AgencyOverview
{
    public partial class CombinedReportSummary : DevExpress.XtraReports.UI.XtraReport
    {
        public CombinedReportSummary()
        {
            InitializeComponent();

            this.xrLabel3.DataBindings.AddRange(new XRBinding[] {
            new XRBinding(this.Color, "HexaForeColor", string.Empty)});
        }

        private void CombinedReportWires_DataSourceDemanded(object sender, EventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);
            (sender as CombinedReportSummary).DataSourceWires.ConnectionParameters = dataConnectionParametersBase;
     
        }

        private void DataSourceWires_ConfigureDataConnection(object sender, DevExpress.DataAccess.Sql.ConfigureDataConnectionEventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);

            if (e.ConnectionName == ReportCommon.WireTransacDB)            
            e.ConnectionParameters = dataConnectionParametersBase;
        }       

        private void GroupFooter1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ReportCommon.SetSmallerLabelFontSize(xrLabel8, false);
            ReportCommon.SetSmallerLabelFontSize(xrLabel14, false);
            ReportCommon.SetSmallerLabelFontSize(xrLabel9, false);
            ReportCommon.SetSmallerLabelFontSize(xrLabel2, false);
            ReportCommon.SetSmallerLabelFontSize(xrLabel10, false);
        }        

        private void xrLabel6_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            var wires = ((CombinedReportSummaryWires)xrSubreportSummaryWires.ReportSource).TotalWires;
            var moneyOrders = ((CombinedReportSummaryMO)xrSubreportSummaryMO.ReportSource).TotalMO;
            var billPayment = ((CombinedReportSummaryBillPayment)xrSubreportSummaryBillPayment.ReportSource).TotalBP;
            var checks = ((CombinedReportSummaryChecks)xrSubreportSummaryChecks.ReportSource).TotalChecks;
            var labelTotal = (sender as XRLabel);
            Int32 nWires = Int32.TryParse(wires, out nWires) ? nWires : 0;
            Int32 nMOneyOrders = Int32.TryParse(moneyOrders, out nMOneyOrders) ? nMOneyOrders : 0;
            Int32 nChecks = Int32.TryParse(checks, out nChecks) ? nChecks : 0;
            Int32 nBillPayments = Int32.TryParse(billPayment, out nBillPayments) ? nBillPayments : 0;

            labelTotal.Text = (nWires + nMOneyOrders + nChecks + nBillPayments).ToString();
        }

        private void xrLabel14_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            var wires = ((CombinedReportSummaryWires)xrSubreportSummaryWires.ReportSource).TotalFee;
            var moneyOrders = ((CombinedReportSummaryMO)xrSubreportSummaryMO.ReportSource).TotalFee;
            var checks = ((CombinedReportSummaryChecks)xrSubreportSummaryChecks.ReportSource).TotalFee;
            var billPayments = ((CombinedReportSummaryBillPayment)xrSubreportSummaryBillPayment.ReportSource).TotalFee;

            var labelAmount = (sender as XRLabel);
            Decimal nWires = Decimal.TryParse(wires, out nWires) ? nWires : 0;
            Decimal nMOneyOrders = Decimal.TryParse(moneyOrders, out nMOneyOrders) ? nMOneyOrders : 0;
            Decimal nChecks = Decimal.TryParse(checks, out nChecks) ? nChecks : 0;
            Decimal nBillPayments = Decimal.TryParse(billPayments, out nBillPayments) ? nBillPayments : 0;

            labelAmount.Text = String.Format("{0:$#,##0.00}", nWires + nMOneyOrders + nChecks + nBillPayments);
        }

        private void xrLabel8_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            var wires = ((CombinedReportSummaryWires)xrSubreportSummaryWires.ReportSource).TotalAmount;
            var moneyOrders = ((CombinedReportSummaryMO)xrSubreportSummaryMO.ReportSource).TotalAmount;
            var checks = ((CombinedReportSummaryChecks)xrSubreportSummaryChecks.ReportSource).TotalAmount;
            var billPayments = ((CombinedReportSummaryBillPayment)xrSubreportSummaryBillPayment.ReportSource).TotalAmount;

            var labelAmount = (sender as XRLabel);
            Decimal nWires = Decimal.TryParse(wires, out nWires) ? nWires : 0;
            Decimal nMOneyOrders = Decimal.TryParse(moneyOrders, out nMOneyOrders) ? nMOneyOrders : 0;
            Decimal nChecks = Decimal.TryParse(checks, out nChecks) ? nChecks : 0;
            Decimal nBillPayments = Decimal.TryParse(billPayments, out nBillPayments) ? nBillPayments : 0;

            labelAmount.Text = String.Format("{0:$#,##0.00}", nWires + nMOneyOrders + nChecks + nBillPayments);
        }

        private void xrLabel9_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            var wires = ((CombinedReportSummaryWires)xrSubreportSummaryWires.ReportSource).TotalDeposit;
            var moneyOrders = ((CombinedReportSummaryMO)xrSubreportSummaryMO.ReportSource).TotalDeposit;
            var checks = ((CombinedReportSummaryChecks)xrSubreportSummaryChecks.ReportSource).TotalDeposit;
            var billPayments = ((CombinedReportSummaryBillPayment)xrSubreportSummaryBillPayment.ReportSource).TotalDeposit;

            var labelAmount = (sender as XRLabel);
            Decimal nWires = Decimal.TryParse(wires, out nWires) ? nWires : 0;
            Decimal nMOneyOrders = Decimal.TryParse(moneyOrders, out nMOneyOrders) ? nMOneyOrders : 0;
            Decimal nChecks = Decimal.TryParse(checks, out nChecks) ? nChecks : 0;
            Decimal nBillPayments = Decimal.TryParse(billPayments, out nBillPayments) ? nBillPayments : 0;

            labelAmount.Text = String.Format("{0:$#,##0.00}", nWires + nMOneyOrders + nChecks + nBillPayments);
        }

        private void xrLabel10_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            var wires = ((CombinedReportSummaryWires)xrSubreportSummaryWires.ReportSource).TotalComm;
            var moneyOrders = ((CombinedReportSummaryMO)xrSubreportSummaryMO.ReportSource).TotalComm;
            var checks = ((CombinedReportSummaryChecks)xrSubreportSummaryChecks.ReportSource).TotalComm;
            var billPayments = ((CombinedReportSummaryBillPayment)xrSubreportSummaryBillPayment.ReportSource).TotalComm;

            var labelAmount = (sender as XRLabel);
            Decimal nWires = Decimal.TryParse(wires, out nWires) ? nWires : 0;
            Decimal nMOneyOrders = Decimal.TryParse(moneyOrders, out nMOneyOrders) ? nMOneyOrders : 0;
            Decimal nChecks = Decimal.TryParse(checks, out nChecks) ? nChecks : 0;
            Decimal nBillPayments = Decimal.TryParse(billPayments, out nBillPayments) ? nBillPayments : 0;

            labelAmount.Text = String.Format("{0:$#,##0.00}", nWires + nMOneyOrders + nChecks + nBillPayments);

            bool visible;
            bool.TryParse(Parameters["AllowViewCommissions"].Value.ToString(), out visible);
            labelAmount.Visible = visible;
        }

        private void xrLabel2_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            var wires = ((CombinedReportSummaryWires)xrSubreportSummaryWires.ReportSource).TotalVoid;
            var moneyOrders = ((CombinedReportSummaryMO)xrSubreportSummaryMO.ReportSource).TotalVoid;
            var checks = ((CombinedReportSummaryChecks)xrSubreportSummaryChecks.ReportSource).TotalVoid;
            var billPayments = ((CombinedReportSummaryBillPayment)xrSubreportSummaryBillPayment.ReportSource).TotalVoid;

            var labelAmount = (sender as XRLabel);
            Decimal nWires = Decimal.TryParse(wires, out nWires) ? nWires : 0;
            Decimal nMOneyOrders = Decimal.TryParse(moneyOrders, out nMOneyOrders) ? nMOneyOrders : 0;
            Decimal nChecks = Decimal.TryParse(checks, out nChecks) ? nChecks : 0;
            Decimal nBillPayments = Decimal.TryParse(billPayments, out nBillPayments) ? nBillPayments : 0;

            labelAmount.Text = (nWires + nMOneyOrders + nChecks + nBillPayments).ToString();
        }

        private void CombinedReportSummary_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (Boolean.Parse(Parameters["HasData"].Value.ToString()) == true)
            {
                this.GroupHeader1.Visible = true;
                this.PageHeader.Visible = true;
                this.Detail.Visible = true;
                this.PageFooter.Visible = true;
            } else
            {
                this.GroupHeader1.Visible = false;
                this.PageHeader.Visible = false;
                this.Detail.Visible = false;
                this.PageFooter.Visible = false;
            }
        }
    }
}
