using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class PDCIssue
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _pDCRID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _pDCType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _pDCNO;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _pDCPreFix;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _pDCDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _address;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _payCatID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _payCatCategory;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _modeofReceiptID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modeofReceiptDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _chequeNo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _chequeLeafNumber;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _chequeChequeBookChequeBookNo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _chequeChequeBookAccFundAccFundName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _chequeChequeBookCoaDetailAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _branchName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _amount;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isSameAmount;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _noOfPdc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _gname;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _gFathersname;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _gAddress;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _otherRemarks;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _displayAction;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accFundID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accFundAccFundName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _payeeCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _payeeAccSubName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _payeeAccSubTypeAccSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _headOfExpense;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headOfExpenseAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headOfExpenseAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headOfExpenseAccCurrencyAccCurrencyName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headOfExpenseAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headOfExpenseAccDestCompanyTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headOfExpenseAccFundAccFundName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headOfExpenseAccSubTypeAccSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headOfExpenseAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headOfExpenseCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headOfExpenseCoaControlAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headOfExpenseCoaControlAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headOfExpenseCoaControlAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headOfExpenseCoaControlCompTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headOfExpenseCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headOfExpenseCoaMainAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headOfExpenseCoaMainAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headOfExpenseCoaMainAccFundAccFundName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headOfExpenseCoaMainAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headOfExpenseCoaMainCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headOfExpenseCoaSubAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headOfExpenseCoaSubAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headOfExpenseCoaSubAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headOfExpenseCoaSubAccFundAccFundName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headOfExpenseCoaSubAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headOfExpenseCoaSubCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headOfExpenseCoaSubCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _bankAccountHOA;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankAccountHOAAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankAccountHOAAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankAccountHOAAccCurrencyAccCurrencyName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankAccountHOAAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankAccountHOAAccDestCompanyTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankAccountHOAAccFundAccFundName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankAccountHOAAccSubTypeAccSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankAccountHOAAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankAccountHOACoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankAccountHOACoaControlAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankAccountHOACoaControlAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankAccountHOACoaControlAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankAccountHOACoaControlCompTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankAccountHOACoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankAccountHOACoaMainAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankAccountHOACoaMainAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankAccountHOACoaMainAccFundAccFundName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankAccountHOACoaMainAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankAccountHOACoaMainCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankAccountHOACoaSubAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankAccountHOACoaSubAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankAccountHOACoaSubAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankAccountHOACoaSubAccFundAccFundName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankAccountHOACoaSubAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankAccountHOACoaSubCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankAccountHOACoaSubCoaMainAccName;
        
        public PDCIssue()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? PDCRID
        {
            get
            {
                return _pDCRID;
            }
            set
            {
                _pDCRID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public bool? PDCType
        {
            get
            {
                return _pDCType;
            }
            set
            {
                _pDCType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PDCNO
        {
            get
            {
                return _pDCNO;
            }
            set
            {
                _pDCNO = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PDCPreFix
        {
            get
            {
                return _pDCPreFix;
            }
            set
            {
                _pDCPreFix = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? PDCDate
        {
            get
            {
                return _pDCDate;
            }
            set
            {
                _pDCDate = value;
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
        public int? PayCatID
        {
            get
            {
                return _payCatID;
            }
            set
            {
                _payCatID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PayCatCategory
        {
            get
            {
                return _payCatCategory;
            }
            set
            {
                _payCatCategory = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? ModeofReceiptID
        {
            get
            {
                return _modeofReceiptID;
            }
            set
            {
                _modeofReceiptID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ModeofReceiptDescription
        {
            get
            {
                return _modeofReceiptDescription;
            }
            set
            {
                _modeofReceiptDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? ChequeNo
        {
            get
            {
                return _chequeNo;
            }
            set
            {
                _chequeNo = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? ChequeLeafNumber
        {
            get
            {
                return _chequeLeafNumber;
            }
            set
            {
                _chequeLeafNumber = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ChequeChequeBookChequeBookNo
        {
            get
            {
                return _chequeChequeBookChequeBookNo;
            }
            set
            {
                _chequeChequeBookChequeBookNo = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ChequeChequeBookAccFundAccFundName
        {
            get
            {
                return _chequeChequeBookAccFundAccFundName;
            }
            set
            {
                _chequeChequeBookAccFundAccFundName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ChequeChequeBookCoaDetailAccName
        {
            get
            {
                return _chequeChequeBookCoaDetailAccName;
            }
            set
            {
                _chequeChequeBookCoaDetailAccName = value;
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
        public decimal? Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public bool? IsSameAmount
        {
            get
            {
                return _isSameAmount;
            }
            set
            {
                _isSameAmount = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NoOfPdc
        {
            get
            {
                return _noOfPdc;
            }
            set
            {
                _noOfPdc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Gname
        {
            get
            {
                return _gname;
            }
            set
            {
                _gname = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string GFathersname
        {
            get
            {
                return _gFathersname;
            }
            set
            {
                _gFathersname = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string GAddress
        {
            get
            {
                return _gAddress;
            }
            set
            {
                _gAddress = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OtherRemarks
        {
            get
            {
                return _otherRemarks;
            }
            set
            {
                _otherRemarks = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? DisplayAction
        {
            get
            {
                return _displayAction;
            }
            set
            {
                _displayAction = value;
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
        public int? PayeeCode
        {
            get
            {
                return _payeeCode;
            }
            set
            {
                _payeeCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PayeeAccSubName
        {
            get
            {
                return _payeeAccSubName;
            }
            set
            {
                _payeeAccSubName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PayeeAccSubTypeAccSubType
        {
            get
            {
                return _payeeAccSubTypeAccSubType;
            }
            set
            {
                _payeeAccSubTypeAccSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? HeadOfExpense
        {
            get
            {
                return _headOfExpense;
            }
            set
            {
                _headOfExpense = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadOfExpenseAccName
        {
            get
            {
                return _headOfExpenseAccName;
            }
            set
            {
                _headOfExpenseAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadOfExpenseAccBalTypeAccBalType
        {
            get
            {
                return _headOfExpenseAccBalTypeAccBalType;
            }
            set
            {
                _headOfExpenseAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadOfExpenseAccCurrencyAccCurrencyName
        {
            get
            {
                return _headOfExpenseAccCurrencyAccCurrencyName;
            }
            set
            {
                _headOfExpenseAccCurrencyAccCurrencyName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadOfExpenseAccDestAccDest
        {
            get
            {
                return _headOfExpenseAccDestAccDest;
            }
            set
            {
                _headOfExpenseAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadOfExpenseAccDestCompanyTypeDescription
        {
            get
            {
                return _headOfExpenseAccDestCompanyTypeDescription;
            }
            set
            {
                _headOfExpenseAccDestCompanyTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadOfExpenseAccFundAccFundName
        {
            get
            {
                return _headOfExpenseAccFundAccFundName;
            }
            set
            {
                _headOfExpenseAccFundAccFundName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadOfExpenseAccSubTypeAccSubType
        {
            get
            {
                return _headOfExpenseAccSubTypeAccSubType;
            }
            set
            {
                _headOfExpenseAccSubTypeAccSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadOfExpenseAccTypeAccType
        {
            get
            {
                return _headOfExpenseAccTypeAccType;
            }
            set
            {
                _headOfExpenseAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadOfExpenseCoaControlAccName
        {
            get
            {
                return _headOfExpenseCoaControlAccName;
            }
            set
            {
                _headOfExpenseCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadOfExpenseCoaControlAccBalTypeAccBalType
        {
            get
            {
                return _headOfExpenseCoaControlAccBalTypeAccBalType;
            }
            set
            {
                _headOfExpenseCoaControlAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadOfExpenseCoaControlAccDestAccDest
        {
            get
            {
                return _headOfExpenseCoaControlAccDestAccDest;
            }
            set
            {
                _headOfExpenseCoaControlAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadOfExpenseCoaControlAccTypeAccType
        {
            get
            {
                return _headOfExpenseCoaControlAccTypeAccType;
            }
            set
            {
                _headOfExpenseCoaControlAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadOfExpenseCoaControlCompTypeDescription
        {
            get
            {
                return _headOfExpenseCoaControlCompTypeDescription;
            }
            set
            {
                _headOfExpenseCoaControlCompTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadOfExpenseCoaMainAccName
        {
            get
            {
                return _headOfExpenseCoaMainAccName;
            }
            set
            {
                _headOfExpenseCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadOfExpenseCoaMainAccBalTypeAccBalType
        {
            get
            {
                return _headOfExpenseCoaMainAccBalTypeAccBalType;
            }
            set
            {
                _headOfExpenseCoaMainAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadOfExpenseCoaMainAccDestAccDest
        {
            get
            {
                return _headOfExpenseCoaMainAccDestAccDest;
            }
            set
            {
                _headOfExpenseCoaMainAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadOfExpenseCoaMainAccFundAccFundName
        {
            get
            {
                return _headOfExpenseCoaMainAccFundAccFundName;
            }
            set
            {
                _headOfExpenseCoaMainAccFundAccFundName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadOfExpenseCoaMainAccTypeAccType
        {
            get
            {
                return _headOfExpenseCoaMainAccTypeAccType;
            }
            set
            {
                _headOfExpenseCoaMainAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadOfExpenseCoaMainCoaControlAccName
        {
            get
            {
                return _headOfExpenseCoaMainCoaControlAccName;
            }
            set
            {
                _headOfExpenseCoaMainCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadOfExpenseCoaSubAccName
        {
            get
            {
                return _headOfExpenseCoaSubAccName;
            }
            set
            {
                _headOfExpenseCoaSubAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadOfExpenseCoaSubAccBalTypeAccBalType
        {
            get
            {
                return _headOfExpenseCoaSubAccBalTypeAccBalType;
            }
            set
            {
                _headOfExpenseCoaSubAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadOfExpenseCoaSubAccDestAccDest
        {
            get
            {
                return _headOfExpenseCoaSubAccDestAccDest;
            }
            set
            {
                _headOfExpenseCoaSubAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadOfExpenseCoaSubAccFundAccFundName
        {
            get
            {
                return _headOfExpenseCoaSubAccFundAccFundName;
            }
            set
            {
                _headOfExpenseCoaSubAccFundAccFundName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadOfExpenseCoaSubAccTypeAccType
        {
            get
            {
                return _headOfExpenseCoaSubAccTypeAccType;
            }
            set
            {
                _headOfExpenseCoaSubAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadOfExpenseCoaSubCoaControlAccName
        {
            get
            {
                return _headOfExpenseCoaSubCoaControlAccName;
            }
            set
            {
                _headOfExpenseCoaSubCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadOfExpenseCoaSubCoaMainAccName
        {
            get
            {
                return _headOfExpenseCoaSubCoaMainAccName;
            }
            set
            {
                _headOfExpenseCoaSubCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? BankAccountHOA
        {
            get
            {
                return _bankAccountHOA;
            }
            set
            {
                _bankAccountHOA = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankAccountHOAAccName
        {
            get
            {
                return _bankAccountHOAAccName;
            }
            set
            {
                _bankAccountHOAAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankAccountHOAAccBalTypeAccBalType
        {
            get
            {
                return _bankAccountHOAAccBalTypeAccBalType;
            }
            set
            {
                _bankAccountHOAAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankAccountHOAAccCurrencyAccCurrencyName
        {
            get
            {
                return _bankAccountHOAAccCurrencyAccCurrencyName;
            }
            set
            {
                _bankAccountHOAAccCurrencyAccCurrencyName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankAccountHOAAccDestAccDest
        {
            get
            {
                return _bankAccountHOAAccDestAccDest;
            }
            set
            {
                _bankAccountHOAAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankAccountHOAAccDestCompanyTypeDescription
        {
            get
            {
                return _bankAccountHOAAccDestCompanyTypeDescription;
            }
            set
            {
                _bankAccountHOAAccDestCompanyTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankAccountHOAAccFundAccFundName
        {
            get
            {
                return _bankAccountHOAAccFundAccFundName;
            }
            set
            {
                _bankAccountHOAAccFundAccFundName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankAccountHOAAccSubTypeAccSubType
        {
            get
            {
                return _bankAccountHOAAccSubTypeAccSubType;
            }
            set
            {
                _bankAccountHOAAccSubTypeAccSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankAccountHOAAccTypeAccType
        {
            get
            {
                return _bankAccountHOAAccTypeAccType;
            }
            set
            {
                _bankAccountHOAAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankAccountHOACoaControlAccName
        {
            get
            {
                return _bankAccountHOACoaControlAccName;
            }
            set
            {
                _bankAccountHOACoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankAccountHOACoaControlAccBalTypeAccBalType
        {
            get
            {
                return _bankAccountHOACoaControlAccBalTypeAccBalType;
            }
            set
            {
                _bankAccountHOACoaControlAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankAccountHOACoaControlAccDestAccDest
        {
            get
            {
                return _bankAccountHOACoaControlAccDestAccDest;
            }
            set
            {
                _bankAccountHOACoaControlAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankAccountHOACoaControlAccTypeAccType
        {
            get
            {
                return _bankAccountHOACoaControlAccTypeAccType;
            }
            set
            {
                _bankAccountHOACoaControlAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankAccountHOACoaControlCompTypeDescription
        {
            get
            {
                return _bankAccountHOACoaControlCompTypeDescription;
            }
            set
            {
                _bankAccountHOACoaControlCompTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankAccountHOACoaMainAccName
        {
            get
            {
                return _bankAccountHOACoaMainAccName;
            }
            set
            {
                _bankAccountHOACoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankAccountHOACoaMainAccBalTypeAccBalType
        {
            get
            {
                return _bankAccountHOACoaMainAccBalTypeAccBalType;
            }
            set
            {
                _bankAccountHOACoaMainAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankAccountHOACoaMainAccDestAccDest
        {
            get
            {
                return _bankAccountHOACoaMainAccDestAccDest;
            }
            set
            {
                _bankAccountHOACoaMainAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankAccountHOACoaMainAccFundAccFundName
        {
            get
            {
                return _bankAccountHOACoaMainAccFundAccFundName;
            }
            set
            {
                _bankAccountHOACoaMainAccFundAccFundName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankAccountHOACoaMainAccTypeAccType
        {
            get
            {
                return _bankAccountHOACoaMainAccTypeAccType;
            }
            set
            {
                _bankAccountHOACoaMainAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankAccountHOACoaMainCoaControlAccName
        {
            get
            {
                return _bankAccountHOACoaMainCoaControlAccName;
            }
            set
            {
                _bankAccountHOACoaMainCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankAccountHOACoaSubAccName
        {
            get
            {
                return _bankAccountHOACoaSubAccName;
            }
            set
            {
                _bankAccountHOACoaSubAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankAccountHOACoaSubAccBalTypeAccBalType
        {
            get
            {
                return _bankAccountHOACoaSubAccBalTypeAccBalType;
            }
            set
            {
                _bankAccountHOACoaSubAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankAccountHOACoaSubAccDestAccDest
        {
            get
            {
                return _bankAccountHOACoaSubAccDestAccDest;
            }
            set
            {
                _bankAccountHOACoaSubAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankAccountHOACoaSubAccFundAccFundName
        {
            get
            {
                return _bankAccountHOACoaSubAccFundAccFundName;
            }
            set
            {
                _bankAccountHOACoaSubAccFundAccFundName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankAccountHOACoaSubAccTypeAccType
        {
            get
            {
                return _bankAccountHOACoaSubAccTypeAccType;
            }
            set
            {
                _bankAccountHOACoaSubAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankAccountHOACoaSubCoaControlAccName
        {
            get
            {
                return _bankAccountHOACoaSubCoaControlAccName;
            }
            set
            {
                _bankAccountHOACoaSubCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankAccountHOACoaSubCoaMainAccName
        {
            get
            {
                return _bankAccountHOACoaSubCoaMainAccName;
            }
            set
            {
                _bankAccountHOACoaSubCoaMainAccName = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.PDCIssue> Select(
                    int? pDCRID, 
                    bool? pDCType, 
                    string pDCNO, 
                    string pDCPreFix, 
                    DateTime? pDCDate, 
                    string address, 
                    int? payCatID, 
                    string payCatCategory, 
                    int? modeofReceiptID, 
                    string modeofReceiptDescription, 
                    int? chequeNo, 
                    int? chequeLeafNumber, 
                    string chequeChequeBookChequeBookNo, 
                    string chequeChequeBookAccFundAccFundName, 
                    string chequeChequeBookCoaDetailAccName, 
                    string bankName, 
                    string branchName, 
                    decimal? amount, 
                    bool? isSameAmount, 
                    string noOfPdc, 
                    string gname, 
                    string gFathersname, 
                    string gAddress, 
                    string otherRemarks, 
                    bool? displayAction, 
                    int? accFundID, 
                    string accFundAccFundName, 
                    int? payeeCode, 
                    string payeeAccSubName, 
                    string payeeAccSubTypeAccSubType, 
                    int? headOfExpense, 
                    string headOfExpenseAccName, 
                    string headOfExpenseAccBalTypeAccBalType, 
                    string headOfExpenseAccCurrencyAccCurrencyName, 
                    string headOfExpenseAccDestAccDest, 
                    string headOfExpenseAccDestCompanyTypeDescription, 
                    string headOfExpenseAccFundAccFundName, 
                    string headOfExpenseAccSubTypeAccSubType, 
                    string headOfExpenseAccTypeAccType, 
                    string headOfExpenseCoaControlAccName, 
                    string headOfExpenseCoaControlAccBalTypeAccBalType, 
                    string headOfExpenseCoaControlAccDestAccDest, 
                    string headOfExpenseCoaControlAccTypeAccType, 
                    string headOfExpenseCoaControlCompTypeDescription, 
                    string headOfExpenseCoaMainAccName, 
                    string headOfExpenseCoaMainAccBalTypeAccBalType, 
                    string headOfExpenseCoaMainAccDestAccDest, 
                    string headOfExpenseCoaMainAccFundAccFundName, 
                    string headOfExpenseCoaMainAccTypeAccType, 
                    string headOfExpenseCoaMainCoaControlAccName, 
                    string headOfExpenseCoaSubAccName, 
                    string headOfExpenseCoaSubAccBalTypeAccBalType, 
                    string headOfExpenseCoaSubAccDestAccDest, 
                    string headOfExpenseCoaSubAccFundAccFundName, 
                    string headOfExpenseCoaSubAccTypeAccType, 
                    string headOfExpenseCoaSubCoaControlAccName, 
                    string headOfExpenseCoaSubCoaMainAccName, 
                    int? bankAccountHOA, 
                    string bankAccountHOAAccName, 
                    string bankAccountHOAAccBalTypeAccBalType, 
                    string bankAccountHOAAccCurrencyAccCurrencyName, 
                    string bankAccountHOAAccDestAccDest, 
                    string bankAccountHOAAccDestCompanyTypeDescription, 
                    string bankAccountHOAAccFundAccFundName, 
                    string bankAccountHOAAccSubTypeAccSubType, 
                    string bankAccountHOAAccTypeAccType, 
                    string bankAccountHOACoaControlAccName, 
                    string bankAccountHOACoaControlAccBalTypeAccBalType, 
                    string bankAccountHOACoaControlAccDestAccDest, 
                    string bankAccountHOACoaControlAccTypeAccType, 
                    string bankAccountHOACoaControlCompTypeDescription, 
                    string bankAccountHOACoaMainAccName, 
                    string bankAccountHOACoaMainAccBalTypeAccBalType, 
                    string bankAccountHOACoaMainAccDestAccDest, 
                    string bankAccountHOACoaMainAccFundAccFundName, 
                    string bankAccountHOACoaMainAccTypeAccType, 
                    string bankAccountHOACoaMainCoaControlAccName, 
                    string bankAccountHOACoaSubAccName, 
                    string bankAccountHOACoaSubAccBalTypeAccBalType, 
                    string bankAccountHOACoaSubAccDestAccDest, 
                    string bankAccountHOACoaSubAccFundAccFundName, 
                    string bankAccountHOACoaSubAccTypeAccType, 
                    string bankAccountHOACoaSubCoaControlAccName, 
                    string bankAccountHOACoaSubCoaMainAccName)
        {
            return new PDCIssueFactory().Select(pDCRID, pDCType, pDCNO, pDCPreFix, pDCDate, address, payCatID, payCatCategory, modeofReceiptID, modeofReceiptDescription, chequeNo, chequeLeafNumber, chequeChequeBookChequeBookNo, chequeChequeBookAccFundAccFundName, chequeChequeBookCoaDetailAccName, bankName, branchName, amount, isSameAmount, noOfPdc, gname, gFathersname, gAddress, otherRemarks, displayAction, accFundID, accFundAccFundName, payeeCode, payeeAccSubName, payeeAccSubTypeAccSubType, headOfExpense, headOfExpenseAccName, headOfExpenseAccBalTypeAccBalType, headOfExpenseAccCurrencyAccCurrencyName, headOfExpenseAccDestAccDest, headOfExpenseAccDestCompanyTypeDescription, headOfExpenseAccFundAccFundName, headOfExpenseAccSubTypeAccSubType, headOfExpenseAccTypeAccType, headOfExpenseCoaControlAccName, headOfExpenseCoaControlAccBalTypeAccBalType, headOfExpenseCoaControlAccDestAccDest, headOfExpenseCoaControlAccTypeAccType, headOfExpenseCoaControlCompTypeDescription, headOfExpenseCoaMainAccName, headOfExpenseCoaMainAccBalTypeAccBalType, headOfExpenseCoaMainAccDestAccDest, headOfExpenseCoaMainAccFundAccFundName, headOfExpenseCoaMainAccTypeAccType, headOfExpenseCoaMainCoaControlAccName, headOfExpenseCoaSubAccName, headOfExpenseCoaSubAccBalTypeAccBalType, headOfExpenseCoaSubAccDestAccDest, headOfExpenseCoaSubAccFundAccFundName, headOfExpenseCoaSubAccTypeAccType, headOfExpenseCoaSubCoaControlAccName, headOfExpenseCoaSubCoaMainAccName, bankAccountHOA, bankAccountHOAAccName, bankAccountHOAAccBalTypeAccBalType, bankAccountHOAAccCurrencyAccCurrencyName, bankAccountHOAAccDestAccDest, bankAccountHOAAccDestCompanyTypeDescription, bankAccountHOAAccFundAccFundName, bankAccountHOAAccSubTypeAccSubType, bankAccountHOAAccTypeAccType, bankAccountHOACoaControlAccName, bankAccountHOACoaControlAccBalTypeAccBalType, bankAccountHOACoaControlAccDestAccDest, bankAccountHOACoaControlAccTypeAccType, bankAccountHOACoaControlCompTypeDescription, bankAccountHOACoaMainAccName, bankAccountHOACoaMainAccBalTypeAccBalType, bankAccountHOACoaMainAccDestAccDest, bankAccountHOACoaMainAccFundAccFundName, bankAccountHOACoaMainAccTypeAccType, bankAccountHOACoaMainCoaControlAccName, bankAccountHOACoaSubAccName, bankAccountHOACoaSubAccBalTypeAccBalType, bankAccountHOACoaSubAccDestAccDest, bankAccountHOACoaSubAccFundAccFundName, bankAccountHOACoaSubAccTypeAccType, bankAccountHOACoaSubCoaControlAccName, bankAccountHOACoaSubCoaMainAccName);
        }
        
        public static List<MyCompany.Data.Objects.PDCIssue> Select(MyCompany.Data.Objects.PDCIssue qbe)
        {
            return new PDCIssueFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.PDCIssue> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new PDCIssueFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.PDCIssue> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new PDCIssueFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.PDCIssue> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new PDCIssueFactory().Select(filter, sort, PDCIssueFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.PDCIssue> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new PDCIssueFactory().Select(filter, sort, PDCIssueFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.PDCIssue> Select(string filter, BusinessObjectParameters parameters)
        {
            return new PDCIssueFactory().Select(filter, null, PDCIssueFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.PDCIssue> Select(string filter, params FieldValue[] parameters)
        {
            return new PDCIssueFactory().Select(filter, null, PDCIssueFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.PDCIssue SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new PDCIssueFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.PDCIssue SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new PDCIssueFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.PDCIssue SelectSingle(int? pDCRID)
        {
            return new PDCIssueFactory().SelectSingle(pDCRID);
        }
        
        public int Insert()
        {
            return new PDCIssueFactory().Insert(this);
        }
        
        public int Update()
        {
            return new PDCIssueFactory().Update(this);
        }
        
        public int Delete()
        {
            return new PDCIssueFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("PDCRID: {0}", this.PDCRID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class PDCIssueFactory
    {
        
        public PDCIssueFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("PDCIssue");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("PDCIssue");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("PDCIssue");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("PDCIssue");
            }
        }
        
        public static PDCIssueFactory Create()
        {
            return new PDCIssueFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    int? pDCRID, 
                    bool? pDCType, 
                    string pDCNO, 
                    string pDCPreFix, 
                    DateTime? pDCDate, 
                    string address, 
                    int? payCatID, 
                    string payCatCategory, 
                    int? modeofReceiptID, 
                    string modeofReceiptDescription, 
                    int? chequeNo, 
                    int? chequeLeafNumber, 
                    string chequeChequeBookChequeBookNo, 
                    string chequeChequeBookAccFundAccFundName, 
                    string chequeChequeBookCoaDetailAccName, 
                    string bankName, 
                    string branchName, 
                    decimal? amount, 
                    bool? isSameAmount, 
                    string noOfPdc, 
                    string gname, 
                    string gFathersname, 
                    string gAddress, 
                    string otherRemarks, 
                    bool? displayAction, 
                    int? accFundID, 
                    string accFundAccFundName, 
                    int? payeeCode, 
                    string payeeAccSubName, 
                    string payeeAccSubTypeAccSubType, 
                    int? headOfExpense, 
                    string headOfExpenseAccName, 
                    string headOfExpenseAccBalTypeAccBalType, 
                    string headOfExpenseAccCurrencyAccCurrencyName, 
                    string headOfExpenseAccDestAccDest, 
                    string headOfExpenseAccDestCompanyTypeDescription, 
                    string headOfExpenseAccFundAccFundName, 
                    string headOfExpenseAccSubTypeAccSubType, 
                    string headOfExpenseAccTypeAccType, 
                    string headOfExpenseCoaControlAccName, 
                    string headOfExpenseCoaControlAccBalTypeAccBalType, 
                    string headOfExpenseCoaControlAccDestAccDest, 
                    string headOfExpenseCoaControlAccTypeAccType, 
                    string headOfExpenseCoaControlCompTypeDescription, 
                    string headOfExpenseCoaMainAccName, 
                    string headOfExpenseCoaMainAccBalTypeAccBalType, 
                    string headOfExpenseCoaMainAccDestAccDest, 
                    string headOfExpenseCoaMainAccFundAccFundName, 
                    string headOfExpenseCoaMainAccTypeAccType, 
                    string headOfExpenseCoaMainCoaControlAccName, 
                    string headOfExpenseCoaSubAccName, 
                    string headOfExpenseCoaSubAccBalTypeAccBalType, 
                    string headOfExpenseCoaSubAccDestAccDest, 
                    string headOfExpenseCoaSubAccFundAccFundName, 
                    string headOfExpenseCoaSubAccTypeAccType, 
                    string headOfExpenseCoaSubCoaControlAccName, 
                    string headOfExpenseCoaSubCoaMainAccName, 
                    int? bankAccountHOA, 
                    string bankAccountHOAAccName, 
                    string bankAccountHOAAccBalTypeAccBalType, 
                    string bankAccountHOAAccCurrencyAccCurrencyName, 
                    string bankAccountHOAAccDestAccDest, 
                    string bankAccountHOAAccDestCompanyTypeDescription, 
                    string bankAccountHOAAccFundAccFundName, 
                    string bankAccountHOAAccSubTypeAccSubType, 
                    string bankAccountHOAAccTypeAccType, 
                    string bankAccountHOACoaControlAccName, 
                    string bankAccountHOACoaControlAccBalTypeAccBalType, 
                    string bankAccountHOACoaControlAccDestAccDest, 
                    string bankAccountHOACoaControlAccTypeAccType, 
                    string bankAccountHOACoaControlCompTypeDescription, 
                    string bankAccountHOACoaMainAccName, 
                    string bankAccountHOACoaMainAccBalTypeAccBalType, 
                    string bankAccountHOACoaMainAccDestAccDest, 
                    string bankAccountHOACoaMainAccFundAccFundName, 
                    string bankAccountHOACoaMainAccTypeAccType, 
                    string bankAccountHOACoaMainCoaControlAccName, 
                    string bankAccountHOACoaSubAccName, 
                    string bankAccountHOACoaSubAccBalTypeAccBalType, 
                    string bankAccountHOACoaSubAccDestAccDest, 
                    string bankAccountHOACoaSubAccFundAccFundName, 
                    string bankAccountHOACoaSubAccTypeAccType, 
                    string bankAccountHOACoaSubCoaControlAccName, 
                    string bankAccountHOACoaSubCoaMainAccName, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (pDCRID.HasValue)
            	filter.Add(("PDCRID:=" + pDCRID.Value.ToString()));
            if (pDCType.HasValue)
            	filter.Add(("PDCType:=" + pDCType.Value.ToString()));
            if (!(String.IsNullOrEmpty(pDCNO)))
            	filter.Add(("PDCNO:*" + pDCNO));
            if (!(String.IsNullOrEmpty(pDCPreFix)))
            	filter.Add(("PDCPreFix:*" + pDCPreFix));
            if (pDCDate.HasValue)
            	filter.Add(("PDCDate:=" + pDCDate.Value.ToString()));
            if (!(String.IsNullOrEmpty(address)))
            	filter.Add(("Address:*" + address));
            if (payCatID.HasValue)
            	filter.Add(("PayCatID:=" + payCatID.Value.ToString()));
            if (!(String.IsNullOrEmpty(payCatCategory)))
            	filter.Add(("PayCatCategory:*" + payCatCategory));
            if (modeofReceiptID.HasValue)
            	filter.Add(("ModeofReceiptID:=" + modeofReceiptID.Value.ToString()));
            if (!(String.IsNullOrEmpty(modeofReceiptDescription)))
            	filter.Add(("ModeofReceiptDescription:*" + modeofReceiptDescription));
            if (chequeNo.HasValue)
            	filter.Add(("ChequeNo:=" + chequeNo.Value.ToString()));
            if (chequeLeafNumber.HasValue)
            	filter.Add(("ChequeLeafNumber:=" + chequeLeafNumber.Value.ToString()));
            if (!(String.IsNullOrEmpty(chequeChequeBookChequeBookNo)))
            	filter.Add(("ChequeChequeBookChequeBookNo:*" + chequeChequeBookChequeBookNo));
            if (!(String.IsNullOrEmpty(chequeChequeBookAccFundAccFundName)))
            	filter.Add(("ChequeChequeBookAccFundAccFundName:*" + chequeChequeBookAccFundAccFundName));
            if (!(String.IsNullOrEmpty(chequeChequeBookCoaDetailAccName)))
            	filter.Add(("ChequeChequeBookCoaDetailAccName:*" + chequeChequeBookCoaDetailAccName));
            if (!(String.IsNullOrEmpty(bankName)))
            	filter.Add(("BankName:*" + bankName));
            if (!(String.IsNullOrEmpty(branchName)))
            	filter.Add(("BranchName:*" + branchName));
            if (amount.HasValue)
            	filter.Add(("Amount:=" + amount.Value.ToString()));
            if (isSameAmount.HasValue)
            	filter.Add(("IsSameAmount:=" + isSameAmount.Value.ToString()));
            if (!(String.IsNullOrEmpty(noOfPdc)))
            	filter.Add(("NoOfPdc:*" + noOfPdc));
            if (!(String.IsNullOrEmpty(gname)))
            	filter.Add(("Gname:*" + gname));
            if (!(String.IsNullOrEmpty(gFathersname)))
            	filter.Add(("GFathersname:*" + gFathersname));
            if (!(String.IsNullOrEmpty(gAddress)))
            	filter.Add(("GAddress:*" + gAddress));
            if (!(String.IsNullOrEmpty(otherRemarks)))
            	filter.Add(("OtherRemarks:*" + otherRemarks));
            if (displayAction.HasValue)
            	filter.Add(("DisplayAction:=" + displayAction.Value.ToString()));
            if (accFundID.HasValue)
            	filter.Add(("AccFundID:=" + accFundID.Value.ToString()));
            if (!(String.IsNullOrEmpty(accFundAccFundName)))
            	filter.Add(("AccFundAccFundName:*" + accFundAccFundName));
            if (payeeCode.HasValue)
            	filter.Add(("PayeeCode:=" + payeeCode.Value.ToString()));
            if (!(String.IsNullOrEmpty(payeeAccSubName)))
            	filter.Add(("PayeeAccSubName:*" + payeeAccSubName));
            if (!(String.IsNullOrEmpty(payeeAccSubTypeAccSubType)))
            	filter.Add(("PayeeAccSubTypeAccSubType:*" + payeeAccSubTypeAccSubType));
            if (headOfExpense.HasValue)
            	filter.Add(("HeadOfExpense:=" + headOfExpense.Value.ToString()));
            if (!(String.IsNullOrEmpty(headOfExpenseAccName)))
            	filter.Add(("HeadOfExpenseAccName:*" + headOfExpenseAccName));
            if (!(String.IsNullOrEmpty(headOfExpenseAccBalTypeAccBalType)))
            	filter.Add(("HeadOfExpenseAccBalTypeAccBalType:*" + headOfExpenseAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(headOfExpenseAccCurrencyAccCurrencyName)))
            	filter.Add(("HeadOfExpenseAccCurrencyAccCurrencyName:*" + headOfExpenseAccCurrencyAccCurrencyName));
            if (!(String.IsNullOrEmpty(headOfExpenseAccDestAccDest)))
            	filter.Add(("HeadOfExpenseAccDestAccDest:*" + headOfExpenseAccDestAccDest));
            if (!(String.IsNullOrEmpty(headOfExpenseAccDestCompanyTypeDescription)))
            	filter.Add(("HeadOfExpenseAccDestCompanyTypeDescription:*" + headOfExpenseAccDestCompanyTypeDescription));
            if (!(String.IsNullOrEmpty(headOfExpenseAccFundAccFundName)))
            	filter.Add(("HeadOfExpenseAccFundAccFundName:*" + headOfExpenseAccFundAccFundName));
            if (!(String.IsNullOrEmpty(headOfExpenseAccSubTypeAccSubType)))
            	filter.Add(("HeadOfExpenseAccSubTypeAccSubType:*" + headOfExpenseAccSubTypeAccSubType));
            if (!(String.IsNullOrEmpty(headOfExpenseAccTypeAccType)))
            	filter.Add(("HeadOfExpenseAccTypeAccType:*" + headOfExpenseAccTypeAccType));
            if (!(String.IsNullOrEmpty(headOfExpenseCoaControlAccName)))
            	filter.Add(("HeadOfExpenseCoaControlAccName:*" + headOfExpenseCoaControlAccName));
            if (!(String.IsNullOrEmpty(headOfExpenseCoaControlAccBalTypeAccBalType)))
            	filter.Add(("HeadOfExpenseCoaControlAccBalTypeAccBalType:*" + headOfExpenseCoaControlAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(headOfExpenseCoaControlAccDestAccDest)))
            	filter.Add(("HeadOfExpenseCoaControlAccDestAccDest:*" + headOfExpenseCoaControlAccDestAccDest));
            if (!(String.IsNullOrEmpty(headOfExpenseCoaControlAccTypeAccType)))
            	filter.Add(("HeadOfExpenseCoaControlAccTypeAccType:*" + headOfExpenseCoaControlAccTypeAccType));
            if (!(String.IsNullOrEmpty(headOfExpenseCoaControlCompTypeDescription)))
            	filter.Add(("HeadOfExpenseCoaControlCompTypeDescription:*" + headOfExpenseCoaControlCompTypeDescription));
            if (!(String.IsNullOrEmpty(headOfExpenseCoaMainAccName)))
            	filter.Add(("HeadOfExpenseCoaMainAccName:*" + headOfExpenseCoaMainAccName));
            if (!(String.IsNullOrEmpty(headOfExpenseCoaMainAccBalTypeAccBalType)))
            	filter.Add(("HeadOfExpenseCoaMainAccBalTypeAccBalType:*" + headOfExpenseCoaMainAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(headOfExpenseCoaMainAccDestAccDest)))
            	filter.Add(("HeadOfExpenseCoaMainAccDestAccDest:*" + headOfExpenseCoaMainAccDestAccDest));
            if (!(String.IsNullOrEmpty(headOfExpenseCoaMainAccFundAccFundName)))
            	filter.Add(("HeadOfExpenseCoaMainAccFundAccFundName:*" + headOfExpenseCoaMainAccFundAccFundName));
            if (!(String.IsNullOrEmpty(headOfExpenseCoaMainAccTypeAccType)))
            	filter.Add(("HeadOfExpenseCoaMainAccTypeAccType:*" + headOfExpenseCoaMainAccTypeAccType));
            if (!(String.IsNullOrEmpty(headOfExpenseCoaMainCoaControlAccName)))
            	filter.Add(("HeadOfExpenseCoaMainCoaControlAccName:*" + headOfExpenseCoaMainCoaControlAccName));
            if (!(String.IsNullOrEmpty(headOfExpenseCoaSubAccName)))
            	filter.Add(("HeadOfExpenseCoaSubAccName:*" + headOfExpenseCoaSubAccName));
            if (!(String.IsNullOrEmpty(headOfExpenseCoaSubAccBalTypeAccBalType)))
            	filter.Add(("HeadOfExpenseCoaSubAccBalTypeAccBalType:*" + headOfExpenseCoaSubAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(headOfExpenseCoaSubAccDestAccDest)))
            	filter.Add(("HeadOfExpenseCoaSubAccDestAccDest:*" + headOfExpenseCoaSubAccDestAccDest));
            if (!(String.IsNullOrEmpty(headOfExpenseCoaSubAccFundAccFundName)))
            	filter.Add(("HeadOfExpenseCoaSubAccFundAccFundName:*" + headOfExpenseCoaSubAccFundAccFundName));
            if (!(String.IsNullOrEmpty(headOfExpenseCoaSubAccTypeAccType)))
            	filter.Add(("HeadOfExpenseCoaSubAccTypeAccType:*" + headOfExpenseCoaSubAccTypeAccType));
            if (!(String.IsNullOrEmpty(headOfExpenseCoaSubCoaControlAccName)))
            	filter.Add(("HeadOfExpenseCoaSubCoaControlAccName:*" + headOfExpenseCoaSubCoaControlAccName));
            if (!(String.IsNullOrEmpty(headOfExpenseCoaSubCoaMainAccName)))
            	filter.Add(("HeadOfExpenseCoaSubCoaMainAccName:*" + headOfExpenseCoaSubCoaMainAccName));
            if (bankAccountHOA.HasValue)
            	filter.Add(("BankAccountHOA:=" + bankAccountHOA.Value.ToString()));
            if (!(String.IsNullOrEmpty(bankAccountHOAAccName)))
            	filter.Add(("BankAccountHOAAccName:*" + bankAccountHOAAccName));
            if (!(String.IsNullOrEmpty(bankAccountHOAAccBalTypeAccBalType)))
            	filter.Add(("BankAccountHOAAccBalTypeAccBalType:*" + bankAccountHOAAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(bankAccountHOAAccCurrencyAccCurrencyName)))
            	filter.Add(("BankAccountHOAAccCurrencyAccCurrencyName:*" + bankAccountHOAAccCurrencyAccCurrencyName));
            if (!(String.IsNullOrEmpty(bankAccountHOAAccDestAccDest)))
            	filter.Add(("BankAccountHOAAccDestAccDest:*" + bankAccountHOAAccDestAccDest));
            if (!(String.IsNullOrEmpty(bankAccountHOAAccDestCompanyTypeDescription)))
            	filter.Add(("BankAccountHOAAccDestCompanyTypeDescription:*" + bankAccountHOAAccDestCompanyTypeDescription));
            if (!(String.IsNullOrEmpty(bankAccountHOAAccFundAccFundName)))
            	filter.Add(("BankAccountHOAAccFundAccFundName:*" + bankAccountHOAAccFundAccFundName));
            if (!(String.IsNullOrEmpty(bankAccountHOAAccSubTypeAccSubType)))
            	filter.Add(("BankAccountHOAAccSubTypeAccSubType:*" + bankAccountHOAAccSubTypeAccSubType));
            if (!(String.IsNullOrEmpty(bankAccountHOAAccTypeAccType)))
            	filter.Add(("BankAccountHOAAccTypeAccType:*" + bankAccountHOAAccTypeAccType));
            if (!(String.IsNullOrEmpty(bankAccountHOACoaControlAccName)))
            	filter.Add(("BankAccountHOACoaControlAccName:*" + bankAccountHOACoaControlAccName));
            if (!(String.IsNullOrEmpty(bankAccountHOACoaControlAccBalTypeAccBalType)))
            	filter.Add(("BankAccountHOACoaControlAccBalTypeAccBalType:*" + bankAccountHOACoaControlAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(bankAccountHOACoaControlAccDestAccDest)))
            	filter.Add(("BankAccountHOACoaControlAccDestAccDest:*" + bankAccountHOACoaControlAccDestAccDest));
            if (!(String.IsNullOrEmpty(bankAccountHOACoaControlAccTypeAccType)))
            	filter.Add(("BankAccountHOACoaControlAccTypeAccType:*" + bankAccountHOACoaControlAccTypeAccType));
            if (!(String.IsNullOrEmpty(bankAccountHOACoaControlCompTypeDescription)))
            	filter.Add(("BankAccountHOACoaControlCompTypeDescription:*" + bankAccountHOACoaControlCompTypeDescription));
            if (!(String.IsNullOrEmpty(bankAccountHOACoaMainAccName)))
            	filter.Add(("BankAccountHOACoaMainAccName:*" + bankAccountHOACoaMainAccName));
            if (!(String.IsNullOrEmpty(bankAccountHOACoaMainAccBalTypeAccBalType)))
            	filter.Add(("BankAccountHOACoaMainAccBalTypeAccBalType:*" + bankAccountHOACoaMainAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(bankAccountHOACoaMainAccDestAccDest)))
            	filter.Add(("BankAccountHOACoaMainAccDestAccDest:*" + bankAccountHOACoaMainAccDestAccDest));
            if (!(String.IsNullOrEmpty(bankAccountHOACoaMainAccFundAccFundName)))
            	filter.Add(("BankAccountHOACoaMainAccFundAccFundName:*" + bankAccountHOACoaMainAccFundAccFundName));
            if (!(String.IsNullOrEmpty(bankAccountHOACoaMainAccTypeAccType)))
            	filter.Add(("BankAccountHOACoaMainAccTypeAccType:*" + bankAccountHOACoaMainAccTypeAccType));
            if (!(String.IsNullOrEmpty(bankAccountHOACoaMainCoaControlAccName)))
            	filter.Add(("BankAccountHOACoaMainCoaControlAccName:*" + bankAccountHOACoaMainCoaControlAccName));
            if (!(String.IsNullOrEmpty(bankAccountHOACoaSubAccName)))
            	filter.Add(("BankAccountHOACoaSubAccName:*" + bankAccountHOACoaSubAccName));
            if (!(String.IsNullOrEmpty(bankAccountHOACoaSubAccBalTypeAccBalType)))
            	filter.Add(("BankAccountHOACoaSubAccBalTypeAccBalType:*" + bankAccountHOACoaSubAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(bankAccountHOACoaSubAccDestAccDest)))
            	filter.Add(("BankAccountHOACoaSubAccDestAccDest:*" + bankAccountHOACoaSubAccDestAccDest));
            if (!(String.IsNullOrEmpty(bankAccountHOACoaSubAccFundAccFundName)))
            	filter.Add(("BankAccountHOACoaSubAccFundAccFundName:*" + bankAccountHOACoaSubAccFundAccFundName));
            if (!(String.IsNullOrEmpty(bankAccountHOACoaSubAccTypeAccType)))
            	filter.Add(("BankAccountHOACoaSubAccTypeAccType:*" + bankAccountHOACoaSubAccTypeAccType));
            if (!(String.IsNullOrEmpty(bankAccountHOACoaSubCoaControlAccName)))
            	filter.Add(("BankAccountHOACoaSubCoaControlAccName:*" + bankAccountHOACoaSubCoaControlAccName));
            if (!(String.IsNullOrEmpty(bankAccountHOACoaSubCoaMainAccName)))
            	filter.Add(("BankAccountHOACoaSubCoaMainAccName:*" + bankAccountHOACoaSubCoaMainAccName));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.PDCIssue> Select(
                    int? pDCRID, 
                    bool? pDCType, 
                    string pDCNO, 
                    string pDCPreFix, 
                    DateTime? pDCDate, 
                    string address, 
                    int? payCatID, 
                    string payCatCategory, 
                    int? modeofReceiptID, 
                    string modeofReceiptDescription, 
                    int? chequeNo, 
                    int? chequeLeafNumber, 
                    string chequeChequeBookChequeBookNo, 
                    string chequeChequeBookAccFundAccFundName, 
                    string chequeChequeBookCoaDetailAccName, 
                    string bankName, 
                    string branchName, 
                    decimal? amount, 
                    bool? isSameAmount, 
                    string noOfPdc, 
                    string gname, 
                    string gFathersname, 
                    string gAddress, 
                    string otherRemarks, 
                    bool? displayAction, 
                    int? accFundID, 
                    string accFundAccFundName, 
                    int? payeeCode, 
                    string payeeAccSubName, 
                    string payeeAccSubTypeAccSubType, 
                    int? headOfExpense, 
                    string headOfExpenseAccName, 
                    string headOfExpenseAccBalTypeAccBalType, 
                    string headOfExpenseAccCurrencyAccCurrencyName, 
                    string headOfExpenseAccDestAccDest, 
                    string headOfExpenseAccDestCompanyTypeDescription, 
                    string headOfExpenseAccFundAccFundName, 
                    string headOfExpenseAccSubTypeAccSubType, 
                    string headOfExpenseAccTypeAccType, 
                    string headOfExpenseCoaControlAccName, 
                    string headOfExpenseCoaControlAccBalTypeAccBalType, 
                    string headOfExpenseCoaControlAccDestAccDest, 
                    string headOfExpenseCoaControlAccTypeAccType, 
                    string headOfExpenseCoaControlCompTypeDescription, 
                    string headOfExpenseCoaMainAccName, 
                    string headOfExpenseCoaMainAccBalTypeAccBalType, 
                    string headOfExpenseCoaMainAccDestAccDest, 
                    string headOfExpenseCoaMainAccFundAccFundName, 
                    string headOfExpenseCoaMainAccTypeAccType, 
                    string headOfExpenseCoaMainCoaControlAccName, 
                    string headOfExpenseCoaSubAccName, 
                    string headOfExpenseCoaSubAccBalTypeAccBalType, 
                    string headOfExpenseCoaSubAccDestAccDest, 
                    string headOfExpenseCoaSubAccFundAccFundName, 
                    string headOfExpenseCoaSubAccTypeAccType, 
                    string headOfExpenseCoaSubCoaControlAccName, 
                    string headOfExpenseCoaSubCoaMainAccName, 
                    int? bankAccountHOA, 
                    string bankAccountHOAAccName, 
                    string bankAccountHOAAccBalTypeAccBalType, 
                    string bankAccountHOAAccCurrencyAccCurrencyName, 
                    string bankAccountHOAAccDestAccDest, 
                    string bankAccountHOAAccDestCompanyTypeDescription, 
                    string bankAccountHOAAccFundAccFundName, 
                    string bankAccountHOAAccSubTypeAccSubType, 
                    string bankAccountHOAAccTypeAccType, 
                    string bankAccountHOACoaControlAccName, 
                    string bankAccountHOACoaControlAccBalTypeAccBalType, 
                    string bankAccountHOACoaControlAccDestAccDest, 
                    string bankAccountHOACoaControlAccTypeAccType, 
                    string bankAccountHOACoaControlCompTypeDescription, 
                    string bankAccountHOACoaMainAccName, 
                    string bankAccountHOACoaMainAccBalTypeAccBalType, 
                    string bankAccountHOACoaMainAccDestAccDest, 
                    string bankAccountHOACoaMainAccFundAccFundName, 
                    string bankAccountHOACoaMainAccTypeAccType, 
                    string bankAccountHOACoaMainCoaControlAccName, 
                    string bankAccountHOACoaSubAccName, 
                    string bankAccountHOACoaSubAccBalTypeAccBalType, 
                    string bankAccountHOACoaSubAccDestAccDest, 
                    string bankAccountHOACoaSubAccFundAccFundName, 
                    string bankAccountHOACoaSubAccTypeAccType, 
                    string bankAccountHOACoaSubCoaControlAccName, 
                    string bankAccountHOACoaSubCoaMainAccName, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(pDCRID, pDCType, pDCNO, pDCPreFix, pDCDate, address, payCatID, payCatCategory, modeofReceiptID, modeofReceiptDescription, chequeNo, chequeLeafNumber, chequeChequeBookChequeBookNo, chequeChequeBookAccFundAccFundName, chequeChequeBookCoaDetailAccName, bankName, branchName, amount, isSameAmount, noOfPdc, gname, gFathersname, gAddress, otherRemarks, displayAction, accFundID, accFundAccFundName, payeeCode, payeeAccSubName, payeeAccSubTypeAccSubType, headOfExpense, headOfExpenseAccName, headOfExpenseAccBalTypeAccBalType, headOfExpenseAccCurrencyAccCurrencyName, headOfExpenseAccDestAccDest, headOfExpenseAccDestCompanyTypeDescription, headOfExpenseAccFundAccFundName, headOfExpenseAccSubTypeAccSubType, headOfExpenseAccTypeAccType, headOfExpenseCoaControlAccName, headOfExpenseCoaControlAccBalTypeAccBalType, headOfExpenseCoaControlAccDestAccDest, headOfExpenseCoaControlAccTypeAccType, headOfExpenseCoaControlCompTypeDescription, headOfExpenseCoaMainAccName, headOfExpenseCoaMainAccBalTypeAccBalType, headOfExpenseCoaMainAccDestAccDest, headOfExpenseCoaMainAccFundAccFundName, headOfExpenseCoaMainAccTypeAccType, headOfExpenseCoaMainCoaControlAccName, headOfExpenseCoaSubAccName, headOfExpenseCoaSubAccBalTypeAccBalType, headOfExpenseCoaSubAccDestAccDest, headOfExpenseCoaSubAccFundAccFundName, headOfExpenseCoaSubAccTypeAccType, headOfExpenseCoaSubCoaControlAccName, headOfExpenseCoaSubCoaMainAccName, bankAccountHOA, bankAccountHOAAccName, bankAccountHOAAccBalTypeAccBalType, bankAccountHOAAccCurrencyAccCurrencyName, bankAccountHOAAccDestAccDest, bankAccountHOAAccDestCompanyTypeDescription, bankAccountHOAAccFundAccFundName, bankAccountHOAAccSubTypeAccSubType, bankAccountHOAAccTypeAccType, bankAccountHOACoaControlAccName, bankAccountHOACoaControlAccBalTypeAccBalType, bankAccountHOACoaControlAccDestAccDest, bankAccountHOACoaControlAccTypeAccType, bankAccountHOACoaControlCompTypeDescription, bankAccountHOACoaMainAccName, bankAccountHOACoaMainAccBalTypeAccBalType, bankAccountHOACoaMainAccDestAccDest, bankAccountHOACoaMainAccFundAccFundName, bankAccountHOACoaMainAccTypeAccType, bankAccountHOACoaMainCoaControlAccName, bankAccountHOACoaSubAccName, bankAccountHOACoaSubAccBalTypeAccBalType, bankAccountHOACoaSubAccDestAccDest, bankAccountHOACoaSubAccFundAccFundName, bankAccountHOACoaSubAccTypeAccType, bankAccountHOACoaSubCoaControlAccName, bankAccountHOACoaSubCoaMainAccName, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("PDCIssue", dataView, request);
            return page.ToList<MyCompany.Data.Objects.PDCIssue>();
        }
        
        public List<MyCompany.Data.Objects.PDCIssue> Select(MyCompany.Data.Objects.PDCIssue qbe)
        {
            return Select(qbe.PDCRID, qbe.PDCType, qbe.PDCNO, qbe.PDCPreFix, qbe.PDCDate, qbe.Address, qbe.PayCatID, qbe.PayCatCategory, qbe.ModeofReceiptID, qbe.ModeofReceiptDescription, qbe.ChequeNo, qbe.ChequeLeafNumber, qbe.ChequeChequeBookChequeBookNo, qbe.ChequeChequeBookAccFundAccFundName, qbe.ChequeChequeBookCoaDetailAccName, qbe.BankName, qbe.BranchName, qbe.Amount, qbe.IsSameAmount, qbe.NoOfPdc, qbe.Gname, qbe.GFathersname, qbe.GAddress, qbe.OtherRemarks, qbe.DisplayAction, qbe.AccFundID, qbe.AccFundAccFundName, qbe.PayeeCode, qbe.PayeeAccSubName, qbe.PayeeAccSubTypeAccSubType, qbe.HeadOfExpense, qbe.HeadOfExpenseAccName, qbe.HeadOfExpenseAccBalTypeAccBalType, qbe.HeadOfExpenseAccCurrencyAccCurrencyName, qbe.HeadOfExpenseAccDestAccDest, qbe.HeadOfExpenseAccDestCompanyTypeDescription, qbe.HeadOfExpenseAccFundAccFundName, qbe.HeadOfExpenseAccSubTypeAccSubType, qbe.HeadOfExpenseAccTypeAccType, qbe.HeadOfExpenseCoaControlAccName, qbe.HeadOfExpenseCoaControlAccBalTypeAccBalType, qbe.HeadOfExpenseCoaControlAccDestAccDest, qbe.HeadOfExpenseCoaControlAccTypeAccType, qbe.HeadOfExpenseCoaControlCompTypeDescription, qbe.HeadOfExpenseCoaMainAccName, qbe.HeadOfExpenseCoaMainAccBalTypeAccBalType, qbe.HeadOfExpenseCoaMainAccDestAccDest, qbe.HeadOfExpenseCoaMainAccFundAccFundName, qbe.HeadOfExpenseCoaMainAccTypeAccType, qbe.HeadOfExpenseCoaMainCoaControlAccName, qbe.HeadOfExpenseCoaSubAccName, qbe.HeadOfExpenseCoaSubAccBalTypeAccBalType, qbe.HeadOfExpenseCoaSubAccDestAccDest, qbe.HeadOfExpenseCoaSubAccFundAccFundName, qbe.HeadOfExpenseCoaSubAccTypeAccType, qbe.HeadOfExpenseCoaSubCoaControlAccName, qbe.HeadOfExpenseCoaSubCoaMainAccName, qbe.BankAccountHOA, qbe.BankAccountHOAAccName, qbe.BankAccountHOAAccBalTypeAccBalType, qbe.BankAccountHOAAccCurrencyAccCurrencyName, qbe.BankAccountHOAAccDestAccDest, qbe.BankAccountHOAAccDestCompanyTypeDescription, qbe.BankAccountHOAAccFundAccFundName, qbe.BankAccountHOAAccSubTypeAccSubType, qbe.BankAccountHOAAccTypeAccType, qbe.BankAccountHOACoaControlAccName, qbe.BankAccountHOACoaControlAccBalTypeAccBalType, qbe.BankAccountHOACoaControlAccDestAccDest, qbe.BankAccountHOACoaControlAccTypeAccType, qbe.BankAccountHOACoaControlCompTypeDescription, qbe.BankAccountHOACoaMainAccName, qbe.BankAccountHOACoaMainAccBalTypeAccBalType, qbe.BankAccountHOACoaMainAccDestAccDest, qbe.BankAccountHOACoaMainAccFundAccFundName, qbe.BankAccountHOACoaMainAccTypeAccType, qbe.BankAccountHOACoaMainCoaControlAccName, qbe.BankAccountHOACoaSubAccName, qbe.BankAccountHOACoaSubAccBalTypeAccBalType, qbe.BankAccountHOACoaSubAccDestAccDest, qbe.BankAccountHOACoaSubAccFundAccFundName, qbe.BankAccountHOACoaSubAccTypeAccType, qbe.BankAccountHOACoaSubCoaControlAccName, qbe.BankAccountHOACoaSubCoaMainAccName);
        }
        
        public int SelectCount(
                    int? pDCRID, 
                    bool? pDCType, 
                    string pDCNO, 
                    string pDCPreFix, 
                    DateTime? pDCDate, 
                    string address, 
                    int? payCatID, 
                    string payCatCategory, 
                    int? modeofReceiptID, 
                    string modeofReceiptDescription, 
                    int? chequeNo, 
                    int? chequeLeafNumber, 
                    string chequeChequeBookChequeBookNo, 
                    string chequeChequeBookAccFundAccFundName, 
                    string chequeChequeBookCoaDetailAccName, 
                    string bankName, 
                    string branchName, 
                    decimal? amount, 
                    bool? isSameAmount, 
                    string noOfPdc, 
                    string gname, 
                    string gFathersname, 
                    string gAddress, 
                    string otherRemarks, 
                    bool? displayAction, 
                    int? accFundID, 
                    string accFundAccFundName, 
                    int? payeeCode, 
                    string payeeAccSubName, 
                    string payeeAccSubTypeAccSubType, 
                    int? headOfExpense, 
                    string headOfExpenseAccName, 
                    string headOfExpenseAccBalTypeAccBalType, 
                    string headOfExpenseAccCurrencyAccCurrencyName, 
                    string headOfExpenseAccDestAccDest, 
                    string headOfExpenseAccDestCompanyTypeDescription, 
                    string headOfExpenseAccFundAccFundName, 
                    string headOfExpenseAccSubTypeAccSubType, 
                    string headOfExpenseAccTypeAccType, 
                    string headOfExpenseCoaControlAccName, 
                    string headOfExpenseCoaControlAccBalTypeAccBalType, 
                    string headOfExpenseCoaControlAccDestAccDest, 
                    string headOfExpenseCoaControlAccTypeAccType, 
                    string headOfExpenseCoaControlCompTypeDescription, 
                    string headOfExpenseCoaMainAccName, 
                    string headOfExpenseCoaMainAccBalTypeAccBalType, 
                    string headOfExpenseCoaMainAccDestAccDest, 
                    string headOfExpenseCoaMainAccFundAccFundName, 
                    string headOfExpenseCoaMainAccTypeAccType, 
                    string headOfExpenseCoaMainCoaControlAccName, 
                    string headOfExpenseCoaSubAccName, 
                    string headOfExpenseCoaSubAccBalTypeAccBalType, 
                    string headOfExpenseCoaSubAccDestAccDest, 
                    string headOfExpenseCoaSubAccFundAccFundName, 
                    string headOfExpenseCoaSubAccTypeAccType, 
                    string headOfExpenseCoaSubCoaControlAccName, 
                    string headOfExpenseCoaSubCoaMainAccName, 
                    int? bankAccountHOA, 
                    string bankAccountHOAAccName, 
                    string bankAccountHOAAccBalTypeAccBalType, 
                    string bankAccountHOAAccCurrencyAccCurrencyName, 
                    string bankAccountHOAAccDestAccDest, 
                    string bankAccountHOAAccDestCompanyTypeDescription, 
                    string bankAccountHOAAccFundAccFundName, 
                    string bankAccountHOAAccSubTypeAccSubType, 
                    string bankAccountHOAAccTypeAccType, 
                    string bankAccountHOACoaControlAccName, 
                    string bankAccountHOACoaControlAccBalTypeAccBalType, 
                    string bankAccountHOACoaControlAccDestAccDest, 
                    string bankAccountHOACoaControlAccTypeAccType, 
                    string bankAccountHOACoaControlCompTypeDescription, 
                    string bankAccountHOACoaMainAccName, 
                    string bankAccountHOACoaMainAccBalTypeAccBalType, 
                    string bankAccountHOACoaMainAccDestAccDest, 
                    string bankAccountHOACoaMainAccFundAccFundName, 
                    string bankAccountHOACoaMainAccTypeAccType, 
                    string bankAccountHOACoaMainCoaControlAccName, 
                    string bankAccountHOACoaSubAccName, 
                    string bankAccountHOACoaSubAccBalTypeAccBalType, 
                    string bankAccountHOACoaSubAccDestAccDest, 
                    string bankAccountHOACoaSubAccFundAccFundName, 
                    string bankAccountHOACoaSubAccTypeAccType, 
                    string bankAccountHOACoaSubCoaControlAccName, 
                    string bankAccountHOACoaSubCoaMainAccName, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(pDCRID, pDCType, pDCNO, pDCPreFix, pDCDate, address, payCatID, payCatCategory, modeofReceiptID, modeofReceiptDescription, chequeNo, chequeLeafNumber, chequeChequeBookChequeBookNo, chequeChequeBookAccFundAccFundName, chequeChequeBookCoaDetailAccName, bankName, branchName, amount, isSameAmount, noOfPdc, gname, gFathersname, gAddress, otherRemarks, displayAction, accFundID, accFundAccFundName, payeeCode, payeeAccSubName, payeeAccSubTypeAccSubType, headOfExpense, headOfExpenseAccName, headOfExpenseAccBalTypeAccBalType, headOfExpenseAccCurrencyAccCurrencyName, headOfExpenseAccDestAccDest, headOfExpenseAccDestCompanyTypeDescription, headOfExpenseAccFundAccFundName, headOfExpenseAccSubTypeAccSubType, headOfExpenseAccTypeAccType, headOfExpenseCoaControlAccName, headOfExpenseCoaControlAccBalTypeAccBalType, headOfExpenseCoaControlAccDestAccDest, headOfExpenseCoaControlAccTypeAccType, headOfExpenseCoaControlCompTypeDescription, headOfExpenseCoaMainAccName, headOfExpenseCoaMainAccBalTypeAccBalType, headOfExpenseCoaMainAccDestAccDest, headOfExpenseCoaMainAccFundAccFundName, headOfExpenseCoaMainAccTypeAccType, headOfExpenseCoaMainCoaControlAccName, headOfExpenseCoaSubAccName, headOfExpenseCoaSubAccBalTypeAccBalType, headOfExpenseCoaSubAccDestAccDest, headOfExpenseCoaSubAccFundAccFundName, headOfExpenseCoaSubAccTypeAccType, headOfExpenseCoaSubCoaControlAccName, headOfExpenseCoaSubCoaMainAccName, bankAccountHOA, bankAccountHOAAccName, bankAccountHOAAccBalTypeAccBalType, bankAccountHOAAccCurrencyAccCurrencyName, bankAccountHOAAccDestAccDest, bankAccountHOAAccDestCompanyTypeDescription, bankAccountHOAAccFundAccFundName, bankAccountHOAAccSubTypeAccSubType, bankAccountHOAAccTypeAccType, bankAccountHOACoaControlAccName, bankAccountHOACoaControlAccBalTypeAccBalType, bankAccountHOACoaControlAccDestAccDest, bankAccountHOACoaControlAccTypeAccType, bankAccountHOACoaControlCompTypeDescription, bankAccountHOACoaMainAccName, bankAccountHOACoaMainAccBalTypeAccBalType, bankAccountHOACoaMainAccDestAccDest, bankAccountHOACoaMainAccFundAccFundName, bankAccountHOACoaMainAccTypeAccType, bankAccountHOACoaMainCoaControlAccName, bankAccountHOACoaSubAccName, bankAccountHOACoaSubAccBalTypeAccBalType, bankAccountHOACoaSubAccDestAccDest, bankAccountHOACoaSubAccFundAccFundName, bankAccountHOACoaSubAccTypeAccType, bankAccountHOACoaSubCoaControlAccName, bankAccountHOACoaSubCoaMainAccName, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("PDCIssue", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.PDCIssue> Select(
                    int? pDCRID, 
                    bool? pDCType, 
                    string pDCNO, 
                    string pDCPreFix, 
                    DateTime? pDCDate, 
                    string address, 
                    int? payCatID, 
                    string payCatCategory, 
                    int? modeofReceiptID, 
                    string modeofReceiptDescription, 
                    int? chequeNo, 
                    int? chequeLeafNumber, 
                    string chequeChequeBookChequeBookNo, 
                    string chequeChequeBookAccFundAccFundName, 
                    string chequeChequeBookCoaDetailAccName, 
                    string bankName, 
                    string branchName, 
                    decimal? amount, 
                    bool? isSameAmount, 
                    string noOfPdc, 
                    string gname, 
                    string gFathersname, 
                    string gAddress, 
                    string otherRemarks, 
                    bool? displayAction, 
                    int? accFundID, 
                    string accFundAccFundName, 
                    int? payeeCode, 
                    string payeeAccSubName, 
                    string payeeAccSubTypeAccSubType, 
                    int? headOfExpense, 
                    string headOfExpenseAccName, 
                    string headOfExpenseAccBalTypeAccBalType, 
                    string headOfExpenseAccCurrencyAccCurrencyName, 
                    string headOfExpenseAccDestAccDest, 
                    string headOfExpenseAccDestCompanyTypeDescription, 
                    string headOfExpenseAccFundAccFundName, 
                    string headOfExpenseAccSubTypeAccSubType, 
                    string headOfExpenseAccTypeAccType, 
                    string headOfExpenseCoaControlAccName, 
                    string headOfExpenseCoaControlAccBalTypeAccBalType, 
                    string headOfExpenseCoaControlAccDestAccDest, 
                    string headOfExpenseCoaControlAccTypeAccType, 
                    string headOfExpenseCoaControlCompTypeDescription, 
                    string headOfExpenseCoaMainAccName, 
                    string headOfExpenseCoaMainAccBalTypeAccBalType, 
                    string headOfExpenseCoaMainAccDestAccDest, 
                    string headOfExpenseCoaMainAccFundAccFundName, 
                    string headOfExpenseCoaMainAccTypeAccType, 
                    string headOfExpenseCoaMainCoaControlAccName, 
                    string headOfExpenseCoaSubAccName, 
                    string headOfExpenseCoaSubAccBalTypeAccBalType, 
                    string headOfExpenseCoaSubAccDestAccDest, 
                    string headOfExpenseCoaSubAccFundAccFundName, 
                    string headOfExpenseCoaSubAccTypeAccType, 
                    string headOfExpenseCoaSubCoaControlAccName, 
                    string headOfExpenseCoaSubCoaMainAccName, 
                    int? bankAccountHOA, 
                    string bankAccountHOAAccName, 
                    string bankAccountHOAAccBalTypeAccBalType, 
                    string bankAccountHOAAccCurrencyAccCurrencyName, 
                    string bankAccountHOAAccDestAccDest, 
                    string bankAccountHOAAccDestCompanyTypeDescription, 
                    string bankAccountHOAAccFundAccFundName, 
                    string bankAccountHOAAccSubTypeAccSubType, 
                    string bankAccountHOAAccTypeAccType, 
                    string bankAccountHOACoaControlAccName, 
                    string bankAccountHOACoaControlAccBalTypeAccBalType, 
                    string bankAccountHOACoaControlAccDestAccDest, 
                    string bankAccountHOACoaControlAccTypeAccType, 
                    string bankAccountHOACoaControlCompTypeDescription, 
                    string bankAccountHOACoaMainAccName, 
                    string bankAccountHOACoaMainAccBalTypeAccBalType, 
                    string bankAccountHOACoaMainAccDestAccDest, 
                    string bankAccountHOACoaMainAccFundAccFundName, 
                    string bankAccountHOACoaMainAccTypeAccType, 
                    string bankAccountHOACoaMainCoaControlAccName, 
                    string bankAccountHOACoaSubAccName, 
                    string bankAccountHOACoaSubAccBalTypeAccBalType, 
                    string bankAccountHOACoaSubAccDestAccDest, 
                    string bankAccountHOACoaSubAccFundAccFundName, 
                    string bankAccountHOACoaSubAccTypeAccType, 
                    string bankAccountHOACoaSubCoaControlAccName, 
                    string bankAccountHOACoaSubCoaMainAccName)
        {
            return Select(pDCRID, pDCType, pDCNO, pDCPreFix, pDCDate, address, payCatID, payCatCategory, modeofReceiptID, modeofReceiptDescription, chequeNo, chequeLeafNumber, chequeChequeBookChequeBookNo, chequeChequeBookAccFundAccFundName, chequeChequeBookCoaDetailAccName, bankName, branchName, amount, isSameAmount, noOfPdc, gname, gFathersname, gAddress, otherRemarks, displayAction, accFundID, accFundAccFundName, payeeCode, payeeAccSubName, payeeAccSubTypeAccSubType, headOfExpense, headOfExpenseAccName, headOfExpenseAccBalTypeAccBalType, headOfExpenseAccCurrencyAccCurrencyName, headOfExpenseAccDestAccDest, headOfExpenseAccDestCompanyTypeDescription, headOfExpenseAccFundAccFundName, headOfExpenseAccSubTypeAccSubType, headOfExpenseAccTypeAccType, headOfExpenseCoaControlAccName, headOfExpenseCoaControlAccBalTypeAccBalType, headOfExpenseCoaControlAccDestAccDest, headOfExpenseCoaControlAccTypeAccType, headOfExpenseCoaControlCompTypeDescription, headOfExpenseCoaMainAccName, headOfExpenseCoaMainAccBalTypeAccBalType, headOfExpenseCoaMainAccDestAccDest, headOfExpenseCoaMainAccFundAccFundName, headOfExpenseCoaMainAccTypeAccType, headOfExpenseCoaMainCoaControlAccName, headOfExpenseCoaSubAccName, headOfExpenseCoaSubAccBalTypeAccBalType, headOfExpenseCoaSubAccDestAccDest, headOfExpenseCoaSubAccFundAccFundName, headOfExpenseCoaSubAccTypeAccType, headOfExpenseCoaSubCoaControlAccName, headOfExpenseCoaSubCoaMainAccName, bankAccountHOA, bankAccountHOAAccName, bankAccountHOAAccBalTypeAccBalType, bankAccountHOAAccCurrencyAccCurrencyName, bankAccountHOAAccDestAccDest, bankAccountHOAAccDestCompanyTypeDescription, bankAccountHOAAccFundAccFundName, bankAccountHOAAccSubTypeAccSubType, bankAccountHOAAccTypeAccType, bankAccountHOACoaControlAccName, bankAccountHOACoaControlAccBalTypeAccBalType, bankAccountHOACoaControlAccDestAccDest, bankAccountHOACoaControlAccTypeAccType, bankAccountHOACoaControlCompTypeDescription, bankAccountHOACoaMainAccName, bankAccountHOACoaMainAccBalTypeAccBalType, bankAccountHOACoaMainAccDestAccDest, bankAccountHOACoaMainAccFundAccFundName, bankAccountHOACoaMainAccTypeAccType, bankAccountHOACoaMainCoaControlAccName, bankAccountHOACoaSubAccName, bankAccountHOACoaSubAccBalTypeAccBalType, bankAccountHOACoaSubAccDestAccDest, bankAccountHOACoaSubAccFundAccFundName, bankAccountHOACoaSubAccTypeAccType, bankAccountHOACoaSubCoaControlAccName, bankAccountHOACoaSubCoaMainAccName, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.PDCIssue SelectSingle(int? pDCRID)
        {
            List<MyCompany.Data.Objects.PDCIssue> list = Select(pDCRID, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.PDCIssue> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("PDCIssue", dataView, request);
            return page.ToList<MyCompany.Data.Objects.PDCIssue>();
        }
        
        public List<MyCompany.Data.Objects.PDCIssue> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.PDCIssue> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.PDCIssue SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.PDCIssue> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.PDCIssue thePDCIssue, MyCompany.Data.Objects.PDCIssue original_PDCIssue)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("PDCRID", original_PDCIssue.PDCRID, thePDCIssue.PDCRID, true));
            values.Add(new FieldValue("PDCType", original_PDCIssue.PDCType, thePDCIssue.PDCType));
            values.Add(new FieldValue("PDCNO", original_PDCIssue.PDCNO, thePDCIssue.PDCNO));
            values.Add(new FieldValue("PDCPreFix", original_PDCIssue.PDCPreFix, thePDCIssue.PDCPreFix));
            values.Add(new FieldValue("PDCDate", original_PDCIssue.PDCDate, thePDCIssue.PDCDate));
            values.Add(new FieldValue("Address", original_PDCIssue.Address, thePDCIssue.Address));
            values.Add(new FieldValue("PayCatID", original_PDCIssue.PayCatID, thePDCIssue.PayCatID));
            values.Add(new FieldValue("PayCatCategory", original_PDCIssue.PayCatCategory, thePDCIssue.PayCatCategory, true));
            values.Add(new FieldValue("ModeofReceiptID", original_PDCIssue.ModeofReceiptID, thePDCIssue.ModeofReceiptID));
            values.Add(new FieldValue("ModeofReceiptDescription", original_PDCIssue.ModeofReceiptDescription, thePDCIssue.ModeofReceiptDescription, true));
            values.Add(new FieldValue("ChequeNo", original_PDCIssue.ChequeNo, thePDCIssue.ChequeNo));
            values.Add(new FieldValue("ChequeLeafNumber", original_PDCIssue.ChequeLeafNumber, thePDCIssue.ChequeLeafNumber, true));
            values.Add(new FieldValue("ChequeChequeBookChequeBookNo", original_PDCIssue.ChequeChequeBookChequeBookNo, thePDCIssue.ChequeChequeBookChequeBookNo, true));
            values.Add(new FieldValue("ChequeChequeBookAccFundAccFundName", original_PDCIssue.ChequeChequeBookAccFundAccFundName, thePDCIssue.ChequeChequeBookAccFundAccFundName, true));
            values.Add(new FieldValue("ChequeChequeBookCoaDetailAccName", original_PDCIssue.ChequeChequeBookCoaDetailAccName, thePDCIssue.ChequeChequeBookCoaDetailAccName, true));
            values.Add(new FieldValue("BankName", original_PDCIssue.BankName, thePDCIssue.BankName));
            values.Add(new FieldValue("BranchName", original_PDCIssue.BranchName, thePDCIssue.BranchName));
            values.Add(new FieldValue("Amount", original_PDCIssue.Amount, thePDCIssue.Amount));
            values.Add(new FieldValue("IsSameAmount", original_PDCIssue.IsSameAmount, thePDCIssue.IsSameAmount));
            values.Add(new FieldValue("NoOfPdc", original_PDCIssue.NoOfPdc, thePDCIssue.NoOfPdc));
            values.Add(new FieldValue("Gname", original_PDCIssue.Gname, thePDCIssue.Gname));
            values.Add(new FieldValue("GFathersname", original_PDCIssue.GFathersname, thePDCIssue.GFathersname));
            values.Add(new FieldValue("GAddress", original_PDCIssue.GAddress, thePDCIssue.GAddress));
            values.Add(new FieldValue("OtherRemarks", original_PDCIssue.OtherRemarks, thePDCIssue.OtherRemarks));
            values.Add(new FieldValue("DisplayAction", original_PDCIssue.DisplayAction, thePDCIssue.DisplayAction));
            values.Add(new FieldValue("AccFundID", original_PDCIssue.AccFundID, thePDCIssue.AccFundID));
            values.Add(new FieldValue("AccFundAccFundName", original_PDCIssue.AccFundAccFundName, thePDCIssue.AccFundAccFundName, true));
            values.Add(new FieldValue("PayeeCode", original_PDCIssue.PayeeCode, thePDCIssue.PayeeCode));
            values.Add(new FieldValue("PayeeAccSubName", original_PDCIssue.PayeeAccSubName, thePDCIssue.PayeeAccSubName, true));
            values.Add(new FieldValue("PayeeAccSubTypeAccSubType", original_PDCIssue.PayeeAccSubTypeAccSubType, thePDCIssue.PayeeAccSubTypeAccSubType, true));
            values.Add(new FieldValue("HeadOfExpense", original_PDCIssue.HeadOfExpense, thePDCIssue.HeadOfExpense));
            values.Add(new FieldValue("HeadOfExpenseAccName", original_PDCIssue.HeadOfExpenseAccName, thePDCIssue.HeadOfExpenseAccName, true));
            values.Add(new FieldValue("HeadOfExpenseAccBalTypeAccBalType", original_PDCIssue.HeadOfExpenseAccBalTypeAccBalType, thePDCIssue.HeadOfExpenseAccBalTypeAccBalType, true));
            values.Add(new FieldValue("HeadOfExpenseAccCurrencyAccCurrencyName", original_PDCIssue.HeadOfExpenseAccCurrencyAccCurrencyName, thePDCIssue.HeadOfExpenseAccCurrencyAccCurrencyName, true));
            values.Add(new FieldValue("HeadOfExpenseAccDestAccDest", original_PDCIssue.HeadOfExpenseAccDestAccDest, thePDCIssue.HeadOfExpenseAccDestAccDest, true));
            values.Add(new FieldValue("HeadOfExpenseAccDestCompanyTypeDescription", original_PDCIssue.HeadOfExpenseAccDestCompanyTypeDescription, thePDCIssue.HeadOfExpenseAccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("HeadOfExpenseAccFundAccFundName", original_PDCIssue.HeadOfExpenseAccFundAccFundName, thePDCIssue.HeadOfExpenseAccFundAccFundName, true));
            values.Add(new FieldValue("HeadOfExpenseAccSubTypeAccSubType", original_PDCIssue.HeadOfExpenseAccSubTypeAccSubType, thePDCIssue.HeadOfExpenseAccSubTypeAccSubType, true));
            values.Add(new FieldValue("HeadOfExpenseAccTypeAccType", original_PDCIssue.HeadOfExpenseAccTypeAccType, thePDCIssue.HeadOfExpenseAccTypeAccType, true));
            values.Add(new FieldValue("HeadOfExpenseCoaControlAccName", original_PDCIssue.HeadOfExpenseCoaControlAccName, thePDCIssue.HeadOfExpenseCoaControlAccName, true));
            values.Add(new FieldValue("HeadOfExpenseCoaControlAccBalTypeAccBalType", original_PDCIssue.HeadOfExpenseCoaControlAccBalTypeAccBalType, thePDCIssue.HeadOfExpenseCoaControlAccBalTypeAccBalType, true));
            values.Add(new FieldValue("HeadOfExpenseCoaControlAccDestAccDest", original_PDCIssue.HeadOfExpenseCoaControlAccDestAccDest, thePDCIssue.HeadOfExpenseCoaControlAccDestAccDest, true));
            values.Add(new FieldValue("HeadOfExpenseCoaControlAccTypeAccType", original_PDCIssue.HeadOfExpenseCoaControlAccTypeAccType, thePDCIssue.HeadOfExpenseCoaControlAccTypeAccType, true));
            values.Add(new FieldValue("HeadOfExpenseCoaControlCompTypeDescription", original_PDCIssue.HeadOfExpenseCoaControlCompTypeDescription, thePDCIssue.HeadOfExpenseCoaControlCompTypeDescription, true));
            values.Add(new FieldValue("HeadOfExpenseCoaMainAccName", original_PDCIssue.HeadOfExpenseCoaMainAccName, thePDCIssue.HeadOfExpenseCoaMainAccName, true));
            values.Add(new FieldValue("HeadOfExpenseCoaMainAccBalTypeAccBalType", original_PDCIssue.HeadOfExpenseCoaMainAccBalTypeAccBalType, thePDCIssue.HeadOfExpenseCoaMainAccBalTypeAccBalType, true));
            values.Add(new FieldValue("HeadOfExpenseCoaMainAccDestAccDest", original_PDCIssue.HeadOfExpenseCoaMainAccDestAccDest, thePDCIssue.HeadOfExpenseCoaMainAccDestAccDest, true));
            values.Add(new FieldValue("HeadOfExpenseCoaMainAccFundAccFundName", original_PDCIssue.HeadOfExpenseCoaMainAccFundAccFundName, thePDCIssue.HeadOfExpenseCoaMainAccFundAccFundName, true));
            values.Add(new FieldValue("HeadOfExpenseCoaMainAccTypeAccType", original_PDCIssue.HeadOfExpenseCoaMainAccTypeAccType, thePDCIssue.HeadOfExpenseCoaMainAccTypeAccType, true));
            values.Add(new FieldValue("HeadOfExpenseCoaMainCoaControlAccName", original_PDCIssue.HeadOfExpenseCoaMainCoaControlAccName, thePDCIssue.HeadOfExpenseCoaMainCoaControlAccName, true));
            values.Add(new FieldValue("HeadOfExpenseCoaSubAccName", original_PDCIssue.HeadOfExpenseCoaSubAccName, thePDCIssue.HeadOfExpenseCoaSubAccName, true));
            values.Add(new FieldValue("HeadOfExpenseCoaSubAccBalTypeAccBalType", original_PDCIssue.HeadOfExpenseCoaSubAccBalTypeAccBalType, thePDCIssue.HeadOfExpenseCoaSubAccBalTypeAccBalType, true));
            values.Add(new FieldValue("HeadOfExpenseCoaSubAccDestAccDest", original_PDCIssue.HeadOfExpenseCoaSubAccDestAccDest, thePDCIssue.HeadOfExpenseCoaSubAccDestAccDest, true));
            values.Add(new FieldValue("HeadOfExpenseCoaSubAccFundAccFundName", original_PDCIssue.HeadOfExpenseCoaSubAccFundAccFundName, thePDCIssue.HeadOfExpenseCoaSubAccFundAccFundName, true));
            values.Add(new FieldValue("HeadOfExpenseCoaSubAccTypeAccType", original_PDCIssue.HeadOfExpenseCoaSubAccTypeAccType, thePDCIssue.HeadOfExpenseCoaSubAccTypeAccType, true));
            values.Add(new FieldValue("HeadOfExpenseCoaSubCoaControlAccName", original_PDCIssue.HeadOfExpenseCoaSubCoaControlAccName, thePDCIssue.HeadOfExpenseCoaSubCoaControlAccName, true));
            values.Add(new FieldValue("HeadOfExpenseCoaSubCoaMainAccName", original_PDCIssue.HeadOfExpenseCoaSubCoaMainAccName, thePDCIssue.HeadOfExpenseCoaSubCoaMainAccName, true));
            values.Add(new FieldValue("BankAccountHOA", original_PDCIssue.BankAccountHOA, thePDCIssue.BankAccountHOA));
            values.Add(new FieldValue("BankAccountHOAAccName", original_PDCIssue.BankAccountHOAAccName, thePDCIssue.BankAccountHOAAccName, true));
            values.Add(new FieldValue("BankAccountHOAAccBalTypeAccBalType", original_PDCIssue.BankAccountHOAAccBalTypeAccBalType, thePDCIssue.BankAccountHOAAccBalTypeAccBalType, true));
            values.Add(new FieldValue("BankAccountHOAAccCurrencyAccCurrencyName", original_PDCIssue.BankAccountHOAAccCurrencyAccCurrencyName, thePDCIssue.BankAccountHOAAccCurrencyAccCurrencyName, true));
            values.Add(new FieldValue("BankAccountHOAAccDestAccDest", original_PDCIssue.BankAccountHOAAccDestAccDest, thePDCIssue.BankAccountHOAAccDestAccDest, true));
            values.Add(new FieldValue("BankAccountHOAAccDestCompanyTypeDescription", original_PDCIssue.BankAccountHOAAccDestCompanyTypeDescription, thePDCIssue.BankAccountHOAAccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("BankAccountHOAAccFundAccFundName", original_PDCIssue.BankAccountHOAAccFundAccFundName, thePDCIssue.BankAccountHOAAccFundAccFundName, true));
            values.Add(new FieldValue("BankAccountHOAAccSubTypeAccSubType", original_PDCIssue.BankAccountHOAAccSubTypeAccSubType, thePDCIssue.BankAccountHOAAccSubTypeAccSubType, true));
            values.Add(new FieldValue("BankAccountHOAAccTypeAccType", original_PDCIssue.BankAccountHOAAccTypeAccType, thePDCIssue.BankAccountHOAAccTypeAccType, true));
            values.Add(new FieldValue("BankAccountHOACoaControlAccName", original_PDCIssue.BankAccountHOACoaControlAccName, thePDCIssue.BankAccountHOACoaControlAccName, true));
            values.Add(new FieldValue("BankAccountHOACoaControlAccBalTypeAccBalType", original_PDCIssue.BankAccountHOACoaControlAccBalTypeAccBalType, thePDCIssue.BankAccountHOACoaControlAccBalTypeAccBalType, true));
            values.Add(new FieldValue("BankAccountHOACoaControlAccDestAccDest", original_PDCIssue.BankAccountHOACoaControlAccDestAccDest, thePDCIssue.BankAccountHOACoaControlAccDestAccDest, true));
            values.Add(new FieldValue("BankAccountHOACoaControlAccTypeAccType", original_PDCIssue.BankAccountHOACoaControlAccTypeAccType, thePDCIssue.BankAccountHOACoaControlAccTypeAccType, true));
            values.Add(new FieldValue("BankAccountHOACoaControlCompTypeDescription", original_PDCIssue.BankAccountHOACoaControlCompTypeDescription, thePDCIssue.BankAccountHOACoaControlCompTypeDescription, true));
            values.Add(new FieldValue("BankAccountHOACoaMainAccName", original_PDCIssue.BankAccountHOACoaMainAccName, thePDCIssue.BankAccountHOACoaMainAccName, true));
            values.Add(new FieldValue("BankAccountHOACoaMainAccBalTypeAccBalType", original_PDCIssue.BankAccountHOACoaMainAccBalTypeAccBalType, thePDCIssue.BankAccountHOACoaMainAccBalTypeAccBalType, true));
            values.Add(new FieldValue("BankAccountHOACoaMainAccDestAccDest", original_PDCIssue.BankAccountHOACoaMainAccDestAccDest, thePDCIssue.BankAccountHOACoaMainAccDestAccDest, true));
            values.Add(new FieldValue("BankAccountHOACoaMainAccFundAccFundName", original_PDCIssue.BankAccountHOACoaMainAccFundAccFundName, thePDCIssue.BankAccountHOACoaMainAccFundAccFundName, true));
            values.Add(new FieldValue("BankAccountHOACoaMainAccTypeAccType", original_PDCIssue.BankAccountHOACoaMainAccTypeAccType, thePDCIssue.BankAccountHOACoaMainAccTypeAccType, true));
            values.Add(new FieldValue("BankAccountHOACoaMainCoaControlAccName", original_PDCIssue.BankAccountHOACoaMainCoaControlAccName, thePDCIssue.BankAccountHOACoaMainCoaControlAccName, true));
            values.Add(new FieldValue("BankAccountHOACoaSubAccName", original_PDCIssue.BankAccountHOACoaSubAccName, thePDCIssue.BankAccountHOACoaSubAccName, true));
            values.Add(new FieldValue("BankAccountHOACoaSubAccBalTypeAccBalType", original_PDCIssue.BankAccountHOACoaSubAccBalTypeAccBalType, thePDCIssue.BankAccountHOACoaSubAccBalTypeAccBalType, true));
            values.Add(new FieldValue("BankAccountHOACoaSubAccDestAccDest", original_PDCIssue.BankAccountHOACoaSubAccDestAccDest, thePDCIssue.BankAccountHOACoaSubAccDestAccDest, true));
            values.Add(new FieldValue("BankAccountHOACoaSubAccFundAccFundName", original_PDCIssue.BankAccountHOACoaSubAccFundAccFundName, thePDCIssue.BankAccountHOACoaSubAccFundAccFundName, true));
            values.Add(new FieldValue("BankAccountHOACoaSubAccTypeAccType", original_PDCIssue.BankAccountHOACoaSubAccTypeAccType, thePDCIssue.BankAccountHOACoaSubAccTypeAccType, true));
            values.Add(new FieldValue("BankAccountHOACoaSubCoaControlAccName", original_PDCIssue.BankAccountHOACoaSubCoaControlAccName, thePDCIssue.BankAccountHOACoaSubCoaControlAccName, true));
            values.Add(new FieldValue("BankAccountHOACoaSubCoaMainAccName", original_PDCIssue.BankAccountHOACoaSubCoaMainAccName, thePDCIssue.BankAccountHOACoaSubCoaMainAccName, true));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.PDCIssue thePDCIssue, MyCompany.Data.Objects.PDCIssue original_PDCIssue, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "PDCIssue";
            args.View = dataView;
            args.Values = CreateFieldValues(thePDCIssue, original_PDCIssue);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("PDCIssue", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(thePDCIssue);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.PDCIssue thePDCIssue, MyCompany.Data.Objects.PDCIssue original_PDCIssue)
        {
            return ExecuteAction(thePDCIssue, original_PDCIssue, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.PDCIssue thePDCIssue)
        {
            return Update(thePDCIssue, SelectSingle(thePDCIssue.PDCRID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.PDCIssue thePDCIssue)
        {
            return ExecuteAction(thePDCIssue, new PDCIssue(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.PDCIssue thePDCIssue)
        {
            return ExecuteAction(thePDCIssue, thePDCIssue, "Select", "Delete", DeleteView);
        }
    }
}
