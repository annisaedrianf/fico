// Class Name : fChangePurchase.cs 
// Project Name : FICO 
// Last Update : 14/06/2023 11:26:48  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 14/06/2023 11:26:48 
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
   [System.ComponentModel.DisplayName("Change Purchase Order")]
   public class fChangePurchase : XPObject
   {
     public fChangePurchase(Session session) : base(session) 
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
     [Appearance("VisiblefChangePurchaseOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // Select Document
     // Notes for fChangePurchase : 
     private string _po; 
     [XafDisplayName("PO"), ToolTip("PO")] 
     // [Appearance("fChangePurchasepo", Enabled = true)]
     // [Appearance("fChangePurchasepoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string po
     { 
       get { return _po; } 
       set { SetPropertyValue(nameof(po), ref _po, value); } 
     } 
     // Select Document
     // Notes for fChangePurchase : 
     private bool _po1; 
     [XafDisplayName("PO"), ToolTip("PO")] 
     // [Appearance("fChangePurchasepo1", Enabled = true)]
     // [Appearance("fChangePurchasepo1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool po1
     { 
       get { return _po1; } 
       set { SetPropertyValue(nameof(po1), ref _po1, value); } 
     } 
     // Select Document
     // Notes for fChangePurchase : 
     private bool _purchrequistion; 
     [XafDisplayName("Purch. Requistion"), ToolTip("Purch. Requistion")] 
     // [Appearance("fChangePurchasepurchrequistion", Enabled = true)]
     // [Appearance("fChangePurchasepurchrequistionVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool purchrequistion
     { 
       get { return _purchrequistion; } 
       set { SetPropertyValue(nameof(purchrequistion), ref _purchrequistion, value); } 
     } 
     // Document Overview On
     // Notes for fChangePurchase : 
     private fVendor _vendor; 
     [XafDisplayName("Vendor"), ToolTip("Vendor")] 
     // [Appearance("fChangePurchasevendor", Enabled = true)]
     // [Appearance("fChangePurchasevendorVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fVendor vendor
     { 
       get { return _vendor; } 
       set { SetPropertyValue(nameof(vendor), ref _vendor, value); } 
     } 
     // Document Overview On
     // Notes for fChangePurchase : 
     private DateTime _docdate; 
     [XafDisplayName("Doc. Date"), ToolTip("Doc. Date")] 
     // [Appearance("fChangePurchasedocdate", Enabled = true)]
     // [Appearance("fChangePurchasedocdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime docdate
     { 
       get { return _docdate; } 
       set { SetPropertyValue(nameof(docdate), ref _docdate, value); } 
     } 
     // Document Overview On
     // Notes for fChangePurchase : 
     private string _itm; 
     [XafDisplayName("Item"), ToolTip("Item")] 
     // [Appearance("fChangePurchaseitm", Enabled = true)]
     // [Appearance("fChangePurchaseitmVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string itm
     { 
       get { return _itm; } 
       set { SetPropertyValue(nameof(itm), ref _itm, value); } 
     } 
     // Document Overview On
     // Notes for fChangePurchase : 
     private string _material; 
     [XafDisplayName("Material"), ToolTip("Material")] 
     // [Appearance("fChangePurchasematerial", Enabled = true)]
     // [Appearance("fChangePurchasematerialVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string material
     { 
       get { return _material; } 
       set { SetPropertyValue(nameof(material), ref _material, value); } 
     } 
     // Document Overview On
     // Notes for fChangePurchase : 
     private string _shorttext; 
     [XafDisplayName("Short Text"), ToolTip("Short Text")] 
     // [Appearance("fChangePurchaseshorttext", Enabled = true)]
     // [Appearance("fChangePurchaseshorttextVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string shorttext
     { 
       get { return _shorttext; } 
       set { SetPropertyValue(nameof(shorttext), ref _shorttext, value); } 
     } 
     // Document Overview On
     // Notes for fChangePurchase : 
     private string _poqty; 
     [XafDisplayName("PO Quantity"), ToolTip("PO Quantity")] 
     // [Appearance("fChangePurchasepoqty", Enabled = true)]
     // [Appearance("fChangePurchasepoqtyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string poqty
     { 
       get { return _poqty; } 
       set { SetPropertyValue(nameof(poqty), ref _poqty, value); } 
     } 
     // Document Overview On
     // Notes for fChangePurchase : 
     private string _ordertype; 
     [XafDisplayName("Order Type"), ToolTip("Order Type")] 
     // [Appearance("fChangePurchaseordertype", Enabled = true)]
     // [Appearance("fChangePurchaseordertypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string ordertype
     { 
       get { return _ordertype; } 
       set { SetPropertyValue(nameof(ordertype), ref _ordertype, value); } 
     } 
     // Document Overview On
     // Notes for fChangePurchase : 
     private DateTime _delivdate; 
     [XafDisplayName("Deliv. Date"), ToolTip("Deliv. Date")] 
     // [Appearance("fChangePurchasedelivdate", Enabled = true)]
     // [Appearance("fChangePurchasedelivdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime delivdate
     { 
       get { return _delivdate; } 
       set { SetPropertyValue(nameof(delivdate), ref _delivdate, value); } 
     } 
     // Document Overview On
     // Notes for fChangePurchase : 
     private double _netprice; 
     [XafDisplayName("Net Price"), ToolTip("Net Price")] 
     // [Appearance("fChangePurchasenetprice", Enabled = true)]
     // [Appearance("fChangePurchasenetpriceVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double netprice
     { 
       get { return _netprice; } 
       set { SetPropertyValue(nameof(netprice), ref _netprice, value); } 
     } 
     // Document Overview On
     // Notes for fChangePurchase : 
     private fCurrency _currency; 
     [XafDisplayName("Currency"), ToolTip("Currency")] 
     // [Appearance("fChangePurchasecurrency", Enabled = true)]
     // [Appearance("fChangePurchasecurrencyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCurrency currency
     { 
       get { return _currency; } 
       set { SetPropertyValue(nameof(currency), ref _currency, value); } 
     } 
   } 
} 
