// Class Name : fInfoRecord.cs 
// Project Name : FICO 
// Last Update : 16/06/2023 15:05:31  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 16/06/2023 15:05:31 
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
   [System.ComponentModel.DisplayName("Create Info Record: Initial Screen")]
   public class fInfoRecord : XPObject
   {
     public fInfoRecord(Session session) : base(session) 
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
     [Appearance("VisiblefInfoRecordOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for fInfoRecord : 
     private fVendor _vendor; 
     [XafDisplayName("Vendor"), ToolTip("Vendor")] 
     // [Appearance("fInfoRecordvendor", Enabled = true)]
     // [Appearance("fInfoRecordvendorVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fVendor vendor
     { 
       get { return _vendor; } 
       set { SetPropertyValue(nameof(vendor), ref _vendor, value); } 
     } 
     // 
     // Notes for fInfoRecord : 
     private string _material; 
     [XafDisplayName("Material"), ToolTip("Material")] 
     // [Appearance("fInfoRecordmaterial", Enabled = true)]
     // [Appearance("fInfoRecordmaterialVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fInfoRecord : 
     private string _purchorg; 
     [XafDisplayName("Purchasing Org."), ToolTip("Purchasing Org.")] 
     // [Appearance("fInfoRecordpurchorg", Enabled = true)]
     // [Appearance("fInfoRecordpurchorgVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string purchorg
     { 
       get { return _purchorg; } 
       set { SetPropertyValue(nameof(purchorg), ref _purchorg, value); } 
     } 
     // 
     // Notes for fInfoRecord : 
     private string _plant; 
     [XafDisplayName("Plant"), ToolTip("Plant")] 
     // [Appearance("fInfoRecordplant", Enabled = true)]
     // [Appearance("fInfoRecordplantVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fInfoRecord : 
     private string _inforecord; 
     [XafDisplayName("Info Record"), ToolTip("Info Record")] 
     // [Appearance("fInfoRecordinforecord", Enabled = true)]
     // [Appearance("fInfoRecordinforecordVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string inforecord
     { 
       get { return _inforecord; } 
       set { SetPropertyValue(nameof(inforecord), ref _inforecord, value); } 
     } 
     // Info Record
     // Notes for fInfoRecord : 
     private bool _standard; 
     [XafDisplayName("Standard"), ToolTip("Standard")] 
     // [Appearance("fInfoRecordstandard", Enabled = true)]
     // [Appearance("fInfoRecordstandardVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool standard
     { 
       get { return _standard; } 
       set { SetPropertyValue(nameof(standard), ref _standard, value); } 
     } 
     // Info Record
     // Notes for fInfoRecord : 
     private bool _subcontracting; 
     [XafDisplayName("Subcontracting"), ToolTip("Subcontracting")] 
     // [Appearance("fInfoRecordsubcontracting", Enabled = true)]
     // [Appearance("fInfoRecordsubcontractingVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool subcontracting
     { 
       get { return _subcontracting; } 
       set { SetPropertyValue(nameof(subcontracting), ref _subcontracting, value); } 
     } 
     // Info Record
     // Notes for fInfoRecord : 
     private bool _pipeline; 
     [XafDisplayName("Pipeline"), ToolTip("Pipeline")] 
     // [Appearance("fInfoRecordpipeline", Enabled = true)]
     // [Appearance("fInfoRecordpipelineVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool pipeline
     { 
       get { return _pipeline; } 
       set { SetPropertyValue(nameof(pipeline), ref _pipeline, value); } 
     } 
     // Info Record
     // Notes for fInfoRecord : 
     private bool _consignment; 
     [XafDisplayName("Consignment"), ToolTip("Consignment")] 
     // [Appearance("fInfoRecordconsignment", Enabled = true)]
     // [Appearance("fInfoRecordconsignmentVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool consignment
     { 
       get { return _consignment; } 
       set { SetPropertyValue(nameof(consignment), ref _consignment, value); } 
     } 
     // 
     // Notes for fInfoRecord : 
     private string _matlgrp; 
     [XafDisplayName("Material Group"), ToolTip("Material Group")] 
     // [Appearance("fInfoRecordmatlgrp", Enabled = true)]
     // [Appearance("fInfoRecordmatlgrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string matlgrp
     { 
       get { return _matlgrp; } 
       set { SetPropertyValue(nameof(matlgrp), ref _matlgrp, value); } 
     } 
     // Vendor Data
     // Notes for fInfoRecord : 
     private string _rem1st; 
     [XafDisplayName("1st Rem./Exped."), ToolTip("1st Rem./Exped.")] 
     // [Appearance("fInfoRecordrem1st", Enabled = true)]
     // [Appearance("fInfoRecordrem1stVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string rem1st
     { 
       get { return _rem1st; } 
       set { SetPropertyValue(nameof(rem1st), ref _rem1st, value); } 
     } 
     // Vendor Data
     // Notes for fInfoRecord : 
     private string _rem2nd; 
     [XafDisplayName("2nd Rem./Exped."), ToolTip("2nd Rem./Exped.")] 
     // [Appearance("fInfoRecordrem2nd", Enabled = true)]
     // [Appearance("fInfoRecordrem2ndVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string rem2nd
     { 
       get { return _rem2nd; } 
       set { SetPropertyValue(nameof(rem2nd), ref _rem2nd, value); } 
     } 
     // Vendor Data
     // Notes for fInfoRecord : 
     private string _rem3rd; 
     [XafDisplayName("3rd Rem./Exped."), ToolTip("3rd Rem./Exped.")] 
     // [Appearance("fInfoRecordrem3rd", Enabled = true)]
     // [Appearance("fInfoRecordrem3rdVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string rem3rd
     { 
       get { return _rem3rd; } 
       set { SetPropertyValue(nameof(rem3rd), ref _rem3rd, value); } 
     } 
     // Vendor Data
     // Notes for fInfoRecord : 
     private string _vendormatno; 
     [XafDisplayName("Vendor Mat. No."), ToolTip("Vendor Mat. No.")] 
     // [Appearance("fInfoRecordvendormatno", Enabled = true)]
     // [Appearance("fInfoRecordvendormatnoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string vendormatno
     { 
       get { return _vendormatno; } 
       set { SetPropertyValue(nameof(vendormatno), ref _vendormatno, value); } 
     } 
     // Vendor Data
     // Notes for fInfoRecord : 
     private string _vendorsubrange; 
     [XafDisplayName("Vendor Subrange"), ToolTip("Vendor Subrange")] 
     // [Appearance("fInfoRecordvendorsubrange", Enabled = true)]
     // [Appearance("fInfoRecordvendorsubrangeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string vendorsubrange
     { 
       get { return _vendorsubrange; } 
       set { SetPropertyValue(nameof(vendorsubrange), ref _vendorsubrange, value); } 
     } 
     // Vendor Data
     // Notes for fInfoRecord : 
     private string _vsrsortno; 
     [XafDisplayName("VSR Sort No."), ToolTip("VSR Sort No.")] 
     // [Appearance("fInfoRecordvsrsortno", Enabled = true)]
     // [Appearance("fInfoRecordvsrsortnoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string vsrsortno
     { 
       get { return _vsrsortno; } 
       set { SetPropertyValue(nameof(vsrsortno), ref _vsrsortno, value); } 
     } 
     // Vendor Data
     // Notes for fInfoRecord : 
     private string _vendormatgrp; 
     [XafDisplayName("Vendor Mat. Grp"), ToolTip("Vendor Mat. Grp")] 
     // [Appearance("fInfoRecordvendormatgrp", Enabled = true)]
     // [Appearance("fInfoRecordvendormatgrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(40)] 
     public  string vendormatgrp
     { 
       get { return _vendormatgrp; } 
       set { SetPropertyValue(nameof(vendormatgrp), ref _vendormatgrp, value); } 
     } 
     // Vendor Data
     // Notes for fInfoRecord : 
     private string _points; 
     [XafDisplayName("Points"), ToolTip("Points")] 
     // [Appearance("fInfoRecordpoints", Enabled = true)]
     // [Appearance("fInfoRecordpointsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(60)] 
     public  string points
     { 
       get { return _points; } 
       set { SetPropertyValue(nameof(points), ref _points, value); } 
     } 
     // Vendor Data
     // Notes for fInfoRecord : 
     private string _salesperson; 
     [XafDisplayName("Salesperson"), ToolTip("Salesperson")] 
     // [Appearance("fInfoRecordsalesperson", Enabled = true)]
     // [Appearance("fInfoRecordsalespersonVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(70)] 
     public  string salesperson
     { 
       get { return _salesperson; } 
       set { SetPropertyValue(nameof(salesperson), ref _salesperson, value); } 
     } 
     // Vendor Data
     // Notes for fInfoRecord : 
     private string _telephone; 
     [XafDisplayName("Telephone"), ToolTip("Telephone")] 
     // [Appearance("fInfoRecordtelephone", Enabled = true)]
     // [Appearance("fInfoRecordtelephoneVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string telephone
     { 
       get { return _telephone; } 
       set { SetPropertyValue(nameof(telephone), ref _telephone, value); } 
     } 
     // Vendor Data
     // Notes for fInfoRecord : 
     private string _retunragmr; 
     [XafDisplayName("Return Agmr"), ToolTip("Return Agmr")] 
     // [Appearance("fInfoRecordretunragmr", Enabled = true)]
     // [Appearance("fInfoRecordretunragmrVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string retunragmr
     { 
       get { return _retunragmr; } 
       set { SetPropertyValue(nameof(retunragmr), ref _retunragmr, value); } 
     } 
     // Vendor Data
     // Notes for fInfoRecord : 
     private string _priorvendor; 
     [XafDisplayName("Prior Vendor"), ToolTip("Prior Vendor")] 
     // [Appearance("fInfoRecordpriorvendor", Enabled = true)]
     // [Appearance("fInfoRecordpriorvendorVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string priorvendor
     { 
       get { return _priorvendor; } 
       set { SetPropertyValue(nameof(priorvendor), ref _priorvendor, value); } 
     } 
     // Purchase Order Unit of Measure
     // Notes for fInfoRecord : 
     private string _orderunit; 
     [XafDisplayName("Order Unit"), ToolTip("Order Unit")] 
     // [Appearance("fInfoRecordorderunit", Enabled = true)]
     // [Appearance("fInfoRecordorderunitVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string orderunit
     { 
       get { return _orderunit; } 
       set { SetPropertyValue(nameof(orderunit), ref _orderunit, value); } 
     } 
     // Purchase Order Unit of Measure
     // Notes for fInfoRecord : 
     private string _conversion; 
     [XafDisplayName("Conversion"), ToolTip("Conversion")] 
     // [Appearance("fInfoRecordconversion", Enabled = true)]
     // [Appearance("fInfoRecordconversionVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string conversion
     { 
       get { return _conversion; } 
       set { SetPropertyValue(nameof(conversion), ref _conversion, value); } 
     } 
     // Purchase Order Unit of Measure
     // Notes for fInfoRecord : 
     private string _varorderunit; 
     [XafDisplayName("Var. Order Unit"), ToolTip("Var. Order Unit")] 
     // [Appearance("fInfoRecordvarorderunit", Enabled = true)]
     // [Appearance("fInfoRecordvarorderunitVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string varorderunit
     { 
       get { return _varorderunit; } 
       set { SetPropertyValue(nameof(varorderunit), ref _varorderunit, value); } 
     } 
     // Origin Data
     // Notes for fInfoRecord : 
     private string _cerifcat; 
     [XafDisplayName("Cerif. Cat."), ToolTip("Cerif. Cat.")] 
     // [Appearance("fInfoRecordcerifcat", Enabled = true)]
     // [Appearance("fInfoRecordcerifcatVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string cerifcat
     { 
       get { return _cerifcat; } 
       set { SetPropertyValue(nameof(cerifcat), ref _cerifcat, value); } 
     } 
     // Origin Data
     // Notes for fInfoRecord : 
     private string _certificate; 
     [XafDisplayName("Certificate"), ToolTip("Certificate")] 
     // [Appearance("fInfoRecordcertificate", Enabled = true)]
     // [Appearance("fInfoRecordcertificateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string certificate
     { 
       get { return _certificate; } 
       set { SetPropertyValue(nameof(certificate), ref _certificate, value); } 
     } 
     // Origin Data
     // Notes for fInfoRecord : 
     private DateTime _validto; 
     [XafDisplayName("Valid to"), ToolTip("Valid to")] 
     // [Appearance("fInfoRecordvalidto", Enabled = true)]
     // [Appearance("fInfoRecordvalidtoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime validto
     { 
       get { return _validto; } 
       set { SetPropertyValue(nameof(validto), ref _validto, value); } 
     } 
     // Origin Data
     // Notes for fInfoRecord : 
     private fCountry _ctrfoforg; 
     [XafDisplayName("Ctrf of Origin"), ToolTip("Ctrf of Origin")] 
     // [Appearance("fInfoRecordctrfoforg", Enabled = true)]
     // [Appearance("fInfoRecordctrfoforgVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCountry ctrfoforg
     { 
       get { return _ctrfoforg; } 
       set { SetPropertyValue(nameof(ctrfoforg), ref _ctrfoforg, value); } 
     } 
     // Origin Data
     // Notes for fInfoRecord : 
     private fRegion _region; 
     [XafDisplayName("Region"), ToolTip("Region")] 
     // [Appearance("fInfoRecordregion", Enabled = true)]
     // [Appearance("fInfoRecordregionVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fRegion region
     { 
       get { return _region; } 
       set { SetPropertyValue(nameof(region), ref _region, value); } 
     } 
     // Origin Data
     // Notes for fInfoRecord : 
     private string _number; 
     [XafDisplayName("Number"), ToolTip("Number")] 
     // [Appearance("fInfoRecordnumber", Enabled = true)]
     // [Appearance("fInfoRecordnumberVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string number
     { 
       get { return _number; } 
       set { SetPropertyValue(nameof(number), ref _number, value); } 
     } 
     // Origin Data
     // Notes for fInfoRecord : 
     private string _manufacturer; 
     [XafDisplayName("Manufacturer"), ToolTip("Manufacturer")] 
     // [Appearance("fInfoRecordmanufacturer", Enabled = true)]
     // [Appearance("fInfoRecordmanufacturerVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string manufacturer
     { 
       get { return _manufacturer; } 
       set { SetPropertyValue(nameof(manufacturer), ref _manufacturer, value); } 
     } 
     // Supply Option
     // Notes for fInfoRecord : 
     private DateTime _availablefrom; 
     [XafDisplayName("Available from"), ToolTip("Available from")] 
     // [Appearance("fInfoRecordavailablefrom", Enabled = true)]
     // [Appearance("fInfoRecordavailablefromVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime availablefrom
     { 
       get { return _availablefrom; } 
       set { SetPropertyValue(nameof(availablefrom), ref _availablefrom, value); } 
     } 
     // Supply Option
     // Notes for fInfoRecord : 
     private DateTime _availableto; 
     [XafDisplayName("Available to"), ToolTip("Available to")] 
     // [Appearance("fInfoRecordavailableto", Enabled = true)]
     // [Appearance("fInfoRecordavailabletoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime availableto
     { 
       get { return _availableto; } 
       set { SetPropertyValue(nameof(availableto), ref _availableto, value); } 
     } 
     // Supply Option
     // Notes for fInfoRecord : 
     private bool _regularvendor; 
     [XafDisplayName("Regular Vendor"), ToolTip("Regular Vendor")] 
     // [Appearance("fInfoRecordregularvendor", Enabled = true)]
     // [Appearance("fInfoRecordregularvendorVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool regularvendor
     { 
       get { return _regularvendor; } 
       set { SetPropertyValue(nameof(regularvendor), ref _regularvendor, value); } 
     } 
     // Control
     // Notes for fInfoRecord : 
     private string _pidelivtime; 
     [XafDisplayName("PI. Deliv. Time"), ToolTip("PI. Deliv. Time")] 
     // [Appearance("fInfoRecordpidelivtime", Enabled = true)]
     // [Appearance("fInfoRecordpidelivtimeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string pidelivtime
     { 
       get { return _pidelivtime; } 
       set { SetPropertyValue(nameof(pidelivtime), ref _pidelivtime, value); } 
     } 
     // Control
     // Notes for fInfoRecord : 
     private string _tolunderdl; 
     [XafDisplayName("Tol. Underdl."), ToolTip("Tol. Underdl.")] 
     // [Appearance("fInfoRecordtolunderdl", Enabled = true)]
     // [Appearance("fInfoRecordtolunderdlVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string tolunderdl
     { 
       get { return _tolunderdl; } 
       set { SetPropertyValue(nameof(tolunderdl), ref _tolunderdl, value); } 
     } 
     // Control
     // Notes for fInfoRecord : 
     private bool _nomtext; 
     [XafDisplayName("No Mtext"), ToolTip("No Mtext")] 
     // [Appearance("fInfoRecordnomtext", Enabled = true)]
     // [Appearance("fInfoRecordnomtextVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool nomtext
     { 
       get { return _nomtext; } 
       set { SetPropertyValue(nameof(nomtext), ref _nomtext, value); } 
     } 
     // Control
     // Notes for fInfoRecord : 
     private string _purchgroup; 
     [XafDisplayName("Purch. Group"), ToolTip("Purch. Group")] 
     // [Appearance("fInfoRecordpurchgroup", Enabled = true)]
     // [Appearance("fInfoRecordpurchgroupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string purchgroup
     { 
       get { return _purchgroup; } 
       set { SetPropertyValue(nameof(purchgroup), ref _purchgroup, value); } 
     } 
     // Control
     // Notes for fInfoRecord : 
     private string _toloverdl; 
     [XafDisplayName("Tol. Overdl"), ToolTip("Tol. Overdl")] 
     // [Appearance("fInfoRecordtoloverdl", Enabled = true)]
     // [Appearance("fInfoRecordtoloverdlVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string toloverdl
     { 
       get { return _toloverdl; } 
       set { SetPropertyValue(nameof(toloverdl), ref _toloverdl, value); } 
     } 
     // Control
     // Notes for fInfoRecord : 
     private bool _acknrqd; 
     [XafDisplayName("Ackn. Rqd"), ToolTip("Ackn. Rqd")] 
     // [Appearance("fInfoRecordacknrqd", Enabled = true)]
     // [Appearance("fInfoRecordacknrqdVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool acknrqd
     { 
       get { return _acknrqd; } 
       set { SetPropertyValue(nameof(acknrqd), ref _acknrqd, value); } 
     } 
     // Control
     // Notes for fInfoRecord : 
     private string _standardqty; 
     [XafDisplayName("Standard Qty"), ToolTip("Standard Qty")] 
     // [Appearance("fInfoRecordstandardqty", Enabled = true)]
     // [Appearance("fInfoRecordstandardqtyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string standardqty
     { 
       get { return _standardqty; } 
       set { SetPropertyValue(nameof(standardqty), ref _standardqty, value); } 
     } 
     // Control
     // Notes for fInfoRecord : 
     private bool _unlimited; 
     [XafDisplayName("Unlimited"), ToolTip("Unlimited")] 
     // [Appearance("fInfoRecordunlimited", Enabled = true)]
     // [Appearance("fInfoRecordunlimitedVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool unlimited
     { 
       get { return _unlimited; } 
       set { SetPropertyValue(nameof(unlimited), ref _unlimited, value); } 
     } 
     // Control
     // Notes for fInfoRecord : 
     private string _confctrl; 
     [XafDisplayName("Conf. Ctrl"), ToolTip("Conf. Ctrl")] 
     // [Appearance("fInfoRecordconfctrl", Enabled = true)]
     // [Appearance("fInfoRecordconfctrlVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string confctrl
     { 
       get { return _confctrl; } 
       set { SetPropertyValue(nameof(confctrl), ref _confctrl, value); } 
     } 
     // Control
     // Notes for fInfoRecord : 
     private string _minimumqty; 
     [XafDisplayName("Minimum Qty"), ToolTip("Minimum Qty")] 
     // [Appearance("fInfoRecordminimumqty", Enabled = true)]
     // [Appearance("fInfoRecordminimumqtyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string minimumqty
     { 
       get { return _minimumqty; } 
       set { SetPropertyValue(nameof(minimumqty), ref _minimumqty, value); } 
     } 
     // Control
     // Notes for fInfoRecord : 
     private bool _grbsdiv; 
     [XafDisplayName("GR-Bsd IV"), ToolTip("GR-Bsd IV")] 
     // [Appearance("fInfoRecordgrbsdiv", Enabled = true)]
     // [Appearance("fInfoRecordgrbsdivVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool grbsdiv
     { 
       get { return _grbsdiv; } 
       set { SetPropertyValue(nameof(grbsdiv), ref _grbsdiv, value); } 
     } 
     // Control
     // Notes for fInfoRecord : 
     private string _taxcode; 
     [XafDisplayName("Tax Code"), ToolTip("Tax Code")] 
     // [Appearance("fInfoRecordtaxcode", Enabled = true)]
     // [Appearance("fInfoRecordtaxcodeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string taxcode
     { 
       get { return _taxcode; } 
       set { SetPropertyValue(nameof(taxcode), ref _taxcode, value); } 
     } 
     // Control
     // Notes for fInfoRecord : 
     private string _remshelflife; 
     [XafDisplayName("Rem. Shelf Life"), ToolTip("Rem. Shelf Life")] 
     // [Appearance("fInfoRecordremshelflife", Enabled = true)]
     // [Appearance("fInfoRecordremshelflifeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string remshelflife
     { 
       get { return _remshelflife; } 
       set { SetPropertyValue(nameof(remshelflife), ref _remshelflife, value); } 
     } 
     // Control
     // Notes for fInfoRecord : 
     private bool _noers; 
     [XafDisplayName("No ERS"), ToolTip("No ERS")] 
     // [Appearance("fInfoRecordnoers", Enabled = true)]
     // [Appearance("fInfoRecordnoersVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool noers
     { 
       get { return _noers; } 
       set { SetPropertyValue(nameof(noers), ref _noers, value); } 
     } 
     // Control
     // Notes for fInfoRecord : 
     private string _shippginstr; 
     [XafDisplayName("Shippg Instr."), ToolTip("Shippg Instr.")] 
     // [Appearance("fInfoRecordshippginstr", Enabled = true)]
     // [Appearance("fInfoRecordshippginstrVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string shippginstr
     { 
       get { return _shippginstr; } 
       set { SetPropertyValue(nameof(shippginstr), ref _shippginstr, value); } 
     } 
     // Control
     // Notes for fInfoRecord : 
     private string _procedure; 
     [XafDisplayName("Procedure"), ToolTip("Procedure")] 
     // [Appearance("fInfoRecordprocedure", Enabled = true)]
     // [Appearance("fInfoRecordprocedureVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string procedure
     { 
       get { return _procedure; } 
       set { SetPropertyValue(nameof(procedure), ref _procedure, value); } 
     } 
     // Control
     // Notes for fInfoRecord : 
     private string _maxquantity; 
     [XafDisplayName("Max. Quantity"), ToolTip("Max. Quantity")] 
     // [Appearance("fInfoRecordmaxquantity", Enabled = true)]
     // [Appearance("fInfoRecordmaxquantityVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string maxquantity
     { 
       get { return _maxquantity; } 
       set { SetPropertyValue(nameof(maxquantity), ref _maxquantity, value); } 
     } 
     // Control
     // Notes for fInfoRecord : 
     private string _rndgprof; 
     [XafDisplayName("Rndg Prof."), ToolTip("Rndg Prof.")] 
     // [Appearance("fInfoRecordrndgprof", Enabled = true)]
     // [Appearance("fInfoRecordrndgprofVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string rndgprof
     { 
       get { return _rndgprof; } 
       set { SetPropertyValue(nameof(rndgprof), ref _rndgprof, value); } 
     } 
     // Control
     // Notes for fInfoRecord : 
     private string _uomuomgroup; 
     [XafDisplayName("UoM Group"), ToolTip("UoM Group")] 
     // [Appearance("fInfoRecorduomuomgroup", Enabled = true)]
     // [Appearance("fInfoRecorduomuomgroupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string uomuomgroup
     { 
       get { return _uomuomgroup; } 
       set { SetPropertyValue(nameof(uomuomgroup), ref _uomuomgroup, value); } 
     } 
     // Conditions
     // Notes for fInfoRecord : 
     private double _netprice; 
     [XafDisplayName("Net Price"), ToolTip("Net Price")] 
     // [Appearance("fInfoRecordnetprice", Enabled = true)]
     // [Appearance("fInfoRecordnetpriceVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double netprice
     { 
       get { return _netprice; } 
       set { SetPropertyValue(nameof(netprice), ref _netprice, value); } 
     } 
     // Conditions
     // Notes for fInfoRecord : 
     private DateTime _validto1; 
     [XafDisplayName("Valid to"), ToolTip("Valid to")] 
     // [Appearance("fInfoRecordvalidto", Enabled = true)]
     // [Appearance("fInfoRecordvalidtoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime validto1
     { 
       get { return _validto1; } 
       set { SetPropertyValue(nameof(validto1), ref _validto1, value); } 
     } 
     // Conditions
     // Notes for fInfoRecord : 
     private double _effectiveprice; 
     [XafDisplayName("Effective Price"), ToolTip("Effective Price")] 
     // [Appearance("fInfoRecordeffectiveprice", Enabled = true)]
     // [Appearance("fInfoRecordeffectivepriceVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double effectiveprice
     { 
       get { return _effectiveprice; } 
       set { SetPropertyValue(nameof(effectiveprice), ref _effectiveprice, value); } 
     } 
     // Conditions
     // Notes for fInfoRecord : 
     private bool _nocashdisc; 
     [XafDisplayName("No Cash Disc."), ToolTip("No Cash Disc.")] 
     // [Appearance("fInfoRecordnocashdisc", Enabled = true)]
     // [Appearance("fInfoRecordnocashdiscVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool nocashdisc
     { 
       get { return _nocashdisc; } 
       set { SetPropertyValue(nameof(nocashdisc), ref _nocashdisc, value); } 
     } 
     // Conditions
     // Notes for fInfoRecord : 
     private string _qtyconv; 
     [XafDisplayName("Qty Conv. "), ToolTip("Qty Conv. ")] 
     // [Appearance("fInfoRecordqtyconv", Enabled = true)]
     // [Appearance("fInfoRecordqtyconvVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string qtyconv
     { 
       get { return _qtyconv; } 
       set { SetPropertyValue(nameof(qtyconv), ref _qtyconv, value); } 
     } 
     // Conditions
     // Notes for fInfoRecord : 
     private string _condgrp; 
     [XafDisplayName("Cond. Grp"), ToolTip("Cond. Grp")] 
     // [Appearance("fInfoRecordcondgrp", Enabled = true)]
     // [Appearance("fInfoRecordcondgrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string condgrp
     { 
       get { return _condgrp; } 
       set { SetPropertyValue(nameof(condgrp), ref _condgrp, value); } 
     } 
     // Conditions
     // Notes for fInfoRecord : 
     private string _prdatecat; 
     [XafDisplayName("Pr. Date Cat."), ToolTip("Pr. Date Cat.")] 
     // [Appearance("fInfoRecordprdatecat", Enabled = true)]
     // [Appearance("fInfoRecordprdatecatVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string prdatecat
     { 
       get { return _prdatecat; } 
       set { SetPropertyValue(nameof(prdatecat), ref _prdatecat, value); } 
     } 
     // Conditions
     // Notes for fInfoRecord : 
     private string _incoterms; 
     [XafDisplayName("Incoterms"), ToolTip("Incoterms")] 
     // [Appearance("fInfoRecordincoterms", Enabled = true)]
     // [Appearance("fInfoRecordincotermsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string incoterms
     { 
       get { return _incoterms; } 
       set { SetPropertyValue(nameof(incoterms), ref _incoterms, value); } 
     } 
   } 
} 
