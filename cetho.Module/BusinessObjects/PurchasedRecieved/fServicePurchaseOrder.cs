// Class Name : fServicePurchaseOrder.cs 
// Project Name : FICO 
// Last Update : 14/06/2023 13:20:12  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 14/06/2023 13:20:12 
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
   [System.ComponentModel.DisplayName("Service Purchase Order")]
   public class fServicePurchaseOrder : XPObject
   {
     public fServicePurchaseOrder(Session session) : base(session) 
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
     [Appearance("VisiblefServicePurchaseOrderOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // Account Assignment
     // Notes for fServicePurchaseOrder : 
     private enumAccAssCat _accasscat; 
     [XafDisplayName("AccAssCat"), ToolTip("AccAssCat")] 
     // [Appearance("fServicePurchaseOrderaccasscat", Enabled = true)]
     // [Appearance("fServicePurchaseOrderaccasscatVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumAccAssCat accasscat
     { 
       get { return _accasscat; } 
       set { SetPropertyValue(nameof(accasscat), ref _accasscat, value); } 
     } 
     // Account Assignment
     // Notes for fServicePurchaseOrder : 
     private fCompany _cocode; 
     [XafDisplayName("CoCode"), ToolTip("CoCode")] 
     // [Appearance("fServicePurchaseOrdercocode", Enabled = true)]
     // [Appearance("fServicePurchaseOrdercocodeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCompany cocode
     { 
       get { return _cocode; } 
       set { SetPropertyValue(nameof(cocode), ref _cocode, value); } 
     } 
     // Account Assignment
     // Notes for fServicePurchaseOrder : 
     private string _costctr1; 
     [XafDisplayName("Cost Center "), ToolTip("Cost Center ")] 
     // [Appearance("fServicePurchaseOrdercostctr1", Enabled = true)]
     // [Appearance("fServicePurchaseOrdercostctr1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string costctr1
     { 
       get { return _costctr1; } 
       set { SetPropertyValue(nameof(costctr1), ref _costctr1, value); } 
     } 
     // Account Assignment
     // Notes for fServicePurchaseOrder : 
     private bool _d; 
     [XafDisplayName("D"), ToolTip("D")] 
     // [Appearance("fServicePurchaseOrderd", Enabled = true)]
     // [Appearance("fServicePurchaseOrderdVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool d
     { 
       get { return _d; } 
       set { SetPropertyValue(nameof(d), ref _d, value); } 
     } 
     // Account Assignment
     // Notes for fServicePurchaseOrder : 
     private enumDistrib _distribution; 
     [XafDisplayName("Distribution"), ToolTip("Distribution")] 
     // [Appearance("fServicePurchaseOrderdistribution", Enabled = true)]
     // [Appearance("fServicePurchaseOrderdistributionVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumDistrib distribution
     { 
       get { return _distribution; } 
       set { SetPropertyValue(nameof(distribution), ref _distribution, value); } 
     } 
     // Account Assignment
     // Notes for fServicePurchaseOrder : 
     private fGLAcct _glacct1; 
     [XafDisplayName("G/L Account "), ToolTip("G/L Account ")] 
     // [Appearance("fServicePurchaseOrderglacct1", Enabled = true)]
     // [Appearance("fServicePurchaseOrderglacct1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fGLAcct glacct1
     { 
       get { return _glacct1; } 
       set { SetPropertyValue(nameof(glacct1), ref _glacct1, value); } 
     } 
     // Account Assignment
     // Notes for fServicePurchaseOrder : 
     private enumPartialInv _partialinv; 
     [XafDisplayName("Partial Inv."), ToolTip("Partial Inv.")] 
     // [Appearance("fServicePurchaseOrderpartialinv", Enabled = true)]
     // [Appearance("fServicePurchaseOrderpartialinvVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumPartialInv partialinv
     { 
       get { return _partialinv; } 
       set { SetPropertyValue(nameof(partialinv), ref _partialinv, value); } 
     } 
     // Account Assignment
     // Notes for fServicePurchaseOrder : 
     private double _perce; 
     [XafDisplayName("Perce"), ToolTip("Perce")] 
     // [Appearance("fServicePurchaseOrderperce", Enabled = true)]
     // [Appearance("fServicePurchaseOrderperceVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double perce
     { 
       get { return _perce; } 
       set { SetPropertyValue(nameof(perce), ref _perce, value); } 
     } 
     // Account Assignment
     // Notes for fServicePurchaseOrder : 
     private double _qty; 
     [XafDisplayName("Quantity"), ToolTip("Quantity")] 
     // [Appearance("fServicePurchaseOrderqty", Enabled = true)]
     // [Appearance("fServicePurchaseOrderqtyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double qty
     { 
       get { return _qty; } 
       set { SetPropertyValue(nameof(qty), ref _qty, value); } 
     } 
     // Account Assignment
     // Notes for fServicePurchaseOrder : 
     private string _recepient; 
     [XafDisplayName("Recepient"), ToolTip("Recepient")] 
     // [Appearance("fServicePurchaseOrderrecepient", Enabled = true)]
     // [Appearance("fServicePurchaseOrderrecepientVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string recepient
     { 
       get { return _recepient; } 
       set { SetPropertyValue(nameof(recepient), ref _recepient, value); } 
     } 
     // Account Assignment
     // Notes for fServicePurchaseOrder : 
     private string _unloadpoint; 
     [XafDisplayName("Unloading Point"), ToolTip("Unloading Point")] 
     // [Appearance("fServicePurchaseOrderunloadpoint", Enabled = true)]
     // [Appearance("fServicePurchaseOrderunloadpointVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string unloadpoint
     { 
       get { return _unloadpoint; } 
       set { SetPropertyValue(nameof(unloadpoint), ref _unloadpoint, value); } 
     } 
     // Account Assignment of Service in Line 10
     // Notes for fServicePurchaseOrder : 
     private fGLAcct _glacct; 
     [XafDisplayName("G/L Account"), ToolTip("G/L Account")] 
     // [Appearance("fServicePurchaseOrderglacct", Enabled = true)]
     // [Appearance("fServicePurchaseOrderglacctVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fGLAcct glacct
     { 
       get { return _glacct; } 
       set { SetPropertyValue(nameof(glacct), ref _glacct, value); } 
     } 
     // Account Assignment of Service in Line 11
     // Notes for fServicePurchaseOrder : 
     private string _coarea; 
     [XafDisplayName("CO Area"), ToolTip("CO Area")] 
     // [Appearance("fServicePurchaseOrdercoarea", Enabled = true)]
     // [Appearance("fServicePurchaseOrdercoareaVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string coarea
     { 
       get { return _coarea; } 
       set { SetPropertyValue(nameof(coarea), ref _coarea, value); } 
     } 
     // Account Assignment of Service in Line 12
     // Notes for fServicePurchaseOrder : 
     private string _costctr; 
     [XafDisplayName("Cost Center"), ToolTip("Cost Center")] 
     // [Appearance("fServicePurchaseOrdercostctr", Enabled = true)]
     // [Appearance("fServicePurchaseOrdercostctrVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string costctr
     { 
       get { return _costctr; } 
       set { SetPropertyValue(nameof(costctr), ref _costctr, value); } 
     } 
     // Account Assignment of Service in Line 13
     // Notes for fServicePurchaseOrder : 
     private fCompany _compcode; 
     [XafDisplayName("Company Code"), ToolTip("Company Code")] 
     // [Appearance("fServicePurchaseOrdercompcode", Enabled = true)]
     // [Appearance("fServicePurchaseOrdercompcodeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fCompany compcode
     { 
       get { return _compcode; } 
       set { SetPropertyValue(nameof(compcode), ref _compcode, value); } 
     } 
     // Additional Data
     // Notes for fServicePurchaseOrder : 
     private string _collectno; 
     [XafDisplayName("Collective No."), ToolTip("Collective No.")] 
     // [Appearance("fServicePurchaseOrdercollectno", Enabled = true)]
     // [Appearance("fServicePurchaseOrdercollectnoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(10)] 
     public  string collectno
     { 
       get { return _collectno; } 
       set { SetPropertyValue(nameof(collectno), ref _collectno, value); } 
     } 
     // Additional Data
     // Notes for fServicePurchaseOrder : 
     private DateTime _validend; 
     [XafDisplayName("Validity End"), ToolTip("Validity End")] 
     // [Appearance("fServicePurchaseOrdervalidend", Enabled = true)]
     // [Appearance("fServicePurchaseOrdervalidendVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime validend
     { 
       get { return _validend; } 
       set { SetPropertyValue(nameof(validend), ref _validend, value); } 
     } 
     // Additional Data
     // Notes for fServicePurchaseOrder : 
     private DateTime _validstart; 
     [XafDisplayName("Validity Start"), ToolTip("Validity Start")] 
     // [Appearance("fServicePurchaseOrdervalidstart", Enabled = true)]
     // [Appearance("fServicePurchaseOrdervalidstartVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime validstart
     { 
       get { return _validstart; } 
       set { SetPropertyValue(nameof(validstart), ref _validstart, value); } 
     } 
     // Additional Data
     // Notes for fServicePurchaseOrder : 
     private string _vatno; 
     [XafDisplayName("VAT No."), ToolTip("VAT No.")] 
     // [Appearance("fServicePurchaseOrdervatno", Enabled = true)]
     // [Appearance("fServicePurchaseOrdervatnoVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string vatno
     { 
       get { return _vatno; } 
       set { SetPropertyValue(nameof(vatno), ref _vatno, value); } 
     } 
     // Contract limits
     // Notes for fServicePurchaseOrder : 
     private double _actvalue1; 
     [XafDisplayName("Actual Value "), ToolTip("Actual Value ")] 
     // [Appearance("fServicePurchaseOrderactvalue1", Enabled = true)]
     // [Appearance("fServicePurchaseOrderactvalue1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double actvalue1
     { 
       get { return _actvalue1; } 
       set { SetPropertyValue(nameof(actvalue1), ref _actvalue1, value); } 
     } 
     // Contract limits
     // Notes for fServicePurchaseOrder : 
     private string _contract; 
     [XafDisplayName("Contract"), ToolTip("Contract")] 
     // [Appearance("fServicePurchaseOrdercontract", Enabled = true)]
     // [Appearance("fServicePurchaseOrdercontractVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string contract
     { 
       get { return _contract; } 
       set { SetPropertyValue(nameof(contract), ref _contract, value); } 
     } 
     // Contract limits
     // Notes for fServicePurchaseOrder : 
     private string _item; 
     [XafDisplayName("Item"), ToolTip("Item")] 
     // [Appearance("fServicePurchaseOrderitem", Enabled = true)]
     // [Appearance("fServicePurchaseOrderitemVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string item
     { 
       get { return _item; } 
       set { SetPropertyValue(nameof(item), ref _item, value); } 
     } 
     // Contract limits
     // Notes for fServicePurchaseOrder : 
     private string _limit; 
     [XafDisplayName("Limit"), ToolTip("Limit")] 
     // [Appearance("fServicePurchaseOrderlimit", Enabled = true)]
     // [Appearance("fServicePurchaseOrderlimitVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string limit
     { 
       get { return _limit; } 
       set { SetPropertyValue(nameof(limit), ref _limit, value); } 
     } 
     // Contract limits
     // Notes for fServicePurchaseOrder : 
     private string _shorttext; 
     [XafDisplayName("Short Text"), ToolTip("Short Text")] 
     // [Appearance("fServicePurchaseOrdershorttext", Enabled = true)]
     // [Appearance("fServicePurchaseOrdershorttextVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string shorttext
     { 
       get { return _shorttext; } 
       set { SetPropertyValue(nameof(shorttext), ref _shorttext, value); } 
     } 
     // Delivery
     // Notes for fServicePurchaseOrder : 
     private string _rem1; 
     [XafDisplayName("1st Rem./Exped."), ToolTip("1st Rem./Exped.")] 
     // [Appearance("fServicePurchaseOrderrem1", Enabled = true)]
     // [Appearance("fServicePurchaseOrderrem1Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string rem1
     { 
       get { return _rem1; } 
       set { SetPropertyValue(nameof(rem1), ref _rem1, value); } 
     } 
     // Delivery
     // Notes for fServicePurchaseOrder : 
     private string _rem2; 
     [XafDisplayName("2nd Rem./Exped."), ToolTip("2nd Rem./Exped.")] 
     // [Appearance("fServicePurchaseOrderrem2", Enabled = true)]
     // [Appearance("fServicePurchaseOrderrem2Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string rem2
     { 
       get { return _rem2; } 
       set { SetPropertyValue(nameof(rem2), ref _rem2, value); } 
     } 
     // Delivery
     // Notes for fServicePurchaseOrder : 
     private string _rem3; 
     [XafDisplayName("3rd Rem./Exped."), ToolTip("3rd Rem./Exped.")] 
     // [Appearance("fServicePurchaseOrderrem3", Enabled = true)]
     // [Appearance("fServicePurchaseOrderrem3Visiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string rem3
     { 
       get { return _rem3; } 
       set { SetPropertyValue(nameof(rem3), ref _rem3, value); } 
     } 
     // Delivery
     // Notes for fServicePurchaseOrder : 
     private bool _goodsreceipt; 
     [XafDisplayName("Goods Receipt"), ToolTip("Goods Receipt")] 
     // [Appearance("fServicePurchaseOrdergoodsreceipt", Enabled = true)]
     // [Appearance("fServicePurchaseOrdergoodsreceiptVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool goodsreceipt
     { 
       get { return _goodsreceipt; } 
       set { SetPropertyValue(nameof(goodsreceipt), ref _goodsreceipt, value); } 
     } 
     // Delivery
     // Notes for fServicePurchaseOrder : 
     private bool _grnonvaluat; 
     [XafDisplayName("GR Non-Valuated"), ToolTip("GR Non-Valuated")] 
     // [Appearance("fServicePurchaseOrdergrnonvaluat", Enabled = true)]
     // [Appearance("fServicePurchaseOrdergrnonvaluatVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool grnonvaluat
     { 
       get { return _grnonvaluat; } 
       set { SetPropertyValue(nameof(grnonvaluat), ref _grnonvaluat, value); } 
     } 
     // Delivery
     // Notes for fServicePurchaseOrder : 
     private string _incoterms; 
     [XafDisplayName("Incoterms"), ToolTip("Incoterms")] 
     // [Appearance("fServicePurchaseOrderincoterms", Enabled = true)]
     // [Appearance("fServicePurchaseOrderincotermsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string incoterms
     { 
       get { return _incoterms; } 
       set { SetPropertyValue(nameof(incoterms), ref _incoterms, value); } 
     } 
     // Delivery
     // Notes for fServicePurchaseOrder : 
     private string _noexped; 
     [XafDisplayName("No. Exped."), ToolTip("No. Exped.")] 
     // [Appearance("fServicePurchaseOrdernoexped", Enabled = true)]
     // [Appearance("fServicePurchaseOrdernoexpedVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string noexped
     { 
       get { return _noexped; } 
       set { SetPropertyValue(nameof(noexped), ref _noexped, value); } 
     } 
     // Delivery
     // Notes for fServicePurchaseOrder : 
     private string _overdtol; 
     [XafDisplayName("Overdeliv. Tol"), ToolTip("Overdeliv. Tol")] 
     // [Appearance("fServicePurchaseOrderoverdtol", Enabled = true)]
     // [Appearance("fServicePurchaseOrderoverdtolVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(5)] 
     public  string overdtol
     { 
       get { return _overdtol; } 
       set { SetPropertyValue(nameof(overdtol), ref _overdtol, value); } 
     } 
     // Delivery
     // Notes for fServicePurchaseOrder : 
     private string _pidelivtime; 
     [XafDisplayName("PI. Deliv. Time"), ToolTip("PI. Deliv. Time")] 
     // [Appearance("fServicePurchaseOrderpidelivtime", Enabled = true)]
     // [Appearance("fServicePurchaseOrderpidelivtimeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string pidelivtime
     { 
       get { return _pidelivtime; } 
       set { SetPropertyValue(nameof(pidelivtime), ref _pidelivtime, value); } 
     } 
     // Delivery
     // Notes for fServicePurchaseOrder : 
     private enumQACtrlKey _qactrlkey; 
     [XafDisplayName("QA Control Key"), ToolTip("QA Control Key")] 
     // [Appearance("fServicePurchaseOrderqactrlkey", Enabled = true)]
     // [Appearance("fServicePurchaseOrderqactrlkeyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  enumQACtrlKey qactrlkey
     { 
       get { return _qactrlkey; } 
       set { SetPropertyValue(nameof(qactrlkey), ref _qactrlkey, value); } 
     } 
     // Delivery
     // Notes for fServicePurchaseOrder : 
     private bool _unlimited; 
     [XafDisplayName("Unlimited"), ToolTip("Unlimited")] 
     // [Appearance("fServicePurchaseOrderunlimited", Enabled = true)]
     // [Appearance("fServicePurchaseOrderunlimitedVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool unlimited
     { 
       get { return _unlimited; } 
       set { SetPropertyValue(nameof(unlimited), ref _unlimited, value); } 
     } 
     // Limits
     // Notes for fServicePurchaseOrder : 
     private double _actvalue; 
     [XafDisplayName("Actual Value"), ToolTip("Actual Value")] 
     // [Appearance("fServicePurchaseOrderactvalue", Enabled = true)]
     // [Appearance("fServicePurchaseOrderactvalueVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double actvalue
     { 
       get { return _actvalue; } 
       set { SetPropertyValue(nameof(actvalue), ref _actvalue, value); } 
     } 
     // Limits
     // Notes for fServicePurchaseOrder : 
     private double _expectvalue; 
     [XafDisplayName("Expected value"), ToolTip("Expected value")] 
     // [Appearance("fServicePurchaseOrderexpectvalue", Enabled = true)]
     // [Appearance("fServicePurchaseOrderexpectvalueVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double expectvalue
     { 
       get { return _expectvalue; } 
       set { SetPropertyValue(nameof(expectvalue), ref _expectvalue, value); } 
     } 
     // Limits
     // Notes for fServicePurchaseOrder : 
     private bool _nolimit; 
     [XafDisplayName("No limit"), ToolTip("No limit")] 
     // [Appearance("fServicePurchaseOrdernolimit", Enabled = true)]
     // [Appearance("fServicePurchaseOrdernolimitVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool nolimit
     { 
       get { return _nolimit; } 
       set { SetPropertyValue(nameof(nolimit), ref _nolimit, value); } 
     } 
     // Limits
     // Notes for fServicePurchaseOrder : 
     private double _overallimit; 
     [XafDisplayName("Overall Limit"), ToolTip("Overall Limit")] 
     // [Appearance("fServicePurchaseOrderoverallimit", Enabled = true)]
     // [Appearance("fServicePurchaseOrderoverallimitVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  double overallimit
     { 
       get { return _overallimit; } 
       set { SetPropertyValue(nameof(overallimit), ref _overallimit, value); } 
     } 
   } 
} 
