// Class Name : fCreateRFQHdr.cs 
// Project Name : FICO 
// Last Update : 16/06/2023 15:06:28  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 16/06/2023 15:06:28 
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
   [System.ComponentModel.DisplayName("Create RFQ : Header Data")]
   public class fCreateRFQHdr : XPObject
   {
     public fCreateRFQHdr(Session session) : base(session) 
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
     [Appearance("VisiblefCreateRFQHdrOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for fCreateRFQHdr : 
     private string _rfq; 
     [XafDisplayName("RFQ"), ToolTip("RFQ")] 
     // [Appearance("fCreateRFQHdrrfq", Enabled = true)]
     // [Appearance("fCreateRFQHdrrfqVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string rfq
     { 
       get { return _rfq; } 
       set { SetPropertyValue(nameof(rfq), ref _rfq, value); } 
     } 
     // 
     // Notes for fCreateRFQHdr : 
     private fCompany _compcode; 
     [XafDisplayName("Company Code"), ToolTip("Company Code")] 
     // [Appearance("fCreateRFQHdrcompcode", Enabled = true)]
     // [Appearance("fCreateRFQHdrcompcodeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCompany compcode
     { 
       get { return _compcode; } 
       set { SetPropertyValue(nameof(compcode), ref _compcode, value); } 
     } 
     // 
     // Notes for fCreateRFQHdr : 
     private string _purchgroup; 
     [XafDisplayName("Purchasing Group"), ToolTip("Purchasing Group")] 
     // [Appearance("fCreateRFQHdrpurchgroup", Enabled = true)]
     // [Appearance("fCreateRFQHdrpurchgroupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string purchgroup
     { 
       get { return _purchgroup; } 
       set { SetPropertyValue(nameof(purchgroup), ref _purchgroup, value); } 
     } 
     // 
     // Notes for fCreateRFQHdr : 
     private string _rfqtype; 
     [XafDisplayName("RFQ Type"), ToolTip("RFQ Type")] 
     // [Appearance("fCreateRFQHdrrfqtype", Enabled = true)]
     // [Appearance("fCreateRFQHdrrfqtypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string rfqtype
     { 
       get { return _rfqtype; } 
       set { SetPropertyValue(nameof(rfqtype), ref _rfqtype, value); } 
     } 
     // 
     // Notes for fCreateRFQHdr : 
     private string _puchorgan; 
     [XafDisplayName("Purch. Organization"), ToolTip("Purch. Organization")] 
     // [Appearance("fCreateRFQHdrpuchorgan", Enabled = true)]
     // [Appearance("fCreateRFQHdrpuchorganVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string puchorgan
     { 
       get { return _puchorgan; } 
       set { SetPropertyValue(nameof(puchorgan), ref _puchorgan, value); } 
     } 
     // 
     // Notes for fCreateRFQHdr : 
     private fVendor _vendor; 
     [XafDisplayName("Vendor"), ToolTip("Vendor")] 
     // [Appearance("fCreateRFQHdrvendor", Enabled = true)]
     // [Appearance("fCreateRFQHdrvendorVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fVendor vendor
     { 
       get { return _vendor; } 
       set { SetPropertyValue(nameof(vendor), ref _vendor, value); } 
     } 
     // Administrative Fields
     // Notes for fCreateRFQHdr : 
     private DateTime _rfqdate; 
     [XafDisplayName("RFQ Date"), ToolTip("RFQ Date")] 
     // [Appearance("fCreateRFQHdrrfqdate", Enabled = true)]
     // [Appearance("fCreateRFQHdrrfqdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime rfqdate
     { 
       get { return _rfqdate; } 
       set { SetPropertyValue(nameof(rfqdate), ref _rfqdate, value); } 
     } 
     // Administrative Fields
     // Notes for fCreateRFQHdr : 
     private string _iteminterval; 
     [XafDisplayName("Item Interval"), ToolTip("Item Interval")] 
     // [Appearance("fCreateRFQHdriteminterval", Enabled = true)]
     // [Appearance("fCreateRFQHdritemintervalVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string iteminterval
     { 
       get { return _iteminterval; } 
       set { SetPropertyValue(nameof(iteminterval), ref _iteminterval, value); } 
     } 
     // Administrative Fields
     // Notes for fCreateRFQHdr : 
     private string _collno; 
     [XafDisplayName("Coll. No."), ToolTip("Coll. No.")] 
     // [Appearance("fCreateRFQHdrcollno", Enabled = true)]
     // [Appearance("fCreateRFQHdrcollnoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string collno
     { 
       get { return _collno; } 
       set { SetPropertyValue(nameof(collno), ref _collno, value); } 
     } 
     // Administrative Fields
     // Notes for fCreateRFQHdr : 
     private fLanguage _language; 
     [XafDisplayName("Language"), ToolTip("Language")] 
     // [Appearance("fCreateRFQHdrlanguage", Enabled = true)]
     // [Appearance("fCreateRFQHdrlanguageVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fLanguage language
     { 
       get { return _language; } 
       set { SetPropertyValue(nameof(language), ref _language, value); } 
     } 
     // Administrative Fields
     // Notes for fCreateRFQHdr : 
     private string _subiteminterv; 
     [XafDisplayName("Subitem Interv."), ToolTip("Subitem Interv.")] 
     // [Appearance("fCreateRFQHdrsubiteminterv", Enabled = true)]
     // [Appearance("fCreateRFQHdrsubitemintervVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string subiteminterv
     { 
       get { return _subiteminterv; } 
       set { SetPropertyValue(nameof(subiteminterv), ref _subiteminterv, value); } 
     } 
     // Administrative Fields
     // Notes for fCreateRFQHdr : 
     private DateTime _quotddln; 
     [XafDisplayName("QuotDdln"), ToolTip("QuotDdln")] 
     // [Appearance("fCreateRFQHdrquotddln", Enabled = true)]
     // [Appearance("fCreateRFQHdrquotddlnVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime quotddln
     { 
       get { return _quotddln; } 
       set { SetPropertyValue(nameof(quotddln), ref _quotddln, value); } 
     } 
     // Administrative Fields
     // Notes for fCreateRFQHdr : 
     private DateTime _validitystart; 
     [XafDisplayName("Validity Start"), ToolTip("Validity Start")] 
     // [Appearance("fCreateRFQHdrvaliditystart", Enabled = true)]
     // [Appearance("fCreateRFQHdrvaliditystartVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime validitystart
     { 
       get { return _validitystart; } 
       set { SetPropertyValue(nameof(validitystart), ref _validitystart, value); } 
     } 
     // Administrative Fields
     // Notes for fCreateRFQHdr : 
     private DateTime _validityend; 
     [XafDisplayName("Validity End"), ToolTip("Validity End")] 
     // [Appearance("fCreateRFQHdrvalidityend", Enabled = true)]
     // [Appearance("fCreateRFQHdrvalidityendVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime validityend
     { 
       get { return _validityend; } 
       set { SetPropertyValue(nameof(validityend), ref _validityend, value); } 
     } 
     // Administrative Fields
     // Notes for fCreateRFQHdr : 
     private DateTime _applyby; 
     [XafDisplayName("Apply By"), ToolTip("Apply By")] 
     // [Appearance("fCreateRFQHdrapplyby", Enabled = true)]
     // [Appearance("fCreateRFQHdrapplybyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime applyby
     { 
       get { return _applyby; } 
       set { SetPropertyValue(nameof(applyby), ref _applyby, value); } 
     } 
     // Administrative Fields
     // Notes for fCreateRFQHdr : 
     private DateTime _warranty; 
     [XafDisplayName("Warranty"), ToolTip("Warranty")] 
     // [Appearance("fCreateRFQHdrwarranty", Enabled = true)]
     // [Appearance("fCreateRFQHdrwarrantyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime warranty
     { 
       get { return _warranty; } 
       set { SetPropertyValue(nameof(warranty), ref _warranty, value); } 
     } 
     // Administrative Fields
     // Notes for fCreateRFQHdr : 
     private DateTime _bindgper; 
     [XafDisplayName("Bindg Per."), ToolTip("Bindg Per.")] 
     // [Appearance("fCreateRFQHdrbindgper", Enabled = true)]
     // [Appearance("fCreateRFQHdrbindgperVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime bindgper
     { 
       get { return _bindgper; } 
       set { SetPropertyValue(nameof(bindgper), ref _bindgper, value); } 
     } 
     // Term of Delivery and Payment
     // Notes for fCreateRFQHdr : 
     private string _targval; 
     [XafDisplayName("Targ. Val."), ToolTip("Targ. Val.")] 
     // [Appearance("fCreateRFQHdrtargval", Enabled = true)]
     // [Appearance("fCreateRFQHdrtargvalVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string targval
     { 
       get { return _targval; } 
       set { SetPropertyValue(nameof(targval), ref _targval, value); } 
     } 
     // Reference Data
     // Notes for fCreateRFQHdr : 
     private string _yourreference; 
     [XafDisplayName("Your Reference"), ToolTip("Your Reference")] 
     // [Appearance("fCreateRFQHdryourreference", Enabled = true)]
     // [Appearance("fCreateRFQHdryourreferenceVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string yourreference
     { 
       get { return _yourreference; } 
       set { SetPropertyValue(nameof(yourreference), ref _yourreference, value); } 
     } 
     // Reference Data
     // Notes for fCreateRFQHdr : 
     private string _salesperson; 
     [XafDisplayName("Salesperson"), ToolTip("Salesperson")] 
     // [Appearance("fCreateRFQHdrsalesperson", Enabled = true)]
     // [Appearance("fCreateRFQHdrsalespersonVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string salesperson
     { 
       get { return _salesperson; } 
       set { SetPropertyValue(nameof(salesperson), ref _salesperson, value); } 
     } 
     // Reference Data
     // Notes for fCreateRFQHdr : 
     private string _ourreference; 
     [XafDisplayName("Our Reference"), ToolTip("Our Reference")] 
     // [Appearance("fCreateRFQHdrourreference", Enabled = true)]
     // [Appearance("fCreateRFQHdrourreferenceVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string ourreference
     { 
       get { return _ourreference; } 
       set { SetPropertyValue(nameof(ourreference), ref _ourreference, value); } 
     } 
     // Reference Data
     // Notes for fCreateRFQHdr : 
     private string _telephone; 
     [XafDisplayName("Telephone"), ToolTip("Telephone")] 
     // [Appearance("fCreateRFQHdrtelephone", Enabled = true)]
     // [Appearance("fCreateRFQHdrtelephoneVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string telephone
     { 
       get { return _telephone; } 
       set { SetPropertyValue(nameof(telephone), ref _telephone, value); } 
     } 
     // Name
     // Notes for fCreateRFQHdr : 
     private enumTitle _title; 
     [XafDisplayName("Title"), ToolTip("Title")] 
     // [Appearance("fCreateRFQHdrtitle", Enabled = true)]
     // [Appearance("fCreateRFQHdrtitleVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumTitle title
     { 
       get { return _title; } 
       set { SetPropertyValue(nameof(title), ref _title, value); } 
     } 
     // Name
     // Notes for fCreateRFQHdr : 
     private string _name; 
     [XafDisplayName("Name"), ToolTip("Name")] 
     // [Appearance("fCreateRFQHdrname", Enabled = true)]
     // [Appearance("fCreateRFQHdrnameVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(200)] 
     public  string name
     { 
       get { return _name; } 
       set { SetPropertyValue(nameof(name), ref _name, value); } 
     } 
     // Search Terms
     // Notes for fCreateRFQHdr : 
     private string _searchterm; 
     [XafDisplayName("Search term 1/2"), ToolTip("Search term 1/2")] 
     // [Appearance("fCreateRFQHdrsearchterm", Enabled = true)]
     // [Appearance("fCreateRFQHdrsearchtermVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string searchterm
     { 
       get { return _searchterm; } 
       set { SetPropertyValue(nameof(searchterm), ref _searchterm, value); } 
     } 
     // Street Address
     // Notes for fCreateRFQHdr : 
     private string _street; 
     [XafDisplayName("Street/House number"), ToolTip("Street/House number")] 
     // [Appearance("fCreateRFQHdrstreet", Enabled = true)]
     // [Appearance("fCreateRFQHdrstreetVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string street
     { 
       get { return _street; } 
       set { SetPropertyValue(nameof(street), ref _street, value); } 
     } 
     // Street Address
     // Notes for fCreateRFQHdr : 
     private string _postalcode; 
     [XafDisplayName("Postal Code/City"), ToolTip("Postal Code/City")] 
     // [Appearance("fCreateRFQHdrpostalcode", Enabled = true)]
     // [Appearance("fCreateRFQHdrpostalcodeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(200)] 
     public  string postalcode
     { 
       get { return _postalcode; } 
       set { SetPropertyValue(nameof(postalcode), ref _postalcode, value); } 
     } 
     // Street Address
     // Notes for fCreateRFQHdr : 
     private fCountry _country; 
     [XafDisplayName("Country"), ToolTip("Country")] 
     // [Appearance("fCreateRFQHdrcountry", Enabled = true)]
     // [Appearance("fCreateRFQHdrcountryVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCountry country
     { 
       get { return _country; } 
       set { SetPropertyValue(nameof(country), ref _country, value); } 
     } 
     // Street Address
     // Notes for fCreateRFQHdr : 
     private fRegion _region; 
     [XafDisplayName("Region"), ToolTip("Region")] 
     // [Appearance("fCreateRFQHdrregion", Enabled = true)]
     // [Appearance("fCreateRFQHdrregionVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fRegion region
     { 
       get { return _region; } 
       set { SetPropertyValue(nameof(region), ref _region, value); } 
     } 
     // Street Address
     // Notes for fCreateRFQHdr : 
     private string _timezone; 
     [XafDisplayName("Time zone"), ToolTip("Time zone")] 
     // [Appearance("fCreateRFQHdrtimezone", Enabled = true)]
     // [Appearance("fCreateRFQHdrtimezoneVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string timezone
     { 
       get { return _timezone; } 
       set { SetPropertyValue(nameof(timezone), ref _timezone, value); } 
     } 
     // PO Box Address
     // Notes for fCreateRFQHdr : 
     private string _pobox; 
     [XafDisplayName("PO Box"), ToolTip("PO Box")] 
     // [Appearance("fCreateRFQHdrpobox", Enabled = true)]
     // [Appearance("fCreateRFQHdrpoboxVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string pobox
     { 
       get { return _pobox; } 
       set { SetPropertyValue(nameof(pobox), ref _pobox, value); } 
     } 
     // PO Box Address
     // Notes for fCreateRFQHdr : 
     private string _postalcode1; 
     [XafDisplayName("Postal code"), ToolTip("Postal code")] 
     // [Appearance("fCreateRFQHdrpostalcode", Enabled = true)]
     // [Appearance("fCreateRFQHdrpostalcodeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string postalcode1
     { 
       get { return _postalcode1; } 
       set { SetPropertyValue(nameof(postalcode1), ref _postalcode1, value); } 
     } 
     // PO Box Address
     // Notes for fCreateRFQHdr : 
     private fCompany _comppostcode; 
     [XafDisplayName("Company postal code"), ToolTip("Company postal code")] 
     // [Appearance("fCreateRFQHdrcomppostcode", Enabled = true)]
     // [Appearance("fCreateRFQHdrcomppostcodeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCompany comppostcode
     { 
       get { return _comppostcode; } 
       set { SetPropertyValue(nameof(comppostcode), ref _comppostcode, value); } 
     } 
   } 
} 
