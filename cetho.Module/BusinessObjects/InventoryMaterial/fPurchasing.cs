// Class Name : fPurchasing.cs 
// Project Name : FICO 
// Last Update : 16/06/2023 15:04:06  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 16/06/2023 15:04:06 
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
   [System.ComponentModel.DisplayName("Purchasing Transactions per Requirement Tracking Number")]
   public class fPurchasing : XPObject
   {
     public fPurchasing(Session session) : base(session) 
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
     [Appearance("VisiblefPurchasingOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for fPurchasing : 
     private string _reqtracknum; 
     [XafDisplayName("Requirement Tracking Number"), ToolTip("Requirement tracking number")] 
     // [Appearance("fPurchasingreqtracknum", Enabled = true)]
     // [Appearance("fPurchasingreqtracknumVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string reqtracknum
     { 
       get { return _reqtracknum; } 
       set { SetPropertyValue(nameof(reqtracknum), ref _reqtracknum, value); } 
     } 
     // 
     // Notes for fPurchasing : 
     private string _to1; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fPurchasingto1", Enabled = true)]
     // [Appearance("fPurchasingto1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string to1
     { 
       get { return _to1; } 
       set { SetPropertyValue(nameof(to1), ref _to1, value); } 
     } 
     // 
     // Notes for fPurchasing : 
     private string _purchasorganization; 
     [XafDisplayName("Purchasing Organization"), ToolTip("Purchasing organization")] 
     // [Appearance("fPurchasingpurchasorganization", Enabled = true)]
     // [Appearance("fPurchasingpurchasorganizationVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string purchasorganization
     { 
       get { return _purchasorganization; } 
       set { SetPropertyValue(nameof(purchasorganization), ref _purchasorganization, value); } 
     } 
     // 
     // Notes for fPurchasing : 
     private string _to2; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fPurchasingto2", Enabled = true)]
     // [Appearance("fPurchasingto2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string to2
     { 
       get { return _to2; } 
       set { SetPropertyValue(nameof(to2), ref _to2, value); } 
     } 
     // 
     // Notes for fPurchasing : 
     private string _doctype; 
     [XafDisplayName("Document Type"), ToolTip("Document Type")] 
     // [Appearance("fPurchasingdoctype", Enabled = true)]
     // [Appearance("fPurchasingdoctypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string doctype
     { 
       get { return _doctype; } 
       set { SetPropertyValue(nameof(doctype), ref _doctype, value); } 
     } 
     // 
     // Notes for fPurchasing : 
     private string _to3; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fPurchasingto3", Enabled = true)]
     // [Appearance("fPurchasingto3Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string to3
     { 
       get { return _to3; } 
       set { SetPropertyValue(nameof(to3), ref _to3, value); } 
     } 
     // 
     // Notes for fPurchasing : 
     private string _purchasgroup; 
     [XafDisplayName("Purchasing Group"), ToolTip("Purchasing Group")] 
     // [Appearance("fPurchasingpurchasgroup", Enabled = true)]
     // [Appearance("fPurchasingpurchasgroupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string purchasgroup
     { 
       get { return _purchasgroup; } 
       set { SetPropertyValue(nameof(purchasgroup), ref _purchasgroup, value); } 
     } 
     // 
     // Notes for fPurchasing : 
     private string _to4; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fPurchasingto4", Enabled = true)]
     // [Appearance("fPurchasingto4Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string to4
     { 
       get { return _to4; } 
       set { SetPropertyValue(nameof(to4), ref _to4, value); } 
     } 
     // 
     // Notes for fPurchasing : 
     private string _plant; 
     [XafDisplayName("Plant"), ToolTip("Plant")] 
     // [Appearance("fPurchasingplant", Enabled = true)]
     // [Appearance("fPurchasingplantVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string plant
     { 
       get { return _plant; } 
       set { SetPropertyValue(nameof(plant), ref _plant, value); } 
     } 
     // 
     // Notes for fPurchasing : 
     private string _to5; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fPurchasingto5", Enabled = true)]
     // [Appearance("fPurchasingto5Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string to5
     { 
       get { return _to5; } 
       set { SetPropertyValue(nameof(to5), ref _to5, value); } 
     } 
     // 
     // Notes for fPurchasing : 
     private string _supplyplant; 
     [XafDisplayName("Supplying Plant"), ToolTip("Supplying Plant")] 
     // [Appearance("fPurchasingsupplyplant", Enabled = true)]
     // [Appearance("fPurchasingsupplyplantVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string supplyplant
     { 
       get { return _supplyplant; } 
       set { SetPropertyValue(nameof(supplyplant), ref _supplyplant, value); } 
     } 
     // 
     // Notes for fPurchasing : 
     private string _to6; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fPurchasingto6", Enabled = true)]
     // [Appearance("fPurchasingto6Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string to6
     { 
       get { return _to6; } 
       set { SetPropertyValue(nameof(to6), ref _to6, value); } 
     } 
     // 
     // Notes for fPurchasing : 
     private string _itemcateg; 
     [XafDisplayName("Item Category"), ToolTip("Item Category")] 
     // [Appearance("fPurchasingitemcateg", Enabled = true)]
     // [Appearance("fPurchasingitemcategVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string itemcateg
     { 
       get { return _itemcateg; } 
       set { SetPropertyValue(nameof(itemcateg), ref _itemcateg, value); } 
     } 
     // 
     // Notes for fPurchasing : 
     private string _to7; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fPurchasingto7", Enabled = true)]
     // [Appearance("fPurchasingto7Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string to7
     { 
       get { return _to7; } 
       set { SetPropertyValue(nameof(to7), ref _to7, value); } 
     } 
     // 
     // Notes for fPurchasing : 
     private string _accassgcateg; 
     [XafDisplayName("Account Assignment Category"), ToolTip("Account Assignment Category")] 
     // [Appearance("fPurchasingaccassgcateg", Enabled = true)]
     // [Appearance("fPurchasingaccassgcategVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string accassgcateg
     { 
       get { return _accassgcateg; } 
       set { SetPropertyValue(nameof(accassgcateg), ref _accassgcateg, value); } 
     } 
     // 
     // Notes for fPurchasing : 
     private string _to8; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fPurchasingto8", Enabled = true)]
     // [Appearance("fPurchasingto8Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string to8
     { 
       get { return _to8; } 
       set { SetPropertyValue(nameof(to8), ref _to8, value); } 
     } 
     // 
     // Notes for fPurchasing : 
     private string _material; 
     [XafDisplayName("Material"), ToolTip("Material")] 
     // [Appearance("fPurchasingmaterial", Enabled = true)]
     // [Appearance("fPurchasingmaterialVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string material
     { 
       get { return _material; } 
       set { SetPropertyValue(nameof(material), ref _material, value); } 
     } 
     // 
     // Notes for fPurchasing : 
     private string _to9; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fPurchasingto9", Enabled = true)]
     // [Appearance("fPurchasingto9Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string to9
     { 
       get { return _to9; } 
       set { SetPropertyValue(nameof(to9), ref _to9, value); } 
     } 
     // 
     // Notes for fPurchasing : 
     private string _materialgrp; 
     [XafDisplayName("Material Group"), ToolTip("Material Group")] 
     // [Appearance("fPurchasingmaterialgrp", Enabled = true)]
     // [Appearance("fPurchasingmaterialgrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string materialgrp
     { 
       get { return _materialgrp; } 
       set { SetPropertyValue(nameof(materialgrp), ref _materialgrp, value); } 
     } 
     // 
     // Notes for fPurchasing : 
     private string _to10; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fPurchasingto10", Enabled = true)]
     // [Appearance("fPurchasingto10Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string to10
     { 
       get { return _to10; } 
       set { SetPropertyValue(nameof(to10), ref _to10, value); } 
     } 
     // 
     // Notes for fPurchasing : 
     private string _shorttext; 
     [XafDisplayName("Short Text"), ToolTip("Short Text")] 
     // [Appearance("fPurchasingshorttext", Enabled = true)]
     // [Appearance("fPurchasingshorttextVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string shorttext
     { 
       get { return _shorttext; } 
       set { SetPropertyValue(nameof(shorttext), ref _shorttext, value); } 
     } 
   } 
} 
