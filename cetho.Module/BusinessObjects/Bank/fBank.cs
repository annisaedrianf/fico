// Class Name : fBank.cs 
// Project Name : FICO 
// Last Update : 22/05/2023 16:25:03  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 22/05/2023 16:25:02 
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
   [DefaultProperty("BankKey")]
   [NavigationItem("Master")]
   // Standard Document
   [System.ComponentModel.DisplayName("Bank")]
   public class fBank : XPObject
   {
     public fBank(Session session) : base(session) 
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
     [Appearance("VisiblefBankOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for fBank : 
     private string _bankkey; 
     [XafDisplayName("Bank Key"), ToolTip("Bank Key")] 
     // [Appearance("fBankbankkey", Enabled = true)]
     // [Appearance("fBankbankkeyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string bankkey
     { 
       get { return _bankkey; } 
       set { SetPropertyValue(nameof(bankkey), ref _bankkey, value); } 
     } 
     // 
     // Notes for fBank : 
     private fCountry _bankcountry; 
     [XafDisplayName("Bank Country"), ToolTip("Bank Country")] 
     // [Appearance("fBankbankcountry", Enabled = true)]
     // [Appearance("fBankbankcountryVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCountry bankcountry
     { 
       get { return _bankcountry; } 
       set { SetPropertyValue(nameof(bankcountry), ref _bankcountry, value); } 
     } 
     // Address
     // Notes for fBank : 
     private string _bankname; 
     [XafDisplayName("Bank Name"), ToolTip("Bank Name")] 
     // [Appearance("fBankbankname", Enabled = true)]
     // [Appearance("fBankbanknameVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(250)] 
     public  string bankname
     { 
       get { return _bankname; } 
       set { SetPropertyValue(nameof(bankname), ref _bankname, value); } 
     } 
     // Address
     // Notes for fBank : 
     private fRegion _region; 
     [XafDisplayName("Region"), ToolTip("Region")] 
     // [Appearance("fBankregion", Enabled = true)]
     // [Appearance("fBankregionVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fRegion region
     { 
       get { return _region; } 
       set { SetPropertyValue(nameof(region), ref _region, value); } 
     } 
     // Address
     // Notes for fBank : 
     private string _street; 
     [XafDisplayName("Street"), ToolTip("Street")] 
     // [Appearance("fBankstreet", Enabled = true)]
     // [Appearance("fBankstreetVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(SizeAttribute.Unlimited)] 
     public  string street
     { 
       get { return _street; } 
       set { SetPropertyValue(nameof(street), ref _street, value); } 
     } 
     // Address
     // Notes for fBank : 
     private string _city; 
     [XafDisplayName("City"), ToolTip("City")] 
     // [Appearance("fBankcity", Enabled = true)]
     // [Appearance("fBankcityVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string city
     { 
       get { return _city; } 
       set { SetPropertyValue(nameof(city), ref _city, value); } 
     } 
     // Control Data
     // Notes for fBank : 
     private string _swiftcode; 
     [XafDisplayName("SWIFT Code"), ToolTip("SWIFT Code")] 
     // [Appearance("fBankswiftcode", Enabled = true)]
     // [Appearance("fBankswiftcodeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fBank : 
     private fBankGroup _bankgroup; 
     [XafDisplayName("Bank Group"), ToolTip("Bank Group")] 
     // [Appearance("fBankbankgroup", Enabled = true)]
     // [Appearance("fBankbankgroupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Association("BankGroups")] 
     public  fBankGroup bankgroup
     { 
       get { return _bankgroup; } 
       set { SetPropertyValue(nameof(bankgroup), ref _bankgroup, value); } 
     } 
     // Control Data
     // Notes for fBank : 
     private bool _postbankacc; 
     [XafDisplayName("Post Bank Acc"), ToolTip("Post Bank Acc")] 
     // [Appearance("fBankpostbankacc", Enabled = true)]
     // [Appearance("fBankpostbankaccVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool postbankacc
     { 
       get { return _postbankacc; } 
       set { SetPropertyValue(nameof(postbankacc), ref _postbankacc, value); } 
     } 
     // Control Data
     // Notes for fBank : 
     private string _banknumber; 
     [XafDisplayName("Bank Number"), ToolTip("Bank Number")] 
     // [Appearance("fBankbanknumber", Enabled = true)]
     // [Appearance("fBankbanknumberVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string banknumber
     { 
       get { return _banknumber; } 
       set { SetPropertyValue(nameof(banknumber), ref _banknumber, value); } 
     } 
     // 
     // Notes for fBank : 
     [XafDisplayName("Bank Acct Number"), ToolTip("Bank Acct Number")] 
     // [Appearance("fBankbankacctnum", Enabled = true)]
     // [Appearance("fBankbankacctnumVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Association("BankAcct")] 
     public XPCollection<fBankAcct> bankacctnum
     {
     get
       {
         return GetCollection<fBankAcct>("bankacctnum"); 
       }
     }
   } 
} 
