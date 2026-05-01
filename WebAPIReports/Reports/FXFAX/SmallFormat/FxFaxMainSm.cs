using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Globalization;
using WebAPIReports.Reports.Invoice;
using DevExpress.Xpf.Core.ConditionalFormatting;

namespace WebAPIReports.Reports.FXFAX
{
    public partial class FxFaxMainSm : DevExpress.XtraReports.UI.XtraReport
    {
        public FxFaxMainSm()
        {
            InitializeComponent();
        }

       
        private void xrLabel1_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            string header = (sender as XRLabel).Text;

            DateTime dt = DateTime.Now;

            IFormatProvider fp;

            if (Convert.ToInt32(this.Parameters["LanguageId"].Value) == 1)
            {
                fp = new CultureInfo("en-Us");
            }
            else
                fp = new CultureInfo("es-MX");

            (sender as XRLabel).Text = string.Format(header,
                                                       dt.ToString("dddd", fp),
                                                       dt.ToString("MMMM", fp),
                                                       dt.Day.ToString(),
                                                       dt.Year.ToString()
                                                       ).ToUpper();
        }

        private void FxFaxMainSm_DataSourceDemanded(object sender, EventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);
            (sender as FxFaxMainSm).WireTransac.ConnectionParameters = dataConnectionParametersBase;

        
        }

    }
}
