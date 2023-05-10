using DevExpress.ExpressApp.DC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace cetho.Module.BusinessObjects
{
    //[AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = false)]

   
    public class IsSyncSearch : Attribute
    {
        // Private fields 
        //private string title;
        //private string description;
        //private bool isSearch;
        //private bool allKey;

        public bool isSyncSearch { get; set; }
        public bool allKey { get; set; }
        public string description { get; set; }

        public string title { get; set; }



        // Parameterised Constructor 
        public IsSyncSearch(bool issearch = true, bool allkey = false, string Title = "", string Description = "")
        {
            title = Title;
            description = Description;
            isSyncSearch = issearch;
            allKey = allkey;
        }
        public InfoOfClass CreateriaClassAdd<T>(T oType, string pName, bool isKey = false, bool allKey = false) where T : Type
        {
            InfoOfClass oClass = new InfoOfClass();
            PropertyInfo info = oType.GetProperty(pName);
            oClass.Class = oType.Name;
            oClass.ForSearchSync = info.Name;
            oClass.Name = info.Name;
            oClass.isKeySync = isKey;
            oClass.Datatype = info.PropertyType.Name;
            oClass.allKey = allKey;
            return oClass;
        }


        public string CreateriaClasstoSQLQuery(List<InfoOfClass> olInfoOfClass)
        {
            string sQuery = "";
            //sQuery = CreateriaClasstoSQLQuery(CreateriaClass(T), oSetDataObject);
            List<InfoOfClass> query = olInfoOfClass.Where(a => a.isKeySync).ToList();
            //  olInfoOfClass = query;
            foreach (InfoOfClass value in query)
            {
                sQuery += " " + value.ForSearchValueSync + " &&";
            }
            try
            {
                sQuery = sQuery.Substring(1, sQuery.Length - 3);
            }
            catch (Exception ex)
            {
                sQuery = "";
            }

            return sQuery;
        }

        public string CreateriaClasstoSQLQuery(Type T, eSetDataObject oSetDataObject = eSetDataObject.None)
        {
            string sQuery = "";
            sQuery = CreateriaClasstoSQLQuery(CreateriaClass(T), oSetDataObject);
            return sQuery;
        }
        public string CreateriaClasstoSQLQuery(List<InfoOfClass> aList, eSetDataObject oSetDataObject = eSetDataObject.None)
        {
            string sQuery = "";

            if (oSetDataObject == eSetDataObject.Key)
            {
                List<InfoOfClass> query = aList.Where(a => a.isKeySync).ToList();
                aList = query;
            }

            foreach (InfoOfClass value in aList)
            {
                sQuery += " " + value.ForSearchSync + " == '{0}' ||";
            }
            try
            {
                sQuery = sQuery.Substring(1, sQuery.Length - 3);
            }
            catch (Exception ex)
            {
                sQuery = "";
            }
            return sQuery;

        }
        public List<InfoOfClass> CreateriaClass<T>(T oType) where T : Type
        {
            List<InfoOfClass> LCreateriaClass = new List<InfoOfClass>();
              PropertyInfo[] properties = oType.GetProperties();
            for (int i = 0; i < properties.GetLength(0); i++)
            {
                object[] attributesArray = properties[i].GetCustomAttributes(true);

                foreach (Attribute item in attributesArray)
                {
                    if (item is IsSyncSearch)
                    {

                        //// Display the fields of the NewAttribute 
                        IsSyncSearch attributeObject = (IsSyncSearch)item;
                        //Console.WriteLine("{0} - {1}, {2} ", properties[i].Name,
                        //attributeObject.title, attributeObject.description);
                        if (attributeObject.isSyncSearch)
                        {
                            LCreateriaClass.Add(CreateriaClassAdd(oType, properties[i].Name, true));
                        }
                    }
                }

            }

            return LCreateriaClass;
        }
       


    }
  
}

