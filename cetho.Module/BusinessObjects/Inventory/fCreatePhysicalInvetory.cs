// Class Name : fCreatePhysicalInvetory.cs 
// Project Name : FICO 
// Last Update : 08/06/2023 13:00:50  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 08/06/2023 13:00:50 
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
   [System.ComponentModel.DisplayName("Create Physical Inventory Document: Initial Screen")]
   public class fCreatePhysicalInvetory : XPObject
   {
     public fCreatePhysicalInvetory(Session session) : base(session) 
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
     [Appearance("VisiblefCreatePhysicalInvetoryOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // Date
     // Notes for fCreatePhysicalInvetory : 
     private DateTime _countdate; 
     [XafDisplayName("Count Date"), ToolTip("Count Date")] 
     // [Appearance("fCreatePhysicalInvetorycountdate", Enabled = true)]
     // [Appearance("fCreatePhysicalInvetorycountdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime countdate
     { 
       get { return _countdate; } 
       set { SetPropertyValue(nameof(countdate), ref _countdate, value); } 
     } 
     // Date and status
     // Notes for fCreatePhysicalInvetory : 
     private string _adjstatus; 
     [XafDisplayName("Adjustment Status"), ToolTip("Adjustment status")] 
     // [Appearance("fCreatePhysicalInvetoryadjstatus", Enabled = true)]
     // [Appearance("fCreatePhysicalInvetoryadjstatusVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string adjstatus
     { 
       get { return _adjstatus; } 
       set { SetPropertyValue(nameof(adjstatus), ref _adjstatus, value); } 
     } 
     // Date and status
     // Notes for fCreatePhysicalInvetory : 
     private DateTime _countdate1; 
     [XafDisplayName("Count Date "), ToolTip("Count date ")] 
     // [Appearance("fCreatePhysicalInvetorycountdate1", Enabled = true)]
     // [Appearance("fCreatePhysicalInvetorycountdate1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime countdate1
     { 
       get { return _countdate1; } 
       set { SetPropertyValue(nameof(countdate1), ref _countdate1, value); } 
     } 
     // Date and status
     // Notes for fCreatePhysicalInvetory : 
     private string _countstatus; 
     [XafDisplayName("Count Status"), ToolTip("Count status")] 
     // [Appearance("fCreatePhysicalInvetorycountstatus", Enabled = true)]
     // [Appearance("fCreatePhysicalInvetorycountstatusVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string countstatus
     { 
       get { return _countstatus; } 
       set { SetPropertyValue(nameof(countstatus), ref _countstatus, value); } 
     } 
     // Date and status
     // Notes for fCreatePhysicalInvetory : 
     private string _createdby; 
     [XafDisplayName("Created by"), ToolTip("Created by")] 
     // [Appearance("fCreatePhysicalInvetorycreatedby", Enabled = true)]
     // [Appearance("fCreatePhysicalInvetorycreatedbyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string createdby
     { 
       get { return _createdby; } 
       set { SetPropertyValue(nameof(createdby), ref _createdby, value); } 
     } 
     // Date and status
     // Notes for fCreatePhysicalInvetory : 
     private string _delstatus; 
     [XafDisplayName("Delete Status"), ToolTip("Delete Status")] 
     // [Appearance("fCreatePhysicalInvetorydelstatus", Enabled = true)]
     // [Appearance("fCreatePhysicalInvetorydelstatusVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string delstatus
     { 
       get { return _delstatus; } 
       set { SetPropertyValue(nameof(delstatus), ref _delstatus, value); } 
     } 
     // Date and status
     // Notes for fCreatePhysicalInvetory : 
     private DateTime _docdate1; 
     [XafDisplayName("Document Date "), ToolTip("Document date ")] 
     // [Appearance("fCreatePhysicalInvetorydocdate1", Enabled = true)]
     // [Appearance("fCreatePhysicalInvetorydocdate1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime docdate1
     { 
       get { return _docdate1; } 
       set { SetPropertyValue(nameof(docdate1), ref _docdate1, value); } 
     } 
     // Date and status
     // Notes for fCreatePhysicalInvetory : 
     private DateTime _planncountdate1; 
     [XafDisplayName("Planned Count Date "), ToolTip("Planned count date ")] 
     // [Appearance("fCreatePhysicalInvetoryplanncountdate1", Enabled = true)]
     // [Appearance("fCreatePhysicalInvetoryplanncountdate1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime planncountdate1
     { 
       get { return _planncountdate1; } 
       set { SetPropertyValue(nameof(planncountdate1), ref _planncountdate1, value); } 
     } 
     // Date and status
     // Notes for fCreatePhysicalInvetory : 
     private DateTime _postdate; 
     [XafDisplayName("Posting Date"), ToolTip("Posting Date")] 
     // [Appearance("fCreatePhysicalInvetorypostdate", Enabled = true)]
     // [Appearance("fCreatePhysicalInvetorypostdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime postdate
     { 
       get { return _postdate; } 
       set { SetPropertyValue(nameof(postdate), ref _postdate, value); } 
     } 
     // Date and status
     // Notes for fCreatePhysicalInvetory : 
     private string _postperiod; 
     [XafDisplayName("Posting Period"), ToolTip("Posting period")] 
     // [Appearance("fCreatePhysicalInvetorypostperiod", Enabled = true)]
     // [Appearance("fCreatePhysicalInvetorypostperiodVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string postperiod
     { 
       get { return _postperiod; } 
       set { SetPropertyValue(nameof(postperiod), ref _postperiod, value); } 
     } 
     // Display Physical Inventory History
     // Notes for fCreatePhysicalInvetory : 
     private string _mat1; 
     [XafDisplayName("Material "), ToolTip("Material ")] 
     // [Appearance("fCreatePhysicalInvetorymat1", Enabled = true)]
     // [Appearance("fCreatePhysicalInvetorymat1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string mat1
     { 
       get { return _mat1; } 
       set { SetPropertyValue(nameof(mat1), ref _mat1, value); } 
     } 
     // Enter Inventory Count: Initial Screen
     // Notes for fCreatePhysicalInvetory : 
     private string _physinventdoc; 
     [XafDisplayName("Phys. Inventory Doc."), ToolTip("Phys. Inventory Doc.")] 
     // [Appearance("fCreatePhysicalInvetoryphysinventdoc", Enabled = true)]
     // [Appearance("fCreatePhysicalInvetoryphysinventdocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string physinventdoc
     { 
       get { return _physinventdoc; } 
       set { SetPropertyValue(nameof(physinventdoc), ref _physinventdoc, value); } 
     } 
     // Items
     // Notes for fCreatePhysicalInvetory : 
     private bool _aun; 
     [XafDisplayName("Aun"), ToolTip("Aun")] 
     // [Appearance("fCreatePhysicalInvetoryaun", Enabled = true)]
     // [Appearance("fCreatePhysicalInvetoryaunVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool aun
     { 
       get { return _aun; } 
       set { SetPropertyValue(nameof(aun), ref _aun, value); } 
     } 
     // Items
     // Notes for fCreatePhysicalInvetory : 
     private string _batch; 
     [XafDisplayName("Batch"), ToolTip("Batch")] 
     // [Appearance("fCreatePhysicalInvetorybatch", Enabled = true)]
     // [Appearance("fCreatePhysicalInvetorybatchVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string batch
     { 
       get { return _batch; } 
       set { SetPropertyValue(nameof(batch), ref _batch, value); } 
     } 
     // Items
     // Notes for fCreatePhysicalInvetory : 
     private bool _del; 
     [XafDisplayName("Del"), ToolTip("Del")] 
     // [Appearance("fCreatePhysicalInvetorydel", Enabled = true)]
     // [Appearance("fCreatePhysicalInvetorydelVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool del
     { 
       get { return _del; } 
       set { SetPropertyValue(nameof(del), ref _del, value); } 
     } 
     // Items
     // Notes for fCreatePhysicalInvetory : 
     private string _itm; 
     [XafDisplayName("Item"), ToolTip("Itm")] 
     // [Appearance("fCreatePhysicalInvetoryitm", Enabled = true)]
     // [Appearance("fCreatePhysicalInvetoryitmVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string itm
     { 
       get { return _itm; } 
       set { SetPropertyValue(nameof(itm), ref _itm, value); } 
     } 
     // Items
     // Notes for fCreatePhysicalInvetory : 
     private string _mat; 
     [XafDisplayName("Material"), ToolTip("Material")] 
     // [Appearance("fCreatePhysicalInvetorymat", Enabled = true)]
     // [Appearance("fCreatePhysicalInvetorymatVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string mat
     { 
       get { return _mat; } 
       set { SetPropertyValue(nameof(mat), ref _mat, value); } 
     } 
     // Items
     // Notes for fCreatePhysicalInvetory : 
     private string _matdesc; 
     [XafDisplayName("Material Description"), ToolTip("Material Description")] 
     // [Appearance("fCreatePhysicalInvetorymatdesc", Enabled = true)]
     // [Appearance("fCreatePhysicalInvetorymatdescVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string matdesc
     { 
       get { return _matdesc; } 
       set { SetPropertyValue(nameof(matdesc), ref _matdesc, value); } 
     } 
     // Items
     // Notes for fCreatePhysicalInvetory : 
     private string _sty; 
     [XafDisplayName("Sty"), ToolTip("Sty")] 
     // [Appearance("fCreatePhysicalInvetorysty", Enabled = true)]
     // [Appearance("fCreatePhysicalInvetorystyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string sty
     { 
       get { return _sty; } 
       set { SetPropertyValue(nameof(sty), ref _sty, value); } 
     } 
     // Loc.of phys.inv.
     // Notes for fCreatePhysicalInvetory : 
     private string _spclstck; 
     [XafDisplayName("Special Stock"), ToolTip("Special Stock")] 
     // [Appearance("fCreatePhysicalInvetoryspclstck", Enabled = true)]
     // [Appearance("fCreatePhysicalInvetoryspclstckVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string spclstck
     { 
       get { return _spclstck; } 
       set { SetPropertyValue(nameof(spclstck), ref _spclstck, value); } 
     } 
     // Location of phys.inv.
     // Notes for fCreatePhysicalInvetory : 
     private string _plant; 
     [XafDisplayName("Plant"), ToolTip("Plant")] 
     // [Appearance("fCreatePhysicalInvetoryplant", Enabled = true)]
     // [Appearance("fCreatePhysicalInvetoryplantVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string plant
     { 
       get { return _plant; } 
       set { SetPropertyValue(nameof(plant), ref _plant, value); } 
     } 
     // Location of phys.inv.
     // Notes for fCreatePhysicalInvetory : 
     private string _stcktype; 
     [XafDisplayName("Stock Type"), ToolTip("Stock type")] 
     // [Appearance("fCreatePhysicalInvetorystcktype", Enabled = true)]
     // [Appearance("fCreatePhysicalInvetorystcktypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string stcktype
     { 
       get { return _stcktype; } 
       set { SetPropertyValue(nameof(stcktype), ref _stcktype, value); } 
     } 
     // Location of phys.inv.
     // Notes for fCreatePhysicalInvetory : 
     private string _storloc; 
     [XafDisplayName("Stor. Location"), ToolTip("Stor. Location")] 
     // [Appearance("fCreatePhysicalInvetorystorloc", Enabled = true)]
     // [Appearance("fCreatePhysicalInvetorystorlocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string storloc
     { 
       get { return _storloc; } 
       set { SetPropertyValue(nameof(storloc), ref _storloc, value); } 
     } 
     // Other fields
     // Notes for fCreatePhysicalInvetory : 
     private bool _freezebookinvent1; 
     [XafDisplayName("Freeze Book Inventory"), ToolTip("Freeze book inventory ")] 
     // [Appearance("fCreatePhysicalInvetoryfreezebookinvent1", Enabled = true)]
     // [Appearance("fCreatePhysicalInvetoryfreezebookinvent1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool freezebookinvent1
     { 
       get { return _freezebookinvent1; } 
       set { SetPropertyValue(nameof(freezebookinvent1), ref _freezebookinvent1, value); } 
     } 
     // Other fields
     // Notes for fCreatePhysicalInvetory : 
     private string _grpcriterion; 
     [XafDisplayName("Grouping Criterion"), ToolTip("Grouping criterion")] 
     // [Appearance("fCreatePhysicalInvetorygrpcriterion", Enabled = true)]
     // [Appearance("fCreatePhysicalInvetorygrpcriterionVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string grpcriterion
     { 
       get { return _grpcriterion; } 
       set { SetPropertyValue(nameof(grpcriterion), ref _grpcriterion, value); } 
     } 
     // Other fields
     // Notes for fCreatePhysicalInvetory : 
     private string _grptype1; 
     [XafDisplayName("Grouping Type"), ToolTip("Grouping type ")] 
     // [Appearance("fCreatePhysicalInvetorygrptype1", Enabled = true)]
     // [Appearance("fCreatePhysicalInvetorygrptype1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string grptype1
     { 
       get { return _grptype1; } 
       set { SetPropertyValue(nameof(grptype1), ref _grptype1, value); } 
     } 
     // Other fields
     // Notes for fCreatePhysicalInvetory : 
     private string _physinventnumb; 
     [XafDisplayName("Phys. Inventory Number"), ToolTip("Phys. Inventory number")] 
     // [Appearance("fCreatePhysicalInvetoryphysinventnumb", Enabled = true)]
     // [Appearance("fCreatePhysicalInvetoryphysinventnumbVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string physinventnumb
     { 
       get { return _physinventnumb; } 
       set { SetPropertyValue(nameof(physinventnumb), ref _physinventnumb, value); } 
     } 
     // Other fields
     // Notes for fCreatePhysicalInvetory : 
     private string _physinventref1; 
     [XafDisplayName("Phys. Inventory Ref."), ToolTip("Phys. Inventory ref. ")] 
     // [Appearance("fCreatePhysicalInvetoryphysinventref1", Enabled = true)]
     // [Appearance("fCreatePhysicalInvetoryphysinventref1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string physinventref1
     { 
       get { return _physinventref1; } 
       set { SetPropertyValue(nameof(physinventref1), ref _physinventref1, value); } 
     } 
     // Other fields
     // Notes for fCreatePhysicalInvetory : 
     private bool _postblock1; 
     [XafDisplayName("Posting Block   "), ToolTip("Posting Block ")] 
     // [Appearance("fCreatePhysicalInvetorypostblock1", Enabled = true)]
     // [Appearance("fCreatePhysicalInvetorypostblock1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool postblock1
     { 
       get { return _postblock1; } 
       set { SetPropertyValue(nameof(postblock1), ref _postblock1, value); } 
     } 
     // Other fields
     // Notes for fCreatePhysicalInvetory : 
     private string _transtype; 
     [XafDisplayName("Trans./Event Type"), ToolTip("Trans./Event Type")] 
     // [Appearance("fCreatePhysicalInvetorytranstype", Enabled = true)]
     // [Appearance("fCreatePhysicalInvetorytranstypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string transtype
     { 
       get { return _transtype; } 
       set { SetPropertyValue(nameof(transtype), ref _transtype, value); } 
     } 
     // Other Information
     // Notes for fCreatePhysicalInvetory : 
     private bool _batchdelflag; 
     [XafDisplayName("Batches w. Del. Flag"), ToolTip("Batches w. del. Flag")] 
     // [Appearance("fCreatePhysicalInvetorybatchdelflag", Enabled = true)]
     // [Appearance("fCreatePhysicalInvetorybatchdelflagVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool batchdelflag
     { 
       get { return _batchdelflag; } 
       set { SetPropertyValue(nameof(batchdelflag), ref _batchdelflag, value); } 
     } 
     // Other Information
     // Notes for fCreatePhysicalInvetory : 
     private bool _freezebookinvent; 
     [XafDisplayName("Freeze Book Inventory"), ToolTip("Freeze book inventory")] 
     // [Appearance("fCreatePhysicalInvetoryfreezebookinvent", Enabled = true)]
     // [Appearance("fCreatePhysicalInvetoryfreezebookinventVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool freezebookinvent
     { 
       get { return _freezebookinvent; } 
       set { SetPropertyValue(nameof(freezebookinvent), ref _freezebookinvent, value); } 
     } 
     // Other Information
     // Notes for fCreatePhysicalInvetory : 
     private string _grptype; 
     [XafDisplayName("Grouping Type"), ToolTip("Grouping type")] 
     // [Appearance("fCreatePhysicalInvetorygrptype", Enabled = true)]
     // [Appearance("fCreatePhysicalInvetorygrptypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string grptype
     { 
       get { return _grptype; } 
       set { SetPropertyValue(nameof(grptype), ref _grptype, value); } 
     } 
     // Other Information
     // Notes for fCreatePhysicalInvetory : 
     private string _physinventno; 
     [XafDisplayName("Phys. Inventory No."), ToolTip("Phys. Inventory no.")] 
     // [Appearance("fCreatePhysicalInvetoryphysinventno", Enabled = true)]
     // [Appearance("fCreatePhysicalInvetoryphysinventnoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string physinventno
     { 
       get { return _physinventno; } 
       set { SetPropertyValue(nameof(physinventno), ref _physinventno, value); } 
     } 
     // Other Information
     // Notes for fCreatePhysicalInvetory : 
     private string _physinventref; 
     [XafDisplayName("Phys. Inventory Ref."), ToolTip("Phys. Inventory Ref.")] 
     // [Appearance("fCreatePhysicalInvetoryphysinventref", Enabled = true)]
     // [Appearance("fCreatePhysicalInvetoryphysinventrefVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string physinventref
     { 
       get { return _physinventref; } 
       set { SetPropertyValue(nameof(physinventref), ref _physinventref, value); } 
     } 
     // Other Information
     // Notes for fCreatePhysicalInvetory : 
     private bool _postblock; 
     [XafDisplayName("Posting Block"), ToolTip("Posting Block")] 
     // [Appearance("fCreatePhysicalInvetorypostblock", Enabled = true)]
     // [Appearance("fCreatePhysicalInvetorypostblockVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool postblock
     { 
       get { return _postblock; } 
       set { SetPropertyValue(nameof(postblock), ref _postblock, value); } 
     } 
     // Other Information
     // Notes for fCreatePhysicalInvetory : 
     private string _varicance; 
     [XafDisplayName("Variance in %"), ToolTip("Variance in %")] 
     // [Appearance("fCreatePhysicalInvetoryvaricance", Enabled = true)]
     // [Appearance("fCreatePhysicalInvetoryvaricanceVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string varicance
     { 
       get { return _varicance; } 
       set { SetPropertyValue(nameof(varicance), ref _varicance, value); } 
     } 
     // Promotions
     // Notes for fCreatePhysicalInvetory : 
     private string _physinvstatus; 
     [XafDisplayName("Phys. Inv. Status"), ToolTip("Phys.inv.status")] 
     // [Appearance("fCreatePhysicalInvetoryphysinvstatus", Enabled = true)]
     // [Appearance("fCreatePhysicalInvetoryphysinvstatusVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string physinvstatus
     { 
       get { return _physinvstatus; } 
       set { SetPropertyValue(nameof(physinvstatus), ref _physinvstatus, value); } 
     } 
     // 
     // Notes for fCreatePhysicalInvetory : 
     private DateTime _docdate; 
     [XafDisplayName("Document Date"), ToolTip("Document date")] 
     // [Appearance("fCreatePhysicalInvetorydocdate", Enabled = true)]
     // [Appearance("fCreatePhysicalInvetorydocdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime docdate
     { 
       get { return _docdate; } 
       set { SetPropertyValue(nameof(docdate), ref _docdate, value); } 
     } 
     // 
     // Notes for fCreatePhysicalInvetory : 
     private string _fiscalyr; 
     [XafDisplayName("Fiscal Year"), ToolTip("Fiscal Year")] 
     // [Appearance("fCreatePhysicalInvetoryfiscalyr", Enabled = true)]
     // [Appearance("fCreatePhysicalInvetoryfiscalyrVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string fiscalyr
     { 
       get { return _fiscalyr; } 
       set { SetPropertyValue(nameof(fiscalyr), ref _fiscalyr, value); } 
     } 
     // 
     // Notes for fCreatePhysicalInvetory : 
     private DateTime _planncountdate; 
     [XafDisplayName("Planned Count Date"), ToolTip("Planned count date")] 
     // [Appearance("fCreatePhysicalInvetoryplanncountdate", Enabled = true)]
     // [Appearance("fCreatePhysicalInvetoryplanncountdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime planncountdate
     { 
       get { return _planncountdate; } 
       set { SetPropertyValue(nameof(planncountdate), ref _planncountdate, value); } 
     } 
   } 
} 
