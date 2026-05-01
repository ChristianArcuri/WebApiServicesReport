using DevExpress.XtraReports.UI;

namespace WebAPIReports.Reports.FXFAX
{
    partial class ExchangeRateReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExchangeRateReport));
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery3 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter5 = new DevExpress.DataAccess.Sql.QueryParameter();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.SubBand1 = new DevExpress.XtraReports.UI.SubBand();
            this.xrSubreport5 = new DevExpress.XtraReports.UI.XRSubreport();
            this.AgencyCode = new DevExpress.XtraReports.Parameters.Parameter();
            this.BlackAndWhite = new DevExpress.XtraReports.Parameters.Parameter();
            this.LanguageId = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrSubreport1 = new DevExpress.XtraReports.UI.XRSubreport();
            this.SubBand2 = new DevExpress.XtraReports.UI.SubBand();
            this.xrSubreport7 = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrSubreport6 = new DevExpress.XtraReports.UI.XRSubreport();
            this.Top = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.WireTransac = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailCaption3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailCaptionBackground3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.FirstSecond = new DevExpress.XtraReports.UI.CalculatedField();
            this.FormName = new DevExpress.XtraReports.Parameters.Parameter();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabelExtension();
            this.xrPictureBox2 = new DevExpress.XtraReports.UI.PictureBoxExtension();
            this.lanRule = new DevExpress.XtraReports.UI.FormattingRule();
            this.xrPictureBox3 = new DevExpress.XtraReports.UI.PictureBoxExtension();
            this.imxrule = new DevExpress.XtraReports.UI.FormattingRule();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 0F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand1,
            this.SubBand2});
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // SubBand1
            // 
            this.SubBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreport5,
            this.xrSubreport1});
            this.SubBand1.HeightF = 117.17F;
            this.SubBand1.Name = "SubBand1";
            // 
            // xrSubreport5
            // 
            this.xrSubreport5.LocationFloat = new DevExpress.Utils.PointFloat(0.000406901F, 0F);
            this.xrSubreport5.Name = "xrSubreport5";
            this.xrSubreport5.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgencyCode", this.AgencyCode));
            this.xrSubreport5.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("ListCountries", null, "Agencies_GetBestCountriesByWires.FirstCountry"));
            this.xrSubreport5.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("BlackAndWhite", this.BlackAndWhite));
            this.xrSubreport5.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LaguageId", this.LanguageId));
            this.xrSubreport5.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Color", null, "GetAgencyCompanyInfo.ReportColorForeground"));
            this.xrSubreport5.ReportSource = new WebAPIReports.Reports.FXFAX.FxFaxByCountry();
            this.xrSubreport5.SizeF = new System.Drawing.SizeF(380.45F, 117.17F);
            // 
            // AgencyCode
            // 
            this.AgencyCode.Name = "AgencyCode";
            this.AgencyCode.ValueInfo = "fl-1992";
            this.AgencyCode.Visible = false;
            // 
            // BlackAndWhite
            // 
            this.BlackAndWhite.Description = "Parameter1";
            this.BlackAndWhite.Name = "BlackAndWhite";
            this.BlackAndWhite.Type = typeof(bool);
            this.BlackAndWhite.ValueInfo = "False";
            this.BlackAndWhite.Visible = false;
            // 
            // LanguageId
            // 
            this.LanguageId.Description = "LanguageId";
            this.LanguageId.Name = "LanguageId";
            this.LanguageId.Type = typeof(int);
            this.LanguageId.ValueInfo = "1";
            this.LanguageId.Visible = false;
            // 
            // xrSubreport1
            // 
            this.xrSubreport1.LocationFloat = new DevExpress.Utils.PointFloat(387.4502F, 0F);
            this.xrSubreport1.Name = "xrSubreport1";
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgencyCode", this.AgencyCode));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("ListCountries", null, "Agencies_GetBestCountriesByWires.SecondCountry"));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("BlackAndWhite", this.BlackAndWhite));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LaguageId", this.LanguageId));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Color", null, "GetAgencyCompanyInfo.ReportColorForeground"));
            this.xrSubreport1.ReportSource = new WebAPIReports.Reports.FXFAX.FxFaxByCountry();
            this.xrSubreport1.SizeF = new System.Drawing.SizeF(373.55F, 117.17F);
            // 
            // SubBand2
            // 
            this.SubBand2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreport7,
            this.xrSubreport6});
            this.SubBand2.HeightF = 80.16658F;
            this.SubBand2.Name = "SubBand2";
            // 
            // xrSubreport7
            // 
            this.xrSubreport7.LocationFloat = new DevExpress.Utils.PointFloat(0.000406901F, 39.66665F);
            this.xrSubreport7.Name = "xrSubreport7";
            this.xrSubreport7.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("HeaderLabel", null, "MultiLangLabels.AgFaxUSDCountries"));
            this.xrSubreport7.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("BlackAndWhite", this.BlackAndWhite));
            this.xrSubreport7.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgencyCode", this.AgencyCode));
            this.xrSubreport7.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Color", null, "GetAgencyCompanyInfo.ReportColorForeground"));
            this.xrSubreport7.ReportSource = new WebAPIReports.Reports.FXFAX.FxFaxUSDCountries();
            this.xrSubreport7.SizeF = new System.Drawing.SizeF(760.9999F, 40.49993F);
            // 
            // xrSubreport6
            // 
            this.xrSubreport6.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrSubreport6.Name = "xrSubreport6";
            this.xrSubreport6.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgencyCode", this.AgencyCode));
            this.xrSubreport6.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("ListCountries", null, "Agencies_GetBestCountriesByWires.OtherCountry"));
            this.xrSubreport6.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("NoListCountries", null, "Agencies_GetBestCountriesByWires.FirstSecond"));
            this.xrSubreport6.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("CountryLabel", null, "MultiLangLabels.Country"));
            this.xrSubreport6.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("PayerLabel", null, "MultiLangLabels.Payer"));
            this.xrSubreport6.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("RateTypeLabel", null, "MultiLangLabels.RateType"));
            this.xrSubreport6.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("OtherCountryLabel", null, "MultiLangLabels.AgFaxOtherCountries"));
            this.xrSubreport6.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("BlackAndWhite", this.BlackAndWhite));
            this.xrSubreport6.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LanguageId", this.LanguageId));
            this.xrSubreport6.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Top", this.Top));
            this.xrSubreport6.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Color", null, "GetAgencyCompanyInfo.ReportColorForeground"));
            this.xrSubreport6.ReportSource = new WebAPIReports.Reports.FXFAX.FxFaxOtherCountries();
            this.xrSubreport6.SizeF = new System.Drawing.SizeF(760.9999F, 39.66665F);
            // 
            // Top
            // 
            this.Top.Description = "Top";
            this.Top.Name = "Top";
            this.Top.Type = typeof(short);
            this.Top.ValueInfo = "8";
            this.Top.Visible = false;
            // 
            // xrLabel3
            // 
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", resources.GetString("xrLabel3.ExpressionBindings"))});
            this.xrLabel3.Font = new System.Drawing.Font("Calibri", 9F);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(0.0002034505F, 0F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(760.9999F, 23F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "xrLabel3";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel6
            // 
            this.xrLabel6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Upper([MultiLangLabels].[AgFaxTitle])")});
            this.xrLabel6.Font = new System.Drawing.Font("Calibri", 16F);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(387.4502F, 34.12122F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(328.3834F, 32.33332F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "xrLabel2";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 0.8333333F;
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
            // WireTransac
            // 
            this.WireTransac.ConnectionName = "WireTransacConn";
            this.WireTransac.ConnectionOptions.CommandTimeout = 300;
            this.WireTransac.ConnectionOptions.DbCommandTimeout = 300;
            this.WireTransac.Name = "WireTransac";
            storedProcQuery1.Name = "Agencies_GetBestCountriesByWires";
            queryParameter1.Name = "@AgencyCode";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.AgencyCode]", typeof(string));
            queryParameter2.Name = "@TopCountries";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.Top]", typeof(short));
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.Parameters.Add(queryParameter2);
            storedProcQuery1.StoredProcName = "Agencies_GetBestCountriesByWires";
            storedProcQuery2.Name = "MultiLangLabels";
            queryParameter3.Name = "@LanguageId";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("[Parameters.LanguageId]", typeof(int));
            queryParameter4.Name = "@FormName";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("[Parameters.FormName]", typeof(string));
            storedProcQuery2.Parameters.Add(queryParameter3);
            storedProcQuery2.Parameters.Add(queryParameter4);
            storedProcQuery2.StoredProcName = "ConvertRowsInColumns_MultiLangLabels";
            storedProcQuery3.Name = "GetAgencyCompanyInfo";
            queryParameter5.Name = "@AgencyCode";
            queryParameter5.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter5.Value = new DevExpress.DataAccess.Expression("[Parameters.AgencyCode]", typeof(string));
            storedProcQuery3.Parameters.Add(queryParameter5);
            storedProcQuery3.StoredProcName = "GetAgencyCompanyInfo";
            this.WireTransac.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1,
            storedProcQuery2,
            storedProcQuery3});
            this.WireTransac.ResultSchemaSerializable = resources.GetString("WireTransac.ResultSchemaSerializable");
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            //this.Title.BorderColor = System.Drawing.Color.Black;
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Title.BorderWidth = 1F;
            this.Title.Font = new System.Drawing.Font("Calibri", 14F);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.Title.Name = "Title";
            // 
            // DetailCaption3
            // 
            this.DetailCaption3.BackColor = System.Drawing.Color.Transparent;
            this.DetailCaption3.BorderColor = System.Drawing.Color.Transparent;
            this.DetailCaption3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DetailCaption3.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.DetailCaption3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.DetailCaption3.Name = "DetailCaption3";
            this.DetailCaption3.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailCaption3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData3
            // 
            this.DetailData3.Font = new System.Drawing.Font("Calibri", 8F);
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
            this.DetailData3_Odd.Font = new System.Drawing.Font("Calibri", 8F);
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
            this.PageInfo.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.PageInfo.Name = "PageInfo";
            this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // FirstSecond
            // 
            this.FirstSecond.DataMember = "Agencies_GetBestCountriesByWires";
            this.FirstSecond.Expression = "[FirstCountry] + \',\' + [SecondCountry]";
            this.FirstSecond.Name = "FirstSecond";
            // 
            // FormName
            // 
            this.FormName.Description = "FormName";
            this.FormName.Name = "FormName";
            this.FormName.ValueInfo = "Report.Pricing.RepPrcPayerFXFAXToAgencies";
            this.FormName.Visible = false;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel8,
            this.xrLabel6,
            this.xrPictureBox2,
            this.xrPictureBox3});
            this.GroupHeader1.HeightF = 75.06566F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrLabel8
            // 
            //this.xrLabel8.BorderColor = System.Drawing.Color.Black;
            this.xrLabel8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("BackColor", null, "GetAgencyCompanyInfo.ReportColorForeground")});
            this.xrLabel8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MultiLangLabels].[AgFaxHeader] \n+ Char(13)\n+ [AgencyName]")});
            this.xrLabel8.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.xrLabel8.ForeColor = System.Drawing.Color.White;
            this.xrLabel8.HexaForeColor = null;
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel8.Multiline = true;
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 8, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(760.9999F, 27.99999F);
            this.xrLabel8.StylePriority.UseBackColor = false;
            this.xrLabel8.StylePriority.UseBorderColor = false;
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseForeColor = false;
            this.xrLabel8.StylePriority.UsePadding = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "HeaderLabel";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrLabel8.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.xrLabel1_PrintOnPage);
            // 
            // xrPictureBox2
            // 
            this.xrPictureBox2.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom;
            this.xrPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.xrPictureBox2.BGColor = null;
            this.xrPictureBox2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Logo", null, "GetAgencyCompanyInfo.Logo3Binary")});
            this.xrPictureBox2.FormattingRules.Add(this.lanRule);
            this.xrPictureBox2.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter;
            this.xrPictureBox2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 15.6755F);
            this.xrPictureBox2.Logo = null;
            this.xrPictureBox2.Name = "xrPictureBox2";
            this.xrPictureBox2.SizeF = new System.Drawing.SizeF(340F, 55F);
            this.xrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
            this.xrPictureBox2.Visible = false;
            // 
            // lanRule
            // 
            this.lanRule.DataMember = "GetAgencyCompanyInfo";
            this.lanRule.Formatting.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.lanRule.Name = "lanRule";
            // 
            // xrPictureBox3
            // 
            this.xrPictureBox3.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom;
            this.xrPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.xrPictureBox3.BGColor = null;
            this.xrPictureBox3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Logo", null, "GetAgencyCompanyInfo.Logo1Binary")});
            this.xrPictureBox3.FormattingRules.Add(this.imxrule);
            this.xrPictureBox3.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter;
            this.xrPictureBox3.LocationFloat = new DevExpress.Utils.PointFloat(10.00041F, 20.06565F);
            this.xrPictureBox3.Logo = null;
            this.xrPictureBox3.Name = "xrPictureBox3";
            this.xrPictureBox3.SizeF = new System.Drawing.SizeF(250F, 55F);
            this.xrPictureBox3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
            this.xrPictureBox3.Visible = false;
            // 
            // imxrule
            // 
            this.imxrule.DataMember = "GetAgencyCompanyInfo";
            this.imxrule.Formatting.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.imxrule.Name = "imxrule";
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3});
            this.GroupFooter1.HeightF = 23F;
            this.GroupFooter1.Name = "GroupFooter1";
            // 
            // ExchangeRateReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader1,
            this.GroupFooter1});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.FirstSecond});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.WireTransac});
            this.DataMember = "Agencies_GetBestCountriesByWires";
            this.DataSource = this.WireTransac;
            this.FormattingRuleSheet.AddRange(new DevExpress.XtraReports.UI.FormattingRule[] {
            this.imxrule,
            this.lanRule});
            this.Margins = new System.Drawing.Printing.Margins(40, 49, 1, 0);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.AgencyCode,
            this.Top,
            this.LanguageId,
            this.FormName,
            this.BlackAndWhite});
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailCaption3,
            this.DetailData3,
            this.DetailData3_Odd,
            this.DetailCaptionBackground3,
            this.PageInfo});
            this.Version = "18.1";
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.FxFaxMain_DataSourceDemanded);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.DataAccess.Sql.SqlDataSource WireTransac;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle DetailCaption3;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData3;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
        private DevExpress.XtraReports.UI.XRControlStyle DetailCaptionBackground3;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.Parameters.Parameter AgencyCode;
        private DevExpress.XtraReports.Parameters.Parameter Top;
        private DevExpress.XtraReports.UI.CalculatedField FirstSecond;
        private DevExpress.XtraReports.Parameters.Parameter LanguageId;
        private DevExpress.XtraReports.Parameters.Parameter FormName;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.Parameters.Parameter BlackAndWhite;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport7;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabelExtension xrLabel8;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport5;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.SubBand SubBand1;
        private DevExpress.XtraReports.UI.SubBand SubBand2;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport1;
        private PictureBoxExtension xrPictureBox2;
        private FormattingRule imxrule;
        private FormattingRule lanRule;
        private PictureBoxExtension xrPictureBox3;
    }
}
