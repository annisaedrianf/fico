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
    [System.ComponentModel.DisplayName("Alert Setup")]
    public class SyncSetup : XPObject
    {
        //public SyncSetup() : base()
        //{
        //    // This constructor is used when an object is loaded from a persistent storage.
        //    // Do not place any code here.
        //}

        public SyncSetup(Session session) : base(session)
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
        public  string Title
        {
            get { return _Title; }
            set { SetPropertyValue("Title", ref _Title, value); }
        }

        private string _EmailSubject;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Email Subject"), ToolTip("Email Subject")]
        [Size(SizeAttribute.Unlimited)]
        [NullText("EmailSubject")]
        public  string EmailSubject
        {
            get { return _EmailSubject; }
            set { SetPropertyValue("EmailSubject", ref _EmailSubject, value); }
        }

        private string _Description;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Description"), ToolTip("Description")]
        [Size(SizeAttribute.Unlimited)]
        [NullText("Description")]
        public  string Description
        {
            get { return _Description; }
            set { SetPropertyValue("Description", ref _Description, value); }
        }

        private string _Notes;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Notes"), ToolTip("Notes")]
        [Size(SizeAttribute.Unlimited)]
        [NullText("Notes")]
        public  string Notes
        {
            get { return _Notes; }
            set { SetPropertyValue("Notes", ref _Notes, value); }
        }

        private string _SqlQuery;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Sql Query"), ToolTip("Sql Query")]
        [Size(SizeAttribute.Unlimited)]
        [NullText("SqlQuery")]
        public  string SqlQuery
        {
            get {
                if (_SqlQuery == null)
                {
                    _SqlQuery = "";
                }
                return _SqlQuery; }
            set { SetPropertyValue("SqlQuery", ref _SqlQuery, value); }
        }
        private eDataLevelSetup _DataLevel;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Data Level"), ToolTip("Data Level")]
        public  eDataLevelSetup DataLevel
        {
            get { return _DataLevel; }
            set { SetPropertyValue("DataLevel", ref _DataLevel, value); }
        }
        [Association("CompanyAlert")]
        public XPCollection<CompanyInfo> Companies
        {
            get
            {
                return GetCollection<CompanyInfo>("Companies");
            }
        }
        [Association("EmailCCGRP")]
        public XPCollection<SyncEmailGroup> CCEmails
        {
            get
            {
                return GetCollection<SyncEmailGroup>("CCEmails");
            }
        }

        [Association("EmailTOGRP")]
        public XPCollection<SyncEmailGroup> TOEmails
        {
            get
            {
                return GetCollection<SyncEmailGroup>("TOEmails");
            }
        }
        [Association("SetupInfo")]
        public XPCollection<SyncSetupInfo> Info        {
            get
            {
                return GetCollection<SyncSetupInfo>("Info");
            }
        }

        private eAttachEmailSetup _AttachEmail;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Attach Email"), ToolTip("Attach Email")]
        public  eAttachEmailSetup AttachEmail
        {
            get { return _AttachEmail; }
            set { SetPropertyValue("AttachEmail", ref _AttachEmail, value); }
        }

        /*
         * list  of sending email
        */

        [Association("Helper")]
        public XPCollection<SyncSetupHelper> FunctionHelper
        {
            get
            {
                return GetCollection<SyncSetupHelper>("FunctionHelper");
            }
        }

        [Action(Caption = "Create Helper")]
        public void HelperCreate ()
        {
            string emailcc = "";
            string emailto = "";
            SyncSetupHelper oFunctionHelper;
            HelperDelete();
            foreach (CompanyInfo oCompany in Companies)
            {
                

                if (DataLevel == eDataLevelSetup.Company)
                {
                    emailcc= HelperEmailCC(oCompany);
                    emailto= HelperEmailTO(oCompany);

                    if (emailcc.Trim().Length > 0 || emailto.Trim().Length > 0)
                    {
                        oFunctionHelper = new SyncSetupHelper(Session);
                        oFunctionHelper.AlertSetup = this;
                        oFunctionHelper.Datalevel = oCompany;
                        oFunctionHelper.CCEmail = emailcc;
                        oFunctionHelper.ToEmail = emailto;
                        oFunctionHelper.SqlQueryBody = HelperSQlMessage(oCompany);
                        oFunctionHelper.Subject = this.EmailSubject;
                        oFunctionHelper.Save();
                        this.Session.CommitTransaction();
                    }
                }
                else if (DataLevel == eDataLevelSetup.OU)
                {
                    string txtSql = "";
                    XPCollection<OperatingUnitInfo> aOUs;
                    txtSql = String.Format("Company.Oid = {0}", Convert.ToInt16(oCompany.Oid ).ToString());
                    aOUs = new XPCollection<OperatingUnitInfo>(Session) { Criteria = CriteriaOperator.Parse(txtSql) };
                    foreach ( OperatingUnitInfo oOU in aOUs)
                    {
                        emailcc = HelperEmailCC(oOU);
                        emailto = HelperEmailTO(oOU);

                        if (emailcc.Trim().Length > 0 || emailto.Trim().Length > 0)
                        {
                            oFunctionHelper = new SyncSetupHelper(Session);
                            oFunctionHelper.AlertSetup = this;
                            oFunctionHelper.Datalevel = oOU;
                            oFunctionHelper.CCEmail = emailcc;
                            oFunctionHelper.ToEmail = emailto;
                            oFunctionHelper.SqlQueryBody = HelperSQlMessage(oOU);
                            oFunctionHelper.Subject = this.EmailSubject;
                            oFunctionHelper.Save();
                            this.Session.CommitTransaction();
                        }
                   
                    }
                }

            }
        }

        private void HelperDelete()
        {
            //sFilter = string.Format(" OU.Company.Oid == {0} && EmailGroup.AlertCCEmail.Oid == {1} ", oCompany.Oid, this.Oid);
            XPCollection<SyncSetupHelper> dAlertSetupHelper = this.FunctionHelper;
            this.Session.Delete(dAlertSetupHelper);
            this.Session.CommitTransaction();
        }
        //private CriteriaOperator filterOperator;
        private string sFilter = "";
        private string HelperEmailCC( CompanyInfo oCompany)
        {
            string sHelperEmail = "";
             XPCollection<SyncEmailGroup> aCCEmail= CCEmails;
            foreach(SyncEmailGroup aoccmail in aCCEmail )
            {
                sFilter = string.Format(" Company.Oid == {0}  ", oCompany.Oid);
                XPCollection<SyncPeople> aPeople = aoccmail.Emails;
                foreach (SyncPeople aoPeople in aPeople)
                {

                    XPCollection<OperatingUnitInfo> iOU = aoPeople.OUAccess;
                    iOU.Filter = CriteriaOperator.Parse(sFilter);
                    if (iOU.Count > 0)
                    {
                        //sHelperEmail += HelperEmail(aPeople) + " ;";
                        sHelperEmail += aoPeople.Email + " ;";
                    }

                }
            }
            sHelperEmail = removeLastChar(sHelperEmail);
            return sHelperEmail;
            //sFilter = string.Format(" OU.Company.Oid == {0} && EmailGroup.AlertCCEmail.Oid == {1} ", oCompany.Oid,this.Oid);
            //XPCollection<SyncPeople> aPeople;
            //aPeople = new XPCollection<SyncPeople>(Session) { Criteria = CriteriaOperator.Parse(sFilter) };
            //return HelperEmail(aPeople);
        }

        private string HelperEmailCC( OperatingUnitInfo oOU)
        {
            string sHelperEmail = "";
            //XPCollection<SyncEmailGroup> aCCEmail = CCEmails;
            //foreach (SyncEmailGroup aoccmail in aCCEmail)
            //{
            //    sFilter = string.Format(" OU.Oid == {0}  ", oOU.Oid);
            //    XPCollection<SyncPeople> aPeople = aoccmail.Emails;
            //    //aPeople = new XPCollection<SyncPeople>(Session) { Criteria = CriteriaOperator.Parse(sFilter) };
            //    aPeople.Filter = CriteriaOperator.Parse(sFilter);
            //    sHelperEmail += HelperEmail(aPeople) + " ;";
            //}

            XPCollection<SyncEmailGroup> aCCEmail = CCEmails;
            foreach (SyncEmailGroup aoccmail in aCCEmail)
            {
                sFilter = string.Format(" Oid == {0}  ", oOU.Oid);
                XPCollection<SyncPeople> aPeople = aoccmail.Emails;
                foreach (SyncPeople aoPeople in aPeople)
                {

                    XPCollection<OperatingUnitInfo> iOU = aoPeople.OUAccess;
                    iOU.Filter = CriteriaOperator.Parse(sFilter);
                    if (iOU.Count > 0)
                    {
                        //  sHelperEmail += HelperEmail(aPeople) + " ;";
                        //sHelperEmail += HelperEmail(aPeople) + " ;";
                        sHelperEmail += aoPeople.Email + " ;";
                    }

                }
            }
            sHelperEmail = removeLastChar(sHelperEmail);
            return sHelperEmail;
            //sFilter = string.Format(" OU.Oid == {0} && EmailGroup.AlertCCEmail.Oid == {1} ", oOU.Oid, this.Oid);
            //XPCollection<SyncPeople> aPeople;
            //aPeople = new XPCollection<SyncPeople>(Session) { Criteria = CriteriaOperator.Parse(sFilter) };
            //return HelperEmail(aPeople);
        }
        private string HelperEmailTO(CompanyInfo oCompany)
        {
            string sHelperEmail = "";

            //XPCollection<SyncEmailGroup> aTOEmail = TOEmails;
            //foreach (SyncEmailGroup aomail in aTOEmail)
            //{
            //    sFilter = string.Format(" OU.Company.Oid == {0}  ", oCompany.Oid);
            //    XPCollection<SyncPeople> aPeople = aomail.Emails;
            //    aPeople.Filter = CriteriaOperator.Parse(sFilter);
            //    sHelperEmail += HelperEmail(aPeople) + " ;";
            //}
            XPCollection<SyncEmailGroup> aCCEmail = TOEmails;
            foreach (SyncEmailGroup aoccmail in aCCEmail)
            {
                sFilter = string.Format(" Company.Oid == {0}  ", oCompany.Oid);
                XPCollection<SyncPeople> aPeople = aoccmail.Emails;
                foreach (SyncPeople aoPeople in aPeople)
                {

                    XPCollection<OperatingUnitInfo> iOU = aoPeople.OUAccess;
                    iOU.Filter = CriteriaOperator.Parse(sFilter);
                    if (iOU.Count > 0)
                    {
                        //sHelperEmail += HelperEmail(aPeople) + " ;";
                        sHelperEmail += aoPeople.Email + " ;";
                    }

                }
            }
            sHelperEmail = removeLastChar(sHelperEmail);

            return sHelperEmail;

            //sFilter = string.Format(" OU.Company.Oid == {0} && EmailGroup.alertTOEmail.Oid == {1} ", oCompany.Oid, this.Oid);
            //XPCollection<SyncPeople> aPeople;
            //aPeople = new XPCollection<SyncPeople>(Session) { Criteria = CriteriaOperator.Parse(sFilter) };
            //return HelperEmail(aPeople);
        }
        
  
        private string HelperEmailTO(OperatingUnitInfo oOU)
        {
            string sHelperEmail = "";

            //XPCollection<SyncEmailGroup> aTOEmail = TOEmails;
            //foreach (SyncEmailGroup aomail in aTOEmail)
            //{
            //    sFilter = string.Format(" OU.Oid == {0}  ", oOU.Oid);
            //    XPCollection<SyncPeople> aPeople = aomail.Emails;
            //    aPeople.Filter = CriteriaOperator.Parse(sFilter);
            //    sHelperEmail += HelperEmail(aPeople) + " ;";
            //}
            XPCollection<SyncEmailGroup> aCCEmail = TOEmails;

            foreach (SyncEmailGroup aoccmail in aCCEmail)
            {
                sFilter = string.Format(" Oid == {0}  ", oOU.Oid);
                XPCollection<SyncPeople> aPeople = aoccmail.Emails;
                foreach (SyncPeople aoPeople in aPeople)
                {

                    XPCollection<OperatingUnitInfo> iOU = aoPeople.OUAccess;
                    iOU.Filter = CriteriaOperator.Parse(sFilter);
                    if (iOU.Count > 0)
                    {
                        // sHelperEmail += HelperEmail(aPeople) + " ;";
                        sHelperEmail += aoPeople.Email + " ;";
                    }

                }
            }
            sHelperEmail = removeLastChar(sHelperEmail);
            return sHelperEmail;
            //sFilter = string.Format(" OU.Oid == {0} && EmailGroup.alertTOEmail.Oid == {1} ", oOU.Oid, this.Oid);
            //XPCollection<SyncPeople> aPeople;
            //aPeople = new XPCollection<SyncPeople>(Session) { Criteria = CriteriaOperator.Parse(sFilter) };
            //return HelperEmail(aPeople);
        }
        private string HelperEmail(XPCollection<SyncPeople> oaEmailList)
        {
            string aEmail = "";

            foreach (SyncPeople oemail in oaEmailList)
            {
                aEmail += oemail.Email.ToString() + " ;";
            }

            if (aEmail.Length > 1)
            {
                aEmail = aEmail.Substring(0, aEmail.Length - 1);
            }
            
            return aEmail;
        }
        private string removeLastChar(string sLastChar = "")
        {
            sLastChar.Trim();
            if (sLastChar.Length > 1)
            {
                sLastChar = sLastChar.Substring(0, sLastChar.Length - 1);
            }
            return sLastChar;
        }
        private string HelperSQlMessage(CompanyInfo oCompany)
        {
            string aSql = "";

            aSql = SqlQuery.Replace("~Company~", oCompany.Company.ToString());
            return aSql;
        }
        private string HelperSQlMessage(OperatingUnitInfo oOU)
        {
            string aSql = "";
         
            aSql = SqlQuery.Replace("~OU~", oOU.OU.ToString());
            return aSql;
        }

        private string HelperSQlMessage (string aSql="" )
        {
            
            return aSql;
        }
        private Boolean _Active;
        //[Appearance("SyncSetupLastUpdateEnable", Enabled = false)]
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Active"), ToolTip("Active")]
        //[Size(50)]
        public  Boolean Active
        {
            get { return _Active; }
            set { SetPropertyValue("Active", ref _Active, value); }
        }
        private DateTime _LastUpdate;
        [Appearance("SyncSetupLastUpdateEnable", Enabled = false)]
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Date"), ToolTip("Date")]
        //[Size(50)]
        public  DateTime LastUpdate
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

    //public enum eDataLevelSetup
    //{
    //    [XafDisplayName("Region")]
    //    Region = 0,
    //    [XafDisplayName("Company")]
    //    Company = 1,
    //    [XafDisplayName("Operating Unit")]
    //    OU = 2
    //};
    //public enum eAttachEmailSetup
    //{
    //    [XafDisplayName("None")]
    //    None = 0,
    //    [XafDisplayName("Excel")]
    //    Excel = 1,
    //    [XafDisplayName("Text")]
    //    Text = 2,
    //    [XafDisplayName("Words")]
    //    Words = 3,
    //    [XafDisplayName("PDF")]
    //    Pdf = 4
    //};

}