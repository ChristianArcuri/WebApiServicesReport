namespace WebAPIReports.Reports.Invoice.SmallFormat
{
    partial class CompanyRptInvoiceSm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyRptInvoiceSm));
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery3 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.SubBand1 = new DevExpress.XtraReports.UI.SubBand();
            this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            this.WireSecurity = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrPanel2 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrWiresLabel = new DevExpress.XtraReports.UI.XRLabel();
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
            this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrQtyDebitCard = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrDebitCardAmount = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrQtyBP = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrAmountBP = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow11 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrQtyTpUp = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTpUpAmount = new DevExpress.XtraReports.UI.XRTableCell();
            this.Payments = new DevExpress.XtraReports.UI.SubBand();
            this.xrSubPayment = new DevExpress.XtraReports.UI.XRSubreport();
            this.StatementId = new DevExpress.XtraReports.Parameters.Parameter();
            this.OtherCreditsDebits = new DevExpress.XtraReports.UI.SubBand();
            this.xrSubOther = new DevExpress.XtraReports.UI.XRSubreport();
            this.Cancellations = new DevExpress.XtraReports.UI.SubBand();
            this.xrSubCancellations = new DevExpress.XtraReports.UI.XRSubreport();
            this.Wires = new DevExpress.XtraReports.UI.SubBand();
            this.xrSubWires = new DevExpress.XtraReports.UI.XRSubreport();
            this.DebitCard = new DevExpress.XtraReports.UI.SubBand();
            this.xrDebitCard = new DevExpress.XtraReports.UI.XRSubreport();
            this.BillPayment = new DevExpress.XtraReports.UI.SubBand();
            this.xrSubreport1 = new DevExpress.XtraReports.UI.XRSubreport();
            this.TopUps = new DevExpress.XtraReports.UI.SubBand();
            this.xrSubTopUp = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrPanel3 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.fromDate = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrRightInfoHeader = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrReportCustomTitle = new DevExpress.XtraReports.UI.XRSubreport();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.frFaxMessage = new DevExpress.XtraReports.UI.FormattingRule();
            this.xrPanel6 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
            this.xrPanel5 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrTCommission = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.frShowCommissionBox = new DevExpress.XtraReports.UI.FormattingRule();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.frShowCommiPaymentMethod = new DevExpress.XtraReports.UI.FormattingRule();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLine4 = new DevExpress.XtraReports.UI.XRLine();
            this.xrPanel8 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrTDebitCard = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrSubInTransit = new DevExpress.XtraReports.UI.XRSubreport();
            this.LanguageId = new DevExpress.XtraReports.Parameters.Parameter();
            this.FormName = new DevExpress.XtraReports.Parameters.Parameter();
            this.CalcTrimTransaction = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcTrimDebitCard = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcTrimBP = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcAgPhoneLabel = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcAgFax = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcNote = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcTrimCancellations = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcTrimOther = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcTrimPayment = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcCommiPaymentMethod = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcAgPhone = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcWireSentLabel = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcCancellationLabel = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcOtherLabel = new DevExpress.XtraReports.UI.CalculatedField();
            this.calculatedField1 = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcPaymentLabel = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcTotalPaymentAmount = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcAgInfo = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcAgInfoOwner = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcLegalEntiyInfo = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcInfoHeader = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcHeaderInfo = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcTopUpLabel = new DevExpress.XtraReports.UI.CalculatedField();
            this.WireTransac = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.AgencyCode = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.xrTSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTCommission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTDebitCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.BorderWidth = 6F;
            this.Detail.HeightF = 1.041667F;
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
            this.TopUps});
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // SubBand1
            // 
            this.SubBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel23,
            this.xrLabel22,
            this.xrPanel1});
            this.SubBand1.HeightF = 182.3403F;
            this.SubBand1.Name = "SubBand1";
            // 
            // xrLabel23
            // 
            this.xrLabel23.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel23.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Header(@StatementId).BeginingBalance", "{0:$#,##0.00}")});
            this.xrLabel23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(214.9012F, 156.3716F);
            this.xrLabel23.Name = "xrLabel23";
            this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel23.SizeF = new System.Drawing.SizeF(103.4371F, 19.87502F);
            this.xrLabel23.StylePriority.UseBorders = false;
            this.xrLabel23.StylePriority.UseFont = false;
            this.xrLabel23.StylePriority.UseTextAlignment = false;
            this.xrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel22
            // 
            this.xrLabel22.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel22.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).BeginingBalance")});
            this.xrLabel22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(70.52636F, 156.3716F);
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel22.SizeF = new System.Drawing.SizeF(144.3748F, 19.87502F);
            this.xrLabel22.StylePriority.UseBorders = false;
            this.xrLabel22.StylePriority.UseFont = false;
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
            // xrPanel1
            // 
            this.xrPanel1.BorderColor = System.Drawing.Color.Black;
            this.xrPanel1.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPanel1.BorderWidth = 1F;
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel2,
            this.xrPanel4});
            this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(9.934106E-05F, 0F);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.SizeF = new System.Drawing.SizeF(319.0001F, 145.2953F);
            this.xrPanel1.StylePriority.UseBorderColor = false;
            this.xrPanel1.StylePriority.UseBorders = false;
            this.xrPanel1.StylePriority.UseBorderWidth = false;
            // 
            // xrPanel2
            // 
            this.xrPanel2.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrPanel2.BorderWidth = 1F;
            this.xrPanel2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrWiresLabel,
            this.xrLabel11,
            this.xrLabel9});
            this.xrPanel2.LocationFloat = new DevExpress.Utils.PointFloat(1.112567F, 121.9481F);
            this.xrPanel2.Name = "xrPanel2";
            this.xrPanel2.SizeF = new System.Drawing.SizeF(317.2256F, 23.00001F);
            this.xrPanel2.StylePriority.UseBorders = false;
            this.xrPanel2.StylePriority.UseBorderWidth = false;
            // 
            // xrWiresLabel
            // 
            this.xrWiresLabel.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrWiresLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Wires")});
            this.xrWiresLabel.LocationFloat = new DevExpress.Utils.PointFloat(152.1102F, 2F);
            this.xrWiresLabel.Name = "xrWiresLabel";
            this.xrWiresLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrWiresLabel.SizeF = new System.Drawing.SizeF(29.76823F, 19.87499F);
            this.xrWiresLabel.StylePriority.UseBorders = false;
            this.xrWiresLabel.Visible = false;
            // 
            // xrLabel11
            // 
            this.xrLabel11.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Header(@StatementId).EndingBalance", "{0:$#,##0.00}")});
            this.xrLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(213.5631F, 2F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(103.4371F, 19.87502F);
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
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(3.375057F, 2F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(144.3748F, 19.87502F);
            this.xrLabel9.StylePriority.UseBorders = false;
            this.xrLabel9.StylePriority.UseFont = false;
            // 
            // xrPanel4
            // 
            this.xrPanel4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrPanel4.CanShrink = true;
            this.xrPanel4.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTSummary});
            this.xrPanel4.LocationFloat = new DevExpress.Utils.PointFloat(1.112567F, 10.00002F);
            this.xrPanel4.Name = "xrPanel4";
            this.xrPanel4.SizeF = new System.Drawing.SizeF(317.8873F, 111.9481F);
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
            this.xrTableRow9,
            this.xrTableRow11});
            this.xrTSummary.SizeF = new System.Drawing.SizeF(314.5123F, 109F);
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
            this.xrTableCell4.Weight = 1.6033742039418137D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.CanGrow = false;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell5.Weight = 0.19355049073085298D;
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
            this.xrTableCell6.Weight = 0.7394921131925567D;
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
            this.xrLblPayment.Weight = 1.5322746187374969D;
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
            this.xrQtyPayments.Weight = 0.26465007593516987D;
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
            this.xrPaymentAmount.Weight = 0.7394921131925567D;
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
            this.xrLblOther.Weight = 1.5322746187374969D;
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
            this.xrQtyOtherCredits.Weight = 0.26465007593516987D;
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
            this.xrOtherAmount.Weight = 0.7394921131925567D;
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
            this.xrLblCancellation.Weight = 1.5322746187374969D;
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
            this.xrQtyCancellations.Weight = 0.26465007593516987D;
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
            this.xrCancellationAmount.Weight = 0.7394921131925567D;
            this.xrCancellationAmount.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.xrCancellationAmount_PrintOnPage);
            // 
            // xrTableRow10
            // 
            this.xrTableRow10.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell15,
            this.xrQtyDebitCard,
            this.xrDebitCardAmount});
            this.xrTableRow10.Name = "xrTableRow10";
            this.xrTableRow10.Weight = 0.6000000000000002D;
            this.xrTableRow10.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.xrTableRow10_PrintOnPage);
            // 
            // xrTableCell15
            // 
            this.xrTableCell15.CanShrink = true;
            this.xrTableCell15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CalcTrimDebitCard")});
            this.xrTableCell15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.xrTableCell15.Name = "xrTableCell15";
            this.xrTableCell15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell15.StylePriority.UseFont = false;
            this.xrTableCell15.Weight = 1.5322746187374969D;
            // 
            // xrQtyDebitCard
            // 
            this.xrQtyDebitCard.CanGrow = false;
            this.xrQtyDebitCard.CanShrink = true;
            this.xrQtyDebitCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.xrQtyDebitCard.Name = "xrQtyDebitCard";
            this.xrQtyDebitCard.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrQtyDebitCard.StylePriority.UseFont = false;
            this.xrQtyDebitCard.StylePriority.UsePadding = false;
            this.xrQtyDebitCard.StylePriority.UseTextAlignment = false;
            this.xrQtyDebitCard.Text = "xrQtyDebitCard";
            this.xrQtyDebitCard.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrQtyDebitCard.Weight = 0.26465007593516987D;
            this.xrQtyDebitCard.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.xrQtyDebitCard_PrintOnPage);
            // 
            // xrDebitCardAmount
            // 
            this.xrDebitCardAmount.CanGrow = false;
            this.xrDebitCardAmount.CanShrink = true;
            this.xrDebitCardAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.xrDebitCardAmount.Name = "xrDebitCardAmount";
            this.xrDebitCardAmount.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrDebitCardAmount.StylePriority.UseFont = false;
            this.xrDebitCardAmount.StylePriority.UsePadding = false;
            this.xrDebitCardAmount.StylePriority.UseTextAlignment = false;
            this.xrDebitCardAmount.Text = "xrDebitCardAmount";
            this.xrDebitCardAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrDebitCardAmount.Weight = 0.7394921131925567D;
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
            this.xrTableCell12.Weight = 1.5322744956814216D;
            // 
            // xrQtyBP
            // 
            this.xrQtyBP.CanGrow = false;
            this.xrQtyBP.CanShrink = true;
            this.xrQtyBP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.xrQtyBP.Name = "xrQtyBP";
            this.xrQtyBP.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrQtyBP.StylePriority.UseFont = false;
            this.xrQtyBP.StylePriority.UsePadding = false;
            this.xrQtyBP.StylePriority.UseTextAlignment = false;
            this.xrQtyBP.Text = "xrQtyBP";
            this.xrQtyBP.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrQtyBP.Weight = 0.264650198991245D;
            this.xrQtyBP.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.xrQtyBP_PrintOnPage);
            // 
            // xrAmountBP
            // 
            this.xrAmountBP.CanGrow = false;
            this.xrAmountBP.CanShrink = true;
            this.xrAmountBP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.xrAmountBP.Name = "xrAmountBP";
            this.xrAmountBP.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrAmountBP.StylePriority.UseFont = false;
            this.xrAmountBP.StylePriority.UsePadding = false;
            this.xrAmountBP.StylePriority.UseTextAlignment = false;
            this.xrAmountBP.Text = "xrAmountBP";
            this.xrAmountBP.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrAmountBP.Weight = 0.7394921131925567D;
            this.xrAmountBP.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.xrAmountBP_PrintOnPage);
            // 
            // xrTableRow11
            // 
            this.xrTableRow11.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell16,
            this.xrQtyTpUp,
            this.xrTpUpAmount});
            this.xrTableRow11.Name = "xrTableRow11";
            this.xrTableRow11.Weight = 0.6000000000000002D;
            this.xrTableRow11.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.xrTableRowTopUp_PrintOnPage);
            // 
            // xrTableCell16
            // 
            this.xrTableCell16.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CalcTopUpLabel")});
            this.xrTableCell16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.xrTableCell16.Multiline = true;
            this.xrTableCell16.Name = "xrTableCell16";
            this.xrTableCell16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell16.StylePriority.UseFont = false;
            this.xrTableCell16.StylePriority.UsePadding = false;
            this.xrTableCell16.Weight = 1.7488234705438828D;
            // 
            // xrQtyTpUp
            // 
            this.xrQtyTpUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.xrQtyTpUp.Multiline = true;
            this.xrQtyTpUp.Name = "xrQtyTpUp";
            this.xrQtyTpUp.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrQtyTpUp.StylePriority.UseFont = false;
            this.xrQtyTpUp.StylePriority.UsePadding = false;
            this.xrQtyTpUp.StylePriority.UseTextAlignment = false;
            this.xrQtyTpUp.Text = "xrQtyTpUp";
            this.xrQtyTpUp.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrQtyTpUp.Weight = 0.30205177628048308D;
            this.xrQtyTpUp.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.xrQtyTpUp_PrintOnPage);
            // 
            // xrTpUpAmount
            // 
            this.xrTpUpAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.xrTpUpAmount.Multiline = true;
            this.xrTpUpAmount.Name = "xrTpUpAmount";
            this.xrTpUpAmount.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTpUpAmount.StylePriority.UseFont = false;
            this.xrTpUpAmount.StylePriority.UsePadding = false;
            this.xrTpUpAmount.StylePriority.UseTextAlignment = false;
            this.xrTpUpAmount.Text = "xrTpUpAmount";
            this.xrTpUpAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTpUpAmount.Weight = 0.84400114169643969D;
            this.xrTpUpAmount.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.xrTpUpAmount_PrintOnPage);
            // 
            // Payments
            // 
            this.Payments.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubPayment});
            this.Payments.HeightF = 4.666646F;
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
            this.xrSubPayment.ReportSource = new WebAPIReports.Reports.Invoice.SmallFormat.RptInvoicePaymentSm();
            this.xrSubPayment.SizeF = new System.Drawing.SizeF(317F, 4.666646F);
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
            this.xrSubOther.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Date", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Date"));
            this.xrSubOther.ReportSource = new WebAPIReports.Reports.Invoice.SmallFormat.RptInvoiceOtherSm();
            this.xrSubOther.SizeF = new System.Drawing.SizeF(317F, 3.729184F);
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
            this.xrSubCancellations.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("WireNo", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).WireNo"));
            this.xrSubCancellations.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Descript", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Description"));
            this.xrSubCancellations.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Void", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Void"));
            this.xrSubCancellations.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Amount", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).ActivityBalance"));
            this.xrSubCancellations.ReportSource = new WebAPIReports.Reports.Invoice.SmallFormat.RptInvoiceCancellationsSm();
            this.xrSubCancellations.SizeF = new System.Drawing.SizeF(317F, 4.249954F);
            // 
            // Wires
            // 
            this.Wires.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubWires});
            this.Wires.HeightF = 4.250018F;
            this.Wires.Name = "Wires";
            // 
            // xrSubWires
            // 
            this.xrSubWires.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrSubWires.Name = "xrSubWires";
            this.xrSubWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("StatementId", this.StatementId));
            this.xrSubWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("WireLabel", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CalcWireSentLabel"));
            this.xrSubWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Date", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Date"));
            this.xrSubWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("WireNo", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).WireNo"));
            this.xrSubWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Sender", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Sender"));
            this.xrSubWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Void", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Void"));
            this.xrSubWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Amount", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).ActivityBalance"));
            this.xrSubWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Note", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CalcNote"));
            this.xrSubWires.ReportSource = new WebAPIReports.Reports.Invoice.SmallFormat.RptInvoiceWiresSm();
            this.xrSubWires.SizeF = new System.Drawing.SizeF(317F, 4.250018F);
            // 
            // DebitCard
            // 
            this.DebitCard.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrDebitCard});
            this.DebitCard.HeightF = 7.500013F;
            this.DebitCard.Name = "DebitCard";
            // 
            // xrDebitCard
            // 
            this.xrDebitCard.LocationFloat = new DevExpress.Utils.PointFloat(0.3380722F, 0.1249949F);
            this.xrDebitCard.Name = "xrDebitCard";
            this.xrDebitCard.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("StatementId", this.StatementId));
            this.xrDebitCard.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Date", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Date"));
            this.xrDebitCard.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Sender", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Sender"));
            this.xrDebitCard.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("ActivityBalance", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).ActivityBalance"));
            this.xrDebitCard.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("DebitCard", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CalcTrimDebitCard"));
            this.xrDebitCard.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Transaction", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CalcTrimTransaction"));
            this.xrDebitCard.ReportSource = new WebAPIReports.Reports.Invoice.SmallFormat.RptInvoiceDebitCardSm();
            this.xrDebitCard.SizeF = new System.Drawing.SizeF(316.3285F, 7.375019F);
            // 
            // BillPayment
            // 
            this.BillPayment.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreport1});
            this.BillPayment.HeightF = 8.333334F;
            this.BillPayment.Name = "BillPayment";
            // 
            // xrSubreport1
            // 
            this.xrSubreport1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrSubreport1.Name = "xrSubreport1";
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("StatementId", this.StatementId));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Date", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Date"));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("lblBP", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CalcTrimBP"));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Sender", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Sender"));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("ActivityBalance", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).ActivityBalance"));
            this.xrSubreport1.ReportSource = new WebAPIReports.Reports.Invoice.SmallFormat.RptInvoiceBPSm();
            this.xrSubreport1.SizeF = new System.Drawing.SizeF(315.6249F, 7.375018F);
            // 
            // TopUps
            // 
            this.TopUps.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubTopUp});
            this.TopUps.HeightF = 7.375018F;
            this.TopUps.Name = "TopUps";
            // 
            // xrSubTopUp
            // 
            this.xrSubTopUp.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrSubTopUp.Name = "xrSubTopUp";
            this.xrSubTopUp.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("StatementId", this.StatementId));
            this.xrSubTopUp.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Date", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Date"));
            this.xrSubTopUp.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("TopUpTittle", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CalcTopUpLabel"));
            this.xrSubTopUp.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("Sender", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Sender"));
            this.xrSubTopUp.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("ActivityBalance", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).ActivityBalance"));
            this.xrSubTopUp.ReportSource = new WebAPIReports.Reports.Invoice.SmallFormat.RptInvoiceTopUpSm();
            this.xrSubTopUp.SizeF = new System.Drawing.SizeF(315.625F, 7.375018F);
            // 
            // xrPanel3
            // 
            this.xrPanel3.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrPanel3.BorderWidth = 1F;
            this.xrPanel3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel25,
            this.xrLabel26});
            this.xrPanel3.LocationFloat = new DevExpress.Utils.PointFloat(2.000006F, 0F);
            this.xrPanel3.Name = "xrPanel3";
            this.xrPanel3.SizeF = new System.Drawing.SizeF(319F, 22F);
            this.xrPanel3.StylePriority.UseBorders = false;
            this.xrPanel3.StylePriority.UseBorderWidth = false;
            // 
            // xrLabel25
            // 
            this.xrLabel25.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel25.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Header(@StatementId).EndingBalance", "{0:$#,##0.00}")});
            this.xrLabel25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(213.4501F, 2F);
            this.xrLabel25.Name = "xrLabel25";
            this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel25.SizeF = new System.Drawing.SizeF(103.4371F, 19.87502F);
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
            this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(69.07533F, 2F);
            this.xrLabel26.Name = "xrLabel26";
            this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel26.SizeF = new System.Drawing.SizeF(144.3748F, 19.87502F);
            this.xrLabel26.StylePriority.UseBorders = false;
            this.xrLabel26.StylePriority.UseFont = false;
            // 
            // xrLabel3
            // 
            this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Header(@StatementId).CalcAgInfoOwner")});
            this.xrLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 23F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(316.6666F, 18.20831F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "xrLabel3";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel12
            // 
            this.xrLabel12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).InvoiceNum")});
            this.xrLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(234.3672F, 51.70833F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(82.29956F, 16.74999F);
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel13
            // 
            this.xrLabel13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Header(@StatementId).StatementId")});
            this.xrLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(242.7083F, 68.45838F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(73.95833F, 16.74998F);
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel15
            // 
            this.xrLabel15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Header(@StatementId).AgStatementSeq")});
            this.xrLabel15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(147.6039F, 68.45838F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(75.39616F, 16.74998F);
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel14
            // 
            this.xrLabel14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).AgencySeq")});
            this.xrLabel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(135.7918F, 51.70832F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(87.2083F, 16.74997F);
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // fromDate
            // 
            this.fromDate.AutoWidth = true;
            this.fromDate.CanGrow = false;
            this.fromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.fromDate.LocationFloat = new DevExpress.Utils.PointFloat(0F, 68.45832F);
            this.fromDate.Name = "fromDate";
            this.fromDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.fromDate.SizeF = new System.Drawing.SizeF(58.5F, 16.74998F);
            this.fromDate.StylePriority.UseFont = false;
            this.fromDate.WordWrap = false;
            this.fromDate.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.fromDate_BeforePrint);
            // 
            // xrLabel16
            // 
            this.xrLabel16.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Date")});
            this.xrLabel16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(0F, 51.70833F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(48.74142F, 16.74998F);
            this.xrLabel16.StylePriority.UseFont = false;
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
            // xrRightInfoHeader
            // 
            this.xrRightInfoHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel21,
            this.xrLabel20,
            this.xrLabel19,
            this.xrLabel18,
            this.xrLabel17,
            this.xrLabel10,
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel1});
            this.xrRightInfoHeader.LocationFloat = new DevExpress.Utils.PointFloat(0.3380736F, 3.999996F);
            this.xrRightInfoHeader.Name = "xrRightInfoHeader";
            this.xrRightInfoHeader.SizeF = new System.Drawing.SizeF(316.7746F, 60.47891F);
            // 
            // xrLabel21
            // 
            this.xrLabel21.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).LikeInfo")});
            this.xrLabel21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(0.549237F, 44.14558F);
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(306.7747F, 8F);
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.Text = "xrLabel21";
            // 
            // xrLabel20
            // 
            this.xrLabel20.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "GetAgencyCompanyInfo.CoBrandInvoicePhone")});
            this.xrLabel20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(0.549237F, 52.14558F);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(172.3958F, 8F);
            this.xrLabel20.StylePriority.UseFont = false;
            // 
            // xrLabel19
            // 
            this.xrLabel19.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "GetAgencyCompanyInfo.CoBrandPhoneCell")});
            this.xrLabel19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(122.3616F, 25.99999F);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(172.3958F, 8F);
            this.xrLabel19.StylePriority.UseFont = false;
            // 
            // xrLabel18
            // 
            this.xrLabel18.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "GetAgencyCompanyInfo.CoBrandEmail")});
            this.xrLabel18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(121.587F, 18F);
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(172.3958F, 8F);
            this.xrLabel18.StylePriority.UseFont = false;
            // 
            // xrLabel17
            // 
            this.xrLabel17.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "GetAgencyCompanyInfo.CoBrandPhoneFax")});
            this.xrLabel17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(122.3616F, 10.00001F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(172.3958F, 8F);
            this.xrLabel17.StylePriority.UseFont = false;
            // 
            // xrLabel10
            // 
            this.xrLabel10.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CellPhone")});
            this.xrLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(0.7745902F, 25.99999F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(121.587F, 8F);
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.Text = "xrLabel10";
            // 
            // xrLabel5
            // 
            this.xrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Email")});
            this.xrLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 18F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(121.587F, 8F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.Text = "xrLabel5";
            // 
            // xrLabel4
            // 
            this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Fax")});
            this.xrLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(0.7745862F, 10.00001F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(121.587F, 8F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.Text = "xrLabel4";
            // 
            // xrLabel1
            // 
            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).SendDeposit")});
            this.xrLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 3.178914E-05F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(306.7746F, 8F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "xrLabel1";
            // 
            // xrLine2
            // 
            this.xrLine2.BorderColor = System.Drawing.Color.Black;
            this.xrLine2.ForeColor = System.Drawing.Color.Black;
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 41.20831F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(316.6667F, 10.5F);
            this.xrLine2.StylePriority.UseBorderColor = false;
            this.xrLine2.StylePriority.UseForeColor = false;
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
            this.xrReportCustomTitle,
            this.xrLabel3,
            this.xrLabel13,
            this.xrLabel15,
            this.xrLabel14,
            this.fromDate,
            this.xrLabel16,
            this.xrLabel12,
            this.xrLine2});
            this.PageHeader.HeightF = 85.20836F;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.StylePriority.UseTextAlignment = false;
            this.PageHeader.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.PageHeader_BeforePrint);
            // 
            // xrReportCustomTitle
            // 
            this.xrReportCustomTitle.LocationFloat = new DevExpress.Utils.PointFloat(0.3381348F, 0F);
            this.xrReportCustomTitle.Name = "xrReportCustomTitle";
            this.xrReportCustomTitle.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("ReportTitle", null, "GetAgencyCompanyInfo.CoBrandName"));
            this.xrReportCustomTitle.ReportSource = new WebAPIReports.Reports.Common.CustomHeader.CompanyReportTitleSm();
            this.xrReportCustomTitle.SizeF = new System.Drawing.SizeF(316.3285F, 23F);
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrRightInfoHeader,
            this.xrLine1});
            this.ReportFooter.HeightF = 66.0414F;
            this.ReportFooter.KeepTogether = true;
            this.ReportFooter.Name = "ReportFooter";
            this.ReportFooter.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            this.ReportFooter.PrintAtBottom = true;
            // 
            // xrLine1
            // 
            this.xrLine1.BackColor = System.Drawing.Color.Transparent;
            this.xrLine1.BorderColor = System.Drawing.Color.Black;
            this.xrLine1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLine1.ForeColor = System.Drawing.Color.Black;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(317F, 4F);
            this.xrLine1.StylePriority.UseBackColor = false;
            this.xrLine1.StylePriority.UseBorderColor = false;
            this.xrLine1.StylePriority.UseBorders = false;
            this.xrLine1.StylePriority.UseForeColor = false;
            // 
            // xrLabel8
            // 
            this.xrLabel8.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrLabel8.CanShrink = true;
            this.xrLabel8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Header(@StatementId).AgFaxMessageText")});
            this.xrLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.xrLabel8.FormattingRules.Add(this.frFaxMessage);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(0.3381093F, 134.8125F);
            this.xrLabel8.Multiline = true;
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(317.8873F, 11.54169F);
            this.xrLabel8.StylePriority.UseBorders = false;
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UsePadding = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
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
            this.xrPanel6.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine3,
            this.xrPanel5,
            this.xrLabel7,
            this.xrLabel6});
            this.xrPanel6.FormattingRules.Add(this.frShowCommissionBox);
            this.xrPanel6.LocationFloat = new DevExpress.Utils.PointFloat(2.000006F, 45.41702F);
            this.xrPanel6.Name = "xrPanel6";
            this.xrPanel6.SizeF = new System.Drawing.SizeF(317.9998F, 48F);
            // 
            // xrLine3
            // 
            this.xrLine3.BackColor = System.Drawing.Color.Transparent;
            this.xrLine3.BorderColor = System.Drawing.Color.Black;
            this.xrLine3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLine3.ForeColor = System.Drawing.Color.Black;
            this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(0.8871834F, 25.1042F);
            this.xrLine3.Name = "xrLine3";
            this.xrLine3.SizeF = new System.Drawing.SizeF(317F, 4F);
            this.xrLine3.StylePriority.UseBackColor = false;
            this.xrLine3.StylePriority.UseBorderColor = false;
            this.xrLine3.StylePriority.UseBorders = false;
            this.xrLine3.StylePriority.UseForeColor = false;
            // 
            // xrPanel5
            // 
            this.xrPanel5.BorderColor = System.Drawing.Color.Black;
            this.xrPanel5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrPanel5.BorderWidth = 1F;
            this.xrPanel5.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTCommission});
            this.xrPanel5.FormattingRules.Add(this.frShowCommissionBox);
            this.xrPanel5.LocationFloat = new DevExpress.Utils.PointFloat(0.1125336F, 0F);
            this.xrPanel5.Name = "xrPanel5";
            this.xrPanel5.SizeF = new System.Drawing.SizeF(317F, 25.1042F);
            this.xrPanel5.StylePriority.UseBorderColor = false;
            this.xrPanel5.StylePriority.UseBorders = false;
            this.xrPanel5.StylePriority.UseBorderWidth = false;
            // 
            // xrTCommission
            // 
            this.xrTCommission.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTCommission.LocationFloat = new DevExpress.Utils.PointFloat(0.999999F, 2.000014F);
            this.xrTCommission.Name = "xrTCommission";
            this.xrTCommission.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow4,
            this.xrTableRow5});
            this.xrTCommission.SizeF = new System.Drawing.SizeF(314.5123F, 25.00001F);
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
            this.xrTableCell8.BorderWidth = 1F;
            this.xrTableCell8.CanGrow = false;
            this.xrTableCell8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).AgentCommission")});
            this.xrTableCell8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.StylePriority.UseBorders = false;
            this.xrTableCell8.StylePriority.UseBorderWidth = false;
            this.xrTableCell8.StylePriority.UseFont = false;
            this.xrTableCell8.StylePriority.UseTextAlignment = false;
            this.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell8.Weight = 1.7155421965083584D;
            this.xrTableCell8.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.xrTableCell8_PrintOnPage);
            // 
            // xrTableRow5
            // 
            this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell11,
            this.xrTableCell13});
            this.xrTableRow5.Name = "xrTableRow5";
            this.xrTableRow5.Weight = 0.40000026702880853D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.CanGrow = false;
            this.xrTableCell11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic);
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F);
            this.xrTableCell11.StylePriority.UseFont = false;
            this.xrTableCell11.StylePriority.UsePadding = false;
            this.xrTableCell11.StylePriority.UseTextAlignment = false;
            this.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell11.Weight = 1.27231251263896D;
            // 
            // xrTableCell13
            // 
            this.xrTableCell13.CanGrow = false;
            this.xrTableCell13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic);
            this.xrTableCell13.Name = "xrTableCell13";
            this.xrTableCell13.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F);
            this.xrTableCell13.StylePriority.UseFont = false;
            this.xrTableCell13.StylePriority.UsePadding = false;
            this.xrTableCell13.StylePriority.UseTextAlignment = false;
            this.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell13.Weight = 0.44322968386939821D;
            // 
            // frShowCommissionBox
            // 
            this.frShowCommissionBox.Condition = "[ShowAgCommiStatement] == False";
            this.frShowCommissionBox.DataMember = "Acc_Invoice_Header(@StatementId)";
            this.frShowCommissionBox.Formatting.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.frShowCommissionBox.Name = "frShowCommissionBox";
            // 
            // xrLabel7
            // 
            this.xrLabel7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Header(@StatementId).CommiPaymentMethod")});
            this.xrLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel7.FormattingRules.Add(this.frShowCommiPaymentMethod);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(210.1879F, 29.1042F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(65F, 14.00001F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UsePadding = false;
            this.xrLabel7.Visible = false;
            // 
            // frShowCommiPaymentMethod
            // 
            this.frShowCommiPaymentMethod.Condition = resources.GetString("frShowCommiPaymentMethod.Condition");
            this.frShowCommiPaymentMethod.Formatting.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.frShowCommiPaymentMethod.Name = "frShowCommiPaymentMethod";
            // 
            // xrLabel6
            // 
            this.xrLabel6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).AgCommWillBePAid")});
            this.xrLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.xrLabel6.FormattingRules.Add(this.frShowCommiPaymentMethod);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(0.8871794F, 29.10423F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(209.3006F, 14F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UsePadding = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrLabel6.Visible = false;
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel3,
            this.xrLine4,
            this.xrPanel8,
            this.xrLabel8,
            this.xrSubInTransit,
            this.xrPanel6});
            this.GroupFooter1.HeightF = 146.3542F;
            this.GroupFooter1.KeepTogether = true;
            this.GroupFooter1.Name = "GroupFooter1";
            // 
            // xrLine4
            // 
            this.xrLine4.BackColor = System.Drawing.Color.Transparent;
            this.xrLine4.BorderColor = System.Drawing.Color.Black;
            this.xrLine4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLine4.ForeColor = System.Drawing.Color.Black;
            this.xrLine4.LocationFloat = new DevExpress.Utils.PointFloat(2.11254F, 122.9653F);
            this.xrLine4.Name = "xrLine4";
            this.xrLine4.SizeF = new System.Drawing.SizeF(312.6F, 4F);
            this.xrLine4.StylePriority.UseBackColor = false;
            this.xrLine4.StylePriority.UseBorderColor = false;
            this.xrLine4.StylePriority.UseBorders = false;
            this.xrLine4.StylePriority.UseForeColor = false;
            this.xrLine4.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.xrLine4_PrintOnPage);
            // 
            // xrPanel8
            // 
            this.xrPanel8.BorderColor = System.Drawing.Color.Black;
            this.xrPanel8.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrPanel8.BorderWidth = 1F;
            this.xrPanel8.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTDebitCard});
            this.xrPanel8.LocationFloat = new DevExpress.Utils.PointFloat(0.8873423F, 97.81246F);
            this.xrPanel8.Name = "xrPanel8";
            this.xrPanel8.SizeF = new System.Drawing.SizeF(317.1126F, 25.1528F);
            this.xrPanel8.StylePriority.UseBorderColor = false;
            this.xrPanel8.StylePriority.UseBorders = false;
            this.xrPanel8.StylePriority.UseBorderWidth = false;
            this.xrPanel8.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.xrPanel8_PrintOnPage);
            // 
            // xrTDebitCard
            // 
            this.xrTDebitCard.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrTDebitCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTDebitCard.LocationFloat = new DevExpress.Utils.PointFloat(1.850001F, 1.999982F);
            this.xrTDebitCard.Name = "xrTDebitCard";
            this.xrTDebitCard.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow6,
            this.xrTableRow7});
            this.xrTDebitCard.SizeF = new System.Drawing.SizeF(312.8876F, 22F);
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
            this.xrTableCell7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).DebitPaymentChart")});
            this.xrTableCell7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.StylePriority.UseBorders = false;
            this.xrTableCell7.StylePriority.UseBorderWidth = false;
            this.xrTableCell7.StylePriority.UseFont = false;
            this.xrTableCell7.StylePriority.UseTextAlignment = false;
            this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell7.Weight = 2.42545051149018D;
            this.xrTableCell7.PrintOnPage += new DevExpress.XtraReports.UI.PrintOnPageEventHandler(this.xrTableCell7_PrintOnPage);
            // 
            // xrTableRow7
            // 
            this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell9,
            this.xrTableCell10,
            this.xrTableCell14});
            this.xrTableRow7.Name = "xrTableRow7";
            this.xrTableRow7.Weight = 0.2800000513907982D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.CanGrow = false;
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
            this.xrSubInTransit.LocationFloat = new DevExpress.Utils.PointFloat(2.000006F, 32.8125F);
            this.xrSubInTransit.Name = "xrSubInTransit";
            this.xrSubInTransit.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("StatementId", this.StatementId));
            this.xrSubInTransit.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("lblAmount", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Amount    "));
            this.xrSubInTransit.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("lblPayments", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Payments"));
            this.xrSubInTransit.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("lblInTransit", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).InTransit"));
            this.xrSubInTransit.ReportSource = new WebAPIReports.Reports.Invoice.SmallFormat.RptInvoiceInTransitSm();
            this.xrSubInTransit.SizeF = new System.Drawing.SizeF(317F, 2F);
            // 
            // LanguageId
            // 
            this.LanguageId.Name = "LanguageId";
            this.LanguageId.Type = typeof(int);
            this.LanguageId.ValueInfo = "2";
            this.LanguageId.Visible = false;
            // 
            // FormName
            // 
            this.FormName.Name = "FormName";
            this.FormName.ValueInfo = "REPORT.ACCOUNTING.NEWINVOICE";
            this.FormName.Visible = false;
            // 
            // CalcTrimTransaction
            // 
            this.CalcTrimTransaction.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcTrimTransaction.DataSource = this.WireSecurity;
            this.CalcTrimTransaction.Expression = "Trim([Transaction])";
            this.CalcTrimTransaction.Name = "CalcTrimTransaction";
            // 
            // CalcTrimDebitCard
            // 
            this.CalcTrimDebitCard.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcTrimDebitCard.DataSource = this.WireSecurity;
            this.CalcTrimDebitCard.Expression = "Trim([DebitCard])";
            this.CalcTrimDebitCard.Name = "CalcTrimDebitCard";
            // 
            // CalcTrimBP
            // 
            this.CalcTrimBP.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcTrimBP.DataSource = this.WireSecurity;
            this.CalcTrimBP.Expression = "Trim([BillPayment])";
            this.CalcTrimBP.Name = "CalcTrimBP";
            // 
            // CalcAgPhoneLabel
            // 
            this.CalcAgPhoneLabel.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcAgPhoneLabel.DataSource = this.WireSecurity;
            this.CalcAgPhoneLabel.Expression = "[phoneInvoice] + \':\'";
            this.CalcAgPhoneLabel.Name = "CalcAgPhoneLabel";
            // 
            // CalcAgFax
            // 
            this.CalcAgFax.DataMember = "Acc_Invoice_Header(@StatementId)";
            this.CalcAgFax.Expression = " Iif(not IsNullOrEmpty([AgFax1]),\n           Iif(Len(Trim([AgFax1])) <= 10, \n\t\t T" +
    "oLong(Trim([AgFax1])), \t\t\t\t\t  \t\t ToLong(Substring(Trim([AgFax1]),0  ,9 ))\n\t\t) ,\'" +
    "\')";
            this.CalcAgFax.Name = "CalcAgFax";
            // 
            // CalcNote
            // 
            this.CalcNote.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcNote.DataSource = this.WireSecurity;
            this.CalcNote.Expression = resources.GetString("CalcNote.Expression");
            this.CalcNote.Name = "CalcNote";
            // 
            // CalcTrimCancellations
            // 
            this.CalcTrimCancellations.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcTrimCancellations.DataSource = this.WireSecurity;
            this.CalcTrimCancellations.Expression = "Trim([Cancellations])";
            this.CalcTrimCancellations.Name = "CalcTrimCancellations";
            // 
            // CalcTrimOther
            // 
            this.CalcTrimOther.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcTrimOther.DataSource = this.WireSecurity;
            this.CalcTrimOther.Expression = "Trim([OtherDebitCredit])";
            this.CalcTrimOther.Name = "CalcTrimOther";
            // 
            // CalcTrimPayment
            // 
            this.CalcTrimPayment.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcTrimPayment.DataSource = this.WireSecurity;
            this.CalcTrimPayment.Expression = "Trim([Payments])";
            this.CalcTrimPayment.Name = "CalcTrimPayment";
            // 
            // CalcCommiPaymentMethod
            // 
            this.CalcCommiPaymentMethod.DataMember = "Acc_Invoice_Header(@StatementId)";
            this.CalcCommiPaymentMethod.Name = "CalcCommiPaymentMethod";
            // 
            // CalcAgPhone
            // 
            this.CalcAgPhone.DataMember = "Acc_Invoice_Header(@StatementId)";
            this.CalcAgPhone.Expression = " Iif(not IsNullOrEmpty([AgPhone1]),\n           Iif(Len(Trim([AgPhone1])) <= 10, \n" +
    "\t\t ToLong(Trim([AgPhone1])), \t\t\t\t\t  \t\t ToLong(Substring(Trim([AgPhone1]),0  ,9 )" +
    ")\n\t\t) ,\'\')";
            this.CalcAgPhone.Name = "CalcAgPhone";
            // 
            // CalcWireSentLabel
            // 
            this.CalcWireSentLabel.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcWireSentLabel.DataSource = this.WireSecurity;
            this.CalcWireSentLabel.DisplayName = "CalcWireSentLabel";
            this.CalcWireSentLabel.Expression = "Upper([WireTransfers])";
            this.CalcWireSentLabel.Name = "CalcWireSentLabel";
            // 
            // CalcCancellationLabel
            // 
            this.CalcCancellationLabel.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcCancellationLabel.DataSource = this.WireSecurity;
            this.CalcCancellationLabel.DisplayName = "CalcCancellationLabel";
            this.CalcCancellationLabel.Expression = "Upper([Cancellations])";
            this.CalcCancellationLabel.Name = "CalcCancellationLabel";
            // 
            // CalcOtherLabel
            // 
            this.CalcOtherLabel.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcOtherLabel.DataSource = this.WireSecurity;
            this.CalcOtherLabel.DisplayName = "CalcOtherLabel";
            this.CalcOtherLabel.Expression = "Upper([OtherDebitCredit])";
            this.CalcOtherLabel.Name = "CalcOtherLabel";
            // 
            // calculatedField1
            // 
            this.calculatedField1.DataMember = "Acc_Invoice_OtherCreditsDebits";
            this.calculatedField1.DisplayName = "CalcAmountDC";
            this.calculatedField1.Expression = "Sum([Amount])";
            this.calculatedField1.Name = "calculatedField1";
            // 
            // CalcPaymentLabel
            // 
            this.CalcPaymentLabel.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcPaymentLabel.DataSource = this.WireSecurity;
            this.CalcPaymentLabel.Expression = "Upper([Payments])";
            this.CalcPaymentLabel.Name = "CalcPaymentLabel";
            // 
            // CalcTotalPaymentAmount
            // 
            this.CalcTotalPaymentAmount.DataMember = "Acc_Invoice_Payments";
            this.CalcTotalPaymentAmount.Expression = "Sum([Amount])";
            this.CalcTotalPaymentAmount.Name = "CalcTotalPaymentAmount";
            this.CalcTotalPaymentAmount.Scripts.OnGetValue = "CalcTotalPaymentAmount_GetValue";
            // 
            // CalcAgInfo
            // 
            this.CalcAgInfo.DataMember = "Acc_Invoice_Header(@StatementId)";
            this.CalcAgInfo.Expression = "[AgAddress] + \' \'\n+ [AgAddress2]\n+ Char(13)\n+ [AgCity] + \', \' + [AgStateAbbr] + \'" +
    " \' + [AgZip]";
            this.CalcAgInfo.Name = "CalcAgInfo";
            // 
            // CalcAgInfoOwner
            // 
            this.CalcAgInfoOwner.DataMember = "Acc_Invoice_Header(@StatementId)";
            this.CalcAgInfoOwner.Expression = "Trim([AgencyCode]) + Char(13) + [Agname]";
            this.CalcAgInfoOwner.Name = "CalcAgInfoOwner";
            // 
            // CalcLegalEntiyInfo
            // 
            this.CalcLegalEntiyInfo.DataMember = "Acc_Invoice_Header(@StatementId)";
            this.CalcLegalEntiyInfo.Expression = "[LegalEntityOfficialName]";
            this.CalcLegalEntiyInfo.Name = "CalcLegalEntiyInfo";
            // 
            // CalcInfoHeader
            // 
            this.CalcInfoHeader.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcInfoHeader.DataSource = this.WireSecurity;
            this.CalcInfoHeader.Name = "CalcInfoHeader";
            // 
            // CalcHeaderInfo
            // 
            this.CalcHeaderInfo.DataMember = "Acc_Invoice_Header(@StatementId)";
            this.CalcHeaderInfo.Expression = "Iif([AgLanguageId] == 1,\'Please send your deposit receipt to:\',\'Favor de enviar s" +
    "u recibo de deposito a:\')";
            this.CalcHeaderInfo.Name = "CalcHeaderInfo";
            // 
            // CalcTopUpLabel
            // 
            this.CalcTopUpLabel.DataMember = "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName)";
            this.CalcTopUpLabel.DataSource = this.WireSecurity;
            this.CalcTopUpLabel.Expression = "Trim([TopUpsTittle])";
            this.CalcTopUpLabel.Name = "CalcTopUpLabel";
            // 
            // WireTransac
            // 
            this.WireTransac.ConnectionName = "WireTransacConn";
            this.WireTransac.Name = "WireTransac";
            storedProcQuery2.Name = "Acc_Invoice_Header(@StatementId)";
            queryParameter3.Name = "@StatementId";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("[Parameters.StatementId]", typeof(int));
            storedProcQuery2.Parameters.Add(queryParameter3);
            storedProcQuery2.StoredProcName = "Acc_Invoice_Header";
            storedProcQuery3.Name = "GetAgencyCompanyInfo";
            queryParameter4.Name = "@AgencyCode";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("[Parameters.AgencyCode]", typeof(string));
            storedProcQuery3.Parameters.Add(queryParameter4);
            storedProcQuery3.StoredProcName = "GetAgencyCompanyInfo";
            this.WireTransac.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery2,
            storedProcQuery3});
            this.WireTransac.ResultSchemaSerializable = resources.GetString("WireTransac.ResultSchemaSerializable");
            // 
            // AgencyCode
            // 
            this.AgencyCode.Description = "AgencyCode";
            this.AgencyCode.Name = "AgencyCode";
            this.AgencyCode.Visible = false;
            // 
            // CompanyRptInvoiceSm
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader,
            this.ReportFooter,
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
            this.CalcTrimDebitCard,
            this.CalcTrimTransaction,
            this.CalcTopUpLabel});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.WireSecurity,
            this.WireTransac});
            this.DataMember = "Acc_Invoice_Header(@StatementId)";
            this.DataSource = this.WireTransac;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormattingRuleSheet.AddRange(new DevExpress.XtraReports.UI.FormattingRule[] {
            this.frShowCommissionBox,
            this.frFaxMessage,
            this.frShowCommiPaymentMethod});
            this.Margins = new System.Drawing.Printing.Margins(3, 27, 0, 0);
            this.PageWidth = 351;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.StatementId,
            this.LanguageId,
            this.FormName,
            this.AgencyCode});
            this.RollPaper = true;
            this.ScriptsSource = resources.GetString("$this.ScriptsSource");
            this.ShowPrintMarginsWarning = false;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailData3_Odd,
            this.PageInfo});
            this.Version = "18.1";
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.RptInvoice_DataSourceDemanded);
            ((System.ComponentModel.ISupportInitialize)(this.xrTSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTCommission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTDebitCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLine xrLine2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.Parameters.Parameter StatementId;
        private DevExpress.DataAccess.Sql.SqlDataSource WireSecurity;
        private DevExpress.XtraReports.UI.SubBand SubBand1;
        private DevExpress.XtraReports.UI.XRPanel xrPanel1;
        private DevExpress.XtraReports.UI.XRPanel xrPanel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.XRLabel xrLabel13;
        private DevExpress.XtraReports.UI.XRLabel xrLabel15;
        private DevExpress.XtraReports.UI.XRLabel xrLabel14;
        private DevExpress.XtraReports.UI.XRLabel fromDate;
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
        private DevExpress.XtraReports.UI.XRSubreport xrSubWires;
        private DevExpress.XtraReports.UI.XRPanel xrPanel4;
        private DevExpress.XtraReports.UI.XRLabel xrWiresLabel;
        private DevExpress.XtraReports.UI.XRSubreport xrSubCancellations;
        private DevExpress.XtraReports.UI.XRSubreport xrSubOther;
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
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRPanel xrPanel6;
        private DevExpress.XtraReports.UI.XRTable xrTSummary;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.FormattingRule frFaxMessage;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.FormattingRule frShowCommiPaymentMethod;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRLine xrLine3;
        private DevExpress.XtraReports.UI.XRPanel xrRightInfoHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel20;
        private DevExpress.XtraReports.UI.XRLabel xrLabel19;
        private DevExpress.XtraReports.UI.XRLabel xrLabel18;
        private DevExpress.XtraReports.UI.XRLabel xrLabel17;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel21;
        private DevExpress.XtraReports.UI.XRLabel xrLabel23;
        private DevExpress.XtraReports.UI.XRLabel xrLabel22;
        private DevExpress.XtraReports.UI.XRPanel xrPanel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel25;
        private DevExpress.XtraReports.UI.XRLabel xrLabel26;
        private DevExpress.XtraReports.UI.XRPanel xrPanel8;
        private DevExpress.XtraReports.UI.XRTable xrTDebitCard;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell9;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell10;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell14;
        private DevExpress.XtraReports.UI.XRLine xrLine4;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow9;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell12;
        private DevExpress.XtraReports.UI.XRTableCell xrQtyBP;
        private DevExpress.XtraReports.UI.XRTableCell xrAmountBP;
        private DevExpress.XtraReports.UI.SubBand BillPayment;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreport1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow10;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell15;
        private DevExpress.XtraReports.UI.XRTableCell xrQtyDebitCard;
        private DevExpress.XtraReports.UI.XRTableCell xrDebitCardAmount;
        private DevExpress.XtraReports.UI.SubBand DebitCard;
        private DevExpress.XtraReports.UI.XRSubreport xrDebitCard;
        private DevExpress.XtraReports.Parameters.Parameter LanguageId;
        private DevExpress.XtraReports.Parameters.Parameter FormName;
        private DevExpress.XtraReports.UI.CalculatedField CalcTrimTransaction;
        private DevExpress.XtraReports.UI.CalculatedField CalcTrimDebitCard;
        private DevExpress.XtraReports.UI.CalculatedField CalcTrimBP;
        private DevExpress.XtraReports.UI.CalculatedField CalcAgPhoneLabel;
        private DevExpress.XtraReports.UI.CalculatedField CalcAgFax;
        private DevExpress.XtraReports.UI.CalculatedField CalcNote;
        private DevExpress.XtraReports.UI.CalculatedField CalcTrimCancellations;
        private DevExpress.XtraReports.UI.CalculatedField CalcTrimOther;
        private DevExpress.XtraReports.UI.CalculatedField CalcTrimPayment;
        private DevExpress.XtraReports.UI.CalculatedField CalcCommiPaymentMethod;
        private DevExpress.XtraReports.UI.CalculatedField CalcAgPhone;
        private DevExpress.XtraReports.UI.CalculatedField CalcWireSentLabel;
        private DevExpress.XtraReports.UI.CalculatedField CalcCancellationLabel;
        private DevExpress.XtraReports.UI.CalculatedField CalcOtherLabel;
        private DevExpress.XtraReports.UI.CalculatedField calculatedField1;
        private DevExpress.XtraReports.UI.CalculatedField CalcPaymentLabel;
        private DevExpress.XtraReports.UI.CalculatedField CalcTotalPaymentAmount;
        private DevExpress.XtraReports.UI.CalculatedField CalcAgInfo;
        private DevExpress.XtraReports.UI.CalculatedField CalcAgInfoOwner;
        private DevExpress.XtraReports.UI.CalculatedField CalcLegalEntiyInfo;
        private DevExpress.XtraReports.UI.CalculatedField CalcInfoHeader;
        private DevExpress.XtraReports.UI.CalculatedField CalcHeaderInfo;
        private DevExpress.DataAccess.Sql.SqlDataSource WireTransac;
        private DevExpress.XtraReports.Parameters.Parameter AgencyCode;
        private DevExpress.XtraReports.UI.XRSubreport xrReportCustomTitle;
        private DevExpress.XtraReports.UI.SubBand TopUps;
        private DevExpress.XtraReports.UI.XRSubreport xrSubTopUp;
        private DevExpress.XtraReports.UI.CalculatedField CalcTopUpLabel;
        private DevExpress.XtraReports.UI.XRTableCell xrQtyTpUp;
        private DevExpress.XtraReports.UI.XRTableCell xrTpUpAmount;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow11;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell16;        
    }
}
