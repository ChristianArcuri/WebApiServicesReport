using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Globalization;
using WebAPIReports.Reports.Invoice;

namespace WebAPIReports.Reports.FXFAX
{
    public partial class FxTest : DevExpress.XtraReports.UI.XtraReport
    {
        public FxTest()
        {
            InitializeComponent();
        }

       
        private void xrLabel1_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            //string header = (sender as XRLabel).Text;// Convert.ToString(GetCurrentColumnValue("AgFaxHeader"));

            //DateTime dt = DateTime.Now;

            //IFormatProvider fp;

            //if (Convert.ToInt32(this.Parameters["LanguageId"].Value) == 1)
            //{
            //    fp = new CultureInfo("en-Us");
            //}
            //else
            //    fp = new CultureInfo("es-MX");

            //(sender as XRLabel).Text = string.Format(header,
            //                                           dt.ToString("dddd", fp),
            //                                           dt.ToString("MMMM", fp),
            //                                           dt.Day.ToString(),
            //                                           dt.Year.ToString()
            //                                           ).ToUpper();
        }

        private void FxFaxMain_DataSourceDemanded(object sender, EventArgs e)
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);
            (sender as FxTest).WireTransac.ConnectionParameters = dataConnectionParametersBase;

        
        }

    }
}
