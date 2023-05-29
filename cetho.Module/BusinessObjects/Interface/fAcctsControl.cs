// Class Name : fAcctsControl.cs 
// Project Name : FICO 
// Last Update : 22/05/2023 16:46:33  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 22/05/2023 16:46:33 
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
   [System.ComponentModel.DisplayName("Account Control")]
   public class fAcctsControl : XPObject
   {
     public fAcctsControl(Session session) : base(session) 
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
     [Appearance("VisiblefAcctsControlOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     
     // 
     // Notes for fAcctsControl : 
     private enumAcctControl _currency; 
     [XafDisplayName("Currency"), ToolTip("Currency")] 
     // [Appearance("fAcctsControlcurrency", Enabled = true)]
     // [Appearance("fAcctsControlcurrencyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumAcctControl currency
     { 
       get { return _currency; } 
       set { SetPropertyValue(nameof(currency), ref _currency, value); } 
     } 
     // 
     // Notes for fAcctsControl : 
     private enumAcctControl _taxcat; 
     [XafDisplayName("Tax Category"), ToolTip("Tax Category")] 
     // [Appearance("fAcctsControltaxcat", Enabled = true)]
     // [Appearance("fAcctsControltaxcatVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumAcctControl taxcat
     { 
       get { return _taxcat; } 
       set { SetPropertyValue(nameof(taxcat), ref _taxcat, value); } 
     } 
     // 
     // Notes for fAcctsControl : 
     private enumAcctControl _reconaccts; 
     [XafDisplayName("Reconcilation Accounts"), ToolTip("Reconcilation Accounts")] 
     // [Appearance("fAcctsControlreconaccts", Enabled = true)]
     // [Appearance("fAcctsControlreconacctsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumAcctControl reconaccts
     { 
       get { return _reconaccts; } 
       set { SetPropertyValue(nameof(reconaccts), ref _reconaccts, value); } 
     } 
     // 
     // Notes for fAcctsControl : 
     private enumAcctControl _exchratediff; 
     [XafDisplayName("Exchange Rate Difference"), ToolTip("Exchange Rate Difference")] 
     // [Appearance("fAcctsControlexchratediff", Enabled = true)]
     // [Appearance("fAcctsControlexchratediffVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumAcctControl exchratediff
     { 
       get { return _exchratediff; } 
       set { SetPropertyValue(nameof(exchratediff), ref _exchratediff, value); } 
     } 
     // 
     // Notes for fAcctsControl : 
     private enumAcctControl _acctmngdinextsys; 
     [XafDisplayName("Account Managed In ext. System"), ToolTip("Account Managed In ext. System")] 
     // [Appearance("fAcctsControlacctmngdinextsys", Enabled = true)]
     // [Appearance("fAcctsControlacctmngdinextsysVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumAcctControl acctmngdinextsys
     { 
       get { return _acctmngdinextsys; } 
       set { SetPropertyValue(nameof(acctmngdinextsys), ref _acctmngdinextsys, value); } 
     } 
     // 
     // Notes for fAcctsControl : 
     private enumAcctControl _onlybalcloccrcy; 
     [XafDisplayName("Only Balance in Local crcy"), ToolTip("Only Balance in Local crcy")] 
     // [Appearance("fAcctsControlonlybalcloccrcy", Enabled = true)]
     // [Appearance("fAcctsControlonlybalcloccrcyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumAcctControl onlybalcloccrcy
     { 
       get { return _onlybalcloccrcy; } 
       set { SetPropertyValue(nameof(onlybalcloccrcy), ref _onlybalcloccrcy, value); } 
     } 
     // 
     // Notes for fAcctsControl : 
     private enumAcctControl _altacctnumber; 
     [XafDisplayName("Alternative Account Number"), ToolTip("Alternative Account Number")] 
     // [Appearance("fAcctsControlaltacctnumber", Enabled = true)]
     // [Appearance("fAcctsControlaltacctnumberVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumAcctControl altacctnumber
     { 
       get { return _altacctnumber; } 
       set { SetPropertyValue(nameof(altacctnumber), ref _altacctnumber, value); } 
     } 
     // 
     // Notes for fAcctsControl : 
     private enumAcctControl _inflationkey; 
     [XafDisplayName("Inflation Key"), ToolTip("Inflation Key")] 
     // [Appearance("fAcctsControlinflationkey", Enabled = true)]
     // [Appearance("fAcctsControlinflationkeyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumAcctControl inflationkey
     { 
       get { return _inflationkey; } 
       set { SetPropertyValue(nameof(inflationkey), ref _inflationkey, value); } 
     } 
     // 
     // Notes for fAcctsControl : 
     private enumAcctControl _tolcgroup; 
     [XafDisplayName("Tolerance Group"), ToolTip("Tolerance Group")] 
     // [Appearance("fAcctsControltolcgroup", Enabled = true)]
     // [Appearance("fAcctsControltolcgroupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumAcctControl tolcgroup
     { 
       get { return _tolcgroup; } 
       set { SetPropertyValue(nameof(tolcgroup), ref _tolcgroup, value); } 
     } 
   } 
} 
