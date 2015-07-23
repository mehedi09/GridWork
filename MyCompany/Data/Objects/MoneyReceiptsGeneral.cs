using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class MoneyReceiptsGeneral
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _moneyReceiptsID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _mRDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _mRNo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _plotSaleID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _payCatID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _payCatCategory;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _pCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _receAmount;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _modeofReceiptID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modeofReceiptDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _applicantId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accSubNameID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accSubNameAccSubName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accSubNameAccSubTypeAccSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _fileno;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _checkno;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _checkDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _checkPostDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _checkBankName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankBranch;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _dlt;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _description;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _multiPayment;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _cancelMR;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _cancelDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _receiptType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _gName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _gFathersName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _gaddress;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _vide;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _created_BY;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _created_DT;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _updated_BY;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _updated_DT;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _remarks;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _displayAction;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accFundID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _coaDetailID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaDetailAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaDetailAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaDetailAccCurrencyAccCurrencyName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaDetailAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaDetailAccDestCompanyTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaDetailAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaDetailAccSubTypeAccSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaDetailAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaDetailCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaDetailCoaControlAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaDetailCoaControlAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaDetailCoaControlAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaDetailCoaControlCompTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaDetailCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaDetailCoaMainAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaDetailCoaMainAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaDetailCoaMainAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaDetailCoaMainAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaDetailCoaMainCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaDetailCoaSubAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaDetailCoaSubAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaDetailCoaSubAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaDetailCoaSubAccFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaDetailCoaSubAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaDetailCoaSubCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaDetailCoaSubCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accTranID;
        
        public MoneyReceiptsGeneral()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public long? MoneyReceiptsID
        {
            get
            {
                return _moneyReceiptsID;
            }
            set
            {
                _moneyReceiptsID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public DateTime? MRDate
        {
            get
            {
                return _mRDate;
            }
            set
            {
                _mRDate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string MRNo
        {
            get
            {
                return _mRNo;
            }
            set
            {
                _mRNo = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public long? PlotSaleID
        {
            get
            {
                return _plotSaleID;
            }
            set
            {
                _plotSaleID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
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
        public int? PCode
        {
            get
            {
                return _pCode;
            }
            set
            {
                _pCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public decimal? ReceAmount
        {
            get
            {
                return _receAmount;
            }
            set
            {
                _receAmount = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
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
        public int? ApplicantId
        {
            get
            {
                return _applicantId;
            }
            set
            {
                _applicantId = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public int? AccSubNameID
        {
            get
            {
                return _accSubNameID;
            }
            set
            {
                _accSubNameID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccSubNameAccSubName
        {
            get
            {
                return _accSubNameAccSubName;
            }
            set
            {
                _accSubNameAccSubName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccSubNameAccSubTypeAccSubType
        {
            get
            {
                return _accSubNameAccSubTypeAccSubType;
            }
            set
            {
                _accSubNameAccSubTypeAccSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Fileno
        {
            get
            {
                return _fileno;
            }
            set
            {
                _fileno = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Checkno
        {
            get
            {
                return _checkno;
            }
            set
            {
                _checkno = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? CheckDate
        {
            get
            {
                return _checkDate;
            }
            set
            {
                _checkDate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? CheckPostDate
        {
            get
            {
                return _checkPostDate;
            }
            set
            {
                _checkPostDate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CheckBankName
        {
            get
            {
                return _checkBankName;
            }
            set
            {
                _checkBankName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankBranch
        {
            get
            {
                return _bankBranch;
            }
            set
            {
                _bankBranch = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? Dlt
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
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? MultiPayment
        {
            get
            {
                return _multiPayment;
            }
            set
            {
                _multiPayment = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? CancelMR
        {
            get
            {
                return _cancelMR;
            }
            set
            {
                _cancelMR = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? CancelDate
        {
            get
            {
                return _cancelDate;
            }
            set
            {
                _cancelDate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? ReceiptType
        {
            get
            {
                return _receiptType;
            }
            set
            {
                _receiptType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string GName
        {
            get
            {
                return _gName;
            }
            set
            {
                _gName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string GFathersName
        {
            get
            {
                return _gFathersName;
            }
            set
            {
                _gFathersName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Gaddress
        {
            get
            {
                return _gaddress;
            }
            set
            {
                _gaddress = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string vide
        {
            get
            {
                return _vide;
            }
            set
            {
                _vide = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Created_BY
        {
            get
            {
                return _created_BY;
            }
            set
            {
                _created_BY = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? Created_DT
        {
            get
            {
                return _created_DT;
            }
            set
            {
                _created_DT = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Updated_BY
        {
            get
            {
                return _updated_BY;
            }
            set
            {
                _updated_BY = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? Updated_DT
        {
            get
            {
                return _updated_DT;
            }
            set
            {
                _updated_DT = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Remarks
        {
            get
            {
                return _remarks;
            }
            set
            {
                _remarks = value;
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
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
        public string CoaDetailAccName
        {
            get
            {
                return _coaDetailAccName;
            }
            set
            {
                _coaDetailAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaDetailAccBalTypeAccBalType
        {
            get
            {
                return _coaDetailAccBalTypeAccBalType;
            }
            set
            {
                _coaDetailAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaDetailAccCurrencyAccCurrencyName
        {
            get
            {
                return _coaDetailAccCurrencyAccCurrencyName;
            }
            set
            {
                _coaDetailAccCurrencyAccCurrencyName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaDetailAccDestAccDest
        {
            get
            {
                return _coaDetailAccDestAccDest;
            }
            set
            {
                _coaDetailAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaDetailAccDestCompanyTypeDescription
        {
            get
            {
                return _coaDetailAccDestCompanyTypeDescription;
            }
            set
            {
                _coaDetailAccDestCompanyTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaDetailAccFundAccFundCode
        {
            get
            {
                return _coaDetailAccFundAccFundCode;
            }
            set
            {
                _coaDetailAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaDetailAccSubTypeAccSubType
        {
            get
            {
                return _coaDetailAccSubTypeAccSubType;
            }
            set
            {
                _coaDetailAccSubTypeAccSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaDetailAccTypeAccType
        {
            get
            {
                return _coaDetailAccTypeAccType;
            }
            set
            {
                _coaDetailAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaDetailCoaControlAccName
        {
            get
            {
                return _coaDetailCoaControlAccName;
            }
            set
            {
                _coaDetailCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaDetailCoaControlAccBalTypeAccBalType
        {
            get
            {
                return _coaDetailCoaControlAccBalTypeAccBalType;
            }
            set
            {
                _coaDetailCoaControlAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaDetailCoaControlAccDestAccDest
        {
            get
            {
                return _coaDetailCoaControlAccDestAccDest;
            }
            set
            {
                _coaDetailCoaControlAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaDetailCoaControlAccTypeAccType
        {
            get
            {
                return _coaDetailCoaControlAccTypeAccType;
            }
            set
            {
                _coaDetailCoaControlAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaDetailCoaControlCompTypeDescription
        {
            get
            {
                return _coaDetailCoaControlCompTypeDescription;
            }
            set
            {
                _coaDetailCoaControlCompTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaDetailCoaMainAccName
        {
            get
            {
                return _coaDetailCoaMainAccName;
            }
            set
            {
                _coaDetailCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaDetailCoaMainAccBalTypeAccBalType
        {
            get
            {
                return _coaDetailCoaMainAccBalTypeAccBalType;
            }
            set
            {
                _coaDetailCoaMainAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaDetailCoaMainAccDestAccDest
        {
            get
            {
                return _coaDetailCoaMainAccDestAccDest;
            }
            set
            {
                _coaDetailCoaMainAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaDetailCoaMainAccFundAccFundCode
        {
            get
            {
                return _coaDetailCoaMainAccFundAccFundCode;
            }
            set
            {
                _coaDetailCoaMainAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaDetailCoaMainAccTypeAccType
        {
            get
            {
                return _coaDetailCoaMainAccTypeAccType;
            }
            set
            {
                _coaDetailCoaMainAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaDetailCoaMainCoaControlAccName
        {
            get
            {
                return _coaDetailCoaMainCoaControlAccName;
            }
            set
            {
                _coaDetailCoaMainCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaDetailCoaSubAccName
        {
            get
            {
                return _coaDetailCoaSubAccName;
            }
            set
            {
                _coaDetailCoaSubAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaDetailCoaSubAccBalTypeAccBalType
        {
            get
            {
                return _coaDetailCoaSubAccBalTypeAccBalType;
            }
            set
            {
                _coaDetailCoaSubAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaDetailCoaSubAccDestAccDest
        {
            get
            {
                return _coaDetailCoaSubAccDestAccDest;
            }
            set
            {
                _coaDetailCoaSubAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaDetailCoaSubAccFundAccFundCode
        {
            get
            {
                return _coaDetailCoaSubAccFundAccFundCode;
            }
            set
            {
                _coaDetailCoaSubAccFundAccFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaDetailCoaSubAccTypeAccType
        {
            get
            {
                return _coaDetailCoaSubAccTypeAccType;
            }
            set
            {
                _coaDetailCoaSubAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaDetailCoaSubCoaControlAccName
        {
            get
            {
                return _coaDetailCoaSubCoaControlAccName;
            }
            set
            {
                _coaDetailCoaSubCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoaDetailCoaSubCoaMainAccName
        {
            get
            {
                return _coaDetailCoaSubCoaMainAccName;
            }
            set
            {
                _coaDetailCoaSubCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? AccTranID
        {
            get
            {
                return _accTranID;
            }
            set
            {
                _accTranID = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.MoneyReceiptsGeneral> Select(
                    long? moneyReceiptsID, 
                    DateTime? mRDate, 
                    string mRNo, 
                    long? plotSaleID, 
                    int? payCatID, 
                    string payCatCategory, 
                    int? pCode, 
                    decimal? receAmount, 
                    int? modeofReceiptID, 
                    string modeofReceiptDescription, 
                    int? applicantId, 
                    int? accSubNameID, 
                    string accSubNameAccSubName, 
                    string accSubNameAccSubTypeAccSubType, 
                    string fileno, 
                    string checkno, 
                    DateTime? checkDate, 
                    DateTime? checkPostDate, 
                    string checkBankName, 
                    string bankBranch, 
                    bool? dlt, 
                    string description, 
                    bool? multiPayment, 
                    bool? cancelMR, 
                    DateTime? cancelDate, 
                    bool? receiptType, 
                    string gName, 
                    string gFathersName, 
                    string gaddress, 
                    string vide, 
                    string created_BY, 
                    DateTime? created_DT, 
                    string updated_BY, 
                    DateTime? updated_DT, 
                    string remarks, 
                    bool? displayAction, 
                    int? accFundID, 
                    int? coaDetailID, 
                    string coaDetailAccName, 
                    string coaDetailAccBalTypeAccBalType, 
                    string coaDetailAccCurrencyAccCurrencyName, 
                    string coaDetailAccDestAccDest, 
                    string coaDetailAccDestCompanyTypeDescription, 
                    string coaDetailAccFundAccFundCode, 
                    string coaDetailAccSubTypeAccSubType, 
                    string coaDetailAccTypeAccType, 
                    string coaDetailCoaControlAccName, 
                    string coaDetailCoaControlAccBalTypeAccBalType, 
                    string coaDetailCoaControlAccDestAccDest, 
                    string coaDetailCoaControlAccTypeAccType, 
                    string coaDetailCoaControlCompTypeDescription, 
                    string coaDetailCoaMainAccName, 
                    string coaDetailCoaMainAccBalTypeAccBalType, 
                    string coaDetailCoaMainAccDestAccDest, 
                    string coaDetailCoaMainAccFundAccFundCode, 
                    string coaDetailCoaMainAccTypeAccType, 
                    string coaDetailCoaMainCoaControlAccName, 
                    string coaDetailCoaSubAccName, 
                    string coaDetailCoaSubAccBalTypeAccBalType, 
                    string coaDetailCoaSubAccDestAccDest, 
                    string coaDetailCoaSubAccFundAccFundCode, 
                    string coaDetailCoaSubAccTypeAccType, 
                    string coaDetailCoaSubCoaControlAccName, 
                    string coaDetailCoaSubCoaMainAccName, 
                    int? accTranID)
        {
            return new MoneyReceiptsGeneralFactory().Select(moneyReceiptsID, mRDate, mRNo, plotSaleID, payCatID, payCatCategory, pCode, receAmount, modeofReceiptID, modeofReceiptDescription, applicantId, accSubNameID, accSubNameAccSubName, accSubNameAccSubTypeAccSubType, fileno, checkno, checkDate, checkPostDate, checkBankName, bankBranch, dlt, description, multiPayment, cancelMR, cancelDate, receiptType, gName, gFathersName, gaddress, vide, created_BY, created_DT, updated_BY, updated_DT, remarks, displayAction, accFundID, coaDetailID, coaDetailAccName, coaDetailAccBalTypeAccBalType, coaDetailAccCurrencyAccCurrencyName, coaDetailAccDestAccDest, coaDetailAccDestCompanyTypeDescription, coaDetailAccFundAccFundCode, coaDetailAccSubTypeAccSubType, coaDetailAccTypeAccType, coaDetailCoaControlAccName, coaDetailCoaControlAccBalTypeAccBalType, coaDetailCoaControlAccDestAccDest, coaDetailCoaControlAccTypeAccType, coaDetailCoaControlCompTypeDescription, coaDetailCoaMainAccName, coaDetailCoaMainAccBalTypeAccBalType, coaDetailCoaMainAccDestAccDest, coaDetailCoaMainAccFundAccFundCode, coaDetailCoaMainAccTypeAccType, coaDetailCoaMainCoaControlAccName, coaDetailCoaSubAccName, coaDetailCoaSubAccBalTypeAccBalType, coaDetailCoaSubAccDestAccDest, coaDetailCoaSubAccFundAccFundCode, coaDetailCoaSubAccTypeAccType, coaDetailCoaSubCoaControlAccName, coaDetailCoaSubCoaMainAccName, accTranID);
        }
        
        public static List<MyCompany.Data.Objects.MoneyReceiptsGeneral> Select(MyCompany.Data.Objects.MoneyReceiptsGeneral qbe)
        {
            return new MoneyReceiptsGeneralFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.MoneyReceiptsGeneral> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new MoneyReceiptsGeneralFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.MoneyReceiptsGeneral> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new MoneyReceiptsGeneralFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.MoneyReceiptsGeneral> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new MoneyReceiptsGeneralFactory().Select(filter, sort, MoneyReceiptsGeneralFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.MoneyReceiptsGeneral> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new MoneyReceiptsGeneralFactory().Select(filter, sort, MoneyReceiptsGeneralFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.MoneyReceiptsGeneral> Select(string filter, BusinessObjectParameters parameters)
        {
            return new MoneyReceiptsGeneralFactory().Select(filter, null, MoneyReceiptsGeneralFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.MoneyReceiptsGeneral> Select(string filter, params FieldValue[] parameters)
        {
            return new MoneyReceiptsGeneralFactory().Select(filter, null, MoneyReceiptsGeneralFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.MoneyReceiptsGeneral SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new MoneyReceiptsGeneralFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.MoneyReceiptsGeneral SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new MoneyReceiptsGeneralFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.MoneyReceiptsGeneral SelectSingle(long? moneyReceiptsID)
        {
            return new MoneyReceiptsGeneralFactory().SelectSingle(moneyReceiptsID);
        }
        
        public int Insert()
        {
            return new MoneyReceiptsGeneralFactory().Insert(this);
        }
        
        public int Update()
        {
            return new MoneyReceiptsGeneralFactory().Update(this);
        }
        
        public int Delete()
        {
            return new MoneyReceiptsGeneralFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("MoneyReceiptsID: {0}", this.MoneyReceiptsID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class MoneyReceiptsGeneralFactory
    {
        
        public MoneyReceiptsGeneralFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("MoneyReceiptsGeneral");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("MoneyReceiptsGeneral");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("MoneyReceiptsGeneral");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("MoneyReceiptsGeneral");
            }
        }
        
        public static MoneyReceiptsGeneralFactory Create()
        {
            return new MoneyReceiptsGeneralFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    long? moneyReceiptsID, 
                    DateTime? mRDate, 
                    string mRNo, 
                    long? plotSaleID, 
                    int? payCatID, 
                    string payCatCategory, 
                    int? pCode, 
                    decimal? receAmount, 
                    int? modeofReceiptID, 
                    string modeofReceiptDescription, 
                    int? applicantId, 
                    int? accSubNameID, 
                    string accSubNameAccSubName, 
                    string accSubNameAccSubTypeAccSubType, 
                    string fileno, 
                    string checkno, 
                    DateTime? checkDate, 
                    DateTime? checkPostDate, 
                    string checkBankName, 
                    string bankBranch, 
                    bool? dlt, 
                    string description, 
                    bool? multiPayment, 
                    bool? cancelMR, 
                    DateTime? cancelDate, 
                    bool? receiptType, 
                    string gName, 
                    string gFathersName, 
                    string gaddress, 
                    string vide, 
                    string created_BY, 
                    DateTime? created_DT, 
                    string updated_BY, 
                    DateTime? updated_DT, 
                    string remarks, 
                    bool? displayAction, 
                    int? accFundID, 
                    int? coaDetailID, 
                    string coaDetailAccName, 
                    string coaDetailAccBalTypeAccBalType, 
                    string coaDetailAccCurrencyAccCurrencyName, 
                    string coaDetailAccDestAccDest, 
                    string coaDetailAccDestCompanyTypeDescription, 
                    string coaDetailAccFundAccFundCode, 
                    string coaDetailAccSubTypeAccSubType, 
                    string coaDetailAccTypeAccType, 
                    string coaDetailCoaControlAccName, 
                    string coaDetailCoaControlAccBalTypeAccBalType, 
                    string coaDetailCoaControlAccDestAccDest, 
                    string coaDetailCoaControlAccTypeAccType, 
                    string coaDetailCoaControlCompTypeDescription, 
                    string coaDetailCoaMainAccName, 
                    string coaDetailCoaMainAccBalTypeAccBalType, 
                    string coaDetailCoaMainAccDestAccDest, 
                    string coaDetailCoaMainAccFundAccFundCode, 
                    string coaDetailCoaMainAccTypeAccType, 
                    string coaDetailCoaMainCoaControlAccName, 
                    string coaDetailCoaSubAccName, 
                    string coaDetailCoaSubAccBalTypeAccBalType, 
                    string coaDetailCoaSubAccDestAccDest, 
                    string coaDetailCoaSubAccFundAccFundCode, 
                    string coaDetailCoaSubAccTypeAccType, 
                    string coaDetailCoaSubCoaControlAccName, 
                    string coaDetailCoaSubCoaMainAccName, 
                    int? accTranID, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (moneyReceiptsID.HasValue)
            	filter.Add(("MoneyReceiptsID:=" + moneyReceiptsID.Value.ToString()));
            if (mRDate.HasValue)
            	filter.Add(("MRDate:=" + mRDate.Value.ToString()));
            if (!(String.IsNullOrEmpty(mRNo)))
            	filter.Add(("MRNo:*" + mRNo));
            if (plotSaleID.HasValue)
            	filter.Add(("PlotSaleID:=" + plotSaleID.Value.ToString()));
            if (payCatID.HasValue)
            	filter.Add(("PayCatID:=" + payCatID.Value.ToString()));
            if (!(String.IsNullOrEmpty(payCatCategory)))
            	filter.Add(("PayCatCategory:*" + payCatCategory));
            if (pCode.HasValue)
            	filter.Add(("PCode:=" + pCode.Value.ToString()));
            if (receAmount.HasValue)
            	filter.Add(("ReceAmount:=" + receAmount.Value.ToString()));
            if (modeofReceiptID.HasValue)
            	filter.Add(("ModeofReceiptID:=" + modeofReceiptID.Value.ToString()));
            if (!(String.IsNullOrEmpty(modeofReceiptDescription)))
            	filter.Add(("ModeofReceiptDescription:*" + modeofReceiptDescription));
            if (applicantId.HasValue)
            	filter.Add(("ApplicantId:=" + applicantId.Value.ToString()));
            if (accSubNameID.HasValue)
            	filter.Add(("AccSubNameID:=" + accSubNameID.Value.ToString()));
            if (!(String.IsNullOrEmpty(accSubNameAccSubName)))
            	filter.Add(("AccSubNameAccSubName:*" + accSubNameAccSubName));
            if (!(String.IsNullOrEmpty(accSubNameAccSubTypeAccSubType)))
            	filter.Add(("AccSubNameAccSubTypeAccSubType:*" + accSubNameAccSubTypeAccSubType));
            if (!(String.IsNullOrEmpty(fileno)))
            	filter.Add(("Fileno:*" + fileno));
            if (!(String.IsNullOrEmpty(checkno)))
            	filter.Add(("Checkno:*" + checkno));
            if (checkDate.HasValue)
            	filter.Add(("CheckDate:=" + checkDate.Value.ToString()));
            if (checkPostDate.HasValue)
            	filter.Add(("CheckPostDate:=" + checkPostDate.Value.ToString()));
            if (!(String.IsNullOrEmpty(checkBankName)))
            	filter.Add(("CheckBankName:*" + checkBankName));
            if (!(String.IsNullOrEmpty(bankBranch)))
            	filter.Add(("BankBranch:*" + bankBranch));
            if (dlt.HasValue)
            	filter.Add(("Dlt:=" + dlt.Value.ToString()));
            if (!(String.IsNullOrEmpty(description)))
            	filter.Add(("Description:*" + description));
            if (multiPayment.HasValue)
            	filter.Add(("MultiPayment:=" + multiPayment.Value.ToString()));
            if (cancelMR.HasValue)
            	filter.Add(("CancelMR:=" + cancelMR.Value.ToString()));
            if (cancelDate.HasValue)
            	filter.Add(("CancelDate:=" + cancelDate.Value.ToString()));
            if (receiptType.HasValue)
            	filter.Add(("ReceiptType:=" + receiptType.Value.ToString()));
            if (!(String.IsNullOrEmpty(gName)))
            	filter.Add(("GName:*" + gName));
            if (!(String.IsNullOrEmpty(gFathersName)))
            	filter.Add(("GFathersName:*" + gFathersName));
            if (!(String.IsNullOrEmpty(gaddress)))
            	filter.Add(("Gaddress:*" + gaddress));
            if (!(String.IsNullOrEmpty(vide)))
            	filter.Add(("vide:*" + vide));
            if (!(String.IsNullOrEmpty(created_BY)))
            	filter.Add(("Created_BY:*" + created_BY));
            if (created_DT.HasValue)
            	filter.Add(("Created_DT:=" + created_DT.Value.ToString()));
            if (!(String.IsNullOrEmpty(updated_BY)))
            	filter.Add(("Updated_BY:*" + updated_BY));
            if (updated_DT.HasValue)
            	filter.Add(("Updated_DT:=" + updated_DT.Value.ToString()));
            if (!(String.IsNullOrEmpty(remarks)))
            	filter.Add(("Remarks:*" + remarks));
            if (displayAction.HasValue)
            	filter.Add(("DisplayAction:=" + displayAction.Value.ToString()));
            if (accFundID.HasValue)
            	filter.Add(("AccFundID:=" + accFundID.Value.ToString()));
            if (coaDetailID.HasValue)
            	filter.Add(("CoaDetailID:=" + coaDetailID.Value.ToString()));
            if (!(String.IsNullOrEmpty(coaDetailAccName)))
            	filter.Add(("CoaDetailAccName:*" + coaDetailAccName));
            if (!(String.IsNullOrEmpty(coaDetailAccBalTypeAccBalType)))
            	filter.Add(("CoaDetailAccBalTypeAccBalType:*" + coaDetailAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(coaDetailAccCurrencyAccCurrencyName)))
            	filter.Add(("CoaDetailAccCurrencyAccCurrencyName:*" + coaDetailAccCurrencyAccCurrencyName));
            if (!(String.IsNullOrEmpty(coaDetailAccDestAccDest)))
            	filter.Add(("CoaDetailAccDestAccDest:*" + coaDetailAccDestAccDest));
            if (!(String.IsNullOrEmpty(coaDetailAccDestCompanyTypeDescription)))
            	filter.Add(("CoaDetailAccDestCompanyTypeDescription:*" + coaDetailAccDestCompanyTypeDescription));
            if (!(String.IsNullOrEmpty(coaDetailAccFundAccFundCode)))
            	filter.Add(("CoaDetailAccFundAccFundCode:*" + coaDetailAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(coaDetailAccSubTypeAccSubType)))
            	filter.Add(("CoaDetailAccSubTypeAccSubType:*" + coaDetailAccSubTypeAccSubType));
            if (!(String.IsNullOrEmpty(coaDetailAccTypeAccType)))
            	filter.Add(("CoaDetailAccTypeAccType:*" + coaDetailAccTypeAccType));
            if (!(String.IsNullOrEmpty(coaDetailCoaControlAccName)))
            	filter.Add(("CoaDetailCoaControlAccName:*" + coaDetailCoaControlAccName));
            if (!(String.IsNullOrEmpty(coaDetailCoaControlAccBalTypeAccBalType)))
            	filter.Add(("CoaDetailCoaControlAccBalTypeAccBalType:*" + coaDetailCoaControlAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(coaDetailCoaControlAccDestAccDest)))
            	filter.Add(("CoaDetailCoaControlAccDestAccDest:*" + coaDetailCoaControlAccDestAccDest));
            if (!(String.IsNullOrEmpty(coaDetailCoaControlAccTypeAccType)))
            	filter.Add(("CoaDetailCoaControlAccTypeAccType:*" + coaDetailCoaControlAccTypeAccType));
            if (!(String.IsNullOrEmpty(coaDetailCoaControlCompTypeDescription)))
            	filter.Add(("CoaDetailCoaControlCompTypeDescription:*" + coaDetailCoaControlCompTypeDescription));
            if (!(String.IsNullOrEmpty(coaDetailCoaMainAccName)))
            	filter.Add(("CoaDetailCoaMainAccName:*" + coaDetailCoaMainAccName));
            if (!(String.IsNullOrEmpty(coaDetailCoaMainAccBalTypeAccBalType)))
            	filter.Add(("CoaDetailCoaMainAccBalTypeAccBalType:*" + coaDetailCoaMainAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(coaDetailCoaMainAccDestAccDest)))
            	filter.Add(("CoaDetailCoaMainAccDestAccDest:*" + coaDetailCoaMainAccDestAccDest));
            if (!(String.IsNullOrEmpty(coaDetailCoaMainAccFundAccFundCode)))
            	filter.Add(("CoaDetailCoaMainAccFundAccFundCode:*" + coaDetailCoaMainAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(coaDetailCoaMainAccTypeAccType)))
            	filter.Add(("CoaDetailCoaMainAccTypeAccType:*" + coaDetailCoaMainAccTypeAccType));
            if (!(String.IsNullOrEmpty(coaDetailCoaMainCoaControlAccName)))
            	filter.Add(("CoaDetailCoaMainCoaControlAccName:*" + coaDetailCoaMainCoaControlAccName));
            if (!(String.IsNullOrEmpty(coaDetailCoaSubAccName)))
            	filter.Add(("CoaDetailCoaSubAccName:*" + coaDetailCoaSubAccName));
            if (!(String.IsNullOrEmpty(coaDetailCoaSubAccBalTypeAccBalType)))
            	filter.Add(("CoaDetailCoaSubAccBalTypeAccBalType:*" + coaDetailCoaSubAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(coaDetailCoaSubAccDestAccDest)))
            	filter.Add(("CoaDetailCoaSubAccDestAccDest:*" + coaDetailCoaSubAccDestAccDest));
            if (!(String.IsNullOrEmpty(coaDetailCoaSubAccFundAccFundCode)))
            	filter.Add(("CoaDetailCoaSubAccFundAccFundCode:*" + coaDetailCoaSubAccFundAccFundCode));
            if (!(String.IsNullOrEmpty(coaDetailCoaSubAccTypeAccType)))
            	filter.Add(("CoaDetailCoaSubAccTypeAccType:*" + coaDetailCoaSubAccTypeAccType));
            if (!(String.IsNullOrEmpty(coaDetailCoaSubCoaControlAccName)))
            	filter.Add(("CoaDetailCoaSubCoaControlAccName:*" + coaDetailCoaSubCoaControlAccName));
            if (!(String.IsNullOrEmpty(coaDetailCoaSubCoaMainAccName)))
            	filter.Add(("CoaDetailCoaSubCoaMainAccName:*" + coaDetailCoaSubCoaMainAccName));
            if (accTranID.HasValue)
            	filter.Add(("AccTranID:=" + accTranID.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.MoneyReceiptsGeneral> Select(
                    long? moneyReceiptsID, 
                    DateTime? mRDate, 
                    string mRNo, 
                    long? plotSaleID, 
                    int? payCatID, 
                    string payCatCategory, 
                    int? pCode, 
                    decimal? receAmount, 
                    int? modeofReceiptID, 
                    string modeofReceiptDescription, 
                    int? applicantId, 
                    int? accSubNameID, 
                    string accSubNameAccSubName, 
                    string accSubNameAccSubTypeAccSubType, 
                    string fileno, 
                    string checkno, 
                    DateTime? checkDate, 
                    DateTime? checkPostDate, 
                    string checkBankName, 
                    string bankBranch, 
                    bool? dlt, 
                    string description, 
                    bool? multiPayment, 
                    bool? cancelMR, 
                    DateTime? cancelDate, 
                    bool? receiptType, 
                    string gName, 
                    string gFathersName, 
                    string gaddress, 
                    string vide, 
                    string created_BY, 
                    DateTime? created_DT, 
                    string updated_BY, 
                    DateTime? updated_DT, 
                    string remarks, 
                    bool? displayAction, 
                    int? accFundID, 
                    int? coaDetailID, 
                    string coaDetailAccName, 
                    string coaDetailAccBalTypeAccBalType, 
                    string coaDetailAccCurrencyAccCurrencyName, 
                    string coaDetailAccDestAccDest, 
                    string coaDetailAccDestCompanyTypeDescription, 
                    string coaDetailAccFundAccFundCode, 
                    string coaDetailAccSubTypeAccSubType, 
                    string coaDetailAccTypeAccType, 
                    string coaDetailCoaControlAccName, 
                    string coaDetailCoaControlAccBalTypeAccBalType, 
                    string coaDetailCoaControlAccDestAccDest, 
                    string coaDetailCoaControlAccTypeAccType, 
                    string coaDetailCoaControlCompTypeDescription, 
                    string coaDetailCoaMainAccName, 
                    string coaDetailCoaMainAccBalTypeAccBalType, 
                    string coaDetailCoaMainAccDestAccDest, 
                    string coaDetailCoaMainAccFundAccFundCode, 
                    string coaDetailCoaMainAccTypeAccType, 
                    string coaDetailCoaMainCoaControlAccName, 
                    string coaDetailCoaSubAccName, 
                    string coaDetailCoaSubAccBalTypeAccBalType, 
                    string coaDetailCoaSubAccDestAccDest, 
                    string coaDetailCoaSubAccFundAccFundCode, 
                    string coaDetailCoaSubAccTypeAccType, 
                    string coaDetailCoaSubCoaControlAccName, 
                    string coaDetailCoaSubCoaMainAccName, 
                    int? accTranID, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(moneyReceiptsID, mRDate, mRNo, plotSaleID, payCatID, payCatCategory, pCode, receAmount, modeofReceiptID, modeofReceiptDescription, applicantId, accSubNameID, accSubNameAccSubName, accSubNameAccSubTypeAccSubType, fileno, checkno, checkDate, checkPostDate, checkBankName, bankBranch, dlt, description, multiPayment, cancelMR, cancelDate, receiptType, gName, gFathersName, gaddress, vide, created_BY, created_DT, updated_BY, updated_DT, remarks, displayAction, accFundID, coaDetailID, coaDetailAccName, coaDetailAccBalTypeAccBalType, coaDetailAccCurrencyAccCurrencyName, coaDetailAccDestAccDest, coaDetailAccDestCompanyTypeDescription, coaDetailAccFundAccFundCode, coaDetailAccSubTypeAccSubType, coaDetailAccTypeAccType, coaDetailCoaControlAccName, coaDetailCoaControlAccBalTypeAccBalType, coaDetailCoaControlAccDestAccDest, coaDetailCoaControlAccTypeAccType, coaDetailCoaControlCompTypeDescription, coaDetailCoaMainAccName, coaDetailCoaMainAccBalTypeAccBalType, coaDetailCoaMainAccDestAccDest, coaDetailCoaMainAccFundAccFundCode, coaDetailCoaMainAccTypeAccType, coaDetailCoaMainCoaControlAccName, coaDetailCoaSubAccName, coaDetailCoaSubAccBalTypeAccBalType, coaDetailCoaSubAccDestAccDest, coaDetailCoaSubAccFundAccFundCode, coaDetailCoaSubAccTypeAccType, coaDetailCoaSubCoaControlAccName, coaDetailCoaSubCoaMainAccName, accTranID, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("MoneyReceiptsGeneral", dataView, request);
            return page.ToList<MyCompany.Data.Objects.MoneyReceiptsGeneral>();
        }
        
        public List<MyCompany.Data.Objects.MoneyReceiptsGeneral> Select(MyCompany.Data.Objects.MoneyReceiptsGeneral qbe)
        {
            return Select(qbe.MoneyReceiptsID, qbe.MRDate, qbe.MRNo, qbe.PlotSaleID, qbe.PayCatID, qbe.PayCatCategory, qbe.PCode, qbe.ReceAmount, qbe.ModeofReceiptID, qbe.ModeofReceiptDescription, qbe.ApplicantId, qbe.AccSubNameID, qbe.AccSubNameAccSubName, qbe.AccSubNameAccSubTypeAccSubType, qbe.Fileno, qbe.Checkno, qbe.CheckDate, qbe.CheckPostDate, qbe.CheckBankName, qbe.BankBranch, qbe.Dlt, qbe.Description, qbe.MultiPayment, qbe.CancelMR, qbe.CancelDate, qbe.ReceiptType, qbe.GName, qbe.GFathersName, qbe.Gaddress, qbe.vide, qbe.Created_BY, qbe.Created_DT, qbe.Updated_BY, qbe.Updated_DT, qbe.Remarks, qbe.DisplayAction, qbe.AccFundID, qbe.CoaDetailID, qbe.CoaDetailAccName, qbe.CoaDetailAccBalTypeAccBalType, qbe.CoaDetailAccCurrencyAccCurrencyName, qbe.CoaDetailAccDestAccDest, qbe.CoaDetailAccDestCompanyTypeDescription, qbe.CoaDetailAccFundAccFundCode, qbe.CoaDetailAccSubTypeAccSubType, qbe.CoaDetailAccTypeAccType, qbe.CoaDetailCoaControlAccName, qbe.CoaDetailCoaControlAccBalTypeAccBalType, qbe.CoaDetailCoaControlAccDestAccDest, qbe.CoaDetailCoaControlAccTypeAccType, qbe.CoaDetailCoaControlCompTypeDescription, qbe.CoaDetailCoaMainAccName, qbe.CoaDetailCoaMainAccBalTypeAccBalType, qbe.CoaDetailCoaMainAccDestAccDest, qbe.CoaDetailCoaMainAccFundAccFundCode, qbe.CoaDetailCoaMainAccTypeAccType, qbe.CoaDetailCoaMainCoaControlAccName, qbe.CoaDetailCoaSubAccName, qbe.CoaDetailCoaSubAccBalTypeAccBalType, qbe.CoaDetailCoaSubAccDestAccDest, qbe.CoaDetailCoaSubAccFundAccFundCode, qbe.CoaDetailCoaSubAccTypeAccType, qbe.CoaDetailCoaSubCoaControlAccName, qbe.CoaDetailCoaSubCoaMainAccName, qbe.AccTranID);
        }
        
        public int SelectCount(
                    long? moneyReceiptsID, 
                    DateTime? mRDate, 
                    string mRNo, 
                    long? plotSaleID, 
                    int? payCatID, 
                    string payCatCategory, 
                    int? pCode, 
                    decimal? receAmount, 
                    int? modeofReceiptID, 
                    string modeofReceiptDescription, 
                    int? applicantId, 
                    int? accSubNameID, 
                    string accSubNameAccSubName, 
                    string accSubNameAccSubTypeAccSubType, 
                    string fileno, 
                    string checkno, 
                    DateTime? checkDate, 
                    DateTime? checkPostDate, 
                    string checkBankName, 
                    string bankBranch, 
                    bool? dlt, 
                    string description, 
                    bool? multiPayment, 
                    bool? cancelMR, 
                    DateTime? cancelDate, 
                    bool? receiptType, 
                    string gName, 
                    string gFathersName, 
                    string gaddress, 
                    string vide, 
                    string created_BY, 
                    DateTime? created_DT, 
                    string updated_BY, 
                    DateTime? updated_DT, 
                    string remarks, 
                    bool? displayAction, 
                    int? accFundID, 
                    int? coaDetailID, 
                    string coaDetailAccName, 
                    string coaDetailAccBalTypeAccBalType, 
                    string coaDetailAccCurrencyAccCurrencyName, 
                    string coaDetailAccDestAccDest, 
                    string coaDetailAccDestCompanyTypeDescription, 
                    string coaDetailAccFundAccFundCode, 
                    string coaDetailAccSubTypeAccSubType, 
                    string coaDetailAccTypeAccType, 
                    string coaDetailCoaControlAccName, 
                    string coaDetailCoaControlAccBalTypeAccBalType, 
                    string coaDetailCoaControlAccDestAccDest, 
                    string coaDetailCoaControlAccTypeAccType, 
                    string coaDetailCoaControlCompTypeDescription, 
                    string coaDetailCoaMainAccName, 
                    string coaDetailCoaMainAccBalTypeAccBalType, 
                    string coaDetailCoaMainAccDestAccDest, 
                    string coaDetailCoaMainAccFundAccFundCode, 
                    string coaDetailCoaMainAccTypeAccType, 
                    string coaDetailCoaMainCoaControlAccName, 
                    string coaDetailCoaSubAccName, 
                    string coaDetailCoaSubAccBalTypeAccBalType, 
                    string coaDetailCoaSubAccDestAccDest, 
                    string coaDetailCoaSubAccFundAccFundCode, 
                    string coaDetailCoaSubAccTypeAccType, 
                    string coaDetailCoaSubCoaControlAccName, 
                    string coaDetailCoaSubCoaMainAccName, 
                    int? accTranID, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(moneyReceiptsID, mRDate, mRNo, plotSaleID, payCatID, payCatCategory, pCode, receAmount, modeofReceiptID, modeofReceiptDescription, applicantId, accSubNameID, accSubNameAccSubName, accSubNameAccSubTypeAccSubType, fileno, checkno, checkDate, checkPostDate, checkBankName, bankBranch, dlt, description, multiPayment, cancelMR, cancelDate, receiptType, gName, gFathersName, gaddress, vide, created_BY, created_DT, updated_BY, updated_DT, remarks, displayAction, accFundID, coaDetailID, coaDetailAccName, coaDetailAccBalTypeAccBalType, coaDetailAccCurrencyAccCurrencyName, coaDetailAccDestAccDest, coaDetailAccDestCompanyTypeDescription, coaDetailAccFundAccFundCode, coaDetailAccSubTypeAccSubType, coaDetailAccTypeAccType, coaDetailCoaControlAccName, coaDetailCoaControlAccBalTypeAccBalType, coaDetailCoaControlAccDestAccDest, coaDetailCoaControlAccTypeAccType, coaDetailCoaControlCompTypeDescription, coaDetailCoaMainAccName, coaDetailCoaMainAccBalTypeAccBalType, coaDetailCoaMainAccDestAccDest, coaDetailCoaMainAccFundAccFundCode, coaDetailCoaMainAccTypeAccType, coaDetailCoaMainCoaControlAccName, coaDetailCoaSubAccName, coaDetailCoaSubAccBalTypeAccBalType, coaDetailCoaSubAccDestAccDest, coaDetailCoaSubAccFundAccFundCode, coaDetailCoaSubAccTypeAccType, coaDetailCoaSubCoaControlAccName, coaDetailCoaSubCoaMainAccName, accTranID, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("MoneyReceiptsGeneral", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.MoneyReceiptsGeneral> Select(
                    long? moneyReceiptsID, 
                    DateTime? mRDate, 
                    string mRNo, 
                    long? plotSaleID, 
                    int? payCatID, 
                    string payCatCategory, 
                    int? pCode, 
                    decimal? receAmount, 
                    int? modeofReceiptID, 
                    string modeofReceiptDescription, 
                    int? applicantId, 
                    int? accSubNameID, 
                    string accSubNameAccSubName, 
                    string accSubNameAccSubTypeAccSubType, 
                    string fileno, 
                    string checkno, 
                    DateTime? checkDate, 
                    DateTime? checkPostDate, 
                    string checkBankName, 
                    string bankBranch, 
                    bool? dlt, 
                    string description, 
                    bool? multiPayment, 
                    bool? cancelMR, 
                    DateTime? cancelDate, 
                    bool? receiptType, 
                    string gName, 
                    string gFathersName, 
                    string gaddress, 
                    string vide, 
                    string created_BY, 
                    DateTime? created_DT, 
                    string updated_BY, 
                    DateTime? updated_DT, 
                    string remarks, 
                    bool? displayAction, 
                    int? accFundID, 
                    int? coaDetailID, 
                    string coaDetailAccName, 
                    string coaDetailAccBalTypeAccBalType, 
                    string coaDetailAccCurrencyAccCurrencyName, 
                    string coaDetailAccDestAccDest, 
                    string coaDetailAccDestCompanyTypeDescription, 
                    string coaDetailAccFundAccFundCode, 
                    string coaDetailAccSubTypeAccSubType, 
                    string coaDetailAccTypeAccType, 
                    string coaDetailCoaControlAccName, 
                    string coaDetailCoaControlAccBalTypeAccBalType, 
                    string coaDetailCoaControlAccDestAccDest, 
                    string coaDetailCoaControlAccTypeAccType, 
                    string coaDetailCoaControlCompTypeDescription, 
                    string coaDetailCoaMainAccName, 
                    string coaDetailCoaMainAccBalTypeAccBalType, 
                    string coaDetailCoaMainAccDestAccDest, 
                    string coaDetailCoaMainAccFundAccFundCode, 
                    string coaDetailCoaMainAccTypeAccType, 
                    string coaDetailCoaMainCoaControlAccName, 
                    string coaDetailCoaSubAccName, 
                    string coaDetailCoaSubAccBalTypeAccBalType, 
                    string coaDetailCoaSubAccDestAccDest, 
                    string coaDetailCoaSubAccFundAccFundCode, 
                    string coaDetailCoaSubAccTypeAccType, 
                    string coaDetailCoaSubCoaControlAccName, 
                    string coaDetailCoaSubCoaMainAccName, 
                    int? accTranID)
        {
            return Select(moneyReceiptsID, mRDate, mRNo, plotSaleID, payCatID, payCatCategory, pCode, receAmount, modeofReceiptID, modeofReceiptDescription, applicantId, accSubNameID, accSubNameAccSubName, accSubNameAccSubTypeAccSubType, fileno, checkno, checkDate, checkPostDate, checkBankName, bankBranch, dlt, description, multiPayment, cancelMR, cancelDate, receiptType, gName, gFathersName, gaddress, vide, created_BY, created_DT, updated_BY, updated_DT, remarks, displayAction, accFundID, coaDetailID, coaDetailAccName, coaDetailAccBalTypeAccBalType, coaDetailAccCurrencyAccCurrencyName, coaDetailAccDestAccDest, coaDetailAccDestCompanyTypeDescription, coaDetailAccFundAccFundCode, coaDetailAccSubTypeAccSubType, coaDetailAccTypeAccType, coaDetailCoaControlAccName, coaDetailCoaControlAccBalTypeAccBalType, coaDetailCoaControlAccDestAccDest, coaDetailCoaControlAccTypeAccType, coaDetailCoaControlCompTypeDescription, coaDetailCoaMainAccName, coaDetailCoaMainAccBalTypeAccBalType, coaDetailCoaMainAccDestAccDest, coaDetailCoaMainAccFundAccFundCode, coaDetailCoaMainAccTypeAccType, coaDetailCoaMainCoaControlAccName, coaDetailCoaSubAccName, coaDetailCoaSubAccBalTypeAccBalType, coaDetailCoaSubAccDestAccDest, coaDetailCoaSubAccFundAccFundCode, coaDetailCoaSubAccTypeAccType, coaDetailCoaSubCoaControlAccName, coaDetailCoaSubCoaMainAccName, accTranID, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.MoneyReceiptsGeneral SelectSingle(long? moneyReceiptsID)
        {
            List<MyCompany.Data.Objects.MoneyReceiptsGeneral> list = Select(moneyReceiptsID, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.MoneyReceiptsGeneral> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("MoneyReceiptsGeneral", dataView, request);
            return page.ToList<MyCompany.Data.Objects.MoneyReceiptsGeneral>();
        }
        
        public List<MyCompany.Data.Objects.MoneyReceiptsGeneral> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.MoneyReceiptsGeneral> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.MoneyReceiptsGeneral SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.MoneyReceiptsGeneral> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.MoneyReceiptsGeneral theMoneyReceiptsGeneral, MyCompany.Data.Objects.MoneyReceiptsGeneral original_MoneyReceiptsGeneral)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("MoneyReceiptsID", original_MoneyReceiptsGeneral.MoneyReceiptsID, theMoneyReceiptsGeneral.MoneyReceiptsID, true));
            values.Add(new FieldValue("MRDate", original_MoneyReceiptsGeneral.MRDate, theMoneyReceiptsGeneral.MRDate));
            values.Add(new FieldValue("MRNo", original_MoneyReceiptsGeneral.MRNo, theMoneyReceiptsGeneral.MRNo));
            values.Add(new FieldValue("PlotSaleID", original_MoneyReceiptsGeneral.PlotSaleID, theMoneyReceiptsGeneral.PlotSaleID));
            values.Add(new FieldValue("PayCatID", original_MoneyReceiptsGeneral.PayCatID, theMoneyReceiptsGeneral.PayCatID));
            values.Add(new FieldValue("PayCatCategory", original_MoneyReceiptsGeneral.PayCatCategory, theMoneyReceiptsGeneral.PayCatCategory, true));
            values.Add(new FieldValue("PCode", original_MoneyReceiptsGeneral.PCode, theMoneyReceiptsGeneral.PCode));
            values.Add(new FieldValue("ReceAmount", original_MoneyReceiptsGeneral.ReceAmount, theMoneyReceiptsGeneral.ReceAmount));
            values.Add(new FieldValue("ModeofReceiptID", original_MoneyReceiptsGeneral.ModeofReceiptID, theMoneyReceiptsGeneral.ModeofReceiptID));
            values.Add(new FieldValue("ModeofReceiptDescription", original_MoneyReceiptsGeneral.ModeofReceiptDescription, theMoneyReceiptsGeneral.ModeofReceiptDescription, true));
            values.Add(new FieldValue("ApplicantId", original_MoneyReceiptsGeneral.ApplicantId, theMoneyReceiptsGeneral.ApplicantId));
            values.Add(new FieldValue("AccSubNameID", original_MoneyReceiptsGeneral.AccSubNameID, theMoneyReceiptsGeneral.AccSubNameID));
            values.Add(new FieldValue("AccSubNameAccSubName", original_MoneyReceiptsGeneral.AccSubNameAccSubName, theMoneyReceiptsGeneral.AccSubNameAccSubName, true));
            values.Add(new FieldValue("AccSubNameAccSubTypeAccSubType", original_MoneyReceiptsGeneral.AccSubNameAccSubTypeAccSubType, theMoneyReceiptsGeneral.AccSubNameAccSubTypeAccSubType, true));
            values.Add(new FieldValue("Fileno", original_MoneyReceiptsGeneral.Fileno, theMoneyReceiptsGeneral.Fileno));
            values.Add(new FieldValue("Checkno", original_MoneyReceiptsGeneral.Checkno, theMoneyReceiptsGeneral.Checkno));
            values.Add(new FieldValue("CheckDate", original_MoneyReceiptsGeneral.CheckDate, theMoneyReceiptsGeneral.CheckDate));
            values.Add(new FieldValue("CheckPostDate", original_MoneyReceiptsGeneral.CheckPostDate, theMoneyReceiptsGeneral.CheckPostDate));
            values.Add(new FieldValue("CheckBankName", original_MoneyReceiptsGeneral.CheckBankName, theMoneyReceiptsGeneral.CheckBankName));
            values.Add(new FieldValue("BankBranch", original_MoneyReceiptsGeneral.BankBranch, theMoneyReceiptsGeneral.BankBranch));
            values.Add(new FieldValue("Dlt", original_MoneyReceiptsGeneral.Dlt, theMoneyReceiptsGeneral.Dlt));
            values.Add(new FieldValue("Description", original_MoneyReceiptsGeneral.Description, theMoneyReceiptsGeneral.Description));
            values.Add(new FieldValue("MultiPayment", original_MoneyReceiptsGeneral.MultiPayment, theMoneyReceiptsGeneral.MultiPayment));
            values.Add(new FieldValue("CancelMR", original_MoneyReceiptsGeneral.CancelMR, theMoneyReceiptsGeneral.CancelMR));
            values.Add(new FieldValue("CancelDate", original_MoneyReceiptsGeneral.CancelDate, theMoneyReceiptsGeneral.CancelDate));
            values.Add(new FieldValue("ReceiptType", original_MoneyReceiptsGeneral.ReceiptType, theMoneyReceiptsGeneral.ReceiptType));
            values.Add(new FieldValue("GName", original_MoneyReceiptsGeneral.GName, theMoneyReceiptsGeneral.GName));
            values.Add(new FieldValue("GFathersName", original_MoneyReceiptsGeneral.GFathersName, theMoneyReceiptsGeneral.GFathersName));
            values.Add(new FieldValue("Gaddress", original_MoneyReceiptsGeneral.Gaddress, theMoneyReceiptsGeneral.Gaddress));
            values.Add(new FieldValue("vide", original_MoneyReceiptsGeneral.vide, theMoneyReceiptsGeneral.vide));
            values.Add(new FieldValue("Created_BY", original_MoneyReceiptsGeneral.Created_BY, theMoneyReceiptsGeneral.Created_BY));
            values.Add(new FieldValue("Created_DT", original_MoneyReceiptsGeneral.Created_DT, theMoneyReceiptsGeneral.Created_DT));
            values.Add(new FieldValue("Updated_BY", original_MoneyReceiptsGeneral.Updated_BY, theMoneyReceiptsGeneral.Updated_BY));
            values.Add(new FieldValue("Updated_DT", original_MoneyReceiptsGeneral.Updated_DT, theMoneyReceiptsGeneral.Updated_DT));
            values.Add(new FieldValue("Remarks", original_MoneyReceiptsGeneral.Remarks, theMoneyReceiptsGeneral.Remarks));
            values.Add(new FieldValue("DisplayAction", original_MoneyReceiptsGeneral.DisplayAction, theMoneyReceiptsGeneral.DisplayAction));
            values.Add(new FieldValue("AccFundID", original_MoneyReceiptsGeneral.AccFundID, theMoneyReceiptsGeneral.AccFundID));
            values.Add(new FieldValue("CoaDetailID", original_MoneyReceiptsGeneral.CoaDetailID, theMoneyReceiptsGeneral.CoaDetailID));
            values.Add(new FieldValue("CoaDetailAccName", original_MoneyReceiptsGeneral.CoaDetailAccName, theMoneyReceiptsGeneral.CoaDetailAccName, true));
            values.Add(new FieldValue("CoaDetailAccBalTypeAccBalType", original_MoneyReceiptsGeneral.CoaDetailAccBalTypeAccBalType, theMoneyReceiptsGeneral.CoaDetailAccBalTypeAccBalType, true));
            values.Add(new FieldValue("CoaDetailAccCurrencyAccCurrencyName", original_MoneyReceiptsGeneral.CoaDetailAccCurrencyAccCurrencyName, theMoneyReceiptsGeneral.CoaDetailAccCurrencyAccCurrencyName, true));
            values.Add(new FieldValue("CoaDetailAccDestAccDest", original_MoneyReceiptsGeneral.CoaDetailAccDestAccDest, theMoneyReceiptsGeneral.CoaDetailAccDestAccDest, true));
            values.Add(new FieldValue("CoaDetailAccDestCompanyTypeDescription", original_MoneyReceiptsGeneral.CoaDetailAccDestCompanyTypeDescription, theMoneyReceiptsGeneral.CoaDetailAccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("CoaDetailAccFundAccFundCode", original_MoneyReceiptsGeneral.CoaDetailAccFundAccFundCode, theMoneyReceiptsGeneral.CoaDetailAccFundAccFundCode, true));
            values.Add(new FieldValue("CoaDetailAccSubTypeAccSubType", original_MoneyReceiptsGeneral.CoaDetailAccSubTypeAccSubType, theMoneyReceiptsGeneral.CoaDetailAccSubTypeAccSubType, true));
            values.Add(new FieldValue("CoaDetailAccTypeAccType", original_MoneyReceiptsGeneral.CoaDetailAccTypeAccType, theMoneyReceiptsGeneral.CoaDetailAccTypeAccType, true));
            values.Add(new FieldValue("CoaDetailCoaControlAccName", original_MoneyReceiptsGeneral.CoaDetailCoaControlAccName, theMoneyReceiptsGeneral.CoaDetailCoaControlAccName, true));
            values.Add(new FieldValue("CoaDetailCoaControlAccBalTypeAccBalType", original_MoneyReceiptsGeneral.CoaDetailCoaControlAccBalTypeAccBalType, theMoneyReceiptsGeneral.CoaDetailCoaControlAccBalTypeAccBalType, true));
            values.Add(new FieldValue("CoaDetailCoaControlAccDestAccDest", original_MoneyReceiptsGeneral.CoaDetailCoaControlAccDestAccDest, theMoneyReceiptsGeneral.CoaDetailCoaControlAccDestAccDest, true));
            values.Add(new FieldValue("CoaDetailCoaControlAccTypeAccType", original_MoneyReceiptsGeneral.CoaDetailCoaControlAccTypeAccType, theMoneyReceiptsGeneral.CoaDetailCoaControlAccTypeAccType, true));
            values.Add(new FieldValue("CoaDetailCoaControlCompTypeDescription", original_MoneyReceiptsGeneral.CoaDetailCoaControlCompTypeDescription, theMoneyReceiptsGeneral.CoaDetailCoaControlCompTypeDescription, true));
            values.Add(new FieldValue("CoaDetailCoaMainAccName", original_MoneyReceiptsGeneral.CoaDetailCoaMainAccName, theMoneyReceiptsGeneral.CoaDetailCoaMainAccName, true));
            values.Add(new FieldValue("CoaDetailCoaMainAccBalTypeAccBalType", original_MoneyReceiptsGeneral.CoaDetailCoaMainAccBalTypeAccBalType, theMoneyReceiptsGeneral.CoaDetailCoaMainAccBalTypeAccBalType, true));
            values.Add(new FieldValue("CoaDetailCoaMainAccDestAccDest", original_MoneyReceiptsGeneral.CoaDetailCoaMainAccDestAccDest, theMoneyReceiptsGeneral.CoaDetailCoaMainAccDestAccDest, true));
            values.Add(new FieldValue("CoaDetailCoaMainAccFundAccFundCode", original_MoneyReceiptsGeneral.CoaDetailCoaMainAccFundAccFundCode, theMoneyReceiptsGeneral.CoaDetailCoaMainAccFundAccFundCode, true));
            values.Add(new FieldValue("CoaDetailCoaMainAccTypeAccType", original_MoneyReceiptsGeneral.CoaDetailCoaMainAccTypeAccType, theMoneyReceiptsGeneral.CoaDetailCoaMainAccTypeAccType, true));
            values.Add(new FieldValue("CoaDetailCoaMainCoaControlAccName", original_MoneyReceiptsGeneral.CoaDetailCoaMainCoaControlAccName, theMoneyReceiptsGeneral.CoaDetailCoaMainCoaControlAccName, true));
            values.Add(new FieldValue("CoaDetailCoaSubAccName", original_MoneyReceiptsGeneral.CoaDetailCoaSubAccName, theMoneyReceiptsGeneral.CoaDetailCoaSubAccName, true));
            values.Add(new FieldValue("CoaDetailCoaSubAccBalTypeAccBalType", original_MoneyReceiptsGeneral.CoaDetailCoaSubAccBalTypeAccBalType, theMoneyReceiptsGeneral.CoaDetailCoaSubAccBalTypeAccBalType, true));
            values.Add(new FieldValue("CoaDetailCoaSubAccDestAccDest", original_MoneyReceiptsGeneral.CoaDetailCoaSubAccDestAccDest, theMoneyReceiptsGeneral.CoaDetailCoaSubAccDestAccDest, true));
            values.Add(new FieldValue("CoaDetailCoaSubAccFundAccFundCode", original_MoneyReceiptsGeneral.CoaDetailCoaSubAccFundAccFundCode, theMoneyReceiptsGeneral.CoaDetailCoaSubAccFundAccFundCode, true));
            values.Add(new FieldValue("CoaDetailCoaSubAccTypeAccType", original_MoneyReceiptsGeneral.CoaDetailCoaSubAccTypeAccType, theMoneyReceiptsGeneral.CoaDetailCoaSubAccTypeAccType, true));
            values.Add(new FieldValue("CoaDetailCoaSubCoaControlAccName", original_MoneyReceiptsGeneral.CoaDetailCoaSubCoaControlAccName, theMoneyReceiptsGeneral.CoaDetailCoaSubCoaControlAccName, true));
            values.Add(new FieldValue("CoaDetailCoaSubCoaMainAccName", original_MoneyReceiptsGeneral.CoaDetailCoaSubCoaMainAccName, theMoneyReceiptsGeneral.CoaDetailCoaSubCoaMainAccName, true));
            values.Add(new FieldValue("AccTranID", original_MoneyReceiptsGeneral.AccTranID, theMoneyReceiptsGeneral.AccTranID));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.MoneyReceiptsGeneral theMoneyReceiptsGeneral, MyCompany.Data.Objects.MoneyReceiptsGeneral original_MoneyReceiptsGeneral, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "MoneyReceiptsGeneral";
            args.View = dataView;
            args.Values = CreateFieldValues(theMoneyReceiptsGeneral, original_MoneyReceiptsGeneral);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("MoneyReceiptsGeneral", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theMoneyReceiptsGeneral);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.MoneyReceiptsGeneral theMoneyReceiptsGeneral, MyCompany.Data.Objects.MoneyReceiptsGeneral original_MoneyReceiptsGeneral)
        {
            return ExecuteAction(theMoneyReceiptsGeneral, original_MoneyReceiptsGeneral, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.MoneyReceiptsGeneral theMoneyReceiptsGeneral)
        {
            return Update(theMoneyReceiptsGeneral, SelectSingle(theMoneyReceiptsGeneral.MoneyReceiptsID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.MoneyReceiptsGeneral theMoneyReceiptsGeneral)
        {
            return ExecuteAction(theMoneyReceiptsGeneral, new MoneyReceiptsGeneral(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.MoneyReceiptsGeneral theMoneyReceiptsGeneral)
        {
            return ExecuteAction(theMoneyReceiptsGeneral, theMoneyReceiptsGeneral, "Select", "Delete", DeleteView);
        }
    }
}
