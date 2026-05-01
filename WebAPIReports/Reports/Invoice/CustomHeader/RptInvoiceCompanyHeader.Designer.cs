namespace WebAPIReports.Reports.Invoice
{
    partial class RptInvoiceCompanyHeader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptInvoiceCompanyHeader));
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrCompany = new DevExpress.XtraReports.UI.XRLabel();
            this.xrIHLine1 = new DevExpress.XtraReports.UI.XRLabel();
            this.WireSecurity = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.xrIHFax = new DevExpress.XtraReports.UI.XRLabel();
            this.xrIHFaxValue = new DevExpress.XtraReports.UI.XRLabel();
            this.xrIHEmail = new DevExpress.XtraReports.UI.XRLabel();
            this.xrIHEmailValue = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrIHPhone = new DevExpress.XtraReports.UI.XRLabel();
            this.xrIHPhoneValue = new DevExpress.XtraReports.UI.XRLabel();
            this.xrIHLineEnd = new DevExpress.XtraReports.UI.XRLabel();
            this.xrIHLineEndValue = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLineExtension();
            this.xrRightInfoHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.PictureBoxExtension();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLineExtension();
            this.xrPanel3 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrBankDeposit = new DevExpress.XtraReports.UI.XRLabel();
            this.WireTransac = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.StatementId = new DevExpress.XtraReports.Parameters.Parameter();
            this.LanguageId = new DevExpress.XtraReports.Parameters.Parameter();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
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
            this.CalcOtherLabel = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcCancellationLabel = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcWireSentLabel = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcAgPhone = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcNote = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcAgFax = new DevExpress.XtraReports.UI.CalculatedField();
            this.CalcAgPhoneLabel = new DevExpress.XtraReports.UI.CalculatedField();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.BorderWidth = 6F;
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCompany,
            this.xrIHLine1,
            this.xrIHFax,
            this.xrIHFaxValue,
            this.xrIHEmail,
            this.xrIHEmailValue,
            this.xrLabel2,
            this.xrIHPhone,
            this.xrIHPhoneValue,
            this.xrIHLineEnd,
            this.xrIHLineEndValue,
            this.xrLine2,
            this.xrRightInfoHeader,
            this.xrPictureBox1,
            this.xrLine1,
            this.xrPanel3,
            this.xrBankDeposit});
            this.Detail.HeightF = 96.50002F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StylePriority.UseBorderWidth = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrCompany
            // 
            this.xrCompany.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Agency_Header(@StatementId).CoBrandName")});
            this.xrCompany.LocationFloat = new DevExpress.Utils.PointFloat(363.0673F, 20.58333F);
            this.xrCompany.Multiline = true;
            this.xrCompany.Name = "xrCompany";
            this.xrCompany.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrCompany.SizeF = new System.Drawing.SizeF(50F, 13.99999F);
            this.xrCompany.Text = "xrCompany";
            this.xrCompany.Visible = false;
            // 
            // xrIHLine1
            // 
            this.xrIHLine1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).SendDeposit")});
            this.xrIHLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.xrIHLine1.LocationFloat = new DevExpress.Utils.PointFloat(258.472F, 11.58333F);
            this.xrIHLine1.Name = "xrIHLine1";
            this.xrIHLine1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrIHLine1.SizeF = new System.Drawing.SizeF(51.74216F, 9F);
            this.xrIHLine1.StylePriority.UseFont = false;
            this.xrIHLine1.Text = "xrLabel1";
            this.xrIHLine1.Visible = false;
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
            this.WireSecurity.ResultSchemaSerializable = resources.GetString("WireSecurity.ResultSchemaSerializable");
            // 
            // xrIHFax
            // 
            this.xrIHFax.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Fax")});
            this.xrIHFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.xrIHFax.LocationFloat = new DevExpress.Utils.PointFloat(311.3252F, 11.58333F);
            this.xrIHFax.Name = "xrIHFax";
            this.xrIHFax.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrIHFax.SizeF = new System.Drawing.SizeF(51.74214F, 9F);
            this.xrIHFax.StylePriority.UseFont = false;
            this.xrIHFax.Text = "xrLabel4";
            this.xrIHFax.Visible = false;
            // 
            // xrIHFaxValue
            // 
            this.xrIHFaxValue.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Agency_Header(@StatementId).CoBrandPhoneFax")});
            this.xrIHFaxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.xrIHFaxValue.LocationFloat = new DevExpress.Utils.PointFloat(363.0673F, 11.58333F);
            this.xrIHFaxValue.Name = "xrIHFaxValue";
            this.xrIHFaxValue.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrIHFaxValue.SizeF = new System.Drawing.SizeF(51.74216F, 9F);
            this.xrIHFaxValue.StylePriority.UseFont = false;
            this.xrIHFaxValue.Text = "xrLabel17";
            this.xrIHFaxValue.Visible = false;
            // 
            // xrIHEmail
            // 
            this.xrIHEmail.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).Email")});
            this.xrIHEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.xrIHEmail.LocationFloat = new DevExpress.Utils.PointFloat(258.472F, 27.45839F);
            this.xrIHEmail.Name = "xrIHEmail";
            this.xrIHEmail.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrIHEmail.SizeF = new System.Drawing.SizeF(51.74214F, 9F);
            this.xrIHEmail.StylePriority.UseFont = false;
            this.xrIHEmail.Text = "xrLabel5";
            this.xrIHEmail.Visible = false;
            // 
            // xrIHEmailValue
            // 
            this.xrIHEmailValue.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Agency_Header(@StatementId).CoBrandEmail")});
            this.xrIHEmailValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.xrIHEmailValue.LocationFloat = new DevExpress.Utils.PointFloat(311.3252F, 27.45839F);
            this.xrIHEmailValue.Name = "xrIHEmailValue";
            this.xrIHEmailValue.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrIHEmailValue.SizeF = new System.Drawing.SizeF(51.74213F, 9F);
            this.xrIHEmailValue.StylePriority.UseFont = false;
            this.xrIHEmailValue.Text = "xrLabel17";
            this.xrIHEmailValue.Visible = false;
            // 
            // xrLabel2
            // 
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Agency_Header(@StatementId).CalcLegalEntiyInfo")});
            this.xrLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(266.5124F, 36.45839F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(232.2917F, 23F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "xrLabel2";
            // 
            // xrIHPhone
            // 
            this.xrIHPhone.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).CellPhone")});
            this.xrIHPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.xrIHPhone.LocationFloat = new DevExpress.Utils.PointFloat(258.472F, 65.58334F);
            this.xrIHPhone.Name = "xrIHPhone";
            this.xrIHPhone.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrIHPhone.SizeF = new System.Drawing.SizeF(51.74216F, 9F);
            this.xrIHPhone.StylePriority.UseFont = false;
            this.xrIHPhone.Text = "xrLabel10";
            this.xrIHPhone.Visible = false;
            // 
            // xrIHPhoneValue
            // 
            this.xrIHPhoneValue.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Agency_Header(@StatementId).CellPhone")});
            this.xrIHPhoneValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.xrIHPhoneValue.LocationFloat = new DevExpress.Utils.PointFloat(311.3252F, 65.58334F);
            this.xrIHPhoneValue.Name = "xrIHPhoneValue";
            this.xrIHPhoneValue.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrIHPhoneValue.SizeF = new System.Drawing.SizeF(51.74216F, 9F);
            this.xrIHPhoneValue.StylePriority.UseFont = false;
            this.xrIHPhoneValue.Text = "xrLabel17";
            this.xrIHPhoneValue.Visible = false;
            // 
            // xrIHLineEnd
            // 
            this.xrIHLineEnd.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).LikeInfo")});
            this.xrIHLineEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.xrIHLineEnd.LocationFloat = new DevExpress.Utils.PointFloat(368.6254F, 65.58334F);
            this.xrIHLineEnd.Name = "xrIHLineEnd";
            this.xrIHLineEnd.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrIHLineEnd.SizeF = new System.Drawing.SizeF(42.4449F, 9.000004F);
            this.xrIHLineEnd.StylePriority.UseFont = false;
            this.xrIHLineEnd.Text = "xrLabel21";
            this.xrIHLineEnd.Visible = false;
            // 
            // xrIHLineEndValue
            // 
            this.xrIHLineEndValue.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Acc_Invoice_Agency_Header(@StatementId).InvoicePhone")});
            this.xrIHLineEndValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.xrIHLineEndValue.LocationFloat = new DevExpress.Utils.PointFloat(411.0703F, 65.58334F);
            this.xrIHLineEndValue.Name = "xrIHLineEndValue";
            this.xrIHLineEndValue.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrIHLineEndValue.SizeF = new System.Drawing.SizeF(41.14587F, 9F);
            this.xrIHLineEndValue.StylePriority.UseFont = false;
            this.xrIHLineEndValue.Text = "xrLabel17";
            this.xrIHLineEndValue.Visible = false;
            // 
            // xrLine2
            // 
            this.xrLine2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Color", null, "Acc_Invoice_Agency_Header(@StatementId).ReportColorForeground")});
            this.xrLine2.LineWidth = 2;
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 82.58334F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(765F, 6F);
            this.xrLine2.StylePriority.UseBorderColor = false;
            this.xrLine2.StylePriority.UseForeColor = false;
            // 
            // xrRightInfoHeader
            // 
            this.xrRightInfoHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.xrRightInfoHeader.LocationFloat = new DevExpress.Utils.PointFloat(507.2716F, 11.58333F);
            this.xrRightInfoHeader.Multiline = true;
            this.xrRightInfoHeader.Name = "xrRightInfoHeader";
            this.xrRightInfoHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRightInfoHeader.SizeF = new System.Drawing.SizeF(252.2948F, 70.99998F);
            this.xrRightInfoHeader.StylePriority.UseFont = false;
            this.xrRightInfoHeader.Text = "xrLabel17";
            this.xrRightInfoHeader.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrInfoHeader_BeforePrint);
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("BGColor", null, "Acc_Invoice_Agency_Header(@StatementId).ReportColorBackground")});
            this.xrPictureBox1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Logo", null, "Acc_Invoice_Agency_Header(@StatementId).Logo")});           
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(11.37497F, 31.74999F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(230F, 57F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
            this.xrPictureBox1.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter;

            this.xrLine1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Color", null, "Acc_Invoice_Agency_Header(@StatementId).ReportColorForeground")});
            this.xrLine1.LineWidth = 10;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(765F, 10.5F);
            this.xrLine1.StylePriority.UseForeColor = false;

            // xrPanel3
            // 
            this.xrPanel3.LocationFloat = new DevExpress.Utils.PointFloat(9.999974F, 32F);
            this.xrPanel3.Name = "xrPanel3";
            this.xrPanel3.SizeF = new System.Drawing.SizeF(232.2917F, 64.50002F);
            // 
            // xrBankDeposit
            // 
            this.xrBankDeposit.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.WireSecurity, "ConvertRowsInColumns_MultiLangLabels(@LanguageId, @FormName).BankDeposit")});
            this.xrBankDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.xrBankDeposit.LocationFloat = new DevExpress.Utils.PointFloat(415.3252F, 11.58333F);
            this.xrBankDeposit.Name = "xrBankDeposit";
            this.xrBankDeposit.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrBankDeposit.SizeF = new System.Drawing.SizeF(51.74214F, 9F);
            this.xrBankDeposit.StylePriority.UseFont = false;
            this.xrBankDeposit.Text = "xrLabel4";
            this.xrBankDeposit.Visible = false;
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
            // StatementId
            // 
            this.StatementId.Description = "StatementId";
            this.StatementId.Name = "StatementId";
            this.StatementId.Type = typeof(int);
            this.StatementId.ValueInfo = "13079674";
            this.StatementId.Visible = false;
            // 
            // LanguageId
            // 
            this.LanguageId.Name = "LanguageId";
            this.LanguageId.Type = typeof(int);
            this.LanguageId.ValueInfo = "2";
            this.LanguageId.Visible = false;
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
            this.CalcLegalEntiyInfo.Expression = "[LegalEntityOfficialName]\n+Char(13)\n+ [CoBrandAddress]\n+ Char(13)\n+ [CoBrandCity] " +
    "+ \', \' + [CoBrandState] + \' \' + [CoBrandZip]";
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
            // RptInvoiceCompanyHeader
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
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
            this.CalcNote,
            this.CalcAgFax,
            this.CalcAgPhoneLabel});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.WireTransac,
            this.WireSecurity});
            this.DataMember = "Acc_Invoice_Agency_Header(@StatementId)";
            this.DataSource = this.WireTransac;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margins = new System.Drawing.Printing.Margins(54, 31, 0, 0);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.StatementId,
            this.LanguageId,
            this.FormName});
            this.ScriptsSource = resources.GetString("$this.ScriptsSource");
            this.ShowPrintMarginsWarning = false;
            this.Version = "18.1";
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.RptInvoice_DataSourceDemanded);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.DataAccess.Sql.SqlDataSource WireTransac;
        
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
        private DevExpress.XtraReports.UI.CalculatedField CalcOtherLabel;
        private DevExpress.XtraReports.UI.CalculatedField CalcCancellationLabel;
        private DevExpress.XtraReports.UI.CalculatedField CalcWireSentLabel;
        private DevExpress.XtraReports.UI.CalculatedField CalcAgPhone;
        private DevExpress.XtraReports.UI.CalculatedField CalcNote;
        private DevExpress.XtraReports.UI.CalculatedField CalcAgFax;
        private DevExpress.XtraReports.UI.CalculatedField CalcAgPhoneLabel;
        private DevExpress.XtraReports.UI.XRLabel xrIHLine1;
        private DevExpress.XtraReports.UI.XRLabel xrIHFax;
        private DevExpress.XtraReports.UI.XRLabel xrIHFaxValue;
        private DevExpress.XtraReports.UI.XRLabel xrIHEmail;
        private DevExpress.XtraReports.UI.XRLabel xrIHEmailValue;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrIHPhone;
        private DevExpress.XtraReports.UI.XRLabel xrIHPhoneValue;
        private DevExpress.XtraReports.UI.XRLabel xrIHLineEnd;
        private DevExpress.XtraReports.UI.XRLabel xrIHLineEndValue;
        private DevExpress.XtraReports.UI.XRLineExtension xrLine2;
        private DevExpress.XtraReports.UI.XRLabel xrRightInfoHeader;
        private DevExpress.XtraReports.UI.PictureBoxExtension xrPictureBox1;
        private DevExpress.XtraReports.UI.XRLineExtension xrLine1;
        private DevExpress.XtraReports.UI.XRPanel xrPanel3;
        private DevExpress.XtraReports.UI.XRLabel xrBankDeposit;
        private DevExpress.XtraReports.UI.XRLabel xrCompany;
    }
}