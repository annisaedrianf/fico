// Class Name : fBankAcct.cs 
// Project Name : FICO 
// Last Update : 22/05/2023 16:27:32  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 22/05/2023 16:27:32 
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
   [DefaultProperty("BankAcctNum")]
   [NavigationItem("Master")]
   // Standard Document
   [System.ComponentModel.DisplayName("Bank Acct")]
   public class fBankAcct : XPObject
   {
     public fBankAcct(Session session) : base(session) 
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
     [Appearance("VisiblefBankAcctOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for fBankAcct : 
     private fBank _bankacctnum; 
     [XafDisplayName("Bank Acct Number"), ToolTip("Bank Acct Number")] 
     // [Appearance("fBankAcctbankacctnum", Enabled = true)]
     // [Appearance("fBankAcctbankacctnumVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fBank bankacctnum
     { 
       get { return _bankacctnum; } 
       set { SetPropertyValue(nameof(bankacctnum), ref _bankacctnum, value); } 
     } 
     // 
     // Notes for fBankAcct : 
     private string _bankacctname; 
     [XafDisplayName("Bank Acct Name"), ToolTip("Bank Acct Name")] 
     // [Appearance("fBankAcctbankacctname", Enabled = true)]
     // [Appearance("fBankAcctbankacctnameVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string bankacctname
     { 
       get { return _bankacctname; } 
       set { SetPropertyValue(nameof(bankacctname), ref _bankacctname, value); } 
     } 
     // Address
     // Notes for fBankAcct : 
     private string _alternativeacctno; 
     [XafDisplayName("Alternative Acct No"), ToolTip("Alternative Acct No")] 
     // [Appearance("fBankAcctalternativeacctno", Enabled = true)]
     // [Appearance("fBankAcctalternativeacctnoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string alternativeacctno
     { 
       get { return _alternativeacctno; } 
       set { SetPropertyValue(nameof(alternativeacctno), ref _alternativeacctno, value); } 
     } 
     // Address
     // Notes for fBankAcct : 
     private fCurrency _currency; 
     [XafDisplayName("Currency"), ToolTip("Currency")] 
     // [Appearance("fBankAcctcurrency", Enabled = true)]
     // [Appearance("fBankAcctcurrencyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCurrency currency
     { 
       get { return _currency; } 
       set { SetPropertyValue(nameof(currency), ref _currency, value); } 
     } 
     // Address
     // Notes for fBankAcct : 
     private string _controlkey; 
     [XafDisplayName("Control Key"), ToolTip("Control Key")] 
     // [Appearance("fBankAcctcontrolkey", Enabled = true)]
     // [Appearance("fBankAcctcontrolkeyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string controlkey
     { 
       get { return _controlkey; } 
       set { SetPropertyValue(nameof(controlkey), ref _controlkey, value); } 
     } 
     // Address
     // Notes for fBankAcct : 
     private fGLAcct _glacct; 
     [XafDisplayName("G/L"), ToolTip("G/L")] 
     // [Appearance("fBankAcctglacct", Enabled = true)]
     // [Appearance("fBankAcctglacctVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fGLAcct glacct
     { 
       get { return _glacct; } 
       set { SetPropertyValue(nameof(glacct), ref _glacct, value); } 
     } 
     // Control Data
     // Notes for fBankAcct : 
     private fGLAcct _discountacct; 
     [XafDisplayName("Discount Acct"), ToolTip("Discount Acct")] 
     // [Appearance("fBankAcctdiscountacct", Enabled = true)]
     // [Appearance("fBankAcctdiscountacctVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fGLAcct discountacct
     { 
       get { return _discountacct; } 
       set { SetPropertyValue(nameof(discountacct), ref _discountacct, value); } 
     } 
     // 
     // Notes for fBankAcct : 
     private fBank _bank; 
     [XafDisplayName("Bank"), ToolTip("Bank")] 
     // [Appearance("fBankAcctbank", Enabled = true)]
     // [Appearance("fBankAcctbankVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Association("BankAcct")] 
     public  fBank bank
     { 
       get { return _bank; } 
       set { SetPropertyValue(nameof(bank), ref _bank, value); } 
     } 
   } 
} 
