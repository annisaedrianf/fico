// Class Name : Enum.cs 
// Project Name : FICO 
// Last Update : 22/05/2023 16:50:05  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 22/05/2023 16:50:05 
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
   [NavigationItem("eNumAcctsControl")]
   // Standard Document
   [System.ComponentModel.DisplayName("Account")]
   public class Enum : AccountControl
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
     private bool _suppress; 
     [XafDisplayName("Suppress"), ToolTip("Suppress")] 
     // [Appearance("Enumsuppress", Enabled = true)]
     // [Appearance("EnumsuppressVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool suppress
     { 
       get { return _suppress; } 
       set { SetPropertyValue(nameof(suppress), ref _suppress, value); } 
     } 
     // 
     // Notes for Enum : 
     private bool _reqentry; 
     [XafDisplayName("Req.Entry"), ToolTip("Req.Entry")] 
     // [Appearance("Enumreqentry", Enabled = true)]
     // [Appearance("EnumreqentryVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool reqentry
     { 
       get { return _reqentry; } 
       set { SetPropertyValue(nameof(reqentry), ref _reqentry, value); } 
     } 
     // 
     // Notes for Enum : 
     private bool _optentry; 
     [XafDisplayName("Opt.Entry"), ToolTip("Opt.Entry")] 
     // [Appearance("Enumoptentry", Enabled = true)]
     // [Appearance("EnumoptentryVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool optentry
     { 
       get { return _optentry; } 
       set { SetPropertyValue(nameof(optentry), ref _optentry, value); } 
     } 
     // 
     // Notes for Enum : 
     private bool _display; 
     [XafDisplayName("Display"), ToolTip("Display")] 
     // [Appearance("Enumdisplay", Enabled = true)]
     // [Appearance("EnumdisplayVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool display
     { 
       get { return _display; } 
       set { SetPropertyValue(nameof(display), ref _display, value); } 
     } 
   } 
} 
