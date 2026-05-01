using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using WebAPIReports.Reports.Invoice;
using log4net;

namespace WebAPIReports.Reports.MoneyOrder
{
    public partial class RptMOInvoiceDetail : DevExpress.XtraReports.UI.XtraReport
    {
        private decimal currentBalance = 0;
        ILog log = LogManager.GetLogger(typeof(RptMOInvoiceDetail));

        public RptMOInvoiceDetail()
        {
            InitializeComponent();           
        }

        private void xrLabel5_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (currentBalance == 0)
                currentBalance = Convert.ToDecimal(this.Parameters["BeginingBalance"].Value);

            currentBalance += Convert.ToDecimal(GetCurrentColumnValue("Debits")) - Convert.ToDecimal(GetCurrentColumnValue("Credits"));
            (sender as XRLabel).Text = string.Format(ReportCommon.StringFormatMoney, currentBalance);
        }

        private void xrLabel8_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            (sender as XRLabel).Text = string.Format(ReportCommon.StringFormatMoney, currentBalance);
        }

        private void RptMOInvoiceDetail_DataSourceDemanded(object sender, EventArgs e)
        {

            try
            {
                var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.MoneyOrderConnectionString);
                (sender as RptMOInvoiceDetail).MoneyOrders.ConnectionParameters = dataConnectionParametersBase;
            }
            catch (Exception ex)
            {
                log.ErrorFormat("RptMOInvoiceDetail ERROR: {0}", ex.Message);
            }
        }

        private string GetLabelSmallFormat(object descriptionColumn)
        {
            string label = "";

            if (descriptionColumn == null)
                return label;

            var moNumber = GetCurrentColumnValue("MoExtNumber")?.ToString();

            if (descriptionColumn.ToString() == "23") // Agency Commission
            {
                label = $"{moNumber.Substring(moNumber.Length - 4)} Ag Com";
            }
            else if (descriptionColumn.ToString() == "7") // MO Void Return
            {
                label = $"{moNumber.Substring(moNumber.Length - 4)} Void";
            }
            else if (descriptionColumn.ToString() == "22") // Service Fee
            {
                label = $"{moNumber.Substring(moNumber.Length - 4)} Ser Fee";
            }
            else if (descriptionColumn.ToString() == "16") // MO Delete Return
            {
                label = $"{moNumber.Substring(moNumber.Length - 4)} Del Ret";
            }
            else if (descriptionColumn.ToString() == "19") // Money Order Deleted
            {
                label = $"{moNumber.Substring(moNumber.Length - 4)} Del";
            }
            else
            {
                label = GetCurrentColumnValue("Description").ToString();
            }

            return label;
        }

        private void xrLabel1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var descriptionColumn = GetCurrentColumnValue("AccTranTypeId");
            xrLabel1.Text = GetLabelSmallFormat(descriptionColumn);
        }

        private void RptMOInvoiceDetail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var isVisible = GetCurrentRow() != null;
            EmptyLeyend.Visible = !isVisible;
            xrPanel1.Visible = isVisible;
            xrPanel2.Visible = isVisible;
            xrPanel3.Visible = isVisible;
        }
    }
}
