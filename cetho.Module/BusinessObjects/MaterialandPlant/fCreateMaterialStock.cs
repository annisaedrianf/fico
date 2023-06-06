// Class Name : fCreateMaterialStock.cs 
// Project Name : FICO 
// Last Update : 06/06/2023 13:49:26  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 06/06/2023 13:49:26 
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
   [System.ComponentModel.DisplayName("Enter Other Goods Receipts: Initial Screen")]
   public class fCreateMaterialStock : XPObject
   {
     public fCreateMaterialStock(Session session) : base(session) 
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
     [Appearance("VisiblefCreateMaterialStockOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // Defaults for Document Items
     // Notes for fCreateMaterialStock : 
     private string _movetype; 
     [XafDisplayName("Movement Type"), ToolTip("Movement Type")] 
     // [Appearance("fCreateMaterialStockmovetype", Enabled = true)]
     // [Appearance("fCreateMaterialStockmovetypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string movetype
     { 
       get { return _movetype; } 
       set { SetPropertyValue(nameof(movetype), ref _movetype, value); } 
     } 
     // Defaults for Document Items
     // Notes for fCreateMaterialStock : 
     private string _plant; 
     [XafDisplayName("Plant"), ToolTip("Plant")] 
     // [Appearance("fCreateMaterialStockplant", Enabled = true)]
     // [Appearance("fCreateMaterialStockplantVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string plant
     { 
       get { return _plant; } 
       set { SetPropertyValue(nameof(plant), ref _plant, value); } 
     } 
     // Defaults for Document Items
     // Notes for fCreateMaterialStock : 
     private string _reasonformove; 
     [XafDisplayName("Reason for Movement"), ToolTip("Reason for Movement")] 
     // [Appearance("fCreateMaterialStockreasonformove", Enabled = true)]
     // [Appearance("fCreateMaterialStockreasonformoveVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string reasonformove
     { 
       get { return _reasonformove; } 
       set { SetPropertyValue(nameof(reasonformove), ref _reasonformove, value); } 
     } 
     // Defaults for Document Items
     // Notes for fCreateMaterialStock : 
     private string _spclstock; 
     [XafDisplayName("Special Stock"), ToolTip("Special Stock")] 
     // [Appearance("fCreateMaterialStockspclstock", Enabled = true)]
     // [Appearance("fCreateMaterialStockspclstockVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string spclstock
     { 
       get { return _spclstock; } 
       set { SetPropertyValue(nameof(spclstock), ref _spclstock, value); } 
     } 
     // Defaults for Document Items
     // Notes for fCreateMaterialStock : 
     private string _storloc; 
     [XafDisplayName("Storage Location"), ToolTip("Storage Location")] 
     // [Appearance("fCreateMaterialStockstorloc", Enabled = true)]
     // [Appearance("fCreateMaterialStockstorlocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string storloc
     { 
       get { return _storloc; } 
       set { SetPropertyValue(nameof(storloc), ref _storloc, value); } 
     } 
     // Defaults for Document Items
     // Notes for fCreateMaterialStock : 
     private bool _suggzeroline; 
     [XafDisplayName("Suggest Zero Lines"), ToolTip("Suggest Zero Lines")] 
     // [Appearance("fCreateMaterialStocksuggzeroline", Enabled = true)]
     // [Appearance("fCreateMaterialStocksuggzerolineVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool suggzeroline
     { 
       get { return _suggzeroline; } 
       set { SetPropertyValue(nameof(suggzeroline), ref _suggzeroline, value); } 
     } 
     // GR/GI Slip
     // Notes for fCreateMaterialStock : 
     private bool _collectslip; 
     [XafDisplayName("Collective Slip"), ToolTip("Collective Slip")] 
     // [Appearance("fCreateMaterialStockcollectslip", Enabled = true)]
     // [Appearance("fCreateMaterialStockcollectslipVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool collectslip
     { 
       get { return _collectslip; } 
       set { SetPropertyValue(nameof(collectslip), ref _collectslip, value); } 
     } 
     // GR/GI Slip
     // Notes for fCreateMaterialStock : 
     private bool _indivslip; 
     [XafDisplayName("Individual Slip"), ToolTip("Individual Slip")] 
     // [Appearance("fCreateMaterialStockindivslip", Enabled = true)]
     // [Appearance("fCreateMaterialStockindivslipVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool indivslip
     { 
       get { return _indivslip; } 
       set { SetPropertyValue(nameof(indivslip), ref _indivslip, value); } 
     } 
     // GR/GI Slip
     // Notes for fCreateMaterialStock : 
     private bool _indivslipinspecttext; 
     [XafDisplayName("Indiv. Slip with Inspect.Text"), ToolTip("Indiv.Slip w.Inspect.Text")] 
     // [Appearance("fCreateMaterialStockindivslipinspecttext", Enabled = true)]
     // [Appearance("fCreateMaterialStockindivslipinspecttextVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool indivslipinspecttext
     { 
       get { return _indivslipinspecttext; } 
       set { SetPropertyValue(nameof(indivslipinspecttext), ref _indivslipinspecttext, value); } 
     } 
     // GR/GI Slip
     // Notes for fCreateMaterialStock : 
     private bool _print; 
     [XafDisplayName("Print"), ToolTip("Print")] 
     // [Appearance("fCreateMaterialStockprint", Enabled = true)]
     // [Appearance("fCreateMaterialStockprintVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool print
     { 
       get { return _print; } 
       set { SetPropertyValue(nameof(print), ref _print, value); } 
     } 
     // Items
     // Notes for fCreateMaterialStock : 
     private string _batch; 
     [XafDisplayName("Batch"), ToolTip("Batch")] 
     // [Appearance("fCreateMaterialStockbatch", Enabled = true)]
     // [Appearance("fCreateMaterialStockbatchVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateMaterialStock : 
     private string _item; 
     [XafDisplayName("Item"), ToolTip("Item")] 
     // [Appearance("fCreateMaterialStockitem", Enabled = true)]
     // [Appearance("fCreateMaterialStockitemVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string item
     { 
       get { return _item; } 
       set { SetPropertyValue(nameof(item), ref _item, value); } 
     } 
     // Items
     // Notes for fCreateMaterialStock : 
     private string _mat; 
     [XafDisplayName("Material"), ToolTip("Material")] 
     // [Appearance("fCreateMaterialStockmat", Enabled = true)]
     // [Appearance("fCreateMaterialStockmatVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateMaterialStock : 
     private string _plnt; 
     [XafDisplayName("Plnt"), ToolTip("Plnt")] 
     // [Appearance("fCreateMaterialStockplnt", Enabled = true)]
     // [Appearance("fCreateMaterialStockplntVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string plnt
     { 
       get { return _plnt; } 
       set { SetPropertyValue(nameof(plnt), ref _plnt, value); } 
     } 
     // Items
     // Notes for fCreateMaterialStock : 
     private string _qty; 
     [XafDisplayName("Quantity"), ToolTip("Quantity")] 
     // [Appearance("fCreateMaterialStockqty", Enabled = true)]
     // [Appearance("fCreateMaterialStockqtyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string qty
     { 
       get { return _qty; } 
       set { SetPropertyValue(nameof(qty), ref _qty, value); } 
     } 
     // Items
     // Notes for fCreateMaterialStock : 
     private string _sloc; 
     [XafDisplayName("Sloc"), ToolTip("Sloc")] 
     // [Appearance("fCreateMaterialStocksloc", Enabled = true)]
     // [Appearance("fCreateMaterialStockslocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string sloc
     { 
       get { return _sloc; } 
       set { SetPropertyValue(nameof(sloc), ref _sloc, value); } 
     } 
     // Items
     // Notes for fCreateMaterialStock : 
     private string _une; 
     [XafDisplayName("UnE"), ToolTip("UnE")] 
     // [Appearance("fCreateMaterialStockune", Enabled = true)]
     // [Appearance("fCreateMaterialStockuneVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string une
     { 
       get { return _une; } 
       set { SetPropertyValue(nameof(une), ref _une, value); } 
     } 
     // 
     // Notes for fCreateMaterialStock : 
     private DateTime _docdate; 
     [XafDisplayName("Document Date"), ToolTip("Document Date")] 
     // [Appearance("fCreateMaterialStockdocdate", Enabled = true)]
     // [Appearance("fCreateMaterialStockdocdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime docdate
     { 
       get { return _docdate; } 
       set { SetPropertyValue(nameof(docdate), ref _docdate, value); } 
     } 
     // 
     // Notes for fCreateMaterialStock : 
     private string _docheadertext; 
     [XafDisplayName("Doc. Header Text"), ToolTip("Doc.Header Text")] 
     // [Appearance("fCreateMaterialStockdocheadertext", Enabled = true)]
     // [Appearance("fCreateMaterialStockdocheadertextVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string docheadertext
     { 
       get { return _docheadertext; } 
       set { SetPropertyValue(nameof(docheadertext), ref _docheadertext, value); } 
     } 
     // 
     // Notes for fCreateMaterialStock : 
     private string _grslipno; 
     [XafDisplayName("GR/GI Slip No."), ToolTip("GR/GI Slip No.")] 
     // [Appearance("fCreateMaterialStockgrslipno", Enabled = true)]
     // [Appearance("fCreateMaterialStockgrslipnoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string grslipno
     { 
       get { return _grslipno; } 
       set { SetPropertyValue(nameof(grslipno), ref _grslipno, value); } 
     } 
     // 
     // Notes for fCreateMaterialStock : 
     private string _matslip; 
     [XafDisplayName("Material Slip"), ToolTip("Material Slip")] 
     // [Appearance("fCreateMaterialStockmatslip", Enabled = true)]
     // [Appearance("fCreateMaterialStockmatslipVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string matslip
     { 
       get { return _matslip; } 
       set { SetPropertyValue(nameof(matslip), ref _matslip, value); } 
     } 
     // 
     // Notes for fCreateMaterialStock : 
     private DateTime _postdate; 
     [XafDisplayName("Posting Date"), ToolTip("Posting Date")] 
     // [Appearance("fCreateMaterialStockpostdate", Enabled = true)]
     // [Appearance("fCreateMaterialStockpostdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime postdate
     { 
       get { return _postdate; } 
       set { SetPropertyValue(nameof(postdate), ref _postdate, value); } 
     } 
   } 
} 
