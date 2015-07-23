using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class Company
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _companyID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _companyName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _address;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _phone;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _fax;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _email;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private byte[] _logo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _companyTypeID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _companyTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _licenseTO;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cashCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _fixedAssetCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _depreciation;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rawMAcc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _finishGAcc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _inventory;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _depCalYesNo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _rawmStk;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _finishStk;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _rCurr;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _rCurrRate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _fCurr;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _fCurrRate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _profitAcc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _dateType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _baseCurrency;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accountBalShow;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _fundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _branchCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _subLedYN;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accBalShow;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _fundCodeYN;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _branchCodeYN;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _fixedAssetYN;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _salesAcct;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _purchaseAcct;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _invtoryVchrAuto;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sDebitor;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sCreditor;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _projectYN;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _godownYN;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _batchYN;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _mgtYN;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _expireYN;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _active;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _license;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _instal;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _copYN;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _vchrNumberUnique;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _vchrNumberByType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _currAsset;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _currLiab;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _saleAcc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _purAcc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _fixedAcc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _loanLiab;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _capAcc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _opnStkAcc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _clsStkAcc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _fabricCatID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _fabricItemID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _fuelAcc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _basOwnerAcc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _helperAcc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _driverAcc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _advanceAcc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _ticketSaleAcc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _ticketAcc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _busRsrvAcc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cntrDepositAcc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _consFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _workinProgressAcc;
        
        public Company()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public int? CompanyID
        {
            get
            {
                return _companyID;
            }
            set
            {
                _companyID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string CompanyName
        {
            get
            {
                return _companyName;
            }
            set
            {
                _companyName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                _phone = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Fax
        {
            get
            {
                return _fax;
            }
            set
            {
                _fax = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public byte[] Logo
        {
            get
            {
                return _logo;
            }
            set
            {
                _logo = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? CompanyTypeID
        {
            get
            {
                return _companyTypeID;
            }
            set
            {
                _companyTypeID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CompanyTypeDescription
        {
            get
            {
                return _companyTypeDescription;
            }
            set
            {
                _companyTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LicenseTO
        {
            get
            {
                return _licenseTO;
            }
            set
            {
                _licenseTO = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CashCode
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
        public string BankCode
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
        public string FixedAssetCode
        {
            get
            {
                return _fixedAssetCode;
            }
            set
            {
                _fixedAssetCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Depreciation
        {
            get
            {
                return _depreciation;
            }
            set
            {
                _depreciation = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RawMAcc
        {
            get
            {
                return _rawMAcc;
            }
            set
            {
                _rawMAcc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string FinishGAcc
        {
            get
            {
                return _finishGAcc;
            }
            set
            {
                _finishGAcc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Inventory
        {
            get
            {
                return _inventory;
            }
            set
            {
                _inventory = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string DepCalYesNo
        {
            get
            {
                return _depCalYesNo;
            }
            set
            {
                _depCalYesNo = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public decimal? RawmStk
        {
            get
            {
                return _rawmStk;
            }
            set
            {
                _rawmStk = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public decimal? FinishStk
        {
            get
            {
                return _finishStk;
            }
            set
            {
                _finishStk = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? RCurr
        {
            get
            {
                return _rCurr;
            }
            set
            {
                _rCurr = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public decimal? RCurrRate
        {
            get
            {
                return _rCurrRate;
            }
            set
            {
                _rCurrRate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? FCurr
        {
            get
            {
                return _fCurr;
            }
            set
            {
                _fCurr = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public decimal? FCurrRate
        {
            get
            {
                return _fCurrRate;
            }
            set
            {
                _fCurrRate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ProfitAcc
        {
            get
            {
                return _profitAcc;
            }
            set
            {
                _profitAcc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string DateType
        {
            get
            {
                return _dateType;
            }
            set
            {
                _dateType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? BaseCurrency
        {
            get
            {
                return _baseCurrency;
            }
            set
            {
                _baseCurrency = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? AccountBalShow
        {
            get
            {
                return _accountBalShow;
            }
            set
            {
                _accountBalShow = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string FundCode
        {
            get
            {
                return _fundCode;
            }
            set
            {
                _fundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BranchCode
        {
            get
            {
                return _branchCode;
            }
            set
            {
                _branchCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string SubLedYN
        {
            get
            {
                return _subLedYN;
            }
            set
            {
                _subLedYN = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string AccBalShow
        {
            get
            {
                return _accBalShow;
            }
            set
            {
                _accBalShow = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string FundCodeYN
        {
            get
            {
                return _fundCodeYN;
            }
            set
            {
                _fundCodeYN = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string BranchCodeYN
        {
            get
            {
                return _branchCodeYN;
            }
            set
            {
                _branchCodeYN = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string FixedAssetYN
        {
            get
            {
                return _fixedAssetYN;
            }
            set
            {
                _fixedAssetYN = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SalesAcct
        {
            get
            {
                return _salesAcct;
            }
            set
            {
                _salesAcct = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PurchaseAcct
        {
            get
            {
                return _purchaseAcct;
            }
            set
            {
                _purchaseAcct = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string InvtoryVchrAuto
        {
            get
            {
                return _invtoryVchrAuto;
            }
            set
            {
                _invtoryVchrAuto = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SDebitor
        {
            get
            {
                return _sDebitor;
            }
            set
            {
                _sDebitor = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SCreditor
        {
            get
            {
                return _sCreditor;
            }
            set
            {
                _sCreditor = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ProjectYN
        {
            get
            {
                return _projectYN;
            }
            set
            {
                _projectYN = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string GodownYN
        {
            get
            {
                return _godownYN;
            }
            set
            {
                _godownYN = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BatchYN
        {
            get
            {
                return _batchYN;
            }
            set
            {
                _batchYN = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string MgtYN
        {
            get
            {
                return _mgtYN;
            }
            set
            {
                _mgtYN = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ExpireYN
        {
            get
            {
                return _expireYN;
            }
            set
            {
                _expireYN = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Active
        {
            get
            {
                return _active;
            }
            set
            {
                _active = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string License
        {
            get
            {
                return _license;
            }
            set
            {
                _license = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? Instal
        {
            get
            {
                return _instal;
            }
            set
            {
                _instal = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CopYN
        {
            get
            {
                return _copYN;
            }
            set
            {
                _copYN = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string VchrNumberUnique
        {
            get
            {
                return _vchrNumberUnique;
            }
            set
            {
                _vchrNumberUnique = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string VchrNumberByType
        {
            get
            {
                return _vchrNumberByType;
            }
            set
            {
                _vchrNumberByType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CurrAsset
        {
            get
            {
                return _currAsset;
            }
            set
            {
                _currAsset = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CurrLiab
        {
            get
            {
                return _currLiab;
            }
            set
            {
                _currLiab = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SaleAcc
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
        public string PurAcc
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
        public string FixedAcc
        {
            get
            {
                return _fixedAcc;
            }
            set
            {
                _fixedAcc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LoanLiab
        {
            get
            {
                return _loanLiab;
            }
            set
            {
                _loanLiab = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CapAcc
        {
            get
            {
                return _capAcc;
            }
            set
            {
                _capAcc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OpnStkAcc
        {
            get
            {
                return _opnStkAcc;
            }
            set
            {
                _opnStkAcc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ClsStkAcc
        {
            get
            {
                return _clsStkAcc;
            }
            set
            {
                _clsStkAcc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string FabricCatID
        {
            get
            {
                return _fabricCatID;
            }
            set
            {
                _fabricCatID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string FabricItemID
        {
            get
            {
                return _fabricItemID;
            }
            set
            {
                _fabricItemID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string FuelAcc
        {
            get
            {
                return _fuelAcc;
            }
            set
            {
                _fuelAcc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BasOwnerAcc
        {
            get
            {
                return _basOwnerAcc;
            }
            set
            {
                _basOwnerAcc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HelperAcc
        {
            get
            {
                return _helperAcc;
            }
            set
            {
                _helperAcc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string DriverAcc
        {
            get
            {
                return _driverAcc;
            }
            set
            {
                _driverAcc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AdvanceAcc
        {
            get
            {
                return _advanceAcc;
            }
            set
            {
                _advanceAcc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string TicketSaleAcc
        {
            get
            {
                return _ticketSaleAcc;
            }
            set
            {
                _ticketSaleAcc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string TicketAcc
        {
            get
            {
                return _ticketAcc;
            }
            set
            {
                _ticketAcc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BusRsrvAcc
        {
            get
            {
                return _busRsrvAcc;
            }
            set
            {
                _busRsrvAcc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CntrDepositAcc
        {
            get
            {
                return _cntrDepositAcc;
            }
            set
            {
                _cntrDepositAcc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ConsFundCode
        {
            get
            {
                return _consFundCode;
            }
            set
            {
                _consFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string WorkinProgressAcc
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
        
        public static List<MyCompany.Data.Objects.Company> Select(
                    int? companyID, 
                    string companyName, 
                    string address, 
                    string phone, 
                    string fax, 
                    string email, 
                    int? companyTypeID, 
                    string companyTypeDescription, 
                    string licenseTO, 
                    string cashCode, 
                    string bankCode, 
                    string fixedAssetCode, 
                    string depreciation, 
                    string rawMAcc, 
                    string finishGAcc, 
                    string inventory, 
                    string depCalYesNo, 
                    decimal? rawmStk, 
                    decimal? finishStk, 
                    int? rCurr, 
                    decimal? rCurrRate, 
                    int? fCurr, 
                    decimal? fCurrRate, 
                    string profitAcc, 
                    string dateType, 
                    int? baseCurrency, 
                    int? accountBalShow, 
                    string fundCode, 
                    string branchCode, 
                    string subLedYN, 
                    string accBalShow, 
                    string fundCodeYN, 
                    string branchCodeYN, 
                    string fixedAssetYN, 
                    string salesAcct, 
                    string purchaseAcct, 
                    string invtoryVchrAuto, 
                    string sDebitor, 
                    string sCreditor, 
                    string projectYN, 
                    string godownYN, 
                    string batchYN, 
                    string mgtYN, 
                    string expireYN, 
                    string active, 
                    string license, 
                    DateTime? instal, 
                    string copYN, 
                    string vchrNumberUnique, 
                    string vchrNumberByType, 
                    string currAsset, 
                    string currLiab, 
                    string saleAcc, 
                    string purAcc, 
                    string fixedAcc, 
                    string loanLiab, 
                    string capAcc, 
                    string opnStkAcc, 
                    string clsStkAcc, 
                    string fabricCatID, 
                    string fabricItemID, 
                    string fuelAcc, 
                    string basOwnerAcc, 
                    string helperAcc, 
                    string driverAcc, 
                    string advanceAcc, 
                    string ticketSaleAcc, 
                    string ticketAcc, 
                    string busRsrvAcc, 
                    string cntrDepositAcc, 
                    string consFundCode, 
                    string workinProgressAcc)
        {
            return new CompanyFactory().Select(companyID, companyName, address, phone, fax, email, companyTypeID, companyTypeDescription, licenseTO, cashCode, bankCode, fixedAssetCode, depreciation, rawMAcc, finishGAcc, inventory, depCalYesNo, rawmStk, finishStk, rCurr, rCurrRate, fCurr, fCurrRate, profitAcc, dateType, baseCurrency, accountBalShow, fundCode, branchCode, subLedYN, accBalShow, fundCodeYN, branchCodeYN, fixedAssetYN, salesAcct, purchaseAcct, invtoryVchrAuto, sDebitor, sCreditor, projectYN, godownYN, batchYN, mgtYN, expireYN, active, license, instal, copYN, vchrNumberUnique, vchrNumberByType, currAsset, currLiab, saleAcc, purAcc, fixedAcc, loanLiab, capAcc, opnStkAcc, clsStkAcc, fabricCatID, fabricItemID, fuelAcc, basOwnerAcc, helperAcc, driverAcc, advanceAcc, ticketSaleAcc, ticketAcc, busRsrvAcc, cntrDepositAcc, consFundCode, workinProgressAcc);
        }
        
        public static List<MyCompany.Data.Objects.Company> Select(MyCompany.Data.Objects.Company qbe)
        {
            return new CompanyFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.Company> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new CompanyFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.Company> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new CompanyFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.Company> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new CompanyFactory().Select(filter, sort, CompanyFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.Company> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new CompanyFactory().Select(filter, sort, CompanyFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.Company> Select(string filter, BusinessObjectParameters parameters)
        {
            return new CompanyFactory().Select(filter, null, CompanyFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.Company> Select(string filter, params FieldValue[] parameters)
        {
            return new CompanyFactory().Select(filter, null, CompanyFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.Company SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new CompanyFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.Company SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new CompanyFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.Company SelectSingle(int? companyID)
        {
            return new CompanyFactory().SelectSingle(companyID);
        }
        
        public int Insert()
        {
            return new CompanyFactory().Insert(this);
        }
        
        public int Update()
        {
            return new CompanyFactory().Update(this);
        }
        
        public int Delete()
        {
            return new CompanyFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("CompanyID: {0}", this.CompanyID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class CompanyFactory
    {
        
        public CompanyFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Company");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Company");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Company");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Company");
            }
        }
        
        public static CompanyFactory Create()
        {
            return new CompanyFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    int? companyID, 
                    string companyName, 
                    string address, 
                    string phone, 
                    string fax, 
                    string email, 
                    int? companyTypeID, 
                    string companyTypeDescription, 
                    string licenseTO, 
                    string cashCode, 
                    string bankCode, 
                    string fixedAssetCode, 
                    string depreciation, 
                    string rawMAcc, 
                    string finishGAcc, 
                    string inventory, 
                    string depCalYesNo, 
                    decimal? rawmStk, 
                    decimal? finishStk, 
                    int? rCurr, 
                    decimal? rCurrRate, 
                    int? fCurr, 
                    decimal? fCurrRate, 
                    string profitAcc, 
                    string dateType, 
                    int? baseCurrency, 
                    int? accountBalShow, 
                    string fundCode, 
                    string branchCode, 
                    string subLedYN, 
                    string accBalShow, 
                    string fundCodeYN, 
                    string branchCodeYN, 
                    string fixedAssetYN, 
                    string salesAcct, 
                    string purchaseAcct, 
                    string invtoryVchrAuto, 
                    string sDebitor, 
                    string sCreditor, 
                    string projectYN, 
                    string godownYN, 
                    string batchYN, 
                    string mgtYN, 
                    string expireYN, 
                    string active, 
                    string license, 
                    DateTime? instal, 
                    string copYN, 
                    string vchrNumberUnique, 
                    string vchrNumberByType, 
                    string currAsset, 
                    string currLiab, 
                    string saleAcc, 
                    string purAcc, 
                    string fixedAcc, 
                    string loanLiab, 
                    string capAcc, 
                    string opnStkAcc, 
                    string clsStkAcc, 
                    string fabricCatID, 
                    string fabricItemID, 
                    string fuelAcc, 
                    string basOwnerAcc, 
                    string helperAcc, 
                    string driverAcc, 
                    string advanceAcc, 
                    string ticketSaleAcc, 
                    string ticketAcc, 
                    string busRsrvAcc, 
                    string cntrDepositAcc, 
                    string consFundCode, 
                    string workinProgressAcc, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (companyID.HasValue)
            	filter.Add(("CompanyID:=" + companyID.Value.ToString()));
            if (!(String.IsNullOrEmpty(companyName)))
            	filter.Add(("CompanyName:*" + companyName));
            if (!(String.IsNullOrEmpty(address)))
            	filter.Add(("Address:*" + address));
            if (!(String.IsNullOrEmpty(phone)))
            	filter.Add(("Phone:*" + phone));
            if (!(String.IsNullOrEmpty(fax)))
            	filter.Add(("Fax:*" + fax));
            if (!(String.IsNullOrEmpty(email)))
            	filter.Add(("Email:*" + email));
            if (companyTypeID.HasValue)
            	filter.Add(("CompanyTypeID:=" + companyTypeID.Value.ToString()));
            if (!(String.IsNullOrEmpty(companyTypeDescription)))
            	filter.Add(("CompanyTypeDescription:*" + companyTypeDescription));
            if (!(String.IsNullOrEmpty(licenseTO)))
            	filter.Add(("LicenseTO:*" + licenseTO));
            if (!(String.IsNullOrEmpty(cashCode)))
            	filter.Add(("CashCode:*" + cashCode));
            if (!(String.IsNullOrEmpty(bankCode)))
            	filter.Add(("BankCode:*" + bankCode));
            if (!(String.IsNullOrEmpty(fixedAssetCode)))
            	filter.Add(("FixedAssetCode:*" + fixedAssetCode));
            if (!(String.IsNullOrEmpty(depreciation)))
            	filter.Add(("Depreciation:*" + depreciation));
            if (!(String.IsNullOrEmpty(rawMAcc)))
            	filter.Add(("RawMAcc:*" + rawMAcc));
            if (!(String.IsNullOrEmpty(finishGAcc)))
            	filter.Add(("FinishGAcc:*" + finishGAcc));
            if (!(String.IsNullOrEmpty(inventory)))
            	filter.Add(("Inventory:*" + inventory));
            if (!(String.IsNullOrEmpty(depCalYesNo)))
            	filter.Add(("DepCalYesNo:*" + depCalYesNo));
            if (rawmStk.HasValue)
            	filter.Add(("RawmStk:=" + rawmStk.Value.ToString()));
            if (finishStk.HasValue)
            	filter.Add(("FinishStk:=" + finishStk.Value.ToString()));
            if (rCurr.HasValue)
            	filter.Add(("RCurr:=" + rCurr.Value.ToString()));
            if (rCurrRate.HasValue)
            	filter.Add(("RCurrRate:=" + rCurrRate.Value.ToString()));
            if (fCurr.HasValue)
            	filter.Add(("FCurr:=" + fCurr.Value.ToString()));
            if (fCurrRate.HasValue)
            	filter.Add(("FCurrRate:=" + fCurrRate.Value.ToString()));
            if (!(String.IsNullOrEmpty(profitAcc)))
            	filter.Add(("ProfitAcc:*" + profitAcc));
            if (!(String.IsNullOrEmpty(dateType)))
            	filter.Add(("DateType:*" + dateType));
            if (baseCurrency.HasValue)
            	filter.Add(("BaseCurrency:=" + baseCurrency.Value.ToString()));
            if (accountBalShow.HasValue)
            	filter.Add(("AccountBalShow:=" + accountBalShow.Value.ToString()));
            if (!(String.IsNullOrEmpty(fundCode)))
            	filter.Add(("FundCode:*" + fundCode));
            if (!(String.IsNullOrEmpty(branchCode)))
            	filter.Add(("BranchCode:*" + branchCode));
            if (!(String.IsNullOrEmpty(subLedYN)))
            	filter.Add(("SubLedYN:*" + subLedYN));
            if (!(String.IsNullOrEmpty(accBalShow)))
            	filter.Add(("AccBalShow:*" + accBalShow));
            if (!(String.IsNullOrEmpty(fundCodeYN)))
            	filter.Add(("FundCodeYN:*" + fundCodeYN));
            if (!(String.IsNullOrEmpty(branchCodeYN)))
            	filter.Add(("BranchCodeYN:*" + branchCodeYN));
            if (!(String.IsNullOrEmpty(fixedAssetYN)))
            	filter.Add(("FixedAssetYN:*" + fixedAssetYN));
            if (!(String.IsNullOrEmpty(salesAcct)))
            	filter.Add(("SalesAcct:*" + salesAcct));
            if (!(String.IsNullOrEmpty(purchaseAcct)))
            	filter.Add(("PurchaseAcct:*" + purchaseAcct));
            if (!(String.IsNullOrEmpty(invtoryVchrAuto)))
            	filter.Add(("InvtoryVchrAuto:*" + invtoryVchrAuto));
            if (!(String.IsNullOrEmpty(sDebitor)))
            	filter.Add(("SDebitor:*" + sDebitor));
            if (!(String.IsNullOrEmpty(sCreditor)))
            	filter.Add(("SCreditor:*" + sCreditor));
            if (!(String.IsNullOrEmpty(projectYN)))
            	filter.Add(("ProjectYN:*" + projectYN));
            if (!(String.IsNullOrEmpty(godownYN)))
            	filter.Add(("GodownYN:*" + godownYN));
            if (!(String.IsNullOrEmpty(batchYN)))
            	filter.Add(("BatchYN:*" + batchYN));
            if (!(String.IsNullOrEmpty(mgtYN)))
            	filter.Add(("MgtYN:*" + mgtYN));
            if (!(String.IsNullOrEmpty(expireYN)))
            	filter.Add(("ExpireYN:*" + expireYN));
            if (!(String.IsNullOrEmpty(active)))
            	filter.Add(("Active:*" + active));
            if (!(String.IsNullOrEmpty(license)))
            	filter.Add(("License:*" + license));
            if (instal.HasValue)
            	filter.Add(("Instal:=" + instal.Value.ToString()));
            if (!(String.IsNullOrEmpty(copYN)))
            	filter.Add(("CopYN:*" + copYN));
            if (!(String.IsNullOrEmpty(vchrNumberUnique)))
            	filter.Add(("VchrNumberUnique:*" + vchrNumberUnique));
            if (!(String.IsNullOrEmpty(vchrNumberByType)))
            	filter.Add(("VchrNumberByType:*" + vchrNumberByType));
            if (!(String.IsNullOrEmpty(currAsset)))
            	filter.Add(("CurrAsset:*" + currAsset));
            if (!(String.IsNullOrEmpty(currLiab)))
            	filter.Add(("CurrLiab:*" + currLiab));
            if (!(String.IsNullOrEmpty(saleAcc)))
            	filter.Add(("SaleAcc:*" + saleAcc));
            if (!(String.IsNullOrEmpty(purAcc)))
            	filter.Add(("PurAcc:*" + purAcc));
            if (!(String.IsNullOrEmpty(fixedAcc)))
            	filter.Add(("FixedAcc:*" + fixedAcc));
            if (!(String.IsNullOrEmpty(loanLiab)))
            	filter.Add(("LoanLiab:*" + loanLiab));
            if (!(String.IsNullOrEmpty(capAcc)))
            	filter.Add(("CapAcc:*" + capAcc));
            if (!(String.IsNullOrEmpty(opnStkAcc)))
            	filter.Add(("OpnStkAcc:*" + opnStkAcc));
            if (!(String.IsNullOrEmpty(clsStkAcc)))
            	filter.Add(("ClsStkAcc:*" + clsStkAcc));
            if (!(String.IsNullOrEmpty(fabricCatID)))
            	filter.Add(("FabricCatID:*" + fabricCatID));
            if (!(String.IsNullOrEmpty(fabricItemID)))
            	filter.Add(("FabricItemID:*" + fabricItemID));
            if (!(String.IsNullOrEmpty(fuelAcc)))
            	filter.Add(("FuelAcc:*" + fuelAcc));
            if (!(String.IsNullOrEmpty(basOwnerAcc)))
            	filter.Add(("BasOwnerAcc:*" + basOwnerAcc));
            if (!(String.IsNullOrEmpty(helperAcc)))
            	filter.Add(("HelperAcc:*" + helperAcc));
            if (!(String.IsNullOrEmpty(driverAcc)))
            	filter.Add(("DriverAcc:*" + driverAcc));
            if (!(String.IsNullOrEmpty(advanceAcc)))
            	filter.Add(("AdvanceAcc:*" + advanceAcc));
            if (!(String.IsNullOrEmpty(ticketSaleAcc)))
            	filter.Add(("TicketSaleAcc:*" + ticketSaleAcc));
            if (!(String.IsNullOrEmpty(ticketAcc)))
            	filter.Add(("TicketAcc:*" + ticketAcc));
            if (!(String.IsNullOrEmpty(busRsrvAcc)))
            	filter.Add(("BusRsrvAcc:*" + busRsrvAcc));
            if (!(String.IsNullOrEmpty(cntrDepositAcc)))
            	filter.Add(("CntrDepositAcc:*" + cntrDepositAcc));
            if (!(String.IsNullOrEmpty(consFundCode)))
            	filter.Add(("ConsFundCode:*" + consFundCode));
            if (!(String.IsNullOrEmpty(workinProgressAcc)))
            	filter.Add(("WorkinProgressAcc:*" + workinProgressAcc));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.Company> Select(
                    int? companyID, 
                    string companyName, 
                    string address, 
                    string phone, 
                    string fax, 
                    string email, 
                    int? companyTypeID, 
                    string companyTypeDescription, 
                    string licenseTO, 
                    string cashCode, 
                    string bankCode, 
                    string fixedAssetCode, 
                    string depreciation, 
                    string rawMAcc, 
                    string finishGAcc, 
                    string inventory, 
                    string depCalYesNo, 
                    decimal? rawmStk, 
                    decimal? finishStk, 
                    int? rCurr, 
                    decimal? rCurrRate, 
                    int? fCurr, 
                    decimal? fCurrRate, 
                    string profitAcc, 
                    string dateType, 
                    int? baseCurrency, 
                    int? accountBalShow, 
                    string fundCode, 
                    string branchCode, 
                    string subLedYN, 
                    string accBalShow, 
                    string fundCodeYN, 
                    string branchCodeYN, 
                    string fixedAssetYN, 
                    string salesAcct, 
                    string purchaseAcct, 
                    string invtoryVchrAuto, 
                    string sDebitor, 
                    string sCreditor, 
                    string projectYN, 
                    string godownYN, 
                    string batchYN, 
                    string mgtYN, 
                    string expireYN, 
                    string active, 
                    string license, 
                    DateTime? instal, 
                    string copYN, 
                    string vchrNumberUnique, 
                    string vchrNumberByType, 
                    string currAsset, 
                    string currLiab, 
                    string saleAcc, 
                    string purAcc, 
                    string fixedAcc, 
                    string loanLiab, 
                    string capAcc, 
                    string opnStkAcc, 
                    string clsStkAcc, 
                    string fabricCatID, 
                    string fabricItemID, 
                    string fuelAcc, 
                    string basOwnerAcc, 
                    string helperAcc, 
                    string driverAcc, 
                    string advanceAcc, 
                    string ticketSaleAcc, 
                    string ticketAcc, 
                    string busRsrvAcc, 
                    string cntrDepositAcc, 
                    string consFundCode, 
                    string workinProgressAcc, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(companyID, companyName, address, phone, fax, email, companyTypeID, companyTypeDescription, licenseTO, cashCode, bankCode, fixedAssetCode, depreciation, rawMAcc, finishGAcc, inventory, depCalYesNo, rawmStk, finishStk, rCurr, rCurrRate, fCurr, fCurrRate, profitAcc, dateType, baseCurrency, accountBalShow, fundCode, branchCode, subLedYN, accBalShow, fundCodeYN, branchCodeYN, fixedAssetYN, salesAcct, purchaseAcct, invtoryVchrAuto, sDebitor, sCreditor, projectYN, godownYN, batchYN, mgtYN, expireYN, active, license, instal, copYN, vchrNumberUnique, vchrNumberByType, currAsset, currLiab, saleAcc, purAcc, fixedAcc, loanLiab, capAcc, opnStkAcc, clsStkAcc, fabricCatID, fabricItemID, fuelAcc, basOwnerAcc, helperAcc, driverAcc, advanceAcc, ticketSaleAcc, ticketAcc, busRsrvAcc, cntrDepositAcc, consFundCode, workinProgressAcc, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Company", dataView, request);
            return page.ToList<MyCompany.Data.Objects.Company>();
        }
        
        public List<MyCompany.Data.Objects.Company> Select(MyCompany.Data.Objects.Company qbe)
        {
            return Select(qbe.CompanyID, qbe.CompanyName, qbe.Address, qbe.Phone, qbe.Fax, qbe.Email, qbe.CompanyTypeID, qbe.CompanyTypeDescription, qbe.LicenseTO, qbe.CashCode, qbe.BankCode, qbe.FixedAssetCode, qbe.Depreciation, qbe.RawMAcc, qbe.FinishGAcc, qbe.Inventory, qbe.DepCalYesNo, qbe.RawmStk, qbe.FinishStk, qbe.RCurr, qbe.RCurrRate, qbe.FCurr, qbe.FCurrRate, qbe.ProfitAcc, qbe.DateType, qbe.BaseCurrency, qbe.AccountBalShow, qbe.FundCode, qbe.BranchCode, qbe.SubLedYN, qbe.AccBalShow, qbe.FundCodeYN, qbe.BranchCodeYN, qbe.FixedAssetYN, qbe.SalesAcct, qbe.PurchaseAcct, qbe.InvtoryVchrAuto, qbe.SDebitor, qbe.SCreditor, qbe.ProjectYN, qbe.GodownYN, qbe.BatchYN, qbe.MgtYN, qbe.ExpireYN, qbe.Active, qbe.License, qbe.Instal, qbe.CopYN, qbe.VchrNumberUnique, qbe.VchrNumberByType, qbe.CurrAsset, qbe.CurrLiab, qbe.SaleAcc, qbe.PurAcc, qbe.FixedAcc, qbe.LoanLiab, qbe.CapAcc, qbe.OpnStkAcc, qbe.ClsStkAcc, qbe.FabricCatID, qbe.FabricItemID, qbe.FuelAcc, qbe.BasOwnerAcc, qbe.HelperAcc, qbe.DriverAcc, qbe.AdvanceAcc, qbe.TicketSaleAcc, qbe.TicketAcc, qbe.BusRsrvAcc, qbe.CntrDepositAcc, qbe.ConsFundCode, qbe.WorkinProgressAcc);
        }
        
        public int SelectCount(
                    int? companyID, 
                    string companyName, 
                    string address, 
                    string phone, 
                    string fax, 
                    string email, 
                    int? companyTypeID, 
                    string companyTypeDescription, 
                    string licenseTO, 
                    string cashCode, 
                    string bankCode, 
                    string fixedAssetCode, 
                    string depreciation, 
                    string rawMAcc, 
                    string finishGAcc, 
                    string inventory, 
                    string depCalYesNo, 
                    decimal? rawmStk, 
                    decimal? finishStk, 
                    int? rCurr, 
                    decimal? rCurrRate, 
                    int? fCurr, 
                    decimal? fCurrRate, 
                    string profitAcc, 
                    string dateType, 
                    int? baseCurrency, 
                    int? accountBalShow, 
                    string fundCode, 
                    string branchCode, 
                    string subLedYN, 
                    string accBalShow, 
                    string fundCodeYN, 
                    string branchCodeYN, 
                    string fixedAssetYN, 
                    string salesAcct, 
                    string purchaseAcct, 
                    string invtoryVchrAuto, 
                    string sDebitor, 
                    string sCreditor, 
                    string projectYN, 
                    string godownYN, 
                    string batchYN, 
                    string mgtYN, 
                    string expireYN, 
                    string active, 
                    string license, 
                    DateTime? instal, 
                    string copYN, 
                    string vchrNumberUnique, 
                    string vchrNumberByType, 
                    string currAsset, 
                    string currLiab, 
                    string saleAcc, 
                    string purAcc, 
                    string fixedAcc, 
                    string loanLiab, 
                    string capAcc, 
                    string opnStkAcc, 
                    string clsStkAcc, 
                    string fabricCatID, 
                    string fabricItemID, 
                    string fuelAcc, 
                    string basOwnerAcc, 
                    string helperAcc, 
                    string driverAcc, 
                    string advanceAcc, 
                    string ticketSaleAcc, 
                    string ticketAcc, 
                    string busRsrvAcc, 
                    string cntrDepositAcc, 
                    string consFundCode, 
                    string workinProgressAcc, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(companyID, companyName, address, phone, fax, email, companyTypeID, companyTypeDescription, licenseTO, cashCode, bankCode, fixedAssetCode, depreciation, rawMAcc, finishGAcc, inventory, depCalYesNo, rawmStk, finishStk, rCurr, rCurrRate, fCurr, fCurrRate, profitAcc, dateType, baseCurrency, accountBalShow, fundCode, branchCode, subLedYN, accBalShow, fundCodeYN, branchCodeYN, fixedAssetYN, salesAcct, purchaseAcct, invtoryVchrAuto, sDebitor, sCreditor, projectYN, godownYN, batchYN, mgtYN, expireYN, active, license, instal, copYN, vchrNumberUnique, vchrNumberByType, currAsset, currLiab, saleAcc, purAcc, fixedAcc, loanLiab, capAcc, opnStkAcc, clsStkAcc, fabricCatID, fabricItemID, fuelAcc, basOwnerAcc, helperAcc, driverAcc, advanceAcc, ticketSaleAcc, ticketAcc, busRsrvAcc, cntrDepositAcc, consFundCode, workinProgressAcc, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Company", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.Company> Select(
                    int? companyID, 
                    string companyName, 
                    string address, 
                    string phone, 
                    string fax, 
                    string email, 
                    int? companyTypeID, 
                    string companyTypeDescription, 
                    string licenseTO, 
                    string cashCode, 
                    string bankCode, 
                    string fixedAssetCode, 
                    string depreciation, 
                    string rawMAcc, 
                    string finishGAcc, 
                    string inventory, 
                    string depCalYesNo, 
                    decimal? rawmStk, 
                    decimal? finishStk, 
                    int? rCurr, 
                    decimal? rCurrRate, 
                    int? fCurr, 
                    decimal? fCurrRate, 
                    string profitAcc, 
                    string dateType, 
                    int? baseCurrency, 
                    int? accountBalShow, 
                    string fundCode, 
                    string branchCode, 
                    string subLedYN, 
                    string accBalShow, 
                    string fundCodeYN, 
                    string branchCodeYN, 
                    string fixedAssetYN, 
                    string salesAcct, 
                    string purchaseAcct, 
                    string invtoryVchrAuto, 
                    string sDebitor, 
                    string sCreditor, 
                    string projectYN, 
                    string godownYN, 
                    string batchYN, 
                    string mgtYN, 
                    string expireYN, 
                    string active, 
                    string license, 
                    DateTime? instal, 
                    string copYN, 
                    string vchrNumberUnique, 
                    string vchrNumberByType, 
                    string currAsset, 
                    string currLiab, 
                    string saleAcc, 
                    string purAcc, 
                    string fixedAcc, 
                    string loanLiab, 
                    string capAcc, 
                    string opnStkAcc, 
                    string clsStkAcc, 
                    string fabricCatID, 
                    string fabricItemID, 
                    string fuelAcc, 
                    string basOwnerAcc, 
                    string helperAcc, 
                    string driverAcc, 
                    string advanceAcc, 
                    string ticketSaleAcc, 
                    string ticketAcc, 
                    string busRsrvAcc, 
                    string cntrDepositAcc, 
                    string consFundCode, 
                    string workinProgressAcc)
        {
            return Select(companyID, companyName, address, phone, fax, email, companyTypeID, companyTypeDescription, licenseTO, cashCode, bankCode, fixedAssetCode, depreciation, rawMAcc, finishGAcc, inventory, depCalYesNo, rawmStk, finishStk, rCurr, rCurrRate, fCurr, fCurrRate, profitAcc, dateType, baseCurrency, accountBalShow, fundCode, branchCode, subLedYN, accBalShow, fundCodeYN, branchCodeYN, fixedAssetYN, salesAcct, purchaseAcct, invtoryVchrAuto, sDebitor, sCreditor, projectYN, godownYN, batchYN, mgtYN, expireYN, active, license, instal, copYN, vchrNumberUnique, vchrNumberByType, currAsset, currLiab, saleAcc, purAcc, fixedAcc, loanLiab, capAcc, opnStkAcc, clsStkAcc, fabricCatID, fabricItemID, fuelAcc, basOwnerAcc, helperAcc, driverAcc, advanceAcc, ticketSaleAcc, ticketAcc, busRsrvAcc, cntrDepositAcc, consFundCode, workinProgressAcc, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.Company SelectSingle(int? companyID)
        {
            List<MyCompany.Data.Objects.Company> list = Select(companyID, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.Company> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("Company", dataView, request);
            return page.ToList<MyCompany.Data.Objects.Company>();
        }
        
        public List<MyCompany.Data.Objects.Company> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.Company> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.Company SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.Company> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.Company theCompany, MyCompany.Data.Objects.Company original_Company)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("CompanyID", original_Company.CompanyID, theCompany.CompanyID));
            values.Add(new FieldValue("CompanyName", original_Company.CompanyName, theCompany.CompanyName));
            values.Add(new FieldValue("Address", original_Company.Address, theCompany.Address));
            values.Add(new FieldValue("Phone", original_Company.Phone, theCompany.Phone));
            values.Add(new FieldValue("Fax", original_Company.Fax, theCompany.Fax));
            values.Add(new FieldValue("Email", original_Company.Email, theCompany.Email));
            values.Add(new FieldValue("Logo", original_Company.Logo, theCompany.Logo));
            values.Add(new FieldValue("CompanyTypeID", original_Company.CompanyTypeID, theCompany.CompanyTypeID));
            values.Add(new FieldValue("CompanyTypeDescription", original_Company.CompanyTypeDescription, theCompany.CompanyTypeDescription, true));
            values.Add(new FieldValue("LicenseTO", original_Company.LicenseTO, theCompany.LicenseTO));
            values.Add(new FieldValue("CashCode", original_Company.CashCode, theCompany.CashCode));
            values.Add(new FieldValue("BankCode", original_Company.BankCode, theCompany.BankCode));
            values.Add(new FieldValue("FixedAssetCode", original_Company.FixedAssetCode, theCompany.FixedAssetCode));
            values.Add(new FieldValue("Depreciation", original_Company.Depreciation, theCompany.Depreciation));
            values.Add(new FieldValue("RawMAcc", original_Company.RawMAcc, theCompany.RawMAcc));
            values.Add(new FieldValue("FinishGAcc", original_Company.FinishGAcc, theCompany.FinishGAcc));
            values.Add(new FieldValue("Inventory", original_Company.Inventory, theCompany.Inventory));
            values.Add(new FieldValue("DepCalYesNo", original_Company.DepCalYesNo, theCompany.DepCalYesNo));
            values.Add(new FieldValue("RawmStk", original_Company.RawmStk, theCompany.RawmStk));
            values.Add(new FieldValue("FinishStk", original_Company.FinishStk, theCompany.FinishStk));
            values.Add(new FieldValue("RCurr", original_Company.RCurr, theCompany.RCurr));
            values.Add(new FieldValue("RCurrRate", original_Company.RCurrRate, theCompany.RCurrRate));
            values.Add(new FieldValue("FCurr", original_Company.FCurr, theCompany.FCurr));
            values.Add(new FieldValue("FCurrRate", original_Company.FCurrRate, theCompany.FCurrRate));
            values.Add(new FieldValue("ProfitAcc", original_Company.ProfitAcc, theCompany.ProfitAcc));
            values.Add(new FieldValue("DateType", original_Company.DateType, theCompany.DateType));
            values.Add(new FieldValue("BaseCurrency", original_Company.BaseCurrency, theCompany.BaseCurrency));
            values.Add(new FieldValue("AccountBalShow", original_Company.AccountBalShow, theCompany.AccountBalShow));
            values.Add(new FieldValue("FundCode", original_Company.FundCode, theCompany.FundCode));
            values.Add(new FieldValue("BranchCode", original_Company.BranchCode, theCompany.BranchCode));
            values.Add(new FieldValue("SubLedYN", original_Company.SubLedYN, theCompany.SubLedYN));
            values.Add(new FieldValue("AccBalShow", original_Company.AccBalShow, theCompany.AccBalShow));
            values.Add(new FieldValue("FundCodeYN", original_Company.FundCodeYN, theCompany.FundCodeYN));
            values.Add(new FieldValue("BranchCodeYN", original_Company.BranchCodeYN, theCompany.BranchCodeYN));
            values.Add(new FieldValue("FixedAssetYN", original_Company.FixedAssetYN, theCompany.FixedAssetYN));
            values.Add(new FieldValue("SalesAcct", original_Company.SalesAcct, theCompany.SalesAcct));
            values.Add(new FieldValue("PurchaseAcct", original_Company.PurchaseAcct, theCompany.PurchaseAcct));
            values.Add(new FieldValue("InvtoryVchrAuto", original_Company.InvtoryVchrAuto, theCompany.InvtoryVchrAuto));
            values.Add(new FieldValue("SDebitor", original_Company.SDebitor, theCompany.SDebitor));
            values.Add(new FieldValue("SCreditor", original_Company.SCreditor, theCompany.SCreditor));
            values.Add(new FieldValue("ProjectYN", original_Company.ProjectYN, theCompany.ProjectYN));
            values.Add(new FieldValue("GodownYN", original_Company.GodownYN, theCompany.GodownYN));
            values.Add(new FieldValue("BatchYN", original_Company.BatchYN, theCompany.BatchYN));
            values.Add(new FieldValue("MgtYN", original_Company.MgtYN, theCompany.MgtYN));
            values.Add(new FieldValue("ExpireYN", original_Company.ExpireYN, theCompany.ExpireYN));
            values.Add(new FieldValue("Active", original_Company.Active, theCompany.Active));
            values.Add(new FieldValue("License", original_Company.License, theCompany.License));
            values.Add(new FieldValue("Instal", original_Company.Instal, theCompany.Instal));
            values.Add(new FieldValue("CopYN", original_Company.CopYN, theCompany.CopYN));
            values.Add(new FieldValue("VchrNumberUnique", original_Company.VchrNumberUnique, theCompany.VchrNumberUnique));
            values.Add(new FieldValue("VchrNumberByType", original_Company.VchrNumberByType, theCompany.VchrNumberByType));
            values.Add(new FieldValue("CurrAsset", original_Company.CurrAsset, theCompany.CurrAsset));
            values.Add(new FieldValue("CurrLiab", original_Company.CurrLiab, theCompany.CurrLiab));
            values.Add(new FieldValue("SaleAcc", original_Company.SaleAcc, theCompany.SaleAcc));
            values.Add(new FieldValue("PurAcc", original_Company.PurAcc, theCompany.PurAcc));
            values.Add(new FieldValue("FixedAcc", original_Company.FixedAcc, theCompany.FixedAcc));
            values.Add(new FieldValue("LoanLiab", original_Company.LoanLiab, theCompany.LoanLiab));
            values.Add(new FieldValue("CapAcc", original_Company.CapAcc, theCompany.CapAcc));
            values.Add(new FieldValue("OpnStkAcc", original_Company.OpnStkAcc, theCompany.OpnStkAcc));
            values.Add(new FieldValue("ClsStkAcc", original_Company.ClsStkAcc, theCompany.ClsStkAcc));
            values.Add(new FieldValue("FabricCatID", original_Company.FabricCatID, theCompany.FabricCatID));
            values.Add(new FieldValue("FabricItemID", original_Company.FabricItemID, theCompany.FabricItemID));
            values.Add(new FieldValue("FuelAcc", original_Company.FuelAcc, theCompany.FuelAcc));
            values.Add(new FieldValue("BasOwnerAcc", original_Company.BasOwnerAcc, theCompany.BasOwnerAcc));
            values.Add(new FieldValue("HelperAcc", original_Company.HelperAcc, theCompany.HelperAcc));
            values.Add(new FieldValue("DriverAcc", original_Company.DriverAcc, theCompany.DriverAcc));
            values.Add(new FieldValue("AdvanceAcc", original_Company.AdvanceAcc, theCompany.AdvanceAcc));
            values.Add(new FieldValue("TicketSaleAcc", original_Company.TicketSaleAcc, theCompany.TicketSaleAcc));
            values.Add(new FieldValue("TicketAcc", original_Company.TicketAcc, theCompany.TicketAcc));
            values.Add(new FieldValue("BusRsrvAcc", original_Company.BusRsrvAcc, theCompany.BusRsrvAcc));
            values.Add(new FieldValue("CntrDepositAcc", original_Company.CntrDepositAcc, theCompany.CntrDepositAcc));
            values.Add(new FieldValue("ConsFundCode", original_Company.ConsFundCode, theCompany.ConsFundCode));
            values.Add(new FieldValue("WorkinProgressAcc", original_Company.WorkinProgressAcc, theCompany.WorkinProgressAcc));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.Company theCompany, MyCompany.Data.Objects.Company original_Company, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "Company";
            args.View = dataView;
            args.Values = CreateFieldValues(theCompany, original_Company);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("Company", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theCompany);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.Company theCompany, MyCompany.Data.Objects.Company original_Company)
        {
            return ExecuteAction(theCompany, original_Company, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.Company theCompany)
        {
            return Update(theCompany, SelectSingle(theCompany.CompanyID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.Company theCompany)
        {
            return ExecuteAction(theCompany, new Company(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.Company theCompany)
        {
            return ExecuteAction(theCompany, theCompany, "Select", "Delete", DeleteView);
        }
    }
}
