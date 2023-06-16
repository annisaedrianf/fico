// Class Name : fOutlineAgreement.cs 
// Project Name : FICO 
// Last Update : 14/06/2023 12:58:12  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 14/06/2023 12:58:12 
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
   [System.ComponentModel.DisplayName("Create Outline Agreement")]
   public class fOutlineAgreement : XPObject
   {
     public fOutlineAgreement(Session session) : base(session) 
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
     [Appearance("VisiblefOutlineAgreementOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // Administartive Fields
     // Notes for fOutlineAgreement : 
     private DateTime _agreedate1; 
     [XafDisplayName("Agreement Date "), ToolTip("Agreement Date ")] 
     // [Appearance("fOutlineAgreementagreedate1", Enabled = true)]
     // [Appearance("fOutlineAgreementagreedate1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime agreedate1
     { 
       get { return _agreedate1; } 
       set { SetPropertyValue(nameof(agreedate1), ref _agreedate1, value); } 
     } 
     // Administartive Fields
     // Notes for fOutlineAgreement : 
     private DateTime _agreedate3; 
     [XafDisplayName("Agreement Date "), ToolTip("Agreement Date ")] 
     // [Appearance("fOutlineAgreementagreedate3", Enabled = true)]
     // [Appearance("fOutlineAgreementagreedate3Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime agreedate3
     { 
       get { return _agreedate3; } 
       set { SetPropertyValue(nameof(agreedate3), ref _agreedate3, value); } 
     } 
     // Administartive Fields
     // Notes for fOutlineAgreement : 
     private string _itemnumbintervl1; 
     [XafDisplayName("Item Number Interval"), ToolTip("Item Number Interval")] 
     // [Appearance("fOutlineAgreementitemnumbintervl1", Enabled = true)]
     // [Appearance("fOutlineAgreementitemnumbintervl1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string itemnumbintervl1
     { 
       get { return _itemnumbintervl1; } 
       set { SetPropertyValue(nameof(itemnumbintervl1), ref _itemnumbintervl1, value); } 
     } 
     // Administartive Fields
     // Notes for fOutlineAgreement : 
     private string _itemnumbintervl; 
     [XafDisplayName("Item Number Interval"), ToolTip("Item Number Interval")] 
     // [Appearance("fOutlineAgreementitemnumbintervl", Enabled = true)]
     // [Appearance("fOutlineAgreementitemnumbintervlVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string itemnumbintervl
     { 
       get { return _itemnumbintervl; } 
       set { SetPropertyValue(nameof(itemnumbintervl), ref _itemnumbintervl, value); } 
     } 
     // Administartive Fields
     // Notes for fOutlineAgreement : 
     private fLanguage _language1; 
     [XafDisplayName("Language"), ToolTip("Language")] 
     // [Appearance("fOutlineAgreementlanguage1", Enabled = true)]
     // [Appearance("fOutlineAgreementlanguage1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fLanguage language1
     { 
       get { return _language1; } 
       set { SetPropertyValue(nameof(language1), ref _language1, value); } 
     } 
     // Administartive Fields
     // Notes for fOutlineAgreement : 
     private fLanguage _language; 
     [XafDisplayName("Language"), ToolTip("Language")] 
     // [Appearance("fOutlineAgreementlanguage", Enabled = true)]
     // [Appearance("fOutlineAgreementlanguageVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fLanguage language
     { 
       get { return _language; } 
       set { SetPropertyValue(nameof(language), ref _language, value); } 
     } 
     // Administartive Fields
     // Notes for fOutlineAgreement : 
     private DateTime _subiteminterv; 
     [XafDisplayName("Subitem Interv."), ToolTip("Subitem Interv.")] 
     // [Appearance("fOutlineAgreementsubiteminterv", Enabled = true)]
     // [Appearance("fOutlineAgreementsubitemintervVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime subiteminterv1
     { 
       get { return _subiteminterv1; } 
       set { SetPropertyValue(nameof(subiteminterv1), ref _subiteminterv1, value); } 
     } 
     // Administartive Fields
     // Notes for fOutlineAgreement : 
     private DateTime _subiteminterv1; 
     [XafDisplayName("Subitem Interv."), ToolTip("Subitem Interv.")] 
     // [Appearance("fOutlineAgreementsubiteminterv", Enabled = true)]
     // [Appearance("fOutlineAgreementsubitemintervVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime subiteminterv
     { 
       get { return _subiteminterv; } 
       set { SetPropertyValue(nameof(subiteminterv), ref _subiteminterv, value); } 
     } 
     // Administartive Fields
     // Notes for fOutlineAgreement : 
     private DateTime _validend; 
     [XafDisplayName("Validity End"), ToolTip("Validity End")] 
     // [Appearance("fOutlineAgreementvalidend", Enabled = true)]
     // [Appearance("fOutlineAgreementvalidendVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime validend
     { 
       get { return _validend; } 
       set { SetPropertyValue(nameof(validend), ref _validend, value); } 
     } 
     // Administartive Fields
     // Notes for fOutlineAgreement : 
     private DateTime _validend1; 
     [XafDisplayName("Validity End"), ToolTip("Validity End")] 
     // [Appearance("fOutlineAgreementvalidend1", Enabled = true)]
     // [Appearance("fOutlineAgreementvalidend1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime validend1
     { 
       get { return _validend1; } 
       set { SetPropertyValue(nameof(validend1), ref _validend1, value); } 
     } 
     // Administartive Fields
     // Notes for fOutlineAgreement : 
     private DateTime _validstart; 
     [XafDisplayName("Validity Start"), ToolTip("Validity Start")] 
     // [Appearance("fOutlineAgreementvalidstart", Enabled = true)]
     // [Appearance("fOutlineAgreementvalidstartVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime validstart
     { 
       get { return _validstart; } 
       set { SetPropertyValue(nameof(validstart), ref _validstart, value); } 
     } 
     // Administartive Fields
     // Notes for fOutlineAgreement : 
     private DateTime _validstart1; 
     [XafDisplayName("Validity Start"), ToolTip("Validity Start")] 
     // [Appearance("fOutlineAgreementvalidstart1", Enabled = true)]
     // [Appearance("fOutlineAgreementvalidstart1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime validstart1
     { 
       get { return _validstart1; } 
       set { SetPropertyValue(nameof(validstart1), ref _validstart1, value); } 
     } 
     // Create Contract : Header Data
     // Notes for fOutlineAgreement : 
     private string _agree1; 
     [XafDisplayName("Agreement "), ToolTip("Agreement ")] 
     // [Appearance("fOutlineAgreementagree1", Enabled = true)]
     // [Appearance("fOutlineAgreementagree1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string agree1
     { 
       get { return _agree1; } 
       set { SetPropertyValue(nameof(agree1), ref _agree1, value); } 
     } 
     // Create Contract : Header Data
     // Notes for fOutlineAgreement : 
     private string _agreetype1; 
     [XafDisplayName("Agreement Type "), ToolTip("Agreement Type ")] 
     // [Appearance("fOutlineAgreementagreetype1", Enabled = true)]
     // [Appearance("fOutlineAgreementagreetype1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string agreetype1
     { 
       get { return _agreetype1; } 
       set { SetPropertyValue(nameof(agreetype1), ref _agreetype1, value); } 
     } 
     // Create Contract : Header Data
     // Notes for fOutlineAgreement : 
     private fCompany _comcode; 
     [XafDisplayName("Company Code"), ToolTip("Company Code")] 
     // [Appearance("fOutlineAgreementcomcode", Enabled = true)]
     // [Appearance("fOutlineAgreementcomcodeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCompany comcode
     { 
       get { return _comcode; } 
       set { SetPropertyValue(nameof(comcode), ref _comcode, value); } 
     } 
     // Create Contract : Header Data
     // Notes for fOutlineAgreement : 
     private string _purchgroup1; 
     [XafDisplayName("Purchasing Group "), ToolTip("Purchasing Group ")] 
     // [Appearance("fOutlineAgreementpurchgroup1", Enabled = true)]
     // [Appearance("fOutlineAgreementpurchgroup1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string purchgroup1
     { 
       get { return _purchgroup1; } 
       set { SetPropertyValue(nameof(purchgroup1), ref _purchgroup1, value); } 
     } 
     // Create Contract : Header Data
     // Notes for fOutlineAgreement : 
     private string _purchorgn1; 
     [XafDisplayName("Purch. Organization "), ToolTip("Purch. Organization ")] 
     // [Appearance("fOutlineAgreementpurchorgn1", Enabled = true)]
     // [Appearance("fOutlineAgreementpurchorgn1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string purchorgn1
     { 
       get { return _purchorgn1; } 
       set { SetPropertyValue(nameof(purchorgn1), ref _purchorgn1, value); } 
     } 
     // Create Contract : Initial Screen
     // Notes for fOutlineAgreement : 
     private string _agree; 
     [XafDisplayName("Agreement"), ToolTip("Agreement")] 
     // [Appearance("fOutlineAgreementagree", Enabled = true)]
     // [Appearance("fOutlineAgreementagreeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string agree
     { 
       get { return _agree; } 
       set { SetPropertyValue(nameof(agree), ref _agree, value); } 
     } 
     // Create Contract : Initial Screen
     // Notes for fOutlineAgreement : 
     private DateTime _agreedate; 
     [XafDisplayName("Agreement Date"), ToolTip("Agreement Date")] 
     // [Appearance("fOutlineAgreementagreedate", Enabled = true)]
     // [Appearance("fOutlineAgreementagreedateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime agreedate
     { 
       get { return _agreedate; } 
       set { SetPropertyValue(nameof(agreedate), ref _agreedate, value); } 
     } 
     // Create Contract : Initial Screen
     // Notes for fOutlineAgreement : 
     private string _agreetype; 
     [XafDisplayName("Agreement Type"), ToolTip("Agreement Type")] 
     // [Appearance("fOutlineAgreementagreetype", Enabled = true)]
     // [Appearance("fOutlineAgreementagreetypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string agreetype
     { 
       get { return _agreetype; } 
       set { SetPropertyValue(nameof(agreetype), ref _agreetype, value); } 
     } 
     // Create Contract : Initial Screen
     // Notes for fOutlineAgreement : 
     private fVendor _vendor; 
     [XafDisplayName("Vendor"), ToolTip("Vendor")] 
     // [Appearance("fOutlineAgreementvendor", Enabled = true)]
     // [Appearance("fOutlineAgreementvendorVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fVendor vendor
     { 
       get { return _vendor; } 
       set { SetPropertyValue(nameof(vendor), ref _vendor, value); } 
     } 
     // Create Contract : Item Overview
     // Notes for fOutlineAgreement : 
     private string _a; 
     [XafDisplayName("A"), ToolTip("A")] 
     // [Appearance("fOutlineAgreementa", Enabled = true)]
     // [Appearance("fOutlineAgreementaVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string a
     { 
       get { return _a; } 
       set { SetPropertyValue(nameof(a), ref _a, value); } 
     } 
     // Create Contract : Item Overview
     // Notes for fOutlineAgreement : 
     private string _agree2; 
     [XafDisplayName("Agreement "), ToolTip("Agreement ")] 
     // [Appearance("fOutlineAgreementagree2", Enabled = true)]
     // [Appearance("fOutlineAgreementagree2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string agree2
     { 
       get { return _agree2; } 
       set { SetPropertyValue(nameof(agree2), ref _agree2, value); } 
     } 
     // Create Contract : Item Overview
     // Notes for fOutlineAgreement : 
     private DateTime _agreedate2; 
     [XafDisplayName("Agreement Date "), ToolTip("Agreement Date ")] 
     // [Appearance("fOutlineAgreementagreedate2", Enabled = true)]
     // [Appearance("fOutlineAgreementagreedate2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime agreedate2
     { 
       get { return _agreedate2; } 
       set { SetPropertyValue(nameof(agreedate2), ref _agreedate2, value); } 
     } 
     // Create Contract : Item Overview
     // Notes for fOutlineAgreement : 
     private string _agreetype2; 
     [XafDisplayName("Agreement Type "), ToolTip("Agreement Type ")] 
     // [Appearance("fOutlineAgreementagreetype2", Enabled = true)]
     // [Appearance("fOutlineAgreementagreetype2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string agreetype2
     { 
       get { return _agreetype2; } 
       set { SetPropertyValue(nameof(agreetype2), ref _agreetype2, value); } 
     } 
     // Create Contract : Item Overview
     // Notes for fOutlineAgreement : 
     private fCurrency _currency; 
     [XafDisplayName("Currency"), ToolTip("Currency")] 
     // [Appearance("fOutlineAgreementcurrency", Enabled = true)]
     // [Appearance("fOutlineAgreementcurrencyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCurrency currency
     { 
       get { return _currency; } 
       set { SetPropertyValue(nameof(currency), ref _currency, value); } 
     } 
     // Create Contract : Item Overview
     // Notes for fOutlineAgreement : 
     private string _i; 
     [XafDisplayName("I"), ToolTip("I")] 
     // [Appearance("fOutlineAgreementi", Enabled = true)]
     // [Appearance("fOutlineAgreementiVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string i
     { 
       get { return _i; } 
       set { SetPropertyValue(nameof(i), ref _i, value); } 
     } 
     // Create Contract : Item Overview
     // Notes for fOutlineAgreement : 
     private string _item; 
     [XafDisplayName("Item"), ToolTip("Item")] 
     // [Appearance("fOutlineAgreementitem", Enabled = true)]
     // [Appearance("fOutlineAgreementitemVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string item
     { 
       get { return _item; } 
       set { SetPropertyValue(nameof(item), ref _item, value); } 
     } 
     // Create Contract : Item Overview
     // Notes for fOutlineAgreement : 
     private string _material; 
     [XafDisplayName("Material"), ToolTip("Material")] 
     // [Appearance("fOutlineAgreementmaterial", Enabled = true)]
     // [Appearance("fOutlineAgreementmaterialVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string material
     { 
       get { return _material; } 
       set { SetPropertyValue(nameof(material), ref _material, value); } 
     } 
     // Create Contract : Item Overview
     // Notes for fOutlineAgreement : 
     private double _netprice; 
     [XafDisplayName("Net Price"), ToolTip("Net Price")] 
     // [Appearance("fOutlineAgreementnetprice", Enabled = true)]
     // [Appearance("fOutlineAgreementnetpriceVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double netprice
     { 
       get { return _netprice; } 
       set { SetPropertyValue(nameof(netprice), ref _netprice, value); } 
     } 
     // Create Contract : Item Overview
     // Notes for fOutlineAgreement : 
     private string _o; 
     [XafDisplayName("O…"), ToolTip("O…")] 
     // [Appearance("fOutlineAgreemento", Enabled = true)]
     // [Appearance("fOutlineAgreementoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string o
     { 
       get { return _o; } 
       set { SetPropertyValue(nameof(o), ref _o, value); } 
     } 
     // Create Contract : Item Overview
     // Notes for fOutlineAgreement : 
     private string _shorttext; 
     [XafDisplayName("Short Text"), ToolTip("Short Text")] 
     // [Appearance("fOutlineAgreementshorttext", Enabled = true)]
     // [Appearance("fOutlineAgreementshorttextVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string shorttext
     { 
       get { return _shorttext; } 
       set { SetPropertyValue(nameof(shorttext), ref _shorttext, value); } 
     } 
     // Create Contract : Item Overview
     // Notes for fOutlineAgreement : 
     private string _targqty; 
     [XafDisplayName("Targ. Qty"), ToolTip("Targ. Qty")] 
     // [Appearance("fOutlineAgreementtargqty", Enabled = true)]
     // [Appearance("fOutlineAgreementtargqtyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string targqty
     { 
       get { return _targqty; } 
       set { SetPropertyValue(nameof(targqty), ref _targqty, value); } 
     } 
     // Create Contract : Item Overview
     // Notes for fOutlineAgreement : 
     private fVendor _vendor1; 
     [XafDisplayName("Vendor "), ToolTip("Vendor ")] 
     // [Appearance("fOutlineAgreementvendor1", Enabled = true)]
     // [Appearance("fOutlineAgreementvendor1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fVendor vendor1
     { 
       get { return _vendor1; } 
       set { SetPropertyValue(nameof(vendor1), ref _vendor1, value); } 
     } 
     // Create Schedulling Agreement : Header Data
     // Notes for fOutlineAgreement : 
     private string _agree3; 
     [XafDisplayName("Agreement "), ToolTip("Agreement ")] 
     // [Appearance("fOutlineAgreementagree3", Enabled = true)]
     // [Appearance("fOutlineAgreementagree3Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string agree3
     { 
       get { return _agree3; } 
       set { SetPropertyValue(nameof(agree3), ref _agree3, value); } 
     } 
     // Create Schedulling Agreement : Header Data
     // Notes for fOutlineAgreement : 
     private string _agreetype3; 
     [XafDisplayName("Agreement Type "), ToolTip("Agreement Type ")] 
     // [Appearance("fOutlineAgreementagreetype3", Enabled = true)]
     // [Appearance("fOutlineAgreementagreetype3Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string agreetype3
     { 
       get { return _agreetype3; } 
       set { SetPropertyValue(nameof(agreetype3), ref _agreetype3, value); } 
     } 
     // Create Schedulling Agreement : Header Data
     // Notes for fOutlineAgreement : 
     private fCompany _compcode; 
     [XafDisplayName("Company Code "), ToolTip("Company Code ")] 
     // [Appearance("fOutlineAgreementcompcode", Enabled = true)]
     // [Appearance("fOutlineAgreementcompcodeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCompany compcode
     { 
       get { return _compcode; } 
       set { SetPropertyValue(nameof(compcode), ref _compcode, value); } 
     } 
     // Create Schedulling Agreement : Header Data
     // Notes for fOutlineAgreement : 
     private string _purchgroup2; 
     [XafDisplayName("Purchasing Group "), ToolTip("Purchasing Group ")] 
     // [Appearance("fOutlineAgreementpurchgroup2", Enabled = true)]
     // [Appearance("fOutlineAgreementpurchgroup2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string purchgroup2
     { 
       get { return _purchgroup2; } 
       set { SetPropertyValue(nameof(purchgroup2), ref _purchgroup2, value); } 
     } 
     // Create Schedulling Agreement : Header Data
     // Notes for fOutlineAgreement : 
     private string _purchorgn2; 
     [XafDisplayName("Purch. Organization "), ToolTip("Purch. Organization ")] 
     // [Appearance("fOutlineAgreementpurchorgn2", Enabled = true)]
     // [Appearance("fOutlineAgreementpurchorgn2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string purchorgn2
     { 
       get { return _purchorgn2; } 
       set { SetPropertyValue(nameof(purchorgn2), ref _purchorgn2, value); } 
     } 
     // Create Schedulling Agreement : Header Data
     // Notes for fOutlineAgreement : 
     private fVendor _vendor2; 
     [XafDisplayName("Vendor "), ToolTip("Vendor ")] 
     // [Appearance("fOutlineAgreementvendor2", Enabled = true)]
     // [Appearance("fOutlineAgreementvendor2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fVendor vendor2
     { 
       get { return _vendor2; } 
       set { SetPropertyValue(nameof(vendor2), ref _vendor2, value); } 
     } 
     // Organizational Data
     // Notes for fOutlineAgreement : 
     private string _purchgroup; 
     [XafDisplayName("Purchasing Group"), ToolTip("Purchasing Group")] 
     // [Appearance("fOutlineAgreementpurchgroup", Enabled = true)]
     // [Appearance("fOutlineAgreementpurchgroupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string purchgroup
     { 
       get { return _purchgroup; } 
       set { SetPropertyValue(nameof(purchgroup), ref _purchgroup, value); } 
     } 
     // Organizational Data
     // Notes for fOutlineAgreement : 
     private string _purchorgn; 
     [XafDisplayName("Purch. Organization"), ToolTip("Purch. Organization")] 
     // [Appearance("fOutlineAgreementpurchorgn", Enabled = true)]
     // [Appearance("fOutlineAgreementpurchorgnVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string purchorgn
     { 
       get { return _purchorgn; } 
       set { SetPropertyValue(nameof(purchorgn), ref _purchorgn, value); } 
     } 
   } 
} 
