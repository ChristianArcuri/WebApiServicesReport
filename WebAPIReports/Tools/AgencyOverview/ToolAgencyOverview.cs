using System;
using System.Collections.Generic;
using System.Linq;
using WEbAPIEntities.Common;
using System.IO;
using System.Globalization;
using WebAPIReports.Reports.AgencyOverview;
using WEbAPIEntities.Invoice;
using WebAPIReports.Reports;

namespace WebAPIReports.Tools.AgencyOverview
{ 
    public static class ToolAgencyOverview
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(ToolAgencyOverview));

        #region private
       
        private static InvoiceResultStream ReportToStreamPDF( DevExpress.XtraReports.UI.XtraReport report, InvoiceParameters param)
        {
            InvoiceResult result = new InvoiceResult();

            result = PopulateReportParameters(report, param);
            MemoryStream stream = new MemoryStream();
            if (result.ErrorCode == 0)
            {
                try
                {
                    DevExpress.XtraPrinting.PdfExportOptions opt = new DevExpress.XtraPrinting.PdfExportOptions();
                    opt.NeverEmbeddedFonts = string.Empty;
                    report.ExportToPdf(stream, opt);
                    report.Dispose();
                }
                catch (Exception ex)
                {
                    log.ErrorFormat("ReportToStreamPDF ERROR: {0}", ex.Message);
                    result.SetMessages(ErrorResult.UnexpectedError, ex.Message);
                }
            }
            else
                log.ErrorFormat("Error populating parameter {0}", result.ErrorMessage);

            InvoiceResultStream rs = new InvoiceResultStream();

            rs.ErrorCode = result.ErrorCode;
            rs.ErrorMessage = result.ErrorMessage;
            rs.StreamInfo = stream.ToArray();
            return rs;
        }

        private static InvoiceResultStream ReportToStreamCSV(DevExpress.XtraReports.UI.XtraReport report, InvoiceParameters param)
        {
            InvoiceResult result = new InvoiceResult();

            result = PopulateReportParameters(report, param);
            MemoryStream stream = new MemoryStream();
            if (result.ErrorCode == 0)
            {
                try
                {                    
                    // report.Bands[DevExpress.XtraReports.UI.BandKind.TopMargin].Visible = false;
                    report.Bands[DevExpress.XtraReports.UI.BandKind.BottomMargin].Visible = false;
                    // report.Bands[DevExpress.XtraReports.UI.BandKind.ReportFooter].Visible = false;
                    report.ExportToCsv(stream);
                    report.Dispose();
                }
                catch (Exception ex)
                {
                    log.ErrorFormat("ReportToStreamCSV ERROR: {0}", ex.Message);
                    result.SetMessages(ErrorResult.UnexpectedError, ex.Message);
                }
            }
            else
                log.ErrorFormat("Error populating parameter {0}", result.ErrorMessage);

            InvoiceResultStream rs = new InvoiceResultStream();

            rs.ErrorCode = result.ErrorCode;
            rs.ErrorMessage = result.ErrorMessage;
            rs.StreamInfo = stream.ToArray();
            return rs;
        }

        #endregion

        #region publics

        public static InvoiceResultStream EndOfDayRptToStreamPDF(InvoiceParameters param)
        {
            //  log.Info("ToolInvoice. Stream To PDF");
            EndOfDayCompanyReport report = new EndOfDayCompanyReport();

            return ReportToStreamPDF(report, param);
        }

        public static InvoiceResultStream EndOfDayRptToStreamPDFV2(InvoiceParameters param)
        {
            //  log.Info("ToolInvoice. Stream To PDF");
            EndOfDayCompanyReportV2 report = new EndOfDayCompanyReportV2();

            return ReportToStreamPDF(report, param);
        }

        public static InvoiceResultStream EndOfDayRptToStreamPDFV3(InvoiceParameters param)
        {
            //  log.Info("ToolInvoice. Stream To PDF");
            EndOfDayCompanyReportV3 report = new EndOfDayCompanyReportV3();

            return ReportToStreamPDF(report, param);
        }

        public static InvoiceResultStream SentWiresRptToStreamPDF(InvoiceParameters param)
        {
            //  log.Info("ToolInvoice. Stream To PDF");
            SentWiresCompanyReport report = new SentWiresCompanyReport();
            return ReportToStreamPDF(report, param);
        }

        public static InvoiceResultStream SentWiresRptSmallToStreamPDF(InvoiceParameters param)
        {
            //  log.Info("ToolInvoice. Stream To PDF");
            SentWiresSMReport report = new SentWiresSMReport();

            return ReportToStreamPDF(report, param);
        }

        public static InvoiceResultStream SentWiresRptSmallToStream(InvoiceParameters param, string format)
        {
            SentWiresSMReport report = new SentWiresSMReport();
            return ReportToStream(report, param, format);
        }

        public static InvoiceResultStream SentWiresRptToStream(InvoiceParameters param, string format)
        {
            SentWiresCompanyReportV2 report = new SentWiresCompanyReportV2();
            return ReportToStream(report, param, format);
        }
        public static InvoiceResultStream CombinedRptToStreamPDF(InvoiceParameters param)
        {
            //  log.Info("ToolInvoice. Stream To PDF");
            CombinedCompanyReport report = new CombinedCompanyReport();

            return ReportToStreamPDF(report, param);
        }

        public static InvoiceResultStream CombinedSummaryRptToStreamPDF(InvoiceParameters param)
        {
            //  log.Info("ToolInvoice. Stream To PDF");
            CombinedSummaryCompanyReport report = new CombinedSummaryCompanyReport();
            return ReportToStreamPDF(report, param);
        }       

        public static InvoiceResultStream RegulatoryComplianceRptToStream(InvoiceParameters param, string format)
        {
            RegulatoryComplianceCompanyReport report = new RegulatoryComplianceCompanyReport();
            return ReportToStream(report, param, format);
        }

        public static InvoiceResultStream RegulatoryComplianceRptToStreamV2(InvoiceParameters param, string format)
        {
            RegulatoryComplianceCompanyReportExcel report = new RegulatoryComplianceCompanyReportExcel();
            return ReportToStream(report, param, format);
        }

        #endregion

        private static InvoiceResult PopulateReportParameters(DevExpress.XtraReports.UI.XtraReport report, InvoiceParameters param)
        {
            InvoiceResult result = new InvoiceResult();
            try
            {
                foreach (var par in report.Parameters)
                {
                    string val = "";
                    if (param.parameters.TryGetValue(par.Name, out val))
                    {
                        if (val == null)
                            par.Value = DBNull.Value;
                        else
                            par.Value = val;
                    }
                    else
                    {
                        var defaultParameters = ReportCommon.DefaultParameters.Split(',').Select(o=>o.Trim());
                        if (!(defaultParameters.Any(o => par.Name.Contains(o))))
                        {
                            result.SetMessages(ErrorResult.MissingReportParameter, par.Name);
                            log.ErrorFormat("Missing Parameter {0}", par.Name);
                            break;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                result.SetMessages(ErrorResult.InvalidReportParameter, ex.Message);
            }
            return result;
        }

        private static InvoiceResultStream ReportToStream(DevExpress.XtraReports.UI.XtraReport report, InvoiceParameters param, string format)
        {
            InvoiceResultStream rs = new InvoiceResultStream();

            switch (format.ToUpper())
            {
                case "PDF":
                    rs = ReportToStreamPDF(report, param);
                    break; 
                case "CSV":
                    rs = ReportToStreamCSV(report, param);
                    break;
            }
            return rs;
        }
    }

    public static class StringExtensions
    {
        public static string[] Split(this string value, int position)
        {
            List<string> result = new List<string>();
            string temp = value.Trim();

            int i = 0;
            while (position - 1 < temp.Length)
            {
                string s = temp.Substring(0, position - 1);
                if (s.LastIndexOf(' ') > 0)
                    s = s.Substring(0, s.LastIndexOf(' '));
                result.Add(s.Trim());
                temp = temp.Substring(s.Length + 1, temp.Length - s.Length - 1).Trim();
                i++;
            }
            if (!string.IsNullOrWhiteSpace(temp))
            {
                result.Add(temp);
            }
            return result.ToArray<string>();
        }

    }
}
