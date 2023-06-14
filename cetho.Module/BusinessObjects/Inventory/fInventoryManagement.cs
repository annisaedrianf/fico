// Class Name : fInventoryManagement.cs 
// Project Name : FICO 
// Last Update : 07/06/2023 12:02:02  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 07/06/2023 12:02:02 
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
   [System.ComponentModel.DisplayName("Change Movement Type: Details")]
   public class fInventoryManagement : XPObject
   {
     public fInventoryManagement(Session session) : base(session) 
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
     [Appearance("VisiblefInventoryManagementOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for fInventoryManagement : 
     private string _movetype; 
     [XafDisplayName("Movement Type"), ToolTip("Movement Type")] 
     // [Appearance("fInventoryManagementmovetype", Enabled = true)]
     // [Appearance("fInventoryManagementmovetypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string movetype
     { 
       get { return _movetype; } 
       set { SetPropertyValue(nameof(movetype), ref _movetype, value); } 
     } 
     // Entry Control
     // Notes for fInventoryManagement : 
     private string _printitem; 
     [XafDisplayName("Print Item"), ToolTip("Print item")] 
     // [Appearance("fInventoryManagementprintitem", Enabled = true)]
     // [Appearance("fInventoryManagementprintitemVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string printitem
     { 
       get { return _printitem; } 
       set { SetPropertyValue(nameof(printitem), ref _printitem, value); } 
     } 
     // Entry Control
     // Notes for fInventoryManagement : 
     private string _selectparam; 
     [XafDisplayName("Selection Parameter"), ToolTip("Selection parameter")] 
     // [Appearance("fInventoryManagementselectparam", Enabled = true)]
     // [Appearance("fInventoryManagementselectparamVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string selectparam
     { 
       get { return _selectparam; } 
       set { SetPropertyValue(nameof(selectparam), ref _selectparam, value); } 
     } 
     // Entry Control
     // Notes for fInventoryManagement : 
     private string _classbatch; 
     [XafDisplayName("Classif. Batches"), ToolTip("Classif.batches")] 
     // [Appearance("fInventoryManagementclassbatch", Enabled = true)]
     // [Appearance("fInventoryManagementclassbatchVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string classbatch
     { 
       get { return _classbatch; } 
       set { SetPropertyValue(nameof(classbatch), ref _classbatch, value); } 
     } 
     // Entry Control
     // Notes for fInventoryManagement : 
     private string _createnewbatch; 
     [XafDisplayName("Create New Batch"), ToolTip("Create New Batch")] 
     // [Appearance("fInventoryManagementcreatenewbatch", Enabled = true)]
     // [Appearance("fInventoryManagementcreatenewbatchVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string createnewbatch
     { 
       get { return _createnewbatch; } 
       set { SetPropertyValue(nameof(createnewbatch), ref _createnewbatch, value); } 
     } 
     // Entry Control
     // Notes for fInventoryManagement : 
     private bool _extclassific; 
     [XafDisplayName("Ext. Classific."), ToolTip("Ext.classific.")] 
     // [Appearance("fInventoryManagementextclassific", Enabled = true)]
     // [Appearance("fInventoryManagementextclassificVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool extclassific
     { 
       get { return _extclassific; } 
       set { SetPropertyValue(nameof(extclassific), ref _extclassific, value); } 
     } 
     // Entry Control
     // Notes for fInventoryManagement : 
     private string _chkslexpirdate; 
     [XafDisplayName("Check SL Expir. Date"), ToolTip("Check SLExpir.date")] 
     // [Appearance("fInventoryManagementchkslexpirdate", Enabled = true)]
     // [Appearance("fInventoryManagementchkslexpirdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string chkslexpirdate
     { 
       get { return _chkslexpirdate; } 
       set { SetPropertyValue(nameof(chkslexpirdate), ref _chkslexpirdate, value); } 
     } 
     // Entry Control
     // Notes for fInventoryManagement : 
     private string _accctrl; 
     [XafDisplayName("Account Control"), ToolTip("Account control")] 
     // [Appearance("fInventoryManagementaccctrl", Enabled = true)]
     // [Appearance("fInventoryManagementaccctrlVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string accctrl
     { 
       get { return _accctrl; } 
       set { SetPropertyValue(nameof(accctrl), ref _accctrl, value); } 
     } 
     // Entry Control
     // Notes for fInventoryManagement : 
     private string _ctrlreason; 
     [XafDisplayName("Control Reason"), ToolTip("Control Reason")] 
     // [Appearance("fInventoryManagementctrlreason", Enabled = true)]
     // [Appearance("fInventoryManagementctrlreasonVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string ctrlreason
     { 
       get { return _ctrlreason; } 
       set { SetPropertyValue(nameof(ctrlreason), ref _ctrlreason, value); } 
     } 
     // Entry Control
     // Notes for fInventoryManagement : 
     private string _stckdeterrule; 
     [XafDisplayName("Stck Determation Rule"), ToolTip("Stck determation rule")] 
     // [Appearance("fInventoryManagementstckdeterrule", Enabled = true)]
     // [Appearance("fInventoryManagementstckdeterruleVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string stckdeterrule
     { 
       get { return _stckdeterrule; } 
       set { SetPropertyValue(nameof(stckdeterrule), ref _stckdeterrule, value); } 
     } 
     // Entry Control
     // Notes for fInventoryManagement : 
     private bool _revgrdespiteir; 
     [XafDisplayName("RevGR Despite IR"), ToolTip("RevGR despite IR")] 
     // [Appearance("fInventoryManagementrevgrdespiteir", Enabled = true)]
     // [Appearance("fInventoryManagementrevgrdespiteirVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool revgrdespiteir
     { 
       get { return _revgrdespiteir; } 
       set { SetPropertyValue(nameof(revgrdespiteir), ref _revgrdespiteir, value); } 
     } 
     // Updating Control
     // Notes for fInventoryManagement : 
     private bool _createslocautomat; 
     [XafDisplayName("Create Sloc. Automat."), ToolTip("Create Sloc. Automat.")] 
     // [Appearance("fInventoryManagementcreateslocautomat", Enabled = true)]
     // [Appearance("fInventoryManagementcreateslocautomatVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool createslocautomat
     { 
       get { return _createslocautomat; } 
       set { SetPropertyValue(nameof(createslocautomat), ref _createslocautomat, value); } 
     } 
     // Updating Control
     // Notes for fInventoryManagement : 
     private bool _indrqmtsreduct; 
     [XafDisplayName("Ind. Rqmts Reduction"), ToolTip("Ind. Rqmts reduction")] 
     // [Appearance("fInventoryManagementindrqmtsreduct", Enabled = true)]
     // [Appearance("fInventoryManagementindrqmtsreductVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool indrqmtsreduct
     { 
       get { return _indrqmtsreduct; } 
       set { SetPropertyValue(nameof(indrqmtsreduct), ref _indrqmtsreduct, value); } 
     } 
     // Updating Control
     // Notes for fInventoryManagement : 
     private bool _generatephinvdoc; 
     [XafDisplayName("Generate Ph-Inv-Doc."), ToolTip("Generate ph.inv.doc.")] 
     // [Appearance("fInventoryManagementgeneratephinvdoc", Enabled = true)]
     // [Appearance("fInventoryManagementgeneratephinvdocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool generatephinvdoc
     { 
       get { return _generatephinvdoc; } 
       set { SetPropertyValue(nameof(generatephinvdoc), ref _generatephinvdoc, value); } 
     } 
     // Updating Control
     // Notes for fInventoryManagement : 
     private bool _autopo; 
     [XafDisplayName("Automatic PO"), ToolTip("Automatic PO")] 
     // [Appearance("fInventoryManagementautopo", Enabled = true)]
     // [Appearance("fInventoryManagementautopoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool autopo
     { 
       get { return _autopo; } 
       set { SetPropertyValue(nameof(autopo), ref _autopo, value); } 
     } 
     // Updating Control
     // Notes for fInventoryManagement : 
     private string _statisrelev; 
     [XafDisplayName("Statistically Relev."), ToolTip("Statistically relev.")] 
     // [Appearance("fInventoryManagementstatisrelev", Enabled = true)]
     // [Appearance("fInventoryManagementstatisrelevVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string statisrelev
     { 
       get { return _statisrelev; } 
       set { SetPropertyValue(nameof(statisrelev), ref _statisrelev, value); } 
     } 
     // Updating Control
     // Notes for fInventoryManagement : 
     private string _consumpost; 
     [XafDisplayName("Consumption Posting"), ToolTip("Consumption posting")] 
     // [Appearance("fInventoryManagementconsumpost", Enabled = true)]
     // [Appearance("fInventoryManagementconsumpostVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string consumpost
     { 
       get { return _consumpost; } 
       set { SetPropertyValue(nameof(consumpost), ref _consumpost, value); } 
     } 
     // Updating Control
     // Notes for fInventoryManagement : 
     private string _store; 
     [XafDisplayName("Store"), ToolTip("Store")] 
     // [Appearance("fInventoryManagementstore", Enabled = true)]
     // [Appearance("fInventoryManagementstoreVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(12)] 
     public  string store
     { 
       get { return _store; } 
       set { SetPropertyValue(nameof(store), ref _store, value); } 
     } 
     // Internal Control (Please Do Not Change)
     // Notes for fInventoryManagement : 
     private bool _revmvmnttypeind; 
     [XafDisplayName("Rev. Mvmnt Type Ind."), ToolTip("Rev. mvmnt type ind.")] 
     // [Appearance("fInventoryManagementrevmvmnttypeind", Enabled = true)]
     // [Appearance("fInventoryManagementrevmvmnttypeindVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool revmvmnttypeind
     { 
       get { return _revmvmnttypeind; } 
       set { SetPropertyValue(nameof(revmvmnttypeind), ref _revmvmnttypeind, value); } 
     } 
     // Internal Control (Please Do Not Change)
     // Notes for fInventoryManagement : 
     private bool _costelemacc; 
     [XafDisplayName("CostElem Account"), ToolTip("CostElem account")] 
     // [Appearance("fInventoryManagementcostelemacc", Enabled = true)]
     // [Appearance("fInventoryManagementcostelemaccVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool costelemacc
     { 
       get { return _costelemacc; } 
       set { SetPropertyValue(nameof(costelemacc), ref _costelemacc, value); } 
     } 
     // Internal Control (Please Do Not Change)
     // Notes for fInventoryManagement : 
     private string _mvttypectgr; 
     [XafDisplayName("Mvt Type Category"), ToolTip("Mvt type category")] 
     // [Appearance("fInventoryManagementmvttypectgr", Enabled = true)]
     // [Appearance("fInventoryManagementmvttypectgrVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string mvttypectgr
     { 
       get { return _mvttypectgr; } 
       set { SetPropertyValue(nameof(mvttypectgr), ref _mvttypectgr, value); } 
     } 
     // Internal Control (Please Do Not Change)
     // Notes for fInventoryManagement : 
     private string _debitind; 
     [XafDisplayName("Debit/Credit Ind."), ToolTip("Debit/Credit Ind.")] 
     // [Appearance("fInventoryManagementdebitind", Enabled = true)]
     // [Appearance("fInventoryManagementdebitindVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string debitind
     { 
       get { return _debitind; } 
       set { SetPropertyValue(nameof(debitind), ref _debitind, value); } 
     } 
     // Internal Control (Please Do Not Change)
     // Notes for fInventoryManagement : 
     private string _reservcat; 
     [XafDisplayName("Reserv. Cat."), ToolTip("Reserv. Cat.")] 
     // [Appearance("fInventoryManagementreservcat", Enabled = true)]
     // [Appearance("fInventoryManagementreservcatVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string reservcat
     { 
       get { return _reservcat; } 
       set { SetPropertyValue(nameof(reservcat), ref _reservcat, value); } 
     } 
     // Internal Control (Please Do Not Change)
     // Notes for fInventoryManagement : 
     private string _grblockstck; 
     [XafDisplayName("GR Blocked Stock"), ToolTip("GR blocked stock")] 
     // [Appearance("fInventoryManagementgrblockstck", Enabled = true)]
     // [Appearance("fInventoryManagementgrblockstckVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string grblockstck
     { 
       get { return _grblockstck; } 
       set { SetPropertyValue(nameof(grblockstck), ref _grblockstck, value); } 
     } 
     // Internal Control (Please Do Not Change)
     // Notes for fInventoryManagement : 
     private string _directind; 
     [XafDisplayName("Direction Indicator"), ToolTip("Direction Indicator")] 
     // [Appearance("fInventoryManagementdirectind", Enabled = true)]
     // [Appearance("fInventoryManagementdirectindVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string directind
     { 
       get { return _directind; } 
       set { SetPropertyValue(nameof(directind), ref _directind, value); } 
     } 
   } 
} 
