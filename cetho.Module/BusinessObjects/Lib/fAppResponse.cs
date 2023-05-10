// Class Name : fVechType.cs 
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
using DevExpress.Persistent.BaseImpl;
using DevExpress.ExpressApp.Model;

namespace cetho.Module.BusinessObjects
{
    [DefaultClassOptions]
    [ImageName("ModelEditor_Views")]
    [DefaultProperty("Code")]
    [NavigationItem("Services")]
    // Standard Document
    [System.ComponentModel.DisplayName("App Response")]
    public class fAppResponse : XPObject
    {
        public fAppResponse() : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }
        public fAppResponse(Session session) : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            string tUser = SecuritySystem.CurrentUserName.ToString();
            Description = "";
            ReportName = "";
            Value = "";
            Active = true;
            Information = "";
            Notification = "";
        }
        protected override void OnSaving()
        {
            base.OnSaving();
        }
        protected override void OnDeleting()
        {
            base.OnDeleting();
        }
        //
        private string _KeyWord;
        [XafDisplayName("KeyWord"), ToolTip("KeyWord")]
        [Size(10)]
        public  string KeyWord
        {
            get { return _KeyWord; }
            set { SetPropertyValue("KeyWord", ref _KeyWord, value); }
        }
        private string _Information;
        [XafDisplayName("Information"), ToolTip("Information")]
        [Size(150)]
        public  string Information
        {
            get {
                if (_Information == null)
                {
                    _Information = "";
                }
                return _Information; }
            set { SetPropertyValue("Information", ref _Information, value); }
        }

        private string _Notification;
        [XafDisplayName("Notification"), ToolTip("Notification")]
        [Size(150)]
        public  string Notification
        {
            get {
                if (_Notification == null)
                {
                    _Notification = "";
                }
                return _Notification; }
            set { SetPropertyValue("Notification", ref _Notification, value); }
        }
        //
        private string _Description;
        [XafDisplayName("Description"), ToolTip("Description")]
        [Size(300)]
        public  string Description
        {
            get { 
                 if (_Description==null)
                {
                    _Description = "";
                }
                return _Description; }
            set { SetPropertyValue("Description", ref _Description, value); }
        }
        private eAppResponseType _Type;
        [XafDisplayName("Type"), ToolTip("Type")]
        [Size(150)]
        public  eAppResponseType Type
        {
            get { return _Type; }
            set { SetPropertyValue("Type", ref _Type, value); }
        }
        private string _ReportName;
        [XafDisplayName("Report Name"), ToolTip("Report Name")]
        [Size(50)]
        public  string ReportName
        {
            get { return _ReportName; }
            set { SetPropertyValue("ReportName", ref _ReportName, value); }
        }

        private string _Value;
        [XafDisplayName("Value"), ToolTip("Value")]
        [Size(50)]
        public  string Value
        {
            get { return _Value; }
            set { SetPropertyValue("Value", ref _Value, value); }
        }

        private eNotifyOn _Every;
        [XafDisplayName("Every"), ToolTip("Every")]
        [Size(50)]
        public  eNotifyOn Every
        {
            get { return _Every; }
            set { SetPropertyValue("Every", ref _Every, value); }
        }

        private DateTime _StartProcess;
        [XafDisplayName("Start Process"), ToolTip("Start Process")]
        [ModelDefault("DisplayFormat", "{0: dd/MMM/yyyy hh:mm:ss }")]
        //[Size(50)]
        public  DateTime StartProcess
        {
            get { return _StartProcess; }
            set { SetPropertyValue("StartProcess", ref _StartProcess, value); }
        }

        private DateTime _LastProcess;
        [XafDisplayName("Last Process"), ToolTip("Last Process")]
        [ModelDefault("DisplayFormat", "{0: dd/MMM/yyyy hh:mm:ss }")]
        //[Size(50)]
        public  DateTime LastProcess
        {
            get { return _LastProcess; }
            set { SetPropertyValue("LastProcess", ref _LastProcess, value); }
        }

        private bool _Active;
        [XafDisplayName("Active"), ToolTip("Active")]

        //[Size(50)]
        public  bool Active
        {
            get { return _Active; }
            set { SetPropertyValue("Active", ref _Active, value); }
        }

        [XafDisplayName("Users"), ToolTip("Users")]
        [Association("UserResponse")]
        public XPCollection<UserLoginInfo> Users
        {
            get
            {
                return GetCollection<UserLoginInfo>("Users");
            }
        }


    }
    public enum eNotifyOn
    {
        [XafDisplayName("Month")]
        Month = 0,
        [XafDisplayName("Week")]
        Week = 1,
        [XafDisplayName("Day")]
        Day = 2,
        [XafDisplayName("Hours")]
        Hours = 3,
        [XafDisplayName("Minute")]
        Minute = 4,
        [XafDisplayName("Second")]
        Second = 5
    }

    public enum eAppResponseType
    {
        [XafDisplayName("Report")]
        Report = 0,
        [XafDisplayName("Notify")]
        Notify = 1,
        [XafDisplayName("Others")]
        Others = 2,
        [XafDisplayName("Report & Notify")]
        NotifyReport = 3
    }

}