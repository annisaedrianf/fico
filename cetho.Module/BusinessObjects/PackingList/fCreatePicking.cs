// Class Name : fCreatePicking.cs 
// Project Name : FICO 
// Last Update : 05/06/2023 14:12:10  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 05/06/2023 14:12:07 
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
   [System.ComponentModel.DisplayName("Create Outbound Delivery with Order Reference")]
   public class fCreatePicking : XPObject
   {
     public fCreatePicking(Session session) : base(session) 
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
     [Appearance("VisiblefCreatePickingOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for fCreatePicking : 
     private string _shippoint; 
     [XafDisplayName("Shipping Point"), ToolTip("Shipping point")] 
     // [Appearance("fCreatePickingshippoint", Enabled = true)]
     // [Appearance("fCreatePickingshippointVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string shippoint
     { 
       get { return _shippoint; } 
       set { SetPropertyValue(nameof(shippoint), ref _shippoint, value); } 
     } 
     // Sales order data
     // Notes for fCreatePicking : 
     private DateTime _selectdate; 
     [XafDisplayName("Selection Date"), ToolTip("Selection date")] 
     // [Appearance("fCreatePickingselectdate", Enabled = true)]
     // [Appearance("fCreatePickingselectdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime selectdate
     { 
       get { return _selectdate; } 
       set { SetPropertyValue(nameof(selectdate), ref _selectdate, value); } 
     } 
     // Sales order data
     // Notes for fCreatePicking : 
     private string _order; 
     [XafDisplayName("Order"), ToolTip("Order")] 
     // [Appearance("fCreatePickingorder", Enabled = true)]
     // [Appearance("fCreatePickingorderVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string order
     { 
       get { return _order; } 
       set { SetPropertyValue(nameof(order), ref _order, value); } 
     } 
     // Sales order data
     // Notes for fCreatePicking : 
     private string _fromitem; 
     [XafDisplayName("From Item"), ToolTip("From item")] 
     // [Appearance("fCreatePickingfromitem", Enabled = true)]
     // [Appearance("fCreatePickingfromitemVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string fromitem
     { 
       get { return _fromitem; } 
       set { SetPropertyValue(nameof(fromitem), ref _fromitem, value); } 
     } 
     // Sales order data
     // Notes for fCreatePicking : 
     private string _toitem; 
     [XafDisplayName("To Item"), ToolTip("To item")] 
     // [Appearance("fCreatePickingtoitem", Enabled = true)]
     // [Appearance("fCreatePickingtoitemVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string toitem
     { 
       get { return _toitem; } 
       set { SetPropertyValue(nameof(toitem), ref _toitem, value); } 
     } 
     // Create Transfer Order for Delivery
     // Notes for fCreatePicking : 
     private string _warehousenumb; 
     [XafDisplayName("Warehouse Number"), ToolTip("Warehouse Number")] 
     // [Appearance("fCreatePickingwarehousenumb", Enabled = true)]
     // [Appearance("fCreatePickingwarehousenumbVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string warehousenumb
     { 
       get { return _warehousenumb; } 
       set { SetPropertyValue(nameof(warehousenumb), ref _warehousenumb, value); } 
     } 
     // Create Transfer Order for Delivery
     // Notes for fCreatePicking : 
     private string _plant; 
     [XafDisplayName("Plant"), ToolTip("Plant")] 
     // [Appearance("fCreatePickingplant", Enabled = true)]
     // [Appearance("fCreatePickingplantVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string plant
     { 
       get { return _plant; } 
       set { SetPropertyValue(nameof(plant), ref _plant, value); } 
     } 
     // Create Transfer Order for Delivery
     // Notes for fCreatePicking : 
     private string _delivery; 
     [XafDisplayName("Delivery"), ToolTip("Delivery")] 
     // [Appearance("fCreatePickingdelivery", Enabled = true)]
     // [Appearance("fCreatePickingdeliveryVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(40)] 
     public  string delivery
     { 
       get { return _delivery; } 
       set { SetPropertyValue(nameof(delivery), ref _delivery, value); } 
     } 
     // Create Transfer Order for Delivery
     // Notes for fCreatePicking : 
     private string _group; 
     [XafDisplayName("Group"), ToolTip("Group")] 
     // [Appearance("fCreatePickinggroup", Enabled = true)]
     // [Appearance("fCreatePickinggroupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string group
     { 
       get { return _group; } 
       set { SetPropertyValue(nameof(group), ref _group, value); } 
     } 
     // Control
     // Notes for fCreatePicking : 
     private bool _activeitem; 
     [XafDisplayName("Activate Item"), ToolTip("Activate Item")] 
     // [Appearance("fCreatePickingactiveitem", Enabled = true)]
     // [Appearance("fCreatePickingactiveitemVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool activeitem
     { 
       get { return _activeitem; } 
       set { SetPropertyValue(nameof(activeitem), ref _activeitem, value); } 
     } 
     // Control
     // Notes for fCreatePicking : 
     private enumForeground _foreground; 
     [XafDisplayName("Foreground/Background"), ToolTip("Foreground/background")] 
     // [Appearance("fCreatePickingforeground", Enabled = true)]
     // [Appearance("fCreatePickingforegroundVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumForeground foreground
     { 
       get { return _foreground; } 
       set { SetPropertyValue(nameof(foreground), ref _foreground, value); } 
     } 
     // Control
     // Notes for fCreatePicking : 
     private string _adoptpickqty; 
     [XafDisplayName("Adopt Pick Quantity"), ToolTip("Adopt Pick Quantity")] 
     // [Appearance("fCreatePickingadoptpickqty", Enabled = true)]
     // [Appearance("fCreatePickingadoptpickqtyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string adoptpickqty
     { 
       get { return _adoptpickqty; } 
       set { SetPropertyValue(nameof(adoptpickqty), ref _adoptpickqty, value); } 
     } 
     // Control
     // Notes for fCreatePicking : 
     private string _adoptputawayqty; 
     [XafDisplayName("Adopt Putawat Qty"), ToolTip("Adopt putaway qty")] 
     // [Appearance("fCreatePickingadoptputawayqty", Enabled = true)]
     // [Appearance("fCreatePickingadoptputawayqtyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string adoptputawayqty
     { 
       get { return _adoptputawayqty; } 
       set { SetPropertyValue(nameof(adoptputawayqty), ref _adoptputawayqty, value); } 
     } 
     // Control
     // Notes for fCreatePicking : 
     private string _putawayyoproc; 
     [XafDisplayName("Putaway To Proc."), ToolTip("Putaway TO proc.")] 
     // [Appearance("fCreatePickingputawayyoproc", Enabled = true)]
     // [Appearance("fCreatePickingputawayyoprocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string putawayyoproc
     { 
       get { return _putawayyoproc; } 
       set { SetPropertyValue(nameof(putawayyoproc), ref _putawayyoproc, value); } 
     } 
     // Change Outbound Delivery
     // Notes for fCreatePicking : 
     private string _outbounddeliv; 
     [XafDisplayName("Outbound Delivery"), ToolTip("Outbound Delivery")] 
     // [Appearance("fCreatePickingoutbounddeliv", Enabled = true)]
     // [Appearance("fCreatePickingoutbounddelivVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string outbounddeliv
     { 
       get { return _outbounddeliv; } 
       set { SetPropertyValue(nameof(outbounddeliv), ref _outbounddeliv, value); } 
     } 
     // Pack Material
     // Notes for fCreatePicking : 
     private string _handunit; 
     [XafDisplayName("Handing Unit"), ToolTip("Handing Unit")] 
     // [Appearance("fCreatePickinghandunit", Enabled = true)]
     // [Appearance("fCreatePickinghandunitVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string handunit
     { 
       get { return _handunit; } 
       set { SetPropertyValue(nameof(handunit), ref _handunit, value); } 
     } 
     // Pack Material
     // Notes for fCreatePicking : 
     private string _packmatl; 
     [XafDisplayName("Packaging Materials"), ToolTip("Packaging Materials")] 
     // [Appearance("fCreatePickingpackmatl", Enabled = true)]
     // [Appearance("fCreatePickingpackmatlVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string packmatl
     { 
       get { return _packmatl; } 
       set { SetPropertyValue(nameof(packmatl), ref _packmatl, value); } 
     } 
     // Pack Material
     // Notes for fCreatePicking : 
     private string _totweight; 
     [XafDisplayName("Total Weight"), ToolTip("Total Weight")] 
     // [Appearance("fCreatePickingtotweight", Enabled = true)]
     // [Appearance("fCreatePickingtotweightVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string totweight
     { 
       get { return _totweight; } 
       set { SetPropertyValue(nameof(totweight), ref _totweight, value); } 
     } 
     // Pack Material
     // Notes for fCreatePicking : 
     private string _loadweight; 
     [XafDisplayName("Loading Weight"), ToolTip("Loading Weight")] 
     // [Appearance("fCreatePickingloadweight", Enabled = true)]
     // [Appearance("fCreatePickingloadweightVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string loadweight
     { 
       get { return _loadweight; } 
       set { SetPropertyValue(nameof(loadweight), ref _loadweight, value); } 
     } 
   } 
} 
