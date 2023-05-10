using System;
using DevExpress.Xpo;
using DevExpress.Persistent.Base;
using System.ComponentModel;
using DevExpress.Persistent.Validation;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.ConditionalAppearance;
using DevExpress.ExpressApp;
using DevExpress.Data.Filtering;

namespace cetho.Module.BusinessObjects
{

    [DefaultClassOptions]
    [ImageName("ModelEditor_Views")]
    [DefaultProperty("Title")]
    [NavigationItem("Services")]
    // Standard Document
    [System.ComponentModel.DisplayName("Jobs History")]
    public class SyncJobsHistory : XPObject
    {
        //public SyncJobsHistory() : base()
        //{
        //    // This constructor is used when an object is loaded from a persistent storage.
        //    // Do not place any code here.
        //}

        public SyncJobsHistory(Session session) : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            Date = DateTime.Now;

        }
        //private string _Title;
        ////[RuleRequiredField(DefaultContexts.Save)]
        //[XafDisplayName("Title *"), ToolTip("Title *")]
        //[Size(350)]
        //[NullText("Title")]
        //public  string Title
        //{
        //    get { return _Title; }
        //    set { SetPropertyValue("Title", ref _Title, value); }
        //}
        private int _OidRef;
        [XafDisplayName("OidRef"), ToolTip("OidRef")]
        public  int OidRef
        {
            get { return _OidRef; }
            set { SetPropertyValue("OidRef", ref _OidRef, value); }
        }
        private DateTime _Date;
        [XafDisplayName("Date"), ToolTip("Date")]
        public  DateTime Date
        {
            get { return _Date; }
            set { SetPropertyValue("Date", ref _Date, value); }
        }
        private eJobsHistoryType _JobsHistoryType;
        [XafDisplayName("Jobs History Type"), ToolTip("Jobs History Type")]
        public  eJobsHistoryType JobsHistoryType
        {
            get { return _JobsHistoryType; }
            set { SetPropertyValue("JobsHistoryType", ref _JobsHistoryType, value); }
        }
        private int _ProcessID;
        [XafDisplayName("Process ID"), ToolTip("Process ID")]
        public  int ProcessID
        {
            get { return _ProcessID; }
            set { SetPropertyValue("ProcessID", ref _ProcessID, value); }
        }
    }
    public enum eJobsHistoryType
    {
        [XafDisplayName("SyncServiceJob")]
        SyncServiceJob = 0

    };
}