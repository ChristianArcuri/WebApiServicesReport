namespace WebAPIReports.Reports.PartnerInvoiceProcFee
{
    partial class PartnerInvoiceBC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartnerInvoiceBC));
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.WireTransac = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrTable5 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow11 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell54 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell58 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell63 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLine6 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable4 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell49 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLine5 = new DevExpress.XtraReports.UI.XRLine();
            this.BlackAndWhite = new DevExpress.XtraReports.Parameters.Parameter();
            this.PartnerCommissionId = new DevExpress.XtraReports.Parameters.Parameter();
            this.BC = new DevExpress.XtraReports.Parameters.Parameter();
            this.Date = new DevExpress.XtraReports.Parameters.Parameter();
            this.Description = new DevExpress.XtraReports.Parameters.Parameter();
            this.ReferralFee = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.Detail.HeightF = 16.66667F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable1
            // 
            this.xrTable1.Font = new System.Drawing.Font("Open Sans", 7.5F);
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(1036F, 16.66667F);
            this.xrTable1.StylePriority.UseFont = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell15,
            this.xrTableCell20});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 0.67999999999999994D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[RecordDate]")});
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell1.Text = "xrTableCell1";
            this.xrTableCell1.TextFormatString = "{0:MM/dd/yy}";
            this.xrTableCell1.Weight = 0.69060153777845446D;
            // 
            // xrTableCell15
            // 
            this.xrTableCell15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CostDescription]")});
            this.xrTableCell15.Name = "xrTableCell15";
            this.xrTableCell15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell15.StylePriority.UsePadding = false;
            this.xrTableCell15.Text = "xrTableCell15";
            this.xrTableCell15.Weight = 6.3525545992126364D;
            // 
            // xrTableCell20
            // 
            this.xrTableCell20.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ToBePaidToPartner]")});
            this.xrTableCell20.Name = "xrTableCell20";
            this.xrTableCell20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell20.StylePriority.UsePadding = false;
            this.xrTableCell20.StylePriority.UseTextAlignment = false;
            this.xrTableCell20.Text = "xrTableCell20";
            this.xrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell20.TextFormatString = "{0:$0.00}";
            this.xrTableCell20.Weight = 1.0725078481478105D;
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
            // WireTransac
            // 
            this.WireTransac.ConnectionName = "WireTransacConn";
            this.WireTransac.Name = "WireTransac";
            storedProcQuery1.Name = "Acc_Partner_Invoice_BankCharges";
            queryParameter1.Name = "@PartnerCommissionId";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.PartnerCommissionId]", typeof(int));
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.StoredProcName = "Acc_Partner_ProcFee_Invoice_BankCharges";
            this.WireTransac.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.WireTransac.ResultSchemaSerializable = resources.GetString("WireTransac.ResultSchemaSerializable");
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable5,
            this.xrLabel15});
            this.GroupHeader1.HeightF = 34.79166F;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.RepeatEveryPage = true;
            // 
            // xrTable5
            // 
            this.xrTable5.Font = new System.Drawing.Font("Open Sans", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.xrTable5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 17.79165F);
            this.xrTable5.Name = "xrTable5";
            this.xrTable5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow11});
            this.xrTable5.SizeF = new System.Drawing.SizeF(1036F, 17.00001F);
            this.xrTable5.StylePriority.UseFont = false;
            // 
            // xrTableRow11
            // 
            this.xrTableRow11.BorderColor = System.Drawing.Color.LightGray;
            this.xrTableRow11.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableRow11.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell54,
            this.xrTableCell58,
            this.xrTableCell63});
            this.xrTableRow11.Name = "xrTableRow11";
            this.xrTableRow11.StylePriority.UseBorderColor = false;
            this.xrTableRow11.StylePriority.UseBorders = false;
            this.xrTableRow11.Weight = 0.6799999999999996D;
            // 
            // xrTableCell54
            // 
            this.xrTableCell54.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[Date]")});
            this.xrTableCell54.Name = "xrTableCell54";
            this.xrTableCell54.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell54.Text = "Date";
            this.xrTableCell54.Weight = 0.64801804017559927D;
            // 
            // xrTableCell58
            // 
            this.xrTableCell58.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[Description]")});
            this.xrTableCell58.Name = "xrTableCell58";
            this.xrTableCell58.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell58.StylePriority.UsePadding = false;
            this.xrTableCell58.Text = "Description";
            this.xrTableCell58.Weight = 4.5739683136729541D;
            // 
            // xrTableCell63
            // 
            this.xrTableCell63.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[ReferralFee]")});
            this.xrTableCell63.Name = "xrTableCell63";
            this.xrTableCell63.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.xrTableCell63.StylePriority.UsePadding = false;
            this.xrTableCell63.StylePriority.UseTextAlignment = false;
            this.xrTableCell63.Text = "Referral Fee";
            this.xrTableCell63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell63.Weight = 2.3679536221090833D;
            // 
            // xrLabel15
            // 
            this.xrLabel15.BackColor = System.Drawing.Color.Black;
            this.xrLabel15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "BackColor", "Iif([Parameters].[BlackAndWhite], \'Black\',\'#ff5fb341\')"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Upper([Parameters].[BC])")});
            this.xrLabel15.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel15.ForeColor = System.Drawing.Color.White;
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0.7083575F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(1036F, 17.08F);
            this.xrLabel15.StylePriority.UseBackColor = false;
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.StylePriority.UseForeColor = false;
            this.xrLabel15.Text = "BC";
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine6,
            this.xrLabel5,
            this.xrLabel14,
            this.xrTable4,
            this.xrLine5});
            this.GroupFooter1.HeightF = 24.08333F;
            this.GroupFooter1.Name = "GroupFooter1";
            // 
            // xrLine6
            // 
            this.xrLine6.BorderColor = System.Drawing.Color.Silver;
            this.xrLine6.BorderWidth = 2F;
            this.xrLine6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ForeColor", "Iif([Parameters].[BlackAndWhite], \'Black\',\'#ff5fb341\')")});
            this.xrLine6.ForeColor = System.Drawing.Color.Silver;
            this.xrLine6.LocationFloat = new DevExpress.Utils.PointFloat(0.0003019969F, 21.99999F);
            this.xrLine6.Name = "xrLine6";
            this.xrLine6.SizeF = new System.Drawing.SizeF(1036F, 2.083334F);
            this.xrLine6.StylePriority.UseBorderColor = false;
            this.xrLine6.StylePriority.UseBorderWidth = false;
            this.xrLine6.StylePriority.UseForeColor = false;
            // 
            // xrLabel5
            // 
            this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumCount([Control])")});
            this.xrLabel5.Font = new System.Drawing.Font("Open Sans", 7.5F, System.Drawing.FontStyle.Bold);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(79.16698F, 3.000005F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(85.87495F, 18.00003F);
            this.xrLabel5.StylePriority.UseFont = false;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel5.Summary = xrSummary1;
            this.xrLabel5.Text = "xrLabel5";
            this.xrLabel5.Visible = false;
            // 
            // xrLabel14
            // 
            this.xrLabel14.Font = new System.Drawing.Font("Open Sans", 7.5F, System.Drawing.FontStyle.Bold);
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(10.0004F, 3.000005F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(69.16669F, 18.00003F);
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.Text = "Total:";
            this.xrLabel14.Visible = false;
            // 
            // xrTable4
            // 
            this.xrTable4.LocationFloat = new DevExpress.Utils.PointFloat(893.988F, 3.000005F);
            this.xrTable4.Name = "xrTable4";
            this.xrTable4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow9});
            this.xrTable4.SizeF = new System.Drawing.SizeF(142.012F, 18.00005F);
            // 
            // xrTableRow9
            // 
            this.xrTableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell49});
            this.xrTableRow9.Name = "xrTableRow9";
            this.xrTableRow9.Weight = 0.72D;
            // 
            // xrTableCell49
            // 
            this.xrTableCell49.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([ToBePaidToPartner])")});
            this.xrTableCell49.Font = new System.Drawing.Font("Open Sans", 7.5F, System.Drawing.FontStyle.Bold);
            this.xrTableCell49.Name = "xrTableCell49";
            this.xrTableCell49.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell49.StylePriority.UseFont = false;
            this.xrTableCell49.StylePriority.UsePadding = false;
            this.xrTableCell49.StylePriority.UseTextAlignment = false;
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrTableCell49.Summary = xrSummary2;
            this.xrTableCell49.Text = "xrTableCell49";
            this.xrTableCell49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell49.TextFormatString = "{0:$#,##0.00}";
            this.xrTableCell49.Weight = 1.2601083489375173D;
            // 
            // xrLine5
            // 
            this.xrLine5.BorderColor = System.Drawing.Color.Silver;
            this.xrLine5.BorderWidth = 2F;
            this.xrLine5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ForeColor", "Iif([Parameters].[BlackAndWhite], \'Black\',\'#ff5fb341\')")});
            this.xrLine5.ForeColor = System.Drawing.Color.Silver;
            this.xrLine5.LocationFloat = new DevExpress.Utils.PointFloat(0.0003178914F, 0F);
            this.xrLine5.Name = "xrLine5";
            this.xrLine5.SizeF = new System.Drawing.SizeF(1036F, 3.000005F);
            this.xrLine5.StylePriority.UseBorderColor = false;
            this.xrLine5.StylePriority.UseBorderWidth = false;
            this.xrLine5.StylePriority.UseForeColor = false;
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
            // BC
            // 
            this.BC.Description = "Parameter1";
            this.BC.Name = "BC";
            this.BC.Visible = false;
            // 
            // Date
            // 
            this.Date.Description = "Parameter1";
            this.Date.Name = "Date";
            this.Date.Visible = false;
            // 
            // Description
            // 
            this.Description.Description = "Parameter1";
            this.Description.Name = "Description";
            this.Description.Visible = false;
            // 
            // ReferralFee
            // 
            this.ReferralFee.Description = "Parameter1";
            this.ReferralFee.Name = "ReferralFee";
            this.ReferralFee.Visible = false;
            // 
            // PartnerInvoiceBC
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader1,
            this.GroupFooter1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.WireTransac});
            this.DataMember = "Acc_Partner_Invoice_BankCharges";
            this.DataSource = this.WireTransac;
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(36, 28, 0, 0);
            this.PageHeight = 850;
            this.PageWidth = 1100;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.BlackAndWhite,
            this.PartnerCommissionId,
            this.BC,
            this.Date,
            this.Description,
            this.ReferralFee});
            this.Version = "17.2";
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.PartnerInvoiceBC_DataSourceDemanded);
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.PartnerInvoiceBC_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.DataAccess.Sql.SqlDataSource WireTransac;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.Parameters.Parameter BlackAndWhite;
        private DevExpress.XtraReports.Parameters.Parameter PartnerCommissionId;
        private DevExpress.XtraReports.UI.XRTable xrTable5;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow11;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell54;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell58;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell63;
        private DevExpress.XtraReports.UI.XRLabel xrLabel15;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell15;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell20;
        private DevExpress.XtraReports.UI.XRLine xrLine6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel14;
        private DevExpress.XtraReports.UI.XRTable xrTable4;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow9;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell49;
        private DevExpress.XtraReports.UI.XRLine xrLine5;
        private DevExpress.XtraReports.Parameters.Parameter BC;
        private DevExpress.XtraReports.Parameters.Parameter Date;
        private DevExpress.XtraReports.Parameters.Parameter Description;
        private DevExpress.XtraReports.Parameters.Parameter ReferralFee;
    }
}
