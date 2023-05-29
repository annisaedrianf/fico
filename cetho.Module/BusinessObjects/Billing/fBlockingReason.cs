// Class Name : fBlockingReason.cs 
// Project Name : FICO 
// Last Update : 29/05/2023 15:38:49  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 29/05/2023 15:38:49 
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
   [System.ComponentModel.DisplayName("Change View (Billing: Blocking Reasons): Overview")]
   public class fBlockingReason : XPObject
   {
     public fBlockingReason(Session session) : base(session) 
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
     [Appearance("VisiblefBlockingReasonOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for fBlockingReason : 
     private string _block; 
     [XafDisplayName("Block"), ToolTip("Block")] 
     // [Appearance("fBlockingReasonblock", Enabled = true)]
     // [Appearance("fBlockingReasonblockVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string block
     { 
       get { return _block; } 
       set { SetPropertyValue(nameof(block), ref _block, value); } 
     } 
     // 
     // Notes for fBlockingReason : 
     private string _block1; 
     [XafDisplayName("Block 1"), ToolTip("Block 1")] 
     // [Appearance("fBlockingReasonblock1", Enabled = true)]
     // [Appearance("fBlockingReasonblock1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string block1
     { 
       get { return _block1; } 
       set { SetPropertyValue(nameof(block1), ref _block1, value); } 
     } 
     // 
     // Notes for fBlockingReason : 
     private string _billtype; 
     [XafDisplayName("Billing Type "), ToolTip("Bill. Type ")] 
     // [Appearance("fBlockingReasonbilltype", Enabled = true)]
     // [Appearance("fBlockingReasonbilltypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string billtype
     { 
       get { return _billtype; } 
       set { SetPropertyValue(nameof(billtype), ref _billtype, value); } 
     } 
     // 
     // Notes for fBlockingReason : 
     private string _billingtype; 
     [XafDisplayName("Billing Type 1"), ToolTip("Billing Type")] 
     // [Appearance("fBlockingReasonbillingtype", Enabled = true)]
     // [Appearance("fBlockingReasonbillingtypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string billingtype
     { 
       get { return _billingtype; } 
       set { SetPropertyValue(nameof(billingtype), ref _billingtype, value); } 
     } 
   } 
} 
