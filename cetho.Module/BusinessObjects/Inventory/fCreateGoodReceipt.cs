// Class Name : fCreateGoodReceipt.cs 
// Project Name : FICO 
// Last Update : 07/06/2023 15:10:40  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 07/06/2023 15:10:40 
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
   [System.ComponentModel.DisplayName("Goods Receipt Purchase Order")]
   public class fCreateGoodReceipt : XPObject
   {
     public fCreateGoodReceipt(Session session) : base(session) 
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
     [Appearance("VisiblefCreateGoodReceiptOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // Display Material Document 5000023571
     // Notes for fCreateGoodReceipt : 
     private string _eun; 
     [XafDisplayName("Eun"), ToolTip("Eun")] 
     // [Appearance("fCreateGoodReceipteun", Enabled = true)]
     // [Appearance("fCreateGoodReceipteunVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string eun
     { 
       get { return _eun; } 
       set { SetPropertyValue(nameof(eun), ref _eun, value); } 
     } 
     // Display Material Document 5000023571
     // Notes for fCreateGoodReceipt : 
     private string _itemctgr; 
     [XafDisplayName("Item Category"), ToolTip("Item Category")] 
     // [Appearance("fCreateGoodReceiptitemctgr", Enabled = true)]
     // [Appearance("fCreateGoodReceiptitemctgrVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string itemctgr
     { 
       get { return _itemctgr; } 
       set { SetPropertyValue(nameof(itemctgr), ref _itemctgr, value); } 
     } 
     // Display Material Document 5000023571
     // Notes for fCreateGoodReceipt : 
     private string _material1; 
     [XafDisplayName("Material"), ToolTip("Material (5000023571)")] 
     // [Appearance("fCreateGoodReceiptmaterial1", Enabled = true)]
     // [Appearance("fCreateGoodReceiptmaterial1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string material1
     { 
       get { return _material1; } 
       set { SetPropertyValue(nameof(material1), ref _material1, value); } 
     } 
     // Display Material Document 5000023571
     // Notes for fCreateGoodReceipt : 
     private string _name; 
     [XafDisplayName("Name"), ToolTip("Name")] 
     // [Appearance("fCreateGoodReceiptname", Enabled = true)]
     // [Appearance("fCreateGoodReceiptnameVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string name
     { 
       get { return _name; } 
       set { SetPropertyValue(nameof(name), ref _name, value); } 
     } 
     // Display Material Document 5000023571
     // Notes for fCreateGoodReceipt : 
     private string _plnt; 
     [XafDisplayName("Plant"), ToolTip("Plnt")] 
     // [Appearance("fCreateGoodReceiptplnt", Enabled = true)]
     // [Appearance("fCreateGoodReceiptplntVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string plnt
     { 
       get { return _plnt; } 
       set { SetPropertyValue(nameof(plnt), ref _plnt, value); } 
     } 
     // Display Material Document 5000023571
     // Notes for fCreateGoodReceipt : 
     private string _po; 
     [XafDisplayName("PO"), ToolTip("PO")] 
     // [Appearance("fCreateGoodReceiptpo", Enabled = true)]
     // [Appearance("fCreateGoodReceiptpoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string po
     { 
       get { return _po; } 
       set { SetPropertyValue(nameof(po), ref _po, value); } 
     } 
     // Display Material Document 5000023571
     // Notes for fCreateGoodReceipt : 
     private DateTime _postdate1; 
     [XafDisplayName("Posting Date"), ToolTip("Posting Date (5000023571)")] 
     // [Appearance("fCreateGoodReceiptpostdate1", Enabled = true)]
     // [Appearance("fCreateGoodReceiptpostdate1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime postdate1
     { 
       get { return _postdate1; } 
       set { SetPropertyValue(nameof(postdate1), ref _postdate1, value); } 
     } 
     // Display Material Document 5000023571
     // Notes for fCreateGoodReceipt : 
     private string _qty; 
     [XafDisplayName("Quantity"), ToolTip("Quantity")] 
     // [Appearance("fCreateGoodReceiptqty", Enabled = true)]
     // [Appearance("fCreateGoodReceiptqtyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string qty
     { 
       get { return _qty; } 
       set { SetPropertyValue(nameof(qty), ref _qty, value); } 
     } 
     // Display Material Document 5000023571
     // Notes for fCreateGoodReceipt : 
     private string _sloc2; 
     [XafDisplayName("Sloc"), ToolTip("Sloc (5000023571)")] 
     // [Appearance("fCreateGoodReceiptsloc2", Enabled = true)]
     // [Appearance("fCreateGoodReceiptsloc2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string sloc2
     { 
       get { return _sloc2; } 
       set { SetPropertyValue(nameof(sloc2), ref _sloc2, value); } 
     } 
     // Display Material Document: Initial Screen
     // Notes for fCreateGoodReceipt : 
     private string _matdoc; 
     [XafDisplayName("Material Document"), ToolTip("Material Doc.")] 
     // [Appearance("fCreateGoodReceiptmatdoc", Enabled = true)]
     // [Appearance("fCreateGoodReceiptmatdocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string matdoc
     { 
       get { return _matdoc; } 
       set { SetPropertyValue(nameof(matdoc), ref _matdoc, value); } 
     } 
     // Display Material Document: Initial Screen
     // Notes for fCreateGoodReceipt : 
     private string _matdocyear; 
     [XafDisplayName("Material Document Year"), ToolTip("Mat. Doc. Year")] 
     // [Appearance("fCreateGoodReceiptmatdocyear", Enabled = true)]
     // [Appearance("fCreateGoodReceiptmatdocyearVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string matdocyear
     { 
       get { return _matdocyear; } 
       set { SetPropertyValue(nameof(matdocyear), ref _matdocyear, value); } 
     } 
     // Further Information
     // Notes for fCreateGoodReceipt : 
     private fCompany _compcode; 
     [XafDisplayName("Company Code"), ToolTip("Company Code")] 
     // [Appearance("fCreateGoodReceiptcompcode", Enabled = true)]
     // [Appearance("fCreateGoodReceiptcompcodeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCompany compcode
     { 
       get { return _compcode; } 
       set { SetPropertyValue(nameof(compcode), ref _compcode, value); } 
     } 
     // General
     // Notes for fCreateGoodReceipt : 
     private string _batch; 
     [XafDisplayName("Batch"), ToolTip("Batch")] 
     // [Appearance("fCreateGoodReceiptbatch", Enabled = true)]
     // [Appearance("fCreateGoodReceiptbatchVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string batch
     { 
       get { return _batch; } 
       set { SetPropertyValue(nameof(batch), ref _batch, value); } 
     } 
     // General
     // Notes for fCreateGoodReceipt : 
     private string _billlading; 
     [XafDisplayName("Bill of Lading"), ToolTip("Bill of Lading")] 
     // [Appearance("fCreateGoodReceiptbilllading", Enabled = true)]
     // [Appearance("fCreateGoodReceiptbillladingVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string billlading
     { 
       get { return _billlading; } 
       set { SetPropertyValue(nameof(billlading), ref _billlading, value); } 
     } 
     // General
     // Notes for fCreateGoodReceipt : 
     private string _delivnote; 
     [XafDisplayName("Delivery Note"), ToolTip("Delivery Note")] 
     // [Appearance("fCreateGoodReceiptdelivnote", Enabled = true)]
     // [Appearance("fCreateGoodReceiptdelivnoteVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string delivnote
     { 
       get { return _delivnote; } 
       set { SetPropertyValue(nameof(delivnote), ref _delivnote, value); } 
     } 
     // General
     // Notes for fCreateGoodReceipt : 
     private DateTime _docdate; 
     [XafDisplayName("Document Date"), ToolTip("Document Date")] 
     // [Appearance("fCreateGoodReceiptdocdate", Enabled = true)]
     // [Appearance("fCreateGoodReceiptdocdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime docdate
     { 
       get { return _docdate; } 
       set { SetPropertyValue(nameof(docdate), ref _docdate, value); } 
     } 
     // General
     // Notes for fCreateGoodReceipt : 
     private string _headtext; 
     [XafDisplayName("Header Text"), ToolTip("Header Text")] 
     // [Appearance("fCreateGoodReceiptheadtext", Enabled = true)]
     // [Appearance("fCreateGoodReceiptheadtextVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string headtext
     { 
       get { return _headtext; } 
       set { SetPropertyValue(nameof(headtext), ref _headtext, value); } 
     } 
     // General
     // Notes for fCreateGoodReceipt : 
     private string _line; 
     [XafDisplayName("Line"), ToolTip("Line")] 
     // [Appearance("fCreateGoodReceiptline", Enabled = true)]
     // [Appearance("fCreateGoodReceiptlineVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string line
     { 
       get { return _line; } 
       set { SetPropertyValue(nameof(line), ref _line, value); } 
     } 
     // General
     // Notes for fCreateGoodReceipt : 
     private string _matshorttext; 
     [XafDisplayName("Material Short Text"), ToolTip("Mat. Short Text")] 
     // [Appearance("fCreateGoodReceiptmatshorttext", Enabled = true)]
     // [Appearance("fCreateGoodReceiptmatshorttextVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string matshorttext
     { 
       get { return _matshorttext; } 
       set { SetPropertyValue(nameof(matshorttext), ref _matshorttext, value); } 
     } 
     // General
     // Notes for fCreateGoodReceipt : 
     private DateTime _postdate; 
     [XafDisplayName("Posting Date"), ToolTip("Posting Date")] 
     // [Appearance("fCreateGoodReceiptpostdate", Enabled = true)]
     // [Appearance("fCreateGoodReceiptpostdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime postdate
     { 
       get { return _postdate; } 
       set { SetPropertyValue(nameof(postdate), ref _postdate, value); } 
     } 
     // General
     // Notes for fCreateGoodReceipt : 
     private string _qtyune; 
     [XafDisplayName("Qty in UNE"), ToolTip("Qty inUNE")] 
     // [Appearance("fCreateGoodReceiptqtyune", Enabled = true)]
     // [Appearance("fCreateGoodReceiptqtyuneVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string qtyune
     { 
       get { return _qtyune; } 
       set { SetPropertyValue(nameof(qtyune), ref _qtyune, value); } 
     } 
     // General
     // Notes for fCreateGoodReceipt : 
     private string _sloc; 
     [XafDisplayName("Sloc"), ToolTip("Sloc")] 
     // [Appearance("fCreateGoodReceiptsloc", Enabled = true)]
     // [Appearance("fCreateGoodReceiptslocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string sloc
     { 
       get { return _sloc; } 
       set { SetPropertyValue(nameof(sloc), ref _sloc, value); } 
     } 
     // Material
     // Notes for fCreateGoodReceipt : 
     private string _eancheck; 
     [XafDisplayName("EAN Check"), ToolTip("EAN Check")] 
     // [Appearance("fCreateGoodReceipteancheck", Enabled = true)]
     // [Appearance("fCreateGoodReceipteancheckVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(35)] 
     public  string eancheck
     { 
       get { return _eancheck; } 
       set { SetPropertyValue(nameof(eancheck), ref _eancheck, value); } 
     } 
     // Material
     // Notes for fCreateGoodReceipt : 
     private string _eanorderunit; 
     [XafDisplayName("EAN in Order Unit"), ToolTip("EAN in Order Unit")] 
     // [Appearance("fCreateGoodReceipteanorderunit", Enabled = true)]
     // [Appearance("fCreateGoodReceipteanorderunitVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string eanorderunit
     { 
       get { return _eanorderunit; } 
       set { SetPropertyValue(nameof(eanorderunit), ref _eanorderunit, value); } 
     } 
     // Material
     // Notes for fCreateGoodReceipt : 
     private string _material; 
     [XafDisplayName("Material"), ToolTip("Material")] 
     // [Appearance("fCreateGoodReceiptmaterial", Enabled = true)]
     // [Appearance("fCreateGoodReceiptmaterialVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(200)] 
     public  string material
     { 
       get { return _material; } 
       set { SetPropertyValue(nameof(material), ref _material, value); } 
     } 
     // Material
     // Notes for fCreateGoodReceipt : 
     private string _materialgrp; 
     [XafDisplayName("Material Group"), ToolTip("Material Group")] 
     // [Appearance("fCreateGoodReceiptmaterialgrp", Enabled = true)]
     // [Appearance("fCreateGoodReceiptmaterialgrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string materialgrp
     { 
       get { return _materialgrp; } 
       set { SetPropertyValue(nameof(materialgrp), ref _materialgrp, value); } 
     } 
     // Material
     // Notes for fCreateGoodReceipt : 
     private fVendor _vendormaterialno; 
     [XafDisplayName("Vendor Material No"), ToolTip("Vendor Material No.")] 
     // [Appearance("fCreateGoodReceiptvendormaterialno", Enabled = true)]
     // [Appearance("fCreateGoodReceiptvendormaterialnoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fVendor vendormaterialno
     { 
       get { return _vendormaterialno; } 
       set { SetPropertyValue(nameof(vendormaterialno), ref _vendormaterialno, value); } 
     } 
     // Purchase Order Data
     // Notes for fCreateGoodReceipt : 
     private enumDelCompl _delcomplind; 
     [XafDisplayName("Del.Completed Ind."), ToolTip("Del.Completed Ind.")] 
     // [Appearance("fCreateGoodReceiptdelcomplind", Enabled = true)]
     // [Appearance("fCreateGoodReceiptdelcomplindVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumDelCompl delcomplind
     { 
       get { return _delcomplind; } 
       set { SetPropertyValue(nameof(delcomplind), ref _delcomplind, value); } 
     } 
     // Purchase Order Data
     // Notes for fCreateGoodReceipt : 
     private bool _delcomplindpoitem; 
     [XafDisplayName("Del. Compl. Ind. PO Item"), ToolTip("Del. Compl. Ind. PO Item")] 
     // [Appearance("fCreateGoodReceiptdelcomplindpoitem", Enabled = true)]
     // [Appearance("fCreateGoodReceiptdelcomplindpoitemVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool delcomplindpoitem
     { 
       get { return _delcomplindpoitem; } 
       set { SetPropertyValue(nameof(delcomplindpoitem), ref _delcomplindpoitem, value); } 
     } 
     // Purchase Order Data
     // Notes for fCreateGoodReceipt : 
     private string _itemctgr1; 
     [XafDisplayName("Item Category"), ToolTip("Item Category (Purch)")] 
     // [Appearance("fCreateGoodReceiptitemctgr1", Enabled = true)]
     // [Appearance("fCreateGoodReceiptitemctgr1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string itemctgr1
     { 
       get { return _itemctgr1; } 
       set { SetPropertyValue(nameof(itemctgr1), ref _itemctgr1, value); } 
     } 
     // Purchase Order Data
     // Notes for fCreateGoodReceipt : 
     private string _purchorder; 
     [XafDisplayName("Purchase Order"), ToolTip("Purchase Order")] 
     // [Appearance("fCreateGoodReceiptpurchorder", Enabled = true)]
     // [Appearance("fCreateGoodReceiptpurchorderVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string purchorder
     { 
       get { return _purchorder; } 
       set { SetPropertyValue(nameof(purchorder), ref _purchorder, value); } 
     } 
     // Quantity
     // Notes for fCreateGoodReceipt : 
     private string _nocontainers; 
     [XafDisplayName("No. Containers"), ToolTip("No. Containers")] 
     // [Appearance("fCreateGoodReceiptnocontainers", Enabled = true)]
     // [Appearance("fCreateGoodReceiptnocontainersVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(15)] 
     public  string nocontainers
     { 
       get { return _nocontainers; } 
       set { SetPropertyValue(nameof(nocontainers), ref _nocontainers, value); } 
     } 
     // Quantity
     // Notes for fCreateGoodReceipt : 
     private string _qtydelivnote; 
     [XafDisplayName("Qty in Delivery Note"), ToolTip("Qty in Delivery Note")] 
     // [Appearance("fCreateGoodReceiptqtydelivnote", Enabled = true)]
     // [Appearance("fCreateGoodReceiptqtydelivnoteVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string qtydelivnote
     { 
       get { return _qtydelivnote; } 
       set { SetPropertyValue(nameof(qtydelivnote), ref _qtydelivnote, value); } 
     } 
     // Quantity
     // Notes for fCreateGoodReceipt : 
     private string _qtyordered; 
     [XafDisplayName("Quantity Ordered"), ToolTip("Quantity Ordered")] 
     // [Appearance("fCreateGoodReceiptqtyordered", Enabled = true)]
     // [Appearance("fCreateGoodReceiptqtyorderedVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string qtyordered
     { 
       get { return _qtyordered; } 
       set { SetPropertyValue(nameof(qtyordered), ref _qtyordered, value); } 
     } 
     // Quantity
     // Notes for fCreateGoodReceipt : 
     private string _qtysku; 
     [XafDisplayName("Qty in SKU"), ToolTip("Qty in SKU")] 
     // [Appearance("fCreateGoodReceiptqtysku", Enabled = true)]
     // [Appearance("fCreateGoodReceiptqtyskuVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string qtysku
     { 
       get { return _qtysku; } 
       set { SetPropertyValue(nameof(qtysku), ref _qtysku, value); } 
     } 
     // Quantity
     // Notes for fCreateGoodReceipt : 
     private string _qtyune2; 
     [XafDisplayName("Qty in UNE"), ToolTip("Qty in Unit of Entry")] 
     // [Appearance("fCreateGoodReceiptqtyune", Enabled = true)]
     // [Appearance("fCreateGoodReceiptqtyuneVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string qtyune2
     { 
       get { return _qtyune2; } 
       set { SetPropertyValue(nameof(qtyune2), ref _qtyune2, value); } 
     } 
     // Quantity in
     // Notes for fCreateGoodReceipt : 
     private bool _delivcompl; 
     [XafDisplayName("Deliv. Compl."), ToolTip("Deliv. Compl.")] 
     // [Appearance("fCreateGoodReceiptdelivcompl", Enabled = true)]
     // [Appearance("fCreateGoodReceiptdelivcomplVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool delivcompl
     { 
       get { return _delivcompl; } 
       set { SetPropertyValue(nameof(delivcompl), ref _delivcompl, value); } 
     } 
     // Quantity in
     // Notes for fCreateGoodReceipt : 
     private string _stocktype1; 
     [XafDisplayName("Stock Type"), ToolTip("Stock type (Qty)")] 
     // [Appearance("fCreateGoodReceiptstocktype1", Enabled = true)]
     // [Appearance("fCreateGoodReceiptstocktype1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string stocktype1
     { 
       get { return _stocktype1; } 
       set { SetPropertyValue(nameof(stocktype1), ref _stocktype1, value); } 
     } 
     // Quantity in
     // Notes for fCreateGoodReceipt : 
     private string _stockunit; 
     [XafDisplayName("Stockkeepg Unit"), ToolTip("Stockkeepg Unit")] 
     // [Appearance("fCreateGoodReceiptstockunit", Enabled = true)]
     // [Appearance("fCreateGoodReceiptstockunitVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string stockunit
     { 
       get { return _stockunit; } 
       set { SetPropertyValue(nameof(stockunit), ref _stockunit, value); } 
     } 
     // Quantity in
     // Notes for fCreateGoodReceipt : 
     private string _stroloc; 
     [XafDisplayName("Stor. Location"), ToolTip("Stor. Location")] 
     // [Appearance("fCreateGoodReceiptstroloc", Enabled = true)]
     // [Appearance("fCreateGoodReceiptstrolocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string stroloc
     { 
       get { return _stroloc; } 
       set { SetPropertyValue(nameof(stroloc), ref _stroloc, value); } 
     } 
     // Quantity in
     // Notes for fCreateGoodReceipt : 
     private string _uoe; 
     [XafDisplayName("Unit of Entry"), ToolTip("Unit of Entry")] 
     // [Appearance("fCreateGoodReceiptuoe", Enabled = true)]
     // [Appearance("fCreateGoodReceiptuoeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string uoe
     { 
       get { return _uoe; } 
       set { SetPropertyValue(nameof(uoe), ref _uoe, value); } 
     } 
     // Vendor
     // Notes for fCreateGoodReceipt : 
     private string _line1; 
     [XafDisplayName("Line"), ToolTip("Line (V)")] 
     // [Appearance("fCreateGoodReceiptline1", Enabled = true)]
     // [Appearance("fCreateGoodReceiptline1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string line1
     { 
       get { return _line1; } 
       set { SetPropertyValue(nameof(line1), ref _line1, value); } 
     } 
     // Vendor
     // Notes for fCreateGoodReceipt : 
     private string _matshorttext1; 
     [XafDisplayName("Mat. Short Text"), ToolTip("Mat. Short Text (V)")] 
     // [Appearance("fCreateGoodReceiptmatshorttext1", Enabled = true)]
     // [Appearance("fCreateGoodReceiptmatshorttext1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string matshorttext1
     { 
       get { return _matshorttext1; } 
       set { SetPropertyValue(nameof(matshorttext1), ref _matshorttext1, value); } 
     } 
     // Vendor
     // Notes for fCreateGoodReceipt : 
     //private fProfitCenter _profitcenter; 
     //[XafDisplayName("Profit Center"), ToolTip("Profit Center")] 
     // [Appearance("fCreateGoodReceiptprofitcenter", Enabled = true)]
     // [Appearance("fCreateGoodReceiptprofitcenterVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     //public  fProfitCenter profitcenter
     //{ 
     //  get { return _profitcenter; } 
     //  set { SetPropertyValue(nameof(profitcenter), ref _profitcenter, value); } 
     //} 
     // Vendor
     // Notes for fCreateGoodReceipt : 
     private string _qtyune1; 
     [XafDisplayName("Qty in UNE "), ToolTip("Qty inUNE (V)")] 
     // [Appearance("fCreateGoodReceiptqtyune1", Enabled = true)]
     // [Appearance("fCreateGoodReceiptqtyune1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string qtyune1
     { 
       get { return _qtyune1; } 
       set { SetPropertyValue(nameof(qtyune1), ref _qtyune1, value); } 
     } 
     // Vendor
     // Notes for fCreateGoodReceipt : 
     private string _sloc1; 
     [XafDisplayName("Sloc"), ToolTip("Sloc (V)")] 
     // [Appearance("fCreateGoodReceiptsloc1", Enabled = true)]
     // [Appearance("fCreateGoodReceiptsloc1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string sloc1
     { 
       get { return _sloc1; } 
       set { SetPropertyValue(nameof(sloc1), ref _sloc1, value); } 
     } 
     // Vendor
     // Notes for fCreateGoodReceipt : 
     private fVendor _vendor; 
     [XafDisplayName("Vendor"), ToolTip("Vendor")] 
     // [Appearance("fCreateGoodReceiptvendor", Enabled = true)]
     // [Appearance("fCreateGoodReceiptvendorVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fVendor vendor
     { 
       get { return _vendor; } 
       set { SetPropertyValue(nameof(vendor), ref _vendor, value); } 
     } 
     // Where
     // Notes for fCreateGoodReceipt : 
     private string _goodsrecipt; 
     [XafDisplayName("Goods Recipient"), ToolTip("Goods recipient")] 
     // [Appearance("fCreateGoodReceiptgoodsrecipt", Enabled = true)]
     // [Appearance("fCreateGoodReceiptgoodsreciptVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string goodsrecipt
     { 
       get { return _goodsrecipt; } 
       set { SetPropertyValue(nameof(goodsrecipt), ref _goodsrecipt, value); } 
     } 
     // Where
     // Notes for fCreateGoodReceipt : 
     private string _movetype; 
     [XafDisplayName("Movement Type"), ToolTip("Movement Type")] 
     // [Appearance("fCreateGoodReceiptmovetype", Enabled = true)]
     // [Appearance("fCreateGoodReceiptmovetypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string movetype
     { 
       get { return _movetype; } 
       set { SetPropertyValue(nameof(movetype), ref _movetype, value); } 
     } 
     // Where
     // Notes for fCreateGoodReceipt : 
     private string _plant; 
     [XafDisplayName("Plant"), ToolTip("Plant")] 
     // [Appearance("fCreateGoodReceiptplant", Enabled = true)]
     // [Appearance("fCreateGoodReceiptplantVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string plant
     { 
       get { return _plant; } 
       set { SetPropertyValue(nameof(plant), ref _plant, value); } 
     } 
     // Where
     // Notes for fCreateGoodReceipt : 
     private enumStockType _stocktype; 
     [XafDisplayName("Stock Type"), ToolTip("Stock type")] 
     // [Appearance("fCreateGoodReceiptstocktype", Enabled = true)]
     // [Appearance("fCreateGoodReceiptstocktypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumStockType stocktype
     { 
       get { return _stocktype; } 
       set { SetPropertyValue(nameof(stocktype), ref _stocktype, value); } 
     } 
     // Where
     // Notes for fCreateGoodReceipt : 
     private string _storageloc; 
     [XafDisplayName("Storage Location"), ToolTip("Storage Location")] 
     // [Appearance("fCreateGoodReceiptstorageloc", Enabled = true)]
     // [Appearance("fCreateGoodReceiptstoragelocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string storageloc
     { 
       get { return _storageloc; } 
       set { SetPropertyValue(nameof(storageloc), ref _storageloc, value); } 
     } 
     // Where
     // Notes for fCreateGoodReceipt : 
     private string _unloadpoint; 
     [XafDisplayName("Unloading Point"), ToolTip("Unloading Point")] 
     // [Appearance("fCreateGoodReceiptunloadpoint", Enabled = true)]
     // [Appearance("fCreateGoodReceiptunloadpointVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string unloadpoint
     { 
       get { return _unloadpoint; } 
       set { SetPropertyValue(nameof(unloadpoint), ref _unloadpoint, value); } 
     } 
   } 
} 
