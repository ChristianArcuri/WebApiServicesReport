namespace WebAPIReports.Reports.Invoice
{
    partial class RptInvoiceDebitCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptInvoiceDebitCard));
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.frReversal = new DevExpress.XtraReports.UI.FormattingRule();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBalance = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.WireTransac = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrPanelPayments = new DevExpress.XtraReports.UI.XRPanelExtension();
            this.xrTable5 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCellExtension();
            this.Date = new DevExpress.XtraReports.Parameters.Parameter();
            this.Color = new DevExpress.XtraReports.Parameters.Parameter();
            this.frGreenBorderColor = new DevExpress.XtraReports.UI.FormattingRule();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Control = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCellExtension();
            this.TransacID = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCellExtension();
            this.Sender = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCellExtension();
            this.OriAmount = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCellExtension();
            this.Fee = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCellExtension();
            this.AgComm = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCellExtension();
            this.Amount = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCellExtension();
            this.Balance = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabelExtension();
            this.DebitCard = new DevExpress.XtraReports.Parameters.Parameter();
            this.frGreenBackColor = new DevExpress.XtraReports.UI.FormattingRule();
            this.StatementId = new DevExpress.XtraReports.Parameters.Parameter();
            this.BlackAndWhite = new DevExpress.XtraReports.Parameters.Parameter();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrPanel2 = new DevExpress.XtraReports.UI.XRPanelExtension();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.Detail.HeightF = 14.58333F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // xrTable1
            // 
            this.xrTable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(6.357829E-05F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable1.SizeF = new System.Drawing.SizeF(764.9999F, 14.58333F);
            this.xrTable1.StylePriority.UseFont = false;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell11,
            this.xrTableCell5,
            this.xrTableCell12,
            this.xrTableCell13,
            this.xrTableCell15,
            this.xrTableCell16,
            this.xrTableCell17,
            this.xrTableCell18,
            this.xrBalance});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_DebitCard(@StatementId).TransactionDate")});
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.TextFormatString = "{0:MM/dd/yy}";
            this.xrTableCell11.Weight = 0.48722154413341984D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_DebitCard(@StatementId).TransacId")});
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Weight = 0.48722154413341984D;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_DebitCard(@StatementId).TransactionType")});
            this.xrTableCell12.FormattingRules.Add(this.frReversal);
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.Weight = 0.66869245296502056D;
            // 
            // frReversal
            // 
            this.frReversal.Condition = "[Type] = \'LR\' Or [Type] = \'IV\'";
            this.frReversal.DataMember = "Acc_Invoice_DebitCard(@StatementId)";
            this.frReversal.Formatting.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.frReversal.Name = "frReversal";
            // 
            // xrTableCell13
            // 
            this.xrTableCell13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_DebitCard(@StatementId).SndFullName")});
            this.xrTableCell13.FormattingRules.Add(this.frReversal);
            this.xrTableCell13.Name = "xrTableCell13";
            this.xrTableCell13.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100F);
            this.xrTableCell13.StylePriority.UsePadding = false;
            this.xrTableCell13.Weight = 1.718312788906547D;
            this.xrTableCell13.EvaluateBinding += new DevExpress.XtraReports.UI.BindingEventHandler(this.ToTitleCaseString);
            // 
            // xrTableCell15
            // 
            this.xrTableCell15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_DebitCard(@StatementId).Amount")});
            this.xrTableCell15.Name = "xrTableCell15";
            this.xrTableCell15.StylePriority.UseTextAlignment = false;
            this.xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell15.TextFormatString = "{0:$#,##0.00}";
            this.xrTableCell15.Weight = 0.58037884615690294D;
            // 
            // xrTableCell16
            // 
            this.xrTableCell16.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_DebitCard(@StatementId).FeeAmount")});
            this.xrTableCell16.Name = "xrTableCell16";
            this.xrTableCell16.StylePriority.UseTextAlignment = false;
            this.xrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell16.TextFormatString = "{0:$#,##0.00}";
            this.xrTableCell16.Weight = 0.57850642093250348D;
            // 
            // xrTableCell17
            // 
            this.xrTableCell17.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_DebitCard(@StatementId).AgCommission")});
            this.xrTableCell17.Name = "xrTableCell17";
            this.xrTableCell17.StylePriority.UseTextAlignment = false;
            this.xrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell17.TextFormatString = "{0:$#,##0.00}";
            this.xrTableCell17.Weight = 0.4959403284135086D;
            // 
            // xrTableCell18
            // 
            this.xrTableCell18.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_DebitCard(@StatementId).TranAmountInv")});
            this.xrTableCell18.Name = "xrTableCell18";
            this.xrTableCell18.StylePriority.UseTextAlignment = false;
            this.xrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell18.TextFormatString = "{0:$#,##0.00}";
            this.xrTableCell18.Weight = 0.67320810897606642D;
            // 
            // xrBalance
            // 
            this.xrBalance.Name = "xrBalance";
            this.xrBalance.StylePriority.UseTextAlignment = false;
            this.xrBalance.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrBalance.Weight = 0.68167141483584726D;
            this.xrBalance.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrBalance_BeforePrint);
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
            this.BottomMargin.HeightF = 0.9999911F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // WireTransac
            // 
            this.WireTransac.ConnectionName = "WireTransac_Connection";
            this.WireTransac.Name = "WireTransac";
            storedProcQuery1.Name = "Acc_Invoice_DebitCard(@StatementId)";
            queryParameter1.Name = "@StatementId";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.StatementId]", typeof(int));
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.StoredProcName = "Acc_Invoice_DebitCard";
            this.WireTransac.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.WireTransac.ResultSchemaSerializable = resources.GetString("WireTransac.ResultSchemaSerializable");
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
            this.Title.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.Title.Name = "Title";
            // 
            // DetailData3_Odd
            // 
            this.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent;
            this.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DetailData3_Odd.BorderWidth = 1F;
            this.DetailData3_Odd.Font = new System.Drawing.Font("Tahoma", 8F);
            this.DetailData3_Odd.ForeColor = System.Drawing.Color.Black;
            this.DetailData3_Odd.Name = "DetailData3_Odd";
            this.DetailData3_Odd.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // PageInfo
            // 
            this.PageInfo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.PageInfo.Name = "PageInfo";
            this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanelPayments});
            this.PageHeader.HeightF = 35.54166F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrPanelPayments
            // 
            this.xrPanelPayments.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable5,
            this.xrLabel27});
            this.xrPanelPayments.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.Color, "BorderColor", "")});
            this.xrPanelPayments.FormattingRules.Add(this.frGreenBorderColor);
            this.xrPanelPayments.LocationFloat = new DevExpress.Utils.PointFloat(0F, 3.041665F);
            this.xrPanelPayments.Name = "xrPanelPayments";
            this.xrPanelPayments.SizeF = new System.Drawing.SizeF(765F, 32.39582F);
            // 
            // xrTable5
            // 
            this.xrTable5.BorderColor = System.Drawing.Color.Black;
            this.xrTable5.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTable5.BorderWidth = 0.5F;
            this.xrTable5.LocationFloat = new DevExpress.Utils.PointFloat(4.768372E-05F, 16.75F);
            this.xrTable5.Name = "xrTable5";
            this.xrTable5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow7});
            this.xrTable5.SizeF = new System.Drawing.SizeF(764.9999F, 15F);
            this.xrTable5.StylePriority.UseBorderColor = false;
            this.xrTable5.StylePriority.UseBorders = false;
            this.xrTable5.StylePriority.UseBorderWidth = false;
            // 
            // xrTableRow7
            // 
            this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell22,
            this.xrTableCell14,
            this.xrTableCell23,
            this.xrTableCell4,
            this.xrTableCell6,
            this.xrTableCell7,
            this.xrTableCell8,
            this.xrTableCell9,
            this.xrTableCell10});
            this.xrTableRow7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableRow7.Name = "xrTableRow7";
            this.xrTableRow7.StylePriority.UseFont = false;
            this.xrTableRow7.Weight = 0.40541383699685452D;
            // 
            // xrTableCell22
            // 
            this.xrTableCell22.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableCell22.BorderWidth = 0.5F;
            this.xrTableCell22.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.Date, "Text", ""),
            new DevExpress.XtraReports.UI.XRBinding(this.Color, "BorderColor", "")});
            this.xrTableCell22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.xrTableCell22.FormattingRules.Add(this.frGreenBorderColor);
            this.xrTableCell22.HexaForeColor = null;
            this.xrTableCell22.Name = "xrTableCell22";
            this.xrTableCell22.StylePriority.UseBorders = false;
            this.xrTableCell22.StylePriority.UseBorderWidth = false;
            this.xrTableCell22.StylePriority.UseFont = false;
            this.xrTableCell22.Weight = 0.52563882549574192D;
            // 
            // Date
            // 
            this.Date.Description = "Parameter1";
            this.Date.Name = "Date";
            this.Date.ValueInfo = "Date";
            this.Date.Visible = false;
            // 
            // Color
            // 
            this.Color.Description = "Color";
            this.Color.Name = "Color";
            this.Color.Visible = false;
            // 
            // frGreenBorderColor
            // 
            this.frGreenBorderColor.Condition = "IsNullOrEmpty([Parameters.Color]) && [Parameters].[BlackAndWhite] == False";
            this.frGreenBorderColor.Formatting.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(179)))), ((int)(((byte)(65)))));
            this.frGreenBorderColor.Name = "frGreenBorderColor";
            // 
            // xrTableCell14
            // 
            this.xrTableCell14.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableCell14.BorderWidth = 0.5F;
            this.xrTableCell14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.Control, "Text", "")});
            this.xrTableCell14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.xrTableCell14.Name = "xrTableCell14";
            this.xrTableCell14.StylePriority.UseBorders = false;
            this.xrTableCell14.StylePriority.UseBorderWidth = false;
            this.xrTableCell14.StylePriority.UseFont = false;
            this.xrTableCell14.Weight = 0.58249964943474164D;
            // 
            // Control
            // 
            this.Control.Description = "Control";
            this.Control.Name = "Control";
            this.Control.ValueInfo = "Control";
            this.Control.Visible = false;
            // 
            // xrTableCell23
            // 
            this.xrTableCell23.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.TransacID, "Text", ""),
            new DevExpress.XtraReports.UI.XRBinding(this.Color, "BorderColor", "")});
            this.xrTableCell23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.xrTableCell23.FormattingRules.Add(this.frGreenBorderColor);
            this.xrTableCell23.HexaForeColor = null;
            this.xrTableCell23.Name = "xrTableCell23";
            this.xrTableCell23.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.xrTableCell23.StylePriority.UseFont = false;
            this.xrTableCell23.StylePriority.UsePadding = false;
            this.xrTableCell23.StylePriority.UseTextAlignment = false;
            this.xrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell23.Weight = 0.76043882076155311D;
            // 
            // TransacID
            // 
            this.TransacID.Description = "TransacID";
            this.TransacID.Name = "TransacID";
            this.TransacID.ValueInfo = "Transaction";
            this.TransacID.Visible = false;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.Sender, "Text", ""),
            new DevExpress.XtraReports.UI.XRBinding(this.Color, "BorderColor", "")});
            this.xrTableCell4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.xrTableCell4.FormattingRules.Add(this.frGreenBorderColor);
            this.xrTableCell4.HexaForeColor = null;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 2, 0, 0, 100F);
            this.xrTableCell4.StylePriority.UseFont = false;
            this.xrTableCell4.StylePriority.UsePadding = false;
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.Text = "xrTableCell4";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell4.Weight = 1.9540693163017133D;
            // 
            // Sender
            // 
            this.Sender.Description = "Parameter1";
            this.Sender.Name = "Sender";
            this.Sender.ValueInfo = "Sender";
            this.Sender.Visible = false;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.OriAmount, "Text", ""),
            new DevExpress.XtraReports.UI.XRBinding(this.Color, "BorderColor", "")});
            this.xrTableCell6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.xrTableCell6.FormattingRules.Add(this.frGreenBorderColor);
            this.xrTableCell6.HexaForeColor = null;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F);
            this.xrTableCell6.StylePriority.UseFont = false;
            this.xrTableCell6.StylePriority.UsePadding = false;
            this.xrTableCell6.StylePriority.UseTextAlignment = false;
            this.xrTableCell6.Text = "xrTableCell6";
            this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell6.Weight = 0.66000817269652123D;
            // 
            // OriAmount
            // 
            this.OriAmount.Description = "OriAmount";
            this.OriAmount.Name = "OriAmount";
            this.OriAmount.ValueInfo = "OriAmount";
            this.OriAmount.Visible = false;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.CanGrow = false;
            this.xrTableCell7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.Fee, "Text", ""),
            new DevExpress.XtraReports.UI.XRBinding(this.Color, "BorderColor", "")});
            this.xrTableCell7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.xrTableCell7.FormattingRules.Add(this.frGreenBorderColor);
            this.xrTableCell7.HexaForeColor = null;
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F);
            this.xrTableCell7.StylePriority.UseFont = false;
            this.xrTableCell7.StylePriority.UsePadding = false;
            this.xrTableCell7.StylePriority.UseTextAlignment = false;
            this.xrTableCell7.Text = "xrTableCell7";
            this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell7.Weight = 0.65787884448915634D;
            // 
            // Fee
            // 
            this.Fee.Description = "Parameter1";
            this.Fee.Name = "Fee";
            this.Fee.ValueInfo = "Fee";
            this.Fee.Visible = false;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.CanGrow = false;
            this.xrTableCell8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.AgComm, "Text", ""),
            new DevExpress.XtraReports.UI.XRBinding(this.Color, "BorderColor", "")});
            this.xrTableCell8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.xrTableCell8.FormattingRules.Add(this.frGreenBorderColor);
            this.xrTableCell8.HexaForeColor = null;
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F);
            this.xrTableCell8.StylePriority.UseFont = false;
            this.xrTableCell8.StylePriority.UsePadding = false;
            this.xrTableCell8.StylePriority.UseTextAlignment = false;
            this.xrTableCell8.Text = "xrTableCell8";
            this.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell8.Weight = 0.674479384897074D;
            // 
            // AgComm
            // 
            this.AgComm.Description = "Parameter1";
            this.AgComm.Name = "AgComm";
            this.AgComm.ValueInfo = "AgComm";
            this.AgComm.Visible = false;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.Amount, "Text", ""),
            new DevExpress.XtraReports.UI.XRBinding(this.Color, "BorderColor", "")});
            this.xrTableCell9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.xrTableCell9.FormattingRules.Add(this.frGreenBorderColor);
            this.xrTableCell9.HexaForeColor = null;
            this.xrTableCell9.Multiline = true;
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F);
            this.xrTableCell9.StylePriority.UseFont = false;
            this.xrTableCell9.StylePriority.UsePadding = false;
            this.xrTableCell9.StylePriority.UseTextAlignment = false;
            this.xrTableCell9.Text = "xrTableCell9";
            this.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell9.Weight = 0.655079036625501D;
            // 
            // Amount
            // 
            this.Amount.Description = "Parameter1";
            this.Amount.Name = "Amount";
            this.Amount.ValueInfo = "Amount";
            this.Amount.Visible = false;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.CanGrow = false;
            this.xrTableCell10.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.Balance, "Text", ""),
            new DevExpress.XtraReports.UI.XRBinding(this.Color, "BorderColor", "")});
            this.xrTableCell10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.xrTableCell10.FormattingRules.Add(this.frGreenBorderColor);
            this.xrTableCell10.HexaForeColor = null;
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F);
            this.xrTableCell10.StylePriority.UseFont = false;
            this.xrTableCell10.StylePriority.UsePadding = false;
            this.xrTableCell10.StylePriority.UseTextAlignment = false;
            this.xrTableCell10.Text = "xrTableCell10";
            this.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell10.Weight = 0.77519879062973474D;
            // 
            // Balance
            // 
            this.Balance.Description = "Parameter1";
            this.Balance.Name = "Balance";
            this.Balance.ValueInfo = "Balance";
            this.Balance.Visible = false;
            // 
            // xrLabel27
            // 
            this.xrLabel27.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.Color, "BackColor", ""),
            new DevExpress.XtraReports.UI.XRBinding(this.DebitCard, "Text", "")});
            this.xrLabel27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel27.ForeColor = System.Drawing.Color.White;
            this.xrLabel27.FormattingRules.Add(this.frGreenBackColor);
            this.xrLabel27.HexaForeColor = null;
            this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel27.Name = "xrLabel27";
            this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel27.SizeF = new System.Drawing.SizeF(765F, 16.75F);
            this.xrLabel27.StylePriority.UseBackColor = false;
            this.xrLabel27.StylePriority.UseFont = false;
            this.xrLabel27.StylePriority.UseForeColor = false;
            // 
            // DebitCard
            // 
            this.DebitCard.Description = "DebitCard";
            this.DebitCard.Name = "DebitCard";
            this.DebitCard.ValueInfo = "Debit Card";
            this.DebitCard.Visible = false;
            // 
            // frGreenBackColor
            // 
            this.frGreenBackColor.Condition = "IsNullOrEmpty([Parameters.Color]) && [Parameters].[BlackAndWhite] == False";
            this.frGreenBackColor.Formatting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(179)))), ((int)(((byte)(65)))));
            this.frGreenBackColor.Name = "frGreenBackColor";
            // 
            // StatementId
            // 
            this.StatementId.Description = "Parameter1";
            this.StatementId.Name = "StatementId";
            this.StatementId.Type = typeof(int);
            this.StatementId.ValueInfo = "13079674";
            this.StatementId.Visible = false;
            // 
            // BlackAndWhite
            // 
            this.BlackAndWhite.Description = "BlackAndWhite";
            this.BlackAndWhite.Name = "BlackAndWhite";
            this.BlackAndWhite.Type = typeof(bool);
            this.BlackAndWhite.ValueInfo = "True";
            this.BlackAndWhite.Visible = false;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel2});
            this.ReportFooter.HeightF = 29.16667F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrPanel2
            // 
            this.xrPanel2.BackColor = System.Drawing.Color.Transparent;
            this.xrPanel2.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrPanel2.BorderWidth = 1F;
            this.xrPanel2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3});
            this.xrPanel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.Color, "BorderColor", "")});
            this.xrPanel2.FormattingRules.Add(this.frGreenBorderColor);
            this.xrPanel2.LocationFloat = new DevExpress.Utils.PointFloat(0.0001192093F, 0F);
            this.xrPanel2.Name = "xrPanel2";
            this.xrPanel2.SizeF = new System.Drawing.SizeF(764.9999F, 18.62501F);
            this.xrPanel2.StylePriority.UseBackColor = false;
            this.xrPanel2.StylePriority.UseBorderColor = false;
            this.xrPanel2.StylePriority.UseBorders = false;
            this.xrPanel2.StylePriority.UseBorderWidth = false;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_DebitCard(@StatementId).TranAmountInv", "{0:C2}")});
            this.xrLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel3.ForeColor = System.Drawing.Color.Black;
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(579.7913F, 2.625005F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(103.3585F, 16F);
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseForeColor = false;
            this.xrLabel3.StylePriority.UsePadding = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "{0:$#,##0.00}";
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel3.Summary = xrSummary1;
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // RptInvoiceDebitCard
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader,
            this.ReportFooter});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.WireTransac});
            this.DataMember = "Acc_Invoice_DebitCard(@StatementId)";
            this.DataSource = this.WireTransac;
            this.FormattingRuleSheet.AddRange(new DevExpress.XtraReports.UI.FormattingRule[] {
            this.frGreenBackColor,
            this.frGreenBorderColor,
            this.frReversal});
            this.Margins = new System.Drawing.Printing.Margins(61, 24, 0, 1);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.StatementId,
            this.BlackAndWhite,
            this.Date,
            this.TransacID,
            this.Sender,
            this.OriAmount,
            this.Fee,
            this.AgComm,
            this.Amount,
            this.Balance,
            this.Control,
            this.DebitCard,
            this.Color});
            this.ReportPrintOptions.PrintOnEmptyDataSource = false;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailData3_Odd,
            this.PageInfo});
            this.Version = "18.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).EndInit();
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
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.Parameters.Parameter StatementId;
        private DevExpress.XtraReports.Parameters.Parameter BlackAndWhite;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRPanelExtension xrPanelPayments;
        private DevExpress.XtraReports.UI.XRLabelExtension xrLabel27;
        private DevExpress.XtraReports.UI.XRTable xrTable5;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow7;
        private DevExpress.XtraReports.UI.XRTableCellExtension xrTableCell22;
        private DevExpress.XtraReports.UI.XRTableCellExtension xrTableCell23;
        private DevExpress.XtraReports.Parameters.Parameter Date;
        private DevExpress.XtraReports.Parameters.Parameter TransacID;
        private DevExpress.XtraReports.Parameters.Parameter Sender;
        private DevExpress.XtraReports.Parameters.Parameter OriAmount;
        private DevExpress.XtraReports.Parameters.Parameter Fee;
        private DevExpress.XtraReports.Parameters.Parameter AgComm;
        private DevExpress.XtraReports.Parameters.Parameter Amount;
        private DevExpress.XtraReports.Parameters.Parameter Balance;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell11;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell12;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell13;
        private DevExpress.XtraReports.Parameters.Parameter Control;
        private DevExpress.XtraReports.UI.XRTableCellExtension xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCellExtension xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableCellExtension xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableCellExtension xrTableCell8;
        private DevExpress.XtraReports.UI.XRTableCellExtension xrTableCell9;
        private DevExpress.XtraReports.UI.XRTableCellExtension xrTableCell10;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell15;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell16;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell17;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell18;
        private DevExpress.XtraReports.UI.XRPanelExtension xrPanel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRTableCell xrBalance;
        private DevExpress.XtraReports.Parameters.Parameter DebitCard;
        private DevExpress.XtraReports.UI.FormattingRule frGreenBackColor;
        private DevExpress.XtraReports.UI.FormattingRule frGreenBorderColor;
        private DevExpress.XtraReports.UI.FormattingRule frReversal;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell14;
        private DevExpress.XtraReports.Parameters.Parameter Color;
        internal DevExpress.DataAccess.Sql.SqlDataSource WireTransac;
    }
}
