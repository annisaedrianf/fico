// Class Name : fCalculationSchema.cs 
// Project Name : FICO 
// Last Update : 07/06/2023 12:00:40  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 07/06/2023 12:00:40 
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
   [System.ComponentModel.DisplayName("Define Calculation Schema")]
   public class fCalculationSchema : XPObject
   {
     public fCalculationSchema(Session session) : base(session) 
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
     [Appearance("VisiblefCalculationSchemaOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for fCalculationSchema : 
     private string _step; 
     [XafDisplayName("Step"), ToolTip("Step")] 
     // [Appearance("fCalculationSchemastep", Enabled = true)]
     // [Appearance("fCalculationSchemastepVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string step
     { 
       get { return _step; } 
       set { SetPropertyValue(nameof(step), ref _step, value); } 
     } 
     // 
     // Notes for fCalculationSchema : 
     private string _counter; 
     [XafDisplayName("Counter"), ToolTip("Counter")] 
     // [Appearance("fCalculationSchemacounter", Enabled = true)]
     // [Appearance("fCalculationSchemacounterVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string counter
     { 
       get { return _counter; } 
       set { SetPropertyValue(nameof(counter), ref _counter, value); } 
     } 
     // 
     // Notes for fCalculationSchema : 
     private string _condtype; 
     [XafDisplayName("Condition Type"), ToolTip("Condition Type")] 
     // [Appearance("fCalculationSchemacondtype", Enabled = true)]
     // [Appearance("fCalculationSchemacondtypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string condtype
     { 
       get { return _condtype; } 
       set { SetPropertyValue(nameof(condtype), ref _condtype, value); } 
     } 
     // 
     // Notes for fCalculationSchema : 
     private string _description; 
     [XafDisplayName("Description"), ToolTip("Description")] 
     // [Appearance("fCalculationSchemadescription", Enabled = true)]
     // [Appearance("fCalculationSchemadescriptionVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string description
     { 
       get { return _description; } 
       set { SetPropertyValue(nameof(description), ref _description, value); } 
     } 
     // 
     // Notes for fCalculationSchema : 
     private string _from; 
     [XafDisplayName("From"), ToolTip("From")] 
     // [Appearance("fCalculationSchemafrom", Enabled = true)]
     // [Appearance("fCalculationSchemafromVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string from
     { 
       get { return _from; } 
       set { SetPropertyValue(nameof(from), ref _from, value); } 
     } 
     // 
     // Notes for fCalculationSchema : 
     private string _to; 
     [XafDisplayName("To"), ToolTip("To")] 
     // [Appearance("fCalculationSchemato", Enabled = true)]
     // [Appearance("fCalculationSchematoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string to
     { 
       get { return _to; } 
       set { SetPropertyValue(nameof(to), ref _to, value); } 
     } 
     // 
     // Notes for fCalculationSchema : 
     private bool _manual; 
     [XafDisplayName("Manual "), ToolTip("Manual ")] 
     // [Appearance("fCalculationSchemamanual", Enabled = true)]
     // [Appearance("fCalculationSchemamanualVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool manual
     { 
       get { return _manual; } 
       set { SetPropertyValue(nameof(manual), ref _manual, value); } 
     } 
     // 
     // Notes for fCalculationSchema : 
     private bool _required; 
     [XafDisplayName("Required"), ToolTip("Required")] 
     // [Appearance("fCalculationSchemarequired", Enabled = true)]
     // [Appearance("fCalculationSchemarequiredVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool required
     { 
       get { return _required; } 
       set { SetPropertyValue(nameof(required), ref _required, value); } 
     } 
     // 
     // Notes for fCalculationSchema : 
     private bool _statistic; 
     [XafDisplayName("Statistic"), ToolTip("Statistic")] 
     // [Appearance("fCalculationSchemastatistic", Enabled = true)]
     // [Appearance("fCalculationSchemastatisticVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool statistic
     { 
       get { return _statistic; } 
       set { SetPropertyValue(nameof(statistic), ref _statistic, value); } 
     } 
     // 
     // Notes for fCalculationSchema : 
     private string _print; 
     [XafDisplayName("Print"), ToolTip("Print")] 
     // [Appearance("fCalculationSchemaprint", Enabled = true)]
     // [Appearance("fCalculationSchemaprintVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string print
     { 
       get { return _print; } 
       set { SetPropertyValue(nameof(print), ref _print, value); } 
     } 
     // 
     // Notes for fCalculationSchema : 
     private string _subtotal; 
     [XafDisplayName("Subtotal"), ToolTip("Subtotal")] 
     // [Appearance("fCalculationSchemasubtotal", Enabled = true)]
     // [Appearance("fCalculationSchemasubtotalVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string subtotal
     { 
       get { return _subtotal; } 
       set { SetPropertyValue(nameof(subtotal), ref _subtotal, value); } 
     } 
     // 
     // Notes for fCalculationSchema : 
     private string _requirement; 
     [XafDisplayName("Requirement"), ToolTip("Requirement")] 
     // [Appearance("fCalculationSchemarequirement", Enabled = true)]
     // [Appearance("fCalculationSchemarequirementVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string requirement
     { 
       get { return _requirement; } 
       set { SetPropertyValue(nameof(requirement), ref _requirement, value); } 
     } 
     // 
     // Notes for fCalculationSchema : 
     private string _caltype; 
     [XafDisplayName("Cal Type"), ToolTip("Cal Type")] 
     // [Appearance("fCalculationSchemacaltype", Enabled = true)]
     // [Appearance("fCalculationSchemacaltypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string caltype
     { 
       get { return _caltype; } 
       set { SetPropertyValue(nameof(caltype), ref _caltype, value); } 
     } 
     // 
     // Notes for fCalculationSchema : 
     private string _bastype; 
     [XafDisplayName("Bas Type"), ToolTip("Bas Type")] 
     // [Appearance("fCalculationSchemabastype", Enabled = true)]
     // [Appearance("fCalculationSchemabastypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string bastype
     { 
       get { return _bastype; } 
       set { SetPropertyValue(nameof(bastype), ref _bastype, value); } 
     } 
     // 
     // Notes for fCalculationSchema : 
     private string _acckey; 
     [XafDisplayName("Acc Key"), ToolTip("AccKey")] 
     // [Appearance("fCalculationSchemaacckey", Enabled = true)]
     // [Appearance("fCalculationSchemaacckeyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string acckey
     { 
       get { return _acckey; } 
       set { SetPropertyValue(nameof(acckey), ref _acckey, value); } 
     } 
     // 
     // Notes for fCalculationSchema : 
     private string _accrualacckey; 
     [XafDisplayName("Accrual Acc-Key"), ToolTip("AccrualAccKey")] 
     // [Appearance("fCalculationSchemaaccrualacckey", Enabled = true)]
     // [Appearance("fCalculationSchemaaccrualacckeyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string accrualacckey
     { 
       get { return _accrualacckey; } 
       set { SetPropertyValue(nameof(accrualacckey), ref _accrualacckey, value); } 
     } 
   } 
} 
