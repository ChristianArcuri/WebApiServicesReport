using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using WebAPIReports.Reports.Invoice;
using log4net;

namespace WebAPIReports.Reports.MoneyOrder
{
    public partial class RptCompanyMOInvoice : DevExpress.XtraReports.UI.XtraReport
    {
        ILog log = LogManager.GetLogger(typeof(RptCompanyMOInvoice));
        public RptCompanyMOInvoice()
        {
            InitializeComponent();
        }

        private void RptMOInvoice_DataSourceDemanded(object sender, EventArgs e)
        {
            try 
            { 
                var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.MoneyOrderConnectionString);
                (sender as RptCompanyMOInvoice).MoneyOrders.ConnectionParameters = dataConnectionParametersBase;

                dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);
                (sender as RptCompanyMOInvoice).WireDataSource.ConnectionParameters = dataConnectionParametersBase;
            }
            catch (Exception ex)
            {
                log.ErrorFormat("RptCompanyMOInvoice ERROR: {0}", ex.Message);
            }
        }
    }
}
