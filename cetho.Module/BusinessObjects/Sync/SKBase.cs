using System;
using DevExpress.Xpo;
using DevExpress.Persistent.Base;
using System.ComponentModel;
using DevExpress.Persistent.Validation;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.ConditionalAppearance;
using DevExpress.ExpressApp;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp.Editors;

namespace cetho.Module.BusinessObjects
{

    [DefaultClassOptions]
    [ImageName("ModelEditor_Views")]
    [DefaultProperty("Title")]
    [NavigationItem("Sync")]
    // Standard Document
    [System.ComponentModel.DisplayName("Base")]
    public class SKBase : XPObject
    {
        //public SKBase() : base()
        //{
        //    // This constructor is used when an object is loaded from a persistent storage.
        //    // Do not place any code here.
        //}

        public SKBase(Session session) : base(session)
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
            LastUpdatedUser = Session.FindObject<ApplicationUser>( new BinaryOperator("UserName", tUser));

            LastUpdate = DateTime.Now;

        }
        private string _Title;
        //[RuleRequiredField(DefaultContexts.Save)]
        [Appearance("SKBaseTitle", Visibility = ViewItemVisibility.Hide)]
        [XafDisplayName("Title *"), ToolTip("Title *")]
        [Size(350)]
        [NullText("Title")]
        public virtual string Title
        {
            get { return _Title; }
            set { SetPropertyValue("Title", ref _Title, value); }
        }

        private string _Description;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Description"), ToolTip("Description")]
        [Appearance("SKBaseDescription", Visibility = ViewItemVisibility.Hide)]
        [Size(SizeAttribute.Unlimited)]
        public virtual string Description
        {
            get { return _Description; }
            set { SetPropertyValue("Description", ref _Description, value); }
        }

        private string _KeyWord;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("KeyWord"), ToolTip("KeyWord")]
        [Size(350)]
        [NullText("KeyWord")]
        public virtual string KeyWord
        {
            get { return _KeyWord; }
            set { SetPropertyValue("KeyWord", ref _KeyWord, value); }
        }

        private DateTime _LastUpdate;
        [Appearance("SKBaseLastUpdateEnable", Enabled = false)]
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Date"), ToolTip("Date")]
        //[Size(50)]
        public virtual DateTime LastUpdate
        {
            get { return _LastUpdate; }
            set { SetPropertyValue("LastUpdate", ref _LastUpdate, value); }
        }

        private ApplicationUser _LastUpdatedUser;
        [Appearance("SKBaseLastUpdatedUserEnable", Enabled = false)]
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Last Update User"), ToolTip("Last Update User")]
        //[Size(50)]
        public virtual ApplicationUser LastUpdatedUser
        {
            get { return _LastUpdatedUser; }
            set { SetPropertyValue("LastUpdatedUser", ref _LastUpdatedUser, value); }
        }
    }

}