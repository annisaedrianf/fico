using System;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
// lis of OU
namespace cetho.Module.BusinessObjects
{

    [DefaultClassOptions]
    [ImageName("ModelEditor_Views")]
    [DefaultProperty("Title")]
    [NavigationItem("Org. Structure")]

    [System.ComponentModel.DisplayName("OU")]

    public class OperatingUnitInfo : XPObject
    {
        private string _OU;
        [RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("OU"), ToolTip("OU")]
        //[Size(6)]
        [IsSearch(true)]
        public  string  OU
        {
            get { return _OU; }
            set { SetPropertyValue("OU", ref _OU, value); }
        }

        private string _OUName;
        [RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("OU Name"), ToolTip("OU Name")]
        public  string OUName
        {
            get { return _OUName; }
            set { SetPropertyValue("OUName", ref _OUName, value); }
        }

        private CompanyInfo _Company;
        [RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Company"), ToolTip("Company")]
        [Association]
        public  CompanyInfo Company
        {
            get { return _Company; }
            set { SetPropertyValue("Company", ref _Company, value); 
                 
                }
        }
        //private CountryInfo _Country;
        //[RuleRequiredField(DefaultContexts.Save)]
        //[XafDisplayName("Country"), ToolTip("Country")]
        //public  CountryInfo Country
        //{
        //    get { return _Country; }
        //    set { SetPropertyValue("Country", ref _Country, value); }
        //}
        //private RegionInfo _Region;
        ////[RuleRequiredField(DefaultContexts.Save)]
        //[XafDisplayName("Region"), ToolTip("Region")]
        ////[Size(50)]
        //public  RegionInfo Region
        //{
        //    get
        //    {

        //        return _Region;
        //    }
        //    set { SetPropertyValue("Region", ref _Region, value); }
        //}
        //[XafDisplayName("Estates"), ToolTip("Estates")]
        //[Association]
        //public XPCollection<EstateInfo> Estates
        //{
        //    get
        //    {
        //        return GetCollection<EstateInfo>("Estates");
        //    }
        //}
        private SyncPeople _OUPeople;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("OUPeople"), ToolTip("OUPeople")]
        [Association("OUPersonAccess")]
        public XPCollection<SyncPeople> OUPeople
        {
            get
            {
                return GetCollection<SyncPeople>("OUPeople");
            }
        }

        private UserLoginInfo _OUUserLogin;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("OUUserLogin"), ToolTip("OUUserLogin")]
        [Association("OUUserLoginAccess")]
        public XPCollection<UserLoginInfo> OUUserLogin
        {
            get
            {
                return GetCollection<UserLoginInfo>("OUUserLogin");
            }
        }

        //public OperatingUnitInfo() : base()
        //{
        //    // This constructor is used when an object is loaded from a persistent storage.
        //    // Do not place any code here.
        //}

        public OperatingUnitInfo(Session session) : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
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

        private ReportUI _RptUI;
        //[RuleRequiredField(DefaultContexts.Save)]
        // [Appearance("ReportUIMMRFFBProdCompany", Enabled = true)]
        // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
        // [RuleRequiredField(DefaultContexts.Save)] 
        // [IsSearch(true)]
        [Association("RptUIOU")]
        [XafDisplayName("Report UI"), ToolTip("Report UI")]
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