namespace WebAPIReports.Reports.Invoice
{
    partial class RptCompanyInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptCompanyInvoice));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.SubBand1 = new DevExpress.XtraReports.UI.SubBand();
            this.xrAgPayerDomestic = new DevExpress.XtraReports.UI.XRLabelExtension();
            this.xrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.WireSecurity = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanelExtension();
            this.xrPanel2 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPanel4 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrTSummary = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow10 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrLblDebitCard = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrQtyDebitCard = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrDebitCardAmount = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrWiresLabel = new DevExpress.XtraReports.UI.XRLabel();
            this.Payments = new DevExpress.XtraReports.UI.SubBand();
            this.xrSubPayment = new DevExpress.XtraReports.UI.XRSubreport();
            this.StatementId = new DevExpress.XtraReports.Parameters.Parameter();
            this.OtherCreditsDebits = new DevExpress.XtraReports.UI.SubBand();
            this.xrSubOther = new DevExpress.XtraReports.UI.XRSubreport();
            this.Cancellations = new DevExpress.XtraReports.UI.SubBand();
            this.xrSubCancellations = new DevExpress.XtraReports.UI.XRSubreport();
            this.Wires = new DevExpress.XtraReports.UI.SubBand();
            this.xrSubWires = new DevExpress.XtraReports.UI.XRSubreport();
            this.frWiresVisible = new DevExpress.XtraReports.UI.FormattingRule();
            this.LanguageId = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrSubWiresInbound = new DevExpress.XtraReports.UI.XRSubreport();
            this.frWiresInboundVisible = new DevExpress.XtraReports.UI.FormattingRule();
            this.DebitCard = new DevExpress.XtraReports.UI.SubBand();
            this.xrSubDebitCard = new DevExpress.XtraReports.UI.XRSubreport();
            this.BillPayment = new DevExpress.XtraReports.UI.SubBand();
            this.xrSubBillPayment = new DevExpress.XtraReports.UI.XRSubreport();
            this.TopUps = new DevExpress.XtraReports.UI.SubBand();
            this.xrSRTopUps = new DevExpress.XtraReports.UI.XRSubreport();
            this.WiresPaid = new DevExpress.XtraReports.UI.SubBand();
            this.xrSRWiresPaid = new DevExpress.XtraReports.UI.XRSubreport();
            this.IsInvoiceForCaribe = new DevExpress.XtraReports.Parameters.Parameter();
            this.SubBandSummary = new DevExpress.XtraReports.UI.SubBand();
            this.xrPanel7 = new DevExpress.XtraReports.UI.XRPanelExtension();
            this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTransDate = new DevExpress.XtraReports.UI.XRLabel();
            this.WireTransac = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
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
            this.AgencyCode = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLine4 = new DevExpress.XtraReports.UI.XRLineExtension();
            this.xrCompanyHeader = new DevExpress.XtraReports.UI.XRSubreport();
            this.CalcOtherLabel = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcCancellationLabel = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcWireSentLabel = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcAgPhone = new DevExpress.XtraReports.UI.CalculatedField();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLine3 = new DevExpress.XtraReports.UI.XRLineExtension();
            this.xrPagerInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.frFaxMessage = new DevExpress.XtraReports.UI.FormattingRule();
            this.frShowCommiPaymentMethod = new DevExpress.XtraReports.UI.FormattingRule();
            this.frShowCommissionBox = new DevExpress.XtraReports.UI.FormattingRule();
            this.CalcCommiPaymentMethod = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcTrimPayment = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcTrimOther = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcTrimCancellations = new DevExpress.XtraReports.UI.CalculatedField();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrLine5 = new DevExpress.XtraReports.UI.XRLineExtension();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.CalcNote = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcAgFax = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcAgPhoneLabel = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcTrimBP = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcSeqNo = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcService = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcStCurrency = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcDebitCard = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcTransact = new DevExpress.XtraReports.UI.CalculatedField();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPanel6 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrPanel5 = new DevExpress.XtraReports.UI.XRPanelExtension();
            this.xrTCommission = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCellExtension();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrCommyType = new DevExpress.XtraReports.UI.XRLabel();
            this.xrCommiPaidNote = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrPanel8 = new DevExpress.XtraReports.UI.XRPanelExtension();
            this.xrTDebitCard = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCellExtension();
            this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabelExtension();
            this.xrSubInTransit = new DevExpress.XtraReports.UI.XRSubreport();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.CalcTopUpLabel = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcTopUpNote = new DevExpress.XtraReports.UI.CalculatedField();
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
            this.BillPayment,
            this.TopUps,
            this.WiresPaid,
            this.SubBandSummary});
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // SubBand1
            // 
            this.SubBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrAgPayerDomestic,
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
            this.SubBand1.HeightF = 122.775F;
            this.SubBand1.Name = "SubBand1";
            // 
            // xrAgPayerDomestic
            // 
            this.xrAgPayerDomestic.BorderColor = System.Drawing.Color.Black;
            this.xrAgPayerDomestic.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Agency_Header(@StatementId).AgDomesticPayer")});
            this.xrAgPayerDomestic.HexaForeColor = null;
            this.xrAgPayerDomestic.LocationFloat = new DevExpress.Utils.PointFloat(127.0814F, 109.4168F);
            this.xrAgPayerDomestic.Multiline = true;
            this.xrAgPayerDomestic.Name = "xrAgPayerDomestic";
            this.xrAgPayerDomestic.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrAgPayerDomestic.SizeF = new System.Drawing.SizeF(40.63467F, 7.60791F);
            this.xrAgPayerDomestic.Visible = false;
            // 
            // xrLabel30
            // 
            this.xrLabel30.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Agency_Header(@StatementId).StateLicense")});
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
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Agency_Header(@StatementId).BeginingBalance", "{0:$#,##0.00}")});
            this.xrLabel24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(637.9167F, 112.9F);
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
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(411.8203F, 112.9F);
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
            this.WireSecurity.ConnectionName = "WireSecurityConn";
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
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Agency_Header(@StatementId).CalcAgFax", "{0:(###) ### - ####}")});
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
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Agency_Header(@StatementId).AgEmail")});
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
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Agency_Header(@StatementId).CalcAgPhone", "{0:(###) ### - ####}")});
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
            this.xrPanel1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPanel1.BorderWidth = 2F;
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel2,
            this.xrPanel4});
            this.xrPanel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("BorderColor", null, "Acc_Invoice_Agency_Header(@StatementId).ReportColorForeground")});
            this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(349.3755F, 10.00002F);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.SizeF = new System.Drawing.SizeF(405.6244F, 93.85F);
            this.xrPanel1.StylePriority.UseBorderColor = false;
            this.xrPanel1.StylePriority.UseBorders = false;
            this.xrPanel1.StylePriority.UseBorderWidth = false;
            // 
            // xrPanel2
            // 
            this.xrPanel2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel11,
            this.xrLabel9});
            this.xrPanel2.LocationFloat = new DevExpress.Utils.PointFloat(9.999889F, 47.74998F);
            this.xrPanel2.Name = "xrPanel2";
            this.xrPanel2.SizeF = new System.Drawing.SizeF(385.6245F, 33F);
            // 
            // xrLabel11
            // 
            this.xrLabel11.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Agency_Header(@StatementId).EndingBalance", "{0:$#,##0.00}")});
            this.xrLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(253.0749F, 5.3F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(127.0833F, 19.87502F);
            this.xrLabel11.StylePriority.UseBorders = false;
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel11.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel11_BeforePrint);
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
            this.xrPanel4.LocationFloat = new DevExpress.Utils.PointFloat(10.00024F, 9.999999F);
            this.xrPanel4.Name = "xrPanel4";
            this.xrPanel4.SizeF = new System.Drawing.SizeF(385.6246F, 34.45F);
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
            this.xrTableRow10});
            this.xrTSummary.SizeF = new System.Drawing.SizeF(385.6244F, 34.10159F);
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
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Agency_Header(@StatementId).BeginingBalance", "{0:$#,##0.00}")});
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
            // xrTableRow10
            // 
            this.xrTableRow10.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrLblDebitCard,
            this.xrQtyDebitCard,
            this.xrDebitCardAmount});
            this.xrTableRow10.Name = "xrTableRow10";
            this.xrTableRow10.Weight = 0.6000000000000002D;
            // 
            // xrLblDebitCard
            // 
            this.xrLblDebitCard.CanShrink = true;
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
            this.xrQtyDebitCard.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrQtyDebitCard.Weight = 0.37628078855883629D;
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
            this.xrDebitCardAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrDebitCardAmount.Weight = 0.97655192858763851D;
            // 
            // xrLabel3
            // 
            this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Agency_Header(@StatementId).CalcAgInfoOwner")});
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
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Agency_Header(@StatementId).CalcAgInfo")});
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
            this.xrWiresLabel.LocationFloat = new DevExpress.Utils.PointFloat(9.999979F, 109.4168F);
            this.xrWiresLabel.Name = "xrWiresLabel";
            this.xrWiresLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrWiresLabel.SizeF = new System.Drawing.SizeF(100F, 7.607918F);
            this.xrWiresLabel.Visible = false;
            // 
            // Payments
            // 
            this.Payments.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubPayment});
            this.Payments.HeightF = 3.241207F;
            this.Payments.Name = "Payments";
            // 
            // xrSubPayment
            // 
            this.xrSubPayment.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrSubPayment.Name = "xrSubPayment";
            this.xrSubPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("StatementId", this.StatementId));
            this.xrSubPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Date", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Date"));
            this.xrSubPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("lblPayments", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CalcPaymentLabel"));
            this.xrSubPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Description", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Description"));
            this.xrSubPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Deposit", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Deposits"));
            this.xrSubPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("lblBalance", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Balance"));
            this.xrSubPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Color", null, "Acc_Invoice_Agency_Header(@StatementId).ReportColorForeground"));
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
            // OtherCreditsDebits
            // 
            this.OtherCreditsDebits.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubOther});
            this.OtherCreditsDebits.HeightF = 3.729184F;
            this.OtherCreditsDebits.Name = "OtherCreditsDebits";
            // 
            // xrSubOther
            // 
            this.xrSubOther.LocationFloat = new DevExpress.Utils.PointFloat(0.0001271566F, 0F);
            this.xrSubOther.Name = "xrSubOther";
            this.xrSubOther.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("StatementId", this.StatementId));
            this.xrSubOther.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("OtherLabel", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CalcOtherLabel"));
            this.xrSubOther.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Description", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Description"));
            this.xrSubOther.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Amount", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).ActivityBalance"));
            this.xrSubOther.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("lblBalance", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Balance"));
            this.xrSubOther.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Date", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Date"));
            this.xrSubOther.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Color", null, "Acc_Invoice_Agency_Header(@StatementId).ReportColorForeground"));
            this.xrSubOther.ReportSource = new WebAPIReports.Reports.Invoice.RptInvoiceOther();
            this.xrSubOther.SizeF = new System.Drawing.SizeF(764.9999F, 3.208319F);
            // 
            // Cancellations
            // 
            this.Cancellations.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubCancellations});
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
            this.xrSubCancellations.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Color", null, "Acc_Invoice_Agency_Header(@StatementId).ReportColorForeground"));
            this.xrSubCancellations.ReportSource = new WebAPIReports.Reports.Invoice.RptInvoiceCancellations();
            this.xrSubCancellations.SizeF = new System.Drawing.SizeF(764.9999F, 4.249986F);
            // 
            // Wires
            // 
            this.Wires.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubWires,
            this.xrSubWiresInbound});
            this.Wires.HeightF = 5.008803F;
            this.Wires.Name = "Wires";
            // 
            // xrSubWires
            // 
            this.xrSubWires.FormattingRules.Add(this.frWiresVisible);
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
            this.xrSubWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Note", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CalcNote"));
            this.xrSubWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Color", null, "Acc_Invoice_Agency_Header(@StatementId).ReportColorForeground"));
            this.xrSubWires.ReportSource = new WebAPIReports.Reports.Invoice.RptInvoiceWires();
            this.xrSubWires.SizeF = new System.Drawing.SizeF(765F, 5.008793F);
            // 
            // frWiresVisible
            // 
            this.frWiresVisible.Condition = "[Parameters].[IsInvoiceForCaribe] == True";
            this.frWiresVisible.DataMember = "Acc_Invoice_Agency_Header(@StatementId)";
            this.frWiresVisible.Formatting.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.frWiresVisible.Name = "frWiresVisible";
            // 
            // LanguageId
            // 
            this.LanguageId.Name = "LanguageId";
            this.LanguageId.Type = typeof(int);
            this.LanguageId.ValueInfo = "2";
            this.LanguageId.Visible = false;
            // 
            // xrSubWiresInbound
            // 
            this.xrSubWiresInbound.FormattingRules.Add(this.frWiresInboundVisible);
            this.xrSubWiresInbound.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0.06434059F);
            this.xrSubWiresInbound.Name = "xrSubWiresInbound";
            this.xrSubWiresInbound.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("StatementId", this.StatementId));
            this.xrSubWiresInbound.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("WireLabel", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CalcWireSentLabel"));
            this.xrSubWiresInbound.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Date", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Date"));
            this.xrSubWiresInbound.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Control", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Control"));
            this.xrSubWiresInbound.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("WireNo", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).WireNo"));
            this.xrSubWiresInbound.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Sender", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Sender"));
            this.xrSubWiresInbound.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Country", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Country"));
            this.xrSubWiresInbound.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Transfer", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Transfer"));
            this.xrSubWiresInbound.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Fee", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Fee"));
            this.xrSubWiresInbound.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("StateFee", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).StateFee"));
            this.xrSubWiresInbound.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgComm", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CommAg"));
            this.xrSubWiresInbound.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Other", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Other"));
            this.xrSubWiresInbound.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Void", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Void"));
            this.xrSubWiresInbound.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Amount", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).ActivityBalance"));
            this.xrSubWiresInbound.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Balance", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Balance"));
            this.xrSubWiresInbound.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LanguageId", this.LanguageId));
            this.xrSubWiresInbound.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Note", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CalcNote"));
            this.xrSubWiresInbound.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Color", null, "Acc_Invoice_Agency_Header(@StatementId).ReportColorForeground"));
            this.xrSubWiresInbound.ReportSource = new WebAPIReports.Reports.Invoice.RptInvoiceWiresInbound();
            this.xrSubWiresInbound.SizeF = new System.Drawing.SizeF(765F, 4.944462F);
            this.xrSubWiresInbound.Visible = false;
            // 
            // frWiresInboundVisible
            // 
            this.frWiresInboundVisible.Condition = "[Parameters].[IsInvoiceForCaribe] == True";
            this.frWiresInboundVisible.DataMember = "Acc_Invoice_Agency_Header(@StatementId)";
            this.frWiresInboundVisible.Formatting.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.frWiresInboundVisible.Name = "frWiresInboundVisible";
            // 
            // DebitCard
            // 
            this.DebitCard.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubDebitCard});
            this.DebitCard.HeightF = 5.043859F;
            this.DebitCard.Name = "DebitCard";
            // 
            // xrSubDebitCard
            // 
            this.xrSubDebitCard.LocationFloat = new DevExpress.Utils.PointFloat(0.0001271566F, 0F);
            this.xrSubDebitCard.Name = "xrSubDebitCard";
            this.xrSubDebitCard.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("StatementId", this.StatementId));
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
            this.xrSubDebitCard.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Color", null, "Acc_Invoice_Agency_Header(@StatementId).ReportColorForeground"));
            this.xrSubDebitCard.ReportSource = new WebAPIReports.Reports.Invoice.RptInvoiceDebitCard();
            this.xrSubDebitCard.SizeF = new System.Drawing.SizeF(764.9999F, 4.944439F);
            // 
            // BillPayment
            // 
            this.BillPayment.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubBillPayment});
            this.BillPayment.HeightF = 4.944441F;
            this.BillPayment.Name = "BillPayment";
            // 
            // xrSubBillPayment
            // 
            this.xrSubBillPayment.LocationFloat = new DevExpress.Utils.PointFloat(0.0001271566F, 0F);
            this.xrSubBillPayment.Name = "xrSubBillPayment";
            this.xrSubBillPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("StatementId", this.StatementId));
            this.xrSubBillPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Date", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Date"));
            this.xrSubBillPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Control", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Control"));
            this.xrSubBillPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Sender", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Sender"));
            this.xrSubBillPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Service", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CalcService"));
            this.xrSubBillPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AmountBP", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Amount    "));
            this.xrSubBillPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Fee", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Fee"));
            this.xrSubBillPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgComm", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CommAg"));
            this.xrSubBillPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Amount", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).ActivityBalance"));
            this.xrSubBillPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Balance", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Balance"));
            this.xrSubBillPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Sequence", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CalcSeqNo"));
            this.xrSubBillPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("BillPayment", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CalcTrimBP"));
            this.xrSubBillPayment.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Color", null, "Acc_Invoice_Agency_Header(@StatementId).ReportColorForeground"));
            this.xrSubBillPayment.ReportSource = new WebAPIReports.Reports.Invoice.RptInvoiceBillPayment();
            this.xrSubBillPayment.SizeF = new System.Drawing.SizeF(764.9999F, 4.944441F);
            // 
            // TopUps
            // 
            this.TopUps.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSRTopUps});
            this.TopUps.HeightF = 4.249986F;
            this.TopUps.Name = "TopUps";
            // 
            // xrSRTopUps
            // 
            this.xrSRTopUps.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrSRTopUps.Name = "xrSRTopUps";
            this.xrSRTopUps.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("StatementId", this.StatementId));
            this.xrSRTopUps.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("BlackAndWhite", null, null));
            this.xrSRTopUps.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Date", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Date"));
            this.xrSRTopUps.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Control", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Control"));
            this.xrSRTopUps.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Sender", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Sender"));
            this.xrSRTopUps.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Service", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CalcService"));
            this.xrSRTopUps.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AmountBP", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Amount    "));
            this.xrSRTopUps.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Fee", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Fee"));
            this.xrSRTopUps.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgComm", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CommAg"));
            this.xrSRTopUps.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Amount", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).ActivityBalance"));
            this.xrSRTopUps.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Balance", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Balance"));
            this.xrSRTopUps.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Sequence", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CalcSeqNo"));
            this.xrSRTopUps.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("TopUpTittle", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CalcTopUpLabel"));
            this.xrSRTopUps.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Color", null, "Acc_Invoice_Agency_Header(@StatementId).ReportColorForeground"));
            this.xrSRTopUps.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Leyend", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CalcTopUpNote"));
            this.xrSRTopUps.ReportSource = new WebAPIReports.Reports.Invoice.RptTopUp();
            this.xrSRTopUps.SizeF = new System.Drawing.SizeF(765.0001F, 4.249986F);
            // 
            // WiresPaid
            // 
            this.WiresPaid.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSRWiresPaid});
            this.WiresPaid.Expanded = false;
            this.WiresPaid.HeightF = 4.718144F;
            this.WiresPaid.Name = "WiresPaid";
            // 
            // xrSRWiresPaid
            // 
            this.xrSRWiresPaid.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrSRWiresPaid.Name = "xrSRWiresPaid";
            this.xrSRWiresPaid.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("StatementId", this.StatementId));
            this.xrSRWiresPaid.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("BlackAndWhite", null, null));
            this.xrSRWiresPaid.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Date", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Date"));
            this.xrSRWiresPaid.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Control", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Control"));
            this.xrSRWiresPaid.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Wire", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).WireNo"));
            this.xrSRWiresPaid.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgComm", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CommAg"));
            this.xrSRWiresPaid.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Amount", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Transfer"));
            this.xrSRWiresPaid.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Balance", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Balance"));
            this.xrSRWiresPaid.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Color", null, "Acc_Invoice_Agency_Header(@StatementId).ReportColorForeground"));
            this.xrSRWiresPaid.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Beneficiary", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Beneficiary"));
            this.xrSRWiresPaid.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Country", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Country"));
            this.xrSRWiresPaid.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("IMXCharges", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Fee"));
            this.xrSRWiresPaid.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("ActBalance", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).ActivityBalance"));
            this.xrSRWiresPaid.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("WirePaidTittle", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).WiresTransfersPaid"));
            this.xrSRWiresPaid.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LanguageId", this.LanguageId));
            this.xrSRWiresPaid.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("IsInvoiceForCaribe", this.IsInvoiceForCaribe));
            this.xrSRWiresPaid.ReportSource = new WebAPIReports.Reports.Invoice.RptWiresPaid();
            this.xrSRWiresPaid.SizeF = new System.Drawing.SizeF(765.0001F, 4.249986F);
            // 
            // IsInvoiceForCaribe
            // 
            this.IsInvoiceForCaribe.Description = "IsInvoiceForCaribe";
            this.IsInvoiceForCaribe.Name = "IsInvoiceForCaribe";
            this.IsInvoiceForCaribe.Type = typeof(bool);
            this.IsInvoiceForCaribe.ValueInfo = "False";
            this.IsInvoiceForCaribe.Visible = false;
            // 
            // SubBandSummary
            // 
            this.SubBandSummary.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel7});
            this.SubBandSummary.HeightF = 30.4F;
            this.SubBandSummary.Name = "SubBandSummary";
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
            this.xrPanel7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("BorderColor", null, "Acc_Invoice_Agency_Header(@StatementId).ReportColorForeground")});
            this.xrPanel7.LocationFloat = new DevExpress.Utils.PointFloat(504.7906F, 1.4F);
            this.xrPanel7.Name = "xrPanel7";
            this.xrPanel7.SizeF = new System.Drawing.SizeF(256.9784F, 29F);
            this.xrPanel7.StylePriority.UseBorders = false;
            this.xrPanel7.StylePriority.UseBorderWidth = false;
            // 
            // xrLabel25
            // 
            this.xrLabel25.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel25.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Agency_Header(@StatementId).EndingBalance", "{0:$#,##0.00}")});
            this.xrLabel25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(141.9263F, 4.77F);
            this.xrLabel25.Name = "xrLabel25";
            this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 1, 0, 100F);
            this.xrLabel25.SizeF = new System.Drawing.SizeF(110.8177F, 19.87502F);
            this.xrLabel25.StylePriority.UseBorders = false;
            this.xrLabel25.StylePriority.UseFont = false;
            this.xrLabel25.StylePriority.UsePadding = false;
            this.xrLabel25.StylePriority.UseTextAlignment = false;
            this.xrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel25.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel25_BeforePrint);
            // 
            // xrLabel26
            // 
            this.xrLabel26.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel26.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).TotalPaymentDue")});
            this.xrLabel26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(5F, 4.77F);
            this.xrLabel26.Name = "xrLabel26";
            this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 1, 0, 100F);
            this.xrLabel26.SizeF = new System.Drawing.SizeF(135.9263F, 19.87502F);
            this.xrLabel26.StylePriority.UseBorders = false;
            this.xrLabel26.StylePriority.UseFont = false;
            this.xrLabel26.StylePriority.UsePadding = false;
            this.xrLabel26.StylePriority.UseTextAlignment = false;
            this.xrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrTransDate
            // 
            this.xrTransDate.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTransDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.xrTransDate.LocationFloat = new DevExpress.Utils.PointFloat(642.429F, 23.75002F);
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
            this.WireTransac.ConnectionName = "WireTransacConn";
            this.WireTransac.Name = "WireTransac";
            storedProcQuery2.Name = "Acc_Invoice_Agency_Header(@StatementId)";
            queryParameter3.Name = "@StatementId";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("[Parameters.StatementId]", typeof(int));
            storedProcQuery2.Parameters.Add(queryParameter3);
            storedProcQuery2.StoredProcName = "Acc_Invoice_Agency_Header";
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
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(0.0002543131F, 23.75002F);
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
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Agency_Header(@StatementId).StatementId")});
            this.xrLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(94.51853F, 23.75002F);
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
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Agency_Header(@StatementId).AgStatementSeq")});
            this.xrLabel15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(532.2292F, 23.75002F);
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
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(442.813F, 23.75002F);
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
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(593.6876F, 23.75002F);
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
            this.CalcHeaderInfo.DataMember = "Acc_Invoice_Agency_Header(@StatementId)";
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
            this.CalcLegalEntiyInfo.DataMember = "Acc_Invoice_Agency_Header(@StatementId)";
            this.CalcLegalEntiyInfo.Expression = "[LegalEntityOfficialName]\n+Char(13)\n+ [CoBrandAddress]\n+ Char(13)\n+ [CoBrandCity]" +
    " + \', \' + [CoBrandState] + \' \' + [CoBrandZip]";
            this.CalcLegalEntiyInfo.Name = "CalcLegalEntiyInfo";
            // 
            // CalcAgInfoOwner
            // 
            this.CalcAgInfoOwner.DataMember = "Acc_Invoice_Agency_Header(@StatementId)";
            this.CalcAgInfoOwner.Expression = "Trim([AgencyCode]) + \' / \' + [Agname]\n+ Char(13)\n+ \'Mr(s.) \' + Trim([AgOwnerFirst" +
    "Name]) + \' \' + Trim([AgOwnerLastName])";
            this.CalcAgInfoOwner.Name = "CalcAgInfoOwner";
            // 
            // CalcAgInfo
            // 
            this.CalcAgInfo.DataMember = "Acc_Invoice_Agency_Header(@StatementId)";
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
            this.PageHeader.HeightF = 1.624997F;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.PageHeader_BeforePrint);
            // 
            // xrLabel29
            // 
            this.xrLabel29.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel29.CanGrow = false;
            this.xrLabel29.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Agency_Header(@StatementId).StatementCurrency")});
            this.xrLabel29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(249.138F, 23.74999F);
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
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(168.4768F, 23.75002F);
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
            this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(290.0381F, 23.75002F);
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
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Agency_Header(@StatementId).AgencyCode")});
            this.xrLabel27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(352.6436F, 23.75002F);
            this.xrLabel27.Name = "xrLabel27";
            this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(1, 0, 0, 0, 100F);
            this.xrLabel27.SizeF = new System.Drawing.SizeF(90.16943F, 16.74998F);
            this.xrLabel27.StylePriority.UseBorders = false;
            this.xrLabel27.StylePriority.UseFont = false;
            this.xrLabel27.StylePriority.UsePadding = false;
            // 
            // AgencyCode
            // 
            this.AgencyCode.Description = "AgencyCode";
            this.AgencyCode.Name = "AgencyCode";
            this.AgencyCode.Type = typeof(int);
            this.AgencyCode.ValueInfo = "0";
            this.AgencyCode.Visible = false;
            // 
            // xrLine4
            // 
            this.xrLine4.BorderColor = System.Drawing.Color.Black;
            this.xrLine4.Color = null;
            this.xrLine4.ForeColor = System.Drawing.Color.Black;
            this.xrLine4.LineWidth = 2;
            this.xrLine4.LocationFloat = new DevExpress.Utils.PointFloat(0.0001271566F, 40.49997F);
            this.xrLine4.Name = "xrLine4";
            this.xrLine4.SizeF = new System.Drawing.SizeF(765F, 10.5F);
            this.xrLine4.StylePriority.UseBorderColor = false;
            this.xrLine4.StylePriority.UseForeColor = false;
            // 
            // xrCompanyHeader
            // 
            this.xrCompanyHeader.LocationFloat = new DevExpress.Utils.PointFloat(0.0001271566F, 0F);
            this.xrCompanyHeader.Name = "xrCompanyHeader";
            this.xrCompanyHeader.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LanguageId", this.LanguageId));
            this.xrCompanyHeader.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FormName", this.FormName));
            this.xrCompanyHeader.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("StatementId", this.StatementId));
            this.xrCompanyHeader.ReportSource = new WebAPIReports.Reports.Invoice.RptInvoiceCompanyHeader();
            this.xrCompanyHeader.SizeF = new System.Drawing.SizeF(765F, 22.99999F);
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
            // CalcAgPhone
            // 
            this.CalcAgPhone.DataMember = "Acc_Invoice_Agency_Header(@StatementId)";
            this.CalcAgPhone.Expression = " Iif(not IsNullOrEmpty([AgPhone1]),\n           Iif(Len(Trim([AgPhone1])) <= 10, \n" +
    "\t\t ToLong(Trim([AgPhone1])), \t\t\t\t\t  \t\t ToLong(Substring(Trim([AgPhone1]),0  ,9 )" +
    ")\n\t\t) ,\'\')";
            this.CalcAgPhone.Name = "CalcAgPhone";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine3,
            this.xrPagerInfo1});
            this.ReportFooter.HeightF = 27.77099F;
            this.ReportFooter.KeepTogether = true;
            this.ReportFooter.Name = "ReportFooter";
            this.ReportFooter.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            this.ReportFooter.PrintAtBottom = true;
            // 
            // xrLine3
            // 
            this.xrLine3.BorderColor = System.Drawing.Color.Black;
            this.xrLine3.Color = null;
            this.xrLine3.ForeColor = System.Drawing.Color.Black;
            this.xrLine3.LineWidth = 10;
            this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine3.Name = "xrLine3";
            this.xrLine3.SizeF = new System.Drawing.SizeF(765F, 10.5F);
            this.xrLine3.StylePriority.UseForeColor = false;
            // 
            // xrPagerInfo1
            // 
            this.xrPagerInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.xrPagerInfo1.LocationFloat = new DevExpress.Utils.PointFloat(601.91F, 10.5F);
            this.xrPagerInfo1.Name = "xrPagerInfo1";
            this.xrPagerInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 0, 0, 100F);
            this.xrPagerInfo1.SizeF = new System.Drawing.SizeF(163.0831F, 17F);
            this.xrPagerInfo1.StylePriority.UseFont = false;
            this.xrPagerInfo1.StylePriority.UsePadding = false;
            this.xrPagerInfo1.StylePriority.UseTextAlignment = false;
            this.xrPagerInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // frFaxMessage
            // 
            this.frFaxMessage.Condition = "Not IsNullOrEmpty([AgFaxMessageText])";
            this.frFaxMessage.Formatting.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.frFaxMessage.Name = "frFaxMessage";
            // 
            // frShowCommiPaymentMethod
            // 
            this.frShowCommiPaymentMethod.Condition = resources.GetString("frShowCommiPaymentMethod.Condition");
            this.frShowCommiPaymentMethod.Formatting.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.frShowCommiPaymentMethod.Name = "frShowCommiPaymentMethod";
            // 
            // frShowCommissionBox
            // 
            this.frShowCommissionBox.Condition = "[ShowAgCommiStatement] == False";
            this.frShowCommissionBox.DataMember = "Acc_Invoice_Agency_Header(@StatementId)";
            this.frShowCommissionBox.Formatting.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.frShowCommissionBox.Name = "frShowCommissionBox";
            // 
            // CalcCommiPaymentMethod
            // 
            this.CalcCommiPaymentMethod.DataMember = "Acc_Invoice_Agency_Header(@StatementId)";
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
            this.xrLine5,
            this.xrLabel2,
            this.xrPageInfo2});
            this.PageFooter.HeightF = 27.77099F;
            this.PageFooter.Name = "PageFooter";
            this.PageFooter.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportFooter;
            this.PageFooter.StylePriority.UseTextAlignment = false;
            this.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // xrLine5
            // 
            this.xrLine5.BorderColor = System.Drawing.Color.Black;
            this.xrLine5.Color = null;
            this.xrLine5.ForeColor = System.Drawing.Color.Black;
            this.xrLine5.LineWidth = 10;
            this.xrLine5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine5.Name = "xrLine5";
            this.xrLine5.SizeF = new System.Drawing.SizeF(765F, 10.5F);
            this.xrLine5.StylePriority.UseForeColor = false;
            // 
            // xrLabel2
            // 
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).DailyStatementTitle")});
            this.xrLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(208.5033F, 10.50002F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(213.7124F, 17F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UsePadding = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrPageInfo2
            // 
            this.xrPageInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(601.91F, 10.50002F);
            this.xrPageInfo2.Name = "xrPageInfo2";
            this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 4, 0, 0, 100F);
            this.xrPageInfo2.SizeF = new System.Drawing.SizeF(163.0831F, 17F);
            this.xrPageInfo2.StylePriority.UseFont = false;
            this.xrPageInfo2.StylePriority.UsePadding = false;
            this.xrPageInfo2.StylePriority.UseTextAlignment = false;
            this.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
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
            this.CalcAgFax.DataMember = "Acc_Invoice_Agency_Header(@StatementId)";
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
            // xrLabel6
            // 
            this.xrLabel6.AutoWidth = true;
            this.xrLabel6.CanShrink = true;
            this.xrLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel6.FormattingRules.Add(this.frShowCommiPaymentMethod);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(1.109924F, 38.99998F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(276.8272F, 14F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UsePadding = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrLabel6.Visible = false;
            this.xrLabel6.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel6_BeforePrint);
            // 
            // xrPanel6
            // 
            this.xrPanel6.CanShrink = true;
            this.xrPanel6.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel6,
            this.xrPanel5});
            this.xrPanel6.FormattingRules.Add(this.frShowCommissionBox);
            this.xrPanel6.LocationFloat = new DevExpress.Utils.PointFloat(482.379F, 15F);
            this.xrPanel6.Name = "xrPanel6";
            this.xrPanel6.SizeF = new System.Drawing.SizeF(279.39F, 55F);
            // 
            // xrPanel5
            // 
            this.xrPanel5.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPanel5.BorderWidth = 1.5F;
            this.xrPanel5.CanShrink = true;
            this.xrPanel5.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTCommission});
            this.xrPanel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("BorderColor", null, "Acc_Invoice_Agency_Header(@StatementId).ReportColorForeground")});
            this.xrPanel5.FormattingRules.Add(this.frShowCommissionBox);
            this.xrPanel5.LocationFloat = new DevExpress.Utils.PointFloat(1.109955F, 0F);
            this.xrPanel5.Name = "xrPanel5";
            this.xrPanel5.SizeF = new System.Drawing.SizeF(278.28F, 37.00002F);
            this.xrPanel5.StylePriority.UseBorderColor = false;
            this.xrPanel5.StylePriority.UseBorders = false;
            this.xrPanel5.StylePriority.UseBorderWidth = false;
            // 
            // xrTCommission
            // 
            this.xrTCommission.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTCommission.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2.000006F);
            this.xrTCommission.Name = "xrTCommission";
            this.xrTCommission.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow4,
            this.xrTableRow5});
            this.xrTCommission.SizeF = new System.Drawing.SizeF(276.8272F, 31F);
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
            this.xrTableCell8.BorderColor = System.Drawing.Color.Black;
            this.xrTableCell8.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableCell8.BorderWidth = 1.5F;
            this.xrTableCell8.CanGrow = false;
            this.xrTableCell8.CanShrink = true;
            this.xrTableCell8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).AgentCommission"),
            new DevExpress.XtraReports.UI.XRBinding("BorderColor", null, "Acc_Invoice_Agency_Header(@StatementId).ReportColorForeground")});
            this.xrTableCell8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.xrTableCell8.HexaForeColor = null;
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.StylePriority.UseBorders = false;
            this.xrTableCell8.StylePriority.UseBorderWidth = false;
            this.xrTableCell8.StylePriority.UseFont = false;
            this.xrTableCell8.StylePriority.UseTextAlignment = false;
            this.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell8.Weight = 1.5721060989452282D;
            // 
            // xrTableRow5
            // 
            this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell11,
            this.xrTableCell16,
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
            this.xrTableCell11.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100F);
            this.xrTableCell11.StylePriority.UseFont = false;
            this.xrTableCell11.StylePriority.UsePadding = false;
            this.xrTableCell11.StylePriority.UseTextAlignment = false;
            this.xrTableCell11.Text = "Wednesday 11/11/24";
            this.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell11.Weight = 1.0450041481904082D;
            // 
            // xrTableCell16
            // 
            this.xrTableCell16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic);
            this.xrTableCell16.Multiline = true;
            this.xrTableCell16.Name = "xrTableCell16";
            this.xrTableCell16.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrTableCell16.StylePriority.UseFont = false;
            this.xrTableCell16.StylePriority.UsePadding = false;
            this.xrTableCell16.StylePriority.UseTextAlignment = false;
            this.xrTableCell16.Text = "Pagos Facturas";
            this.xrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell16.Weight = 0.75576189318122844D;
            // 
            // xrTableCell13
            // 
            this.xrTableCell13.CanGrow = false;
            this.xrTableCell13.CanShrink = true;
            this.xrTableCell13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic);
            this.xrTableCell13.Name = "xrTableCell13";
            this.xrTableCell13.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F);
            this.xrTableCell13.StylePriority.UseFont = false;
            this.xrTableCell13.StylePriority.UsePadding = false;
            this.xrTableCell13.StylePriority.UseTextAlignment = false;
            this.xrTableCell13.Text = "$10,223,458.25";
            this.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell13.Weight = 0.78214092496798038D;
            // 
            // xrCommyType
            // 
            this.xrCommyType.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Agency_Header(@StatementId).CommiPaymentMethod")});
            this.xrCommyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.xrCommyType.LocationFloat = new DevExpress.Utils.PointFloat(369.3754F, 0F);
            this.xrCommyType.Name = "xrCommyType";
            this.xrCommyType.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrCommyType.SizeF = new System.Drawing.SizeF(73.5F, 14F);
            this.xrCommyType.StylePriority.UseFont = false;
            this.xrCommyType.StylePriority.UsePadding = false;
            this.xrCommyType.Visible = false;
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
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCommiPaidNote,
            this.xrCommyType,
            this.xrPanel8,
            this.xrLabel8,
            this.xrPanel6,
            this.xrSubInTransit});
            this.GroupFooter1.HeightF = 82.21815F;
            this.GroupFooter1.Name = "GroupFooter1";
            this.GroupFooter1.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.GroupFooter1_BeforePrint);
            // 
            // xrPanel8
            // 
            this.xrPanel8.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPanel8.BorderWidth = 1.5F;
            this.xrPanel8.CanShrink = true;
            this.xrPanel8.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTDebitCard});
            this.xrPanel8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("BorderColor", null, "Acc_Invoice_Agency_Header(@StatementId).ReportColorForeground")});
            this.xrPanel8.LocationFloat = new DevExpress.Utils.PointFloat(9.999974F, 15F);
            this.xrPanel8.Name = "xrPanel8";
            this.xrPanel8.SizeF = new System.Drawing.SizeF(328F, 36.00006F);
            this.xrPanel8.StylePriority.UseBorderColor = false;
            this.xrPanel8.StylePriority.UseBorders = false;
            this.xrPanel8.StylePriority.UseBorderWidth = false;
            this.xrPanel8.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.xrPanel8_PrintOnPage);
            // 
            // xrTDebitCard
            // 
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
            this.xrTableCell7.BorderColor = System.Drawing.Color.Black;
            this.xrTableCell7.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTableCell7.BorderWidth = 1.5F;
            this.xrTableCell7.CanGrow = false;
            this.xrTableCell7.CanShrink = true;
            this.xrTableCell7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).DebitPaymentChart"),
            new DevExpress.XtraReports.UI.XRBinding("BorderColor", null, "Acc_Invoice_Agency_Header(@StatementId).ReportColorForeground")});
            this.xrTableCell7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.xrTableCell7.HexaForeColor = null;
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
            // xrLabel8
            // 
            this.xrLabel8.BorderColor = System.Drawing.Color.Black;
            this.xrLabel8.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Agency_Header(@StatementId).AgFaxMessageText"),
            new DevExpress.XtraReports.UI.XRBinding("BorderColor", null, "Acc_Invoice_Agency_Header(@StatementId).ReportColorForeground")});
            this.xrLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.xrLabel8.FormattingRules.Add(this.frFaxMessage);
            this.xrLabel8.HexaForeColor = null;
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(0F, 70F);
            this.xrLabel8.Multiline = true;
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(760.3162F, 11.54169F);
            this.xrLabel8.StylePriority.UseBackColor = false;
            this.xrLabel8.StylePriority.UseBorders = false;
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UsePadding = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
            this.xrLabel8.TextTrimming = System.Drawing.StringTrimming.Word;
            this.xrLabel8.Visible = false;
            // 
            // xrSubInTransit
            // 
            this.xrSubInTransit.LocationFloat = new DevExpress.Utils.PointFloat(9.550858F, 14F);
            this.xrSubInTransit.Name = "xrSubInTransit";
            this.xrSubInTransit.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("StatementId", this.StatementId));
            this.xrSubInTransit.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LanguageId", this.LanguageId));
            this.xrSubInTransit.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("lblAmount", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Amount    "));
            this.xrSubInTransit.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("lblPayments", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Payments"));
            this.xrSubInTransit.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("lblInTransit", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).InTransit"));
            this.xrSubInTransit.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Color", null, "Acc_Invoice_Agency_Header(@StatementId).ReportColorForeground"));
            this.xrSubInTransit.ReportSource = new WebAPIReports.Reports.Invoice.RptInvoiceInTransit();
            this.xrSubInTransit.SizeF = new System.Drawing.SizeF(369.1666F, 1F);
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel29,
            this.xrLabel7,
            this.xrTransDate,
            this.xrLabel28,
            this.xrLabel27,
            this.xrLine4,
            this.xrLabel13,
            this.xrLabel15,
            this.xrLabel14,
            this.xrLabel16,
            this.xrLabel12,
            this.xrCompanyHeader});
            this.ReportHeader.Expanded = false;
            this.ReportHeader.HeightF = 59.375F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // CalcTopUpLabel
            // 
            this.CalcTopUpLabel.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcTopUpLabel.DataSource = this.WireSecurity;
            this.CalcTopUpLabel.Expression = "Trim([TopUpsTittle])";
            this.CalcTopUpLabel.Name = "CalcTopUpLabel";
            // 
            // CalcTopUpNote
            // 
            this.CalcTopUpNote.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcTopUpNote.DataSource = this.WireSecurity;
            this.CalcTopUpNote.Expression = resources.GetString("CalcTopUpNote.Expression");
            this.CalcTopUpNote.Name = "CalcTopUpNote";
            // 
            // RptCompanyInvoice
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader,
            this.ReportFooter,
            this.PageFooter,
            this.GroupFooter1,
            this.ReportHeader});
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
            this.CalcTransact,
            this.CalcTopUpLabel,
            this.CalcTopUpNote});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.WireTransac,
            this.WireSecurity});
            this.DataMember = "Acc_Invoice_Agency_Header(@StatementId)";
            this.DataSource = this.WireTransac;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormattingRuleSheet.AddRange(new DevExpress.XtraReports.UI.FormattingRule[] {
            this.frShowCommissionBox,
            this.frFaxMessage,
            this.frShowCommiPaymentMethod,
            this.frWiresVisible,
            this.frWiresInboundVisible});
            this.Margins = new System.Drawing.Printing.Margins(54, 31, 10, 10);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.StatementId,
            this.LanguageId,
            this.FormName,
            this.AgencyCode,
            this.IsInvoiceForCaribe});
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
        private DevExpress.XtraReports.UI.CalculatedField CalcLegalEntiyInfo;
        private DevExpress.XtraReports.UI.CalculatedField CalcAgInfoOwner;
        private DevExpress.XtraReports.UI.CalculatedField CalcAgInfo;
        private DevExpress.XtraReports.UI.CalculatedField CalcTotalPaymentAmount;
        private DevExpress.XtraReports.UI.CalculatedField CalcPaymentLabel;
        private DevExpress.XtraReports.UI.CalculatedField calculatedField1;
        private DevExpress.XtraReports.UI.SubBand SubBand1;
        private DevExpress.XtraReports.UI.XRPanelExtension xrPanel1;
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
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow10;
        private DevExpress.XtraReports.UI.XRTableCell xrLblDebitCard;
        private DevExpress.XtraReports.UI.XRTableCell xrQtyDebitCard;
        private DevExpress.XtraReports.UI.XRTableCell xrDebitCardAmount;
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
        private DevExpress.XtraReports.UI.XRSubreport xrSubOther;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.CalculatedField CalcAgPhone;
        private DevExpress.XtraReports.UI.XRLineExtension xrLine4;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.FormattingRule frShowCommissionBox;
        private DevExpress.XtraReports.UI.CalculatedField CalcCommiPaymentMethod;
        private DevExpress.XtraReports.UI.XRTable xrTSummary;
        private DevExpress.XtraReports.UI.CalculatedField CalcTrimPayment;
        private DevExpress.XtraReports.UI.CalculatedField CalcTrimOther;
        private DevExpress.XtraReports.UI.CalculatedField CalcTrimCancellations;
        private DevExpress.XtraReports.UI.FormattingRule frFaxMessage;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRLineExtension xrLine5;
        private DevExpress.XtraReports.UI.XRLineExtension xrLine3;
        private DevExpress.XtraReports.UI.FormattingRule frShowCommiPaymentMethod;
        private DevExpress.XtraReports.UI.CalculatedField CalcNote;
        private DevExpress.XtraReports.UI.XRLabel xrLabel22;
        private DevExpress.XtraReports.UI.XRLabel xrLabel21;
        private DevExpress.XtraReports.UI.CalculatedField CalcAgFax;
        private DevExpress.XtraReports.UI.XRLabel xrLabel23;
        private DevExpress.XtraReports.UI.CalculatedField CalcAgPhoneLabel;
        private DevExpress.XtraReports.UI.XRLabel xrLabel24;
        private DevExpress.XtraReports.UI.XRLabel xrLabel19;
        private DevExpress.XtraReports.UI.XRPanelExtension xrPanel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel25;
        private DevExpress.XtraReports.UI.XRLabel xrLabel26;
        private DevExpress.XtraReports.UI.XRLabel xrLabel28;
        private DevExpress.XtraReports.UI.XRLabel xrLabel27;
        private DevExpress.XtraReports.UI.XRLabel xrTransDate;
        private DevExpress.XtraReports.UI.CalculatedField CalcTrimBP;
        private DevExpress.XtraReports.UI.SubBand BillPayment;
        private DevExpress.XtraReports.UI.XRSubreport xrSubBillPayment;
        private DevExpress.XtraReports.UI.CalculatedField CalcSeqNo;
        private DevExpress.XtraReports.UI.CalculatedField CalcService;
        private DevExpress.XtraReports.UI.XRLabel xrLabel29;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.CalculatedField CalcStCurrency;
        private DevExpress.XtraReports.UI.SubBand DebitCard;
        private DevExpress.XtraReports.UI.XRSubreport xrSubDebitCard;
        private DevExpress.XtraReports.UI.CalculatedField CalcDebitCard;
        private DevExpress.XtraReports.UI.CalculatedField CalcTransact;
        private DevExpress.XtraReports.UI.XRLabel xrLabel30;
        private DevExpress.XtraReports.UI.XRSubreport xrCompanyHeader;
        private DevExpress.XtraReports.UI.XRSubreport xrSubInTransit;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell13;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell11;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow5;
        private DevExpress.XtraReports.UI.XRTableCellExtension xrTableCell8;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow4;
        private DevExpress.XtraReports.UI.XRTable xrTCommission;
        private DevExpress.XtraReports.UI.XRPanelExtension xrPanel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRPanel xrPanel6;
        private DevExpress.XtraReports.UI.XRLabelExtension xrLabel8;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell14;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell10;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell9;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow7;
        private DevExpress.XtraReports.UI.XRTableCellExtension xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow6;
        private DevExpress.XtraReports.UI.XRTable xrTDebitCard;
        private DevExpress.XtraReports.UI.XRPanelExtension xrPanel8;
        private DevExpress.XtraReports.UI.XRLabel xrCommyType;
        private DevExpress.XtraReports.UI.XRLabel xrCommiPaidNote;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.Parameters.Parameter AgencyCode;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.SubBand TopUps;
        private DevExpress.XtraReports.UI.XRSubreport xrSRTopUps;
        private DevExpress.XtraReports.UI.CalculatedField CalcTopUpLabel;
        private DevExpress.XtraReports.UI.SubBand SubBandSummary;
        private DevExpress.XtraReports.UI.XRPageInfo xrPagerInfo1;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell16;
        private DevExpress.XtraReports.UI.CalculatedField CalcTopUpNote;
        private DevExpress.XtraReports.UI.XRLabelExtension xrAgPayerDomestic;
        private DevExpress.XtraReports.UI.SubBand WiresPaid;
        private DevExpress.XtraReports.UI.XRSubreport xrSRWiresPaid;
        private DevExpress.XtraReports.Parameters.Parameter IsInvoiceForCaribe;
        private DevExpress.XtraReports.UI.FormattingRule frWiresVisible;
        private DevExpress.XtraReports.UI.XRSubreport xrSubWiresInbound;
        private DevExpress.XtraReports.UI.FormattingRule frWiresInboundVisible;
    }
}
