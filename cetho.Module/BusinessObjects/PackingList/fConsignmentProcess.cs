// Class Name : fConsignmentProcess.cs 
// Project Name : FICO 
// Last Update : 05/06/2023 14:42:09  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 05/06/2023 14:42:09 
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
   public class fConsignmentProcess : XPObject
   {
     public fConsignmentProcess(Session session) : base(session) 
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
     [Appearance("VisiblefConsignmentProcessOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for fConsignmentProcess : 
     private string _ordertype; 
     [XafDisplayName("Order Type"), ToolTip("Order Type")] 
     // [Appearance("fConsignmentProcessordertype", Enabled = true)]
     // [Appearance("fConsignmentProcessordertypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fConsignmentProcess : 
     private string _distrchnl; 
     [XafDisplayName("Distribution Channel"), ToolTip("Distribution Channel")] 
     // [Appearance("fConsignmentProcessdistrchnl", Enabled = true)]
     // [Appearance("fConsignmentProcessdistrchnlVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fConsignmentProcess : 
     private string _division; 
     [XafDisplayName("Division"), ToolTip("Division")] 
     // [Appearance("fConsignmentProcessdivision", Enabled = true)]
     // [Appearance("fConsignmentProcessdivisionVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fConsignmentProcess : 
     private string _salesgroup; 
     [XafDisplayName("Sales Group"), ToolTip("Sales Group")] 
     // [Appearance("fConsignmentProcesssalesgroup", Enabled = true)]
     // [Appearance("fConsignmentProcesssalesgroupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string salesgroup
     { 
       get { return _salesgroup; } 
       set { SetPropertyValue(nameof(salesgroup), ref _salesgroup, value); } 
     } 
     // Organizational Data
     // Notes for fConsignmentProcess : 
     private string _salesoffice; 
     [XafDisplayName("Sales Office"), ToolTip("Sales Office")] 
     // [Appearance("fConsignmentProcesssalesoffice", Enabled = true)]
     // [Appearance("fConsignmentProcesssalesofficeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fConsignmentProcess : 
     private string _salesorgnz; 
     [XafDisplayName("Sales Organization"), ToolTip("Sales Organization")] 
     // [Appearance("fConsignmentProcesssalesorgnz", Enabled = true)]
     // [Appearance("fConsignmentProcesssalesorgnzVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string salesorgnz
     { 
       get { return _salesorgnz; } 
       set { SetPropertyValue(nameof(salesorgnz), ref _salesorgnz, value); } 
     } 
     // Create Consignment Fill-up: Overview
     // Notes for fConsignmentProcess : 
     private string _consignfillup; 
     [XafDisplayName("Consignment Fill-up"), ToolTip("Consignment Fill-up")] 
     // [Appearance("fConsignmentProcessconsignfillup", Enabled = true)]
     // [Appearance("fConsignmentProcessconsignfillupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string consignfillup
     { 
       get { return _consignfillup; } 
       set { SetPropertyValue(nameof(consignfillup), ref _consignfillup, value); } 
     } 
     // Create Consignment Fill-up: Overview
     // Notes for fConsignmentProcess : 
     private double _netval; 
     [XafDisplayName("Net Value "), ToolTip("Net Value")] 
     // [Appearance("fConsignmentProcessnetval", Enabled = true)]
     // [Appearance("fConsignmentProcessnetvalVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double netval
     { 
       get { return _netval; } 
       set { SetPropertyValue(nameof(netval), ref _netval, value); } 
     } 
     // Create Consignment Fill-up: Overview
     // Notes for fConsignmentProcess : 
     private DateTime _podate; 
     [XafDisplayName("PO Date "), ToolTip("PO Date")] 
     // [Appearance("fConsignmentProcesspodate", Enabled = true)]
     // [Appearance("fConsignmentProcesspodateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime podate
     { 
       get { return _podate; } 
       set { SetPropertyValue(nameof(podate), ref _podate, value); } 
     } 
     // Create Consignment Fill-up: Overview
     // Notes for fConsignmentProcess : 
     private string _ponumb; 
     [XafDisplayName("PO Number "), ToolTip("PO Number")] 
     // [Appearance("fConsignmentProcessponumb", Enabled = true)]
     // [Appearance("fConsignmentProcessponumbVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string ponumb
     { 
       get { return _ponumb; } 
       set { SetPropertyValue(nameof(ponumb), ref _ponumb, value); } 
     } 
     // Create Consignment Fill-up: Overview
     // Notes for fConsignmentProcess : 
     private string _shipparty; 
     [XafDisplayName("Ship-To Party "), ToolTip("Ship-To Party")] 
     // [Appearance("fConsignmentProcessshipparty", Enabled = true)]
     // [Appearance("fConsignmentProcessshippartyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string shipparty
     { 
       get { return _shipparty; } 
       set { SetPropertyValue(nameof(shipparty), ref _shipparty, value); } 
     } 
     // Create Consignment Fill-up: Overview
     // Notes for fConsignmentProcess : 
     private string _soldparty; 
     [XafDisplayName("Sold-To Party "), ToolTip("Sold-To Party")] 
     // [Appearance("fConsignmentProcesssoldparty", Enabled = true)]
     // [Appearance("fConsignmentProcesssoldpartyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string soldparty
     { 
       get { return _soldparty; } 
       set { SetPropertyValue(nameof(soldparty), ref _soldparty, value); } 
     } 
     // Sales
     // Notes for fConsignmentProcess : 
     private enumBilllBlock _billblock; 
     [XafDisplayName("Billing Block"), ToolTip("Billing Block")] 
     // [Appearance("fConsignmentProcessbillblock", Enabled = true)]
     // [Appearance("fConsignmentProcessbillblockVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumBilllBlock billblock
     { 
       get { return _billblock; } 
       set { SetPropertyValue(nameof(billblock), ref _billblock, value); } 
     } 
     // Sales
     // Notes for fConsignmentProcess : 
     private bool _cmpltdeliv; 
     [XafDisplayName("Complete Deliv"), ToolTip("Complete Deliv")] 
     // [Appearance("fConsignmentProcesscmpltdeliv", Enabled = true)]
     // [Appearance("fConsignmentProcesscmpltdelivVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool cmpltdeliv
     { 
       get { return _cmpltdeliv; } 
       set { SetPropertyValue(nameof(cmpltdeliv), ref _cmpltdeliv, value); } 
     } 
     // Sales
     // Notes for fConsignmentProcess : 
     private enumDelivBlock _delivblock; 
     [XafDisplayName("Delivery Block"), ToolTip("Delivery Block")] 
     // [Appearance("fConsignmentProcessdelivblock", Enabled = true)]
     // [Appearance("fConsignmentProcessdelivblockVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumDelivBlock delivblock
     { 
       get { return _delivblock; } 
       set { SetPropertyValue(nameof(delivblock), ref _delivblock, value); } 
     } 
     // Sales
     // Notes for fConsignmentProcess : 
     private string _delivplant; 
     [XafDisplayName("Deliver. Plant "), ToolTip("Deliver. Plant ")] 
     // [Appearance("fConsignmentProcessdelivplant", Enabled = true)]
     // [Appearance("fConsignmentProcessdelivplantVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fConsignmentProcess : 
     private string _incoterms; 
     [XafDisplayName("Incoterms"), ToolTip("Incoterms")] 
     // [Appearance("fConsignmentProcessincoterms", Enabled = true)]
     // [Appearance("fConsignmentProcessincotermsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string incoterms
     { 
       get { return _incoterms; } 
       set { SetPropertyValue(nameof(incoterms), ref _incoterms, value); } 
     } 
     // Sales
     // Notes for fConsignmentProcess : 
     private enumOrderReason _orderreason; 
     [XafDisplayName("Order Reason"), ToolTip("Order Reason")] 
     // [Appearance("fConsignmentProcessorderreason", Enabled = true)]
     // [Appearance("fConsignmentProcessorderreasonVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumOrderReason orderreason
     { 
       get { return _orderreason; } 
       set { SetPropertyValue(nameof(orderreason), ref _orderreason, value); } 
     } 
     // Sales
     // Notes for fConsignmentProcess : 
     private string _paytterms; 
     [XafDisplayName("Payment Terms"), ToolTip("Payment Terms")] 
     // [Appearance("fConsignmentProcesspaytterms", Enabled = true)]
     // [Appearance("fConsignmentProcesspayttermsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fConsignmentProcess : 
     private DateTime _pricdata; 
     [XafDisplayName("Pricing Date"), ToolTip("Pricing Date")] 
     // [Appearance("fConsignmentProcesspricdata", Enabled = true)]
     // [Appearance("fConsignmentProcesspricdataVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime pricdata
     { 
       get { return _pricdata; } 
       set { SetPropertyValue(nameof(pricdata), ref _pricdata, value); } 
     } 
     // Sales
     // Notes for fConsignmentProcess : 
     private DateTime _reqdelivdate; 
     [XafDisplayName("Req. Deliv Date"), ToolTip("Req. Deliv Date")] 
     // [Appearance("fConsignmentProcessreqdelivdate", Enabled = true)]
     // [Appearance("fConsignmentProcessreqdelivdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime reqdelivdate
     { 
       get { return _reqdelivdate; } 
       set { SetPropertyValue(nameof(reqdelivdate), ref _reqdelivdate, value); } 
     } 
     // Sales
     // Notes for fConsignmentProcess : 
     private string _salesarea; 
     [XafDisplayName("Sales Area"), ToolTip("Sales Area")] 
     // [Appearance("fConsignmentProcesssalesarea", Enabled = true)]
     // [Appearance("fConsignmentProcesssalesareaVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string salesarea
     { 
       get { return _salesarea; } 
       set { SetPropertyValue(nameof(salesarea), ref _salesarea, value); } 
     } 
     // Sales
     // Notes for fConsignmentProcess : 
     private double _totweight; 
     [XafDisplayName("Total Weight"), ToolTip("Total Weight")] 
     // [Appearance("fConsignmentProcesstotweight", Enabled = true)]
     // [Appearance("fConsignmentProcesstotweightVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double totweight
     { 
       get { return _totweight; } 
       set { SetPropertyValue(nameof(totweight), ref _totweight, value); } 
     } 
     // Sales
     // Notes for fConsignmentProcess : 
     private double _volume; 
     [XafDisplayName("Volume"), ToolTip("Volume")] 
     // [Appearance("fConsignmentProcessvolume", Enabled = true)]
     // [Appearance("fConsignmentProcessvolumeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double volume
     { 
       get { return _volume; } 
       set { SetPropertyValue(nameof(volume), ref _volume, value); } 
     } 
     // Create Consignment Issue: Overview
     // Notes for fConsignmentProcess : 
     private string _consignissue; 
     [XafDisplayName("Cosignment Issue"), ToolTip("Cosignment Issue")] 
     // [Appearance("fConsignmentProcessconsignissue", Enabled = true)]
     // [Appearance("fConsignmentProcessconsignissueVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string consignissue
     { 
       get { return _consignissue; } 
       set { SetPropertyValue(nameof(consignissue), ref _consignissue, value); } 
     } 
     // Create Consignment Issue: Overview
     // Notes for fConsignmentProcess : 
     private double _netval1; 
     [XafDisplayName("Net Value "), ToolTip("Net Value")] 
     // [Appearance("fConsignmentProcessnetval1", Enabled = true)]
     // [Appearance("fConsignmentProcessnetval1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double netval1
     { 
       get { return _netval1; } 
       set { SetPropertyValue(nameof(netval1), ref _netval1, value); } 
     } 
     // Create Consignment Issue: Overview
     // Notes for fConsignmentProcess : 
     private DateTime _podate1; 
     [XafDisplayName("PO Date "), ToolTip("PO Date")] 
     // [Appearance("fConsignmentProcesspodate1", Enabled = true)]
     // [Appearance("fConsignmentProcesspodate1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime podate1
     { 
       get { return _podate1; } 
       set { SetPropertyValue(nameof(podate1), ref _podate1, value); } 
     } 
     // Create Consignment Issue: Overview
     // Notes for fConsignmentProcess : 
     private string _ponumb1; 
     [XafDisplayName("PO Number "), ToolTip("PO Number")] 
     // [Appearance("fConsignmentProcessponumb1", Enabled = true)]
     // [Appearance("fConsignmentProcessponumb1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string ponumb1
     { 
       get { return _ponumb1; } 
       set { SetPropertyValue(nameof(ponumb1), ref _ponumb1, value); } 
     } 
     // Create Consignment Issue: Overview
     // Notes for fConsignmentProcess : 
     private string _shipparty1; 
     [XafDisplayName("Ship-To Party "), ToolTip("Ship-To Party")] 
     // [Appearance("fConsignmentProcessshipparty1", Enabled = true)]
     // [Appearance("fConsignmentProcessshipparty1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string shipparty1
     { 
       get { return _shipparty1; } 
       set { SetPropertyValue(nameof(shipparty1), ref _shipparty1, value); } 
     } 
     // Create Consignment Issue: Overview
     // Notes for fConsignmentProcess : 
     private string _soldparty1; 
     [XafDisplayName("Sold-To Party "), ToolTip("Sold-To Party")] 
     // [Appearance("fConsignmentProcesssoldparty1", Enabled = true)]
     // [Appearance("fConsignmentProcesssoldparty1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string soldparty1
     { 
       get { return _soldparty1; } 
       set { SetPropertyValue(nameof(soldparty1), ref _soldparty1, value); } 
     } 
     // Create Consignment Returns: Overview
     // Notes for fConsignmentProcess : 
     private string _consignreturn; 
     [XafDisplayName("Consignment Return"), ToolTip("Consignment Return")] 
     // [Appearance("fConsignmentProcessconsignreturn", Enabled = true)]
     // [Appearance("fConsignmentProcessconsignreturnVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string consignreturn
     { 
       get { return _consignreturn; } 
       set { SetPropertyValue(nameof(consignreturn), ref _consignreturn, value); } 
     } 
     // Create Consignment Returns: Overview
     // Notes for fConsignmentProcess : 
     private double _netval2; 
     [XafDisplayName("Net Value "), ToolTip("Net Value")] 
     // [Appearance("fConsignmentProcessnetval2", Enabled = true)]
     // [Appearance("fConsignmentProcessnetval2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double netval2
     { 
       get { return _netval2; } 
       set { SetPropertyValue(nameof(netval2), ref _netval2, value); } 
     } 
     // Create Consignment Returns: Overview
     // Notes for fConsignmentProcess : 
     private DateTime _podate2; 
     [XafDisplayName("PO Date "), ToolTip("PO Date")] 
     // [Appearance("fConsignmentProcesspodate2", Enabled = true)]
     // [Appearance("fConsignmentProcesspodate2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime podate2
     { 
       get { return _podate2; } 
       set { SetPropertyValue(nameof(podate2), ref _podate2, value); } 
     } 
     // Create Consignment Returns: Overview
     // Notes for fConsignmentProcess : 
     private string _ponumb2; 
     [XafDisplayName("PO Number "), ToolTip("PO Number")] 
     // [Appearance("fConsignmentProcessponumb2", Enabled = true)]
     // [Appearance("fConsignmentProcessponumb2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string ponumb2
     { 
       get { return _ponumb2; } 
       set { SetPropertyValue(nameof(ponumb2), ref _ponumb2, value); } 
     } 
     // Create Consignment Returns: Overview
     // Notes for fConsignmentProcess : 
     private string _shipparty2; 
     [XafDisplayName("Ship-To Party "), ToolTip("Ship-To Party")] 
     // [Appearance("fConsignmentProcessshipparty2", Enabled = true)]
     // [Appearance("fConsignmentProcessshipparty2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string shipparty2
     { 
       get { return _shipparty2; } 
       set { SetPropertyValue(nameof(shipparty2), ref _shipparty2, value); } 
     } 
     // Create Consignment Returns: Overview
     // Notes for fConsignmentProcess : 
     private string _soldparty2; 
     [XafDisplayName("Sold-To Party "), ToolTip("Sold-To Party")] 
     // [Appearance("fConsignmentProcesssoldparty2", Enabled = true)]
     // [Appearance("fConsignmentProcesssoldparty2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string soldparty2
     { 
       get { return _soldparty2; } 
       set { SetPropertyValue(nameof(soldparty2), ref _soldparty2, value); } 
     } 
     // Create Consignment Pick-up: Overview
     // Notes for fConsignmentProcess : 
     private string _consignpickup; 
     [XafDisplayName("Consignment Pick-up"), ToolTip("Consignment Pick-up")] 
     // [Appearance("fConsignmentProcessconsignpickup", Enabled = true)]
     // [Appearance("fConsignmentProcessconsignpickupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string consignpickup
     { 
       get { return _consignpickup; } 
       set { SetPropertyValue(nameof(consignpickup), ref _consignpickup, value); } 
     } 
     // Create Consignment Pick-up: Overview
     // Notes for fConsignmentProcess : 
     private double _netval3; 
     [XafDisplayName("Net Value "), ToolTip("Net Value")] 
     // [Appearance("fConsignmentProcessnetval3", Enabled = true)]
     // [Appearance("fConsignmentProcessnetval3Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double netval3
     { 
       get { return _netval3; } 
       set { SetPropertyValue(nameof(netval3), ref _netval3, value); } 
     } 
     // Create Consignment Pick-up: Overview
     // Notes for fConsignmentProcess : 
     private DateTime _podate3; 
     [XafDisplayName("PO Date "), ToolTip("PO Date")] 
     // [Appearance("fConsignmentProcesspodate3", Enabled = true)]
     // [Appearance("fConsignmentProcesspodate3Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime podate3
     { 
       get { return _podate3; } 
       set { SetPropertyValue(nameof(podate3), ref _podate3, value); } 
     } 
     // Create Consignment Pick-up: Overview
     // Notes for fConsignmentProcess : 
     private string _ponumb3; 
     [XafDisplayName("PO Number "), ToolTip("PO Number")] 
     // [Appearance("fConsignmentProcessponumb3", Enabled = true)]
     // [Appearance("fConsignmentProcessponumb3Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string ponumb3
     { 
       get { return _ponumb3; } 
       set { SetPropertyValue(nameof(ponumb3), ref _ponumb3, value); } 
     } 
     // Create Consignment Pick-up: Overview
     // Notes for fConsignmentProcess : 
     private string _shipparty3; 
     [XafDisplayName("Ship-To Party "), ToolTip("Ship-To Party")] 
     // [Appearance("fConsignmentProcessshipparty3", Enabled = true)]
     // [Appearance("fConsignmentProcessshipparty3Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string shipparty3
     { 
       get { return _shipparty3; } 
       set { SetPropertyValue(nameof(shipparty3), ref _shipparty3, value); } 
     } 
     // Create Consignment Pick-up: Overview
     // Notes for fConsignmentProcess : 
     private string _soldparty3; 
     [XafDisplayName("Sold-To Party "), ToolTip("Sold-To Party")] 
     // [Appearance("fConsignmentProcesssoldparty3", Enabled = true)]
     // [Appearance("fConsignmentProcesssoldparty3Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string soldparty3
     { 
       get { return _soldparty3; } 
       set { SetPropertyValue(nameof(soldparty3), ref _soldparty3, value); } 
     } 
   } 
} 
