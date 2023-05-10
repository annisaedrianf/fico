// Class Name : fCompany.cs 
// Project Name : FICO 
// Last Update : 26/04/2023 05:41:51  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 26/04/2023 05:41:51 
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
using DevExpress.Persistent.BaseImpl;

namespace cetho.Module.BusinessObjects 
{ 
   [DefaultClassOptions] 
   [ImageName("ModelEditor_Views")] 
   [DefaultProperty("compannyname")]
   [NavigationItem("Organizational Structure")]
   // Standard Document
   [System.ComponentModel.DisplayName("Company")]
   public class fCompany : XPObject
   {
     public fCompany(Session session) : base(session) 
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
       UpdateByTime(); 
     } 
     protected override void OnSaving()
     {
        base.OnSaving();
        UpdateByTime(); 
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
     [Appearance("VisiblefCompanyOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // Name
     // Notes for fCompany : 
     private string _companygroup; 
     [XafDisplayName("Company Group"), ToolTip("Company Group")] 
     // [Appearance("fCompanycompanygroup", Enabled = true)]
     // [Appearance("fCompanycompanygroupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(7)] 
     public  string companygroup
     { 
       get { return _companygroup; } 
       set { SetPropertyValue(nameof(companygroup), ref _companygroup, value); } 
     } 
     // Name
     // Notes for fCompany : 
     private string _compannyname; 
     [XafDisplayName("Companny Name"), ToolTip("Companny Name")] 
     // [Appearance("fCompanycompannyname", Enabled = true)]
     // [Appearance("fCompanycompannynameVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(250)] 
     public  string compannyname
     { 
       get { return _compannyname; } 
       set { SetPropertyValue(nameof(compannyname), ref _compannyname, value); } 
     } 
     // Name
     // Notes for fCompany : 
     private string _nameofcompany; 
     [XafDisplayName("Name Of Company"), ToolTip("Name Of Company")] 
     // [Appearance("fCompanynameofcompany", Enabled = true)]
     // [Appearance("fCompanynameofcompanyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(200)] 
     public  string nameofcompany
     { 
       get { return _nameofcompany; } 
       set { SetPropertyValue(nameof(nameofcompany), ref _nameofcompany, value); } 
     } 
     // Search Terms
     // Notes for fCompany : 
     private string _searchterm; 
     [XafDisplayName("Search Term"), ToolTip("Search Term")] 
     // [Appearance("fCompanysearchterm", Enabled = true)]
     // [Appearance("fCompanysearchtermVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(150)] 
     public  string searchterm
     { 
       get { return _searchterm; } 
       set { SetPropertyValue(nameof(searchterm), ref _searchterm, value); } 
     } 
     // Street Address
     // Notes for fCompany : 
     private string _streethousenumber; 
     [XafDisplayName("Street/House Number"), ToolTip("Street/House Number")] 
     // [Appearance("fCompanystreethousenumber", Enabled = true)]
     // [Appearance("fCompanystreethousenumberVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(500)] 
     public  string streethousenumber
     { 
       get { return _streethousenumber; } 
       set { SetPropertyValue(nameof(streethousenumber), ref _streethousenumber, value); } 
     } 
     // Street Address
     // Notes for fCompany : 
     private string _postalcode1; 
     [XafDisplayName("Postal Code 1"), ToolTip("Postal Code 1")] 
     // [Appearance("fCompanypostalcode1", Enabled = true)]
     // [Appearance("fCompanypostalcode1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string postalcode1
     { 
       get { return _postalcode1; } 
       set { SetPropertyValue(nameof(postalcode1), ref _postalcode1, value); } 
     } 
     // Street Address
     // Notes for fCompany : 
     private string _city; 
     [XafDisplayName("City"), ToolTip("City")] 
     // [Appearance("fCompanycity", Enabled = true)]
     // [Appearance("fCompanycityVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(150)] 
     public  string city
     { 
       get { return _city; } 
       set { SetPropertyValue(nameof(city), ref _city, value); } 
     } 
     // Street Address
     // Notes for fCompany : 
     private fCountry _country; 
     [XafDisplayName("Country"), ToolTip("Country")] 
     // [Appearance("fCompanycountry", Enabled = true)]
     // [Appearance("fCompanycountryVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCountry country
     { 
       get { return _country; } 
       set { SetPropertyValue(nameof(country), ref _country, value); } 
     } 
     // Street Address
     // Notes for fCompany : 
     private fRegion _region; 
     [XafDisplayName("Region"), ToolTip("Region")] 
     // [Appearance("fCompanyregion", Enabled = true)]
     // [Appearance("fCompanyregionVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fRegion region
     { 
       get { return _region; } 
       set { SetPropertyValue(nameof(region), ref _region, value); } 
     } 
     // PO Box Address
     // Notes for fCompany : 
     private string _pobox; 
     [XafDisplayName("PO Box"), ToolTip("PO Box")] 
     // [Appearance("fCompanypobox", Enabled = true)]
     // [Appearance("fCompanypoboxVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCompany : 
     private string _postalcode; 
     [XafDisplayName("Postal Code"), ToolTip("Postal Code")] 
     // [Appearance("fCompanypostalcode", Enabled = true)]
     // [Appearance("fCompanypostalcodeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string postalcode
     { 
       get { return _postalcode; } 
       set { SetPropertyValue(nameof(postalcode), ref _postalcode, value); } 
     } 
     // PO Box Address
     // Notes for fCompany : 
     private string _companypostalcode; 
     [XafDisplayName("Company Postal Code"), ToolTip("Company Postal Code")] 
     // [Appearance("fCompanycompanypostalcode", Enabled = true)]
     // [Appearance("fCompanycompanypostalcodeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string companypostalcode
     { 
       get { return _companypostalcode; } 
       set { SetPropertyValue(nameof(companypostalcode), ref _companypostalcode, value); } 
     } 
     // Communication
     // Notes for fCompany : 
     private fLanguage _languange; 
     [XafDisplayName("Languange"), ToolTip("Languange")] 
     // [Appearance("fCompanylanguange", Enabled = true)]
     // [Appearance("fCompanylanguangeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fLanguage languange
     { 
       get { return _languange; } 
       set { SetPropertyValue(nameof(languange), ref _languange, value); } 
     } 
     // Communication
     // Notes for fCompany : 
     private fCurrency _currency; 
     [XafDisplayName("Currency"), ToolTip("Currency")] 
     // [Appearance("fCompanycurrency", Enabled = true)]
     // [Appearance("fCompanycurrencyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCurrency currency
     { 
       get { return _currency; } 
       set { SetPropertyValue(nameof(currency), ref _currency, value); } 
     } 
     // Communication
     // Notes for fCompany : 
     private string _telephone; 
     [XafDisplayName("Telephone"), ToolTip("Telephone")] 
     // [Appearance("fCompanytelephone", Enabled = true)]
     // [Appearance("fCompanytelephoneVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(40)] 
     public  string telephone
     { 
       get { return _telephone; } 
       set { SetPropertyValue(nameof(telephone), ref _telephone, value); } 
     } 
     // Communication
     // Notes for fCompany : 
     private string _extentionph1; 
     [XafDisplayName("Extention (Ph)"), ToolTip("Extention (Ph)")] 
     // [Appearance("fCompanyextentionph1", Enabled = true)]
     // [Appearance("fCompanyextentionph1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(40)] 
     public  string extentionph1
     { 
       get { return _extentionph1; } 
       set { SetPropertyValue(nameof(extentionph1), ref _extentionph1, value); } 
     } 
     // Communication
     // Notes for fCompany : 
     private string _mobilephone; 
     [XafDisplayName("Mobile Phone"), ToolTip("Mobile Phone")] 
     // [Appearance("fCompanymobilephone", Enabled = true)]
     // [Appearance("fCompanymobilephoneVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(40)] 
     public  string mobilephone
     { 
       get { return _mobilephone; } 
       set { SetPropertyValue(nameof(mobilephone), ref _mobilephone, value); } 
     } 
     // Communication
     // Notes for fCompany : 
     private string _fax; 
     [XafDisplayName("Fax"), ToolTip("Fax")] 
     // [Appearance("fCompanyfax", Enabled = true)]
     // [Appearance("fCompanyfaxVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(40)] 
     public  string fax
     { 
       get { return _fax; } 
       set { SetPropertyValue(nameof(fax), ref _fax, value); } 
     } 
     // Communication
     // Notes for fCompany : 
     private string _extentionph2; 
     [XafDisplayName("Extention (Ph)"), ToolTip("Extention (Ph)")] 
     // [Appearance("fCompanyextentionph2", Enabled = true)]
     // [Appearance("fCompanyextentionph2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(40)] 
     public  string extentionph2
     { 
       get { return _extentionph2; } 
       set { SetPropertyValue(nameof(extentionph2), ref _extentionph2, value); } 
     } 
     // Communication
     // Notes for fCompany : 
     private string _email; 
     [XafDisplayName("E-Mail"), ToolTip("E-Mail")] 
     // [Appearance("fCompanyemail", Enabled = true)]
     // [Appearance("fCompanyemailVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(40)] 
     public  string email
     { 
       get { return _email; } 
       set { SetPropertyValue(nameof(email), ref _email, value); } 
     } 
     // 
     // Notes for fCompany : 
     private string _comments; 
     [XafDisplayName("Comments"), ToolTip("Comments")] 
     // [Appearance("fCompanycomments", Enabled = true)]
     // [Appearance("fCompanycommentsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(SizeAttribute.Unlimited)] 
     public  string comments
     { 
       get { return _comments; } 
       set { SetPropertyValue(nameof(comments), ref _comments, value); } 
     } 
     // 
     // Notes for fCompany : 
     //private fChartOfAccts _chartofaccts; 
     //[XafDisplayName("ChartOfAccts"), ToolTip("ChartOfAccts")] 
     //// [Appearance("fCompanychartofaccts", Enabled = true)]
     //// [Appearance("fCompanychartofacctsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     //// [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     //// [RuleRequiredField(DefaultContexts.Save)] 
     //// [IsSearch(true)]
     //[Association("CompanyCOA")] 
     //public  fChartOfAccts chartofaccts
     //{ 
     //  get { return _chartofaccts; } 
     //  set { SetPropertyValue(nameof(chartofaccts), ref _chartofaccts, value); } 
     //} 
   
   private void UpdateByTime() 
   { 
   string tUser = SecuritySystem.CurrentUserName.ToString(); 
   Updateby = Session.FindObject<ApplicationUser>(new BinaryOperator("UserName", tUser)); 
   Updatedate = DateTime.Now; 
   } 
   private ApplicationUser _Updateby; 
   [XafDisplayName("Update by"), ToolTip("Update by")] 
   // [Appearance("fCompanyUpdatebyAppearance", Enabled = false)]
   public ApplicationUser Updateby 
   { 
   get { return _Updateby; } 
   set { SetPropertyValue("Updateby", ref _Updateby, value); } 
   } 
   private DateTime _Updatedate; 
   [XafDisplayName("Update date"), ToolTip("Update date")] 
   // [Appearance("fCompanyUpdatedateAppearance", Enabled = false)]
   public DateTime Updatedate 
   { 
   get 
   { 
    
   return _Updatedate; 
   } 
   set { SetPropertyValue("Updatedate", ref _Updatedate, value); } 
   } 
   } 
} 
