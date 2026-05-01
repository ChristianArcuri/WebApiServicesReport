using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data.SqlClient;
using DevExpress.DataAccess.ConnectionParameters;
using WebAPIReports.Reports.AgencyOverview;
using WebAPIReports.Reports;
using log4net;
/// <summary>
/// Summary description for BillPymtEndOfDayReport
/// </summary>
public class BillPymtEndOfDayCompanyReport : DevExpress.XtraReports.UI.XtraReport
{
    private DetailBand Detail;
    private XRTable xrTable2;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell15;
    private XRTableCell xrTableCell19;
    private XRTableCell xrTableCell20;
    private XRTableCell xrTableCell21;
    private XRTableCell xrTableCell23;
    private XRTableCell xrTableCell24;
    private XRTableCell xrTableCell25;
    private TopMarginBand TopMargin;
    private BottomMarginBand BottomMargin;
    private GroupFooterBand GroupFooter1;
    private XRPanel xrPanel8;
    private XRLabel xrLabel92;
    private XRLabel xrLabel93;
    private XRLabel xrLabel94;
    private XRLabel xrLabel95;
    private XRLabel xrLabel96;
    private XRLabel xrLabel97;
    private XRPanel xrPanel9;
    private XRLabel xrLabel98;
    private XRLabel xrLabel99;
    private XRLabel xrLabel100;
    private XRLabel xrLabel101;
    private XRLabel xrLabel102;
    private XRLabel xrLabel103;
    private XRPanel xrPanel10;
    private XRLabel xrLabel104;
    private XRLabel xrLabel105;
    private XRLabel xrLabel106;
    private XRLabel xrLabel107;
    private XRLabel xrLabel108;
    private XRLabel xrLabel109;
    private GroupHeaderBand GroupHeader1;
    private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    private XRControlStyle Title;
    private XRControlStyle DetailCaption3;
    private XRControlStyle DetailData3;
    private XRControlStyle DetailData3_Odd;
    private XRControlStyle DetailCaptionBackground3;
    private XRControlStyle PageInfo;
    private DevExpress.XtraReports.Parameters.Parameter AgSenderCode;
    private DevExpress.XtraReports.Parameters.Parameter FDate;
    private DevExpress.XtraReports.Parameters.Parameter UserName;
    private DevExpress.XtraReports.Parameters.Parameter FormName;
    private DevExpress.XtraReports.Parameters.Parameter LanguageId;
    private XRTableCell xrTableCell17;
    private XRTableCell xrTableCell18;
    private XRTableCell xrTableCell16;
    private DevExpress.XtraReports.Parameters.Parameter AgencyName;
    private XRPanel xrPanel1;
    private XRLabel xrLabel111;
    private XRLabel xrLabel113;
    private XRLabel xrLabel110;
    private XRLabel xrLabel114;
    private XRLabel xrLabel115;
    private XRLabel xrLabel112;
    private XRLabel xrLabel116;
    private XRLabel xrLabel117;
    private XRLabel xrLabel118;
    private XRLabel xrLabel119;
    private DevExpress.XtraReports.Parameters.Parameter AllowViewCommissions;
    private ReportHeaderBand ReportHeader;
    private XRSubreport xrCompanyHeader;
    private DevExpress.XtraReports.Parameters.Parameter OnlyFromVisible;
    private XRLabel EmptyLeyend;
    private PageHeaderBand PageHeader;
    private PageFooterBand PageFooter;
    private XRSubreport xrCompanyFooter;

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    ILog log = LogManager.GetLogger(typeof(BillPymtEndOfDayCompanyReport));

