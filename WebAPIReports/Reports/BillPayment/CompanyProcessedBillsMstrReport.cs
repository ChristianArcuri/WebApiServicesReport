using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using WebAPIReports.Reports;
using WebAPIReports.Reports.AgencyOverview;

/// <summary>
/// Summary description for ProcessedBillsMstrReport
/// </summary>
public class CompanyProcessedBillsMstrReport : DevExpress.XtraReports.UI.XtraReport
{
    private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(CompanyProcessedBillsMstrReport));

    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private DevExpress.XtraReports.Parameters.Parameter AgencyName;
    private DevExpress.XtraReports.Parameters.Parameter AgSenderCode;
    private DevExpress.XtraReports.Parameters.Parameter FormName;
    private DevExpress.XtraReports.Parameters.Parameter FDate;
    private DevExpress.XtraReports.Parameters.Parameter TDate;
    private DevExpress.XtraReports.Parameters.Parameter LanguageId;
    private DevExpress.XtraReports.Parameters.Parameter UserName;
    private PageFooterBand PageFooter;
    private DevExpress.XtraReports.Parameters.Parameter IncludeAgencyGroup;
    private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    private XRLabel EmptyLeyend;
    private PageHeaderBand PageHeader;
    private GroupHeaderBand GroupHeader1;
    private XRSubreport xrSubreport1;
    private DevExpress.XtraReports.Parameters.Parameter AllowViewCommissions;
    private XRSubreport xrSubreporHeaderCustom;
    private XRSubreport xrSubreportFooterCustom;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public CompanyProcessedBillsMstrReport()
    {
        InitializeComponent();
        //
        // TODO: Add constructor logic here
        //
    }
   
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
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter5 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter6 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter7 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter8 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyProcessedBillsMstrReport));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.EmptyLeyend = new DevExpress.XtraReports.UI.XRLabel();
            this.FDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.TDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.UserName = new DevExpress.XtraReports.Parameters.Parameter();
            this.FormName = new DevExpress.XtraReports.Parameters.Parameter();
            this.LanguageId = new DevExpress.XtraReports.Parameters.Parameter();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.AgencyName = new DevExpress.XtraReports.Parameters.Parameter();
            this.AgSenderCode = new DevExpress.XtraReports.Parameters.Parameter();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrSubreportFooterCustom = new DevExpress.XtraReports.UI.XRSubreport();
            this.IncludeAgencyGroup = new DevExpress.XtraReports.Parameters.Parameter();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrSubreporHeaderCustom = new DevExpress.XtraReports.UI.XRSubreport();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrSubreport1 = new DevExpress.XtraReports.UI.XRSubreport();
            this.AllowViewCommissions = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 12.5F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("AgencyCode", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // EmptyLeyend
            // 
            this.EmptyLeyend.CanGrow = false;
            this.EmptyLeyend.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif([ShowEmptyLeyend] = 1, \'\', [ConvertRowsInColumns_MultiLangLabels].[EmptyLeyen" +
                    "d])")});
            this.EmptyLeyend.Font = new System.Drawing.Font(ReportCommon.Font, 12.75F, System.Drawing.FontStyle.Bold);
            this.EmptyLeyend.ForeColor = System.Drawing.Color.Black;
            this.EmptyLeyend.LocationFloat = new DevExpress.Utils.PointFloat(0.999999F, 10.48611F);
            this.EmptyLeyend.Multiline = true;
            this.EmptyLeyend.Name = "EmptyLeyend";
            this.EmptyLeyend.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
            this.EmptyLeyend.SizeF = new System.Drawing.SizeF(849F, 44.43058F);
            this.EmptyLeyend.StylePriority.UseFont = false;
            this.EmptyLeyend.StylePriority.UseForeColor = false;
            this.EmptyLeyend.StylePriority.UsePadding = false;
            this.EmptyLeyend.StylePriority.UseTextAlignment = false;
            this.EmptyLeyend.Text = "Empty Leyend";
            this.EmptyLeyend.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // FDate
            // 
            this.FDate.Name = "FDate";
            this.FDate.Type = typeof(System.DateTime);
            this.FDate.ValueInfo = "2021-12-01";
            // 
            // TDate
            // 
            this.TDate.Name = "TDate";
            this.TDate.Type = typeof(System.DateTime);
            this.TDate.ValueInfo = "2022-01-24";
            // 
            // UserName
            // 
            this.UserName.Name = "UserName";
            // 
            // FormName
            // 
            this.FormName.Name = "FormName";
            this.FormName.ValueInfo = "REPORT.IMXDIRECT.BILLPAYMENT";
            // 
            // LanguageId
            // 
            this.LanguageId.Name = "LanguageId";
            this.LanguageId.Type = typeof(short);
            this.LanguageId.ValueInfo = "1";
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 5.208333F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 3.125F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // AgencyName
            // 
            this.AgencyName.Name = "AgencyName";
            this.AgencyName.ValueInfo = "Agency TEST";
            // 
            // AgSenderCode
            // 
            this.AgSenderCode.Name = "AgSenderCode";
            this.AgSenderCode.ValueInfo = "FL1000";
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreportFooterCustom});
            this.PageFooter.HeightF = 40.625F;
            this.PageFooter.Name = "PageFooter";
            // 
            // xrSubreportFooterCustom
            // 
            this.xrSubreportFooterCustom.LocationFloat = new DevExpress.Utils.PointFloat(0F, 3.000005F);
            this.xrSubreportFooterCustom.Name = "xrSubreportFooterCustom";
            this.xrSubreportFooterCustom.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LanguageId", this.LanguageId));
            this.xrSubreportFooterCustom.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgSenderCode", this.AgSenderCode));
            this.xrSubreportFooterCustom.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FormName", this.FormName));
            this.xrSubreportFooterCustom.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("ReportTitle", null, "ConvertRowsInColumns_MultiLangLabels.BillPaymentTitle"));
            this.xrSubreportFooterCustom.ReportSource = new WebAPIReports.Reports.Common.CustomHeader.CompanyAgencyReportFooter();
            this.xrSubreportFooterCustom.SizeF = new System.Drawing.SizeF(829.9999F, 23F);
            // 
            // IncludeAgencyGroup
            // 
            this.IncludeAgencyGroup.Name = "IncludeAgencyGroup";
            this.IncludeAgencyGroup.Type = typeof(short);
            this.IncludeAgencyGroup.ValueInfo = "1";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = ReportCommon.WireTransacDB;
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "ProcessedBills_Master";
            queryParameter1.Name = "@AgencyCode";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.AgSenderCode]", typeof(string));
            queryParameter2.Name = "@IncludeAgencyGroup";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.IncludeAgencyGroup]", typeof(bool));
            queryParameter3.Name = "@FDate";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("[Parameters.FDate]", typeof(System.DateTime));
            queryParameter4.Name = "@TDate";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("[Parameters.TDate]", typeof(System.DateTime));
            queryParameter5.Name = "@CreatedBy";
            queryParameter5.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter5.Value = new DevExpress.DataAccess.Expression("[Parameters.UserName]", typeof(string));
            queryParameter6.Name = "@IncludeVoid";
            queryParameter6.Type = typeof(bool);
            queryParameter6.ValueInfo = "True";
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.Parameters.Add(queryParameter2);
            storedProcQuery1.Parameters.Add(queryParameter3);
            storedProcQuery1.Parameters.Add(queryParameter4);
            storedProcQuery1.Parameters.Add(queryParameter5);
            storedProcQuery1.Parameters.Add(queryParameter6);
            storedProcQuery1.StoredProcName = "ProcessedBills_Master";
            storedProcQuery2.Name = "ConvertRowsInColumns_MultiLangLabels";
            queryParameter7.Name = "@LanguageId";
            queryParameter7.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter7.Value = new DevExpress.DataAccess.Expression("[Parameters.LanguageId]", typeof(int));
            queryParameter8.Name = "@FormName";
            queryParameter8.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter8.Value = new DevExpress.DataAccess.Expression("[Parameters.FormName]", typeof(string));
            storedProcQuery2.Parameters.Add(queryParameter7);
            storedProcQuery2.Parameters.Add(queryParameter8);
            storedProcQuery2.StoredProcName = "ConvertRowsInColumns_MultiLangLabels";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1,
            storedProcQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            this.sqlDataSource1.ConfigureDataConnection += new DevExpress.DataAccess.Sql.ConfigureDataConnectionEventHandler(this.sqlDataSource1_ConfigureDataConnection);
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreporHeaderCustom});
            this.PageHeader.HeightF = 32.29167F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrSubreporHeaderCustom
            // 
            this.xrSubreporHeaderCustom.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrSubreporHeaderCustom.Name = "xrSubreporHeaderCustom";
            this.xrSubreporHeaderCustom.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LanguageId", this.LanguageId));
            this.xrSubreporHeaderCustom.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgSenderCode", this.AgSenderCode));
            this.xrSubreporHeaderCustom.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FDate", this.FDate));
            this.xrSubreporHeaderCustom.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("TDate", this.TDate));
            this.xrSubreporHeaderCustom.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FormName", this.FormName));
            this.xrSubreporHeaderCustom.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("ReportTitle", null, "ConvertRowsInColumns_MultiLangLabels.BillPaymentTitle"));
            this.xrSubreporHeaderCustom.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgencyName", this.AgencyName));
            this.xrSubreporHeaderCustom.ReportSource = new WebAPIReports.Reports.Common.CustomHeader.CompanyAgencyReportHeader();
            this.xrSubreporHeaderCustom.SizeF = new System.Drawing.SizeF(830F, 23F);
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrSubreport1,
            this.EmptyLeyend});
            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("AgencyCode", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader1.HeightF = 64.48078F;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.RepeatEveryPage = true;
            // 
            // xrSubreport1
            // 
            this.xrSubreport1.LocationFloat = new DevExpress.Utils.PointFloat(0.999999F, 10.00001F);
            this.xrSubreport1.Name = "xrSubreport1";
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgSenderCode", null, "ProcessedBills_Master.AgencyCode"));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FDate", this.FDate));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("TDate", this.TDate));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("UserName", this.UserName));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FormName", this.FormName));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LanguageId", this.LanguageId));
            this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AllowViewCommissions", this.AllowViewCommissions));
            this.xrSubreport1.ReportSource = new ProcessedBillsReport();
            this.xrSubreport1.SizeF = new System.Drawing.SizeF(849F, 23F);
            // 
            // AllowViewCommissions
            // 
            this.AllowViewCommissions.Description = "Allow View Commissions";
            this.AllowViewCommissions.Name = "AllowViewCommissions";
            this.AllowViewCommissions.Type = typeof(bool);
            this.AllowViewCommissions.ValueInfo = "False";
            // 
            // CompanyProcessedBillsMstrReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageFooter,
            this.PageHeader,
            this.GroupHeader1});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "ProcessedBills_Master";
            this.DataSource = this.sqlDataSource1;
            this.Margins = new System.Drawing.Printing.Margins(0, 0, 5, 3);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.AgencyName,
            this.AgSenderCode,
            this.FormName,
            this.FDate,
            this.TDate,
            this.LanguageId,
            this.UserName,
            this.IncludeAgencyGroup,
            this.AllowViewCommissions});
            this.Version = "18.1";
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.ProcessedBillsMstrReport_DataSourceDemanded);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    private void ProcessedBillsMstrReport_DataSourceDemanded(object sender, EventArgs e)
    {
        try
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);
            (sender as CompanyProcessedBillsMstrReport).sqlDataSource1.ConnectionParameters = dataConnectionParametersBase;
        }
        catch (Exception ex)
        {
            log.ErrorFormat("ProcessedBillsMstrReport_DataSourceDemanded ERROR: {0}", ex.Message);

        }
    }

    private void sqlDataSource1_ConfigureDataConnection(object sender, DevExpress.DataAccess.Sql.ConfigureDataConnectionEventArgs e)
    {
        var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);

        if (e.ConnectionName == ReportCommon.WireTransacDB)
            e.ConnectionParameters = dataConnectionParametersBase;
    }
}
