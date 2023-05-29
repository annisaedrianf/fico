// Class Name : fCreateSalesOrder.cs 
// Project Name : FICO 
// Last Update : 29/05/2023 15:51:15  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 29/05/2023 15:51:15 
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
   [System.ComponentModel.DisplayName("Create Sales Order: Initial Screen")]
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
     private string _ordertype; 
     [XafDisplayName("Order Type"), ToolTip("Order Type")] 
     // [Appearance("fCreateSalesOrderordertype", Enabled = true)]
     // [Appearance("fCreateSalesOrderordertypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string ordertype
     { 
       get { return _ordertype; } 
       set { SetPropertyValue(nameof(ordertype), ref _ordertype, value); } 
     } 
     // Organizational Data
     // Notes for fCreateSalesOrder : 
     private string _salesorgnz; 
     [XafDisplayName("Sales Organization"), ToolTip("Sales Organization")] 
     // [Appearance("fCreateSalesOrdersalesorgnz", Enabled = true)]
     // [Appearance("fCreateSalesOrdersalesorgnzVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string salesorgnz
     { 
       get { return _salesorgnz; } 
       set { SetPropertyValue(nameof(salesorgnz), ref _salesorgnz, value); } 
     } 
     // Organizational Data
     // Notes for fCreateSalesOrder : 
     private string _distrchnl; 
     [XafDisplayName("Distribution Channel"), ToolTip("Distribution Channel")] 
     // [Appearance("fCreateSalesOrderdistrchnl", Enabled = true)]
     // [Appearance("fCreateSalesOrderdistrchnlVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string distrchnl
     { 
       get { return _distrchnl; } 
       set { SetPropertyValue(nameof(distrchnl), ref _distrchnl, value); } 
     } 
     // Organizational Data
     // Notes for fCreateSalesOrder : 
     private string _division; 
     [XafDisplayName("Division"), ToolTip("Division")] 
     // [Appearance("fCreateSalesOrderdivision", Enabled = true)]
     // [Appearance("fCreateSalesOrderdivisionVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string division
     { 
       get { return _division; } 
       set { SetPropertyValue(nameof(division), ref _division, value); } 
     } 
     // Organizational Data
     // Notes for fCreateSalesOrder : 
     private string _salesoffice; 
     [XafDisplayName("Sales Office"), ToolTip("Sales Office")] 
     // [Appearance("fCreateSalesOrdersalesoffice", Enabled = true)]
     // [Appearance("fCreateSalesOrdersalesofficeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string salesoffice
     { 
       get { return _salesoffice; } 
       set { SetPropertyValue(nameof(salesoffice), ref _salesoffice, value); } 
     } 
     // Organizational Data
     // Notes for fCreateSalesOrder : 
     private string _salesgroup; 
     [XafDisplayName("Sales Group"), ToolTip("Sales Group")] 
     // [Appearance("fCreateSalesOrdersalesgroup", Enabled = true)]
     // [Appearance("fCreateSalesOrdersalesgroupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string salesgroup
     { 
       get { return _salesgroup; } 
       set { SetPropertyValue(nameof(salesgroup), ref _salesgroup, value); } 
     } 
     // BillDoc
     // Notes for fCreateSalesOrder : 
     private string _billdoc; 
     [XafDisplayName("Billing Document"), ToolTip("Billing Document")] 
     // [Appearance("fCreateSalesOrderbilldoc", Enabled = true)]
     // [Appearance("fCreateSalesOrderbilldocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string billdoc
     { 
       get { return _billdoc; } 
       set { SetPropertyValue(nameof(billdoc), ref _billdoc, value); } 
     } 
     // Change Standard Order 2000958: Overview
     // Notes for fCreateSalesOrder : 
     private string _standorder; 
     [XafDisplayName("Standard Order"), ToolTip("Standard Order")] 
     // [Appearance("fCreateSalesOrderstandorder", Enabled = true)]
     // [Appearance("fCreateSalesOrderstandorderVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string standorder
     { 
       get { return _standorder; } 
       set { SetPropertyValue(nameof(standorder), ref _standorder, value); } 
     } 
     // Change Standard Order 2000958: Overview
     // Notes for fCreateSalesOrder : 
     private string _soldparty; 
     [XafDisplayName("Sold-To Party"), ToolTip("Sold-To Party")] 
     // [Appearance("fCreateSalesOrdersoldparty", Enabled = true)]
     // [Appearance("fCreateSalesOrdersoldpartyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string soldparty
     { 
       get { return _soldparty; } 
       set { SetPropertyValue(nameof(soldparty), ref _soldparty, value); } 
     } 
     // Change Standard Order 2000958: Overview
     // Notes for fCreateSalesOrder : 
     private string _shipparty; 
     [XafDisplayName("Ship-To Party"), ToolTip("Ship-To Party")] 
     // [Appearance("fCreateSalesOrdershipparty", Enabled = true)]
     // [Appearance("fCreateSalesOrdershippartyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string shipparty
     { 
       get { return _shipparty; } 
       set { SetPropertyValue(nameof(shipparty), ref _shipparty, value); } 
     } 
     // Change Standard Order 2000958: Overview
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
     // Change Standard Order 2000958: Overview
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
     // Change Standard Order 2000958: Overview
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
     [XafDisplayName("Req. Deliv Date"), ToolTip("Req. deliv date")] 
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
     private bool _cmpltdeliv; 
     [XafDisplayName("Complete Deliv"), ToolTip("Complete deliv")] 
     // [Appearance("fCreateSalesOrdercmpltdeliv", Enabled = true)]
     // [Appearance("fCreateSalesOrdercmpltdelivVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool cmpltdeliv
     { 
       get { return _cmpltdeliv; } 
       set { SetPropertyValue(nameof(cmpltdeliv), ref _cmpltdeliv, value); } 
     } 
     // Sales
     // Notes for fCreateSalesOrder : 
     private enumDelivBlock _delivblock; 
     [XafDisplayName("Delivery Block"), ToolTip("Delivery block")] 
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
     private enumBilllBlock _billblock; 
     [XafDisplayName("Billing Block"), ToolTip("Billing block")] 
     // [Appearance("fCreateSalesOrderbillblock", Enabled = true)]
     // [Appearance("fCreateSalesOrderbillblockVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumBilllBlock billblock
     { 
       get { return _billblock; } 
       set { SetPropertyValue(nameof(billblock), ref _billblock, value); } 
     } 
     // Sales
     // Notes for fCreateSalesOrder : 
     private string _paytcard; 
     [XafDisplayName("Payment Card"), ToolTip("Payment card")] 
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
     [Size(5)] 
     public  string cardverifcode
     { 
       get { return _cardverifcode; } 
       set { SetPropertyValue(nameof(cardverifcode), ref _cardverifcode, value); } 
     } 
     // Sales
     // Notes for fCreateSalesOrder : 
     private string _paytterms; 
     [XafDisplayName("Payment Terms"), ToolTip("Payment terms")] 
     // [Appearance("fCreateSalesOrderpaytterms", Enabled = true)]
     // [Appearance("fCreateSalesOrderpayttermsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string paytterms
     { 
       get { return _paytterms; } 
       set { SetPropertyValue(nameof(paytterms), ref _paytterms, value); } 
     } 
     // Sales
     // Notes for fCreateSalesOrder : 
     private enumOrderReason _orderreason; 
     [XafDisplayName("Order Reason"), ToolTip("Order reason")] 
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
     private string _delivplant; 
     [XafDisplayName("Deliver Plant"), ToolTip("Deliver.Plant")] 
     // [Appearance("fCreateSalesOrderdelivplant", Enabled = true)]
     // [Appearance("fCreateSalesOrderdelivplantVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string delivplant
     { 
       get { return _delivplant; } 
       set { SetPropertyValue(nameof(delivplant), ref _delivplant, value); } 
     } 
     // Sales
     // Notes for fCreateSalesOrder : 
     private double _totweight; 
     [XafDisplayName("Total Weight"), ToolTip("Total Weight")] 
     // [Appearance("fCreateSalesOrdertotweight", Enabled = true)]
     // [Appearance("fCreateSalesOrdertotweightVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double totweight
     { 
       get { return _totweight; } 
       set { SetPropertyValue(nameof(totweight), ref _totweight, value); } 
     } 
     // Sales
     // Notes for fCreateSalesOrder : 
     private double _volume; 
     [XafDisplayName("Volume"), ToolTip("Volume")] 
     // [Appearance("fCreateSalesOrdervolume", Enabled = true)]
     // [Appearance("fCreateSalesOrdervolumeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double volume
     { 
       get { return _volume; } 
       set { SetPropertyValue(nameof(volume), ref _volume, value); } 
     } 
     // Sales
     // Notes for fCreateSalesOrder : 
     private DateTime _pricdata; 
     [XafDisplayName("Pricing Date"), ToolTip("Pricing date")] 
     // [Appearance("fCreateSalesOrderpricdata", Enabled = true)]
     // [Appearance("fCreateSalesOrderpricdataVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime pricdata
     { 
       get { return _pricdata; } 
       set { SetPropertyValue(nameof(pricdata), ref _pricdata, value); } 
     } 
     // Sales
     // Notes for fCreateSalesOrder : 
     private DateTime _expdate; 
     [XafDisplayName("Exp. Date "), ToolTip("Exp. Date ")] 
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
     private string _incoterms; 
     [XafDisplayName("Incoterms"), ToolTip("Incoterms")] 
     // [Appearance("fCreateSalesOrderincoterms", Enabled = true)]
     // [Appearance("fCreateSalesOrderincotermsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string incoterms
     { 
       get { return _incoterms; } 
       set { SetPropertyValue(nameof(incoterms), ref _incoterms, value); } 
     } 
   } 
} 
