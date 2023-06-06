// Class Name : fCreatePartner.cs 
// Project Name : FICO 
// Last Update : 06/06/2023 13:48:16  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 06/06/2023 13:48:16 
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
   [System.ComponentModel.DisplayName("Maintain: Partner Determination")]
   public class fCreatePartner : XPObject
   {
     public fCreatePartner(Session session) : base(session) 
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
     [Appearance("VisiblefCreatePartnerOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // Partner Obejct
     // Notes for fCreatePartner : 
     private bool _cutsmaster; 
     [XafDisplayName("Cust. Master"), ToolTip("Cust.Master")] 
     // [Appearance("fCreatePartnercutsmaster", Enabled = true)]
     // [Appearance("fCreatePartnercutsmasterVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool cutsmaster
     { 
       get { return _cutsmaster; } 
       set { SetPropertyValue(nameof(cutsmaster), ref _cutsmaster, value); } 
     } 
     // Partner Obejct
     // Notes for fCreatePartner : 
     private bool _salesdochead; 
     [XafDisplayName("Sales Doc Header"), ToolTip("Sales Doc Header")] 
     // [Appearance("fCreatePartnersalesdochead", Enabled = true)]
     // [Appearance("fCreatePartnersalesdocheadVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool salesdochead
     { 
       get { return _salesdochead; } 
       set { SetPropertyValue(nameof(salesdochead), ref _salesdochead, value); } 
     } 
     // Partner Obejct
     // Notes for fCreatePartner : 
     private bool _salesdocitem; 
     [XafDisplayName("Sales Document Item"), ToolTip("Sales Document Item")] 
     // [Appearance("fCreatePartnersalesdocitem", Enabled = true)]
     // [Appearance("fCreatePartnersalesdocitemVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool salesdocitem
     { 
       get { return _salesdocitem; } 
       set { SetPropertyValue(nameof(salesdocitem), ref _salesdocitem, value); } 
     } 
     // Partner Obejct
     // Notes for fCreatePartner : 
     private bool _delivery; 
     [XafDisplayName("Delivery"), ToolTip("Delivery")] 
     // [Appearance("fCreatePartnerdelivery", Enabled = true)]
     // [Appearance("fCreatePartnerdeliveryVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool delivery
     { 
       get { return _delivery; } 
       set { SetPropertyValue(nameof(delivery), ref _delivery, value); } 
     } 
     // Partner Obejct
     // Notes for fCreatePartner : 
     private bool _shipment; 
     [XafDisplayName("Shipment"), ToolTip("Shipment")] 
     // [Appearance("fCreatePartnershipment", Enabled = true)]
     // [Appearance("fCreatePartnershipmentVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool shipment
     { 
       get { return _shipment; } 
       set { SetPropertyValue(nameof(shipment), ref _shipment, value); } 
     } 
     // Partner Obejct
     // Notes for fCreatePartner : 
     private bool _billhead; 
     [XafDisplayName("Bill Header"), ToolTip("Bill Header")] 
     // [Appearance("fCreatePartnerbillhead", Enabled = true)]
     // [Appearance("fCreatePartnerbillheadVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool billhead
     { 
       get { return _billhead; } 
       set { SetPropertyValue(nameof(billhead), ref _billhead, value); } 
     } 
     // Partner Obejct
     // Notes for fCreatePartner : 
     private bool _billitem; 
     [XafDisplayName("Billing Item"), ToolTip("Billing Item")] 
     // [Appearance("fCreatePartnerbillitem", Enabled = true)]
     // [Appearance("fCreatePartnerbillitemVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool billitem
     { 
       get { return _billitem; } 
       set { SetPropertyValue(nameof(billitem), ref _billitem, value); } 
     } 
     // Partner Obejct
     // Notes for fCreatePartner : 
     private bool _sisacts; 
     [XafDisplayName("Sis Acts (CAS)"), ToolTip("Sis Acts (CAS)")] 
     // [Appearance("fCreatePartnersisacts", Enabled = true)]
     // [Appearance("fCreatePartnersisactsVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool sisacts
     { 
       get { return _sisacts; } 
       set { SetPropertyValue(nameof(sisacts), ref _sisacts, value); } 
     } 
   } 
} 
