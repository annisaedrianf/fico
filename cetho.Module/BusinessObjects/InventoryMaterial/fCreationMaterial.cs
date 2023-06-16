// Class Name : fCreationMaterial.cs 
// Project Name : FICO 
// Last Update : 16/06/2023 14:18:09  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 16/06/2023 14:18:09 
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
   [System.ComponentModel.DisplayName("Mass Maintenance: Materials (Industry)")]
   public class fCreationMaterial : XPObject
   {
     public fCreationMaterial(Session session) : base(session) 
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
     [Appearance("VisiblefCreationMaterialOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for fCreationMaterial : 
     private string _objtype; 
     [XafDisplayName("Object Type"), ToolTip("Object Type")] 
     // [Appearance("fCreationMaterialobjtype", Enabled = true)]
     // [Appearance("fCreationMaterialobjtypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string objtype
     { 
       get { return _objtype; } 
       set { SetPropertyValue(nameof(objtype), ref _objtype, value); } 
     } 
     // 
     // Notes for fCreationMaterial : 
     private string _variantname; 
     [XafDisplayName("Variant Name"), ToolTip("Variant Name")] 
     // [Appearance("fCreationMaterialvariantname", Enabled = true)]
     // [Appearance("fCreationMaterialvariantnameVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string variantname
     { 
       get { return _variantname; } 
       set { SetPropertyValue(nameof(variantname), ref _variantname, value); } 
     } 
     // Tables
     // Notes for fCreationMaterial : 
     private string _shortdesc; 
     [XafDisplayName("Short Description"), ToolTip("Short Description")] 
     // [Appearance("fCreationMaterialshortdesc", Enabled = true)]
     // [Appearance("fCreationMaterialshortdescVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(200)] 
     public  string shortdesc
     { 
       get { return _shortdesc; } 
       set { SetPropertyValue(nameof(shortdesc), ref _shortdesc, value); } 
     } 
     // Tables
     // Notes for fCreationMaterial : 
     private string _tablename; 
     [XafDisplayName("Table Name"), ToolTip("Table Name")] 
     // [Appearance("fCreationMaterialtablename", Enabled = true)]
     // [Appearance("fCreationMaterialtablenameVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string tablename
     { 
       get { return _tablename; } 
       set { SetPropertyValue(nameof(tablename), ref _tablename, value); } 
     } 
     // 
     // Notes for fCreationMaterial : 
     private bool _notchangeexdata; 
     [XafDisplayName("Do Not Change Existing Data"), ToolTip("Do Not Change Existing Data")] 
     // [Appearance("fCreationMaterialnotchangeexdata", Enabled = true)]
     // [Appearance("fCreationMaterialnotchangeexdataVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool notchangeexdata
     { 
       get { return _notchangeexdata; } 
       set { SetPropertyValue(nameof(notchangeexdata), ref _notchangeexdata, value); } 
     } 
     // Restrict Data Records to Be Changed
     // Notes for fCreationMaterial : 
     private string _material; 
     [XafDisplayName("Material"), ToolTip("Material")] 
     // [Appearance("fCreationMaterialmaterial", Enabled = true)]
     // [Appearance("fCreationMaterialmaterialVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string material
     { 
       get { return _material; } 
       set { SetPropertyValue(nameof(material), ref _material, value); } 
     } 
     // Restrict Data Records to Be Changed
     // Notes for fCreationMaterial : 
     private string _to; 
     [XafDisplayName("To"), ToolTip("To")] 
     // [Appearance("fCreationMaterialto", Enabled = true)]
     // [Appearance("fCreationMaterialtoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string to
     { 
       get { return _to; } 
       set { SetPropertyValue(nameof(to), ref _to, value); } 
     } 
     // General Material Data
     // Notes for fCreationMaterial : 
     private string _material1; 
     [XafDisplayName("Material"), ToolTip("Material")] 
     // [Appearance("fCreationMaterialmaterial1", Enabled = true)]
     // [Appearance("fCreationMaterialmaterial1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string material1
     { 
       get { return _material1; } 
       set { SetPropertyValue(nameof(material1), ref _material1, value); } 
     } 
     // General Material Data
     // Notes for fCreationMaterial : 
     private string _desc; 
     [XafDisplayName("Description"), ToolTip("Description")] 
     // [Appearance("fCreationMaterialdesc", Enabled = true)]
     // [Appearance("fCreationMaterialdescVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(200)] 
     public  string desc
     { 
       get { return _desc; } 
       set { SetPropertyValue(nameof(desc), ref _desc, value); } 
     } 
   } 
} 
