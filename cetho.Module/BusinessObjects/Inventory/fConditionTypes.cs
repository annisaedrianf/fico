// Class Name : fConditionTypes.cs 
// Project Name : FICO 
// Last Update : 07/06/2023 11:59:18  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 07/06/2023 11:59:14 
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
   [System.ComponentModel.DisplayName("Change Condition Types: Details")]
   public class fConditionTypes : XPObject
   {
     public fConditionTypes(Session session) : base(session) 
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
     [Appearance("VisiblefConditionTypesOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // Changes which can be made
     // Notes for fConditionTypes : 
     private bool _amount; 
     [XafDisplayName("Amount/Percent"), ToolTip("Amount/percent")] 
     // [Appearance("fConditionTypesamount", Enabled = true)]
     // [Appearance("fConditionTypesamountVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool amount
     { 
       get { return _amount; } 
       set { SetPropertyValue(nameof(amount), ref _amount, value); } 
     } 
     // Changes which can be made
     // Notes for fConditionTypes : 
     private bool _calctype; 
     [XafDisplayName("Calculat. Type"), ToolTip("Calculat.type")] 
     // [Appearance("fConditionTypescalctype", Enabled = true)]
     // [Appearance("fConditionTypescalctypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool calctype
     { 
       get { return _calctype; } 
       set { SetPropertyValue(nameof(calctype), ref _calctype, value); } 
     } 
     // Changes which can be made
     // Notes for fConditionTypes : 
     private bool _delete; 
     [XafDisplayName("Delete"), ToolTip("Delete")] 
     // [Appearance("fConditionTypesdelete", Enabled = true)]
     // [Appearance("fConditionTypesdeleteVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool delete
     { 
       get { return _delete; } 
       set { SetPropertyValue(nameof(delete), ref _delete, value); } 
     } 
     // Changes which can be made
     // Notes for fConditionTypes : 
     private bool _headcondit; 
     [XafDisplayName("Header Condit."), ToolTip("Header condit.")] 
     // [Appearance("fConditionTypesheadcondit", Enabled = true)]
     // [Appearance("fConditionTypesheadconditVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool headcondit
     { 
       get { return _headcondit; } 
       set { SetPropertyValue(nameof(headcondit), ref _headcondit, value); } 
     } 
     // Changes which can be made
     // Notes for fConditionTypes : 
     private bool _itemcond; 
     [XafDisplayName("Item Condition"), ToolTip("Item condition")] 
     // [Appearance("fConditionTypesitemcond", Enabled = true)]
     // [Appearance("fConditionTypesitemcondVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool itemcond
     { 
       get { return _itemcond; } 
       set { SetPropertyValue(nameof(itemcond), ref _itemcond, value); } 
     } 
     // Changes which can be made
     // Notes for fConditionTypes : 
     private string _manualentries; 
     [XafDisplayName("Manual Entries"), ToolTip("Manual entries")] 
     // [Appearance("fConditionTypesmanualentries", Enabled = true)]
     // [Appearance("fConditionTypesmanualentriesVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string manualentries
     { 
       get { return _manualentries; } 
       set { SetPropertyValue(nameof(manualentries), ref _manualentries, value); } 
     } 
     // Changes which can be made
     // Notes for fConditionTypes : 
     private bool _qtyrelation; 
     [XafDisplayName("Qty Relation"), ToolTip("Qty relation")] 
     // [Appearance("fConditionTypesqtyrelation", Enabled = true)]
     // [Appearance("fConditionTypesqtyrelationVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool qtyrelation
     { 
       get { return _qtyrelation; } 
       set { SetPropertyValue(nameof(qtyrelation), ref _qtyrelation, value); } 
     } 
     // Changes which can be made
     // Notes for fConditionTypes : 
     private bool _value; 
     [XafDisplayName("Value"), ToolTip("Value")] 
     // [Appearance("fConditionTypesvalue", Enabled = true)]
     // [Appearance("fConditionTypesvalueVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool value
     { 
       get { return _value; } 
       set { SetPropertyValue(nameof(value), ref _value, value); } 
     } 
     // Control data 1
     // Notes for fConditionTypes : 
     private string _calctype1; 
     [XafDisplayName("Calculat. Type"), ToolTip("Calculat.type (Ctrl1)")] 
     // [Appearance("fConditionTypescalctype1", Enabled = true)]
     // [Appearance("fConditionTypescalctype1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string calctype1
     { 
       get { return _calctype1; } 
       set { SetPropertyValue(nameof(calctype1), ref _calctype1, value); } 
     } 
     // Control data 1
     // Notes for fConditionTypes : 
     private string _condclass; 
     [XafDisplayName("Cond. Class"), ToolTip("Cond. Class")] 
     // [Appearance("fConditionTypescondclass", Enabled = true)]
     // [Appearance("fConditionTypescondclassVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string condclass
     { 
       get { return _condclass; } 
       set { SetPropertyValue(nameof(condclass), ref _condclass, value); } 
     } 
     // Control data 1
     // Notes for fConditionTypes : 
     private string _condctgr; 
     [XafDisplayName("Cond. Category"), ToolTip("Cond.category")] 
     // [Appearance("fConditionTypescondctgr", Enabled = true)]
     // [Appearance("fConditionTypescondctgrVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string condctgr
     { 
       get { return _condctgr; } 
       set { SetPropertyValue(nameof(condctgr), ref _condctgr, value); } 
     } 
     // Control data 1
     // Notes for fConditionTypes : 
     private string _plusminus; 
     [XafDisplayName("Plus/Minus"), ToolTip("Plus/minus")] 
     // [Appearance("fConditionTypesplusminus", Enabled = true)]
     // [Appearance("fConditionTypesplusminusVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string plusminus
     { 
       get { return _plusminus; } 
       set { SetPropertyValue(nameof(plusminus), ref _plusminus, value); } 
     } 
     // Control data 1
     // Notes for fConditionTypes : 
     private string _roundrule; 
     [XafDisplayName("Rounding Rule"), ToolTip("Rounding rule")] 
     // [Appearance("fConditionTypesroundrule", Enabled = true)]
     // [Appearance("fConditionTypesroundruleVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string roundrule
     { 
       get { return _roundrule; } 
       set { SetPropertyValue(nameof(roundrule), ref _roundrule, value); } 
     } 
     // Control data 1
     // Notes for fConditionTypes : 
     private string _struccond; 
     [XafDisplayName("Struc Cond."), ToolTip("StrucCond.")] 
     // [Appearance("fConditionTypesstruccond", Enabled = true)]
     // [Appearance("fConditionTypesstruccondVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string struccond
     { 
       get { return _struccond; } 
       set { SetPropertyValue(nameof(struccond), ref _struccond, value); } 
     } 
     // Control data 10
     // Notes for fConditionTypes : 
     private string _relaccassig; 
     [XafDisplayName("Rel. Acc. Assig"), ToolTip("Rel.Acc.Assig")] 
     // [Appearance("fConditionTypesrelaccassig", Enabled = true)]
     // [Appearance("fConditionTypesrelaccassigVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string relaccassig
     { 
       get { return _relaccassig; } 
       set { SetPropertyValue(nameof(relaccassig), ref _relaccassig, value); } 
     } 
     // Control data 2
     // Notes for fConditionTypes : 
     private bool _currencyconv; 
     [XafDisplayName("Currency Cnv"), ToolTip("Currency conv")] 
     // [Appearance("fConditionTypescurrencyconv", Enabled = true)]
     // [Appearance("fConditionTypescurrencyconvVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool currencyconv
     { 
       get { return _currencyconv; } 
       set { SetPropertyValue(nameof(currencyconv), ref _currencyconv, value); } 
     } 
     // Control data 3
     // Notes for fConditionTypes : 
     private bool _accruals; 
     [XafDisplayName("Accruals"), ToolTip("Accruals")] 
     // [Appearance("fConditionTypesaccruals", Enabled = true)]
     // [Appearance("fConditionTypesaccrualsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool accruals
     { 
       get { return _accruals; } 
       set { SetPropertyValue(nameof(accruals), ref _accruals, value); } 
     } 
     // Control data 4
     // Notes for fConditionTypes : 
     private bool _invlistcond; 
     [XafDisplayName("Inv. List Cond."), ToolTip("Inv.list cond.")] 
     // [Appearance("fConditionTypesinvlistcond", Enabled = true)]
     // [Appearance("fConditionTypesinvlistcondVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool invlistcond
     { 
       get { return _invlistcond; } 
       set { SetPropertyValue(nameof(invlistcond), ref _invlistcond, value); } 
     } 
     // Control data 5
     // Notes for fConditionTypes : 
     private bool _intcombill; 
     [XafDisplayName("Int-com Bill Cond"), ToolTip("Int-comBillCond")] 
     // [Appearance("fConditionTypesintcombill", Enabled = true)]
     // [Appearance("fConditionTypesintcombillVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool intcombill
     { 
       get { return _intcombill; } 
       set { SetPropertyValue(nameof(intcombill), ref _intcombill, value); } 
     } 
     // Control data 6
     // Notes for fConditionTypes : 
     private bool _promotcond; 
     [XafDisplayName("Promotion Cond"), ToolTip("Promotion Cond")] 
     // [Appearance("fConditionTypespromotcond", Enabled = true)]
     // [Appearance("fConditionTypespromotcondVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool promotcond
     { 
       get { return _promotcond; } 
       set { SetPropertyValue(nameof(promotcond), ref _promotcond, value); } 
     } 
     // Control data 7
     // Notes for fConditionTypes : 
     private bool _varcond; 
     [XafDisplayName("Variant Cond."), ToolTip("Variant cond.")] 
     // [Appearance("fConditionTypesvarcond", Enabled = true)]
     // [Appearance("fConditionTypesvarcondVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool varcond
     { 
       get { return _varcond; } 
       set { SetPropertyValue(nameof(varcond), ref _varcond, value); } 
     } 
     // Control data 8
     // Notes for fConditionTypes : 
     private bool _qtyconvers; 
     [XafDisplayName("Qty Conversion"), ToolTip("Qty conversion")] 
     // [Appearance("fConditionTypesqtyconvers", Enabled = true)]
     // [Appearance("fConditionTypesqtyconversVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool qtyconvers
     { 
       get { return _qtyconvers; } 
       set { SetPropertyValue(nameof(qtyconvers), ref _qtyconvers, value); } 
     } 
     // Control data 9
     // Notes for fConditionTypes : 
     private string _exclusion; 
     [XafDisplayName("Exclusion"), ToolTip("Exclusion")] 
     // [Appearance("fConditionTypesexclusion", Enabled = true)]
     // [Appearance("fConditionTypesexclusionVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string exclusion
     { 
       get { return _exclusion; } 
       set { SetPropertyValue(nameof(exclusion), ref _exclusion, value); } 
     } 
     // Group condition
     // Notes for fConditionTypes : 
     private bool _groupcond; 
     [XafDisplayName("Group Cond."), ToolTip("Group cond.")] 
     // [Appearance("fConditionTypesgroupcond", Enabled = true)]
     // [Appearance("fConditionTypesgroupcondVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool groupcond
     { 
       get { return _groupcond; } 
       set { SetPropertyValue(nameof(groupcond), ref _groupcond, value); } 
     } 
     // Group condition
     // Notes for fConditionTypes : 
     private bool _grpcondroutine; 
     [XafDisplayName("Grp Cond. Routine"), ToolTip("GrpCond.routine")] 
     // [Appearance("fConditionTypesgrpcondroutine", Enabled = true)]
     // [Appearance("fConditionTypesgrpcondroutineVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool grpcondroutine
     { 
       get { return _grpcondroutine; } 
       set { SetPropertyValue(nameof(grpcondroutine), ref _grpcondroutine, value); } 
     } 
     // Group condition
     // Notes for fConditionTypes : 
     private bool _roounddiffcomp; 
     [XafDisplayName("Round Diff Comp"), ToolTip("RoundDiffComp")] 
     // [Appearance("fConditionTypesroounddiffcomp", Enabled = true)]
     // [Appearance("fConditionTypesroounddiffcompVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool roounddiffcomp
     { 
       get { return _roounddiffcomp; } 
       set { SetPropertyValue(nameof(roounddiffcomp), ref _roounddiffcomp, value); } 
     } 
     // Master data
     // Notes for fConditionTypes : 
     private bool _condindex; 
     [XafDisplayName("Condition Index"), ToolTip("Condition index")] 
     // [Appearance("fConditionTypescondindex", Enabled = true)]
     // [Appearance("fConditionTypescondindexVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool condindex
     { 
       get { return _condindex; } 
       set { SetPropertyValue(nameof(condindex), ref _condindex, value); } 
     } 
     // Master data
     // Notes for fConditionTypes : 
     private enumDeleteDB _delfrdb; 
     [XafDisplayName("Delete fr. DB"), ToolTip("delete fr. DB")] 
     // [Appearance("fConditionTypesdelfrdb", Enabled = true)]
     // [Appearance("fConditionTypesdelfrdbVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumDeleteDB delfrdb
     { 
       get { return _delfrdb; } 
       set { SetPropertyValue(nameof(delfrdb), ref _delfrdb, value); } 
     } 
     // Master data
     // Notes for fConditionTypes : 
     private string _pricingproc; 
     [XafDisplayName("Pricing Proc"), ToolTip("PricingProc")] 
     // [Appearance("fConditionTypespricingproc", Enabled = true)]
     // [Appearance("fConditionTypespricingprocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string pricingproc
     { 
       get { return _pricingproc; } 
       set { SetPropertyValue(nameof(pricingproc), ref _pricingproc, value); } 
     } 
     // Master data
     // Notes for fConditionTypes : 
     private string _refappl; 
     [XafDisplayName("Ref Applicatio"), ToolTip("RefApplicatio")] 
     // [Appearance("fConditionTypesrefappl", Enabled = true)]
     // [Appearance("fConditionTypesrefapplVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string refappl
     { 
       get { return _refappl; } 
       set { SetPropertyValue(nameof(refappl), ref _refappl, value); } 
     } 
     // Master data
     // Notes for fConditionTypes : 
     private string _refcontype; 
     [XafDisplayName("Ref Con Type"), ToolTip("RefCon Type")] 
     // [Appearance("fConditionTypesrefcontype", Enabled = true)]
     // [Appearance("fConditionTypesrefcontypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string refcontype
     { 
       get { return _refcontype; } 
       set { SetPropertyValue(nameof(refcontype), ref _refcontype, value); } 
     } 
     // Master data
     // Notes for fConditionTypes : 
     private DateTime _vldfrom; 
     [XafDisplayName("valid From"), ToolTip("valid from")] 
     // [Appearance("fConditionTypesvldfrom", Enabled = true)]
     // [Appearance("fConditionTypesvldfromVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime vldfrom
     { 
       get { return _vldfrom; } 
       set { SetPropertyValue(nameof(vldfrom), ref _vldfrom, value); } 
     } 
     // Master data
     // Notes for fConditionTypes : 
     private DateTime _vldto; 
     [XafDisplayName("Valid To"), ToolTip("Valid to")] 
     // [Appearance("fConditionTypesvldto", Enabled = true)]
     // [Appearance("fConditionTypesvldtoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime vldto
     { 
       get { return _vldto; } 
       set { SetPropertyValue(nameof(vldto), ref _vldto, value); } 
     } 
     // Sales to pricing
     // Notes for fConditionTypes : 
     private bool _pricingonoff; 
     [XafDisplayName("Pricing On/Off"), ToolTip("Pricing on/off")] 
     // [Appearance("fConditionTypespricingonoff", Enabled = true)]
     // [Appearance("fConditionTypespricingonoffVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool pricingonoff
     { 
       get { return _pricingonoff; } 
       set { SetPropertyValue(nameof(pricingonoff), ref _pricingonoff, value); } 
     } 
     // Sales to pricing
     // Notes for fConditionTypes : 
     private bool _reltopricing; 
     [XafDisplayName("Rel. to Pricing"), ToolTip("Rel. to pricing")] 
     // [Appearance("fConditionTypesreltopricing", Enabled = true)]
     // [Appearance("fConditionTypesreltopricingVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool reltopricing
     { 
       get { return _reltopricing; } 
       set { SetPropertyValue(nameof(reltopricing), ref _reltopricing, value); } 
     } 
     // Scales
     // Notes for fConditionTypes : 
     private string _chkvalue; 
     [XafDisplayName("Check Value"), ToolTip("Check value")] 
     // [Appearance("fConditionTypeschkvalue", Enabled = true)]
     // [Appearance("fConditionTypeschkvalueVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string chkvalue
     { 
       get { return _chkvalue; } 
       set { SetPropertyValue(nameof(chkvalue), ref _chkvalue, value); } 
     } 
     // Scales
     // Notes for fConditionTypes : 
     private string _scalebasis; 
     [XafDisplayName("Scale Basis"), ToolTip("Scale basis")] 
     // [Appearance("fConditionTypesscalebasis", Enabled = true)]
     // [Appearance("fConditionTypesscalebasisVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string scalebasis
     { 
       get { return _scalebasis; } 
       set { SetPropertyValue(nameof(scalebasis), ref _scalebasis, value); } 
     } 
     // Scales
     // Notes for fConditionTypes : 
     private string _scaleforuml; 
     [XafDisplayName("Scale Formula"), ToolTip("Scale formula")] 
     // [Appearance("fConditionTypesscaleforuml", Enabled = true)]
     // [Appearance("fConditionTypesscaleforumlVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string scaleforuml
     { 
       get { return _scaleforuml; } 
       set { SetPropertyValue(nameof(scaleforuml), ref _scaleforuml, value); } 
     } 
     // Scales
     // Notes for fConditionTypes : 
     private string _scaletype; 
     [XafDisplayName("Scale Type"), ToolTip("Scale type")] 
     // [Appearance("fConditionTypesscaletype", Enabled = true)]
     // [Appearance("fConditionTypesscaletypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string scaletype
     { 
       get { return _scaletype; } 
       set { SetPropertyValue(nameof(scaletype), ref _scaletype, value); } 
     } 
     // Scales
     // Notes for fConditionTypes : 
     private string _unitofmeas; 
     [XafDisplayName("Unit of Meas."), ToolTip("Unit of meas.")] 
     // [Appearance("fConditionTypesunitofmeas", Enabled = true)]
     // [Appearance("fConditionTypesunitofmeasVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string unitofmeas
     { 
       get { return _unitofmeas; } 
       set { SetPropertyValue(nameof(unitofmeas), ref _unitofmeas, value); } 
     } 
     // Text determination
     // Notes for fConditionTypes : 
     private enumTextDetPrc _textdetprc; 
     [XafDisplayName("Text Det Prc"), ToolTip("TextDetPrc")] 
     // [Appearance("fConditionTypestextdetprc", Enabled = true)]
     // [Appearance("fConditionTypestextdetprcVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumTextDetPrc textdetprc
     { 
       get { return _textdetprc; } 
       set { SetPropertyValue(nameof(textdetprc), ref _textdetprc, value); } 
     } 
     // Text determination
     // Notes for fConditionTypes : 
     private string _textid; 
     [XafDisplayName("Text ID"), ToolTip("Text ID")] 
     // [Appearance("fConditionTypestextid", Enabled = true)]
     // [Appearance("fConditionTypestextidVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string textid
     { 
       get { return _textid; } 
       set { SetPropertyValue(nameof(textid), ref _textid, value); } 
     } 
     // 
     // Notes for fConditionTypes : 
     private string _accessseq; 
     [XafDisplayName("Access Seq."), ToolTip("Access seq.")] 
     // [Appearance("fConditionTypesaccessseq", Enabled = true)]
     // [Appearance("fConditionTypesaccessseqVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string accessseq
     { 
       get { return _accessseq; } 
       set { SetPropertyValue(nameof(accessseq), ref _accessseq, value); } 
     } 
     // 
     // Notes for fConditionTypes : 
     private string _condtype; 
     [XafDisplayName("Condit. Type"), ToolTip("Condit. Type")] 
     // [Appearance("fConditionTypescondtype", Enabled = true)]
     // [Appearance("fConditionTypescondtypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string condtype
     { 
       get { return _condtype; } 
       set { SetPropertyValue(nameof(condtype), ref _condtype, value); } 
     } 
   } 
} 
