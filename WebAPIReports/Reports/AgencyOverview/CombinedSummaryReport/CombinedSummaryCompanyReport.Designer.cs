namespace WebAPIReports.Reports.AgencyOverview
{
    partial class CombinedSummaryCompanyReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CombinedSummaryCompanyReport));
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter5 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter6 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter7 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter8 = new DevExpress.DataAccess.Sql.QueryParameter();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.SubBand2 = new DevExpress.XtraReports.UI.SubBand();
            this.xrSubreportWires = new DevExpress.XtraReports.UI.XRSubreport();
            this.LanguageId = new DevExpress.XtraReports.Parameters.Parameter();
            this.FDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.TDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.CreatedBy = new DevExpress.XtraReports.Parameters.Parameter();
            this.AllowViewCommissions = new DevExpress.XtraReports.Parameters.Parameter();
            this.SubBand3 = new DevExpress.XtraReports.UI.SubBand();
            this.xrSubreportMO = new DevExpress.XtraReports.UI.XRSubreport();
            this.SubBand4 = new DevExpress.XtraReports.UI.SubBand();
            this.xrSubreportChecks = new DevExpress.XtraReports.UI.XRSubreport();
            this.SubBand5 = new DevExpress.XtraReports.UI.SubBand();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrSubreportBillPayment = new DevExpress.XtraReports.UI.XRSubreport();
            this.AgencyCode = new DevExpress.XtraReports.Parameters.Parameter();
            this.FormName = new DevExpress.XtraReports.Parameters.Parameter();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.CalcHeaderInfo = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcInfoHeader = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcLegalEntiyInfo = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcAgInfoOwner = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcAgInfo = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcTotalPaymentAmount = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcPaymentLabel = new DevExpress.XtraReports.UI.CalculatedField();
            this.calculatedField1 = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcOtherLabel = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcCancellationLabel = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcWireSentLabel = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcAgPhone = new DevExpress.XtraReports.UI.CalculatedField();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.CalcCommiPaymentMethod = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcTrimPayment = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcTrimOther = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcTrimCancellations = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcNote = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcAgFax = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcAgPhoneLabel = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcTrimBP = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcSeqNo = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcService = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcStCurrency = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcDebitCard = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcTransact = new DevExpress.XtraReports.UI.CalculatedField();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrCompanyHeader = new DevExpress.XtraReports.UI.XRSubreport();
            this.IncludeAgencyGroup = new DevExpress.XtraReports.Parameters.Parameter();
            this.DataSourceCombined = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrSubreportFooterCustom = new DevExpress.XtraReports.UI.XRSubreport();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.BorderWidth = 6F;
            this.Detail.HeightF = 0F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("AgencyCode", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.Detail.StylePriority.UseBorderWidth = false;
            this.Detail.StylePriority.UsePadding = false;
            this.Detail.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand2,
            this.SubBand3,
            this.SubBand4,
            this.SubBand5});
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // SubBand2
            // 
            this.SubBand2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreportWires});
            this.SubBand2.HeightF = 14.29164F;
            this.SubBand2.Name = "SubBand2";
            // 
            // xrSubreportWires
            // 
            this.xrSubreportWires.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrSubreportWires.Name = "xrSubreportWires";
            this.xrSubreportWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LanguageId", this.LanguageId));
            this.xrSubreportWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgSenderCode", null, "Combined_Report_Header.AgencyCode"));
            this.xrSubreportWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FDate", this.FDate));
            this.xrSubreportWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("TDate", this.TDate));
            this.xrSubreportWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("UserName", this.CreatedBy));
            this.xrSubreportWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AllowViewCommissions", this.AllowViewCommissions));
            this.xrSubreportWires.ReportSource = new WebAPIReports.Reports.AgencyOverview.CombinedSummaryReportWires();
            this.xrSubreportWires.SizeF = new System.Drawing.SizeF(830F, 14.29164F);
            // 
            // LanguageId
            // 
            this.LanguageId.Name = "LanguageId";
            this.LanguageId.Type = typeof(int);
            this.LanguageId.ValueInfo = "1";
            // 
            // FDate
            // 
            this.FDate.Name = "FDate";
            this.FDate.Type = typeof(System.DateTime);
            this.FDate.ValueInfo = "2021-11-10";
            // 
            // TDate
            // 
            this.TDate.Name = "TDate";
            this.TDate.Type = typeof(System.DateTime);
            this.TDate.ValueInfo = "2021-11-25";
            // 
            // CreatedBy
            // 
            this.CreatedBy.Name = "CreatedBy";
            // 
            // AllowViewCommissions
            // 
            this.AllowViewCommissions.Description = "Allow View Commissions";
            this.AllowViewCommissions.Name = "AllowViewCommissions";
            this.AllowViewCommissions.Type = typeof(bool);
            this.AllowViewCommissions.ValueInfo = "False";
            // 
            // SubBand3
            // 
            this.SubBand3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreportMO});
            this.SubBand3.HeightF = 14.29164F;
            this.SubBand3.KeepTogether = true;
            this.SubBand3.Name = "SubBand3";
            // 
            // xrSubreportMO
            // 
            this.xrSubreportMO.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrSubreportMO.Name = "xrSubreportMO";
            this.xrSubreportMO.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LanguageId", this.LanguageId));
            this.xrSubreportMO.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgencyCode", null, "Combined_Report_Header.AgencyCode"));
            this.xrSubreportMO.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FromDate", this.FDate));
            this.xrSubreportMO.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("ToDate", this.TDate));
            this.xrSubreportMO.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("UserName", this.CreatedBy));
            this.xrSubreportMO.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AllowViewCommissions", this.AllowViewCommissions));
            this.xrSubreportMO.ReportSource = new WebAPIReports.Reports.AgencyOverview.CombinedSummaryReportMO();
            this.xrSubreportMO.SizeF = new System.Drawing.SizeF(830F, 14.29164F);
            // 
            // SubBand4
            // 
            this.SubBand4.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreportChecks});
            this.SubBand4.HeightF = 14.29164F;
            this.SubBand4.KeepTogether = true;
            this.SubBand4.Name = "SubBand4";
            // 
            // xrSubreportChecks
            // 
            this.xrSubreportChecks.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrSubreportChecks.Name = "xrSubreportChecks";
            this.xrSubreportChecks.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgencyCode", null, "Combined_Report_Header.AgencyCode"));
            this.xrSubreportChecks.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("UserName", this.CreatedBy));
            this.xrSubreportChecks.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("CheckFromDate", this.FDate));
            this.xrSubreportChecks.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("CheckToDate", this.TDate));
            this.xrSubreportChecks.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LanguageId", this.LanguageId));
            this.xrSubreportChecks.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AllowViewCommissions", this.AllowViewCommissions));
            this.xrSubreportChecks.ReportSource = new WebAPIReports.Reports.AgencyOverview.CombinedSummaryReportChecks();
            this.xrSubreportChecks.SizeF = new System.Drawing.SizeF(830F, 14.29164F);
            // 
            // SubBand5
            // 
            this.SubBand5.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel5,
            this.xrSubreportBillPayment});
            this.SubBand5.HeightF = 71.20336F;
            this.SubBand5.KeepTogether = true;
            this.SubBand5.Name = "SubBand5";
            // 
            // xrLabel5
            // 
            this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif([HasData] = 0, [ConvertRowsInColumns_MultiLangLabels].[EmptyLeyend], \'\')")});
            this.xrLabel5.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 14.29164F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(830F, 15.58F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UsePadding = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrSubreportBillPayment
            // 
            this.xrSubreportBillPayment.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrSubreportBillPayment.Name = "xrSubreportBillPayment";
            this.xrSubreportBillPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgSenderCode", null, "Combined_Report_Header.AgencyCode"));
            this.xrSubreportBillPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FDate", this.FDate));
            this.xrSubreportBillPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("TDate", this.TDate));
            this.xrSubreportBillPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("UserName", this.CreatedBy));
            this.xrSubreportBillPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LanguageId", this.LanguageId));
            this.xrSubreportBillPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AllowViewCommissions", this.AllowViewCommissions));
            this.xrSubreportBillPayment.ReportSource = new WebAPIReports.Reports.AgencyOverview.CombinedSummaryReportBillPayments();
            this.xrSubreportBillPayment.SizeF = new System.Drawing.SizeF(830F, 14.29164F);
            // 
            // AgencyCode
            // 
            this.AgencyCode.Name = "AgencyCode";
            this.AgencyCode.ValueInfo = "FL1000";
            // 
            // FormName
            // 
            this.FormName.Name = "FormName";
            this.FormName.ValueInfo = "REPORT.IMXDIRECT.COMBINED";
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 10F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.BorderWidth = 0F;
            this.BottomMargin.HeightF = 10F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.SnapLinePadding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.StylePriority.UseBorderWidth = false;
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Text = "xrTableCell1";
            this.xrTableCell1.Weight = 1D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Text = "xrTableCell2";
            this.xrTableCell2.Weight = 1D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Text = "xrTableCell3";
            this.xrTableCell3.Weight = 1D;
            // 
            // CalcHeaderInfo
            // 
            this.CalcHeaderInfo.DataMember = "Acc_Invoice_Header(@StatementId)";
            this.CalcHeaderInfo.Expression = "Iif([AgLanguageId] == 1,\'Please send your deposit receipt to:\',\'Favor de enviar s" +
    "u recibo de deposito a:\')";
            this.CalcHeaderInfo.Name = "CalcHeaderInfo";
            // 
            // CalcInfoHeader
            // 
            this.CalcInfoHeader.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcInfoHeader.Expression = null;
            this.CalcInfoHeader.Name = "CalcInfoHeader";
            // 
            // CalcLegalEntiyInfo
            // 
            this.CalcLegalEntiyInfo.DataMember = "Acc_Invoice_Header(@StatementId)";
            this.CalcLegalEntiyInfo.Expression = "[LegalEntityOfficialName]\n+Char(13)\n+ [LegalEntityAddress]\n+ Char(13)\n+ [LECity] " +
    "+ \', \' + [LEState] + \' \' + [LEZip]";
            this.CalcLegalEntiyInfo.Name = "CalcLegalEntiyInfo";
            // 
            // CalcAgInfoOwner
            // 
            this.CalcAgInfoOwner.DataMember = "Acc_Invoice_Header(@StatementId)";
            this.CalcAgInfoOwner.Expression = "Trim([AgencyCode]) + \' / \' + [Agname]\n+ Char(13)\n+ \'Mr(s.) \' + Trim([AgOwnerFirst" +
    "Name]) + \' \' + Trim([AgOwnerLastName])";
            this.CalcAgInfoOwner.Name = "CalcAgInfoOwner";
            // 
            // CalcAgInfo
            // 
            this.CalcAgInfo.DataMember = "Acc_Invoice_Header(@StatementId)";
            this.CalcAgInfo.Expression = "[AgAddress] + \' \'\n+ [AgAddress2]\n+ Char(13)\n+ [AgCity] + \', \' + [AgStateAbbr] + \'" +
    " \' + [AgZip]";
            this.CalcAgInfo.Name = "CalcAgInfo";
            // 
            // CalcTotalPaymentAmount
            // 
            this.CalcTotalPaymentAmount.DataMember = "Acc_Invoice_Payments";
            this.CalcTotalPaymentAmount.Expression = "Sum([Amount])";
            this.CalcTotalPaymentAmount.Name = "CalcTotalPaymentAmount";
            this.CalcTotalPaymentAmount.Scripts.OnGetValue = "CalcTotalPaymentAmount_GetValue";
            // 
            // CalcPaymentLabel
            // 
            this.CalcPaymentLabel.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcPaymentLabel.Expression = "Upper([Payments])";
            this.CalcPaymentLabel.Name = "CalcPaymentLabel";
            // 
            // calculatedField1
            // 
            this.calculatedField1.DataMember = "Acc_Invoice_OtherCreditsDebits";
            this.calculatedField1.DisplayName = "CalcAmountDC";
            this.calculatedField1.Expression = "Sum([Amount])";
            this.calculatedField1.Name = "calculatedField1";
            // 
            // CalcOtherLabel
            // 
            this.CalcOtherLabel.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcOtherLabel.DisplayName = "CalcOtherLabel";
            this.CalcOtherLabel.Expression = "Upper([OtherDebitCredit])";
            this.CalcOtherLabel.Name = "CalcOtherLabel";
            // 
            // CalcCancellationLabel
            // 
            this.CalcCancellationLabel.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcCancellationLabel.DisplayName = "CalcCancellationLabel";
            this.CalcCancellationLabel.Expression = "Upper([Cancellations])";
            this.CalcCancellationLabel.Name = "CalcCancellationLabel";
            // 
            // CalcWireSentLabel
            // 
            this.CalcWireSentLabel.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcWireSentLabel.DisplayName = "CalcWireSentLabel";
            this.CalcWireSentLabel.Expression = "Upper([WireTransfers])";
            this.CalcWireSentLabel.Name = "CalcWireSentLabel";
            // 
            // CalcAgPhone
            // 
            this.CalcAgPhone.DataMember = "Acc_Invoice_Header(@StatementId)";
            this.CalcAgPhone.Expression = " Iif(not IsNullOrEmpty([AgPhone1]),\n           Iif(Len(Trim([AgPhone1])) <= 10, \n" +
    "\t\t ToLong(Trim([AgPhone1])), \t\t\t\t\t  \t\t ToLong(Substring(Trim([AgPhone1]),0  ,9 )" +
    ")\n\t\t) ,\'\')";
            this.CalcAgPhone.Name = "CalcAgPhone";
            // 
            // ReportFooter
            // 
            this.ReportFooter.HeightF = 0F;
            this.ReportFooter.KeepTogether = true;
            this.ReportFooter.Name = "ReportFooter";
            this.ReportFooter.PrintAtBottom = true;
            this.ReportFooter.SnapLinePadding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            // 
            // CalcCommiPaymentMethod
            // 
            this.CalcCommiPaymentMethod.DataMember = "Acc_Invoice_Header(@StatementId)";
            this.CalcCommiPaymentMethod.Name = "CalcCommiPaymentMethod";
            // 
            // CalcTrimPayment
            // 
            this.CalcTrimPayment.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcTrimPayment.Expression = "Trim([Payments])";
            this.CalcTrimPayment.Name = "CalcTrimPayment";
            // 
            // CalcTrimOther
            // 
            this.CalcTrimOther.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcTrimOther.Expression = "Trim([OtherDebitCredit])";
            this.CalcTrimOther.Name = "CalcTrimOther";
            // 
            // CalcTrimCancellations
            // 
            this.CalcTrimCancellations.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcTrimCancellations.Expression = "Trim([Cancellations])";
            this.CalcTrimCancellations.Name = "CalcTrimCancellations";
            // 
            // CalcNote
            // 
            this.CalcNote.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcNote.Expression = resources.GetString("CalcNote.Expression");
            this.CalcNote.Name = "CalcNote";
            // 
            // CalcAgFax
            // 
            this.CalcAgFax.DataMember = "Acc_Invoice_Header(@StatementId)";
            this.CalcAgFax.Expression = " Iif(not IsNullOrEmpty([AgFax1]),\n           Iif(Len(Trim([AgFax1])) <= 10, \n\t\t T" +
    "oLong(Trim([AgFax1])), \t\t\t\t\t  \t\t ToLong(Substring(Trim([AgFax1]),0  ,9 ))\n\t\t) ,\'" +
    "\')";
            this.CalcAgFax.Name = "CalcAgFax";
            // 
            // CalcAgPhoneLabel
            // 
            this.CalcAgPhoneLabel.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcAgPhoneLabel.Expression = "[phoneInvoice] + \':\'";
            this.CalcAgPhoneLabel.Name = "CalcAgPhoneLabel";
            // 
            // CalcTrimBP
            // 
            this.CalcTrimBP.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcTrimBP.Expression = "Trim([BillPayment])";
            this.CalcTrimBP.Name = "CalcTrimBP";
            // 
            // CalcSeqNo
            // 
            this.CalcSeqNo.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcSeqNo.Expression = "Trim([SeqNo])";
            this.CalcSeqNo.Name = "CalcSeqNo";
            // 
            // CalcService
            // 
            this.CalcService.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcService.Expression = "Trim([ServiceType])";
            this.CalcService.Name = "CalcService";
            // 
            // CalcStCurrency
            // 
            this.CalcStCurrency.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcStCurrency.Expression = "[Currency]";
            this.CalcStCurrency.Name = "CalcStCurrency";
            // 
            // CalcDebitCard
            // 
            this.CalcDebitCard.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcDebitCard.Expression = "Trim([DebitCard])";
            this.CalcDebitCard.Name = "CalcDebitCard";
            // 
            // CalcTransact
            // 
            this.CalcTransact.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcTransact.Expression = "Trim([Transaction])";
            this.CalcTransact.Name = "CalcTransact";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCompanyHeader});
            this.ReportHeader.HeightF = 29.16667F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrCompanyHeader
            // 
            this.xrCompanyHeader.LocationFloat = new DevExpress.Utils.PointFloat(0F, 1.000007F);
            this.xrCompanyHeader.Name = "xrCompanyHeader";
            this.xrCompanyHeader.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FDate", this.FDate));
            this.xrCompanyHeader.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("TDate", this.TDate));
            this.xrCompanyHeader.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FormName", this.FormName));
            this.xrCompanyHeader.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LanguageId", this.LanguageId));
            this.xrCompanyHeader.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("ReportTitle", null, "ConvertRowsInColumns_MultiLangLabels.CombinedReportTitle"));
            this.xrCompanyHeader.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgSenderCode", this.AgencyCode));
            this.xrCompanyHeader.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgencyName", null, "Combined_Report_Header.Agname"));
            this.xrCompanyHeader.ReportSource = new WebAPIReports.Reports.Common.CustomHeader.CompanyAgencyReportHeader();
            this.xrCompanyHeader.SizeF = new System.Drawing.SizeF(830F, 25.99999F);
            // 
            // IncludeAgencyGroup
            // 
            this.IncludeAgencyGroup.Description = "IncludeAgencyGroup";
            this.IncludeAgencyGroup.Name = "IncludeAgencyGroup";
            this.IncludeAgencyGroup.Type = typeof(bool);
            this.IncludeAgencyGroup.ValueInfo = "False";
            // 
            // DataSourceCombined
            // 
            this.DataSourceCombined.ConnectionName = "WireTransacConn";
            this.DataSourceCombined.Name = "DataSourceCombined";
            storedProcQuery1.Name = "ConvertRowsInColumns_MultiLangLabels";
            queryParameter1.Name = "@LanguageId";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.LanguageId]", typeof(int));
            queryParameter2.Name = "@FormName";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.FormName]", typeof(string));
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.Parameters.Add(queryParameter2);
            storedProcQuery1.StoredProcName = "ConvertRowsInColumns_MultiLangLabels";
            storedProcQuery2.Name = "Combined_Report_Header";
            queryParameter3.Name = "@AgencyCode";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("[Parameters.AgencyCode]", typeof(string));
            queryParameter4.Name = "@IncludeAgencyGroup";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("[Parameters.IncludeAgencyGroup]", typeof(bool));
            queryParameter5.Name = "@FDate";
            queryParameter5.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter5.Value = new DevExpress.DataAccess.Expression("[Parameters.FDate]", typeof(System.DateTime));
            queryParameter6.Name = "@TDate";
            queryParameter6.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter6.Value = new DevExpress.DataAccess.Expression("[Parameters.TDate]", typeof(System.DateTime));
            queryParameter7.Name = "@CreatedBy";
            queryParameter7.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter7.Value = new DevExpress.DataAccess.Expression("[Parameters.CreatedBy]", typeof(string));
            queryParameter8.Name = "@IncludeVoid";
            queryParameter8.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter8.Value = new DevExpress.DataAccess.Expression("True", typeof(bool));
            storedProcQuery2.Parameters.Add(queryParameter3);
            storedProcQuery2.Parameters.Add(queryParameter4);
            storedProcQuery2.Parameters.Add(queryParameter5);
            storedProcQuery2.Parameters.Add(queryParameter6);
            storedProcQuery2.Parameters.Add(queryParameter7);
            storedProcQuery2.Parameters.Add(queryParameter8);
            storedProcQuery2.StoredProcName = "Combined_Report_Header";
            this.DataSourceCombined.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1,
            storedProcQuery2});
            this.DataSourceCombined.ResultSchemaSerializable = resources.GetString("DataSourceCombined.ResultSchemaSerializable");
            this.DataSourceCombined.ConfigureDataConnection += new DevExpress.DataAccess.Sql.ConfigureDataConnectionEventHandler(this.DataSourceCombined_ConfigureDataConnection);
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreportFooterCustom});
            this.PageFooter.HeightF = 28.125F;
            this.PageFooter.Name = "PageFooter";
            // 
            // xrSubreportFooterCustom
            // 
            this.xrSubreportFooterCustom.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrSubreportFooterCustom.Name = "xrSubreportFooterCustom";
            this.xrSubreportFooterCustom.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LanguageId", this.LanguageId));
            this.xrSubreportFooterCustom.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgSenderCode", null, "Combined_Report_Header.AgencyCode"));
            this.xrSubreportFooterCustom.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FormName", this.FormName));
            this.xrSubreportFooterCustom.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("ReportTitle", null, "ConvertRowsInColumns_MultiLangLabels.CombinedReportTitle"));
            this.xrSubreportFooterCustom.ReportSource = new WebAPIReports.Reports.Common.CustomHeader.CompanyAgencyReportFooter();
            this.xrSubreportFooterCustom.SizeF = new System.Drawing.SizeF(829.9999F, 23F);
            // 
            // CombinedSummaryCompanyReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportFooter,
            this.ReportHeader,
            this.PageFooter});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.CalcHeaderInfo,
            this.CalcInfoHeader,
            this.CalcLegalEntiyInfo,
            this.CalcAgInfoOwner,
            this.CalcAgInfo,
            this.CalcTotalPaymentAmount,
            this.CalcPaymentLabel,
            this.calculatedField1,
            this.CalcOtherLabel,
            this.CalcCancellationLabel,
            this.CalcWireSentLabel,
            this.CalcAgPhone,
            this.CalcCommiPaymentMethod,
            this.CalcTrimPayment,
            this.CalcTrimOther,
            this.CalcTrimCancellations,
            this.CalcNote,
            this.CalcAgFax,
            this.CalcAgPhoneLabel,
            this.CalcTrimBP,
            this.CalcSeqNo,
            this.CalcService,
            this.CalcStCurrency,
            this.CalcDebitCard,
            this.CalcTransact});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.DataSourceCombined});
            this.DataMember = "Combined_Report_Header";
            this.DataSource = this.DataSourceCombined;
            this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margins = new System.Drawing.Printing.Margins(10, 10, 10, 10);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.AgencyCode,
            this.FDate,
            this.TDate,
            this.CreatedBy,
            this.FormName,
            this.LanguageId,
            this.IncludeAgencyGroup,
            this.AllowViewCommissions});
            this.ShowPrintMarginsWarning = false;
            this.Version = "18.1";
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.CombinedSummaryReport_DataSourceDemanded);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.CalculatedField CalcHeaderInfo;
        private DevExpress.XtraReports.Parameters.Parameter LanguageId;
        private DevExpress.XtraReports.Parameters.Parameter FormName;
        private DevExpress.XtraReports.UI.CalculatedField CalcInfoHeader;
        private DevExpress.XtraReports.UI.CalculatedField CalcLegalEntiyInfo;
        private DevExpress.XtraReports.UI.CalculatedField CalcAgInfoOwner;
        private DevExpress.XtraReports.UI.CalculatedField CalcAgInfo;
        private DevExpress.XtraReports.UI.CalculatedField CalcTotalPaymentAmount;
        private DevExpress.XtraReports.UI.CalculatedField CalcPaymentLabel;
        private DevExpress.XtraReports.UI.CalculatedField calculatedField1;
        private DevExpress.XtraReports.UI.CalculatedField CalcOtherLabel;
        private DevExpress.XtraReports.UI.CalculatedField CalcCancellationLabel;
        private DevExpress.XtraReports.UI.CalculatedField CalcWireSentLabel;
        private DevExpress.XtraReports.UI.CalculatedField CalcAgPhone;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.CalculatedField CalcCommiPaymentMethod;
        private DevExpress.XtraReports.UI.CalculatedField CalcTrimPayment;
        private DevExpress.XtraReports.UI.CalculatedField CalcTrimOther;
        private DevExpress.XtraReports.UI.CalculatedField CalcTrimCancellations;
        private DevExpress.XtraReports.UI.CalculatedField CalcNote;
        private DevExpress.XtraReports.UI.CalculatedField CalcAgFax;
        private DevExpress.XtraReports.UI.CalculatedField CalcAgPhoneLabel;
        private DevExpress.XtraReports.UI.CalculatedField CalcTrimBP;
        private DevExpress.XtraReports.UI.CalculatedField CalcSeqNo;
        private DevExpress.XtraReports.UI.CalculatedField CalcService;
        private DevExpress.XtraReports.UI.CalculatedField CalcStCurrency;
        private DevExpress.XtraReports.UI.CalculatedField CalcDebitCard;
        private DevExpress.XtraReports.UI.CalculatedField CalcTransact;
        private DevExpress.XtraReports.Parameters.Parameter AgencyCode;
        private DevExpress.XtraReports.Parameters.Parameter FDate;
        private DevExpress.XtraReports.Parameters.Parameter TDate;
        private DevExpress.XtraReports.Parameters.Parameter CreatedBy;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreportWires;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreportMO;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreportChecks;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreportBillPayment;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.Parameters.Parameter IncludeAgencyGroup;
        private DevExpress.DataAccess.Sql.SqlDataSource DataSourceCombined;
        private DevExpress.XtraReports.UI.SubBand SubBand2;
        private DevExpress.XtraReports.UI.SubBand SubBand3;
        private DevExpress.XtraReports.UI.SubBand SubBand4;
        private DevExpress.XtraReports.UI.SubBand SubBand5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.Parameters.Parameter AllowViewCommissions;
        private DevExpress.XtraReports.UI.XRSubreport xrCompanyHeader;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreportFooterCustom;
    }
}
