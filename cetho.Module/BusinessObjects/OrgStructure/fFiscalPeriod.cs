// Class Name : fFiscalPeriod.cs 
// Project Name : FICO 
// Last Update : 26/04/2023 06:44:27  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 26/04/2023 06:44:27 
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
   [DefaultProperty("fmareatext")]
   [NavigationItem("FicoGlobalSetting")]
   // Standard Document
   [System.ComponentModel.DisplayName("Fiscal Period")]
   public class fFiscalPeriod : XPObject
   {
     public fFiscalPeriod(Session session) : base(session) 
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
     [Appearance("VisiblefFiscalPeriodOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for fFiscalPeriod : 
     private string _code; 
     [XafDisplayName("Fiscal Period"), ToolTip("Fiscal Period")] 
     // [Appearance("fFiscalPeriodcode", Enabled = true)]
     // [Appearance("fFiscalPeriodcodeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(7)] 
     public  string code
     { 
       get { return _code; } 
       set { SetPropertyValue(nameof(code), ref _code, value); } 
     } 
     // 
     // Notes for fFiscalPeriod : 
     private string _description; 
     [XafDisplayName("Description"), ToolTip("Description")] 
     // [Appearance("fFiscalPerioddescription", Enabled = true)]
     // [Appearance("fFiscalPerioddescriptionVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(250)] 
     public  string description
     { 
       get { return _description; } 
       set { SetPropertyValue(nameof(description), ref _description, value); } 
     } 
     // 
     // Notes for fFiscalPeriod : 
     private int _noofpostperiod; 
     [XafDisplayName("No Of Posting Period"), ToolTip("No Of Posting Period")] 
     // [Appearance("fFiscalPeriodnoofpostperiod", Enabled = true)]
     // [Appearance("fFiscalPeriodnoofpostperiodVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  int noofpostperiod
     { 
       get { return _noofpostperiod; } 
       set { SetPropertyValue(nameof(noofpostperiod), ref _noofpostperiod, value); } 
     } 
     // 
     // Notes for fFiscalPeriod : 
     private int _nospecialperiod; 
     [XafDisplayName("No Special Periods"), ToolTip("No Special Periods")] 
     // [Appearance("fFiscalPeriodnospecialperiod", Enabled = true)]
     // [Appearance("fFiscalPeriodnospecialperiodVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  int nospecialperiod
     { 
       get { return _nospecialperiod; } 
       set { SetPropertyValue(nameof(nospecialperiod), ref _nospecialperiod, value); } 
     } 
     // 
     // Notes for fFiscalPeriod : 
     [XafDisplayName(""), ToolTip("")] 
     // [Appearance("fFiscalPeriodperiod", Enabled = true)]
     // [Appearance("fFiscalPeriodperiodVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Association("FiscalMonth")] 
     public XPCollection<fFiscalPeriodMonth> period
     {
     get
       {
         return GetCollection<fFiscalPeriodMonth>("period"); 
       }
     }
   
   private void UpdateByTime() 
   { 
   string tUser = SecuritySystem.CurrentUserName.ToString(); 
   Updateby = Session.FindObject<ApplicationUser>(new BinaryOperator("UserName", tUser)); 
   Updatedate = DateTime.Now; 
   } 
   private ApplicationUser _Updateby; 
   [XafDisplayName("Update by"), ToolTip("Update by")] 
   // [Appearance("fFiscalPeriodUpdatebyAppearance", Enabled = false)]
   public ApplicationUser Updateby 
   { 
   get { return _Updateby; } 
   set { SetPropertyValue("Updateby", ref _Updateby, value); } 
   } 
   private DateTime _Updatedate; 
   [XafDisplayName("Update date"), ToolTip("Update date")] 
   // [Appearance("fFiscalPeriodUpdatedateAppearance", Enabled = false)]
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
