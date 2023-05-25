// Class Name : Enum.cs 
// Project Name : FICO 
// Last Update : 22/05/2023 16:38:42  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 22/05/2023 16:38:42 
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
   [DefaultProperty("")]
   [NavigationItem("eNumAcctsCtrlIntgration")]
   // Standard Document
   [System.ComponentModel.DisplayName("Account Controlling Integration")]
   public class Enum : Account Control
   {
     public Enum(Session session) : base(session) 
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
     [Appearance("VisibleEnumOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // GroupProperty
     // Notes for Enum : Notes
     private Type _id; 
     [XafDisplayName("Description"), ToolTip("Description")] 
     // [Appearance("Enumid", Enabled = true)]
     // [Appearance("EnumidVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Association("Assc")] 
     public  Type id
     { 
       get { return _id; } 
       set { SetPropertyValue(nameof(id), ref _id, value); } 
     } 
     // 
     // Notes for Enum : 
     private int _manualcostelement; 
     [XafDisplayName("Manual creation of cost element"), ToolTip("Manual creation of cost element")] 
     // [Appearance("Enummanualcostelement", Enabled = true)]
     // [Appearance("EnummanualcostelementVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  int manualcostelement
     { 
       get { return _manualcostelement; } 
       set { SetPropertyValue(nameof(manualcostelement), ref _manualcostelement, value); } 
     } 
     // 
     // Notes for Enum : 
     private int _automaticcostelement; 
     [XafDisplayName("Automatic Creation of Cost elements"), ToolTip("Automatic Creation of Cost elements")] 
     // [Appearance("Enumautomaticcostelement", Enabled = true)]
     // [Appearance("EnumautomaticcostelementVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  int automaticcostelement
     { 
       get { return _automaticcostelement; } 
       set { SetPropertyValue(nameof(automaticcostelement), ref _automaticcostelement, value); } 
     } 
   } 
} 
