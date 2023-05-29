// Class Name : fCategoryDetermination.cs 
// Project Name : FICO 
// Last Update : 29/05/2023 14:29:42  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 29/05/2023 14:29:42 
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
   [System.ComponentModel.DisplayName("New Entries: Details of Added Entries")]
   public class fCategoryDetermination : XPObject
   {
     public fCategoryDetermination(Session session) : base(session) 
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
     [Appearance("VisiblefCategoryDeterminationOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for fCategoryDetermination : 
     private string _salesdoctype; 
     [XafDisplayName("Sales Doc. Type"), ToolTip("Sales Doc. Type")] 
     // [Appearance("fCategoryDeterminationsalesdoctype", Enabled = true)]
     // [Appearance("fCategoryDeterminationsalesdoctypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string salesdoctype
     { 
       get { return _salesdoctype; } 
       set { SetPropertyValue(nameof(salesdoctype), ref _salesdoctype, value); } 
     } 
     // 
     // Notes for fCategoryDetermination : 
     private string _itemcatgroup; 
     [XafDisplayName("Item Cat. Group"), ToolTip("Item cat.group")] 
     // [Appearance("fCategoryDeterminationitemcatgroup", Enabled = true)]
     // [Appearance("fCategoryDeterminationitemcatgroupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string itemcatgroup
     { 
       get { return _itemcatgroup; } 
       set { SetPropertyValue(nameof(itemcatgroup), ref _itemcatgroup, value); } 
     } 
     // 
     // Notes for fCategoryDetermination : 
     private string _itemusage; 
     [XafDisplayName("Item Usage"), ToolTip("Item usage")] 
     // [Appearance("fCategoryDeterminationitemusage", Enabled = true)]
     // [Appearance("fCategoryDeterminationitemusageVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string itemusage
     { 
       get { return _itemusage; } 
       set { SetPropertyValue(nameof(itemusage), ref _itemusage, value); } 
     } 
     // 
     // Notes for fCategoryDetermination : 
     private string _itemcathglvitm; 
     [XafDisplayName("Item Cat-HgLvItm"), ToolTip("ItemCat-HgLvItm")] 
     // [Appearance("fCategoryDeterminationitemcathglvitm", Enabled = true)]
     // [Appearance("fCategoryDeterminationitemcathglvitmVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string itemcathglvitm
     { 
       get { return _itemcathglvitm; } 
       set { SetPropertyValue(nameof(itemcathglvitm), ref _itemcathglvitm, value); } 
     } 
     // 
     // Notes for fCategoryDetermination : 
     private string _itemctg; 
     [XafDisplayName("Item Category"), ToolTip("Item category")] 
     // [Appearance("fCategoryDeterminationitemctg", Enabled = true)]
     // [Appearance("fCategoryDeterminationitemctgVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string itemctg
     { 
       get { return _itemctg; } 
       set { SetPropertyValue(nameof(itemctg), ref _itemctg, value); } 
     } 
     // 
     // Notes for fCategoryDetermination : 
     private string _manualitemcat; 
     [XafDisplayName("Manual Item Cat"), ToolTip("Manual item cat")] 
     // [Appearance("fCategoryDeterminationmanualitemcat", Enabled = true)]
     // [Appearance("fCategoryDeterminationmanualitemcatVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string manualitemcat
     { 
       get { return _manualitemcat; } 
       set { SetPropertyValue(nameof(manualitemcat), ref _manualitemcat, value); } 
     } 
     // 
     // Notes for fCategoryDetermination : 
     private string _manualitemcat1; 
     [XafDisplayName("Manual Item Cat 1"), ToolTip("Manual item cat 1")] 
     // [Appearance("fCategoryDeterminationmanualitemcat", Enabled = true)]
     // [Appearance("fCategoryDeterminationmanualitemcatVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string manualitemcat1
     { 
       get { return _manualitemcat1; } 
       set { SetPropertyValue(nameof(manualitemcat1), ref _manualitemcat1, value); } 
     } 
     // 
     // Notes for fCategoryDetermination : 
     private string _manualitemcat2; 
     [XafDisplayName("Manual Item Cat 2"), ToolTip("Manual item cat 2")] 
     // [Appearance("fCategoryDeterminationmanualitemcat", Enabled = true)]
     // [Appearance("fCategoryDeterminationmanualitemcatVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string manualitemcat2
     { 
       get { return _manualitemcat1; } 
       set { SetPropertyValue(nameof(manualitemcat2), ref _manualitemcat2, value); } 
     } 
   } 
} 
