// Class Name : FinancialManagementArea.cs 
// Project Name : FICO 
// Last Update : 23/04/2023 09:05:04  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 23/04/2023 09:05:04 
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
   [System.ComponentModel.DisplayName("Financial Management Area")]
   public class FinancialManagementArea : XPObject
   {
     public FinancialManagementArea(Session session) : base(session) 
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
     [Appearance("VisibleFinancialManagementAreaOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for FinancialManagementArea : 
     private string _fmarea; 
     [XafDisplayName("FM Area"), ToolTip("FM Area")] 
     // [Appearance("FinancialManagementAreafmarea", Enabled = true)]
     // [Appearance("FinancialManagementAreafmareaVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(7)] 
     public  string fmarea
     { 
       get { return _fmarea; } 
       set { SetPropertyValue(nameof(fmarea), ref _fmarea, value); } 
     } 
     // 
     // Notes for FinancialManagementArea : 
     private string _fmareatext; 
     [XafDisplayName("FM Area Text"), ToolTip("FM Area Text")] 
     // [Appearance("FinancialManagementAreafmareatext", Enabled = true)]
     // [Appearance("FinancialManagementAreafmareatextVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(250)] 
     public  string fmareatext
     { 
       get { return _fmareatext; } 
       set { SetPropertyValue(nameof(fmareatext), ref _fmareatext, value); } 
     } 
     // 
     // Notes for FinancialManagementArea : 
     private fCurrency _fmareacurrency; 
     [XafDisplayName("FM Area Currency"), ToolTip("FM Area Currency")] 
     // [Appearance("FinancialManagementAreafmareacurrency", Enabled = true)]
     // [Appearance("FinancialManagementAreafmareacurrencyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public fCurrency fmareacurrency
     { 
       get { return _fmareacurrency; } 
       set { SetPropertyValue(nameof(fmareacurrency), ref _fmareacurrency, value); } 
     } 
   
   private void UpdateByTime() 
   { 
   string tUser = SecuritySystem.CurrentUserName.ToString(); 
   Updateby = Session.FindObject<ApplicationUser>(new BinaryOperator("UserName", tUser)); 
   Updatedate = DateTime.Now; 
   } 
   private ApplicationUser _Updateby; 
   [XafDisplayName("Update by"), ToolTip("Update by")] 
   // [Appearance("FinancialManagementAreaUpdatebyAppearance", Enabled = false)]
   public ApplicationUser Updateby 
   { 
   get { return _Updateby; } 
   set { SetPropertyValue("Updateby", ref _Updateby, value); } 
   } 
   private DateTime _Updatedate; 
   [XafDisplayName("Update date"), ToolTip("Update date")] 
   // [Appearance("FinancialManagementAreaUpdatedateAppearance", Enabled = false)]
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
