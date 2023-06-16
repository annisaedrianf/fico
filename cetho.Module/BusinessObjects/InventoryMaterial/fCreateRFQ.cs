// Class Name : fCreateRFQ.cs 
// Project Name : FICO 
// Last Update : 16/06/2023 15:05:56  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 16/06/2023 15:05:56 
 // Updated :   
//======================================================================== 
 
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
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Editors;

namespace cetho.Module.BusinessObjects 
{ 
   [DefaultClassOptions] 
   [ImageName("ModelEditor_Views")] 
   [DefaultProperty("TaxCatgr")]
   [NavigationItem("Master")]
   // Standard Document
   [System.ComponentModel.DisplayName("Create RFQ : Initial Screen")]
   public class fCreateRFQ : XPObject
   {
     public fCreateRFQ(Session session) : base(session) 
     {
       // This constructor is used when an object is loaded from a persistent storage.
       // Do not place any code here.
     }
     public override void AfterConstruction()
     {
       base.AfterConstruction();
       // Place here your initialization code.
       //SecuritySystem.CurrentUserName
       //LastUpdateUser = Session.GetObjectByKey<GPUser>(SecuritySystem.CurrentUserId);
       string tUser = SecuritySystem.CurrentUserName.ToString();
       //LastUpdateUser = Session.FindObject<GPUser>(new BinaryOperator("UserName", SecuritySystem.CurrentUserName.ToString())); 
       // LastUpdateUser = Session.FindObject<GPUser>(new BinaryOperator("UserName", tUser)); 
       // LastUpdate = DateTime.Now; 
     } 
     protected override void OnSaving()
     {
       base.OnSaving();
     } 
     protected override void OnSaved()
     {
       base.OnSaved();
     } 
     protected override void OnDeleting()
     {
       base.OnDeleting();
     } 
     protected override void OnDeleted()
     {
       base.OnDeleted();
     } 
     public void Sync()
     {
     } 
     [Appearance("VisiblefCreateRFQOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for fCreateRFQ : 
     private string _rfqtype; 
     [XafDisplayName("RFQ Type"), ToolTip("RFQ Type")] 
     // [Appearance("fCreateRFQrfqtype", Enabled = true)]
     // [Appearance("fCreateRFQrfqtypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string rfqtype
     { 
       get { return _rfqtype; } 
       set { SetPropertyValue(nameof(rfqtype), ref _rfqtype, value); } 
     } 
     // 
     // Notes for fCreateRFQ : 
     private fLanguage _langkey; 
     [XafDisplayName("Language Key"), ToolTip("Language Key")] 
     // [Appearance("fCreateRFQlangkey", Enabled = true)]
     // [Appearance("fCreateRFQlangkeyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fLanguage langkey
     { 
       get { return _langkey; } 
       set { SetPropertyValue(nameof(langkey), ref _langkey, value); } 
     } 
     // 
     // Notes for fCreateRFQ : 
     private DateTime _rqfdate; 
     [XafDisplayName("RFQ Date"), ToolTip("RFQ Date")] 
     // [Appearance("fCreateRFQrqfdate", Enabled = true)]
     // [Appearance("fCreateRFQrqfdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime rqfdate
     { 
       get { return _rqfdate; } 
       set { SetPropertyValue(nameof(rqfdate), ref _rqfdate, value); } 
     } 
     // 
     // Notes for fCreateRFQ : 
     private DateTime _quotationdeadline; 
     [XafDisplayName("Quotation Deadline"), ToolTip("Quotation Deadline")] 
     // [Appearance("fCreateRFQquotationdeadline", Enabled = true)]
     // [Appearance("fCreateRFQquotationdeadlineVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime quotationdeadline
     { 
       get { return _quotationdeadline; } 
       set { SetPropertyValue(nameof(quotationdeadline), ref _quotationdeadline, value); } 
     } 
     // 
     // Notes for fCreateRFQ : 
     private string _rfq; 
     [XafDisplayName("RFQ"), ToolTip("RFQ")] 
     // [Appearance("fCreateRFQrfq", Enabled = true)]
     // [Appearance("fCreateRFQrfqVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string rfq
     { 
       get { return _rfq; } 
       set { SetPropertyValue(nameof(rfq), ref _rfq, value); } 
     } 
     // Organizational Data
     // Notes for fCreateRFQ : 
     private string _purchorganization; 
     [XafDisplayName("Purch. Organization"), ToolTip("Purch. Organization")] 
     // [Appearance("fCreateRFQpurchorganization", Enabled = true)]
     // [Appearance("fCreateRFQpurchorganizationVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string purchorganization
     { 
       get { return _purchorganization; } 
       set { SetPropertyValue(nameof(purchorganization), ref _purchorganization, value); } 
     } 
     // Organizational Data
     // Notes for fCreateRFQ : 
     private string _purchgroup; 
     [XafDisplayName("Purchasing Group"), ToolTip("Purchasing Group")] 
     // [Appearance("fCreateRFQpurchgroup", Enabled = true)]
     // [Appearance("fCreateRFQpurchgroupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string purchgroup
     { 
       get { return _purchgroup; } 
       set { SetPropertyValue(nameof(purchgroup), ref _purchgroup, value); } 
     } 
     // Default Data for Items
     // Notes for fCreateRFQ : 
     private string _itemcateg; 
     [XafDisplayName("Item Category"), ToolTip("Item Category")] 
     // [Appearance("fCreateRFQitemcateg", Enabled = true)]
     // [Appearance("fCreateRFQitemcategVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string itemcateg
     { 
       get { return _itemcateg; } 
       set { SetPropertyValue(nameof(itemcateg), ref _itemcateg, value); } 
     } 
     // Default Data for Items
     // Notes for fCreateRFQ : 
     private DateTime _delivedate; 
     [XafDisplayName("Delivery Date"), ToolTip("Delivery Date")] 
     // [Appearance("fCreateRFQdelivedate", Enabled = true)]
     // [Appearance("fCreateRFQdelivedateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime delivedate
     { 
       get { return _delivedate; } 
       set { SetPropertyValue(nameof(delivedate), ref _delivedate, value); } 
     } 
     // Default Data for Items
     // Notes for fCreateRFQ : 
     private string _plant; 
     [XafDisplayName("Plant"), ToolTip("Plant")] 
     // [Appearance("fCreateRFQplant", Enabled = true)]
     // [Appearance("fCreateRFQplantVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string plant
     { 
       get { return _plant; } 
       set { SetPropertyValue(nameof(plant), ref _plant, value); } 
     } 
     // Default Data for Items
     // Notes for fCreateRFQ : 
     private string _storageloc; 
     [XafDisplayName("Storage Location"), ToolTip("Storage Location")] 
     // [Appearance("fCreateRFQstorageloc", Enabled = true)]
     // [Appearance("fCreateRFQstoragelocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string storageloc
     { 
       get { return _storageloc; } 
       set { SetPropertyValue(nameof(storageloc), ref _storageloc, value); } 
     } 
     // Default Data for Items
     // Notes for fCreateRFQ : 
     private string _matlgroup; 
     [XafDisplayName("Material Group"), ToolTip("Material Group")] 
     // [Appearance("fCreateRFQmatlgroup", Enabled = true)]
     // [Appearance("fCreateRFQmatlgroupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string matlgroup
     { 
       get { return _matlgroup; } 
       set { SetPropertyValue(nameof(matlgroup), ref _matlgroup, value); } 
     } 
     // Default Data for Items
     // Notes for fCreateRFQ : 
     private string _reqtracknumb; 
     [XafDisplayName("Req. Tracking Number"), ToolTip("Req. Tracking Number")] 
     // [Appearance("fCreateRFQreqtracknumb", Enabled = true)]
     // [Appearance("fCreateRFQreqtracknumbVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(15)] 
     public  string reqtracknumb
     { 
       get { return _reqtracknumb; } 
       set { SetPropertyValue(nameof(reqtracknumb), ref _reqtracknumb, value); } 
     } 
   } 
} 
