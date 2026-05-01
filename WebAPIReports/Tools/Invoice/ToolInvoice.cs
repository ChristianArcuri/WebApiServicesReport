using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEbAPIEntities.Invoice;
using WEbAPIEntities.Common;
using WebAPIReports.Reports.Invoice;
using WebAPIReports.Reports.Invoice.SmallFormat;
using System.IO;
using System.Data;
using WebAPIDataAccess.WireTransac;
using WebAPIDataAccess.WireSecurity;

using System.Globalization;
using WebAPIReports.Reports.Invoice.Common.Interfaces;

namespace WebAPIReports.Tools.Invoice
{
    public static class ToolInvoice
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(ToolInvoice));

        #region private
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
                    else if (par.Name == "IsInvoiceForCaribe" && val == null)
                    {
                        param.parameters.Add("IsInvoiceForCaribe", "false");
                        par.Value = false;
                    }
                    else
                    {
                        if (!par.Name.Contains("FormName"))
                        {
                            result.SetMessages(ErrorResult.MissingReportParameter, par.Name);
                            log.ErrorFormat("Missing Parameter {0}",par.Name);
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
        private static InvoiceResult ValidateFilePath(string filePath)
        {

            InvoiceResult result = new InvoiceResult();

            if (!Directory.Exists(Path.GetDirectoryName(filePath)))
            {
                result.SetMessages(ErrorResult.InvalidFilePath, filePath);

            }

            return result;
        }

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

        private static InvoiceResultStream ReportToStreamPRNX(DevExpress.XtraReports.UI.XtraReport report, InvoiceParameters param)
        {
            MemoryStream stream = new MemoryStream();
            InvoiceResult result = PopulateReportParameters(report, param);

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


            InvoiceResultStream rs = new InvoiceResultStream();

            rs.ErrorCode = result.ErrorCode;
            rs.ErrorMessage = result.ErrorMessage;
            rs.StreamInfo = stream.ToArray();
            return rs;
        }

        private static InvoiceResultStream ReportToStreamPNG(DevExpress.XtraReports.UI.XtraReport report, InvoiceParameters param)
        {
            InvoiceResult result = new InvoiceResult();
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

            InvoiceResultStream rs = new InvoiceResultStream();

            rs.ErrorCode = result.ErrorCode;
            rs.ErrorMessage = result.ErrorMessage;
            rs.StreamInfo = stream.ToArray();
            return rs;
        }
        
        private static InvoiceResultStream ReportToStreamHTML(DevExpress.XtraReports.UI.XtraReport report, InvoiceParameters param)
        {
            InvoiceResult result = new InvoiceResult();
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

            InvoiceResultStream rs = new InvoiceResultStream();

            rs.ErrorCode = result.ErrorCode;
            rs.ErrorMessage = result.ErrorMessage;
            rs.StreamInfo = stream.ToArray();
            return rs;
        }

        private static InvoiceResultStream ReportToStreamTXT(DevExpress.XtraReports.UI.XtraReport report, InvoiceParameters param)
        {
            InvoiceResult result = new InvoiceResult();
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

            InvoiceResultStream rs = new InvoiceResultStream();

            rs.ErrorCode = result.ErrorCode;
            rs.ErrorMessage = result.ErrorMessage;
            rs.StreamInfo = stream.ToArray();
            return rs;
        }

        private static InvoiceResultStream ReportToStreamXLSX(DevExpress.XtraReports.UI.XtraReport report, InvoiceParameters param)
        {
            InvoiceResult result = new InvoiceResult();

            result = PopulateReportParameters(report, param);
            MemoryStream stream = new MemoryStream();
            if (result.ErrorCode == 0)
            {
                try
                {
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

            InvoiceResultStream rs = new InvoiceResultStream();

            rs.ErrorCode = result.ErrorCode;
            rs.ErrorMessage = result.ErrorMessage;
            rs.StreamInfo = stream.ToArray();
            return rs;
        }

        private static void ProcessHeader(StreamWriter writer, DataTable header, DataTable language)
        {
            if (header.Rows.Count > 0)
            {
                writer.WriteLine("<B><H>");
                writer.WriteLine(string.Format("<!C>{0}</B></H>", header.Rows[0]["LegalEntityOfficialName"]));
                writer.WriteLine(string.Format("<!C><B>{0}</B>", header.Rows[0]["AgencyCode"].ToString().Trim()));
                writer.WriteLine(string.Format("<!C><B>{0}</B>", header.Rows[0]["Agname"].ToString().Trim()));

                writer.WriteLine("<LF>");
                writer.WriteLine("<!D>");

                writer.WriteLine(string.Format("{0,-22}{1,-10}{2,16}",
                                                language.Rows[0]["Date"],
                                                language.Rows[0]["AgencySeq"],
                                                language.Rows[0]["InvoiceNum"]));

                DateTime dt1 = Convert.ToDateTime(header.Rows[0]["TransactionDateFrom"]);
                DateTime dt2 = Convert.ToDateTime(header.Rows[0]["TransactionDateTo"]);
                string st = string.Empty;

                if (dt1 == dt2)
                {
                    st = dt1.ToString("MM/dd/yy");
                }
                else
                    st = string.Format("{0} - {1}", dt1.ToString("MM/dd/yy"), dt2.ToString("MM/dd/yy"));


                writer.WriteLine(string.Format("{0,-22}{1,-10}{2,16}",
                                               st,
                                               header.Rows[0]["AgStatementSeq"],
                                               header.Rows[0]["StatementId"]));
                writer.WriteLine("<!D>");
                writer.WriteLine("<LF>");
            }
        }

        private static void ProcessPayments(StreamWriter writer, DataTable payments, DataTable language)
        {
            /// PAYMENTS
            if (payments.Rows.Count > 0)
            {
                writer.WriteLine(string.Format("<B>{0}</B>", language.Rows[0]["Payments"].ToString().ToUpper()));
                writer.WriteLine("<!D>");
                writer.WriteLine(string.Format("{0,-10}{1,-28}{2,10}",
                                                language.Rows[0]["Date"],
                                                language.Rows[0]["Description"],
                                                language.Rows[0]["Deposits"]));
                writer.WriteLine("<!D>");
                foreach (DataRow row in payments.Rows)
                {
                    string[] desc = row["StatementDesc"].ToString().Split(28);
                    writer.WriteLine(string.Format("{0,-10}{1,-26}{2,12:$#,##0.00}",
                                                   Convert.ToDateTime(row["TransactionDate"]).ToString("MM/dd/yy"),
                                                   desc[0],
                                                   row["Amount"]));
                    if (desc.Count() > 1)
                    {
                        for (int i = 1; i < desc.Count(); i++)
                        {
                            writer.WriteLine(string.Format("{0,-10}{1,-26}",
                                                            string.Empty,
                                                            desc[i]));
                        }
                    }
                }
                writer.WriteLine("<!D>");
                writer.WriteLine(string.Format("<B>{0,48:$#,##0.00}</B>", payments.Compute("Sum(Amount)", "")));
                writer.WriteLine("<LF>");
            }
        }

        private static void ProcessOthers(StreamWriter writer, DataTable others, DataTable language)
        {
            /// OTHER CREDITS AND DEBITS
            if (others.Rows.Count > 0)
            {
                writer.WriteLine(string.Format("<B>{0}</B>", language.Rows[0]["OtherDebitCredit"].ToString().ToUpper()));
                writer.WriteLine("<!D>");
                string[] desc = language.Rows[0]["ActivityBalance"].ToString().Trim().Split(10);

                writer.WriteLine(string.Format("{0,-10}{1,-28}{2,10}",
                                                language.Rows[0]["Date"],
                                                language.Rows[0]["Description"],
                                                desc[0]));
                if (desc.Count() > 1)
                {
                    for (int i = 1; i < desc.Count(); i++)
                    {
                        writer.WriteLine(string.Format("{0,48}",
                                                        desc[i]));
                    }
                }
                writer.WriteLine("<!D>");
                foreach (DataRow row in others.Rows)
                {
                    desc = row["StatementDesc"].ToString().Trim().Split(26);
                    writer.WriteLine(string.Format("{0,-10}{1,-26}{2,12:$#,##0.00}",
                                                   Convert.ToDateTime(row["TransactionDate"]).ToString("MM/dd/yy"),
                                                   desc[0],
                                                   row["Amount"]));
                    if (desc.Count() > 1)
                    {
                        for (int i = 1; i < desc.Count(); i++)
                        {
                            writer.WriteLine(string.Format("{0,-10}{1,-26}",
                                                            string.Empty,
                                                            desc[i]));
                        }
                    }
                }
                writer.WriteLine("<!D>");
                writer.WriteLine(string.Format("<B>{0,48:$#,##0.00}</B>", others.Compute("Sum(Amount)", "")));
                writer.WriteLine("<LF>");
            }
        }

        private static void ProcessCancellations(StreamWriter writer, DataTable cancellations, DataTable language)
        {
            /// CANCELLATIONS
            if (cancellations.Rows.Count > 0)
            {
                writer.WriteLine(string.Format("<B>{0}</B>", language.Rows[0]["Cancellations"].ToString().ToUpper()));
                writer.WriteLine("<!D>");
                string[] desc = language.Rows[0]["ActivityBalance"].ToString().Split(10);
                writer.WriteLine(string.Format("{0,-8}{1,-9}{2,-17}{3,5}{4,9}",
                                                language.Rows[0]["Date"],
                                                language.Rows[0]["WireNo"],
                                                language.Rows[0]["Description"],
                                                language.Rows[0]["Void"],
                                                desc[0]));
                if (desc.Count() > 1)
                {
                    for (int i = 1; i < desc.Count(); i++)
                    {
                        writer.WriteLine(string.Format("{0,48}",
                                                        desc[i]));
                    }
                }
                writer.WriteLine("<!D>");
                foreach (DataRow row in cancellations.Rows)
                {
                    desc = row["StatementDesc"].ToString().Split(17);
                    writer.WriteLine(string.Format("{0,-9}{1,-8}{2,-17}{3,2}{4,12:$#,##0.00}",
                                                   Convert.ToDateTime(row["TransactionDate"]).ToString("MM/dd/yy"),
                                                   row["AgSenderSeq"],
                                                   desc[0],
                                                   row["Cancel"],
                                                   row["ActivityBalance"]));
                    if (desc.Count() > 1)
                    {
                        for (int i = 1; i < desc.Count(); i++)
                        {
                            writer.WriteLine(string.Format("{0,-9}{1,-8}{2,-16}",
                                                            string.Empty,
                                                            string.Empty,
                                                            desc[i]));
                        }
                    }
                }
                writer.WriteLine("<!D>");
                writer.WriteLine(string.Format("<B>{0,48:$#,##0.00}</B>", cancellations.Compute("Sum(ActivityBalance)", "")));
                writer.WriteLine("<LF>");
            }
        }

        private static void ProcessWires(StreamWriter writer, DataTable wires, DataTable language)
        {
            /// WIRES
            if (wires.Rows.Count > 0)
            {
                string[] desc = language.Rows[0]["ActivityBalance"].ToString().Split(10);
                writer.WriteLine(string.Format("<B>{0}</B>", language.Rows[0]["WireTransfers"].ToString().ToUpper()));
                writer.WriteLine("<!D>");
                writer.WriteLine(string.Format("{0,-9}{1,-22}{2,5}{3,12}",
                                                language.Rows[0]["WireNo"],
                                                language.Rows[0]["Sender"],
                                                language.Rows[0]["Void"],
                                                desc[0]));

                if (desc.Count() > 1)
                {
                    for (int i = 1; i < desc.Count(); i++)
                    {
                        writer.WriteLine(string.Format("{0,48}",
                                                        desc[i]));
                    }
                }

                string tranDate = string.Empty;
                int qtyWires = 0;
                decimal balanceWires = 0;
                foreach (DataRow row in wires.Rows)
                {
                    if (string.IsNullOrWhiteSpace(tranDate))
                    {
                        tranDate = Convert.ToDateTime(row["TransactionDate"]).ToString("MM/dd/yy");
                        writer.WriteLine("<!D>");
                        writer.WriteLine(string.Format("<B>{0}</B>", tranDate));
                        writer.WriteLine("<!D>");
                    }
                    else if (tranDate != Convert.ToDateTime(row["TransactionDate"]).ToString("MM/dd/yy"))
                    {
                        writer.WriteLine("<!D>");
                        writer.WriteLine(string.Format("{0,-9}{1,22}{2,-5}{3,12:$#,##0.00}", tranDate, "Total ", qtyWires, balanceWires));
                        writer.WriteLine("<!D>");

                        tranDate = Convert.ToDateTime(row["TransactionDate"]).ToString("MM/dd/yy");

                        writer.WriteLine(string.Format("<B>{0}</B>", tranDate));
                        writer.WriteLine("<!D>");
                        qtyWires = 0;
                        balanceWires = 0;
                    }

                    bool isWS = row["Type"].ToString().ToUpper() == "WS" && row["ChartDescription"].ToString().ToUpper() != "REPLACEMENT";

                    desc = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(row["SenderName"].ToString().ToLower().Trim()).Split(25);
                  
                    if (isWS)
                    {
                        qtyWires++;
                        writer.WriteLine(string.Format("{0,-8}{1,-25}{2,3}{3,12:$#,##0.00}",
                                                row["AgSenderSeq"],
                                                desc[0],
                                                row["Cancel"],
                                                row["ActivityBalance"]));

                        for (int i = 1; i < desc.Count(); i++)
                        {
                            writer.WriteLine(string.Format("{0,-8}{1,-25}",
                                                            string.Empty,
                                                            desc[i]
                                                            ));
                        }
                        
                    }
                    else
                    {
                        writer.WriteLine(string.Format("{0,-8}{1,-32}{2,3}{3,12:$#,##0.00}",
                                               row["AgSenderSeq"],
                                               string.Format("{0}{1}{2}", "<B>", desc[0], "</B>"),
                                               row["Cancel"],
                                               row["ActivityBalance"]));


                        for (int i = 1; i < desc.Count(); i++)
                        {
                            writer.WriteLine(string.Format("{0,-8}{1,-32}",
                                                            string.Empty,
                                                            string.Format("{0}{1}{2}", "<B>", desc[i], "</B>")
                                                            ));
                        }
                    }
                 
                   
                  
                    balanceWires += Convert.ToDecimal(row["ActivityBalance"]);
                }
                writer.WriteLine("<!D>");
                writer.WriteLine(string.Format("<B>{0,27}{1,-5}{2,16:$#,##0.00}</B>",
                                                "Total ",
                                                (int)wires.Compute("Count(AgSenderSeq)", ""),
                                                wires.Compute("Sum(ActivityBalance)", "")
                                                ));
                writer.WriteLine("<LF>");

                ProcessNote(writer, language);

            }
        }

        private static void ProcessBillPayments(StreamWriter writer, DataTable billPayments, DataTable language)
        {
            /// PAYMENTS
            if (billPayments.Rows.Count > 0)
            {
                writer.WriteLine(string.Format("<B>{0}</B>", language.Rows[0]["BillPayment"].ToString().ToUpper()));
                writer.WriteLine("<!D>");
                string[] descName = language.Rows[0]["ActivityBalance"].ToString().Trim().Split(10);

                writer.WriteLine(string.Format("{0,-10}{1,-28}{2,10}",
                                                language.Rows[0]["Date"],
                                                language.Rows[0]["Sender"],
                                                descName[0]));
                if (descName.Count() > 1)
                {
                    for (int i = 1; i < descName.Count(); i++)
                    {
                        writer.WriteLine(string.Format("{0,48}",
                                                        descName[i]));
                    }
                }
                writer.WriteLine("<!D>");
                foreach (DataRow row in billPayments.Rows)
                {
                    string[] desc = row["BTSenderName"].ToString().Split(28);
                    writer.WriteLine(string.Format("{0,-10}{1,-26}{2,12:$#,##0.00}",
                                                   Convert.ToDateTime(row["TransactionDate"]).ToString("MM/dd/yy"),
                                                   desc[0],
                                                   row["BTTotAmountInv"]));
                    if (desc.Count() > 1)
                    {
                        for (int i = 1; i < desc.Count(); i++)
                        {
                            writer.WriteLine(string.Format("{0,-10}{1,-26}",
                                                            string.Empty,
                                                            desc[i]));
                        }
                    }
                }
                writer.WriteLine("<!D>");
                writer.WriteLine(string.Format("<B>{0,48:$#,##0.00}</B>", billPayments.Compute("Sum(BTTotAmountInv)", "")));
                writer.WriteLine("<LF>");
            }
        }
        private static void ProcessTotalValues(StreamWriter writer, DataTable header,DataTable wires, DataTable payments, DataTable others, 
                                                DataTable cancellations, DataTable billPayments,  DataTable language)
        {
            writer.WriteLine(string.Format("<B>{0,-32}{1,16:$#,##0.00}", 
                                           language.Rows[0]["BeginingBalance"],
                                           header.Rows[0]["BeginingBalance"]));
            
            writer.WriteLine(string.Format("{0,-29}{1,-5}{2,14:$#,##0.00}",
                                                      language.Rows[0]["Payments"],
                                                      (int)payments.Compute("Count(Amount)", ""),
                                                      payments.Compute("Sum(Amount)", "")
                                           ));
          
            writer.WriteLine(string.Format("{0,-29}{1,-5}{2,14:$#,##0.00}",
                                                    language.Rows[0]["OtherDebitCredit"],
                                                    (int)others.Compute("Count(Amount)", ""),
                                                    others.Compute("Sum(Amount)", "")
                                           ));

            string[] desc = language.Rows[0]["Cancellations"].ToString().Split(29);

            writer.WriteLine(string.Format("{0,-29}{1,-5}{2,14:$#,##0.00}",
                                                   desc[0],
                                                   (int)cancellations.Compute("Count(AgSenderSeq)", "Type='WC'"),
                                                   cancellations.Compute("Sum(ActivityBalance)", "")
                                          ));
            for (int i = 1; i < desc.Count(); i++)
            {
                writer.WriteLine(string.Format("{0,-29}",
                                                    desc[i]
                                           ));
            }

         
            var grp = wires.AsEnumerable().GroupBy(c => c.Field<DateTime>("TransactionDate")).Select(s => new
            {
                tranDate = s.Key,
                qty = s.Count(p=> p.Field<string>("Type")=="WS"),
                sum = s.Sum(p => p.Field<decimal>("ActivityBalance"))
            });
            foreach(var elem in grp)
            { 
            writer.WriteLine(string.Format("{0,-29}{1,-5}{2,14:$#,##0.00}",
                                                   string.Format("{0} {1}", language.Rows[0]["Wires"], elem.tranDate.ToString("MM/dd/yy")),
                                                   elem.qty,
                                                   elem.sum
                                          ));
            }

            if (billPayments.Rows.Count > 0)
            writer.WriteLine(string.Format("{0,-29}{1,-5}{2,14:$#,##0.00}",
                                                      language.Rows[0]["BillPayment"],
                                                      (int)billPayments.Compute("Count(BTTotAmountInv)", ""),
                                                      billPayments.Compute("Sum(BTTotAmountInv)", "")
                                           ));

            writer.WriteLine("<!D>");
            writer.WriteLine(string.Format("{0,-32}{1,16:$#,##0.00}</B>",
                                           language.Rows[0]["TotalPaymentDue"],
                                           header.Rows[0]["EndingBalance"]));
            writer.WriteLine("<LF>");
            writer.WriteLine("<LF>");
            writer.WriteLine(string.Format("<B>{0,-32}{1,16:$#,##0.00}</B>",
                                           language.Rows[0]["BeginingBalance"],
                                           header.Rows[0]["BeginingBalance"]));
            writer.WriteLine("<LF>");
        }
        
        private static void ProcessNote(StreamWriter writer, DataTable language)
        {
            var boldItalic = language.Rows[0]["bold italic"].ToString();
            boldItalic = boldItalic.Replace("italic", "").Replace("cursiva", "");

              string str = string.Format("<S>{0} <B>{1}</B> {2}</S>", 
                                            language.Rows[0]["InvoiceNote1"].ToString().Trim(),
                                            boldItalic.Trim(),
                                            language.Rows[0]["InvoiceNoteOther"].ToString().Trim());
              string[] desc = str.Split(74);

              for (int i = 0; i < desc.Count(); i++)
              {
                  writer.WriteLine(string.Format("{0,-74}",
                                                  desc[i]));
              }
              writer.WriteLine("<LF>");
        }

        private static void ProcessIntransit(StreamWriter writer, DataTable language, DataTable inTransit)
        {
            /// INTRANSIT
            if (inTransit.Rows.Count > 0)
            {
                writer.WriteLine("<!D>");
                writer.WriteLine(string.Format("<B>{0} {1}</B>", 
                                            language.Rows[0]["Payments"].ToString().ToUpper(),
                                            language.Rows[0]["InTransit"].ToString().ToUpper()));
                writer.WriteLine("<!D>");
              
                foreach (DataRow row in inTransit.Rows)
                {
                    string[] desc = string.Format("{0} ({1})",
                                                    row["InTransitReasonDesc"].ToString(),
                                                    row["ValueDescription"].ToString()
                                                    ).Split(37);
                    writer.WriteLine(string.Format("{0,-10}{1,-27}{2,11:$#,##0.00}",
                                                   Convert.ToDateTime(row["InTransitDate"]).ToString("MM/dd/yy"),
                                                   desc[0],
                                                   row["InTransitPendAmount"]));
                    if (desc.Count() > 1)
                    {
                        for (int i = 1; i < desc.Count(); i++)
                        {
                            writer.WriteLine(string.Format("{0,-10}{1,-27}",
                                                            string.Empty,
                                                            desc[i]));
                        }
                    }
                }
                writer.WriteLine("<!D>");
                writer.WriteLine(string.Format("<B>{0}{1,12:$#,##0.00}</B>", 
                                                string.Format("Total {0} {1}",
                                                               language.Rows[0]["Amount    "].ToString(), 
                                                               language.Rows[0]["InTransit"].ToString()),
                                                inTransit.Compute("Sum(InTransitPendAmount)", "")));
                writer.WriteLine("<!D>");
                writer.WriteLine("<LF>");
            }
        }
        private static void ProcessCommission(StreamWriter writer, DataTable header,DataTable wires,DataTable language)
        {
            if (Convert.ToBoolean(header.Rows[0]["ShowAgCommiStatement"]))
            {
                writer.WriteLine(string.Format("<B>{0}</B>", language.Rows[0]["AgentCommission"].ToString().ToUpper()));
                writer.WriteLine("<!D>");

                var grp = wires.AsEnumerable().GroupBy(c => c.Field<DateTime>("TransactionDate")).Select(s => new
                {
                    tranDate = s.Key,
                    comm = s.Sum(p => p.Field<decimal>("MonthlyCommission"))// + p.Field<decimal>("Other")
                });
                foreach (var elem in grp)
                {
                    writer.WriteLine(string.Format("<B>{0,-36}{1,12:$#,##0.00}</B>",
                                                           elem.tranDate.ToString("MM/dd/yy"),
                                                           elem.comm
                                                  ));
                }
                writer.WriteLine("<!D>");

                if (!Convert.ToBoolean(header.Rows[0]["DailyCommission"]) && (header.Rows[0]["CommiPaymentMethod"].ToString() == "ACH" ||
                    header.Rows[0]["CommiPaymentMethod"].ToString() == "CREDIT MEMO" ||
                    header.Rows[0]["CommiPaymentMethod"].ToString() == "CHECK" ||
                    header.Rows[0]["CommiPaymentMethod"].ToString() == "MANDATORY CHECK"))
                {
                    writer.WriteLine(string.Format("<S>{0} {1}</S>", 
                                                    language.Rows[0]["AgCommWillBePAid"].ToString(),
                                                    header.Rows[0]["CommiPaymentMethod"].ToString()
                                                    ));
                }
                writer.WriteLine("<LF>");
            }
        }

        private static void ProcessFaxStatement(StreamWriter writer, DataTable header)
        {
            if (!string.IsNullOrWhiteSpace(header.Rows[0]["AgFaxMessageText"].ToString()))
            {
                writer.WriteLine("<!D>");
                string[] desc = header.Rows[0]["AgFaxMessageText"].ToString().Split(64);

                writer.WriteLine("<S>");
                for (int i = 0; i < desc.Count(); i++)
                {
                    writer.WriteLine(string.Format("{0,-64}",
                                                     desc[i]
                                                    ));
                }
                writer.WriteLine("</S>");
                writer.WriteLine("<!D>");
                writer.WriteLine("<LF>");
            }

        }

        private static void ProcessEndNote(StreamWriter writer, DataTable language, DataTable header)
        {
            writer.WriteLine("<LF>");
            writer.WriteLine("<!D>");
            writer.WriteLine(string.Format("<S>{0}:", language.Rows[0]["SendDeposit"].ToString()));
            writer.WriteLine(string.Format("{0}: {1}", 
                                     language.Rows[0]["Fax"].ToString(),
                                     header.Rows[0]["LEFax"].ToString()));
            writer.WriteLine(string.Format("{0}: {1}",
                                    language.Rows[0]["Email"].ToString(),
                                    header.Rows[0]["LEEmail"].ToString()));
            writer.WriteLine(string.Format("{0}: {1}",
                                    language.Rows[0]["CellPhone"].ToString(),
                                    header.Rows[0]["LECellPhone"].ToString()));

            writer.WriteLine("<LF>");
            string[] desc = string.Format("{0} {1}</S>",
                                                    language.Rows[0]["LikeInfo"].ToString(),
                                                    header.Rows[0]["LEInvoicePhone"].ToString()
                                                    ).Split(64);
            for (int i = 0; i < desc.Count(); i++)
            {
                writer.WriteLine(string.Format("{0,-64}",
                                                desc[i]));
            }
            writer.WriteLine("<LF>");
        }
        private static void ProcessEndingBalance(StreamWriter writer, DataTable header, DataTable language)
        {
            writer.WriteLine("<!D>");
            writer.WriteLine(string.Format("<B>{0,-32}{1,16:$#,##0.00}</B>",
                                           language.Rows[0]["TotalPaymentDue"],
                                           header.Rows[0]["EndingBalance"]));
            writer.WriteLine("<LF>");
        }

        private static void ProcessPinDebit(StreamWriter writer, DataTable wires, DataTable language)
        {
            var grp = wires.AsEnumerable().GroupBy(c => c.Field<DateTime>("TransactionDate")).Select(s => new
                {
                    tranDate = s.Key,
                    qtyPinDebit = s.Where(p => p.Field<string>("Type") == "PY").Count(),
                    amtPinDebit = -1*s.Where(p => p.Field<string>("Type") == "PY").Sum(p => p.Field<decimal>("ActivityBalance"))
                });

            if (grp.Where(p => p.qtyPinDebit > 0).Count() > 0)
            {
                writer.WriteLine(string.Format("<B>{0}</B>", language.Rows[0]["DebitPaymentChart"].ToString().ToUpper()));
                writer.WriteLine("<!D>");

                foreach (var elem in grp)
                {
                    writer.WriteLine(string.Format("<B>{0,-22}{1,-15}{2,11:$#,##0.00}</B>",
                                                           elem.tranDate.ToString("MM/dd/yy"),
                                                           elem.qtyPinDebit,
                                                           elem.amtPinDebit
                                                  ));
                }
                writer.WriteLine("<!D>");
                writer.WriteLine("<LF>");
            }
           
        }

        #endregion

        #region publics

        public static InvoiceResultStream InvoiceToStreamPDF(InvoiceParameters param)
        {
          //  log.Info("ToolInvoice. Stream To PDF");
            RptInvoiceMain report = new RptInvoiceMain();
            return ReportToStreamPDF(report, param);
        }

        public static InvoiceResultStream InvoiceToStreamXLSX(InvoiceParameters param)
        {
            RptInvoiceMain report = new RptInvoiceMain();
            return ReportToStreamXLSX(report, param);
        }

        public static InvoiceResultStream InvoiceToStreamPDFSmall(InvoiceParameters param)
        {
            var report = new CompanyRptInvoiceSm();
            return ReportToStreamPDF(report, param);
        }

        public static InvoiceResultStream InvoiceToStreamPRNX(InvoiceParameters param)
        {
           RptInvoiceMain report = new RptInvoiceMain();
           return ReportToStreamPRNX(report, param);
         
        }

        public static InvoiceResult OneInvoiceToPDFFile(InvoiceParameters param, string fpath)
        {
            InvoiceResult result = new InvoiceResult();
            RptCompanyInvoice report = new RptCompanyInvoice();

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
                        log.ErrorFormat("InvoiceToPDFFile ERROR: {0}",ex.Message);
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
      
        public static InvoiceResultStream OneInvoiceToStreamPDF(InvoiceParameters param)
        {
            RptCompanyInvoice report = new RptCompanyInvoice();
            return ReportToStreamPDF(report, param);
        }

        public static InvoiceResultStream InvoiceToStreamPNG(InvoiceParameters param)
        {
          RptInvoiceMain report = new RptInvoiceMain();
          return ReportToStreamPNG(report, param);
        }

        public static InvoiceResultStream InvoiceToStreamHTML(InvoiceParameters param)
        {
            RptInvoiceMain report = new RptInvoiceMain();
            return ReportToStreamHTML(report, param);
        }

        public static InvoiceResultStream InvoiceToStreamTXTSmall(InvoiceParameters param)
        {
            string val = "";
            string statementID = string.Empty;
            int languageId = 0;

            InvoiceResultStream rs = new InvoiceResultStream();

            if (param.parameters.TryGetValue("StatementId", out val))
            {
                if (val != null)
                    statementID = val;
            }
            if (string.IsNullOrEmpty(statementID))
            {
                rs.SetMessages(ErrorResult.MissingReportParameter, "StatementId");
                log.ErrorFormat("Missing Parameter {0}", "StatementId");
                return rs;
            }

            if (param.parameters.TryGetValue("LanguageId", out val))
            {
                if (val != null)
                    languageId = Convert.ToInt32(val);
            }

            if (languageId < 1)
            {
                rs.SetMessages(ErrorResult.MissingReportParameter, "LanguageId");
                log.ErrorFormat("Missing Parameter {0}", "LanguageId");
                return rs;
            }
            else if (languageId > 2)
            {
                rs.SetMessages(ErrorResult.InvalidReportParameter, "LanguageId");
                log.ErrorFormat("Invalid Parameter {0}", "LanguageId");
                return rs;
            }
               

            Encoding encoding = Encoding.GetEncoding("utf-8");

            using (var memoryStream = new MemoryStream())
            using (var writer = new StreamWriter(memoryStream, encoding))
            {
                DAStatement st = new DAStatement();

                DataTable header = st.InvoiceHeader(statementID);
                DataTable payments = st.InvoicePayments(statementID);
                DataTable cancellations = st.InvoiceCancellations(statementID);
                DataTable others = st.InvoiceOther(statementID);
                DataTable wires = st.InvoiceWires(statementID);
                DataTable inTransit = st.InvoiceInTransit(statementID, languageId);
                DataTable billPayments = st.InvoiceBillPayment(statementID);

                DataTable language = new DAMultiLanguage().ReportMultiLanguage("REPORT.ACCOUNTING.NEWINVOICE", languageId);

                ProcessHeader(writer, header, language);

                ProcessTotalValues(writer, header, wires, payments, others, cancellations, billPayments,language);

                ProcessPayments(writer, payments, language);

                ProcessOthers(writer, others, language);

                ProcessCancellations(writer, cancellations, language);

                ProcessWires(writer, wires, language);

                ProcessBillPayments(writer, billPayments, language);

                ProcessEndingBalance(writer, header, language);

               // ProcessNote(writer, language);

                ProcessIntransit(writer, language, inTransit); 
                
                ProcessCommission(writer, header, wires, language);

                ProcessPinDebit(writer, wires, language);

                ProcessFaxStatement(writer, header);

                ProcessEndNote(writer, language, header);

                writer.WriteLine("<PCUT>");
                writer.Flush();
                memoryStream.Position = 0;
                rs.StreamInfo = memoryStream.ToArray();
                return rs;
            }
         

        }

        public static InvoiceResultStream InvoiceToStreamHTMLSmall(InvoiceParameters param)
        {
            RptInvoiceSm report = new RptInvoiceSm();
            return ReportToStreamHTML(report, param);
        }
        #endregion
    }

    public static class StringExtensions
    {
        public static string[] Split(this string value, int position)
        {
            List<string> result = new List<string>();
            string temp = value.Trim();

            int i = 0;
            while (position-1 < temp.Length)
            {
                string s = temp.Substring(0, position-1);
                if (s.LastIndexOf(' ') > 0)
                    s = s.Substring(0, s.LastIndexOf(' '));
                result.Add(s.Trim());
                temp = temp.Substring(s.Length + 1, temp.Length - s.Length - 1).Trim();
                i++;
            }
            if (!string.IsNullOrWhiteSpace(temp) )
            {
                result.Add(temp);
            }
            return result.ToArray<string>();
        }

    }
}
