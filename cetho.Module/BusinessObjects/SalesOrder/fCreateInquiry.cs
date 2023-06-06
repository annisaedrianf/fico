// Class Name : fCreateInquiry.cs 
// Project Name : FICO 
// Last Update : 06/06/2023 11:55:02  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 06/06/2023 11:54:58 
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
   [System.ComponentModel.DisplayName("Create Inquiry: Initial Screen")]
   public class fCreateInquiry : XPObject
   {
     public fCreateInquiry(Session session) : base(session) 
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
     [Appearance("VisiblefCreateInquiryOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // Cretae Inquiry: Overview
     // Notes for fCreateInquiry : 
     private string _inq; 
     [XafDisplayName("Inquiry"), ToolTip("Inquiry")] 
     // [Appearance("fCreateInquiryinq", Enabled = true)]
     // [Appearance("fCreateInquiryinqVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string inq
     { 
       get { return _inq; } 
       set { SetPropertyValue(nameof(inq), ref _inq, value); } 
     } 
     // Cretae Inquiry: Overview
     // Notes for fCreateInquiry : 
     private double _netval; 
     [XafDisplayName("Net Value"), ToolTip("Net Value")] 
     // [Appearance("fCreateInquirynetval", Enabled = true)]
     // [Appearance("fCreateInquirynetvalVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double netval
     { 
       get { return _netval; } 
       set { SetPropertyValue(nameof(netval), ref _netval, value); } 
     } 
     // Cretae Inquiry: Overview
     // Notes for fCreateInquiry : 
     private DateTime _podate; 
     [XafDisplayName("PO Date"), ToolTip("PO date")] 
     // [Appearance("fCreateInquirypodate", Enabled = true)]
     // [Appearance("fCreateInquirypodateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime podate
     { 
       get { return _podate; } 
       set { SetPropertyValue(nameof(podate), ref _podate, value); } 
     } 
     // Cretae Inquiry: Overview
     // Notes for fCreateInquiry : 
     private string _ponumb; 
     [XafDisplayName("PO Number"), ToolTip("PO Number")] 
     // [Appearance("fCreateInquiryponumb", Enabled = true)]
     // [Appearance("fCreateInquiryponumbVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string ponumb
     { 
       get { return _ponumb; } 
       set { SetPropertyValue(nameof(ponumb), ref _ponumb, value); } 
     } 
     // Cretae Inquiry: Overview
     // Notes for fCreateInquiry : 
     private string _shipparty; 
     [XafDisplayName("Ship-To Party"), ToolTip("Ship-To Party")] 
     // [Appearance("fCreateInquiryshipparty", Enabled = true)]
     // [Appearance("fCreateInquiryshippartyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string shipparty
     { 
       get { return _shipparty; } 
       set { SetPropertyValue(nameof(shipparty), ref _shipparty, value); } 
     } 
     // Cretae Inquiry: Overview
     // Notes for fCreateInquiry : 
     private string _soldparty; 
     [XafDisplayName("Sold-To Party"), ToolTip("Sold-To Party")] 
     // [Appearance("fCreateInquirysoldparty", Enabled = true)]
     // [Appearance("fCreateInquirysoldpartyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string soldparty
     { 
       get { return _soldparty; } 
       set { SetPropertyValue(nameof(soldparty), ref _soldparty, value); } 
     } 
     // Organizational Data
     // Notes for fCreateInquiry : 
     private string _distrchnl; 
     [XafDisplayName("Distribution Channel"), ToolTip("Distribution Channel")] 
     // [Appearance("fCreateInquirydistrchnl", Enabled = true)]
     // [Appearance("fCreateInquirydistrchnlVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateInquiry : 
     private string _division; 
     [XafDisplayName("Division"), ToolTip("Division")] 
     // [Appearance("fCreateInquirydivision", Enabled = true)]
     // [Appearance("fCreateInquirydivisionVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateInquiry : 
     private string _salesgrp; 
     [XafDisplayName("Sales Group"), ToolTip("Sales Group")] 
     // [Appearance("fCreateInquirysalesgrp", Enabled = true)]
     // [Appearance("fCreateInquirysalesgrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string salesgrp
     { 
       get { return _salesgrp; } 
       set { SetPropertyValue(nameof(salesgrp), ref _salesgrp, value); } 
     } 
     // Organizational Data
     // Notes for fCreateInquiry : 
     private string _salesoffice; 
     [XafDisplayName("Sales Office"), ToolTip("Sales Office")] 
     // [Appearance("fCreateInquirysalesoffice", Enabled = true)]
     // [Appearance("fCreateInquirysalesofficeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateInquiry : 
     private string _salesorgnz; 
     [XafDisplayName("Sales Organization"), ToolTip("Sales Organization")] 
     // [Appearance("fCreateInquirysalesorgnz", Enabled = true)]
     // [Appearance("fCreateInquirysalesorgnzVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string salesorgnz
     { 
       get { return _salesorgnz; } 
       set { SetPropertyValue(nameof(salesorgnz), ref _salesorgnz, value); } 
     } 
     // Sales
     // Notes for fCreateInquiry : 
     private bool _cmpltdlv; 
     [XafDisplayName("Complete Deliv."), ToolTip("Complete dlv.")] 
     // [Appearance("fCreateInquirycmpltdlv", Enabled = true)]
     // [Appearance("fCreateInquirycmpltdlvVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool cmpltdlv
     { 
       get { return _cmpltdlv; } 
       set { SetPropertyValue(nameof(cmpltdlv), ref _cmpltdlv, value); } 
     } 
     // Sales
     // Notes for fCreateInquiry : 
     private string _deliverplant; 
     [XafDisplayName("Deliver Plant"), ToolTip("DeliverPlant")] 
     // [Appearance("fCreateInquirydeliverplant", Enabled = true)]
     // [Appearance("fCreateInquirydeliverplantVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateInquiry : 
     private fCurrency _doccurr; 
     [XafDisplayName("Doc. Currency"), ToolTip("Doc. Currency")] 
     // [Appearance("fCreateInquirydoccurr", Enabled = true)]
     // [Appearance("fCreateInquirydoccurrVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCurrency doccurr
     { 
       get { return _doccurr; } 
       set { SetPropertyValue(nameof(doccurr), ref _doccurr, value); } 
     } 
     // Sales
     // Notes for fCreateInquiry : 
     private string _incoterms; 
     [XafDisplayName("Incoterms"), ToolTip("Incoterms")] 
     // [Appearance("fCreateInquiryincoterms", Enabled = true)]
     // [Appearance("fCreateInquiryincotermsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateInquiry : 
     private enumOrderReason _orderreason; 
     [XafDisplayName("Order Reason"), ToolTip("Order reason")] 
     // [Appearance("fCreateInquiryorderreason", Enabled = true)]
     // [Appearance("fCreateInquiryorderreasonVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumOrderReason orderreason
     { 
       get { return _orderreason; } 
       set { SetPropertyValue(nameof(orderreason), ref _orderreason, value); } 
     } 
     // Sales
     // Notes for fCreateInquiry : 
     private string _paytterms; 
     [XafDisplayName("Payment Terms"), ToolTip("Payment terms")] 
     // [Appearance("fCreateInquirypaytterms", Enabled = true)]
     // [Appearance("fCreateInquirypayttermsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateInquiry : 
     private DateTime _pricdate; 
     [XafDisplayName("Pricing Date"), ToolTip("Pricing date")] 
     // [Appearance("fCreateInquirypricdate", Enabled = true)]
     // [Appearance("fCreateInquirypricdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime pricdate
     { 
       get { return _pricdate; } 
       set { SetPropertyValue(nameof(pricdate), ref _pricdate, value); } 
     } 
     // Sales
     // Notes for fCreateInquiry : 
     private DateTime _reqdelivdate; 
     [XafDisplayName("Req. Deliv Date"), ToolTip("Req. deliv date")] 
     // [Appearance("fCreateInquiryreqdelivdate", Enabled = true)]
     // [Appearance("fCreateInquiryreqdelivdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime reqdelivdate
     { 
       get { return _reqdelivdate; } 
       set { SetPropertyValue(nameof(reqdelivdate), ref _reqdelivdate, value); } 
     } 
     // Sales
     // Notes for fCreateInquiry : 
     private string _salesarea; 
     [XafDisplayName("Sales Area"), ToolTip("Sales area")] 
     // [Appearance("fCreateInquirysalesarea", Enabled = true)]
     // [Appearance("fCreateInquirysalesareaVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateInquiry : 
     private double _totamnt; 
     [XafDisplayName("Total Amount"), ToolTip("Total amount")] 
     // [Appearance("fCreateInquirytotamnt", Enabled = true)]
     // [Appearance("fCreateInquirytotamntVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double totamnt
     { 
       get { return _totamnt; } 
       set { SetPropertyValue(nameof(totamnt), ref _totamnt, value); } 
     } 
     // Sales
     // Notes for fCreateInquiry : 
     private double _totweight; 
     [XafDisplayName("Total Weight"), ToolTip("Total Weight")] 
     // [Appearance("fCreateInquirytotweight", Enabled = true)]
     // [Appearance("fCreateInquirytotweightVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double totweight
     { 
       get { return _totweight; } 
       set { SetPropertyValue(nameof(totweight), ref _totweight, value); } 
     } 
     // Sales
     // Notes for fCreateInquiry : 
     private DateTime _vldfrm; 
     [XafDisplayName("Valid From"), ToolTip("Valid from")] 
     // [Appearance("fCreateInquiryvldfrm", Enabled = true)]
     // [Appearance("fCreateInquiryvldfrmVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime vldfrm
     { 
       get { return _vldfrm; } 
       set { SetPropertyValue(nameof(vldfrm), ref _vldfrm, value); } 
     } 
     // Sales
     // Notes for fCreateInquiry : 
     private DateTime _vldto; 
     [XafDisplayName("Valid To"), ToolTip("Valid to")] 
     // [Appearance("fCreateInquiryvldto", Enabled = true)]
     // [Appearance("fCreateInquiryvldtoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime vldto
     { 
       get { return _vldto; } 
       set { SetPropertyValue(nameof(vldto), ref _vldto, value); } 
     } 
     // 
     // Notes for fCreateInquiry : 
     private string _inqtype; 
     [XafDisplayName("Inquiry Type"), ToolTip("Inquiry Type")] 
     // [Appearance("fCreateInquiryinqtype", Enabled = true)]
     // [Appearance("fCreateInquiryinqtypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string inqtype
     { 
       get { return _inqtype; } 
       set { SetPropertyValue(nameof(inqtype), ref _inqtype, value); } 
     } 
   } 
} 
