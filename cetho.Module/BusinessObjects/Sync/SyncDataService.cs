using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
//using System.Data.EntityClient;
using System.Data.SqlClient;
//using System.Data.EntityClient;
//using Microsoft.EntityFrameworkCore;

using System.Configuration;
using DevExpress.Export.Xl;
using System.IO;
using System.Collections;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using System.Globalization;
using System.Threading;
using DevExpress.Data.Filtering;

namespace cetho.Module.BusinessObjects
{
    public class SyncDataService
    {

        private SqlConnection cnnConnect;
        //private string strHTML;
        private bool bAnydata = false;

        public SyncDataService()
        {
            //

            //Session.DefaultSession.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString; ;
            IsAnyData = false;
        }

        public void AdoConn()
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=.;Initial Catalog=ReportServer;User ID=sa;Password=1";
            connetionString = ConfigurationManager.AppSettings["ConnectionTest"];
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            //MessageBox.Show("Connection Open  !");
            cnn.Close();
        }

        private void OpenConn(string Database = "")
        {

            string connetionString;
            string dbConnection = "Connection" + Database;
            //SqlConnection cnnConnect;
            connetionString = @"Data Source=.;Initial Catalog=ReportServer;User ID=sa;Password=1";
            connetionString = ConfigurationManager.AppSettings[dbConnection];
            cnnConnect = new SqlConnection(connetionString);
            cnnConnect.Open();
        }
        private void OpenDBConn(string Database = "")
        {
            try
            {
                cnnConnect = new SqlConnection(Database);
              //  cnnConnect.ConnectionTimeout = 0;
                cnnConnect.Open();
            }
            catch (Exception ex)
            {
                SyncEmailService eService = new SyncEmailService();
                 eService.WriteToFile(" {0}  OpenDBConn " + ex.Message);
            }

        }
        private void CloseConn()
        {
            cnnConnect.Close();
        }

        private string HtmlCss
        {

            get
            {
                string sCss;
                sCss = " table { font - family: arial, sans - serif; " +
                 " border - collapse: collapse; " +
                 " width: 100 %;  } " +
                 " td, th {  border: 1px solid #dddddd; " +
                 " text - align: left; " +
                 " padding: 8px; } " +
                 " tr: nth - child(even) { " +
                 " background - color: #dddddd; } ";

                return sCss;
            }
        }
        private string HtmlHeader
        {

            get
            {
                string htmstr = " < !DOCTYPE html > " +
               " < html >  " +
              " < head >" +
                " < style > " +
                " table { font - family: arial, sans - serif; " +
                " border - collapse: collapse; " +
                " width: 100 %;  } " +
                " td, th {  border: 1px solid #dddddd; " +
                " text - align: left; " +
                " padding: 8px; } " +
                " tr: nth - child(even) { " +
                " background - color: #dddddd; } </ style > </ head > <body>  ";
                return htmstr;
            }

        }


        private string isStringNull(string sData = "")
        {
            if (sData ==null)
            {
                sData = "";
            }

            return sData;
        }
        public string DataReplace(string sData , string sId)
        {
            string sDataReplace = "";
            sData= isStringNull(sData);
               sData = sData.Replace("@@pt@@",  sId );
               sData = sData.Replace("@@ou@@",  sId );
            sDataReplace = sData;
            return sDataReplace;
        }
            public string DataReplace(string sData = "", string sId = "", eDataReplace enumDataReplace = eDataReplace.PTOU)
        {
            string sDataReplace = "";
            sData = isStringNull(sData);
            // sData=NullText(sData);
            if (enumDataReplace == eDataReplace.PTOU)
            {
                sData = sData.Replace("@@pt@@", sId );
                sData = sData.Replace("@@ou@@", sId );
            }

            else if (enumDataReplace == eDataReplace.Date)
            {
                sData = sData.Replace("@@date@@", sId );
            }
            else if (enumDataReplace == eDataReplace.User)
            {
                sData = sData.Replace("@@user@@",  sId );
            }
            sDataReplace = sData;
            return sDataReplace;

        }


       
        
