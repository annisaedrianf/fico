// Class Name : fOverviewMaterialStock.cs 
// Project Name : FICO 
// Last Update : 06/06/2023 13:52:41  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 06/06/2023 13:52:41 
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
   [System.ComponentModel.DisplayName("Stock Overview: Company Code/Plant/Storage Location/Batch")]
   public class fOverviewMaterialStock : XPObject
   {
     public fOverviewMaterialStock(Session session) : base(session) 
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
     [Appearance("VisiblefOverviewMaterialStockOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // Database selections
     // Notes for fOverviewMaterialStock : 
     private string _mat1; 
     [XafDisplayName("Material "), ToolTip("Material")] 
     // [Appearance("fOverviewMaterialStockmat", Enabled = true)]
     // [Appearance("fOverviewMaterialStockmatVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string mat1
     { 
       get { return _mat1; } 
       set { SetPropertyValue(nameof(mat1), ref _mat1, value); } 
     } 
     // Database selections
     // Notes for fOverviewMaterialStock : 
     private string _batch1; 
     [XafDisplayName("Batch "), ToolTip("Batch ")] 
     // [Appearance("fOverviewMaterialStockbatch1", Enabled = true)]
     // [Appearance("fOverviewMaterialStockbatch1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string batch1
     { 
       get { return _batch1; } 
       set { SetPropertyValue(nameof(batch1), ref _batch1, value); } 
     } 
     // Database selections
     // Notes for fOverviewMaterialStock : 
     private string _plant; 
     [XafDisplayName("Plant "), ToolTip("Plant ")] 
     // [Appearance("fOverviewMaterialStockplant", Enabled = true)]
     // [Appearance("fOverviewMaterialStockplantVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string plant
     { 
       get { return _plant; } 
       set { SetPropertyValue(nameof(plant), ref _plant, value); } 
     } 
     // Database selections
     // Notes for fOverviewMaterialStock : 
     private string _storloc1; 
     [XafDisplayName("Storage Location "), ToolTip("Storage Location ")] 
     // [Appearance("fOverviewMaterialStockstorloc1", Enabled = true)]
     // [Appearance("fOverviewMaterialStockstorloc1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string storloc1
     { 
       get { return _storloc1; } 
       set { SetPropertyValue(nameof(storloc1), ref _storloc1, value); } 
     } 
     // Database selections
     // Notes for fOverviewMaterialStock : 
     private string _to1; 
     [XafDisplayName("to "), ToolTip("to")] 
     // [Appearance("fOverviewMaterialStockto", Enabled = true)]
     // [Appearance("fOverviewMaterialStocktoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string to1
     { 
       get { return _to1; } 
       set { SetPropertyValue(nameof(to1), ref _to1, value); } 
     } 
     // List Display
     // Notes for fOverviewMaterialStock : 
     private bool _decplcasunit; 
     [XafDisplayName("Decimal Place as /Unit"), ToolTip("Decimal Place as per Unit")] 
     // [Appearance("fOverviewMaterialStockdecplcasunit", Enabled = true)]
     // [Appearance("fOverviewMaterialStockdecplcasunitVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool decplcasunit
     { 
       get { return _decplcasunit; } 
       set { SetPropertyValue(nameof(decplcasunit), ref _decplcasunit, value); } 
     } 
     // List Display
     // Notes for fOverviewMaterialStock : 
     private string _dsplyuom; 
     [XafDisplayName("Display Unit of Measure"), ToolTip("Display Unit of Measure")] 
     // [Appearance("fOverviewMaterialStockdsplyuom", Enabled = true)]
     // [Appearance("fOverviewMaterialStockdsplyuomVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string dsplyuom
     { 
       get { return _dsplyuom; } 
       set { SetPropertyValue(nameof(dsplyuom), ref _dsplyuom, value); } 
     } 
     // List Display
     // Notes for fOverviewMaterialStock : 
     private string _dsplyvers; 
     [XafDisplayName("Display Version"), ToolTip("Display version")] 
     // [Appearance("fOverviewMaterialStockdsplyvers", Enabled = true)]
     // [Appearance("fOverviewMaterialStockdsplyversVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string dsplyvers
     { 
       get { return _dsplyvers; } 
       set { SetPropertyValue(nameof(dsplyvers), ref _dsplyvers, value); } 
     } 
     // List Display
     // Notes for fOverviewMaterialStock : 
     private bool _nozerostcklines; 
     [XafDisplayName("No Zero Stock Lines"), ToolTip("No Zero Stock Lines")] 
     // [Appearance("fOverviewMaterialStocknozerostcklines", Enabled = true)]
     // [Appearance("fOverviewMaterialStocknozerostcklinesVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool nozerostcklines
     { 
       get { return _nozerostcklines; } 
       set { SetPropertyValue(nameof(nozerostcklines), ref _nozerostcklines, value); } 
     } 
     // List Display
     // Notes for fOverviewMaterialStock : 
     private string _spclstockindic; 
     [XafDisplayName("Special Stock Indicator"), ToolTip("Special Stock Indicator")] 
     // [Appearance("fOverviewMaterialStockspclstockindic", Enabled = true)]
     // [Appearance("fOverviewMaterialStockspclstockindicVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string spclstockindic
     { 
       get { return _spclstockindic; } 
       set { SetPropertyValue(nameof(spclstockindic), ref _spclstockindic, value); } 
     } 
     // List Display
     // Notes for fOverviewMaterialStock : 
     private string _to; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fOverviewMaterialStockto", Enabled = true)]
     // [Appearance("fOverviewMaterialStocktoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string to
     { 
       get { return _to; } 
       set { SetPropertyValue(nameof(to), ref _to, value); } 
     } 
     // Selection
     // Notes for fOverviewMaterialStock : 
     private string _mat; 
     [XafDisplayName("Material"), ToolTip("Material")] 
     // [Appearance("fOverviewMaterialStockmat", Enabled = true)]
     // [Appearance("fOverviewMaterialStockmatVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string mat
     { 
       get { return _mat; } 
       set { SetPropertyValue(nameof(mat), ref _mat, value); } 
     } 
     // Selection
     // Notes for fOverviewMaterialStock : 
     private string _mattype; 
     [XafDisplayName("Material Type"), ToolTip("Material Type")] 
     // [Appearance("fOverviewMaterialStockmattype", Enabled = true)]
     // [Appearance("fOverviewMaterialStockmattypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string mattype
     { 
       get { return _mattype; } 
       set { SetPropertyValue(nameof(mattype), ref _mattype, value); } 
     } 
     // Selection
     // Notes for fOverviewMaterialStock : 
     private string _uom; 
     [XafDisplayName("Unit of Measure"), ToolTip("Unit of Measure")] 
     // [Appearance("fOverviewMaterialStockuom", Enabled = true)]
     // [Appearance("fOverviewMaterialStockuomVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string uom
     { 
       get { return _uom; } 
       set { SetPropertyValue(nameof(uom), ref _uom, value); } 
     } 
     // Selection of Display Levels
     // Notes for fOverviewMaterialStock : 
     private bool _batch; 
     [XafDisplayName("Batch "), ToolTip("Batch ")] 
     // [Appearance("fOverviewMaterialStockbatch", Enabled = true)]
     // [Appearance("fOverviewMaterialStockbatchVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool batch
     { 
       get { return _batch; } 
       set { SetPropertyValue(nameof(batch), ref _batch, value); } 
     } 
     // Selection of Display Levels
     // Notes for fOverviewMaterialStock : 
     private bool _compcode; 
     [XafDisplayName("Company Code"), ToolTip("Company Code")] 
     // [Appearance("fOverviewMaterialStockcompcode", Enabled = true)]
     // [Appearance("fOverviewMaterialStockcompcodeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool compcode
     { 
       get { return _compcode; } 
       set { SetPropertyValue(nameof(compcode), ref _compcode, value); } 
     } 
     // Selection of Display Levels
     // Notes for fOverviewMaterialStock : 
     private bool _plnt; 
     [XafDisplayName("Plant"), ToolTip("Plant")] 
     // [Appearance("fOverviewMaterialStockplnt", Enabled = true)]
     // [Appearance("fOverviewMaterialStockplntVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool plnt
     { 
       get { return _plnt; } 
       set { SetPropertyValue(nameof(plnt), ref _plnt, value); } 
     } 
     // Selection of Display Levels
     // Notes for fOverviewMaterialStock : 
     private bool _spclstock; 
     [XafDisplayName("Special Stock"), ToolTip("Special Stock")] 
     // [Appearance("fOverviewMaterialStockspclstock", Enabled = true)]
     // [Appearance("fOverviewMaterialStockspclstockVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool spclstock
     { 
       get { return _spclstock; } 
       set { SetPropertyValue(nameof(spclstock), ref _spclstock, value); } 
     } 
     // Selection of Display Levels
     // Notes for fOverviewMaterialStock : 
     private bool _storloc; 
     [XafDisplayName("Storage Location"), ToolTip("Storage Location")] 
     // [Appearance("fOverviewMaterialStockstorloc", Enabled = true)]
     // [Appearance("fOverviewMaterialStockstorlocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool storloc
     { 
       get { return _storloc; } 
       set { SetPropertyValue(nameof(storloc), ref _storloc, value); } 
     } 
     // Stock Type Selections
     // Notes for fOverviewMaterialStock : 
     private bool _slctspclstock; 
     [XafDisplayName("Also Select Special Stocks"), ToolTip("Also Select Special Stocks")] 
     // [Appearance("fOverviewMaterialStockslctspclstock", Enabled = true)]
     // [Appearance("fOverviewMaterialStockslctspclstockVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool slctspclstock
     { 
       get { return _slctspclstock; } 
       set { SetPropertyValue(nameof(slctspclstock), ref _slctspclstock, value); } 
     } 
     // Stock Type Selections
     // Notes for fOverviewMaterialStock : 
     private bool _slctstockcommit; 
     [XafDisplayName("Also Select Stock Commitments"), ToolTip("Also Select Stock Commitments")] 
     // [Appearance("fOverviewMaterialStockslctstockcommit", Enabled = true)]
     // [Appearance("fOverviewMaterialStockslctstockcommitVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool slctstockcommit
     { 
       get { return _slctstockcommit; } 
       set { SetPropertyValue(nameof(slctstockcommit), ref _slctstockcommit, value); } 
     } 
   } 
} 
