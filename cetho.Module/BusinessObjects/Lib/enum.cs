﻿using System;
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

namespace cetho.Module.BusinessObjects
{
    public enum enumAcctControl
    {
        
        [XafDisplayName("Suppress")]
        Suppress = 0,
        [XafDisplayName("Req.Entry")]
        ReqEntry = 1,
        [XafDisplayName("Opt.Entry")]
        OptEntry = 2,
        [XafDisplayName("Display")]
        Display = 3
    }
    public enum eNumAcctsCtrlIntgration
    {
        [XafDisplayName("Manual creation of cost element")]
        ManualCostElement = 0,
        [XafDisplayName("Automatic Creation of Cost elements")]
        AutomaticCostElement = 1
    }
    public enum eNumPLBS
    {
        [XafDisplayName("Income Statement")]
        ProfitLost = 0,
        [XafDisplayName("Balance Sheet")]
        BalanceSheet = 1
    }
    public enum eNumDebtCredit
    {
        [XafDisplayName("Debit")]
        Debit = 0,
        [XafDisplayName("Credit")]
        Credit = 1
    }
    public enum eNumAccountType
    {

        [XafDisplayName("Customer")]
        Customer = 0,
        [XafDisplayName("Vendor")]
        Vendor = 1,
        [XafDisplayName("G/L Account")]
        GLAccount = 2,
        [XafDisplayName("Assets")]
        Assets = 3,
        [XafDisplayName("Material")]
        Material = 4

    }

    public enum enumDelivBlock
    {

    }

    public enum enumBilllBlock
    {

    }

    public enum enumOrderReason
    {

    }

    public enum enumForeground
    {

    }

    public enum enumBillBlock
    {

    }

    public enum enumCustGrp
    {

    }

    public enum enumPricDate
    {

    }

    public enum enumPriceGrp
    {

    }

    public enum enumPriceList
    {

    }

    public enum enumUsage
    {

    }

    public enum enumReasonReject
    {

    }

    public enum enumTitle
    {

    }

    public enum enumIncoterms
    {

    }

    public enum enumLang
    {

    }

    public enum enumDocType
    {

    }

    public enum enumDC
    {

    }

    public enum enumDeleteDB
    {

    }

    public enum enumTextDetPrc
    {

    }

    public enum enumDelCompl
    {

    }

    public enum enumStockType
    {

    }

    public enum enumTransaction
    {

    }

    public enum enumPmntBlock
    {

    }

    public enum enumStatus
    {

    }

    public enum enumClassGrp
    {

    }
    public enum enumAccAssCat
    {
        
    }
    public enum enumDistrib
    {

    }

    public enum enumPartialInv
    {

    }

    public enum enumQACtrlKey
    {

    }

    public enum enumIndustrySector
    {

    }

    public enum enumMaterialType
    {

    }
}
