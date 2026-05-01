using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WEbAPIEntities.Common;
using WEbAPIEntities.SSRS;
using Microsoft.Reporting.WebForms;
using System.Data;
using System.Collections;
using System.Configuration;
using System.Web;

namespace WebAPIDataAccess.SSRS
{
    public class DAReportingSvc : DABase
    {
        #region Properties
        protected override string ConnectionString
        {
            get { return DAConnectionStrings.WireSecurityConnectionString; }
        }

        const string SQLGETCONNECTION = @"SELECT 
                D.DatabaseId,
                D.DatabaseName,
                D.EnvironmentId,
                D.UserName,
                D.Password,
                D.DatabaseStatus,
                D.DatabaseAliasName,
                D.ApplicationId,
                D.ServerName,
                A.AppName as ApplicationName
                FROM Sec_Databases as D
                INNER JOIN Sec_Applications as A
                ON D.ApplicationId = A.AppId
                WHERE D.DatabaseAliasName = @DatabaseAliasName
                AND D.EnvironmentId = @EnvironmentId
                AND D.ApplicationId = @ApplicationId;";

        #endregion

        #region Public Methods

        public SSRSResponseStream FxRptToStreamPDF(ReportParameters report)
        {        
            Warning[] warnings;
            string[] streamIds;
            string mimeType;
            string encoding;
            string extension;
            string listCountries = string.IsNullOrEmpty(report.ListCountries) ? string.Empty : report.ListCountries;
            DataTable dtResult = new DataTable();
            SSRSResponseStream result = new SSRSResponseStream();

            try
            {
                dtResult = GetEnvironmentInformation();
                string ReportUrl = dtResult.Rows[0]["ServerName"].ToString();
                string ReportUser = DAConnectionStrings.GetDecryptSetting(dtResult.Rows[0]["UserName"].ToString());
                string ReportPassword = DAConnectionStrings.GetDecryptSetting(dtResult.Rows[0]["Password"].ToString());
                string ReportDomain = DAConnectionStrings.GetDecryptSetting(ConfigurationManager.AppSettings["ReportDomain"].ToString());

                ReportViewer rv = new ReportViewer { ProcessingMode = ProcessingMode.Remote };
                rv.AsyncRendering = false;
                ServerReport sr = rv.ServerReport;
                sr.ReportServerUrl = new Uri(ReportUrl);                

                IReportServerCredentials cred = new CustomReportCredentials(ReportUser, ReportPassword, ReportDomain);
                rv.ServerReport.ReportServerCredentials = cred;
                rv.ServerReport.ReportPath = "/" + report.ReportFolder + "/" + report.ReportName;

                List<ReportParameter> paramList = new List<ReportParameter>();
                paramList.Add(new ReportParameter("AgencyCode", report.AgencyCode, false));
                paramList.Add(new ReportParameter("ListCountries", listCountries, false));
                rv.ServerReport.SetParameters(paramList);

                result.StreamInfo = rv.ServerReport.Render("PDF", null, out mimeType, out encoding, out extension, out streamIds, out warnings);

                if (report.Fax)
                {
                    var path = HttpContext.Current.Server.MapPath("~/App_Data/");
                    var faxFilePath = string.Format("{0}FaxToAgenciesExchangeRates_{1}{2}", path, report.AgencyCode.Trim(), ".pdf");
                    SaveReport(result.StreamInfo, faxFilePath);
                    result.FaxFilePath = faxFilePath;
                }
            }
            catch (Exception ex)
            {
                result.SetMessages(ErrorResult.UnexpectedError, ex.Message);
            }
            return result;
        }

        public void DeleteFaxTempReport(string agencyCode)
        {
            var path = HttpContext.Current.Server.MapPath("~/App_Data/");
            var filePath = string.Format("{0}FaxToAgenciesExchangeRates_{1}{2}", path, agencyCode.Trim(), ".pdf");
            if (File.Exists(filePath))
                File.Delete(filePath);
        }

        #endregion

        #region Private Methods

        private DataTable GetEnvironmentInformation()
        {
            var command = GetTextCommand(SQLGETCONNECTION);
            command.Parameters.Add(CreateParameter("@DatabaseAliasName", "REPORTSERVER"));
            command.Parameters.Add(CreateParameter("@EnvironmentId", 13));
            command.Parameters.Add(CreateParameter("@ApplicationId", 2));

            return ExecuteDataTable(command);
        }

        private void SaveReport(Byte[] bytPDF, string fileLocation)
        {           
            using (FileStream stream = File.OpenWrite(fileLocation))
            {
                stream.Write(bytPDF, 0, bytPDF.Length);
            }
        }

        #endregion
    }
}
