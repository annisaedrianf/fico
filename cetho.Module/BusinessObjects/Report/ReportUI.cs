using System;
using System.ComponentModel;
using DevExpress.Data.Filtering;
using System.ServiceModel.Channels;
using DevExpress.ExpressApp.ConditionalAppearance;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Editors;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
// lis of OU
namespace cetho.Module.BusinessObjects
{

    [DefaultClassOptions]
    [ImageName("ModelEditor_Views")]
    [DefaultProperty("Title")]
    [NavigationItem("Reports")]

    [System.ComponentModel.DisplayName("Report MMR")]

    public class ReportUI : XPObject
    {
        public ReportUI(Session session) : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.

            PDF = true;
            Xls = true;
            WhatsApp = true;
            Email = true;

            // find new data
            //XPCollection<SyncReport> syncReports = new XPCollection<SyncReport>(session);
                


        }

        
     // Notes for ReportUIMMRFFBProd : 
        private SyncReport _ReportBy;
        [XafDisplayName("Report By"), ToolTip("Report By")]
        // [Appearance("ReportUIMMRFFBProdReportBy", Enabled = true)]
        // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
        // [RuleRequiredField(DefaultContexts.Save)] 
        // [IsSearch(true)]
        public SyncReport ReportBy
        {
            get { return _ReportBy; }
            set { SetPropertyValue(nameof(ReportBy), ref _ReportBy, value); }
        }

        private string _ReportId;
        //[RuleRequiredField(DefaultContexts.Save)]
       
        [XafDisplayName("Report Id"), ToolTip("Report Id")]
        [Size(50)]
        [DevExpress.ExpressApp.Data.Key]
        public string ReportId
        {
            get { return _ReportId; }
            set { SetPropertyValue("ReportId", ref _ReportId, value); }
        }
        private string _ViewId;
        //[RuleRequiredField(DefaultContexts.Save)]

        [XafDisplayName("View Id"), ToolTip("View Id")]
        [Size(150)]
        //[DevExpress.ExpressApp.Data.Key]
        public string ViewId
        {
            get {  if (_ViewId==null)
                    {
                        _ViewId = "";
                    }
                    return _ViewId; }
            set { SetPropertyValue("ViewId", ref _ViewId, value); }
        }

        // 
        // Notes for SyncTaskReport : 
        private bool _Email;
        [XafDisplayName("Email"), ToolTip("Email")]
        // [Appearance("SyncTaskReportEmail", Enabled = true)]
        // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
        // [RuleRequiredField(DefaultContexts.Save)] 
        // [IsSearch(true)]
        public bool Email
        {
            get { return _Email; }
            set { SetPropertyValue(nameof(Email), ref _Email, value); }
        }
        // 
        // Notes for SyncTaskReport : 
        private bool _WhatsApp;
        [XafDisplayName("WhatsApp"), ToolTip("WhatsApp")]
        // [Appearance("SyncTaskReportWhatUp", Enabled = true)]
        // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
        // [RuleRequiredField(DefaultContexts.Save)] 
        // [IsSearch(true)]
        public bool WhatsApp
        {
            get { return _WhatsApp; }
            set { SetPropertyValue(nameof(WhatsApp), ref _WhatsApp, value); }
        }
        // 
        // Notes for SyncTaskReport : 
        private bool _PDF;
        [XafDisplayName("PDF"), ToolTip("PDF")]
        // [Appearance("SyncTaskReportPDF", Enabled = true)]
        // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
        // [RuleRequiredField(DefaultContexts.Save)] 
        // [IsSearch(true)]
        public bool PDF
        {
            get { return _PDF; }
            set { SetPropertyValue(nameof(PDF), ref _PDF, value); }
        }
        // 
        // Notes for SyncTaskReport : 
        private bool _Xls;
        [XafDisplayName("Xls"), ToolTip("Xls")]
        // [Appearance("SyncTaskReportXls", Enabled = true)]
        // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
        // [RuleRequiredField(DefaultContexts.Save)] 
        // [IsSearch(true)]
        public bool Xls
        {
            get { return _Xls; }
            set { SetPropertyValue(nameof(Xls), ref _Xls, value); }
        }