        public CompanyInfo GetSyncCompany(Session oSession, eGPSync oGPSync)
        {

            string sqlQuery = string.Format(" Type  == {0}  ",
                           oGPSync.GetHashCode());
            CriteriaOperator filterOperator = CriteriaOperator.Parse(sqlQuery);
            CompanyInfo oObject = oSession.FindObject<CompanyInfo>(filterOperator);
            if (oObject == null)
            {
                oObject = new CompanyInfo(oSession);
                //oObject.Type = oGPSync;
                oObject.Title = "Budget HA & Crop";
            }
           
            return oObject;
        }

        public string fmtstr(string idSql)
        {
            return "'" + idSql.Replace("'", "''").Trim() + "'";
        }

           private string DataReadervalue(SqlDataReader dataReader)
        {
            string svalue = "";

            return svalue = "";
        }


        public bool IsAnyData
        {
            get
            {
                return bAnydata;
            }
            set
            {
                bAnydata = value;
            }
        }
        private bool bAnydataDetail = false;
        public string OleExecuteQuery(SyncServiceJobDetail oServiceJobDetail,
                                    string database = "",
                                    string sDataLevelID = "")
        {
            //bool lbAnydata = false;
            string srqHTML;
            bool bCrlf = true;
            Chilkat.StringBuilder sbHtml = new Chilkat.StringBuilder();
            //sbHtml = "";
            XPCollection<SyncSetupInfo> Serviceinfs = oServiceJobDetail.ServiceJob.JobType.Info;
            // add soring 
            SortingCollection newSorting = new SortingCollection();
            newSorting.Add(new SortProperty("Idx", SortingDirection.Ascending));
            Serviceinfs.Sorting = newSorting;

            bAnydataDetail = false;
            foreach (SyncSetupInfo oServiceinfo in Serviceinfs)
            //Parallel.ForEach<SyncSetupInfo>(Serviceinfs, (oServiceinfo) =>
            {
                bAnydataDetail = false;
                srqHTML = OleExecuteQuery(DataReplace(oServiceinfo.SqlQuery, sDataLevelID, eDataReplace.PTOU), database, oServiceinfo.Description);
                if (bAnydataDetail)
                {
                    sbHtml.AppendLine("<p>" + oServiceinfo.Description + "</p>", bCrlf);
                    sbHtml.AppendLine(srqHTML, bCrlf);
                    sbHtml.AppendLine("<p>" + oServiceinfo.Notes + "</p>", bCrlf);
                }
            }
            //IsAnyData = lbAnydata;
            return sbHtml.GetAsString();
        }
        public string OleExecuteQuery(string sqlQuery, string database = "", string sBody = "")
        {
            string strHTML;
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;

            //OpenConn(database);
            SyncEmailService eService = new SyncEmailService();
            OpenDBConn(database);
            SqlCommand command;
            SqlDataReader dataReader;
            string sql, Output = "";
            string datatype = "";
            sql = "select";
            command = new SqlCommand(sqlQuery, cnnConnect);
            dataReader = command.ExecuteReader();
            int drFieldCount;
            drFieldCount = dataReader.FieldCount;

            //strHTML = "<table style='width: 100 %' > " + "\r\n";
            strHTML = "<table class='gridtable'>  " + "\r\n";
            strHTML += "<tr bgcolor='#808080'> " + "\r\n";
            for (int i = 0; i < drFieldCount; i++)
            {
                //Console.WriteLine(" nama header : " + dataReader.GetName(i).ToString());
                // set html header
                strHTML += "<th>" + dataReader.GetName(i).ToString() + "</th>" + "\r\n";
            }
            strHTML += "</tr> ";
            // set any data to false
            //IsAnyData = false;
            while (dataReader.Read())
            {

                IsAnyData = true;
                bAnydataDetail = true;
                //90EE90
                strHTML += "<tr bgcolor='#10aee3'>";
                bool bColspan = false;
                for (int i = 0; i < drFieldCount; i++)
                {
                   
                    datatype = dataReader.GetFieldType(i).ToString();
                    /*
                    Console.WriteLine(" nama : " + dataReader.GetName(i).ToString());
                    Console.WriteLine(" GetFieldType  : " + dataReader.GetFieldType(i).ToString());
                    Console.WriteLine("GetDataTypeName " + dataReader.GetDataTypeName(i).ToString());
                    eService.WriteToFile(" nama : " + dataReader.GetName(i).ToString());
                    eService.WriteToFile(" GetFieldType  : " + dataReader.GetFieldType(i).ToString());
                    eService.WriteToFile("GetDataTypeName " + dataReader.GetDataTypeName(i).ToString());
                    */
                    if (dataReader[i] != DBNull.Value)
                    {
                        // <td colspan="2">OK&nbsp;</td>
                        //< td > &nbsp;</ td >

                        //strHTML += "<td>" + dataReader[i].ToString() + "</td>";
                        
                        if (datatype == "System.Int32")
                        {
                            //Console.WriteLine("data " + dataReader.GetInt32(i).ToString());
                             Int32 Idata = System.Int32.Parse( dataReader[i].ToString());
                            strHTML += "<td align = 'right'>" + Idata.ToString("N",nfi) + "</td>";
                            Output = dataReader[i].ToString();
                            

                        }
                        else if (datatype == "System.Double")
                        {
                            Double Idata = System.Double.Parse(dataReader[i].ToString());
                            strHTML += "<td align = 'right'>" + Idata.ToString("N", nfi) + "</td>";
                            
                        }
                        else if (datatype == "System.Decimal")
                        {
                            Decimal Idata = System.Decimal.Parse(dataReader[i].ToString());
                            strHTML += "<td align = 'right'>" + Idata.ToString("N", nfi) + "</td>";
                            
                        }
                        else if (datatype == "System.Int16")
                        {
                            Int16 Idata = System.Int16.Parse(dataReader[i].ToString());
                            strHTML += "<td align = 'right'>" + Idata.ToString("N", nfi) + "</td>";
                           
                        }
                        else if (datatype == " System.Int64")
                        {
                            Int16 Idata = System.Int16.Parse(dataReader[i].ToString());
                            strHTML += "<td align = 'right'>" + Idata.ToString("N", nfi) + "</td>";
                            
                        }
                        else if (datatype == "System.DateTime")

                        {
                            //Console.WriteLine("data " + dataReader.GetDateTime(i).ToString());
                            strHTML += "<td>" + dataReader[i].ToString() + "</td>";
                        }
                        else if (datatype == "System.String")

                        {
                            //Console.WriteLine("data " + dataReader.GetString(i));
                            if (dataReader[i].ToString().Length > 4)
                            {
                                string sHeaderdata = dataReader[i].ToString();
                                if (sHeaderdata.Substring(0, 3) == "{GR")
                                {
                                    bColspan = true;
                                    //< td colspan = "2" > OK & nbsp;</ td >
                                    strHTML += "<td colspan ='" + sHeaderdata.Substring(3, 1) + "'>" + sHeaderdata.Substring(4, sHeaderdata.Length-4) + "</td>";
                                }
                                else if (sHeaderdata.Substring(0, 3) == "{TT")
                                {
                                    bColspan = true;
                                    //< td colspan = "2" > OK & nbsp;</ td >
                                    strHTML += "<td colspan ='" + sHeaderdata.Substring(3, 1) + "'>" + sHeaderdata.Substring(4, sHeaderdata.Length - 4) + "</td>";
                                }
                                else
                                {
                                    strHTML += "<td>" + dataReader[i].ToString() + "</td>";
                                }
                            }
                            else
                            {
                                strHTML += "<td>" + dataReader[i].ToString() + "</td>";
                            }
                        }

                    }
                    else if (!bColspan)
                    {
                        strHTML += "<td></td> ";
                    }
                }
                strHTML += "</tr> ";

            }
            strHTML += " </table> ";
            //strHTML += " </ body > " ;
            //strHTML += " </ html > ";

            string htmlFinal;
            htmlFinal = HtmlHeader + strHTML;
            //Console.WriteLine(strHTML);
            CloseConn();
            return strHTML;
        }
        public void EntityConn()
        {

            // Specify the provider name, server and database.
            string providerName = "System.Data.SqlClient";
            string serverName = ".";
            string databaseName = "ReportServer";

            //// Initialize the connection string builder for the
            //// underlying provider.
            //SqlConnectionStringBuilder sqlBuilder =
            //    new SqlConnectionStringBuilder();

            //// Set the properties for the data source.
            //sqlBuilder.DataSource = serverName;
            //sqlBuilder.InitialCatalog = databaseName;
            //sqlBuilder.IntegratedSecurity = true;



            //// Build the SqlConnection connection string.
            //string providerString = sqlBuilder.ToString();
            
            //// Initialize the EntityConnectionStringBuilder.
            //EntityConnectionStringBuilder entityBuilder =
            //    new EntityConnectionStringBuilder();

            ////Set the provider name.
            //entityBuilder.Provider = providerName;

            //// Set the provider-specific connection string.
            //entityBuilder.ProviderConnectionString = providerString;

            //// Set the Metadata location.
            //entityBuilder.Metadata = @"res://*/ReportServerModel.csdl|
            //                res://*/ReportServerModel.ssdl|
            //                res://*/ReportServerModel.msl";
            //Console.WriteLine(entityBuilder.ToString());



            //using (EntityConnection conn =
            //    new EntityConnection(entityBuilder.ToString()))
            //{
            //    conn.Open();
            //    Console.WriteLine("Just testing the connection.");
            //    conn.Close();
            //}
            
        }
        public static void ExecuteQuery(string sqlQuery)
        {
            sqlQuery = "";
            string queryString =
                @"SELECT c.CategoryID, c.CategoryName 
                FROM NorthwindEntities.Categories AS c";

            //using (EntityConnection conn =
            //    new EntityConnection("name=NorthwindEntities"))
            //{
            //    try
            //    {
            //        conn.Open();
            //        using (EntityCommand query = new EntityCommand(queryString, conn))
            //        {
            //            using (DbDataReader rdr =
            //                query.ExecuteReader(CommandBehavior.SequentialAccess))
            //            {
            //                while (rdr.Read())
            //                {
            //                    Console.WriteLine("\t{0}\t{1}", rdr[0], rdr[1]);
            //                }
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}
        }

        public SqlDataReader ExeQuery(string sqlQuery, string database = "")
        {
            OpenDBConn(database);

            SqlCommand command;
            SqlDataReader dataReader;
            command = new SqlCommand(sqlQuery, cnnConnect);
            //dataReader = command.ExecuteReader();
            return command.ExecuteReader();
            //return dataReader;
        }
        public string HTMLCreated(string sqlQuery, string database = "")
        {
            string strHTML = "";
            string sHTML = "";
            //string sH1 = "";
            //string sH2 = "";
            //string sB1 = "";
            //string sB2 = "";
            Chilkat.StringBuilder shtm = new Chilkat.StringBuilder();
            bool bCrlf = true;
            shtm.AppendLine("<!doctype html>", bCrlf);
            shtm.AppendLine("<html>", bCrlf);
            shtm.AppendLine("<head>", bCrlf);
            shtm.AppendLine("<title> The Skeleton of an HTML5 Document </title >", bCrlf);
            shtm.AppendLine("</head>", bCrlf);
            shtm.AppendLine("<body>", bCrlf);

            SqlDataReader dataReader;
            dataReader = ExeQuery(sqlQuery, database);
            // table
            shtm.AppendLine("<table border = '0.5'>", bCrlf);
            // add table header

            int drFieldCount;
            drFieldCount = dataReader.FieldCount;

            shtm.AppendLine("<tr>", bCrlf);
            for (int i = 0; i < drFieldCount; i++)
            {
                //Console.WriteLine(" nama header : " + dataReader.GetName(i).ToString());
                // set header to Array
                //XlsHeader[i] = dataReader.GetName(i).ToString();
                shtm.AppendLine("<th>", false);
                shtm.AppendLine(dataReader.GetName(i).ToString(), false);
                shtm.AppendLine("</th>", bCrlf);
            }
            shtm.AppendLine("</tr>", bCrlf);
            // data
            while (dataReader.Read())
            {
                shtm.AppendLine("<tr>", bCrlf);
                for (int i = 0; i < drFieldCount; i++)
                {
                    string datatype = dataReader.GetFieldType(i).ToString();

                    if (dataReader[i] != DBNull.Value)
                    {
                        shtm.AppendLine(" <td> " + dataReader[i].ToString() + " </td> ", bCrlf);
                    }
                    else
                    {
                        strHTML += " <td>  </td> ";
                    }
                }
                shtm.AppendLine("</tr>", bCrlf);
            }
            shtm.AppendLine("</table>", bCrlf);
            shtm.AppendLine("</body>", bCrlf);
            shtm.AppendLine("</html>", false);
            sHTML = shtm.ToString();
            return sHTML;

        }
        public void ExportToXls(string sqlQery = "", string sFilename = "", string sSheetname = "", string database = "")
        {
            SyncEmailService eService = new SyncEmailService();
            SqlDataReader dataReader;
            dataReader = ExeQuery(sqlQery, database);
            eService.WriteToFile(" {0}  while (dataReader.Read()) " + dataReader.FieldCount.ToString() + database + sqlQery);
            // Create an exporter instance.  
            IXlExporter exporter = XlExport.CreateExporter(XlDocumentFormat.Xlsx);
            // Create the FileStream object with the specified file path.  

            using (FileStream stream = new FileStream(sFilename + ".xlsx", FileMode.Create, FileAccess.ReadWrite))
            {
                eService.WriteToFile(" {0} : FileStream stream");
                // Create a new document and begin to write it to the specified stream.  
                using (IXlDocument document = exporter.CreateDocument(stream))
                {
                    // Add a new worksheet to the document.  s
                    using (IXlSheet sheet = document.CreateSheet())
                    {
                        // Specify the worksheet name. 
                        sheet.Name = sSheetname;
                        // Specify cell font attributes. 
                        XlCellFormatting cellFormatting = new XlCellFormatting();
                        cellFormatting.Font = new XlFont();
                        cellFormatting.Font.Name = "Century Gothic";
                        cellFormatting.Font.SchemeStyle = XlFontSchemeStyles.None;

                        // Specify formatting settings for the header row. 
                        XlCellFormatting headerRowFormatting = new XlCellFormatting();
                        headerRowFormatting.CopyFrom(cellFormatting);
                        headerRowFormatting.Font.Bold = true;
                        headerRowFormatting.Font.Color = XlColor.FromTheme(XlThemeColor.Light1, 0.0);
                        headerRowFormatting.Fill = XlFill.SolidFill(XlColor.FromTheme(XlThemeColor.Accent2, 0.0));
                        // create header 
                        int drFieldCount;
                        drFieldCount = dataReader.FieldCount;
                        string[] XlsHeader = new string[drFieldCount];
                        for (int i = 0; i < drFieldCount; i++)
                        {
                            eService.WriteToFile(" {0} nama header : " + dataReader.GetName(i).ToString());
                            // set header to Array
                            XlsHeader[i] = dataReader.GetName(i).ToString();
                            // Create the first column and set its width.  
                            using (IXlColumn column = sheet.CreateColumn())
                            {
                                column.WidthInPixels = 100;
                            }

                        }
                        eService.WriteToFile("  {0} setelah nama header  drFieldCount ");

                        //#region #AddTable
                        IXlTable table;
                        // Create the first row in the worksheet from which the table starts.
                        using (IXlRow row = sheet.CreateRow())
                        {
                            // Start generating the table with a header row displayed.
                            table = row.BeginTable(XlsHeader, true);
                        }

                        // Generate table rows and populate them with data.
                        eService.WriteToFile("  {0} sebelum  dataReader.Read() ");
                        while (dataReader.Read())
                        {
                            eService.WriteToFile("  {0}  while (dataReader.Read()) " + database);
                            ArrayList xlsData = new ArrayList();
                            for (int i = 0; i < drFieldCount; i++)
                            {
                                // set to array list
                                xlsData.Add(dataReader[i]);
                            }
                            using (IXlRow row = sheet.CreateRow())
                                row.BulkCells(xlsData, null);
                        }


                    }
                }
            }
        }
    }
    //public enum eDataReplace
    //{
    //    PTOU = 0,
    //    Date = 1,
    //    User = 2

    //}
}
