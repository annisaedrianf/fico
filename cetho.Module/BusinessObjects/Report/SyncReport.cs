// Class Name : SyncReport.cs 
// Project Name : GPN 
// Last Update : 2/8/2023 1:51:24 PM  

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
using DevExpress.Persistent.BaseImpl;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.XtraPrinting.Native;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace cetho.Module.BusinessObjects
{
    [DefaultClassOptions]
    [ImageName("ModelEditor_Views")]
    [DefaultProperty("")]
    [NavigationItem("Sync")]
    // Standard Document
    [System.ComponentModel.DisplayName("Report")]
    public class SyncReport : XPObject
    {
        public SyncReport(Session session) : base(session)
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
        [Appearance("VisibleSyncReportOID", Visibility = ViewItemVisibility.Hide)]
        public int Oid
        {
            get { return base.Oid; }
            set { base.Oid = value; }
        }

        

        // 
        // Notes for SyncReport : 
        private string _NavigationItem;
        [XafDisplayName("Navigation Item"), ToolTip("Navigation Item")]
        // [Appearance("SyncReportReportID", Enabled = true)]
        // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
        // [RuleRequiredField(DefaultContexts.Save)] 
        // [IsSearch(true)]
        public string NavigationItem
        {
            get { return _NavigationItem; }
            set { SetPropertyValue(nameof(NavigationItem), ref _NavigationItem ,value); }
        }


        // 
        // Notes for SyncReport : 
        private string _ReportID;
        [XafDisplayName("ReportID"), ToolTip("ReportID")]
        // [Appearance("SyncReportReportID", Enabled = true)]
        // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
        // [RuleRequiredField(DefaultContexts.Save)] 
        // [IsSearch(true)]
        public string ReportID
        {
            get { return _ReportID; }
            set { SetPropertyValue(nameof(ReportID), ref _ReportID, value); }
        }

        // Notes for SyncReport : 
        private ImportObject _ReportUIID;
        [XafDisplayName("Report UI"), ToolTip("Report UI")]
        // [Appearance("SyncReportReportID", Enabled = true)]
        // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
        // [RuleRequiredField(DefaultContexts.Save)] 
        // [IsSearch(true)]
        
        [DataSourceCriteria("Contains(ObjectName, 'ReportUI')")]
        public ImportObject ReportUIID
        {
            get { return _ReportUIID; }
            set { SetPropertyValue(nameof(ReportUIID), ref _ReportUIID, value); }
        }

        // 
        // Notes for SyncReport : 
        private string _ReportName;
        [XafDisplayName("ReportName"), ToolTip("ReportName")]
        // [Appearance("SyncReportReportName", Enabled = true)]
        // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
        // [RuleRequiredField(DefaultContexts.Save)] 
        // [IsSearch(true)]
        public string ReportName
        {
            get { return _ReportName; }
            set { SetPropertyValue(nameof(ReportName), ref _ReportName, value); }
        }
        // 
        // Notes for SyncReport : 
        private string _ScriptName;
        [XafDisplayName("ScriptName"), ToolTip("ScriptName")]
        // [Appearance("SyncReportScriptName", Enabled = true)]
        // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
        // [RuleRequiredField(DefaultContexts.Save)] 
        // [IsSearch(true)]
        public string ScriptName
        {
            get { return _ScriptName; }
            set { SetPropertyValue(nameof(ScriptName), ref _ScriptName, value); }
        }

        // 
        // Notes for SyncReport : 
        private ReportDataV2 _NameObject;
        [XafDisplayName("NameObject"), ToolTip("NameObject")]
        // [Appearance("SyncReportScriptName", Enabled = true)]
        // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
        // [RuleRequiredField(DefaultContexts.Save)] 
        // [IsSearch(true)]
        public ReportDataV2 NameObject
        {
            get { return _NameObject; }
            set { SetPropertyValue(nameof(NameObject), ref _NameObject, value); }
        }
    }
}
