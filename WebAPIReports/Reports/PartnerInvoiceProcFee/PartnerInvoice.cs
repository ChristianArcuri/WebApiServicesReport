using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;
using DevExpress.DataAccess.Sql;
using WebAPIReports.Reports.Invoice;

namespace WebAPIReports.Reports.PartnerInvoiceProcFee
{
    public partial class PartnerInvoice : DevExpress.XtraReports.UI.XtraReport
    {
        private string connStringWireSecurity { get; set; }
        private string connStringWireTransac { get; set; }
        public PartnerInvoice()
        {
            InitializeComponent();
        }

     
      
        private void PartnerInvoice_DataSourceDemanded(object sender, EventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);
            (sender as PartnerInvoice).WireTransac.ConnectionParameters = dataConnectionParametersBase;

        }


     
    
    }
}
