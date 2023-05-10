using DevExpress.ExpressApp.DC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace cetho.Module.BusinessObjects
{
    /*
     SQL Server data type          CLR data type (SQL Server)    CLR data type (.NET Framework)  
varbinary                     SqlBytes, SqlBinary           Byte[]  
binary                        SqlBytes, SqlBinary           Byte[]  
varbinary(1), binary(1)       SqlBytes, SqlBinary           byte, Byte[] 
image                         None                          None

varchar                       None                          None
char                          None                          None
nvarchar(1), nchar(1)         SqlChars, SqlString           Char, String, Char[]     
nvarchar                      SqlChars, SqlString           String, Char[] 
nchar                         SqlChars, SqlString           String, Char[] 
text                          None                          None
ntext                         None                          None

uniqueidentifier              SqlGuid                       Guid 
rowversion                    None                          Byte[]  
bit                           SqlBoolean                    Boolean 
tinyint                       SqlByte                       Byte 
smallint                      SqlInt16                      Int16  
int                           SqlInt32                      Int32  
bigint                        SqlInt64                      Int64 

smallmoney                    SqlMoney                      Decimal  
money                         SqlMoney                      Decimal  
numeric                       SqlDecimal                    Decimal  
decimal                       SqlDecimal                    Decimal  
real                          SqlSingle                     Single  
float                         SqlDouble                     Double  

smalldatetime                 SqlDateTime                   DateTime  
datetime                      SqlDateTime                   DateTime 

sql_variant                   None                          Object  
User-defined type(UDT)        None                          user-defined type     
table                         None                          None 
cursor                        None                          None
timestamp                     None                          None 
xml                           SqlXml                        None
*/

    //public string fmtstr( string str)
    //{

    //    return str.Replace("'", "''").Trim();
    //}
    public enum eGPMMRExEstateCost
    {

        [XafDisplayName("HA")]
        HA = 0,
        [XafDisplayName("MT")]
        MT = 1,
        [XafDisplayName("Cost")]
        Cost = 2

    }

    public enum eIntiPlasma
    {

        [XafDisplayName("Inti")]
        Inti = 0,
        [XafDisplayName("Plasma")]
        Plasma = 1

    }
    public enum eBudgetType
    {

        [XafDisplayName("N/A")]
        NA = 0,
        [XafDisplayName("Upkeep Budget")]
        Upkeep = 1,
        [XafDisplayName("Manuring Budget")]
        Manuring = 2,
        [XafDisplayName("Harvesting & Transport Budget")]
        HarvestingTransport = 3
    }
    public enum eBudgetAllocation
    {

        [XafDisplayName("N/A")]
        NA = 0,
        [XafDisplayName("HA")]
        HA = 1,
        [XafDisplayName("KG")]
        KG = 2
    }
    public enum eBudgetIndicator
    {
        [XafDisplayName("N/A")]
        NA = 0,
        [XafDisplayName("Nursery")]
        Nursery = 1,
        [XafDisplayName("LC")]
        LC = 2,
        [XafDisplayName("TBM")]
        TBM = 3,
        [XafDisplayName("TM")]
        TM = 4,
        [XafDisplayName("GC")]
        GC = 5
        }

    public enum eHREmpSrSts
    {
        [XafDisplayName("New")]
        New = 0,
        [XafDisplayName("Inprogress")]
        InProgress = 1,
        [XafDisplayName("Closed")]
        ItemClass = 2

    }



    public enum eSqlIdxActvity
    {
        [XafDisplayName("ID Activity")]
        ID = 0,
        [XafDisplayName("ActivityName")]
        ActivityName = 1,
        [XafDisplayName("TypeHK")]
        TipeHK = 2,
        [XafDisplayName("UoM")]
        UoM = 3,
        [XafDisplayName("Indicator")]
        Indicator = 4

    }
    public enum eSqlIdxItem
    {
        [XafDisplayName("Item Number")]
        ItemNumber = 0,
        [XafDisplayName("Item Description")]
        ItemDescription = 1,
        [XafDisplayName("Item Class")]
        ItemClass = 2,
        [XafDisplayName("UoM")]
        UoM = 3,
        [XafDisplayName("Item Type")]
        ItemType = 4

    }

   
    public enum eTRAUpoadColumn
    {
        [XafDisplayName("ID")]
        Id = 0,
        [XafDisplayName("Name")]
        Name = 1,
        [XafDisplayName("OU")]
        OU = 2,
        [XafDisplayName("GroupTRA")]
        GroupTRA = 3,
        [XafDisplayName("Account")]
        Account = 4,
        [XafDisplayName("STNKDueDate")]
        STNKDueDate = 5


    }
    public enum eItemColumn
    {
        [XafDisplayName("ID")]
        Id = 0,
        [XafDisplayName("Name")]
        Name = 1,
        [XafDisplayName("ShortName")]
        ShortName = 2,
        [XafDisplayName("UOM")]
        UOM = 3,
        [XafDisplayName("ItemClass")]
        ItemClass = 4
    }
    public enum eAccountUpoadColumn
    {
        [XafDisplayName("ID")]
        Id = 0,
        [XafDisplayName("Name")]
        Name = 1,
        [XafDisplayName("Description")]
        Description = 2,
        [XafDisplayName("ShortName")]
        ShortName = 3,
        [XafDisplayName("CostAtribute")]
        CostAtribute = 4,
        [XafDisplayName("Header")]
        Header = 5,
        [XafDisplayName("AccountGroup")]
        AccountGroup = 6,
        [XafDisplayName("Type")]
        Type = 7,
        [XafDisplayName("BudgetType")]
        BudgetType = 8,
        [XafDisplayName("BudgetIndicator")]
        BudgetIndicator = 9


    }
    public enum eHMKM
    {
        [XafDisplayName("KM")]
        KM = 0,
        [XafDisplayName("HM")]
        HM = 1
    }

    public enum eNumGroup
    {
        //[XafDisplayName("KM")]
        //KM = 0,
        //[XafDisplayName("HM")]
        //HM = 1,
    }
    public enum eAccountType
    {
        [XafDisplayName("H")]
        H = 0,
        [XafDisplayName("D")]
        D = 1

    }
    public enum eSyncBudgetCropSql
    {
        [XafDisplayName("Tahun")]
        Tahun = 0,
        [XafDisplayName("KodeBudgetCrop")]
        KodeBudgetCrop = 1,
        [XafDisplayName("KodeBudgetHA")]
        KodeBudgetHA = 2,
        [XafDisplayName("KodeBudgetTrend")]
        KodeBudgetTrend = 3,
        [XafDisplayName("OU")]
        OU = 4,
        [XafDisplayName("Estate")]
        Estate = 5,
        [XafDisplayName("Divisi")]
        Divisi = 6,
        [XafDisplayName("Blok")]
        Blok = 7,
        [XafDisplayName("CropMT")]
        CropMT = 8,
        [XafDisplayName("Creator")]

        Creator = 9,
        [XafDisplayName("Status")]
        Status = 10,
        [XafDisplayName("Scout")]
        Scout = 11
    }
    public enum eSyncBudgetHASql
    {
        [XafDisplayName("Tahun")]
        Tahun = 0,
        [XafDisplayName("KodeBudget")]
        KodeBudget = 1,
        [XafDisplayName("OU")]
        OU = 2,
        [XafDisplayName("Estate")]
        Estate = 3,
        [XafDisplayName("Divisi")]
        Divisi = 4,
        [XafDisplayName("Blok")]
        Blok = 5,
        [XafDisplayName("PlantingDate")]
        PlantingDate = 6,
        [XafDisplayName("Indicator")]
        Indicator = 7,
        [XafDisplayName("MaturityDate")]
        MaturityDate = 8,
        [XafDisplayName("VARIETAS")]
        VARIETAS = 9,
        [XafDisplayName("TOPOGRAFI")]
        TOPOGRAFI = 10,
        [XafDisplayName("HA")]
        HA = 11,
        [XafDisplayName("TotalPokok")]
        TotalPokok = 12,
        [XafDisplayName("Status")]
        Status = 13,
        [XafDisplayName("Creator")]
        Creator = 14,
        [XafDisplayName("Scout")]
        Scout = 15
    }

    public enum eBudgetMasterCode
    {
        [XafDisplayName("Code")]
        Code = 0,
        [XafDisplayName("Aresta/Hectare")]
        Aresta = 1,
        [XafDisplayName("VRA")]
        VRA = 2,
        [XafDisplayName("StandardUpah")]
        StandardUpah = 3,
        [XafDisplayName("StandardBahan")]
        StandardBahan = 4,
        [XafDisplayName("StandardTanaman")]
        StandardTanaman = 5,
        [XafDisplayName("StandardPremi")]
        StandardPremi = 6,
        [XafDisplayName("DistributionEstate")]
        DistributionEstate = 7,
        [XafDisplayName("Crop")]
        Crop = 8



    }

    public enum eBudgetSheets
    {
        [XafDisplayName("N/A")]
        NA = 0,
        [XafDisplayName("Budget Summary")]
        BudgetSummary =1,
        [XafDisplayName("Hectare")]
        Hectare = 2,
        [XafDisplayName("Crop")]
        Crop = 3,
        [XafDisplayName("Harvesting Transportation")]
        HarvestingTransportation = 4,
        [XafDisplayName("Labour Cost")]
        LabourCost = 5,
        [XafDisplayName("Material Cost")]
        MaterialCost = 6,
        [XafDisplayName("VRA Cost")]
        VRACost = 7,
        [XafDisplayName("Last POPrice ")]
        LastPOPrice = 8,
        [XafDisplayName("Workshop")]
        Workshop = 9,
        [XafDisplayName("Workshop Allocation")]
        WorkshopAllocation = 10,
        [XafDisplayName("EXCAVATOR")]
        EXCAVATOR = 11,
        [XafDisplayName("BIN TRUCK")]
        BINTRUCK = 12,
        [XafDisplayName("COMPACTOR")]
        COMPACTOR = 13,
        [XafDisplayName("MOTOR GREDER")]
        MOTORGREDER = 14,
        [XafDisplayName("BACKHOE LOADER")]
        BACKHOELOADER = 15,
        [XafDisplayName("BULLDOZER")]
        BULLDOZER = 16,
        [XafDisplayName("FARM TRACTOR")]
        FARMTRACTOR = 17,
        [XafDisplayName("MINI TRACTOR")]
        MINITRACTOR = 18,
        [XafDisplayName("MINI TRAILER")]
        MINITRAILER = 19,
        [XafDisplayName("LVH")]
        LVH = 20,
        [XafDisplayName("AMBULANCE")]
        AMBULANCE = 21,
        [XafDisplayName("BUSSEKOLAH")]
        BUSSEKOLAH = 22,
        [XafDisplayName("DUMP TRUCK")]
        DUMPTRUCK = 23,
        [XafDisplayName("GENSET")]
        GENSET = 24,
        [XafDisplayName("TUGBOAT")]
        TUGBOAT = 25
            


    }
    public enum eBudgetMonthly
    {
        [XafDisplayName("Jan")]
        M01 = 1,
        [XafDisplayName("Feb")]
        M02 = 2,
        [XafDisplayName("Mar")]
        M03 = 3,
        [XafDisplayName("Apr")]
        M04 = 4,
        [XafDisplayName("May")]
        M05 = 5,
        [XafDisplayName("Jun")]
        M06 = 6,
        [XafDisplayName("JUl")]
        M07 = 7,
        [XafDisplayName("Aug")]
        M08 = 8,
        [XafDisplayName("Sep")]
        M09 = 9,
        [XafDisplayName("Oct")]
        M10 = 10,
        [XafDisplayName("Nov")]
        M11 = 11,
        [XafDisplayName("Des")]
        M12 = 12,
        [XafDisplayName("Total")]
        M99 = 99
    }
    public enum eBudgetWorkshopItem
    {
        [XafDisplayName("N/A")]
        NA = 0,
        [XafDisplayName("Fuel")]
        Fuel = 1,
        [XafDisplayName("Lubricant")]
        Lubricant = 2,
        [XafDisplayName("SparePart&Others")]
        SparePartOthers = 3
    }

    public enum eBudgetHA
    {
        Estate = 0,
        Div = 1,
        Block = 2,
        ShortBlock = 3,
        PlantingDate = 4,
        Hecater = 6,
        TotalPlam = 7,
        SPH = 8,
        Indicator = 9,
        StaringAge = 11,
        EndingAge = 22
    }
    public enum eBudgetCrop
    {
        Estate = 1,
        Div = 2,
        Block = 3,
        FFBKG=101
    }
    public enum eBudgetTRAItem
    {
        [XafDisplayName("Spare Part")]
        SparePart = 0,
        [XafDisplayName("Service")]
        Service = 1
    }
    public enum eBudgetWorkshop
    {
        Items = 0,
        TotalQty = 3,
        TotalUnitPrice = 10,
        TotalAmount = 15,
        HoursRow=6,
        HoursCol = 13,
        Mechanic = 11,
        AllowanceRow = 13,
        NaturaRow = 12,
        THRRow = 21,
        SalaryRow = 23,
        FuelRow = 34,
        LubricantRow = 39,
        SparePartRow = 88,
        TotalCostRow = 90
    }

    public enum eBudgetTRA
    {
        Account = 2,
        TotalDistribution = 18,
        TotalRunning = 5,
        SpartPartItem =2,
        SpartPartItemRemark = 3,
        SpartPartQty = 4,
        SpartPartUP = 5,
        ServiceItem = 8,
        ServiceItemRemarks = 9,
        ServiceQty = 13,
        ServiceUP = 14,
        LastCostRow=291,
        StartItem = 565,
        HMKM= 7,
        Salary =8,
        Premi=9,
        Fuel=10,
        Workshop=11,
        SparePart=12,
        ServiceReapir=13,
        TotalSummary=14


    }
    public enum eBudgetMaterial
    {
        Account = 1,
        ItemDescription =4,
        Item = 5,
        QtyOrPrice=6,
        Qty = 9,
        UnitPrice=7
    }
    public enum eBudgetLabourCost
    {
        Account = 1,
        HKWorker=7,
        HKSPV = 9
    }
    public enum eBudgetSummary
    {
        Account=1,
        Activities=2,
        UoM=3,
        Volume=4,
        Rounds=5,    
        QtyOfWork=6,
        Labour=7,
        Material=8,
        VRA=9,
        Contractor=10,
        CostUnit=11,
        TotalBudget=12,
        BudgetMT=13,
        BudgetHa=14


    }
    public enum eBudgetUpload
    {
        Summary,
        Account,
        AccountGroup,
        CostAtribute,
        GroupTRA,
        TRA,
        UOM,
        Item,
        ItemClass,
        PlantingMaterial,
        Terrain,
        Indicator

    }
    public enum eObjectUpload
    {
        Region,
        company,
        OU,
        Estate,
        Division,
        Department,
        Position,
        People,
        Variestas,
        Indicator,
        AreaStatements,
        Employee,
        Jabatan,
        PekerjaanUtama,
        FiscalPeriod,
        CaseType,
        Module,
        ResolutionType,
        RootCauseType,
        ServiceStage,
        Severity,
        SubModul,
        TicketList

    }

    public enum eDataReplace
    {
        PTOU=0,
        Date=1,
        User=2,
        UserLoginInfo=3


    }
    public enum eGPTiketColumn
    {
        [XafDisplayName("Ticket Number")]
        TicketNumber = 0,
        [XafDisplayName("Tgl Response")]
        TglResponse = 1,
        [XafDisplayName("Description")]
        Description = 2,
        [XafDisplayName("Case Type")]
        CaseType = 3,
        [XafDisplayName("Company")]
        Company = 4,
        [XafDisplayName("OU")]
        OU = 5,
        [XafDisplayName("Week Open")]
        WeekOpen = 6,
        [XafDisplayName("Week Solved")]
        WeekSolved = 7,
        [XafDisplayName("Module")]
        Module = 8,
        [XafDisplayName("Sub Module")]
        SubModule = 9,
        [XafDisplayName("Aging")]
        Aging = 10,
        [XafDisplayName("Resolution Time")]
        ResolutionTime = 11,
        [XafDisplayName("Severity")]
        Severity = 12,
        [XafDisplayName("Tgl Solved")]
        TglSolved = 13,
        [XafDisplayName("Root Cause")]
        RootCause = 14,
        [XafDisplayName("Root Cause Type")]
        RootCauseType = 15,
        [XafDisplayName("Solution")]
        Solution = 16,
        [XafDisplayName("Customer")]
        Customer = 17,
        [XafDisplayName("Case Title")]
        CaseTitle = 18,
        [XafDisplayName("Service Stage")]
        ServiceStage = 19,
        [XafDisplayName("Resolution Action")]
        ResolutionAction = 20,
        [XafDisplayName("Resolution Type")]
        ResolutionType = 21,
        [XafDisplayName("Target Date")]
        TargetDate = 22,
        [XafDisplayName("Closed Date")]
        ClosedDate = 23,
        [XafDisplayName("Category")]
        Category = 24,
        [XafDisplayName("Notes")]
        Notes = 25,
        [XafDisplayName("Notes Solved")]
        NotesSolved = 26


    };
    public enum eTiketMasterColumn
    {
        [XafDisplayName("ID")]
        Id = 0,
        [XafDisplayName("Name")]
        Name = 1,
        [XafDisplayName("Description")]
        Description = 2
    };
       public enum eSendingEmail
    {
        [XafDisplayName("MS Exchange")]
        MSExchange = 0,
        [XafDisplayName("SMTP Service")]
        SMTP = 1
        
    };

    public enum eRegionColumn
    {
        [XafDisplayName("Region ID")]
        Id = 0,
        [XafDisplayName("Region Name")]
        Name = 1,
        [XafDisplayName("Region Description")]
        Description = 2

    };
    public enum ePekerjaanTypeColumn
    {
        [XafDisplayName("N/A")]
        NA = 0,
        [XafDisplayName("Mill")]
        Mill = 1,
        [XafDisplayName("Plantation")]
        Plantation = 2,
        [XafDisplayName("Other")]
        Other = 3
    };

    public enum eCompanyColumn
    {
        [XafDisplayName("Company ID")]
        Id = 0,
        [XafDisplayName("Company Name")]
        Name = 1,
        [XafDisplayName("Company Description")]
        Description = 2,
        [XafDisplayName("Region ID")]
        Region = 3
    };
    public enum eOUColumn
    {
        [XafDisplayName("OU ID")]
        Id = 0,
        [XafDisplayName("OU Name")]
        Name = 1,
        [XafDisplayName("OU Description")]
        Description = 2,
        [XafDisplayName("Company ID")]
        Company = 3
    };
    public enum eEstateColumn
    {
        [XafDisplayName("Estate ID")]
        Id = 0,
        [XafDisplayName("Estate Name")]
        Name = 1,
        [XafDisplayName("Estate Description")]
        Description = 2,
        [XafDisplayName("OU ID")]
        OU = 3
    };
    public enum eDivisionColumn
    {
        [XafDisplayName("Division ID")]
        Id = 0,
        [XafDisplayName("Division Name")]
        Name = 1,
        [XafDisplayName("Division Description")]
        Description = 2,
        [XafDisplayName("Estate ID")]
        Estate = 3
    };
    public enum eDepartmentColumn
    {
        [XafDisplayName("Department ID")]
        Id = 0,
        [XafDisplayName("Department Name")]
        Name = 1,
        [XafDisplayName("Department Description")]
        Description = 2
    };
    public enum ePositionColumn
    {
        [XafDisplayName("Position ID")]
        Id = 0,
        [XafDisplayName("Department Name")]
        Name = 1,

    };
    public enum eVarietasColumn
    {
        [XafDisplayName("Varietas ID")]
        Id = 0,
        [XafDisplayName("Varietas Title")]
        Name = 1,

    };
    public enum eIndicatorColumn
    {
        [XafDisplayName("Indicator ID")]
        Id = 0,
        [XafDisplayName("Indicator Title")]
        Name = 1,
        [XafDisplayName("Indicator Status")]
        Status = 2
    };

    public enum eFiscalPeriodColumn
    {
        [XafDisplayName("Fiscal ID")]
        Id = 0,
        [XafDisplayName(" Title")]
        Name = 1,
        [XafDisplayName("Start Date")]
        StartDate = 2,
        [XafDisplayName("End Date")]
        EndDate = 3
    };

    public enum eJabatanColumn
    {
        [XafDisplayName("Indicator ID")]
        Id = 0,
        [XafDisplayName("Indicator Title")]
        Name = 1,
        [XafDisplayName("Indicator Status")]
        Status = 2
    };

    public enum ePekerjaanUtamaColumn
    {
        [XafDisplayName("N/A")]
        NA = 0,
        [XafDisplayName("LC")]
        LC = 1,
        [XafDisplayName("Nursery")]
        Nursery = 2,
        [XafDisplayName("Perawatan")]
        Perawatan = 3,
        [XafDisplayName("Panen")]
        Panen = 4,
        [XafDisplayName("Penderes")]
        Penderes = 5,
        [XafDisplayName("Operator / Traksi")]
        OperatorTraksi = 6,
        [XafDisplayName("Umum")]
        Umum = 7,
        [XafDisplayName("Bengkel Sentral")]
        BengkelSentral = 8,
        [XafDisplayName("Bengkel Kebun")]
        BengkelKebun = 9,
        [XafDisplayName("Bengkel PKS")]
        BengkelPKS = 10,
        [XafDisplayName("Kantor")]
        Kantor = 11,
        [XafDisplayName("Mill")]
        Mill = 12,
        [XafDisplayName("Satpam")]
        Satpam = 13,
        [XafDisplayName("Seed Garden")]
        SeedGarden = 14,
        [XafDisplayName("Seed Preparation")]
        SeedPreparation = 15,
        [XafDisplayName("Seed Processing")]
        SeedProcessing = 16,
        [XafDisplayName("Int Laboratory")]
        IntLaboratory = 17,
        [XafDisplayName("Tukang Muat")]
        TukangMuat = 18

    };

    public enum ePeopleColumn
    {
        [XafDisplayName("ID")]
        ID = 0,
        [XafDisplayName("Name")]
        Name = 1,
        [XafDisplayName("Position")]
        Position = 2,
        [XafDisplayName("Email")]
        Email = 3,
        [XafDisplayName("TelpExtNo")]
        TelpExtNo = 4,
        [XafDisplayName("TelpDirectNo")]
        TelpDirectNo = 5,
        [XafDisplayName("MobileNumber")]
        MobileNumber = 6,
        [XafDisplayName("Department")]
        Department = 7,
        [XafDisplayName("OU")]
        OU = 8
        
    };
    public enum eAttachEmailSetup
    {
        [XafDisplayName("None")]
        None = 0,
        [XafDisplayName("Excel")]
        Excel = 1,
        [XafDisplayName("Text")]
        Text = 2,
        [XafDisplayName("Words")]
        Words = 3,
        [XafDisplayName("PDF")]
        Pdf = 4
    };
    public enum eDataLevelSetup
    {
        [XafDisplayName("Region")]
        Region = 0,
        [XafDisplayName("Company")]
        Company = 1,
        [XafDisplayName("Operating Unit")]
        OU = 2
    };

    public enum eOUMBudgetAllocation
    {
        [XafDisplayName("NA")]
        NA = 0,
        [XafDisplayName("HA")]
        Ha = 1,
        [XafDisplayName("KG")]
        KG = 2
    };

    public enum eJobDetail
    {
        [XafDisplayName("Created")]
        Created = 0,
        [XafDisplayName("Process")]
        Process = 1,
        [XafDisplayName("Done")]
        Done = 2
    };
    public enum eSrvRecType
    {
        [XafDisplayName("Daily")]
        Daily = 0,
        [XafDisplayName("Weekly")]
        Weekly = 1,
        [XafDisplayName("Monthly")]
        Monthly = 2,
        [XafDisplayName("Yearly")]
        Yearly = 3
    };
    public enum eSrvRecEvery
    {
        [XafDisplayName("Second")]
        Second = 0,
        [XafDisplayName("Munites")]
        Munites = 1,
        [XafDisplayName("Hours")]
        Hours = 2,
        [XafDisplayName("Days")]
        Days = 3,
        [XafDisplayName("Months")]
        Months = 4,
        [XafDisplayName("Years")]
        Years = 5
    };

    public enum eIndicatorStatus
    {
        [XafDisplayName("Nursery")]
        Nursery = 1,
        [XafDisplayName("Nursery")]
        MAINNursery = 1,
        [XafDisplayName("LC")]
        LC = 2,
        [XafDisplayName("TBM")]
        TBM = 3,
        [XafDisplayName("TM")]
        TM = 4,
        [XafDisplayName("GC")]
        GC = 5,
        [XafDisplayName("Inactive")]
        Inactive = 0
    };
    public enum eUplodedMode
    {
        [XafDisplayName("New")]
        New  = 0,
        [XafDisplayName("Replace/Update")]
        Update = 1,
        [XafDisplayName("Delete")]
        Delete = 2
        
    };
    public enum eArestaColumn
    {
        [XafDisplayName("OU")]
        OU = 0,
        [XafDisplayName("Estate")]
        Estate = 1,
        [XafDisplayName("Divisi")]
        Divisi = 2,
        [XafDisplayName("Blok")]
        Blok = 3,
        [XafDisplayName("Deskripsi")]
        Deskripsi = 4,
        [XafDisplayName("Indicator")]
        Indicator = 5,
        [XafDisplayName("Varietas")]
        Varietas = 6,
        [XafDisplayName("Topography")]
        Topografi = 7,
        [XafDisplayName("JenisTanah")]
        JenisTanah = 8,
        [XafDisplayName("AreaDiusahakan")]
        AreaDiusahakan = 9,
        [XafDisplayName("AreaDitanam")]
        AreaDitanam = 10,
        [XafDisplayName("AreaSudahTanam")]
        AreaSudahTanam = 11,
        [XafDisplayName("HAControl")]
        HAControl = 12,
        [XafDisplayName("EnclaveSudahTanam")]
        EnclaveSudahTanam = 13,
        [XafDisplayName("AreaBelumTanam")]
        AreaBelumTanam = 14,
        [XafDisplayName("EnclaveBelumTanam")]
        EnclaveBelumTanam = 15,
        [XafDisplayName("LandClearing")]
        LandClearing = 16,
        [XafDisplayName("SedangDikerjakan")]
        SedangDikerjakan = 17,
        [XafDisplayName("BelumDikerjakan")]
        BelumDikerjakan = 18,
        [XafDisplayName("AreaBibitanNursery")]
        AreaBibitanNursery = 19,
        [XafDisplayName("AreaBisaDitanam")]
        AreaBisaDitanam = 20,
        [XafDisplayName("Cadangan")]
        Cadangan = 21,
        [XafDisplayName("Okupasi")]
        Okupasi = 22,
        [XafDisplayName("AreaTidakBisaDitanam")]
        AreaTidakBisaDitanam = 23,
        [XafDisplayName("TanahDesa")]
        TanahDesa = 24,
        [XafDisplayName("Sungai")]
        Sungai = 25,
        [XafDisplayName("AreaPrasarana")]
        AreaPrasarana = 26,
        [XafDisplayName("Emplasmen")]
        Emplasmen = 27,

        [XafDisplayName("Pabrik")]
        Pabrik = 28,
        [XafDisplayName("Jalan")]
        Jalan = 29,
        [XafDisplayName("JalanProduksi")]
        JalanProduksi = 30,
        [XafDisplayName("JalanPoros")]
        JalanPoros = 31,
        [XafDisplayName("Jembatan")]
        Jembatan = 32,
        [XafDisplayName("LainLain")]
        LainLain = 33,
        [XafDisplayName("TanggalTanam")]
        TanggalTanam = 34,
        [XafDisplayName("TahunTanam")]
        TahunTanam = 35,
        [XafDisplayName("TanggalTMTBM")]
        TanggalTMTBM = 36,
        [XafDisplayName("Rawa")]
        Rawa = 37,
        [XafDisplayName("Parit")]
        Parit = 38,
        [XafDisplayName("PokokPerHektar")]
        PokokPerHektar = 39,
        [XafDisplayName("JumlahPokok")]
        JumlahPokok = 40,
        [XafDisplayName("JumlahPokokNonKomersil")]
        JumlahPokokNonKomersil = 41,
        [XafDisplayName("SegmentAccount")]
        SegmentAccount = 42,
        [XafDisplayName("Koordinat")]
        Koordinat = 43,
        [XafDisplayName("JenisPohon")]
        JenisPohon = 44,
        [XafDisplayName("TotalArea")]
        TotalArea = 45,
        [XafDisplayName("KodeKetinggian")]
        KodeKetinggian = 46,
        [XafDisplayName("STATUSKEBUN")]
        STATUSKEBUN = 47,
        [XafDisplayName("Panen")]
        Panen = 48,
        [XafDisplayName("TanggsalMulaiPanen")]
        TanggalMulaiPanen = 49,
        [XafDisplayName("LCSelesaiDikerjakan")]
        LCSelesaiDikerjakan = 50,
        [XafDisplayName("BelumLCC")]
        BelumLCC = 51,
        [XafDisplayName("SudahLCC")]
        SudahLCC = 52
        }
         public enum eEmployeeColumn
        {
        [XafDisplayName("EMPLOYEE ID")]
        EMPLOYEEID = 0,
        [XafDisplayName("EMPLOYEE ID LAMA")]
        EMPLOYEEIDLAMA = 1,
        [XafDisplayName("EMPLOYEE NAME")]
        EMPLOYEENAME = 2,
        [XafDisplayName("DIVISION CODE")]
        DIVISIONCODE = 3,
        [XafDisplayName("DIVISION NAME")]
        DIVISIONNAME = 4,
        [XafDisplayName("DEPARTMENT CODE")]
        DEPARTMENTCODE = 5,
        [XafDisplayName("DEPARTMENT NAME")]
        DEPARTMENTNAME = 6,
        [XafDisplayName("KEMANDORAN")]
        KEMANDORAN = 7,
        [XafDisplayName("JOB TITLE CODE")]
        JOBTITLECODE = 8,
        [XafDisplayName("JOB TITLE NAME")]
        JOBTITLENAME = 9,
        [XafDisplayName("LOCATION ID")]
        LOCATIONID = 10,
        [XafDisplayName("LOCATION NAME")]
        LOCATIONNAME = 11,
        [XafDisplayName("LOCATION PAYROLL")]
        LOCATIONPAYROLL = 12,
        [XafDisplayName("LOCATION PAYROLL NAME")]
        LOCATIONPAYROLLNAME = 13,
        [XafDisplayName("EMPLOYMENT GROUP CODE")]
        EMPLOYMENTGROUPCODE = 14,
        [XafDisplayName("EMPLOYMENT GROUP NAME")]
        EMPLOYMENTGROUPNAME = 15,
        [XafDisplayName("EMPLOYMENT RANK CODE")]
        EMPLOYMENTRANKCODE = 16,
        [XafDisplayName("EMPLOYMENT RANK NAME")]
        EMPLOYMENTRANKNAME = 17,
        [XafDisplayName("GRADE CODE")]
        GRADECODE = 18,
        [XafDisplayName("GRADE NAME")]
        GRADENAME = 19,
        [XafDisplayName("TIPE PEGAWAI")]
        TIPEPEGAWAI = 20,
        [XafDisplayName("TIPE PEGAWAI MILL & PLANTATION")]
        TIPEPEGAWAIMILLPLANTATION = 21,
        [XafDisplayName("KEGIATAN UTAMA")]
        KEGIATANUTAMA = 22,
        [XafDisplayName("KEGIATAN LAIN")]
        KEGIATANLAIN = 23,
        [XafDisplayName("PAYCODE")]
        PAYCODE = 24,
        [XafDisplayName("PAYCODE NAME")]
        PAYCODENAME = 25,
        [XafDisplayName("TGL MASUK")]
        TGLMASUK = 26,
        [XafDisplayName("TGL PENGANGKATAN KHT")]
        TGLPENGANGKATANKHT = 27,
        [XafDisplayName("TGL PENGANGKATAN PB")]
        TGLPENGANGKATANPB = 28,
        [XafDisplayName("BIRTH PLACE")]
        BIRTHPLACE = 29,
        [XafDisplayName("BIRTH DATE")]
        BIRTHDATE = 30,
        [XafDisplayName("GENDER")]
        GENDER = 31,
        [XafDisplayName("AGAMA")]
        AGAMA = 32,
        [XafDisplayName("ID CARD NUMBER")]
        IDCARDNUMBER = 33,
        [XafDisplayName("MARITAL STATUS")]
        MARITALSTATUS = 34,
        [XafDisplayName("ADDRESS (KTP)")]
        ADDRESSKTP = 35,
        [XafDisplayName("PHONE (KTP)")]
        PHONEKTP = 36,
        [XafDisplayName("ADDRESS (DOMISILI)")]
        ADDRESSDOMISILI = 37,
        [XafDisplayName("PHONE (DOMISILI)")]
        PHONEDOMISILI = 38,
        [XafDisplayName("BPJS TK NUMBER")]
        BPJSTKNUMBER = 39,
        [XafDisplayName("NAMA BPJS TK")]
        NAMABPJSTK = 40,
        [XafDisplayName("BPJS KES NUMBER")]
        BPJSKESNUMBER = 41,
        [XafDisplayName("NAMA BPJS KES")]
        NAMABPJSKES = 42,
        [XafDisplayName("ID ABSENSI")]
        IDABSENSI = 43,
        [XafDisplayName("STATUS PAJAK")]
        STATUSPAJAK = 44,
        [XafDisplayName("NPWP")]
        NPWP = 45,
        [XafDisplayName("NOMOR NPWP")]
        NOMORNPWP = 46,
        [XafDisplayName("JENIS PEGAWAI")]
        JENISPEGAWAI = 47,
        [XafDisplayName("NPWP PEMOTONG PAJAK")]
        NPWPPEMOTONGPAJAK = 48,
        [XafDisplayName("TGL TERAKHIR KERJA")]
        TGLTERAKHIRKERJA = 49,
        [XafDisplayName("TGL KELUAR")]
        TGLKELUAR = 50,
        [XafDisplayName("EMPLOYMENT STATUS")]
        EMPLOYMENTSTATUS = 51,
        [XafDisplayName("STATUS NATURA")]
        STATUSNATURA = 52,
        [XafDisplayName("DIREKRUT OLEH")]
        DIREKRUTOLEH = 53

        
    }

    }


