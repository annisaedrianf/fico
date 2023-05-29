// Class Name : fOutputProposal.cs 
// Project Name : FICO 
// Last Update : 29/05/2023 15:42:24  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 29/05/2023 15:42:24 
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
   [System.ComponentModel.DisplayName("Output Proposal Using the Condition Tehcnique")]
   public class fOutputProposal : XPObject
   {
     public fOutputProposal(Session session) : base(session) 
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
     [Appearance("VisiblefOutputProposalOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for fOutputProposal : 
     private string _outputtype; 
     [XafDisplayName("Output Type"), ToolTip("Output Type")] 
     // [Appearance("fOutputProposaloutputtype", Enabled = true)]
     // [Appearance("fOutputProposaloutputtypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string outputtype
     { 
       get { return _outputtype; } 
       set { SetPropertyValue(nameof(outputtype), ref _outputtype, value); } 
     } 
     // General data
     // Notes for fOutputProposal : 
     private string _accseq; 
     [XafDisplayName("Access Sequence"), ToolTip("Access sequence")] 
     // [Appearance("fOutputProposalaccseq", Enabled = true)]
     // [Appearance("fOutputProposalaccseqVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string accseq
     { 
       get { return _accseq; } 
       set { SetPropertyValue(nameof(accseq), ref _accseq, value); } 
     } 
     // General data
     // Notes for fOutputProposal : 
     private bool _acccond; 
     [XafDisplayName("Access to Conditions"), ToolTip("Access to conditions")] 
     // [Appearance("fOutputProposalacccond", Enabled = true)]
     // [Appearance("fOutputProposalacccondVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool acccond
     { 
       get { return _acccond; } 
       set { SetPropertyValue(nameof(acccond), ref _acccond, value); } 
     } 
     // General data
     // Notes for fOutputProposal : 
     private bool _cannotbechanged; 
     [XafDisplayName("Cannot Be Changed"), ToolTip("CannotBeChanged")] 
     // [Appearance("fOutputProposalcannotbechanged", Enabled = true)]
     // [Appearance("fOutputProposalcannotbechangedVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool cannotbechanged
     { 
       get { return _cannotbechanged; } 
       set { SetPropertyValue(nameof(cannotbechanged), ref _cannotbechanged, value); } 
     } 
     // General data
     // Notes for fOutputProposal : 
     private bool _multisuuing; 
     [XafDisplayName("Multiple Issuing"), ToolTip("Multiple issuing")] 
     // [Appearance("fOutputProposalmultisuuing", Enabled = true)]
     // [Appearance("fOutputProposalmultisuuingVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool multisuuing
     { 
       get { return _multisuuing; } 
       set { SetPropertyValue(nameof(multisuuing), ref _multisuuing, value); } 
     } 
     // General data
     // Notes for fOutputProposal : 
     private bool _partnerindepoutput; 
     [XafDisplayName("Partner-Indep Output"), ToolTip("Partner-indep.output")] 
     // [Appearance("fOutputProposalpartnerindepoutput", Enabled = true)]
     // [Appearance("fOutputProposalpartnerindepoutputVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool partnerindepoutput
     { 
       get { return _partnerindepoutput; } 
       set { SetPropertyValue(nameof(partnerindepoutput), ref _partnerindepoutput, value); } 
     } 
     // General data
     // Notes for fOutputProposal : 
     private bool _donotwriteproclog; 
     [XafDisplayName("Do not Write Processing Log"), ToolTip("do not write processing log")] 
     // [Appearance("fOutputProposaldonotwriteproclog", Enabled = true)]
     // [Appearance("fOutputProposaldonotwriteproclogVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool donotwriteproclog
     { 
       get { return _donotwriteproclog; } 
       set { SetPropertyValue(nameof(donotwriteproclog), ref _donotwriteproclog, value); } 
     } 
     // Default values
     // Notes for fOutputProposal : 
     private string _dispatchtime; 
     [XafDisplayName("Dispatch Time"), ToolTip("Dispatch Time")] 
     // [Appearance("fOutputProposaldispatchtime", Enabled = true)]
     // [Appearance("fOutputProposaldispatchtimeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string dispatchtime
     { 
       get { return _dispatchtime; } 
       set { SetPropertyValue(nameof(dispatchtime), ref _dispatchtime, value); } 
     } 
     // Default values
     // Notes for fOutputProposal : 
     private string _transmedium; 
     [XafDisplayName("Transmission Medium"), ToolTip("Transmission Medium")] 
     // [Appearance("fOutputProposaltransmedium", Enabled = true)]
     // [Appearance("fOutputProposaltransmediumVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string transmedium
     { 
       get { return _transmedium; } 
       set { SetPropertyValue(nameof(transmedium), ref _transmedium, value); } 
     } 
     // Default values
     // Notes for fOutputProposal : 
     private string _partnerfunct; 
     [XafDisplayName("Partner Function"), ToolTip("Partner Function")] 
     // [Appearance("fOutputProposalpartnerfunct", Enabled = true)]
     // [Appearance("fOutputProposalpartnerfunctVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string partnerfunct
     { 
       get { return _partnerfunct; } 
       set { SetPropertyValue(nameof(partnerfunct), ref _partnerfunct, value); } 
     } 
     // Default values
     // Notes for fOutputProposal : 
     private string _comstrategy; 
     [XafDisplayName("Communication Strategy"), ToolTip("Communication strategy")] 
     // [Appearance("fOutputProposalcomstrategy", Enabled = true)]
     // [Appearance("fOutputProposalcomstrategyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string comstrategy
     { 
       get { return _comstrategy; } 
       set { SetPropertyValue(nameof(comstrategy), ref _comstrategy, value); } 
     } 
     // Time
     // Notes for fOutputProposal : 
     private bool _timing1; 
     [XafDisplayName("Timing 1 (Period Job) Not Allowed"), ToolTip("Timing 1 (period job) not allowed")] 
     // [Appearance("fOutputProposaltiming1", Enabled = true)]
     // [Appearance("fOutputProposaltiming1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool timing1
     { 
       get { return _timing1; } 
       set { SetPropertyValue(nameof(timing1), ref _timing1, value); } 
     } 
     // Time
     // Notes for fOutputProposal : 
     private bool _timing2; 
     [XafDisplayName("Timing 2 (Job & Time Entry) Not Allowed"), ToolTip("Timing 2 (job and time entry) not allowed")] 
     // [Appearance("fOutputProposaltiming2", Enabled = true)]
     // [Appearance("fOutputProposaltiming2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool timing2
     { 
       get { return _timing2; } 
       set { SetPropertyValue(nameof(timing2), ref _timing2, value); } 
     } 
     // Time
     // Notes for fOutputProposal : 
     private bool _timing3; 
     [XafDisplayName("Timing 3 (Application Transacation) Not Allowed"), ToolTip("Timing 3 (application transaction) not allowed")] 
     // [Appearance("fOutputProposaltiming3", Enabled = true)]
     // [Appearance("fOutputProposaltiming3Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool timing3
     { 
       get { return _timing3; } 
       set { SetPropertyValue(nameof(timing3), ref _timing3, value); } 
     } 
     // Time
     // Notes for fOutputProposal : 
     private bool _timing4; 
     [XafDisplayName("Timing 4 (Immediate) Not Allowed"), ToolTip("Timing 4 (immediate) not allowed")] 
     // [Appearance("fOutputProposaltiming4", Enabled = true)]
     // [Appearance("fOutputProposaltiming4Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool timing4
     { 
       get { return _timing4; } 
       set { SetPropertyValue(nameof(timing4), ref _timing4, value); } 
     } 
     // Time
     // Notes for fOutputProposal : 
     private string _outputtimingprg; 
     [XafDisplayName("Output Timing Prg"), ToolTip("Output timing prg")] 
     // [Appearance("fOutputProposaloutputtimingprg", Enabled = true)]
     // [Appearance("fOutputProposaloutputtimingprgVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string outputtimingprg
     { 
       get { return _outputtimingprg; } 
       set { SetPropertyValue(nameof(outputtimingprg), ref _outputtimingprg, value); } 
     } 
     // Time
     // Notes for fOutputProposal : 
     private string _formroutine; 
     [XafDisplayName("From Routine"), ToolTip("FORM routine")] 
     // [Appearance("fOutputProposalformroutine", Enabled = true)]
     // [Appearance("fOutputProposalformroutineVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string formroutine
     { 
       get { return _formroutine; } 
       set { SetPropertyValue(nameof(formroutine), ref _formroutine, value); } 
     } 
   } 
} 
