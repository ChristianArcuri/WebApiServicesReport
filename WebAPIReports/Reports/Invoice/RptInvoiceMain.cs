using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace WebAPIReports.Reports.Invoice
{
    public partial class RptInvoiceMain : DevExpress.XtraReports.UI.XtraReport
    {
        public ArrayList groups = new ArrayList();
        int startPageIndex = 0;
        ArrayList st = new ArrayList();
        int grp = 0;
        public RptInvoiceMain()
        {
            InitializeComponent();
        }

        private void xrLabel1_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            startPageIndex = e.PageIndex;
           
        }

        private void xrLabel2_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            groups.Add(new Groups(startPageIndex, e.PageIndex, Convert.ToInt32(st[grp])));
            grp++;
           
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            st.Add(Convert.ToInt32(GetCurrentColumnValue("StatementId")));
        }

        private void xrSubreport2_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            (sender as XRSubreport).ReportSource = new WebAPIReports.Reports.Invoice.RptCompanyInvoice();
            //(sender as XRSubreport).ReportSource = new WebAPIReports.Reports.Invoice.RptInvoice();
        }

        private void WireTransac_ConfigureDataConnection(object sender, DevExpress.DataAccess.Sql.ConfigureDataConnectionEventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);

            if (e.ConnectionName == "WireTransac_Connection")
                e.ConnectionParameters = dataConnectionParametersBase;
        }

        private void RptInvoiceMain_DataSourceDemanded(object sender, EventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);
            (sender as RptInvoiceMain).WireTransac.ConnectionParameters = dataConnectionParametersBase;
        }


    }

    public class Groups
    {
        public Groups(int startPageIndex, int endPageIndex, int statementId)
        {
            this.startPageIndex = startPageIndex;
            this.endPageIndex = endPageIndex;
            this.statementId = statementId;
        }

        private int startPageIndex;
        private int endPageIndex;
        private int statementId;

        public int StartPageIndex
        {
            get { return startPageIndex; }
            set { startPageIndex = value; }
        }

        public int EndPageIndex
        {
            get { return endPageIndex; }
            set { endPageIndex = value; }
        }

        public int StatementId
        {
            get { return statementId; }
            set { statementId = value; }
        }
    }
}
