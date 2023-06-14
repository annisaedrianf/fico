// Class Name : fCustomerInvoice.cs 
// Project Name : FICO 
// Last Update : 06/06/2023 14:51:25  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 06/06/2023 14:51:25 
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
   [System.ComponentModel.DisplayName("Enter Customer Invoice: Company Code 1000")]
   public class fCustomerInvoice : XPObject
   {
     public fCustomerInvoice(Session session) : base(session) 
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
     [Appearance("VisiblefCustomerInvoiceOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // Basic data
     // Notes for fCustomerInvoice : 
     private double _amount; 
     [XafDisplayName("Amount"), ToolTip("Amount")] 
     // [Appearance("fCustomerInvoiceamount", Enabled = true)]
     // [Appearance("fCustomerInvoiceamountVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double amount
     { 
       get { return _amount; } 
       set { SetPropertyValue(nameof(amount), ref _amount, value); } 
     } 
     // Basic data
     // Notes for fCustomerInvoice : 
     private DateTime _basedate; 
     [XafDisplayName("Baseline Date"), ToolTip("Baseline date")] 
     // [Appearance("fCustomerInvoicebasedate", Enabled = true)]
     // [Appearance("fCustomerInvoicebasedateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime basedate
     { 
       get { return _basedate; } 
       set { SetPropertyValue(nameof(basedate), ref _basedate, value); } 
     } 
     // Basic data
     // Notes for fCustomerInvoice : 
     private bool _caltax; 
     [XafDisplayName("Calculate Tax"), ToolTip("Calculate tax")] 
     // [Appearance("fCustomerInvoicecaltax", Enabled = true)]
     // [Appearance("fCustomerInvoicecaltaxVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool caltax
     { 
       get { return _caltax; } 
       set { SetPropertyValue(nameof(caltax), ref _caltax, value); } 
     } 
     // Basic data
     // Notes for fCustomerInvoice : 
     private fCompany _compcode; 
     [XafDisplayName("Company Code"), ToolTip("Company Code")] 
     // [Appearance("fCustomerInvoicecompcode", Enabled = true)]
     // [Appearance("fCustomerInvoicecompcodeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCompany compcode
     { 
       get { return _compcode; } 
       set { SetPropertyValue(nameof(compcode), ref _compcode, value); } 
     } 
     // Basic data
     // Notes for fCustomerInvoice : 
     private fGLAcct _crossccno; 
     [XafDisplayName("Cross-CC No."), ToolTip("Cross-CC no.")] 
     // [Appearance("fCustomerInvoicecrossccno", Enabled = true)]
     // [Appearance("fCustomerInvoicecrossccnoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fGLAcct crossccno
     { 
       get { return _crossccno; } 
       set { SetPropertyValue(nameof(crossccno), ref _crossccno, value); } 
     } 
     // Basic data
     // Notes for fCustomerInvoice : 
     private fCustomer _customer; 
     [XafDisplayName("Customer"), ToolTip("Customer")] 
     // [Appearance("fCustomerInvoicecustomer", Enabled = true)]
     // [Appearance("fCustomerInvoicecustomerVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCustomer customer
     { 
       get { return _customer; } 
       set { SetPropertyValue(nameof(customer), ref _customer, value); } 
     } 
     // Basic data
     // Notes for fCustomerInvoice : 
     private enumDocType _doctype; 
     [XafDisplayName("Document Type"), ToolTip("Document type")] 
     // [Appearance("fCustomerInvoicedoctype", Enabled = true)]
     // [Appearance("fCustomerInvoicedoctypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumDocType doctype
     { 
       get { return _doctype; } 
       set { SetPropertyValue(nameof(doctype), ref _doctype, value); } 
     } 
     // Basic data
     // Notes for fCustomerInvoice : 
     private DateTime _invoicedate; 
     [XafDisplayName("Invoice Date"), ToolTip("Invoice date")] 
     // [Appearance("fCustomerInvoiceinvoicedate", Enabled = true)]
     // [Appearance("fCustomerInvoiceinvoicedateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime invoicedate
     { 
       get { return _invoicedate; } 
       set { SetPropertyValue(nameof(invoicedate), ref _invoicedate, value); } 
     } 
     // Basic data
     // Notes for fCustomerInvoice : 
     private string _paymtterms; 
     [XafDisplayName("Paymt Terms"), ToolTip("Paymt terms")] 
     // [Appearance("fCustomerInvoicepaymtterms", Enabled = true)]
     // [Appearance("fCustomerInvoicepaymttermsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(250)] 
     public  string paymtterms
     { 
       get { return _paymtterms; } 
       set { SetPropertyValue(nameof(paymtterms), ref _paymtterms, value); } 
     } 
     // Basic data
     // Notes for fCustomerInvoice : 
     private DateTime _postdate; 
     [XafDisplayName("Posting Date"), ToolTip("Posting Date")] 
     // [Appearance("fCustomerInvoicepostdate", Enabled = true)]
     // [Appearance("fCustomerInvoicepostdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime postdate
     { 
       get { return _postdate; } 
       set { SetPropertyValue(nameof(postdate), ref _postdate, value); } 
     } 
     // Basic data
     // Notes for fCustomerInvoice : 
     private string _reference; 
     [XafDisplayName("Reference"), ToolTip("Reference")] 
     // [Appearance("fCustomerInvoicereference", Enabled = true)]
     // [Appearance("fCustomerInvoicereferenceVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string reference
     { 
       get { return _reference; } 
       set { SetPropertyValue(nameof(reference), ref _reference, value); } 
     } 
     // Basic data
     // Notes for fCustomerInvoice : 
     private string _sglind; 
     [XafDisplayName("SGL Ind"), ToolTip("SGL Ind")] 
     // [Appearance("fCustomerInvoicesglind", Enabled = true)]
     // [Appearance("fCustomerInvoicesglindVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string sglind
     { 
       get { return _sglind; } 
       set { SetPropertyValue(nameof(sglind), ref _sglind, value); } 
     } 
     // Basic data
     // Notes for fCustomerInvoice : 
     private string _text; 
     [XafDisplayName("Text"), ToolTip("Text")] 
     // [Appearance("fCustomerInvoicetext", Enabled = true)]
     // [Appearance("fCustomerInvoicetextVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(250)] 
     public  string text
     { 
       get { return _text; } 
       set { SetPropertyValue(nameof(text), ref _text, value); } 
     } 
     // Local currency
     // Notes for fCustomerInvoice : 
     private double _amount1; 
     [XafDisplayName("Amount (Local)"), ToolTip("Amount (Local)")] 
     // [Appearance("fCustomerInvoiceamount1", Enabled = true)]
     // [Appearance("fCustomerInvoiceamount1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double amount1
     { 
       get { return _amount1; } 
       set { SetPropertyValue(nameof(amount1), ref _amount1, value); } 
     } 
     // Local currency
     // Notes for fCustomerInvoice : 
     private double _amtloccur; 
     [XafDisplayName("Amount in Doc. Curr. (Local)"), ToolTip("Amount in Doc. Curr. (Local)")] 
     // [Appearance("fCustomerInvoiceamtloccur", Enabled = true)]
     // [Appearance("fCustomerInvoiceamtloccurVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double amtloccur
     { 
       get { return _amtloccur; } 
       set { SetPropertyValue(nameof(amtloccur), ref _amtloccur, value); } 
     } 
     // Local currency
     // Notes for fCustomerInvoice : 
     private double _exchangerate; 
     [XafDisplayName("Exchange Rate"), ToolTip("Exchange rate")] 
     // [Appearance("fCustomerInvoiceexchangerate", Enabled = true)]
     // [Appearance("fCustomerInvoiceexchangerateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double exchangerate
     { 
       get { return _exchangerate; } 
       set { SetPropertyValue(nameof(exchangerate), ref _exchangerate, value); } 
     } 
     // Local currency
     // Notes for fCustomerInvoice : 
     private DateTime _transltdate; 
     [XafDisplayName("Translation Date"), ToolTip("Translation dte")] 
     // [Appearance("fCustomerInvoicetransltdate", Enabled = true)]
     // [Appearance("fCustomerInvoicetransltdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime transltdate
     { 
       get { return _transltdate; } 
       set { SetPropertyValue(nameof(transltdate), ref _transltdate, value); } 
     } 
     // 
     // Notes for fCustomerInvoice : 
     private double _amountdoccurr; 
     [XafDisplayName("Amount in Doc. Curr."), ToolTip("Amount in Doc. Curr.")] 
     // [Appearance("fCustomerInvoiceamountdoccurr", Enabled = true)]
     // [Appearance("fCustomerInvoiceamountdoccurrVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double amountdoccurr
     { 
       get { return _amountdoccurr; } 
       set { SetPropertyValue(nameof(amountdoccurr), ref _amountdoccurr, value); } 
     } 
     // 
     // Notes for fCustomerInvoice : 
     private fGLAcct _clacct; 
     [XafDisplayName("G/L Acct"), ToolTip("G/L acct")] 
     // [Appearance("fCustomerInvoiceclacct", Enabled = true)]
     // [Appearance("fCustomerInvoiceclacctVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fGLAcct clacct
     { 
       get { return _clacct; } 
       set { SetPropertyValue(nameof(clacct), ref _clacct, value); } 
     } 
     // 
     // Notes for fCustomerInvoice : 
     private enumDC _dc; 
     [XafDisplayName("D/C"), ToolTip("D/C")] 
     // [Appearance("fCustomerInvoicedc", Enabled = true)]
     // [Appearance("fCustomerInvoicedcVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumDC dc
     { 
       get { return _dc; } 
       set { SetPropertyValue(nameof(dc), ref _dc, value); } 
     } 
     // 
     // Notes for fCustomerInvoice : 
     private string _shorttext; 
     [XafDisplayName("Short Text"), ToolTip("Short Text")] 
     // [Appearance("fCustomerInvoiceshorttext", Enabled = true)]
     // [Appearance("fCustomerInvoiceshorttextVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string shorttext
     { 
       get { return _shorttext; } 
       set { SetPropertyValue(nameof(shorttext), ref _shorttext, value); } 
     } 
   } 
} 
