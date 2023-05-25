// Class Name : fCompanyFiscalPeriod.cs 
// Project Name : FICO 
// Last Update : 22/05/2023 15:02:58  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 22/05/2023 15:02:58 
 // Updated :   
//======================================================================== 
 
using System; 
using DevExpress.Xpo; 
using DevExpress.Persistent.Base; 
using System.ComponentModel; 
using DevExpress.Persistent.Validation; 
using DevExpress.ExpressApp.DC; 
using DevExpress.ExpressApp.ConditionalAppearance; 
using DevExpress.ExpressApp; 
using DevExpress.Data.Filtering; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Editors;

namespace cetho.Module.BusinessObjects 
{ 
   [DefaultClassOptions] 
   [ImageName("ModelEditor_Views")] 
   [DefaultProperty("")]
   [NavigationItem("Organizational Structure")]
   // Standard Document
   [System.ComponentModel.DisplayName("Company Fiscal Period")]
   public class fCompanyFiscalPeriod : XPObject
   {
     public fCompanyFiscalPeriod(Session session) : base(session) 
     {
       // This constructor is used when an object is loaded from a persistent storage.
       // Do not place any code here.
     }
     public override void AfterConstruction()
     {
       base.AfterConstruction();
       // Place here your initialization code.
       //SecuritySystem.CurrentUserName
       //LastUpdateUser = Session.GetObjectByKey<GPUser>(SecuritySystem.CurrentUserId);
       string tUser = SecuritySystem.CurrentUserName.ToString();
       //LastUpdateUser = Session.FindObject<GPUser>(new BinaryOperator("UserName", SecuritySystem.CurrentUserName.ToString())); 
       // LastUpdateUser = Session.FindObject<GPUser>(new BinaryOperator("UserName", tUser)); 
       // LastUpdate = DateTime.Now; 
     } 
     protected override void OnSaving()
     {
       base.OnSaving();
     } 
     protected override void OnSaved()
     {
       base.OnSaved();
     } 
     protected override void OnDeleting()
     {
       base.OnDeleting();
     } 
     protected override void OnDeleted()
     {
       base.OnDeleted();
     } 
     public void Sync()
     {
     } 
     [Appearance("VisiblefCompanyFiscalPeriodOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for fCompanyFiscalPeriod : 
     private fCompany _company; 
     [XafDisplayName("Company"), ToolTip("Company")] 
     // [Appearance("fCompanyFiscalPeriodcompany", Enabled = true)]
     // [Appearance("fCompanyFiscalPeriodcompanyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCompany company
     { 
       get { return _company; } 
       set { SetPropertyValue(nameof(company), ref _company, value); } 
     } 
     // 
     // Notes for fCompanyFiscalPeriod : 
     private int _year; 
     [XafDisplayName("Year"), ToolTip("Year")] 
     // [Appearance("fCompanyFiscalPeriodyear", Enabled = true)]
     // [Appearance("fCompanyFiscalPeriodyearVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  int year
     { 
       get { return _year; } 
       set { SetPropertyValue(nameof(year), ref _year, value); } 
     } 
     // 
     // Notes for fCompanyFiscalPeriod : 
     private bool _historicalyear; 
     [XafDisplayName("HistoricalYear"), ToolTip("HistoricalYear")] 
     // [Appearance("fCompanyFiscalPeriodhistoricalyear", Enabled = true)]
     // [Appearance("fCompanyFiscalPeriodhistoricalyearVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool historicalyear
     { 
       get { return _historicalyear; } 
       set { SetPropertyValue(nameof(historicalyear), ref _historicalyear, value); } 
     } 
     // 
     // Notes for fCompanyFiscalPeriod : 
     private int _periodid; 
     [XafDisplayName("Period"), ToolTip("Period")] 
     // [Appearance("fCompanyFiscalPeriodperiodid", Enabled = true)]
     // [Appearance("fCompanyFiscalPeriodperiodidVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  int periodid
     { 
       get { return _periodid; } 
       set { SetPropertyValue(nameof(periodid), ref _periodid, value); } 
     } 
     // 
     // Notes for fCompanyFiscalPeriod : 
     private string _period; 
     [XafDisplayName("Period Name"), ToolTip("Period Name")] 
     // [Appearance("fCompanyFiscalPeriodperiod", Enabled = true)]
     // [Appearance("fCompanyFiscalPeriodperiodVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string period
     { 
       get { return _period; } 
       set { SetPropertyValue(nameof(period), ref _period, value); } 
     } 
     // 
     // Notes for fCompanyFiscalPeriod : 
     private DateTime _startdate; 
     [XafDisplayName("StartDate"), ToolTip("StartDate")] 
     // [Appearance("fCompanyFiscalPeriodstartdate", Enabled = true)]
     // [Appearance("fCompanyFiscalPeriodstartdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime startdate
     { 
       get { return _startdate; } 
       set { SetPropertyValue(nameof(startdate), ref _startdate, value); } 
     } 
     // 
     // Notes for fCompanyFiscalPeriod : 
     private DateTime _enddate; 
     [XafDisplayName("EndDate"), ToolTip("EndDate")] 
     // [Appearance("fCompanyFiscalPeriodenddate", Enabled = true)]
     // [Appearance("fCompanyFiscalPeriodenddateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime enddate
     { 
       get { return _enddate; } 
       set { SetPropertyValue(nameof(enddate), ref _enddate, value); } 
     } 
     // 
     // Notes for fCompanyFiscalPeriod : 
     private bool _sd; 
     [XafDisplayName("SD"), ToolTip("SD")] 
     // [Appearance("fCompanyFiscalPeriodsd", Enabled = true)]
     // [Appearance("fCompanyFiscalPeriodsdVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool sd
     { 
       get { return _sd; } 
       set { SetPropertyValue(nameof(sd), ref _sd, value); } 
     } 
     // 
     // Notes for fCompanyFiscalPeriod : 
     private bool _mm; 
     [XafDisplayName("MM"), ToolTip("MM")] 
     // [Appearance("fCompanyFiscalPeriodmm", Enabled = true)]
     // [Appearance("fCompanyFiscalPeriodmmVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool mm
     { 
       get { return _mm; } 
       set { SetPropertyValue(nameof(mm), ref _mm, value); } 
     } 
     // 
     // Notes for fCompanyFiscalPeriod : 
     private bool _fico; 
     [XafDisplayName("FICO"), ToolTip("FICO")] 
     // [Appearance("fCompanyFiscalPeriodfico", Enabled = true)]
     // [Appearance("fCompanyFiscalPeriodficoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool fico
     { 
       get { return _fico; } 
       set { SetPropertyValue(nameof(fico), ref _fico, value); } 
     } 
     // 
     // Notes for fCompanyFiscalPeriod : 
     private bool _pp; 
     [XafDisplayName("PP"), ToolTip("PP")] 
     // [Appearance("fCompanyFiscalPeriodpp", Enabled = true)]
     // [Appearance("fCompanyFiscalPeriodppVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool pp
     { 
       get { return _pp; } 
       set { SetPropertyValue(nameof(pp), ref _pp, value); } 
     } 
     // 
     // Notes for fCompanyFiscalPeriod : 
     private bool _hr; 
     [XafDisplayName("HR"), ToolTip("HR")] 
     // [Appearance("fCompanyFiscalPeriodhr", Enabled = true)]
     // [Appearance("fCompanyFiscalPeriodhrVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool hr
     { 
       get { return _hr; } 
       set { SetPropertyValue(nameof(hr), ref _hr, value); } 
     } 
     // 
     // Notes for fCompanyFiscalPeriod : 
     private bool _sm; 
     [XafDisplayName("SM"), ToolTip("SM")] 
     // [Appearance("fCompanyFiscalPeriodsm", Enabled = true)]
     // [Appearance("fCompanyFiscalPeriodsmVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool sm
     { 
       get { return _sm; } 
       set { SetPropertyValue(nameof(sm), ref _sm, value); } 
     } 
     // 
     // Notes for fCompanyFiscalPeriod : 
     private bool _qm; 
     [XafDisplayName("QM"), ToolTip("QM")] 
     // [Appearance("fCompanyFiscalPeriodqm", Enabled = true)]
     // [Appearance("fCompanyFiscalPeriodqmVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool qm
     { 
       get { return _qm; } 
       set { SetPropertyValue(nameof(qm), ref _qm, value); } 
     } 
     // 
     // Notes for fCompanyFiscalPeriod : 
     private bool _pm; 
     [XafDisplayName("PM"), ToolTip("PM")] 
     // [Appearance("fCompanyFiscalPeriodpm", Enabled = true)]
     // [Appearance("fCompanyFiscalPeriodpmVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool pm
     { 
       get { return _pm; } 
       set { SetPropertyValue(nameof(pm), ref _pm, value); } 
     } 
   } 
} 