        //[Appearance("VisibleReportUIMMRFFBProdOID", Visibility = ViewItemVisibility.Hide)] 
        //public int Oid 
        //{ 
        //    get { return base.Oid; }
        //    set { base.Oid = value; }
        //}
        // 
        //// Notes for ReportUIMMRFFBProd : 
        //[XafDisplayName("Region"), ToolTip("Region")]
        //// [Appearance("ReportUIMMRFFBProdCompany", Enabled = true)]
        //// [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
        //// [RuleRequiredField(DefaultContexts.Save)] 
        //// [IsSearch(true)]
        //[Association("RptUIRegion")]
        //public XPCollection<RegionInfo> Region
        //{
        //    get
        //    {
        //        return GetCollection<RegionInfo>("Region");
        //    }
        //}

        // Notes for ReportUIMMRFFBProd : 
        [XafDisplayName("Company"), ToolTip("Company")]
        // [Appearance("ReportUIMMRFFBProdCompany", Enabled = true)]
        // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
        // [RuleRequiredField(DefaultContexts.Save)] 
        // [IsSearch(true)]
        [Association("RptUICompany")]
        public XPCollection<CompanyInfo> Company
        {
            get
            {
                return GetCollection<CompanyInfo>("Company");
            }
        }
        //// 
        //// Notes for ReportUIMMRFFBProd : 
        [XafDisplayName("OU"), ToolTip("OU")]
        // [Appearance("ReportUIMMRFFBProdOU", Enabled = true)]
        // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
        // [RuleRequiredField(DefaultContexts.Save)] 
        // [IsSearch(true)]
        [Association("RptUIOU")]
        public XPCollection<OperatingUnitInfo> OU
        {
            get
            {
                return GetCollection<OperatingUnitInfo>("OU");
            }
        }
        // 
        //// Notes for ReportUIMMRFFBProd : 
        //[XafDisplayName("Estate"), ToolTip("Estate")]
        //// [Appearance("ReportUIMMRFFBProdEstate", Enabled = true)]
        //// [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
        //// [RuleRequiredField(DefaultContexts.Save)] 
        //// [IsSearch(true)]
        //[Association("RptUIEstate")]
        //public XPCollection<EstateInfo> Estate
        //{
        //    get
        //    {
        //        return GetCollection<EstateInfo>("Estate");
        //    }
        //}
        //// 
        //// Notes for ReportUIMMRFFBProd : 
        //private PeriodInfo _Periode;
        //[XafDisplayName("Period"), ToolTip("Period")]
        //// [Appearance("ReportUIMMRFFBProdPeriode", Enabled = true)]
        //// [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
        //// [RuleRequiredField(DefaultContexts.Save)] 
        //// [IsSearch(true)]
        //public PeriodInfo Periode
        //{
        //    get { return _Periode; }
        //    set { SetPropertyValue(nameof(Periode), ref _Periode, value); }
        //}

        // 
        // Notes for SyncTaskReport : 

        [XafDisplayName("Task Report"), ToolTip("Task Report")]
        // [Appearance("SyncTaskReportParameter", Enabled = true)]
        // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
        // [RuleRequiredField(DefaultContexts.Save)] 
        // [IsSearch(true)]
        [Association("ReportUITask")]
        public XPCollection<SyncTaskReport> Task
        {
            get
            {
                return GetCollection<SyncTaskReport>("Task");
            }
        }

        //public string GetRegionList()
        //{
        //    string ogetRegion = "";

        //    foreach (RegionInfo item in Region)
        //    {
        //        ogetRegion = ogetRegion + item.Region + ",";
        //    }

        //    return ogetRegion;
        //}

        public string GetCompanyList() 
        {
            string ogetCompany = "";

            foreach (CompanyInfo item in Company)
            {
                ogetCompany = ogetCompany + item.CompanyId + ",";
            }

            return ogetCompany;
        }

        public string GetOUList()
        {
            string ogetOU = "";

            foreach (OperatingUnitInfo item in OU)
            {
                ogetOU = ogetOU + item.OU + ",";
            }

            return ogetOU;
        }

        //public string GetEstateList()
        //{
        //    string ogetEstate = "";

        //    foreach (EstateInfo item in Estate)
        //    {
        //        ogetEstate = ogetEstate + item.Estate + ",";
        //    }

        //    return ogetEstate;
        //}

    }

}