using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;


namespace cetho.Module.BusinessObjects
{
    public class InfoOfClass
    {
        public InfoOfClass()
        {
            //HasData = false;
            //ForSearch = false;
        }
        public string Class { get; set; }
        public string Name { get; set; }
        public string Datatype { get; set; }
        public bool HasData { get; set; } = false;
        public bool isKey { get; set; } = false;
        public bool isKeySync { get; set; } = false;
        public string ForSearch { get; set; }
        public string ForSearchSync { get; set; }
        public string ForSearchValue { get; set; }
        public string ForSearchValueSync { get; set; }
        public int ColomXls { get; set; } = -1;
        public bool allKey { get; set; } = false;
        public bool allKeySync { get; set; } = false;
        public object Value { get; set; }
        
        public XPClassInfo ClassInfo { get; set; }
        public int MaxStringValue { get; set; } = 50;
        public void  setDataObject(Session session, string oValue, eSetDataObject oSetDataObject = eSetDataObject.None) 
        {
            iGetKey oGetKey = new iGetKey();

            //XPClassInfo classInfo = session.Dictionary.GetClassInfo(oType);
            XPMemberInfo oMemberInfo = ClassInfo.GetPersistentMember(Name);
            //DateTime dateValue;
            object oDataValue = null;
            ForSearchValue = "";
            //ForSearchValueSync = "";
            //object otempbjClass = ClassInfo.CreateNewObject(session);
            //Type otype = otempbjClass.GetType();
            //PropertyInfo info = otype.GetProperty(Name);


            //Type oType = info.PropertyType;
            // Type oType = oMemberInfo.GetType();

            Type oType = oMemberInfo.MemberType;

            bool bdate = false;

            if (oType.Name == "DateTime")
            {
                DateTime oValueOut;
                if (DateTime.TryParse(oValue, out oValueOut))
                {
                    bdate = true;
                }
                ForSearchValue = "";
                //ForSearchValueSync = "";
                oDataValue = oValueOut;
            }

            else if (oType.Name == "bool")
            {
                oDataValue = oGetKey.setDataBoolean(oValue);
            }

            else if (oType.Name == "String")
            {
                string strValue = oValue.ToString().Replace("'", "''").Trim();
                ForSearchValue = $" trim({Name}) == '{strValue}' ";
                //ForSearchValueSync = $" {Name} == '{strValue}' ";
                string iValue = (string)oValue;
                if (iValue.Length > MaxStringValue && MaxStringValue >0 )
                {
                    oValue = iValue.Substring(0, MaxStringValue);

                }
                //if ( MaxStringValue==0)
                oDataValue = oValue.Trim();
            }
            else if (oGetKey.ListOfNumeric().Contains(oType.Name))
            {
                double oIntOut;
                if (!Double.TryParse(oValue, out oIntOut))
                {
                    // it is a number
                    oIntOut = 0;
                }
                object iValue = Convert.ChangeType(oIntOut, oType);
                //Convert.ChangeType()
                ForSearchValue = $" {Name} == {iValue} ";
              //  ForSearchValueSync = $" {Name} == {iValue} ";
                oDataValue = iValue;
            }
            // enum data
            else if (oGetKey.ListOfEnum().Contains(oType.Name))
            {

                //oDataValue=(oType)Enum.Parse(typeof(oType), oValue);
                oDataValue = Enum.Parse(oType, oValue.Replace(" ",""),true);
                Console.WriteLine($"{oDataValue}");
            }
            else
            /// object data
            {

                IsSearch isSearch = new IsSearch();
                // mencari creteria unutk object ini 
                List<InfoOfClass> sCreteria = isSearch.CreateriaClass(oType);
                string sqlQuery = "";
                // XPClassInfo ObjTypeClassInfo = session.GetClassInfo(oType);
                if (oSetDataObject == eSetDataObject.Oid)
                {
                    sqlQuery = string.Format(" Oid== {0} ",
                    oValue.Trim().Replace("'", "''"));
                }
                else
                {
                    sqlQuery = string.Format(oGetKey.CreateriaClasstoSQLQuery(sCreteria, oSetDataObject),
                    oValue.Trim().Replace("'", "''"));
                }
                CriteriaOperator filterOperator = CriteriaOperator.Parse(sqlQuery);
                // object objClass = session.FindObject(oType, CriteriaOperator.Parse(sqlQuery));
                object objClass = session.FindObject(oType, CriteriaOperator.Parse(sqlQuery));
                if (objClass != null)
                {
                    XPObject oXPObject = (XPObject)objClass;
                    ForSearchValue = $" {Name}.Oid == {oXPObject.Oid} ";
                }
                oDataValue = objClass;
            }
            ForSearchValueSync = ForSearchValue;
            Value = oDataValue;
        }

    }
}
