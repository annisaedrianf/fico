// Class Name : fTextDetermination.cs 
// Project Name : FICO 
// Last Update : 06/06/2023 13:10:50  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 06/06/2023 13:10:50 
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
   [System.ComponentModel.DisplayName("Customizing Text Determination")]
   public class fTextDetermination : XPObject
   {
     public fTextDetermination(Session session) : base(session) 
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
     [Appearance("VisiblefTextDeterminationOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // Text Object
     // Notes for fTextDetermination : 
     private bool _cntrltext; 
     [XafDisplayName("Central Texts"), ToolTip("Central Texts")] 
     // [Appearance("fTextDeterminationcntrltext", Enabled = true)]
     // [Appearance("fTextDeterminationcntrltextVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool cntrltext
     { 
       get { return _cntrltext; } 
       set { SetPropertyValue(nameof(cntrltext), ref _cntrltext, value); } 
     } 
     // Text Object
     // Notes for fTextDetermination : 
     private bool _contractperson; 
     [XafDisplayName("Contract Person"), ToolTip("Contract Person")] 
     // [Appearance("fTextDeterminationcontractperson", Enabled = true)]
     // [Appearance("fTextDeterminationcontractpersonVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool contractperson
     { 
       get { return _contractperson; } 
       set { SetPropertyValue(nameof(contractperson), ref _contractperson, value); } 
     } 
     // Text Object
     // Notes for fTextDetermination : 
     private bool _salesdistr; 
     [XafDisplayName("Sales & Distribution"), ToolTip("Sales & Distribution")] 
     // [Appearance("fTextDeterminationsalesdistr", Enabled = true)]
     // [Appearance("fTextDeterminationsalesdistrVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool salesdistr
     { 
       get { return _salesdistr; } 
       set { SetPropertyValue(nameof(salesdistr), ref _salesdistr, value); } 
     } 
     // Text Object
     // Notes for fTextDetermination : 
     private bool _cust; 
     [XafDisplayName("Cust./Material"), ToolTip("Cust./Material")] 
     // [Appearance("fTextDeterminationcust", Enabled = true)]
     // [Appearance("fTextDeterminationcustVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool cust
     { 
       get { return _cust; } 
       set { SetPropertyValue(nameof(cust), ref _cust, value); } 
     } 
     // Text Object
     // Notes for fTextDetermination : 
     private bool _agree; 
     [XafDisplayName("Agreements"), ToolTip("Agreements")] 
     // [Appearance("fTextDeterminationagree", Enabled = true)]
     // [Appearance("fTextDeterminationagreeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool agree
     { 
       get { return _agree; } 
       set { SetPropertyValue(nameof(agree), ref _agree, value); } 
     } 
     // Text Object
     // Notes for fTextDetermination : 
     private bool _conditions; 
     [XafDisplayName("Conditions"), ToolTip("Conditions")] 
     // [Appearance("fTextDeterminationconditions", Enabled = true)]
     // [Appearance("fTextDeterminationconditionsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool conditions
     { 
       get { return _conditions; } 
       set { SetPropertyValue(nameof(conditions), ref _conditions, value); } 
     } 
     // Text Object
     // Notes for fTextDetermination : 
     private bool _head; 
     [XafDisplayName("Header"), ToolTip("Header")] 
     // [Appearance("fTextDeterminationhead", Enabled = true)]
     // [Appearance("fTextDeterminationheadVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool head
     { 
       get { return _head; } 
       set { SetPropertyValue(nameof(head), ref _head, value); } 
     } 
     // Text Object
     // Notes for fTextDetermination : 
     private bool _item; 
     [XafDisplayName("Item"), ToolTip("Item")] 
     // [Appearance("fTextDeterminationitem", Enabled = true)]
     // [Appearance("fTextDeterminationitemVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool item
     { 
       get { return _item; } 
       set { SetPropertyValue(nameof(item), ref _item, value); } 
     } 
   } 
} 
