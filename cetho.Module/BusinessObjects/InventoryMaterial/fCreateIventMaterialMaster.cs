// Class Name : fCreateIventMaterialMaster.cs 
// Project Name : FICO 
// Last Update : 16/06/2023 14:20:21  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 16/06/2023 14:20:21 
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
   [System.ComponentModel.DisplayName("Create Material (Initial Screen)")]
   public class fCreateIventMaterialMaster : XPObject
   {
     public fCreateIventMaterialMaster(Session session) : base(session) 
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
     [Appearance("VisiblefCreateIventMaterialMasterOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for fCreateIventMaterialMaster : 
     private string _material; 
     [XafDisplayName("Material"), ToolTip("Material")] 
     // [Appearance("fCreateIventMaterialMastermaterial", Enabled = true)]
     // [Appearance("fCreateIventMaterialMastermaterialVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateIventMaterialMaster : 
     private enumIndustrySector _industrysector; 
     [XafDisplayName("Industry Sector"), ToolTip("Industry sector")] 
     // [Appearance("fCreateIventMaterialMasterindustrysector", Enabled = true)]
     // [Appearance("fCreateIventMaterialMasterindustrysectorVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumIndustrySector industrysector
     { 
       get { return _industrysector; } 
       set { SetPropertyValue(nameof(industrysector), ref _industrysector, value); } 
     } 
     // 
     // Notes for fCreateIventMaterialMaster : 
     private enumMaterialType _materialtype; 
     [XafDisplayName("Material Type"), ToolTip("Material Type")] 
     // [Appearance("fCreateIventMaterialMastermaterialtype", Enabled = true)]
     // [Appearance("fCreateIventMaterialMastermaterialtypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumMaterialType materialtype
     { 
       get { return _materialtype; } 
       set { SetPropertyValue(nameof(materialtype), ref _materialtype, value); } 
     } 
     // 
     // Notes for fCreateIventMaterialMaster : 
     private string _changenumber; 
     [XafDisplayName("Change Number"), ToolTip("Change Number")] 
     // [Appearance("fCreateIventMaterialMasterchangenumber", Enabled = true)]
     // [Appearance("fCreateIventMaterialMasterchangenumberVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string changenumber
     { 
       get { return _changenumber; } 
       set { SetPropertyValue(nameof(changenumber), ref _changenumber, value); } 
     } 
     // Copy from…
     // Notes for fCreateIventMaterialMaster : 
     private string _material1; 
     [XafDisplayName("Material"), ToolTip("Material")] 
     // [Appearance("fCreateIventMaterialMastermaterial1", Enabled = true)]
     // [Appearance("fCreateIventMaterialMastermaterial1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string material1
     { 
       get { return _material1; } 
       set { SetPropertyValue(nameof(material1), ref _material1, value); } 
     } 
     // Organizational Levels
     // Notes for fCreateIventMaterialMaster : 
     private string _plant; 
     [XafDisplayName("Plant"), ToolTip("Plant")] 
     // [Appearance("fCreateIventMaterialMasterplant", Enabled = true)]
     // [Appearance("fCreateIventMaterialMasterplantVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateIventMaterialMaster : 
     private string _stroloc; 
     [XafDisplayName("Stor. Location"), ToolTip("Stor. Location")] 
     // [Appearance("fCreateIventMaterialMasterstroloc", Enabled = true)]
     // [Appearance("fCreateIventMaterialMasterstrolocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateIventMaterialMaster : 
     private string _salesorg; 
     [XafDisplayName("Sales Org."), ToolTip("Sales Org.")] 
     // [Appearance("fCreateIventMaterialMastersalesorg", Enabled = true)]
     // [Appearance("fCreateIventMaterialMastersalesorgVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateIventMaterialMaster : 
     private string _distrchann; 
     [XafDisplayName("Distr. Channel"), ToolTip("Distr. Channel")] 
     // [Appearance("fCreateIventMaterialMasterdistrchann", Enabled = true)]
     // [Appearance("fCreateIventMaterialMasterdistrchannVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateIventMaterialMaster : 
     private bool _orglevels; 
     [XafDisplayName("Org. Levels/Profile only on Request"), ToolTip("Org. levels/profile only on request")] 
     // [Appearance("fCreateIventMaterialMasterorglevels", Enabled = true)]
     // [Appearance("fCreateIventMaterialMasterorglevelsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool orglevels
     { 
       get { return _orglevels; } 
       set { SetPropertyValue(nameof(orglevels), ref _orglevels, value); } 
     } 
   } 
} 
