using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class AccFundAccs
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accFundAccsID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accFundID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _cashCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cashAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cashAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cashAccCurrencyAccCurrencyName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cashAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cashAccDestCompanyTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cashAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cashAccSubTypeAccSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cashAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cashCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cashCoaControlAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cashCoaControlAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cashCoaControlAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cashCoaControlCompTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cashCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cashCoaMainAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cashCoaMainAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cashCoaMainAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cashCoaMainAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cashCoaMainCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cashCoaSubAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cashCoaSubAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cashCoaSubAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cashCoaSubAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cashCoaSubAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cashCoaSubCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cashCoaSubCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _bankCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankAccCurrencyAccCurrencyName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankAccDestCompanyTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankAccSubTypeAccSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankCoaControlAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankCoaControlAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankCoaControlAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankCoaControlCompTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankCoaMainAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankCoaMainAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankCoaMainAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankCoaMainAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankCoaMainCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankCoaSubAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankCoaSubAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankCoaSubAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankCoaSubAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankCoaSubAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankCoaSubCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankCoaSubCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _advance;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advanceAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advanceAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advanceAccCurrencyAccCurrencyName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advanceAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advanceAccDestCompanyTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advanceAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advanceAccSubTypeAccSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advanceAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advanceCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advanceCoaControlAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advanceCoaControlAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advanceCoaControlAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advanceCoaControlCompTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advanceCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advanceCoaMainAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advanceCoaMainAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advanceCoaMainAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advanceCoaMainAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advanceCoaMainCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advanceCoaSubAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advanceCoaSubAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advanceCoaSubAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advanceCoaSubAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advanceCoaSubAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advanceCoaSubCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advanceCoaSubCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _purAcc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _purAccAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _purAccAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _purAccAccCurrencyAccCurrencyName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _purAccAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _purAccAccDestCompanyTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _purAccAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _purAccAccSubTypeAccSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _purAccAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _purAccCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _purAccCoaControlAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _purAccCoaControlAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _purAccCoaControlAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _purAccCoaControlCompTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _purAccCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _purAccCoaMainAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _purAccCoaMainAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _purAccCoaMainAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _purAccCoaMainAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _purAccCoaMainCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _purAccCoaSubAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _purAccCoaSubAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _purAccCoaSubAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _purAccCoaSubAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _purAccCoaSubAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _purAccCoaSubCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _purAccCoaSubCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _saleAcc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _saleAccAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _saleAccAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _saleAccAccCurrencyAccCurrencyName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _saleAccAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _saleAccAccDestCompanyTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _saleAccAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _saleAccAccSubTypeAccSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _saleAccAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _saleAccCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _saleAccCoaControlAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _saleAccCoaControlAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _saleAccCoaControlAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _saleAccCoaControlCompTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _saleAccCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _saleAccCoaMainAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _saleAccCoaMainAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _saleAccCoaMainAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _saleAccCoaMainAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _saleAccCoaMainCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _saleAccCoaSubAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _saleAccCoaSubAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _saleAccCoaSubAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _saleAccCoaSubAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _saleAccCoaSubAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _saleAccCoaSubCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _saleAccCoaSubCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _workinProgressAcc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _workinProgressAccAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _workinProgressAccAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _workinProgressAccAccCurrencyAccCurrencyName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _workinProgressAccAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _workinProgressAccAccDestCompanyTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _workinProgressAccAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _workinProgressAccAccSubTypeAccSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _workinProgressAccAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _workinProgressAccCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _workinProgressAccCoaControlAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _workinProgressAccCoaControlAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _workinProgressAccCoaControlAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _workinProgressAccCoaControlCompTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _workinProgressAccCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _workinProgressAccCoaMainAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _workinProgressAccCoaMainAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _workinProgressAccCoaMainAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _workinProgressAccCoaMainAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _workinProgressAccCoaMainCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _workinProgressAccCoaSubAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _workinProgressAccCoaSubAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _workinProgressAccCoaSubAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _workinProgressAccCoaSubAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _workinProgressAccCoaSubAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _workinProgressAccCoaSubCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _workinProgressAccCoaSubCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _costofSold;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _costofSoldAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _costofSoldAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _costofSoldAccCurrencyAccCurrencyName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _costofSoldAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _costofSoldAccDestCompanyTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _costofSoldAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _costofSoldAccSubTypeAccSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _costofSoldAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _costofSoldCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _costofSoldCoaControlAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _costofSoldCoaControlAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _costofSoldCoaControlAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _costofSoldCoaControlCompTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _costofSoldCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _costofSoldCoaMainAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _costofSoldCoaMainAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _costofSoldCoaMainAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _costofSoldCoaMainAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _costofSoldCoaMainCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _costofSoldCoaSubAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _costofSoldCoaSubAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _costofSoldCoaSubAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _costofSoldCoaSubAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _costofSoldCoaSubAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _costofSoldCoaSubCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _costofSoldCoaSubCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _oPD_Acc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _oPD_AccAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _oPD_AccAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _oPD_AccAccCurrencyAccCurrencyName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _oPD_AccAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _oPD_AccAccDestCompanyTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _oPD_AccAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _oPD_AccAccSubTypeAccSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _oPD_AccAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _oPD_AccCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _oPD_AccCoaControlAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _oPD_AccCoaControlAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _oPD_AccCoaControlAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _oPD_AccCoaControlCompTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _oPD_AccCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _oPD_AccCoaMainAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _oPD_AccCoaMainAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _oPD_AccCoaMainAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _oPD_AccCoaMainAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _oPD_AccCoaMainCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _oPD_AccCoaSubAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _oPD_AccCoaSubAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _oPD_AccCoaSubAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _oPD_AccCoaSubAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _oPD_AccCoaSubAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _oPD_AccCoaSubCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _oPD_AccCoaSubCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _advPat_Acc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advPat_AccAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advPat_AccAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advPat_AccAccCurrencyAccCurrencyName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advPat_AccAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advPat_AccAccDestCompanyTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advPat_AccAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advPat_AccAccSubTypeAccSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advPat_AccAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advPat_AccCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advPat_AccCoaControlAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advPat_AccCoaControlAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advPat_AccCoaControlAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advPat_AccCoaControlCompTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advPat_AccCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advPat_AccCoaMainAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advPat_AccCoaMainAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advPat_AccCoaMainAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advPat_AccCoaMainAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advPat_AccCoaMainCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advPat_AccCoaSubAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advPat_AccCoaSubAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advPat_AccCoaSubAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advPat_AccCoaSubAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advPat_AccCoaSubAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advPat_AccCoaSubCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advPat_AccCoaSubCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _investigate_Acc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _investigate_AccAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _investigate_AccAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _investigate_AccAccCurrencyAccCurrencyName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _investigate_AccAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _investigate_AccAccDestCompanyTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _investigate_AccAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _investigate_AccAccSubTypeAccSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _investigate_AccAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _investigate_AccCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _investigate_AccCoaControlAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _investigate_AccCoaControlAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _investigate_AccCoaControlAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _investigate_AccCoaControlCompTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _investigate_AccCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _investigate_AccCoaMainAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _investigate_AccCoaMainAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _investigate_AccCoaMainAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _investigate_AccCoaMainAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _investigate_AccCoaMainCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _investigate_AccCoaSubAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _investigate_AccCoaSubAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _investigate_AccCoaSubAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _investigate_AccCoaSubAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _investigate_AccCoaSubAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _investigate_AccCoaSubCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _investigate_AccCoaSubCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _vatAcc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _vatAccAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _vatAccAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _vatAccAccCurrencyAccCurrencyName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _vatAccAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _vatAccAccDestCompanyTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _vatAccAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _vatAccAccSubTypeAccSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _vatAccAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _vatAccCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _vatAccCoaControlAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _vatAccCoaControlAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _vatAccCoaControlAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _vatAccCoaControlCompTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _vatAccCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _vatAccCoaMainAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _vatAccCoaMainAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _vatAccCoaMainAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _vatAccCoaMainAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _vatAccCoaMainCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _vatAccCoaSubAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _vatAccCoaSubAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _vatAccCoaSubAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _vatAccCoaSubAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _vatAccCoaSubAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _vatAccCoaSubCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _vatAccCoaSubCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _sundryDebitors;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryDebitorsAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryDebitorsAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryDebitorsAccCurrencyAccCurrencyName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryDebitorsAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryDebitorsAccDestCompanyTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryDebitorsAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryDebitorsAccSubTypeAccSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryDebitorsAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryDebitorsCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryDebitorsCoaControlAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryDebitorsCoaControlAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryDebitorsCoaControlAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryDebitorsCoaControlCompTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryDebitorsCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryDebitorsCoaMainAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryDebitorsCoaMainAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryDebitorsCoaMainAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryDebitorsCoaMainAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryDebitorsCoaMainCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryDebitorsCoaSubAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryDebitorsCoaSubAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryDebitorsCoaSubAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryDebitorsCoaSubAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryDebitorsCoaSubAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryDebitorsCoaSubCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryDebitorsCoaSubCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _sundryCreditors;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryCreditorsAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryCreditorsAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryCreditorsAccCurrencyAccCurrencyName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryCreditorsAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryCreditorsAccDestCompanyTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryCreditorsAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryCreditorsAccSubTypeAccSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryCreditorsAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryCreditorsCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryCreditorsCoaControlAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryCreditorsCoaControlAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryCreditorsCoaControlAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryCreditorsCoaControlCompTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryCreditorsCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryCreditorsCoaMainAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryCreditorsCoaMainAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryCreditorsCoaMainAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryCreditorsCoaMainAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryCreditorsCoaMainCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryCreditorsCoaSubAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryCreditorsCoaSubAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryCreditorsCoaSubAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryCreditorsCoaSubAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryCreditorsCoaSubAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryCreditorsCoaSubCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sundryCreditorsCoaSubCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _rawMatAcc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rawMatAccAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rawMatAccAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rawMatAccAccCurrencyAccCurrencyName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rawMatAccAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rawMatAccAccDestCompanyTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rawMatAccAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rawMatAccAccSubTypeAccSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rawMatAccAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rawMatAccCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rawMatAccCoaControlAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rawMatAccCoaControlAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rawMatAccCoaControlAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rawMatAccCoaControlCompTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rawMatAccCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rawMatAccCoaMainAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rawMatAccCoaMainAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rawMatAccCoaMainAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rawMatAccCoaMainAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rawMatAccCoaMainCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rawMatAccCoaSubAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rawMatAccCoaSubAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rawMatAccCoaSubAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rawMatAccCoaSubAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rawMatAccCoaSubAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rawMatAccCoaSubCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rawMatAccCoaSubCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _packMatAcc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _packMatAccAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _packMatAccAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _packMatAccAccCurrencyAccCurrencyName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _packMatAccAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _packMatAccAccDestCompanyTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _packMatAccAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _packMatAccAccSubTypeAccSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _packMatAccAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _packMatAccCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _packMatAccCoaControlAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _packMatAccCoaControlAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _packMatAccCoaControlAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _packMatAccCoaControlCompTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _packMatAccCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _packMatAccCoaMainAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _packMatAccCoaMainAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _packMatAccCoaMainAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _packMatAccCoaMainAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _packMatAccCoaMainCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _packMatAccCoaSubAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _packMatAccCoaSubAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _packMatAccCoaSubAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _packMatAccCoaSubAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _packMatAccCoaSubAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _packMatAccCoaSubCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _packMatAccCoaSubCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _otherMatAcc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _otherMatAccAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _otherMatAccAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _otherMatAccAccCurrencyAccCurrencyName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _otherMatAccAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _otherMatAccAccDestCompanyTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _otherMatAccAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _otherMatAccAccSubTypeAccSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _otherMatAccAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _otherMatAccCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _otherMatAccCoaControlAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _otherMatAccCoaControlAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _otherMatAccCoaControlAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _otherMatAccCoaControlCompTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _otherMatAccCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _otherMatAccCoaMainAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _otherMatAccCoaMainAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _otherMatAccCoaMainAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _otherMatAccCoaMainAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _otherMatAccCoaMainCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _otherMatAccCoaSubAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _otherMatAccCoaSubAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _otherMatAccCoaSubAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _otherMatAccCoaSubAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _otherMatAccCoaSubAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _otherMatAccCoaSubCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _otherMatAccCoaSubCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _finishMatAcc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _finishMatAccAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _finishMatAccAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _finishMatAccAccCurrencyAccCurrencyName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _finishMatAccAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _finishMatAccAccDestCompanyTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _finishMatAccAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _finishMatAccAccSubTypeAccSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _finishMatAccAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _finishMatAccCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _finishMatAccCoaControlAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _finishMatAccCoaControlAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _finishMatAccCoaControlAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _finishMatAccCoaControlCompTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _finishMatAccCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _finishMatAccCoaMainAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _finishMatAccCoaMainAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _finishMatAccCoaMainAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _finishMatAccCoaMainAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _finishMatAccCoaMainCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _finishMatAccCoaSubAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _finishMatAccCoaSubAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _finishMatAccCoaSubAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _finishMatAccCoaSubAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _finishMatAccCoaSubAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _finishMatAccCoaSubCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _finishMatAccCoaSubCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _adminExpAcc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _adminExpAccAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _adminExpAccAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _adminExpAccAccCurrencyAccCurrencyName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _adminExpAccAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _adminExpAccAccDestCompanyTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _adminExpAccAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _adminExpAccAccSubTypeAccSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _adminExpAccAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _adminExpAccCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _adminExpAccCoaControlAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _adminExpAccCoaControlAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _adminExpAccCoaControlAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _adminExpAccCoaControlCompTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _adminExpAccCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _adminExpAccCoaMainAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _adminExpAccCoaMainAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _adminExpAccCoaMainAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _adminExpAccCoaMainAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _adminExpAccCoaMainCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _adminExpAccCoaSubAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _adminExpAccCoaSubAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _adminExpAccCoaSubAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _adminExpAccCoaSubAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _adminExpAccCoaSubAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _adminExpAccCoaSubCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _adminExpAccCoaSubCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _sellingExpAcc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sellingExpAccAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sellingExpAccAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sellingExpAccAccCurrencyAccCurrencyName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sellingExpAccAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sellingExpAccAccDestCompanyTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sellingExpAccAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sellingExpAccAccSubTypeAccSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sellingExpAccAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sellingExpAccCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sellingExpAccCoaControlAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sellingExpAccCoaControlAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sellingExpAccCoaControlAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sellingExpAccCoaControlCompTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sellingExpAccCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sellingExpAccCoaMainAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sellingExpAccCoaMainAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sellingExpAccCoaMainAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sellingExpAccCoaMainAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sellingExpAccCoaMainCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sellingExpAccCoaSubAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sellingExpAccCoaSubAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sellingExpAccCoaSubAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sellingExpAccCoaSubAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sellingExpAccCoaSubAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sellingExpAccCoaSubCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sellingExpAccCoaSubCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _manuExpAcc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _manuExpAccAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _manuExpAccAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _manuExpAccAccCurrencyAccCurrencyName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _manuExpAccAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _manuExpAccAccDestCompanyTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _manuExpAccAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _manuExpAccAccSubTypeAccSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _manuExpAccAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _manuExpAccCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _manuExpAccCoaControlAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _manuExpAccCoaControlAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _manuExpAccCoaControlAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _manuExpAccCoaControlCompTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _manuExpAccCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _manuExpAccCoaMainAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _manuExpAccCoaMainAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _manuExpAccCoaMainAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _manuExpAccCoaMainAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _manuExpAccCoaMainCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _manuExpAccCoaSubAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _manuExpAccCoaSubAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _manuExpAccCoaSubAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _manuExpAccCoaSubAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _manuExpAccCoaSubAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _manuExpAccCoaSubCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _manuExpAccCoaSubCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _loanAcc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _loanAccAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _loanAccAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _loanAccAccCurrencyAccCurrencyName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _loanAccAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _loanAccAccDestCompanyTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _loanAccAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _loanAccAccSubTypeAccSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _loanAccAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _loanAccCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _loanAccCoaControlAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _loanAccCoaControlAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _loanAccCoaControlAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _loanAccCoaControlCompTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _loanAccCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _loanAccCoaMainAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _loanAccCoaMainAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _loanAccCoaMainAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _loanAccCoaMainAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _loanAccCoaMainCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _loanAccCoaSubAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _loanAccCoaSubAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _loanAccCoaSubAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _loanAccCoaSubAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _loanAccCoaSubAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _loanAccCoaSubCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _loanAccCoaSubCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _assetDepAcc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _assetDepAccAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _assetDepAccAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _assetDepAccAccCurrencyAccCurrencyName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _assetDepAccAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _assetDepAccAccDestCompanyTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _assetDepAccAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _assetDepAccAccSubTypeAccSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _assetDepAccAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _assetDepAccCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _assetDepAccCoaControlAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _assetDepAccCoaControlAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _assetDepAccCoaControlAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _assetDepAccCoaControlCompTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _assetDepAccCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _assetDepAccCoaMainAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _assetDepAccCoaMainAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _assetDepAccCoaMainAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _assetDepAccCoaMainAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _assetDepAccCoaMainCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _assetDepAccCoaSubAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _assetDepAccCoaSubAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _assetDepAccCoaSubAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _assetDepAccCoaSubAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _assetDepAccCoaSubAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _assetDepAccCoaSubCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _assetDepAccCoaSubCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _nonOperateIncAcc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateIncAccAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateIncAccAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateIncAccAccCurrencyAccCurrencyName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateIncAccAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateIncAccAccDestCompanyTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateIncAccAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateIncAccAccSubTypeAccSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateIncAccAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateIncAccCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateIncAccCoaControlAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateIncAccCoaControlAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateIncAccCoaControlAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateIncAccCoaControlCompTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateIncAccCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateIncAccCoaMainAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateIncAccCoaMainAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateIncAccCoaMainAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateIncAccCoaMainAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateIncAccCoaMainCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateIncAccCoaSubAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateIncAccCoaSubAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateIncAccCoaSubAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateIncAccCoaSubAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateIncAccCoaSubAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateIncAccCoaSubCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateIncAccCoaSubCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _nonOperateExpAcc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateExpAccAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateExpAccAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateExpAccAccCurrencyAccCurrencyName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateExpAccAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateExpAccAccDestCompanyTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateExpAccAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateExpAccAccSubTypeAccSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateExpAccAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateExpAccCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateExpAccCoaControlAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateExpAccCoaControlAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateExpAccCoaControlAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateExpAccCoaControlCompTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateExpAccCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateExpAccCoaMainAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateExpAccCoaMainAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateExpAccCoaMainAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateExpAccCoaMainAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateExpAccCoaMainCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateExpAccCoaSubAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateExpAccCoaSubAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateExpAccCoaSubAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateExpAccCoaSubAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateExpAccCoaSubAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateExpAccCoaSubCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nonOperateExpAccCoaSubCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _prevYearPLAcc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _prevYearPLAccAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _prevYearPLAccAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _prevYearPLAccAccCurrencyAccCurrencyName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _prevYearPLAccAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _prevYearPLAccAccDestCompanyTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _prevYearPLAccAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _prevYearPLAccAccSubTypeAccSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _prevYearPLAccAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _prevYearPLAccCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _prevYearPLAccCoaControlAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _prevYearPLAccCoaControlAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _prevYearPLAccCoaControlAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _prevYearPLAccCoaControlCompTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _prevYearPLAccCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _prevYearPLAccCoaMainAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _prevYearPLAccCoaMainAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _prevYearPLAccCoaMainAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _prevYearPLAccCoaMainAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _prevYearPLAccCoaMainCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _prevYearPLAccCoaSubAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _prevYearPLAccCoaSubAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _prevYearPLAccCoaSubAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _prevYearPLAccCoaSubAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _prevYearPLAccCoaSubAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _prevYearPLAccCoaSubCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _prevYearPLAccCoaSubCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _currYearPLAcc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _currYearPLAccAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _currYearPLAccAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _currYearPLAccAccCurrencyAccCurrencyName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _currYearPLAccAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _currYearPLAccAccDestCompanyTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _currYearPLAccAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _currYearPLAccAccSubTypeAccSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _currYearPLAccAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _currYearPLAccCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _currYearPLAccCoaControlAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _currYearPLAccCoaControlAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _currYearPLAccCoaControlAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _currYearPLAccCoaControlCompTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _currYearPLAccCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _currYearPLAccCoaMainAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _currYearPLAccCoaMainAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _currYearPLAccCoaMainAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _currYearPLAccCoaMainAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _currYearPLAccCoaMainCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _currYearPLAccCoaSubAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _currYearPLAccCoaSubAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _currYearPLAccCoaSubAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _currYearPLAccCoaSubAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _currYearPLAccCoaSubAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _currYearPLAccCoaSubCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _currYearPLAccCoaSubCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _chequeCCAcc;
        
        public AccFundAccs()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? AccFundAccsID
        {
            get
            {
                return _accFundAccsID;
            }
            set
            {
                _accFundAccsID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public int? AccFundID
        {
            get
            {
                return _accFundID;
            }
            set
            {
                _accFundID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccFundAccFundCode
        {
            get
            {
                return _accFundAccFundCode;
            }
            set
            {
                _accFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? CashCode
        {
            get
            {
                return _cashCode;
            }
            set
            {
                _cashCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CashAccName
        {
            get
            {
                return _cashAccName;
            }
            set
            {
                _cashAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CashAccBalTypeAccBalType
        {
            get
            {
                return _cashAccBalTypeAccBalType;
            }
            set
            {
                _cashAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CashAccCurrencyAccCurrencyName
        {
            get
            {
                return _cashAccCurrencyAccCurrencyName;
            }
            set
            {
                _cashAccCurrencyAccCurrencyName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CashAccDestAccDest
        {
            get
            {
                return _cashAccDestAccDest;
            }
            set
            {
                _cashAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CashAccDestCompanyTypeDescription
        {
            get
            {
                return _cashAccDestCompanyTypeDescription;
            }
            set
            {
                _cashAccDestCompanyTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CashAccFundAccFundCode
        {
            get
            {
                return _cashAccFundAccFundCode;
            }
            set
            {
                _cashAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CashAccSubTypeAccSubType
        {
            get
            {
                return _cashAccSubTypeAccSubType;
            }
            set
            {
                _cashAccSubTypeAccSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CashAccTypeAccType
        {
            get
            {
                return _cashAccTypeAccType;
            }
            set
            {
                _cashAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CashCoaControlAccName
        {
            get
            {
                return _cashCoaControlAccName;
            }
            set
            {
                _cashCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CashCoaControlAccBalTypeAccBalType
        {
            get
            {
                return _cashCoaControlAccBalTypeAccBalType;
            }
            set
            {
                _cashCoaControlAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CashCoaControlAccDestAccDest
        {
            get
            {
                return _cashCoaControlAccDestAccDest;
            }
            set
            {
                _cashCoaControlAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CashCoaControlAccTypeAccType
        {
            get
            {
                return _cashCoaControlAccTypeAccType;
            }
            set
            {
                _cashCoaControlAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CashCoaControlCompTypeDescription
        {
            get
            {
                return _cashCoaControlCompTypeDescription;
            }
            set
            {
                _cashCoaControlCompTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CashCoaMainAccName
        {
            get
            {
                return _cashCoaMainAccName;
            }
            set
            {
                _cashCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CashCoaMainAccBalTypeAccBalType
        {
            get
            {
                return _cashCoaMainAccBalTypeAccBalType;
            }
            set
            {
                _cashCoaMainAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CashCoaMainAccDestAccDest
        {
            get
            {
                return _cashCoaMainAccDestAccDest;
            }
            set
            {
                _cashCoaMainAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CashCoaMainAccFundAccFundCode
        {
            get
            {
                return _cashCoaMainAccFundAccFundCode;
            }
            set
            {
                _cashCoaMainAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CashCoaMainAccTypeAccType
        {
            get
            {
                return _cashCoaMainAccTypeAccType;
            }
            set
            {
                _cashCoaMainAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CashCoaMainCoaControlAccName
        {
            get
            {
                return _cashCoaMainCoaControlAccName;
            }
            set
            {
                _cashCoaMainCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CashCoaSubAccName
        {
            get
            {
                return _cashCoaSubAccName;
            }
            set
            {
                _cashCoaSubAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CashCoaSubAccBalTypeAccBalType
        {
            get
            {
                return _cashCoaSubAccBalTypeAccBalType;
            }
            set
            {
                _cashCoaSubAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CashCoaSubAccDestAccDest
        {
            get
            {
                return _cashCoaSubAccDestAccDest;
            }
            set
            {
                _cashCoaSubAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CashCoaSubAccFundAccFundCode
        {
            get
            {
                return _cashCoaSubAccFundAccFundCode;
            }
            set
            {
                _cashCoaSubAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CashCoaSubAccTypeAccType
        {
            get
            {
                return _cashCoaSubAccTypeAccType;
            }
            set
            {
                _cashCoaSubAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CashCoaSubCoaControlAccName
        {
            get
            {
                return _cashCoaSubCoaControlAccName;
            }
            set
            {
                _cashCoaSubCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CashCoaSubCoaMainAccName
        {
            get
            {
                return _cashCoaSubCoaMainAccName;
            }
            set
            {
                _cashCoaSubCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? BankCode
        {
            get
            {
                return _bankCode;
            }
            set
            {
                _bankCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankAccName
        {
            get
            {
                return _bankAccName;
            }
            set
            {
                _bankAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankAccBalTypeAccBalType
        {
            get
            {
                return _bankAccBalTypeAccBalType;
            }
            set
            {
                _bankAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankAccCurrencyAccCurrencyName
        {
            get
            {
                return _bankAccCurrencyAccCurrencyName;
            }
            set
            {
                _bankAccCurrencyAccCurrencyName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankAccDestAccDest
        {
            get
            {
                return _bankAccDestAccDest;
            }
            set
            {
                _bankAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankAccDestCompanyTypeDescription
        {
            get
            {
                return _bankAccDestCompanyTypeDescription;
            }
            set
            {
                _bankAccDestCompanyTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankAccFundAccFundCode
        {
            get
            {
                return _bankAccFundAccFundCode;
            }
            set
            {
                _bankAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankAccSubTypeAccSubType
        {
            get
            {
                return _bankAccSubTypeAccSubType;
            }
            set
            {
                _bankAccSubTypeAccSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankAccTypeAccType
        {
            get
            {
                return _bankAccTypeAccType;
            }
            set
            {
                _bankAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankCoaControlAccName
        {
            get
            {
                return _bankCoaControlAccName;
            }
            set
            {
                _bankCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankCoaControlAccBalTypeAccBalType
        {
            get
            {
                return _bankCoaControlAccBalTypeAccBalType;
            }
            set
            {
                _bankCoaControlAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankCoaControlAccDestAccDest
        {
            get
            {
                return _bankCoaControlAccDestAccDest;
            }
            set
            {
                _bankCoaControlAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankCoaControlAccTypeAccType
        {
            get
            {
                return _bankCoaControlAccTypeAccType;
            }
            set
            {
                _bankCoaControlAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankCoaControlCompTypeDescription
        {
            get
            {
                return _bankCoaControlCompTypeDescription;
            }
            set
            {
                _bankCoaControlCompTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankCoaMainAccName
        {
            get
            {
                return _bankCoaMainAccName;
            }
            set
            {
                _bankCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankCoaMainAccBalTypeAccBalType
        {
            get
            {
                return _bankCoaMainAccBalTypeAccBalType;
            }
            set
            {
                _bankCoaMainAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankCoaMainAccDestAccDest
        {
            get
            {
                return _bankCoaMainAccDestAccDest;
            }
            set
            {
                _bankCoaMainAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankCoaMainAccFundAccFundCode
        {
            get
            {
                return _bankCoaMainAccFundAccFundCode;
            }
            set
            {
                _bankCoaMainAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankCoaMainAccTypeAccType
        {
            get
            {
                return _bankCoaMainAccTypeAccType;
            }
            set
            {
                _bankCoaMainAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankCoaMainCoaControlAccName
        {
            get
            {
                return _bankCoaMainCoaControlAccName;
            }
            set
            {
                _bankCoaMainCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankCoaSubAccName
        {
            get
            {
                return _bankCoaSubAccName;
            }
            set
            {
                _bankCoaSubAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankCoaSubAccBalTypeAccBalType
        {
            get
            {
                return _bankCoaSubAccBalTypeAccBalType;
            }
            set
            {
                _bankCoaSubAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankCoaSubAccDestAccDest
        {
            get
            {
                return _bankCoaSubAccDestAccDest;
            }
            set
            {
                _bankCoaSubAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankCoaSubAccFundAccFundCode
        {
            get
            {
                return _bankCoaSubAccFundAccFundCode;
            }
            set
            {
                _bankCoaSubAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankCoaSubAccTypeAccType
        {
            get
            {
                return _bankCoaSubAccTypeAccType;
            }
            set
            {
                _bankCoaSubAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankCoaSubCoaControlAccName
        {
            get
            {
                return _bankCoaSubCoaControlAccName;
            }
            set
            {
                _bankCoaSubCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankCoaSubCoaMainAccName
        {
            get
            {
                return _bankCoaSubCoaMainAccName;
            }
            set
            {
                _bankCoaSubCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? Advance
        {
            get
            {
                return _advance;
            }
            set
            {
                _advance = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvanceAccName
        {
            get
            {
                return _advanceAccName;
            }
            set
            {
                _advanceAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvanceAccBalTypeAccBalType
        {
            get
            {
                return _advanceAccBalTypeAccBalType;
            }
            set
            {
                _advanceAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvanceAccCurrencyAccCurrencyName
        {
            get
            {
                return _advanceAccCurrencyAccCurrencyName;
            }
            set
            {
                _advanceAccCurrencyAccCurrencyName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvanceAccDestAccDest
        {
            get
            {
                return _advanceAccDestAccDest;
            }
            set
            {
                _advanceAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvanceAccDestCompanyTypeDescription
        {
            get
            {
                return _advanceAccDestCompanyTypeDescription;
            }
            set
            {
                _advanceAccDestCompanyTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvanceAccFundAccFundCode
        {
            get
            {
                return _advanceAccFundAccFundCode;
            }
            set
            {
                _advanceAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvanceAccSubTypeAccSubType
        {
            get
            {
                return _advanceAccSubTypeAccSubType;
            }
            set
            {
                _advanceAccSubTypeAccSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvanceAccTypeAccType
        {
            get
            {
                return _advanceAccTypeAccType;
            }
            set
            {
                _advanceAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvanceCoaControlAccName
        {
            get
            {
                return _advanceCoaControlAccName;
            }
            set
            {
                _advanceCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvanceCoaControlAccBalTypeAccBalType
        {
            get
            {
                return _advanceCoaControlAccBalTypeAccBalType;
            }
            set
            {
                _advanceCoaControlAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvanceCoaControlAccDestAccDest
        {
            get
            {
                return _advanceCoaControlAccDestAccDest;
            }
            set
            {
                _advanceCoaControlAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvanceCoaControlAccTypeAccType
        {
            get
            {
                return _advanceCoaControlAccTypeAccType;
            }
            set
            {
                _advanceCoaControlAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvanceCoaControlCompTypeDescription
        {
            get
            {
                return _advanceCoaControlCompTypeDescription;
            }
            set
            {
                _advanceCoaControlCompTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvanceCoaMainAccName
        {
            get
            {
                return _advanceCoaMainAccName;
            }
            set
            {
                _advanceCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvanceCoaMainAccBalTypeAccBalType
        {
            get
            {
                return _advanceCoaMainAccBalTypeAccBalType;
            }
            set
            {
                _advanceCoaMainAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvanceCoaMainAccDestAccDest
        {
            get
            {
                return _advanceCoaMainAccDestAccDest;
            }
            set
            {
                _advanceCoaMainAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvanceCoaMainAccFundAccFundCode
        {
            get
            {
                return _advanceCoaMainAccFundAccFundCode;
            }
            set
            {
                _advanceCoaMainAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvanceCoaMainAccTypeAccType
        {
            get
            {
                return _advanceCoaMainAccTypeAccType;
            }
            set
            {
                _advanceCoaMainAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvanceCoaMainCoaControlAccName
        {
            get
            {
                return _advanceCoaMainCoaControlAccName;
            }
            set
            {
                _advanceCoaMainCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvanceCoaSubAccName
        {
            get
            {
                return _advanceCoaSubAccName;
            }
            set
            {
                _advanceCoaSubAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvanceCoaSubAccBalTypeAccBalType
        {
            get
            {
                return _advanceCoaSubAccBalTypeAccBalType;
            }
            set
            {
                _advanceCoaSubAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvanceCoaSubAccDestAccDest
        {
            get
            {
                return _advanceCoaSubAccDestAccDest;
            }
            set
            {
                _advanceCoaSubAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvanceCoaSubAccFundAccFundCode
        {
            get
            {
                return _advanceCoaSubAccFundAccFundCode;
            }
            set
            {
                _advanceCoaSubAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvanceCoaSubAccTypeAccType
        {
            get
            {
                return _advanceCoaSubAccTypeAccType;
            }
            set
            {
                _advanceCoaSubAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvanceCoaSubCoaControlAccName
        {
            get
            {
                return _advanceCoaSubCoaControlAccName;
            }
            set
            {
                _advanceCoaSubCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvanceCoaSubCoaMainAccName
        {
            get
            {
                return _advanceCoaSubCoaMainAccName;
            }
            set
            {
                _advanceCoaSubCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? PurAcc
        {
            get
            {
                return _purAcc;
            }
            set
            {
                _purAcc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PurAccAccName
        {
            get
            {
                return _purAccAccName;
            }
            set
            {
                _purAccAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PurAccAccBalTypeAccBalType
        {
            get
            {
                return _purAccAccBalTypeAccBalType;
            }
            set
            {
                _purAccAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PurAccAccCurrencyAccCurrencyName
        {
            get
            {
                return _purAccAccCurrencyAccCurrencyName;
            }
            set
            {
                _purAccAccCurrencyAccCurrencyName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PurAccAccDestAccDest
        {
            get
            {
                return _purAccAccDestAccDest;
            }
            set
            {
                _purAccAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PurAccAccDestCompanyTypeDescription
        {
            get
            {
                return _purAccAccDestCompanyTypeDescription;
            }
            set
            {
                _purAccAccDestCompanyTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PurAccAccFundAccFundCode
        {
            get
            {
                return _purAccAccFundAccFundCode;
            }
            set
            {
                _purAccAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PurAccAccSubTypeAccSubType
        {
            get
            {
                return _purAccAccSubTypeAccSubType;
            }
            set
            {
                _purAccAccSubTypeAccSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PurAccAccTypeAccType
        {
            get
            {
                return _purAccAccTypeAccType;
            }
            set
            {
                _purAccAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PurAccCoaControlAccName
        {
            get
            {
                return _purAccCoaControlAccName;
            }
            set
            {
                _purAccCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PurAccCoaControlAccBalTypeAccBalType
        {
            get
            {
                return _purAccCoaControlAccBalTypeAccBalType;
            }
            set
            {
                _purAccCoaControlAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PurAccCoaControlAccDestAccDest
        {
            get
            {
                return _purAccCoaControlAccDestAccDest;
            }
            set
            {
                _purAccCoaControlAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PurAccCoaControlAccTypeAccType
        {
            get
            {
                return _purAccCoaControlAccTypeAccType;
            }
            set
            {
                _purAccCoaControlAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PurAccCoaControlCompTypeDescription
        {
            get
            {
                return _purAccCoaControlCompTypeDescription;
            }
            set
            {
                _purAccCoaControlCompTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PurAccCoaMainAccName
        {
            get
            {
                return _purAccCoaMainAccName;
            }
            set
            {
                _purAccCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PurAccCoaMainAccBalTypeAccBalType
        {
            get
            {
                return _purAccCoaMainAccBalTypeAccBalType;
            }
            set
            {
                _purAccCoaMainAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PurAccCoaMainAccDestAccDest
        {
            get
            {
                return _purAccCoaMainAccDestAccDest;
            }
            set
            {
                _purAccCoaMainAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PurAccCoaMainAccFundAccFundCode
        {
            get
            {
                return _purAccCoaMainAccFundAccFundCode;
            }
            set
            {
                _purAccCoaMainAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PurAccCoaMainAccTypeAccType
        {
            get
            {
                return _purAccCoaMainAccTypeAccType;
            }
            set
            {
                _purAccCoaMainAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PurAccCoaMainCoaControlAccName
        {
            get
            {
                return _purAccCoaMainCoaControlAccName;
            }
            set
            {
                _purAccCoaMainCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PurAccCoaSubAccName
        {
            get
            {
                return _purAccCoaSubAccName;
            }
            set
            {
                _purAccCoaSubAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PurAccCoaSubAccBalTypeAccBalType
        {
            get
            {
                return _purAccCoaSubAccBalTypeAccBalType;
            }
            set
            {
                _purAccCoaSubAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PurAccCoaSubAccDestAccDest
        {
            get
            {
                return _purAccCoaSubAccDestAccDest;
            }
            set
            {
                _purAccCoaSubAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PurAccCoaSubAccFundAccFundCode
        {
            get
            {
                return _purAccCoaSubAccFundAccFundCode;
            }
            set
            {
                _purAccCoaSubAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PurAccCoaSubAccTypeAccType
        {
            get
            {
                return _purAccCoaSubAccTypeAccType;
            }
            set
            {
                _purAccCoaSubAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PurAccCoaSubCoaControlAccName
        {
            get
            {
                return _purAccCoaSubCoaControlAccName;
            }
            set
            {
                _purAccCoaSubCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PurAccCoaSubCoaMainAccName
        {
            get
            {
                return _purAccCoaSubCoaMainAccName;
            }
            set
            {
                _purAccCoaSubCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? SaleAcc
        {
            get
            {
                return _saleAcc;
            }
            set
            {
                _saleAcc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SaleAccAccName
        {
            get
            {
                return _saleAccAccName;
            }
            set
            {
                _saleAccAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SaleAccAccBalTypeAccBalType
        {
            get
            {
                return _saleAccAccBalTypeAccBalType;
            }
            set
            {
                _saleAccAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SaleAccAccCurrencyAccCurrencyName
        {
            get
            {
                return _saleAccAccCurrencyAccCurrencyName;
            }
            set
            {
                _saleAccAccCurrencyAccCurrencyName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SaleAccAccDestAccDest
        {
            get
            {
                return _saleAccAccDestAccDest;
            }
            set
            {
                _saleAccAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SaleAccAccDestCompanyTypeDescription
        {
            get
            {
                return _saleAccAccDestCompanyTypeDescription;
            }
            set
            {
                _saleAccAccDestCompanyTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SaleAccAccFundAccFundCode
        {
            get
            {
                return _saleAccAccFundAccFundCode;
            }
            set
            {
                _saleAccAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SaleAccAccSubTypeAccSubType
        {
            get
            {
                return _saleAccAccSubTypeAccSubType;
            }
            set
            {
                _saleAccAccSubTypeAccSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SaleAccAccTypeAccType
        {
            get
            {
                return _saleAccAccTypeAccType;
            }
            set
            {
                _saleAccAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SaleAccCoaControlAccName
        {
            get
            {
                return _saleAccCoaControlAccName;
            }
            set
            {
                _saleAccCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SaleAccCoaControlAccBalTypeAccBalType
        {
            get
            {
                return _saleAccCoaControlAccBalTypeAccBalType;
            }
            set
            {
                _saleAccCoaControlAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SaleAccCoaControlAccDestAccDest
        {
            get
            {
                return _saleAccCoaControlAccDestAccDest;
            }
            set
            {
                _saleAccCoaControlAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SaleAccCoaControlAccTypeAccType
        {
            get
            {
                return _saleAccCoaControlAccTypeAccType;
            }
            set
            {
                _saleAccCoaControlAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SaleAccCoaControlCompTypeDescription
        {
            get
            {
                return _saleAccCoaControlCompTypeDescription;
            }
            set
            {
                _saleAccCoaControlCompTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SaleAccCoaMainAccName
        {
            get
            {
                return _saleAccCoaMainAccName;
            }
            set
            {
                _saleAccCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SaleAccCoaMainAccBalTypeAccBalType
        {
            get
            {
                return _saleAccCoaMainAccBalTypeAccBalType;
            }
            set
            {
                _saleAccCoaMainAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SaleAccCoaMainAccDestAccDest
        {
            get
            {
                return _saleAccCoaMainAccDestAccDest;
            }
            set
            {
                _saleAccCoaMainAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SaleAccCoaMainAccFundAccFundCode
        {
            get
            {
                return _saleAccCoaMainAccFundAccFundCode;
            }
            set
            {
                _saleAccCoaMainAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SaleAccCoaMainAccTypeAccType
        {
            get
            {
                return _saleAccCoaMainAccTypeAccType;
            }
            set
            {
                _saleAccCoaMainAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SaleAccCoaMainCoaControlAccName
        {
            get
            {
                return _saleAccCoaMainCoaControlAccName;
            }
            set
            {
                _saleAccCoaMainCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SaleAccCoaSubAccName
        {
            get
            {
                return _saleAccCoaSubAccName;
            }
            set
            {
                _saleAccCoaSubAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SaleAccCoaSubAccBalTypeAccBalType
        {
            get
            {
                return _saleAccCoaSubAccBalTypeAccBalType;
            }
            set
            {
                _saleAccCoaSubAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SaleAccCoaSubAccDestAccDest
        {
            get
            {
                return _saleAccCoaSubAccDestAccDest;
            }
            set
            {
                _saleAccCoaSubAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SaleAccCoaSubAccFundAccFundCode
        {
            get
            {
                return _saleAccCoaSubAccFundAccFundCode;
            }
            set
            {
                _saleAccCoaSubAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SaleAccCoaSubAccTypeAccType
        {
            get
            {
                return _saleAccCoaSubAccTypeAccType;
            }
            set
            {
                _saleAccCoaSubAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SaleAccCoaSubCoaControlAccName
        {
            get
            {
                return _saleAccCoaSubCoaControlAccName;
            }
            set
            {
                _saleAccCoaSubCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SaleAccCoaSubCoaMainAccName
        {
            get
            {
                return _saleAccCoaSubCoaMainAccName;
            }
            set
            {
                _saleAccCoaSubCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? WorkinProgressAcc
        {
            get
            {
                return _workinProgressAcc;
            }
            set
            {
                _workinProgressAcc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string WorkinProgressAccAccName
        {
            get
            {
                return _workinProgressAccAccName;
            }
            set
            {
                _workinProgressAccAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string WorkinProgressAccAccBalTypeAccBalType
        {
            get
            {
                return _workinProgressAccAccBalTypeAccBalType;
            }
            set
            {
                _workinProgressAccAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string WorkinProgressAccAccCurrencyAccCurrencyName
        {
            get
            {
                return _workinProgressAccAccCurrencyAccCurrencyName;
            }
            set
            {
                _workinProgressAccAccCurrencyAccCurrencyName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string WorkinProgressAccAccDestAccDest
        {
            get
            {
                return _workinProgressAccAccDestAccDest;
            }
            set
            {
                _workinProgressAccAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string WorkinProgressAccAccDestCompanyTypeDescription
        {
            get
            {
                return _workinProgressAccAccDestCompanyTypeDescription;
            }
            set
            {
                _workinProgressAccAccDestCompanyTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string WorkinProgressAccAccFundAccFundCode
        {
            get
            {
                return _workinProgressAccAccFundAccFundCode;
            }
            set
            {
                _workinProgressAccAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string WorkinProgressAccAccSubTypeAccSubType
        {
            get
            {
                return _workinProgressAccAccSubTypeAccSubType;
            }
            set
            {
                _workinProgressAccAccSubTypeAccSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string WorkinProgressAccAccTypeAccType
        {
            get
            {
                return _workinProgressAccAccTypeAccType;
            }
            set
            {
                _workinProgressAccAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string WorkinProgressAccCoaControlAccName
        {
            get
            {
                return _workinProgressAccCoaControlAccName;
            }
            set
            {
                _workinProgressAccCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string WorkinProgressAccCoaControlAccBalTypeAccBalType
        {
            get
            {
                return _workinProgressAccCoaControlAccBalTypeAccBalType;
            }
            set
            {
                _workinProgressAccCoaControlAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string WorkinProgressAccCoaControlAccDestAccDest
        {
            get
            {
                return _workinProgressAccCoaControlAccDestAccDest;
            }
            set
            {
                _workinProgressAccCoaControlAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string WorkinProgressAccCoaControlAccTypeAccType
        {
            get
            {
                return _workinProgressAccCoaControlAccTypeAccType;
            }
            set
            {
                _workinProgressAccCoaControlAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string WorkinProgressAccCoaControlCompTypeDescription
        {
            get
            {
                return _workinProgressAccCoaControlCompTypeDescription;
            }
            set
            {
                _workinProgressAccCoaControlCompTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string WorkinProgressAccCoaMainAccName
        {
            get
            {
                return _workinProgressAccCoaMainAccName;
            }
            set
            {
                _workinProgressAccCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string WorkinProgressAccCoaMainAccBalTypeAccBalType
        {
            get
            {
                return _workinProgressAccCoaMainAccBalTypeAccBalType;
            }
            set
            {
                _workinProgressAccCoaMainAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string WorkinProgressAccCoaMainAccDestAccDest
        {
            get
            {
                return _workinProgressAccCoaMainAccDestAccDest;
            }
            set
            {
                _workinProgressAccCoaMainAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string WorkinProgressAccCoaMainAccFundAccFundCode
        {
            get
            {
                return _workinProgressAccCoaMainAccFundAccFundCode;
            }
            set
            {
                _workinProgressAccCoaMainAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string WorkinProgressAccCoaMainAccTypeAccType
        {
            get
            {
                return _workinProgressAccCoaMainAccTypeAccType;
            }
            set
            {
                _workinProgressAccCoaMainAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string WorkinProgressAccCoaMainCoaControlAccName
        {
            get
            {
                return _workinProgressAccCoaMainCoaControlAccName;
            }
            set
            {
                _workinProgressAccCoaMainCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string WorkinProgressAccCoaSubAccName
        {
            get
            {
                return _workinProgressAccCoaSubAccName;
            }
            set
            {
                _workinProgressAccCoaSubAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string WorkinProgressAccCoaSubAccBalTypeAccBalType
        {
            get
            {
                return _workinProgressAccCoaSubAccBalTypeAccBalType;
            }
            set
            {
                _workinProgressAccCoaSubAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string WorkinProgressAccCoaSubAccDestAccDest
        {
            get
            {
                return _workinProgressAccCoaSubAccDestAccDest;
            }
            set
            {
                _workinProgressAccCoaSubAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string WorkinProgressAccCoaSubAccFundAccFundCode
        {
            get
            {
                return _workinProgressAccCoaSubAccFundAccFundCode;
            }
            set
            {
                _workinProgressAccCoaSubAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string WorkinProgressAccCoaSubAccTypeAccType
        {
            get
            {
                return _workinProgressAccCoaSubAccTypeAccType;
            }
            set
            {
                _workinProgressAccCoaSubAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string WorkinProgressAccCoaSubCoaControlAccName
        {
            get
            {
                return _workinProgressAccCoaSubCoaControlAccName;
            }
            set
            {
                _workinProgressAccCoaSubCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string WorkinProgressAccCoaSubCoaMainAccName
        {
            get
            {
                return _workinProgressAccCoaSubCoaMainAccName;
            }
            set
            {
                _workinProgressAccCoaSubCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? CostofSold
        {
            get
            {
                return _costofSold;
            }
            set
            {
                _costofSold = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CostofSoldAccName
        {
            get
            {
                return _costofSoldAccName;
            }
            set
            {
                _costofSoldAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CostofSoldAccBalTypeAccBalType
        {
            get
            {
                return _costofSoldAccBalTypeAccBalType;
            }
            set
            {
                _costofSoldAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CostofSoldAccCurrencyAccCurrencyName
        {
            get
            {
                return _costofSoldAccCurrencyAccCurrencyName;
            }
            set
            {
                _costofSoldAccCurrencyAccCurrencyName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CostofSoldAccDestAccDest
        {
            get
            {
                return _costofSoldAccDestAccDest;
            }
            set
            {
                _costofSoldAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CostofSoldAccDestCompanyTypeDescription
        {
            get
            {
                return _costofSoldAccDestCompanyTypeDescription;
            }
            set
            {
                _costofSoldAccDestCompanyTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CostofSoldAccFundAccFundCode
        {
            get
            {
                return _costofSoldAccFundAccFundCode;
            }
            set
            {
                _costofSoldAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CostofSoldAccSubTypeAccSubType
        {
            get
            {
                return _costofSoldAccSubTypeAccSubType;
            }
            set
            {
                _costofSoldAccSubTypeAccSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CostofSoldAccTypeAccType
        {
            get
            {
                return _costofSoldAccTypeAccType;
            }
            set
            {
                _costofSoldAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CostofSoldCoaControlAccName
        {
            get
            {
                return _costofSoldCoaControlAccName;
            }
            set
            {
                _costofSoldCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CostofSoldCoaControlAccBalTypeAccBalType
        {
            get
            {
                return _costofSoldCoaControlAccBalTypeAccBalType;
            }
            set
            {
                _costofSoldCoaControlAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CostofSoldCoaControlAccDestAccDest
        {
            get
            {
                return _costofSoldCoaControlAccDestAccDest;
            }
            set
            {
                _costofSoldCoaControlAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CostofSoldCoaControlAccTypeAccType
        {
            get
            {
                return _costofSoldCoaControlAccTypeAccType;
            }
            set
            {
                _costofSoldCoaControlAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CostofSoldCoaControlCompTypeDescription
        {
            get
            {
                return _costofSoldCoaControlCompTypeDescription;
            }
            set
            {
                _costofSoldCoaControlCompTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CostofSoldCoaMainAccName
        {
            get
            {
                return _costofSoldCoaMainAccName;
            }
            set
            {
                _costofSoldCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CostofSoldCoaMainAccBalTypeAccBalType
        {
            get
            {
                return _costofSoldCoaMainAccBalTypeAccBalType;
            }
            set
            {
                _costofSoldCoaMainAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CostofSoldCoaMainAccDestAccDest
        {
            get
            {
                return _costofSoldCoaMainAccDestAccDest;
            }
            set
            {
                _costofSoldCoaMainAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CostofSoldCoaMainAccFundAccFundCode
        {
            get
            {
                return _costofSoldCoaMainAccFundAccFundCode;
            }
            set
            {
                _costofSoldCoaMainAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CostofSoldCoaMainAccTypeAccType
        {
            get
            {
                return _costofSoldCoaMainAccTypeAccType;
            }
            set
            {
                _costofSoldCoaMainAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CostofSoldCoaMainCoaControlAccName
        {
            get
            {
                return _costofSoldCoaMainCoaControlAccName;
            }
            set
            {
                _costofSoldCoaMainCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CostofSoldCoaSubAccName
        {
            get
            {
                return _costofSoldCoaSubAccName;
            }
            set
            {
                _costofSoldCoaSubAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CostofSoldCoaSubAccBalTypeAccBalType
        {
            get
            {
                return _costofSoldCoaSubAccBalTypeAccBalType;
            }
            set
            {
                _costofSoldCoaSubAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CostofSoldCoaSubAccDestAccDest
        {
            get
            {
                return _costofSoldCoaSubAccDestAccDest;
            }
            set
            {
                _costofSoldCoaSubAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CostofSoldCoaSubAccFundAccFundCode
        {
            get
            {
                return _costofSoldCoaSubAccFundAccFundCode;
            }
            set
            {
                _costofSoldCoaSubAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CostofSoldCoaSubAccTypeAccType
        {
            get
            {
                return _costofSoldCoaSubAccTypeAccType;
            }
            set
            {
                _costofSoldCoaSubAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CostofSoldCoaSubCoaControlAccName
        {
            get
            {
                return _costofSoldCoaSubCoaControlAccName;
            }
            set
            {
                _costofSoldCoaSubCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CostofSoldCoaSubCoaMainAccName
        {
            get
            {
                return _costofSoldCoaSubCoaMainAccName;
            }
            set
            {
                _costofSoldCoaSubCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? OPD_Acc
        {
            get
            {
                return _oPD_Acc;
            }
            set
            {
                _oPD_Acc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OPD_AccAccName
        {
            get
            {
                return _oPD_AccAccName;
            }
            set
            {
                _oPD_AccAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OPD_AccAccBalTypeAccBalType
        {
            get
            {
                return _oPD_AccAccBalTypeAccBalType;
            }
            set
            {
                _oPD_AccAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OPD_AccAccCurrencyAccCurrencyName
        {
            get
            {
                return _oPD_AccAccCurrencyAccCurrencyName;
            }
            set
            {
                _oPD_AccAccCurrencyAccCurrencyName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OPD_AccAccDestAccDest
        {
            get
            {
                return _oPD_AccAccDestAccDest;
            }
            set
            {
                _oPD_AccAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OPD_AccAccDestCompanyTypeDescription
        {
            get
            {
                return _oPD_AccAccDestCompanyTypeDescription;
            }
            set
            {
                _oPD_AccAccDestCompanyTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OPD_AccAccFundAccFundCode
        {
            get
            {
                return _oPD_AccAccFundAccFundCode;
            }
            set
            {
                _oPD_AccAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OPD_AccAccSubTypeAccSubType
        {
            get
            {
                return _oPD_AccAccSubTypeAccSubType;
            }
            set
            {
                _oPD_AccAccSubTypeAccSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OPD_AccAccTypeAccType
        {
            get
            {
                return _oPD_AccAccTypeAccType;
            }
            set
            {
                _oPD_AccAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OPD_AccCoaControlAccName
        {
            get
            {
                return _oPD_AccCoaControlAccName;
            }
            set
            {
                _oPD_AccCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OPD_AccCoaControlAccBalTypeAccBalType
        {
            get
            {
                return _oPD_AccCoaControlAccBalTypeAccBalType;
            }
            set
            {
                _oPD_AccCoaControlAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OPD_AccCoaControlAccDestAccDest
        {
            get
            {
                return _oPD_AccCoaControlAccDestAccDest;
            }
            set
            {
                _oPD_AccCoaControlAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OPD_AccCoaControlAccTypeAccType
        {
            get
            {
                return _oPD_AccCoaControlAccTypeAccType;
            }
            set
            {
                _oPD_AccCoaControlAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OPD_AccCoaControlCompTypeDescription
        {
            get
            {
                return _oPD_AccCoaControlCompTypeDescription;
            }
            set
            {
                _oPD_AccCoaControlCompTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OPD_AccCoaMainAccName
        {
            get
            {
                return _oPD_AccCoaMainAccName;
            }
            set
            {
                _oPD_AccCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OPD_AccCoaMainAccBalTypeAccBalType
        {
            get
            {
                return _oPD_AccCoaMainAccBalTypeAccBalType;
            }
            set
            {
                _oPD_AccCoaMainAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OPD_AccCoaMainAccDestAccDest
        {
            get
            {
                return _oPD_AccCoaMainAccDestAccDest;
            }
            set
            {
                _oPD_AccCoaMainAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OPD_AccCoaMainAccFundAccFundCode
        {
            get
            {
                return _oPD_AccCoaMainAccFundAccFundCode;
            }
            set
            {
                _oPD_AccCoaMainAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OPD_AccCoaMainAccTypeAccType
        {
            get
            {
                return _oPD_AccCoaMainAccTypeAccType;
            }
            set
            {
                _oPD_AccCoaMainAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OPD_AccCoaMainCoaControlAccName
        {
            get
            {
                return _oPD_AccCoaMainCoaControlAccName;
            }
            set
            {
                _oPD_AccCoaMainCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OPD_AccCoaSubAccName
        {
            get
            {
                return _oPD_AccCoaSubAccName;
            }
            set
            {
                _oPD_AccCoaSubAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OPD_AccCoaSubAccBalTypeAccBalType
        {
            get
            {
                return _oPD_AccCoaSubAccBalTypeAccBalType;
            }
            set
            {
                _oPD_AccCoaSubAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OPD_AccCoaSubAccDestAccDest
        {
            get
            {
                return _oPD_AccCoaSubAccDestAccDest;
            }
            set
            {
                _oPD_AccCoaSubAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OPD_AccCoaSubAccFundAccFundCode
        {
            get
            {
                return _oPD_AccCoaSubAccFundAccFundCode;
            }
            set
            {
                _oPD_AccCoaSubAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OPD_AccCoaSubAccTypeAccType
        {
            get
            {
                return _oPD_AccCoaSubAccTypeAccType;
            }
            set
            {
                _oPD_AccCoaSubAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OPD_AccCoaSubCoaControlAccName
        {
            get
            {
                return _oPD_AccCoaSubCoaControlAccName;
            }
            set
            {
                _oPD_AccCoaSubCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OPD_AccCoaSubCoaMainAccName
        {
            get
            {
                return _oPD_AccCoaSubCoaMainAccName;
            }
            set
            {
                _oPD_AccCoaSubCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? AdvPat_Acc
        {
            get
            {
                return _advPat_Acc;
            }
            set
            {
                _advPat_Acc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvPat_AccAccName
        {
            get
            {
                return _advPat_AccAccName;
            }
            set
            {
                _advPat_AccAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvPat_AccAccBalTypeAccBalType
        {
            get
            {
                return _advPat_AccAccBalTypeAccBalType;
            }
            set
            {
                _advPat_AccAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvPat_AccAccCurrencyAccCurrencyName
        {
            get
            {
                return _advPat_AccAccCurrencyAccCurrencyName;
            }
            set
            {
                _advPat_AccAccCurrencyAccCurrencyName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvPat_AccAccDestAccDest
        {
            get
            {
                return _advPat_AccAccDestAccDest;
            }
            set
            {
                _advPat_AccAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvPat_AccAccDestCompanyTypeDescription
        {
            get
            {
                return _advPat_AccAccDestCompanyTypeDescription;
            }
            set
            {
                _advPat_AccAccDestCompanyTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvPat_AccAccFundAccFundCode
        {
            get
            {
                return _advPat_AccAccFundAccFundCode;
            }
            set
            {
                _advPat_AccAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvPat_AccAccSubTypeAccSubType
        {
            get
            {
                return _advPat_AccAccSubTypeAccSubType;
            }
            set
            {
                _advPat_AccAccSubTypeAccSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvPat_AccAccTypeAccType
        {
            get
            {
                return _advPat_AccAccTypeAccType;
            }
            set
            {
                _advPat_AccAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvPat_AccCoaControlAccName
        {
            get
            {
                return _advPat_AccCoaControlAccName;
            }
            set
            {
                _advPat_AccCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvPat_AccCoaControlAccBalTypeAccBalType
        {
            get
            {
                return _advPat_AccCoaControlAccBalTypeAccBalType;
            }
            set
            {
                _advPat_AccCoaControlAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvPat_AccCoaControlAccDestAccDest
        {
            get
            {
                return _advPat_AccCoaControlAccDestAccDest;
            }
            set
            {
                _advPat_AccCoaControlAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvPat_AccCoaControlAccTypeAccType
        {
            get
            {
                return _advPat_AccCoaControlAccTypeAccType;
            }
            set
            {
                _advPat_AccCoaControlAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvPat_AccCoaControlCompTypeDescription
        {
            get
            {
                return _advPat_AccCoaControlCompTypeDescription;
            }
            set
            {
                _advPat_AccCoaControlCompTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvPat_AccCoaMainAccName
        {
            get
            {
                return _advPat_AccCoaMainAccName;
            }
            set
            {
                _advPat_AccCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvPat_AccCoaMainAccBalTypeAccBalType
        {
            get
            {
                return _advPat_AccCoaMainAccBalTypeAccBalType;
            }
            set
            {
                _advPat_AccCoaMainAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvPat_AccCoaMainAccDestAccDest
        {
            get
            {
                return _advPat_AccCoaMainAccDestAccDest;
            }
            set
            {
                _advPat_AccCoaMainAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvPat_AccCoaMainAccFundAccFundCode
        {
            get
            {
                return _advPat_AccCoaMainAccFundAccFundCode;
            }
            set
            {
                _advPat_AccCoaMainAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvPat_AccCoaMainAccTypeAccType
        {
            get
            {
                return _advPat_AccCoaMainAccTypeAccType;
            }
            set
            {
                _advPat_AccCoaMainAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvPat_AccCoaMainCoaControlAccName
        {
            get
            {
                return _advPat_AccCoaMainCoaControlAccName;
            }
            set
            {
                _advPat_AccCoaMainCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvPat_AccCoaSubAccName
        {
            get
            {
                return _advPat_AccCoaSubAccName;
            }
            set
            {
                _advPat_AccCoaSubAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvPat_AccCoaSubAccBalTypeAccBalType
        {
            get
            {
                return _advPat_AccCoaSubAccBalTypeAccBalType;
            }
            set
            {
                _advPat_AccCoaSubAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvPat_AccCoaSubAccDestAccDest
        {
            get
            {
                return _advPat_AccCoaSubAccDestAccDest;
            }
            set
            {
                _advPat_AccCoaSubAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvPat_AccCoaSubAccFundAccFundCode
        {
            get
            {
                return _advPat_AccCoaSubAccFundAccFundCode;
            }
            set
            {
                _advPat_AccCoaSubAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvPat_AccCoaSubAccTypeAccType
        {
            get
            {
                return _advPat_AccCoaSubAccTypeAccType;
            }
            set
            {
                _advPat_AccCoaSubAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvPat_AccCoaSubCoaControlAccName
        {
            get
            {
                return _advPat_AccCoaSubCoaControlAccName;
            }
            set
            {
                _advPat_AccCoaSubCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvPat_AccCoaSubCoaMainAccName
        {
            get
            {
                return _advPat_AccCoaSubCoaMainAccName;
            }
            set
            {
                _advPat_AccCoaSubCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? Investigate_Acc
        {
            get
            {
                return _investigate_Acc;
            }
            set
            {
                _investigate_Acc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Investigate_AccAccName
        {
            get
            {
                return _investigate_AccAccName;
            }
            set
            {
                _investigate_AccAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Investigate_AccAccBalTypeAccBalType
        {
            get
            {
                return _investigate_AccAccBalTypeAccBalType;
            }
            set
            {
                _investigate_AccAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Investigate_AccAccCurrencyAccCurrencyName
        {
            get
            {
                return _investigate_AccAccCurrencyAccCurrencyName;
            }
            set
            {
                _investigate_AccAccCurrencyAccCurrencyName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Investigate_AccAccDestAccDest
        {
            get
            {
                return _investigate_AccAccDestAccDest;
            }
            set
            {
                _investigate_AccAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Investigate_AccAccDestCompanyTypeDescription
        {
            get
            {
                return _investigate_AccAccDestCompanyTypeDescription;
            }
            set
            {
                _investigate_AccAccDestCompanyTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Investigate_AccAccFundAccFundCode
        {
            get
            {
                return _investigate_AccAccFundAccFundCode;
            }
            set
            {
                _investigate_AccAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Investigate_AccAccSubTypeAccSubType
        {
            get
            {
                return _investigate_AccAccSubTypeAccSubType;
            }
            set
            {
                _investigate_AccAccSubTypeAccSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Investigate_AccAccTypeAccType
        {
            get
            {
                return _investigate_AccAccTypeAccType;
            }
            set
            {
                _investigate_AccAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Investigate_AccCoaControlAccName
        {
            get
            {
                return _investigate_AccCoaControlAccName;
            }
            set
            {
                _investigate_AccCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Investigate_AccCoaControlAccBalTypeAccBalType
        {
            get
            {
                return _investigate_AccCoaControlAccBalTypeAccBalType;
            }
            set
            {
                _investigate_AccCoaControlAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Investigate_AccCoaControlAccDestAccDest
        {
            get
            {
                return _investigate_AccCoaControlAccDestAccDest;
            }
            set
            {
                _investigate_AccCoaControlAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Investigate_AccCoaControlAccTypeAccType
        {
            get
            {
                return _investigate_AccCoaControlAccTypeAccType;
            }
            set
            {
                _investigate_AccCoaControlAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Investigate_AccCoaControlCompTypeDescription
        {
            get
            {
                return _investigate_AccCoaControlCompTypeDescription;
            }
            set
            {
                _investigate_AccCoaControlCompTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Investigate_AccCoaMainAccName
        {
            get
            {
                return _investigate_AccCoaMainAccName;
            }
            set
            {
                _investigate_AccCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Investigate_AccCoaMainAccBalTypeAccBalType
        {
            get
            {
                return _investigate_AccCoaMainAccBalTypeAccBalType;
            }
            set
            {
                _investigate_AccCoaMainAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Investigate_AccCoaMainAccDestAccDest
        {
            get
            {
                return _investigate_AccCoaMainAccDestAccDest;
            }
            set
            {
                _investigate_AccCoaMainAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Investigate_AccCoaMainAccFundAccFundCode
        {
            get
            {
                return _investigate_AccCoaMainAccFundAccFundCode;
            }
            set
            {
                _investigate_AccCoaMainAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Investigate_AccCoaMainAccTypeAccType
        {
            get
            {
                return _investigate_AccCoaMainAccTypeAccType;
            }
            set
            {
                _investigate_AccCoaMainAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Investigate_AccCoaMainCoaControlAccName
        {
            get
            {
                return _investigate_AccCoaMainCoaControlAccName;
            }
            set
            {
                _investigate_AccCoaMainCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Investigate_AccCoaSubAccName
        {
            get
            {
                return _investigate_AccCoaSubAccName;
            }
            set
            {
                _investigate_AccCoaSubAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Investigate_AccCoaSubAccBalTypeAccBalType
        {
            get
            {
                return _investigate_AccCoaSubAccBalTypeAccBalType;
            }
            set
            {
                _investigate_AccCoaSubAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Investigate_AccCoaSubAccDestAccDest
        {
            get
            {
                return _investigate_AccCoaSubAccDestAccDest;
            }
            set
            {
                _investigate_AccCoaSubAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Investigate_AccCoaSubAccFundAccFundCode
        {
            get
            {
                return _investigate_AccCoaSubAccFundAccFundCode;
            }
            set
            {
                _investigate_AccCoaSubAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Investigate_AccCoaSubAccTypeAccType
        {
            get
            {
                return _investigate_AccCoaSubAccTypeAccType;
            }
            set
            {
                _investigate_AccCoaSubAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Investigate_AccCoaSubCoaControlAccName
        {
            get
            {
                return _investigate_AccCoaSubCoaControlAccName;
            }
            set
            {
                _investigate_AccCoaSubCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Investigate_AccCoaSubCoaMainAccName
        {
            get
            {
                return _investigate_AccCoaSubCoaMainAccName;
            }
            set
            {
                _investigate_AccCoaSubCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? VatAcc
        {
            get
            {
                return _vatAcc;
            }
            set
            {
                _vatAcc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string VatAccAccName
        {
            get
            {
                return _vatAccAccName;
            }
            set
            {
                _vatAccAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string VatAccAccBalTypeAccBalType
        {
            get
            {
                return _vatAccAccBalTypeAccBalType;
            }
            set
            {
                _vatAccAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string VatAccAccCurrencyAccCurrencyName
        {
            get
            {
                return _vatAccAccCurrencyAccCurrencyName;
            }
            set
            {
                _vatAccAccCurrencyAccCurrencyName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string VatAccAccDestAccDest
        {
            get
            {
                return _vatAccAccDestAccDest;
            }
            set
            {
                _vatAccAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string VatAccAccDestCompanyTypeDescription
        {
            get
            {
                return _vatAccAccDestCompanyTypeDescription;
            }
            set
            {
                _vatAccAccDestCompanyTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string VatAccAccFundAccFundCode
        {
            get
            {
                return _vatAccAccFundAccFundCode;
            }
            set
            {
                _vatAccAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string VatAccAccSubTypeAccSubType
        {
            get
            {
                return _vatAccAccSubTypeAccSubType;
            }
            set
            {
                _vatAccAccSubTypeAccSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string VatAccAccTypeAccType
        {
            get
            {
                return _vatAccAccTypeAccType;
            }
            set
            {
                _vatAccAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string VatAccCoaControlAccName
        {
            get
            {
                return _vatAccCoaControlAccName;
            }
            set
            {
                _vatAccCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string VatAccCoaControlAccBalTypeAccBalType
        {
            get
            {
                return _vatAccCoaControlAccBalTypeAccBalType;
            }
            set
            {
                _vatAccCoaControlAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string VatAccCoaControlAccDestAccDest
        {
            get
            {
                return _vatAccCoaControlAccDestAccDest;
            }
            set
            {
                _vatAccCoaControlAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string VatAccCoaControlAccTypeAccType
        {
            get
            {
                return _vatAccCoaControlAccTypeAccType;
            }
            set
            {
                _vatAccCoaControlAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string VatAccCoaControlCompTypeDescription
        {
            get
            {
                return _vatAccCoaControlCompTypeDescription;
            }
            set
            {
                _vatAccCoaControlCompTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string VatAccCoaMainAccName
        {
            get
            {
                return _vatAccCoaMainAccName;
            }
            set
            {
                _vatAccCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string VatAccCoaMainAccBalTypeAccBalType
        {
            get
            {
                return _vatAccCoaMainAccBalTypeAccBalType;
            }
            set
            {
                _vatAccCoaMainAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string VatAccCoaMainAccDestAccDest
        {
            get
            {
                return _vatAccCoaMainAccDestAccDest;
            }
            set
            {
                _vatAccCoaMainAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string VatAccCoaMainAccFundAccFundCode
        {
            get
            {
                return _vatAccCoaMainAccFundAccFundCode;
            }
            set
            {
                _vatAccCoaMainAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string VatAccCoaMainAccTypeAccType
        {
            get
            {
                return _vatAccCoaMainAccTypeAccType;
            }
            set
            {
                _vatAccCoaMainAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string VatAccCoaMainCoaControlAccName
        {
            get
            {
                return _vatAccCoaMainCoaControlAccName;
            }
            set
            {
                _vatAccCoaMainCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string VatAccCoaSubAccName
        {
            get
            {
                return _vatAccCoaSubAccName;
            }
            set
            {
                _vatAccCoaSubAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string VatAccCoaSubAccBalTypeAccBalType
        {
            get
            {
                return _vatAccCoaSubAccBalTypeAccBalType;
            }
            set
            {
                _vatAccCoaSubAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string VatAccCoaSubAccDestAccDest
        {
            get
            {
                return _vatAccCoaSubAccDestAccDest;
            }
            set
            {
                _vatAccCoaSubAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string VatAccCoaSubAccFundAccFundCode
        {
            get
            {
                return _vatAccCoaSubAccFundAccFundCode;
            }
            set
            {
                _vatAccCoaSubAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string VatAccCoaSubAccTypeAccType
        {
            get
            {
                return _vatAccCoaSubAccTypeAccType;
            }
            set
            {
                _vatAccCoaSubAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string VatAccCoaSubCoaControlAccName
        {
            get
            {
                return _vatAccCoaSubCoaControlAccName;
            }
            set
            {
                _vatAccCoaSubCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string VatAccCoaSubCoaMainAccName
        {
            get
            {
                return _vatAccCoaSubCoaMainAccName;
            }
            set
            {
                _vatAccCoaSubCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? SundryDebitors
        {
            get
            {
                return _sundryDebitors;
            }
            set
            {
                _sundryDebitors = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryDebitorsAccName
        {
            get
            {
                return _sundryDebitorsAccName;
            }
            set
            {
                _sundryDebitorsAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryDebitorsAccBalTypeAccBalType
        {
            get
            {
                return _sundryDebitorsAccBalTypeAccBalType;
            }
            set
            {
                _sundryDebitorsAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryDebitorsAccCurrencyAccCurrencyName
        {
            get
            {
                return _sundryDebitorsAccCurrencyAccCurrencyName;
            }
            set
            {
                _sundryDebitorsAccCurrencyAccCurrencyName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryDebitorsAccDestAccDest
        {
            get
            {
                return _sundryDebitorsAccDestAccDest;
            }
            set
            {
                _sundryDebitorsAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryDebitorsAccDestCompanyTypeDescription
        {
            get
            {
                return _sundryDebitorsAccDestCompanyTypeDescription;
            }
            set
            {
                _sundryDebitorsAccDestCompanyTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryDebitorsAccFundAccFundCode
        {
            get
            {
                return _sundryDebitorsAccFundAccFundCode;
            }
            set
            {
                _sundryDebitorsAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryDebitorsAccSubTypeAccSubType
        {
            get
            {
                return _sundryDebitorsAccSubTypeAccSubType;
            }
            set
            {
                _sundryDebitorsAccSubTypeAccSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryDebitorsAccTypeAccType
        {
            get
            {
                return _sundryDebitorsAccTypeAccType;
            }
            set
            {
                _sundryDebitorsAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryDebitorsCoaControlAccName
        {
            get
            {
                return _sundryDebitorsCoaControlAccName;
            }
            set
            {
                _sundryDebitorsCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryDebitorsCoaControlAccBalTypeAccBalType
        {
            get
            {
                return _sundryDebitorsCoaControlAccBalTypeAccBalType;
            }
            set
            {
                _sundryDebitorsCoaControlAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryDebitorsCoaControlAccDestAccDest
        {
            get
            {
                return _sundryDebitorsCoaControlAccDestAccDest;
            }
            set
            {
                _sundryDebitorsCoaControlAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryDebitorsCoaControlAccTypeAccType
        {
            get
            {
                return _sundryDebitorsCoaControlAccTypeAccType;
            }
            set
            {
                _sundryDebitorsCoaControlAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryDebitorsCoaControlCompTypeDescription
        {
            get
            {
                return _sundryDebitorsCoaControlCompTypeDescription;
            }
            set
            {
                _sundryDebitorsCoaControlCompTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryDebitorsCoaMainAccName
        {
            get
            {
                return _sundryDebitorsCoaMainAccName;
            }
            set
            {
                _sundryDebitorsCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryDebitorsCoaMainAccBalTypeAccBalType
        {
            get
            {
                return _sundryDebitorsCoaMainAccBalTypeAccBalType;
            }
            set
            {
                _sundryDebitorsCoaMainAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryDebitorsCoaMainAccDestAccDest
        {
            get
            {
                return _sundryDebitorsCoaMainAccDestAccDest;
            }
            set
            {
                _sundryDebitorsCoaMainAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryDebitorsCoaMainAccFundAccFundCode
        {
            get
            {
                return _sundryDebitorsCoaMainAccFundAccFundCode;
            }
            set
            {
                _sundryDebitorsCoaMainAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryDebitorsCoaMainAccTypeAccType
        {
            get
            {
                return _sundryDebitorsCoaMainAccTypeAccType;
            }
            set
            {
                _sundryDebitorsCoaMainAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryDebitorsCoaMainCoaControlAccName
        {
            get
            {
                return _sundryDebitorsCoaMainCoaControlAccName;
            }
            set
            {
                _sundryDebitorsCoaMainCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryDebitorsCoaSubAccName
        {
            get
            {
                return _sundryDebitorsCoaSubAccName;
            }
            set
            {
                _sundryDebitorsCoaSubAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryDebitorsCoaSubAccBalTypeAccBalType
        {
            get
            {
                return _sundryDebitorsCoaSubAccBalTypeAccBalType;
            }
            set
            {
                _sundryDebitorsCoaSubAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryDebitorsCoaSubAccDestAccDest
        {
            get
            {
                return _sundryDebitorsCoaSubAccDestAccDest;
            }
            set
            {
                _sundryDebitorsCoaSubAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryDebitorsCoaSubAccFundAccFundCode
        {
            get
            {
                return _sundryDebitorsCoaSubAccFundAccFundCode;
            }
            set
            {
                _sundryDebitorsCoaSubAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryDebitorsCoaSubAccTypeAccType
        {
            get
            {
                return _sundryDebitorsCoaSubAccTypeAccType;
            }
            set
            {
                _sundryDebitorsCoaSubAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryDebitorsCoaSubCoaControlAccName
        {
            get
            {
                return _sundryDebitorsCoaSubCoaControlAccName;
            }
            set
            {
                _sundryDebitorsCoaSubCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryDebitorsCoaSubCoaMainAccName
        {
            get
            {
                return _sundryDebitorsCoaSubCoaMainAccName;
            }
            set
            {
                _sundryDebitorsCoaSubCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? SundryCreditors
        {
            get
            {
                return _sundryCreditors;
            }
            set
            {
                _sundryCreditors = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryCreditorsAccName
        {
            get
            {
                return _sundryCreditorsAccName;
            }
            set
            {
                _sundryCreditorsAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryCreditorsAccBalTypeAccBalType
        {
            get
            {
                return _sundryCreditorsAccBalTypeAccBalType;
            }
            set
            {
                _sundryCreditorsAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryCreditorsAccCurrencyAccCurrencyName
        {
            get
            {
                return _sundryCreditorsAccCurrencyAccCurrencyName;
            }
            set
            {
                _sundryCreditorsAccCurrencyAccCurrencyName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryCreditorsAccDestAccDest
        {
            get
            {
                return _sundryCreditorsAccDestAccDest;
            }
            set
            {
                _sundryCreditorsAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryCreditorsAccDestCompanyTypeDescription
        {
            get
            {
                return _sundryCreditorsAccDestCompanyTypeDescription;
            }
            set
            {
                _sundryCreditorsAccDestCompanyTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryCreditorsAccFundAccFundCode
        {
            get
            {
                return _sundryCreditorsAccFundAccFundCode;
            }
            set
            {
                _sundryCreditorsAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryCreditorsAccSubTypeAccSubType
        {
            get
            {
                return _sundryCreditorsAccSubTypeAccSubType;
            }
            set
            {
                _sundryCreditorsAccSubTypeAccSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryCreditorsAccTypeAccType
        {
            get
            {
                return _sundryCreditorsAccTypeAccType;
            }
            set
            {
                _sundryCreditorsAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryCreditorsCoaControlAccName
        {
            get
            {
                return _sundryCreditorsCoaControlAccName;
            }
            set
            {
                _sundryCreditorsCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryCreditorsCoaControlAccBalTypeAccBalType
        {
            get
            {
                return _sundryCreditorsCoaControlAccBalTypeAccBalType;
            }
            set
            {
                _sundryCreditorsCoaControlAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryCreditorsCoaControlAccDestAccDest
        {
            get
            {
                return _sundryCreditorsCoaControlAccDestAccDest;
            }
            set
            {
                _sundryCreditorsCoaControlAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryCreditorsCoaControlAccTypeAccType
        {
            get
            {
                return _sundryCreditorsCoaControlAccTypeAccType;
            }
            set
            {
                _sundryCreditorsCoaControlAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryCreditorsCoaControlCompTypeDescription
        {
            get
            {
                return _sundryCreditorsCoaControlCompTypeDescription;
            }
            set
            {
                _sundryCreditorsCoaControlCompTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryCreditorsCoaMainAccName
        {
            get
            {
                return _sundryCreditorsCoaMainAccName;
            }
            set
            {
                _sundryCreditorsCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryCreditorsCoaMainAccBalTypeAccBalType
        {
            get
            {
                return _sundryCreditorsCoaMainAccBalTypeAccBalType;
            }
            set
            {
                _sundryCreditorsCoaMainAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryCreditorsCoaMainAccDestAccDest
        {
            get
            {
                return _sundryCreditorsCoaMainAccDestAccDest;
            }
            set
            {
                _sundryCreditorsCoaMainAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryCreditorsCoaMainAccFundAccFundCode
        {
            get
            {
                return _sundryCreditorsCoaMainAccFundAccFundCode;
            }
            set
            {
                _sundryCreditorsCoaMainAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryCreditorsCoaMainAccTypeAccType
        {
            get
            {
                return _sundryCreditorsCoaMainAccTypeAccType;
            }
            set
            {
                _sundryCreditorsCoaMainAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryCreditorsCoaMainCoaControlAccName
        {
            get
            {
                return _sundryCreditorsCoaMainCoaControlAccName;
            }
            set
            {
                _sundryCreditorsCoaMainCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryCreditorsCoaSubAccName
        {
            get
            {
                return _sundryCreditorsCoaSubAccName;
            }
            set
            {
                _sundryCreditorsCoaSubAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryCreditorsCoaSubAccBalTypeAccBalType
        {
            get
            {
                return _sundryCreditorsCoaSubAccBalTypeAccBalType;
            }
            set
            {
                _sundryCreditorsCoaSubAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryCreditorsCoaSubAccDestAccDest
        {
            get
            {
                return _sundryCreditorsCoaSubAccDestAccDest;
            }
            set
            {
                _sundryCreditorsCoaSubAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryCreditorsCoaSubAccFundAccFundCode
        {
            get
            {
                return _sundryCreditorsCoaSubAccFundAccFundCode;
            }
            set
            {
                _sundryCreditorsCoaSubAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryCreditorsCoaSubAccTypeAccType
        {
            get
            {
                return _sundryCreditorsCoaSubAccTypeAccType;
            }
            set
            {
                _sundryCreditorsCoaSubAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryCreditorsCoaSubCoaControlAccName
        {
            get
            {
                return _sundryCreditorsCoaSubCoaControlAccName;
            }
            set
            {
                _sundryCreditorsCoaSubCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SundryCreditorsCoaSubCoaMainAccName
        {
            get
            {
                return _sundryCreditorsCoaSubCoaMainAccName;
            }
            set
            {
                _sundryCreditorsCoaSubCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? RawMatAcc
        {
            get
            {
                return _rawMatAcc;
            }
            set
            {
                _rawMatAcc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RawMatAccAccName
        {
            get
            {
                return _rawMatAccAccName;
            }
            set
            {
                _rawMatAccAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RawMatAccAccBalTypeAccBalType
        {
            get
            {
                return _rawMatAccAccBalTypeAccBalType;
            }
            set
            {
                _rawMatAccAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RawMatAccAccCurrencyAccCurrencyName
        {
            get
            {
                return _rawMatAccAccCurrencyAccCurrencyName;
            }
            set
            {
                _rawMatAccAccCurrencyAccCurrencyName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RawMatAccAccDestAccDest
        {
            get
            {
                return _rawMatAccAccDestAccDest;
            }
            set
            {
                _rawMatAccAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RawMatAccAccDestCompanyTypeDescription
        {
            get
            {
                return _rawMatAccAccDestCompanyTypeDescription;
            }
            set
            {
                _rawMatAccAccDestCompanyTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RawMatAccAccFundAccFundCode
        {
            get
            {
                return _rawMatAccAccFundAccFundCode;
            }
            set
            {
                _rawMatAccAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RawMatAccAccSubTypeAccSubType
        {
            get
            {
                return _rawMatAccAccSubTypeAccSubType;
            }
            set
            {
                _rawMatAccAccSubTypeAccSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RawMatAccAccTypeAccType
        {
            get
            {
                return _rawMatAccAccTypeAccType;
            }
            set
            {
                _rawMatAccAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RawMatAccCoaControlAccName
        {
            get
            {
                return _rawMatAccCoaControlAccName;
            }
            set
            {
                _rawMatAccCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RawMatAccCoaControlAccBalTypeAccBalType
        {
            get
            {
                return _rawMatAccCoaControlAccBalTypeAccBalType;
            }
            set
            {
                _rawMatAccCoaControlAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RawMatAccCoaControlAccDestAccDest
        {
            get
            {
                return _rawMatAccCoaControlAccDestAccDest;
            }
            set
            {
                _rawMatAccCoaControlAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RawMatAccCoaControlAccTypeAccType
        {
            get
            {
                return _rawMatAccCoaControlAccTypeAccType;
            }
            set
            {
                _rawMatAccCoaControlAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RawMatAccCoaControlCompTypeDescription
        {
            get
            {
                return _rawMatAccCoaControlCompTypeDescription;
            }
            set
            {
                _rawMatAccCoaControlCompTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RawMatAccCoaMainAccName
        {
            get
            {
                return _rawMatAccCoaMainAccName;
            }
            set
            {
                _rawMatAccCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RawMatAccCoaMainAccBalTypeAccBalType
        {
            get
            {
                return _rawMatAccCoaMainAccBalTypeAccBalType;
            }
            set
            {
                _rawMatAccCoaMainAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RawMatAccCoaMainAccDestAccDest
        {
            get
            {
                return _rawMatAccCoaMainAccDestAccDest;
            }
            set
            {
                _rawMatAccCoaMainAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RawMatAccCoaMainAccFundAccFundCode
        {
            get
            {
                return _rawMatAccCoaMainAccFundAccFundCode;
            }
            set
            {
                _rawMatAccCoaMainAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RawMatAccCoaMainAccTypeAccType
        {
            get
            {
                return _rawMatAccCoaMainAccTypeAccType;
            }
            set
            {
                _rawMatAccCoaMainAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RawMatAccCoaMainCoaControlAccName
        {
            get
            {
                return _rawMatAccCoaMainCoaControlAccName;
            }
            set
            {
                _rawMatAccCoaMainCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RawMatAccCoaSubAccName
        {
            get
            {
                return _rawMatAccCoaSubAccName;
            }
            set
            {
                _rawMatAccCoaSubAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RawMatAccCoaSubAccBalTypeAccBalType
        {
            get
            {
                return _rawMatAccCoaSubAccBalTypeAccBalType;
            }
            set
            {
                _rawMatAccCoaSubAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RawMatAccCoaSubAccDestAccDest
        {
            get
            {
                return _rawMatAccCoaSubAccDestAccDest;
            }
            set
            {
                _rawMatAccCoaSubAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RawMatAccCoaSubAccFundAccFundCode
        {
            get
            {
                return _rawMatAccCoaSubAccFundAccFundCode;
            }
            set
            {
                _rawMatAccCoaSubAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RawMatAccCoaSubAccTypeAccType
        {
            get
            {
                return _rawMatAccCoaSubAccTypeAccType;
            }
            set
            {
                _rawMatAccCoaSubAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RawMatAccCoaSubCoaControlAccName
        {
            get
            {
                return _rawMatAccCoaSubCoaControlAccName;
            }
            set
            {
                _rawMatAccCoaSubCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RawMatAccCoaSubCoaMainAccName
        {
            get
            {
                return _rawMatAccCoaSubCoaMainAccName;
            }
            set
            {
                _rawMatAccCoaSubCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? PackMatAcc
        {
            get
            {
                return _packMatAcc;
            }
            set
            {
                _packMatAcc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PackMatAccAccName
        {
            get
            {
                return _packMatAccAccName;
            }
            set
            {
                _packMatAccAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PackMatAccAccBalTypeAccBalType
        {
            get
            {
                return _packMatAccAccBalTypeAccBalType;
            }
            set
            {
                _packMatAccAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PackMatAccAccCurrencyAccCurrencyName
        {
            get
            {
                return _packMatAccAccCurrencyAccCurrencyName;
            }
            set
            {
                _packMatAccAccCurrencyAccCurrencyName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PackMatAccAccDestAccDest
        {
            get
            {
                return _packMatAccAccDestAccDest;
            }
            set
            {
                _packMatAccAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PackMatAccAccDestCompanyTypeDescription
        {
            get
            {
                return _packMatAccAccDestCompanyTypeDescription;
            }
            set
            {
                _packMatAccAccDestCompanyTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PackMatAccAccFundAccFundCode
        {
            get
            {
                return _packMatAccAccFundAccFundCode;
            }
            set
            {
                _packMatAccAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PackMatAccAccSubTypeAccSubType
        {
            get
            {
                return _packMatAccAccSubTypeAccSubType;
            }
            set
            {
                _packMatAccAccSubTypeAccSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PackMatAccAccTypeAccType
        {
            get
            {
                return _packMatAccAccTypeAccType;
            }
            set
            {
                _packMatAccAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PackMatAccCoaControlAccName
        {
            get
            {
                return _packMatAccCoaControlAccName;
            }
            set
            {
                _packMatAccCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PackMatAccCoaControlAccBalTypeAccBalType
        {
            get
            {
                return _packMatAccCoaControlAccBalTypeAccBalType;
            }
            set
            {
                _packMatAccCoaControlAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PackMatAccCoaControlAccDestAccDest
        {
            get
            {
                return _packMatAccCoaControlAccDestAccDest;
            }
            set
            {
                _packMatAccCoaControlAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PackMatAccCoaControlAccTypeAccType
        {
            get
            {
                return _packMatAccCoaControlAccTypeAccType;
            }
            set
            {
                _packMatAccCoaControlAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PackMatAccCoaControlCompTypeDescription
        {
            get
            {
                return _packMatAccCoaControlCompTypeDescription;
            }
            set
            {
                _packMatAccCoaControlCompTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PackMatAccCoaMainAccName
        {
            get
            {
                return _packMatAccCoaMainAccName;
            }
            set
            {
                _packMatAccCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PackMatAccCoaMainAccBalTypeAccBalType
        {
            get
            {
                return _packMatAccCoaMainAccBalTypeAccBalType;
            }
            set
            {
                _packMatAccCoaMainAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PackMatAccCoaMainAccDestAccDest
        {
            get
            {
                return _packMatAccCoaMainAccDestAccDest;
            }
            set
            {
                _packMatAccCoaMainAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PackMatAccCoaMainAccFundAccFundCode
        {
            get
            {
                return _packMatAccCoaMainAccFundAccFundCode;
            }
            set
            {
                _packMatAccCoaMainAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PackMatAccCoaMainAccTypeAccType
        {
            get
            {
                return _packMatAccCoaMainAccTypeAccType;
            }
            set
            {
                _packMatAccCoaMainAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PackMatAccCoaMainCoaControlAccName
        {
            get
            {
                return _packMatAccCoaMainCoaControlAccName;
            }
            set
            {
                _packMatAccCoaMainCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PackMatAccCoaSubAccName
        {
            get
            {
                return _packMatAccCoaSubAccName;
            }
            set
            {
                _packMatAccCoaSubAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PackMatAccCoaSubAccBalTypeAccBalType
        {
            get
            {
                return _packMatAccCoaSubAccBalTypeAccBalType;
            }
            set
            {
                _packMatAccCoaSubAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PackMatAccCoaSubAccDestAccDest
        {
            get
            {
                return _packMatAccCoaSubAccDestAccDest;
            }
            set
            {
                _packMatAccCoaSubAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PackMatAccCoaSubAccFundAccFundCode
        {
            get
            {
                return _packMatAccCoaSubAccFundAccFundCode;
            }
            set
            {
                _packMatAccCoaSubAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PackMatAccCoaSubAccTypeAccType
        {
            get
            {
                return _packMatAccCoaSubAccTypeAccType;
            }
            set
            {
                _packMatAccCoaSubAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PackMatAccCoaSubCoaControlAccName
        {
            get
            {
                return _packMatAccCoaSubCoaControlAccName;
            }
            set
            {
                _packMatAccCoaSubCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PackMatAccCoaSubCoaMainAccName
        {
            get
            {
                return _packMatAccCoaSubCoaMainAccName;
            }
            set
            {
                _packMatAccCoaSubCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? OtherMatAcc
        {
            get
            {
                return _otherMatAcc;
            }
            set
            {
                _otherMatAcc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OtherMatAccAccName
        {
            get
            {
                return _otherMatAccAccName;
            }
            set
            {
                _otherMatAccAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OtherMatAccAccBalTypeAccBalType
        {
            get
            {
                return _otherMatAccAccBalTypeAccBalType;
            }
            set
            {
                _otherMatAccAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OtherMatAccAccCurrencyAccCurrencyName
        {
            get
            {
                return _otherMatAccAccCurrencyAccCurrencyName;
            }
            set
            {
                _otherMatAccAccCurrencyAccCurrencyName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OtherMatAccAccDestAccDest
        {
            get
            {
                return _otherMatAccAccDestAccDest;
            }
            set
            {
                _otherMatAccAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OtherMatAccAccDestCompanyTypeDescription
        {
            get
            {
                return _otherMatAccAccDestCompanyTypeDescription;
            }
            set
            {
                _otherMatAccAccDestCompanyTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OtherMatAccAccFundAccFundCode
        {
            get
            {
                return _otherMatAccAccFundAccFundCode;
            }
            set
            {
                _otherMatAccAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OtherMatAccAccSubTypeAccSubType
        {
            get
            {
                return _otherMatAccAccSubTypeAccSubType;
            }
            set
            {
                _otherMatAccAccSubTypeAccSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OtherMatAccAccTypeAccType
        {
            get
            {
                return _otherMatAccAccTypeAccType;
            }
            set
            {
                _otherMatAccAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OtherMatAccCoaControlAccName
        {
            get
            {
                return _otherMatAccCoaControlAccName;
            }
            set
            {
                _otherMatAccCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OtherMatAccCoaControlAccBalTypeAccBalType
        {
            get
            {
                return _otherMatAccCoaControlAccBalTypeAccBalType;
            }
            set
            {
                _otherMatAccCoaControlAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OtherMatAccCoaControlAccDestAccDest
        {
            get
            {
                return _otherMatAccCoaControlAccDestAccDest;
            }
            set
            {
                _otherMatAccCoaControlAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OtherMatAccCoaControlAccTypeAccType
        {
            get
            {
                return _otherMatAccCoaControlAccTypeAccType;
            }
            set
            {
                _otherMatAccCoaControlAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OtherMatAccCoaControlCompTypeDescription
        {
            get
            {
                return _otherMatAccCoaControlCompTypeDescription;
            }
            set
            {
                _otherMatAccCoaControlCompTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OtherMatAccCoaMainAccName
        {
            get
            {
                return _otherMatAccCoaMainAccName;
            }
            set
            {
                _otherMatAccCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OtherMatAccCoaMainAccBalTypeAccBalType
        {
            get
            {
                return _otherMatAccCoaMainAccBalTypeAccBalType;
            }
            set
            {
                _otherMatAccCoaMainAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OtherMatAccCoaMainAccDestAccDest
        {
            get
            {
                return _otherMatAccCoaMainAccDestAccDest;
            }
            set
            {
                _otherMatAccCoaMainAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OtherMatAccCoaMainAccFundAccFundCode
        {
            get
            {
                return _otherMatAccCoaMainAccFundAccFundCode;
            }
            set
            {
                _otherMatAccCoaMainAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OtherMatAccCoaMainAccTypeAccType
        {
            get
            {
                return _otherMatAccCoaMainAccTypeAccType;
            }
            set
            {
                _otherMatAccCoaMainAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OtherMatAccCoaMainCoaControlAccName
        {
            get
            {
                return _otherMatAccCoaMainCoaControlAccName;
            }
            set
            {
                _otherMatAccCoaMainCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OtherMatAccCoaSubAccName
        {
            get
            {
                return _otherMatAccCoaSubAccName;
            }
            set
            {
                _otherMatAccCoaSubAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OtherMatAccCoaSubAccBalTypeAccBalType
        {
            get
            {
                return _otherMatAccCoaSubAccBalTypeAccBalType;
            }
            set
            {
                _otherMatAccCoaSubAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OtherMatAccCoaSubAccDestAccDest
        {
            get
            {
                return _otherMatAccCoaSubAccDestAccDest;
            }
            set
            {
                _otherMatAccCoaSubAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OtherMatAccCoaSubAccFundAccFundCode
        {
            get
            {
                return _otherMatAccCoaSubAccFundAccFundCode;
            }
            set
            {
                _otherMatAccCoaSubAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OtherMatAccCoaSubAccTypeAccType
        {
            get
            {
                return _otherMatAccCoaSubAccTypeAccType;
            }
            set
            {
                _otherMatAccCoaSubAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OtherMatAccCoaSubCoaControlAccName
        {
            get
            {
                return _otherMatAccCoaSubCoaControlAccName;
            }
            set
            {
                _otherMatAccCoaSubCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OtherMatAccCoaSubCoaMainAccName
        {
            get
            {
                return _otherMatAccCoaSubCoaMainAccName;
            }
            set
            {
                _otherMatAccCoaSubCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? FinishMatAcc
        {
            get
            {
                return _finishMatAcc;
            }
            set
            {
                _finishMatAcc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string FinishMatAccAccName
        {
            get
            {
                return _finishMatAccAccName;
            }
            set
            {
                _finishMatAccAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string FinishMatAccAccBalTypeAccBalType
        {
            get
            {
                return _finishMatAccAccBalTypeAccBalType;
            }
            set
            {
                _finishMatAccAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string FinishMatAccAccCurrencyAccCurrencyName
        {
            get
            {
                return _finishMatAccAccCurrencyAccCurrencyName;
            }
            set
            {
                _finishMatAccAccCurrencyAccCurrencyName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string FinishMatAccAccDestAccDest
        {
            get
            {
                return _finishMatAccAccDestAccDest;
            }
            set
            {
                _finishMatAccAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string FinishMatAccAccDestCompanyTypeDescription
        {
            get
            {
                return _finishMatAccAccDestCompanyTypeDescription;
            }
            set
            {
                _finishMatAccAccDestCompanyTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string FinishMatAccAccFundAccFundCode
        {
            get
            {
                return _finishMatAccAccFundAccFundCode;
            }
            set
            {
                _finishMatAccAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string FinishMatAccAccSubTypeAccSubType
        {
            get
            {
                return _finishMatAccAccSubTypeAccSubType;
            }
            set
            {
                _finishMatAccAccSubTypeAccSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string FinishMatAccAccTypeAccType
        {
            get
            {
                return _finishMatAccAccTypeAccType;
            }
            set
            {
                _finishMatAccAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string FinishMatAccCoaControlAccName
        {
            get
            {
                return _finishMatAccCoaControlAccName;
            }
            set
            {
                _finishMatAccCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string FinishMatAccCoaControlAccBalTypeAccBalType
        {
            get
            {
                return _finishMatAccCoaControlAccBalTypeAccBalType;
            }
            set
            {
                _finishMatAccCoaControlAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string FinishMatAccCoaControlAccDestAccDest
        {
            get
            {
                return _finishMatAccCoaControlAccDestAccDest;
            }
            set
            {
                _finishMatAccCoaControlAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string FinishMatAccCoaControlAccTypeAccType
        {
            get
            {
                return _finishMatAccCoaControlAccTypeAccType;
            }
            set
            {
                _finishMatAccCoaControlAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string FinishMatAccCoaControlCompTypeDescription
        {
            get
            {
                return _finishMatAccCoaControlCompTypeDescription;
            }
            set
            {
                _finishMatAccCoaControlCompTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string FinishMatAccCoaMainAccName
        {
            get
            {
                return _finishMatAccCoaMainAccName;
            }
            set
            {
                _finishMatAccCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string FinishMatAccCoaMainAccBalTypeAccBalType
        {
            get
            {
                return _finishMatAccCoaMainAccBalTypeAccBalType;
            }
            set
            {
                _finishMatAccCoaMainAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string FinishMatAccCoaMainAccDestAccDest
        {
            get
            {
                return _finishMatAccCoaMainAccDestAccDest;
            }
            set
            {
                _finishMatAccCoaMainAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string FinishMatAccCoaMainAccFundAccFundCode
        {
            get
            {
                return _finishMatAccCoaMainAccFundAccFundCode;
            }
            set
            {
                _finishMatAccCoaMainAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string FinishMatAccCoaMainAccTypeAccType
        {
            get
            {
                return _finishMatAccCoaMainAccTypeAccType;
            }
            set
            {
                _finishMatAccCoaMainAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string FinishMatAccCoaMainCoaControlAccName
        {
            get
            {
                return _finishMatAccCoaMainCoaControlAccName;
            }
            set
            {
                _finishMatAccCoaMainCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string FinishMatAccCoaSubAccName
        {
            get
            {
                return _finishMatAccCoaSubAccName;
            }
            set
            {
                _finishMatAccCoaSubAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string FinishMatAccCoaSubAccBalTypeAccBalType
        {
            get
            {
                return _finishMatAccCoaSubAccBalTypeAccBalType;
            }
            set
            {
                _finishMatAccCoaSubAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string FinishMatAccCoaSubAccDestAccDest
        {
            get
            {
                return _finishMatAccCoaSubAccDestAccDest;
            }
            set
            {
                _finishMatAccCoaSubAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string FinishMatAccCoaSubAccFundAccFundCode
        {
            get
            {
                return _finishMatAccCoaSubAccFundAccFundCode;
            }
            set
            {
                _finishMatAccCoaSubAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string FinishMatAccCoaSubAccTypeAccType
        {
            get
            {
                return _finishMatAccCoaSubAccTypeAccType;
            }
            set
            {
                _finishMatAccCoaSubAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string FinishMatAccCoaSubCoaControlAccName
        {
            get
            {
                return _finishMatAccCoaSubCoaControlAccName;
            }
            set
            {
                _finishMatAccCoaSubCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string FinishMatAccCoaSubCoaMainAccName
        {
            get
            {
                return _finishMatAccCoaSubCoaMainAccName;
            }
            set
            {
                _finishMatAccCoaSubCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? AdminExpAcc
        {
            get
            {
                return _adminExpAcc;
            }
            set
            {
                _adminExpAcc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdminExpAccAccName
        {
            get
            {
                return _adminExpAccAccName;
            }
            set
            {
                _adminExpAccAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdminExpAccAccBalTypeAccBalType
        {
            get
            {
                return _adminExpAccAccBalTypeAccBalType;
            }
            set
            {
                _adminExpAccAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdminExpAccAccCurrencyAccCurrencyName
        {
            get
            {
                return _adminExpAccAccCurrencyAccCurrencyName;
            }
            set
            {
                _adminExpAccAccCurrencyAccCurrencyName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdminExpAccAccDestAccDest
        {
            get
            {
                return _adminExpAccAccDestAccDest;
            }
            set
            {
                _adminExpAccAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdminExpAccAccDestCompanyTypeDescription
        {
            get
            {
                return _adminExpAccAccDestCompanyTypeDescription;
            }
            set
            {
                _adminExpAccAccDestCompanyTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdminExpAccAccFundAccFundCode
        {
            get
            {
                return _adminExpAccAccFundAccFundCode;
            }
            set
            {
                _adminExpAccAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdminExpAccAccSubTypeAccSubType
        {
            get
            {
                return _adminExpAccAccSubTypeAccSubType;
            }
            set
            {
                _adminExpAccAccSubTypeAccSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdminExpAccAccTypeAccType
        {
            get
            {
                return _adminExpAccAccTypeAccType;
            }
            set
            {
                _adminExpAccAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdminExpAccCoaControlAccName
        {
            get
            {
                return _adminExpAccCoaControlAccName;
            }
            set
            {
                _adminExpAccCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdminExpAccCoaControlAccBalTypeAccBalType
        {
            get
            {
                return _adminExpAccCoaControlAccBalTypeAccBalType;
            }
            set
            {
                _adminExpAccCoaControlAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdminExpAccCoaControlAccDestAccDest
        {
            get
            {
                return _adminExpAccCoaControlAccDestAccDest;
            }
            set
            {
                _adminExpAccCoaControlAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdminExpAccCoaControlAccTypeAccType
        {
            get
            {
                return _adminExpAccCoaControlAccTypeAccType;
            }
            set
            {
                _adminExpAccCoaControlAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdminExpAccCoaControlCompTypeDescription
        {
            get
            {
                return _adminExpAccCoaControlCompTypeDescription;
            }
            set
            {
                _adminExpAccCoaControlCompTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdminExpAccCoaMainAccName
        {
            get
            {
                return _adminExpAccCoaMainAccName;
            }
            set
            {
                _adminExpAccCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdminExpAccCoaMainAccBalTypeAccBalType
        {
            get
            {
                return _adminExpAccCoaMainAccBalTypeAccBalType;
            }
            set
            {
                _adminExpAccCoaMainAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdminExpAccCoaMainAccDestAccDest
        {
            get
            {
                return _adminExpAccCoaMainAccDestAccDest;
            }
            set
            {
                _adminExpAccCoaMainAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdminExpAccCoaMainAccFundAccFundCode
        {
            get
            {
                return _adminExpAccCoaMainAccFundAccFundCode;
            }
            set
            {
                _adminExpAccCoaMainAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdminExpAccCoaMainAccTypeAccType
        {
            get
            {
                return _adminExpAccCoaMainAccTypeAccType;
            }
            set
            {
                _adminExpAccCoaMainAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdminExpAccCoaMainCoaControlAccName
        {
            get
            {
                return _adminExpAccCoaMainCoaControlAccName;
            }
            set
            {
                _adminExpAccCoaMainCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdminExpAccCoaSubAccName
        {
            get
            {
                return _adminExpAccCoaSubAccName;
            }
            set
            {
                _adminExpAccCoaSubAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdminExpAccCoaSubAccBalTypeAccBalType
        {
            get
            {
                return _adminExpAccCoaSubAccBalTypeAccBalType;
            }
            set
            {
                _adminExpAccCoaSubAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdminExpAccCoaSubAccDestAccDest
        {
            get
            {
                return _adminExpAccCoaSubAccDestAccDest;
            }
            set
            {
                _adminExpAccCoaSubAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdminExpAccCoaSubAccFundAccFundCode
        {
            get
            {
                return _adminExpAccCoaSubAccFundAccFundCode;
            }
            set
            {
                _adminExpAccCoaSubAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdminExpAccCoaSubAccTypeAccType
        {
            get
            {
                return _adminExpAccCoaSubAccTypeAccType;
            }
            set
            {
                _adminExpAccCoaSubAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdminExpAccCoaSubCoaControlAccName
        {
            get
            {
                return _adminExpAccCoaSubCoaControlAccName;
            }
            set
            {
                _adminExpAccCoaSubCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdminExpAccCoaSubCoaMainAccName
        {
            get
            {
                return _adminExpAccCoaSubCoaMainAccName;
            }
            set
            {
                _adminExpAccCoaSubCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? SellingExpAcc
        {
            get
            {
                return _sellingExpAcc;
            }
            set
            {
                _sellingExpAcc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SellingExpAccAccName
        {
            get
            {
                return _sellingExpAccAccName;
            }
            set
            {
                _sellingExpAccAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SellingExpAccAccBalTypeAccBalType
        {
            get
            {
                return _sellingExpAccAccBalTypeAccBalType;
            }
            set
            {
                _sellingExpAccAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SellingExpAccAccCurrencyAccCurrencyName
        {
            get
            {
                return _sellingExpAccAccCurrencyAccCurrencyName;
            }
            set
            {
                _sellingExpAccAccCurrencyAccCurrencyName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SellingExpAccAccDestAccDest
        {
            get
            {
                return _sellingExpAccAccDestAccDest;
            }
            set
            {
                _sellingExpAccAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SellingExpAccAccDestCompanyTypeDescription
        {
            get
            {
                return _sellingExpAccAccDestCompanyTypeDescription;
            }
            set
            {
                _sellingExpAccAccDestCompanyTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SellingExpAccAccFundAccFundCode
        {
            get
            {
                return _sellingExpAccAccFundAccFundCode;
            }
            set
            {
                _sellingExpAccAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SellingExpAccAccSubTypeAccSubType
        {
            get
            {
                return _sellingExpAccAccSubTypeAccSubType;
            }
            set
            {
                _sellingExpAccAccSubTypeAccSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SellingExpAccAccTypeAccType
        {
            get
            {
                return _sellingExpAccAccTypeAccType;
            }
            set
            {
                _sellingExpAccAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SellingExpAccCoaControlAccName
        {
            get
            {
                return _sellingExpAccCoaControlAccName;
            }
            set
            {
                _sellingExpAccCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SellingExpAccCoaControlAccBalTypeAccBalType
        {
            get
            {
                return _sellingExpAccCoaControlAccBalTypeAccBalType;
            }
            set
            {
                _sellingExpAccCoaControlAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SellingExpAccCoaControlAccDestAccDest
        {
            get
            {
                return _sellingExpAccCoaControlAccDestAccDest;
            }
            set
            {
                _sellingExpAccCoaControlAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SellingExpAccCoaControlAccTypeAccType
        {
            get
            {
                return _sellingExpAccCoaControlAccTypeAccType;
            }
            set
            {
                _sellingExpAccCoaControlAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SellingExpAccCoaControlCompTypeDescription
        {
            get
            {
                return _sellingExpAccCoaControlCompTypeDescription;
            }
            set
            {
                _sellingExpAccCoaControlCompTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SellingExpAccCoaMainAccName
        {
            get
            {
                return _sellingExpAccCoaMainAccName;
            }
            set
            {
                _sellingExpAccCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SellingExpAccCoaMainAccBalTypeAccBalType
        {
            get
            {
                return _sellingExpAccCoaMainAccBalTypeAccBalType;
            }
            set
            {
                _sellingExpAccCoaMainAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SellingExpAccCoaMainAccDestAccDest
        {
            get
            {
                return _sellingExpAccCoaMainAccDestAccDest;
            }
            set
            {
                _sellingExpAccCoaMainAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SellingExpAccCoaMainAccFundAccFundCode
        {
            get
            {
                return _sellingExpAccCoaMainAccFundAccFundCode;
            }
            set
            {
                _sellingExpAccCoaMainAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SellingExpAccCoaMainAccTypeAccType
        {
            get
            {
                return _sellingExpAccCoaMainAccTypeAccType;
            }
            set
            {
                _sellingExpAccCoaMainAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SellingExpAccCoaMainCoaControlAccName
        {
            get
            {
                return _sellingExpAccCoaMainCoaControlAccName;
            }
            set
            {
                _sellingExpAccCoaMainCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SellingExpAccCoaSubAccName
        {
            get
            {
                return _sellingExpAccCoaSubAccName;
            }
            set
            {
                _sellingExpAccCoaSubAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SellingExpAccCoaSubAccBalTypeAccBalType
        {
            get
            {
                return _sellingExpAccCoaSubAccBalTypeAccBalType;
            }
            set
            {
                _sellingExpAccCoaSubAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SellingExpAccCoaSubAccDestAccDest
        {
            get
            {
                return _sellingExpAccCoaSubAccDestAccDest;
            }
            set
            {
                _sellingExpAccCoaSubAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SellingExpAccCoaSubAccFundAccFundCode
        {
            get
            {
                return _sellingExpAccCoaSubAccFundAccFundCode;
            }
            set
            {
                _sellingExpAccCoaSubAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SellingExpAccCoaSubAccTypeAccType
        {
            get
            {
                return _sellingExpAccCoaSubAccTypeAccType;
            }
            set
            {
                _sellingExpAccCoaSubAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SellingExpAccCoaSubCoaControlAccName
        {
            get
            {
                return _sellingExpAccCoaSubCoaControlAccName;
            }
            set
            {
                _sellingExpAccCoaSubCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SellingExpAccCoaSubCoaMainAccName
        {
            get
            {
                return _sellingExpAccCoaSubCoaMainAccName;
            }
            set
            {
                _sellingExpAccCoaSubCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? ManuExpAcc
        {
            get
            {
                return _manuExpAcc;
            }
            set
            {
                _manuExpAcc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ManuExpAccAccName
        {
            get
            {
                return _manuExpAccAccName;
            }
            set
            {
                _manuExpAccAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ManuExpAccAccBalTypeAccBalType
        {
            get
            {
                return _manuExpAccAccBalTypeAccBalType;
            }
            set
            {
                _manuExpAccAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ManuExpAccAccCurrencyAccCurrencyName
        {
            get
            {
                return _manuExpAccAccCurrencyAccCurrencyName;
            }
            set
            {
                _manuExpAccAccCurrencyAccCurrencyName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ManuExpAccAccDestAccDest
        {
            get
            {
                return _manuExpAccAccDestAccDest;
            }
            set
            {
                _manuExpAccAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ManuExpAccAccDestCompanyTypeDescription
        {
            get
            {
                return _manuExpAccAccDestCompanyTypeDescription;
            }
            set
            {
                _manuExpAccAccDestCompanyTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ManuExpAccAccFundAccFundCode
        {
            get
            {
                return _manuExpAccAccFundAccFundCode;
            }
            set
            {
                _manuExpAccAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ManuExpAccAccSubTypeAccSubType
        {
            get
            {
                return _manuExpAccAccSubTypeAccSubType;
            }
            set
            {
                _manuExpAccAccSubTypeAccSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ManuExpAccAccTypeAccType
        {
            get
            {
                return _manuExpAccAccTypeAccType;
            }
            set
            {
                _manuExpAccAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ManuExpAccCoaControlAccName
        {
            get
            {
                return _manuExpAccCoaControlAccName;
            }
            set
            {
                _manuExpAccCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ManuExpAccCoaControlAccBalTypeAccBalType
        {
            get
            {
                return _manuExpAccCoaControlAccBalTypeAccBalType;
            }
            set
            {
                _manuExpAccCoaControlAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ManuExpAccCoaControlAccDestAccDest
        {
            get
            {
                return _manuExpAccCoaControlAccDestAccDest;
            }
            set
            {
                _manuExpAccCoaControlAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ManuExpAccCoaControlAccTypeAccType
        {
            get
            {
                return _manuExpAccCoaControlAccTypeAccType;
            }
            set
            {
                _manuExpAccCoaControlAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ManuExpAccCoaControlCompTypeDescription
        {
            get
            {
                return _manuExpAccCoaControlCompTypeDescription;
            }
            set
            {
                _manuExpAccCoaControlCompTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ManuExpAccCoaMainAccName
        {
            get
            {
                return _manuExpAccCoaMainAccName;
            }
            set
            {
                _manuExpAccCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ManuExpAccCoaMainAccBalTypeAccBalType
        {
            get
            {
                return _manuExpAccCoaMainAccBalTypeAccBalType;
            }
            set
            {
                _manuExpAccCoaMainAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ManuExpAccCoaMainAccDestAccDest
        {
            get
            {
                return _manuExpAccCoaMainAccDestAccDest;
            }
            set
            {
                _manuExpAccCoaMainAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ManuExpAccCoaMainAccFundAccFundCode
        {
            get
            {
                return _manuExpAccCoaMainAccFundAccFundCode;
            }
            set
            {
                _manuExpAccCoaMainAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ManuExpAccCoaMainAccTypeAccType
        {
            get
            {
                return _manuExpAccCoaMainAccTypeAccType;
            }
            set
            {
                _manuExpAccCoaMainAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ManuExpAccCoaMainCoaControlAccName
        {
            get
            {
                return _manuExpAccCoaMainCoaControlAccName;
            }
            set
            {
                _manuExpAccCoaMainCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ManuExpAccCoaSubAccName
        {
            get
            {
                return _manuExpAccCoaSubAccName;
            }
            set
            {
                _manuExpAccCoaSubAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ManuExpAccCoaSubAccBalTypeAccBalType
        {
            get
            {
                return _manuExpAccCoaSubAccBalTypeAccBalType;
            }
            set
            {
                _manuExpAccCoaSubAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ManuExpAccCoaSubAccDestAccDest
        {
            get
            {
                return _manuExpAccCoaSubAccDestAccDest;
            }
            set
            {
                _manuExpAccCoaSubAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ManuExpAccCoaSubAccFundAccFundCode
        {
            get
            {
                return _manuExpAccCoaSubAccFundAccFundCode;
            }
            set
            {
                _manuExpAccCoaSubAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ManuExpAccCoaSubAccTypeAccType
        {
            get
            {
                return _manuExpAccCoaSubAccTypeAccType;
            }
            set
            {
                _manuExpAccCoaSubAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ManuExpAccCoaSubCoaControlAccName
        {
            get
            {
                return _manuExpAccCoaSubCoaControlAccName;
            }
            set
            {
                _manuExpAccCoaSubCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ManuExpAccCoaSubCoaMainAccName
        {
            get
            {
                return _manuExpAccCoaSubCoaMainAccName;
            }
            set
            {
                _manuExpAccCoaSubCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? LoanAcc
        {
            get
            {
                return _loanAcc;
            }
            set
            {
                _loanAcc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LoanAccAccName
        {
            get
            {
                return _loanAccAccName;
            }
            set
            {
                _loanAccAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LoanAccAccBalTypeAccBalType
        {
            get
            {
                return _loanAccAccBalTypeAccBalType;
            }
            set
            {
                _loanAccAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LoanAccAccCurrencyAccCurrencyName
        {
            get
            {
                return _loanAccAccCurrencyAccCurrencyName;
            }
            set
            {
                _loanAccAccCurrencyAccCurrencyName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LoanAccAccDestAccDest
        {
            get
            {
                return _loanAccAccDestAccDest;
            }
            set
            {
                _loanAccAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LoanAccAccDestCompanyTypeDescription
        {
            get
            {
                return _loanAccAccDestCompanyTypeDescription;
            }
            set
            {
                _loanAccAccDestCompanyTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LoanAccAccFundAccFundCode
        {
            get
            {
                return _loanAccAccFundAccFundCode;
            }
            set
            {
                _loanAccAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LoanAccAccSubTypeAccSubType
        {
            get
            {
                return _loanAccAccSubTypeAccSubType;
            }
            set
            {
                _loanAccAccSubTypeAccSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LoanAccAccTypeAccType
        {
            get
            {
                return _loanAccAccTypeAccType;
            }
            set
            {
                _loanAccAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LoanAccCoaControlAccName
        {
            get
            {
                return _loanAccCoaControlAccName;
            }
            set
            {
                _loanAccCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LoanAccCoaControlAccBalTypeAccBalType
        {
            get
            {
                return _loanAccCoaControlAccBalTypeAccBalType;
            }
            set
            {
                _loanAccCoaControlAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LoanAccCoaControlAccDestAccDest
        {
            get
            {
                return _loanAccCoaControlAccDestAccDest;
            }
            set
            {
                _loanAccCoaControlAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LoanAccCoaControlAccTypeAccType
        {
            get
            {
                return _loanAccCoaControlAccTypeAccType;
            }
            set
            {
                _loanAccCoaControlAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LoanAccCoaControlCompTypeDescription
        {
            get
            {
                return _loanAccCoaControlCompTypeDescription;
            }
            set
            {
                _loanAccCoaControlCompTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LoanAccCoaMainAccName
        {
            get
            {
                return _loanAccCoaMainAccName;
            }
            set
            {
                _loanAccCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LoanAccCoaMainAccBalTypeAccBalType
        {
            get
            {
                return _loanAccCoaMainAccBalTypeAccBalType;
            }
            set
            {
                _loanAccCoaMainAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LoanAccCoaMainAccDestAccDest
        {
            get
            {
                return _loanAccCoaMainAccDestAccDest;
            }
            set
            {
                _loanAccCoaMainAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LoanAccCoaMainAccFundAccFundCode
        {
            get
            {
                return _loanAccCoaMainAccFundAccFundCode;
            }
            set
            {
                _loanAccCoaMainAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LoanAccCoaMainAccTypeAccType
        {
            get
            {
                return _loanAccCoaMainAccTypeAccType;
            }
            set
            {
                _loanAccCoaMainAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LoanAccCoaMainCoaControlAccName
        {
            get
            {
                return _loanAccCoaMainCoaControlAccName;
            }
            set
            {
                _loanAccCoaMainCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LoanAccCoaSubAccName
        {
            get
            {
                return _loanAccCoaSubAccName;
            }
            set
            {
                _loanAccCoaSubAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LoanAccCoaSubAccBalTypeAccBalType
        {
            get
            {
                return _loanAccCoaSubAccBalTypeAccBalType;
            }
            set
            {
                _loanAccCoaSubAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LoanAccCoaSubAccDestAccDest
        {
            get
            {
                return _loanAccCoaSubAccDestAccDest;
            }
            set
            {
                _loanAccCoaSubAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LoanAccCoaSubAccFundAccFundCode
        {
            get
            {
                return _loanAccCoaSubAccFundAccFundCode;
            }
            set
            {
                _loanAccCoaSubAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LoanAccCoaSubAccTypeAccType
        {
            get
            {
                return _loanAccCoaSubAccTypeAccType;
            }
            set
            {
                _loanAccCoaSubAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LoanAccCoaSubCoaControlAccName
        {
            get
            {
                return _loanAccCoaSubCoaControlAccName;
            }
            set
            {
                _loanAccCoaSubCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LoanAccCoaSubCoaMainAccName
        {
            get
            {
                return _loanAccCoaSubCoaMainAccName;
            }
            set
            {
                _loanAccCoaSubCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? AssetDepAcc
        {
            get
            {
                return _assetDepAcc;
            }
            set
            {
                _assetDepAcc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AssetDepAccAccName
        {
            get
            {
                return _assetDepAccAccName;
            }
            set
            {
                _assetDepAccAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AssetDepAccAccBalTypeAccBalType
        {
            get
            {
                return _assetDepAccAccBalTypeAccBalType;
            }
            set
            {
                _assetDepAccAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AssetDepAccAccCurrencyAccCurrencyName
        {
            get
            {
                return _assetDepAccAccCurrencyAccCurrencyName;
            }
            set
            {
                _assetDepAccAccCurrencyAccCurrencyName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AssetDepAccAccDestAccDest
        {
            get
            {
                return _assetDepAccAccDestAccDest;
            }
            set
            {
                _assetDepAccAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AssetDepAccAccDestCompanyTypeDescription
        {
            get
            {
                return _assetDepAccAccDestCompanyTypeDescription;
            }
            set
            {
                _assetDepAccAccDestCompanyTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AssetDepAccAccFundAccFundCode
        {
            get
            {
                return _assetDepAccAccFundAccFundCode;
            }
            set
            {
                _assetDepAccAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AssetDepAccAccSubTypeAccSubType
        {
            get
            {
                return _assetDepAccAccSubTypeAccSubType;
            }
            set
            {
                _assetDepAccAccSubTypeAccSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AssetDepAccAccTypeAccType
        {
            get
            {
                return _assetDepAccAccTypeAccType;
            }
            set
            {
                _assetDepAccAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AssetDepAccCoaControlAccName
        {
            get
            {
                return _assetDepAccCoaControlAccName;
            }
            set
            {
                _assetDepAccCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AssetDepAccCoaControlAccBalTypeAccBalType
        {
            get
            {
                return _assetDepAccCoaControlAccBalTypeAccBalType;
            }
            set
            {
                _assetDepAccCoaControlAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AssetDepAccCoaControlAccDestAccDest
        {
            get
            {
                return _assetDepAccCoaControlAccDestAccDest;
            }
            set
            {
                _assetDepAccCoaControlAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AssetDepAccCoaControlAccTypeAccType
        {
            get
            {
                return _assetDepAccCoaControlAccTypeAccType;
            }
            set
            {
                _assetDepAccCoaControlAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AssetDepAccCoaControlCompTypeDescription
        {
            get
            {
                return _assetDepAccCoaControlCompTypeDescription;
            }
            set
            {
                _assetDepAccCoaControlCompTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AssetDepAccCoaMainAccName
        {
            get
            {
                return _assetDepAccCoaMainAccName;
            }
            set
            {
                _assetDepAccCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AssetDepAccCoaMainAccBalTypeAccBalType
        {
            get
            {
                return _assetDepAccCoaMainAccBalTypeAccBalType;
            }
            set
            {
                _assetDepAccCoaMainAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AssetDepAccCoaMainAccDestAccDest
        {
            get
            {
                return _assetDepAccCoaMainAccDestAccDest;
            }
            set
            {
                _assetDepAccCoaMainAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AssetDepAccCoaMainAccFundAccFundCode
        {
            get
            {
                return _assetDepAccCoaMainAccFundAccFundCode;
            }
            set
            {
                _assetDepAccCoaMainAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AssetDepAccCoaMainAccTypeAccType
        {
            get
            {
                return _assetDepAccCoaMainAccTypeAccType;
            }
            set
            {
                _assetDepAccCoaMainAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AssetDepAccCoaMainCoaControlAccName
        {
            get
            {
                return _assetDepAccCoaMainCoaControlAccName;
            }
            set
            {
                _assetDepAccCoaMainCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AssetDepAccCoaSubAccName
        {
            get
            {
                return _assetDepAccCoaSubAccName;
            }
            set
            {
                _assetDepAccCoaSubAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AssetDepAccCoaSubAccBalTypeAccBalType
        {
            get
            {
                return _assetDepAccCoaSubAccBalTypeAccBalType;
            }
            set
            {
                _assetDepAccCoaSubAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AssetDepAccCoaSubAccDestAccDest
        {
            get
            {
                return _assetDepAccCoaSubAccDestAccDest;
            }
            set
            {
                _assetDepAccCoaSubAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AssetDepAccCoaSubAccFundAccFundCode
        {
            get
            {
                return _assetDepAccCoaSubAccFundAccFundCode;
            }
            set
            {
                _assetDepAccCoaSubAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AssetDepAccCoaSubAccTypeAccType
        {
            get
            {
                return _assetDepAccCoaSubAccTypeAccType;
            }
            set
            {
                _assetDepAccCoaSubAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AssetDepAccCoaSubCoaControlAccName
        {
            get
            {
                return _assetDepAccCoaSubCoaControlAccName;
            }
            set
            {
                _assetDepAccCoaSubCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AssetDepAccCoaSubCoaMainAccName
        {
            get
            {
                return _assetDepAccCoaSubCoaMainAccName;
            }
            set
            {
                _assetDepAccCoaSubCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? NonOperateIncAcc
        {
            get
            {
                return _nonOperateIncAcc;
            }
            set
            {
                _nonOperateIncAcc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateIncAccAccName
        {
            get
            {
                return _nonOperateIncAccAccName;
            }
            set
            {
                _nonOperateIncAccAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateIncAccAccBalTypeAccBalType
        {
            get
            {
                return _nonOperateIncAccAccBalTypeAccBalType;
            }
            set
            {
                _nonOperateIncAccAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateIncAccAccCurrencyAccCurrencyName
        {
            get
            {
                return _nonOperateIncAccAccCurrencyAccCurrencyName;
            }
            set
            {
                _nonOperateIncAccAccCurrencyAccCurrencyName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateIncAccAccDestAccDest
        {
            get
            {
                return _nonOperateIncAccAccDestAccDest;
            }
            set
            {
                _nonOperateIncAccAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateIncAccAccDestCompanyTypeDescription
        {
            get
            {
                return _nonOperateIncAccAccDestCompanyTypeDescription;
            }
            set
            {
                _nonOperateIncAccAccDestCompanyTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateIncAccAccFundAccFundCode
        {
            get
            {
                return _nonOperateIncAccAccFundAccFundCode;
            }
            set
            {
                _nonOperateIncAccAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateIncAccAccSubTypeAccSubType
        {
            get
            {
                return _nonOperateIncAccAccSubTypeAccSubType;
            }
            set
            {
                _nonOperateIncAccAccSubTypeAccSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateIncAccAccTypeAccType
        {
            get
            {
                return _nonOperateIncAccAccTypeAccType;
            }
            set
            {
                _nonOperateIncAccAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateIncAccCoaControlAccName
        {
            get
            {
                return _nonOperateIncAccCoaControlAccName;
            }
            set
            {
                _nonOperateIncAccCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateIncAccCoaControlAccBalTypeAccBalType
        {
            get
            {
                return _nonOperateIncAccCoaControlAccBalTypeAccBalType;
            }
            set
            {
                _nonOperateIncAccCoaControlAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateIncAccCoaControlAccDestAccDest
        {
            get
            {
                return _nonOperateIncAccCoaControlAccDestAccDest;
            }
            set
            {
                _nonOperateIncAccCoaControlAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateIncAccCoaControlAccTypeAccType
        {
            get
            {
                return _nonOperateIncAccCoaControlAccTypeAccType;
            }
            set
            {
                _nonOperateIncAccCoaControlAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateIncAccCoaControlCompTypeDescription
        {
            get
            {
                return _nonOperateIncAccCoaControlCompTypeDescription;
            }
            set
            {
                _nonOperateIncAccCoaControlCompTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateIncAccCoaMainAccName
        {
            get
            {
                return _nonOperateIncAccCoaMainAccName;
            }
            set
            {
                _nonOperateIncAccCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateIncAccCoaMainAccBalTypeAccBalType
        {
            get
            {
                return _nonOperateIncAccCoaMainAccBalTypeAccBalType;
            }
            set
            {
                _nonOperateIncAccCoaMainAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateIncAccCoaMainAccDestAccDest
        {
            get
            {
                return _nonOperateIncAccCoaMainAccDestAccDest;
            }
            set
            {
                _nonOperateIncAccCoaMainAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateIncAccCoaMainAccFundAccFundCode
        {
            get
            {
                return _nonOperateIncAccCoaMainAccFundAccFundCode;
            }
            set
            {
                _nonOperateIncAccCoaMainAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateIncAccCoaMainAccTypeAccType
        {
            get
            {
                return _nonOperateIncAccCoaMainAccTypeAccType;
            }
            set
            {
                _nonOperateIncAccCoaMainAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateIncAccCoaMainCoaControlAccName
        {
            get
            {
                return _nonOperateIncAccCoaMainCoaControlAccName;
            }
            set
            {
                _nonOperateIncAccCoaMainCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateIncAccCoaSubAccName
        {
            get
            {
                return _nonOperateIncAccCoaSubAccName;
            }
            set
            {
                _nonOperateIncAccCoaSubAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateIncAccCoaSubAccBalTypeAccBalType
        {
            get
            {
                return _nonOperateIncAccCoaSubAccBalTypeAccBalType;
            }
            set
            {
                _nonOperateIncAccCoaSubAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateIncAccCoaSubAccDestAccDest
        {
            get
            {
                return _nonOperateIncAccCoaSubAccDestAccDest;
            }
            set
            {
                _nonOperateIncAccCoaSubAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateIncAccCoaSubAccFundAccFundCode
        {
            get
            {
                return _nonOperateIncAccCoaSubAccFundAccFundCode;
            }
            set
            {
                _nonOperateIncAccCoaSubAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateIncAccCoaSubAccTypeAccType
        {
            get
            {
                return _nonOperateIncAccCoaSubAccTypeAccType;
            }
            set
            {
                _nonOperateIncAccCoaSubAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateIncAccCoaSubCoaControlAccName
        {
            get
            {
                return _nonOperateIncAccCoaSubCoaControlAccName;
            }
            set
            {
                _nonOperateIncAccCoaSubCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateIncAccCoaSubCoaMainAccName
        {
            get
            {
                return _nonOperateIncAccCoaSubCoaMainAccName;
            }
            set
            {
                _nonOperateIncAccCoaSubCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? NonOperateExpAcc
        {
            get
            {
                return _nonOperateExpAcc;
            }
            set
            {
                _nonOperateExpAcc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateExpAccAccName
        {
            get
            {
                return _nonOperateExpAccAccName;
            }
            set
            {
                _nonOperateExpAccAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateExpAccAccBalTypeAccBalType
        {
            get
            {
                return _nonOperateExpAccAccBalTypeAccBalType;
            }
            set
            {
                _nonOperateExpAccAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateExpAccAccCurrencyAccCurrencyName
        {
            get
            {
                return _nonOperateExpAccAccCurrencyAccCurrencyName;
            }
            set
            {
                _nonOperateExpAccAccCurrencyAccCurrencyName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateExpAccAccDestAccDest
        {
            get
            {
                return _nonOperateExpAccAccDestAccDest;
            }
            set
            {
                _nonOperateExpAccAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateExpAccAccDestCompanyTypeDescription
        {
            get
            {
                return _nonOperateExpAccAccDestCompanyTypeDescription;
            }
            set
            {
                _nonOperateExpAccAccDestCompanyTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateExpAccAccFundAccFundCode
        {
            get
            {
                return _nonOperateExpAccAccFundAccFundCode;
            }
            set
            {
                _nonOperateExpAccAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateExpAccAccSubTypeAccSubType
        {
            get
            {
                return _nonOperateExpAccAccSubTypeAccSubType;
            }
            set
            {
                _nonOperateExpAccAccSubTypeAccSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateExpAccAccTypeAccType
        {
            get
            {
                return _nonOperateExpAccAccTypeAccType;
            }
            set
            {
                _nonOperateExpAccAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateExpAccCoaControlAccName
        {
            get
            {
                return _nonOperateExpAccCoaControlAccName;
            }
            set
            {
                _nonOperateExpAccCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateExpAccCoaControlAccBalTypeAccBalType
        {
            get
            {
                return _nonOperateExpAccCoaControlAccBalTypeAccBalType;
            }
            set
            {
                _nonOperateExpAccCoaControlAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateExpAccCoaControlAccDestAccDest
        {
            get
            {
                return _nonOperateExpAccCoaControlAccDestAccDest;
            }
            set
            {
                _nonOperateExpAccCoaControlAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateExpAccCoaControlAccTypeAccType
        {
            get
            {
                return _nonOperateExpAccCoaControlAccTypeAccType;
            }
            set
            {
                _nonOperateExpAccCoaControlAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateExpAccCoaControlCompTypeDescription
        {
            get
            {
                return _nonOperateExpAccCoaControlCompTypeDescription;
            }
            set
            {
                _nonOperateExpAccCoaControlCompTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateExpAccCoaMainAccName
        {
            get
            {
                return _nonOperateExpAccCoaMainAccName;
            }
            set
            {
                _nonOperateExpAccCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateExpAccCoaMainAccBalTypeAccBalType
        {
            get
            {
                return _nonOperateExpAccCoaMainAccBalTypeAccBalType;
            }
            set
            {
                _nonOperateExpAccCoaMainAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateExpAccCoaMainAccDestAccDest
        {
            get
            {
                return _nonOperateExpAccCoaMainAccDestAccDest;
            }
            set
            {
                _nonOperateExpAccCoaMainAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateExpAccCoaMainAccFundAccFundCode
        {
            get
            {
                return _nonOperateExpAccCoaMainAccFundAccFundCode;
            }
            set
            {
                _nonOperateExpAccCoaMainAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateExpAccCoaMainAccTypeAccType
        {
            get
            {
                return _nonOperateExpAccCoaMainAccTypeAccType;
            }
            set
            {
                _nonOperateExpAccCoaMainAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateExpAccCoaMainCoaControlAccName
        {
            get
            {
                return _nonOperateExpAccCoaMainCoaControlAccName;
            }
            set
            {
                _nonOperateExpAccCoaMainCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateExpAccCoaSubAccName
        {
            get
            {
                return _nonOperateExpAccCoaSubAccName;
            }
            set
            {
                _nonOperateExpAccCoaSubAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateExpAccCoaSubAccBalTypeAccBalType
        {
            get
            {
                return _nonOperateExpAccCoaSubAccBalTypeAccBalType;
            }
            set
            {
                _nonOperateExpAccCoaSubAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateExpAccCoaSubAccDestAccDest
        {
            get
            {
                return _nonOperateExpAccCoaSubAccDestAccDest;
            }
            set
            {
                _nonOperateExpAccCoaSubAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateExpAccCoaSubAccFundAccFundCode
        {
            get
            {
                return _nonOperateExpAccCoaSubAccFundAccFundCode;
            }
            set
            {
                _nonOperateExpAccCoaSubAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateExpAccCoaSubAccTypeAccType
        {
            get
            {
                return _nonOperateExpAccCoaSubAccTypeAccType;
            }
            set
            {
                _nonOperateExpAccCoaSubAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateExpAccCoaSubCoaControlAccName
        {
            get
            {
                return _nonOperateExpAccCoaSubCoaControlAccName;
            }
            set
            {
                _nonOperateExpAccCoaSubCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NonOperateExpAccCoaSubCoaMainAccName
        {
            get
            {
                return _nonOperateExpAccCoaSubCoaMainAccName;
            }
            set
            {
                _nonOperateExpAccCoaSubCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? PrevYearPLAcc
        {
            get
            {
                return _prevYearPLAcc;
            }
            set
            {
                _prevYearPLAcc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PrevYearPLAccAccName
        {
            get
            {
                return _prevYearPLAccAccName;
            }
            set
            {
                _prevYearPLAccAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PrevYearPLAccAccBalTypeAccBalType
        {
            get
            {
                return _prevYearPLAccAccBalTypeAccBalType;
            }
            set
            {
                _prevYearPLAccAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PrevYearPLAccAccCurrencyAccCurrencyName
        {
            get
            {
                return _prevYearPLAccAccCurrencyAccCurrencyName;
            }
            set
            {
                _prevYearPLAccAccCurrencyAccCurrencyName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PrevYearPLAccAccDestAccDest
        {
            get
            {
                return _prevYearPLAccAccDestAccDest;
            }
            set
            {
                _prevYearPLAccAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PrevYearPLAccAccDestCompanyTypeDescription
        {
            get
            {
                return _prevYearPLAccAccDestCompanyTypeDescription;
            }
            set
            {
                _prevYearPLAccAccDestCompanyTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PrevYearPLAccAccFundAccFundCode
        {
            get
            {
                return _prevYearPLAccAccFundAccFundCode;
            }
            set
            {
                _prevYearPLAccAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PrevYearPLAccAccSubTypeAccSubType
        {
            get
            {
                return _prevYearPLAccAccSubTypeAccSubType;
            }
            set
            {
                _prevYearPLAccAccSubTypeAccSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PrevYearPLAccAccTypeAccType
        {
            get
            {
                return _prevYearPLAccAccTypeAccType;
            }
            set
            {
                _prevYearPLAccAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PrevYearPLAccCoaControlAccName
        {
            get
            {
                return _prevYearPLAccCoaControlAccName;
            }
            set
            {
                _prevYearPLAccCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PrevYearPLAccCoaControlAccBalTypeAccBalType
        {
            get
            {
                return _prevYearPLAccCoaControlAccBalTypeAccBalType;
            }
            set
            {
                _prevYearPLAccCoaControlAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PrevYearPLAccCoaControlAccDestAccDest
        {
            get
            {
                return _prevYearPLAccCoaControlAccDestAccDest;
            }
            set
            {
                _prevYearPLAccCoaControlAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PrevYearPLAccCoaControlAccTypeAccType
        {
            get
            {
                return _prevYearPLAccCoaControlAccTypeAccType;
            }
            set
            {
                _prevYearPLAccCoaControlAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PrevYearPLAccCoaControlCompTypeDescription
        {
            get
            {
                return _prevYearPLAccCoaControlCompTypeDescription;
            }
            set
            {
                _prevYearPLAccCoaControlCompTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PrevYearPLAccCoaMainAccName
        {
            get
            {
                return _prevYearPLAccCoaMainAccName;
            }
            set
            {
                _prevYearPLAccCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PrevYearPLAccCoaMainAccBalTypeAccBalType
        {
            get
            {
                return _prevYearPLAccCoaMainAccBalTypeAccBalType;
            }
            set
            {
                _prevYearPLAccCoaMainAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PrevYearPLAccCoaMainAccDestAccDest
        {
            get
            {
                return _prevYearPLAccCoaMainAccDestAccDest;
            }
            set
            {
                _prevYearPLAccCoaMainAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PrevYearPLAccCoaMainAccFundAccFundCode
        {
            get
            {
                return _prevYearPLAccCoaMainAccFundAccFundCode;
            }
            set
            {
                _prevYearPLAccCoaMainAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PrevYearPLAccCoaMainAccTypeAccType
        {
            get
            {
                return _prevYearPLAccCoaMainAccTypeAccType;
            }
            set
            {
                _prevYearPLAccCoaMainAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PrevYearPLAccCoaMainCoaControlAccName
        {
            get
            {
                return _prevYearPLAccCoaMainCoaControlAccName;
            }
            set
            {
                _prevYearPLAccCoaMainCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PrevYearPLAccCoaSubAccName
        {
            get
            {
                return _prevYearPLAccCoaSubAccName;
            }
            set
            {
                _prevYearPLAccCoaSubAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PrevYearPLAccCoaSubAccBalTypeAccBalType
        {
            get
            {
                return _prevYearPLAccCoaSubAccBalTypeAccBalType;
            }
            set
            {
                _prevYearPLAccCoaSubAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PrevYearPLAccCoaSubAccDestAccDest
        {
            get
            {
                return _prevYearPLAccCoaSubAccDestAccDest;
            }
            set
            {
                _prevYearPLAccCoaSubAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PrevYearPLAccCoaSubAccFundAccFundCode
        {
            get
            {
                return _prevYearPLAccCoaSubAccFundAccFundCode;
            }
            set
            {
                _prevYearPLAccCoaSubAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PrevYearPLAccCoaSubAccTypeAccType
        {
            get
            {
                return _prevYearPLAccCoaSubAccTypeAccType;
            }
            set
            {
                _prevYearPLAccCoaSubAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PrevYearPLAccCoaSubCoaControlAccName
        {
            get
            {
                return _prevYearPLAccCoaSubCoaControlAccName;
            }
            set
            {
                _prevYearPLAccCoaSubCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PrevYearPLAccCoaSubCoaMainAccName
        {
            get
            {
                return _prevYearPLAccCoaSubCoaMainAccName;
            }
            set
            {
                _prevYearPLAccCoaSubCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? CurrYearPLAcc
        {
            get
            {
                return _currYearPLAcc;
            }
            set
            {
                _currYearPLAcc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CurrYearPLAccAccName
        {
            get
            {
                return _currYearPLAccAccName;
            }
            set
            {
                _currYearPLAccAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CurrYearPLAccAccBalTypeAccBalType
        {
            get
            {
                return _currYearPLAccAccBalTypeAccBalType;
            }
            set
            {
                _currYearPLAccAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CurrYearPLAccAccCurrencyAccCurrencyName
        {
            get
            {
                return _currYearPLAccAccCurrencyAccCurrencyName;
            }
            set
            {
                _currYearPLAccAccCurrencyAccCurrencyName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CurrYearPLAccAccDestAccDest
        {
            get
            {
                return _currYearPLAccAccDestAccDest;
            }
            set
            {
                _currYearPLAccAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CurrYearPLAccAccDestCompanyTypeDescription
        {
            get
            {
                return _currYearPLAccAccDestCompanyTypeDescription;
            }
            set
            {
                _currYearPLAccAccDestCompanyTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CurrYearPLAccAccFundAccFundCode
        {
            get
            {
                return _currYearPLAccAccFundAccFundCode;
            }
            set
            {
                _currYearPLAccAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CurrYearPLAccAccSubTypeAccSubType
        {
            get
            {
                return _currYearPLAccAccSubTypeAccSubType;
            }
            set
            {
                _currYearPLAccAccSubTypeAccSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CurrYearPLAccAccTypeAccType
        {
            get
            {
                return _currYearPLAccAccTypeAccType;
            }
            set
            {
                _currYearPLAccAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CurrYearPLAccCoaControlAccName
        {
            get
            {
                return _currYearPLAccCoaControlAccName;
            }
            set
            {
                _currYearPLAccCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CurrYearPLAccCoaControlAccBalTypeAccBalType
        {
            get
            {
                return _currYearPLAccCoaControlAccBalTypeAccBalType;
            }
            set
            {
                _currYearPLAccCoaControlAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CurrYearPLAccCoaControlAccDestAccDest
        {
            get
            {
                return _currYearPLAccCoaControlAccDestAccDest;
            }
            set
            {
                _currYearPLAccCoaControlAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CurrYearPLAccCoaControlAccTypeAccType
        {
            get
            {
                return _currYearPLAccCoaControlAccTypeAccType;
            }
            set
            {
                _currYearPLAccCoaControlAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CurrYearPLAccCoaControlCompTypeDescription
        {
            get
            {
                return _currYearPLAccCoaControlCompTypeDescription;
            }
            set
            {
                _currYearPLAccCoaControlCompTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CurrYearPLAccCoaMainAccName
        {
            get
            {
                return _currYearPLAccCoaMainAccName;
            }
            set
            {
                _currYearPLAccCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CurrYearPLAccCoaMainAccBalTypeAccBalType
        {
            get
            {
                return _currYearPLAccCoaMainAccBalTypeAccBalType;
            }
            set
            {
                _currYearPLAccCoaMainAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CurrYearPLAccCoaMainAccDestAccDest
        {
            get
            {
                return _currYearPLAccCoaMainAccDestAccDest;
            }
            set
            {
                _currYearPLAccCoaMainAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CurrYearPLAccCoaMainAccFundAccFundCode
        {
            get
            {
                return _currYearPLAccCoaMainAccFundAccFundCode;
            }
            set
            {
                _currYearPLAccCoaMainAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CurrYearPLAccCoaMainAccTypeAccType
        {
            get
            {
                return _currYearPLAccCoaMainAccTypeAccType;
            }
            set
            {
                _currYearPLAccCoaMainAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CurrYearPLAccCoaMainCoaControlAccName
        {
            get
            {
                return _currYearPLAccCoaMainCoaControlAccName;
            }
            set
            {
                _currYearPLAccCoaMainCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CurrYearPLAccCoaSubAccName
        {
            get
            {
                return _currYearPLAccCoaSubAccName;
            }
            set
            {
                _currYearPLAccCoaSubAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CurrYearPLAccCoaSubAccBalTypeAccBalType
        {
            get
            {
                return _currYearPLAccCoaSubAccBalTypeAccBalType;
            }
            set
            {
                _currYearPLAccCoaSubAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CurrYearPLAccCoaSubAccDestAccDest
        {
            get
            {
                return _currYearPLAccCoaSubAccDestAccDest;
            }
            set
            {
                _currYearPLAccCoaSubAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CurrYearPLAccCoaSubAccFundAccFundCode
        {
            get
            {
                return _currYearPLAccCoaSubAccFundAccFundCode;
            }
            set
            {
                _currYearPLAccCoaSubAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CurrYearPLAccCoaSubAccTypeAccType
        {
            get
            {
                return _currYearPLAccCoaSubAccTypeAccType;
            }
            set
            {
                _currYearPLAccCoaSubAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CurrYearPLAccCoaSubCoaControlAccName
        {
            get
            {
                return _currYearPLAccCoaSubCoaControlAccName;
            }
            set
            {
                _currYearPLAccCoaSubCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CurrYearPLAccCoaSubCoaMainAccName
        {
            get
            {
                return _currYearPLAccCoaSubCoaMainAccName;
            }
            set
            {
                _currYearPLAccCoaSubCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? ChequeCCAcc
        {
            get
            {
                return _chequeCCAcc;
            }
            set
            {
                _chequeCCAcc = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.AccFundAccs> Select(
                    int? accFundAccsID, 
                    int? accFundID, 
                    string accFundAccFundCode, 
                    int? cashCode, 
                    string cashAccName, 
                    string cashAccBalTypeAccBalType, 
                    string cashAccCurrencyAccCurrencyName, 
                    string cashAccDestAccDest, 
                    string cashAccDestCompanyTypeDescription, 
                    string cashAccFundAccFundCode, 
                    string cashAccSubTypeAccSubType, 
                    string cashAccTypeAccType, 
                    string cashCoaControlAccName, 
                    string cashCoaControlAccBalTypeAccBalType, 
                    string cashCoaControlAccDestAccDest, 
                    string cashCoaControlAccTypeAccType, 
                    string cashCoaControlCompTypeDescription, 
                    string cashCoaMainAccName, 
                    string cashCoaMainAccBalTypeAccBalType, 
                    string cashCoaMainAccDestAccDest, 
                    string cashCoaMainAccFundAccFundCode, 
                    string cashCoaMainAccTypeAccType, 
                    string cashCoaMainCoaControlAccName, 
                    string cashCoaSubAccName, 
                    string cashCoaSubAccBalTypeAccBalType, 
                    string cashCoaSubAccDestAccDest, 
                    string cashCoaSubAccFundAccFundCode, 
                    string cashCoaSubAccTypeAccType, 
                    string cashCoaSubCoaControlAccName, 
                    string cashCoaSubCoaMainAccName, 
                    int? bankCode, 
                    string bankAccName, 
                    string bankAccBalTypeAccBalType, 
                    string bankAccCurrencyAccCurrencyName, 
                    string bankAccDestAccDest, 
                    string bankAccDestCompanyTypeDescription, 
                    string bankAccFundAccFundCode, 
                    string bankAccSubTypeAccSubType, 
                    string bankAccTypeAccType, 
                    string bankCoaControlAccName, 
                    string bankCoaControlAccBalTypeAccBalType, 
                    string bankCoaControlAccDestAccDest, 
                    string bankCoaControlAccTypeAccType, 
                    string bankCoaControlCompTypeDescription, 
                    string bankCoaMainAccName, 
                    string bankCoaMainAccBalTypeAccBalType, 
                    string bankCoaMainAccDestAccDest, 
                    string bankCoaMainAccFundAccFundCode, 
                    string bankCoaMainAccTypeAccType, 
                    string bankCoaMainCoaControlAccName, 
                    string bankCoaSubAccName, 
                    string bankCoaSubAccBalTypeAccBalType, 
                    string bankCoaSubAccDestAccDest, 
                    string bankCoaSubAccFundAccFundCode, 
                    string bankCoaSubAccTypeAccType, 
                    string bankCoaSubCoaControlAccName, 
                    string bankCoaSubCoaMainAccName, 
                    int? advance, 
                    string advanceAccName, 
                    string advanceAccBalTypeAccBalType, 
                    string advanceAccCurrencyAccCurrencyName, 
                    string advanceAccDestAccDest, 
                    string advanceAccDestCompanyTypeDescription, 
                    string advanceAccFundAccFundCode, 
                    string advanceAccSubTypeAccSubType, 
                    string advanceAccTypeAccType, 
                    string advanceCoaControlAccName, 
                    string advanceCoaControlAccBalTypeAccBalType, 
                    string advanceCoaControlAccDestAccDest, 
                    string advanceCoaControlAccTypeAccType, 
                    string advanceCoaControlCompTypeDescription, 
                    string advanceCoaMainAccName, 
                    string advanceCoaMainAccBalTypeAccBalType, 
                    string advanceCoaMainAccDestAccDest, 
                    string advanceCoaMainAccFundAccFundCode, 
                    string advanceCoaMainAccTypeAccType, 
                    string advanceCoaMainCoaControlAccName, 
                    string advanceCoaSubAccName, 
                    string advanceCoaSubAccBalTypeAccBalType, 
                    string advanceCoaSubAccDestAccDest, 
                    string advanceCoaSubAccFundAccFundCode, 
                    string advanceCoaSubAccTypeAccType, 
                    string advanceCoaSubCoaControlAccName, 
                    string advanceCoaSubCoaMainAccName, 
                    int? purAcc, 
                    string purAccAccName, 
                    string purAccAccBalTypeAccBalType, 
                    string purAccAccCurrencyAccCurrencyName, 
                    string purAccAccDestAccDest, 
                    string purAccAccDestCompanyTypeDescription, 
                    string purAccAccFundAccFundCode, 
                    string purAccAccSubTypeAccSubType, 
                    string purAccAccTypeAccType, 
                    string purAccCoaControlAccName, 
                    string purAccCoaControlAccBalTypeAccBalType, 
                    string purAccCoaControlAccDestAccDest, 
                    string purAccCoaControlAccTypeAccType, 
                    string purAccCoaControlCompTypeDescription, 
                    string purAccCoaMainAccName, 
                    string purAccCoaMainAccBalTypeAccBalType, 
                    string purAccCoaMainAccDestAccDest, 
                    string purAccCoaMainAccFundAccFundCode, 
                    string purAccCoaMainAccTypeAccType, 
                    string purAccCoaMainCoaControlAccName, 
                    string purAccCoaSubAccName, 
                    string purAccCoaSubAccBalTypeAccBalType, 
                    string purAccCoaSubAccDestAccDest, 
                    string purAccCoaSubAccFundAccFundCode, 
                    string purAccCoaSubAccTypeAccType, 
                    string purAccCoaSubCoaControlAccName, 
                    string purAccCoaSubCoaMainAccName, 
                    int? saleAcc, 
                    string saleAccAccName, 
                    string saleAccAccBalTypeAccBalType, 
                    string saleAccAccCurrencyAccCurrencyName, 
                    string saleAccAccDestAccDest, 
                    string saleAccAccDestCompanyTypeDescription, 
                    string saleAccAccFundAccFundCode, 
                    string saleAccAccSubTypeAccSubType, 
                    string saleAccAccTypeAccType, 
                    string saleAccCoaControlAccName, 
                    string saleAccCoaControlAccBalTypeAccBalType, 
                    string saleAccCoaControlAccDestAccDest, 
                    string saleAccCoaControlAccTypeAccType, 
                    string saleAccCoaControlCompTypeDescription, 
                    string saleAccCoaMainAccName, 
                    string saleAccCoaMainAccBalTypeAccBalType, 
                    string saleAccCoaMainAccDestAccDest, 
                    string saleAccCoaMainAccFundAccFundCode, 
                    string saleAccCoaMainAccTypeAccType, 
                    string saleAccCoaMainCoaControlAccName, 
                    string saleAccCoaSubAccName, 
                    string saleAccCoaSubAccBalTypeAccBalType, 
                    string saleAccCoaSubAccDestAccDest, 
                    string saleAccCoaSubAccFundAccFundCode, 
                    string saleAccCoaSubAccTypeAccType, 
                    string saleAccCoaSubCoaControlAccName, 
                    string saleAccCoaSubCoaMainAccName, 
                    int? workinProgressAcc, 
                    string workinProgressAccAccName, 
                    string workinProgressAccAccBalTypeAccBalType, 
                    string workinProgressAccAccCurrencyAccCurrencyName, 
                    string workinProgressAccAccDestAccDest, 
                    string workinProgressAccAccDestCompanyTypeDescription, 
                    string workinProgressAccAccFundAccFundCode, 
                    string workinProgressAccAccSubTypeAccSubType, 
                    string workinProgressAccAccTypeAccType, 
                    string workinProgressAccCoaControlAccName, 
                    string workinProgressAccCoaControlAccBalTypeAccBalType, 
                    string workinProgressAccCoaControlAccDestAccDest, 
                    string workinProgressAccCoaControlAccTypeAccType, 
                    string workinProgressAccCoaControlCompTypeDescription, 
                    string workinProgressAccCoaMainAccName, 
                    string workinProgressAccCoaMainAccBalTypeAccBalType, 
                    string workinProgressAccCoaMainAccDestAccDest, 
                    string workinProgressAccCoaMainAccFundAccFundCode, 
                    string workinProgressAccCoaMainAccTypeAccType, 
                    string workinProgressAccCoaMainCoaControlAccName, 
                    string workinProgressAccCoaSubAccName, 
                    string workinProgressAccCoaSubAccBalTypeAccBalType, 
                    string workinProgressAccCoaSubAccDestAccDest, 
                    string workinProgressAccCoaSubAccFundAccFundCode, 
                    string workinProgressAccCoaSubAccTypeAccType, 
                    string workinProgressAccCoaSubCoaControlAccName, 
                    string workinProgressAccCoaSubCoaMainAccName, 
                    int? costofSold, 
                    string costofSoldAccName, 
                    string costofSoldAccBalTypeAccBalType, 
                    string costofSoldAccCurrencyAccCurrencyName, 
                    string costofSoldAccDestAccDest, 
                    string costofSoldAccDestCompanyTypeDescription, 
                    string costofSoldAccFundAccFundCode, 
                    string costofSoldAccSubTypeAccSubType, 
                    string costofSoldAccTypeAccType, 
                    string costofSoldCoaControlAccName, 
                    string costofSoldCoaControlAccBalTypeAccBalType, 
                    string costofSoldCoaControlAccDestAccDest, 
                    string costofSoldCoaControlAccTypeAccType, 
                    string costofSoldCoaControlCompTypeDescription, 
                    string costofSoldCoaMainAccName, 
                    string costofSoldCoaMainAccBalTypeAccBalType, 
                    string costofSoldCoaMainAccDestAccDest, 
                    string costofSoldCoaMainAccFundAccFundCode, 
                    string costofSoldCoaMainAccTypeAccType, 
                    string costofSoldCoaMainCoaControlAccName, 
                    string costofSoldCoaSubAccName, 
                    string costofSoldCoaSubAccBalTypeAccBalType, 
                    string costofSoldCoaSubAccDestAccDest, 
                    string costofSoldCoaSubAccFundAccFundCode, 
                    string costofSoldCoaSubAccTypeAccType, 
                    string costofSoldCoaSubCoaControlAccName, 
                    string costofSoldCoaSubCoaMainAccName, 
                    int? oPD_Acc, 
                    string oPD_AccAccName, 
                    string oPD_AccAccBalTypeAccBalType, 
                    string oPD_AccAccCurrencyAccCurrencyName, 
                    string oPD_AccAccDestAccDest, 
                    string oPD_AccAccDestCompanyTypeDescription, 
                    string oPD_AccAccFundAccFundCode, 
                    string oPD_AccAccSubTypeAccSubType, 
                    string oPD_AccAccTypeAccType, 
                    string oPD_AccCoaControlAccName, 
                    string oPD_AccCoaControlAccBalTypeAccBalType, 
                    string oPD_AccCoaControlAccDestAccDest, 
                    string oPD_AccCoaControlAccTypeAccType, 
                    string oPD_AccCoaControlCompTypeDescription, 
                    string oPD_AccCoaMainAccName, 
                    string oPD_AccCoaMainAccBalTypeAccBalType, 
                    string oPD_AccCoaMainAccDestAccDest, 
                    string oPD_AccCoaMainAccFundAccFundCode, 
                    string oPD_AccCoaMainAccTypeAccType, 
                    string oPD_AccCoaMainCoaControlAccName, 
                    string oPD_AccCoaSubAccName, 
                    string oPD_AccCoaSubAccBalTypeAccBalType, 
                    string oPD_AccCoaSubAccDestAccDest, 
                    string oPD_AccCoaSubAccFundAccFundCode, 
                    string oPD_AccCoaSubAccTypeAccType, 
                    string oPD_AccCoaSubCoaControlAccName, 
                    string oPD_AccCoaSubCoaMainAccName, 
                    int? advPat_Acc, 
                    string advPat_AccAccName, 
                    string advPat_AccAccBalTypeAccBalType, 
                    string advPat_AccAccCurrencyAccCurrencyName, 
                    string advPat_AccAccDestAccDest, 
                    string advPat_AccAccDestCompanyTypeDescription, 
                    string advPat_AccAccFundAccFundCode, 
                    string advPat_AccAccSubTypeAccSubType, 
                    string advPat_AccAccTypeAccType, 
                    string advPat_AccCoaControlAccName, 
                    string advPat_AccCoaControlAccBalTypeAccBalType, 
                    string advPat_AccCoaControlAccDestAccDest, 
                    string advPat_AccCoaControlAccTypeAccType, 
                    string advPat_AccCoaControlCompTypeDescription, 
                    string advPat_AccCoaMainAccName, 
                    string advPat_AccCoaMainAccBalTypeAccBalType, 
                    string advPat_AccCoaMainAccDestAccDest, 
                    string advPat_AccCoaMainAccFundAccFundCode, 
                    string advPat_AccCoaMainAccTypeAccType, 
                    string advPat_AccCoaMainCoaControlAccName, 
                    string advPat_AccCoaSubAccName, 
                    string advPat_AccCoaSubAccBalTypeAccBalType, 
                    string advPat_AccCoaSubAccDestAccDest, 
                    string advPat_AccCoaSubAccFundAccFundCode, 
                    string advPat_AccCoaSubAccTypeAccType, 
                    string advPat_AccCoaSubCoaControlAccName, 
                    string advPat_AccCoaSubCoaMainAccName, 
                    int? investigate_Acc, 
                    string investigate_AccAccName, 
                    string investigate_AccAccBalTypeAccBalType, 
                    string investigate_AccAccCurrencyAccCurrencyName, 
                    string investigate_AccAccDestAccDest, 
                    string investigate_AccAccDestCompanyTypeDescription, 
                    string investigate_AccAccFundAccFundCode, 
                    string investigate_AccAccSubTypeAccSubType, 
                    string investigate_AccAccTypeAccType, 
                    string investigate_AccCoaControlAccName, 
                    string investigate_AccCoaControlAccBalTypeAccBalType, 
                    string investigate_AccCoaControlAccDestAccDest, 
                    string investigate_AccCoaControlAccTypeAccType, 
                    string investigate_AccCoaControlCompTypeDescription, 
                    string investigate_AccCoaMainAccName, 
                    string investigate_AccCoaMainAccBalTypeAccBalType, 
                    string investigate_AccCoaMainAccDestAccDest, 
                    string investigate_AccCoaMainAccFundAccFundCode, 
                    string investigate_AccCoaMainAccTypeAccType, 
                    string investigate_AccCoaMainCoaControlAccName, 
                    string investigate_AccCoaSubAccName, 
                    string investigate_AccCoaSubAccBalTypeAccBalType, 
                    string investigate_AccCoaSubAccDestAccDest, 
                    string investigate_AccCoaSubAccFundAccFundCode, 
                    string investigate_AccCoaSubAccTypeAccType, 
                    string investigate_AccCoaSubCoaControlAccName, 
                    string investigate_AccCoaSubCoaMainAccName, 
                    int? vatAcc, 
                    string vatAccAccName, 
                    string vatAccAccBalTypeAccBalType, 
                    string vatAccAccCurrencyAccCurrencyName, 
                    string vatAccAccDestAccDest, 
                    string vatAccAccDestCompanyTypeDescription, 
                    string vatAccAccFundAccFundCode, 
                    string vatAccAccSubTypeAccSubType, 
                    string vatAccAccTypeAccType, 
                    string vatAccCoaControlAccName, 
                    string vatAccCoaControlAccBalTypeAccBalType, 
                    string vatAccCoaControlAccDestAccDest, 
                    string vatAccCoaControlAccTypeAccType, 
                    string vatAccCoaControlCompTypeDescription, 
                    string vatAccCoaMainAccName, 
                    string vatAccCoaMainAccBalTypeAccBalType, 
                    string vatAccCoaMainAccDestAccDest, 
                    string vatAccCoaMainAccFundAccFundCode, 
                    string vatAccCoaMainAccTypeAccType, 
                    string vatAccCoaMainCoaControlAccName, 
                    string vatAccCoaSubAccName, 
                    string vatAccCoaSubAccBalTypeAccBalType, 
                    string vatAccCoaSubAccDestAccDest, 
                    string vatAccCoaSubAccFundAccFundCode, 
                    string vatAccCoaSubAccTypeAccType, 
                    string vatAccCoaSubCoaControlAccName, 
                    string vatAccCoaSubCoaMainAccName, 
                    int? sundryDebitors, 
                    string sundryDebitorsAccName, 
                    string sundryDebitorsAccBalTypeAccBalType, 
                    string sundryDebitorsAccCurrencyAccCurrencyName, 
                    string sundryDebitorsAccDestAccDest, 
                    string sundryDebitorsAccDestCompanyTypeDescription, 
                    string sundryDebitorsAccFundAccFundCode, 
                    string sundryDebitorsAccSubTypeAccSubType, 
                    string sundryDebitorsAccTypeAccType, 
                    string sundryDebitorsCoaControlAccName, 
                    string sundryDebitorsCoaControlAccBalTypeAccBalType, 
                    string sundryDebitorsCoaControlAccDestAccDest, 
                    string sundryDebitorsCoaControlAccTypeAccType, 
                    string sundryDebitorsCoaControlCompTypeDescription, 
                    string sundryDebitorsCoaMainAccName, 
                    string sundryDebitorsCoaMainAccBalTypeAccBalType, 
                    string sundryDebitorsCoaMainAccDestAccDest, 
                    string sundryDebitorsCoaMainAccFundAccFundCode, 
                    string sundryDebitorsCoaMainAccTypeAccType, 
                    string sundryDebitorsCoaMainCoaControlAccName, 
                    string sundryDebitorsCoaSubAccName, 
                    string sundryDebitorsCoaSubAccBalTypeAccBalType, 
                    string sundryDebitorsCoaSubAccDestAccDest, 
                    string sundryDebitorsCoaSubAccFundAccFundCode, 
                    string sundryDebitorsCoaSubAccTypeAccType, 
                    string sundryDebitorsCoaSubCoaControlAccName, 
                    string sundryDebitorsCoaSubCoaMainAccName, 
                    int? sundryCreditors, 
                    string sundryCreditorsAccName, 
                    string sundryCreditorsAccBalTypeAccBalType, 
                    string sundryCreditorsAccCurrencyAccCurrencyName, 
                    string sundryCreditorsAccDestAccDest, 
                    string sundryCreditorsAccDestCompanyTypeDescription, 
                    string sundryCreditorsAccFundAccFundCode, 
                    string sundryCreditorsAccSubTypeAccSubType, 
                    string sundryCreditorsAccTypeAccType, 
                    string sundryCreditorsCoaControlAccName, 
                    string sundryCreditorsCoaControlAccBalTypeAccBalType, 
                    string sundryCreditorsCoaControlAccDestAccDest, 
                    string sundryCreditorsCoaControlAccTypeAccType, 
                    string sundryCreditorsCoaControlCompTypeDescription, 
                    string sundryCreditorsCoaMainAccName, 
                    string sundryCreditorsCoaMainAccBalTypeAccBalType, 
                    string sundryCreditorsCoaMainAccDestAccDest, 
                    string sundryCreditorsCoaMainAccFundAccFundCode, 
                    string sundryCreditorsCoaMainAccTypeAccType, 
                    string sundryCreditorsCoaMainCoaControlAccName, 
                    string sundryCreditorsCoaSubAccName, 
                    string sundryCreditorsCoaSubAccBalTypeAccBalType, 
                    string sundryCreditorsCoaSubAccDestAccDest, 
                    string sundryCreditorsCoaSubAccFundAccFundCode, 
                    string sundryCreditorsCoaSubAccTypeAccType, 
                    string sundryCreditorsCoaSubCoaControlAccName, 
                    string sundryCreditorsCoaSubCoaMainAccName, 
                    int? rawMatAcc, 
                    string rawMatAccAccName, 
                    string rawMatAccAccBalTypeAccBalType, 
                    string rawMatAccAccCurrencyAccCurrencyName, 
                    string rawMatAccAccDestAccDest, 
                    string rawMatAccAccDestCompanyTypeDescription, 
                    string rawMatAccAccFundAccFundCode, 
                    string rawMatAccAccSubTypeAccSubType, 
                    string rawMatAccAccTypeAccType, 
                    string rawMatAccCoaControlAccName, 
                    string rawMatAccCoaControlAccBalTypeAccBalType, 
                    string rawMatAccCoaControlAccDestAccDest, 
                    string rawMatAccCoaControlAccTypeAccType, 
                    string rawMatAccCoaControlCompTypeDescription, 
                    string rawMatAccCoaMainAccName, 
                    string rawMatAccCoaMainAccBalTypeAccBalType, 
                    string rawMatAccCoaMainAccDestAccDest, 
                    string rawMatAccCoaMainAccFundAccFundCode, 
                    string rawMatAccCoaMainAccTypeAccType, 
                    string rawMatAccCoaMainCoaControlAccName, 
                    string rawMatAccCoaSubAccName, 
                    string rawMatAccCoaSubAccBalTypeAccBalType, 
                    string rawMatAccCoaSubAccDestAccDest, 
                    string rawMatAccCoaSubAccFundAccFundCode, 
                    string rawMatAccCoaSubAccTypeAccType, 
                    string rawMatAccCoaSubCoaControlAccName, 
                    string rawMatAccCoaSubCoaMainAccName, 
                    int? packMatAcc, 
                    string packMatAccAccName, 
                    string packMatAccAccBalTypeAccBalType, 
                    string packMatAccAccCurrencyAccCurrencyName, 
                    string packMatAccAccDestAccDest, 
                    string packMatAccAccDestCompanyTypeDescription, 
                    string packMatAccAccFundAccFundCode, 
                    string packMatAccAccSubTypeAccSubType, 
                    string packMatAccAccTypeAccType, 
                    string packMatAccCoaControlAccName, 
                    string packMatAccCoaControlAccBalTypeAccBalType, 
                    string packMatAccCoaControlAccDestAccDest, 
                    string packMatAccCoaControlAccTypeAccType, 
                    string packMatAccCoaControlCompTypeDescription, 
                    string packMatAccCoaMainAccName, 
                    string packMatAccCoaMainAccBalTypeAccBalType, 
                    string packMatAccCoaMainAccDestAccDest, 
                    string packMatAccCoaMainAccFundAccFundCode, 
                    string packMatAccCoaMainAccTypeAccType, 
                    string packMatAccCoaMainCoaControlAccName, 
                    string packMatAccCoaSubAccName, 
                    string packMatAccCoaSubAccBalTypeAccBalType, 
                    string packMatAccCoaSubAccDestAccDest, 
                    string packMatAccCoaSubAccFundAccFundCode, 
                    string packMatAccCoaSubAccTypeAccType, 
                    string packMatAccCoaSubCoaControlAccName, 
                    string packMatAccCoaSubCoaMainAccName, 
                    int? otherMatAcc, 
                    string otherMatAccAccName, 
                    string otherMatAccAccBalTypeAccBalType, 
                    string otherMatAccAccCurrencyAccCurrencyName, 
                    string otherMatAccAccDestAccDest, 
                    string otherMatAccAccDestCompanyTypeDescription, 
                    string otherMatAccAccFundAccFundCode, 
                    string otherMatAccAccSubTypeAccSubType, 
                    string otherMatAccAccTypeAccType, 
                    string otherMatAccCoaControlAccName, 
                    string otherMatAccCoaControlAccBalTypeAccBalType, 
                    string otherMatAccCoaControlAccDestAccDest, 
                    string otherMatAccCoaControlAccTypeAccType, 
                    string otherMatAccCoaControlCompTypeDescription, 
                    string otherMatAccCoaMainAccName, 
                    string otherMatAccCoaMainAccBalTypeAccBalType, 
                    string otherMatAccCoaMainAccDestAccDest, 
                    string otherMatAccCoaMainAccFundAccFundCode, 
                    string otherMatAccCoaMainAccTypeAccType, 
                    string otherMatAccCoaMainCoaControlAccName, 
                    string otherMatAccCoaSubAccName, 
                    string otherMatAccCoaSubAccBalTypeAccBalType, 
                    string otherMatAccCoaSubAccDestAccDest, 
                    string otherMatAccCoaSubAccFundAccFundCode, 
                    string otherMatAccCoaSubAccTypeAccType, 
                    string otherMatAccCoaSubCoaControlAccName, 
                    string otherMatAccCoaSubCoaMainAccName, 
                    int? finishMatAcc, 
                    string finishMatAccAccName, 
                    string finishMatAccAccBalTypeAccBalType, 
                    string finishMatAccAccCurrencyAccCurrencyName, 
                    string finishMatAccAccDestAccDest, 
                    string finishMatAccAccDestCompanyTypeDescription, 
                    string finishMatAccAccFundAccFundCode, 
                    string finishMatAccAccSubTypeAccSubType, 
                    string finishMatAccAccTypeAccType, 
                    string finishMatAccCoaControlAccName, 
                    string finishMatAccCoaControlAccBalTypeAccBalType, 
                    string finishMatAccCoaControlAccDestAccDest, 
                    string finishMatAccCoaControlAccTypeAccType, 
                    string finishMatAccCoaControlCompTypeDescription, 
                    string finishMatAccCoaMainAccName, 
                    string finishMatAccCoaMainAccBalTypeAccBalType, 
                    string finishMatAccCoaMainAccDestAccDest, 
                    string finishMatAccCoaMainAccFundAccFundCode, 
                    string finishMatAccCoaMainAccTypeAccType, 
                    string finishMatAccCoaMainCoaControlAccName, 
                    string finishMatAccCoaSubAccName, 
                    string finishMatAccCoaSubAccBalTypeAccBalType, 
                    string finishMatAccCoaSubAccDestAccDest, 
                    string finishMatAccCoaSubAccFundAccFundCode, 
                    string finishMatAccCoaSubAccTypeAccType, 
                    string finishMatAccCoaSubCoaControlAccName, 
                    string finishMatAccCoaSubCoaMainAccName, 
                    int? adminExpAcc, 
                    string adminExpAccAccName, 
                    string adminExpAccAccBalTypeAccBalType, 
                    string adminExpAccAccCurrencyAccCurrencyName, 
                    string adminExpAccAccDestAccDest, 
                    string adminExpAccAccDestCompanyTypeDescription, 
                    string adminExpAccAccFundAccFundCode, 
                    string adminExpAccAccSubTypeAccSubType, 
                    string adminExpAccAccTypeAccType, 
                    string adminExpAccCoaControlAccName, 
                    string adminExpAccCoaControlAccBalTypeAccBalType, 
                    string adminExpAccCoaControlAccDestAccDest, 
                    string adminExpAccCoaControlAccTypeAccType, 
                    string adminExpAccCoaControlCompTypeDescription, 
                    string adminExpAccCoaMainAccName, 
                    string adminExpAccCoaMainAccBalTypeAccBalType, 
                    string adminExpAccCoaMainAccDestAccDest, 
                    string adminExpAccCoaMainAccFundAccFundCode, 
                    string adminExpAccCoaMainAccTypeAccType, 
                    string adminExpAccCoaMainCoaControlAccName, 
                    string adminExpAccCoaSubAccName, 
                    string adminExpAccCoaSubAccBalTypeAccBalType, 
                    string adminExpAccCoaSubAccDestAccDest, 
                    string adminExpAccCoaSubAccFundAccFundCode, 
                    string adminExpAccCoaSubAccTypeAccType, 
                    string adminExpAccCoaSubCoaControlAccName, 
                    string adminExpAccCoaSubCoaMainAccName, 
                    int? sellingExpAcc, 
                    string sellingExpAccAccName, 
                    string sellingExpAccAccBalTypeAccBalType, 
                    string sellingExpAccAccCurrencyAccCurrencyName, 
                    string sellingExpAccAccDestAccDest, 
                    string sellingExpAccAccDestCompanyTypeDescription, 
                    string sellingExpAccAccFundAccFundCode, 
                    string sellingExpAccAccSubTypeAccSubType, 
                    string sellingExpAccAccTypeAccType, 
                    string sellingExpAccCoaControlAccName, 
                    string sellingExpAccCoaControlAccBalTypeAccBalType, 
                    string sellingExpAccCoaControlAccDestAccDest, 
                    string sellingExpAccCoaControlAccTypeAccType, 
                    string sellingExpAccCoaControlCompTypeDescription, 
                    string sellingExpAccCoaMainAccName, 
                    string sellingExpAccCoaMainAccBalTypeAccBalType, 
                    string sellingExpAccCoaMainAccDestAccDest, 
                    string sellingExpAccCoaMainAccFundAccFundCode, 
                    string sellingExpAccCoaMainAccTypeAccType, 
                    string sellingExpAccCoaMainCoaControlAccName, 
                    string sellingExpAccCoaSubAccName, 
                    string sellingExpAccCoaSubAccBalTypeAccBalType, 
                    string sellingExpAccCoaSubAccDestAccDest, 
                    string sellingExpAccCoaSubAccFundAccFundCode, 
                    string sellingExpAccCoaSubAccTypeAccType, 
                    string sellingExpAccCoaSubCoaControlAccName, 
                    string sellingExpAccCoaSubCoaMainAccName, 
                    int? manuExpAcc, 
                    string manuExpAccAccName, 
                    string manuExpAccAccBalTypeAccBalType, 
                    string manuExpAccAccCurrencyAccCurrencyName, 
                    string manuExpAccAccDestAccDest, 
                    string manuExpAccAccDestCompanyTypeDescription, 
                    string manuExpAccAccFundAccFundCode, 
                    string manuExpAccAccSubTypeAccSubType, 
                    string manuExpAccAccTypeAccType, 
                    string manuExpAccCoaControlAccName, 
                    string manuExpAccCoaControlAccBalTypeAccBalType, 
                    string manuExpAccCoaControlAccDestAccDest, 
                    string manuExpAccCoaControlAccTypeAccType, 
                    string manuExpAccCoaControlCompTypeDescription, 
                    string manuExpAccCoaMainAccName, 
                    string manuExpAccCoaMainAccBalTypeAccBalType, 
                    string manuExpAccCoaMainAccDestAccDest, 
                    string manuExpAccCoaMainAccFundAccFundCode, 
                    string manuExpAccCoaMainAccTypeAccType, 
                    string manuExpAccCoaMainCoaControlAccName, 
                    string manuExpAccCoaSubAccName, 
                    string manuExpAccCoaSubAccBalTypeAccBalType, 
                    string manuExpAccCoaSubAccDestAccDest, 
                    string manuExpAccCoaSubAccFundAccFundCode, 
                    string manuExpAccCoaSubAccTypeAccType, 
                    string manuExpAccCoaSubCoaControlAccName, 
                    string manuExpAccCoaSubCoaMainAccName, 
                    int? loanAcc, 
                    string loanAccAccName, 
                    string loanAccAccBalTypeAccBalType, 
                    string loanAccAccCurrencyAccCurrencyName, 
                    string loanAccAccDestAccDest, 
                    string loanAccAccDestCompanyTypeDescription, 
                    string loanAccAccFundAccFundCode, 
                    string loanAccAccSubTypeAccSubType, 
                    string loanAccAccTypeAccType, 
                    string loanAccCoaControlAccName, 
                    string loanAccCoaControlAccBalTypeAccBalType, 
                    string loanAccCoaControlAccDestAccDest, 
                    string loanAccCoaControlAccTypeAccType, 
                    string loanAccCoaControlCompTypeDescription, 
                    string loanAccCoaMainAccName, 
                    string loanAccCoaMainAccBalTypeAccBalType, 
                    string loanAccCoaMainAccDestAccDest, 
                    string loanAccCoaMainAccFundAccFundCode, 
                    string loanAccCoaMainAccTypeAccType, 
                    string loanAccCoaMainCoaControlAccName, 
                    string loanAccCoaSubAccName, 
                    string loanAccCoaSubAccBalTypeAccBalType, 
                    string loanAccCoaSubAccDestAccDest, 
                    string loanAccCoaSubAccFundAccFundCode, 
                    string loanAccCoaSubAccTypeAccType, 
                    string loanAccCoaSubCoaControlAccName, 
                    string loanAccCoaSubCoaMainAccName, 
                    int? assetDepAcc, 
                    string assetDepAccAccName, 
                    string assetDepAccAccBalTypeAccBalType, 
                    string assetDepAccAccCurrencyAccCurrencyName, 
                    string assetDepAccAccDestAccDest, 
                    string assetDepAccAccDestCompanyTypeDescription, 
                    string assetDepAccAccFundAccFundCode, 
                    string assetDepAccAccSubTypeAccSubType, 
                    string assetDepAccAccTypeAccType, 
                    string assetDepAccCoaControlAccName, 
                    string assetDepAccCoaControlAccBalTypeAccBalType, 
                    string assetDepAccCoaControlAccDestAccDest, 
                    string assetDepAccCoaControlAccTypeAccType, 
                    string assetDepAccCoaControlCompTypeDescription, 
                    string assetDepAccCoaMainAccName, 
                    string assetDepAccCoaMainAccBalTypeAccBalType, 
                    string assetDepAccCoaMainAccDestAccDest, 
                    string assetDepAccCoaMainAccFundAccFundCode, 
                    string assetDepAccCoaMainAccTypeAccType, 
                    string assetDepAccCoaMainCoaControlAccName, 
                    string assetDepAccCoaSubAccName, 
                    string assetDepAccCoaSubAccBalTypeAccBalType, 
                    string assetDepAccCoaSubAccDestAccDest, 
                    string assetDepAccCoaSubAccFundAccFundCode, 
                    string assetDepAccCoaSubAccTypeAccType, 
                    string assetDepAccCoaSubCoaControlAccName, 
                    string assetDepAccCoaSubCoaMainAccName, 
                    int? nonOperateIncAcc, 
                    string nonOperateIncAccAccName, 
                    string nonOperateIncAccAccBalTypeAccBalType, 
                    string nonOperateIncAccAccCurrencyAccCurrencyName, 
                    string nonOperateIncAccAccDestAccDest, 
                    string nonOperateIncAccAccDestCompanyTypeDescription, 
                    string nonOperateIncAccAccFundAccFundCode, 
                    string nonOperateIncAccAccSubTypeAccSubType, 
                    string nonOperateIncAccAccTypeAccType, 
                    string nonOperateIncAccCoaControlAccName, 
                    string nonOperateIncAccCoaControlAccBalTypeAccBalType, 
                    string nonOperateIncAccCoaControlAccDestAccDest, 
                    string nonOperateIncAccCoaControlAccTypeAccType, 
                    string nonOperateIncAccCoaControlCompTypeDescription, 
                    string nonOperateIncAccCoaMainAccName, 
                    string nonOperateIncAccCoaMainAccBalTypeAccBalType, 
                    string nonOperateIncAccCoaMainAccDestAccDest, 
                    string nonOperateIncAccCoaMainAccFundAccFundCode, 
                    string nonOperateIncAccCoaMainAccTypeAccType, 
                    string nonOperateIncAccCoaMainCoaControlAccName, 
                    string nonOperateIncAccCoaSubAccName, 
                    string nonOperateIncAccCoaSubAccBalTypeAccBalType, 
                    string nonOperateIncAccCoaSubAccDestAccDest, 
                    string nonOperateIncAccCoaSubAccFundAccFundCode, 
                    string nonOperateIncAccCoaSubAccTypeAccType, 
                    string nonOperateIncAccCoaSubCoaControlAccName, 
                    string nonOperateIncAccCoaSubCoaMainAccName, 
                    int? nonOperateExpAcc, 
                    string nonOperateExpAccAccName, 
                    string nonOperateExpAccAccBalTypeAccBalType, 
                    string nonOperateExpAccAccCurrencyAccCurrencyName, 
                    string nonOperateExpAccAccDestAccDest, 
                    string nonOperateExpAccAccDestCompanyTypeDescription, 
                    string nonOperateExpAccAccFundAccFundCode, 
                    string nonOperateExpAccAccSubTypeAccSubType, 
                    string nonOperateExpAccAccTypeAccType, 
                    string nonOperateExpAccCoaControlAccName, 
                    string nonOperateExpAccCoaControlAccBalTypeAccBalType, 
                    string nonOperateExpAccCoaControlAccDestAccDest, 
                    string nonOperateExpAccCoaControlAccTypeAccType, 
                    string nonOperateExpAccCoaControlCompTypeDescription, 
                    string nonOperateExpAccCoaMainAccName, 
                    string nonOperateExpAccCoaMainAccBalTypeAccBalType, 
                    string nonOperateExpAccCoaMainAccDestAccDest, 
                    string nonOperateExpAccCoaMainAccFundAccFundCode, 
                    string nonOperateExpAccCoaMainAccTypeAccType, 
                    string nonOperateExpAccCoaMainCoaControlAccName, 
                    string nonOperateExpAccCoaSubAccName, 
                    string nonOperateExpAccCoaSubAccBalTypeAccBalType, 
                    string nonOperateExpAccCoaSubAccDestAccDest, 
                    string nonOperateExpAccCoaSubAccFundAccFundCode, 
                    string nonOperateExpAccCoaSubAccTypeAccType, 
                    string nonOperateExpAccCoaSubCoaControlAccName, 
                    string nonOperateExpAccCoaSubCoaMainAccName, 
                    int? prevYearPLAcc, 
                    string prevYearPLAccAccName, 
                    string prevYearPLAccAccBalTypeAccBalType, 
                    string prevYearPLAccAccCurrencyAccCurrencyName, 
                    string prevYearPLAccAccDestAccDest, 
                    string prevYearPLAccAccDestCompanyTypeDescription, 
                    string prevYearPLAccAccFundAccFundCode, 
                    string prevYearPLAccAccSubTypeAccSubType, 
                    string prevYearPLAccAccTypeAccType, 
                    string prevYearPLAccCoaControlAccName, 
                    string prevYearPLAccCoaControlAccBalTypeAccBalType, 
                    string prevYearPLAccCoaControlAccDestAccDest, 
                    string prevYearPLAccCoaControlAccTypeAccType, 
                    string prevYearPLAccCoaControlCompTypeDescription, 
                    string prevYearPLAccCoaMainAccName, 
                    string prevYearPLAccCoaMainAccBalTypeAccBalType, 
                    string prevYearPLAccCoaMainAccDestAccDest, 
                    string prevYearPLAccCoaMainAccFundAccFundCode, 
                    string prevYearPLAccCoaMainAccTypeAccType, 
                    string prevYearPLAccCoaMainCoaControlAccName, 
                    string prevYearPLAccCoaSubAccName, 
                    string prevYearPLAccCoaSubAccBalTypeAccBalType, 
                    string prevYearPLAccCoaSubAccDestAccDest, 
                    string prevYearPLAccCoaSubAccFundAccFundCode, 
                    string prevYearPLAccCoaSubAccTypeAccType, 
                    string prevYearPLAccCoaSubCoaControlAccName, 
                    string prevYearPLAccCoaSubCoaMainAccName, 
                    int? currYearPLAcc, 
                    string currYearPLAccAccName, 
                    string currYearPLAccAccBalTypeAccBalType, 
                    string currYearPLAccAccCurrencyAccCurrencyName, 
                    string currYearPLAccAccDestAccDest, 
                    string currYearPLAccAccDestCompanyTypeDescription, 
                    string currYearPLAccAccFundAccFundCode, 
                    string currYearPLAccAccSubTypeAccSubType, 
                    string currYearPLAccAccTypeAccType, 
                    string currYearPLAccCoaControlAccName, 
                    string currYearPLAccCoaControlAccBalTypeAccBalType, 
                    string currYearPLAccCoaControlAccDestAccDest, 
                    string currYearPLAccCoaControlAccTypeAccType, 
                    string currYearPLAccCoaControlCompTypeDescription, 
                    string currYearPLAccCoaMainAccName, 
                    string currYearPLAccCoaMainAccBalTypeAccBalType, 
                    string currYearPLAccCoaMainAccDestAccDest, 
                    string currYearPLAccCoaMainAccFundAccFundCode, 
                    string currYearPLAccCoaMainAccTypeAccType, 
                    string currYearPLAccCoaMainCoaControlAccName, 
                    string currYearPLAccCoaSubAccName, 
                    string currYearPLAccCoaSubAccBalTypeAccBalType, 
                    string currYearPLAccCoaSubAccDestAccDest, 
                    string currYearPLAccCoaSubAccFundAccFundCode, 
                    string currYearPLAccCoaSubAccTypeAccType, 
                    string currYearPLAccCoaSubCoaControlAccName, 
                    string currYearPLAccCoaSubCoaMainAccName, 
                    int? chequeCCAcc)
        {
            return new AccFundAccsFactory().Select(accFundAccsID, accFundID, accFundAccFundCode, cashCode, cashAccName, cashAccBalTypeAccBalType, cashAccCurrencyAccCurrencyName, cashAccDestAccDest, cashAccDestCompanyTypeDescription, cashAccFundAccFundCode, cashAccSubTypeAccSubType, cashAccTypeAccType, cashCoaControlAccName, cashCoaControlAccBalTypeAccBalType, cashCoaControlAccDestAccDest, cashCoaControlAccTypeAccType, cashCoaControlCompTypeDescription, cashCoaMainAccName, cashCoaMainAccBalTypeAccBalType, cashCoaMainAccDestAccDest, cashCoaMainAccFundAccFundCode, cashCoaMainAccTypeAccType, cashCoaMainCoaControlAccName, cashCoaSubAccName, cashCoaSubAccBalTypeAccBalType, cashCoaSubAccDestAccDest, cashCoaSubAccFundAccFundCode, cashCoaSubAccTypeAccType, cashCoaSubCoaControlAccName, cashCoaSubCoaMainAccName, bankCode, bankAccName, bankAccBalTypeAccBalType, bankAccCurrencyAccCurrencyName, bankAccDestAccDest, bankAccDestCompanyTypeDescription, bankAccFundAccFundCode, bankAccSubTypeAccSubType, bankAccTypeAccType, bankCoaControlAccName, bankCoaControlAccBalTypeAccBalType, bankCoaControlAccDestAccDest, bankCoaControlAccTypeAccType, bankCoaControlCompTypeDescription, bankCoaMainAccName, bankCoaMainAccBalTypeAccBalType, bankCoaMainAccDestAccDest, bankCoaMainAccFundAccFundCode, bankCoaMainAccTypeAccType, bankCoaMainCoaControlAccName, bankCoaSubAccName, bankCoaSubAccBalTypeAccBalType, bankCoaSubAccDestAccDest, bankCoaSubAccFundAccFundCode, bankCoaSubAccTypeAccType, bankCoaSubCoaControlAccName, bankCoaSubCoaMainAccName, advance, advanceAccName, advanceAccBalTypeAccBalType, advanceAccCurrencyAccCurrencyName, advanceAccDestAccDest, advanceAccDestCompanyTypeDescription, advanceAccFundAccFundCode, advanceAccSubTypeAccSubType, advanceAccTypeAccType, advanceCoaControlAccName, advanceCoaControlAccBalTypeAccBalType, advanceCoaControlAccDestAccDest, advanceCoaControlAccTypeAccType, advanceCoaControlCompTypeDescription, advanceCoaMainAccName, advanceCoaMainAccBalTypeAccBalType, advanceCoaMainAccDestAccDest, advanceCoaMainAccFundAccFundCode, advanceCoaMainAccTypeAccType, advanceCoaMainCoaControlAccName, advanceCoaSubAccName, advanceCoaSubAccBalTypeAccBalType, advanceCoaSubAccDestAccDest, advanceCoaSubAccFundAccFundCode, advanceCoaSubAccTypeAccType, advanceCoaSubCoaControlAccName, advanceCoaSubCoaMainAccName, purAcc, purAccAccName, purAccAccBalTypeAccBalType, purAccAccCurrencyAccCurrencyName, purAccAccDestAccDest, purAccAccDestCompanyTypeDescription, purAccAccFundAccFundCode, purAccAccSubTypeAccSubType, purAccAccTypeAccType, purAccCoaControlAccName, purAccCoaControlAccBalTypeAccBalType, purAccCoaControlAccDestAccDest, purAccCoaControlAccTypeAccType, purAccCoaControlCompTypeDescription, purAccCoaMainAccName, purAccCoaMainAccBalTypeAccBalType, purAccCoaMainAccDestAccDest, purAccCoaMainAccFundAccFundCode, purAccCoaMainAccTypeAccType, purAccCoaMainCoaControlAccName, purAccCoaSubAccName, purAccCoaSubAccBalTypeAccBalType, purAccCoaSubAccDestAccDest, purAccCoaSubAccFundAccFundCode, purAccCoaSubAccTypeAccType, purAccCoaSubCoaControlAccName, purAccCoaSubCoaMainAccName, saleAcc, saleAccAccName, saleAccAccBalTypeAccBalType, saleAccAccCurrencyAccCurrencyName, saleAccAccDestAccDest, saleAccAccDestCompanyTypeDescription, saleAccAccFundAccFundCode, saleAccAccSubTypeAccSubType, saleAccAccTypeAccType, saleAccCoaControlAccName, saleAccCoaControlAccBalTypeAccBalType, saleAccCoaControlAccDestAccDest, saleAccCoaControlAccTypeAccType, saleAccCoaControlCompTypeDescription, saleAccCoaMainAccName, saleAccCoaMainAccBalTypeAccBalType, saleAccCoaMainAccDestAccDest, saleAccCoaMainAccFundAccFundCode, saleAccCoaMainAccTypeAccType, saleAccCoaMainCoaControlAccName, saleAccCoaSubAccName, saleAccCoaSubAccBalTypeAccBalType, saleAccCoaSubAccDestAccDest, saleAccCoaSubAccFundAccFundCode, saleAccCoaSubAccTypeAccType, saleAccCoaSubCoaControlAccName, saleAccCoaSubCoaMainAccName, workinProgressAcc, workinProgressAccAccName, workinProgressAccAccBalTypeAccBalType, workinProgressAccAccCurrencyAccCurrencyName, workinProgressAccAccDestAccDest, workinProgressAccAccDestCompanyTypeDescription, workinProgressAccAccFundAccFundCode, workinProgressAccAccSubTypeAccSubType, workinProgressAccAccTypeAccType, workinProgressAccCoaControlAccName, workinProgressAccCoaControlAccBalTypeAccBalType, workinProgressAccCoaControlAccDestAccDest, workinProgressAccCoaControlAccTypeAccType, workinProgressAccCoaControlCompTypeDescription, workinProgressAccCoaMainAccName, workinProgressAccCoaMainAccBalTypeAccBalType, workinProgressAccCoaMainAccDestAccDest, workinProgressAccCoaMainAccFundAccFundCode, workinProgressAccCoaMainAccTypeAccType, workinProgressAccCoaMainCoaControlAccName, workinProgressAccCoaSubAccName, workinProgressAccCoaSubAccBalTypeAccBalType, workinProgressAccCoaSubAccDestAccDest, workinProgressAccCoaSubAccFundAccFundCode, workinProgressAccCoaSubAccTypeAccType, workinProgressAccCoaSubCoaControlAccName, workinProgressAccCoaSubCoaMainAccName, costofSold, costofSoldAccName, costofSoldAccBalTypeAccBalType, costofSoldAccCurrencyAccCurrencyName, costofSoldAccDestAccDest, costofSoldAccDestCompanyTypeDescription, costofSoldAccFundAccFundCode, costofSoldAccSubTypeAccSubType, costofSoldAccTypeAccType, costofSoldCoaControlAccName, costofSoldCoaControlAccBalTypeAccBalType, costofSoldCoaControlAccDestAccDest, costofSoldCoaControlAccTypeAccType, costofSoldCoaControlCompTypeDescription, costofSoldCoaMainAccName, costofSoldCoaMainAccBalTypeAccBalType, costofSoldCoaMainAccDestAccDest, costofSoldCoaMainAccFundAccFundCode, costofSoldCoaMainAccTypeAccType, costofSoldCoaMainCoaControlAccName, costofSoldCoaSubAccName, costofSoldCoaSubAccBalTypeAccBalType, costofSoldCoaSubAccDestAccDest, costofSoldCoaSubAccFundAccFundCode, costofSoldCoaSubAccTypeAccType, costofSoldCoaSubCoaControlAccName, costofSoldCoaSubCoaMainAccName, oPD_Acc, oPD_AccAccName, oPD_AccAccBalTypeAccBalType, oPD_AccAccCurrencyAccCurrencyName, oPD_AccAccDestAccDest, oPD_AccAccDestCompanyTypeDescription, oPD_AccAccFundAccFundCode, oPD_AccAccSubTypeAccSubType, oPD_AccAccTypeAccType, oPD_AccCoaControlAccName, oPD_AccCoaControlAccBalTypeAccBalType, oPD_AccCoaControlAccDestAccDest, oPD_AccCoaControlAccTypeAccType, oPD_AccCoaControlCompTypeDescription, oPD_AccCoaMainAccName, oPD_AccCoaMainAccBalTypeAccBalType, oPD_AccCoaMainAccDestAccDest, oPD_AccCoaMainAccFundAccFundCode, oPD_AccCoaMainAccTypeAccType, oPD_AccCoaMainCoaControlAccName, oPD_AccCoaSubAccName, oPD_AccCoaSubAccBalTypeAccBalType, oPD_AccCoaSubAccDestAccDest, oPD_AccCoaSubAccFundAccFundCode, oPD_AccCoaSubAccTypeAccType, oPD_AccCoaSubCoaControlAccName, oPD_AccCoaSubCoaMainAccName, advPat_Acc, advPat_AccAccName, advPat_AccAccBalTypeAccBalType, advPat_AccAccCurrencyAccCurrencyName, advPat_AccAccDestAccDest, advPat_AccAccDestCompanyTypeDescription, advPat_AccAccFundAccFundCode, advPat_AccAccSubTypeAccSubType, advPat_AccAccTypeAccType, advPat_AccCoaControlAccName, advPat_AccCoaControlAccBalTypeAccBalType, advPat_AccCoaControlAccDestAccDest, advPat_AccCoaControlAccTypeAccType, advPat_AccCoaControlCompTypeDescription, advPat_AccCoaMainAccName, advPat_AccCoaMainAccBalTypeAccBalType, advPat_AccCoaMainAccDestAccDest, advPat_AccCoaMainAccFundAccFundCode, advPat_AccCoaMainAccTypeAccType, advPat_AccCoaMainCoaControlAccName, advPat_AccCoaSubAccName, advPat_AccCoaSubAccBalTypeAccBalType, advPat_AccCoaSubAccDestAccDest, advPat_AccCoaSubAccFundAccFundCode, advPat_AccCoaSubAccTypeAccType, advPat_AccCoaSubCoaControlAccName, advPat_AccCoaSubCoaMainAccName, investigate_Acc, investigate_AccAccName, investigate_AccAccBalTypeAccBalType, investigate_AccAccCurrencyAccCurrencyName, investigate_AccAccDestAccDest, investigate_AccAccDestCompanyTypeDescription, investigate_AccAccFundAccFundCode, investigate_AccAccSubTypeAccSubType, investigate_AccAccTypeAccType, investigate_AccCoaControlAccName, investigate_AccCoaControlAccBalTypeAccBalType, investigate_AccCoaControlAccDestAccDest, investigate_AccCoaControlAccTypeAccType, investigate_AccCoaControlCompTypeDescription, investigate_AccCoaMainAccName, investigate_AccCoaMainAccBalTypeAccBalType, investigate_AccCoaMainAccDestAccDest, investigate_AccCoaMainAccFundAccFundCode, investigate_AccCoaMainAccTypeAccType, investigate_AccCoaMainCoaControlAccName, investigate_AccCoaSubAccName, investigate_AccCoaSubAccBalTypeAccBalType, investigate_AccCoaSubAccDestAccDest, investigate_AccCoaSubAccFundAccFundCode, investigate_AccCoaSubAccTypeAccType, investigate_AccCoaSubCoaControlAccName, investigate_AccCoaSubCoaMainAccName, vatAcc, vatAccAccName, vatAccAccBalTypeAccBalType, vatAccAccCurrencyAccCurrencyName, vatAccAccDestAccDest, vatAccAccDestCompanyTypeDescription, vatAccAccFundAccFundCode, vatAccAccSubTypeAccSubType, vatAccAccTypeAccType, vatAccCoaControlAccName, vatAccCoaControlAccBalTypeAccBalType, vatAccCoaControlAccDestAccDest, vatAccCoaControlAccTypeAccType, vatAccCoaControlCompTypeDescription, vatAccCoaMainAccName, vatAccCoaMainAccBalTypeAccBalType, vatAccCoaMainAccDestAccDest, vatAccCoaMainAccFundAccFundCode, vatAccCoaMainAccTypeAccType, vatAccCoaMainCoaControlAccName, vatAccCoaSubAccName, vatAccCoaSubAccBalTypeAccBalType, vatAccCoaSubAccDestAccDest, vatAccCoaSubAccFundAccFundCode, vatAccCoaSubAccTypeAccType, vatAccCoaSubCoaControlAccName, vatAccCoaSubCoaMainAccName, sundryDebitors, sundryDebitorsAccName, sundryDebitorsAccBalTypeAccBalType, sundryDebitorsAccCurrencyAccCurrencyName, sundryDebitorsAccDestAccDest, sundryDebitorsAccDestCompanyTypeDescription, sundryDebitorsAccFundAccFundCode, sundryDebitorsAccSubTypeAccSubType, sundryDebitorsAccTypeAccType, sundryDebitorsCoaControlAccName, sundryDebitorsCoaControlAccBalTypeAccBalType, sundryDebitorsCoaControlAccDestAccDest, sundryDebitorsCoaControlAccTypeAccType, sundryDebitorsCoaControlCompTypeDescription, sundryDebitorsCoaMainAccName, sundryDebitorsCoaMainAccBalTypeAccBalType, sundryDebitorsCoaMainAccDestAccDest, sundryDebitorsCoaMainAccFundAccFundCode, sundryDebitorsCoaMainAccTypeAccType, sundryDebitorsCoaMainCoaControlAccName, sundryDebitorsCoaSubAccName, sundryDebitorsCoaSubAccBalTypeAccBalType, sundryDebitorsCoaSubAccDestAccDest, sundryDebitorsCoaSubAccFundAccFundCode, sundryDebitorsCoaSubAccTypeAccType, sundryDebitorsCoaSubCoaControlAccName, sundryDebitorsCoaSubCoaMainAccName, sundryCreditors, sundryCreditorsAccName, sundryCreditorsAccBalTypeAccBalType, sundryCreditorsAccCurrencyAccCurrencyName, sundryCreditorsAccDestAccDest, sundryCreditorsAccDestCompanyTypeDescription, sundryCreditorsAccFundAccFundCode, sundryCreditorsAccSubTypeAccSubType, sundryCreditorsAccTypeAccType, sundryCreditorsCoaControlAccName, sundryCreditorsCoaControlAccBalTypeAccBalType, sundryCreditorsCoaControlAccDestAccDest, sundryCreditorsCoaControlAccTypeAccType, sundryCreditorsCoaControlCompTypeDescription, sundryCreditorsCoaMainAccName, sundryCreditorsCoaMainAccBalTypeAccBalType, sundryCreditorsCoaMainAccDestAccDest, sundryCreditorsCoaMainAccFundAccFundCode, sundryCreditorsCoaMainAccTypeAccType, sundryCreditorsCoaMainCoaControlAccName, sundryCreditorsCoaSubAccName, sundryCreditorsCoaSubAccBalTypeAccBalType, sundryCreditorsCoaSubAccDestAccDest, sundryCreditorsCoaSubAccFundAccFundCode, sundryCreditorsCoaSubAccTypeAccType, sundryCreditorsCoaSubCoaControlAccName, sundryCreditorsCoaSubCoaMainAccName, rawMatAcc, rawMatAccAccName, rawMatAccAccBalTypeAccBalType, rawMatAccAccCurrencyAccCurrencyName, rawMatAccAccDestAccDest, rawMatAccAccDestCompanyTypeDescription, rawMatAccAccFundAccFundCode, rawMatAccAccSubTypeAccSubType, rawMatAccAccTypeAccType, rawMatAccCoaControlAccName, rawMatAccCoaControlAccBalTypeAccBalType, rawMatAccCoaControlAccDestAccDest, rawMatAccCoaControlAccTypeAccType, rawMatAccCoaControlCompTypeDescription, rawMatAccCoaMainAccName, rawMatAccCoaMainAccBalTypeAccBalType, rawMatAccCoaMainAccDestAccDest, rawMatAccCoaMainAccFundAccFundCode, rawMatAccCoaMainAccTypeAccType, rawMatAccCoaMainCoaControlAccName, rawMatAccCoaSubAccName, rawMatAccCoaSubAccBalTypeAccBalType, rawMatAccCoaSubAccDestAccDest, rawMatAccCoaSubAccFundAccFundCode, rawMatAccCoaSubAccTypeAccType, rawMatAccCoaSubCoaControlAccName, rawMatAccCoaSubCoaMainAccName, packMatAcc, packMatAccAccName, packMatAccAccBalTypeAccBalType, packMatAccAccCurrencyAccCurrencyName, packMatAccAccDestAccDest, packMatAccAccDestCompanyTypeDescription, packMatAccAccFundAccFundCode, packMatAccAccSubTypeAccSubType, packMatAccAccTypeAccType, packMatAccCoaControlAccName, packMatAccCoaControlAccBalTypeAccBalType, packMatAccCoaControlAccDestAccDest, packMatAccCoaControlAccTypeAccType, packMatAccCoaControlCompTypeDescription, packMatAccCoaMainAccName, packMatAccCoaMainAccBalTypeAccBalType, packMatAccCoaMainAccDestAccDest, packMatAccCoaMainAccFundAccFundCode, packMatAccCoaMainAccTypeAccType, packMatAccCoaMainCoaControlAccName, packMatAccCoaSubAccName, packMatAccCoaSubAccBalTypeAccBalType, packMatAccCoaSubAccDestAccDest, packMatAccCoaSubAccFundAccFundCode, packMatAccCoaSubAccTypeAccType, packMatAccCoaSubCoaControlAccName, packMatAccCoaSubCoaMainAccName, otherMatAcc, otherMatAccAccName, otherMatAccAccBalTypeAccBalType, otherMatAccAccCurrencyAccCurrencyName, otherMatAccAccDestAccDest, otherMatAccAccDestCompanyTypeDescription, otherMatAccAccFundAccFundCode, otherMatAccAccSubTypeAccSubType, otherMatAccAccTypeAccType, otherMatAccCoaControlAccName, otherMatAccCoaControlAccBalTypeAccBalType, otherMatAccCoaControlAccDestAccDest, otherMatAccCoaControlAccTypeAccType, otherMatAccCoaControlCompTypeDescription, otherMatAccCoaMainAccName, otherMatAccCoaMainAccBalTypeAccBalType, otherMatAccCoaMainAccDestAccDest, otherMatAccCoaMainAccFundAccFundCode, otherMatAccCoaMainAccTypeAccType, otherMatAccCoaMainCoaControlAccName, otherMatAccCoaSubAccName, otherMatAccCoaSubAccBalTypeAccBalType, otherMatAccCoaSubAccDestAccDest, otherMatAccCoaSubAccFundAccFundCode, otherMatAccCoaSubAccTypeAccType, otherMatAccCoaSubCoaControlAccName, otherMatAccCoaSubCoaMainAccName, finishMatAcc, finishMatAccAccName, finishMatAccAccBalTypeAccBalType, finishMatAccAccCurrencyAccCurrencyName, finishMatAccAccDestAccDest, finishMatAccAccDestCompanyTypeDescription, finishMatAccAccFundAccFundCode, finishMatAccAccSubTypeAccSubType, finishMatAccAccTypeAccType, finishMatAccCoaControlAccName, finishMatAccCoaControlAccBalTypeAccBalType, finishMatAccCoaControlAccDestAccDest, finishMatAccCoaControlAccTypeAccType, finishMatAccCoaControlCompTypeDescription, finishMatAccCoaMainAccName, finishMatAccCoaMainAccBalTypeAccBalType, finishMatAccCoaMainAccDestAccDest, finishMatAccCoaMainAccFundAccFundCode, finishMatAccCoaMainAccTypeAccType, finishMatAccCoaMainCoaControlAccName, finishMatAccCoaSubAccName, finishMatAccCoaSubAccBalTypeAccBalType, finishMatAccCoaSubAccDestAccDest, finishMatAccCoaSubAccFundAccFundCode, finishMatAccCoaSubAccTypeAccType, finishMatAccCoaSubCoaControlAccName, finishMatAccCoaSubCoaMainAccName, adminExpAcc, adminExpAccAccName, adminExpAccAccBalTypeAccBalType, adminExpAccAccCurrencyAccCurrencyName, adminExpAccAccDestAccDest, adminExpAccAccDestCompanyTypeDescription, adminExpAccAccFundAccFundCode, adminExpAccAccSubTypeAccSubType, adminExpAccAccTypeAccType, adminExpAccCoaControlAccName, adminExpAccCoaControlAccBalTypeAccBalType, adminExpAccCoaControlAccDestAccDest, adminExpAccCoaControlAccTypeAccType, adminExpAccCoaControlCompTypeDescription, adminExpAccCoaMainAccName, adminExpAccCoaMainAccBalTypeAccBalType, adminExpAccCoaMainAccDestAccDest, adminExpAccCoaMainAccFundAccFundCode, adminExpAccCoaMainAccTypeAccType, adminExpAccCoaMainCoaControlAccName, adminExpAccCoaSubAccName, adminExpAccCoaSubAccBalTypeAccBalType, adminExpAccCoaSubAccDestAccDest, adminExpAccCoaSubAccFundAccFundCode, adminExpAccCoaSubAccTypeAccType, adminExpAccCoaSubCoaControlAccName, adminExpAccCoaSubCoaMainAccName, sellingExpAcc, sellingExpAccAccName, sellingExpAccAccBalTypeAccBalType, sellingExpAccAccCurrencyAccCurrencyName, sellingExpAccAccDestAccDest, sellingExpAccAccDestCompanyTypeDescription, sellingExpAccAccFundAccFundCode, sellingExpAccAccSubTypeAccSubType, sellingExpAccAccTypeAccType, sellingExpAccCoaControlAccName, sellingExpAccCoaControlAccBalTypeAccBalType, sellingExpAccCoaControlAccDestAccDest, sellingExpAccCoaControlAccTypeAccType, sellingExpAccCoaControlCompTypeDescription, sellingExpAccCoaMainAccName, sellingExpAccCoaMainAccBalTypeAccBalType, sellingExpAccCoaMainAccDestAccDest, sellingExpAccCoaMainAccFundAccFundCode, sellingExpAccCoaMainAccTypeAccType, sellingExpAccCoaMainCoaControlAccName, sellingExpAccCoaSubAccName, sellingExpAccCoaSubAccBalTypeAccBalType, sellingExpAccCoaSubAccDestAccDest, sellingExpAccCoaSubAccFundAccFundCode, sellingExpAccCoaSubAccTypeAccType, sellingExpAccCoaSubCoaControlAccName, sellingExpAccCoaSubCoaMainAccName, manuExpAcc, manuExpAccAccName, manuExpAccAccBalTypeAccBalType, manuExpAccAccCurrencyAccCurrencyName, manuExpAccAccDestAccDest, manuExpAccAccDestCompanyTypeDescription, manuExpAccAccFundAccFundCode, manuExpAccAccSubTypeAccSubType, manuExpAccAccTypeAccType, manuExpAccCoaControlAccName, manuExpAccCoaControlAccBalTypeAccBalType, manuExpAccCoaControlAccDestAccDest, manuExpAccCoaControlAccTypeAccType, manuExpAccCoaControlCompTypeDescription, manuExpAccCoaMainAccName, manuExpAccCoaMainAccBalTypeAccBalType, manuExpAccCoaMainAccDestAccDest, manuExpAccCoaMainAccFundAccFundCode, manuExpAccCoaMainAccTypeAccType, manuExpAccCoaMainCoaControlAccName, manuExpAccCoaSubAccName, manuExpAccCoaSubAccBalTypeAccBalType, manuExpAccCoaSubAccDestAccDest, manuExpAccCoaSubAccFundAccFundCode, manuExpAccCoaSubAccTypeAccType, manuExpAccCoaSubCoaControlAccName, manuExpAccCoaSubCoaMainAccName, loanAcc, loanAccAccName, loanAccAccBalTypeAccBalType, loanAccAccCurrencyAccCurrencyName, loanAccAccDestAccDest, loanAccAccDestCompanyTypeDescription, loanAccAccFundAccFundCode, loanAccAccSubTypeAccSubType, loanAccAccTypeAccType, loanAccCoaControlAccName, loanAccCoaControlAccBalTypeAccBalType, loanAccCoaControlAccDestAccDest, loanAccCoaControlAccTypeAccType, loanAccCoaControlCompTypeDescription, loanAccCoaMainAccName, loanAccCoaMainAccBalTypeAccBalType, loanAccCoaMainAccDestAccDest, loanAccCoaMainAccFundAccFundCode, loanAccCoaMainAccTypeAccType, loanAccCoaMainCoaControlAccName, loanAccCoaSubAccName, loanAccCoaSubAccBalTypeAccBalType, loanAccCoaSubAccDestAccDest, loanAccCoaSubAccFundAccFundCode, loanAccCoaSubAccTypeAccType, loanAccCoaSubCoaControlAccName, loanAccCoaSubCoaMainAccName, assetDepAcc, assetDepAccAccName, assetDepAccAccBalTypeAccBalType, assetDepAccAccCurrencyAccCurrencyName, assetDepAccAccDestAccDest, assetDepAccAccDestCompanyTypeDescription, assetDepAccAccFundAccFundCode, assetDepAccAccSubTypeAccSubType, assetDepAccAccTypeAccType, assetDepAccCoaControlAccName, assetDepAccCoaControlAccBalTypeAccBalType, assetDepAccCoaControlAccDestAccDest, assetDepAccCoaControlAccTypeAccType, assetDepAccCoaControlCompTypeDescription, assetDepAccCoaMainAccName, assetDepAccCoaMainAccBalTypeAccBalType, assetDepAccCoaMainAccDestAccDest, assetDepAccCoaMainAccFundAccFundCode, assetDepAccCoaMainAccTypeAccType, assetDepAccCoaMainCoaControlAccName, assetDepAccCoaSubAccName, assetDepAccCoaSubAccBalTypeAccBalType, assetDepAccCoaSubAccDestAccDest, assetDepAccCoaSubAccFundAccFundCode, assetDepAccCoaSubAccTypeAccType, assetDepAccCoaSubCoaControlAccName, assetDepAccCoaSubCoaMainAccName, nonOperateIncAcc, nonOperateIncAccAccName, nonOperateIncAccAccBalTypeAccBalType, nonOperateIncAccAccCurrencyAccCurrencyName, nonOperateIncAccAccDestAccDest, nonOperateIncAccAccDestCompanyTypeDescription, nonOperateIncAccAccFundAccFundCode, nonOperateIncAccAccSubTypeAccSubType, nonOperateIncAccAccTypeAccType, nonOperateIncAccCoaControlAccName, nonOperateIncAccCoaControlAccBalTypeAccBalType, nonOperateIncAccCoaControlAccDestAccDest, nonOperateIncAccCoaControlAccTypeAccType, nonOperateIncAccCoaControlCompTypeDescription, nonOperateIncAccCoaMainAccName, nonOperateIncAccCoaMainAccBalTypeAccBalType, nonOperateIncAccCoaMainAccDestAccDest, nonOperateIncAccCoaMainAccFundAccFundCode, nonOperateIncAccCoaMainAccTypeAccType, nonOperateIncAccCoaMainCoaControlAccName, nonOperateIncAccCoaSubAccName, nonOperateIncAccCoaSubAccBalTypeAccBalType, nonOperateIncAccCoaSubAccDestAccDest, nonOperateIncAccCoaSubAccFundAccFundCode, nonOperateIncAccCoaSubAccTypeAccType, nonOperateIncAccCoaSubCoaControlAccName, nonOperateIncAccCoaSubCoaMainAccName, nonOperateExpAcc, nonOperateExpAccAccName, nonOperateExpAccAccBalTypeAccBalType, nonOperateExpAccAccCurrencyAccCurrencyName, nonOperateExpAccAccDestAccDest, nonOperateExpAccAccDestCompanyTypeDescription, nonOperateExpAccAccFundAccFundCode, nonOperateExpAccAccSubTypeAccSubType, nonOperateExpAccAccTypeAccType, nonOperateExpAccCoaControlAccName, nonOperateExpAccCoaControlAccBalTypeAccBalType, nonOperateExpAccCoaControlAccDestAccDest, nonOperateExpAccCoaControlAccTypeAccType, nonOperateExpAccCoaControlCompTypeDescription, nonOperateExpAccCoaMainAccName, nonOperateExpAccCoaMainAccBalTypeAccBalType, nonOperateExpAccCoaMainAccDestAccDest, nonOperateExpAccCoaMainAccFundAccFundCode, nonOperateExpAccCoaMainAccTypeAccType, nonOperateExpAccCoaMainCoaControlAccName, nonOperateExpAccCoaSubAccName, nonOperateExpAccCoaSubAccBalTypeAccBalType, nonOperateExpAccCoaSubAccDestAccDest, nonOperateExpAccCoaSubAccFundAccFundCode, nonOperateExpAccCoaSubAccTypeAccType, nonOperateExpAccCoaSubCoaControlAccName, nonOperateExpAccCoaSubCoaMainAccName, prevYearPLAcc, prevYearPLAccAccName, prevYearPLAccAccBalTypeAccBalType, prevYearPLAccAccCurrencyAccCurrencyName, prevYearPLAccAccDestAccDest, prevYearPLAccAccDestCompanyTypeDescription, prevYearPLAccAccFundAccFundCode, prevYearPLAccAccSubTypeAccSubType, prevYearPLAccAccTypeAccType, prevYearPLAccCoaControlAccName, prevYearPLAccCoaControlAccBalTypeAccBalType, prevYearPLAccCoaControlAccDestAccDest, prevYearPLAccCoaControlAccTypeAccType, prevYearPLAccCoaControlCompTypeDescription, prevYearPLAccCoaMainAccName, prevYearPLAccCoaMainAccBalTypeAccBalType, prevYearPLAccCoaMainAccDestAccDest, prevYearPLAccCoaMainAccFundAccFundCode, prevYearPLAccCoaMainAccTypeAccType, prevYearPLAccCoaMainCoaControlAccName, prevYearPLAccCoaSubAccName, prevYearPLAccCoaSubAccBalTypeAccBalType, prevYearPLAccCoaSubAccDestAccDest, prevYearPLAccCoaSubAccFundAccFundCode, prevYearPLAccCoaSubAccTypeAccType, prevYearPLAccCoaSubCoaControlAccName, prevYearPLAccCoaSubCoaMainAccName, currYearPLAcc, currYearPLAccAccName, currYearPLAccAccBalTypeAccBalType, currYearPLAccAccCurrencyAccCurrencyName, currYearPLAccAccDestAccDest, currYearPLAccAccDestCompanyTypeDescription, currYearPLAccAccFundAccFundCode, currYearPLAccAccSubTypeAccSubType, currYearPLAccAccTypeAccType, currYearPLAccCoaControlAccName, currYearPLAccCoaControlAccBalTypeAccBalType, currYearPLAccCoaControlAccDestAccDest, currYearPLAccCoaControlAccTypeAccType, currYearPLAccCoaControlCompTypeDescription, currYearPLAccCoaMainAccName, currYearPLAccCoaMainAccBalTypeAccBalType, currYearPLAccCoaMainAccDestAccDest, currYearPLAccCoaMainAccFundAccFundCode, currYearPLAccCoaMainAccTypeAccType, currYearPLAccCoaMainCoaControlAccName, currYearPLAccCoaSubAccName, currYearPLAccCoaSubAccBalTypeAccBalType, currYearPLAccCoaSubAccDestAccDest, currYearPLAccCoaSubAccFundAccFundCode, currYearPLAccCoaSubAccTypeAccType, currYearPLAccCoaSubCoaControlAccName, currYearPLAccCoaSubCoaMainAccName, chequeCCAcc);
        }
        
        public static List<MyCompany.Data.Objects.AccFundAccs> Select(MyCompany.Data.Objects.AccFundAccs qbe)
        {
            return new AccFundAccsFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.AccFundAccs> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new AccFundAccsFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccFundAccs> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new AccFundAccsFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.AccFundAccs> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new AccFundAccsFactory().Select(filter, sort, AccFundAccsFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccFundAccs> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new AccFundAccsFactory().Select(filter, sort, AccFundAccsFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.AccFundAccs> Select(string filter, BusinessObjectParameters parameters)
        {
            return new AccFundAccsFactory().Select(filter, null, AccFundAccsFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccFundAccs> Select(string filter, params FieldValue[] parameters)
        {
            return new AccFundAccsFactory().Select(filter, null, AccFundAccsFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.AccFundAccs SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new AccFundAccsFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.AccFundAccs SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new AccFundAccsFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.AccFundAccs SelectSingle(int? accFundAccsID)
        {
            return new AccFundAccsFactory().SelectSingle(accFundAccsID);
        }
        
        public int Insert()
        {
            return new AccFundAccsFactory().Insert(this);
        }
        
        public int Update()
        {
            return new AccFundAccsFactory().Update(this);
        }
        
        public int Delete()
        {
            return new AccFundAccsFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("AccFundAccsID: {0}", this.AccFundAccsID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class AccFundAccsFactory
    {
        
        public AccFundAccsFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("AccFundAccs");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("AccFundAccs");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("AccFundAccs");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("AccFundAccs");
            }
        }
        
        public static AccFundAccsFactory Create()
        {
            return new AccFundAccsFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    int? accFundAccsID, 
                    int? accFundID, 
                    string accFundAccFundCode, 
                    int? cashCode, 
                    string cashAccName, 
                    string cashAccBalTypeAccBalType, 
                    string cashAccCurrencyAccCurrencyName, 
                    string cashAccDestAccDest, 
                    string cashAccDestCompanyTypeDescription, 
                    string cashAccFundAccFundCode, 
                    string cashAccSubTypeAccSubType, 
                    string cashAccTypeAccType, 
                    string cashCoaControlAccName, 
                    string cashCoaControlAccBalTypeAccBalType, 
                    string cashCoaControlAccDestAccDest, 
                    string cashCoaControlAccTypeAccType, 
                    string cashCoaControlCompTypeDescription, 
                    string cashCoaMainAccName, 
                    string cashCoaMainAccBalTypeAccBalType, 
                    string cashCoaMainAccDestAccDest, 
                    string cashCoaMainAccFundAccFundCode, 
                    string cashCoaMainAccTypeAccType, 
                    string cashCoaMainCoaControlAccName, 
                    string cashCoaSubAccName, 
                    string cashCoaSubAccBalTypeAccBalType, 
                    string cashCoaSubAccDestAccDest, 
                    string cashCoaSubAccFundAccFundCode, 
                    string cashCoaSubAccTypeAccType, 
                    string cashCoaSubCoaControlAccName, 
                    string cashCoaSubCoaMainAccName, 
                    int? bankCode, 
                    string bankAccName, 
                    string bankAccBalTypeAccBalType, 
                    string bankAccCurrencyAccCurrencyName, 
                    string bankAccDestAccDest, 
                    string bankAccDestCompanyTypeDescription, 
                    string bankAccFundAccFundCode, 
                    string bankAccSubTypeAccSubType, 
                    string bankAccTypeAccType, 
                    string bankCoaControlAccName, 
                    string bankCoaControlAccBalTypeAccBalType, 
                    string bankCoaControlAccDestAccDest, 
                    string bankCoaControlAccTypeAccType, 
                    string bankCoaControlCompTypeDescription, 
                    string bankCoaMainAccName, 
                    string bankCoaMainAccBalTypeAccBalType, 
                    string bankCoaMainAccDestAccDest, 
                    string bankCoaMainAccFundAccFundCode, 
                    string bankCoaMainAccTypeAccType, 
                    string bankCoaMainCoaControlAccName, 
                    string bankCoaSubAccName, 
                    string bankCoaSubAccBalTypeAccBalType, 
                    string bankCoaSubAccDestAccDest, 
                    string bankCoaSubAccFundAccFundCode, 
                    string bankCoaSubAccTypeAccType, 
                    string bankCoaSubCoaControlAccName, 
                    string bankCoaSubCoaMainAccName, 
                    int? advance, 
                    string advanceAccName, 
                    string advanceAccBalTypeAccBalType, 
                    string advanceAccCurrencyAccCurrencyName, 
                    string advanceAccDestAccDest, 
                    string advanceAccDestCompanyTypeDescription, 
                    string advanceAccFundAccFundCode, 
                    string advanceAccSubTypeAccSubType, 
                    string advanceAccTypeAccType, 
                    string advanceCoaControlAccName, 
                    string advanceCoaControlAccBalTypeAccBalType, 
                    string advanceCoaControlAccDestAccDest, 
                    string advanceCoaControlAccTypeAccType, 
                    string advanceCoaControlCompTypeDescription, 
                    string advanceCoaMainAccName, 
                    string advanceCoaMainAccBalTypeAccBalType, 
                    string advanceCoaMainAccDestAccDest, 
                    string advanceCoaMainAccFundAccFundCode, 
                    string advanceCoaMainAccTypeAccType, 
                    string advanceCoaMainCoaControlAccName, 
                    string advanceCoaSubAccName, 
                    string advanceCoaSubAccBalTypeAccBalType, 
                    string advanceCoaSubAccDestAccDest, 
                    string advanceCoaSubAccFundAccFundCode, 
                    string advanceCoaSubAccTypeAccType, 
                    string advanceCoaSubCoaControlAccName, 
                    string advanceCoaSubCoaMainAccName, 
                    int? purAcc, 
                    string purAccAccName, 
                    string purAccAccBalTypeAccBalType, 
                    string purAccAccCurrencyAccCurrencyName, 
                    string purAccAccDestAccDest, 
                    string purAccAccDestCompanyTypeDescription, 
                    string purAccAccFundAccFundCode, 
                    string purAccAccSubTypeAccSubType, 
                    string purAccAccTypeAccType, 
                    string purAccCoaControlAccName, 
                    string purAccCoaControlAccBalTypeAccBalType, 
                    string purAccCoaControlAccDestAccDest, 
                    string purAccCoaControlAccTypeAccType, 
                    string purAccCoaControlCompTypeDescription, 
                    string purAccCoaMainAccName, 
                    string purAccCoaMainAccBalTypeAccBalType, 
                    string purAccCoaMainAccDestAccDest, 
                    string purAccCoaMainAccFundAccFundCode, 
                    string purAccCoaMainAccTypeAccType, 
                    string purAccCoaMainCoaControlAccName, 
                    string purAccCoaSubAccName, 
                    string purAccCoaSubAccBalTypeAccBalType, 
                    string purAccCoaSubAccDestAccDest, 
                    string purAccCoaSubAccFundAccFundCode, 
                    string purAccCoaSubAccTypeAccType, 
                    string purAccCoaSubCoaControlAccName, 
                    string purAccCoaSubCoaMainAccName, 
                    int? saleAcc, 
                    string saleAccAccName, 
                    string saleAccAccBalTypeAccBalType, 
                    string saleAccAccCurrencyAccCurrencyName, 
                    string saleAccAccDestAccDest, 
                    string saleAccAccDestCompanyTypeDescription, 
                    string saleAccAccFundAccFundCode, 
                    string saleAccAccSubTypeAccSubType, 
                    string saleAccAccTypeAccType, 
                    string saleAccCoaControlAccName, 
                    string saleAccCoaControlAccBalTypeAccBalType, 
                    string saleAccCoaControlAccDestAccDest, 
                    string saleAccCoaControlAccTypeAccType, 
                    string saleAccCoaControlCompTypeDescription, 
                    string saleAccCoaMainAccName, 
                    string saleAccCoaMainAccBalTypeAccBalType, 
                    string saleAccCoaMainAccDestAccDest, 
                    string saleAccCoaMainAccFundAccFundCode, 
                    string saleAccCoaMainAccTypeAccType, 
                    string saleAccCoaMainCoaControlAccName, 
                    string saleAccCoaSubAccName, 
                    string saleAccCoaSubAccBalTypeAccBalType, 
                    string saleAccCoaSubAccDestAccDest, 
                    string saleAccCoaSubAccFundAccFundCode, 
                    string saleAccCoaSubAccTypeAccType, 
                    string saleAccCoaSubCoaControlAccName, 
                    string saleAccCoaSubCoaMainAccName, 
                    int? workinProgressAcc, 
                    string workinProgressAccAccName, 
                    string workinProgressAccAccBalTypeAccBalType, 
                    string workinProgressAccAccCurrencyAccCurrencyName, 
                    string workinProgressAccAccDestAccDest, 
                    string workinProgressAccAccDestCompanyTypeDescription, 
                    string workinProgressAccAccFundAccFundCode, 
                    string workinProgressAccAccSubTypeAccSubType, 
                    string workinProgressAccAccTypeAccType, 
                    string workinProgressAccCoaControlAccName, 
                    string workinProgressAccCoaControlAccBalTypeAccBalType, 
                    string workinProgressAccCoaControlAccDestAccDest, 
                    string workinProgressAccCoaControlAccTypeAccType, 
                    string workinProgressAccCoaControlCompTypeDescription, 
                    string workinProgressAccCoaMainAccName, 
                    string workinProgressAccCoaMainAccBalTypeAccBalType, 
                    string workinProgressAccCoaMainAccDestAccDest, 
                    string workinProgressAccCoaMainAccFundAccFundCode, 
                    string workinProgressAccCoaMainAccTypeAccType, 
                    string workinProgressAccCoaMainCoaControlAccName, 
                    string workinProgressAccCoaSubAccName, 
                    string workinProgressAccCoaSubAccBalTypeAccBalType, 
                    string workinProgressAccCoaSubAccDestAccDest, 
                    string workinProgressAccCoaSubAccFundAccFundCode, 
                    string workinProgressAccCoaSubAccTypeAccType, 
                    string workinProgressAccCoaSubCoaControlAccName, 
                    string workinProgressAccCoaSubCoaMainAccName, 
                    int? costofSold, 
                    string costofSoldAccName, 
                    string costofSoldAccBalTypeAccBalType, 
                    string costofSoldAccCurrencyAccCurrencyName, 
                    string costofSoldAccDestAccDest, 
                    string costofSoldAccDestCompanyTypeDescription, 
                    string costofSoldAccFundAccFundCode, 
                    string costofSoldAccSubTypeAccSubType, 
                    string costofSoldAccTypeAccType, 
                    string costofSoldCoaControlAccName, 
                    string costofSoldCoaControlAccBalTypeAccBalType, 
                    string costofSoldCoaControlAccDestAccDest, 
                    string costofSoldCoaControlAccTypeAccType, 
                    string costofSoldCoaControlCompTypeDescription, 
                    string costofSoldCoaMainAccName, 
                    string costofSoldCoaMainAccBalTypeAccBalType, 
                    string costofSoldCoaMainAccDestAccDest, 
                    string costofSoldCoaMainAccFundAccFundCode, 
                    string costofSoldCoaMainAccTypeAccType, 
                    string costofSoldCoaMainCoaControlAccName, 
                    string costofSoldCoaSubAccName, 
                    string costofSoldCoaSubAccBalTypeAccBalType, 
                    string costofSoldCoaSubAccDestAccDest, 
                    string costofSoldCoaSubAccFundAccFundCode, 
                    string costofSoldCoaSubAccTypeAccType, 
                    string costofSoldCoaSubCoaControlAccName, 
                    string costofSoldCoaSubCoaMainAccName, 
                    int? oPD_Acc, 
                    string oPD_AccAccName, 
                    string oPD_AccAccBalTypeAccBalType, 
                    string oPD_AccAccCurrencyAccCurrencyName, 
                    string oPD_AccAccDestAccDest, 
                    string oPD_AccAccDestCompanyTypeDescription, 
                    string oPD_AccAccFundAccFundCode, 
                    string oPD_AccAccSubTypeAccSubType, 
                    string oPD_AccAccTypeAccType, 
                    string oPD_AccCoaControlAccName, 
                    string oPD_AccCoaControlAccBalTypeAccBalType, 
                    string oPD_AccCoaControlAccDestAccDest, 
                    string oPD_AccCoaControlAccTypeAccType, 
                    string oPD_AccCoaControlCompTypeDescription, 
                    string oPD_AccCoaMainAccName, 
                    string oPD_AccCoaMainAccBalTypeAccBalType, 
                    string oPD_AccCoaMainAccDestAccDest, 
                    string oPD_AccCoaMainAccFundAccFundCode, 
                    string oPD_AccCoaMainAccTypeAccType, 
                    string oPD_AccCoaMainCoaControlAccName, 
                    string oPD_AccCoaSubAccName, 
                    string oPD_AccCoaSubAccBalTypeAccBalType, 
                    string oPD_AccCoaSubAccDestAccDest, 
                    string oPD_AccCoaSubAccFundAccFundCode, 
                    string oPD_AccCoaSubAccTypeAccType, 
                    string oPD_AccCoaSubCoaControlAccName, 
                    string oPD_AccCoaSubCoaMainAccName, 
                    int? advPat_Acc, 
                    string advPat_AccAccName, 
                    string advPat_AccAccBalTypeAccBalType, 
                    string advPat_AccAccCurrencyAccCurrencyName, 
                    string advPat_AccAccDestAccDest, 
                    string advPat_AccAccDestCompanyTypeDescription, 
                    string advPat_AccAccFundAccFundCode, 
                    string advPat_AccAccSubTypeAccSubType, 
                    string advPat_AccAccTypeAccType, 
                    string advPat_AccCoaControlAccName, 
                    string advPat_AccCoaControlAccBalTypeAccBalType, 
                    string advPat_AccCoaControlAccDestAccDest, 
                    string advPat_AccCoaControlAccTypeAccType, 
                    string advPat_AccCoaControlCompTypeDescription, 
                    string advPat_AccCoaMainAccName, 
                    string advPat_AccCoaMainAccBalTypeAccBalType, 
                    string advPat_AccCoaMainAccDestAccDest, 
                    string advPat_AccCoaMainAccFundAccFundCode, 
                    string advPat_AccCoaMainAccTypeAccType, 
                    string advPat_AccCoaMainCoaControlAccName, 
                    string advPat_AccCoaSubAccName, 
                    string advPat_AccCoaSubAccBalTypeAccBalType, 
                    string advPat_AccCoaSubAccDestAccDest, 
                    string advPat_AccCoaSubAccFundAccFundCode, 
                    string advPat_AccCoaSubAccTypeAccType, 
                    string advPat_AccCoaSubCoaControlAccName, 
                    string advPat_AccCoaSubCoaMainAccName, 
                    int? investigate_Acc, 
                    string investigate_AccAccName, 
                    string investigate_AccAccBalTypeAccBalType, 
                    string investigate_AccAccCurrencyAccCurrencyName, 
                    string investigate_AccAccDestAccDest, 
                    string investigate_AccAccDestCompanyTypeDescription, 
                    string investigate_AccAccFundAccFundCode, 
                    string investigate_AccAccSubTypeAccSubType, 
                    string investigate_AccAccTypeAccType, 
                    string investigate_AccCoaControlAccName, 
                    string investigate_AccCoaControlAccBalTypeAccBalType, 
                    string investigate_AccCoaControlAccDestAccDest, 
                    string investigate_AccCoaControlAccTypeAccType, 
                    string investigate_AccCoaControlCompTypeDescription, 
                    string investigate_AccCoaMainAccName, 
                    string investigate_AccCoaMainAccBalTypeAccBalType, 
                    string investigate_AccCoaMainAccDestAccDest, 
                    string investigate_AccCoaMainAccFundAccFundCode, 
                    string investigate_AccCoaMainAccTypeAccType, 
                    string investigate_AccCoaMainCoaControlAccName, 
                    string investigate_AccCoaSubAccName, 
                    string investigate_AccCoaSubAccBalTypeAccBalType, 
                    string investigate_AccCoaSubAccDestAccDest, 
                    string investigate_AccCoaSubAccFundAccFundCode, 
                    string investigate_AccCoaSubAccTypeAccType, 
                    string investigate_AccCoaSubCoaControlAccName, 
                    string investigate_AccCoaSubCoaMainAccName, 
                    int? vatAcc, 
                    string vatAccAccName, 
                    string vatAccAccBalTypeAccBalType, 
                    string vatAccAccCurrencyAccCurrencyName, 
                    string vatAccAccDestAccDest, 
                    string vatAccAccDestCompanyTypeDescription, 
                    string vatAccAccFundAccFundCode, 
                    string vatAccAccSubTypeAccSubType, 
                    string vatAccAccTypeAccType, 
                    string vatAccCoaControlAccName, 
                    string vatAccCoaControlAccBalTypeAccBalType, 
                    string vatAccCoaControlAccDestAccDest, 
                    string vatAccCoaControlAccTypeAccType, 
                    string vatAccCoaControlCompTypeDescription, 
                    string vatAccCoaMainAccName, 
                    string vatAccCoaMainAccBalTypeAccBalType, 
                    string vatAccCoaMainAccDestAccDest, 
                    string vatAccCoaMainAccFundAccFundCode, 
                    string vatAccCoaMainAccTypeAccType, 
                    string vatAccCoaMainCoaControlAccName, 
                    string vatAccCoaSubAccName, 
                    string vatAccCoaSubAccBalTypeAccBalType, 
                    string vatAccCoaSubAccDestAccDest, 
                    string vatAccCoaSubAccFundAccFundCode, 
                    string vatAccCoaSubAccTypeAccType, 
                    string vatAccCoaSubCoaControlAccName, 
                    string vatAccCoaSubCoaMainAccName, 
                    int? sundryDebitors, 
                    string sundryDebitorsAccName, 
                    string sundryDebitorsAccBalTypeAccBalType, 
                    string sundryDebitorsAccCurrencyAccCurrencyName, 
                    string sundryDebitorsAccDestAccDest, 
                    string sundryDebitorsAccDestCompanyTypeDescription, 
                    string sundryDebitorsAccFundAccFundCode, 
                    string sundryDebitorsAccSubTypeAccSubType, 
                    string sundryDebitorsAccTypeAccType, 
                    string sundryDebitorsCoaControlAccName, 
                    string sundryDebitorsCoaControlAccBalTypeAccBalType, 
                    string sundryDebitorsCoaControlAccDestAccDest, 
                    string sundryDebitorsCoaControlAccTypeAccType, 
                    string sundryDebitorsCoaControlCompTypeDescription, 
                    string sundryDebitorsCoaMainAccName, 
                    string sundryDebitorsCoaMainAccBalTypeAccBalType, 
                    string sundryDebitorsCoaMainAccDestAccDest, 
                    string sundryDebitorsCoaMainAccFundAccFundCode, 
                    string sundryDebitorsCoaMainAccTypeAccType, 
                    string sundryDebitorsCoaMainCoaControlAccName, 
                    string sundryDebitorsCoaSubAccName, 
                    string sundryDebitorsCoaSubAccBalTypeAccBalType, 
                    string sundryDebitorsCoaSubAccDestAccDest, 
                    string sundryDebitorsCoaSubAccFundAccFundCode, 
                    string sundryDebitorsCoaSubAccTypeAccType, 
                    string sundryDebitorsCoaSubCoaControlAccName, 
                    string sundryDebitorsCoaSubCoaMainAccName, 
                    int? sundryCreditors, 
                    string sundryCreditorsAccName, 
                    string sundryCreditorsAccBalTypeAccBalType, 
                    string sundryCreditorsAccCurrencyAccCurrencyName, 
                    string sundryCreditorsAccDestAccDest, 
                    string sundryCreditorsAccDestCompanyTypeDescription, 
                    string sundryCreditorsAccFundAccFundCode, 
                    string sundryCreditorsAccSubTypeAccSubType, 
                    string sundryCreditorsAccTypeAccType, 
                    string sundryCreditorsCoaControlAccName, 
                    string sundryCreditorsCoaControlAccBalTypeAccBalType, 
                    string sundryCreditorsCoaControlAccDestAccDest, 
                    string sundryCreditorsCoaControlAccTypeAccType, 
                    string sundryCreditorsCoaControlCompTypeDescription, 
                    string sundryCreditorsCoaMainAccName, 
                    string sundryCreditorsCoaMainAccBalTypeAccBalType, 
                    string sundryCreditorsCoaMainAccDestAccDest, 
                    string sundryCreditorsCoaMainAccFundAccFundCode, 
                    string sundryCreditorsCoaMainAccTypeAccType, 
                    string sundryCreditorsCoaMainCoaControlAccName, 
                    string sundryCreditorsCoaSubAccName, 
                    string sundryCreditorsCoaSubAccBalTypeAccBalType, 
                    string sundryCreditorsCoaSubAccDestAccDest, 
                    string sundryCreditorsCoaSubAccFundAccFundCode, 
                    string sundryCreditorsCoaSubAccTypeAccType, 
                    string sundryCreditorsCoaSubCoaControlAccName, 
                    string sundryCreditorsCoaSubCoaMainAccName, 
                    int? rawMatAcc, 
                    string rawMatAccAccName, 
                    string rawMatAccAccBalTypeAccBalType, 
                    string rawMatAccAccCurrencyAccCurrencyName, 
                    string rawMatAccAccDestAccDest, 
                    string rawMatAccAccDestCompanyTypeDescription, 
                    string rawMatAccAccFundAccFundCode, 
                    string rawMatAccAccSubTypeAccSubType, 
                    string rawMatAccAccTypeAccType, 
                    string rawMatAccCoaControlAccName, 
                    string rawMatAccCoaControlAccBalTypeAccBalType, 
                    string rawMatAccCoaControlAccDestAccDest, 
                    string rawMatAccCoaControlAccTypeAccType, 
                    string rawMatAccCoaControlCompTypeDescription, 
                    string rawMatAccCoaMainAccName, 
                    string rawMatAccCoaMainAccBalTypeAccBalType, 
                    string rawMatAccCoaMainAccDestAccDest, 
                    string rawMatAccCoaMainAccFundAccFundCode, 
                    string rawMatAccCoaMainAccTypeAccType, 
                    string rawMatAccCoaMainCoaControlAccName, 
                    string rawMatAccCoaSubAccName, 
                    string rawMatAccCoaSubAccBalTypeAccBalType, 
                    string rawMatAccCoaSubAccDestAccDest, 
                    string rawMatAccCoaSubAccFundAccFundCode, 
                    string rawMatAccCoaSubAccTypeAccType, 
                    string rawMatAccCoaSubCoaControlAccName, 
                    string rawMatAccCoaSubCoaMainAccName, 
                    int? packMatAcc, 
                    string packMatAccAccName, 
                    string packMatAccAccBalTypeAccBalType, 
                    string packMatAccAccCurrencyAccCurrencyName, 
                    string packMatAccAccDestAccDest, 
                    string packMatAccAccDestCompanyTypeDescription, 
                    string packMatAccAccFundAccFundCode, 
                    string packMatAccAccSubTypeAccSubType, 
                    string packMatAccAccTypeAccType, 
                    string packMatAccCoaControlAccName, 
                    string packMatAccCoaControlAccBalTypeAccBalType, 
                    string packMatAccCoaControlAccDestAccDest, 
                    string packMatAccCoaControlAccTypeAccType, 
                    string packMatAccCoaControlCompTypeDescription, 
                    string packMatAccCoaMainAccName, 
                    string packMatAccCoaMainAccBalTypeAccBalType, 
                    string packMatAccCoaMainAccDestAccDest, 
                    string packMatAccCoaMainAccFundAccFundCode, 
                    string packMatAccCoaMainAccTypeAccType, 
                    string packMatAccCoaMainCoaControlAccName, 
                    string packMatAccCoaSubAccName, 
                    string packMatAccCoaSubAccBalTypeAccBalType, 
                    string packMatAccCoaSubAccDestAccDest, 
                    string packMatAccCoaSubAccFundAccFundCode, 
                    string packMatAccCoaSubAccTypeAccType, 
                    string packMatAccCoaSubCoaControlAccName, 
                    string packMatAccCoaSubCoaMainAccName, 
                    int? otherMatAcc, 
                    string otherMatAccAccName, 
                    string otherMatAccAccBalTypeAccBalType, 
                    string otherMatAccAccCurrencyAccCurrencyName, 
                    string otherMatAccAccDestAccDest, 
                    string otherMatAccAccDestCompanyTypeDescription, 
                    string otherMatAccAccFundAccFundCode, 
                    string otherMatAccAccSubTypeAccSubType, 
                    string otherMatAccAccTypeAccType, 
                    string otherMatAccCoaControlAccName, 
                    string otherMatAccCoaControlAccBalTypeAccBalType, 
                    string otherMatAccCoaControlAccDestAccDest, 
                    string otherMatAccCoaControlAccTypeAccType, 
                    string otherMatAccCoaControlCompTypeDescription, 
                    string otherMatAccCoaMainAccName, 
                    string otherMatAccCoaMainAccBalTypeAccBalType, 
                    string otherMatAccCoaMainAccDestAccDest, 
                    string otherMatAccCoaMainAccFundAccFundCode, 
                    string otherMatAccCoaMainAccTypeAccType, 
                    string otherMatAccCoaMainCoaControlAccName, 
                    string otherMatAccCoaSubAccName, 
                    string otherMatAccCoaSubAccBalTypeAccBalType, 
                    string otherMatAccCoaSubAccDestAccDest, 
                    string otherMatAccCoaSubAccFundAccFundCode, 
                    string otherMatAccCoaSubAccTypeAccType, 
                    string otherMatAccCoaSubCoaControlAccName, 
                    string otherMatAccCoaSubCoaMainAccName, 
                    int? finishMatAcc, 
                    string finishMatAccAccName, 
                    string finishMatAccAccBalTypeAccBalType, 
                    string finishMatAccAccCurrencyAccCurrencyName, 
                    string finishMatAccAccDestAccDest, 
                    string finishMatAccAccDestCompanyTypeDescription, 
                    string finishMatAccAccFundAccFundCode, 
                    string finishMatAccAccSubTypeAccSubType, 
                    string finishMatAccAccTypeAccType, 
                    string finishMatAccCoaControlAccName, 
                    string finishMatAccCoaControlAccBalTypeAccBalType, 
                    string finishMatAccCoaControlAccDestAccDest, 
                    string finishMatAccCoaControlAccTypeAccType, 
                    string finishMatAccCoaControlCompTypeDescription, 
                    string finishMatAccCoaMainAccName, 
                    string finishMatAccCoaMainAccBalTypeAccBalType, 
                    string finishMatAccCoaMainAccDestAccDest, 
                    string finishMatAccCoaMainAccFundAccFundCode, 
                    string finishMatAccCoaMainAccTypeAccType, 
                    string finishMatAccCoaMainCoaControlAccName, 
                    string finishMatAccCoaSubAccName, 
                    string finishMatAccCoaSubAccBalTypeAccBalType, 
                    string finishMatAccCoaSubAccDestAccDest, 
                    string finishMatAccCoaSubAccFundAccFundCode, 
                    string finishMatAccCoaSubAccTypeAccType, 
                    string finishMatAccCoaSubCoaControlAccName, 
                    string finishMatAccCoaSubCoaMainAccName, 
                    int? adminExpAcc, 
                    string adminExpAccAccName, 
                    string adminExpAccAccBalTypeAccBalType, 
                    string adminExpAccAccCurrencyAccCurrencyName, 
                    string adminExpAccAccDestAccDest, 
                    string adminExpAccAccDestCompanyTypeDescription, 
                    string adminExpAccAccFundAccFundCode, 
                    string adminExpAccAccSubTypeAccSubType, 
                    string adminExpAccAccTypeAccType, 
                    string adminExpAccCoaControlAccName, 
                    string adminExpAccCoaControlAccBalTypeAccBalType, 
                    string adminExpAccCoaControlAccDestAccDest, 
                    string adminExpAccCoaControlAccTypeAccType, 
                    string adminExpAccCoaControlCompTypeDescription, 
                    string adminExpAccCoaMainAccName, 
                    string adminExpAccCoaMainAccBalTypeAccBalType, 
                    string adminExpAccCoaMainAccDestAccDest, 
                    string adminExpAccCoaMainAccFundAccFundCode, 
                    string adminExpAccCoaMainAccTypeAccType, 
                    string adminExpAccCoaMainCoaControlAccName, 
                    string adminExpAccCoaSubAccName, 
                    string adminExpAccCoaSubAccBalTypeAccBalType, 
                    string adminExpAccCoaSubAccDestAccDest, 
                    string adminExpAccCoaSubAccFundAccFundCode, 
                    string adminExpAccCoaSubAccTypeAccType, 
                    string adminExpAccCoaSubCoaControlAccName, 
                    string adminExpAccCoaSubCoaMainAccName, 
                    int? sellingExpAcc, 
                    string sellingExpAccAccName, 
                    string sellingExpAccAccBalTypeAccBalType, 
                    string sellingExpAccAccCurrencyAccCurrencyName, 
                    string sellingExpAccAccDestAccDest, 
                    string sellingExpAccAccDestCompanyTypeDescription, 
                    string sellingExpAccAccFundAccFundCode, 
                    string sellingExpAccAccSubTypeAccSubType, 
                    string sellingExpAccAccTypeAccType, 
                    string sellingExpAccCoaControlAccName, 
                    string sellingExpAccCoaControlAccBalTypeAccBalType, 
                    string sellingExpAccCoaControlAccDestAccDest, 
                    string sellingExpAccCoaControlAccTypeAccType, 
                    string sellingExpAccCoaControlCompTypeDescription, 
                    string sellingExpAccCoaMainAccName, 
                    string sellingExpAccCoaMainAccBalTypeAccBalType, 
                    string sellingExpAccCoaMainAccDestAccDest, 
                    string sellingExpAccCoaMainAccFundAccFundCode, 
                    string sellingExpAccCoaMainAccTypeAccType, 
                    string sellingExpAccCoaMainCoaControlAccName, 
                    string sellingExpAccCoaSubAccName, 
                    string sellingExpAccCoaSubAccBalTypeAccBalType, 
                    string sellingExpAccCoaSubAccDestAccDest, 
                    string sellingExpAccCoaSubAccFundAccFundCode, 
                    string sellingExpAccCoaSubAccTypeAccType, 
                    string sellingExpAccCoaSubCoaControlAccName, 
                    string sellingExpAccCoaSubCoaMainAccName, 
                    int? manuExpAcc, 
                    string manuExpAccAccName, 
                    string manuExpAccAccBalTypeAccBalType, 
                    string manuExpAccAccCurrencyAccCurrencyName, 
                    string manuExpAccAccDestAccDest, 
                    string manuExpAccAccDestCompanyTypeDescription, 
                    string manuExpAccAccFundAccFundCode, 
                    string manuExpAccAccSubTypeAccSubType, 
                    string manuExpAccAccTypeAccType, 
                    string manuExpAccCoaControlAccName, 
                    string manuExpAccCoaControlAccBalTypeAccBalType, 
                    string manuExpAccCoaControlAccDestAccDest, 
                    string manuExpAccCoaControlAccTypeAccType, 
                    string manuExpAccCoaControlCompTypeDescription, 
                    string manuExpAccCoaMainAccName, 
                    string manuExpAccCoaMainAccBalTypeAccBalType, 
                    string manuExpAccCoaMainAccDestAccDest, 
                    string manuExpAccCoaMainAccFundAccFundCode, 
                    string manuExpAccCoaMainAccTypeAccType, 
                    string manuExpAccCoaMainCoaControlAccName, 
                    string manuExpAccCoaSubAccName, 
                    string manuExpAccCoaSubAccBalTypeAccBalType, 
                    string manuExpAccCoaSubAccDestAccDest, 
                    string manuExpAccCoaSubAccFundAccFundCode, 
                    string manuExpAccCoaSubAccTypeAccType, 
                    string manuExpAccCoaSubCoaControlAccName, 
                    string manuExpAccCoaSubCoaMainAccName, 
                    int? loanAcc, 
                    string loanAccAccName, 
                    string loanAccAccBalTypeAccBalType, 
                    string loanAccAccCurrencyAccCurrencyName, 
                    string loanAccAccDestAccDest, 
                    string loanAccAccDestCompanyTypeDescription, 
                    string loanAccAccFundAccFundCode, 
                    string loanAccAccSubTypeAccSubType, 
                    string loanAccAccTypeAccType, 
                    string loanAccCoaControlAccName, 
                    string loanAccCoaControlAccBalTypeAccBalType, 
                    string loanAccCoaControlAccDestAccDest, 
                    string loanAccCoaControlAccTypeAccType, 
                    string loanAccCoaControlCompTypeDescription, 
                    string loanAccCoaMainAccName, 
                    string loanAccCoaMainAccBalTypeAccBalType, 
                    string loanAccCoaMainAccDestAccDest, 
                    string loanAccCoaMainAccFundAccFundCode, 
                    string loanAccCoaMainAccTypeAccType, 
                    string loanAccCoaMainCoaControlAccName, 
                    string loanAccCoaSubAccName, 
                    string loanAccCoaSubAccBalTypeAccBalType, 
                    string loanAccCoaSubAccDestAccDest, 
                    string loanAccCoaSubAccFundAccFundCode, 
                    string loanAccCoaSubAccTypeAccType, 
                    string loanAccCoaSubCoaControlAccName, 
                    string loanAccCoaSubCoaMainAccName, 
                    int? assetDepAcc, 
                    string assetDepAccAccName, 
                    string assetDepAccAccBalTypeAccBalType, 
                    string assetDepAccAccCurrencyAccCurrencyName, 
                    string assetDepAccAccDestAccDest, 
                    string assetDepAccAccDestCompanyTypeDescription, 
                    string assetDepAccAccFundAccFundCode, 
                    string assetDepAccAccSubTypeAccSubType, 
                    string assetDepAccAccTypeAccType, 
                    string assetDepAccCoaControlAccName, 
                    string assetDepAccCoaControlAccBalTypeAccBalType, 
                    string assetDepAccCoaControlAccDestAccDest, 
                    string assetDepAccCoaControlAccTypeAccType, 
                    string assetDepAccCoaControlCompTypeDescription, 
                    string assetDepAccCoaMainAccName, 
                    string assetDepAccCoaMainAccBalTypeAccBalType, 
                    string assetDepAccCoaMainAccDestAccDest, 
                    string assetDepAccCoaMainAccFundAccFundCode, 
                    string assetDepAccCoaMainAccTypeAccType, 
                    string assetDepAccCoaMainCoaControlAccName, 
                    string assetDepAccCoaSubAccName, 
                    string assetDepAccCoaSubAccBalTypeAccBalType, 
                    string assetDepAccCoaSubAccDestAccDest, 
                    string assetDepAccCoaSubAccFundAccFundCode, 
                    string assetDepAccCoaSubAccTypeAccType, 
                    string assetDepAccCoaSubCoaControlAccName, 
                    string assetDepAccCoaSubCoaMainAccName, 
                    int? nonOperateIncAcc, 
                    string nonOperateIncAccAccName, 
                    string nonOperateIncAccAccBalTypeAccBalType, 
                    string nonOperateIncAccAccCurrencyAccCurrencyName, 
                    string nonOperateIncAccAccDestAccDest, 
                    string nonOperateIncAccAccDestCompanyTypeDescription, 
                    string nonOperateIncAccAccFundAccFundCode, 
                    string nonOperateIncAccAccSubTypeAccSubType, 
                    string nonOperateIncAccAccTypeAccType, 
                    string nonOperateIncAccCoaControlAccName, 
                    string nonOperateIncAccCoaControlAccBalTypeAccBalType, 
                    string nonOperateIncAccCoaControlAccDestAccDest, 
                    string nonOperateIncAccCoaControlAccTypeAccType, 
                    string nonOperateIncAccCoaControlCompTypeDescription, 
                    string nonOperateIncAccCoaMainAccName, 
                    string nonOperateIncAccCoaMainAccBalTypeAccBalType, 
                    string nonOperateIncAccCoaMainAccDestAccDest, 
                    string nonOperateIncAccCoaMainAccFundAccFundCode, 
                    string nonOperateIncAccCoaMainAccTypeAccType, 
                    string nonOperateIncAccCoaMainCoaControlAccName, 
                    string nonOperateIncAccCoaSubAccName, 
                    string nonOperateIncAccCoaSubAccBalTypeAccBalType, 
                    string nonOperateIncAccCoaSubAccDestAccDest, 
                    string nonOperateIncAccCoaSubAccFundAccFundCode, 
                    string nonOperateIncAccCoaSubAccTypeAccType, 
                    string nonOperateIncAccCoaSubCoaControlAccName, 
                    string nonOperateIncAccCoaSubCoaMainAccName, 
                    int? nonOperateExpAcc, 
                    string nonOperateExpAccAccName, 
                    string nonOperateExpAccAccBalTypeAccBalType, 
                    string nonOperateExpAccAccCurrencyAccCurrencyName, 
                    string nonOperateExpAccAccDestAccDest, 
                    string nonOperateExpAccAccDestCompanyTypeDescription, 
                    string nonOperateExpAccAccFundAccFundCode, 
                    string nonOperateExpAccAccSubTypeAccSubType, 
                    string nonOperateExpAccAccTypeAccType, 
                    string nonOperateExpAccCoaControlAccName, 
                    string nonOperateExpAccCoaControlAccBalTypeAccBalType, 
                    string nonOperateExpAccCoaControlAccDestAccDest, 
                    string nonOperateExpAccCoaControlAccTypeAccType, 
                    string nonOperateExpAccCoaControlCompTypeDescription, 
                    string nonOperateExpAccCoaMainAccName, 
                    string nonOperateExpAccCoaMainAccBalTypeAccBalType, 
                    string nonOperateExpAccCoaMainAccDestAccDest, 
                    string nonOperateExpAccCoaMainAccFundAccFundCode, 
                    string nonOperateExpAccCoaMainAccTypeAccType, 
                    string nonOperateExpAccCoaMainCoaControlAccName, 
                    string nonOperateExpAccCoaSubAccName, 
                    string nonOperateExpAccCoaSubAccBalTypeAccBalType, 
                    string nonOperateExpAccCoaSubAccDestAccDest, 
                    string nonOperateExpAccCoaSubAccFundAccFundCode, 
                    string nonOperateExpAccCoaSubAccTypeAccType, 
                    string nonOperateExpAccCoaSubCoaControlAccName, 
                    string nonOperateExpAccCoaSubCoaMainAccName, 
                    int? prevYearPLAcc, 
                    string prevYearPLAccAccName, 
                    string prevYearPLAccAccBalTypeAccBalType, 
                    string prevYearPLAccAccCurrencyAccCurrencyName, 
                    string prevYearPLAccAccDestAccDest, 
                    string prevYearPLAccAccDestCompanyTypeDescription, 
                    string prevYearPLAccAccFundAccFundCode, 
                    string prevYearPLAccAccSubTypeAccSubType, 
                    string prevYearPLAccAccTypeAccType, 
                    string prevYearPLAccCoaControlAccName, 
                    string prevYearPLAccCoaControlAccBalTypeAccBalType, 
                    string prevYearPLAccCoaControlAccDestAccDest, 
                    string prevYearPLAccCoaControlAccTypeAccType, 
                    string prevYearPLAccCoaControlCompTypeDescription, 
                    string prevYearPLAccCoaMainAccName, 
                    string prevYearPLAccCoaMainAccBalTypeAccBalType, 
                    string prevYearPLAccCoaMainAccDestAccDest, 
                    string prevYearPLAccCoaMainAccFundAccFundCode, 
                    string prevYearPLAccCoaMainAccTypeAccType, 
                    string prevYearPLAccCoaMainCoaControlAccName, 
                    string prevYearPLAccCoaSubAccName, 
                    string prevYearPLAccCoaSubAccBalTypeAccBalType, 
                    string prevYearPLAccCoaSubAccDestAccDest, 
                    string prevYearPLAccCoaSubAccFundAccFundCode, 
                    string prevYearPLAccCoaSubAccTypeAccType, 
                    string prevYearPLAccCoaSubCoaControlAccName, 
                    string prevYearPLAccCoaSubCoaMainAccName, 
                    int? currYearPLAcc, 
                    string currYearPLAccAccName, 
                    string currYearPLAccAccBalTypeAccBalType, 
                    string currYearPLAccAccCurrencyAccCurrencyName, 
                    string currYearPLAccAccDestAccDest, 
                    string currYearPLAccAccDestCompanyTypeDescription, 
                    string currYearPLAccAccFundAccFundCode, 
                    string currYearPLAccAccSubTypeAccSubType, 
                    string currYearPLAccAccTypeAccType, 
                    string currYearPLAccCoaControlAccName, 
                    string currYearPLAccCoaControlAccBalTypeAccBalType, 
                    string currYearPLAccCoaControlAccDestAccDest, 
                    string currYearPLAccCoaControlAccTypeAccType, 
                    string currYearPLAccCoaControlCompTypeDescription, 
                    string currYearPLAccCoaMainAccName, 
                    string currYearPLAccCoaMainAccBalTypeAccBalType, 
                    string currYearPLAccCoaMainAccDestAccDest, 
                    string currYearPLAccCoaMainAccFundAccFundCode, 
                    string currYearPLAccCoaMainAccTypeAccType, 
                    string currYearPLAccCoaMainCoaControlAccName, 
                    string currYearPLAccCoaSubAccName, 
                    string currYearPLAccCoaSubAccBalTypeAccBalType, 
                    string currYearPLAccCoaSubAccDestAccDest, 
                    string currYearPLAccCoaSubAccFundAccFundCode, 
                    string currYearPLAccCoaSubAccTypeAccType, 
                    string currYearPLAccCoaSubCoaControlAccName, 
                    string currYearPLAccCoaSubCoaMainAccName, 
                    int? chequeCCAcc, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (accFundAccsID.HasValue)
            	filter.Add(("AccFundAccsID:=" + accFundAccsID.Value.ToString()));
            if (accFundID.HasValue)
            	filter.Add(("AccFundID:=" + accFundID.Value.ToString()));
            if (!(String.IsNullOrEmpty(accFundAccFundCode)))
            	filter.Add(("AccFundAccFundCode:*" + accFundAccFundCode));
            if (cashCode.HasValue)
            	filter.Add(("CashCode:=" + cashCode.Value.ToString()));
            if (!(String.IsNullOrEmpty(cashAccName)))
            	filter.Add(("CashAccName:*" + cashAccName));
            if (!(String.IsNullOrEmpty(cashAccBalTypeAccBalType)))
            	filter.Add(("CashAccBalTypeAccBalType:*" + cashAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(cashAccCurrencyAccCurrencyName)))
            	filter.Add(("CashAccCurrencyAccCurrencyName:*" + cashAccCurrencyAccCurrencyName));
            if (!(String.IsNullOrEmpty(cashAccDestAccDest)))
            	filter.Add(("CashAccDestAccDest:*" + cashAccDestAccDest));
            if (!(String.IsNullOrEmpty(cashAccDestCompanyTypeDescription)))
            	filter.Add(("CashAccDestCompanyTypeDescription:*" + cashAccDestCompanyTypeDescription));
            if (!(String.IsNullOrEmpty(cashAccFundAccFundCode)))
            	filter.Add(("CashAccFundAccFundCode:*" + cashAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(cashAccSubTypeAccSubType)))
            	filter.Add(("CashAccSubTypeAccSubType:*" + cashAccSubTypeAccSubType));
            if (!(String.IsNullOrEmpty(cashAccTypeAccType)))
            	filter.Add(("CashAccTypeAccType:*" + cashAccTypeAccType));
            if (!(String.IsNullOrEmpty(cashCoaControlAccName)))
            	filter.Add(("CashCoaControlAccName:*" + cashCoaControlAccName));
            if (!(String.IsNullOrEmpty(cashCoaControlAccBalTypeAccBalType)))
            	filter.Add(("CashCoaControlAccBalTypeAccBalType:*" + cashCoaControlAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(cashCoaControlAccDestAccDest)))
            	filter.Add(("CashCoaControlAccDestAccDest:*" + cashCoaControlAccDestAccDest));
            if (!(String.IsNullOrEmpty(cashCoaControlAccTypeAccType)))
            	filter.Add(("CashCoaControlAccTypeAccType:*" + cashCoaControlAccTypeAccType));
            if (!(String.IsNullOrEmpty(cashCoaControlCompTypeDescription)))
            	filter.Add(("CashCoaControlCompTypeDescription:*" + cashCoaControlCompTypeDescription));
            if (!(String.IsNullOrEmpty(cashCoaMainAccName)))
            	filter.Add(("CashCoaMainAccName:*" + cashCoaMainAccName));
            if (!(String.IsNullOrEmpty(cashCoaMainAccBalTypeAccBalType)))
            	filter.Add(("CashCoaMainAccBalTypeAccBalType:*" + cashCoaMainAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(cashCoaMainAccDestAccDest)))
            	filter.Add(("CashCoaMainAccDestAccDest:*" + cashCoaMainAccDestAccDest));
            if (!(String.IsNullOrEmpty(cashCoaMainAccFundAccFundCode)))
            	filter.Add(("CashCoaMainAccFundAccFundCode:*" + cashCoaMainAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(cashCoaMainAccTypeAccType)))
            	filter.Add(("CashCoaMainAccTypeAccType:*" + cashCoaMainAccTypeAccType));
            if (!(String.IsNullOrEmpty(cashCoaMainCoaControlAccName)))
            	filter.Add(("CashCoaMainCoaControlAccName:*" + cashCoaMainCoaControlAccName));
            if (!(String.IsNullOrEmpty(cashCoaSubAccName)))
            	filter.Add(("CashCoaSubAccName:*" + cashCoaSubAccName));
            if (!(String.IsNullOrEmpty(cashCoaSubAccBalTypeAccBalType)))
            	filter.Add(("CashCoaSubAccBalTypeAccBalType:*" + cashCoaSubAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(cashCoaSubAccDestAccDest)))
            	filter.Add(("CashCoaSubAccDestAccDest:*" + cashCoaSubAccDestAccDest));
            if (!(String.IsNullOrEmpty(cashCoaSubAccFundAccFundCode)))
            	filter.Add(("CashCoaSubAccFundAccFundCode:*" + cashCoaSubAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(cashCoaSubAccTypeAccType)))
            	filter.Add(("CashCoaSubAccTypeAccType:*" + cashCoaSubAccTypeAccType));
            if (!(String.IsNullOrEmpty(cashCoaSubCoaControlAccName)))
            	filter.Add(("CashCoaSubCoaControlAccName:*" + cashCoaSubCoaControlAccName));
            if (!(String.IsNullOrEmpty(cashCoaSubCoaMainAccName)))
            	filter.Add(("CashCoaSubCoaMainAccName:*" + cashCoaSubCoaMainAccName));
            if (bankCode.HasValue)
            	filter.Add(("BankCode:=" + bankCode.Value.ToString()));
            if (!(String.IsNullOrEmpty(bankAccName)))
            	filter.Add(("BankAccName:*" + bankAccName));
            if (!(String.IsNullOrEmpty(bankAccBalTypeAccBalType)))
            	filter.Add(("BankAccBalTypeAccBalType:*" + bankAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(bankAccCurrencyAccCurrencyName)))
            	filter.Add(("BankAccCurrencyAccCurrencyName:*" + bankAccCurrencyAccCurrencyName));
            if (!(String.IsNullOrEmpty(bankAccDestAccDest)))
            	filter.Add(("BankAccDestAccDest:*" + bankAccDestAccDest));
            if (!(String.IsNullOrEmpty(bankAccDestCompanyTypeDescription)))
            	filter.Add(("BankAccDestCompanyTypeDescription:*" + bankAccDestCompanyTypeDescription));
            if (!(String.IsNullOrEmpty(bankAccFundAccFundCode)))
            	filter.Add(("BankAccFundAccFundCode:*" + bankAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(bankAccSubTypeAccSubType)))
            	filter.Add(("BankAccSubTypeAccSubType:*" + bankAccSubTypeAccSubType));
            if (!(String.IsNullOrEmpty(bankAccTypeAccType)))
            	filter.Add(("BankAccTypeAccType:*" + bankAccTypeAccType));
            if (!(String.IsNullOrEmpty(bankCoaControlAccName)))
            	filter.Add(("BankCoaControlAccName:*" + bankCoaControlAccName));
            if (!(String.IsNullOrEmpty(bankCoaControlAccBalTypeAccBalType)))
            	filter.Add(("BankCoaControlAccBalTypeAccBalType:*" + bankCoaControlAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(bankCoaControlAccDestAccDest)))
            	filter.Add(("BankCoaControlAccDestAccDest:*" + bankCoaControlAccDestAccDest));
            if (!(String.IsNullOrEmpty(bankCoaControlAccTypeAccType)))
            	filter.Add(("BankCoaControlAccTypeAccType:*" + bankCoaControlAccTypeAccType));
            if (!(String.IsNullOrEmpty(bankCoaControlCompTypeDescription)))
            	filter.Add(("BankCoaControlCompTypeDescription:*" + bankCoaControlCompTypeDescription));
            if (!(String.IsNullOrEmpty(bankCoaMainAccName)))
            	filter.Add(("BankCoaMainAccName:*" + bankCoaMainAccName));
            if (!(String.IsNullOrEmpty(bankCoaMainAccBalTypeAccBalType)))
            	filter.Add(("BankCoaMainAccBalTypeAccBalType:*" + bankCoaMainAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(bankCoaMainAccDestAccDest)))
            	filter.Add(("BankCoaMainAccDestAccDest:*" + bankCoaMainAccDestAccDest));
            if (!(String.IsNullOrEmpty(bankCoaMainAccFundAccFundCode)))
            	filter.Add(("BankCoaMainAccFundAccFundCode:*" + bankCoaMainAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(bankCoaMainAccTypeAccType)))
            	filter.Add(("BankCoaMainAccTypeAccType:*" + bankCoaMainAccTypeAccType));
            if (!(String.IsNullOrEmpty(bankCoaMainCoaControlAccName)))
            	filter.Add(("BankCoaMainCoaControlAccName:*" + bankCoaMainCoaControlAccName));
            if (!(String.IsNullOrEmpty(bankCoaSubAccName)))
            	filter.Add(("BankCoaSubAccName:*" + bankCoaSubAccName));
            if (!(String.IsNullOrEmpty(bankCoaSubAccBalTypeAccBalType)))
            	filter.Add(("BankCoaSubAccBalTypeAccBalType:*" + bankCoaSubAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(bankCoaSubAccDestAccDest)))
            	filter.Add(("BankCoaSubAccDestAccDest:*" + bankCoaSubAccDestAccDest));
            if (!(String.IsNullOrEmpty(bankCoaSubAccFundAccFundCode)))
            	filter.Add(("BankCoaSubAccFundAccFundCode:*" + bankCoaSubAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(bankCoaSubAccTypeAccType)))
            	filter.Add(("BankCoaSubAccTypeAccType:*" + bankCoaSubAccTypeAccType));
            if (!(String.IsNullOrEmpty(bankCoaSubCoaControlAccName)))
            	filter.Add(("BankCoaSubCoaControlAccName:*" + bankCoaSubCoaControlAccName));
            if (!(String.IsNullOrEmpty(bankCoaSubCoaMainAccName)))
            	filter.Add(("BankCoaSubCoaMainAccName:*" + bankCoaSubCoaMainAccName));
            if (advance.HasValue)
            	filter.Add(("Advance:=" + advance.Value.ToString()));
            if (!(String.IsNullOrEmpty(advanceAccName)))
            	filter.Add(("AdvanceAccName:*" + advanceAccName));
            if (!(String.IsNullOrEmpty(advanceAccBalTypeAccBalType)))
            	filter.Add(("AdvanceAccBalTypeAccBalType:*" + advanceAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(advanceAccCurrencyAccCurrencyName)))
            	filter.Add(("AdvanceAccCurrencyAccCurrencyName:*" + advanceAccCurrencyAccCurrencyName));
            if (!(String.IsNullOrEmpty(advanceAccDestAccDest)))
            	filter.Add(("AdvanceAccDestAccDest:*" + advanceAccDestAccDest));
            if (!(String.IsNullOrEmpty(advanceAccDestCompanyTypeDescription)))
            	filter.Add(("AdvanceAccDestCompanyTypeDescription:*" + advanceAccDestCompanyTypeDescription));
            if (!(String.IsNullOrEmpty(advanceAccFundAccFundCode)))
            	filter.Add(("AdvanceAccFundAccFundCode:*" + advanceAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(advanceAccSubTypeAccSubType)))
            	filter.Add(("AdvanceAccSubTypeAccSubType:*" + advanceAccSubTypeAccSubType));
            if (!(String.IsNullOrEmpty(advanceAccTypeAccType)))
            	filter.Add(("AdvanceAccTypeAccType:*" + advanceAccTypeAccType));
            if (!(String.IsNullOrEmpty(advanceCoaControlAccName)))
            	filter.Add(("AdvanceCoaControlAccName:*" + advanceCoaControlAccName));
            if (!(String.IsNullOrEmpty(advanceCoaControlAccBalTypeAccBalType)))
            	filter.Add(("AdvanceCoaControlAccBalTypeAccBalType:*" + advanceCoaControlAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(advanceCoaControlAccDestAccDest)))
            	filter.Add(("AdvanceCoaControlAccDestAccDest:*" + advanceCoaControlAccDestAccDest));
            if (!(String.IsNullOrEmpty(advanceCoaControlAccTypeAccType)))
            	filter.Add(("AdvanceCoaControlAccTypeAccType:*" + advanceCoaControlAccTypeAccType));
            if (!(String.IsNullOrEmpty(advanceCoaControlCompTypeDescription)))
            	filter.Add(("AdvanceCoaControlCompTypeDescription:*" + advanceCoaControlCompTypeDescription));
            if (!(String.IsNullOrEmpty(advanceCoaMainAccName)))
            	filter.Add(("AdvanceCoaMainAccName:*" + advanceCoaMainAccName));
            if (!(String.IsNullOrEmpty(advanceCoaMainAccBalTypeAccBalType)))
            	filter.Add(("AdvanceCoaMainAccBalTypeAccBalType:*" + advanceCoaMainAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(advanceCoaMainAccDestAccDest)))
            	filter.Add(("AdvanceCoaMainAccDestAccDest:*" + advanceCoaMainAccDestAccDest));
            if (!(String.IsNullOrEmpty(advanceCoaMainAccFundAccFundCode)))
            	filter.Add(("AdvanceCoaMainAccFundAccFundCode:*" + advanceCoaMainAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(advanceCoaMainAccTypeAccType)))
            	filter.Add(("AdvanceCoaMainAccTypeAccType:*" + advanceCoaMainAccTypeAccType));
            if (!(String.IsNullOrEmpty(advanceCoaMainCoaControlAccName)))
            	filter.Add(("AdvanceCoaMainCoaControlAccName:*" + advanceCoaMainCoaControlAccName));
            if (!(String.IsNullOrEmpty(advanceCoaSubAccName)))
            	filter.Add(("AdvanceCoaSubAccName:*" + advanceCoaSubAccName));
            if (!(String.IsNullOrEmpty(advanceCoaSubAccBalTypeAccBalType)))
            	filter.Add(("AdvanceCoaSubAccBalTypeAccBalType:*" + advanceCoaSubAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(advanceCoaSubAccDestAccDest)))
            	filter.Add(("AdvanceCoaSubAccDestAccDest:*" + advanceCoaSubAccDestAccDest));
            if (!(String.IsNullOrEmpty(advanceCoaSubAccFundAccFundCode)))
            	filter.Add(("AdvanceCoaSubAccFundAccFundCode:*" + advanceCoaSubAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(advanceCoaSubAccTypeAccType)))
            	filter.Add(("AdvanceCoaSubAccTypeAccType:*" + advanceCoaSubAccTypeAccType));
            if (!(String.IsNullOrEmpty(advanceCoaSubCoaControlAccName)))
            	filter.Add(("AdvanceCoaSubCoaControlAccName:*" + advanceCoaSubCoaControlAccName));
            if (!(String.IsNullOrEmpty(advanceCoaSubCoaMainAccName)))
            	filter.Add(("AdvanceCoaSubCoaMainAccName:*" + advanceCoaSubCoaMainAccName));
            if (purAcc.HasValue)
            	filter.Add(("PurAcc:=" + purAcc.Value.ToString()));
            if (!(String.IsNullOrEmpty(purAccAccName)))
            	filter.Add(("PurAccAccName:*" + purAccAccName));
            if (!(String.IsNullOrEmpty(purAccAccBalTypeAccBalType)))
            	filter.Add(("PurAccAccBalTypeAccBalType:*" + purAccAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(purAccAccCurrencyAccCurrencyName)))
            	filter.Add(("PurAccAccCurrencyAccCurrencyName:*" + purAccAccCurrencyAccCurrencyName));
            if (!(String.IsNullOrEmpty(purAccAccDestAccDest)))
            	filter.Add(("PurAccAccDestAccDest:*" + purAccAccDestAccDest));
            if (!(String.IsNullOrEmpty(purAccAccDestCompanyTypeDescription)))
            	filter.Add(("PurAccAccDestCompanyTypeDescription:*" + purAccAccDestCompanyTypeDescription));
            if (!(String.IsNullOrEmpty(purAccAccFundAccFundCode)))
            	filter.Add(("PurAccAccFundAccFundCode:*" + purAccAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(purAccAccSubTypeAccSubType)))
            	filter.Add(("PurAccAccSubTypeAccSubType:*" + purAccAccSubTypeAccSubType));
            if (!(String.IsNullOrEmpty(purAccAccTypeAccType)))
            	filter.Add(("PurAccAccTypeAccType:*" + purAccAccTypeAccType));
            if (!(String.IsNullOrEmpty(purAccCoaControlAccName)))
            	filter.Add(("PurAccCoaControlAccName:*" + purAccCoaControlAccName));
            if (!(String.IsNullOrEmpty(purAccCoaControlAccBalTypeAccBalType)))
            	filter.Add(("PurAccCoaControlAccBalTypeAccBalType:*" + purAccCoaControlAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(purAccCoaControlAccDestAccDest)))
            	filter.Add(("PurAccCoaControlAccDestAccDest:*" + purAccCoaControlAccDestAccDest));
            if (!(String.IsNullOrEmpty(purAccCoaControlAccTypeAccType)))
            	filter.Add(("PurAccCoaControlAccTypeAccType:*" + purAccCoaControlAccTypeAccType));
            if (!(String.IsNullOrEmpty(purAccCoaControlCompTypeDescription)))
            	filter.Add(("PurAccCoaControlCompTypeDescription:*" + purAccCoaControlCompTypeDescription));
            if (!(String.IsNullOrEmpty(purAccCoaMainAccName)))
            	filter.Add(("PurAccCoaMainAccName:*" + purAccCoaMainAccName));
            if (!(String.IsNullOrEmpty(purAccCoaMainAccBalTypeAccBalType)))
            	filter.Add(("PurAccCoaMainAccBalTypeAccBalType:*" + purAccCoaMainAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(purAccCoaMainAccDestAccDest)))
            	filter.Add(("PurAccCoaMainAccDestAccDest:*" + purAccCoaMainAccDestAccDest));
            if (!(String.IsNullOrEmpty(purAccCoaMainAccFundAccFundCode)))
            	filter.Add(("PurAccCoaMainAccFundAccFundCode:*" + purAccCoaMainAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(purAccCoaMainAccTypeAccType)))
            	filter.Add(("PurAccCoaMainAccTypeAccType:*" + purAccCoaMainAccTypeAccType));
            if (!(String.IsNullOrEmpty(purAccCoaMainCoaControlAccName)))
            	filter.Add(("PurAccCoaMainCoaControlAccName:*" + purAccCoaMainCoaControlAccName));
            if (!(String.IsNullOrEmpty(purAccCoaSubAccName)))
            	filter.Add(("PurAccCoaSubAccName:*" + purAccCoaSubAccName));
            if (!(String.IsNullOrEmpty(purAccCoaSubAccBalTypeAccBalType)))
            	filter.Add(("PurAccCoaSubAccBalTypeAccBalType:*" + purAccCoaSubAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(purAccCoaSubAccDestAccDest)))
            	filter.Add(("PurAccCoaSubAccDestAccDest:*" + purAccCoaSubAccDestAccDest));
            if (!(String.IsNullOrEmpty(purAccCoaSubAccFundAccFundCode)))
            	filter.Add(("PurAccCoaSubAccFundAccFundCode:*" + purAccCoaSubAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(purAccCoaSubAccTypeAccType)))
            	filter.Add(("PurAccCoaSubAccTypeAccType:*" + purAccCoaSubAccTypeAccType));
            if (!(String.IsNullOrEmpty(purAccCoaSubCoaControlAccName)))
            	filter.Add(("PurAccCoaSubCoaControlAccName:*" + purAccCoaSubCoaControlAccName));
            if (!(String.IsNullOrEmpty(purAccCoaSubCoaMainAccName)))
            	filter.Add(("PurAccCoaSubCoaMainAccName:*" + purAccCoaSubCoaMainAccName));
            if (saleAcc.HasValue)
            	filter.Add(("SaleAcc:=" + saleAcc.Value.ToString()));
            if (!(String.IsNullOrEmpty(saleAccAccName)))
            	filter.Add(("SaleAccAccName:*" + saleAccAccName));
            if (!(String.IsNullOrEmpty(saleAccAccBalTypeAccBalType)))
            	filter.Add(("SaleAccAccBalTypeAccBalType:*" + saleAccAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(saleAccAccCurrencyAccCurrencyName)))
            	filter.Add(("SaleAccAccCurrencyAccCurrencyName:*" + saleAccAccCurrencyAccCurrencyName));
            if (!(String.IsNullOrEmpty(saleAccAccDestAccDest)))
            	filter.Add(("SaleAccAccDestAccDest:*" + saleAccAccDestAccDest));
            if (!(String.IsNullOrEmpty(saleAccAccDestCompanyTypeDescription)))
            	filter.Add(("SaleAccAccDestCompanyTypeDescription:*" + saleAccAccDestCompanyTypeDescription));
            if (!(String.IsNullOrEmpty(saleAccAccFundAccFundCode)))
            	filter.Add(("SaleAccAccFundAccFundCode:*" + saleAccAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(saleAccAccSubTypeAccSubType)))
            	filter.Add(("SaleAccAccSubTypeAccSubType:*" + saleAccAccSubTypeAccSubType));
            if (!(String.IsNullOrEmpty(saleAccAccTypeAccType)))
            	filter.Add(("SaleAccAccTypeAccType:*" + saleAccAccTypeAccType));
            if (!(String.IsNullOrEmpty(saleAccCoaControlAccName)))
            	filter.Add(("SaleAccCoaControlAccName:*" + saleAccCoaControlAccName));
            if (!(String.IsNullOrEmpty(saleAccCoaControlAccBalTypeAccBalType)))
            	filter.Add(("SaleAccCoaControlAccBalTypeAccBalType:*" + saleAccCoaControlAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(saleAccCoaControlAccDestAccDest)))
            	filter.Add(("SaleAccCoaControlAccDestAccDest:*" + saleAccCoaControlAccDestAccDest));
            if (!(String.IsNullOrEmpty(saleAccCoaControlAccTypeAccType)))
            	filter.Add(("SaleAccCoaControlAccTypeAccType:*" + saleAccCoaControlAccTypeAccType));
            if (!(String.IsNullOrEmpty(saleAccCoaControlCompTypeDescription)))
            	filter.Add(("SaleAccCoaControlCompTypeDescription:*" + saleAccCoaControlCompTypeDescription));
            if (!(String.IsNullOrEmpty(saleAccCoaMainAccName)))
            	filter.Add(("SaleAccCoaMainAccName:*" + saleAccCoaMainAccName));
            if (!(String.IsNullOrEmpty(saleAccCoaMainAccBalTypeAccBalType)))
            	filter.Add(("SaleAccCoaMainAccBalTypeAccBalType:*" + saleAccCoaMainAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(saleAccCoaMainAccDestAccDest)))
            	filter.Add(("SaleAccCoaMainAccDestAccDest:*" + saleAccCoaMainAccDestAccDest));
            if (!(String.IsNullOrEmpty(saleAccCoaMainAccFundAccFundCode)))
            	filter.Add(("SaleAccCoaMainAccFundAccFundCode:*" + saleAccCoaMainAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(saleAccCoaMainAccTypeAccType)))
            	filter.Add(("SaleAccCoaMainAccTypeAccType:*" + saleAccCoaMainAccTypeAccType));
            if (!(String.IsNullOrEmpty(saleAccCoaMainCoaControlAccName)))
            	filter.Add(("SaleAccCoaMainCoaControlAccName:*" + saleAccCoaMainCoaControlAccName));
            if (!(String.IsNullOrEmpty(saleAccCoaSubAccName)))
            	filter.Add(("SaleAccCoaSubAccName:*" + saleAccCoaSubAccName));
            if (!(String.IsNullOrEmpty(saleAccCoaSubAccBalTypeAccBalType)))
            	filter.Add(("SaleAccCoaSubAccBalTypeAccBalType:*" + saleAccCoaSubAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(saleAccCoaSubAccDestAccDest)))
            	filter.Add(("SaleAccCoaSubAccDestAccDest:*" + saleAccCoaSubAccDestAccDest));
            if (!(String.IsNullOrEmpty(saleAccCoaSubAccFundAccFundCode)))
            	filter.Add(("SaleAccCoaSubAccFundAccFundCode:*" + saleAccCoaSubAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(saleAccCoaSubAccTypeAccType)))
            	filter.Add(("SaleAccCoaSubAccTypeAccType:*" + saleAccCoaSubAccTypeAccType));
            if (!(String.IsNullOrEmpty(saleAccCoaSubCoaControlAccName)))
            	filter.Add(("SaleAccCoaSubCoaControlAccName:*" + saleAccCoaSubCoaControlAccName));
            if (!(String.IsNullOrEmpty(saleAccCoaSubCoaMainAccName)))
            	filter.Add(("SaleAccCoaSubCoaMainAccName:*" + saleAccCoaSubCoaMainAccName));
            if (workinProgressAcc.HasValue)
            	filter.Add(("WorkinProgressAcc:=" + workinProgressAcc.Value.ToString()));
            if (!(String.IsNullOrEmpty(workinProgressAccAccName)))
            	filter.Add(("WorkinProgressAccAccName:*" + workinProgressAccAccName));
            if (!(String.IsNullOrEmpty(workinProgressAccAccBalTypeAccBalType)))
            	filter.Add(("WorkinProgressAccAccBalTypeAccBalType:*" + workinProgressAccAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(workinProgressAccAccCurrencyAccCurrencyName)))
            	filter.Add(("WorkinProgressAccAccCurrencyAccCurrencyName:*" + workinProgressAccAccCurrencyAccCurrencyName));
            if (!(String.IsNullOrEmpty(workinProgressAccAccDestAccDest)))
            	filter.Add(("WorkinProgressAccAccDestAccDest:*" + workinProgressAccAccDestAccDest));
            if (!(String.IsNullOrEmpty(workinProgressAccAccDestCompanyTypeDescription)))
            	filter.Add(("WorkinProgressAccAccDestCompanyTypeDescription:*" + workinProgressAccAccDestCompanyTypeDescription));
            if (!(String.IsNullOrEmpty(workinProgressAccAccFundAccFundCode)))
            	filter.Add(("WorkinProgressAccAccFundAccFundCode:*" + workinProgressAccAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(workinProgressAccAccSubTypeAccSubType)))
            	filter.Add(("WorkinProgressAccAccSubTypeAccSubType:*" + workinProgressAccAccSubTypeAccSubType));
            if (!(String.IsNullOrEmpty(workinProgressAccAccTypeAccType)))
            	filter.Add(("WorkinProgressAccAccTypeAccType:*" + workinProgressAccAccTypeAccType));
            if (!(String.IsNullOrEmpty(workinProgressAccCoaControlAccName)))
            	filter.Add(("WorkinProgressAccCoaControlAccName:*" + workinProgressAccCoaControlAccName));
            if (!(String.IsNullOrEmpty(workinProgressAccCoaControlAccBalTypeAccBalType)))
            	filter.Add(("WorkinProgressAccCoaControlAccBalTypeAccBalType:*" + workinProgressAccCoaControlAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(workinProgressAccCoaControlAccDestAccDest)))
            	filter.Add(("WorkinProgressAccCoaControlAccDestAccDest:*" + workinProgressAccCoaControlAccDestAccDest));
            if (!(String.IsNullOrEmpty(workinProgressAccCoaControlAccTypeAccType)))
            	filter.Add(("WorkinProgressAccCoaControlAccTypeAccType:*" + workinProgressAccCoaControlAccTypeAccType));
            if (!(String.IsNullOrEmpty(workinProgressAccCoaControlCompTypeDescription)))
            	filter.Add(("WorkinProgressAccCoaControlCompTypeDescription:*" + workinProgressAccCoaControlCompTypeDescription));
            if (!(String.IsNullOrEmpty(workinProgressAccCoaMainAccName)))
            	filter.Add(("WorkinProgressAccCoaMainAccName:*" + workinProgressAccCoaMainAccName));
            if (!(String.IsNullOrEmpty(workinProgressAccCoaMainAccBalTypeAccBalType)))
            	filter.Add(("WorkinProgressAccCoaMainAccBalTypeAccBalType:*" + workinProgressAccCoaMainAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(workinProgressAccCoaMainAccDestAccDest)))
            	filter.Add(("WorkinProgressAccCoaMainAccDestAccDest:*" + workinProgressAccCoaMainAccDestAccDest));
            if (!(String.IsNullOrEmpty(workinProgressAccCoaMainAccFundAccFundCode)))
            	filter.Add(("WorkinProgressAccCoaMainAccFundAccFundCode:*" + workinProgressAccCoaMainAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(workinProgressAccCoaMainAccTypeAccType)))
            	filter.Add(("WorkinProgressAccCoaMainAccTypeAccType:*" + workinProgressAccCoaMainAccTypeAccType));
            if (!(String.IsNullOrEmpty(workinProgressAccCoaMainCoaControlAccName)))
            	filter.Add(("WorkinProgressAccCoaMainCoaControlAccName:*" + workinProgressAccCoaMainCoaControlAccName));
            if (!(String.IsNullOrEmpty(workinProgressAccCoaSubAccName)))
            	filter.Add(("WorkinProgressAccCoaSubAccName:*" + workinProgressAccCoaSubAccName));
            if (!(String.IsNullOrEmpty(workinProgressAccCoaSubAccBalTypeAccBalType)))
            	filter.Add(("WorkinProgressAccCoaSubAccBalTypeAccBalType:*" + workinProgressAccCoaSubAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(workinProgressAccCoaSubAccDestAccDest)))
            	filter.Add(("WorkinProgressAccCoaSubAccDestAccDest:*" + workinProgressAccCoaSubAccDestAccDest));
            if (!(String.IsNullOrEmpty(workinProgressAccCoaSubAccFundAccFundCode)))
            	filter.Add(("WorkinProgressAccCoaSubAccFundAccFundCode:*" + workinProgressAccCoaSubAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(workinProgressAccCoaSubAccTypeAccType)))
            	filter.Add(("WorkinProgressAccCoaSubAccTypeAccType:*" + workinProgressAccCoaSubAccTypeAccType));
            if (!(String.IsNullOrEmpty(workinProgressAccCoaSubCoaControlAccName)))
            	filter.Add(("WorkinProgressAccCoaSubCoaControlAccName:*" + workinProgressAccCoaSubCoaControlAccName));
            if (!(String.IsNullOrEmpty(workinProgressAccCoaSubCoaMainAccName)))
            	filter.Add(("WorkinProgressAccCoaSubCoaMainAccName:*" + workinProgressAccCoaSubCoaMainAccName));
            if (costofSold.HasValue)
            	filter.Add(("CostofSold:=" + costofSold.Value.ToString()));
            if (!(String.IsNullOrEmpty(costofSoldAccName)))
            	filter.Add(("CostofSoldAccName:*" + costofSoldAccName));
            if (!(String.IsNullOrEmpty(costofSoldAccBalTypeAccBalType)))
            	filter.Add(("CostofSoldAccBalTypeAccBalType:*" + costofSoldAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(costofSoldAccCurrencyAccCurrencyName)))
            	filter.Add(("CostofSoldAccCurrencyAccCurrencyName:*" + costofSoldAccCurrencyAccCurrencyName));
            if (!(String.IsNullOrEmpty(costofSoldAccDestAccDest)))
            	filter.Add(("CostofSoldAccDestAccDest:*" + costofSoldAccDestAccDest));
            if (!(String.IsNullOrEmpty(costofSoldAccDestCompanyTypeDescription)))
            	filter.Add(("CostofSoldAccDestCompanyTypeDescription:*" + costofSoldAccDestCompanyTypeDescription));
            if (!(String.IsNullOrEmpty(costofSoldAccFundAccFundCode)))
            	filter.Add(("CostofSoldAccFundAccFundCode:*" + costofSoldAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(costofSoldAccSubTypeAccSubType)))
            	filter.Add(("CostofSoldAccSubTypeAccSubType:*" + costofSoldAccSubTypeAccSubType));
            if (!(String.IsNullOrEmpty(costofSoldAccTypeAccType)))
            	filter.Add(("CostofSoldAccTypeAccType:*" + costofSoldAccTypeAccType));
            if (!(String.IsNullOrEmpty(costofSoldCoaControlAccName)))
            	filter.Add(("CostofSoldCoaControlAccName:*" + costofSoldCoaControlAccName));
            if (!(String.IsNullOrEmpty(costofSoldCoaControlAccBalTypeAccBalType)))
            	filter.Add(("CostofSoldCoaControlAccBalTypeAccBalType:*" + costofSoldCoaControlAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(costofSoldCoaControlAccDestAccDest)))
            	filter.Add(("CostofSoldCoaControlAccDestAccDest:*" + costofSoldCoaControlAccDestAccDest));
            if (!(String.IsNullOrEmpty(costofSoldCoaControlAccTypeAccType)))
            	filter.Add(("CostofSoldCoaControlAccTypeAccType:*" + costofSoldCoaControlAccTypeAccType));
            if (!(String.IsNullOrEmpty(costofSoldCoaControlCompTypeDescription)))
            	filter.Add(("CostofSoldCoaControlCompTypeDescription:*" + costofSoldCoaControlCompTypeDescription));
            if (!(String.IsNullOrEmpty(costofSoldCoaMainAccName)))
            	filter.Add(("CostofSoldCoaMainAccName:*" + costofSoldCoaMainAccName));
            if (!(String.IsNullOrEmpty(costofSoldCoaMainAccBalTypeAccBalType)))
            	filter.Add(("CostofSoldCoaMainAccBalTypeAccBalType:*" + costofSoldCoaMainAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(costofSoldCoaMainAccDestAccDest)))
            	filter.Add(("CostofSoldCoaMainAccDestAccDest:*" + costofSoldCoaMainAccDestAccDest));
            if (!(String.IsNullOrEmpty(costofSoldCoaMainAccFundAccFundCode)))
            	filter.Add(("CostofSoldCoaMainAccFundAccFundCode:*" + costofSoldCoaMainAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(costofSoldCoaMainAccTypeAccType)))
            	filter.Add(("CostofSoldCoaMainAccTypeAccType:*" + costofSoldCoaMainAccTypeAccType));
            if (!(String.IsNullOrEmpty(costofSoldCoaMainCoaControlAccName)))
            	filter.Add(("CostofSoldCoaMainCoaControlAccName:*" + costofSoldCoaMainCoaControlAccName));
            if (!(String.IsNullOrEmpty(costofSoldCoaSubAccName)))
            	filter.Add(("CostofSoldCoaSubAccName:*" + costofSoldCoaSubAccName));
            if (!(String.IsNullOrEmpty(costofSoldCoaSubAccBalTypeAccBalType)))
            	filter.Add(("CostofSoldCoaSubAccBalTypeAccBalType:*" + costofSoldCoaSubAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(costofSoldCoaSubAccDestAccDest)))
            	filter.Add(("CostofSoldCoaSubAccDestAccDest:*" + costofSoldCoaSubAccDestAccDest));
            if (!(String.IsNullOrEmpty(costofSoldCoaSubAccFundAccFundCode)))
            	filter.Add(("CostofSoldCoaSubAccFundAccFundCode:*" + costofSoldCoaSubAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(costofSoldCoaSubAccTypeAccType)))
            	filter.Add(("CostofSoldCoaSubAccTypeAccType:*" + costofSoldCoaSubAccTypeAccType));
            if (!(String.IsNullOrEmpty(costofSoldCoaSubCoaControlAccName)))
            	filter.Add(("CostofSoldCoaSubCoaControlAccName:*" + costofSoldCoaSubCoaControlAccName));
            if (!(String.IsNullOrEmpty(costofSoldCoaSubCoaMainAccName)))
            	filter.Add(("CostofSoldCoaSubCoaMainAccName:*" + costofSoldCoaSubCoaMainAccName));
            if (oPD_Acc.HasValue)
            	filter.Add(("OPD_Acc:=" + oPD_Acc.Value.ToString()));
            if (!(String.IsNullOrEmpty(oPD_AccAccName)))
            	filter.Add(("OPD_AccAccName:*" + oPD_AccAccName));
            if (!(String.IsNullOrEmpty(oPD_AccAccBalTypeAccBalType)))
            	filter.Add(("OPD_AccAccBalTypeAccBalType:*" + oPD_AccAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(oPD_AccAccCurrencyAccCurrencyName)))
            	filter.Add(("OPD_AccAccCurrencyAccCurrencyName:*" + oPD_AccAccCurrencyAccCurrencyName));
            if (!(String.IsNullOrEmpty(oPD_AccAccDestAccDest)))
            	filter.Add(("OPD_AccAccDestAccDest:*" + oPD_AccAccDestAccDest));
            if (!(String.IsNullOrEmpty(oPD_AccAccDestCompanyTypeDescription)))
            	filter.Add(("OPD_AccAccDestCompanyTypeDescription:*" + oPD_AccAccDestCompanyTypeDescription));
            if (!(String.IsNullOrEmpty(oPD_AccAccFundAccFundCode)))
            	filter.Add(("OPD_AccAccFundAccFundCode:*" + oPD_AccAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(oPD_AccAccSubTypeAccSubType)))
            	filter.Add(("OPD_AccAccSubTypeAccSubType:*" + oPD_AccAccSubTypeAccSubType));
            if (!(String.IsNullOrEmpty(oPD_AccAccTypeAccType)))
            	filter.Add(("OPD_AccAccTypeAccType:*" + oPD_AccAccTypeAccType));
            if (!(String.IsNullOrEmpty(oPD_AccCoaControlAccName)))
            	filter.Add(("OPD_AccCoaControlAccName:*" + oPD_AccCoaControlAccName));
            if (!(String.IsNullOrEmpty(oPD_AccCoaControlAccBalTypeAccBalType)))
            	filter.Add(("OPD_AccCoaControlAccBalTypeAccBalType:*" + oPD_AccCoaControlAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(oPD_AccCoaControlAccDestAccDest)))
            	filter.Add(("OPD_AccCoaControlAccDestAccDest:*" + oPD_AccCoaControlAccDestAccDest));
            if (!(String.IsNullOrEmpty(oPD_AccCoaControlAccTypeAccType)))
            	filter.Add(("OPD_AccCoaControlAccTypeAccType:*" + oPD_AccCoaControlAccTypeAccType));
            if (!(String.IsNullOrEmpty(oPD_AccCoaControlCompTypeDescription)))
            	filter.Add(("OPD_AccCoaControlCompTypeDescription:*" + oPD_AccCoaControlCompTypeDescription));
            if (!(String.IsNullOrEmpty(oPD_AccCoaMainAccName)))
            	filter.Add(("OPD_AccCoaMainAccName:*" + oPD_AccCoaMainAccName));
            if (!(String.IsNullOrEmpty(oPD_AccCoaMainAccBalTypeAccBalType)))
            	filter.Add(("OPD_AccCoaMainAccBalTypeAccBalType:*" + oPD_AccCoaMainAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(oPD_AccCoaMainAccDestAccDest)))
            	filter.Add(("OPD_AccCoaMainAccDestAccDest:*" + oPD_AccCoaMainAccDestAccDest));
            if (!(String.IsNullOrEmpty(oPD_AccCoaMainAccFundAccFundCode)))
            	filter.Add(("OPD_AccCoaMainAccFundAccFundCode:*" + oPD_AccCoaMainAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(oPD_AccCoaMainAccTypeAccType)))
            	filter.Add(("OPD_AccCoaMainAccTypeAccType:*" + oPD_AccCoaMainAccTypeAccType));
            if (!(String.IsNullOrEmpty(oPD_AccCoaMainCoaControlAccName)))
            	filter.Add(("OPD_AccCoaMainCoaControlAccName:*" + oPD_AccCoaMainCoaControlAccName));
            if (!(String.IsNullOrEmpty(oPD_AccCoaSubAccName)))
            	filter.Add(("OPD_AccCoaSubAccName:*" + oPD_AccCoaSubAccName));
            if (!(String.IsNullOrEmpty(oPD_AccCoaSubAccBalTypeAccBalType)))
            	filter.Add(("OPD_AccCoaSubAccBalTypeAccBalType:*" + oPD_AccCoaSubAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(oPD_AccCoaSubAccDestAccDest)))
            	filter.Add(("OPD_AccCoaSubAccDestAccDest:*" + oPD_AccCoaSubAccDestAccDest));
            if (!(String.IsNullOrEmpty(oPD_AccCoaSubAccFundAccFundCode)))
            	filter.Add(("OPD_AccCoaSubAccFundAccFundCode:*" + oPD_AccCoaSubAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(oPD_AccCoaSubAccTypeAccType)))
            	filter.Add(("OPD_AccCoaSubAccTypeAccType:*" + oPD_AccCoaSubAccTypeAccType));
            if (!(String.IsNullOrEmpty(oPD_AccCoaSubCoaControlAccName)))
            	filter.Add(("OPD_AccCoaSubCoaControlAccName:*" + oPD_AccCoaSubCoaControlAccName));
            if (!(String.IsNullOrEmpty(oPD_AccCoaSubCoaMainAccName)))
            	filter.Add(("OPD_AccCoaSubCoaMainAccName:*" + oPD_AccCoaSubCoaMainAccName));
            if (advPat_Acc.HasValue)
            	filter.Add(("AdvPat_Acc:=" + advPat_Acc.Value.ToString()));
            if (!(String.IsNullOrEmpty(advPat_AccAccName)))
            	filter.Add(("AdvPat_AccAccName:*" + advPat_AccAccName));
            if (!(String.IsNullOrEmpty(advPat_AccAccBalTypeAccBalType)))
            	filter.Add(("AdvPat_AccAccBalTypeAccBalType:*" + advPat_AccAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(advPat_AccAccCurrencyAccCurrencyName)))
            	filter.Add(("AdvPat_AccAccCurrencyAccCurrencyName:*" + advPat_AccAccCurrencyAccCurrencyName));
            if (!(String.IsNullOrEmpty(advPat_AccAccDestAccDest)))
            	filter.Add(("AdvPat_AccAccDestAccDest:*" + advPat_AccAccDestAccDest));
            if (!(String.IsNullOrEmpty(advPat_AccAccDestCompanyTypeDescription)))
            	filter.Add(("AdvPat_AccAccDestCompanyTypeDescription:*" + advPat_AccAccDestCompanyTypeDescription));
            if (!(String.IsNullOrEmpty(advPat_AccAccFundAccFundCode)))
            	filter.Add(("AdvPat_AccAccFundAccFundCode:*" + advPat_AccAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(advPat_AccAccSubTypeAccSubType)))
            	filter.Add(("AdvPat_AccAccSubTypeAccSubType:*" + advPat_AccAccSubTypeAccSubType));
            if (!(String.IsNullOrEmpty(advPat_AccAccTypeAccType)))
            	filter.Add(("AdvPat_AccAccTypeAccType:*" + advPat_AccAccTypeAccType));
            if (!(String.IsNullOrEmpty(advPat_AccCoaControlAccName)))
            	filter.Add(("AdvPat_AccCoaControlAccName:*" + advPat_AccCoaControlAccName));
            if (!(String.IsNullOrEmpty(advPat_AccCoaControlAccBalTypeAccBalType)))
            	filter.Add(("AdvPat_AccCoaControlAccBalTypeAccBalType:*" + advPat_AccCoaControlAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(advPat_AccCoaControlAccDestAccDest)))
            	filter.Add(("AdvPat_AccCoaControlAccDestAccDest:*" + advPat_AccCoaControlAccDestAccDest));
            if (!(String.IsNullOrEmpty(advPat_AccCoaControlAccTypeAccType)))
            	filter.Add(("AdvPat_AccCoaControlAccTypeAccType:*" + advPat_AccCoaControlAccTypeAccType));
            if (!(String.IsNullOrEmpty(advPat_AccCoaControlCompTypeDescription)))
            	filter.Add(("AdvPat_AccCoaControlCompTypeDescription:*" + advPat_AccCoaControlCompTypeDescription));
            if (!(String.IsNullOrEmpty(advPat_AccCoaMainAccName)))
            	filter.Add(("AdvPat_AccCoaMainAccName:*" + advPat_AccCoaMainAccName));
            if (!(String.IsNullOrEmpty(advPat_AccCoaMainAccBalTypeAccBalType)))
            	filter.Add(("AdvPat_AccCoaMainAccBalTypeAccBalType:*" + advPat_AccCoaMainAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(advPat_AccCoaMainAccDestAccDest)))
            	filter.Add(("AdvPat_AccCoaMainAccDestAccDest:*" + advPat_AccCoaMainAccDestAccDest));
            if (!(String.IsNullOrEmpty(advPat_AccCoaMainAccFundAccFundCode)))
            	filter.Add(("AdvPat_AccCoaMainAccFundAccFundCode:*" + advPat_AccCoaMainAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(advPat_AccCoaMainAccTypeAccType)))
            	filter.Add(("AdvPat_AccCoaMainAccTypeAccType:*" + advPat_AccCoaMainAccTypeAccType));
            if (!(String.IsNullOrEmpty(advPat_AccCoaMainCoaControlAccName)))
            	filter.Add(("AdvPat_AccCoaMainCoaControlAccName:*" + advPat_AccCoaMainCoaControlAccName));
            if (!(String.IsNullOrEmpty(advPat_AccCoaSubAccName)))
            	filter.Add(("AdvPat_AccCoaSubAccName:*" + advPat_AccCoaSubAccName));
            if (!(String.IsNullOrEmpty(advPat_AccCoaSubAccBalTypeAccBalType)))
            	filter.Add(("AdvPat_AccCoaSubAccBalTypeAccBalType:*" + advPat_AccCoaSubAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(advPat_AccCoaSubAccDestAccDest)))
            	filter.Add(("AdvPat_AccCoaSubAccDestAccDest:*" + advPat_AccCoaSubAccDestAccDest));
            if (!(String.IsNullOrEmpty(advPat_AccCoaSubAccFundAccFundCode)))
            	filter.Add(("AdvPat_AccCoaSubAccFundAccFundCode:*" + advPat_AccCoaSubAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(advPat_AccCoaSubAccTypeAccType)))
            	filter.Add(("AdvPat_AccCoaSubAccTypeAccType:*" + advPat_AccCoaSubAccTypeAccType));
            if (!(String.IsNullOrEmpty(advPat_AccCoaSubCoaControlAccName)))
            	filter.Add(("AdvPat_AccCoaSubCoaControlAccName:*" + advPat_AccCoaSubCoaControlAccName));
            if (!(String.IsNullOrEmpty(advPat_AccCoaSubCoaMainAccName)))
            	filter.Add(("AdvPat_AccCoaSubCoaMainAccName:*" + advPat_AccCoaSubCoaMainAccName));
            if (investigate_Acc.HasValue)
            	filter.Add(("Investigate_Acc:=" + investigate_Acc.Value.ToString()));
            if (!(String.IsNullOrEmpty(investigate_AccAccName)))
            	filter.Add(("Investigate_AccAccName:*" + investigate_AccAccName));
            if (!(String.IsNullOrEmpty(investigate_AccAccBalTypeAccBalType)))
            	filter.Add(("Investigate_AccAccBalTypeAccBalType:*" + investigate_AccAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(investigate_AccAccCurrencyAccCurrencyName)))
            	filter.Add(("Investigate_AccAccCurrencyAccCurrencyName:*" + investigate_AccAccCurrencyAccCurrencyName));
            if (!(String.IsNullOrEmpty(investigate_AccAccDestAccDest)))
            	filter.Add(("Investigate_AccAccDestAccDest:*" + investigate_AccAccDestAccDest));
            if (!(String.IsNullOrEmpty(investigate_AccAccDestCompanyTypeDescription)))
            	filter.Add(("Investigate_AccAccDestCompanyTypeDescription:*" + investigate_AccAccDestCompanyTypeDescription));
            if (!(String.IsNullOrEmpty(investigate_AccAccFundAccFundCode)))
            	filter.Add(("Investigate_AccAccFundAccFundCode:*" + investigate_AccAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(investigate_AccAccSubTypeAccSubType)))
            	filter.Add(("Investigate_AccAccSubTypeAccSubType:*" + investigate_AccAccSubTypeAccSubType));
            if (!(String.IsNullOrEmpty(investigate_AccAccTypeAccType)))
            	filter.Add(("Investigate_AccAccTypeAccType:*" + investigate_AccAccTypeAccType));
            if (!(String.IsNullOrEmpty(investigate_AccCoaControlAccName)))
            	filter.Add(("Investigate_AccCoaControlAccName:*" + investigate_AccCoaControlAccName));
            if (!(String.IsNullOrEmpty(investigate_AccCoaControlAccBalTypeAccBalType)))
            	filter.Add(("Investigate_AccCoaControlAccBalTypeAccBalType:*" + investigate_AccCoaControlAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(investigate_AccCoaControlAccDestAccDest)))
            	filter.Add(("Investigate_AccCoaControlAccDestAccDest:*" + investigate_AccCoaControlAccDestAccDest));
            if (!(String.IsNullOrEmpty(investigate_AccCoaControlAccTypeAccType)))
            	filter.Add(("Investigate_AccCoaControlAccTypeAccType:*" + investigate_AccCoaControlAccTypeAccType));
            if (!(String.IsNullOrEmpty(investigate_AccCoaControlCompTypeDescription)))
            	filter.Add(("Investigate_AccCoaControlCompTypeDescription:*" + investigate_AccCoaControlCompTypeDescription));
            if (!(String.IsNullOrEmpty(investigate_AccCoaMainAccName)))
            	filter.Add(("Investigate_AccCoaMainAccName:*" + investigate_AccCoaMainAccName));
            if (!(String.IsNullOrEmpty(investigate_AccCoaMainAccBalTypeAccBalType)))
            	filter.Add(("Investigate_AccCoaMainAccBalTypeAccBalType:*" + investigate_AccCoaMainAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(investigate_AccCoaMainAccDestAccDest)))
            	filter.Add(("Investigate_AccCoaMainAccDestAccDest:*" + investigate_AccCoaMainAccDestAccDest));
            if (!(String.IsNullOrEmpty(investigate_AccCoaMainAccFundAccFundCode)))
            	filter.Add(("Investigate_AccCoaMainAccFundAccFundCode:*" + investigate_AccCoaMainAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(investigate_AccCoaMainAccTypeAccType)))
            	filter.Add(("Investigate_AccCoaMainAccTypeAccType:*" + investigate_AccCoaMainAccTypeAccType));
            if (!(String.IsNullOrEmpty(investigate_AccCoaMainCoaControlAccName)))
            	filter.Add(("Investigate_AccCoaMainCoaControlAccName:*" + investigate_AccCoaMainCoaControlAccName));
            if (!(String.IsNullOrEmpty(investigate_AccCoaSubAccName)))
            	filter.Add(("Investigate_AccCoaSubAccName:*" + investigate_AccCoaSubAccName));
            if (!(String.IsNullOrEmpty(investigate_AccCoaSubAccBalTypeAccBalType)))
            	filter.Add(("Investigate_AccCoaSubAccBalTypeAccBalType:*" + investigate_AccCoaSubAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(investigate_AccCoaSubAccDestAccDest)))
            	filter.Add(("Investigate_AccCoaSubAccDestAccDest:*" + investigate_AccCoaSubAccDestAccDest));
            if (!(String.IsNullOrEmpty(investigate_AccCoaSubAccFundAccFundCode)))
            	filter.Add(("Investigate_AccCoaSubAccFundAccFundCode:*" + investigate_AccCoaSubAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(investigate_AccCoaSubAccTypeAccType)))
            	filter.Add(("Investigate_AccCoaSubAccTypeAccType:*" + investigate_AccCoaSubAccTypeAccType));
            if (!(String.IsNullOrEmpty(investigate_AccCoaSubCoaControlAccName)))
            	filter.Add(("Investigate_AccCoaSubCoaControlAccName:*" + investigate_AccCoaSubCoaControlAccName));
            if (!(String.IsNullOrEmpty(investigate_AccCoaSubCoaMainAccName)))
            	filter.Add(("Investigate_AccCoaSubCoaMainAccName:*" + investigate_AccCoaSubCoaMainAccName));
            if (vatAcc.HasValue)
            	filter.Add(("VatAcc:=" + vatAcc.Value.ToString()));
            if (!(String.IsNullOrEmpty(vatAccAccName)))
            	filter.Add(("VatAccAccName:*" + vatAccAccName));
            if (!(String.IsNullOrEmpty(vatAccAccBalTypeAccBalType)))
            	filter.Add(("VatAccAccBalTypeAccBalType:*" + vatAccAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(vatAccAccCurrencyAccCurrencyName)))
            	filter.Add(("VatAccAccCurrencyAccCurrencyName:*" + vatAccAccCurrencyAccCurrencyName));
            if (!(String.IsNullOrEmpty(vatAccAccDestAccDest)))
            	filter.Add(("VatAccAccDestAccDest:*" + vatAccAccDestAccDest));
            if (!(String.IsNullOrEmpty(vatAccAccDestCompanyTypeDescription)))
            	filter.Add(("VatAccAccDestCompanyTypeDescription:*" + vatAccAccDestCompanyTypeDescription));
            if (!(String.IsNullOrEmpty(vatAccAccFundAccFundCode)))
            	filter.Add(("VatAccAccFundAccFundCode:*" + vatAccAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(vatAccAccSubTypeAccSubType)))
            	filter.Add(("VatAccAccSubTypeAccSubType:*" + vatAccAccSubTypeAccSubType));
            if (!(String.IsNullOrEmpty(vatAccAccTypeAccType)))
            	filter.Add(("VatAccAccTypeAccType:*" + vatAccAccTypeAccType));
            if (!(String.IsNullOrEmpty(vatAccCoaControlAccName)))
            	filter.Add(("VatAccCoaControlAccName:*" + vatAccCoaControlAccName));
            if (!(String.IsNullOrEmpty(vatAccCoaControlAccBalTypeAccBalType)))
            	filter.Add(("VatAccCoaControlAccBalTypeAccBalType:*" + vatAccCoaControlAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(vatAccCoaControlAccDestAccDest)))
            	filter.Add(("VatAccCoaControlAccDestAccDest:*" + vatAccCoaControlAccDestAccDest));
            if (!(String.IsNullOrEmpty(vatAccCoaControlAccTypeAccType)))
            	filter.Add(("VatAccCoaControlAccTypeAccType:*" + vatAccCoaControlAccTypeAccType));
            if (!(String.IsNullOrEmpty(vatAccCoaControlCompTypeDescription)))
            	filter.Add(("VatAccCoaControlCompTypeDescription:*" + vatAccCoaControlCompTypeDescription));
            if (!(String.IsNullOrEmpty(vatAccCoaMainAccName)))
            	filter.Add(("VatAccCoaMainAccName:*" + vatAccCoaMainAccName));
            if (!(String.IsNullOrEmpty(vatAccCoaMainAccBalTypeAccBalType)))
            	filter.Add(("VatAccCoaMainAccBalTypeAccBalType:*" + vatAccCoaMainAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(vatAccCoaMainAccDestAccDest)))
            	filter.Add(("VatAccCoaMainAccDestAccDest:*" + vatAccCoaMainAccDestAccDest));
            if (!(String.IsNullOrEmpty(vatAccCoaMainAccFundAccFundCode)))
            	filter.Add(("VatAccCoaMainAccFundAccFundCode:*" + vatAccCoaMainAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(vatAccCoaMainAccTypeAccType)))
            	filter.Add(("VatAccCoaMainAccTypeAccType:*" + vatAccCoaMainAccTypeAccType));
            if (!(String.IsNullOrEmpty(vatAccCoaMainCoaControlAccName)))
            	filter.Add(("VatAccCoaMainCoaControlAccName:*" + vatAccCoaMainCoaControlAccName));
            if (!(String.IsNullOrEmpty(vatAccCoaSubAccName)))
            	filter.Add(("VatAccCoaSubAccName:*" + vatAccCoaSubAccName));
            if (!(String.IsNullOrEmpty(vatAccCoaSubAccBalTypeAccBalType)))
            	filter.Add(("VatAccCoaSubAccBalTypeAccBalType:*" + vatAccCoaSubAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(vatAccCoaSubAccDestAccDest)))
            	filter.Add(("VatAccCoaSubAccDestAccDest:*" + vatAccCoaSubAccDestAccDest));
            if (!(String.IsNullOrEmpty(vatAccCoaSubAccFundAccFundCode)))
            	filter.Add(("VatAccCoaSubAccFundAccFundCode:*" + vatAccCoaSubAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(vatAccCoaSubAccTypeAccType)))
            	filter.Add(("VatAccCoaSubAccTypeAccType:*" + vatAccCoaSubAccTypeAccType));
            if (!(String.IsNullOrEmpty(vatAccCoaSubCoaControlAccName)))
            	filter.Add(("VatAccCoaSubCoaControlAccName:*" + vatAccCoaSubCoaControlAccName));
            if (!(String.IsNullOrEmpty(vatAccCoaSubCoaMainAccName)))
            	filter.Add(("VatAccCoaSubCoaMainAccName:*" + vatAccCoaSubCoaMainAccName));
            if (sundryDebitors.HasValue)
            	filter.Add(("SundryDebitors:=" + sundryDebitors.Value.ToString()));
            if (!(String.IsNullOrEmpty(sundryDebitorsAccName)))
            	filter.Add(("SundryDebitorsAccName:*" + sundryDebitorsAccName));
            if (!(String.IsNullOrEmpty(sundryDebitorsAccBalTypeAccBalType)))
            	filter.Add(("SundryDebitorsAccBalTypeAccBalType:*" + sundryDebitorsAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(sundryDebitorsAccCurrencyAccCurrencyName)))
            	filter.Add(("SundryDebitorsAccCurrencyAccCurrencyName:*" + sundryDebitorsAccCurrencyAccCurrencyName));
            if (!(String.IsNullOrEmpty(sundryDebitorsAccDestAccDest)))
            	filter.Add(("SundryDebitorsAccDestAccDest:*" + sundryDebitorsAccDestAccDest));
            if (!(String.IsNullOrEmpty(sundryDebitorsAccDestCompanyTypeDescription)))
            	filter.Add(("SundryDebitorsAccDestCompanyTypeDescription:*" + sundryDebitorsAccDestCompanyTypeDescription));
            if (!(String.IsNullOrEmpty(sundryDebitorsAccFundAccFundCode)))
            	filter.Add(("SundryDebitorsAccFundAccFundCode:*" + sundryDebitorsAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(sundryDebitorsAccSubTypeAccSubType)))
            	filter.Add(("SundryDebitorsAccSubTypeAccSubType:*" + sundryDebitorsAccSubTypeAccSubType));
            if (!(String.IsNullOrEmpty(sundryDebitorsAccTypeAccType)))
            	filter.Add(("SundryDebitorsAccTypeAccType:*" + sundryDebitorsAccTypeAccType));
            if (!(String.IsNullOrEmpty(sundryDebitorsCoaControlAccName)))
            	filter.Add(("SundryDebitorsCoaControlAccName:*" + sundryDebitorsCoaControlAccName));
            if (!(String.IsNullOrEmpty(sundryDebitorsCoaControlAccBalTypeAccBalType)))
            	filter.Add(("SundryDebitorsCoaControlAccBalTypeAccBalType:*" + sundryDebitorsCoaControlAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(sundryDebitorsCoaControlAccDestAccDest)))
            	filter.Add(("SundryDebitorsCoaControlAccDestAccDest:*" + sundryDebitorsCoaControlAccDestAccDest));
            if (!(String.IsNullOrEmpty(sundryDebitorsCoaControlAccTypeAccType)))
            	filter.Add(("SundryDebitorsCoaControlAccTypeAccType:*" + sundryDebitorsCoaControlAccTypeAccType));
            if (!(String.IsNullOrEmpty(sundryDebitorsCoaControlCompTypeDescription)))
            	filter.Add(("SundryDebitorsCoaControlCompTypeDescription:*" + sundryDebitorsCoaControlCompTypeDescription));
            if (!(String.IsNullOrEmpty(sundryDebitorsCoaMainAccName)))
            	filter.Add(("SundryDebitorsCoaMainAccName:*" + sundryDebitorsCoaMainAccName));
            if (!(String.IsNullOrEmpty(sundryDebitorsCoaMainAccBalTypeAccBalType)))
            	filter.Add(("SundryDebitorsCoaMainAccBalTypeAccBalType:*" + sundryDebitorsCoaMainAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(sundryDebitorsCoaMainAccDestAccDest)))
            	filter.Add(("SundryDebitorsCoaMainAccDestAccDest:*" + sundryDebitorsCoaMainAccDestAccDest));
            if (!(String.IsNullOrEmpty(sundryDebitorsCoaMainAccFundAccFundCode)))
            	filter.Add(("SundryDebitorsCoaMainAccFundAccFundCode:*" + sundryDebitorsCoaMainAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(sundryDebitorsCoaMainAccTypeAccType)))
            	filter.Add(("SundryDebitorsCoaMainAccTypeAccType:*" + sundryDebitorsCoaMainAccTypeAccType));
            if (!(String.IsNullOrEmpty(sundryDebitorsCoaMainCoaControlAccName)))
            	filter.Add(("SundryDebitorsCoaMainCoaControlAccName:*" + sundryDebitorsCoaMainCoaControlAccName));
            if (!(String.IsNullOrEmpty(sundryDebitorsCoaSubAccName)))
            	filter.Add(("SundryDebitorsCoaSubAccName:*" + sundryDebitorsCoaSubAccName));
            if (!(String.IsNullOrEmpty(sundryDebitorsCoaSubAccBalTypeAccBalType)))
            	filter.Add(("SundryDebitorsCoaSubAccBalTypeAccBalType:*" + sundryDebitorsCoaSubAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(sundryDebitorsCoaSubAccDestAccDest)))
            	filter.Add(("SundryDebitorsCoaSubAccDestAccDest:*" + sundryDebitorsCoaSubAccDestAccDest));
            if (!(String.IsNullOrEmpty(sundryDebitorsCoaSubAccFundAccFundCode)))
            	filter.Add(("SundryDebitorsCoaSubAccFundAccFundCode:*" + sundryDebitorsCoaSubAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(sundryDebitorsCoaSubAccTypeAccType)))
            	filter.Add(("SundryDebitorsCoaSubAccTypeAccType:*" + sundryDebitorsCoaSubAccTypeAccType));
            if (!(String.IsNullOrEmpty(sundryDebitorsCoaSubCoaControlAccName)))
            	filter.Add(("SundryDebitorsCoaSubCoaControlAccName:*" + sundryDebitorsCoaSubCoaControlAccName));
            if (!(String.IsNullOrEmpty(sundryDebitorsCoaSubCoaMainAccName)))
            	filter.Add(("SundryDebitorsCoaSubCoaMainAccName:*" + sundryDebitorsCoaSubCoaMainAccName));
            if (sundryCreditors.HasValue)
            	filter.Add(("SundryCreditors:=" + sundryCreditors.Value.ToString()));
            if (!(String.IsNullOrEmpty(sundryCreditorsAccName)))
            	filter.Add(("SundryCreditorsAccName:*" + sundryCreditorsAccName));
            if (!(String.IsNullOrEmpty(sundryCreditorsAccBalTypeAccBalType)))
            	filter.Add(("SundryCreditorsAccBalTypeAccBalType:*" + sundryCreditorsAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(sundryCreditorsAccCurrencyAccCurrencyName)))
            	filter.Add(("SundryCreditorsAccCurrencyAccCurrencyName:*" + sundryCreditorsAccCurrencyAccCurrencyName));
            if (!(String.IsNullOrEmpty(sundryCreditorsAccDestAccDest)))
            	filter.Add(("SundryCreditorsAccDestAccDest:*" + sundryCreditorsAccDestAccDest));
            if (!(String.IsNullOrEmpty(sundryCreditorsAccDestCompanyTypeDescription)))
            	filter.Add(("SundryCreditorsAccDestCompanyTypeDescription:*" + sundryCreditorsAccDestCompanyTypeDescription));
            if (!(String.IsNullOrEmpty(sundryCreditorsAccFundAccFundCode)))
            	filter.Add(("SundryCreditorsAccFundAccFundCode:*" + sundryCreditorsAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(sundryCreditorsAccSubTypeAccSubType)))
            	filter.Add(("SundryCreditorsAccSubTypeAccSubType:*" + sundryCreditorsAccSubTypeAccSubType));
            if (!(String.IsNullOrEmpty(sundryCreditorsAccTypeAccType)))
            	filter.Add(("SundryCreditorsAccTypeAccType:*" + sundryCreditorsAccTypeAccType));
            if (!(String.IsNullOrEmpty(sundryCreditorsCoaControlAccName)))
            	filter.Add(("SundryCreditorsCoaControlAccName:*" + sundryCreditorsCoaControlAccName));
            if (!(String.IsNullOrEmpty(sundryCreditorsCoaControlAccBalTypeAccBalType)))
            	filter.Add(("SundryCreditorsCoaControlAccBalTypeAccBalType:*" + sundryCreditorsCoaControlAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(sundryCreditorsCoaControlAccDestAccDest)))
            	filter.Add(("SundryCreditorsCoaControlAccDestAccDest:*" + sundryCreditorsCoaControlAccDestAccDest));
            if (!(String.IsNullOrEmpty(sundryCreditorsCoaControlAccTypeAccType)))
            	filter.Add(("SundryCreditorsCoaControlAccTypeAccType:*" + sundryCreditorsCoaControlAccTypeAccType));
            if (!(String.IsNullOrEmpty(sundryCreditorsCoaControlCompTypeDescription)))
            	filter.Add(("SundryCreditorsCoaControlCompTypeDescription:*" + sundryCreditorsCoaControlCompTypeDescription));
            if (!(String.IsNullOrEmpty(sundryCreditorsCoaMainAccName)))
            	filter.Add(("SundryCreditorsCoaMainAccName:*" + sundryCreditorsCoaMainAccName));
            if (!(String.IsNullOrEmpty(sundryCreditorsCoaMainAccBalTypeAccBalType)))
            	filter.Add(("SundryCreditorsCoaMainAccBalTypeAccBalType:*" + sundryCreditorsCoaMainAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(sundryCreditorsCoaMainAccDestAccDest)))
            	filter.Add(("SundryCreditorsCoaMainAccDestAccDest:*" + sundryCreditorsCoaMainAccDestAccDest));
            if (!(String.IsNullOrEmpty(sundryCreditorsCoaMainAccFundAccFundCode)))
            	filter.Add(("SundryCreditorsCoaMainAccFundAccFundCode:*" + sundryCreditorsCoaMainAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(sundryCreditorsCoaMainAccTypeAccType)))
            	filter.Add(("SundryCreditorsCoaMainAccTypeAccType:*" + sundryCreditorsCoaMainAccTypeAccType));
            if (!(String.IsNullOrEmpty(sundryCreditorsCoaMainCoaControlAccName)))
            	filter.Add(("SundryCreditorsCoaMainCoaControlAccName:*" + sundryCreditorsCoaMainCoaControlAccName));
            if (!(String.IsNullOrEmpty(sundryCreditorsCoaSubAccName)))
            	filter.Add(("SundryCreditorsCoaSubAccName:*" + sundryCreditorsCoaSubAccName));
            if (!(String.IsNullOrEmpty(sundryCreditorsCoaSubAccBalTypeAccBalType)))
            	filter.Add(("SundryCreditorsCoaSubAccBalTypeAccBalType:*" + sundryCreditorsCoaSubAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(sundryCreditorsCoaSubAccDestAccDest)))
            	filter.Add(("SundryCreditorsCoaSubAccDestAccDest:*" + sundryCreditorsCoaSubAccDestAccDest));
            if (!(String.IsNullOrEmpty(sundryCreditorsCoaSubAccFundAccFundCode)))
            	filter.Add(("SundryCreditorsCoaSubAccFundAccFundCode:*" + sundryCreditorsCoaSubAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(sundryCreditorsCoaSubAccTypeAccType)))
            	filter.Add(("SundryCreditorsCoaSubAccTypeAccType:*" + sundryCreditorsCoaSubAccTypeAccType));
            if (!(String.IsNullOrEmpty(sundryCreditorsCoaSubCoaControlAccName)))
            	filter.Add(("SundryCreditorsCoaSubCoaControlAccName:*" + sundryCreditorsCoaSubCoaControlAccName));
            if (!(String.IsNullOrEmpty(sundryCreditorsCoaSubCoaMainAccName)))
            	filter.Add(("SundryCreditorsCoaSubCoaMainAccName:*" + sundryCreditorsCoaSubCoaMainAccName));
            if (rawMatAcc.HasValue)
            	filter.Add(("RawMatAcc:=" + rawMatAcc.Value.ToString()));
            if (!(String.IsNullOrEmpty(rawMatAccAccName)))
            	filter.Add(("RawMatAccAccName:*" + rawMatAccAccName));
            if (!(String.IsNullOrEmpty(rawMatAccAccBalTypeAccBalType)))
            	filter.Add(("RawMatAccAccBalTypeAccBalType:*" + rawMatAccAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(rawMatAccAccCurrencyAccCurrencyName)))
            	filter.Add(("RawMatAccAccCurrencyAccCurrencyName:*" + rawMatAccAccCurrencyAccCurrencyName));
            if (!(String.IsNullOrEmpty(rawMatAccAccDestAccDest)))
            	filter.Add(("RawMatAccAccDestAccDest:*" + rawMatAccAccDestAccDest));
            if (!(String.IsNullOrEmpty(rawMatAccAccDestCompanyTypeDescription)))
            	filter.Add(("RawMatAccAccDestCompanyTypeDescription:*" + rawMatAccAccDestCompanyTypeDescription));
            if (!(String.IsNullOrEmpty(rawMatAccAccFundAccFundCode)))
            	filter.Add(("RawMatAccAccFundAccFundCode:*" + rawMatAccAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(rawMatAccAccSubTypeAccSubType)))
            	filter.Add(("RawMatAccAccSubTypeAccSubType:*" + rawMatAccAccSubTypeAccSubType));
            if (!(String.IsNullOrEmpty(rawMatAccAccTypeAccType)))
            	filter.Add(("RawMatAccAccTypeAccType:*" + rawMatAccAccTypeAccType));
            if (!(String.IsNullOrEmpty(rawMatAccCoaControlAccName)))
            	filter.Add(("RawMatAccCoaControlAccName:*" + rawMatAccCoaControlAccName));
            if (!(String.IsNullOrEmpty(rawMatAccCoaControlAccBalTypeAccBalType)))
            	filter.Add(("RawMatAccCoaControlAccBalTypeAccBalType:*" + rawMatAccCoaControlAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(rawMatAccCoaControlAccDestAccDest)))
            	filter.Add(("RawMatAccCoaControlAccDestAccDest:*" + rawMatAccCoaControlAccDestAccDest));
            if (!(String.IsNullOrEmpty(rawMatAccCoaControlAccTypeAccType)))
            	filter.Add(("RawMatAccCoaControlAccTypeAccType:*" + rawMatAccCoaControlAccTypeAccType));
            if (!(String.IsNullOrEmpty(rawMatAccCoaControlCompTypeDescription)))
            	filter.Add(("RawMatAccCoaControlCompTypeDescription:*" + rawMatAccCoaControlCompTypeDescription));
            if (!(String.IsNullOrEmpty(rawMatAccCoaMainAccName)))
            	filter.Add(("RawMatAccCoaMainAccName:*" + rawMatAccCoaMainAccName));
            if (!(String.IsNullOrEmpty(rawMatAccCoaMainAccBalTypeAccBalType)))
            	filter.Add(("RawMatAccCoaMainAccBalTypeAccBalType:*" + rawMatAccCoaMainAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(rawMatAccCoaMainAccDestAccDest)))
            	filter.Add(("RawMatAccCoaMainAccDestAccDest:*" + rawMatAccCoaMainAccDestAccDest));
            if (!(String.IsNullOrEmpty(rawMatAccCoaMainAccFundAccFundCode)))
            	filter.Add(("RawMatAccCoaMainAccFundAccFundCode:*" + rawMatAccCoaMainAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(rawMatAccCoaMainAccTypeAccType)))
            	filter.Add(("RawMatAccCoaMainAccTypeAccType:*" + rawMatAccCoaMainAccTypeAccType));
            if (!(String.IsNullOrEmpty(rawMatAccCoaMainCoaControlAccName)))
            	filter.Add(("RawMatAccCoaMainCoaControlAccName:*" + rawMatAccCoaMainCoaControlAccName));
            if (!(String.IsNullOrEmpty(rawMatAccCoaSubAccName)))
            	filter.Add(("RawMatAccCoaSubAccName:*" + rawMatAccCoaSubAccName));
            if (!(String.IsNullOrEmpty(rawMatAccCoaSubAccBalTypeAccBalType)))
            	filter.Add(("RawMatAccCoaSubAccBalTypeAccBalType:*" + rawMatAccCoaSubAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(rawMatAccCoaSubAccDestAccDest)))
            	filter.Add(("RawMatAccCoaSubAccDestAccDest:*" + rawMatAccCoaSubAccDestAccDest));
            if (!(String.IsNullOrEmpty(rawMatAccCoaSubAccFundAccFundCode)))
            	filter.Add(("RawMatAccCoaSubAccFundAccFundCode:*" + rawMatAccCoaSubAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(rawMatAccCoaSubAccTypeAccType)))
            	filter.Add(("RawMatAccCoaSubAccTypeAccType:*" + rawMatAccCoaSubAccTypeAccType));
            if (!(String.IsNullOrEmpty(rawMatAccCoaSubCoaControlAccName)))
            	filter.Add(("RawMatAccCoaSubCoaControlAccName:*" + rawMatAccCoaSubCoaControlAccName));
            if (!(String.IsNullOrEmpty(rawMatAccCoaSubCoaMainAccName)))
            	filter.Add(("RawMatAccCoaSubCoaMainAccName:*" + rawMatAccCoaSubCoaMainAccName));
            if (packMatAcc.HasValue)
            	filter.Add(("PackMatAcc:=" + packMatAcc.Value.ToString()));
            if (!(String.IsNullOrEmpty(packMatAccAccName)))
            	filter.Add(("PackMatAccAccName:*" + packMatAccAccName));
            if (!(String.IsNullOrEmpty(packMatAccAccBalTypeAccBalType)))
            	filter.Add(("PackMatAccAccBalTypeAccBalType:*" + packMatAccAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(packMatAccAccCurrencyAccCurrencyName)))
            	filter.Add(("PackMatAccAccCurrencyAccCurrencyName:*" + packMatAccAccCurrencyAccCurrencyName));
            if (!(String.IsNullOrEmpty(packMatAccAccDestAccDest)))
            	filter.Add(("PackMatAccAccDestAccDest:*" + packMatAccAccDestAccDest));
            if (!(String.IsNullOrEmpty(packMatAccAccDestCompanyTypeDescription)))
            	filter.Add(("PackMatAccAccDestCompanyTypeDescription:*" + packMatAccAccDestCompanyTypeDescription));
            if (!(String.IsNullOrEmpty(packMatAccAccFundAccFundCode)))
            	filter.Add(("PackMatAccAccFundAccFundCode:*" + packMatAccAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(packMatAccAccSubTypeAccSubType)))
            	filter.Add(("PackMatAccAccSubTypeAccSubType:*" + packMatAccAccSubTypeAccSubType));
            if (!(String.IsNullOrEmpty(packMatAccAccTypeAccType)))
            	filter.Add(("PackMatAccAccTypeAccType:*" + packMatAccAccTypeAccType));
            if (!(String.IsNullOrEmpty(packMatAccCoaControlAccName)))
            	filter.Add(("PackMatAccCoaControlAccName:*" + packMatAccCoaControlAccName));
            if (!(String.IsNullOrEmpty(packMatAccCoaControlAccBalTypeAccBalType)))
            	filter.Add(("PackMatAccCoaControlAccBalTypeAccBalType:*" + packMatAccCoaControlAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(packMatAccCoaControlAccDestAccDest)))
            	filter.Add(("PackMatAccCoaControlAccDestAccDest:*" + packMatAccCoaControlAccDestAccDest));
            if (!(String.IsNullOrEmpty(packMatAccCoaControlAccTypeAccType)))
            	filter.Add(("PackMatAccCoaControlAccTypeAccType:*" + packMatAccCoaControlAccTypeAccType));
            if (!(String.IsNullOrEmpty(packMatAccCoaControlCompTypeDescription)))
            	filter.Add(("PackMatAccCoaControlCompTypeDescription:*" + packMatAccCoaControlCompTypeDescription));
            if (!(String.IsNullOrEmpty(packMatAccCoaMainAccName)))
            	filter.Add(("PackMatAccCoaMainAccName:*" + packMatAccCoaMainAccName));
            if (!(String.IsNullOrEmpty(packMatAccCoaMainAccBalTypeAccBalType)))
            	filter.Add(("PackMatAccCoaMainAccBalTypeAccBalType:*" + packMatAccCoaMainAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(packMatAccCoaMainAccDestAccDest)))
            	filter.Add(("PackMatAccCoaMainAccDestAccDest:*" + packMatAccCoaMainAccDestAccDest));
            if (!(String.IsNullOrEmpty(packMatAccCoaMainAccFundAccFundCode)))
            	filter.Add(("PackMatAccCoaMainAccFundAccFundCode:*" + packMatAccCoaMainAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(packMatAccCoaMainAccTypeAccType)))
            	filter.Add(("PackMatAccCoaMainAccTypeAccType:*" + packMatAccCoaMainAccTypeAccType));
            if (!(String.IsNullOrEmpty(packMatAccCoaMainCoaControlAccName)))
            	filter.Add(("PackMatAccCoaMainCoaControlAccName:*" + packMatAccCoaMainCoaControlAccName));
            if (!(String.IsNullOrEmpty(packMatAccCoaSubAccName)))
            	filter.Add(("PackMatAccCoaSubAccName:*" + packMatAccCoaSubAccName));
            if (!(String.IsNullOrEmpty(packMatAccCoaSubAccBalTypeAccBalType)))
            	filter.Add(("PackMatAccCoaSubAccBalTypeAccBalType:*" + packMatAccCoaSubAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(packMatAccCoaSubAccDestAccDest)))
            	filter.Add(("PackMatAccCoaSubAccDestAccDest:*" + packMatAccCoaSubAccDestAccDest));
            if (!(String.IsNullOrEmpty(packMatAccCoaSubAccFundAccFundCode)))
            	filter.Add(("PackMatAccCoaSubAccFundAccFundCode:*" + packMatAccCoaSubAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(packMatAccCoaSubAccTypeAccType)))
            	filter.Add(("PackMatAccCoaSubAccTypeAccType:*" + packMatAccCoaSubAccTypeAccType));
            if (!(String.IsNullOrEmpty(packMatAccCoaSubCoaControlAccName)))
            	filter.Add(("PackMatAccCoaSubCoaControlAccName:*" + packMatAccCoaSubCoaControlAccName));
            if (!(String.IsNullOrEmpty(packMatAccCoaSubCoaMainAccName)))
            	filter.Add(("PackMatAccCoaSubCoaMainAccName:*" + packMatAccCoaSubCoaMainAccName));
            if (otherMatAcc.HasValue)
            	filter.Add(("OtherMatAcc:=" + otherMatAcc.Value.ToString()));
            if (!(String.IsNullOrEmpty(otherMatAccAccName)))
            	filter.Add(("OtherMatAccAccName:*" + otherMatAccAccName));
            if (!(String.IsNullOrEmpty(otherMatAccAccBalTypeAccBalType)))
            	filter.Add(("OtherMatAccAccBalTypeAccBalType:*" + otherMatAccAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(otherMatAccAccCurrencyAccCurrencyName)))
            	filter.Add(("OtherMatAccAccCurrencyAccCurrencyName:*" + otherMatAccAccCurrencyAccCurrencyName));
            if (!(String.IsNullOrEmpty(otherMatAccAccDestAccDest)))
            	filter.Add(("OtherMatAccAccDestAccDest:*" + otherMatAccAccDestAccDest));
            if (!(String.IsNullOrEmpty(otherMatAccAccDestCompanyTypeDescription)))
            	filter.Add(("OtherMatAccAccDestCompanyTypeDescription:*" + otherMatAccAccDestCompanyTypeDescription));
            if (!(String.IsNullOrEmpty(otherMatAccAccFundAccFundCode)))
            	filter.Add(("OtherMatAccAccFundAccFundCode:*" + otherMatAccAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(otherMatAccAccSubTypeAccSubType)))
            	filter.Add(("OtherMatAccAccSubTypeAccSubType:*" + otherMatAccAccSubTypeAccSubType));
            if (!(String.IsNullOrEmpty(otherMatAccAccTypeAccType)))
            	filter.Add(("OtherMatAccAccTypeAccType:*" + otherMatAccAccTypeAccType));
            if (!(String.IsNullOrEmpty(otherMatAccCoaControlAccName)))
            	filter.Add(("OtherMatAccCoaControlAccName:*" + otherMatAccCoaControlAccName));
            if (!(String.IsNullOrEmpty(otherMatAccCoaControlAccBalTypeAccBalType)))
            	filter.Add(("OtherMatAccCoaControlAccBalTypeAccBalType:*" + otherMatAccCoaControlAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(otherMatAccCoaControlAccDestAccDest)))
            	filter.Add(("OtherMatAccCoaControlAccDestAccDest:*" + otherMatAccCoaControlAccDestAccDest));
            if (!(String.IsNullOrEmpty(otherMatAccCoaControlAccTypeAccType)))
            	filter.Add(("OtherMatAccCoaControlAccTypeAccType:*" + otherMatAccCoaControlAccTypeAccType));
            if (!(String.IsNullOrEmpty(otherMatAccCoaControlCompTypeDescription)))
            	filter.Add(("OtherMatAccCoaControlCompTypeDescription:*" + otherMatAccCoaControlCompTypeDescription));
            if (!(String.IsNullOrEmpty(otherMatAccCoaMainAccName)))
            	filter.Add(("OtherMatAccCoaMainAccName:*" + otherMatAccCoaMainAccName));
            if (!(String.IsNullOrEmpty(otherMatAccCoaMainAccBalTypeAccBalType)))
            	filter.Add(("OtherMatAccCoaMainAccBalTypeAccBalType:*" + otherMatAccCoaMainAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(otherMatAccCoaMainAccDestAccDest)))
            	filter.Add(("OtherMatAccCoaMainAccDestAccDest:*" + otherMatAccCoaMainAccDestAccDest));
            if (!(String.IsNullOrEmpty(otherMatAccCoaMainAccFundAccFundCode)))
            	filter.Add(("OtherMatAccCoaMainAccFundAccFundCode:*" + otherMatAccCoaMainAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(otherMatAccCoaMainAccTypeAccType)))
            	filter.Add(("OtherMatAccCoaMainAccTypeAccType:*" + otherMatAccCoaMainAccTypeAccType));
            if (!(String.IsNullOrEmpty(otherMatAccCoaMainCoaControlAccName)))
            	filter.Add(("OtherMatAccCoaMainCoaControlAccName:*" + otherMatAccCoaMainCoaControlAccName));
            if (!(String.IsNullOrEmpty(otherMatAccCoaSubAccName)))
            	filter.Add(("OtherMatAccCoaSubAccName:*" + otherMatAccCoaSubAccName));
            if (!(String.IsNullOrEmpty(otherMatAccCoaSubAccBalTypeAccBalType)))
            	filter.Add(("OtherMatAccCoaSubAccBalTypeAccBalType:*" + otherMatAccCoaSubAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(otherMatAccCoaSubAccDestAccDest)))
            	filter.Add(("OtherMatAccCoaSubAccDestAccDest:*" + otherMatAccCoaSubAccDestAccDest));
            if (!(String.IsNullOrEmpty(otherMatAccCoaSubAccFundAccFundCode)))
            	filter.Add(("OtherMatAccCoaSubAccFundAccFundCode:*" + otherMatAccCoaSubAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(otherMatAccCoaSubAccTypeAccType)))
            	filter.Add(("OtherMatAccCoaSubAccTypeAccType:*" + otherMatAccCoaSubAccTypeAccType));
            if (!(String.IsNullOrEmpty(otherMatAccCoaSubCoaControlAccName)))
            	filter.Add(("OtherMatAccCoaSubCoaControlAccName:*" + otherMatAccCoaSubCoaControlAccName));
            if (!(String.IsNullOrEmpty(otherMatAccCoaSubCoaMainAccName)))
            	filter.Add(("OtherMatAccCoaSubCoaMainAccName:*" + otherMatAccCoaSubCoaMainAccName));
            if (finishMatAcc.HasValue)
            	filter.Add(("FinishMatAcc:=" + finishMatAcc.Value.ToString()));
            if (!(String.IsNullOrEmpty(finishMatAccAccName)))
            	filter.Add(("FinishMatAccAccName:*" + finishMatAccAccName));
            if (!(String.IsNullOrEmpty(finishMatAccAccBalTypeAccBalType)))
            	filter.Add(("FinishMatAccAccBalTypeAccBalType:*" + finishMatAccAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(finishMatAccAccCurrencyAccCurrencyName)))
            	filter.Add(("FinishMatAccAccCurrencyAccCurrencyName:*" + finishMatAccAccCurrencyAccCurrencyName));
            if (!(String.IsNullOrEmpty(finishMatAccAccDestAccDest)))
            	filter.Add(("FinishMatAccAccDestAccDest:*" + finishMatAccAccDestAccDest));
            if (!(String.IsNullOrEmpty(finishMatAccAccDestCompanyTypeDescription)))
            	filter.Add(("FinishMatAccAccDestCompanyTypeDescription:*" + finishMatAccAccDestCompanyTypeDescription));
            if (!(String.IsNullOrEmpty(finishMatAccAccFundAccFundCode)))
            	filter.Add(("FinishMatAccAccFundAccFundCode:*" + finishMatAccAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(finishMatAccAccSubTypeAccSubType)))
            	filter.Add(("FinishMatAccAccSubTypeAccSubType:*" + finishMatAccAccSubTypeAccSubType));
            if (!(String.IsNullOrEmpty(finishMatAccAccTypeAccType)))
            	filter.Add(("FinishMatAccAccTypeAccType:*" + finishMatAccAccTypeAccType));
            if (!(String.IsNullOrEmpty(finishMatAccCoaControlAccName)))
            	filter.Add(("FinishMatAccCoaControlAccName:*" + finishMatAccCoaControlAccName));
            if (!(String.IsNullOrEmpty(finishMatAccCoaControlAccBalTypeAccBalType)))
            	filter.Add(("FinishMatAccCoaControlAccBalTypeAccBalType:*" + finishMatAccCoaControlAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(finishMatAccCoaControlAccDestAccDest)))
            	filter.Add(("FinishMatAccCoaControlAccDestAccDest:*" + finishMatAccCoaControlAccDestAccDest));
            if (!(String.IsNullOrEmpty(finishMatAccCoaControlAccTypeAccType)))
            	filter.Add(("FinishMatAccCoaControlAccTypeAccType:*" + finishMatAccCoaControlAccTypeAccType));
            if (!(String.IsNullOrEmpty(finishMatAccCoaControlCompTypeDescription)))
            	filter.Add(("FinishMatAccCoaControlCompTypeDescription:*" + finishMatAccCoaControlCompTypeDescription));
            if (!(String.IsNullOrEmpty(finishMatAccCoaMainAccName)))
            	filter.Add(("FinishMatAccCoaMainAccName:*" + finishMatAccCoaMainAccName));
            if (!(String.IsNullOrEmpty(finishMatAccCoaMainAccBalTypeAccBalType)))
            	filter.Add(("FinishMatAccCoaMainAccBalTypeAccBalType:*" + finishMatAccCoaMainAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(finishMatAccCoaMainAccDestAccDest)))
            	filter.Add(("FinishMatAccCoaMainAccDestAccDest:*" + finishMatAccCoaMainAccDestAccDest));
            if (!(String.IsNullOrEmpty(finishMatAccCoaMainAccFundAccFundCode)))
            	filter.Add(("FinishMatAccCoaMainAccFundAccFundCode:*" + finishMatAccCoaMainAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(finishMatAccCoaMainAccTypeAccType)))
            	filter.Add(("FinishMatAccCoaMainAccTypeAccType:*" + finishMatAccCoaMainAccTypeAccType));
            if (!(String.IsNullOrEmpty(finishMatAccCoaMainCoaControlAccName)))
            	filter.Add(("FinishMatAccCoaMainCoaControlAccName:*" + finishMatAccCoaMainCoaControlAccName));
            if (!(String.IsNullOrEmpty(finishMatAccCoaSubAccName)))
            	filter.Add(("FinishMatAccCoaSubAccName:*" + finishMatAccCoaSubAccName));
            if (!(String.IsNullOrEmpty(finishMatAccCoaSubAccBalTypeAccBalType)))
            	filter.Add(("FinishMatAccCoaSubAccBalTypeAccBalType:*" + finishMatAccCoaSubAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(finishMatAccCoaSubAccDestAccDest)))
            	filter.Add(("FinishMatAccCoaSubAccDestAccDest:*" + finishMatAccCoaSubAccDestAccDest));
            if (!(String.IsNullOrEmpty(finishMatAccCoaSubAccFundAccFundCode)))
            	filter.Add(("FinishMatAccCoaSubAccFundAccFundCode:*" + finishMatAccCoaSubAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(finishMatAccCoaSubAccTypeAccType)))
            	filter.Add(("FinishMatAccCoaSubAccTypeAccType:*" + finishMatAccCoaSubAccTypeAccType));
            if (!(String.IsNullOrEmpty(finishMatAccCoaSubCoaControlAccName)))
            	filter.Add(("FinishMatAccCoaSubCoaControlAccName:*" + finishMatAccCoaSubCoaControlAccName));
            if (!(String.IsNullOrEmpty(finishMatAccCoaSubCoaMainAccName)))
            	filter.Add(("FinishMatAccCoaSubCoaMainAccName:*" + finishMatAccCoaSubCoaMainAccName));
            if (adminExpAcc.HasValue)
            	filter.Add(("AdminExpAcc:=" + adminExpAcc.Value.ToString()));
            if (!(String.IsNullOrEmpty(adminExpAccAccName)))
            	filter.Add(("AdminExpAccAccName:*" + adminExpAccAccName));
            if (!(String.IsNullOrEmpty(adminExpAccAccBalTypeAccBalType)))
            	filter.Add(("AdminExpAccAccBalTypeAccBalType:*" + adminExpAccAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(adminExpAccAccCurrencyAccCurrencyName)))
            	filter.Add(("AdminExpAccAccCurrencyAccCurrencyName:*" + adminExpAccAccCurrencyAccCurrencyName));
            if (!(String.IsNullOrEmpty(adminExpAccAccDestAccDest)))
            	filter.Add(("AdminExpAccAccDestAccDest:*" + adminExpAccAccDestAccDest));
            if (!(String.IsNullOrEmpty(adminExpAccAccDestCompanyTypeDescription)))
            	filter.Add(("AdminExpAccAccDestCompanyTypeDescription:*" + adminExpAccAccDestCompanyTypeDescription));
            if (!(String.IsNullOrEmpty(adminExpAccAccFundAccFundCode)))
            	filter.Add(("AdminExpAccAccFundAccFundCode:*" + adminExpAccAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(adminExpAccAccSubTypeAccSubType)))
            	filter.Add(("AdminExpAccAccSubTypeAccSubType:*" + adminExpAccAccSubTypeAccSubType));
            if (!(String.IsNullOrEmpty(adminExpAccAccTypeAccType)))
            	filter.Add(("AdminExpAccAccTypeAccType:*" + adminExpAccAccTypeAccType));
            if (!(String.IsNullOrEmpty(adminExpAccCoaControlAccName)))
            	filter.Add(("AdminExpAccCoaControlAccName:*" + adminExpAccCoaControlAccName));
            if (!(String.IsNullOrEmpty(adminExpAccCoaControlAccBalTypeAccBalType)))
            	filter.Add(("AdminExpAccCoaControlAccBalTypeAccBalType:*" + adminExpAccCoaControlAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(adminExpAccCoaControlAccDestAccDest)))
            	filter.Add(("AdminExpAccCoaControlAccDestAccDest:*" + adminExpAccCoaControlAccDestAccDest));
            if (!(String.IsNullOrEmpty(adminExpAccCoaControlAccTypeAccType)))
            	filter.Add(("AdminExpAccCoaControlAccTypeAccType:*" + adminExpAccCoaControlAccTypeAccType));
            if (!(String.IsNullOrEmpty(adminExpAccCoaControlCompTypeDescription)))
            	filter.Add(("AdminExpAccCoaControlCompTypeDescription:*" + adminExpAccCoaControlCompTypeDescription));
            if (!(String.IsNullOrEmpty(adminExpAccCoaMainAccName)))
            	filter.Add(("AdminExpAccCoaMainAccName:*" + adminExpAccCoaMainAccName));
            if (!(String.IsNullOrEmpty(adminExpAccCoaMainAccBalTypeAccBalType)))
            	filter.Add(("AdminExpAccCoaMainAccBalTypeAccBalType:*" + adminExpAccCoaMainAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(adminExpAccCoaMainAccDestAccDest)))
            	filter.Add(("AdminExpAccCoaMainAccDestAccDest:*" + adminExpAccCoaMainAccDestAccDest));
            if (!(String.IsNullOrEmpty(adminExpAccCoaMainAccFundAccFundCode)))
            	filter.Add(("AdminExpAccCoaMainAccFundAccFundCode:*" + adminExpAccCoaMainAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(adminExpAccCoaMainAccTypeAccType)))
            	filter.Add(("AdminExpAccCoaMainAccTypeAccType:*" + adminExpAccCoaMainAccTypeAccType));
            if (!(String.IsNullOrEmpty(adminExpAccCoaMainCoaControlAccName)))
            	filter.Add(("AdminExpAccCoaMainCoaControlAccName:*" + adminExpAccCoaMainCoaControlAccName));
            if (!(String.IsNullOrEmpty(adminExpAccCoaSubAccName)))
            	filter.Add(("AdminExpAccCoaSubAccName:*" + adminExpAccCoaSubAccName));
            if (!(String.IsNullOrEmpty(adminExpAccCoaSubAccBalTypeAccBalType)))
            	filter.Add(("AdminExpAccCoaSubAccBalTypeAccBalType:*" + adminExpAccCoaSubAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(adminExpAccCoaSubAccDestAccDest)))
            	filter.Add(("AdminExpAccCoaSubAccDestAccDest:*" + adminExpAccCoaSubAccDestAccDest));
            if (!(String.IsNullOrEmpty(adminExpAccCoaSubAccFundAccFundCode)))
            	filter.Add(("AdminExpAccCoaSubAccFundAccFundCode:*" + adminExpAccCoaSubAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(adminExpAccCoaSubAccTypeAccType)))
            	filter.Add(("AdminExpAccCoaSubAccTypeAccType:*" + adminExpAccCoaSubAccTypeAccType));
            if (!(String.IsNullOrEmpty(adminExpAccCoaSubCoaControlAccName)))
            	filter.Add(("AdminExpAccCoaSubCoaControlAccName:*" + adminExpAccCoaSubCoaControlAccName));
            if (!(String.IsNullOrEmpty(adminExpAccCoaSubCoaMainAccName)))
            	filter.Add(("AdminExpAccCoaSubCoaMainAccName:*" + adminExpAccCoaSubCoaMainAccName));
            if (sellingExpAcc.HasValue)
            	filter.Add(("SellingExpAcc:=" + sellingExpAcc.Value.ToString()));
            if (!(String.IsNullOrEmpty(sellingExpAccAccName)))
            	filter.Add(("SellingExpAccAccName:*" + sellingExpAccAccName));
            if (!(String.IsNullOrEmpty(sellingExpAccAccBalTypeAccBalType)))
            	filter.Add(("SellingExpAccAccBalTypeAccBalType:*" + sellingExpAccAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(sellingExpAccAccCurrencyAccCurrencyName)))
            	filter.Add(("SellingExpAccAccCurrencyAccCurrencyName:*" + sellingExpAccAccCurrencyAccCurrencyName));
            if (!(String.IsNullOrEmpty(sellingExpAccAccDestAccDest)))
            	filter.Add(("SellingExpAccAccDestAccDest:*" + sellingExpAccAccDestAccDest));
            if (!(String.IsNullOrEmpty(sellingExpAccAccDestCompanyTypeDescription)))
            	filter.Add(("SellingExpAccAccDestCompanyTypeDescription:*" + sellingExpAccAccDestCompanyTypeDescription));
            if (!(String.IsNullOrEmpty(sellingExpAccAccFundAccFundCode)))
            	filter.Add(("SellingExpAccAccFundAccFundCode:*" + sellingExpAccAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(sellingExpAccAccSubTypeAccSubType)))
            	filter.Add(("SellingExpAccAccSubTypeAccSubType:*" + sellingExpAccAccSubTypeAccSubType));
            if (!(String.IsNullOrEmpty(sellingExpAccAccTypeAccType)))
            	filter.Add(("SellingExpAccAccTypeAccType:*" + sellingExpAccAccTypeAccType));
            if (!(String.IsNullOrEmpty(sellingExpAccCoaControlAccName)))
            	filter.Add(("SellingExpAccCoaControlAccName:*" + sellingExpAccCoaControlAccName));
            if (!(String.IsNullOrEmpty(sellingExpAccCoaControlAccBalTypeAccBalType)))
            	filter.Add(("SellingExpAccCoaControlAccBalTypeAccBalType:*" + sellingExpAccCoaControlAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(sellingExpAccCoaControlAccDestAccDest)))
            	filter.Add(("SellingExpAccCoaControlAccDestAccDest:*" + sellingExpAccCoaControlAccDestAccDest));
            if (!(String.IsNullOrEmpty(sellingExpAccCoaControlAccTypeAccType)))
            	filter.Add(("SellingExpAccCoaControlAccTypeAccType:*" + sellingExpAccCoaControlAccTypeAccType));
            if (!(String.IsNullOrEmpty(sellingExpAccCoaControlCompTypeDescription)))
            	filter.Add(("SellingExpAccCoaControlCompTypeDescription:*" + sellingExpAccCoaControlCompTypeDescription));
            if (!(String.IsNullOrEmpty(sellingExpAccCoaMainAccName)))
            	filter.Add(("SellingExpAccCoaMainAccName:*" + sellingExpAccCoaMainAccName));
            if (!(String.IsNullOrEmpty(sellingExpAccCoaMainAccBalTypeAccBalType)))
            	filter.Add(("SellingExpAccCoaMainAccBalTypeAccBalType:*" + sellingExpAccCoaMainAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(sellingExpAccCoaMainAccDestAccDest)))
            	filter.Add(("SellingExpAccCoaMainAccDestAccDest:*" + sellingExpAccCoaMainAccDestAccDest));
            if (!(String.IsNullOrEmpty(sellingExpAccCoaMainAccFundAccFundCode)))
            	filter.Add(("SellingExpAccCoaMainAccFundAccFundCode:*" + sellingExpAccCoaMainAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(sellingExpAccCoaMainAccTypeAccType)))
            	filter.Add(("SellingExpAccCoaMainAccTypeAccType:*" + sellingExpAccCoaMainAccTypeAccType));
            if (!(String.IsNullOrEmpty(sellingExpAccCoaMainCoaControlAccName)))
            	filter.Add(("SellingExpAccCoaMainCoaControlAccName:*" + sellingExpAccCoaMainCoaControlAccName));
            if (!(String.IsNullOrEmpty(sellingExpAccCoaSubAccName)))
            	filter.Add(("SellingExpAccCoaSubAccName:*" + sellingExpAccCoaSubAccName));
            if (!(String.IsNullOrEmpty(sellingExpAccCoaSubAccBalTypeAccBalType)))
            	filter.Add(("SellingExpAccCoaSubAccBalTypeAccBalType:*" + sellingExpAccCoaSubAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(sellingExpAccCoaSubAccDestAccDest)))
            	filter.Add(("SellingExpAccCoaSubAccDestAccDest:*" + sellingExpAccCoaSubAccDestAccDest));
            if (!(String.IsNullOrEmpty(sellingExpAccCoaSubAccFundAccFundCode)))
            	filter.Add(("SellingExpAccCoaSubAccFundAccFundCode:*" + sellingExpAccCoaSubAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(sellingExpAccCoaSubAccTypeAccType)))
            	filter.Add(("SellingExpAccCoaSubAccTypeAccType:*" + sellingExpAccCoaSubAccTypeAccType));
            if (!(String.IsNullOrEmpty(sellingExpAccCoaSubCoaControlAccName)))
            	filter.Add(("SellingExpAccCoaSubCoaControlAccName:*" + sellingExpAccCoaSubCoaControlAccName));
            if (!(String.IsNullOrEmpty(sellingExpAccCoaSubCoaMainAccName)))
            	filter.Add(("SellingExpAccCoaSubCoaMainAccName:*" + sellingExpAccCoaSubCoaMainAccName));
            if (manuExpAcc.HasValue)
            	filter.Add(("ManuExpAcc:=" + manuExpAcc.Value.ToString()));
            if (!(String.IsNullOrEmpty(manuExpAccAccName)))
            	filter.Add(("ManuExpAccAccName:*" + manuExpAccAccName));
            if (!(String.IsNullOrEmpty(manuExpAccAccBalTypeAccBalType)))
            	filter.Add(("ManuExpAccAccBalTypeAccBalType:*" + manuExpAccAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(manuExpAccAccCurrencyAccCurrencyName)))
            	filter.Add(("ManuExpAccAccCurrencyAccCurrencyName:*" + manuExpAccAccCurrencyAccCurrencyName));
            if (!(String.IsNullOrEmpty(manuExpAccAccDestAccDest)))
            	filter.Add(("ManuExpAccAccDestAccDest:*" + manuExpAccAccDestAccDest));
            if (!(String.IsNullOrEmpty(manuExpAccAccDestCompanyTypeDescription)))
            	filter.Add(("ManuExpAccAccDestCompanyTypeDescription:*" + manuExpAccAccDestCompanyTypeDescription));
            if (!(String.IsNullOrEmpty(manuExpAccAccFundAccFundCode)))
            	filter.Add(("ManuExpAccAccFundAccFundCode:*" + manuExpAccAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(manuExpAccAccSubTypeAccSubType)))
            	filter.Add(("ManuExpAccAccSubTypeAccSubType:*" + manuExpAccAccSubTypeAccSubType));
            if (!(String.IsNullOrEmpty(manuExpAccAccTypeAccType)))
            	filter.Add(("ManuExpAccAccTypeAccType:*" + manuExpAccAccTypeAccType));
            if (!(String.IsNullOrEmpty(manuExpAccCoaControlAccName)))
            	filter.Add(("ManuExpAccCoaControlAccName:*" + manuExpAccCoaControlAccName));
            if (!(String.IsNullOrEmpty(manuExpAccCoaControlAccBalTypeAccBalType)))
            	filter.Add(("ManuExpAccCoaControlAccBalTypeAccBalType:*" + manuExpAccCoaControlAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(manuExpAccCoaControlAccDestAccDest)))
            	filter.Add(("ManuExpAccCoaControlAccDestAccDest:*" + manuExpAccCoaControlAccDestAccDest));
            if (!(String.IsNullOrEmpty(manuExpAccCoaControlAccTypeAccType)))
            	filter.Add(("ManuExpAccCoaControlAccTypeAccType:*" + manuExpAccCoaControlAccTypeAccType));
            if (!(String.IsNullOrEmpty(manuExpAccCoaControlCompTypeDescription)))
            	filter.Add(("ManuExpAccCoaControlCompTypeDescription:*" + manuExpAccCoaControlCompTypeDescription));
            if (!(String.IsNullOrEmpty(manuExpAccCoaMainAccName)))
            	filter.Add(("ManuExpAccCoaMainAccName:*" + manuExpAccCoaMainAccName));
            if (!(String.IsNullOrEmpty(manuExpAccCoaMainAccBalTypeAccBalType)))
            	filter.Add(("ManuExpAccCoaMainAccBalTypeAccBalType:*" + manuExpAccCoaMainAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(manuExpAccCoaMainAccDestAccDest)))
            	filter.Add(("ManuExpAccCoaMainAccDestAccDest:*" + manuExpAccCoaMainAccDestAccDest));
            if (!(String.IsNullOrEmpty(manuExpAccCoaMainAccFundAccFundCode)))
            	filter.Add(("ManuExpAccCoaMainAccFundAccFundCode:*" + manuExpAccCoaMainAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(manuExpAccCoaMainAccTypeAccType)))
            	filter.Add(("ManuExpAccCoaMainAccTypeAccType:*" + manuExpAccCoaMainAccTypeAccType));
            if (!(String.IsNullOrEmpty(manuExpAccCoaMainCoaControlAccName)))
            	filter.Add(("ManuExpAccCoaMainCoaControlAccName:*" + manuExpAccCoaMainCoaControlAccName));
            if (!(String.IsNullOrEmpty(manuExpAccCoaSubAccName)))
            	filter.Add(("ManuExpAccCoaSubAccName:*" + manuExpAccCoaSubAccName));
            if (!(String.IsNullOrEmpty(manuExpAccCoaSubAccBalTypeAccBalType)))
            	filter.Add(("ManuExpAccCoaSubAccBalTypeAccBalType:*" + manuExpAccCoaSubAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(manuExpAccCoaSubAccDestAccDest)))
            	filter.Add(("ManuExpAccCoaSubAccDestAccDest:*" + manuExpAccCoaSubAccDestAccDest));
            if (!(String.IsNullOrEmpty(manuExpAccCoaSubAccFundAccFundCode)))
            	filter.Add(("ManuExpAccCoaSubAccFundAccFundCode:*" + manuExpAccCoaSubAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(manuExpAccCoaSubAccTypeAccType)))
            	filter.Add(("ManuExpAccCoaSubAccTypeAccType:*" + manuExpAccCoaSubAccTypeAccType));
            if (!(String.IsNullOrEmpty(manuExpAccCoaSubCoaControlAccName)))
            	filter.Add(("ManuExpAccCoaSubCoaControlAccName:*" + manuExpAccCoaSubCoaControlAccName));
            if (!(String.IsNullOrEmpty(manuExpAccCoaSubCoaMainAccName)))
            	filter.Add(("ManuExpAccCoaSubCoaMainAccName:*" + manuExpAccCoaSubCoaMainAccName));
            if (loanAcc.HasValue)
            	filter.Add(("LoanAcc:=" + loanAcc.Value.ToString()));
            if (!(String.IsNullOrEmpty(loanAccAccName)))
            	filter.Add(("LoanAccAccName:*" + loanAccAccName));
            if (!(String.IsNullOrEmpty(loanAccAccBalTypeAccBalType)))
            	filter.Add(("LoanAccAccBalTypeAccBalType:*" + loanAccAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(loanAccAccCurrencyAccCurrencyName)))
            	filter.Add(("LoanAccAccCurrencyAccCurrencyName:*" + loanAccAccCurrencyAccCurrencyName));
            if (!(String.IsNullOrEmpty(loanAccAccDestAccDest)))
            	filter.Add(("LoanAccAccDestAccDest:*" + loanAccAccDestAccDest));
            if (!(String.IsNullOrEmpty(loanAccAccDestCompanyTypeDescription)))
            	filter.Add(("LoanAccAccDestCompanyTypeDescription:*" + loanAccAccDestCompanyTypeDescription));
            if (!(String.IsNullOrEmpty(loanAccAccFundAccFundCode)))
            	filter.Add(("LoanAccAccFundAccFundCode:*" + loanAccAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(loanAccAccSubTypeAccSubType)))
            	filter.Add(("LoanAccAccSubTypeAccSubType:*" + loanAccAccSubTypeAccSubType));
            if (!(String.IsNullOrEmpty(loanAccAccTypeAccType)))
            	filter.Add(("LoanAccAccTypeAccType:*" + loanAccAccTypeAccType));
            if (!(String.IsNullOrEmpty(loanAccCoaControlAccName)))
            	filter.Add(("LoanAccCoaControlAccName:*" + loanAccCoaControlAccName));
            if (!(String.IsNullOrEmpty(loanAccCoaControlAccBalTypeAccBalType)))
            	filter.Add(("LoanAccCoaControlAccBalTypeAccBalType:*" + loanAccCoaControlAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(loanAccCoaControlAccDestAccDest)))
            	filter.Add(("LoanAccCoaControlAccDestAccDest:*" + loanAccCoaControlAccDestAccDest));
            if (!(String.IsNullOrEmpty(loanAccCoaControlAccTypeAccType)))
            	filter.Add(("LoanAccCoaControlAccTypeAccType:*" + loanAccCoaControlAccTypeAccType));
            if (!(String.IsNullOrEmpty(loanAccCoaControlCompTypeDescription)))
            	filter.Add(("LoanAccCoaControlCompTypeDescription:*" + loanAccCoaControlCompTypeDescription));
            if (!(String.IsNullOrEmpty(loanAccCoaMainAccName)))
            	filter.Add(("LoanAccCoaMainAccName:*" + loanAccCoaMainAccName));
            if (!(String.IsNullOrEmpty(loanAccCoaMainAccBalTypeAccBalType)))
            	filter.Add(("LoanAccCoaMainAccBalTypeAccBalType:*" + loanAccCoaMainAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(loanAccCoaMainAccDestAccDest)))
            	filter.Add(("LoanAccCoaMainAccDestAccDest:*" + loanAccCoaMainAccDestAccDest));
            if (!(String.IsNullOrEmpty(loanAccCoaMainAccFundAccFundCode)))
            	filter.Add(("LoanAccCoaMainAccFundAccFundCode:*" + loanAccCoaMainAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(loanAccCoaMainAccTypeAccType)))
            	filter.Add(("LoanAccCoaMainAccTypeAccType:*" + loanAccCoaMainAccTypeAccType));
            if (!(String.IsNullOrEmpty(loanAccCoaMainCoaControlAccName)))
            	filter.Add(("LoanAccCoaMainCoaControlAccName:*" + loanAccCoaMainCoaControlAccName));
            if (!(String.IsNullOrEmpty(loanAccCoaSubAccName)))
            	filter.Add(("LoanAccCoaSubAccName:*" + loanAccCoaSubAccName));
            if (!(String.IsNullOrEmpty(loanAccCoaSubAccBalTypeAccBalType)))
            	filter.Add(("LoanAccCoaSubAccBalTypeAccBalType:*" + loanAccCoaSubAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(loanAccCoaSubAccDestAccDest)))
            	filter.Add(("LoanAccCoaSubAccDestAccDest:*" + loanAccCoaSubAccDestAccDest));
            if (!(String.IsNullOrEmpty(loanAccCoaSubAccFundAccFundCode)))
            	filter.Add(("LoanAccCoaSubAccFundAccFundCode:*" + loanAccCoaSubAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(loanAccCoaSubAccTypeAccType)))
            	filter.Add(("LoanAccCoaSubAccTypeAccType:*" + loanAccCoaSubAccTypeAccType));
            if (!(String.IsNullOrEmpty(loanAccCoaSubCoaControlAccName)))
            	filter.Add(("LoanAccCoaSubCoaControlAccName:*" + loanAccCoaSubCoaControlAccName));
            if (!(String.IsNullOrEmpty(loanAccCoaSubCoaMainAccName)))
            	filter.Add(("LoanAccCoaSubCoaMainAccName:*" + loanAccCoaSubCoaMainAccName));
            if (assetDepAcc.HasValue)
            	filter.Add(("AssetDepAcc:=" + assetDepAcc.Value.ToString()));
            if (!(String.IsNullOrEmpty(assetDepAccAccName)))
            	filter.Add(("AssetDepAccAccName:*" + assetDepAccAccName));
            if (!(String.IsNullOrEmpty(assetDepAccAccBalTypeAccBalType)))
            	filter.Add(("AssetDepAccAccBalTypeAccBalType:*" + assetDepAccAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(assetDepAccAccCurrencyAccCurrencyName)))
            	filter.Add(("AssetDepAccAccCurrencyAccCurrencyName:*" + assetDepAccAccCurrencyAccCurrencyName));
            if (!(String.IsNullOrEmpty(assetDepAccAccDestAccDest)))
            	filter.Add(("AssetDepAccAccDestAccDest:*" + assetDepAccAccDestAccDest));
            if (!(String.IsNullOrEmpty(assetDepAccAccDestCompanyTypeDescription)))
            	filter.Add(("AssetDepAccAccDestCompanyTypeDescription:*" + assetDepAccAccDestCompanyTypeDescription));
            if (!(String.IsNullOrEmpty(assetDepAccAccFundAccFundCode)))
            	filter.Add(("AssetDepAccAccFundAccFundCode:*" + assetDepAccAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(assetDepAccAccSubTypeAccSubType)))
            	filter.Add(("AssetDepAccAccSubTypeAccSubType:*" + assetDepAccAccSubTypeAccSubType));
            if (!(String.IsNullOrEmpty(assetDepAccAccTypeAccType)))
            	filter.Add(("AssetDepAccAccTypeAccType:*" + assetDepAccAccTypeAccType));
            if (!(String.IsNullOrEmpty(assetDepAccCoaControlAccName)))
            	filter.Add(("AssetDepAccCoaControlAccName:*" + assetDepAccCoaControlAccName));
            if (!(String.IsNullOrEmpty(assetDepAccCoaControlAccBalTypeAccBalType)))
            	filter.Add(("AssetDepAccCoaControlAccBalTypeAccBalType:*" + assetDepAccCoaControlAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(assetDepAccCoaControlAccDestAccDest)))
            	filter.Add(("AssetDepAccCoaControlAccDestAccDest:*" + assetDepAccCoaControlAccDestAccDest));
            if (!(String.IsNullOrEmpty(assetDepAccCoaControlAccTypeAccType)))
            	filter.Add(("AssetDepAccCoaControlAccTypeAccType:*" + assetDepAccCoaControlAccTypeAccType));
            if (!(String.IsNullOrEmpty(assetDepAccCoaControlCompTypeDescription)))
            	filter.Add(("AssetDepAccCoaControlCompTypeDescription:*" + assetDepAccCoaControlCompTypeDescription));
            if (!(String.IsNullOrEmpty(assetDepAccCoaMainAccName)))
            	filter.Add(("AssetDepAccCoaMainAccName:*" + assetDepAccCoaMainAccName));
            if (!(String.IsNullOrEmpty(assetDepAccCoaMainAccBalTypeAccBalType)))
            	filter.Add(("AssetDepAccCoaMainAccBalTypeAccBalType:*" + assetDepAccCoaMainAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(assetDepAccCoaMainAccDestAccDest)))
            	filter.Add(("AssetDepAccCoaMainAccDestAccDest:*" + assetDepAccCoaMainAccDestAccDest));
            if (!(String.IsNullOrEmpty(assetDepAccCoaMainAccFundAccFundCode)))
            	filter.Add(("AssetDepAccCoaMainAccFundAccFundCode:*" + assetDepAccCoaMainAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(assetDepAccCoaMainAccTypeAccType)))
            	filter.Add(("AssetDepAccCoaMainAccTypeAccType:*" + assetDepAccCoaMainAccTypeAccType));
            if (!(String.IsNullOrEmpty(assetDepAccCoaMainCoaControlAccName)))
            	filter.Add(("AssetDepAccCoaMainCoaControlAccName:*" + assetDepAccCoaMainCoaControlAccName));
            if (!(String.IsNullOrEmpty(assetDepAccCoaSubAccName)))
            	filter.Add(("AssetDepAccCoaSubAccName:*" + assetDepAccCoaSubAccName));
            if (!(String.IsNullOrEmpty(assetDepAccCoaSubAccBalTypeAccBalType)))
            	filter.Add(("AssetDepAccCoaSubAccBalTypeAccBalType:*" + assetDepAccCoaSubAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(assetDepAccCoaSubAccDestAccDest)))
            	filter.Add(("AssetDepAccCoaSubAccDestAccDest:*" + assetDepAccCoaSubAccDestAccDest));
            if (!(String.IsNullOrEmpty(assetDepAccCoaSubAccFundAccFundCode)))
            	filter.Add(("AssetDepAccCoaSubAccFundAccFundCode:*" + assetDepAccCoaSubAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(assetDepAccCoaSubAccTypeAccType)))
            	filter.Add(("AssetDepAccCoaSubAccTypeAccType:*" + assetDepAccCoaSubAccTypeAccType));
            if (!(String.IsNullOrEmpty(assetDepAccCoaSubCoaControlAccName)))
            	filter.Add(("AssetDepAccCoaSubCoaControlAccName:*" + assetDepAccCoaSubCoaControlAccName));
            if (!(String.IsNullOrEmpty(assetDepAccCoaSubCoaMainAccName)))
            	filter.Add(("AssetDepAccCoaSubCoaMainAccName:*" + assetDepAccCoaSubCoaMainAccName));
            if (nonOperateIncAcc.HasValue)
            	filter.Add(("NonOperateIncAcc:=" + nonOperateIncAcc.Value.ToString()));
            if (!(String.IsNullOrEmpty(nonOperateIncAccAccName)))
            	filter.Add(("NonOperateIncAccAccName:*" + nonOperateIncAccAccName));
            if (!(String.IsNullOrEmpty(nonOperateIncAccAccBalTypeAccBalType)))
            	filter.Add(("NonOperateIncAccAccBalTypeAccBalType:*" + nonOperateIncAccAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(nonOperateIncAccAccCurrencyAccCurrencyName)))
            	filter.Add(("NonOperateIncAccAccCurrencyAccCurrencyName:*" + nonOperateIncAccAccCurrencyAccCurrencyName));
            if (!(String.IsNullOrEmpty(nonOperateIncAccAccDestAccDest)))
            	filter.Add(("NonOperateIncAccAccDestAccDest:*" + nonOperateIncAccAccDestAccDest));
            if (!(String.IsNullOrEmpty(nonOperateIncAccAccDestCompanyTypeDescription)))
            	filter.Add(("NonOperateIncAccAccDestCompanyTypeDescription:*" + nonOperateIncAccAccDestCompanyTypeDescription));
            if (!(String.IsNullOrEmpty(nonOperateIncAccAccFundAccFundCode)))
            	filter.Add(("NonOperateIncAccAccFundAccFundCode:*" + nonOperateIncAccAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(nonOperateIncAccAccSubTypeAccSubType)))
            	filter.Add(("NonOperateIncAccAccSubTypeAccSubType:*" + nonOperateIncAccAccSubTypeAccSubType));
            if (!(String.IsNullOrEmpty(nonOperateIncAccAccTypeAccType)))
            	filter.Add(("NonOperateIncAccAccTypeAccType:*" + nonOperateIncAccAccTypeAccType));
            if (!(String.IsNullOrEmpty(nonOperateIncAccCoaControlAccName)))
            	filter.Add(("NonOperateIncAccCoaControlAccName:*" + nonOperateIncAccCoaControlAccName));
            if (!(String.IsNullOrEmpty(nonOperateIncAccCoaControlAccBalTypeAccBalType)))
            	filter.Add(("NonOperateIncAccCoaControlAccBalTypeAccBalType:*" + nonOperateIncAccCoaControlAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(nonOperateIncAccCoaControlAccDestAccDest)))
            	filter.Add(("NonOperateIncAccCoaControlAccDestAccDest:*" + nonOperateIncAccCoaControlAccDestAccDest));
            if (!(String.IsNullOrEmpty(nonOperateIncAccCoaControlAccTypeAccType)))
            	filter.Add(("NonOperateIncAccCoaControlAccTypeAccType:*" + nonOperateIncAccCoaControlAccTypeAccType));
            if (!(String.IsNullOrEmpty(nonOperateIncAccCoaControlCompTypeDescription)))
            	filter.Add(("NonOperateIncAccCoaControlCompTypeDescription:*" + nonOperateIncAccCoaControlCompTypeDescription));
            if (!(String.IsNullOrEmpty(nonOperateIncAccCoaMainAccName)))
            	filter.Add(("NonOperateIncAccCoaMainAccName:*" + nonOperateIncAccCoaMainAccName));
            if (!(String.IsNullOrEmpty(nonOperateIncAccCoaMainAccBalTypeAccBalType)))
            	filter.Add(("NonOperateIncAccCoaMainAccBalTypeAccBalType:*" + nonOperateIncAccCoaMainAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(nonOperateIncAccCoaMainAccDestAccDest)))
            	filter.Add(("NonOperateIncAccCoaMainAccDestAccDest:*" + nonOperateIncAccCoaMainAccDestAccDest));
            if (!(String.IsNullOrEmpty(nonOperateIncAccCoaMainAccFundAccFundCode)))
            	filter.Add(("NonOperateIncAccCoaMainAccFundAccFundCode:*" + nonOperateIncAccCoaMainAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(nonOperateIncAccCoaMainAccTypeAccType)))
            	filter.Add(("NonOperateIncAccCoaMainAccTypeAccType:*" + nonOperateIncAccCoaMainAccTypeAccType));
            if (!(String.IsNullOrEmpty(nonOperateIncAccCoaMainCoaControlAccName)))
            	filter.Add(("NonOperateIncAccCoaMainCoaControlAccName:*" + nonOperateIncAccCoaMainCoaControlAccName));
            if (!(String.IsNullOrEmpty(nonOperateIncAccCoaSubAccName)))
            	filter.Add(("NonOperateIncAccCoaSubAccName:*" + nonOperateIncAccCoaSubAccName));
            if (!(String.IsNullOrEmpty(nonOperateIncAccCoaSubAccBalTypeAccBalType)))
            	filter.Add(("NonOperateIncAccCoaSubAccBalTypeAccBalType:*" + nonOperateIncAccCoaSubAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(nonOperateIncAccCoaSubAccDestAccDest)))
            	filter.Add(("NonOperateIncAccCoaSubAccDestAccDest:*" + nonOperateIncAccCoaSubAccDestAccDest));
            if (!(String.IsNullOrEmpty(nonOperateIncAccCoaSubAccFundAccFundCode)))
            	filter.Add(("NonOperateIncAccCoaSubAccFundAccFundCode:*" + nonOperateIncAccCoaSubAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(nonOperateIncAccCoaSubAccTypeAccType)))
            	filter.Add(("NonOperateIncAccCoaSubAccTypeAccType:*" + nonOperateIncAccCoaSubAccTypeAccType));
            if (!(String.IsNullOrEmpty(nonOperateIncAccCoaSubCoaControlAccName)))
            	filter.Add(("NonOperateIncAccCoaSubCoaControlAccName:*" + nonOperateIncAccCoaSubCoaControlAccName));
            if (!(String.IsNullOrEmpty(nonOperateIncAccCoaSubCoaMainAccName)))
            	filter.Add(("NonOperateIncAccCoaSubCoaMainAccName:*" + nonOperateIncAccCoaSubCoaMainAccName));
            if (nonOperateExpAcc.HasValue)
            	filter.Add(("NonOperateExpAcc:=" + nonOperateExpAcc.Value.ToString()));
            if (!(String.IsNullOrEmpty(nonOperateExpAccAccName)))
            	filter.Add(("NonOperateExpAccAccName:*" + nonOperateExpAccAccName));
            if (!(String.IsNullOrEmpty(nonOperateExpAccAccBalTypeAccBalType)))
            	filter.Add(("NonOperateExpAccAccBalTypeAccBalType:*" + nonOperateExpAccAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(nonOperateExpAccAccCurrencyAccCurrencyName)))
            	filter.Add(("NonOperateExpAccAccCurrencyAccCurrencyName:*" + nonOperateExpAccAccCurrencyAccCurrencyName));
            if (!(String.IsNullOrEmpty(nonOperateExpAccAccDestAccDest)))
            	filter.Add(("NonOperateExpAccAccDestAccDest:*" + nonOperateExpAccAccDestAccDest));
            if (!(String.IsNullOrEmpty(nonOperateExpAccAccDestCompanyTypeDescription)))
            	filter.Add(("NonOperateExpAccAccDestCompanyTypeDescription:*" + nonOperateExpAccAccDestCompanyTypeDescription));
            if (!(String.IsNullOrEmpty(nonOperateExpAccAccFundAccFundCode)))
            	filter.Add(("NonOperateExpAccAccFundAccFundCode:*" + nonOperateExpAccAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(nonOperateExpAccAccSubTypeAccSubType)))
            	filter.Add(("NonOperateExpAccAccSubTypeAccSubType:*" + nonOperateExpAccAccSubTypeAccSubType));
            if (!(String.IsNullOrEmpty(nonOperateExpAccAccTypeAccType)))
            	filter.Add(("NonOperateExpAccAccTypeAccType:*" + nonOperateExpAccAccTypeAccType));
            if (!(String.IsNullOrEmpty(nonOperateExpAccCoaControlAccName)))
            	filter.Add(("NonOperateExpAccCoaControlAccName:*" + nonOperateExpAccCoaControlAccName));
            if (!(String.IsNullOrEmpty(nonOperateExpAccCoaControlAccBalTypeAccBalType)))
            	filter.Add(("NonOperateExpAccCoaControlAccBalTypeAccBalType:*" + nonOperateExpAccCoaControlAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(nonOperateExpAccCoaControlAccDestAccDest)))
            	filter.Add(("NonOperateExpAccCoaControlAccDestAccDest:*" + nonOperateExpAccCoaControlAccDestAccDest));
            if (!(String.IsNullOrEmpty(nonOperateExpAccCoaControlAccTypeAccType)))
            	filter.Add(("NonOperateExpAccCoaControlAccTypeAccType:*" + nonOperateExpAccCoaControlAccTypeAccType));
            if (!(String.IsNullOrEmpty(nonOperateExpAccCoaControlCompTypeDescription)))
            	filter.Add(("NonOperateExpAccCoaControlCompTypeDescription:*" + nonOperateExpAccCoaControlCompTypeDescription));
            if (!(String.IsNullOrEmpty(nonOperateExpAccCoaMainAccName)))
            	filter.Add(("NonOperateExpAccCoaMainAccName:*" + nonOperateExpAccCoaMainAccName));
            if (!(String.IsNullOrEmpty(nonOperateExpAccCoaMainAccBalTypeAccBalType)))
            	filter.Add(("NonOperateExpAccCoaMainAccBalTypeAccBalType:*" + nonOperateExpAccCoaMainAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(nonOperateExpAccCoaMainAccDestAccDest)))
            	filter.Add(("NonOperateExpAccCoaMainAccDestAccDest:*" + nonOperateExpAccCoaMainAccDestAccDest));
            if (!(String.IsNullOrEmpty(nonOperateExpAccCoaMainAccFundAccFundCode)))
            	filter.Add(("NonOperateExpAccCoaMainAccFundAccFundCode:*" + nonOperateExpAccCoaMainAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(nonOperateExpAccCoaMainAccTypeAccType)))
            	filter.Add(("NonOperateExpAccCoaMainAccTypeAccType:*" + nonOperateExpAccCoaMainAccTypeAccType));
            if (!(String.IsNullOrEmpty(nonOperateExpAccCoaMainCoaControlAccName)))
            	filter.Add(("NonOperateExpAccCoaMainCoaControlAccName:*" + nonOperateExpAccCoaMainCoaControlAccName));
            if (!(String.IsNullOrEmpty(nonOperateExpAccCoaSubAccName)))
            	filter.Add(("NonOperateExpAccCoaSubAccName:*" + nonOperateExpAccCoaSubAccName));
            if (!(String.IsNullOrEmpty(nonOperateExpAccCoaSubAccBalTypeAccBalType)))
            	filter.Add(("NonOperateExpAccCoaSubAccBalTypeAccBalType:*" + nonOperateExpAccCoaSubAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(nonOperateExpAccCoaSubAccDestAccDest)))
            	filter.Add(("NonOperateExpAccCoaSubAccDestAccDest:*" + nonOperateExpAccCoaSubAccDestAccDest));
            if (!(String.IsNullOrEmpty(nonOperateExpAccCoaSubAccFundAccFundCode)))
            	filter.Add(("NonOperateExpAccCoaSubAccFundAccFundCode:*" + nonOperateExpAccCoaSubAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(nonOperateExpAccCoaSubAccTypeAccType)))
            	filter.Add(("NonOperateExpAccCoaSubAccTypeAccType:*" + nonOperateExpAccCoaSubAccTypeAccType));
            if (!(String.IsNullOrEmpty(nonOperateExpAccCoaSubCoaControlAccName)))
            	filter.Add(("NonOperateExpAccCoaSubCoaControlAccName:*" + nonOperateExpAccCoaSubCoaControlAccName));
            if (!(String.IsNullOrEmpty(nonOperateExpAccCoaSubCoaMainAccName)))
            	filter.Add(("NonOperateExpAccCoaSubCoaMainAccName:*" + nonOperateExpAccCoaSubCoaMainAccName));
            if (prevYearPLAcc.HasValue)
            	filter.Add(("PrevYearPLAcc:=" + prevYearPLAcc.Value.ToString()));
            if (!(String.IsNullOrEmpty(prevYearPLAccAccName)))
            	filter.Add(("PrevYearPLAccAccName:*" + prevYearPLAccAccName));
            if (!(String.IsNullOrEmpty(prevYearPLAccAccBalTypeAccBalType)))
            	filter.Add(("PrevYearPLAccAccBalTypeAccBalType:*" + prevYearPLAccAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(prevYearPLAccAccCurrencyAccCurrencyName)))
            	filter.Add(("PrevYearPLAccAccCurrencyAccCurrencyName:*" + prevYearPLAccAccCurrencyAccCurrencyName));
            if (!(String.IsNullOrEmpty(prevYearPLAccAccDestAccDest)))
            	filter.Add(("PrevYearPLAccAccDestAccDest:*" + prevYearPLAccAccDestAccDest));
            if (!(String.IsNullOrEmpty(prevYearPLAccAccDestCompanyTypeDescription)))
            	filter.Add(("PrevYearPLAccAccDestCompanyTypeDescription:*" + prevYearPLAccAccDestCompanyTypeDescription));
            if (!(String.IsNullOrEmpty(prevYearPLAccAccFundAccFundCode)))
            	filter.Add(("PrevYearPLAccAccFundAccFundCode:*" + prevYearPLAccAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(prevYearPLAccAccSubTypeAccSubType)))
            	filter.Add(("PrevYearPLAccAccSubTypeAccSubType:*" + prevYearPLAccAccSubTypeAccSubType));
            if (!(String.IsNullOrEmpty(prevYearPLAccAccTypeAccType)))
            	filter.Add(("PrevYearPLAccAccTypeAccType:*" + prevYearPLAccAccTypeAccType));
            if (!(String.IsNullOrEmpty(prevYearPLAccCoaControlAccName)))
            	filter.Add(("PrevYearPLAccCoaControlAccName:*" + prevYearPLAccCoaControlAccName));
            if (!(String.IsNullOrEmpty(prevYearPLAccCoaControlAccBalTypeAccBalType)))
            	filter.Add(("PrevYearPLAccCoaControlAccBalTypeAccBalType:*" + prevYearPLAccCoaControlAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(prevYearPLAccCoaControlAccDestAccDest)))
            	filter.Add(("PrevYearPLAccCoaControlAccDestAccDest:*" + prevYearPLAccCoaControlAccDestAccDest));
            if (!(String.IsNullOrEmpty(prevYearPLAccCoaControlAccTypeAccType)))
            	filter.Add(("PrevYearPLAccCoaControlAccTypeAccType:*" + prevYearPLAccCoaControlAccTypeAccType));
            if (!(String.IsNullOrEmpty(prevYearPLAccCoaControlCompTypeDescription)))
            	filter.Add(("PrevYearPLAccCoaControlCompTypeDescription:*" + prevYearPLAccCoaControlCompTypeDescription));
            if (!(String.IsNullOrEmpty(prevYearPLAccCoaMainAccName)))
            	filter.Add(("PrevYearPLAccCoaMainAccName:*" + prevYearPLAccCoaMainAccName));
            if (!(String.IsNullOrEmpty(prevYearPLAccCoaMainAccBalTypeAccBalType)))
            	filter.Add(("PrevYearPLAccCoaMainAccBalTypeAccBalType:*" + prevYearPLAccCoaMainAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(prevYearPLAccCoaMainAccDestAccDest)))
            	filter.Add(("PrevYearPLAccCoaMainAccDestAccDest:*" + prevYearPLAccCoaMainAccDestAccDest));
            if (!(String.IsNullOrEmpty(prevYearPLAccCoaMainAccFundAccFundCode)))
            	filter.Add(("PrevYearPLAccCoaMainAccFundAccFundCode:*" + prevYearPLAccCoaMainAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(prevYearPLAccCoaMainAccTypeAccType)))
            	filter.Add(("PrevYearPLAccCoaMainAccTypeAccType:*" + prevYearPLAccCoaMainAccTypeAccType));
            if (!(String.IsNullOrEmpty(prevYearPLAccCoaMainCoaControlAccName)))
            	filter.Add(("PrevYearPLAccCoaMainCoaControlAccName:*" + prevYearPLAccCoaMainCoaControlAccName));
            if (!(String.IsNullOrEmpty(prevYearPLAccCoaSubAccName)))
            	filter.Add(("PrevYearPLAccCoaSubAccName:*" + prevYearPLAccCoaSubAccName));
            if (!(String.IsNullOrEmpty(prevYearPLAccCoaSubAccBalTypeAccBalType)))
            	filter.Add(("PrevYearPLAccCoaSubAccBalTypeAccBalType:*" + prevYearPLAccCoaSubAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(prevYearPLAccCoaSubAccDestAccDest)))
            	filter.Add(("PrevYearPLAccCoaSubAccDestAccDest:*" + prevYearPLAccCoaSubAccDestAccDest));
            if (!(String.IsNullOrEmpty(prevYearPLAccCoaSubAccFundAccFundCode)))
            	filter.Add(("PrevYearPLAccCoaSubAccFundAccFundCode:*" + prevYearPLAccCoaSubAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(prevYearPLAccCoaSubAccTypeAccType)))
            	filter.Add(("PrevYearPLAccCoaSubAccTypeAccType:*" + prevYearPLAccCoaSubAccTypeAccType));
            if (!(String.IsNullOrEmpty(prevYearPLAccCoaSubCoaControlAccName)))
            	filter.Add(("PrevYearPLAccCoaSubCoaControlAccName:*" + prevYearPLAccCoaSubCoaControlAccName));
            if (!(String.IsNullOrEmpty(prevYearPLAccCoaSubCoaMainAccName)))
            	filter.Add(("PrevYearPLAccCoaSubCoaMainAccName:*" + prevYearPLAccCoaSubCoaMainAccName));
            if (currYearPLAcc.HasValue)
            	filter.Add(("CurrYearPLAcc:=" + currYearPLAcc.Value.ToString()));
            if (!(String.IsNullOrEmpty(currYearPLAccAccName)))
            	filter.Add(("CurrYearPLAccAccName:*" + currYearPLAccAccName));
            if (!(String.IsNullOrEmpty(currYearPLAccAccBalTypeAccBalType)))
            	filter.Add(("CurrYearPLAccAccBalTypeAccBalType:*" + currYearPLAccAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(currYearPLAccAccCurrencyAccCurrencyName)))
            	filter.Add(("CurrYearPLAccAccCurrencyAccCurrencyName:*" + currYearPLAccAccCurrencyAccCurrencyName));
            if (!(String.IsNullOrEmpty(currYearPLAccAccDestAccDest)))
            	filter.Add(("CurrYearPLAccAccDestAccDest:*" + currYearPLAccAccDestAccDest));
            if (!(String.IsNullOrEmpty(currYearPLAccAccDestCompanyTypeDescription)))
            	filter.Add(("CurrYearPLAccAccDestCompanyTypeDescription:*" + currYearPLAccAccDestCompanyTypeDescription));
            if (!(String.IsNullOrEmpty(currYearPLAccAccFundAccFundCode)))
            	filter.Add(("CurrYearPLAccAccFundAccFundCode:*" + currYearPLAccAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(currYearPLAccAccSubTypeAccSubType)))
            	filter.Add(("CurrYearPLAccAccSubTypeAccSubType:*" + currYearPLAccAccSubTypeAccSubType));
            if (!(String.IsNullOrEmpty(currYearPLAccAccTypeAccType)))
            	filter.Add(("CurrYearPLAccAccTypeAccType:*" + currYearPLAccAccTypeAccType));
            if (!(String.IsNullOrEmpty(currYearPLAccCoaControlAccName)))
            	filter.Add(("CurrYearPLAccCoaControlAccName:*" + currYearPLAccCoaControlAccName));
            if (!(String.IsNullOrEmpty(currYearPLAccCoaControlAccBalTypeAccBalType)))
            	filter.Add(("CurrYearPLAccCoaControlAccBalTypeAccBalType:*" + currYearPLAccCoaControlAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(currYearPLAccCoaControlAccDestAccDest)))
            	filter.Add(("CurrYearPLAccCoaControlAccDestAccDest:*" + currYearPLAccCoaControlAccDestAccDest));
            if (!(String.IsNullOrEmpty(currYearPLAccCoaControlAccTypeAccType)))
            	filter.Add(("CurrYearPLAccCoaControlAccTypeAccType:*" + currYearPLAccCoaControlAccTypeAccType));
            if (!(String.IsNullOrEmpty(currYearPLAccCoaControlCompTypeDescription)))
            	filter.Add(("CurrYearPLAccCoaControlCompTypeDescription:*" + currYearPLAccCoaControlCompTypeDescription));
            if (!(String.IsNullOrEmpty(currYearPLAccCoaMainAccName)))
            	filter.Add(("CurrYearPLAccCoaMainAccName:*" + currYearPLAccCoaMainAccName));
            if (!(String.IsNullOrEmpty(currYearPLAccCoaMainAccBalTypeAccBalType)))
            	filter.Add(("CurrYearPLAccCoaMainAccBalTypeAccBalType:*" + currYearPLAccCoaMainAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(currYearPLAccCoaMainAccDestAccDest)))
            	filter.Add(("CurrYearPLAccCoaMainAccDestAccDest:*" + currYearPLAccCoaMainAccDestAccDest));
            if (!(String.IsNullOrEmpty(currYearPLAccCoaMainAccFundAccFundCode)))
            	filter.Add(("CurrYearPLAccCoaMainAccFundAccFundCode:*" + currYearPLAccCoaMainAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(currYearPLAccCoaMainAccTypeAccType)))
            	filter.Add(("CurrYearPLAccCoaMainAccTypeAccType:*" + currYearPLAccCoaMainAccTypeAccType));
            if (!(String.IsNullOrEmpty(currYearPLAccCoaMainCoaControlAccName)))
            	filter.Add(("CurrYearPLAccCoaMainCoaControlAccName:*" + currYearPLAccCoaMainCoaControlAccName));
            if (!(String.IsNullOrEmpty(currYearPLAccCoaSubAccName)))
            	filter.Add(("CurrYearPLAccCoaSubAccName:*" + currYearPLAccCoaSubAccName));
            if (!(String.IsNullOrEmpty(currYearPLAccCoaSubAccBalTypeAccBalType)))
            	filter.Add(("CurrYearPLAccCoaSubAccBalTypeAccBalType:*" + currYearPLAccCoaSubAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(currYearPLAccCoaSubAccDestAccDest)))
            	filter.Add(("CurrYearPLAccCoaSubAccDestAccDest:*" + currYearPLAccCoaSubAccDestAccDest));
            if (!(String.IsNullOrEmpty(currYearPLAccCoaSubAccFundAccFundCode)))
            	filter.Add(("CurrYearPLAccCoaSubAccFundAccFundCode:*" + currYearPLAccCoaSubAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(currYearPLAccCoaSubAccTypeAccType)))
            	filter.Add(("CurrYearPLAccCoaSubAccTypeAccType:*" + currYearPLAccCoaSubAccTypeAccType));
            if (!(String.IsNullOrEmpty(currYearPLAccCoaSubCoaControlAccName)))
            	filter.Add(("CurrYearPLAccCoaSubCoaControlAccName:*" + currYearPLAccCoaSubCoaControlAccName));
            if (!(String.IsNullOrEmpty(currYearPLAccCoaSubCoaMainAccName)))
            	filter.Add(("CurrYearPLAccCoaSubCoaMainAccName:*" + currYearPLAccCoaSubCoaMainAccName));
            if (chequeCCAcc.HasValue)
            	filter.Add(("ChequeCCAcc:=" + chequeCCAcc.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.AccFundAccs> Select(
                    int? accFundAccsID, 
                    int? accFundID, 
                    string accFundAccFundCode, 
                    int? cashCode, 
                    string cashAccName, 
                    string cashAccBalTypeAccBalType, 
                    string cashAccCurrencyAccCurrencyName, 
                    string cashAccDestAccDest, 
                    string cashAccDestCompanyTypeDescription, 
                    string cashAccFundAccFundCode, 
                    string cashAccSubTypeAccSubType, 
                    string cashAccTypeAccType, 
                    string cashCoaControlAccName, 
                    string cashCoaControlAccBalTypeAccBalType, 
                    string cashCoaControlAccDestAccDest, 
                    string cashCoaControlAccTypeAccType, 
                    string cashCoaControlCompTypeDescription, 
                    string cashCoaMainAccName, 
                    string cashCoaMainAccBalTypeAccBalType, 
                    string cashCoaMainAccDestAccDest, 
                    string cashCoaMainAccFundAccFundCode, 
                    string cashCoaMainAccTypeAccType, 
                    string cashCoaMainCoaControlAccName, 
                    string cashCoaSubAccName, 
                    string cashCoaSubAccBalTypeAccBalType, 
                    string cashCoaSubAccDestAccDest, 
                    string cashCoaSubAccFundAccFundCode, 
                    string cashCoaSubAccTypeAccType, 
                    string cashCoaSubCoaControlAccName, 
                    string cashCoaSubCoaMainAccName, 
                    int? bankCode, 
                    string bankAccName, 
                    string bankAccBalTypeAccBalType, 
                    string bankAccCurrencyAccCurrencyName, 
                    string bankAccDestAccDest, 
                    string bankAccDestCompanyTypeDescription, 
                    string bankAccFundAccFundCode, 
                    string bankAccSubTypeAccSubType, 
                    string bankAccTypeAccType, 
                    string bankCoaControlAccName, 
                    string bankCoaControlAccBalTypeAccBalType, 
                    string bankCoaControlAccDestAccDest, 
                    string bankCoaControlAccTypeAccType, 
                    string bankCoaControlCompTypeDescription, 
                    string bankCoaMainAccName, 
                    string bankCoaMainAccBalTypeAccBalType, 
                    string bankCoaMainAccDestAccDest, 
                    string bankCoaMainAccFundAccFundCode, 
                    string bankCoaMainAccTypeAccType, 
                    string bankCoaMainCoaControlAccName, 
                    string bankCoaSubAccName, 
                    string bankCoaSubAccBalTypeAccBalType, 
                    string bankCoaSubAccDestAccDest, 
                    string bankCoaSubAccFundAccFundCode, 
                    string bankCoaSubAccTypeAccType, 
                    string bankCoaSubCoaControlAccName, 
                    string bankCoaSubCoaMainAccName, 
                    int? advance, 
                    string advanceAccName, 
                    string advanceAccBalTypeAccBalType, 
                    string advanceAccCurrencyAccCurrencyName, 
                    string advanceAccDestAccDest, 
                    string advanceAccDestCompanyTypeDescription, 
                    string advanceAccFundAccFundCode, 
                    string advanceAccSubTypeAccSubType, 
                    string advanceAccTypeAccType, 
                    string advanceCoaControlAccName, 
                    string advanceCoaControlAccBalTypeAccBalType, 
                    string advanceCoaControlAccDestAccDest, 
                    string advanceCoaControlAccTypeAccType, 
                    string advanceCoaControlCompTypeDescription, 
                    string advanceCoaMainAccName, 
                    string advanceCoaMainAccBalTypeAccBalType, 
                    string advanceCoaMainAccDestAccDest, 
                    string advanceCoaMainAccFundAccFundCode, 
                    string advanceCoaMainAccTypeAccType, 
                    string advanceCoaMainCoaControlAccName, 
                    string advanceCoaSubAccName, 
                    string advanceCoaSubAccBalTypeAccBalType, 
                    string advanceCoaSubAccDestAccDest, 
                    string advanceCoaSubAccFundAccFundCode, 
                    string advanceCoaSubAccTypeAccType, 
                    string advanceCoaSubCoaControlAccName, 
                    string advanceCoaSubCoaMainAccName, 
                    int? purAcc, 
                    string purAccAccName, 
                    string purAccAccBalTypeAccBalType, 
                    string purAccAccCurrencyAccCurrencyName, 
                    string purAccAccDestAccDest, 
                    string purAccAccDestCompanyTypeDescription, 
                    string purAccAccFundAccFundCode, 
                    string purAccAccSubTypeAccSubType, 
                    string purAccAccTypeAccType, 
                    string purAccCoaControlAccName, 
                    string purAccCoaControlAccBalTypeAccBalType, 
                    string purAccCoaControlAccDestAccDest, 
                    string purAccCoaControlAccTypeAccType, 
                    string purAccCoaControlCompTypeDescription, 
                    string purAccCoaMainAccName, 
                    string purAccCoaMainAccBalTypeAccBalType, 
                    string purAccCoaMainAccDestAccDest, 
                    string purAccCoaMainAccFundAccFundCode, 
                    string purAccCoaMainAccTypeAccType, 
                    string purAccCoaMainCoaControlAccName, 
                    string purAccCoaSubAccName, 
                    string purAccCoaSubAccBalTypeAccBalType, 
                    string purAccCoaSubAccDestAccDest, 
                    string purAccCoaSubAccFundAccFundCode, 
                    string purAccCoaSubAccTypeAccType, 
                    string purAccCoaSubCoaControlAccName, 
                    string purAccCoaSubCoaMainAccName, 
                    int? saleAcc, 
                    string saleAccAccName, 
                    string saleAccAccBalTypeAccBalType, 
                    string saleAccAccCurrencyAccCurrencyName, 
                    string saleAccAccDestAccDest, 
                    string saleAccAccDestCompanyTypeDescription, 
                    string saleAccAccFundAccFundCode, 
                    string saleAccAccSubTypeAccSubType, 
                    string saleAccAccTypeAccType, 
                    string saleAccCoaControlAccName, 
                    string saleAccCoaControlAccBalTypeAccBalType, 
                    string saleAccCoaControlAccDestAccDest, 
                    string saleAccCoaControlAccTypeAccType, 
                    string saleAccCoaControlCompTypeDescription, 
                    string saleAccCoaMainAccName, 
                    string saleAccCoaMainAccBalTypeAccBalType, 
                    string saleAccCoaMainAccDestAccDest, 
                    string saleAccCoaMainAccFundAccFundCode, 
                    string saleAccCoaMainAccTypeAccType, 
                    string saleAccCoaMainCoaControlAccName, 
                    string saleAccCoaSubAccName, 
                    string saleAccCoaSubAccBalTypeAccBalType, 
                    string saleAccCoaSubAccDestAccDest, 
                    string saleAccCoaSubAccFundAccFundCode, 
                    string saleAccCoaSubAccTypeAccType, 
                    string saleAccCoaSubCoaControlAccName, 
                    string saleAccCoaSubCoaMainAccName, 
                    int? workinProgressAcc, 
                    string workinProgressAccAccName, 
                    string workinProgressAccAccBalTypeAccBalType, 
                    string workinProgressAccAccCurrencyAccCurrencyName, 
                    string workinProgressAccAccDestAccDest, 
                    string workinProgressAccAccDestCompanyTypeDescription, 
                    string workinProgressAccAccFundAccFundCode, 
                    string workinProgressAccAccSubTypeAccSubType, 
                    string workinProgressAccAccTypeAccType, 
                    string workinProgressAccCoaControlAccName, 
                    string workinProgressAccCoaControlAccBalTypeAccBalType, 
                    string workinProgressAccCoaControlAccDestAccDest, 
                    string workinProgressAccCoaControlAccTypeAccType, 
                    string workinProgressAccCoaControlCompTypeDescription, 
                    string workinProgressAccCoaMainAccName, 
                    string workinProgressAccCoaMainAccBalTypeAccBalType, 
                    string workinProgressAccCoaMainAccDestAccDest, 
                    string workinProgressAccCoaMainAccFundAccFundCode, 
                    string workinProgressAccCoaMainAccTypeAccType, 
                    string workinProgressAccCoaMainCoaControlAccName, 
                    string workinProgressAccCoaSubAccName, 
                    string workinProgressAccCoaSubAccBalTypeAccBalType, 
                    string workinProgressAccCoaSubAccDestAccDest, 
                    string workinProgressAccCoaSubAccFundAccFundCode, 
                    string workinProgressAccCoaSubAccTypeAccType, 
                    string workinProgressAccCoaSubCoaControlAccName, 
                    string workinProgressAccCoaSubCoaMainAccName, 
                    int? costofSold, 
                    string costofSoldAccName, 
                    string costofSoldAccBalTypeAccBalType, 
                    string costofSoldAccCurrencyAccCurrencyName, 
                    string costofSoldAccDestAccDest, 
                    string costofSoldAccDestCompanyTypeDescription, 
                    string costofSoldAccFundAccFundCode, 
                    string costofSoldAccSubTypeAccSubType, 
                    string costofSoldAccTypeAccType, 
                    string costofSoldCoaControlAccName, 
                    string costofSoldCoaControlAccBalTypeAccBalType, 
                    string costofSoldCoaControlAccDestAccDest, 
                    string costofSoldCoaControlAccTypeAccType, 
                    string costofSoldCoaControlCompTypeDescription, 
                    string costofSoldCoaMainAccName, 
                    string costofSoldCoaMainAccBalTypeAccBalType, 
                    string costofSoldCoaMainAccDestAccDest, 
                    string costofSoldCoaMainAccFundAccFundCode, 
                    string costofSoldCoaMainAccTypeAccType, 
                    string costofSoldCoaMainCoaControlAccName, 
                    string costofSoldCoaSubAccName, 
                    string costofSoldCoaSubAccBalTypeAccBalType, 
                    string costofSoldCoaSubAccDestAccDest, 
                    string costofSoldCoaSubAccFundAccFundCode, 
                    string costofSoldCoaSubAccTypeAccType, 
                    string costofSoldCoaSubCoaControlAccName, 
                    string costofSoldCoaSubCoaMainAccName, 
                    int? oPD_Acc, 
                    string oPD_AccAccName, 
                    string oPD_AccAccBalTypeAccBalType, 
                    string oPD_AccAccCurrencyAccCurrencyName, 
                    string oPD_AccAccDestAccDest, 
                    string oPD_AccAccDestCompanyTypeDescription, 
                    string oPD_AccAccFundAccFundCode, 
                    string oPD_AccAccSubTypeAccSubType, 
                    string oPD_AccAccTypeAccType, 
                    string oPD_AccCoaControlAccName, 
                    string oPD_AccCoaControlAccBalTypeAccBalType, 
                    string oPD_AccCoaControlAccDestAccDest, 
                    string oPD_AccCoaControlAccTypeAccType, 
                    string oPD_AccCoaControlCompTypeDescription, 
                    string oPD_AccCoaMainAccName, 
                    string oPD_AccCoaMainAccBalTypeAccBalType, 
                    string oPD_AccCoaMainAccDestAccDest, 
                    string oPD_AccCoaMainAccFundAccFundCode, 
                    string oPD_AccCoaMainAccTypeAccType, 
                    string oPD_AccCoaMainCoaControlAccName, 
                    string oPD_AccCoaSubAccName, 
                    string oPD_AccCoaSubAccBalTypeAccBalType, 
                    string oPD_AccCoaSubAccDestAccDest, 
                    string oPD_AccCoaSubAccFundAccFundCode, 
                    string oPD_AccCoaSubAccTypeAccType, 
                    string oPD_AccCoaSubCoaControlAccName, 
                    string oPD_AccCoaSubCoaMainAccName, 
                    int? advPat_Acc, 
                    string advPat_AccAccName, 
                    string advPat_AccAccBalTypeAccBalType, 
                    string advPat_AccAccCurrencyAccCurrencyName, 
                    string advPat_AccAccDestAccDest, 
                    string advPat_AccAccDestCompanyTypeDescription, 
                    string advPat_AccAccFundAccFundCode, 
                    string advPat_AccAccSubTypeAccSubType, 
                    string advPat_AccAccTypeAccType, 
                    string advPat_AccCoaControlAccName, 
                    string advPat_AccCoaControlAccBalTypeAccBalType, 
                    string advPat_AccCoaControlAccDestAccDest, 
                    string advPat_AccCoaControlAccTypeAccType, 
                    string advPat_AccCoaControlCompTypeDescription, 
                    string advPat_AccCoaMainAccName, 
                    string advPat_AccCoaMainAccBalTypeAccBalType, 
                    string advPat_AccCoaMainAccDestAccDest, 
                    string advPat_AccCoaMainAccFundAccFundCode, 
                    string advPat_AccCoaMainAccTypeAccType, 
                    string advPat_AccCoaMainCoaControlAccName, 
                    string advPat_AccCoaSubAccName, 
                    string advPat_AccCoaSubAccBalTypeAccBalType, 
                    string advPat_AccCoaSubAccDestAccDest, 
                    string advPat_AccCoaSubAccFundAccFundCode, 
                    string advPat_AccCoaSubAccTypeAccType, 
                    string advPat_AccCoaSubCoaControlAccName, 
                    string advPat_AccCoaSubCoaMainAccName, 
                    int? investigate_Acc, 
                    string investigate_AccAccName, 
                    string investigate_AccAccBalTypeAccBalType, 
                    string investigate_AccAccCurrencyAccCurrencyName, 
                    string investigate_AccAccDestAccDest, 
                    string investigate_AccAccDestCompanyTypeDescription, 
                    string investigate_AccAccFundAccFundCode, 
                    string investigate_AccAccSubTypeAccSubType, 
                    string investigate_AccAccTypeAccType, 
                    string investigate_AccCoaControlAccName, 
                    string investigate_AccCoaControlAccBalTypeAccBalType, 
                    string investigate_AccCoaControlAccDestAccDest, 
                    string investigate_AccCoaControlAccTypeAccType, 
                    string investigate_AccCoaControlCompTypeDescription, 
                    string investigate_AccCoaMainAccName, 
                    string investigate_AccCoaMainAccBalTypeAccBalType, 
                    string investigate_AccCoaMainAccDestAccDest, 
                    string investigate_AccCoaMainAccFundAccFundCode, 
                    string investigate_AccCoaMainAccTypeAccType, 
                    string investigate_AccCoaMainCoaControlAccName, 
                    string investigate_AccCoaSubAccName, 
                    string investigate_AccCoaSubAccBalTypeAccBalType, 
                    string investigate_AccCoaSubAccDestAccDest, 
                    string investigate_AccCoaSubAccFundAccFundCode, 
                    string investigate_AccCoaSubAccTypeAccType, 
                    string investigate_AccCoaSubCoaControlAccName, 
                    string investigate_AccCoaSubCoaMainAccName, 
                    int? vatAcc, 
                    string vatAccAccName, 
                    string vatAccAccBalTypeAccBalType, 
                    string vatAccAccCurrencyAccCurrencyName, 
                    string vatAccAccDestAccDest, 
                    string vatAccAccDestCompanyTypeDescription, 
                    string vatAccAccFundAccFundCode, 
                    string vatAccAccSubTypeAccSubType, 
                    string vatAccAccTypeAccType, 
                    string vatAccCoaControlAccName, 
                    string vatAccCoaControlAccBalTypeAccBalType, 
                    string vatAccCoaControlAccDestAccDest, 
                    string vatAccCoaControlAccTypeAccType, 
                    string vatAccCoaControlCompTypeDescription, 
                    string vatAccCoaMainAccName, 
                    string vatAccCoaMainAccBalTypeAccBalType, 
                    string vatAccCoaMainAccDestAccDest, 
                    string vatAccCoaMainAccFundAccFundCode, 
                    string vatAccCoaMainAccTypeAccType, 
                    string vatAccCoaMainCoaControlAccName, 
                    string vatAccCoaSubAccName, 
                    string vatAccCoaSubAccBalTypeAccBalType, 
                    string vatAccCoaSubAccDestAccDest, 
                    string vatAccCoaSubAccFundAccFundCode, 
                    string vatAccCoaSubAccTypeAccType, 
                    string vatAccCoaSubCoaControlAccName, 
                    string vatAccCoaSubCoaMainAccName, 
                    int? sundryDebitors, 
                    string sundryDebitorsAccName, 
                    string sundryDebitorsAccBalTypeAccBalType, 
                    string sundryDebitorsAccCurrencyAccCurrencyName, 
                    string sundryDebitorsAccDestAccDest, 
                    string sundryDebitorsAccDestCompanyTypeDescription, 
                    string sundryDebitorsAccFundAccFundCode, 
                    string sundryDebitorsAccSubTypeAccSubType, 
                    string sundryDebitorsAccTypeAccType, 
                    string sundryDebitorsCoaControlAccName, 
                    string sundryDebitorsCoaControlAccBalTypeAccBalType, 
                    string sundryDebitorsCoaControlAccDestAccDest, 
                    string sundryDebitorsCoaControlAccTypeAccType, 
                    string sundryDebitorsCoaControlCompTypeDescription, 
                    string sundryDebitorsCoaMainAccName, 
                    string sundryDebitorsCoaMainAccBalTypeAccBalType, 
                    string sundryDebitorsCoaMainAccDestAccDest, 
                    string sundryDebitorsCoaMainAccFundAccFundCode, 
                    string sundryDebitorsCoaMainAccTypeAccType, 
                    string sundryDebitorsCoaMainCoaControlAccName, 
                    string sundryDebitorsCoaSubAccName, 
                    string sundryDebitorsCoaSubAccBalTypeAccBalType, 
                    string sundryDebitorsCoaSubAccDestAccDest, 
                    string sundryDebitorsCoaSubAccFundAccFundCode, 
                    string sundryDebitorsCoaSubAccTypeAccType, 
                    string sundryDebitorsCoaSubCoaControlAccName, 
                    string sundryDebitorsCoaSubCoaMainAccName, 
                    int? sundryCreditors, 
                    string sundryCreditorsAccName, 
                    string sundryCreditorsAccBalTypeAccBalType, 
                    string sundryCreditorsAccCurrencyAccCurrencyName, 
                    string sundryCreditorsAccDestAccDest, 
                    string sundryCreditorsAccDestCompanyTypeDescription, 
                    string sundryCreditorsAccFundAccFundCode, 
                    string sundryCreditorsAccSubTypeAccSubType, 
                    string sundryCreditorsAccTypeAccType, 
                    string sundryCreditorsCoaControlAccName, 
                    string sundryCreditorsCoaControlAccBalTypeAccBalType, 
                    string sundryCreditorsCoaControlAccDestAccDest, 
                    string sundryCreditorsCoaControlAccTypeAccType, 
                    string sundryCreditorsCoaControlCompTypeDescription, 
                    string sundryCreditorsCoaMainAccName, 
                    string sundryCreditorsCoaMainAccBalTypeAccBalType, 
                    string sundryCreditorsCoaMainAccDestAccDest, 
                    string sundryCreditorsCoaMainAccFundAccFundCode, 
                    string sundryCreditorsCoaMainAccTypeAccType, 
                    string sundryCreditorsCoaMainCoaControlAccName, 
                    string sundryCreditorsCoaSubAccName, 
                    string sundryCreditorsCoaSubAccBalTypeAccBalType, 
                    string sundryCreditorsCoaSubAccDestAccDest, 
                    string sundryCreditorsCoaSubAccFundAccFundCode, 
                    string sundryCreditorsCoaSubAccTypeAccType, 
                    string sundryCreditorsCoaSubCoaControlAccName, 
                    string sundryCreditorsCoaSubCoaMainAccName, 
                    int? rawMatAcc, 
                    string rawMatAccAccName, 
                    string rawMatAccAccBalTypeAccBalType, 
                    string rawMatAccAccCurrencyAccCurrencyName, 
                    string rawMatAccAccDestAccDest, 
                    string rawMatAccAccDestCompanyTypeDescription, 
                    string rawMatAccAccFundAccFundCode, 
                    string rawMatAccAccSubTypeAccSubType, 
                    string rawMatAccAccTypeAccType, 
                    string rawMatAccCoaControlAccName, 
                    string rawMatAccCoaControlAccBalTypeAccBalType, 
                    string rawMatAccCoaControlAccDestAccDest, 
                    string rawMatAccCoaControlAccTypeAccType, 
                    string rawMatAccCoaControlCompTypeDescription, 
                    string rawMatAccCoaMainAccName, 
                    string rawMatAccCoaMainAccBalTypeAccBalType, 
                    string rawMatAccCoaMainAccDestAccDest, 
                    string rawMatAccCoaMainAccFundAccFundCode, 
                    string rawMatAccCoaMainAccTypeAccType, 
                    string rawMatAccCoaMainCoaControlAccName, 
                    string rawMatAccCoaSubAccName, 
                    string rawMatAccCoaSubAccBalTypeAccBalType, 
                    string rawMatAccCoaSubAccDestAccDest, 
                    string rawMatAccCoaSubAccFundAccFundCode, 
                    string rawMatAccCoaSubAccTypeAccType, 
                    string rawMatAccCoaSubCoaControlAccName, 
                    string rawMatAccCoaSubCoaMainAccName, 
                    int? packMatAcc, 
                    string packMatAccAccName, 
                    string packMatAccAccBalTypeAccBalType, 
                    string packMatAccAccCurrencyAccCurrencyName, 
                    string packMatAccAccDestAccDest, 
                    string packMatAccAccDestCompanyTypeDescription, 
                    string packMatAccAccFundAccFundCode, 
                    string packMatAccAccSubTypeAccSubType, 
                    string packMatAccAccTypeAccType, 
                    string packMatAccCoaControlAccName, 
                    string packMatAccCoaControlAccBalTypeAccBalType, 
                    string packMatAccCoaControlAccDestAccDest, 
                    string packMatAccCoaControlAccTypeAccType, 
                    string packMatAccCoaControlCompTypeDescription, 
                    string packMatAccCoaMainAccName, 
                    string packMatAccCoaMainAccBalTypeAccBalType, 
                    string packMatAccCoaMainAccDestAccDest, 
                    string packMatAccCoaMainAccFundAccFundCode, 
                    string packMatAccCoaMainAccTypeAccType, 
                    string packMatAccCoaMainCoaControlAccName, 
                    string packMatAccCoaSubAccName, 
                    string packMatAccCoaSubAccBalTypeAccBalType, 
                    string packMatAccCoaSubAccDestAccDest, 
                    string packMatAccCoaSubAccFundAccFundCode, 
                    string packMatAccCoaSubAccTypeAccType, 
                    string packMatAccCoaSubCoaControlAccName, 
                    string packMatAccCoaSubCoaMainAccName, 
                    int? otherMatAcc, 
                    string otherMatAccAccName, 
                    string otherMatAccAccBalTypeAccBalType, 
                    string otherMatAccAccCurrencyAccCurrencyName, 
                    string otherMatAccAccDestAccDest, 
                    string otherMatAccAccDestCompanyTypeDescription, 
                    string otherMatAccAccFundAccFundCode, 
                    string otherMatAccAccSubTypeAccSubType, 
                    string otherMatAccAccTypeAccType, 
                    string otherMatAccCoaControlAccName, 
                    string otherMatAccCoaControlAccBalTypeAccBalType, 
                    string otherMatAccCoaControlAccDestAccDest, 
                    string otherMatAccCoaControlAccTypeAccType, 
                    string otherMatAccCoaControlCompTypeDescription, 
                    string otherMatAccCoaMainAccName, 
                    string otherMatAccCoaMainAccBalTypeAccBalType, 
                    string otherMatAccCoaMainAccDestAccDest, 
                    string otherMatAccCoaMainAccFundAccFundCode, 
                    string otherMatAccCoaMainAccTypeAccType, 
                    string otherMatAccCoaMainCoaControlAccName, 
                    string otherMatAccCoaSubAccName, 
                    string otherMatAccCoaSubAccBalTypeAccBalType, 
                    string otherMatAccCoaSubAccDestAccDest, 
                    string otherMatAccCoaSubAccFundAccFundCode, 
                    string otherMatAccCoaSubAccTypeAccType, 
                    string otherMatAccCoaSubCoaControlAccName, 
                    string otherMatAccCoaSubCoaMainAccName, 
                    int? finishMatAcc, 
                    string finishMatAccAccName, 
                    string finishMatAccAccBalTypeAccBalType, 
                    string finishMatAccAccCurrencyAccCurrencyName, 
                    string finishMatAccAccDestAccDest, 
                    string finishMatAccAccDestCompanyTypeDescription, 
                    string finishMatAccAccFundAccFundCode, 
                    string finishMatAccAccSubTypeAccSubType, 
                    string finishMatAccAccTypeAccType, 
                    string finishMatAccCoaControlAccName, 
                    string finishMatAccCoaControlAccBalTypeAccBalType, 
                    string finishMatAccCoaControlAccDestAccDest, 
                    string finishMatAccCoaControlAccTypeAccType, 
                    string finishMatAccCoaControlCompTypeDescription, 
                    string finishMatAccCoaMainAccName, 
                    string finishMatAccCoaMainAccBalTypeAccBalType, 
                    string finishMatAccCoaMainAccDestAccDest, 
                    string finishMatAccCoaMainAccFundAccFundCode, 
                    string finishMatAccCoaMainAccTypeAccType, 
                    string finishMatAccCoaMainCoaControlAccName, 
                    string finishMatAccCoaSubAccName, 
                    string finishMatAccCoaSubAccBalTypeAccBalType, 
                    string finishMatAccCoaSubAccDestAccDest, 
                    string finishMatAccCoaSubAccFundAccFundCode, 
                    string finishMatAccCoaSubAccTypeAccType, 
                    string finishMatAccCoaSubCoaControlAccName, 
                    string finishMatAccCoaSubCoaMainAccName, 
                    int? adminExpAcc, 
                    string adminExpAccAccName, 
                    string adminExpAccAccBalTypeAccBalType, 
                    string adminExpAccAccCurrencyAccCurrencyName, 
                    string adminExpAccAccDestAccDest, 
                    string adminExpAccAccDestCompanyTypeDescription, 
                    string adminExpAccAccFundAccFundCode, 
                    string adminExpAccAccSubTypeAccSubType, 
                    string adminExpAccAccTypeAccType, 
                    string adminExpAccCoaControlAccName, 
                    string adminExpAccCoaControlAccBalTypeAccBalType, 
                    string adminExpAccCoaControlAccDestAccDest, 
                    string adminExpAccCoaControlAccTypeAccType, 
                    string adminExpAccCoaControlCompTypeDescription, 
                    string adminExpAccCoaMainAccName, 
                    string adminExpAccCoaMainAccBalTypeAccBalType, 
                    string adminExpAccCoaMainAccDestAccDest, 
                    string adminExpAccCoaMainAccFundAccFundCode, 
                    string adminExpAccCoaMainAccTypeAccType, 
                    string adminExpAccCoaMainCoaControlAccName, 
                    string adminExpAccCoaSubAccName, 
                    string adminExpAccCoaSubAccBalTypeAccBalType, 
                    string adminExpAccCoaSubAccDestAccDest, 
                    string adminExpAccCoaSubAccFundAccFundCode, 
                    string adminExpAccCoaSubAccTypeAccType, 
                    string adminExpAccCoaSubCoaControlAccName, 
                    string adminExpAccCoaSubCoaMainAccName, 
                    int? sellingExpAcc, 
                    string sellingExpAccAccName, 
                    string sellingExpAccAccBalTypeAccBalType, 
                    string sellingExpAccAccCurrencyAccCurrencyName, 
                    string sellingExpAccAccDestAccDest, 
                    string sellingExpAccAccDestCompanyTypeDescription, 
                    string sellingExpAccAccFundAccFundCode, 
                    string sellingExpAccAccSubTypeAccSubType, 
                    string sellingExpAccAccTypeAccType, 
                    string sellingExpAccCoaControlAccName, 
                    string sellingExpAccCoaControlAccBalTypeAccBalType, 
                    string sellingExpAccCoaControlAccDestAccDest, 
                    string sellingExpAccCoaControlAccTypeAccType, 
                    string sellingExpAccCoaControlCompTypeDescription, 
                    string sellingExpAccCoaMainAccName, 
                    string sellingExpAccCoaMainAccBalTypeAccBalType, 
                    string sellingExpAccCoaMainAccDestAccDest, 
                    string sellingExpAccCoaMainAccFundAccFundCode, 
                    string sellingExpAccCoaMainAccTypeAccType, 
                    string sellingExpAccCoaMainCoaControlAccName, 
                    string sellingExpAccCoaSubAccName, 
                    string sellingExpAccCoaSubAccBalTypeAccBalType, 
                    string sellingExpAccCoaSubAccDestAccDest, 
                    string sellingExpAccCoaSubAccFundAccFundCode, 
                    string sellingExpAccCoaSubAccTypeAccType, 
                    string sellingExpAccCoaSubCoaControlAccName, 
                    string sellingExpAccCoaSubCoaMainAccName, 
                    int? manuExpAcc, 
                    string manuExpAccAccName, 
                    string manuExpAccAccBalTypeAccBalType, 
                    string manuExpAccAccCurrencyAccCurrencyName, 
                    string manuExpAccAccDestAccDest, 
                    string manuExpAccAccDestCompanyTypeDescription, 
                    string manuExpAccAccFundAccFundCode, 
                    string manuExpAccAccSubTypeAccSubType, 
                    string manuExpAccAccTypeAccType, 
                    string manuExpAccCoaControlAccName, 
                    string manuExpAccCoaControlAccBalTypeAccBalType, 
                    string manuExpAccCoaControlAccDestAccDest, 
                    string manuExpAccCoaControlAccTypeAccType, 
                    string manuExpAccCoaControlCompTypeDescription, 
                    string manuExpAccCoaMainAccName, 
                    string manuExpAccCoaMainAccBalTypeAccBalType, 
                    string manuExpAccCoaMainAccDestAccDest, 
                    string manuExpAccCoaMainAccFundAccFundCode, 
                    string manuExpAccCoaMainAccTypeAccType, 
                    string manuExpAccCoaMainCoaControlAccName, 
                    string manuExpAccCoaSubAccName, 
                    string manuExpAccCoaSubAccBalTypeAccBalType, 
                    string manuExpAccCoaSubAccDestAccDest, 
                    string manuExpAccCoaSubAccFundAccFundCode, 
                    string manuExpAccCoaSubAccTypeAccType, 
                    string manuExpAccCoaSubCoaControlAccName, 
                    string manuExpAccCoaSubCoaMainAccName, 
                    int? loanAcc, 
                    string loanAccAccName, 
                    string loanAccAccBalTypeAccBalType, 
                    string loanAccAccCurrencyAccCurrencyName, 
                    string loanAccAccDestAccDest, 
                    string loanAccAccDestCompanyTypeDescription, 
                    string loanAccAccFundAccFundCode, 
                    string loanAccAccSubTypeAccSubType, 
                    string loanAccAccTypeAccType, 
                    string loanAccCoaControlAccName, 
                    string loanAccCoaControlAccBalTypeAccBalType, 
                    string loanAccCoaControlAccDestAccDest, 
                    string loanAccCoaControlAccTypeAccType, 
                    string loanAccCoaControlCompTypeDescription, 
                    string loanAccCoaMainAccName, 
                    string loanAccCoaMainAccBalTypeAccBalType, 
                    string loanAccCoaMainAccDestAccDest, 
                    string loanAccCoaMainAccFundAccFundCode, 
                    string loanAccCoaMainAccTypeAccType, 
                    string loanAccCoaMainCoaControlAccName, 
                    string loanAccCoaSubAccName, 
                    string loanAccCoaSubAccBalTypeAccBalType, 
                    string loanAccCoaSubAccDestAccDest, 
                    string loanAccCoaSubAccFundAccFundCode, 
                    string loanAccCoaSubAccTypeAccType, 
                    string loanAccCoaSubCoaControlAccName, 
                    string loanAccCoaSubCoaMainAccName, 
                    int? assetDepAcc, 
                    string assetDepAccAccName, 
                    string assetDepAccAccBalTypeAccBalType, 
                    string assetDepAccAccCurrencyAccCurrencyName, 
                    string assetDepAccAccDestAccDest, 
                    string assetDepAccAccDestCompanyTypeDescription, 
                    string assetDepAccAccFundAccFundCode, 
                    string assetDepAccAccSubTypeAccSubType, 
                    string assetDepAccAccTypeAccType, 
                    string assetDepAccCoaControlAccName, 
                    string assetDepAccCoaControlAccBalTypeAccBalType, 
                    string assetDepAccCoaControlAccDestAccDest, 
                    string assetDepAccCoaControlAccTypeAccType, 
                    string assetDepAccCoaControlCompTypeDescription, 
                    string assetDepAccCoaMainAccName, 
                    string assetDepAccCoaMainAccBalTypeAccBalType, 
                    string assetDepAccCoaMainAccDestAccDest, 
                    string assetDepAccCoaMainAccFundAccFundCode, 
                    string assetDepAccCoaMainAccTypeAccType, 
                    string assetDepAccCoaMainCoaControlAccName, 
                    string assetDepAccCoaSubAccName, 
                    string assetDepAccCoaSubAccBalTypeAccBalType, 
                    string assetDepAccCoaSubAccDestAccDest, 
                    string assetDepAccCoaSubAccFundAccFundCode, 
                    string assetDepAccCoaSubAccTypeAccType, 
                    string assetDepAccCoaSubCoaControlAccName, 
                    string assetDepAccCoaSubCoaMainAccName, 
                    int? nonOperateIncAcc, 
                    string nonOperateIncAccAccName, 
                    string nonOperateIncAccAccBalTypeAccBalType, 
                    string nonOperateIncAccAccCurrencyAccCurrencyName, 
                    string nonOperateIncAccAccDestAccDest, 
                    string nonOperateIncAccAccDestCompanyTypeDescription, 
                    string nonOperateIncAccAccFundAccFundCode, 
                    string nonOperateIncAccAccSubTypeAccSubType, 
                    string nonOperateIncAccAccTypeAccType, 
                    string nonOperateIncAccCoaControlAccName, 
                    string nonOperateIncAccCoaControlAccBalTypeAccBalType, 
                    string nonOperateIncAccCoaControlAccDestAccDest, 
                    string nonOperateIncAccCoaControlAccTypeAccType, 
                    string nonOperateIncAccCoaControlCompTypeDescription, 
                    string nonOperateIncAccCoaMainAccName, 
                    string nonOperateIncAccCoaMainAccBalTypeAccBalType, 
                    string nonOperateIncAccCoaMainAccDestAccDest, 
                    string nonOperateIncAccCoaMainAccFundAccFundCode, 
                    string nonOperateIncAccCoaMainAccTypeAccType, 
                    string nonOperateIncAccCoaMainCoaControlAccName, 
                    string nonOperateIncAccCoaSubAccName, 
                    string nonOperateIncAccCoaSubAccBalTypeAccBalType, 
                    string nonOperateIncAccCoaSubAccDestAccDest, 
                    string nonOperateIncAccCoaSubAccFundAccFundCode, 
                    string nonOperateIncAccCoaSubAccTypeAccType, 
                    string nonOperateIncAccCoaSubCoaControlAccName, 
                    string nonOperateIncAccCoaSubCoaMainAccName, 
                    int? nonOperateExpAcc, 
                    string nonOperateExpAccAccName, 
                    string nonOperateExpAccAccBalTypeAccBalType, 
                    string nonOperateExpAccAccCurrencyAccCurrencyName, 
                    string nonOperateExpAccAccDestAccDest, 
                    string nonOperateExpAccAccDestCompanyTypeDescription, 
                    string nonOperateExpAccAccFundAccFundCode, 
                    string nonOperateExpAccAccSubTypeAccSubType, 
                    string nonOperateExpAccAccTypeAccType, 
                    string nonOperateExpAccCoaControlAccName, 
                    string nonOperateExpAccCoaControlAccBalTypeAccBalType, 
                    string nonOperateExpAccCoaControlAccDestAccDest, 
                    string nonOperateExpAccCoaControlAccTypeAccType, 
                    string nonOperateExpAccCoaControlCompTypeDescription, 
                    string nonOperateExpAccCoaMainAccName, 
                    string nonOperateExpAccCoaMainAccBalTypeAccBalType, 
                    string nonOperateExpAccCoaMainAccDestAccDest, 
                    string nonOperateExpAccCoaMainAccFundAccFundCode, 
                    string nonOperateExpAccCoaMainAccTypeAccType, 
                    string nonOperateExpAccCoaMainCoaControlAccName, 
                    string nonOperateExpAccCoaSubAccName, 
                    string nonOperateExpAccCoaSubAccBalTypeAccBalType, 
                    string nonOperateExpAccCoaSubAccDestAccDest, 
                    string nonOperateExpAccCoaSubAccFundAccFundCode, 
                    string nonOperateExpAccCoaSubAccTypeAccType, 
                    string nonOperateExpAccCoaSubCoaControlAccName, 
                    string nonOperateExpAccCoaSubCoaMainAccName, 
                    int? prevYearPLAcc, 
                    string prevYearPLAccAccName, 
                    string prevYearPLAccAccBalTypeAccBalType, 
                    string prevYearPLAccAccCurrencyAccCurrencyName, 
                    string prevYearPLAccAccDestAccDest, 
                    string prevYearPLAccAccDestCompanyTypeDescription, 
                    string prevYearPLAccAccFundAccFundCode, 
                    string prevYearPLAccAccSubTypeAccSubType, 
                    string prevYearPLAccAccTypeAccType, 
                    string prevYearPLAccCoaControlAccName, 
                    string prevYearPLAccCoaControlAccBalTypeAccBalType, 
                    string prevYearPLAccCoaControlAccDestAccDest, 
                    string prevYearPLAccCoaControlAccTypeAccType, 
                    string prevYearPLAccCoaControlCompTypeDescription, 
                    string prevYearPLAccCoaMainAccName, 
                    string prevYearPLAccCoaMainAccBalTypeAccBalType, 
                    string prevYearPLAccCoaMainAccDestAccDest, 
                    string prevYearPLAccCoaMainAccFundAccFundCode, 
                    string prevYearPLAccCoaMainAccTypeAccType, 
                    string prevYearPLAccCoaMainCoaControlAccName, 
                    string prevYearPLAccCoaSubAccName, 
                    string prevYearPLAccCoaSubAccBalTypeAccBalType, 
                    string prevYearPLAccCoaSubAccDestAccDest, 
                    string prevYearPLAccCoaSubAccFundAccFundCode, 
                    string prevYearPLAccCoaSubAccTypeAccType, 
                    string prevYearPLAccCoaSubCoaControlAccName, 
                    string prevYearPLAccCoaSubCoaMainAccName, 
                    int? currYearPLAcc, 
                    string currYearPLAccAccName, 
                    string currYearPLAccAccBalTypeAccBalType, 
                    string currYearPLAccAccCurrencyAccCurrencyName, 
                    string currYearPLAccAccDestAccDest, 
                    string currYearPLAccAccDestCompanyTypeDescription, 
                    string currYearPLAccAccFundAccFundCode, 
                    string currYearPLAccAccSubTypeAccSubType, 
                    string currYearPLAccAccTypeAccType, 
                    string currYearPLAccCoaControlAccName, 
                    string currYearPLAccCoaControlAccBalTypeAccBalType, 
                    string currYearPLAccCoaControlAccDestAccDest, 
                    string currYearPLAccCoaControlAccTypeAccType, 
                    string currYearPLAccCoaControlCompTypeDescription, 
                    string currYearPLAccCoaMainAccName, 
                    string currYearPLAccCoaMainAccBalTypeAccBalType, 
                    string currYearPLAccCoaMainAccDestAccDest, 
                    string currYearPLAccCoaMainAccFundAccFundCode, 
                    string currYearPLAccCoaMainAccTypeAccType, 
                    string currYearPLAccCoaMainCoaControlAccName, 
                    string currYearPLAccCoaSubAccName, 
                    string currYearPLAccCoaSubAccBalTypeAccBalType, 
                    string currYearPLAccCoaSubAccDestAccDest, 
                    string currYearPLAccCoaSubAccFundAccFundCode, 
                    string currYearPLAccCoaSubAccTypeAccType, 
                    string currYearPLAccCoaSubCoaControlAccName, 
                    string currYearPLAccCoaSubCoaMainAccName, 
                    int? chequeCCAcc, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(accFundAccsID, accFundID, accFundAccFundCode, cashCode, cashAccName, cashAccBalTypeAccBalType, cashAccCurrencyAccCurrencyName, cashAccDestAccDest, cashAccDestCompanyTypeDescription, cashAccFundAccFundCode, cashAccSubTypeAccSubType, cashAccTypeAccType, cashCoaControlAccName, cashCoaControlAccBalTypeAccBalType, cashCoaControlAccDestAccDest, cashCoaControlAccTypeAccType, cashCoaControlCompTypeDescription, cashCoaMainAccName, cashCoaMainAccBalTypeAccBalType, cashCoaMainAccDestAccDest, cashCoaMainAccFundAccFundCode, cashCoaMainAccTypeAccType, cashCoaMainCoaControlAccName, cashCoaSubAccName, cashCoaSubAccBalTypeAccBalType, cashCoaSubAccDestAccDest, cashCoaSubAccFundAccFundCode, cashCoaSubAccTypeAccType, cashCoaSubCoaControlAccName, cashCoaSubCoaMainAccName, bankCode, bankAccName, bankAccBalTypeAccBalType, bankAccCurrencyAccCurrencyName, bankAccDestAccDest, bankAccDestCompanyTypeDescription, bankAccFundAccFundCode, bankAccSubTypeAccSubType, bankAccTypeAccType, bankCoaControlAccName, bankCoaControlAccBalTypeAccBalType, bankCoaControlAccDestAccDest, bankCoaControlAccTypeAccType, bankCoaControlCompTypeDescription, bankCoaMainAccName, bankCoaMainAccBalTypeAccBalType, bankCoaMainAccDestAccDest, bankCoaMainAccFundAccFundCode, bankCoaMainAccTypeAccType, bankCoaMainCoaControlAccName, bankCoaSubAccName, bankCoaSubAccBalTypeAccBalType, bankCoaSubAccDestAccDest, bankCoaSubAccFundAccFundCode, bankCoaSubAccTypeAccType, bankCoaSubCoaControlAccName, bankCoaSubCoaMainAccName, advance, advanceAccName, advanceAccBalTypeAccBalType, advanceAccCurrencyAccCurrencyName, advanceAccDestAccDest, advanceAccDestCompanyTypeDescription, advanceAccFundAccFundCode, advanceAccSubTypeAccSubType, advanceAccTypeAccType, advanceCoaControlAccName, advanceCoaControlAccBalTypeAccBalType, advanceCoaControlAccDestAccDest, advanceCoaControlAccTypeAccType, advanceCoaControlCompTypeDescription, advanceCoaMainAccName, advanceCoaMainAccBalTypeAccBalType, advanceCoaMainAccDestAccDest, advanceCoaMainAccFundAccFundCode, advanceCoaMainAccTypeAccType, advanceCoaMainCoaControlAccName, advanceCoaSubAccName, advanceCoaSubAccBalTypeAccBalType, advanceCoaSubAccDestAccDest, advanceCoaSubAccFundAccFundCode, advanceCoaSubAccTypeAccType, advanceCoaSubCoaControlAccName, advanceCoaSubCoaMainAccName, purAcc, purAccAccName, purAccAccBalTypeAccBalType, purAccAccCurrencyAccCurrencyName, purAccAccDestAccDest, purAccAccDestCompanyTypeDescription, purAccAccFundAccFundCode, purAccAccSubTypeAccSubType, purAccAccTypeAccType, purAccCoaControlAccName, purAccCoaControlAccBalTypeAccBalType, purAccCoaControlAccDestAccDest, purAccCoaControlAccTypeAccType, purAccCoaControlCompTypeDescription, purAccCoaMainAccName, purAccCoaMainAccBalTypeAccBalType, purAccCoaMainAccDestAccDest, purAccCoaMainAccFundAccFundCode, purAccCoaMainAccTypeAccType, purAccCoaMainCoaControlAccName, purAccCoaSubAccName, purAccCoaSubAccBalTypeAccBalType, purAccCoaSubAccDestAccDest, purAccCoaSubAccFundAccFundCode, purAccCoaSubAccTypeAccType, purAccCoaSubCoaControlAccName, purAccCoaSubCoaMainAccName, saleAcc, saleAccAccName, saleAccAccBalTypeAccBalType, saleAccAccCurrencyAccCurrencyName, saleAccAccDestAccDest, saleAccAccDestCompanyTypeDescription, saleAccAccFundAccFundCode, saleAccAccSubTypeAccSubType, saleAccAccTypeAccType, saleAccCoaControlAccName, saleAccCoaControlAccBalTypeAccBalType, saleAccCoaControlAccDestAccDest, saleAccCoaControlAccTypeAccType, saleAccCoaControlCompTypeDescription, saleAccCoaMainAccName, saleAccCoaMainAccBalTypeAccBalType, saleAccCoaMainAccDestAccDest, saleAccCoaMainAccFundAccFundCode, saleAccCoaMainAccTypeAccType, saleAccCoaMainCoaControlAccName, saleAccCoaSubAccName, saleAccCoaSubAccBalTypeAccBalType, saleAccCoaSubAccDestAccDest, saleAccCoaSubAccFundAccFundCode, saleAccCoaSubAccTypeAccType, saleAccCoaSubCoaControlAccName, saleAccCoaSubCoaMainAccName, workinProgressAcc, workinProgressAccAccName, workinProgressAccAccBalTypeAccBalType, workinProgressAccAccCurrencyAccCurrencyName, workinProgressAccAccDestAccDest, workinProgressAccAccDestCompanyTypeDescription, workinProgressAccAccFundAccFundCode, workinProgressAccAccSubTypeAccSubType, workinProgressAccAccTypeAccType, workinProgressAccCoaControlAccName, workinProgressAccCoaControlAccBalTypeAccBalType, workinProgressAccCoaControlAccDestAccDest, workinProgressAccCoaControlAccTypeAccType, workinProgressAccCoaControlCompTypeDescription, workinProgressAccCoaMainAccName, workinProgressAccCoaMainAccBalTypeAccBalType, workinProgressAccCoaMainAccDestAccDest, workinProgressAccCoaMainAccFundAccFundCode, workinProgressAccCoaMainAccTypeAccType, workinProgressAccCoaMainCoaControlAccName, workinProgressAccCoaSubAccName, workinProgressAccCoaSubAccBalTypeAccBalType, workinProgressAccCoaSubAccDestAccDest, workinProgressAccCoaSubAccFundAccFundCode, workinProgressAccCoaSubAccTypeAccType, workinProgressAccCoaSubCoaControlAccName, workinProgressAccCoaSubCoaMainAccName, costofSold, costofSoldAccName, costofSoldAccBalTypeAccBalType, costofSoldAccCurrencyAccCurrencyName, costofSoldAccDestAccDest, costofSoldAccDestCompanyTypeDescription, costofSoldAccFundAccFundCode, costofSoldAccSubTypeAccSubType, costofSoldAccTypeAccType, costofSoldCoaControlAccName, costofSoldCoaControlAccBalTypeAccBalType, costofSoldCoaControlAccDestAccDest, costofSoldCoaControlAccTypeAccType, costofSoldCoaControlCompTypeDescription, costofSoldCoaMainAccName, costofSoldCoaMainAccBalTypeAccBalType, costofSoldCoaMainAccDestAccDest, costofSoldCoaMainAccFundAccFundCode, costofSoldCoaMainAccTypeAccType, costofSoldCoaMainCoaControlAccName, costofSoldCoaSubAccName, costofSoldCoaSubAccBalTypeAccBalType, costofSoldCoaSubAccDestAccDest, costofSoldCoaSubAccFundAccFundCode, costofSoldCoaSubAccTypeAccType, costofSoldCoaSubCoaControlAccName, costofSoldCoaSubCoaMainAccName, oPD_Acc, oPD_AccAccName, oPD_AccAccBalTypeAccBalType, oPD_AccAccCurrencyAccCurrencyName, oPD_AccAccDestAccDest, oPD_AccAccDestCompanyTypeDescription, oPD_AccAccFundAccFundCode, oPD_AccAccSubTypeAccSubType, oPD_AccAccTypeAccType, oPD_AccCoaControlAccName, oPD_AccCoaControlAccBalTypeAccBalType, oPD_AccCoaControlAccDestAccDest, oPD_AccCoaControlAccTypeAccType, oPD_AccCoaControlCompTypeDescription, oPD_AccCoaMainAccName, oPD_AccCoaMainAccBalTypeAccBalType, oPD_AccCoaMainAccDestAccDest, oPD_AccCoaMainAccFundAccFundCode, oPD_AccCoaMainAccTypeAccType, oPD_AccCoaMainCoaControlAccName, oPD_AccCoaSubAccName, oPD_AccCoaSubAccBalTypeAccBalType, oPD_AccCoaSubAccDestAccDest, oPD_AccCoaSubAccFundAccFundCode, oPD_AccCoaSubAccTypeAccType, oPD_AccCoaSubCoaControlAccName, oPD_AccCoaSubCoaMainAccName, advPat_Acc, advPat_AccAccName, advPat_AccAccBalTypeAccBalType, advPat_AccAccCurrencyAccCurrencyName, advPat_AccAccDestAccDest, advPat_AccAccDestCompanyTypeDescription, advPat_AccAccFundAccFundCode, advPat_AccAccSubTypeAccSubType, advPat_AccAccTypeAccType, advPat_AccCoaControlAccName, advPat_AccCoaControlAccBalTypeAccBalType, advPat_AccCoaControlAccDestAccDest, advPat_AccCoaControlAccTypeAccType, advPat_AccCoaControlCompTypeDescription, advPat_AccCoaMainAccName, advPat_AccCoaMainAccBalTypeAccBalType, advPat_AccCoaMainAccDestAccDest, advPat_AccCoaMainAccFundAccFundCode, advPat_AccCoaMainAccTypeAccType, advPat_AccCoaMainCoaControlAccName, advPat_AccCoaSubAccName, advPat_AccCoaSubAccBalTypeAccBalType, advPat_AccCoaSubAccDestAccDest, advPat_AccCoaSubAccFundAccFundCode, advPat_AccCoaSubAccTypeAccType, advPat_AccCoaSubCoaControlAccName, advPat_AccCoaSubCoaMainAccName, investigate_Acc, investigate_AccAccName, investigate_AccAccBalTypeAccBalType, investigate_AccAccCurrencyAccCurrencyName, investigate_AccAccDestAccDest, investigate_AccAccDestCompanyTypeDescription, investigate_AccAccFundAccFundCode, investigate_AccAccSubTypeAccSubType, investigate_AccAccTypeAccType, investigate_AccCoaControlAccName, investigate_AccCoaControlAccBalTypeAccBalType, investigate_AccCoaControlAccDestAccDest, investigate_AccCoaControlAccTypeAccType, investigate_AccCoaControlCompTypeDescription, investigate_AccCoaMainAccName, investigate_AccCoaMainAccBalTypeAccBalType, investigate_AccCoaMainAccDestAccDest, investigate_AccCoaMainAccFundAccFundCode, investigate_AccCoaMainAccTypeAccType, investigate_AccCoaMainCoaControlAccName, investigate_AccCoaSubAccName, investigate_AccCoaSubAccBalTypeAccBalType, investigate_AccCoaSubAccDestAccDest, investigate_AccCoaSubAccFundAccFundCode, investigate_AccCoaSubAccTypeAccType, investigate_AccCoaSubCoaControlAccName, investigate_AccCoaSubCoaMainAccName, vatAcc, vatAccAccName, vatAccAccBalTypeAccBalType, vatAccAccCurrencyAccCurrencyName, vatAccAccDestAccDest, vatAccAccDestCompanyTypeDescription, vatAccAccFundAccFundCode, vatAccAccSubTypeAccSubType, vatAccAccTypeAccType, vatAccCoaControlAccName, vatAccCoaControlAccBalTypeAccBalType, vatAccCoaControlAccDestAccDest, vatAccCoaControlAccTypeAccType, vatAccCoaControlCompTypeDescription, vatAccCoaMainAccName, vatAccCoaMainAccBalTypeAccBalType, vatAccCoaMainAccDestAccDest, vatAccCoaMainAccFundAccFundCode, vatAccCoaMainAccTypeAccType, vatAccCoaMainCoaControlAccName, vatAccCoaSubAccName, vatAccCoaSubAccBalTypeAccBalType, vatAccCoaSubAccDestAccDest, vatAccCoaSubAccFundAccFundCode, vatAccCoaSubAccTypeAccType, vatAccCoaSubCoaControlAccName, vatAccCoaSubCoaMainAccName, sundryDebitors, sundryDebitorsAccName, sundryDebitorsAccBalTypeAccBalType, sundryDebitorsAccCurrencyAccCurrencyName, sundryDebitorsAccDestAccDest, sundryDebitorsAccDestCompanyTypeDescription, sundryDebitorsAccFundAccFundCode, sundryDebitorsAccSubTypeAccSubType, sundryDebitorsAccTypeAccType, sundryDebitorsCoaControlAccName, sundryDebitorsCoaControlAccBalTypeAccBalType, sundryDebitorsCoaControlAccDestAccDest, sundryDebitorsCoaControlAccTypeAccType, sundryDebitorsCoaControlCompTypeDescription, sundryDebitorsCoaMainAccName, sundryDebitorsCoaMainAccBalTypeAccBalType, sundryDebitorsCoaMainAccDestAccDest, sundryDebitorsCoaMainAccFundAccFundCode, sundryDebitorsCoaMainAccTypeAccType, sundryDebitorsCoaMainCoaControlAccName, sundryDebitorsCoaSubAccName, sundryDebitorsCoaSubAccBalTypeAccBalType, sundryDebitorsCoaSubAccDestAccDest, sundryDebitorsCoaSubAccFundAccFundCode, sundryDebitorsCoaSubAccTypeAccType, sundryDebitorsCoaSubCoaControlAccName, sundryDebitorsCoaSubCoaMainAccName, sundryCreditors, sundryCreditorsAccName, sundryCreditorsAccBalTypeAccBalType, sundryCreditorsAccCurrencyAccCurrencyName, sundryCreditorsAccDestAccDest, sundryCreditorsAccDestCompanyTypeDescription, sundryCreditorsAccFundAccFundCode, sundryCreditorsAccSubTypeAccSubType, sundryCreditorsAccTypeAccType, sundryCreditorsCoaControlAccName, sundryCreditorsCoaControlAccBalTypeAccBalType, sundryCreditorsCoaControlAccDestAccDest, sundryCreditorsCoaControlAccTypeAccType, sundryCreditorsCoaControlCompTypeDescription, sundryCreditorsCoaMainAccName, sundryCreditorsCoaMainAccBalTypeAccBalType, sundryCreditorsCoaMainAccDestAccDest, sundryCreditorsCoaMainAccFundAccFundCode, sundryCreditorsCoaMainAccTypeAccType, sundryCreditorsCoaMainCoaControlAccName, sundryCreditorsCoaSubAccName, sundryCreditorsCoaSubAccBalTypeAccBalType, sundryCreditorsCoaSubAccDestAccDest, sundryCreditorsCoaSubAccFundAccFundCode, sundryCreditorsCoaSubAccTypeAccType, sundryCreditorsCoaSubCoaControlAccName, sundryCreditorsCoaSubCoaMainAccName, rawMatAcc, rawMatAccAccName, rawMatAccAccBalTypeAccBalType, rawMatAccAccCurrencyAccCurrencyName, rawMatAccAccDestAccDest, rawMatAccAccDestCompanyTypeDescription, rawMatAccAccFundAccFundCode, rawMatAccAccSubTypeAccSubType, rawMatAccAccTypeAccType, rawMatAccCoaControlAccName, rawMatAccCoaControlAccBalTypeAccBalType, rawMatAccCoaControlAccDestAccDest, rawMatAccCoaControlAccTypeAccType, rawMatAccCoaControlCompTypeDescription, rawMatAccCoaMainAccName, rawMatAccCoaMainAccBalTypeAccBalType, rawMatAccCoaMainAccDestAccDest, rawMatAccCoaMainAccFundAccFundCode, rawMatAccCoaMainAccTypeAccType, rawMatAccCoaMainCoaControlAccName, rawMatAccCoaSubAccName, rawMatAccCoaSubAccBalTypeAccBalType, rawMatAccCoaSubAccDestAccDest, rawMatAccCoaSubAccFundAccFundCode, rawMatAccCoaSubAccTypeAccType, rawMatAccCoaSubCoaControlAccName, rawMatAccCoaSubCoaMainAccName, packMatAcc, packMatAccAccName, packMatAccAccBalTypeAccBalType, packMatAccAccCurrencyAccCurrencyName, packMatAccAccDestAccDest, packMatAccAccDestCompanyTypeDescription, packMatAccAccFundAccFundCode, packMatAccAccSubTypeAccSubType, packMatAccAccTypeAccType, packMatAccCoaControlAccName, packMatAccCoaControlAccBalTypeAccBalType, packMatAccCoaControlAccDestAccDest, packMatAccCoaControlAccTypeAccType, packMatAccCoaControlCompTypeDescription, packMatAccCoaMainAccName, packMatAccCoaMainAccBalTypeAccBalType, packMatAccCoaMainAccDestAccDest, packMatAccCoaMainAccFundAccFundCode, packMatAccCoaMainAccTypeAccType, packMatAccCoaMainCoaControlAccName, packMatAccCoaSubAccName, packMatAccCoaSubAccBalTypeAccBalType, packMatAccCoaSubAccDestAccDest, packMatAccCoaSubAccFundAccFundCode, packMatAccCoaSubAccTypeAccType, packMatAccCoaSubCoaControlAccName, packMatAccCoaSubCoaMainAccName, otherMatAcc, otherMatAccAccName, otherMatAccAccBalTypeAccBalType, otherMatAccAccCurrencyAccCurrencyName, otherMatAccAccDestAccDest, otherMatAccAccDestCompanyTypeDescription, otherMatAccAccFundAccFundCode, otherMatAccAccSubTypeAccSubType, otherMatAccAccTypeAccType, otherMatAccCoaControlAccName, otherMatAccCoaControlAccBalTypeAccBalType, otherMatAccCoaControlAccDestAccDest, otherMatAccCoaControlAccTypeAccType, otherMatAccCoaControlCompTypeDescription, otherMatAccCoaMainAccName, otherMatAccCoaMainAccBalTypeAccBalType, otherMatAccCoaMainAccDestAccDest, otherMatAccCoaMainAccFundAccFundCode, otherMatAccCoaMainAccTypeAccType, otherMatAccCoaMainCoaControlAccName, otherMatAccCoaSubAccName, otherMatAccCoaSubAccBalTypeAccBalType, otherMatAccCoaSubAccDestAccDest, otherMatAccCoaSubAccFundAccFundCode, otherMatAccCoaSubAccTypeAccType, otherMatAccCoaSubCoaControlAccName, otherMatAccCoaSubCoaMainAccName, finishMatAcc, finishMatAccAccName, finishMatAccAccBalTypeAccBalType, finishMatAccAccCurrencyAccCurrencyName, finishMatAccAccDestAccDest, finishMatAccAccDestCompanyTypeDescription, finishMatAccAccFundAccFundCode, finishMatAccAccSubTypeAccSubType, finishMatAccAccTypeAccType, finishMatAccCoaControlAccName, finishMatAccCoaControlAccBalTypeAccBalType, finishMatAccCoaControlAccDestAccDest, finishMatAccCoaControlAccTypeAccType, finishMatAccCoaControlCompTypeDescription, finishMatAccCoaMainAccName, finishMatAccCoaMainAccBalTypeAccBalType, finishMatAccCoaMainAccDestAccDest, finishMatAccCoaMainAccFundAccFundCode, finishMatAccCoaMainAccTypeAccType, finishMatAccCoaMainCoaControlAccName, finishMatAccCoaSubAccName, finishMatAccCoaSubAccBalTypeAccBalType, finishMatAccCoaSubAccDestAccDest, finishMatAccCoaSubAccFundAccFundCode, finishMatAccCoaSubAccTypeAccType, finishMatAccCoaSubCoaControlAccName, finishMatAccCoaSubCoaMainAccName, adminExpAcc, adminExpAccAccName, adminExpAccAccBalTypeAccBalType, adminExpAccAccCurrencyAccCurrencyName, adminExpAccAccDestAccDest, adminExpAccAccDestCompanyTypeDescription, adminExpAccAccFundAccFundCode, adminExpAccAccSubTypeAccSubType, adminExpAccAccTypeAccType, adminExpAccCoaControlAccName, adminExpAccCoaControlAccBalTypeAccBalType, adminExpAccCoaControlAccDestAccDest, adminExpAccCoaControlAccTypeAccType, adminExpAccCoaControlCompTypeDescription, adminExpAccCoaMainAccName, adminExpAccCoaMainAccBalTypeAccBalType, adminExpAccCoaMainAccDestAccDest, adminExpAccCoaMainAccFundAccFundCode, adminExpAccCoaMainAccTypeAccType, adminExpAccCoaMainCoaControlAccName, adminExpAccCoaSubAccName, adminExpAccCoaSubAccBalTypeAccBalType, adminExpAccCoaSubAccDestAccDest, adminExpAccCoaSubAccFundAccFundCode, adminExpAccCoaSubAccTypeAccType, adminExpAccCoaSubCoaControlAccName, adminExpAccCoaSubCoaMainAccName, sellingExpAcc, sellingExpAccAccName, sellingExpAccAccBalTypeAccBalType, sellingExpAccAccCurrencyAccCurrencyName, sellingExpAccAccDestAccDest, sellingExpAccAccDestCompanyTypeDescription, sellingExpAccAccFundAccFundCode, sellingExpAccAccSubTypeAccSubType, sellingExpAccAccTypeAccType, sellingExpAccCoaControlAccName, sellingExpAccCoaControlAccBalTypeAccBalType, sellingExpAccCoaControlAccDestAccDest, sellingExpAccCoaControlAccTypeAccType, sellingExpAccCoaControlCompTypeDescription, sellingExpAccCoaMainAccName, sellingExpAccCoaMainAccBalTypeAccBalType, sellingExpAccCoaMainAccDestAccDest, sellingExpAccCoaMainAccFundAccFundCode, sellingExpAccCoaMainAccTypeAccType, sellingExpAccCoaMainCoaControlAccName, sellingExpAccCoaSubAccName, sellingExpAccCoaSubAccBalTypeAccBalType, sellingExpAccCoaSubAccDestAccDest, sellingExpAccCoaSubAccFundAccFundCode, sellingExpAccCoaSubAccTypeAccType, sellingExpAccCoaSubCoaControlAccName, sellingExpAccCoaSubCoaMainAccName, manuExpAcc, manuExpAccAccName, manuExpAccAccBalTypeAccBalType, manuExpAccAccCurrencyAccCurrencyName, manuExpAccAccDestAccDest, manuExpAccAccDestCompanyTypeDescription, manuExpAccAccFundAccFundCode, manuExpAccAccSubTypeAccSubType, manuExpAccAccTypeAccType, manuExpAccCoaControlAccName, manuExpAccCoaControlAccBalTypeAccBalType, manuExpAccCoaControlAccDestAccDest, manuExpAccCoaControlAccTypeAccType, manuExpAccCoaControlCompTypeDescription, manuExpAccCoaMainAccName, manuExpAccCoaMainAccBalTypeAccBalType, manuExpAccCoaMainAccDestAccDest, manuExpAccCoaMainAccFundAccFundCode, manuExpAccCoaMainAccTypeAccType, manuExpAccCoaMainCoaControlAccName, manuExpAccCoaSubAccName, manuExpAccCoaSubAccBalTypeAccBalType, manuExpAccCoaSubAccDestAccDest, manuExpAccCoaSubAccFundAccFundCode, manuExpAccCoaSubAccTypeAccType, manuExpAccCoaSubCoaControlAccName, manuExpAccCoaSubCoaMainAccName, loanAcc, loanAccAccName, loanAccAccBalTypeAccBalType, loanAccAccCurrencyAccCurrencyName, loanAccAccDestAccDest, loanAccAccDestCompanyTypeDescription, loanAccAccFundAccFundCode, loanAccAccSubTypeAccSubType, loanAccAccTypeAccType, loanAccCoaControlAccName, loanAccCoaControlAccBalTypeAccBalType, loanAccCoaControlAccDestAccDest, loanAccCoaControlAccTypeAccType, loanAccCoaControlCompTypeDescription, loanAccCoaMainAccName, loanAccCoaMainAccBalTypeAccBalType, loanAccCoaMainAccDestAccDest, loanAccCoaMainAccFundAccFundCode, loanAccCoaMainAccTypeAccType, loanAccCoaMainCoaControlAccName, loanAccCoaSubAccName, loanAccCoaSubAccBalTypeAccBalType, loanAccCoaSubAccDestAccDest, loanAccCoaSubAccFundAccFundCode, loanAccCoaSubAccTypeAccType, loanAccCoaSubCoaControlAccName, loanAccCoaSubCoaMainAccName, assetDepAcc, assetDepAccAccName, assetDepAccAccBalTypeAccBalType, assetDepAccAccCurrencyAccCurrencyName, assetDepAccAccDestAccDest, assetDepAccAccDestCompanyTypeDescription, assetDepAccAccFundAccFundCode, assetDepAccAccSubTypeAccSubType, assetDepAccAccTypeAccType, assetDepAccCoaControlAccName, assetDepAccCoaControlAccBalTypeAccBalType, assetDepAccCoaControlAccDestAccDest, assetDepAccCoaControlAccTypeAccType, assetDepAccCoaControlCompTypeDescription, assetDepAccCoaMainAccName, assetDepAccCoaMainAccBalTypeAccBalType, assetDepAccCoaMainAccDestAccDest, assetDepAccCoaMainAccFundAccFundCode, assetDepAccCoaMainAccTypeAccType, assetDepAccCoaMainCoaControlAccName, assetDepAccCoaSubAccName, assetDepAccCoaSubAccBalTypeAccBalType, assetDepAccCoaSubAccDestAccDest, assetDepAccCoaSubAccFundAccFundCode, assetDepAccCoaSubAccTypeAccType, assetDepAccCoaSubCoaControlAccName, assetDepAccCoaSubCoaMainAccName, nonOperateIncAcc, nonOperateIncAccAccName, nonOperateIncAccAccBalTypeAccBalType, nonOperateIncAccAccCurrencyAccCurrencyName, nonOperateIncAccAccDestAccDest, nonOperateIncAccAccDestCompanyTypeDescription, nonOperateIncAccAccFundAccFundCode, nonOperateIncAccAccSubTypeAccSubType, nonOperateIncAccAccTypeAccType, nonOperateIncAccCoaControlAccName, nonOperateIncAccCoaControlAccBalTypeAccBalType, nonOperateIncAccCoaControlAccDestAccDest, nonOperateIncAccCoaControlAccTypeAccType, nonOperateIncAccCoaControlCompTypeDescription, nonOperateIncAccCoaMainAccName, nonOperateIncAccCoaMainAccBalTypeAccBalType, nonOperateIncAccCoaMainAccDestAccDest, nonOperateIncAccCoaMainAccFundAccFundCode, nonOperateIncAccCoaMainAccTypeAccType, nonOperateIncAccCoaMainCoaControlAccName, nonOperateIncAccCoaSubAccName, nonOperateIncAccCoaSubAccBalTypeAccBalType, nonOperateIncAccCoaSubAccDestAccDest, nonOperateIncAccCoaSubAccFundAccFundCode, nonOperateIncAccCoaSubAccTypeAccType, nonOperateIncAccCoaSubCoaControlAccName, nonOperateIncAccCoaSubCoaMainAccName, nonOperateExpAcc, nonOperateExpAccAccName, nonOperateExpAccAccBalTypeAccBalType, nonOperateExpAccAccCurrencyAccCurrencyName, nonOperateExpAccAccDestAccDest, nonOperateExpAccAccDestCompanyTypeDescription, nonOperateExpAccAccFundAccFundCode, nonOperateExpAccAccSubTypeAccSubType, nonOperateExpAccAccTypeAccType, nonOperateExpAccCoaControlAccName, nonOperateExpAccCoaControlAccBalTypeAccBalType, nonOperateExpAccCoaControlAccDestAccDest, nonOperateExpAccCoaControlAccTypeAccType, nonOperateExpAccCoaControlCompTypeDescription, nonOperateExpAccCoaMainAccName, nonOperateExpAccCoaMainAccBalTypeAccBalType, nonOperateExpAccCoaMainAccDestAccDest, nonOperateExpAccCoaMainAccFundAccFundCode, nonOperateExpAccCoaMainAccTypeAccType, nonOperateExpAccCoaMainCoaControlAccName, nonOperateExpAccCoaSubAccName, nonOperateExpAccCoaSubAccBalTypeAccBalType, nonOperateExpAccCoaSubAccDestAccDest, nonOperateExpAccCoaSubAccFundAccFundCode, nonOperateExpAccCoaSubAccTypeAccType, nonOperateExpAccCoaSubCoaControlAccName, nonOperateExpAccCoaSubCoaMainAccName, prevYearPLAcc, prevYearPLAccAccName, prevYearPLAccAccBalTypeAccBalType, prevYearPLAccAccCurrencyAccCurrencyName, prevYearPLAccAccDestAccDest, prevYearPLAccAccDestCompanyTypeDescription, prevYearPLAccAccFundAccFundCode, prevYearPLAccAccSubTypeAccSubType, prevYearPLAccAccTypeAccType, prevYearPLAccCoaControlAccName, prevYearPLAccCoaControlAccBalTypeAccBalType, prevYearPLAccCoaControlAccDestAccDest, prevYearPLAccCoaControlAccTypeAccType, prevYearPLAccCoaControlCompTypeDescription, prevYearPLAccCoaMainAccName, prevYearPLAccCoaMainAccBalTypeAccBalType, prevYearPLAccCoaMainAccDestAccDest, prevYearPLAccCoaMainAccFundAccFundCode, prevYearPLAccCoaMainAccTypeAccType, prevYearPLAccCoaMainCoaControlAccName, prevYearPLAccCoaSubAccName, prevYearPLAccCoaSubAccBalTypeAccBalType, prevYearPLAccCoaSubAccDestAccDest, prevYearPLAccCoaSubAccFundAccFundCode, prevYearPLAccCoaSubAccTypeAccType, prevYearPLAccCoaSubCoaControlAccName, prevYearPLAccCoaSubCoaMainAccName, currYearPLAcc, currYearPLAccAccName, currYearPLAccAccBalTypeAccBalType, currYearPLAccAccCurrencyAccCurrencyName, currYearPLAccAccDestAccDest, currYearPLAccAccDestCompanyTypeDescription, currYearPLAccAccFundAccFundCode, currYearPLAccAccSubTypeAccSubType, currYearPLAccAccTypeAccType, currYearPLAccCoaControlAccName, currYearPLAccCoaControlAccBalTypeAccBalType, currYearPLAccCoaControlAccDestAccDest, currYearPLAccCoaControlAccTypeAccType, currYearPLAccCoaControlCompTypeDescription, currYearPLAccCoaMainAccName, currYearPLAccCoaMainAccBalTypeAccBalType, currYearPLAccCoaMainAccDestAccDest, currYearPLAccCoaMainAccFundAccFundCode, currYearPLAccCoaMainAccTypeAccType, currYearPLAccCoaMainCoaControlAccName, currYearPLAccCoaSubAccName, currYearPLAccCoaSubAccBalTypeAccBalType, currYearPLAccCoaSubAccDestAccDest, currYearPLAccCoaSubAccFundAccFundCode, currYearPLAccCoaSubAccTypeAccType, currYearPLAccCoaSubCoaControlAccName, currYearPLAccCoaSubCoaMainAccName, chequeCCAcc, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("AccFundAccs", dataView, request);
            return page.ToList<MyCompany.Data.Objects.AccFundAccs>();
        }
        
        public List<MyCompany.Data.Objects.AccFundAccs> Select(MyCompany.Data.Objects.AccFundAccs qbe)
        {
            return Select(qbe.AccFundAccsID, qbe.AccFundID, qbe.AccFundAccFundCode, qbe.CashCode, qbe.CashAccName, qbe.CashAccBalTypeAccBalType, qbe.CashAccCurrencyAccCurrencyName, qbe.CashAccDestAccDest, qbe.CashAccDestCompanyTypeDescription, qbe.CashAccFundAccFundCode, qbe.CashAccSubTypeAccSubType, qbe.CashAccTypeAccType, qbe.CashCoaControlAccName, qbe.CashCoaControlAccBalTypeAccBalType, qbe.CashCoaControlAccDestAccDest, qbe.CashCoaControlAccTypeAccType, qbe.CashCoaControlCompTypeDescription, qbe.CashCoaMainAccName, qbe.CashCoaMainAccBalTypeAccBalType, qbe.CashCoaMainAccDestAccDest, qbe.CashCoaMainAccFundAccFundCode, qbe.CashCoaMainAccTypeAccType, qbe.CashCoaMainCoaControlAccName, qbe.CashCoaSubAccName, qbe.CashCoaSubAccBalTypeAccBalType, qbe.CashCoaSubAccDestAccDest, qbe.CashCoaSubAccFundAccFundCode, qbe.CashCoaSubAccTypeAccType, qbe.CashCoaSubCoaControlAccName, qbe.CashCoaSubCoaMainAccName, qbe.BankCode, qbe.BankAccName, qbe.BankAccBalTypeAccBalType, qbe.BankAccCurrencyAccCurrencyName, qbe.BankAccDestAccDest, qbe.BankAccDestCompanyTypeDescription, qbe.BankAccFundAccFundCode, qbe.BankAccSubTypeAccSubType, qbe.BankAccTypeAccType, qbe.BankCoaControlAccName, qbe.BankCoaControlAccBalTypeAccBalType, qbe.BankCoaControlAccDestAccDest, qbe.BankCoaControlAccTypeAccType, qbe.BankCoaControlCompTypeDescription, qbe.BankCoaMainAccName, qbe.BankCoaMainAccBalTypeAccBalType, qbe.BankCoaMainAccDestAccDest, qbe.BankCoaMainAccFundAccFundCode, qbe.BankCoaMainAccTypeAccType, qbe.BankCoaMainCoaControlAccName, qbe.BankCoaSubAccName, qbe.BankCoaSubAccBalTypeAccBalType, qbe.BankCoaSubAccDestAccDest, qbe.BankCoaSubAccFundAccFundCode, qbe.BankCoaSubAccTypeAccType, qbe.BankCoaSubCoaControlAccName, qbe.BankCoaSubCoaMainAccName, qbe.Advance, qbe.AdvanceAccName, qbe.AdvanceAccBalTypeAccBalType, qbe.AdvanceAccCurrencyAccCurrencyName, qbe.AdvanceAccDestAccDest, qbe.AdvanceAccDestCompanyTypeDescription, qbe.AdvanceAccFundAccFundCode, qbe.AdvanceAccSubTypeAccSubType, qbe.AdvanceAccTypeAccType, qbe.AdvanceCoaControlAccName, qbe.AdvanceCoaControlAccBalTypeAccBalType, qbe.AdvanceCoaControlAccDestAccDest, qbe.AdvanceCoaControlAccTypeAccType, qbe.AdvanceCoaControlCompTypeDescription, qbe.AdvanceCoaMainAccName, qbe.AdvanceCoaMainAccBalTypeAccBalType, qbe.AdvanceCoaMainAccDestAccDest, qbe.AdvanceCoaMainAccFundAccFundCode, qbe.AdvanceCoaMainAccTypeAccType, qbe.AdvanceCoaMainCoaControlAccName, qbe.AdvanceCoaSubAccName, qbe.AdvanceCoaSubAccBalTypeAccBalType, qbe.AdvanceCoaSubAccDestAccDest, qbe.AdvanceCoaSubAccFundAccFundCode, qbe.AdvanceCoaSubAccTypeAccType, qbe.AdvanceCoaSubCoaControlAccName, qbe.AdvanceCoaSubCoaMainAccName, qbe.PurAcc, qbe.PurAccAccName, qbe.PurAccAccBalTypeAccBalType, qbe.PurAccAccCurrencyAccCurrencyName, qbe.PurAccAccDestAccDest, qbe.PurAccAccDestCompanyTypeDescription, qbe.PurAccAccFundAccFundCode, qbe.PurAccAccSubTypeAccSubType, qbe.PurAccAccTypeAccType, qbe.PurAccCoaControlAccName, qbe.PurAccCoaControlAccBalTypeAccBalType, qbe.PurAccCoaControlAccDestAccDest, qbe.PurAccCoaControlAccTypeAccType, qbe.PurAccCoaControlCompTypeDescription, qbe.PurAccCoaMainAccName, qbe.PurAccCoaMainAccBalTypeAccBalType, qbe.PurAccCoaMainAccDestAccDest, qbe.PurAccCoaMainAccFundAccFundCode, qbe.PurAccCoaMainAccTypeAccType, qbe.PurAccCoaMainCoaControlAccName, qbe.PurAccCoaSubAccName, qbe.PurAccCoaSubAccBalTypeAccBalType, qbe.PurAccCoaSubAccDestAccDest, qbe.PurAccCoaSubAccFundAccFundCode, qbe.PurAccCoaSubAccTypeAccType, qbe.PurAccCoaSubCoaControlAccName, qbe.PurAccCoaSubCoaMainAccName, qbe.SaleAcc, qbe.SaleAccAccName, qbe.SaleAccAccBalTypeAccBalType, qbe.SaleAccAccCurrencyAccCurrencyName, qbe.SaleAccAccDestAccDest, qbe.SaleAccAccDestCompanyTypeDescription, qbe.SaleAccAccFundAccFundCode, qbe.SaleAccAccSubTypeAccSubType, qbe.SaleAccAccTypeAccType, qbe.SaleAccCoaControlAccName, qbe.SaleAccCoaControlAccBalTypeAccBalType, qbe.SaleAccCoaControlAccDestAccDest, qbe.SaleAccCoaControlAccTypeAccType, qbe.SaleAccCoaControlCompTypeDescription, qbe.SaleAccCoaMainAccName, qbe.SaleAccCoaMainAccBalTypeAccBalType, qbe.SaleAccCoaMainAccDestAccDest, qbe.SaleAccCoaMainAccFundAccFundCode, qbe.SaleAccCoaMainAccTypeAccType, qbe.SaleAccCoaMainCoaControlAccName, qbe.SaleAccCoaSubAccName, qbe.SaleAccCoaSubAccBalTypeAccBalType, qbe.SaleAccCoaSubAccDestAccDest, qbe.SaleAccCoaSubAccFundAccFundCode, qbe.SaleAccCoaSubAccTypeAccType, qbe.SaleAccCoaSubCoaControlAccName, qbe.SaleAccCoaSubCoaMainAccName, qbe.WorkinProgressAcc, qbe.WorkinProgressAccAccName, qbe.WorkinProgressAccAccBalTypeAccBalType, qbe.WorkinProgressAccAccCurrencyAccCurrencyName, qbe.WorkinProgressAccAccDestAccDest, qbe.WorkinProgressAccAccDestCompanyTypeDescription, qbe.WorkinProgressAccAccFundAccFundCode, qbe.WorkinProgressAccAccSubTypeAccSubType, qbe.WorkinProgressAccAccTypeAccType, qbe.WorkinProgressAccCoaControlAccName, qbe.WorkinProgressAccCoaControlAccBalTypeAccBalType, qbe.WorkinProgressAccCoaControlAccDestAccDest, qbe.WorkinProgressAccCoaControlAccTypeAccType, qbe.WorkinProgressAccCoaControlCompTypeDescription, qbe.WorkinProgressAccCoaMainAccName, qbe.WorkinProgressAccCoaMainAccBalTypeAccBalType, qbe.WorkinProgressAccCoaMainAccDestAccDest, qbe.WorkinProgressAccCoaMainAccFundAccFundCode, qbe.WorkinProgressAccCoaMainAccTypeAccType, qbe.WorkinProgressAccCoaMainCoaControlAccName, qbe.WorkinProgressAccCoaSubAccName, qbe.WorkinProgressAccCoaSubAccBalTypeAccBalType, qbe.WorkinProgressAccCoaSubAccDestAccDest, qbe.WorkinProgressAccCoaSubAccFundAccFundCode, qbe.WorkinProgressAccCoaSubAccTypeAccType, qbe.WorkinProgressAccCoaSubCoaControlAccName, qbe.WorkinProgressAccCoaSubCoaMainAccName, qbe.CostofSold, qbe.CostofSoldAccName, qbe.CostofSoldAccBalTypeAccBalType, qbe.CostofSoldAccCurrencyAccCurrencyName, qbe.CostofSoldAccDestAccDest, qbe.CostofSoldAccDestCompanyTypeDescription, qbe.CostofSoldAccFundAccFundCode, qbe.CostofSoldAccSubTypeAccSubType, qbe.CostofSoldAccTypeAccType, qbe.CostofSoldCoaControlAccName, qbe.CostofSoldCoaControlAccBalTypeAccBalType, qbe.CostofSoldCoaControlAccDestAccDest, qbe.CostofSoldCoaControlAccTypeAccType, qbe.CostofSoldCoaControlCompTypeDescription, qbe.CostofSoldCoaMainAccName, qbe.CostofSoldCoaMainAccBalTypeAccBalType, qbe.CostofSoldCoaMainAccDestAccDest, qbe.CostofSoldCoaMainAccFundAccFundCode, qbe.CostofSoldCoaMainAccTypeAccType, qbe.CostofSoldCoaMainCoaControlAccName, qbe.CostofSoldCoaSubAccName, qbe.CostofSoldCoaSubAccBalTypeAccBalType, qbe.CostofSoldCoaSubAccDestAccDest, qbe.CostofSoldCoaSubAccFundAccFundCode, qbe.CostofSoldCoaSubAccTypeAccType, qbe.CostofSoldCoaSubCoaControlAccName, qbe.CostofSoldCoaSubCoaMainAccName, qbe.OPD_Acc, qbe.OPD_AccAccName, qbe.OPD_AccAccBalTypeAccBalType, qbe.OPD_AccAccCurrencyAccCurrencyName, qbe.OPD_AccAccDestAccDest, qbe.OPD_AccAccDestCompanyTypeDescription, qbe.OPD_AccAccFundAccFundCode, qbe.OPD_AccAccSubTypeAccSubType, qbe.OPD_AccAccTypeAccType, qbe.OPD_AccCoaControlAccName, qbe.OPD_AccCoaControlAccBalTypeAccBalType, qbe.OPD_AccCoaControlAccDestAccDest, qbe.OPD_AccCoaControlAccTypeAccType, qbe.OPD_AccCoaControlCompTypeDescription, qbe.OPD_AccCoaMainAccName, qbe.OPD_AccCoaMainAccBalTypeAccBalType, qbe.OPD_AccCoaMainAccDestAccDest, qbe.OPD_AccCoaMainAccFundAccFundCode, qbe.OPD_AccCoaMainAccTypeAccType, qbe.OPD_AccCoaMainCoaControlAccName, qbe.OPD_AccCoaSubAccName, qbe.OPD_AccCoaSubAccBalTypeAccBalType, qbe.OPD_AccCoaSubAccDestAccDest, qbe.OPD_AccCoaSubAccFundAccFundCode, qbe.OPD_AccCoaSubAccTypeAccType, qbe.OPD_AccCoaSubCoaControlAccName, qbe.OPD_AccCoaSubCoaMainAccName, qbe.AdvPat_Acc, qbe.AdvPat_AccAccName, qbe.AdvPat_AccAccBalTypeAccBalType, qbe.AdvPat_AccAccCurrencyAccCurrencyName, qbe.AdvPat_AccAccDestAccDest, qbe.AdvPat_AccAccDestCompanyTypeDescription, qbe.AdvPat_AccAccFundAccFundCode, qbe.AdvPat_AccAccSubTypeAccSubType, qbe.AdvPat_AccAccTypeAccType, qbe.AdvPat_AccCoaControlAccName, qbe.AdvPat_AccCoaControlAccBalTypeAccBalType, qbe.AdvPat_AccCoaControlAccDestAccDest, qbe.AdvPat_AccCoaControlAccTypeAccType, qbe.AdvPat_AccCoaControlCompTypeDescription, qbe.AdvPat_AccCoaMainAccName, qbe.AdvPat_AccCoaMainAccBalTypeAccBalType, qbe.AdvPat_AccCoaMainAccDestAccDest, qbe.AdvPat_AccCoaMainAccFundAccFundCode, qbe.AdvPat_AccCoaMainAccTypeAccType, qbe.AdvPat_AccCoaMainCoaControlAccName, qbe.AdvPat_AccCoaSubAccName, qbe.AdvPat_AccCoaSubAccBalTypeAccBalType, qbe.AdvPat_AccCoaSubAccDestAccDest, qbe.AdvPat_AccCoaSubAccFundAccFundCode, qbe.AdvPat_AccCoaSubAccTypeAccType, qbe.AdvPat_AccCoaSubCoaControlAccName, qbe.AdvPat_AccCoaSubCoaMainAccName, qbe.Investigate_Acc, qbe.Investigate_AccAccName, qbe.Investigate_AccAccBalTypeAccBalType, qbe.Investigate_AccAccCurrencyAccCurrencyName, qbe.Investigate_AccAccDestAccDest, qbe.Investigate_AccAccDestCompanyTypeDescription, qbe.Investigate_AccAccFundAccFundCode, qbe.Investigate_AccAccSubTypeAccSubType, qbe.Investigate_AccAccTypeAccType, qbe.Investigate_AccCoaControlAccName, qbe.Investigate_AccCoaControlAccBalTypeAccBalType, qbe.Investigate_AccCoaControlAccDestAccDest, qbe.Investigate_AccCoaControlAccTypeAccType, qbe.Investigate_AccCoaControlCompTypeDescription, qbe.Investigate_AccCoaMainAccName, qbe.Investigate_AccCoaMainAccBalTypeAccBalType, qbe.Investigate_AccCoaMainAccDestAccDest, qbe.Investigate_AccCoaMainAccFundAccFundCode, qbe.Investigate_AccCoaMainAccTypeAccType, qbe.Investigate_AccCoaMainCoaControlAccName, qbe.Investigate_AccCoaSubAccName, qbe.Investigate_AccCoaSubAccBalTypeAccBalType, qbe.Investigate_AccCoaSubAccDestAccDest, qbe.Investigate_AccCoaSubAccFundAccFundCode, qbe.Investigate_AccCoaSubAccTypeAccType, qbe.Investigate_AccCoaSubCoaControlAccName, qbe.Investigate_AccCoaSubCoaMainAccName, qbe.VatAcc, qbe.VatAccAccName, qbe.VatAccAccBalTypeAccBalType, qbe.VatAccAccCurrencyAccCurrencyName, qbe.VatAccAccDestAccDest, qbe.VatAccAccDestCompanyTypeDescription, qbe.VatAccAccFundAccFundCode, qbe.VatAccAccSubTypeAccSubType, qbe.VatAccAccTypeAccType, qbe.VatAccCoaControlAccName, qbe.VatAccCoaControlAccBalTypeAccBalType, qbe.VatAccCoaControlAccDestAccDest, qbe.VatAccCoaControlAccTypeAccType, qbe.VatAccCoaControlCompTypeDescription, qbe.VatAccCoaMainAccName, qbe.VatAccCoaMainAccBalTypeAccBalType, qbe.VatAccCoaMainAccDestAccDest, qbe.VatAccCoaMainAccFundAccFundCode, qbe.VatAccCoaMainAccTypeAccType, qbe.VatAccCoaMainCoaControlAccName, qbe.VatAccCoaSubAccName, qbe.VatAccCoaSubAccBalTypeAccBalType, qbe.VatAccCoaSubAccDestAccDest, qbe.VatAccCoaSubAccFundAccFundCode, qbe.VatAccCoaSubAccTypeAccType, qbe.VatAccCoaSubCoaControlAccName, qbe.VatAccCoaSubCoaMainAccName, qbe.SundryDebitors, qbe.SundryDebitorsAccName, qbe.SundryDebitorsAccBalTypeAccBalType, qbe.SundryDebitorsAccCurrencyAccCurrencyName, qbe.SundryDebitorsAccDestAccDest, qbe.SundryDebitorsAccDestCompanyTypeDescription, qbe.SundryDebitorsAccFundAccFundCode, qbe.SundryDebitorsAccSubTypeAccSubType, qbe.SundryDebitorsAccTypeAccType, qbe.SundryDebitorsCoaControlAccName, qbe.SundryDebitorsCoaControlAccBalTypeAccBalType, qbe.SundryDebitorsCoaControlAccDestAccDest, qbe.SundryDebitorsCoaControlAccTypeAccType, qbe.SundryDebitorsCoaControlCompTypeDescription, qbe.SundryDebitorsCoaMainAccName, qbe.SundryDebitorsCoaMainAccBalTypeAccBalType, qbe.SundryDebitorsCoaMainAccDestAccDest, qbe.SundryDebitorsCoaMainAccFundAccFundCode, qbe.SundryDebitorsCoaMainAccTypeAccType, qbe.SundryDebitorsCoaMainCoaControlAccName, qbe.SundryDebitorsCoaSubAccName, qbe.SundryDebitorsCoaSubAccBalTypeAccBalType, qbe.SundryDebitorsCoaSubAccDestAccDest, qbe.SundryDebitorsCoaSubAccFundAccFundCode, qbe.SundryDebitorsCoaSubAccTypeAccType, qbe.SundryDebitorsCoaSubCoaControlAccName, qbe.SundryDebitorsCoaSubCoaMainAccName, qbe.SundryCreditors, qbe.SundryCreditorsAccName, qbe.SundryCreditorsAccBalTypeAccBalType, qbe.SundryCreditorsAccCurrencyAccCurrencyName, qbe.SundryCreditorsAccDestAccDest, qbe.SundryCreditorsAccDestCompanyTypeDescription, qbe.SundryCreditorsAccFundAccFundCode, qbe.SundryCreditorsAccSubTypeAccSubType, qbe.SundryCreditorsAccTypeAccType, qbe.SundryCreditorsCoaControlAccName, qbe.SundryCreditorsCoaControlAccBalTypeAccBalType, qbe.SundryCreditorsCoaControlAccDestAccDest, qbe.SundryCreditorsCoaControlAccTypeAccType, qbe.SundryCreditorsCoaControlCompTypeDescription, qbe.SundryCreditorsCoaMainAccName, qbe.SundryCreditorsCoaMainAccBalTypeAccBalType, qbe.SundryCreditorsCoaMainAccDestAccDest, qbe.SundryCreditorsCoaMainAccFundAccFundCode, qbe.SundryCreditorsCoaMainAccTypeAccType, qbe.SundryCreditorsCoaMainCoaControlAccName, qbe.SundryCreditorsCoaSubAccName, qbe.SundryCreditorsCoaSubAccBalTypeAccBalType, qbe.SundryCreditorsCoaSubAccDestAccDest, qbe.SundryCreditorsCoaSubAccFundAccFundCode, qbe.SundryCreditorsCoaSubAccTypeAccType, qbe.SundryCreditorsCoaSubCoaControlAccName, qbe.SundryCreditorsCoaSubCoaMainAccName, qbe.RawMatAcc, qbe.RawMatAccAccName, qbe.RawMatAccAccBalTypeAccBalType, qbe.RawMatAccAccCurrencyAccCurrencyName, qbe.RawMatAccAccDestAccDest, qbe.RawMatAccAccDestCompanyTypeDescription, qbe.RawMatAccAccFundAccFundCode, qbe.RawMatAccAccSubTypeAccSubType, qbe.RawMatAccAccTypeAccType, qbe.RawMatAccCoaControlAccName, qbe.RawMatAccCoaControlAccBalTypeAccBalType, qbe.RawMatAccCoaControlAccDestAccDest, qbe.RawMatAccCoaControlAccTypeAccType, qbe.RawMatAccCoaControlCompTypeDescription, qbe.RawMatAccCoaMainAccName, qbe.RawMatAccCoaMainAccBalTypeAccBalType, qbe.RawMatAccCoaMainAccDestAccDest, qbe.RawMatAccCoaMainAccFundAccFundCode, qbe.RawMatAccCoaMainAccTypeAccType, qbe.RawMatAccCoaMainCoaControlAccName, qbe.RawMatAccCoaSubAccName, qbe.RawMatAccCoaSubAccBalTypeAccBalType, qbe.RawMatAccCoaSubAccDestAccDest, qbe.RawMatAccCoaSubAccFundAccFundCode, qbe.RawMatAccCoaSubAccTypeAccType, qbe.RawMatAccCoaSubCoaControlAccName, qbe.RawMatAccCoaSubCoaMainAccName, qbe.PackMatAcc, qbe.PackMatAccAccName, qbe.PackMatAccAccBalTypeAccBalType, qbe.PackMatAccAccCurrencyAccCurrencyName, qbe.PackMatAccAccDestAccDest, qbe.PackMatAccAccDestCompanyTypeDescription, qbe.PackMatAccAccFundAccFundCode, qbe.PackMatAccAccSubTypeAccSubType, qbe.PackMatAccAccTypeAccType, qbe.PackMatAccCoaControlAccName, qbe.PackMatAccCoaControlAccBalTypeAccBalType, qbe.PackMatAccCoaControlAccDestAccDest, qbe.PackMatAccCoaControlAccTypeAccType, qbe.PackMatAccCoaControlCompTypeDescription, qbe.PackMatAccCoaMainAccName, qbe.PackMatAccCoaMainAccBalTypeAccBalType, qbe.PackMatAccCoaMainAccDestAccDest, qbe.PackMatAccCoaMainAccFundAccFundCode, qbe.PackMatAccCoaMainAccTypeAccType, qbe.PackMatAccCoaMainCoaControlAccName, qbe.PackMatAccCoaSubAccName, qbe.PackMatAccCoaSubAccBalTypeAccBalType, qbe.PackMatAccCoaSubAccDestAccDest, qbe.PackMatAccCoaSubAccFundAccFundCode, qbe.PackMatAccCoaSubAccTypeAccType, qbe.PackMatAccCoaSubCoaControlAccName, qbe.PackMatAccCoaSubCoaMainAccName, qbe.OtherMatAcc, qbe.OtherMatAccAccName, qbe.OtherMatAccAccBalTypeAccBalType, qbe.OtherMatAccAccCurrencyAccCurrencyName, qbe.OtherMatAccAccDestAccDest, qbe.OtherMatAccAccDestCompanyTypeDescription, qbe.OtherMatAccAccFundAccFundCode, qbe.OtherMatAccAccSubTypeAccSubType, qbe.OtherMatAccAccTypeAccType, qbe.OtherMatAccCoaControlAccName, qbe.OtherMatAccCoaControlAccBalTypeAccBalType, qbe.OtherMatAccCoaControlAccDestAccDest, qbe.OtherMatAccCoaControlAccTypeAccType, qbe.OtherMatAccCoaControlCompTypeDescription, qbe.OtherMatAccCoaMainAccName, qbe.OtherMatAccCoaMainAccBalTypeAccBalType, qbe.OtherMatAccCoaMainAccDestAccDest, qbe.OtherMatAccCoaMainAccFundAccFundCode, qbe.OtherMatAccCoaMainAccTypeAccType, qbe.OtherMatAccCoaMainCoaControlAccName, qbe.OtherMatAccCoaSubAccName, qbe.OtherMatAccCoaSubAccBalTypeAccBalType, qbe.OtherMatAccCoaSubAccDestAccDest, qbe.OtherMatAccCoaSubAccFundAccFundCode, qbe.OtherMatAccCoaSubAccTypeAccType, qbe.OtherMatAccCoaSubCoaControlAccName, qbe.OtherMatAccCoaSubCoaMainAccName, qbe.FinishMatAcc, qbe.FinishMatAccAccName, qbe.FinishMatAccAccBalTypeAccBalType, qbe.FinishMatAccAccCurrencyAccCurrencyName, qbe.FinishMatAccAccDestAccDest, qbe.FinishMatAccAccDestCompanyTypeDescription, qbe.FinishMatAccAccFundAccFundCode, qbe.FinishMatAccAccSubTypeAccSubType, qbe.FinishMatAccAccTypeAccType, qbe.FinishMatAccCoaControlAccName, qbe.FinishMatAccCoaControlAccBalTypeAccBalType, qbe.FinishMatAccCoaControlAccDestAccDest, qbe.FinishMatAccCoaControlAccTypeAccType, qbe.FinishMatAccCoaControlCompTypeDescription, qbe.FinishMatAccCoaMainAccName, qbe.FinishMatAccCoaMainAccBalTypeAccBalType, qbe.FinishMatAccCoaMainAccDestAccDest, qbe.FinishMatAccCoaMainAccFundAccFundCode, qbe.FinishMatAccCoaMainAccTypeAccType, qbe.FinishMatAccCoaMainCoaControlAccName, qbe.FinishMatAccCoaSubAccName, qbe.FinishMatAccCoaSubAccBalTypeAccBalType, qbe.FinishMatAccCoaSubAccDestAccDest, qbe.FinishMatAccCoaSubAccFundAccFundCode, qbe.FinishMatAccCoaSubAccTypeAccType, qbe.FinishMatAccCoaSubCoaControlAccName, qbe.FinishMatAccCoaSubCoaMainAccName, qbe.AdminExpAcc, qbe.AdminExpAccAccName, qbe.AdminExpAccAccBalTypeAccBalType, qbe.AdminExpAccAccCurrencyAccCurrencyName, qbe.AdminExpAccAccDestAccDest, qbe.AdminExpAccAccDestCompanyTypeDescription, qbe.AdminExpAccAccFundAccFundCode, qbe.AdminExpAccAccSubTypeAccSubType, qbe.AdminExpAccAccTypeAccType, qbe.AdminExpAccCoaControlAccName, qbe.AdminExpAccCoaControlAccBalTypeAccBalType, qbe.AdminExpAccCoaControlAccDestAccDest, qbe.AdminExpAccCoaControlAccTypeAccType, qbe.AdminExpAccCoaControlCompTypeDescription, qbe.AdminExpAccCoaMainAccName, qbe.AdminExpAccCoaMainAccBalTypeAccBalType, qbe.AdminExpAccCoaMainAccDestAccDest, qbe.AdminExpAccCoaMainAccFundAccFundCode, qbe.AdminExpAccCoaMainAccTypeAccType, qbe.AdminExpAccCoaMainCoaControlAccName, qbe.AdminExpAccCoaSubAccName, qbe.AdminExpAccCoaSubAccBalTypeAccBalType, qbe.AdminExpAccCoaSubAccDestAccDest, qbe.AdminExpAccCoaSubAccFundAccFundCode, qbe.AdminExpAccCoaSubAccTypeAccType, qbe.AdminExpAccCoaSubCoaControlAccName, qbe.AdminExpAccCoaSubCoaMainAccName, qbe.SellingExpAcc, qbe.SellingExpAccAccName, qbe.SellingExpAccAccBalTypeAccBalType, qbe.SellingExpAccAccCurrencyAccCurrencyName, qbe.SellingExpAccAccDestAccDest, qbe.SellingExpAccAccDestCompanyTypeDescription, qbe.SellingExpAccAccFundAccFundCode, qbe.SellingExpAccAccSubTypeAccSubType, qbe.SellingExpAccAccTypeAccType, qbe.SellingExpAccCoaControlAccName, qbe.SellingExpAccCoaControlAccBalTypeAccBalType, qbe.SellingExpAccCoaControlAccDestAccDest, qbe.SellingExpAccCoaControlAccTypeAccType, qbe.SellingExpAccCoaControlCompTypeDescription, qbe.SellingExpAccCoaMainAccName, qbe.SellingExpAccCoaMainAccBalTypeAccBalType, qbe.SellingExpAccCoaMainAccDestAccDest, qbe.SellingExpAccCoaMainAccFundAccFundCode, qbe.SellingExpAccCoaMainAccTypeAccType, qbe.SellingExpAccCoaMainCoaControlAccName, qbe.SellingExpAccCoaSubAccName, qbe.SellingExpAccCoaSubAccBalTypeAccBalType, qbe.SellingExpAccCoaSubAccDestAccDest, qbe.SellingExpAccCoaSubAccFundAccFundCode, qbe.SellingExpAccCoaSubAccTypeAccType, qbe.SellingExpAccCoaSubCoaControlAccName, qbe.SellingExpAccCoaSubCoaMainAccName, qbe.ManuExpAcc, qbe.ManuExpAccAccName, qbe.ManuExpAccAccBalTypeAccBalType, qbe.ManuExpAccAccCurrencyAccCurrencyName, qbe.ManuExpAccAccDestAccDest, qbe.ManuExpAccAccDestCompanyTypeDescription, qbe.ManuExpAccAccFundAccFundCode, qbe.ManuExpAccAccSubTypeAccSubType, qbe.ManuExpAccAccTypeAccType, qbe.ManuExpAccCoaControlAccName, qbe.ManuExpAccCoaControlAccBalTypeAccBalType, qbe.ManuExpAccCoaControlAccDestAccDest, qbe.ManuExpAccCoaControlAccTypeAccType, qbe.ManuExpAccCoaControlCompTypeDescription, qbe.ManuExpAccCoaMainAccName, qbe.ManuExpAccCoaMainAccBalTypeAccBalType, qbe.ManuExpAccCoaMainAccDestAccDest, qbe.ManuExpAccCoaMainAccFundAccFundCode, qbe.ManuExpAccCoaMainAccTypeAccType, qbe.ManuExpAccCoaMainCoaControlAccName, qbe.ManuExpAccCoaSubAccName, qbe.ManuExpAccCoaSubAccBalTypeAccBalType, qbe.ManuExpAccCoaSubAccDestAccDest, qbe.ManuExpAccCoaSubAccFundAccFundCode, qbe.ManuExpAccCoaSubAccTypeAccType, qbe.ManuExpAccCoaSubCoaControlAccName, qbe.ManuExpAccCoaSubCoaMainAccName, qbe.LoanAcc, qbe.LoanAccAccName, qbe.LoanAccAccBalTypeAccBalType, qbe.LoanAccAccCurrencyAccCurrencyName, qbe.LoanAccAccDestAccDest, qbe.LoanAccAccDestCompanyTypeDescription, qbe.LoanAccAccFundAccFundCode, qbe.LoanAccAccSubTypeAccSubType, qbe.LoanAccAccTypeAccType, qbe.LoanAccCoaControlAccName, qbe.LoanAccCoaControlAccBalTypeAccBalType, qbe.LoanAccCoaControlAccDestAccDest, qbe.LoanAccCoaControlAccTypeAccType, qbe.LoanAccCoaControlCompTypeDescription, qbe.LoanAccCoaMainAccName, qbe.LoanAccCoaMainAccBalTypeAccBalType, qbe.LoanAccCoaMainAccDestAccDest, qbe.LoanAccCoaMainAccFundAccFundCode, qbe.LoanAccCoaMainAccTypeAccType, qbe.LoanAccCoaMainCoaControlAccName, qbe.LoanAccCoaSubAccName, qbe.LoanAccCoaSubAccBalTypeAccBalType, qbe.LoanAccCoaSubAccDestAccDest, qbe.LoanAccCoaSubAccFundAccFundCode, qbe.LoanAccCoaSubAccTypeAccType, qbe.LoanAccCoaSubCoaControlAccName, qbe.LoanAccCoaSubCoaMainAccName, qbe.AssetDepAcc, qbe.AssetDepAccAccName, qbe.AssetDepAccAccBalTypeAccBalType, qbe.AssetDepAccAccCurrencyAccCurrencyName, qbe.AssetDepAccAccDestAccDest, qbe.AssetDepAccAccDestCompanyTypeDescription, qbe.AssetDepAccAccFundAccFundCode, qbe.AssetDepAccAccSubTypeAccSubType, qbe.AssetDepAccAccTypeAccType, qbe.AssetDepAccCoaControlAccName, qbe.AssetDepAccCoaControlAccBalTypeAccBalType, qbe.AssetDepAccCoaControlAccDestAccDest, qbe.AssetDepAccCoaControlAccTypeAccType, qbe.AssetDepAccCoaControlCompTypeDescription, qbe.AssetDepAccCoaMainAccName, qbe.AssetDepAccCoaMainAccBalTypeAccBalType, qbe.AssetDepAccCoaMainAccDestAccDest, qbe.AssetDepAccCoaMainAccFundAccFundCode, qbe.AssetDepAccCoaMainAccTypeAccType, qbe.AssetDepAccCoaMainCoaControlAccName, qbe.AssetDepAccCoaSubAccName, qbe.AssetDepAccCoaSubAccBalTypeAccBalType, qbe.AssetDepAccCoaSubAccDestAccDest, qbe.AssetDepAccCoaSubAccFundAccFundCode, qbe.AssetDepAccCoaSubAccTypeAccType, qbe.AssetDepAccCoaSubCoaControlAccName, qbe.AssetDepAccCoaSubCoaMainAccName, qbe.NonOperateIncAcc, qbe.NonOperateIncAccAccName, qbe.NonOperateIncAccAccBalTypeAccBalType, qbe.NonOperateIncAccAccCurrencyAccCurrencyName, qbe.NonOperateIncAccAccDestAccDest, qbe.NonOperateIncAccAccDestCompanyTypeDescription, qbe.NonOperateIncAccAccFundAccFundCode, qbe.NonOperateIncAccAccSubTypeAccSubType, qbe.NonOperateIncAccAccTypeAccType, qbe.NonOperateIncAccCoaControlAccName, qbe.NonOperateIncAccCoaControlAccBalTypeAccBalType, qbe.NonOperateIncAccCoaControlAccDestAccDest, qbe.NonOperateIncAccCoaControlAccTypeAccType, qbe.NonOperateIncAccCoaControlCompTypeDescription, qbe.NonOperateIncAccCoaMainAccName, qbe.NonOperateIncAccCoaMainAccBalTypeAccBalType, qbe.NonOperateIncAccCoaMainAccDestAccDest, qbe.NonOperateIncAccCoaMainAccFundAccFundCode, qbe.NonOperateIncAccCoaMainAccTypeAccType, qbe.NonOperateIncAccCoaMainCoaControlAccName, qbe.NonOperateIncAccCoaSubAccName, qbe.NonOperateIncAccCoaSubAccBalTypeAccBalType, qbe.NonOperateIncAccCoaSubAccDestAccDest, qbe.NonOperateIncAccCoaSubAccFundAccFundCode, qbe.NonOperateIncAccCoaSubAccTypeAccType, qbe.NonOperateIncAccCoaSubCoaControlAccName, qbe.NonOperateIncAccCoaSubCoaMainAccName, qbe.NonOperateExpAcc, qbe.NonOperateExpAccAccName, qbe.NonOperateExpAccAccBalTypeAccBalType, qbe.NonOperateExpAccAccCurrencyAccCurrencyName, qbe.NonOperateExpAccAccDestAccDest, qbe.NonOperateExpAccAccDestCompanyTypeDescription, qbe.NonOperateExpAccAccFundAccFundCode, qbe.NonOperateExpAccAccSubTypeAccSubType, qbe.NonOperateExpAccAccTypeAccType, qbe.NonOperateExpAccCoaControlAccName, qbe.NonOperateExpAccCoaControlAccBalTypeAccBalType, qbe.NonOperateExpAccCoaControlAccDestAccDest, qbe.NonOperateExpAccCoaControlAccTypeAccType, qbe.NonOperateExpAccCoaControlCompTypeDescription, qbe.NonOperateExpAccCoaMainAccName, qbe.NonOperateExpAccCoaMainAccBalTypeAccBalType, qbe.NonOperateExpAccCoaMainAccDestAccDest, qbe.NonOperateExpAccCoaMainAccFundAccFundCode, qbe.NonOperateExpAccCoaMainAccTypeAccType, qbe.NonOperateExpAccCoaMainCoaControlAccName, qbe.NonOperateExpAccCoaSubAccName, qbe.NonOperateExpAccCoaSubAccBalTypeAccBalType, qbe.NonOperateExpAccCoaSubAccDestAccDest, qbe.NonOperateExpAccCoaSubAccFundAccFundCode, qbe.NonOperateExpAccCoaSubAccTypeAccType, qbe.NonOperateExpAccCoaSubCoaControlAccName, qbe.NonOperateExpAccCoaSubCoaMainAccName, qbe.PrevYearPLAcc, qbe.PrevYearPLAccAccName, qbe.PrevYearPLAccAccBalTypeAccBalType, qbe.PrevYearPLAccAccCurrencyAccCurrencyName, qbe.PrevYearPLAccAccDestAccDest, qbe.PrevYearPLAccAccDestCompanyTypeDescription, qbe.PrevYearPLAccAccFundAccFundCode, qbe.PrevYearPLAccAccSubTypeAccSubType, qbe.PrevYearPLAccAccTypeAccType, qbe.PrevYearPLAccCoaControlAccName, qbe.PrevYearPLAccCoaControlAccBalTypeAccBalType, qbe.PrevYearPLAccCoaControlAccDestAccDest, qbe.PrevYearPLAccCoaControlAccTypeAccType, qbe.PrevYearPLAccCoaControlCompTypeDescription, qbe.PrevYearPLAccCoaMainAccName, qbe.PrevYearPLAccCoaMainAccBalTypeAccBalType, qbe.PrevYearPLAccCoaMainAccDestAccDest, qbe.PrevYearPLAccCoaMainAccFundAccFundCode, qbe.PrevYearPLAccCoaMainAccTypeAccType, qbe.PrevYearPLAccCoaMainCoaControlAccName, qbe.PrevYearPLAccCoaSubAccName, qbe.PrevYearPLAccCoaSubAccBalTypeAccBalType, qbe.PrevYearPLAccCoaSubAccDestAccDest, qbe.PrevYearPLAccCoaSubAccFundAccFundCode, qbe.PrevYearPLAccCoaSubAccTypeAccType, qbe.PrevYearPLAccCoaSubCoaControlAccName, qbe.PrevYearPLAccCoaSubCoaMainAccName, qbe.CurrYearPLAcc, qbe.CurrYearPLAccAccName, qbe.CurrYearPLAccAccBalTypeAccBalType, qbe.CurrYearPLAccAccCurrencyAccCurrencyName, qbe.CurrYearPLAccAccDestAccDest, qbe.CurrYearPLAccAccDestCompanyTypeDescription, qbe.CurrYearPLAccAccFundAccFundCode, qbe.CurrYearPLAccAccSubTypeAccSubType, qbe.CurrYearPLAccAccTypeAccType, qbe.CurrYearPLAccCoaControlAccName, qbe.CurrYearPLAccCoaControlAccBalTypeAccBalType, qbe.CurrYearPLAccCoaControlAccDestAccDest, qbe.CurrYearPLAccCoaControlAccTypeAccType, qbe.CurrYearPLAccCoaControlCompTypeDescription, qbe.CurrYearPLAccCoaMainAccName, qbe.CurrYearPLAccCoaMainAccBalTypeAccBalType, qbe.CurrYearPLAccCoaMainAccDestAccDest, qbe.CurrYearPLAccCoaMainAccFundAccFundCode, qbe.CurrYearPLAccCoaMainAccTypeAccType, qbe.CurrYearPLAccCoaMainCoaControlAccName, qbe.CurrYearPLAccCoaSubAccName, qbe.CurrYearPLAccCoaSubAccBalTypeAccBalType, qbe.CurrYearPLAccCoaSubAccDestAccDest, qbe.CurrYearPLAccCoaSubAccFundAccFundCode, qbe.CurrYearPLAccCoaSubAccTypeAccType, qbe.CurrYearPLAccCoaSubCoaControlAccName, qbe.CurrYearPLAccCoaSubCoaMainAccName, qbe.ChequeCCAcc);
        }
        
        public int SelectCount(
                    int? accFundAccsID, 
                    int? accFundID, 
                    string accFundAccFundCode, 
                    int? cashCode, 
                    string cashAccName, 
                    string cashAccBalTypeAccBalType, 
                    string cashAccCurrencyAccCurrencyName, 
                    string cashAccDestAccDest, 
                    string cashAccDestCompanyTypeDescription, 
                    string cashAccFundAccFundCode, 
                    string cashAccSubTypeAccSubType, 
                    string cashAccTypeAccType, 
                    string cashCoaControlAccName, 
                    string cashCoaControlAccBalTypeAccBalType, 
                    string cashCoaControlAccDestAccDest, 
                    string cashCoaControlAccTypeAccType, 
                    string cashCoaControlCompTypeDescription, 
                    string cashCoaMainAccName, 
                    string cashCoaMainAccBalTypeAccBalType, 
                    string cashCoaMainAccDestAccDest, 
                    string cashCoaMainAccFundAccFundCode, 
                    string cashCoaMainAccTypeAccType, 
                    string cashCoaMainCoaControlAccName, 
                    string cashCoaSubAccName, 
                    string cashCoaSubAccBalTypeAccBalType, 
                    string cashCoaSubAccDestAccDest, 
                    string cashCoaSubAccFundAccFundCode, 
                    string cashCoaSubAccTypeAccType, 
                    string cashCoaSubCoaControlAccName, 
                    string cashCoaSubCoaMainAccName, 
                    int? bankCode, 
                    string bankAccName, 
                    string bankAccBalTypeAccBalType, 
                    string bankAccCurrencyAccCurrencyName, 
                    string bankAccDestAccDest, 
                    string bankAccDestCompanyTypeDescription, 
                    string bankAccFundAccFundCode, 
                    string bankAccSubTypeAccSubType, 
                    string bankAccTypeAccType, 
                    string bankCoaControlAccName, 
                    string bankCoaControlAccBalTypeAccBalType, 
                    string bankCoaControlAccDestAccDest, 
                    string bankCoaControlAccTypeAccType, 
                    string bankCoaControlCompTypeDescription, 
                    string bankCoaMainAccName, 
                    string bankCoaMainAccBalTypeAccBalType, 
                    string bankCoaMainAccDestAccDest, 
                    string bankCoaMainAccFundAccFundCode, 
                    string bankCoaMainAccTypeAccType, 
                    string bankCoaMainCoaControlAccName, 
                    string bankCoaSubAccName, 
                    string bankCoaSubAccBalTypeAccBalType, 
                    string bankCoaSubAccDestAccDest, 
                    string bankCoaSubAccFundAccFundCode, 
                    string bankCoaSubAccTypeAccType, 
                    string bankCoaSubCoaControlAccName, 
                    string bankCoaSubCoaMainAccName, 
                    int? advance, 
                    string advanceAccName, 
                    string advanceAccBalTypeAccBalType, 
                    string advanceAccCurrencyAccCurrencyName, 
                    string advanceAccDestAccDest, 
                    string advanceAccDestCompanyTypeDescription, 
                    string advanceAccFundAccFundCode, 
                    string advanceAccSubTypeAccSubType, 
                    string advanceAccTypeAccType, 
                    string advanceCoaControlAccName, 
                    string advanceCoaControlAccBalTypeAccBalType, 
                    string advanceCoaControlAccDestAccDest, 
                    string advanceCoaControlAccTypeAccType, 
                    string advanceCoaControlCompTypeDescription, 
                    string advanceCoaMainAccName, 
                    string advanceCoaMainAccBalTypeAccBalType, 
                    string advanceCoaMainAccDestAccDest, 
                    string advanceCoaMainAccFundAccFundCode, 
                    string advanceCoaMainAccTypeAccType, 
                    string advanceCoaMainCoaControlAccName, 
                    string advanceCoaSubAccName, 
                    string advanceCoaSubAccBalTypeAccBalType, 
                    string advanceCoaSubAccDestAccDest, 
                    string advanceCoaSubAccFundAccFundCode, 
                    string advanceCoaSubAccTypeAccType, 
                    string advanceCoaSubCoaControlAccName, 
                    string advanceCoaSubCoaMainAccName, 
                    int? purAcc, 
                    string purAccAccName, 
                    string purAccAccBalTypeAccBalType, 
                    string purAccAccCurrencyAccCurrencyName, 
                    string purAccAccDestAccDest, 
                    string purAccAccDestCompanyTypeDescription, 
                    string purAccAccFundAccFundCode, 
                    string purAccAccSubTypeAccSubType, 
                    string purAccAccTypeAccType, 
                    string purAccCoaControlAccName, 
                    string purAccCoaControlAccBalTypeAccBalType, 
                    string purAccCoaControlAccDestAccDest, 
                    string purAccCoaControlAccTypeAccType, 
                    string purAccCoaControlCompTypeDescription, 
                    string purAccCoaMainAccName, 
                    string purAccCoaMainAccBalTypeAccBalType, 
                    string purAccCoaMainAccDestAccDest, 
                    string purAccCoaMainAccFundAccFundCode, 
                    string purAccCoaMainAccTypeAccType, 
                    string purAccCoaMainCoaControlAccName, 
                    string purAccCoaSubAccName, 
                    string purAccCoaSubAccBalTypeAccBalType, 
                    string purAccCoaSubAccDestAccDest, 
                    string purAccCoaSubAccFundAccFundCode, 
                    string purAccCoaSubAccTypeAccType, 
                    string purAccCoaSubCoaControlAccName, 
                    string purAccCoaSubCoaMainAccName, 
                    int? saleAcc, 
                    string saleAccAccName, 
                    string saleAccAccBalTypeAccBalType, 
                    string saleAccAccCurrencyAccCurrencyName, 
                    string saleAccAccDestAccDest, 
                    string saleAccAccDestCompanyTypeDescription, 
                    string saleAccAccFundAccFundCode, 
                    string saleAccAccSubTypeAccSubType, 
                    string saleAccAccTypeAccType, 
                    string saleAccCoaControlAccName, 
                    string saleAccCoaControlAccBalTypeAccBalType, 
                    string saleAccCoaControlAccDestAccDest, 
                    string saleAccCoaControlAccTypeAccType, 
                    string saleAccCoaControlCompTypeDescription, 
                    string saleAccCoaMainAccName, 
                    string saleAccCoaMainAccBalTypeAccBalType, 
                    string saleAccCoaMainAccDestAccDest, 
                    string saleAccCoaMainAccFundAccFundCode, 
                    string saleAccCoaMainAccTypeAccType, 
                    string saleAccCoaMainCoaControlAccName, 
                    string saleAccCoaSubAccName, 
                    string saleAccCoaSubAccBalTypeAccBalType, 
                    string saleAccCoaSubAccDestAccDest, 
                    string saleAccCoaSubAccFundAccFundCode, 
                    string saleAccCoaSubAccTypeAccType, 
                    string saleAccCoaSubCoaControlAccName, 
                    string saleAccCoaSubCoaMainAccName, 
                    int? workinProgressAcc, 
                    string workinProgressAccAccName, 
                    string workinProgressAccAccBalTypeAccBalType, 
                    string workinProgressAccAccCurrencyAccCurrencyName, 
                    string workinProgressAccAccDestAccDest, 
                    string workinProgressAccAccDestCompanyTypeDescription, 
                    string workinProgressAccAccFundAccFundCode, 
                    string workinProgressAccAccSubTypeAccSubType, 
                    string workinProgressAccAccTypeAccType, 
                    string workinProgressAccCoaControlAccName, 
                    string workinProgressAccCoaControlAccBalTypeAccBalType, 
                    string workinProgressAccCoaControlAccDestAccDest, 
                    string workinProgressAccCoaControlAccTypeAccType, 
                    string workinProgressAccCoaControlCompTypeDescription, 
                    string workinProgressAccCoaMainAccName, 
                    string workinProgressAccCoaMainAccBalTypeAccBalType, 
                    string workinProgressAccCoaMainAccDestAccDest, 
                    string workinProgressAccCoaMainAccFundAccFundCode, 
                    string workinProgressAccCoaMainAccTypeAccType, 
                    string workinProgressAccCoaMainCoaControlAccName, 
                    string workinProgressAccCoaSubAccName, 
                    string workinProgressAccCoaSubAccBalTypeAccBalType, 
                    string workinProgressAccCoaSubAccDestAccDest, 
                    string workinProgressAccCoaSubAccFundAccFundCode, 
                    string workinProgressAccCoaSubAccTypeAccType, 
                    string workinProgressAccCoaSubCoaControlAccName, 
                    string workinProgressAccCoaSubCoaMainAccName, 
                    int? costofSold, 
                    string costofSoldAccName, 
                    string costofSoldAccBalTypeAccBalType, 
                    string costofSoldAccCurrencyAccCurrencyName, 
                    string costofSoldAccDestAccDest, 
                    string costofSoldAccDestCompanyTypeDescription, 
                    string costofSoldAccFundAccFundCode, 
                    string costofSoldAccSubTypeAccSubType, 
                    string costofSoldAccTypeAccType, 
                    string costofSoldCoaControlAccName, 
                    string costofSoldCoaControlAccBalTypeAccBalType, 
                    string costofSoldCoaControlAccDestAccDest, 
                    string costofSoldCoaControlAccTypeAccType, 
                    string costofSoldCoaControlCompTypeDescription, 
                    string costofSoldCoaMainAccName, 
                    string costofSoldCoaMainAccBalTypeAccBalType, 
                    string costofSoldCoaMainAccDestAccDest, 
                    string costofSoldCoaMainAccFundAccFundCode, 
                    string costofSoldCoaMainAccTypeAccType, 
                    string costofSoldCoaMainCoaControlAccName, 
                    string costofSoldCoaSubAccName, 
                    string costofSoldCoaSubAccBalTypeAccBalType, 
                    string costofSoldCoaSubAccDestAccDest, 
                    string costofSoldCoaSubAccFundAccFundCode, 
                    string costofSoldCoaSubAccTypeAccType, 
                    string costofSoldCoaSubCoaControlAccName, 
                    string costofSoldCoaSubCoaMainAccName, 
                    int? oPD_Acc, 
                    string oPD_AccAccName, 
                    string oPD_AccAccBalTypeAccBalType, 
                    string oPD_AccAccCurrencyAccCurrencyName, 
                    string oPD_AccAccDestAccDest, 
                    string oPD_AccAccDestCompanyTypeDescription, 
                    string oPD_AccAccFundAccFundCode, 
                    string oPD_AccAccSubTypeAccSubType, 
                    string oPD_AccAccTypeAccType, 
                    string oPD_AccCoaControlAccName, 
                    string oPD_AccCoaControlAccBalTypeAccBalType, 
                    string oPD_AccCoaControlAccDestAccDest, 
                    string oPD_AccCoaControlAccTypeAccType, 
                    string oPD_AccCoaControlCompTypeDescription, 
                    string oPD_AccCoaMainAccName, 
                    string oPD_AccCoaMainAccBalTypeAccBalType, 
                    string oPD_AccCoaMainAccDestAccDest, 
                    string oPD_AccCoaMainAccFundAccFundCode, 
                    string oPD_AccCoaMainAccTypeAccType, 
                    string oPD_AccCoaMainCoaControlAccName, 
                    string oPD_AccCoaSubAccName, 
                    string oPD_AccCoaSubAccBalTypeAccBalType, 
                    string oPD_AccCoaSubAccDestAccDest, 
                    string oPD_AccCoaSubAccFundAccFundCode, 
                    string oPD_AccCoaSubAccTypeAccType, 
                    string oPD_AccCoaSubCoaControlAccName, 
                    string oPD_AccCoaSubCoaMainAccName, 
                    int? advPat_Acc, 
                    string advPat_AccAccName, 
                    string advPat_AccAccBalTypeAccBalType, 
                    string advPat_AccAccCurrencyAccCurrencyName, 
                    string advPat_AccAccDestAccDest, 
                    string advPat_AccAccDestCompanyTypeDescription, 
                    string advPat_AccAccFundAccFundCode, 
                    string advPat_AccAccSubTypeAccSubType, 
                    string advPat_AccAccTypeAccType, 
                    string advPat_AccCoaControlAccName, 
                    string advPat_AccCoaControlAccBalTypeAccBalType, 
                    string advPat_AccCoaControlAccDestAccDest, 
                    string advPat_AccCoaControlAccTypeAccType, 
                    string advPat_AccCoaControlCompTypeDescription, 
                    string advPat_AccCoaMainAccName, 
                    string advPat_AccCoaMainAccBalTypeAccBalType, 
                    string advPat_AccCoaMainAccDestAccDest, 
                    string advPat_AccCoaMainAccFundAccFundCode, 
                    string advPat_AccCoaMainAccTypeAccType, 
                    string advPat_AccCoaMainCoaControlAccName, 
                    string advPat_AccCoaSubAccName, 
                    string advPat_AccCoaSubAccBalTypeAccBalType, 
                    string advPat_AccCoaSubAccDestAccDest, 
                    string advPat_AccCoaSubAccFundAccFundCode, 
                    string advPat_AccCoaSubAccTypeAccType, 
                    string advPat_AccCoaSubCoaControlAccName, 
                    string advPat_AccCoaSubCoaMainAccName, 
                    int? investigate_Acc, 
                    string investigate_AccAccName, 
                    string investigate_AccAccBalTypeAccBalType, 
                    string investigate_AccAccCurrencyAccCurrencyName, 
                    string investigate_AccAccDestAccDest, 
                    string investigate_AccAccDestCompanyTypeDescription, 
                    string investigate_AccAccFundAccFundCode, 
                    string investigate_AccAccSubTypeAccSubType, 
                    string investigate_AccAccTypeAccType, 
                    string investigate_AccCoaControlAccName, 
                    string investigate_AccCoaControlAccBalTypeAccBalType, 
                    string investigate_AccCoaControlAccDestAccDest, 
                    string investigate_AccCoaControlAccTypeAccType, 
                    string investigate_AccCoaControlCompTypeDescription, 
                    string investigate_AccCoaMainAccName, 
                    string investigate_AccCoaMainAccBalTypeAccBalType, 
                    string investigate_AccCoaMainAccDestAccDest, 
                    string investigate_AccCoaMainAccFundAccFundCode, 
                    string investigate_AccCoaMainAccTypeAccType, 
                    string investigate_AccCoaMainCoaControlAccName, 
                    string investigate_AccCoaSubAccName, 
                    string investigate_AccCoaSubAccBalTypeAccBalType, 
                    string investigate_AccCoaSubAccDestAccDest, 
                    string investigate_AccCoaSubAccFundAccFundCode, 
                    string investigate_AccCoaSubAccTypeAccType, 
                    string investigate_AccCoaSubCoaControlAccName, 
                    string investigate_AccCoaSubCoaMainAccName, 
                    int? vatAcc, 
                    string vatAccAccName, 
                    string vatAccAccBalTypeAccBalType, 
                    string vatAccAccCurrencyAccCurrencyName, 
                    string vatAccAccDestAccDest, 
                    string vatAccAccDestCompanyTypeDescription, 
                    string vatAccAccFundAccFundCode, 
                    string vatAccAccSubTypeAccSubType, 
                    string vatAccAccTypeAccType, 
                    string vatAccCoaControlAccName, 
                    string vatAccCoaControlAccBalTypeAccBalType, 
                    string vatAccCoaControlAccDestAccDest, 
                    string vatAccCoaControlAccTypeAccType, 
                    string vatAccCoaControlCompTypeDescription, 
                    string vatAccCoaMainAccName, 
                    string vatAccCoaMainAccBalTypeAccBalType, 
                    string vatAccCoaMainAccDestAccDest, 
                    string vatAccCoaMainAccFundAccFundCode, 
                    string vatAccCoaMainAccTypeAccType, 
                    string vatAccCoaMainCoaControlAccName, 
                    string vatAccCoaSubAccName, 
                    string vatAccCoaSubAccBalTypeAccBalType, 
                    string vatAccCoaSubAccDestAccDest, 
                    string vatAccCoaSubAccFundAccFundCode, 
                    string vatAccCoaSubAccTypeAccType, 
                    string vatAccCoaSubCoaControlAccName, 
                    string vatAccCoaSubCoaMainAccName, 
                    int? sundryDebitors, 
                    string sundryDebitorsAccName, 
                    string sundryDebitorsAccBalTypeAccBalType, 
                    string sundryDebitorsAccCurrencyAccCurrencyName, 
                    string sundryDebitorsAccDestAccDest, 
                    string sundryDebitorsAccDestCompanyTypeDescription, 
                    string sundryDebitorsAccFundAccFundCode, 
                    string sundryDebitorsAccSubTypeAccSubType, 
                    string sundryDebitorsAccTypeAccType, 
                    string sundryDebitorsCoaControlAccName, 
                    string sundryDebitorsCoaControlAccBalTypeAccBalType, 
                    string sundryDebitorsCoaControlAccDestAccDest, 
                    string sundryDebitorsCoaControlAccTypeAccType, 
                    string sundryDebitorsCoaControlCompTypeDescription, 
                    string sundryDebitorsCoaMainAccName, 
                    string sundryDebitorsCoaMainAccBalTypeAccBalType, 
                    string sundryDebitorsCoaMainAccDestAccDest, 
                    string sundryDebitorsCoaMainAccFundAccFundCode, 
                    string sundryDebitorsCoaMainAccTypeAccType, 
                    string sundryDebitorsCoaMainCoaControlAccName, 
                    string sundryDebitorsCoaSubAccName, 
                    string sundryDebitorsCoaSubAccBalTypeAccBalType, 
                    string sundryDebitorsCoaSubAccDestAccDest, 
                    string sundryDebitorsCoaSubAccFundAccFundCode, 
                    string sundryDebitorsCoaSubAccTypeAccType, 
                    string sundryDebitorsCoaSubCoaControlAccName, 
                    string sundryDebitorsCoaSubCoaMainAccName, 
                    int? sundryCreditors, 
                    string sundryCreditorsAccName, 
                    string sundryCreditorsAccBalTypeAccBalType, 
                    string sundryCreditorsAccCurrencyAccCurrencyName, 
                    string sundryCreditorsAccDestAccDest, 
                    string sundryCreditorsAccDestCompanyTypeDescription, 
                    string sundryCreditorsAccFundAccFundCode, 
                    string sundryCreditorsAccSubTypeAccSubType, 
                    string sundryCreditorsAccTypeAccType, 
                    string sundryCreditorsCoaControlAccName, 
                    string sundryCreditorsCoaControlAccBalTypeAccBalType, 
                    string sundryCreditorsCoaControlAccDestAccDest, 
                    string sundryCreditorsCoaControlAccTypeAccType, 
                    string sundryCreditorsCoaControlCompTypeDescription, 
                    string sundryCreditorsCoaMainAccName, 
                    string sundryCreditorsCoaMainAccBalTypeAccBalType, 
                    string sundryCreditorsCoaMainAccDestAccDest, 
                    string sundryCreditorsCoaMainAccFundAccFundCode, 
                    string sundryCreditorsCoaMainAccTypeAccType, 
                    string sundryCreditorsCoaMainCoaControlAccName, 
                    string sundryCreditorsCoaSubAccName, 
                    string sundryCreditorsCoaSubAccBalTypeAccBalType, 
                    string sundryCreditorsCoaSubAccDestAccDest, 
                    string sundryCreditorsCoaSubAccFundAccFundCode, 
                    string sundryCreditorsCoaSubAccTypeAccType, 
                    string sundryCreditorsCoaSubCoaControlAccName, 
                    string sundryCreditorsCoaSubCoaMainAccName, 
                    int? rawMatAcc, 
                    string rawMatAccAccName, 
                    string rawMatAccAccBalTypeAccBalType, 
                    string rawMatAccAccCurrencyAccCurrencyName, 
                    string rawMatAccAccDestAccDest, 
                    string rawMatAccAccDestCompanyTypeDescription, 
                    string rawMatAccAccFundAccFundCode, 
                    string rawMatAccAccSubTypeAccSubType, 
                    string rawMatAccAccTypeAccType, 
                    string rawMatAccCoaControlAccName, 
                    string rawMatAccCoaControlAccBalTypeAccBalType, 
                    string rawMatAccCoaControlAccDestAccDest, 
                    string rawMatAccCoaControlAccTypeAccType, 
                    string rawMatAccCoaControlCompTypeDescription, 
                    string rawMatAccCoaMainAccName, 
                    string rawMatAccCoaMainAccBalTypeAccBalType, 
                    string rawMatAccCoaMainAccDestAccDest, 
                    string rawMatAccCoaMainAccFundAccFundCode, 
                    string rawMatAccCoaMainAccTypeAccType, 
                    string rawMatAccCoaMainCoaControlAccName, 
                    string rawMatAccCoaSubAccName, 
                    string rawMatAccCoaSubAccBalTypeAccBalType, 
                    string rawMatAccCoaSubAccDestAccDest, 
                    string rawMatAccCoaSubAccFundAccFundCode, 
                    string rawMatAccCoaSubAccTypeAccType, 
                    string rawMatAccCoaSubCoaControlAccName, 
                    string rawMatAccCoaSubCoaMainAccName, 
                    int? packMatAcc, 
                    string packMatAccAccName, 
                    string packMatAccAccBalTypeAccBalType, 
                    string packMatAccAccCurrencyAccCurrencyName, 
                    string packMatAccAccDestAccDest, 
                    string packMatAccAccDestCompanyTypeDescription, 
                    string packMatAccAccFundAccFundCode, 
                    string packMatAccAccSubTypeAccSubType, 
                    string packMatAccAccTypeAccType, 
                    string packMatAccCoaControlAccName, 
                    string packMatAccCoaControlAccBalTypeAccBalType, 
                    string packMatAccCoaControlAccDestAccDest, 
                    string packMatAccCoaControlAccTypeAccType, 
                    string packMatAccCoaControlCompTypeDescription, 
                    string packMatAccCoaMainAccName, 
                    string packMatAccCoaMainAccBalTypeAccBalType, 
                    string packMatAccCoaMainAccDestAccDest, 
                    string packMatAccCoaMainAccFundAccFundCode, 
                    string packMatAccCoaMainAccTypeAccType, 
                    string packMatAccCoaMainCoaControlAccName, 
                    string packMatAccCoaSubAccName, 
                    string packMatAccCoaSubAccBalTypeAccBalType, 
                    string packMatAccCoaSubAccDestAccDest, 
                    string packMatAccCoaSubAccFundAccFundCode, 
                    string packMatAccCoaSubAccTypeAccType, 
                    string packMatAccCoaSubCoaControlAccName, 
                    string packMatAccCoaSubCoaMainAccName, 
                    int? otherMatAcc, 
                    string otherMatAccAccName, 
                    string otherMatAccAccBalTypeAccBalType, 
                    string otherMatAccAccCurrencyAccCurrencyName, 
                    string otherMatAccAccDestAccDest, 
                    string otherMatAccAccDestCompanyTypeDescription, 
                    string otherMatAccAccFundAccFundCode, 
                    string otherMatAccAccSubTypeAccSubType, 
                    string otherMatAccAccTypeAccType, 
                    string otherMatAccCoaControlAccName, 
                    string otherMatAccCoaControlAccBalTypeAccBalType, 
                    string otherMatAccCoaControlAccDestAccDest, 
                    string otherMatAccCoaControlAccTypeAccType, 
                    string otherMatAccCoaControlCompTypeDescription, 
                    string otherMatAccCoaMainAccName, 
                    string otherMatAccCoaMainAccBalTypeAccBalType, 
                    string otherMatAccCoaMainAccDestAccDest, 
                    string otherMatAccCoaMainAccFundAccFundCode, 
                    string otherMatAccCoaMainAccTypeAccType, 
                    string otherMatAccCoaMainCoaControlAccName, 
                    string otherMatAccCoaSubAccName, 
                    string otherMatAccCoaSubAccBalTypeAccBalType, 
                    string otherMatAccCoaSubAccDestAccDest, 
                    string otherMatAccCoaSubAccFundAccFundCode, 
                    string otherMatAccCoaSubAccTypeAccType, 
                    string otherMatAccCoaSubCoaControlAccName, 
                    string otherMatAccCoaSubCoaMainAccName, 
                    int? finishMatAcc, 
                    string finishMatAccAccName, 
                    string finishMatAccAccBalTypeAccBalType, 
                    string finishMatAccAccCurrencyAccCurrencyName, 
                    string finishMatAccAccDestAccDest, 
                    string finishMatAccAccDestCompanyTypeDescription, 
                    string finishMatAccAccFundAccFundCode, 
                    string finishMatAccAccSubTypeAccSubType, 
                    string finishMatAccAccTypeAccType, 
                    string finishMatAccCoaControlAccName, 
                    string finishMatAccCoaControlAccBalTypeAccBalType, 
                    string finishMatAccCoaControlAccDestAccDest, 
                    string finishMatAccCoaControlAccTypeAccType, 
                    string finishMatAccCoaControlCompTypeDescription, 
                    string finishMatAccCoaMainAccName, 
                    string finishMatAccCoaMainAccBalTypeAccBalType, 
                    string finishMatAccCoaMainAccDestAccDest, 
                    string finishMatAccCoaMainAccFundAccFundCode, 
                    string finishMatAccCoaMainAccTypeAccType, 
                    string finishMatAccCoaMainCoaControlAccName, 
                    string finishMatAccCoaSubAccName, 
                    string finishMatAccCoaSubAccBalTypeAccBalType, 
                    string finishMatAccCoaSubAccDestAccDest, 
                    string finishMatAccCoaSubAccFundAccFundCode, 
                    string finishMatAccCoaSubAccTypeAccType, 
                    string finishMatAccCoaSubCoaControlAccName, 
                    string finishMatAccCoaSubCoaMainAccName, 
                    int? adminExpAcc, 
                    string adminExpAccAccName, 
                    string adminExpAccAccBalTypeAccBalType, 
                    string adminExpAccAccCurrencyAccCurrencyName, 
                    string adminExpAccAccDestAccDest, 
                    string adminExpAccAccDestCompanyTypeDescription, 
                    string adminExpAccAccFundAccFundCode, 
                    string adminExpAccAccSubTypeAccSubType, 
                    string adminExpAccAccTypeAccType, 
                    string adminExpAccCoaControlAccName, 
                    string adminExpAccCoaControlAccBalTypeAccBalType, 
                    string adminExpAccCoaControlAccDestAccDest, 
                    string adminExpAccCoaControlAccTypeAccType, 
                    string adminExpAccCoaControlCompTypeDescription, 
                    string adminExpAccCoaMainAccName, 
                    string adminExpAccCoaMainAccBalTypeAccBalType, 
                    string adminExpAccCoaMainAccDestAccDest, 
                    string adminExpAccCoaMainAccFundAccFundCode, 
                    string adminExpAccCoaMainAccTypeAccType, 
                    string adminExpAccCoaMainCoaControlAccName, 
                    string adminExpAccCoaSubAccName, 
                    string adminExpAccCoaSubAccBalTypeAccBalType, 
                    string adminExpAccCoaSubAccDestAccDest, 
                    string adminExpAccCoaSubAccFundAccFundCode, 
                    string adminExpAccCoaSubAccTypeAccType, 
                    string adminExpAccCoaSubCoaControlAccName, 
                    string adminExpAccCoaSubCoaMainAccName, 
                    int? sellingExpAcc, 
                    string sellingExpAccAccName, 
                    string sellingExpAccAccBalTypeAccBalType, 
                    string sellingExpAccAccCurrencyAccCurrencyName, 
                    string sellingExpAccAccDestAccDest, 
                    string sellingExpAccAccDestCompanyTypeDescription, 
                    string sellingExpAccAccFundAccFundCode, 
                    string sellingExpAccAccSubTypeAccSubType, 
                    string sellingExpAccAccTypeAccType, 
                    string sellingExpAccCoaControlAccName, 
                    string sellingExpAccCoaControlAccBalTypeAccBalType, 
                    string sellingExpAccCoaControlAccDestAccDest, 
                    string sellingExpAccCoaControlAccTypeAccType, 
                    string sellingExpAccCoaControlCompTypeDescription, 
                    string sellingExpAccCoaMainAccName, 
                    string sellingExpAccCoaMainAccBalTypeAccBalType, 
                    string sellingExpAccCoaMainAccDestAccDest, 
                    string sellingExpAccCoaMainAccFundAccFundCode, 
                    string sellingExpAccCoaMainAccTypeAccType, 
                    string sellingExpAccCoaMainCoaControlAccName, 
                    string sellingExpAccCoaSubAccName, 
                    string sellingExpAccCoaSubAccBalTypeAccBalType, 
                    string sellingExpAccCoaSubAccDestAccDest, 
                    string sellingExpAccCoaSubAccFundAccFundCode, 
                    string sellingExpAccCoaSubAccTypeAccType, 
                    string sellingExpAccCoaSubCoaControlAccName, 
                    string sellingExpAccCoaSubCoaMainAccName, 
                    int? manuExpAcc, 
                    string manuExpAccAccName, 
                    string manuExpAccAccBalTypeAccBalType, 
                    string manuExpAccAccCurrencyAccCurrencyName, 
                    string manuExpAccAccDestAccDest, 
                    string manuExpAccAccDestCompanyTypeDescription, 
                    string manuExpAccAccFundAccFundCode, 
                    string manuExpAccAccSubTypeAccSubType, 
                    string manuExpAccAccTypeAccType, 
                    string manuExpAccCoaControlAccName, 
                    string manuExpAccCoaControlAccBalTypeAccBalType, 
                    string manuExpAccCoaControlAccDestAccDest, 
                    string manuExpAccCoaControlAccTypeAccType, 
                    string manuExpAccCoaControlCompTypeDescription, 
                    string manuExpAccCoaMainAccName, 
                    string manuExpAccCoaMainAccBalTypeAccBalType, 
                    string manuExpAccCoaMainAccDestAccDest, 
                    string manuExpAccCoaMainAccFundAccFundCode, 
                    string manuExpAccCoaMainAccTypeAccType, 
                    string manuExpAccCoaMainCoaControlAccName, 
                    string manuExpAccCoaSubAccName, 
                    string manuExpAccCoaSubAccBalTypeAccBalType, 
                    string manuExpAccCoaSubAccDestAccDest, 
                    string manuExpAccCoaSubAccFundAccFundCode, 
                    string manuExpAccCoaSubAccTypeAccType, 
                    string manuExpAccCoaSubCoaControlAccName, 
                    string manuExpAccCoaSubCoaMainAccName, 
                    int? loanAcc, 
                    string loanAccAccName, 
                    string loanAccAccBalTypeAccBalType, 
                    string loanAccAccCurrencyAccCurrencyName, 
                    string loanAccAccDestAccDest, 
                    string loanAccAccDestCompanyTypeDescription, 
                    string loanAccAccFundAccFundCode, 
                    string loanAccAccSubTypeAccSubType, 
                    string loanAccAccTypeAccType, 
                    string loanAccCoaControlAccName, 
                    string loanAccCoaControlAccBalTypeAccBalType, 
                    string loanAccCoaControlAccDestAccDest, 
                    string loanAccCoaControlAccTypeAccType, 
                    string loanAccCoaControlCompTypeDescription, 
                    string loanAccCoaMainAccName, 
                    string loanAccCoaMainAccBalTypeAccBalType, 
                    string loanAccCoaMainAccDestAccDest, 
                    string loanAccCoaMainAccFundAccFundCode, 
                    string loanAccCoaMainAccTypeAccType, 
                    string loanAccCoaMainCoaControlAccName, 
                    string loanAccCoaSubAccName, 
                    string loanAccCoaSubAccBalTypeAccBalType, 
                    string loanAccCoaSubAccDestAccDest, 
                    string loanAccCoaSubAccFundAccFundCode, 
                    string loanAccCoaSubAccTypeAccType, 
                    string loanAccCoaSubCoaControlAccName, 
                    string loanAccCoaSubCoaMainAccName, 
                    int? assetDepAcc, 
                    string assetDepAccAccName, 
                    string assetDepAccAccBalTypeAccBalType, 
                    string assetDepAccAccCurrencyAccCurrencyName, 
                    string assetDepAccAccDestAccDest, 
                    string assetDepAccAccDestCompanyTypeDescription, 
                    string assetDepAccAccFundAccFundCode, 
                    string assetDepAccAccSubTypeAccSubType, 
                    string assetDepAccAccTypeAccType, 
                    string assetDepAccCoaControlAccName, 
                    string assetDepAccCoaControlAccBalTypeAccBalType, 
                    string assetDepAccCoaControlAccDestAccDest, 
                    string assetDepAccCoaControlAccTypeAccType, 
                    string assetDepAccCoaControlCompTypeDescription, 
                    string assetDepAccCoaMainAccName, 
                    string assetDepAccCoaMainAccBalTypeAccBalType, 
                    string assetDepAccCoaMainAccDestAccDest, 
                    string assetDepAccCoaMainAccFundAccFundCode, 
                    string assetDepAccCoaMainAccTypeAccType, 
                    string assetDepAccCoaMainCoaControlAccName, 
                    string assetDepAccCoaSubAccName, 
                    string assetDepAccCoaSubAccBalTypeAccBalType, 
                    string assetDepAccCoaSubAccDestAccDest, 
                    string assetDepAccCoaSubAccFundAccFundCode, 
                    string assetDepAccCoaSubAccTypeAccType, 
                    string assetDepAccCoaSubCoaControlAccName, 
                    string assetDepAccCoaSubCoaMainAccName, 
                    int? nonOperateIncAcc, 
                    string nonOperateIncAccAccName, 
                    string nonOperateIncAccAccBalTypeAccBalType, 
                    string nonOperateIncAccAccCurrencyAccCurrencyName, 
                    string nonOperateIncAccAccDestAccDest, 
                    string nonOperateIncAccAccDestCompanyTypeDescription, 
                    string nonOperateIncAccAccFundAccFundCode, 
                    string nonOperateIncAccAccSubTypeAccSubType, 
                    string nonOperateIncAccAccTypeAccType, 
                    string nonOperateIncAccCoaControlAccName, 
                    string nonOperateIncAccCoaControlAccBalTypeAccBalType, 
                    string nonOperateIncAccCoaControlAccDestAccDest, 
                    string nonOperateIncAccCoaControlAccTypeAccType, 
                    string nonOperateIncAccCoaControlCompTypeDescription, 
                    string nonOperateIncAccCoaMainAccName, 
                    string nonOperateIncAccCoaMainAccBalTypeAccBalType, 
                    string nonOperateIncAccCoaMainAccDestAccDest, 
                    string nonOperateIncAccCoaMainAccFundAccFundCode, 
                    string nonOperateIncAccCoaMainAccTypeAccType, 
                    string nonOperateIncAccCoaMainCoaControlAccName, 
                    string nonOperateIncAccCoaSubAccName, 
                    string nonOperateIncAccCoaSubAccBalTypeAccBalType, 
                    string nonOperateIncAccCoaSubAccDestAccDest, 
                    string nonOperateIncAccCoaSubAccFundAccFundCode, 
                    string nonOperateIncAccCoaSubAccTypeAccType, 
                    string nonOperateIncAccCoaSubCoaControlAccName, 
                    string nonOperateIncAccCoaSubCoaMainAccName, 
                    int? nonOperateExpAcc, 
                    string nonOperateExpAccAccName, 
                    string nonOperateExpAccAccBalTypeAccBalType, 
                    string nonOperateExpAccAccCurrencyAccCurrencyName, 
                    string nonOperateExpAccAccDestAccDest, 
                    string nonOperateExpAccAccDestCompanyTypeDescription, 
                    string nonOperateExpAccAccFundAccFundCode, 
                    string nonOperateExpAccAccSubTypeAccSubType, 
                    string nonOperateExpAccAccTypeAccType, 
                    string nonOperateExpAccCoaControlAccName, 
                    string nonOperateExpAccCoaControlAccBalTypeAccBalType, 
                    string nonOperateExpAccCoaControlAccDestAccDest, 
                    string nonOperateExpAccCoaControlAccTypeAccType, 
                    string nonOperateExpAccCoaControlCompTypeDescription, 
                    string nonOperateExpAccCoaMainAccName, 
                    string nonOperateExpAccCoaMainAccBalTypeAccBalType, 
                    string nonOperateExpAccCoaMainAccDestAccDest, 
                    string nonOperateExpAccCoaMainAccFundAccFundCode, 
                    string nonOperateExpAccCoaMainAccTypeAccType, 
                    string nonOperateExpAccCoaMainCoaControlAccName, 
                    string nonOperateExpAccCoaSubAccName, 
                    string nonOperateExpAccCoaSubAccBalTypeAccBalType, 
                    string nonOperateExpAccCoaSubAccDestAccDest, 
                    string nonOperateExpAccCoaSubAccFundAccFundCode, 
                    string nonOperateExpAccCoaSubAccTypeAccType, 
                    string nonOperateExpAccCoaSubCoaControlAccName, 
                    string nonOperateExpAccCoaSubCoaMainAccName, 
                    int? prevYearPLAcc, 
                    string prevYearPLAccAccName, 
                    string prevYearPLAccAccBalTypeAccBalType, 
                    string prevYearPLAccAccCurrencyAccCurrencyName, 
                    string prevYearPLAccAccDestAccDest, 
                    string prevYearPLAccAccDestCompanyTypeDescription, 
                    string prevYearPLAccAccFundAccFundCode, 
                    string prevYearPLAccAccSubTypeAccSubType, 
                    string prevYearPLAccAccTypeAccType, 
                    string prevYearPLAccCoaControlAccName, 
                    string prevYearPLAccCoaControlAccBalTypeAccBalType, 
                    string prevYearPLAccCoaControlAccDestAccDest, 
                    string prevYearPLAccCoaControlAccTypeAccType, 
                    string prevYearPLAccCoaControlCompTypeDescription, 
                    string prevYearPLAccCoaMainAccName, 
                    string prevYearPLAccCoaMainAccBalTypeAccBalType, 
                    string prevYearPLAccCoaMainAccDestAccDest, 
                    string prevYearPLAccCoaMainAccFundAccFundCode, 
                    string prevYearPLAccCoaMainAccTypeAccType, 
                    string prevYearPLAccCoaMainCoaControlAccName, 
                    string prevYearPLAccCoaSubAccName, 
                    string prevYearPLAccCoaSubAccBalTypeAccBalType, 
                    string prevYearPLAccCoaSubAccDestAccDest, 
                    string prevYearPLAccCoaSubAccFundAccFundCode, 
                    string prevYearPLAccCoaSubAccTypeAccType, 
                    string prevYearPLAccCoaSubCoaControlAccName, 
                    string prevYearPLAccCoaSubCoaMainAccName, 
                    int? currYearPLAcc, 
                    string currYearPLAccAccName, 
                    string currYearPLAccAccBalTypeAccBalType, 
                    string currYearPLAccAccCurrencyAccCurrencyName, 
                    string currYearPLAccAccDestAccDest, 
                    string currYearPLAccAccDestCompanyTypeDescription, 
                    string currYearPLAccAccFundAccFundCode, 
                    string currYearPLAccAccSubTypeAccSubType, 
                    string currYearPLAccAccTypeAccType, 
                    string currYearPLAccCoaControlAccName, 
                    string currYearPLAccCoaControlAccBalTypeAccBalType, 
                    string currYearPLAccCoaControlAccDestAccDest, 
                    string currYearPLAccCoaControlAccTypeAccType, 
                    string currYearPLAccCoaControlCompTypeDescription, 
                    string currYearPLAccCoaMainAccName, 
                    string currYearPLAccCoaMainAccBalTypeAccBalType, 
                    string currYearPLAccCoaMainAccDestAccDest, 
                    string currYearPLAccCoaMainAccFundAccFundCode, 
                    string currYearPLAccCoaMainAccTypeAccType, 
                    string currYearPLAccCoaMainCoaControlAccName, 
                    string currYearPLAccCoaSubAccName, 
                    string currYearPLAccCoaSubAccBalTypeAccBalType, 
                    string currYearPLAccCoaSubAccDestAccDest, 
                    string currYearPLAccCoaSubAccFundAccFundCode, 
                    string currYearPLAccCoaSubAccTypeAccType, 
                    string currYearPLAccCoaSubCoaControlAccName, 
                    string currYearPLAccCoaSubCoaMainAccName, 
                    int? chequeCCAcc, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(accFundAccsID, accFundID, accFundAccFundCode, cashCode, cashAccName, cashAccBalTypeAccBalType, cashAccCurrencyAccCurrencyName, cashAccDestAccDest, cashAccDestCompanyTypeDescription, cashAccFundAccFundCode, cashAccSubTypeAccSubType, cashAccTypeAccType, cashCoaControlAccName, cashCoaControlAccBalTypeAccBalType, cashCoaControlAccDestAccDest, cashCoaControlAccTypeAccType, cashCoaControlCompTypeDescription, cashCoaMainAccName, cashCoaMainAccBalTypeAccBalType, cashCoaMainAccDestAccDest, cashCoaMainAccFundAccFundCode, cashCoaMainAccTypeAccType, cashCoaMainCoaControlAccName, cashCoaSubAccName, cashCoaSubAccBalTypeAccBalType, cashCoaSubAccDestAccDest, cashCoaSubAccFundAccFundCode, cashCoaSubAccTypeAccType, cashCoaSubCoaControlAccName, cashCoaSubCoaMainAccName, bankCode, bankAccName, bankAccBalTypeAccBalType, bankAccCurrencyAccCurrencyName, bankAccDestAccDest, bankAccDestCompanyTypeDescription, bankAccFundAccFundCode, bankAccSubTypeAccSubType, bankAccTypeAccType, bankCoaControlAccName, bankCoaControlAccBalTypeAccBalType, bankCoaControlAccDestAccDest, bankCoaControlAccTypeAccType, bankCoaControlCompTypeDescription, bankCoaMainAccName, bankCoaMainAccBalTypeAccBalType, bankCoaMainAccDestAccDest, bankCoaMainAccFundAccFundCode, bankCoaMainAccTypeAccType, bankCoaMainCoaControlAccName, bankCoaSubAccName, bankCoaSubAccBalTypeAccBalType, bankCoaSubAccDestAccDest, bankCoaSubAccFundAccFundCode, bankCoaSubAccTypeAccType, bankCoaSubCoaControlAccName, bankCoaSubCoaMainAccName, advance, advanceAccName, advanceAccBalTypeAccBalType, advanceAccCurrencyAccCurrencyName, advanceAccDestAccDest, advanceAccDestCompanyTypeDescription, advanceAccFundAccFundCode, advanceAccSubTypeAccSubType, advanceAccTypeAccType, advanceCoaControlAccName, advanceCoaControlAccBalTypeAccBalType, advanceCoaControlAccDestAccDest, advanceCoaControlAccTypeAccType, advanceCoaControlCompTypeDescription, advanceCoaMainAccName, advanceCoaMainAccBalTypeAccBalType, advanceCoaMainAccDestAccDest, advanceCoaMainAccFundAccFundCode, advanceCoaMainAccTypeAccType, advanceCoaMainCoaControlAccName, advanceCoaSubAccName, advanceCoaSubAccBalTypeAccBalType, advanceCoaSubAccDestAccDest, advanceCoaSubAccFundAccFundCode, advanceCoaSubAccTypeAccType, advanceCoaSubCoaControlAccName, advanceCoaSubCoaMainAccName, purAcc, purAccAccName, purAccAccBalTypeAccBalType, purAccAccCurrencyAccCurrencyName, purAccAccDestAccDest, purAccAccDestCompanyTypeDescription, purAccAccFundAccFundCode, purAccAccSubTypeAccSubType, purAccAccTypeAccType, purAccCoaControlAccName, purAccCoaControlAccBalTypeAccBalType, purAccCoaControlAccDestAccDest, purAccCoaControlAccTypeAccType, purAccCoaControlCompTypeDescription, purAccCoaMainAccName, purAccCoaMainAccBalTypeAccBalType, purAccCoaMainAccDestAccDest, purAccCoaMainAccFundAccFundCode, purAccCoaMainAccTypeAccType, purAccCoaMainCoaControlAccName, purAccCoaSubAccName, purAccCoaSubAccBalTypeAccBalType, purAccCoaSubAccDestAccDest, purAccCoaSubAccFundAccFundCode, purAccCoaSubAccTypeAccType, purAccCoaSubCoaControlAccName, purAccCoaSubCoaMainAccName, saleAcc, saleAccAccName, saleAccAccBalTypeAccBalType, saleAccAccCurrencyAccCurrencyName, saleAccAccDestAccDest, saleAccAccDestCompanyTypeDescription, saleAccAccFundAccFundCode, saleAccAccSubTypeAccSubType, saleAccAccTypeAccType, saleAccCoaControlAccName, saleAccCoaControlAccBalTypeAccBalType, saleAccCoaControlAccDestAccDest, saleAccCoaControlAccTypeAccType, saleAccCoaControlCompTypeDescription, saleAccCoaMainAccName, saleAccCoaMainAccBalTypeAccBalType, saleAccCoaMainAccDestAccDest, saleAccCoaMainAccFundAccFundCode, saleAccCoaMainAccTypeAccType, saleAccCoaMainCoaControlAccName, saleAccCoaSubAccName, saleAccCoaSubAccBalTypeAccBalType, saleAccCoaSubAccDestAccDest, saleAccCoaSubAccFundAccFundCode, saleAccCoaSubAccTypeAccType, saleAccCoaSubCoaControlAccName, saleAccCoaSubCoaMainAccName, workinProgressAcc, workinProgressAccAccName, workinProgressAccAccBalTypeAccBalType, workinProgressAccAccCurrencyAccCurrencyName, workinProgressAccAccDestAccDest, workinProgressAccAccDestCompanyTypeDescription, workinProgressAccAccFundAccFundCode, workinProgressAccAccSubTypeAccSubType, workinProgressAccAccTypeAccType, workinProgressAccCoaControlAccName, workinProgressAccCoaControlAccBalTypeAccBalType, workinProgressAccCoaControlAccDestAccDest, workinProgressAccCoaControlAccTypeAccType, workinProgressAccCoaControlCompTypeDescription, workinProgressAccCoaMainAccName, workinProgressAccCoaMainAccBalTypeAccBalType, workinProgressAccCoaMainAccDestAccDest, workinProgressAccCoaMainAccFundAccFundCode, workinProgressAccCoaMainAccTypeAccType, workinProgressAccCoaMainCoaControlAccName, workinProgressAccCoaSubAccName, workinProgressAccCoaSubAccBalTypeAccBalType, workinProgressAccCoaSubAccDestAccDest, workinProgressAccCoaSubAccFundAccFundCode, workinProgressAccCoaSubAccTypeAccType, workinProgressAccCoaSubCoaControlAccName, workinProgressAccCoaSubCoaMainAccName, costofSold, costofSoldAccName, costofSoldAccBalTypeAccBalType, costofSoldAccCurrencyAccCurrencyName, costofSoldAccDestAccDest, costofSoldAccDestCompanyTypeDescription, costofSoldAccFundAccFundCode, costofSoldAccSubTypeAccSubType, costofSoldAccTypeAccType, costofSoldCoaControlAccName, costofSoldCoaControlAccBalTypeAccBalType, costofSoldCoaControlAccDestAccDest, costofSoldCoaControlAccTypeAccType, costofSoldCoaControlCompTypeDescription, costofSoldCoaMainAccName, costofSoldCoaMainAccBalTypeAccBalType, costofSoldCoaMainAccDestAccDest, costofSoldCoaMainAccFundAccFundCode, costofSoldCoaMainAccTypeAccType, costofSoldCoaMainCoaControlAccName, costofSoldCoaSubAccName, costofSoldCoaSubAccBalTypeAccBalType, costofSoldCoaSubAccDestAccDest, costofSoldCoaSubAccFundAccFundCode, costofSoldCoaSubAccTypeAccType, costofSoldCoaSubCoaControlAccName, costofSoldCoaSubCoaMainAccName, oPD_Acc, oPD_AccAccName, oPD_AccAccBalTypeAccBalType, oPD_AccAccCurrencyAccCurrencyName, oPD_AccAccDestAccDest, oPD_AccAccDestCompanyTypeDescription, oPD_AccAccFundAccFundCode, oPD_AccAccSubTypeAccSubType, oPD_AccAccTypeAccType, oPD_AccCoaControlAccName, oPD_AccCoaControlAccBalTypeAccBalType, oPD_AccCoaControlAccDestAccDest, oPD_AccCoaControlAccTypeAccType, oPD_AccCoaControlCompTypeDescription, oPD_AccCoaMainAccName, oPD_AccCoaMainAccBalTypeAccBalType, oPD_AccCoaMainAccDestAccDest, oPD_AccCoaMainAccFundAccFundCode, oPD_AccCoaMainAccTypeAccType, oPD_AccCoaMainCoaControlAccName, oPD_AccCoaSubAccName, oPD_AccCoaSubAccBalTypeAccBalType, oPD_AccCoaSubAccDestAccDest, oPD_AccCoaSubAccFundAccFundCode, oPD_AccCoaSubAccTypeAccType, oPD_AccCoaSubCoaControlAccName, oPD_AccCoaSubCoaMainAccName, advPat_Acc, advPat_AccAccName, advPat_AccAccBalTypeAccBalType, advPat_AccAccCurrencyAccCurrencyName, advPat_AccAccDestAccDest, advPat_AccAccDestCompanyTypeDescription, advPat_AccAccFundAccFundCode, advPat_AccAccSubTypeAccSubType, advPat_AccAccTypeAccType, advPat_AccCoaControlAccName, advPat_AccCoaControlAccBalTypeAccBalType, advPat_AccCoaControlAccDestAccDest, advPat_AccCoaControlAccTypeAccType, advPat_AccCoaControlCompTypeDescription, advPat_AccCoaMainAccName, advPat_AccCoaMainAccBalTypeAccBalType, advPat_AccCoaMainAccDestAccDest, advPat_AccCoaMainAccFundAccFundCode, advPat_AccCoaMainAccTypeAccType, advPat_AccCoaMainCoaControlAccName, advPat_AccCoaSubAccName, advPat_AccCoaSubAccBalTypeAccBalType, advPat_AccCoaSubAccDestAccDest, advPat_AccCoaSubAccFundAccFundCode, advPat_AccCoaSubAccTypeAccType, advPat_AccCoaSubCoaControlAccName, advPat_AccCoaSubCoaMainAccName, investigate_Acc, investigate_AccAccName, investigate_AccAccBalTypeAccBalType, investigate_AccAccCurrencyAccCurrencyName, investigate_AccAccDestAccDest, investigate_AccAccDestCompanyTypeDescription, investigate_AccAccFundAccFundCode, investigate_AccAccSubTypeAccSubType, investigate_AccAccTypeAccType, investigate_AccCoaControlAccName, investigate_AccCoaControlAccBalTypeAccBalType, investigate_AccCoaControlAccDestAccDest, investigate_AccCoaControlAccTypeAccType, investigate_AccCoaControlCompTypeDescription, investigate_AccCoaMainAccName, investigate_AccCoaMainAccBalTypeAccBalType, investigate_AccCoaMainAccDestAccDest, investigate_AccCoaMainAccFundAccFundCode, investigate_AccCoaMainAccTypeAccType, investigate_AccCoaMainCoaControlAccName, investigate_AccCoaSubAccName, investigate_AccCoaSubAccBalTypeAccBalType, investigate_AccCoaSubAccDestAccDest, investigate_AccCoaSubAccFundAccFundCode, investigate_AccCoaSubAccTypeAccType, investigate_AccCoaSubCoaControlAccName, investigate_AccCoaSubCoaMainAccName, vatAcc, vatAccAccName, vatAccAccBalTypeAccBalType, vatAccAccCurrencyAccCurrencyName, vatAccAccDestAccDest, vatAccAccDestCompanyTypeDescription, vatAccAccFundAccFundCode, vatAccAccSubTypeAccSubType, vatAccAccTypeAccType, vatAccCoaControlAccName, vatAccCoaControlAccBalTypeAccBalType, vatAccCoaControlAccDestAccDest, vatAccCoaControlAccTypeAccType, vatAccCoaControlCompTypeDescription, vatAccCoaMainAccName, vatAccCoaMainAccBalTypeAccBalType, vatAccCoaMainAccDestAccDest, vatAccCoaMainAccFundAccFundCode, vatAccCoaMainAccTypeAccType, vatAccCoaMainCoaControlAccName, vatAccCoaSubAccName, vatAccCoaSubAccBalTypeAccBalType, vatAccCoaSubAccDestAccDest, vatAccCoaSubAccFundAccFundCode, vatAccCoaSubAccTypeAccType, vatAccCoaSubCoaControlAccName, vatAccCoaSubCoaMainAccName, sundryDebitors, sundryDebitorsAccName, sundryDebitorsAccBalTypeAccBalType, sundryDebitorsAccCurrencyAccCurrencyName, sundryDebitorsAccDestAccDest, sundryDebitorsAccDestCompanyTypeDescription, sundryDebitorsAccFundAccFundCode, sundryDebitorsAccSubTypeAccSubType, sundryDebitorsAccTypeAccType, sundryDebitorsCoaControlAccName, sundryDebitorsCoaControlAccBalTypeAccBalType, sundryDebitorsCoaControlAccDestAccDest, sundryDebitorsCoaControlAccTypeAccType, sundryDebitorsCoaControlCompTypeDescription, sundryDebitorsCoaMainAccName, sundryDebitorsCoaMainAccBalTypeAccBalType, sundryDebitorsCoaMainAccDestAccDest, sundryDebitorsCoaMainAccFundAccFundCode, sundryDebitorsCoaMainAccTypeAccType, sundryDebitorsCoaMainCoaControlAccName, sundryDebitorsCoaSubAccName, sundryDebitorsCoaSubAccBalTypeAccBalType, sundryDebitorsCoaSubAccDestAccDest, sundryDebitorsCoaSubAccFundAccFundCode, sundryDebitorsCoaSubAccTypeAccType, sundryDebitorsCoaSubCoaControlAccName, sundryDebitorsCoaSubCoaMainAccName, sundryCreditors, sundryCreditorsAccName, sundryCreditorsAccBalTypeAccBalType, sundryCreditorsAccCurrencyAccCurrencyName, sundryCreditorsAccDestAccDest, sundryCreditorsAccDestCompanyTypeDescription, sundryCreditorsAccFundAccFundCode, sundryCreditorsAccSubTypeAccSubType, sundryCreditorsAccTypeAccType, sundryCreditorsCoaControlAccName, sundryCreditorsCoaControlAccBalTypeAccBalType, sundryCreditorsCoaControlAccDestAccDest, sundryCreditorsCoaControlAccTypeAccType, sundryCreditorsCoaControlCompTypeDescription, sundryCreditorsCoaMainAccName, sundryCreditorsCoaMainAccBalTypeAccBalType, sundryCreditorsCoaMainAccDestAccDest, sundryCreditorsCoaMainAccFundAccFundCode, sundryCreditorsCoaMainAccTypeAccType, sundryCreditorsCoaMainCoaControlAccName, sundryCreditorsCoaSubAccName, sundryCreditorsCoaSubAccBalTypeAccBalType, sundryCreditorsCoaSubAccDestAccDest, sundryCreditorsCoaSubAccFundAccFundCode, sundryCreditorsCoaSubAccTypeAccType, sundryCreditorsCoaSubCoaControlAccName, sundryCreditorsCoaSubCoaMainAccName, rawMatAcc, rawMatAccAccName, rawMatAccAccBalTypeAccBalType, rawMatAccAccCurrencyAccCurrencyName, rawMatAccAccDestAccDest, rawMatAccAccDestCompanyTypeDescription, rawMatAccAccFundAccFundCode, rawMatAccAccSubTypeAccSubType, rawMatAccAccTypeAccType, rawMatAccCoaControlAccName, rawMatAccCoaControlAccBalTypeAccBalType, rawMatAccCoaControlAccDestAccDest, rawMatAccCoaControlAccTypeAccType, rawMatAccCoaControlCompTypeDescription, rawMatAccCoaMainAccName, rawMatAccCoaMainAccBalTypeAccBalType, rawMatAccCoaMainAccDestAccDest, rawMatAccCoaMainAccFundAccFundCode, rawMatAccCoaMainAccTypeAccType, rawMatAccCoaMainCoaControlAccName, rawMatAccCoaSubAccName, rawMatAccCoaSubAccBalTypeAccBalType, rawMatAccCoaSubAccDestAccDest, rawMatAccCoaSubAccFundAccFundCode, rawMatAccCoaSubAccTypeAccType, rawMatAccCoaSubCoaControlAccName, rawMatAccCoaSubCoaMainAccName, packMatAcc, packMatAccAccName, packMatAccAccBalTypeAccBalType, packMatAccAccCurrencyAccCurrencyName, packMatAccAccDestAccDest, packMatAccAccDestCompanyTypeDescription, packMatAccAccFundAccFundCode, packMatAccAccSubTypeAccSubType, packMatAccAccTypeAccType, packMatAccCoaControlAccName, packMatAccCoaControlAccBalTypeAccBalType, packMatAccCoaControlAccDestAccDest, packMatAccCoaControlAccTypeAccType, packMatAccCoaControlCompTypeDescription, packMatAccCoaMainAccName, packMatAccCoaMainAccBalTypeAccBalType, packMatAccCoaMainAccDestAccDest, packMatAccCoaMainAccFundAccFundCode, packMatAccCoaMainAccTypeAccType, packMatAccCoaMainCoaControlAccName, packMatAccCoaSubAccName, packMatAccCoaSubAccBalTypeAccBalType, packMatAccCoaSubAccDestAccDest, packMatAccCoaSubAccFundAccFundCode, packMatAccCoaSubAccTypeAccType, packMatAccCoaSubCoaControlAccName, packMatAccCoaSubCoaMainAccName, otherMatAcc, otherMatAccAccName, otherMatAccAccBalTypeAccBalType, otherMatAccAccCurrencyAccCurrencyName, otherMatAccAccDestAccDest, otherMatAccAccDestCompanyTypeDescription, otherMatAccAccFundAccFundCode, otherMatAccAccSubTypeAccSubType, otherMatAccAccTypeAccType, otherMatAccCoaControlAccName, otherMatAccCoaControlAccBalTypeAccBalType, otherMatAccCoaControlAccDestAccDest, otherMatAccCoaControlAccTypeAccType, otherMatAccCoaControlCompTypeDescription, otherMatAccCoaMainAccName, otherMatAccCoaMainAccBalTypeAccBalType, otherMatAccCoaMainAccDestAccDest, otherMatAccCoaMainAccFundAccFundCode, otherMatAccCoaMainAccTypeAccType, otherMatAccCoaMainCoaControlAccName, otherMatAccCoaSubAccName, otherMatAccCoaSubAccBalTypeAccBalType, otherMatAccCoaSubAccDestAccDest, otherMatAccCoaSubAccFundAccFundCode, otherMatAccCoaSubAccTypeAccType, otherMatAccCoaSubCoaControlAccName, otherMatAccCoaSubCoaMainAccName, finishMatAcc, finishMatAccAccName, finishMatAccAccBalTypeAccBalType, finishMatAccAccCurrencyAccCurrencyName, finishMatAccAccDestAccDest, finishMatAccAccDestCompanyTypeDescription, finishMatAccAccFundAccFundCode, finishMatAccAccSubTypeAccSubType, finishMatAccAccTypeAccType, finishMatAccCoaControlAccName, finishMatAccCoaControlAccBalTypeAccBalType, finishMatAccCoaControlAccDestAccDest, finishMatAccCoaControlAccTypeAccType, finishMatAccCoaControlCompTypeDescription, finishMatAccCoaMainAccName, finishMatAccCoaMainAccBalTypeAccBalType, finishMatAccCoaMainAccDestAccDest, finishMatAccCoaMainAccFundAccFundCode, finishMatAccCoaMainAccTypeAccType, finishMatAccCoaMainCoaControlAccName, finishMatAccCoaSubAccName, finishMatAccCoaSubAccBalTypeAccBalType, finishMatAccCoaSubAccDestAccDest, finishMatAccCoaSubAccFundAccFundCode, finishMatAccCoaSubAccTypeAccType, finishMatAccCoaSubCoaControlAccName, finishMatAccCoaSubCoaMainAccName, adminExpAcc, adminExpAccAccName, adminExpAccAccBalTypeAccBalType, adminExpAccAccCurrencyAccCurrencyName, adminExpAccAccDestAccDest, adminExpAccAccDestCompanyTypeDescription, adminExpAccAccFundAccFundCode, adminExpAccAccSubTypeAccSubType, adminExpAccAccTypeAccType, adminExpAccCoaControlAccName, adminExpAccCoaControlAccBalTypeAccBalType, adminExpAccCoaControlAccDestAccDest, adminExpAccCoaControlAccTypeAccType, adminExpAccCoaControlCompTypeDescription, adminExpAccCoaMainAccName, adminExpAccCoaMainAccBalTypeAccBalType, adminExpAccCoaMainAccDestAccDest, adminExpAccCoaMainAccFundAccFundCode, adminExpAccCoaMainAccTypeAccType, adminExpAccCoaMainCoaControlAccName, adminExpAccCoaSubAccName, adminExpAccCoaSubAccBalTypeAccBalType, adminExpAccCoaSubAccDestAccDest, adminExpAccCoaSubAccFundAccFundCode, adminExpAccCoaSubAccTypeAccType, adminExpAccCoaSubCoaControlAccName, adminExpAccCoaSubCoaMainAccName, sellingExpAcc, sellingExpAccAccName, sellingExpAccAccBalTypeAccBalType, sellingExpAccAccCurrencyAccCurrencyName, sellingExpAccAccDestAccDest, sellingExpAccAccDestCompanyTypeDescription, sellingExpAccAccFundAccFundCode, sellingExpAccAccSubTypeAccSubType, sellingExpAccAccTypeAccType, sellingExpAccCoaControlAccName, sellingExpAccCoaControlAccBalTypeAccBalType, sellingExpAccCoaControlAccDestAccDest, sellingExpAccCoaControlAccTypeAccType, sellingExpAccCoaControlCompTypeDescription, sellingExpAccCoaMainAccName, sellingExpAccCoaMainAccBalTypeAccBalType, sellingExpAccCoaMainAccDestAccDest, sellingExpAccCoaMainAccFundAccFundCode, sellingExpAccCoaMainAccTypeAccType, sellingExpAccCoaMainCoaControlAccName, sellingExpAccCoaSubAccName, sellingExpAccCoaSubAccBalTypeAccBalType, sellingExpAccCoaSubAccDestAccDest, sellingExpAccCoaSubAccFundAccFundCode, sellingExpAccCoaSubAccTypeAccType, sellingExpAccCoaSubCoaControlAccName, sellingExpAccCoaSubCoaMainAccName, manuExpAcc, manuExpAccAccName, manuExpAccAccBalTypeAccBalType, manuExpAccAccCurrencyAccCurrencyName, manuExpAccAccDestAccDest, manuExpAccAccDestCompanyTypeDescription, manuExpAccAccFundAccFundCode, manuExpAccAccSubTypeAccSubType, manuExpAccAccTypeAccType, manuExpAccCoaControlAccName, manuExpAccCoaControlAccBalTypeAccBalType, manuExpAccCoaControlAccDestAccDest, manuExpAccCoaControlAccTypeAccType, manuExpAccCoaControlCompTypeDescription, manuExpAccCoaMainAccName, manuExpAccCoaMainAccBalTypeAccBalType, manuExpAccCoaMainAccDestAccDest, manuExpAccCoaMainAccFundAccFundCode, manuExpAccCoaMainAccTypeAccType, manuExpAccCoaMainCoaControlAccName, manuExpAccCoaSubAccName, manuExpAccCoaSubAccBalTypeAccBalType, manuExpAccCoaSubAccDestAccDest, manuExpAccCoaSubAccFundAccFundCode, manuExpAccCoaSubAccTypeAccType, manuExpAccCoaSubCoaControlAccName, manuExpAccCoaSubCoaMainAccName, loanAcc, loanAccAccName, loanAccAccBalTypeAccBalType, loanAccAccCurrencyAccCurrencyName, loanAccAccDestAccDest, loanAccAccDestCompanyTypeDescription, loanAccAccFundAccFundCode, loanAccAccSubTypeAccSubType, loanAccAccTypeAccType, loanAccCoaControlAccName, loanAccCoaControlAccBalTypeAccBalType, loanAccCoaControlAccDestAccDest, loanAccCoaControlAccTypeAccType, loanAccCoaControlCompTypeDescription, loanAccCoaMainAccName, loanAccCoaMainAccBalTypeAccBalType, loanAccCoaMainAccDestAccDest, loanAccCoaMainAccFundAccFundCode, loanAccCoaMainAccTypeAccType, loanAccCoaMainCoaControlAccName, loanAccCoaSubAccName, loanAccCoaSubAccBalTypeAccBalType, loanAccCoaSubAccDestAccDest, loanAccCoaSubAccFundAccFundCode, loanAccCoaSubAccTypeAccType, loanAccCoaSubCoaControlAccName, loanAccCoaSubCoaMainAccName, assetDepAcc, assetDepAccAccName, assetDepAccAccBalTypeAccBalType, assetDepAccAccCurrencyAccCurrencyName, assetDepAccAccDestAccDest, assetDepAccAccDestCompanyTypeDescription, assetDepAccAccFundAccFundCode, assetDepAccAccSubTypeAccSubType, assetDepAccAccTypeAccType, assetDepAccCoaControlAccName, assetDepAccCoaControlAccBalTypeAccBalType, assetDepAccCoaControlAccDestAccDest, assetDepAccCoaControlAccTypeAccType, assetDepAccCoaControlCompTypeDescription, assetDepAccCoaMainAccName, assetDepAccCoaMainAccBalTypeAccBalType, assetDepAccCoaMainAccDestAccDest, assetDepAccCoaMainAccFundAccFundCode, assetDepAccCoaMainAccTypeAccType, assetDepAccCoaMainCoaControlAccName, assetDepAccCoaSubAccName, assetDepAccCoaSubAccBalTypeAccBalType, assetDepAccCoaSubAccDestAccDest, assetDepAccCoaSubAccFundAccFundCode, assetDepAccCoaSubAccTypeAccType, assetDepAccCoaSubCoaControlAccName, assetDepAccCoaSubCoaMainAccName, nonOperateIncAcc, nonOperateIncAccAccName, nonOperateIncAccAccBalTypeAccBalType, nonOperateIncAccAccCurrencyAccCurrencyName, nonOperateIncAccAccDestAccDest, nonOperateIncAccAccDestCompanyTypeDescription, nonOperateIncAccAccFundAccFundCode, nonOperateIncAccAccSubTypeAccSubType, nonOperateIncAccAccTypeAccType, nonOperateIncAccCoaControlAccName, nonOperateIncAccCoaControlAccBalTypeAccBalType, nonOperateIncAccCoaControlAccDestAccDest, nonOperateIncAccCoaControlAccTypeAccType, nonOperateIncAccCoaControlCompTypeDescription, nonOperateIncAccCoaMainAccName, nonOperateIncAccCoaMainAccBalTypeAccBalType, nonOperateIncAccCoaMainAccDestAccDest, nonOperateIncAccCoaMainAccFundAccFundCode, nonOperateIncAccCoaMainAccTypeAccType, nonOperateIncAccCoaMainCoaControlAccName, nonOperateIncAccCoaSubAccName, nonOperateIncAccCoaSubAccBalTypeAccBalType, nonOperateIncAccCoaSubAccDestAccDest, nonOperateIncAccCoaSubAccFundAccFundCode, nonOperateIncAccCoaSubAccTypeAccType, nonOperateIncAccCoaSubCoaControlAccName, nonOperateIncAccCoaSubCoaMainAccName, nonOperateExpAcc, nonOperateExpAccAccName, nonOperateExpAccAccBalTypeAccBalType, nonOperateExpAccAccCurrencyAccCurrencyName, nonOperateExpAccAccDestAccDest, nonOperateExpAccAccDestCompanyTypeDescription, nonOperateExpAccAccFundAccFundCode, nonOperateExpAccAccSubTypeAccSubType, nonOperateExpAccAccTypeAccType, nonOperateExpAccCoaControlAccName, nonOperateExpAccCoaControlAccBalTypeAccBalType, nonOperateExpAccCoaControlAccDestAccDest, nonOperateExpAccCoaControlAccTypeAccType, nonOperateExpAccCoaControlCompTypeDescription, nonOperateExpAccCoaMainAccName, nonOperateExpAccCoaMainAccBalTypeAccBalType, nonOperateExpAccCoaMainAccDestAccDest, nonOperateExpAccCoaMainAccFundAccFundCode, nonOperateExpAccCoaMainAccTypeAccType, nonOperateExpAccCoaMainCoaControlAccName, nonOperateExpAccCoaSubAccName, nonOperateExpAccCoaSubAccBalTypeAccBalType, nonOperateExpAccCoaSubAccDestAccDest, nonOperateExpAccCoaSubAccFundAccFundCode, nonOperateExpAccCoaSubAccTypeAccType, nonOperateExpAccCoaSubCoaControlAccName, nonOperateExpAccCoaSubCoaMainAccName, prevYearPLAcc, prevYearPLAccAccName, prevYearPLAccAccBalTypeAccBalType, prevYearPLAccAccCurrencyAccCurrencyName, prevYearPLAccAccDestAccDest, prevYearPLAccAccDestCompanyTypeDescription, prevYearPLAccAccFundAccFundCode, prevYearPLAccAccSubTypeAccSubType, prevYearPLAccAccTypeAccType, prevYearPLAccCoaControlAccName, prevYearPLAccCoaControlAccBalTypeAccBalType, prevYearPLAccCoaControlAccDestAccDest, prevYearPLAccCoaControlAccTypeAccType, prevYearPLAccCoaControlCompTypeDescription, prevYearPLAccCoaMainAccName, prevYearPLAccCoaMainAccBalTypeAccBalType, prevYearPLAccCoaMainAccDestAccDest, prevYearPLAccCoaMainAccFundAccFundCode, prevYearPLAccCoaMainAccTypeAccType, prevYearPLAccCoaMainCoaControlAccName, prevYearPLAccCoaSubAccName, prevYearPLAccCoaSubAccBalTypeAccBalType, prevYearPLAccCoaSubAccDestAccDest, prevYearPLAccCoaSubAccFundAccFundCode, prevYearPLAccCoaSubAccTypeAccType, prevYearPLAccCoaSubCoaControlAccName, prevYearPLAccCoaSubCoaMainAccName, currYearPLAcc, currYearPLAccAccName, currYearPLAccAccBalTypeAccBalType, currYearPLAccAccCurrencyAccCurrencyName, currYearPLAccAccDestAccDest, currYearPLAccAccDestCompanyTypeDescription, currYearPLAccAccFundAccFundCode, currYearPLAccAccSubTypeAccSubType, currYearPLAccAccTypeAccType, currYearPLAccCoaControlAccName, currYearPLAccCoaControlAccBalTypeAccBalType, currYearPLAccCoaControlAccDestAccDest, currYearPLAccCoaControlAccTypeAccType, currYearPLAccCoaControlCompTypeDescription, currYearPLAccCoaMainAccName, currYearPLAccCoaMainAccBalTypeAccBalType, currYearPLAccCoaMainAccDestAccDest, currYearPLAccCoaMainAccFundAccFundCode, currYearPLAccCoaMainAccTypeAccType, currYearPLAccCoaMainCoaControlAccName, currYearPLAccCoaSubAccName, currYearPLAccCoaSubAccBalTypeAccBalType, currYearPLAccCoaSubAccDestAccDest, currYearPLAccCoaSubAccFundAccFundCode, currYearPLAccCoaSubAccTypeAccType, currYearPLAccCoaSubCoaControlAccName, currYearPLAccCoaSubCoaMainAccName, chequeCCAcc, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("AccFundAccs", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.AccFundAccs> Select(
                    int? accFundAccsID, 
                    int? accFundID, 
                    string accFundAccFundCode, 
                    int? cashCode, 
                    string cashAccName, 
                    string cashAccBalTypeAccBalType, 
                    string cashAccCurrencyAccCurrencyName, 
                    string cashAccDestAccDest, 
                    string cashAccDestCompanyTypeDescription, 
                    string cashAccFundAccFundCode, 
                    string cashAccSubTypeAccSubType, 
                    string cashAccTypeAccType, 
                    string cashCoaControlAccName, 
                    string cashCoaControlAccBalTypeAccBalType, 
                    string cashCoaControlAccDestAccDest, 
                    string cashCoaControlAccTypeAccType, 
                    string cashCoaControlCompTypeDescription, 
                    string cashCoaMainAccName, 
                    string cashCoaMainAccBalTypeAccBalType, 
                    string cashCoaMainAccDestAccDest, 
                    string cashCoaMainAccFundAccFundCode, 
                    string cashCoaMainAccTypeAccType, 
                    string cashCoaMainCoaControlAccName, 
                    string cashCoaSubAccName, 
                    string cashCoaSubAccBalTypeAccBalType, 
                    string cashCoaSubAccDestAccDest, 
                    string cashCoaSubAccFundAccFundCode, 
                    string cashCoaSubAccTypeAccType, 
                    string cashCoaSubCoaControlAccName, 
                    string cashCoaSubCoaMainAccName, 
                    int? bankCode, 
                    string bankAccName, 
                    string bankAccBalTypeAccBalType, 
                    string bankAccCurrencyAccCurrencyName, 
                    string bankAccDestAccDest, 
                    string bankAccDestCompanyTypeDescription, 
                    string bankAccFundAccFundCode, 
                    string bankAccSubTypeAccSubType, 
                    string bankAccTypeAccType, 
                    string bankCoaControlAccName, 
                    string bankCoaControlAccBalTypeAccBalType, 
                    string bankCoaControlAccDestAccDest, 
                    string bankCoaControlAccTypeAccType, 
                    string bankCoaControlCompTypeDescription, 
                    string bankCoaMainAccName, 
                    string bankCoaMainAccBalTypeAccBalType, 
                    string bankCoaMainAccDestAccDest, 
                    string bankCoaMainAccFundAccFundCode, 
                    string bankCoaMainAccTypeAccType, 
                    string bankCoaMainCoaControlAccName, 
                    string bankCoaSubAccName, 
                    string bankCoaSubAccBalTypeAccBalType, 
                    string bankCoaSubAccDestAccDest, 
                    string bankCoaSubAccFundAccFundCode, 
                    string bankCoaSubAccTypeAccType, 
                    string bankCoaSubCoaControlAccName, 
                    string bankCoaSubCoaMainAccName, 
                    int? advance, 
                    string advanceAccName, 
                    string advanceAccBalTypeAccBalType, 
                    string advanceAccCurrencyAccCurrencyName, 
                    string advanceAccDestAccDest, 
                    string advanceAccDestCompanyTypeDescription, 
                    string advanceAccFundAccFundCode, 
                    string advanceAccSubTypeAccSubType, 
                    string advanceAccTypeAccType, 
                    string advanceCoaControlAccName, 
                    string advanceCoaControlAccBalTypeAccBalType, 
                    string advanceCoaControlAccDestAccDest, 
                    string advanceCoaControlAccTypeAccType, 
                    string advanceCoaControlCompTypeDescription, 
                    string advanceCoaMainAccName, 
                    string advanceCoaMainAccBalTypeAccBalType, 
                    string advanceCoaMainAccDestAccDest, 
                    string advanceCoaMainAccFundAccFundCode, 
                    string advanceCoaMainAccTypeAccType, 
                    string advanceCoaMainCoaControlAccName, 
                    string advanceCoaSubAccName, 
                    string advanceCoaSubAccBalTypeAccBalType, 
                    string advanceCoaSubAccDestAccDest, 
                    string advanceCoaSubAccFundAccFundCode, 
                    string advanceCoaSubAccTypeAccType, 
                    string advanceCoaSubCoaControlAccName, 
                    string advanceCoaSubCoaMainAccName, 
                    int? purAcc, 
                    string purAccAccName, 
                    string purAccAccBalTypeAccBalType, 
                    string purAccAccCurrencyAccCurrencyName, 
                    string purAccAccDestAccDest, 
                    string purAccAccDestCompanyTypeDescription, 
                    string purAccAccFundAccFundCode, 
                    string purAccAccSubTypeAccSubType, 
                    string purAccAccTypeAccType, 
                    string purAccCoaControlAccName, 
                    string purAccCoaControlAccBalTypeAccBalType, 
                    string purAccCoaControlAccDestAccDest, 
                    string purAccCoaControlAccTypeAccType, 
                    string purAccCoaControlCompTypeDescription, 
                    string purAccCoaMainAccName, 
                    string purAccCoaMainAccBalTypeAccBalType, 
                    string purAccCoaMainAccDestAccDest, 
                    string purAccCoaMainAccFundAccFundCode, 
                    string purAccCoaMainAccTypeAccType, 
                    string purAccCoaMainCoaControlAccName, 
                    string purAccCoaSubAccName, 
                    string purAccCoaSubAccBalTypeAccBalType, 
                    string purAccCoaSubAccDestAccDest, 
                    string purAccCoaSubAccFundAccFundCode, 
                    string purAccCoaSubAccTypeAccType, 
                    string purAccCoaSubCoaControlAccName, 
                    string purAccCoaSubCoaMainAccName, 
                    int? saleAcc, 
                    string saleAccAccName, 
                    string saleAccAccBalTypeAccBalType, 
                    string saleAccAccCurrencyAccCurrencyName, 
                    string saleAccAccDestAccDest, 
                    string saleAccAccDestCompanyTypeDescription, 
                    string saleAccAccFundAccFundCode, 
                    string saleAccAccSubTypeAccSubType, 
                    string saleAccAccTypeAccType, 
                    string saleAccCoaControlAccName, 
                    string saleAccCoaControlAccBalTypeAccBalType, 
                    string saleAccCoaControlAccDestAccDest, 
                    string saleAccCoaControlAccTypeAccType, 
                    string saleAccCoaControlCompTypeDescription, 
                    string saleAccCoaMainAccName, 
                    string saleAccCoaMainAccBalTypeAccBalType, 
                    string saleAccCoaMainAccDestAccDest, 
                    string saleAccCoaMainAccFundAccFundCode, 
                    string saleAccCoaMainAccTypeAccType, 
                    string saleAccCoaMainCoaControlAccName, 
                    string saleAccCoaSubAccName, 
                    string saleAccCoaSubAccBalTypeAccBalType, 
                    string saleAccCoaSubAccDestAccDest, 
                    string saleAccCoaSubAccFundAccFundCode, 
                    string saleAccCoaSubAccTypeAccType, 
                    string saleAccCoaSubCoaControlAccName, 
                    string saleAccCoaSubCoaMainAccName, 
                    int? workinProgressAcc, 
                    string workinProgressAccAccName, 
                    string workinProgressAccAccBalTypeAccBalType, 
                    string workinProgressAccAccCurrencyAccCurrencyName, 
                    string workinProgressAccAccDestAccDest, 
                    string workinProgressAccAccDestCompanyTypeDescription, 
                    string workinProgressAccAccFundAccFundCode, 
                    string workinProgressAccAccSubTypeAccSubType, 
                    string workinProgressAccAccTypeAccType, 
                    string workinProgressAccCoaControlAccName, 
                    string workinProgressAccCoaControlAccBalTypeAccBalType, 
                    string workinProgressAccCoaControlAccDestAccDest, 
                    string workinProgressAccCoaControlAccTypeAccType, 
                    string workinProgressAccCoaControlCompTypeDescription, 
                    string workinProgressAccCoaMainAccName, 
                    string workinProgressAccCoaMainAccBalTypeAccBalType, 
                    string workinProgressAccCoaMainAccDestAccDest, 
                    string workinProgressAccCoaMainAccFundAccFundCode, 
                    string workinProgressAccCoaMainAccTypeAccType, 
                    string workinProgressAccCoaMainCoaControlAccName, 
                    string workinProgressAccCoaSubAccName, 
                    string workinProgressAccCoaSubAccBalTypeAccBalType, 
                    string workinProgressAccCoaSubAccDestAccDest, 
                    string workinProgressAccCoaSubAccFundAccFundCode, 
                    string workinProgressAccCoaSubAccTypeAccType, 
                    string workinProgressAccCoaSubCoaControlAccName, 
                    string workinProgressAccCoaSubCoaMainAccName, 
                    int? costofSold, 
                    string costofSoldAccName, 
                    string costofSoldAccBalTypeAccBalType, 
                    string costofSoldAccCurrencyAccCurrencyName, 
                    string costofSoldAccDestAccDest, 
                    string costofSoldAccDestCompanyTypeDescription, 
                    string costofSoldAccFundAccFundCode, 
                    string costofSoldAccSubTypeAccSubType, 
                    string costofSoldAccTypeAccType, 
                    string costofSoldCoaControlAccName, 
                    string costofSoldCoaControlAccBalTypeAccBalType, 
                    string costofSoldCoaControlAccDestAccDest, 
                    string costofSoldCoaControlAccTypeAccType, 
                    string costofSoldCoaControlCompTypeDescription, 
                    string costofSoldCoaMainAccName, 
                    string costofSoldCoaMainAccBalTypeAccBalType, 
                    string costofSoldCoaMainAccDestAccDest, 
                    string costofSoldCoaMainAccFundAccFundCode, 
                    string costofSoldCoaMainAccTypeAccType, 
                    string costofSoldCoaMainCoaControlAccName, 
                    string costofSoldCoaSubAccName, 
                    string costofSoldCoaSubAccBalTypeAccBalType, 
                    string costofSoldCoaSubAccDestAccDest, 
                    string costofSoldCoaSubAccFundAccFundCode, 
                    string costofSoldCoaSubAccTypeAccType, 
                    string costofSoldCoaSubCoaControlAccName, 
                    string costofSoldCoaSubCoaMainAccName, 
                    int? oPD_Acc, 
                    string oPD_AccAccName, 
                    string oPD_AccAccBalTypeAccBalType, 
                    string oPD_AccAccCurrencyAccCurrencyName, 
                    string oPD_AccAccDestAccDest, 
                    string oPD_AccAccDestCompanyTypeDescription, 
                    string oPD_AccAccFundAccFundCode, 
                    string oPD_AccAccSubTypeAccSubType, 
                    string oPD_AccAccTypeAccType, 
                    string oPD_AccCoaControlAccName, 
                    string oPD_AccCoaControlAccBalTypeAccBalType, 
                    string oPD_AccCoaControlAccDestAccDest, 
                    string oPD_AccCoaControlAccTypeAccType, 
                    string oPD_AccCoaControlCompTypeDescription, 
                    string oPD_AccCoaMainAccName, 
                    string oPD_AccCoaMainAccBalTypeAccBalType, 
                    string oPD_AccCoaMainAccDestAccDest, 
                    string oPD_AccCoaMainAccFundAccFundCode, 
                    string oPD_AccCoaMainAccTypeAccType, 
                    string oPD_AccCoaMainCoaControlAccName, 
                    string oPD_AccCoaSubAccName, 
                    string oPD_AccCoaSubAccBalTypeAccBalType, 
                    string oPD_AccCoaSubAccDestAccDest, 
                    string oPD_AccCoaSubAccFundAccFundCode, 
                    string oPD_AccCoaSubAccTypeAccType, 
                    string oPD_AccCoaSubCoaControlAccName, 
                    string oPD_AccCoaSubCoaMainAccName, 
                    int? advPat_Acc, 
                    string advPat_AccAccName, 
                    string advPat_AccAccBalTypeAccBalType, 
                    string advPat_AccAccCurrencyAccCurrencyName, 
                    string advPat_AccAccDestAccDest, 
                    string advPat_AccAccDestCompanyTypeDescription, 
                    string advPat_AccAccFundAccFundCode, 
                    string advPat_AccAccSubTypeAccSubType, 
                    string advPat_AccAccTypeAccType, 
                    string advPat_AccCoaControlAccName, 
                    string advPat_AccCoaControlAccBalTypeAccBalType, 
                    string advPat_AccCoaControlAccDestAccDest, 
                    string advPat_AccCoaControlAccTypeAccType, 
                    string advPat_AccCoaControlCompTypeDescription, 
                    string advPat_AccCoaMainAccName, 
                    string advPat_AccCoaMainAccBalTypeAccBalType, 
                    string advPat_AccCoaMainAccDestAccDest, 
                    string advPat_AccCoaMainAccFundAccFundCode, 
                    string advPat_AccCoaMainAccTypeAccType, 
                    string advPat_AccCoaMainCoaControlAccName, 
                    string advPat_AccCoaSubAccName, 
                    string advPat_AccCoaSubAccBalTypeAccBalType, 
                    string advPat_AccCoaSubAccDestAccDest, 
                    string advPat_AccCoaSubAccFundAccFundCode, 
                    string advPat_AccCoaSubAccTypeAccType, 
                    string advPat_AccCoaSubCoaControlAccName, 
                    string advPat_AccCoaSubCoaMainAccName, 
                    int? investigate_Acc, 
                    string investigate_AccAccName, 
                    string investigate_AccAccBalTypeAccBalType, 
                    string investigate_AccAccCurrencyAccCurrencyName, 
                    string investigate_AccAccDestAccDest, 
                    string investigate_AccAccDestCompanyTypeDescription, 
                    string investigate_AccAccFundAccFundCode, 
                    string investigate_AccAccSubTypeAccSubType, 
                    string investigate_AccAccTypeAccType, 
                    string investigate_AccCoaControlAccName, 
                    string investigate_AccCoaControlAccBalTypeAccBalType, 
                    string investigate_AccCoaControlAccDestAccDest, 
                    string investigate_AccCoaControlAccTypeAccType, 
                    string investigate_AccCoaControlCompTypeDescription, 
                    string investigate_AccCoaMainAccName, 
                    string investigate_AccCoaMainAccBalTypeAccBalType, 
                    string investigate_AccCoaMainAccDestAccDest, 
                    string investigate_AccCoaMainAccFundAccFundCode, 
                    string investigate_AccCoaMainAccTypeAccType, 
                    string investigate_AccCoaMainCoaControlAccName, 
                    string investigate_AccCoaSubAccName, 
                    string investigate_AccCoaSubAccBalTypeAccBalType, 
                    string investigate_AccCoaSubAccDestAccDest, 
                    string investigate_AccCoaSubAccFundAccFundCode, 
                    string investigate_AccCoaSubAccTypeAccType, 
                    string investigate_AccCoaSubCoaControlAccName, 
                    string investigate_AccCoaSubCoaMainAccName, 
                    int? vatAcc, 
                    string vatAccAccName, 
                    string vatAccAccBalTypeAccBalType, 
                    string vatAccAccCurrencyAccCurrencyName, 
                    string vatAccAccDestAccDest, 
                    string vatAccAccDestCompanyTypeDescription, 
                    string vatAccAccFundAccFundCode, 
                    string vatAccAccSubTypeAccSubType, 
                    string vatAccAccTypeAccType, 
                    string vatAccCoaControlAccName, 
                    string vatAccCoaControlAccBalTypeAccBalType, 
                    string vatAccCoaControlAccDestAccDest, 
                    string vatAccCoaControlAccTypeAccType, 
                    string vatAccCoaControlCompTypeDescription, 
                    string vatAccCoaMainAccName, 
                    string vatAccCoaMainAccBalTypeAccBalType, 
                    string vatAccCoaMainAccDestAccDest, 
                    string vatAccCoaMainAccFundAccFundCode, 
                    string vatAccCoaMainAccTypeAccType, 
                    string vatAccCoaMainCoaControlAccName, 
                    string vatAccCoaSubAccName, 
                    string vatAccCoaSubAccBalTypeAccBalType, 
                    string vatAccCoaSubAccDestAccDest, 
                    string vatAccCoaSubAccFundAccFundCode, 
                    string vatAccCoaSubAccTypeAccType, 
                    string vatAccCoaSubCoaControlAccName, 
                    string vatAccCoaSubCoaMainAccName, 
                    int? sundryDebitors, 
                    string sundryDebitorsAccName, 
                    string sundryDebitorsAccBalTypeAccBalType, 
                    string sundryDebitorsAccCurrencyAccCurrencyName, 
                    string sundryDebitorsAccDestAccDest, 
                    string sundryDebitorsAccDestCompanyTypeDescription, 
                    string sundryDebitorsAccFundAccFundCode, 
                    string sundryDebitorsAccSubTypeAccSubType, 
                    string sundryDebitorsAccTypeAccType, 
                    string sundryDebitorsCoaControlAccName, 
                    string sundryDebitorsCoaControlAccBalTypeAccBalType, 
                    string sundryDebitorsCoaControlAccDestAccDest, 
                    string sundryDebitorsCoaControlAccTypeAccType, 
                    string sundryDebitorsCoaControlCompTypeDescription, 
                    string sundryDebitorsCoaMainAccName, 
                    string sundryDebitorsCoaMainAccBalTypeAccBalType, 
                    string sundryDebitorsCoaMainAccDestAccDest, 
                    string sundryDebitorsCoaMainAccFundAccFundCode, 
                    string sundryDebitorsCoaMainAccTypeAccType, 
                    string sundryDebitorsCoaMainCoaControlAccName, 
                    string sundryDebitorsCoaSubAccName, 
                    string sundryDebitorsCoaSubAccBalTypeAccBalType, 
                    string sundryDebitorsCoaSubAccDestAccDest, 
                    string sundryDebitorsCoaSubAccFundAccFundCode, 
                    string sundryDebitorsCoaSubAccTypeAccType, 
                    string sundryDebitorsCoaSubCoaControlAccName, 
                    string sundryDebitorsCoaSubCoaMainAccName, 
                    int? sundryCreditors, 
                    string sundryCreditorsAccName, 
                    string sundryCreditorsAccBalTypeAccBalType, 
                    string sundryCreditorsAccCurrencyAccCurrencyName, 
                    string sundryCreditorsAccDestAccDest, 
                    string sundryCreditorsAccDestCompanyTypeDescription, 
                    string sundryCreditorsAccFundAccFundCode, 
                    string sundryCreditorsAccSubTypeAccSubType, 
                    string sundryCreditorsAccTypeAccType, 
                    string sundryCreditorsCoaControlAccName, 
                    string sundryCreditorsCoaControlAccBalTypeAccBalType, 
                    string sundryCreditorsCoaControlAccDestAccDest, 
                    string sundryCreditorsCoaControlAccTypeAccType, 
                    string sundryCreditorsCoaControlCompTypeDescription, 
                    string sundryCreditorsCoaMainAccName, 
                    string sundryCreditorsCoaMainAccBalTypeAccBalType, 
                    string sundryCreditorsCoaMainAccDestAccDest, 
                    string sundryCreditorsCoaMainAccFundAccFundCode, 
                    string sundryCreditorsCoaMainAccTypeAccType, 
                    string sundryCreditorsCoaMainCoaControlAccName, 
                    string sundryCreditorsCoaSubAccName, 
                    string sundryCreditorsCoaSubAccBalTypeAccBalType, 
                    string sundryCreditorsCoaSubAccDestAccDest, 
                    string sundryCreditorsCoaSubAccFundAccFundCode, 
                    string sundryCreditorsCoaSubAccTypeAccType, 
                    string sundryCreditorsCoaSubCoaControlAccName, 
                    string sundryCreditorsCoaSubCoaMainAccName, 
                    int? rawMatAcc, 
                    string rawMatAccAccName, 
                    string rawMatAccAccBalTypeAccBalType, 
                    string rawMatAccAccCurrencyAccCurrencyName, 
                    string rawMatAccAccDestAccDest, 
                    string rawMatAccAccDestCompanyTypeDescription, 
                    string rawMatAccAccFundAccFundCode, 
                    string rawMatAccAccSubTypeAccSubType, 
                    string rawMatAccAccTypeAccType, 
                    string rawMatAccCoaControlAccName, 
                    string rawMatAccCoaControlAccBalTypeAccBalType, 
                    string rawMatAccCoaControlAccDestAccDest, 
                    string rawMatAccCoaControlAccTypeAccType, 
                    string rawMatAccCoaControlCompTypeDescription, 
                    string rawMatAccCoaMainAccName, 
                    string rawMatAccCoaMainAccBalTypeAccBalType, 
                    string rawMatAccCoaMainAccDestAccDest, 
                    string rawMatAccCoaMainAccFundAccFundCode, 
                    string rawMatAccCoaMainAccTypeAccType, 
                    string rawMatAccCoaMainCoaControlAccName, 
                    string rawMatAccCoaSubAccName, 
                    string rawMatAccCoaSubAccBalTypeAccBalType, 
                    string rawMatAccCoaSubAccDestAccDest, 
                    string rawMatAccCoaSubAccFundAccFundCode, 
                    string rawMatAccCoaSubAccTypeAccType, 
                    string rawMatAccCoaSubCoaControlAccName, 
                    string rawMatAccCoaSubCoaMainAccName, 
                    int? packMatAcc, 
                    string packMatAccAccName, 
                    string packMatAccAccBalTypeAccBalType, 
                    string packMatAccAccCurrencyAccCurrencyName, 
                    string packMatAccAccDestAccDest, 
                    string packMatAccAccDestCompanyTypeDescription, 
                    string packMatAccAccFundAccFundCode, 
                    string packMatAccAccSubTypeAccSubType, 
                    string packMatAccAccTypeAccType, 
                    string packMatAccCoaControlAccName, 
                    string packMatAccCoaControlAccBalTypeAccBalType, 
                    string packMatAccCoaControlAccDestAccDest, 
                    string packMatAccCoaControlAccTypeAccType, 
                    string packMatAccCoaControlCompTypeDescription, 
                    string packMatAccCoaMainAccName, 
                    string packMatAccCoaMainAccBalTypeAccBalType, 
                    string packMatAccCoaMainAccDestAccDest, 
                    string packMatAccCoaMainAccFundAccFundCode, 
                    string packMatAccCoaMainAccTypeAccType, 
                    string packMatAccCoaMainCoaControlAccName, 
                    string packMatAccCoaSubAccName, 
                    string packMatAccCoaSubAccBalTypeAccBalType, 
                    string packMatAccCoaSubAccDestAccDest, 
                    string packMatAccCoaSubAccFundAccFundCode, 
                    string packMatAccCoaSubAccTypeAccType, 
                    string packMatAccCoaSubCoaControlAccName, 
                    string packMatAccCoaSubCoaMainAccName, 
                    int? otherMatAcc, 
                    string otherMatAccAccName, 
                    string otherMatAccAccBalTypeAccBalType, 
                    string otherMatAccAccCurrencyAccCurrencyName, 
                    string otherMatAccAccDestAccDest, 
                    string otherMatAccAccDestCompanyTypeDescription, 
                    string otherMatAccAccFundAccFundCode, 
                    string otherMatAccAccSubTypeAccSubType, 
                    string otherMatAccAccTypeAccType, 
                    string otherMatAccCoaControlAccName, 
                    string otherMatAccCoaControlAccBalTypeAccBalType, 
                    string otherMatAccCoaControlAccDestAccDest, 
                    string otherMatAccCoaControlAccTypeAccType, 
                    string otherMatAccCoaControlCompTypeDescription, 
                    string otherMatAccCoaMainAccName, 
                    string otherMatAccCoaMainAccBalTypeAccBalType, 
                    string otherMatAccCoaMainAccDestAccDest, 
                    string otherMatAccCoaMainAccFundAccFundCode, 
                    string otherMatAccCoaMainAccTypeAccType, 
                    string otherMatAccCoaMainCoaControlAccName, 
                    string otherMatAccCoaSubAccName, 
                    string otherMatAccCoaSubAccBalTypeAccBalType, 
                    string otherMatAccCoaSubAccDestAccDest, 
                    string otherMatAccCoaSubAccFundAccFundCode, 
                    string otherMatAccCoaSubAccTypeAccType, 
                    string otherMatAccCoaSubCoaControlAccName, 
                    string otherMatAccCoaSubCoaMainAccName, 
                    int? finishMatAcc, 
                    string finishMatAccAccName, 
                    string finishMatAccAccBalTypeAccBalType, 
                    string finishMatAccAccCurrencyAccCurrencyName, 
                    string finishMatAccAccDestAccDest, 
                    string finishMatAccAccDestCompanyTypeDescription, 
                    string finishMatAccAccFundAccFundCode, 
                    string finishMatAccAccSubTypeAccSubType, 
                    string finishMatAccAccTypeAccType, 
                    string finishMatAccCoaControlAccName, 
                    string finishMatAccCoaControlAccBalTypeAccBalType, 
                    string finishMatAccCoaControlAccDestAccDest, 
                    string finishMatAccCoaControlAccTypeAccType, 
                    string finishMatAccCoaControlCompTypeDescription, 
                    string finishMatAccCoaMainAccName, 
                    string finishMatAccCoaMainAccBalTypeAccBalType, 
                    string finishMatAccCoaMainAccDestAccDest, 
                    string finishMatAccCoaMainAccFundAccFundCode, 
                    string finishMatAccCoaMainAccTypeAccType, 
                    string finishMatAccCoaMainCoaControlAccName, 
                    string finishMatAccCoaSubAccName, 
                    string finishMatAccCoaSubAccBalTypeAccBalType, 
                    string finishMatAccCoaSubAccDestAccDest, 
                    string finishMatAccCoaSubAccFundAccFundCode, 
                    string finishMatAccCoaSubAccTypeAccType, 
                    string finishMatAccCoaSubCoaControlAccName, 
                    string finishMatAccCoaSubCoaMainAccName, 
                    int? adminExpAcc, 
                    string adminExpAccAccName, 
                    string adminExpAccAccBalTypeAccBalType, 
                    string adminExpAccAccCurrencyAccCurrencyName, 
                    string adminExpAccAccDestAccDest, 
                    string adminExpAccAccDestCompanyTypeDescription, 
                    string adminExpAccAccFundAccFundCode, 
                    string adminExpAccAccSubTypeAccSubType, 
                    string adminExpAccAccTypeAccType, 
                    string adminExpAccCoaControlAccName, 
                    string adminExpAccCoaControlAccBalTypeAccBalType, 
                    string adminExpAccCoaControlAccDestAccDest, 
                    string adminExpAccCoaControlAccTypeAccType, 
                    string adminExpAccCoaControlCompTypeDescription, 
                    string adminExpAccCoaMainAccName, 
                    string adminExpAccCoaMainAccBalTypeAccBalType, 
                    string adminExpAccCoaMainAccDestAccDest, 
                    string adminExpAccCoaMainAccFundAccFundCode, 
                    string adminExpAccCoaMainAccTypeAccType, 
                    string adminExpAccCoaMainCoaControlAccName, 
                    string adminExpAccCoaSubAccName, 
                    string adminExpAccCoaSubAccBalTypeAccBalType, 
                    string adminExpAccCoaSubAccDestAccDest, 
                    string adminExpAccCoaSubAccFundAccFundCode, 
                    string adminExpAccCoaSubAccTypeAccType, 
                    string adminExpAccCoaSubCoaControlAccName, 
                    string adminExpAccCoaSubCoaMainAccName, 
                    int? sellingExpAcc, 
                    string sellingExpAccAccName, 
                    string sellingExpAccAccBalTypeAccBalType, 
                    string sellingExpAccAccCurrencyAccCurrencyName, 
                    string sellingExpAccAccDestAccDest, 
                    string sellingExpAccAccDestCompanyTypeDescription, 
                    string sellingExpAccAccFundAccFundCode, 
                    string sellingExpAccAccSubTypeAccSubType, 
                    string sellingExpAccAccTypeAccType, 
                    string sellingExpAccCoaControlAccName, 
                    string sellingExpAccCoaControlAccBalTypeAccBalType, 
                    string sellingExpAccCoaControlAccDestAccDest, 
                    string sellingExpAccCoaControlAccTypeAccType, 
                    string sellingExpAccCoaControlCompTypeDescription, 
                    string sellingExpAccCoaMainAccName, 
                    string sellingExpAccCoaMainAccBalTypeAccBalType, 
                    string sellingExpAccCoaMainAccDestAccDest, 
                    string sellingExpAccCoaMainAccFundAccFundCode, 
                    string sellingExpAccCoaMainAccTypeAccType, 
                    string sellingExpAccCoaMainCoaControlAccName, 
                    string sellingExpAccCoaSubAccName, 
                    string sellingExpAccCoaSubAccBalTypeAccBalType, 
                    string sellingExpAccCoaSubAccDestAccDest, 
                    string sellingExpAccCoaSubAccFundAccFundCode, 
                    string sellingExpAccCoaSubAccTypeAccType, 
                    string sellingExpAccCoaSubCoaControlAccName, 
                    string sellingExpAccCoaSubCoaMainAccName, 
                    int? manuExpAcc, 
                    string manuExpAccAccName, 
                    string manuExpAccAccBalTypeAccBalType, 
                    string manuExpAccAccCurrencyAccCurrencyName, 
                    string manuExpAccAccDestAccDest, 
                    string manuExpAccAccDestCompanyTypeDescription, 
                    string manuExpAccAccFundAccFundCode, 
                    string manuExpAccAccSubTypeAccSubType, 
                    string manuExpAccAccTypeAccType, 
                    string manuExpAccCoaControlAccName, 
                    string manuExpAccCoaControlAccBalTypeAccBalType, 
                    string manuExpAccCoaControlAccDestAccDest, 
                    string manuExpAccCoaControlAccTypeAccType, 
                    string manuExpAccCoaControlCompTypeDescription, 
                    string manuExpAccCoaMainAccName, 
                    string manuExpAccCoaMainAccBalTypeAccBalType, 
                    string manuExpAccCoaMainAccDestAccDest, 
                    string manuExpAccCoaMainAccFundAccFundCode, 
                    string manuExpAccCoaMainAccTypeAccType, 
                    string manuExpAccCoaMainCoaControlAccName, 
                    string manuExpAccCoaSubAccName, 
                    string manuExpAccCoaSubAccBalTypeAccBalType, 
                    string manuExpAccCoaSubAccDestAccDest, 
                    string manuExpAccCoaSubAccFundAccFundCode, 
                    string manuExpAccCoaSubAccTypeAccType, 
                    string manuExpAccCoaSubCoaControlAccName, 
                    string manuExpAccCoaSubCoaMainAccName, 
                    int? loanAcc, 
                    string loanAccAccName, 
                    string loanAccAccBalTypeAccBalType, 
                    string loanAccAccCurrencyAccCurrencyName, 
                    string loanAccAccDestAccDest, 
                    string loanAccAccDestCompanyTypeDescription, 
                    string loanAccAccFundAccFundCode, 
                    string loanAccAccSubTypeAccSubType, 
                    string loanAccAccTypeAccType, 
                    string loanAccCoaControlAccName, 
                    string loanAccCoaControlAccBalTypeAccBalType, 
                    string loanAccCoaControlAccDestAccDest, 
                    string loanAccCoaControlAccTypeAccType, 
                    string loanAccCoaControlCompTypeDescription, 
                    string loanAccCoaMainAccName, 
                    string loanAccCoaMainAccBalTypeAccBalType, 
                    string loanAccCoaMainAccDestAccDest, 
                    string loanAccCoaMainAccFundAccFundCode, 
                    string loanAccCoaMainAccTypeAccType, 
                    string loanAccCoaMainCoaControlAccName, 
                    string loanAccCoaSubAccName, 
                    string loanAccCoaSubAccBalTypeAccBalType, 
                    string loanAccCoaSubAccDestAccDest, 
                    string loanAccCoaSubAccFundAccFundCode, 
                    string loanAccCoaSubAccTypeAccType, 
                    string loanAccCoaSubCoaControlAccName, 
                    string loanAccCoaSubCoaMainAccName, 
                    int? assetDepAcc, 
                    string assetDepAccAccName, 
                    string assetDepAccAccBalTypeAccBalType, 
                    string assetDepAccAccCurrencyAccCurrencyName, 
                    string assetDepAccAccDestAccDest, 
                    string assetDepAccAccDestCompanyTypeDescription, 
                    string assetDepAccAccFundAccFundCode, 
                    string assetDepAccAccSubTypeAccSubType, 
                    string assetDepAccAccTypeAccType, 
                    string assetDepAccCoaControlAccName, 
                    string assetDepAccCoaControlAccBalTypeAccBalType, 
                    string assetDepAccCoaControlAccDestAccDest, 
                    string assetDepAccCoaControlAccTypeAccType, 
                    string assetDepAccCoaControlCompTypeDescription, 
                    string assetDepAccCoaMainAccName, 
                    string assetDepAccCoaMainAccBalTypeAccBalType, 
                    string assetDepAccCoaMainAccDestAccDest, 
                    string assetDepAccCoaMainAccFundAccFundCode, 
                    string assetDepAccCoaMainAccTypeAccType, 
                    string assetDepAccCoaMainCoaControlAccName, 
                    string assetDepAccCoaSubAccName, 
                    string assetDepAccCoaSubAccBalTypeAccBalType, 
                    string assetDepAccCoaSubAccDestAccDest, 
                    string assetDepAccCoaSubAccFundAccFundCode, 
                    string assetDepAccCoaSubAccTypeAccType, 
                    string assetDepAccCoaSubCoaControlAccName, 
                    string assetDepAccCoaSubCoaMainAccName, 
                    int? nonOperateIncAcc, 
                    string nonOperateIncAccAccName, 
                    string nonOperateIncAccAccBalTypeAccBalType, 
                    string nonOperateIncAccAccCurrencyAccCurrencyName, 
                    string nonOperateIncAccAccDestAccDest, 
                    string nonOperateIncAccAccDestCompanyTypeDescription, 
                    string nonOperateIncAccAccFundAccFundCode, 
                    string nonOperateIncAccAccSubTypeAccSubType, 
                    string nonOperateIncAccAccTypeAccType, 
                    string nonOperateIncAccCoaControlAccName, 
                    string nonOperateIncAccCoaControlAccBalTypeAccBalType, 
                    string nonOperateIncAccCoaControlAccDestAccDest, 
                    string nonOperateIncAccCoaControlAccTypeAccType, 
                    string nonOperateIncAccCoaControlCompTypeDescription, 
                    string nonOperateIncAccCoaMainAccName, 
                    string nonOperateIncAccCoaMainAccBalTypeAccBalType, 
                    string nonOperateIncAccCoaMainAccDestAccDest, 
                    string nonOperateIncAccCoaMainAccFundAccFundCode, 
                    string nonOperateIncAccCoaMainAccTypeAccType, 
                    string nonOperateIncAccCoaMainCoaControlAccName, 
                    string nonOperateIncAccCoaSubAccName, 
                    string nonOperateIncAccCoaSubAccBalTypeAccBalType, 
                    string nonOperateIncAccCoaSubAccDestAccDest, 
                    string nonOperateIncAccCoaSubAccFundAccFundCode, 
                    string nonOperateIncAccCoaSubAccTypeAccType, 
                    string nonOperateIncAccCoaSubCoaControlAccName, 
                    string nonOperateIncAccCoaSubCoaMainAccName, 
                    int? nonOperateExpAcc, 
                    string nonOperateExpAccAccName, 
                    string nonOperateExpAccAccBalTypeAccBalType, 
                    string nonOperateExpAccAccCurrencyAccCurrencyName, 
                    string nonOperateExpAccAccDestAccDest, 
                    string nonOperateExpAccAccDestCompanyTypeDescription, 
                    string nonOperateExpAccAccFundAccFundCode, 
                    string nonOperateExpAccAccSubTypeAccSubType, 
                    string nonOperateExpAccAccTypeAccType, 
                    string nonOperateExpAccCoaControlAccName, 
                    string nonOperateExpAccCoaControlAccBalTypeAccBalType, 
                    string nonOperateExpAccCoaControlAccDestAccDest, 
                    string nonOperateExpAccCoaControlAccTypeAccType, 
                    string nonOperateExpAccCoaControlCompTypeDescription, 
                    string nonOperateExpAccCoaMainAccName, 
                    string nonOperateExpAccCoaMainAccBalTypeAccBalType, 
                    string nonOperateExpAccCoaMainAccDestAccDest, 
                    string nonOperateExpAccCoaMainAccFundAccFundCode, 
                    string nonOperateExpAccCoaMainAccTypeAccType, 
                    string nonOperateExpAccCoaMainCoaControlAccName, 
                    string nonOperateExpAccCoaSubAccName, 
                    string nonOperateExpAccCoaSubAccBalTypeAccBalType, 
                    string nonOperateExpAccCoaSubAccDestAccDest, 
                    string nonOperateExpAccCoaSubAccFundAccFundCode, 
                    string nonOperateExpAccCoaSubAccTypeAccType, 
                    string nonOperateExpAccCoaSubCoaControlAccName, 
                    string nonOperateExpAccCoaSubCoaMainAccName, 
                    int? prevYearPLAcc, 
                    string prevYearPLAccAccName, 
                    string prevYearPLAccAccBalTypeAccBalType, 
                    string prevYearPLAccAccCurrencyAccCurrencyName, 
                    string prevYearPLAccAccDestAccDest, 
                    string prevYearPLAccAccDestCompanyTypeDescription, 
                    string prevYearPLAccAccFundAccFundCode, 
                    string prevYearPLAccAccSubTypeAccSubType, 
                    string prevYearPLAccAccTypeAccType, 
                    string prevYearPLAccCoaControlAccName, 
                    string prevYearPLAccCoaControlAccBalTypeAccBalType, 
                    string prevYearPLAccCoaControlAccDestAccDest, 
                    string prevYearPLAccCoaControlAccTypeAccType, 
                    string prevYearPLAccCoaControlCompTypeDescription, 
                    string prevYearPLAccCoaMainAccName, 
                    string prevYearPLAccCoaMainAccBalTypeAccBalType, 
                    string prevYearPLAccCoaMainAccDestAccDest, 
                    string prevYearPLAccCoaMainAccFundAccFundCode, 
                    string prevYearPLAccCoaMainAccTypeAccType, 
                    string prevYearPLAccCoaMainCoaControlAccName, 
                    string prevYearPLAccCoaSubAccName, 
                    string prevYearPLAccCoaSubAccBalTypeAccBalType, 
                    string prevYearPLAccCoaSubAccDestAccDest, 
                    string prevYearPLAccCoaSubAccFundAccFundCode, 
                    string prevYearPLAccCoaSubAccTypeAccType, 
                    string prevYearPLAccCoaSubCoaControlAccName, 
                    string prevYearPLAccCoaSubCoaMainAccName, 
                    int? currYearPLAcc, 
                    string currYearPLAccAccName, 
                    string currYearPLAccAccBalTypeAccBalType, 
                    string currYearPLAccAccCurrencyAccCurrencyName, 
                    string currYearPLAccAccDestAccDest, 
                    string currYearPLAccAccDestCompanyTypeDescription, 
                    string currYearPLAccAccFundAccFundCode, 
                    string currYearPLAccAccSubTypeAccSubType, 
                    string currYearPLAccAccTypeAccType, 
                    string currYearPLAccCoaControlAccName, 
                    string currYearPLAccCoaControlAccBalTypeAccBalType, 
                    string currYearPLAccCoaControlAccDestAccDest, 
                    string currYearPLAccCoaControlAccTypeAccType, 
                    string currYearPLAccCoaControlCompTypeDescription, 
                    string currYearPLAccCoaMainAccName, 
                    string currYearPLAccCoaMainAccBalTypeAccBalType, 
                    string currYearPLAccCoaMainAccDestAccDest, 
                    string currYearPLAccCoaMainAccFundAccFundCode, 
                    string currYearPLAccCoaMainAccTypeAccType, 
                    string currYearPLAccCoaMainCoaControlAccName, 
                    string currYearPLAccCoaSubAccName, 
                    string currYearPLAccCoaSubAccBalTypeAccBalType, 
                    string currYearPLAccCoaSubAccDestAccDest, 
                    string currYearPLAccCoaSubAccFundAccFundCode, 
                    string currYearPLAccCoaSubAccTypeAccType, 
                    string currYearPLAccCoaSubCoaControlAccName, 
                    string currYearPLAccCoaSubCoaMainAccName, 
                    int? chequeCCAcc)
        {
            return Select(accFundAccsID, accFundID, accFundAccFundCode, cashCode, cashAccName, cashAccBalTypeAccBalType, cashAccCurrencyAccCurrencyName, cashAccDestAccDest, cashAccDestCompanyTypeDescription, cashAccFundAccFundCode, cashAccSubTypeAccSubType, cashAccTypeAccType, cashCoaControlAccName, cashCoaControlAccBalTypeAccBalType, cashCoaControlAccDestAccDest, cashCoaControlAccTypeAccType, cashCoaControlCompTypeDescription, cashCoaMainAccName, cashCoaMainAccBalTypeAccBalType, cashCoaMainAccDestAccDest, cashCoaMainAccFundAccFundCode, cashCoaMainAccTypeAccType, cashCoaMainCoaControlAccName, cashCoaSubAccName, cashCoaSubAccBalTypeAccBalType, cashCoaSubAccDestAccDest, cashCoaSubAccFundAccFundCode, cashCoaSubAccTypeAccType, cashCoaSubCoaControlAccName, cashCoaSubCoaMainAccName, bankCode, bankAccName, bankAccBalTypeAccBalType, bankAccCurrencyAccCurrencyName, bankAccDestAccDest, bankAccDestCompanyTypeDescription, bankAccFundAccFundCode, bankAccSubTypeAccSubType, bankAccTypeAccType, bankCoaControlAccName, bankCoaControlAccBalTypeAccBalType, bankCoaControlAccDestAccDest, bankCoaControlAccTypeAccType, bankCoaControlCompTypeDescription, bankCoaMainAccName, bankCoaMainAccBalTypeAccBalType, bankCoaMainAccDestAccDest, bankCoaMainAccFundAccFundCode, bankCoaMainAccTypeAccType, bankCoaMainCoaControlAccName, bankCoaSubAccName, bankCoaSubAccBalTypeAccBalType, bankCoaSubAccDestAccDest, bankCoaSubAccFundAccFundCode, bankCoaSubAccTypeAccType, bankCoaSubCoaControlAccName, bankCoaSubCoaMainAccName, advance, advanceAccName, advanceAccBalTypeAccBalType, advanceAccCurrencyAccCurrencyName, advanceAccDestAccDest, advanceAccDestCompanyTypeDescription, advanceAccFundAccFundCode, advanceAccSubTypeAccSubType, advanceAccTypeAccType, advanceCoaControlAccName, advanceCoaControlAccBalTypeAccBalType, advanceCoaControlAccDestAccDest, advanceCoaControlAccTypeAccType, advanceCoaControlCompTypeDescription, advanceCoaMainAccName, advanceCoaMainAccBalTypeAccBalType, advanceCoaMainAccDestAccDest, advanceCoaMainAccFundAccFundCode, advanceCoaMainAccTypeAccType, advanceCoaMainCoaControlAccName, advanceCoaSubAccName, advanceCoaSubAccBalTypeAccBalType, advanceCoaSubAccDestAccDest, advanceCoaSubAccFundAccFundCode, advanceCoaSubAccTypeAccType, advanceCoaSubCoaControlAccName, advanceCoaSubCoaMainAccName, purAcc, purAccAccName, purAccAccBalTypeAccBalType, purAccAccCurrencyAccCurrencyName, purAccAccDestAccDest, purAccAccDestCompanyTypeDescription, purAccAccFundAccFundCode, purAccAccSubTypeAccSubType, purAccAccTypeAccType, purAccCoaControlAccName, purAccCoaControlAccBalTypeAccBalType, purAccCoaControlAccDestAccDest, purAccCoaControlAccTypeAccType, purAccCoaControlCompTypeDescription, purAccCoaMainAccName, purAccCoaMainAccBalTypeAccBalType, purAccCoaMainAccDestAccDest, purAccCoaMainAccFundAccFundCode, purAccCoaMainAccTypeAccType, purAccCoaMainCoaControlAccName, purAccCoaSubAccName, purAccCoaSubAccBalTypeAccBalType, purAccCoaSubAccDestAccDest, purAccCoaSubAccFundAccFundCode, purAccCoaSubAccTypeAccType, purAccCoaSubCoaControlAccName, purAccCoaSubCoaMainAccName, saleAcc, saleAccAccName, saleAccAccBalTypeAccBalType, saleAccAccCurrencyAccCurrencyName, saleAccAccDestAccDest, saleAccAccDestCompanyTypeDescription, saleAccAccFundAccFundCode, saleAccAccSubTypeAccSubType, saleAccAccTypeAccType, saleAccCoaControlAccName, saleAccCoaControlAccBalTypeAccBalType, saleAccCoaControlAccDestAccDest, saleAccCoaControlAccTypeAccType, saleAccCoaControlCompTypeDescription, saleAccCoaMainAccName, saleAccCoaMainAccBalTypeAccBalType, saleAccCoaMainAccDestAccDest, saleAccCoaMainAccFundAccFundCode, saleAccCoaMainAccTypeAccType, saleAccCoaMainCoaControlAccName, saleAccCoaSubAccName, saleAccCoaSubAccBalTypeAccBalType, saleAccCoaSubAccDestAccDest, saleAccCoaSubAccFundAccFundCode, saleAccCoaSubAccTypeAccType, saleAccCoaSubCoaControlAccName, saleAccCoaSubCoaMainAccName, workinProgressAcc, workinProgressAccAccName, workinProgressAccAccBalTypeAccBalType, workinProgressAccAccCurrencyAccCurrencyName, workinProgressAccAccDestAccDest, workinProgressAccAccDestCompanyTypeDescription, workinProgressAccAccFundAccFundCode, workinProgressAccAccSubTypeAccSubType, workinProgressAccAccTypeAccType, workinProgressAccCoaControlAccName, workinProgressAccCoaControlAccBalTypeAccBalType, workinProgressAccCoaControlAccDestAccDest, workinProgressAccCoaControlAccTypeAccType, workinProgressAccCoaControlCompTypeDescription, workinProgressAccCoaMainAccName, workinProgressAccCoaMainAccBalTypeAccBalType, workinProgressAccCoaMainAccDestAccDest, workinProgressAccCoaMainAccFundAccFundCode, workinProgressAccCoaMainAccTypeAccType, workinProgressAccCoaMainCoaControlAccName, workinProgressAccCoaSubAccName, workinProgressAccCoaSubAccBalTypeAccBalType, workinProgressAccCoaSubAccDestAccDest, workinProgressAccCoaSubAccFundAccFundCode, workinProgressAccCoaSubAccTypeAccType, workinProgressAccCoaSubCoaControlAccName, workinProgressAccCoaSubCoaMainAccName, costofSold, costofSoldAccName, costofSoldAccBalTypeAccBalType, costofSoldAccCurrencyAccCurrencyName, costofSoldAccDestAccDest, costofSoldAccDestCompanyTypeDescription, costofSoldAccFundAccFundCode, costofSoldAccSubTypeAccSubType, costofSoldAccTypeAccType, costofSoldCoaControlAccName, costofSoldCoaControlAccBalTypeAccBalType, costofSoldCoaControlAccDestAccDest, costofSoldCoaControlAccTypeAccType, costofSoldCoaControlCompTypeDescription, costofSoldCoaMainAccName, costofSoldCoaMainAccBalTypeAccBalType, costofSoldCoaMainAccDestAccDest, costofSoldCoaMainAccFundAccFundCode, costofSoldCoaMainAccTypeAccType, costofSoldCoaMainCoaControlAccName, costofSoldCoaSubAccName, costofSoldCoaSubAccBalTypeAccBalType, costofSoldCoaSubAccDestAccDest, costofSoldCoaSubAccFundAccFundCode, costofSoldCoaSubAccTypeAccType, costofSoldCoaSubCoaControlAccName, costofSoldCoaSubCoaMainAccName, oPD_Acc, oPD_AccAccName, oPD_AccAccBalTypeAccBalType, oPD_AccAccCurrencyAccCurrencyName, oPD_AccAccDestAccDest, oPD_AccAccDestCompanyTypeDescription, oPD_AccAccFundAccFundCode, oPD_AccAccSubTypeAccSubType, oPD_AccAccTypeAccType, oPD_AccCoaControlAccName, oPD_AccCoaControlAccBalTypeAccBalType, oPD_AccCoaControlAccDestAccDest, oPD_AccCoaControlAccTypeAccType, oPD_AccCoaControlCompTypeDescription, oPD_AccCoaMainAccName, oPD_AccCoaMainAccBalTypeAccBalType, oPD_AccCoaMainAccDestAccDest, oPD_AccCoaMainAccFundAccFundCode, oPD_AccCoaMainAccTypeAccType, oPD_AccCoaMainCoaControlAccName, oPD_AccCoaSubAccName, oPD_AccCoaSubAccBalTypeAccBalType, oPD_AccCoaSubAccDestAccDest, oPD_AccCoaSubAccFundAccFundCode, oPD_AccCoaSubAccTypeAccType, oPD_AccCoaSubCoaControlAccName, oPD_AccCoaSubCoaMainAccName, advPat_Acc, advPat_AccAccName, advPat_AccAccBalTypeAccBalType, advPat_AccAccCurrencyAccCurrencyName, advPat_AccAccDestAccDest, advPat_AccAccDestCompanyTypeDescription, advPat_AccAccFundAccFundCode, advPat_AccAccSubTypeAccSubType, advPat_AccAccTypeAccType, advPat_AccCoaControlAccName, advPat_AccCoaControlAccBalTypeAccBalType, advPat_AccCoaControlAccDestAccDest, advPat_AccCoaControlAccTypeAccType, advPat_AccCoaControlCompTypeDescription, advPat_AccCoaMainAccName, advPat_AccCoaMainAccBalTypeAccBalType, advPat_AccCoaMainAccDestAccDest, advPat_AccCoaMainAccFundAccFundCode, advPat_AccCoaMainAccTypeAccType, advPat_AccCoaMainCoaControlAccName, advPat_AccCoaSubAccName, advPat_AccCoaSubAccBalTypeAccBalType, advPat_AccCoaSubAccDestAccDest, advPat_AccCoaSubAccFundAccFundCode, advPat_AccCoaSubAccTypeAccType, advPat_AccCoaSubCoaControlAccName, advPat_AccCoaSubCoaMainAccName, investigate_Acc, investigate_AccAccName, investigate_AccAccBalTypeAccBalType, investigate_AccAccCurrencyAccCurrencyName, investigate_AccAccDestAccDest, investigate_AccAccDestCompanyTypeDescription, investigate_AccAccFundAccFundCode, investigate_AccAccSubTypeAccSubType, investigate_AccAccTypeAccType, investigate_AccCoaControlAccName, investigate_AccCoaControlAccBalTypeAccBalType, investigate_AccCoaControlAccDestAccDest, investigate_AccCoaControlAccTypeAccType, investigate_AccCoaControlCompTypeDescription, investigate_AccCoaMainAccName, investigate_AccCoaMainAccBalTypeAccBalType, investigate_AccCoaMainAccDestAccDest, investigate_AccCoaMainAccFundAccFundCode, investigate_AccCoaMainAccTypeAccType, investigate_AccCoaMainCoaControlAccName, investigate_AccCoaSubAccName, investigate_AccCoaSubAccBalTypeAccBalType, investigate_AccCoaSubAccDestAccDest, investigate_AccCoaSubAccFundAccFundCode, investigate_AccCoaSubAccTypeAccType, investigate_AccCoaSubCoaControlAccName, investigate_AccCoaSubCoaMainAccName, vatAcc, vatAccAccName, vatAccAccBalTypeAccBalType, vatAccAccCurrencyAccCurrencyName, vatAccAccDestAccDest, vatAccAccDestCompanyTypeDescription, vatAccAccFundAccFundCode, vatAccAccSubTypeAccSubType, vatAccAccTypeAccType, vatAccCoaControlAccName, vatAccCoaControlAccBalTypeAccBalType, vatAccCoaControlAccDestAccDest, vatAccCoaControlAccTypeAccType, vatAccCoaControlCompTypeDescription, vatAccCoaMainAccName, vatAccCoaMainAccBalTypeAccBalType, vatAccCoaMainAccDestAccDest, vatAccCoaMainAccFundAccFundCode, vatAccCoaMainAccTypeAccType, vatAccCoaMainCoaControlAccName, vatAccCoaSubAccName, vatAccCoaSubAccBalTypeAccBalType, vatAccCoaSubAccDestAccDest, vatAccCoaSubAccFundAccFundCode, vatAccCoaSubAccTypeAccType, vatAccCoaSubCoaControlAccName, vatAccCoaSubCoaMainAccName, sundryDebitors, sundryDebitorsAccName, sundryDebitorsAccBalTypeAccBalType, sundryDebitorsAccCurrencyAccCurrencyName, sundryDebitorsAccDestAccDest, sundryDebitorsAccDestCompanyTypeDescription, sundryDebitorsAccFundAccFundCode, sundryDebitorsAccSubTypeAccSubType, sundryDebitorsAccTypeAccType, sundryDebitorsCoaControlAccName, sundryDebitorsCoaControlAccBalTypeAccBalType, sundryDebitorsCoaControlAccDestAccDest, sundryDebitorsCoaControlAccTypeAccType, sundryDebitorsCoaControlCompTypeDescription, sundryDebitorsCoaMainAccName, sundryDebitorsCoaMainAccBalTypeAccBalType, sundryDebitorsCoaMainAccDestAccDest, sundryDebitorsCoaMainAccFundAccFundCode, sundryDebitorsCoaMainAccTypeAccType, sundryDebitorsCoaMainCoaControlAccName, sundryDebitorsCoaSubAccName, sundryDebitorsCoaSubAccBalTypeAccBalType, sundryDebitorsCoaSubAccDestAccDest, sundryDebitorsCoaSubAccFundAccFundCode, sundryDebitorsCoaSubAccTypeAccType, sundryDebitorsCoaSubCoaControlAccName, sundryDebitorsCoaSubCoaMainAccName, sundryCreditors, sundryCreditorsAccName, sundryCreditorsAccBalTypeAccBalType, sundryCreditorsAccCurrencyAccCurrencyName, sundryCreditorsAccDestAccDest, sundryCreditorsAccDestCompanyTypeDescription, sundryCreditorsAccFundAccFundCode, sundryCreditorsAccSubTypeAccSubType, sundryCreditorsAccTypeAccType, sundryCreditorsCoaControlAccName, sundryCreditorsCoaControlAccBalTypeAccBalType, sundryCreditorsCoaControlAccDestAccDest, sundryCreditorsCoaControlAccTypeAccType, sundryCreditorsCoaControlCompTypeDescription, sundryCreditorsCoaMainAccName, sundryCreditorsCoaMainAccBalTypeAccBalType, sundryCreditorsCoaMainAccDestAccDest, sundryCreditorsCoaMainAccFundAccFundCode, sundryCreditorsCoaMainAccTypeAccType, sundryCreditorsCoaMainCoaControlAccName, sundryCreditorsCoaSubAccName, sundryCreditorsCoaSubAccBalTypeAccBalType, sundryCreditorsCoaSubAccDestAccDest, sundryCreditorsCoaSubAccFundAccFundCode, sundryCreditorsCoaSubAccTypeAccType, sundryCreditorsCoaSubCoaControlAccName, sundryCreditorsCoaSubCoaMainAccName, rawMatAcc, rawMatAccAccName, rawMatAccAccBalTypeAccBalType, rawMatAccAccCurrencyAccCurrencyName, rawMatAccAccDestAccDest, rawMatAccAccDestCompanyTypeDescription, rawMatAccAccFundAccFundCode, rawMatAccAccSubTypeAccSubType, rawMatAccAccTypeAccType, rawMatAccCoaControlAccName, rawMatAccCoaControlAccBalTypeAccBalType, rawMatAccCoaControlAccDestAccDest, rawMatAccCoaControlAccTypeAccType, rawMatAccCoaControlCompTypeDescription, rawMatAccCoaMainAccName, rawMatAccCoaMainAccBalTypeAccBalType, rawMatAccCoaMainAccDestAccDest, rawMatAccCoaMainAccFundAccFundCode, rawMatAccCoaMainAccTypeAccType, rawMatAccCoaMainCoaControlAccName, rawMatAccCoaSubAccName, rawMatAccCoaSubAccBalTypeAccBalType, rawMatAccCoaSubAccDestAccDest, rawMatAccCoaSubAccFundAccFundCode, rawMatAccCoaSubAccTypeAccType, rawMatAccCoaSubCoaControlAccName, rawMatAccCoaSubCoaMainAccName, packMatAcc, packMatAccAccName, packMatAccAccBalTypeAccBalType, packMatAccAccCurrencyAccCurrencyName, packMatAccAccDestAccDest, packMatAccAccDestCompanyTypeDescription, packMatAccAccFundAccFundCode, packMatAccAccSubTypeAccSubType, packMatAccAccTypeAccType, packMatAccCoaControlAccName, packMatAccCoaControlAccBalTypeAccBalType, packMatAccCoaControlAccDestAccDest, packMatAccCoaControlAccTypeAccType, packMatAccCoaControlCompTypeDescription, packMatAccCoaMainAccName, packMatAccCoaMainAccBalTypeAccBalType, packMatAccCoaMainAccDestAccDest, packMatAccCoaMainAccFundAccFundCode, packMatAccCoaMainAccTypeAccType, packMatAccCoaMainCoaControlAccName, packMatAccCoaSubAccName, packMatAccCoaSubAccBalTypeAccBalType, packMatAccCoaSubAccDestAccDest, packMatAccCoaSubAccFundAccFundCode, packMatAccCoaSubAccTypeAccType, packMatAccCoaSubCoaControlAccName, packMatAccCoaSubCoaMainAccName, otherMatAcc, otherMatAccAccName, otherMatAccAccBalTypeAccBalType, otherMatAccAccCurrencyAccCurrencyName, otherMatAccAccDestAccDest, otherMatAccAccDestCompanyTypeDescription, otherMatAccAccFundAccFundCode, otherMatAccAccSubTypeAccSubType, otherMatAccAccTypeAccType, otherMatAccCoaControlAccName, otherMatAccCoaControlAccBalTypeAccBalType, otherMatAccCoaControlAccDestAccDest, otherMatAccCoaControlAccTypeAccType, otherMatAccCoaControlCompTypeDescription, otherMatAccCoaMainAccName, otherMatAccCoaMainAccBalTypeAccBalType, otherMatAccCoaMainAccDestAccDest, otherMatAccCoaMainAccFundAccFundCode, otherMatAccCoaMainAccTypeAccType, otherMatAccCoaMainCoaControlAccName, otherMatAccCoaSubAccName, otherMatAccCoaSubAccBalTypeAccBalType, otherMatAccCoaSubAccDestAccDest, otherMatAccCoaSubAccFundAccFundCode, otherMatAccCoaSubAccTypeAccType, otherMatAccCoaSubCoaControlAccName, otherMatAccCoaSubCoaMainAccName, finishMatAcc, finishMatAccAccName, finishMatAccAccBalTypeAccBalType, finishMatAccAccCurrencyAccCurrencyName, finishMatAccAccDestAccDest, finishMatAccAccDestCompanyTypeDescription, finishMatAccAccFundAccFundCode, finishMatAccAccSubTypeAccSubType, finishMatAccAccTypeAccType, finishMatAccCoaControlAccName, finishMatAccCoaControlAccBalTypeAccBalType, finishMatAccCoaControlAccDestAccDest, finishMatAccCoaControlAccTypeAccType, finishMatAccCoaControlCompTypeDescription, finishMatAccCoaMainAccName, finishMatAccCoaMainAccBalTypeAccBalType, finishMatAccCoaMainAccDestAccDest, finishMatAccCoaMainAccFundAccFundCode, finishMatAccCoaMainAccTypeAccType, finishMatAccCoaMainCoaControlAccName, finishMatAccCoaSubAccName, finishMatAccCoaSubAccBalTypeAccBalType, finishMatAccCoaSubAccDestAccDest, finishMatAccCoaSubAccFundAccFundCode, finishMatAccCoaSubAccTypeAccType, finishMatAccCoaSubCoaControlAccName, finishMatAccCoaSubCoaMainAccName, adminExpAcc, adminExpAccAccName, adminExpAccAccBalTypeAccBalType, adminExpAccAccCurrencyAccCurrencyName, adminExpAccAccDestAccDest, adminExpAccAccDestCompanyTypeDescription, adminExpAccAccFundAccFundCode, adminExpAccAccSubTypeAccSubType, adminExpAccAccTypeAccType, adminExpAccCoaControlAccName, adminExpAccCoaControlAccBalTypeAccBalType, adminExpAccCoaControlAccDestAccDest, adminExpAccCoaControlAccTypeAccType, adminExpAccCoaControlCompTypeDescription, adminExpAccCoaMainAccName, adminExpAccCoaMainAccBalTypeAccBalType, adminExpAccCoaMainAccDestAccDest, adminExpAccCoaMainAccFundAccFundCode, adminExpAccCoaMainAccTypeAccType, adminExpAccCoaMainCoaControlAccName, adminExpAccCoaSubAccName, adminExpAccCoaSubAccBalTypeAccBalType, adminExpAccCoaSubAccDestAccDest, adminExpAccCoaSubAccFundAccFundCode, adminExpAccCoaSubAccTypeAccType, adminExpAccCoaSubCoaControlAccName, adminExpAccCoaSubCoaMainAccName, sellingExpAcc, sellingExpAccAccName, sellingExpAccAccBalTypeAccBalType, sellingExpAccAccCurrencyAccCurrencyName, sellingExpAccAccDestAccDest, sellingExpAccAccDestCompanyTypeDescription, sellingExpAccAccFundAccFundCode, sellingExpAccAccSubTypeAccSubType, sellingExpAccAccTypeAccType, sellingExpAccCoaControlAccName, sellingExpAccCoaControlAccBalTypeAccBalType, sellingExpAccCoaControlAccDestAccDest, sellingExpAccCoaControlAccTypeAccType, sellingExpAccCoaControlCompTypeDescription, sellingExpAccCoaMainAccName, sellingExpAccCoaMainAccBalTypeAccBalType, sellingExpAccCoaMainAccDestAccDest, sellingExpAccCoaMainAccFundAccFundCode, sellingExpAccCoaMainAccTypeAccType, sellingExpAccCoaMainCoaControlAccName, sellingExpAccCoaSubAccName, sellingExpAccCoaSubAccBalTypeAccBalType, sellingExpAccCoaSubAccDestAccDest, sellingExpAccCoaSubAccFundAccFundCode, sellingExpAccCoaSubAccTypeAccType, sellingExpAccCoaSubCoaControlAccName, sellingExpAccCoaSubCoaMainAccName, manuExpAcc, manuExpAccAccName, manuExpAccAccBalTypeAccBalType, manuExpAccAccCurrencyAccCurrencyName, manuExpAccAccDestAccDest, manuExpAccAccDestCompanyTypeDescription, manuExpAccAccFundAccFundCode, manuExpAccAccSubTypeAccSubType, manuExpAccAccTypeAccType, manuExpAccCoaControlAccName, manuExpAccCoaControlAccBalTypeAccBalType, manuExpAccCoaControlAccDestAccDest, manuExpAccCoaControlAccTypeAccType, manuExpAccCoaControlCompTypeDescription, manuExpAccCoaMainAccName, manuExpAccCoaMainAccBalTypeAccBalType, manuExpAccCoaMainAccDestAccDest, manuExpAccCoaMainAccFundAccFundCode, manuExpAccCoaMainAccTypeAccType, manuExpAccCoaMainCoaControlAccName, manuExpAccCoaSubAccName, manuExpAccCoaSubAccBalTypeAccBalType, manuExpAccCoaSubAccDestAccDest, manuExpAccCoaSubAccFundAccFundCode, manuExpAccCoaSubAccTypeAccType, manuExpAccCoaSubCoaControlAccName, manuExpAccCoaSubCoaMainAccName, loanAcc, loanAccAccName, loanAccAccBalTypeAccBalType, loanAccAccCurrencyAccCurrencyName, loanAccAccDestAccDest, loanAccAccDestCompanyTypeDescription, loanAccAccFundAccFundCode, loanAccAccSubTypeAccSubType, loanAccAccTypeAccType, loanAccCoaControlAccName, loanAccCoaControlAccBalTypeAccBalType, loanAccCoaControlAccDestAccDest, loanAccCoaControlAccTypeAccType, loanAccCoaControlCompTypeDescription, loanAccCoaMainAccName, loanAccCoaMainAccBalTypeAccBalType, loanAccCoaMainAccDestAccDest, loanAccCoaMainAccFundAccFundCode, loanAccCoaMainAccTypeAccType, loanAccCoaMainCoaControlAccName, loanAccCoaSubAccName, loanAccCoaSubAccBalTypeAccBalType, loanAccCoaSubAccDestAccDest, loanAccCoaSubAccFundAccFundCode, loanAccCoaSubAccTypeAccType, loanAccCoaSubCoaControlAccName, loanAccCoaSubCoaMainAccName, assetDepAcc, assetDepAccAccName, assetDepAccAccBalTypeAccBalType, assetDepAccAccCurrencyAccCurrencyName, assetDepAccAccDestAccDest, assetDepAccAccDestCompanyTypeDescription, assetDepAccAccFundAccFundCode, assetDepAccAccSubTypeAccSubType, assetDepAccAccTypeAccType, assetDepAccCoaControlAccName, assetDepAccCoaControlAccBalTypeAccBalType, assetDepAccCoaControlAccDestAccDest, assetDepAccCoaControlAccTypeAccType, assetDepAccCoaControlCompTypeDescription, assetDepAccCoaMainAccName, assetDepAccCoaMainAccBalTypeAccBalType, assetDepAccCoaMainAccDestAccDest, assetDepAccCoaMainAccFundAccFundCode, assetDepAccCoaMainAccTypeAccType, assetDepAccCoaMainCoaControlAccName, assetDepAccCoaSubAccName, assetDepAccCoaSubAccBalTypeAccBalType, assetDepAccCoaSubAccDestAccDest, assetDepAccCoaSubAccFundAccFundCode, assetDepAccCoaSubAccTypeAccType, assetDepAccCoaSubCoaControlAccName, assetDepAccCoaSubCoaMainAccName, nonOperateIncAcc, nonOperateIncAccAccName, nonOperateIncAccAccBalTypeAccBalType, nonOperateIncAccAccCurrencyAccCurrencyName, nonOperateIncAccAccDestAccDest, nonOperateIncAccAccDestCompanyTypeDescription, nonOperateIncAccAccFundAccFundCode, nonOperateIncAccAccSubTypeAccSubType, nonOperateIncAccAccTypeAccType, nonOperateIncAccCoaControlAccName, nonOperateIncAccCoaControlAccBalTypeAccBalType, nonOperateIncAccCoaControlAccDestAccDest, nonOperateIncAccCoaControlAccTypeAccType, nonOperateIncAccCoaControlCompTypeDescription, nonOperateIncAccCoaMainAccName, nonOperateIncAccCoaMainAccBalTypeAccBalType, nonOperateIncAccCoaMainAccDestAccDest, nonOperateIncAccCoaMainAccFundAccFundCode, nonOperateIncAccCoaMainAccTypeAccType, nonOperateIncAccCoaMainCoaControlAccName, nonOperateIncAccCoaSubAccName, nonOperateIncAccCoaSubAccBalTypeAccBalType, nonOperateIncAccCoaSubAccDestAccDest, nonOperateIncAccCoaSubAccFundAccFundCode, nonOperateIncAccCoaSubAccTypeAccType, nonOperateIncAccCoaSubCoaControlAccName, nonOperateIncAccCoaSubCoaMainAccName, nonOperateExpAcc, nonOperateExpAccAccName, nonOperateExpAccAccBalTypeAccBalType, nonOperateExpAccAccCurrencyAccCurrencyName, nonOperateExpAccAccDestAccDest, nonOperateExpAccAccDestCompanyTypeDescription, nonOperateExpAccAccFundAccFundCode, nonOperateExpAccAccSubTypeAccSubType, nonOperateExpAccAccTypeAccType, nonOperateExpAccCoaControlAccName, nonOperateExpAccCoaControlAccBalTypeAccBalType, nonOperateExpAccCoaControlAccDestAccDest, nonOperateExpAccCoaControlAccTypeAccType, nonOperateExpAccCoaControlCompTypeDescription, nonOperateExpAccCoaMainAccName, nonOperateExpAccCoaMainAccBalTypeAccBalType, nonOperateExpAccCoaMainAccDestAccDest, nonOperateExpAccCoaMainAccFundAccFundCode, nonOperateExpAccCoaMainAccTypeAccType, nonOperateExpAccCoaMainCoaControlAccName, nonOperateExpAccCoaSubAccName, nonOperateExpAccCoaSubAccBalTypeAccBalType, nonOperateExpAccCoaSubAccDestAccDest, nonOperateExpAccCoaSubAccFundAccFundCode, nonOperateExpAccCoaSubAccTypeAccType, nonOperateExpAccCoaSubCoaControlAccName, nonOperateExpAccCoaSubCoaMainAccName, prevYearPLAcc, prevYearPLAccAccName, prevYearPLAccAccBalTypeAccBalType, prevYearPLAccAccCurrencyAccCurrencyName, prevYearPLAccAccDestAccDest, prevYearPLAccAccDestCompanyTypeDescription, prevYearPLAccAccFundAccFundCode, prevYearPLAccAccSubTypeAccSubType, prevYearPLAccAccTypeAccType, prevYearPLAccCoaControlAccName, prevYearPLAccCoaControlAccBalTypeAccBalType, prevYearPLAccCoaControlAccDestAccDest, prevYearPLAccCoaControlAccTypeAccType, prevYearPLAccCoaControlCompTypeDescription, prevYearPLAccCoaMainAccName, prevYearPLAccCoaMainAccBalTypeAccBalType, prevYearPLAccCoaMainAccDestAccDest, prevYearPLAccCoaMainAccFundAccFundCode, prevYearPLAccCoaMainAccTypeAccType, prevYearPLAccCoaMainCoaControlAccName, prevYearPLAccCoaSubAccName, prevYearPLAccCoaSubAccBalTypeAccBalType, prevYearPLAccCoaSubAccDestAccDest, prevYearPLAccCoaSubAccFundAccFundCode, prevYearPLAccCoaSubAccTypeAccType, prevYearPLAccCoaSubCoaControlAccName, prevYearPLAccCoaSubCoaMainAccName, currYearPLAcc, currYearPLAccAccName, currYearPLAccAccBalTypeAccBalType, currYearPLAccAccCurrencyAccCurrencyName, currYearPLAccAccDestAccDest, currYearPLAccAccDestCompanyTypeDescription, currYearPLAccAccFundAccFundCode, currYearPLAccAccSubTypeAccSubType, currYearPLAccAccTypeAccType, currYearPLAccCoaControlAccName, currYearPLAccCoaControlAccBalTypeAccBalType, currYearPLAccCoaControlAccDestAccDest, currYearPLAccCoaControlAccTypeAccType, currYearPLAccCoaControlCompTypeDescription, currYearPLAccCoaMainAccName, currYearPLAccCoaMainAccBalTypeAccBalType, currYearPLAccCoaMainAccDestAccDest, currYearPLAccCoaMainAccFundAccFundCode, currYearPLAccCoaMainAccTypeAccType, currYearPLAccCoaMainCoaControlAccName, currYearPLAccCoaSubAccName, currYearPLAccCoaSubAccBalTypeAccBalType, currYearPLAccCoaSubAccDestAccDest, currYearPLAccCoaSubAccFundAccFundCode, currYearPLAccCoaSubAccTypeAccType, currYearPLAccCoaSubCoaControlAccName, currYearPLAccCoaSubCoaMainAccName, chequeCCAcc, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.AccFundAccs SelectSingle(int? accFundAccsID)
        {
            List<MyCompany.Data.Objects.AccFundAccs> list = Select(accFundAccsID, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.AccFundAccs> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("AccFundAccs", dataView, request);
            return page.ToList<MyCompany.Data.Objects.AccFundAccs>();
        }
        
        public List<MyCompany.Data.Objects.AccFundAccs> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.AccFundAccs> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.AccFundAccs SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.AccFundAccs> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.AccFundAccs theAccFundAccs, MyCompany.Data.Objects.AccFundAccs original_AccFundAccs)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("AccFundAccsID", original_AccFundAccs.AccFundAccsID, theAccFundAccs.AccFundAccsID, true));
            values.Add(new FieldValue("AccFundID", original_AccFundAccs.AccFundID, theAccFundAccs.AccFundID));
            values.Add(new FieldValue("AccFundAccFundCode", original_AccFundAccs.AccFundAccFundCode, theAccFundAccs.AccFundAccFundCode, true));
            values.Add(new FieldValue("CashCode", original_AccFundAccs.CashCode, theAccFundAccs.CashCode));
            values.Add(new FieldValue("CashAccName", original_AccFundAccs.CashAccName, theAccFundAccs.CashAccName, true));
            values.Add(new FieldValue("CashAccBalTypeAccBalType", original_AccFundAccs.CashAccBalTypeAccBalType, theAccFundAccs.CashAccBalTypeAccBalType, true));
            values.Add(new FieldValue("CashAccCurrencyAccCurrencyName", original_AccFundAccs.CashAccCurrencyAccCurrencyName, theAccFundAccs.CashAccCurrencyAccCurrencyName, true));
            values.Add(new FieldValue("CashAccDestAccDest", original_AccFundAccs.CashAccDestAccDest, theAccFundAccs.CashAccDestAccDest, true));
            values.Add(new FieldValue("CashAccDestCompanyTypeDescription", original_AccFundAccs.CashAccDestCompanyTypeDescription, theAccFundAccs.CashAccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("CashAccFundAccFundCode", original_AccFundAccs.CashAccFundAccFundCode, theAccFundAccs.CashAccFundAccFundCode, true));
            values.Add(new FieldValue("CashAccSubTypeAccSubType", original_AccFundAccs.CashAccSubTypeAccSubType, theAccFundAccs.CashAccSubTypeAccSubType, true));
            values.Add(new FieldValue("CashAccTypeAccType", original_AccFundAccs.CashAccTypeAccType, theAccFundAccs.CashAccTypeAccType, true));
            values.Add(new FieldValue("CashCoaControlAccName", original_AccFundAccs.CashCoaControlAccName, theAccFundAccs.CashCoaControlAccName, true));
            values.Add(new FieldValue("CashCoaControlAccBalTypeAccBalType", original_AccFundAccs.CashCoaControlAccBalTypeAccBalType, theAccFundAccs.CashCoaControlAccBalTypeAccBalType, true));
            values.Add(new FieldValue("CashCoaControlAccDestAccDest", original_AccFundAccs.CashCoaControlAccDestAccDest, theAccFundAccs.CashCoaControlAccDestAccDest, true));
            values.Add(new FieldValue("CashCoaControlAccTypeAccType", original_AccFundAccs.CashCoaControlAccTypeAccType, theAccFundAccs.CashCoaControlAccTypeAccType, true));
            values.Add(new FieldValue("CashCoaControlCompTypeDescription", original_AccFundAccs.CashCoaControlCompTypeDescription, theAccFundAccs.CashCoaControlCompTypeDescription, true));
            values.Add(new FieldValue("CashCoaMainAccName", original_AccFundAccs.CashCoaMainAccName, theAccFundAccs.CashCoaMainAccName, true));
            values.Add(new FieldValue("CashCoaMainAccBalTypeAccBalType", original_AccFundAccs.CashCoaMainAccBalTypeAccBalType, theAccFundAccs.CashCoaMainAccBalTypeAccBalType, true));
            values.Add(new FieldValue("CashCoaMainAccDestAccDest", original_AccFundAccs.CashCoaMainAccDestAccDest, theAccFundAccs.CashCoaMainAccDestAccDest, true));
            values.Add(new FieldValue("CashCoaMainAccFundAccFundCode", original_AccFundAccs.CashCoaMainAccFundAccFundCode, theAccFundAccs.CashCoaMainAccFundAccFundCode, true));
            values.Add(new FieldValue("CashCoaMainAccTypeAccType", original_AccFundAccs.CashCoaMainAccTypeAccType, theAccFundAccs.CashCoaMainAccTypeAccType, true));
            values.Add(new FieldValue("CashCoaMainCoaControlAccName", original_AccFundAccs.CashCoaMainCoaControlAccName, theAccFundAccs.CashCoaMainCoaControlAccName, true));
            values.Add(new FieldValue("CashCoaSubAccName", original_AccFundAccs.CashCoaSubAccName, theAccFundAccs.CashCoaSubAccName, true));
            values.Add(new FieldValue("CashCoaSubAccBalTypeAccBalType", original_AccFundAccs.CashCoaSubAccBalTypeAccBalType, theAccFundAccs.CashCoaSubAccBalTypeAccBalType, true));
            values.Add(new FieldValue("CashCoaSubAccDestAccDest", original_AccFundAccs.CashCoaSubAccDestAccDest, theAccFundAccs.CashCoaSubAccDestAccDest, true));
            values.Add(new FieldValue("CashCoaSubAccFundAccFundCode", original_AccFundAccs.CashCoaSubAccFundAccFundCode, theAccFundAccs.CashCoaSubAccFundAccFundCode, true));
            values.Add(new FieldValue("CashCoaSubAccTypeAccType", original_AccFundAccs.CashCoaSubAccTypeAccType, theAccFundAccs.CashCoaSubAccTypeAccType, true));
            values.Add(new FieldValue("CashCoaSubCoaControlAccName", original_AccFundAccs.CashCoaSubCoaControlAccName, theAccFundAccs.CashCoaSubCoaControlAccName, true));
            values.Add(new FieldValue("CashCoaSubCoaMainAccName", original_AccFundAccs.CashCoaSubCoaMainAccName, theAccFundAccs.CashCoaSubCoaMainAccName, true));
            values.Add(new FieldValue("BankCode", original_AccFundAccs.BankCode, theAccFundAccs.BankCode));
            values.Add(new FieldValue("BankAccName", original_AccFundAccs.BankAccName, theAccFundAccs.BankAccName, true));
            values.Add(new FieldValue("BankAccBalTypeAccBalType", original_AccFundAccs.BankAccBalTypeAccBalType, theAccFundAccs.BankAccBalTypeAccBalType, true));
            values.Add(new FieldValue("BankAccCurrencyAccCurrencyName", original_AccFundAccs.BankAccCurrencyAccCurrencyName, theAccFundAccs.BankAccCurrencyAccCurrencyName, true));
            values.Add(new FieldValue("BankAccDestAccDest", original_AccFundAccs.BankAccDestAccDest, theAccFundAccs.BankAccDestAccDest, true));
            values.Add(new FieldValue("BankAccDestCompanyTypeDescription", original_AccFundAccs.BankAccDestCompanyTypeDescription, theAccFundAccs.BankAccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("BankAccFundAccFundCode", original_AccFundAccs.BankAccFundAccFundCode, theAccFundAccs.BankAccFundAccFundCode, true));
            values.Add(new FieldValue("BankAccSubTypeAccSubType", original_AccFundAccs.BankAccSubTypeAccSubType, theAccFundAccs.BankAccSubTypeAccSubType, true));
            values.Add(new FieldValue("BankAccTypeAccType", original_AccFundAccs.BankAccTypeAccType, theAccFundAccs.BankAccTypeAccType, true));
            values.Add(new FieldValue("BankCoaControlAccName", original_AccFundAccs.BankCoaControlAccName, theAccFundAccs.BankCoaControlAccName, true));
            values.Add(new FieldValue("BankCoaControlAccBalTypeAccBalType", original_AccFundAccs.BankCoaControlAccBalTypeAccBalType, theAccFundAccs.BankCoaControlAccBalTypeAccBalType, true));
            values.Add(new FieldValue("BankCoaControlAccDestAccDest", original_AccFundAccs.BankCoaControlAccDestAccDest, theAccFundAccs.BankCoaControlAccDestAccDest, true));
            values.Add(new FieldValue("BankCoaControlAccTypeAccType", original_AccFundAccs.BankCoaControlAccTypeAccType, theAccFundAccs.BankCoaControlAccTypeAccType, true));
            values.Add(new FieldValue("BankCoaControlCompTypeDescription", original_AccFundAccs.BankCoaControlCompTypeDescription, theAccFundAccs.BankCoaControlCompTypeDescription, true));
            values.Add(new FieldValue("BankCoaMainAccName", original_AccFundAccs.BankCoaMainAccName, theAccFundAccs.BankCoaMainAccName, true));
            values.Add(new FieldValue("BankCoaMainAccBalTypeAccBalType", original_AccFundAccs.BankCoaMainAccBalTypeAccBalType, theAccFundAccs.BankCoaMainAccBalTypeAccBalType, true));
            values.Add(new FieldValue("BankCoaMainAccDestAccDest", original_AccFundAccs.BankCoaMainAccDestAccDest, theAccFundAccs.BankCoaMainAccDestAccDest, true));
            values.Add(new FieldValue("BankCoaMainAccFundAccFundCode", original_AccFundAccs.BankCoaMainAccFundAccFundCode, theAccFundAccs.BankCoaMainAccFundAccFundCode, true));
            values.Add(new FieldValue("BankCoaMainAccTypeAccType", original_AccFundAccs.BankCoaMainAccTypeAccType, theAccFundAccs.BankCoaMainAccTypeAccType, true));
            values.Add(new FieldValue("BankCoaMainCoaControlAccName", original_AccFundAccs.BankCoaMainCoaControlAccName, theAccFundAccs.BankCoaMainCoaControlAccName, true));
            values.Add(new FieldValue("BankCoaSubAccName", original_AccFundAccs.BankCoaSubAccName, theAccFundAccs.BankCoaSubAccName, true));
            values.Add(new FieldValue("BankCoaSubAccBalTypeAccBalType", original_AccFundAccs.BankCoaSubAccBalTypeAccBalType, theAccFundAccs.BankCoaSubAccBalTypeAccBalType, true));
            values.Add(new FieldValue("BankCoaSubAccDestAccDest", original_AccFundAccs.BankCoaSubAccDestAccDest, theAccFundAccs.BankCoaSubAccDestAccDest, true));
            values.Add(new FieldValue("BankCoaSubAccFundAccFundCode", original_AccFundAccs.BankCoaSubAccFundAccFundCode, theAccFundAccs.BankCoaSubAccFundAccFundCode, true));
            values.Add(new FieldValue("BankCoaSubAccTypeAccType", original_AccFundAccs.BankCoaSubAccTypeAccType, theAccFundAccs.BankCoaSubAccTypeAccType, true));
            values.Add(new FieldValue("BankCoaSubCoaControlAccName", original_AccFundAccs.BankCoaSubCoaControlAccName, theAccFundAccs.BankCoaSubCoaControlAccName, true));
            values.Add(new FieldValue("BankCoaSubCoaMainAccName", original_AccFundAccs.BankCoaSubCoaMainAccName, theAccFundAccs.BankCoaSubCoaMainAccName, true));
            values.Add(new FieldValue("Advance", original_AccFundAccs.Advance, theAccFundAccs.Advance));
            values.Add(new FieldValue("AdvanceAccName", original_AccFundAccs.AdvanceAccName, theAccFundAccs.AdvanceAccName, true));
            values.Add(new FieldValue("AdvanceAccBalTypeAccBalType", original_AccFundAccs.AdvanceAccBalTypeAccBalType, theAccFundAccs.AdvanceAccBalTypeAccBalType, true));
            values.Add(new FieldValue("AdvanceAccCurrencyAccCurrencyName", original_AccFundAccs.AdvanceAccCurrencyAccCurrencyName, theAccFundAccs.AdvanceAccCurrencyAccCurrencyName, true));
            values.Add(new FieldValue("AdvanceAccDestAccDest", original_AccFundAccs.AdvanceAccDestAccDest, theAccFundAccs.AdvanceAccDestAccDest, true));
            values.Add(new FieldValue("AdvanceAccDestCompanyTypeDescription", original_AccFundAccs.AdvanceAccDestCompanyTypeDescription, theAccFundAccs.AdvanceAccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("AdvanceAccFundAccFundCode", original_AccFundAccs.AdvanceAccFundAccFundCode, theAccFundAccs.AdvanceAccFundAccFundCode, true));
            values.Add(new FieldValue("AdvanceAccSubTypeAccSubType", original_AccFundAccs.AdvanceAccSubTypeAccSubType, theAccFundAccs.AdvanceAccSubTypeAccSubType, true));
            values.Add(new FieldValue("AdvanceAccTypeAccType", original_AccFundAccs.AdvanceAccTypeAccType, theAccFundAccs.AdvanceAccTypeAccType, true));
            values.Add(new FieldValue("AdvanceCoaControlAccName", original_AccFundAccs.AdvanceCoaControlAccName, theAccFundAccs.AdvanceCoaControlAccName, true));
            values.Add(new FieldValue("AdvanceCoaControlAccBalTypeAccBalType", original_AccFundAccs.AdvanceCoaControlAccBalTypeAccBalType, theAccFundAccs.AdvanceCoaControlAccBalTypeAccBalType, true));
            values.Add(new FieldValue("AdvanceCoaControlAccDestAccDest", original_AccFundAccs.AdvanceCoaControlAccDestAccDest, theAccFundAccs.AdvanceCoaControlAccDestAccDest, true));
            values.Add(new FieldValue("AdvanceCoaControlAccTypeAccType", original_AccFundAccs.AdvanceCoaControlAccTypeAccType, theAccFundAccs.AdvanceCoaControlAccTypeAccType, true));
            values.Add(new FieldValue("AdvanceCoaControlCompTypeDescription", original_AccFundAccs.AdvanceCoaControlCompTypeDescription, theAccFundAccs.AdvanceCoaControlCompTypeDescription, true));
            values.Add(new FieldValue("AdvanceCoaMainAccName", original_AccFundAccs.AdvanceCoaMainAccName, theAccFundAccs.AdvanceCoaMainAccName, true));
            values.Add(new FieldValue("AdvanceCoaMainAccBalTypeAccBalType", original_AccFundAccs.AdvanceCoaMainAccBalTypeAccBalType, theAccFundAccs.AdvanceCoaMainAccBalTypeAccBalType, true));
            values.Add(new FieldValue("AdvanceCoaMainAccDestAccDest", original_AccFundAccs.AdvanceCoaMainAccDestAccDest, theAccFundAccs.AdvanceCoaMainAccDestAccDest, true));
            values.Add(new FieldValue("AdvanceCoaMainAccFundAccFundCode", original_AccFundAccs.AdvanceCoaMainAccFundAccFundCode, theAccFundAccs.AdvanceCoaMainAccFundAccFundCode, true));
            values.Add(new FieldValue("AdvanceCoaMainAccTypeAccType", original_AccFundAccs.AdvanceCoaMainAccTypeAccType, theAccFundAccs.AdvanceCoaMainAccTypeAccType, true));
            values.Add(new FieldValue("AdvanceCoaMainCoaControlAccName", original_AccFundAccs.AdvanceCoaMainCoaControlAccName, theAccFundAccs.AdvanceCoaMainCoaControlAccName, true));
            values.Add(new FieldValue("AdvanceCoaSubAccName", original_AccFundAccs.AdvanceCoaSubAccName, theAccFundAccs.AdvanceCoaSubAccName, true));
            values.Add(new FieldValue("AdvanceCoaSubAccBalTypeAccBalType", original_AccFundAccs.AdvanceCoaSubAccBalTypeAccBalType, theAccFundAccs.AdvanceCoaSubAccBalTypeAccBalType, true));
            values.Add(new FieldValue("AdvanceCoaSubAccDestAccDest", original_AccFundAccs.AdvanceCoaSubAccDestAccDest, theAccFundAccs.AdvanceCoaSubAccDestAccDest, true));
            values.Add(new FieldValue("AdvanceCoaSubAccFundAccFundCode", original_AccFundAccs.AdvanceCoaSubAccFundAccFundCode, theAccFundAccs.AdvanceCoaSubAccFundAccFundCode, true));
            values.Add(new FieldValue("AdvanceCoaSubAccTypeAccType", original_AccFundAccs.AdvanceCoaSubAccTypeAccType, theAccFundAccs.AdvanceCoaSubAccTypeAccType, true));
            values.Add(new FieldValue("AdvanceCoaSubCoaControlAccName", original_AccFundAccs.AdvanceCoaSubCoaControlAccName, theAccFundAccs.AdvanceCoaSubCoaControlAccName, true));
            values.Add(new FieldValue("AdvanceCoaSubCoaMainAccName", original_AccFundAccs.AdvanceCoaSubCoaMainAccName, theAccFundAccs.AdvanceCoaSubCoaMainAccName, true));
            values.Add(new FieldValue("PurAcc", original_AccFundAccs.PurAcc, theAccFundAccs.PurAcc));
            values.Add(new FieldValue("PurAccAccName", original_AccFundAccs.PurAccAccName, theAccFundAccs.PurAccAccName, true));
            values.Add(new FieldValue("PurAccAccBalTypeAccBalType", original_AccFundAccs.PurAccAccBalTypeAccBalType, theAccFundAccs.PurAccAccBalTypeAccBalType, true));
            values.Add(new FieldValue("PurAccAccCurrencyAccCurrencyName", original_AccFundAccs.PurAccAccCurrencyAccCurrencyName, theAccFundAccs.PurAccAccCurrencyAccCurrencyName, true));
            values.Add(new FieldValue("PurAccAccDestAccDest", original_AccFundAccs.PurAccAccDestAccDest, theAccFundAccs.PurAccAccDestAccDest, true));
            values.Add(new FieldValue("PurAccAccDestCompanyTypeDescription", original_AccFundAccs.PurAccAccDestCompanyTypeDescription, theAccFundAccs.PurAccAccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("PurAccAccFundAccFundCode", original_AccFundAccs.PurAccAccFundAccFundCode, theAccFundAccs.PurAccAccFundAccFundCode, true));
            values.Add(new FieldValue("PurAccAccSubTypeAccSubType", original_AccFundAccs.PurAccAccSubTypeAccSubType, theAccFundAccs.PurAccAccSubTypeAccSubType, true));
            values.Add(new FieldValue("PurAccAccTypeAccType", original_AccFundAccs.PurAccAccTypeAccType, theAccFundAccs.PurAccAccTypeAccType, true));
            values.Add(new FieldValue("PurAccCoaControlAccName", original_AccFundAccs.PurAccCoaControlAccName, theAccFundAccs.PurAccCoaControlAccName, true));
            values.Add(new FieldValue("PurAccCoaControlAccBalTypeAccBalType", original_AccFundAccs.PurAccCoaControlAccBalTypeAccBalType, theAccFundAccs.PurAccCoaControlAccBalTypeAccBalType, true));
            values.Add(new FieldValue("PurAccCoaControlAccDestAccDest", original_AccFundAccs.PurAccCoaControlAccDestAccDest, theAccFundAccs.PurAccCoaControlAccDestAccDest, true));
            values.Add(new FieldValue("PurAccCoaControlAccTypeAccType", original_AccFundAccs.PurAccCoaControlAccTypeAccType, theAccFundAccs.PurAccCoaControlAccTypeAccType, true));
            values.Add(new FieldValue("PurAccCoaControlCompTypeDescription", original_AccFundAccs.PurAccCoaControlCompTypeDescription, theAccFundAccs.PurAccCoaControlCompTypeDescription, true));
            values.Add(new FieldValue("PurAccCoaMainAccName", original_AccFundAccs.PurAccCoaMainAccName, theAccFundAccs.PurAccCoaMainAccName, true));
            values.Add(new FieldValue("PurAccCoaMainAccBalTypeAccBalType", original_AccFundAccs.PurAccCoaMainAccBalTypeAccBalType, theAccFundAccs.PurAccCoaMainAccBalTypeAccBalType, true));
            values.Add(new FieldValue("PurAccCoaMainAccDestAccDest", original_AccFundAccs.PurAccCoaMainAccDestAccDest, theAccFundAccs.PurAccCoaMainAccDestAccDest, true));
            values.Add(new FieldValue("PurAccCoaMainAccFundAccFundCode", original_AccFundAccs.PurAccCoaMainAccFundAccFundCode, theAccFundAccs.PurAccCoaMainAccFundAccFundCode, true));
            values.Add(new FieldValue("PurAccCoaMainAccTypeAccType", original_AccFundAccs.PurAccCoaMainAccTypeAccType, theAccFundAccs.PurAccCoaMainAccTypeAccType, true));
            values.Add(new FieldValue("PurAccCoaMainCoaControlAccName", original_AccFundAccs.PurAccCoaMainCoaControlAccName, theAccFundAccs.PurAccCoaMainCoaControlAccName, true));
            values.Add(new FieldValue("PurAccCoaSubAccName", original_AccFundAccs.PurAccCoaSubAccName, theAccFundAccs.PurAccCoaSubAccName, true));
            values.Add(new FieldValue("PurAccCoaSubAccBalTypeAccBalType", original_AccFundAccs.PurAccCoaSubAccBalTypeAccBalType, theAccFundAccs.PurAccCoaSubAccBalTypeAccBalType, true));
            values.Add(new FieldValue("PurAccCoaSubAccDestAccDest", original_AccFundAccs.PurAccCoaSubAccDestAccDest, theAccFundAccs.PurAccCoaSubAccDestAccDest, true));
            values.Add(new FieldValue("PurAccCoaSubAccFundAccFundCode", original_AccFundAccs.PurAccCoaSubAccFundAccFundCode, theAccFundAccs.PurAccCoaSubAccFundAccFundCode, true));
            values.Add(new FieldValue("PurAccCoaSubAccTypeAccType", original_AccFundAccs.PurAccCoaSubAccTypeAccType, theAccFundAccs.PurAccCoaSubAccTypeAccType, true));
            values.Add(new FieldValue("PurAccCoaSubCoaControlAccName", original_AccFundAccs.PurAccCoaSubCoaControlAccName, theAccFundAccs.PurAccCoaSubCoaControlAccName, true));
            values.Add(new FieldValue("PurAccCoaSubCoaMainAccName", original_AccFundAccs.PurAccCoaSubCoaMainAccName, theAccFundAccs.PurAccCoaSubCoaMainAccName, true));
            values.Add(new FieldValue("SaleAcc", original_AccFundAccs.SaleAcc, theAccFundAccs.SaleAcc));
            values.Add(new FieldValue("SaleAccAccName", original_AccFundAccs.SaleAccAccName, theAccFundAccs.SaleAccAccName, true));
            values.Add(new FieldValue("SaleAccAccBalTypeAccBalType", original_AccFundAccs.SaleAccAccBalTypeAccBalType, theAccFundAccs.SaleAccAccBalTypeAccBalType, true));
            values.Add(new FieldValue("SaleAccAccCurrencyAccCurrencyName", original_AccFundAccs.SaleAccAccCurrencyAccCurrencyName, theAccFundAccs.SaleAccAccCurrencyAccCurrencyName, true));
            values.Add(new FieldValue("SaleAccAccDestAccDest", original_AccFundAccs.SaleAccAccDestAccDest, theAccFundAccs.SaleAccAccDestAccDest, true));
            values.Add(new FieldValue("SaleAccAccDestCompanyTypeDescription", original_AccFundAccs.SaleAccAccDestCompanyTypeDescription, theAccFundAccs.SaleAccAccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("SaleAccAccFundAccFundCode", original_AccFundAccs.SaleAccAccFundAccFundCode, theAccFundAccs.SaleAccAccFundAccFundCode, true));
            values.Add(new FieldValue("SaleAccAccSubTypeAccSubType", original_AccFundAccs.SaleAccAccSubTypeAccSubType, theAccFundAccs.SaleAccAccSubTypeAccSubType, true));
            values.Add(new FieldValue("SaleAccAccTypeAccType", original_AccFundAccs.SaleAccAccTypeAccType, theAccFundAccs.SaleAccAccTypeAccType, true));
            values.Add(new FieldValue("SaleAccCoaControlAccName", original_AccFundAccs.SaleAccCoaControlAccName, theAccFundAccs.SaleAccCoaControlAccName, true));
            values.Add(new FieldValue("SaleAccCoaControlAccBalTypeAccBalType", original_AccFundAccs.SaleAccCoaControlAccBalTypeAccBalType, theAccFundAccs.SaleAccCoaControlAccBalTypeAccBalType, true));
            values.Add(new FieldValue("SaleAccCoaControlAccDestAccDest", original_AccFundAccs.SaleAccCoaControlAccDestAccDest, theAccFundAccs.SaleAccCoaControlAccDestAccDest, true));
            values.Add(new FieldValue("SaleAccCoaControlAccTypeAccType", original_AccFundAccs.SaleAccCoaControlAccTypeAccType, theAccFundAccs.SaleAccCoaControlAccTypeAccType, true));
            values.Add(new FieldValue("SaleAccCoaControlCompTypeDescription", original_AccFundAccs.SaleAccCoaControlCompTypeDescription, theAccFundAccs.SaleAccCoaControlCompTypeDescription, true));
            values.Add(new FieldValue("SaleAccCoaMainAccName", original_AccFundAccs.SaleAccCoaMainAccName, theAccFundAccs.SaleAccCoaMainAccName, true));
            values.Add(new FieldValue("SaleAccCoaMainAccBalTypeAccBalType", original_AccFundAccs.SaleAccCoaMainAccBalTypeAccBalType, theAccFundAccs.SaleAccCoaMainAccBalTypeAccBalType, true));
            values.Add(new FieldValue("SaleAccCoaMainAccDestAccDest", original_AccFundAccs.SaleAccCoaMainAccDestAccDest, theAccFundAccs.SaleAccCoaMainAccDestAccDest, true));
            values.Add(new FieldValue("SaleAccCoaMainAccFundAccFundCode", original_AccFundAccs.SaleAccCoaMainAccFundAccFundCode, theAccFundAccs.SaleAccCoaMainAccFundAccFundCode, true));
            values.Add(new FieldValue("SaleAccCoaMainAccTypeAccType", original_AccFundAccs.SaleAccCoaMainAccTypeAccType, theAccFundAccs.SaleAccCoaMainAccTypeAccType, true));
            values.Add(new FieldValue("SaleAccCoaMainCoaControlAccName", original_AccFundAccs.SaleAccCoaMainCoaControlAccName, theAccFundAccs.SaleAccCoaMainCoaControlAccName, true));
            values.Add(new FieldValue("SaleAccCoaSubAccName", original_AccFundAccs.SaleAccCoaSubAccName, theAccFundAccs.SaleAccCoaSubAccName, true));
            values.Add(new FieldValue("SaleAccCoaSubAccBalTypeAccBalType", original_AccFundAccs.SaleAccCoaSubAccBalTypeAccBalType, theAccFundAccs.SaleAccCoaSubAccBalTypeAccBalType, true));
            values.Add(new FieldValue("SaleAccCoaSubAccDestAccDest", original_AccFundAccs.SaleAccCoaSubAccDestAccDest, theAccFundAccs.SaleAccCoaSubAccDestAccDest, true));
            values.Add(new FieldValue("SaleAccCoaSubAccFundAccFundCode", original_AccFundAccs.SaleAccCoaSubAccFundAccFundCode, theAccFundAccs.SaleAccCoaSubAccFundAccFundCode, true));
            values.Add(new FieldValue("SaleAccCoaSubAccTypeAccType", original_AccFundAccs.SaleAccCoaSubAccTypeAccType, theAccFundAccs.SaleAccCoaSubAccTypeAccType, true));
            values.Add(new FieldValue("SaleAccCoaSubCoaControlAccName", original_AccFundAccs.SaleAccCoaSubCoaControlAccName, theAccFundAccs.SaleAccCoaSubCoaControlAccName, true));
            values.Add(new FieldValue("SaleAccCoaSubCoaMainAccName", original_AccFundAccs.SaleAccCoaSubCoaMainAccName, theAccFundAccs.SaleAccCoaSubCoaMainAccName, true));
            values.Add(new FieldValue("WorkinProgressAcc", original_AccFundAccs.WorkinProgressAcc, theAccFundAccs.WorkinProgressAcc));
            values.Add(new FieldValue("WorkinProgressAccAccName", original_AccFundAccs.WorkinProgressAccAccName, theAccFundAccs.WorkinProgressAccAccName, true));
            values.Add(new FieldValue("WorkinProgressAccAccBalTypeAccBalType", original_AccFundAccs.WorkinProgressAccAccBalTypeAccBalType, theAccFundAccs.WorkinProgressAccAccBalTypeAccBalType, true));
            values.Add(new FieldValue("WorkinProgressAccAccCurrencyAccCurrencyName", original_AccFundAccs.WorkinProgressAccAccCurrencyAccCurrencyName, theAccFundAccs.WorkinProgressAccAccCurrencyAccCurrencyName, true));
            values.Add(new FieldValue("WorkinProgressAccAccDestAccDest", original_AccFundAccs.WorkinProgressAccAccDestAccDest, theAccFundAccs.WorkinProgressAccAccDestAccDest, true));
            values.Add(new FieldValue("WorkinProgressAccAccDestCompanyTypeDescription", original_AccFundAccs.WorkinProgressAccAccDestCompanyTypeDescription, theAccFundAccs.WorkinProgressAccAccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("WorkinProgressAccAccFundAccFundCode", original_AccFundAccs.WorkinProgressAccAccFundAccFundCode, theAccFundAccs.WorkinProgressAccAccFundAccFundCode, true));
            values.Add(new FieldValue("WorkinProgressAccAccSubTypeAccSubType", original_AccFundAccs.WorkinProgressAccAccSubTypeAccSubType, theAccFundAccs.WorkinProgressAccAccSubTypeAccSubType, true));
            values.Add(new FieldValue("WorkinProgressAccAccTypeAccType", original_AccFundAccs.WorkinProgressAccAccTypeAccType, theAccFundAccs.WorkinProgressAccAccTypeAccType, true));
            values.Add(new FieldValue("WorkinProgressAccCoaControlAccName", original_AccFundAccs.WorkinProgressAccCoaControlAccName, theAccFundAccs.WorkinProgressAccCoaControlAccName, true));
            values.Add(new FieldValue("WorkinProgressAccCoaControlAccBalTypeAccBalType", original_AccFundAccs.WorkinProgressAccCoaControlAccBalTypeAccBalType, theAccFundAccs.WorkinProgressAccCoaControlAccBalTypeAccBalType, true));
            values.Add(new FieldValue("WorkinProgressAccCoaControlAccDestAccDest", original_AccFundAccs.WorkinProgressAccCoaControlAccDestAccDest, theAccFundAccs.WorkinProgressAccCoaControlAccDestAccDest, true));
            values.Add(new FieldValue("WorkinProgressAccCoaControlAccTypeAccType", original_AccFundAccs.WorkinProgressAccCoaControlAccTypeAccType, theAccFundAccs.WorkinProgressAccCoaControlAccTypeAccType, true));
            values.Add(new FieldValue("WorkinProgressAccCoaControlCompTypeDescription", original_AccFundAccs.WorkinProgressAccCoaControlCompTypeDescription, theAccFundAccs.WorkinProgressAccCoaControlCompTypeDescription, true));
            values.Add(new FieldValue("WorkinProgressAccCoaMainAccName", original_AccFundAccs.WorkinProgressAccCoaMainAccName, theAccFundAccs.WorkinProgressAccCoaMainAccName, true));
            values.Add(new FieldValue("WorkinProgressAccCoaMainAccBalTypeAccBalType", original_AccFundAccs.WorkinProgressAccCoaMainAccBalTypeAccBalType, theAccFundAccs.WorkinProgressAccCoaMainAccBalTypeAccBalType, true));
            values.Add(new FieldValue("WorkinProgressAccCoaMainAccDestAccDest", original_AccFundAccs.WorkinProgressAccCoaMainAccDestAccDest, theAccFundAccs.WorkinProgressAccCoaMainAccDestAccDest, true));
            values.Add(new FieldValue("WorkinProgressAccCoaMainAccFundAccFundCode", original_AccFundAccs.WorkinProgressAccCoaMainAccFundAccFundCode, theAccFundAccs.WorkinProgressAccCoaMainAccFundAccFundCode, true));
            values.Add(new FieldValue("WorkinProgressAccCoaMainAccTypeAccType", original_AccFundAccs.WorkinProgressAccCoaMainAccTypeAccType, theAccFundAccs.WorkinProgressAccCoaMainAccTypeAccType, true));
            values.Add(new FieldValue("WorkinProgressAccCoaMainCoaControlAccName", original_AccFundAccs.WorkinProgressAccCoaMainCoaControlAccName, theAccFundAccs.WorkinProgressAccCoaMainCoaControlAccName, true));
            values.Add(new FieldValue("WorkinProgressAccCoaSubAccName", original_AccFundAccs.WorkinProgressAccCoaSubAccName, theAccFundAccs.WorkinProgressAccCoaSubAccName, true));
            values.Add(new FieldValue("WorkinProgressAccCoaSubAccBalTypeAccBalType", original_AccFundAccs.WorkinProgressAccCoaSubAccBalTypeAccBalType, theAccFundAccs.WorkinProgressAccCoaSubAccBalTypeAccBalType, true));
            values.Add(new FieldValue("WorkinProgressAccCoaSubAccDestAccDest", original_AccFundAccs.WorkinProgressAccCoaSubAccDestAccDest, theAccFundAccs.WorkinProgressAccCoaSubAccDestAccDest, true));
            values.Add(new FieldValue("WorkinProgressAccCoaSubAccFundAccFundCode", original_AccFundAccs.WorkinProgressAccCoaSubAccFundAccFundCode, theAccFundAccs.WorkinProgressAccCoaSubAccFundAccFundCode, true));
            values.Add(new FieldValue("WorkinProgressAccCoaSubAccTypeAccType", original_AccFundAccs.WorkinProgressAccCoaSubAccTypeAccType, theAccFundAccs.WorkinProgressAccCoaSubAccTypeAccType, true));
            values.Add(new FieldValue("WorkinProgressAccCoaSubCoaControlAccName", original_AccFundAccs.WorkinProgressAccCoaSubCoaControlAccName, theAccFundAccs.WorkinProgressAccCoaSubCoaControlAccName, true));
            values.Add(new FieldValue("WorkinProgressAccCoaSubCoaMainAccName", original_AccFundAccs.WorkinProgressAccCoaSubCoaMainAccName, theAccFundAccs.WorkinProgressAccCoaSubCoaMainAccName, true));
            values.Add(new FieldValue("CostofSold", original_AccFundAccs.CostofSold, theAccFundAccs.CostofSold));
            values.Add(new FieldValue("CostofSoldAccName", original_AccFundAccs.CostofSoldAccName, theAccFundAccs.CostofSoldAccName, true));
            values.Add(new FieldValue("CostofSoldAccBalTypeAccBalType", original_AccFundAccs.CostofSoldAccBalTypeAccBalType, theAccFundAccs.CostofSoldAccBalTypeAccBalType, true));
            values.Add(new FieldValue("CostofSoldAccCurrencyAccCurrencyName", original_AccFundAccs.CostofSoldAccCurrencyAccCurrencyName, theAccFundAccs.CostofSoldAccCurrencyAccCurrencyName, true));
            values.Add(new FieldValue("CostofSoldAccDestAccDest", original_AccFundAccs.CostofSoldAccDestAccDest, theAccFundAccs.CostofSoldAccDestAccDest, true));
            values.Add(new FieldValue("CostofSoldAccDestCompanyTypeDescription", original_AccFundAccs.CostofSoldAccDestCompanyTypeDescription, theAccFundAccs.CostofSoldAccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("CostofSoldAccFundAccFundCode", original_AccFundAccs.CostofSoldAccFundAccFundCode, theAccFundAccs.CostofSoldAccFundAccFundCode, true));
            values.Add(new FieldValue("CostofSoldAccSubTypeAccSubType", original_AccFundAccs.CostofSoldAccSubTypeAccSubType, theAccFundAccs.CostofSoldAccSubTypeAccSubType, true));
            values.Add(new FieldValue("CostofSoldAccTypeAccType", original_AccFundAccs.CostofSoldAccTypeAccType, theAccFundAccs.CostofSoldAccTypeAccType, true));
            values.Add(new FieldValue("CostofSoldCoaControlAccName", original_AccFundAccs.CostofSoldCoaControlAccName, theAccFundAccs.CostofSoldCoaControlAccName, true));
            values.Add(new FieldValue("CostofSoldCoaControlAccBalTypeAccBalType", original_AccFundAccs.CostofSoldCoaControlAccBalTypeAccBalType, theAccFundAccs.CostofSoldCoaControlAccBalTypeAccBalType, true));
            values.Add(new FieldValue("CostofSoldCoaControlAccDestAccDest", original_AccFundAccs.CostofSoldCoaControlAccDestAccDest, theAccFundAccs.CostofSoldCoaControlAccDestAccDest, true));
            values.Add(new FieldValue("CostofSoldCoaControlAccTypeAccType", original_AccFundAccs.CostofSoldCoaControlAccTypeAccType, theAccFundAccs.CostofSoldCoaControlAccTypeAccType, true));
            values.Add(new FieldValue("CostofSoldCoaControlCompTypeDescription", original_AccFundAccs.CostofSoldCoaControlCompTypeDescription, theAccFundAccs.CostofSoldCoaControlCompTypeDescription, true));
            values.Add(new FieldValue("CostofSoldCoaMainAccName", original_AccFundAccs.CostofSoldCoaMainAccName, theAccFundAccs.CostofSoldCoaMainAccName, true));
            values.Add(new FieldValue("CostofSoldCoaMainAccBalTypeAccBalType", original_AccFundAccs.CostofSoldCoaMainAccBalTypeAccBalType, theAccFundAccs.CostofSoldCoaMainAccBalTypeAccBalType, true));
            values.Add(new FieldValue("CostofSoldCoaMainAccDestAccDest", original_AccFundAccs.CostofSoldCoaMainAccDestAccDest, theAccFundAccs.CostofSoldCoaMainAccDestAccDest, true));
            values.Add(new FieldValue("CostofSoldCoaMainAccFundAccFundCode", original_AccFundAccs.CostofSoldCoaMainAccFundAccFundCode, theAccFundAccs.CostofSoldCoaMainAccFundAccFundCode, true));
            values.Add(new FieldValue("CostofSoldCoaMainAccTypeAccType", original_AccFundAccs.CostofSoldCoaMainAccTypeAccType, theAccFundAccs.CostofSoldCoaMainAccTypeAccType, true));
            values.Add(new FieldValue("CostofSoldCoaMainCoaControlAccName", original_AccFundAccs.CostofSoldCoaMainCoaControlAccName, theAccFundAccs.CostofSoldCoaMainCoaControlAccName, true));
            values.Add(new FieldValue("CostofSoldCoaSubAccName", original_AccFundAccs.CostofSoldCoaSubAccName, theAccFundAccs.CostofSoldCoaSubAccName, true));
            values.Add(new FieldValue("CostofSoldCoaSubAccBalTypeAccBalType", original_AccFundAccs.CostofSoldCoaSubAccBalTypeAccBalType, theAccFundAccs.CostofSoldCoaSubAccBalTypeAccBalType, true));
            values.Add(new FieldValue("CostofSoldCoaSubAccDestAccDest", original_AccFundAccs.CostofSoldCoaSubAccDestAccDest, theAccFundAccs.CostofSoldCoaSubAccDestAccDest, true));
            values.Add(new FieldValue("CostofSoldCoaSubAccFundAccFundCode", original_AccFundAccs.CostofSoldCoaSubAccFundAccFundCode, theAccFundAccs.CostofSoldCoaSubAccFundAccFundCode, true));
            values.Add(new FieldValue("CostofSoldCoaSubAccTypeAccType", original_AccFundAccs.CostofSoldCoaSubAccTypeAccType, theAccFundAccs.CostofSoldCoaSubAccTypeAccType, true));
            values.Add(new FieldValue("CostofSoldCoaSubCoaControlAccName", original_AccFundAccs.CostofSoldCoaSubCoaControlAccName, theAccFundAccs.CostofSoldCoaSubCoaControlAccName, true));
            values.Add(new FieldValue("CostofSoldCoaSubCoaMainAccName", original_AccFundAccs.CostofSoldCoaSubCoaMainAccName, theAccFundAccs.CostofSoldCoaSubCoaMainAccName, true));
            values.Add(new FieldValue("OPD_Acc", original_AccFundAccs.OPD_Acc, theAccFundAccs.OPD_Acc));
            values.Add(new FieldValue("OPD_AccAccName", original_AccFundAccs.OPD_AccAccName, theAccFundAccs.OPD_AccAccName, true));
            values.Add(new FieldValue("OPD_AccAccBalTypeAccBalType", original_AccFundAccs.OPD_AccAccBalTypeAccBalType, theAccFundAccs.OPD_AccAccBalTypeAccBalType, true));
            values.Add(new FieldValue("OPD_AccAccCurrencyAccCurrencyName", original_AccFundAccs.OPD_AccAccCurrencyAccCurrencyName, theAccFundAccs.OPD_AccAccCurrencyAccCurrencyName, true));
            values.Add(new FieldValue("OPD_AccAccDestAccDest", original_AccFundAccs.OPD_AccAccDestAccDest, theAccFundAccs.OPD_AccAccDestAccDest, true));
            values.Add(new FieldValue("OPD_AccAccDestCompanyTypeDescription", original_AccFundAccs.OPD_AccAccDestCompanyTypeDescription, theAccFundAccs.OPD_AccAccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("OPD_AccAccFundAccFundCode", original_AccFundAccs.OPD_AccAccFundAccFundCode, theAccFundAccs.OPD_AccAccFundAccFundCode, true));
            values.Add(new FieldValue("OPD_AccAccSubTypeAccSubType", original_AccFundAccs.OPD_AccAccSubTypeAccSubType, theAccFundAccs.OPD_AccAccSubTypeAccSubType, true));
            values.Add(new FieldValue("OPD_AccAccTypeAccType", original_AccFundAccs.OPD_AccAccTypeAccType, theAccFundAccs.OPD_AccAccTypeAccType, true));
            values.Add(new FieldValue("OPD_AccCoaControlAccName", original_AccFundAccs.OPD_AccCoaControlAccName, theAccFundAccs.OPD_AccCoaControlAccName, true));
            values.Add(new FieldValue("OPD_AccCoaControlAccBalTypeAccBalType", original_AccFundAccs.OPD_AccCoaControlAccBalTypeAccBalType, theAccFundAccs.OPD_AccCoaControlAccBalTypeAccBalType, true));
            values.Add(new FieldValue("OPD_AccCoaControlAccDestAccDest", original_AccFundAccs.OPD_AccCoaControlAccDestAccDest, theAccFundAccs.OPD_AccCoaControlAccDestAccDest, true));
            values.Add(new FieldValue("OPD_AccCoaControlAccTypeAccType", original_AccFundAccs.OPD_AccCoaControlAccTypeAccType, theAccFundAccs.OPD_AccCoaControlAccTypeAccType, true));
            values.Add(new FieldValue("OPD_AccCoaControlCompTypeDescription", original_AccFundAccs.OPD_AccCoaControlCompTypeDescription, theAccFundAccs.OPD_AccCoaControlCompTypeDescription, true));
            values.Add(new FieldValue("OPD_AccCoaMainAccName", original_AccFundAccs.OPD_AccCoaMainAccName, theAccFundAccs.OPD_AccCoaMainAccName, true));
            values.Add(new FieldValue("OPD_AccCoaMainAccBalTypeAccBalType", original_AccFundAccs.OPD_AccCoaMainAccBalTypeAccBalType, theAccFundAccs.OPD_AccCoaMainAccBalTypeAccBalType, true));
            values.Add(new FieldValue("OPD_AccCoaMainAccDestAccDest", original_AccFundAccs.OPD_AccCoaMainAccDestAccDest, theAccFundAccs.OPD_AccCoaMainAccDestAccDest, true));
            values.Add(new FieldValue("OPD_AccCoaMainAccFundAccFundCode", original_AccFundAccs.OPD_AccCoaMainAccFundAccFundCode, theAccFundAccs.OPD_AccCoaMainAccFundAccFundCode, true));
            values.Add(new FieldValue("OPD_AccCoaMainAccTypeAccType", original_AccFundAccs.OPD_AccCoaMainAccTypeAccType, theAccFundAccs.OPD_AccCoaMainAccTypeAccType, true));
            values.Add(new FieldValue("OPD_AccCoaMainCoaControlAccName", original_AccFundAccs.OPD_AccCoaMainCoaControlAccName, theAccFundAccs.OPD_AccCoaMainCoaControlAccName, true));
            values.Add(new FieldValue("OPD_AccCoaSubAccName", original_AccFundAccs.OPD_AccCoaSubAccName, theAccFundAccs.OPD_AccCoaSubAccName, true));
            values.Add(new FieldValue("OPD_AccCoaSubAccBalTypeAccBalType", original_AccFundAccs.OPD_AccCoaSubAccBalTypeAccBalType, theAccFundAccs.OPD_AccCoaSubAccBalTypeAccBalType, true));
            values.Add(new FieldValue("OPD_AccCoaSubAccDestAccDest", original_AccFundAccs.OPD_AccCoaSubAccDestAccDest, theAccFundAccs.OPD_AccCoaSubAccDestAccDest, true));
            values.Add(new FieldValue("OPD_AccCoaSubAccFundAccFundCode", original_AccFundAccs.OPD_AccCoaSubAccFundAccFundCode, theAccFundAccs.OPD_AccCoaSubAccFundAccFundCode, true));
            values.Add(new FieldValue("OPD_AccCoaSubAccTypeAccType", original_AccFundAccs.OPD_AccCoaSubAccTypeAccType, theAccFundAccs.OPD_AccCoaSubAccTypeAccType, true));
            values.Add(new FieldValue("OPD_AccCoaSubCoaControlAccName", original_AccFundAccs.OPD_AccCoaSubCoaControlAccName, theAccFundAccs.OPD_AccCoaSubCoaControlAccName, true));
            values.Add(new FieldValue("OPD_AccCoaSubCoaMainAccName", original_AccFundAccs.OPD_AccCoaSubCoaMainAccName, theAccFundAccs.OPD_AccCoaSubCoaMainAccName, true));
            values.Add(new FieldValue("AdvPat_Acc", original_AccFundAccs.AdvPat_Acc, theAccFundAccs.AdvPat_Acc));
            values.Add(new FieldValue("AdvPat_AccAccName", original_AccFundAccs.AdvPat_AccAccName, theAccFundAccs.AdvPat_AccAccName, true));
            values.Add(new FieldValue("AdvPat_AccAccBalTypeAccBalType", original_AccFundAccs.AdvPat_AccAccBalTypeAccBalType, theAccFundAccs.AdvPat_AccAccBalTypeAccBalType, true));
            values.Add(new FieldValue("AdvPat_AccAccCurrencyAccCurrencyName", original_AccFundAccs.AdvPat_AccAccCurrencyAccCurrencyName, theAccFundAccs.AdvPat_AccAccCurrencyAccCurrencyName, true));
            values.Add(new FieldValue("AdvPat_AccAccDestAccDest", original_AccFundAccs.AdvPat_AccAccDestAccDest, theAccFundAccs.AdvPat_AccAccDestAccDest, true));
            values.Add(new FieldValue("AdvPat_AccAccDestCompanyTypeDescription", original_AccFundAccs.AdvPat_AccAccDestCompanyTypeDescription, theAccFundAccs.AdvPat_AccAccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("AdvPat_AccAccFundAccFundCode", original_AccFundAccs.AdvPat_AccAccFundAccFundCode, theAccFundAccs.AdvPat_AccAccFundAccFundCode, true));
            values.Add(new FieldValue("AdvPat_AccAccSubTypeAccSubType", original_AccFundAccs.AdvPat_AccAccSubTypeAccSubType, theAccFundAccs.AdvPat_AccAccSubTypeAccSubType, true));
            values.Add(new FieldValue("AdvPat_AccAccTypeAccType", original_AccFundAccs.AdvPat_AccAccTypeAccType, theAccFundAccs.AdvPat_AccAccTypeAccType, true));
            values.Add(new FieldValue("AdvPat_AccCoaControlAccName", original_AccFundAccs.AdvPat_AccCoaControlAccName, theAccFundAccs.AdvPat_AccCoaControlAccName, true));
            values.Add(new FieldValue("AdvPat_AccCoaControlAccBalTypeAccBalType", original_AccFundAccs.AdvPat_AccCoaControlAccBalTypeAccBalType, theAccFundAccs.AdvPat_AccCoaControlAccBalTypeAccBalType, true));
            values.Add(new FieldValue("AdvPat_AccCoaControlAccDestAccDest", original_AccFundAccs.AdvPat_AccCoaControlAccDestAccDest, theAccFundAccs.AdvPat_AccCoaControlAccDestAccDest, true));
            values.Add(new FieldValue("AdvPat_AccCoaControlAccTypeAccType", original_AccFundAccs.AdvPat_AccCoaControlAccTypeAccType, theAccFundAccs.AdvPat_AccCoaControlAccTypeAccType, true));
            values.Add(new FieldValue("AdvPat_AccCoaControlCompTypeDescription", original_AccFundAccs.AdvPat_AccCoaControlCompTypeDescription, theAccFundAccs.AdvPat_AccCoaControlCompTypeDescription, true));
            values.Add(new FieldValue("AdvPat_AccCoaMainAccName", original_AccFundAccs.AdvPat_AccCoaMainAccName, theAccFundAccs.AdvPat_AccCoaMainAccName, true));
            values.Add(new FieldValue("AdvPat_AccCoaMainAccBalTypeAccBalType", original_AccFundAccs.AdvPat_AccCoaMainAccBalTypeAccBalType, theAccFundAccs.AdvPat_AccCoaMainAccBalTypeAccBalType, true));
            values.Add(new FieldValue("AdvPat_AccCoaMainAccDestAccDest", original_AccFundAccs.AdvPat_AccCoaMainAccDestAccDest, theAccFundAccs.AdvPat_AccCoaMainAccDestAccDest, true));
            values.Add(new FieldValue("AdvPat_AccCoaMainAccFundAccFundCode", original_AccFundAccs.AdvPat_AccCoaMainAccFundAccFundCode, theAccFundAccs.AdvPat_AccCoaMainAccFundAccFundCode, true));
            values.Add(new FieldValue("AdvPat_AccCoaMainAccTypeAccType", original_AccFundAccs.AdvPat_AccCoaMainAccTypeAccType, theAccFundAccs.AdvPat_AccCoaMainAccTypeAccType, true));
            values.Add(new FieldValue("AdvPat_AccCoaMainCoaControlAccName", original_AccFundAccs.AdvPat_AccCoaMainCoaControlAccName, theAccFundAccs.AdvPat_AccCoaMainCoaControlAccName, true));
            values.Add(new FieldValue("AdvPat_AccCoaSubAccName", original_AccFundAccs.AdvPat_AccCoaSubAccName, theAccFundAccs.AdvPat_AccCoaSubAccName, true));
            values.Add(new FieldValue("AdvPat_AccCoaSubAccBalTypeAccBalType", original_AccFundAccs.AdvPat_AccCoaSubAccBalTypeAccBalType, theAccFundAccs.AdvPat_AccCoaSubAccBalTypeAccBalType, true));
            values.Add(new FieldValue("AdvPat_AccCoaSubAccDestAccDest", original_AccFundAccs.AdvPat_AccCoaSubAccDestAccDest, theAccFundAccs.AdvPat_AccCoaSubAccDestAccDest, true));
            values.Add(new FieldValue("AdvPat_AccCoaSubAccFundAccFundCode", original_AccFundAccs.AdvPat_AccCoaSubAccFundAccFundCode, theAccFundAccs.AdvPat_AccCoaSubAccFundAccFundCode, true));
            values.Add(new FieldValue("AdvPat_AccCoaSubAccTypeAccType", original_AccFundAccs.AdvPat_AccCoaSubAccTypeAccType, theAccFundAccs.AdvPat_AccCoaSubAccTypeAccType, true));
            values.Add(new FieldValue("AdvPat_AccCoaSubCoaControlAccName", original_AccFundAccs.AdvPat_AccCoaSubCoaControlAccName, theAccFundAccs.AdvPat_AccCoaSubCoaControlAccName, true));
            values.Add(new FieldValue("AdvPat_AccCoaSubCoaMainAccName", original_AccFundAccs.AdvPat_AccCoaSubCoaMainAccName, theAccFundAccs.AdvPat_AccCoaSubCoaMainAccName, true));
            values.Add(new FieldValue("Investigate_Acc", original_AccFundAccs.Investigate_Acc, theAccFundAccs.Investigate_Acc));
            values.Add(new FieldValue("Investigate_AccAccName", original_AccFundAccs.Investigate_AccAccName, theAccFundAccs.Investigate_AccAccName, true));
            values.Add(new FieldValue("Investigate_AccAccBalTypeAccBalType", original_AccFundAccs.Investigate_AccAccBalTypeAccBalType, theAccFundAccs.Investigate_AccAccBalTypeAccBalType, true));
            values.Add(new FieldValue("Investigate_AccAccCurrencyAccCurrencyName", original_AccFundAccs.Investigate_AccAccCurrencyAccCurrencyName, theAccFundAccs.Investigate_AccAccCurrencyAccCurrencyName, true));
            values.Add(new FieldValue("Investigate_AccAccDestAccDest", original_AccFundAccs.Investigate_AccAccDestAccDest, theAccFundAccs.Investigate_AccAccDestAccDest, true));
            values.Add(new FieldValue("Investigate_AccAccDestCompanyTypeDescription", original_AccFundAccs.Investigate_AccAccDestCompanyTypeDescription, theAccFundAccs.Investigate_AccAccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("Investigate_AccAccFundAccFundCode", original_AccFundAccs.Investigate_AccAccFundAccFundCode, theAccFundAccs.Investigate_AccAccFundAccFundCode, true));
            values.Add(new FieldValue("Investigate_AccAccSubTypeAccSubType", original_AccFundAccs.Investigate_AccAccSubTypeAccSubType, theAccFundAccs.Investigate_AccAccSubTypeAccSubType, true));
            values.Add(new FieldValue("Investigate_AccAccTypeAccType", original_AccFundAccs.Investigate_AccAccTypeAccType, theAccFundAccs.Investigate_AccAccTypeAccType, true));
            values.Add(new FieldValue("Investigate_AccCoaControlAccName", original_AccFundAccs.Investigate_AccCoaControlAccName, theAccFundAccs.Investigate_AccCoaControlAccName, true));
            values.Add(new FieldValue("Investigate_AccCoaControlAccBalTypeAccBalType", original_AccFundAccs.Investigate_AccCoaControlAccBalTypeAccBalType, theAccFundAccs.Investigate_AccCoaControlAccBalTypeAccBalType, true));
            values.Add(new FieldValue("Investigate_AccCoaControlAccDestAccDest", original_AccFundAccs.Investigate_AccCoaControlAccDestAccDest, theAccFundAccs.Investigate_AccCoaControlAccDestAccDest, true));
            values.Add(new FieldValue("Investigate_AccCoaControlAccTypeAccType", original_AccFundAccs.Investigate_AccCoaControlAccTypeAccType, theAccFundAccs.Investigate_AccCoaControlAccTypeAccType, true));
            values.Add(new FieldValue("Investigate_AccCoaControlCompTypeDescription", original_AccFundAccs.Investigate_AccCoaControlCompTypeDescription, theAccFundAccs.Investigate_AccCoaControlCompTypeDescription, true));
            values.Add(new FieldValue("Investigate_AccCoaMainAccName", original_AccFundAccs.Investigate_AccCoaMainAccName, theAccFundAccs.Investigate_AccCoaMainAccName, true));
            values.Add(new FieldValue("Investigate_AccCoaMainAccBalTypeAccBalType", original_AccFundAccs.Investigate_AccCoaMainAccBalTypeAccBalType, theAccFundAccs.Investigate_AccCoaMainAccBalTypeAccBalType, true));
            values.Add(new FieldValue("Investigate_AccCoaMainAccDestAccDest", original_AccFundAccs.Investigate_AccCoaMainAccDestAccDest, theAccFundAccs.Investigate_AccCoaMainAccDestAccDest, true));
            values.Add(new FieldValue("Investigate_AccCoaMainAccFundAccFundCode", original_AccFundAccs.Investigate_AccCoaMainAccFundAccFundCode, theAccFundAccs.Investigate_AccCoaMainAccFundAccFundCode, true));
            values.Add(new FieldValue("Investigate_AccCoaMainAccTypeAccType", original_AccFundAccs.Investigate_AccCoaMainAccTypeAccType, theAccFundAccs.Investigate_AccCoaMainAccTypeAccType, true));
            values.Add(new FieldValue("Investigate_AccCoaMainCoaControlAccName", original_AccFundAccs.Investigate_AccCoaMainCoaControlAccName, theAccFundAccs.Investigate_AccCoaMainCoaControlAccName, true));
            values.Add(new FieldValue("Investigate_AccCoaSubAccName", original_AccFundAccs.Investigate_AccCoaSubAccName, theAccFundAccs.Investigate_AccCoaSubAccName, true));
            values.Add(new FieldValue("Investigate_AccCoaSubAccBalTypeAccBalType", original_AccFundAccs.Investigate_AccCoaSubAccBalTypeAccBalType, theAccFundAccs.Investigate_AccCoaSubAccBalTypeAccBalType, true));
            values.Add(new FieldValue("Investigate_AccCoaSubAccDestAccDest", original_AccFundAccs.Investigate_AccCoaSubAccDestAccDest, theAccFundAccs.Investigate_AccCoaSubAccDestAccDest, true));
            values.Add(new FieldValue("Investigate_AccCoaSubAccFundAccFundCode", original_AccFundAccs.Investigate_AccCoaSubAccFundAccFundCode, theAccFundAccs.Investigate_AccCoaSubAccFundAccFundCode, true));
            values.Add(new FieldValue("Investigate_AccCoaSubAccTypeAccType", original_AccFundAccs.Investigate_AccCoaSubAccTypeAccType, theAccFundAccs.Investigate_AccCoaSubAccTypeAccType, true));
            values.Add(new FieldValue("Investigate_AccCoaSubCoaControlAccName", original_AccFundAccs.Investigate_AccCoaSubCoaControlAccName, theAccFundAccs.Investigate_AccCoaSubCoaControlAccName, true));
            values.Add(new FieldValue("Investigate_AccCoaSubCoaMainAccName", original_AccFundAccs.Investigate_AccCoaSubCoaMainAccName, theAccFundAccs.Investigate_AccCoaSubCoaMainAccName, true));
            values.Add(new FieldValue("VatAcc", original_AccFundAccs.VatAcc, theAccFundAccs.VatAcc));
            values.Add(new FieldValue("VatAccAccName", original_AccFundAccs.VatAccAccName, theAccFundAccs.VatAccAccName, true));
            values.Add(new FieldValue("VatAccAccBalTypeAccBalType", original_AccFundAccs.VatAccAccBalTypeAccBalType, theAccFundAccs.VatAccAccBalTypeAccBalType, true));
            values.Add(new FieldValue("VatAccAccCurrencyAccCurrencyName", original_AccFundAccs.VatAccAccCurrencyAccCurrencyName, theAccFundAccs.VatAccAccCurrencyAccCurrencyName, true));
            values.Add(new FieldValue("VatAccAccDestAccDest", original_AccFundAccs.VatAccAccDestAccDest, theAccFundAccs.VatAccAccDestAccDest, true));
            values.Add(new FieldValue("VatAccAccDestCompanyTypeDescription", original_AccFundAccs.VatAccAccDestCompanyTypeDescription, theAccFundAccs.VatAccAccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("VatAccAccFundAccFundCode", original_AccFundAccs.VatAccAccFundAccFundCode, theAccFundAccs.VatAccAccFundAccFundCode, true));
            values.Add(new FieldValue("VatAccAccSubTypeAccSubType", original_AccFundAccs.VatAccAccSubTypeAccSubType, theAccFundAccs.VatAccAccSubTypeAccSubType, true));
            values.Add(new FieldValue("VatAccAccTypeAccType", original_AccFundAccs.VatAccAccTypeAccType, theAccFundAccs.VatAccAccTypeAccType, true));
            values.Add(new FieldValue("VatAccCoaControlAccName", original_AccFundAccs.VatAccCoaControlAccName, theAccFundAccs.VatAccCoaControlAccName, true));
            values.Add(new FieldValue("VatAccCoaControlAccBalTypeAccBalType", original_AccFundAccs.VatAccCoaControlAccBalTypeAccBalType, theAccFundAccs.VatAccCoaControlAccBalTypeAccBalType, true));
            values.Add(new FieldValue("VatAccCoaControlAccDestAccDest", original_AccFundAccs.VatAccCoaControlAccDestAccDest, theAccFundAccs.VatAccCoaControlAccDestAccDest, true));
            values.Add(new FieldValue("VatAccCoaControlAccTypeAccType", original_AccFundAccs.VatAccCoaControlAccTypeAccType, theAccFundAccs.VatAccCoaControlAccTypeAccType, true));
            values.Add(new FieldValue("VatAccCoaControlCompTypeDescription", original_AccFundAccs.VatAccCoaControlCompTypeDescription, theAccFundAccs.VatAccCoaControlCompTypeDescription, true));
            values.Add(new FieldValue("VatAccCoaMainAccName", original_AccFundAccs.VatAccCoaMainAccName, theAccFundAccs.VatAccCoaMainAccName, true));
            values.Add(new FieldValue("VatAccCoaMainAccBalTypeAccBalType", original_AccFundAccs.VatAccCoaMainAccBalTypeAccBalType, theAccFundAccs.VatAccCoaMainAccBalTypeAccBalType, true));
            values.Add(new FieldValue("VatAccCoaMainAccDestAccDest", original_AccFundAccs.VatAccCoaMainAccDestAccDest, theAccFundAccs.VatAccCoaMainAccDestAccDest, true));
            values.Add(new FieldValue("VatAccCoaMainAccFundAccFundCode", original_AccFundAccs.VatAccCoaMainAccFundAccFundCode, theAccFundAccs.VatAccCoaMainAccFundAccFundCode, true));
            values.Add(new FieldValue("VatAccCoaMainAccTypeAccType", original_AccFundAccs.VatAccCoaMainAccTypeAccType, theAccFundAccs.VatAccCoaMainAccTypeAccType, true));
            values.Add(new FieldValue("VatAccCoaMainCoaControlAccName", original_AccFundAccs.VatAccCoaMainCoaControlAccName, theAccFundAccs.VatAccCoaMainCoaControlAccName, true));
            values.Add(new FieldValue("VatAccCoaSubAccName", original_AccFundAccs.VatAccCoaSubAccName, theAccFundAccs.VatAccCoaSubAccName, true));
            values.Add(new FieldValue("VatAccCoaSubAccBalTypeAccBalType", original_AccFundAccs.VatAccCoaSubAccBalTypeAccBalType, theAccFundAccs.VatAccCoaSubAccBalTypeAccBalType, true));
            values.Add(new FieldValue("VatAccCoaSubAccDestAccDest", original_AccFundAccs.VatAccCoaSubAccDestAccDest, theAccFundAccs.VatAccCoaSubAccDestAccDest, true));
            values.Add(new FieldValue("VatAccCoaSubAccFundAccFundCode", original_AccFundAccs.VatAccCoaSubAccFundAccFundCode, theAccFundAccs.VatAccCoaSubAccFundAccFundCode, true));
            values.Add(new FieldValue("VatAccCoaSubAccTypeAccType", original_AccFundAccs.VatAccCoaSubAccTypeAccType, theAccFundAccs.VatAccCoaSubAccTypeAccType, true));
            values.Add(new FieldValue("VatAccCoaSubCoaControlAccName", original_AccFundAccs.VatAccCoaSubCoaControlAccName, theAccFundAccs.VatAccCoaSubCoaControlAccName, true));
            values.Add(new FieldValue("VatAccCoaSubCoaMainAccName", original_AccFundAccs.VatAccCoaSubCoaMainAccName, theAccFundAccs.VatAccCoaSubCoaMainAccName, true));
            values.Add(new FieldValue("SundryDebitors", original_AccFundAccs.SundryDebitors, theAccFundAccs.SundryDebitors));
            values.Add(new FieldValue("SundryDebitorsAccName", original_AccFundAccs.SundryDebitorsAccName, theAccFundAccs.SundryDebitorsAccName, true));
            values.Add(new FieldValue("SundryDebitorsAccBalTypeAccBalType", original_AccFundAccs.SundryDebitorsAccBalTypeAccBalType, theAccFundAccs.SundryDebitorsAccBalTypeAccBalType, true));
            values.Add(new FieldValue("SundryDebitorsAccCurrencyAccCurrencyName", original_AccFundAccs.SundryDebitorsAccCurrencyAccCurrencyName, theAccFundAccs.SundryDebitorsAccCurrencyAccCurrencyName, true));
            values.Add(new FieldValue("SundryDebitorsAccDestAccDest", original_AccFundAccs.SundryDebitorsAccDestAccDest, theAccFundAccs.SundryDebitorsAccDestAccDest, true));
            values.Add(new FieldValue("SundryDebitorsAccDestCompanyTypeDescription", original_AccFundAccs.SundryDebitorsAccDestCompanyTypeDescription, theAccFundAccs.SundryDebitorsAccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("SundryDebitorsAccFundAccFundCode", original_AccFundAccs.SundryDebitorsAccFundAccFundCode, theAccFundAccs.SundryDebitorsAccFundAccFundCode, true));
            values.Add(new FieldValue("SundryDebitorsAccSubTypeAccSubType", original_AccFundAccs.SundryDebitorsAccSubTypeAccSubType, theAccFundAccs.SundryDebitorsAccSubTypeAccSubType, true));
            values.Add(new FieldValue("SundryDebitorsAccTypeAccType", original_AccFundAccs.SundryDebitorsAccTypeAccType, theAccFundAccs.SundryDebitorsAccTypeAccType, true));
            values.Add(new FieldValue("SundryDebitorsCoaControlAccName", original_AccFundAccs.SundryDebitorsCoaControlAccName, theAccFundAccs.SundryDebitorsCoaControlAccName, true));
            values.Add(new FieldValue("SundryDebitorsCoaControlAccBalTypeAccBalType", original_AccFundAccs.SundryDebitorsCoaControlAccBalTypeAccBalType, theAccFundAccs.SundryDebitorsCoaControlAccBalTypeAccBalType, true));
            values.Add(new FieldValue("SundryDebitorsCoaControlAccDestAccDest", original_AccFundAccs.SundryDebitorsCoaControlAccDestAccDest, theAccFundAccs.SundryDebitorsCoaControlAccDestAccDest, true));
            values.Add(new FieldValue("SundryDebitorsCoaControlAccTypeAccType", original_AccFundAccs.SundryDebitorsCoaControlAccTypeAccType, theAccFundAccs.SundryDebitorsCoaControlAccTypeAccType, true));
            values.Add(new FieldValue("SundryDebitorsCoaControlCompTypeDescription", original_AccFundAccs.SundryDebitorsCoaControlCompTypeDescription, theAccFundAccs.SundryDebitorsCoaControlCompTypeDescription, true));
            values.Add(new FieldValue("SundryDebitorsCoaMainAccName", original_AccFundAccs.SundryDebitorsCoaMainAccName, theAccFundAccs.SundryDebitorsCoaMainAccName, true));
            values.Add(new FieldValue("SundryDebitorsCoaMainAccBalTypeAccBalType", original_AccFundAccs.SundryDebitorsCoaMainAccBalTypeAccBalType, theAccFundAccs.SundryDebitorsCoaMainAccBalTypeAccBalType, true));
            values.Add(new FieldValue("SundryDebitorsCoaMainAccDestAccDest", original_AccFundAccs.SundryDebitorsCoaMainAccDestAccDest, theAccFundAccs.SundryDebitorsCoaMainAccDestAccDest, true));
            values.Add(new FieldValue("SundryDebitorsCoaMainAccFundAccFundCode", original_AccFundAccs.SundryDebitorsCoaMainAccFundAccFundCode, theAccFundAccs.SundryDebitorsCoaMainAccFundAccFundCode, true));
            values.Add(new FieldValue("SundryDebitorsCoaMainAccTypeAccType", original_AccFundAccs.SundryDebitorsCoaMainAccTypeAccType, theAccFundAccs.SundryDebitorsCoaMainAccTypeAccType, true));
            values.Add(new FieldValue("SundryDebitorsCoaMainCoaControlAccName", original_AccFundAccs.SundryDebitorsCoaMainCoaControlAccName, theAccFundAccs.SundryDebitorsCoaMainCoaControlAccName, true));
            values.Add(new FieldValue("SundryDebitorsCoaSubAccName", original_AccFundAccs.SundryDebitorsCoaSubAccName, theAccFundAccs.SundryDebitorsCoaSubAccName, true));
            values.Add(new FieldValue("SundryDebitorsCoaSubAccBalTypeAccBalType", original_AccFundAccs.SundryDebitorsCoaSubAccBalTypeAccBalType, theAccFundAccs.SundryDebitorsCoaSubAccBalTypeAccBalType, true));
            values.Add(new FieldValue("SundryDebitorsCoaSubAccDestAccDest", original_AccFundAccs.SundryDebitorsCoaSubAccDestAccDest, theAccFundAccs.SundryDebitorsCoaSubAccDestAccDest, true));
            values.Add(new FieldValue("SundryDebitorsCoaSubAccFundAccFundCode", original_AccFundAccs.SundryDebitorsCoaSubAccFundAccFundCode, theAccFundAccs.SundryDebitorsCoaSubAccFundAccFundCode, true));
            values.Add(new FieldValue("SundryDebitorsCoaSubAccTypeAccType", original_AccFundAccs.SundryDebitorsCoaSubAccTypeAccType, theAccFundAccs.SundryDebitorsCoaSubAccTypeAccType, true));
            values.Add(new FieldValue("SundryDebitorsCoaSubCoaControlAccName", original_AccFundAccs.SundryDebitorsCoaSubCoaControlAccName, theAccFundAccs.SundryDebitorsCoaSubCoaControlAccName, true));
            values.Add(new FieldValue("SundryDebitorsCoaSubCoaMainAccName", original_AccFundAccs.SundryDebitorsCoaSubCoaMainAccName, theAccFundAccs.SundryDebitorsCoaSubCoaMainAccName, true));
            values.Add(new FieldValue("SundryCreditors", original_AccFundAccs.SundryCreditors, theAccFundAccs.SundryCreditors));
            values.Add(new FieldValue("SundryCreditorsAccName", original_AccFundAccs.SundryCreditorsAccName, theAccFundAccs.SundryCreditorsAccName, true));
            values.Add(new FieldValue("SundryCreditorsAccBalTypeAccBalType", original_AccFundAccs.SundryCreditorsAccBalTypeAccBalType, theAccFundAccs.SundryCreditorsAccBalTypeAccBalType, true));
            values.Add(new FieldValue("SundryCreditorsAccCurrencyAccCurrencyName", original_AccFundAccs.SundryCreditorsAccCurrencyAccCurrencyName, theAccFundAccs.SundryCreditorsAccCurrencyAccCurrencyName, true));
            values.Add(new FieldValue("SundryCreditorsAccDestAccDest", original_AccFundAccs.SundryCreditorsAccDestAccDest, theAccFundAccs.SundryCreditorsAccDestAccDest, true));
            values.Add(new FieldValue("SundryCreditorsAccDestCompanyTypeDescription", original_AccFundAccs.SundryCreditorsAccDestCompanyTypeDescription, theAccFundAccs.SundryCreditorsAccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("SundryCreditorsAccFundAccFundCode", original_AccFundAccs.SundryCreditorsAccFundAccFundCode, theAccFundAccs.SundryCreditorsAccFundAccFundCode, true));
            values.Add(new FieldValue("SundryCreditorsAccSubTypeAccSubType", original_AccFundAccs.SundryCreditorsAccSubTypeAccSubType, theAccFundAccs.SundryCreditorsAccSubTypeAccSubType, true));
            values.Add(new FieldValue("SundryCreditorsAccTypeAccType", original_AccFundAccs.SundryCreditorsAccTypeAccType, theAccFundAccs.SundryCreditorsAccTypeAccType, true));
            values.Add(new FieldValue("SundryCreditorsCoaControlAccName", original_AccFundAccs.SundryCreditorsCoaControlAccName, theAccFundAccs.SundryCreditorsCoaControlAccName, true));
            values.Add(new FieldValue("SundryCreditorsCoaControlAccBalTypeAccBalType", original_AccFundAccs.SundryCreditorsCoaControlAccBalTypeAccBalType, theAccFundAccs.SundryCreditorsCoaControlAccBalTypeAccBalType, true));
            values.Add(new FieldValue("SundryCreditorsCoaControlAccDestAccDest", original_AccFundAccs.SundryCreditorsCoaControlAccDestAccDest, theAccFundAccs.SundryCreditorsCoaControlAccDestAccDest, true));
            values.Add(new FieldValue("SundryCreditorsCoaControlAccTypeAccType", original_AccFundAccs.SundryCreditorsCoaControlAccTypeAccType, theAccFundAccs.SundryCreditorsCoaControlAccTypeAccType, true));
            values.Add(new FieldValue("SundryCreditorsCoaControlCompTypeDescription", original_AccFundAccs.SundryCreditorsCoaControlCompTypeDescription, theAccFundAccs.SundryCreditorsCoaControlCompTypeDescription, true));
            values.Add(new FieldValue("SundryCreditorsCoaMainAccName", original_AccFundAccs.SundryCreditorsCoaMainAccName, theAccFundAccs.SundryCreditorsCoaMainAccName, true));
            values.Add(new FieldValue("SundryCreditorsCoaMainAccBalTypeAccBalType", original_AccFundAccs.SundryCreditorsCoaMainAccBalTypeAccBalType, theAccFundAccs.SundryCreditorsCoaMainAccBalTypeAccBalType, true));
            values.Add(new FieldValue("SundryCreditorsCoaMainAccDestAccDest", original_AccFundAccs.SundryCreditorsCoaMainAccDestAccDest, theAccFundAccs.SundryCreditorsCoaMainAccDestAccDest, true));
            values.Add(new FieldValue("SundryCreditorsCoaMainAccFundAccFundCode", original_AccFundAccs.SundryCreditorsCoaMainAccFundAccFundCode, theAccFundAccs.SundryCreditorsCoaMainAccFundAccFundCode, true));
            values.Add(new FieldValue("SundryCreditorsCoaMainAccTypeAccType", original_AccFundAccs.SundryCreditorsCoaMainAccTypeAccType, theAccFundAccs.SundryCreditorsCoaMainAccTypeAccType, true));
            values.Add(new FieldValue("SundryCreditorsCoaMainCoaControlAccName", original_AccFundAccs.SundryCreditorsCoaMainCoaControlAccName, theAccFundAccs.SundryCreditorsCoaMainCoaControlAccName, true));
            values.Add(new FieldValue("SundryCreditorsCoaSubAccName", original_AccFundAccs.SundryCreditorsCoaSubAccName, theAccFundAccs.SundryCreditorsCoaSubAccName, true));
            values.Add(new FieldValue("SundryCreditorsCoaSubAccBalTypeAccBalType", original_AccFundAccs.SundryCreditorsCoaSubAccBalTypeAccBalType, theAccFundAccs.SundryCreditorsCoaSubAccBalTypeAccBalType, true));
            values.Add(new FieldValue("SundryCreditorsCoaSubAccDestAccDest", original_AccFundAccs.SundryCreditorsCoaSubAccDestAccDest, theAccFundAccs.SundryCreditorsCoaSubAccDestAccDest, true));
            values.Add(new FieldValue("SundryCreditorsCoaSubAccFundAccFundCode", original_AccFundAccs.SundryCreditorsCoaSubAccFundAccFundCode, theAccFundAccs.SundryCreditorsCoaSubAccFundAccFundCode, true));
            values.Add(new FieldValue("SundryCreditorsCoaSubAccTypeAccType", original_AccFundAccs.SundryCreditorsCoaSubAccTypeAccType, theAccFundAccs.SundryCreditorsCoaSubAccTypeAccType, true));
            values.Add(new FieldValue("SundryCreditorsCoaSubCoaControlAccName", original_AccFundAccs.SundryCreditorsCoaSubCoaControlAccName, theAccFundAccs.SundryCreditorsCoaSubCoaControlAccName, true));
            values.Add(new FieldValue("SundryCreditorsCoaSubCoaMainAccName", original_AccFundAccs.SundryCreditorsCoaSubCoaMainAccName, theAccFundAccs.SundryCreditorsCoaSubCoaMainAccName, true));
            values.Add(new FieldValue("RawMatAcc", original_AccFundAccs.RawMatAcc, theAccFundAccs.RawMatAcc));
            values.Add(new FieldValue("RawMatAccAccName", original_AccFundAccs.RawMatAccAccName, theAccFundAccs.RawMatAccAccName, true));
            values.Add(new FieldValue("RawMatAccAccBalTypeAccBalType", original_AccFundAccs.RawMatAccAccBalTypeAccBalType, theAccFundAccs.RawMatAccAccBalTypeAccBalType, true));
            values.Add(new FieldValue("RawMatAccAccCurrencyAccCurrencyName", original_AccFundAccs.RawMatAccAccCurrencyAccCurrencyName, theAccFundAccs.RawMatAccAccCurrencyAccCurrencyName, true));
            values.Add(new FieldValue("RawMatAccAccDestAccDest", original_AccFundAccs.RawMatAccAccDestAccDest, theAccFundAccs.RawMatAccAccDestAccDest, true));
            values.Add(new FieldValue("RawMatAccAccDestCompanyTypeDescription", original_AccFundAccs.RawMatAccAccDestCompanyTypeDescription, theAccFundAccs.RawMatAccAccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("RawMatAccAccFundAccFundCode", original_AccFundAccs.RawMatAccAccFundAccFundCode, theAccFundAccs.RawMatAccAccFundAccFundCode, true));
            values.Add(new FieldValue("RawMatAccAccSubTypeAccSubType", original_AccFundAccs.RawMatAccAccSubTypeAccSubType, theAccFundAccs.RawMatAccAccSubTypeAccSubType, true));
            values.Add(new FieldValue("RawMatAccAccTypeAccType", original_AccFundAccs.RawMatAccAccTypeAccType, theAccFundAccs.RawMatAccAccTypeAccType, true));
            values.Add(new FieldValue("RawMatAccCoaControlAccName", original_AccFundAccs.RawMatAccCoaControlAccName, theAccFundAccs.RawMatAccCoaControlAccName, true));
            values.Add(new FieldValue("RawMatAccCoaControlAccBalTypeAccBalType", original_AccFundAccs.RawMatAccCoaControlAccBalTypeAccBalType, theAccFundAccs.RawMatAccCoaControlAccBalTypeAccBalType, true));
            values.Add(new FieldValue("RawMatAccCoaControlAccDestAccDest", original_AccFundAccs.RawMatAccCoaControlAccDestAccDest, theAccFundAccs.RawMatAccCoaControlAccDestAccDest, true));
            values.Add(new FieldValue("RawMatAccCoaControlAccTypeAccType", original_AccFundAccs.RawMatAccCoaControlAccTypeAccType, theAccFundAccs.RawMatAccCoaControlAccTypeAccType, true));
            values.Add(new FieldValue("RawMatAccCoaControlCompTypeDescription", original_AccFundAccs.RawMatAccCoaControlCompTypeDescription, theAccFundAccs.RawMatAccCoaControlCompTypeDescription, true));
            values.Add(new FieldValue("RawMatAccCoaMainAccName", original_AccFundAccs.RawMatAccCoaMainAccName, theAccFundAccs.RawMatAccCoaMainAccName, true));
            values.Add(new FieldValue("RawMatAccCoaMainAccBalTypeAccBalType", original_AccFundAccs.RawMatAccCoaMainAccBalTypeAccBalType, theAccFundAccs.RawMatAccCoaMainAccBalTypeAccBalType, true));
            values.Add(new FieldValue("RawMatAccCoaMainAccDestAccDest", original_AccFundAccs.RawMatAccCoaMainAccDestAccDest, theAccFundAccs.RawMatAccCoaMainAccDestAccDest, true));
            values.Add(new FieldValue("RawMatAccCoaMainAccFundAccFundCode", original_AccFundAccs.RawMatAccCoaMainAccFundAccFundCode, theAccFundAccs.RawMatAccCoaMainAccFundAccFundCode, true));
            values.Add(new FieldValue("RawMatAccCoaMainAccTypeAccType", original_AccFundAccs.RawMatAccCoaMainAccTypeAccType, theAccFundAccs.RawMatAccCoaMainAccTypeAccType, true));
            values.Add(new FieldValue("RawMatAccCoaMainCoaControlAccName", original_AccFundAccs.RawMatAccCoaMainCoaControlAccName, theAccFundAccs.RawMatAccCoaMainCoaControlAccName, true));
            values.Add(new FieldValue("RawMatAccCoaSubAccName", original_AccFundAccs.RawMatAccCoaSubAccName, theAccFundAccs.RawMatAccCoaSubAccName, true));
            values.Add(new FieldValue("RawMatAccCoaSubAccBalTypeAccBalType", original_AccFundAccs.RawMatAccCoaSubAccBalTypeAccBalType, theAccFundAccs.RawMatAccCoaSubAccBalTypeAccBalType, true));
            values.Add(new FieldValue("RawMatAccCoaSubAccDestAccDest", original_AccFundAccs.RawMatAccCoaSubAccDestAccDest, theAccFundAccs.RawMatAccCoaSubAccDestAccDest, true));
            values.Add(new FieldValue("RawMatAccCoaSubAccFundAccFundCode", original_AccFundAccs.RawMatAccCoaSubAccFundAccFundCode, theAccFundAccs.RawMatAccCoaSubAccFundAccFundCode, true));
            values.Add(new FieldValue("RawMatAccCoaSubAccTypeAccType", original_AccFundAccs.RawMatAccCoaSubAccTypeAccType, theAccFundAccs.RawMatAccCoaSubAccTypeAccType, true));
            values.Add(new FieldValue("RawMatAccCoaSubCoaControlAccName", original_AccFundAccs.RawMatAccCoaSubCoaControlAccName, theAccFundAccs.RawMatAccCoaSubCoaControlAccName, true));
            values.Add(new FieldValue("RawMatAccCoaSubCoaMainAccName", original_AccFundAccs.RawMatAccCoaSubCoaMainAccName, theAccFundAccs.RawMatAccCoaSubCoaMainAccName, true));
            values.Add(new FieldValue("PackMatAcc", original_AccFundAccs.PackMatAcc, theAccFundAccs.PackMatAcc));
            values.Add(new FieldValue("PackMatAccAccName", original_AccFundAccs.PackMatAccAccName, theAccFundAccs.PackMatAccAccName, true));
            values.Add(new FieldValue("PackMatAccAccBalTypeAccBalType", original_AccFundAccs.PackMatAccAccBalTypeAccBalType, theAccFundAccs.PackMatAccAccBalTypeAccBalType, true));
            values.Add(new FieldValue("PackMatAccAccCurrencyAccCurrencyName", original_AccFundAccs.PackMatAccAccCurrencyAccCurrencyName, theAccFundAccs.PackMatAccAccCurrencyAccCurrencyName, true));
            values.Add(new FieldValue("PackMatAccAccDestAccDest", original_AccFundAccs.PackMatAccAccDestAccDest, theAccFundAccs.PackMatAccAccDestAccDest, true));
            values.Add(new FieldValue("PackMatAccAccDestCompanyTypeDescription", original_AccFundAccs.PackMatAccAccDestCompanyTypeDescription, theAccFundAccs.PackMatAccAccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("PackMatAccAccFundAccFundCode", original_AccFundAccs.PackMatAccAccFundAccFundCode, theAccFundAccs.PackMatAccAccFundAccFundCode, true));
            values.Add(new FieldValue("PackMatAccAccSubTypeAccSubType", original_AccFundAccs.PackMatAccAccSubTypeAccSubType, theAccFundAccs.PackMatAccAccSubTypeAccSubType, true));
            values.Add(new FieldValue("PackMatAccAccTypeAccType", original_AccFundAccs.PackMatAccAccTypeAccType, theAccFundAccs.PackMatAccAccTypeAccType, true));
            values.Add(new FieldValue("PackMatAccCoaControlAccName", original_AccFundAccs.PackMatAccCoaControlAccName, theAccFundAccs.PackMatAccCoaControlAccName, true));
            values.Add(new FieldValue("PackMatAccCoaControlAccBalTypeAccBalType", original_AccFundAccs.PackMatAccCoaControlAccBalTypeAccBalType, theAccFundAccs.PackMatAccCoaControlAccBalTypeAccBalType, true));
            values.Add(new FieldValue("PackMatAccCoaControlAccDestAccDest", original_AccFundAccs.PackMatAccCoaControlAccDestAccDest, theAccFundAccs.PackMatAccCoaControlAccDestAccDest, true));
            values.Add(new FieldValue("PackMatAccCoaControlAccTypeAccType", original_AccFundAccs.PackMatAccCoaControlAccTypeAccType, theAccFundAccs.PackMatAccCoaControlAccTypeAccType, true));
            values.Add(new FieldValue("PackMatAccCoaControlCompTypeDescription", original_AccFundAccs.PackMatAccCoaControlCompTypeDescription, theAccFundAccs.PackMatAccCoaControlCompTypeDescription, true));
            values.Add(new FieldValue("PackMatAccCoaMainAccName", original_AccFundAccs.PackMatAccCoaMainAccName, theAccFundAccs.PackMatAccCoaMainAccName, true));
            values.Add(new FieldValue("PackMatAccCoaMainAccBalTypeAccBalType", original_AccFundAccs.PackMatAccCoaMainAccBalTypeAccBalType, theAccFundAccs.PackMatAccCoaMainAccBalTypeAccBalType, true));
            values.Add(new FieldValue("PackMatAccCoaMainAccDestAccDest", original_AccFundAccs.PackMatAccCoaMainAccDestAccDest, theAccFundAccs.PackMatAccCoaMainAccDestAccDest, true));
            values.Add(new FieldValue("PackMatAccCoaMainAccFundAccFundCode", original_AccFundAccs.PackMatAccCoaMainAccFundAccFundCode, theAccFundAccs.PackMatAccCoaMainAccFundAccFundCode, true));
            values.Add(new FieldValue("PackMatAccCoaMainAccTypeAccType", original_AccFundAccs.PackMatAccCoaMainAccTypeAccType, theAccFundAccs.PackMatAccCoaMainAccTypeAccType, true));
            values.Add(new FieldValue("PackMatAccCoaMainCoaControlAccName", original_AccFundAccs.PackMatAccCoaMainCoaControlAccName, theAccFundAccs.PackMatAccCoaMainCoaControlAccName, true));
            values.Add(new FieldValue("PackMatAccCoaSubAccName", original_AccFundAccs.PackMatAccCoaSubAccName, theAccFundAccs.PackMatAccCoaSubAccName, true));
            values.Add(new FieldValue("PackMatAccCoaSubAccBalTypeAccBalType", original_AccFundAccs.PackMatAccCoaSubAccBalTypeAccBalType, theAccFundAccs.PackMatAccCoaSubAccBalTypeAccBalType, true));
            values.Add(new FieldValue("PackMatAccCoaSubAccDestAccDest", original_AccFundAccs.PackMatAccCoaSubAccDestAccDest, theAccFundAccs.PackMatAccCoaSubAccDestAccDest, true));
            values.Add(new FieldValue("PackMatAccCoaSubAccFundAccFundCode", original_AccFundAccs.PackMatAccCoaSubAccFundAccFundCode, theAccFundAccs.PackMatAccCoaSubAccFundAccFundCode, true));
            values.Add(new FieldValue("PackMatAccCoaSubAccTypeAccType", original_AccFundAccs.PackMatAccCoaSubAccTypeAccType, theAccFundAccs.PackMatAccCoaSubAccTypeAccType, true));
            values.Add(new FieldValue("PackMatAccCoaSubCoaControlAccName", original_AccFundAccs.PackMatAccCoaSubCoaControlAccName, theAccFundAccs.PackMatAccCoaSubCoaControlAccName, true));
            values.Add(new FieldValue("PackMatAccCoaSubCoaMainAccName", original_AccFundAccs.PackMatAccCoaSubCoaMainAccName, theAccFundAccs.PackMatAccCoaSubCoaMainAccName, true));
            values.Add(new FieldValue("OtherMatAcc", original_AccFundAccs.OtherMatAcc, theAccFundAccs.OtherMatAcc));
            values.Add(new FieldValue("OtherMatAccAccName", original_AccFundAccs.OtherMatAccAccName, theAccFundAccs.OtherMatAccAccName, true));
            values.Add(new FieldValue("OtherMatAccAccBalTypeAccBalType", original_AccFundAccs.OtherMatAccAccBalTypeAccBalType, theAccFundAccs.OtherMatAccAccBalTypeAccBalType, true));
            values.Add(new FieldValue("OtherMatAccAccCurrencyAccCurrencyName", original_AccFundAccs.OtherMatAccAccCurrencyAccCurrencyName, theAccFundAccs.OtherMatAccAccCurrencyAccCurrencyName, true));
            values.Add(new FieldValue("OtherMatAccAccDestAccDest", original_AccFundAccs.OtherMatAccAccDestAccDest, theAccFundAccs.OtherMatAccAccDestAccDest, true));
            values.Add(new FieldValue("OtherMatAccAccDestCompanyTypeDescription", original_AccFundAccs.OtherMatAccAccDestCompanyTypeDescription, theAccFundAccs.OtherMatAccAccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("OtherMatAccAccFundAccFundCode", original_AccFundAccs.OtherMatAccAccFundAccFundCode, theAccFundAccs.OtherMatAccAccFundAccFundCode, true));
            values.Add(new FieldValue("OtherMatAccAccSubTypeAccSubType", original_AccFundAccs.OtherMatAccAccSubTypeAccSubType, theAccFundAccs.OtherMatAccAccSubTypeAccSubType, true));
            values.Add(new FieldValue("OtherMatAccAccTypeAccType", original_AccFundAccs.OtherMatAccAccTypeAccType, theAccFundAccs.OtherMatAccAccTypeAccType, true));
            values.Add(new FieldValue("OtherMatAccCoaControlAccName", original_AccFundAccs.OtherMatAccCoaControlAccName, theAccFundAccs.OtherMatAccCoaControlAccName, true));
            values.Add(new FieldValue("OtherMatAccCoaControlAccBalTypeAccBalType", original_AccFundAccs.OtherMatAccCoaControlAccBalTypeAccBalType, theAccFundAccs.OtherMatAccCoaControlAccBalTypeAccBalType, true));
            values.Add(new FieldValue("OtherMatAccCoaControlAccDestAccDest", original_AccFundAccs.OtherMatAccCoaControlAccDestAccDest, theAccFundAccs.OtherMatAccCoaControlAccDestAccDest, true));
            values.Add(new FieldValue("OtherMatAccCoaControlAccTypeAccType", original_AccFundAccs.OtherMatAccCoaControlAccTypeAccType, theAccFundAccs.OtherMatAccCoaControlAccTypeAccType, true));
            values.Add(new FieldValue("OtherMatAccCoaControlCompTypeDescription", original_AccFundAccs.OtherMatAccCoaControlCompTypeDescription, theAccFundAccs.OtherMatAccCoaControlCompTypeDescription, true));
            values.Add(new FieldValue("OtherMatAccCoaMainAccName", original_AccFundAccs.OtherMatAccCoaMainAccName, theAccFundAccs.OtherMatAccCoaMainAccName, true));
            values.Add(new FieldValue("OtherMatAccCoaMainAccBalTypeAccBalType", original_AccFundAccs.OtherMatAccCoaMainAccBalTypeAccBalType, theAccFundAccs.OtherMatAccCoaMainAccBalTypeAccBalType, true));
            values.Add(new FieldValue("OtherMatAccCoaMainAccDestAccDest", original_AccFundAccs.OtherMatAccCoaMainAccDestAccDest, theAccFundAccs.OtherMatAccCoaMainAccDestAccDest, true));
            values.Add(new FieldValue("OtherMatAccCoaMainAccFundAccFundCode", original_AccFundAccs.OtherMatAccCoaMainAccFundAccFundCode, theAccFundAccs.OtherMatAccCoaMainAccFundAccFundCode, true));
            values.Add(new FieldValue("OtherMatAccCoaMainAccTypeAccType", original_AccFundAccs.OtherMatAccCoaMainAccTypeAccType, theAccFundAccs.OtherMatAccCoaMainAccTypeAccType, true));
            values.Add(new FieldValue("OtherMatAccCoaMainCoaControlAccName", original_AccFundAccs.OtherMatAccCoaMainCoaControlAccName, theAccFundAccs.OtherMatAccCoaMainCoaControlAccName, true));
            values.Add(new FieldValue("OtherMatAccCoaSubAccName", original_AccFundAccs.OtherMatAccCoaSubAccName, theAccFundAccs.OtherMatAccCoaSubAccName, true));
            values.Add(new FieldValue("OtherMatAccCoaSubAccBalTypeAccBalType", original_AccFundAccs.OtherMatAccCoaSubAccBalTypeAccBalType, theAccFundAccs.OtherMatAccCoaSubAccBalTypeAccBalType, true));
            values.Add(new FieldValue("OtherMatAccCoaSubAccDestAccDest", original_AccFundAccs.OtherMatAccCoaSubAccDestAccDest, theAccFundAccs.OtherMatAccCoaSubAccDestAccDest, true));
            values.Add(new FieldValue("OtherMatAccCoaSubAccFundAccFundCode", original_AccFundAccs.OtherMatAccCoaSubAccFundAccFundCode, theAccFundAccs.OtherMatAccCoaSubAccFundAccFundCode, true));
            values.Add(new FieldValue("OtherMatAccCoaSubAccTypeAccType", original_AccFundAccs.OtherMatAccCoaSubAccTypeAccType, theAccFundAccs.OtherMatAccCoaSubAccTypeAccType, true));
            values.Add(new FieldValue("OtherMatAccCoaSubCoaControlAccName", original_AccFundAccs.OtherMatAccCoaSubCoaControlAccName, theAccFundAccs.OtherMatAccCoaSubCoaControlAccName, true));
            values.Add(new FieldValue("OtherMatAccCoaSubCoaMainAccName", original_AccFundAccs.OtherMatAccCoaSubCoaMainAccName, theAccFundAccs.OtherMatAccCoaSubCoaMainAccName, true));
            values.Add(new FieldValue("FinishMatAcc", original_AccFundAccs.FinishMatAcc, theAccFundAccs.FinishMatAcc));
            values.Add(new FieldValue("FinishMatAccAccName", original_AccFundAccs.FinishMatAccAccName, theAccFundAccs.FinishMatAccAccName, true));
            values.Add(new FieldValue("FinishMatAccAccBalTypeAccBalType", original_AccFundAccs.FinishMatAccAccBalTypeAccBalType, theAccFundAccs.FinishMatAccAccBalTypeAccBalType, true));
            values.Add(new FieldValue("FinishMatAccAccCurrencyAccCurrencyName", original_AccFundAccs.FinishMatAccAccCurrencyAccCurrencyName, theAccFundAccs.FinishMatAccAccCurrencyAccCurrencyName, true));
            values.Add(new FieldValue("FinishMatAccAccDestAccDest", original_AccFundAccs.FinishMatAccAccDestAccDest, theAccFundAccs.FinishMatAccAccDestAccDest, true));
            values.Add(new FieldValue("FinishMatAccAccDestCompanyTypeDescription", original_AccFundAccs.FinishMatAccAccDestCompanyTypeDescription, theAccFundAccs.FinishMatAccAccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("FinishMatAccAccFundAccFundCode", original_AccFundAccs.FinishMatAccAccFundAccFundCode, theAccFundAccs.FinishMatAccAccFundAccFundCode, true));
            values.Add(new FieldValue("FinishMatAccAccSubTypeAccSubType", original_AccFundAccs.FinishMatAccAccSubTypeAccSubType, theAccFundAccs.FinishMatAccAccSubTypeAccSubType, true));
            values.Add(new FieldValue("FinishMatAccAccTypeAccType", original_AccFundAccs.FinishMatAccAccTypeAccType, theAccFundAccs.FinishMatAccAccTypeAccType, true));
            values.Add(new FieldValue("FinishMatAccCoaControlAccName", original_AccFundAccs.FinishMatAccCoaControlAccName, theAccFundAccs.FinishMatAccCoaControlAccName, true));
            values.Add(new FieldValue("FinishMatAccCoaControlAccBalTypeAccBalType", original_AccFundAccs.FinishMatAccCoaControlAccBalTypeAccBalType, theAccFundAccs.FinishMatAccCoaControlAccBalTypeAccBalType, true));
            values.Add(new FieldValue("FinishMatAccCoaControlAccDestAccDest", original_AccFundAccs.FinishMatAccCoaControlAccDestAccDest, theAccFundAccs.FinishMatAccCoaControlAccDestAccDest, true));
            values.Add(new FieldValue("FinishMatAccCoaControlAccTypeAccType", original_AccFundAccs.FinishMatAccCoaControlAccTypeAccType, theAccFundAccs.FinishMatAccCoaControlAccTypeAccType, true));
            values.Add(new FieldValue("FinishMatAccCoaControlCompTypeDescription", original_AccFundAccs.FinishMatAccCoaControlCompTypeDescription, theAccFundAccs.FinishMatAccCoaControlCompTypeDescription, true));
            values.Add(new FieldValue("FinishMatAccCoaMainAccName", original_AccFundAccs.FinishMatAccCoaMainAccName, theAccFundAccs.FinishMatAccCoaMainAccName, true));
            values.Add(new FieldValue("FinishMatAccCoaMainAccBalTypeAccBalType", original_AccFundAccs.FinishMatAccCoaMainAccBalTypeAccBalType, theAccFundAccs.FinishMatAccCoaMainAccBalTypeAccBalType, true));
            values.Add(new FieldValue("FinishMatAccCoaMainAccDestAccDest", original_AccFundAccs.FinishMatAccCoaMainAccDestAccDest, theAccFundAccs.FinishMatAccCoaMainAccDestAccDest, true));
            values.Add(new FieldValue("FinishMatAccCoaMainAccFundAccFundCode", original_AccFundAccs.FinishMatAccCoaMainAccFundAccFundCode, theAccFundAccs.FinishMatAccCoaMainAccFundAccFundCode, true));
            values.Add(new FieldValue("FinishMatAccCoaMainAccTypeAccType", original_AccFundAccs.FinishMatAccCoaMainAccTypeAccType, theAccFundAccs.FinishMatAccCoaMainAccTypeAccType, true));
            values.Add(new FieldValue("FinishMatAccCoaMainCoaControlAccName", original_AccFundAccs.FinishMatAccCoaMainCoaControlAccName, theAccFundAccs.FinishMatAccCoaMainCoaControlAccName, true));
            values.Add(new FieldValue("FinishMatAccCoaSubAccName", original_AccFundAccs.FinishMatAccCoaSubAccName, theAccFundAccs.FinishMatAccCoaSubAccName, true));
            values.Add(new FieldValue("FinishMatAccCoaSubAccBalTypeAccBalType", original_AccFundAccs.FinishMatAccCoaSubAccBalTypeAccBalType, theAccFundAccs.FinishMatAccCoaSubAccBalTypeAccBalType, true));
            values.Add(new FieldValue("FinishMatAccCoaSubAccDestAccDest", original_AccFundAccs.FinishMatAccCoaSubAccDestAccDest, theAccFundAccs.FinishMatAccCoaSubAccDestAccDest, true));
            values.Add(new FieldValue("FinishMatAccCoaSubAccFundAccFundCode", original_AccFundAccs.FinishMatAccCoaSubAccFundAccFundCode, theAccFundAccs.FinishMatAccCoaSubAccFundAccFundCode, true));
            values.Add(new FieldValue("FinishMatAccCoaSubAccTypeAccType", original_AccFundAccs.FinishMatAccCoaSubAccTypeAccType, theAccFundAccs.FinishMatAccCoaSubAccTypeAccType, true));
            values.Add(new FieldValue("FinishMatAccCoaSubCoaControlAccName", original_AccFundAccs.FinishMatAccCoaSubCoaControlAccName, theAccFundAccs.FinishMatAccCoaSubCoaControlAccName, true));
            values.Add(new FieldValue("FinishMatAccCoaSubCoaMainAccName", original_AccFundAccs.FinishMatAccCoaSubCoaMainAccName, theAccFundAccs.FinishMatAccCoaSubCoaMainAccName, true));
            values.Add(new FieldValue("AdminExpAcc", original_AccFundAccs.AdminExpAcc, theAccFundAccs.AdminExpAcc));
            values.Add(new FieldValue("AdminExpAccAccName", original_AccFundAccs.AdminExpAccAccName, theAccFundAccs.AdminExpAccAccName, true));
            values.Add(new FieldValue("AdminExpAccAccBalTypeAccBalType", original_AccFundAccs.AdminExpAccAccBalTypeAccBalType, theAccFundAccs.AdminExpAccAccBalTypeAccBalType, true));
            values.Add(new FieldValue("AdminExpAccAccCurrencyAccCurrencyName", original_AccFundAccs.AdminExpAccAccCurrencyAccCurrencyName, theAccFundAccs.AdminExpAccAccCurrencyAccCurrencyName, true));
            values.Add(new FieldValue("AdminExpAccAccDestAccDest", original_AccFundAccs.AdminExpAccAccDestAccDest, theAccFundAccs.AdminExpAccAccDestAccDest, true));
            values.Add(new FieldValue("AdminExpAccAccDestCompanyTypeDescription", original_AccFundAccs.AdminExpAccAccDestCompanyTypeDescription, theAccFundAccs.AdminExpAccAccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("AdminExpAccAccFundAccFundCode", original_AccFundAccs.AdminExpAccAccFundAccFundCode, theAccFundAccs.AdminExpAccAccFundAccFundCode, true));
            values.Add(new FieldValue("AdminExpAccAccSubTypeAccSubType", original_AccFundAccs.AdminExpAccAccSubTypeAccSubType, theAccFundAccs.AdminExpAccAccSubTypeAccSubType, true));
            values.Add(new FieldValue("AdminExpAccAccTypeAccType", original_AccFundAccs.AdminExpAccAccTypeAccType, theAccFundAccs.AdminExpAccAccTypeAccType, true));
            values.Add(new FieldValue("AdminExpAccCoaControlAccName", original_AccFundAccs.AdminExpAccCoaControlAccName, theAccFundAccs.AdminExpAccCoaControlAccName, true));
            values.Add(new FieldValue("AdminExpAccCoaControlAccBalTypeAccBalType", original_AccFundAccs.AdminExpAccCoaControlAccBalTypeAccBalType, theAccFundAccs.AdminExpAccCoaControlAccBalTypeAccBalType, true));
            values.Add(new FieldValue("AdminExpAccCoaControlAccDestAccDest", original_AccFundAccs.AdminExpAccCoaControlAccDestAccDest, theAccFundAccs.AdminExpAccCoaControlAccDestAccDest, true));
            values.Add(new FieldValue("AdminExpAccCoaControlAccTypeAccType", original_AccFundAccs.AdminExpAccCoaControlAccTypeAccType, theAccFundAccs.AdminExpAccCoaControlAccTypeAccType, true));
            values.Add(new FieldValue("AdminExpAccCoaControlCompTypeDescription", original_AccFundAccs.AdminExpAccCoaControlCompTypeDescription, theAccFundAccs.AdminExpAccCoaControlCompTypeDescription, true));
            values.Add(new FieldValue("AdminExpAccCoaMainAccName", original_AccFundAccs.AdminExpAccCoaMainAccName, theAccFundAccs.AdminExpAccCoaMainAccName, true));
            values.Add(new FieldValue("AdminExpAccCoaMainAccBalTypeAccBalType", original_AccFundAccs.AdminExpAccCoaMainAccBalTypeAccBalType, theAccFundAccs.AdminExpAccCoaMainAccBalTypeAccBalType, true));
            values.Add(new FieldValue("AdminExpAccCoaMainAccDestAccDest", original_AccFundAccs.AdminExpAccCoaMainAccDestAccDest, theAccFundAccs.AdminExpAccCoaMainAccDestAccDest, true));
            values.Add(new FieldValue("AdminExpAccCoaMainAccFundAccFundCode", original_AccFundAccs.AdminExpAccCoaMainAccFundAccFundCode, theAccFundAccs.AdminExpAccCoaMainAccFundAccFundCode, true));
            values.Add(new FieldValue("AdminExpAccCoaMainAccTypeAccType", original_AccFundAccs.AdminExpAccCoaMainAccTypeAccType, theAccFundAccs.AdminExpAccCoaMainAccTypeAccType, true));
            values.Add(new FieldValue("AdminExpAccCoaMainCoaControlAccName", original_AccFundAccs.AdminExpAccCoaMainCoaControlAccName, theAccFundAccs.AdminExpAccCoaMainCoaControlAccName, true));
            values.Add(new FieldValue("AdminExpAccCoaSubAccName", original_AccFundAccs.AdminExpAccCoaSubAccName, theAccFundAccs.AdminExpAccCoaSubAccName, true));
            values.Add(new FieldValue("AdminExpAccCoaSubAccBalTypeAccBalType", original_AccFundAccs.AdminExpAccCoaSubAccBalTypeAccBalType, theAccFundAccs.AdminExpAccCoaSubAccBalTypeAccBalType, true));
            values.Add(new FieldValue("AdminExpAccCoaSubAccDestAccDest", original_AccFundAccs.AdminExpAccCoaSubAccDestAccDest, theAccFundAccs.AdminExpAccCoaSubAccDestAccDest, true));
            values.Add(new FieldValue("AdminExpAccCoaSubAccFundAccFundCode", original_AccFundAccs.AdminExpAccCoaSubAccFundAccFundCode, theAccFundAccs.AdminExpAccCoaSubAccFundAccFundCode, true));
            values.Add(new FieldValue("AdminExpAccCoaSubAccTypeAccType", original_AccFundAccs.AdminExpAccCoaSubAccTypeAccType, theAccFundAccs.AdminExpAccCoaSubAccTypeAccType, true));
            values.Add(new FieldValue("AdminExpAccCoaSubCoaControlAccName", original_AccFundAccs.AdminExpAccCoaSubCoaControlAccName, theAccFundAccs.AdminExpAccCoaSubCoaControlAccName, true));
            values.Add(new FieldValue("AdminExpAccCoaSubCoaMainAccName", original_AccFundAccs.AdminExpAccCoaSubCoaMainAccName, theAccFundAccs.AdminExpAccCoaSubCoaMainAccName, true));
            values.Add(new FieldValue("SellingExpAcc", original_AccFundAccs.SellingExpAcc, theAccFundAccs.SellingExpAcc));
            values.Add(new FieldValue("SellingExpAccAccName", original_AccFundAccs.SellingExpAccAccName, theAccFundAccs.SellingExpAccAccName, true));
            values.Add(new FieldValue("SellingExpAccAccBalTypeAccBalType", original_AccFundAccs.SellingExpAccAccBalTypeAccBalType, theAccFundAccs.SellingExpAccAccBalTypeAccBalType, true));
            values.Add(new FieldValue("SellingExpAccAccCurrencyAccCurrencyName", original_AccFundAccs.SellingExpAccAccCurrencyAccCurrencyName, theAccFundAccs.SellingExpAccAccCurrencyAccCurrencyName, true));
            values.Add(new FieldValue("SellingExpAccAccDestAccDest", original_AccFundAccs.SellingExpAccAccDestAccDest, theAccFundAccs.SellingExpAccAccDestAccDest, true));
            values.Add(new FieldValue("SellingExpAccAccDestCompanyTypeDescription", original_AccFundAccs.SellingExpAccAccDestCompanyTypeDescription, theAccFundAccs.SellingExpAccAccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("SellingExpAccAccFundAccFundCode", original_AccFundAccs.SellingExpAccAccFundAccFundCode, theAccFundAccs.SellingExpAccAccFundAccFundCode, true));
            values.Add(new FieldValue("SellingExpAccAccSubTypeAccSubType", original_AccFundAccs.SellingExpAccAccSubTypeAccSubType, theAccFundAccs.SellingExpAccAccSubTypeAccSubType, true));
            values.Add(new FieldValue("SellingExpAccAccTypeAccType", original_AccFundAccs.SellingExpAccAccTypeAccType, theAccFundAccs.SellingExpAccAccTypeAccType, true));
            values.Add(new FieldValue("SellingExpAccCoaControlAccName", original_AccFundAccs.SellingExpAccCoaControlAccName, theAccFundAccs.SellingExpAccCoaControlAccName, true));
            values.Add(new FieldValue("SellingExpAccCoaControlAccBalTypeAccBalType", original_AccFundAccs.SellingExpAccCoaControlAccBalTypeAccBalType, theAccFundAccs.SellingExpAccCoaControlAccBalTypeAccBalType, true));
            values.Add(new FieldValue("SellingExpAccCoaControlAccDestAccDest", original_AccFundAccs.SellingExpAccCoaControlAccDestAccDest, theAccFundAccs.SellingExpAccCoaControlAccDestAccDest, true));
            values.Add(new FieldValue("SellingExpAccCoaControlAccTypeAccType", original_AccFundAccs.SellingExpAccCoaControlAccTypeAccType, theAccFundAccs.SellingExpAccCoaControlAccTypeAccType, true));
            values.Add(new FieldValue("SellingExpAccCoaControlCompTypeDescription", original_AccFundAccs.SellingExpAccCoaControlCompTypeDescription, theAccFundAccs.SellingExpAccCoaControlCompTypeDescription, true));
            values.Add(new FieldValue("SellingExpAccCoaMainAccName", original_AccFundAccs.SellingExpAccCoaMainAccName, theAccFundAccs.SellingExpAccCoaMainAccName, true));
            values.Add(new FieldValue("SellingExpAccCoaMainAccBalTypeAccBalType", original_AccFundAccs.SellingExpAccCoaMainAccBalTypeAccBalType, theAccFundAccs.SellingExpAccCoaMainAccBalTypeAccBalType, true));
            values.Add(new FieldValue("SellingExpAccCoaMainAccDestAccDest", original_AccFundAccs.SellingExpAccCoaMainAccDestAccDest, theAccFundAccs.SellingExpAccCoaMainAccDestAccDest, true));
            values.Add(new FieldValue("SellingExpAccCoaMainAccFundAccFundCode", original_AccFundAccs.SellingExpAccCoaMainAccFundAccFundCode, theAccFundAccs.SellingExpAccCoaMainAccFundAccFundCode, true));
            values.Add(new FieldValue("SellingExpAccCoaMainAccTypeAccType", original_AccFundAccs.SellingExpAccCoaMainAccTypeAccType, theAccFundAccs.SellingExpAccCoaMainAccTypeAccType, true));
            values.Add(new FieldValue("SellingExpAccCoaMainCoaControlAccName", original_AccFundAccs.SellingExpAccCoaMainCoaControlAccName, theAccFundAccs.SellingExpAccCoaMainCoaControlAccName, true));
            values.Add(new FieldValue("SellingExpAccCoaSubAccName", original_AccFundAccs.SellingExpAccCoaSubAccName, theAccFundAccs.SellingExpAccCoaSubAccName, true));
            values.Add(new FieldValue("SellingExpAccCoaSubAccBalTypeAccBalType", original_AccFundAccs.SellingExpAccCoaSubAccBalTypeAccBalType, theAccFundAccs.SellingExpAccCoaSubAccBalTypeAccBalType, true));
            values.Add(new FieldValue("SellingExpAccCoaSubAccDestAccDest", original_AccFundAccs.SellingExpAccCoaSubAccDestAccDest, theAccFundAccs.SellingExpAccCoaSubAccDestAccDest, true));
            values.Add(new FieldValue("SellingExpAccCoaSubAccFundAccFundCode", original_AccFundAccs.SellingExpAccCoaSubAccFundAccFundCode, theAccFundAccs.SellingExpAccCoaSubAccFundAccFundCode, true));
            values.Add(new FieldValue("SellingExpAccCoaSubAccTypeAccType", original_AccFundAccs.SellingExpAccCoaSubAccTypeAccType, theAccFundAccs.SellingExpAccCoaSubAccTypeAccType, true));
            values.Add(new FieldValue("SellingExpAccCoaSubCoaControlAccName", original_AccFundAccs.SellingExpAccCoaSubCoaControlAccName, theAccFundAccs.SellingExpAccCoaSubCoaControlAccName, true));
            values.Add(new FieldValue("SellingExpAccCoaSubCoaMainAccName", original_AccFundAccs.SellingExpAccCoaSubCoaMainAccName, theAccFundAccs.SellingExpAccCoaSubCoaMainAccName, true));
            values.Add(new FieldValue("ManuExpAcc", original_AccFundAccs.ManuExpAcc, theAccFundAccs.ManuExpAcc));
            values.Add(new FieldValue("ManuExpAccAccName", original_AccFundAccs.ManuExpAccAccName, theAccFundAccs.ManuExpAccAccName, true));
            values.Add(new FieldValue("ManuExpAccAccBalTypeAccBalType", original_AccFundAccs.ManuExpAccAccBalTypeAccBalType, theAccFundAccs.ManuExpAccAccBalTypeAccBalType, true));
            values.Add(new FieldValue("ManuExpAccAccCurrencyAccCurrencyName", original_AccFundAccs.ManuExpAccAccCurrencyAccCurrencyName, theAccFundAccs.ManuExpAccAccCurrencyAccCurrencyName, true));
            values.Add(new FieldValue("ManuExpAccAccDestAccDest", original_AccFundAccs.ManuExpAccAccDestAccDest, theAccFundAccs.ManuExpAccAccDestAccDest, true));
            values.Add(new FieldValue("ManuExpAccAccDestCompanyTypeDescription", original_AccFundAccs.ManuExpAccAccDestCompanyTypeDescription, theAccFundAccs.ManuExpAccAccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("ManuExpAccAccFundAccFundCode", original_AccFundAccs.ManuExpAccAccFundAccFundCode, theAccFundAccs.ManuExpAccAccFundAccFundCode, true));
            values.Add(new FieldValue("ManuExpAccAccSubTypeAccSubType", original_AccFundAccs.ManuExpAccAccSubTypeAccSubType, theAccFundAccs.ManuExpAccAccSubTypeAccSubType, true));
            values.Add(new FieldValue("ManuExpAccAccTypeAccType", original_AccFundAccs.ManuExpAccAccTypeAccType, theAccFundAccs.ManuExpAccAccTypeAccType, true));
            values.Add(new FieldValue("ManuExpAccCoaControlAccName", original_AccFundAccs.ManuExpAccCoaControlAccName, theAccFundAccs.ManuExpAccCoaControlAccName, true));
            values.Add(new FieldValue("ManuExpAccCoaControlAccBalTypeAccBalType", original_AccFundAccs.ManuExpAccCoaControlAccBalTypeAccBalType, theAccFundAccs.ManuExpAccCoaControlAccBalTypeAccBalType, true));
            values.Add(new FieldValue("ManuExpAccCoaControlAccDestAccDest", original_AccFundAccs.ManuExpAccCoaControlAccDestAccDest, theAccFundAccs.ManuExpAccCoaControlAccDestAccDest, true));
            values.Add(new FieldValue("ManuExpAccCoaControlAccTypeAccType", original_AccFundAccs.ManuExpAccCoaControlAccTypeAccType, theAccFundAccs.ManuExpAccCoaControlAccTypeAccType, true));
            values.Add(new FieldValue("ManuExpAccCoaControlCompTypeDescription", original_AccFundAccs.ManuExpAccCoaControlCompTypeDescription, theAccFundAccs.ManuExpAccCoaControlCompTypeDescription, true));
            values.Add(new FieldValue("ManuExpAccCoaMainAccName", original_AccFundAccs.ManuExpAccCoaMainAccName, theAccFundAccs.ManuExpAccCoaMainAccName, true));
            values.Add(new FieldValue("ManuExpAccCoaMainAccBalTypeAccBalType", original_AccFundAccs.ManuExpAccCoaMainAccBalTypeAccBalType, theAccFundAccs.ManuExpAccCoaMainAccBalTypeAccBalType, true));
            values.Add(new FieldValue("ManuExpAccCoaMainAccDestAccDest", original_AccFundAccs.ManuExpAccCoaMainAccDestAccDest, theAccFundAccs.ManuExpAccCoaMainAccDestAccDest, true));
            values.Add(new FieldValue("ManuExpAccCoaMainAccFundAccFundCode", original_AccFundAccs.ManuExpAccCoaMainAccFundAccFundCode, theAccFundAccs.ManuExpAccCoaMainAccFundAccFundCode, true));
            values.Add(new FieldValue("ManuExpAccCoaMainAccTypeAccType", original_AccFundAccs.ManuExpAccCoaMainAccTypeAccType, theAccFundAccs.ManuExpAccCoaMainAccTypeAccType, true));
            values.Add(new FieldValue("ManuExpAccCoaMainCoaControlAccName", original_AccFundAccs.ManuExpAccCoaMainCoaControlAccName, theAccFundAccs.ManuExpAccCoaMainCoaControlAccName, true));
            values.Add(new FieldValue("ManuExpAccCoaSubAccName", original_AccFundAccs.ManuExpAccCoaSubAccName, theAccFundAccs.ManuExpAccCoaSubAccName, true));
            values.Add(new FieldValue("ManuExpAccCoaSubAccBalTypeAccBalType", original_AccFundAccs.ManuExpAccCoaSubAccBalTypeAccBalType, theAccFundAccs.ManuExpAccCoaSubAccBalTypeAccBalType, true));
            values.Add(new FieldValue("ManuExpAccCoaSubAccDestAccDest", original_AccFundAccs.ManuExpAccCoaSubAccDestAccDest, theAccFundAccs.ManuExpAccCoaSubAccDestAccDest, true));
            values.Add(new FieldValue("ManuExpAccCoaSubAccFundAccFundCode", original_AccFundAccs.ManuExpAccCoaSubAccFundAccFundCode, theAccFundAccs.ManuExpAccCoaSubAccFundAccFundCode, true));
            values.Add(new FieldValue("ManuExpAccCoaSubAccTypeAccType", original_AccFundAccs.ManuExpAccCoaSubAccTypeAccType, theAccFundAccs.ManuExpAccCoaSubAccTypeAccType, true));
            values.Add(new FieldValue("ManuExpAccCoaSubCoaControlAccName", original_AccFundAccs.ManuExpAccCoaSubCoaControlAccName, theAccFundAccs.ManuExpAccCoaSubCoaControlAccName, true));
            values.Add(new FieldValue("ManuExpAccCoaSubCoaMainAccName", original_AccFundAccs.ManuExpAccCoaSubCoaMainAccName, theAccFundAccs.ManuExpAccCoaSubCoaMainAccName, true));
            values.Add(new FieldValue("LoanAcc", original_AccFundAccs.LoanAcc, theAccFundAccs.LoanAcc));
            values.Add(new FieldValue("LoanAccAccName", original_AccFundAccs.LoanAccAccName, theAccFundAccs.LoanAccAccName, true));
            values.Add(new FieldValue("LoanAccAccBalTypeAccBalType", original_AccFundAccs.LoanAccAccBalTypeAccBalType, theAccFundAccs.LoanAccAccBalTypeAccBalType, true));
            values.Add(new FieldValue("LoanAccAccCurrencyAccCurrencyName", original_AccFundAccs.LoanAccAccCurrencyAccCurrencyName, theAccFundAccs.LoanAccAccCurrencyAccCurrencyName, true));
            values.Add(new FieldValue("LoanAccAccDestAccDest", original_AccFundAccs.LoanAccAccDestAccDest, theAccFundAccs.LoanAccAccDestAccDest, true));
            values.Add(new FieldValue("LoanAccAccDestCompanyTypeDescription", original_AccFundAccs.LoanAccAccDestCompanyTypeDescription, theAccFundAccs.LoanAccAccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("LoanAccAccFundAccFundCode", original_AccFundAccs.LoanAccAccFundAccFundCode, theAccFundAccs.LoanAccAccFundAccFundCode, true));
            values.Add(new FieldValue("LoanAccAccSubTypeAccSubType", original_AccFundAccs.LoanAccAccSubTypeAccSubType, theAccFundAccs.LoanAccAccSubTypeAccSubType, true));
            values.Add(new FieldValue("LoanAccAccTypeAccType", original_AccFundAccs.LoanAccAccTypeAccType, theAccFundAccs.LoanAccAccTypeAccType, true));
            values.Add(new FieldValue("LoanAccCoaControlAccName", original_AccFundAccs.LoanAccCoaControlAccName, theAccFundAccs.LoanAccCoaControlAccName, true));
            values.Add(new FieldValue("LoanAccCoaControlAccBalTypeAccBalType", original_AccFundAccs.LoanAccCoaControlAccBalTypeAccBalType, theAccFundAccs.LoanAccCoaControlAccBalTypeAccBalType, true));
            values.Add(new FieldValue("LoanAccCoaControlAccDestAccDest", original_AccFundAccs.LoanAccCoaControlAccDestAccDest, theAccFundAccs.LoanAccCoaControlAccDestAccDest, true));
            values.Add(new FieldValue("LoanAccCoaControlAccTypeAccType", original_AccFundAccs.LoanAccCoaControlAccTypeAccType, theAccFundAccs.LoanAccCoaControlAccTypeAccType, true));
            values.Add(new FieldValue("LoanAccCoaControlCompTypeDescription", original_AccFundAccs.LoanAccCoaControlCompTypeDescription, theAccFundAccs.LoanAccCoaControlCompTypeDescription, true));
            values.Add(new FieldValue("LoanAccCoaMainAccName", original_AccFundAccs.LoanAccCoaMainAccName, theAccFundAccs.LoanAccCoaMainAccName, true));
            values.Add(new FieldValue("LoanAccCoaMainAccBalTypeAccBalType", original_AccFundAccs.LoanAccCoaMainAccBalTypeAccBalType, theAccFundAccs.LoanAccCoaMainAccBalTypeAccBalType, true));
            values.Add(new FieldValue("LoanAccCoaMainAccDestAccDest", original_AccFundAccs.LoanAccCoaMainAccDestAccDest, theAccFundAccs.LoanAccCoaMainAccDestAccDest, true));
            values.Add(new FieldValue("LoanAccCoaMainAccFundAccFundCode", original_AccFundAccs.LoanAccCoaMainAccFundAccFundCode, theAccFundAccs.LoanAccCoaMainAccFundAccFundCode, true));
            values.Add(new FieldValue("LoanAccCoaMainAccTypeAccType", original_AccFundAccs.LoanAccCoaMainAccTypeAccType, theAccFundAccs.LoanAccCoaMainAccTypeAccType, true));
            values.Add(new FieldValue("LoanAccCoaMainCoaControlAccName", original_AccFundAccs.LoanAccCoaMainCoaControlAccName, theAccFundAccs.LoanAccCoaMainCoaControlAccName, true));
            values.Add(new FieldValue("LoanAccCoaSubAccName", original_AccFundAccs.LoanAccCoaSubAccName, theAccFundAccs.LoanAccCoaSubAccName, true));
            values.Add(new FieldValue("LoanAccCoaSubAccBalTypeAccBalType", original_AccFundAccs.LoanAccCoaSubAccBalTypeAccBalType, theAccFundAccs.LoanAccCoaSubAccBalTypeAccBalType, true));
            values.Add(new FieldValue("LoanAccCoaSubAccDestAccDest", original_AccFundAccs.LoanAccCoaSubAccDestAccDest, theAccFundAccs.LoanAccCoaSubAccDestAccDest, true));
            values.Add(new FieldValue("LoanAccCoaSubAccFundAccFundCode", original_AccFundAccs.LoanAccCoaSubAccFundAccFundCode, theAccFundAccs.LoanAccCoaSubAccFundAccFundCode, true));
            values.Add(new FieldValue("LoanAccCoaSubAccTypeAccType", original_AccFundAccs.LoanAccCoaSubAccTypeAccType, theAccFundAccs.LoanAccCoaSubAccTypeAccType, true));
            values.Add(new FieldValue("LoanAccCoaSubCoaControlAccName", original_AccFundAccs.LoanAccCoaSubCoaControlAccName, theAccFundAccs.LoanAccCoaSubCoaControlAccName, true));
            values.Add(new FieldValue("LoanAccCoaSubCoaMainAccName", original_AccFundAccs.LoanAccCoaSubCoaMainAccName, theAccFundAccs.LoanAccCoaSubCoaMainAccName, true));
            values.Add(new FieldValue("AssetDepAcc", original_AccFundAccs.AssetDepAcc, theAccFundAccs.AssetDepAcc));
            values.Add(new FieldValue("AssetDepAccAccName", original_AccFundAccs.AssetDepAccAccName, theAccFundAccs.AssetDepAccAccName, true));
            values.Add(new FieldValue("AssetDepAccAccBalTypeAccBalType", original_AccFundAccs.AssetDepAccAccBalTypeAccBalType, theAccFundAccs.AssetDepAccAccBalTypeAccBalType, true));
            values.Add(new FieldValue("AssetDepAccAccCurrencyAccCurrencyName", original_AccFundAccs.AssetDepAccAccCurrencyAccCurrencyName, theAccFundAccs.AssetDepAccAccCurrencyAccCurrencyName, true));
            values.Add(new FieldValue("AssetDepAccAccDestAccDest", original_AccFundAccs.AssetDepAccAccDestAccDest, theAccFundAccs.AssetDepAccAccDestAccDest, true));
            values.Add(new FieldValue("AssetDepAccAccDestCompanyTypeDescription", original_AccFundAccs.AssetDepAccAccDestCompanyTypeDescription, theAccFundAccs.AssetDepAccAccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("AssetDepAccAccFundAccFundCode", original_AccFundAccs.AssetDepAccAccFundAccFundCode, theAccFundAccs.AssetDepAccAccFundAccFundCode, true));
            values.Add(new FieldValue("AssetDepAccAccSubTypeAccSubType", original_AccFundAccs.AssetDepAccAccSubTypeAccSubType, theAccFundAccs.AssetDepAccAccSubTypeAccSubType, true));
            values.Add(new FieldValue("AssetDepAccAccTypeAccType", original_AccFundAccs.AssetDepAccAccTypeAccType, theAccFundAccs.AssetDepAccAccTypeAccType, true));
            values.Add(new FieldValue("AssetDepAccCoaControlAccName", original_AccFundAccs.AssetDepAccCoaControlAccName, theAccFundAccs.AssetDepAccCoaControlAccName, true));
            values.Add(new FieldValue("AssetDepAccCoaControlAccBalTypeAccBalType", original_AccFundAccs.AssetDepAccCoaControlAccBalTypeAccBalType, theAccFundAccs.AssetDepAccCoaControlAccBalTypeAccBalType, true));
            values.Add(new FieldValue("AssetDepAccCoaControlAccDestAccDest", original_AccFundAccs.AssetDepAccCoaControlAccDestAccDest, theAccFundAccs.AssetDepAccCoaControlAccDestAccDest, true));
            values.Add(new FieldValue("AssetDepAccCoaControlAccTypeAccType", original_AccFundAccs.AssetDepAccCoaControlAccTypeAccType, theAccFundAccs.AssetDepAccCoaControlAccTypeAccType, true));
            values.Add(new FieldValue("AssetDepAccCoaControlCompTypeDescription", original_AccFundAccs.AssetDepAccCoaControlCompTypeDescription, theAccFundAccs.AssetDepAccCoaControlCompTypeDescription, true));
            values.Add(new FieldValue("AssetDepAccCoaMainAccName", original_AccFundAccs.AssetDepAccCoaMainAccName, theAccFundAccs.AssetDepAccCoaMainAccName, true));
            values.Add(new FieldValue("AssetDepAccCoaMainAccBalTypeAccBalType", original_AccFundAccs.AssetDepAccCoaMainAccBalTypeAccBalType, theAccFundAccs.AssetDepAccCoaMainAccBalTypeAccBalType, true));
            values.Add(new FieldValue("AssetDepAccCoaMainAccDestAccDest", original_AccFundAccs.AssetDepAccCoaMainAccDestAccDest, theAccFundAccs.AssetDepAccCoaMainAccDestAccDest, true));
            values.Add(new FieldValue("AssetDepAccCoaMainAccFundAccFundCode", original_AccFundAccs.AssetDepAccCoaMainAccFundAccFundCode, theAccFundAccs.AssetDepAccCoaMainAccFundAccFundCode, true));
            values.Add(new FieldValue("AssetDepAccCoaMainAccTypeAccType", original_AccFundAccs.AssetDepAccCoaMainAccTypeAccType, theAccFundAccs.AssetDepAccCoaMainAccTypeAccType, true));
            values.Add(new FieldValue("AssetDepAccCoaMainCoaControlAccName", original_AccFundAccs.AssetDepAccCoaMainCoaControlAccName, theAccFundAccs.AssetDepAccCoaMainCoaControlAccName, true));
            values.Add(new FieldValue("AssetDepAccCoaSubAccName", original_AccFundAccs.AssetDepAccCoaSubAccName, theAccFundAccs.AssetDepAccCoaSubAccName, true));
            values.Add(new FieldValue("AssetDepAccCoaSubAccBalTypeAccBalType", original_AccFundAccs.AssetDepAccCoaSubAccBalTypeAccBalType, theAccFundAccs.AssetDepAccCoaSubAccBalTypeAccBalType, true));
            values.Add(new FieldValue("AssetDepAccCoaSubAccDestAccDest", original_AccFundAccs.AssetDepAccCoaSubAccDestAccDest, theAccFundAccs.AssetDepAccCoaSubAccDestAccDest, true));
            values.Add(new FieldValue("AssetDepAccCoaSubAccFundAccFundCode", original_AccFundAccs.AssetDepAccCoaSubAccFundAccFundCode, theAccFundAccs.AssetDepAccCoaSubAccFundAccFundCode, true));
            values.Add(new FieldValue("AssetDepAccCoaSubAccTypeAccType", original_AccFundAccs.AssetDepAccCoaSubAccTypeAccType, theAccFundAccs.AssetDepAccCoaSubAccTypeAccType, true));
            values.Add(new FieldValue("AssetDepAccCoaSubCoaControlAccName", original_AccFundAccs.AssetDepAccCoaSubCoaControlAccName, theAccFundAccs.AssetDepAccCoaSubCoaControlAccName, true));
            values.Add(new FieldValue("AssetDepAccCoaSubCoaMainAccName", original_AccFundAccs.AssetDepAccCoaSubCoaMainAccName, theAccFundAccs.AssetDepAccCoaSubCoaMainAccName, true));
            values.Add(new FieldValue("NonOperateIncAcc", original_AccFundAccs.NonOperateIncAcc, theAccFundAccs.NonOperateIncAcc));
            values.Add(new FieldValue("NonOperateIncAccAccName", original_AccFundAccs.NonOperateIncAccAccName, theAccFundAccs.NonOperateIncAccAccName, true));
            values.Add(new FieldValue("NonOperateIncAccAccBalTypeAccBalType", original_AccFundAccs.NonOperateIncAccAccBalTypeAccBalType, theAccFundAccs.NonOperateIncAccAccBalTypeAccBalType, true));
            values.Add(new FieldValue("NonOperateIncAccAccCurrencyAccCurrencyName", original_AccFundAccs.NonOperateIncAccAccCurrencyAccCurrencyName, theAccFundAccs.NonOperateIncAccAccCurrencyAccCurrencyName, true));
            values.Add(new FieldValue("NonOperateIncAccAccDestAccDest", original_AccFundAccs.NonOperateIncAccAccDestAccDest, theAccFundAccs.NonOperateIncAccAccDestAccDest, true));
            values.Add(new FieldValue("NonOperateIncAccAccDestCompanyTypeDescription", original_AccFundAccs.NonOperateIncAccAccDestCompanyTypeDescription, theAccFundAccs.NonOperateIncAccAccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("NonOperateIncAccAccFundAccFundCode", original_AccFundAccs.NonOperateIncAccAccFundAccFundCode, theAccFundAccs.NonOperateIncAccAccFundAccFundCode, true));
            values.Add(new FieldValue("NonOperateIncAccAccSubTypeAccSubType", original_AccFundAccs.NonOperateIncAccAccSubTypeAccSubType, theAccFundAccs.NonOperateIncAccAccSubTypeAccSubType, true));
            values.Add(new FieldValue("NonOperateIncAccAccTypeAccType", original_AccFundAccs.NonOperateIncAccAccTypeAccType, theAccFundAccs.NonOperateIncAccAccTypeAccType, true));
            values.Add(new FieldValue("NonOperateIncAccCoaControlAccName", original_AccFundAccs.NonOperateIncAccCoaControlAccName, theAccFundAccs.NonOperateIncAccCoaControlAccName, true));
            values.Add(new FieldValue("NonOperateIncAccCoaControlAccBalTypeAccBalType", original_AccFundAccs.NonOperateIncAccCoaControlAccBalTypeAccBalType, theAccFundAccs.NonOperateIncAccCoaControlAccBalTypeAccBalType, true));
            values.Add(new FieldValue("NonOperateIncAccCoaControlAccDestAccDest", original_AccFundAccs.NonOperateIncAccCoaControlAccDestAccDest, theAccFundAccs.NonOperateIncAccCoaControlAccDestAccDest, true));
            values.Add(new FieldValue("NonOperateIncAccCoaControlAccTypeAccType", original_AccFundAccs.NonOperateIncAccCoaControlAccTypeAccType, theAccFundAccs.NonOperateIncAccCoaControlAccTypeAccType, true));
            values.Add(new FieldValue("NonOperateIncAccCoaControlCompTypeDescription", original_AccFundAccs.NonOperateIncAccCoaControlCompTypeDescription, theAccFundAccs.NonOperateIncAccCoaControlCompTypeDescription, true));
            values.Add(new FieldValue("NonOperateIncAccCoaMainAccName", original_AccFundAccs.NonOperateIncAccCoaMainAccName, theAccFundAccs.NonOperateIncAccCoaMainAccName, true));
            values.Add(new FieldValue("NonOperateIncAccCoaMainAccBalTypeAccBalType", original_AccFundAccs.NonOperateIncAccCoaMainAccBalTypeAccBalType, theAccFundAccs.NonOperateIncAccCoaMainAccBalTypeAccBalType, true));
            values.Add(new FieldValue("NonOperateIncAccCoaMainAccDestAccDest", original_AccFundAccs.NonOperateIncAccCoaMainAccDestAccDest, theAccFundAccs.NonOperateIncAccCoaMainAccDestAccDest, true));
            values.Add(new FieldValue("NonOperateIncAccCoaMainAccFundAccFundCode", original_AccFundAccs.NonOperateIncAccCoaMainAccFundAccFundCode, theAccFundAccs.NonOperateIncAccCoaMainAccFundAccFundCode, true));
            values.Add(new FieldValue("NonOperateIncAccCoaMainAccTypeAccType", original_AccFundAccs.NonOperateIncAccCoaMainAccTypeAccType, theAccFundAccs.NonOperateIncAccCoaMainAccTypeAccType, true));
            values.Add(new FieldValue("NonOperateIncAccCoaMainCoaControlAccName", original_AccFundAccs.NonOperateIncAccCoaMainCoaControlAccName, theAccFundAccs.NonOperateIncAccCoaMainCoaControlAccName, true));
            values.Add(new FieldValue("NonOperateIncAccCoaSubAccName", original_AccFundAccs.NonOperateIncAccCoaSubAccName, theAccFundAccs.NonOperateIncAccCoaSubAccName, true));
            values.Add(new FieldValue("NonOperateIncAccCoaSubAccBalTypeAccBalType", original_AccFundAccs.NonOperateIncAccCoaSubAccBalTypeAccBalType, theAccFundAccs.NonOperateIncAccCoaSubAccBalTypeAccBalType, true));
            values.Add(new FieldValue("NonOperateIncAccCoaSubAccDestAccDest", original_AccFundAccs.NonOperateIncAccCoaSubAccDestAccDest, theAccFundAccs.NonOperateIncAccCoaSubAccDestAccDest, true));
            values.Add(new FieldValue("NonOperateIncAccCoaSubAccFundAccFundCode", original_AccFundAccs.NonOperateIncAccCoaSubAccFundAccFundCode, theAccFundAccs.NonOperateIncAccCoaSubAccFundAccFundCode, true));
            values.Add(new FieldValue("NonOperateIncAccCoaSubAccTypeAccType", original_AccFundAccs.NonOperateIncAccCoaSubAccTypeAccType, theAccFundAccs.NonOperateIncAccCoaSubAccTypeAccType, true));
            values.Add(new FieldValue("NonOperateIncAccCoaSubCoaControlAccName", original_AccFundAccs.NonOperateIncAccCoaSubCoaControlAccName, theAccFundAccs.NonOperateIncAccCoaSubCoaControlAccName, true));
            values.Add(new FieldValue("NonOperateIncAccCoaSubCoaMainAccName", original_AccFundAccs.NonOperateIncAccCoaSubCoaMainAccName, theAccFundAccs.NonOperateIncAccCoaSubCoaMainAccName, true));
            values.Add(new FieldValue("NonOperateExpAcc", original_AccFundAccs.NonOperateExpAcc, theAccFundAccs.NonOperateExpAcc));
            values.Add(new FieldValue("NonOperateExpAccAccName", original_AccFundAccs.NonOperateExpAccAccName, theAccFundAccs.NonOperateExpAccAccName, true));
            values.Add(new FieldValue("NonOperateExpAccAccBalTypeAccBalType", original_AccFundAccs.NonOperateExpAccAccBalTypeAccBalType, theAccFundAccs.NonOperateExpAccAccBalTypeAccBalType, true));
            values.Add(new FieldValue("NonOperateExpAccAccCurrencyAccCurrencyName", original_AccFundAccs.NonOperateExpAccAccCurrencyAccCurrencyName, theAccFundAccs.NonOperateExpAccAccCurrencyAccCurrencyName, true));
            values.Add(new FieldValue("NonOperateExpAccAccDestAccDest", original_AccFundAccs.NonOperateExpAccAccDestAccDest, theAccFundAccs.NonOperateExpAccAccDestAccDest, true));
            values.Add(new FieldValue("NonOperateExpAccAccDestCompanyTypeDescription", original_AccFundAccs.NonOperateExpAccAccDestCompanyTypeDescription, theAccFundAccs.NonOperateExpAccAccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("NonOperateExpAccAccFundAccFundCode", original_AccFundAccs.NonOperateExpAccAccFundAccFundCode, theAccFundAccs.NonOperateExpAccAccFundAccFundCode, true));
            values.Add(new FieldValue("NonOperateExpAccAccSubTypeAccSubType", original_AccFundAccs.NonOperateExpAccAccSubTypeAccSubType, theAccFundAccs.NonOperateExpAccAccSubTypeAccSubType, true));
            values.Add(new FieldValue("NonOperateExpAccAccTypeAccType", original_AccFundAccs.NonOperateExpAccAccTypeAccType, theAccFundAccs.NonOperateExpAccAccTypeAccType, true));
            values.Add(new FieldValue("NonOperateExpAccCoaControlAccName", original_AccFundAccs.NonOperateExpAccCoaControlAccName, theAccFundAccs.NonOperateExpAccCoaControlAccName, true));
            values.Add(new FieldValue("NonOperateExpAccCoaControlAccBalTypeAccBalType", original_AccFundAccs.NonOperateExpAccCoaControlAccBalTypeAccBalType, theAccFundAccs.NonOperateExpAccCoaControlAccBalTypeAccBalType, true));
            values.Add(new FieldValue("NonOperateExpAccCoaControlAccDestAccDest", original_AccFundAccs.NonOperateExpAccCoaControlAccDestAccDest, theAccFundAccs.NonOperateExpAccCoaControlAccDestAccDest, true));
            values.Add(new FieldValue("NonOperateExpAccCoaControlAccTypeAccType", original_AccFundAccs.NonOperateExpAccCoaControlAccTypeAccType, theAccFundAccs.NonOperateExpAccCoaControlAccTypeAccType, true));
            values.Add(new FieldValue("NonOperateExpAccCoaControlCompTypeDescription", original_AccFundAccs.NonOperateExpAccCoaControlCompTypeDescription, theAccFundAccs.NonOperateExpAccCoaControlCompTypeDescription, true));
            values.Add(new FieldValue("NonOperateExpAccCoaMainAccName", original_AccFundAccs.NonOperateExpAccCoaMainAccName, theAccFundAccs.NonOperateExpAccCoaMainAccName, true));
            values.Add(new FieldValue("NonOperateExpAccCoaMainAccBalTypeAccBalType", original_AccFundAccs.NonOperateExpAccCoaMainAccBalTypeAccBalType, theAccFundAccs.NonOperateExpAccCoaMainAccBalTypeAccBalType, true));
            values.Add(new FieldValue("NonOperateExpAccCoaMainAccDestAccDest", original_AccFundAccs.NonOperateExpAccCoaMainAccDestAccDest, theAccFundAccs.NonOperateExpAccCoaMainAccDestAccDest, true));
            values.Add(new FieldValue("NonOperateExpAccCoaMainAccFundAccFundCode", original_AccFundAccs.NonOperateExpAccCoaMainAccFundAccFundCode, theAccFundAccs.NonOperateExpAccCoaMainAccFundAccFundCode, true));
            values.Add(new FieldValue("NonOperateExpAccCoaMainAccTypeAccType", original_AccFundAccs.NonOperateExpAccCoaMainAccTypeAccType, theAccFundAccs.NonOperateExpAccCoaMainAccTypeAccType, true));
            values.Add(new FieldValue("NonOperateExpAccCoaMainCoaControlAccName", original_AccFundAccs.NonOperateExpAccCoaMainCoaControlAccName, theAccFundAccs.NonOperateExpAccCoaMainCoaControlAccName, true));
            values.Add(new FieldValue("NonOperateExpAccCoaSubAccName", original_AccFundAccs.NonOperateExpAccCoaSubAccName, theAccFundAccs.NonOperateExpAccCoaSubAccName, true));
            values.Add(new FieldValue("NonOperateExpAccCoaSubAccBalTypeAccBalType", original_AccFundAccs.NonOperateExpAccCoaSubAccBalTypeAccBalType, theAccFundAccs.NonOperateExpAccCoaSubAccBalTypeAccBalType, true));
            values.Add(new FieldValue("NonOperateExpAccCoaSubAccDestAccDest", original_AccFundAccs.NonOperateExpAccCoaSubAccDestAccDest, theAccFundAccs.NonOperateExpAccCoaSubAccDestAccDest, true));
            values.Add(new FieldValue("NonOperateExpAccCoaSubAccFundAccFundCode", original_AccFundAccs.NonOperateExpAccCoaSubAccFundAccFundCode, theAccFundAccs.NonOperateExpAccCoaSubAccFundAccFundCode, true));
            values.Add(new FieldValue("NonOperateExpAccCoaSubAccTypeAccType", original_AccFundAccs.NonOperateExpAccCoaSubAccTypeAccType, theAccFundAccs.NonOperateExpAccCoaSubAccTypeAccType, true));
            values.Add(new FieldValue("NonOperateExpAccCoaSubCoaControlAccName", original_AccFundAccs.NonOperateExpAccCoaSubCoaControlAccName, theAccFundAccs.NonOperateExpAccCoaSubCoaControlAccName, true));
            values.Add(new FieldValue("NonOperateExpAccCoaSubCoaMainAccName", original_AccFundAccs.NonOperateExpAccCoaSubCoaMainAccName, theAccFundAccs.NonOperateExpAccCoaSubCoaMainAccName, true));
            values.Add(new FieldValue("PrevYearPLAcc", original_AccFundAccs.PrevYearPLAcc, theAccFundAccs.PrevYearPLAcc));
            values.Add(new FieldValue("PrevYearPLAccAccName", original_AccFundAccs.PrevYearPLAccAccName, theAccFundAccs.PrevYearPLAccAccName, true));
            values.Add(new FieldValue("PrevYearPLAccAccBalTypeAccBalType", original_AccFundAccs.PrevYearPLAccAccBalTypeAccBalType, theAccFundAccs.PrevYearPLAccAccBalTypeAccBalType, true));
            values.Add(new FieldValue("PrevYearPLAccAccCurrencyAccCurrencyName", original_AccFundAccs.PrevYearPLAccAccCurrencyAccCurrencyName, theAccFundAccs.PrevYearPLAccAccCurrencyAccCurrencyName, true));
            values.Add(new FieldValue("PrevYearPLAccAccDestAccDest", original_AccFundAccs.PrevYearPLAccAccDestAccDest, theAccFundAccs.PrevYearPLAccAccDestAccDest, true));
            values.Add(new FieldValue("PrevYearPLAccAccDestCompanyTypeDescription", original_AccFundAccs.PrevYearPLAccAccDestCompanyTypeDescription, theAccFundAccs.PrevYearPLAccAccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("PrevYearPLAccAccFundAccFundCode", original_AccFundAccs.PrevYearPLAccAccFundAccFundCode, theAccFundAccs.PrevYearPLAccAccFundAccFundCode, true));
            values.Add(new FieldValue("PrevYearPLAccAccSubTypeAccSubType", original_AccFundAccs.PrevYearPLAccAccSubTypeAccSubType, theAccFundAccs.PrevYearPLAccAccSubTypeAccSubType, true));
            values.Add(new FieldValue("PrevYearPLAccAccTypeAccType", original_AccFundAccs.PrevYearPLAccAccTypeAccType, theAccFundAccs.PrevYearPLAccAccTypeAccType, true));
            values.Add(new FieldValue("PrevYearPLAccCoaControlAccName", original_AccFundAccs.PrevYearPLAccCoaControlAccName, theAccFundAccs.PrevYearPLAccCoaControlAccName, true));
            values.Add(new FieldValue("PrevYearPLAccCoaControlAccBalTypeAccBalType", original_AccFundAccs.PrevYearPLAccCoaControlAccBalTypeAccBalType, theAccFundAccs.PrevYearPLAccCoaControlAccBalTypeAccBalType, true));
            values.Add(new FieldValue("PrevYearPLAccCoaControlAccDestAccDest", original_AccFundAccs.PrevYearPLAccCoaControlAccDestAccDest, theAccFundAccs.PrevYearPLAccCoaControlAccDestAccDest, true));
            values.Add(new FieldValue("PrevYearPLAccCoaControlAccTypeAccType", original_AccFundAccs.PrevYearPLAccCoaControlAccTypeAccType, theAccFundAccs.PrevYearPLAccCoaControlAccTypeAccType, true));
            values.Add(new FieldValue("PrevYearPLAccCoaControlCompTypeDescription", original_AccFundAccs.PrevYearPLAccCoaControlCompTypeDescription, theAccFundAccs.PrevYearPLAccCoaControlCompTypeDescription, true));
            values.Add(new FieldValue("PrevYearPLAccCoaMainAccName", original_AccFundAccs.PrevYearPLAccCoaMainAccName, theAccFundAccs.PrevYearPLAccCoaMainAccName, true));
            values.Add(new FieldValue("PrevYearPLAccCoaMainAccBalTypeAccBalType", original_AccFundAccs.PrevYearPLAccCoaMainAccBalTypeAccBalType, theAccFundAccs.PrevYearPLAccCoaMainAccBalTypeAccBalType, true));
            values.Add(new FieldValue("PrevYearPLAccCoaMainAccDestAccDest", original_AccFundAccs.PrevYearPLAccCoaMainAccDestAccDest, theAccFundAccs.PrevYearPLAccCoaMainAccDestAccDest, true));
            values.Add(new FieldValue("PrevYearPLAccCoaMainAccFundAccFundCode", original_AccFundAccs.PrevYearPLAccCoaMainAccFundAccFundCode, theAccFundAccs.PrevYearPLAccCoaMainAccFundAccFundCode, true));
            values.Add(new FieldValue("PrevYearPLAccCoaMainAccTypeAccType", original_AccFundAccs.PrevYearPLAccCoaMainAccTypeAccType, theAccFundAccs.PrevYearPLAccCoaMainAccTypeAccType, true));
            values.Add(new FieldValue("PrevYearPLAccCoaMainCoaControlAccName", original_AccFundAccs.PrevYearPLAccCoaMainCoaControlAccName, theAccFundAccs.PrevYearPLAccCoaMainCoaControlAccName, true));
            values.Add(new FieldValue("PrevYearPLAccCoaSubAccName", original_AccFundAccs.PrevYearPLAccCoaSubAccName, theAccFundAccs.PrevYearPLAccCoaSubAccName, true));
            values.Add(new FieldValue("PrevYearPLAccCoaSubAccBalTypeAccBalType", original_AccFundAccs.PrevYearPLAccCoaSubAccBalTypeAccBalType, theAccFundAccs.PrevYearPLAccCoaSubAccBalTypeAccBalType, true));
            values.Add(new FieldValue("PrevYearPLAccCoaSubAccDestAccDest", original_AccFundAccs.PrevYearPLAccCoaSubAccDestAccDest, theAccFundAccs.PrevYearPLAccCoaSubAccDestAccDest, true));
            values.Add(new FieldValue("PrevYearPLAccCoaSubAccFundAccFundCode", original_AccFundAccs.PrevYearPLAccCoaSubAccFundAccFundCode, theAccFundAccs.PrevYearPLAccCoaSubAccFundAccFundCode, true));
            values.Add(new FieldValue("PrevYearPLAccCoaSubAccTypeAccType", original_AccFundAccs.PrevYearPLAccCoaSubAccTypeAccType, theAccFundAccs.PrevYearPLAccCoaSubAccTypeAccType, true));
            values.Add(new FieldValue("PrevYearPLAccCoaSubCoaControlAccName", original_AccFundAccs.PrevYearPLAccCoaSubCoaControlAccName, theAccFundAccs.PrevYearPLAccCoaSubCoaControlAccName, true));
            values.Add(new FieldValue("PrevYearPLAccCoaSubCoaMainAccName", original_AccFundAccs.PrevYearPLAccCoaSubCoaMainAccName, theAccFundAccs.PrevYearPLAccCoaSubCoaMainAccName, true));
            values.Add(new FieldValue("CurrYearPLAcc", original_AccFundAccs.CurrYearPLAcc, theAccFundAccs.CurrYearPLAcc));
            values.Add(new FieldValue("CurrYearPLAccAccName", original_AccFundAccs.CurrYearPLAccAccName, theAccFundAccs.CurrYearPLAccAccName, true));
            values.Add(new FieldValue("CurrYearPLAccAccBalTypeAccBalType", original_AccFundAccs.CurrYearPLAccAccBalTypeAccBalType, theAccFundAccs.CurrYearPLAccAccBalTypeAccBalType, true));
            values.Add(new FieldValue("CurrYearPLAccAccCurrencyAccCurrencyName", original_AccFundAccs.CurrYearPLAccAccCurrencyAccCurrencyName, theAccFundAccs.CurrYearPLAccAccCurrencyAccCurrencyName, true));
            values.Add(new FieldValue("CurrYearPLAccAccDestAccDest", original_AccFundAccs.CurrYearPLAccAccDestAccDest, theAccFundAccs.CurrYearPLAccAccDestAccDest, true));
            values.Add(new FieldValue("CurrYearPLAccAccDestCompanyTypeDescription", original_AccFundAccs.CurrYearPLAccAccDestCompanyTypeDescription, theAccFundAccs.CurrYearPLAccAccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("CurrYearPLAccAccFundAccFundCode", original_AccFundAccs.CurrYearPLAccAccFundAccFundCode, theAccFundAccs.CurrYearPLAccAccFundAccFundCode, true));
            values.Add(new FieldValue("CurrYearPLAccAccSubTypeAccSubType", original_AccFundAccs.CurrYearPLAccAccSubTypeAccSubType, theAccFundAccs.CurrYearPLAccAccSubTypeAccSubType, true));
            values.Add(new FieldValue("CurrYearPLAccAccTypeAccType", original_AccFundAccs.CurrYearPLAccAccTypeAccType, theAccFundAccs.CurrYearPLAccAccTypeAccType, true));
            values.Add(new FieldValue("CurrYearPLAccCoaControlAccName", original_AccFundAccs.CurrYearPLAccCoaControlAccName, theAccFundAccs.CurrYearPLAccCoaControlAccName, true));
            values.Add(new FieldValue("CurrYearPLAccCoaControlAccBalTypeAccBalType", original_AccFundAccs.CurrYearPLAccCoaControlAccBalTypeAccBalType, theAccFundAccs.CurrYearPLAccCoaControlAccBalTypeAccBalType, true));
            values.Add(new FieldValue("CurrYearPLAccCoaControlAccDestAccDest", original_AccFundAccs.CurrYearPLAccCoaControlAccDestAccDest, theAccFundAccs.CurrYearPLAccCoaControlAccDestAccDest, true));
            values.Add(new FieldValue("CurrYearPLAccCoaControlAccTypeAccType", original_AccFundAccs.CurrYearPLAccCoaControlAccTypeAccType, theAccFundAccs.CurrYearPLAccCoaControlAccTypeAccType, true));
            values.Add(new FieldValue("CurrYearPLAccCoaControlCompTypeDescription", original_AccFundAccs.CurrYearPLAccCoaControlCompTypeDescription, theAccFundAccs.CurrYearPLAccCoaControlCompTypeDescription, true));
            values.Add(new FieldValue("CurrYearPLAccCoaMainAccName", original_AccFundAccs.CurrYearPLAccCoaMainAccName, theAccFundAccs.CurrYearPLAccCoaMainAccName, true));
            values.Add(new FieldValue("CurrYearPLAccCoaMainAccBalTypeAccBalType", original_AccFundAccs.CurrYearPLAccCoaMainAccBalTypeAccBalType, theAccFundAccs.CurrYearPLAccCoaMainAccBalTypeAccBalType, true));
            values.Add(new FieldValue("CurrYearPLAccCoaMainAccDestAccDest", original_AccFundAccs.CurrYearPLAccCoaMainAccDestAccDest, theAccFundAccs.CurrYearPLAccCoaMainAccDestAccDest, true));
            values.Add(new FieldValue("CurrYearPLAccCoaMainAccFundAccFundCode", original_AccFundAccs.CurrYearPLAccCoaMainAccFundAccFundCode, theAccFundAccs.CurrYearPLAccCoaMainAccFundAccFundCode, true));
            values.Add(new FieldValue("CurrYearPLAccCoaMainAccTypeAccType", original_AccFundAccs.CurrYearPLAccCoaMainAccTypeAccType, theAccFundAccs.CurrYearPLAccCoaMainAccTypeAccType, true));
            values.Add(new FieldValue("CurrYearPLAccCoaMainCoaControlAccName", original_AccFundAccs.CurrYearPLAccCoaMainCoaControlAccName, theAccFundAccs.CurrYearPLAccCoaMainCoaControlAccName, true));
            values.Add(new FieldValue("CurrYearPLAccCoaSubAccName", original_AccFundAccs.CurrYearPLAccCoaSubAccName, theAccFundAccs.CurrYearPLAccCoaSubAccName, true));
            values.Add(new FieldValue("CurrYearPLAccCoaSubAccBalTypeAccBalType", original_AccFundAccs.CurrYearPLAccCoaSubAccBalTypeAccBalType, theAccFundAccs.CurrYearPLAccCoaSubAccBalTypeAccBalType, true));
            values.Add(new FieldValue("CurrYearPLAccCoaSubAccDestAccDest", original_AccFundAccs.CurrYearPLAccCoaSubAccDestAccDest, theAccFundAccs.CurrYearPLAccCoaSubAccDestAccDest, true));
            values.Add(new FieldValue("CurrYearPLAccCoaSubAccFundAccFundCode", original_AccFundAccs.CurrYearPLAccCoaSubAccFundAccFundCode, theAccFundAccs.CurrYearPLAccCoaSubAccFundAccFundCode, true));
            values.Add(new FieldValue("CurrYearPLAccCoaSubAccTypeAccType", original_AccFundAccs.CurrYearPLAccCoaSubAccTypeAccType, theAccFundAccs.CurrYearPLAccCoaSubAccTypeAccType, true));
            values.Add(new FieldValue("CurrYearPLAccCoaSubCoaControlAccName", original_AccFundAccs.CurrYearPLAccCoaSubCoaControlAccName, theAccFundAccs.CurrYearPLAccCoaSubCoaControlAccName, true));
            values.Add(new FieldValue("CurrYearPLAccCoaSubCoaMainAccName", original_AccFundAccs.CurrYearPLAccCoaSubCoaMainAccName, theAccFundAccs.CurrYearPLAccCoaSubCoaMainAccName, true));
            values.Add(new FieldValue("ChequeCCAcc", original_AccFundAccs.ChequeCCAcc, theAccFundAccs.ChequeCCAcc));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.AccFundAccs theAccFundAccs, MyCompany.Data.Objects.AccFundAccs original_AccFundAccs, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "AccFundAccs";
            args.View = dataView;
            args.Values = CreateFieldValues(theAccFundAccs, original_AccFundAccs);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("AccFundAccs", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theAccFundAccs);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.AccFundAccs theAccFundAccs, MyCompany.Data.Objects.AccFundAccs original_AccFundAccs)
        {
            return ExecuteAction(theAccFundAccs, original_AccFundAccs, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.AccFundAccs theAccFundAccs)
        {
            return Update(theAccFundAccs, SelectSingle(theAccFundAccs.AccFundAccsID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.AccFundAccs theAccFundAccs)
        {
            return ExecuteAction(theAccFundAccs, new AccFundAccs(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.AccFundAccs theAccFundAccs)
        {
            return ExecuteAction(theAccFundAccs, theAccFundAccs, "Select", "Delete", DeleteView);
        }
    }
}
