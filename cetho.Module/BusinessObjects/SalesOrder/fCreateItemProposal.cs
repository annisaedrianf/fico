// Class Name : fCreateItemProposal.cs 
// Project Name : FICO 
// Last Update : 06/06/2023 13:12:18  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 06/06/2023 13:12:18 
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
   [System.ComponentModel.DisplayName("Create Item Proposal: Initial Screen")]
   public class fCreateItemProposal : XPObject
   {
     public fCreateItemProposal(Session session) : base(session) 
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
     [Appearance("VisiblefCreateItemProposalOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for fCreateItemProposal : 
     private string _itmproptype; 
     [XafDisplayName("Item Proposal Type"), ToolTip("Item Proposal Type")] 
     // [Appearance("fCreateItemProposalitmproptype", Enabled = true)]
     // [Appearance("fCreateItemProposalitmproptypeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string itmproptype
     { 
       get { return _itmproptype; } 
       set { SetPropertyValue(nameof(itmproptype), ref _itmproptype, value); } 
     } 
     // Organizational Data
     // Notes for fCreateItemProposal : 
     private string _salesorgnz; 
     [XafDisplayName("Sales Organization"), ToolTip("Sales Organization")] 
     // [Appearance("fCreateItemProposalsalesorgnz", Enabled = true)]
     // [Appearance("fCreateItemProposalsalesorgnzVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string salesorgnz
     { 
       get { return _salesorgnz; } 
       set { SetPropertyValue(nameof(salesorgnz), ref _salesorgnz, value); } 
     } 
     // Organizational Data
     // Notes for fCreateItemProposal : 
     private string _distrchnl; 
     [XafDisplayName("Distribution Channel"), ToolTip("Distribution Channel")] 
     // [Appearance("fCreateItemProposaldistrchnl", Enabled = true)]
     // [Appearance("fCreateItemProposaldistrchnlVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateItemProposal : 
     private string _division; 
     [XafDisplayName("Division"), ToolTip("Division")] 
     // [Appearance("fCreateItemProposaldivision", Enabled = true)]
     // [Appearance("fCreateItemProposaldivisionVisiblen ", Visibility = ViewItemVisibility.Hide)] 
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
     // Notes for fCreateItemProposal : 
     private string _salesoffice; 
     [XafDisplayName("Sales Office"), ToolTip("Sales Office")] 
     // [Appearance("fCreateItemProposalsalesoffice", Enabled = true)]
     // [Appearance("fCreateItemProposalsalesofficeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(4)] 
     public  string salesoffice
     { 
       get { return _salesoffice; } 
       set { SetPropertyValue(nameof(salesoffice), ref _salesoffice, value); } 
     } 
     // Organizational Data
     // Notes for fCreateItemProposal : 
     private string _salesgroup; 
     [XafDisplayName("Sales Group"), ToolTip("Sales Group")] 
     // [Appearance("fCreateItemProposalsalesgroup", Enabled = true)]
     // [Appearance("fCreateItemProposalsalesgroupVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(3)] 
     public  string salesgroup
     { 
       get { return _salesgroup; } 
       set { SetPropertyValue(nameof(salesgroup), ref _salesgroup, value); } 
     } 
     // Create Item Proposal 55000058: Overview
     // Notes for fCreateItemProposal : 
     private string _itmprop; 
     [XafDisplayName("Item Proposal"), ToolTip("Item Proposal")] 
     // [Appearance("fCreateItemProposalitmprop", Enabled = true)]
     // [Appearance("fCreateItemProposalitmpropVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(20)] 
     public  string itmprop
     { 
       get { return _itmprop; } 
       set { SetPropertyValue(nameof(itmprop), ref _itmprop, value); } 
     } 
     // Create Item Proposal 55000058: Overview
     // Notes for fCreateItemProposal : 
     private string _desc; 
     [XafDisplayName("Description"), ToolTip("Description")] 
     // [Appearance("fCreateItemProposaldesc", Enabled = true)]
     // [Appearance("fCreateItemProposaldescVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(100)] 
     public  string desc
     { 
       get { return _desc; } 
       set { SetPropertyValue(nameof(desc), ref _desc, value); } 
     } 
     // Create Item Proposal 55000058: Overview
     // Notes for fCreateItemProposal : 
     private DateTime _vldfrmdate; 
     [XafDisplayName("Valid-From Date"), ToolTip("Valid-from date")] 
     // [Appearance("fCreateItemProposalvldfrmdate", Enabled = true)]
     // [Appearance("fCreateItemProposalvldfrmdateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime vldfrmdate
     { 
       get { return _vldfrmdate; } 
       set { SetPropertyValue(nameof(vldfrmdate), ref _vldfrmdate, value); } 
     } 
     // Create Item Proposal 55000058: Overview
     // Notes for fCreateItemProposal : 
     private DateTime _vlddate; 
     [XafDisplayName("Valid-To Date"), ToolTip("Valid-to date")] 
     // [Appearance("fCreateItemProposalvlddate", Enabled = true)]
     // [Appearance("fCreateItemProposalvlddateVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime vlddate
     { 
       get { return _vlddate; } 
       set { SetPropertyValue(nameof(vlddate), ref _vlddate, value); } 
     } 
     // Create Item Proposal 55000058: Overview
     // Notes for fCreateItemProposal : 
     private string _itm; 
     [XafDisplayName("Item"), ToolTip("Item")] 
     // [Appearance("fCreateItemProposalitm", Enabled = true)]
     // [Appearance("fCreateItemProposalitmVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(2)] 
     public  string itm
     { 
       get { return _itm; } 
       set { SetPropertyValue(nameof(itm), ref _itm, value); } 
     } 
     // Create Item Proposal 55000058: Overview
     // Notes for fCreateItemProposal : 
     private string _matl; 
     [XafDisplayName("Material"), ToolTip("Material")] 
     // [Appearance("fCreateItemProposalmatl", Enabled = true)]
     // [Appearance("fCreateItemProposalmatlVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string matl
     { 
       get { return _matl; } 
       set { SetPropertyValue(nameof(matl), ref _matl, value); } 
     } 
     // Create Item Proposal 55000058: Overview
     // Notes for fCreateItemProposal : 
     private string _targetqty; 
     [XafDisplayName("Target Quantity"), ToolTip("Target Quantity")] 
     // [Appearance("fCreateItemProposaltargetqty", Enabled = true)]
     // [Appearance("fCreateItemProposaltargetqtyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string targetqty
     { 
       get { return _targetqty; } 
       set { SetPropertyValue(nameof(targetqty), ref _targetqty, value); } 
     } 
   } 
} 
