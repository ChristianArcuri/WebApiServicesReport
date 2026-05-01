using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

using System.Globalization;

namespace WebAPIReports.Reports.Invoice.SmallFormat
{
    public partial class RptInvoiceTopUpSm : DevExpress.XtraReports.UI.XtraReport
    {
        public RptInvoiceTopUpSm()
        {
            InitializeComponent();
          }
 
        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            decimal amountValue = Convert.ToDecimal(GetCurrentColumnValue("ActivityBalance"));

          
            if (amountValue != 0) 
            {
                (MasterReport as CompanyRptInvoiceSm).qtyTopUp++;
                (MasterReport as CompanyRptInvoiceSm).amountTopUp += amountValue;
            }
        }
        

        private void RptInvoiceTopUp_DataSourceDemanded(object sender, EventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);
            (sender as RptInvoiceTopUpSm).WireTransac.ConnectionParameters = dataConnectionParametersBase;
        }


    }
}
