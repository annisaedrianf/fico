// Class Name : fCurrency.cs 
// Project Name : FICO 
// Last Update : 26/04/2023 06:30:51  
 
// Gen Code Version : 1.0.0.0  
 
// Revise ==> Revice date : 26/04/2023 06:30:51 
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
   [System.ComponentModel.DisplayName("Currency")]
   public class fCurrency : XPObject
   {
     public fCurrency(Session session) : base(session) 
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
     [Appearance("VisiblefCurrencyOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for fCurrency : 
     private string _currency; 
     [XafDisplayName("Currency"), ToolTip("Currency")] 
     // [Appearance("fCurrencycurrency", Enabled = true)]
     // [Appearance("fCurrencycurrencyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(7)] 
     public  string currency
     { 
       get { return _currency; } 
       set { SetPropertyValue(nameof(currency), ref _currency, value); } 
     } 
     // 
     // Notes for fCurrency : 
     private string _longtext; 
     [XafDisplayName("Long Text"), ToolTip("Long Text")] 
     // [Appearance("fCurrencylongtext", Enabled = true)]
     // [Appearance("fCurrencylongtextVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(250)] 
     public  string longtext
     { 
       get { return _longtext; } 
       set { SetPropertyValue(nameof(longtext), ref _longtext, value); } 
     } 
     // 
     // Notes for fCurrency : 
     private string _shorttext; 
     [XafDisplayName("Short Text"), ToolTip("Short Text")] 
     // [Appearance("fCurrencyshorttext", Enabled = true)]
     // [Appearance("fCurrencyshorttextVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(150)] 
     public  string shorttext
     { 
       get { return _shorttext; } 
       set { SetPropertyValue(nameof(shorttext), ref _shorttext, value); } 
     } 
     // 
     // Notes for fCurrency : 
     private string _isocode; 
     [XafDisplayName("ISO Code"), ToolTip("ISO Code")] 
     // [Appearance("fCurrencyisocode", Enabled = true)]
     // [Appearance("fCurrencyisocodeVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string isocode
     { 
       get { return _isocode; } 
       set { SetPropertyValue(nameof(isocode), ref _isocode, value); } 
     } 
     // 
     // Notes for fCurrency : 
     private string _alternativekey; 
     [XafDisplayName("Alternative Key"), ToolTip("Alternative Key")] 
     // [Appearance("fCurrencyalternativekey", Enabled = true)]
     // [Appearance("fCurrencyalternativekeyVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Size(30)] 
     public  string alternativekey
     { 
       get { return _alternativekey; } 
       set { SetPropertyValue(nameof(alternativekey), ref _alternativekey, value); } 
     } 
     // 
     // Notes for fCurrency : 
     private DateTime _validuntil; 
     [XafDisplayName("Valid Until"), ToolTip("Valid Until")] 
     // [Appearance("fCurrencyvaliduntil", Enabled = true)]
     // [Appearance("fCurrencyvaliduntilVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime validuntil
     { 
       get { return _validuntil; } 
       set { SetPropertyValue(nameof(validuntil), ref _validuntil, value); } 
     } 
     // 
     // Notes for fCurrency : 
     private bool _primary; 
     [XafDisplayName("Primary"), ToolTip("Primary")] 
     // [Appearance("fCurrencyprimary", Enabled = true)]
     // [Appearance("fCurrencyprimaryVisiblen ", Visibility = ViewItemVisibility.Hide)] 
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool primary
     { 
       get { return _primary; } 
       set { SetPropertyValue(nameof(primary), ref _primary, value); } 
     } 
   
   private void UpdateByTime() 
   { 
   string tUser = SecuritySystem.CurrentUserName.ToString(); 
   Updateby = Session.FindObject<ApplicationUser>(new BinaryOperator("UserName", tUser)); 
   Updatedate = DateTime.Now; 
   } 
   private ApplicationUser _Updateby; 
   [XafDisplayName("Update by"), ToolTip("Update by")] 
   // [Appearance("fCurrencyUpdatebyAppearance", Enabled = false)]
   public ApplicationUser Updateby 
   { 
   get { return _Updateby; } 
   set { SetPropertyValue("Updateby", ref _Updateby, value); } 
   } 
   private DateTime _Updatedate; 
   [XafDisplayName("Update date"), ToolTip("Update date")] 
   // [Appearance("fCurrencyUpdatedateAppearance", Enabled = false)]
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
