// Class Name : fTaxDetermination.cs 
// Project Name : FICO 
// Last Update : 29/05/2023 15:21:35  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 29/05/2023 15:21:34 
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
   [System.ComponentModel.DisplayName("Change View (Customer Taxes): Overview")]
   public class fTaxDetermination : XPObject
   {
     public fTaxDetermination(Session session) : base(session) 
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
     [Appearance("VisiblefTaxDeterminationOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // New Entries: Overview of Added Entries
     // Notes for fTaxDetermination : 
     private string _taxctg; 
     [XafDisplayName("Tax Categ"), ToolTip("Tax categ")] 
     // [Appearance("fTaxDeterminationtaxctg", Enabled = true)]
     // [Appearance("fTaxDeterminationtaxctgVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string taxctg
     { 
       get { return _taxctg; } 
       set { SetPropertyValue(nameof(taxctg), ref _taxctg, value); } 
     } 
     // New Entries: Overview of Added Entries
     // Notes for fTaxDetermination : 
     private string _taxclass; 
     [XafDisplayName("Tax Class."), ToolTip("Tax class.")] 
     // [Appearance("fTaxDeterminationtaxclass", Enabled = true)]
     // [Appearance("fTaxDeterminationtaxclassVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string taxclass
     { 
       get { return _taxclass; } 
       set { SetPropertyValue(nameof(taxclass), ref _taxclass, value); } 
     } 
     // New Entries: Overview of Added Entries
     // Notes for fTaxDetermination : 
     private string _desc; 
     [XafDisplayName("Description"), ToolTip("Description")] 
     // [Appearance("fTaxDeterminationdesc", Enabled = true)]
     // [Appearance("fTaxDeterminationdescVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string desc
     { 
       get { return _desc; } 
       set { SetPropertyValue(nameof(desc), ref _desc, value); } 
     } 
     // Change View "Taxes: Tax Categories by Country": Overview
     // Notes for fTaxDetermination : 
     private fCountry _taxcount; 
     [XafDisplayName("Tax Count"), ToolTip("Tax count.")] 
     // [Appearance("fTaxDeterminationtaxcount", Enabled = true)]
     // [Appearance("fTaxDeterminationtaxcountVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCountry taxcount
     { 
       get { return _taxcount; } 
       set { SetPropertyValue(nameof(taxcount), ref _taxcount, value); } 
     } 
     // Change View "Taxes: Tax Categories by Country": Overview
     // Notes for fTaxDetermination : 
     private string _name; 
     [XafDisplayName("Name"), ToolTip("Name")] 
     // [Appearance("fTaxDeterminationname", Enabled = true)]
     // [Appearance("fTaxDeterminationnameVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string name
     { 
       get { return _name; } 
       set { SetPropertyValue(nameof(name), ref _name, value); } 
     } 
     // Change View "Taxes: Tax Categories by Country": Overview
     // Notes for fTaxDetermination : 
     private string _seq; 
     [XafDisplayName("Seq."), ToolTip("Seq.")] 
     // [Appearance("fTaxDeterminationseq", Enabled = true)]
     // [Appearance("fTaxDeterminationseqVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string seq
     { 
       get { return _seq; } 
       set { SetPropertyValue(nameof(seq), ref _seq, value); } 
     } 
     // Change View "Taxes: Tax Categories by Country": Overview
     // Notes for fTaxDetermination : 
     private string _taxctgchg; 
     [XafDisplayName("Tax Categ. by Country"), ToolTip("Tax Categ. by Country")] 
     // [Appearance("fTaxDeterminationtaxctgchg", Enabled = true)]
     // [Appearance("fTaxDeterminationtaxctgchgVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string taxctgchg
     { 
       get { return _taxctgchg; } 
       set { SetPropertyValue(nameof(taxctgchg), ref _taxctgchg, value); } 
     } 
     // Change View "Taxes: Tax Categories by Country": Overview
     // Notes for fTaxDetermination : 
     private string _namechg; 
     [XafDisplayName("Name"), ToolTip("Name")] 
     // [Appearance("fTaxDeterminationname", Enabled = true)]
     // [Appearance("fTaxDeterminationnameVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string namechg
     { 
       get { return _namechg; } 
       set { SetPropertyValue(nameof(namechg), ref _namechg, value); } 
     } 
     // Change View "Plants": Overview
     // Notes for fTaxDetermination : 
     private string _plntchg; 
     [XafDisplayName("Plants"), ToolTip("Plants")] 
     // [Appearance("fTaxDeterminationplntchg", Enabled = true)]
     // [Appearance("fTaxDeterminationplntchgVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string plntchg
     { 
       get { return _plntchg; } 
       set { SetPropertyValue(nameof(plntchg), ref _plntchg, value); } 
     } 
     // Change View "Plants": Overview
     // Notes for fTaxDetermination : 
     private string _name1chg; 
     [XafDisplayName("Name 1 (Plants)"), ToolTip("Name 1 (Plants)")] 
     // [Appearance("fTaxDeterminationname1chg", Enabled = true)]
     // [Appearance("fTaxDeterminationname1chgVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string name1chg
     { 
       get { return _name1chg; } 
       set { SetPropertyValue(nameof(name1chg), ref _name1chg, value); } 
     } 
     // Change View "Plants": Overview
     // Notes for fTaxDetermination : 
     private string _name2chg; 
     [XafDisplayName("Name 2 (Plants)"), ToolTip("Name 2 (Plants)")] 
     // [Appearance("fTaxDeterminationname2chg", Enabled = true)]
     // [Appearance("fTaxDeterminationname2chgVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string name2chg
     { 
       get { return _name2chg; } 
       set { SetPropertyValue(nameof(name2chg), ref _name2chg, value); } 
     } 
     // New Entries: Details of Added Entries
     // Notes for fTaxDetermination : 
     private string _plntnew; 
     [XafDisplayName("Plants"), ToolTip("Plants")] 
     // [Appearance("fTaxDeterminationplntnew", Enabled = true)]
     // [Appearance("fTaxDeterminationplntnewVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string plntnew
     { 
       get { return _plntnew; } 
       set { SetPropertyValue(nameof(plntnew), ref _plntnew, value); } 
     } 
     // New Entries: Details of Added Entries
     // Notes for fTaxDetermination : 
     private string _name1; 
     [XafDisplayName("Name 1 "), ToolTip("Name 1 ")] 
     // [Appearance("fTaxDeterminationname1", Enabled = true)]
     // [Appearance("fTaxDeterminationname1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string name1
     { 
       get { return _name1; } 
       set { SetPropertyValue(nameof(name1), ref _name1, value); } 
     } 
     // New Entries: Details of Added Entries
     // Notes for fTaxDetermination : 
     private string _name2; 
     [XafDisplayName("Name 2"), ToolTip("Name 2")] 
     // [Appearance("fTaxDeterminationname2", Enabled = true)]
     // [Appearance("fTaxDeterminationname2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string name2
     { 
       get { return _name2; } 
       set { SetPropertyValue(nameof(name2), ref _name2, value); } 
     } 
     // Detailed Information
     // Notes for fTaxDetermination : 
     private fLanguage _langkey; 
     [XafDisplayName("Languange Key"), ToolTip("Languange Key")] 
     // [Appearance("fTaxDeterminationlangkey", Enabled = true)]
     // [Appearance("fTaxDeterminationlangkeyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fLanguage langkey
     { 
       get { return _langkey; } 
       set { SetPropertyValue(nameof(langkey), ref _langkey, value); } 
     } 
     // Detailed Information
     // Notes for fTaxDetermination : 
     private string _housenumb; 
     [XafDisplayName("House Number/Street"), ToolTip("House number/street")] 
     // [Appearance("fTaxDeterminationhousenumb", Enabled = true)]
     // [Appearance("fTaxDeterminationhousenumbVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string housenumb
     { 
       get { return _housenumb; } 
       set { SetPropertyValue(nameof(housenumb), ref _housenumb, value); } 
     } 
     // Detailed Information
     // Notes for fTaxDetermination : 
     private string _pobox; 
     [XafDisplayName("PO Box"), ToolTip("PO Box")] 
     // [Appearance("fTaxDeterminationpobox", Enabled = true)]
     // [Appearance("fTaxDeterminationpoboxVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string pobox
     { 
       get { return _pobox; } 
       set { SetPropertyValue(nameof(pobox), ref _pobox, value); } 
     } 
     // Detailed Information
     // Notes for fTaxDetermination : 
     private string _postcode; 
     [XafDisplayName("Postal Code"), ToolTip("Postal Code")] 
     // [Appearance("fTaxDeterminationpostcode", Enabled = true)]
     // [Appearance("fTaxDeterminationpostcodeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string postcode
     { 
       get { return _postcode; } 
       set { SetPropertyValue(nameof(postcode), ref _postcode, value); } 
     } 
     // Detailed Information
     // Notes for fTaxDetermination : 
     private fRegion _city; 
     [XafDisplayName("City"), ToolTip("City")] 
     // [Appearance("fTaxDeterminationcity", Enabled = true)]
     // [Appearance("fTaxDeterminationcityVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fRegion city
     { 
       get { return _city; } 
       set { SetPropertyValue(nameof(city), ref _city, value); } 
     } 
     // Detailed Information
     // Notes for fTaxDetermination : 
     private fCountry _countkey; 
     [XafDisplayName("Country Key"), ToolTip("Country Key")] 
     // [Appearance("fTaxDeterminationcountkey", Enabled = true)]
     // [Appearance("fTaxDeterminationcountkeyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCountry countkey
     { 
       get { return _countkey; } 
       set { SetPropertyValue(nameof(countkey), ref _countkey, value); } 
     } 
     // Detailed Information
     // Notes for fTaxDetermination : 
     private fRegion _citycode; 
     [XafDisplayName("City Code"), ToolTip("City Code")] 
     // [Appearance("fTaxDeterminationcitycode", Enabled = true)]
     // [Appearance("fTaxDeterminationcitycodeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fRegion citycode
     { 
       get { return _citycode; } 
       set { SetPropertyValue(nameof(citycode), ref _citycode, value); } 
     } 
     // Detailed Information
     // Notes for fTaxDetermination : 
     private string _taxjuris; 
     [XafDisplayName("Tax Jurisdiction"), ToolTip("Tax Jurisdiction")] 
     // [Appearance("fTaxDeterminationtaxjuris", Enabled = true)]
     // [Appearance("fTaxDeterminationtaxjurisVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string taxjuris
     { 
       get { return _taxjuris; } 
       set { SetPropertyValue(nameof(taxjuris), ref _taxjuris, value); } 
     } 
     // Change View "Material Taxes": Overview
     // Notes for fTaxDetermination : 
     private string _taxctgchg1; 
     [XafDisplayName("Tax Categ. (Material Taxes)"), ToolTip("Tax categ. (Material Taxes)")] 
     // [Appearance("fTaxDeterminationtaxctgchg1", Enabled = true)]
     // [Appearance("fTaxDeterminationtaxctgchg1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string taxctgchg1
     { 
       get { return _taxctgchg1; } 
       set { SetPropertyValue(nameof(taxctgchg1), ref _taxctgchg1, value); } 
     } 
     // Change View "Material Taxes": Overview
     // Notes for fTaxDetermination : 
     private string _taxclasschg; 
     [XafDisplayName("Tax Class. (Material Taxes)"), ToolTip("Tax class. (Material Taxes)")] 
     // [Appearance("fTaxDeterminationtaxclasschg", Enabled = true)]
     // [Appearance("fTaxDeterminationtaxclasschgVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string taxclasschg
     { 
       get { return _taxclasschg; } 
       set { SetPropertyValue(nameof(taxclasschg), ref _taxclasschg, value); } 
     } 
     // Change View "Material Taxes": Overview
     // Notes for fTaxDetermination : 
     private string _descchg; 
     [XafDisplayName("Description (Material Taxes)"), ToolTip("Description (Material Taxes)")] 
     // [Appearance("fTaxDeterminationdescchg", Enabled = true)]
     // [Appearance("fTaxDeterminationdescchgVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string descchg
     { 
       get { return _descchg; } 
       set { SetPropertyValue(nameof(descchg), ref _descchg, value); } 
     } 
     // Change Condition Records
     // Notes for fTaxDetermination : 
     private string _condtype; 
     [XafDisplayName("Condition Type"), ToolTip("Condition type")] 
     // [Appearance("fTaxDeterminationcondtype", Enabled = true)]
     // [Appearance("fTaxDeterminationcondtypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string condtype
     { 
       get { return _condtype; } 
       set { SetPropertyValue(nameof(condtype), ref _condtype, value); } 
     } 
     // Key Combination
     // Notes for fTaxDetermination : 
     private bool _derpcount; 
     [XafDisplayName("Derpature Country / Destination Country"), ToolTip("Derpature Country /Destination Country")] 
     // [Appearance("fTaxDeterminationderpcount", Enabled = true)]
     // [Appearance("fTaxDeterminationderpcountVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool derpcount
     { 
       get { return _derpcount; } 
       set { SetPropertyValue(nameof(derpcount), ref _derpcount, value); } 
     } 
     // Key Combination
     // Notes for fTaxDetermination : 
     private bool _domestictax; 
     [XafDisplayName("Domestic Taxes"), ToolTip("Domestic Taxes")] 
     // [Appearance("fTaxDeterminationdomestictax", Enabled = true)]
     // [Appearance("fTaxDeterminationdomestictaxVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool domestictax
     { 
       get { return _domestictax; } 
       set { SetPropertyValue(nameof(domestictax), ref _domestictax, value); } 
     } 
     // Key Combination
     // Notes for fTaxDetermination : 
     private bool _exportstax; 
     [XafDisplayName("Exports Taxes"), ToolTip("Exports Taxes")] 
     // [Appearance("fTaxDeterminationexportstax", Enabled = true)]
     // [Appearance("fTaxDeterminationexportstaxVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool exportstax
     { 
       get { return _exportstax; } 
       set { SetPropertyValue(nameof(exportstax), ref _exportstax, value); } 
     } 
     // Change Sales Tax (WUST): Selection
     // Notes for fTaxDetermination : 
     private fCountry _country; 
     [XafDisplayName("Country"), ToolTip("Country")] 
     // [Appearance("fTaxDeterminationcountry", Enabled = true)]
     // [Appearance("fTaxDeterminationcountryVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCountry country
     { 
       get { return _country; } 
       set { SetPropertyValue(nameof(country), ref _country, value); } 
     } 
     // Change Sales Tax (WUST): Selection
     // Notes for fTaxDetermination : 
     private string _taxclass1; 
     [XafDisplayName("Tax Class1-Cust,"), ToolTip("TaxClass1-Cust,")] 
     // [Appearance("fTaxDeterminationtaxclass1", Enabled = true)]
     // [Appearance("fTaxDeterminationtaxclass1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string taxclass1
     { 
       get { return _taxclass1; } 
       set { SetPropertyValue(nameof(taxclass1), ref _taxclass1, value); } 
     } 
     // Change Sales Tax (WUST): Selection
     // Notes for fTaxDetermination : 
     private string _taxclassmatl; 
     [XafDisplayName("Tax Class-Material"), ToolTip("Tax class. Material")] 
     // [Appearance("fTaxDeterminationtaxclassmatl", Enabled = true)]
     // [Appearance("fTaxDeterminationtaxclassmatlVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string taxclassmatl
     { 
       get { return _taxclassmatl; } 
       set { SetPropertyValue(nameof(taxclassmatl), ref _taxclassmatl, value); } 
     } 
     // Change Sales Tax (WUST): Selection
     // Notes for fTaxDetermination : 
     private DateTime _validon; 
     [XafDisplayName("Valid On"), ToolTip("Valid On")] 
     // [Appearance("fTaxDeterminationvalidon", Enabled = true)]
     // [Appearance("fTaxDeterminationvalidonVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime validon
     { 
       get { return _validon; } 
       set { SetPropertyValue(nameof(validon), ref _validon, value); } 
     } 
     // Domestic Taxes
     // Notes for fTaxDetermination : 
     private string _taxcl1cuts; 
     [XafDisplayName("Tax Cl1-Cuts"), ToolTip("TaxCl1Cuts")] 
     // [Appearance("fTaxDeterminationtaxcl1cuts", Enabled = true)]
     // [Appearance("fTaxDeterminationtaxcl1cutsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string taxcl1cuts
     { 
       get { return _taxcl1cuts; } 
       set { SetPropertyValue(nameof(taxcl1cuts), ref _taxcl1cuts, value); } 
     } 
     // Domestic Taxes
     // Notes for fTaxDetermination : 
     private string _taxclmat; 
     [XafDisplayName("Tax Cl-Mat"), ToolTip("TaxCl.Mat")] 
     // [Appearance("fTaxDeterminationtaxclmat", Enabled = true)]
     // [Appearance("fTaxDeterminationtaxclmatVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string taxclmat
     { 
       get { return _taxclmat; } 
       set { SetPropertyValue(nameof(taxclmat), ref _taxclmat, value); } 
     } 
     // Domestic Taxes
     // Notes for fTaxDetermination : 
     private double _amount; 
     [XafDisplayName("Amount"), ToolTip("Amount")] 
     // [Appearance("fTaxDeterminationamount", Enabled = true)]
     // [Appearance("fTaxDeterminationamountVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double amount
     { 
       get { return _amount; } 
       set { SetPropertyValue(nameof(amount), ref _amount, value); } 
     } 
     // Domestic Taxes
     // Notes for fTaxDetermination : 
     private string _unit; 
     [XafDisplayName("Unit"), ToolTip("Unit")] 
     // [Appearance("fTaxDeterminationunit", Enabled = true)]
     // [Appearance("fTaxDeterminationunitVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string unit
     { 
       get { return _unit; } 
       set { SetPropertyValue(nameof(unit), ref _unit, value); } 
     } 
     // Domestic Taxes
     // Notes for fTaxDetermination : 
     private DateTime _vldfrm; 
     [XafDisplayName("Valid From"), ToolTip("Valid From")] 
     // [Appearance("fTaxDeterminationvldfrm", Enabled = true)]
     // [Appearance("fTaxDeterminationvldfrmVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime vldfrm
     { 
       get { return _vldfrm; } 
       set { SetPropertyValue(nameof(vldfrm), ref _vldfrm, value); } 
     } 
     // Domestic Taxes
     // Notes for fTaxDetermination : 
     private DateTime _vldto; 
     [XafDisplayName("Valid To"), ToolTip("Valid To")] 
     // [Appearance("fTaxDeterminationvldto", Enabled = true)]
     // [Appearance("fTaxDeterminationvldtoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime vldto
     { 
       get { return _vldto; } 
       set { SetPropertyValue(nameof(vldto), ref _vldto, value); } 
     } 
     // Domestic Taxes
     // Notes for fTaxDetermination : 
     private string _taxcode; 
     [XafDisplayName("Tax Code"), ToolTip("Tax Code")] 
     // [Appearance("fTaxDeterminationtaxcode", Enabled = true)]
     // [Appearance("fTaxDeterminationtaxcodeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string taxcode
     { 
       get { return _taxcode; } 
       set { SetPropertyValue(nameof(taxcode), ref _taxcode, value); } 
     } 
   } 
} 
