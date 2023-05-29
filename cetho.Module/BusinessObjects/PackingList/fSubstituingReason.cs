// Class Name : fSubstituingReason.cs 
// Project Name : FICO 
// Last Update : 29/05/2023 15:43:31  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 29/05/2023 15:43:31 
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
   [System.ComponentModel.DisplayName("New Entries: Overview of Added Entries")]
   public class fSubstituingReason : XPObject
   {
     public fSubstituingReason(Session session) : base(session) 
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
     [Appearance("VisiblefSubstituingReasonOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for fSubstituingReason : 
     private string _sbstreason; 
     [XafDisplayName("Substituing Reason"), ToolTip("SbstReason")] 
     // [Appearance("fSubstituingReasonsbstreason", Enabled = true)]
     // [Appearance("fSubstituingReasonsbstreasonVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string sbstreason
     { 
       get { return _sbstreason; } 
       set { SetPropertyValue(nameof(sbstreason), ref _sbstreason, value); } 
     } 
     // 
     // Notes for fSubstituingReason : 
     private string _description; 
     [XafDisplayName("Description"), ToolTip("Description")] 
     // [Appearance("fSubstituingReasondescription", Enabled = true)]
     // [Appearance("fSubstituingReasondescriptionVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string description
     { 
       get { return _description; } 
       set { SetPropertyValue(nameof(description), ref _description, value); } 
     } 
     // 
     // Notes for fSubstituingReason : 
     private bool _entry; 
     [XafDisplayName("Entry"), ToolTip("Entry")] 
     // [Appearance("fSubstituingReasonentry", Enabled = true)]
     // [Appearance("fSubstituingReasonentryVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool entry
     { 
       get { return _entry; } 
       set { SetPropertyValue(nameof(entry), ref _entry, value); } 
     } 
     // 
     // Notes for fSubstituingReason : 
     private bool _warning; 
     [XafDisplayName("Warning"), ToolTip("Warning")] 
     // [Appearance("fSubstituingReasonwarning", Enabled = true)]
     // [Appearance("fSubstituingReasonwarningVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool warning
     { 
       get { return _warning; } 
       set { SetPropertyValue(nameof(warning), ref _warning, value); } 
     } 
     // 
     // Notes for fSubstituingReason : 
     private string _strategy; 
     [XafDisplayName("Strategy"), ToolTip("Strategy")] 
     // [Appearance("fSubstituingReasonstrategy", Enabled = true)]
     // [Appearance("fSubstituingReasonstrategyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string strategy
     { 
       get { return _strategy; } 
       set { SetPropertyValue(nameof(strategy), ref _strategy, value); } 
     } 
   } 
} 
