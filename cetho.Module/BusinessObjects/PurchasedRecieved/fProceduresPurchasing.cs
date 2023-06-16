// Class Name : fProceduresPurchasing.cs 
// Project Name : FICO 
// Last Update : 14/06/2023 13:12:57  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 14/06/2023 13:12:57 
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
   [System.ComponentModel.DisplayName("Release Procedures Purchasing")]
   public class fProceduresPurchasing : XPObject
   {
     public fProceduresPurchasing(Session session) : base(session) 
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
     [Appearance("VisiblefProceduresPurchasingOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // Addnl Data
     // Notes for fProceduresPurchasing : 
     private string _fildname; 
     [XafDisplayName("Filed Name"), ToolTip("Filed Name")] 
     // [Appearance("fProceduresPurchasingfildname", Enabled = true)]
     // [Appearance("fProceduresPurchasingfildnameVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string fildname
     { 
       get { return _fildname; } 
       set { SetPropertyValue(nameof(fildname), ref _fildname, value); } 
     } 
     // Addnl Data
     // Notes for fProceduresPurchasing : 
     private string _tblname; 
     [XafDisplayName("Table Name"), ToolTip("Table Name")] 
     // [Appearance("fProceduresPurchasingtblname", Enabled = true)]
     // [Appearance("fProceduresPurchasingtblnameVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string tblname
     { 
       get { return _tblname; } 
       set { SetPropertyValue(nameof(tblname), ref _tblname, value); } 
     } 
     // Authorizations
     // Notes for fProceduresPurchasing : 
     private string _classification; 
     [XafDisplayName("Classification"), ToolTip("Classification")] 
     // [Appearance("fProceduresPurchasingclassification", Enabled = true)]
     // [Appearance("fProceduresPurchasingclassificationVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string classification
     { 
       get { return _classification; } 
       set { SetPropertyValue(nameof(classification), ref _classification, value); } 
     } 
     // Authorizations
     // Notes for fProceduresPurchasing : 
     private string _classmaintan; 
     [XafDisplayName("Class maintenance"), ToolTip("Class maintenance")] 
     // [Appearance("fProceduresPurchasingclassmaintan", Enabled = true)]
     // [Appearance("fProceduresPurchasingclassmaintanVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string classmaintan
     { 
       get { return _classmaintan; } 
       set { SetPropertyValue(nameof(classmaintan), ref _classmaintan, value); } 
     } 
     // Authorizations
     // Notes for fProceduresPurchasing : 
     private string _findobj; 
     [XafDisplayName("Find object"), ToolTip("Find object")] 
     // [Appearance("fProceduresPurchasingfindobj", Enabled = true)]
     // [Appearance("fProceduresPurchasingfindobjVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string findobj
     { 
       get { return _findobj; } 
       set { SetPropertyValue(nameof(findobj), ref _findobj, value); } 
     } 
     // Basic data
     // Notes for fProceduresPurchasing : 
     private enumClassGrp _classgroup; 
     [XafDisplayName("Class group"), ToolTip("Class group")] 
     // [Appearance("fProceduresPurchasingclassgroup", Enabled = true)]
     // [Appearance("fProceduresPurchasingclassgroupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumClassGrp classgroup
     { 
       get { return _classgroup; } 
       set { SetPropertyValue(nameof(classgroup), ref _classgroup, value); } 
     } 
     // Basic data
     // Notes for fProceduresPurchasing : 
     private string _desc; 
     [XafDisplayName("Description"), ToolTip("Description")] 
     // [Appearance("fProceduresPurchasingdesc", Enabled = true)]
     // [Appearance("fProceduresPurchasingdescVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string desc
     { 
       get { return _desc; } 
       set { SetPropertyValue(nameof(desc), ref _desc, value); } 
     } 
     // Basic data
     // Notes for fProceduresPurchasing : 
     private bool _localclass; 
     [XafDisplayName("Local class"), ToolTip("Local class")] 
     // [Appearance("fProceduresPurchasinglocalclass", Enabled = true)]
     // [Appearance("fProceduresPurchasinglocalclassVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool localclass
     { 
       get { return _localclass; } 
       set { SetPropertyValue(nameof(localclass), ref _localclass, value); } 
     } 
     // Basic data
     // Notes for fProceduresPurchasing : 
     private string _orgntlarea; 
     [XafDisplayName("Organizational area"), ToolTip("Organizational area")] 
     // [Appearance("fProceduresPurchasingorgntlarea", Enabled = true)]
     // [Appearance("fProceduresPurchasingorgntlareaVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string orgntlarea
     { 
       get { return _orgntlarea; } 
       set { SetPropertyValue(nameof(orgntlarea), ref _orgntlarea, value); } 
     } 
     // Basic data
     // Notes for fProceduresPurchasing : 
     private enumStatus _status; 
     [XafDisplayName("Status"), ToolTip("Status")] 
     // [Appearance("fProceduresPurchasingstatus", Enabled = true)]
     // [Appearance("fProceduresPurchasingstatusVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumStatus status
     { 
       get { return _status; } 
       set { SetPropertyValue(nameof(status), ref _status, value); } 
     } 
     // Basic data
     // Notes for fProceduresPurchasing : 
     private DateTime _vldfrom2; 
     [XafDisplayName("Valid From (bs)"), ToolTip("Valid From (bs)")] 
     // [Appearance("fProceduresPurchasingvldfrom2", Enabled = true)]
     // [Appearance("fProceduresPurchasingvldfrom2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime vldfrom2
     { 
       get { return _vldfrom2; } 
       set { SetPropertyValue(nameof(vldfrom2), ref _vldfrom2, value); } 
     } 
     // Basic data
     // Notes for fProceduresPurchasing : 
     private DateTime _vldto; 
     [XafDisplayName("Valid to"), ToolTip("Valid to")] 
     // [Appearance("fProceduresPurchasingvldto", Enabled = true)]
     // [Appearance("fProceduresPurchasingvldtoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime vldto
     { 
       get { return _vldto; } 
       set { SetPropertyValue(nameof(vldto), ref _vldto, value); } 
     } 
     // Change Language
     // Notes for fProceduresPurchasing : 
     private string _chgnumb1; 
     [XafDisplayName("Change Number (l)"), ToolTip("Change Number (l)")] 
     // [Appearance("fProceduresPurchasingchgnumb1", Enabled = true)]
     // [Appearance("fProceduresPurchasingchgnumb1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string chgnumb1
     { 
       get { return _chgnumb1; } 
       set { SetPropertyValue(nameof(chgnumb1), ref _chgnumb1, value); } 
     } 
     // Change Language
     // Notes for fProceduresPurchasing : 
     private string _classl; 
     [XafDisplayName("Class"), ToolTip("Class")] 
     // [Appearance("fProceduresPurchasingclassl", Enabled = true)]
     // [Appearance("fProceduresPurchasingclasslVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string classl
     { 
       get { return _classl; } 
       set { SetPropertyValue(nameof(classl), ref _classl, value); } 
     } 
     // Change Language
     // Notes for fProceduresPurchasing : 
     private string _classtype; 
     [XafDisplayName("Class type"), ToolTip("Class type")] 
     // [Appearance("fProceduresPurchasingclasstype", Enabled = true)]
     // [Appearance("fProceduresPurchasingclasstypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string classtype
     { 
       get { return _classtype; } 
       set { SetPropertyValue(nameof(classtype), ref _classtype, value); } 
     } 
     // Change Language
     // Notes for fProceduresPurchasing : 
     private DateTime _vldfrom1; 
     [XafDisplayName("Valid From (l)"), ToolTip("Valid From (l)")] 
     // [Appearance("fProceduresPurchasingvldfrom1", Enabled = true)]
     // [Appearance("fProceduresPurchasingvldfrom1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime vldfrom1
     { 
       get { return _vldfrom1; } 
       set { SetPropertyValue(nameof(vldfrom1), ref _vldfrom1, value); } 
     } 
     // Delivery/Invoice
     // Notes for fProceduresPurchasing : 
     private string _delivered1; 
     [XafDisplayName("Delivered (di)"), ToolTip("Delivered (di)")] 
     // [Appearance("fProceduresPurchasingdelivered1", Enabled = true)]
     // [Appearance("fProceduresPurchasingdelivered1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string delivered1
     { 
       get { return _delivered1; } 
       set { SetPropertyValue(nameof(delivered1), ref _delivered1, value); } 
     } 
     // Delivery/Invoice
     // Notes for fProceduresPurchasing : 
     private double _downpaymt1; 
     [XafDisplayName("Down paymts (di)"), ToolTip("Down paymts (di)")] 
     // [Appearance("fProceduresPurchasingdownpaymt1", Enabled = true)]
     // [Appearance("fProceduresPurchasingdownpaymt1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double downpaymt1
     { 
       get { return _downpaymt1; } 
       set { SetPropertyValue(nameof(downpaymt1), ref _downpaymt1, value); } 
     } 
     // Delivery/Invoice
     // Notes for fProceduresPurchasing : 
     private string _invoiced1; 
     [XafDisplayName("Invoiced (di)"), ToolTip("Invoiced (di)")] 
     // [Appearance("fProceduresPurchasinginvoiced1", Enabled = true)]
     // [Appearance("fProceduresPurchasinginvoiced1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string invoiced1
     { 
       get { return _invoiced1; } 
       set { SetPropertyValue(nameof(invoiced1), ref _invoiced1, value); } 
     } 
     // Delivery/Invoice
     // Notes for fProceduresPurchasing : 
     private string _ordered1; 
     [XafDisplayName("Ordered (di)"), ToolTip("Ordered (di)")] 
     // [Appearance("fProceduresPurchasingordered1", Enabled = true)]
     // [Appearance("fProceduresPurchasingordered1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string ordered1
     { 
       get { return _ordered1; } 
       set { SetPropertyValue(nameof(ordered1), ref _ordered1, value); } 
     } 
     // Delivery/Invoice
     // Notes for fProceduresPurchasing : 
     private double _pal4; 
     [XafDisplayName("PAL (di)"), ToolTip("PAL (di)")] 
     // [Appearance("fProceduresPurchasingpal4", Enabled = true)]
     // [Appearance("fProceduresPurchasingpal4Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double pal4
     { 
       get { return _pal4; } 
       set { SetPropertyValue(nameof(pal4), ref _pal4, value); } 
     } 
     // Delivery/Invoice
     // Notes for fProceduresPurchasing : 
     private double _pal5; 
     [XafDisplayName("PAL (di)"), ToolTip("PAL (di)")] 
     // [Appearance("fProceduresPurchasingpal5", Enabled = true)]
     // [Appearance("fProceduresPurchasingpal5Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double pal5
     { 
       get { return _pal5; } 
       set { SetPropertyValue(nameof(pal5), ref _pal5, value); } 
     } 
     // Delivery/Invoice
     // Notes for fProceduresPurchasing : 
     private double _pal6; 
     [XafDisplayName("PAL (di)"), ToolTip("PAL (di)")] 
     // [Appearance("fProceduresPurchasingpal6", Enabled = true)]
     // [Appearance("fProceduresPurchasingpal6Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double pal6
     { 
       get { return _pal6; } 
       set { SetPropertyValue(nameof(pal6), ref _pal6, value); } 
     } 
     // Delivery/Invoice
     // Notes for fProceduresPurchasing : 
     private double _pal7; 
     [XafDisplayName("PAL (di)"), ToolTip("PAL (di)")] 
     // [Appearance("fProceduresPurchasingpal7", Enabled = true)]
     // [Appearance("fProceduresPurchasingpal7Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double pal7
     { 
       get { return _pal7; } 
       set { SetPropertyValue(nameof(pal7), ref _pal7, value); } 
     } 
     // Delivery/Invoice
     // Notes for fProceduresPurchasing : 
     private string _stilltodeliv1; 
     [XafDisplayName("Still to deliv. (di)"), ToolTip("Still to deliv. (di)")] 
     // [Appearance("fProceduresPurchasingstilltodeliv1", Enabled = true)]
     // [Appearance("fProceduresPurchasingstilltodeliv1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string stilltodeliv1
     { 
       get { return _stilltodeliv1; } 
       set { SetPropertyValue(nameof(stilltodeliv1), ref _stilltodeliv1, value); } 
     } 
     // Release (Approve) Purchasing Documents
     // Notes for fProceduresPurchasing : 
     private bool _cancelrelease; 
     [XafDisplayName("Cancel Release"), ToolTip("Cancel Release")] 
     // [Appearance("fProceduresPurchasingcancelrelease", Enabled = true)]
     // [Appearance("fProceduresPurchasingcancelreleaseVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool cancelrelease
     { 
       get { return _cancelrelease; } 
       set { SetPropertyValue(nameof(cancelrelease), ref _cancelrelease, value); } 
     } 
     // Release (Approve) Purchasing Documents
     // Notes for fProceduresPurchasing : 
     private DateTime _docdat; 
     [XafDisplayName("Document Date"), ToolTip("Document Date")] 
     // [Appearance("fProceduresPurchasingdocdat", Enabled = true)]
     // [Appearance("fProceduresPurchasingdocdatVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime docdat
     { 
       get { return _docdat; } 
       set { SetPropertyValue(nameof(docdat), ref _docdat, value); } 
     } 
     // Release (Approve) Purchasing Documents
     // Notes for fProceduresPurchasing : 
     private string _docgroup; 
     [XafDisplayName("Document Group"), ToolTip("Document Group")] 
     // [Appearance("fProceduresPurchasingdocgroup", Enabled = true)]
     // [Appearance("fProceduresPurchasingdocgroupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string docgroup
     { 
       get { return _docgroup; } 
       set { SetPropertyValue(nameof(docgroup), ref _docgroup, value); } 
     } 
     // Release (Approve) Purchasing Documents
     // Notes for fProceduresPurchasing : 
     private string _docnumb; 
     [XafDisplayName("Document Number"), ToolTip("Document Number")] 
     // [Appearance("fProceduresPurchasingdocnumb", Enabled = true)]
     // [Appearance("fProceduresPurchasingdocnumbVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string docnumb
     { 
       get { return _docnumb; } 
       set { SetPropertyValue(nameof(docnumb), ref _docnumb, value); } 
     } 
     // Release (Approve) Purchasing Documents
     // Notes for fProceduresPurchasing : 
     private string _doctype; 
     [XafDisplayName("Document Type"), ToolTip("Document Type")] 
     // [Appearance("fProceduresPurchasingdoctype", Enabled = true)]
     // [Appearance("fProceduresPurchasingdoctypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string doctype
     { 
       get { return _doctype; } 
       set { SetPropertyValue(nameof(doctype), ref _doctype, value); } 
     } 
     // Release (Approve) Purchasing Documents
     // Notes for fProceduresPurchasing : 
     private bool _listitems; 
     [XafDisplayName("List with Items"), ToolTip("List with Items")] 
     // [Appearance("fProceduresPurchasinglistitems", Enabled = true)]
     // [Appearance("fProceduresPurchasinglistitemsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool listitems
     { 
       get { return _listitems; } 
       set { SetPropertyValue(nameof(listitems), ref _listitems, value); } 
     } 
     // Release (Approve) Purchasing Documents
     // Notes for fProceduresPurchasing : 
     private string _purchdocctg; 
     [XafDisplayName("Purchasing Document Category"), ToolTip("Purchasing Document Category")] 
     // [Appearance("fProceduresPurchasingpurchdocctg", Enabled = true)]
     // [Appearance("fProceduresPurchasingpurchdocctgVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string purchdocctg
     { 
       get { return _purchdocctg; } 
       set { SetPropertyValue(nameof(purchdocctg), ref _purchdocctg, value); } 
     } 
     // Release (Approve) Purchasing Documents
     // Notes for fProceduresPurchasing : 
     private string _purchorgn; 
     [XafDisplayName("Purchasing Organization"), ToolTip("Purchasing Organization")] 
     // [Appearance("fProceduresPurchasingpurchorgn", Enabled = true)]
     // [Appearance("fProceduresPurchasingpurchorgnVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string purchorgn
     { 
       get { return _purchorgn; } 
       set { SetPropertyValue(nameof(purchorgn), ref _purchorgn, value); } 
     } 
     // Release (Approve) Purchasing Documents
     // Notes for fProceduresPurchasing : 
     private string _releasecode; 
     [XafDisplayName("Release Code"), ToolTip("Release Code")] 
     // [Appearance("fProceduresPurchasingreleasecode", Enabled = true)]
     // [Appearance("fProceduresPurchasingreleasecodeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string releasecode
     { 
       get { return _releasecode; } 
       set { SetPropertyValue(nameof(releasecode), ref _releasecode, value); } 
     } 
     // Release (Approve) Purchasing Documents
     // Notes for fProceduresPurchasing : 
     private string _releasegrp; 
     [XafDisplayName("Release Group"), ToolTip("Release Group")] 
     // [Appearance("fProceduresPurchasingreleasegrp", Enabled = true)]
     // [Appearance("fProceduresPurchasingreleasegrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string releasegrp
     { 
       get { return _releasegrp; } 
       set { SetPropertyValue(nameof(releasegrp), ref _releasegrp, value); } 
     } 
     // Release (Approve) Purchasing Documents
     // Notes for fProceduresPurchasing : 
     private bool _releaseprereqfulfill; 
     [XafDisplayName("Release Prerequisite Fulfilled"), ToolTip("Release Prerequisite Fulfilled")] 
     // [Appearance("fProceduresPurchasingreleaseprereqfulfill", Enabled = true)]
     // [Appearance("fProceduresPurchasingreleaseprereqfulfillVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool releaseprereqfulfill
     { 
       get { return _releaseprereqfulfill; } 
       set { SetPropertyValue(nameof(releaseprereqfulfill), ref _releaseprereqfulfill, value); } 
     } 
     // Release (Approve) Purchasing Documents
     // Notes for fProceduresPurchasing : 
     private string _scopelist; 
     [XafDisplayName("Scope of List"), ToolTip("Scope of List")] 
     // [Appearance("fProceduresPurchasingscopelist", Enabled = true)]
     // [Appearance("fProceduresPurchasingscopelistVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string scopelist
     { 
       get { return _scopelist; } 
       set { SetPropertyValue(nameof(scopelist), ref _scopelist, value); } 
     } 
     // Release (Approve) Purchasing Documents
     // Notes for fProceduresPurchasing : 
     private bool _setrelease; 
     [XafDisplayName("Set Release"), ToolTip("Set Release")] 
     // [Appearance("fProceduresPurchasingsetrelease", Enabled = true)]
     // [Appearance("fProceduresPurchasingsetreleaseVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool setrelease
     { 
       get { return _setrelease; } 
       set { SetPropertyValue(nameof(setrelease), ref _setrelease, value); } 
     } 
     // Release (Approve) Purchasing Documents
     // Notes for fProceduresPurchasing : 
     private string _supplyplant; 
     [XafDisplayName("Supplying Plant"), ToolTip("Supplying Plant")] 
     // [Appearance("fProceduresPurchasingsupplyplant", Enabled = true)]
     // [Appearance("fProceduresPurchasingsupplyplantVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string supplyplant
     { 
       get { return _supplyplant; } 
       set { SetPropertyValue(nameof(supplyplant), ref _supplyplant, value); } 
     } 
     // Release (Approve) Purchasing Documents
     // Notes for fProceduresPurchasing : 
     private string _to; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fProceduresPurchasingto", Enabled = true)]
     // [Appearance("fProceduresPurchasingtoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string to
     { 
       get { return _to; } 
       set { SetPropertyValue(nameof(to), ref _to, value); } 
     } 
     // Release (Approve) Purchasing Documents
     // Notes for fProceduresPurchasing : 
     private string _to1; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fProceduresPurchasingto1", Enabled = true)]
     // [Appearance("fProceduresPurchasingto1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string to1
     { 
       get { return _to1; } 
       set { SetPropertyValue(nameof(to1), ref _to1, value); } 
     } 
     // Release (Approve) Purchasing Documents
     // Notes for fProceduresPurchasing : 
     private string _to2; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fProceduresPurchasingto2", Enabled = true)]
     // [Appearance("fProceduresPurchasingto2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string to2
     { 
       get { return _to2; } 
       set { SetPropertyValue(nameof(to2), ref _to2, value); } 
     } 
     // Release (Approve) Purchasing Documents
     // Notes for fProceduresPurchasing : 
     private string _to3; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fProceduresPurchasingto3", Enabled = true)]
     // [Appearance("fProceduresPurchasingto3Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string to3
     { 
       get { return _to3; } 
       set { SetPropertyValue(nameof(to3), ref _to3, value); } 
     } 
     // Release (Approve) Purchasing Documents
     // Notes for fProceduresPurchasing : 
     private string _to4; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fProceduresPurchasingto4", Enabled = true)]
     // [Appearance("fProceduresPurchasingto4Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string to4
     { 
       get { return _to4; } 
       set { SetPropertyValue(nameof(to4), ref _to4, value); } 
     } 
     // Release (Approve) Purchasing Documents
     // Notes for fProceduresPurchasing : 
     private string _to5; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fProceduresPurchasingto5", Enabled = true)]
     // [Appearance("fProceduresPurchasingto5Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string to5
     { 
       get { return _to5; } 
       set { SetPropertyValue(nameof(to5), ref _to5, value); } 
     } 
     // Release (Approve) Purchasing Documents
     // Notes for fProceduresPurchasing : 
     private string _to6; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fProceduresPurchasingto6", Enabled = true)]
     // [Appearance("fProceduresPurchasingto6Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string to6
     { 
       get { return _to6; } 
       set { SetPropertyValue(nameof(to6), ref _to6, value); } 
     } 
     // Release (Approve) Purchasing Documents
     // Notes for fProceduresPurchasing : 
     private fVendor _to7; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fProceduresPurchasingto7", Enabled = true)]
     // [Appearance("fProceduresPurchasingto7Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fVendor to7
     { 
       get { return _to7; } 
       set { SetPropertyValue(nameof(to7), ref _to7, value); } 
     } 
     // Release (Approve) Purchasing Documents
     // Notes for fProceduresPurchasing : 
     private string _to8; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fProceduresPurchasingto8", Enabled = true)]
     // [Appearance("fProceduresPurchasingto8Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string to8
     { 
       get { return _to8; } 
       set { SetPropertyValue(nameof(to8), ref _to8, value); } 
     } 
     // Release (Approve) Purchasing Documents
     // Notes for fProceduresPurchasing : 
     private DateTime _to9; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fProceduresPurchasingto9", Enabled = true)]
     // [Appearance("fProceduresPurchasingto9Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime to9
     { 
       get { return _to9; } 
       set { SetPropertyValue(nameof(to9), ref _to9, value); } 
     } 
     // Release (Approve) Purchasing Documents
     // Notes for fProceduresPurchasing : 
     private fVendor _vendor; 
     [XafDisplayName("Vendor"), ToolTip("Vendor")] 
     // [Appearance("fProceduresPurchasingvendor", Enabled = true)]
     // [Appearance("fProceduresPurchasingvendorVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fVendor vendor
     { 
       get { return _vendor; } 
       set { SetPropertyValue(nameof(vendor), ref _vendor, value); } 
     } 
     // Release Codes
     // Notes for fProceduresPurchasing : 
     private string _finalrelease1; 
     [XafDisplayName("Final Release (rs)"), ToolTip("Final Release (rs)")] 
     // [Appearance("fProceduresPurchasingfinalrelease1", Enabled = true)]
     // [Appearance("fProceduresPurchasingfinalrelease1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string finalrelease1
     { 
       get { return _finalrelease1; } 
       set { SetPropertyValue(nameof(finalrelease1), ref _finalrelease1, value); } 
     } 
     // Release Codes
     // Notes for fProceduresPurchasing : 
     private string _releasedate1; 
     [XafDisplayName("Releases to Date"), ToolTip("Releases to Date")] 
     // [Appearance("fProceduresPurchasingreleasedate1", Enabled = true)]
     // [Appearance("fProceduresPurchasingreleasedate1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string releasedate1
     { 
       get { return _releasedate1; } 
       set { SetPropertyValue(nameof(releasedate1), ref _releasedate1, value); } 
     } 
     // Release Codes
     // Notes for fProceduresPurchasing : 
     private string _relpereq1; 
     [XafDisplayName("Rel. Prerequisite (rs)"), ToolTip("Rel. Prerequisite (rs)")] 
     // [Appearance("fProceduresPurchasingrelpereq1", Enabled = true)]
     // [Appearance("fProceduresPurchasingrelpereq1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string relpereq1
     { 
       get { return _relpereq1; } 
       set { SetPropertyValue(nameof(relpereq1), ref _relpereq1, value); } 
     } 
     // Release Strategy Purchase Ord 4500018392
     // Notes for fProceduresPurchasing : 
     private string _releasecode1; 
     [XafDisplayName("Release Code (rs)"), ToolTip("Release Code (rs)")] 
     // [Appearance("fProceduresPurchasingreleasecode1", Enabled = true)]
     // [Appearance("fProceduresPurchasingreleasecode1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string releasecode1
     { 
       get { return _releasecode1; } 
       set { SetPropertyValue(nameof(releasecode1), ref _releasecode1, value); } 
     } 
     // Release Strategy Purchase Ord 4500018392
     // Notes for fProceduresPurchasing : 
     private string _releasegrp1; 
     [XafDisplayName("Release group (rs)"), ToolTip("Release group (rs)")] 
     // [Appearance("fProceduresPurchasingreleasegrp1", Enabled = true)]
     // [Appearance("fProceduresPurchasingreleasegrp1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string releasegrp1
     { 
       get { return _releasegrp1; } 
       set { SetPropertyValue(nameof(releasegrp1), ref _releasegrp1, value); } 
     } 
     // Release Strategy Purchase Ord 4500018392
     // Notes for fProceduresPurchasing : 
     private string _releaseid1; 
     [XafDisplayName("Release ID (rs)"), ToolTip("Release ID (rs)")] 
     // [Appearance("fProceduresPurchasingreleaseid1", Enabled = true)]
     // [Appearance("fProceduresPurchasingreleaseid1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string releaseid1
     { 
       get { return _releaseid1; } 
       set { SetPropertyValue(nameof(releaseid1), ref _releaseid1, value); } 
     } 
     // Release Strategy Purchase Ord 4500018392
     // Notes for fProceduresPurchasing : 
     private string _releasestrtgy1; 
     [XafDisplayName("Release Strategy (rs)"), ToolTip("Release Strategy (rs)")] 
     // [Appearance("fProceduresPurchasingreleasestrtgy1", Enabled = true)]
     // [Appearance("fProceduresPurchasingreleasestrtgy1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string releasestrtgy1
     { 
       get { return _releasestrtgy1; } 
       set { SetPropertyValue(nameof(releasestrtgy1), ref _releasestrtgy1, value); } 
     } 
     // Same classification
     // Notes for fProceduresPurchasing : 
     private bool _chkwitherror; 
     [XafDisplayName("Check with error"), ToolTip("Check with error")] 
     // [Appearance("fProceduresPurchasingchkwitherror", Enabled = true)]
     // [Appearance("fProceduresPurchasingchkwitherrorVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool chkwitherror
     { 
       get { return _chkwitherror; } 
       set { SetPropertyValue(nameof(chkwitherror), ref _chkwitherror, value); } 
     } 
     // Same classification
     // Notes for fProceduresPurchasing : 
     private bool _donotcheck; 
     [XafDisplayName("Do not check"), ToolTip("Do not check")] 
     // [Appearance("fProceduresPurchasingdonotcheck", Enabled = true)]
     // [Appearance("fProceduresPurchasingdonotcheckVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool donotcheck
     { 
       get { return _donotcheck; } 
       set { SetPropertyValue(nameof(donotcheck), ref _donotcheck, value); } 
     } 
     // Same classification
     // Notes for fProceduresPurchasing : 
     private bool _warningmsg; 
     [XafDisplayName("Warning message"), ToolTip("Warning message")] 
     // [Appearance("fProceduresPurchasingwarningmsg", Enabled = true)]
     // [Appearance("fProceduresPurchasingwarningmsgVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool warningmsg
     { 
       get { return _warningmsg; } 
       set { SetPropertyValue(nameof(warningmsg), ref _warningmsg, value); } 
     } 
     // Status
     // Notes for fProceduresPurchasing : 
     private string _delivered; 
     [XafDisplayName("Delivered"), ToolTip("Delivered")] 
     // [Appearance("fProceduresPurchasingdelivered", Enabled = true)]
     // [Appearance("fProceduresPurchasingdeliveredVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string delivered
     { 
       get { return _delivered; } 
       set { SetPropertyValue(nameof(delivered), ref _delivered, value); } 
     } 
     // Status
     // Notes for fProceduresPurchasing : 
     private double _downpaymt; 
     [XafDisplayName("Down paymts"), ToolTip("Down paymts")] 
     // [Appearance("fProceduresPurchasingdownpaymt", Enabled = true)]
     // [Appearance("fProceduresPurchasingdownpaymtVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double downpaymt
     { 
       get { return _downpaymt; } 
       set { SetPropertyValue(nameof(downpaymt), ref _downpaymt, value); } 
     } 
     // Status
     // Notes for fProceduresPurchasing : 
     private string _invoiced; 
     [XafDisplayName("Invoiced"), ToolTip("Invoiced")] 
     // [Appearance("fProceduresPurchasinginvoiced", Enabled = true)]
     // [Appearance("fProceduresPurchasinginvoicedVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string invoiced
     { 
       get { return _invoiced; } 
       set { SetPropertyValue(nameof(invoiced), ref _invoiced, value); } 
     } 
     // Status
     // Notes for fProceduresPurchasing : 
     private string _ordered; 
     [XafDisplayName("Ordered"), ToolTip("Ordered")] 
     // [Appearance("fProceduresPurchasingordered", Enabled = true)]
     // [Appearance("fProceduresPurchasingorderedVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string ordered
     { 
       get { return _ordered; } 
       set { SetPropertyValue(nameof(ordered), ref _ordered, value); } 
     } 
     // Status
     // Notes for fProceduresPurchasing : 
     private double _pal; 
     [XafDisplayName("PAL"), ToolTip("PAL")] 
     // [Appearance("fProceduresPurchasingpal", Enabled = true)]
     // [Appearance("fProceduresPurchasingpalVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double pal
     { 
       get { return _pal; } 
       set { SetPropertyValue(nameof(pal), ref _pal, value); } 
     } 
     // Status
     // Notes for fProceduresPurchasing : 
     private double _pal1; 
     [XafDisplayName("PAL"), ToolTip("PAL")] 
     // [Appearance("fProceduresPurchasingpal1", Enabled = true)]
     // [Appearance("fProceduresPurchasingpal1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double pal1
     { 
       get { return _pal1; } 
       set { SetPropertyValue(nameof(pal1), ref _pal1, value); } 
     } 
     // Status
     // Notes for fProceduresPurchasing : 
     private double _pal2; 
     [XafDisplayName("PAL"), ToolTip("PAL")] 
     // [Appearance("fProceduresPurchasingpal2", Enabled = true)]
     // [Appearance("fProceduresPurchasingpal2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double pal2
     { 
       get { return _pal2; } 
       set { SetPropertyValue(nameof(pal2), ref _pal2, value); } 
     } 
     // Status
     // Notes for fProceduresPurchasing : 
     private double _pal3; 
     [XafDisplayName("PAL"), ToolTip("PAL")] 
     // [Appearance("fProceduresPurchasingpal3", Enabled = true)]
     // [Appearance("fProceduresPurchasingpal3Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double pal3
     { 
       get { return _pal3; } 
       set { SetPropertyValue(nameof(pal3), ref _pal3, value); } 
     } 
     // Status
     // Notes for fProceduresPurchasing : 
     private string _stilltodeliv; 
     [XafDisplayName("Still to deliv."), ToolTip("Still to deliv.")] 
     // [Appearance("fProceduresPurchasingstilltodeliv", Enabled = true)]
     // [Appearance("fProceduresPurchasingstilltodelivVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string stilltodeliv
     { 
       get { return _stilltodeliv; } 
       set { SetPropertyValue(nameof(stilltodeliv), ref _stilltodeliv, value); } 
     } 
     // Values
     // Notes for fProceduresPurchasing : 
     private bool _addnlvalues; 
     [XafDisplayName("Additional Values"), ToolTip("Additional Values")] 
     // [Appearance("fProceduresPurchasingaddnlvalues", Enabled = true)]
     // [Appearance("fProceduresPurchasingaddnlvaluesVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool addnlvalues
     { 
       get { return _addnlvalues; } 
       set { SetPropertyValue(nameof(addnlvalues), ref _addnlvalues, value); } 
     } 
     // Values
     // Notes for fProceduresPurchasing : 
     private bool _c; 
     [XafDisplayName("C"), ToolTip("C")] 
     // [Appearance("fProceduresPurchasingc", Enabled = true)]
     // [Appearance("fProceduresPurchasingcVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool c
     { 
       get { return _c; } 
       set { SetPropertyValue(nameof(c), ref _c, value); } 
     } 
     // Values
     // Notes for fProceduresPurchasing : 
     private double _charvalues; 
     [XafDisplayName("Char. Values"), ToolTip("Char. Values")] 
     // [Appearance("fProceduresPurchasingcharvalues", Enabled = true)]
     // [Appearance("fProceduresPurchasingcharvaluesVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double charvalues
     { 
       get { return _charvalues; } 
       set { SetPropertyValue(nameof(charvalues), ref _charvalues, value); } 
     } 
     // Values
     // Notes for fProceduresPurchasing : 
     private bool _d; 
     [XafDisplayName("D"), ToolTip("D")] 
     // [Appearance("fProceduresPurchasingd", Enabled = true)]
     // [Appearance("fProceduresPurchasingdVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool d
     { 
       get { return _d; } 
       set { SetPropertyValue(nameof(d), ref _d, value); } 
     } 
     // 
     // Notes for fProceduresPurchasing : 
     private string _characteristic; 
     [XafDisplayName("Characteristic"), ToolTip("Characteristic")] 
     // [Appearance("fProceduresPurchasingcharacteristic", Enabled = true)]
     // [Appearance("fProceduresPurchasingcharacteristicVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string characteristic
     { 
       get { return _characteristic; } 
       set { SetPropertyValue(nameof(characteristic), ref _characteristic, value); } 
     } 
     // 
     // Notes for fProceduresPurchasing : 
     private string _chgnumb; 
     [XafDisplayName("Change Number"), ToolTip("Change Number")] 
     // [Appearance("fProceduresPurchasingchgnumb", Enabled = true)]
     // [Appearance("fProceduresPurchasingchgnumbVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string chgnumb
     { 
       get { return _chgnumb; } 
       set { SetPropertyValue(nameof(chgnumb), ref _chgnumb, value); } 
     } 
     // 
     // Notes for fProceduresPurchasing : 
     private DateTime _vldfrom; 
     [XafDisplayName("Valid From"), ToolTip("Valid From")] 
     // [Appearance("fProceduresPurchasingvldfrom", Enabled = true)]
     // [Appearance("fProceduresPurchasingvldfromVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime vldfrom
     { 
       get { return _vldfrom; } 
       set { SetPropertyValue(nameof(vldfrom), ref _vldfrom, value); } 
     } 
   } 
} 
