using System;
using DevExpress.Xpo;
using DevExpress.Persistent.Base;
using System.ComponentModel;
using DevExpress.Persistent.Validation;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.ConditionalAppearance;
using DevExpress.ExpressApp;
using DevExpress.Data.Filtering;
using System.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;

namespace cetho.Module.BusinessObjects
{

    [DefaultClassOptions]
    [ImageName("ModelEditor_Views")]
    [DefaultProperty("Title")]
    [NavigationItem("Services")]
    // Standard Document
    [System.ComponentModel.DisplayName("Service Job")]
    public class SyncServiceJob : XPObject
    {
        //public SyncServiceJob() : base()
        //{
        //    // This constructor is used when an object is loaded from a persistent storage.
        //    // Do not place any code here.
        //}

        public SyncServiceJob(Session session) : base(session)
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
        [XafDisplayName("Title *"), ToolTip("Title *")]
        [Size(350)]
        [NullText("Title")]
        public string Title
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

        private SyncSetup _JobType;
        [RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Job Type"), ToolTip("Job Type")]
        //[Size(SizeAttribute.Unlimited)]
        public SyncSetup JobType
        {
            get { return _JobType; }
            set { SetPropertyValue("JobType", ref _JobType, value); }
        }

        [Association("JobsDetails")]
        public XPCollection<SyncServiceJobDetail> ServiceJobs
        {
            get
            {
                return GetCollection<SyncServiceJobDetail>("ServiceJobs");
            }
        }

        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Last Job Created"), ToolTip("Last Job Created")]
        private DateTime _LastJobCreated;
        public DateTime LastJobCreated
        {
            get
            {
                try
                {
                    if (_LastJobCreated == null)
                    {
                        _LastJobCreated = new DateTime(2000, 1, 1);
                    }
                }
                catch (Exception ex)
                {
                    _LastJobCreated = new DateTime(2000, 1, 1);
                }
                return _LastJobCreated;
            }

            set { SetPropertyValue("LastJobCreated", ref _LastJobCreated, value); }
        }


        //[Appearance("SyncSetupLastUpdateEnable", Enabled = false)]
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Active"), ToolTip("Active")]
        //[Size(50)]
        private bool _Active;
        public bool Active
        {
            get { return _Active; }
            set { SetPropertyValue("Active", ref _Active, value); }
        }

        [Action(Caption = "Delete Job")]
        public void DeleteJobDetails()
        {

            DateTime dDateTime = DateTime.Now.AddDays(-1);
            Session NewSession = Session;
            string Filter = string.Format(" Status == 2 && [Date]  < ?  ", dDateTime);
            //ObjectSpace os = Application.CreateObjectSpace();
            XPCollection<SyncServiceJobDetail> cJobDetail = new XPCollection<SyncServiceJobDetail>(NewSession, CriteriaOperator.Parse(" Status == 2 And [Date]  < ?  ", dDateTime));
            NewSession.Delete(cJobDetail);
            //Session.Save(cJobDetail);
            NewSession.CommitTransaction();
        }
        //--------------------------------------------------------------------
        //-------------------------------------------
        [Action(Caption = "Create Job")]
        public void CreateJobDetails()
        {

            // --- get information of recurring
            // check Schedule is on range 
            // -- check last running jobs 
            _ = CreateJobDetail();
        }

        public void Process(SyncConnection oConnection)
        {
            ExecuteJob();
        }
        public void Process()
        {
            ExecuteJob();
        }
        [Action(Caption = "Execute Job")]
        public void ExecuteJob()
        {
            int ProcessId = DateTime.Now.GetHashCode();
            ExecuteJob(ProcessId);
        }
        public int CreateJobDetail()
        {

            int oID = 0;
            if (JobDetailWillCreate() && Active)
            {
                // ---- insert service jobs 

                /// Session.BeginTransaction();

                try
                {
                    SyncServiceJobDetail oJobDetail;
                    oJobDetail = new SyncServiceJobDetail(Session);
                    oJobDetail.Date = DateTime.Now;
                    oJobDetail.ServiceJob = this;

                    LastJobCreated = UpdateLastJob(LastJobCreated);

                    oJobDetail.Save();
                    oJobDetail.Session.CommitTransaction();
                    //Session.CommitTransaction();
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
                DateTime dNow = DateTime.Today;
                double totalday = Math.Round((dNow - sLastJobdate).TotalDays, 0);
                sLastJobdate = sLastJobdate.AddDays(totalday);
            }
            else if (Schedule.EveryOUM == eSrvRecEvery.Months)
            {
                sLastJobdate = sLastJobdate.AddMonths(Convert.ToInt32(dEvery));
            }
            else
            {
                sLastJobdate = sLastJobdate.AddYears(Convert.ToInt32(dEvery));
            }
            return sLastJobdate;
        }
        public void ExecuteJob(int ProcessID)
        {
            SyncEmailService iEmailService;
            iEmailService = new SyncEmailService();
            // iEmailService.WriteToFile($" Process Ececute :  {ProcessID} ");

            CriteriaOperator filterOperator;
            bool bCrlf = true;

            string eEmailFrom = ConfigurationManager.AppSettings["EmailUserFrom"];
            string mailServer = ConfigurationManager.AppSettings["EmailServer"];
            string EmailFileExport = ConfigurationManager.AppSettings["EmailFileExport"];

            string squery = "";
            string subject = "";
            string eMailTo = "";
            string eMailCC = "";
            string eDatabase = "";
            string eConnString = "";
            string eMessage = "";

            string sqlData = "";
            string sFilter = "";

            List<int> iJobs = new List<int>();

            Session.LockingOption = LockingOption.None;
            string txtSql = "";
            XPCollection<SyncServiceJobDetail> aServiceJobDetail;
            txtSql = string.Format(" ServiceJob.Oid == {0}  &&  Status == 0 ", Oid);
            aServiceJobDetail = new XPCollection<SyncServiceJobDetail>(Session) { Criteria = CriteriaOperator.Parse(txtSql) };
            iEmailService.WriteToFile($" 3 ASServicceJob==>ExecuteJob :  {ProcessID} // Total Job Detail : {aServiceJobDetail.Count.ToString()} ");
            foreach (SyncServiceJobDetail ServiceJobDetail in aServiceJobDetail)
            // Parallel.ForEach<SyncServiceJobDetail>(aServiceJobDetail, (ServiceJobDetail) =>
            {

                // iEmailService.WriteToFile($" Process Ececute :  {ProcessID} , Jobdetail id :  {ServiceJobDetail.Oid.ToString() } ");
                //if (FindJobHistory(ServiceJobDetail.Oid, eJobsHistoryType.SyncServiceJob, ProcessID))
                //  {
                iEmailService.WriteToFile($" 3 Process Ececute :  {ProcessID} , Jobdetail id :  {ServiceJobDetail.Oid.ToString()} is FINDING");
                //iJobs.Add(ServiceJobDetail.Oid);

                //XPCollection<SyncSetupHelper> oServiceSetup = ServiceJobDetail.ServiceJob.JobType.FunctionHelper;
                txtSql = string.Format(" AlertSetup.Oid == {0}   ", ServiceJobDetail.ServiceJob.JobType.Oid);
                XPCollection<SyncSetupHelper> oServiceSetup = new XPCollection<SyncSetupHelper>(Session) { Criteria = CriteriaOperator.Parse(txtSql) };
                iEmailService.WriteToFile($" 3 Process Ececute :  {ProcessID} , Jobdetail id :  {ServiceJobDetail.Oid.ToString()} is FINDING // HELPER TOTAL: {oServiceSetup.Count.ToString()} ");
                // perapre sending by company
                foreach (SyncSetupHelper oqServiceExecute in oServiceSetup)
                //Parallel.ForEach<SyncSetupHelper>(oServiceSetup, (oqServiceExecute) =>
                {
                    //oqServiceExecute.
                    string sqlQuery = string.Format(" Oid == {0} ", oqServiceExecute.Oid.ToString());
                    filterOperator = CriteriaOperator.Parse(sqlQuery);
                    SyncSetupHelper oServiceExecute = Session.FindObject<SyncSetupHelper>(filterOperator);

                    SyncEmailService oEmailService;
                    oEmailService = new SyncEmailService();
                    SyncDataService datas;
                    datas = new SyncDataService();

                    eDatabase = "";
                    string sFilesAttahment = "";
                    eConnString = oServiceExecute.ConnectionString();
                    eDatabase = eConnString;
                    /* replace Query */
                    squery = datas.DataReplace(oServiceExecute.SqlQueryBody, oServiceExecute.DataID, eDataReplace.PTOU);

                    subject = oServiceExecute.Subject;
                    /* replace subject */

                    subject = datas.DataReplace(subject, ServiceJobDetail.Date.ToString(), eDataReplace.Date);
                    subject = datas.DataReplace(subject, oServiceExecute.DataID, eDataReplace.PTOU);

                    eMailCC = oServiceExecute.CCEmail;
                    eMailTo = oServiceExecute.ToEmail;

                    eMessage = oServiceExecute.AlertSetup.Description;
                    sqlData = "";
                    Chilkat.StringBuilder sbHtml = new Chilkat.StringBuilder();

                    sbHtml.AppendLine(datas.OleExecuteQuery(squery, eConnString, eMessage), bCrlf);
                    //sqlData += datas.OleExecuteQuery(squery, eConnString, eMessage);
                    sbHtml.AppendLine(datas.OleExecuteQuery(ServiceJobDetail, eConnString, oServiceExecute.DataID), bCrlf);
                    //sqlData += datas.OleExecuteQuery(ServiceJobDetail, eConnString, oServiceExecute.DataID);

                    sbHtml.AppendLine("<p>" + oServiceExecute.AlertSetup.Notes + "</p>", bCrlf);

                    sqlData = sbHtml.GetAsString();
                    if (oServiceExecute.AlertSetup.AttachEmail == eAttachEmailSetup.Excel)
                    {
                        string path = EmailFileExport + oServiceExecute.Subject.Replace(" ", "") + ServiceJobDetail.Date.ToString("yyMMddHHmmss");
                        string Sheet = oServiceExecute.Subject.Replace(" ", "");
                        // eService.WriteToFile(" writes  Xls  ExecuteJobAlert status: {0} " + path);
                        datas.ExportToXls(squery, path, Sheet, eDatabase);
                        //sFilesAttahment = path + ServiceJobDetail.Date.ToString("yyMMddHHmmss") + ".xlsx";
                        sFilesAttahment = path + ".xlsx";
                        //eService.WriteToFile(" Xls  ExecuteJobAlert status: {0} " + sFilesAttahment);
                    }

                    oEmailService.WriteToFile($" 3 ServiceJob ==> :Sending Email Process Id :  {ProcessID} ");
                    if (datas.IsAnyData)
                    {
                        oEmailService.SendEmail(eEmailFrom,
                                              eMailTo,
                                              eMailCC,
                                              subject,
                                              eMessage,
                                              sqlData,
                                              sFilesAttahment);
                    }

                };
                //}
                ServiceJobDetail.Status = eJobDetail.Done;
                ServiceJobDetail.Save();
                ServiceJobDetail.Session.CommitTransaction();
            };
            ///SetDoneJobDetail(iJobs);
        }
        private bool FindJobStatus(int OidRef, eJobDetail JobsStatus, int ProcessID)
        {
            bool status = false;

            SyncEmailService iEmailService;
            iEmailService = new SyncEmailService();
            //iEmailService.WriteToFile($" ServiceJob ==>FindJobStatus  iEmailService is created   :  {OidRef}// {ProcessID.ToString()}  ");

            try
            {
                Session.BeginTransaction();
                //iEmailService.WriteToFile($" ServiceJob ==>FindJobStatus  BeginTransaction is created   :  {OidRef}// {ProcessID.ToString()}  ");

                string sqlQuery = string.Format($"  Oid == {OidRef.ToString()} && Status== {JobsStatus.GetHashCode().ToString()} ");
                CriteriaOperator filterOperator = CriteriaOperator.Parse(sqlQuery);
                SyncServiceJobDetail cJobStatus = Session.FindObject<SyncServiceJobDetail>(filterOperator);
                iEmailService.WriteToFile($" ServiceJob ==>FindJobStatus  jobstatus finding {sqlQuery}   :  {OidRef}// {ProcessID.ToString()}  ");
                //cJobStatus.Status==eJobDetail.Created

                if (cJobStatus != null)
                {
                    cJobStatus.Status = eJobDetail.Process;
                    cJobStatus.Save();
                    Session.CommitTransaction();
                    status = true;
                    iEmailService.WriteToFile($" ServiceJob ==>FindJobStatus  tobe proccess  :  {OidRef}// {ProcessID}  ");
                }

            }
            catch (Exception ex)
            {
                status = false;
                Session.RollbackTransaction();
                iEmailService.WriteToFile($"  ServiceJob ==>FindJobHistory  :  Rollback  {ex.Message} // {ProcessID}  ");
            }
            return status;

        }
        private bool FindJobHistory(int OidRef, eJobsHistoryType JobsHistoryType, int ProcessID)
        {
            bool status = false;
            //using (UnitOfWork uow = new UnitOfWork())
            //{

            SyncEmailService iEmailService;
            iEmailService = new SyncEmailService();
            try
            {
                Session.BeginTransaction();
                try
                {
                    string sqlQuery = string.Format($"  OidRef == {OidRef.ToString()} && JobsHistoryType== {JobsHistoryType.GetHashCode().ToString()} ");
                    CriteriaOperator filterOperator = CriteriaOperator.Parse(sqlQuery);
                    SyncJobsHistory cJobsHistory = Session.FindObject<SyncJobsHistory>(filterOperator);
                    //XPCollection<SyncJobsHistory> cJobsHistory= new XPCollection<SyncJobsHistory>(Session) { Criteria = CriteriaOperator.Parse(sqlQuery) };
                    //if (cJobsHistory.Count ==0 )
                    if (cJobsHistory == null)
                    {
                        SyncJobsHistory oJobsHistory = new SyncJobsHistory(Session);
                        oJobsHistory.OidRef = OidRef;
                        oJobsHistory.JobsHistoryType = JobsHistoryType;
                        oJobsHistory.ProcessID = ProcessID;
                        oJobsHistory.Save();
                        Session.CommitTransaction();
                        status = true;
                        iEmailService.WriteToFile($" ServiceJob ==>FindJobHistory  commit  :  {OidRef}// {ProcessID}  ");
                    }
                }
                catch (Exception ex)
                {
                    status = false;
                    Session.RollbackTransaction();
                    iEmailService.WriteToFile($"  ServiceJob ==>FindJobHistory  :  Rollback  {ex.Message} // {ProcessID}  ");
                }

            }
            catch (Exception ex)
            {
                status = false;
                Session.RollbackTransaction();
                iEmailService.WriteToFile($"  ServiceJob ==>FindJobHistory  :  Rollback  {ex.Message} // {ProcessID}  ");
            }
            return status;

        }
        public void ExecuteJobDetail(SyncServiceJobDetail ServiceJobDetail)
        {
            SyncEmailService iEmailService;
            int ProcessID = ServiceJobDetail.Oid;
            iEmailService = new SyncEmailService();
            // iEmailService.WriteToFile($" Process Ececute :  {ProcessID} ");

            CriteriaOperator filterOperator;
            bool bCrlf = true;

            string eEmailFrom = ConfigurationManager.AppSettings["EmailUserFrom"];
            string mailServer = ConfigurationManager.AppSettings["EmailServer"];
            string EmailFileExport = ConfigurationManager.AppSettings["EmailFileExport"];

            string squery = "";
            string subject = "";
            string eMailTo = "";
            string eMailCC = "";
            string eDatabase = "";
            string eConnString = "";
            string eMessage = "";

            string sqlData = "";
            string sFilter = "";
            string txtSql = "";

            //iEmailService.WriteToFile($" 3 Process Ececute :  {ProcessID} , Jobdetail id :  {ServiceJobDetail.Oid.ToString() } is FINDING");
            Console.WriteLine($" Sense & Response  Process Ececute {ServiceJobDetail.Oid} ");
            //iJobs.Add(ServiceJobDetail.Oid);



            //XPCollection<SyncSetupHelper> oServiceSetup = ServiceJobDetail.ServiceJob.JobType.FunctionHelper;
            txtSql = string.Format(" AlertSetup.Oid == {0}   ", ServiceJobDetail.ServiceJob.JobType.Oid);
            XPCollection<SyncSetupHelper> oServiceSetup = new XPCollection<SyncSetupHelper>(Session) { Criteria = CriteriaOperator.Parse(txtSql) };
            Console.WriteLine($" Sense & Response  Process Ececute {ServiceJobDetail.Oid}   {ServiceJobDetail.ServiceJob.Title} ");
            //iEmailService.WriteToFile($" 3 Process Ececute :  {ProcessID} , Jobdetail id :  {ServiceJobDetail.Oid.ToString() } is FINDING // HELPER TOTAL: {oServiceSetup.Count.ToString()} ");
            // perapre sending by company
            foreach (SyncSetupHelper oqServiceExecute in oServiceSetup)
            //Parallel.ForEach<SyncSetupHelper>(oServiceSetup, (oqServiceExecute) =>
            {

                //oqServiceExecute.
                string sqlQuery = string.Format(" Oid == {0} ", oqServiceExecute.Oid.ToString());
                filterOperator = CriteriaOperator.Parse(sqlQuery);
                SyncSetupHelper oServiceExecute = Session.FindObject<SyncSetupHelper>(filterOperator);

                SyncEmailService oEmailService;
                Console.WriteLine($" Sense & Response  Process Ececute new SyncEmailService() {ServiceJobDetail.Oid}   {ServiceJobDetail.ServiceJob.Title} ");
                oEmailService = new SyncEmailService();
                SyncDataService datas;
                datas = new SyncDataService();

                eDatabase = "";
                string sFilesAttahment = "";
                Console.WriteLine($" Sense & Response  Process Ececute oServiceExecute.ConnectionString() {ServiceJobDetail.Oid}   {ServiceJobDetail.ServiceJob.Title} ");
                eConnString = oServiceExecute.ConnectionString();
                eDatabase = eConnString;

                Console.WriteLine($" Sense & Response  Process Execute  oServiceExecute.ConnectionString()  is connected {ServiceJobDetail.Oid}   {ServiceJobDetail.ServiceJob.Title} ");

                /* replace Query */
                squery = datas.DataReplace(oServiceExecute.SqlQueryBody, oServiceExecute.DataID, eDataReplace.PTOU);

                subject = oServiceExecute.Subject;
                /* replace subject */

                subject = datas.DataReplace(subject, ServiceJobDetail.Date.ToString(), eDataReplace.Date);
                subject = datas.DataReplace(subject, oServiceExecute.DataID, eDataReplace.PTOU);

                eMailCC = oServiceExecute.CCEmail;
                eMailTo = oServiceExecute.ToEmail;

                eMessage = oServiceExecute.AlertSetup.Description;
                sqlData = "";
                Chilkat.StringBuilder sbHtml = new Chilkat.StringBuilder();

                sbHtml.AppendLine(datas.OleExecuteQuery(squery, eConnString, eMessage), bCrlf);
                //sqlData += datas.OleExecuteQuery(squery, eConnString, eMessage);
                sbHtml.AppendLine(datas.OleExecuteQuery(ServiceJobDetail, eConnString, oServiceExecute.DataID), bCrlf);
                //sqlData += datas.OleExecuteQuery(ServiceJobDetail, eConnString, oServiceExecute.DataID);

                sbHtml.AppendLine("<p>" + oServiceExecute.AlertSetup.Notes + "</p>", bCrlf);

                sqlData = sbHtml.GetAsString();
                if (oServiceExecute.AlertSetup.AttachEmail == eAttachEmailSetup.Excel)
                {
                    string path = EmailFileExport + oServiceExecute.Subject.Replace(" ", "") + ServiceJobDetail.Date.ToString("yyMMddHHmmss");
                    string Sheet = oServiceExecute.Subject.Replace(" ", "");
                    // eService.WriteToFile(" writes  Xls  ExecuteJobAlert status: {0} " + path);
                    datas.ExportToXls(squery, path, Sheet, eDatabase);
                    //sFilesAttahment = path + ServiceJobDetail.Date.ToString("yyMMddHHmmss") + ".xlsx";
                    sFilesAttahment = path + ".xlsx";
                    //eService.WriteToFile(" Xls  ExecuteJobAlert status: {0} " + sFilesAttahment);
                }

                //  oEmailService.WriteToFile($" 3 ServiceJob ==> :Sending Email Process Id :  {ProcessID} ");
                Console.WriteLine($" Sense & Response  Process Ececute SendEmail {ServiceJobDetail.Oid}   {ServiceJobDetail.ServiceJob.Title} ");
                if (datas.IsAnyData)
                {
                    oEmailService.WriteToFile($" 3 ServiceJob ==> :EMAIL TO {eMailTo} Process Id :  {ProcessID} ");
                    oEmailService.SendEmail(eEmailFrom,
                                              eMailTo,
                                              eMailCC,
                                              subject,
                                              eMessage,
                                              sqlData,
                                              sFilesAttahment);
                }

            };


        }
        public void ExecuteJobDetail(SyncServiceJobDetail ServiceJobDetail, int ProcessID)
        {
            SyncEmailService iEmailService;
            iEmailService = new SyncEmailService();
            // iEmailService.WriteToFile($" Process Ececute :  {ProcessID} ");

            CriteriaOperator filterOperator;
            bool bCrlf = true;

            string eEmailFrom = ConfigurationManager.AppSettings["EmailUserFrom"];
            string mailServer = ConfigurationManager.AppSettings["EmailServer"];
            string EmailFileExport = ConfigurationManager.AppSettings["EmailFileExport"];

            string squery = "";
            string subject = "";
            string eMailTo = "";
            string eMailCC = "";
            string eDatabase = "";
            string eConnString = "";
            string eMessage = "";

            string sqlData = "";
            string sFilter = "";
            string txtSql = "";

            iEmailService.WriteToFile($" 3 Process Ececute :  {ProcessID} , Jobdetail id :  {ServiceJobDetail.Oid.ToString()} is FINDING");
            //iJobs.Add(ServiceJobDetail.Oid);

            //XPCollection<SyncSetupHelper> oServiceSetup = ServiceJobDetail.ServiceJob.JobType.FunctionHelper;
            txtSql = string.Format(" AlertSetup.Oid == {0}   ", ServiceJobDetail.ServiceJob.JobType.Oid);
            XPCollection<SyncSetupHelper> oServiceSetup = new XPCollection<SyncSetupHelper>(Session) { Criteria = CriteriaOperator.Parse(txtSql) };
            iEmailService.WriteToFile($" 3 Process Ececute :  {ProcessID} , Jobdetail id :  {ServiceJobDetail.Oid.ToString()} is FINDING // HELPER TOTAL: {oServiceSetup.Count.ToString()} ");
            // perapre sending by company
            foreach (SyncSetupHelper oqServiceExecute in oServiceSetup)
            //Parallel.ForEach<SyncSetupHelper>(oServiceSetup, (oqServiceExecute) =>
            {
                //oqServiceExecute.
                string sqlQuery = string.Format(" Oid == {0} ", oqServiceExecute.Oid.ToString());
                filterOperator = CriteriaOperator.Parse(sqlQuery);
                SyncSetupHelper oServiceExecute = Session.FindObject<SyncSetupHelper>(filterOperator);

                SyncEmailService oEmailService;
                oEmailService = new SyncEmailService();
                SyncDataService datas;
                datas = new SyncDataService();

                eDatabase = "";
                string sFilesAttahment = "";
                eConnString = oServiceExecute.ConnectionString();
                eDatabase = eConnString;
                /* replace Query */
                squery = datas.DataReplace(oServiceExecute.SqlQueryBody, oServiceExecute.DataID, eDataReplace.PTOU);

                subject = oServiceExecute.Subject;
                /* replace subject */

                subject = datas.DataReplace(subject, ServiceJobDetail.Date.ToString(), eDataReplace.Date);
                subject = datas.DataReplace(subject, oServiceExecute.DataID, eDataReplace.PTOU);

                eMailCC = oServiceExecute.CCEmail;
                eMailTo = oServiceExecute.ToEmail;

                eMessage = oServiceExecute.AlertSetup.Description;
                sqlData = "";
                Chilkat.StringBuilder sbHtml = new Chilkat.StringBuilder();

                sbHtml.AppendLine(datas.OleExecuteQuery(squery, eConnString, eMessage), bCrlf);
                //sqlData += datas.OleExecuteQuery(squery, eConnString, eMessage);
                sbHtml.AppendLine(datas.OleExecuteQuery(ServiceJobDetail, eConnString, oServiceExecute.DataID), bCrlf);
                //sqlData += datas.OleExecuteQuery(ServiceJobDetail, eConnString, oServiceExecute.DataID);

                sbHtml.AppendLine("<p>" + oServiceExecute.AlertSetup.Notes + "</p>", bCrlf);

                sqlData = sbHtml.GetAsString();
                if (oServiceExecute.AlertSetup.AttachEmail == eAttachEmailSetup.Excel)
                {
                    string path = EmailFileExport + oServiceExecute.Subject.Replace(" ", "") + ServiceJobDetail.Date.ToString("yyMMddHHmmss");
                    string Sheet = oServiceExecute.Subject.Replace(" ", "");
                    // eService.WriteToFile(" writes  Xls  ExecuteJobAlert status: {0} " + path);
                    datas.ExportToXls(squery, path, Sheet, eDatabase);
                    //sFilesAttahment = path + ServiceJobDetail.Date.ToString("yyMMddHHmmss") + ".xlsx";
                    sFilesAttahment = path + ".xlsx";
                    //eService.WriteToFile(" Xls  ExecuteJobAlert status: {0} " + sFilesAttahment);
                }

                oEmailService.WriteToFile($" 3 ServiceJob ==> :Sending Email Process Id :  {ProcessID} ");
                if (datas.IsAnyData)
                {
                    oEmailService.WriteToFile($" 3 ServiceJob ==> :EMAIL TO {eMailTo} Process Id :  {ProcessID} ");
                    oEmailService.SendEmail(eEmailFrom,
                                              eMailTo,
                                              eMailCC,
                                              subject,
                                              eMessage,
                                              sqlData,
                                              sFilesAttahment);
                }

            };


        }
        public void ExecuteJobDetailOld(SyncServiceJobDetail ServiceJobDetail)
        {
            CriteriaOperator filterOperator;
            bool bCrlf = true;
            SyncEmailService iEmailService;
            iEmailService = new SyncEmailService();

            string eEmailFrom = ConfigurationManager.AppSettings["EmailUserFrom"];
            string emailServer = ConfigurationManager.AppSettings["EmailServer"];
            string EmailFileExport = ConfigurationManager.AppSettings["EmailFileExport"];




            //XPCollection<SyncSetupHelper> oServiceSetup = ServiceJobDetail.ServiceJob.JobType.FunctionHelper;
            string txtSql = string.Format(" AlertSetup.Oid == {0}   ", ServiceJobDetail.ServiceJob.JobType.Oid);
            XPCollection<SyncSetupHelper> oServiceSetup = new XPCollection<SyncSetupHelper>(Session) { Criteria = CriteriaOperator.Parse(txtSql) };

            // perapre sending by company
            foreach (SyncSetupHelper oqServiceExecute in oServiceSetup)
            {
                //oqServiceExecute.
                string sqlQuery = string.Format(" Oid == {0} ", oqServiceExecute.Oid.ToString());
                filterOperator = CriteriaOperator.Parse(sqlQuery);
                SyncSetupHelper oServiceExecute = Session.FindObject<SyncSetupHelper>(filterOperator);

                SyncEmailService oEmailService;
                oEmailService = new SyncEmailService();
                SyncDataService datas;
                datas = new SyncDataService();
                //  oEmailService.CreateFoder(EmailFileExport);

                //oServiceExecute.AlertSetup.Reload();


                string eDatabase = "";
                string sFilesAttahment = "";
                string eConnString = oServiceExecute.ConnectionString();
                eDatabase = eConnString;
                /* replace Query */
                string squery = datas.DataReplace(oServiceExecute.SqlQueryBody, oServiceExecute.DataID, eDataReplace.PTOU);

                string subject = oServiceExecute.Subject;
                /* replace subject */

                subject = datas.DataReplace(subject, ServiceJobDetail.Date.ToString(), eDataReplace.Date);
                subject = datas.DataReplace(subject, oServiceExecute.DataID, eDataReplace.PTOU);

                string eMailCC = oServiceExecute.CCEmail;
                string eMailTo = oServiceExecute.ToEmail;

                string eMessage = oServiceExecute.AlertSetup.Description;
                string sqlData = "";
                Chilkat.StringBuilder sbHtml = new Chilkat.StringBuilder();

                sbHtml.AppendLine(datas.OleExecuteQuery(squery, eConnString, eMessage), bCrlf);
                //sqlData += datas.OleExecuteQuery(squery, eConnString, eMessage);
                sbHtml.AppendLine(datas.OleExecuteQuery(ServiceJobDetail, eConnString, oServiceExecute.DataID), bCrlf);
                //sqlData += datas.OleExecuteQuery(ServiceJobDetail, eConnString, oServiceExecute.DataID);

                sbHtml.AppendLine("<p>" + oServiceExecute.AlertSetup.Notes + "</p>", bCrlf);

                sqlData = sbHtml.GetAsString();
                if (oServiceExecute.AlertSetup.AttachEmail == eAttachEmailSetup.Excel)
                {
                    string path = EmailFileExport + oServiceExecute.Subject.Replace(" ", "") + ServiceJobDetail.Date.ToString("yyMMddHHmmss");
                    string Sheet = oServiceExecute.Subject.Replace(" ", "");
                    // eService.WriteToFile(" writes  Xls  ExecuteJobAlert status: {0} " + path);
                    datas.ExportToXls(squery, path, Sheet, eDatabase);
                    sFilesAttahment = path + ".xlsx";

                }

                //iEmailService.WriteToFile($" {sqlData} ");
                //// send email 
                //eService.WriteToFile("{ 0} " + eEmailFrom);
                //eService.WriteToFile("email to  { 0} " + eMailTo);
                if (datas.IsAnyData)
                {
                    oEmailService.SendEmail(eEmailFrom,
                                         eMailTo,
                                         eMailCC,
                                         subject,
                                         eMessage,
                                         sqlData,
                                         sFilesAttahment);
                }


            }

        }
        private void SetDoneJobDetail()
        {
            // updaate status
            string sFilter = string.Format(" ServiceJob.Oid == {0}  &&  Status == 0 ", Oid);
            //filterOperator = CriteriaOperator.Parse(sFilter);
            XPCollection<SyncServiceJobDetail> ouServiceJobDetail = new XPCollection<SyncServiceJobDetail>(Session) { Criteria = CriteriaOperator.Parse(sFilter) };
            //if (ouServiceJobDetail != null)
            foreach (SyncServiceJobDetail eouServiceJobDetail in ouServiceJobDetail)
            {
                //eouServiceJobDetail.Status = eJobDetail.Done;
                eouServiceJobDetail.Save();

            }
            Session.CommitTransaction();
        }

        private void SetDoneJobDetail(List<int> oJobOid)
        {
            SyncEmailService eService = new SyncEmailService();
            foreach (int oOid in oJobOid)
            {

                string sqlQuery = string.Format($" Oid == {oOid.ToString()} ");
                CriteriaOperator filterOperator = CriteriaOperator.Parse(sqlQuery);
                SyncServiceJobDetail oServiceJobDetail = Session.FindObject<SyncServiceJobDetail>(filterOperator);
                if (oServiceJobDetail != null)
                {
                    Session.BeginTransaction();
                    try
                    {
                        oServiceJobDetail.Status = eJobDetail.Done;
                        oServiceJobDetail.Save();
                        Session.CommitTransaction();
                        eService.WriteToFile($" ServiceJob ==> SetDoneJobDetail Commit {oOid.ToString()} ");
                    }
                    catch (Exception ex)
                    {
                        Session.RollbackTransaction();
                        eService.WriteToFile($" ServiceJob ==> SetDoneJobDetail ROLLBACK {ex.Message.ToString()} ");
                    }
                }
            }

        }
        public bool JobDetailWillCreate()
        {
            bool isNeedCreate = false;
            DateTime dNow = DateTime.Now;
            double cjDiff = 0;
            Schedule.Reload();

            if (Schedule.StartAt <= dNow && Schedule.EndBy >= dNow || Schedule.NoEndDate)
            {

                if (Schedule.EveryOUM == eSrvRecEvery.Years)
                {
                    //cjDiff = LastJobCreated.Year - dNow.Year;
                    cjDiff = dNow.Year - LastJobCreated.Year;
                    //System.TimeSpan diffResult = dtTodayNoon.Subtract(dtTodayMidnight);

                }
                else if (Schedule.EveryOUM == eSrvRecEvery.Months)
                {
                    cjDiff = dNow.Year + dNow.Month - (LastJobCreated.Year + dNow.Month);
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
        private DateTime _LastUpdate;
        [Appearance("SyncSetupLastUpdateEnable", Enabled = false)]
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Date"), ToolTip("Date")]
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
    //public enum eJobsHistoryType
    //{
    //    [XafDisplayName("SyncServiceJob")]
    //    SyncServiceJob = 0

    //};

}