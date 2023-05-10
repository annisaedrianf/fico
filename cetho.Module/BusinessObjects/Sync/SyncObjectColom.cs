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
    [System.ComponentModel.DisplayName("Sync Object Map")]
    public class SyncObjectColom : XPObject
    {
        //public SyncObjectColom() : base()
        //{
        //    // This constructor is used when an object is loaded from a persistent storage.
        //    // Do not place any code here.
        //}
        public SyncObjectColom(Session session) : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            UpdateByTime();
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

        private SyncTask _SyncDBConnection;
        [XafDisplayName("Sync DB Connection"), ToolTip("Sync DB Connection")]
        [Association("ObjectSyncDB")]
        [Appearance("SyncDatabaseConnetionEnable", Enabled = false, Visibility = ViewItemVisibility.Hide)]
        public  SyncTask SyncDBConnection
        {
            get { return _SyncDBConnection; }
            set { SetPropertyValue("SyncDBConnection", ref _SyncDBConnection, value); }
        }

        private string _ObjectName;
        [XafDisplayName("Object Name"), ToolTip("Object Name")]
        //[Appearance("ImportColomnObjectName", Enabled = false, Visibility = ViewItemVisibility.Show)]
        public  string ObjectName
        {
            get { return _ObjectName; }
            set { SetPropertyValue("ObjectName", ref _ObjectName, value); }
        }

        private string _ImportName;
        [XafDisplayName("Import Name"), ToolTip("Import Name")]
     //   [DataSourceProperty("ImportFile.xlsColomn", DataSourcePropertyIsNullMode.SelectAll)]
        public  string ImportName
        {
            get { return _ImportName; }
            set { SetPropertyValue("ImportName", ref _ImportName, value); }
        }

        private int _ImportNameIdx;
        [XafDisplayName("Import Name Idx"), ToolTip("Import Name Idx")]
        [Appearance("ImportNameIdx", Visibility = ViewItemVisibility.Hide)]
        //   [DataSourceProperty("ImportFile.xlsColomn", DataSourcePropertyIsNullMode.SelectAll)]
        public  int ImportNameIdx
        {
            get { return _ImportNameIdx; }
            set { SetPropertyValue("ImportNameIdx", ref _ImportNameIdx, value); }
        }


        private UserLoginInfo _Updateby;
        [XafDisplayName("Update by"), ToolTip("Update by")]
        public  UserLoginInfo Updateby
        {
            get { return _Updateby; }
            set { SetPropertyValue("Updateby", ref _Updateby, value); }
        }
        // 
        private DateTime _Updatedate;
        [XafDisplayName("Update date"), ToolTip("Update date")]
        public  DateTime Updatedate
        {
            get
            {
                if (_Updatedate != null)
                {
                    _Updatedate = DateTime.Now;
                }
                return _Updatedate;
            }
            set { SetPropertyValue("Updatedate", ref _Updatedate, value); }
        }
    }

}
