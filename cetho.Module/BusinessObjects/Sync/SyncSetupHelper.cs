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
    [System.ComponentModel.DisplayName("Alert Setup Helper")]
    public class SyncSetupHelper : XPObject
    {
        //public SyncSetupHelper() : base()
        //{
        //    // This constructor is used when an object is loaded from a persistent storage.
        //    // Do not place any code here.
        //}

        public SyncSetupHelper(Session session) : base(session)
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
            //LastUpdatedUser = Session.FindObject<ApplicationUser>( new BinaryOperator("UserName", tUser));

            LastUpdate = DateTime.Now;

        }


        private SyncSetup _AlertSetup;
        //[RuleRequiredField(DefaultContexts.Save)]
        [Association("Helper")]
        [XafDisplayName("Alert Setup"), ToolTip("Alert Setup")]

        public  SyncSetup AlertSetup
        {
            get { return _AlertSetup; }
            set { SetPropertyValue("AlertSetup", ref _AlertSetup, value); }
        }

        private Object _Datalevel;
        [RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Data Level"), ToolTip("Data Level")]

        public  Object Datalevel
        {
            get { return _Datalevel; }
            set { SetPropertyValue("Datalevel", ref _Datalevel, value); }
        }

        private string _Subject;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Subject"), ToolTip("Subject")]
        [Size(500)]
        public  string Subject
        {
            get { return _Subject; }
            set { SetPropertyValue("Subject", ref _Subject, value); }
        }

        private string _SqlQueryBody;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Sql Query Body"), ToolTip("Sql Query Body")]
        [Size(SizeAttribute.Unlimited)]
        public  string SqlQueryBody
        {
            get { return _SqlQueryBody; }
            set { SetPropertyValue("SqlQueryBody", ref _SqlQueryBody, value); }
        }

        private string _SqlQueryAttachment;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Sql Query Attachment"), ToolTip("Sql Query Attachment")]
        [Size(SizeAttribute.Unlimited)]
        public  string SqlQueryAttachment
        {
            get { return _SqlQueryAttachment; }
            set { SetPropertyValue("SqlQueryAttachment", ref _SqlQueryAttachment, value); }
        }

        private string _CCEmail;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("CCEmail"), ToolTip("CCEmail")]
        [Size(SizeAttribute.Unlimited)]
        public  string CCEmail
        {
            get { return _CCEmail; }
            set { SetPropertyValue("CCEmail", ref _CCEmail, value); }
        }

        private string _ToEmail;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("To Email"), ToolTip("To Email")]
        [Size(SizeAttribute.Unlimited)]
        public  string ToEmail
        {
            get { return _ToEmail; }
            set { SetPropertyValue("ToEmail", ref _ToEmail, value); }
        }

        private string _DataID;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Data ID"), ToolTip("Data ID")]
        [Size(500)]
        public  string DataID
        {
            get { return _DataID; }
            set { SetPropertyValue("DataID", ref _DataID, value); }
        }

        public string ConnectionString()
        {
            string sConn = "";
            string sqlQuery = "";
            if (AlertSetup.DataLevel==eDataLevelSetup.Region)
            {
                //sqlQuery = string.Format(" Oid == '{0}' ",  Datalevel.Oid.ToString());
                //CriteriaOperator filterOperator = CriteriaOperator.Parse(sqlQuery);
                //RegionInfo oRegion = Session.FindObject<RegionInfo>(filterOperator);
                //if (oRegion != null)
                //{
                //    sConn = oRegion.ConnectionString;
                //    DataID = oRegion.Region;
                //}
            }
            else if(AlertSetup.DataLevel == eDataLevelSetup.Company)
            {
                int OIod = 0;
                //sqlQuery = string.Format(" Oid == '{0}' ", Datalevel.Oid.ToString());
                sqlQuery = string.Format($" Oid == {OIod} ");
                CriteriaOperator filterOperator = CriteriaOperator.Parse(sqlQuery);
                CompanyInfo oCompany = Session.FindObject<CompanyInfo>(filterOperator);
                if (oCompany != null)
                {
                    sConn = oCompany.ConnectionString;
                    DataID = oCompany.Company;
                }
            }
            else if (AlertSetup.DataLevel == eDataLevelSetup.OU)
            {
                int OIod = 0;
                sqlQuery = string.Format($" Oid == {OIod} ");
                //sqlQuery = string.Format(" Oid == '{0}' ", Datalevel.Oid.ToString());
                CriteriaOperator filterOperator = CriteriaOperator.Parse(sqlQuery);
                OperatingUnitInfo oOU = Session.FindObject<OperatingUnitInfo>(filterOperator);
                if (oOU != null)
                {
                    sConn = oOU.Company.ConnectionString;
                    DataID = oOU.OU;
                }
            }

            return sConn;
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

        //private ApplicationUser _LastUpdatedUser;
        //[Appearance("SKBaseLastUpdatedUserEnable", Enabled = false)]
        ////[RuleRequiredField(DefaultContexts.Save)]
        //[XafDisplayName("Last Update User"), ToolTip("Last Update User")]
        ////[Size(50)]
        //public  ApplicationUser LastUpdatedUser
        //{
        //    get { return _LastUpdatedUser; }
        //    set { SetPropertyValue("LastUpdatedUser", ref _LastUpdatedUser, value); }
        //}
    }

}