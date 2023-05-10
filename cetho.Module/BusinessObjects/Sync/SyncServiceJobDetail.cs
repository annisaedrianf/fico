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
    [System.ComponentModel.DisplayName("Service Job Detail")]
    public class SyncServiceJobDetail : XPObject
    {
        //public SyncServiceJobDetail() : base()
        //{
        //    // This constructor is used when an object is loaded from a persistent storage.
        //    // Do not place any code here.
        //}

        public SyncServiceJobDetail(Session session) : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.


            //SecuritySystem.CurrentUserName
            //LastUpdatedUser = Session.GetObjectByKey<GPUser>(SecuritySystem.CurrentUserId);

            string tUser = SecuritySystem.CurrentUserName.ToString();
            //LastUpdatedUser = Session.FindObject<GPUser>(new BinaryOperator("UserName", SecuritySystem.CurrentUserName.ToString()));
            //LastUpdatedUser = Session.FindObject<UserInfo>( new BinaryOperator("UserName", tUser));
            LastUpdate = DateTime.Now;
            Date = DateTime.Now;
            Status = eJobDetail.Created;

        }
        private DateTime _Date;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Date *"), ToolTip("Date *")]
        //[Size(350)]
        //[NullText("Title")]
        public DateTime Date
        {
            get { return _Date; }
            set { SetPropertyValue("Date", ref _Date, value); }
        }

        private SyncServiceJob _ServiceJob;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Service Job"), ToolTip("Service Job")]
        [Association("JobsDetails")]
        public SyncServiceJob ServiceJob
        {
            get { return _ServiceJob; }
            set
            {
                SetPropertyValue("ServiceJob", ref _ServiceJob, value);
                if (!IsDeleted && !IsLoading && !IsSaving)
                {
                    if (value != null)
                    {
                        JobDetailType = eJobDetailType.SyncServiceJob;
                        Job = value;
                    }
                }
            }
        }

        private SyncDataFlows _SyncDataFlow;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Sync Data Flow"), ToolTip("Sync Data Flow")]
        [Association("DataFlowJobsDetails")]
        public SyncDataFlows SyncDataFlow
        {
            get { return _SyncDataFlow; }
            set
            {
                SetPropertyValue("SyncDataFlow", ref _SyncDataFlow, value);
                if (!IsDeleted && !IsLoading && !IsSaving)
                {
                    if (value != null)
                    {
                        JobDetailType = eJobDetailType.SyncDataFlows;
                        Job = value;
                    }
                }
            }
        }

        private eJobDetailType _JobDetailType;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Job Detail Type"), ToolTip("Job Detail Type")]

        public eJobDetailType JobDetailType
        {
            get
            {
                //if (_JobDetailType==null )
                //{
                //_JobDetailType = eJobDetailType.Service;
                //}
                return _JobDetailType;
            }
            set { SetPropertyValue("JobDetailType", ref _JobDetailType, value); }
        }

        public void Process(string vProcess = "")
        {

            Status = eJobDetail.Process;
            try
            {
                if (SyncDataFlow != null)
                {
                    if (ConnectionJob != null)
                    {
                        Console.WriteLine($"Will process Data Flow {vProcess}  {SyncDataFlow.Title}   {ConnectionJob.Title} ");
                        SyncDataFlow.Process(ConnectionJob, vProcess);
                        Console.WriteLine($"Done process Data Flow {vProcess}  {SyncDataFlow.Title}   {ConnectionJob.Title} ");
                    }
                    else
                    {
                        Console.WriteLine($"Done process Data Flow  {vProcess} {SyncDataFlow.Title}   No connection  ");
                    }
                }
                else
                {
                    Console.WriteLine($"Will Process  {vProcess} {ServiceJob.Title}");
                    ServiceJob.Process();
                    Console.WriteLine($"Done Process {vProcess} {ServiceJob.Title}");
                }
            }
            catch
            { }

            Status = eJobDetail.Done;
        }
        private object _Job;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Job"), ToolTip("Job")]
        public object Job
        {
            get
            {
                if (_Job == null)
                {

                    if (SyncDataFlow == null)
                    {
                        _Job = ServiceJob;
                    }
                    else
                    {
                        _Job = SyncDataFlow;
                    }

                }
                return _Job;
            }
            set
            {
                //if (value == eJobDetail.Done)
                //{
                //    SyncEmailService eService = new SyncEmailService();
                //    eService.WriteToFile("  update job detail  " );
                //}
                SetPropertyValue("Job", ref _Job, value);
            }
        }

        private eJobDetail _Status;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Status"), ToolTip("Status")]
        public eJobDetail Status
        {
            get
            {
                //double cjDiff = (DateTime.Now.AddDays(50) - LastUpdate).Seconds;
                //if ( _Status==eJobDetail.Process && cjDiff >1)
                //{
                //    _Status = eJobDetail.Created;
                //}
                return _Status;
            }
            set
            {
                //if (value == eJobDetail.Done)
                //{
                //    SyncEmailService eService = new SyncEmailService();
                //    eService.WriteToFile("  update job detail  " );
                //}
                SetPropertyValue("Status", ref _Status, value);
                if (!IsLoading && !IsSaving)
                {
                    LastUpdate = DateTime.Now;
                }
            }
        }

        private SyncConnection _ConnectionJob;
        [Appearance("ConnectionJobEnable", Enabled = false)]
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Connection Job"), ToolTip("Connection Job")]
        //[Size(50)]
        public SyncConnection ConnectionJob
        {
            get { return _ConnectionJob; }
            set { SetPropertyValue("ConnectionJob", ref _ConnectionJob, value); }
        }

        private DateTime _LastUpdate;
        [Appearance("SyncSetupLastUpdateEnable", Enabled = false)]
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Last Update"), ToolTip("Las tUpdate")]
        //[Size(50)]
        public DateTime LastUpdate
        {
            get { return _LastUpdate; }
            set { SetPropertyValue("LastUpdate", ref _LastUpdate, value); }
        }

        //private UserInfo _LastUpdatedUser;
        //[Appearance("SyncSetupLastUpdatedUserEnable", Enabled = false)]
        ////[RuleRequiredField(DefaultContexts.Save)]
        //[XafDisplayName("Last Update User"), ToolTip("Last Update User")]
        ////[Size(50)]
        //public  UserInfo LastUpdatedUser
        //{
        //    get { return _LastUpdatedUser; }
        //    set { SetPropertyValue("LastUpdatedUser", ref _LastUpdatedUser, value); }

        //}
    }
    /*
     * 
     * job detail type 
     */

    public enum eJobDetailType
    {

        [XafDisplayName("SyncServiceJob")]
        SyncServiceJob = 0,
        [XafDisplayName("SyncDataFlows")]
        SyncDataFlows = 1
    }
    //public enum eJobDetail
    //{
    //    [XafDisplayName("Created")]
    //    Created = 0,
    //    [XafDisplayName("Process")]
    //    Process = 1,
    //    [XafDisplayName("Done")]
    //    Done = 2
    //};

}