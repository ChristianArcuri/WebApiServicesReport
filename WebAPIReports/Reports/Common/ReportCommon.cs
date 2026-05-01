using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;
using System.Drawing;

namespace WebAPIReports.Reports
{
    public static class ReportCommon
    {

        public const string WireTransacDB = "WireTransacConn";
        public const string ChecksConnectionString = "ChecksConnectionString";
        public const string MoneyOrderConnectionString = "MoneyOrderConnectionString";
        public const int LandscapeWidth = 1080;
        public const string DefaultParameters = "FormName, IsLandscape, OnlyFromVisible";
        public const string Font = "Tahoma";
        public const string TimesNewRoman = "Times New Roman";
        public const string Tahoma = "Tahoma";
        public const string INTERMEX_BRAND_NAME = "INTERMEX";
        public const string LAN_BRAND_NAME = "LA NACIONAL";

        internal static void SetAsLandscapeReport(ParameterCollection reportParameters, XRSubreport header, XRSubreport footer)
        {
            Parameter IsLandscape = new Parameter();        
            IsLandscape.Description = "IsLandscape";
            IsLandscape.Name = "IsLandscape";
            IsLandscape.Type = typeof(bool);
            IsLandscape.Visible = false;
            IsLandscape.Value = true;
            reportParameters.Add(IsLandscape);
            header.ParameterBindings.Add(new ParameterBinding("IsLandscape", IsLandscape));
            footer.ParameterBindings.Add(new ParameterBinding("IsLandscape", IsLandscape));     
        }
        
        const int maxRows = 999;

        public const string StringFormatDay = "dddd";
        public const string StringFormatMonth = "MMMM";
        public const string StringFormatMoney = "{0:$#,##0.00}";

        public const string CultureInfoEnUs = "en-US";
        public const string CultureInfoEsMX = "es-MX";
        const string color = "#E7E7E7";

        public static MsSqlConnectionParameters GetDataConnectionParameters(string conn)
        {
            var sqlConnection = new SqlConnection(conn);
            var sqlConnectionStringBuilder = new SqlConnectionStringBuilder(sqlConnection.ConnectionString);
            var dataConnectionParametersBase = new MsSqlConnectionParameters
            {
                ServerName = sqlConnectionStringBuilder.DataSource,
                DatabaseName = sqlConnectionStringBuilder.InitialCatalog,
                UserName = sqlConnectionStringBuilder.UserID,
                Password = sqlConnectionStringBuilder.Password,
                AuthorizationType = sqlConnectionStringBuilder.IntegratedSecurity ?
                        DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.Windows : DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.SqlServer
            };

            return dataConnectionParametersBase;

        }

        public static void SetSmallerLabelFontSize(XRLabel label, bool isBold =true)
        {
            decimal total = 0; 
            decimal.TryParse(label.Summary.GetResult() == null || string.IsNullOrEmpty(label.Summary.GetResult().ToString()) ? 0.ToString() : label.Summary.GetResult().ToString(), out total);
            if (total > maxRows)
            {
                if (isBold)
                {
                    label.Font = new System.Drawing.Font(label.Font.FontFamily, 7F, System.Drawing.FontStyle.Bold);
                }
                else
                {
                    label.Font = new System.Drawing.Font(label.Font.FontFamily, 7F);
                }
            }
        }

        public static System.Drawing.Font GetTitleFont()
        {
            return new System.Drawing.Font(Font, 12F, System.Drawing.FontStyle.Bold);
        }
        public static void GridZebraStyle(object sender, int row)
        {
            Color alternateColor = ColorTranslator.FromHtml(color);
            if (row % 2 == 0)
                (sender as DevExpress.XtraReports.UI.GroupBand).BackColor = alternateColor;
            else
                (sender as DevExpress.XtraReports.UI.GroupBand).BackColor = Color.White;
        }
    }
}
