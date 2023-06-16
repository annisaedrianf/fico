// Class Name : fInvoiceVerification.cs 
// Project Name : FICO 
// Last Update : 14/06/2023 11:32:48  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 14/06/2023 11:32:48 
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
   [System.ComponentModel.DisplayName("Enter Incoming Invoice: Company Code 0001")]
   public class fInvoiceVerification : XPObject
   {
     public fInvoiceVerification(Session session) : base(session) 
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
     [Appearance("VisiblefInvoiceVerificationOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // Basic Data
     // Notes for fInvoiceVerification : 
     private double _amount; 
     [XafDisplayName("Amount "), ToolTip("Amount ")] 
     // [Appearance("fInvoiceVerificationamount", Enabled = true)]
     // [Appearance("fInvoiceVerificationamountVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double amount
     { 
       get { return _amount; } 
       set { SetPropertyValue(nameof(amount), ref _amount, value); } 
     } 
     // Basic Data
     // Notes for fInvoiceVerification : 
     private DateTime _baselinedate1; 
     [XafDisplayName("Baseline Date "), ToolTip("Baseline Date ")] 
     // [Appearance("fInvoiceVerificationbaselinedate1", Enabled = true)]
     // [Appearance("fInvoiceVerificationbaselinedate1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime baselinedate1
     { 
       get { return _baselinedate1; } 
       set { SetPropertyValue(nameof(baselinedate1), ref _baselinedate1, value); } 
     } 
     // Basic Data
     // Notes for fInvoiceVerification : 
     private bool _calctax; 
     [XafDisplayName("Calculate tax"), ToolTip("Calculate tax")] 
     // [Appearance("fInvoiceVerificationcalctax", Enabled = true)]
     // [Appearance("fInvoiceVerificationcalctaxVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool calctax
     { 
       get { return _calctax; } 
       set { SetPropertyValue(nameof(calctax), ref _calctax, value); } 
     } 
     // Basic Data
     // Notes for fInvoiceVerification : 
     private fCompany _compcode; 
     [XafDisplayName("Company Code"), ToolTip("Company Code")] 
     // [Appearance("fInvoiceVerificationcompcode", Enabled = true)]
     // [Appearance("fInvoiceVerificationcompcodeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCompany compcode
     { 
       get { return _compcode; } 
       set { SetPropertyValue(nameof(compcode), ref _compcode, value); } 
     } 
     // Basic Data
     // Notes for fInvoiceVerification : 
     private DateTime _invoicedate; 
     [XafDisplayName("Invoice date"), ToolTip("Invoice date")] 
     // [Appearance("fInvoiceVerificationinvoicedate", Enabled = true)]
     // [Appearance("fInvoiceVerificationinvoicedateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime invoicedate
     { 
       get { return _invoicedate; } 
       set { SetPropertyValue(nameof(invoicedate), ref _invoicedate, value); } 
     } 
     // Basic Data
     // Notes for fInvoiceVerification : 
     private string _paymtterms; 
     [XafDisplayName("Payment Terms "), ToolTip("Payment Terms ")] 
     // [Appearance("fInvoiceVerificationpaymtterms", Enabled = true)]
     // [Appearance("fInvoiceVerificationpaymttermsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(200)] 
     public  string paymtterms
     { 
       get { return _paymtterms; } 
       set { SetPropertyValue(nameof(paymtterms), ref _paymtterms, value); } 
     } 
     // Basic Data
     // Notes for fInvoiceVerification : 
     private DateTime _postdate; 
     [XafDisplayName("Posting date"), ToolTip("Posting date")] 
     // [Appearance("fInvoiceVerificationpostdate", Enabled = true)]
     // [Appearance("fInvoiceVerificationpostdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime postdate
     { 
       get { return _postdate; } 
       set { SetPropertyValue(nameof(postdate), ref _postdate, value); } 
     } 
     // Basic Data
     // Notes for fInvoiceVerification : 
     private double _taxamnt; 
     [XafDisplayName("Tax Amount"), ToolTip("Tax Amount")] 
     // [Appearance("fInvoiceVerificationtaxamnt", Enabled = true)]
     // [Appearance("fInvoiceVerificationtaxamntVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double taxamnt
     { 
       get { return _taxamnt; } 
       set { SetPropertyValue(nameof(taxamnt), ref _taxamnt, value); } 
     } 
     // Basic Data
     // Notes for fInvoiceVerification : 
     private string _text; 
     [XafDisplayName("Text"), ToolTip("Text")] 
     // [Appearance("fInvoiceVerificationtext", Enabled = true)]
     // [Appearance("fInvoiceVerificationtextVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(200)] 
     public  string text
     { 
       get { return _text; } 
       set { SetPropertyValue(nameof(text), ref _text, value); } 
     } 
     // Payment
     // Notes for fInvoiceVerification : 
     private DateTime _baselinedate; 
     [XafDisplayName("Baseline Date"), ToolTip("Baseline Date")] 
     // [Appearance("fInvoiceVerificationbaselinedate", Enabled = true)]
     // [Appearance("fInvoiceVerificationbaselinedateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime baselinedate
     { 
       get { return _baselinedate; } 
       set { SetPropertyValue(nameof(baselinedate), ref _baselinedate, value); } 
     } 
     // Payment
     // Notes for fInvoiceVerification : 
     private double _cahsdiscnt; 
     [XafDisplayName("CashDiscnt"), ToolTip("CashDiscnt")] 
     // [Appearance("fInvoiceVerificationcahsdiscnt", Enabled = true)]
     // [Appearance("fInvoiceVerificationcahsdiscntVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double cahsdiscnt
     { 
       get { return _cahsdiscnt; } 
       set { SetPropertyValue(nameof(cahsdiscnt), ref _cahsdiscnt, value); } 
     } 
     // Payment
     // Notes for fInvoiceVerification : 
     private string _days; 
     [XafDisplayName("Days"), ToolTip("Days")] 
     // [Appearance("fInvoiceVerificationdays", Enabled = true)]
     // [Appearance("fInvoiceVerificationdaysVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string days
     { 
       get { return _days; } 
       set { SetPropertyValue(nameof(days), ref _days, value); } 
     } 
     // Payment
     // Notes for fInvoiceVerification : 
     private string _days1; 
     [XafDisplayName("Days"), ToolTip("Days")] 
     // [Appearance("fInvoiceVerificationdays1", Enabled = true)]
     // [Appearance("fInvoiceVerificationdays1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string days1
     { 
       get { return _days1; } 
       set { SetPropertyValue(nameof(days1), ref _days1, value); } 
     } 
     // Payment
     // Notes for fInvoiceVerification : 
     private DateTime _dueon; 
     [XafDisplayName("Due on"), ToolTip("Due on")] 
     // [Appearance("fInvoiceVerificationdueon", Enabled = true)]
     // [Appearance("fInvoiceVerificationdueonVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime dueon
     { 
       get { return _dueon; } 
       set { SetPropertyValue(nameof(dueon), ref _dueon, value); } 
     } 
     // Payment
     // Notes for fInvoiceVerification : 
     private string _fixediv; 
     [XafDisplayName("Fixed"), ToolTip("Fixed")] 
     // [Appearance("fInvoiceVerificationfixed", Enabled = true)]
     // [Appearance("fInvoiceVerificationfixedVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string fixediv
     { 
       get { return _fixediv; } 
       set { SetPropertyValue(nameof(fixediv), ref _fixediv, value); } 
     } 
     // Payment
     // Notes for fInvoiceVerification : 
     private string _housebank; 
     [XafDisplayName("House Bank"), ToolTip("House Bank")] 
     // [Appearance("fInvoiceVerificationhousebank", Enabled = true)]
     // [Appearance("fInvoiceVerificationhousebankVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string housebank
     { 
       get { return _housebank; } 
       set { SetPropertyValue(nameof(housebank), ref _housebank, value); } 
     } 
     // Payment
     // Notes for fInvoiceVerification : 
     private string _invref; 
     [XafDisplayName("Inv.ref."), ToolTip("Inv.ref.")] 
     // [Appearance("fInvoiceVerificationinvref", Enabled = true)]
     // [Appearance("fInvoiceVerificationinvrefVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string invref
     { 
       get { return _invref; } 
       set { SetPropertyValue(nameof(invref), ref _invref, value); } 
     } 
     // Payment
     // Notes for fInvoiceVerification : 
     private string _partbank; 
     [XafDisplayName("Part. Bank"), ToolTip("Part. Bank")] 
     // [Appearance("fInvoiceVerificationpartbank", Enabled = true)]
     // [Appearance("fInvoiceVerificationpartbankVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string partbank
     { 
       get { return _partbank; } 
       set { SetPropertyValue(nameof(partbank), ref _partbank, value); } 
     } 
     // Payment
     // Notes for fInvoiceVerification : 
     private string _paytterms; 
     [XafDisplayName("Payment Terms"), ToolTip("Payment Terms")] 
     // [Appearance("fInvoiceVerificationpaytterms", Enabled = true)]
     // [Appearance("fInvoiceVerificationpayttermsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string paytterms
     { 
       get { return _paytterms; } 
       set { SetPropertyValue(nameof(paytterms), ref _paytterms, value); } 
     } 
     // Payment
     // Notes for fInvoiceVerification : 
     private enumPmntBlock _pmntblock; 
     [XafDisplayName("Pmnt Block"), ToolTip("Pmnt Block")] 
     // [Appearance("fInvoiceVerificationpmntblock", Enabled = true)]
     // [Appearance("fInvoiceVerificationpmntblockVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumPmntBlock pmntblock
     { 
       get { return _pmntblock; } 
       set { SetPropertyValue(nameof(pmntblock), ref _pmntblock, value); } 
     } 
     // Payment
     // Notes for fInvoiceVerification : 
     private string _pmtmethod; 
     [XafDisplayName("Pmt Method"), ToolTip("Pmt Method")] 
     // [Appearance("fInvoiceVerificationpmtmethod", Enabled = true)]
     // [Appearance("fInvoiceVerificationpmtmethodVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string pmtmethod
     { 
       get { return _pmtmethod; } 
       set { SetPropertyValue(nameof(pmtmethod), ref _pmtmethod, value); } 
     } 
     // PO reference
     // Notes for fInvoiceVerification : 
     private string _a; 
     [XafDisplayName("A…"), ToolTip("A…")] 
     // [Appearance("fInvoiceVerificationa", Enabled = true)]
     // [Appearance("fInvoiceVerificationaVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string a
     { 
       get { return _a; } 
       set { SetPropertyValue(nameof(a), ref _a, value); } 
     } 
     // PO reference
     // Notes for fInvoiceVerification : 
     private string _acctassg; 
     [XafDisplayName("Acct Assg…"), ToolTip("Acct Assg…")] 
     // [Appearance("fInvoiceVerificationacctassg", Enabled = true)]
     // [Appearance("fInvoiceVerificationacctassgVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string acctassg
     { 
       get { return _acctassg; } 
       set { SetPropertyValue(nameof(acctassg), ref _acctassg, value); } 
     } 
     // PO reference
     // Notes for fInvoiceVerification : 
     private double _amount1; 
     [XafDisplayName("Amount"), ToolTip("Amount")] 
     // [Appearance("fInvoiceVerificationamount1", Enabled = true)]
     // [Appearance("fInvoiceVerificationamount1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double amount1
     { 
       get { return _amount1; } 
       set { SetPropertyValue(nameof(amount1), ref _amount1, value); } 
     } 
     // PO reference
     // Notes for fInvoiceVerification : 
     private string _item; 
     [XafDisplayName("Item"), ToolTip("Item")] 
     // [Appearance("fInvoiceVerificationitem", Enabled = true)]
     // [Appearance("fInvoiceVerificationitemVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string item
     { 
       get { return _item; } 
       set { SetPropertyValue(nameof(item), ref _item, value); } 
     } 
     // PO reference
     // Notes for fInvoiceVerification : 
     private string _item1; 
     [XafDisplayName("Item"), ToolTip("Item")] 
     // [Appearance("fInvoiceVerificationitem1", Enabled = true)]
     // [Appearance("fInvoiceVerificationitem1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string item1
     { 
       get { return _item1; } 
       set { SetPropertyValue(nameof(item1), ref _item1, value); } 
     } 
     // PO reference
     // Notes for fInvoiceVerification : 
     private bool _n; 
     [XafDisplayName("N."), ToolTip("N.")] 
     // [Appearance("fInvoiceVerificationn", Enabled = true)]
     // [Appearance("fInvoiceVerificationnVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool n
     { 
       get { return _n; } 
       set { SetPropertyValue(nameof(n), ref _n, value); } 
     } 
     // PO reference
     // Notes for fInvoiceVerification : 
     private string _o; 
     [XafDisplayName("O."), ToolTip("O.")] 
     // [Appearance("fInvoiceVerificationo", Enabled = true)]
     // [Appearance("fInvoiceVerificationoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string o
     { 
       get { return _o; } 
       set { SetPropertyValue(nameof(o), ref _o, value); } 
     } 
     // PO reference
     // Notes for fInvoiceVerification : 
     private string _potext; 
     [XafDisplayName("PO Text"), ToolTip("PO Text")] 
     // [Appearance("fInvoiceVerificationpotext", Enabled = true)]
     // [Appearance("fInvoiceVerificationpotextVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string potext
     { 
       get { return _potext; } 
       set { SetPropertyValue(nameof(potext), ref _potext, value); } 
     } 
     // PO reference
     // Notes for fInvoiceVerification : 
     private string _purchase; 
     [XafDisplayName("Purchase…"), ToolTip("Purchase…")] 
     // [Appearance("fInvoiceVerificationpurchase", Enabled = true)]
     // [Appearance("fInvoiceVerificationpurchaseVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string purchase
     { 
       get { return _purchase; } 
       set { SetPropertyValue(nameof(purchase), ref _purchase, value); } 
     } 
     // PO reference
     // Notes for fInvoiceVerification : 
     private string _qty; 
     [XafDisplayName("Quantity"), ToolTip("Quantity")] 
     // [Appearance("fInvoiceVerificationqty", Enabled = true)]
     // [Appearance("fInvoiceVerificationqtyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string qty
     { 
       get { return _qty; } 
       set { SetPropertyValue(nameof(qty), ref _qty, value); } 
     } 
     // PO reference
     // Notes for fInvoiceVerification : 
     private string _smartnumb; 
     [XafDisplayName("Smart Number"), ToolTip("Smart Number")] 
     // [Appearance("fInvoiceVerificationsmartnumb", Enabled = true)]
     // [Appearance("fInvoiceVerificationsmartnumbVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string smartnumb
     { 
       get { return _smartnumb; } 
       set { SetPropertyValue(nameof(smartnumb), ref _smartnumb, value); } 
     } 
     // PO reference
     // Notes for fInvoiceVerification : 
     private string _taxcode; 
     [XafDisplayName("Tax Code"), ToolTip("Tax Code")] 
     // [Appearance("fInvoiceVerificationtaxcode", Enabled = true)]
     // [Appearance("fInvoiceVerificationtaxcodeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string taxcode
     { 
       get { return _taxcode; } 
       set { SetPropertyValue(nameof(taxcode), ref _taxcode, value); } 
     } 
     // 
     // Notes for fInvoiceVerification : 
     private double _balance; 
     [XafDisplayName("Balance"), ToolTip("Balance")] 
     // [Appearance("fInvoiceVerificationbalance", Enabled = true)]
     // [Appearance("fInvoiceVerificationbalanceVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double balance
     { 
       get { return _balance; } 
       set { SetPropertyValue(nameof(balance), ref _balance, value); } 
     } 
     // 
     // Notes for fInvoiceVerification : 
     private enumTransaction _transaction; 
     [XafDisplayName("Transaction"), ToolTip("Transaction")] 
     // [Appearance("fInvoiceVerificationtransaction", Enabled = true)]
     // [Appearance("fInvoiceVerificationtransactionVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumTransaction transaction
     { 
       get { return _transaction; } 
       set { SetPropertyValue(nameof(transaction), ref _transaction, value); } 
     } 
   } 
} 
