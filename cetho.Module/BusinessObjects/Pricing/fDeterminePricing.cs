// Class Name : fDeterminePricing.cs 
// Project Name : FICO 
// Last Update : 29/05/2023 14:26:51  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 29/05/2023 14:26:48 
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
   [DefaultProperty("TaxCatgr")]
   [NavigationItem("Master")]
   // Standard Document
   [System.ComponentModel.DisplayName("Change View (Sales Documents: Pricing for Item Category)")]
   public class fDeterminePricing : XPObject
   {
     public fDeterminePricing(Session session) : base(session) 
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
     [Appearance("VisiblefDeterminePricingOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for fDeterminePricing : 
     private string _itemcat; 
     [XafDisplayName("ItemCat"), ToolTip("ItemCat")] 
     // [Appearance("fDeterminePricingitemcat", Enabled = true)]
     // [Appearance("fDeterminePricingitemcatVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string itemcat
     { 
       get { return _itemcat; } 
       set { SetPropertyValue(nameof(itemcat), ref _itemcat, value); } 
     } 
     // 
     // Notes for fDeterminePricing : 
     private string _desc; 
     [XafDisplayName("Description"), ToolTip("Description")] 
     // [Appearance("fDeterminePricingdesc", Enabled = true)]
     // [Appearance("fDeterminePricingdescVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string desc
     { 
       get { return _desc; } 
       set { SetPropertyValue(nameof(desc), ref _desc, value); } 
     } 
     // 
     // Notes for fDeterminePricing : 
     private string _pricing; 
     [XafDisplayName("Pricing"), ToolTip("Pricing")] 
     // [Appearance("fDeterminePricingpricing", Enabled = true)]
     // [Appearance("fDeterminePricingpricingVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string pricing
     { 
       get { return _pricing; } 
       set { SetPropertyValue(nameof(pricing), ref _pricing, value); } 
     } 
     // 
     // Notes for fDeterminePricing : 
     private string _statisval; 
     [XafDisplayName("Statictical Value"), ToolTip("Statictical value")] 
     // [Appearance("fDeterminePricingstatisval", Enabled = true)]
     // [Appearance("fDeterminePricingstatisvalVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string statisval
     { 
       get { return _statisval; } 
       set { SetPropertyValue(nameof(statisval), ref _statisval, value); } 
     } 
     // 
     // Notes for fDeterminePricing : 
     private string _shortdesc; 
     [XafDisplayName("Short Desc."), ToolTip("Short Descprit.")] 
     // [Appearance("fDeterminePricingshortdesc", Enabled = true)]
     // [Appearance("fDeterminePricingshortdescVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string shortdesc
     { 
       get { return _shortdesc; } 
       set { SetPropertyValue(nameof(shortdesc), ref _shortdesc, value); } 
     } 
   } 
} 
