// Class Name : fPurchaseReference.cs 
// Project Name : FICO 
// Last Update : 14/06/2023 11:25:53  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 14/06/2023 11:25:53 
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
   [System.ComponentModel.DisplayName("Ordering: Assigned Purchase Requisitions")]
   public class fPurchaseReference : XPObject
   {
     public fPurchaseReference(Session session) : base(session) 
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
     [Appearance("VisiblefPurchaseReferenceOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // General selections
     // Notes for fPurchaseReference : 
     private bool _assignopenrelease; 
     [XafDisplayName("Assigned, Open, and Released"), ToolTip("Assigned, Open, and Released")] 
     // [Appearance("fPurchaseReferenceassignopenrelease", Enabled = true)]
     // [Appearance("fPurchaseReferenceassignopenreleaseVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool assignopenrelease
     { 
       get { return _assignopenrelease; } 
       set { SetPropertyValue(nameof(assignopenrelease), ref _assignopenrelease, value); } 
     } 
     // General selections
     // Notes for fPurchaseReference : 
     private string _maxnohits; 
     [XafDisplayName("Max. No of Hits"), ToolTip("Max. No of Hits")] 
     // [Appearance("fPurchaseReferencemaxnohits", Enabled = true)]
     // [Appearance("fPurchaseReferencemaxnohitsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string maxnohits
     { 
       get { return _maxnohits; } 
       set { SetPropertyValue(nameof(maxnohits), ref _maxnohits, value); } 
     } 
     // General selections
     // Notes for fPurchaseReference : 
     private bool _openonly; 
     [XafDisplayName("Open Only"), ToolTip("Open Only")] 
     // [Appearance("fPurchaseReferenceopenonly", Enabled = true)]
     // [Appearance("fPurchaseReferenceopenonlyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool openonly
     { 
       get { return _openonly; } 
       set { SetPropertyValue(nameof(openonly), ref _openonly, value); } 
     } 
     // General selections
     // Notes for fPurchaseReference : 
     private bool _releaseonly; 
     [XafDisplayName("Released Only"), ToolTip("Released Only")] 
     // [Appearance("fPurchaseReferencereleaseonly", Enabled = true)]
     // [Appearance("fPurchaseReferencereleaseonlyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool releaseonly
     { 
       get { return _releaseonly; } 
       set { SetPropertyValue(nameof(releaseonly), ref _releaseonly, value); } 
     } 
     // ProcessAssignment : Create PO
     // Notes for fPurchaseReference : 
     private string _ordertype; 
     [XafDisplayName("Order Type"), ToolTip("Order Type")] 
     // [Appearance("fPurchaseReferenceordertype", Enabled = true)]
     // [Appearance("fPurchaseReferenceordertypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string ordertype
     { 
       get { return _ordertype; } 
       set { SetPropertyValue(nameof(ordertype), ref _ordertype, value); } 
     } 
     // ProcessAssignment : Create PO
     // Notes for fPurchaseReference : 
     private string _puchgroup; 
     [XafDisplayName("Purchasing Group "), ToolTip("Purchasing Group ")] 
     // [Appearance("fPurchaseReferencepuchgroup", Enabled = true)]
     // [Appearance("fPurchaseReferencepuchgroupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string puchgroup
     { 
       get { return _puchgroup; } 
       set { SetPropertyValue(nameof(puchgroup), ref _puchgroup, value); } 
     } 
     // ProcessAssignment : Create PO
     // Notes for fPurchaseReference : 
     private string _purchorder; 
     [XafDisplayName("Purchase Order"), ToolTip("Purchase Order")] 
     // [Appearance("fPurchaseReferencepurchorder", Enabled = true)]
     // [Appearance("fPurchaseReferencepurchorderVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string purchorder
     { 
       get { return _purchorder; } 
       set { SetPropertyValue(nameof(purchorder), ref _purchorder, value); } 
     } 
     // ProcessAssignment : Create PO
     // Notes for fPurchaseReference : 
     private DateTime _purchorderdate; 
     [XafDisplayName("Purchase Order Date"), ToolTip("Purchase Order Date")] 
     // [Appearance("fPurchaseReferencepurchorderdate", Enabled = true)]
     // [Appearance("fPurchaseReferencepurchorderdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime purchorderdate
     { 
       get { return _purchorderdate; } 
       set { SetPropertyValue(nameof(purchorderdate), ref _purchorderdate, value); } 
     } 
     // ProcessAssignment : Create PO
     // Notes for fPurchaseReference : 
     private string _purchorgn1; 
     [XafDisplayName("Purchasing Organization "), ToolTip("Purchasing Organization ")] 
     // [Appearance("fPurchaseReferencepurchorgn1", Enabled = true)]
     // [Appearance("fPurchaseReferencepurchorgn1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string purchorgn1
     { 
       get { return _purchorgn1; } 
       set { SetPropertyValue(nameof(purchorgn1), ref _purchorgn1, value); } 
     } 
     // Program selections
     // Notes for fPurchaseReference : 
     private string _doctype; 
     [XafDisplayName("Document Type"), ToolTip("Document Type")] 
     // [Appearance("fPurchaseReferencedoctype", Enabled = true)]
     // [Appearance("fPurchaseReferencedoctypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string doctype
     { 
       get { return _doctype; } 
       set { SetPropertyValue(nameof(doctype), ref _doctype, value); } 
     } 
     // Program selections
     // Notes for fPurchaseReference : 
     private string _itemnumb; 
     [XafDisplayName("Item Number"), ToolTip("Item Number")] 
     // [Appearance("fPurchaseReferenceitemnumb", Enabled = true)]
     // [Appearance("fPurchaseReferenceitemnumbVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string itemnumb
     { 
       get { return _itemnumb; } 
       set { SetPropertyValue(nameof(itemnumb), ref _itemnumb, value); } 
     } 
     // Program selections
     // Notes for fPurchaseReference : 
     private string _mpnmaterial; 
     [XafDisplayName("MPN Material"), ToolTip("MPN Material")] 
     // [Appearance("fPurchaseReferencempnmaterial", Enabled = true)]
     // [Appearance("fPurchaseReferencempnmaterialVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string mpnmaterial
     { 
       get { return _mpnmaterial; } 
       set { SetPropertyValue(nameof(mpnmaterial), ref _mpnmaterial, value); } 
     } 
     // Program selections
     // Notes for fPurchaseReference : 
     private string _namerequistion; 
     [XafDisplayName("Name of Requistioner/Request"), ToolTip("Name of Requistioner/Request")] 
     // [Appearance("fPurchaseReferencenamerequistion", Enabled = true)]
     // [Appearance("fPurchaseReferencenamerequistionVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string namerequistion
     { 
       get { return _namerequistion; } 
       set { SetPropertyValue(nameof(namerequistion), ref _namerequistion, value); } 
     } 
     // Program selections
     // Notes for fPurchaseReference : 
     private string _purchgroup2; 
     [XafDisplayName("Purchasing Group "), ToolTip("Purchasing Group ")] 
     // [Appearance("fPurchaseReferencepurchgroup2", Enabled = true)]
     // [Appearance("fPurchaseReferencepurchgroup2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string purchgroup2
     { 
       get { return _purchgroup2; } 
       set { SetPropertyValue(nameof(purchgroup2), ref _purchgroup2, value); } 
     } 
     // Program selections
     // Notes for fPurchaseReference : 
     private string _purchorgn2; 
     [XafDisplayName("Purchasing Organization "), ToolTip("Purchasing Organization ")] 
     // [Appearance("fPurchaseReferencepurchorgn2", Enabled = true)]
     // [Appearance("fPurchaseReferencepurchorgn2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string purchorgn2
     { 
       get { return _purchorgn2; } 
       set { SetPropertyValue(nameof(purchorgn2), ref _purchorgn2, value); } 
     } 
     // Program selections
     // Notes for fPurchaseReference : 
     private string _purchrequistionnumb; 
     [XafDisplayName("Purchase Requistion Number"), ToolTip("Purchase Requistion Number")] 
     // [Appearance("fPurchaseReferencepurchrequistionnumb", Enabled = true)]
     // [Appearance("fPurchaseReferencepurchrequistionnumbVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(15)] 
     public  string purchrequistionnumb
     { 
       get { return _purchrequistionnumb; } 
       set { SetPropertyValue(nameof(purchrequistionnumb), ref _purchrequistionnumb, value); } 
     } 
     // Program selections
     // Notes for fPurchaseReference : 
     private string _reqtracknumb; 
     [XafDisplayName("Requirement Tracking Number"), ToolTip("Requirement Tracking Number")] 
     // [Appearance("fPurchaseReferencereqtracknumb", Enabled = true)]
     // [Appearance("fPurchaseReferencereqtracknumbVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(15)] 
     public  string reqtracknumb
     { 
       get { return _reqtracknumb; } 
       set { SetPropertyValue(nameof(reqtracknumb), ref _reqtracknumb, value); } 
     } 
     // Program selections
     // Notes for fPurchaseReference : 
     private string _requistiondate; 
     [XafDisplayName("Requistion (Request) Date"), ToolTip("Requistion (Request) Date")] 
     // [Appearance("fPurchaseReferencerequistiondate", Enabled = true)]
     // [Appearance("fPurchaseReferencerequistiondateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(15)] 
     public  string requistiondate
     { 
       get { return _requistiondate; } 
       set { SetPropertyValue(nameof(requistiondate), ref _requistiondate, value); } 
     } 
     // Program selections
     // Notes for fPurchaseReference : 
     private string _to17; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fPurchaseReferenceto17", Enabled = true)]
     // [Appearance("fPurchaseReferenceto17Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string to17
     { 
       get { return _to17; } 
       set { SetPropertyValue(nameof(to17), ref _to17, value); } 
     } 
     // Program selections
     // Notes for fPurchaseReference : 
     private string _to18; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fPurchaseReferenceto18", Enabled = true)]
     // [Appearance("fPurchaseReferenceto18Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(15)] 
     public  string to18
     { 
       get { return _to18; } 
       set { SetPropertyValue(nameof(to18), ref _to18, value); } 
     } 
     // Program selections
     // Notes for fPurchaseReference : 
     private string _to19; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fPurchaseReferenceto19", Enabled = true)]
     // [Appearance("fPurchaseReferenceto19Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(15)] 
     public  string to19
     { 
       get { return _to19; } 
       set { SetPropertyValue(nameof(to19), ref _to19, value); } 
     } 
     // Program selections
     // Notes for fPurchaseReference : 
     private string _to20; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fPurchaseReferenceto20", Enabled = true)]
     // [Appearance("fPurchaseReferenceto20Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(15)] 
     public  string to20
     { 
       get { return _to20; } 
       set { SetPropertyValue(nameof(to20), ref _to20, value); } 
     } 
     // Program selections
     // Notes for fPurchaseReference : 
     private string _to21; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fPurchaseReferenceto21", Enabled = true)]
     // [Appearance("fPurchaseReferenceto21Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string to21
     { 
       get { return _to21; } 
       set { SetPropertyValue(nameof(to21), ref _to21, value); } 
     } 
     // Program selections
     // Notes for fPurchaseReference : 
     private string _to22; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fPurchaseReferenceto22", Enabled = true)]
     // [Appearance("fPurchaseReferenceto22Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string to22
     { 
       get { return _to22; } 
       set { SetPropertyValue(nameof(to22), ref _to22, value); } 
     } 
     // Program selections
     // Notes for fPurchaseReference : 
     private string _to23; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fPurchaseReferenceto23", Enabled = true)]
     // [Appearance("fPurchaseReferenceto23Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string to23
     { 
       get { return _to23; } 
       set { SetPropertyValue(nameof(to23), ref _to23, value); } 
     } 
     // Program selections
     // Notes for fPurchaseReference : 
     private string _to24; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fPurchaseReferenceto24", Enabled = true)]
     // [Appearance("fPurchaseReferenceto24Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string to24
     { 
       get { return _to24; } 
       set { SetPropertyValue(nameof(to24), ref _to24, value); } 
     } 
     // Program selections
     // Notes for fPurchaseReference : 
     private string _to25; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fPurchaseReferenceto25", Enabled = true)]
     // [Appearance("fPurchaseReferenceto25Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string to25
     { 
       get { return _to25; } 
       set { SetPropertyValue(nameof(to25), ref _to25, value); } 
     } 
     // 
     // Notes for fPurchaseReference : 
     private string _asset; 
     [XafDisplayName("Asset"), ToolTip("Asset")] 
     // [Appearance("fPurchaseReferenceasset", Enabled = true)]
     // [Appearance("fPurchaseReferenceassetVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string asset
     { 
       get { return _asset; } 
       set { SetPropertyValue(nameof(asset), ref _asset, value); } 
     } 
     // 
     // Notes for fPurchaseReference : 
     private string _assetsubnumb; 
     [XafDisplayName("Asset Subnumber"), ToolTip("Asset Subnumber")] 
     // [Appearance("fPurchaseReferenceassetsubnumb", Enabled = true)]
     // [Appearance("fPurchaseReferenceassetsubnumbVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string assetsubnumb
     { 
       get { return _assetsubnumb; } 
       set { SetPropertyValue(nameof(assetsubnumb), ref _assetsubnumb, value); } 
     } 
     // 
     // Notes for fPurchaseReference : 
     private bool _contracts; 
     [XafDisplayName("Contracts"), ToolTip("Contracts")] 
     // [Appearance("fPurchaseReferencecontracts", Enabled = true)]
     // [Appearance("fPurchaseReferencecontractsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool contracts
     { 
       get { return _contracts; } 
       set { SetPropertyValue(nameof(contracts), ref _contracts, value); } 
     } 
     // 
     // Notes for fPurchaseReference : 
     private string _costcenter; 
     [XafDisplayName("Cost Center"), ToolTip("Cost Center")] 
     // [Appearance("fPurchaseReferencecostcenter", Enabled = true)]
     // [Appearance("fPurchaseReferencecostcenterVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string costcenter
     { 
       get { return _costcenter; } 
       set { SetPropertyValue(nameof(costcenter), ref _costcenter, value); } 
     } 
     // 
     // Notes for fPurchaseReference : 
     private DateTime _delivdate; 
     [XafDisplayName("Delivery Date"), ToolTip("Delivery Date")] 
     // [Appearance("fPurchaseReferencedelivdate", Enabled = true)]
     // [Appearance("fPurchaseReferencedelivdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime delivdate
     { 
       get { return _delivdate; } 
       set { SetPropertyValue(nameof(delivdate), ref _delivdate, value); } 
     } 
     // 
     // Notes for fPurchaseReference : 
     private bool _entrysheets; 
     [XafDisplayName("Entry Sheets"), ToolTip("Entry Sheets")] 
     // [Appearance("fPurchaseReferenceentrysheets", Enabled = true)]
     // [Appearance("fPurchaseReferenceentrysheetsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool entrysheets
     { 
       get { return _entrysheets; } 
       set { SetPropertyValue(nameof(entrysheets), ref _entrysheets, value); } 
     } 
     // 
     // Notes for fPurchaseReference : 
     private string _frameworkorder; 
     [XafDisplayName("Framework Order"), ToolTip("Framework Order")] 
     // [Appearance("fPurchaseReferenceframeworkorder", Enabled = true)]
     // [Appearance("fPurchaseReferenceframeworkorderVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string frameworkorder
     { 
       get { return _frameworkorder; } 
       set { SetPropertyValue(nameof(frameworkorder), ref _frameworkorder, value); } 
     } 
     // 
     // Notes for fPurchaseReference : 
     private string _itemctgry; 
     [XafDisplayName("Item Category"), ToolTip("Item Category")] 
     // [Appearance("fPurchaseReferenceitemctgry", Enabled = true)]
     // [Appearance("fPurchaseReferenceitemctgryVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string itemctgry
     { 
       get { return _itemctgry; } 
       set { SetPropertyValue(nameof(itemctgry), ref _itemctgry, value); } 
     } 
     // 
     // Notes for fPurchaseReference : 
     private string _network; 
     [XafDisplayName("Netwrok"), ToolTip("Netwrok")] 
     // [Appearance("fPurchaseReferencenetwork", Enabled = true)]
     // [Appearance("fPurchaseReferencenetworkVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string network
     { 
       get { return _network; } 
       set { SetPropertyValue(nameof(network), ref _network, value); } 
     } 
     // 
     // Notes for fPurchaseReference : 
     private string _operationnumb; 
     [XafDisplayName("Operation Number"), ToolTip("Operation Number")] 
     // [Appearance("fPurchaseReferenceoperationnumb", Enabled = true)]
     // [Appearance("fPurchaseReferenceoperationnumbVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string operationnumb
     { 
       get { return _operationnumb; } 
       set { SetPropertyValue(nameof(operationnumb), ref _operationnumb, value); } 
     } 
     // 
     // Notes for fPurchaseReference : 
     private string _order; 
     [XafDisplayName("Order"), ToolTip("Order")] 
     // [Appearance("fPurchaseReferenceorder", Enabled = true)]
     // [Appearance("fPurchaseReferenceorderVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string order
     { 
       get { return _order; } 
       set { SetPropertyValue(nameof(order), ref _order, value); } 
     } 
     // 
     // Notes for fPurchaseReference : 
     private string _outlineagree; 
     [XafDisplayName("Outline Agreement"), ToolTip("Outline Agreement")] 
     // [Appearance("fPurchaseReferenceoutlineagree", Enabled = true)]
     // [Appearance("fPurchaseReferenceoutlineagreeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string outlineagree
     { 
       get { return _outlineagree; } 
       set { SetPropertyValue(nameof(outlineagree), ref _outlineagree, value); } 
     } 
     // 
     // Notes for fPurchaseReference : 
     private string _plant; 
     [XafDisplayName("Plant"), ToolTip("Plant")] 
     // [Appearance("fPurchaseReferenceplant", Enabled = true)]
     // [Appearance("fPurchaseReferenceplantVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string plant
     { 
       get { return _plant; } 
       set { SetPropertyValue(nameof(plant), ref _plant, value); } 
     } 
     // 
     // Notes for fPurchaseReference : 
     private string _purchgroup; 
     [XafDisplayName("Purchasing Group"), ToolTip("Purchasing Group")] 
     // [Appearance("fPurchaseReferencepurchgroup", Enabled = true)]
     // [Appearance("fPurchaseReferencepurchgroupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string purchgroup
     { 
       get { return _purchgroup; } 
       set { SetPropertyValue(nameof(purchgroup), ref _purchgroup, value); } 
     } 
     // 
     // Notes for fPurchaseReference : 
     private string _purchorgn; 
     [XafDisplayName("Purchasing Organization"), ToolTip("Purchasing Organization")] 
     // [Appearance("fPurchaseReferencepurchorgn", Enabled = true)]
     // [Appearance("fPurchaseReferencepurchorgnVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string purchorgn
     { 
       get { return _purchorgn; } 
       set { SetPropertyValue(nameof(purchorgn), ref _purchorgn, value); } 
     } 
     // 
     // Notes for fPurchaseReference : 
     private DateTime _releasedate; 
     [XafDisplayName("Release Date"), ToolTip("Release Date")] 
     // [Appearance("fPurchaseReferencereleasedate", Enabled = true)]
     // [Appearance("fPurchaseReferencereleasedateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime releasedate
     { 
       get { return _releasedate; } 
       set { SetPropertyValue(nameof(releasedate), ref _releasedate, value); } 
     } 
     // 
     // Notes for fPurchaseReference : 
     private string _salesorder; 
     [XafDisplayName("Sales Order"), ToolTip("Sales Order")] 
     // [Appearance("fPurchaseReferencesalesorder", Enabled = true)]
     // [Appearance("fPurchaseReferencesalesorderVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string salesorder
     { 
       get { return _salesorder; } 
       set { SetPropertyValue(nameof(salesorder), ref _salesorder, value); } 
     } 
     // 
     // Notes for fPurchaseReference : 
     private string _salesorderitem; 
     [XafDisplayName("Sales Order Item"), ToolTip("Sales Order Item")] 
     // [Appearance("fPurchaseReferencesalesorderitem", Enabled = true)]
     // [Appearance("fPurchaseReferencesalesorderitemVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(8)] 
     public  string salesorderitem
     { 
       get { return _salesorderitem; } 
       set { SetPropertyValue(nameof(salesorderitem), ref _salesorderitem, value); } 
     } 
     // 
     // Notes for fPurchaseReference : 
     private bool _schdlagree; 
     [XafDisplayName("Scheduling Agreements"), ToolTip("Scheduling Agreements")] 
     // [Appearance("fPurchaseReferenceschdlagree", Enabled = true)]
     // [Appearance("fPurchaseReferenceschdlagreeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool schdlagree
     { 
       get { return _schdlagree; } 
       set { SetPropertyValue(nameof(schdlagree), ref _schdlagree, value); } 
     } 
     // 
     // Notes for fPurchaseReference : 
     private string _scopelist; 
     [XafDisplayName("Scope of List"), ToolTip("Scope of List")] 
     // [Appearance("fPurchaseReferencescopelist", Enabled = true)]
     // [Appearance("fPurchaseReferencescopelistVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string scopelist
     { 
       get { return _scopelist; } 
       set { SetPropertyValue(nameof(scopelist), ref _scopelist, value); } 
     } 
     // 
     // Notes for fPurchaseReference : 
     private string _supplyplant; 
     [XafDisplayName("Supplying Plant"), ToolTip("Supplying Plant")] 
     // [Appearance("fPurchaseReferencesupplyplant", Enabled = true)]
     // [Appearance("fPurchaseReferencesupplyplantVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string supplyplant
     { 
       get { return _supplyplant; } 
       set { SetPropertyValue(nameof(supplyplant), ref _supplyplant, value); } 
     } 
     // 
     // Notes for fPurchaseReference : 
     private fVendor _to; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fPurchaseReferenceto", Enabled = true)]
     // [Appearance("fPurchaseReferencetoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fVendor to
     { 
       get { return _to; } 
       set { SetPropertyValue(nameof(to), ref _to, value); } 
     } 
     // 
     // Notes for fPurchaseReference : 
     private string _to1; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fPurchaseReferenceto1", Enabled = true)]
     // [Appearance("fPurchaseReferenceto1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string to1
     { 
       get { return _to1; } 
       set { SetPropertyValue(nameof(to1), ref _to1, value); } 
     } 
     // 
     // Notes for fPurchaseReference : 
     private string _to2; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fPurchaseReferenceto2", Enabled = true)]
     // [Appearance("fPurchaseReferenceto2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string to2
     { 
       get { return _to2; } 
       set { SetPropertyValue(nameof(to2), ref _to2, value); } 
     } 
     // 
     // Notes for fPurchaseReference : 
     private string _to3; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fPurchaseReferenceto3", Enabled = true)]
     // [Appearance("fPurchaseReferenceto3Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string to3
     { 
       get { return _to3; } 
       set { SetPropertyValue(nameof(to3), ref _to3, value); } 
     } 
     // 
     // Notes for fPurchaseReference : 
     private string _to4; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fPurchaseReferenceto4", Enabled = true)]
     // [Appearance("fPurchaseReferenceto4Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string to4
     { 
       get { return _to4; } 
       set { SetPropertyValue(nameof(to4), ref _to4, value); } 
     } 
     // 
     // Notes for fPurchaseReference : 
     private string _to5; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fPurchaseReferenceto5", Enabled = true)]
     // [Appearance("fPurchaseReferenceto5Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string to5
     { 
       get { return _to5; } 
       set { SetPropertyValue(nameof(to5), ref _to5, value); } 
     } 
     // 
     // Notes for fPurchaseReference : 
     private DateTime _to6; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fPurchaseReferenceto6", Enabled = true)]
     // [Appearance("fPurchaseReferenceto6Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime to6
     { 
       get { return _to6; } 
       set { SetPropertyValue(nameof(to6), ref _to6, value); } 
     } 
     // 
     // Notes for fPurchaseReference : 
     private DateTime _to7; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fPurchaseReferenceto7", Enabled = true)]
     // [Appearance("fPurchaseReferenceto7Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime to7
     { 
       get { return _to7; } 
       set { SetPropertyValue(nameof(to7), ref _to7, value); } 
     } 
     // 
     // Notes for fPurchaseReference : 
     private string _to8; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fPurchaseReferenceto8", Enabled = true)]
     // [Appearance("fPurchaseReferenceto8Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string to8
     { 
       get { return _to8; } 
       set { SetPropertyValue(nameof(to8), ref _to8, value); } 
     } 
     // 
     // Notes for fPurchaseReference : 
     private string _to9; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fPurchaseReferenceto9", Enabled = true)]
     // [Appearance("fPurchaseReferenceto9Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string to9
     { 
       get { return _to9; } 
       set { SetPropertyValue(nameof(to9), ref _to9, value); } 
     } 
     // 
     // Notes for fPurchaseReference : 
     private string _to10; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fPurchaseReferenceto10", Enabled = true)]
     // [Appearance("fPurchaseReferenceto10Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string to10
     { 
       get { return _to10; } 
       set { SetPropertyValue(nameof(to10), ref _to10, value); } 
     } 
     // 
     // Notes for fPurchaseReference : 
     private string _to11; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fPurchaseReferenceto11", Enabled = true)]
     // [Appearance("fPurchaseReferenceto11Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string to11
     { 
       get { return _to11; } 
       set { SetPropertyValue(nameof(to11), ref _to11, value); } 
     } 
     // 
     // Notes for fPurchaseReference : 
     private string _to12; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fPurchaseReferenceto12", Enabled = true)]
     // [Appearance("fPurchaseReferenceto12Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string to12
     { 
       get { return _to12; } 
       set { SetPropertyValue(nameof(to12), ref _to12, value); } 
     } 
     // 
     // Notes for fPurchaseReference : 
     private string _to13; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fPurchaseReferenceto13", Enabled = true)]
     // [Appearance("fPurchaseReferenceto13Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string to13
     { 
       get { return _to13; } 
       set { SetPropertyValue(nameof(to13), ref _to13, value); } 
     } 
     // 
     // Notes for fPurchaseReference : 
     private string _to14; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fPurchaseReferenceto14", Enabled = true)]
     // [Appearance("fPurchaseReferenceto14Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string to14
     { 
       get { return _to14; } 
       set { SetPropertyValue(nameof(to14), ref _to14, value); } 
     } 
     // 
     // Notes for fPurchaseReference : 
     private string _to15; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fPurchaseReferenceto15", Enabled = true)]
     // [Appearance("fPurchaseReferenceto15Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string to15
     { 
       get { return _to15; } 
       set { SetPropertyValue(nameof(to15), ref _to15, value); } 
     } 
     // 
     // Notes for fPurchaseReference : 
     private string _to16; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fPurchaseReferenceto16", Enabled = true)]
     // [Appearance("fPurchaseReferenceto16Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(8)] 
     public  string to16
     { 
       get { return _to16; } 
       set { SetPropertyValue(nameof(to16), ref _to16, value); } 
     } 
     // 
     // Notes for fPurchaseReference : 
     private string _to26; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fPurchaseReferenceto26", Enabled = true)]
     // [Appearance("fPurchaseReferenceto26Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string to26
     { 
       get { return _to26; } 
       set { SetPropertyValue(nameof(to26), ref _to26, value); } 
     } 
     // 
     // Notes for fPurchaseReference : 
     private string _to27; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fPurchaseReferenceto27", Enabled = true)]
     // [Appearance("fPurchaseReferenceto27Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string to27
     { 
       get { return _to27; } 
       set { SetPropertyValue(nameof(to27), ref _to27, value); } 
     } 
     // 
     // Notes for fPurchaseReference : 
     private fVendor _vendor; 
     [XafDisplayName("Vendor"), ToolTip("Vendor")] 
     // [Appearance("fPurchaseReferencevendor", Enabled = true)]
     // [Appearance("fPurchaseReferencevendorVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fVendor vendor
     { 
       get { return _vendor; } 
       set { SetPropertyValue(nameof(vendor), ref _vendor, value); } 
     } 
     // 
     // Notes for fPurchaseReference : 
     private string _wbselements; 
     [XafDisplayName("WBS Element"), ToolTip("WBS Element")] 
     // [Appearance("fPurchaseReferencewbselements", Enabled = true)]
     // [Appearance("fPurchaseReferencewbselementsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string wbselements
     { 
       get { return _wbselements; } 
       set { SetPropertyValue(nameof(wbselements), ref _wbselements, value); } 
     } 
   } 
} 
