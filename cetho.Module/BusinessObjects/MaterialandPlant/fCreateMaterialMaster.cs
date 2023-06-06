// Class Name : fCreateMaterialMaster.cs 
// Project Name : FICO 
// Last Update : 06/06/2023 13:56:03  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 06/06/2023 13:56:03 
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
   [System.ComponentModel.DisplayName("Create Material 9554 (Finished Product SAP)")]
   public class fCreateMaterialMaster : XPObject
   {
     public fCreateMaterialMaster(Session session) : base(session) 
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
     [Appearance("VisiblefCreateMaterialMasterOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // Basic Data 1
     // Notes for fCreateMaterialMaster : 
     private string _mat; 
     [XafDisplayName("Material"), ToolTip("Material")] 
     // [Appearance("fCreateMaterialMastermat", Enabled = true)]
     // [Appearance("fCreateMaterialMastermatVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string mat
     { 
       get { return _mat; } 
       set { SetPropertyValue(nameof(mat), ref _mat, value); } 
     } 
     // Basic Data 10
     // Notes for fCreateMaterialMaster : 
     private string _lab; 
     [XafDisplayName("Lab/Office"), ToolTip("Lab/Office")] 
     // [Appearance("fCreateMaterialMasterlab", Enabled = true)]
     // [Appearance("fCreateMaterialMasterlabVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string lab
     { 
       get { return _lab; } 
       set { SetPropertyValue(nameof(lab), ref _lab, value); } 
     } 
     // Basic Data 11
     // Notes for fCreateMaterialMaster : 
     private string _prodhierarcht; 
     [XafDisplayName("Prod. Hierarchy"), ToolTip("Prod.hierarchy")] 
     // [Appearance("fCreateMaterialMasterprodhierarcht", Enabled = true)]
     // [Appearance("fCreateMaterialMasterprodhierarchtVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string prodhierarcht
     { 
       get { return _prodhierarcht; } 
       set { SetPropertyValue(nameof(prodhierarcht), ref _prodhierarcht, value); } 
     } 
     // Basic Data 12
     // Notes for fCreateMaterialMaster : 
     private string _vldfrm; 
     [XafDisplayName("Valid From"), ToolTip("Valid from")] 
     // [Appearance("fCreateMaterialMastervldfrm", Enabled = true)]
     // [Appearance("fCreateMaterialMastervldfrmVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string vldfrm
     { 
       get { return _vldfrm; } 
       set { SetPropertyValue(nameof(vldfrm), ref _vldfrm, value); } 
     } 
     // Basic Data 13
     // Notes for fCreateMaterialMaster : 
     private string _genitemcatgroup; 
     [XafDisplayName("Gen Item Cat-Group"), ToolTip("GenItemCatGroup")] 
     // [Appearance("fCreateMaterialMastergenitemcatgroup", Enabled = true)]
     // [Appearance("fCreateMaterialMastergenitemcatgroupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string genitemcatgroup
     { 
       get { return _genitemcatgroup; } 
       set { SetPropertyValue(nameof(genitemcatgroup), ref _genitemcatgroup, value); } 
     } 
     // Basic Data 2
     // Notes for fCreateMaterialMaster : 
     private string _baseuom; 
     [XafDisplayName("Base Unit of Measure"), ToolTip("Base Unit of Measure")] 
     // [Appearance("fCreateMaterialMasterbaseuom", Enabled = true)]
     // [Appearance("fCreateMaterialMasterbaseuomVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string baseuom
     { 
       get { return _baseuom; } 
       set { SetPropertyValue(nameof(baseuom), ref _baseuom, value); } 
     } 
     // Basic Data 3
     // Notes for fCreateMaterialMaster : 
     private string _oldmatnumb; 
     [XafDisplayName("Old Material Number"), ToolTip("Old material number")] 
     // [Appearance("fCreateMaterialMasteroldmatnumb", Enabled = true)]
     // [Appearance("fCreateMaterialMasteroldmatnumbVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string oldmatnumb
     { 
       get { return _oldmatnumb; } 
       set { SetPropertyValue(nameof(oldmatnumb), ref _oldmatnumb, value); } 
     } 
     // Basic Data 4
     // Notes for fCreateMaterialMaster : 
     private string _division; 
     [XafDisplayName("Division"), ToolTip("Division")] 
     // [Appearance("fCreateMaterialMasterdivision", Enabled = true)]
     // [Appearance("fCreateMaterialMasterdivisionVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string division
     { 
       get { return _division; } 
       set { SetPropertyValue(nameof(division), ref _division, value); } 
     } 
     // Basic Data 5
     // Notes for fCreateMaterialMaster : 
     private string _prdctalloc; 
     [XafDisplayName("Product Allocation"), ToolTip("Product allocation")] 
     // [Appearance("fCreateMaterialMasterprdctalloc", Enabled = true)]
     // [Appearance("fCreateMaterialMasterprdctallocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string prdctalloc
     { 
       get { return _prdctalloc; } 
       set { SetPropertyValue(nameof(prdctalloc), ref _prdctalloc, value); } 
     } 
     // Basic Data 6
     // Notes for fCreateMaterialMaster : 
     private string _xplantmatlstatus; 
     [XafDisplayName("X-Plant Matl Status"), ToolTip("X-plant matl status")] 
     // [Appearance("fCreateMaterialMasterxplantmatlstatus", Enabled = true)]
     // [Appearance("fCreateMaterialMasterxplantmatlstatusVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string xplantmatlstatus
     { 
       get { return _xplantmatlstatus; } 
       set { SetPropertyValue(nameof(xplantmatlstatus), ref _xplantmatlstatus, value); } 
     } 
     // Basic Data 7
     // Notes for fCreateMaterialMaster : 
     private bool _assigneffectvals; 
     [XafDisplayName("Assign Effect Vals"), ToolTip("Assign effect vals")] 
     // [Appearance("fCreateMaterialMasterassigneffectvals", Enabled = true)]
     // [Appearance("fCreateMaterialMasterassigneffectvalsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool assigneffectvals
     { 
       get { return _assigneffectvals; } 
       set { SetPropertyValue(nameof(assigneffectvals), ref _assigneffectvals, value); } 
     } 
     // Basic Data 8
     // Notes for fCreateMaterialMaster : 
     private string _matgrp; 
     [XafDisplayName("Material Group"), ToolTip("Material Group")] 
     // [Appearance("fCreateMaterialMastermatgrp", Enabled = true)]
     // [Appearance("fCreateMaterialMastermatgrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string matgrp
     { 
       get { return _matgrp; } 
       set { SetPropertyValue(nameof(matgrp), ref _matgrp, value); } 
     } 
     // Basic Data 9
     // Notes for fCreateMaterialMaster : 
     private string _extmatlgrp; 
     [XafDisplayName("Ext. Matl Group"), ToolTip("Ext. Matl Group")] 
     // [Appearance("fCreateMaterialMasterextmatlgrp", Enabled = true)]
     // [Appearance("fCreateMaterialMasterextmatlgrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string extmatlgrp
     { 
       get { return _extmatlgrp; } 
       set { SetPropertyValue(nameof(extmatlgrp), ref _extmatlgrp, value); } 
     } 
     // Costing 2
     // Notes for fCreateMaterialMaster : 
     private string _matl; 
     [XafDisplayName("Material"), ToolTip("Material")] 
     // [Appearance("fCreateMaterialMastermatl", Enabled = true)]
     // [Appearance("fCreateMaterialMastermatlVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string matl
     { 
       get { return _matl; } 
       set { SetPropertyValue(nameof(matl), ref _matl, value); } 
     } 
     // Costing 2
     // Notes for fCreateMaterialMaster : 
     private double _movingprice; 
     [XafDisplayName("Moving Price"), ToolTip("Moving price")] 
     // [Appearance("fCreateMaterialMastermovingprice", Enabled = true)]
     // [Appearance("fCreateMaterialMastermovingpriceVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double movingprice
     { 
       get { return _movingprice; } 
       set { SetPropertyValue(nameof(movingprice), ref _movingprice, value); } 
     } 
     // Costing 2
     // Notes for fCreateMaterialMaster : 
     private string _period; 
     [XafDisplayName("Period/Fiscal Year"), ToolTip("Period /Fiscal Year")] 
     // [Appearance("fCreateMaterialMasterperiod", Enabled = true)]
     // [Appearance("fCreateMaterialMasterperiodVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string period
     { 
       get { return _period; } 
       set { SetPropertyValue(nameof(period), ref _period, value); } 
     } 
     // Costing 2
     // Notes for fCreateMaterialMaster : 
     private double _plannprice; 
     [XafDisplayName("Planned Price"), ToolTip("Planned price")] 
     // [Appearance("fCreateMaterialMasterplannprice", Enabled = true)]
     // [Appearance("fCreateMaterialMasterplannpriceVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double plannprice
     { 
       get { return _plannprice; } 
       set { SetPropertyValue(nameof(plannprice), ref _plannprice, value); } 
     } 
     // Costing 2
     // Notes for fCreateMaterialMaster : 
     private double _plannprice1; 
     [XafDisplayName("Planned Price 1"), ToolTip("Planned price 1")] 
     // [Appearance("fCreateMaterialMasterplannprice1", Enabled = true)]
     // [Appearance("fCreateMaterialMasterplannprice1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double plannprice1
     { 
       get { return _plannprice1; } 
       set { SetPropertyValue(nameof(plannprice1), ref _plannprice1, value); } 
     } 
     // Costing 2
     // Notes for fCreateMaterialMaster : 
     private double _plannprice2; 
     [XafDisplayName("Planned Price 2"), ToolTip("Planned price 2")] 
     // [Appearance("fCreateMaterialMasterplannprice2", Enabled = true)]
     // [Appearance("fCreateMaterialMasterplannprice2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double plannprice2
     { 
       get { return _plannprice2; } 
       set { SetPropertyValue(nameof(plannprice2), ref _plannprice2, value); } 
     } 
     // Costing 2
     // Notes for fCreateMaterialMaster : 
     private double _plannprice3; 
     [XafDisplayName("Planned Price 3"), ToolTip("Planned price 3")] 
     // [Appearance("fCreateMaterialMasterplannprice3", Enabled = true)]
     // [Appearance("fCreateMaterialMasterplannprice3Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double plannprice3
     { 
       get { return _plannprice3; } 
       set { SetPropertyValue(nameof(plannprice3), ref _plannprice3, value); } 
     } 
     // Costing 2
     // Notes for fCreateMaterialMaster : 
     private string _plnt; 
     [XafDisplayName("Plant"), ToolTip("Plant")] 
     // [Appearance("fCreateMaterialMasterplnt", Enabled = true)]
     // [Appearance("fCreateMaterialMasterplntVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string plnt
     { 
       get { return _plnt; } 
       set { SetPropertyValue(nameof(plnt), ref _plnt, value); } 
     } 
     // Costing 2
     // Notes for fCreateMaterialMaster : 
     private string _pricectrl; 
     [XafDisplayName("Price Control"), ToolTip("Price control")] 
     // [Appearance("fCreateMaterialMasterpricectrl", Enabled = true)]
     // [Appearance("fCreateMaterialMasterpricectrlVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string pricectrl
     { 
       get { return _pricectrl; } 
       set { SetPropertyValue(nameof(pricectrl), ref _pricectrl, value); } 
     } 
     // Costing 2
     // Notes for fCreateMaterialMaster : 
     private double _priceunit; 
     [XafDisplayName("Price Unit"), ToolTip("Price Unit")] 
     // [Appearance("fCreateMaterialMasterpriceunit", Enabled = true)]
     // [Appearance("fCreateMaterialMasterpriceunitVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double priceunit
     { 
       get { return _priceunit; } 
       set { SetPropertyValue(nameof(priceunit), ref _priceunit, value); } 
     } 
     // Costing 2
     // Notes for fCreateMaterialMaster : 
     private string _salesorderstk; 
     [XafDisplayName("VC: Sales Order Stk"), ToolTip("VC: Sales order stk")] 
     // [Appearance("fCreateMaterialMastersalesorderstk", Enabled = true)]
     // [Appearance("fCreateMaterialMastersalesorderstkVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string salesorderstk
     { 
       get { return _salesorderstk; } 
       set { SetPropertyValue(nameof(salesorderstk), ref _salesorderstk, value); } 
     } 
     // Costing 2
     // Notes for fCreateMaterialMaster : 
     private double _standprice; 
     [XafDisplayName("Standard Price"), ToolTip("Standard price")] 
     // [Appearance("fCreateMaterialMasterstandprice", Enabled = true)]
     // [Appearance("fCreateMaterialMasterstandpriceVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double standprice
     { 
       get { return _standprice; } 
       set { SetPropertyValue(nameof(standprice), ref _standprice, value); } 
     } 
     // Costing 2
     // Notes for fCreateMaterialMaster : 
     private string _valclass; 
     [XafDisplayName("Valuation Class"), ToolTip("Valuation Class")] 
     // [Appearance("fCreateMaterialMastervalclass", Enabled = true)]
     // [Appearance("fCreateMaterialMastervalclassVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string valclass
     { 
       get { return _valclass; } 
       set { SetPropertyValue(nameof(valclass), ref _valclass, value); } 
     } 
     // Sales: General/Plant
     // Notes for fCreateMaterialMaster : 
     private string _availcheck; 
     [XafDisplayName("Availbility Check"), ToolTip("Availbility check")] 
     // [Appearance("fCreateMaterialMasteravailcheck", Enabled = true)]
     // [Appearance("fCreateMaterialMasteravailcheckVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string availcheck
     { 
       get { return _availcheck; } 
       set { SetPropertyValue(nameof(availcheck), ref _availcheck, value); } 
     } 
     // Sales: General/Plant
     // Notes for fCreateMaterialMaster : 
     private string _baseqty; 
     [XafDisplayName("Base Qty"), ToolTip("Base qty")] 
     // [Appearance("fCreateMaterialMasterbaseqty", Enabled = true)]
     // [Appearance("fCreateMaterialMasterbaseqtyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string baseqty
     { 
       get { return _baseqty; } 
       set { SetPropertyValue(nameof(baseqty), ref _baseqty, value); } 
     } 
     // Sales: General/Plant
     // Notes for fCreateMaterialMaster : 
     private string _baseuom2; 
     [XafDisplayName("Base Unit of Measure (General)"), ToolTip("Base Unit of Measure (General)")] 
     // [Appearance("fCreateMaterialMasterbaseuom2", Enabled = true)]
     // [Appearance("fCreateMaterialMasterbaseuom2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string baseuom2
     { 
       get { return _baseuom2; } 
       set { SetPropertyValue(nameof(baseuom2), ref _baseuom2, value); } 
     } 
     // Sales: General/Plant
     // Notes for fCreateMaterialMaster : 
     private string _batchmanage; 
     [XafDisplayName("Batch Management"), ToolTip("Batch management")] 
     // [Appearance("fCreateMaterialMasterbatchmanage", Enabled = true)]
     // [Appearance("fCreateMaterialMasterbatchmanageVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string batchmanage
     { 
       get { return _batchmanage; } 
       set { SetPropertyValue(nameof(batchmanage), ref _batchmanage, value); } 
     } 
     // Sales: General/Plant
     // Notes for fCreateMaterialMaster : 
     private string _grossweight; 
     [XafDisplayName("Gross Weight"), ToolTip("Gross Weight")] 
     // [Appearance("fCreateMaterialMastergrossweight", Enabled = true)]
     // [Appearance("fCreateMaterialMastergrossweightVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string grossweight
     { 
       get { return _grossweight; } 
       set { SetPropertyValue(nameof(grossweight), ref _grossweight, value); } 
     } 
     // Sales: General/Plant
     // Notes for fCreateMaterialMaster : 
     private string _loadgrp; 
     [XafDisplayName("Loading Grp"), ToolTip("LoadingGrp")] 
     // [Appearance("fCreateMaterialMasterloadgrp", Enabled = true)]
     // [Appearance("fCreateMaterialMasterloadgrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string loadgrp
     { 
       get { return _loadgrp; } 
       set { SetPropertyValue(nameof(loadgrp), ref _loadgrp, value); } 
     } 
     // Sales: General/Plant
     // Notes for fCreateMaterialMaster : 
     private string _matl2; 
     [XafDisplayName("Material (General)"), ToolTip("Material (General)")] 
     // [Appearance("fCreateMaterialMastermatl2", Enabled = true)]
     // [Appearance("fCreateMaterialMastermatl2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string matl2
     { 
       get { return _matl2; } 
       set { SetPropertyValue(nameof(matl2), ref _matl2, value); } 
     } 
     // Sales: General/Plant
     // Notes for fCreateMaterialMaster : 
     private string _netweight; 
     [XafDisplayName("Net Weight"), ToolTip("Net Weight")] 
     // [Appearance("fCreateMaterialMasternetweight", Enabled = true)]
     // [Appearance("fCreateMaterialMasternetweightVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string netweight
     { 
       get { return _netweight; } 
       set { SetPropertyValue(nameof(netweight), ref _netweight, value); } 
     } 
     // Sales: General/Plant
     // Notes for fCreateMaterialMaster : 
     private string _plnt1; 
     [XafDisplayName("Plant (General)"), ToolTip("Plant (Sales)")] 
     // [Appearance("fCreateMaterialMasterplnt1", Enabled = true)]
     // [Appearance("fCreateMaterialMasterplnt1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string plnt1
     { 
       get { return _plnt1; } 
       set { SetPropertyValue(nameof(plnt1), ref _plnt1, value); } 
     } 
     // Sales: General/Plant
     // Notes for fCreateMaterialMaster : 
     private string _setuptime; 
     [XafDisplayName("Setup Time"), ToolTip("Setup time")] 
     // [Appearance("fCreateMaterialMastersetuptime", Enabled = true)]
     // [Appearance("fCreateMaterialMastersetuptimeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string setuptime
     { 
       get { return _setuptime; } 
       set { SetPropertyValue(nameof(setuptime), ref _setuptime, value); } 
     } 
     // Sales: General/Plant
     // Notes for fCreateMaterialMaster : 
     private string _transgrp; 
     [XafDisplayName("Trans. Grp"), ToolTip("Trans. Grp")] 
     // [Appearance("fCreateMaterialMastertransgrp", Enabled = true)]
     // [Appearance("fCreateMaterialMastertransgrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string transgrp
     { 
       get { return _transgrp; } 
       set { SetPropertyValue(nameof(transgrp), ref _transgrp, value); } 
     } 
     // Sales: sales org. 1
     // Notes for fCreateMaterialMaster : 
     private string _baseuom1; 
     [XafDisplayName("Base Unit of Measure (Sales)"), ToolTip("Base Unit of Measure (Sales)")] 
     // [Appearance("fCreateMaterialMasterbaseuom1", Enabled = true)]
     // [Appearance("fCreateMaterialMasterbaseuom1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string baseuom1
     { 
       get { return _baseuom1; } 
       set { SetPropertyValue(nameof(baseuom1), ref _baseuom1, value); } 
     } 
     // Sales: sales org. 1
     // Notes for fCreateMaterialMaster : 
     private bool _cahsdisc; 
     [XafDisplayName("Cash Discount"), ToolTip("Cash Discount")] 
     // [Appearance("fCreateMaterialMastercahsdisc", Enabled = true)]
     // [Appearance("fCreateMaterialMastercahsdiscVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool cahsdisc
     { 
       get { return _cahsdisc; } 
       set { SetPropertyValue(nameof(cahsdisc), ref _cahsdisc, value); } 
     } 
     // Sales: sales org. 1
     // Notes for fCreateMaterialMaster : 
     private string _dchainspecstts; 
     [XafDisplayName("Dchain-spec. Status"), ToolTip("Dchain-spec. status")] 
     // [Appearance("fCreateMaterialMasterdchainspecstts", Enabled = true)]
     // [Appearance("fCreateMaterialMasterdchainspecsttsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string dchainspecstts
     { 
       get { return _dchainspecstts; } 
       set { SetPropertyValue(nameof(dchainspecstts), ref _dchainspecstts, value); } 
     } 
     // Sales: sales org. 1
     // Notes for fCreateMaterialMaster : 
     private string _delivplnt; 
     [XafDisplayName("Delivering Plant"), ToolTip("Delivering Plant")] 
     // [Appearance("fCreateMaterialMasterdelivplnt", Enabled = true)]
     // [Appearance("fCreateMaterialMasterdelivplntVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string delivplnt
     { 
       get { return _delivplnt; } 
       set { SetPropertyValue(nameof(delivplnt), ref _delivplnt, value); } 
     } 
     // Sales: sales org. 1
     // Notes for fCreateMaterialMaster : 
     private string _distrchl; 
     [XafDisplayName("Distr. Chl"), ToolTip("Distr. Chl")] 
     // [Appearance("fCreateMaterialMasterdistrchl", Enabled = true)]
     // [Appearance("fCreateMaterialMasterdistrchlVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string distrchl
     { 
       get { return _distrchl; } 
       set { SetPropertyValue(nameof(distrchl), ref _distrchl, value); } 
     } 
     // Sales: sales org. 1
     // Notes for fCreateMaterialMaster : 
     private string _matl1; 
     [XafDisplayName("Material (Sales)"), ToolTip("Material (Sales)")] 
     // [Appearance("fCreateMaterialMastermatl1", Enabled = true)]
     // [Appearance("fCreateMaterialMastermatl1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string matl1
     { 
       get { return _matl1; } 
       set { SetPropertyValue(nameof(matl1), ref _matl1, value); } 
     } 
     // Sales: sales org. 1
     // Notes for fCreateMaterialMaster : 
     private string _matlgrp; 
     [XafDisplayName("Material Group"), ToolTip("Material Group")] 
     // [Appearance("fCreateMaterialMastermatlgrp", Enabled = true)]
     // [Appearance("fCreateMaterialMastermatlgrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string matlgrp
     { 
       get { return _matlgrp; } 
       set { SetPropertyValue(nameof(matlgrp), ref _matlgrp, value); } 
     } 
     // Sales: sales org. 1
     // Notes for fCreateMaterialMaster : 
     private string _salesorg; 
     [XafDisplayName("Sales Org."), ToolTip("Sales Org.")] 
     // [Appearance("fCreateMaterialMastersalesorg", Enabled = true)]
     // [Appearance("fCreateMaterialMastersalesorgVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string salesorg
     { 
       get { return _salesorg; } 
       set { SetPropertyValue(nameof(salesorg), ref _salesorg, value); } 
     } 
     // Sales: sales org. 1
     // Notes for fCreateMaterialMaster : 
     private string _salesunit; 
     [XafDisplayName("Sales Unit"), ToolTip("Sales Unit")] 
     // [Appearance("fCreateMaterialMastersalesunit", Enabled = true)]
     // [Appearance("fCreateMaterialMastersalesunitVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string salesunit
     { 
       get { return _salesunit; } 
       set { SetPropertyValue(nameof(salesunit), ref _salesunit, value); } 
     } 
     // Sales: sales org. 1
     // Notes for fCreateMaterialMaster : 
     private string _uomgrp; 
     [XafDisplayName("Unit of Measure Grp"), ToolTip("Unit of Measure Grp")] 
     // [Appearance("fCreateMaterialMasteruomgrp", Enabled = true)]
     // [Appearance("fCreateMaterialMasteruomgrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string uomgrp
     { 
       get { return _uomgrp; } 
       set { SetPropertyValue(nameof(uomgrp), ref _uomgrp, value); } 
     } 
     // Sales: sales org. 1
     // Notes for fCreateMaterialMaster : 
     private string _xdistrchainstts; 
     [XafDisplayName("X-Distr. Chain Status"), ToolTip("X-distr.chain status")] 
     // [Appearance("fCreateMaterialMasterxdistrchainstts", Enabled = true)]
     // [Appearance("fCreateMaterialMasterxdistrchainsttsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string xdistrchainstts
     { 
       get { return _xdistrchainstts; } 
       set { SetPropertyValue(nameof(xdistrchainstts), ref _xdistrchainstts, value); } 
     } 
   } 
} 
