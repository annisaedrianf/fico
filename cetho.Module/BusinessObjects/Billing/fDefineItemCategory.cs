// Class Name : fDefineItemCategory.cs 
// Project Name : FICO 
// Last Update : 29/05/2023 14:42:44  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 29/05/2023 14:42:44 
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
   [System.ComponentModel.DisplayName("New Entries: Details of Added Entries")]
   public class fDefineItemCategory : XPObject
   {
     public fDefineItemCategory(Session session) : base(session) 
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
     [Appearance("VisiblefDefineItemCategoryOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for fDefineItemCategory : 
     private string _salesdoctype; 
     [XafDisplayName("Sales Document Type"), ToolTip("Sales Document Type")] 
     // [Appearance("fDefineItemCategorysalesdoctype", Enabled = true)]
     // [Appearance("fDefineItemCategorysalesdoctypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string salesdoctype
     { 
       get { return _salesdoctype; } 
       set { SetPropertyValue(nameof(salesdoctype), ref _salesdoctype, value); } 
     } 
     // 
     // Notes for fDefineItemCategory : 
     private string _salesdoccateg; 
     [XafDisplayName("Sales Document Categ"), ToolTip("Sales document categ")] 
     // [Appearance("fDefineItemCategorysalesdoccateg", Enabled = true)]
     // [Appearance("fDefineItemCategorysalesdoccategVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string salesdoccateg
     { 
       get { return _salesdoccateg; } 
       set { SetPropertyValue(nameof(salesdoccateg), ref _salesdoccateg, value); } 
     } 
     // 
     // Notes for fDefineItemCategory : 
     private string _salesdocblock; 
     [XafDisplayName("Sales Document Block"), ToolTip("Sales document block")] 
     // [Appearance("fDefineItemCategorysalesdocblock", Enabled = true)]
     // [Appearance("fDefineItemCategorysalesdocblockVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string salesdocblock
     { 
       get { return _salesdocblock; } 
       set { SetPropertyValue(nameof(salesdocblock), ref _salesdocblock, value); } 
     } 
     // Number systems
     // Notes for fDefineItemCategory : 
     private string _rangeintassgt; 
     [XafDisplayName("No.Range Int. Assgt"), ToolTip("No.range int.assgt")] 
     // [Appearance("fDefineItemCategoryrangeintassgt", Enabled = true)]
     // [Appearance("fDefineItemCategoryrangeintassgtVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string rangeintassgt
     { 
       get { return _rangeintassgt; } 
       set { SetPropertyValue(nameof(rangeintassgt), ref _rangeintassgt, value); } 
     } 
     // Number systems
     // Notes for fDefineItemCategory : 
     private string _rangeextassg; 
     [XafDisplayName("No.Range Ext. Assg"), ToolTip("No.range ext.assg")] 
     // [Appearance("fDefineItemCategoryrangeextassg", Enabled = true)]
     // [Appearance("fDefineItemCategoryrangeextassgVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string rangeextassg
     { 
       get { return _rangeextassg; } 
       set { SetPropertyValue(nameof(rangeextassg), ref _rangeextassg, value); } 
     } 
     // Number systems
     // Notes for fDefineItemCategory : 
     private string _itmnoincremnt; 
     [XafDisplayName("Item No. Increment"), ToolTip("Item no.increment")] 
     // [Appearance("fDefineItemCategoryitmnoincremnt", Enabled = true)]
     // [Appearance("fDefineItemCategoryitmnoincremntVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string itmnoincremnt
     { 
       get { return _itmnoincremnt; } 
       set { SetPropertyValue(nameof(itmnoincremnt), ref _itmnoincremnt, value); } 
     } 
     // Number systems
     // Notes for fDefineItemCategory : 
     private string _subitmincrmnt; 
     [XafDisplayName("Sub-Item Increment"), ToolTip("Sub-item increment")] 
     // [Appearance("fDefineItemCategorysubitmincrmnt", Enabled = true)]
     // [Appearance("fDefineItemCategorysubitmincrmntVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string subitmincrmnt
     { 
       get { return _subitmincrmnt; } 
       set { SetPropertyValue(nameof(subitmincrmnt), ref _subitmincrmnt, value); } 
     } 
     // General control
     // Notes for fDefineItemCategory : 
     private string _refmandatory; 
     [XafDisplayName("Reference Mandatory"), ToolTip("Reference mandatory")] 
     // [Appearance("fDefineItemCategoryrefmandatory", Enabled = true)]
     // [Appearance("fDefineItemCategoryrefmandatoryVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string refmandatory
     { 
       get { return _refmandatory; } 
       set { SetPropertyValue(nameof(refmandatory), ref _refmandatory, value); } 
     } 
     // General control
     // Notes for fDefineItemCategory : 
     private string _checkdivsion; 
     [XafDisplayName("Check Division"), ToolTip("Check division")] 
     // [Appearance("fDefineItemCategorycheckdivsion", Enabled = true)]
     // [Appearance("fDefineItemCategorycheckdivsionVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string checkdivsion
     { 
       get { return _checkdivsion; } 
       set { SetPropertyValue(nameof(checkdivsion), ref _checkdivsion, value); } 
     } 
     // General control
     // Notes for fDefineItemCategory : 
     private string _probability; 
     [XafDisplayName("Probability"), ToolTip("Probability")] 
     // [Appearance("fDefineItemCategoryprobability", Enabled = true)]
     // [Appearance("fDefineItemCategoryprobabilityVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string probability
     { 
       get { return _probability; } 
       set { SetPropertyValue(nameof(probability), ref _probability, value); } 
     } 
     // General control
     // Notes for fDefineItemCategory : 
     private string _chckcreditlimit; 
     [XafDisplayName("Check Credit Limit"), ToolTip("Check credit limit")] 
     // [Appearance("fDefineItemCategorychckcreditlimit", Enabled = true)]
     // [Appearance("fDefineItemCategorychckcreditlimitVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string chckcreditlimit
     { 
       get { return _chckcreditlimit; } 
       set { SetPropertyValue(nameof(chckcreditlimit), ref _chckcreditlimit, value); } 
     } 
     // General control
     // Notes for fDefineItemCategory : 
     private string _creditgrp; 
     [XafDisplayName("Credit Group"), ToolTip("Credit group")] 
     // [Appearance("fDefineItemCategorycreditgrp", Enabled = true)]
     // [Appearance("fDefineItemCategorycreditgrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string creditgrp
     { 
       get { return _creditgrp; } 
       set { SetPropertyValue(nameof(creditgrp), ref _creditgrp, value); } 
     } 
     // General control
     // Notes for fDefineItemCategory : 
     private string _outputappl; 
     [XafDisplayName("Output Application"), ToolTip("Output application")] 
     // [Appearance("fDefineItemCategoryoutputappl", Enabled = true)]
     // [Appearance("fDefineItemCategoryoutputapplVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string outputappl
     { 
       get { return _outputappl; } 
       set { SetPropertyValue(nameof(outputappl), ref _outputappl, value); } 
     } 
     // General control
     // Notes for fDefineItemCategory : 
     private string _matlentrytype; 
     [XafDisplayName("Material Entry Type"), ToolTip("Material entry type")] 
     // [Appearance("fDefineItemCategorymatlentrytype", Enabled = true)]
     // [Appearance("fDefineItemCategorymatlentrytypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string matlentrytype
     { 
       get { return _matlentrytype; } 
       set { SetPropertyValue(nameof(matlentrytype), ref _matlentrytype, value); } 
     } 
     // General control
     // Notes for fDefineItemCategory : 
     private bool _itemdivision; 
     [XafDisplayName("Item Division"), ToolTip("Item division")] 
     // [Appearance("fDefineItemCategoryitemdivision", Enabled = true)]
     // [Appearance("fDefineItemCategoryitemdivisionVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool itemdivision
     { 
       get { return _itemdivision; } 
       set { SetPropertyValue(nameof(itemdivision), ref _itemdivision, value); } 
     } 
     // General control
     // Notes for fDefineItemCategory : 
     private bool _readinforecord; 
     [XafDisplayName("Read Info Record"), ToolTip("Read info record")] 
     // [Appearance("fDefineItemCategoryreadinforecord", Enabled = true)]
     // [Appearance("fDefineItemCategoryreadinforecordVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool readinforecord
     { 
       get { return _readinforecord; } 
       set { SetPropertyValue(nameof(readinforecord), ref _readinforecord, value); } 
     } 
     // General control
     // Notes for fDefineItemCategory : 
     private string _checkpurchorder; 
     [XafDisplayName("Check Purch. Order No"), ToolTip("Check purch. Order no")] 
     // [Appearance("fDefineItemCategorycheckpurchorder", Enabled = true)]
     // [Appearance("fDefineItemCategorycheckpurchorderVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string checkpurchorder
     { 
       get { return _checkpurchorder; } 
       set { SetPropertyValue(nameof(checkpurchorder), ref _checkpurchorder, value); } 
     } 
     // General control
     // Notes for fDefineItemCategory : 
     private bool _enterponumb; 
     [XafDisplayName("Enter PO number"), ToolTip("Enter PO number")] 
     // [Appearance("fDefineItemCategoryenterponumb", Enabled = true)]
     // [Appearance("fDefineItemCategoryenterponumbVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool enterponumb
     { 
       get { return _enterponumb; } 
       set { SetPropertyValue(nameof(enterponumb), ref _enterponumb, value); } 
     } 
     // General control
     // Notes for fDefineItemCategory : 
     private string _commitdate; 
     [XafDisplayName("Commitment Date"), ToolTip("Commitment date")] 
     // [Appearance("fDefineItemCategorycommitdate", Enabled = true)]
     // [Appearance("fDefineItemCategorycommitdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string commitdate
     { 
       get { return _commitdate; } 
       set { SetPropertyValue(nameof(commitdate), ref _commitdate, value); } 
     } 
     // Transaction flow
     // Notes for fDefineItemCategory : 
     private string _screenseqgrp; 
     [XafDisplayName("Screen Sequence Grp."), ToolTip("Screen sequence grp.")] 
     // [Appearance("fDefineItemCategoryscreenseqgrp", Enabled = true)]
     // [Appearance("fDefineItemCategoryscreenseqgrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string screenseqgrp
     { 
       get { return _screenseqgrp; } 
       set { SetPropertyValue(nameof(screenseqgrp), ref _screenseqgrp, value); } 
     } 
     // Transaction flow
     // Notes for fDefineItemCategory : 
     private string _incomplproced; 
     [XafDisplayName("Incompl. Proced"), ToolTip("Incompl. Proced")] 
     // [Appearance("fDefineItemCategoryincomplproced", Enabled = true)]
     // [Appearance("fDefineItemCategoryincomplprocedVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string incomplproced
     { 
       get { return _incomplproced; } 
       set { SetPropertyValue(nameof(incomplproced), ref _incomplproced, value); } 
     } 
     // Transaction flow
     // Notes for fDefineItemCategory : 
     private string _transactgrp; 
     [XafDisplayName("Transaction Group"), ToolTip("Transaction group")] 
     // [Appearance("fDefineItemCategorytransactgrp", Enabled = true)]
     // [Appearance("fDefineItemCategorytransactgrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string transactgrp
     { 
       get { return _transactgrp; } 
       set { SetPropertyValue(nameof(transactgrp), ref _transactgrp, value); } 
     } 
     // Transaction flow
     // Notes for fDefineItemCategory : 
     private string _docpricproced; 
     [XafDisplayName("Doc. Pric. Procedure"), ToolTip("Doc.pric.procedure")] 
     // [Appearance("fDefineItemCategorydocpricproced", Enabled = true)]
     // [Appearance("fDefineItemCategorydocpricprocedVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string docpricproced
     { 
       get { return _docpricproced; } 
       set { SetPropertyValue(nameof(docpricproced), ref _docpricproced, value); } 
     } 
     // Transaction flow
     // Notes for fDefineItemCategory : 
     private string _statusprof; 
     [XafDisplayName("Status Profile"), ToolTip("Status profile")] 
     // [Appearance("fDefineItemCategorystatusprof", Enabled = true)]
     // [Appearance("fDefineItemCategorystatusprofVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string statusprof
     { 
       get { return _statusprof; } 
       set { SetPropertyValue(nameof(statusprof), ref _statusprof, value); } 
     } 
     // Transaction flow
     // Notes for fDefineItemCategory : 
     private string _altsalesdoctype1; 
     [XafDisplayName("Alt. Sales Doc. Type 1"), ToolTip("Alt.sales doc.type 1")] 
     // [Appearance("fDefineItemCategoryaltsalesdoctype1", Enabled = true)]
     // [Appearance("fDefineItemCategoryaltsalesdoctype1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string altsalesdoctype1
     { 
       get { return _altsalesdoctype1; } 
       set { SetPropertyValue(nameof(altsalesdoctype1), ref _altsalesdoctype1, value); } 
     } 
     // Transaction flow
     // Notes for fDefineItemCategory : 
     private string _altsalesdoctype2; 
     [XafDisplayName("Alt. Sales Doc. Type 2"), ToolTip("Alt.sales doc.type 2")] 
     // [Appearance("fDefineItemCategoryaltsalesdoctype2", Enabled = true)]
     // [Appearance("fDefineItemCategoryaltsalesdoctype2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string altsalesdoctype2
     { 
       get { return _altsalesdoctype2; } 
       set { SetPropertyValue(nameof(altsalesdoctype2), ref _altsalesdoctype2, value); } 
     } 
     // Transaction flow
     // Notes for fDefineItemCategory : 
     private string _variant; 
     [XafDisplayName("Variant"), ToolTip("Variant")] 
     // [Appearance("fDefineItemCategoryvariant", Enabled = true)]
     // [Appearance("fDefineItemCategoryvariantVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string variant
     { 
       get { return _variant; } 
       set { SetPropertyValue(nameof(variant), ref _variant, value); } 
     } 
     // Transaction flow
     // Notes for fDefineItemCategory : 
     private string _dsplyrange; 
     [XafDisplayName("Display Range"), ToolTip("Display Range")] 
     // [Appearance("fDefineItemCategorydsplyrange", Enabled = true)]
     // [Appearance("fDefineItemCategorydsplyrangeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string dsplyrange
     { 
       get { return _dsplyrange; } 
       set { SetPropertyValue(nameof(dsplyrange), ref _dsplyrange, value); } 
     } 
     // Transaction flow
     // Notes for fDefineItemCategory : 
     private string _codeforovervscr; 
     [XafDisplayName("Code For Overv. Scr."), ToolTip("Fcode for overv.scr.")] 
     // [Appearance("fDefineItemCategorycodeforovervscr", Enabled = true)]
     // [Appearance("fDefineItemCategorycodeforovervscrVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string codeforovervscr
     { 
       get { return _codeforovervscr; } 
       set { SetPropertyValue(nameof(codeforovervscr), ref _codeforovervscr, value); } 
     } 
     // Transaction flow
     // Notes for fDefineItemCategory : 
     private string _quotmsg; 
     [XafDisplayName("Quotation Messages"), ToolTip("Quotation messages")] 
     // [Appearance("fDefineItemCategoryquotmsg", Enabled = true)]
     // [Appearance("fDefineItemCategoryquotmsgVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string quotmsg
     { 
       get { return _quotmsg; } 
       set { SetPropertyValue(nameof(quotmsg), ref _quotmsg, value); } 
     } 
     // Transaction flow
     // Notes for fDefineItemCategory : 
     private string _outlineagrmtmess; 
     [XafDisplayName("Outline Agrmt Mess."), ToolTip("Outline agrmt mess.")] 
     // [Appearance("fDefineItemCategoryoutlineagrmtmess", Enabled = true)]
     // [Appearance("fDefineItemCategoryoutlineagrmtmessVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string outlineagrmtmess
     { 
       get { return _outlineagrmtmess; } 
       set { SetPropertyValue(nameof(outlineagrmtmess), ref _outlineagrmtmess, value); } 
     } 
     // Transaction flow
     // Notes for fDefineItemCategory : 
     private string _msgmastcontr; 
     [XafDisplayName("Message: Mast. Contr."), ToolTip("Message: Mast.contr.")] 
     // [Appearance("fDefineItemCategorymsgmastcontr", Enabled = true)]
     // [Appearance("fDefineItemCategorymsgmastcontrVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string msgmastcontr
     { 
       get { return _msgmastcontr; } 
       set { SetPropertyValue(nameof(msgmastcontr), ref _msgmastcontr, value); } 
     } 
     // Transaction flow
     // Notes for fDefineItemCategory : 
     private string _prodattrmsg; 
     [XafDisplayName("ProdAttr. Messages"), ToolTip("ProdAttr.messages")] 
     // [Appearance("fDefineItemCategoryprodattrmsg", Enabled = true)]
     // [Appearance("fDefineItemCategoryprodattrmsgVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string prodattrmsg
     { 
       get { return _prodattrmsg; } 
       set { SetPropertyValue(nameof(prodattrmsg), ref _prodattrmsg, value); } 
     } 
     // Transaction flow
     // Notes for fDefineItemCategory : 
     private bool _incmpltmsg; 
     [XafDisplayName("Incomplete Messages"), ToolTip("Incomplet.messages")] 
     // [Appearance("fDefineItemCategoryincmpltmsg", Enabled = true)]
     // [Appearance("fDefineItemCategoryincmpltmsgVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool incmpltmsg
     { 
       get { return _incmpltmsg; } 
       set { SetPropertyValue(nameof(incmpltmsg), ref _incmpltmsg, value); } 
     } 
     // Schedulling Agreement
     // Notes for fDefineItemCategory : 
     private string _corrdelivtype; 
     [XafDisplayName("Corr. Delivery Type"), ToolTip("Corr.delivery type")] 
     // [Appearance("fDefineItemCategorycorrdelivtype", Enabled = true)]
     // [Appearance("fDefineItemCategorycorrdelivtypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string corrdelivtype
     { 
       get { return _corrdelivtype; } 
       set { SetPropertyValue(nameof(corrdelivtype), ref _corrdelivtype, value); } 
     } 
     // Schedulling Agreement
     // Notes for fDefineItemCategory : 
     private string _usage; 
     [XafDisplayName("Usage"), ToolTip("Usage")] 
     // [Appearance("fDefineItemCategoryusage", Enabled = true)]
     // [Appearance("fDefineItemCategoryusageVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string usage
     { 
       get { return _usage; } 
       set { SetPropertyValue(nameof(usage), ref _usage, value); } 
     } 
     // Schedulling Agreement
     // Notes for fDefineItemCategory : 
     private string _mrpfordlvschtype; 
     [XafDisplayName("MRP for DlvSchType"), ToolTip("MRP for DlvSchType")] 
     // [Appearance("fDefineItemCategorymrpfordlvschtype", Enabled = true)]
     // [Appearance("fDefineItemCategorymrpfordlvschtypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string mrpfordlvschtype
     { 
       get { return _mrpfordlvschtype; } 
       set { SetPropertyValue(nameof(mrpfordlvschtype), ref _mrpfordlvschtype, value); } 
     } 
     // Schedulling Agreement
     // Notes for fDefineItemCategory : 
     private string _delivblock; 
     [XafDisplayName("Delivery Block"), ToolTip("Delivery block")] 
     // [Appearance("fDefineItemCategorydelivblock", Enabled = true)]
     // [Appearance("fDefineItemCategorydelivblockVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string delivblock
     { 
       get { return _delivblock; } 
       set { SetPropertyValue(nameof(delivblock), ref _delivblock, value); } 
     } 
     // Shipping
     // Notes for fDefineItemCategory : 
     private string _delivtype; 
     [XafDisplayName("Delivery Type"), ToolTip("Delivery type")] 
     // [Appearance("fDefineItemCategorydelivtype", Enabled = true)]
     // [Appearance("fDefineItemCategorydelivtypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string delivtype
     { 
       get { return _delivtype; } 
       set { SetPropertyValue(nameof(delivtype), ref _delivtype, value); } 
     } 
     // Shipping
     // Notes for fDefineItemCategory : 
     private string _delivbock; 
     [XafDisplayName("Delivery Block"), ToolTip("Delivery block")] 
     // [Appearance("fDefineItemCategorydelivbock", Enabled = true)]
     // [Appearance("fDefineItemCategorydelivbockVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string delivbock
     { 
       get { return _delivbock; } 
       set { SetPropertyValue(nameof(delivbock), ref _delivbock, value); } 
     } 
     // Shipping
     // Notes for fDefineItemCategory : 
     private string _shipcond; 
     [XafDisplayName("Shipping Conditions"), ToolTip("Shipping conditions")] 
     // [Appearance("fDefineItemCategoryshipcond", Enabled = true)]
     // [Appearance("fDefineItemCategoryshipcondVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string shipcond
     { 
       get { return _shipcond; } 
       set { SetPropertyValue(nameof(shipcond), ref _shipcond, value); } 
     } 
     // Shipping
     // Notes for fDefineItemCategory : 
     private string _shipcostinfoprofile; 
     [XafDisplayName("Ship. Cost Info Profile"), ToolTip("ShipCostInfoProfile")] 
     // [Appearance("fDefineItemCategoryshipcostinfoprofile", Enabled = true)]
     // [Appearance("fDefineItemCategoryshipcostinfoprofileVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string shipcostinfoprofile
     { 
       get { return _shipcostinfoprofile; } 
       set { SetPropertyValue(nameof(shipcostinfoprofile), ref _shipcostinfoprofile, value); } 
     } 
     // Shipping
     // Notes for fDefineItemCategory : 
     private string _mediatedeliv; 
     [XafDisplayName("Immediate Delivevry"), ToolTip("Immediate delivevry")] 
     // [Appearance("fDefineItemCategorymediatedeliv", Enabled = true)]
     // [Appearance("fDefineItemCategorymediatedelivVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string mediatedeliv
     { 
       get { return _mediatedeliv; } 
       set { SetPropertyValue(nameof(mediatedeliv), ref _mediatedeliv, value); } 
     } 
     // Billing
     // Notes for fDefineItemCategory : 
     private string _dlvbilltype; 
     [XafDisplayName("Dlv-rel Billing Type"), ToolTip("Dlv-rel billing type")] 
     // [Appearance("fDefineItemCategorydlvbilltype", Enabled = true)]
     // [Appearance("fDefineItemCategorydlvbilltypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string dlvbilltype
     { 
       get { return _dlvbilltype; } 
       set { SetPropertyValue(nameof(dlvbilltype), ref _dlvbilltype, value); } 
     } 
     // Billing
     // Notes for fDefineItemCategory : 
     private string _orderbilltype; 
     [XafDisplayName("Order-rel Bill Type"), ToolTip("Order-rel.bill.type")] 
     // [Appearance("fDefineItemCategoryorderbilltype", Enabled = true)]
     // [Appearance("fDefineItemCategoryorderbilltypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string orderbilltype
     { 
       get { return _orderbilltype; } 
       set { SetPropertyValue(nameof(orderbilltype), ref _orderbilltype, value); } 
     } 
     // Billing
     // Notes for fDefineItemCategory : 
     private string _intercompbilltype; 
     [XafDisplayName("Intercomp. Bill Type"), ToolTip("Intercomp.bill.type")] 
     // [Appearance("fDefineItemCategoryintercompbilltype", Enabled = true)]
     // [Appearance("fDefineItemCategoryintercompbilltypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string intercompbilltype
     { 
       get { return _intercompbilltype; } 
       set { SetPropertyValue(nameof(intercompbilltype), ref _intercompbilltype, value); } 
     } 
     // Billing
     // Notes for fDefineItemCategory : 
     private string _cndtypelineitems; 
     [XafDisplayName("CndType Line Items"), ToolTip("CndType line items")] 
     // [Appearance("fDefineItemCategorycndtypelineitems", Enabled = true)]
     // [Appearance("fDefineItemCategorycndtypelineitemsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string cndtypelineitems
     { 
       get { return _cndtypelineitems; } 
       set { SetPropertyValue(nameof(cndtypelineitems), ref _cndtypelineitems, value); } 
     } 
     // Billing
     // Notes for fDefineItemCategory : 
     private string _paymtguarantproc; 
     [XafDisplayName("Paymt Guarant. Proc."), ToolTip("Paymt guarant.proc.")] 
     // [Appearance("fDefineItemCategorypaymtguarantproc", Enabled = true)]
     // [Appearance("fDefineItemCategorypaymtguarantprocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string paymtguarantproc
     { 
       get { return _paymtguarantproc; } 
       set { SetPropertyValue(nameof(paymtguarantproc), ref _paymtguarantproc, value); } 
     } 
     // Billing
     // Notes for fDefineItemCategory : 
     private string _paymtcardplantype; 
     [XafDisplayName("Paymt Card Plan Type"), ToolTip("Paymt card plan type")] 
     // [Appearance("fDefineItemCategorypaymtcardplantype", Enabled = true)]
     // [Appearance("fDefineItemCategorypaymtcardplantypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string paymtcardplantype
     { 
       get { return _paymtcardplantype; } 
       set { SetPropertyValue(nameof(paymtcardplantype), ref _paymtcardplantype, value); } 
     } 
     // Billing
     // Notes for fDefineItemCategory : 
     private string _checkgrp; 
     [XafDisplayName("Checking Group"), ToolTip("Checking group")] 
     // [Appearance("fDefineItemCategorycheckgrp", Enabled = true)]
     // [Appearance("fDefineItemCategorycheckgrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string checkgrp
     { 
       get { return _checkgrp; } 
       set { SetPropertyValue(nameof(checkgrp), ref _checkgrp, value); } 
     } 
     // Requested delivery date/pricing date/purchase order date
     // Notes for fDefineItemCategory : 
     private string _leadtimeindays; 
     [XafDisplayName("Lead Time in Days"), ToolTip("Lead time in days")] 
     // [Appearance("fDefineItemCategoryleadtimeindays", Enabled = true)]
     // [Appearance("fDefineItemCategoryleadtimeindaysVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string leadtimeindays
     { 
       get { return _leadtimeindays; } 
       set { SetPropertyValue(nameof(leadtimeindays), ref _leadtimeindays, value); } 
     } 
     // Requested delivery date/pricing date/purchase order date
     // Notes for fDefineItemCategory : 
     private string _datetype; 
     [XafDisplayName("Date Type"), ToolTip("Date type")] 
     // [Appearance("fDefineItemCategorydatetype", Enabled = true)]
     // [Appearance("fDefineItemCategorydatetypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string datetype
     { 
       get { return _datetype; } 
       set { SetPropertyValue(nameof(datetype), ref _datetype, value); } 
     } 
     // Requested delivery date/pricing date/purchase order date
     // Notes for fDefineItemCategory : 
     private string _proppricdate; 
     [XafDisplayName("Prop. Pricing Date"), ToolTip("Prop.f.pricing date")] 
     // [Appearance("fDefineItemCategoryproppricdate", Enabled = true)]
     // [Appearance("fDefineItemCategoryproppricdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string proppricdate
     { 
       get { return _proppricdate; } 
       set { SetPropertyValue(nameof(proppricdate), ref _proppricdate, value); } 
     } 
     // Requested delivery date/pricing date/purchase order date
     // Notes for fDefineItemCategory : 
     private string _propvldfrmdate; 
     [XafDisplayName("Prop. Valid-From Date"), ToolTip("Prop.valid-from date")] 
     // [Appearance("fDefineItemCategorypropvldfrmdate", Enabled = true)]
     // [Appearance("fDefineItemCategorypropvldfrmdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string propvldfrmdate
     { 
       get { return _propvldfrmdate; } 
       set { SetPropertyValue(nameof(propvldfrmdate), ref _propvldfrmdate, value); } 
     } 
     // Requested delivery date/pricing date/purchase order date
     // Notes for fDefineItemCategory : 
     private bool _propdelivdate; 
     [XafDisplayName("Propose Deliv. Date"), ToolTip("Propose deliv.date")] 
     // [Appearance("fDefineItemCategorypropdelivdate", Enabled = true)]
     // [Appearance("fDefineItemCategorypropdelivdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool propdelivdate
     { 
       get { return _propdelivdate; } 
       set { SetPropertyValue(nameof(propdelivdate), ref _propdelivdate, value); } 
     } 
     // Requested delivery date/pricing date/purchase order date
     // Notes for fDefineItemCategory : 
     private bool _proppodate; 
     [XafDisplayName("Propose PO date"), ToolTip("Propose PO date")] 
     // [Appearance("fDefineItemCategoryproppodate", Enabled = true)]
     // [Appearance("fDefineItemCategoryproppodateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool proppodate
     { 
       get { return _proppodate; } 
       set { SetPropertyValue(nameof(proppodate), ref _proppodate, value); } 
     } 
     // Contract
     // Notes for fDefineItemCategory : 
     private string _pricproccondheadr; 
     [XafDisplayName("Pric. Proc. Cond-Headr"), ToolTip("PricProcCondHeadr")] 
     // [Appearance("fDefineItemCategorypricproccondheadr", Enabled = true)]
     // [Appearance("fDefineItemCategorypricproccondheadrVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string pricproccondheadr
     { 
       get { return _pricproccondheadr; } 
       set { SetPropertyValue(nameof(pricproccondheadr), ref _pricproccondheadr, value); } 
     } 
     // Contract
     // Notes for fDefineItemCategory : 
     private string _pricprocconditem; 
     [XafDisplayName("Pric. Proc. Cond-Item"), ToolTip("PricProcCondItem")] 
     // [Appearance("fDefineItemCategorypricprocconditem", Enabled = true)]
     // [Appearance("fDefineItemCategorypricprocconditemVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string pricprocconditem
     { 
       get { return _pricprocconditem; } 
       set { SetPropertyValue(nameof(pricprocconditem), ref _pricprocconditem, value); } 
     } 
     // Contract
     // Notes for fDefineItemCategory : 
     private string _contractprofile; 
     [XafDisplayName("Contract Profile"), ToolTip("Contract profile")] 
     // [Appearance("fDefineItemCategorycontractprofile", Enabled = true)]
     // [Appearance("fDefineItemCategorycontractprofileVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string contractprofile
     { 
       get { return _contractprofile; } 
       set { SetPropertyValue(nameof(contractprofile), ref _contractprofile, value); } 
     } 
     // Contract
     // Notes for fDefineItemCategory : 
     private string _billreq; 
     [XafDisplayName("Billing Request"), ToolTip("Billingrequest")] 
     // [Appearance("fDefineItemCategorybillreq", Enabled = true)]
     // [Appearance("fDefineItemCategorybillreqVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string billreq
     { 
       get { return _billreq; } 
       set { SetPropertyValue(nameof(billreq), ref _billreq, value); } 
     } 
     // Contract
     // Notes for fDefineItemCategory : 
     private string _grprefproc; 
     [XafDisplayName("Group Ref. Procedure"), ToolTip("Group Ref. Procedure")] 
     // [Appearance("fDefineItemCategorygrprefproc", Enabled = true)]
     // [Appearance("fDefineItemCategorygrprefprocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string grprefproc
     { 
       get { return _grprefproc; } 
       set { SetPropertyValue(nameof(grprefproc), ref _grprefproc, value); } 
     } 
     // Contract
     // Notes for fDefineItemCategory : 
     private string _contractdataallwd; 
     [XafDisplayName("Contract Data Allwd."), ToolTip("Contract data allwd.")] 
     // [Appearance("fDefineItemCategorycontractdataallwd", Enabled = true)]
     // [Appearance("fDefineItemCategorycontractdataallwdVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string contractdataallwd
     { 
       get { return _contractdataallwd; } 
       set { SetPropertyValue(nameof(contractdataallwd), ref _contractdataallwd, value); } 
     } 
     // Contract
     // Notes for fDefineItemCategory : 
     private string _follupactivitytype; 
     [XafDisplayName("Foll-Up Activity Type"), ToolTip("FollUpActivityType")] 
     // [Appearance("fDefineItemCategoryfollupactivitytype", Enabled = true)]
     // [Appearance("fDefineItemCategoryfollupactivitytypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string follupactivitytype
     { 
       get { return _follupactivitytype; } 
       set { SetPropertyValue(nameof(follupactivitytype), ref _follupactivitytype, value); } 
     } 
     // Contract
     // Notes for fDefineItemCategory : 
     private string _subseqordertype; 
     [XafDisplayName("Subseq.Order Type"), ToolTip("Subseq.order type")] 
     // [Appearance("fDefineItemCategorysubseqordertype", Enabled = true)]
     // [Appearance("fDefineItemCategorysubseqordertypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string subseqordertype
     { 
       get { return _subseqordertype; } 
       set { SetPropertyValue(nameof(subseqordertype), ref _subseqordertype, value); } 
     } 
     // Contract
     // Notes for fDefineItemCategory : 
     private string _chkpartnerauth; 
     [XafDisplayName("Check Partner Auth."), ToolTip("Check partner auth.")] 
     // [Appearance("fDefineItemCategorychkpartnerauth", Enabled = true)]
     // [Appearance("fDefineItemCategorychkpartnerauthVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string chkpartnerauth
     { 
       get { return _chkpartnerauth; } 
       set { SetPropertyValue(nameof(chkpartnerauth), ref _chkpartnerauth, value); } 
     } 
     // Contract
     // Notes for fDefineItemCategory : 
     private bool _updtlowlevcont; 
     [XafDisplayName("Update Low Lev-Cont"), ToolTip("Update low.lev.cont")] 
     // [Appearance("fDefineItemCategoryupdtlowlevcont", Enabled = true)]
     // [Appearance("fDefineItemCategoryupdtlowlevcontVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool updtlowlevcont
     { 
       get { return _updtlowlevcont; } 
       set { SetPropertyValue(nameof(updtlowlevcont), ref _updtlowlevcont, value); } 
     } 
     // Availbality check
     // Notes for fDefineItemCategory : 
     private string _businesstransact; 
     [XafDisplayName("Business Transaction"), ToolTip("Business transaction")] 
     // [Appearance("fDefineItemCategorybusinesstransact", Enabled = true)]
     // [Appearance("fDefineItemCategorybusinesstransactVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string businesstransact
     { 
       get { return _businesstransact; } 
       set { SetPropertyValue(nameof(businesstransact), ref _businesstransact, value); } 
     } 
     // New Entries: Details of Added Entries
     // Notes for fDefineItemCategory : 
     private string _itmctg; 
     [XafDisplayName("Item Category"), ToolTip("Item Category")] 
     // [Appearance("fDefineItemCategoryitmctg", Enabled = true)]
     // [Appearance("fDefineItemCategoryitmctgVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string itmctg
     { 
       get { return _itmctg; } 
       set { SetPropertyValue(nameof(itmctg), ref _itmctg, value); } 
     } 
     // Business Data
     // Notes for fDefineItemCategory : 
     private string _itmtype; 
     [XafDisplayName("Item Type"), ToolTip("Item Type")] 
     // [Appearance("fDefineItemCategoryitmtype", Enabled = true)]
     // [Appearance("fDefineItemCategoryitmtypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string itmtype
     { 
       get { return _itmtype; } 
       set { SetPropertyValue(nameof(itmtype), ref _itmtype, value); } 
     } 
     // Business Data
     // Notes for fDefineItemCategory : 
     private string _comprule; 
     [XafDisplayName("Completion Rule"), ToolTip("Completion Rule")] 
     // [Appearance("fDefineItemCategorycomprule", Enabled = true)]
     // [Appearance("fDefineItemCategorycompruleVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string comprule
     { 
       get { return _comprule; } 
       set { SetPropertyValue(nameof(comprule), ref _comprule, value); } 
     } 
     // Business Data
     // Notes for fDefineItemCategory : 
     private string _spclstck; 
     [XafDisplayName("Special Stock"), ToolTip("Special Stock")] 
     // [Appearance("fDefineItemCategoryspclstck", Enabled = true)]
     // [Appearance("fDefineItemCategoryspclstckVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string spclstck
     { 
       get { return _spclstck; } 
       set { SetPropertyValue(nameof(spclstck), ref _spclstck, value); } 
     } 
     // Business Data
     // Notes for fDefineItemCategory : 
     private string _billrelevan; 
     [XafDisplayName("Billing Relevance"), ToolTip("Billing Relevance")] 
     // [Appearance("fDefineItemCategorybillrelevan", Enabled = true)]
     // [Appearance("fDefineItemCategorybillrelevanVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string billrelevan
     { 
       get { return _billrelevan; } 
       set { SetPropertyValue(nameof(billrelevan), ref _billrelevan, value); } 
     } 
     // Business Data
     // Notes for fDefineItemCategory : 
     private string _billplantype; 
     [XafDisplayName("Billing Plan Type"), ToolTip("Billing Plan Type")] 
     // [Appearance("fDefineItemCategorybillplantype", Enabled = true)]
     // [Appearance("fDefineItemCategorybillplantypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string billplantype
     { 
       get { return _billplantype; } 
       set { SetPropertyValue(nameof(billplantype), ref _billplantype, value); } 
     } 
     // Business Data
     // Notes for fDefineItemCategory : 
     private string _billblock; 
     [XafDisplayName("Billing Block"), ToolTip("Billing block")] 
     // [Appearance("fDefineItemCategorybillblock", Enabled = true)]
     // [Appearance("fDefineItemCategorybillblockVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string billblock
     { 
       get { return _billblock; } 
       set { SetPropertyValue(nameof(billblock), ref _billblock, value); } 
     } 
     // Business Data
     // Notes for fDefineItemCategory : 
     private string _pricing; 
     [XafDisplayName("Pricing"), ToolTip("Pricing")] 
     // [Appearance("fDefineItemCategorypricing", Enabled = true)]
     // [Appearance("fDefineItemCategorypricingVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string pricing
     { 
       get { return _pricing; } 
       set { SetPropertyValue(nameof(pricing), ref _pricing, value); } 
     } 
     // Business Data
     // Notes for fDefineItemCategory : 
     private string _statisval; 
     [XafDisplayName("Statistical Value"), ToolTip("Statistical value")] 
     // [Appearance("fDefineItemCategorystatisval", Enabled = true)]
     // [Appearance("fDefineItemCategorystatisvalVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string statisval
     { 
       get { return _statisval; } 
       set { SetPropertyValue(nameof(statisval), ref _statisval, value); } 
     } 
     // Business Data
     // Notes for fDefineItemCategory : 
     private string _revenrecog; 
     [XafDisplayName("Revenue Recognition"), ToolTip("Revenue Recognition")] 
     // [Appearance("fDefineItemCategoryrevenrecog", Enabled = true)]
     // [Appearance("fDefineItemCategoryrevenrecogVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string revenrecog
     { 
       get { return _revenrecog; } 
       set { SetPropertyValue(nameof(revenrecog), ref _revenrecog, value); } 
     } 
     // Business Data
     // Notes for fDefineItemCategory : 
     private string _selimitstartdate; 
     [XafDisplayName("Selimit. Start Date"), ToolTip("Selimit. Start Date")] 
     // [Appearance("fDefineItemCategoryselimitstartdate", Enabled = true)]
     // [Appearance("fDefineItemCategoryselimitstartdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string selimitstartdate
     { 
       get { return _selimitstartdate; } 
       set { SetPropertyValue(nameof(selimitstartdate), ref _selimitstartdate, value); } 
     } 
     // Business Data
     // Notes for fDefineItemCategory : 
     private bool _busitm; 
     [XafDisplayName("Business Item"), ToolTip("Business Item")] 
     // [Appearance("fDefineItemCategorybusitm", Enabled = true)]
     // [Appearance("fDefineItemCategorybusitmVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool busitm
     { 
       get { return _busitm; } 
       set { SetPropertyValue(nameof(busitm), ref _busitm, value); } 
     } 
     // Business Data
     // Notes for fDefineItemCategory : 
     private bool _shcedlineallwd; 
     [XafDisplayName("Sched. Line Allowed"), ToolTip("Sched.Line Allowed")] 
     // [Appearance("fDefineItemCategoryshcedlineallwd", Enabled = true)]
     // [Appearance("fDefineItemCategoryshcedlineallwdVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool shcedlineallwd
     { 
       get { return _shcedlineallwd; } 
       set { SetPropertyValue(nameof(shcedlineallwd), ref _shcedlineallwd, value); } 
     } 
     // Business Data
     // Notes for fDefineItemCategory : 
     private bool _itmrelevdlv; 
     [XafDisplayName("Item Relev. For Dlv"), ToolTip("Item Relev.for Dlv")] 
     // [Appearance("fDefineItemCategoryitmrelevdlv", Enabled = true)]
     // [Appearance("fDefineItemCategoryitmrelevdlvVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool itmrelevdlv
     { 
       get { return _itmrelevdlv; } 
       set { SetPropertyValue(nameof(itmrelevdlv), ref _itmrelevdlv, value); } 
     } 
     // Business Data
     // Notes for fDefineItemCategory : 
     private bool _returns; 
     [XafDisplayName("Returns"), ToolTip("Returns")] 
     // [Appearance("fDefineItemCategoryreturns", Enabled = true)]
     // [Appearance("fDefineItemCategoryreturnsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool returns
     { 
       get { return _returns; } 
       set { SetPropertyValue(nameof(returns), ref _returns, value); } 
     } 
     // Business Data
     // Notes for fDefineItemCategory : 
     private bool _volrelev; 
     [XafDisplayName("Wght/Vol. Relevant"), ToolTip("Wght/Vol. Relevant")] 
     // [Appearance("fDefineItemCategoryvolrelev", Enabled = true)]
     // [Appearance("fDefineItemCategoryvolrelevVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool volrelev
     { 
       get { return _volrelev; } 
       set { SetPropertyValue(nameof(volrelev), ref _volrelev, value); } 
     } 
     // Business Data
     // Notes for fDefineItemCategory : 
     private bool _crdtactv; 
     [XafDisplayName("Credit Active"), ToolTip("Credit Active")] 
     // [Appearance("fDefineItemCategorycrdtactv", Enabled = true)]
     // [Appearance("fDefineItemCategorycrdtactvVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool crdtactv
     { 
       get { return _crdtactv; } 
       set { SetPropertyValue(nameof(crdtactv), ref _crdtactv, value); } 
     } 
     // Business Data
     // Notes for fDefineItemCategory : 
     private bool _detercost; 
     [XafDisplayName("Determine Cost"), ToolTip("Determine Cost")] 
     // [Appearance("fDefineItemCategorydetercost", Enabled = true)]
     // [Appearance("fDefineItemCategorydetercostVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool detercost
     { 
       get { return _detercost; } 
       set { SetPropertyValue(nameof(detercost), ref _detercost, value); } 
     } 
   } 
} 