    public BillPymtEndOfDayCompanyReport()
    {
        InitializeComponent();
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
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary4 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary5 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary6 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary7 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary8 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary9 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary10 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary11 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary12 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary13 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary14 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary15 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter5 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter6 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter7 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillPymtEndOfDayCompanyReport));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrPanel8 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel92 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel93 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel94 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel95 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel96 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel97 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPanel9 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel98 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel99 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel100 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel101 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel102 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel103 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPanel10 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel104 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel105 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel106 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel107 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel108 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel109 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel111 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel113 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel110 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel114 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel115 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel112 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel116 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel117 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel118 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel119 = new DevExpress.XtraReports.UI.XRLabel();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailCaption3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailCaptionBackground3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.AgSenderCode = new DevExpress.XtraReports.Parameters.Parameter();
            this.FDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.UserName = new DevExpress.XtraReports.Parameters.Parameter();
            this.FormName = new DevExpress.XtraReports.Parameters.Parameter();
            this.LanguageId = new DevExpress.XtraReports.Parameters.Parameter();
            this.AgencyName = new DevExpress.XtraReports.Parameters.Parameter();
            this.AllowViewCommissions = new DevExpress.XtraReports.Parameters.Parameter();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrCompanyHeader = new DevExpress.XtraReports.UI.XRSubreport();
            this.OnlyFromVisible = new DevExpress.XtraReports.Parameters.Parameter();
            this.EmptyLeyend = new DevExpress.XtraReports.UI.XRLabel();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrCompanyFooter = new DevExpress.XtraReports.UI.XRSubreport();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.Detail.HeightF = 25F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable2
            // 
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(7.947286E-06F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.OddStyleName = "DetailData3_Odd";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(830.0001F, 25F);
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell15,
            this.xrTableCell16,
            this.xrTableCell17,
            this.xrTableCell18,
            this.xrTableCell19,
            this.xrTableCell20,
            this.xrTableCell21,
            this.xrTableCell23,
            this.xrTableCell24,
            this.xrTableCell25});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 11.5D;
            // 
            // xrTableCell15
            // 
            this.xrTableCell15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BTAgSenderSeq]")});
            this.xrTableCell15.Name = "xrTableCell15";
            this.xrTableCell15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell15.StyleName = "DetailData3";
            this.xrTableCell15.Text = "xrTableCell15";
            this.xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell15.Weight = 0.094166591392331037D;
            // 
            // xrTableCell16
            // 
            this.xrTableCell16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SndFullName]")});
            this.xrTableCell16.Name = "xrTableCell16";
            this.xrTableCell16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell16.StyleName = "DetailData3";
            this.xrTableCell16.Text = "xrTableCell16";
            this.xrTableCell16.Weight = 0.34514195255881142D;
            // 
            // xrTableCell17
            // 
            this.xrTableCell17.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BTBillerName]")});
            this.xrTableCell17.Multiline = true;
            this.xrTableCell17.Name = "xrTableCell17";
            this.xrTableCell17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell17.StyleName = "DetailData3";
            this.xrTableCell17.StylePriority.UsePadding = false;
            this.xrTableCell17.Text = "xrTableCell17";
            this.xrTableCell17.Weight = 0.21794882756751444D;
            // 
            // xrTableCell18
            // 
            this.xrTableCell18.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BTOriAmount]")});
            this.xrTableCell18.Name = "xrTableCell18";
            this.xrTableCell18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell18.StyleName = "DetailData3";
            this.xrTableCell18.StylePriority.UseTextAlignment = false;
            this.xrTableCell18.Text = "xrTableCell18";
            this.xrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell18.TextFormatString = "{0:$0.00}";
            this.xrTableCell18.Weight = 0.092307607614739315D;
            // 
            // xrTableCell19
            // 
            this.xrTableCell19.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BTCharges]")});
            this.xrTableCell19.Multiline = true;
            this.xrTableCell19.Name = "xrTableCell19";
            this.xrTableCell19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell19.StyleName = "DetailData3";
            this.xrTableCell19.StylePriority.UseTextAlignment = false;
            this.xrTableCell19.Text = "xrTableCell19";
            this.xrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell19.TextFormatString = "{0:$0.00}";
            this.xrTableCell19.Weight = 0.076923111200163832D;
            // 
            // xrTableCell20
            // 
            this.xrTableCell20.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif([Parameters].[AllowViewCommissions] = true,[BTAgSenderCommission], \'\')")});
            this.xrTableCell20.Multiline = true;
            this.xrTableCell20.Name = "xrTableCell20";
            this.xrTableCell20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell20.StyleName = "DetailData3";
            this.xrTableCell20.StylePriority.UseTextAlignment = false;
            this.xrTableCell20.Text = "xrTableCell20";
            this.xrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell20.TextFormatString = "{0:$0.00}";
            this.xrTableCell20.Weight = 0.076923071819982619D;
            // 
            // xrTableCell21
            // 
            this.xrTableCell21.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "iif(IsNull([BTCreatedBy])\n   ,[PayMethodAbbr]\n   ,IsNull([PayMethodAbbr],\'CASH\')\n" +
                    ")")});
            this.xrTableCell21.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.xrTableCell21.Name = "xrTableCell21";
            this.xrTableCell21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell21.StyleName = "DetailData3";
            this.xrTableCell21.StylePriority.UseTextAlignment = false;
            this.xrTableCell21.Text = "xrTableCell21";
            this.xrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell21.Weight = 0.10256384073013203D;
            // 
            // xrTableCell23
            // 
            this.xrTableCell23.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BTOriAmount]+[BTCharges]")});
            this.xrTableCell23.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.xrTableCell23.Multiline = true;
            this.xrTableCell23.Name = "xrTableCell23";
            this.xrTableCell23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell23.StyleName = "DetailData3";
            this.xrTableCell23.StylePriority.UseTextAlignment = false;
            this.xrTableCell23.Text = "xrTableCell23";
            this.xrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell23.TextFormatString = "{0:$0.00}";
            this.xrTableCell23.Weight = 0.097716526738331033D;
            // 
            // xrTableCell24
            // 
            this.xrTableCell24.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif([BTStsCancel] == 2 ,\'X\' ,\'\' )")});
            this.xrTableCell24.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.xrTableCell24.Name = "xrTableCell24";
            this.xrTableCell24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell24.StyleName = "DetailData3";
            this.xrTableCell24.StylePriority.UseTextAlignment = false;
            this.xrTableCell24.Text = "xrTableCell24";
            this.xrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell24.Weight = 0.061258069827640704D;
            // 
            // xrTableCell25
            // 
            this.xrTableCell25.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BTCreatedBy]")});
            this.xrTableCell25.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.xrTableCell25.Name = "xrTableCell25";
            this.xrTableCell25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCell25.StyleName = "DetailData3";
            this.xrTableCell25.Text = "xrTableCell25";
            this.xrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell25.Weight = 0.11658892279098498D;
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
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel8,
            this.xrPanel9,
            this.xrPanel10});
            this.GroupFooter1.Name = "GroupFooter1";
            // 
            // xrPanel8
            // 
            this.xrPanel8.BackColor = System.Drawing.Color.Transparent;
            this.xrPanel8.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrPanel8.BorderWidth = 1F;
            this.xrPanel8.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel92,
            this.xrLabel93,
            this.xrLabel94,
            this.xrLabel95,
            this.xrLabel96,
            this.xrLabel97});
            this.xrPanel8.LocationFloat = new DevExpress.Utils.PointFloat(7.947286E-06F, 0F);
            this.xrPanel8.Name = "xrPanel8";
            this.xrPanel8.SizeF = new System.Drawing.SizeF(830.0001F, 30.62499F);
            this.xrPanel8.StylePriority.UseBackColor = false;
            this.xrPanel8.StylePriority.UseBorders = false;
            this.xrPanel8.StylePriority.UseBorderWidth = false;
            // 
            // xrLabel92
            // 
            this.xrLabel92.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel92.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([BTCharges])")});
            this.xrLabel92.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel92.LocationFloat = new DevExpress.Utils.PointFloat(487.2173F, 5.541674F);
            this.xrLabel92.Name = "xrLabel92";
            this.xrLabel92.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F);
            this.xrLabel92.SizeF = new System.Drawing.SizeF(49.99997F, 23F);
            this.xrLabel92.StylePriority.UseBorders = false;
            this.xrLabel92.StylePriority.UseFont = false;
            this.xrLabel92.StylePriority.UsePadding = false;
            this.xrLabel92.StylePriority.UseTextAlignment = false;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel92.Summary = xrSummary1;
            this.xrLabel92.Text = "xrLabel8";
            this.xrLabel92.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel92.TextFormatString = "{0:$#,##0.00}";
            // 
            // xrLabel93
            // 
            this.xrLabel93.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel93.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([BTOriAmount]+[BTCharges])")});
            this.xrLabel93.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel93.LocationFloat = new DevExpress.Utils.PointFloat(653.8837F, 5.541658F);
            this.xrLabel93.Name = "xrLabel93";
            this.xrLabel93.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F);
            this.xrLabel93.SizeF = new System.Drawing.SizeF(63.51581F, 23F);
            this.xrLabel93.StylePriority.UseBorders = false;
            this.xrLabel93.StylePriority.UseFont = false;
            this.xrLabel93.StylePriority.UsePadding = false;
            this.xrLabel93.StylePriority.UseTextAlignment = false;
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel93.Summary = xrSummary2;
            this.xrLabel93.Text = "xrLabel8";
            this.xrLabel93.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel93.TextFormatString = "{0:$#,##0.00}";
            // 
            // xrLabel94
            // 
            this.xrLabel94.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel94.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif([Parameters].[AllowViewCommissions] = true,sumSum([BTAgSenderCommission]), \'\'" +
                    ")")});
            this.xrLabel94.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel94.LocationFloat = new DevExpress.Utils.PointFloat(537.2173F, 5.541674F);
            this.xrLabel94.Name = "xrLabel94";
            this.xrLabel94.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F);
            this.xrLabel94.SizeF = new System.Drawing.SizeF(50F, 23F);
            this.xrLabel94.StylePriority.UseBorders = false;
            this.xrLabel94.StylePriority.UseFont = false;
            this.xrLabel94.StylePriority.UsePadding = false;
            this.xrLabel94.StylePriority.UseTextAlignment = false;
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel94.Summary = xrSummary3;
            this.xrLabel94.Text = "xrLabel8";
            this.xrLabel94.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel94.TextFormatString = "{0:$#,##0.00}";
            // 
            // xrLabel95
            // 
            this.xrLabel95.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel95.CanGrow = false;
            this.xrLabel95.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([BTOriAmount])")});
            this.xrLabel95.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel95.LocationFloat = new DevExpress.Utils.PointFloat(427.2173F, 5.541674F);
            this.xrLabel95.Name = "xrLabel95";
            this.xrLabel95.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F);
            this.xrLabel95.SizeF = new System.Drawing.SizeF(59.99994F, 23F);
            this.xrLabel95.StylePriority.UseBorders = false;
            this.xrLabel95.StylePriority.UseFont = false;
            this.xrLabel95.StylePriority.UsePadding = false;
            this.xrLabel95.StylePriority.UseTextAlignment = false;
            xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel95.Summary = xrSummary4;
            this.xrLabel95.Text = "xrLabel8";
            this.xrLabel95.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel95.TextFormatString = "{0:$#,##0.00}";
            this.xrLabel95.WordWrap = false;
            // 
            // xrLabel96
            // 
            this.xrLabel96.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel96.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumCount([BTAgSenderSeq])")});
            this.xrLabel96.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel96.LocationFloat = new DevExpress.Utils.PointFloat(123.5763F, 5.54166F);
            this.xrLabel96.Name = "xrLabel96";
            this.xrLabel96.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel96.SizeF = new System.Drawing.SizeF(55.68282F, 23F);
            this.xrLabel96.StylePriority.UseBorders = false;
            this.xrLabel96.StylePriority.UseFont = false;
            this.xrLabel96.StylePriority.UseTextAlignment = false;
            xrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel96.Summary = xrSummary5;
            this.xrLabel96.Text = "xrLabel6";
            this.xrLabel96.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrLabel96.TextFormatString = "{0}";
            // 
            // xrLabel97
            // 
            this.xrLabel97.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel97.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "concat([ConvertRowsInColumns_MultiLangLabels].[TotalBillPaymentTrml],\':\')")});
            this.xrLabel97.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel97.LocationFloat = new DevExpress.Utils.PointFloat(0F, 5.54166F);
            this.xrLabel97.Name = "xrLabel97";
            this.xrLabel97.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel97.SizeF = new System.Drawing.SizeF(123.5763F, 23F);
            this.xrLabel97.StylePriority.UseBorders = false;
            this.xrLabel97.StylePriority.UseFont = false;
            this.xrLabel97.StylePriority.UseTextAlignment = false;
            this.xrLabel97.Text = "Bill Payment:";
            this.xrLabel97.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrPanel9
            // 
            this.xrPanel9.BackColor = System.Drawing.Color.Transparent;
            this.xrPanel9.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.xrPanel9.BorderWidth = 1F;
            this.xrPanel9.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel98,
            this.xrLabel99,
            this.xrLabel100,
            this.xrLabel101,
            this.xrLabel102,
            this.xrLabel103});
            this.xrPanel9.LocationFloat = new DevExpress.Utils.PointFloat(7.947286E-06F, 30.62499F);
            this.xrPanel9.Name = "xrPanel9";
            this.xrPanel9.SizeF = new System.Drawing.SizeF(829.9999F, 30.62499F);
            this.xrPanel9.StylePriority.UseBackColor = false;
            this.xrPanel9.StylePriority.UseBorders = false;
            this.xrPanel9.StylePriority.UseBorderWidth = false;
            // 
            // xrLabel98
            // 
            this.xrLabel98.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel98.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum(Iif([BTStsCancel] = 2,  [BTCharges],0))")});
            this.xrLabel98.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel98.LocationFloat = new DevExpress.Utils.PointFloat(488.2174F, 5.541647F);
            this.xrLabel98.Name = "xrLabel98";
            this.xrLabel98.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F);
            this.xrLabel98.SizeF = new System.Drawing.SizeF(50.00003F, 23F);
            this.xrLabel98.StylePriority.UseBorders = false;
            this.xrLabel98.StylePriority.UseFont = false;
            this.xrLabel98.StylePriority.UsePadding = false;
            this.xrLabel98.StylePriority.UseTextAlignment = false;
            xrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel98.Summary = xrSummary6;
            this.xrLabel98.Text = "xrLabel8";
            this.xrLabel98.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel98.TextFormatString = "{0:$#,##0.00}";
            // 
            // xrLabel99
            // 
            this.xrLabel99.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel99.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum(Iif([BTStsCancel] = 2, [BTOriAmount]+[BTCharges]\n ,0))")});
            this.xrLabel99.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel99.LocationFloat = new DevExpress.Utils.PointFloat(654.8839F, 5.541628F);
            this.xrLabel99.Name = "xrLabel99";
            this.xrLabel99.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F);
            this.xrLabel99.SizeF = new System.Drawing.SizeF(63.51581F, 23F);
            this.xrLabel99.StylePriority.UseBorders = false;
            this.xrLabel99.StylePriority.UseFont = false;
            this.xrLabel99.StylePriority.UsePadding = false;
            this.xrLabel99.StylePriority.UseTextAlignment = false;
            xrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel99.Summary = xrSummary7;
            this.xrLabel99.Text = "xrLabel8";
            this.xrLabel99.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel99.TextFormatString = "{0:$#,##0.00}";
            // 
            // xrLabel100
            // 
            this.xrLabel100.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel100.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif([Parameters].[AllowViewCommissions] = true,sumSum(Iif([BTStsCancel] = 2,  [BT" +
                    "AgSenderCommission],0)), \'\')")});
            this.xrLabel100.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel100.LocationFloat = new DevExpress.Utils.PointFloat(538.2173F, 5.541647F);
            this.xrLabel100.Name = "xrLabel100";
            this.xrLabel100.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F);
            this.xrLabel100.SizeF = new System.Drawing.SizeF(50.00006F, 23F);
            this.xrLabel100.StylePriority.UseBorders = false;
            this.xrLabel100.StylePriority.UseFont = false;
            this.xrLabel100.StylePriority.UsePadding = false;
            this.xrLabel100.StylePriority.UseTextAlignment = false;
            xrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel100.Summary = xrSummary8;
            this.xrLabel100.Text = "xrLabel8";
            this.xrLabel100.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel100.TextFormatString = "{0:$#,##0.00}";
            // 
            // xrLabel101
            // 
            this.xrLabel101.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel101.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum(Iif([BTStsCancel] = 2,  [BTOriAmount],0))")});
            this.xrLabel101.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel101.LocationFloat = new DevExpress.Utils.PointFloat(428.2175F, 5.541647F);
            this.xrLabel101.Name = "xrLabel101";
            this.xrLabel101.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F);
            this.xrLabel101.SizeF = new System.Drawing.SizeF(59.99991F, 23F);
            this.xrLabel101.StylePriority.UseBorders = false;
            this.xrLabel101.StylePriority.UseFont = false;
            this.xrLabel101.StylePriority.UsePadding = false;
            this.xrLabel101.StylePriority.UseTextAlignment = false;
            xrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel101.Summary = xrSummary9;
            this.xrLabel101.Text = "xrLabel8";
            this.xrLabel101.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel101.TextFormatString = "{0:$#,##0.00}";
            // 
            // xrLabel102
            // 
            this.xrLabel102.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel102.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum(Iif([BTStsCancel] = 2, 1, 0))")});
            this.xrLabel102.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel102.LocationFloat = new DevExpress.Utils.PointFloat(123.5764F, 5.541674F);
            this.xrLabel102.Name = "xrLabel102";
            this.xrLabel102.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel102.SizeF = new System.Drawing.SizeF(55.68288F, 23F);
            this.xrLabel102.StylePriority.UseBorders = false;
            this.xrLabel102.StylePriority.UseFont = false;
            this.xrLabel102.StylePriority.UseTextAlignment = false;
            xrSummary10.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel102.Summary = xrSummary10;
            this.xrLabel102.Text = "xrLabel6";
            this.xrLabel102.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrLabel102.TextFormatString = "{0}";
            // 
            // xrLabel103
            // 
            this.xrLabel103.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel103.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "concat([ConvertRowsInColumns_MultiLangLabels].[Void],\':\')")});
            this.xrLabel103.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel103.LocationFloat = new DevExpress.Utils.PointFloat(1.00011F, 5.541674F);
            this.xrLabel103.Name = "xrLabel103";
            this.xrLabel103.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel103.SizeF = new System.Drawing.SizeF(122.5763F, 23F);
            this.xrLabel103.StylePriority.UseBorders = false;
            this.xrLabel103.StylePriority.UseFont = false;
            this.xrLabel103.StylePriority.UseTextAlignment = false;
            this.xrLabel103.Text = "Void:";
            this.xrLabel103.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrPanel10
            // 
            this.xrPanel10.BackColor = System.Drawing.Color.Transparent;
            this.xrPanel10.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Double;
            this.xrPanel10.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPanel10.BorderWidth = 2F;
            this.xrPanel10.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel104,
            this.xrLabel105,
            this.xrLabel106,
            this.xrLabel107,
            this.xrLabel108,
            this.xrLabel109});
            this.xrPanel10.LocationFloat = new DevExpress.Utils.PointFloat(1.000118F, 61.24999F);
            this.xrPanel10.Name = "xrPanel10";
            this.xrPanel10.SizeF = new System.Drawing.SizeF(828.9999F, 30.625F);
            this.xrPanel10.StylePriority.UseBackColor = false;
            this.xrPanel10.StylePriority.UseBorderDashStyle = false;
            this.xrPanel10.StylePriority.UseBorders = false;
            this.xrPanel10.StylePriority.UseBorderWidth = false;
            // 
            // xrLabel104
            // 
            this.xrLabel104.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel104.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum(Iif([BTStsCancel] = 2, 0, [BTCharges]))")});
            this.xrLabel104.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel104.LocationFloat = new DevExpress.Utils.PointFloat(488.2173F, 5.541683F);
            this.xrLabel104.Name = "xrLabel104";
            this.xrLabel104.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F);
            this.xrLabel104.SizeF = new System.Drawing.SizeF(49.99997F, 23F);
            this.xrLabel104.StylePriority.UseBorders = false;
            this.xrLabel104.StylePriority.UseFont = false;
            this.xrLabel104.StylePriority.UsePadding = false;
            this.xrLabel104.StylePriority.UseTextAlignment = false;
            xrSummary11.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel104.Summary = xrSummary11;
            this.xrLabel104.Text = "xrLabel8";
            this.xrLabel104.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel104.TextFormatString = "{0:$#,##0.00}";
            // 
            // xrLabel105
            // 
            this.xrLabel105.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel105.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum(Iif([BTStsCancel] = 2,0,[BTOriAmount]+[BTCharges]\n))")});
            this.xrLabel105.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel105.LocationFloat = new DevExpress.Utils.PointFloat(654.8839F, 5.541668F);
            this.xrLabel105.Name = "xrLabel105";
            this.xrLabel105.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F);
            this.xrLabel105.SizeF = new System.Drawing.SizeF(63.51581F, 23F);
            this.xrLabel105.StylePriority.UseBorders = false;
            this.xrLabel105.StylePriority.UseFont = false;
            this.xrLabel105.StylePriority.UsePadding = false;
            this.xrLabel105.StylePriority.UseTextAlignment = false;
            xrSummary12.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel105.Summary = xrSummary12;
            this.xrLabel105.Text = "xrLabel8";
            this.xrLabel105.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel105.TextFormatString = "{0:$#,##0.00}";
            // 
            // xrLabel106
            // 
            this.xrLabel106.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel106.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif([Parameters].[AllowViewCommissions] = true,sumSum(Iif([BTStsCancel] = 2, 0, [" +
                    "BTAgSenderCommission])),\'\')")});
            this.xrLabel106.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel106.LocationFloat = new DevExpress.Utils.PointFloat(538.2174F, 5.541683F);
            this.xrLabel106.Name = "xrLabel106";
            this.xrLabel106.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F);
            this.xrLabel106.SizeF = new System.Drawing.SizeF(49.99994F, 23F);
            this.xrLabel106.StylePriority.UseBorders = false;
            this.xrLabel106.StylePriority.UseFont = false;
            this.xrLabel106.StylePriority.UsePadding = false;
            this.xrLabel106.StylePriority.UseTextAlignment = false;
            xrSummary13.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel106.Summary = xrSummary13;
            this.xrLabel106.Text = "xrLabel8";
            this.xrLabel106.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel106.TextFormatString = "{0:$#,##0.00}";
            // 
            // xrLabel107
            // 
            this.xrLabel107.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel107.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum(Iif([BTStsCancel] = 2, 0, [BTOriAmount]))")});
            this.xrLabel107.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel107.LocationFloat = new DevExpress.Utils.PointFloat(428.2174F, 5.750027F);
            this.xrLabel107.Name = "xrLabel107";
            this.xrLabel107.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F);
            this.xrLabel107.SizeF = new System.Drawing.SizeF(59.99997F, 23F);
            this.xrLabel107.StylePriority.UseBorders = false;
            this.xrLabel107.StylePriority.UseFont = false;
            this.xrLabel107.StylePriority.UsePadding = false;
            this.xrLabel107.StylePriority.UseTextAlignment = false;
            xrSummary14.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel107.Summary = xrSummary14;
            this.xrLabel107.Text = "xrLabel8";
            this.xrLabel107.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel107.TextFormatString = "{0:$#,##0.00}";
            // 
            // xrLabel108
            // 
            this.xrLabel108.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel108.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum(Iif([BTStsCancel] = 2, 0, 1))")});
            this.xrLabel108.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel108.LocationFloat = new DevExpress.Utils.PointFloat(123.5763F, 5.541674F);
            this.xrLabel108.Name = "xrLabel108";
            this.xrLabel108.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel108.SizeF = new System.Drawing.SizeF(55.68288F, 23F);
            this.xrLabel108.StylePriority.UseBorders = false;
            this.xrLabel108.StylePriority.UseFont = false;
            this.xrLabel108.StylePriority.UseTextAlignment = false;
            xrSummary15.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel108.Summary = xrSummary15;
            this.xrLabel108.Text = "xrLabel6";
            this.xrLabel108.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrLabel108.TextFormatString = "{0}";
            // 
            // xrLabel109
            // 
            this.xrLabel109.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel109.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "concat([ConvertRowsInColumns_MultiLangLabels].[GrandTotal],\':\')")});
            this.xrLabel109.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel109.LocationFloat = new DevExpress.Utils.PointFloat(1.000101F, 5.54166F);
            this.xrLabel109.Name = "xrLabel109";
            this.xrLabel109.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel109.SizeF = new System.Drawing.SizeF(122.5762F, 23F);
            this.xrLabel109.StylePriority.UseBorders = false;
            this.xrLabel109.StylePriority.UseFont = false;
            this.xrLabel109.StylePriority.UseTextAlignment = false;
            this.xrLabel109.Text = "Grand Total:";
            this.xrLabel109.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel1});
            this.GroupHeader1.HeightF = 46.88169F;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.RepeatEveryPage = true;
            // 
            // xrPanel1
            // 
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel111,
            this.xrLabel113,
            this.xrLabel110,
            this.xrLabel114,
            this.xrLabel115,
            this.xrLabel112,
            this.xrLabel116,
            this.xrLabel117,
            this.xrLabel118,
            this.xrLabel119});
            this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.SizeF = new System.Drawing.SizeF(830.0001F, 46.88168F);
            // 
            // xrLabel111
            // 
            this.xrLabel111.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel111.BorderWidth = 2F;
            this.xrLabel111.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ConvertRowsInColumns_MultiLangLabels].[CreatedBy]")});
            this.xrLabel111.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel111.LocationFloat = new DevExpress.Utils.PointFloat(758.2173F, 0F);
            this.xrLabel111.Name = "xrLabel111";
            this.xrLabel111.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel111.SizeF = new System.Drawing.SizeF(75.78284F, 41.66666F);
            this.xrLabel111.StylePriority.UseBorders = false;
            this.xrLabel111.StylePriority.UseBorderWidth = false;
            this.xrLabel111.StylePriority.UseFont = false;
            this.xrLabel111.StylePriority.UseTextAlignment = false;
            this.xrLabel111.Text = "Operador";
            this.xrLabel111.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel113
            // 
            this.xrLabel113.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel113.BorderWidth = 2F;
            this.xrLabel113.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ConvertRowsInColumns_MultiLangLabels].[Void]")});
            this.xrLabel113.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel113.LocationFloat = new DevExpress.Utils.PointFloat(718.3997F, 0.003343821F);
            this.xrLabel113.Multiline = true;
            this.xrLabel113.Name = "xrLabel113";
            this.xrLabel113.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.xrLabel113.SizeF = new System.Drawing.SizeF(39.81775F, 41.66999F);
            this.xrLabel113.StylePriority.UseBorders = false;
            this.xrLabel113.StylePriority.UseBorderWidth = false;
            this.xrLabel113.StylePriority.UseFont = false;
            this.xrLabel113.StylePriority.UsePadding = false;
            this.xrLabel113.StylePriority.UseTextAlignment = false;
            this.xrLabel113.Text = "Void";
            this.xrLabel113.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel110
            // 
            this.xrLabel110.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel110.BorderWidth = 2F;
            this.xrLabel110.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ConvertRowsInColumns_MultiLangLabels].[DepositAmount]")});
            this.xrLabel110.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel110.LocationFloat = new DevExpress.Utils.PointFloat(654.884F, 0F);
            this.xrLabel110.Name = "xrLabel110";
            this.xrLabel110.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F);
            this.xrLabel110.SizeF = new System.Drawing.SizeF(63.51569F, 41.67F);
            this.xrLabel110.StylePriority.UseBorders = false;
            this.xrLabel110.StylePriority.UseBorderWidth = false;
            this.xrLabel110.StylePriority.UseFont = false;
            this.xrLabel110.StylePriority.UsePadding = false;
            this.xrLabel110.StylePriority.UseTextAlignment = false;
            this.xrLabel110.Text = "DepositAmount";
            this.xrLabel110.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel114
            // 
            this.xrLabel114.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel114.BorderWidth = 2F;
            this.xrLabel114.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ConvertRowsInColumns_MultiLangLabels].[PaymentMethod]")});
            this.xrLabel114.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel114.LocationFloat = new DevExpress.Utils.PointFloat(588.2173F, 0.00333786F);
            this.xrLabel114.Name = "xrLabel114";
            this.xrLabel114.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
            this.xrLabel114.SizeF = new System.Drawing.SizeF(66.6665F, 41.66666F);
            this.xrLabel114.StylePriority.UseBorders = false;
            this.xrLabel114.StylePriority.UseBorderWidth = false;
            this.xrLabel114.StylePriority.UseFont = false;
            this.xrLabel114.StylePriority.UsePadding = false;
            this.xrLabel114.StylePriority.UseTextAlignment = false;
            this.xrLabel114.Text = "DepositAmount";
            this.xrLabel114.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel115
            // 
            this.xrLabel115.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel115.BorderWidth = 2F;
            this.xrLabel115.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif([Parameters].[AllowViewCommissions] = true,[ConvertRowsInColumns_MultiLangLab" +
                    "els].[CommAg], \'\')")});
            this.xrLabel115.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel115.LocationFloat = new DevExpress.Utils.PointFloat(538.2173F, 0.00333786F);
            this.xrLabel115.Name = "xrLabel115";
            this.xrLabel115.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
            this.xrLabel115.SizeF = new System.Drawing.SizeF(50F, 41.67F);
            this.xrLabel115.StylePriority.UseBorders = false;
            this.xrLabel115.StylePriority.UseBorderWidth = false;
            this.xrLabel115.StylePriority.UseFont = false;
            this.xrLabel115.StylePriority.UsePadding = false;
            this.xrLabel115.StylePriority.UseTextAlignment = false;
            this.xrLabel115.Text = "CommAg";
            this.xrLabel115.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel112
            // 
            this.xrLabel112.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel112.BorderWidth = 2F;
            this.xrLabel112.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ConvertRowsInColumns_MultiLangLabels].[Fee]")});
            this.xrLabel112.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel112.LocationFloat = new DevExpress.Utils.PointFloat(488.2173F, 0F);
            this.xrLabel112.Name = "xrLabel112";
            this.xrLabel112.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 6, 0, 0, 100F);
            this.xrLabel112.SizeF = new System.Drawing.SizeF(57F, 41.67F);
            this.xrLabel112.StylePriority.UseBorders = false;
            this.xrLabel112.StylePriority.UseBorderWidth = false;
            this.xrLabel112.StylePriority.UseFont = false;
            this.xrLabel112.StylePriority.UsePadding = false;
            this.xrLabel112.StylePriority.UseTextAlignment = false;
            this.xrLabel112.Text = "Fee";
            this.xrLabel112.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel116
            // 
            this.xrLabel116.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel116.BorderWidth = 2F;
            this.xrLabel116.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ConvertRowsInColumns_MultiLangLabels].[Amount    ]")});
            this.xrLabel116.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel116.LocationFloat = new DevExpress.Utils.PointFloat(428.2173F, 0F);
            this.xrLabel116.Name = "xrLabel116";
            this.xrLabel116.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 6, 0, 0, 100F);
            this.xrLabel116.SizeF = new System.Drawing.SizeF(60F, 41.67F);
            this.xrLabel116.StylePriority.UseBorders = false;
            this.xrLabel116.StylePriority.UseBorderWidth = false;
            this.xrLabel116.StylePriority.UseFont = false;
            this.xrLabel116.StylePriority.UsePadding = false;
            this.xrLabel116.StylePriority.UseTextAlignment = false;
            this.xrLabel116.Text = "Amount    ";
            this.xrLabel116.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel117
            // 
            this.xrLabel117.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel117.BorderWidth = 2F;
            this.xrLabel117.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ConvertRowsInColumns_MultiLangLabels].[BillerName]")});
            this.xrLabel117.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel117.LocationFloat = new DevExpress.Utils.PointFloat(286.5506F, 0F);
            this.xrLabel117.Name = "xrLabel117";
            this.xrLabel117.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel117.SizeF = new System.Drawing.SizeF(141.6667F, 41.67F);
            this.xrLabel117.StylePriority.UseBorders = false;
            this.xrLabel117.StylePriority.UseBorderWidth = false;
            this.xrLabel117.StylePriority.UseFont = false;
            this.xrLabel117.StylePriority.UseTextAlignment = false;
            this.xrLabel117.Text = "BillerName";
            this.xrLabel117.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel118
            // 
            this.xrLabel118.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel118.BorderWidth = 2F;
            this.xrLabel118.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ConvertRowsInColumns_MultiLangLabels].[ChkCustomer]")});
            this.xrLabel118.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel118.LocationFloat = new DevExpress.Utils.PointFloat(62.20839F, 0.00333786F);
            this.xrLabel118.Name = "xrLabel118";
            this.xrLabel118.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
            this.xrLabel118.SizeF = new System.Drawing.SizeF(224.3423F, 41.66666F);
            this.xrLabel118.StylePriority.UseBorders = false;
            this.xrLabel118.StylePriority.UseBorderWidth = false;
            this.xrLabel118.StylePriority.UseFont = false;
            this.xrLabel118.StylePriority.UsePadding = false;
            this.xrLabel118.StylePriority.UseTextAlignment = false;
            this.xrLabel118.Text = "ChkCustomer";
            this.xrLabel118.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel119
            // 
            this.xrLabel119.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrLabel119.BorderWidth = 2F;
            this.xrLabel119.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ConvertRowsInColumns_MultiLangLabels].[Payment]")});
            this.xrLabel119.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel119.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel119.Name = "xrLabel119";
            this.xrLabel119.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel119.SizeF = new System.Drawing.SizeF(62.20839F, 41.66666F);
            this.xrLabel119.StylePriority.UseBorders = false;
            this.xrLabel119.StylePriority.UseBorderWidth = false;
            this.xrLabel119.StylePriority.UseFont = false;
            this.xrLabel119.StylePriority.UseTextAlignment = false;
            this.xrLabel119.Text = "Payment #";
            this.xrLabel119.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "WireTransacConn";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "BT_Sales_Report";
            queryParameter1.Name = "@AgencyCode";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.AgSenderCode]", typeof(string));
            queryParameter2.Name = "@DateFrom";
            queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.FDate]", typeof(System.DateTime));
            queryParameter3.Name = "@DateTo";
            queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter3.Value = new DevExpress.DataAccess.Expression("[Parameters.FDate]", typeof(System.DateTime));
            queryParameter4.Name = "@Username";
            queryParameter4.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter4.Value = new DevExpress.DataAccess.Expression("[Parameters.UserName]", typeof(string));
            queryParameter5.Name = "@IncludeAgencyGroup";
            queryParameter5.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter5.Value = new DevExpress.DataAccess.Expression("false", typeof(bool));
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.Parameters.Add(queryParameter2);
            storedProcQuery1.Parameters.Add(queryParameter3);
            storedProcQuery1.Parameters.Add(queryParameter4);
            storedProcQuery1.Parameters.Add(queryParameter5);
            storedProcQuery1.StoredProcName = "BT_Sales_Report";
            storedProcQuery2.Name = "ConvertRowsInColumns_MultiLangLabels";
            queryParameter6.Name = "@LanguageId";
            queryParameter6.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter6.Value = new DevExpress.DataAccess.Expression("[Parameters.LanguageId]", typeof(int));
            queryParameter7.Name = "@FormName";
            queryParameter7.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter7.Value = new DevExpress.DataAccess.Expression("[Parameters.FormName]", typeof(string));
            storedProcQuery2.Parameters.Add(queryParameter6);
            storedProcQuery2.Parameters.Add(queryParameter7);
            storedProcQuery2.StoredProcName = "ConvertRowsInColumns_MultiLangLabels";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1,
            storedProcQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            this.sqlDataSource1.ConfigureDataConnection += new DevExpress.DataAccess.Sql.ConfigureDataConnectionEventHandler(this.sqlDataSource1_ConfigureDataConnection);
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
            this.DetailCaption3.BorderColor = System.Drawing.Color.Black;
            this.DetailCaption3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DetailCaption3.BorderWidth = 1F;
            this.DetailCaption3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.DetailCaption3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.DetailCaption3.Name = "DetailCaption3";
            this.DetailCaption3.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.DetailCaption3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData3
            // 
            this.DetailData3.Font = new System.Drawing.Font("Times New Roman", 9F);
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
            this.DetailData3_Odd.Font = new System.Drawing.Font("Times New Roman", 9F);
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
            // PageInfo
            // 
            this.PageInfo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.PageInfo.Name = "PageInfo";
            this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // AgSenderCode
            // 
            this.AgSenderCode.Description = "AgSenderCode";
            this.AgSenderCode.Name = "AgSenderCode";
            this.AgSenderCode.ValueInfo = "FL1000";
            // 
            // FDate
            // 
            this.FDate.Description = "FDate";
            this.FDate.Name = "FDate";
            this.FDate.Type = typeof(System.DateTime);
            this.FDate.ValueInfo = "2022-01-26";
            // 
            // UserName
            // 
            this.UserName.Description = "UserName";
            this.UserName.Name = "UserName";
            // 
            // FormName
            // 
            this.FormName.Description = "FormName";
            this.FormName.Name = "FormName";
            this.FormName.ValueInfo = "REPORT.IMXDIRECT.BILLPAYMENT";
            this.FormName.Visible = false;
            // 
            // LanguageId
            // 
            this.LanguageId.Description = "LanguageId";
            this.LanguageId.Name = "LanguageId";
            this.LanguageId.Type = typeof(int);
            this.LanguageId.ValueInfo = "1";
            // 
            // AgencyName
            // 
            this.AgencyName.Description = "AgencyName";
            this.AgencyName.Name = "AgencyName";
            // 
            // AllowViewCommissions
            // 
            this.AllowViewCommissions.Description = "Allow View Commissions";
            this.AllowViewCommissions.Name = "AllowViewCommissions";
            this.AllowViewCommissions.Type = typeof(bool);
            this.AllowViewCommissions.ValueInfo = "False";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCompanyHeader});
            this.ReportHeader.HeightF = 26.04167F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrCompanyHeader
            // 
            this.xrCompanyHeader.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrCompanyHeader.Name = "xrCompanyHeader";
            this.xrCompanyHeader.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgSenderCode", this.AgSenderCode));
            this.xrCompanyHeader.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FormName", this.FormName));
            this.xrCompanyHeader.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LanguageId", this.LanguageId));
            this.xrCompanyHeader.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("ReportTitle", null, "ConvertRowsInColumns_MultiLangLabels.BillPaymentEndOfDayTitle"));
            this.xrCompanyHeader.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FDate", this.FDate));
            this.xrCompanyHeader.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgencyName", this.AgencyName));
            this.xrCompanyHeader.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("OnlyFromVisible", this.OnlyFromVisible));
            this.xrCompanyHeader.ReportSource = new WebAPIReports.Reports.Common.CustomHeader.CompanyAgencyReportHeader();
            this.xrCompanyHeader.SizeF = new System.Drawing.SizeF(830F, 25.99999F);
            // 
            // OnlyFromVisible
            // 
            this.OnlyFromVisible.Description = "OnlyFromVisible";
            this.OnlyFromVisible.Name = "OnlyFromVisible";
            this.OnlyFromVisible.Type = typeof(bool);
            this.OnlyFromVisible.ValueInfo = "True";
            this.OnlyFromVisible.Visible = false;
            // 
            // EmptyLeyend
            // 
            this.EmptyLeyend.AutoWidth = true;
            this.EmptyLeyend.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ConvertRowsInColumns_MultiLangLabels].[EmptyLeyend]")});
            this.EmptyLeyend.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmptyLeyend.LocationFloat = new DevExpress.Utils.PointFloat(19.21747F, 0F);
            this.EmptyLeyend.Multiline = true;
            this.EmptyLeyend.Name = "EmptyLeyend";
            this.EmptyLeyend.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.EmptyLeyend.SizeF = new System.Drawing.SizeF(747.9999F, 13.00005F);
            this.EmptyLeyend.StylePriority.UseFont = false;
            this.EmptyLeyend.StylePriority.UseTextAlignment = false;
            this.EmptyLeyend.Text = "EmptyLeyend";
            this.EmptyLeyend.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.EmptyLeyend});
            this.PageHeader.HeightF = 13.00005F;
            this.PageHeader.Name = "PageHeader";
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCompanyFooter});
            this.PageFooter.HeightF = 25.99999F;
            this.PageFooter.Name = "PageFooter";
            // 
            // xrCompanyFooter
            // 
            this.xrCompanyFooter.LocationFloat = new DevExpress.Utils.PointFloat(7.947286E-06F, 0F);
            this.xrCompanyFooter.Name = "xrCompanyFooter";
            this.xrCompanyFooter.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("AgSenderCode", this.AgSenderCode));
            this.xrCompanyFooter.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("FormName", this.FormName));
            this.xrCompanyFooter.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("LanguageId", this.LanguageId));
            this.xrCompanyFooter.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("ReportTitle", null, "ConvertRowsInColumns_MultiLangLabels.BillPaymentEndOfDayTitle"));
            this.xrCompanyFooter.ReportSource = new WebAPIReports.Reports.Common.CustomHeader.CompanyAgencyReportFooter();
            this.xrCompanyFooter.SizeF = new System.Drawing.SizeF(830F, 25.99999F);
            // 
            // BillPymtEndOfDayCompanyReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupFooter1,
            this.GroupHeader1,
            this.PageHeader,
            this.ReportHeader,
            this.PageFooter});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "BT_Sales_Report";
            this.DataSource = this.sqlDataSource1;
            this.Margins = new System.Drawing.Printing.Margins(10, 10, 10, 10);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.AgSenderCode,
            this.FDate,
            this.UserName,
            this.FormName,
            this.LanguageId,
            this.AgencyName,
            this.AllowViewCommissions,
            this.OnlyFromVisible});
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailCaption3,
            this.DetailData3,
            this.DetailData3_Odd,
            this.DetailCaptionBackground3,
            this.PageInfo});
            this.Version = "18.1";
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.BillPymtEndOfDayReport_DataSourceDemanded);
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.BillPymtEndOfDayReport_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    private void BillPymtEndOfDayReport_DataSourceDemanded(object sender, EventArgs e)
    {
        try
        {
            var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);
            (sender as BillPymtEndOfDayCompanyReport).sqlDataSource1.ConnectionParameters = dataConnectionParametersBase;
        }
        catch (Exception ex)
        {
            log.ErrorFormat("BillPymtEndOfDayCompanyReport ERROR: {0}", ex.Message);
        }
    }

    private void sqlDataSource1_ConfigureDataConnection(object sender, DevExpress.DataAccess.Sql.ConfigureDataConnectionEventArgs e)
    {
        var dataConnectionParametersBase = ReportCommon.GetDataConnectionParameters(WebAPIDataAccess.DAConnectionStrings.WireTransacConnectionString);

        if (e.ConnectionName == ReportCommon.WireTransacDB)
            e.ConnectionParameters = dataConnectionParametersBase;
    }

    private void BillPymtEndOfDayReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        var visible = GetCurrentRow() != null;
        EmptyLeyend.Visible = !visible;
        xrPanel8.Visible = visible;
        xrPanel9.Visible = visible;
        xrPanel10.Visible = visible;
        xrTable2.Visible = visible;
        GroupHeader1.Visible = visible;
    }
}
