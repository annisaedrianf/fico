// Class Name : fConditionExclusionGrp.cs 
// Project Name : FICO 
// Last Update : 29/05/2023 15:33:26  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 29/05/2023 15:33:26 
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
   [System.ComponentModel.DisplayName("Change View (Condition Exclusion Groups)")]
   public class fConditionExclusionGrp : XPObject
   {
     public fConditionExclusionGrp(Session session) : base(session) 
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
     [Appearance("VisiblefConditionExclusionGrpOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // New Entries: Overview of Added Entries
     // Notes for fConditionExclusionGrp : 
     private string _exgr; 
     [XafDisplayName("Exc Group"), ToolTip("Exc Group")] 
     // [Appearance("fConditionExclusionGrpexgr", Enabled = true)]
     // [Appearance("fConditionExclusionGrpexgrVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string exgr
     { 
       get { return _exgr; } 
       set { SetPropertyValue(nameof(exgr), ref _exgr, value); } 
     } 
     // New Entries: Overview of Added Entries
     // Notes for fConditionExclusionGrp : 
     private string _condexcgrp; 
     [XafDisplayName("Cond. Exclusion Group"), ToolTip("Cond.exclusion group")] 
     // [Appearance("fConditionExclusionGrpcondexcgrp", Enabled = true)]
     // [Appearance("fConditionExclusionGrpcondexcgrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string condexcgrp
     { 
       get { return _condexcgrp; } 
       set { SetPropertyValue(nameof(condexcgrp), ref _condexcgrp, value); } 
     } 
     // New Entries: Overview of Added Entries
     // Notes for fConditionExclusionGrp : 
     private string _ctyp; 
     [XafDisplayName("Condition Exc. Group"), ToolTip("Ctyp")] 
     // [Appearance("fConditionExclusionGrpctyp", Enabled = true)]
     // [Appearance("fConditionExclusionGrpctypVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string ctyp
     { 
       get { return _ctyp; } 
       set { SetPropertyValue(nameof(ctyp), ref _ctyp, value); } 
     } 
     // New Entries: Overview of Added Entries
     // Notes for fConditionExclusionGrp : 
     private string _condtype; 
     [XafDisplayName("Condition Type"), ToolTip("Condition Type")] 
     // [Appearance("fConditionExclusionGrpcondtype", Enabled = true)]
     // [Appearance("fConditionExclusionGrpcondtypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string condtype
     { 
       get { return _condtype; } 
       set { SetPropertyValue(nameof(condtype), ref _condtype, value); } 
     } 
     // Change View "Procedures": Overview
     // Notes for fConditionExclusionGrp : 
     private string _procchg; 
     [XafDisplayName("Proc. (Procedures)"), ToolTip("Proc. (Procedures)")] 
     // [Appearance("fConditionExclusionGrpprocchg", Enabled = true)]
     // [Appearance("fConditionExclusionGrpprocchgVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string procchg
     { 
       get { return _procchg; } 
       set { SetPropertyValue(nameof(procchg), ref _procchg, value); } 
     } 
     // Change View "Procedures": Overview
     // Notes for fConditionExclusionGrp : 
     private string _desc; 
     [XafDisplayName("Description"), ToolTip("Description")] 
     // [Appearance("fConditionExclusionGrpdesc", Enabled = true)]
     // [Appearance("fConditionExclusionGrpdescVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string desc
     { 
       get { return _desc; } 
       set { SetPropertyValue(nameof(desc), ref _desc, value); } 
     } 
     // New Entries: Overview of Added Entries
     // Notes for fConditionExclusionGrp : 
     private string _sno; 
     [XafDisplayName("Snp"), ToolTip("Snp")] 
     // [Appearance("fConditionExclusionGrpsno", Enabled = true)]
     // [Appearance("fConditionExclusionGrpsnoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string sno
     { 
       get { return _sno; } 
       set { SetPropertyValue(nameof(sno), ref _sno, value); } 
     } 
     // New Entries: Overview of Added Entries
     // Notes for fConditionExclusionGrp : 
     private string _cpr; 
     [XafDisplayName("Cpr"), ToolTip("Cpr")] 
     // [Appearance("fConditionExclusionGrpcpr", Enabled = true)]
     // [Appearance("fConditionExclusionGrpcprVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string cpr
     { 
       get { return _cpr; } 
       set { SetPropertyValue(nameof(cpr), ref _cpr, value); } 
     } 
     // New Entries: Overview of Added Entries
     // Notes for fConditionExclusionGrp : 
     private string _proc; 
     [XafDisplayName("Procedure"), ToolTip("Procedure")] 
     // [Appearance("fConditionExclusionGrpproc", Enabled = true)]
     // [Appearance("fConditionExclusionGrpprocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string proc
     { 
       get { return _proc; } 
       set { SetPropertyValue(nameof(proc), ref _proc, value); } 
     } 
     // New Entries: Overview of Added Entries
     // Notes for fConditionExclusionGrp : 
     private string _exgr1; 
     [XafDisplayName("Exc Group 1"), ToolTip("ExGr1")] 
     // [Appearance("fConditionExclusionGrpexgr1", Enabled = true)]
     // [Appearance("fConditionExclusionGrpexgr1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string exgr1
     { 
       get { return _exgr1; } 
       set { SetPropertyValue(nameof(exgr1), ref _exgr1, value); } 
     } 
     // New Entries: Overview of Added Entries
     // Notes for fConditionExclusionGrp : 
     private string _group1; 
     [XafDisplayName("Group 1"), ToolTip("Group 1")] 
     // [Appearance("fConditionExclusionGrpgroup1", Enabled = true)]
     // [Appearance("fConditionExclusionGrpgroup1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string group1
     { 
       get { return _group1; } 
       set { SetPropertyValue(nameof(group1), ref _group1, value); } 
     } 
     // New Entries: Overview of Added Entries
     // Notes for fConditionExclusionGrp : 
     private string _exgr2; 
     [XafDisplayName("Exc Group 2"), ToolTip("ExGr2")] 
     // [Appearance("fConditionExclusionGrpexgr2", Enabled = true)]
     // [Appearance("fConditionExclusionGrpexgr2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string exgr2
     { 
       get { return _exgr2; } 
       set { SetPropertyValue(nameof(exgr2), ref _exgr2, value); } 
     } 
     // New Entries: Overview of Added Entries
     // Notes for fConditionExclusionGrp : 
     private string _group2; 
     [XafDisplayName("Group 2"), ToolTip("Group 2")] 
     // [Appearance("fConditionExclusionGrpgroup2", Enabled = true)]
     // [Appearance("fConditionExclusionGrpgroup2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string group2
     { 
       get { return _group2; } 
       set { SetPropertyValue(nameof(group2), ref _group2, value); } 
     } 
   } 
} 
