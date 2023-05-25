// Class Name : fChartOfAccts.cs 
// Project Name : FICO 
// Last Update : 22/05/2023 16:34:23  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 22/05/2023 16:34:23 
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
   [System.ComponentModel.DisplayName("Chart Of Accts")]
   public class fChartOfAccts : XPObject
   {
     public fChartOfAccts(Session session) : base(session) 
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
     [Appearance("VisiblefChartOfAcctsOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for fChartOfAccts : Enter a unique Chart of Accounts Code , maximum length is four
     private string _code; 
     [XafDisplayName("Chart Of Accts"), ToolTip("Chart Of Accts")] 
     // [Appearance("fChartOfAcctscode", Enabled = true)]
     // [Appearance("fChartOfAcctscodeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string code
     { 
       get { return _code; } 
       set { SetPropertyValue(nameof(code), ref _code, value); } 
     } 
     // 
     // Notes for fChartOfAccts : 
     private string _description; 
     [XafDisplayName("Description"), ToolTip("Description")] 
     // [Appearance("fChartOfAcctsdescription", Enabled = true)]
     // [Appearance("fChartOfAcctsdescriptionVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(250)] 
     public  string description
     { 
       get { return _description; } 
       set { SetPropertyValue(nameof(description), ref _description, value); } 
     } 
     // General Specification
     // Notes for fChartOfAccts : 
     private fLanguage _languagemaster; 
     [XafDisplayName("language.Master"), ToolTip("language.Master")] 
     // [Appearance("fChartOfAcctslanguagemaster", Enabled = true)]
     // [Appearance("fChartOfAcctslanguagemasterVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fLanguage languagemaster
     { 
       get { return _languagemaster; } 
       set { SetPropertyValue(nameof(languagemaster), ref _languagemaster, value); } 
     } 
     // General Specification
     // Notes for fChartOfAccts : 
     private int _lengthforglacctsnumber; 
     [XafDisplayName("length for G/L Accounts number"), ToolTip("length for G/L Accounts number")] 
     // [Appearance("fChartOfAcctslengthforglacctsnumber", Enabled = true)]
     // [Appearance("fChartOfAcctslengthforglacctsnumberVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  int lengthforglacctsnumber
     { 
       get { return _lengthforglacctsnumber; } 
       set { SetPropertyValue(nameof(lengthforglacctsnumber), ref _lengthforglacctsnumber, value); } 
     } 
     // Integeration
     // Notes for fChartOfAccts : 
     private eNumAcctsCtrlIntgration _ctlintegration; 
     [XafDisplayName("Controlling integeration"), ToolTip("Controlling integeration")] 
     // [Appearance("fChartOfAcctsctlintegration", Enabled = true)]
     // [Appearance("fChartOfAcctsctlintegrationVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  eNumAcctsCtrlIntgration ctlintegration
     { 
       get { return _ctlintegration; } 
       set { SetPropertyValue(nameof(ctlintegration), ref _ctlintegration, value); } 
     } 
     // Consolidation
     // Notes for fChartOfAccts : 
     private fAcctsGroup _groupcoaconsolidate; 
     [XafDisplayName("Group Of Chart Of Accts"), ToolTip("Group Of Chart Of Accts")] 
     // [Appearance("fChartOfAcctsgroupcoaconsolidate", Enabled = true)]
     // [Appearance("fChartOfAcctsgroupcoaconsolidateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fAcctsGroup groupcoaconsolidate
     { 
       get { return _groupcoaconsolidate; } 
       set { SetPropertyValue(nameof(groupcoaconsolidate), ref _groupcoaconsolidate, value); } 
     } 
     // 
     // Notes for fChartOfAccts : 
     private bool _blocked; 
     [XafDisplayName("Status"), ToolTip("Status")] 
     // [Appearance("fChartOfAcctsblocked", Enabled = true)]
     // [Appearance("fChartOfAcctsblockedVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool blocked
     { 
       get { return _blocked; } 
       set { SetPropertyValue(nameof(blocked), ref _blocked, value); } 
     } 
     // 
     // Notes for fChartOfAccts : 
     [XafDisplayName("Group Of Chart Of Accts Number"), ToolTip("Group Of Chart Of Accts Number")] 
     // [Appearance("fChartOfAcctsacctgroup", Enabled = true)]
     // [Appearance("fChartOfAcctsacctgroupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Association("AcctGroups")] 
     public XPCollection<fAcctsGroup> acctgroup
     {
     get
       {
         return GetCollection<fAcctsGroup>("acctgroup"); 
       }
     }
     // 
     // Notes for fChartOfAccts : 
     [XafDisplayName("Company Of Chart Of Accts"), ToolTip("Company Of Chart Of Accts")] 
     // [Appearance("fChartOfAcctscompany", Enabled = true)]
     // [Appearance("fChartOfAcctscompanyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Association("CompanyCOA")] 
     public XPCollection<fCompany> company
     {
     get
       {
         return GetCollection<fCompany>("company"); 
       }
     }
   } 
} 
