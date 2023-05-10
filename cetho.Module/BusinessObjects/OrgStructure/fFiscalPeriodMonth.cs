// Class Name : fFiscalPeriodMonth.cs 
// Project Name : FICO 
// Last Update : 23/04/2023 19:20:41  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 23/04/2023 19:20:41 
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
using DevExpress.Persistent.BaseImpl;

namespace cetho.Module.BusinessObjects 
{ 
   [DefaultClassOptions] 
   [ImageName("ModelEditor_Views")] 
   [DefaultProperty("Period")]
   [NavigationItem("FicoGlobalSetting")]
   // Standard Document
   [System.ComponentModel.DisplayName("Fiscal Period Month")]
   public class fFiscalPeriodMonth : XPObject
   {
     public fFiscalPeriodMonth(Session session) : base(session) 
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
       UpdateByTime(); 
     } 
     protected override void OnSaving()
     {
        base.OnSaving();
        UpdateByTime(); 
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
     [Appearance("VisiblefFiscalPeriodMonthOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for fFiscalPeriodMonth : 
     private Int16 _month; 
     [XafDisplayName("Month"), ToolTip("Month")] 
     // [Appearance("fFiscalPeriodMonthmonth", Enabled = true)]
     // [Appearance("fFiscalPeriodMonthmonthVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  Int16 month
     { 
       get { return _month; } 
       set { SetPropertyValue(nameof(month), ref _month, value); } 
     } 
     // 
     // Notes for fFiscalPeriodMonth : 
     private Int16 _firstday; 
     [XafDisplayName("First Day"), ToolTip("First Day")] 
     // [Appearance("fFiscalPeriodMonthfirstday", Enabled = true)]
     // [Appearance("fFiscalPeriodMonthfirstdayVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  Int16 firstday
     { 
       get { return _firstday; } 
       set { SetPropertyValue(nameof(firstday), ref _firstday, value); } 
     } 
     // 
     // Notes for fFiscalPeriodMonth : 
     private String _period; 
     [XafDisplayName("Period"), ToolTip("Period")] 
     // [Appearance("fFiscalPeriodMonthperiod", Enabled = true)]
     // [Appearance("fFiscalPeriodMonthperiodVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  String period
     { 
       get { return _period; } 
       set { SetPropertyValue(nameof(period), ref _period, value); } 
     } 
     // 
     // Notes for fFiscalPeriodMonth : 
     private Int16 _yearshift; 
     [XafDisplayName("Year Shift"), ToolTip("Year Shift")] 
     // [Appearance("fFiscalPeriodMonthyearshift", Enabled = true)]
     // [Appearance("fFiscalPeriodMonthyearshiftVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  Int16 yearshift
     { 
       get { return _yearshift; } 
       set { SetPropertyValue(nameof(yearshift), ref _yearshift, value); } 
     } 
     // 
     // Notes for fFiscalPeriodMonth : 
     private fFiscalPeriod _fiscalperiod; 
     [XafDisplayName("Fiscal Period"), ToolTip("Fiscal Period")] 
     // [Appearance("fFiscalPeriodMonthfiscalperiod", Enabled = true)]
     // [Appearance("fFiscalPeriodMonthfiscalperiodVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Association("FiscalMonth")] 
     public  fFiscalPeriod fiscalperiod
     { 
       get { return _fiscalperiod; } 
       set { SetPropertyValue(nameof(fiscalperiod), ref _fiscalperiod, value); } 
     } 
   
   private void UpdateByTime() 
   { 
   string tUser = SecuritySystem.CurrentUserName.ToString(); 
   Updateby = Session.FindObject<ApplicationUser>(new BinaryOperator("UserName", tUser)); 
   Updatedate = DateTime.Now; 
   } 
   private ApplicationUser _Updateby; 
   [XafDisplayName("Update by"), ToolTip("Update by")] 
   // [Appearance("fFiscalPeriodMonthUpdatebyAppearance", Enabled = false)]
   public ApplicationUser Updateby 
   { 
   get { return _Updateby; } 
   set { SetPropertyValue("Updateby", ref _Updateby, value); } 
   } 
   private DateTime _Updatedate; 
   [XafDisplayName("Update date"), ToolTip("Update date")] 
   // [Appearance("fFiscalPeriodMonthUpdatedateAppearance", Enabled = false)]
   public DateTime Updatedate 
   { 
   get 
   { 
    
   return _Updatedate; 
   } 
   set { SetPropertyValue("Updatedate", ref _Updatedate, value); } 
   } 
   } 
} 
