namespace WebAPIReports.Reports.AgencyOverview
{
    partial class CombinedReportSummaryChecks
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
            DevExpress.XtraReports.UI.XRTable xrTable2;
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary4 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary5 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary6 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRGroupSortingSummary xrGroupSortingSummary1 = new DevExpress.XtraReports.UI.XRGroupSortingSummary();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CombinedReportSummaryChecks));
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCellExtension();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailCaption3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailCaptionBackground3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.AgSenderCode = new DevExpress.XtraReports.Parameters.Parameter();
            this.FDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.TDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.UserName = new DevExpress.XtraReports.Parameters.Parameter();
            this.FormName = new DevExpress.XtraReports.Parameters.Parameter();
            this.LanguageId = new DevExpress.XtraReports.Parameters.Parameter();
            this.IncludeAgencyGroup = new DevExpress.XtraReports.Parameters.Parameter();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrControlStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.xrControlStyle2 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.xrControlStyle3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.xrControlStyle4 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DataSourceChecks = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.AllowViewCommissions = new DevExpress.XtraReports.Parameters.Parameter();
            this.Color = new DevExpress.XtraReports.Parameters.Parameter();
            xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            ((System.ComponentModel.ISupportInitialize)(xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // xrTable2
            // 
            xrTable2.BackColor = System.Drawing.Color.White;
            xrTable2.EvenStyleName = "xrControlStyle1";
            xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            xrTable2.Name = "xrTable2";
            xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            xrTable2.SizeF = new System.Drawing.SizeF(603F, 25F);
            xrTable2.StylePriority.UseBackColor = false;
            xrTable2.StylePriority.UseForeColor = false;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell2,
            this.xrTableCell5,
            this.xrTableCell1,
            this.xrTableCell3,
            this.xrTableCell4,
            this.xrTableCell6,
            this.xrTableCell7});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 11.5D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.EvenStyleName = "xrControlStyle1";
            this.xrTableCell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ConvertRowsInColumns_MultiLangLabels].[Checks]")});
            this.xrTableCell2.ForeColor = System.Drawing.Color.Blue;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.OddStyleName = "xrControlStyle1";
            this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
            this.xrTableCell2.StylePriority.UseForeColor = false;
            this.xrTableCell2.StylePriority.UsePadding = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell2.Weight = 0.23797814464727873D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.CanGrow = false;
            this.xrTableCell5.EvenStyleName = "xrControlStyle1";
            this.xrTableCell5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumCount([ImxDirect_CHECK_Report_ChecksProcessed].[CheckId])")});
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.OddStyleName = "xrControlStyle2";
            this.xrTableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
            this.xrTableCell5.StylePriority.UsePadding = false;
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrTableCell5.Summary = xrSummary1;
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell5.TextFormatString = "{0}";
            this.xrTableCell5.Weight = 0.13413313412035621D;
            this.xrTableCell5.WordWrap = false;
            this.xrTableCell5.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.xrTableCell5_PrintOnPage);
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([ImxDirect_CHECK_Report_ChecksProcessed].[CheckAmount])")});
            this.xrTableCell1.Font = new System.Drawing.Font("Calibri", 10F);
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
            this.xrTableCell1.StylePriority.UsePadding = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrTableCell1.Summary = xrSummary2;
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell1.TextFormatString = "{0:$#,##0.00}";
            this.xrTableCell1.Weight = 0.21634377077799066D;
            this.xrTableCell1.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.xrTableCell10_PrintOnPage);
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([ImxDirect_CHECK_Report_ChecksProcessed].[CheckFee])")});
            this.xrTableCell3.Font = new System.Drawing.Font("Calibri", 10F);
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
            this.xrTableCell3.StylePriority.UsePadding = false;
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrTableCell3.Summary = xrSummary3;
            this.xrTableCell3.Text = " ";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell3.TextFormatString = "{0:$#,##0.00}";
            this.xrTableCell3.Weight = 0.18389220863485789D;
            this.xrTableCell3.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.hFee_PrintOnPage);
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([ImxDirect_CHECK_Report_ChecksProcessed].[CheckAmount]+[ImxDirect_CHECK_Re" +
                    "port_ChecksProcessed].[CheckFee])")});
            this.xrTableCell4.Font = new System.Drawing.Font("Calibri", 10F);
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
            this.xrTableCell4.StylePriority.UsePadding = false;
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrTableCell4.Summary = xrSummary4;
            this.xrTableCell4.Text = " ";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell4.TextFormatString = "{0:$#,##0.00}";
            this.xrTableCell4.Weight = 0.21634376964759394D;
            this.xrTableCell4.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.hDeposit_PrintOnPage);
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif([Parameters].[AllowViewCommissions]=true,sumSum([ImxDirect_CHECK_Report_Check" +
                    "sProcessed].[CheckAGCommFee]), \'\')")});
            this.xrTableCell6.Font = new System.Drawing.Font("Calibri", 10F);
            this.xrTableCell6.Multiline = true;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
            this.xrTableCell6.StylePriority.UsePadding = false;
            this.xrTableCell6.StylePriority.UseTextAlignment = false;
            xrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrTableCell6.Summary = xrSummary5;
            this.xrTableCell6.Text = " ";
            this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell6.TextFormatString = "{0:$#,##0.00}";
            this.xrTableCell6.Weight = 0.16442125791066123D;
            this.xrTableCell6.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.hCommission_PrintOnPage);
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif(sumCount([ImxDirect_CHECK_Report_ChecksProcessed].[CheckStatusId])=0,0,sumSum" +
                    "(Iif([ImxDirect_CHECK_Report_ChecksProcessed].[CheckStatusId] == 2, 1, 0)))")});
            this.xrTableCell7.Font = new System.Drawing.Font("Calibri", 10F);
            this.xrTableCell7.Multiline = true;
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
            this.xrTableCell7.StylePriority.UsePadding = false;
            this.xrTableCell7.StylePriority.UseTextAlignment = false;
            xrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrTableCell7.Summary = xrSummary6;
            this.xrTableCell7.Text = "xrTableCell7";
            this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell7.Weight = 0.15144062276166179D;
            this.xrTableCell7.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.hVoid_PrintOnPage);
            // 
            // Detail
            // 
            this.Detail.HeightF = 0F;
            this.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnCount;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.Visible = false;
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
            this.BottomMargin.HeightF = 1F;
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
            this.Title.Font = new System.Drawing.Font("Calibri", 12F);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.Title.Name = "Title";
            // 
            // DetailCaption3
            // 
            this.DetailCaption3.BackColor = System.Drawing.Color.Transparent;
            this.DetailCaption3.BorderColor = System.Drawing.Color.Transparent;
            this.DetailCaption3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DetailCaption3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.DetailCaption3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.DetailCaption3.Name = "DetailCaption3";
            this.DetailCaption3.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailCaption3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData3
            // 
            this.DetailData3.Font = new System.Drawing.Font("Calibri", 10F);
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
            this.DetailData3_Odd.Font = new System.Drawing.Font("Calibri", 10F);
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
            this.PageInfo.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.PageInfo.Name = "PageInfo";
            this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
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
            this.FDate.ValueInfo = "2022-01-01";
            // 
            // TDate
            // 
            this.TDate.Description = "TDate";
            this.TDate.Name = "TDate";
            this.TDate.Type = typeof(System.DateTime);
            this.TDate.ValueInfo = "2022-06-07";
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
            this.FormName.ValueInfo = "REPORT.IMXCHECKS.PROCESSED";
            this.FormName.Visible = false;
            // 
            // LanguageId
            // 
            this.LanguageId.Description = "LanguageId";
            this.LanguageId.Name = "LanguageId";
            this.LanguageId.Type = typeof(int);
            this.LanguageId.ValueInfo = "1";
            // 
            // IncludeAgencyGroup
            // 
            this.IncludeAgencyGroup.Description = "IncludeAgencyGroup";
            this.IncludeAgencyGroup.Name = "IncludeAgencyGroup";
            this.IncludeAgencyGroup.Type = typeof(bool);
            this.IncludeAgencyGroup.ValueInfo = "False";
            this.IncludeAgencyGroup.Visible = false;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            xrTable2});
            this.GroupHeader1.Font = new System.Drawing.Font("Calibri", 10F);
            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("SummaryWire", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader1.HeightF = 27.08333F;
            this.GroupHeader1.Name = "GroupHeader1";
            xrGroupSortingSummary1.Enabled = true;
            this.GroupHeader1.SortingSummary = xrGroupSortingSummary1;
            this.GroupHeader1.StylePriority.UseBackColor = false;
            this.GroupHeader1.StylePriority.UseForeColor = false;
            // 
            // xrControlStyle1
            // 
            this.xrControlStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.xrControlStyle1.Name = "xrControlStyle1";
            this.xrControlStyle1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            // 
            // xrControlStyle2
            // 
            this.xrControlStyle2.Name = "xrControlStyle2";
            this.xrControlStyle2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            // 
            // xrControlStyle3
            // 
            this.xrControlStyle3.Name = "xrControlStyle3";
            this.xrControlStyle3.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            // 
            // xrControlStyle4
            // 
            this.xrControlStyle4.Name = "xrControlStyle4";
            this.xrControlStyle4.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            // 
            // DataSourceChecks
            // 
            this.DataSourceChecks.ConnectionName = "ChecksConnectionString";
            this.DataSourceChecks.Name = "DataSourceChecks";
            storedProcQuery1.Name = "ConvertRowsInColumns_MultiLangLabels";
            queryParameter1.Name = "@LanguageId";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.LanguageId]", typeof(int));
            queryParameter2.Name = "@FormName";
            queryParameter2.Type = typeof(string);
            queryParameter2.ValueInfo = "REPORT.IMXCHECKS.PROCESSED";
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.Parameters.Add(queryParameter2);
            storedProcQuery1.StoredProcName = "ConvertRowsInColumns_MultiLangLabels";
            storedProcQuery2.Name = "ImxDirect_CHECK_Report_ChecksProcessed";
            queryParameter3.Name = "@AgencyCode";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("[Parameters.AgSenderCode]", typeof(string));
            queryParameter4.Name = "@Username";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("[Parameters.UserName]", typeof(string));
            queryParameter5.Name = "@CheckFromDate";
            queryParameter5.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter5.Value = new DevExpress.DataAccess.Expression("[Parameters.FDate]", typeof(System.DateTime));
            queryParameter6.Name = "@CheckToDate";
            queryParameter6.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter6.Value = new DevExpress.DataAccess.Expression("[Parameters.TDate]", typeof(System.DateTime));
            queryParameter7.Name = "@IncludeVoid";
            queryParameter7.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter7.Value = new DevExpress.DataAccess.Expression("True", typeof(bool));
            queryParameter8.Name = "@IncludeAgencyGroup";
            queryParameter8.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter8.Value = new DevExpress.DataAccess.Expression("[Parameters.IncludeAgencyGroup]", typeof(bool));
            storedProcQuery2.Parameters.Add(queryParameter3);
            storedProcQuery2.Parameters.Add(queryParameter4);
            storedProcQuery2.Parameters.Add(queryParameter5);
            storedProcQuery2.Parameters.Add(queryParameter6);
            storedProcQuery2.Parameters.Add(queryParameter7);
            storedProcQuery2.Parameters.Add(queryParameter8);
            storedProcQuery2.StoredProcName = "ImxDirect_CHECK_Report_ChecksProcessed";
            this.DataSourceChecks.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1,
            storedProcQuery2});
            this.DataSourceChecks.ResultSchemaSerializable = resources.GetString("DataSourceChecks.ResultSchemaSerializable");
            this.DataSourceChecks.ConfigureDataConnection += new DevExpress.DataAccess.Sql.ConfigureDataConnectionEventHandler(this.DataSourceChecks_ConfigureDataConnection);
            // 
            // AllowViewCommissions
            // 
            this.AllowViewCommissions.Description = "Allow View Commissions";
            this.AllowViewCommissions.Name = "AllowViewCommissions";
            this.AllowViewCommissions.Type = typeof(bool);
            this.AllowViewCommissions.ValueInfo = "False";
            // 
            // Color
            // 
            this.Color.Description = "Color Foreground";
            this.Color.Name = "Color";
            this.Color.ValueInfo = "#000000";
            this.Color.Visible = false;
            // 
            // CombinedReportSummaryChecks
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.DataSourceChecks});
            this.DataMember = "ImxDirect_CHECK_Report_ChecksProcessed";
            this.DataSource = this.DataSourceChecks;
            this.Margins = new System.Drawing.Printing.Margins(0, 25, 0, 1);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.AgSenderCode,
            this.FDate,
            this.TDate,
            this.UserName,
            this.FormName,
            this.LanguageId,
            this.IncludeAgencyGroup,
            this.AllowViewCommissions,
            this.Color});
            this.ReportPrintOptions.PrintOnEmptyDataSource = false;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailCaption3,
            this.DetailData3,
            this.DetailData3_Odd,
            this.DetailCaptionBackground3,
            this.PageInfo,
            this.xrControlStyle1,
            this.xrControlStyle2,
            this.xrControlStyle3,
            this.xrControlStyle4});
            this.Version = "18.1";
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.CombinedReportSummaryChecks_DataSourceDemanded);
            ((System.ComponentModel.ISupportInitialize)(xrTable2)).EndInit();
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
        private DevExpress.XtraReports.Parameters.Parameter AgSenderCode;
        private DevExpress.XtraReports.Parameters.Parameter FDate;
        private DevExpress.XtraReports.Parameters.Parameter TDate;
        private DevExpress.XtraReports.Parameters.Parameter UserName;
        private DevExpress.XtraReports.Parameters.Parameter FormName;
        private DevExpress.XtraReports.Parameters.Parameter LanguageId;
        private DevExpress.XtraReports.Parameters.Parameter IncludeAgencyGroup;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCellExtension xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRControlStyle xrControlStyle1;
        private DevExpress.XtraReports.UI.XRControlStyle xrControlStyle2;
        private DevExpress.XtraReports.UI.XRControlStyle xrControlStyle3;
        private DevExpress.XtraReports.UI.XRControlStyle xrControlStyle4;
        private DevExpress.DataAccess.Sql.SqlDataSource DataSourceChecks;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.Parameters.Parameter AllowViewCommissions;
        private DevExpress.XtraReports.Parameters.Parameter Color;
    }
}
