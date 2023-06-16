// Class Name : fCreateQuotations.cs 
// Project Name : FICO 
// Last Update : 16/06/2023 15:07:14  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 16/06/2023 15:07:14 
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
   [System.ComponentModel.DisplayName("Maintain Quotation : Item 00010")]
   public class fCreateQuotations : XPObject
   {
     public fCreateQuotations(Session session) : base(session) 
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
     [Appearance("VisiblefCreateQuotationsOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for fCreateQuotations : 
     private string _item; 
     [XafDisplayName("Item"), ToolTip("Item")] 
     // [Appearance("fCreateQuotationsitem", Enabled = true)]
     // [Appearance("fCreateQuotationsitemVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string item
     { 
       get { return _item; } 
       set { SetPropertyValue(nameof(item), ref _item, value); } 
     } 
     // 
     // Notes for fCreateQuotations : 
     private string _itcat; 
     [XafDisplayName("ItCat."), ToolTip("ItCat.")] 
     // [Appearance("fCreateQuotationsitcat", Enabled = true)]
     // [Appearance("fCreateQuotationsitcatVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string itcat
     { 
       get { return _itcat; } 
       set { SetPropertyValue(nameof(itcat), ref _itcat, value); } 
     } 
     // 
     // Notes for fCreateQuotations : 
     private string _plant; 
     [XafDisplayName("Plant"), ToolTip("Plant")] 
     // [Appearance("fCreateQuotationsplant", Enabled = true)]
     // [Appearance("fCreateQuotationsplantVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string plant
     { 
       get { return _plant; } 
       set { SetPropertyValue(nameof(plant), ref _plant, value); } 
     } 
     // 
     // Notes for fCreateQuotations : 
     private string _material; 
     [XafDisplayName("Material"), ToolTip("Material")] 
     // [Appearance("fCreateQuotationsmaterial", Enabled = true)]
     // [Appearance("fCreateQuotationsmaterialVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string material
     { 
       get { return _material; } 
       set { SetPropertyValue(nameof(material), ref _material, value); } 
     } 
     // 
     // Notes for fCreateQuotations : 
     private string _matgrp; 
     [XafDisplayName("Mat. Grp"), ToolTip("Mat. Grp")] 
     // [Appearance("fCreateQuotationsmatgrp", Enabled = true)]
     // [Appearance("fCreateQuotationsmatgrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string matgrp
     { 
       get { return _matgrp; } 
       set { SetPropertyValue(nameof(matgrp), ref _matgrp, value); } 
     } 
     // 
     // Notes for fCreateQuotations : 
     private string _storloc; 
     [XafDisplayName("Stor. Loc."), ToolTip("Stor. Loc.")] 
     // [Appearance("fCreateQuotationsstorloc", Enabled = true)]
     // [Appearance("fCreateQuotationsstorlocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string storloc
     { 
       get { return _storloc; } 
       set { SetPropertyValue(nameof(storloc), ref _storloc, value); } 
     } 
     // 
     // Notes for fCreateQuotations : 
     private string _shorttext; 
     [XafDisplayName("Short Text"), ToolTip("Short Text")] 
     // [Appearance("fCreateQuotationsshorttext", Enabled = true)]
     // [Appearance("fCreateQuotationsshorttextVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string shorttext
     { 
       get { return _shorttext; } 
       set { SetPropertyValue(nameof(shorttext), ref _shorttext, value); } 
     } 
     // Quantity and Date
     // Notes for fCreateQuotations : 
     private string _rfqqty; 
     [XafDisplayName("RFQ Quantity"), ToolTip("RFQ Quantity")] 
     // [Appearance("fCreateQuotationsrfqqty", Enabled = true)]
     // [Appearance("fCreateQuotationsrfqqtyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string rfqqty
     { 
       get { return _rfqqty; } 
       set { SetPropertyValue(nameof(rfqqty), ref _rfqqty, value); } 
     } 
     // Quantity and Date
     // Notes for fCreateQuotations : 
     private DateTime _quotddln; 
     [XafDisplayName("Quot Ddln"), ToolTip("QuotDdln")] 
     // [Appearance("fCreateQuotationsquotddln", Enabled = true)]
     // [Appearance("fCreateQuotationsquotddlnVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime quotddln
     { 
       get { return _quotddln; } 
       set { SetPropertyValue(nameof(quotddln), ref _quotddln, value); } 
     } 
     // Quantity and Date
     // Notes for fCreateQuotations : 
     private DateTime _delivedate; 
     [XafDisplayName("Delivery Date"), ToolTip("Delivery Date")] 
     // [Appearance("fCreateQuotationsdelivedate", Enabled = true)]
     // [Appearance("fCreateQuotationsdelivedateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime delivedate
     { 
       get { return _delivedate; } 
       set { SetPropertyValue(nameof(delivedate), ref _delivedate, value); } 
     } 
     // Deadline Monitoring
     // Notes for fCreateQuotations : 
     private string _rem1st; 
     [XafDisplayName("1st Rem./Exped."), ToolTip("1st Rem./Exped.")] 
     // [Appearance("fCreateQuotationsrem1st", Enabled = true)]
     // [Appearance("fCreateQuotationsrem1stVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string rem1st
     { 
       get { return _rem1st; } 
       set { SetPropertyValue(nameof(rem1st), ref _rem1st, value); } 
     } 
     // Deadline Monitoring
     // Notes for fCreateQuotations : 
     private string _trackno; 
     [XafDisplayName("Tracking No"), ToolTip("TrackingNo")] 
     // [Appearance("fCreateQuotationstrackno", Enabled = true)]
     // [Appearance("fCreateQuotationstracknoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string trackno
     { 
       get { return _trackno; } 
       set { SetPropertyValue(nameof(trackno), ref _trackno, value); } 
     } 
     // Deadline Monitoring
     // Notes for fCreateQuotations : 
     private string _rem2nd; 
     [XafDisplayName("2nd Rem./Exped."), ToolTip("2nd Rem./Exped.")] 
     // [Appearance("fCreateQuotationsrem2nd", Enabled = true)]
     // [Appearance("fCreateQuotationsrem2ndVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string rem2nd
     { 
       get { return _rem2nd; } 
       set { SetPropertyValue(nameof(rem2nd), ref _rem2nd, value); } 
     } 
     // Deadline Monitoring
     // Notes for fCreateQuotations : 
     private string _vmat; 
     [XafDisplayName("V. Mat."), ToolTip("V. Mat.")] 
     // [Appearance("fCreateQuotationsvmat", Enabled = true)]
     // [Appearance("fCreateQuotationsvmatVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string vmat
     { 
       get { return _vmat; } 
       set { SetPropertyValue(nameof(vmat), ref _vmat, value); } 
     } 
     // Deadline Monitoring
     // Notes for fCreateQuotations : 
     private string _rems3rd; 
     [XafDisplayName("3rd Rem./Exped."), ToolTip("3rd Rem./Exped.")] 
     // [Appearance("fCreateQuotationsrems3rd", Enabled = true)]
     // [Appearance("fCreateQuotationsrems3rdVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string rems3rd
     { 
       get { return _rems3rd; } 
       set { SetPropertyValue(nameof(rems3rd), ref _rems3rd, value); } 
     } 
     // Deadline Monitoring
     // Notes for fCreateQuotations : 
     private string _noexped; 
     [XafDisplayName("No. Exped."), ToolTip("No. Exped.")] 
     // [Appearance("fCreateQuotationsnoexped", Enabled = true)]
     // [Appearance("fCreateQuotationsnoexpedVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string noexped
     { 
       get { return _noexped; } 
       set { SetPropertyValue(nameof(noexped), ref _noexped, value); } 
     } 
     // Quotation Data
     // Notes for fCreateQuotations : 
     private double _netorderprice; 
     [XafDisplayName("Net Order Price"), ToolTip("Net Order Price")] 
     // [Appearance("fCreateQuotationsnetorderprice", Enabled = true)]
     // [Appearance("fCreateQuotationsnetorderpriceVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double netorderprice
     { 
       get { return _netorderprice; } 
       set { SetPropertyValue(nameof(netorderprice), ref _netorderprice, value); } 
     } 
     // Quotation Data
     // Notes for fCreateQuotations : 
     private string _infoupdt; 
     [XafDisplayName("Info Update"), ToolTip("InfoUpdate")] 
     // [Appearance("fCreateQuotationsinfoupdt", Enabled = true)]
     // [Appearance("fCreateQuotationsinfoupdtVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string infoupdt
     { 
       get { return _infoupdt; } 
       set { SetPropertyValue(nameof(infoupdt), ref _infoupdt, value); } 
     } 
     // Quotation Data
     // Notes for fCreateQuotations : 
     private string _qtyconv; 
     [XafDisplayName("Qty Conv."), ToolTip("QtyConv.")] 
     // [Appearance("fCreateQuotationsqtyconv", Enabled = true)]
     // [Appearance("fCreateQuotationsqtyconvVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string qtyconv
     { 
       get { return _qtyconv; } 
       set { SetPropertyValue(nameof(qtyconv), ref _qtyconv, value); } 
     } 
     // Quotation Data
     // Notes for fCreateQuotations : 
     private string _quotcomm; 
     [XafDisplayName("Quot. Comment"), ToolTip("Quot. Comment")] 
     // [Appearance("fCreateQuotationsquotcomm", Enabled = true)]
     // [Appearance("fCreateQuotationsquotcommVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string quotcomm
     { 
       get { return _quotcomm; } 
       set { SetPropertyValue(nameof(quotcomm), ref _quotcomm, value); } 
     } 
     // Quotation Data
     // Notes for fCreateQuotations : 
     private string _taxcode; 
     [XafDisplayName("Tax Code"), ToolTip("Tax Code")] 
     // [Appearance("fCreateQuotationstaxcode", Enabled = true)]
     // [Appearance("fCreateQuotationstaxcodeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string taxcode
     { 
       get { return _taxcode; } 
       set { SetPropertyValue(nameof(taxcode), ref _taxcode, value); } 
     } 
     // Quotation Data
     // Notes for fCreateQuotations : 
     private bool _rejind; 
     [XafDisplayName("Rej. Ind."), ToolTip("Rej. Ind.")] 
     // [Appearance("fCreateQuotationsrejind", Enabled = true)]
     // [Appearance("fCreateQuotationsrejindVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool rejind
     { 
       get { return _rejind; } 
       set { SetPropertyValue(nameof(rejind), ref _rejind, value); } 
     } 
     // Administration
     // Notes for fCreateQuotations : 
     private string _pidelivtime; 
     [XafDisplayName("PI. Deliv. Time"), ToolTip("PI. Deliv. Time")] 
     // [Appearance("fCreateQuotationspidelivtime", Enabled = true)]
     // [Appearance("fCreateQuotationspidelivtimeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string pidelivtime
     { 
       get { return _pidelivtime; } 
       set { SetPropertyValue(nameof(pidelivtime), ref _pidelivtime, value); } 
     } 
     // Administration
     // Notes for fCreateQuotations : 
     private string _revisionlevel; 
     [XafDisplayName("Revision Level"), ToolTip("Revision Level")] 
     // [Appearance("fCreateQuotationsrevisionlevel", Enabled = true)]
     // [Appearance("fCreateQuotationsrevisionlevelVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string revisionlevel
     { 
       get { return _revisionlevel; } 
       set { SetPropertyValue(nameof(revisionlevel), ref _revisionlevel, value); } 
     } 
     // Administration
     // Notes for fCreateQuotations : 
     private string _priorvendor; 
     [XafDisplayName("Prior Vendor"), ToolTip("Prior Vendor")] 
     // [Appearance("fCreateQuotationspriorvendor", Enabled = true)]
     // [Appearance("fCreateQuotationspriorvendorVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string priorvendor
     { 
       get { return _priorvendor; } 
       set { SetPropertyValue(nameof(priorvendor), ref _priorvendor, value); } 
     } 
     // Administration
     // Notes for fCreateQuotations : 
     private string _season; 
     [XafDisplayName("Season"), ToolTip("Season")] 
     // [Appearance("fCreateQuotationsseason", Enabled = true)]
     // [Appearance("fCreateQuotationsseasonVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string season
     { 
       get { return _season; } 
       set { SetPropertyValue(nameof(season), ref _season, value); } 
     } 
     // Administration
     // Notes for fCreateQuotations : 
     private string _kanbanindicat; 
     [XafDisplayName("Kanban Indicat."), ToolTip("Kanban Indicat.")] 
     // [Appearance("fCreateQuotationskanbanindicat", Enabled = true)]
     // [Appearance("fCreateQuotationskanbanindicatVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string kanbanindicat
     { 
       get { return _kanbanindicat; } 
       set { SetPropertyValue(nameof(kanbanindicat), ref _kanbanindicat, value); } 
     } 
     // Administration
     // Notes for fCreateQuotations : 
     private string _atrelevant; 
     [XafDisplayName("A T-Relevant"), ToolTip("A T-Relevant")] 
     // [Appearance("fCreateQuotationsatrelevant", Enabled = true)]
     // [Appearance("fCreateQuotationsatrelevantVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string atrelevant
     { 
       get { return _atrelevant; } 
       set { SetPropertyValue(nameof(atrelevant), ref _atrelevant, value); } 
     } 
     // Administration
     // Notes for fCreateQuotations : 
     private string _reasonforord; 
     [XafDisplayName("Reason for Ord."), ToolTip("Reason for Ord.")] 
     // [Appearance("fCreateQuotationsreasonforord", Enabled = true)]
     // [Appearance("fCreateQuotationsreasonforordVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string reasonforord
     { 
       get { return _reasonforord; } 
       set { SetPropertyValue(nameof(reasonforord), ref _reasonforord, value); } 
     } 
     // Weights and Volumes for 1 Order Unit
     // Notes for fCreateQuotations : 
     private double _netweight; 
     [XafDisplayName("Net Weight"), ToolTip("Net Weight")] 
     // [Appearance("fCreateQuotationsnetweight", Enabled = true)]
     // [Appearance("fCreateQuotationsnetweightVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double netweight
     { 
       get { return _netweight; } 
       set { SetPropertyValue(nameof(netweight), ref _netweight, value); } 
     } 
     // Weights and Volumes for 1 Order Unit
     // Notes for fCreateQuotations : 
     private double _grossweight; 
     [XafDisplayName("Gross Weight"), ToolTip("Gross Weight")] 
     // [Appearance("fCreateQuotationsgrossweight", Enabled = true)]
     // [Appearance("fCreateQuotationsgrossweightVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double grossweight
     { 
       get { return _grossweight; } 
       set { SetPropertyValue(nameof(grossweight), ref _grossweight, value); } 
     } 
     // Weights and Volumes for 1 Order Unit
     // Notes for fCreateQuotations : 
     private double _volume; 
     [XafDisplayName("Volume"), ToolTip("Volume")] 
     // [Appearance("fCreateQuotationsvolume", Enabled = true)]
     // [Appearance("fCreateQuotationsvolumeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double volume
     { 
       get { return _volume; } 
       set { SetPropertyValue(nameof(volume), ref _volume, value); } 
     } 
     // Weights and Volumes for 1 Order Unit
     // Notes for fCreateQuotations : 
     private double _points; 
     [XafDisplayName("Points"), ToolTip("Points")] 
     // [Appearance("fCreateQuotationspoints", Enabled = true)]
     // [Appearance("fCreateQuotationspointsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double points
     { 
       get { return _points; } 
       set { SetPropertyValue(nameof(points), ref _points, value); } 
     } 
     // Conditions
     // Notes for fCreateQuotations : 
     private string _conditionsgrp; 
     [XafDisplayName("Conditions Group"), ToolTip("Conditions Group")] 
     // [Appearance("fCreateQuotationsconditionsgrp", Enabled = true)]
     // [Appearance("fCreateQuotationsconditionsgrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string conditionsgrp
     { 
       get { return _conditionsgrp; } 
       set { SetPropertyValue(nameof(conditionsgrp), ref _conditionsgrp, value); } 
     } 
     // Conditions
     // Notes for fCreateQuotations : 
     private bool _nocashdisc; 
     [XafDisplayName("No Cash Disc."), ToolTip("No Cash Disc.")] 
     // [Appearance("fCreateQuotationsnocashdisc", Enabled = true)]
     // [Appearance("fCreateQuotationsnocashdiscVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool nocashdisc
     { 
       get { return _nocashdisc; } 
       set { SetPropertyValue(nameof(nocashdisc), ref _nocashdisc, value); } 
     } 
     // Conditions
     // Notes for fCreateQuotations : 
     private string _vendorsubrange; 
     [XafDisplayName("Vendor Subrange"), ToolTip("Vendor Subrange")] 
     // [Appearance("fCreateQuotationsvendorsubrange", Enabled = true)]
     // [Appearance("fCreateQuotationsvendorsubrangeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string vendorsubrange
     { 
       get { return _vendorsubrange; } 
       set { SetPropertyValue(nameof(vendorsubrange), ref _vendorsubrange, value); } 
     } 
     // Conditions
     // Notes for fCreateQuotations : 
     private string _promotion; 
     [XafDisplayName("Promotion"), ToolTip("Promotion")] 
     // [Appearance("fCreateQuotationspromotion", Enabled = true)]
     // [Appearance("fCreateQuotationspromotionVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string promotion
     { 
       get { return _promotion; } 
       set { SetPropertyValue(nameof(promotion), ref _promotion, value); } 
     } 
     // Conditions
     // Notes for fCreateQuotations : 
     private string _prdatecat; 
     [XafDisplayName("Pr. Date Cat."), ToolTip("Pr. Date Cat.")] 
     // [Appearance("fCreateQuotationsprdatecat", Enabled = true)]
     // [Appearance("fCreateQuotationsprdatecatVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string prdatecat
     { 
       get { return _prdatecat; } 
       set { SetPropertyValue(nameof(prdatecat), ref _prdatecat, value); } 
     } 
     // Conditions
     // Notes for fCreateQuotations : 
     private string _incoterms; 
     [XafDisplayName("Incoterms"), ToolTip("Incoterms")] 
     // [Appearance("fCreateQuotationsincoterms", Enabled = true)]
     // [Appearance("fCreateQuotationsincotermsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string incoterms
     { 
       get { return _incoterms; } 
       set { SetPropertyValue(nameof(incoterms), ref _incoterms, value); } 
     } 
     // GR Control
     // Notes for fCreateQuotations : 
     private string _remshelflife; 
     [XafDisplayName("Rem. Shelf Life"), ToolTip("Rem. Shelf Life")] 
     // [Appearance("fCreateQuotationsremshelflife", Enabled = true)]
     // [Appearance("fCreateQuotationsremshelflifeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string remshelflife
     { 
       get { return _remshelflife; } 
       set { SetPropertyValue(nameof(remshelflife), ref _remshelflife, value); } 
     } 
     // GR Control
     // Notes for fCreateQuotations : 
     private string _batch; 
     [XafDisplayName("Batch"), ToolTip("Batch")] 
     // [Appearance("fCreateQuotationsbatch", Enabled = true)]
     // [Appearance("fCreateQuotationsbatchVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string batch
     { 
       get { return _batch; } 
       set { SetPropertyValue(nameof(batch), ref _batch, value); } 
     } 
     // GR Control
     // Notes for fCreateQuotations : 
     private string _latestgrdate; 
     [XafDisplayName("Latest GR Date"), ToolTip("Latest GR Date")] 
     // [Appearance("fCreateQuotationslatestgrdate", Enabled = true)]
     // [Appearance("fCreateQuotationslatestgrdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string latestgrdate
     { 
       get { return _latestgrdate; } 
       set { SetPropertyValue(nameof(latestgrdate), ref _latestgrdate, value); } 
     } 
     // GR Control
     // Notes for fCreateQuotations : 
     private string _vendorbatch; 
     [XafDisplayName("Vendor Batch"), ToolTip("Vendor Batch")] 
     // [Appearance("fCreateQuotationsvendorbatch", Enabled = true)]
     // [Appearance("fCreateQuotationsvendorbatchVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string vendorbatch
     { 
       get { return _vendorbatch; } 
       set { SetPropertyValue(nameof(vendorbatch), ref _vendorbatch, value); } 
     } 
     // GR Control
     // Notes for fCreateQuotations : 
     private string _qmcontrolkey; 
     [XafDisplayName("QM Control Key"), ToolTip("QM Control Key")] 
     // [Appearance("fCreateQuotationsqmcontrolkey", Enabled = true)]
     // [Appearance("fCreateQuotationsqmcontrolkeyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string qmcontrolkey
     { 
       get { return _qmcontrolkey; } 
       set { SetPropertyValue(nameof(qmcontrolkey), ref _qmcontrolkey, value); } 
     } 
   } 
} 
