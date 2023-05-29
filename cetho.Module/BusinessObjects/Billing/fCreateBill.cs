// Class Name : fCreateBill.cs 
// Project Name : FICO 
// Last Update : 29/05/2023 14:41:15  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 29/05/2023 14:41:14 
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
   [System.ComponentModel.DisplayName("Create material BOM: Initial Screen")]
   public class fCreateBill : XPObject
   {
     public fCreateBill(Session session) : base(session) 
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
     [Appearance("VisiblefCreateBillOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for fCreateBill : 
     private string _matl; 
     [XafDisplayName("Material"), ToolTip("Material")] 
     // [Appearance("fCreateBillmatl", Enabled = true)]
     // [Appearance("fCreateBillmatlVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string matl
     { 
       get { return _matl; } 
       set { SetPropertyValue(nameof(matl), ref _matl, value); } 
     } 
     // 
     // Notes for fCreateBill : 
     private string _plant; 
     [XafDisplayName("Plant"), ToolTip("Plant")] 
     // [Appearance("fCreateBillplant", Enabled = true)]
     // [Appearance("fCreateBillplantVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string plant
     { 
       get { return _plant; } 
       set { SetPropertyValue(nameof(plant), ref _plant, value); } 
     } 
     // 
     // Notes for fCreateBill : 
     private string _bomusage; 
     [XafDisplayName("BOM Usage"), ToolTip("BOM Usage")] 
     // [Appearance("fCreateBillbomusage", Enabled = true)]
     // [Appearance("fCreateBillbomusageVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string bomusage
     { 
       get { return _bomusage; } 
       set { SetPropertyValue(nameof(bomusage), ref _bomusage, value); } 
     } 
     // 
     // Notes for fCreateBill : 
     private string _altbom; 
     [XafDisplayName("Alternative BOM"), ToolTip("Alternative BOM")] 
     // [Appearance("fCreateBillaltbom", Enabled = true)]
     // [Appearance("fCreateBillaltbomVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string altbom
     { 
       get { return _altbom; } 
       set { SetPropertyValue(nameof(altbom), ref _altbom, value); } 
     } 
     // Material
     // Notes for fCreateBill : 
     private string _item; 
     [XafDisplayName("Item"), ToolTip("Item")] 
     // [Appearance("fCreateBillitem", Enabled = true)]
     // [Appearance("fCreateBillitemVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string item
     { 
       get { return _item; } 
       set { SetPropertyValue(nameof(item), ref _item, value); } 
     } 
     // Material
     // Notes for fCreateBill : 
     private string _ict; 
     [XafDisplayName("Ict"), ToolTip("Ict")] 
     // [Appearance("fCreateBillict", Enabled = true)]
     // [Appearance("fCreateBillictVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string ict
     { 
       get { return _ict; } 
       set { SetPropertyValue(nameof(ict), ref _ict, value); } 
     } 
     // Material
     // Notes for fCreateBill : 
     private string _comp; 
     [XafDisplayName("Component"), ToolTip("Component")] 
     // [Appearance("fCreateBillcomp", Enabled = true)]
     // [Appearance("fCreateBillcompVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string comp
     { 
       get { return _comp; } 
       set { SetPropertyValue(nameof(comp), ref _comp, value); } 
     } 
     // Material
     // Notes for fCreateBill : 
     private string _compdesc; 
     [XafDisplayName("Component Description"), ToolTip("Component description")] 
     // [Appearance("fCreateBillcompdesc", Enabled = true)]
     // [Appearance("fCreateBillcompdescVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string compdesc
     { 
       get { return _compdesc; } 
       set { SetPropertyValue(nameof(compdesc), ref _compdesc, value); } 
     } 
     // Material
     // Notes for fCreateBill : 
     private string _qty; 
     [XafDisplayName("Quantity"), ToolTip("Quantity")] 
     // [Appearance("fCreateBillqty", Enabled = true)]
     // [Appearance("fCreateBillqtyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string qty
     { 
       get { return _qty; } 
       set { SetPropertyValue(nameof(qty), ref _qty, value); } 
     } 
     // Material
     // Notes for fCreateBill : 
     private string _un; 
     [XafDisplayName("Un"), ToolTip("Un")] 
     // [Appearance("fCreateBillun", Enabled = true)]
     // [Appearance("fCreateBillunVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string un
     { 
       get { return _un; } 
       set { SetPropertyValue(nameof(un), ref _un, value); } 
     } 
   } 
} 
