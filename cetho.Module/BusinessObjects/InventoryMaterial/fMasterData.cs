// Class Name : fMasterData.cs 
// Project Name : FICO 
// Last Update : 16/06/2023 14:14:33  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 16/06/2023 14:14:29 
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
   [System.ComponentModel.DisplayName("Materials List")]
   public class fMasterData : XPObject
   {
     public fMasterData(Session session) : base(session) 
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
     [Appearance("VisiblefMasterDataOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // Database selections
     // Notes for fMasterData : 
     private string _material; 
     [XafDisplayName("Material"), ToolTip("Material")] 
     // [Appearance("fMasterDatamaterial", Enabled = true)]
     // [Appearance("fMasterDatamaterialVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string material
     { 
       get { return _material; } 
       set { SetPropertyValue(nameof(material), ref _material, value); } 
     } 
     // Database selections
     // Notes for fMasterData : 
     private string _to1; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fMasterDatato1", Enabled = true)]
     // [Appearance("fMasterDatato1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string to1
     { 
       get { return _to1; } 
       set { SetPropertyValue(nameof(to1), ref _to1, value); } 
     } 
     // Database selections
     // Notes for fMasterData : 
     private string _plant; 
     [XafDisplayName("Plant"), ToolTip("Plant")] 
     // [Appearance("fMasterDataplant", Enabled = true)]
     // [Appearance("fMasterDataplantVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string plant
     { 
       get { return _plant; } 
       set { SetPropertyValue(nameof(plant), ref _plant, value); } 
     } 
     // Database selections
     // Notes for fMasterData : 
     private string _to2; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fMasterDatato2", Enabled = true)]
     // [Appearance("fMasterDatato2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string to2
     { 
       get { return _to2; } 
       set { SetPropertyValue(nameof(to2), ref _to2, value); } 
     } 
     // Database selections
     // Notes for fMasterData : 
     private string _materialtype; 
     [XafDisplayName("Material Type"), ToolTip("Material type")] 
     // [Appearance("fMasterDatamaterialtype", Enabled = true)]
     // [Appearance("fMasterDatamaterialtypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string materialtype
     { 
       get { return _materialtype; } 
       set { SetPropertyValue(nameof(materialtype), ref _materialtype, value); } 
     } 
     // Database selections
     // Notes for fMasterData : 
     private string _to3; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fMasterDatato3", Enabled = true)]
     // [Appearance("fMasterDatato3Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string to3
     { 
       get { return _to3; } 
       set { SetPropertyValue(nameof(to3), ref _to3, value); } 
     } 
     // Database selections
     // Notes for fMasterData : 
     private string _materialgroup; 
     [XafDisplayName("Material Group"), ToolTip("Material group")] 
     // [Appearance("fMasterDatamaterialgroup", Enabled = true)]
     // [Appearance("fMasterDatamaterialgroupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string materialgroup
     { 
       get { return _materialgroup; } 
       set { SetPropertyValue(nameof(materialgroup), ref _materialgroup, value); } 
     } 
     // Database selections
     // Notes for fMasterData : 
     private string _to4; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fMasterDatato4", Enabled = true)]
     // [Appearance("fMasterDatato4Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string to4
     { 
       get { return _to4; } 
       set { SetPropertyValue(nameof(to4), ref _to4, value); } 
     } 
     // Database selections
     // Notes for fMasterData : 
     private string _createdby; 
     [XafDisplayName("Created by"), ToolTip("Created by")] 
     // [Appearance("fMasterDatacreatedby", Enabled = true)]
     // [Appearance("fMasterDatacreatedbyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(15)] 
     public  string createdby
     { 
       get { return _createdby; } 
       set { SetPropertyValue(nameof(createdby), ref _createdby, value); } 
     } 
     // Database selections
     // Notes for fMasterData : 
     private string _to5; 
     [XafDisplayName("to"), ToolTip("to")] 
     // [Appearance("fMasterDatato5", Enabled = true)]
     // [Appearance("fMasterDatato5Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(15)] 
     public  string to5
     { 
       get { return _to5; } 
       set { SetPropertyValue(nameof(to5), ref _to5, value); } 
     } 
     // Database selections
     // Notes for fMasterData : 
     private bool _valuatedmaterialsonly; 
     [XafDisplayName("Valuated Materials Only"), ToolTip("Valuated materials only")] 
     // [Appearance("fMasterDatavaluatedmaterialsonly", Enabled = true)]
     // [Appearance("fMasterDatavaluatedmaterialsonlyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool valuatedmaterialsonly
     { 
       get { return _valuatedmaterialsonly; } 
       set { SetPropertyValue(nameof(valuatedmaterialsonly), ref _valuatedmaterialsonly, value); } 
     } 
     // Basic data 1
     // Notes for fMasterData : 
     private string _material1; 
     [XafDisplayName("Material"), ToolTip("Material")] 
     // [Appearance("fMasterDatamaterial1", Enabled = true)]
     // [Appearance("fMasterDatamaterial1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string material1
     { 
       get { return _material1; } 
       set { SetPropertyValue(nameof(material1), ref _material1, value); } 
     } 
     // Basic data 1
     // Notes for fMasterData : 
     private string _baseofmeasure; 
     [XafDisplayName("Base Unit of Measure"), ToolTip("Base Unit of Measure")] 
     // [Appearance("fMasterDatabaseofmeasure", Enabled = true)]
     // [Appearance("fMasterDatabaseofmeasureVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string baseofmeasure
     { 
       get { return _baseofmeasure; } 
       set { SetPropertyValue(nameof(baseofmeasure), ref _baseofmeasure, value); } 
     } 
     // Basic data 1
     // Notes for fMasterData : 
     private string _materialgroup1; 
     [XafDisplayName("Material Group"), ToolTip("Material Group")] 
     // [Appearance("fMasterDatamaterialgroup1", Enabled = true)]
     // [Appearance("fMasterDatamaterialgroup1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string materialgroup1
     { 
       get { return _materialgroup1; } 
       set { SetPropertyValue(nameof(materialgroup1), ref _materialgroup1, value); } 
     } 
     // Basic data 1
     // Notes for fMasterData : 
     private string _oldmaterialnumber; 
     [XafDisplayName("Old Material Number"), ToolTip("Old material number")] 
     // [Appearance("fMasterDataoldmaterialnumber", Enabled = true)]
     // [Appearance("fMasterDataoldmaterialnumberVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string oldmaterialnumber
     { 
       get { return _oldmaterialnumber; } 
       set { SetPropertyValue(nameof(oldmaterialnumber), ref _oldmaterialnumber, value); } 
     } 
     // Basic data 1
     // Notes for fMasterData : 
     private string _extmatlgroup; 
     [XafDisplayName("Ext. Matl Group"), ToolTip("Ext. Matl Group")] 
     // [Appearance("fMasterDataextmatlgroup", Enabled = true)]
     // [Appearance("fMasterDataextmatlgroupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string extmatlgroup
     { 
       get { return _extmatlgroup; } 
       set { SetPropertyValue(nameof(extmatlgroup), ref _extmatlgroup, value); } 
     } 
     // Basic data 1
     // Notes for fMasterData : 
     private string _division; 
     [XafDisplayName("Division"), ToolTip("Division")] 
     // [Appearance("fMasterDatadivision", Enabled = true)]
     // [Appearance("fMasterDatadivisionVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string division
     { 
       get { return _division; } 
       set { SetPropertyValue(nameof(division), ref _division, value); } 
     } 
     // Basic data 1
     // Notes for fMasterData : 
     private string _laboffice; 
     [XafDisplayName("Lab/Office"), ToolTip("Lab/Office")] 
     // [Appearance("fMasterDatalaboffice", Enabled = true)]
     // [Appearance("fMasterDatalabofficeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string laboffice
     { 
       get { return _laboffice; } 
       set { SetPropertyValue(nameof(laboffice), ref _laboffice, value); } 
     } 
     // Basic data 1
     // Notes for fMasterData : 
     private string _productallocation; 
     [XafDisplayName("Product Allocation"), ToolTip("Product allocation")] 
     // [Appearance("fMasterDataproductallocation", Enabled = true)]
     // [Appearance("fMasterDataproductallocationVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string productallocation
     { 
       get { return _productallocation; } 
       set { SetPropertyValue(nameof(productallocation), ref _productallocation, value); } 
     } 
     // Basic data 1
     // Notes for fMasterData : 
     private string _prodhierarchy; 
     [XafDisplayName("Prod. Hierarchy"), ToolTip("Prod.hierarchy")] 
     // [Appearance("fMasterDataprodhierarchy", Enabled = true)]
     // [Appearance("fMasterDataprodhierarchyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string prodhierarchy
     { 
       get { return _prodhierarchy; } 
       set { SetPropertyValue(nameof(prodhierarchy), ref _prodhierarchy, value); } 
     } 
     // Basic data 1
     // Notes for fMasterData : 
     private string _xmatlstatus; 
     [XafDisplayName("X-plant Matl Status"), ToolTip("X-plant matl status")] 
     // [Appearance("fMasterDataxmatlstatus", Enabled = true)]
     // [Appearance("fMasterDataxmatlstatusVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string xmatlstatus
     { 
       get { return _xmatlstatus; } 
       set { SetPropertyValue(nameof(xmatlstatus), ref _xmatlstatus, value); } 
     } 
     // Basic data 1
     // Notes for fMasterData : 
     private DateTime _validfrom; 
     [XafDisplayName("Valid From"), ToolTip("Valid from")] 
     // [Appearance("fMasterDatavalidfrom", Enabled = true)]
     // [Appearance("fMasterDatavalidfromVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime validfrom
     { 
       get { return _validfrom; } 
       set { SetPropertyValue(nameof(validfrom), ref _validfrom, value); } 
     } 
     // Basic data 1
     // Notes for fMasterData : 
     private bool _assigneffectvals; 
     [XafDisplayName("Assign Effect. Vals"), ToolTip("Assign effect. Vals")] 
     // [Appearance("fMasterDataassigneffectvals", Enabled = true)]
     // [Appearance("fMasterDataassigneffectvalsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool assigneffectvals
     { 
       get { return _assigneffectvals; } 
       set { SetPropertyValue(nameof(assigneffectvals), ref _assigneffectvals, value); } 
     } 
     // Basic data 1
     // Notes for fMasterData : 
     private string _genitemcatgroup; 
     [XafDisplayName("Gen Item Cat Group"), ToolTip("GenItemCatGroup")] 
     // [Appearance("fMasterDatagenitemcatgroup", Enabled = true)]
     // [Appearance("fMasterDatagenitemcatgroupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string genitemcatgroup
     { 
       get { return _genitemcatgroup; } 
       set { SetPropertyValue(nameof(genitemcatgroup), ref _genitemcatgroup, value); } 
     } 
   } 
} 
