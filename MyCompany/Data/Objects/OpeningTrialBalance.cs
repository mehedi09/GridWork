using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class OpeningTrialBalance
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _coaDetailID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accFundID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accFundAccFundName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _acccode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accDesc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accTypeID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accDestID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accDestCompanyTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accBalTypeID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accCurrency;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accCurrencyAccCurrencyName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _consTranCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _coaControlID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaControlAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaControlAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaControlAccDestCompanyTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaControlAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaControlCompTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _coaSubID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaSubAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaSubAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaSubAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaSubAccDestCompanyTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaSubAccFundAccFundName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaSubAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaSubCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaSubCoaControlAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaSubCoaControlAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaSubCoaControlAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaSubCoaControlCompTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaSubCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaSubCoaMainAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaSubCoaMainAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaSubCoaMainAccFundAccFundName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaSubCoaMainAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaSubCoaMainCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _coaMainID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaMainAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaMainAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaMainAccDestCompanyTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaMainAccFundAccFundName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaMainAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaMainCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaMainCoaControlAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaMainCoaControlAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaMainCoaControlAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaMainCoaControlCompTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tranCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _subsYN;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accSubTypeID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accSubTypeAccSubTypeName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _openDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _openDebit;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _openCredit;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _accCurrencyRate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private byte? _revenue;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _variableCost;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _monthlyExp;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _budget;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _annex;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _dlt;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isCashNature;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isBankNature;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accSubTypeID1;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accSubTypeID2;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankAccNum;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _branchName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accSubTypeAccSubTypeName1;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accSubTypeAccSubTypeName2;
        
        public OpeningTrialBalance()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? CoaDetailID
        {
            get
            {
                return _coaDetailID;
            }
            set
            {
                _coaDetailID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
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
        public string AccFundAccFundName
        {
            get
            {
                return _accFundAccFundName;
            }
            set
            {
                _accFundAccFundName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccFundCode
        {
            get
            {
                return _accFundCode;
            }
            set
            {
                _accFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Acccode
        {
            get
            {
                return _acccode;
            }
            set
            {
                _acccode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string AccName
        {
            get
            {
                return _accName;
            }
            set
            {
                _accName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccDesc
        {
            get
            {
                return _accDesc;
            }
            set
            {
                _accDesc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public int? AccTypeID
        {
            get
            {
                return _accTypeID;
            }
            set
            {
                _accTypeID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccTypeAccType
        {
            get
            {
                return _accTypeAccType;
            }
            set
            {
                _accTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public int? AccDestID
        {
            get
            {
                return _accDestID;
            }
            set
            {
                _accDestID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccDestAccDest
        {
            get
            {
                return _accDestAccDest;
            }
            set
            {
                _accDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccDestCompanyTypeDescription
        {
            get
            {
                return _accDestCompanyTypeDescription;
            }
            set
            {
                _accDestCompanyTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public int? AccBalTypeID
        {
            get
            {
                return _accBalTypeID;
            }
            set
            {
                _accBalTypeID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccBalTypeAccBalType
        {
            get
            {
                return _accBalTypeAccBalType;
            }
            set
            {
                _accBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? AccCurrency
        {
            get
            {
                return _accCurrency;
            }
            set
            {
                _accCurrency = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccCurrencyAccCurrencyName
        {
            get
            {
                return _accCurrencyAccCurrencyName;
            }
            set
            {
                _accCurrencyAccCurrencyName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ConsTranCode
        {
            get
            {
                return _consTranCode;
            }
            set
            {
                _consTranCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public int? CoaControlID
        {
            get
            {
                return _coaControlID;
            }
            set
            {
                _coaControlID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaControlAccName
        {
            get
            {
                return _coaControlAccName;
            }
            set
            {
                _coaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaControlAccBalTypeAccBalType
        {
            get
            {
                return _coaControlAccBalTypeAccBalType;
            }
            set
            {
                _coaControlAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaControlAccDestAccDest
        {
            get
            {
                return _coaControlAccDestAccDest;
            }
            set
            {
                _coaControlAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaControlAccDestCompanyTypeDescription
        {
            get
            {
                return _coaControlAccDestCompanyTypeDescription;
            }
            set
            {
                _coaControlAccDestCompanyTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaControlAccTypeAccType
        {
            get
            {
                return _coaControlAccTypeAccType;
            }
            set
            {
                _coaControlAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaControlCompTypeDescription
        {
            get
            {
                return _coaControlCompTypeDescription;
            }
            set
            {
                _coaControlCompTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? CoaSubID
        {
            get
            {
                return _coaSubID;
            }
            set
            {
                _coaSubID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaSubAccName
        {
            get
            {
                return _coaSubAccName;
            }
            set
            {
                _coaSubAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaSubAccBalTypeAccBalType
        {
            get
            {
                return _coaSubAccBalTypeAccBalType;
            }
            set
            {
                _coaSubAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaSubAccDestAccDest
        {
            get
            {
                return _coaSubAccDestAccDest;
            }
            set
            {
                _coaSubAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaSubAccDestCompanyTypeDescription
        {
            get
            {
                return _coaSubAccDestCompanyTypeDescription;
            }
            set
            {
                _coaSubAccDestCompanyTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaSubAccFundAccFundName
        {
            get
            {
                return _coaSubAccFundAccFundName;
            }
            set
            {
                _coaSubAccFundAccFundName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaSubAccTypeAccType
        {
            get
            {
                return _coaSubAccTypeAccType;
            }
            set
            {
                _coaSubAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaSubCoaControlAccName
        {
            get
            {
                return _coaSubCoaControlAccName;
            }
            set
            {
                _coaSubCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaSubCoaControlAccBalTypeAccBalType
        {
            get
            {
                return _coaSubCoaControlAccBalTypeAccBalType;
            }
            set
            {
                _coaSubCoaControlAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaSubCoaControlAccDestAccDest
        {
            get
            {
                return _coaSubCoaControlAccDestAccDest;
            }
            set
            {
                _coaSubCoaControlAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaSubCoaControlAccTypeAccType
        {
            get
            {
                return _coaSubCoaControlAccTypeAccType;
            }
            set
            {
                _coaSubCoaControlAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaSubCoaControlCompTypeDescription
        {
            get
            {
                return _coaSubCoaControlCompTypeDescription;
            }
            set
            {
                _coaSubCoaControlCompTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaSubCoaMainAccName
        {
            get
            {
                return _coaSubCoaMainAccName;
            }
            set
            {
                _coaSubCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaSubCoaMainAccBalTypeAccBalType
        {
            get
            {
                return _coaSubCoaMainAccBalTypeAccBalType;
            }
            set
            {
                _coaSubCoaMainAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaSubCoaMainAccDestAccDest
        {
            get
            {
                return _coaSubCoaMainAccDestAccDest;
            }
            set
            {
                _coaSubCoaMainAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaSubCoaMainAccFundAccFundName
        {
            get
            {
                return _coaSubCoaMainAccFundAccFundName;
            }
            set
            {
                _coaSubCoaMainAccFundAccFundName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaSubCoaMainAccTypeAccType
        {
            get
            {
                return _coaSubCoaMainAccTypeAccType;
            }
            set
            {
                _coaSubCoaMainAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaSubCoaMainCoaControlAccName
        {
            get
            {
                return _coaSubCoaMainCoaControlAccName;
            }
            set
            {
                _coaSubCoaMainCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? CoaMainID
        {
            get
            {
                return _coaMainID;
            }
            set
            {
                _coaMainID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaMainAccName
        {
            get
            {
                return _coaMainAccName;
            }
            set
            {
                _coaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaMainAccBalTypeAccBalType
        {
            get
            {
                return _coaMainAccBalTypeAccBalType;
            }
            set
            {
                _coaMainAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaMainAccDestAccDest
        {
            get
            {
                return _coaMainAccDestAccDest;
            }
            set
            {
                _coaMainAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaMainAccDestCompanyTypeDescription
        {
            get
            {
                return _coaMainAccDestCompanyTypeDescription;
            }
            set
            {
                _coaMainAccDestCompanyTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaMainAccFundAccFundName
        {
            get
            {
                return _coaMainAccFundAccFundName;
            }
            set
            {
                _coaMainAccFundAccFundName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaMainAccTypeAccType
        {
            get
            {
                return _coaMainAccTypeAccType;
            }
            set
            {
                _coaMainAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaMainCoaControlAccName
        {
            get
            {
                return _coaMainCoaControlAccName;
            }
            set
            {
                _coaMainCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaMainCoaControlAccBalTypeAccBalType
        {
            get
            {
                return _coaMainCoaControlAccBalTypeAccBalType;
            }
            set
            {
                _coaMainCoaControlAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaMainCoaControlAccDestAccDest
        {
            get
            {
                return _coaMainCoaControlAccDestAccDest;
            }
            set
            {
                _coaMainCoaControlAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaMainCoaControlAccTypeAccType
        {
            get
            {
                return _coaMainCoaControlAccTypeAccType;
            }
            set
            {
                _coaMainCoaControlAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaMainCoaControlCompTypeDescription
        {
            get
            {
                return _coaMainCoaControlCompTypeDescription;
            }
            set
            {
                _coaMainCoaControlCompTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string TranCode
        {
            get
            {
                return _tranCode;
            }
            set
            {
                _tranCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? SubsYN
        {
            get
            {
                return _subsYN;
            }
            set
            {
                _subsYN = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? AccSubTypeID
        {
            get
            {
                return _accSubTypeID;
            }
            set
            {
                _accSubTypeID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccSubTypeAccSubTypeName
        {
            get
            {
                return _accSubTypeAccSubTypeName;
            }
            set
            {
                _accSubTypeAccSubTypeName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? OpenDate
        {
            get
            {
                return _openDate;
            }
            set
            {
                _openDate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public decimal? OpenDebit
        {
            get
            {
                return _openDebit;
            }
            set
            {
                _openDebit = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public decimal? OpenCredit
        {
            get
            {
                return _openCredit;
            }
            set
            {
                _openCredit = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public decimal? AccCurrencyRate
        {
            get
            {
                return _accCurrencyRate;
            }
            set
            {
                _accCurrencyRate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public byte? Revenue
        {
            get
            {
                return _revenue;
            }
            set
            {
                _revenue = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? VariableCost
        {
            get
            {
                return _variableCost;
            }
            set
            {
                _variableCost = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? MonthlyExp
        {
            get
            {
                return _monthlyExp;
            }
            set
            {
                _monthlyExp = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public decimal? Budget
        {
            get
            {
                return _budget;
            }
            set
            {
                _budget = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Annex
        {
            get
            {
                return _annex;
            }
            set
            {
                _annex = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Dlt
        {
            get
            {
                return _dlt;
            }
            set
            {
                _dlt = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? IsCashNature
        {
            get
            {
                return _isCashNature;
            }
            set
            {
                _isCashNature = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? IsBankNature
        {
            get
            {
                return _isBankNature;
            }
            set
            {
                _isBankNature = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? AccSubTypeID1
        {
            get
            {
                return _accSubTypeID1;
            }
            set
            {
                _accSubTypeID1 = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? AccSubTypeID2
        {
            get
            {
                return _accSubTypeID2;
            }
            set
            {
                _accSubTypeID2 = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankName
        {
            get
            {
                return _bankName;
            }
            set
            {
                _bankName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankAccNum
        {
            get
            {
                return _bankAccNum;
            }
            set
            {
                _bankAccNum = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BranchName
        {
            get
            {
                return _branchName;
            }
            set
            {
                _branchName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankAccType
        {
            get
            {
                return _bankAccType;
            }
            set
            {
                _bankAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccSubTypeAccSubTypeName1
        {
            get
            {
                return _accSubTypeAccSubTypeName1;
            }
            set
            {
                _accSubTypeAccSubTypeName1 = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccSubTypeAccSubTypeName2
        {
            get
            {
                return _accSubTypeAccSubTypeName2;
            }
            set
            {
                _accSubTypeAccSubTypeName2 = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.OpeningTrialBalance> Select(
                    int? coaDetailID, 
                    int? accFundID, 
                    string accFundAccFundName, 
                    string accFundCode, 
                    string acccode, 
                    string accName, 
                    string accDesc, 
                    int? accTypeID, 
                    string accTypeAccType, 
                    int? accDestID, 
                    string accDestAccDest, 
                    string accDestCompanyTypeDescription, 
                    int? accBalTypeID, 
                    string accBalTypeAccBalType, 
                    int? accCurrency, 
                    string accCurrencyAccCurrencyName, 
                    string consTranCode, 
                    int? coaControlID, 
                    string coaControlAccName, 
                    string coaControlAccBalTypeAccBalType, 
                    string coaControlAccDestAccDest, 
                    string coaControlAccDestCompanyTypeDescription, 
                    string coaControlAccTypeAccType, 
                    string coaControlCompTypeDescription, 
                    int? coaSubID, 
                    string coaSubAccName, 
                    string coaSubAccBalTypeAccBalType, 
                    string coaSubAccDestAccDest, 
                    string coaSubAccDestCompanyTypeDescription, 
                    string coaSubAccFundAccFundName, 
                    string coaSubAccTypeAccType, 
                    string coaSubCoaControlAccName, 
                    string coaSubCoaControlAccBalTypeAccBalType, 
                    string coaSubCoaControlAccDestAccDest, 
                    string coaSubCoaControlAccTypeAccType, 
                    string coaSubCoaControlCompTypeDescription, 
                    string coaSubCoaMainAccName, 
                    string coaSubCoaMainAccBalTypeAccBalType, 
                    string coaSubCoaMainAccDestAccDest, 
                    string coaSubCoaMainAccFundAccFundName, 
                    string coaSubCoaMainAccTypeAccType, 
                    string coaSubCoaMainCoaControlAccName, 
                    int? coaMainID, 
                    string coaMainAccName, 
                    string coaMainAccBalTypeAccBalType, 
                    string coaMainAccDestAccDest, 
                    string coaMainAccDestCompanyTypeDescription, 
                    string coaMainAccFundAccFundName, 
                    string coaMainAccTypeAccType, 
                    string coaMainCoaControlAccName, 
                    string coaMainCoaControlAccBalTypeAccBalType, 
                    string coaMainCoaControlAccDestAccDest, 
                    string coaMainCoaControlAccTypeAccType, 
                    string coaMainCoaControlCompTypeDescription, 
                    string tranCode, 
                    bool? subsYN, 
                    int? accSubTypeID, 
                    string accSubTypeAccSubTypeName, 
                    DateTime? openDate, 
                    decimal? openDebit, 
                    decimal? openCredit, 
                    decimal? accCurrencyRate, 
                    byte? revenue, 
                    bool? variableCost, 
                    bool? monthlyExp, 
                    decimal? budget, 
                    string annex, 
                    string dlt, 
                    bool? isCashNature, 
                    bool? isBankNature, 
                    int? accSubTypeID1, 
                    int? accSubTypeID2, 
                    string bankName, 
                    string bankAccNum, 
                    string branchName, 
                    string bankAccType)
        {
            return new OpeningTrialBalanceFactory().Select(coaDetailID, accFundID, accFundAccFundName, accFundCode, acccode, accName, accDesc, accTypeID, accTypeAccType, accDestID, accDestAccDest, accDestCompanyTypeDescription, accBalTypeID, accBalTypeAccBalType, accCurrency, accCurrencyAccCurrencyName, consTranCode, coaControlID, coaControlAccName, coaControlAccBalTypeAccBalType, coaControlAccDestAccDest, coaControlAccDestCompanyTypeDescription, coaControlAccTypeAccType, coaControlCompTypeDescription, coaSubID, coaSubAccName, coaSubAccBalTypeAccBalType, coaSubAccDestAccDest, coaSubAccDestCompanyTypeDescription, coaSubAccFundAccFundName, coaSubAccTypeAccType, coaSubCoaControlAccName, coaSubCoaControlAccBalTypeAccBalType, coaSubCoaControlAccDestAccDest, coaSubCoaControlAccTypeAccType, coaSubCoaControlCompTypeDescription, coaSubCoaMainAccName, coaSubCoaMainAccBalTypeAccBalType, coaSubCoaMainAccDestAccDest, coaSubCoaMainAccFundAccFundName, coaSubCoaMainAccTypeAccType, coaSubCoaMainCoaControlAccName, coaMainID, coaMainAccName, coaMainAccBalTypeAccBalType, coaMainAccDestAccDest, coaMainAccDestCompanyTypeDescription, coaMainAccFundAccFundName, coaMainAccTypeAccType, coaMainCoaControlAccName, coaMainCoaControlAccBalTypeAccBalType, coaMainCoaControlAccDestAccDest, coaMainCoaControlAccTypeAccType, coaMainCoaControlCompTypeDescription, tranCode, subsYN, accSubTypeID, accSubTypeAccSubTypeName, openDate, openDebit, openCredit, accCurrencyRate, revenue, variableCost, monthlyExp, budget, annex, dlt, isCashNature, isBankNature, accSubTypeID1, accSubTypeID2, bankName, bankAccNum, branchName, bankAccType);
        }
        
        public static List<MyCompany.Data.Objects.OpeningTrialBalance> Select(MyCompany.Data.Objects.OpeningTrialBalance qbe)
        {
            return new OpeningTrialBalanceFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.OpeningTrialBalance> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new OpeningTrialBalanceFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.OpeningTrialBalance> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new OpeningTrialBalanceFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.OpeningTrialBalance> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new OpeningTrialBalanceFactory().Select(filter, sort, OpeningTrialBalanceFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.OpeningTrialBalance> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new OpeningTrialBalanceFactory().Select(filter, sort, OpeningTrialBalanceFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.OpeningTrialBalance> Select(string filter, BusinessObjectParameters parameters)
        {
            return new OpeningTrialBalanceFactory().Select(filter, null, OpeningTrialBalanceFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.OpeningTrialBalance> Select(string filter, params FieldValue[] parameters)
        {
            return new OpeningTrialBalanceFactory().Select(filter, null, OpeningTrialBalanceFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.OpeningTrialBalance SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new OpeningTrialBalanceFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.OpeningTrialBalance SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new OpeningTrialBalanceFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.OpeningTrialBalance SelectSingle(int? coaDetailID)
        {
            return new OpeningTrialBalanceFactory().SelectSingle(coaDetailID);
        }
        
        public int Insert()
        {
            return new OpeningTrialBalanceFactory().Insert(this);
        }
        
        public int Update()
        {
            return new OpeningTrialBalanceFactory().Update(this);
        }
        
        public int Delete()
        {
            return new OpeningTrialBalanceFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("CoaDetailID: {0}", this.CoaDetailID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class OpeningTrialBalanceFactory
    {
        
        public OpeningTrialBalanceFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("OpeningTrialBalance");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("OpeningTrialBalance");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("OpeningTrialBalance");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("OpeningTrialBalance");
            }
        }
        
        public static OpeningTrialBalanceFactory Create()
        {
            return new OpeningTrialBalanceFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    int? coaDetailID, 
                    int? accFundID, 
                    string accFundAccFundName, 
                    string accFundCode, 
                    string acccode, 
                    string accName, 
                    string accDesc, 
                    int? accTypeID, 
                    string accTypeAccType, 
                    int? accDestID, 
                    string accDestAccDest, 
                    string accDestCompanyTypeDescription, 
                    int? accBalTypeID, 
                    string accBalTypeAccBalType, 
                    int? accCurrency, 
                    string accCurrencyAccCurrencyName, 
                    string consTranCode, 
                    int? coaControlID, 
                    string coaControlAccName, 
                    string coaControlAccBalTypeAccBalType, 
                    string coaControlAccDestAccDest, 
                    string coaControlAccDestCompanyTypeDescription, 
                    string coaControlAccTypeAccType, 
                    string coaControlCompTypeDescription, 
                    int? coaSubID, 
                    string coaSubAccName, 
                    string coaSubAccBalTypeAccBalType, 
                    string coaSubAccDestAccDest, 
                    string coaSubAccDestCompanyTypeDescription, 
                    string coaSubAccFundAccFundName, 
                    string coaSubAccTypeAccType, 
                    string coaSubCoaControlAccName, 
                    string coaSubCoaControlAccBalTypeAccBalType, 
                    string coaSubCoaControlAccDestAccDest, 
                    string coaSubCoaControlAccTypeAccType, 
                    string coaSubCoaControlCompTypeDescription, 
                    string coaSubCoaMainAccName, 
                    string coaSubCoaMainAccBalTypeAccBalType, 
                    string coaSubCoaMainAccDestAccDest, 
                    string coaSubCoaMainAccFundAccFundName, 
                    string coaSubCoaMainAccTypeAccType, 
                    string coaSubCoaMainCoaControlAccName, 
                    int? coaMainID, 
                    string coaMainAccName, 
                    string coaMainAccBalTypeAccBalType, 
                    string coaMainAccDestAccDest, 
                    string coaMainAccDestCompanyTypeDescription, 
                    string coaMainAccFundAccFundName, 
                    string coaMainAccTypeAccType, 
                    string coaMainCoaControlAccName, 
                    string coaMainCoaControlAccBalTypeAccBalType, 
                    string coaMainCoaControlAccDestAccDest, 
                    string coaMainCoaControlAccTypeAccType, 
                    string coaMainCoaControlCompTypeDescription, 
                    string tranCode, 
                    bool? subsYN, 
                    int? accSubTypeID, 
                    string accSubTypeAccSubTypeName, 
                    DateTime? openDate, 
                    decimal? openDebit, 
                    decimal? openCredit, 
                    decimal? accCurrencyRate, 
                    byte? revenue, 
                    bool? variableCost, 
                    bool? monthlyExp, 
                    decimal? budget, 
                    string annex, 
                    string dlt, 
                    bool? isCashNature, 
                    bool? isBankNature, 
                    int? accSubTypeID1, 
                    int? accSubTypeID2, 
                    string bankName, 
                    string bankAccNum, 
                    string branchName, 
                    string bankAccType, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (coaDetailID.HasValue)
            	filter.Add(("CoaDetailID:=" + coaDetailID.Value.ToString()));
            if (accFundID.HasValue)
            	filter.Add(("AccFundID:=" + accFundID.Value.ToString()));
            if (!(String.IsNullOrEmpty(accFundAccFundName)))
            	filter.Add(("AccFundAccFundName:*" + accFundAccFundName));
            if (!(String.IsNullOrEmpty(accFundCode)))
            	filter.Add(("AccFundCode:*" + accFundCode));
            if (!(String.IsNullOrEmpty(acccode)))
            	filter.Add(("Acccode:*" + acccode));
            if (!(String.IsNullOrEmpty(accName)))
            	filter.Add(("AccName:*" + accName));
            if (!(String.IsNullOrEmpty(accDesc)))
            	filter.Add(("AccDesc:*" + accDesc));
            if (accTypeID.HasValue)
            	filter.Add(("AccTypeID:=" + accTypeID.Value.ToString()));
            if (!(String.IsNullOrEmpty(accTypeAccType)))
            	filter.Add(("AccTypeAccType:*" + accTypeAccType));
            if (accDestID.HasValue)
            	filter.Add(("AccDestID:=" + accDestID.Value.ToString()));
            if (!(String.IsNullOrEmpty(accDestAccDest)))
            	filter.Add(("AccDestAccDest:*" + accDestAccDest));
            if (!(String.IsNullOrEmpty(accDestCompanyTypeDescription)))
            	filter.Add(("AccDestCompanyTypeDescription:*" + accDestCompanyTypeDescription));
            if (accBalTypeID.HasValue)
            	filter.Add(("AccBalTypeID:=" + accBalTypeID.Value.ToString()));
            if (!(String.IsNullOrEmpty(accBalTypeAccBalType)))
            	filter.Add(("AccBalTypeAccBalType:*" + accBalTypeAccBalType));
            if (accCurrency.HasValue)
            	filter.Add(("AccCurrency:=" + accCurrency.Value.ToString()));
            if (!(String.IsNullOrEmpty(accCurrencyAccCurrencyName)))
            	filter.Add(("AccCurrencyAccCurrencyName:*" + accCurrencyAccCurrencyName));
            if (!(String.IsNullOrEmpty(consTranCode)))
            	filter.Add(("ConsTranCode:*" + consTranCode));
            if (coaControlID.HasValue)
            	filter.Add(("CoaControlID:=" + coaControlID.Value.ToString()));
            if (!(String.IsNullOrEmpty(coaControlAccName)))
            	filter.Add(("CoaControlAccName:*" + coaControlAccName));
            if (!(String.IsNullOrEmpty(coaControlAccBalTypeAccBalType)))
            	filter.Add(("CoaControlAccBalTypeAccBalType:*" + coaControlAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(coaControlAccDestAccDest)))
            	filter.Add(("CoaControlAccDestAccDest:*" + coaControlAccDestAccDest));
            if (!(String.IsNullOrEmpty(coaControlAccDestCompanyTypeDescription)))
            	filter.Add(("CoaControlAccDestCompanyTypeDescription:*" + coaControlAccDestCompanyTypeDescription));
            if (!(String.IsNullOrEmpty(coaControlAccTypeAccType)))
            	filter.Add(("CoaControlAccTypeAccType:*" + coaControlAccTypeAccType));
            if (!(String.IsNullOrEmpty(coaControlCompTypeDescription)))
            	filter.Add(("CoaControlCompTypeDescription:*" + coaControlCompTypeDescription));
            if (coaSubID.HasValue)
            	filter.Add(("CoaSubID:=" + coaSubID.Value.ToString()));
            if (!(String.IsNullOrEmpty(coaSubAccName)))
            	filter.Add(("CoaSubAccName:*" + coaSubAccName));
            if (!(String.IsNullOrEmpty(coaSubAccBalTypeAccBalType)))
            	filter.Add(("CoaSubAccBalTypeAccBalType:*" + coaSubAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(coaSubAccDestAccDest)))
            	filter.Add(("CoaSubAccDestAccDest:*" + coaSubAccDestAccDest));
            if (!(String.IsNullOrEmpty(coaSubAccDestCompanyTypeDescription)))
            	filter.Add(("CoaSubAccDestCompanyTypeDescription:*" + coaSubAccDestCompanyTypeDescription));
            if (!(String.IsNullOrEmpty(coaSubAccFundAccFundName)))
            	filter.Add(("CoaSubAccFundAccFundName:*" + coaSubAccFundAccFundName));
            if (!(String.IsNullOrEmpty(coaSubAccTypeAccType)))
            	filter.Add(("CoaSubAccTypeAccType:*" + coaSubAccTypeAccType));
            if (!(String.IsNullOrEmpty(coaSubCoaControlAccName)))
            	filter.Add(("CoaSubCoaControlAccName:*" + coaSubCoaControlAccName));
            if (!(String.IsNullOrEmpty(coaSubCoaControlAccBalTypeAccBalType)))
            	filter.Add(("CoaSubCoaControlAccBalTypeAccBalType:*" + coaSubCoaControlAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(coaSubCoaControlAccDestAccDest)))
            	filter.Add(("CoaSubCoaControlAccDestAccDest:*" + coaSubCoaControlAccDestAccDest));
            if (!(String.IsNullOrEmpty(coaSubCoaControlAccTypeAccType)))
            	filter.Add(("CoaSubCoaControlAccTypeAccType:*" + coaSubCoaControlAccTypeAccType));
            if (!(String.IsNullOrEmpty(coaSubCoaControlCompTypeDescription)))
            	filter.Add(("CoaSubCoaControlCompTypeDescription:*" + coaSubCoaControlCompTypeDescription));
            if (!(String.IsNullOrEmpty(coaSubCoaMainAccName)))
            	filter.Add(("CoaSubCoaMainAccName:*" + coaSubCoaMainAccName));
            if (!(String.IsNullOrEmpty(coaSubCoaMainAccBalTypeAccBalType)))
            	filter.Add(("CoaSubCoaMainAccBalTypeAccBalType:*" + coaSubCoaMainAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(coaSubCoaMainAccDestAccDest)))
            	filter.Add(("CoaSubCoaMainAccDestAccDest:*" + coaSubCoaMainAccDestAccDest));
            if (!(String.IsNullOrEmpty(coaSubCoaMainAccFundAccFundName)))
            	filter.Add(("CoaSubCoaMainAccFundAccFundName:*" + coaSubCoaMainAccFundAccFundName));
            if (!(String.IsNullOrEmpty(coaSubCoaMainAccTypeAccType)))
            	filter.Add(("CoaSubCoaMainAccTypeAccType:*" + coaSubCoaMainAccTypeAccType));
            if (!(String.IsNullOrEmpty(coaSubCoaMainCoaControlAccName)))
            	filter.Add(("CoaSubCoaMainCoaControlAccName:*" + coaSubCoaMainCoaControlAccName));
            if (coaMainID.HasValue)
            	filter.Add(("CoaMainID:=" + coaMainID.Value.ToString()));
            if (!(String.IsNullOrEmpty(coaMainAccName)))
            	filter.Add(("CoaMainAccName:*" + coaMainAccName));
            if (!(String.IsNullOrEmpty(coaMainAccBalTypeAccBalType)))
            	filter.Add(("CoaMainAccBalTypeAccBalType:*" + coaMainAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(coaMainAccDestAccDest)))
            	filter.Add(("CoaMainAccDestAccDest:*" + coaMainAccDestAccDest));
            if (!(String.IsNullOrEmpty(coaMainAccDestCompanyTypeDescription)))
            	filter.Add(("CoaMainAccDestCompanyTypeDescription:*" + coaMainAccDestCompanyTypeDescription));
            if (!(String.IsNullOrEmpty(coaMainAccFundAccFundName)))
            	filter.Add(("CoaMainAccFundAccFundName:*" + coaMainAccFundAccFundName));
            if (!(String.IsNullOrEmpty(coaMainAccTypeAccType)))
            	filter.Add(("CoaMainAccTypeAccType:*" + coaMainAccTypeAccType));
            if (!(String.IsNullOrEmpty(coaMainCoaControlAccName)))
            	filter.Add(("CoaMainCoaControlAccName:*" + coaMainCoaControlAccName));
            if (!(String.IsNullOrEmpty(coaMainCoaControlAccBalTypeAccBalType)))
            	filter.Add(("CoaMainCoaControlAccBalTypeAccBalType:*" + coaMainCoaControlAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(coaMainCoaControlAccDestAccDest)))
            	filter.Add(("CoaMainCoaControlAccDestAccDest:*" + coaMainCoaControlAccDestAccDest));
            if (!(String.IsNullOrEmpty(coaMainCoaControlAccTypeAccType)))
            	filter.Add(("CoaMainCoaControlAccTypeAccType:*" + coaMainCoaControlAccTypeAccType));
            if (!(String.IsNullOrEmpty(coaMainCoaControlCompTypeDescription)))
            	filter.Add(("CoaMainCoaControlCompTypeDescription:*" + coaMainCoaControlCompTypeDescription));
            if (!(String.IsNullOrEmpty(tranCode)))
            	filter.Add(("TranCode:*" + tranCode));
            if (subsYN.HasValue)
            	filter.Add(("SubsYN:=" + subsYN.Value.ToString()));
            if (accSubTypeID.HasValue)
            	filter.Add(("AccSubTypeID:=" + accSubTypeID.Value.ToString()));
            if (!(String.IsNullOrEmpty(accSubTypeAccSubTypeName)))
            	filter.Add(("AccSubTypeAccSubTypeName:*" + accSubTypeAccSubTypeName));
            if (openDate.HasValue)
            	filter.Add(("OpenDate:=" + openDate.Value.ToString()));
            if (openDebit.HasValue)
            	filter.Add(("OpenDebit:=" + openDebit.Value.ToString()));
            if (openCredit.HasValue)
            	filter.Add(("OpenCredit:=" + openCredit.Value.ToString()));
            if (accCurrencyRate.HasValue)
            	filter.Add(("AccCurrencyRate:=" + accCurrencyRate.Value.ToString()));
            if (revenue.HasValue)
            	filter.Add(("Revenue:=" + revenue.Value.ToString()));
            if (variableCost.HasValue)
            	filter.Add(("VariableCost:=" + variableCost.Value.ToString()));
            if (monthlyExp.HasValue)
            	filter.Add(("MonthlyExp:=" + monthlyExp.Value.ToString()));
            if (budget.HasValue)
            	filter.Add(("Budget:=" + budget.Value.ToString()));
            if (!(String.IsNullOrEmpty(annex)))
            	filter.Add(("Annex:*" + annex));
            if (!(String.IsNullOrEmpty(dlt)))
            	filter.Add(("Dlt:*" + dlt));
            if (isCashNature.HasValue)
            	filter.Add(("IsCashNature:=" + isCashNature.Value.ToString()));
            if (isBankNature.HasValue)
            	filter.Add(("IsBankNature:=" + isBankNature.Value.ToString()));
            if (accSubTypeID1.HasValue)
            	filter.Add(("AccSubTypeID1:=" + accSubTypeID1.Value.ToString()));
            if (accSubTypeID2.HasValue)
            	filter.Add(("AccSubTypeID2:=" + accSubTypeID2.Value.ToString()));
            if (!(String.IsNullOrEmpty(bankName)))
            	filter.Add(("BankName:*" + bankName));
            if (!(String.IsNullOrEmpty(bankAccNum)))
            	filter.Add(("BankAccNum:*" + bankAccNum));
            if (!(String.IsNullOrEmpty(branchName)))
            	filter.Add(("BranchName:*" + branchName));
            if (!(String.IsNullOrEmpty(bankAccType)))
            	filter.Add(("BankAccType:*" + bankAccType));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.OpeningTrialBalance> Select(
                    int? coaDetailID, 
                    int? accFundID, 
                    string accFundAccFundName, 
                    string accFundCode, 
                    string acccode, 
                    string accName, 
                    string accDesc, 
                    int? accTypeID, 
                    string accTypeAccType, 
                    int? accDestID, 
                    string accDestAccDest, 
                    string accDestCompanyTypeDescription, 
                    int? accBalTypeID, 
                    string accBalTypeAccBalType, 
                    int? accCurrency, 
                    string accCurrencyAccCurrencyName, 
                    string consTranCode, 
                    int? coaControlID, 
                    string coaControlAccName, 
                    string coaControlAccBalTypeAccBalType, 
                    string coaControlAccDestAccDest, 
                    string coaControlAccDestCompanyTypeDescription, 
                    string coaControlAccTypeAccType, 
                    string coaControlCompTypeDescription, 
                    int? coaSubID, 
                    string coaSubAccName, 
                    string coaSubAccBalTypeAccBalType, 
                    string coaSubAccDestAccDest, 
                    string coaSubAccDestCompanyTypeDescription, 
                    string coaSubAccFundAccFundName, 
                    string coaSubAccTypeAccType, 
                    string coaSubCoaControlAccName, 
                    string coaSubCoaControlAccBalTypeAccBalType, 
                    string coaSubCoaControlAccDestAccDest, 
                    string coaSubCoaControlAccTypeAccType, 
                    string coaSubCoaControlCompTypeDescription, 
                    string coaSubCoaMainAccName, 
                    string coaSubCoaMainAccBalTypeAccBalType, 
                    string coaSubCoaMainAccDestAccDest, 
                    string coaSubCoaMainAccFundAccFundName, 
                    string coaSubCoaMainAccTypeAccType, 
                    string coaSubCoaMainCoaControlAccName, 
                    int? coaMainID, 
                    string coaMainAccName, 
                    string coaMainAccBalTypeAccBalType, 
                    string coaMainAccDestAccDest, 
                    string coaMainAccDestCompanyTypeDescription, 
                    string coaMainAccFundAccFundName, 
                    string coaMainAccTypeAccType, 
                    string coaMainCoaControlAccName, 
                    string coaMainCoaControlAccBalTypeAccBalType, 
                    string coaMainCoaControlAccDestAccDest, 
                    string coaMainCoaControlAccTypeAccType, 
                    string coaMainCoaControlCompTypeDescription, 
                    string tranCode, 
                    bool? subsYN, 
                    int? accSubTypeID, 
                    string accSubTypeAccSubTypeName, 
                    DateTime? openDate, 
                    decimal? openDebit, 
                    decimal? openCredit, 
                    decimal? accCurrencyRate, 
                    byte? revenue, 
                    bool? variableCost, 
                    bool? monthlyExp, 
                    decimal? budget, 
                    string annex, 
                    string dlt, 
                    bool? isCashNature, 
                    bool? isBankNature, 
                    int? accSubTypeID1, 
                    int? accSubTypeID2, 
                    string bankName, 
                    string bankAccNum, 
                    string branchName, 
                    string bankAccType, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(coaDetailID, accFundID, accFundAccFundName, accFundCode, acccode, accName, accDesc, accTypeID, accTypeAccType, accDestID, accDestAccDest, accDestCompanyTypeDescription, accBalTypeID, accBalTypeAccBalType, accCurrency, accCurrencyAccCurrencyName, consTranCode, coaControlID, coaControlAccName, coaControlAccBalTypeAccBalType, coaControlAccDestAccDest, coaControlAccDestCompanyTypeDescription, coaControlAccTypeAccType, coaControlCompTypeDescription, coaSubID, coaSubAccName, coaSubAccBalTypeAccBalType, coaSubAccDestAccDest, coaSubAccDestCompanyTypeDescription, coaSubAccFundAccFundName, coaSubAccTypeAccType, coaSubCoaControlAccName, coaSubCoaControlAccBalTypeAccBalType, coaSubCoaControlAccDestAccDest, coaSubCoaControlAccTypeAccType, coaSubCoaControlCompTypeDescription, coaSubCoaMainAccName, coaSubCoaMainAccBalTypeAccBalType, coaSubCoaMainAccDestAccDest, coaSubCoaMainAccFundAccFundName, coaSubCoaMainAccTypeAccType, coaSubCoaMainCoaControlAccName, coaMainID, coaMainAccName, coaMainAccBalTypeAccBalType, coaMainAccDestAccDest, coaMainAccDestCompanyTypeDescription, coaMainAccFundAccFundName, coaMainAccTypeAccType, coaMainCoaControlAccName, coaMainCoaControlAccBalTypeAccBalType, coaMainCoaControlAccDestAccDest, coaMainCoaControlAccTypeAccType, coaMainCoaControlCompTypeDescription, tranCode, subsYN, accSubTypeID, accSubTypeAccSubTypeName, openDate, openDebit, openCredit, accCurrencyRate, revenue, variableCost, monthlyExp, budget, annex, dlt, isCashNature, isBankNature, accSubTypeID1, accSubTypeID2, bankName, bankAccNum, branchName, bankAccType, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("OpeningTrialBalance", dataView, request);
            return page.ToList<MyCompany.Data.Objects.OpeningTrialBalance>();
        }
        
        public List<MyCompany.Data.Objects.OpeningTrialBalance> Select(MyCompany.Data.Objects.OpeningTrialBalance qbe)
        {
            return Select(qbe.CoaDetailID, qbe.AccFundID, qbe.AccFundAccFundName, qbe.AccFundCode, qbe.Acccode, qbe.AccName, qbe.AccDesc, qbe.AccTypeID, qbe.AccTypeAccType, qbe.AccDestID, qbe.AccDestAccDest, qbe.AccDestCompanyTypeDescription, qbe.AccBalTypeID, qbe.AccBalTypeAccBalType, qbe.AccCurrency, qbe.AccCurrencyAccCurrencyName, qbe.ConsTranCode, qbe.CoaControlID, qbe.CoaControlAccName, qbe.CoaControlAccBalTypeAccBalType, qbe.CoaControlAccDestAccDest, qbe.CoaControlAccDestCompanyTypeDescription, qbe.CoaControlAccTypeAccType, qbe.CoaControlCompTypeDescription, qbe.CoaSubID, qbe.CoaSubAccName, qbe.CoaSubAccBalTypeAccBalType, qbe.CoaSubAccDestAccDest, qbe.CoaSubAccDestCompanyTypeDescription, qbe.CoaSubAccFundAccFundName, qbe.CoaSubAccTypeAccType, qbe.CoaSubCoaControlAccName, qbe.CoaSubCoaControlAccBalTypeAccBalType, qbe.CoaSubCoaControlAccDestAccDest, qbe.CoaSubCoaControlAccTypeAccType, qbe.CoaSubCoaControlCompTypeDescription, qbe.CoaSubCoaMainAccName, qbe.CoaSubCoaMainAccBalTypeAccBalType, qbe.CoaSubCoaMainAccDestAccDest, qbe.CoaSubCoaMainAccFundAccFundName, qbe.CoaSubCoaMainAccTypeAccType, qbe.CoaSubCoaMainCoaControlAccName, qbe.CoaMainID, qbe.CoaMainAccName, qbe.CoaMainAccBalTypeAccBalType, qbe.CoaMainAccDestAccDest, qbe.CoaMainAccDestCompanyTypeDescription, qbe.CoaMainAccFundAccFundName, qbe.CoaMainAccTypeAccType, qbe.CoaMainCoaControlAccName, qbe.CoaMainCoaControlAccBalTypeAccBalType, qbe.CoaMainCoaControlAccDestAccDest, qbe.CoaMainCoaControlAccTypeAccType, qbe.CoaMainCoaControlCompTypeDescription, qbe.TranCode, qbe.SubsYN, qbe.AccSubTypeID, qbe.AccSubTypeAccSubTypeName, qbe.OpenDate, qbe.OpenDebit, qbe.OpenCredit, qbe.AccCurrencyRate, qbe.Revenue, qbe.VariableCost, qbe.MonthlyExp, qbe.Budget, qbe.Annex, qbe.Dlt, qbe.IsCashNature, qbe.IsBankNature, qbe.AccSubTypeID1, qbe.AccSubTypeID2, qbe.BankName, qbe.BankAccNum, qbe.BranchName, qbe.BankAccType);
        }
        
        public int SelectCount(
                    int? coaDetailID, 
                    int? accFundID, 
                    string accFundAccFundName, 
                    string accFundCode, 
                    string acccode, 
                    string accName, 
                    string accDesc, 
                    int? accTypeID, 
                    string accTypeAccType, 
                    int? accDestID, 
                    string accDestAccDest, 
                    string accDestCompanyTypeDescription, 
                    int? accBalTypeID, 
                    string accBalTypeAccBalType, 
                    int? accCurrency, 
                    string accCurrencyAccCurrencyName, 
                    string consTranCode, 
                    int? coaControlID, 
                    string coaControlAccName, 
                    string coaControlAccBalTypeAccBalType, 
                    string coaControlAccDestAccDest, 
                    string coaControlAccDestCompanyTypeDescription, 
                    string coaControlAccTypeAccType, 
                    string coaControlCompTypeDescription, 
                    int? coaSubID, 
                    string coaSubAccName, 
                    string coaSubAccBalTypeAccBalType, 
                    string coaSubAccDestAccDest, 
                    string coaSubAccDestCompanyTypeDescription, 
                    string coaSubAccFundAccFundName, 
                    string coaSubAccTypeAccType, 
                    string coaSubCoaControlAccName, 
                    string coaSubCoaControlAccBalTypeAccBalType, 
                    string coaSubCoaControlAccDestAccDest, 
                    string coaSubCoaControlAccTypeAccType, 
                    string coaSubCoaControlCompTypeDescription, 
                    string coaSubCoaMainAccName, 
                    string coaSubCoaMainAccBalTypeAccBalType, 
                    string coaSubCoaMainAccDestAccDest, 
                    string coaSubCoaMainAccFundAccFundName, 
                    string coaSubCoaMainAccTypeAccType, 
                    string coaSubCoaMainCoaControlAccName, 
                    int? coaMainID, 
                    string coaMainAccName, 
                    string coaMainAccBalTypeAccBalType, 
                    string coaMainAccDestAccDest, 
                    string coaMainAccDestCompanyTypeDescription, 
                    string coaMainAccFundAccFundName, 
                    string coaMainAccTypeAccType, 
                    string coaMainCoaControlAccName, 
                    string coaMainCoaControlAccBalTypeAccBalType, 
                    string coaMainCoaControlAccDestAccDest, 
                    string coaMainCoaControlAccTypeAccType, 
                    string coaMainCoaControlCompTypeDescription, 
                    string tranCode, 
                    bool? subsYN, 
                    int? accSubTypeID, 
                    string accSubTypeAccSubTypeName, 
                    DateTime? openDate, 
                    decimal? openDebit, 
                    decimal? openCredit, 
                    decimal? accCurrencyRate, 
                    byte? revenue, 
                    bool? variableCost, 
                    bool? monthlyExp, 
                    decimal? budget, 
                    string annex, 
                    string dlt, 
                    bool? isCashNature, 
                    bool? isBankNature, 
                    int? accSubTypeID1, 
                    int? accSubTypeID2, 
                    string bankName, 
                    string bankAccNum, 
                    string branchName, 
                    string bankAccType, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(coaDetailID, accFundID, accFundAccFundName, accFundCode, acccode, accName, accDesc, accTypeID, accTypeAccType, accDestID, accDestAccDest, accDestCompanyTypeDescription, accBalTypeID, accBalTypeAccBalType, accCurrency, accCurrencyAccCurrencyName, consTranCode, coaControlID, coaControlAccName, coaControlAccBalTypeAccBalType, coaControlAccDestAccDest, coaControlAccDestCompanyTypeDescription, coaControlAccTypeAccType, coaControlCompTypeDescription, coaSubID, coaSubAccName, coaSubAccBalTypeAccBalType, coaSubAccDestAccDest, coaSubAccDestCompanyTypeDescription, coaSubAccFundAccFundName, coaSubAccTypeAccType, coaSubCoaControlAccName, coaSubCoaControlAccBalTypeAccBalType, coaSubCoaControlAccDestAccDest, coaSubCoaControlAccTypeAccType, coaSubCoaControlCompTypeDescription, coaSubCoaMainAccName, coaSubCoaMainAccBalTypeAccBalType, coaSubCoaMainAccDestAccDest, coaSubCoaMainAccFundAccFundName, coaSubCoaMainAccTypeAccType, coaSubCoaMainCoaControlAccName, coaMainID, coaMainAccName, coaMainAccBalTypeAccBalType, coaMainAccDestAccDest, coaMainAccDestCompanyTypeDescription, coaMainAccFundAccFundName, coaMainAccTypeAccType, coaMainCoaControlAccName, coaMainCoaControlAccBalTypeAccBalType, coaMainCoaControlAccDestAccDest, coaMainCoaControlAccTypeAccType, coaMainCoaControlCompTypeDescription, tranCode, subsYN, accSubTypeID, accSubTypeAccSubTypeName, openDate, openDebit, openCredit, accCurrencyRate, revenue, variableCost, monthlyExp, budget, annex, dlt, isCashNature, isBankNature, accSubTypeID1, accSubTypeID2, bankName, bankAccNum, branchName, bankAccType, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("OpeningTrialBalance", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.OpeningTrialBalance> Select(
                    int? coaDetailID, 
                    int? accFundID, 
                    string accFundAccFundName, 
                    string accFundCode, 
                    string acccode, 
                    string accName, 
                    string accDesc, 
                    int? accTypeID, 
                    string accTypeAccType, 
                    int? accDestID, 
                    string accDestAccDest, 
                    string accDestCompanyTypeDescription, 
                    int? accBalTypeID, 
                    string accBalTypeAccBalType, 
                    int? accCurrency, 
                    string accCurrencyAccCurrencyName, 
                    string consTranCode, 
                    int? coaControlID, 
                    string coaControlAccName, 
                    string coaControlAccBalTypeAccBalType, 
                    string coaControlAccDestAccDest, 
                    string coaControlAccDestCompanyTypeDescription, 
                    string coaControlAccTypeAccType, 
                    string coaControlCompTypeDescription, 
                    int? coaSubID, 
                    string coaSubAccName, 
                    string coaSubAccBalTypeAccBalType, 
                    string coaSubAccDestAccDest, 
                    string coaSubAccDestCompanyTypeDescription, 
                    string coaSubAccFundAccFundName, 
                    string coaSubAccTypeAccType, 
                    string coaSubCoaControlAccName, 
                    string coaSubCoaControlAccBalTypeAccBalType, 
                    string coaSubCoaControlAccDestAccDest, 
                    string coaSubCoaControlAccTypeAccType, 
                    string coaSubCoaControlCompTypeDescription, 
                    string coaSubCoaMainAccName, 
                    string coaSubCoaMainAccBalTypeAccBalType, 
                    string coaSubCoaMainAccDestAccDest, 
                    string coaSubCoaMainAccFundAccFundName, 
                    string coaSubCoaMainAccTypeAccType, 
                    string coaSubCoaMainCoaControlAccName, 
                    int? coaMainID, 
                    string coaMainAccName, 
                    string coaMainAccBalTypeAccBalType, 
                    string coaMainAccDestAccDest, 
                    string coaMainAccDestCompanyTypeDescription, 
                    string coaMainAccFundAccFundName, 
                    string coaMainAccTypeAccType, 
                    string coaMainCoaControlAccName, 
                    string coaMainCoaControlAccBalTypeAccBalType, 
                    string coaMainCoaControlAccDestAccDest, 
                    string coaMainCoaControlAccTypeAccType, 
                    string coaMainCoaControlCompTypeDescription, 
                    string tranCode, 
                    bool? subsYN, 
                    int? accSubTypeID, 
                    string accSubTypeAccSubTypeName, 
                    DateTime? openDate, 
                    decimal? openDebit, 
                    decimal? openCredit, 
                    decimal? accCurrencyRate, 
                    byte? revenue, 
                    bool? variableCost, 
                    bool? monthlyExp, 
                    decimal? budget, 
                    string annex, 
                    string dlt, 
                    bool? isCashNature, 
                    bool? isBankNature, 
                    int? accSubTypeID1, 
                    int? accSubTypeID2, 
                    string bankName, 
                    string bankAccNum, 
                    string branchName, 
                    string bankAccType)
        {
            return Select(coaDetailID, accFundID, accFundAccFundName, accFundCode, acccode, accName, accDesc, accTypeID, accTypeAccType, accDestID, accDestAccDest, accDestCompanyTypeDescription, accBalTypeID, accBalTypeAccBalType, accCurrency, accCurrencyAccCurrencyName, consTranCode, coaControlID, coaControlAccName, coaControlAccBalTypeAccBalType, coaControlAccDestAccDest, coaControlAccDestCompanyTypeDescription, coaControlAccTypeAccType, coaControlCompTypeDescription, coaSubID, coaSubAccName, coaSubAccBalTypeAccBalType, coaSubAccDestAccDest, coaSubAccDestCompanyTypeDescription, coaSubAccFundAccFundName, coaSubAccTypeAccType, coaSubCoaControlAccName, coaSubCoaControlAccBalTypeAccBalType, coaSubCoaControlAccDestAccDest, coaSubCoaControlAccTypeAccType, coaSubCoaControlCompTypeDescription, coaSubCoaMainAccName, coaSubCoaMainAccBalTypeAccBalType, coaSubCoaMainAccDestAccDest, coaSubCoaMainAccFundAccFundName, coaSubCoaMainAccTypeAccType, coaSubCoaMainCoaControlAccName, coaMainID, coaMainAccName, coaMainAccBalTypeAccBalType, coaMainAccDestAccDest, coaMainAccDestCompanyTypeDescription, coaMainAccFundAccFundName, coaMainAccTypeAccType, coaMainCoaControlAccName, coaMainCoaControlAccBalTypeAccBalType, coaMainCoaControlAccDestAccDest, coaMainCoaControlAccTypeAccType, coaMainCoaControlCompTypeDescription, tranCode, subsYN, accSubTypeID, accSubTypeAccSubTypeName, openDate, openDebit, openCredit, accCurrencyRate, revenue, variableCost, monthlyExp, budget, annex, dlt, isCashNature, isBankNature, accSubTypeID1, accSubTypeID2, bankName, bankAccNum, branchName, bankAccType, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.OpeningTrialBalance SelectSingle(int? coaDetailID)
        {
            List<MyCompany.Data.Objects.OpeningTrialBalance> list = Select(coaDetailID, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.OpeningTrialBalance> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("OpeningTrialBalance", dataView, request);
            return page.ToList<MyCompany.Data.Objects.OpeningTrialBalance>();
        }
        
        public List<MyCompany.Data.Objects.OpeningTrialBalance> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.OpeningTrialBalance> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.OpeningTrialBalance SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.OpeningTrialBalance> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.OpeningTrialBalance theOpeningTrialBalance, MyCompany.Data.Objects.OpeningTrialBalance original_OpeningTrialBalance)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("CoaDetailID", original_OpeningTrialBalance.CoaDetailID, theOpeningTrialBalance.CoaDetailID, true));
            values.Add(new FieldValue("AccFundID", original_OpeningTrialBalance.AccFundID, theOpeningTrialBalance.AccFundID));
            values.Add(new FieldValue("AccFundAccFundName", original_OpeningTrialBalance.AccFundAccFundName, theOpeningTrialBalance.AccFundAccFundName, true));
            values.Add(new FieldValue("AccFundCode", original_OpeningTrialBalance.AccFundCode, theOpeningTrialBalance.AccFundCode));
            values.Add(new FieldValue("Acccode", original_OpeningTrialBalance.Acccode, theOpeningTrialBalance.Acccode));
            values.Add(new FieldValue("AccName", original_OpeningTrialBalance.AccName, theOpeningTrialBalance.AccName));
            values.Add(new FieldValue("AccDesc", original_OpeningTrialBalance.AccDesc, theOpeningTrialBalance.AccDesc));
            values.Add(new FieldValue("AccTypeID", original_OpeningTrialBalance.AccTypeID, theOpeningTrialBalance.AccTypeID));
            values.Add(new FieldValue("AccTypeAccType", original_OpeningTrialBalance.AccTypeAccType, theOpeningTrialBalance.AccTypeAccType, true));
            values.Add(new FieldValue("AccDestID", original_OpeningTrialBalance.AccDestID, theOpeningTrialBalance.AccDestID));
            values.Add(new FieldValue("AccDestAccDest", original_OpeningTrialBalance.AccDestAccDest, theOpeningTrialBalance.AccDestAccDest, true));
            values.Add(new FieldValue("AccDestCompanyTypeDescription", original_OpeningTrialBalance.AccDestCompanyTypeDescription, theOpeningTrialBalance.AccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("AccBalTypeID", original_OpeningTrialBalance.AccBalTypeID, theOpeningTrialBalance.AccBalTypeID));
            values.Add(new FieldValue("AccBalTypeAccBalType", original_OpeningTrialBalance.AccBalTypeAccBalType, theOpeningTrialBalance.AccBalTypeAccBalType, true));
            values.Add(new FieldValue("AccCurrency", original_OpeningTrialBalance.AccCurrency, theOpeningTrialBalance.AccCurrency));
            values.Add(new FieldValue("AccCurrencyAccCurrencyName", original_OpeningTrialBalance.AccCurrencyAccCurrencyName, theOpeningTrialBalance.AccCurrencyAccCurrencyName, true));
            values.Add(new FieldValue("ConsTranCode", original_OpeningTrialBalance.ConsTranCode, theOpeningTrialBalance.ConsTranCode));
            values.Add(new FieldValue("CoaControlID", original_OpeningTrialBalance.CoaControlID, theOpeningTrialBalance.CoaControlID));
            values.Add(new FieldValue("CoaControlAccName", original_OpeningTrialBalance.CoaControlAccName, theOpeningTrialBalance.CoaControlAccName, true));
            values.Add(new FieldValue("CoaControlAccBalTypeAccBalType", original_OpeningTrialBalance.CoaControlAccBalTypeAccBalType, theOpeningTrialBalance.CoaControlAccBalTypeAccBalType, true));
            values.Add(new FieldValue("CoaControlAccDestAccDest", original_OpeningTrialBalance.CoaControlAccDestAccDest, theOpeningTrialBalance.CoaControlAccDestAccDest, true));
            values.Add(new FieldValue("CoaControlAccDestCompanyTypeDescription", original_OpeningTrialBalance.CoaControlAccDestCompanyTypeDescription, theOpeningTrialBalance.CoaControlAccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("CoaControlAccTypeAccType", original_OpeningTrialBalance.CoaControlAccTypeAccType, theOpeningTrialBalance.CoaControlAccTypeAccType, true));
            values.Add(new FieldValue("CoaControlCompTypeDescription", original_OpeningTrialBalance.CoaControlCompTypeDescription, theOpeningTrialBalance.CoaControlCompTypeDescription, true));
            values.Add(new FieldValue("CoaSubID", original_OpeningTrialBalance.CoaSubID, theOpeningTrialBalance.CoaSubID));
            values.Add(new FieldValue("CoaSubAccName", original_OpeningTrialBalance.CoaSubAccName, theOpeningTrialBalance.CoaSubAccName, true));
            values.Add(new FieldValue("CoaSubAccBalTypeAccBalType", original_OpeningTrialBalance.CoaSubAccBalTypeAccBalType, theOpeningTrialBalance.CoaSubAccBalTypeAccBalType, true));
            values.Add(new FieldValue("CoaSubAccDestAccDest", original_OpeningTrialBalance.CoaSubAccDestAccDest, theOpeningTrialBalance.CoaSubAccDestAccDest, true));
            values.Add(new FieldValue("CoaSubAccDestCompanyTypeDescription", original_OpeningTrialBalance.CoaSubAccDestCompanyTypeDescription, theOpeningTrialBalance.CoaSubAccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("CoaSubAccFundAccFundName", original_OpeningTrialBalance.CoaSubAccFundAccFundName, theOpeningTrialBalance.CoaSubAccFundAccFundName, true));
            values.Add(new FieldValue("CoaSubAccTypeAccType", original_OpeningTrialBalance.CoaSubAccTypeAccType, theOpeningTrialBalance.CoaSubAccTypeAccType, true));
            values.Add(new FieldValue("CoaSubCoaControlAccName", original_OpeningTrialBalance.CoaSubCoaControlAccName, theOpeningTrialBalance.CoaSubCoaControlAccName, true));
            values.Add(new FieldValue("CoaSubCoaControlAccBalTypeAccBalType", original_OpeningTrialBalance.CoaSubCoaControlAccBalTypeAccBalType, theOpeningTrialBalance.CoaSubCoaControlAccBalTypeAccBalType, true));
            values.Add(new FieldValue("CoaSubCoaControlAccDestAccDest", original_OpeningTrialBalance.CoaSubCoaControlAccDestAccDest, theOpeningTrialBalance.CoaSubCoaControlAccDestAccDest, true));
            values.Add(new FieldValue("CoaSubCoaControlAccTypeAccType", original_OpeningTrialBalance.CoaSubCoaControlAccTypeAccType, theOpeningTrialBalance.CoaSubCoaControlAccTypeAccType, true));
            values.Add(new FieldValue("CoaSubCoaControlCompTypeDescription", original_OpeningTrialBalance.CoaSubCoaControlCompTypeDescription, theOpeningTrialBalance.CoaSubCoaControlCompTypeDescription, true));
            values.Add(new FieldValue("CoaSubCoaMainAccName", original_OpeningTrialBalance.CoaSubCoaMainAccName, theOpeningTrialBalance.CoaSubCoaMainAccName, true));
            values.Add(new FieldValue("CoaSubCoaMainAccBalTypeAccBalType", original_OpeningTrialBalance.CoaSubCoaMainAccBalTypeAccBalType, theOpeningTrialBalance.CoaSubCoaMainAccBalTypeAccBalType, true));
            values.Add(new FieldValue("CoaSubCoaMainAccDestAccDest", original_OpeningTrialBalance.CoaSubCoaMainAccDestAccDest, theOpeningTrialBalance.CoaSubCoaMainAccDestAccDest, true));
            values.Add(new FieldValue("CoaSubCoaMainAccFundAccFundName", original_OpeningTrialBalance.CoaSubCoaMainAccFundAccFundName, theOpeningTrialBalance.CoaSubCoaMainAccFundAccFundName, true));
            values.Add(new FieldValue("CoaSubCoaMainAccTypeAccType", original_OpeningTrialBalance.CoaSubCoaMainAccTypeAccType, theOpeningTrialBalance.CoaSubCoaMainAccTypeAccType, true));
            values.Add(new FieldValue("CoaSubCoaMainCoaControlAccName", original_OpeningTrialBalance.CoaSubCoaMainCoaControlAccName, theOpeningTrialBalance.CoaSubCoaMainCoaControlAccName, true));
            values.Add(new FieldValue("CoaMainID", original_OpeningTrialBalance.CoaMainID, theOpeningTrialBalance.CoaMainID));
            values.Add(new FieldValue("CoaMainAccName", original_OpeningTrialBalance.CoaMainAccName, theOpeningTrialBalance.CoaMainAccName, true));
            values.Add(new FieldValue("CoaMainAccBalTypeAccBalType", original_OpeningTrialBalance.CoaMainAccBalTypeAccBalType, theOpeningTrialBalance.CoaMainAccBalTypeAccBalType, true));
            values.Add(new FieldValue("CoaMainAccDestAccDest", original_OpeningTrialBalance.CoaMainAccDestAccDest, theOpeningTrialBalance.CoaMainAccDestAccDest, true));
            values.Add(new FieldValue("CoaMainAccDestCompanyTypeDescription", original_OpeningTrialBalance.CoaMainAccDestCompanyTypeDescription, theOpeningTrialBalance.CoaMainAccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("CoaMainAccFundAccFundName", original_OpeningTrialBalance.CoaMainAccFundAccFundName, theOpeningTrialBalance.CoaMainAccFundAccFundName, true));
            values.Add(new FieldValue("CoaMainAccTypeAccType", original_OpeningTrialBalance.CoaMainAccTypeAccType, theOpeningTrialBalance.CoaMainAccTypeAccType, true));
            values.Add(new FieldValue("CoaMainCoaControlAccName", original_OpeningTrialBalance.CoaMainCoaControlAccName, theOpeningTrialBalance.CoaMainCoaControlAccName, true));
            values.Add(new FieldValue("CoaMainCoaControlAccBalTypeAccBalType", original_OpeningTrialBalance.CoaMainCoaControlAccBalTypeAccBalType, theOpeningTrialBalance.CoaMainCoaControlAccBalTypeAccBalType, true));
            values.Add(new FieldValue("CoaMainCoaControlAccDestAccDest", original_OpeningTrialBalance.CoaMainCoaControlAccDestAccDest, theOpeningTrialBalance.CoaMainCoaControlAccDestAccDest, true));
            values.Add(new FieldValue("CoaMainCoaControlAccTypeAccType", original_OpeningTrialBalance.CoaMainCoaControlAccTypeAccType, theOpeningTrialBalance.CoaMainCoaControlAccTypeAccType, true));
            values.Add(new FieldValue("CoaMainCoaControlCompTypeDescription", original_OpeningTrialBalance.CoaMainCoaControlCompTypeDescription, theOpeningTrialBalance.CoaMainCoaControlCompTypeDescription, true));
            values.Add(new FieldValue("TranCode", original_OpeningTrialBalance.TranCode, theOpeningTrialBalance.TranCode));
            values.Add(new FieldValue("SubsYN", original_OpeningTrialBalance.SubsYN, theOpeningTrialBalance.SubsYN));
            values.Add(new FieldValue("AccSubTypeID", original_OpeningTrialBalance.AccSubTypeID, theOpeningTrialBalance.AccSubTypeID));
            values.Add(new FieldValue("AccSubTypeAccSubTypeName", original_OpeningTrialBalance.AccSubTypeAccSubTypeName, theOpeningTrialBalance.AccSubTypeAccSubTypeName, true));
            values.Add(new FieldValue("OpenDate", original_OpeningTrialBalance.OpenDate, theOpeningTrialBalance.OpenDate));
            values.Add(new FieldValue("OpenDebit", original_OpeningTrialBalance.OpenDebit, theOpeningTrialBalance.OpenDebit));
            values.Add(new FieldValue("OpenCredit", original_OpeningTrialBalance.OpenCredit, theOpeningTrialBalance.OpenCredit));
            values.Add(new FieldValue("AccCurrencyRate", original_OpeningTrialBalance.AccCurrencyRate, theOpeningTrialBalance.AccCurrencyRate));
            values.Add(new FieldValue("Revenue", original_OpeningTrialBalance.Revenue, theOpeningTrialBalance.Revenue));
            values.Add(new FieldValue("VariableCost", original_OpeningTrialBalance.VariableCost, theOpeningTrialBalance.VariableCost));
            values.Add(new FieldValue("MonthlyExp", original_OpeningTrialBalance.MonthlyExp, theOpeningTrialBalance.MonthlyExp));
            values.Add(new FieldValue("Budget", original_OpeningTrialBalance.Budget, theOpeningTrialBalance.Budget));
            values.Add(new FieldValue("Annex", original_OpeningTrialBalance.Annex, theOpeningTrialBalance.Annex));
            values.Add(new FieldValue("Dlt", original_OpeningTrialBalance.Dlt, theOpeningTrialBalance.Dlt));
            values.Add(new FieldValue("IsCashNature", original_OpeningTrialBalance.IsCashNature, theOpeningTrialBalance.IsCashNature));
            values.Add(new FieldValue("IsBankNature", original_OpeningTrialBalance.IsBankNature, theOpeningTrialBalance.IsBankNature));
            values.Add(new FieldValue("AccSubTypeID1", original_OpeningTrialBalance.AccSubTypeID1, theOpeningTrialBalance.AccSubTypeID1));
            values.Add(new FieldValue("AccSubTypeID2", original_OpeningTrialBalance.AccSubTypeID2, theOpeningTrialBalance.AccSubTypeID2));
            values.Add(new FieldValue("BankName", original_OpeningTrialBalance.BankName, theOpeningTrialBalance.BankName));
            values.Add(new FieldValue("BankAccNum", original_OpeningTrialBalance.BankAccNum, theOpeningTrialBalance.BankAccNum));
            values.Add(new FieldValue("BranchName", original_OpeningTrialBalance.BranchName, theOpeningTrialBalance.BranchName));
            values.Add(new FieldValue("BankAccType", original_OpeningTrialBalance.BankAccType, theOpeningTrialBalance.BankAccType));
            values.Add(new FieldValue("AccSubTypeAccSubTypeName1", original_OpeningTrialBalance.AccSubTypeAccSubTypeName1, theOpeningTrialBalance.AccSubTypeAccSubTypeName1));
            values.Add(new FieldValue("AccSubTypeAccSubTypeName2", original_OpeningTrialBalance.AccSubTypeAccSubTypeName2, theOpeningTrialBalance.AccSubTypeAccSubTypeName2));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.OpeningTrialBalance theOpeningTrialBalance, MyCompany.Data.Objects.OpeningTrialBalance original_OpeningTrialBalance, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "OpeningTrialBalance";
            args.View = dataView;
            args.Values = CreateFieldValues(theOpeningTrialBalance, original_OpeningTrialBalance);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("OpeningTrialBalance", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theOpeningTrialBalance);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.OpeningTrialBalance theOpeningTrialBalance, MyCompany.Data.Objects.OpeningTrialBalance original_OpeningTrialBalance)
        {
            return ExecuteAction(theOpeningTrialBalance, original_OpeningTrialBalance, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.OpeningTrialBalance theOpeningTrialBalance)
        {
            return Update(theOpeningTrialBalance, SelectSingle(theOpeningTrialBalance.CoaDetailID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.OpeningTrialBalance theOpeningTrialBalance)
        {
            return ExecuteAction(theOpeningTrialBalance, new OpeningTrialBalance(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.OpeningTrialBalance theOpeningTrialBalance)
        {
            return ExecuteAction(theOpeningTrialBalance, theOpeningTrialBalance, "Select", "Delete", DeleteView);
        }
    }
}
