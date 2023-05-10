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
   [DefaultProperty("ColomName")]
   [NavigationItem("Utility")]
   // Standard Document
   [System.ComponentModel.DisplayName("Column Xls")]
   public class xlsFileColomn : XPObject
   {
     public xlsFileColomn() : base()
     {
     // This constructor is used when an object is loaded from a persistent storage.
     // Do not place any code here.
     }
     public xlsFileColomn(Session session) : base(session) 
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
        // 
    private ImportFiles _ImportFile;
    [XafDisplayName("Import File"), ToolTip("Import File")]
    [Association("ImpColom")]
    public  ImportFiles ImportFile
    {
        get { return _ImportFile; }
        set { SetPropertyValue("ImportFile", ref _ImportFile, value); }
    }
     private string _ColomName; 
     [XafDisplayName("Column Name"), ToolTip("Column Name")] 
     public  string ColomName
        { 
       get { return _ColomName; } 
       set { SetPropertyValue("ColomName", ref _ColomName, value); } 
     }

        private int _ColomIdx;

        [XafDisplayName("Column Idx"), ToolTip("Column Idx")]
        [Appearance("xlFileColomColomIdx", Enabled = false, Visibility = ViewItemVisibility.Hide)]
        public  int ColomIdx
        {
            get { return _ColomIdx; }
            set { SetPropertyValue("ColomIdx", ref _ColomIdx, value); }
        }


    } 

} 
