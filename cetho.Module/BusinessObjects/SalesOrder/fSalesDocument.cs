// Class Name : fSalesDocument.cs 
// Project Name : FICO 
// Last Update : 06/06/2023 13:10:02  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 06/06/2023 13:10:02 
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
   [System.ComponentModel.DisplayName("All about Sales Document (Header/Item/Schedule)")]
   public class fSalesDocument : XPObject
   {
     public fSalesDocument(Session session) : base(session) 
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
     [Appearance("VisiblefSalesDocumentOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for fSalesDocument : 
     private string _inqtype; 
     [XafDisplayName("Inquiry Type"), ToolTip("Inquiry Type")] 
     // [Appearance("fSalesDocumentinqtype", Enabled = true)]
     // [Appearance("fSalesDocumentinqtypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string inqtype
     { 
       get { return _inqtype; } 
       set { SetPropertyValue(nameof(inqtype), ref _inqtype, value); } 
     } 
     // Change Inquiry 10000023: Header Data
     // Notes for fSalesDocument : 
     private string _inqtype2; 
     [XafDisplayName("Inquiry Type (Header)"), ToolTip("Inquiry Type (Header)")] 
     // [Appearance("fSalesDocumentinqtype2", Enabled = true)]
     // [Appearance("fSalesDocumentinqtype2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string inqtype2
     { 
       get { return _inqtype2; } 
       set { SetPropertyValue(nameof(inqtype2), ref _inqtype2, value); } 
     } 
     // Change Inquiry 10000023: Header Data
     // Notes for fSalesDocument : 
     private string _purchorderno; 
     [XafDisplayName("Purchase Order No."), ToolTip("Purchase order no.")] 
     // [Appearance("fSalesDocumentpurchorderno", Enabled = true)]
     // [Appearance("fSalesDocumentpurchordernoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string purchorderno
     { 
       get { return _purchorderno; } 
       set { SetPropertyValue(nameof(purchorderno), ref _purchorderno, value); } 
     } 
     // Change Inquiry 10000023: Header Data
     // Notes for fSalesDocument : 
     private string _soldparty; 
     [XafDisplayName("Sold-To Party"), ToolTip("Sold-to party")] 
     // [Appearance("fSalesDocumentsoldparty", Enabled = true)]
     // [Appearance("fSalesDocumentsoldpartyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string soldparty
     { 
       get { return _soldparty; } 
       set { SetPropertyValue(nameof(soldparty), ref _soldparty, value); } 
     } 
     // Change Inquiry 10000023: Item Data
     // Notes for fSalesDocument : 
     private string _itemctg; 
     [XafDisplayName("Item Category"), ToolTip("Item category")] 
     // [Appearance("fSalesDocumentitemctg", Enabled = true)]
     // [Appearance("fSalesDocumentitemctgVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string itemctg
     { 
       get { return _itemctg; } 
       set { SetPropertyValue(nameof(itemctg), ref _itemctg, value); } 
     } 
     // Change Inquiry 10000023: Item Data
     // Notes for fSalesDocument : 
     private string _matl; 
     [XafDisplayName("Material"), ToolTip("Material")] 
     // [Appearance("fSalesDocumentmatl", Enabled = true)]
     // [Appearance("fSalesDocumentmatlVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string matl
     { 
       get { return _matl; } 
       set { SetPropertyValue(nameof(matl), ref _matl, value); } 
     } 
     // Change Inquiry 10000023: Item Data
     // Notes for fSalesDocument : 
     private string _salesdocitem; 
     [XafDisplayName("Sales Document Item"), ToolTip("Sales Document Item")] 
     // [Appearance("fSalesDocumentsalesdocitem", Enabled = true)]
     // [Appearance("fSalesDocumentsalesdocitemVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string salesdocitem
     { 
       get { return _salesdocitem; } 
       set { SetPropertyValue(nameof(salesdocitem), ref _salesdocitem, value); } 
     } 
     // Organizational Data
     // Notes for fSalesDocument : 
     private string _distrchnl; 
     [XafDisplayName("Distribution Channel"), ToolTip("Distribution Channel")] 
     // [Appearance("fSalesDocumentdistrchnl", Enabled = true)]
     // [Appearance("fSalesDocumentdistrchnlVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string distrchnl
     { 
       get { return _distrchnl; } 
       set { SetPropertyValue(nameof(distrchnl), ref _distrchnl, value); } 
     } 
     // Organizational Data
     // Notes for fSalesDocument : 
     private string _division; 
     [XafDisplayName("Division"), ToolTip("Division")] 
     // [Appearance("fSalesDocumentdivision", Enabled = true)]
     // [Appearance("fSalesDocumentdivisionVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string division
     { 
       get { return _division; } 
       set { SetPropertyValue(nameof(division), ref _division, value); } 
     } 
     // Organizational Data
     // Notes for fSalesDocument : 
     private string _salesgroup; 
     [XafDisplayName("Sales Group"), ToolTip("Sales Group")] 
     // [Appearance("fSalesDocumentsalesgroup", Enabled = true)]
     // [Appearance("fSalesDocumentsalesgroupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string salesgroup
     { 
       get { return _salesgroup; } 
       set { SetPropertyValue(nameof(salesgroup), ref _salesgroup, value); } 
     } 
     // Organizational Data
     // Notes for fSalesDocument : 
     private string _salesoffice; 
     [XafDisplayName("Sales Office"), ToolTip("Sales Office")] 
     // [Appearance("fSalesDocumentsalesoffice", Enabled = true)]
     // [Appearance("fSalesDocumentsalesofficeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string salesoffice
     { 
       get { return _salesoffice; } 
       set { SetPropertyValue(nameof(salesoffice), ref _salesoffice, value); } 
     } 
     // Organizational Data
     // Notes for fSalesDocument : 
     private string _salesorgnz; 
     [XafDisplayName("Sales Organization"), ToolTip("Sales Organization")] 
     // [Appearance("fSalesDocumentsalesorgnz", Enabled = true)]
     // [Appearance("fSalesDocumentsalesorgnzVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string salesorgnz
     { 
       get { return _salesorgnz; } 
       set { SetPropertyValue(nameof(salesorgnz), ref _salesorgnz, value); } 
     } 
     // Sales
     // Notes for fSalesDocument : 
     private DateTime _createby; 
     [XafDisplayName("Created by"), ToolTip("Created by")] 
     // [Appearance("fSalesDocumentcreateby", Enabled = true)]
     // [Appearance("fSalesDocumentcreatebyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime createby
     { 
       get { return _createby; } 
       set { SetPropertyValue(nameof(createby), ref _createby, value); } 
     } 
     // Sales
     // Notes for fSalesDocument : 
     private DateTime _createon; 
     [XafDisplayName("Created on"), ToolTip("Created on")] 
     // [Appearance("fSalesDocumentcreateon", Enabled = true)]
     // [Appearance("fSalesDocumentcreateonVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime createon
     { 
       get { return _createon; } 
       set { SetPropertyValue(nameof(createon), ref _createon, value); } 
     } 
     // Sales
     // Notes for fSalesDocument : 
     private enumCustGrp _custgrp; 
     [XafDisplayName("Customer group "), ToolTip("Customer group ")] 
     // [Appearance("fSalesDocumentcustgrp", Enabled = true)]
     // [Appearance("fSalesDocumentcustgrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumCustGrp custgrp
     { 
       get { return _custgrp; } 
       set { SetPropertyValue(nameof(custgrp), ref _custgrp, value); } 
     } 
     // Sales
     // Notes for fSalesDocument : 
     private double _doccurr; 
     [XafDisplayName("Doc. Currency"), ToolTip("Doc. Currency")] 
     // [Appearance("fSalesDocumentdoccurr", Enabled = true)]
     // [Appearance("fSalesDocumentdoccurrVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double doccurr
     { 
       get { return _doccurr; } 
       set { SetPropertyValue(nameof(doccurr), ref _doccurr, value); } 
     } 
     // Sales
     // Notes for fSalesDocument : 
     private DateTime _docdate; 
     [XafDisplayName("Document Date"), ToolTip("Document date")] 
     // [Appearance("fSalesDocumentdocdate", Enabled = true)]
     // [Appearance("fSalesDocumentdocdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime docdate
     { 
       get { return _docdate; } 
       set { SetPropertyValue(nameof(docdate), ref _docdate, value); } 
     } 
     // Sales
     // Notes for fSalesDocument : 
     private string _guarantee; 
     [XafDisplayName("Guarantee"), ToolTip("Guarantee")] 
     // [Appearance("fSalesDocumentguarantee", Enabled = true)]
     // [Appearance("fSalesDocumentguaranteeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string guarantee
     { 
       get { return _guarantee; } 
       set { SetPropertyValue(nameof(guarantee), ref _guarantee, value); } 
     } 
     // Sales
     // Notes for fSalesDocument : 
     private string _inqtype1; 
     [XafDisplayName("Inquiry Type (Sales)"), ToolTip("Inquiry Type (Sales)")] 
     // [Appearance("fSalesDocumentinqtype1", Enabled = true)]
     // [Appearance("fSalesDocumentinqtype1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string inqtype1
     { 
       get { return _inqtype1; } 
       set { SetPropertyValue(nameof(inqtype1), ref _inqtype1, value); } 
     } 
     // Sales
     // Notes for fSalesDocument : 
     private DateTime _inqvldfrm; 
     [XafDisplayName("Inquiry Valid From"), ToolTip("Inquiry Valid From")] 
     // [Appearance("fSalesDocumentinqvldfrm", Enabled = true)]
     // [Appearance("fSalesDocumentinqvldfrmVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime inqvldfrm
     { 
       get { return _inqvldfrm; } 
       set { SetPropertyValue(nameof(inqvldfrm), ref _inqvldfrm, value); } 
     } 
     // Sales
     // Notes for fSalesDocument : 
     private DateTime _inqvlduntil; 
     [XafDisplayName("Inquiry Valid Until"), ToolTip("Inquiry Valid Until")] 
     // [Appearance("fSalesDocumentinqvlduntil", Enabled = true)]
     // [Appearance("fSalesDocumentinqvlduntilVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime inqvlduntil
     { 
       get { return _inqvlduntil; } 
       set { SetPropertyValue(nameof(inqvlduntil), ref _inqvlduntil, value); } 
     } 
     // Sales
     // Notes for fSalesDocument : 
     private enumOrderReason _orderreason; 
     [XafDisplayName("Order Reason"), ToolTip("Order reason")] 
     // [Appearance("fSalesDocumentorderreason", Enabled = true)]
     // [Appearance("fSalesDocumentorderreasonVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumOrderReason orderreason
     { 
       get { return _orderreason; } 
       set { SetPropertyValue(nameof(orderreason), ref _orderreason, value); } 
     } 
     // Sales
     // Notes for fSalesDocument : 
     private enumPricDate _pricedate1; 
     [XafDisplayName("Pricing Date (Sales)"), ToolTip("Pricing date (Sales)")] 
     // [Appearance("fSalesDocumentpricedate1", Enabled = true)]
     // [Appearance("fSalesDocumentpricedate1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumPricDate pricedate1
     { 
       get { return _pricedate1; } 
       set { SetPropertyValue(nameof(pricedate1), ref _pricedate1, value); } 
     } 
     // Sales
     // Notes for fSalesDocument : 
     private enumPriceGrp _pricegrp; 
     [XafDisplayName("Price Group"), ToolTip("Price Group")] 
     // [Appearance("fSalesDocumentpricegrp", Enabled = true)]
     // [Appearance("fSalesDocumentpricegrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumPriceGrp pricegrp
     { 
       get { return _pricegrp; } 
       set { SetPropertyValue(nameof(pricegrp), ref _pricegrp, value); } 
     } 
     // Sales
     // Notes for fSalesDocument : 
     private enumPriceList _pricelist; 
     [XafDisplayName("Price List"), ToolTip("Price List")] 
     // [Appearance("fSalesDocumentpricelist", Enabled = true)]
     // [Appearance("fSalesDocumentpricelistVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumPriceList pricelist
     { 
       get { return _pricelist; } 
       set { SetPropertyValue(nameof(pricelist), ref _pricelist, value); } 
     } 
     // Sales
     // Notes for fSalesDocument : 
     private string _pricproc; 
     [XafDisplayName("Pric. Procedure"), ToolTip("Pric. Procedure")] 
     // [Appearance("fSalesDocumentpricproc", Enabled = true)]
     // [Appearance("fSalesDocumentpricprocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string pricproc
     { 
       get { return _pricproc; } 
       set { SetPropertyValue(nameof(pricproc), ref _pricproc, value); } 
     } 
     // Sales
     // Notes for fSalesDocument : 
     private string _salesareadata; 
     [XafDisplayName("Sales Area Data"), ToolTip("Sales area data")] 
     // [Appearance("fSalesDocumentsalesareadata", Enabled = true)]
     // [Appearance("fSalesDocumentsalesareadataVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string salesareadata
     { 
       get { return _salesareadata; } 
       set { SetPropertyValue(nameof(salesareadata), ref _salesareadata, value); } 
     } 
     // Sales
     // Notes for fSalesDocument : 
     private string _salesdistrict; 
     [XafDisplayName("Sales District"), ToolTip("Sales district")] 
     // [Appearance("fSalesDocumentsalesdistrict", Enabled = true)]
     // [Appearance("fSalesDocumentsalesdistrictVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string salesdistrict
     { 
       get { return _salesdistrict; } 
       set { SetPropertyValue(nameof(salesdistrict), ref _salesdistrict, value); } 
     } 
     // Sales
     // Notes for fSalesDocument : 
     private string _salesgroup1; 
     [XafDisplayName("Sales Group (Sales)"), ToolTip("Sales Group (Sales)")] 
     // [Appearance("fSalesDocumentsalesgroup1", Enabled = true)]
     // [Appearance("fSalesDocumentsalesgroup1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string salesgroup1
     { 
       get { return _salesgroup1; } 
       set { SetPropertyValue(nameof(salesgroup1), ref _salesgroup1, value); } 
     } 
     // Sales
     // Notes for fSalesDocument : 
     private string _salesoffice1; 
     [XafDisplayName("Sales Office (Sales)"), ToolTip("Sales Office (Sales)")] 
     // [Appearance("fSalesDocumentsalesoffice1", Enabled = true)]
     // [Appearance("fSalesDocumentsalesoffice1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string salesoffice1
     { 
       get { return _salesoffice1; } 
       set { SetPropertyValue(nameof(salesoffice1), ref _salesoffice1, value); } 
     } 
     // Sales
     // Notes for fSalesDocument : 
     private enumUsage _usage1; 
     [XafDisplayName("Usage (Sales)"), ToolTip("Usage (Sales)")] 
     // [Appearance("fSalesDocumentusage1", Enabled = true)]
     // [Appearance("fSalesDocumentusage1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumUsage usage1
     { 
       get { return _usage1; } 
       set { SetPropertyValue(nameof(usage1), ref _usage1, value); } 
     } 
     // Sales
     // Notes for fSalesDocument : 
     private string _version; 
     [XafDisplayName("Version"), ToolTip("Version")] 
     // [Appearance("fSalesDocumentversion", Enabled = true)]
     // [Appearance("fSalesDocumentversionVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string version
     { 
       get { return _version; } 
       set { SetPropertyValue(nameof(version), ref _version, value); } 
     } 
     // Sales A
     // Notes for fSalesDocument : 
     private string _alttoitem; 
     [XafDisplayName("Alternative to Item"), ToolTip("Alternative to item")] 
     // [Appearance("fSalesDocumentalttoitem", Enabled = true)]
     // [Appearance("fSalesDocumentalttoitemVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string alttoitem
     { 
       get { return _alttoitem; } 
       set { SetPropertyValue(nameof(alttoitem), ref _alttoitem, value); } 
     } 
     // Sales A
     // Notes for fSalesDocument : 
     private string _bomexpnumb; 
     [XafDisplayName("BOM Explosion Number"), ToolTip("BOM explosion number")] 
     // [Appearance("fSalesDocumentbomexpnumb", Enabled = true)]
     // [Appearance("fSalesDocumentbomexpnumbVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string bomexpnumb
     { 
       get { return _bomexpnumb; } 
       set { SetPropertyValue(nameof(bomexpnumb), ref _bomexpnumb, value); } 
     } 
     // Sales A
     // Notes for fSalesDocument : 
     private string _bustranstype; 
     [XafDisplayName("Bus Transaction Type"), ToolTip("Bus transaction type")] 
     // [Appearance("fSalesDocumentbustranstype", Enabled = true)]
     // [Appearance("fSalesDocumentbustranstypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string bustranstype
     { 
       get { return _bustranstype; } 
       set { SetPropertyValue(nameof(bustranstype), ref _bustranstype, value); } 
     } 
     // Sales A
     // Notes for fSalesDocument : 
     private string _eanupc; 
     [XafDisplayName("EANUPC"), ToolTip("EANUPC")] 
     // [Appearance("fSalesDocumenteanupc", Enabled = true)]
     // [Appearance("fSalesDocumenteanupcVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(80)] 
     public  string eanupc
     { 
       get { return _eanupc; } 
       set { SetPropertyValue(nameof(eanupc), ref _eanupc, value); } 
     } 
     // Sales A
     // Notes for fSalesDocument : 
     private string _engchg; 
     [XafDisplayName("Engineering Change"), ToolTip("Engineering change")] 
     // [Appearance("fSalesDocumentengchg", Enabled = true)]
     // [Appearance("fSalesDocumentengchgVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string engchg
     { 
       get { return _engchg; } 
       set { SetPropertyValue(nameof(engchg), ref _engchg, value); } 
     } 
     // Sales A
     // Notes for fSalesDocument : 
     private DateTime _firstdelivdate; 
     [XafDisplayName("First Delivery Date"), ToolTip("First Delivery Date")] 
     // [Appearance("fSalesDocumentfirstdelivdate", Enabled = true)]
     // [Appearance("fSalesDocumentfirstdelivdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime firstdelivdate
     { 
       get { return _firstdelivdate; } 
       set { SetPropertyValue(nameof(firstdelivdate), ref _firstdelivdate, value); } 
     } 
     // Sales A
     // Notes for fSalesDocument : 
     private string _matlenter; 
     [XafDisplayName("Material Entered"), ToolTip("Material entered")] 
     // [Appearance("fSalesDocumentmatlenter", Enabled = true)]
     // [Appearance("fSalesDocumentmatlenterVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string matlenter
     { 
       get { return _matlenter; } 
       set { SetPropertyValue(nameof(matlenter), ref _matlenter, value); } 
     } 
     // Sales A
     // Notes for fSalesDocument : 
     private double _netval; 
     [XafDisplayName("Net Value"), ToolTip("Net value")] 
     // [Appearance("fSalesDocumentnetval", Enabled = true)]
     // [Appearance("fSalesDocumentnetvalVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double netval
     { 
       get { return _netval; } 
       set { SetPropertyValue(nameof(netval), ref _netval, value); } 
     } 
     // Sales A
     // Notes for fSalesDocument : 
     private string _orderprob; 
     [XafDisplayName("Order Probability"), ToolTip("Order probability")] 
     // [Appearance("fSalesDocumentorderprob", Enabled = true)]
     // [Appearance("fSalesDocumentorderprobVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string orderprob
     { 
       get { return _orderprob; } 
       set { SetPropertyValue(nameof(orderprob), ref _orderprob, value); } 
     } 
     // Sales A
     // Notes for fSalesDocument : 
     private string _orderqty; 
     [XafDisplayName("Order Quantity"), ToolTip("Order Quantity")] 
     // [Appearance("fSalesDocumentorderqty", Enabled = true)]
     // [Appearance("fSalesDocumentorderqtyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string orderqty
     { 
       get { return _orderqty; } 
       set { SetPropertyValue(nameof(orderqty), ref _orderqty, value); } 
     } 
     // Sales A
     // Notes for fSalesDocument : 
     private DateTime _pricdate; 
     [XafDisplayName("Pricing Date"), ToolTip("Pricing date")] 
     // [Appearance("fSalesDocumentpricdate", Enabled = true)]
     // [Appearance("fSalesDocumentpricdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime pricdate
     { 
       get { return _pricdate; } 
       set { SetPropertyValue(nameof(pricdate), ref _pricdate, value); } 
     } 
     // Sales A
     // Notes for fSalesDocument : 
     private enumReasonReject _reasonreject; 
     [XafDisplayName("Reason for Rejection"), ToolTip("Reason for rejection")] 
     // [Appearance("fSalesDocumentreasonreject", Enabled = true)]
     // [Appearance("fSalesDocumentreasonrejectVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumReasonReject reasonreject
     { 
       get { return _reasonreject; } 
       set { SetPropertyValue(nameof(reasonreject), ref _reasonreject, value); } 
     } 
     // Sales A
     // Notes for fSalesDocument : 
     private enumUsage _usage; 
     [XafDisplayName("Usage"), ToolTip("Usage")] 
     // [Appearance("fSalesDocumentusage", Enabled = true)]
     // [Appearance("fSalesDocumentusageVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumUsage usage
     { 
       get { return _usage; } 
       set { SetPropertyValue(nameof(usage), ref _usage, value); } 
     } 
     // Schedule lines
     // Notes for fSalesDocument : 
     private string _delivqty; 
     [XafDisplayName("Deliverd Qty"), ToolTip("Deliverd qty")] 
     // [Appearance("fSalesDocumentdelivqty", Enabled = true)]
     // [Appearance("fSalesDocumentdelivqtyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string delivqty
     { 
       get { return _delivqty; } 
       set { SetPropertyValue(nameof(delivqty), ref _delivqty, value); } 
     } 
     // Schedule lines
     // Notes for fSalesDocument : 
     private bool _fixdateqty; 
     [XafDisplayName("Fixed Date and Qty"), ToolTip("Fixed date and qty")] 
     // [Appearance("fSalesDocumentfixdateqty", Enabled = true)]
     // [Appearance("fSalesDocumentfixdateqtyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool fixdateqty
     { 
       get { return _fixdateqty; } 
       set { SetPropertyValue(nameof(fixdateqty), ref _fixdateqty, value); } 
     } 
     // Schedule lines
     // Notes for fSalesDocument : 
     private string _orderqty1; 
     [XafDisplayName("Order Quantity (Sch.)"), ToolTip("Order Quantity (Sch.)")] 
     // [Appearance("fSalesDocumentorderqty1", Enabled = true)]
     // [Appearance("fSalesDocumentorderqty1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string orderqty1
     { 
       get { return _orderqty1; } 
       set { SetPropertyValue(nameof(orderqty1), ref _orderqty1, value); } 
     } 
   } 
} 
