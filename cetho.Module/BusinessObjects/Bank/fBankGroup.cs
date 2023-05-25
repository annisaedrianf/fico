// Class Name : fBankGroup.cs 
// Project Name : FICO 
// Last Update : 22/05/2023 16:28:35  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 22/05/2023 16:28:35 
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
   [DefaultProperty("BankGroup")]
   [NavigationItem("Master")]
   // Standard Document
   [System.ComponentModel.DisplayName("Bank Group")]
   public class fBankGroup : XPObject
   {
     public fBankGroup(Session session) : base(session) 
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
     [Appearance("VisiblefBankGroupOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for fBankGroup : 
     private string _bankgroup; 
     [XafDisplayName("Bank Group"), ToolTip("Bank Group")] 
     // [Appearance("fBankGroupbankgroup", Enabled = true)]
     // [Appearance("fBankGroupbankgroupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string bankgroup
     { 
       get { return _bankgroup; } 
       set { SetPropertyValue(nameof(bankgroup), ref _bankgroup, value); } 
     } 
     // 
     // Notes for fBankGroup : 
     private string _name; 
     [XafDisplayName("Name"), ToolTip("Name")] 
     // [Appearance("fBankGroupname", Enabled = true)]
     // [Appearance("fBankGroupnameVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(250)] 
     public  string name
     { 
       get { return _name; } 
       set { SetPropertyValue(nameof(name), ref _name, value); } 
     } 
     // 
     // Notes for fBankGroup : 
     private string _transfercode; 
     [XafDisplayName("Transfer Code"), ToolTip("Transfer Code")] 
     // [Appearance("fBankGrouptransfercode", Enabled = true)]
     // [Appearance("fBankGrouptransfercodeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string transfercode
     { 
       get { return _transfercode; } 
       set { SetPropertyValue(nameof(transfercode), ref _transfercode, value); } 
     } 
     // 
     // Notes for fBankGroup : 
     private fCountry _country; 
     [XafDisplayName("Bank Country"), ToolTip("Bank Country")] 
     // [Appearance("fBankGroupcountry", Enabled = true)]
     // [Appearance("fBankGroupcountryVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCountry country
     { 
       get { return _country; } 
       set { SetPropertyValue(nameof(country), ref _country, value); } 
     } 
     // 
     // Notes for fBankGroup : 
     [XafDisplayName("Banks"), ToolTip("Banks")] 
     // [Appearance("fBankGroupbank", Enabled = true)]
     // [Appearance("fBankGroupbankVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Association("BankGroups")] 
     public XPCollection<fBank> bank
     {
     get
       {
         return GetCollection<fBank>("bank"); 
       }
     }
   } 
} 
