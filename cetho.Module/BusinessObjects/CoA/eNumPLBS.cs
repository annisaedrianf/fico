// Class Name : Enum.cs 
// Project Name : FICO 
// Last Update : 22/05/2023 16:38:04  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 22/05/2023 16:38:04 
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
   [NavigationItem("eNumPLBS")]
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
     private int _pl; 
     [XafDisplayName("P&Lstatement Acct"), ToolTip("P&Lstatement Acct")] 
     // [Appearance("Enumpl", Enabled = true)]
     // [Appearance("EnumplVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  int pl
     { 
       get { return _pl; } 
       set { SetPropertyValue(nameof(pl), ref _pl, value); } 
     } 
     // 
     // Notes for Enum : 
     private int _bs; 
     [XafDisplayName("Balance Sheet Acct"), ToolTip("Balance Sheet Acct")] 
     // [Appearance("Enumbs", Enabled = true)]
     // [Appearance("EnumbsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  int bs
     { 
       get { return _bs; } 
       set { SetPropertyValue(nameof(bs), ref _bs, value); } 
     } 
   } 
} 
