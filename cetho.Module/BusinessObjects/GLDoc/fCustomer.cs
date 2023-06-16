// Class Name : fCustomer.cs 
// Project Name : FICO 
// Last Update : 06/06/2023 14:47:39  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 06/06/2023 14:47:39 
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
   [System.ComponentModel.DisplayName("Customer Create : Initial Screen")]
   public class fCustomer : XPObject
   {
     public fCustomer(Session session) : base(session) 
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
     [Appearance("VisiblefCustomerOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // Account Management
     // Notes for fCustomer : 
     private string _authorization1; 
     [XafDisplayName("Authorization"), ToolTip("Authorization (Acc)")] 
     // [Appearance("fCustomerauthorization1", Enabled = true)]
     // [Appearance("fCustomerauthorization1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string authorization1
     { 
       get { return _authorization1; } 
       set { SetPropertyValue(nameof(authorization1), ref _authorization1, value); } 
     } 
     // Account Management
     // Notes for fCustomer : 
     private string _cash; 
     [XafDisplayName("Cash Mgmt Group"), ToolTip("Cash mgmt group")] 
     // [Appearance("fCustomercash", Enabled = true)]
     // [Appearance("fCustomercashVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string cash
     { 
       get { return _cash; } 
       set { SetPropertyValue(nameof(cash), ref _cash, value); } 
     } 
     // Account Management
     // Notes for fCustomer : 
     private string _headoffice; 
     [XafDisplayName("Head Office"), ToolTip("Head Office")] 
     // [Appearance("fCustomerheadoffice", Enabled = true)]
     // [Appearance("fCustomerheadofficeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string headoffice
     { 
       get { return _headoffice; } 
       set { SetPropertyValue(nameof(headoffice), ref _headoffice, value); } 
     } 
     // Account Management
     // Notes for fCustomer : 
     private string _preference; 
     [XafDisplayName("Preference Ind."), ToolTip("Preference ind.")] 
     // [Appearance("fCustomerpreference", Enabled = true)]
     // [Appearance("fCustomerpreferenceVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string preference
     { 
       get { return _preference; } 
       set { SetPropertyValue(nameof(preference), ref _preference, value); } 
     } 
     // Account Management
     // Notes for fCustomer : 
     private string _reconacc; 
     [XafDisplayName("Recon. Account"), ToolTip("Recon. Account")] 
     // [Appearance("fCustomerreconacc", Enabled = true)]
     // [Appearance("fCustomerreconaccVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string reconacc
     { 
       get { return _reconacc; } 
       set { SetPropertyValue(nameof(reconacc), ref _reconacc, value); } 
     } 
     // Account Management
     // Notes for fCustomer : 
     private string _sortkey; 
     [XafDisplayName("Sort Key"), ToolTip("Sort Key")] 
     // [Appearance("fCustomersortkey", Enabled = true)]
     // [Appearance("fCustomersortkeyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string sortkey
     { 
       get { return _sortkey; } 
       set { SetPropertyValue(nameof(sortkey), ref _sortkey, value); } 
     } 
     // Account Management
     // Notes for fCustomer : 
     private string _valueadjust; 
     [XafDisplayName("Value Adjustment"), ToolTip("Value adjustment")] 
     // [Appearance("fCustomervalueadjust", Enabled = true)]
     // [Appearance("fCustomervalueadjustVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string valueadjust
     { 
       get { return _valueadjust; } 
       set { SetPropertyValue(nameof(valueadjust), ref _valueadjust, value); } 
     } 
     // Address
     // Notes for fCustomer : 
     private fCountry _country; 
     [XafDisplayName("Country"), ToolTip("Country")] 
     // [Appearance("fCustomercountry", Enabled = true)]
     // [Appearance("fCustomercountryVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCountry country
     { 
       get { return _country; } 
       set { SetPropertyValue(nameof(country), ref _country, value); } 
     } 
     // Address
     // Notes for fCustomer : 
     private string _name; 
     [XafDisplayName("Name"), ToolTip("Name")] 
     // [Appearance("fCustomername", Enabled = true)]
     // [Appearance("fCustomernameVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(250)] 
     public  string name
     { 
       get { return _name; } 
       set { SetPropertyValue(nameof(name), ref _name, value); } 
     } 
     // Address
     // Notes for fCustomer : 
     private string _postalcode; 
     [XafDisplayName("Postal Code/City"), ToolTip("Postal Code/City")] 
     // [Appearance("fCustomerpostalcode", Enabled = true)]
     // [Appearance("fCustomerpostalcodeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string postalcode
     { 
       get { return _postalcode; } 
       set { SetPropertyValue(nameof(postalcode), ref _postalcode, value); } 
     } 
     // Address
     // Notes for fCustomer : 
     private string _searchterm; 
     [XafDisplayName("Search Term"), ToolTip("Search Term")] 
     // [Appearance("fCustomersearchterm", Enabled = true)]
     // [Appearance("fCustomersearchtermVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(150)] 
     public  string searchterm
     { 
       get { return _searchterm; } 
       set { SetPropertyValue(nameof(searchterm), ref _searchterm, value); } 
     } 
     // Address
     // Notes for fCustomer : 
     private string _street; 
     [XafDisplayName("Street/House Number"), ToolTip("Street/House Number")] 
     // [Appearance("fCustomerstreet", Enabled = true)]
     // [Appearance("fCustomerstreetVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(500)] 
     public  string street
     { 
       get { return _street; } 
       set { SetPropertyValue(nameof(street), ref _street, value); } 
     } 
     // Address
     // Notes for fCustomer : 
     private fCountry _time; 
     [XafDisplayName("Time Zone"), ToolTip("Time Zone")] 
     // [Appearance("fCustomertime", Enabled = true)]
     // [Appearance("fCustomertimeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCountry time
     { 
       get { return _time; } 
       set { SetPropertyValue(nameof(time), ref _time, value); } 
     } 
     // Address
     // Notes for fCustomer : 
     private string _title; 
     [XafDisplayName("Title"), ToolTip("Title")] 
     // [Appearance("fCustomertitle", Enabled = true)]
     // [Appearance("fCustomertitleVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string title
     { 
       get { return _title; } 
       set { SetPropertyValue(nameof(title), ref _title, value); } 
     } 
     // Address
     // Notes for fCustomer : 
     private string _transportation; 
     [XafDisplayName("Transportation Zone"), ToolTip("Transportation zone")] 
     // [Appearance("fCustomertransportation", Enabled = true)]
     // [Appearance("fCustomertransportationVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(15)] 
     public  string transportation
     { 
       get { return _transportation; } 
       set { SetPropertyValue(nameof(transportation), ref _transportation, value); } 
     } 
     // Billing Documents
     // Notes for fCustomer : 
     private string _acctassgmtgroup; 
     [XafDisplayName("Acct Assgmt Group"), ToolTip("Acct assgmt group")] 
     // [Appearance("fCustomeracctassgmtgroup", Enabled = true)]
     // [Appearance("fCustomeracctassgmtgroupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string acctassgmtgroup
     { 
       get { return _acctassgmtgroup; } 
       set { SetPropertyValue(nameof(acctassgmtgroup), ref _acctassgmtgroup, value); } 
     } 
     // Billing Documents
     // Notes for fCustomer : 
     private fCountry _country1; 
     [XafDisplayName("Country"), ToolTip("Country ")] 
     // [Appearance("fCustomercountry1", Enabled = true)]
     // [Appearance("fCustomercountry1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCountry country1
     { 
       get { return _country1; } 
       set { SetPropertyValue(nameof(country1), ref _country1, value); } 
     } 
     // Billing Documents
     // Notes for fCustomer : 
     private string _creditctrlarea; 
     [XafDisplayName("Credit Ctrl Area"), ToolTip("Credit ctrl area")] 
     // [Appearance("fCustomercreditctrlarea", Enabled = true)]
     // [Appearance("fCustomercreditctrlareaVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string creditctrlarea
     { 
       get { return _creditctrlarea; } 
       set { SetPropertyValue(nameof(creditctrlarea), ref _creditctrlarea, value); } 
     } 
     // Billing Documents
     // Notes for fCustomer : 
     private string _description; 
     [XafDisplayName("Description"), ToolTip("Description")] 
     // [Appearance("fCustomerdescription", Enabled = true)]
     // [Appearance("fCustomerdescriptionVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(250)] 
     public  string description
     { 
       get { return _description; } 
       set { SetPropertyValue(nameof(description), ref _description, value); } 
     } 
     // Billing Documents
     // Notes for fCustomer : 
     private string _incoterms; 
     [XafDisplayName("Incoterms"), ToolTip("Incoterms")] 
     // [Appearance("fCustomerincoterms", Enabled = true)]
     // [Appearance("fCustomerincotermsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string incoterms
     { 
       get { return _incoterms; } 
       set { SetPropertyValue(nameof(incoterms), ref _incoterms, value); } 
     } 
     // Billing Documents
     // Notes for fCustomer : 
     private fCustomerInvoice _invoicedates; 
     [XafDisplayName("Invoice Dates"), ToolTip("Invoice dates")] 
     // [Appearance("fCustomerinvoicedates", Enabled = true)]
     // [Appearance("fCustomerinvoicedatesVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCustomerInvoice invoicedates
     { 
       get { return _invoicedates; } 
       set { SetPropertyValue(nameof(invoicedates), ref _invoicedates, value); } 
     } 
     // Billing Documents
     // Notes for fCustomer : 
     private fCustomerInvoice _invoiclistdates; 
     [XafDisplayName("Invoicing List Dates"), ToolTip("InvoicingListDates")] 
     // [Appearance("fCustomerinvoiclistdates", Enabled = true)]
     // [Appearance("fCustomerinvoiclistdatesVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCustomerInvoice invoiclistdates
     { 
       get { return _invoiclistdates; } 
       set { SetPropertyValue(nameof(invoiclistdates), ref _invoiclistdates, value); } 
     } 
     // Billing Documents
     // Notes for fCustomer : 
     private string _name1; 
     [XafDisplayName("Name "), ToolTip("Name ")] 
     // [Appearance("fCustomername1", Enabled = true)]
     // [Appearance("fCustomername1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string name1
     { 
       get { return _name1; } 
       set { SetPropertyValue(nameof(name1), ref _name1, value); } 
     } 
     // Billing Documents
     // Notes for fCustomer : 
     private string _paymguarproc; 
     [XafDisplayName("Paym. Guar. Proc."), ToolTip("Paym.guar.proc.")] 
     // [Appearance("fCustomerpaymguarproc", Enabled = true)]
     // [Appearance("fCustomerpaymguarprocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string paymguarproc
     { 
       get { return _paymguarproc; } 
       set { SetPropertyValue(nameof(paymguarproc), ref _paymguarproc, value); } 
     } 
     // Billing Documents
     // Notes for fCustomer : 
     private bool _pricedetermin; 
     [XafDisplayName("Price Determin."), ToolTip("Price determin.")] 
     // [Appearance("fCustomerpricedetermin", Enabled = true)]
     // [Appearance("fCustomerpricedeterminVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool pricedetermin
     { 
       get { return _pricedetermin; } 
       set { SetPropertyValue(nameof(pricedetermin), ref _pricedetermin, value); } 
     } 
     // Billing Documents
     // Notes for fCustomer : 
     private bool _rebate; 
     [XafDisplayName("Rebate"), ToolTip("Rebate")] 
     // [Appearance("fCustomerrebate", Enabled = true)]
     // [Appearance("fCustomerrebateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool rebate
     { 
       get { return _rebate; } 
       set { SetPropertyValue(nameof(rebate), ref _rebate, value); } 
     } 
     // Billing Documents
     // Notes for fCustomer : 
     private bool _subsinvoice; 
     [XafDisplayName("Subs. Invoice Processing"), ToolTip("Subs. Invoice processing")] 
     // [Appearance("fCustomersubsinvoice", Enabled = true)]
     // [Appearance("fCustomersubsinvoiceVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool subsinvoice
     { 
       get { return _subsinvoice; } 
       set { SetPropertyValue(nameof(subsinvoice), ref _subsinvoice, value); } 
     } 
     // Billing Documents
     // Notes for fCustomer : 
     private string _tax; 
     [XafDisplayName("Tax"), ToolTip("Tax")] 
     // [Appearance("fCustomertax", Enabled = true)]
     // [Appearance("fCustomertaxVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string tax
     { 
       get { return _tax; } 
       set { SetPropertyValue(nameof(tax), ref _tax, value); } 
     } 
     // Billing Documents
     // Notes for fCustomer : 
     private string _taxcategory; 
     [XafDisplayName("Tax Category"), ToolTip("Tax category")] 
     // [Appearance("fCustomertaxcategory", Enabled = true)]
     // [Appearance("fCustomertaxcategoryVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string taxcategory
     { 
       get { return _taxcategory; } 
       set { SetPropertyValue(nameof(taxcategory), ref _taxcategory, value); } 
     } 
     // Billing Documents
     // Notes for fCustomer : 
     private string _termpayt; 
     [XafDisplayName("Terms of Payment "), ToolTip("Terms of Payment ")] 
     // [Appearance("fCustomertermpayt", Enabled = true)]
     // [Appearance("fCustomertermpaytVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string termpayt
     { 
       get { return _termpayt; } 
       set { SetPropertyValue(nameof(termpayt), ref _termpayt, value); } 
     } 
     // Control Data
     // Notes for fCustomer : 
     private string _authorization; 
     [XafDisplayName("Authorization"), ToolTip("Authorization")] 
     // [Appearance("fCustomerauthorization", Enabled = true)]
     // [Appearance("fCustomerauthorizationVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string authorization
     { 
       get { return _authorization; } 
       set { SetPropertyValue(nameof(authorization), ref _authorization, value); } 
     } 
     // Control Data
     // Notes for fCustomer : 
     private string _corporategroup; 
     [XafDisplayName("Corporate Group"), ToolTip("Corporate Group")] 
     // [Appearance("fCustomercorporategroup", Enabled = true)]
     // [Appearance("fCustomercorporategroupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string corporategroup
     { 
       get { return _corporategroup; } 
       set { SetPropertyValue(nameof(corporategroup), ref _corporategroup, value); } 
     } 
     // Control Data
     // Notes for fCustomer : 
     private string _tradingpartner; 
     [XafDisplayName("Trading Partner"), ToolTip("Trading Partner")] 
     // [Appearance("fCustomertradingpartner", Enabled = true)]
     // [Appearance("fCustomertradingpartnerVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string tradingpartner
     { 
       get { return _tradingpartner; } 
       set { SetPropertyValue(nameof(tradingpartner), ref _tradingpartner, value); } 
     } 
     // Control Data
     // Notes for fCustomer : 
     private fVendor _vendor; 
     [XafDisplayName("Vendor"), ToolTip("Vendor")] 
     // [Appearance("fCustomervendor", Enabled = true)]
     // [Appearance("fCustomervendorVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fVendor vendor
     { 
       get { return _vendor; } 
       set { SetPropertyValue(nameof(vendor), ref _vendor, value); } 
     } 
     // Payment Transactions
     // Notes for fCustomer : 
     private string _arpind; 
     [XafDisplayName("AR Pledging Ind"), ToolTip("AR Pledging Ind")] 
     // [Appearance("fCustomerarpind", Enabled = true)]
     // [Appearance("fCustomerarpindVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string arpind
     { 
       get { return _arpind; } 
       set { SetPropertyValue(nameof(arpind), ref _arpind, value); } 
     } 
     // Payment Transactions
     // Notes for fCustomer : 
     private string _bechargespayt; 
     [XafDisplayName("B/E Charges Payt Term"), ToolTip("B/e charges payt term")] 
     // [Appearance("fCustomerbechargespayt", Enabled = true)]
     // [Appearance("fCustomerbechargespaytVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string bechargespayt
     { 
       get { return _bechargespayt; } 
       set { SetPropertyValue(nameof(bechargespayt), ref _bechargespayt, value); } 
     } 
     // Payment Transactions
     // Notes for fCustomer : 
     private string _knownleave; 
     [XafDisplayName("Known/Neg. Leave"), ToolTip("Known/neg.leave")] 
     // [Appearance("fCustomerknownleave", Enabled = true)]
     // [Appearance("fCustomerknownleaveVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string knownleave
     { 
       get { return _knownleave; } 
       set { SetPropertyValue(nameof(knownleave), ref _knownleave, value); } 
     } 
     // Payment Transactions
     // Notes for fCustomer : 
     private bool _paythistoryrecord; 
     [XafDisplayName("Payment History Record"), ToolTip("Payment history record")] 
     // [Appearance("fCustomerpaythistoryrecord", Enabled = true)]
     // [Appearance("fCustomerpaythistoryrecordVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool paythistoryrecord
     { 
       get { return _paythistoryrecord; } 
       set { SetPropertyValue(nameof(paythistoryrecord), ref _paythistoryrecord, value); } 
     } 
     // Payment Transactions
     // Notes for fCustomer : 
     private string _termpayment; 
     [XafDisplayName("Terms of Payment"), ToolTip("Terms of Payment")] 
     // [Appearance("fCustomertermpayment", Enabled = true)]
     // [Appearance("fCustomertermpaymentVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string termpayment
     { 
       get { return _termpayment; } 
       set { SetPropertyValue(nameof(termpayment), ref _termpayment, value); } 
     } 
     // Payment Transactions
     // Notes for fCustomer : 
     private string _timeuntiluntilcheck; 
     [XafDisplayName("Time until Check Paid"), ToolTip("Time until check paid")] 
     // [Appearance("fCustomertimeuntiluntilcheck", Enabled = true)]
     // [Appearance("fCustomertimeuntiluntilcheckVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string timeuntiluntilcheck
     { 
       get { return _timeuntiluntilcheck; } 
       set { SetPropertyValue(nameof(timeuntiluntilcheck), ref _timeuntiluntilcheck, value); } 
     } 
     // Payment Transactions
     // Notes for fCustomer : 
     private string _tolegroup; 
     [XafDisplayName("Tolerance Group"), ToolTip("Tolerance Group")] 
     // [Appearance("fCustomertolegroup", Enabled = true)]
     // [Appearance("fCustomertolegroupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string tolegroup
     { 
       get { return _tolegroup; } 
       set { SetPropertyValue(nameof(tolegroup), ref _tolegroup, value); } 
     } 
     // Reference
     // Notes for fCustomer : 
     private fCompany _compcode; 
     [XafDisplayName("Company Code "), ToolTip("Company Code ")] 
     // [Appearance("fCustomercompcode", Enabled = true)]
     // [Appearance("fCustomercompcodeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCompany compcode
     { 
       get { return _compcode; } 
       set { SetPropertyValue(nameof(compcode), ref _compcode, value); } 
     } 
     // Reference
     // Notes for fCustomer : 
     private fCustomer _customer1; 
     [XafDisplayName("Customer "), ToolTip("Customer ")] 
     // [Appearance("fCustomercustomer1", Enabled = true)]
     // [Appearance("fCustomercustomer1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCustomer customer1
     { 
       get { return _customer1; } 
       set { SetPropertyValue(nameof(customer1), ref _customer1, value); } 
     } 
     // Reference
     // Notes for fCustomer : 
     private string _distributionchannel1; 
     [XafDisplayName("Distribution Channel "), ToolTip("Distribution Channel ")] 
     // [Appearance("fCustomerdistributionchannel1", Enabled = true)]
     // [Appearance("fCustomerdistributionchannel1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string distributionchannel1
     { 
       get { return _distributionchannel1; } 
       set { SetPropertyValue(nameof(distributionchannel1), ref _distributionchannel1, value); } 
     } 
     // Reference
     // Notes for fCustomer : 
     private string _refdivision; 
     [XafDisplayName("Reference Division"), ToolTip("Reference division")] 
     // [Appearance("fCustomerrefdivision", Enabled = true)]
     // [Appearance("fCustomerrefdivisionVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string refdivision
     { 
       get { return _refdivision; } 
       set { SetPropertyValue(nameof(refdivision), ref _refdivision, value); } 
     } 
     // Reference
     // Notes for fCustomer : 
     private string _salesorgan1; 
     [XafDisplayName("Sales Organization "), ToolTip("SalesOrganization ")] 
     // [Appearance("fCustomersalesorgan1", Enabled = true)]
     // [Appearance("fCustomersalesorgan1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string salesorgan1
     { 
       get { return _salesorgan1; } 
       set { SetPropertyValue(nameof(salesorgan1), ref _salesorgan1, value); } 
     } 
     // Sales Area
     // Notes for fCustomer : 
     private string _distributionchannel; 
     [XafDisplayName("Distribution Channel"), ToolTip("Distribution Channel")] 
     // [Appearance("fCustomerdistributionchannel", Enabled = true)]
     // [Appearance("fCustomerdistributionchannelVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string distributionchannel
     { 
       get { return _distributionchannel; } 
       set { SetPropertyValue(nameof(distributionchannel), ref _distributionchannel, value); } 
     } 
     // Sales Area
     // Notes for fCustomer : 
     private string _division; 
     [XafDisplayName("Division"), ToolTip("Division")] 
     // [Appearance("fCustomerdivision", Enabled = true)]
     // [Appearance("fCustomerdivisionVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string division
     { 
       get { return _division; } 
       set { SetPropertyValue(nameof(division), ref _division, value); } 
     } 
     // Sales Area
     // Notes for fCustomer : 
     private string _salesorgan; 
     [XafDisplayName("Sales Organization"), ToolTip("SalesOrganization")] 
     // [Appearance("fCustomersalesorgan", Enabled = true)]
     // [Appearance("fCustomersalesorganVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string salesorgan
     { 
       get { return _salesorgan; } 
       set { SetPropertyValue(nameof(salesorgan), ref _salesorgan, value); } 
     } 
     // 
     // Notes for fCustomer : 
     private fAcctsGroup _accgroup; 
     [XafDisplayName("Account Group"), ToolTip("Account Group")] 
     // [Appearance("fCustomeraccgroup", Enabled = true)]
     // [Appearance("fCustomeraccgroupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fAcctsGroup accgroup
     { 
       get { return _accgroup; } 
       set { SetPropertyValue(nameof(accgroup), ref _accgroup, value); } 
     } 
     // 
     // Notes for fCustomer : 
     private fCompany _companycode; 
     [XafDisplayName("Company Code"), ToolTip("Company Code")] 
     // [Appearance("fCustomercompanycode", Enabled = true)]
     // [Appearance("fCustomercompanycodeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCompany companycode
     { 
       get { return _companycode; } 
       set { SetPropertyValue(nameof(companycode), ref _companycode, value); } 
     } 
     // 
     // Notes for fCustomer : 
     private string _customer; 
     [XafDisplayName("Customer"), ToolTip("Customer")] 
     // [Appearance("fCustomercustomer", Enabled = true)]
     // [Appearance("fCustomercustomerVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string customer
     { 
       get { return _customer; } 
       set { SetPropertyValue(nameof(customer), ref _customer, value); } 
     } 
   } 
} 
