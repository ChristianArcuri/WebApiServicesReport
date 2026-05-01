namespace WebAPIReports.Reports.PartnerInvoiceProcFee
{
    partial class PartnerInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartnerInvoice));
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.WirePaid = new DevExpress.XtraReports.UI.SubBand();
            this.BlackAndWhite = new DevExpress.XtraReports.Parameters.Parameter();
            this.PartnerCommissionId = new DevExpress.XtraReports.Parameters.Parameter();
            this.BankCharges = new DevExpress.XtraReports.UI.SubBand();
            this.ChargeBack = new DevExpress.XtraReports.UI.SubBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine4 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.WireTransac = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.calcLEInfo = new DevExpress.XtraReports.UI.CalculatedField();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrPanel2 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow10 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell50 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell53 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.calcPartnerAddress = new DevExpress.XtraReports.UI.CalculatedField();
            this.calcTotalReferralFee = new DevExpress.XtraReports.UI.CalculatedField();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
            this.LanguageId = new DevExpress.XtraReports.Parameters.Parameter();
            this.FormName = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrWP = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrBC = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrChB = new DevExpress.XtraReports.UI.XRSubreport();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 0F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.WirePaid,
            this.BankCharges,
            this.ChargeBack});
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // WirePaid
            // 
            this.WirePaid.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrWP});
            this.WirePaid.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Iif([Header].[WPQty] > 0, True, False)")});
            this.WirePaid.HeightF = 37.58332F;
            this.WirePaid.Name = "WirePaid";
            // 
            // BlackAndWhite
            // 
            this.BlackAndWhite.Description = "Parameter1";
            this.BlackAndWhite.Name = "BlackAndWhite";
            this.BlackAndWhite.Type = typeof(bool);
            this.BlackAndWhite.ValueInfo = "False";
            this.BlackAndWhite.Visible = false;
            // 
            // PartnerCommissionId
            // 
            this.PartnerCommissionId.Description = "Parameter1";
            this.PartnerCommissionId.Name = "PartnerCommissionId";
            this.PartnerCommissionId.Type = typeof(int);
            this.PartnerCommissionId.ValueInfo = "7";
            this.PartnerCommissionId.Visible = false;
            // 
            // BankCharges
            // 
            this.BankCharges.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBC});
            this.BankCharges.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Iif([Header].[BCQty] > 0, True, False)")});
            this.BankCharges.HeightF = 39.66662F;
            this.BankCharges.Name = "BankCharges";
            // 
            // ChargeBack
            // 
            this.ChargeBack.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrChB});
            this.ChargeBack.HeightF = 39.58333F;
            this.ChargeBack.Name = "ChargeBack";
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox1,
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel13,
            this.xrLabel12,
            this.xrLabel11,
            this.xrLabel10,
            this.xrLine4,
            this.xrLabel2,
            this.xrLine2,
            this.xrLine1});
            this.TopMargin.HeightF = 142F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(10.00002F, 43.16667F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(329.1667F, 56F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xrLabel5
            // 
            this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[PartnerCommissionId]")});
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(113.5416F, 115.8333F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(100F, 18.00003F);
            this.xrLabel5.Text = "xrLabel5";
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(28.54166F, 115.8333F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(85F, 18F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "ID:";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel13
            // 
            this.xrLabel13.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MultiLangLabels].[To]+ \':\'")});
            this.xrLabel13.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(635.5829F, 115.8333F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(84F, 18F);
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.Text = "To:";
            this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel12
            // 
            this.xrLabel12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MultiLangLabels].[From] + \':\'")});
            this.xrLabel12.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(370.5832F, 115.8333F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(85F, 18F);
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel11
            // 
            this.xrLabel11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Header].[ToDate]")});
            this.xrLabel11.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(724.1246F, 115.8333F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(100F, 18F);
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.Text = "xrLabel11";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrLabel11.TextFormatString = "{0:MM/dd/yy}";
            // 
            // xrLabel10
            // 
            this.xrLabel10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Header].[FromDate]")});
            this.xrLabel10.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(459.1249F, 115.8333F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(100F, 18F);
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.Text = "xrLabel10";
            this.xrLabel10.TextFormatString = "{0:MM/dd/yy}";
            // 
            // xrLine4
            // 
            this.xrLine4.BorderColor = System.Drawing.Color.Black;
            this.xrLine4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ForeColor", "Iif([Parameters].[BlackAndWhite], \'Black\',\'#ff5fb341\')")});
            this.xrLine4.ForeColor = System.Drawing.Color.Black;
            this.xrLine4.LineWidth = 2;
            this.xrLine4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 133.8333F);
            this.xrLine4.Name = "xrLine4";
            this.xrLine4.SizeF = new System.Drawing.SizeF(1040F, 6.000015F);
            this.xrLine4.StylePriority.UseBorderColor = false;
            this.xrLine4.StylePriority.UseForeColor = false;
            // 
            // xrLabel2
            // 
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Header].[calcLEInfo]")});
            this.xrLabel2.Font = new System.Drawing.Font("Open Sans", 10F);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(744.8332F, 31.33334F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(295.1668F, 77.08335F);
            this.xrLabel2.StylePriority.UseFont = false;
            // 
            // xrLine2
            // 
            this.xrLine2.BorderColor = System.Drawing.Color.Black;
            this.xrLine2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ForeColor", "Iif([Parameters].[BlackAndWhite], \'Black\',\'#ff5fb341\')")});
            this.xrLine2.ForeColor = System.Drawing.Color.Black;
            this.xrLine2.LineWidth = 2;
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 108.4167F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(1040F, 6.000008F);
            this.xrLine2.StylePriority.UseBorderColor = false;
            this.xrLine2.StylePriority.UseForeColor = false;
            // 
            // xrLine1
            // 
            this.xrLine1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ForeColor", "Iif([Parameters].[BlackAndWhite], \'Black\',\'#ff5fb341\')")});
            this.xrLine1.ForeColor = System.Drawing.Color.Black;
            this.xrLine1.LineWidth = 10;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 20.83333F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(1040F, 10.5F);
            this.xrLine1.StylePriority.UseForeColor = false;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 8F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // WireTransac
            // 
            this.WireTransac.ConnectionName = "WireTransacConn";
            this.WireTransac.Name = "WireTransac";
            storedProcQuery1.Name = "Header";
            queryParameter1.Name = "@PartnerCommissionId";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.PartnerCommissionId]", typeof(int));
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.StoredProcName = "Acc_Partner_ProcFee_Invoice_Header";
            storedProcQuery2.Name = "MultiLangLabels";
            queryParameter2.Name = "@LanguageId";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.LanguageId]", typeof(int));
            queryParameter3.Name = "@FormName";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("[Parameters.FormName]", typeof(string));
            storedProcQuery2.Parameters.Add(queryParameter2);
            storedProcQuery2.Parameters.Add(queryParameter3);
            storedProcQuery2.StoredProcName = "Acc_Partner_ProcFee_MultiLangLabels";
            this.WireTransac.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1,
            storedProcQuery2});
            this.WireTransac.ResultSchemaSerializable = resources.GetString("WireTransac.ResultSchemaSerializable");
            // 
            // xrLabel1
            // 
            this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Header].[PartnerLegalName]")});
            this.xrLabel1.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(9.999974F, 10.00001F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(308.9583F, 23F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "xrLabel1";
            // 
            // calcLEInfo
            // 
            this.calcLEInfo.DataMember = "Header";
            this.calcLEInfo.Expression = "[LEName]\n+Char(13)\n+ [LEAddress]\n+ Char(13)\n+ [LECity] + \', \' + [LEState] + \' \' +" +
    " [LEZip]\n+ Char(13)\n+ [LECountry]";
            this.calcLEInfo.Name = "calcLEInfo";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel1,
            this.xrLabel7,
            this.xrLabel6,
            this.xrLabel3,
            this.xrLabel1});
            this.GroupHeader1.HeightF = 189.375F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrPanel1
            // 
            this.xrPanel1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPanel1.BorderWidth = 2F;
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel2,
            this.xrTable2});
            this.xrPanel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "BorderColor", "Iif([Parameters].[BlackAndWhite], \'Black\',\'#ff5fb341\')")});
            this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(619.6247F, 10.00001F);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.SizeF = new System.Drawing.SizeF(410.3752F, 172.5F);
            this.xrPanel1.StylePriority.UseBorders = false;
            this.xrPanel1.StylePriority.UseBorderWidth = false;
            // 
            // xrPanel2
            // 
            this.xrPanel2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPanel2.BorderWidth = 2F;
            this.xrPanel2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel9,
            this.xrLabel8});
            this.xrPanel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "BorderColor", "Iif([Parameters].[BlackAndWhite], \'Black\',\'#ff5fb341\')")});
            this.xrPanel2.LocationFloat = new DevExpress.Utils.PointFloat(5.999947F, 133.6666F);
            this.xrPanel2.Name = "xrPanel2";
            this.xrPanel2.SizeF = new System.Drawing.SizeF(397F, 32.99998F);
            this.xrPanel2.StylePriority.UseBorders = false;
            this.xrPanel2.StylePriority.UseBorderWidth = false;
            // 
            // xrLabel9
            // 
            this.xrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Header].[calcTotalReferralFee]")});
            this.xrLabel9.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(219.6248F, 6.999969F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(160.7503F, 23F);
            this.xrLabel9.StylePriority.UseBorders = false;
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "xrLabel9";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel9.TextFormatString = "{0:$#,##0.00}";
            // 
            // xrLabel8
            // 
            this.xrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "\'Total \' + [MultiLangLabels].[ReferralFee]")});
            this.xrLabel8.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(9.999847F, 6.999969F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(184.4999F, 23F);
            this.xrLabel8.StylePriority.UseBorders = false;
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.Text = "Total Referral Fee";
            // 
            // xrTable2
            // 
            this.xrTable2.Font = new System.Drawing.Font("Open Sans", 9F);
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(6F, 4F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2,
            this.xrTableRow4,
            this.xrTableRow10,
            this.xrTableRow1});
            this.xrTable2.SizeF = new System.Drawing.SizeF(394.3752F, 100F);
            this.xrTable2.StylePriority.UseFont = false;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell7});
            this.xrTableRow2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "BorderColor", "Iif([Parameters].[BlackAndWhite], \'Black\',\'#ff5fb341\')")});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.BorderColor = System.Drawing.Color.Silver;
            this.xrTableCell4.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableCell4.BorderWidth = 1F;
            this.xrTableCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "BorderColor", "Iif([Parameters].[BlackAndWhite], \'Black\',\'#ff5fb341\')")});
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell4.StylePriority.UseBorderColor = false;
            this.xrTableCell4.StylePriority.UseBorders = false;
            this.xrTableCell4.StylePriority.UseBorderWidth = false;
            this.xrTableCell4.Weight = 1.7313180142265723D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.BorderColor = System.Drawing.Color.Silver;
            this.xrTableCell5.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableCell5.BorderWidth = 1F;
            this.xrTableCell5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MultiLangLabels].[Qty]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "BorderColor", "Iif([Parameters].[BlackAndWhite], \'Black\',\'#ff5fb341\')")});
            this.xrTableCell5.Font = new System.Drawing.Font("Open Sans", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell5.StylePriority.UseBorderColor = false;
            this.xrTableCell5.StylePriority.UseBorders = false;
            this.xrTableCell5.StylePriority.UseBorderWidth = false;
            this.xrTableCell5.StylePriority.UseFont = false;
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            this.xrTableCell5.Text = "Qty";
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell5.Weight = 0.90890049470762169D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.BorderColor = System.Drawing.Color.Silver;
            this.xrTableCell7.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableCell7.BorderWidth = 1F;
            this.xrTableCell7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MultiLangLabels].[ReferralFee]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "BorderColor", "Iif([Parameters].[BlackAndWhite], \'Black\',\'#ff5fb341\')")});
            this.xrTableCell7.Font = new System.Drawing.Font("Open Sans", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell7.StylePriority.UseBorderColor = false;
            this.xrTableCell7.StylePriority.UseBorders = false;
            this.xrTableCell7.StylePriority.UseBorderWidth = false;
            this.xrTableCell7.StylePriority.UseFont = false;
            this.xrTableCell7.StylePriority.UsePadding = false;
            this.xrTableCell7.StylePriority.UseTextAlignment = false;
            this.xrTableCell7.Text = "Referral Fee";
            this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell7.Weight = 1.3333349732367759D;
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell8,
            this.xrTableCell9,
            this.xrTableCell11});
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.Weight = 1D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCell8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MultiLangLabels].[WiresPaid]")});
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell8.StylePriority.UseBorders = false;
            this.xrTableCell8.StylePriority.UsePadding = false;
            this.xrTableCell8.Text = "WP";
            this.xrTableCell8.Weight = 1.7313180142265723D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCell9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Header].[WPQty]")});
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell9.StylePriority.UseBorders = false;
            this.xrTableCell9.StylePriority.UsePadding = false;
            this.xrTableCell9.StylePriority.UseTextAlignment = false;
            this.xrTableCell9.Text = "xrTableCell9";
            this.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell9.TextFormatString = "{0:#,#}";
            this.xrTableCell9.Weight = 0.90890049470762169D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCell11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Header].[WPRF]")});
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell11.StylePriority.UseBorders = false;
            this.xrTableCell11.StylePriority.UsePadding = false;
            this.xrTableCell11.StylePriority.UseTextAlignment = false;
            this.xrTableCell11.Text = "xrTableCell11";
            this.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell11.TextFormatString = "{0:$#,##0.00}";
            this.xrTableCell11.Weight = 1.3333349732367759D;
            // 
            // xrTableRow10
            // 
            this.xrTableRow10.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell50,
            this.xrTableCell6,
            this.xrTableCell53});
            this.xrTableRow10.Name = "xrTableRow10";
            this.xrTableRow10.Weight = 1D;
            // 
            // xrTableCell50
            // 
            this.xrTableCell50.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCell50.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MultiLangLabels].[BankCharges]")});
            this.xrTableCell50.Name = "xrTableCell50";
            this.xrTableCell50.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell50.StylePriority.UseBorders = false;
            this.xrTableCell50.StylePriority.UsePadding = false;
            this.xrTableCell50.Text = "BC";
            this.xrTableCell50.Weight = 1.7313180142265723D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCell6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BCQty]")});
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell6.StylePriority.UseBorders = false;
            this.xrTableCell6.StylePriority.UsePadding = false;
            this.xrTableCell6.StylePriority.UseTextAlignment = false;
            this.xrTableCell6.Text = "xrTableCell6";
            this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell6.Weight = 0.90890104883835809D;
            // 
            // xrTableCell53
            // 
            this.xrTableCell53.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCell53.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Header].[BCRF]")});
            this.xrTableCell53.Name = "xrTableCell53";
            this.xrTableCell53.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell53.StylePriority.UseBorders = false;
            this.xrTableCell53.StylePriority.UsePadding = false;
            this.xrTableCell53.StylePriority.UseTextAlignment = false;
            this.xrTableCell53.Text = "xrTableCell53";
            this.xrTableCell53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell53.TextFormatString = "{0:$#,##0.00}";
            this.xrTableCell53.Weight = 1.3333344191060392D;
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
            this.xrTableCell1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCell1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MultiLangLabels].[ChargeBack]")});
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell1.StylePriority.UseBorders = false;
            this.xrTableCell1.StylePriority.UsePadding = false;
            this.xrTableCell1.Text = "xrTableCell1";
            this.xrTableCell1.Weight = 1.7313180142265723D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCell3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Header].[CBRF]")});
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell3.StylePriority.UseBorders = false;
            this.xrTableCell3.StylePriority.UsePadding = false;
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.Text = "xrTableCell3";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell3.TextFormatString = "{0:$#,##0.00}";
            this.xrTableCell3.Weight = 1.3333349571993147D;
            // 
            // xrLabel7
            // 
            this.xrLabel7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MultiLangLabels].[Phone] + \':\'")});
            this.xrLabel7.Font = new System.Drawing.Font("Open Sans", 9F);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(9.999974F, 96.875F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(72.91679F, 23F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.Text = "Phone:";
            // 
            // xrLabel6
            // 
            this.xrLabel6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Header].[PartnerPhone]")});
            this.xrLabel6.Font = new System.Drawing.Font("Open Sans", 9F);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(82.91677F, 96.875F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(236.0417F, 23F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.Text = "xrLabel6";
            // 
            // xrLabel3
            // 
            this.xrLabel3.CanShrink = true;
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Header].[calcPartnerAddress]")});
            this.xrLabel3.Font = new System.Drawing.Font("Open Sans", 9F);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(9.999974F, 33.00001F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(308.9583F, 63.87501F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.Text = "xrLabel3";
            // 
            // calcPartnerAddress
            // 
            this.calcPartnerAddress.DataMember = "Header";
            this.calcPartnerAddress.Expression = "[PartnerAddress] \n+ Char(13)\n+ [PartnerCity] + \', \' + [PartnerState] + \' \' + [Par" +
    "tnerZipCode]\n+ Char(13)\n+ [PartnerCountry]";
            this.calcPartnerAddress.Name = "calcPartnerAddress";
            // 
            // calcTotalReferralFee
            // 
            this.calcTotalReferralFee.DataMember = "Header";
            this.calcTotalReferralFee.Expression = "[WPRF] + [BCRF] + [CBRF]";
            this.calcTotalReferralFee.Name = "calcTotalReferralFee";
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1,
            this.xrLine3});
            this.PageFooter.HeightF = 38.54167F;
            this.PageFooter.Name = "PageFooter";
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Font = new System.Drawing.Font("Open Sans", 8F, System.Drawing.FontStyle.Bold);
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(930F, 15.5F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrPageInfo1.StylePriority.UseFont = false;
            this.xrPageInfo1.StylePriority.UseTextAlignment = false;
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLine3
            // 
            this.xrLine3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ForeColor", "Iif([Parameters].[BlackAndWhite], \'Black\',\'#ff5fb341\')")});
            this.xrLine3.ForeColor = System.Drawing.Color.Black;
            this.xrLine3.LineWidth = 10;
            this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 4.999987F);
            this.xrLine3.Name = "xrLine3";
            this.xrLine3.SizeF = new System.Drawing.SizeF(1040F, 10.5F);
            this.xrLine3.StylePriority.UseForeColor = false;
            // 
            // LanguageId
            // 
            this.LanguageId.Description = "Parameter1";
            this.LanguageId.Name = "LanguageId";
            this.LanguageId.Type = typeof(int);
            this.LanguageId.ValueInfo = "1";
            this.LanguageId.Visible = false;
            // 
            // FormName
            // 
            this.FormName.Description = "Parameter1";
            this.FormName.Name = "FormName";
            this.FormName.ValueInfo = "REPORT.ACCOUNTING.PARTNERINVOICEPROCCFEE";
            this.FormName.Visible = false;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTableCell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CBQty]")});
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell2.StylePriority.UseBorders = false;
            this.xrTableCell2.StylePriority.UsePadding = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.Text = "xrTableCell2";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell2.Weight = 0.90890051074508271D;
            // 
            // xrWP
            // 
            this.xrWP.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrWP.Name = "xrWP";
            this.xrWP.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("BlackAndWhite", this.BlackAndWhite));
            this.xrWP.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("PartnerCommissionId", this.PartnerCommissionId));
            this.xrWP.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Date", null, "MultiLangLabels.Date"));
            this.xrWP.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("UserId", null, "MultiLangLabels.UserId"));
            this.xrWP.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FromState", null, "MultiLangLabels.State"));
            this.xrWP.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("PaymentMethod", null, "MultiLangLabels.PaymentMethod"));
            this.xrWP.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Amount", null, "MultiLangLabels.Amount"));
            this.xrWP.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Charges", null, "MultiLangLabels.Charges"));
            this.xrWP.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FxGain", null, "MultiLangLabels.FxGain"));
            this.xrWP.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("ReferralFee", null, "MultiLangLabels.ReferralFee"));
            this.xrWP.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("WP", null, "MultiLangLabels.WiresPaid"));
            this.xrWP.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("DestCountry", null, "MultiLangLabels.DestCountry"));
            this.xrWP.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Discount", null, "MultiLangLabels.DiscountAmount"));
            this.xrWP.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("TotalRevenue", null, "MultiLangLabels.TotalRevenue"));
            this.xrWP.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("PayerCost", null, "MultiLangLabels.PayerCost"));
            this.xrWP.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("TotalCost", null, "MultiLangLabels.TotalCost"));
            this.xrWP.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("WLProcessingFee", null, "MultiLangLabels.WLProcessingFee"));
            this.xrWP.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("WLFraudReserve", null, "MultiLangLabels.WLFraudReserve"));
            this.xrWP.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Control", null, null));
            this.xrWP.ReportSource = new WebAPIReports.Reports.PartnerInvoiceProcFee.PartnerInvoiceWP();
            this.xrWP.SizeF = new System.Drawing.SizeF(1040F, 23F);
            // 
            // xrBC
            // 
            this.xrBC.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrBC.Name = "xrBC";
            this.xrBC.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("BlackAndWhite", this.BlackAndWhite));
            this.xrBC.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("PartnerCommissionId", this.PartnerCommissionId));
            this.xrBC.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("BC", null, "MultiLangLabels.BankCharges"));
            this.xrBC.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Date", null, "MultiLangLabels.Date"));
            this.xrBC.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Description", null, "MultiLangLabels.Description"));
            this.xrBC.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("ReferralFee", null, "MultiLangLabels.ReferralFee"));
            this.xrBC.ReportSource = new WebAPIReports.Reports.PartnerInvoiceProcFee.PartnerInvoiceBC();
            this.xrBC.SizeF = new System.Drawing.SizeF(1040F, 23F);
            // 
            // xrChB
            // 
            this.xrChB.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrChB.Name = "xrChB";
            this.xrChB.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("PartnerCommissionId", this.PartnerCommissionId));
            this.xrChB.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("BlackAndWhite", this.BlackAndWhite));
            this.xrChB.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Date", null, "MultiLangLabels.Date"));
            this.xrChB.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Control", null, null));
            this.xrChB.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("UserId", null, "MultiLangLabels.UserId"));
            this.xrChB.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FromState", null, "MultiLangLabels.State"));
            this.xrChB.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("PaymentMethod", null, "MultiLangLabels.PaymentMethod"));
            this.xrChB.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Amount", null, "MultiLangLabels.Amount"));
            this.xrChB.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Charges", null, "MultiLangLabels.Charges"));
            this.xrChB.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FxGain", null, "MultiLangLabels.FxGain"));
            this.xrChB.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("ReferralFee", null, "MultiLangLabels.ReferralFee"));
            this.xrChB.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Reason", null, "MultiLangLabels.Reason"));
            this.xrChB.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("DestCountry", null, "MultiLangLabels.DestCountry"));
            this.xrChB.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("ChB", null, "MultiLangLabels.ChargeBack"));
            this.xrChB.ReportSource = new WebAPIReports.Reports.PartnerInvoiceProcFee.PartnerInvoiceChB();
            this.xrChB.SizeF = new System.Drawing.SizeF(1040F, 23F);
            // 
            // PartnerInvoice
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader1,
            this.PageFooter});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.calcLEInfo,
            this.calcPartnerAddress,
            this.calcTotalReferralFee});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.WireTransac});
            this.DataMember = "Header";
            this.DataSource = this.WireTransac;
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(36, 24, 142, 8);
            this.PageHeight = 850;
            this.PageWidth = 1100;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.PartnerCommissionId,
            this.BlackAndWhite,
            this.LanguageId,
            this.FormName});
            this.ShowPrintMarginsWarning = false;
            this.Version = "17.2";
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.PartnerInvoice_DataSourceDemanded);
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLine xrLine2;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.Parameters.Parameter PartnerCommissionId;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.CalculatedField calcLEInfo;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.CalculatedField calcPartnerAddress;
        private DevExpress.XtraReports.UI.XRPanel xrPanel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell9;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell11;
        private DevExpress.XtraReports.UI.CalculatedField calcTotalReferralFee;
        private DevExpress.XtraReports.UI.XRPanel xrPanel2;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.XRLine xrLine3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel13;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRLine xrLine4;
        private DevExpress.XtraReports.Parameters.Parameter BlackAndWhite;
        private DevExpress.XtraReports.Parameters.Parameter LanguageId;
        private DevExpress.XtraReports.Parameters.Parameter FormName;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow10;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell50;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell53;
        private DevExpress.XtraReports.UI.SubBand WirePaid;
        private DevExpress.XtraReports.UI.SubBand BankCharges;
        public DevExpress.DataAccess.Sql.SqlDataSource WireTransac;
        private DevExpress.XtraReports.UI.XRSubreport xrWP;
        private DevExpress.XtraReports.UI.XRSubreport xrBC;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.SubBand ChargeBack;
        private DevExpress.XtraReports.UI.XRSubreport xrChB;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
    }
}
