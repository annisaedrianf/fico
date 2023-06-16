// Class Name : fChangeMaterialMaster.cs 
// Project Name : FICO 
// Last Update : 16/06/2023 14:16:10  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 16/06/2023 14:16:10 
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
   [System.ComponentModel.DisplayName("Change Material (Initial Screen)")]
   public class fChangeMaterialMaster : XPObject
   {
     public fChangeMaterialMaster(Session session) : base(session) 
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
     [Appearance("VisiblefChangeMaterialMasterOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for fChangeMaterialMaster : 
     private string _material; 
     [XafDisplayName("Material"), ToolTip("Material")] 
     // [Appearance("fChangeMaterialMastermaterial", Enabled = true)]
     // [Appearance("fChangeMaterialMastermaterialVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fChangeMaterialMaster : 
     private string _changenumber; 
     [XafDisplayName("Change Number"), ToolTip("Change Number")] 
     // [Appearance("fChangeMaterialMasterchangenumber", Enabled = true)]
     // [Appearance("fChangeMaterialMasterchangenumberVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string changenumber
     { 
       get { return _changenumber; } 
       set { SetPropertyValue(nameof(changenumber), ref _changenumber, value); } 
     } 
     // Organizational Levels
     // Notes for fChangeMaterialMaster : 
     private string _plant; 
     [XafDisplayName("Plant"), ToolTip("Plant")] 
     // [Appearance("fChangeMaterialMasterplant", Enabled = true)]
     // [Appearance("fChangeMaterialMasterplantVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string plant
     { 
       get { return _plant; } 
       set { SetPropertyValue(nameof(plant), ref _plant, value); } 
     } 
     // Organizational Levels
     // Notes for fChangeMaterialMaster : 
     private string _stroloc; 
     [XafDisplayName("Stor. Location"), ToolTip("Stor. Location")] 
     // [Appearance("fChangeMaterialMasterstroloc", Enabled = true)]
     // [Appearance("fChangeMaterialMasterstrolocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string stroloc
     { 
       get { return _stroloc; } 
       set { SetPropertyValue(nameof(stroloc), ref _stroloc, value); } 
     } 
     // Organizational Levels
     // Notes for fChangeMaterialMaster : 
     private string _salesorg; 
     [XafDisplayName("Sales Org."), ToolTip("Sales Org.")] 
     // [Appearance("fChangeMaterialMastersalesorg", Enabled = true)]
     // [Appearance("fChangeMaterialMastersalesorgVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string salesorg
     { 
       get { return _salesorg; } 
       set { SetPropertyValue(nameof(salesorg), ref _salesorg, value); } 
     } 
     // Organizational Levels
     // Notes for fChangeMaterialMaster : 
     private string _distrchann; 
     [XafDisplayName("Distr. Channel"), ToolTip("Distr. Channel")] 
     // [Appearance("fChangeMaterialMasterdistrchann", Enabled = true)]
     // [Appearance("fChangeMaterialMasterdistrchannVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string distrchann
     { 
       get { return _distrchann; } 
       set { SetPropertyValue(nameof(distrchann), ref _distrchann, value); } 
     } 
     // Organizational Levels
     // Notes for fChangeMaterialMaster : 
     private bool _orglevels; 
     [XafDisplayName("Org. Levels/Profile only on Request"), ToolTip("Org. levels/profile only on request")] 
     // [Appearance("fChangeMaterialMasterorglevels", Enabled = true)]
     // [Appearance("fChangeMaterialMasterorglevelsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool orglevels
     { 
       get { return _orglevels; } 
       set { SetPropertyValue(nameof(orglevels), ref _orglevels, value); } 
     } 
     // Sales: sales org. 2
     // Notes for fChangeMaterialMaster : 
     private string _material1; 
     [XafDisplayName("Material"), ToolTip("Material")] 
     // [Appearance("fChangeMaterialMastermaterial1", Enabled = true)]
     // [Appearance("fChangeMaterialMastermaterial1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(200)] 
     public  string material1
     { 
       get { return _material1; } 
       set { SetPropertyValue(nameof(material1), ref _material1, value); } 
     } 
     // Sales: sales org. 2
     // Notes for fChangeMaterialMaster : 
     private string _salesorg1; 
     [XafDisplayName("Sales Org."), ToolTip("Sales Org.")] 
     // [Appearance("fChangeMaterialMastersalesorg1", Enabled = true)]
     // [Appearance("fChangeMaterialMastersalesorg1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string salesorg1
     { 
       get { return _salesorg1; } 
       set { SetPropertyValue(nameof(salesorg1), ref _salesorg1, value); } 
     } 
     // Sales: sales org. 2
     // Notes for fChangeMaterialMaster : 
     private string _distrchl; 
     [XafDisplayName("Distr. Chl"), ToolTip("Distr. Chl")] 
     // [Appearance("fChangeMaterialMasterdistrchl", Enabled = true)]
     // [Appearance("fChangeMaterialMasterdistrchlVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string distrchl
     { 
       get { return _distrchl; } 
       set { SetPropertyValue(nameof(distrchl), ref _distrchl, value); } 
     } 
     // Grouping terms
     // Notes for fChangeMaterialMaster : 
     private string _matlstaticgrp; 
     [XafDisplayName("Matl Statistic Grp"), ToolTip("Matl statistic grp")] 
     // [Appearance("fChangeMaterialMastermatlstaticgrp", Enabled = true)]
     // [Appearance("fChangeMaterialMastermatlstaticgrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string matlstaticgrp
     { 
       get { return _matlstaticgrp; } 
       set { SetPropertyValue(nameof(matlstaticgrp), ref _matlstaticgrp, value); } 
     } 
     // Grouping terms
     // Notes for fChangeMaterialMaster : 
     private string _matlpricinggrp; 
     [XafDisplayName("Material Pricing Grp"), ToolTip("Material pricing grp")] 
     // [Appearance("fChangeMaterialMastermatlpricinggrp", Enabled = true)]
     // [Appearance("fChangeMaterialMastermatlpricinggrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string matlpricinggrp
     { 
       get { return _matlpricinggrp; } 
       set { SetPropertyValue(nameof(matlpricinggrp), ref _matlpricinggrp, value); } 
     } 
     // Grouping terms
     // Notes for fChangeMaterialMaster : 
     private string _volumrebategrp; 
     [XafDisplayName("Volume Rebate Group"), ToolTip("Volume rebate group")] 
     // [Appearance("fChangeMaterialMastervolumrebategrp", Enabled = true)]
     // [Appearance("fChangeMaterialMastervolumrebategrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string volumrebategrp
     { 
       get { return _volumrebategrp; } 
       set { SetPropertyValue(nameof(volumrebategrp), ref _volumrebategrp, value); } 
     } 
     // Grouping terms
     // Notes for fChangeMaterialMaster : 
     private string _acctassggrp; 
     [XafDisplayName("Acct Assignment Grp"), ToolTip("Acct assignment grp")] 
     // [Appearance("fChangeMaterialMasteracctassggrp", Enabled = true)]
     // [Appearance("fChangeMaterialMasteracctassggrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string acctassggrp
     { 
       get { return _acctassggrp; } 
       set { SetPropertyValue(nameof(acctassggrp), ref _acctassggrp, value); } 
     } 
     // Grouping terms
     // Notes for fChangeMaterialMaster : 
     private string _genitemcatgrp; 
     [XafDisplayName("Gen. Item Cat. Grp"), ToolTip("Gen. item cat. Grp")] 
     // [Appearance("fChangeMaterialMastergenitemcatgrp", Enabled = true)]
     // [Appearance("fChangeMaterialMastergenitemcatgrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string genitemcatgrp
     { 
       get { return _genitemcatgrp; } 
       set { SetPropertyValue(nameof(genitemcatgrp), ref _genitemcatgrp, value); } 
     } 
     // Grouping terms
     // Notes for fChangeMaterialMaster : 
     private string _itemcateggrp; 
     [XafDisplayName("Item Category Grp"), ToolTip("Item category grp")] 
     // [Appearance("fChangeMaterialMasteritemcateggrp", Enabled = true)]
     // [Appearance("fChangeMaterialMasteritemcateggrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string itemcateggrp
     { 
       get { return _itemcateggrp; } 
       set { SetPropertyValue(nameof(itemcateggrp), ref _itemcateggrp, value); } 
     } 
     // Grouping terms
     // Notes for fChangeMaterialMaster : 
     private string _pricrefmatl; 
     [XafDisplayName("Pricing Ref. Matl"), ToolTip("Pricing Ref. Matl")] 
     // [Appearance("fChangeMaterialMasterpricrefmatl", Enabled = true)]
     // [Appearance("fChangeMaterialMasterpricrefmatlVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string pricrefmatl
     { 
       get { return _pricrefmatl; } 
       set { SetPropertyValue(nameof(pricrefmatl), ref _pricrefmatl, value); } 
     } 
     // Grouping terms
     // Notes for fChangeMaterialMaster : 
     private string _prodcthierarchy; 
     [XafDisplayName("Product Hierarchy"), ToolTip("Product hierarchy")] 
     // [Appearance("fChangeMaterialMasterprodcthierarchy", Enabled = true)]
     // [Appearance("fChangeMaterialMasterprodcthierarchyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string prodcthierarchy
     { 
       get { return _prodcthierarchy; } 
       set { SetPropertyValue(nameof(prodcthierarchy), ref _prodcthierarchy, value); } 
     } 
     // Grouping terms
     // Notes for fChangeMaterialMaster : 
     private string _commgrp; 
     [XafDisplayName("Commission Group"), ToolTip("Commission group")] 
     // [Appearance("fChangeMaterialMastercommgrp", Enabled = true)]
     // [Appearance("fChangeMaterialMastercommgrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string commgrp
     { 
       get { return _commgrp; } 
       set { SetPropertyValue(nameof(commgrp), ref _commgrp, value); } 
     } 
     // Product attributes
     // Notes for fChangeMaterialMaster : 
     private bool _prodctatt1; 
     [XafDisplayName("Product Attributes 1"), ToolTip("Product attributes 1")] 
     // [Appearance("fChangeMaterialMasterprodctatt1", Enabled = true)]
     // [Appearance("fChangeMaterialMasterprodctatt1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool prodctatt1
     { 
       get { return _prodctatt1; } 
       set { SetPropertyValue(nameof(prodctatt1), ref _prodctatt1, value); } 
     } 
     // Product attributes
     // Notes for fChangeMaterialMaster : 
     private bool _prodctatt2; 
     [XafDisplayName("Product Attributes 2"), ToolTip("Product attributes 2")] 
     // [Appearance("fChangeMaterialMasterprodctatt2", Enabled = true)]
     // [Appearance("fChangeMaterialMasterprodctatt2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool prodctatt2
     { 
       get { return _prodctatt2; } 
       set { SetPropertyValue(nameof(prodctatt2), ref _prodctatt2, value); } 
     } 
     // Product attributes
     // Notes for fChangeMaterialMaster : 
     private bool _prodctatt3; 
     [XafDisplayName("Product Attributes 3"), ToolTip("Product attributes 3")] 
     // [Appearance("fChangeMaterialMasterprodctatt3", Enabled = true)]
     // [Appearance("fChangeMaterialMasterprodctatt3Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool prodctatt3
     { 
       get { return _prodctatt3; } 
       set { SetPropertyValue(nameof(prodctatt3), ref _prodctatt3, value); } 
     } 
     // Product attributes
     // Notes for fChangeMaterialMaster : 
     private bool _prodctatt4; 
     [XafDisplayName("Product Attributes 4"), ToolTip("Product attributes 4")] 
     // [Appearance("fChangeMaterialMasterprodctatt4", Enabled = true)]
     // [Appearance("fChangeMaterialMasterprodctatt4Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool prodctatt4
     { 
       get { return _prodctatt4; } 
       set { SetPropertyValue(nameof(prodctatt4), ref _prodctatt4, value); } 
     } 
     // Product attributes
     // Notes for fChangeMaterialMaster : 
     private bool _prodctatt5; 
     [XafDisplayName("Product Attributes 5"), ToolTip("Product attributes 5")] 
     // [Appearance("fChangeMaterialMasterprodctatt5", Enabled = true)]
     // [Appearance("fChangeMaterialMasterprodctatt5Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool prodctatt5
     { 
       get { return _prodctatt5; } 
       set { SetPropertyValue(nameof(prodctatt5), ref _prodctatt5, value); } 
     } 
     // Product attributes
     // Notes for fChangeMaterialMaster : 
     private bool _prodctatt6; 
     [XafDisplayName("Product Attributes 6"), ToolTip("Product attributes 6")] 
     // [Appearance("fChangeMaterialMasterprodctatt6", Enabled = true)]
     // [Appearance("fChangeMaterialMasterprodctatt6Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool prodctatt6
     { 
       get { return _prodctatt6; } 
       set { SetPropertyValue(nameof(prodctatt6), ref _prodctatt6, value); } 
     } 
     // Product attributes
     // Notes for fChangeMaterialMaster : 
     private bool _prodctatt7; 
     [XafDisplayName("Product Attributes 7"), ToolTip("Product attributes 7")] 
     // [Appearance("fChangeMaterialMasterprodctatt7", Enabled = true)]
     // [Appearance("fChangeMaterialMasterprodctatt7Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool prodctatt7
     { 
       get { return _prodctatt7; } 
       set { SetPropertyValue(nameof(prodctatt7), ref _prodctatt7, value); } 
     } 
     // Product attributes
     // Notes for fChangeMaterialMaster : 
     private bool _prodctatt8; 
     [XafDisplayName("Product Attributes 8"), ToolTip("Product attributes 8")] 
     // [Appearance("fChangeMaterialMasterprodctatt8", Enabled = true)]
     // [Appearance("fChangeMaterialMasterprodctatt8Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool prodctatt8
     { 
       get { return _prodctatt8; } 
       set { SetPropertyValue(nameof(prodctatt8), ref _prodctatt8, value); } 
     } 
     // Product attributes
     // Notes for fChangeMaterialMaster : 
     private bool _prodctatt9; 
     [XafDisplayName("Product Attributes 9"), ToolTip("Product attributes 9")] 
     // [Appearance("fChangeMaterialMasterprodctatt9", Enabled = true)]
     // [Appearance("fChangeMaterialMasterprodctatt9Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool prodctatt9
     { 
       get { return _prodctatt9; } 
       set { SetPropertyValue(nameof(prodctatt9), ref _prodctatt9, value); } 
     } 
     // Product attributes
     // Notes for fChangeMaterialMaster : 
     private bool _prodctatt10; 
     [XafDisplayName("Product Attributes 10"), ToolTip("Product attributes 10")] 
     // [Appearance("fChangeMaterialMasterprodctatt10", Enabled = true)]
     // [Appearance("fChangeMaterialMasterprodctatt10Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool prodctatt10
     { 
       get { return _prodctatt10; } 
       set { SetPropertyValue(nameof(prodctatt10), ref _prodctatt10, value); } 
     } 
   } 
} 
