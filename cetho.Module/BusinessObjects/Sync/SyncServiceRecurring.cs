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
    [System.ComponentModel.DisplayName("Service Recurring")]
    public class SyncServiceRecurring : XPObject
    {
        //public SyncServiceRecurring() : base()
        //{
        //    // This constructor is used when an object is loaded from a persistent storage.
        //    // Do not place any code here.
        //}

        public SyncServiceRecurring(Session session) : base(session)
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
         //   LastUpdatedUser = Session.FindObject<UserInfo>( new BinaryOperator("UserName", tUser));

            LastUpdate = DateTime.Now;

        }
        private string _Title;
        [RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Title *"), ToolTip("Title *")]
        [Size(350)]
        [NullText("Title")]
        public  string Title
        {
            get { return _Title; }
            set { SetPropertyValue("Title", ref _Title, value); }
        }

        private string _Description;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Description"), ToolTip("Description")]
        [Size(SizeAttribute.Unlimited)]
        public  string Description
        {
            get { return _Description; }
            set { SetPropertyValue("Description", ref _Description, value); }
        }

        private eSrvRecType _Type;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Type"), ToolTip("Type")]
        //[Size(SizeAttribute.Unlimited)]
        public  eSrvRecType Type
        {
            get { return _Type; }
            set { SetPropertyValue("Type", ref _Type, value); }
        }
        private Boolean _NoEndDate;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("No End Date"), ToolTip("No End Date")]
        public  Boolean NoEndDate
        {
            get { return _NoEndDate; }
            set { SetPropertyValue("NoEndDate", ref _NoEndDate, value); }
        }
       
        private DateTime _EndBy;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("End By"), ToolTip("End By")]
        public  DateTime EndBy
        {
            get { return _EndBy; }
            set { SetPropertyValue("EndBy", ref _EndBy, value); }
        }

        private DateTime _StartAt;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Start At"), ToolTip("Start At")]
        public  DateTime StartAt
        {
            get { return _StartAt; }
            set { SetPropertyValue("StartAt", ref _StartAt, value); }
        }

        private double  _Every;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Every"), ToolTip("Every")]
        public  double Every
        {
            get { return _Every; }
            set { SetPropertyValue("Every", ref _Every, value); }
        }

        private eSrvRecEvery _EveryOUM;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Every OUM"), ToolTip("Every OUM")]
        public  eSrvRecEvery EveryOUM
        {
            get { return _EveryOUM; }
            set { SetPropertyValue("EveryOUM", ref _EveryOUM, value); }
        }
        
        private DateTime _LastUpdate;
        [Appearance("SyncSetupLastUpdateEnable", Enabled = false)]
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Last Update Date"), ToolTip("Last Update Date")]
        //[Size(50)]
        public  DateTime LastUpdate
        {
            get { return _LastUpdate; }
            set { SetPropertyValue("LastUpdate", ref _LastUpdate, value); }
        }

       
    }
    //public enum eSrvRecType
    //{
    //    [XafDisplayName("Daily")]
    //    Daily = 0,
    //    [XafDisplayName("Weekly")]
    //    Weekly = 1,
    //    [XafDisplayName("Monthly")]
    //    Monthly = 2,
    //    [XafDisplayName("Yearly")]
    //    Yearly = 3
    //};
    //public enum eSrvRecEvery
    //{
    //    [XafDisplayName("Second")]
    //    Second = 0,
    //    [XafDisplayName("Munites")]
    //    Munites = 1,
    //    [XafDisplayName("Hours")]
    //    Hours = 2,
    //    [XafDisplayName("Days")]
    //    Days = 3,
    //    [XafDisplayName("Months")]
    //    Months = 4,
    //    [XafDisplayName("Years")]
    //    Years = 5
    //};
}