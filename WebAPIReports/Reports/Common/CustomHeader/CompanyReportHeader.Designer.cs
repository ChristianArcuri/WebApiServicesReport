namespace WebAPIReports.Reports.Common.CustomHeader
{
    partial class CompanyReportHeader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyReportHeader));
            this.DataSourceCompanyReportHeader = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.AgencyCode = new DevExpress.XtraReports.Parameters.Parameter();
            this.Logo2Visible = new DevExpress.XtraReports.UI.FormattingRule();
            this.Logo1Visible = new DevExpress.XtraReports.UI.FormattingRule();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.IsLandscape = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrSubreporHeaderCustom = new DevExpress.XtraReports.UI.XRSubreport();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // DataSourceCompanyReportHeader
            // 
            this.DataSourceCompanyReportHeader.ConnectionName = "WireTransacConn";
            this.DataSourceCompanyReportHeader.Name = "DataSourceCompanyReportHeader";
            storedProcQuery1.Name = "GetAgencyCompanyInfo(@AgencyCode)";
            queryParameter1.Name = "@AgencyCode";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.AgencyCode]", typeof(string));
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.StoredProcName = "GetAgencyCompanyInfo";
            this.DataSourceCompanyReportHeader.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.DataSourceCompanyReportHeader.ResultSchemaSerializable = resources.GetString("DataSourceCompanyReportHeader.ResultSchemaSerializable");
            this.DataSourceCompanyReportHeader.ConfigureDataConnection += new DevExpress.DataAccess.Sql.ConfigureDataConnectionEventHandler(this.DataSourceCompanyReportHeader_ConfigureDataConnection);
            // 
            // Detail
            // 
            this.Detail.BorderWidth = 6F;
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1,
            this.xrSubreporHeaderCustom});
            this.Detail.Font = new System.Drawing.Font(ReportCommon.Font, 10F);
            this.Detail.HeightF = 78.57213F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("AgencyCode", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.Detail.StylePriority.UseBorderWidth = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Font = new System.Drawing.Font(ReportCommon.Font, 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(601F, 10.00001F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 4, 4, 4, 100F);
            this.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(229F, 27.95833F);
            this.xrPageInfo1.StylePriority.UseFont = false;
            this.xrPageInfo1.StylePriority.UsePadding = false;
            this.xrPageInfo1.StylePriority.UseTextAlignment = false;
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrPageInfo1.TextFormatString = "{0:MM/dd/yyyy HH:mm}";
            this.xrPageInfo1.WordWrap = false;
            // 
            // AgencyCode
            // 
            this.AgencyCode.Name = "AgencyCode";
            this.AgencyCode.ValueInfo = "FL1000";
            // 
            // Logo2Visible
            // 
            this.Logo2Visible.Condition = "IsNullOrEmpty([GetAgencyCompanyInfo(@AgencyCode)].[ReportColorBackground])";
            this.Logo2Visible.Formatting.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.Logo2Visible.Name = "Logo2Visible";
            // 
            // Logo1Visible
            // 
            this.Logo1Visible.Condition = "Not IsNullOrEmpty([GetAgencyCompanyInfo(@AgencyCode)].[ReportColorBackground])";
            this.Logo1Visible.Formatting.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.Logo1Visible.Name = "Logo1Visible";
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
            // IsLandscape
            // 
            this.IsLandscape.Description = "IsLandscape";
            this.IsLandscape.Name = "IsLandscape";
            this.IsLandscape.Type = typeof(bool);
            this.IsLandscape.ValueInfo = "False";
            this.IsLandscape.Visible = false;
            // 
            // xrSubreporHeaderCustom
            // 
            this.xrSubreporHeaderCustom.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10.00001F);
            this.xrSubreporHeaderCustom.Name = "xrSubreporHeaderCustom";
            this.xrSubreporHeaderCustom.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgencyCode", this.AgencyCode));
            this.xrSubreporHeaderCustom.ReportSource = new WebAPIReports.Reports.Common.CustomHeader.CompanyReportHeaderLogo();
            this.xrSubreporHeaderCustom.SizeF = new System.Drawing.SizeF(229F, 63.55833F);
            // 
            // CompanyReportHeader
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.DataSourceCompanyReportHeader});
            this.DataMember = "GetAgencyCompanyInfo(@AgencyCode)";
            this.DataSource = this.DataSourceCompanyReportHeader;
            this.DrawGrid = false;
            this.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormattingRuleSheet.AddRange(new DevExpress.XtraReports.UI.FormattingRule[] {
            this.Logo1Visible,
            this.Logo2Visible});
            this.Margins = new System.Drawing.Printing.Margins(10, 10, 10, 10);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.AgencyCode,
            this.IsLandscape});
            this.ShowPrintMarginsWarning = false;
            this.Version = "18.1";
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.CompanyReportHeader_DataSourceDemanded);
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.CompanyReportHeader_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.Parameters.Parameter AgencyCode;
        private DevExpress.DataAccess.Sql.SqlDataSource DataSourceCompanyReportHeader;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.FormattingRule Logo1Visible;
        private DevExpress.XtraReports.UI.FormattingRule Logo2Visible;
        private DevExpress.XtraReports.Parameters.Parameter IsLandscape;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreporHeaderCustom;
    }
}
