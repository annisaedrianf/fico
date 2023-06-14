// Class Name : fCancelGoodReceipt.cs 
// Project Name : FICO 
// Last Update : 08/06/2023 12:12:36  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 08/06/2023 12:12:32 
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
   [System.ComponentModel.DisplayName("Stock Overview: Basic List")]
   public class fCancelGoodReceipt : XPObject
   {
     public fCancelGoodReceipt(Session session) : base(session) 
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
     [Appearance("VisiblefCancelGoodReceiptOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // Selection
     // Notes for fCancelGoodReceipt : 
     private string _material; 
     [XafDisplayName("Material"), ToolTip("Material")] 
     // [Appearance("fCancelGoodReceiptmaterial", Enabled = true)]
     // [Appearance("fCancelGoodReceiptmaterialVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string material
     { 
       get { return _material; } 
       set { SetPropertyValue(nameof(material), ref _material, value); } 
     } 
     // Selection
     // Notes for fCancelGoodReceipt : 
     private string _mattype; 
     [XafDisplayName("Material Type"), ToolTip("Material Type")] 
     // [Appearance("fCancelGoodReceiptmattype", Enabled = true)]
     // [Appearance("fCancelGoodReceiptmattypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string mattype
     { 
       get { return _mattype; } 
       set { SetPropertyValue(nameof(mattype), ref _mattype, value); } 
     } 
     // Selection
     // Notes for fCancelGoodReceipt : 
     private string _uom; 
     [XafDisplayName("Unit of Measure"), ToolTip("Unit of Measure")] 
     // [Appearance("fCancelGoodReceiptuom", Enabled = true)]
     // [Appearance("fCancelGoodReceiptuomVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string uom
     { 
       get { return _uom; } 
       set { SetPropertyValue(nameof(uom), ref _uom, value); } 
     } 
     // Stock Overview
     // Notes for fCancelGoodReceipt : 
     private double  _unrestrictuse; 
     [XafDisplayName("Unrestricted Use"), ToolTip("Unrestricted use")] 
     // [Appearance("fCancelGoodReceiptunrestrictuse", Enabled = true)]
     // [Appearance("fCancelGoodReceiptunrestrictuseVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double  unrestrictuse
     { 
       get { return _unrestrictuse; } 
       set { SetPropertyValue(nameof(unrestrictuse), ref _unrestrictuse, value); } 
     } 
     // Stock Overview
     // Notes for fCancelGoodReceipt : 
     private double  _qualinspect; 
     [XafDisplayName("Qual. Inspection"), ToolTip("Qual. Inspection")] 
     // [Appearance("fCancelGoodReceiptqualinspect", Enabled = true)]
     // [Appearance("fCancelGoodReceiptqualinspectVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double  qualinspect
     { 
       get { return _qualinspect; } 
       set { SetPropertyValue(nameof(qualinspect), ref _qualinspect, value); } 
     } 
     // Cancellation Material Document
     // Notes for fCancelGoodReceipt : 
     private DateTime _docdate; 
     [XafDisplayName("Document Date"), ToolTip("Document Date")] 
     // [Appearance("fCancelGoodReceiptdocdate", Enabled = true)]
     // [Appearance("fCancelGoodReceiptdocdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime docdate
     { 
       get { return _docdate; } 
       set { SetPropertyValue(nameof(docdate), ref _docdate, value); } 
     } 
     // Cancellation Material Document
     // Notes for fCancelGoodReceipt : 
     private DateTime _postdate; 
     [XafDisplayName("Posting Date"), ToolTip("Posting Date")] 
     // [Appearance("fCancelGoodReceiptpostdate", Enabled = true)]
     // [Appearance("fCancelGoodReceiptpostdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime postdate
     { 
       get { return _postdate; } 
       set { SetPropertyValue(nameof(postdate), ref _postdate, value); } 
     } 
     // Cancellation Material Document
     // Notes for fCancelGoodReceipt : 
     private string _delivenote; 
     [XafDisplayName("Delivery Note"), ToolTip("Delivery Note")] 
     // [Appearance("fCancelGoodReceiptdelivenote", Enabled = true)]
     // [Appearance("fCancelGoodReceiptdelivenoteVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string delivenote
     { 
       get { return _delivenote; } 
       set { SetPropertyValue(nameof(delivenote), ref _delivenote, value); } 
     } 
     // Cancellation Material Document
     // Notes for fCancelGoodReceipt : 
     private string _billlading; 
     [XafDisplayName("Bill of Lading"), ToolTip("Bill of Lading")] 
     // [Appearance("fCancelGoodReceiptbilllading", Enabled = true)]
     // [Appearance("fCancelGoodReceiptbillladingVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string billlading
     { 
       get { return _billlading; } 
       set { SetPropertyValue(nameof(billlading), ref _billlading, value); } 
     } 
     // Cancellation Material Document
     // Notes for fCancelGoodReceipt : 
     private string _headtext; 
     [XafDisplayName("Header Text"), ToolTip("Header Text")] 
     // [Appearance("fCancelGoodReceiptheadtext", Enabled = true)]
     // [Appearance("fCancelGoodReceiptheadtextVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string headtext
     { 
       get { return _headtext; } 
       set { SetPropertyValue(nameof(headtext), ref _headtext, value); } 
     } 
   } 
} 
