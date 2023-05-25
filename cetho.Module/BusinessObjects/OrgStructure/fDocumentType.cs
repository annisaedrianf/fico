// Class Name : fDocumentType.cs 
// Project Name : FICO 
// Last Update : 22/05/2023 15:05:53  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 22/05/2023 15:05:53 
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
   [NavigationItem("FicoGlobalSetting")]
   // Standard Document
   [System.ComponentModel.DisplayName("Document Type")]
   public class fDocumentType : XPObject
   {
     public fDocumentType(Session session) : base(session) 
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
     [Appearance("VisiblefDocumentTypeOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for fDocumentType : 
     private string _code; 
     [XafDisplayName("Document Type"), ToolTip("Document Type")] 
     // [Appearance("fDocumentTypecode", Enabled = true)]
     // [Appearance("fDocumentTypecodeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string code
     { 
       get { return _code; } 
       set { SetPropertyValue(nameof(code), ref _code, value); } 
     } 
     // 
     // Notes for fDocumentType : 
     private string _description; 
     [XafDisplayName("Description"), ToolTip("Description")] 
     // [Appearance("fDocumentTypedescription", Enabled = true)]
     // [Appearance("fDocumentTypedescriptionVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fDocumentType : 
     private fDocumentType _reversedoctype; 
     [XafDisplayName("Reverse Doc. Type"), ToolTip("Reverse Doc. Type")] 
     // [Appearance("fDocumentTypereversedoctype", Enabled = true)]
     // [Appearance("fDocumentTypereversedoctypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fDocumentType reversedoctype
     { 
       get { return _reversedoctype; } 
       set { SetPropertyValue(nameof(reversedoctype), ref _reversedoctype, value); } 
     } 
     // Account Types allowed
     // Notes for fDocumentType : Account Types allowed
     private Boolean _assets; 
     [XafDisplayName("Assets"), ToolTip("Assets")] 
     // [Appearance("fDocumentTypeassets", Enabled = true)]
     // [Appearance("fDocumentTypeassetsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  Boolean assets
     { 
       get { return _assets; } 
       set { SetPropertyValue(nameof(assets), ref _assets, value); } 
     } 
     // Account Types allowed
     // Notes for fDocumentType : Account Types allowed
     private Boolean _customer; 
     [XafDisplayName("Customer"), ToolTip("Customer")] 
     // [Appearance("fDocumentTypecustomer", Enabled = true)]
     // [Appearance("fDocumentTypecustomerVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  Boolean customer
     { 
       get { return _customer; } 
       set { SetPropertyValue(nameof(customer), ref _customer, value); } 
     } 
     // Account Types allowed
     // Notes for fDocumentType : Account Types allowed
     private Boolean _vendor; 
     [XafDisplayName("Vendor"), ToolTip("Vendor")] 
     // [Appearance("fDocumentTypevendor", Enabled = true)]
     // [Appearance("fDocumentTypevendorVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  Boolean vendor
     { 
       get { return _vendor; } 
       set { SetPropertyValue(nameof(vendor), ref _vendor, value); } 
     } 
     // Account Types allowed
     // Notes for fDocumentType : Account Types allowed
     private Boolean _material; 
     [XafDisplayName("Material"), ToolTip("Material")] 
     // [Appearance("fDocumentTypematerial", Enabled = true)]
     // [Appearance("fDocumentTypematerialVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  Boolean material
     { 
       get { return _material; } 
       set { SetPropertyValue(nameof(material), ref _material, value); } 
     } 
     // Account Types allowed
     // Notes for fDocumentType : Account Types allowed
     private Boolean _glaccount; 
     [XafDisplayName("G/L Account"), ToolTip("G/L Account")] 
     // [Appearance("fDocumentTypeglaccount", Enabled = true)]
     // [Appearance("fDocumentTypeglaccountVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  Boolean glaccount
     { 
       get { return _glaccount; } 
       set { SetPropertyValue(nameof(glaccount), ref _glaccount, value); } 
     } 
     // Special Usage
     // Notes for fDocumentType : Special Usage
     private Boolean _batchinputonly; 
     [XafDisplayName("Batch Input Only"), ToolTip("Batch Input Only")] 
     // [Appearance("fDocumentTypebatchinputonly", Enabled = true)]
     // [Appearance("fDocumentTypebatchinputonlyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  Boolean batchinputonly
     { 
       get { return _batchinputonly; } 
       set { SetPropertyValue(nameof(batchinputonly), ref _batchinputonly, value); } 
     } 
     // Special Usage
     // Notes for fDocumentType : Special Usage
     private Boolean _rollup; 
     [XafDisplayName("Rollup"), ToolTip("Rollup")] 
     // [Appearance("fDocumentTyperollup", Enabled = true)]
     // [Appearance("fDocumentTyperollupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  Boolean rollup
     { 
       get { return _rollup; } 
       set { SetPropertyValue(nameof(rollup), ref _rollup, value); } 
     } 
     // Special Usage
     // Notes for fDocumentType : Special Usage
     private Boolean _planning; 
     [XafDisplayName("Planning"), ToolTip("Planning")] 
     // [Appearance("fDocumentTypeplanning", Enabled = true)]
     // [Appearance("fDocumentTypeplanningVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  Boolean planning
     { 
       get { return _planning; } 
       set { SetPropertyValue(nameof(planning), ref _planning, value); } 
     } 
     // Special Usage
     // Notes for fDocumentType : Special Usage
     private Boolean _actallocation; 
     [XafDisplayName("Act Allocation"), ToolTip("Act Allocation")] 
     // [Appearance("fDocumentTypeactallocation", Enabled = true)]
     // [Appearance("fDocumentTypeactallocationVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  Boolean actallocation
     { 
       get { return _actallocation; } 
       set { SetPropertyValue(nameof(actallocation), ref _actallocation, value); } 
     } 
     // Special Usage
     // Notes for fDocumentType : Special Usage
     private Boolean _planallocation; 
     [XafDisplayName("Plan Allocation"), ToolTip("Plan Allocation")] 
     // [Appearance("fDocumentTypeplanallocation", Enabled = true)]
     // [Appearance("fDocumentTypeplanallocationVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  Boolean planallocation
     { 
       get { return _planallocation; } 
       set { SetPropertyValue(nameof(planallocation), ref _planallocation, value); } 
     } 
     // Control Data
     // Notes for fDocumentType : Control Data
     private Boolean _nettdoctype; 
     [XafDisplayName("Nett Document Type"), ToolTip("Nett Document Type")] 
     // [Appearance("fDocumentTypenettdoctype", Enabled = true)]
     // [Appearance("fDocumentTypenettdoctypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  Boolean nettdoctype
     { 
       get { return _nettdoctype; } 
       set { SetPropertyValue(nameof(nettdoctype), ref _nettdoctype, value); } 
     } 
     // Control Data
     // Notes for fDocumentType : Control Data
     private Boolean _custvendcheck; 
     [XafDisplayName("Cust/Vend Check"), ToolTip("Cust/Vend Check")] 
     // [Appearance("fDocumentTypecustvendcheck", Enabled = true)]
     // [Appearance("fDocumentTypecustvendcheckVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  Boolean custvendcheck
     { 
       get { return _custvendcheck; } 
       set { SetPropertyValue(nameof(custvendcheck), ref _custvendcheck, value); } 
     } 
     // Control Data
     // Notes for fDocumentType : Control Data
     private Boolean _negativepostallow; 
     [XafDisplayName("Negative Postings Allowed"), ToolTip("Negative Postings Allowed")] 
     // [Appearance("fDocumentTypenegativepostallow", Enabled = true)]
     // [Appearance("fDocumentTypenegativepostallowVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  Boolean negativepostallow
     { 
       get { return _negativepostallow; } 
       set { SetPropertyValue(nameof(negativepostallow), ref _negativepostallow, value); } 
     } 
     // Control Data
     // Notes for fDocumentType : Control Data
     private Boolean _intercomppostgs; 
     [XafDisplayName("Inter-Company Posting"), ToolTip("Inter-Company Posting")] 
     // [Appearance("fDocumentTypeintercomppostgs", Enabled = true)]
     // [Appearance("fDocumentTypeintercomppostgsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  Boolean intercomppostgs
     { 
       get { return _intercomppostgs; } 
       set { SetPropertyValue(nameof(intercomppostgs), ref _intercomppostgs, value); } 
     } 
   } 
} 
