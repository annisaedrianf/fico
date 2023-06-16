// Class Name : fReleaseInvoice.cs 
// Project Name : FICO 
// Last Update : 14/06/2023 12:57:15  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 14/06/2023 12:57:15 
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
   [System.ComponentModel.DisplayName("Release Blocked Invoices")]
   public class fReleaseInvoice : XPObject
   {
     public fReleaseInvoice(Session session) : base(session) 
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
     [Appearance("VisiblefReleaseInvoiceOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // Selection of Blocked Invoices
     // Notes for fReleaseInvoice : 
     private fCompany _compcode; 
     [XafDisplayName("Company Code"), ToolTip("Company Code")] 
     // [Appearance("fReleaseInvoicecompcode", Enabled = true)]
     // [Appearance("fReleaseInvoicecompcodeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCompany compcode
     { 
       get { return _compcode; } 
       set { SetPropertyValue(nameof(compcode), ref _compcode, value); } 
     } 
     // Selection of Blocked Invoices
     // Notes for fReleaseInvoice : 
     private fCompany _to1; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fReleaseInvoiceto1", Enabled = true)]
     // [Appearance("fReleaseInvoiceto1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCompany to1
     { 
       get { return _to1; } 
       set { SetPropertyValue(nameof(to1), ref _to1, value); } 
     } 
     // Selection of Blocked Invoices
     // Notes for fReleaseInvoice : 
     private string _invoicedoc; 
     [XafDisplayName("Invoice Document"), ToolTip("Invoice Document")] 
     // [Appearance("fReleaseInvoiceinvoicedoc", Enabled = true)]
     // [Appearance("fReleaseInvoiceinvoicedocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string invoicedoc
     { 
       get { return _invoicedoc; } 
       set { SetPropertyValue(nameof(invoicedoc), ref _invoicedoc, value); } 
     } 
     // Selection of Blocked Invoices
     // Notes for fReleaseInvoice : 
     private string _to2; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fReleaseInvoiceto2", Enabled = true)]
     // [Appearance("fReleaseInvoiceto2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string to2
     { 
       get { return _to2; } 
       set { SetPropertyValue(nameof(to2), ref _to2, value); } 
     } 
     // Selection of Blocked Invoices
     // Notes for fReleaseInvoice : 
     private string _fiscalyear; 
     [XafDisplayName("Fiscal Year"), ToolTip("Fiscal Year")] 
     // [Appearance("fReleaseInvoicefiscalyear", Enabled = true)]
     // [Appearance("fReleaseInvoicefiscalyearVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string fiscalyear
     { 
       get { return _fiscalyear; } 
       set { SetPropertyValue(nameof(fiscalyear), ref _fiscalyear, value); } 
     } 
     // Selection of Blocked Invoices
     // Notes for fReleaseInvoice : 
     private string _to3; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fReleaseInvoiceto3", Enabled = true)]
     // [Appearance("fReleaseInvoiceto3Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string to3
     { 
       get { return _to3; } 
       set { SetPropertyValue(nameof(to3), ref _to3, value); } 
     } 
     // Selection of Blocked Invoices
     // Notes for fReleaseInvoice : 
     private fVendor _vendor; 
     [XafDisplayName("Vendor"), ToolTip("Vendor")] 
     // [Appearance("fReleaseInvoicevendor", Enabled = true)]
     // [Appearance("fReleaseInvoicevendorVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fVendor vendor
     { 
       get { return _vendor; } 
       set { SetPropertyValue(nameof(vendor), ref _vendor, value); } 
     } 
     // Selection of Blocked Invoices
     // Notes for fReleaseInvoice : 
     private fVendor _to4; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fReleaseInvoiceto4", Enabled = true)]
     // [Appearance("fReleaseInvoiceto4Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fVendor to4
     { 
       get { return _to4; } 
       set { SetPropertyValue(nameof(to4), ref _to4, value); } 
     } 
     // Selection of Blocked Invoices
     // Notes for fReleaseInvoice : 
     private DateTime _postdate; 
     [XafDisplayName("Posting Date "), ToolTip("Posting Date ")] 
     // [Appearance("fReleaseInvoicepostdate", Enabled = true)]
     // [Appearance("fReleaseInvoicepostdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime postdate
     { 
       get { return _postdate; } 
       set { SetPropertyValue(nameof(postdate), ref _postdate, value); } 
     } 
     // Selection of Blocked Invoices
     // Notes for fReleaseInvoice : 
     private DateTime _to5; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fReleaseInvoiceto5", Enabled = true)]
     // [Appearance("fReleaseInvoiceto5Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime to5
     { 
       get { return _to5; } 
       set { SetPropertyValue(nameof(to5), ref _to5, value); } 
     } 
     // Selection of Blocked Invoices
     // Notes for fReleaseInvoice : 
     private DateTime _duedate; 
     [XafDisplayName("Due Date"), ToolTip("Due Date")] 
     // [Appearance("fReleaseInvoiceduedate", Enabled = true)]
     // [Appearance("fReleaseInvoiceduedateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime duedate
     { 
       get { return _duedate; } 
       set { SetPropertyValue(nameof(duedate), ref _duedate, value); } 
     } 
     // Selection of Blocked Invoices
     // Notes for fReleaseInvoice : 
     private DateTime _to6; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fReleaseInvoiceto6", Enabled = true)]
     // [Appearance("fReleaseInvoiceto6Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime to6
     { 
       get { return _to6; } 
       set { SetPropertyValue(nameof(to6), ref _to6, value); } 
     } 
     // Selection of Blocked Invoices
     // Notes for fReleaseInvoice : 
     private string _purchgroup; 
     [XafDisplayName("Purchasing Group"), ToolTip("Purchasing Group")] 
     // [Appearance("fReleaseInvoicepurchgroup", Enabled = true)]
     // [Appearance("fReleaseInvoicepurchgroupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string purchgroup
     { 
       get { return _purchgroup; } 
       set { SetPropertyValue(nameof(purchgroup), ref _purchgroup, value); } 
     } 
     // Selection of Blocked Invoices
     // Notes for fReleaseInvoice : 
     private string _to7; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fReleaseInvoiceto7", Enabled = true)]
     // [Appearance("fReleaseInvoiceto7Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string to7
     { 
       get { return _to7; } 
       set { SetPropertyValue(nameof(to7), ref _to7, value); } 
     } 
     // Selection of Blocked Invoices
     // Notes for fReleaseInvoice : 
     private string _user; 
     [XafDisplayName("User"), ToolTip("User")] 
     // [Appearance("fReleaseInvoiceuser", Enabled = true)]
     // [Appearance("fReleaseInvoiceuserVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(15)] 
     public  string user
     { 
       get { return _user; } 
       set { SetPropertyValue(nameof(user), ref _user, value); } 
     } 
     // Selection of Blocked Invoices
     // Notes for fReleaseInvoice : 
     private string _to8; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fReleaseInvoiceto8", Enabled = true)]
     // [Appearance("fReleaseInvoiceto8Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(15)] 
     public  string to8
     { 
       get { return _to8; } 
       set { SetPropertyValue(nameof(to8), ref _to8, value); } 
     } 
     // Processing
     // Notes for fReleaseInvoice : 
     private bool _releasemanual; 
     [XafDisplayName("Release Manually"), ToolTip("Release Manually")] 
     // [Appearance("fReleaseInvoicereleasemanual", Enabled = true)]
     // [Appearance("fReleaseInvoicereleasemanualVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool releasemanual
     { 
       get { return _releasemanual; } 
       set { SetPropertyValue(nameof(releasemanual), ref _releasemanual, value); } 
     } 
     // Processing
     // Notes for fReleaseInvoice : 
     private bool _movecash; 
     [XafDisplayName("Move Cash Disc. Date"), ToolTip("Move Cash Disc. Date")] 
     // [Appearance("fReleaseInvoicemovecash", Enabled = true)]
     // [Appearance("fReleaseInvoicemovecashVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool movecash
     { 
       get { return _movecash; } 
       set { SetPropertyValue(nameof(movecash), ref _movecash, value); } 
     } 
     // Processing
     // Notes for fReleaseInvoice : 
     private bool _releaseauto; 
     [XafDisplayName("Release Automatically"), ToolTip("Release Automatically")] 
     // [Appearance("fReleaseInvoicereleaseauto", Enabled = true)]
     // [Appearance("fReleaseInvoicereleaseautoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool releaseauto
     { 
       get { return _releaseauto; } 
       set { SetPropertyValue(nameof(releaseauto), ref _releaseauto, value); } 
     } 
     // Blocking Procedure
     // Notes for fReleaseInvoice : 
     private bool _blockduevarian; 
     [XafDisplayName("Blocked Due to Variances"), ToolTip("Blocked Due to Variances")] 
     // [Appearance("fReleaseInvoiceblockduevarian", Enabled = true)]
     // [Appearance("fReleaseInvoiceblockduevarianVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool blockduevarian
     { 
       get { return _blockduevarian; } 
       set { SetPropertyValue(nameof(blockduevarian), ref _blockduevarian, value); } 
     } 
     // Blocking Procedure
     // Notes for fReleaseInvoice : 
     private bool _manualpaymtblock; 
     [XafDisplayName("Manual Payment Block"), ToolTip("Manual Payment Block")] 
     // [Appearance("fReleaseInvoicemanualpaymtblock", Enabled = true)]
     // [Appearance("fReleaseInvoicemanualpaymtblockVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool manualpaymtblock
     { 
       get { return _manualpaymtblock; } 
       set { SetPropertyValue(nameof(manualpaymtblock), ref _manualpaymtblock, value); } 
     } 
     // Blocking Procedure
     // Notes for fReleaseInvoice : 
     private bool _stochasticallyblock; 
     [XafDisplayName("Stochastically Blocked"), ToolTip("Stochastically Blocked")] 
     // [Appearance("fReleaseInvoicestochasticallyblock", Enabled = true)]
     // [Appearance("fReleaseInvoicestochasticallyblockVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool stochasticallyblock
     { 
       get { return _stochasticallyblock; } 
       set { SetPropertyValue(nameof(stochasticallyblock), ref _stochasticallyblock, value); } 
     } 
     // Display options
     // Notes for fReleaseInvoice : 
     private string _variant; 
     [XafDisplayName("Variant"), ToolTip("Variant")] 
     // [Appearance("fReleaseInvoicevariant", Enabled = true)]
     // [Appearance("fReleaseInvoicevariantVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string variant
     { 
       get { return _variant; } 
       set { SetPropertyValue(nameof(variant), ref _variant, value); } 
     } 
     // 
     // Notes for fReleaseInvoice : 
     private bool _status; 
     [XafDisplayName("Status"), ToolTip("Status")] 
     // [Appearance("fReleaseInvoicestatus", Enabled = true)]
     // [Appearance("fReleaseInvoicestatusVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool status
     { 
       get { return _status; } 
       set { SetPropertyValue(nameof(status), ref _status, value); } 
     } 
     // 
     // Notes for fReleaseInvoice : 
     private string _docno; 
     [XafDisplayName("Doc. No."), ToolTip("Doc. No.")] 
     // [Appearance("fReleaseInvoicedocno", Enabled = true)]
     // [Appearance("fReleaseInvoicedocnoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string docno
     { 
       get { return _docno; } 
       set { SetPropertyValue(nameof(docno), ref _docno, value); } 
     } 
     // 
     // Notes for fReleaseInvoice : 
     private string _year; 
     [XafDisplayName("Year"), ToolTip("Year")] 
     // [Appearance("fReleaseInvoiceyear", Enabled = true)]
     // [Appearance("fReleaseInvoiceyearVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string year
     { 
       get { return _year; } 
       set { SetPropertyValue(nameof(year), ref _year, value); } 
     } 
     // 
     // Notes for fReleaseInvoice : 
     private fCurrency _crcy; 
     [XafDisplayName("Crcy"), ToolTip("Crcy")] 
     // [Appearance("fReleaseInvoicecrcy", Enabled = true)]
     // [Appearance("fReleaseInvoicecrcyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCurrency crcy
     { 
       get { return _crcy; } 
       set { SetPropertyValue(nameof(crcy), ref _crcy, value); } 
     } 
     // 
     // Notes for fReleaseInvoice : 
     private DateTime _transldate; 
     [XafDisplayName("Trans Date"), ToolTip("Trans Date")] 
     // [Appearance("fReleaseInvoicetransldate", Enabled = true)]
     // [Appearance("fReleaseInvoicetransldateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime transldate
     { 
       get { return _transldate; } 
       set { SetPropertyValue(nameof(transldate), ref _transldate, value); } 
     } 
     // 
     // Notes for fReleaseInvoice : 
     private double _exchrate; 
     [XafDisplayName("Exchange rate"), ToolTip("Exchange rate")] 
     // [Appearance("fReleaseInvoiceexchrate", Enabled = true)]
     // [Appearance("fReleaseInvoiceexchrateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double exchrate
     { 
       get { return _exchrate; } 
       set { SetPropertyValue(nameof(exchrate), ref _exchrate, value); } 
     } 
     // 
     // Notes for fReleaseInvoice : 
     private fCurrency _lcur; 
     [XafDisplayName("L.cur"), ToolTip("L.cur")] 
     // [Appearance("fReleaseInvoicelcur", Enabled = true)]
     // [Appearance("fReleaseInvoicelcurVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCurrency lcur
     { 
       get { return _lcur; } 
       set { SetPropertyValue(nameof(lcur), ref _lcur, value); } 
     } 
     // 
     // Notes for fReleaseInvoice : 
     private string _t; 
     [XafDisplayName("T"), ToolTip("T")] 
     // [Appearance("fReleaseInvoicet", Enabled = true)]
     // [Appearance("fReleaseInvoicetVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string t
     { 
       get { return _t; } 
       set { SetPropertyValue(nameof(t), ref _t, value); } 
     } 
     // 
     // Notes for fReleaseInvoice : 
     private DateTime _postdate1; 
     [XafDisplayName("Posting Date"), ToolTip("Posting Date")] 
     // [Appearance("fReleaseInvoicepostdate", Enabled = true)]
     // [Appearance("fReleaseInvoicepostdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime postdate1
     { 
       get { return _postdate1; } 
       set { SetPropertyValue(nameof(postdate1), ref _postdate1, value); } 
     } 
     // 
     // Notes for fReleaseInvoice : 
     private fCompany _cocd; 
     [XafDisplayName("CoCd"), ToolTip("CoCd")] 
     // [Appearance("fReleaseInvoicecocd", Enabled = true)]
     // [Appearance("fReleaseInvoicecocdVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCompany cocd
     { 
       get { return _cocd; } 
       set { SetPropertyValue(nameof(cocd), ref _cocd, value); } 
     } 
     // 
     // Notes for fReleaseInvoice : 
     private string _invoicepty; 
     [XafDisplayName("Invoicing Pty"), ToolTip("Invoicing Pty")] 
     // [Appearance("fReleaseInvoiceinvoicepty", Enabled = true)]
     // [Appearance("fReleaseInvoiceinvoiceptyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string invoicepty
     { 
       get { return _invoicepty; } 
       set { SetPropertyValue(nameof(invoicepty), ref _invoicepty, value); } 
     } 
     // 
     // Notes for fReleaseInvoice : 
     private string _name; 
     [XafDisplayName("Name"), ToolTip("Name")] 
     // [Appearance("fReleaseInvoicename", Enabled = true)]
     // [Appearance("fReleaseInvoicenameVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string name
     { 
       get { return _name; } 
       set { SetPropertyValue(nameof(name), ref _name, value); } 
     } 
   } 
} 
