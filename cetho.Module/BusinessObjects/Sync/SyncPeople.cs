using System;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
//using Microsoft.Office.Interop.Outlook;
//using Outlook = Microsoft.Office.Interop.Outlook;
using System.Reflection; // to u
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace cetho.Module.BusinessObjects
{
    [DefaultClassOptions]
    [ImageName("ModelEditor_Views")]
    [System.ComponentModel.DefaultProperty("Name")]
    [NavigationItem("Org. Structure")]
    // Standard Document
    [System.ComponentModel.DisplayName("Staff")]
    public class SyncPeople : XPObject
    {

        private string _ID;
        [RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("ID"), ToolTip("ID")]
        [Size(25)]
        [NullText("ID")]
        public  string ID
        {
            get { return GetPropertyValue<string>("ID"); }
            set { SetPropertyValue<string>("ID", value); }
        }

        private string _Name;
        [RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Name"), ToolTip("Name")]
        [Size(350)]
        [NullText("Name")]
        public  string Name
        {
            get { return _Name; }
            set { SetPropertyValue("Name", ref _Name, value); }
        }

        
        private string _Email;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Email *"), ToolTip("Email *")]
        [Size(5000)]
        [NullText("Email")]
        public  string Email
        {
            get { return _Email; }
            set { SetPropertyValue("Email", ref _Email, value); }
        }
        private string _TelpExtNo;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Telp Ext No "), ToolTip("Telp Ext No ")]
        [Size(50)]
        //[NullText("TelpExtNo")]
        public  string TelpExtNo
        {
            get { return _TelpExtNo; }
            set { SetPropertyValue("TelpExtNo", ref _TelpExtNo, value); }
        }
        private string _TelpDirectNo;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Telp Direct No"), ToolTip("Telp Direct No")]
        [Size(50)]
        //[NullText("TelpExtNo")]
        public  string TelpDirectNo
        {
            get { return _TelpDirectNo; }
            set { SetPropertyValue("TelpDirectNo", ref _TelpDirectNo, value); }
        }

        private string _MobileNumber;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Mobile Number"), ToolTip("Mobile Number")]
        [Size(50)]
        //[NullText("TelpExtNo")]
        public  string MobileNumber
        {
            get { return _MobileNumber; }
            set { SetPropertyValue("MobileNumber", ref _MobileNumber, value); }
        }

        //private DepartmentInfo _Department;
        ////[RuleRequiredField(DefaultContexts.Save)]
        //[XafDisplayName("Department"), ToolTip("Department")]
        ////[Size(50)]
        ////[NullText("TelpExtNo")]
        //public  DepartmentInfo Department
        //{
        //    get { return _Department; }
        //    set { SetPropertyValue("Department", ref _Department, value); }
        //}

        //private OperatingUnitInfo _OU;
        ////[RuleRequiredField(DefaultContexts.Save)]
        //[XafDisplayName("OU"), ToolTip("OU")]
        ////[Size(50)]
        ////[NullText("TelpExtNo")]
        //public  OperatingUnitInfo OU
        //{
        //    get { return _OU; }
        //    set { SetPropertyValue("OU", ref _OU, value); }
        //}

        //private GSOUnit _OUAccess;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("OUAccess"), ToolTip("OUAccess")]
        [Association("OUPersonAccess")]
        public XPCollection<OperatingUnitInfo> OUAccess
        {
            get
            {
                return GetCollection<OperatingUnitInfo>("OUAccess");
            }
        }

        [Association("EmailPerson")]
        //public SyncEmailGroup EmailGroup
        //{
        //    get { return _EmailGroup; }
        //    set { SetPropertyValue("EmailGroup", ref _EmailGroup, value); }
        //}
        public XPCollection<SyncEmailGroup> EmailGroup
        {
            get
            {
                return GetCollection<SyncEmailGroup>("EmailGroup");
            }
        }

        //[Association("HRSReMailCC")]
        //public XPCollection<ASHREmpSR> CCHREmpSREmails
        //{
        //    get
        //    {
        //        return GetCollection<ASHREmpSR>("CCHREmpSREmails");
        //    }
        //}

        //[Association("HRSReMailTO")]
        //public XPCollection<ASHREmpSR> TOHREmpSREmails
        //{
        //    get
        //    {
        //        return GetCollection<ASHREmpSR>("TOHREmpSREmails");
        //    }
        //}

        [Action(Caption = "SyncContacts")]
        public void SyncContacts()
        {


            ////string ctn = "";
            ////Microsoft.Office.Interop.Outlook.Items _items;
            ////Microsoft.Office.Interop.Outlook.NameSpace _ns;
            ////Microsoft.Office.Interop.Outlook.MAPIFolder _inbox;
            ////Microsoft.Office.Interop.Outlook.Application _application = new Microsoft.Office.Interop.Outlook.Application();


            ////_ns = _application.Session;
            ////_inbox = _ns.GetDefaultFolder(Microsoft.Office.Interop.Outlook.OlDefaultFolders.olFolderInbox);
            ////_items = _inbox.Items;
            //Microsoft.Office.Interop.Outlook.Application oApp;
            //Microsoft.Office.Interop.Outlook.NameSpace oNS;
            ////Outlook.MAPIFolder oInbox;
            ////Outlook.Items oItems;
            ////Outlook.MailItem oMsg;
            //oApp = new Microsoft.Office.Interop.Outlook.Application();

            //// Get the MAPI namespace.
            //oNS = oApp.GetNamespace("mapi");

            //// Log on by using the default profile or existing session (no dialog box).
            //oNS.Logon(Missing.Value, Missing.Value, false, true);

            //Outlook.MAPIFolder folderContacts = oNS.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderContacts);
            ////oInbox = oNS.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderInbox);
            ////Outlook.MAPIFolder folderContacts = oApp.ActiveExplorer().Session.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderContacts);
            //Outlook.Items searchFolder = folderContacts.Items;
            //int counter = 0;
            ////ctn += folderContacts.Items.Count.ToString();
            //searchFolder.GetFirst();
            //Outlook.ContactItem foundContact;
            //foundContact = (Outlook.ContactItem)folderContacts.Items.GetFirst();
            //int totalcnt = folderContacts.Items.Count;
            ////totalcnt = 500;
            //bool bfeachdata = true;
            //for (int i = 1; i < totalcnt; i++)
            //{
            //    if (foundContact != null && bfeachdata)
            //    {
            //        /*
            //        //searchFolder
            //        //Outlook.ContactItem foundContact = searchFolder.i;
            //        ctn += foundContact.EntryID + "~";
            //        ctn += foundContact.FullName + "~";
            //        ctn += foundContact.JobTitle + "~";
            //        ctn += foundContact.CompanyName + "~";
            //        ctn += foundContact.Email1AddressType + "~";
            //        ctn += foundContact.Email1DisplayName + "~";
            //        //ctn += foundContact.Email1EntryID + "~";
            //        ctn += foundContact.Email1Address + System.Environment.NewLine;
            //        */
            //        NewFromContact(foundContact);
            //    }
            //    try
            //    {
            //        foundContact = (Outlook.ContactItem)searchFolder.GetNext();
            //        bfeachdata = true;
            //    }
            //    catch
            //    {
            //        bfeachdata = false;
            //    }
            //    //Console.WriteLine("Value of i: {0}", i);
            //}
        }

        //public void NewFromContact(Outlook.ContactItem oContact)
        public void NewFromContact(object oContact)
        {

            //string sqlQuery = string.Format(" Email == '{0}' ", oContact.Email1Address.ToString());
            //CriteriaOperator filterOperator = CriteriaOperator.Parse(sqlQuery);
            //SyncPeople oPeople = Session.FindObject<SyncPeople>(filterOperator);
            //if (oPeople == null)
            //{
            //    oPeople = new SyncPeople(Session);
            //}
            //oPeople.Email = oContact.Email1Address.Trim();
            //oPeople.Name = oContact.FullName;
            //oPeople.ID = oContact.EntryID.Substring(oContact.EntryID.Length - 25, 14);
            //oPeople.Save();
            //oPeople.Session.CommitTransaction();

        }
            public SyncPeople() : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public SyncPeople(Session session) : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }
    }

}