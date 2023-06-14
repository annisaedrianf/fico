// Class Name : fIssueGoods.cs 
// Project Name : FICO 
// Last Update : 08/06/2023 12:53:35  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 08/06/2023 12:53:35 
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
   [System.ComponentModel.DisplayName("Post Goods Issue")]
   public class fIssueGoods : XPObject
   {
     public fIssueGoods(Session session) : base(session) 
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
     [Appearance("VisiblefIssueGoodsOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // Picking
     // Notes for fIssueGoods : 
     private string _batch; 
     [XafDisplayName("Batch"), ToolTip("Batch")] 
     // [Appearance("fIssueGoodsbatch", Enabled = true)]
     // [Appearance("fIssueGoodsbatchVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string batch
     { 
       get { return _batch; } 
       set { SetPropertyValue(nameof(batch), ref _batch, value); } 
     } 
     // Picking
     // Notes for fIssueGoods : 
     private string _delivqty; 
     [XafDisplayName("Deliv. Qty"), ToolTip("Deliv. Qty")] 
     // [Appearance("fIssueGoodsdelivqty", Enabled = true)]
     // [Appearance("fIssueGoodsdelivqtyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string delivqty
     { 
       get { return _delivqty; } 
       set { SetPropertyValue(nameof(delivqty), ref _delivqty, value); } 
     } 
     // Picking
     // Notes for fIssueGoods : 
     private string _itms; 
     [XafDisplayName("Item"), ToolTip("Item")] 
     // [Appearance("fIssueGoodsitms", Enabled = true)]
     // [Appearance("fIssueGoodsitmsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string itms
     { 
       get { return _itms; } 
       set { SetPropertyValue(nameof(itms), ref _itms, value); } 
     } 
     // Picking
     // Notes for fIssueGoods : 
     private string _material; 
     [XafDisplayName("Material"), ToolTip("Material")] 
     // [Appearance("fIssueGoodsmaterial", Enabled = true)]
     // [Appearance("fIssueGoodsmaterialVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string material
     { 
       get { return _material; } 
       set { SetPropertyValue(nameof(material), ref _material, value); } 
     } 
     // Picking
     // Notes for fIssueGoods : 
     private string _ovrllpickstts; 
     [XafDisplayName("Ovrll Pick Status"), ToolTip("OvrllPickStatus")] 
     // [Appearance("fIssueGoodsovrllpickstts", Enabled = true)]
     // [Appearance("fIssueGoodsovrllpicksttsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string ovrllpickstts
     { 
       get { return _ovrllpickstts; } 
       set { SetPropertyValue(nameof(ovrllpickstts), ref _ovrllpickstts, value); } 
     } 
     // Picking
     // Notes for fIssueGoods : 
     private string _ovrllwmstts; 
     [XafDisplayName("Overall WM Status"), ToolTip("OverallWMStatus")] 
     // [Appearance("fIssueGoodsovrllwmstts", Enabled = true)]
     // [Appearance("fIssueGoodsovrllwmsttsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string ovrllwmstts
     { 
       get { return _ovrllwmstts; } 
       set { SetPropertyValue(nameof(ovrllwmstts), ref _ovrllwmstts, value); } 
     } 
     // Picking
     // Notes for fIssueGoods : 
     private DateTime _pickdate; 
     [XafDisplayName("Pick Date/Time"), ToolTip("Pick Date/Time")] 
     // [Appearance("fIssueGoodspickdate", Enabled = true)]
     // [Appearance("fIssueGoodspickdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime pickdate
     { 
       get { return _pickdate; } 
       set { SetPropertyValue(nameof(pickdate), ref _pickdate, value); } 
     } 
     // Picking
     // Notes for fIssueGoods : 
     private string _pickqty; 
     [XafDisplayName("Picked Qty"), ToolTip("Picked Qty")] 
     // [Appearance("fIssueGoodspickqty", Enabled = true)]
     // [Appearance("fIssueGoodspickqtyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string pickqty
     { 
       get { return _pickqty; } 
       set { SetPropertyValue(nameof(pickqty), ref _pickqty, value); } 
     } 
     // Picking
     // Notes for fIssueGoods : 
     private string _plant; 
     [XafDisplayName("Plant"), ToolTip("Plant")] 
     // [Appearance("fIssueGoodsplant", Enabled = true)]
     // [Appearance("fIssueGoodsplantVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string plant
     { 
       get { return _plant; } 
       set { SetPropertyValue(nameof(plant), ref _plant, value); } 
     } 
     // Picking
     // Notes for fIssueGoods : 
     private string _storloc; 
     [XafDisplayName("Storage Location"), ToolTip("Storage Location")] 
     // [Appearance("fIssueGoodsstorloc", Enabled = true)]
     // [Appearance("fIssueGoodsstorlocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string storloc
     { 
       get { return _storloc; } 
       set { SetPropertyValue(nameof(storloc), ref _storloc, value); } 
     } 
     // Picking
     // Notes for fIssueGoods : 
     private string _warehouseno; 
     [XafDisplayName("Warehouse No."), ToolTip("Warehouse No.")] 
     // [Appearance("fIssueGoodswarehouseno", Enabled = true)]
     // [Appearance("fIssueGoodswarehousenoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string warehouseno
     { 
       get { return _warehouseno; } 
       set { SetPropertyValue(nameof(warehouseno), ref _warehouseno, value); } 
     } 
     // Reverse Good Movement
     // Notes for fIssueGoods : 
     private string _goodsmovedate; 
     [XafDisplayName("Goods Movement Date"), ToolTip("Goods Movement Date")] 
     // [Appearance("fIssueGoodsgoodsmovedate", Enabled = true)]
     // [Appearance("fIssueGoodsgoodsmovedateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string goodsmovedate
     { 
       get { return _goodsmovedate; } 
       set { SetPropertyValue(nameof(goodsmovedate), ref _goodsmovedate, value); } 
     } 
     // Reverse Good Movement
     // Notes for fIssueGoods : 
     private string _grpdeliv; 
     [XafDisplayName("Group of Deliveries"), ToolTip("Group of Deliveries")] 
     // [Appearance("fIssueGoodsgrpdeliv", Enabled = true)]
     // [Appearance("fIssueGoodsgrpdelivVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string grpdeliv
     { 
       get { return _grpdeliv; } 
       set { SetPropertyValue(nameof(grpdeliv), ref _grpdeliv, value); } 
     } 
     // Reverse Good Movement
     // Notes for fIssueGoods : 
     private bool _inbounddeliv; 
     [XafDisplayName("Inbound Dlvs"), ToolTip("Inbound Dlvs")] 
     // [Appearance("fIssueGoodsinbounddeliv", Enabled = true)]
     // [Appearance("fIssueGoodsinbounddelivVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool inbounddeliv
     { 
       get { return _inbounddeliv; } 
       set { SetPropertyValue(nameof(inbounddeliv), ref _inbounddeliv, value); } 
     } 
     // Reverse Good Movement
     // Notes for fIssueGoods : 
     private string _inoutbounddeliv; 
     [XafDisplayName("Inbound/Outbound Delivery"), ToolTip("Inbound/Outbound Delivery")] 
     // [Appearance("fIssueGoodsinoutbounddeliv", Enabled = true)]
     // [Appearance("fIssueGoodsinoutbounddelivVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string inoutbounddeliv
     { 
       get { return _inoutbounddeliv; } 
       set { SetPropertyValue(nameof(inoutbounddeliv), ref _inoutbounddeliv, value); } 
     } 
     // Reverse Good Movement
     // Notes for fIssueGoods : 
     private bool _inoutbounddeliv1; 
     [XafDisplayName("Inbound Delivs & Outbounf Delivs"), ToolTip("Inbound Delivs & Outbounf Delivs")] 
     // [Appearance("fIssueGoodsinoutbounddeliv1", Enabled = true)]
     // [Appearance("fIssueGoodsinoutbounddeliv1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool inoutbounddeliv1
     { 
       get { return _inoutbounddeliv1; } 
       set { SetPropertyValue(nameof(inoutbounddeliv1), ref _inoutbounddeliv1, value); } 
     } 
     // Reverse Good Movement
     // Notes for fIssueGoods : 
     private bool _outbounddely; 
     [XafDisplayName("Outbound Dely"), ToolTip("Outbound Dely")] 
     // [Appearance("fIssueGoodsoutbounddely", Enabled = true)]
     // [Appearance("fIssueGoodsoutbounddelyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool outbounddely
     { 
       get { return _outbounddely; } 
       set { SetPropertyValue(nameof(outbounddely), ref _outbounddely, value); } 
     } 
     // Reverse Good Movement
     // Notes for fIssueGoods : 
     private string _route; 
     [XafDisplayName("Route"), ToolTip("Route")] 
     // [Appearance("fIssueGoodsroute", Enabled = true)]
     // [Appearance("fIssueGoodsrouteVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string route
     { 
       get { return _route; } 
       set { SetPropertyValue(nameof(route), ref _route, value); } 
     } 
     // Reverse Good Movement
     // Notes for fIssueGoods : 
     private string _shipnumb; 
     [XafDisplayName("Shipment Number"), ToolTip("Shipment Number")] 
     // [Appearance("fIssueGoodsshipnumb", Enabled = true)]
     // [Appearance("fIssueGoodsshipnumbVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string shipnumb
     { 
       get { return _shipnumb; } 
       set { SetPropertyValue(nameof(shipnumb), ref _shipnumb, value); } 
     } 
     // Reverse Good Movement
     // Notes for fIssueGoods : 
     private string _shippoint; 
     [XafDisplayName("Shipping Point"), ToolTip("Shipping Point")] 
     // [Appearance("fIssueGoodsshippoint", Enabled = true)]
     // [Appearance("fIssueGoodsshippointVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string shippoint
     { 
       get { return _shippoint; } 
       set { SetPropertyValue(nameof(shippoint), ref _shippoint, value); } 
     } 
     // Reverse Good Movement
     // Notes for fIssueGoods : 
     private string _to; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fIssueGoodsto", Enabled = true)]
     // [Appearance("fIssueGoodstoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string to
     { 
       get { return _to; } 
       set { SetPropertyValue(nameof(to), ref _to, value); } 
     } 
     // Reverse Good Movement
     // Notes for fIssueGoods : 
     private string _to1; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fIssueGoodsto1", Enabled = true)]
     // [Appearance("fIssueGoodsto1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string to1
     { 
       get { return _to1; } 
       set { SetPropertyValue(nameof(to1), ref _to1, value); } 
     } 
     // Reverse Good Movement
     // Notes for fIssueGoods : 
     private string _to2; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fIssueGoodsto2", Enabled = true)]
     // [Appearance("fIssueGoodsto2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string to2
     { 
       get { return _to2; } 
       set { SetPropertyValue(nameof(to2), ref _to2, value); } 
     } 
     // Reverse Good Movement
     // Notes for fIssueGoods : 
     private string _to3; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fIssueGoodsto3", Enabled = true)]
     // [Appearance("fIssueGoodsto3Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string to3
     { 
       get { return _to3; } 
       set { SetPropertyValue(nameof(to3), ref _to3, value); } 
     } 
     // Reverse Good Movement
     // Notes for fIssueGoods : 
     private string _to4; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fIssueGoodsto4", Enabled = true)]
     // [Appearance("fIssueGoodsto4Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string to4
     { 
       get { return _to4; } 
       set { SetPropertyValue(nameof(to4), ref _to4, value); } 
     } 
     // Reverse Good Movement
     // Notes for fIssueGoods : 
     private string _to5; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fIssueGoodsto5", Enabled = true)]
     // [Appearance("fIssueGoodsto5Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string to5
     { 
       get { return _to5; } 
       set { SetPropertyValue(nameof(to5), ref _to5, value); } 
     } 
     // 
     // Notes for fIssueGoods : 
     private DateTime _docdate; 
     [XafDisplayName("Document Date"), ToolTip("Document Date")] 
     // [Appearance("fIssueGoodsdocdate", Enabled = true)]
     // [Appearance("fIssueGoodsdocdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime docdate
     { 
       get { return _docdate; } 
       set { SetPropertyValue(nameof(docdate), ref _docdate, value); } 
     } 
     // 
     // Notes for fIssueGoods : 
     private string _outbounddelov; 
     [XafDisplayName("Outbound Delov."), ToolTip("Outbound delov.")] 
     // [Appearance("fIssueGoodsoutbounddelov", Enabled = true)]
     // [Appearance("fIssueGoodsoutbounddelovVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string outbounddelov
     { 
       get { return _outbounddelov; } 
       set { SetPropertyValue(nameof(outbounddelov), ref _outbounddelov, value); } 
     } 
     // 
     // Notes for fIssueGoods : 
     private string _shiptoparty; 
     [XafDisplayName("Ship-To Party"), ToolTip("Ship-to party")] 
     // [Appearance("fIssueGoodsshiptoparty", Enabled = true)]
     // [Appearance("fIssueGoodsshiptopartyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string shiptoparty
     { 
       get { return _shiptoparty; } 
       set { SetPropertyValue(nameof(shiptoparty), ref _shiptoparty, value); } 
     } 
   } 
} 
