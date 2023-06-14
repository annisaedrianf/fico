// Class Name : fCreateReturn.cs 
// Project Name : FICO 
// Last Update : 05/06/2023 14:48:42  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 05/06/2023 14:48:42 
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
   public class fCreateReturn : XPObject
   {
     public fCreateReturn(Session session) : base(session) 
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
     [Appearance("VisiblefCreateReturnOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for fCreateReturn : 
     private string _ordertype; 
     [XafDisplayName("Order Type"), ToolTip("Order Type")] 
     // [Appearance("fCreateReturnordertype", Enabled = true)]
     // [Appearance("fCreateReturnordertypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string ordertype
     { 
       get { return _ordertype; } 
       set { SetPropertyValue(nameof(ordertype), ref _ordertype, value); } 
     } 
     // Create Deliv.Fee of Charge: Overview
     // Notes for fCreateReturn : 
     private string _delivfreechg; 
     [XafDisplayName("Deliv.Free of Change"), ToolTip("Deliv.Free of Change")] 
     // [Appearance("fCreateReturndelivfreechg", Enabled = true)]
     // [Appearance("fCreateReturndelivfreechgVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string delivfreechg
     { 
       get { return _delivfreechg; } 
       set { SetPropertyValue(nameof(delivfreechg), ref _delivfreechg, value); } 
     } 
     // Create Deliv.Fee of Charge: Overview
     // Notes for fCreateReturn : 
     private double _netval1; 
     [XafDisplayName("Net Value "), ToolTip("Net Value")] 
     // [Appearance("fCreateReturnnetval1", Enabled = true)]
     // [Appearance("fCreateReturnnetval1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double netval1
     { 
       get { return _netval1; } 
       set { SetPropertyValue(nameof(netval1), ref _netval1, value); } 
     } 
     // Create Deliv.Fee of Charge: Overview
     // Notes for fCreateReturn : 
     private DateTime _podate1; 
     [XafDisplayName("PO Date "), ToolTip("PO Date")] 
     // [Appearance("fCreateReturnpodate1", Enabled = true)]
     // [Appearance("fCreateReturnpodate1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime podate1
     { 
       get { return _podate1; } 
       set { SetPropertyValue(nameof(podate1), ref _podate1, value); } 
     } 
     // Create Deliv.Fee of Charge: Overview
     // Notes for fCreateReturn : 
     private string _ponumb1; 
     [XafDisplayName("PO Number "), ToolTip("PO Number")] 
     // [Appearance("fCreateReturnponumb1", Enabled = true)]
     // [Appearance("fCreateReturnponumb1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string ponumb1
     { 
       get { return _ponumb1; } 
       set { SetPropertyValue(nameof(ponumb1), ref _ponumb1, value); } 
     } 
     // Create Deliv.Fee of Charge: Overview
     // Notes for fCreateReturn : 
     private string _shipparty2; 
     [XafDisplayName("Ship-To Party "), ToolTip("Ship-To Party")] 
     // [Appearance("fCreateReturnshipparty2", Enabled = true)]
     // [Appearance("fCreateReturnshipparty2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string shipparty2
     { 
       get { return _shipparty2; } 
       set { SetPropertyValue(nameof(shipparty2), ref _shipparty2, value); } 
     } 
     // Create Deliv.Fee of Charge: Overview
     // Notes for fCreateReturn : 
     private string _soldparty2; 
     [XafDisplayName("Sold-To Party "), ToolTip("Sold-To Party")] 
     // [Appearance("fCreateReturnsoldparty2", Enabled = true)]
     // [Appearance("fCreateReturnsoldparty2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string soldparty2
     { 
       get { return _soldparty2; } 
       set { SetPropertyValue(nameof(soldparty2), ref _soldparty2, value); } 
     } 
     // Create Outbond Delivery with Order Reference
     // Notes for fCreateReturn : 
     private string _shippoint; 
     [XafDisplayName("Shipping Point"), ToolTip("Shipping Point")] 
     // [Appearance("fCreateReturnshippoint", Enabled = true)]
     // [Appearance("fCreateReturnshippointVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string shippoint
     { 
       get { return _shippoint; } 
       set { SetPropertyValue(nameof(shippoint), ref _shippoint, value); } 
     } 
     // Create Returns: Overview
     // Notes for fCreateReturn : 
     private double _netval; 
     [XafDisplayName("Net Value "), ToolTip("Net Value")] 
     // [Appearance("fCreateReturnnetval", Enabled = true)]
     // [Appearance("fCreateReturnnetvalVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double netval
     { 
       get { return _netval; } 
       set { SetPropertyValue(nameof(netval), ref _netval, value); } 
     } 
     // Create Returns: Overview
     // Notes for fCreateReturn : 
     private DateTime _podate; 
     [XafDisplayName("PO Date "), ToolTip("PO Date")] 
     // [Appearance("fCreateReturnpodate", Enabled = true)]
     // [Appearance("fCreateReturnpodateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime podate
     { 
       get { return _podate; } 
       set { SetPropertyValue(nameof(podate), ref _podate, value); } 
     } 
     // Create Returns: Overview
     // Notes for fCreateReturn : 
     private string _ponumb; 
     [XafDisplayName("PO Number "), ToolTip("PO Number")] 
     // [Appearance("fCreateReturnponumb", Enabled = true)]
     // [Appearance("fCreateReturnponumbVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string ponumb
     { 
       get { return _ponumb; } 
       set { SetPropertyValue(nameof(ponumb), ref _ponumb, value); } 
     } 
     // Create Returns: Overview
     // Notes for fCreateReturn : 
     private string _returns; 
     [XafDisplayName("Returns"), ToolTip("Returns")] 
     // [Appearance("fCreateReturnreturns", Enabled = true)]
     // [Appearance("fCreateReturnreturnsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string returns
     { 
       get { return _returns; } 
       set { SetPropertyValue(nameof (returns), ref _returns, value); } 
     } 
     // Create Returns: Overview
     // Notes for fCreateReturn : 
     private string _shipparty; 
     [XafDisplayName("Ship-To Party "), ToolTip("Ship-To Party")] 
     // [Appearance("fCreateReturnshipparty", Enabled = true)]
     // [Appearance("fCreateReturnshippartyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string shipparty
     { 
       get { return _shipparty; } 
       set { SetPropertyValue(nameof(shipparty), ref _shipparty, value); } 
     } 
     // Create Returns: Overview
     // Notes for fCreateReturn : 
     private string _soldparty1; 
     [XafDisplayName("Sold-To Party "), ToolTip("Sold-To Party")] 
     // [Appearance("fCreateReturnsoldparty1", Enabled = true)]
     // [Appearance("fCreateReturnsoldparty1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string soldparty1
     { 
       get { return _soldparty1; } 
       set { SetPropertyValue(nameof(soldparty1), ref _soldparty1, value); } 
     } 
     // Create Subs.Dlv.Free of Ch.:Overview
     // Notes for fCreateReturn : 
     private double _netval2; 
     [XafDisplayName("Net Value "), ToolTip("Net Value")] 
     // [Appearance("fCreateReturnnetval2", Enabled = true)]
     // [Appearance("fCreateReturnnetval2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double netval2
     { 
       get { return _netval2; } 
       set { SetPropertyValue(nameof(netval2), ref _netval2, value); } 
     } 
     // Create Subs.Dlv.Free of Ch.:Overview
     // Notes for fCreateReturn : 
     private DateTime _podate2; 
     [XafDisplayName("PO Date "), ToolTip("PO Date")] 
     // [Appearance("fCreateReturnpodate2", Enabled = true)]
     // [Appearance("fCreateReturnpodate2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime podate2
     { 
       get { return _podate2; } 
       set { SetPropertyValue(nameof(podate2), ref _podate2, value); } 
     } 
     // Create Subs.Dlv.Free of Ch.:Overview
     // Notes for fCreateReturn : 
     private string _ponumb2; 
     [XafDisplayName("PO Number "), ToolTip("PO Number")] 
     // [Appearance("fCreateReturnponumb2", Enabled = true)]
     // [Appearance("fCreateReturnponumb2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string ponumb2
     { 
       get { return _ponumb2; } 
       set { SetPropertyValue(nameof(ponumb2), ref _ponumb2, value); } 
     } 
     // Create Subs.Dlv.Free of Ch.:Overview
     // Notes for fCreateReturn : 
     private string _shipparty3; 
     [XafDisplayName("Ship-To Party "), ToolTip("Ship-To Party")] 
     // [Appearance("fCreateReturnshipparty3", Enabled = true)]
     // [Appearance("fCreateReturnshipparty3Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string shipparty3
     { 
       get { return _shipparty3; } 
       set { SetPropertyValue(nameof(shipparty3), ref _shipparty3, value); } 
     } 
     // Create Subs.Dlv.Free of Ch.:Overview
     // Notes for fCreateReturn : 
     private string _soldparty3; 
     [XafDisplayName("Sold-To Party "), ToolTip("Sold-To Party")] 
     // [Appearance("fCreateReturnsoldparty3", Enabled = true)]
     // [Appearance("fCreateReturnsoldparty3Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string soldparty3
     { 
       get { return _soldparty3; } 
       set { SetPropertyValue(nameof(soldparty3), ref _soldparty3, value); } 
     } 
     // Create Subs.Dlv.Free of Ch.:Overview
     // Notes for fCreateReturn : 
     private string _subsdlvfreech; 
     [XafDisplayName("Subs. Dlv.Free of Ch."), ToolTip("Subs. Dlv.Free of Ch.")] 
     // [Appearance("fCreateReturnsubsdlvfreech", Enabled = true)]
     // [Appearance("fCreateReturnsubsdlvfreechVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string subsdlvfreech
     { 
       get { return _subsdlvfreech; } 
       set { SetPropertyValue(nameof(subsdlvfreech), ref _subsdlvfreech, value); } 
     } 
     // Item Overview
     // Notes for fCreateReturn : 
     private DateTime _actgidate; 
     [XafDisplayName("Actual GI Date"), ToolTip("Actual GI Date")] 
     // [Appearance("fCreateReturnactgidate", Enabled = true)]
     // [Appearance("fCreateReturnactgidateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime actgidate
     { 
       get { return _actgidate; } 
       set { SetPropertyValue(nameof(actgidate), ref _actgidate, value); } 
     } 
     // Item Overview
     // Notes for fCreateReturn : 
     private string _nopack; 
     [XafDisplayName("No.of Packages"), ToolTip("No.of Packages")] 
     // [Appearance("fCreateReturnnopack", Enabled = true)]
     // [Appearance("fCreateReturnnopackVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string nopack
     { 
       get { return _nopack; } 
       set { SetPropertyValue(nameof(nopack), ref _nopack, value); } 
     } 
     // Item Overview
     // Notes for fCreateReturn : 
     private DateTime _plangi; 
     [XafDisplayName("Planned GI"), ToolTip("Planned GI")] 
     // [Appearance("fCreateReturnplangi", Enabled = true)]
     // [Appearance("fCreateReturnplangiVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime plangi
     { 
       get { return _plangi; } 
       set { SetPropertyValue(nameof(plangi), ref _plangi, value); } 
     } 
     // Item Overview
     // Notes for fCreateReturn : 
     private string _totweight1; 
     [XafDisplayName("Total Weight"), ToolTip("Total Weight")] 
     // [Appearance("fCreateReturntotweight1", Enabled = true)]
     // [Appearance("fCreateReturntotweight1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string totweight1
     { 
       get { return _totweight1; } 
       set { SetPropertyValue(nameof(totweight1), ref _totweight1, value); } 
     } 
     // Order
     // Notes for fCreateReturn : 
     private string _order; 
     [XafDisplayName("Order"), ToolTip("Order")] 
     // [Appearance("fCreateReturnorder", Enabled = true)]
     // [Appearance("fCreateReturnorderVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string order
     { 
       get { return _order; } 
       set { SetPropertyValue(nameof(order), ref _order, value); } 
     } 
     // Order
     // Notes for fCreateReturn : 
     private string _reqdelivdate; 
     [XafDisplayName("Req. Deliv Date"), ToolTip("Req. Deliv Date")] 
     // [Appearance("fCreateReturnreqdelivdate", Enabled = true)]
     // [Appearance("fCreateReturnreqdelivdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string reqdelivdate
     { 
       get { return _reqdelivdate; } 
       set { SetPropertyValue(nameof(reqdelivdate), ref _reqdelivdate, value); } 
     } 
     // Organizational Data
     // Notes for fCreateReturn : 
     private string _distrchnl; 
     [XafDisplayName("Distribution Channel"), ToolTip("Distribution Channel")] 
     // [Appearance("fCreateReturndistrchnl", Enabled = true)]
     // [Appearance("fCreateReturndistrchnlVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateReturn : 
     private string _division; 
     [XafDisplayName("Division"), ToolTip("Division")] 
     // [Appearance("fCreateReturndivision", Enabled = true)]
     // [Appearance("fCreateReturndivisionVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateReturn : 
     private string _salesgroup; 
     [XafDisplayName("Sales Group"), ToolTip("Sales Group")] 
     // [Appearance("fCreateReturnsalesgroup", Enabled = true)]
     // [Appearance("fCreateReturnsalesgroupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateReturn : 
     private string _salesoffice; 
     [XafDisplayName("Sales Office"), ToolTip("Sales Office")] 
     // [Appearance("fCreateReturnsalesoffice", Enabled = true)]
     // [Appearance("fCreateReturnsalesofficeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateReturn : 
     private string _salesorgnz; 
     [XafDisplayName("Sales Organization"), ToolTip("Sales Organization")] 
     // [Appearance("fCreateReturnsalesorgnz", Enabled = true)]
     // [Appearance("fCreateReturnsalesorgnzVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string salesorgnz
     { 
       get { return _salesorgnz; } 
       set { SetPropertyValue(nameof(salesorgnz), ref _salesorgnz, value); } 
     } 
     // Predifine delivery type
     // Notes for fCreateReturn : 
     private string _delivtype; 
     [XafDisplayName("Delivery Type"), ToolTip("Delivery Type")] 
     // [Appearance("fCreateReturndelivtype", Enabled = true)]
     // [Appearance("fCreateReturndelivtypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string delivtype
     { 
       get { return _delivtype; } 
       set { SetPropertyValue(nameof(delivtype), ref _delivtype, value); } 
     } 
     // Return delivery Create: Overview
     // Notes for fCreateReturn : 
     private DateTime _docdate; 
     [XafDisplayName("Document Date"), ToolTip("Document Date")] 
     // [Appearance("fCreateReturndocdate", Enabled = true)]
     // [Appearance("fCreateReturndocdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime docdate
     { 
       get { return _docdate; } 
       set { SetPropertyValue(nameof(docdate), ref _docdate, value); } 
     } 
     // Return delivery Create: Overview
     // Notes for fCreateReturn : 
     private string _outbounddeliv; 
     [XafDisplayName("Outbound Deliv."), ToolTip("Outbound Deliv.")] 
     // [Appearance("fCreateReturnoutbounddeliv", Enabled = true)]
     // [Appearance("fCreateReturnoutbounddelivVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string outbounddeliv
     { 
       get { return _outbounddeliv; } 
       set { SetPropertyValue(nameof(outbounddeliv), ref _outbounddeliv, value); } 
     } 
     // Return delivery Create: Overview
     // Notes for fCreateReturn : 
     private string _shipparty1; 
     [XafDisplayName("Ship-To Party "), ToolTip("Ship-To Party")] 
     // [Appearance("fCreateReturnshipparty1", Enabled = true)]
     // [Appearance("fCreateReturnshipparty1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string shipparty1
     { 
       get { return _shipparty1; } 
       set { SetPropertyValue(nameof(shipparty1), ref _shipparty1, value); } 
     } 
     // Sales
     // Notes for fCreateReturn : 
     private enumBilllBlock _billblock; 
     [XafDisplayName("Billing Block"), ToolTip("Billing Block")] 
     // [Appearance("fCreateReturnbillblock", Enabled = true)]
     // [Appearance("fCreateReturnbillblockVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumBilllBlock billblock
     { 
       get { return _billblock; } 
       set { SetPropertyValue(nameof(billblock), ref _billblock, value); } 
     } 
     // Sales
     // Notes for fCreateReturn : 
     private bool _cmpltdeliv; 
     [XafDisplayName("Complete Deliv"), ToolTip("Complete Deliv")] 
     // [Appearance("fCreateReturncmpltdeliv", Enabled = true)]
     // [Appearance("fCreateReturncmpltdelivVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool cmpltdeliv
     { 
       get { return _cmpltdeliv; } 
       set { SetPropertyValue(nameof(cmpltdeliv), ref _cmpltdeliv, value); } 
     } 
     // Sales
     // Notes for fCreateReturn : 
     private enumDelivBlock _delivblock; 
     [XafDisplayName("Delivery Block"), ToolTip("Delivery Block")] 
     // [Appearance("fCreateReturndelivblock", Enabled = true)]
     // [Appearance("fCreateReturndelivblockVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumDelivBlock delivblock
     { 
       get { return _delivblock; } 
       set { SetPropertyValue(nameof(delivblock), ref _delivblock, value); } 
     } 
     // Sales
     // Notes for fCreateReturn : 
     private string _incoterms; 
     [XafDisplayName("Incoterms"), ToolTip("Incoterms")] 
     // [Appearance("fCreateReturnincoterms", Enabled = true)]
     // [Appearance("fCreateReturnincotermsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateReturn : 
     private enumOrderReason _orderreason; 
     [XafDisplayName("Order Reason"), ToolTip("Order Reason")] 
     // [Appearance("fCreateReturnorderreason", Enabled = true)]
     // [Appearance("fCreateReturnorderreasonVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumOrderReason orderreason
     { 
       get { return _orderreason; } 
       set { SetPropertyValue(nameof(orderreason), ref _orderreason, value); } 
     } 
     // Sales
     // Notes for fCreateReturn : 
     private string _paytterms; 
     [XafDisplayName("Payment Terms"), ToolTip("Payment Terms")] 
     // [Appearance("fCreateReturnpaytterms", Enabled = true)]
     // [Appearance("fCreateReturnpayttermsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateReturn : 
     private DateTime _pricdata; 
     [XafDisplayName("Pricing Date"), ToolTip("Pricing Date")] 
     // [Appearance("fCreateReturnpricdata", Enabled = true)]
     // [Appearance("fCreateReturnpricdataVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime pricdata
     { 
       get { return _pricdata; } 
       set { SetPropertyValue(nameof(pricdata), ref _pricdata, value); } 
     } 
     // Sales
     // Notes for fCreateReturn : 
     private DateTime _reqdelivdate1; 
     [XafDisplayName("Req. Deliv Date "), ToolTip("Req. Deliv Date")] 
     // [Appearance("fCreateReturnreqdelivdate1", Enabled = true)]
     // [Appearance("fCreateReturnreqdelivdate1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime reqdelivdate1
     { 
       get { return _reqdelivdate1; } 
       set { SetPropertyValue(nameof(reqdelivdate1), ref _reqdelivdate1, value); } 
     } 
     // Sales
     // Notes for fCreateReturn : 
     private string _salesarea; 
     [XafDisplayName("Sales Area"), ToolTip("Sales Area")] 
     // [Appearance("fCreateReturnsalesarea", Enabled = true)]
     // [Appearance("fCreateReturnsalesareaVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateReturn : 
     private double _totweight; 
     [XafDisplayName("Total Weight "), ToolTip("Total Weight")] 
     // [Appearance("fCreateReturntotweight", Enabled = true)]
     // [Appearance("fCreateReturntotweightVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double totweight
     { 
       get { return _totweight; } 
       set { SetPropertyValue(nameof(totweight), ref _totweight, value); } 
     } 
     // Sales
     // Notes for fCreateReturn : 
     private double _volume; 
     [XafDisplayName("Volume"), ToolTip("Volume")] 
     // [Appearance("fCreateReturnvolume", Enabled = true)]
     // [Appearance("fCreateReturnvolumeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double volume
     { 
       get { return _volume; } 
       set { SetPropertyValue(nameof(volume), ref _volume, value); } 
     } 
     // Sales order data
     // Notes for fCreateReturn : 
     private string _frmitm; 
     [XafDisplayName("From Item"), ToolTip("From Item")] 
     // [Appearance("fCreateReturnfrmitm", Enabled = true)]
     // [Appearance("fCreateReturnfrmitmVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string frmitm
     { 
       get { return _frmitm; } 
       set { SetPropertyValue(nameof(frmitm), ref _frmitm, value); } 
     } 
     // Sales order data
     // Notes for fCreateReturn : 
     private string _order1; 
     [XafDisplayName("Order "), ToolTip("Order")] 
     // [Appearance("fCreateReturnorder1", Enabled = true)]
     // [Appearance("fCreateReturnorder1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string order1
     { 
       get { return _order1; } 
       set { SetPropertyValue(nameof(order1), ref _order1, value); } 
     } 
     // Sales order data
     // Notes for fCreateReturn : 
     private DateTime _selectdate; 
     [XafDisplayName("Selection date"), ToolTip("Selection date")] 
     // [Appearance("fCreateReturnselectdate", Enabled = true)]
     // [Appearance("fCreateReturnselectdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime selectdate
     { 
       get { return _selectdate; } 
       set { SetPropertyValue(nameof(selectdate), ref _selectdate, value); } 
     } 
     // Sales order data
     // Notes for fCreateReturn : 
     private string _toitm; 
     [XafDisplayName("To Item"), ToolTip("To Item")] 
     // [Appearance("fCreateReturntoitm", Enabled = true)]
     // [Appearance("fCreateReturntoitmVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string toitm
     { 
       get { return _toitm; } 
       set { SetPropertyValue(nameof(toitm), ref _toitm, value); } 
     } 
     // Search Criteria
     // Notes for fCreateReturn : 
     private string _delivery; 
     [XafDisplayName("Delivery"), ToolTip("Delivery")] 
     // [Appearance("fCreateReturndelivery", Enabled = true)]
     // [Appearance("fCreateReturndeliveryVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string delivery
     { 
       get { return _delivery; } 
       set { SetPropertyValue(nameof(delivery), ref _delivery, value); } 
     } 
     // Search Criteria
     // Notes for fCreateReturn : 
     private string _purorder; 
     [XafDisplayName("Pur. Order "), ToolTip("Pur. Order ")] 
     // [Appearance("fCreateReturnpurorder", Enabled = true)]
     // [Appearance("fCreateReturnpurorderVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string purorder
     { 
       get { return _purorder; } 
       set { SetPropertyValue(nameof(purorder), ref _purorder, value); } 
     } 
     // Search Criteria
     // Notes for fCreateReturn : 
     private string _soldparty; 
     [XafDisplayName("Sold-To Party"), ToolTip("Sold-To Party")] 
     // [Appearance("fCreateReturnsoldparty", Enabled = true)]
     // [Appearance("fCreateReturnsoldpartyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string soldparty
     { 
       get { return _soldparty; } 
       set { SetPropertyValue(nameof(soldparty), ref _soldparty, value); } 
     } 
     // Search Criteria
     // Notes for fCreateReturn : 
     private string _wbselement; 
     [XafDisplayName("WBS Element"), ToolTip("WBS Element")] 
     // [Appearance("fCreateReturnwbselement", Enabled = true)]
     // [Appearance("fCreateReturnwbselementVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string wbselement
     { 
       get { return _wbselement; } 
       set { SetPropertyValue(nameof(wbselement), ref _wbselement, value); } 
     } 
   } 
} 
