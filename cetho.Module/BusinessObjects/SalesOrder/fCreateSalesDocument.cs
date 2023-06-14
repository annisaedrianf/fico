// Class Name : fCreateSalesDocument.cs 
// Project Name : FICO 
// Last Update : 06/06/2023 12:42:42  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 06/06/2023 12:42:42 
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
   [System.ComponentModel.DisplayName("Maintain Number Range Intervals")]
   public class fCreateSalesDocument : XPObject
   {
     public fCreateSalesDocument(Session session) : base(session) 
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
     [Appearance("VisiblefCreateSalesDocumentOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // Availbality check
     // Notes for fCreateSalesDocument : 
     private string _businesstransact; 
     [XafDisplayName("Business Transaction"), ToolTip("Business transaction")] 
     // [Appearance("fCreateSalesDocumentbusinesstransact", Enabled = true)]
     // [Appearance("fCreateSalesDocumentbusinesstransactVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string businesstransact
     { 
       get { return _businesstransact; } 
       set { SetPropertyValue(nameof(businesstransact), ref _businesstransact, value); } 
     } 
     // Billing
     // Notes for fCreateSalesDocument : 
     private string _billblock; 
     [XafDisplayName("Billing Block"), ToolTip("Billing block")] 
     // [Appearance("fCreateSalesDocumentbillblock", Enabled = true)]
     // [Appearance("fCreateSalesDocumentbillblockVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string billblock
     { 
       get { return _billblock; } 
       set { SetPropertyValue(nameof(billblock), ref _billblock, value); } 
     } 
     // Billing
     // Notes for fCreateSalesDocument : 
     private string _billplantype; 
     [XafDisplayName("Billing Plan Type"), ToolTip("Billing plam type")] 
     // [Appearance("fCreateSalesDocumentbillplantype", Enabled = true)]
     // [Appearance("fCreateSalesDocumentbillplantypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string billplantype
     { 
       get { return _billplantype; } 
       set { SetPropertyValue(nameof(billplantype), ref _billplantype, value); } 
     } 
     // Billing
     // Notes for fCreateSalesDocument : 
     private string _checkgrp; 
     [XafDisplayName("Checking Group"), ToolTip("Checking group")] 
     // [Appearance("fCreateSalesDocumentcheckgrp", Enabled = true)]
     // [Appearance("fCreateSalesDocumentcheckgrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string checkgrp
     { 
       get { return _checkgrp; } 
       set { SetPropertyValue(nameof(checkgrp), ref _checkgrp, value); } 
     } 
     // Billing
     // Notes for fCreateSalesDocument : 
     private string _cndtypelineitems; 
     [XafDisplayName("CndType Line Items"), ToolTip("CndType line items")] 
     // [Appearance("fCreateSalesDocumentcndtypelineitems", Enabled = true)]
     // [Appearance("fCreateSalesDocumentcndtypelineitemsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private string _dlvbilltype; 
     [XafDisplayName("Dlv-Rel Billing Type"), ToolTip("Dlv-rel billing type")] 
     // [Appearance("fCreateSalesDocumentdlvbilltype", Enabled = true)]
     // [Appearance("fCreateSalesDocumentdlvbilltypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private string _intercompbilltype; 
     [XafDisplayName("Intercomp. Bill. Type"), ToolTip("Intercomp.bill.type")] 
     // [Appearance("fCreateSalesDocumentintercompbilltype", Enabled = true)]
     // [Appearance("fCreateSalesDocumentintercompbilltypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private string _orderbilltype; 
     [XafDisplayName("Order-Rel. Bill. Type"), ToolTip("Order-rel.bill.type")] 
     // [Appearance("fCreateSalesDocumentorderbilltype", Enabled = true)]
     // [Appearance("fCreateSalesDocumentorderbilltypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private string _paymtcardplantype; 
     [XafDisplayName("Paymt Card Plan Type"), ToolTip("Paymt card plan type")] 
     // [Appearance("fCreateSalesDocumentpaymtcardplantype", Enabled = true)]
     // [Appearance("fCreateSalesDocumentpaymtcardplantypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private string _paymtguarantproc; 
     [XafDisplayName("Paymt Guarant. Proc."), ToolTip("Paymt guarant.proc.")] 
     // [Appearance("fCreateSalesDocumentpaymtguarantproc", Enabled = true)]
     // [Appearance("fCreateSalesDocumentpaymtguarantprocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string paymtguarantproc
     { 
       get { return _paymtguarantproc; } 
       set { SetPropertyValue(nameof(paymtguarantproc), ref _paymtguarantproc, value); } 
     } 
     // Contract
     // Notes for fCreateSalesDocument : 
     private string _billreq; 
     [XafDisplayName("Billing Request"), ToolTip("Billingrequest")] 
     // [Appearance("fCreateSalesDocumentbillreq", Enabled = true)]
     // [Appearance("fCreateSalesDocumentbillreqVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private string _chkpartnerauth; 
     [XafDisplayName("Check Partner Auth."), ToolTip("Check partner auth.")] 
     // [Appearance("fCreateSalesDocumentchkpartnerauth", Enabled = true)]
     // [Appearance("fCreateSalesDocumentchkpartnerauthVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private string _contractdataallwd; 
     [XafDisplayName("Contract Data Allwd."), ToolTip("Contract data allwd.")] 
     // [Appearance("fCreateSalesDocumentcontractdataallwd", Enabled = true)]
     // [Appearance("fCreateSalesDocumentcontractdataallwdVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private string _contractprofile; 
     [XafDisplayName("Contract Profile"), ToolTip("Contract profile")] 
     // [Appearance("fCreateSalesDocumentcontractprofile", Enabled = true)]
     // [Appearance("fCreateSalesDocumentcontractprofileVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private string _follupactivitytype; 
     [XafDisplayName("Foll-Up Activity Type"), ToolTip("FollUpActivityType")] 
     // [Appearance("fCreateSalesDocumentfollupactivitytype", Enabled = true)]
     // [Appearance("fCreateSalesDocumentfollupactivitytypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private string _grprefproc; 
     [XafDisplayName("Group Ref. Procedure"), ToolTip("Group Ref. Procedure")] 
     // [Appearance("fCreateSalesDocumentgrprefproc", Enabled = true)]
     // [Appearance("fCreateSalesDocumentgrprefprocVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private string _pricproccondheadr; 
     [XafDisplayName("Pric-Proc Cond-Headr"), ToolTip("PricProcCondHeadr")] 
     // [Appearance("fCreateSalesDocumentpricproccondheadr", Enabled = true)]
     // [Appearance("fCreateSalesDocumentpricproccondheadrVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private string _pricprocconditem; 
     [XafDisplayName("Pric-Proc Cond-Item"), ToolTip("PricProcCondItem")] 
     // [Appearance("fCreateSalesDocumentpricprocconditem", Enabled = true)]
     // [Appearance("fCreateSalesDocumentpricprocconditemVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private string _subseqordertype; 
     [XafDisplayName("Subseq. Order Type"), ToolTip("Subseq. Order Type")] 
     // [Appearance("fCreateSalesDocumentsubseqordertype", Enabled = true)]
     // [Appearance("fCreateSalesDocumentsubseqordertypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private bool _updtlowlevcont; 
     [XafDisplayName("Update Low Lev. Cont"), ToolTip("Update Low Lev. Cont")] 
     // [Appearance("fCreateSalesDocumentupdtlowlevcont", Enabled = true)]
     // [Appearance("fCreateSalesDocumentupdtlowlevcontVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool updtlowlevcont
     { 
       get { return _updtlowlevcont; } 
       set { SetPropertyValue(nameof(updtlowlevcont), ref _updtlowlevcont, value); } 
     } 
     // Existing Number Ranges
     // Notes for fCreateSalesDocument : 
     private bool _ext1; 
     [XafDisplayName("Exst. Number Ranges"), ToolTip("Exst. Number Ranges")] 
     // [Appearance("fCreateSalesDocumentext1", Enabled = true)]
     // [Appearance("fCreateSalesDocumentext1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool ext1
     { 
       get { return _ext1; } 
       set { SetPropertyValue(nameof(ext1), ref _ext1, value); } 
     } 
     // Existing Number Ranges
     // Notes for fCreateSalesDocument : 
     private string _frmnumb1; 
     [XafDisplayName("From Number "), ToolTip("From number ")] 
     // [Appearance("fCreateSalesDocumentfrmnumb1", Enabled = true)]
     // [Appearance("fCreateSalesDocumentfrmnumb1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string frmnumb1
     { 
       get { return _frmnumb1; } 
       set { SetPropertyValue(nameof(frmnumb1), ref _frmnumb1, value); } 
     } 
     // Existing Number Ranges
     // Notes for fCreateSalesDocument : 
     private string _no1; 
     [XafDisplayName("No "), ToolTip("No ")] 
     // [Appearance("fCreateSalesDocumentno1", Enabled = true)]
     // [Appearance("fCreateSalesDocumentno1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string no1
     { 
       get { return _no1; } 
       set { SetPropertyValue(nameof(no1), ref _no1, value); } 
     } 
     // Existing Number Ranges
     // Notes for fCreateSalesDocument : 
     private string _numrangestts; 
     [XafDisplayName("Number Range Status"), ToolTip("Number Range Status")] 
     // [Appearance("fCreateSalesDocumentnumrangestts", Enabled = true)]
     // [Appearance("fCreateSalesDocumentnumrangesttsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string numrangestts
     { 
       get { return _numrangestts; } 
       set { SetPropertyValue(nameof(numrangestts), ref _numrangestts, value); } 
     } 
     // Existing Number Ranges
     // Notes for fCreateSalesDocument : 
     private string _tonumb1; 
     [XafDisplayName("To Number "), ToolTip("To Number ")] 
     // [Appearance("fCreateSalesDocumenttonumb1", Enabled = true)]
     // [Appearance("fCreateSalesDocumenttonumb1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string tonumb1
     { 
       get { return _tonumb1; } 
       set { SetPropertyValue(nameof(tonumb1), ref _tonumb1, value); } 
     } 
     // General control
     // Notes for fCreateSalesDocument : 
     private string _chckcreditlimit; 
     [XafDisplayName("Check Credit Limit"), ToolTip("Check credit limit")] 
     // [Appearance("fCreateSalesDocumentchckcreditlimit", Enabled = true)]
     // [Appearance("fCreateSalesDocumentchckcreditlimitVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private string _checkdivsion; 
     [XafDisplayName("Check Division"), ToolTip("Check division")] 
     // [Appearance("fCreateSalesDocumentcheckdivsion", Enabled = true)]
     // [Appearance("fCreateSalesDocumentcheckdivsionVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private string _checkpurchorder; 
     [XafDisplayName("Check Purch. Order No"), ToolTip("Check purch. Order no")] 
     // [Appearance("fCreateSalesDocumentcheckpurchorder", Enabled = true)]
     // [Appearance("fCreateSalesDocumentcheckpurchorderVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private string _commitdate; 
     [XafDisplayName("Commitment Date"), ToolTip("Commitment date")] 
     // [Appearance("fCreateSalesDocumentcommitdate", Enabled = true)]
     // [Appearance("fCreateSalesDocumentcommitdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string commitdate
     { 
       get { return _commitdate; } 
       set { SetPropertyValue(nameof(commitdate), ref _commitdate, value); } 
     } 
     // General control
     // Notes for fCreateSalesDocument : 
     private string _creditgrp; 
     [XafDisplayName("Credit Group"), ToolTip("Credit group")] 
     // [Appearance("fCreateSalesDocumentcreditgrp", Enabled = true)]
     // [Appearance("fCreateSalesDocumentcreditgrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private bool _enterponumb; 
     [XafDisplayName("Enter PO Number"), ToolTip("Enter PO number")] 
     // [Appearance("fCreateSalesDocumententerponumb", Enabled = true)]
     // [Appearance("fCreateSalesDocumententerponumbVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool enterponumb
     { 
       get { return _enterponumb; } 
       set { SetPropertyValue(nameof(enterponumb), ref _enterponumb, value); } 
     } 
     // General control
     // Notes for fCreateSalesDocument : 
     private bool _itemdivision; 
     [XafDisplayName("Item Division"), ToolTip("Item division")] 
     // [Appearance("fCreateSalesDocumentitemdivision", Enabled = true)]
     // [Appearance("fCreateSalesDocumentitemdivisionVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool itemdivision
     { 
       get { return _itemdivision; } 
       set { SetPropertyValue(nameof(itemdivision), ref _itemdivision, value); } 
     } 
     // General control
     // Notes for fCreateSalesDocument : 
     private string _matlentrytype; 
     [XafDisplayName("Material Entry Type"), ToolTip("Material entry type")] 
     // [Appearance("fCreateSalesDocumentmatlentrytype", Enabled = true)]
     // [Appearance("fCreateSalesDocumentmatlentrytypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private string _outputappl; 
     [XafDisplayName("Output Application"), ToolTip("Output application")] 
     // [Appearance("fCreateSalesDocumentoutputappl", Enabled = true)]
     // [Appearance("fCreateSalesDocumentoutputapplVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private string _probability; 
     [XafDisplayName("Probability"), ToolTip("Probability")] 
     // [Appearance("fCreateSalesDocumentprobability", Enabled = true)]
     // [Appearance("fCreateSalesDocumentprobabilityVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private bool _readinforecord; 
     [XafDisplayName("Read Info Record"), ToolTip("Read info record")] 
     // [Appearance("fCreateSalesDocumentreadinforecord", Enabled = true)]
     // [Appearance("fCreateSalesDocumentreadinforecordVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool readinforecord
     { 
       get { return _readinforecord; } 
       set { SetPropertyValue(nameof(readinforecord), ref _readinforecord, value); } 
     } 
     // General control
     // Notes for fCreateSalesDocument : 
     private string _refmandatory; 
     [XafDisplayName("Reference Mandatory"), ToolTip("Reference mandatory")] 
     // [Appearance("fCreateSalesDocumentrefmandatory", Enabled = true)]
     // [Appearance("fCreateSalesDocumentrefmandatoryVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string refmandatory
     { 
       get { return _refmandatory; } 
       set { SetPropertyValue(nameof(refmandatory), ref _refmandatory, value); } 
     } 
     // New Interval
     // Notes for fCreateSalesDocument : 
     private string _currnumb; 
     [XafDisplayName("Current Number"), ToolTip("Current number")] 
     // [Appearance("fCreateSalesDocumentcurrnumb", Enabled = true)]
     // [Appearance("fCreateSalesDocumentcurrnumbVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string currnumb
     { 
       get { return _currnumb; } 
       set { SetPropertyValue(nameof(currnumb), ref _currnumb, value); } 
     } 
     // New Interval
     // Notes for fCreateSalesDocument : 
     private bool _ext; 
     [XafDisplayName("Ext"), ToolTip("Ext")] 
     // [Appearance("fCreateSalesDocumentext", Enabled = true)]
     // [Appearance("fCreateSalesDocumentextVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool ext
     { 
       get { return _ext; } 
       set { SetPropertyValue(nameof(ext), ref _ext, value); } 
     } 
     // New Interval
     // Notes for fCreateSalesDocument : 
     private string _frmnumb; 
     [XafDisplayName("From Number"), ToolTip("From number")] 
     // [Appearance("fCreateSalesDocumentfrmnumb", Enabled = true)]
     // [Appearance("fCreateSalesDocumentfrmnumbVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string frmnumb
     { 
       get { return _frmnumb; } 
       set { SetPropertyValue(nameof(frmnumb), ref _frmnumb, value); } 
     } 
     // New Interval
     // Notes for fCreateSalesDocument : 
     private string _no; 
     [XafDisplayName("No"), ToolTip("No")] 
     // [Appearance("fCreateSalesDocumentno", Enabled = true)]
     // [Appearance("fCreateSalesDocumentnoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string no
     { 
       get { return _no; } 
       set { SetPropertyValue(nameof(no), ref _no, value); } 
     } 
     // New Interval
     // Notes for fCreateSalesDocument : 
     private string _tonumb; 
     [XafDisplayName("To Number"), ToolTip("To Number")] 
     // [Appearance("fCreateSalesDocumenttonumb", Enabled = true)]
     // [Appearance("fCreateSalesDocumenttonumbVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string tonumb
     { 
       get { return _tonumb; } 
       set { SetPropertyValue(nameof(tonumb), ref _tonumb, value); } 
     } 
     // Number systems
     // Notes for fCreateSalesDocument : 
     private string _itmnoincremnt; 
     [XafDisplayName("Item No. Increment"), ToolTip("Item no.increment")] 
     // [Appearance("fCreateSalesDocumentitmnoincremnt", Enabled = true)]
     // [Appearance("fCreateSalesDocumentitmnoincremntVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private string _rangeextassg; 
     [XafDisplayName("No. Range Exs. Assg"), ToolTip("No.range ext.assg")] 
     // [Appearance("fCreateSalesDocumentrangeextassg", Enabled = true)]
     // [Appearance("fCreateSalesDocumentrangeextassgVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private string _rangeintassgt; 
     [XafDisplayName("No. Range Int. Assgt"), ToolTip("No.range int.assgt")] 
     // [Appearance("fCreateSalesDocumentrangeintassgt", Enabled = true)]
     // [Appearance("fCreateSalesDocumentrangeintassgtVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private string _subitmincrmnt; 
     [XafDisplayName("Sub-Item Increment"), ToolTip("Sub-Item Increment")] 
     // [Appearance("fCreateSalesDocumentsubitmincrmnt", Enabled = true)]
     // [Appearance("fCreateSalesDocumentsubitmincrmntVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string subitmincrmnt
     { 
       get { return _subitmincrmnt; } 
       set { SetPropertyValue(nameof(subitmincrmnt), ref _subitmincrmnt, value); } 
     } 
     // Requested delivery date/pricing date/purchase order date
     // Notes for fCreateSalesDocument : 
     private string _datetype; 
     [XafDisplayName("Date Type"), ToolTip("Date type")] 
     // [Appearance("fCreateSalesDocumentdatetype", Enabled = true)]
     // [Appearance("fCreateSalesDocumentdatetypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private string _leadtimeindays; 
     [XafDisplayName("Lead Time in Days"), ToolTip("Lead time in days")] 
     // [Appearance("fCreateSalesDocumentleadtimeindays", Enabled = true)]
     // [Appearance("fCreateSalesDocumentleadtimeindaysVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private bool _propdelivdate; 
     [XafDisplayName("Propose Deliv. Date"), ToolTip("Propose deliv.date")] 
     // [Appearance("fCreateSalesDocumentpropdelivdate", Enabled = true)]
     // [Appearance("fCreateSalesDocumentpropdelivdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool propdelivdate
     { 
       get { return _propdelivdate; } 
       set { SetPropertyValue(nameof(propdelivdate), ref _propdelivdate, value); } 
     } 
     // Requested delivery date/pricing date/purchase order date
     // Notes for fCreateSalesDocument : 
     private bool _proppodate; 
     [XafDisplayName("Propose PO date"), ToolTip("Propose PO date")] 
     // [Appearance("fCreateSalesDocumentproppodate", Enabled = true)]
     // [Appearance("fCreateSalesDocumentproppodateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool proppodate
     { 
       get { return _proppodate; } 
       set { SetPropertyValue(nameof(proppodate), ref _proppodate, value); } 
     } 
     // Requested delivery date/pricing date/purchase order date
     // Notes for fCreateSalesDocument : 
     private string _proppricdate; 
     [XafDisplayName("Prop. F-Pricing date"), ToolTip("Prop.f.pricing date")] 
     // [Appearance("fCreateSalesDocumentproppricdate", Enabled = true)]
     // [Appearance("fCreateSalesDocumentproppricdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private string _propvldfrmdate; 
     [XafDisplayName("Prop. Valid-From Date"), ToolTip("Prop.valid-from date")] 
     // [Appearance("fCreateSalesDocumentpropvldfrmdate", Enabled = true)]
     // [Appearance("fCreateSalesDocumentpropvldfrmdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string propvldfrmdate
     { 
       get { return _propvldfrmdate; } 
       set { SetPropertyValue(nameof(propvldfrmdate), ref _propvldfrmdate, value); } 
     } 
     // Schedulling Agreement
     // Notes for fCreateSalesDocument : 
     private string _corrdelivtype; 
     [XafDisplayName("Corr. Delivery Type"), ToolTip("Corr.delivery type")] 
     // [Appearance("fCreateSalesDocumentcorrdelivtype", Enabled = true)]
     // [Appearance("fCreateSalesDocumentcorrdelivtypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private string _delivblock; 
     [XafDisplayName("Delivery Block"), ToolTip("Delivery block")] 
     // [Appearance("fCreateSalesDocumentdelivblock", Enabled = true)]
     // [Appearance("fCreateSalesDocumentdelivblockVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string delivblock
     { 
       get { return _delivblock; } 
       set { SetPropertyValue(nameof(delivblock), ref _delivblock, value); } 
     } 
     // Schedulling Agreement
     // Notes for fCreateSalesDocument : 
     private string _mrpfordlvschtype; 
     [XafDisplayName("MRP for Dlv-Sch Type"), ToolTip("MRP for DlvSchType")] 
     // [Appearance("fCreateSalesDocumentmrpfordlvschtype", Enabled = true)]
     // [Appearance("fCreateSalesDocumentmrpfordlvschtypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private string _usage; 
     [XafDisplayName("Usage"), ToolTip("Usage")] 
     // [Appearance("fCreateSalesDocumentusage", Enabled = true)]
     // [Appearance("fCreateSalesDocumentusageVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string usage
     { 
       get { return _usage; } 
       set { SetPropertyValue(nameof(usage), ref _usage, value); } 
     } 
     // Shipping
     // Notes for fCreateSalesDocument : 
     private string _delivbock1; 
     [XafDisplayName("Delivery Block"), ToolTip("Delivery block")] 
     // [Appearance("fCreateSalesDocumentdelivbock1", Enabled = true)]
     // [Appearance("fCreateSalesDocumentdelivbock1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string delivbock1
     { 
       get { return _delivbock1; } 
       set { SetPropertyValue(nameof(delivbock1), ref _delivbock1, value); } 
     } 
     // Shipping
     // Notes for fCreateSalesDocument : 
     private string _delivtype; 
     [XafDisplayName("Delivery Type"), ToolTip("Delivery type")] 
     // [Appearance("fCreateSalesDocumentdelivtype", Enabled = true)]
     // [Appearance("fCreateSalesDocumentdelivtypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private string _mediatedeliv; 
     [XafDisplayName("Immediate Delivevry"), ToolTip("Immediate delivevry")] 
     // [Appearance("fCreateSalesDocumentmediatedeliv", Enabled = true)]
     // [Appearance("fCreateSalesDocumentmediatedelivVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string mediatedeliv
     { 
       get { return _mediatedeliv; } 
       set { SetPropertyValue(nameof(mediatedeliv), ref _mediatedeliv, value); } 
     } 
     // Shipping
     // Notes for fCreateSalesDocument : 
     private string _shipcond; 
     [XafDisplayName("Shipping Conditions"), ToolTip("Shipping conditions")] 
     // [Appearance("fCreateSalesDocumentshipcond", Enabled = true)]
     // [Appearance("fCreateSalesDocumentshipcondVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private string _shipcostinfoprofile; 
     [XafDisplayName("Ship. Cost Info Profile"), ToolTip("ShipCostInfoProfile")] 
     // [Appearance("fCreateSalesDocumentshipcostinfoprofile", Enabled = true)]
     // [Appearance("fCreateSalesDocumentshipcostinfoprofileVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string shipcostinfoprofile
     { 
       get { return _shipcostinfoprofile; } 
       set { SetPropertyValue(nameof(shipcostinfoprofile), ref _shipcostinfoprofile, value); } 
     } 
     // Transaction flow
     // Notes for fCreateSalesDocument : 
     private string _altsalesdoctype1; 
     [XafDisplayName("Alt. Sales Doc. Type 1"), ToolTip("Alt.sales doc.type 1")] 
     // [Appearance("fCreateSalesDocumentaltsalesdoctype1", Enabled = true)]
     // [Appearance("fCreateSalesDocumentaltsalesdoctype1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private string _altsalesdoctype2; 
     [XafDisplayName("Alt. Sales Doc. Type 2"), ToolTip("Alt.sales doc.type 2")] 
     // [Appearance("fCreateSalesDocumentaltsalesdoctype2", Enabled = true)]
     // [Appearance("fCreateSalesDocumentaltsalesdoctype2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private string _codeforovervscr; 
     [XafDisplayName("Fcode for Overv. Scr."), ToolTip("Fcode for overv.scr.")] 
     // [Appearance("fCreateSalesDocumentcodeforovervscr", Enabled = true)]
     // [Appearance("fCreateSalesDocumentcodeforovervscrVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private string _docpricproced; 
     [XafDisplayName("Doc. Pric. Procedure"), ToolTip("Doc.pric.procedure")] 
     // [Appearance("fCreateSalesDocumentdocpricproced", Enabled = true)]
     // [Appearance("fCreateSalesDocumentdocpricprocedVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private string _dsplyrange; 
     [XafDisplayName("Display Range"), ToolTip("Display Range")] 
     // [Appearance("fCreateSalesDocumentdsplyrange", Enabled = true)]
     // [Appearance("fCreateSalesDocumentdsplyrangeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private bool _incmpltmsg; 
     [XafDisplayName("Incomplete Messages"), ToolTip("Incomplet.messages")] 
     // [Appearance("fCreateSalesDocumentincmpltmsg", Enabled = true)]
     // [Appearance("fCreateSalesDocumentincmpltmsgVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool incmpltmsg
     { 
       get { return _incmpltmsg; } 
       set { SetPropertyValue(nameof(incmpltmsg), ref _incmpltmsg, value); } 
     } 
     // Transaction flow
     // Notes for fCreateSalesDocument : 
     private string _incomplproced; 
     [XafDisplayName("Incompl. Proced"), ToolTip("Incompl. Proced")] 
     // [Appearance("fCreateSalesDocumentincomplproced", Enabled = true)]
     // [Appearance("fCreateSalesDocumentincomplprocedVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private string _msgmastcontr; 
     [XafDisplayName("Message: Mast. Contr."), ToolTip("Message: Mast.contr.")] 
     // [Appearance("fCreateSalesDocumentmsgmastcontr", Enabled = true)]
     // [Appearance("fCreateSalesDocumentmsgmastcontrVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private string _outlineagrmtmess; 
     [XafDisplayName("Outline Agrmt Mess."), ToolTip("Outline agrmt mess.")] 
     // [Appearance("fCreateSalesDocumentoutlineagrmtmess", Enabled = true)]
     // [Appearance("fCreateSalesDocumentoutlineagrmtmessVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private string _prodattrmsg; 
     [XafDisplayName("Prod. Attr. Messages"), ToolTip("ProdAttr.messages")] 
     // [Appearance("fCreateSalesDocumentprodattrmsg", Enabled = true)]
     // [Appearance("fCreateSalesDocumentprodattrmsgVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private string _quotmsg; 
     [XafDisplayName("Quotation Messages"), ToolTip("Quotation messages")] 
     // [Appearance("fCreateSalesDocumentquotmsg", Enabled = true)]
     // [Appearance("fCreateSalesDocumentquotmsgVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private string _screenseqgrp; 
     [XafDisplayName("Screen Sequence Group"), ToolTip("Screen sequence grp.")] 
     // [Appearance("fCreateSalesDocumentscreenseqgrp", Enabled = true)]
     // [Appearance("fCreateSalesDocumentscreenseqgrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private string _statusprof; 
     [XafDisplayName("Status Profile"), ToolTip("Status profile")] 
     // [Appearance("fCreateSalesDocumentstatusprof", Enabled = true)]
     // [Appearance("fCreateSalesDocumentstatusprofVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private string _transactgrp; 
     [XafDisplayName("Transaction Group"), ToolTip("Transaction Group")] 
     // [Appearance("fCreateSalesDocumenttransactgrp", Enabled = true)]
     // [Appearance("fCreateSalesDocumenttransactgrpVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private string _variant; 
     [XafDisplayName("Variant"), ToolTip("Variant")] 
     // [Appearance("fCreateSalesDocumentvariant", Enabled = true)]
     // [Appearance("fCreateSalesDocumentvariantVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string variant
     { 
       get { return _variant; } 
       set { SetPropertyValue(nameof(variant), ref _variant, value); } 
     } 
     // 
     // Notes for fCreateSalesDocument : 
     private string _nrobj; 
     [XafDisplayName("NR Object"), ToolTip("NR Object")] 
     // [Appearance("fCreateSalesDocumentnrobj", Enabled = true)]
     // [Appearance("fCreateSalesDocumentnrobjVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string nrobj
     { 
       get { return _nrobj; } 
       set { SetPropertyValue(nameof(nrobj), ref _nrobj, value); } 
     } 
     // 
     // Notes for fCreateSalesDocument : 
     private string _salesdocblock; 
     [XafDisplayName("Sales Document Block"), ToolTip("Sales document block")] 
     // [Appearance("fCreateSalesDocumentsalesdocblock", Enabled = true)]
     // [Appearance("fCreateSalesDocumentsalesdocblockVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(1)] 
     public  string salesdocblock
     { 
       get { return _salesdocblock; } 
       set { SetPropertyValue(nameof(salesdocblock), ref _salesdocblock, value); } 
     } 
     // 
     // Notes for fCreateSalesDocument : 
     private string _salesdoccateg; 
     [XafDisplayName("Sales Document Categ."), ToolTip("Sales document categ")] 
     // [Appearance("fCreateSalesDocumentsalesdoccateg", Enabled = true)]
     // [Appearance("fCreateSalesDocumentsalesdoccategVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateSalesDocument : 
     private string _salesdoctype; 
     [XafDisplayName("Sales Document Type"), ToolTip("Sales Document Type")] 
     // [Appearance("fCreateSalesDocumentsalesdoctype", Enabled = true)]
     // [Appearance("fCreateSalesDocumentsalesdoctypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string salesdoctype
     { 
       get { return _salesdoctype; } 
       set { SetPropertyValue(nameof(salesdoctype), ref _salesdoctype, value); } 
     } 
   } 
} 
