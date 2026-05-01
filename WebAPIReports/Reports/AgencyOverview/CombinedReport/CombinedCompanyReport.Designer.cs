namespace WebAPIReports.Reports.AgencyOverview
{
    partial class CombinedCompanyReport
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
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter5 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter6 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter7 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter8 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery3 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter9 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery4 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter10 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CombinedCompanyReport));
            this.DataSourceCombined = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrSubreportSummary = new DevExpress.XtraReports.UI.XRSubreport();
            this.FDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.TDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.FormName = new DevExpress.XtraReports.Parameters.Parameter();
            this.LanguageId = new DevExpress.XtraReports.Parameters.Parameter();
            this.AllowViewCommissions = new DevExpress.XtraReports.Parameters.Parameter();
            this.Empty = new DevExpress.XtraReports.UI.XRLabel();
            this.xrSubreportBillPayment = new DevExpress.XtraReports.UI.XRSubreport();
            this.CreatedBy = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrSubreportChecks = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrSubreportMO = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrSubreportWires = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrSubreportGraphic = new DevExpress.XtraReports.UI.XRSubreport();
            this.AgencyCode = new DevExpress.XtraReports.Parameters.Parameter();
            this.IncludeAgencyGroup = new DevExpress.XtraReports.Parameters.Parameter();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
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
            this.xrSubreporHeaderCustom = new DevExpress.XtraReports.UI.XRSubreport();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrSubreportFooterCustom = new DevExpress.XtraReports.UI.XRSubreport();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // DataSourceCombined
            // 
            this.DataSourceCombined.ConnectionName = "WireTransacConn";
            this.DataSourceCombined.Name = "DataSourceCombined";
            storedProcQuery1.Name = "Combined_Report_Header";
            queryParameter1.Name = "@AgencyCode";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.AgencyCode]", typeof(string));
            queryParameter2.Name = "@IncludeAgencyGroup";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.IncludeAgencyGroup]", typeof(bool));
            queryParameter3.Name = "@FDate";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("[Parameters.FDate]", typeof(System.DateTime));
            queryParameter4.Name = "@TDate";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("[Parameters.TDate]", typeof(System.DateTime));
            queryParameter5.Name = "@CreatedBy";
            queryParameter5.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter5.Value = new DevExpress.DataAccess.Expression("[Parameters.CreatedBy]", typeof(string));
            queryParameter6.Name = "@IncludeVoid";
            queryParameter6.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter6.Value = new DevExpress.DataAccess.Expression("1", typeof(bool));
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.Parameters.Add(queryParameter2);
            storedProcQuery1.Parameters.Add(queryParameter3);
            storedProcQuery1.Parameters.Add(queryParameter4);
            storedProcQuery1.Parameters.Add(queryParameter5);
            storedProcQuery1.Parameters.Add(queryParameter6);
            storedProcQuery1.StoredProcName = "Combined_Report_Header";
            storedProcQuery2.Name = "ConvertRowsInColumns_MultiLangLabels";
            queryParameter7.Name = "@LanguageId";
            queryParameter7.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter7.Value = new DevExpress.DataAccess.Expression("[Parameters.LanguageId]", typeof(int));
            queryParameter8.Name = "@FormName";
            queryParameter8.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter8.Value = new DevExpress.DataAccess.Expression("[Parameters.FormName]", typeof(string));
            storedProcQuery2.Parameters.Add(queryParameter7);
            storedProcQuery2.Parameters.Add(queryParameter8);
            storedProcQuery2.StoredProcName = "ConvertRowsInColumns_MultiLangLabels";
            storedProcQuery3.Name = "Combined_Report_Header_Logo";
            queryParameter9.Name = "@AgencyCode";
            queryParameter9.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter9.Value = new DevExpress.DataAccess.Expression("[Parameters.AgencyCode]", typeof(string));
            storedProcQuery3.Parameters.Add(queryParameter9);
            storedProcQuery3.StoredProcName = "Combined_Report_Header_Logo";
            storedProcQuery4.Name = "GetAgencyCompanyInfo";
            queryParameter10.Name = "@AgencyCode";
            queryParameter10.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter10.Value = new DevExpress.DataAccess.Expression("[Parameters.AgencyCode]", typeof(string));
            storedProcQuery4.Parameters.Add(queryParameter10);
            storedProcQuery4.StoredProcName = "GetAgencyCompanyInfo";
            this.DataSourceCombined.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1,
            storedProcQuery2,
            storedProcQuery3,
            storedProcQuery4});
            this.DataSourceCombined.ResultSchemaSerializable = resources.GetString("DataSourceCombined.ResultSchemaSerializable");
            this.DataSourceCombined.ConfigureDataConnection += new DevExpress.DataAccess.Sql.ConfigureDataConnectionEventHandler(this.DataSourceCombined_ConfigureDataConnection);
            // 
            // Detail
            // 
            this.Detail.BorderWidth = 6F;
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreportSummary,
            this.Empty,
            this.xrSubreportBillPayment,
            this.xrSubreportChecks,
            this.xrSubreportMO,
            this.xrSubreportWires,
            this.xrSubreportGraphic});
            this.Detail.Font = new System.Drawing.Font(ReportCommon.Font, 10F);
            this.Detail.HeightF = 320.6112F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("AgencyCode", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.Detail.StylePriority.UseBorderWidth = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrSubreportSummary
            // 
            this.xrSubreportSummary.CanShrink = true;
            this.xrSubreportSummary.LocationFloat = new DevExpress.Utils.PointFloat(100F, 10.00001F);
            this.xrSubreportSummary.Name = "xrSubreportSummary";
            this.xrSubreportSummary.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgSenderCode", null, "Combined_Report_Header.AgencyCode"));
            this.xrSubreportSummary.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FDate", this.FDate));
            this.xrSubreportSummary.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("TDate", this.TDate));
            this.xrSubreportSummary.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FormName", this.FormName));
            this.xrSubreportSummary.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LanguageId", this.LanguageId));
            this.xrSubreportSummary.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AllowViewCommissions", this.AllowViewCommissions));
            this.xrSubreportSummary.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("HasData", null, "Combined_Report_Header.HasData"));
            this.xrSubreportSummary.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Color", null, "GetAgencyCompanyInfo.ReportColorForeground"));
            this.xrSubreportSummary.ReportSource = new WebAPIReports.Reports.AgencyOverview.CombinedReportSummary();
            this.xrSubreportSummary.SizeF = new System.Drawing.SizeF(729.9999F, 138.8541F);
            // 
            // FDate
            // 
            this.FDate.Name = "FDate";
            this.FDate.Type = typeof(System.DateTime);
            this.FDate.ValueInfo = "2022-01-10";
            // 
            // TDate
            // 
            this.TDate.Name = "TDate";
            this.TDate.Type = typeof(System.DateTime);
            this.TDate.ValueInfo = "2022-01-20";
            // 
            // FormName
            // 
            this.FormName.Name = "FormName";
            this.FormName.ValueInfo = "REPORT.IMXDIRECT.COMBINED";
            // 
            // LanguageId
            // 
            this.LanguageId.Name = "LanguageId";
            this.LanguageId.Type = typeof(int);
            this.LanguageId.ValueInfo = "1";
            // 
            // AllowViewCommissions
            // 
            this.AllowViewCommissions.Description = "Allow View Commissions";
            this.AllowViewCommissions.Name = "AllowViewCommissions";
            this.AllowViewCommissions.Type = typeof(bool);
            this.AllowViewCommissions.ValueInfo = "False";
            // 
            // Empty
            // 
            this.Empty.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif([Combined_Report_Header].[HasData] = 0, [ConvertRowsInColumns_MultiLangLabels" +
                    "].[EmptyLeyend], \'\')")});
            this.Empty.Font = new System.Drawing.Font(ReportCommon.Font, 12F, System.Drawing.FontStyle.Bold);
            this.Empty.LocationFloat = new DevExpress.Utils.PointFloat(3.973643E-05F, 159.2707F);
            this.Empty.Multiline = true;
            this.Empty.Name = "Empty";
            this.Empty.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.Empty.SizeF = new System.Drawing.SizeF(829.9999F, 15.58336F);
            this.Empty.StylePriority.UseFont = false;
            this.Empty.StylePriority.UseTextAlignment = false;
            this.Empty.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrSubreportBillPayment
            // 
            this.xrSubreportBillPayment.LocationFloat = new DevExpress.Utils.PointFloat(0.0001509984F, 287.2567F);
            this.xrSubreportBillPayment.Name = "xrSubreportBillPayment";
            this.xrSubreportBillPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgSenderCode", null, "Combined_Report_Header.AgencyCode"));
            this.xrSubreportBillPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FDate", this.FDate));
            this.xrSubreportBillPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("TDate", this.TDate));
            this.xrSubreportBillPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("UserName", this.CreatedBy));
            this.xrSubreportBillPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LanguageId", this.LanguageId));
            this.xrSubreportBillPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AllowViewCommissions", this.AllowViewCommissions));
            this.xrSubreportBillPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Color", null, "GetAgencyCompanyInfo.ReportColorForeground"));
            this.xrSubreportBillPayment.ReportSource = new WebAPIReports.Reports.AgencyOverview.CombinedReportBillPayments();
            this.xrSubreportBillPayment.SizeF = new System.Drawing.SizeF(829.9997F, 22.99997F);
            // 
            // CreatedBy
            // 
            this.CreatedBy.Name = "CreatedBy";
            // 
            // xrSubreportChecks
            // 
            this.xrSubreportChecks.LocationFloat = new DevExpress.Utils.PointFloat(0.0001509984F, 253.8402F);
            this.xrSubreportChecks.Name = "xrSubreportChecks";
            this.xrSubreportChecks.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgencyCode", null, "Combined_Report_Header.AgencyCode"));
            this.xrSubreportChecks.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("UserName", this.CreatedBy));
            this.xrSubreportChecks.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("CheckFromDate", this.FDate));
            this.xrSubreportChecks.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("CheckToDate", this.TDate));
            this.xrSubreportChecks.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LanguageId", this.LanguageId));
            this.xrSubreportChecks.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AllowViewCommissions", this.AllowViewCommissions));
            this.xrSubreportChecks.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Color", null, "GetAgencyCompanyInfo.ReportColorForeground"));
            this.xrSubreportChecks.ReportSource = new WebAPIReports.Reports.AgencyOverview.CombinedReportChecks();
            this.xrSubreportChecks.SizeF = new System.Drawing.SizeF(829.9998F, 23.00002F);
            // 
            // xrSubreportMO
            // 
            this.xrSubreportMO.LocationFloat = new DevExpress.Utils.PointFloat(0.0001509984F, 220.0764F);
            this.xrSubreportMO.Name = "xrSubreportMO";
            this.xrSubreportMO.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LanguageId", this.LanguageId));
            this.xrSubreportMO.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgencyCode", null, "Combined_Report_Header.AgencyCode"));
            this.xrSubreportMO.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FromDate", this.FDate));
            this.xrSubreportMO.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("ToDate", this.TDate));
            this.xrSubreportMO.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("UserName", this.CreatedBy));
            this.xrSubreportMO.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AllowViewCommissions", this.AllowViewCommissions));
            this.xrSubreportMO.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Color", null, "GetAgencyCompanyInfo.ReportColorForeground"));
            this.xrSubreportMO.ReportSource = new WebAPIReports.Reports.AgencyOverview.CombinedReportMO();
            this.xrSubreportMO.SizeF = new System.Drawing.SizeF(829.9998F, 23.00002F);
            // 
            // xrSubreportWires
            // 
            this.xrSubreportWires.LocationFloat = new DevExpress.Utils.PointFloat(0.0001509984F, 186.3123F);
            this.xrSubreportWires.Name = "xrSubreportWires";
            this.xrSubreportWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LanguageId", this.LanguageId));
            this.xrSubreportWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgSenderCode", null, "Combined_Report_Header.AgencyCode"));
            this.xrSubreportWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FDate", this.FDate));
            this.xrSubreportWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("TDate", this.TDate));
            this.xrSubreportWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("UserName", this.CreatedBy));
            this.xrSubreportWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AllowViewCommissions", this.AllowViewCommissions));
            this.xrSubreportWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Color", null, "GetAgencyCompanyInfo.ReportColorForeground"));
            this.xrSubreportWires.ReportSource = new WebAPIReports.Reports.AgencyOverview.CombinedReportWires();
            this.xrSubreportWires.SizeF = new System.Drawing.SizeF(829.9998F, 23F);
            // 
            // xrSubreportGraphic
            // 
            this.xrSubreportGraphic.CanShrink = true;
            this.xrSubreportGraphic.LocationFloat = new DevExpress.Utils.PointFloat(0F, 76.14581F);
            this.xrSubreportGraphic.Name = "xrSubreportGraphic";
            this.xrSubreportGraphic.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgSenderCode", null, "Combined_Report_Header.AgencyCode"));
            this.xrSubreportGraphic.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FDate", this.FDate));
            this.xrSubreportGraphic.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("TDate", this.TDate));
            this.xrSubreportGraphic.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FormName", this.FormName));
            this.xrSubreportGraphic.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LanguageId", this.LanguageId));
            this.xrSubreportGraphic.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AllowViewCommissions", this.AllowViewCommissions));
            this.xrSubreportGraphic.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("HasData", null, "Combined_Report_Header.HasData"));
            this.xrSubreportGraphic.ReportSource = new WebAPIReports.Reports.AgencyOverview.CombinedReportSummaryGraphic();
            this.xrSubreportGraphic.SizeF = new System.Drawing.SizeF(100F, 83.12498F);
            // 
            // AgencyCode
            // 
            this.AgencyCode.Name = "AgencyCode";
            this.AgencyCode.ValueInfo = "FL1000";
            // 
            // IncludeAgencyGroup
            // 
            this.IncludeAgencyGroup.Description = "IncludeAgencyGroup";
            this.IncludeAgencyGroup.Name = "IncludeAgencyGroup";
            this.IncludeAgencyGroup.Type = typeof(bool);
            this.IncludeAgencyGroup.ValueInfo = "True";
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
            this.BottomMargin.HeightF = 10F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
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
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BorderColor = System.Drawing.Color.Black;
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Title.BorderWidth = 1F;
            this.Title.Font = new System.Drawing.Font(ReportCommon.Font, 12F);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.Title.Name = "Title";
            // 
            // DetailData3_Odd
            // 
            this.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent;
            this.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DetailData3_Odd.BorderWidth = 1F;
            this.DetailData3_Odd.Font = new System.Drawing.Font(ReportCommon.Font, 10F);
            this.DetailData3_Odd.ForeColor = System.Drawing.Color.Black;
            this.DetailData3_Odd.Name = "DetailData3_Odd";
            this.DetailData3_Odd.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // PageInfo
            // 
            this.PageInfo.Font = new System.Drawing.Font(ReportCommon.Font, 10F, System.Drawing.FontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.PageInfo.Name = "PageInfo";
            this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
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
            this.CalcInfoHeader.Expression = resources.GetString("CalcInfoHeader.Expression");
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
            this.ReportFooter.Font = new System.Drawing.Font(ReportCommon.Font, 10F);
            this.ReportFooter.HeightF = 1.729329F;
            this.ReportFooter.KeepTogether = true;
            this.ReportFooter.Name = "ReportFooter";
            this.ReportFooter.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            this.ReportFooter.PrintAtBottom = true;
            this.ReportFooter.StylePriority.UseFont = false;
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
            this.xrSubreporHeaderCustom});
            this.ReportHeader.Font = new System.Drawing.Font(ReportCommon.Font, 10F);
            this.ReportHeader.HeightF = 34.82213F;
            this.ReportHeader.Name = "ReportHeader";
            this.ReportHeader.StylePriority.UseFont = false;
            // 
            // xrSubreporHeaderCustom
            // 
            this.xrSubreporHeaderCustom.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrSubreporHeaderCustom.Name = "xrSubreporHeaderCustom";
            this.xrSubreporHeaderCustom.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LanguageId", this.LanguageId));
            this.xrSubreporHeaderCustom.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgSenderCode", this.AgencyCode));
            this.xrSubreporHeaderCustom.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FDate", this.FDate));
            this.xrSubreporHeaderCustom.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("TDate", this.TDate));
            this.xrSubreporHeaderCustom.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FormName", null, null));
            this.xrSubreporHeaderCustom.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("ReportTitle", null, "ConvertRowsInColumns_MultiLangLabels.CombinedReportTitle"));
            this.xrSubreporHeaderCustom.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgencyName", null, "Combined_Report_Header.Agname"));
            this.xrSubreporHeaderCustom.ReportSource = new WebAPIReports.Reports.Common.CustomHeader.CompanyAgencyReportHeader();
            this.xrSubreporHeaderCustom.SizeF = new System.Drawing.SizeF(830F, 23F);
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreportFooterCustom});
            this.PageFooter.Expanded = false;
            this.PageFooter.Font = new System.Drawing.Font(ReportCommon.Font, 10F);
            this.PageFooter.HeightF = 26.00001F;
            this.PageFooter.Name = "PageFooter";
            this.PageFooter.StylePriority.UseFont = false;
            // 
            // xrSubreportFooterCustom
            // 
            this.xrSubreportFooterCustom.LocationFloat = new DevExpress.Utils.PointFloat(0F, 3.000005F);
            this.xrSubreportFooterCustom.Name = "xrSubreportFooterCustom";
            this.xrSubreportFooterCustom.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LanguageId", this.LanguageId));
            this.xrSubreportFooterCustom.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgSenderCode", null, "Combined_Report_Header.AgencyCode"));
            this.xrSubreportFooterCustom.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FormName", this.FormName));
            this.xrSubreportFooterCustom.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("ReportTitle", null, "ConvertRowsInColumns_MultiLangLabels.CombinedReportTitle"));
            this.xrSubreportFooterCustom.ReportSource = new WebAPIReports.Reports.Common.CustomHeader.CompanyAgencyReportFooter();
            this.xrSubreportFooterCustom.SizeF = new System.Drawing.SizeF(829.9999F, 23F);
            // 
            // CombinedCompanyReport
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
            this.Font = new System.Drawing.Font(ReportCommon.Font, 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailData3_Odd,
            this.PageInfo});
            this.Version = "18.1";
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.CombinedReport_DataSourceDemanded);
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
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
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
        private DevExpress.XtraReports.UI.XRSubreport xrSubreportMO;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreportChecks;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreportBillPayment;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRLabel Empty;
        private DevExpress.XtraReports.Parameters.Parameter IncludeAgencyGroup;
        private DevExpress.DataAccess.Sql.SqlDataSource DataSourceCombined;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreportSummary;
        private DevExpress.XtraReports.Parameters.Parameter AllowViewCommissions;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreportGraphic;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreportWires;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreporHeaderCustom;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreportFooterCustom;
    }
}
