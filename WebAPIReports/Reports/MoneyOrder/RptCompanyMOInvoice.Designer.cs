namespace WebAPIReports.Reports.MoneyOrder
{
    partial class RptCompanyMOInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptCompanyMOInvoice));
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter5 = new DevExpress.DataAccess.Sql.QueryParameter();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrPanel2 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrSubreport1 = new DevExpress.XtraReports.UI.XRSubreport();
            this.LanguageId = new DevExpress.XtraReports.Parameters.Parameter();
            this.AgencyCode = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLineExtension();
            this.WireDataSource = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLineExtension();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.MoneyOrders = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrCompanyHeader = new DevExpress.XtraReports.UI.XRSubreport();
            this.DateFrom = new DevExpress.XtraReports.Parameters.Parameter();
            this.DateTo = new DevExpress.XtraReports.Parameters.Parameter();
            this.FormName = new DevExpress.XtraReports.Parameters.Parameter();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailCaption3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailCaptionBackground3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.groupHeaderBand1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrCompanyFooter = new DevExpress.XtraReports.UI.XRSubreport();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel2,
            this.xrSubreport1,
            this.xrLabel16,
            this.xrLabel15,
            this.xrLabel5,
            this.xrLabel3,
            this.xrLabel22,
            this.xrLabel23,
            this.xrLabel4});
            this.Detail.HeightF = 133.9165F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPanel2
            // 
            this.xrPanel2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel6,
            this.xrLabel9,
            this.xrLabel8,
            this.xrLabel7});
            this.xrPanel2.LocationFloat = new DevExpress.Utils.PointFloat(563.3673F, 0F);
            this.xrPanel2.Name = "xrPanel2";
            this.xrPanel2.SizeF = new System.Drawing.SizeF(266.6325F, 46.62505F);
            // 
            // xrLabel6
            // 
            this.xrLabel6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MOStatementId] + \': \'")});
            this.xrLabel6.Font = new System.Drawing.Font(ReportCommon.Font, 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(62.79297F, 0F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(98.17343F, 18.37494F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Statment ID:";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel6.WordWrap = false;
            // 
            // xrLabel9
            // 
            this.xrLabel9.CanShrink = true;
            this.xrLabel9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[InvoiceDate]")});
            this.xrLabel9.Font = new System.Drawing.Font(ReportCommon.Font, 9F);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(160.9664F, 24.9585F);
            this.xrLabel9.Multiline = true;
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(99.03362F, 21.66665F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "xrLabel4";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel9.TextFormatString = "{0:MM/dd/yyyy}";
            // 
            // xrLabel8
            // 
            this.xrLabel8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MOStatementDate] + \': \'")});
            this.xrLabel8.Font = new System.Drawing.Font(ReportCommon.Font, 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(50.29968F, 24.9585F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(110.6667F, 18.29173F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "Statement Date:";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel8.WordWrap = false;
            // 
            // xrLabel7
            // 
            this.xrLabel7.CanShrink = true;
            this.xrLabel7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Invoice_Id]")});
            this.xrLabel7.Font = new System.Drawing.Font(ReportCommon.Font, 9F);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(160.9664F, 0F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(99.03362F, 21.66668F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "xrLabel4";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrSubreport1
            // 
            this.xrSubreport1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 108.4165F);
            this.xrSubreport1.Name = "xrSubreport1";
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LanguageId", this.LanguageId));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgencyCode", this.AgencyCode));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("StatementId", null, "ImxDirect_MO_GetStatements.Invoice_Id"));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("BeginingBalance", null, "ImxDirect_MO_GetStatements.BeginingBalance"));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LDate", null, "ImxDirect_MO_GetStatements.MODate"));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LMODebits", null, "ImxDirect_MO_GetStatements.MODebits"));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LMOCredits", null, "ImxDirect_MO_GetStatements.MOCredits"));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Color", null, "GetAgencyCompanyInfo.ReportColorForeground"));
            this.xrSubreport1.ReportSource = new WebAPIReports.Reports.MoneyOrder.RptMOInvoiceDetail();
            this.xrSubreport1.SizeF = new System.Drawing.SizeF(829.9999F, 23.00002F);
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
            // xrLabel16
            // 
            this.xrLabel16.CanShrink = true;
            this.xrLabel16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BeginingBalance]")});
            this.xrLabel16.Font = new System.Drawing.Font(ReportCommon.Font, 10F);
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(716.5678F, 79.66669F);
            this.xrLabel16.Multiline = true;
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(105.0911F, 21.66666F);
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.StylePriority.UseTextAlignment = false;
            this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel16.TextFormatString = "{0:$#,##0.00}";
            // 
            // xrLabel15
            // 
            this.xrLabel15.CanShrink = true;
            this.xrLabel15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MOBeginingBalance] + \': \'")});
            this.xrLabel15.Font = new System.Drawing.Font(ReportCommon.Font, 10F);
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(589.6336F, 79.66665F);
            this.xrLabel15.Multiline = true;
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(126.9344F, 21.66667F);
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.Text = "Begining Balance:";
            // 
            // xrLabel5
            // 
            this.xrLabel5.CanGrow = false;
            this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif(Not IsNullOrEmpty([AgFaxLine1]),\n\tFormatString(\'{0:(###) ### - ####}\',\n\tToLon" +
                    "g(Replace([AgFaxLine1],\'-\',\'\'))),\n\t\'\')")});
            this.xrLabel5.Font = new System.Drawing.Font(ReportCommon.Font, 9F);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(61.99992F, 49.20832F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(263.0001F, 21.66666F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.WordWrap = false;
            // 
            // xrLabel3
            // 
            this.xrLabel3.CanGrow = false;
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif(Not IsNullOrEmpty([AgPhone1]),\n\tFormatString(\'{0:(###) ### - ####}\',\n      To" +
                    "Long(Replace([AgPhone1], \'-\', \'\'))),\n\t\'\')")});
            this.xrLabel3.Font = new System.Drawing.Font(ReportCommon.Font, 9F);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(61.99992F, 27.4584F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(255.9245F, 21.66667F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.WordWrap = false;
            // 
            // xrLabel22
            // 
            this.xrLabel22.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MOPhone] + \': \'")});
            this.xrLabel22.Font = new System.Drawing.Font(ReportCommon.Font, 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(10F, 27.4585F);
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel22.SizeF = new System.Drawing.SizeF(52F, 18.37494F);
            this.xrLabel22.StylePriority.UseFont = false;
            this.xrLabel22.Text = "Phone:";
            this.xrLabel22.WordWrap = false;
            // 
            // xrLabel23
            // 
            this.xrLabel23.Font = new System.Drawing.Font(ReportCommon.Font, 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(10F, 49.20832F);
            this.xrLabel23.Name = "xrLabel23";
            this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel23.SizeF = new System.Drawing.SizeF(41.5F, 18.29173F);
            this.xrLabel23.StylePriority.UseFont = false;
            this.xrLabel23.Text = "Fax:";
            this.xrLabel23.WordWrap = false;
            // 
            // xrLabel4
            // 
            this.xrLabel4.CanShrink = true;
            this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Trim([AgCode]) + \' / \' + [AgName]\n+ Char(13) \n\n+ [AgAddress] + \' \'+ [AgAddress2]\n" +
                    "+ Char(13)\n+ [AgCity] + \', \' + [AgState] + \' \' + [AgZipCode]")});
            this.xrLabel4.Font = new System.Drawing.Font(ReportCommon.Font, 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(10F, 0F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(316.6666F, 21.66667F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.Text = "xrLabel4";
            // 
            // xrLine2
            // 
            this.xrLine2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[]
            {
                new DevExpress.XtraReports.UI.XRBinding("Color", this.WireDataSource, "GetAgencyCompanyInfo.ReportColorForeground")
            });
            this.xrLine2.LineWidth = 2;
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(0.6589413F, 36.91666F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(829.341F, 6F);
            // 
            // WireDataSource
            // 
            this.WireDataSource.ConnectionName = "WireTransacConn";
            this.WireDataSource.Name = "WireDataSource";
            storedProcQuery1.Name = "GetAgencyCompanyInfo";
            queryParameter1.Name = "@AgencyCode";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.AgencyCode]", typeof(string));
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.StoredProcName = "GetAgencyCompanyInfo";
            this.WireDataSource.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.WireDataSource.ResultSchemaSerializable = resources.GetString("WireDataSource.ResultSchemaSerializable");
            // 
            // xrLine1
            // 
            this.xrLine1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[]
            {
                new DevExpress.XtraReports.UI.XRBinding("Color", this.WireDataSource, "GetAgencyCompanyInfo.ReportColorForeground")
            });
            this.xrLine1.LineWidth = 10;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(830F, 10.5F);
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
            storedProcQuery2.Name = "ImxDirect_MO_GetStatements";
            queryParameter2.Name = "@CurrentLanguageId";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.LanguageId]", typeof(int));
            queryParameter3.Name = "@AgSenderCode";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("[Parameters.AgencyCode]", typeof(string));
            queryParameter4.Name = "@DateFrom";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("[Parameters.DateFrom]", typeof(System.DateTime));
            queryParameter5.Name = "@DateTo";
            queryParameter5.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter5.Value = new DevExpress.DataAccess.Expression("[Parameters.DateTo]", typeof(System.DateTime));
            storedProcQuery2.Parameters.Add(queryParameter2);
            storedProcQuery2.Parameters.Add(queryParameter3);
            storedProcQuery2.Parameters.Add(queryParameter4);
            storedProcQuery2.Parameters.Add(queryParameter5);
            storedProcQuery2.StoredProcName = "ImxDirect_MO_GetStatements";
            this.MoneyOrders.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery2});
            this.MoneyOrders.ResultSchemaSerializable = resources.GetString("MoneyOrders.ResultSchemaSerializable");
            // 
            // reportHeaderBand1
            // 
            this.reportHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine2,
            this.xrLine1,
            this.xrCompanyHeader});
            this.reportHeaderBand1.HeightF = 42.91666F;
            this.reportHeaderBand1.Name = "reportHeaderBand1";
            // 
            // xrCompanyHeader
            // 
            this.xrCompanyHeader.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10.5F);
            this.xrCompanyHeader.Name = "xrCompanyHeader";
            this.xrCompanyHeader.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LanguageId", this.LanguageId));
            this.xrCompanyHeader.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("ReportTitle", null, "ImxDirect_MO_GetStatements.MOStatamentTitle"));
            this.xrCompanyHeader.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgSenderCode", this.AgencyCode));
            this.xrCompanyHeader.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FDate", this.DateFrom));
            this.xrCompanyHeader.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("TDate", this.DateTo));
            this.xrCompanyHeader.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FormName", this.FormName));
            this.xrCompanyHeader.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgencyName", null, "ImxDirect_MO_GetStatements.AgName"));
            this.xrCompanyHeader.ReportSource = new WebAPIReports.Reports.Common.CustomHeader.CompanyAgencyReportHeader();
            this.xrCompanyHeader.SizeF = new System.Drawing.SizeF(830F, 25.99999F);
            // 
            // DateFrom
            // 
            this.DateFrom.Description = "DateFrom";
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.Type = typeof(System.DateTime);
            this.DateFrom.ValueInfo = "2017-03-01";
            this.DateFrom.Visible = false;
            // 
            // DateTo
            // 
            this.DateTo.Description = "DateTo";
            this.DateTo.Name = "DateTo";
            this.DateTo.Type = typeof(System.DateTime);
            this.DateTo.ValueInfo = "2017-03-31";
            this.DateTo.Visible = false;
            // 
            // FormName
            // 
            this.FormName.Description = "FormName";
            this.FormName.Name = "FormName";
            this.FormName.ValueInfo = "REPORT.MONEYORDERS.INVOICE";
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BorderColor = System.Drawing.Color.Black;
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Title.BorderWidth = 1F;
            this.Title.Font = new System.Drawing.Font(ReportCommon.Font, 14F);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.Title.Name = "Title";
            // 
            // DetailCaption3
            // 
            this.DetailCaption3.BackColor = System.Drawing.Color.Transparent;
            this.DetailCaption3.BorderColor = System.Drawing.Color.Transparent;
            this.DetailCaption3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DetailCaption3.Font = new System.Drawing.Font(ReportCommon.Font, 8F, System.Drawing.FontStyle.Bold);
            this.DetailCaption3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.DetailCaption3.Name = "DetailCaption3";
            this.DetailCaption3.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailCaption3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData3
            // 
            this.DetailData3.Font = new System.Drawing.Font(ReportCommon.Font, 8F);
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
            this.DetailData3_Odd.Font = new System.Drawing.Font(ReportCommon.Font, 8F);
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
            this.PageInfo.Font = new System.Drawing.Font(ReportCommon.Font, 8F, System.Drawing.FontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.PageInfo.Name = "PageInfo";
            this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // groupHeaderBand1
            // 
            this.groupHeaderBand1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.groupHeaderBand1.HeightF = 0F;
            this.groupHeaderBand1.Name = "groupHeaderBand1";
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCompanyFooter});
            this.PageFooter.HeightF = 28.125F;
            this.PageFooter.Name = "PageFooter";
            // 
            // xrCompanyFooter
            // 
            this.xrCompanyFooter.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrCompanyFooter.Name = "xrCompanyFooter";
            this.xrCompanyFooter.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgSenderCode", this.AgencyCode));
            this.xrCompanyFooter.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FormName", this.FormName));
            this.xrCompanyFooter.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LanguageId", this.LanguageId));
            this.xrCompanyFooter.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("ReportTitle", null, "ImxDirect_MO_GetStatements.MOStatamentTitle"));
            this.xrCompanyFooter.ReportSource = new WebAPIReports.Reports.Common.CustomHeader.CompanyAgencyReportFooter();
            this.xrCompanyFooter.SizeF = new System.Drawing.SizeF(829.0411F, 25.99999F);
            // 
            // RptCompanyMOInvoice
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.reportHeaderBand1,
            this.groupHeaderBand1,
            this.PageFooter});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.MoneyOrders,
            this.WireDataSource});
            this.DataMember = "ImxDirect_MO_GetStatements";
            this.DataSource = this.MoneyOrders;
            this.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ForeColor", "Iif([Parameters.BlackAndWhite], [Red], [Blue])")});
            this.Font = new System.Drawing.Font(ReportCommon.Font, 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(10, 10, 10, 10);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.LanguageId,
            this.AgencyCode,
            this.DateFrom,
            this.DateTo,
            this.FormName});
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailCaption3,
            this.DetailData3,
            this.DetailData3_Odd,
            this.DetailCaptionBackground3,
            this.PageInfo});
            this.Version = "18.1";
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.RptMOInvoice_DataSourceDemanded);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.DataAccess.Sql.SqlDataSource MoneyOrders;
        private DevExpress.XtraReports.UI.ReportHeaderBand reportHeaderBand1;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle DetailCaption3;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData3;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
        private DevExpress.XtraReports.UI.XRControlStyle DetailCaptionBackground3;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.Parameters.Parameter LanguageId;
        private DevExpress.XtraReports.Parameters.Parameter AgencyCode;
        private DevExpress.XtraReports.Parameters.Parameter DateFrom;
        private DevExpress.XtraReports.Parameters.Parameter DateTo;
        private DevExpress.XtraReports.UI.XRLineExtension xrLine1;
        private DevExpress.XtraReports.UI.XRLineExtension xrLine2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel22;
        private DevExpress.XtraReports.UI.XRLabel xrLabel23;
        private DevExpress.XtraReports.UI.XRLabel xrLabel16;
        private DevExpress.XtraReports.UI.XRLabel xrLabel15;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport1;
        private DevExpress.XtraReports.UI.XRPanel xrPanel2;
        private DevExpress.XtraReports.UI.GroupHeaderBand groupHeaderBand1;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.DataAccess.Sql.SqlDataSource WireDataSource;
        private DevExpress.XtraReports.UI.XRSubreport xrCompanyFooter;
        private DevExpress.XtraReports.UI.XRSubreport xrCompanyHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.Parameters.Parameter FormName;
    }
}
