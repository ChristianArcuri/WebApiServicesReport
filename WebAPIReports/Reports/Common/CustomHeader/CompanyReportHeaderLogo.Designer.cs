namespace WebAPIReports.Reports.Common.CustomHeader
{
    partial class CompanyReportHeaderLogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyReportHeaderLogo));
            this.DataSourceCompanyReportHeader = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrPictureBox2 = new DevExpress.XtraReports.UI.PictureBoxExtension();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.PictureBoxExtension();
            this.Logo2Visible = new DevExpress.XtraReports.UI.FormattingRule();
            this.Logo1Visible = new DevExpress.XtraReports.UI.FormattingRule();
            this.AgencyCode = new DevExpress.XtraReports.Parameters.Parameter();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
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
            this.xrPictureBox2,
            this.xrPictureBox1});
            this.Detail.Font = new System.Drawing.Font("Calibri", 10F);
            this.Detail.HeightF = 57.7388F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("AgencyCode", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.Detail.StylePriority.UseBorderWidth = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPictureBox2
            // 
            this.xrPictureBox2.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom;
            this.xrPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.xrPictureBox2.BGColor = null;
            this.xrPictureBox2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("BGColor", null, "GetAgencyCompanyInfo(@AgencyCode).ReportColorBackground"),
            new DevExpress.XtraReports.UI.XRBinding("Logo", null, "GetAgencyCompanyInfo(@AgencyCode).Logo2Binary")});
            this.xrPictureBox2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPictureBox2.Logo = null;
            this.xrPictureBox2.Name = "xrPictureBox2";
            this.xrPictureBox2.SizeF = new System.Drawing.SizeF(230F, 57F); 
            this.xrPictureBox2.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter;
            this.xrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
            this.xrPictureBox2.Visible = false;
            this.xrPictureBox2.FormattingRules.Add(this.Logo2Visible);

            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.xrPictureBox1.BGColor = null;
            this.xrPictureBox1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("BGColor", null, "GetAgencyCompanyInfo(@AgencyCode).ReportColorBackground"),
            new DevExpress.XtraReports.UI.XRBinding("Logo", null, "GetAgencyCompanyInfo(@AgencyCode).Logo1Binary")});
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPictureBox1.Logo = null;
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(230F, 57F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.xrPictureBox1.Visible = false;
            this.xrPictureBox1.FormattingRules.Add(this.Logo1Visible);

            // 
            // Logo2Visible
            // 
            this.Logo2Visible.Condition = "IsNullOrEmpty([ReportColorBackground])";
            this.Logo2Visible.Formatting.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.Logo2Visible.Name = "Logo2Visible";
            // 
            // Logo1Visible
            // 
            this.Logo1Visible.Condition = "Not IsNullOrEmpty([ReportColorBackground])";
            this.Logo1Visible.Formatting.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.Logo1Visible.Name = "Logo1Visible";
            // 
            // AgencyCode
            // 
            this.AgencyCode.Name = "AgencyCode";
            this.AgencyCode.ValueInfo = "FL1000";
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
            // CompanyReportHeaderLogo
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.DataSourceCompanyReportHeader});
            this.DataMember = "GetAgencyCompanyInfo(@AgencyCode)";
            this.DataSource = this.DataSourceCompanyReportHeader;
            this.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormattingRuleSheet.AddRange(new DevExpress.XtraReports.UI.FormattingRule[] {
            this.Logo1Visible,
            this.Logo2Visible});
            this.Margins = new System.Drawing.Printing.Margins(0, 618, 0, 0);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.AgencyCode});
            this.ShowPrintMarginsWarning = false;
            this.Version = "18.1";
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.CompanyReportHeader_DataSourceDemanded);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.Parameters.Parameter AgencyCode;
        private DevExpress.DataAccess.Sql.SqlDataSource DataSourceCompanyReportHeader;
        private DevExpress.XtraReports.UI.PictureBoxExtension xrPictureBox2;
        private DevExpress.XtraReports.UI.PictureBoxExtension xrPictureBox1;
        private DevExpress.XtraReports.UI.FormattingRule Logo1Visible;
        private DevExpress.XtraReports.UI.FormattingRule Logo2Visible;
    }
}
