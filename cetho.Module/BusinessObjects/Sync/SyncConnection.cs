// Class Name : nOutlet.cs 
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
using DevExpress.ExpressApp.Editors;
using System.Reflection;
using DevExpress.Spreadsheet;
using DevExpress.Xpo.Metadata;
//using System.Collections;

namespace cetho.Module.BusinessObjects
{
    [DefaultClassOptions]
    [ImageName("ModelEditor_Views")]
    [DefaultProperty("Name")]
    [NavigationItem("Sync")]
    // Standard Document
    [System.ComponentModel.DisplayName("DataSet")]
    public class SyncConnection : XPObject
    {
        //public SyncConnection() : base()
        //{
        //    // This constructor is used when an object is loaded from a persistent storage.
        //    // Do not place any code here.
        //}
        public SyncConnection(Session session) : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            UpdateByTime();
            Active = eActiveStatus.Active;
            //RowHeader = 1;
            //ListAdd();
           // Updateby = (User)SecuritySystem.CurrentUser;
        }
        private void UpdateByTime()
        {
            string tUser = SecuritySystem.CurrentUserName.ToString();
            Updateby = Session.FindObject<UserLoginInfo>(new BinaryOperator("UserName", tUser));
            Updatedate = DateTime.Now;
        }


        protected override void OnSaving()
        {
            UpdateByTime();
            base.OnSaving();
        }
        protected override void OnDeleting()
        {
            base.OnDeleting();
        }

        //private SyncConnectionGroup _Group;
        ////[RuleRequiredField(DefaultContexts.Save)]
        //[XafDisplayName("DataSets"), ToolTip("DataSets")]
        //[Association("GroupConnections")]
        //[Size(20)]
        //public  SyncConnectionGroup Group
        //{
        //    get { return _Group; }
        //    set { SetPropertyValue("Group", ref _Group, value); }
        //}

        [XafDisplayName("Group"), ToolTip("Group")]
        [Association("GroupConnections")]
        public XPCollection<SyncConnectionGroup> Group
        {
            get
            {
                return GetCollection<SyncConnectionGroup>("Group");
            }
        }

        private string _Title;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Title"), ToolTip("Title")]
        [Size(20)]
        public  string Title
        {
            get { return _Title; }
            set { SetPropertyValue("Title", ref _Title, value); }
        }

        private string _DataBaseName;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("DataBase Name"), ToolTip("DataBase Name")]
        [Size(20)]
        public  string DataBaseName
        {
            get { return _DataBaseName; }
            set { SetPropertyValue("DataBaseName", ref _DataBaseName, value); }
        }

        private string _ConnectionString;
        [RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Connection String"), ToolTip("Connection String")]
        [Size(SizeAttribute.Unlimited)]
        public  string ConnectionString
        {
            get { return _ConnectionString; }
            set { SetPropertyValue("ConnectionString", ref _ConnectionString, value); }
        }

        [XafDisplayName("Active"), ToolTip("Active")]
        //[Size(50)]
        private eActiveStatus _Active;
        public  eActiveStatus Active
        {
            get { return _Active; }
            set { SetPropertyValue("Active", ref _Active, value); }
        }
        private UserLoginInfo _Updateby;
        [XafDisplayName("Update by"), ToolTip("Update by")]
        [Appearance("SyncConnectionUpdateby", Enabled = false)]
        public  UserLoginInfo Updateby
        {
            get { return _Updateby; }
            set { SetPropertyValue("Updateby", ref _Updateby, value); }
        }
        // 
        private DateTime _Updatedate;
        [XafDisplayName("Update date"), ToolTip("Update date")]
        [Appearance("SyncConnectionUpdatedate", Enabled = false)]
        public  DateTime Updatedate
        {
            get
            {
                //if (_Updatedate != null)
                //{
                //    _Updatedate = DateTime.Now;
                //}
                return _Updatedate;
            }
            set { SetPropertyValue("Updatedate", ref _Updatedate, value); }
        }


    }
    //public enum eActiveStatus
    //{
    //    [XafDisplayName("Active")]
    //    Active = 1,
    //    [XafDisplayName("Inactive")]
    //    Inactive = 0
    //};


}
