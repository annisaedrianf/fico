// Class Name : SyncTaskReportParameter.cs 
// Project Name : GPN 
// Last Update : 2/8/2023 1:51:05 PM  
 
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
   [NavigationItem("Sync")]
   // Standard Document
   [System.ComponentModel.DisplayName("Task Report Parameter")]
   public class SyncTaskReportParameter : XPObject
   {
     public SyncTaskReportParameter(Session session) : base(session) 
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
     [Appearance("VisibleSyncTaskReportParameterOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }

        // 
        // Notes for SyncTaskReportParameter : 
     private SyncTaskReport _TaskReport;
     [XafDisplayName("Task Report"), ToolTip("Task Report")] 
     // [Appearance("SyncTaskReportParameterTaskReport", Enabled = true)]
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Association("TaskRptParameter")]

    public SyncTaskReport TaskReport
        {
        get { return _TaskReport; }
        set { SetPropertyValue(nameof(TaskReport), ref _TaskReport, value); }
    }
        
     // 
     // Notes for SyncTaskReportParameter : 
     private string _Parameter; 
     [XafDisplayName("Parameter"), ToolTip("Parameter")] 
     // [Appearance("SyncTaskReportParameterParameter", Enabled = true)]
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(150)] 
     public  string Parameter
     { 
       get { return _Parameter; } 
       set { SetPropertyValue(nameof(Parameter), ref _Parameter, value); } 
     } 
     // 
     // Notes for SyncTaskReportParameter : 
     private string _Value; 
     [XafDisplayName("Value"), ToolTip("Value")] 
     // [Appearance("SyncTaskReportParameterValue", Enabled = true)]
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1500)] 
     public  string Value
     { 
       get { return _Value; } 
       set { SetPropertyValue(nameof(Value), ref _Value, value); } 
     } 
   } 
} 
