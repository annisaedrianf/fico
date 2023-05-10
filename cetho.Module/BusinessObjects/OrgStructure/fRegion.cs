// Class Name : fRegion.cs 
// Project Name : FICO 
// Last Update : 26/04/2023 06:34:12  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 26/04/2023 06:34:12 
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
using DevExpress.Persistent.BaseImpl;

namespace cetho.Module.BusinessObjects 
{ 
   [DefaultClassOptions] 
   [ImageName("ModelEditor_Views")] 
   [DefaultProperty("shorttext")]
   [NavigationItem("System")]
   // Standard Document
   [System.ComponentModel.DisplayName("Region")]
   public class fRegion : XPObject
   {
     public fRegion(Session session) : base(session) 
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
       UpdateByTime(); 
     } 
     protected override void OnSaving()
     {
        base.OnSaving();
        UpdateByTime(); 
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
     [Appearance("VisiblefRegionOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for fRegion : 
     private string _region; 
     [XafDisplayName("Region"), ToolTip("Region")] 
     // [Appearance("fRegionregion", Enabled = true)]
     // [Appearance("fRegionregionVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(7)] 
     public  string region
     { 
       get { return _region; } 
       set { SetPropertyValue(nameof(region), ref _region, value); } 
     } 
     // 
     // Notes for fRegion : 
     private string _shorttext; 
     [XafDisplayName("Short Text"), ToolTip("Short Text")] 
     // [Appearance("fRegionshorttext", Enabled = true)]
     // [Appearance("fRegionshorttextVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(25)] 
     public  string shorttext
     { 
       get { return _shorttext; } 
       set { SetPropertyValue(nameof(shorttext), ref _shorttext, value); } 
     } 
     // 
     // Notes for fRegion : 
     private string _description; 
     [XafDisplayName("Description"), ToolTip("Description")] 
     // [Appearance("fRegiondescription", Enabled = true)]
     // [Appearance("fRegiondescriptionVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(250)] 
     public  string description
     { 
       get { return _description; } 
       set { SetPropertyValue(nameof(description), ref _description, value); } 
     } 
     // 
     // Notes for fRegion : 
     private fCountry _country; 
     [XafDisplayName("Country"), ToolTip("Country")] 
     // [Appearance("fRegioncountry", Enabled = true)]
     // [Appearance("fRegioncountryVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Association("CntRegion")] 
     public  fCountry country
     { 
       get { return _country; } 
       set { SetPropertyValue(nameof(country), ref _country, value); } 
     } 
   
   private void UpdateByTime() 
   { 
   string tUser = SecuritySystem.CurrentUserName.ToString(); 
   Updateby = Session.FindObject<ApplicationUser>(new BinaryOperator("UserName", tUser)); 
   Updatedate = DateTime.Now; 
   } 
   private ApplicationUser _Updateby; 
   [XafDisplayName("Update by"), ToolTip("Update by")] 
   // [Appearance("fRegionUpdatebyAppearance", Enabled = false)]
   public ApplicationUser Updateby 
   { 
   get { return _Updateby; } 
   set { SetPropertyValue("Updateby", ref _Updateby, value); } 
   } 
   private DateTime _Updatedate; 
   [XafDisplayName("Update date"), ToolTip("Update date")] 
   // [Appearance("fRegionUpdatedateAppearance", Enabled = false)]
   public DateTime Updatedate 
   { 
   get 
   { 
    
   return _Updatedate; 
   } 
   set { SetPropertyValue("Updatedate", ref _Updatedate, value); } 
   } 
   } 
} 
