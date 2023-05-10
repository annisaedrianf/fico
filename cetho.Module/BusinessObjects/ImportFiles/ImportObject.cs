// Class Name : nOutlet.cs 
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
using DevExpress.ExpressApp.Editors;

namespace cetho.Module.BusinessObjects
{ 
   [DefaultClassOptions] 
   [ImageName("ModelEditor_Views")] 
   [DefaultProperty("ObjectName")]
   [NavigationItem("Sync")]
   // Standard Document
   [System.ComponentModel.DisplayName("Import Object")]
   public class ImportObject : XPObject
   {
     //public ImportObject() : base()
     //{
     //// This constructor is used when an object is loaded from a persistent storage.
     //// Do not place any code here.
     //}
     public ImportObject(Session session) : base(session) 
     {
       // This constructor is used when an object is loaded from a persistent storage.
       // Do not place any code here.
     }
     public override void AfterConstruction()
     {
       base.AfterConstruction();
       string tUser = SecuritySystem.CurrentUserName.ToString();

     } 
     protected override void OnSaving()
     {
       base.OnSaving();
     } 
     protected override void OnDeleting()
     {
       base.OnDeleting();
     }


    //private string _Title;
    //[XafDisplayName("Title"), ToolTip("Title")]
    //[Appearance("ImportColomnTitle", Enabled = false, Visibility = ViewItemVisibility.Show)]
    //public  string Title
    //    {
    //    get { return _Title; }
    //    set { SetPropertyValue("Title", ref _Title, value); }
    //}

     private string _ObjectName; 
     [XafDisplayName("Object Name"), ToolTip("Object Name")]
        [Appearance("ImportColomnObjectName", Enabled = false, Visibility = ViewItemVisibility.Show)]
        public  string ObjectName
        { 
       get { return _ObjectName; } 
       set { SetPropertyValue("ObjectName", ref _ObjectName, value); } 
     }

    private string _FullObjectName;
    [XafDisplayName("Full Object Name"), ToolTip("Full Object Name")]
        public  string FullObjectName
        {
        get { return _FullObjectName; }
        set { SetPropertyValue("FullObjectName", ref _FullObjectName, value); }
    }

      

    } 

} 
