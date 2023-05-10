using System;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;

// LIST OF COMAPNY
namespace cetho.Module.BusinessObjects
{
    [DefaultClassOptions]
    [ImageName("ModelEditor_Views")]
    [DefaultProperty("Company")]
    [NavigationItem("Org. Structure")]
    
    [System.ComponentModel.DisplayName("Company")]

    public class CompanyInfo : SKBase
    {
        //private string _Company;
        [RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Company"), ToolTip("Company")]
        //[Size(6)]
        [IsSearch(true)]
        
        public  string Company
        {
            get { return base.Title; }
            //set { SetPropertyValue("Company", ref _Company, value); }
            set { base.Title= value; }
        }

        //private string _CompanyName;
        [RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Company Name"), ToolTip("Company Name")]
        [Size(150)]
        public  string CompanyName
        {
            get { return base.Description; }
            //set { SetPropertyValue("CompanyName", ref base.Description, value); }
            set { base.Description = value; }
        }

        //private eIntiPlasma _IntiPlasma;
        //[RuleRequiredField(DefaultContexts.Save)]
        //[XafDisplayName("Inti/Plasma"), ToolTip("Inti/Plasma")]

        //public  eIntiPlasma IntiPlasma
        //{
        //    get { return _IntiPlasma; }
        //    set { SetPropertyValue("IntiPlasma", ref _IntiPlasma, value); }
        //}

        // private CountryInfo _Corporate;
        //// [RuleRequiredField(DefaultContexts.Save)]
        // [XafDisplayName("Country"), ToolTip("Country")]

        // public  CountryInfo Corporate
        // {
        //     get { return _Corporate; }
        //     set { SetPropertyValue("Country", ref _Corporate, value); }
        // }
        // private RegionInfo _Region;
        // //[RuleRequiredField(DefaultContexts.Save)]
        // [XafDisplayName("Region"), ToolTip("Region")]
        // [Association]
        // public  RegionInfo Region
        // {
        //     get { return _Region; }
        //     set { 

        //         SetPropertyValue("Region", ref _Region, value);
        //         //if (!IsLoading && !IsSaving && !IsDeleted)
        //         //{
        //         //    if (value != null)
        //         //    {
        //         //        if (_Region != value && _Region != null)
        //         //        {
        //         //            changeTheRegion(value);
        //         //        }
        //         //        else
        //         //        { 
        //         //        Region = value;
        //         //        if (value.Country != null)
        //         //        {
        //         //            try
        //         //            {
        //         //                Corporate = value.Country;
        //         //            }
        //         //            catch (Exception ex)
        //         //            {
        //         //                Console.WriteLine($" change region company {ex.Message}");
        //         //            }
        //         //        }
        //         //    }
        //         //    }
        //         //}
        //     }
        // }

        // public void changeTheRegion(RegionInfo oRegion )
        // { 
        //     foreach ( OperatingUnitInfo item in OUs)
        //     {
        //         //item.Region = oRegion;
        //         Session.Save(item);
        //         Session.CommitTransaction();
        //     }

        // }
        [XafDisplayName("OU"), ToolTip("OU")]
        [Association]
        public XPCollection<OperatingUnitInfo> OUs
        {
            get
            {
                return GetCollection<OperatingUnitInfo>("OUs");
            }
        }




        //[XafDisplayName("Helpdesk Assignment"), ToolTip("Helpdesk Assignment")]
        ////[Size(SizeAttribute.Unlimited)]
        //[Association("UserAssignment")]
        //public  UserInfo Helpdesk
        //{
        //    get { return GetPropertyValue<UserInfo>("Helpdesk"); }
        //    set { SetPropertyValue("Helpdesk", value); }
        //}
        //private SyncSetup _AlertSetup;
        ////[RuleRequiredField(DefaultContexts.Save)]
        //[XafDisplayName("AlertSetup"), ToolTip("AlertSetup")]
        //[Association("CompanyAlert")]
        //public  SyncSetup AlertSetup
        //{
        //    get { return _AlertSetup; }
        //    set { SetPropertyValue("AlertSetup", ref _AlertSetup, value); }
        //}
        [Association("CompanyAlert")]
        public XPCollection<SyncSetup> AlertSetup
        {
            get
            {
                return GetCollection<SyncSetup>("AlertSetup");
            }
        }
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Database"), ToolTip("Database")]
        [Size(50)]
        public  string Database
        {
            get { return GetPropertyValue<string>("Database"); }
            set { SetPropertyValue("Database", value); }
        }

        //private string _ConnectionString;
        //[XafDisplayName("ConnectionString "), ToolTip("ConnectionString")]
        //[Size(SizeAttribute.Unlimited)]
        //public  string ConnectionString
        //{
        //    get { return _ConnectionString; }
        //    set { SetPropertyValue("ConnectionString", ref _ConnectionString, value); }

        //    //get { return GetPropertyValue<string>("Database"); }
        //    //set { SetPropertyValue("Database", value); }
        //}


        private string _ConnectionString;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("ConnectionString"), ToolTip("ConnectionString")]
        //[Size(50)]
        [Size(SizeAttribute.Unlimited)]
        public string ConnectionString
        {
            get { return _ConnectionString; }
            set { SetPropertyValue("ConnectionString", ref _ConnectionString, value); 
            }
        }

        [XafDisplayName("Connection DataBase "), ToolTip("Connection DataBase")]
        //[Size(SizeAttribute.Unlimited)]
        public  SyncConnection Connection
        {
            get { return GetPropertyValue<SyncConnection>("ConnectionString"); }
            set { SetPropertyValue("ConnectionString", value); }
        }


        [Association("SyncCompanySetup")]
        public XPCollection<SyncCompanyInfo> SyncSetup
        {
            get
            {
                return GetCollection<SyncCompanyInfo>("SyncSetup");
            }
        }

        //public CompanyInfo() : base()
        //{
        //    // This constructor is used when an object is loaded from a persistent storage.
        //    // Do not place any code here.
        //}

        public CompanyInfo(Session session) : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            Status = eActiveStatus.Active;
            // Place here your initialization code.
        }
        private string _GPId;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("GP Id"), ToolTip("GPId")]
        [Size(50)]
        [IsSyncSearch(true)]
        public  string GPId
        {
            get { return _GPId; }
            set { SetPropertyValue("GPId", ref _GPId, value); }
        }

        private string _CompanyId;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Company Id"), ToolTip("CompanyId")]
        [Size(50)]
        public  string CompanyId
        {
            get { return _CompanyId; }
            set { SetPropertyValue("CompanyId", ref _CompanyId, value); }
        }

        private eActiveStatus _Status;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Status"), ToolTip("Status")]
        [Size(50)]
        public  eActiveStatus Status
        {
            get { return _Status; }
            set { SetPropertyValue("Status", ref _Status, value); }
        }

        
        //[RuleRequiredField(DefaultContexts.Save)]
        // [Appearance("ReportUIMMRFFBProdCompany", Enabled = true)]
        // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
        // [RuleRequiredField(DefaultContexts.Save)] 
        // [IsSearch(true)]
        [Association("RptUICompany")]
        [XafDisplayName("Rpt UI"), ToolTip("Rpt UI")]
        [Size(50)]
        public XPCollection<ReportUI> RprUI
        {
            get
            {
                return GetCollection<ReportUI>("RprUI");
            }
        }
    }

}