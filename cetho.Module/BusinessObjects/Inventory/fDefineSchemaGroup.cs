// Class Name : fDefineSchemaGroup.cs 
// Project Name : FICO 
// Last Update : 07/06/2023 12:01:10  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 07/06/2023 12:01:10 
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
   [System.ComponentModel.DisplayName("Change Vendor: Purchasing data")]
   public class fDefineSchemaGroup : XPObject
   {
     public fDefineSchemaGroup(Session session) : base(session) 
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
     [Appearance("VisiblefDefineSchemaGroupOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for fDefineSchemaGroup : 
     private fVendor _vendor; 
     [XafDisplayName("Vendor"), ToolTip("Vendor")] 
     // [Appearance("fDefineSchemaGroupvendor", Enabled = true)]
     // [Appearance("fDefineSchemaGroupvendorVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fVendor vendor
     { 
       get { return _vendor; } 
       set { SetPropertyValue(nameof(vendor), ref _vendor, value); } 
     } 
     // 
     // Notes for fDefineSchemaGroup : 
     private string _purchorg; 
     [XafDisplayName("Purchasing Org."), ToolTip("Purchasing Org.")] 
     // [Appearance("fDefineSchemaGrouppurchorg", Enabled = true)]
     // [Appearance("fDefineSchemaGrouppurchorgVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string purchorg
     { 
       get { return _purchorg; } 
       set { SetPropertyValue(nameof(purchorg), ref _purchorg, value); } 
     } 
     // Conditons
     // Notes for fDefineSchemaGroup : 
     private fCurrency _ordercurrency; 
     [XafDisplayName("Order Currency"), ToolTip("Order currency")] 
     // [Appearance("fDefineSchemaGroupordercurrency", Enabled = true)]
     // [Appearance("fDefineSchemaGroupordercurrencyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCurrency ordercurrency
     { 
       get { return _ordercurrency; } 
       set { SetPropertyValue(nameof(ordercurrency), ref _ordercurrency, value); } 
     } 
     // Conditons
     // Notes for fDefineSchemaGroup : 
     private string _termpaymt; 
     [XafDisplayName("Term of Payment"), ToolTip("Term of paymnt")] 
     // [Appearance("fDefineSchemaGrouptermpaymt", Enabled = true)]
     // [Appearance("fDefineSchemaGrouptermpaymtVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string termpaymt
     { 
       get { return _termpaymt; } 
       set { SetPropertyValue(nameof(termpaymt), ref _termpaymt, value); } 
     } 
     // Conditons
     // Notes for fDefineSchemaGroup : 
     private string _incoterms; 
     [XafDisplayName("Incoterms"), ToolTip("Incoterms")] 
     // [Appearance("fDefineSchemaGroupincoterms", Enabled = true)]
     // [Appearance("fDefineSchemaGroupincotermsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string incoterms
     { 
       get { return _incoterms; } 
       set { SetPropertyValue(nameof(incoterms), ref _incoterms, value); } 
     } 
     // Conditons
     // Notes for fDefineSchemaGroup : 
     private string _minimordervalue; 
     [XafDisplayName("Minimum Order Value"), ToolTip("Minimum order value")] 
     // [Appearance("fDefineSchemaGroupminimordervalue", Enabled = true)]
     // [Appearance("fDefineSchemaGroupminimordervalueVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string minimordervalue
     { 
       get { return _minimordervalue; } 
       set { SetPropertyValue(nameof(minimordervalue), ref _minimordervalue, value); } 
     } 
     // Conditons
     // Notes for fDefineSchemaGroup : 
     private string _schemgroup; 
     [XafDisplayName("Schema Group, Vendor"), ToolTip("Schema Group, Vendor")] 
     // [Appearance("fDefineSchemaGroupschemgroup", Enabled = true)]
     // [Appearance("fDefineSchemaGroupschemgroupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string schemgroup
     { 
       get { return _schemgroup; } 
       set { SetPropertyValue(nameof(schemgroup), ref _schemgroup, value); } 
     } 
     // Conditons
     // Notes for fDefineSchemaGroup : 
     private string _pricingdatectrl; 
     [XafDisplayName("Pricing Date Control"), ToolTip("Pricing Date Control")] 
     // [Appearance("fDefineSchemaGrouppricingdatectrl", Enabled = true)]
     // [Appearance("fDefineSchemaGrouppricingdatectrlVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string pricingdatectrl
     { 
       get { return _pricingdatectrl; } 
       set { SetPropertyValue(nameof(pricingdatectrl), ref _pricingdatectrl, value); } 
     } 
     // Conditons
     // Notes for fDefineSchemaGroup : 
     private string _orderoptimrest; 
     [XafDisplayName("Order Pptim. Rest."), ToolTip("Order optim.rest.")] 
     // [Appearance("fDefineSchemaGrouporderoptimrest", Enabled = true)]
     // [Appearance("fDefineSchemaGrouporderoptimrestVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string orderoptimrest
     { 
       get { return _orderoptimrest; } 
       set { SetPropertyValue(nameof(orderoptimrest), ref _orderoptimrest, value); } 
     } 
   } 
} 
