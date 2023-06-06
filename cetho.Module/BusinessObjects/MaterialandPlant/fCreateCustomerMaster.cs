// Class Name : fCreateCustomerMaster.cs 
// Project Name : FICO 
// Last Update : 06/06/2023 13:47:28  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 06/06/2023 13:47:28 
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
using cetho.Module.BusinessObjects;

namespace cetho.Module.BusinessObjects 
{ 
   [DefaultClassOptions] 
   [ImageName("ModelEditor_Views")] 
   [DefaultProperty("TaxCatgr")]
   [NavigationItem("Master")]
   // Standard Document
   [System.ComponentModel.DisplayName("Create Customer Master By T-Code")]
   public class fCreateCustomerMaster : XPObject
   {
     public fCreateCustomerMaster(Session session) : base(session) 
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
     [Appearance("VisiblefCreateCustomerMasterOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // Address
     // Notes for fCreateCustomerMaster : 
     private string _buildcode; 
     [XafDisplayName("Building Code"), ToolTip("Building Code")] 
     // [Appearance("fCreateCustomerMasterbuildcode", Enabled = true)]
     // [Appearance("fCreateCustomerMasterbuildcodeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string buildcode
     { 
       get { return _buildcode; } 
       set { SetPropertyValue(nameof(buildcode), ref _buildcode, value); } 
     } 
     // Address
     // Notes for fCreateCustomerMaster : 
     private string _co; 
     [XafDisplayName("C/O"), ToolTip("c/o")] 
     // [Appearance("fCreateCustomerMasterco", Enabled = true)]
     // [Appearance("fCreateCustomerMastercoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string co
     { 
       get { return _co; } 
       set { SetPropertyValue(nameof(co), ref _co, value); } 
     } 
     // Address
     // Notes for fCreateCustomerMaster : 
     private string _district; 
     [XafDisplayName("District"), ToolTip("District")] 
     // [Appearance("fCreateCustomerMasterdistrict", Enabled = true)]
     // [Appearance("fCreateCustomerMasterdistrictVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string district
     { 
       get { return _district; } 
       set { SetPropertyValue(nameof(district), ref _district, value); } 
     } 
     // Address
     // Notes for fCreateCustomerMaster : 
     private string _floor; 
     [XafDisplayName("Floor"), ToolTip("Floor")] 
     // [Appearance("fCreateCustomerMasterfloor", Enabled = true)]
     // [Appearance("fCreateCustomerMasterfloorVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string floor
     { 
       get { return _floor; } 
       set { SetPropertyValue(nameof(floor), ref _floor, value); } 
     } 
     // Address
     // Notes for fCreateCustomerMaster : 
     private string _name; 
     [XafDisplayName("Name"), ToolTip("Name")] 
     // [Appearance("fCreateCustomerMastername", Enabled = true)]
     // [Appearance("fCreateCustomerMasternameVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(200)] 
     public  string name
     { 
       get { return _name; } 
       set { SetPropertyValue(nameof(name), ref _name, value); } 
     } 
     // Address
     // Notes for fCreateCustomerMaster : 
     private string _room; 
     [XafDisplayName("Room"), ToolTip("Room")] 
     // [Appearance("fCreateCustomerMasterroom", Enabled = true)]
     // [Appearance("fCreateCustomerMasterroomVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string room
     { 
       get { return _room; } 
       set { SetPropertyValue(nameof(room), ref _room, value); } 
     } 
     // Address
     // Notes for fCreateCustomerMaster : 
     private string _searchterm; 
     [XafDisplayName("Search Term 1/2"), ToolTip("Search term 1/2")] 
     // [Appearance("fCreateCustomerMastersearchterm", Enabled = true)]
     // [Appearance("fCreateCustomerMastersearchtermVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string searchterm
     { 
       get { return _searchterm; } 
       set { SetPropertyValue(nameof(searchterm), ref _searchterm, value); } 
     } 
     // Address
     // Notes for fCreateCustomerMaster : 
     private string _street; 
     [XafDisplayName("Street/House Number"), ToolTip("Street/House number")] 
     // [Appearance("fCreateCustomerMasterstreet", Enabled = true)]
     // [Appearance("fCreateCustomerMasterstreetVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string street
     { 
       get { return _street; } 
       set { SetPropertyValue(nameof(street), ref _street, value); } 
     } 
     // Address
     // Notes for fCreateCustomerMaster : 
     private string _street2; 
     [XafDisplayName("Street 2 "), ToolTip("Street 2 ")] 
     // [Appearance("fCreateCustomerMasterstreet2", Enabled = true)]
     // [Appearance("fCreateCustomerMasterstreet2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string street2
     { 
       get { return _street2; } 
       set { SetPropertyValue(nameof(street2), ref _street2, value); } 
     } 
     // Address
     // Notes for fCreateCustomerMaster : 
     private string _street3; 
     [XafDisplayName("Street 3"), ToolTip("Street 3")] 
     // [Appearance("fCreateCustomerMasterstreet3", Enabled = true)]
     // [Appearance("fCreateCustomerMasterstreet3Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string street3
     { 
       get { return _street3; } 
       set { SetPropertyValue(nameof(street3), ref _street3, value); } 
     } 
     // Address
     // Notes for fCreateCustomerMaster : 
     private string _street4; 
     [XafDisplayName("Street 4"), ToolTip("Street 4")] 
     // [Appearance("fCreateCustomerMasterstreet4", Enabled = true)]
     // [Appearance("fCreateCustomerMasterstreet4Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string street4
     { 
       get { return _street4; } 
       set { SetPropertyValue(nameof(street4), ref _street4, value); } 
     } 
     // Address
     // Notes for fCreateCustomerMaster : 
     private string _street5; 
     [XafDisplayName("Street 5"), ToolTip("Street 5")] 
     // [Appearance("fCreateCustomerMasterstreet5", Enabled = true)]
     // [Appearance("fCreateCustomerMasterstreet5Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string street5
     { 
       get { return _street5; } 
       set { SetPropertyValue(nameof(street5), ref _street5, value); } 
     } 
     // Address
     // Notes for fCreateCustomerMaster : 
     private string _suupl; 
     [XafDisplayName("Suppl."), ToolTip("Suppl.")] 
     // [Appearance("fCreateCustomerMastersuupl", Enabled = true)]
     // [Appearance("fCreateCustomerMastersuuplVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string suupl
     { 
       get { return _suupl; } 
       set { SetPropertyValue(nameof(suupl), ref _suupl, value); } 
     } 
     // Address
     // Notes for fCreateCustomerMaster : 
     private enumTitle _title; 
     [XafDisplayName("Title"), ToolTip("Title")] 
     // [Appearance("fCreateCustomerMastertitle", Enabled = true)]
     // [Appearance("fCreateCustomerMastertitleVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumTitle title
     { 
       get { return _title; } 
       set { SetPropertyValue(nameof(title), ref _title, value); } 
     } 
     // Bank Data
     // Notes for fCreateCustomerMaster : 
     private fBank _bankbranch; 
     [XafDisplayName("Bank Branch"), ToolTip("Bank Branch")] 
     // [Appearance("fCreateCustomerMasterbankbranch", Enabled = true)]
     // [Appearance("fCreateCustomerMasterbankbranchVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fBank bankbranch
     { 
       get { return _bankbranch; } 
       set { SetPropertyValue(nameof(bankbranch), ref _bankbranch, value); } 
     } 
     // Bank Data
     // Notes for fCreateCustomerMaster : 
     private fBank _bankcountry; 
     [XafDisplayName("Bank Country"), ToolTip("Bank Country")] 
     // [Appearance("fCreateCustomerMasterbankcountry", Enabled = true)]
     // [Appearance("fCreateCustomerMasterbankcountryVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fBank bankcountry
     { 
       get { return _bankcountry; } 
       set { SetPropertyValue(nameof(bankcountry), ref _bankcountry, value); } 
     } 
     // Bank Data
     // Notes for fCreateCustomerMaster : 
     private fBank _bankgrp; 
     [XafDisplayName("Bank Group"), ToolTip("Bank group")] 
     // [Appearance("fCreateCustomerMasterbankgrp", Enabled = true)]
     // [Appearance("fCreateCustomerMasterbankgrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fBank bankgrp
     { 
       get { return _bankgrp; } 
       set { SetPropertyValue(nameof(bankgrp), ref _bankgrp, value); } 
     } 
     // Bank Data
     // Notes for fCreateCustomerMaster : 
     private fBank _bankkey; 
     [XafDisplayName("Bank Key"), ToolTip("Bank Key")] 
     // [Appearance("fCreateCustomerMasterbankkey", Enabled = true)]
     // [Appearance("fCreateCustomerMasterbankkeyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fBank bankkey
     { 
       get { return _bankkey; } 
       set { SetPropertyValue(nameof(bankkey), ref _bankkey, value); } 
     } 
     // Bank Data
     // Notes for fCreateCustomerMaster : 
     private fBank _bankname; 
     [XafDisplayName("Bank Name"), ToolTip("Bank Name")] 
     // [Appearance("fCreateCustomerMasterbankname", Enabled = true)]
     // [Appearance("fCreateCustomerMasterbanknameVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fBank bankname
     { 
       get { return _bankname; } 
       set { SetPropertyValue(nameof(bankname), ref _bankname, value); } 
     } 
     // Bank Data
     // Notes for fCreateCustomerMaster : 
     private fBank _banknumb; 
     [XafDisplayName("Bank Number"), ToolTip("Bank Number")] 
     // [Appearance("fCreateCustomerMasterbanknumb", Enabled = true)]
     // [Appearance("fCreateCustomerMasterbanknumbVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fBank banknumb
     { 
       get { return _banknumb; } 
       set { SetPropertyValue(nameof(banknumb), ref _banknumb, value); } 
     } 
     // Bank Data
     // Notes for fCreateCustomerMaster : 
     private fCountry _city; 
     [XafDisplayName("City"), ToolTip("City")] 
     // [Appearance("fCreateCustomerMastercity", Enabled = true)]
     // [Appearance("fCreateCustomerMastercityVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCountry city
     { 
       get { return _city; } 
       set { SetPropertyValue(nameof(city), ref _city, value); } 
     } 
     // Bank Data
     // Notes for fCreateCustomerMaster : 
     private bool _postbankacc; 
     [XafDisplayName("Postbank Acct"), ToolTip("Postbank Acct")] 
     // [Appearance("fCreateCustomerMasterpostbankacc", Enabled = true)]
     // [Appearance("fCreateCustomerMasterpostbankaccVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool postbankacc
     { 
       get { return _postbankacc; } 
       set { SetPropertyValue(nameof(postbankacc), ref _postbankacc, value); } 
     } 
     // Bank Data
     // Notes for fCreateCustomerMaster : 
     private fRegion _region; 
     [XafDisplayName("Region"), ToolTip("Region")] 
     // [Appearance("fCreateCustomerMasterregion", Enabled = true)]
     // [Appearance("fCreateCustomerMasterregionVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fRegion region
     { 
       get { return _region; } 
       set { SetPropertyValue(nameof(region), ref _region, value); } 
     } 
     // Bank Data
     // Notes for fCreateCustomerMaster : 
     private string _street1; 
     [XafDisplayName("Street"), ToolTip("Street")] 
     // [Appearance("fCreateCustomerMasterstreet1", Enabled = true)]
     // [Appearance("fCreateCustomerMasterstreet1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string street1
     { 
       get { return _street1; } 
       set { SetPropertyValue(nameof(street1), ref _street1, value); } 
     } 
     // Bank Data
     // Notes for fCreateCustomerMaster : 
     private string _swiftcode; 
     [XafDisplayName("SWIFT Code"), ToolTip("SWIFTcode")] 
     // [Appearance("fCreateCustomerMasterswiftcode", Enabled = true)]
     // [Appearance("fCreateCustomerMasterswiftcodeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string swiftcode
     { 
       get { return _swiftcode; } 
       set { SetPropertyValue(nameof(swiftcode), ref _swiftcode, value); } 
     } 
     // Control Data
     // Notes for fCreateCustomerMaster : 
     private string _autho; 
     [XafDisplayName("Authorization"), ToolTip("Authorization")] 
     // [Appearance("fCreateCustomerMasterautho", Enabled = true)]
     // [Appearance("fCreateCustomerMasterauthoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string autho
     { 
       get { return _autho; } 
       set { SetPropertyValue(nameof(autho), ref _autho, value); } 
     } 
     // Control Data
     // Notes for fCreateCustomerMaster : 
     private string _chkdigit; 
     [XafDisplayName("Check Digit"), ToolTip("Check digit")] 
     // [Appearance("fCreateCustomerMasterchkdigit", Enabled = true)]
     // [Appearance("fCreateCustomerMasterchkdigitVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string chkdigit
     { 
       get { return _chkdigit; } 
       set { SetPropertyValue(nameof(chkdigit), ref _chkdigit, value); } 
     } 
     // Control Data
     // Notes for fCreateCustomerMaster : 
     private string _corgrp; 
     [XafDisplayName("Corporate Group"), ToolTip("Corporate Group")] 
     // [Appearance("fCreateCustomerMastercorgrp", Enabled = true)]
     // [Appearance("fCreateCustomerMastercorgrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string corgrp
     { 
       get { return _corgrp; } 
       set { SetPropertyValue(nameof(corgrp), ref _corgrp, value); } 
     } 
     // Control Data
     // Notes for fCreateCustomerMaster : 
     private bool _equaltax; 
     [XafDisplayName("Equalizatn Tax"), ToolTip("Equalizatn tax")] 
     // [Appearance("fCreateCustomerMasterequaltax", Enabled = true)]
     // [Appearance("fCreateCustomerMasterequaltaxVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool equaltax
     { 
       get { return _equaltax; } 
       set { SetPropertyValue(nameof(equaltax), ref _equaltax, value); } 
     } 
     // Control Data
     // Notes for fCreateCustomerMaster : 
     private string _expressstation; 
     [XafDisplayName("Express Station"), ToolTip("Express station")] 
     // [Appearance("fCreateCustomerMasterexpressstation", Enabled = true)]
     // [Appearance("fCreateCustomerMasterexpressstationVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string expressstation
     { 
       get { return _expressstation; } 
       set { SetPropertyValue(nameof(expressstation), ref _expressstation, value); } 
     } 
     // Control Data
     // Notes for fCreateCustomerMaster : 
     private string _industry; 
     [XafDisplayName("Industry"), ToolTip("Industry")] 
     // [Appearance("fCreateCustomerMasterindustry", Enabled = true)]
     // [Appearance("fCreateCustomerMasterindustryVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string industry
     { 
       get { return _industry; } 
       set { SetPropertyValue(nameof(industry), ref _industry, value); } 
     } 
     // Control Data
     // Notes for fCreateCustomerMaster : 
     private string _loc1; 
     [XafDisplayName("Location No. 1"), ToolTip("Location no. 1")] 
     // [Appearance("fCreateCustomerMasterloc1", Enabled = true)]
     // [Appearance("fCreateCustomerMasterloc1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string loc1
     { 
       get { return _loc1; } 
       set { SetPropertyValue(nameof(loc1), ref _loc1, value); } 
     } 
     // Control Data
     // Notes for fCreateCustomerMaster : 
     private string _loc2; 
     [XafDisplayName("Location No. 2"), ToolTip("Location no. 2")] 
     // [Appearance("fCreateCustomerMasterloc2", Enabled = true)]
     // [Appearance("fCreateCustomerMasterloc2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string loc2
     { 
       get { return _loc2; } 
       set { SetPropertyValue(nameof(loc2), ref _loc2, value); } 
     } 
     // Control Data
     // Notes for fCreateCustomerMaster : 
     private string _loccode; 
     [XafDisplayName("Location Code"), ToolTip("Location code")] 
     // [Appearance("fCreateCustomerMasterloccode", Enabled = true)]
     // [Appearance("fCreateCustomerMasterloccodeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string loccode
     { 
       get { return _loccode; } 
       set { SetPropertyValue(nameof(loccode), ref _loccode, value); } 
     } 
     // Control Data
     // Notes for fCreateCustomerMaster : 
     private bool _ntrlperson; 
     [XafDisplayName("Natural Person"), ToolTip("Natural person")] 
     // [Appearance("fCreateCustomerMasterntrlperson", Enabled = true)]
     // [Appearance("fCreateCustomerMasterntrlpersonVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool ntrlperson
     { 
       get { return _ntrlperson; } 
       set { SetPropertyValue(nameof(ntrlperson), ref _ntrlperson, value); } 
     } 
     // Control Data
     // Notes for fCreateCustomerMaster : 
     private string _tax1; 
     [XafDisplayName("Tax Number 1"), ToolTip("Tax Number 1")] 
     // [Appearance("fCreateCustomerMastertax1", Enabled = true)]
     // [Appearance("fCreateCustomerMastertax1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string tax1
     { 
       get { return _tax1; } 
       set { SetPropertyValue(nameof(tax1), ref _tax1, value); } 
     } 
     // Control Data
     // Notes for fCreateCustomerMaster : 
     private string _tax2; 
     [XafDisplayName("Tax Number 2"), ToolTip("Tax Number 2")] 
     // [Appearance("fCreateCustomerMastertax2", Enabled = true)]
     // [Appearance("fCreateCustomerMastertax2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string tax2
     { 
       get { return _tax2; } 
       set { SetPropertyValue(nameof(tax2), ref _tax2, value); } 
     } 
     // Control Data
     // Notes for fCreateCustomerMaster : 
     private string _taxnumbtype; 
     [XafDisplayName("Tax Number Type"), ToolTip("Tax number type")] 
     // [Appearance("fCreateCustomerMastertaxnumbtype", Enabled = true)]
     // [Appearance("fCreateCustomerMastertaxnumbtypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string taxnumbtype
     { 
       get { return _taxnumbtype; } 
       set { SetPropertyValue(nameof(taxnumbtype), ref _taxnumbtype, value); } 
     } 
     // Control Data
     // Notes for fCreateCustomerMaster : 
     private string _taxtype; 
     [XafDisplayName("Tax Type"), ToolTip("Tax type")] 
     // [Appearance("fCreateCustomerMastertaxtype", Enabled = true)]
     // [Appearance("fCreateCustomerMastertaxtypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string taxtype
     { 
       get { return _taxtype; } 
       set { SetPropertyValue(nameof(taxtype), ref _taxtype, value); } 
     } 
     // Control Data
     // Notes for fCreateCustomerMaster : 
     private string _tradpartner; 
     [XafDisplayName("Trading Partner"), ToolTip("Trading Partner")] 
     // [Appearance("fCreateCustomerMastertradpartner", Enabled = true)]
     // [Appearance("fCreateCustomerMastertradpartnerVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string tradpartner
     { 
       get { return _tradpartner; } 
       set { SetPropertyValue(nameof(tradpartner), ref _tradpartner, value); } 
     } 
     // Control Data
     // Notes for fCreateCustomerMaster : 
     private string _trainsstation; 
     [XafDisplayName("Train Station"), ToolTip("Train station")] 
     // [Appearance("fCreateCustomerMastertrainsstation", Enabled = true)]
     // [Appearance("fCreateCustomerMastertrainsstationVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string trainsstation
     { 
       get { return _trainsstation; } 
       set { SetPropertyValue(nameof(trainsstation), ref _trainsstation, value); } 
     } 
     // Control Data
     // Notes for fCreateCustomerMaster : 
     private string _transportzone; 
     [XafDisplayName("Transport Zone"), ToolTip("Transportzone")] 
     // [Appearance("fCreateCustomerMastertransportzone", Enabled = true)]
     // [Appearance("fCreateCustomerMastertransportzoneVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string transportzone
     { 
       get { return _transportzone; } 
       set { SetPropertyValue(nameof(transportzone), ref _transportzone, value); } 
     } 
     // Control Data
     // Notes for fCreateCustomerMaster : 
     private fVendor _vendor; 
     [XafDisplayName("Vendor"), ToolTip("Vendor")] 
     // [Appearance("fCreateCustomerMastervendor", Enabled = true)]
     // [Appearance("fCreateCustomerMastervendorVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fVendor vendor
     { 
       get { return _vendor; } 
       set { SetPropertyValue(nameof(vendor), ref _vendor, value); } 
     } 
     // Payment Transactions
     // Notes for fCreateCustomerMaster : 
     private  _acchold; 
     [XafDisplayName("Acct Holder"), ToolTip("Acct Holder")] 
     // [Appearance("fCreateCustomerMasteracchold", Enabled = true)]
     // [Appearance("fCreateCustomerMasteraccholdVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public   acchold
     { 
       get { return _acchold; } 
       set { SetPropertyValue(nameof(acchold), ref _acchold, value); } 
     } 
     // Payment Transactions
     // Notes for fCreateCustomerMaster : 
     private fBankAcct _bankacc; 
     [XafDisplayName("Bank Account"), ToolTip("Bank Account")] 
     // [Appearance("fCreateCustomerMasterbankacc", Enabled = true)]
     // [Appearance("fCreateCustomerMasterbankaccVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fBankAcct bankacc
     { 
       get { return _bankacc; } 
       set { SetPropertyValue(nameof(bankacc), ref _bankacc, value); } 
     } 
     // Payment Transactions
     // Notes for fCreateCustomerMaster : 
     private fBank _bankkey1; 
     [XafDisplayName("Bank Key (Pymt)"), ToolTip("Bank Key (Pymt)")] 
     // [Appearance("fCreateCustomerMasterbankkey1", Enabled = true)]
     // [Appearance("fCreateCustomerMasterbankkey1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fBank bankkey1
     { 
       get { return _bankkey1; } 
       set { SetPropertyValue(nameof(bankkey1), ref _bankkey1, value); } 
     } 
     // Payment Transactions
     // Notes for fCreateCustomerMaster : 
     private fCountry _city1; 
     [XafDisplayName("City (Pymt)"), ToolTip("City (Pymt)")] 
     // [Appearance("fCreateCustomerMastercity1", Enabled = true)]
     // [Appearance("fCreateCustomerMastercity1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCountry city1
     { 
       get { return _city1; } 
       set { SetPropertyValue(nameof(city1), ref _city1, value); } 
     } 
     // Sales
     // Notes for fCreateCustomerMaster : 
     private string _abcclass; 
     [XafDisplayName("ABC class"), ToolTip("ABC class")] 
     // [Appearance("fCreateCustomerMasterabcclass", Enabled = true)]
     // [Appearance("fCreateCustomerMasterabcclassVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string abcclass
     { 
       get { return _abcclass; } 
       set { SetPropertyValue(nameof(abcclass), ref _abcclass, value); } 
     } 
     // Sales
     // Notes for fCreateCustomerMaster : 
     private string _acctatcust; 
     [XafDisplayName("Acct at cust"), ToolTip("Acct at cust")] 
     // [Appearance("fCreateCustomerMasteracctatcust", Enabled = true)]
     // [Appearance("fCreateCustomerMasteracctatcustVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string acctatcust
     { 
       get { return _acctatcust; } 
       set { SetPropertyValue(nameof(acctatcust), ref _acctatcust, value); } 
     } 
     // Sales
     // Notes for fCreateCustomerMaster : 
     private string _authogrp; 
     [XafDisplayName("AuthorizGroup"), ToolTip("AuthorizGroup")] 
     // [Appearance("fCreateCustomerMasterauthogrp", Enabled = true)]
     // [Appearance("fCreateCustomerMasterauthogrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string authogrp
     { 
       get { return _authogrp; } 
       set { SetPropertyValue(nameof(authogrp), ref _authogrp, value); } 
     } 
     // Sales
     // Notes for fCreateCustomerMaster : 
     private fCurrency _currency; 
     [XafDisplayName("Currency"), ToolTip("Currency")] 
     // [Appearance("fCreateCustomerMastercurrency", Enabled = true)]
     // [Appearance("fCreateCustomerMastercurrencyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCurrency currency
     { 
       get { return _currency; } 
       set { SetPropertyValue(nameof(currency), ref _currency, value); } 
     } 
     // Sales
     // Notes for fCreateCustomerMaster : 
     private string _custgrp; 
     [XafDisplayName("Customer group"), ToolTip("Customer group")] 
     // [Appearance("fCreateCustomerMastercustgrp", Enabled = true)]
     // [Appearance("fCreateCustomerMastercustgrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string custgrp
     { 
       get { return _custgrp; } 
       set { SetPropertyValue(nameof(custgrp), ref _custgrp, value); } 
     } 
     // Sales
     // Notes for fCreateCustomerMaster : 
     private string _custpricproc; 
     [XafDisplayName("Cust pric procedure"), ToolTip("Cust pric procedure")] 
     // [Appearance("fCreateCustomerMastercustpricproc", Enabled = true)]
     // [Appearance("fCreateCustomerMastercustpricprocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string custpricproc
     { 
       get { return _custpricproc; } 
       set { SetPropertyValue(nameof(custpricproc), ref _custpricproc, value); } 
     } 
     // Sales
     // Notes for fCreateCustomerMaster : 
     private string _custstatgrp; 
     [XafDisplayName("Cust Stats.Grp"), ToolTip("Cust Stats.Grp")] 
     // [Appearance("fCreateCustomerMastercuststatgrp", Enabled = true)]
     // [Appearance("fCreateCustomerMastercuststatgrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string custstatgrp
     { 
       get { return _custstatgrp; } 
       set { SetPropertyValue(nameof(custstatgrp), ref _custstatgrp, value); } 
     } 
     // Sales
     // Notes for fCreateCustomerMaster : 
     private string _exchratetype; 
     [XafDisplayName("Exch. Rate Type"), ToolTip("Exch. Rate Type")] 
     // [Appearance("fCreateCustomerMasterexchratetype", Enabled = true)]
     // [Appearance("fCreateCustomerMasterexchratetypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string exchratetype
     { 
       get { return _exchratetype; } 
       set { SetPropertyValue(nameof(exchratetype), ref _exchratetype, value); } 
     } 
     // Sales
     // Notes for fCreateCustomerMaster : 
     private string _itemprop; 
     [XafDisplayName("Item proposal"), ToolTip("Item proposal")] 
     // [Appearance("fCreateCustomerMasteritemprop", Enabled = true)]
     // [Appearance("fCreateCustomerMasteritempropVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(15)] 
     public  string itemprop
     { 
       get { return _itemprop; } 
       set { SetPropertyValue(nameof(itemprop), ref _itemprop, value); } 
     } 
     // Sales
     // Notes for fCreateCustomerMaster : 
     private string _orderprobab; 
     [XafDisplayName("Order probab."), ToolTip("Order probab.")] 
     // [Appearance("fCreateCustomerMasterorderprobab", Enabled = true)]
     // [Appearance("fCreateCustomerMasterorderprobabVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string orderprobab
     { 
       get { return _orderprobab; } 
       set { SetPropertyValue(nameof(orderprobab), ref _orderprobab, value); } 
     } 
     // Sales
     // Notes for fCreateCustomerMaster : 
     private string _ppcutsproc; 
     [XafDisplayName("PP cust proc."), ToolTip("PP cust proc.")] 
     // [Appearance("fCreateCustomerMasterppcutsproc", Enabled = true)]
     // [Appearance("fCreateCustomerMasterppcutsprocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string ppcutsproc
     { 
       get { return _ppcutsproc; } 
       set { SetPropertyValue(nameof(ppcutsproc), ref _ppcutsproc, value); } 
     } 
     // Sales
     // Notes for fCreateCustomerMaster : 
     private string _pricegrp; 
     [XafDisplayName("Price group"), ToolTip("Price group")] 
     // [Appearance("fCreateCustomerMasterpricegrp", Enabled = true)]
     // [Appearance("fCreateCustomerMasterpricegrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string pricegrp
     { 
       get { return _pricegrp; } 
       set { SetPropertyValue(nameof(pricegrp), ref _pricegrp, value); } 
     } 
     // Sales
     // Notes for fCreateCustomerMaster : 
     private string _pricelist; 
     [XafDisplayName("Price List"), ToolTip("Price List")] 
     // [Appearance("fCreateCustomerMasterpricelist", Enabled = true)]
     // [Appearance("fCreateCustomerMasterpricelistVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string pricelist
     { 
       get { return _pricelist; } 
       set { SetPropertyValue(nameof(pricelist), ref _pricelist, value); } 
     } 
     // Sales
     // Notes for fCreateCustomerMaster : 
     private string _salesdistric; 
     [XafDisplayName("Sales distric"), ToolTip("Sales distric")] 
     // [Appearance("fCreateCustomerMastersalesdistric", Enabled = true)]
     // [Appearance("fCreateCustomerMastersalesdistricVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string salesdistric
     { 
       get { return _salesdistric; } 
       set { SetPropertyValue(nameof(salesdistric), ref _salesdistric, value); } 
     } 
     // Sales
     // Notes for fCreateCustomerMaster : 
     private string _salesgrp; 
     [XafDisplayName("Sales Group"), ToolTip("Sales Group")] 
     // [Appearance("fCreateCustomerMastersalesgrp", Enabled = true)]
     // [Appearance("fCreateCustomerMastersalesgrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string salesgrp
     { 
       get { return _salesgrp; } 
       set { SetPropertyValue(nameof(salesgrp), ref _salesgrp, value); } 
     } 
     // Sales
     // Notes for fCreateCustomerMaster : 
     private string _salesoffice; 
     [XafDisplayName("Sales Office"), ToolTip("Sales Office")] 
     // [Appearance("fCreateCustomerMastersalesoffice", Enabled = true)]
     // [Appearance("fCreateCustomerMastersalesofficeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string salesoffice
     { 
       get { return _salesoffice; } 
       set { SetPropertyValue(nameof(salesoffice), ref _salesoffice, value); } 
     } 
     // Sales
     // Notes for fCreateCustomerMaster : 
     private bool _switchoffround; 
     [XafDisplayName("Switch off rounding"), ToolTip("Switch off rounding")] 
     // [Appearance("fCreateCustomerMasterswitchoffround", Enabled = true)]
     // [Appearance("fCreateCustomerMasterswitchoffroundVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool switchoffround
     { 
       get { return _switchoffround; } 
       set { SetPropertyValue(nameof(switchoffround), ref _switchoffround, value); } 
     } 
     // Sales
     // Notes for fCreateCustomerMaster : 
     private string _uomgrp; 
     [XafDisplayName("UoM Group"), ToolTip("UoM Group")] 
     // [Appearance("fCreateCustomerMasteruomgrp", Enabled = true)]
     // [Appearance("fCreateCustomerMasteruomgrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string uomgrp
     { 
       get { return _uomgrp; } 
       set { SetPropertyValue(nameof(uomgrp), ref _uomgrp, value); } 
     } 
     // 
     // Notes for fCreateCustomerMaster : 
     private string _cust; 
     [XafDisplayName("Customer"), ToolTip("Customer")] 
     // [Appearance("fCreateCustomerMastercust", Enabled = true)]
     // [Appearance("fCreateCustomerMastercustVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string cust
     { 
       get { return _cust; } 
       set { SetPropertyValue(nameof(cust), ref _cust, value); } 
     } 
     // 
     // Notes for fCreateCustomerMaster : 
     private string _distrchnl; 
     [XafDisplayName("Distr. Channel"), ToolTip("Distr. Channel")] 
     // [Appearance("fCreateCustomerMasterdistrchnl", Enabled = true)]
     // [Appearance("fCreateCustomerMasterdistrchnlVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string distrchnl
     { 
       get { return _distrchnl; } 
       set { SetPropertyValue(nameof(distrchnl), ref _distrchnl, value); } 
     } 
     // 
     // Notes for fCreateCustomerMaster : 
     private string _division; 
     [XafDisplayName("Division"), ToolTip("Division")] 
     // [Appearance("fCreateCustomerMasterdivision", Enabled = true)]
     // [Appearance("fCreateCustomerMasterdivisionVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string division
     { 
       get { return _division; } 
       set { SetPropertyValue(nameof(division), ref _division, value); } 
     } 
     // 
     // Notes for fCreateCustomerMaster : 
     private string _salesorg; 
     [XafDisplayName("Sales Org."), ToolTip("Sales Org.")] 
     // [Appearance("fCreateCustomerMastersalesorg", Enabled = true)]
     // [Appearance("fCreateCustomerMastersalesorgVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string salesorg
     { 
       get { return _salesorg; } 
       set { SetPropertyValue(nameof(salesorg), ref _salesorg, value); } 
     } 
   } 
} 
