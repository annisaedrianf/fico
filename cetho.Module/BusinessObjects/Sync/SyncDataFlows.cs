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
using DevExpress.Xpo.DB;
using DevExpress.ExpressApp.Xpo;
using DevExpress.CodeParser;
using DevExpress.ExpressApp.Model;
//using System.ComponentModel.DataAnnotations;
//using System.Collections;

namespace cetho.Module.BusinessObjects
{
    [DefaultClassOptions]
    [ImageName("ModelEditor_Views")]
    [DefaultProperty("Title")]
    [NavigationItem("Sync")]
    // Standard Document
    [System.ComponentModel.DisplayName("Configure Data Flows")]
    public class SyncDataFlows : XPObject
    {
        /*
         *
          period filter
            
         */ 
        //public SyncDataFlows() : base()
        //{
        //    // This constructor is used when an object is loaded from a persistent storage.
        //    // Do not place any code here.
        //}
        public SyncDataFlows(Session session) : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            UpdateByTime();
            Active = eActiveStatus.Active;
            InitiationProcess = System.DateTime.Now;
            Sync sync = new Sync();
            Session newSession = Session;
            sync.ImportObjectSyncSession(newSession);
            //sync.UpdateSync(newSession);

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


        private string _Title;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Title"), ToolTip("Title")]
        [Size(20)]
        public  string Title
        {
            get { return _Title; }
            set { SetPropertyValue("Title", ref _Title, value); }
        }

