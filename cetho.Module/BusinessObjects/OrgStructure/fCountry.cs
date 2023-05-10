// Class Name : fCountry.cs 
// Project Name : FICO 
// Last Update : 23/04/2023 09:02:12  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 23/04/2023 09:02:12 
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
   [DefaultProperty("name")]
   [NavigationItem("System")]
   // Standard Document
   [System.ComponentModel.DisplayName("Country")]
   public class fCountry : XPObject
   {
     public fCountry(Session session) : base(session) 
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
     [Appearance("VisiblefCountryOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for fCountry : 
     private string _country; 
     [XafDisplayName("Country"), ToolTip("Country")] 
     // [Appearance("fCountrycountry", Enabled = true)]
     // [Appearance("fCountrycountryVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(7)] 
     public  string country
     { 
       get { return _country; } 
       set { SetPropertyValue(nameof(country), ref _country, value); } 
     } 
     // 
     // Notes for fCountry : 
     private string _altrncountrykey; 
     [XafDisplayName("Altrn Country Key"), ToolTip("Altrn Country Key")] 
     // [Appearance("fCountryaltrncountrykey", Enabled = true)]
     // [Appearance("fCountryaltrncountrykeyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(25)] 
     public  string altrncountrykey
     { 
       get { return _altrncountrykey; } 
       set { SetPropertyValue(nameof(altrncountrykey), ref _altrncountrykey, value); } 
     } 
     // 
     // Notes for fCountry : 
     private string _name; 
     [XafDisplayName("Name"), ToolTip("Name")] 
     // [Appearance("fCountryname", Enabled = true)]
     // [Appearance("fCountrynameVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(250)] 
     public  string name
     { 
       get { return _name; } 
       set { SetPropertyValue(nameof(name), ref _name, value); } 
     } 
     // 
     // Notes for fCountry : 
     private string _longname; 
     [XafDisplayName("Long Name"), ToolTip("Long Name")] 
     // [Appearance("fCountrylongname", Enabled = true)]
     // [Appearance("fCountrylongnameVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(500)] 
     public  string longname
     { 
       get { return _longname; } 
       set { SetPropertyValue(nameof(longname), ref _longname, value); } 
     } 
     // 
     // Notes for fCountry : 
     private string _nationallity; 
     [XafDisplayName("Nationallity"), ToolTip("Nationallity")] 
     // [Appearance("fCountrynationallity", Enabled = true)]
     // [Appearance("fCountrynationallityVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string nationallity
     { 
       get { return _nationallity; } 
       set { SetPropertyValue(nameof(nationallity), ref _nationallity, value); } 
     } 
     // 
     // Notes for fCountry : 
     private string _nationalitylong; 
     [XafDisplayName("Nationality (Long)"), ToolTip("Nationality (Long)")] 
     // [Appearance("fCountrynationalitylong", Enabled = true)]
     // [Appearance("fCountrynationalitylongVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(50)] 
     public  string nationalitylong
     { 
       get { return _nationalitylong; } 
       set { SetPropertyValue(nameof(nationalitylong), ref _nationalitylong, value); } 
     } 
     // 
     // Notes for fCountry : 
     private fLanguage _language; 
     [XafDisplayName("Language"), ToolTip("Language")] 
     // [Appearance("fCountrylanguage", Enabled = true)]
     // [Appearance("fCountrylanguageVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  fLanguage language
     { 
       get { return _language; } 
       set { SetPropertyValue(nameof(language), ref _language, value); } 
     } 
     // 
     // Notes for fCountry : 
     [XafDisplayName("Region"), ToolTip("Region")] 
     // [Appearance("fCountryregion", Enabled = true)]
     // [Appearance("fCountryregionVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Association("CntRegion")] 
     public XPCollection<fRegion> region
     {
     get
       {
         return GetCollection<fRegion>("region"); 
       }
     }
   
   private void UpdateByTime() 
   { 
   string tUser = SecuritySystem.CurrentUserName.ToString(); 
   Updateby = Session.FindObject<ApplicationUser>(new BinaryOperator("UserName", tUser)); 
   Updatedate = DateTime.Now; 
   } 
   private ApplicationUser _Updateby; 
   [XafDisplayName("Update by"), ToolTip("Update by")] 
   // [Appearance("fCountryUpdatebyAppearance", Enabled = false)]
   public ApplicationUser Updateby 
   { 
   get { return _Updateby; } 
   set { SetPropertyValue("Updateby", ref _Updateby, value); } 
   } 
   private DateTime _Updatedate; 
   [XafDisplayName("Update date"), ToolTip("Update date")] 
   // [Appearance("fCountryUpdatedateAppearance", Enabled = false)]
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
