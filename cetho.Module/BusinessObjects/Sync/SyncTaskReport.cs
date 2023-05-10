// Class Name : SyncTaskReport.cs 
// Project Name : GPN 
// Last Update : 2/8/2023 1:50:20 PM  
 
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
using System.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DevExpress.Xpo.Logger.Transport;
using DevExpress.ExpressApp.Security;
using DevExpress.DocumentServices.ServiceModel.DataContracts;

//using IHost host = Host.CreateDefaultBuilder(args).Build();

namespace cetho.Module.BusinessObjects 
{ 
   [DefaultClassOptions] 
   [ImageName("ModelEditor_Views")] 
   [DefaultProperty("")]
   [NavigationItem("Sync")]
   // Standard Document
   [System.ComponentModel.DisplayName("Task Report")]
   public class SyncTaskReport : XPObject
   {
     public SyncTaskReport(Session session) : base(session) 
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
            UserID = Session.FindObject<UserLoginInfo>(new BinaryOperator("UserName", SecuritySystem.CurrentUserName.ToString())); 
            // LastUpdateUser = Session.FindObject<GPUser>(new BinaryOperator("UserName", tUser)); 
            // LastUpdate = DateTime.Now; 
            TxnDate = DateTime.Now;
            Status = eJobDetail.Created;

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
     [Appearance("VisibleSyncTaskReportOID", Visibility = ViewItemVisibility.Hide)] 
     public int Oid 
     { 
         get { return base.Oid; }
         set { base.Oid = value; }
     }
     // 
     // Notes for SyncTaskReport : 
     private DateTime _TxnDate; 
     [XafDisplayName("Txn Date"), ToolTip("Txn Date")] 
     // [Appearance("SyncTaskReportTxnDate", Enabled = true)]
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  DateTime TxnDate
     { 
       get { return _TxnDate; } 
       set { SetPropertyValue(nameof(TxnDate), ref _TxnDate, value); } 
     } 
     // 
     // Notes for SyncTaskReport : 
     private SyncReport _ReportID; 
     [XafDisplayName("Report"), ToolTip("Report")] 
     // [Appearance("SyncTaskReportReportID", Enabled = true)]
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  SyncReport ReportID
     { 
       get { return _ReportID; } 
       set { SetPropertyValue(nameof(ReportID), ref _ReportID, value); } 
     } 
     // 
     // Notes for SyncTaskReport : 
     
     [XafDisplayName("Parameter"), ToolTip("Parameter")] 
     // [Appearance("SyncTaskReportParameter", Enabled = true)]
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     [Association("TaskRptParameter")]
        public XPCollection<SyncTaskReportParameter> Parameter
        {
            get
            {
                return GetCollection<SyncTaskReportParameter>("Parameter");
            }
        }
       
     // 
     // Notes for SyncTaskReport : 
     private bool _Email; 
     [XafDisplayName("Email"), ToolTip("Email")] 
     // [Appearance("SyncTaskReportEmail", Enabled = true)]
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool Email
     { 
       get { return _Email; } 
       set { SetPropertyValue(nameof(Email), ref _Email, value); } 
     } 
     // 
     // Notes for SyncTaskReport : 
     private bool _WhatsApp; 
     [XafDisplayName("Whats App"), ToolTip("Whats App")] 
     // [Appearance("SyncTaskReportWhatUp", Enabled = true)]
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool WhatsApp
        { 
       get { return _WhatsApp; } 
       set { SetPropertyValue(nameof(WhatsApp), ref _WhatsApp, value); } 
     } 
     // 
     // Notes for SyncTaskReport : 
     private bool _PDF; 
     [XafDisplayName("PDF"), ToolTip("PDF")] 
     // [Appearance("SyncTaskReportPDF", Enabled = true)]
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool PDF
     { 
       get { return _PDF; } 
       set { SetPropertyValue(nameof(PDF), ref _PDF, value); } 
     } 
     // 
     // Notes for SyncTaskReport : 
     private bool _Xls; 
     [XafDisplayName("Xls"), ToolTip("Xls")] 
     // [Appearance("SyncTaskReportXls", Enabled = true)]
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  bool Xls
     { 
       get { return _Xls; } 
       set { SetPropertyValue(nameof(Xls), ref _Xls, value); } 
     } 
     // 
     // Notes for SyncTaskReport : 
     private UserLoginInfo _UserID; 
     [XafDisplayName("UserID"), ToolTip("UserID")] 
     // [Appearance("SyncTaskReportUserID", Enabled = true)]
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  UserLoginInfo UserID
     { 
       get { return _UserID; } 
       set { SetPropertyValue(nameof(UserID), ref _UserID, value); } 
     } 
     // 
     // Notes for SyncTaskReport : 
     private eJobDetail _Status; 
     [XafDisplayName("Status"), ToolTip("Status")] 
     // [Appearance("SyncTaskReportStatus", Enabled = true)]
     // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
     // [RuleRequiredField(DefaultContexts.Save)] 
     // [IsSearch(true)]
     public  eJobDetail Status
     { 
       get { return _Status; } 
       set { SetPropertyValue(nameof(Status), ref _Status, value); } 
     }

        // 
        // Notes for SyncTaskReport : 
        private ReportUI _ReportName;
        [XafDisplayName("Report Name"), ToolTip("Report Name")]
        // [Appearance("SyncTaskReportStatus", Enabled = true)]
        // [ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)] 
        // [RuleRequiredField(DefaultContexts.Save)] 
        // [IsSearch(true)]
        [Association("ReportUITask")]
        public ReportUI ReportName
        {
            get { return _ReportName; }
            set { SetPropertyValue(nameof(ReportName), ref _ReportName, value); }
        }


        private string PythonLocation;
        private string PythonArgument;
        [Action(Caption = "Process Task")]
        public void Processtask()
        {


          
            // Build a config object, using env vars and JSON providers.
            IConfiguration config = new ConfigurationBuilder()
                //.AddJsonFile("appsettings.json")
                //.AddEnvironmentVariables()
            .Build();

            //var app = builder.Build();
           // var config = config.Configuration;
            var PythonLocation = config["SR:PythonLocation"]; ;
            var PtytonAppLocation = config["SR:PythonAppLocation"]; ;
            // process report 
            // create process info

            PythonArgument = PtytonAppLocation.Replace(@"\\", @"\") + ReportID.ScriptName;
            var psi =  new ProcessStartInfo();
            psi.FileName = PythonLocation.Replace(@"\\", @"\");
            psi.WorkingDirectory = PtytonAppLocation.Replace(@"\\", @"\");
            // provide script & argument
            psi.Arguments= PythonArgument;
            //  proccess configuration
            psi.UseShellExecute= false;
            psi.CreateNoWindow = true;

            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;

            // 4. Execute process & get Output
            var errors = "";
            var result = "";

            using (var process = Process.Start(psi))
            {
                errors= process.StandardError.ReadToEnd();
                result = process.StandardOutput.ReadToEnd();
               // process.WaitForExit();
            }

            // 5 display Output
            Console.WriteLine("Error");

            Console.WriteLine(errors);
            Console.WriteLine("result");
            Console.WriteLine(result);
            //ReportID.r

        }
    } 
} 
