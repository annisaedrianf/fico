using System;
using DevExpress.Xpo;
using DevExpress.Persistent.Base;
using System.ComponentModel;
using DevExpress.Persistent.Validation;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.ConditionalAppearance;
using DevExpress.ExpressApp;
using DevExpress.Data.Filtering;
using DevExpress.Xpo.DB;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Xpo.Metadata;
using System.Collections;
using DevExpress.Xpo.Metadata.Helpers;

namespace cetho.Module.BusinessObjects
{

    //[DefaultClassOptions]
    //[ImageName("ModelEditor_Views")]
    //[DefaultProperty("ID")]
    //[NavigationItem("GPN Budget")]
    //// Standard Document
    //[System.ComponentModel.DisplayName("GPSync")]
    public class Sync : iFunction
    {

        public Sync()
        {

        }

        //public IObjectSpace objectSpace;
        public void UpdateSync(IObjectSpace ObjectSpace)
        {
            
            ImportObjectSync(ObjectSpace);
            CompanySync();
        }


        public void ImportObjectSync(IObjectSpace ObjectSpace)
        {

            Session currentSession = ((XPObjectSpace)ObjectSpace).Session;
            ImportObjectSyncSession(currentSession);
        }
        public void ImportObjectSyncSession(Session currentSession)
        {
            foreach (XPClassInfo classInfo in currentSession.Dictionary.Classes)
            {

                //CriteriaOperator criteria = CriteriaOperator.Parse($"FullObjectName == '{classInfo.ClassType.FullName}' ");
                ImportObject oImportObject = currentSession.FindObject<ImportObject>
                 (new BinaryOperator("ObjectName", classInfo.ClassType.Name));
                if (oImportObject == null && classInfo.ClassType.FullName.Contains("cetho.Module.BusinessObjects"))
                {
                    //oImportObject = ObjectSpace.CreateObject<ImportObject>();

                    oImportObject = new ImportObject(currentSession);
                    oImportObject.ObjectName = classInfo.ClassType.Name;
                    oImportObject.FullObjectName = classInfo.ClassType.FullName;
                    oImportObject.Save();
                    currentSession.CommitTransaction();
                }

            }
        }
            public void CompanySync()
        {
            //SelectedData data = GetEmployeesSimpleData();
            //foreach (SelectStatementResultRow row in data.ResultSet[0].Rows)
            //{

            //    //row.GetType().
            //    Console.WriteLine(row.Values[0]);
            //}
        }

        string[] GetObjectProperties(XPClassInfo xpoInfo, ArrayList processed)
        {
            if (processed.Contains(xpoInfo)) return new string[] { };
            processed.Add(xpoInfo);
            ArrayList result = new ArrayList();
            foreach (XPMemberInfo m in xpoInfo.PersistentProperties)
                if (!(m is ServiceField) && m.IsPersistent)
                {
                    result.Add(m.Name);
                    if (m.ReferenceType != null)
                    {
                        string[] childProps = GetObjectProperties(m.ReferenceType, processed);
                        foreach (string child in childProps)
                            result.Add(string.Format("{0}.{1}", m.Name, child));
                    }
                }

            foreach (XPMemberInfo m in xpoInfo.CollectionProperties)
            {
                string[] childProps = GetObjectProperties(m.CollectionElementType, processed);
                foreach (string child in childProps)
                    result.Add(string.Format("{0}.{1}", m.Name, child));
            }
            return result.ToArray(typeof(string)) as string[];
        }
        string[] GetObjectProperties(Type objectType)
        {
            XPClassInfo classInfo = Session.DefaultSession.Dictionary.GetClassInfo(objectType);
            if (classInfo != null)
                return GetObjectProperties(classInfo, new ArrayList());
            return new string[] { };
        }

        public string connectionString;

    
    }

}