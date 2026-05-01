namespace WebAPIReports.Reports.Invoice.SmallFormat
{
    partial class RptInvoiceCancellationsSm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptInvoiceCancellationsSm));
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.WireTransac = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.reportFooterBand1 = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrPanel2 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrSummary = new DevExpress.XtraReports.UI.XRLabel();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailCaption3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailCaptionBackground3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GrandTotalCaption3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GrandTotalData3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GrandTotalBackground3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.StatementId = new DevExpress.XtraReports.Parameters.Parameter();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrPanel3 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.CancellationLabel = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Date = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.WireNo = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Descript = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Void = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Amount = new DevExpress.XtraReports.Parameters.Parameter();
            this.CalcSumOther = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcSumStateFee = new DevExpress.XtraReports.UI.CalculatedField();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.Detail.Font = new System.Drawing.Font("Open Sans Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.Detail.HeightF = 8F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StylePriority.UseFont = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // xrTable2
            // 
            this.xrTable2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTable2.Font = new System.Drawing.Font("Open Sans Semibold", 7.5F);
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow4});
            this.xrTable2.SizeF = new System.Drawing.SizeF(317F, 8F);
            this.xrTable2.StylePriority.UseBorders = false;
            this.xrTable2.StylePriority.UseFont = false;
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell19,
            this.xrTableCell21,
            this.xrTableCell22,
            this.xrTableCell29,
            this.xrTableCell30});
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.Weight = 11.5D;
            // 
            // xrTableCell19
            // 
            this.xrTableCell19.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Cancellations(@StatementId).TransactionDate", "{0:MM/dd/yy}")});
            this.xrTableCell19.Font = new System.Drawing.Font("Open Sans Semibold", 7.5F);
            this.xrTableCell19.Name = "xrTableCell19";
            this.xrTableCell19.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 0, 0, 0, 100F);
            this.xrTableCell19.StyleName = "DetailData3";
            this.xrTableCell19.StylePriority.UseFont = false;
            this.xrTableCell19.StylePriority.UsePadding = false;
            this.xrTableCell19.Text = "xrTableCell19";
            this.xrTableCell19.Weight = 0.087512196245831259D;
            // 
            // xrTableCell21
            // 
            this.xrTableCell21.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Cancellations(@StatementId).AgSenderSeq")});
            this.xrTableCell21.Font = new System.Drawing.Font("Open Sans Semibold", 7.5F);
            this.xrTableCell21.Name = "xrTableCell21";
            this.xrTableCell21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
            this.xrTableCell21.StyleName = "DetailData3";
            this.xrTableCell21.StylePriority.UseFont = false;
            this.xrTableCell21.StylePriority.UsePadding = false;
            this.xrTableCell21.StylePriority.UseTextAlignment = false;
            this.xrTableCell21.Text = "xrTableCell21";
            this.xrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell21.Weight = 0.075731709039224D;
            // 
            // xrTableCell22
            // 
            this.xrTableCell22.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Cancellations(@StatementId).StatementDesc")});
            this.xrTableCell22.Font = new System.Drawing.Font("Open Sans Semibold", 7.5F);
            this.xrTableCell22.Name = "xrTableCell22";
            this.xrTableCell22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
            this.xrTableCell22.StyleName = "DetailData3";
            this.xrTableCell22.StylePriority.UseFont = false;
            this.xrTableCell22.StylePriority.UsePadding = false;
            this.xrTableCell22.Text = "xrTableCell22";
            this.xrTableCell22.Weight = 0.2338331174182598D;
            this.xrTableCell22.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.xrTableCell22_PrintOnPage);
            // 
            // xrTableCell29
            // 
            this.xrTableCell29.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Cancellations(@StatementId).Cancel")});
            this.xrTableCell29.Font = new System.Drawing.Font("Open Sans Semibold", 7.5F);
            this.xrTableCell29.Name = "xrTableCell29";
            this.xrTableCell29.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 2, 0, 0, 100F);
            this.xrTableCell29.StyleName = "DetailData3";
            this.xrTableCell29.StylePriority.UseFont = false;
            this.xrTableCell29.StylePriority.UsePadding = false;
            this.xrTableCell29.StylePriority.UseTextAlignment = false;
            this.xrTableCell29.Text = "xrTableCell29";
            this.xrTableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell29.Weight = 0.044254202848947925D;
            // 
            // xrTableCell30
            // 
            this.xrTableCell30.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Cancellations(@StatementId).ActivityBalance", "{0:$#,##0.00}")});
            this.xrTableCell30.Font = new System.Drawing.Font("Open Sans Semibold", 7.5F);
            this.xrTableCell30.Name = "xrTableCell30";
            this.xrTableCell30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 1, 0, 0, 100F);
            this.xrTableCell30.StyleName = "DetailData3";
            this.xrTableCell30.StylePriority.UseFont = false;
            this.xrTableCell30.StylePriority.UsePadding = false;
            this.xrTableCell30.StylePriority.UseTextAlignment = false;
            this.xrTableCell30.Text = "xrTableCell30";
            this.xrTableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell30.Weight = 0.11559265966421836D;
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
            this.WireTransac.ConnectionName = "WireTransac_Connection";
            this.WireTransac.Name = "WireTransac";
            storedProcQuery1.Name = "Acc_Invoice_Cancellations(@StatementId)";
            queryParameter1.Name = "@StatementId";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.StatementId]", typeof(int));
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.StoredProcName = "Acc_Invoice_Cancellations";
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
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell16,
            this.xrTableCell17,
            this.xrTableCell18});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // xrTableCell16
            // 
            this.xrTableCell16.Name = "xrTableCell16";
            this.xrTableCell16.Text = "xrTableCell16";
            this.xrTableCell16.Weight = 1D;
            // 
            // xrTableCell17
            // 
            this.xrTableCell17.Name = "xrTableCell17";
            this.xrTableCell17.Text = "xrTableCell17";
            this.xrTableCell17.Weight = 1D;
            // 
            // xrTableCell18
            // 
            this.xrTableCell18.Name = "xrTableCell18";
            this.xrTableCell18.Text = "xrTableCell18";
            this.xrTableCell18.Weight = 1D;
            // 
            // reportFooterBand1
            // 
            this.reportFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel2});
            this.reportFooterBand1.HeightF = 18F;
            this.reportFooterBand1.Name = "reportFooterBand1";
            // 
            // xrPanel2
            // 
            this.xrPanel2.BackColor = System.Drawing.Color.Transparent;
            this.xrPanel2.BorderColor = System.Drawing.Color.Black;
            this.xrPanel2.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrPanel2.BorderWidth = 1F;
            this.xrPanel2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSummary});
            this.xrPanel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPanel2.Name = "xrPanel2";
            this.xrPanel2.SizeF = new System.Drawing.SizeF(318F, 18F);
            this.xrPanel2.StyleName = "GrandTotalBackground3";
            this.xrPanel2.StylePriority.UseBackColor = false;
            this.xrPanel2.StylePriority.UseBorderColor = false;
            this.xrPanel2.StylePriority.UseBorders = false;
            this.xrPanel2.StylePriority.UseBorderWidth = false;
            // 
            // xrSummary
            // 
            this.xrSummary.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Cancellations(@StatementId).ActivityBalance", "{0:C2}")});
            this.xrSummary.Font = new System.Drawing.Font("Open Sans", 8F, System.Drawing.FontStyle.Bold);
            this.xrSummary.ForeColor = System.Drawing.Color.Black;
            this.xrSummary.LocationFloat = new DevExpress.Utils.PointFloat(250.624F, 1.2F);
            this.xrSummary.Name = "xrSummary";
            this.xrSummary.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 1, 0, 0, 100F);
            this.xrSummary.SizeF = new System.Drawing.SizeF(66.37604F, 9F);
            this.xrSummary.StyleName = "GrandTotalData3";
            this.xrSummary.StylePriority.UseFont = false;
            this.xrSummary.StylePriority.UseForeColor = false;
            this.xrSummary.StylePriority.UsePadding = false;
            this.xrSummary.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "{0:$#,##0.00}";
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrSummary.Summary = xrSummary1;
            this.xrSummary.Text = "xrSummary";
            this.xrSummary.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
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
            // DetailCaption3
            // 
            this.DetailCaption3.BackColor = System.Drawing.Color.Transparent;
            this.DetailCaption3.BorderColor = System.Drawing.Color.Transparent;
            this.DetailCaption3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DetailCaption3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.DetailCaption3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.DetailCaption3.Name = "DetailCaption3";
            this.DetailCaption3.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailCaption3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData3
            // 
            this.DetailData3.Font = new System.Drawing.Font("Tahoma", 8F);
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
            this.DetailData3_Odd.Font = new System.Drawing.Font("Tahoma", 8F);
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
            // GrandTotalCaption3
            // 
            this.GrandTotalCaption3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.GrandTotalCaption3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.GrandTotalCaption3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.GrandTotalCaption3.Name = "GrandTotalCaption3";
            this.GrandTotalCaption3.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
            this.GrandTotalCaption3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // GrandTotalData3
            // 
            this.GrandTotalData3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.GrandTotalData3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.GrandTotalData3.ForeColor = System.Drawing.Color.White;
            this.GrandTotalData3.Name = "GrandTotalData3";
            this.GrandTotalData3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 6, 0, 0, 100F);
            this.GrandTotalData3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // GrandTotalBackground3
            // 
            this.GrandTotalBackground3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.GrandTotalBackground3.BorderColor = System.Drawing.Color.White;
            this.GrandTotalBackground3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.GrandTotalBackground3.BorderWidth = 2F;
            this.GrandTotalBackground3.Name = "GrandTotalBackground3";
            // 
            // PageInfo
            // 
            this.PageInfo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.PageInfo.Name = "PageInfo";
            this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // StatementId
            // 
            this.StatementId.Description = "StatementId";
            this.StatementId.Name = "StatementId";
            this.StatementId.Type = typeof(int);
            this.StatementId.ValueInfo = "8557386";
            this.StatementId.Visible = false;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel3});
            this.PageHeader.HeightF = 41.875F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrPanel3
            // 
            this.xrPanel3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel5,
            this.xrTable1});
            this.xrPanel3.LocationFloat = new DevExpress.Utils.PointFloat(0.999705F, 0F);
            this.xrPanel3.Name = "xrPanel3";
            this.xrPanel3.SizeF = new System.Drawing.SizeF(317.0003F, 41.875F);
            // 
            // xrLabel5
            // 
            this.xrLabel5.BackColor = System.Drawing.Color.Transparent;
            this.xrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel5.BorderWidth = 1F;
            this.xrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.CancellationLabel, "Text", "")});
            this.xrLabel5.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel5.ForeColor = System.Drawing.Color.Black;
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 9.999943F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(316.0003F, 16.75F);
            this.xrLabel5.StylePriority.UseBackColor = false;
            this.xrLabel5.StylePriority.UseBorders = false;
            this.xrLabel5.StylePriority.UseBorderWidth = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseForeColor = false;
            // 
            // CancellationLabel
            // 
            this.CancellationLabel.Description = "CancellationLabel";
            this.CancellationLabel.Name = "CancellationLabel";
            this.CancellationLabel.Visible = false;
            // 
            // xrTable1
            // 
            this.xrTable1.BackColor = System.Drawing.Color.Transparent;
            this.xrTable1.BorderColor = System.Drawing.Color.Black;
            this.xrTable1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTable1.BorderWidth = 1F;
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 26.74993F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable1.SizeF = new System.Drawing.SizeF(317F, 15F);
            this.xrTable1.StylePriority.UseBackColor = false;
            this.xrTable1.StylePriority.UseBorderColor = false;
            this.xrTable1.StylePriority.UseBorders = false;
            this.xrTable1.StylePriority.UseBorderWidth = false;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell9,
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell14,
            this.xrTableCell15});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 0.9375D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableCell9.BorderWidth = 1F;
            this.xrTableCell9.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.Date, "Text", "")});
            this.xrTableCell9.Font = new System.Drawing.Font("Open Sans", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 0, 0, 0, 100F);
            this.xrTableCell9.StylePriority.UseBorders = false;
            this.xrTableCell9.StylePriority.UseBorderWidth = false;
            this.xrTableCell9.StylePriority.UseFont = false;
            this.xrTableCell9.StylePriority.UsePadding = false;
            this.xrTableCell9.Weight = 0.48302139399683663D;
            // 
            // Date
            // 
            this.Date.Description = "Date";
            this.Date.Name = "Date";
            this.Date.Visible = false;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.WireNo, "Text", "")});
            this.xrTableCell4.Font = new System.Drawing.Font("Open Sans", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
            this.xrTableCell4.StylePriority.UseFont = false;
            this.xrTableCell4.StylePriority.UsePadding = false;
            this.xrTableCell4.Weight = 0.42619304938933122D;
            // 
            // WireNo
            // 
            this.WireNo.Description = "WireNo";
            this.WireNo.Name = "WireNo";
            this.WireNo.Visible = false;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.Descript, "Text", "")});
            this.xrTableCell5.Font = new System.Drawing.Font("Open Sans", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
            this.xrTableCell5.StylePriority.UseFont = false;
            this.xrTableCell5.StylePriority.UsePadding = false;
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            this.xrTableCell5.Weight = 1.2935726343681275D;
            // 
            // Descript
            // 
            this.Descript.Description = "Descript";
            this.Descript.Name = "Descript";
            this.Descript.Visible = false;
            // 
            // xrTableCell14
            // 
            this.xrTableCell14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.Void, "Text", "")});
            this.xrTableCell14.Font = new System.Drawing.Font("Open Sans", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.xrTableCell14.Name = "xrTableCell14";
            this.xrTableCell14.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 1, 0, 0, 100F);
            this.xrTableCell14.StylePriority.UseFont = false;
            this.xrTableCell14.StylePriority.UsePadding = false;
            this.xrTableCell14.StylePriority.UseTextAlignment = false;
            this.xrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrTableCell14.Weight = 0.24659116936092768D;
            // 
            // Void
            // 
            this.Void.Description = "Void";
            this.Void.Name = "Void";
            this.Void.Visible = false;
            // 
            // xrTableCell15
            // 
            this.xrTableCell15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.Amount, "Text", "{0:$#,##0.00}")});
            this.xrTableCell15.Font = new System.Drawing.Font("Open Sans", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.xrTableCell15.Name = "xrTableCell15";
            this.xrTableCell15.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F);
            this.xrTableCell15.StylePriority.UseFont = false;
            this.xrTableCell15.StylePriority.UsePadding = false;
            this.xrTableCell15.StylePriority.UseTextAlignment = false;
            this.xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell15.Weight = 0.6538865866874336D;
            // 
            // Amount
            // 
            this.Amount.Description = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.Visible = false;
            // 
            // CalcSumOther
            // 
            this.CalcSumOther.DataMember = "Acc_Invoice_Cancellations(@StatementId)";
            this.CalcSumOther.Expression = "Sum(Iif(IsNull([Other]),0,[Other]))";
            this.CalcSumOther.Name = "CalcSumOther";
            // 
            // CalcSumStateFee
            // 
            this.CalcSumStateFee.DataMember = "Acc_Invoice_Cancellations(@StatementId)";
            this.CalcSumStateFee.Expression = "Sum(Iif(IsNull([StateFee]),0,[StateFee]))";
            this.CalcSumStateFee.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
            this.CalcSumStateFee.Name = "CalcSumStateFee";
            // 
            // RptInvoiceCancellationsSm
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.reportFooterBand1,
            this.PageHeader});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.CalcSumOther,
            this.CalcSumStateFee});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.WireTransac});
            this.DataMember = "Acc_Invoice_Cancellations(@StatementId)";
            this.DataSource = this.WireTransac;
            this.Font = new System.Drawing.Font("Open Sans Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0);
            this.PageWidth = 318;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.StatementId,
            this.CancellationLabel,
            this.Date,
            this.WireNo,
            this.Descript,
            this.Void,
            this.Amount});
            this.ReportPrintOptions.PrintOnEmptyDataSource = false;
            this.RollPaper = true;
            this.ShowPrintMarginsWarning = false;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailCaption3,
            this.DetailData3,
            this.DetailData3_Odd,
            this.DetailCaptionBackground3,
            this.GrandTotalCaption3,
            this.GrandTotalData3,
            this.GrandTotalBackground3,
            this.PageInfo});
            this.Version = "17.1";
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.RptInvoiceCancellations_DataSourceDemanded);
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell19;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell21;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell22;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell29;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell30;
        private DevExpress.DataAccess.Sql.SqlDataSource WireTransac;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell16;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell17;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell18;
        private DevExpress.XtraReports.UI.ReportFooterBand reportFooterBand1;
        private DevExpress.XtraReports.UI.XRPanel xrPanel2;
        private DevExpress.XtraReports.UI.XRLabel xrSummary;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle DetailCaption3;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData3;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
        private DevExpress.XtraReports.UI.XRControlStyle DetailCaptionBackground3;
        private DevExpress.XtraReports.UI.XRControlStyle GrandTotalCaption3;
        private DevExpress.XtraReports.UI.XRControlStyle GrandTotalData3;
        private DevExpress.XtraReports.UI.XRControlStyle GrandTotalBackground3;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.Parameters.Parameter StatementId;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRPanel xrPanel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.Parameters.Parameter CancellationLabel;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell9;
        private DevExpress.XtraReports.Parameters.Parameter Date;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.Parameters.Parameter WireNo;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.Parameters.Parameter Descript;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell14;
        private DevExpress.XtraReports.Parameters.Parameter Void;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell15;
        private DevExpress.XtraReports.Parameters.Parameter Amount;
        private DevExpress.XtraReports.UI.CalculatedField CalcSumOther;
        private DevExpress.XtraReports.UI.CalculatedField CalcSumStateFee;
    }
}
