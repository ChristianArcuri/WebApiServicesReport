namespace WebAPIReports.Reports.MoneyOrder
{
    partial class RptMOInvoiceDetail
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
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter5 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptMOInvoiceDetail));
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrPanel3 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.MoneyOrders = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.LanguageId = new DevExpress.XtraReports.Parameters.Parameter();
            this.AgencyCode = new DevExpress.XtraReports.Parameters.Parameter();
            this.StatementId = new DevExpress.XtraReports.Parameters.Parameter();
            this.BeginingBalance = new DevExpress.XtraReports.Parameters.Parameter();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.EmptyLeyend = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanelExtension();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrPanel2 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLine4 = new DevExpress.XtraReports.UI.XRLineExtension();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine3 = new DevExpress.XtraReports.UI.XRLineExtension();
            this.LDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.LMODebits = new DevExpress.XtraReports.Parameters.Parameter();
            this.LMOCredits = new DevExpress.XtraReports.Parameters.Parameter();
            this.calcMO = new DevExpress.XtraReports.UI.CalculatedField();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.Color = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel3});
            this.Detail.HeightF = 27.08333F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPanel3
            // 
            this.xrPanel3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel16,
            this.xrLabel2,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel1,
            this.xrLabel5});
            this.xrPanel3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPanel3.Name = "xrPanel3";
            this.xrPanel3.SizeF = new System.Drawing.SizeF(830.0001F, 27.08333F);
            // 
            // xrLabel16
            // 
            this.xrLabel16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AccTranTypeId]")});
            this.xrLabel16.Font = new System.Drawing.Font(ReportCommon.Font, 9F);
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(730.0001F, 0F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(99.99994F, 23F);
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.StylePriority.UseTextAlignment = false;
            this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel16.Visible = false;
            // 
            // xrLabel2
            // 
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TranDate]")});
            this.xrLabel2.Font = new System.Drawing.Font(ReportCommon.Font, 9F);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(95.74953F, 23F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "xrLabel2";
            this.xrLabel2.TextFormatString = "{0:MM/dd/yy}";
            // 
            // xrLabel4
            // 
            this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Credits]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Iif([Credits] > 0, true , false)")});
            this.xrLabel4.Font = new System.Drawing.Font(ReportCommon.Font, 9F);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(501.6664F, 0F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "xrLabel4";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel4.TextFormatString = "{0:$#,##0.00}";
            // 
            // xrLabel3
            // 
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Debits]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Iif([Debits] > 0, true , false)")});
            this.xrLabel3.Font = new System.Drawing.Font(ReportCommon.Font, 9F);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(349.1664F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "xrLabel3";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel3.TextFormatString = "{0:$#,##0.00}";
            // 
            // xrLabel1
            // 
            this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Description]")});
            this.xrLabel1.Font = new System.Drawing.Font(ReportCommon.Font, 9F);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(95.74953F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(235.9169F, 23F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "xrLabel1";
            this.xrLabel1.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel1_BeforePrint);
            // 
            // xrLabel5
            // 
            this.xrLabel5.Font = new System.Drawing.Font(ReportCommon.Font, 9F);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(628.9999F, 0F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(99.99994F, 23F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UsePadding = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel5.TextFormatString = "{0:$#,##0.00}";
            this.xrLabel5.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel5_BeforePrint);
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
            // MoneyOrders
            // 
            this.MoneyOrders.ConnectionName = "MoneyOrderConnectionString";
            this.MoneyOrders.Name = "MoneyOrders";
            storedProcQuery1.Name = "ImxDirect_MO_GetStatementDetail";
            queryParameter1.Name = "@CurrentLanguageId";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.LanguageId]", typeof(int));
            queryParameter2.Name = "@AgSenderCode";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.AgencyCode]", typeof(string));
            queryParameter3.Name = "@StatementId";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("[Parameters.StatementId]", typeof(int));
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.Parameters.Add(queryParameter2);
            storedProcQuery1.Parameters.Add(queryParameter3);
            storedProcQuery1.StoredProcName = "ImxDirect_MO_GetStatementDetail";
            storedProcQuery2.Name = "ConvertRowsInColumns_MultiLangLabels";
            queryParameter4.Name = "@LanguageId";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("[Parameters.LanguageId]", typeof(int));
            queryParameter5.Name = "@FormName";
            queryParameter5.Type = typeof(string);
            queryParameter5.ValueInfo = "REPORT.MONEYORDERS.INVOICE";
            storedProcQuery2.Parameters.Add(queryParameter4);
            storedProcQuery2.Parameters.Add(queryParameter5);
            storedProcQuery2.StoredProcName = "ConvertRowsInColumns_MultiLangLabels";
            this.MoneyOrders.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1,
            storedProcQuery2});
            this.MoneyOrders.ResultSchemaSerializable = resources.GetString("MoneyOrders.ResultSchemaSerializable");
            // 
            // LanguageId
            // 
            this.LanguageId.Description = "LanguageId";
            this.LanguageId.Name = "LanguageId";
            this.LanguageId.Type = typeof(int);
            this.LanguageId.ValueInfo = "1";
            this.LanguageId.Visible = false;
            // 
            // AgencyCode
            // 
            this.AgencyCode.Description = "AgencyCode";
            this.AgencyCode.Name = "AgencyCode";
            this.AgencyCode.ValueInfo = "fl-1000";
            this.AgencyCode.Visible = false;
            // 
            // StatementId
            // 
            this.StatementId.Description = "StatementId";
            this.StatementId.Name = "StatementId";
            this.StatementId.Type = typeof(int);
            this.StatementId.ValueInfo = "727796";
            this.StatementId.Visible = false;
            // 
            // BeginingBalance
            // 
            this.BeginingBalance.Description = "Parameter1";
            this.BeginingBalance.Name = "BeginingBalance";
            this.BeginingBalance.Type = typeof(decimal);
            this.BeginingBalance.ValueInfo = "25";
            this.BeginingBalance.Visible = false;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.EmptyLeyend,
            this.xrPanel1});
            this.ReportFooter.HeightF = 75F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // EmptyLeyend
            // 
            this.EmptyLeyend.AutoWidth = true;
            this.EmptyLeyend.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ConvertRowsInColumns_MultiLangLabels].[EmptyLeyend]")});
            this.EmptyLeyend.Font = new System.Drawing.Font(ReportCommon.Font, 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmptyLeyend.LocationFloat = new DevExpress.Utils.PointFloat(0F, 41.99998F);
            this.EmptyLeyend.Multiline = true;
            this.EmptyLeyend.Name = "EmptyLeyend";
            this.EmptyLeyend.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.EmptyLeyend.SizeF = new System.Drawing.SizeF(830F, 23.00002F);
            this.EmptyLeyend.StylePriority.UseFont = false;
            this.EmptyLeyend.StylePriority.UseTextAlignment = false;
            this.EmptyLeyend.Text = "EmptyLeyend";
            this.EmptyLeyend.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrPanel1
            // 
            this.xrPanel1.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPanel1.BorderWidth = 2F;
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel10,
            this.xrLabel9,
            this.xrLabel8,
            this.xrLabel6,
            this.xrLabel7});
            this.xrPanel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.Color, "BorderColor", "")});            
            this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10.00001F);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.SizeF = new System.Drawing.SizeF(830F, 27.5F);
            this.xrPanel1.StylePriority.UseBorders = false;
            this.xrPanel1.StylePriority.UseBorderWidth = false;
            // 
            // xrLabel10
            // 
            this.xrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel10.Font = new System.Drawing.Font(ReportCommon.Font, 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(3.173218F, 3.000005F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(116.8268F, 23F);
            this.xrLabel10.StylePriority.UseBorders = false;
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UsePadding = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "# Money Orders:";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel9
            // 
            this.xrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([calcMO])")});
            this.xrLabel9.Font = new System.Drawing.Font(ReportCommon.Font, 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(120F, 3.000005F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(191.6667F, 23F);
            this.xrLabel9.StylePriority.UseBorders = false;
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UsePadding = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel9.Summary = xrSummary1;
            this.xrLabel9.Text = "xrLabel3";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrLabel9.TextFormatString = "{0}";
            // 
            // xrLabel8
            // 
            this.xrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel8.Font = new System.Drawing.Font(ReportCommon.Font, 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(648.0001F, 3F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(99.99994F, 23F);
            this.xrLabel8.StylePriority.UseBorders = false;
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UsePadding = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel8.TextFormatString = "{0:$#,##0.00}";
            this.xrLabel8.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel8_BeforePrint);
            // 
            // xrLabel6
            // 
            this.xrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([Credits])")});
            this.xrLabel6.Font = new System.Drawing.Font(ReportCommon.Font, 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(501.6667F, 3F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel6.Summary = xrSummary2;
            this.xrLabel6.Text = "xrLabel4";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel6.TextFormatString = "{0:$#,##0.00}";
            // 
            // xrLabel7
            // 
            this.xrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([Debits])")});
            this.xrLabel7.Font = new System.Drawing.Font(ReportCommon.Font, 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(349.1667F, 3F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel7.StylePriority.UseBorders = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel7.Summary = xrSummary3;
            this.xrLabel7.Text = "xrLabel3";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel7.TextFormatString = "{0:$#,##0.00}";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel2});
            this.GroupHeader1.HeightF = 32.29167F;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.RepeatEveryPage = true;
            // 
            // xrPanel2
            // 
            this.xrPanel2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine4,
            this.xrLabel11,
            this.xrLabel15,
            this.xrLabel14,
            this.xrLabel13,
            this.xrLabel12,
            this.xrLine3});
            this.xrPanel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPanel2.Name = "xrPanel2";
            this.xrPanel2.SizeF = new System.Drawing.SizeF(830F, 32.29167F);
            // 
            // xrLine4
            // 
            this.xrLine4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.Color, "Color", "")});
            this.xrLine4.LineWidth = 2;
            this.xrLine4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 1.041667F);
            this.xrLine4.Name = "xrLine4";
            this.xrLine4.SizeF = new System.Drawing.SizeF(830F, 5.999985F);
            this.xrLine4.StylePriority.UseBorderColor = false;
            this.xrLine4.StylePriority.UseForeColor = false;
            // 
            // xrLabel11
            // 
            this.xrLabel11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Upper([Parameters].[LDate])")});
            this.xrLabel11.Font = new System.Drawing.Font(ReportCommon.Font, 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(0F, 7.041629F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(95.74953F, 18.29173F);
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.Text = "DATE";
            this.xrLabel11.WordWrap = false;
            // 
            // xrLabel15
            // 
            this.xrLabel15.Font = new System.Drawing.Font(ReportCommon.Font, 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(676.8334F, 7.041645F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 1, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(68.16672F, 18.29173F);
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.StylePriority.UsePadding = false;
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.Text = "BALANCE";
            this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel15.WordWrap = false;
            // 
            // xrLabel14
            // 
            this.xrLabel14.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "UppeR([Parameters].[LMOCredits])")});
            this.xrLabel14.Font = new System.Drawing.Font(ReportCommon.Font, 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(501.6667F, 7.041629F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(99.99997F, 18.29173F);
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.Text = "CREDITS";
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel14.WordWrap = false;
            // 
            // xrLabel13
            // 
            this.xrLabel13.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Upper([Parameters].[LMODebits])")});
            this.xrLabel13.Font = new System.Drawing.Font(ReportCommon.Font, 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(349.1667F, 7.041629F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(100F, 18.29173F);
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.Text = "DEBITS";
            this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel13.WordWrap = false;
            // 
            // xrLabel12
            // 
            this.xrLabel12.Font = new System.Drawing.Font(ReportCommon.Font, 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(95.74979F, 7.041629F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(235.9167F, 18.29173F);
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.Text = "MONEY ORDERS";
            this.xrLabel12.WordWrap = false;
            // 
            // xrLine3
            // 
            this.xrLine3.BorderColor = System.Drawing.Color.Black;
            this.xrLine3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.Color, "Color", "")});           
            this.xrLine3.LineWidth = 2;
            this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 25.33336F);
            this.xrLine3.Name = "xrLine3";
            this.xrLine3.SizeF = new System.Drawing.SizeF(830F, 6F);
            this.xrLine3.StylePriority.UseBorderColor = false;
            this.xrLine3.StylePriority.UseForeColor = false;
            // 
            // LDate
            // 
            this.LDate.Description = "Parameter1";
            this.LDate.Name = "LDate";
            this.LDate.Visible = false;
            // 
            // LMODebits
            // 
            this.LMODebits.Description = "Parameter1";
            this.LMODebits.Name = "LMODebits";
            this.LMODebits.Visible = false;
            // 
            // LMOCredits
            // 
            this.LMOCredits.Description = "Parameter1";
            this.LMOCredits.Name = "LMOCredits";
            this.LMOCredits.Visible = false;
            // 
            // calcMO
            // 
            this.calcMO.DataMember = "ImxDirect_MO_GetStatementDetail";
            this.calcMO.Expression = "Iif([type]=\'2\',1,0)";
            this.calcMO.Name = "calcMO";
            // 
            // PageFooter
            // 
            this.PageFooter.Name = "PageFooter";
            // 
            // Color
            // 
            this.Color.Description = "Color";
            this.Color.Name = "Color";
            this.Color.ValueInfo = "#000000";
            this.Color.Visible = false;
            // 
            // RptMOInvoiceDetail
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportFooter,
            this.GroupHeader1,
            this.PageFooter});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.calcMO});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.MoneyOrders});
            this.DataMember = "ImxDirect_MO_GetStatementDetail";
            this.DataSource = this.MoneyOrders;
            this.Font = new System.Drawing.Font(ReportCommon.Font, 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(10, 10, 10, 10);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.LanguageId,
            this.AgencyCode,
            this.StatementId,
            this.BeginingBalance,
            this.LDate,
            this.LMODebits,
            this.LMOCredits,
            this.Color});
            this.Version = "18.1";
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.RptMOInvoiceDetail_DataSourceDemanded);
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.RptMOInvoiceDetail_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.DataAccess.Sql.SqlDataSource MoneyOrders;
        private DevExpress.XtraReports.Parameters.Parameter LanguageId;
        private DevExpress.XtraReports.Parameters.Parameter AgencyCode;
        private DevExpress.XtraReports.Parameters.Parameter StatementId;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.Parameters.Parameter BeginingBalance;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRPanelExtension xrPanel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRLineExtension xrLine3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.XRLabel xrLabel13;
        private DevExpress.XtraReports.UI.XRLabel xrLabel14;
        private DevExpress.XtraReports.UI.XRLabel xrLabel15;
        private DevExpress.XtraReports.UI.XRLineExtension xrLine4;
        private DevExpress.XtraReports.Parameters.Parameter LDate;
        private DevExpress.XtraReports.Parameters.Parameter LMODebits;
        private DevExpress.XtraReports.Parameters.Parameter LMOCredits;
        private DevExpress.XtraReports.UI.CalculatedField calcMO;
        private DevExpress.XtraReports.UI.XRLabel xrLabel16;
        private DevExpress.XtraReports.UI.XRPanel xrPanel2;
        private DevExpress.XtraReports.UI.XRPanel xrPanel3;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRLabel EmptyLeyend;
        private DevExpress.XtraReports.Parameters.Parameter Color;
    }
}
