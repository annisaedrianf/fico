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
    [System.ComponentModel.DisplayName("Alert Setup Info")]
    public class SyncSetupInfo : XPObject
    {
        //public SyncSetupInfo() : base()
        //{
        //    // This constructor is used when an object is loaded from a persistent storage.
        //    // Do not place any code here.
        //}

        public SyncSetupInfo(Session session) : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            if (!IsLoading && !IsSaving && !IsDeleted && Idx <= 0)
            {
                Idx = GetNumber;
            }
        }
        protected override void OnSaving()
        {
            base.OnSaving();
            if (!IsLoading  && !IsDeleted && Idx <= 0)
            {
                    Idx = GetNumber;
        
            }
        }

        public  int GetNumber
        {

            get
            {
                int Num;
                if ( AlertSetup != null)
                {
                    CriteriaOperator expression = CriteriaOperator.Parse("Max(Idx)");
                    CriteriaOperator filter = CriteriaOperator.Parse(" AlertSetup.Oid = ?  ", this.AlertSetup.Oid);
                    var max = Session.Evaluate<SyncSetupInfo>(expression, filter);
                    Num = max == null ? 1 : (int)max + 1;
                }
                else
                {
                    Num = 0;
                }
             
                return Num;
            }
        }

        private int _Idx;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Idx *"), ToolTip("Idx *")]
        //[Size(350)]
        //[NullText("Title")]
        public  int  Idx
        {
            get { return _Idx; }
            set { SetPropertyValue("Idx", ref _Idx, value); }
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
            get { return _SqlQuery; }
            set { SetPropertyValue("SqlQuery", ref _SqlQuery, value); }
        }

        private eAttachEmailSetup _AttachEmail;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Attach Email"), ToolTip("Attach Email")]
        public  eAttachEmailSetup AttachEmail
        {
            get { return _AttachEmail; }
            set { SetPropertyValue("AttachEmail", ref _AttachEmail, value); }
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

        private SyncSetup _AlertSetup;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Alert Setup"), ToolTip("Alert Setup")]
        [Association("SetupInfo")]
        public  SyncSetup AlertSetup
        {
            get { return _AlertSetup; }
            set { SetPropertyValue("AlertSetup", ref _AlertSetup, value); }
        }
        
    }

}