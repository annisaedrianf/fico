// Class Name : fCreateSalesOrder.cs 
// Project Name : FICO 
// Last Update : 06/06/2023 12:12:25  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 06/06/2023 12:12:25 
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
   [System.ComponentModel.DisplayName("Create Standard Order: Overview")]
   public class fCreateSalesOrder : XPObject
   {
     public fCreateSalesOrder(Session session) : base(session) 
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
     [Appearance("VisiblefCreateSalesOrderOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for fCreateSalesOrder : 
     private string _standorder; 
     [XafDisplayName("Standard Order"), ToolTip("Standard Order")] 
     // [Appearance("fCreateSalesOrderstandorder", Enabled = true)]
     // [Appearance("fCreateSalesOrderstandorderVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string standorder
     { 
       get { return _standorder; } 
       set { SetPropertyValue(nameof(standorder), ref _standorder, value); } 
     } 
     // 
     // Notes for fCreateSalesOrder : 
     private string _soldparty; 
     [XafDisplayName("Sold-To Party"), ToolTip("Sold-To Party")] 
     // [Appearance("fCreateSalesOrdersoldparty", Enabled = true)]
     // [Appearance("fCreateSalesOrdersoldpartyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string soldparty
     { 
       get { return _soldparty; } 
       set { SetPropertyValue(nameof(soldparty), ref _soldparty, value); } 
     } 
     // 
     // Notes for fCreateSalesOrder : 
     private string _shipparty; 
     [XafDisplayName("Ship-To Party"), ToolTip("Ship-To Party")] 
     // [Appearance("fCreateSalesOrdershipparty", Enabled = true)]
     // [Appearance("fCreateSalesOrdershippartyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string shipparty
     { 
       get { return _shipparty; } 
       set { SetPropertyValue(nameof(shipparty), ref _shipparty, value); } 
     } 
     // 
     // Notes for fCreateSalesOrder : 
     private string _ponumb; 
     [XafDisplayName("PO Number"), ToolTip("PO Number")] 
     // [Appearance("fCreateSalesOrderponumb", Enabled = true)]
     // [Appearance("fCreateSalesOrderponumbVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string ponumb
     { 
       get { return _ponumb; } 
       set { SetPropertyValue(nameof(ponumb), ref _ponumb, value); } 
     } 
     // 
     // Notes for fCreateSalesOrder : 
     private double _netval; 
     [XafDisplayName("Net Value"), ToolTip("Net Value")] 
     // [Appearance("fCreateSalesOrdernetval", Enabled = true)]
     // [Appearance("fCreateSalesOrdernetvalVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double netval
     { 
       get { return _netval; } 
       set { SetPropertyValue(nameof(netval), ref _netval, value); } 
     } 
     // 
     // Notes for fCreateSalesOrder : 
     private DateTime _podate; 
     [XafDisplayName("PO Date"), ToolTip("PO Date")] 
     // [Appearance("fCreateSalesOrderpodate", Enabled = true)]
     // [Appearance("fCreateSalesOrderpodateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime podate
     { 
       get { return _podate; } 
       set { SetPropertyValue(nameof(podate), ref _podate, value); } 
     } 
     // Sales
     // Notes for fCreateSalesOrder : 
     private DateTime _reqdelivdate; 
     [XafDisplayName("Req. Deliv Date"), ToolTip("Req. Deliv Date")] 
     // [Appearance("fCreateSalesOrderreqdelivdate", Enabled = true)]
     // [Appearance("fCreateSalesOrderreqdelivdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime reqdelivdate
     { 
       get { return _reqdelivdate; } 
       set { SetPropertyValue(nameof(reqdelivdate), ref _reqdelivdate, value); } 
     } 
     // Sales
     // Notes for fCreateSalesOrder : 
     private bool _cmpltdlv; 
     [XafDisplayName("Complete Deliv"), ToolTip("Complete Deliv")] 
     // [Appearance("fCreateSalesOrdercmpltdlv", Enabled = true)]
     // [Appearance("fCreateSalesOrdercmpltdlvVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool cmpltdlv
     { 
       get { return _cmpltdlv; } 
       set { SetPropertyValue(nameof(cmpltdlv), ref _cmpltdlv, value); } 
     } 
     // Sales
     // Notes for fCreateSalesOrder : 
     private enumDelivBlock _delivblock; 
     [XafDisplayName("Delivery Block"), ToolTip("Delivery Block")] 
     // [Appearance("fCreateSalesOrderdelivblock", Enabled = true)]
     // [Appearance("fCreateSalesOrderdelivblockVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumDelivBlock delivblock
     { 
       get { return _delivblock; } 
       set { SetPropertyValue(nameof(delivblock), ref _delivblock, value); } 
     } 
     // Sales
     // Notes for fCreateSalesOrder : 
     private enumBillBlock _billblock; 
     [XafDisplayName("Billing Block"), ToolTip("Billing Block")] 
     // [Appearance("fCreateSalesOrderbillblock", Enabled = true)]
     // [Appearance("fCreateSalesOrderbillblockVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumBillBlock billblock
     { 
       get { return _billblock; } 
       set { SetPropertyValue(nameof(billblock), ref _billblock, value); } 
     } 
     // Sales
     // Notes for fCreateSalesOrder : 
     private string _paytcard; 
     [XafDisplayName("Payment Card"), ToolTip("Payment Card")] 
     // [Appearance("fCreateSalesOrderpaytcard", Enabled = true)]
     // [Appearance("fCreateSalesOrderpaytcardVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string paytcard
     { 
       get { return _paytcard; } 
       set { SetPropertyValue(nameof(paytcard), ref _paytcard, value); } 
     } 
     // Sales
     // Notes for fCreateSalesOrder : 
     private string _cardverifcode; 
     [XafDisplayName("Card Verif. Code"), ToolTip("Card Verif. Code")] 
     // [Appearance("fCreateSalesOrdercardverifcode", Enabled = true)]
     // [Appearance("fCreateSalesOrdercardverifcodeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string cardverifcode
     { 
       get { return _cardverifcode; } 
       set { SetPropertyValue(nameof(cardverifcode), ref _cardverifcode, value); } 
     } 
     // Sales
     // Notes for fCreateSalesOrder : 
     private string _paytterms; 
     [XafDisplayName("Payment Terms"), ToolTip("Payment Terms")] 
     // [Appearance("fCreateSalesOrderpaytterms", Enabled = true)]
     // [Appearance("fCreateSalesOrderpayttermsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string paytterms
     { 
       get { return _paytterms; } 
       set { SetPropertyValue(nameof(paytterms), ref _paytterms, value); } 
     } 
     // Sales
     // Notes for fCreateSalesOrder : 
     private enumOrderReason _orderreason; 
     [XafDisplayName("Order Reason"), ToolTip("Order Reason")] 
     // [Appearance("fCreateSalesOrderorderreason", Enabled = true)]
     // [Appearance("fCreateSalesOrderorderreasonVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumOrderReason orderreason
     { 
       get { return _orderreason; } 
       set { SetPropertyValue(nameof(orderreason), ref _orderreason, value); } 
     } 
     // Sales
     // Notes for fCreateSalesOrder : 
     private string _delivplnt; 
     [XafDisplayName("Deliver Plant"), ToolTip("Deliver Plant")] 
     // [Appearance("fCreateSalesOrderdelivplnt", Enabled = true)]
     // [Appearance("fCreateSalesOrderdelivplntVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string delivplnt
     { 
       get { return _delivplnt; } 
       set { SetPropertyValue(nameof(delivplnt), ref _delivplnt, value); } 
     } 
     // Sales
     // Notes for fCreateSalesOrder : 
     private string _totweight; 
     [XafDisplayName("Total Weight"), ToolTip("Total Weight")] 
     // [Appearance("fCreateSalesOrdertotweight", Enabled = true)]
     // [Appearance("fCreateSalesOrdertotweightVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string totweight
     { 
       get { return _totweight; } 
       set { SetPropertyValue(nameof(totweight), ref _totweight, value); } 
     } 
     // Sales
     // Notes for fCreateSalesOrder : 
     private string _volume; 
     [XafDisplayName("Volume"), ToolTip("Volume")] 
     // [Appearance("fCreateSalesOrdervolume", Enabled = true)]
     // [Appearance("fCreateSalesOrdervolumeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string volume
     { 
       get { return _volume; } 
       set { SetPropertyValue(nameof(volume), ref _volume, value); } 
     } 
     // Sales
     // Notes for fCreateSalesOrder : 
     private DateTime _pricdate; 
     [XafDisplayName("Pricing Date"), ToolTip("Pricing Date")] 
     // [Appearance("fCreateSalesOrderpricdate", Enabled = true)]
     // [Appearance("fCreateSalesOrderpricdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime pricdate
     { 
       get { return _pricdate; } 
       set { SetPropertyValue(nameof(pricdate), ref _pricdate, value); } 
     } 
     // Sales
     // Notes for fCreateSalesOrder : 
     private DateTime _expdate; 
     [XafDisplayName("Exp. Date"), ToolTip("Exp. Date")] 
     // [Appearance("fCreateSalesOrderexpdate", Enabled = true)]
     // [Appearance("fCreateSalesOrderexpdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime expdate
     { 
       get { return _expdate; } 
       set { SetPropertyValue(nameof(expdate), ref _expdate, value); } 
     } 
     // Sales
     // Notes for fCreateSalesOrder : 
     private enumIncoterms _incoterms; 
     [XafDisplayName("Incoterms"), ToolTip("Incoterms")] 
     // [Appearance("fCreateSalesOrderincoterms", Enabled = true)]
     // [Appearance("fCreateSalesOrderincotermsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumIncoterms incoterms
     { 
       get { return _incoterms; } 
       set { SetPropertyValue(nameof(incoterms), ref _incoterms, value); } 
     } 
   } 
} 
