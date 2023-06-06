// Class Name : fCretaeExclusion.cs 
// Project Name : FICO 
// Last Update : 06/06/2023 13:39:58  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 06/06/2023 13:39:58 
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
   [System.ComponentModel.DisplayName("Create Exclusion (B001): Fast Entry")]
   public class fCretaeExclusion : XPObject
   {
     public fCretaeExclusion(Session session) : base(session) 
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
     [Appearance("VisiblefCretaeExclusionOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for fCretaeExclusion : 
     private string _customer; 
     [XafDisplayName("Customer"), ToolTip("Customer")] 
     // [Appearance("fCretaeExclusioncustomer", Enabled = true)]
     // [Appearance("fCretaeExclusioncustomerVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string customer
     { 
       get { return _customer; } 
       set { SetPropertyValue(nameof(customer), ref _customer, value); } 
     } 
     // 
     // Notes for fCretaeExclusion : 
     private DateTime _vldfrm; 
     [XafDisplayName("Valid From"), ToolTip("Valid From")] 
     // [Appearance("fCretaeExclusionvldfrm", Enabled = true)]
     // [Appearance("fCretaeExclusionvldfrmVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime vldfrm
     { 
       get { return _vldfrm; } 
       set { SetPropertyValue(nameof(vldfrm), ref _vldfrm, value); } 
     } 
     // 
     // Notes for fCretaeExclusion : 
     private DateTime _vldto; 
     [XafDisplayName("Valid To"), ToolTip("Valid To")] 
     // [Appearance("fCretaeExclusionvldto", Enabled = true)]
     // [Appearance("fCretaeExclusionvldtoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime vldto
     { 
       get { return _vldto; } 
       set { SetPropertyValue(nameof(vldto), ref _vldto, value); } 
     } 
     // Customer/Material
     // Notes for fCretaeExclusion : 
     private string _matl; 
     [XafDisplayName("Material"), ToolTip("Material")] 
     // [Appearance("fCretaeExclusionmatl", Enabled = true)]
     // [Appearance("fCretaeExclusionmatlVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string matl
     { 
       get { return _matl; } 
       set { SetPropertyValue(nameof(matl), ref _matl, value); } 
     } 
     // Customer/Material
     // Notes for fCretaeExclusion : 
     private string _desc; 
     [XafDisplayName("Description"), ToolTip("Description")] 
     // [Appearance("fCretaeExclusiondesc", Enabled = true)]
     // [Appearance("fCretaeExclusiondescVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string desc
     { 
       get { return _desc; } 
       set { SetPropertyValue(nameof(desc), ref _desc, value); } 
     } 
   } 
} 
