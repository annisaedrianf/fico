// Class Name : fCopyMaterial.cs 
// Project Name : FICO 
// Last Update : 16/06/2023 14:17:44  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 16/06/2023 14:17:44 
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
   [System.ComponentModel.DisplayName("Copy Material Master")]
   public class fCopyMaterial : XPObject
   {
     public fCopyMaterial(Session session) : base(session) 
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
     [Appearance("VisiblefCopyMaterialOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // Organizational levels
     // Notes for fCopyMaterial : 
     private string _plant; 
     [XafDisplayName("Plant"), ToolTip("Plant")] 
     // [Appearance("fCopyMaterialplant", Enabled = true)]
     // [Appearance("fCopyMaterialplantVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string plant
     { 
       get { return _plant; } 
       set { SetPropertyValue(nameof(plant), ref _plant, value); } 
     } 
     // Organizational levels
     // Notes for fCopyMaterial : 
     private string _storloc; 
     [XafDisplayName("Stor. Location"), ToolTip("Stor. Location")] 
     // [Appearance("fCopyMaterialstorloc", Enabled = true)]
     // [Appearance("fCopyMaterialstorlocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string storloc
     { 
       get { return _storloc; } 
       set { SetPropertyValue(nameof(storloc), ref _storloc, value); } 
     } 
     // Organizational levels
     // Notes for fCopyMaterial : 
     private string _salesorg; 
     [XafDisplayName("Sales Org."), ToolTip("Sales Org.")] 
     // [Appearance("fCopyMaterialsalesorg", Enabled = true)]
     // [Appearance("fCopyMaterialsalesorgVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string salesorg
     { 
       get { return _salesorg; } 
       set { SetPropertyValue(nameof(salesorg), ref _salesorg, value); } 
     } 
     // Organizational levels
     // Notes for fCopyMaterial : 
     private string _distrchnl; 
     [XafDisplayName("Distr. Channel"), ToolTip("Distr. Channel")] 
     // [Appearance("fCopyMaterialdistrchnl", Enabled = true)]
     // [Appearance("fCopyMaterialdistrchnlVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string distrchnl
     { 
       get { return _distrchnl; } 
       set { SetPropertyValue(nameof(distrchnl), ref _distrchnl, value); } 
     } 
     // Organizational levels
     // Notes for fCopyMaterial : 
     private string _warehouseno; 
     [XafDisplayName("Warehouse No."), ToolTip("Warehouse No.")] 
     // [Appearance("fCopyMaterialwarehouseno", Enabled = true)]
     // [Appearance("fCopyMaterialwarehousenoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string warehouseno
     { 
       get { return _warehouseno; } 
       set { SetPropertyValue(nameof(warehouseno), ref _warehouseno, value); } 
     } 
     // Organizational levels
     // Notes for fCopyMaterial : 
     private string _storagetype; 
     [XafDisplayName("Storage Type"), ToolTip("Storage Type")] 
     // [Appearance("fCopyMaterialstoragetype", Enabled = true)]
     // [Appearance("fCopyMaterialstoragetypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string storagetype
     { 
       get { return _storagetype; } 
       set { SetPropertyValue(nameof(storagetype), ref _storagetype, value); } 
     } 
     // Profiles
     // Notes for fCopyMaterial : 
     private string _mrpprofile; 
     [XafDisplayName("MRP Profile"), ToolTip("MRP profile")] 
     // [Appearance("fCopyMaterialmrpprofile", Enabled = true)]
     // [Appearance("fCopyMaterialmrpprofileVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string mrpprofile
     { 
       get { return _mrpprofile; } 
       set { SetPropertyValue(nameof(mrpprofile), ref _mrpprofile, value); } 
     } 
     // Profiles
     // Notes for fCopyMaterial : 
     private string _forecastprof; 
     [XafDisplayName("Forecast Prof."), ToolTip("Forecast prof.")] 
     // [Appearance("fCopyMaterialforecastprof", Enabled = true)]
     // [Appearance("fCopyMaterialforecastprofVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string forecastprof
     { 
       get { return _forecastprof; } 
       set { SetPropertyValue(nameof(forecastprof), ref _forecastprof, value); } 
     } 
     // 
     // Notes for fCopyMaterial : 
     private bool _orglevels; 
     [XafDisplayName("Org. Levels/Profiles only on Request"), ToolTip("Org. levels/profiles only on request")] 
     // [Appearance("fCopyMaterialorglevels", Enabled = true)]
     // [Appearance("fCopyMaterialorglevelsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool orglevels
     { 
       get { return _orglevels; } 
       set { SetPropertyValue(nameof(orglevels), ref _orglevels, value); } 
     } 
     // Basic data 1
     // Notes for fCopyMaterial : 
     private string _material; 
     [XafDisplayName("Material"), ToolTip("Material")] 
     // [Appearance("fCopyMaterialmaterial", Enabled = true)]
     // [Appearance("fCopyMaterialmaterialVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string material
     { 
       get { return _material; } 
       set { SetPropertyValue(nameof(material), ref _material, value); } 
     } 
     // General data
     // Notes for fCopyMaterial : 
     private string _baseunitmeasure; 
     [XafDisplayName("Base Unit of Measure"), ToolTip("Base Unit of Measure")] 
     // [Appearance("fCopyMaterialbaseunitmeasure", Enabled = true)]
     // [Appearance("fCopyMaterialbaseunitmeasureVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string baseunitmeasure
     { 
       get { return _baseunitmeasure; } 
       set { SetPropertyValue(nameof(baseunitmeasure), ref _baseunitmeasure, value); } 
     } 
     // General data
     // Notes for fCopyMaterial : 
     private string _matlgrp; 
     [XafDisplayName("Material Goup"), ToolTip("Material Goup")] 
     // [Appearance("fCopyMaterialmatlgrp", Enabled = true)]
     // [Appearance("fCopyMaterialmatlgrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string matlgrp
     { 
       get { return _matlgrp; } 
       set { SetPropertyValue(nameof(matlgrp), ref _matlgrp, value); } 
     } 
     // General data
     // Notes for fCopyMaterial : 
     private string _oldmatlnumb; 
     [XafDisplayName("Old Material Number"), ToolTip("Old Material number")] 
     // [Appearance("fCopyMaterialoldmatlnumb", Enabled = true)]
     // [Appearance("fCopyMaterialoldmatlnumbVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string oldmatlnumb
     { 
       get { return _oldmatlnumb; } 
       set { SetPropertyValue(nameof(oldmatlnumb), ref _oldmatlnumb, value); } 
     } 
     // General data
     // Notes for fCopyMaterial : 
     private string _extmatlgrp; 
     [XafDisplayName("Ext. Matl Group"), ToolTip("Ext. Matl Group")] 
     // [Appearance("fCopyMaterialextmatlgrp", Enabled = true)]
     // [Appearance("fCopyMaterialextmatlgrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string extmatlgrp
     { 
       get { return _extmatlgrp; } 
       set { SetPropertyValue(nameof(extmatlgrp), ref _extmatlgrp, value); } 
     } 
     // General data
     // Notes for fCopyMaterial : 
     private string _division; 
     [XafDisplayName("Division"), ToolTip("Division")] 
     // [Appearance("fCopyMaterialdivision", Enabled = true)]
     // [Appearance("fCopyMaterialdivisionVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string division
     { 
       get { return _division; } 
       set { SetPropertyValue(nameof(division), ref _division, value); } 
     } 
     // General data
     // Notes for fCopyMaterial : 
     private string _laboffice; 
     [XafDisplayName("Lab/Office"), ToolTip("Lab/Office")] 
     // [Appearance("fCopyMateriallaboffice", Enabled = true)]
     // [Appearance("fCopyMateriallabofficeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string laboffice
     { 
       get { return _laboffice; } 
       set { SetPropertyValue(nameof(laboffice), ref _laboffice, value); } 
     } 
     // General data
     // Notes for fCopyMaterial : 
     private string _prodtallocation; 
     [XafDisplayName("Product Allocation"), ToolTip("Product allocation")] 
     // [Appearance("fCopyMaterialprodtallocation", Enabled = true)]
     // [Appearance("fCopyMaterialprodtallocationVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string prodtallocation
     { 
       get { return _prodtallocation; } 
       set { SetPropertyValue(nameof(prodtallocation), ref _prodtallocation, value); } 
     } 
     // General data
     // Notes for fCopyMaterial : 
     private string _prodhierarchy; 
     [XafDisplayName("Prod. Hierarchy"), ToolTip("Prod.hierarchy")] 
     // [Appearance("fCopyMaterialprodhierarchy", Enabled = true)]
     // [Appearance("fCopyMaterialprodhierarchyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string prodhierarchy
     { 
       get { return _prodhierarchy; } 
       set { SetPropertyValue(nameof(prodhierarchy), ref _prodhierarchy, value); } 
     } 
     // General data
     // Notes for fCopyMaterial : 
     private string _xplantmatlsts; 
     [XafDisplayName("X-plant Matl Status"), ToolTip("X-plant matl status")] 
     // [Appearance("fCopyMaterialxplantmatlsts", Enabled = true)]
     // [Appearance("fCopyMaterialxplantmatlstsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string xplantmatlsts
     { 
       get { return _xplantmatlsts; } 
       set { SetPropertyValue(nameof(xplantmatlsts), ref _xplantmatlsts, value); } 
     } 
     // General data
     // Notes for fCopyMaterial : 
     private string _validfrom; 
     [XafDisplayName("Valid From"), ToolTip("Valid from")] 
     // [Appearance("fCopyMaterialvalidfrom", Enabled = true)]
     // [Appearance("fCopyMaterialvalidfromVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string validfrom
     { 
       get { return _validfrom; } 
       set { SetPropertyValue(nameof(validfrom), ref _validfrom, value); } 
     } 
     // General data
     // Notes for fCopyMaterial : 
     private bool _assigneffecrvals; 
     [XafDisplayName("Assign Effecr. Vals"), ToolTip("Assign effecr. Vals")] 
     // [Appearance("fCopyMaterialassigneffecrvals", Enabled = true)]
     // [Appearance("fCopyMaterialassigneffecrvalsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool assigneffecrvals
     { 
       get { return _assigneffecrvals; } 
       set { SetPropertyValue(nameof(assigneffecrvals), ref _assigneffecrvals, value); } 
     } 
     // General data
     // Notes for fCopyMaterial : 
     private string _genitemcatgroup; 
     [XafDisplayName("Gen Item Cat Group"), ToolTip("GenItemCatGroup")] 
     // [Appearance("fCopyMaterialgenitemcatgroup", Enabled = true)]
     // [Appearance("fCopyMaterialgenitemcatgroupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string genitemcatgroup
     { 
       get { return _genitemcatgroup; } 
       set { SetPropertyValue(nameof(genitemcatgroup), ref _genitemcatgroup, value); } 
     } 
     // Material authorization group
     // Notes for fCopyMaterial : 
     private string _authogrp; 
     [XafDisplayName("Authorization Group"), ToolTip("Authorization Group")] 
     // [Appearance("fCopyMaterialauthogrp", Enabled = true)]
     // [Appearance("fCopyMaterialauthogrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string authogrp
     { 
       get { return _authogrp; } 
       set { SetPropertyValue(nameof(authogrp), ref _authogrp, value); } 
     } 
     // Dimensions/EANs
     // Notes for fCopyMaterial : 
     private double _grossweight; 
     [XafDisplayName("Gross Weight"), ToolTip("Gross Weight")] 
     // [Appearance("fCopyMaterialgrossweight", Enabled = true)]
     // [Appearance("fCopyMaterialgrossweightVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double grossweight
     { 
       get { return _grossweight; } 
       set { SetPropertyValue(nameof(grossweight), ref _grossweight, value); } 
     } 
     // Dimensions/EANs
     // Notes for fCopyMaterial : 
     private string _weightunt; 
     [XafDisplayName("Weight Unit"), ToolTip("Weight unit")] 
     // [Appearance("fCopyMaterialweightunt", Enabled = true)]
     // [Appearance("fCopyMaterialweightuntVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string weightunt
     { 
       get { return _weightunt; } 
       set { SetPropertyValue(nameof(weightunt), ref _weightunt, value); } 
     } 
     // Dimensions/EANs
     // Notes for fCopyMaterial : 
     private double _netweight; 
     [XafDisplayName("Net Weight"), ToolTip("Net Weight")] 
     // [Appearance("fCopyMaterialnetweight", Enabled = true)]
     // [Appearance("fCopyMaterialnetweightVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double netweight
     { 
       get { return _netweight; } 
       set { SetPropertyValue(nameof(netweight), ref _netweight, value); } 
     } 
     // Dimensions/EANs
     // Notes for fCopyMaterial : 
     private string _volume; 
     [XafDisplayName("Volume"), ToolTip("Volume")] 
     // [Appearance("fCopyMaterialvolume", Enabled = true)]
     // [Appearance("fCopyMaterialvolumeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string volume
     { 
       get { return _volume; } 
       set { SetPropertyValue(nameof(volume), ref _volume, value); } 
     } 
     // Dimensions/EANs
     // Notes for fCopyMaterial : 
     private string _volunit; 
     [XafDisplayName("Volume Unit"), ToolTip("Volume unit")] 
     // [Appearance("fCopyMaterialvolunit", Enabled = true)]
     // [Appearance("fCopyMaterialvolunitVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string volunit
     { 
       get { return _volunit; } 
       set { SetPropertyValue(nameof(volunit), ref _volunit, value); } 
     } 
     // Dimensions/EANs
     // Notes for fCopyMaterial : 
     private string _size; 
     [XafDisplayName("Size/Dimensions"), ToolTip("Size/dimensions")] 
     // [Appearance("fCopyMaterialsize", Enabled = true)]
     // [Appearance("fCopyMaterialsizeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string size
     { 
       get { return _size; } 
       set { SetPropertyValue(nameof(size), ref _size, value); } 
     } 
     // Dimensions/EANs
     // Notes for fCopyMaterial : 
     private string _ean; 
     [XafDisplayName("EAN/UPC"), ToolTip("EAN/UPC")] 
     // [Appearance("fCopyMaterialean", Enabled = true)]
     // [Appearance("fCopyMaterialeanVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string ean
     { 
       get { return _ean; } 
       set { SetPropertyValue(nameof(ean), ref _ean, value); } 
     } 
     // Dimensions/EANs
     // Notes for fCopyMaterial : 
     private string _eancateg; 
     [XafDisplayName("EAN Category"), ToolTip("EAN Category")] 
     // [Appearance("fCopyMaterialeancateg", Enabled = true)]
     // [Appearance("fCopyMaterialeancategVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string eancateg
     { 
       get { return _eancateg; } 
       set { SetPropertyValue(nameof(eancateg), ref _eancateg, value); } 
     } 
   } 
} 
