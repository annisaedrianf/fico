// Class Name : fPostGoods.cs 
// Project Name : FICO 
// Last Update : 14/06/2023 11:28:37  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 14/06/2023 11:28:36 
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
   [System.ComponentModel.DisplayName("Goods Receipt Purchase Order 4500018386")]
   public class fPostGoods : XPObject
   {
     public fPostGoods(Session session) : base(session) 
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
     [Appearance("VisiblefPostGoodsOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // General
     // Notes for fPostGoods : 
     private DateTime _docdate; 
     [XafDisplayName("Document Date"), ToolTip("Document Date")] 
     // [Appearance("fPostGoodsdocdate", Enabled = true)]
     // [Appearance("fPostGoodsdocdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime docdate
     { 
       get { return _docdate; } 
       set { SetPropertyValue(nameof(docdate), ref _docdate, value); } 
     } 
     // 
     // Notes for fPostGoods : 
     private DateTime _postdate; 
     [XafDisplayName("Posting Date"), ToolTip("Posting Date")] 
     // [Appearance("fPostGoodspostdate", Enabled = true)]
     // [Appearance("fPostGoodspostdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime postdate
     { 
       get { return _postdate; } 
       set { SetPropertyValue(nameof(postdate), ref _postdate, value); } 
     } 
     // 
     // Notes for fPostGoods : 
     private string _delivnote; 
     [XafDisplayName("Delivery Note"), ToolTip("Delivery Note")] 
     // [Appearance("fPostGoodsdelivnote", Enabled = true)]
     // [Appearance("fPostGoodsdelivnoteVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string delivnote
     { 
       get { return _delivnote; } 
       set { SetPropertyValue(nameof(delivnote), ref _delivnote, value); } 
     } 
     // 
     // Notes for fPostGoods : 
     private string _billlading; 
     [XafDisplayName("Bill of Lading"), ToolTip("Bill of Lading")] 
     // [Appearance("fPostGoodsbilllading", Enabled = true)]
     // [Appearance("fPostGoodsbillladingVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string billlading
     { 
       get { return _billlading; } 
       set { SetPropertyValue(nameof(billlading), ref _billlading, value); } 
     } 
     // 
     // Notes for fPostGoods : 
     private fVendor _vendor; 
     [XafDisplayName("Vendor"), ToolTip("Vendor")] 
     // [Appearance("fPostGoodsvendor", Enabled = true)]
     // [Appearance("fPostGoodsvendorVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fVendor vendor
     { 
       get { return _vendor; } 
       set { SetPropertyValue(nameof(vendor), ref _vendor, value); } 
     } 
     // 
     // Notes for fPostGoods : 
     private string _headtext; 
     [XafDisplayName("HeaderText"), ToolTip("HeaderText")] 
     // [Appearance("fPostGoodsheadtext", Enabled = true)]
     // [Appearance("fPostGoodsheadtextVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string headtext
     { 
       get { return _headtext; } 
       set { SetPropertyValue(nameof(headtext), ref _headtext, value); } 
     } 
     // 
     // Notes for fPostGoods : 
     private string _line; 
     [XafDisplayName("Line"), ToolTip("Line")] 
     // [Appearance("fPostGoodsline", Enabled = true)]
     // [Appearance("fPostGoodslineVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string line
     { 
       get { return _line; } 
       set { SetPropertyValue(nameof(line), ref _line, value); } 
     } 
     // 
     // Notes for fPostGoods : 
     private string _matshorttext; 
     [XafDisplayName("Mat. Short Text"), ToolTip("Mat. Short Text")] 
     // [Appearance("fPostGoodsmatshorttext", Enabled = true)]
     // [Appearance("fPostGoodsmatshorttextVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string matshorttext
     { 
       get { return _matshorttext; } 
       set { SetPropertyValue(nameof(matshorttext), ref _matshorttext, value); } 
     } 
     // 
     // Notes for fPostGoods : 
     private bool _o; 
     [XafDisplayName("O."), ToolTip("O.")] 
     // [Appearance("fPostGoodso", Enabled = true)]
     // [Appearance("fPostGoodsoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool o
     { 
       get { return _o; } 
       set { SetPropertyValue(nameof(o), ref _o, value); } 
     } 
     // 
     // Notes for fPostGoods : 
     private string _qtyune; 
     [XafDisplayName("Qty in UnE"), ToolTip("Qty in UnE")] 
     // [Appearance("fPostGoodsqtyune", Enabled = true)]
     // [Appearance("fPostGoodsqtyuneVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string qtyune
     { 
       get { return _qtyune; } 
       set { SetPropertyValue(nameof(qtyune), ref _qtyune, value); } 
     } 
     // 
     // Notes for fPostGoods : 
     private string _e; 
     [XafDisplayName("E.."), ToolTip("E..")] 
     // [Appearance("fPostGoodse", Enabled = true)]
     // [Appearance("fPostGoodseVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string e
     { 
       get { return _e; } 
       set { SetPropertyValue(nameof(e), ref _e, value); } 
     } 
     // 
     // Notes for fPostGoods : 
     private string _sloc; 
     [XafDisplayName("Sloc"), ToolTip("Sloc")] 
     // [Appearance("fPostGoodssloc", Enabled = true)]
     // [Appearance("fPostGoodsslocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string sloc
     { 
       get { return _sloc; } 
       set { SetPropertyValue(nameof(sloc), ref _sloc, value); } 
     } 
     // 
     // Notes for fPostGoods : 
     private string _profitcenter; 
     [XafDisplayName("Profit Center"), ToolTip("Profit Center")] 
     // [Appearance("fPostGoodsprofitcenter", Enabled = true)]
     // [Appearance("fPostGoodsprofitcenterVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string profitcenter
     { 
       get { return _profitcenter; } 
       set { SetPropertyValue(nameof(profitcenter), ref _profitcenter, value); } 
     } 
     // 
     // Notes for fPostGoods : 
     private string _batch; 
     [XafDisplayName("Batch"), ToolTip("Batch")] 
     // [Appearance("fPostGoodsbatch", Enabled = true)]
     // [Appearance("fPostGoodsbatchVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string batch
     { 
       get { return _batch; } 
       set { SetPropertyValue(nameof(batch), ref _batch, value); } 
     } 
     // 
     // Notes for fPostGoods : 
     private string _v; 
     [XafDisplayName("Valuation…"), ToolTip("Valuation…")] 
     // [Appearance("fPostGoodsv", Enabled = true)]
     // [Appearance("fPostGoodsvVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string v
     { 
       get { return _v; } 
       set { SetPropertyValue(nameof(v), ref _v, value); } 
     } 
     // 
     // Notes for fPostGoods : 
     private string _m; 
     [XafDisplayName("M."), ToolTip("M.")] 
     // [Appearance("fPostGoodsm", Enabled = true)]
     // [Appearance("fPostGoodsmVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string m
     { 
       get { return _m; } 
       set { SetPropertyValue(nameof(m), ref _m, value); } 
     } 
     // 
     // Notes for fPostGoods : 
     private enumStockType _stocktype; 
     [XafDisplayName("Stock Type"), ToolTip("Stock Type")] 
     // [Appearance("fPostGoodsstocktype", Enabled = true)]
     // [Appearance("fPostGoodsstocktypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumStockType stocktype
     { 
       get { return _stocktype; } 
       set { SetPropertyValue(nameof(stocktype), ref _stocktype, value); } 
     } 
     // 
     // Notes for fPostGoods : 
     private string _plnt; 
     [XafDisplayName("Plnt"), ToolTip("Plnt")] 
     // [Appearance("fPostGoodsplnt", Enabled = true)]
     // [Appearance("fPostGoodsplntVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string plnt
     { 
       get { return _plnt; } 
       set { SetPropertyValue(nameof(plnt), ref _plnt, value); } 
     } 
   } 
} 
