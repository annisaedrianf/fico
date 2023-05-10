// Class Name : fCreditCtlAreas.cs 
// Project Name : FICO 
// Last Update : 23/04/2023 09:09:04  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 23/04/2023 09:09:04 
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
   [DefaultProperty("compannyname")]
   [NavigationItem("Organizational Structure")]
   // Standard Document
   [System.ComponentModel.DisplayName("Credit Control Area")]
   public class fCreditCtlAreas : XPObject
   {
     public fCreditCtlAreas(Session session) : base(session) 
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
     [Appearance("VisiblefCreditCtlAreasOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for fCreditCtlAreas : 
     private string _creditcontrarea; 
     [XafDisplayName("Credit Control Area"), ToolTip("Credit Control Area")] 
     // [Appearance("fCreditCtlAreascreditcontrarea", Enabled = true)]
     // [Appearance("fCreditCtlAreascreditcontrareaVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(7)] 
     public  string creditcontrarea
     { 
       get { return _creditcontrarea; } 
       set { SetPropertyValue(nameof(creditcontrarea), ref _creditcontrarea, value); } 
     } 
     // 
     // Notes for fCreditCtlAreas : 
     private fCurrency _currency; 
     [XafDisplayName("Currency"), ToolTip("Currency")] 
     // [Appearance("fCreditCtlAreascurrency", Enabled = true)]
     // [Appearance("fCreditCtlAreascurrencyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCurrency currency
     { 
       get { return _currency; } 
       set { SetPropertyValue(nameof(currency), ref _currency, value); } 
     } 
     // 
     // Notes for fCreditCtlAreas : 
     private double _creditlimit; 
     [XafDisplayName("Credit Limit"), ToolTip("Credit Limit")] 
     // [Appearance("fCreditCtlAreascreditlimit", Enabled = true)]
     // [Appearance("fCreditCtlAreascreditlimitVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double creditlimit
     { 
       get { return _creditlimit; } 
       set { SetPropertyValue(nameof(creditlimit), ref _creditlimit, value); } 
     } 
   
   private void UpdateByTime() 
   { 
   string tUser = SecuritySystem.CurrentUserName.ToString(); 
   Updateby = Session.FindObject<ApplicationUser>(new BinaryOperator("UserName", tUser)); 
   Updatedate = DateTime.Now; 
   } 
   private ApplicationUser _Updateby; 
   [XafDisplayName("Update by"), ToolTip("Update by")] 
   // [Appearance("fCreditCtlAreasUpdatebyAppearance", Enabled = false)]
   public ApplicationUser Updateby 
   { 
   get { return _Updateby; } 
   set { SetPropertyValue("Updateby", ref _Updateby, value); } 
   } 
   private DateTime _Updatedate; 
   [XafDisplayName("Update date"), ToolTip("Update date")] 
   // [Appearance("fCreditCtlAreasUpdatedateAppearance", Enabled = false)]
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
