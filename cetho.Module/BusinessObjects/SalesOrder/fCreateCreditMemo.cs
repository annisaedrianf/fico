// Class Name : fCreateCreditMemo.cs 
// Project Name : FICO 
// Last Update : 06/06/2023 12:14:55  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 06/06/2023 12:14:55 
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
   [System.ComponentModel.DisplayName("Create Credit Memo Request: Overview")]
   public class fCreateCreditMemo : XPObject
   {
     public fCreateCreditMemo(Session session) : base(session) 
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
     [Appearance("VisiblefCreateCreditMemoOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for fCreateCreditMemo : 
     private string _creditmemoreq; 
     [XafDisplayName("Credit Memo Request"), ToolTip("Credit Memo Request")] 
     // [Appearance("fCreateCreditMemocreditmemoreq", Enabled = true)]
     // [Appearance("fCreateCreditMemocreditmemoreqVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string creditmemoreq
     { 
       get { return _creditmemoreq; } 
       set { SetPropertyValue(nameof(creditmemoreq), ref _creditmemoreq, value); } 
     } 
     // 
     // Notes for fCreateCreditMemo : 
     private string _soldparty; 
     [XafDisplayName("Sold-To Party"), ToolTip("Sold-To Party")] 
     // [Appearance("fCreateCreditMemosoldparty", Enabled = true)]
     // [Appearance("fCreateCreditMemosoldpartyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateCreditMemo : 
     private string _shipparty; 
     [XafDisplayName("Ship-To Party"), ToolTip("Ship-To Party")] 
     // [Appearance("fCreateCreditMemoshipparty", Enabled = true)]
     // [Appearance("fCreateCreditMemoshippartyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateCreditMemo : 
     private string _ponumb; 
     [XafDisplayName("PO Number"), ToolTip("PO Number")] 
     // [Appearance("fCreateCreditMemoponumb", Enabled = true)]
     // [Appearance("fCreateCreditMemoponumbVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateCreditMemo : 
     private double _netval; 
     [XafDisplayName("Net Value"), ToolTip("Net Value")] 
     // [Appearance("fCreateCreditMemonetval", Enabled = true)]
     // [Appearance("fCreateCreditMemonetvalVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double netval
     { 
       get { return _netval; } 
       set { SetPropertyValue(nameof(netval), ref _netval, value); } 
     } 
     // 
     // Notes for fCreateCreditMemo : 
     private DateTime _podate; 
     [XafDisplayName("PO Date"), ToolTip("PO Date")] 
     // [Appearance("fCreateCreditMemopodate", Enabled = true)]
     // [Appearance("fCreateCreditMemopodateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime podate
     { 
       get { return _podate; } 
       set { SetPropertyValue(nameof(podate), ref _podate, value); } 
     } 
     // Sales
     // Notes for fCreateCreditMemo : 
     private enumBillBlock _billblock; 
     [XafDisplayName("Billing Block"), ToolTip("Billing Block")] 
     // [Appearance("fCreateCreditMemobillblock", Enabled = true)]
     // [Appearance("fCreateCreditMemobillblockVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumBillBlock billblock
     { 
       get { return _billblock; } 
       set { SetPropertyValue(nameof(billblock), ref _billblock, value); } 
     } 
     // 
     // Notes for fCreateCreditMemo : 
     private DateTime _pricdate; 
     [XafDisplayName("Pricing Date"), ToolTip("Pricing Date")] 
     // [Appearance("fCreateCreditMemopricdate", Enabled = true)]
     // [Appearance("fCreateCreditMemopricdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime pricdate
     { 
       get { return _pricdate; } 
       set { SetPropertyValue(nameof(pricdate), ref _pricdate, value); } 
     } 
     // Sales
     // Notes for fCreateCreditMemo : 
     private enumOrderReason _orderreason; 
     [XafDisplayName("Order Reason"), ToolTip("Order Reason")] 
     // [Appearance("fCreateCreditMemoorderreason", Enabled = true)]
     // [Appearance("fCreateCreditMemoorderreasonVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumOrderReason orderreason
     { 
       get { return _orderreason; } 
       set { SetPropertyValue(nameof(orderreason), ref _orderreason, value); } 
     } 
     // Sales
     // Notes for fCreateCreditMemo : 
     private string _salesarea; 
     [XafDisplayName("Sales Area"), ToolTip("Sales Area")] 
     // [Appearance("fCreateCreditMemosalesarea", Enabled = true)]
     // [Appearance("fCreateCreditMemosalesareaVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string salesarea
     { 
       get { return _salesarea; } 
       set { SetPropertyValue(nameof(salesarea), ref _salesarea, value); } 
     } 
     // Sales
     // Notes for fCreateCreditMemo : 
     private DateTime _billdate; 
     [XafDisplayName("Billing Date"), ToolTip("Billing Date")] 
     // [Appearance("fCreateCreditMemobilldate", Enabled = true)]
     // [Appearance("fCreateCreditMemobilldateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime billdate
     { 
       get { return _billdate; } 
       set { SetPropertyValue(nameof(billdate), ref _billdate, value); } 
     } 
     // Sales
     // Notes for fCreateCreditMemo : 
     private DateTime _servrendereddate; 
     [XafDisplayName("Serv. Rendered Date"), ToolTip("Serv. Rendered Date")] 
     // [Appearance("fCreateCreditMemoservrendereddate", Enabled = true)]
     // [Appearance("fCreateCreditMemoservrendereddateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime servrendereddate
     { 
       get { return _servrendereddate; } 
       set { SetPropertyValue(nameof(servrendereddate), ref _servrendereddate, value); } 
     } 
   } 
} 
