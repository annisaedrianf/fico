using System;
using DevExpress.Xpo;
using DevExpress.Persistent.Base;
using System.ComponentModel;
using DevExpress.Persistent.Validation;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.ConditionalAppearance;
using DevExpress.ExpressApp;
using DevExpress.Data.Filtering;
using System.Data.SqlClient;
using DevExpress.CodeParser;
using DevExpress.Xpo.DB;

namespace cetho.Module.BusinessObjects
{

    [DefaultClassOptions]
    [ImageName("ModelEditor_Views")]
    [DefaultProperty("ID")]
    [NavigationItem("Sync")]
    // Standard Document
    [System.ComponentModel.DisplayName("Company")]
    public class SyncCompanyInfo : XPObject
    {
        //public CompanyInfo() : base()
        //{
        //    // This constructor is used when an object is loaded from a persistent storage.
        //    // Do not place any code here.
        //}

        public SyncCompanyInfo(Session session) : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.


            //SecuritySystem.CurrentUserName
            //LastUpdatedUser = Session.GetObjectByKey<GPUser>(SecuritySystem.CurrentUserId);

            string tUser = SecuritySystem.CurrentUserName.ToString();
            //LastUpdatedUser = Session.FindObject<GPUser>(new BinaryOperator("UserName", SecuritySystem.CurrentUserName.ToString()));
            // LastUpdatedUser = Session.FindObject<GPUser>(new BinaryOperator("UserName", tUser));

            // LastUpdate = DateTime.Now;
            oSyncCreateria = new GPSyncCreateria();

        }

        private GPSyncCreateria oSyncCreateria;

        private string _Title;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Title"), ToolTip("Title")]
        [Size(20)]
        public  string Title
        {
            get { return _Title; }
            set { SetPropertyValue("Title", ref _Title, value); }
        }

