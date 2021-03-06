﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class AccTrnDetail
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _accTrnDetailID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accTranRef;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accTranSLNO;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _accVoucherTranID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accVoucherTranVchrNumber;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accVoucherTranAccFundAccFundName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accFundID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accFundAccFundName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _vchrTypeID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _vchrTypeVchrTypeDesc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _accTranDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accAccCurrencyAccCurrencyName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accAccDestCompanyTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accAccFundAccFundName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accAccSubTypeAccSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accCoaControlAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accCoaControlAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accCoaControlAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accCoaControlCompTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accCoaMainAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accCoaMainAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accCoaMainAccFundAccFundName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accCoaMainAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accCoaMainCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accCoaSubAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accCoaSubAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accCoaSubAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accCoaSubAccFundAccFundName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accCoaSubAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accCoaSubCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accCoaSubCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _debit;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _credit;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tran_Comment;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _revAcc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accCurrency;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accCurrencyAccCurrencyName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _accCurrencyRate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accSubTypeID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accSubTypeAccSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accSubCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accSubAccSubName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accSubAccSubTypeAccSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _trStat;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private byte? _dLT;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accBranchCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _challan_no;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _mrnNo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _stat;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _chequeno;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tranCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _departmentsID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _vchrNo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _vchrLock;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _transitYN;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _isPosted;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isRevtran;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isTransitReceived;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accSubTypeID1;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accSubCode1;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accSubTypeID2;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accSubCode2;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _chequeDT;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _chequeBankBranch;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isChequeHonour;
        
        public AccTrnDetail()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public long? AccTrnDetailID
        {
            get
            {
                return _accTrnDetailID;
            }
            set
            {
                _accTrnDetailID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccTranRef
        {
            get
            {
                return _accTranRef;
            }
            set
            {
                _accTranRef = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public int? AccTranSLNO
        {
            get
            {
                return _accTranSLNO;
            }
            set
            {
                _accTranSLNO = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public long? AccVoucherTranID
        {
            get
            {
                return _accVoucherTranID;
            }
            set
            {
                _accVoucherTranID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccVoucherTranVchrNumber
        {
            get
            {
                return _accVoucherTranVchrNumber;
            }
            set
            {
                _accVoucherTranVchrNumber = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccVoucherTranAccFundAccFundName
        {
            get
            {
                return _accVoucherTranAccFundAccFundName;
            }
            set
            {
                _accVoucherTranAccFundAccFundName = value;
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public int? VchrTypeID
        {
            get
            {
                return _vchrTypeID;
            }
            set
            {
                _vchrTypeID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string VchrTypeVchrTypeDesc
        {
            get
            {
                return _vchrTypeVchrTypeDesc;
            }
            set
            {
                _vchrTypeVchrTypeDesc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public DateTime? AccTranDate
        {
            get
            {
                return _accTranDate;
            }
            set
            {
                _accTranDate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public int? AccCode
        {
            get
            {
                return _accCode;
            }
            set
            {
                _accCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccAccName
        {
            get
            {
                return _accAccName;
            }
            set
            {
                _accAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccAccBalTypeAccBalType
        {
            get
            {
                return _accAccBalTypeAccBalType;
            }
            set
            {
                _accAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccAccCurrencyAccCurrencyName
        {
            get
            {
                return _accAccCurrencyAccCurrencyName;
            }
            set
            {
                _accAccCurrencyAccCurrencyName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccAccDestAccDest
        {
            get
            {
                return _accAccDestAccDest;
            }
            set
            {
                _accAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccAccDestCompanyTypeDescription
        {
            get
            {
                return _accAccDestCompanyTypeDescription;
            }
            set
            {
                _accAccDestCompanyTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccAccFundAccFundName
        {
            get
            {
                return _accAccFundAccFundName;
            }
            set
            {
                _accAccFundAccFundName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccAccSubTypeAccSubType
        {
            get
            {
                return _accAccSubTypeAccSubType;
            }
            set
            {
                _accAccSubTypeAccSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccAccTypeAccType
        {
            get
            {
                return _accAccTypeAccType;
            }
            set
            {
                _accAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccCoaControlAccName
        {
            get
            {
                return _accCoaControlAccName;
            }
            set
            {
                _accCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccCoaControlAccBalTypeAccBalType
        {
            get
            {
                return _accCoaControlAccBalTypeAccBalType;
            }
            set
            {
                _accCoaControlAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccCoaControlAccDestAccDest
        {
            get
            {
                return _accCoaControlAccDestAccDest;
            }
            set
            {
                _accCoaControlAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccCoaControlAccTypeAccType
        {
            get
            {
                return _accCoaControlAccTypeAccType;
            }
            set
            {
                _accCoaControlAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccCoaControlCompTypeDescription
        {
            get
            {
                return _accCoaControlCompTypeDescription;
            }
            set
            {
                _accCoaControlCompTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccCoaMainAccName
        {
            get
            {
                return _accCoaMainAccName;
            }
            set
            {
                _accCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccCoaMainAccBalTypeAccBalType
        {
            get
            {
                return _accCoaMainAccBalTypeAccBalType;
            }
            set
            {
                _accCoaMainAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccCoaMainAccDestAccDest
        {
            get
            {
                return _accCoaMainAccDestAccDest;
            }
            set
            {
                _accCoaMainAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccCoaMainAccFundAccFundName
        {
            get
            {
                return _accCoaMainAccFundAccFundName;
            }
            set
            {
                _accCoaMainAccFundAccFundName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccCoaMainAccTypeAccType
        {
            get
            {
                return _accCoaMainAccTypeAccType;
            }
            set
            {
                _accCoaMainAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccCoaMainCoaControlAccName
        {
            get
            {
                return _accCoaMainCoaControlAccName;
            }
            set
            {
                _accCoaMainCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccCoaSubAccName
        {
            get
            {
                return _accCoaSubAccName;
            }
            set
            {
                _accCoaSubAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccCoaSubAccBalTypeAccBalType
        {
            get
            {
                return _accCoaSubAccBalTypeAccBalType;
            }
            set
            {
                _accCoaSubAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccCoaSubAccDestAccDest
        {
            get
            {
                return _accCoaSubAccDestAccDest;
            }
            set
            {
                _accCoaSubAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccCoaSubAccFundAccFundName
        {
            get
            {
                return _accCoaSubAccFundAccFundName;
            }
            set
            {
                _accCoaSubAccFundAccFundName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccCoaSubAccTypeAccType
        {
            get
            {
                return _accCoaSubAccTypeAccType;
            }
            set
            {
                _accCoaSubAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccCoaSubCoaControlAccName
        {
            get
            {
                return _accCoaSubCoaControlAccName;
            }
            set
            {
                _accCoaSubCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccCoaSubCoaMainAccName
        {
            get
            {
                return _accCoaSubCoaMainAccName;
            }
            set
            {
                _accCoaSubCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public decimal? Debit
        {
            get
            {
                return _debit;
            }
            set
            {
                _debit = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public decimal? Credit
        {
            get
            {
                return _credit;
            }
            set
            {
                _credit = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Tran_Comment
        {
            get
            {
                return _tran_Comment;
            }
            set
            {
                _tran_Comment = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public int? RevAcc
        {
            get
            {
                return _revAcc;
            }
            set
            {
                _revAcc = value;
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
        public string AccSubTypeAccSubType
        {
            get
            {
                return _accSubTypeAccSubType;
            }
            set
            {
                _accSubTypeAccSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? AccSubCode
        {
            get
            {
                return _accSubCode;
            }
            set
            {
                _accSubCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccSubAccSubName
        {
            get
            {
                return _accSubAccSubName;
            }
            set
            {
                _accSubAccSubName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccSubAccSubTypeAccSubType
        {
            get
            {
                return _accSubAccSubTypeAccSubType;
            }
            set
            {
                _accSubAccSubTypeAccSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string TrStat
        {
            get
            {
                return _trStat;
            }
            set
            {
                _trStat = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public byte? DLT
        {
            get
            {
                return _dLT;
            }
            set
            {
                _dLT = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? AccBranchCode
        {
            get
            {
                return _accBranchCode;
            }
            set
            {
                _accBranchCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Challan_no
        {
            get
            {
                return _challan_no;
            }
            set
            {
                _challan_no = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string MrnNo
        {
            get
            {
                return _mrnNo;
            }
            set
            {
                _mrnNo = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Stat
        {
            get
            {
                return _stat;
            }
            set
            {
                _stat = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Chequeno
        {
            get
            {
                return _chequeno;
            }
            set
            {
                _chequeno = value;
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
        public long? DepartmentsID
        {
            get
            {
                return _departmentsID;
            }
            set
            {
                _departmentsID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string VchrNo
        {
            get
            {
                return _vchrNo;
            }
            set
            {
                _vchrNo = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? VchrLock
        {
            get
            {
                return _vchrLock;
            }
            set
            {
                _vchrLock = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? TransitYN
        {
            get
            {
                return _transitYN;
            }
            set
            {
                _transitYN = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? IsPosted
        {
            get
            {
                return _isPosted;
            }
            set
            {
                _isPosted = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? IsRevtran
        {
            get
            {
                return _isRevtran;
            }
            set
            {
                _isRevtran = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? IsTransitReceived
        {
            get
            {
                return _isTransitReceived;
            }
            set
            {
                _isTransitReceived = value;
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
        public int? AccSubCode1
        {
            get
            {
                return _accSubCode1;
            }
            set
            {
                _accSubCode1 = value;
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
        public int? AccSubCode2
        {
            get
            {
                return _accSubCode2;
            }
            set
            {
                _accSubCode2 = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? ChequeDT
        {
            get
            {
                return _chequeDT;
            }
            set
            {
                _chequeDT = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ChequeBankBranch
        {
            get
            {
                return _chequeBankBranch;
            }
            set
            {
                _chequeBankBranch = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? IsChequeHonour
        {
            get
            {
                return _isChequeHonour;
            }
            set
            {
                _isChequeHonour = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.AccTrnDetail> Select(
                    long? accTrnDetailID, 
                    string accTranRef, 
                    int? accTranSLNO, 
                    long? accVoucherTranID, 
                    string accVoucherTranVchrNumber, 
                    string accVoucherTranAccFundAccFundName, 
                    int? accFundID, 
                    string accFundAccFundName, 
                    int? vchrTypeID, 
                    string vchrTypeVchrTypeDesc, 
                    DateTime? accTranDate, 
                    int? accCode, 
                    string accAccName, 
                    string accAccBalTypeAccBalType, 
                    string accAccCurrencyAccCurrencyName, 
                    string accAccDestAccDest, 
                    string accAccDestCompanyTypeDescription, 
                    string accAccFundAccFundName, 
                    string accAccSubTypeAccSubType, 
                    string accAccTypeAccType, 
                    string accCoaControlAccName, 
                    string accCoaControlAccBalTypeAccBalType, 
                    string accCoaControlAccDestAccDest, 
                    string accCoaControlAccTypeAccType, 
                    string accCoaControlCompTypeDescription, 
                    string accCoaMainAccName, 
                    string accCoaMainAccBalTypeAccBalType, 
                    string accCoaMainAccDestAccDest, 
                    string accCoaMainAccFundAccFundName, 
                    string accCoaMainAccTypeAccType, 
                    string accCoaMainCoaControlAccName, 
                    string accCoaSubAccName, 
                    string accCoaSubAccBalTypeAccBalType, 
                    string accCoaSubAccDestAccDest, 
                    string accCoaSubAccFundAccFundName, 
                    string accCoaSubAccTypeAccType, 
                    string accCoaSubCoaControlAccName, 
                    string accCoaSubCoaMainAccName, 
                    decimal? debit, 
                    decimal? credit, 
                    string tran_Comment, 
                    int? revAcc, 
                    int? accCurrency, 
                    string accCurrencyAccCurrencyName, 
                    decimal? accCurrencyRate, 
                    int? accSubTypeID, 
                    string accSubTypeAccSubType, 
                    int? accSubCode, 
                    string accSubAccSubName, 
                    string accSubAccSubTypeAccSubType, 
                    string trStat, 
                    byte? dLT, 
                    int? accBranchCode, 
                    string challan_no, 
                    string mrnNo, 
                    string stat, 
                    string chequeno, 
                    string tranCode, 
                    long? departmentsID, 
                    string vchrNo, 
                    int? vchrLock, 
                    int? transitYN, 
                    int? isPosted, 
                    bool? isRevtran, 
                    bool? isTransitReceived, 
                    int? accSubTypeID1, 
                    int? accSubCode1, 
                    int? accSubTypeID2, 
                    int? accSubCode2, 
                    DateTime? chequeDT, 
                    string chequeBankBranch, 
                    bool? isChequeHonour)
        {
            return new AccTrnDetailFactory().Select(accTrnDetailID, accTranRef, accTranSLNO, accVoucherTranID, accVoucherTranVchrNumber, accVoucherTranAccFundAccFundName, accFundID, accFundAccFundName, vchrTypeID, vchrTypeVchrTypeDesc, accTranDate, accCode, accAccName, accAccBalTypeAccBalType, accAccCurrencyAccCurrencyName, accAccDestAccDest, accAccDestCompanyTypeDescription, accAccFundAccFundName, accAccSubTypeAccSubType, accAccTypeAccType, accCoaControlAccName, accCoaControlAccBalTypeAccBalType, accCoaControlAccDestAccDest, accCoaControlAccTypeAccType, accCoaControlCompTypeDescription, accCoaMainAccName, accCoaMainAccBalTypeAccBalType, accCoaMainAccDestAccDest, accCoaMainAccFundAccFundName, accCoaMainAccTypeAccType, accCoaMainCoaControlAccName, accCoaSubAccName, accCoaSubAccBalTypeAccBalType, accCoaSubAccDestAccDest, accCoaSubAccFundAccFundName, accCoaSubAccTypeAccType, accCoaSubCoaControlAccName, accCoaSubCoaMainAccName, debit, credit, tran_Comment, revAcc, accCurrency, accCurrencyAccCurrencyName, accCurrencyRate, accSubTypeID, accSubTypeAccSubType, accSubCode, accSubAccSubName, accSubAccSubTypeAccSubType, trStat, dLT, accBranchCode, challan_no, mrnNo, stat, chequeno, tranCode, departmentsID, vchrNo, vchrLock, transitYN, isPosted, isRevtran, isTransitReceived, accSubTypeID1, accSubCode1, accSubTypeID2, accSubCode2, chequeDT, chequeBankBranch, isChequeHonour);
        }
        
        public static List<MyCompany.Data.Objects.AccTrnDetail> Select(MyCompany.Data.Objects.AccTrnDetail qbe)
        {
            return new AccTrnDetailFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.AccTrnDetail> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new AccTrnDetailFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccTrnDetail> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new AccTrnDetailFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.AccTrnDetail> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new AccTrnDetailFactory().Select(filter, sort, AccTrnDetailFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccTrnDetail> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new AccTrnDetailFactory().Select(filter, sort, AccTrnDetailFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.AccTrnDetail> Select(string filter, BusinessObjectParameters parameters)
        {
            return new AccTrnDetailFactory().Select(filter, null, AccTrnDetailFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccTrnDetail> Select(string filter, params FieldValue[] parameters)
        {
            return new AccTrnDetailFactory().Select(filter, null, AccTrnDetailFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.AccTrnDetail SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new AccTrnDetailFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.AccTrnDetail SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new AccTrnDetailFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.AccTrnDetail SelectSingle(long? accTrnDetailID)
        {
            return new AccTrnDetailFactory().SelectSingle(accTrnDetailID);
        }
        
        public int Insert()
        {
            return new AccTrnDetailFactory().Insert(this);
        }
        
        public int Update()
        {
            return new AccTrnDetailFactory().Update(this);
        }
        
        public int Delete()
        {
            return new AccTrnDetailFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("AccTrnDetailID: {0}", this.AccTrnDetailID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class AccTrnDetailFactory
    {
        
        public AccTrnDetailFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("AccTrnDetail");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("AccTrnDetail");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("AccTrnDetail");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("AccTrnDetail");
            }
        }
        
        public static AccTrnDetailFactory Create()
        {
            return new AccTrnDetailFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    long? accTrnDetailID, 
                    string accTranRef, 
                    int? accTranSLNO, 
                    long? accVoucherTranID, 
                    string accVoucherTranVchrNumber, 
                    string accVoucherTranAccFundAccFundName, 
                    int? accFundID, 
                    string accFundAccFundName, 
                    int? vchrTypeID, 
                    string vchrTypeVchrTypeDesc, 
                    DateTime? accTranDate, 
                    int? accCode, 
                    string accAccName, 
                    string accAccBalTypeAccBalType, 
                    string accAccCurrencyAccCurrencyName, 
                    string accAccDestAccDest, 
                    string accAccDestCompanyTypeDescription, 
                    string accAccFundAccFundName, 
                    string accAccSubTypeAccSubType, 
                    string accAccTypeAccType, 
                    string accCoaControlAccName, 
                    string accCoaControlAccBalTypeAccBalType, 
                    string accCoaControlAccDestAccDest, 
                    string accCoaControlAccTypeAccType, 
                    string accCoaControlCompTypeDescription, 
                    string accCoaMainAccName, 
                    string accCoaMainAccBalTypeAccBalType, 
                    string accCoaMainAccDestAccDest, 
                    string accCoaMainAccFundAccFundName, 
                    string accCoaMainAccTypeAccType, 
                    string accCoaMainCoaControlAccName, 
                    string accCoaSubAccName, 
                    string accCoaSubAccBalTypeAccBalType, 
                    string accCoaSubAccDestAccDest, 
                    string accCoaSubAccFundAccFundName, 
                    string accCoaSubAccTypeAccType, 
                    string accCoaSubCoaControlAccName, 
                    string accCoaSubCoaMainAccName, 
                    decimal? debit, 
                    decimal? credit, 
                    string tran_Comment, 
                    int? revAcc, 
                    int? accCurrency, 
                    string accCurrencyAccCurrencyName, 
                    decimal? accCurrencyRate, 
                    int? accSubTypeID, 
                    string accSubTypeAccSubType, 
                    int? accSubCode, 
                    string accSubAccSubName, 
                    string accSubAccSubTypeAccSubType, 
                    string trStat, 
                    byte? dLT, 
                    int? accBranchCode, 
                    string challan_no, 
                    string mrnNo, 
                    string stat, 
                    string chequeno, 
                    string tranCode, 
                    long? departmentsID, 
                    string vchrNo, 
                    int? vchrLock, 
                    int? transitYN, 
                    int? isPosted, 
                    bool? isRevtran, 
                    bool? isTransitReceived, 
                    int? accSubTypeID1, 
                    int? accSubCode1, 
                    int? accSubTypeID2, 
                    int? accSubCode2, 
                    DateTime? chequeDT, 
                    string chequeBankBranch, 
                    bool? isChequeHonour, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (accTrnDetailID.HasValue)
            	filter.Add(("AccTrnDetailID:=" + accTrnDetailID.Value.ToString()));
            if (!(String.IsNullOrEmpty(accTranRef)))
            	filter.Add(("AccTranRef:*" + accTranRef));
            if (accTranSLNO.HasValue)
            	filter.Add(("AccTranSLNO:=" + accTranSLNO.Value.ToString()));
            if (accVoucherTranID.HasValue)
            	filter.Add(("AccVoucherTranID:=" + accVoucherTranID.Value.ToString()));
            if (!(String.IsNullOrEmpty(accVoucherTranVchrNumber)))
            	filter.Add(("AccVoucherTranVchrNumber:*" + accVoucherTranVchrNumber));
            if (!(String.IsNullOrEmpty(accVoucherTranAccFundAccFundName)))
            	filter.Add(("AccVoucherTranAccFundAccFundName:*" + accVoucherTranAccFundAccFundName));
            if (accFundID.HasValue)
            	filter.Add(("AccFundID:=" + accFundID.Value.ToString()));
            if (!(String.IsNullOrEmpty(accFundAccFundName)))
            	filter.Add(("AccFundAccFundName:*" + accFundAccFundName));
            if (vchrTypeID.HasValue)
            	filter.Add(("VchrTypeID:=" + vchrTypeID.Value.ToString()));
            if (!(String.IsNullOrEmpty(vchrTypeVchrTypeDesc)))
            	filter.Add(("VchrTypeVchrTypeDesc:*" + vchrTypeVchrTypeDesc));
            if (accTranDate.HasValue)
            	filter.Add(("AccTranDate:=" + accTranDate.Value.ToString()));
            if (accCode.HasValue)
            	filter.Add(("AccCode:=" + accCode.Value.ToString()));
            if (!(String.IsNullOrEmpty(accAccName)))
            	filter.Add(("AccAccName:*" + accAccName));
            if (!(String.IsNullOrEmpty(accAccBalTypeAccBalType)))
            	filter.Add(("AccAccBalTypeAccBalType:*" + accAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(accAccCurrencyAccCurrencyName)))
            	filter.Add(("AccAccCurrencyAccCurrencyName:*" + accAccCurrencyAccCurrencyName));
            if (!(String.IsNullOrEmpty(accAccDestAccDest)))
            	filter.Add(("AccAccDestAccDest:*" + accAccDestAccDest));
            if (!(String.IsNullOrEmpty(accAccDestCompanyTypeDescription)))
            	filter.Add(("AccAccDestCompanyTypeDescription:*" + accAccDestCompanyTypeDescription));
            if (!(String.IsNullOrEmpty(accAccFundAccFundName)))
            	filter.Add(("AccAccFundAccFundName:*" + accAccFundAccFundName));
            if (!(String.IsNullOrEmpty(accAccSubTypeAccSubType)))
            	filter.Add(("AccAccSubTypeAccSubType:*" + accAccSubTypeAccSubType));
            if (!(String.IsNullOrEmpty(accAccTypeAccType)))
            	filter.Add(("AccAccTypeAccType:*" + accAccTypeAccType));
            if (!(String.IsNullOrEmpty(accCoaControlAccName)))
            	filter.Add(("AccCoaControlAccName:*" + accCoaControlAccName));
            if (!(String.IsNullOrEmpty(accCoaControlAccBalTypeAccBalType)))
            	filter.Add(("AccCoaControlAccBalTypeAccBalType:*" + accCoaControlAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(accCoaControlAccDestAccDest)))
            	filter.Add(("AccCoaControlAccDestAccDest:*" + accCoaControlAccDestAccDest));
            if (!(String.IsNullOrEmpty(accCoaControlAccTypeAccType)))
            	filter.Add(("AccCoaControlAccTypeAccType:*" + accCoaControlAccTypeAccType));
            if (!(String.IsNullOrEmpty(accCoaControlCompTypeDescription)))
            	filter.Add(("AccCoaControlCompTypeDescription:*" + accCoaControlCompTypeDescription));
            if (!(String.IsNullOrEmpty(accCoaMainAccName)))
            	filter.Add(("AccCoaMainAccName:*" + accCoaMainAccName));
            if (!(String.IsNullOrEmpty(accCoaMainAccBalTypeAccBalType)))
            	filter.Add(("AccCoaMainAccBalTypeAccBalType:*" + accCoaMainAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(accCoaMainAccDestAccDest)))
            	filter.Add(("AccCoaMainAccDestAccDest:*" + accCoaMainAccDestAccDest));
            if (!(String.IsNullOrEmpty(accCoaMainAccFundAccFundName)))
            	filter.Add(("AccCoaMainAccFundAccFundName:*" + accCoaMainAccFundAccFundName));
            if (!(String.IsNullOrEmpty(accCoaMainAccTypeAccType)))
            	filter.Add(("AccCoaMainAccTypeAccType:*" + accCoaMainAccTypeAccType));
            if (!(String.IsNullOrEmpty(accCoaMainCoaControlAccName)))
            	filter.Add(("AccCoaMainCoaControlAccName:*" + accCoaMainCoaControlAccName));
            if (!(String.IsNullOrEmpty(accCoaSubAccName)))
            	filter.Add(("AccCoaSubAccName:*" + accCoaSubAccName));
            if (!(String.IsNullOrEmpty(accCoaSubAccBalTypeAccBalType)))
            	filter.Add(("AccCoaSubAccBalTypeAccBalType:*" + accCoaSubAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(accCoaSubAccDestAccDest)))
            	filter.Add(("AccCoaSubAccDestAccDest:*" + accCoaSubAccDestAccDest));
            if (!(String.IsNullOrEmpty(accCoaSubAccFundAccFundName)))
            	filter.Add(("AccCoaSubAccFundAccFundName:*" + accCoaSubAccFundAccFundName));
            if (!(String.IsNullOrEmpty(accCoaSubAccTypeAccType)))
            	filter.Add(("AccCoaSubAccTypeAccType:*" + accCoaSubAccTypeAccType));
            if (!(String.IsNullOrEmpty(accCoaSubCoaControlAccName)))
            	filter.Add(("AccCoaSubCoaControlAccName:*" + accCoaSubCoaControlAccName));
            if (!(String.IsNullOrEmpty(accCoaSubCoaMainAccName)))
            	filter.Add(("AccCoaSubCoaMainAccName:*" + accCoaSubCoaMainAccName));
            if (debit.HasValue)
            	filter.Add(("Debit:=" + debit.Value.ToString()));
            if (credit.HasValue)
            	filter.Add(("Credit:=" + credit.Value.ToString()));
            if (!(String.IsNullOrEmpty(tran_Comment)))
            	filter.Add(("Tran_Comment:*" + tran_Comment));
            if (revAcc.HasValue)
            	filter.Add(("RevAcc:=" + revAcc.Value.ToString()));
            if (accCurrency.HasValue)
            	filter.Add(("AccCurrency:=" + accCurrency.Value.ToString()));
            if (!(String.IsNullOrEmpty(accCurrencyAccCurrencyName)))
            	filter.Add(("AccCurrencyAccCurrencyName:*" + accCurrencyAccCurrencyName));
            if (accCurrencyRate.HasValue)
            	filter.Add(("AccCurrencyRate:=" + accCurrencyRate.Value.ToString()));
            if (accSubTypeID.HasValue)
            	filter.Add(("AccSubTypeID:=" + accSubTypeID.Value.ToString()));
            if (!(String.IsNullOrEmpty(accSubTypeAccSubType)))
            	filter.Add(("AccSubTypeAccSubType:*" + accSubTypeAccSubType));
            if (accSubCode.HasValue)
            	filter.Add(("AccSubCode:=" + accSubCode.Value.ToString()));
            if (!(String.IsNullOrEmpty(accSubAccSubName)))
            	filter.Add(("AccSubAccSubName:*" + accSubAccSubName));
            if (!(String.IsNullOrEmpty(accSubAccSubTypeAccSubType)))
            	filter.Add(("AccSubAccSubTypeAccSubType:*" + accSubAccSubTypeAccSubType));
            if (!(String.IsNullOrEmpty(trStat)))
            	filter.Add(("TrStat:*" + trStat));
            if (dLT.HasValue)
            	filter.Add(("DLT:=" + dLT.Value.ToString()));
            if (accBranchCode.HasValue)
            	filter.Add(("AccBranchCode:=" + accBranchCode.Value.ToString()));
            if (!(String.IsNullOrEmpty(challan_no)))
            	filter.Add(("Challan_no:*" + challan_no));
            if (!(String.IsNullOrEmpty(mrnNo)))
            	filter.Add(("MrnNo:*" + mrnNo));
            if (!(String.IsNullOrEmpty(stat)))
            	filter.Add(("Stat:*" + stat));
            if (!(String.IsNullOrEmpty(chequeno)))
            	filter.Add(("Chequeno:*" + chequeno));
            if (!(String.IsNullOrEmpty(tranCode)))
            	filter.Add(("TranCode:*" + tranCode));
            if (departmentsID.HasValue)
            	filter.Add(("DepartmentsID:=" + departmentsID.Value.ToString()));
            if (!(String.IsNullOrEmpty(vchrNo)))
            	filter.Add(("VchrNo:*" + vchrNo));
            if (vchrLock.HasValue)
            	filter.Add(("VchrLock:=" + vchrLock.Value.ToString()));
            if (transitYN.HasValue)
            	filter.Add(("TransitYN:=" + transitYN.Value.ToString()));
            if (isPosted.HasValue)
            	filter.Add(("IsPosted:=" + isPosted.Value.ToString()));
            if (isRevtran.HasValue)
            	filter.Add(("IsRevtran:=" + isRevtran.Value.ToString()));
            if (isTransitReceived.HasValue)
            	filter.Add(("IsTransitReceived:=" + isTransitReceived.Value.ToString()));
            if (accSubTypeID1.HasValue)
            	filter.Add(("AccSubTypeID1:=" + accSubTypeID1.Value.ToString()));
            if (accSubCode1.HasValue)
            	filter.Add(("AccSubCode1:=" + accSubCode1.Value.ToString()));
            if (accSubTypeID2.HasValue)
            	filter.Add(("AccSubTypeID2:=" + accSubTypeID2.Value.ToString()));
            if (accSubCode2.HasValue)
            	filter.Add(("AccSubCode2:=" + accSubCode2.Value.ToString()));
            if (chequeDT.HasValue)
            	filter.Add(("ChequeDT:=" + chequeDT.Value.ToString()));
            if (!(String.IsNullOrEmpty(chequeBankBranch)))
            	filter.Add(("ChequeBankBranch:*" + chequeBankBranch));
            if (isChequeHonour.HasValue)
            	filter.Add(("IsChequeHonour:=" + isChequeHonour.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.AccTrnDetail> Select(
                    long? accTrnDetailID, 
                    string accTranRef, 
                    int? accTranSLNO, 
                    long? accVoucherTranID, 
                    string accVoucherTranVchrNumber, 
                    string accVoucherTranAccFundAccFundName, 
                    int? accFundID, 
                    string accFundAccFundName, 
                    int? vchrTypeID, 
                    string vchrTypeVchrTypeDesc, 
                    DateTime? accTranDate, 
                    int? accCode, 
                    string accAccName, 
                    string accAccBalTypeAccBalType, 
                    string accAccCurrencyAccCurrencyName, 
                    string accAccDestAccDest, 
                    string accAccDestCompanyTypeDescription, 
                    string accAccFundAccFundName, 
                    string accAccSubTypeAccSubType, 
                    string accAccTypeAccType, 
                    string accCoaControlAccName, 
                    string accCoaControlAccBalTypeAccBalType, 
                    string accCoaControlAccDestAccDest, 
                    string accCoaControlAccTypeAccType, 
                    string accCoaControlCompTypeDescription, 
                    string accCoaMainAccName, 
                    string accCoaMainAccBalTypeAccBalType, 
                    string accCoaMainAccDestAccDest, 
                    string accCoaMainAccFundAccFundName, 
                    string accCoaMainAccTypeAccType, 
                    string accCoaMainCoaControlAccName, 
                    string accCoaSubAccName, 
                    string accCoaSubAccBalTypeAccBalType, 
                    string accCoaSubAccDestAccDest, 
                    string accCoaSubAccFundAccFundName, 
                    string accCoaSubAccTypeAccType, 
                    string accCoaSubCoaControlAccName, 
                    string accCoaSubCoaMainAccName, 
                    decimal? debit, 
                    decimal? credit, 
                    string tran_Comment, 
                    int? revAcc, 
                    int? accCurrency, 
                    string accCurrencyAccCurrencyName, 
                    decimal? accCurrencyRate, 
                    int? accSubTypeID, 
                    string accSubTypeAccSubType, 
                    int? accSubCode, 
                    string accSubAccSubName, 
                    string accSubAccSubTypeAccSubType, 
                    string trStat, 
                    byte? dLT, 
                    int? accBranchCode, 
                    string challan_no, 
                    string mrnNo, 
                    string stat, 
                    string chequeno, 
                    string tranCode, 
                    long? departmentsID, 
                    string vchrNo, 
                    int? vchrLock, 
                    int? transitYN, 
                    int? isPosted, 
                    bool? isRevtran, 
                    bool? isTransitReceived, 
                    int? accSubTypeID1, 
                    int? accSubCode1, 
                    int? accSubTypeID2, 
                    int? accSubCode2, 
                    DateTime? chequeDT, 
                    string chequeBankBranch, 
                    bool? isChequeHonour, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(accTrnDetailID, accTranRef, accTranSLNO, accVoucherTranID, accVoucherTranVchrNumber, accVoucherTranAccFundAccFundName, accFundID, accFundAccFundName, vchrTypeID, vchrTypeVchrTypeDesc, accTranDate, accCode, accAccName, accAccBalTypeAccBalType, accAccCurrencyAccCurrencyName, accAccDestAccDest, accAccDestCompanyTypeDescription, accAccFundAccFundName, accAccSubTypeAccSubType, accAccTypeAccType, accCoaControlAccName, accCoaControlAccBalTypeAccBalType, accCoaControlAccDestAccDest, accCoaControlAccTypeAccType, accCoaControlCompTypeDescription, accCoaMainAccName, accCoaMainAccBalTypeAccBalType, accCoaMainAccDestAccDest, accCoaMainAccFundAccFundName, accCoaMainAccTypeAccType, accCoaMainCoaControlAccName, accCoaSubAccName, accCoaSubAccBalTypeAccBalType, accCoaSubAccDestAccDest, accCoaSubAccFundAccFundName, accCoaSubAccTypeAccType, accCoaSubCoaControlAccName, accCoaSubCoaMainAccName, debit, credit, tran_Comment, revAcc, accCurrency, accCurrencyAccCurrencyName, accCurrencyRate, accSubTypeID, accSubTypeAccSubType, accSubCode, accSubAccSubName, accSubAccSubTypeAccSubType, trStat, dLT, accBranchCode, challan_no, mrnNo, stat, chequeno, tranCode, departmentsID, vchrNo, vchrLock, transitYN, isPosted, isRevtran, isTransitReceived, accSubTypeID1, accSubCode1, accSubTypeID2, accSubCode2, chequeDT, chequeBankBranch, isChequeHonour, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("AccTrnDetail", dataView, request);
            return page.ToList<MyCompany.Data.Objects.AccTrnDetail>();
        }
        
        public List<MyCompany.Data.Objects.AccTrnDetail> Select(MyCompany.Data.Objects.AccTrnDetail qbe)
        {
            return Select(qbe.AccTrnDetailID, qbe.AccTranRef, qbe.AccTranSLNO, qbe.AccVoucherTranID, qbe.AccVoucherTranVchrNumber, qbe.AccVoucherTranAccFundAccFundName, qbe.AccFundID, qbe.AccFundAccFundName, qbe.VchrTypeID, qbe.VchrTypeVchrTypeDesc, qbe.AccTranDate, qbe.AccCode, qbe.AccAccName, qbe.AccAccBalTypeAccBalType, qbe.AccAccCurrencyAccCurrencyName, qbe.AccAccDestAccDest, qbe.AccAccDestCompanyTypeDescription, qbe.AccAccFundAccFundName, qbe.AccAccSubTypeAccSubType, qbe.AccAccTypeAccType, qbe.AccCoaControlAccName, qbe.AccCoaControlAccBalTypeAccBalType, qbe.AccCoaControlAccDestAccDest, qbe.AccCoaControlAccTypeAccType, qbe.AccCoaControlCompTypeDescription, qbe.AccCoaMainAccName, qbe.AccCoaMainAccBalTypeAccBalType, qbe.AccCoaMainAccDestAccDest, qbe.AccCoaMainAccFundAccFundName, qbe.AccCoaMainAccTypeAccType, qbe.AccCoaMainCoaControlAccName, qbe.AccCoaSubAccName, qbe.AccCoaSubAccBalTypeAccBalType, qbe.AccCoaSubAccDestAccDest, qbe.AccCoaSubAccFundAccFundName, qbe.AccCoaSubAccTypeAccType, qbe.AccCoaSubCoaControlAccName, qbe.AccCoaSubCoaMainAccName, qbe.Debit, qbe.Credit, qbe.Tran_Comment, qbe.RevAcc, qbe.AccCurrency, qbe.AccCurrencyAccCurrencyName, qbe.AccCurrencyRate, qbe.AccSubTypeID, qbe.AccSubTypeAccSubType, qbe.AccSubCode, qbe.AccSubAccSubName, qbe.AccSubAccSubTypeAccSubType, qbe.TrStat, qbe.DLT, qbe.AccBranchCode, qbe.Challan_no, qbe.MrnNo, qbe.Stat, qbe.Chequeno, qbe.TranCode, qbe.DepartmentsID, qbe.VchrNo, qbe.VchrLock, qbe.TransitYN, qbe.IsPosted, qbe.IsRevtran, qbe.IsTransitReceived, qbe.AccSubTypeID1, qbe.AccSubCode1, qbe.AccSubTypeID2, qbe.AccSubCode2, qbe.ChequeDT, qbe.ChequeBankBranch, qbe.IsChequeHonour);
        }
        
        public int SelectCount(
                    long? accTrnDetailID, 
                    string accTranRef, 
                    int? accTranSLNO, 
                    long? accVoucherTranID, 
                    string accVoucherTranVchrNumber, 
                    string accVoucherTranAccFundAccFundName, 
                    int? accFundID, 
                    string accFundAccFundName, 
                    int? vchrTypeID, 
                    string vchrTypeVchrTypeDesc, 
                    DateTime? accTranDate, 
                    int? accCode, 
                    string accAccName, 
                    string accAccBalTypeAccBalType, 
                    string accAccCurrencyAccCurrencyName, 
                    string accAccDestAccDest, 
                    string accAccDestCompanyTypeDescription, 
                    string accAccFundAccFundName, 
                    string accAccSubTypeAccSubType, 
                    string accAccTypeAccType, 
                    string accCoaControlAccName, 
                    string accCoaControlAccBalTypeAccBalType, 
                    string accCoaControlAccDestAccDest, 
                    string accCoaControlAccTypeAccType, 
                    string accCoaControlCompTypeDescription, 
                    string accCoaMainAccName, 
                    string accCoaMainAccBalTypeAccBalType, 
                    string accCoaMainAccDestAccDest, 
                    string accCoaMainAccFundAccFundName, 
                    string accCoaMainAccTypeAccType, 
                    string accCoaMainCoaControlAccName, 
                    string accCoaSubAccName, 
                    string accCoaSubAccBalTypeAccBalType, 
                    string accCoaSubAccDestAccDest, 
                    string accCoaSubAccFundAccFundName, 
                    string accCoaSubAccTypeAccType, 
                    string accCoaSubCoaControlAccName, 
                    string accCoaSubCoaMainAccName, 
                    decimal? debit, 
                    decimal? credit, 
                    string tran_Comment, 
                    int? revAcc, 
                    int? accCurrency, 
                    string accCurrencyAccCurrencyName, 
                    decimal? accCurrencyRate, 
                    int? accSubTypeID, 
                    string accSubTypeAccSubType, 
                    int? accSubCode, 
                    string accSubAccSubName, 
                    string accSubAccSubTypeAccSubType, 
                    string trStat, 
                    byte? dLT, 
                    int? accBranchCode, 
                    string challan_no, 
                    string mrnNo, 
                    string stat, 
                    string chequeno, 
                    string tranCode, 
                    long? departmentsID, 
                    string vchrNo, 
                    int? vchrLock, 
                    int? transitYN, 
                    int? isPosted, 
                    bool? isRevtran, 
                    bool? isTransitReceived, 
                    int? accSubTypeID1, 
                    int? accSubCode1, 
                    int? accSubTypeID2, 
                    int? accSubCode2, 
                    DateTime? chequeDT, 
                    string chequeBankBranch, 
                    bool? isChequeHonour, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(accTrnDetailID, accTranRef, accTranSLNO, accVoucherTranID, accVoucherTranVchrNumber, accVoucherTranAccFundAccFundName, accFundID, accFundAccFundName, vchrTypeID, vchrTypeVchrTypeDesc, accTranDate, accCode, accAccName, accAccBalTypeAccBalType, accAccCurrencyAccCurrencyName, accAccDestAccDest, accAccDestCompanyTypeDescription, accAccFundAccFundName, accAccSubTypeAccSubType, accAccTypeAccType, accCoaControlAccName, accCoaControlAccBalTypeAccBalType, accCoaControlAccDestAccDest, accCoaControlAccTypeAccType, accCoaControlCompTypeDescription, accCoaMainAccName, accCoaMainAccBalTypeAccBalType, accCoaMainAccDestAccDest, accCoaMainAccFundAccFundName, accCoaMainAccTypeAccType, accCoaMainCoaControlAccName, accCoaSubAccName, accCoaSubAccBalTypeAccBalType, accCoaSubAccDestAccDest, accCoaSubAccFundAccFundName, accCoaSubAccTypeAccType, accCoaSubCoaControlAccName, accCoaSubCoaMainAccName, debit, credit, tran_Comment, revAcc, accCurrency, accCurrencyAccCurrencyName, accCurrencyRate, accSubTypeID, accSubTypeAccSubType, accSubCode, accSubAccSubName, accSubAccSubTypeAccSubType, trStat, dLT, accBranchCode, challan_no, mrnNo, stat, chequeno, tranCode, departmentsID, vchrNo, vchrLock, transitYN, isPosted, isRevtran, isTransitReceived, accSubTypeID1, accSubCode1, accSubTypeID2, accSubCode2, chequeDT, chequeBankBranch, isChequeHonour, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("AccTrnDetail", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.AccTrnDetail> Select(
                    long? accTrnDetailID, 
                    string accTranRef, 
                    int? accTranSLNO, 
                    long? accVoucherTranID, 
                    string accVoucherTranVchrNumber, 
                    string accVoucherTranAccFundAccFundName, 
                    int? accFundID, 
                    string accFundAccFundName, 
                    int? vchrTypeID, 
                    string vchrTypeVchrTypeDesc, 
                    DateTime? accTranDate, 
                    int? accCode, 
                    string accAccName, 
                    string accAccBalTypeAccBalType, 
                    string accAccCurrencyAccCurrencyName, 
                    string accAccDestAccDest, 
                    string accAccDestCompanyTypeDescription, 
                    string accAccFundAccFundName, 
                    string accAccSubTypeAccSubType, 
                    string accAccTypeAccType, 
                    string accCoaControlAccName, 
                    string accCoaControlAccBalTypeAccBalType, 
                    string accCoaControlAccDestAccDest, 
                    string accCoaControlAccTypeAccType, 
                    string accCoaControlCompTypeDescription, 
                    string accCoaMainAccName, 
                    string accCoaMainAccBalTypeAccBalType, 
                    string accCoaMainAccDestAccDest, 
                    string accCoaMainAccFundAccFundName, 
                    string accCoaMainAccTypeAccType, 
                    string accCoaMainCoaControlAccName, 
                    string accCoaSubAccName, 
                    string accCoaSubAccBalTypeAccBalType, 
                    string accCoaSubAccDestAccDest, 
                    string accCoaSubAccFundAccFundName, 
                    string accCoaSubAccTypeAccType, 
                    string accCoaSubCoaControlAccName, 
                    string accCoaSubCoaMainAccName, 
                    decimal? debit, 
                    decimal? credit, 
                    string tran_Comment, 
                    int? revAcc, 
                    int? accCurrency, 
                    string accCurrencyAccCurrencyName, 
                    decimal? accCurrencyRate, 
                    int? accSubTypeID, 
                    string accSubTypeAccSubType, 
                    int? accSubCode, 
                    string accSubAccSubName, 
                    string accSubAccSubTypeAccSubType, 
                    string trStat, 
                    byte? dLT, 
                    int? accBranchCode, 
                    string challan_no, 
                    string mrnNo, 
                    string stat, 
                    string chequeno, 
                    string tranCode, 
                    long? departmentsID, 
                    string vchrNo, 
                    int? vchrLock, 
                    int? transitYN, 
                    int? isPosted, 
                    bool? isRevtran, 
                    bool? isTransitReceived, 
                    int? accSubTypeID1, 
                    int? accSubCode1, 
                    int? accSubTypeID2, 
                    int? accSubCode2, 
                    DateTime? chequeDT, 
                    string chequeBankBranch, 
                    bool? isChequeHonour)
        {
            return Select(accTrnDetailID, accTranRef, accTranSLNO, accVoucherTranID, accVoucherTranVchrNumber, accVoucherTranAccFundAccFundName, accFundID, accFundAccFundName, vchrTypeID, vchrTypeVchrTypeDesc, accTranDate, accCode, accAccName, accAccBalTypeAccBalType, accAccCurrencyAccCurrencyName, accAccDestAccDest, accAccDestCompanyTypeDescription, accAccFundAccFundName, accAccSubTypeAccSubType, accAccTypeAccType, accCoaControlAccName, accCoaControlAccBalTypeAccBalType, accCoaControlAccDestAccDest, accCoaControlAccTypeAccType, accCoaControlCompTypeDescription, accCoaMainAccName, accCoaMainAccBalTypeAccBalType, accCoaMainAccDestAccDest, accCoaMainAccFundAccFundName, accCoaMainAccTypeAccType, accCoaMainCoaControlAccName, accCoaSubAccName, accCoaSubAccBalTypeAccBalType, accCoaSubAccDestAccDest, accCoaSubAccFundAccFundName, accCoaSubAccTypeAccType, accCoaSubCoaControlAccName, accCoaSubCoaMainAccName, debit, credit, tran_Comment, revAcc, accCurrency, accCurrencyAccCurrencyName, accCurrencyRate, accSubTypeID, accSubTypeAccSubType, accSubCode, accSubAccSubName, accSubAccSubTypeAccSubType, trStat, dLT, accBranchCode, challan_no, mrnNo, stat, chequeno, tranCode, departmentsID, vchrNo, vchrLock, transitYN, isPosted, isRevtran, isTransitReceived, accSubTypeID1, accSubCode1, accSubTypeID2, accSubCode2, chequeDT, chequeBankBranch, isChequeHonour, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.AccTrnDetail SelectSingle(long? accTrnDetailID)
        {
            List<MyCompany.Data.Objects.AccTrnDetail> list = Select(accTrnDetailID, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.AccTrnDetail> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("AccTrnDetail", dataView, request);
            return page.ToList<MyCompany.Data.Objects.AccTrnDetail>();
        }
        
        public List<MyCompany.Data.Objects.AccTrnDetail> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.AccTrnDetail> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.AccTrnDetail SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.AccTrnDetail> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.AccTrnDetail theAccTrnDetail, MyCompany.Data.Objects.AccTrnDetail original_AccTrnDetail)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("AccTrnDetailID", original_AccTrnDetail.AccTrnDetailID, theAccTrnDetail.AccTrnDetailID, true));
            values.Add(new FieldValue("AccTranRef", original_AccTrnDetail.AccTranRef, theAccTrnDetail.AccTranRef));
            values.Add(new FieldValue("AccTranSLNO", original_AccTrnDetail.AccTranSLNO, theAccTrnDetail.AccTranSLNO));
            values.Add(new FieldValue("AccVoucherTranID", original_AccTrnDetail.AccVoucherTranID, theAccTrnDetail.AccVoucherTranID));
            values.Add(new FieldValue("AccVoucherTranVchrNumber", original_AccTrnDetail.AccVoucherTranVchrNumber, theAccTrnDetail.AccVoucherTranVchrNumber, true));
            values.Add(new FieldValue("AccVoucherTranAccFundAccFundName", original_AccTrnDetail.AccVoucherTranAccFundAccFundName, theAccTrnDetail.AccVoucherTranAccFundAccFundName, true));
            values.Add(new FieldValue("AccFundID", original_AccTrnDetail.AccFundID, theAccTrnDetail.AccFundID));
            values.Add(new FieldValue("AccFundAccFundName", original_AccTrnDetail.AccFundAccFundName, theAccTrnDetail.AccFundAccFundName, true));
            values.Add(new FieldValue("VchrTypeID", original_AccTrnDetail.VchrTypeID, theAccTrnDetail.VchrTypeID));
            values.Add(new FieldValue("VchrTypeVchrTypeDesc", original_AccTrnDetail.VchrTypeVchrTypeDesc, theAccTrnDetail.VchrTypeVchrTypeDesc, true));
            values.Add(new FieldValue("AccTranDate", original_AccTrnDetail.AccTranDate, theAccTrnDetail.AccTranDate));
            values.Add(new FieldValue("AccCode", original_AccTrnDetail.AccCode, theAccTrnDetail.AccCode));
            values.Add(new FieldValue("AccAccName", original_AccTrnDetail.AccAccName, theAccTrnDetail.AccAccName, true));
            values.Add(new FieldValue("AccAccBalTypeAccBalType", original_AccTrnDetail.AccAccBalTypeAccBalType, theAccTrnDetail.AccAccBalTypeAccBalType, true));
            values.Add(new FieldValue("AccAccCurrencyAccCurrencyName", original_AccTrnDetail.AccAccCurrencyAccCurrencyName, theAccTrnDetail.AccAccCurrencyAccCurrencyName, true));
            values.Add(new FieldValue("AccAccDestAccDest", original_AccTrnDetail.AccAccDestAccDest, theAccTrnDetail.AccAccDestAccDest, true));
            values.Add(new FieldValue("AccAccDestCompanyTypeDescription", original_AccTrnDetail.AccAccDestCompanyTypeDescription, theAccTrnDetail.AccAccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("AccAccFundAccFundName", original_AccTrnDetail.AccAccFundAccFundName, theAccTrnDetail.AccAccFundAccFundName, true));
            values.Add(new FieldValue("AccAccSubTypeAccSubType", original_AccTrnDetail.AccAccSubTypeAccSubType, theAccTrnDetail.AccAccSubTypeAccSubType, true));
            values.Add(new FieldValue("AccAccTypeAccType", original_AccTrnDetail.AccAccTypeAccType, theAccTrnDetail.AccAccTypeAccType, true));
            values.Add(new FieldValue("AccCoaControlAccName", original_AccTrnDetail.AccCoaControlAccName, theAccTrnDetail.AccCoaControlAccName, true));
            values.Add(new FieldValue("AccCoaControlAccBalTypeAccBalType", original_AccTrnDetail.AccCoaControlAccBalTypeAccBalType, theAccTrnDetail.AccCoaControlAccBalTypeAccBalType, true));
            values.Add(new FieldValue("AccCoaControlAccDestAccDest", original_AccTrnDetail.AccCoaControlAccDestAccDest, theAccTrnDetail.AccCoaControlAccDestAccDest, true));
            values.Add(new FieldValue("AccCoaControlAccTypeAccType", original_AccTrnDetail.AccCoaControlAccTypeAccType, theAccTrnDetail.AccCoaControlAccTypeAccType, true));
            values.Add(new FieldValue("AccCoaControlCompTypeDescription", original_AccTrnDetail.AccCoaControlCompTypeDescription, theAccTrnDetail.AccCoaControlCompTypeDescription, true));
            values.Add(new FieldValue("AccCoaMainAccName", original_AccTrnDetail.AccCoaMainAccName, theAccTrnDetail.AccCoaMainAccName, true));
            values.Add(new FieldValue("AccCoaMainAccBalTypeAccBalType", original_AccTrnDetail.AccCoaMainAccBalTypeAccBalType, theAccTrnDetail.AccCoaMainAccBalTypeAccBalType, true));
            values.Add(new FieldValue("AccCoaMainAccDestAccDest", original_AccTrnDetail.AccCoaMainAccDestAccDest, theAccTrnDetail.AccCoaMainAccDestAccDest, true));
            values.Add(new FieldValue("AccCoaMainAccFundAccFundName", original_AccTrnDetail.AccCoaMainAccFundAccFundName, theAccTrnDetail.AccCoaMainAccFundAccFundName, true));
            values.Add(new FieldValue("AccCoaMainAccTypeAccType", original_AccTrnDetail.AccCoaMainAccTypeAccType, theAccTrnDetail.AccCoaMainAccTypeAccType, true));
            values.Add(new FieldValue("AccCoaMainCoaControlAccName", original_AccTrnDetail.AccCoaMainCoaControlAccName, theAccTrnDetail.AccCoaMainCoaControlAccName, true));
            values.Add(new FieldValue("AccCoaSubAccName", original_AccTrnDetail.AccCoaSubAccName, theAccTrnDetail.AccCoaSubAccName, true));
            values.Add(new FieldValue("AccCoaSubAccBalTypeAccBalType", original_AccTrnDetail.AccCoaSubAccBalTypeAccBalType, theAccTrnDetail.AccCoaSubAccBalTypeAccBalType, true));
            values.Add(new FieldValue("AccCoaSubAccDestAccDest", original_AccTrnDetail.AccCoaSubAccDestAccDest, theAccTrnDetail.AccCoaSubAccDestAccDest, true));
            values.Add(new FieldValue("AccCoaSubAccFundAccFundName", original_AccTrnDetail.AccCoaSubAccFundAccFundName, theAccTrnDetail.AccCoaSubAccFundAccFundName, true));
            values.Add(new FieldValue("AccCoaSubAccTypeAccType", original_AccTrnDetail.AccCoaSubAccTypeAccType, theAccTrnDetail.AccCoaSubAccTypeAccType, true));
            values.Add(new FieldValue("AccCoaSubCoaControlAccName", original_AccTrnDetail.AccCoaSubCoaControlAccName, theAccTrnDetail.AccCoaSubCoaControlAccName, true));
            values.Add(new FieldValue("AccCoaSubCoaMainAccName", original_AccTrnDetail.AccCoaSubCoaMainAccName, theAccTrnDetail.AccCoaSubCoaMainAccName, true));
            values.Add(new FieldValue("Debit", original_AccTrnDetail.Debit, theAccTrnDetail.Debit));
            values.Add(new FieldValue("Credit", original_AccTrnDetail.Credit, theAccTrnDetail.Credit));
            values.Add(new FieldValue("Tran_Comment", original_AccTrnDetail.Tran_Comment, theAccTrnDetail.Tran_Comment));
            values.Add(new FieldValue("RevAcc", original_AccTrnDetail.RevAcc, theAccTrnDetail.RevAcc));
            values.Add(new FieldValue("AccCurrency", original_AccTrnDetail.AccCurrency, theAccTrnDetail.AccCurrency));
            values.Add(new FieldValue("AccCurrencyAccCurrencyName", original_AccTrnDetail.AccCurrencyAccCurrencyName, theAccTrnDetail.AccCurrencyAccCurrencyName, true));
            values.Add(new FieldValue("AccCurrencyRate", original_AccTrnDetail.AccCurrencyRate, theAccTrnDetail.AccCurrencyRate));
            values.Add(new FieldValue("AccSubTypeID", original_AccTrnDetail.AccSubTypeID, theAccTrnDetail.AccSubTypeID));
            values.Add(new FieldValue("AccSubTypeAccSubType", original_AccTrnDetail.AccSubTypeAccSubType, theAccTrnDetail.AccSubTypeAccSubType, true));
            values.Add(new FieldValue("AccSubCode", original_AccTrnDetail.AccSubCode, theAccTrnDetail.AccSubCode));
            values.Add(new FieldValue("AccSubAccSubName", original_AccTrnDetail.AccSubAccSubName, theAccTrnDetail.AccSubAccSubName, true));
            values.Add(new FieldValue("AccSubAccSubTypeAccSubType", original_AccTrnDetail.AccSubAccSubTypeAccSubType, theAccTrnDetail.AccSubAccSubTypeAccSubType, true));
            values.Add(new FieldValue("TrStat", original_AccTrnDetail.TrStat, theAccTrnDetail.TrStat));
            values.Add(new FieldValue("DLT", original_AccTrnDetail.DLT, theAccTrnDetail.DLT));
            values.Add(new FieldValue("AccBranchCode", original_AccTrnDetail.AccBranchCode, theAccTrnDetail.AccBranchCode));
            values.Add(new FieldValue("Challan_no", original_AccTrnDetail.Challan_no, theAccTrnDetail.Challan_no));
            values.Add(new FieldValue("MrnNo", original_AccTrnDetail.MrnNo, theAccTrnDetail.MrnNo));
            values.Add(new FieldValue("Stat", original_AccTrnDetail.Stat, theAccTrnDetail.Stat));
            values.Add(new FieldValue("Chequeno", original_AccTrnDetail.Chequeno, theAccTrnDetail.Chequeno));
            values.Add(new FieldValue("TranCode", original_AccTrnDetail.TranCode, theAccTrnDetail.TranCode));
            values.Add(new FieldValue("DepartmentsID", original_AccTrnDetail.DepartmentsID, theAccTrnDetail.DepartmentsID));
            values.Add(new FieldValue("VchrNo", original_AccTrnDetail.VchrNo, theAccTrnDetail.VchrNo));
            values.Add(new FieldValue("VchrLock", original_AccTrnDetail.VchrLock, theAccTrnDetail.VchrLock));
            values.Add(new FieldValue("TransitYN", original_AccTrnDetail.TransitYN, theAccTrnDetail.TransitYN));
            values.Add(new FieldValue("IsPosted", original_AccTrnDetail.IsPosted, theAccTrnDetail.IsPosted));
            values.Add(new FieldValue("IsRevtran", original_AccTrnDetail.IsRevtran, theAccTrnDetail.IsRevtran));
            values.Add(new FieldValue("IsTransitReceived", original_AccTrnDetail.IsTransitReceived, theAccTrnDetail.IsTransitReceived));
            values.Add(new FieldValue("AccSubTypeID1", original_AccTrnDetail.AccSubTypeID1, theAccTrnDetail.AccSubTypeID1));
            values.Add(new FieldValue("AccSubCode1", original_AccTrnDetail.AccSubCode1, theAccTrnDetail.AccSubCode1));
            values.Add(new FieldValue("AccSubTypeID2", original_AccTrnDetail.AccSubTypeID2, theAccTrnDetail.AccSubTypeID2));
            values.Add(new FieldValue("AccSubCode2", original_AccTrnDetail.AccSubCode2, theAccTrnDetail.AccSubCode2));
            values.Add(new FieldValue("ChequeDT", original_AccTrnDetail.ChequeDT, theAccTrnDetail.ChequeDT));
            values.Add(new FieldValue("ChequeBankBranch", original_AccTrnDetail.ChequeBankBranch, theAccTrnDetail.ChequeBankBranch));
            values.Add(new FieldValue("IsChequeHonour", original_AccTrnDetail.IsChequeHonour, theAccTrnDetail.IsChequeHonour));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.AccTrnDetail theAccTrnDetail, MyCompany.Data.Objects.AccTrnDetail original_AccTrnDetail, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "AccTrnDetail";
            args.View = dataView;
            args.Values = CreateFieldValues(theAccTrnDetail, original_AccTrnDetail);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("AccTrnDetail", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theAccTrnDetail);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.AccTrnDetail theAccTrnDetail, MyCompany.Data.Objects.AccTrnDetail original_AccTrnDetail)
        {
            return ExecuteAction(theAccTrnDetail, original_AccTrnDetail, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.AccTrnDetail theAccTrnDetail)
        {
            return Update(theAccTrnDetail, SelectSingle(theAccTrnDetail.AccTrnDetailID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.AccTrnDetail theAccTrnDetail)
        {
            return ExecuteAction(theAccTrnDetail, new AccTrnDetail(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.AccTrnDetail theAccTrnDetail)
        {
            return ExecuteAction(theAccTrnDetail, theAccTrnDetail, "Select", "Delete", DeleteView);
        }
    }
}
