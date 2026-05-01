using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

using System.Data.SqlClient;
using DevExpress.DataAccess.Sql;
using WebAPIReports.Reports.Invoice;

namespace WebAPIReports.Reports.Receipt
{
    public partial class Receipt : DevExpress.XtraReports.UI.XtraReport
    {
        private string connString { get; set; }
        public Receipt()
        {
            InitializeComponent();
          
        }

               
       
        private void Receipt_DataSourceDemanded(object sender, EventArgs e)
        {

            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireSearchConnectionString);
            (sender as Receipt).WireSearchReceipt.ConnectionParameters = dataConnectionParametersBase;
        }

     
    }
}
