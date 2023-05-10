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
    [System.ComponentModel.DisplayName("Email Group")]
    public class SyncEmailGroup : XPObject
    {
        //public SyncEmailGroup() : base()
        //{
        //    // This constructor is used when an object is loaded from a persistent storage.
        //    // Do not place any code here.
        //}

        public SyncEmailGroup(Session session) : base(session)
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

        }
        private string _Title;
        [RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Title"), ToolTip("Title")]
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

        
        //private SyncSetup _AlertCCEmail;
        //[RuleRequiredField(DefaultContexts.Save)]
        [Association("EmailCCGRP")]
        [XafDisplayName("EmailCCGRP"), ToolTip("EmailCCGRP")]

        //public  SyncSetup AlertCCEmail
        //{
        //    get { return _AlertCCEmail; }
        //    set { SetPropertyValue("AlertCCEmail", ref _AlertCCEmail, value); }
        //}
        public XPCollection<SyncSetup> AlertCCEmail
        {
            get
            {
                return GetCollection<SyncSetup>("AlertCCEmail");
            }
        }

        //private SyncSetup _alertTOEmail;
        //[RuleRequiredField(DefaultContexts.Save)]
        [Association("EmailTOGRP")]
        [XafDisplayName("EmailTOGRP"), ToolTip("EmailTOGRP")]

        //public  SyncSetup alertTOEmail
        //{
        //    get { return _alertTOEmail; }
        //    set { SetPropertyValue("alertTOEmail", ref _alertTOEmail, value); }
        //}
        public XPCollection<SyncSetup> alertTOEmail
        {
            get
            {
                return GetCollection<SyncSetup>("alertTOEmail");
            }
        }
        [Association("EmailPerson")]
        public XPCollection<SyncPeople> Emails
        {
            get
            {
                return GetCollection<SyncPeople>("Emails");
            }
        }
        [Association("EmailUserLogin")]
        public XPCollection<UserLoginInfo> EmailUserLogins
        {
            get
            {
                return GetCollection<UserLoginInfo>("EmailUserLogins");
            }
        }


        private DateTime _LastUpdate;
        [Appearance("SKBaseLastUpdateEnable", Enabled = false)]
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Date"), ToolTip("Date")]
        //[Size(50)]
        public  DateTime LastUpdate
        {
            get { return _LastUpdate; }
            set { SetPropertyValue("LastUpdate", ref _LastUpdate, value); }
        }

        //private UserInfo _LastUpdatedUser;
        //[Appearance("SKBaseLastUpdatedUserEnable", Enabled = false)]
        ////[RuleRequiredField(DefaultContexts.Save)]
        //[XafDisplayName("Last Update User"), ToolTip("Last Update User")]
        ////[Size(50)]
        //public  UserInfo LastUpdatedUser
        //{
        //    get { return _LastUpdatedUser; }
        //    set { SetPropertyValue("LastUpdatedUser", ref _LastUpdatedUser, value); }
        //}
    }

}