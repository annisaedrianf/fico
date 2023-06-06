// Class Name : fScheduleLine.cs 
// Project Name : FICO 
// Last Update : 06/06/2023 13:11:26  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 06/06/2023 13:11:26 
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
   [System.ComponentModel.DisplayName("New Entries: Details of Added Entries")]
   public class fScheduleLine : XPObject
   {
     public fScheduleLine(Session session) : base(session) 
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
     [Appearance("VisiblefScheduleLineOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for fScheduleLine : 
     private string _schlinecat; 
     [XafDisplayName("Sched. Line Cat."), ToolTip("Sched.line cat.")] 
     // [Appearance("fScheduleLineschlinecat", Enabled = true)]
     // [Appearance("fScheduleLineschlinecatVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string schlinecat
     { 
       get { return _schlinecat; } 
       set { SetPropertyValue(nameof(schlinecat), ref _schlinecat, value); } 
     } 
     // Business data
     // Notes for fScheduleLine : 
     private string _delivbook; 
     [XafDisplayName("Delivery Block"), ToolTip("Delivery block")] 
     // [Appearance("fScheduleLinedelivbook", Enabled = true)]
     // [Appearance("fScheduleLinedelivbookVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string delivbook
     { 
       get { return _delivbook; } 
       set { SetPropertyValue(nameof(delivbook), ref _delivbook, value); } 
     } 
     // Business data
     // Notes for fScheduleLine : 
     private string _movetype; 
     [XafDisplayName("Movement Type"), ToolTip("Movement Type")] 
     // [Appearance("fScheduleLinemovetype", Enabled = true)]
     // [Appearance("fScheduleLinemovetypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string movetype
     { 
       get { return _movetype; } 
       set { SetPropertyValue(nameof(movetype), ref _movetype, value); } 
     } 
     // Business data
     // Notes for fScheduleLine : 
     private string _movetype1; 
     [XafDisplayName("Movement Type 1-Step"), ToolTip("Movement Type 1-Step")] 
     // [Appearance("fScheduleLinemovetype1", Enabled = true)]
     // [Appearance("fScheduleLinemovetype1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string movetype1
     { 
       get { return _movetype1; } 
       set { SetPropertyValue(nameof(movetype1), ref _movetype1, value); } 
     } 
     // Business data
     // Notes for fScheduleLine : 
     private string _ordertype; 
     [XafDisplayName("Order Type"), ToolTip("Order Type")] 
     // [Appearance("fScheduleLineordertype", Enabled = true)]
     // [Appearance("fScheduleLineordertypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string ordertype
     { 
       get { return _ordertype; } 
       set { SetPropertyValue(nameof(ordertype), ref _ordertype, value); } 
     } 
     // Business data
     // Notes for fScheduleLine : 
     private string _itemctg; 
     [XafDisplayName("Item Category"), ToolTip("Item Category")] 
     // [Appearance("fScheduleLineitemctg", Enabled = true)]
     // [Appearance("fScheduleLineitemctgVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string itemctg
     { 
       get { return _itemctg; } 
       set { SetPropertyValue(nameof(itemctg), ref _itemctg, value); } 
     } 
     // Business data
     // Notes for fScheduleLine : 
     private string _acctassgtcat; 
     [XafDisplayName("Acct Assgt Cat."), ToolTip("AcctAssgtCat.")] 
     // [Appearance("fScheduleLineacctassgtcat", Enabled = true)]
     // [Appearance("fScheduleLineacctassgtcatVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string acctassgtcat
     { 
       get { return _acctassgtcat; } 
       set { SetPropertyValue(nameof(acctassgtcat), ref _acctassgtcat, value); } 
     } 
     // Business data
     // Notes for fScheduleLine : 
     private bool _itemreldlv; 
     [XafDisplayName("Item Rel.f.Dlv"), ToolTip("Item rel.f.dlv")] 
     // [Appearance("fScheduleLineitemreldlv", Enabled = true)]
     // [Appearance("fScheduleLineitemreldlvVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool itemreldlv
     { 
       get { return _itemreldlv; } 
       set { SetPropertyValue(nameof(itemreldlv), ref _itemreldlv, value); } 
     } 
     // Business data
     // Notes for fScheduleLine : 
     private bool _preqdelsch; 
     [XafDisplayName("Preq. Del. Sched"), ToolTip("Preq.del.sched")] 
     // [Appearance("fScheduleLinepreqdelsch", Enabled = true)]
     // [Appearance("fScheduleLinepreqdelschVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool preqdelsch
     { 
       get { return _preqdelsch; } 
       set { SetPropertyValue(nameof(preqdelsch), ref _preqdelsch, value); } 
     } 
     // Transaction flow
     // Notes for fScheduleLine : 
     private string _incomplproced; 
     [XafDisplayName("Incompl. Proced"), ToolTip("Incompl.proced")] 
     // [Appearance("fScheduleLineincomplproced", Enabled = true)]
     // [Appearance("fScheduleLineincomplprocedVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string incomplproced
     { 
       get { return _incomplproced; } 
       set { SetPropertyValue(nameof(incomplproced), ref _incomplproced, value); } 
     } 
     // Transaction flow
     // Notes for fScheduleLine : 
     private bool _req; 
     [XafDisplayName("Req./Assembly"), ToolTip("Req./Assembly")] 
     // [Appearance("fScheduleLinereq", Enabled = true)]
     // [Appearance("fScheduleLinereqVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool req
     { 
       get { return _req; } 
       set { SetPropertyValue(nameof(req), ref _req, value); } 
     } 
     // Transaction flow
     // Notes for fScheduleLine : 
     private bool _avail; 
     [XafDisplayName("Availbality"), ToolTip("Availbality")] 
     // [Appearance("fScheduleLineavail", Enabled = true)]
     // [Appearance("fScheduleLineavailVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool avail
     { 
       get { return _avail; } 
       set { SetPropertyValue(nameof(avail), ref _avail, value); } 
     } 
     // Transaction flow
     // Notes for fScheduleLine : 
     private bool _prodalloc; 
     [XafDisplayName("Prod. Allocation"), ToolTip("Prod.allocation")] 
     // [Appearance("fScheduleLineprodalloc", Enabled = true)]
     // [Appearance("fScheduleLineprodallocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool prodalloc
     { 
       get { return _prodalloc; } 
       set { SetPropertyValue(nameof(prodalloc), ref _prodalloc, value); } 
     } 
   } 
} 
