namespace WebAPIReports.Reports.AgencyOverview
{
    partial class CombinedReportSummary
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
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter6 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter7 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CombinedReportSummary));
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary4 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary5 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrSubreportSummaryChecks = new DevExpress.XtraReports.UI.XRSubreport();
            this.AgSenderCode = new DevExpress.XtraReports.Parameters.Parameter();
            this.FDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.TDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.UserName = new DevExpress.XtraReports.Parameters.Parameter();
            this.FormName = new DevExpress.XtraReports.Parameters.Parameter();
            this.LanguageId = new DevExpress.XtraReports.Parameters.Parameter();
            this.IncludeAgencyGroup = new DevExpress.XtraReports.Parameters.Parameter();
            this.AllowViewCommissions = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrSubreportSummaryBillPayment = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrSubreportSummaryMO = new DevExpress.XtraReports.UI.XRSubreport();
            this.Color = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrSubreportSummaryWires = new DevExpress.XtraReports.UI.XRSubreport();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailCaption3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailCaptionBackground3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabelExtension();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.TotalDeposit = new DevExpress.XtraReports.UI.CalculatedField();
            this.DataSourceWires = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrPanel3 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel37 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.HasData = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreportSummaryChecks,
            this.xrSubreportSummaryBillPayment,
            this.xrSubreportSummaryMO,
            this.xrSubreportSummaryWires});
            this.Detail.Font = new System.Drawing.Font(ReportCommon.Font, 10F);
            this.Detail.HeightF = 92.15378F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("AgSenderCode", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.Detail.StylePriority.UseFont = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrSubreportSummaryChecks
            // 
            this.xrSubreportSummaryChecks.CanShrink = true;
            this.xrSubreportSummaryChecks.LocationFloat = new DevExpress.Utils.PointFloat(37.16925F, 68.99995F);
            this.xrSubreportSummaryChecks.Name = "xrSubreportSummaryChecks";
            this.xrSubreportSummaryChecks.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgSenderCode", this.AgSenderCode));
            this.xrSubreportSummaryChecks.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FDate", this.FDate));
            this.xrSubreportSummaryChecks.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("TDate", this.TDate));
            this.xrSubreportSummaryChecks.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("UserName", this.UserName));
            this.xrSubreportSummaryChecks.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FormName", this.FormName));
            this.xrSubreportSummaryChecks.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LanguageId", this.LanguageId));
            this.xrSubreportSummaryChecks.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("IncludeAgencyGroup", this.IncludeAgencyGroup));
            this.xrSubreportSummaryChecks.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AllowViewCommissions", this.AllowViewCommissions));
            this.xrSubreportSummaryChecks.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Color", this.Color));
            this.xrSubreportSummaryChecks.ReportSource = new WebAPIReports.Reports.AgencyOverview.CombinedReportSummaryChecks();
            this.xrSubreportSummaryChecks.SizeF = new System.Drawing.SizeF(602.9999F, 23F);
            // 
            // AgSenderCode
            // 
            this.AgSenderCode.Description = "AgSenderCode";
            this.AgSenderCode.Name = "AgSenderCode";
            this.AgSenderCode.ValueInfo = "FL1000";
            // 
            // FDate
            // 
            this.FDate.Description = "FDate";
            this.FDate.Name = "FDate";
            this.FDate.Type = typeof(System.DateTime);
            this.FDate.ValueInfo = "2021-11-20";
            // 
            // TDate
            // 
            this.TDate.Description = "TDate";
            this.TDate.Name = "TDate";
            this.TDate.Type = typeof(System.DateTime);
            this.TDate.ValueInfo = "2021-12-01";
            // 
            // UserName
            // 
            this.UserName.Description = "UserName";
            this.UserName.Name = "UserName";
            // 
            // FormName
            // 
            this.FormName.Description = "FormName";
            this.FormName.Name = "FormName";
            this.FormName.ValueInfo = "REPORT.IMXDIRECT.COMBINED";
            this.FormName.Visible = false;
            // 
            // LanguageId
            // 
            this.LanguageId.Description = "LanguageId";
            this.LanguageId.Name = "LanguageId";
            this.LanguageId.Type = typeof(int);
            this.LanguageId.ValueInfo = "2";
            // 
            // IncludeAgencyGroup
            // 
            this.IncludeAgencyGroup.Description = "IncludeAgencyGroup";
            this.IncludeAgencyGroup.Name = "IncludeAgencyGroup";
            this.IncludeAgencyGroup.Type = typeof(bool);
            this.IncludeAgencyGroup.ValueInfo = "False";
            this.IncludeAgencyGroup.Visible = false;
            // 
            // AllowViewCommissions
            // 
            this.AllowViewCommissions.Description = "Allow View Commissions";
            this.AllowViewCommissions.Name = "AllowViewCommissions";
            this.AllowViewCommissions.Type = typeof(bool);
            this.AllowViewCommissions.ValueInfo = "False";
            // 
            // xrSubreportSummaryBillPayment
            // 
            this.xrSubreportSummaryBillPayment.CanShrink = true;
            this.xrSubreportSummaryBillPayment.LocationFloat = new DevExpress.Utils.PointFloat(37.16925F, 45.99997F);
            this.xrSubreportSummaryBillPayment.Name = "xrSubreportSummaryBillPayment";
            this.xrSubreportSummaryBillPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgSenderCode", this.AgSenderCode));
            this.xrSubreportSummaryBillPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FDate", this.FDate));
            this.xrSubreportSummaryBillPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("TDate", this.TDate));
            this.xrSubreportSummaryBillPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("UserName", this.UserName));
            this.xrSubreportSummaryBillPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FormName", this.FormName));
            this.xrSubreportSummaryBillPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LanguageId", this.LanguageId));
            this.xrSubreportSummaryBillPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AllowViewCommissions", this.AllowViewCommissions));
            this.xrSubreportSummaryBillPayment.ReportSource = new WebAPIReports.Reports.AgencyOverview.CombinedReportSummaryBillPayment();
            this.xrSubreportSummaryBillPayment.SizeF = new System.Drawing.SizeF(602.9999F, 23F);
            // 
            // xrSubreportSummaryMO
            // 
            this.xrSubreportSummaryMO.CanShrink = true;
            this.xrSubreportSummaryMO.LocationFloat = new DevExpress.Utils.PointFloat(37.16925F, 22.99999F);
            this.xrSubreportSummaryMO.Name = "xrSubreportSummaryMO";
            this.xrSubreportSummaryMO.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgSenderCode", this.AgSenderCode));
            this.xrSubreportSummaryMO.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FDate", this.FDate));
            this.xrSubreportSummaryMO.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("TDate", this.TDate));
            this.xrSubreportSummaryMO.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("UserName", this.UserName));
            this.xrSubreportSummaryMO.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FormName", this.UserName));
            this.xrSubreportSummaryMO.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LanguageId", this.LanguageId));
            this.xrSubreportSummaryMO.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("IncludeAgencyGroup", this.IncludeAgencyGroup));
            this.xrSubreportSummaryMO.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AllowViewCommissions", this.AllowViewCommissions));
            this.xrSubreportSummaryMO.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Color", this.Color));
            this.xrSubreportSummaryMO.ReportSource = new WebAPIReports.Reports.AgencyOverview.CombinedReportSummaryMO();
            this.xrSubreportSummaryMO.SizeF = new System.Drawing.SizeF(602.9999F, 23F);
            // 
            // Color
            // 
            this.Color.Description = "Color Foreground";
            this.Color.Name = "Color";
            this.Color.ValueInfo = "#000000";
            this.Color.Visible = false;
            // 
            // xrSubreportSummaryWires
            // 
            this.xrSubreportSummaryWires.CanShrink = true;
            this.xrSubreportSummaryWires.LocationFloat = new DevExpress.Utils.PointFloat(37.16925F, 0F);
            this.xrSubreportSummaryWires.Name = "xrSubreportSummaryWires";
            this.xrSubreportSummaryWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgSenderCode", this.AgSenderCode));
            this.xrSubreportSummaryWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FDate", this.FDate));
            this.xrSubreportSummaryWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("TDate", this.TDate));
            this.xrSubreportSummaryWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("UserName", this.UserName));
            this.xrSubreportSummaryWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LanguageId", this.LanguageId));
            this.xrSubreportSummaryWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AllowViewCommissions", this.AllowViewCommissions));
            this.xrSubreportSummaryWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Color", this.Color));
            this.xrSubreportSummaryWires.ReportSource = new WebAPIReports.Reports.AgencyOverview.CombinedReportSummaryWires();
            this.xrSubreportSummaryWires.SizeF = new System.Drawing.SizeF(602.9999F, 23F);
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 0F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
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
            // DetailCaption3
            // 
            this.DetailCaption3.BackColor = System.Drawing.Color.Transparent;
            this.DetailCaption3.BorderColor = System.Drawing.Color.Transparent;
            this.DetailCaption3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DetailCaption3.Font = new System.Drawing.Font(ReportCommon.Font, 10F, System.Drawing.FontStyle.Bold);
            this.DetailCaption3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.DetailCaption3.Name = "DetailCaption3";
            this.DetailCaption3.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailCaption3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData3
            // 
            this.DetailData3.Font = new System.Drawing.Font(ReportCommon.Font, 10F);
            this.DetailData3.ForeColor = System.Drawing.Color.Black;
            this.DetailData3.Name = "DetailData3";
            this.DetailData3.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailData3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
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
            // DetailCaptionBackground3
            // 
            this.DetailCaptionBackground3.BackColor = System.Drawing.Color.Transparent;
            this.DetailCaptionBackground3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.DetailCaptionBackground3.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.DetailCaptionBackground3.BorderWidth = 2F;
            this.DetailCaptionBackground3.Name = "DetailCaptionBackground3";
            // 
            // PageInfo
            // 
            this.PageInfo.Font = new System.Drawing.Font(ReportCommon.Font, 10F, System.Drawing.FontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.PageInfo.Name = "PageInfo";
            this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3});
            this.PageHeader.Font = new System.Drawing.Font(ReportCommon.Font, 12F);
            this.PageHeader.HeightF = 30.13771F;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.StylePriority.UseFont = false;
            // 
            // xrLabel3
            // 
            this.xrLabel3.CanGrow = false;
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Upper([ConvertRowsInColumns_MultiLangLabels].[CombinedReportSummary])")});
            this.xrLabel3.Font = new System.Drawing.Font(ReportCommon.Font, 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel3.ForeColor = System.Drawing.Color.Black;
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(7.947286E-06F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(602.461F, 24.90465F);
            this.xrLabel3.StyleName = "Title";
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseForeColor = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Summary";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrLabel3.WordWrap = false;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel28,
            this.xrLabel21,
            this.xrLabel20,
            this.xrLabel19,
            this.xrLabel18,
            this.xrLabel17,
            this.xrLabel5});
            this.GroupHeader1.Font = new System.Drawing.Font(ReportCommon.Font, 10F);
            this.GroupHeader1.HeightF = 45.13505F;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.RepeatEveryPage = true;
            this.GroupHeader1.StylePriority.UseFont = false;
            // 
            // xrLabel28
            // 
            this.xrLabel28.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel28.BorderWidth = 2F;
            this.xrLabel28.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif([Parameters].[AllowViewCommissions] = true,[ConvertRowsInColumns_MultiLangLab" +
                    "els].[AgComm], \'\')")});
            this.xrLabel28.Font = new System.Drawing.Font(ReportCommon.Font, 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(494.1691F, 4.121685F);
            this.xrLabel28.Name = "xrLabel28";
            this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel28.SizeF = new System.Drawing.SizeF(76F, 41F);
            this.xrLabel28.StylePriority.UseBorders = false;
            this.xrLabel28.StylePriority.UseBorderWidth = false;
            this.xrLabel28.StylePriority.UseFont = false;
            this.xrLabel28.StylePriority.UsePadding = false;
            this.xrLabel28.StylePriority.UseTextAlignment = false;
            this.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel21
            // 
            this.xrLabel21.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel21.BorderWidth = 2F;
            this.xrLabel21.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ConvertRowsInColumns_MultiLangLabels].[Voids]")});
            this.xrLabel21.Font = new System.Drawing.Font(ReportCommon.Font, 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(570.1691F, 4.135052F);
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(70F, 40.99666F);
            this.xrLabel21.StylePriority.UseBorders = false;
            this.xrLabel21.StylePriority.UseBorderWidth = false;
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.StylePriority.UsePadding = false;
            this.xrLabel21.StylePriority.UseTextAlignment = false;
            this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel20
            // 
            this.xrLabel20.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel20.BorderWidth = 2F;
            this.xrLabel20.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ConvertRowsInColumns_MultiLangLabels].[DepositAmount]")});
            this.xrLabel20.Font = new System.Drawing.Font(ReportCommon.Font, 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(394.1691F, 4.121685F);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(100F, 40.99666F);
            this.xrLabel20.StylePriority.UseBorders = false;
            this.xrLabel20.StylePriority.UseBorderWidth = false;
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.StylePriority.UsePadding = false;
            this.xrLabel20.StylePriority.UseTextAlignment = false;
            this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel19
            // 
            this.xrLabel19.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel19.BorderWidth = 2F;
            this.xrLabel19.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ConvertRowsInColumns_MultiLangLabels].[Charges]")});
            this.xrLabel19.Font = new System.Drawing.Font(ReportCommon.Font, 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(309.169F, 4.118331F);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(85F, 41F);
            this.xrLabel19.StylePriority.UseBorders = false;
            this.xrLabel19.StylePriority.UseBorderWidth = false;
            this.xrLabel19.StylePriority.UseFont = false;
            this.xrLabel19.StylePriority.UsePadding = false;
            this.xrLabel19.StylePriority.UseTextAlignment = false;
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel18
            // 
            this.xrLabel18.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel18.BorderWidth = 2F;
            this.xrLabel18.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ConvertRowsInColumns_MultiLangLabels].[AmountAbbr]")});
            this.xrLabel18.Font = new System.Drawing.Font(ReportCommon.Font, 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(209.169F, 4.125039F);
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(100F, 40.99666F);
            this.xrLabel18.StylePriority.UseBorders = false;
            this.xrLabel18.StylePriority.UseBorderWidth = false;
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.StylePriority.UsePadding = false;
            this.xrLabel18.StylePriority.UseTextAlignment = false;
            this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel17
            // 
            this.xrLabel17.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel17.BorderWidth = 2F;
            this.xrLabel17.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ConvertRowsInColumns_MultiLangLabels].[Qty]")});
            this.xrLabel17.Font = new System.Drawing.Font(ReportCommon.Font, 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(147.1691F, 4.125039F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(62F, 41F);
            this.xrLabel17.StylePriority.UseBorders = false;
            this.xrLabel17.StylePriority.UseBorderWidth = false;
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UsePadding = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel5
            // 
            this.xrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel5.BorderWidth = 2F;
            this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ConvertRowsInColumns_MultiLangLabels].[Type]")});
            this.xrLabel5.Font = new System.Drawing.Font(ReportCommon.Font, 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(37.16902F, 4.135052F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(110F, 41F);
            this.xrLabel5.StylePriority.UseBorders = false;
            this.xrLabel5.StylePriority.UseBorderWidth = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UsePadding = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // TotalDeposit
            // 
            this.TotalDeposit.DataMember = "ImxDirect_WIRE_Report_Sent_Combined";
            this.TotalDeposit.Expression = "Iif([WireReplacementType] == 2, 0,IsNull([OriAmount],0) + IsNull([Charges],0) + I" +
    "sNull([OtherChg],0) - IsNull([AgSenderCommissionInv],0) - IsNull([DiscountAmount" +
    "],0))";
            this.TotalDeposit.Name = "TotalDeposit";
            // 
            // DataSourceWires
            // 
            this.DataSourceWires.ConnectionName = "WireTransacConn";
            this.DataSourceWires.Name = "DataSourceWires";
            storedProcQuery1.Name = "ImxDirect_WIRE_Report_Sent_Combined";
            queryParameter1.Name = "@AgSenderCode";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.AgSenderCode]", typeof(string));
            queryParameter2.Name = "@FDate";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.FDate]", typeof(System.DateTime));
            queryParameter3.Name = "@TDate";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("[Parameters.TDate]", typeof(System.DateTime));
            queryParameter4.Name = "@CreatedBy";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("[Parameters.UserName]", typeof(string));
            queryParameter5.Name = "@IncludeAgencyGroup";
            queryParameter5.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter5.Value = new DevExpress.DataAccess.Expression("[Parameters.IncludeAgencyGroup]", typeof(bool));
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.Parameters.Add(queryParameter2);
            storedProcQuery1.Parameters.Add(queryParameter3);
            storedProcQuery1.Parameters.Add(queryParameter4);
            storedProcQuery1.Parameters.Add(queryParameter5);
            storedProcQuery1.StoredProcName = "ImxDirect_WIRE_Report_Sent_Combined";
            storedProcQuery2.Name = "ConvertRowsInColumns_MultiLangLabels";
            queryParameter6.Name = "@LanguageId";
            queryParameter6.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter6.Value = new DevExpress.DataAccess.Expression("[Parameters.LanguageId]", typeof(int));
            queryParameter7.Name = "@FormName";
            queryParameter7.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter7.Value = new DevExpress.DataAccess.Expression("[Parameters.FormName]", typeof(string));
            storedProcQuery2.Parameters.Add(queryParameter6);
            storedProcQuery2.Parameters.Add(queryParameter7);
            storedProcQuery2.StoredProcName = "ConvertRowsInColumns_MultiLangLabels";
            this.DataSourceWires.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1,
            storedProcQuery2});
            this.DataSourceWires.ResultSchemaSerializable = resources.GetString("DataSourceWires.ResultSchemaSerializable");
            this.DataSourceWires.ConfigureDataConnection += new DevExpress.DataAccess.Sql.ConfigureDataConnectionEventHandler(this.DataSourceWires_ConfigureDataConnection);
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel3});
            this.PageFooter.Font = new System.Drawing.Font(ReportCommon.Font, 10F);
            this.PageFooter.HeightF = 33.33334F;
            this.PageFooter.Name = "PageFooter";
            this.PageFooter.StylePriority.UseFont = false;
            // 
            // xrPanel3
            // 
            this.xrPanel3.BackColor = System.Drawing.Color.Transparent;
            this.xrPanel3.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrPanel3.BorderWidth = 1F;
            this.xrPanel3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel6,
            this.xrLabel37,
            this.xrLabel14,
            this.xrLabel10,
            this.xrLabel2,
            this.xrLabel9,
            this.xrLabel8});
            this.xrPanel3.LocationFloat = new DevExpress.Utils.PointFloat(37.16925F, 2.70834F);
            this.xrPanel3.Name = "xrPanel3";
            this.xrPanel3.SizeF = new System.Drawing.SizeF(603.9558F, 30.62499F);
            this.xrPanel3.StylePriority.UseBackColor = false;
            this.xrPanel3.StylePriority.UseBorders = false;
            this.xrPanel3.StylePriority.UseBorderWidth = false;
            // 
            // xrLabel6
            // 
            this.xrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel6.Font = new System.Drawing.Font(ReportCommon.Font, 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(110F, 5.541642F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(61.99995F, 23F);
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UsePadding = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel6.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.xrLabel6_PrintOnPage);
            // 
            // xrLabel37
            // 
            this.xrLabel37.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel37.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "concat([ConvertRowsInColumns_MultiLangLabels].[GrandTotal],\':\')")});
            this.xrLabel37.Font = new System.Drawing.Font(ReportCommon.Font, 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel37.LocationFloat = new DevExpress.Utils.PointFloat(0F, 5.541642F);
            this.xrLabel37.Name = "xrLabel37";
            this.xrLabel37.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel37.SizeF = new System.Drawing.SizeF(110.0001F, 23F);
            this.xrLabel37.StylePriority.UseBorders = false;
            this.xrLabel37.StylePriority.UseFont = false;
            this.xrLabel37.StylePriority.UseTextAlignment = false;
            this.xrLabel37.Text = "Total:";
            this.xrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel14
            // 
            this.xrLabel14.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel14.Font = new System.Drawing.Font(ReportCommon.Font, 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(272F, 5.541642F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(85.00006F, 23F);
            this.xrLabel14.StylePriority.UseBorders = false;
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UsePadding = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel14.Summary = xrSummary1;
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel14.TextFormatString = "{0:$#,##0.00}";
            this.xrLabel14.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.xrLabel14_PrintOnPage);
            // 
            // xrLabel10
            // 
            this.xrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel10.Font = new System.Drawing.Font(ReportCommon.Font, 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(457.0001F, 5.541642F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(76F, 23F);
            this.xrLabel10.StylePriority.UseBorders = false;
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UsePadding = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel10.Summary = xrSummary2;
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel10.TextFormatString = "{0:$#,##0.00}";
            this.xrLabel10.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.xrLabel10_PrintOnPage);
            // 
            // xrLabel2
            // 
            this.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel2.Font = new System.Drawing.Font(ReportCommon.Font, 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(533.0001F, 5.541642F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(69.99969F, 23F);
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UsePadding = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel2.Summary = xrSummary3;
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel2.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.xrLabel2_PrintOnPage);
            // 
            // xrLabel9
            // 
            this.xrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel9.Font = new System.Drawing.Font(ReportCommon.Font, 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(357.0001F, 5.541642F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel9.StylePriority.UseBorders = false;
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UsePadding = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel9.Summary = xrSummary4;
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel9.TextFormatString = "{0:$#,##0.00}";
            this.xrLabel9.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.xrLabel9_PrintOnPage);
            // 
            // xrLabel8
            // 
            this.xrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel8.Font = new System.Drawing.Font(ReportCommon.Font, 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(172F, 5.541642F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel8.StylePriority.UseBorders = false;
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UsePadding = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            xrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel8.Summary = xrSummary5;
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel8.TextFormatString = "{0:$#,##0.00}";
            this.xrLabel8.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.xrLabel8_PrintOnPage);
            // 
            // HasData
            // 
            this.HasData.Description = "Parameter1";
            this.HasData.Name = "HasData";
            this.HasData.Type = typeof(bool);
            this.HasData.ValueInfo = "True";
            // 
            // CombinedReportSummary
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader,
            this.GroupHeader1,
            this.PageFooter});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.TotalDeposit});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.DataSourceWires});
            this.DataSource = this.DataSourceWires;
            this.Margins = new System.Drawing.Printing.Margins(0, 102, 0, 0);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.AgSenderCode,
            this.FDate,
            this.TDate,
            this.UserName,
            this.FormName,
            this.LanguageId,
            this.IncludeAgencyGroup,
            this.AllowViewCommissions,
            this.HasData,
            this.Color});
            this.ReportPrintOptions.PrintOnEmptyDataSource = false;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailCaption3,
            this.DetailData3,
            this.DetailData3_Odd,
            this.DetailCaptionBackground3,
            this.PageInfo});
            this.Version = "18.1";
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.CombinedReportWires_DataSourceDemanded);
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.CombinedReportSummary_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle DetailCaption3;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData3;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
        private DevExpress.XtraReports.UI.XRControlStyle DetailCaptionBackground3;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.Parameters.Parameter AgSenderCode;
        private DevExpress.XtraReports.Parameters.Parameter FDate;
        private DevExpress.XtraReports.Parameters.Parameter TDate;
        private DevExpress.XtraReports.UI.XRLabel xrLabel20;
        private DevExpress.XtraReports.UI.XRLabel xrLabel19;
        private DevExpress.XtraReports.UI.XRLabel xrLabel18;
        private DevExpress.XtraReports.UI.XRLabel xrLabel17;
        private DevExpress.XtraReports.UI.XRLabel xrLabel21;
        private DevExpress.XtraReports.UI.XRLabel xrLabel28;
        private DevExpress.XtraReports.Parameters.Parameter UserName;
        private DevExpress.XtraReports.Parameters.Parameter FormName;
        private DevExpress.XtraReports.Parameters.Parameter LanguageId;
        private DevExpress.XtraReports.UI.CalculatedField TotalDeposit;         
        private DevExpress.XtraReports.UI.XRLabelExtension xrLabel3;
        private DevExpress.XtraReports.Parameters.Parameter IncludeAgencyGroup;
        private DevExpress.DataAccess.Sql.SqlDataSource DataSourceWires;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreportSummaryWires;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreportSummaryMO;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreportSummaryBillPayment;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreportSummaryChecks;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRPanel xrPanel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel37;
        private DevExpress.XtraReports.UI.XRLabel xrLabel14;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.Parameters.Parameter AllowViewCommissions;
        private DevExpress.XtraReports.Parameters.Parameter HasData;
        private DevExpress.XtraReports.Parameters.Parameter Color;
    }
}
