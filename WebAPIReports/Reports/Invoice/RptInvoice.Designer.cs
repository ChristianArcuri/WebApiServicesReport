namespace WebAPIReports.Reports.Invoice
{
    partial class RptInvoice
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
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptInvoice));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.SubBand1 = new DevExpress.XtraReports.UI.SubBand();
            this.xrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.WireSecurity = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrPanel2 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPanel4 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrTSummary = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrLblPayment = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrQtyPayments = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrPaymentAmount = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTROther = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrLblOther = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrQtyOtherCredits = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrOtherAmount = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrLblCancellation = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrQtyCancellations = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrCancellationAmount = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow10 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrLblDebitCard = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrQtyDebitCard = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrDebitCardAmount = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrQtyBP = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrAmountBP = new DevExpress.XtraReports.UI.XRTableCell();
            this.frGreenBorderColor = new DevExpress.XtraReports.UI.FormattingRule();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrWiresLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.Payments = new DevExpress.XtraReports.UI.SubBand();
            this.xrSubPayment = new DevExpress.XtraReports.UI.XRSubreport();
            this.StatementId = new DevExpress.XtraReports.Parameters.Parameter();
            this.BlackAndWhite = new DevExpress.XtraReports.Parameters.Parameter();
            this.OtherCreditsDebits = new DevExpress.XtraReports.UI.SubBand();
            this.xrSubOther = new DevExpress.XtraReports.UI.XRSubreport();
            this.Cancellations = new DevExpress.XtraReports.UI.SubBand();
            this.xrSubCancellations = new DevExpress.XtraReports.UI.XRSubreport();
            this.Wires = new DevExpress.XtraReports.UI.SubBand();
            this.xrSubWires = new DevExpress.XtraReports.UI.XRSubreport();
            this.LanguageId = new DevExpress.XtraReports.Parameters.Parameter();
            this.DebitCard = new DevExpress.XtraReports.UI.SubBand();
            this.xrSubDebitCard = new DevExpress.XtraReports.UI.XRSubreport();
            this.BillPayment = new DevExpress.XtraReports.UI.SubBand();
            this.xrPanel7 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrSubreport1 = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrTransDate = new DevExpress.XtraReports.UI.XRLabel();
            this.WireTransac = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.frGreenForeColor = new DevExpress.XtraReports.UI.FormattingRule();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.frColorLogoVisible = new DevExpress.XtraReports.UI.FormattingRule();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.CalcHeaderInfo = new DevExpress.XtraReports.UI.CalculatedField();
            this.FormName = new DevExpress.XtraReports.Parameters.Parameter();
            this.CalcInfoHeader = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcLegalEntiyInfo = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcAgInfoOwner = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcAgInfo = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcTotalPaymentAmount = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcPaymentLabel = new DevExpress.XtraReports.UI.CalculatedField();
            this.calculatedField1 = new DevExpress.XtraReports.UI.CalculatedField();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrRightInfoHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.xrIHLineEndValue = new DevExpress.XtraReports.UI.XRLabel();
            this.xrIHLineEnd = new DevExpress.XtraReports.UI.XRLabel();
            this.xrIHPhoneValue = new DevExpress.XtraReports.UI.XRLabel();
            this.xrIHPhone = new DevExpress.XtraReports.UI.XRLabel();
            this.xrIHEmailValue = new DevExpress.XtraReports.UI.XRLabel();
            this.xrIHEmail = new DevExpress.XtraReports.UI.XRLabel();
            this.xrIHFaxValue = new DevExpress.XtraReports.UI.XRLabel();
            this.xrIHFax = new DevExpress.XtraReports.UI.XRLabel();
            this.xrIHLine1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine4 = new DevExpress.XtraReports.UI.XRLine();
            this.xrPanel3 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrPictureBox2 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.frBWLogoVisible = new DevExpress.XtraReports.UI.FormattingRule();
            this.CalcOtherLabel = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcCancellationLabel = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcWireSentLabel = new DevExpress.XtraReports.UI.CalculatedField();
            this.frGreenBackColor = new DevExpress.XtraReports.UI.FormattingRule();
            this.CalcAgPhone = new DevExpress.XtraReports.UI.CalculatedField();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrPageInfo4 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
            this.xrPageInfo3 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.frFaxMessage = new DevExpress.XtraReports.UI.FormattingRule();
            this.xrPanel6 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.frShowCommiPaymentMethod = new DevExpress.XtraReports.UI.FormattingRule();
            this.xrPanel5 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrTCommission = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.frShowCommissionBox = new DevExpress.XtraReports.UI.FormattingRule();
            this.xrCommiPaidNote = new DevExpress.XtraReports.UI.XRLabel();
            this.xrCommyType = new DevExpress.XtraReports.UI.XRLabel();
            this.CalcCommiPaymentMethod = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcTrimPayment = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcTrimOther = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcTrimCancellations = new DevExpress.XtraReports.UI.CalculatedField();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLine5 = new DevExpress.XtraReports.UI.XRLine();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrPanel8 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrTDebitCard = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrSubInTransit = new DevExpress.XtraReports.UI.XRSubreport();
            this.CalcNote = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcAgFax = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcAgPhoneLabel = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcTrimBP = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcSeqNo = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcService = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcStCurrency = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcDebitCard = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcTransact = new DevExpress.XtraReports.UI.CalculatedField();
            ((System.ComponentModel.ISupportInitialize)(this.xrTSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTCommission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTDebitCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.BorderWidth = 6F;
            this.Detail.HeightF = 0F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StylePriority.UseBorderWidth = false;
            this.Detail.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand1,
            this.Payments,
            this.OtherCreditsDebits,
            this.Cancellations,
            this.Wires,
            this.DebitCard,
            this.BillPayment});
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // SubBand1
            // 
            this.SubBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel30,
            this.xrLabel24,
            this.xrLabel19,
            this.xrLabel23,
            this.xrLabel22,
            this.xrLabel21,
            this.xrLabel5,
            this.xrLabel1,
            this.xrPanel1,
            this.xrLabel3,
            this.xrLabel4,
            this.xrWiresLabel});
            this.SubBand1.Expanded = false;
            this.SubBand1.HeightF = 204.6666F;
            this.SubBand1.Name = "SubBand1";
            // 
            // xrLabel30
            // 
            this.xrLabel30.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Header(@StatementId).StateLicense")});
            this.xrLabel30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.xrLabel30.LocationFloat = new DevExpress.Utils.PointFloat(9.550858F, 84.00002F);
            this.xrLabel30.Multiline = true;
            this.xrLabel30.Name = "xrLabel30";
            this.xrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel30.SizeF = new System.Drawing.SizeF(316.6666F, 10.84166F);
            this.xrLabel30.StylePriority.UseFont = false;
            // 
            // xrLabel24
            // 
            this.xrLabel24.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel24.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Header(@StatementId).BeginingBalance", "{0:$#,##0.00}")});
            this.xrLabel24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(637.9167F, 194.7916F);
            this.xrLabel24.Name = "xrLabel24";
            this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel24.SizeF = new System.Drawing.SizeF(127.0833F, 9.875015F);
            this.xrLabel24.StylePriority.UseBorders = false;
            this.xrLabel24.StylePriority.UseFont = false;
            this.xrLabel24.StylePriority.UseTextAlignment = false;
            this.xrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel19
            // 
            this.xrLabel19.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel19.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).BeginingBalance")});
            this.xrLabel19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(411.8203F, 194.7916F);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(213.4332F, 9.875015F);
            this.xrLabel19.StylePriority.UseBorders = false;
            this.xrLabel19.StylePriority.UseFont = false;
            this.xrLabel19.StylePriority.UseTextAlignment = false;
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // WireSecurity
            // 
            this.WireSecurity.ConnectionName = "WireSecurity_Connection";
            this.WireSecurity.Name = "WireSecurity";
            storedProcQuery1.Name = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            queryParameter1.Name = "@LanguageId";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.LanguageId]", typeof(int));
            queryParameter2.Name = "@FormName";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.FormName]", typeof(string));
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.Parameters.Add(queryParameter2);
            storedProcQuery1.StoredProcName = "ConvertRowsInColumns_MultiLangLabels";
            this.WireSecurity.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            // 
            // xrLabel23
            // 
            this.xrLabel23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(9.999974F, 65.7F);
            this.xrLabel23.Name = "xrLabel23";
            this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel23.SizeF = new System.Drawing.SizeF(41.5F, 7.458374F);
            this.xrLabel23.StylePriority.UseFont = false;
            this.xrLabel23.Text = "Fax:";
            this.xrLabel23.WordWrap = false;
            // 
            // xrLabel22
            // 
            this.xrLabel22.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CalcAgPhoneLabel")});
            this.xrLabel22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(9.999974F, 57.75F);
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel22.SizeF = new System.Drawing.SizeF(41.5F, 7.45837F);
            this.xrLabel22.StylePriority.UseFont = false;
            this.xrLabel22.WordWrap = false;
            // 
            // xrLabel21
            // 
            this.xrLabel21.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Header(@StatementId).CalcAgFax", "{0:(###) ### - ####}")});
            this.xrLabel21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(51.5F, 65.69999F);
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(276.1667F, 7.458366F);
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.WordWrap = false;
            // 
            // xrLabel5
            // 
            this.xrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Header(@StatementId).AgEmail")});
            this.xrLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(9.999974F, 73.15836F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(316.6666F, 10.84166F);
            this.xrLabel5.StylePriority.UseFont = false;
            // 
            // xrLabel1
            // 
            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Header(@StatementId).CalcAgPhone", "{0:(###) ### - ####}")});
            this.xrLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(51.5F, 57.74997F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(276.1667F, 7.458374F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.WordWrap = false;
            // 
            // xrPanel1
            // 
            this.xrPanel1.BorderColor = System.Drawing.Color.Black;
            this.xrPanel1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPanel1.BorderWidth = 2F;
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel2,
            this.xrPanel4});
            this.xrPanel1.FormattingRules.Add(this.frGreenBorderColor);
            this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(349.3755F, 10.00002F);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.SizeF = new System.Drawing.SizeF(405.6244F, 169.9307F);
            this.xrPanel1.StylePriority.UseBorderColor = false;
            this.xrPanel1.StylePriority.UseBorders = false;
            this.xrPanel1.StylePriority.UseBorderWidth = false;
            // 
            // xrPanel2
            // 
            this.xrPanel2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel11,
            this.xrLabel9});
            this.xrPanel2.LocationFloat = new DevExpress.Utils.PointFloat(9.999889F, 126.9307F);
            this.xrPanel2.Name = "xrPanel2";
            this.xrPanel2.SizeF = new System.Drawing.SizeF(385.6245F, 33F);
            // 
            // xrLabel11
            // 
            this.xrLabel11.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Header(@StatementId).EndingBalance", "{0:$#,##0.00}")});
            this.xrLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(253.0749F, 5.3F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(127.0833F, 19.87502F);
            this.xrLabel11.StylePriority.UseBorders = false;
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel9
            // 
            this.xrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel9.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).TotalPaymentDue")});
            this.xrLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(10.0001F, 5.3F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(134.375F, 19.87502F);
            this.xrLabel9.StylePriority.UseBorders = false;
            this.xrLabel9.StylePriority.UseFont = false;
            // 
            // xrPanel4
            // 
            this.xrPanel4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrPanel4.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTSummary});
            this.xrPanel4.LocationFloat = new DevExpress.Utils.PointFloat(10.0002F, 10F);
            this.xrPanel4.Name = "xrPanel4";
            this.xrPanel4.SizeF = new System.Drawing.SizeF(385.6245F, 96.99999F);
            this.xrPanel4.StylePriority.UseBorders = false;
            // 
            // xrTSummary
            // 
            this.xrTSummary.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTSummary.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTSummary.Name = "xrTSummary";
            this.xrTSummary.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2,
            this.xrTableRow3,
            this.xrTROther,
            this.xrTableRow8,
            this.xrTableRow10,
            this.xrTableRow9});
            this.xrTSummary.SizeF = new System.Drawing.SizeF(385.6244F, 94F);
            this.xrTSummary.StylePriority.UseBorders = false;
            this.xrTSummary.StylePriority.UseFont = false;
            this.xrTSummary.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrTSummary_BeforePrint);
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell6});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 0.76D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.CanGrow = false;
            this.xrTableCell4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).BeginingBalance")});
            this.xrTableCell4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.StylePriority.UseFont = false;
            this.xrTableCell4.Weight = 1.7570742135072126D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.CanGrow = false;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell5.Weight = 0.37628078855883629D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.CanGrow = false;
            this.xrTableCell6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Header(@StatementId).BeginingBalance", "{0:$#,##0.00}")});
            this.xrTableCell6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.NullValueText = "$0.00";
            this.xrTableCell6.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F);
            this.xrTableCell6.StylePriority.UseFont = false;
            this.xrTableCell6.StylePriority.UsePadding = false;
            this.xrTableCell6.StylePriority.UseTextAlignment = false;
            this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell6.Weight = 0.97655192858763851D;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrLblPayment,
            this.xrQtyPayments,
            this.xrPaymentAmount});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 0.60000000000000009D;
            // 
            // xrLblPayment
            // 
            this.xrLblPayment.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CalcTrimPayment")});
            this.xrLblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.xrLblPayment.Name = "xrLblPayment";
            this.xrLblPayment.StylePriority.UseFont = false;
            this.xrLblPayment.Weight = 1.7570742135072126D;
            // 
            // xrQtyPayments
            // 
            this.xrQtyPayments.CanGrow = false;
            this.xrQtyPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.xrQtyPayments.Name = "xrQtyPayments";
            this.xrQtyPayments.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F);
            this.xrQtyPayments.StylePriority.UseFont = false;
            this.xrQtyPayments.StylePriority.UsePadding = false;
            this.xrQtyPayments.StylePriority.UseTextAlignment = false;
            this.xrQtyPayments.Text = "xrQtyPayments";
            this.xrQtyPayments.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrQtyPayments.Weight = 0.37628078855883629D;
            this.xrQtyPayments.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.xrQtyPayments_PrintOnPage_1);
            // 
            // xrPaymentAmount
            // 
            this.xrPaymentAmount.CanGrow = false;
            this.xrPaymentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.xrPaymentAmount.Name = "xrPaymentAmount";
            this.xrPaymentAmount.NullValueText = "$0.00";
            this.xrPaymentAmount.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F);
            this.xrPaymentAmount.StylePriority.UseFont = false;
            this.xrPaymentAmount.StylePriority.UsePadding = false;
            this.xrPaymentAmount.StylePriority.UseTextAlignment = false;
            this.xrPaymentAmount.Text = "xrPaymentAmount";
            this.xrPaymentAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrPaymentAmount.Weight = 0.97655192858763851D;
            this.xrPaymentAmount.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.xrPaymentAmount_PrintOnPage);
            // 
            // xrTROther
            // 
            this.xrTROther.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrLblOther,
            this.xrQtyOtherCredits,
            this.xrOtherAmount});
            this.xrTROther.Name = "xrTROther";
            this.xrTROther.Weight = 0.6000000000000002D;
            // 
            // xrLblOther
            // 
            this.xrLblOther.CanShrink = true;
            this.xrLblOther.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CalcTrimOther")});
            this.xrLblOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.xrLblOther.Name = "xrLblOther";
            this.xrLblOther.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink;
            this.xrLblOther.StylePriority.UseFont = false;
            this.xrLblOther.Weight = 1.7570742135072126D;
            // 
            // xrQtyOtherCredits
            // 
            this.xrQtyOtherCredits.CanGrow = false;
            this.xrQtyOtherCredits.CanShrink = true;
            this.xrQtyOtherCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.xrQtyOtherCredits.Name = "xrQtyOtherCredits";
            this.xrQtyOtherCredits.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F);
            this.xrQtyOtherCredits.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink;
            this.xrQtyOtherCredits.StylePriority.UseFont = false;
            this.xrQtyOtherCredits.StylePriority.UsePadding = false;
            this.xrQtyOtherCredits.StylePriority.UseTextAlignment = false;
            this.xrQtyOtherCredits.Text = "xrQtyOtherCredits";
            this.xrQtyOtherCredits.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrQtyOtherCredits.Weight = 0.37628078855883629D;
            this.xrQtyOtherCredits.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.xrQtyOtherCredits_PrintOnPage);
            // 
            // xrOtherAmount
            // 
            this.xrOtherAmount.CanGrow = false;
            this.xrOtherAmount.CanShrink = true;
            this.xrOtherAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.xrOtherAmount.Name = "xrOtherAmount";
            this.xrOtherAmount.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F);
            this.xrOtherAmount.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink;
            this.xrOtherAmount.StylePriority.UseFont = false;
            this.xrOtherAmount.StylePriority.UsePadding = false;
            this.xrOtherAmount.StylePriority.UseTextAlignment = false;
            this.xrOtherAmount.Text = "xrOtherAmount";
            this.xrOtherAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrOtherAmount.Weight = 0.97655192858763851D;
            this.xrOtherAmount.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.xrOtherAmount_PrintOnPage);
            // 
            // xrTableRow8
            // 
            this.xrTableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrLblCancellation,
            this.xrQtyCancellations,
            this.xrCancellationAmount});
            this.xrTableRow8.Name = "xrTableRow8";
            this.xrTableRow8.Weight = 0.6000000000000002D;
            // 
            // xrLblCancellation
            // 
            this.xrLblCancellation.CanShrink = true;
            this.xrLblCancellation.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CalcTrimCancellation" +
                    "s")});
            this.xrLblCancellation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.xrLblCancellation.Name = "xrLblCancellation";
            this.xrLblCancellation.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink;
            this.xrLblCancellation.StylePriority.UseFont = false;
            this.xrLblCancellation.Weight = 1.7570742135072126D;
            // 
            // xrQtyCancellations
            // 
            this.xrQtyCancellations.CanGrow = false;
            this.xrQtyCancellations.CanShrink = true;
            this.xrQtyCancellations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.xrQtyCancellations.Name = "xrQtyCancellations";
            this.xrQtyCancellations.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F);
            this.xrQtyCancellations.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink;
            this.xrQtyCancellations.StylePriority.UseFont = false;
            this.xrQtyCancellations.StylePriority.UsePadding = false;
            this.xrQtyCancellations.StylePriority.UseTextAlignment = false;
            this.xrQtyCancellations.Text = "xrQtyCancellations";
            this.xrQtyCancellations.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrQtyCancellations.Weight = 0.37628078855883629D;
            this.xrQtyCancellations.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.xrQtyCancellations_PrintOnPage);
            // 
            // xrCancellationAmount
            // 
            this.xrCancellationAmount.CanGrow = false;
            this.xrCancellationAmount.CanShrink = true;
            this.xrCancellationAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.xrCancellationAmount.Name = "xrCancellationAmount";
            this.xrCancellationAmount.NullValueText = "$0.00";
            this.xrCancellationAmount.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F);
            this.xrCancellationAmount.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink;
            this.xrCancellationAmount.StylePriority.UseFont = false;
            this.xrCancellationAmount.StylePriority.UsePadding = false;
            this.xrCancellationAmount.StylePriority.UseTextAlignment = false;
            this.xrCancellationAmount.Text = "xrCancellationAmount";
            this.xrCancellationAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrCancellationAmount.Weight = 0.97655192858763851D;
            this.xrCancellationAmount.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.xrCancellationAmount_PrintOnPage);
            // 
            // xrTableRow10
            // 
            this.xrTableRow10.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrLblDebitCard,
            this.xrQtyDebitCard,
            this.xrDebitCardAmount});
            this.xrTableRow10.Name = "xrTableRow10";
            this.xrTableRow10.Weight = 0.6000000000000002D;
            this.xrTableRow10.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.xrTableRow10_PrintOnPage);
            // 
            // xrLblDebitCard
            // 
            this.xrLblDebitCard.CanShrink = true;
            this.xrLblDebitCard.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CalcDebitCard")});
            this.xrLblDebitCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.xrLblDebitCard.Name = "xrLblDebitCard";
            this.xrLblDebitCard.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F);
            this.xrLblDebitCard.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink;
            this.xrLblDebitCard.StylePriority.UseFont = false;
            this.xrLblDebitCard.StylePriority.UsePadding = false;
            this.xrLblDebitCard.Weight = 1.7570742135072126D;
            // 
            // xrQtyDebitCard
            // 
            this.xrQtyDebitCard.CanGrow = false;
            this.xrQtyDebitCard.CanShrink = true;
            this.xrQtyDebitCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.xrQtyDebitCard.Name = "xrQtyDebitCard";
            this.xrQtyDebitCard.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F);
            this.xrQtyDebitCard.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink;
            this.xrQtyDebitCard.StylePriority.UseFont = false;
            this.xrQtyDebitCard.StylePriority.UsePadding = false;
            this.xrQtyDebitCard.StylePriority.UseTextAlignment = false;
            this.xrQtyDebitCard.Text = "xrQtyDebitCard";
            this.xrQtyDebitCard.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrQtyDebitCard.Weight = 0.37628078855883629D;
            this.xrQtyDebitCard.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.xrQtyDebitCard_PrintOnPage);
            // 
            // xrDebitCardAmount
            // 
            this.xrDebitCardAmount.CanGrow = false;
            this.xrDebitCardAmount.CanShrink = true;
            this.xrDebitCardAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.xrDebitCardAmount.Name = "xrDebitCardAmount";
            this.xrDebitCardAmount.NullValueText = "$0.00";
            this.xrDebitCardAmount.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F);
            this.xrDebitCardAmount.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink;
            this.xrDebitCardAmount.StylePriority.UseFont = false;
            this.xrDebitCardAmount.StylePriority.UsePadding = false;
            this.xrDebitCardAmount.StylePriority.UseTextAlignment = false;
            this.xrDebitCardAmount.Text = "xrDebitCardAmount";
            this.xrDebitCardAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrDebitCardAmount.Weight = 0.97655192858763851D;
            this.xrDebitCardAmount.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.xrDebitCardAmount_PrintOnPage);
            // 
            // xrTableRow9
            // 
            this.xrTableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell12,
            this.xrQtyBP,
            this.xrAmountBP});
            this.xrTableRow9.Name = "xrTableRow9";
            this.xrTableRow9.Weight = 0.6000000000000002D;
            this.xrTableRow9.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.xrTableRow9_PrintOnPage);
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.CanShrink = true;
            this.xrTableCell12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CalcTrimBP")});
            this.xrTableCell12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell12.StylePriority.UseFont = false;
            this.xrTableCell12.Weight = 1.7570742135072126D;
            // 
            // xrQtyBP
            // 
            this.xrQtyBP.CanGrow = false;
            this.xrQtyBP.CanShrink = true;
            this.xrQtyBP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.xrQtyBP.Name = "xrQtyBP";
            this.xrQtyBP.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F);
            this.xrQtyBP.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink;
            this.xrQtyBP.StylePriority.UseFont = false;
            this.xrQtyBP.StylePriority.UsePadding = false;
            this.xrQtyBP.StylePriority.UseTextAlignment = false;
            this.xrQtyBP.Text = "xrQtyBP";
            this.xrQtyBP.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrQtyBP.Weight = 0.37628078855883629D;
            this.xrQtyBP.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.xrQtyBP_PrintOnPage);
            // 
            // xrAmountBP
            // 
            this.xrAmountBP.CanGrow = false;
            this.xrAmountBP.CanShrink = true;
            this.xrAmountBP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.xrAmountBP.Name = "xrAmountBP";
            this.xrAmountBP.NullValueText = "$0.00";
            this.xrAmountBP.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 2, 0, 0, 100F);
            this.xrAmountBP.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink;
            this.xrAmountBP.StylePriority.UseFont = false;
            this.xrAmountBP.StylePriority.UsePadding = false;
            this.xrAmountBP.StylePriority.UseTextAlignment = false;
            this.xrAmountBP.Text = "xrAmountBP";
            this.xrAmountBP.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrAmountBP.Weight = 0.97655192858763851D;
            this.xrAmountBP.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.xrAmountBP_PrintOnPage);
            // 
            // frGreenBorderColor
            // 
            this.frGreenBorderColor.Condition = "[Parameters.BlackAndWhite] == False";
            this.frGreenBorderColor.Formatting.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(179)))), ((int)(((byte)(65)))));
            this.frGreenBorderColor.Name = "frGreenBorderColor";
            // 
            // xrLabel3
            // 
            this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Header(@StatementId).CalcAgInfoOwner")});
            this.xrLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(9.999974F, 10.00001F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(316.6666F, 18.20831F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.Text = "xrLabel3";
            // 
            // xrLabel4
            // 
            this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Header(@StatementId).CalcAgInfo")});
            this.xrLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(9.999974F, 44.74999F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(316.6666F, 13F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.Text = "xrLabel4";
            // 
            // xrWiresLabel
            // 
            this.xrWiresLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Wires")});
            this.xrWiresLabel.LocationFloat = new DevExpress.Utils.PointFloat(9.999974F, 109.4168F);
            this.xrWiresLabel.Name = "xrWiresLabel";
            this.xrWiresLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrWiresLabel.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrWiresLabel.Visible = false;
            // 
            // Payments
            // 
            this.Payments.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubPayment});
            this.Payments.Expanded = false;
            this.Payments.HeightF = 4.666646F;
            this.Payments.Name = "Payments";
            // 
            // xrSubPayment
            // 
            this.xrSubPayment.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrSubPayment.Name = "xrSubPayment";
            this.xrSubPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("StatementId", this.StatementId));
            this.xrSubPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("BlackAndWhite", this.BlackAndWhite));
            this.xrSubPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Date", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Date"));
            this.xrSubPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("lblPayments", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CalcPaymentLabel"));
            this.xrSubPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Description", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Description"));
            this.xrSubPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Deposit", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Deposits"));
            this.xrSubPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("lblBalance", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Balance"));
            this.xrSubPayment.ReportSource = new WebAPIReports.Reports.Invoice.RptInvoicePayment();
            this.xrSubPayment.SizeF = new System.Drawing.SizeF(765F, 3.208319F);
            // 
            // StatementId
            // 
            this.StatementId.Description = "StatementId";
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
            this.BlackAndWhite.ValueInfo = "False";
            this.BlackAndWhite.Visible = false;
            // 
            // OtherCreditsDebits
            // 
            this.OtherCreditsDebits.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubOther});
            this.OtherCreditsDebits.Expanded = false;
            this.OtherCreditsDebits.HeightF = 3.729184F;
            this.OtherCreditsDebits.Name = "OtherCreditsDebits";
            // 
            // xrSubOther
            // 
            this.xrSubOther.LocationFloat = new DevExpress.Utils.PointFloat(0.0001271566F, 0F);
            this.xrSubOther.Name = "xrSubOther";
            this.xrSubOther.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("StatementId", this.StatementId));
            this.xrSubOther.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("BlackAndWhite", this.BlackAndWhite));
            this.xrSubOther.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("OtherLabel", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CalcOtherLabel"));
            this.xrSubOther.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Description", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Description"));
            this.xrSubOther.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Amount", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).ActivityBalance"));
            this.xrSubOther.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("lblBalance", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Balance"));
            this.xrSubOther.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Date", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Date"));
            this.xrSubOther.ReportSource = new WebAPIReports.Reports.Invoice.RptInvoiceOther();
            this.xrSubOther.SizeF = new System.Drawing.SizeF(764.9999F, 3.208319F);
            // 
            // Cancellations
            // 
            this.Cancellations.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubCancellations});
            this.Cancellations.Expanded = false;
            this.Cancellations.HeightF = 4.249986F;
            this.Cancellations.Name = "Cancellations";
            // 
            // xrSubCancellations
            // 
            this.xrSubCancellations.LocationFloat = new DevExpress.Utils.PointFloat(0.0001271566F, 0F);
            this.xrSubCancellations.Name = "xrSubCancellations";
            this.xrSubCancellations.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("StatementId", this.StatementId));
            this.xrSubCancellations.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("CancellationLabel", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CalcCancellationLabe" +
            "l"));
            this.xrSubCancellations.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Date", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Date"));
            this.xrSubCancellations.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Control", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Control"));
            this.xrSubCancellations.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("WireNo", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).WireNo"));
            this.xrSubCancellations.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Descript", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Description"));
            this.xrSubCancellations.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Country", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Country"));
            this.xrSubCancellations.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Transfer", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Transfer"));
            this.xrSubCancellations.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Fee", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Fee"));
            this.xrSubCancellations.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("SateFee", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).StateFee"));
            this.xrSubCancellations.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgComm", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CommAg"));
            this.xrSubCancellations.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Other", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Other"));
            this.xrSubCancellations.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Void", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Void"));
            this.xrSubCancellations.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Amount", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).ActivityBalance"));
            this.xrSubCancellations.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("lblBalance", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Balance"));
            this.xrSubCancellations.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("BlackAndWhite", this.BlackAndWhite));
            this.xrSubCancellations.ReportSource = new WebAPIReports.Reports.Invoice.RptInvoiceCancellations();
            this.xrSubCancellations.SizeF = new System.Drawing.SizeF(764.9999F, 4.249986F);
            // 
            // Wires
            // 
            this.Wires.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubWires});
            this.Wires.Expanded = false;
            this.Wires.HeightF = 5.666701F;
            this.Wires.Name = "Wires";
            // 
            // xrSubWires
            // 
            this.xrSubWires.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrSubWires.Name = "xrSubWires";
            this.xrSubWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("StatementId", this.StatementId));
            this.xrSubWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("WireLabel", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CalcWireSentLabel"));
            this.xrSubWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Date", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Date"));
            this.xrSubWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Control", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Control"));
            this.xrSubWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("WireNo", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).WireNo"));
            this.xrSubWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Sender", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Sender"));
            this.xrSubWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Country", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Country"));
            this.xrSubWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Transfer", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Transfer"));
            this.xrSubWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Fee", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Fee"));
            this.xrSubWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("StateFee", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).StateFee"));
            this.xrSubWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgComm", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CommAg"));
            this.xrSubWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Other", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Other"));
            this.xrSubWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Void", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Void"));
            this.xrSubWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Amount", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).ActivityBalance"));
            this.xrSubWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Balance", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Balance"));
            this.xrSubWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LanguageId", this.LanguageId));
            this.xrSubWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("BlackAndWhite", this.BlackAndWhite));
            this.xrSubWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Note", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CalcNote"));
            this.xrSubWires.ReportSource = new WebAPIReports.Reports.Invoice.RptInvoiceWires();
            this.xrSubWires.SizeF = new System.Drawing.SizeF(765F, 4.944462F);
            // 
            // LanguageId
            // 
            this.LanguageId.Name = "LanguageId";
            this.LanguageId.Type = typeof(int);
            this.LanguageId.ValueInfo = "2";
            this.LanguageId.Visible = false;
            // 
            // DebitCard
            // 
            this.DebitCard.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubDebitCard});
            this.DebitCard.Expanded = false;
            this.DebitCard.HeightF = 8.333333F;
            this.DebitCard.Name = "DebitCard";
            // 
            // xrSubDebitCard
            // 
            this.xrSubDebitCard.LocationFloat = new DevExpress.Utils.PointFloat(0.0001271566F, 0F);
            this.xrSubDebitCard.Name = "xrSubDebitCard";
            this.xrSubDebitCard.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("StatementId", this.StatementId));
            this.xrSubDebitCard.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("BlackAndWhite", this.BlackAndWhite));
            this.xrSubDebitCard.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Date", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Date"));
            this.xrSubDebitCard.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Sender", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Sender"));
            this.xrSubDebitCard.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Fee", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Fee"));
            this.xrSubDebitCard.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgComm", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CommAg"));
            this.xrSubDebitCard.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Amount", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).ActivityBalance"));
            this.xrSubDebitCard.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Balance", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Balance"));
            this.xrSubDebitCard.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("TransacID", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CalcTransact"));
            this.xrSubDebitCard.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("OriAmount", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Amount    "));
            this.xrSubDebitCard.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("DebitCard", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CalcDebitCard"));
            this.xrSubDebitCard.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Control", null, null));
            this.xrSubDebitCard.ReportSource = new WebAPIReports.Reports.Invoice.RptInvoiceDebitCard();
            this.xrSubDebitCard.SizeF = new System.Drawing.SizeF(764.9999F, 4.944439F);
            // 
            // BillPayment
            // 
            this.BillPayment.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel7,
            this.xrSubreport1});
            this.BillPayment.Expanded = false;
            this.BillPayment.HeightF = 33.94444F;
            this.BillPayment.Name = "BillPayment";
            // 
            // xrPanel7
            // 
            this.xrPanel7.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPanel7.BorderWidth = 2F;
            this.xrPanel7.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel25,
            this.xrLabel26});
            this.xrPanel7.FormattingRules.Add(this.frGreenBorderColor);
            this.xrPanel7.LocationFloat = new DevExpress.Utils.PointFloat(508.0216F, 4.944441F);
            this.xrPanel7.Name = "xrPanel7";
            this.xrPanel7.SizeF = new System.Drawing.SizeF(256.9784F, 29F);
            this.xrPanel7.StylePriority.UseBorders = false;
            this.xrPanel7.StylePriority.UseBorderWidth = false;
            // 
            // xrLabel25
            // 
            this.xrLabel25.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel25.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Header(@StatementId).EndingBalance", "{0:$#,##0.00}")});
            this.xrLabel25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(141.9263F, 3.770786F);
            this.xrLabel25.Name = "xrLabel25";
            this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel25.SizeF = new System.Drawing.SizeF(110.8177F, 19.87502F);
            this.xrLabel25.StylePriority.UseBorders = false;
            this.xrLabel25.StylePriority.UseFont = false;
            this.xrLabel25.StylePriority.UseTextAlignment = false;
            this.xrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel26
            // 
            this.xrLabel26.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel26.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).TotalPaymentDue")});
            this.xrLabel26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(6.00001F, 3.770786F);
            this.xrLabel26.Name = "xrLabel26";
            this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel26.SizeF = new System.Drawing.SizeF(135.9263F, 19.87502F);
            this.xrLabel26.StylePriority.UseBorders = false;
            this.xrLabel26.StylePriority.UseFont = false;
            this.xrLabel26.StylePriority.UseTextAlignment = false;
            this.xrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrSubreport1
            // 
            this.xrSubreport1.LocationFloat = new DevExpress.Utils.PointFloat(0.0001271566F, 0F);
            this.xrSubreport1.Name = "xrSubreport1";
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("StatementId", this.StatementId));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("BlackAndWhite", this.BlackAndWhite));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Date", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Date"));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Control", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Control"));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Sender", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Sender"));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Service", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CalcService"));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AmountBP", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Amount    "));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Fee", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Fee"));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgComm", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CommAg"));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Amount", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).ActivityBalance"));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Balance", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Balance"));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Sequence", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CalcSeqNo"));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("BillPayment", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CalcTrimBP"));
            this.xrSubreport1.ReportSource = new WebAPIReports.Reports.Invoice.RptInvoiceBillPayment();
            this.xrSubreport1.SizeF = new System.Drawing.SizeF(764.9999F, 4.944441F);
            // 
            // xrTransDate
            // 
            this.xrTransDate.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTransDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.xrTransDate.LocationFloat = new DevExpress.Utils.PointFloat(642.4288F, 93.12502F);
            this.xrTransDate.Name = "xrTransDate";
            this.xrTransDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 0, 0, 0, 100F);
            this.xrTransDate.SizeF = new System.Drawing.SizeF(119.34F, 16.74998F);
            this.xrTransDate.StylePriority.UseBorders = false;
            this.xrTransDate.StylePriority.UseFont = false;
            this.xrTransDate.StylePriority.UsePadding = false;
            this.xrTransDate.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.xrTransDate_PrintOnPage);
            // 
            // WireTransac
            // 
            this.WireTransac.ConnectionName = "Prod_WireTransac_Connection";
            this.WireTransac.Name = "WireTransac";
            storedProcQuery2.Name = "Acc_Invoice_Header(@StatementId)";
            queryParameter3.Name = "@StatementId";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("[Parameters.StatementId]", typeof(int));
            storedProcQuery2.Parameters.Add(queryParameter3);
            storedProcQuery2.StoredProcName = "Acc_Invoice_Header";
            this.WireTransac.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery2});
            this.WireTransac.ResultSchemaSerializable = resources.GetString("WireTransac.ResultSchemaSerializable");
            // 
            // xrLabel12
            // 
            this.xrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel12.CanGrow = false;
            this.xrLabel12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).InvoiceNum")});
            this.xrLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(0.0001271566F, 93.12502F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(94.51828F, 16.74999F);
            this.xrLabel12.StylePriority.UseBorders = false;
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UsePadding = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel12.TextFormatString = "{0}:";
            this.xrLabel12.WordWrap = false;
            // 
            // xrLabel13
            // 
            this.xrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Header(@StatementId).StatementId")});
            this.xrLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(94.51841F, 93.12502F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 0, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(73.95833F, 16.74998F);
            this.xrLabel13.StylePriority.UseBorders = false;
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.StylePriority.UsePadding = false;
            // 
            // xrLabel15
            // 
            this.xrLabel15.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Header(@StatementId).AgStatementSeq")});
            this.xrLabel15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(532.2291F, 93.12502F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 0, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(61.45831F, 16.74997F);
            this.xrLabel15.StylePriority.UseBorders = false;
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.StylePriority.UsePadding = false;
            // 
            // xrLabel14
            // 
            this.xrLabel14.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).AgencySeq")});
            this.xrLabel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(442.8129F, 93.12502F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(89.41626F, 16.74998F);
            this.xrLabel14.StylePriority.UseBorders = false;
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UsePadding = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel14.TextFormatString = "{0}:";
            // 
            // xrLabel16
            // 
            this.xrLabel16.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel16.CanGrow = false;
            this.xrLabel16.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Date")});
            this.xrLabel16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(593.6874F, 93.12502F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(48.74142F, 16.74998F);
            this.xrLabel16.StylePriority.UseBorders = false;
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.StylePriority.UsePadding = false;
            this.xrLabel16.StylePriority.UseTextAlignment = false;
            this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel16.TextFormatString = "{0}:";
            this.xrLabel16.WordWrap = false;
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
            // frGreenForeColor
            // 
            this.frGreenForeColor.Condition = "[Parameters.BlackAndWhite] == False";
            this.frGreenForeColor.Formatting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(179)))), ((int)(((byte)(65)))));
            this.frGreenForeColor.Name = "frGreenForeColor";
            // 
            // xrLabel2
            // 
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Header(@StatementId).CalcLegalEntiyInfo")});
            this.xrLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(267.2624F, 36.87506F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(232.2917F, 23F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "xrLabel2";
            // 
            // xrLine2
            // 
            this.xrLine2.BorderColor = System.Drawing.Color.Black;
            this.xrLine2.ForeColor = System.Drawing.Color.Black;
            this.xrLine2.FormattingRules.Add(this.frGreenForeColor);
            this.xrLine2.LineWidth = 2;
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 83F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(765F, 6F);
            this.xrLine2.StylePriority.UseBorderColor = false;
            this.xrLine2.StylePriority.UseForeColor = false;
            // 
            // xrLine1
            // 
            this.xrLine1.ForeColor = System.Drawing.Color.Black;
            this.xrLine1.FormattingRules.Add(this.frGreenForeColor);
            this.xrLine1.LineWidth = 10;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(765F, 10.5F);
            this.xrLine1.StylePriority.UseForeColor = false;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.FormattingRules.Add(this.frColorLogoVisible);
            this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 1.250044F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(230F, 57F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.xrPictureBox1.Visible = false;
            // 
            // frColorLogoVisible
            // 
            this.frColorLogoVisible.Condition = "[Parameters.BlackAndWhite] == False";
            this.frColorLogoVisible.Formatting.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.frColorLogoVisible.Name = "frColorLogoVisible";
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
            // CalcHeaderInfo
            // 
            this.CalcHeaderInfo.DataMember = "Acc_Invoice_Header(@StatementId)";
            this.CalcHeaderInfo.Expression = "Iif([AgLanguageId] == 1,\'Please send your deposit receipt to:\',\'Favor de enviar s" +
    "u recibo de deposito a:\')";
            this.CalcHeaderInfo.Name = "CalcHeaderInfo";
            // 
            // FormName
            // 
            this.FormName.Name = "FormName";
            this.FormName.ValueInfo = "REPORT.ACCOUNTING.NEWINVOICE";
            this.FormName.Visible = false;
            // 
            // CalcInfoHeader
            // 
            this.CalcInfoHeader.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcInfoHeader.DataSource = this.WireSecurity;
            this.CalcInfoHeader.Expression = resources.GetString("CalcInfoHeader.Expression");
            this.CalcInfoHeader.Name = "CalcInfoHeader";
            // 
            // CalcLegalEntiyInfo
            // 
            this.CalcLegalEntiyInfo.DataMember = "Acc_Invoice_Header(@StatementId)";
            this.CalcLegalEntiyInfo.Expression = "[LegalEntityOfficialName]\n+Char(13)\n+ [LegalEntityAddress]\n+ Char(13)\n+ [LECity] " +
    "+ \', \' + [LEState] + \' \' + [LEZip]";
            this.CalcLegalEntiyInfo.Name = "CalcLegalEntiyInfo";
            // 
            // CalcAgInfoOwner
            // 
            this.CalcAgInfoOwner.DataMember = "Acc_Invoice_Header(@StatementId)";
            this.CalcAgInfoOwner.Expression = "Trim([AgencyCode]) + \' / \' + [Agname]\n+ Char(13)\n+ \'Mr(s.) \' + Trim([AgOwnerFirst" +
    "Name]) + \' \' + Trim([AgOwnerLastName])";
            this.CalcAgInfoOwner.Name = "CalcAgInfoOwner";
            // 
            // CalcAgInfo
            // 
            this.CalcAgInfo.DataMember = "Acc_Invoice_Header(@StatementId)";
            this.CalcAgInfo.Expression = "[AgAddress] + \' \'\n+ [AgAddress2]\n+ Char(13)\n+ [AgCity] + \', \' + [AgStateAbbr] + \'" +
    " \' + [AgZip]";
            this.CalcAgInfo.Name = "CalcAgInfo";
            // 
            // CalcTotalPaymentAmount
            // 
            this.CalcTotalPaymentAmount.DataMember = "Acc_Invoice_Payments";
            this.CalcTotalPaymentAmount.Expression = "Sum([Amount])";
            this.CalcTotalPaymentAmount.Name = "CalcTotalPaymentAmount";
            this.CalcTotalPaymentAmount.Scripts.OnGetValue = "CalcTotalPaymentAmount_GetValue";
            // 
            // CalcPaymentLabel
            // 
            this.CalcPaymentLabel.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcPaymentLabel.DataSource = this.WireSecurity;
            this.CalcPaymentLabel.Expression = "Upper([Payments])";
            this.CalcPaymentLabel.Name = "CalcPaymentLabel";
            // 
            // calculatedField1
            // 
            this.calculatedField1.DataMember = "Acc_Invoice_OtherCreditsDebits";
            this.calculatedField1.DisplayName = "CalcAmountDC";
            this.calculatedField1.Expression = "Sum([Amount])";
            this.calculatedField1.Name = "calculatedField1";
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel29,
            this.xrLabel7,
            this.xrTransDate,
            this.xrLabel28,
            this.xrLabel27,
            this.xrRightInfoHeader,
            this.xrIHLineEndValue,
            this.xrIHLineEnd,
            this.xrIHPhoneValue,
            this.xrIHPhone,
            this.xrIHEmailValue,
            this.xrIHEmail,
            this.xrIHFaxValue,
            this.xrIHFax,
            this.xrIHLine1,
            this.xrLine4,
            this.xrLabel13,
            this.xrLabel15,
            this.xrLabel14,
            this.xrLabel16,
            this.xrLabel12,
            this.xrLabel2,
            this.xrLine2,
            this.xrLine1,
            this.xrPanel3});
            this.PageHeader.HeightF = 120.375F;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.PageHeader_BeforePrint);
            // 
            // xrLabel29
            // 
            this.xrLabel29.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel29.CanGrow = false;
            this.xrLabel29.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Header(@StatementId).StatementCurrency")});
            this.xrLabel29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(249.1379F, 93.12501F);
            this.xrLabel29.Name = "xrLabel29";
            this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 0, 0, 0, 100F);
            this.xrLabel29.SizeF = new System.Drawing.SizeF(40.9F, 16.74999F);
            this.xrLabel29.StylePriority.UseBorders = false;
            this.xrLabel29.StylePriority.UseFont = false;
            this.xrLabel29.StylePriority.UsePadding = false;
            this.xrLabel29.WordWrap = false;
            // 
            // xrLabel7
            // 
            this.xrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel7.CanGrow = false;
            this.xrLabel7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CalcStCurrency")});
            this.xrLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(168.4767F, 93.12502F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(80.66116F, 16.74998F);
            this.xrLabel7.StylePriority.UseBorders = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UsePadding = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel7.TextFormatString = "{0}:";
            this.xrLabel7.WordWrap = false;
            // 
            // xrLabel28
            // 
            this.xrLabel28.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel28.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Agency")});
            this.xrLabel28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(290.0379F, 93.12502F);
            this.xrLabel28.Name = "xrLabel28";
            this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100F);
            this.xrLabel28.SizeF = new System.Drawing.SizeF(62.60562F, 16.74999F);
            this.xrLabel28.StylePriority.UseBorders = false;
            this.xrLabel28.StylePriority.UseFont = false;
            this.xrLabel28.StylePriority.UsePadding = false;
            this.xrLabel28.StylePriority.UseTextAlignment = false;
            this.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel28.TextFormatString = "{0}:";
            // 
            // xrLabel27
            // 
            this.xrLabel27.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel27.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Header(@StatementId).AgencyCode")});
            this.xrLabel27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(352.6435F, 93.12502F);
            this.xrLabel27.Name = "xrLabel27";
            this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 0, 0, 0, 100F);
            this.xrLabel27.SizeF = new System.Drawing.SizeF(90.16943F, 16.74998F);
            this.xrLabel27.StylePriority.UseBorders = false;
            this.xrLabel27.StylePriority.UseFont = false;
            this.xrLabel27.StylePriority.UsePadding = false;
            // 
            // xrRightInfoHeader
            // 
            this.xrRightInfoHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.xrRightInfoHeader.LocationFloat = new DevExpress.Utils.PointFloat(508.0216F, 12F);
            this.xrRightInfoHeader.Multiline = true;
            this.xrRightInfoHeader.Name = "xrRightInfoHeader";
            this.xrRightInfoHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRightInfoHeader.SizeF = new System.Drawing.SizeF(252.2948F, 70.99998F);
            this.xrRightInfoHeader.StylePriority.UseFont = false;
            this.xrRightInfoHeader.Text = "xrLabel17";
            this.xrRightInfoHeader.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrInfoHeader_BeforePrint);
            // 
            // xrIHLineEndValue
            // 
            this.xrIHLineEndValue.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Header(@StatementId).LEInvoicePhone")});
            this.xrIHLineEndValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.xrIHLineEndValue.LocationFloat = new DevExpress.Utils.PointFloat(411.8203F, 66F);
            this.xrIHLineEndValue.Name = "xrIHLineEndValue";
            this.xrIHLineEndValue.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrIHLineEndValue.SizeF = new System.Drawing.SizeF(41.14587F, 9F);
            this.xrIHLineEndValue.StylePriority.UseFont = false;
            this.xrIHLineEndValue.Text = "xrLabel17";
            this.xrIHLineEndValue.Visible = false;
            // 
            // xrIHLineEnd
            // 
            this.xrIHLineEnd.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).LikeInfo")});
            this.xrIHLineEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.xrIHLineEnd.LocationFloat = new DevExpress.Utils.PointFloat(369.3754F, 66F);
            this.xrIHLineEnd.Name = "xrIHLineEnd";
            this.xrIHLineEnd.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrIHLineEnd.SizeF = new System.Drawing.SizeF(42.4449F, 9.000004F);
            this.xrIHLineEnd.StylePriority.UseFont = false;
            this.xrIHLineEnd.Text = "xrLabel21";
            this.xrIHLineEnd.Visible = false;
            // 
            // xrIHPhoneValue
            // 
            this.xrIHPhoneValue.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Header(@StatementId).LECellPhone")});
            this.xrIHPhoneValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.xrIHPhoneValue.LocationFloat = new DevExpress.Utils.PointFloat(312.0752F, 66F);
            this.xrIHPhoneValue.Name = "xrIHPhoneValue";
            this.xrIHPhoneValue.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrIHPhoneValue.SizeF = new System.Drawing.SizeF(51.74216F, 9F);
            this.xrIHPhoneValue.StylePriority.UseFont = false;
            this.xrIHPhoneValue.Text = "xrLabel17";
            this.xrIHPhoneValue.Visible = false;
            // 
            // xrIHPhone
            // 
            this.xrIHPhone.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CellPhone")});
            this.xrIHPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.xrIHPhone.LocationFloat = new DevExpress.Utils.PointFloat(259.222F, 66F);
            this.xrIHPhone.Name = "xrIHPhone";
            this.xrIHPhone.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrIHPhone.SizeF = new System.Drawing.SizeF(51.74216F, 9F);
            this.xrIHPhone.StylePriority.UseFont = false;
            this.xrIHPhone.Text = "xrLabel10";
            this.xrIHPhone.Visible = false;
            // 
            // xrIHEmailValue
            // 
            this.xrIHEmailValue.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Header(@StatementId).LEEmail")});
            this.xrIHEmailValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.xrIHEmailValue.LocationFloat = new DevExpress.Utils.PointFloat(312.0752F, 27.87506F);
            this.xrIHEmailValue.Name = "xrIHEmailValue";
            this.xrIHEmailValue.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrIHEmailValue.SizeF = new System.Drawing.SizeF(51.74213F, 9F);
            this.xrIHEmailValue.StylePriority.UseFont = false;
            this.xrIHEmailValue.Text = "xrLabel17";
            this.xrIHEmailValue.Visible = false;
            // 
            // xrIHEmail
            // 
            this.xrIHEmail.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Email")});
            this.xrIHEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.xrIHEmail.LocationFloat = new DevExpress.Utils.PointFloat(259.222F, 27.87506F);
            this.xrIHEmail.Name = "xrIHEmail";
            this.xrIHEmail.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrIHEmail.SizeF = new System.Drawing.SizeF(51.74214F, 9F);
            this.xrIHEmail.StylePriority.UseFont = false;
            this.xrIHEmail.Text = "xrLabel5";
            this.xrIHEmail.Visible = false;
            // 
            // xrIHFaxValue
            // 
            this.xrIHFaxValue.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Header(@StatementId).LEFax")});
            this.xrIHFaxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.xrIHFaxValue.LocationFloat = new DevExpress.Utils.PointFloat(363.8173F, 12F);
            this.xrIHFaxValue.Name = "xrIHFaxValue";
            this.xrIHFaxValue.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrIHFaxValue.SizeF = new System.Drawing.SizeF(51.74216F, 9F);
            this.xrIHFaxValue.StylePriority.UseFont = false;
            this.xrIHFaxValue.Text = "xrLabel17";
            this.xrIHFaxValue.Visible = false;
            // 
            // xrIHFax
            // 
            this.xrIHFax.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Fax")});
            this.xrIHFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.xrIHFax.LocationFloat = new DevExpress.Utils.PointFloat(312.0752F, 12F);
            this.xrIHFax.Name = "xrIHFax";
            this.xrIHFax.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrIHFax.SizeF = new System.Drawing.SizeF(51.74214F, 9F);
            this.xrIHFax.StylePriority.UseFont = false;
            this.xrIHFax.Text = "xrLabel4";
            this.xrIHFax.Visible = false;
            // 
            // xrIHLine1
            // 
            this.xrIHLine1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).SendDeposit")});
            this.xrIHLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.xrIHLine1.LocationFloat = new DevExpress.Utils.PointFloat(259.222F, 12F);
            this.xrIHLine1.Name = "xrIHLine1";
            this.xrIHLine1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrIHLine1.SizeF = new System.Drawing.SizeF(51.74216F, 9F);
            this.xrIHLine1.StylePriority.UseFont = false;
            this.xrIHLine1.Text = "xrLabel1";
            this.xrIHLine1.Visible = false;
            // 
            // xrLine4
            // 
            this.xrLine4.BorderColor = System.Drawing.Color.Black;
            this.xrLine4.ForeColor = System.Drawing.Color.Black;
            this.xrLine4.FormattingRules.Add(this.frGreenForeColor);
            this.xrLine4.LineWidth = 2;
            this.xrLine4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 109.875F);
            this.xrLine4.Name = "xrLine4";
            this.xrLine4.SizeF = new System.Drawing.SizeF(765F, 10.5F);
            this.xrLine4.StylePriority.UseBorderColor = false;
            this.xrLine4.StylePriority.UseForeColor = false;
            // 
            // xrPanel3
            // 
            this.xrPanel3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox1,
            this.xrPictureBox2});
            this.xrPanel3.LocationFloat = new DevExpress.Utils.PointFloat(9.999974F, 33.62502F);
            this.xrPanel3.Name = "xrPanel3";
            this.xrPanel3.SizeF = new System.Drawing.SizeF(232.2917F, 64.50002F);
            // 
            // xrPictureBox2
            // 
            this.xrPictureBox2.FormattingRules.Add(this.frBWLogoVisible);
            this.xrPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox2.Image")));
            this.xrPictureBox2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 3.250043F);
            this.xrPictureBox2.Name = "xrPictureBox2";
            this.xrPictureBox2.SizeF = new System.Drawing.SizeF(230F, 55F);
            this.xrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // frBWLogoVisible
            // 
            this.frBWLogoVisible.Condition = "[Parameters.BlackAndWhite] == False";
            this.frBWLogoVisible.Formatting.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.frBWLogoVisible.Name = "frBWLogoVisible";
            // 
            // CalcOtherLabel
            // 
            this.CalcOtherLabel.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcOtherLabel.DataSource = this.WireSecurity;
            this.CalcOtherLabel.DisplayName = "CalcOtherLabel";
            this.CalcOtherLabel.Expression = "Upper([OtherDebitCredit])";
            this.CalcOtherLabel.Name = "CalcOtherLabel";
            // 
            // CalcCancellationLabel
            // 
            this.CalcCancellationLabel.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcCancellationLabel.DataSource = this.WireSecurity;
            this.CalcCancellationLabel.DisplayName = "CalcCancellationLabel";
            this.CalcCancellationLabel.Expression = "Upper([Cancellations])";
            this.CalcCancellationLabel.Name = "CalcCancellationLabel";
            // 
            // CalcWireSentLabel
            // 
            this.CalcWireSentLabel.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcWireSentLabel.DataSource = this.WireSecurity;
            this.CalcWireSentLabel.DisplayName = "CalcWireSentLabel";
            this.CalcWireSentLabel.Expression = "Upper([WireTransfers])";
            this.CalcWireSentLabel.Name = "CalcWireSentLabel";
            // 
            // frGreenBackColor
            // 
            this.frGreenBackColor.Condition = "[Parameters.BlackAndWhite] == False";
            this.frGreenBackColor.Formatting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(179)))), ((int)(((byte)(65)))));
            this.frGreenBackColor.Name = "frGreenBackColor";
            // 
            // CalcAgPhone
            // 
            this.CalcAgPhone.DataMember = "Acc_Invoice_Header(@StatementId)";
            this.CalcAgPhone.Expression = " Iif(not IsNullOrEmpty([AgPhone1]),\n           Iif(Len(Trim([AgPhone1])) <= 10, \n" +
    "\t\t ToLong(Trim([AgPhone1])), \t\t\t\t\t  \t\t ToLong(Substring(Trim([AgPhone1]),0  ,9 )" +
    ")\n\t\t) ,\'\')";
            this.CalcAgPhone.Name = "CalcAgPhone";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo4,
            this.xrLabel17,
            this.xrLine3,
            this.xrPageInfo3,
            this.xrLabel10});
            this.ReportFooter.HeightF = 46.521F;
            this.ReportFooter.KeepTogether = true;
            this.ReportFooter.Name = "ReportFooter";
            this.ReportFooter.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            this.ReportFooter.PrintAtBottom = true;
            // 
            // xrPageInfo4
            // 
            this.xrPageInfo4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.xrPageInfo4.LocationFloat = new DevExpress.Utils.PointFloat(737.9167F, 10.50002F);
            this.xrPageInfo4.Name = "xrPageInfo4";
            this.xrPageInfo4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo4.PageInfo = DevExpress.XtraPrinting.PageInfo.Total;
            this.xrPageInfo4.SizeF = new System.Drawing.SizeF(27.08334F, 17F);
            this.xrPageInfo4.StylePriority.UseFont = false;
            this.xrPageInfo4.StylePriority.UseTextAlignment = false;
            this.xrPageInfo4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel17
            // 
            this.xrLabel17.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Of")});
            this.xrLabel17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(717.9167F, 10.50002F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(20F, 17F);
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UsePadding = false;
            this.xrLabel17.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.xrLabel17_PrintOnPage);
            // 
            // xrLine3
            // 
            this.xrLine3.ForeColor = System.Drawing.Color.Black;
            this.xrLine3.FormattingRules.Add(this.frGreenForeColor);
            this.xrLine3.LineWidth = 10;
            this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine3.Name = "xrLine3";
            this.xrLine3.SizeF = new System.Drawing.SizeF(765F, 10.5F);
            this.xrLine3.StylePriority.UseForeColor = false;
            // 
            // xrPageInfo3
            // 
            this.xrPageInfo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.xrPageInfo3.LocationFloat = new DevExpress.Utils.PointFloat(690.722F, 10.50002F);
            this.xrPageInfo3.Name = "xrPageInfo3";
            this.xrPageInfo3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 0, 0, 100F);
            this.xrPageInfo3.PageInfo = DevExpress.XtraPrinting.PageInfo.Number;
            this.xrPageInfo3.SizeF = new System.Drawing.SizeF(27.1947F, 17F);
            this.xrPageInfo3.StylePriority.UseFont = false;
            this.xrPageInfo3.StylePriority.UsePadding = false;
            this.xrPageInfo3.StylePriority.UseTextAlignment = false;
            this.xrPageInfo3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel10
            // 
            this.xrLabel10.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Page")});
            this.xrLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(623.9088F, 10.50002F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(66.81317F, 17F);
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UsePadding = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel8
            // 
            this.xrLabel8.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Header(@StatementId).AgFaxMessageText")});
            this.xrLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.xrLabel8.FormattingRules.Add(this.frFaxMessage);
            this.xrLabel8.FormattingRules.Add(this.frGreenBorderColor);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(0F, 79.5F);
            this.xrLabel8.Multiline = true;
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(760.3162F, 11.54169F);
            this.xrLabel8.StylePriority.UseBorders = false;
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UsePadding = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
            this.xrLabel8.TextTrimming = System.Drawing.StringTrimming.Word;
            this.xrLabel8.Visible = false;
            // 
            // frFaxMessage
            // 
            this.frFaxMessage.Condition = "Not IsNullOrEmpty([AgFaxMessageText])";
            this.frFaxMessage.Formatting.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.frFaxMessage.Name = "frFaxMessage";
            // 
            // xrPanel6
            // 
            this.xrPanel6.CanShrink = true;
            this.xrPanel6.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel6,
            this.xrPanel5});
            this.xrPanel6.FormattingRules.Add(this.frShowCommissionBox);
            this.xrPanel6.LocationFloat = new DevExpress.Utils.PointFloat(524.9297F, 22.16704F);
            this.xrPanel6.Name = "xrPanel6";
            this.xrPanel6.SizeF = new System.Drawing.SizeF(234.9376F, 55F);
            // 
            // xrLabel6
            // 
            this.xrLabel6.AutoWidth = true;
            this.xrLabel6.CanShrink = true;
            this.xrLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel6.FormattingRules.Add(this.frShowCommiPaymentMethod);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(1.112684F, 41.00005F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(233.8247F, 14F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UsePadding = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrLabel6.Visible = false;
            this.xrLabel6.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel6_BeforePrint);
            // 
            // frShowCommiPaymentMethod
            // 
            this.frShowCommiPaymentMethod.Condition = resources.GetString("frShowCommiPaymentMethod.Condition");
            this.frShowCommiPaymentMethod.Formatting.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.frShowCommiPaymentMethod.Name = "frShowCommiPaymentMethod";
            // 
            // xrPanel5
            // 
            this.xrPanel5.BorderColor = System.Drawing.Color.Black;
            this.xrPanel5.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPanel5.BorderWidth = 1.5F;
            this.xrPanel5.CanShrink = true;
            this.xrPanel5.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTCommission});
            this.xrPanel5.FormattingRules.Add(this.frGreenBorderColor);
            this.xrPanel5.FormattingRules.Add(this.frShowCommissionBox);
            this.xrPanel5.LocationFloat = new DevExpress.Utils.PointFloat(0.1126607F, 0F);
            this.xrPanel5.Name = "xrPanel5";
            this.xrPanel5.SizeF = new System.Drawing.SizeF(234.8248F, 37.00001F);
            this.xrPanel5.StylePriority.UseBorderColor = false;
            this.xrPanel5.StylePriority.UseBorders = false;
            this.xrPanel5.StylePriority.UseBorderWidth = false;
            // 
            // xrTCommission
            // 
            this.xrTCommission.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTCommission.LocationFloat = new DevExpress.Utils.PointFloat(1F, 2.000014F);
            this.xrTCommission.Name = "xrTCommission";
            this.xrTCommission.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow4,
            this.xrTableRow5});
            this.xrTCommission.SizeF = new System.Drawing.SizeF(233.8248F, 31F);
            this.xrTCommission.StylePriority.UseBorders = false;
            this.xrTCommission.StylePriority.UseFont = false;
            this.xrTCommission.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrTCommission_BeforePrint);
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell8});
            this.xrTableRow4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.StylePriority.UseFont = false;
            this.xrTableRow4.Weight = 0.60000000000000009D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableCell8.BorderWidth = 1.5F;
            this.xrTableCell8.CanGrow = false;
            this.xrTableCell8.CanShrink = true;
            this.xrTableCell8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).AgentCommission")});
            this.xrTableCell8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.xrTableCell8.FormattingRules.Add(this.frGreenBorderColor);
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.StylePriority.UseBorders = false;
            this.xrTableCell8.StylePriority.UseBorderWidth = false;
            this.xrTableCell8.StylePriority.UseFont = false;
            this.xrTableCell8.StylePriority.UseTextAlignment = false;
            this.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell8.Weight = 1.8397746789347516D;
            // 
            // xrTableRow5
            // 
            this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell11,
            this.xrTableCell13});
            this.xrTableRow5.Name = "xrTableRow5";
            this.xrTableRow5.Weight = 0.6399999999999999D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.CanGrow = false;
            this.xrTableCell11.CanShrink = true;
            this.xrTableCell11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic);
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F);
            this.xrTableCell11.StylePriority.UseFont = false;
            this.xrTableCell11.StylePriority.UsePadding = false;
            this.xrTableCell11.StylePriority.UseTextAlignment = false;
            this.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell11.Weight = 1.1829009775645365D;
            // 
            // xrTableCell13
            // 
            this.xrTableCell13.CanGrow = false;
            this.xrTableCell13.CanShrink = true;
            this.xrTableCell13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic);
            this.xrTableCell13.Name = "xrTableCell13";
            this.xrTableCell13.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F);
            this.xrTableCell13.StylePriority.UseFont = false;
            this.xrTableCell13.StylePriority.UsePadding = false;
            this.xrTableCell13.StylePriority.UseTextAlignment = false;
            this.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell13.Weight = 0.65687370137021528D;
            // 
            // frShowCommissionBox
            // 
            this.frShowCommissionBox.Condition = "[ShowAgCommiStatement] == False";
            this.frShowCommissionBox.DataMember = "Acc_Invoice_Header(@StatementId)";
            this.frShowCommissionBox.Formatting.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.frShowCommissionBox.Name = "frShowCommissionBox";
            // 
            // xrCommiPaidNote
            // 
            this.xrCommiPaidNote.AutoWidth = true;
            this.xrCommiPaidNote.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).AgCommWillBePAid")});
            this.xrCommiPaidNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.xrCommiPaidNote.LocationFloat = new DevExpress.Utils.PointFloat(453.6461F, 0F);
            this.xrCommiPaidNote.Multiline = true;
            this.xrCommiPaidNote.Name = "xrCommiPaidNote";
            this.xrCommiPaidNote.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
            this.xrCommiPaidNote.SizeF = new System.Drawing.SizeF(110.908F, 14F);
            this.xrCommiPaidNote.StylePriority.UseFont = false;
            this.xrCommiPaidNote.StylePriority.UsePadding = false;
            this.xrCommiPaidNote.StylePriority.UseTextAlignment = false;
            this.xrCommiPaidNote.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrCommiPaidNote.Visible = false;
            // 
            // xrCommyType
            // 
            this.xrCommyType.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Header(@StatementId).CommiPaymentMethod")});
            this.xrCommyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.xrCommyType.LocationFloat = new DevExpress.Utils.PointFloat(369.3754F, 0F);
            this.xrCommyType.Name = "xrCommyType";
            this.xrCommyType.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrCommyType.SizeF = new System.Drawing.SizeF(73.5F, 14F);
            this.xrCommyType.StylePriority.UseFont = false;
            this.xrCommyType.StylePriority.UsePadding = false;
            this.xrCommyType.Visible = false;
            // 
            // CalcCommiPaymentMethod
            // 
            this.CalcCommiPaymentMethod.DataMember = "Acc_Invoice_Header(@StatementId)";
            this.CalcCommiPaymentMethod.Name = "CalcCommiPaymentMethod";
            // 
            // CalcTrimPayment
            // 
            this.CalcTrimPayment.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcTrimPayment.DataSource = this.WireSecurity;
            this.CalcTrimPayment.Expression = "Trim([Payments])";
            this.CalcTrimPayment.Name = "CalcTrimPayment";
            // 
            // CalcTrimOther
            // 
            this.CalcTrimOther.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcTrimOther.DataSource = this.WireSecurity;
            this.CalcTrimOther.Expression = "Trim([OtherDebitCredit])";
            this.CalcTrimOther.Name = "CalcTrimOther";
            // 
            // CalcTrimCancellations
            // 
            this.CalcTrimCancellations.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcTrimCancellations.DataSource = this.WireSecurity;
            this.CalcTrimCancellations.Expression = "Trim([Cancellations])";
            this.CalcTrimCancellations.Name = "CalcTrimCancellations";
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel18,
            this.xrPageInfo1,
            this.xrLabel20,
            this.xrPageInfo2,
            this.xrLine5});
            this.PageFooter.HeightF = 46.521F;
            this.PageFooter.Name = "PageFooter";
            this.PageFooter.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportFooter;
            this.PageFooter.StylePriority.UseTextAlignment = false;
            this.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // xrLabel18
            // 
            this.xrLabel18.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Page")});
            this.xrLabel18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(623.9088F, 10.50002F);
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 0, 0, 100F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(66.81317F, 17F);
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.StylePriority.UsePadding = false;
            this.xrLabel18.StylePriority.UseTextAlignment = false;
            this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(690.722F, 10.50002F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 0, 0, 100F);
            this.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.Number;
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(27.1947F, 17F);
            this.xrPageInfo1.StylePriority.UseFont = false;
            this.xrPageInfo1.StylePriority.UsePadding = false;
            this.xrPageInfo1.StylePriority.UseTextAlignment = false;
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel20
            // 
            this.xrLabel20.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Of")});
            this.xrLabel20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(717.9167F, 10.50002F);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(20F, 17F);
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.StylePriority.UsePadding = false;
            this.xrLabel20.StylePriority.UseTextAlignment = false;
            this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrLabel20.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.xrLabel20_PrintOnPage_1);
            // 
            // xrPageInfo2
            // 
            this.xrPageInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(737.9167F, 10.50002F);
            this.xrPageInfo2.Name = "xrPageInfo2";
            this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.Total;
            this.xrPageInfo2.SizeF = new System.Drawing.SizeF(27.08334F, 17F);
            this.xrPageInfo2.StylePriority.UseFont = false;
            this.xrPageInfo2.StylePriority.UseTextAlignment = false;
            this.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLine5
            // 
            this.xrLine5.ForeColor = System.Drawing.Color.Black;
            this.xrLine5.FormattingRules.Add(this.frGreenForeColor);
            this.xrLine5.LineWidth = 10;
            this.xrLine5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine5.Name = "xrLine5";
            this.xrLine5.SizeF = new System.Drawing.SizeF(765F, 10.5F);
            this.xrLine5.StylePriority.UseForeColor = false;
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCommiPaidNote,
            this.xrCommyType,
            this.xrPanel8,
            this.xrLabel8,
            this.xrPanel6,
            this.xrSubInTransit});
            this.GroupFooter1.HeightF = 91.04169F;
            this.GroupFooter1.Name = "GroupFooter1";
            this.GroupFooter1.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.GroupFooter1_BeforePrint);
            // 
            // xrPanel8
            // 
            this.xrPanel8.BorderColor = System.Drawing.Color.Black;
            this.xrPanel8.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPanel8.BorderWidth = 1.5F;
            this.xrPanel8.CanShrink = true;
            this.xrPanel8.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTDebitCard});
            this.xrPanel8.FormattingRules.Add(this.frGreenBorderColor);
            this.xrPanel8.LocationFloat = new DevExpress.Utils.PointFloat(9.999974F, 23.16698F);
            this.xrPanel8.Name = "xrPanel8";
            this.xrPanel8.SizeF = new System.Drawing.SizeF(328F, 36.00006F);
            this.xrPanel8.StylePriority.UseBorderColor = false;
            this.xrPanel8.StylePriority.UseBorders = false;
            this.xrPanel8.StylePriority.UseBorderWidth = false;
            this.xrPanel8.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.xrPanel8_PrintOnPage);
            // 
            // xrTDebitCard
            // 
            this.xrTDebitCard.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTDebitCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTDebitCard.LocationFloat = new DevExpress.Utils.PointFloat(1.85F, 1.999982F);
            this.xrTDebitCard.Name = "xrTDebitCard";
            this.xrTDebitCard.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow6,
            this.xrTableRow7});
            this.xrTDebitCard.SizeF = new System.Drawing.SizeF(324.55F, 31F);
            this.xrTDebitCard.StylePriority.UseBorders = false;
            this.xrTDebitCard.StylePriority.UseFont = false;
            this.xrTDebitCard.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrTDebitCard_BeforePrint);
            // 
            // xrTableRow6
            // 
            this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell7});
            this.xrTableRow6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.xrTableRow6.Name = "xrTableRow6";
            this.xrTableRow6.StylePriority.UseFont = false;
            this.xrTableRow6.Weight = 0.60000000000000009D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableCell7.BorderWidth = 1.5F;
            this.xrTableCell7.CanGrow = false;
            this.xrTableCell7.CanShrink = true;
            this.xrTableCell7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).DebitPaymentChart")});
            this.xrTableCell7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.xrTableCell7.FormattingRules.Add(this.frGreenBorderColor);
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.StylePriority.UseBorders = false;
            this.xrTableCell7.StylePriority.UseBorderWidth = false;
            this.xrTableCell7.StylePriority.UseFont = false;
            this.xrTableCell7.StylePriority.UseTextAlignment = false;
            this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell7.Weight = 2.42545051149018D;
            // 
            // xrTableRow7
            // 
            this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell9,
            this.xrTableCell10,
            this.xrTableCell14});
            this.xrTableRow7.Name = "xrTableRow7";
            this.xrTableRow7.Weight = 0.6399999999999999D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.CanGrow = false;
            this.xrTableCell9.CanShrink = true;
            this.xrTableCell9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic);
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F);
            this.xrTableCell9.StylePriority.UseFont = false;
            this.xrTableCell9.StylePriority.UsePadding = false;
            this.xrTableCell9.StylePriority.UseTextAlignment = false;
            this.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell9.Weight = 0.69783606313824054D;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.CanGrow = false;
            this.xrTableCell10.CanShrink = true;
            this.xrTableCell10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic);
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F);
            this.xrTableCell10.StylePriority.UseFont = false;
            this.xrTableCell10.StylePriority.UsePadding = false;
            this.xrTableCell10.StylePriority.UseTextAlignment = false;
            this.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell10.Weight = 0.49308561450931176D;
            // 
            // xrTableCell14
            // 
            this.xrTableCell14.CanShrink = true;
            this.xrTableCell14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic);
            this.xrTableCell14.Name = "xrTableCell14";
            this.xrTableCell14.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F);
            this.xrTableCell14.StylePriority.UseFont = false;
            this.xrTableCell14.StylePriority.UsePadding = false;
            this.xrTableCell14.StylePriority.UseTextAlignment = false;
            this.xrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell14.Weight = 0.77453586414512332D;
            // 
            // xrSubInTransit
            // 
            this.xrSubInTransit.LocationFloat = new DevExpress.Utils.PointFloat(9.550858F, 22.16699F);
            this.xrSubInTransit.Name = "xrSubInTransit";
            this.xrSubInTransit.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("StatementId", this.StatementId));
            this.xrSubInTransit.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LanguageId", this.LanguageId));
            this.xrSubInTransit.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("lblAmount", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Amount    "));
            this.xrSubInTransit.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("lblPayments", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Payments"));
            this.xrSubInTransit.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("lblInTransit", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).InTransit"));
            this.xrSubInTransit.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("BlackAndWhite", this.BlackAndWhite));
            this.xrSubInTransit.ReportSource = new WebAPIReports.Reports.Invoice.RptInvoiceInTransit();
            this.xrSubInTransit.SizeF = new System.Drawing.SizeF(369.1666F, 1F);
            // 
            // CalcNote
            // 
            this.CalcNote.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcNote.DataSource = this.WireSecurity;
            this.CalcNote.Expression = resources.GetString("CalcNote.Expression");
            this.CalcNote.Name = "CalcNote";
            // 
            // CalcAgFax
            // 
            this.CalcAgFax.DataMember = "Acc_Invoice_Header(@StatementId)";
            this.CalcAgFax.Expression = " Iif(not IsNullOrEmpty([AgFax1]),\n           Iif(Len(Trim([AgFax1])) <= 10, \n\t\t T" +
    "oLong(Trim([AgFax1])), \t\t\t\t\t  \t\t ToLong(Substring(Trim([AgFax1]),0  ,9 ))\n\t\t) ,\'" +
    "\')";
            this.CalcAgFax.Name = "CalcAgFax";
            // 
            // CalcAgPhoneLabel
            // 
            this.CalcAgPhoneLabel.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcAgPhoneLabel.DataSource = this.WireSecurity;
            this.CalcAgPhoneLabel.Expression = "[phoneInvoice] + \':\'";
            this.CalcAgPhoneLabel.Name = "CalcAgPhoneLabel";
            // 
            // CalcTrimBP
            // 
            this.CalcTrimBP.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcTrimBP.DataSource = this.WireSecurity;
            this.CalcTrimBP.Expression = "Trim([BillPayment])";
            this.CalcTrimBP.Name = "CalcTrimBP";
            // 
            // CalcSeqNo
            // 
            this.CalcSeqNo.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcSeqNo.DataSource = this.WireSecurity;
            this.CalcSeqNo.Expression = "Trim([SeqNo])";
            this.CalcSeqNo.Name = "CalcSeqNo";
            // 
            // CalcService
            // 
            this.CalcService.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcService.DataSource = this.WireSecurity;
            this.CalcService.Expression = "Trim([ServiceType])";
            this.CalcService.Name = "CalcService";
            // 
            // CalcStCurrency
            // 
            this.CalcStCurrency.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcStCurrency.DataSource = this.WireSecurity;
            this.CalcStCurrency.Expression = "[Currency]";
            this.CalcStCurrency.Name = "CalcStCurrency";
            // 
            // CalcDebitCard
            // 
            this.CalcDebitCard.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcDebitCard.DataSource = this.WireSecurity;
            this.CalcDebitCard.Expression = "Trim([DebitCard])";
            this.CalcDebitCard.Name = "CalcDebitCard";
            // 
            // CalcTransact
            // 
            this.CalcTransact.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcTransact.DataSource = this.WireSecurity;
            this.CalcTransact.Expression = "Trim([Transaction])";
            this.CalcTransact.Name = "CalcTransact";
            // 
            // RptInvoice
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader,
            this.ReportFooter,
            this.PageFooter,
            this.GroupFooter1});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.CalcHeaderInfo,
            this.CalcInfoHeader,
            this.CalcLegalEntiyInfo,
            this.CalcAgInfoOwner,
            this.CalcAgInfo,
            this.CalcTotalPaymentAmount,
            this.CalcPaymentLabel,
            this.calculatedField1,
            this.CalcOtherLabel,
            this.CalcCancellationLabel,
            this.CalcWireSentLabel,
            this.CalcAgPhone,
            this.CalcCommiPaymentMethod,
            this.CalcTrimPayment,
            this.CalcTrimOther,
            this.CalcTrimCancellations,
            this.CalcNote,
            this.CalcAgFax,
            this.CalcAgPhoneLabel,
            this.CalcTrimBP,
            this.CalcSeqNo,
            this.CalcService,
            this.CalcStCurrency,
            this.CalcDebitCard,
            this.CalcTransact});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.WireTransac,
            this.WireSecurity});
            this.DataMember = "Acc_Invoice_Header(@StatementId)";
            this.DataSource = this.WireTransac;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormattingRuleSheet.AddRange(new DevExpress.XtraReports.UI.FormattingRule[] {
            this.frGreenBorderColor,
            this.frGreenBackColor,
            this.frGreenForeColor,
            this.frColorLogoVisible,
            this.frBWLogoVisible,
            this.frShowCommissionBox,
            this.frFaxMessage,
            this.frShowCommiPaymentMethod});
            this.Margins = new System.Drawing.Printing.Margins(54, 31, 0, 0);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.StatementId,
            this.LanguageId,
            this.FormName,
            this.BlackAndWhite});
            this.ScriptsSource = resources.GetString("$this.ScriptsSource");
            this.ShowPrintMarginsWarning = false;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailData3_Odd,
            this.PageInfo});
            this.Version = "18.1";
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.RptInvoice_DataSourceDemanded);
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.RptInvoice_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this.xrTSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTCommission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTDebitCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.DataAccess.Sql.SqlDataSource WireTransac;
        private DevExpress.XtraReports.UI.XRLine xrLine2;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.Parameters.Parameter StatementId;
        private DevExpress.XtraReports.UI.CalculatedField CalcHeaderInfo;
        private DevExpress.XtraReports.Parameters.Parameter LanguageId;
        private DevExpress.XtraReports.Parameters.Parameter FormName;
        private DevExpress.DataAccess.Sql.SqlDataSource WireSecurity;
        private DevExpress.XtraReports.UI.CalculatedField CalcInfoHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.CalculatedField CalcLegalEntiyInfo;
        private DevExpress.XtraReports.UI.CalculatedField CalcAgInfoOwner;
        private DevExpress.XtraReports.UI.CalculatedField CalcAgInfo;
        private DevExpress.XtraReports.UI.CalculatedField CalcTotalPaymentAmount;
        private DevExpress.XtraReports.UI.CalculatedField CalcPaymentLabel;
        private DevExpress.XtraReports.UI.CalculatedField calculatedField1;
        private DevExpress.XtraReports.UI.SubBand SubBand1;
        private DevExpress.XtraReports.UI.XRPanel xrPanel1;
        private DevExpress.XtraReports.UI.XRPanel xrPanel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.XRLabel xrLabel13;
        private DevExpress.XtraReports.UI.XRLabel xrLabel15;
        private DevExpress.XtraReports.UI.XRLabel xrLabel14;
        private DevExpress.XtraReports.UI.XRLabel xrLabel16;
        private DevExpress.XtraReports.UI.SubBand Payments;
        private DevExpress.XtraReports.UI.SubBand OtherCreditsDebits;
        private DevExpress.XtraReports.UI.XRSubreport xrSubPayment;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell xrLblPayment;
        private DevExpress.XtraReports.UI.XRTableCell xrQtyPayments;
        private DevExpress.XtraReports.UI.XRTableCell xrPaymentAmount;
        private DevExpress.XtraReports.UI.XRTableRow xrTROther;
        private DevExpress.XtraReports.UI.XRTableCell xrLblOther;
        private DevExpress.XtraReports.UI.XRTableCell xrQtyOtherCredits;
        private DevExpress.XtraReports.UI.XRTableCell xrOtherAmount;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow8;
        private DevExpress.XtraReports.UI.XRTableCell xrLblCancellation;
        private DevExpress.XtraReports.UI.XRTableCell xrQtyCancellations;
        private DevExpress.XtraReports.UI.XRTableCell xrCancellationAmount;
        private DevExpress.XtraReports.UI.SubBand Cancellations;
        private DevExpress.XtraReports.UI.SubBand Wires;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.CalculatedField CalcOtherLabel;
        private DevExpress.XtraReports.UI.CalculatedField CalcCancellationLabel;
        private DevExpress.XtraReports.UI.CalculatedField CalcWireSentLabel;
        private DevExpress.XtraReports.UI.XRSubreport xrSubWires;
        private DevExpress.XtraReports.UI.XRPanel xrPanel4;
        private DevExpress.XtraReports.UI.XRLabel xrWiresLabel;
        private DevExpress.XtraReports.UI.XRSubreport xrSubCancellations;
        private DevExpress.XtraReports.UI.FormattingRule frGreenForeColor;
        private DevExpress.XtraReports.UI.FormattingRule frGreenBorderColor;
        private DevExpress.XtraReports.Parameters.Parameter BlackAndWhite;
        private DevExpress.XtraReports.UI.FormattingRule frGreenBackColor;
        private DevExpress.XtraReports.UI.XRSubreport xrSubOther;
        private DevExpress.XtraReports.UI.FormattingRule frColorLogoVisible;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox2;
        private DevExpress.XtraReports.UI.FormattingRule frBWLogoVisible;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.CalculatedField CalcAgPhone;
        private DevExpress.XtraReports.UI.XRPanel xrPanel3;
        private DevExpress.XtraReports.UI.XRLine xrLine4;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRPanel xrPanel5;
        private DevExpress.XtraReports.UI.XRTable xrTCommission;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell11;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell13;
        private DevExpress.XtraReports.UI.FormattingRule frShowCommissionBox;
        private DevExpress.XtraReports.UI.XRSubreport xrSubInTransit;
        private DevExpress.XtraReports.UI.XRLabel xrCommyType;
        private DevExpress.XtraReports.UI.XRLabel xrCommiPaidNote;
        private DevExpress.XtraReports.UI.CalculatedField CalcCommiPaymentMethod;
        private DevExpress.XtraReports.UI.XRPanel xrPanel6;
        private DevExpress.XtraReports.UI.XRTable xrTSummary;
        private DevExpress.XtraReports.UI.CalculatedField CalcTrimPayment;
        private DevExpress.XtraReports.UI.CalculatedField CalcTrimOther;
        private DevExpress.XtraReports.UI.CalculatedField CalcTrimCancellations;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.FormattingRule frFaxMessage;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRLine xrLine5;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.XRLine xrLine3;
        private DevExpress.XtraReports.UI.FormattingRule frShowCommiPaymentMethod;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel17;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRLabel xrLabel18;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel20;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo2;
        private DevExpress.XtraReports.UI.CalculatedField CalcNote;
        private DevExpress.XtraReports.UI.XRLabel xrLabel22;
        private DevExpress.XtraReports.UI.XRLabel xrLabel21;
        private DevExpress.XtraReports.UI.CalculatedField CalcAgFax;
        private DevExpress.XtraReports.UI.XRLabel xrLabel23;
        private DevExpress.XtraReports.UI.CalculatedField CalcAgPhoneLabel;
        private DevExpress.XtraReports.UI.XRLabel xrIHLineEnd;
        private DevExpress.XtraReports.UI.XRLabel xrIHLineEndValue;
        private DevExpress.XtraReports.UI.XRLabel xrIHPhoneValue;
        private DevExpress.XtraReports.UI.XRLabel xrIHEmailValue;
        private DevExpress.XtraReports.UI.XRLabel xrIHFaxValue;
        private DevExpress.XtraReports.UI.XRLabel xrIHPhone;
        private DevExpress.XtraReports.UI.XRLabel xrIHEmail;
        private DevExpress.XtraReports.UI.XRLabel xrIHFax;
        private DevExpress.XtraReports.UI.XRLabel xrIHLine1;
        private DevExpress.XtraReports.UI.XRLabel xrRightInfoHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel24;
        private DevExpress.XtraReports.UI.XRLabel xrLabel19;
        private DevExpress.XtraReports.UI.XRPanel xrPanel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel25;
        private DevExpress.XtraReports.UI.XRLabel xrLabel26;
        private DevExpress.XtraReports.UI.XRLabel xrLabel28;
        private DevExpress.XtraReports.UI.XRLabel xrLabel27;
        private DevExpress.XtraReports.UI.XRPanel xrPanel8;
        private DevExpress.XtraReports.UI.XRTable xrTDebitCard;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell9;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell10;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell14;
        private DevExpress.XtraReports.UI.XRLabel xrTransDate;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow9;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell12;
        private DevExpress.XtraReports.UI.XRTableCell xrQtyBP;
        private DevExpress.XtraReports.UI.XRTableCell xrAmountBP;
        private DevExpress.XtraReports.UI.CalculatedField CalcTrimBP;
        private DevExpress.XtraReports.UI.SubBand BillPayment;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport1;
        private DevExpress.XtraReports.UI.CalculatedField CalcSeqNo;
        private DevExpress.XtraReports.UI.CalculatedField CalcService;
        private DevExpress.XtraReports.UI.XRLabel xrLabel29;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.CalculatedField CalcStCurrency;
        private DevExpress.XtraReports.UI.SubBand DebitCard;
        private DevExpress.XtraReports.UI.XRSubreport xrSubDebitCard;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow10;
        private DevExpress.XtraReports.UI.XRTableCell xrLblDebitCard;
        private DevExpress.XtraReports.UI.XRTableCell xrQtyDebitCard;
        private DevExpress.XtraReports.UI.XRTableCell xrDebitCardAmount;
        private DevExpress.XtraReports.UI.CalculatedField CalcDebitCard;
        private DevExpress.XtraReports.UI.CalculatedField CalcTransact;
        private DevExpress.XtraReports.UI.XRLabel xrLabel30;
    }
}
