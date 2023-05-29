// Class Name : fTaxCategory.cs 
// Project Name : FICO 
// Last Update : 22/05/2023 16:39:27  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 22/05/2023 16:39:27 
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
   [System.ComponentModel.DisplayName("Tax Category")]
   public class fTaxCategory : XPObject
   {
     public fTaxCategory(Session session) : base(session) 
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
     [Appearance("VisiblefTaxCategoryOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     
     // Notes for fTaxCategory : 
     private string _taxcatgr; 
     [XafDisplayName("Tax  Category"), ToolTip("Tax  Category")] 
     // [Appearance("fTaxCategorytaxcatgr", Enabled = true)]
     // [Appearance("fTaxCategorytaxcatgrVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string taxcatgr
     { 
       get { return _taxcatgr; } 
       set { SetPropertyValue(nameof(taxcatgr), ref _taxcatgr, value); } 
     } 
     // Type/Description
     // Notes for fTaxCategory : 
     private string _shorttext; 
     [XafDisplayName("ShortText"), ToolTip("ShortText")] 
     // [Appearance("fTaxCategoryshorttext", Enabled = true)]
     // [Appearance("fTaxCategoryshorttextVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string shorttext
     { 
       get { return _shorttext; } 
       set { SetPropertyValue(nameof(shorttext), ref _shorttext, value); } 
     } 
     // Type/Description
     // Notes for fTaxCategory : 
     private string _longtext; 
     [XafDisplayName("long Text"), ToolTip("long Text")] 
     // [Appearance("fTaxCategorylongtext", Enabled = true)]
     // [Appearance("fTaxCategorylongtextVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(250)] 
     public  string longtext
     { 
       get { return _longtext; } 
       set { SetPropertyValue(nameof(longtext), ref _longtext, value); } 
     } 
   } 
} 
