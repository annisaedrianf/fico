// Class Name : fReservationOfInventory.cs 
// Project Name : FICO 
// Last Update : 14/06/2023 10:17:31  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 14/06/2023 10:17:24 
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
   [System.ComponentModel.DisplayName("Create Reservation: Initial Screen")]
   public class fReservationOfInventory : XPObject
   {
     public fReservationOfInventory(Session session) : base(session) 
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
     [Appearance("VisiblefReservationOfInventoryOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // Cancel Material Document: Initial Screen
     // Notes for fReservationOfInventory : 
     private string _matdoc; 
     [XafDisplayName("Material Doc."), ToolTip("Material Doc.")] 
     // [Appearance("fReservationOfInventorymatdoc", Enabled = true)]
     // [Appearance("fReservationOfInventorymatdocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string matdoc
     { 
       get { return _matdoc; } 
       set { SetPropertyValue(nameof(matdoc), ref _matdoc, value); } 
     } 
     // Cancel Material Document: Initial Screen
     // Notes for fReservationOfInventory : 
     private string _matdocyear; 
     [XafDisplayName("Mat. Doc. Year"), ToolTip("Mat. Doc. Year")] 
     // [Appearance("fReservationOfInventorymatdocyear", Enabled = true)]
     // [Appearance("fReservationOfInventorymatdocyearVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string matdocyear
     { 
       get { return _matdocyear; } 
       set { SetPropertyValue(nameof(matdocyear), ref _matdocyear, value); } 
     } 
     // Cancel Material Document: Initial Screen
     // Notes for fReservationOfInventory : 
     private DateTime _postdate; 
     [XafDisplayName("Posting Date"), ToolTip("Posting Date")] 
     // [Appearance("fReservationOfInventorypostdate", Enabled = true)]
     // [Appearance("fReservationOfInventorypostdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime postdate
     { 
       get { return _postdate; } 
       set { SetPropertyValue(nameof(postdate), ref _postdate, value); } 
     } 
     // Create Reservation: New Items
     // Notes for fReservationOfInventory : 
     private string _batch; 
     [XafDisplayName("Batch"), ToolTip("Batch")] 
     // [Appearance("fReservationOfInventorybatch", Enabled = true)]
     // [Appearance("fReservationOfInventorybatchVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string batch
     { 
       get { return _batch; } 
       set { SetPropertyValue(nameof(batch), ref _batch, value); } 
     } 
     // Create Reservation: New Items
     // Notes for fReservationOfInventory : 
     //private fCostCenter _costctr; 
     //[XafDisplayName("Cost Center"), ToolTip("Cost Center")] 
     // [Appearance("fReservationOfInventorycostctr", Enabled = true)]
     // [Appearance("fReservationOfInventorycostctrVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     //public  fCostCenter costctr
     //{ 
     //  get { return _costctr; } 
     //  set { SetPropertyValue(nameof(costctr), ref _costctr, value); } 
     //} 
     // Create Reservation: New Items
     // Notes for fReservationOfInventory : 
     private fGLAcct _glacct; 
     [XafDisplayName("G/L Account"), ToolTip("G/L Account")] 
     // [Appearance("fReservationOfInventoryglacct", Enabled = true)]
     // [Appearance("fReservationOfInventoryglacctVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fGLAcct glacct
     { 
       get { return _glacct; } 
       set { SetPropertyValue(nameof(glacct), ref _glacct, value); } 
     } 
     // Create Reservation: New Items
     // Notes for fReservationOfInventory : 
     private string _goodsrecipt; 
     [XafDisplayName("Goods recipient"), ToolTip("Goods recipient")] 
     // [Appearance("fReservationOfInventorygoodsrecipt", Enabled = true)]
     // [Appearance("fReservationOfInventorygoodsreciptVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string goodsrecipt
     { 
       get { return _goodsrecipt; } 
       set { SetPropertyValue(nameof(goodsrecipt), ref _goodsrecipt, value); } 
     } 
     // Create Reservation: New Items
     // Notes for fReservationOfInventory : 
     private string _itm; 
     [XafDisplayName("Itm"), ToolTip("Itm")] 
     // [Appearance("fReservationOfInventoryitm", Enabled = true)]
     // [Appearance("fReservationOfInventoryitmVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string itm
     { 
       get { return _itm; } 
       set { SetPropertyValue(nameof(itm), ref _itm, value); } 
     } 
     // Create Reservation: New Items
     // Notes for fReservationOfInventory : 
     private string _material; 
     [XafDisplayName("Material"), ToolTip("Material")] 
     // [Appearance("fReservationOfInventorymaterial", Enabled = true)]
     // [Appearance("fReservationOfInventorymaterialVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string material
     { 
       get { return _material; } 
       set { SetPropertyValue(nameof(material), ref _material, value); } 
     } 
     // Create Reservation: New Items
     // Notes for fReservationOfInventory : 
     private string _movetype2; 
     [XafDisplayName("Movement Type"), ToolTip("Movement Type")] 
     // [Appearance("fReservationOfInventorymovetype2", Enabled = true)]
     // [Appearance("fReservationOfInventorymovetype2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string movetype2
     { 
       get { return _movetype2; } 
       set { SetPropertyValue(nameof(movetype2), ref _movetype2, value); } 
     } 
     // Create Reservation: New Items
     // Notes for fReservationOfInventory : 
     private string _plnt; 
     [XafDisplayName("Plnt"), ToolTip("Plnt")] 
     // [Appearance("fReservationOfInventoryplnt", Enabled = true)]
     // [Appearance("fReservationOfInventoryplntVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string plnt
     { 
       get { return _plnt; } 
       set { SetPropertyValue(nameof(plnt), ref _plnt, value); } 
     } 
     // Create Reservation: New Items
     // Notes for fReservationOfInventory : 
     private string _qtyune; 
     [XafDisplayName("Quantity in UnE"), ToolTip("Quantity in UnE")] 
     // [Appearance("fReservationOfInventoryqtyune", Enabled = true)]
     // [Appearance("fReservationOfInventoryqtyuneVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string qtyune
     { 
       get { return _qtyune; } 
       set { SetPropertyValue(nameof(qtyune), ref _qtyune, value); } 
     } 
     // Create Reservation: New Items
     // Notes for fReservationOfInventory : 
     private string _sloc; 
     [XafDisplayName("Sloc"), ToolTip("Sloc")] 
     // [Appearance("fReservationOfInventorysloc", Enabled = true)]
     // [Appearance("fReservationOfInventoryslocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string sloc
     { 
       get { return _sloc; } 
       set { SetPropertyValue(nameof(sloc), ref _sloc, value); } 
     } 
     // Defaults for Document Items
     // Notes for fReservationOfInventory : 
     private string _movetype1; 
     [XafDisplayName("Movement Type"), ToolTip("Movement Type (Doc)")] 
     // [Appearance("fReservationOfInventorymovetype1", Enabled = true)]
     // [Appearance("fReservationOfInventorymovetype1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string movetype1
     { 
       get { return _movetype1; } 
       set { SetPropertyValue(nameof(movetype1), ref _movetype1, value); } 
     } 
     // Defaults for Document Items
     // Notes for fReservationOfInventory : 
     private string _plant2; 
     [XafDisplayName("Plant"), ToolTip("Plant (Doc)")] 
     // [Appearance("fReservationOfInventoryplant2", Enabled = true)]
     // [Appearance("fReservationOfInventoryplant2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string plant2
     { 
       get { return _plant2; } 
       set { SetPropertyValue(nameof(plant2), ref _plant2, value); } 
     } 
     // Defaults for Document Items
     // Notes for fReservationOfInventory : 
     private string _reasonformove; 
     [XafDisplayName("Reason for Movement"), ToolTip("Reason for Movement")] 
     // [Appearance("fReservationOfInventoryreasonformove", Enabled = true)]
     // [Appearance("fReservationOfInventoryreasonformoveVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fReservationOfInventory : 
     private string _specialstock; 
     [XafDisplayName("Special Stock"), ToolTip("Special Stock")] 
     // [Appearance("fReservationOfInventoryspecialstock", Enabled = true)]
     // [Appearance("fReservationOfInventoryspecialstockVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string specialstock
     { 
       get { return _specialstock; } 
       set { SetPropertyValue(nameof(specialstock), ref _specialstock, value); } 
     } 
     // Defaults for Document Items
     // Notes for fReservationOfInventory : 
     private string _storloc; 
     [XafDisplayName("Storage Location"), ToolTip("Storage Location")] 
     // [Appearance("fReservationOfInventorystorloc", Enabled = true)]
     // [Appearance("fReservationOfInventorystorlocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string storloc
     { 
       get { return _storloc; } 
       set { SetPropertyValue(nameof(storloc), ref _storloc, value); } 
     } 
     // Defaults for Document Items
     // Notes for fReservationOfInventory : 
     private bool _suggzerolines; 
     [XafDisplayName("Suggest Zero Lines"), ToolTip("Suggest Zero Lines")] 
     // [Appearance("fReservationOfInventorysuggzerolines", Enabled = true)]
     // [Appearance("fReservationOfInventorysuggzerolinesVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool suggzerolines
     { 
       get { return _suggzerolines; } 
       set { SetPropertyValue(nameof(suggzerolines), ref _suggzerolines, value); } 
     } 
     // Enter Goods Issue: Initial Screen
     // Notes for fReservationOfInventory : 
     private DateTime _docdate; 
     [XafDisplayName("Document Date"), ToolTip("Document Date")] 
     // [Appearance("fReservationOfInventorydocdate", Enabled = true)]
     // [Appearance("fReservationOfInventorydocdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime docdate
     { 
       get { return _docdate; } 
       set { SetPropertyValue(nameof(docdate), ref _docdate, value); } 
     } 
     // Enter Goods Issue: Initial Screen
     // Notes for fReservationOfInventory : 
     private string _docheadtext; 
     [XafDisplayName("Doc. Header Text"), ToolTip("Doc. Header Text")] 
     // [Appearance("fReservationOfInventorydocheadtext", Enabled = true)]
     // [Appearance("fReservationOfInventorydocheadtextVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string docheadtext
     { 
       get { return _docheadtext; } 
       set { SetPropertyValue(nameof(docheadtext), ref _docheadtext, value); } 
     } 
     // Enter Goods Issue: Initial Screen
     // Notes for fReservationOfInventory : 
     private string _matslip; 
     [XafDisplayName("Material Slip"), ToolTip("Material Slip")] 
     // [Appearance("fReservationOfInventorymatslip", Enabled = true)]
     // [Appearance("fReservationOfInventorymatslipVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string matslip
     { 
       get { return _matslip; } 
       set { SetPropertyValue(nameof(matslip), ref _matslip, value); } 
     } 
     // Enter Goods Issue: Initial Screen
     // Notes for fReservationOfInventory : 
     private DateTime _postdate1; 
     [XafDisplayName("Posting Date"), ToolTip("Posting Date (Iss)")] 
     // [Appearance("fReservationOfInventorypostdate1", Enabled = true)]
     // [Appearance("fReservationOfInventorypostdate1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime postdate1
     { 
       get { return _postdate1; } 
       set { SetPropertyValue(nameof(postdate1), ref _postdate1, value); } 
     } 
     // Find reservation
     // Notes for fReservationOfInventory : 
     private string _asset; 
     [XafDisplayName("Asset"), ToolTip("Asset")] 
     // [Appearance("fReservationOfInventoryasset", Enabled = true)]
     // [Appearance("fReservationOfInventoryassetVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(40)] 
     public  string asset
     { 
       get { return _asset; } 
       set { SetPropertyValue(nameof(asset), ref _asset, value); } 
     } 
     // Find reservation
     // Notes for fReservationOfInventory : 
     private string _costctr1; 
     [XafDisplayName("Cost Center"), ToolTip("Cost Center (Rsv)")] 
     // [Appearance("fReservationOfInventorycostctr1", Enabled = true)]
     // [Appearance("fReservationOfInventorycostctr1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string costctr1
     { 
       get { return _costctr1; } 
       set { SetPropertyValue(nameof(costctr1), ref _costctr1, value); } 
     } 
     // Find reservation
     // Notes for fReservationOfInventory : 
     private string _material1; 
     [XafDisplayName("Material"), ToolTip("Material (Rsv)")] 
     // [Appearance("fReservationOfInventorymaterial1", Enabled = true)]
     // [Appearance("fReservationOfInventorymaterial1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string material1
     { 
       get { return _material1; } 
       set { SetPropertyValue(nameof(material1), ref _material1, value); } 
     } 
     // Find reservation
     // Notes for fReservationOfInventory : 
     private string _network; 
     [XafDisplayName("Network"), ToolTip("Network")] 
     // [Appearance("fReservationOfInventorynetwork", Enabled = true)]
     // [Appearance("fReservationOfInventorynetworkVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(40)] 
     public  string network
     { 
       get { return _network; } 
       set { SetPropertyValue(nameof(network), ref _network, value); } 
     } 
     // Find reservation
     // Notes for fReservationOfInventory : 
     private string _order; 
     [XafDisplayName("Order"), ToolTip("Order")] 
     // [Appearance("fReservationOfInventoryorder", Enabled = true)]
     // [Appearance("fReservationOfInventoryorderVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(25)] 
     public  string order
     { 
       get { return _order; } 
       set { SetPropertyValue(nameof(order), ref _order, value); } 
     } 
     // Find reservation
     // Notes for fReservationOfInventory : 
     private string _plant1; 
     [XafDisplayName("Plant"), ToolTip("Plant (Rsv)")] 
     // [Appearance("fReservationOfInventoryplant1", Enabled = true)]
     // [Appearance("fReservationOfInventoryplant1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string plant1
     { 
       get { return _plant1; } 
       set { SetPropertyValue(nameof(plant1), ref _plant1, value); } 
     } 
     // Find reservation
     // Notes for fReservationOfInventory : 
     private bool _qwacctassgt; 
     [XafDisplayName("W/o acct.assgt"), ToolTip("W/o acct.assgt")] 
     // [Appearance("fReservationOfInventoryqwacctassgt", Enabled = true)]
     // [Appearance("fReservationOfInventoryqwacctassgtVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool qwacctassgt
     { 
       get { return _qwacctassgt; } 
       set { SetPropertyValue(nameof(qwacctassgt), ref _qwacctassgt, value); } 
     } 
     // Find reservation
     // Notes for fReservationOfInventory : 
     private string _receivplant; 
     [XafDisplayName("Receiving Plant"), ToolTip("Receiving Plant")] 
     // [Appearance("fReservationOfInventoryreceivplant", Enabled = true)]
     // [Appearance("fReservationOfInventoryreceivplantVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string receivplant
     { 
       get { return _receivplant; } 
       set { SetPropertyValue(nameof(receivplant), ref _receivplant, value); } 
     } 
     // Find reservation
     // Notes for fReservationOfInventory : 
     private string _receivsloc; 
     [XafDisplayName("Receiving Sloc."), ToolTip("Receiving Sloc.")] 
     // [Appearance("fReservationOfInventoryreceivsloc", Enabled = true)]
     // [Appearance("fReservationOfInventoryreceivslocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string receivsloc
     { 
       get { return _receivsloc; } 
       set { SetPropertyValue(nameof(receivsloc), ref _receivsloc, value); } 
     } 
     // Find reservation
     // Notes for fReservationOfInventory : 
     private string _reqmtdate; 
     [XafDisplayName("Reqmt Date"), ToolTip("Reqmt Date")] 
     // [Appearance("fReservationOfInventoryreqmtdate", Enabled = true)]
     // [Appearance("fReservationOfInventoryreqmtdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string reqmtdate
     { 
       get { return _reqmtdate; } 
       set { SetPropertyValue(nameof(reqmtdate), ref _reqmtdate, value); } 
     } 
     // Find reservation
     // Notes for fReservationOfInventory : 
     private string _salesordr; 
     [XafDisplayName("Sales Order"), ToolTip("Sales Order")] 
     // [Appearance("fReservationOfInventorysalesordr", Enabled = true)]
     // [Appearance("fReservationOfInventorysalesordrVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string salesordr
     { 
       get { return _salesordr; } 
       set { SetPropertyValue(nameof(salesordr), ref _salesordr, value); } 
     } 
     // Find reservation
     // Notes for fReservationOfInventory : 
     private string _wbselement; 
     [XafDisplayName("WBS Element"), ToolTip("WBS Element")] 
     // [Appearance("fReservationOfInventorywbselement", Enabled = true)]
     // [Appearance("fReservationOfInventorywbselementVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string wbselement
     { 
       get { return _wbselement; } 
       set { SetPropertyValue(nameof(wbselement), ref _wbselement, value); } 
     } 
     // Reference
     // Notes for fReservationOfInventory : 
     private string _reserv; 
     [XafDisplayName("Reservation"), ToolTip("Reservation")] 
     // [Appearance("fReservationOfInventoryreserv", Enabled = true)]
     // [Appearance("fReservationOfInventoryreservVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string reserv
     { 
       get { return _reserv; } 
       set { SetPropertyValue(nameof(reserv), ref _reserv, value); } 
     } 
     // Reference: Reservation
     // Notes for fReservationOfInventory : 
     private bool _extendsel; 
     [XafDisplayName("Extended sel."), ToolTip("Extended sel.")] 
     // [Appearance("fReservationOfInventoryextendsel", Enabled = true)]
     // [Appearance("fReservationOfInventoryextendselVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool extendsel
     { 
       get { return _extendsel; } 
       set { SetPropertyValue(nameof(extendsel), ref _extendsel, value); } 
     } 
     // Reference: Reservation
     // Notes for fReservationOfInventory : 
     private string _reserv1; 
     [XafDisplayName("Reservation"), ToolTip("Reservation (Ref)")] 
     // [Appearance("fReservationOfInventoryreserv1", Enabled = true)]
     // [Appearance("fReservationOfInventoryreserv1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string reserv1
     { 
       get { return _reserv1; } 
       set { SetPropertyValue(nameof(reserv1), ref _reserv1, value); } 
     } 
     // Reference: Reservation
     // Notes for fReservationOfInventory : 
     private string _sloc1; 
     [XafDisplayName("Sloc"), ToolTip("Sloc (Ref)")] 
     // [Appearance("fReservationOfInventorysloc1", Enabled = true)]
     // [Appearance("fReservationOfInventorysloc1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string sloc1
     { 
       get { return _sloc1; } 
       set { SetPropertyValue(nameof(sloc1), ref _sloc1, value); } 
     } 
     // 
     // Notes for fReservationOfInventory : 
     private DateTime _basedate; 
     [XafDisplayName("Base Date"), ToolTip("Base Date")] 
     // [Appearance("fReservationOfInventorybasedate", Enabled = true)]
     // [Appearance("fReservationOfInventorybasedateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime basedate
     { 
       get { return _basedate; } 
       set { SetPropertyValue(nameof(basedate), ref _basedate, value); } 
     } 
     // 
     // Notes for fReservationOfInventory : 
     private bool _chckagainst; 
     [XafDisplayName("Check against cal."), ToolTip("Check against cal.")] 
     // [Appearance("fReservationOfInventorychckagainst", Enabled = true)]
     // [Appearance("fReservationOfInventorychckagainstVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool chckagainst
     { 
       get { return _chckagainst; } 
       set { SetPropertyValue(nameof(chckagainst), ref _chckagainst, value); } 
     } 
     // 
     // Notes for fReservationOfInventory : 
     private string _movetype; 
     [XafDisplayName("Movement Type"), ToolTip("Movement Type")] 
     // [Appearance("fReservationOfInventorymovetype", Enabled = true)]
     // [Appearance("fReservationOfInventorymovetypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string movetype
     { 
       get { return _movetype; } 
       set { SetPropertyValue(nameof(movetype), ref _movetype, value); } 
     } 
     // 
     // Notes for fReservationOfInventory : 
     private string _plant; 
     [XafDisplayName("Plant"), ToolTip("Plant")] 
     // [Appearance("fReservationOfInventoryplant", Enabled = true)]
     // [Appearance("fReservationOfInventoryplantVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string plant
     { 
       get { return _plant; } 
       set { SetPropertyValue(nameof(plant), ref _plant, value); } 
     } 
   } 
} 
