using System;
using System.Collections.Generic;
using System.Linq;
using WEbAPIEntities.Common;
using System.IO;
using System.Globalization;
using WEbAPIEntities.Invoice;
using WebAPIReports.Reports;

namespace WebAPIReports.Tools.BillPayment
{
    public static class ToolBillPayment
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(ToolBillPayment));

        #region private

        private static InvoiceResultStream ReportToStreamPDF(DevExpress.XtraReports.UI.XtraReport report, InvoiceParameters param)
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

        #endregion

        #region publics

        public static InvoiceResultStream BillPymtEndOfDayRptToStreamPDF(InvoiceParameters param)
        {
            //  log.Info("ToolInvoice. Stream To PDF");
            BillPymtEndOfDayCompanyReport report = new BillPymtEndOfDayCompanyReport();

            return ReportToStreamPDF(report, param);
        }
        public static InvoiceResultStream ProcessedBillsRptToStreamPDF(InvoiceParameters param)
        {
            //  log.Info("ToolInvoice. Stream To PDF");
            var report = new CompanyProcessedBillsMstrReport();

            return ReportToStreamPDF(report, param);
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
                        var defaultParameters = ReportCommon.DefaultParameters.Split(',').Select(o => o.Trim());
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
