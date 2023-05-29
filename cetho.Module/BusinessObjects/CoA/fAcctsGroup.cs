// Class Name : fAcctsGroup.cs 
// Project Name : FICO 
// Last Update : 22/05/2023 16:33:16  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 22/05/2023 16:33:16 
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
   [DefaultProperty("")]
   [NavigationItem("Master")]
   // Standard Document
   [System.ComponentModel.DisplayName("Accounts Group")]
   public class fAcctsGroup : XPObject
   {
     public fAcctsGroup(Session session) : base(session) 
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
     [Appearance("VisiblefAcctsGroupOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for fAcctsGroup : 
     private string _acctgroup; 
     [XafDisplayName("Acct Group"), ToolTip("Acct Group")] 
     // [Appearance("fAcctsGroupacctgroup", Enabled = true)]
     // [Appearance("fAcctsGroupacctgroupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string acctgroup
     { 
       get { return _acctgroup; } 
       set { SetPropertyValue(nameof(acctgroup), ref _acctgroup, value); } 
     } 
     // 
     // Notes for fAcctsGroup : 
     private string _name; 
     [XafDisplayName("Name"), ToolTip("Name")] 
     // [Appearance("fAcctsGroupname", Enabled = true)]
     // [Appearance("fAcctsGroupnameVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fAcctsGroup : 
     private string _fromacct; 
     [XafDisplayName("From Acct"), ToolTip("From Acct")] 
     // [Appearance("fAcctsGroupfromacct", Enabled = true)]
     // [Appearance("fAcctsGroupfromacctVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(12)] 
     public  string fromacct
     { 
       get { return _fromacct; } 
       set { SetPropertyValue(nameof(fromacct), ref _fromacct, value); } 
     } 
     // 
     // Notes for fAcctsGroup : 
     private string _toacct; 
     [XafDisplayName("To Acct"), ToolTip("To Acct")] 
     // [Appearance("fAcctsGrouptoacct", Enabled = true)]
     // [Appearance("fAcctsGrouptoacctVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(12)] 
     public  string toacct
     { 
       get { return _toacct; } 
       set { SetPropertyValue(nameof(toacct), ref _toacct, value); } 
     } 
     // 
     // Notes for fAcctsGroup : 
     private fChartOfAccts _chartofaccts; 
     [XafDisplayName("Chart Of Accts"), ToolTip("Chart Of Accts")] 
     // [Appearance("fAcctsGroupchartofaccts", Enabled = true)]
     // [Appearance("fAcctsGroupchartofacctsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Association("AcctGroups")] 
     public  fChartOfAccts chartofaccts
     { 
       get { return _chartofaccts; } 
       set { SetPropertyValue(nameof(chartofaccts), ref _chartofaccts, value); } 
     } 
     // 
     // Notes for fAcctsGroup : 
     private fAcctsControl _acctscontrol; 
     [XafDisplayName("Account Control"), ToolTip("Account Control")] 
     // [Appearance("fAcctsGroupacctscontrol", Enabled = true)]
     // [Appearance("fAcctsGroupacctscontrolVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fAcctsControl acctscontrol
     { 
       get { return _acctscontrol; } 
       set { SetPropertyValue(nameof(acctscontrol), ref _acctscontrol, value); } 
     } 
     // 
     // Notes for fAcctsGroup : 
     private object _acctsmanagemnt; 
     [XafDisplayName("Account Management"), ToolTip("Account Management")] 
     // [Appearance("fAcctsGroupacctsmanagemnt", Enabled = true)]
     // [Appearance("fAcctsGroupacctsmanagemntVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  object acctsmanagemnt
     { 
       get { return _acctsmanagemnt; } 
       set { SetPropertyValue(nameof(acctsmanagemnt), ref _acctsmanagemnt, value); } 
     } 
     // 
     // Notes for fAcctsGroup : 
     private object _docentry; 
     [XafDisplayName("Document Entry"), ToolTip("Document entry")] 
     // [Appearance("fAcctsGroupdocentry", Enabled = true)]
     // [Appearance("fAcctsGroupdocentryVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  object docentry
     { 
       get { return _docentry; } 
       set { SetPropertyValue(nameof(docentry), ref _docentry, value); } 
     } 
     // 
     // Notes for fAcctsGroup : 
     private object _bankfindetail; 
     [XafDisplayName("Bank/Financial Detail"), ToolTip("Bank/financial detail")] 
     // [Appearance("fAcctsGroupbankfindetail", Enabled = true)]
     // [Appearance("fAcctsGroupbankfindetailVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  object bankfindetail
     { 
       get { return _bankfindetail; } 
       set { SetPropertyValue(nameof(bankfindetail), ref _bankfindetail, value); } 
     } 
     // 
     // Notes for fAcctsGroup : 
     private object _interestcalculation; 
     [XafDisplayName("Interest Calculation"), ToolTip("Interest calculation")] 
     // [Appearance("fAcctsGroupinterestcalculation", Enabled = true)]
     // [Appearance("fAcctsGroupinterestcalculationVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  object interestcalculation
     { 
       get { return _interestcalculation; } 
       set { SetPropertyValue(nameof(interestcalculation), ref _interestcalculation, value); } 
     } 
     // 
     // Notes for fAcctsGroup : 
     private object _jointventure; 
     [XafDisplayName("Joint Venture"), ToolTip("Joint venture")] 
     // [Appearance("fAcctsGroupjointventure", Enabled = true)]
     // [Appearance("fAcctsGroupjointventureVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  object jointventure
     { 
       get { return _jointventure; } 
       set { SetPropertyValue(nameof(jointventure), ref _jointventure, value); } 
     } 
   } 
} 
