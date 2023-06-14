// Class Name : fTransferPosting.cs 
// Project Name : FICO 
// Last Update : 08/06/2023 12:55:46  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 08/06/2023 12:55:46 
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
   [System.ComponentModel.DisplayName("Enter Transfer Posting: Initial Screen")]
   public class fTransferPosting : XPObject
   {
     public fTransferPosting(Session session) : base(session) 
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
     [Appearance("VisiblefTransferPostingOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for fTransferPosting : 
     private DateTime _docdate; 
     [XafDisplayName("Document Date"), ToolTip("Document Date")] 
     // [Appearance("fTransferPostingdocdate", Enabled = true)]
     // [Appearance("fTransferPostingdocdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime docdate
     { 
       get { return _docdate; } 
       set { SetPropertyValue(nameof(docdate), ref _docdate, value); } 
     } 
     // 
     // Notes for fTransferPosting : 
     private string _matslip; 
     [XafDisplayName("Material Slip"), ToolTip("Material Slip")] 
     // [Appearance("fTransferPostingmatslip", Enabled = true)]
     // [Appearance("fTransferPostingmatslipVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string matslip
     { 
       get { return _matslip; } 
       set { SetPropertyValue(nameof(matslip), ref _matslip, value); } 
     } 
     // 
     // Notes for fTransferPosting : 
     private string _docheadtext; 
     [XafDisplayName("Doc. Header Text"), ToolTip("Doc. Header Text")] 
     // [Appearance("fTransferPostingdocheadtext", Enabled = true)]
     // [Appearance("fTransferPostingdocheadtextVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string docheadtext
     { 
       get { return _docheadtext; } 
       set { SetPropertyValue(nameof(docheadtext), ref _docheadtext, value); } 
     } 
     // 
     // Notes for fTransferPosting : 
     private DateTime _postdate; 
     [XafDisplayName("Posting Date"), ToolTip("Posting Date")] 
     // [Appearance("fTransferPostingpostdate", Enabled = true)]
     // [Appearance("fTransferPostingpostdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime postdate
     { 
       get { return _postdate; } 
       set { SetPropertyValue(nameof(postdate), ref _postdate, value); } 
     } 
     // Defaults for Document Items
     // Notes for fTransferPosting : 
     private string _movetype; 
     [XafDisplayName("Movement Type"), ToolTip("Movement Type")] 
     // [Appearance("fTransferPostingmovetype", Enabled = true)]
     // [Appearance("fTransferPostingmovetypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string movetype
     { 
       get { return _movetype; } 
       set { SetPropertyValue(nameof(movetype), ref _movetype, value); } 
     } 
     // Defaults for Document Items
     // Notes for fTransferPosting : 
     private string _plant; 
     [XafDisplayName("Plant"), ToolTip("Plant")] 
     // [Appearance("fTransferPostingplant", Enabled = true)]
     // [Appearance("fTransferPostingplantVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string plant
     { 
       get { return _plant; } 
       set { SetPropertyValue(nameof(plant), ref _plant, value); } 
     } 
     // Defaults for Document Items
     // Notes for fTransferPosting : 
     private string _storloc; 
     [XafDisplayName("Storage Location"), ToolTip("Storage Location")] 
     // [Appearance("fTransferPostingstorloc", Enabled = true)]
     // [Appearance("fTransferPostingstorlocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string storloc
     { 
       get { return _storloc; } 
       set { SetPropertyValue(nameof(storloc), ref _storloc, value); } 
     } 
     // Defaults for Document Items
     // Notes for fTransferPosting : 
     private string _spclstck; 
     [XafDisplayName("Special Stock"), ToolTip("Special Stock")] 
     // [Appearance("fTransferPostingspclstck", Enabled = true)]
     // [Appearance("fTransferPostingspclstckVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string spclstck
     { 
       get { return _spclstck; } 
       set { SetPropertyValue(nameof(spclstck), ref _spclstck, value); } 
     } 
     // Defaults for Document Items
     // Notes for fTransferPosting : 
     private string _reasonformove; 
     [XafDisplayName("Reason for Movement"), ToolTip("Reason for Movement")] 
     // [Appearance("fTransferPostingreasonformove", Enabled = true)]
     // [Appearance("fTransferPostingreasonformoveVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string reasonformove
     { 
       get { return _reasonformove; } 
       set { SetPropertyValue(nameof(reasonformove), ref _reasonformove, value); } 
     } 
     // Defaults for Document Items
     // Notes for fTransferPosting : 
     private bool _suggzerolines; 
     [XafDisplayName("Suggest Zero Lines"), ToolTip("Suggest Zero Lines")] 
     // [Appearance("fTransferPostingsuggzerolines", Enabled = true)]
     // [Appearance("fTransferPostingsuggzerolinesVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool suggzerolines
     { 
       get { return _suggzerolines; } 
       set { SetPropertyValue(nameof(suggzerolines), ref _suggzerolines, value); } 
     } 
     // Enter Transfer Posting: New Items
     // Notes for fTransferPosting : 
     private string _movetype1; 
     [XafDisplayName("Movement Type"), ToolTip("Movement Type")] 
     // [Appearance("fTransferPostingmovetype", Enabled = true)]
     // [Appearance("fTransferPostingmovetypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string movetype1
     { 
       get { return _movetype1; } 
       set { SetPropertyValue(nameof(movetype1), ref _movetype1, value); } 
     } 
     // Enter Transfer Posting: New Items
     // Notes for fTransferPosting : 
     private string _recipt; 
     [XafDisplayName("Recipient"), ToolTip("Recipient")] 
     // [Appearance("fTransferPostingrecipt", Enabled = true)]
     // [Appearance("fTransferPostingreciptVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string recipt
     { 
       get { return _recipt; } 
       set { SetPropertyValue(nameof(recipt), ref _recipt, value); } 
     } 
     // Items
     // Notes for fTransferPosting : 
     private string _itm; 
     [XafDisplayName("Item"), ToolTip("Item")] 
     // [Appearance("fTransferPostingitm", Enabled = true)]
     // [Appearance("fTransferPostingitmVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string itm
     { 
       get { return _itm; } 
       set { SetPropertyValue(nameof(itm), ref _itm, value); } 
     } 
     // Items
     // Notes for fTransferPosting : 
     private string _mat; 
     [XafDisplayName("Material"), ToolTip("Material")] 
     // [Appearance("fTransferPostingmat", Enabled = true)]
     // [Appearance("fTransferPostingmatVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string mat
     { 
       get { return _mat; } 
       set { SetPropertyValue(nameof(mat), ref _mat, value); } 
     } 
     // Items
     // Notes for fTransferPosting : 
     private string _qty; 
     [XafDisplayName("Quantity"), ToolTip("Quantity")] 
     // [Appearance("fTransferPostingqty", Enabled = true)]
     // [Appearance("fTransferPostingqtyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string qty
     { 
       get { return _qty; } 
       set { SetPropertyValue(nameof(qty), ref _qty, value); } 
     } 
     // Items
     // Notes for fTransferPosting : 
     private string _une; 
     [XafDisplayName("UnE"), ToolTip("UnE")] 
     // [Appearance("fTransferPostingune", Enabled = true)]
     // [Appearance("fTransferPostinguneVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string une
     { 
       get { return _une; } 
       set { SetPropertyValue(nameof(une), ref _une, value); } 
     } 
     // Items
     // Notes for fTransferPosting : 
     private string _sloc; 
     [XafDisplayName("Sloc"), ToolTip("Sloc")] 
     // [Appearance("fTransferPostingsloc", Enabled = true)]
     // [Appearance("fTransferPostingslocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string sloc
     { 
       get { return _sloc; } 
       set { SetPropertyValue(nameof(sloc), ref _sloc, value); } 
     } 
     // Items
     // Notes for fTransferPosting : 
     private string _batch; 
     [XafDisplayName("Batch"), ToolTip("Batch")] 
     // [Appearance("fTransferPostingbatch", Enabled = true)]
     // [Appearance("fTransferPostingbatchVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string batch
     { 
       get { return _batch; } 
       set { SetPropertyValue(nameof(batch), ref _batch, value); } 
     } 
     // Items
     // Notes for fTransferPosting : 
     private string _plant1; 
     [XafDisplayName("Plant"), ToolTip("Plant (Itm)")] 
     // [Appearance("fTransferPostingplant1", Enabled = true)]
     // [Appearance("fTransferPostingplant1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string plant1
     { 
       get { return _plant1; } 
       set { SetPropertyValue(nameof(plant1), ref _plant1, value); } 
     } 
   } 
} 
