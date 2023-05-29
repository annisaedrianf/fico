// Class Name : fTextType.cs 
// Project Name : FICO 
// Last Update : 29/05/2023 15:31:03  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 29/05/2023 15:31:03 
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
   [System.ComponentModel.DisplayName("Customizing Text Determination")]
   public class fTextType : XPObject
   {
     public fTextType(Session session) : base(session) 
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
     [Appearance("VisiblefTextTypeOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // Text Object
     // Notes for fTextType : 
     private bool _cntltext; 
     [XafDisplayName("Central Texts"), ToolTip("Central Texts")] 
     // [Appearance("fTextTypecntltext", Enabled = true)]
     // [Appearance("fTextTypecntltextVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool cntltext
     { 
       get { return _cntltext; } 
       set { SetPropertyValue(nameof(cntltext), ref _cntltext, value); } 
     } 
     // Text Object
     // Notes for fTextType : 
     private bool _contactperson; 
     [XafDisplayName("Contact Person"), ToolTip("Contact Person")] 
     // [Appearance("fTextTypecontactperson", Enabled = true)]
     // [Appearance("fTextTypecontactpersonVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool contactperson
     { 
       get { return _contactperson; } 
       set { SetPropertyValue(nameof(contactperson), ref _contactperson, value); } 
     } 
     // Text Object
     // Notes for fTextType : 
     private bool _distr; 
     [XafDisplayName("Sales & Distribution"), ToolTip("Sales & Distribution")] 
     // [Appearance("fTextTypedistr", Enabled = true)]
     // [Appearance("fTextTypedistrVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool distr
     { 
       get { return _distr; } 
       set { SetPropertyValue(nameof(distr), ref _distr, value); } 
     } 
     // Change View "TxtDetProc Customer SD": Overview
     // Notes for fTextType : 
     private string _textobjchg; 
     [XafDisplayName("Text Object (TxtDetProc Customer SD)"), ToolTip("Text Object (TxtDetProc Customer SD)")] 
     // [Appearance("fTextTypetextobjchg", Enabled = true)]
     // [Appearance("fTextTypetextobjchgVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string textobjchg
     { 
       get { return _textobjchg; } 
       set { SetPropertyValue(nameof(textobjchg), ref _textobjchg, value); } 
     } 
     // Change View "TxtDetProc Customer SD": Overview
     // Notes for fTextType : 
     private string _groupforchg; 
     [XafDisplayName("Group For (TxtDetProc Customer SD)"), ToolTip("Group For (TxtDetProc Customer SD)")] 
     // [Appearance("fTextTypegroupforchg", Enabled = true)]
     // [Appearance("fTextTypegroupforchgVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string groupforchg
     { 
       get { return _groupforchg; } 
       set { SetPropertyValue(nameof(groupforchg), ref _groupforchg, value); } 
     } 
     // Change View "TxtDetProc Customer SD": Overview
     // Notes for fTextType : 
     private string _txprcchg; 
     [XafDisplayName("TxPrc (TxtDetProc Customer SD)"), ToolTip("TxPrc (TxtDetProc Customer SD)")] 
     // [Appearance("fTextTypetxprcchg", Enabled = true)]
     // [Appearance("fTextTypetxprcchgVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string txprcchg
     { 
       get { return _txprcchg; } 
       set { SetPropertyValue(nameof(txprcchg), ref _txprcchg, value); } 
     } 
     // Change View "TxtDetProc Customer SD": Overview
     // Notes for fTextType : 
     private string _desctxtdetprocchg; 
     [XafDisplayName("Description TxtDetProc"), ToolTip("Description TxtDetProc")] 
     // [Appearance("fTextTypedesctxtdetprocchg", Enabled = true)]
     // [Appearance("fTextTypedesctxtdetprocchgVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string desctxtdetprocchg
     { 
       get { return _desctxtdetprocchg; } 
       set { SetPropertyValue(nameof(desctxtdetprocchg), ref _desctxtdetprocchg, value); } 
     } 
     // New Entries (View "TxtDetProc Customer SD")
     // Notes for fTextType : 
     private string _textobj; 
     [XafDisplayName("Text Object"), ToolTip("Text Object")] 
     // [Appearance("fTextTypetextobj", Enabled = true)]
     // [Appearance("fTextTypetextobjVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string textobj
     { 
       get { return _textobj; } 
       set { SetPropertyValue(nameof(textobj), ref _textobj, value); } 
     } 
     // New Entries (View "TxtDetProc Customer SD")
     // Notes for fTextType : 
     private string _groupfor; 
     [XafDisplayName("Group For"), ToolTip("Group for")] 
     // [Appearance("fTextTypegroupfor", Enabled = true)]
     // [Appearance("fTextTypegroupforVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string groupfor
     { 
       get { return _groupfor; } 
       set { SetPropertyValue(nameof(groupfor), ref _groupfor, value); } 
     } 
     // New Entries (View "TxtDetProc Customer SD")
     // Notes for fTextType : 
     private string _txprc; 
     [XafDisplayName("TxPrc"), ToolTip("TxPrc")] 
     // [Appearance("fTextTypetxprc", Enabled = true)]
     // [Appearance("fTextTypetxprcVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string txprc
     { 
       get { return _txprc; } 
       set { SetPropertyValue(nameof(txprc), ref _txprc, value); } 
     } 
     // New Entries (View "TxtDetProc Customer SD")
     // Notes for fTextType : 
     private string _desctxtdetproc; 
     [XafDisplayName("Description TxtDetProc"), ToolTip("Description TxtDetProc")] 
     // [Appearance("fTextTypedesctxtdetproc", Enabled = true)]
     // [Appearance("fTextTypedesctxtdetprocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string desctxtdetproc
     { 
       get { return _desctxtdetproc; } 
       set { SetPropertyValue(nameof(desctxtdetproc), ref _desctxtdetproc, value); } 
     } 
     // Change View "Customer SD Txt DetProc Assignmt": Overview
     // Notes for fTextType : 
     private string _grp; 
     [XafDisplayName("Group"), ToolTip("Group")] 
     // [Appearance("fTextTypegrp", Enabled = true)]
     // [Appearance("fTextTypegrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string grp
     { 
       get { return _grp; } 
       set { SetPropertyValue(nameof(grp), ref _grp, value); } 
     } 
     // Change View "Customer SD Txt DetProc Assignmt": Overview
     // Notes for fTextType : 
     private string _desc; 
     [XafDisplayName("Description"), ToolTip("Description")] 
     // [Appearance("fTextTypedesc", Enabled = true)]
     // [Appearance("fTextTypedescVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string desc
     { 
       get { return _desc; } 
       set { SetPropertyValue(nameof(desc), ref _desc, value); } 
     } 
     // New Entries (View "Customer SD Text IDs in Txt Det. Proc Z1")
     // Notes for fTextType : 
     private string _textobj1; 
     [XafDisplayName("Text Object (Customer SD Text IDs in Txt Det. Proc Z1)"), ToolTip("Text Object (Customer SD Text IDs in Txt Det. Proc Z1)")] 
     // [Appearance("fTextTypetextobj1", Enabled = true)]
     // [Appearance("fTextTypetextobj1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string textobj1
     { 
       get { return _textobj1; } 
       set { SetPropertyValue(nameof(textobj1), ref _textobj1, value); } 
     } 
     // New Entries (View "Customer SD Text IDs in Txt Det. Proc Z1")
     // Notes for fTextType : 
     private string _groupfor1; 
     [XafDisplayName("Group For (Customer SD Text IDs in Txt Det. Proc Z1)"), ToolTip("Group For (Customer SD Text IDs in Txt Det. Proc Z1)")] 
     // [Appearance("fTextTypegroupfor1", Enabled = true)]
     // [Appearance("fTextTypegroupfor1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string groupfor1
     { 
       get { return _groupfor1; } 
       set { SetPropertyValue(nameof(groupfor1), ref _groupfor1, value); } 
     } 
     // New Entries (View "Customer SD Text IDs in Txt Det. Proc Z1")
     // Notes for fTextType : 
     private string _textdetermproc; 
     [XafDisplayName("TextDetermProc."), ToolTip("TextDetermProc.")] 
     // [Appearance("fTextTypetextdetermproc", Enabled = true)]
     // [Appearance("fTextTypetextdetermprocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string textdetermproc
     { 
       get { return _textdetermproc; } 
       set { SetPropertyValue(nameof(textdetermproc), ref _textdetermproc, value); } 
     } 
     // New Entries (View "Customer SD Text IDs in Txt Det. Proc Z1")
     // Notes for fTextType : 
     private string _seqno; 
     [XafDisplayName("Seq No"), ToolTip("SeqNo")] 
     // [Appearance("fTextTypeseqno", Enabled = true)]
     // [Appearance("fTextTypeseqnoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string seqno
     { 
       get { return _seqno; } 
       set { SetPropertyValue(nameof(seqno), ref _seqno, value); } 
     } 
     // New Entries (View "Customer SD Text IDs in Txt Det. Proc Z1")
     // Notes for fTextType : 
     private string _id; 
     [XafDisplayName("ID"), ToolTip("ID")] 
     // [Appearance("fTextTypeid", Enabled = true)]
     // [Appearance("fTextTypeidVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string id
     { 
       get { return _id; } 
       set { SetPropertyValue(nameof(id), ref _id, value); } 
     } 
     // New Entries (View "Customer SD Text IDs in Txt Det. Proc Z1")
     // Notes for fTextType : 
     private string _iddesc; 
     [XafDisplayName("ID Description"), ToolTip("ID Description")] 
     // [Appearance("fTextTypeiddesc", Enabled = true)]
     // [Appearance("fTextTypeiddescVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string iddesc
     { 
       get { return _iddesc; } 
       set { SetPropertyValue(nameof(iddesc), ref _iddesc, value); } 
     } 
   } 
} 
