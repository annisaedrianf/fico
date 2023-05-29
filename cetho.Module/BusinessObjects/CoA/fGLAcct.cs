// Class Name : fGLAcct.cs 
// Project Name : FICO 
// Last Update : 22/05/2023 16:31:59  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 22/05/2023 16:31:59 
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
   [DefaultProperty("GLAcct")]
   [NavigationItem("Master")]
   // Standard Document
   [System.ComponentModel.DisplayName("GL Account")]
   public class fGLAcct : XPObject
   {
     public fGLAcct(Session session) : base(session) 
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
     [Appearance("VisiblefGLAcctOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for fGLAcct : 
     private string _glacct; 
     [XafDisplayName("G/L Account"), ToolTip("G/L Account")] 
     // [Appearance("fGLAcctglacct", Enabled = true)]
     // [Appearance("fGLAcctglacctVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string glacct
     { 
       get { return _glacct; } 
       set { SetPropertyValue(nameof(glacct), ref _glacct, value); } 
     } 
     // 
     // Notes for fGLAcct : 
     private fCompany _company; 
     [XafDisplayName("Company Code"), ToolTip("Company Code")] 
     // [Appearance("fGLAcctcompany", Enabled = true)]
     // [Appearance("fGLAcctcompanyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCompany company
     { 
       get { return _company; } 
       set { SetPropertyValue(nameof(company), ref _company, value); } 
     } 
     // Type/Description
     // Notes for fGLAcct : 
     private fAcctsGroup _groupacct; 
     [XafDisplayName("Account Group"), ToolTip("Account Group")] 
     // [Appearance("fGLAcctgroupacct", Enabled = true)]
     // [Appearance("fGLAcctgroupacctVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fAcctsGroup groupacct
     { 
       get { return _groupacct; } 
       set { SetPropertyValue(nameof(groupacct), ref _groupacct, value); } 
     } 
     // Type/Description
     // Notes for fGLAcct : 
     private eNumPLBS _typetype; 
     [XafDisplayName("Type"), ToolTip("Type")] 
     // [Appearance("fGLAccttypetype", Enabled = true)]
     // [Appearance("fGLAccttypetypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  eNumPLBS typetype
     { 
       get { return _typetype; } 
       set { SetPropertyValue(nameof(typetype), ref _typetype, value); } 
     } 
     // Type/Description
     // Notes for fGLAcct : 
     private string _shorttext; 
     [XafDisplayName("Short Text"), ToolTip("ShortText")] 
     // [Appearance("fGLAcctshorttext", Enabled = true)]
     // [Appearance("fGLAcctshorttextVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string shorttext
     { 
       get { return _shorttext; } 
       set { SetPropertyValue(nameof(shorttext), ref _shorttext, value); } 
     } 
     // Type/Description
     // Notes for fGLAcct : 
     private string _longtext; 
     [XafDisplayName("G/L Acct Long Text"), ToolTip("G/L Acct long Text")] 
     // [Appearance("fGLAcctlongtext", Enabled = true)]
     // [Appearance("fGLAcctlongtextVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(250)] 
     public  string longtext
     { 
       get { return _longtext; } 
       set { SetPropertyValue(nameof(longtext), ref _longtext, value); } 
     } 
     // Control Data
     // Notes for fGLAcct : 
     private fCurrency _currency; 
     [XafDisplayName("Account Currency"), ToolTip("Account Currency")] 
     // [Appearance("fGLAcctcurrency", Enabled = true)]
     // [Appearance("fGLAcctcurrencyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCurrency currency
     { 
       get { return _currency; } 
       set { SetPropertyValue(nameof(currency), ref _currency, value); } 
     } 
     // Control Data
     // Notes for fGLAcct : 
     private bool _onlybalanceinlocalcrcy; 
     [XafDisplayName("Only Balance in Local Currency"), ToolTip("Only Balance in local crcy")] 
     // [Appearance("fGLAcctonlybalanceinlocalcrcy", Enabled = true)]
     // [Appearance("fGLAcctonlybalanceinlocalcrcyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool onlybalanceinlocalcrcy
     { 
       get { return _onlybalanceinlocalcrcy; } 
       set { SetPropertyValue(nameof(onlybalanceinlocalcrcy), ref _onlybalanceinlocalcrcy, value); } 
     } 
     // Control Data
     // Notes for fGLAcct : 
     private string _valuationgroup; 
     [XafDisplayName("Valuation Group"), ToolTip("Valuation group")] 
     // [Appearance("fGLAcctvaluationgroup", Enabled = true)]
     // [Appearance("fGLAcctvaluationgroupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string valuationgroup
     { 
       get { return _valuationgroup; } 
       set { SetPropertyValue(nameof(valuationgroup), ref _valuationgroup, value); } 
     } 
     // Control Data
     // Notes for fGLAcct : 
     private fTaxCategory _taxcategory; 
     [XafDisplayName("Tax Category"), ToolTip("Tax category")] 
     // [Appearance("fGLAccttaxcategory", Enabled = true)]
     // [Appearance("fGLAccttaxcategoryVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fTaxCategory taxcategory
     { 
       get { return _taxcategory; } 
       set { SetPropertyValue(nameof(taxcategory), ref _taxcategory, value); } 
     } 
     // Control Data
     // Notes for fGLAcct : 
     private bool _postwithouttaxallow; 
     [XafDisplayName("Posting Without Tax Allowance"), ToolTip("Posting without tax Allowance")] 
     // [Appearance("fGLAcctpostwithouttaxallow", Enabled = true)]
     // [Appearance("fGLAcctpostwithouttaxallowVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool postwithouttaxallow
     { 
       get { return _postwithouttaxallow; } 
       set { SetPropertyValue(nameof(postwithouttaxallow), ref _postwithouttaxallow, value); } 
     } 
     // Control Data
     // Notes for fGLAcct : 
     private string _reconacctforaccttyp; 
     [XafDisplayName("Recon-Account for Acct Typ"), ToolTip("Recon. Account for acct typ")] 
     // [Appearance("fGLAcctreconacctforaccttyp", Enabled = true)]
     // [Appearance("fGLAcctreconacctforaccttypVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string reconacctforaccttyp
     { 
       get { return _reconacctforaccttyp; } 
       set { SetPropertyValue(nameof(reconacctforaccttyp), ref _reconacctforaccttyp, value); } 
     } 
     // Control Data
     // Notes for fGLAcct : 
     private string _alternatacctno; 
     [XafDisplayName("Alternative Account No"), ToolTip("Alternative account no")] 
     // [Appearance("fGLAcctalternatacctno", Enabled = true)]
     // [Appearance("fGLAcctalternatacctnoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(15)] 
     public  string alternatacctno
     { 
       get { return _alternatacctno; } 
       set { SetPropertyValue(nameof(alternatacctno), ref _alternatacctno, value); } 
     } 
     // Control Data
     // Notes for fGLAcct : 
     private bool _acctmngdinextsys; 
     [XafDisplayName("Acct Managed in Ext-System"), ToolTip("Acct managed in ext. system")] 
     // [Appearance("fGLAcctacctmngdinextsys", Enabled = true)]
     // [Appearance("fGLAcctacctmngdinextsysVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool acctmngdinextsys
     { 
       get { return _acctmngdinextsys; } 
       set { SetPropertyValue(nameof(acctmngdinextsys), ref _acctmngdinextsys, value); } 
     } 
     // Control Data
     // Notes for fGLAcct : 
     private string _iflationkey; 
     [XafDisplayName("Iflation key"), ToolTip("Iflation key")] 
     // [Appearance("fGLAcctiflationkey", Enabled = true)]
     // [Appearance("fGLAcctiflationkeyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string iflationkey
     { 
       get { return _iflationkey; } 
       set { SetPropertyValue(nameof(iflationkey), ref _iflationkey, value); } 
     } 
     // Control Data
     // Notes for fGLAcct : 
     private string _tollergroup; 
     [XafDisplayName("Tollerance Group"), ToolTip("Tollerance group")] 
     // [Appearance("fGLAccttollergroup", Enabled = true)]
     // [Appearance("fGLAccttollergroupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string tollergroup
     { 
       get { return _tollergroup; } 
       set { SetPropertyValue(nameof(tollergroup), ref _tollergroup, value); } 
     } 
     // Control Data
     // Notes for fGLAcct : 
     private bool _openitemmgnt; 
     [XafDisplayName("Open Item Management"), ToolTip("Open item management")] 
     // [Appearance("fGLAcctopenitemmgnt", Enabled = true)]
     // [Appearance("fGLAcctopenitemmgntVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool openitemmgnt
     { 
       get { return _openitemmgnt; } 
       set { SetPropertyValue(nameof(openitemmgnt), ref _openitemmgnt, value); } 
     } 
     // Control Data
     // Notes for fGLAcct : 
     private bool _lineitemdisplay; 
     [XafDisplayName("Line Item display"), ToolTip("Line Item display")] 
     // [Appearance("fGLAcctlineitemdisplay", Enabled = true)]
     // [Appearance("fGLAcctlineitemdisplayVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool lineitemdisplay
     { 
       get { return _lineitemdisplay; } 
       set { SetPropertyValue(nameof(lineitemdisplay), ref _lineitemdisplay, value); } 
     } 
     // Control Data
     // Notes for fGLAcct : 
     private string _sortkey; 
     [XafDisplayName("Sort Key"), ToolTip("Sort key")] 
     // [Appearance("fGLAcctsortkey", Enabled = true)]
     // [Appearance("fGLAcctsortkeyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string sortkey
     { 
       get { return _sortkey; } 
       set { SetPropertyValue(nameof(sortkey), ref _sortkey, value); } 
     } 
     // Control Data
     // Notes for fGLAcct : 
     private string _authozgroup; 
     [XafDisplayName("Authorization Group"), ToolTip("Authorization Group")] 
     // [Appearance("fGLAcctauthozgroup", Enabled = true)]
     // [Appearance("fGLAcctauthozgroupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string authozgroup
     { 
       get { return _authozgroup; } 
       set { SetPropertyValue(nameof(authozgroup), ref _authozgroup, value); } 
     } 
     // Control Data
     // Notes for fGLAcct : 
     private string _acctclerk; 
     [XafDisplayName("Accounting Clerk"), ToolTip("Accounting clerk")] 
     // [Appearance("fGLAcctacctclerk", Enabled = true)]
     // [Appearance("fGLAcctacctclerkVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string acctclerk
     { 
       get { return _acctclerk; } 
       set { SetPropertyValue(nameof(acctclerk), ref _acctclerk, value); } 
     } 
     // Create/Bank/Interest
     // Notes for fGLAcct : 
     private string _fieldstsgroup; 
     [XafDisplayName("Field Status Group"), ToolTip("Field status group")] 
     // [Appearance("fGLAcctfieldstsgroup", Enabled = true)]
     // [Appearance("fGLAcctfieldstsgroupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string fieldstsgroup
     { 
       get { return _fieldstsgroup; } 
       set { SetPropertyValue(nameof(fieldstsgroup), ref _fieldstsgroup, value); } 
     } 
     // Create/Bank/Interest
     // Notes for fGLAcct : 
     private bool _postautoonly; 
     [XafDisplayName("Post Automaticaly Only"), ToolTip("Post automaticaly only")] 
     // [Appearance("fGLAcctpostautoonly", Enabled = true)]
     // [Appearance("fGLAcctpostautoonlyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool postautoonly
     { 
       get { return _postautoonly; } 
       set { SetPropertyValue(nameof(postautoonly), ref _postautoonly, value); } 
     } 
     // Create/Bank/Interest
     // Notes for fGLAcct : 
     private bool _supplmtautpost; 
     [XafDisplayName("Supplement Aut. Posting"), ToolTip("supplement aut. Posting")] 
     // [Appearance("fGLAcctsupplmtautpost", Enabled = true)]
     // [Appearance("fGLAcctsupplmtautpostVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool supplmtautpost
     { 
       get { return _supplmtautpost; } 
       set { SetPropertyValue(nameof(supplmtautpost), ref _supplmtautpost, value); } 
     } 
     // Create/Bank/Interest
     // Notes for fGLAcct : 
     private bool _recontacctforinput; 
     [XafDisplayName("Recont-Acct Ready for Input"), ToolTip("recont. Acct ready for input")] 
     // [Appearance("fGLAcctrecontacctforinput", Enabled = true)]
     // [Appearance("fGLAcctrecontacctforinputVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool recontacctforinput
     { 
       get { return _recontacctforinput; } 
       set { SetPropertyValue(nameof(recontacctforinput), ref _recontacctforinput, value); } 
     } 
     // Create/Bank/Interest
     // Notes for fGLAcct : 
     private string _planninglevel; 
     [XafDisplayName("Planning Level"), ToolTip("Planning level")] 
     // [Appearance("fGLAcctplanninglevel", Enabled = true)]
     // [Appearance("fGLAcctplanninglevelVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string planninglevel
     { 
       get { return _planninglevel; } 
       set { SetPropertyValue(nameof(planninglevel), ref _planninglevel, value); } 
     } 
     // Create/Bank/Interest
     // Notes for fGLAcct : 
     private bool _relevanttocashflow; 
     [XafDisplayName("Relevant to Cash-Flow"), ToolTip("Relevant to cash flow")] 
     // [Appearance("fGLAcctrelevanttocashflow", Enabled = true)]
     // [Appearance("fGLAcctrelevanttocashflowVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool relevanttocashflow
     { 
       get { return _relevanttocashflow; } 
       set { SetPropertyValue(nameof(relevanttocashflow), ref _relevanttocashflow, value); } 
     } 
     // Create/Bank/Interest
     // Notes for fGLAcct : 
     private fBank _housebank; 
     [XafDisplayName("House Bank"), ToolTip("House bank")] 
     // [Appearance("fGLAccthousebank", Enabled = true)]
     // [Appearance("fGLAccthousebankVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fBank housebank
     { 
       get { return _housebank; } 
       set { SetPropertyValue(nameof(housebank), ref _housebank, value); } 
     } 
     // Create/Bank/Interest
     // Notes for fGLAcct : 
     private fBankAcct _accountid; 
     [XafDisplayName("Account ID"), ToolTip("Account ID")] 
     // [Appearance("fGLAcctaccountid", Enabled = true)]
     // [Appearance("fGLAcctaccountidVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fBankAcct accountid
     { 
       get { return _accountid; } 
       set { SetPropertyValue(nameof(accountid), ref _accountid, value); } 
     } 
     // Create/Bank/Interest
     // Notes for fGLAcct : 
     private string _interestindicator; 
     [XafDisplayName("Interest Indicator"), ToolTip("Interest indicator")] 
     // [Appearance("fGLAcctinterestindicator", Enabled = true)]
     // [Appearance("fGLAcctinterestindicatorVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string interestindicator
     { 
       get { return _interestindicator; } 
       set { SetPropertyValue(nameof(interestindicator), ref _interestindicator, value); } 
     } 
     // Create/Bank/Interest
     // Notes for fGLAcct : 
     private string _interestcalcfrequency; 
     [XafDisplayName("Interest Calc. Frequency"), ToolTip("interest calc. frequency")] 
     // [Appearance("fGLAcctinterestcalcfrequency", Enabled = true)]
     // [Appearance("fGLAcctinterestcalcfrequencyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string interestcalcfrequency
     { 
       get { return _interestcalcfrequency; } 
       set { SetPropertyValue(nameof(interestcalcfrequency), ref _interestcalcfrequency, value); } 
     } 
     // Create/Bank/Interest
     // Notes for fGLAcct : 
     private string _keydateoflastintcalc; 
     [XafDisplayName("Key-Date of Last Int-Calc"), ToolTip("key date of last int. calc.")] 
     // [Appearance("fGLAcctkeydateoflastintcalc", Enabled = true)]
     // [Appearance("fGLAcctkeydateoflastintcalcVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string keydateoflastintcalc
     { 
       get { return _keydateoflastintcalc; } 
       set { SetPropertyValue(nameof(keydateoflastintcalc), ref _keydateoflastintcalc, value); } 
     } 
     // Create/Bank/Interest
     // Notes for fGLAcct : 
     private DateTime _dateoflastinterestrun; 
     [XafDisplayName("Date of Last Interest-Run"), ToolTip("date of last interest run")] 
     // [Appearance("fGLAcctdateoflastinterestrun", Enabled = true)]
     // [Appearance("fGLAcctdateoflastinterestrunVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime dateoflastinterestrun
     { 
       get { return _dateoflastinterestrun; } 
       set { SetPropertyValue(nameof(dateoflastinterestrun), ref _dateoflastinterestrun, value); } 
     } 
     // Lock
     // Notes for fGLAcct : 
     private bool _blockedcreation; 
     [XafDisplayName("Blocked for Creation"), ToolTip("Blocked for creation")] 
     // [Appearance("fGLAcctblockedcreation", Enabled = true)]
     // [Appearance("fGLAcctblockedcreationVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool blockedcreation
     { 
       get { return _blockedcreation; } 
       set { SetPropertyValue(nameof(blockedcreation), ref _blockedcreation, value); } 
     } 
     // Lock
     // Notes for fGLAcct : 
     private bool _blockedposting; 
     [XafDisplayName("Blocked for Posting"), ToolTip("Blocked for Posting")] 
     // [Appearance("fGLAcctblockedposting", Enabled = true)]
     // [Appearance("fGLAcctblockedpostingVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool blockedposting
     { 
       get { return _blockedposting; } 
       set { SetPropertyValue(nameof(blockedposting), ref _blockedposting, value); } 
     } 
     // Lock
     // Notes for fGLAcct : 
     private bool _blockedplaning; 
     [XafDisplayName("Blocked for Plannig"), ToolTip("Blocked for plannig")] 
     // [Appearance("fGLAcctblockedplaning", Enabled = true)]
     // [Appearance("fGLAcctblockedplaningVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool blockedplaning
     { 
       get { return _blockedplaning; } 
       set { SetPropertyValue(nameof(blockedplaning), ref _blockedplaning, value); } 
     } 
   } 
} 
