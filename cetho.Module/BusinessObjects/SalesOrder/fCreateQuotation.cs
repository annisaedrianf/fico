// Class Name : fCreateQuotation.cs 
// Project Name : FICO 
// Last Update : 06/06/2023 11:57:49  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 06/06/2023 11:57:49 
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
   [System.ComponentModel.DisplayName("Create Quotation: Initial Screen")]
   public class fCreateQuotation : XPObject
   {
     public fCreateQuotation(Session session) : base(session) 
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
     [Appearance("VisiblefCreateQuotationOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // Create Quotation: Overview
     // Notes for fCreateQuotation : 
     private double _netval; 
     [XafDisplayName("Net Value"), ToolTip("Net value")] 
     // [Appearance("fCreateQuotationnetval", Enabled = true)]
     // [Appearance("fCreateQuotationnetvalVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double netval
     { 
       get { return _netval; } 
       set { SetPropertyValue(nameof(netval), ref _netval, value); } 
     } 
     // Create Quotation: Overview
     // Notes for fCreateQuotation : 
     private DateTime _podate; 
     [XafDisplayName("PO Date"), ToolTip("PO Date")] 
     // [Appearance("fCreateQuotationpodate", Enabled = true)]
     // [Appearance("fCreateQuotationpodateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime podate
     { 
       get { return _podate; } 
       set { SetPropertyValue(nameof(podate), ref _podate, value); } 
     } 
     // Create Quotation: Overview
     // Notes for fCreateQuotation : 
     private string _ponumb; 
     [XafDisplayName("PO Number"), ToolTip("PO Number")] 
     // [Appearance("fCreateQuotationponumb", Enabled = true)]
     // [Appearance("fCreateQuotationponumbVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string ponumb
     { 
       get { return _ponumb; } 
       set { SetPropertyValue(nameof(ponumb), ref _ponumb, value); } 
     } 
     // Create Quotation: Overview
     // Notes for fCreateQuotation : 
     private string _quotation; 
     [XafDisplayName("Quotation"), ToolTip("Quotation")] 
     // [Appearance("fCreateQuotationquotation", Enabled = true)]
     // [Appearance("fCreateQuotationquotationVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string quotation
     { 
       get { return _quotation; } 
       set { SetPropertyValue(nameof(quotation), ref _quotation, value); } 
     } 
     // Create Quotation: Overview
     // Notes for fCreateQuotation : 
     private string _shipparty; 
     [XafDisplayName("Ship-To Party"), ToolTip("Ship-To Party")] 
     // [Appearance("fCreateQuotationshipparty", Enabled = true)]
     // [Appearance("fCreateQuotationshippartyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string shipparty
     { 
       get { return _shipparty; } 
       set { SetPropertyValue(nameof(shipparty), ref _shipparty, value); } 
     } 
     // Create Quotation: Overview
     // Notes for fCreateQuotation : 
     private string _soldparty; 
     [XafDisplayName("Sold-To Party"), ToolTip("Sold-To Party")] 
     // [Appearance("fCreateQuotationsoldparty", Enabled = true)]
     // [Appearance("fCreateQuotationsoldpartyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string soldparty
     { 
       get { return _soldparty; } 
       set { SetPropertyValue(nameof(soldparty), ref _soldparty, value); } 
     } 
     // Inquiry
     // Notes for fCreateQuotation : 
     private string _inq; 
     [XafDisplayName("Inquiry"), ToolTip("Inquiry")] 
     // [Appearance("fCreateQuotationinq", Enabled = true)]
     // [Appearance("fCreateQuotationinqVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string inq
     { 
       get { return _inq; } 
       set { SetPropertyValue(nameof(inq), ref _inq, value); } 
     } 
     // Inquiry
     // Notes for fCreateQuotation : 
     private string _purorder; 
     [XafDisplayName("Pur. Order"), ToolTip("Pur. Order ")] 
     // [Appearance("fCreateQuotationpurorder", Enabled = true)]
     // [Appearance("fCreateQuotationpurorderVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string purorder
     { 
       get { return _purorder; } 
       set { SetPropertyValue(nameof(purorder), ref _purorder, value); } 
     } 
     // Inquiry
     // Notes for fCreateQuotation : 
     private string _reqdelivdate; 
     [XafDisplayName("Requested Deliv. Date (Inquiry)"), ToolTip("Requested deliv date")] 
     // [Appearance("fCreateQuotationreqdelivdate", Enabled = true)]
     // [Appearance("fCreateQuotationreqdelivdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string reqdelivdate
     { 
       get { return _reqdelivdate; } 
       set { SetPropertyValue(nameof(reqdelivdate), ref _reqdelivdate, value); } 
     } 
     // Inquiry
     // Notes for fCreateQuotation : 
     private string _soldparty1; 
     [XafDisplayName("Sold-To Party (Inquiry)"), ToolTip("Sold-to party")] 
     // [Appearance("fCreateQuotationsoldparty", Enabled = true)]
     // [Appearance("fCreateQuotationsoldpartyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string soldparty1
     { 
       get { return _soldparty1; } 
       set { SetPropertyValue(nameof(soldparty1), ref _soldparty1, value); } 
     } 
     // Inquiry
     // Notes for fCreateQuotation : 
     private string _wbselmnt; 
     [XafDisplayName("WBS Element"), ToolTip("WBS Element")] 
     // [Appearance("fCreateQuotationwbselmnt", Enabled = true)]
     // [Appearance("fCreateQuotationwbselmntVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(80)] 
     public  string wbselmnt
     { 
       get { return _wbselmnt; } 
       set { SetPropertyValue(nameof(wbselmnt), ref _wbselmnt, value); } 
     } 
     // Sales
     // Notes for fCreateQuotation : 
     private bool _cmpltdlv; 
     [XafDisplayName("Complete Deliv."), ToolTip("Complete dlv.")] 
     // [Appearance("fCreateQuotationcmpltdlv", Enabled = true)]
     // [Appearance("fCreateQuotationcmpltdlvVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool cmpltdlv
     { 
       get { return _cmpltdlv; } 
       set { SetPropertyValue(nameof(cmpltdlv), ref _cmpltdlv, value); } 
     } 
     // Sales
     // Notes for fCreateQuotation : 
     private string _deliverplant; 
     [XafDisplayName("Deliver Plant"), ToolTip("DeliverPlant")] 
     // [Appearance("fCreateQuotationdeliverplant", Enabled = true)]
     // [Appearance("fCreateQuotationdeliverplantVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string deliverplant
     { 
       get { return _deliverplant; } 
       set { SetPropertyValue(nameof(deliverplant), ref _deliverplant, value); } 
     } 
     // Sales
     // Notes for fCreateQuotation : 
     private fCurrency _doccurr; 
     [XafDisplayName("Doc. Currency"), ToolTip("Doc. Currency")] 
     // [Appearance("fCreateQuotationdoccurr", Enabled = true)]
     // [Appearance("fCreateQuotationdoccurrVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCurrency doccurr
     { 
       get { return _doccurr; } 
       set { SetPropertyValue(nameof(doccurr), ref _doccurr, value); } 
     } 
     // Sales
     // Notes for fCreateQuotation : 
     private string _incoterms; 
     [XafDisplayName("Incoterms"), ToolTip("Incoterms")] 
     // [Appearance("fCreateQuotationincoterms", Enabled = true)]
     // [Appearance("fCreateQuotationincotermsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateQuotation : 
     private enumOrderReason _orderreason; 
     [XafDisplayName("Order Reason"), ToolTip("Order reason")] 
     // [Appearance("fCreateQuotationorderreason", Enabled = true)]
     // [Appearance("fCreateQuotationorderreasonVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumOrderReason orderreason
     { 
       get { return _orderreason; } 
       set { SetPropertyValue(nameof(orderreason), ref _orderreason, value); } 
     } 
     // Sales
     // Notes for fCreateQuotation : 
     private string _paytterms; 
     [XafDisplayName("Payment Terms"), ToolTip("Payment terms")] 
     // [Appearance("fCreateQuotationpaytterms", Enabled = true)]
     // [Appearance("fCreateQuotationpayttermsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateQuotation : 
     private DateTime _pricdate; 
     [XafDisplayName("Pricing Date"), ToolTip("Pricing date")] 
     // [Appearance("fCreateQuotationpricdate", Enabled = true)]
     // [Appearance("fCreateQuotationpricdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime pricdate
     { 
       get { return _pricdate; } 
       set { SetPropertyValue(nameof(pricdate), ref _pricdate, value); } 
     } 
     // Sales
     // Notes for fCreateQuotation : 
     private DateTime _reqdelivdate1; 
     [XafDisplayName("Req. Deliv Date"), ToolTip("Req. deliv date")] 
     // [Appearance("fCreateQuotationreqdelivdate", Enabled = true)]
     // [Appearance("fCreateQuotationreqdelivdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime reqdelivdate1
     { 
       get { return _reqdelivdate1; } 
       set { SetPropertyValue(nameof(reqdelivdate1), ref _reqdelivdate1, value); } 
     } 
     // Sales
     // Notes for fCreateQuotation : 
     private string _salesarea; 
     [XafDisplayName("Sales Area"), ToolTip("Sales area")] 
     // [Appearance("fCreateQuotationsalesarea", Enabled = true)]
     // [Appearance("fCreateQuotationsalesareaVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string salesarea
     { 
       get { return _salesarea; } 
       set { SetPropertyValue(nameof(salesarea), ref _salesarea, value); } 
     } 
     // Sales
     // Notes for fCreateQuotation : 
     private double _totamnt; 
     [XafDisplayName("Total Amount"), ToolTip("Total amount")] 
     // [Appearance("fCreateQuotationtotamnt", Enabled = true)]
     // [Appearance("fCreateQuotationtotamntVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double totamnt
     { 
       get { return _totamnt; } 
       set { SetPropertyValue(nameof(totamnt), ref _totamnt, value); } 
     } 
     // Sales
     // Notes for fCreateQuotation : 
     private double _totweight; 
     [XafDisplayName("Total Weight"), ToolTip("Total Weight")] 
     // [Appearance("fCreateQuotationtotweight", Enabled = true)]
     // [Appearance("fCreateQuotationtotweightVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double totweight
     { 
       get { return _totweight; } 
       set { SetPropertyValue(nameof(totweight), ref _totweight, value); } 
     } 
     // Sales
     // Notes for fCreateQuotation : 
     private DateTime _vldfrm; 
     [XafDisplayName("Valid From"), ToolTip("Valid from")] 
     // [Appearance("fCreateQuotationvldfrm", Enabled = true)]
     // [Appearance("fCreateQuotationvldfrmVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime vldfrm
     { 
       get { return _vldfrm; } 
       set { SetPropertyValue(nameof(vldfrm), ref _vldfrm, value); } 
     } 
     // Sales
     // Notes for fCreateQuotation : 
     private DateTime _vldto; 
     [XafDisplayName("Valid To"), ToolTip("Valid to")] 
     // [Appearance("fCreateQuotationvldto", Enabled = true)]
     // [Appearance("fCreateQuotationvldtoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime vldto
     { 
       get { return _vldto; } 
       set { SetPropertyValue(nameof(vldto), ref _vldto, value); } 
     } 
   } 
} 
