using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEbAPIEntities.Common;
using WEbAPIEntities.Invoice;
using WebAPIReports.Reports;

namespace WebAPIReports.Tools
{
    public class Tools
    {
        private  readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(Tools));
        const string TopParameter = "TOP";
        private TResult PopulateReportParameters(DevExpress.XtraReports.UI.XtraReport report, TParameters param)
        {
            TResult result = new TResult();
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
                        if (!(defaultParameters.Any(o => par.Name.Contains(o)) || ((report is Reports.FXFAX.ExchangeRateReport || report is Reports.FXFAX.FxFaxMainSm) && par.Name.ToUpper() == TopParameter)))
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
        private TResult ValidateFilePath(string filePath)
        {

            TResult result = new TResult();

            if (!Directory.Exists(Path.GetDirectoryName(filePath)))
            {
                result.SetMessages(ErrorResult.InvalidFilePath, filePath);

            }

            return result;
        }

        private TResultStream ReportToStreamPDF(DevExpress.XtraReports.UI.XtraReport report, TParameters param)
        {
            TResult result = new TResult();

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

            TResultStream rs = new TResultStream();

            rs.ErrorCode = result.ErrorCode;
            rs.ErrorMessage = result.ErrorMessage;
            rs.StreamInfo = stream.ToArray();
            return rs;
        }

        private TResultStream ReportToStreamPRNX(DevExpress.XtraReports.UI.XtraReport report, TParameters param)
        {
            MemoryStream stream = new MemoryStream();
            TResult result = PopulateReportParameters(report, param);

            if (result.ErrorCode == 0)
            {
                try
                {
                    report.CreateDocument();
                    report.PrintingSystem.SaveDocument(stream);
                    report.Dispose();
                }
                catch (Exception ex)
                {
                    log.ErrorFormat("ReportToStreamPRNX ERROR: {0}", ex.Message);
                    result.SetMessages(ErrorResult.UnexpectedError, ex.Message);
                }
            }
            else
                log.ErrorFormat("Error populating parameter {0}", result.ErrorMessage);


            TResultStream rs = new TResultStream();

            rs.ErrorCode = result.ErrorCode;
            rs.ErrorMessage = result.ErrorMessage;
            rs.StreamInfo = stream.ToArray();
            return rs;
        }

        private TResultStream ReportToStreamPNG(DevExpress.XtraReports.UI.XtraReport report, TParameters param)
        {
            TResult result = new TResult();
            result = PopulateReportParameters(report, param);
            MemoryStream stream = new MemoryStream();
            if (result.ErrorCode == 0)
            {
                try
                {
                    DevExpress.XtraPrinting.ImageExportOptions opt = new DevExpress.XtraPrinting.ImageExportOptions();
                    opt.ExportMode = DevExpress.XtraPrinting.ImageExportMode.SingleFilePageByPage;
                    opt.Format = System.Drawing.Imaging.ImageFormat.Png;

                    report.ExportToImage(stream, opt);
                    report.Dispose();
                }
                catch (Exception ex)
                {
                    log.ErrorFormat("ReportToStreamPNG ERROR: {0}", ex.Message);
                    result.SetMessages(ErrorResult.UnexpectedError, ex.Message);
                }
            }
            else
                log.ErrorFormat("Error populating parameter {0}", result.ErrorMessage);

            TResultStream rs = new TResultStream();

            rs.ErrorCode = result.ErrorCode;
            rs.ErrorMessage = result.ErrorMessage;
            rs.StreamInfo = stream.ToArray();
            return rs;
        }

        private TResultStream ReportToStreamHTML(DevExpress.XtraReports.UI.XtraReport report, TParameters param)
        {
            TResult result = new TResult();
            result = PopulateReportParameters(report, param);
            MemoryStream stream = new MemoryStream();
            if (result.ErrorCode == 0)
            {
                try
                {
                    DevExpress.XtraPrinting.HtmlExportOptions opt = new DevExpress.XtraPrinting.HtmlExportOptions();
                    opt.EmbedImagesInHTML = true;

                    report.ExportToHtml(stream, opt);
                    report.Dispose();
                }
                catch (Exception ex)
                {
                    log.ErrorFormat("ReportToStreamHTML ERROR: {0}", ex.Message);
                    result.SetMessages(ErrorResult.UnexpectedError, ex.Message);
                }
            }
            else
                log.ErrorFormat("Error populating parameter {0}", result.ErrorMessage);

            TResultStream rs = new TResultStream();

            rs.ErrorCode = result.ErrorCode;
            rs.ErrorMessage = result.ErrorMessage;
            rs.StreamInfo = stream.ToArray();
            return rs;
        }

        private TResultStream ReportToStreamTXT(DevExpress.XtraReports.UI.XtraReport report, TParameters param)
        {
            TResult result = new TResult();
            result = PopulateReportParameters(report, param);
            MemoryStream stream = new MemoryStream();
            if (result.ErrorCode == 0)
            {
                try
                {
                    //DevExpress.XtraPrinting.TextExportOptions opt = new DevExpress.XtraPrinting.TextExportOptions();
                    //opt.Separator = "";

                    report.ExportToRtf(stream);

                    //report.CreateDocument();
                    //report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                    //report.PrintingSystem.ExportToText(stream);

                    report.Dispose();
                }
                catch (Exception ex)
                {
                    log.ErrorFormat("ReportToStreamTXT ERROR: {0}", ex.Message);
                    result.SetMessages(ErrorResult.UnexpectedError, ex.Message);
                }
            }
            else
                log.ErrorFormat("Error populating parameter {0}", result.ErrorMessage);

            TResultStream rs = new TResultStream();

            rs.ErrorCode = result.ErrorCode;
            rs.ErrorMessage = result.ErrorMessage;
            rs.StreamInfo = stream.ToArray();
            return rs;
        }

        private TResultStream ReportToStreamXLSX(DevExpress.XtraReports.UI.XtraReport report, TParameters param)
        {
            TResult result = new TResult();

            result = PopulateReportParameters(report, param);
            MemoryStream stream = new MemoryStream();
            if (result.ErrorCode == 0)
            {
                try
                {
                   //report.Bands[DevExpress.XtraReports.UI.BandKind.TopMargin].Visible = false;
                    report.ExportToXlsx(stream);
                    report.Dispose();
                }
                catch (Exception ex)
                {
                    log.ErrorFormat("ReportToStreamXLSX ERROR: {0}", ex.Message);
                    result.SetMessages(ErrorResult.UnexpectedError, ex.Message);
                }
            }
            else
                log.ErrorFormat("Error populating parameter {0}", result.ErrorMessage);

            TResultStream rs = new TResultStream();

            rs.ErrorCode = result.ErrorCode;
            rs.ErrorMessage = result.ErrorMessage;
            rs.StreamInfo = stream.ToArray();
            return rs;
        }

        private TResultStream ReportToStreamCSV(DevExpress.XtraReports.UI.XtraReport report, TParameters param)
        {
            TResult result = new TResult();

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

            TResultStream rs = new TResultStream();

            rs.ErrorCode = result.ErrorCode;
            rs.ErrorMessage = result.ErrorMessage;
            rs.StreamInfo = stream.ToArray();
            return rs;
        }

        protected TResultStream ReportToStream(DevExpress.XtraReports.UI.XtraReport report, TParameters param, string format)
        {
            TResultStream rs = new TResultStream();

            switch (format.ToUpper())
            {
                case "PDF":
                    rs = ReportToStreamPDF(report, param);
                    break;
                case "PNG":
                    rs = ReportToStreamPNG(report, param);
                    break;
                case "PRNX":
                    rs = ReportToStreamPRNX(report,param);
                    break;
                case "XLSX":
                    rs = ReportToStreamXLSX(report, param);
                    break;
                case "CSV":
                    rs = ReportToStreamCSV(report, param);
                    break;
            }
            return rs;
        }

        #region ToFile

        protected TResult ReportToFilePDF(DevExpress.XtraReports.UI.XtraReport report, TParameters param, string fpath)
        {
            TResult result = new TResult();

            result = ValidateFilePath(fpath);
          
            if (result.ErrorCode == 0)
            {
                result = PopulateReportParameters(report, param);
              
                if (result.ErrorCode == 0)
                {
                    try
                    {
                        DevExpress.XtraPrinting.PdfExportOptions opt = new DevExpress.XtraPrinting.PdfExportOptions();
                        opt.NeverEmbeddedFonts = string.Empty;
                        report.ExportToPdf(fpath, opt);

                    }
                    catch (Exception ex)
                    {
                        result.SetMessages(ErrorResult.UnexpectedError, ex.Message);
                        log.ErrorFormat("ReportToFilePDF ERROR: {0}", ex.Message);
                    }
                }
                else
                    log.ErrorFormat("Error populating parameter {0}",result.ErrorMessage);
            }
            else
                log.ErrorFormat("Error validating file path {0}", result.ErrorMessage);

            report.Dispose();

            return result;
        }

      

        #endregion
    }
}
