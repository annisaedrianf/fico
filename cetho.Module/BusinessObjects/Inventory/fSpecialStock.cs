// Class Name : fSpecialStock.cs 
// Project Name : FICO 
// Last Update : 08/06/2023 13:14:08  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 08/06/2023 13:14:08 
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
   [System.ComponentModel.DisplayName("Consignment and Pipiline Settlement")]
   public class fSpecialStock : XPObject
   {
     public fSpecialStock(Session session) : base(session) 
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
     [Appearance("VisiblefSpecialStockOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // Display Options
     // Notes for fSpecialStock : 
     private string _docnumb; 
     [XafDisplayName("Document Number"), ToolTip("Document Number")] 
     // [Appearance("fSpecialStockdocnumb", Enabled = true)]
     // [Appearance("fSpecialStockdocnumbVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string docnumb
     { 
       get { return _docnumb; } 
       set { SetPropertyValue(nameof(docnumb), ref _docnumb, value); } 
     } 
     // Display Options
     // Notes for fSpecialStock : 
     private string _layout; 
     [XafDisplayName("Layout"), ToolTip("Layout")] 
     // [Appearance("fSpecialStocklayout", Enabled = true)]
     // [Appearance("fSpecialStocklayoutVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(15)] 
     public  string layout
     { 
       get { return _layout; } 
       set { SetPropertyValue(nameof(layout), ref _layout, value); } 
     } 
     // Display Options
     // Notes for fSpecialStock : 
     private bool _settlewithdraw; 
     [XafDisplayName("Setteled wirthdrawls"), ToolTip("Setteled wirthdrawls")] 
     // [Appearance("fSpecialStocksettlewithdraw", Enabled = true)]
     // [Appearance("fSpecialStocksettlewithdrawVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool settlewithdraw
     { 
       get { return _settlewithdraw; } 
       set { SetPropertyValue(nameof(settlewithdraw), ref _settlewithdraw, value); } 
     } 
     // Display Options
     // Notes for fSpecialStock : 
     private string _to7; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fSpecialStockto7", Enabled = true)]
     // [Appearance("fSpecialStockto7Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string to7
     { 
       get { return _to7; } 
       set { SetPropertyValue(nameof(to7), ref _to7, value); } 
     } 
     // Display Options
     // Notes for fSpecialStock : 
     private bool _withdrawnotsettle; 
     [XafDisplayName("Withdrawals not settled"), ToolTip("Withdrawals not settled")] 
     // [Appearance("fSpecialStockwithdrawnotsettle", Enabled = true)]
     // [Appearance("fSpecialStockwithdrawnotsettleVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool withdrawnotsettle
     { 
       get { return _withdrawnotsettle; } 
       set { SetPropertyValue(nameof(withdrawnotsettle), ref _withdrawnotsettle, value); } 
     } 
     // General
     // Notes for fSpecialStock : 
     private string _billlading; 
     [XafDisplayName("Bill of Lading"), ToolTip("Bill of Lading")] 
     // [Appearance("fSpecialStockbilllading", Enabled = true)]
     // [Appearance("fSpecialStockbillladingVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string billlading
     { 
       get { return _billlading; } 
       set { SetPropertyValue(nameof(billlading), ref _billlading, value); } 
     } 
     // General
     // Notes for fSpecialStock : 
     private string _delivnote; 
     [XafDisplayName("Delivery Note"), ToolTip("Delivery Note")] 
     // [Appearance("fSpecialStockdelivnote", Enabled = true)]
     // [Appearance("fSpecialStockdelivnoteVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string delivnote
     { 
       get { return _delivnote; } 
       set { SetPropertyValue(nameof(delivnote), ref _delivnote, value); } 
     } 
     // General
     // Notes for fSpecialStock : 
     private DateTime _docdate; 
     [XafDisplayName("Document Date"), ToolTip("Document Date")] 
     // [Appearance("fSpecialStockdocdate", Enabled = true)]
     // [Appearance("fSpecialStockdocdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime docdate
     { 
       get { return _docdate; } 
       set { SetPropertyValue(nameof(docdate), ref _docdate, value); } 
     } 
     // General
     // Notes for fSpecialStock : 
     private DateTime _docdate1; 
     [XafDisplayName("Document Date 2"), ToolTip("Document Date 2")] 
     // [Appearance("fSpecialStockdocdate1", Enabled = true)]
     // [Appearance("fSpecialStockdocdate1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime docdate1
     { 
       get { return _docdate1; } 
       set { SetPropertyValue(nameof(docdate1), ref _docdate1, value); } 
     } 
     // General
     // Notes for fSpecialStock : 
     private string _docheadtext; 
     [XafDisplayName("Doc. Header Text"), ToolTip("Doc. Header Text")] 
     // [Appearance("fSpecialStockdocheadtext", Enabled = true)]
     // [Appearance("fSpecialStockdocheadtextVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string docheadtext
     { 
       get { return _docheadtext; } 
       set { SetPropertyValue(nameof(docheadtext), ref _docheadtext, value); } 
     } 
     // General
     // Notes for fSpecialStock : 
     private string _headtext; 
     [XafDisplayName("Header Text"), ToolTip("Header Text")] 
     // [Appearance("fSpecialStockheadtext", Enabled = true)]
     // [Appearance("fSpecialStockheadtextVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string headtext
     { 
       get { return _headtext; } 
       set { SetPropertyValue(nameof(headtext), ref _headtext, value); } 
     } 
     // General
     // Notes for fSpecialStock : 
     private string _matslip; 
     [XafDisplayName("Material Slip"), ToolTip("Material Slip")] 
     // [Appearance("fSpecialStockmatslip", Enabled = true)]
     // [Appearance("fSpecialStockmatslipVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string matslip
     { 
       get { return _matslip; } 
       set { SetPropertyValue(nameof(matslip), ref _matslip, value); } 
     } 
     // General
     // Notes for fSpecialStock : 
     private DateTime _postdate; 
     [XafDisplayName("Posting Date"), ToolTip("Posting Date")] 
     // [Appearance("fSpecialStockpostdate", Enabled = true)]
     // [Appearance("fSpecialStockpostdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime postdate
     { 
       get { return _postdate; } 
       set { SetPropertyValue(nameof(postdate), ref _postdate, value); } 
     } 
     // General
     // Notes for fSpecialStock : 
     private DateTime _postdate2; 
     [XafDisplayName("Posting Date 2"), ToolTip("Posting Date 2")] 
     // [Appearance("fSpecialStockpostdate2", Enabled = true)]
     // [Appearance("fSpecialStockpostdate2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime postdate2
     { 
       get { return _postdate2; } 
       set { SetPropertyValue(nameof(postdate2), ref _postdate2, value); } 
     } 
     // General
     // Notes for fSpecialStock : 
     private fVendor _vendor; 
     [XafDisplayName("Vendor"), ToolTip("Vendor")] 
     // [Appearance("fSpecialStockvendor", Enabled = true)]
     // [Appearance("fSpecialStockvendorVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fVendor vendor
     { 
       get { return _vendor; } 
       set { SetPropertyValue(nameof(vendor), ref _vendor, value); } 
     } 
     // List Ouput
     // Notes for fSpecialStock : 
     private bool _dsplyzeroline; 
     [XafDisplayName("Display Zero Lines"), ToolTip("Display Zero Lines")] 
     // [Appearance("fSpecialStockdsplyzeroline", Enabled = true)]
     // [Appearance("fSpecialStockdsplyzerolineVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool dsplyzeroline
     { 
       get { return _dsplyzeroline; } 
       set { SetPropertyValue(nameof(dsplyzeroline), ref _dsplyzeroline, value); } 
     } 
     // List Ouput
     // Notes for fSpecialStock : 
     private bool _grpbatch; 
     [XafDisplayName("Group by Batches"), ToolTip("Group by Batches")] 
     // [Appearance("fSpecialStockgrpbatch", Enabled = true)]
     // [Appearance("fSpecialStockgrpbatchVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool grpbatch
     { 
       get { return _grpbatch; } 
       set { SetPropertyValue(nameof(grpbatch), ref _grpbatch, value); } 
     } 
     // List Ouput
     // Notes for fSpecialStock : 
     private bool _scstcksshortage; 
     [XafDisplayName("Only SC Stocks with Shortage"), ToolTip("Only SC Stocks with Shortage")] 
     // [Appearance("fSpecialStockscstcksshortage", Enabled = true)]
     // [Appearance("fSpecialStockscstcksshortageVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool scstcksshortage
     { 
       get { return _scstcksshortage; } 
       set { SetPropertyValue(nameof(scstcksshortage), ref _scstcksshortage, value); } 
     } 
     // Material Data
     // Notes for fSpecialStock : 
     private string _batch; 
     [XafDisplayName("Batch"), ToolTip("Batch")] 
     // [Appearance("fSpecialStockbatch", Enabled = true)]
     // [Appearance("fSpecialStockbatchVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string batch
     { 
       get { return _batch; } 
       set { SetPropertyValue(nameof(batch), ref _batch, value); } 
     } 
     // Material Data
     // Notes for fSpecialStock : 
     private string _ean; 
     [XafDisplayName("EAN/UPC"), ToolTip("EAN/UPC")] 
     // [Appearance("fSpecialStockean", Enabled = true)]
     // [Appearance("fSpecialStockeanVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string ean
     { 
       get { return _ean; } 
       set { SetPropertyValue(nameof(ean), ref _ean, value); } 
     } 
     // Material Data
     // Notes for fSpecialStock : 
     private bool _infoupdt; 
     [XafDisplayName("Info Update"), ToolTip("Info Update")] 
     // [Appearance("fSpecialStockinfoupdt", Enabled = true)]
     // [Appearance("fSpecialStockinfoupdtVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool infoupdt
     { 
       get { return _infoupdt; } 
       set { SetPropertyValue(nameof(infoupdt), ref _infoupdt, value); } 
     } 
     // Material Data
     // Notes for fSpecialStock : 
     private string _matgrp; 
     [XafDisplayName("Material group"), ToolTip("Material group")] 
     // [Appearance("fSpecialStockmatgrp", Enabled = true)]
     // [Appearance("fSpecialStockmatgrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string matgrp
     { 
       get { return _matgrp; } 
       set { SetPropertyValue(nameof(matgrp), ref _matgrp, value); } 
     } 
     // Material Data
     // Notes for fSpecialStock : 
     private string _revisionlvl; 
     [XafDisplayName("Revision Level"), ToolTip("Revision Level")] 
     // [Appearance("fSpecialStockrevisionlvl", Enabled = true)]
     // [Appearance("fSpecialStockrevisionlvlVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string revisionlvl
     { 
       get { return _revisionlvl; } 
       set { SetPropertyValue(nameof(revisionlvl), ref _revisionlvl, value); } 
     } 
     // Material Data
     // Notes for fSpecialStock : 
     private fVendor _vendorbatch; 
     [XafDisplayName("Vendor Batch"), ToolTip("Vendor Batch")] 
     // [Appearance("fSpecialStockvendorbatch", Enabled = true)]
     // [Appearance("fSpecialStockvendorbatchVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fVendor vendorbatch
     { 
       get { return _vendorbatch; } 
       set { SetPropertyValue(nameof(vendorbatch), ref _vendorbatch, value); } 
     } 
     // Material Data
     // Notes for fSpecialStock : 
     private fVendor _vendormatno; 
     [XafDisplayName("Vendor mat. No."), ToolTip("Vendor mat. No.")] 
     // [Appearance("fSpecialStockvendormatno", Enabled = true)]
     // [Appearance("fSpecialStockvendormatnoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fVendor vendormatno
     { 
       get { return _vendormatno; } 
       set { SetPropertyValue(nameof(vendormatno), ref _vendormatno, value); } 
     } 
     // Material Data
     // Notes for fSpecialStock : 
     private fVendor _vendorsubrange; 
     [XafDisplayName("Vendor sub-range"), ToolTip("Vendor sub-range")] 
     // [Appearance("fSpecialStockvendorsubrange", Enabled = true)]
     // [Appearance("fSpecialStockvendorsubrangeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fVendor vendorsubrange
     { 
       get { return _vendorsubrange; } 
       set { SetPropertyValue(nameof(vendorsubrange), ref _vendorsubrange, value); } 
     } 
     // Org. Data
     // Notes for fSpecialStock : 
     private fCompany _compcode1; 
     [XafDisplayName("Company Code "), ToolTip("Company Code ")] 
     // [Appearance("fSpecialStockcompcode1", Enabled = true)]
     // [Appearance("fSpecialStockcompcode1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCompany compcode1
     { 
       get { return _compcode1; } 
       set { SetPropertyValue(nameof(compcode1), ref _compcode1, value); } 
     } 
     // Org. Data
     // Notes for fSpecialStock : 
     private string _purchgrp; 
     [XafDisplayName("Purch. Group"), ToolTip("Purch. Group")] 
     // [Appearance("fSpecialStockpurchgrp", Enabled = true)]
     // [Appearance("fSpecialStockpurchgrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string purchgrp
     { 
       get { return _purchgrp; } 
       set { SetPropertyValue(nameof(purchgrp), ref _purchgrp, value); } 
     } 
     // Org. Data
     // Notes for fSpecialStock : 
     private string _purchorg; 
     [XafDisplayName("Purch. Org."), ToolTip("Purch. Org.")] 
     // [Appearance("fSpecialStockpurchorg", Enabled = true)]
     // [Appearance("fSpecialStockpurchorgVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string purchorg
     { 
       get { return _purchorg; } 
       set { SetPropertyValue(nameof(purchorg), ref _purchorg, value); } 
     } 
     // Post Goods Issue
     // Notes for fSpecialStock : 
     private string _batch1; 
     [XafDisplayName("Batch "), ToolTip("Batch ")] 
     // [Appearance("fSpecialStockbatch1", Enabled = true)]
     // [Appearance("fSpecialStockbatch1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string batch1
     { 
       get { return _batch1; } 
       set { SetPropertyValue(nameof(batch1), ref _batch1, value); } 
     } 
     // Post Goods Issue
     // Notes for fSpecialStock : 
     private string _mat2; 
     [XafDisplayName("Material "), ToolTip("Material ")] 
     // [Appearance("fSpecialStockmat2", Enabled = true)]
     // [Appearance("fSpecialStockmat2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string mat2
     { 
       get { return _mat2; } 
       set { SetPropertyValue(nameof(mat2), ref _mat2, value); } 
     } 
     // Post Goods Issue
     // Notes for fSpecialStock : 
     private string _movetype1; 
     [XafDisplayName("Movement Type "), ToolTip("Movement Type ")] 
     // [Appearance("fSpecialStockmovetype1", Enabled = true)]
     // [Appearance("fSpecialStockmovetype1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string movetype1
     { 
       get { return _movetype1; } 
       set { SetPropertyValue(nameof(movetype1), ref _movetype1, value); } 
     } 
     // Post Goods Issue
     // Notes for fSpecialStock : 
     private string _plant3; 
     [XafDisplayName("Plant "), ToolTip("Plant ")] 
     // [Appearance("fSpecialStockplant3", Enabled = true)]
     // [Appearance("fSpecialStockplant3Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string plant3
     { 
       get { return _plant3; } 
       set { SetPropertyValue(nameof(plant3), ref _plant3, value); } 
     } 
     // Post Goods Issue
     // Notes for fSpecialStock : 
     private string _qty1; 
     [XafDisplayName("Quantity "), ToolTip("Quantity ")] 
     // [Appearance("fSpecialStockqty1", Enabled = true)]
     // [Appearance("fSpecialStockqty1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string qty1
     { 
       get { return _qty1; } 
       set { SetPropertyValue(nameof(qty1), ref _qty1, value); } 
     } 
     // Post Goods Issue
     // Notes for fSpecialStock : 
     private string _stroloc2; 
     [XafDisplayName("Stor. Location "), ToolTip("Stor. Location ")] 
     // [Appearance("fSpecialStockstroloc2", Enabled = true)]
     // [Appearance("fSpecialStockstroloc2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string stroloc2
     { 
       get { return _stroloc2; } 
       set { SetPropertyValue(nameof(stroloc2), ref _stroloc2, value); } 
     } 
     // Post Goods Issue
     // Notes for fSpecialStock : 
     private fVendor _vendor3; 
     [XafDisplayName("Vendor "), ToolTip("Vendor ")] 
     // [Appearance("fSpecialStockvendor3", Enabled = true)]
     // [Appearance("fSpecialStockvendor3Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fVendor vendor3
     { 
       get { return _vendor3; } 
       set { SetPropertyValue(nameof(vendor3), ref _vendor3, value); } 
     } 
     // Processing
     // Notes for fSpecialStock : 
     private bool _display; 
     [XafDisplayName("Display"), ToolTip("Display")] 
     // [Appearance("fSpecialStockdisplay", Enabled = true)]
     // [Appearance("fSpecialStockdisplayVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool display
     { 
       get { return _display; } 
       set { SetPropertyValue(nameof(display), ref _display, value); } 
     } 
     // Processing
     // Notes for fSpecialStock : 
     private bool _settle; 
     [XafDisplayName("Settle"), ToolTip("Settle")] 
     // [Appearance("fSpecialStocksettle", Enabled = true)]
     // [Appearance("fSpecialStocksettleVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool settle
     { 
       get { return _settle; } 
       set { SetPropertyValue(nameof(settle), ref _settle, value); } 
     } 
     // Processing Components: Component Overview
     // Notes for fSpecialStock : 
     private DateTime _delivdate; 
     [XafDisplayName("Delivery date"), ToolTip("Delivery date")] 
     // [Appearance("fSpecialStockdelivdate", Enabled = true)]
     // [Appearance("fSpecialStockdelivdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime delivdate
     { 
       get { return _delivdate; } 
       set { SetPropertyValue(nameof(delivdate), ref _delivdate, value); } 
     } 
     // Processing Components: Component Overview
     // Notes for fSpecialStock : 
     private string _mat1; 
     [XafDisplayName("Material"), ToolTip("Material")] 
     // [Appearance("fSpecialStockmat1", Enabled = true)]
     // [Appearance("fSpecialStockmat1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string mat1
     { 
       get { return _mat1; } 
       set { SetPropertyValue(nameof(mat1), ref _mat1, value); } 
     } 
     // Processing Components: Component Overview
     // Notes for fSpecialStock : 
     private string _plant5; 
     [XafDisplayName("Plant "), ToolTip("Plant ")] 
     // [Appearance("fSpecialStockplant5", Enabled = true)]
     // [Appearance("fSpecialStockplant5Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string plant5
     { 
       get { return _plant5; } 
       set { SetPropertyValue(nameof(plant5), ref _plant5, value); } 
     } 
     // Processing Components: Component Overview
     // Notes for fSpecialStock : 
     private double _qty; 
     [XafDisplayName("Quantity"), ToolTip("Quantity")] 
     // [Appearance("fSpecialStockqty", Enabled = true)]
     // [Appearance("fSpecialStockqtyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double qty
     { 
       get { return _qty; } 
       set { SetPropertyValue(nameof(qty), ref _qty, value); } 
     } 
     // Processing Components: Component Overview
     // Notes for fSpecialStock : 
     private DateTime _releasedate; 
     [XafDisplayName("Release Date"), ToolTip("Release Date")] 
     // [Appearance("fSpecialStockreleasedate", Enabled = true)]
     // [Appearance("fSpecialStockreleasedateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime releasedate
     { 
       get { return _releasedate; } 
       set { SetPropertyValue(nameof(releasedate), ref _releasedate, value); } 
     } 
     // Selection
     // Notes for fSpecialStock : 
     private fCompany _compcode; 
     [XafDisplayName("Company Code"), ToolTip("Company Code")] 
     // [Appearance("fSpecialStockcompcode", Enabled = true)]
     // [Appearance("fSpecialStockcompcodeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCompany compcode
     { 
       get { return _compcode; } 
       set { SetPropertyValue(nameof(compcode), ref _compcode, value); } 
     } 
     // Selection
     // Notes for fSpecialStock : 
     private bool _consignment; 
     [XafDisplayName("Consignment"), ToolTip("Consignment")] 
     // [Appearance("fSpecialStockconsignment", Enabled = true)]
     // [Appearance("fSpecialStockconsignmentVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool consignment
     { 
       get { return _consignment; } 
       set { SetPropertyValue(nameof(consignment), ref _consignment, value); } 
     } 
     // Selection
     // Notes for fSpecialStock : 
     private DateTime _docdate2; 
     [XafDisplayName("Document Date "), ToolTip("Document Date ")] 
     // [Appearance("fSpecialStockdocdate2", Enabled = true)]
     // [Appearance("fSpecialStockdocdate2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime docdate2
     { 
       get { return _docdate2; } 
       set { SetPropertyValue(nameof(docdate2), ref _docdate2, value); } 
     } 
     // Selection
     // Notes for fSpecialStock : 
     private string _mat; 
     [XafDisplayName("Material "), ToolTip("Material ")] 
     // [Appearance("fSpecialStockmat", Enabled = true)]
     // [Appearance("fSpecialStockmatVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string mat
     { 
       get { return _mat; } 
       set { SetPropertyValue(nameof(mat), ref _mat, value); } 
     } 
     // Selection
     // Notes for fSpecialStock : 
     private string _matdoc; 
     [XafDisplayName("Material Document"), ToolTip("Material Document")] 
     // [Appearance("fSpecialStockmatdoc", Enabled = true)]
     // [Appearance("fSpecialStockmatdocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string matdoc
     { 
       get { return _matdoc; } 
       set { SetPropertyValue(nameof(matdoc), ref _matdoc, value); } 
     } 
     // Selection
     // Notes for fSpecialStock : 
     private string _material; 
     [XafDisplayName("Material"), ToolTip("Material")] 
     // [Appearance("fSpecialStockmaterial", Enabled = true)]
     // [Appearance("fSpecialStockmaterialVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string material
     { 
       get { return _material; } 
       set { SetPropertyValue(nameof(material), ref _material, value); } 
     } 
     // Selection
     // Notes for fSpecialStock : 
     private string _mattype; 
     [XafDisplayName("Material Type"), ToolTip("Material Type")] 
     // [Appearance("fSpecialStockmattype", Enabled = true)]
     // [Appearance("fSpecialStockmattypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string mattype
     { 
       get { return _mattype; } 
       set { SetPropertyValue(nameof(mattype), ref _mattype, value); } 
     } 
     // Selection
     // Notes for fSpecialStock : 
     private bool _pipeline; 
     [XafDisplayName("Pipeline"), ToolTip("Pipeline")] 
     // [Appearance("fSpecialStockpipeline", Enabled = true)]
     // [Appearance("fSpecialStockpipelineVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool pipeline
     { 
       get { return _pipeline; } 
       set { SetPropertyValue(nameof(pipeline), ref _pipeline, value); } 
     } 
     // Selection
     // Notes for fSpecialStock : 
     private string _plant1; 
     [XafDisplayName("Plant "), ToolTip("Plant ")] 
     // [Appearance("fSpecialStockplant1", Enabled = true)]
     // [Appearance("fSpecialStockplant1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string plant1
     { 
       get { return _plant1; } 
       set { SetPropertyValue(nameof(plant1), ref _plant1, value); } 
     } 
     // Selection
     // Notes for fSpecialStock : 
     private DateTime _postdate1; 
     [XafDisplayName("Posting Date "), ToolTip("Posting Date ")] 
     // [Appearance("fSpecialStockpostdate1", Enabled = true)]
     // [Appearance("fSpecialStockpostdate1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime postdate1
     { 
       get { return _postdate1; } 
       set { SetPropertyValue(nameof(postdate1), ref _postdate1, value); } 
     } 
     // Selection
     // Notes for fSpecialStock : 
     private fCompany _to; 
     [XafDisplayName("to "), ToolTip("to ")] 
     // [Appearance("fSpecialStockto", Enabled = true)]
     // [Appearance("fSpecialStocktoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCompany to
     { 
       get { return _to; } 
       set { SetPropertyValue(nameof(to), ref _to, value); } 
     } 
     // Selection
     // Notes for fSpecialStock : 
     private fVendor _to1; 
     [XafDisplayName("to "), ToolTip("to ")] 
     // [Appearance("fSpecialStockto1", Enabled = true)]
     // [Appearance("fSpecialStockto1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fVendor to1
     { 
       get { return _to1; } 
       set { SetPropertyValue(nameof(to1), ref _to1, value); } 
     } 
     // Selection
     // Notes for fSpecialStock : 
     private string _to2; 
     [XafDisplayName("to "), ToolTip("to ")] 
     // [Appearance("fSpecialStockto2", Enabled = true)]
     // [Appearance("fSpecialStockto2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string to2
     { 
       get { return _to2; } 
       set { SetPropertyValue(nameof(to2), ref _to2, value); } 
     } 
     // Selection
     // Notes for fSpecialStock : 
     private string _to3; 
     [XafDisplayName("to "), ToolTip("to ")] 
     // [Appearance("fSpecialStockto3", Enabled = true)]
     // [Appearance("fSpecialStockto3Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string to3
     { 
       get { return _to3; } 
       set { SetPropertyValue(nameof(to3), ref _to3, value); } 
     } 
     // Selection
     // Notes for fSpecialStock : 
     private DateTime _to4; 
     [XafDisplayName("to "), ToolTip("to ")] 
     // [Appearance("fSpecialStockto4", Enabled = true)]
     // [Appearance("fSpecialStockto4Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime to4
     { 
       get { return _to4; } 
       set { SetPropertyValue(nameof(to4), ref _to4, value); } 
     } 
     // Selection
     // Notes for fSpecialStock : 
     private DateTime _to5; 
     [XafDisplayName("to "), ToolTip("to ")] 
     // [Appearance("fSpecialStockto5", Enabled = true)]
     // [Appearance("fSpecialStockto5Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime to5
     { 
       get { return _to5; } 
       set { SetPropertyValue(nameof(to5), ref _to5, value); } 
     } 
     // Selection
     // Notes for fSpecialStock : 
     private string _to6; 
     [XafDisplayName("to "), ToolTip("to ")] 
     // [Appearance("fSpecialStockto6", Enabled = true)]
     // [Appearance("fSpecialStockto6Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string to6
     { 
       get { return _to6; } 
       set { SetPropertyValue(nameof(to6), ref _to6, value); } 
     } 
     // Selection
     // Notes for fSpecialStock : 
     private string _uom; 
     [XafDisplayName("Unit of Measure"), ToolTip("Unit of Measure")] 
     // [Appearance("fSpecialStockuom", Enabled = true)]
     // [Appearance("fSpecialStockuomVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string uom
     { 
       get { return _uom; } 
       set { SetPropertyValue(nameof(uom), ref _uom, value); } 
     } 
     // Selection
     // Notes for fSpecialStock : 
     private fVendor _vendor1; 
     [XafDisplayName("Vendor "), ToolTip("Vendor ")] 
     // [Appearance("fSpecialStockvendor1", Enabled = true)]
     // [Appearance("fSpecialStockvendor1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fVendor vendor1
     { 
       get { return _vendor1; } 
       set { SetPropertyValue(nameof(vendor1), ref _vendor1, value); } 
     } 
     // Selection Criteria
     // Notes for fSpecialStock : 
     private string _assembly; 
     [XafDisplayName("Assembly"), ToolTip("Assembly")] 
     // [Appearance("fSpecialStockassembly", Enabled = true)]
     // [Appearance("fSpecialStockassemblyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string assembly
     { 
       get { return _assembly; } 
       set { SetPropertyValue(nameof(assembly), ref _assembly, value); } 
     } 
     // Selection Criteria
     // Notes for fSpecialStock : 
     private string _cmpntsprovide; 
     [XafDisplayName("Components Provided"), ToolTip("Components Provided")] 
     // [Appearance("fSpecialStockcmpntsprovide", Enabled = true)]
     // [Appearance("fSpecialStockcmpntsprovideVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string cmpntsprovide
     { 
       get { return _cmpntsprovide; } 
       set { SetPropertyValue(nameof(cmpntsprovide), ref _cmpntsprovide, value); } 
     } 
     // Selection Criteria
     // Notes for fSpecialStock : 
     private bool _extrecipt; 
     [XafDisplayName("W. Ext. Receipts from Requisns"), ToolTip("W. Ext. Receipts from Requisns")] 
     // [Appearance("fSpecialStockextrecipt", Enabled = true)]
     // [Appearance("fSpecialStockextreciptVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool extrecipt
     { 
       get { return _extrecipt; } 
       set { SetPropertyValue(nameof(extrecipt), ref _extrecipt, value); } 
     } 
     // Selection Criteria
     // Notes for fSpecialStock : 
     private string _plant2; 
     [XafDisplayName("Plant "), ToolTip("Plant ")] 
     // [Appearance("fSpecialStockplant2", Enabled = true)]
     // [Appearance("fSpecialStockplant2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string plant2
     { 
       get { return _plant2; } 
       set { SetPropertyValue(nameof(plant2), ref _plant2, value); } 
     } 
     // Selection Criteria
     // Notes for fSpecialStock : 
     private DateTime _reqdate; 
     [XafDisplayName("Reuqirement Date"), ToolTip("Reuqirement Date")] 
     // [Appearance("fSpecialStockreqdate", Enabled = true)]
     // [Appearance("fSpecialStockreqdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime reqdate
     { 
       get { return _reqdate; } 
       set { SetPropertyValue(nameof(reqdate), ref _reqdate, value); } 
     } 
     // Selection Criteria
     // Notes for fSpecialStock : 
     private fVendor _to8; 
     [XafDisplayName("to "), ToolTip("to ")] 
     // [Appearance("fSpecialStockto8", Enabled = true)]
     // [Appearance("fSpecialStockto8Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fVendor to8
     { 
       get { return _to8; } 
       set { SetPropertyValue(nameof(to8), ref _to8, value); } 
     } 
     // Selection Criteria
     // Notes for fSpecialStock : 
     private string _to9; 
     [XafDisplayName("to "), ToolTip("to ")] 
     // [Appearance("fSpecialStockto9", Enabled = true)]
     // [Appearance("fSpecialStockto9Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string to9
     { 
       get { return _to9; } 
       set { SetPropertyValue(nameof(to9), ref _to9, value); } 
     } 
     // Selection Criteria
     // Notes for fSpecialStock : 
     private string _to10; 
     [XafDisplayName("to "), ToolTip("to ")] 
     // [Appearance("fSpecialStockto10", Enabled = true)]
     // [Appearance("fSpecialStockto10Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string to10
     { 
       get { return _to10; } 
       set { SetPropertyValue(nameof(to10), ref _to10, value); } 
     } 
     // Selection Criteria
     // Notes for fSpecialStock : 
     private string _to11; 
     [XafDisplayName("to "), ToolTip("to ")] 
     // [Appearance("fSpecialStockto11", Enabled = true)]
     // [Appearance("fSpecialStockto11Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string to11
     { 
       get { return _to11; } 
       set { SetPropertyValue(nameof(to11), ref _to11, value); } 
     } 
     // Selection Criteria
     // Notes for fSpecialStock : 
     private DateTime _to12; 
     [XafDisplayName("to "), ToolTip("to ")] 
     // [Appearance("fSpecialStockto12", Enabled = true)]
     // [Appearance("fSpecialStockto12Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime to12
     { 
       get { return _to12; } 
       set { SetPropertyValue(nameof(to12), ref _to12, value); } 
     } 
     // Selection Criteria
     // Notes for fSpecialStock : 
     private fVendor _vendor2; 
     [XafDisplayName("Vendor "), ToolTip("Vendor ")] 
     // [Appearance("fSpecialStockvendor2", Enabled = true)]
     // [Appearance("fSpecialStockvendor2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fVendor vendor2
     { 
       get { return _vendor2; } 
       set { SetPropertyValue(nameof(vendor2), ref _vendor2, value); } 
     } 
     // Selection Criteria
     // Notes for fSpecialStock : 
     private bool _withextreciptpos; 
     [XafDisplayName("With Ext. Receipts from Pos"), ToolTip("With Ext. Receipts from Pos")] 
     // [Appearance("fSpecialStockwithextreciptpos", Enabled = true)]
     // [Appearance("fSpecialStockwithextreciptposVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool withextreciptpos
     { 
       get { return _withextreciptpos; } 
       set { SetPropertyValue(nameof(withextreciptpos), ref _withextreciptpos, value); } 
     } 
     // Selection Criteria
     // Notes for fSpecialStock : 
     private bool _withreqscrequires; 
     [XafDisplayName("With Reqts from SC Requires"), ToolTip("With Reqts from SC Requires")] 
     // [Appearance("fSpecialStockwithreqscrequires", Enabled = true)]
     // [Appearance("fSpecialStockwithreqscrequiresVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool withreqscrequires
     { 
       get { return _withreqscrequires; } 
       set { SetPropertyValue(nameof(withreqscrequires), ref _withreqscrequires, value); } 
     } 
     // Where
     // Notes for fSpecialStock : 
     private string _goodsrecipt; 
     [XafDisplayName("Goods recipient"), ToolTip("Goods recipient")] 
     // [Appearance("fSpecialStockgoodsrecipt", Enabled = true)]
     // [Appearance("fSpecialStockgoodsreciptVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string goodsrecipt
     { 
       get { return _goodsrecipt; } 
       set { SetPropertyValue(nameof(goodsrecipt), ref _goodsrecipt, value); } 
     } 
     // Where
     // Notes for fSpecialStock : 
     private string _movetype; 
     [XafDisplayName("Movement Type"), ToolTip("Movement Type")] 
     // [Appearance("fSpecialStockmovetype", Enabled = true)]
     // [Appearance("fSpecialStockmovetypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string movetype
     { 
       get { return _movetype; } 
       set { SetPropertyValue(nameof(movetype), ref _movetype, value); } 
     } 
     // Where
     // Notes for fSpecialStock : 
     private string _movetype2; 
     [XafDisplayName("Movement Type 2"), ToolTip("Movement Type 2")] 
     // [Appearance("fSpecialStockmovetype2", Enabled = true)]
     // [Appearance("fSpecialStockmovetype2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string movetype2
     { 
       get { return _movetype2; } 
       set { SetPropertyValue(nameof(movetype2), ref _movetype2, value); } 
     } 
     // Where
     // Notes for fSpecialStock : 
     private string _plant; 
     [XafDisplayName("Plant"), ToolTip("Plant")] 
     // [Appearance("fSpecialStockplant", Enabled = true)]
     // [Appearance("fSpecialStockplantVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string plant
     { 
       get { return _plant; } 
       set { SetPropertyValue(nameof(plant), ref _plant, value); } 
     } 
     // Where
     // Notes for fSpecialStock : 
     private string _plant4; 
     [XafDisplayName("Plant2"), ToolTip("Plant2")] 
     // [Appearance("fSpecialStockplant4", Enabled = true)]
     // [Appearance("fSpecialStockplant4Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string plant4
     { 
       get { return _plant4; } 
       set { SetPropertyValue(nameof(plant4), ref _plant4, value); } 
     } 
     // Where
     // Notes for fSpecialStock : 
     private enumStockType _stcktype; 
     [XafDisplayName("Stock Type"), ToolTip("Stock Type")] 
     // [Appearance("fSpecialStockstcktype", Enabled = true)]
     // [Appearance("fSpecialStockstcktypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumStockType stcktype
     { 
       get { return _stcktype; } 
       set { SetPropertyValue(nameof(stcktype), ref _stcktype, value); } 
     } 
     // Where
     // Notes for fSpecialStock : 
     private enumStockType _stcktype1; 
     [XafDisplayName("Stock Type"), ToolTip("Stock Type")] 
     // [Appearance("fSpecialStockstcktype1", Enabled = true)]
     // [Appearance("fSpecialStockstcktype1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumStockType stcktype1
     { 
       get { return _stcktype1; } 
       set { SetPropertyValue(nameof(stcktype1), ref _stcktype1, value); } 
     } 
     // Where
     // Notes for fSpecialStock : 
     private string _storloc; 
     [XafDisplayName("Storage Location"), ToolTip("Storage Location")] 
     // [Appearance("fSpecialStockstorloc", Enabled = true)]
     // [Appearance("fSpecialStockstorlocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string storloc
     { 
       get { return _storloc; } 
       set { SetPropertyValue(nameof(storloc), ref _storloc, value); } 
     } 
     // Where
     // Notes for fSpecialStock : 
     private string _storloc1; 
     [XafDisplayName("Storage Location"), ToolTip("Storage Location")] 
     // [Appearance("fSpecialStockstorloc1", Enabled = true)]
     // [Appearance("fSpecialStockstorloc1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string storloc1
     { 
       get { return _storloc1; } 
       set { SetPropertyValue(nameof(storloc1), ref _storloc1, value); } 
     } 
     // Where
     // Notes for fSpecialStock : 
     private string _unloadpoint; 
     [XafDisplayName("Unloading Point"), ToolTip("Unloading Point")] 
     // [Appearance("fSpecialStockunloadpoint", Enabled = true)]
     // [Appearance("fSpecialStockunloadpointVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(40)] 
     public  string unloadpoint
     { 
       get { return _unloadpoint; } 
       set { SetPropertyValue(nameof(unloadpoint), ref _unloadpoint, value); } 
     } 
   } 
} 
