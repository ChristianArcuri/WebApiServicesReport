namespace WebAPIReports.Reports.AgencyOverview
{
    partial class EndOfDayCompanyReportV3
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
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter5 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndOfDayCompanyReportV3));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrSubreportBillPay = new DevExpress.XtraReports.UI.XRSubreport();
            this.AgSenderCode = new DevExpress.XtraReports.Parameters.Parameter();
            this.FormName = new DevExpress.XtraReports.Parameters.Parameter();
            this.LanguageId = new DevExpress.XtraReports.Parameters.Parameter();
            this.D = new DevExpress.XtraReports.Parameters.Parameter();
            this.AllowViewCommissions = new DevExpress.XtraReports.Parameters.Parameter();
            this.UserName = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrSubreportWires = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrSubreportWiresCanceled = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrSubreportMoneyOrders = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrSubreportChecks = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrSubreportTopUps = new DevExpress.XtraReports.UI.XRSubreport();
            this.frTransferNoWires = new DevExpress.XtraReports.UI.FormattingRule();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrCompanyFooter = new DevExpress.XtraReports.UI.XRSubreport();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrCompanyHeader = new DevExpress.XtraReports.UI.XRSubreport();
            this.AgencyName = new DevExpress.XtraReports.Parameters.Parameter();
            this.OnlyFromVisible = new DevExpress.XtraReports.Parameters.Parameter();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailCaption3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailCaptionBackground3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.formattingRule1 = new DevExpress.XtraReports.UI.FormattingRule();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.calculatedField1 = new DevExpress.XtraReports.UI.CalculatedField();
            this.xrControlStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupFooter2 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLabel38 = new DevExpress.XtraReports.UI.XRLabel();
            this.SummaryHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrSubreportEndOfDaySummary = new DevExpress.XtraReports.UI.XRSubreport();
            this.xrSubreportChecksReturned = new DevExpress.XtraReports.UI.XRSubreport();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreportBillPay,
            this.xrSubreportWires,
            this.xrSubreportWiresCanceled,
            this.xrSubreportMoneyOrders,
            this.xrSubreportChecks,
            this.xrSubreportTopUps,
            this.xrSubreportChecksReturned});
            this.Detail.Dpi = 254F;
            this.Detail.Font = new System.Drawing.Font("Calibri", 10F);
            this.Detail.HeightF = 502.7083F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.Detail.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("AgSenderCode", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrSubreportBillPay
            // 
            this.xrSubreportBillPay.CanShrink = true;
            this.xrSubreportBillPay.Dpi = 254F;
            this.xrSubreportBillPay.LocationFloat = new DevExpress.Utils.PointFloat(0F, 210.2677F);
            this.xrSubreportBillPay.Name = "xrSubreportBillPay";
            this.xrSubreportBillPay.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgSenderCode", this.AgSenderCode));
            this.xrSubreportBillPay.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FormName", this.FormName));
            this.xrSubreportBillPay.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LanguageId", this.LanguageId));
            this.xrSubreportBillPay.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("D", this.D));
            this.xrSubreportBillPay.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AllowViewCommissions", this.AllowViewCommissions));
            this.xrSubreportBillPay.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("UserName", this.UserName));
            this.xrSubreportBillPay.ReportSource = new WebAPIReports.Reports.AgencyOverview.EndOfDayCompanyReportBillPayment();
            this.xrSubreportBillPay.SizeF = new System.Drawing.SizeF(2082.508F, 58.42F);
            // 
            // AgSenderCode
            // 
            this.AgSenderCode.Description = "AgSenderCode";
            this.AgSenderCode.Name = "AgSenderCode";
            this.AgSenderCode.ValueInfo = "FL1000";
            this.AgSenderCode.Visible = false;
            // 
            // FormName
            // 
            this.FormName.Description = "Parameter1";
            this.FormName.Name = "FormName";
            this.FormName.ValueInfo = "REPORT.IMXDIRECT.ENDOFDAY";
            this.FormName.Visible = false;
            // 
            // LanguageId
            // 
            this.LanguageId.Description = "Parameter1";
            this.LanguageId.Name = "LanguageId";
            this.LanguageId.Type = typeof(int);
            this.LanguageId.ValueInfo = "2";
            this.LanguageId.Visible = false;
            // 
            // D
            // 
            this.D.Description = "Date";
            this.D.Name = "D";
            this.D.Type = typeof(System.DateTime);
            this.D.ValueInfo = "2022-11-22";
            this.D.Visible = false;
            // 
            // AllowViewCommissions
            // 
            this.AllowViewCommissions.Description = "Allow View Commissions";
            this.AllowViewCommissions.Name = "AllowViewCommissions";
            this.AllowViewCommissions.Type = typeof(bool);
            this.AllowViewCommissions.ValueInfo = "False";
            // 
            // UserName
            // 
            this.UserName.Description = "UserName";
            this.UserName.Name = "UserName";
            this.UserName.Visible = false;
            // 
            // xrSubreportWires
            // 
            this.xrSubreportWires.CanShrink = true;
            this.xrSubreportWires.Dpi = 254F;
            this.xrSubreportWires.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrSubreportWires.Name = "xrSubreportWires";
            this.xrSubreportWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgSenderCode", this.AgSenderCode));
            this.xrSubreportWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FormName", this.FormName));
            this.xrSubreportWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LanguageId", this.LanguageId));
            this.xrSubreportWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("D", this.D));
            this.xrSubreportWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AllowViewCommissions", this.AllowViewCommissions));
            this.xrSubreportWires.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("UserName", this.UserName));
            this.xrSubreportWires.ReportSource = new WebAPIReports.Reports.AgencyOverview.EndOfDayCompanyReportWires();
            this.xrSubreportWires.SizeF = new System.Drawing.SizeF(2082.508F, 58.42F);
            // 
            // xrSubreportWiresCanceled
            // 
            this.xrSubreportWiresCanceled.CanShrink = true;
            this.xrSubreportWiresCanceled.Dpi = 254F;
            this.xrSubreportWiresCanceled.LocationFloat = new DevExpress.Utils.PointFloat(0F, 69.0033F);
            this.xrSubreportWiresCanceled.Name = "xrSubreportWiresCanceled";
            this.xrSubreportWiresCanceled.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgSenderCode", this.AgSenderCode));
            this.xrSubreportWiresCanceled.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FormName", this.FormName));
            this.xrSubreportWiresCanceled.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LanguageId", this.LanguageId));
            this.xrSubreportWiresCanceled.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("D", this.D));
            this.xrSubreportWiresCanceled.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AllowViewCommissions", this.AllowViewCommissions));
            this.xrSubreportWiresCanceled.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("UserName", this.UserName));
            this.xrSubreportWiresCanceled.ReportSource = new WebAPIReports.Reports.AgencyOverview.EndOfDayCompanyReportWiresCanceled();
            this.xrSubreportWiresCanceled.SizeF = new System.Drawing.SizeF(2082.508F, 58.42F);
            // 
            // xrSubreportMoneyOrders
            // 
            this.xrSubreportMoneyOrders.CanShrink = true;
            this.xrSubreportMoneyOrders.Dpi = 254F;
            this.xrSubreportMoneyOrders.LocationFloat = new DevExpress.Utils.PointFloat(0F, 138.8301F);
            this.xrSubreportMoneyOrders.Name = "xrSubreportMoneyOrders";
            this.xrSubreportMoneyOrders.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgencyCode", this.AgSenderCode));
            this.xrSubreportMoneyOrders.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("CurrentLanguageId", this.LanguageId));
            this.xrSubreportMoneyOrders.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LanguageId", this.LanguageId));
            this.xrSubreportMoneyOrders.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FromDate", this.D));
            this.xrSubreportMoneyOrders.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("ToDate", this.D));
            this.xrSubreportMoneyOrders.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("UserName", this.UserName));
            this.xrSubreportMoneyOrders.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AllowViewCommissions", this.AllowViewCommissions));
            this.xrSubreportMoneyOrders.ReportSource = new WebAPIReports.Reports.AgencyOverview.EndOfDayCompanyReportMOIssued();
            this.xrSubreportMoneyOrders.SizeF = new System.Drawing.SizeF(2082.508F, 58.42F);
            // 
            // xrSubreportChecks
            // 
            this.xrSubreportChecks.CanShrink = true;
            this.xrSubreportChecks.Dpi = 254F;
            this.xrSubreportChecks.LocationFloat = new DevExpress.Utils.PointFloat(0F, 354.73F);
            this.xrSubreportChecks.Name = "xrSubreportChecks";
            this.xrSubreportChecks.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgencyCode", this.AgSenderCode));
            this.xrSubreportChecks.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LanguageId", this.LanguageId));
            this.xrSubreportChecks.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("CheckFromDate", this.D));
            this.xrSubreportChecks.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("CheckToDate", this.D));
            this.xrSubreportChecks.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("UserName", this.UserName));
            this.xrSubreportChecks.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AllowViewCommissions", this.AllowViewCommissions));
            this.xrSubreportChecks.ReportSource = new WebAPIReports.Reports.AgencyOverview.EndOfDayCompanyReportChecks();
            this.xrSubreportChecks.SizeF = new System.Drawing.SizeF(2082.508F, 58.42F);
            // 
            // xrSubreportTopUps
            // 
            this.xrSubreportTopUps.CanShrink = true;
            this.xrSubreportTopUps.Dpi = 254F;
            this.xrSubreportTopUps.LocationFloat = new DevExpress.Utils.PointFloat(0F, 283.2927F);
            this.xrSubreportTopUps.Name = "xrSubreportTopUps";
            this.xrSubreportTopUps.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgSenderCode", this.AgSenderCode));
            this.xrSubreportTopUps.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FormName", this.FormName));
            this.xrSubreportTopUps.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LanguageId", this.LanguageId));
            this.xrSubreportTopUps.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("D", this.D));
            this.xrSubreportTopUps.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AllowViewCommissions", this.AllowViewCommissions));
            this.xrSubreportTopUps.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("UserName", this.UserName));
            this.xrSubreportTopUps.ReportSource = new WebAPIReports.Reports.AgencyOverview.EndOfDayCompanyReportTopUps();
            this.xrSubreportTopUps.SizeF = new System.Drawing.SizeF(2082.508F, 58.42F);
            // 
            // frTransferNoWires
            // 
            this.frTransferNoWires.Formatting.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic);
            this.frTransferNoWires.Name = "frTransferNoWires";
            // 
            // TopMargin
            // 
            this.TopMargin.Dpi = 254F;
            this.TopMargin.HeightF = 10F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCompanyFooter});
            this.BottomMargin.Dpi = 254F;
            this.BottomMargin.HeightF = 69F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrCompanyFooter
            // 
            this.xrCompanyFooter.Dpi = 254F;
            this.xrCompanyFooter.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrCompanyFooter.Name = "xrCompanyFooter";
            this.xrCompanyFooter.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgSenderCode", this.AgSenderCode));
            this.xrCompanyFooter.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FormName", this.FormName));
            this.xrCompanyFooter.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LanguageId", this.LanguageId));
            this.xrCompanyFooter.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("ReportTitle", null, "ConvertRowsInColumns_MultiLangLabels.WiresEndOfTheDayTitle"));
            this.xrCompanyFooter.ReportSource = new WebAPIReports.Reports.Common.CustomHeader.CompanyAgencyReportFooter();
            this.xrCompanyFooter.SizeF = new System.Drawing.SizeF(2098F, 66.03997F);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "WireTransacConn";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "sps_EndOfDayReport_withSplitCancels_CardDirect";
            queryParameter1.Name = "@AgSenderCode";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.AgSenderCode]", typeof(string));
            queryParameter2.Name = "@D";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.D]", typeof(System.DateTime));
            queryParameter3.Name = "@UserName";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("[Parameters.UserName]", typeof(string));
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.Parameters.Add(queryParameter2);
            storedProcQuery1.Parameters.Add(queryParameter3);
            storedProcQuery1.StoredProcName = "sps_EndOfDayReport_withSplitCancels_CardDirect_V3";
            storedProcQuery2.Name = "ConvertRowsInColumns_MultiLangLabels";
            queryParameter4.Name = "@LanguageId";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("[Parameters.LanguageId]", typeof(int));
            queryParameter5.Name = "@FormName";
            queryParameter5.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter5.Value = new DevExpress.DataAccess.Expression("[Parameters.FormName]", typeof(string));
            storedProcQuery2.Parameters.Add(queryParameter4);
            storedProcQuery2.Parameters.Add(queryParameter5);
            storedProcQuery2.StoredProcName = "ConvertRowsInColumns_MultiLangLabels";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1,
            storedProcQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            this.sqlDataSource1.ConfigureDataConnection += new DevExpress.DataAccess.Sql.ConfigureDataConnectionEventHandler(this.sqlDataSource1_ConfigureDataConnection);
            // 
            // reportHeaderBand1
            // 
            this.reportHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCompanyHeader});
            this.reportHeaderBand1.Dpi = 254F;
            this.reportHeaderBand1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.reportHeaderBand1.HeightF = 79.26914F;
            this.reportHeaderBand1.Name = "reportHeaderBand1";
            this.reportHeaderBand1.StylePriority.UseFont = false;
            // 
            // xrCompanyHeader
            // 
            this.xrCompanyHeader.Dpi = 254F;
            this.xrCompanyHeader.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrCompanyHeader.Name = "xrCompanyHeader";
            this.xrCompanyHeader.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgSenderCode", this.AgSenderCode));
            this.xrCompanyHeader.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FormName", this.FormName));
            this.xrCompanyHeader.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LanguageId", this.LanguageId));
            this.xrCompanyHeader.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("ReportTitle", null, "ConvertRowsInColumns_MultiLangLabels.WiresEndOfTheDayTitle"));
            this.xrCompanyHeader.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgencyName", this.AgencyName));
            this.xrCompanyHeader.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FDate", this.D));
            this.xrCompanyHeader.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("OnlyFromVisible", this.OnlyFromVisible));
            this.xrCompanyHeader.ReportSource = new WebAPIReports.Reports.Common.CustomHeader.CompanyAgencyReportHeader();
            this.xrCompanyHeader.SizeF = new System.Drawing.SizeF(2082.508F, 66.03998F);
            // 
            // AgencyName
            // 
            this.AgencyName.Description = "AgencyName";
            this.AgencyName.Name = "AgencyName";
            this.AgencyName.ValueInfo = "TEST AGENCY";
            this.AgencyName.Visible = false;
            // 
            // OnlyFromVisible
            // 
            this.OnlyFromVisible.Description = "Show only from date";
            this.OnlyFromVisible.Name = "OnlyFromVisible";
            this.OnlyFromVisible.Type = typeof(bool);
            this.OnlyFromVisible.ValueInfo = "True";
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BorderColor = System.Drawing.Color.Black;
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Title.BorderWidth = 1F;
            this.Title.Font = new System.Drawing.Font("Calibri", 14F);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.Title.Name = "Title";
            // 
            // DetailCaption3
            // 
            this.DetailCaption3.BackColor = System.Drawing.Color.Transparent;
            this.DetailCaption3.BorderColor = System.Drawing.Color.Transparent;
            this.DetailCaption3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DetailCaption3.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.DetailCaption3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.DetailCaption3.Name = "DetailCaption3";
            this.DetailCaption3.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254F);
            this.DetailCaption3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData3
            // 
            this.DetailData3.Font = new System.Drawing.Font("Calibri", 8F);
            this.DetailData3.ForeColor = System.Drawing.Color.Black;
            this.DetailData3.Name = "DetailData3";
            this.DetailData3.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254F);
            this.DetailData3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData3_Odd
            // 
            this.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent;
            this.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DetailData3_Odd.BorderWidth = 1F;
            this.DetailData3_Odd.Font = new System.Drawing.Font("Calibri", 8F);
            this.DetailData3_Odd.ForeColor = System.Drawing.Color.Black;
            this.DetailData3_Odd.Name = "DetailData3_Odd";
            this.DetailData3_Odd.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 15, 0, 0, 254F);
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
            // PageInfo
            // 
            this.PageInfo.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.PageInfo.Name = "PageInfo";
            this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            // 
            // formattingRule1
            // 
            this.formattingRule1.DataMember = "sps_EndOfDayReport_withSplitCancels_CardDirect";
            this.formattingRule1.Formatting.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.formattingRule1.Name = "formattingRule1";
            // 
            // xrLabel12
            // 
            this.xrLabel12.Dpi = 254F;
            this.xrLabel12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ConvertRowsInColumns_MultiLangLabels].[RptSentWiresNote]")});
            this.xrLabel12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.39592F);
            this.xrLabel12.Multiline = true;
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(2098F, 57.02096F);
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel12});
            this.ReportFooter.Dpi = 254F;
            this.ReportFooter.HeightF = 163.9361F;
            this.ReportFooter.KeepTogether = true;
            this.ReportFooter.Name = "ReportFooter";
            this.ReportFooter.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.ReportFooter_BeforePrint);
            // 
            // calculatedField1
            // 
            this.calculatedField1.DataMember = "sps_EndOfDayReport_withSplitCancels_CardDirect";
            this.calculatedField1.Expression = resources.GetString("calculatedField1.Expression");
            this.calculatedField1.FieldType = DevExpress.XtraReports.UI.FieldType.String;
            this.calculatedField1.Name = "calculatedField1";
            // 
            // xrControlStyle1
            // 
            this.xrControlStyle1.Name = "xrControlStyle1";
            // 
            // GroupFooter2
            // 
            this.GroupFooter2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel38});
            this.GroupFooter2.Dpi = 254F;
            this.GroupFooter2.HeightF = 206.3752F;
            this.GroupFooter2.Name = "GroupFooter2";
            this.GroupFooter2.Visible = false;
            this.GroupFooter2.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.GroupFooter2_BeforePrint);
            // 
            // xrLabel38
            // 
            this.xrLabel38.Dpi = 254F;
            this.xrLabel38.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ConvertRowsInColumns_MultiLangLabels].[EoDNoFoundInfo]")});
            this.xrLabel38.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel38.LocationFloat = new DevExpress.Utils.PointFloat(0F, 43.52084F);
            this.xrLabel38.Multiline = true;
            this.xrLabel38.Name = "xrLabel38";
            this.xrLabel38.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel38.SizeF = new System.Drawing.SizeF(2098F, 58.42001F);
            this.xrLabel38.StylePriority.UseFont = false;
            this.xrLabel38.StylePriority.UseTextAlignment = false;
            this.xrLabel38.Text = "xrLabel38";
            this.xrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // GroupHeader1
            // 
            this.SummaryHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreportEndOfDaySummary});
            this.SummaryHeader.Dpi = 254F;
            this.SummaryHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.SummaryHeader.HeightF = 69.1756F;
            this.SummaryHeader.Name = "GroupHeader1";
            this.SummaryHeader.StylePriority.UseFont = false;
            // 
            // xrSubreportEndOfDaySummary
            // 
            this.xrSubreportEndOfDaySummary.CanShrink = true;
            this.xrSubreportEndOfDaySummary.Dpi = 254F;
            this.xrSubreportEndOfDaySummary.LocationFloat = new DevExpress.Utils.PointFloat(2.018611E-05F, 10.7556F);
            this.xrSubreportEndOfDaySummary.Name = "xrSubreportEndOfDaySummary";
            this.xrSubreportEndOfDaySummary.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgSenderCode", this.AgSenderCode));
            this.xrSubreportEndOfDaySummary.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FormName", this.FormName));
            this.xrSubreportEndOfDaySummary.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LanguageId", this.LanguageId));
            this.xrSubreportEndOfDaySummary.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("D", this.D));
            this.xrSubreportEndOfDaySummary.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AllowViewCommissions", this.AllowViewCommissions));
            this.xrSubreportEndOfDaySummary.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("UserName", this.UserName));
            this.xrSubreportEndOfDaySummary.ReportSource = new WebAPIReports.Reports.AgencyOverview.EndOfDayCompanyReportSummary();
            this.xrSubreportEndOfDaySummary.SizeF = new System.Drawing.SizeF(2082.508F, 58.42F);
            // 
            // xrSubreportChecksReturned
            // 
            this.xrSubreportChecksReturned.CanShrink = true;
            this.xrSubreportChecksReturned.Dpi = 254F;
            this.xrSubreportChecksReturned.LocationFloat = new DevExpress.Utils.PointFloat(0F, 425.1092F);
            this.xrSubreportChecksReturned.Name = "xrSubreportChecksReturned";
            this.xrSubreportChecksReturned.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgencyCode", this.AgSenderCode));
            this.xrSubreportChecksReturned.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LanguageId", this.LanguageId));
            this.xrSubreportChecksReturned.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("CheckFromDate", this.D));
            this.xrSubreportChecksReturned.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("UserName", this.UserName));
            this.xrSubreportChecksReturned.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AllowViewCommissions", this.AllowViewCommissions));
            this.xrSubreportChecksReturned.ReportSource = new WebAPIReports.Reports.AgencyOverview.EndOfDayCompanyReportChecksReturned();
            this.xrSubreportChecksReturned.SizeF = new System.Drawing.SizeF(2082.508F, 58.42F);
            // 
            // EndOfDayCompanyReportV3
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.reportHeaderBand1,
            this.ReportFooter,
            this.GroupFooter2,
            this.SummaryHeader});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.calculatedField1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataSource = this.sqlDataSource1;
            this.Dpi = 254F;
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margins = new System.Drawing.Printing.Margins(29, 19, 10, 69);
            this.PageHeight = 2794;
            this.PageWidth = 2159;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.AgSenderCode,
            this.D,
            this.UserName,
            this.LanguageId,
            this.FormName,
            this.AgencyName,
            this.AllowViewCommissions,
            this.OnlyFromVisible});
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
            this.ScriptsSource = "\r\nprivate void xrLabel67_SummaryGetResult(object sender, DevExpress.XtraReports.U" +
    "I.SummaryGetResultEventArgs e) {\r\n\r\n}\r\n";
            this.SnapGridSize = 25F;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailCaption3,
            this.DetailData3,
            this.DetailData3_Odd,
            this.DetailCaptionBackground3,
            this.PageInfo,
            this.xrControlStyle1});
            this.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.Version = "18.1";
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.EndOfDayReport_DataSourceDemanded);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.ReportHeaderBand reportHeaderBand1;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle DetailCaption3;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData3;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
        private DevExpress.XtraReports.UI.XRControlStyle DetailCaptionBackground3;
        private DevExpress.XtraReports.UI.FormattingRule frTransferNoWires;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.Parameters.Parameter AgSenderCode;
        private DevExpress.XtraReports.Parameters.Parameter D;
        private DevExpress.XtraReports.UI.FormattingRule formattingRule1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.CalculatedField calculatedField1;
        private DevExpress.XtraReports.UI.XRControlStyle xrControlStyle1;
        private DevExpress.XtraReports.Parameters.Parameter UserName;
        private DevExpress.XtraReports.Parameters.Parameter LanguageId;
        private DevExpress.XtraReports.Parameters.Parameter FormName;
        private DevExpress.XtraReports.Parameters.Parameter AgencyName;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel38;
        private DevExpress.XtraReports.Parameters.Parameter AllowViewCommissions;
        private DevExpress.XtraReports.UI.XRSubreport xrCompanyHeader;
        private DevExpress.XtraReports.UI.XRSubreport xrCompanyFooter;
        private DevExpress.XtraReports.Parameters.Parameter OnlyFromVisible;
        private DevExpress.XtraReports.UI.GroupHeaderBand SummaryHeader;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreportWires;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreportWiresCanceled;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreportBillPay;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreportEndOfDaySummary;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreportMoneyOrders;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreportChecks;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreportTopUps;
        private DevExpress.XtraReports.UI.XRSubreport xrSubreportChecksReturned;
    }
}