        private eGPSync _Type;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("Type"), ToolTip("Type")]
        //[Size(15)]
        public  eGPSync Type
        {
            get { return _Type; }
            set { SetPropertyValue("Type", ref _Type, value); }
        }
        private DateTime _FromDate;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("From Date"), ToolTip("From Date")]
        //[Size(15)]
        public  DateTime FromDate
        {
            get { return _FromDate; }
            set { SetPropertyValue("FromDate", ref _FromDate, value); }
        }

        private DateTime _ToDate;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("To Date"), ToolTip("To Date")]
        //[Size(15)]
        public  DateTime ToDate
        {
            get { return _ToDate; }
            set { SetPropertyValue("ToDate", ref _ToDate, value); }
        }
        [Association("SyncCompanySetup")]
        public XPCollection<CompanyInfo> SyncCompany
        {
            get
            {
                return GetCollection<CompanyInfo>("SyncCompany");
            }
        }
        private double _LastRowUpated;
        //[RuleRequiredField(DefaultContexts.Save)]

        [XafDisplayName("Last Row Upated"), ToolTip("Last Row Upated")]
        //[Size(15)]
        public  double LastRowUpated
        {
            get { return _LastRowUpated; }
            set { SetPropertyValue("LastRowUpated", ref _LastRowUpated, value); }
        }

        private Boolean _AsJobSchedule;
        //[RuleRequiredField(DefaultContexts.Save)]
        [XafDisplayName("As Job Schedule"), ToolTip("As Job Schedule")]
        //[Size(15)]
        public  Boolean AsJobSchedule
        {
            get { return _AsJobSchedule; }
            set { SetPropertyValue("AsJobSchedule", ref _AsJobSchedule, value); }
        }


        private string fmtstr(string idSql)
        {
            return "'" + idSql.Replace("'", "''").Trim() + "'";
        }

        [XafDisplayName("Connection String "), ToolTip("Connection String")]
        [Size(SizeAttribute.Unlimited)]
        public  string ConnectionString
        {
            get { return GetPropertyValue<string>("ConnectionString"); }
            set { SetPropertyValue("ConnectionString", value); }
        }



        private string SyncBudgetHASql()
        {
            string sql = "";
            sql += " SELECT [Tahun] ";
            sql += " ,[Kode Budget] ";
            //sql += " ,[FORECAST] ";
            sql += " ,[OU] ";
            sql += " ,[Estate] ";
            sql += " ,[Divisi] ";
            sql += " ,[Blok] ";
            sql += " ,[Original Planting Date] ";
            sql += " ,[Indicator Status] ";

            sql += " ,[Budget Maturity Date] ";
            sql += " ,[VARIETAS] ";
            sql += " ,[TOPOGRAFI] ";
            //sql += " ,[Area Diusahakan Existing] ";
            //sql += " ,[Area Diusahakan Estimate] ";
            //sql += " ,[Area Diusahakan Budget] ";
            //sql += " ,[Area Ditanam Existing] ";
            //sql += " ,[Area Ditanam Estimate] ";
            //sql += " ,[Area Ditanam Budget] ";
            //sql += " ,[Area Sudah Tanam Existing] ";
            //sql += " ,[Area Sudah Tanam Estimate] ";
            sql += " ,[Area Sudah Tanam Budget] ";
            //sql += " ,[Actual Ha Harvesting Existing] ";
            //sql += " ,[Actual Ha Harvesting Estimate] ";
            //sql += " ,[Actual Ha Harvesting Budget] ";
            //sql += " ,[Enclave Sudah Tanam Existing] ";
            //sql += " ,[Enclave Sudah Tanam Estimate] ";
            //sql += " ,[Enclave Sudah Tanam Budget] ";
            //sql += " ,[Land Clearing Existing] ";
            //sql += " ,[Land Clearing Estimate] ";
            //sql += " ,[Land Clearing Budget] ";
            //sql += " ,[LC Sedang Dikerjakan Existing] ";
            //sql += " ,[LC Sedang Dikerjakan Estimate] ";
            //sql += " ,[LC Sedang Dikerjakan Budget] ";
            //sql += " ,[LC Belum Dikerjakan Existing] ";
            //sql += " ,[LC Belum Dikerjakan Estimate] ";
            //sql += " ,[LC Belum Dikerjakan Budget] ";
            //sql += " ,[LC Selesai Dikerjakan Existing] ";
            //sql += " ,[LC Selesai Dikerjakan Estimate] ";
            //sql += " ,[LC Selesai Dikerjakan Budget] ";
            //sql += " ,[Belum LCC Existing] ";
            //sql += " ,[Belum LCC Estimate] ";
            //sql += " ,[Belum LCC Budget] ";
            //sql += " ,[Sudah LCC Existing] ";
            //sql += " ,[Sudah LCC Estimate] ";
            //sql += " ,[Sudah LCC Budget] ";
            //sql += " ,[Area Bibitan Existing] ";
            //sql += " ,[Area Bibitan Estimate] ";
            //sql += " ,[Area Bibitan Budget] ";
            //sql += " ,[Area Bisa Ditanam Existing] ";
            //sql += " ,[Area Bisa Ditanam Estimate] ";
            //sql += " ,[Area Bisa Ditanam Budget] ";
            //sql += " ,[Area Belum Tanam Existing] ";
            //sql += " ,[Area Belum Tanam Estimate] ";
            //sql += " ,[Area Belum Tanam Budget] ";
            //sql += " ,[Enclave Belum Tanam Existing] ";
            //sql += " ,[Enclave Belum Tanam Estimate] ";
            //sql += " ,[Enclave Belum Tanam Budget] ";
            //sql += " ,[Cadangan Existing] ";
            //sql += " ,[Cadangan Estimate] ";
            //sql += " ,[Cadangan Budget] ";
            //sql += " ,[Okupasi Existing] ";
            //sql += " ,[Okupasi Estimate] ";
            //sql += " ,[Okupasi Budget] ";
            //sql += " ,[Area Prasarana Existing] ";
            //sql += " ,[Area Prasarana Estimate] ";
            //sql += " ,[Area Prasarana Budget] ";
            //sql += " ,[Emplasmen Existing] ";
            //sql += " ,[Emplasmen Estimate] ";
            //sql += " ,[Emplasmen Budget] ";
            //sql += " ,[Pabrik Existing] ";
            //sql += " ,[Pabrik Estimate] ";
            //sql += " ,[Pabrik Budget] ";
            //sql += " ,[Jalan Existing] ";
            //sql += " ,[Jalan Estimate] ";
            //sql += " ,[Jalan Budget] ";
            //sql += " ,[Jalan Produksi Existing] ";
            //sql += " ,[Jalan Produksi Estimate] ";
            //sql += " ,[Jalan Produksi Budget] ";
            //sql += " ,[Jalan Poros Existing] ";
            //sql += " ,[Jalan Poros Estimate] ";
            //sql += " ,[Jalan Poros Budget] ";
            //sql += " ,[Lain-Lain Existing] ";
            //sql += " ,[Lain-Lain Estimate] ";
            //sql += " ,[Lain-Lain Budget] ";
            //sql += " ,[Area Tdk Bisa Ditanam Existing] ";
            //sql += " ,[Area Tdk Bisa Ditanam Estimate] ";
            //sql += " ,[Area Tdk Bisa Ditanam Budget] ";
            //sql += " ,[Tanah Desa Existing] ";
            //sql += " ,[Tanah Desa Estimate] ";
            //sql += " ,[Tanah Desa Budget] ";
            //sql += " ,[Sungai Existing] ";
            //sql += " ,[Sungai Estimate] ";
            //sql += " ,[Sungai Budget] ";
            //sql += " ,[Rawa Existing] ";
            //sql += " ,[Rawa Estimate] ";
            //sql += " ,[Rawa Budget] ";
            //sql += " ,[Parit Existing] ";
            //sql += " ,[Parit Estimate] ";
            //sql += " ,[Parit Budget] ";
            //sql += " ,[Jumlah Pokok Existing] ";
            //sql += " ,[Jumlah Pokok Estimate] ";
            sql += " ,[Jumlah Pokok Budget] ";
            //sql += " ,[Status Kebun] ";
            sql += " ,[STATUS DOKUMEN] ";
            sql += " ,[CREATOR] ";
            sql += " ,[PANEN] ";
            //sql += " ,[MODIFIED USER] ";
            sql += "  FROM [BP_BUDGET_AREASTATEMENT] ";
            return sql;
        }


        /*
         * =========================================================================
         */
        private string SyncGPAPltHAStatementSql()
        {
            string sql = "";
            sql += " SELECT  [OU] ";
            sql += " , [Estate] ";
            sql += " , [Divisi] ";
            sql += " , [Blok] ";
            sql += " , [Deskripsi] ";
            sql += " , [Indicator Status] ";
            sql += " , [Varietas] ";
            sql += " , [Topography] ";
            sql += " , [Jenis Tanah] ";
            sql += " , [Area Diusahakan] ";
            sql += " , [Area Ditanam] ";
            sql += " , [Area Sudah Tanam] ";
            sql += " , [HA Control] ";
            sql += " , [Enclave Sudah Tanam] ";
            sql += " , [Area Belum Tanam] ";
            sql += " , [Enclave Belum Tanam] ";
            sql += " , [Land Clearing] ";
            sql += " , [Sedang Dikerjakan] ";
            sql += " , [Belum Dikerjakan] ";
            sql += " , [Area Bibitan / Nursery] ";
            sql += " , [Area Bisa Ditanam] ";
            sql += " , [Cadangan] ";
            sql += " , [Okupasi] ";
            sql += " , [Area Tidak Bisa Ditanam] ";
            sql += " , [Tanah Desa] ";
            sql += " , [Sungai] ";
            sql += " , [Area Prasarana] ";
            sql += " , [Emplasmen] ";
            sql += " , [Pabrik] ";
            sql += " , [Jalan] ";
            sql += " , [Jalan Produksi] ";
            sql += " , [Jalan Poros] ";
            sql += " , [Jembatan] ";
            sql += " , [Lain Lain] ";
            sql += " , [Tanggal Tanam] ";
            sql += " , [Tahun Tanam] ";
            sql += " , [Tanggal TM / TBM] ";
            sql += " , [Rawa] ";
            sql += " , [Parit] ";
            sql += " , [Pokok Per Hektar] ";
            sql += " , [Jumlah Pokok] ";
            sql += " , [Jumlah Pokok Non Komersil] ";
            sql += " , [Segment Account] ";
            sql += " , [Koordinat] ";
            sql += " , [Jenis Pohon] ";
            sql += " , [Total Area] ";
            sql += " , [Kode Ketinggian] ";
            sql += " , [STATUS KEBUN] ";
            sql += " , [Panen] ";
            sql += " , [Tanggal Mulai Panen] ";
            sql += " , [LC Selesai Dikerjakan] ";
            sql += " , [Belum LCC] ";
            sql += " , [Sudah LCC] ";
            sql += " , [Created User ID] ";
            sql += " , [Created Date] ";
            sql += " , [Modified User ID] ";
            sql += " , [Modified Date] ";
            sql += " FROM  [dbo].[AREA_STATEMENT_SMARTLIST]  ";
            return sql;
        }
        //private void SyncGPAPltHAStatement(CompanyInfo oCompany)
        //{
        //    SyncDataService oDS = new SyncDataService();
        //    SqlDataReader oDR;
        //    oSyncCreateria.Sync();
        //    string sSql = SyncGPAPltHAStatementSql();
        //    //sSql += "(convert(varchar(4),[Tahun] ,112)  BETWEEN  ";
        //    //sSql += oSyncCreateria.FromDate.ToString("yyyy") + " AND ";
        //    //sSql += oSyncCreateria.ToDate.ToString("yyyy") + ")";
        //    //sSql += "(convert(varchar(2),[Kode Budget] ,112)  BETWEEN  ";
        //    //sSql += "'" + oSyncCreateria.FromDate.ToString("MM") + "'" + " AND ";
        //    //sSql += "'" + oSyncCreateria.ToDate.ToString("MM") + "'" + ")";
        //    CriteriaOperator filterOperator;
        //    HAStatement oGPAPltHAStatement;
        //    oDR = oDS.ExeQuery(sSql, oCompany.ConnectionString);
        //    while (oDR.Read())
        //    {
        //        string sqlQuery = "";
        //        sqlQuery += "OU == " + "'" + oDR.GetString(eIdxGPAPltHAStatement.OU.GetHashCode()) + "'" + " and ";
        //        sqlQuery += "Estate == " + "'" + oDR.GetString(eIdxGPAPltHAStatement.Estate.GetHashCode()) + "'" + " and ";
        //        sqlQuery += "Divisi == " + "'" + oDR.GetString(eIdxGPAPltHAStatement.Divisi.GetHashCode()) + "'" + " and ";
        //        sqlQuery += "Blok == " + "'" + oDR.GetString(eIdxGPAPltHAStatement.Blok.GetHashCode()) + "'";
        //        filterOperator = CriteriaOperator.Parse(sqlQuery);
        //        oGPAPltHAStatement = Session.FindObject<HAStatement>(filterOperator);
        //        if (oGPAPltHAStatement == null)
        //        {
        //            oGPAPltHAStatement = new HAStatement(Session);
        //            if (oDR[eIdxGPAPltHAStatement.OU.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.OU = oDR.GetString(eIdxGPAPltHAStatement.OU.GetHashCode());
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.Estate.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.Estate = oDR.GetString(eIdxGPAPltHAStatement.Estate.GetHashCode());
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.Divisi.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.Divisi = oDR.GetString(eIdxGPAPltHAStatement.Divisi.GetHashCode());
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.Blok.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.Blok = oDR.GetString(eIdxGPAPltHAStatement.Blok.GetHashCode());
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.Deskripsi.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.Deskripsi = oDR.GetString(eIdxGPAPltHAStatement.Deskripsi.GetHashCode());
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.IndicatorStatus.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.IndicatorStatus = oDR.GetString(eIdxGPAPltHAStatement.IndicatorStatus.GetHashCode());
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.Varietas.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.Varietas = oDR.GetString(eIdxGPAPltHAStatement.Varietas.GetHashCode());
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.Topografi.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.Topografi = oDR.GetString(eIdxGPAPltHAStatement.Topografi.GetHashCode());
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.JenisTanah.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.JenisTanah = oDR.GetString(eIdxGPAPltHAStatement.JenisTanah.GetHashCode());
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.AreaDiusahakan.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.AreaDiusahakan = System.Convert.ToDouble(oDR.GetString(eIdxGPAPltHAStatement.AreaDiusahakan.GetHashCode()));
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.AreaDitanam.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.AreaDitanam = System.Convert.ToDouble(oDR.GetString(eIdxGPAPltHAStatement.AreaDitanam.GetHashCode()));
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.AreaSudahTanam.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.AreaSudahTanam = System.Convert.ToDouble(oDR.GetString(eIdxGPAPltHAStatement.AreaSudahTanam.GetHashCode()));
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.HAControl.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.HAControl = System.Convert.ToDouble(oDR.GetString(eIdxGPAPltHAStatement.HAControl.GetHashCode()));
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.EnclaveSudahTanam.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.EnclaveSudahTanam = System.Convert.ToDouble(oDR.GetString(eIdxGPAPltHAStatement.EnclaveSudahTanam.GetHashCode()));
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.AreaBelumTanam.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.AreaBelumTanam = System.Convert.ToDouble(oDR.GetString(eIdxGPAPltHAStatement.AreaBelumTanam.GetHashCode()));
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.EnclaveBelumTanam.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.EnclaveBelumTanam = System.Convert.ToDouble(oDR.GetString(eIdxGPAPltHAStatement.EnclaveBelumTanam.GetHashCode()));
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.LandClearing.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.LandClearing = System.Convert.ToDouble(oDR.GetString(eIdxGPAPltHAStatement.LandClearing.GetHashCode()));
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.SedangDikerjakan.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.SedangDikerjakan = System.Convert.ToDouble(oDR.GetString(eIdxGPAPltHAStatement.SedangDikerjakan.GetHashCode()));
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.BelumDikerjakan.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.BelumDikerjakan = System.Convert.ToDouble(oDR.GetString(eIdxGPAPltHAStatement.BelumDikerjakan.GetHashCode()));
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.AreaBibitanNursery.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.AreaBibitanNursery = System.Convert.ToDouble(oDR.GetString(eIdxGPAPltHAStatement.AreaBibitanNursery.GetHashCode()));
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.AreaBisaDitanam.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.AreaBisaDitanam = System.Convert.ToDouble(oDR.GetString(eIdxGPAPltHAStatement.AreaBisaDitanam.GetHashCode()));
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.Cadangan.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.Cadangan = System.Convert.ToDouble(oDR.GetString(eIdxGPAPltHAStatement.Cadangan.GetHashCode()));
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.Okupasi.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.Okupasi = System.Convert.ToDouble(oDR.GetString(eIdxGPAPltHAStatement.Okupasi.GetHashCode()));
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.AreaTidakBisaDitanam.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.AreaTidakBisaDitanam = System.Convert.ToDouble(oDR.GetString(eIdxGPAPltHAStatement.AreaTidakBisaDitanam.GetHashCode()));
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.TanahDesa.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.TanahDesa = System.Convert.ToDouble(oDR.GetString(eIdxGPAPltHAStatement.TanahDesa.GetHashCode()));
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.Sungai.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.Sungai = System.Convert.ToDouble(oDR.GetString(eIdxGPAPltHAStatement.Sungai.GetHashCode()));
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.AreaPrasarana.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.AreaPrasarana = System.Convert.ToDouble(oDR.GetString(eIdxGPAPltHAStatement.AreaPrasarana.GetHashCode()));
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.Emplasmen.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.Emplasmen = System.Convert.ToDouble(oDR.GetString(eIdxGPAPltHAStatement.Emplasmen.GetHashCode()));
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.Pabrik.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.Pabrik = System.Convert.ToDouble(oDR.GetString(eIdxGPAPltHAStatement.Pabrik.GetHashCode()));
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.Jalan.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.Jalan = System.Convert.ToDouble(oDR.GetString(eIdxGPAPltHAStatement.Jalan.GetHashCode()));
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.JalanProduksi.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.JalanProduksi = System.Convert.ToDouble(oDR.GetString(eIdxGPAPltHAStatement.JalanProduksi.GetHashCode()));
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.JalanPoros.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.JalanPoros = System.Convert.ToDouble(oDR.GetString(eIdxGPAPltHAStatement.JalanPoros.GetHashCode()));
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.Jembatan.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.Jembatan = System.Convert.ToDouble(oDR.GetString(eIdxGPAPltHAStatement.Jembatan.GetHashCode()));
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.LainLain.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.LainLain = System.Convert.ToDouble(oDR.GetString(eIdxGPAPltHAStatement.LainLain.GetHashCode()));
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.TanggalTanam.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.TanggalTanam = oDR.GetString(eIdxGPAPltHAStatement.TanggalTanam.GetHashCode());
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.TahunTanam.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.TahunTanam = oDR.GetString(eIdxGPAPltHAStatement.TahunTanam.GetHashCode());
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.TanggalTMTBM.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.TanggalTMTBM = oDR.GetString(eIdxGPAPltHAStatement.TanggalTMTBM.GetHashCode());
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.Rawa.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.Rawa = oDR.GetString(eIdxGPAPltHAStatement.Rawa.GetHashCode());
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.Parit.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.Parit = oDR.GetString(eIdxGPAPltHAStatement.Parit.GetHashCode());
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.PokokPerHektar.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.PokokPerHektar = System.Convert.ToDouble(oDR.GetString(eIdxGPAPltHAStatement.PokokPerHektar.GetHashCode()));
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.JumlahPokok.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.JumlahPokok = System.Convert.ToDouble(oDR.GetString(eIdxGPAPltHAStatement.JumlahPokok.GetHashCode()));
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.JumlahPokokNonKomersil.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.JumlahPokokNonKomersil = System.Convert.ToDouble(oDR.GetString(eIdxGPAPltHAStatement.JumlahPokokNonKomersil.GetHashCode()));
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.SegmentAccount.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.SegmentAccount = oDR.GetString(eIdxGPAPltHAStatement.SegmentAccount.GetHashCode());
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.Koordinat.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.Koordinat = oDR.GetString(eIdxGPAPltHAStatement.Koordinat.GetHashCode());
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.JenisPohon.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.JenisPohon = oDR.GetString(eIdxGPAPltHAStatement.JenisPohon.GetHashCode());
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.TotalArea.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.TotalArea = System.Convert.ToDouble(oDR.GetString(eIdxGPAPltHAStatement.TotalArea.GetHashCode()));
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.KodeKetinggian.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.KodeKetinggian = oDR.GetString(eIdxGPAPltHAStatement.KodeKetinggian.GetHashCode());
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.STATUSKEBUN.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.STATUSKEBUN = oDR.GetString(eIdxGPAPltHAStatement.STATUSKEBUN.GetHashCode());
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.Panen.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.Panen = oDR.GetString(eIdxGPAPltHAStatement.Panen.GetHashCode());
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.TanggalMulaiPanen.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.TanggalMulaiPanen = oDR.GetString(eIdxGPAPltHAStatement.TanggalMulaiPanen.GetHashCode());
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.LCSelesaiDikerjakan.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.LCSelesaiDikerjakan = oDR.GetString(eIdxGPAPltHAStatement.LCSelesaiDikerjakan.GetHashCode());
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.BelumLCC.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.BelumLCC = System.Convert.ToDouble(oDR.GetString(eIdxGPAPltHAStatement.BelumLCC.GetHashCode()));
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.SudahLCC.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.SudahLCC = System.Convert.ToDouble(oDR.GetString(eIdxGPAPltHAStatement.SudahLCC.GetHashCode()));
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.CreatedUserID.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.CreatedUserID = oDR.GetString(eIdxGPAPltHAStatement.CreatedUserID.GetHashCode());
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.CreatedDate.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.CreatedDate = oDR.GetString(eIdxGPAPltHAStatement.CreatedDate.GetHashCode());
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.ModifiedUserID.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.ModifiedUserID = oDR.GetString(eIdxGPAPltHAStatement.ModifiedUserID.GetHashCode());
        //            }
        //            if (oDR[eIdxGPAPltHAStatement.ModifiedDate.GetHashCode()] != DBNull.Value)
        //            {
        //                oGPAPltHAStatement.ModifiedDate = oDR.GetString(eIdxGPAPltHAStatement.ModifiedDate.GetHashCode());
        //            }
        //            oGPAPltHAStatement.LastSync = oSyncCreateria.LastSync;
        //            oGPAPltHAStatement.Save();
        //            oGPAPltHAStatement.Session.CommitTransaction();
        //        }
        //    }
        //}



        /*
        ======================== * *=============================
        */




        /*
         * ==================================================
         */
    }
    public enum eGPSync
    {
        [XafDisplayName("NA")]
        NA = 0,
        [XafDisplayName("Items")]
        Items = 1,
        [XafDisplayName("Block")]
        Block = 2,
        [XafDisplayName("TRA")]
        TRA = 3,
        [XafDisplayName("Activity")]
        Activity = 4,
        [XafDisplayName("Employee")]
        Employee = 5,
        [XafDisplayName("BudgetHACrop")]
        BudgetHACrop = 6,
        [XafDisplayName("WB Timbang Mill")]
        GPAWBTxn = 7,
        [XafDisplayName("Master Area Statement")]
        GPAPltHAStatement = 8,
        [XafDisplayName("Budget Harvesting")]
        GPABgtHarvesting = 9,
        [XafDisplayName("GC Alokasi-Amount")]
        GPABgtGCAllocation = 10,
        [XafDisplayName("Account Transactions - TB Templ")]
        GPAFinTB = 11,
        [XafDisplayName("Budget Upkeep")]
        GPABgtUpkeep = 12,
        [XafDisplayName("Budget Production")]
        GPABgtProduction=13,
        [XafDisplayName("Budget Manuring")]
        GPABgtManuring = 14,
        [XafDisplayName("Budget Area Statement")]
        GPABgtHAStatement = 15,
        [XafDisplayName("GP Period")]
        SyncGPAGSPeriod=16
    }
}