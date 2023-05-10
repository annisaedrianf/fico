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
    [System.ComponentModel.DisplayName("Sync Task")]
    public class SyncTask : XPObject
    {
        //public SyncTask() : base()
        //{
        //    // This constructor is used when an object is loaded from a persistent storage.
        //    // Do not place any code here.
        //}
        public SyncTask(Session session) : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            UpdateByTime();
            Active = eActiveStatus.Active;
            No = 0;
            ExecCommand = "";
            ConnectionType = eConnectionType.SQLServerQuery;
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
            if (SyncDB != null)
            {
                if (No < 1)
                {
                    No = SyncDB.Tasks.Count;
                    //SyncDB.
                    //var list = SyncDB.Where( x=> x.Tasks.Where( c => x.Oid== x.Oid))
                    //Session NewSession = Session;
                    //XPCollection<SyncDataFlows> DataFlows;
                    //DataFlows.Where( x => x.Tasks.Where(j=> j.Oid)
                }

            }
            base.OnSaving();
        }
        protected override void OnDeleting()
        {
            base.OnDeleting();
        }


        private SyncDataFlows _SyncDB;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Sync DB"), ToolTip("Sync DB")]
        [Association("SyncDBTask")]

        [Size(20)]
        public  SyncDataFlows SyncDB
        {
            get { return _SyncDB; }
            set { SetPropertyValue("SyncDB", ref _SyncDB, value); }
        }

        //[XafDisplayName("SyncDB"), ToolTip("SyncDB")]
        //[Association("SyncDBTask")]
        //public XPCollection<SyncDataFlows> SyncDB
        //{
        //    get
        //    {
        //        return GetCollection<SyncDataFlows>("SyncDB");
        //    }
        //}

        private SyncTask _CopyTask;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Copy Task"), ToolTip("Copy Task")]
        [Size(20)]
        public  SyncTask CopyTask
        {
            get { return _CopyTask; }
            set
            {
                SetPropertyValue("CopyTask", ref _CopyTask, value);
                if (!IsLoading && !IsSaving && !IsDeleted)
                {
                    if (value != null)
                    {
                        TaskCopyForm(value);
                    }

                }
            }
        }

        public void TaskCopyForm(SyncTask oTask)
        {
            if (oTask.ObjectName != null)
            {
                if (oTask.ObjectName == ObjectName)
                {

                    foreach (SyncObjectColom item in Colomn)
                    {
                        foreach (SyncObjectColom itemCopy in oTask.Colomn)
                        {
                            if (item.ObjectName == itemCopy.ObjectName)
                            {
                                item.ImportName = itemCopy.ImportName;
                                break;
                            }
                        }
                    }

                    ExecCommand = oTask.ExecCommand;


                    //foreach ( SyncMethod item in oTask.Methods )
                    //{
                    //    bool find = false;
                    //     foreach ( SyncMethod ItemOrg in Methods)
                    //      {
                    //         if ( item.Method== ItemOrg.Method)
                    //        {
                    //            find = true;
                    //        }
                    //      }
                    //     if ( !find)
                    //        {
                    //        Session NewSession = Session;

                    //        //SyncMethod oSyncMethod = new SyncMethod(NewSession);
                    //        //oSyncMethod.Method = item.Method;
                    //        //oSyncMethod.Task = this;
                    //        //NewSession.Save(oSyncMethod);
                    //        this.Methods.Add(item);

                    //        }
                    //}
                }
            }
        }

        private int _No;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("No"), ToolTip("No")]
        [Size(20)]
        public  int No
        {
            get { return _No; }
            set { SetPropertyValue("No", ref _No, value); }
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



        private ImportObject _ObjectName;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Object Name"), ToolTip("Object Name")]
        //[Size(SizeAttribute.Unlimited)]
        [ImmediatePostData]
        public  ImportObject ObjectName
        {
            get { return _ObjectName; }
            set
            {
                SetPropertyValue("ObjectName", ref _ObjectName, value);
                if (!IsLoading && !IsSaving)
                {
                    try
                    {
                        if (value != null)
                        {
                            DataType = value.ObjectName;
                            DataType = value.FullObjectName;
                            UpdateTempate();
                        }
                        else
                        {
                            SetObjectNameEmpty();
                        }
                        this.Save();
                        this.Session.CommitTransaction();
                    }
                    catch (Exception e)
                    {
                        SetObjectNameEmpty();
                    }

                }

            }
        }
        private void SetObjectNameEmpty()
        {
            DataType = "";
            ObjectFullNameType = "";
            Session.Delete(Colomn);
            Session.Save(Colomn);

        }
        public void UpdateTempate(string sDataType = "")
        {
            DataType = sDataType;
            Session.Delete(Colomn);
            Session.Save(Colomn);
            if (ObjectName.ObjectName != null)
            {
                if (ObjectName.ObjectName != "")
                {
                    string objectType = "cetho.Module.BusinessObjects." + ObjectName.FullObjectName;
                    objectType = ObjectName.FullObjectName;
                    Type oType = Type.GetType(objectType);
                    UpdateTempate(oType);
                }
                // ImportData(oType, "", "", Sheet.SheetName, RowHeader);
            }

        }
        private string _ObjectFullNameType;
        [XafDisplayName("Object Type"), ToolTip("Object Type")]
        [Appearance("FileObjectType", Enabled = false, Visibility = ViewItemVisibility.Hide)]
        public  string ObjectFullNameType
        {
            get { return _ObjectFullNameType; }
            set { SetPropertyValue("ObjectFullNameType", ref _ObjectFullNameType, value); }
        }
        public void UpdateTempate<T>(T ObjType, string objMaster = null, string sMasterPropertyName = "") where T : Type
        {
            //DataType = ObjType.Name.Substring(1, ObjType.Name.Length-1);
            ObjectFullNameType = ObjType.FullName;

            // DataType = ObjType.Name.Substring(1, ObjType.Name.Length - 1);
            // IObjectSpace objectSpace = Application.CreateObjectSpace(typeof(Person));
            PropertyInfo[] properties = ObjType.GetProperties();
            iGetKey oGetKey = new iGetKey();
            List<string> aNotlist = oGetKey.FieldNoshow();
            // add colom to oject 
            foreach (PropertyInfo item in properties)
            {
                object[] attributesArray = item.GetCustomAttributes(true);

                foreach (Attribute at in attributesArray)
                {
                    if (at is IsHide)
                    {
                        aNotlist.Add(item.Name.ToUpper());
                    }
                }

                //if (!oGetKey.FieldNoshow().Contains(item.Name.ToUpper()))
                if (!aNotlist.Contains(item.Name.ToUpper()))
                {
                    SyncObjectColom oSyncObjectColom = new SyncObjectColom(Session);
                    //ImportColom iImportColom = new ImportColom();
                    oSyncObjectColom.ObjectName = item.Name;
                    oSyncObjectColom.SyncDBConnection = this;
                    oSyncObjectColom.Save();
                    oSyncObjectColom.Session.CommitTransaction();
                    //ImportColoms.Add(iImportColom);
                }
            }
            // XPClassInfo ObjTypeClassInfo = Session.GetClassInfo(ObjType);
        }
        private string _DataType;
        [XafDisplayName("Data Type"), ToolTip("Data Type")]
        [Appearance("FileDataType", Enabled = false, Visibility = ViewItemVisibility.Hide)]

        public  string DataType
        {
            get { return _DataType; }
            set { SetPropertyValue("DataType", ref _DataType, value); }
        }

        private eConnectionType _ConnectionType;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Connection Type"), ToolTip("Connection Type")]
        [Size(20)]
        public  eConnectionType ConnectionType
        {
            get { return _ConnectionType; }
            set { SetPropertyValue("ConnectionType", ref _ConnectionType, value); }
        }

        private string _ExecCommand;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Exec Command"), ToolTip("Exec Command")]
        [Size(SizeAttribute.Unlimited)]
        public  string ExecCommand
        {
            get { return _ExecCommand; }
            set { SetPropertyValue("ExecCommand", ref _ExecCommand, value); }
        }

        public string ScriptCommand()
        {
            return SyncDB.ReplaceCommandFilter(ExecCommand);
        }

        [XafDisplayName("Object Colomn"), ToolTip("Object Colomn")]
        [Association("ObjectSyncDB")]
        public XPCollection<SyncObjectColom> Colomn
        {
            get
            {
                return GetCollection<SyncObjectColom>("Colomn");
            }
        }


        [XafDisplayName("Methods"), ToolTip("Methods")]
        [Association("SyncTaskTask"), DevExpress.Xpo.Aggregated]
        public XPCollection<SyncMethod> Methods
        {
            get
            {
                return GetCollection<SyncMethod>("Methods");
            }
        }

        //private SyncConnection _Connection;
        //[RuleRequiredField(DefaultContexts.Save)]
        //[XafDisplayName("Connection"), ToolTip("Schedule")]
        ////[Size(SizeAttribute.Unlimited)]
        //public  SyncConnection Connection
        //{
        //    get { return _Connection; }
        //    set { SetPropertyValue("Connection", ref _Connection, value); }
        //}

        //[XafDisplayName("Connection"), ToolTip("Connection")]
        //[Association("TaskConnectionGroup")]
        //public XPCollection<SyncConnectionGroup> Connections
        //{
        //    get
        //    {
        //        return GetCollection<SyncConnectionGroup>("Connections");
        //    }
        //}


        //[XafDisplayName("Connection"), ToolTip("Connection")]
        //[Association("TaskConnection")]
        //public XPCollection<SyncTaskConnection> Connection
        //{
        //    get
        //    {
        //        return GetCollection<SyncTaskConnection>("Connection");
        //    }
        //}

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
        [Appearance("SyncDatabaseConnetionUpdateby", Enabled = false)]
        public  UserLoginInfo Updateby
        {
            get { return _Updateby; }
            set { SetPropertyValue("Updateby", ref _Updateby, value); }
        }
        // 
        private DateTime _Updatedate;
        [XafDisplayName("Update date"), ToolTip("Update date")]
        [Appearance("SyncDatabaseConnetionUpdatedate", Enabled = false)]
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
    public enum eConnectionType
    {
        [XafDisplayName("OS CmdExec")]
        OSCmdExec = 0,
        [XafDisplayName("PowerShell")]
        PowerShell = 1,
        [XafDisplayName("[SQL Server]Query")]
        SQLServerQuery = 3,
        [XafDisplayName("[SQL Server]Proc")]
        SQLServerProc = 4,
        [XafDisplayName("[SQL Server] Proc Returned Data")]
        SQLServerProcReturnedData = 5,
        [XafDisplayName("[python] Script")]
        PythonScript = 6
    }
}
