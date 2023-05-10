using DevExpress.Xpo;
using System.ComponentModel;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.PermissionPolicy;
using DevExpress.ExpressApp.DC;

namespace cetho.Module.BusinessObjects
{
    [DefaultClassOptions]
    [ImageName("BO_Contact")]
    [DefaultProperty("UserName")]
    [System.ComponentModel.DisplayName("User")]
    [NavigationItem("Master")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (http://documentation.devexpress.com/#Xaf/CustomDocument2701).
    public  class UserAccessInfo : PermissionPolicyUser
    {
        public UserAccessInfo(Session session)
            : base(session)
        {
            
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();

            // Place your initialization code here (http://documentation.devexpress.com/#Xaf/CustomDocument2834).

        }
        protected override void OnSaving()
        {
            base.OnSaving();
          

        }

        protected override void OnDeleting()
        {
            base.OnDeleting();
          
        }

        private SyncPeople _People;
        [XafDisplayName("People"), ToolTip("People")]
        // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)]
        //  [Persistent("DatabaseColumnName"), RuleRequiredField(DefaultContexts.Save)]
        //[ImmediatePostData]
        public SyncPeople People
        {
            get { return _People; }
            set { SetPropertyValue("People", ref _People, value); }
        }

        //[Association("UserAssignment")]
        ////[DevExpress.Xpo.Aggregated]
        //public XPCollection<CompanyInfo> HelpdeskAssignments
        //{
        //    get
        //    {
        //        return GetCollection<CompanyInfo>("HelpdeskAssignments");
        //    }
        //}

        //  [Association("UserEstate")]
        //  //[DevExpress.Xpo.Aggregated]
        //  [Appearance("GPUser_UserEstate", Criteria = " AllEstate = true", Visibility = ViewItemVisibility.Show)]
        //  [XafDisplayName("Estate"), ToolTip("Estate")]
        //  public XPCollection<GPEstate> Estates
        //  {
        //      get { return GetCollection<GPEstate>("Estates"); }
        //  }



        //private string _PersistentProperty;
        //[XafDisplayName("My display name"), ToolTip("My hint message")]
        //[ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)]
        //[Persistent("DatabaseColumnName"), RuleRequiredField(DefaultContexts.Save)]
        //public string PersistentProperty {
        //    get { return _PersistentProperty; }
        //    set { SetPropertyValue("PersistentProperty", ref _PersistentProperty, value); }
        //}

        //[Action(Caption = "My UI Action", ConfirmationMessage = "Are you sure?", ImageName = "Attention", AutoCommit = true)]
        //public void ActionMethod() {
        //    // Trigger a custom business logic for the current record in the UI (http://documentation.devexpress.com/#Xaf/CustomDocument2619).
        //    this.PersistentProperty = "Paid";
        //}


    }
}

