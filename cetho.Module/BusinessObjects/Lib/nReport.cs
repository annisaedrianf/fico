// Class Name : fVechType.cs 
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.ComponentModel;
using System.Linq;

namespace cetho.Module.BusinessObjects
{
    [DefaultClassOptions]
    [ImageName("ModelEditor_Views")]
    [DefaultProperty("Code")]
    [NavigationItem("Utility")]
    // Standard Document
    [System.ComponentModel.DisplayName("Report Setting")]
    public class nReport : XPObject
    {
        public nReport() : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }
        public nReport(Session session) : base(session)
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
        private ePrintType _PrintType;
        [XafDisplayName("Print Type"), ToolTip("Print Type")]
        [Size(50)]
        public  ePrintType PrintType
        {
            get { return _PrintType; }
            set { SetPropertyValue("PrintType", ref _PrintType, value); }
        }

        //
        private string _Code;
        [XafDisplayName("Kode"), ToolTip("Kode")]
        [Size(50)]
        public  string Code
        {
            get { return _Code; }
            set { SetPropertyValue("Code", ref _Code, value); }
        }
        //

        private string _ReportName;
        [XafDisplayName("Report Name"), ToolTip("Report Name")]
        [Size(150)]
        public  string ReportName
        {
            get { return _ReportName; }
            set { SetPropertyValue("ReportName", ref _ReportName, value); }
        }

        private string _Description;
        [XafDisplayName("Description"), ToolTip("Description")]
        [Size(150)]
        public  string Description
        {
            get { return _Description; }
            set { SetPropertyValue("Description", ref _Description, value); }
        }

        private string _Notes;
        [XafDisplayName("Notes"), ToolTip("Notes")]
        [Size(300)]
        public  string Notes
        {
            get { return _Notes; }
            set { SetPropertyValue("Notes", ref _Notes, value); }
        }

        
    }

    public enum ePrintType
    {
        [XafDisplayName("Printed Form")]
        PrintedForm = 0,
        [XafDisplayName("Reports")]
        Reports = 1
    }
}