        private SyncServiceRecurring _Schedule;
        [RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Schedule"), ToolTip("Schedule")]
        //[Size(SizeAttribute.Unlimited)]
        public SyncServiceRecurring Schedule
        {
            get { return _Schedule; }
            set { SetPropertyValue("Schedule", ref _Schedule, value); }
        }

        private DateTime _InitiationProcess;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Initiation Process"), ToolTip("Initiation Process")]
        //[Size(SizeAttribute.Unlimited)]
        [ModelDefault("DisplayFormat", "{0:f}")]
        public  DateTime InitiationProcess
        {
            get { return _InitiationProcess; }
            set { SetPropertyValue("InitiationProcess", ref _InitiationProcess, value); }
        }


        /*
         * format filetr #F#MMYY#F# atau jika tanggal #|#ddMMyy#|#
         */
        private DateTime _FilterFrom;
        [RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Filter From"), ToolTip("Filter From")]
        //[Size(SizeAttribute.Unlimited)]
        public  DateTime FilterFrom
        {
            get { return _FilterFrom; }
            set { SetPropertyValue("FilterFrom", ref _FilterFrom, value); }
        }

        /*
         * format filetr #T#MMYY#T# 
         */
        private DateTime _FilterTo;
        [RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Filter To"), ToolTip("Filter To")]
        //[Size(SizeAttribute.Unlimited)]
        public  DateTime FilterTo
        {
            get { return _FilterTo; }
            set { SetPropertyValue("FilterTo", ref _FilterTo, value); }
        }

        
        public string ReplaceCommandFilter ( string sCommand )
        {
            List<string> aDateFormat = new List<string> { "yyyyMMdd", "yyyyyMM", "yyyy" };

            foreach (string aDate in aDateFormat)
            {
                sCommand = sCommand.Replace($"#F#{aDate}#F#",FilterFrom.ToString(aDate));
                sCommand = sCommand.Replace($"#T#{aDate}#T#", FilterTo.ToString(aDate));
            }

            return sCommand;
        }



        [XafDisplayName("Task"), ToolTip("Task")]
        [Association("SyncDBTask")]
        public XPCollection<SyncTask> Tasks
        {
            get
            {
                return GetCollection<SyncTask>("Tasks");
            }
        }

        [Action(Caption = "CreateJobDetail")]
        public void JobDetail()
        {
            int i = CreateJobDetail();
        }

        [Action(Caption = "Process")]
        //public void Process (string vProcess="")
        public void Process()
        {
            // check SyncTask 
            string vProcess = "";

            foreach (SyncTask oTask in Tasks.OrderBy(x => x.No))
            {
                
               
                    ProcessTask( oTask, vProcess);
                
            }
        }

        public void Process(SyncConnection oConection, string  vProcess="")
        {
            // check SyncTask 

            foreach (SyncTask oTask in Tasks.OrderBy(x => x.No))
            {
                ProcessTask(oTask, oConection, vProcess);
            }
        }


        [XafDisplayName("Connection"), ToolTip("Connection")]
        [Association("SyncDataFlowsConnectionGroup")]
        public XPCollection<SyncConnectionGroup> Connections
        {
            get
            {
                return GetCollection<SyncConnectionGroup>("Connections");
            }
        }

        [XafDisplayName("JobDetails"), ToolTip("JobDetail")]
        [Association("DataFlowJobsDetails")]
        public XPCollection<SyncServiceJobDetail> JobDetails
        {
            get
            {
                return GetCollection<SyncServiceJobDetail>("JobDetails");
            }
        }

        public void ProcessTask(SyncTask oTask, SyncConnection aConnection,string vProcess)
        {
            string connectionString = "";

                    XPObjectSpaceProvider osProvider;
         
                    connectionString = aConnection.ConnectionString;
                    osProvider = new XPObjectSpaceProvider(connectionString, null);
                    IObjectSpace objectSpace = osProvider.CreateObjectSpace();
                    Session currentSession = ((XPObjectSpace)objectSpace).Session;
                    //string queryString = oTask.ExecCommand;
                    string queryString = oTask.ScriptCommand();
                    //SelectedData GetData = currentSession.ExecuteQuery(queryString);
            if (oTask.ConnectionType == eConnectionType.SQLServerQuery)
                    {
                        Type oType = Type.GetType(oTask.ObjectName.FullObjectName);
                        SelectedData GetData = currentSession.ExecuteQueryWithMetadata(queryString);
                        TransferData(oType, GetData, oTask, vProcess +" - " + aConnection.Title);
                    }
                    else if (oTask.ConnectionType == eConnectionType.SQLServerProc)
                    {
                        currentSession.ExecuteSproc(queryString);
                    }
                    else if (oTask.ConnectionType == eConnectionType.SQLServerProcReturnedData)
                    {
                        Type oType = Type.GetType(oTask.ObjectName.FullObjectName);
                        SelectedData GetData = currentSession.ExecuteSproc(queryString);
                        TransferData(oType, GetData, oTask);
                    }

        }
        public void ProcessTask(SyncTask oTask,string vProcess)
        {
            string connectionString = "";

            XPObjectSpaceProvider osProvider;
            XPCollection<SyncConnectionGroup> oConnTask =Connections;
            foreach (SyncConnectionGroup aConnGroup in oConnTask)
            {
                foreach (SyncConnection aConnection in aConnGroup.Connections)
                {
                    connectionString = aConnection.ConnectionString;
                    osProvider = new XPObjectSpaceProvider(connectionString, null);
                    IObjectSpace objectSpace = osProvider.CreateObjectSpace();
                    Session currentSession = ((XPObjectSpace)objectSpace).Session;
                    //string queryString = oTask.ExecCommand;
                    string queryString = oTask.ScriptCommand();
                    //SelectedData GetData = currentSession.ExecuteQuery(queryString);
                    if (oTask.ConnectionType == eConnectionType.SQLServerQuery)
                    {
                        Type oType = Type.GetType(oTask.ObjectName.FullObjectName);
                        SelectedData GetData = currentSession.ExecuteQueryWithMetadata(queryString);
                        TransferData(oType, GetData, oTask, vProcess +"-" +aConnection.Title);
                    }
                    else if (oTask.ConnectionType == eConnectionType.SQLServerProc)
                    {
                        currentSession.ExecuteSproc(queryString);
                    }
                    else if (oTask.ConnectionType == eConnectionType.SQLServerProcReturnedData)
                    {
                        Type oType = Type.GetType(oTask.ObjectName.FullObjectName);
                        SelectedData GetData = currentSession.ExecuteSproc(queryString);
                        TransferData(oType, GetData, oTask);
                    }

                    // process transfer data 
                }
            }
            //}

        }
        public void ProcessTaskOld(SyncTask oTask)
        {
            string connectionString = "";
           //string  connectionString = $"Integrated Security=SSPI;Pooling=false;Data Source=IDGPN098NB\\SQLEXPRESS;Initial Catalog=CTSJE";
            /*
            XPObjectSpaceProvider osProvider = new XPObjectSpaceProvider(connectionString, null);
            IObjectSpace objectSpace = osProvider.CreateObjectSpace();
            Session currentSession = ((XPObjectSpace)objectSpace).Session;
            //Session newSession = new Session(currentSession.DataLayer);

            const string queryString =
                @"SELECT [CFGNM], [CFGVL] 
                FROM [DIRECTPAY].[dbo].[PPM_CONFIG] ";
            SelectedData GetEmployeesSimpleData = currentSession.ExecuteQuery(queryString);
            */
            /*
            XPObjectSpaceProvider osProvider;
            //XPCollection<SyncTaskConnection> oConnTask = oTask.Connection;
            XPCollection<SyncConnectionGroup> oConnTask = oTask.Connections;
            //foreach (SyncTaskConnection aConnTask in oConnTask)
            //{
               foreach( SyncConnectionGroup aConnGroup in oConnTask)
               {
                    foreach (SyncConnection aConnection in aConnGroup.Connections)
                    {
                        connectionString = aConnection.ConnectionString;
                        osProvider = new XPObjectSpaceProvider(connectionString, null);
                        IObjectSpace objectSpace = osProvider.CreateObjectSpace();
                        Session currentSession = ((XPObjectSpace)objectSpace).Session;
                        string queryString = oTask.ExecCommand;
                        //SelectedData GetData = currentSession.ExecuteQuery(queryString);
                        if (oTask.ConnectionType == eConnectionType.SQLServerQuery)
                        {
                            Type oType = Type.GetType(oTask.ObjectName.FullObjectName);
                            SelectedData GetData = currentSession.ExecuteQueryWithMetadata(queryString);
                            TransferData(oType, GetData, oTask);
                        }
                        else if (oTask.ConnectionType == eConnectionType.SQLServerProc)
                        {
                            currentSession.ExecuteSproc(queryString);
                        }
                        else if (oTask.ConnectionType == eConnectionType.SQLServerProcReturnedData)
                        {
                            Type oType = Type.GetType(oTask.ObjectName.FullObjectName);
                            SelectedData GetData = currentSession.ExecuteSproc(queryString);
                            TransferData(oType, GetData, oTask);
                        }

                        // process transfer data 
                    }
                }
            //}
            */
        }

        public void TransferData<T>(T ObjType ,SelectedData oGetData, SyncTask oTask,string vProcess="") where T : Type
        {
            string objMaster = "";
            iGetKey oGetKey = new iGetKey();
            Type objMasterType = objMaster.GetType();
            string xlsValue;
            string sqlQuery = "";



            /*
            foreach (SelectStatementResultRow row in data.ResultSet[1].Rows)
            {
                object firstName = row.Values[columnNames["FirstName"]];
                object lastName = row.Values[columnNames["LastName"]];
            }
            */

            //eIdxfCountry eC;
            //eC = eIdxfCountry.ID;

            //== > MAPPING OBJECT WITH XSL COLOM
            Session.LockingOption = LockingOption.None;

            XPCollection<SyncObjectColom> SyncColomn = oTask.Colomn;


            // MAPING KOLOM  MASUKAN KE OBJECT KOLOM
            Dictionary<string, int> columnNames = new Dictionary<string, int>();
            for (int columnIndex = 0; columnIndex < oGetData.ResultSet[0].Rows.Length; columnIndex++)
            {
                string columnName = (string)oGetData.ResultSet[0].Rows[columnIndex].Values[0];
                columnNames.Add(columnName, columnIndex);
                foreach ( SyncObjectColom aColom in SyncColomn.Where( a=> a.ImportName !=null))
                {

                    if (aColom.ImportName.ToUpper().Trim().Replace("]","").Replace("[", "") == columnName.ToUpper().Trim().Replace("]", "").Replace("[", ""))
                    {
                        

                        aColom.ImportNameIdx = columnIndex;
                        aColom.Save();
                        aColom.Session.CommitTransaction();
                        //Session NewSession =new Session();
                        //NewSession.LockingOption = LockingOption.None;
                        //sqlQuery = $" Oid == {aColom.Oid} ";
                        //CriteriaOperator filterOperator = CriteriaOperator.Parse(sqlQuery);
                        //SyncObjectColom ouaColom = NewSession.FindObject<SyncObjectColom>(filterOperator);
                        //if (ouaColom != null)
                        //{
                        //    ouaColom.ImportNameIdx = columnIndex;
                        //    NewSession.Save(ouaColom);
                        //    NewSession.CommitTransaction();
                            
                        //}
                        //NewSession.Disconnect();
                        //NewSession.Dispose();
                    }
                }
            }


            List<InfoOfClass> aoInfoOfClass = oGetKey.GetObjProperty(ObjType, Session, SyncColomn);
            // ==> GET CLASS INFO OF XPO
            XPClassInfo ObjTypeClassInfo = Session.GetClassInfo(ObjType);

            // ==> HAS MAPPING WITH XLS ONLY
            List<InfoOfClass> aoInfoOfClassHasXlsData = aoInfoOfClass.Where(a => a.ColomXls >= 0).ToList();
            // Start Exels untuk di imports
            foreach (SelectStatementResultRow row in oGetData.ResultSet[1].Rows)
            {
                //icolName = eIdxfCountry.Code.GetHashCode() - 1;
                //icolName = alEnumXls[eIdxfCountry.Code.GetHashCode()].ColomXls;

                xlsValue = row.Values[0].ToString();
                //colXls = alEnumXls[eIdxfCountry.Description.GetHashCode()].ColomXls;

                //if (xlsValue.Trim().Length > 0
                //    &&
                //  (worksheet.Cells[i, 1].Value.ToString().Length > 2 || objMaster != null))
                // persiapan unutk save object
                List<InfoOfClass> ObjectToSave = new List<InfoOfClass>();
                IsSearch oIsSearch = new IsSearch();
                IsSyncSearch oIsSyncSearch = new IsSyncSearch();

                foreach (InfoOfClass eInfoOfClass in aoInfoOfClassHasXlsData)
                {
                    InfoOfClass oInfoOfClass = eInfoOfClass;
                    oInfoOfClass.ClassInfo = ObjTypeClassInfo;

                    try
                    {
                        // ==> IS DATA READY TO UPLOAD ?
                        // tag value to object . 
                        string sData="";
                        if (row.Values[eInfoOfClass.ColomXls] !=null)
                        {
                            sData = row.Values[eInfoOfClass.ColomXls].ToString();
                            oInfoOfClass.setDataObject(Session, sData);
                            ObjectToSave.Add(oInfoOfClass);
                        }

                        //string sData = row.Values[eInfoOfClass.ColomXls].ToString();

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

                // ==> is any data 
                //if (oGetKey.IsAnyData(ObjectToSave))
                // SAVE THE DATA .
                if (oGetKey.IsAnyDataSync(ObjectToSave))
                {
                    // ==> CREATE QUERY STRING  untuk mencari  object
                    //sqlQuery = oIsSearch.CreateriaClasstoSQLQuery(ObjectToSave);
                    sqlQuery = oIsSyncSearch.CreateriaClasstoSQLQuery(ObjectToSave);

                    CriteriaOperator filterOperator = CriteriaOperator.Parse(sqlQuery);
                    object objClass = Session.FindObject(ObjType, CriteriaOperator.Parse(sqlQuery));
                    // tidak KETEMU object di buat baru
                    if (objClass == null)
                    {
                        objClass = ObjTypeClassInfo.CreateNewObject(Session);
                    }
                    Type otype = objClass.GetType();
                    List<InfoOfClass> lObjectToSave = ObjectToSave.Where(a => a.HasData).ToList();
                    // update property on class
                    foreach (InfoOfClass oInfoOfClass in lObjectToSave)
                    {
                        PropertyInfo info = otype.GetProperty(oInfoOfClass.Name);
                        info.SetValue(objClass, oInfoOfClass.Value);
                    }
                   // Console.WriteLine($"TransferData {vProcess}  => {otype.Name} ==> {sqlQuery}"   );
                    foreach (SyncMethod ItemMethod in oTask.Methods)
                    {
                        // get Methot to run
                        string sMethodName = ItemMethod.Method.ToString().Trim();
                        //MethodInfo OMethod = otype.GetMethod("Summarized");
                        MethodInfo OMethod = otype.GetMethod(sMethodName);
                        if (OMethod != null)
                        {

                            OMethod.Invoke(objClass, null);
                        }
                    }
                    Session.LockingOption = LockingOption.None;
                    Session.Save(objClass);
                    
                    Session.CommitTransaction();

                }

            }

        }
        //public static string Description(this Enum enumValue)
        //{
        //    return enumValue.GetType()
        //                    .GetMember(enumValue.ToString())
        //                    .First()
        //                    .GetCustomAttribute<DisplayAttribute>()
        //                    .GetDescription();
        //}
        //public static string ToDescription<TEnum>(this TEnum EnumValue) where TEnum : struct
        //{
        //    return Enumeration.GetEnumDescription((Enum)(object)((TEnum)EnumValue));
        //}
        //public static string GetEnumDescription<TEnum>(int value)
        //{
        //    return GetEnumDescription((Enum)(object)((TEnum)(object)value));  // ugly, but works
        //}
        FileSystemStoreObject FileUpload;
        XPCollection<ImportColomn> Colomn;
        public void ImportData<T>(T ObjType ) where T : Type
        {
            string objMaster = "";
            string sMasterPropertyName = "";
            string oSheet = "";
            int oRowHeader = 0;
            iGetKey oGetKey = new iGetKey();
            int maxloop = 2147483640;
            // open file xls
           
            var fCheck = oGetKey.Openfiles(FileUpload, oSheet);
            int blankid = 0;
            // check if the xls has data
            if (fCheck.Item1)
            {
                Worksheet worksheet = fCheck.Item2;
                string sqlQuery = "";
                string xlsValue;

                //try
                //{
                // remove sementara
                //  Session.BeginTransaction();

                Type objMasterType = objMaster.GetType();
                //eIdxfCountry eC;
                //eC = eIdxfCountry.ID;

                //== > MAPPING OBJECT WITH XSL COLOM
                

                List<InfoOfClass> aoInfoOfClass = oGetKey.GetObjProperty(ObjType, Session, Colomn);
                // ==> GET CLASS INFO OF XPO
                XPClassInfo ObjTypeClassInfo = Session.GetClassInfo(ObjType);

                // ==> HAS MAPPING WITH XLS ONLY
                List<InfoOfClass> aoInfoOfClassHasXlsData = aoInfoOfClass.Where(a => a.ColomXls >= 0).ToList();
                // Start Exels untuk di imports

                for (int i = oRowHeader; i < maxloop; i++)
                {
                    //icolName = eIdxfCountry.Code.GetHashCode() - 1;
                    //icolName = alEnumXls[eIdxfCountry.Code.GetHashCode()].ColomXls;

                    xlsValue = worksheet.Cells[i, 0].Value.ToString();
                    //colXls = alEnumXls[eIdxfCountry.Description.GetHashCode()].ColomXls;

                    //if (xlsValue.Trim().Length > 0
                    //    &&
                    //  (worksheet.Cells[i, 1].Value.ToString().Length > 2 || objMaster != null))
                    List<InfoOfClass> ObjectToSave = new List<InfoOfClass>();
                    IsSearch oIsSearch = new IsSearch();

                    foreach (InfoOfClass eInfoOfClass in aoInfoOfClassHasXlsData)
                    {
                        InfoOfClass oInfoOfClass = eInfoOfClass;
                        oInfoOfClass.ClassInfo = ObjTypeClassInfo;

                        try
                        {
                            // ==> IS DATA READY TO UPLOAD ?
                            string sData = worksheet.Cells[i, eInfoOfClass.ColomXls].Value.ToString();
                            oInfoOfClass.setDataObject(Session, sData);
                            ObjectToSave.Add(oInfoOfClass);
                        }
                        catch (Exception e)
                        {

                        }
                    }
                    // ==> is any data 
                    if (oGetKey.IsAnyData(ObjectToSave))
                    {
                        // ==> CREATE QUERY STRING 
                        sqlQuery = oIsSearch.CreateriaClasstoSQLQuery(ObjectToSave);
                        CriteriaOperator filterOperator = CriteriaOperator.Parse(sqlQuery);
                        object objClass = Session.FindObject(ObjType, CriteriaOperator.Parse(sqlQuery));
                        if (objClass == null)
                        {
                            objClass = ObjTypeClassInfo.CreateNewObject(Session);
                        }
                        Type otype = objClass.GetType();
                        List<InfoOfClass> lObjectToSave = ObjectToSave.Where(a => a.HasData).ToList();
                        foreach (InfoOfClass oInfoOfClass in lObjectToSave)
                        {
                            PropertyInfo info = otype.GetProperty(oInfoOfClass.Name);
                            info.SetValue(objClass, oInfoOfClass.Value);

                        }
                        Session.Save(objClass);
                        Session.CommitTransaction();

                    }
                    else
                    {
                        blankid = blankid + 1;
                        if (blankid > 100)
                        {
                            i = maxloop + 1;
                        }

                    }
                }
                
            }
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
        [Appearance("SyncDatabaseUpdateby", Enabled = false)]
        public  UserLoginInfo Updateby
        {
            get { return _Updateby; }
            set { SetPropertyValue("Updateby", ref _Updateby, value); }
        }
        // 
        private DateTime _Updatedate;
        [XafDisplayName("Update date"), ToolTip("Update date")]
        [Appearance("SyncDatabaseUpdatedate", Enabled = false)]
        public  DateTime Updatedate
        {
            get
            {
                
                    //_Updatedate = DateTime.Now;
                
                return _Updatedate;
            }
            set { SetPropertyValue("Updatedate", ref _Updatedate, value); }
        }
        /*
         * ========================================= handle jobs ==========================
         */

        private DateTime _LastJobCreated;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Last Job Created"), ToolTip("Last Job Created")]
        [ModelDefault("DisplayFormat", "{0:f}")]
        //[Size(SizeAttribute.Unlimited)]
        public  DateTime LastJobCreated
        {
            get { return _LastJobCreated; }
            set { SetPropertyValue("LastJobCreated", ref _LastJobCreated, value); }
        }
        public bool JobDetailWillCreate()
        {
            bool isNeedCreate = false;
            DateTime dNow = DateTime.Now;
            double cjDiff = 0;
            Schedule.Reload();

            if ((Schedule.StartAt <= dNow && Schedule.EndBy >= dNow) || Schedule.NoEndDate)
            {

                if (Schedule.EveryOUM == eSrvRecEvery.Years)
                {
                    //cjDiff = LastJobCreated.Year - dNow.Year;
                    cjDiff = (dNow.Year - LastJobCreated.Year);
                    //System.TimeSpan diffResult = dtTodayNoon.Subtract(dtTodayMidnight);

                }
                else if (Schedule.EveryOUM == eSrvRecEvery.Months)
                {
                    cjDiff = (dNow.Year + dNow.Month) - (LastJobCreated.Year + dNow.Month);
                }
                else if (Schedule.EveryOUM == eSrvRecEvery.Days)
                {
                    cjDiff = (dNow - LastJobCreated).TotalDays;
                }
                else if (Schedule.EveryOUM == eSrvRecEvery.Hours)
                {
                    cjDiff = (dNow - LastJobCreated).TotalHours;
                }
                else if (Schedule.EveryOUM == eSrvRecEvery.Munites)
                {
                    cjDiff = (dNow - LastJobCreated).Minutes;
                }
                else if (Schedule.EveryOUM == eSrvRecEvery.Second)
                {
                    cjDiff = (dNow - LastJobCreated).Seconds;
                }

            }
            if (cjDiff > 0 && cjDiff > Schedule.Every)
            {
                isNeedCreate = true;
            }
            return isNeedCreate;
        }
        private DateTime UpdateLastJob(DateTime sLastJobdate)
        {
            double dEvery = Schedule.Every;

            if (Schedule.EveryOUM == eSrvRecEvery.Second)
            {

                sLastJobdate = sLastJobdate.AddSeconds(Schedule.Every);
            }
            else if (Schedule.EveryOUM == eSrvRecEvery.Hours)
            {
                sLastJobdate = sLastJobdate.AddHours(dEvery);
            }
            else if (Schedule.EveryOUM == eSrvRecEvery.Munites)
            {
                sLastJobdate = sLastJobdate.AddMinutes(dEvery);
            }
            else if (Schedule.EveryOUM == eSrvRecEvery.Days)
            {
                DateTime dNow = System.DateTime.Today;
                double totalday = System.Math.Round((dNow - sLastJobdate).TotalDays, 0);
                sLastJobdate = sLastJobdate.AddDays(totalday);
            }
            else if (Schedule.EveryOUM == eSrvRecEvery.Months)
            {
                sLastJobdate = sLastJobdate.AddMonths(System.Convert.ToInt32(dEvery));
            }
            else
            {
                sLastJobdate = sLastJobdate.AddYears(System.Convert.ToInt32(dEvery));
            }
            return sLastJobdate;
        }

        public int CreateJobDetail()
        {
            int oID = 0;
            if (JobDetailWillCreate() && Active == eActiveStatus.Active)
            {
                // ---- insert service jobs 

                /// Session.BeginTransaction();
                Session NewSession = Session;
                NewSession.LockingOption = LockingOption.None;
                LastJobCreated = UpdateLastJob(LastJobCreated);
                NewSession.Save(this);
                NewSession.CommitTransaction();

                try
                {
                    XPCollection<SyncConnectionGroup> oConnTask = Connections;
                    foreach (SyncConnectionGroup aConnGroup in oConnTask)
                    {
                        foreach (SyncConnection aConnection in aConnGroup.Connections)
                        {
                            SyncServiceJobDetail oJobDetail;
                            oJobDetail = new SyncServiceJobDetail(NewSession);
                            oJobDetail.Date = DateTime.Now;
                            oJobDetail.SyncDataFlow = this;
                            oJobDetail.ConnectionJob = aConnection;

                            //LastJobCreated = UpdateLastJob(LastJobCreated);
                            NewSession.Save(oJobDetail);
                            NewSession.CommitTransaction();
                            oID = oJobDetail.Oid;
                        }
                    }
                    // this.Save();
                }
                catch (Exception ex)
                {
                    //  Session.RollbackTransaction();
                }
            }
            return oID;
        }
            public int CreateJobDetailOld()
        {

            int oID = 0;
            if (JobDetailWillCreate() && Active== eActiveStatus.Active)
            {
                // ---- insert service jobs 

                /// Session.BeginTransaction();
                Session NewSession = Session;
                try
                {
                    SyncServiceJobDetail oJobDetail;
                    oJobDetail = new SyncServiceJobDetail(NewSession);
                    oJobDetail.Date = DateTime.Now;
                    oJobDetail.SyncDataFlow = this;

                    LastJobCreated = UpdateLastJob(LastJobCreated);
                    NewSession.Save(oJobDetail);
                    NewSession.CommitTransaction();
                    oID = oJobDetail.Oid;
                    // this.Save();
                }
                catch (Exception ex)
                {
                    //  Session.RollbackTransaction();
                }
            }
            return oID;
        }


        [Action(ToolTip = "DeleteJob")]
        public void DeleteJobDetails()
        {
            DateTime dDateTime = DateTime.Now.AddDays(-1);
            Session NewSession = Session;
            string Filter = string.Format(" Status == 2 && [Date]  < ?  ", dDateTime);
            XPCollection<SyncServiceJobDetail> cJobDetail = new XPCollection<SyncServiceJobDetail>(NewSession, CriteriaOperator.Parse(" Status == 2 And [Date]  < ?  ", dDateTime));
            NewSession.Delete(cJobDetail);
            NewSession.CommitTransaction();
        }
    }


    public enum eActiveStatus
    {
        [XafDisplayName("Active")]
        Active = 1,
        [XafDisplayName("Inactive")]
        Inactive = 0
    };
}
