// Class Name : fCustomerNumberRange.cs 
// Project Name : FICO 
// Last Update : 06/06/2023 13:47:55  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 06/06/2023 13:47:55 
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
   [System.ComponentModel.DisplayName("Maintain Number Range Intervals")]
   public class fCustomerNumberRange : XPObject
   {
     public fCustomerNumberRange(Session session) : base(session) 
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
     [Appearance("VisiblefCustomerNumberRangeOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for fCustomerNumberRange : 
     private string _nrobj; 
     [XafDisplayName("NR Object"), ToolTip("NR Object")] 
     // [Appearance("fCustomerNumberRangenrobj", Enabled = true)]
     // [Appearance("fCustomerNumberRangenrobjVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string nrobj
     { 
       get { return _nrobj; } 
       set { SetPropertyValue(nameof(nrobj), ref _nrobj, value); } 
     } 
     // Intervals
     // Notes for fCustomerNumberRange : 
     private string _no; 
     [XafDisplayName("No"), ToolTip("No")] 
     // [Appearance("fCustomerNumberRangeno", Enabled = true)]
     // [Appearance("fCustomerNumberRangenoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string no
     { 
       get { return _no; } 
       set { SetPropertyValue(nameof(no), ref _no, value); } 
     } 
     // Intervals
     // Notes for fCustomerNumberRange : 
     private string _fromnumb; 
     [XafDisplayName("From Number"), ToolTip("From number")] 
     // [Appearance("fCustomerNumberRangefromnumb", Enabled = true)]
     // [Appearance("fCustomerNumberRangefromnumbVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string fromnumb
     { 
       get { return _fromnumb; } 
       set { SetPropertyValue(nameof(fromnumb), ref _fromnumb, value); } 
     } 
     // Intervals
     // Notes for fCustomerNumberRange : 
     private string _tonumb; 
     [XafDisplayName("To Number"), ToolTip("To number")] 
     // [Appearance("fCustomerNumberRangetonumb", Enabled = true)]
     // [Appearance("fCustomerNumberRangetonumbVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string tonumb
     { 
       get { return _tonumb; } 
       set { SetPropertyValue(nameof(tonumb), ref _tonumb, value); } 
     } 
     // Intervals
     // Notes for fCustomerNumberRange : 
     private string _currnumb; 
     [XafDisplayName("Current Number"), ToolTip("Current number")] 
     // [Appearance("fCustomerNumberRangecurrnumb", Enabled = true)]
     // [Appearance("fCustomerNumberRangecurrnumbVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string currnumb
     { 
       get { return _currnumb; } 
       set { SetPropertyValue(nameof(currnumb), ref _currnumb, value); } 
     } 
     // Intervals
     // Notes for fCustomerNumberRange : 
     private bool _ext; 
     [XafDisplayName("Ext"), ToolTip("Ext")] 
     // [Appearance("fCustomerNumberRangeext", Enabled = true)]
     // [Appearance("fCustomerNumberRangeextVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool ext
     { 
       get { return _ext; } 
       set { SetPropertyValue(nameof(ext), ref _ext, value); } 
     } 
     // Change View"Assign Customer Acct Groups
     // Notes for fCustomerNumberRange : 
     private string _grp; 
     [XafDisplayName("Group"), ToolTip("Group")] 
     // [Appearance("fCustomerNumberRangegrp", Enabled = true)]
     // [Appearance("fCustomerNumberRangegrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string grp
     { 
       get { return _grp; } 
       set { SetPropertyValue(nameof(grp), ref _grp, value); } 
     } 
     // Change View"Assign Customer Acct Groups
     // Notes for fCustomerNumberRange : 
     private string _name; 
     [XafDisplayName("Name"), ToolTip("Name")] 
     // [Appearance("fCustomerNumberRangename", Enabled = true)]
     // [Appearance("fCustomerNumberRangenameVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string name
     { 
       get { return _name; } 
       set { SetPropertyValue(nameof(name), ref _name, value); } 
     } 
     // Change View"Assign Customer Acct Groups
     // Notes for fCustomerNumberRange : 
     private string _numbrange; 
     [XafDisplayName("Number Range"), ToolTip("Number range")] 
     // [Appearance("fCustomerNumberRangenumbrange", Enabled = true)]
     // [Appearance("fCustomerNumberRangenumbrangeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string numbrange
     { 
       get { return _numbrange; } 
       set { SetPropertyValue(nameof(numbrange), ref _numbrange, value); } 
     } 
   } 
} 
