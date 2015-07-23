using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class ImpresstFundTrans
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _impFundTranID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _impresstFundID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _impresstFundReference;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _impresstFundAccSubAccSubName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _impresstFundAccSubAccSubTypeAccSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _impresstFundAccSubTypeAccSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _impresstFundCoaDetailAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _impresstFundCoaDetailAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _impresstFundCoaDetailAccCurrencyAccCurrencyName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _impresstFundCoaDetailAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _impresstFundCoaDetailAccFundAccFundName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _impresstFundCoaDetailAccSubTypeAccSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _impresstFundCoaDetailAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _impresstFundCoaDetailCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _impresstFundCoaDetailCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _impresstFundCoaDetailCoaSubAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accFundID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accFundAccFundName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _tranDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _slipNo;
        
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
        private string _coaDetailAccFundAccFundName;
        
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
        private string _coaDetailCoaMainAccFundAccFundName;
        
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
        private string _coaDetailCoaSubAccFundAccFundName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaDetailCoaSubAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaDetailCoaSubCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coaDetailCoaSubCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _amount;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _isCashCheque;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _isPayReceived;
        
        public ImpresstFundTrans()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? ImpFundTranID
        {
            get
            {
                return _impFundTranID;
            }
            set
            {
                _impFundTranID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public int? ImpresstFundID
        {
            get
            {
                return _impresstFundID;
            }
            set
            {
                _impresstFundID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ImpresstFundReference
        {
            get
            {
                return _impresstFundReference;
            }
            set
            {
                _impresstFundReference = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ImpresstFundAccSubAccSubName
        {
            get
            {
                return _impresstFundAccSubAccSubName;
            }
            set
            {
                _impresstFundAccSubAccSubName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ImpresstFundAccSubAccSubTypeAccSubType
        {
            get
            {
                return _impresstFundAccSubAccSubTypeAccSubType;
            }
            set
            {
                _impresstFundAccSubAccSubTypeAccSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ImpresstFundAccSubTypeAccSubType
        {
            get
            {
                return _impresstFundAccSubTypeAccSubType;
            }
            set
            {
                _impresstFundAccSubTypeAccSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ImpresstFundCoaDetailAccName
        {
            get
            {
                return _impresstFundCoaDetailAccName;
            }
            set
            {
                _impresstFundCoaDetailAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ImpresstFundCoaDetailAccBalTypeAccBalType
        {
            get
            {
                return _impresstFundCoaDetailAccBalTypeAccBalType;
            }
            set
            {
                _impresstFundCoaDetailAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ImpresstFundCoaDetailAccCurrencyAccCurrencyName
        {
            get
            {
                return _impresstFundCoaDetailAccCurrencyAccCurrencyName;
            }
            set
            {
                _impresstFundCoaDetailAccCurrencyAccCurrencyName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ImpresstFundCoaDetailAccDestAccDest
        {
            get
            {
                return _impresstFundCoaDetailAccDestAccDest;
            }
            set
            {
                _impresstFundCoaDetailAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ImpresstFundCoaDetailAccFundAccFundName
        {
            get
            {
                return _impresstFundCoaDetailAccFundAccFundName;
            }
            set
            {
                _impresstFundCoaDetailAccFundAccFundName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ImpresstFundCoaDetailAccSubTypeAccSubType
        {
            get
            {
                return _impresstFundCoaDetailAccSubTypeAccSubType;
            }
            set
            {
                _impresstFundCoaDetailAccSubTypeAccSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ImpresstFundCoaDetailAccTypeAccType
        {
            get
            {
                return _impresstFundCoaDetailAccTypeAccType;
            }
            set
            {
                _impresstFundCoaDetailAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ImpresstFundCoaDetailCoaControlAccName
        {
            get
            {
                return _impresstFundCoaDetailCoaControlAccName;
            }
            set
            {
                _impresstFundCoaDetailCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ImpresstFundCoaDetailCoaMainAccName
        {
            get
            {
                return _impresstFundCoaDetailCoaMainAccName;
            }
            set
            {
                _impresstFundCoaDetailCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ImpresstFundCoaDetailCoaSubAccName
        {
            get
            {
                return _impresstFundCoaDetailCoaSubAccName;
            }
            set
            {
                _impresstFundCoaDetailCoaSubAccName = value;
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
        public DateTime? TranDate
        {
            get
            {
                return _tranDate;
            }
            set
            {
                _tranDate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? SlipNo
        {
            get
            {
                return _slipNo;
            }
            set
            {
                _slipNo = value;
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
        public string CoaDetailAccFundAccFundName
        {
            get
            {
                return _coaDetailAccFundAccFundName;
            }
            set
            {
                _coaDetailAccFundAccFundName = value;
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
        public string CoaDetailCoaMainAccFundAccFundName
        {
            get
            {
                return _coaDetailCoaMainAccFundAccFundName;
            }
            set
            {
                _coaDetailCoaMainAccFundAccFundName = value;
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
        public string CoaDetailCoaSubAccFundAccFundName
        {
            get
            {
                return _coaDetailCoaSubAccFundAccFundName;
            }
            set
            {
                _coaDetailCoaSubAccFundAccFundName = value;
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
        public int? IsCashCheque
        {
            get
            {
                return _isCashCheque;
            }
            set
            {
                _isCashCheque = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public int? IsPayReceived
        {
            get
            {
                return _isPayReceived;
            }
            set
            {
                _isPayReceived = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.ImpresstFundTrans> Select(
                    int? impFundTranID, 
                    int? impresstFundID, 
                    string impresstFundReference, 
                    string impresstFundAccSubAccSubName, 
                    string impresstFundAccSubAccSubTypeAccSubType, 
                    string impresstFundAccSubTypeAccSubType, 
                    string impresstFundCoaDetailAccName, 
                    string impresstFundCoaDetailAccBalTypeAccBalType, 
                    string impresstFundCoaDetailAccCurrencyAccCurrencyName, 
                    string impresstFundCoaDetailAccDestAccDest, 
                    string impresstFundCoaDetailAccFundAccFundName, 
                    string impresstFundCoaDetailAccSubTypeAccSubType, 
                    string impresstFundCoaDetailAccTypeAccType, 
                    string impresstFundCoaDetailCoaControlAccName, 
                    string impresstFundCoaDetailCoaMainAccName, 
                    string impresstFundCoaDetailCoaSubAccName, 
                    int? accFundID, 
                    string accFundAccFundName, 
                    DateTime? tranDate, 
                    int? slipNo, 
                    int? coaDetailID, 
                    string coaDetailAccName, 
                    string coaDetailAccBalTypeAccBalType, 
                    string coaDetailAccCurrencyAccCurrencyName, 
                    string coaDetailAccDestAccDest, 
                    string coaDetailAccDestCompanyTypeDescription, 
                    string coaDetailAccFundAccFundName, 
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
                    string coaDetailCoaMainAccFundAccFundName, 
                    string coaDetailCoaMainAccTypeAccType, 
                    string coaDetailCoaMainCoaControlAccName, 
                    string coaDetailCoaSubAccName, 
                    string coaDetailCoaSubAccBalTypeAccBalType, 
                    string coaDetailCoaSubAccDestAccDest, 
                    string coaDetailCoaSubAccFundAccFundName, 
                    string coaDetailCoaSubAccTypeAccType, 
                    string coaDetailCoaSubCoaControlAccName, 
                    string coaDetailCoaSubCoaMainAccName, 
                    decimal? amount, 
                    int? isCashCheque, 
                    int? isPayReceived)
        {
            return new ImpresstFundTransFactory().Select(impFundTranID, impresstFundID, impresstFundReference, impresstFundAccSubAccSubName, impresstFundAccSubAccSubTypeAccSubType, impresstFundAccSubTypeAccSubType, impresstFundCoaDetailAccName, impresstFundCoaDetailAccBalTypeAccBalType, impresstFundCoaDetailAccCurrencyAccCurrencyName, impresstFundCoaDetailAccDestAccDest, impresstFundCoaDetailAccFundAccFundName, impresstFundCoaDetailAccSubTypeAccSubType, impresstFundCoaDetailAccTypeAccType, impresstFundCoaDetailCoaControlAccName, impresstFundCoaDetailCoaMainAccName, impresstFundCoaDetailCoaSubAccName, accFundID, accFundAccFundName, tranDate, slipNo, coaDetailID, coaDetailAccName, coaDetailAccBalTypeAccBalType, coaDetailAccCurrencyAccCurrencyName, coaDetailAccDestAccDest, coaDetailAccDestCompanyTypeDescription, coaDetailAccFundAccFundName, coaDetailAccSubTypeAccSubType, coaDetailAccTypeAccType, coaDetailCoaControlAccName, coaDetailCoaControlAccBalTypeAccBalType, coaDetailCoaControlAccDestAccDest, coaDetailCoaControlAccTypeAccType, coaDetailCoaControlCompTypeDescription, coaDetailCoaMainAccName, coaDetailCoaMainAccBalTypeAccBalType, coaDetailCoaMainAccDestAccDest, coaDetailCoaMainAccFundAccFundName, coaDetailCoaMainAccTypeAccType, coaDetailCoaMainCoaControlAccName, coaDetailCoaSubAccName, coaDetailCoaSubAccBalTypeAccBalType, coaDetailCoaSubAccDestAccDest, coaDetailCoaSubAccFundAccFundName, coaDetailCoaSubAccTypeAccType, coaDetailCoaSubCoaControlAccName, coaDetailCoaSubCoaMainAccName, amount, isCashCheque, isPayReceived);
        }
        
        public static List<MyCompany.Data.Objects.ImpresstFundTrans> Select(MyCompany.Data.Objects.ImpresstFundTrans qbe)
        {
            return new ImpresstFundTransFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.ImpresstFundTrans> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new ImpresstFundTransFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.ImpresstFundTrans> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new ImpresstFundTransFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.ImpresstFundTrans> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new ImpresstFundTransFactory().Select(filter, sort, ImpresstFundTransFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.ImpresstFundTrans> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new ImpresstFundTransFactory().Select(filter, sort, ImpresstFundTransFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.ImpresstFundTrans> Select(string filter, BusinessObjectParameters parameters)
        {
            return new ImpresstFundTransFactory().Select(filter, null, ImpresstFundTransFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.ImpresstFundTrans> Select(string filter, params FieldValue[] parameters)
        {
            return new ImpresstFundTransFactory().Select(filter, null, ImpresstFundTransFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.ImpresstFundTrans SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new ImpresstFundTransFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.ImpresstFundTrans SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new ImpresstFundTransFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.ImpresstFundTrans SelectSingle(int? impFundTranID)
        {
            return new ImpresstFundTransFactory().SelectSingle(impFundTranID);
        }
        
        public int Insert()
        {
            return new ImpresstFundTransFactory().Insert(this);
        }
        
        public int Update()
        {
            return new ImpresstFundTransFactory().Update(this);
        }
        
        public int Delete()
        {
            return new ImpresstFundTransFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("ImpFundTranID: {0}", this.ImpFundTranID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class ImpresstFundTransFactory
    {
        
        public ImpresstFundTransFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("ImpresstFundTrans");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("ImpresstFundTrans");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("ImpresstFundTrans");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("ImpresstFundTrans");
            }
        }
        
        public static ImpresstFundTransFactory Create()
        {
            return new ImpresstFundTransFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    int? impFundTranID, 
                    int? impresstFundID, 
                    string impresstFundReference, 
                    string impresstFundAccSubAccSubName, 
                    string impresstFundAccSubAccSubTypeAccSubType, 
                    string impresstFundAccSubTypeAccSubType, 
                    string impresstFundCoaDetailAccName, 
                    string impresstFundCoaDetailAccBalTypeAccBalType, 
                    string impresstFundCoaDetailAccCurrencyAccCurrencyName, 
                    string impresstFundCoaDetailAccDestAccDest, 
                    string impresstFundCoaDetailAccFundAccFundName, 
                    string impresstFundCoaDetailAccSubTypeAccSubType, 
                    string impresstFundCoaDetailAccTypeAccType, 
                    string impresstFundCoaDetailCoaControlAccName, 
                    string impresstFundCoaDetailCoaMainAccName, 
                    string impresstFundCoaDetailCoaSubAccName, 
                    int? accFundID, 
                    string accFundAccFundName, 
                    DateTime? tranDate, 
                    int? slipNo, 
                    int? coaDetailID, 
                    string coaDetailAccName, 
                    string coaDetailAccBalTypeAccBalType, 
                    string coaDetailAccCurrencyAccCurrencyName, 
                    string coaDetailAccDestAccDest, 
                    string coaDetailAccDestCompanyTypeDescription, 
                    string coaDetailAccFundAccFundName, 
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
                    string coaDetailCoaMainAccFundAccFundName, 
                    string coaDetailCoaMainAccTypeAccType, 
                    string coaDetailCoaMainCoaControlAccName, 
                    string coaDetailCoaSubAccName, 
                    string coaDetailCoaSubAccBalTypeAccBalType, 
                    string coaDetailCoaSubAccDestAccDest, 
                    string coaDetailCoaSubAccFundAccFundName, 
                    string coaDetailCoaSubAccTypeAccType, 
                    string coaDetailCoaSubCoaControlAccName, 
                    string coaDetailCoaSubCoaMainAccName, 
                    decimal? amount, 
                    int? isCashCheque, 
                    int? isPayReceived, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (impFundTranID.HasValue)
            	filter.Add(("ImpFundTranID:=" + impFundTranID.Value.ToString()));
            if (impresstFundID.HasValue)
            	filter.Add(("ImpresstFundID:=" + impresstFundID.Value.ToString()));
            if (!(String.IsNullOrEmpty(impresstFundReference)))
            	filter.Add(("ImpresstFundReference:*" + impresstFundReference));
            if (!(String.IsNullOrEmpty(impresstFundAccSubAccSubName)))
            	filter.Add(("ImpresstFundAccSubAccSubName:*" + impresstFundAccSubAccSubName));
            if (!(String.IsNullOrEmpty(impresstFundAccSubAccSubTypeAccSubType)))
            	filter.Add(("ImpresstFundAccSubAccSubTypeAccSubType:*" + impresstFundAccSubAccSubTypeAccSubType));
            if (!(String.IsNullOrEmpty(impresstFundAccSubTypeAccSubType)))
            	filter.Add(("ImpresstFundAccSubTypeAccSubType:*" + impresstFundAccSubTypeAccSubType));
            if (!(String.IsNullOrEmpty(impresstFundCoaDetailAccName)))
            	filter.Add(("ImpresstFundCoaDetailAccName:*" + impresstFundCoaDetailAccName));
            if (!(String.IsNullOrEmpty(impresstFundCoaDetailAccBalTypeAccBalType)))
            	filter.Add(("ImpresstFundCoaDetailAccBalTypeAccBalType:*" + impresstFundCoaDetailAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(impresstFundCoaDetailAccCurrencyAccCurrencyName)))
            	filter.Add(("ImpresstFundCoaDetailAccCurrencyAccCurrencyName:*" + impresstFundCoaDetailAccCurrencyAccCurrencyName));
            if (!(String.IsNullOrEmpty(impresstFundCoaDetailAccDestAccDest)))
            	filter.Add(("ImpresstFundCoaDetailAccDestAccDest:*" + impresstFundCoaDetailAccDestAccDest));
            if (!(String.IsNullOrEmpty(impresstFundCoaDetailAccFundAccFundName)))
            	filter.Add(("ImpresstFundCoaDetailAccFundAccFundName:*" + impresstFundCoaDetailAccFundAccFundName));
            if (!(String.IsNullOrEmpty(impresstFundCoaDetailAccSubTypeAccSubType)))
            	filter.Add(("ImpresstFundCoaDetailAccSubTypeAccSubType:*" + impresstFundCoaDetailAccSubTypeAccSubType));
            if (!(String.IsNullOrEmpty(impresstFundCoaDetailAccTypeAccType)))
            	filter.Add(("ImpresstFundCoaDetailAccTypeAccType:*" + impresstFundCoaDetailAccTypeAccType));
            if (!(String.IsNullOrEmpty(impresstFundCoaDetailCoaControlAccName)))
            	filter.Add(("ImpresstFundCoaDetailCoaControlAccName:*" + impresstFundCoaDetailCoaControlAccName));
            if (!(String.IsNullOrEmpty(impresstFundCoaDetailCoaMainAccName)))
            	filter.Add(("ImpresstFundCoaDetailCoaMainAccName:*" + impresstFundCoaDetailCoaMainAccName));
            if (!(String.IsNullOrEmpty(impresstFundCoaDetailCoaSubAccName)))
            	filter.Add(("ImpresstFundCoaDetailCoaSubAccName:*" + impresstFundCoaDetailCoaSubAccName));
            if (accFundID.HasValue)
            	filter.Add(("AccFundID:=" + accFundID.Value.ToString()));
            if (!(String.IsNullOrEmpty(accFundAccFundName)))
            	filter.Add(("AccFundAccFundName:*" + accFundAccFundName));
            if (tranDate.HasValue)
            	filter.Add(("TranDate:=" + tranDate.Value.ToString()));
            if (slipNo.HasValue)
            	filter.Add(("SlipNo:=" + slipNo.Value.ToString()));
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
            if (!(String.IsNullOrEmpty(coaDetailAccFundAccFundName)))
            	filter.Add(("CoaDetailAccFundAccFundName:*" + coaDetailAccFundAccFundName));
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
            if (!(String.IsNullOrEmpty(coaDetailCoaMainAccFundAccFundName)))
            	filter.Add(("CoaDetailCoaMainAccFundAccFundName:*" + coaDetailCoaMainAccFundAccFundName));
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
            if (!(String.IsNullOrEmpty(coaDetailCoaSubAccFundAccFundName)))
            	filter.Add(("CoaDetailCoaSubAccFundAccFundName:*" + coaDetailCoaSubAccFundAccFundName));
            if (!(String.IsNullOrEmpty(coaDetailCoaSubAccTypeAccType)))
            	filter.Add(("CoaDetailCoaSubAccTypeAccType:*" + coaDetailCoaSubAccTypeAccType));
            if (!(String.IsNullOrEmpty(coaDetailCoaSubCoaControlAccName)))
            	filter.Add(("CoaDetailCoaSubCoaControlAccName:*" + coaDetailCoaSubCoaControlAccName));
            if (!(String.IsNullOrEmpty(coaDetailCoaSubCoaMainAccName)))
            	filter.Add(("CoaDetailCoaSubCoaMainAccName:*" + coaDetailCoaSubCoaMainAccName));
            if (amount.HasValue)
            	filter.Add(("Amount:=" + amount.Value.ToString()));
            if (isCashCheque.HasValue)
            	filter.Add(("IsCashCheque:=" + isCashCheque.Value.ToString()));
            if (isPayReceived.HasValue)
            	filter.Add(("IsPayReceived:=" + isPayReceived.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.ImpresstFundTrans> Select(
                    int? impFundTranID, 
                    int? impresstFundID, 
                    string impresstFundReference, 
                    string impresstFundAccSubAccSubName, 
                    string impresstFundAccSubAccSubTypeAccSubType, 
                    string impresstFundAccSubTypeAccSubType, 
                    string impresstFundCoaDetailAccName, 
                    string impresstFundCoaDetailAccBalTypeAccBalType, 
                    string impresstFundCoaDetailAccCurrencyAccCurrencyName, 
                    string impresstFundCoaDetailAccDestAccDest, 
                    string impresstFundCoaDetailAccFundAccFundName, 
                    string impresstFundCoaDetailAccSubTypeAccSubType, 
                    string impresstFundCoaDetailAccTypeAccType, 
                    string impresstFundCoaDetailCoaControlAccName, 
                    string impresstFundCoaDetailCoaMainAccName, 
                    string impresstFundCoaDetailCoaSubAccName, 
                    int? accFundID, 
                    string accFundAccFundName, 
                    DateTime? tranDate, 
                    int? slipNo, 
                    int? coaDetailID, 
                    string coaDetailAccName, 
                    string coaDetailAccBalTypeAccBalType, 
                    string coaDetailAccCurrencyAccCurrencyName, 
                    string coaDetailAccDestAccDest, 
                    string coaDetailAccDestCompanyTypeDescription, 
                    string coaDetailAccFundAccFundName, 
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
                    string coaDetailCoaMainAccFundAccFundName, 
                    string coaDetailCoaMainAccTypeAccType, 
                    string coaDetailCoaMainCoaControlAccName, 
                    string coaDetailCoaSubAccName, 
                    string coaDetailCoaSubAccBalTypeAccBalType, 
                    string coaDetailCoaSubAccDestAccDest, 
                    string coaDetailCoaSubAccFundAccFundName, 
                    string coaDetailCoaSubAccTypeAccType, 
                    string coaDetailCoaSubCoaControlAccName, 
                    string coaDetailCoaSubCoaMainAccName, 
                    decimal? amount, 
                    int? isCashCheque, 
                    int? isPayReceived, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(impFundTranID, impresstFundID, impresstFundReference, impresstFundAccSubAccSubName, impresstFundAccSubAccSubTypeAccSubType, impresstFundAccSubTypeAccSubType, impresstFundCoaDetailAccName, impresstFundCoaDetailAccBalTypeAccBalType, impresstFundCoaDetailAccCurrencyAccCurrencyName, impresstFundCoaDetailAccDestAccDest, impresstFundCoaDetailAccFundAccFundName, impresstFundCoaDetailAccSubTypeAccSubType, impresstFundCoaDetailAccTypeAccType, impresstFundCoaDetailCoaControlAccName, impresstFundCoaDetailCoaMainAccName, impresstFundCoaDetailCoaSubAccName, accFundID, accFundAccFundName, tranDate, slipNo, coaDetailID, coaDetailAccName, coaDetailAccBalTypeAccBalType, coaDetailAccCurrencyAccCurrencyName, coaDetailAccDestAccDest, coaDetailAccDestCompanyTypeDescription, coaDetailAccFundAccFundName, coaDetailAccSubTypeAccSubType, coaDetailAccTypeAccType, coaDetailCoaControlAccName, coaDetailCoaControlAccBalTypeAccBalType, coaDetailCoaControlAccDestAccDest, coaDetailCoaControlAccTypeAccType, coaDetailCoaControlCompTypeDescription, coaDetailCoaMainAccName, coaDetailCoaMainAccBalTypeAccBalType, coaDetailCoaMainAccDestAccDest, coaDetailCoaMainAccFundAccFundName, coaDetailCoaMainAccTypeAccType, coaDetailCoaMainCoaControlAccName, coaDetailCoaSubAccName, coaDetailCoaSubAccBalTypeAccBalType, coaDetailCoaSubAccDestAccDest, coaDetailCoaSubAccFundAccFundName, coaDetailCoaSubAccTypeAccType, coaDetailCoaSubCoaControlAccName, coaDetailCoaSubCoaMainAccName, amount, isCashCheque, isPayReceived, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("ImpresstFundTrans", dataView, request);
            return page.ToList<MyCompany.Data.Objects.ImpresstFundTrans>();
        }
        
        public List<MyCompany.Data.Objects.ImpresstFundTrans> Select(MyCompany.Data.Objects.ImpresstFundTrans qbe)
        {
            return Select(qbe.ImpFundTranID, qbe.ImpresstFundID, qbe.ImpresstFundReference, qbe.ImpresstFundAccSubAccSubName, qbe.ImpresstFundAccSubAccSubTypeAccSubType, qbe.ImpresstFundAccSubTypeAccSubType, qbe.ImpresstFundCoaDetailAccName, qbe.ImpresstFundCoaDetailAccBalTypeAccBalType, qbe.ImpresstFundCoaDetailAccCurrencyAccCurrencyName, qbe.ImpresstFundCoaDetailAccDestAccDest, qbe.ImpresstFundCoaDetailAccFundAccFundName, qbe.ImpresstFundCoaDetailAccSubTypeAccSubType, qbe.ImpresstFundCoaDetailAccTypeAccType, qbe.ImpresstFundCoaDetailCoaControlAccName, qbe.ImpresstFundCoaDetailCoaMainAccName, qbe.ImpresstFundCoaDetailCoaSubAccName, qbe.AccFundID, qbe.AccFundAccFundName, qbe.TranDate, qbe.SlipNo, qbe.CoaDetailID, qbe.CoaDetailAccName, qbe.CoaDetailAccBalTypeAccBalType, qbe.CoaDetailAccCurrencyAccCurrencyName, qbe.CoaDetailAccDestAccDest, qbe.CoaDetailAccDestCompanyTypeDescription, qbe.CoaDetailAccFundAccFundName, qbe.CoaDetailAccSubTypeAccSubType, qbe.CoaDetailAccTypeAccType, qbe.CoaDetailCoaControlAccName, qbe.CoaDetailCoaControlAccBalTypeAccBalType, qbe.CoaDetailCoaControlAccDestAccDest, qbe.CoaDetailCoaControlAccTypeAccType, qbe.CoaDetailCoaControlCompTypeDescription, qbe.CoaDetailCoaMainAccName, qbe.CoaDetailCoaMainAccBalTypeAccBalType, qbe.CoaDetailCoaMainAccDestAccDest, qbe.CoaDetailCoaMainAccFundAccFundName, qbe.CoaDetailCoaMainAccTypeAccType, qbe.CoaDetailCoaMainCoaControlAccName, qbe.CoaDetailCoaSubAccName, qbe.CoaDetailCoaSubAccBalTypeAccBalType, qbe.CoaDetailCoaSubAccDestAccDest, qbe.CoaDetailCoaSubAccFundAccFundName, qbe.CoaDetailCoaSubAccTypeAccType, qbe.CoaDetailCoaSubCoaControlAccName, qbe.CoaDetailCoaSubCoaMainAccName, qbe.Amount, qbe.IsCashCheque, qbe.IsPayReceived);
        }
        
        public int SelectCount(
                    int? impFundTranID, 
                    int? impresstFundID, 
                    string impresstFundReference, 
                    string impresstFundAccSubAccSubName, 
                    string impresstFundAccSubAccSubTypeAccSubType, 
                    string impresstFundAccSubTypeAccSubType, 
                    string impresstFundCoaDetailAccName, 
                    string impresstFundCoaDetailAccBalTypeAccBalType, 
                    string impresstFundCoaDetailAccCurrencyAccCurrencyName, 
                    string impresstFundCoaDetailAccDestAccDest, 
                    string impresstFundCoaDetailAccFundAccFundName, 
                    string impresstFundCoaDetailAccSubTypeAccSubType, 
                    string impresstFundCoaDetailAccTypeAccType, 
                    string impresstFundCoaDetailCoaControlAccName, 
                    string impresstFundCoaDetailCoaMainAccName, 
                    string impresstFundCoaDetailCoaSubAccName, 
                    int? accFundID, 
                    string accFundAccFundName, 
                    DateTime? tranDate, 
                    int? slipNo, 
                    int? coaDetailID, 
                    string coaDetailAccName, 
                    string coaDetailAccBalTypeAccBalType, 
                    string coaDetailAccCurrencyAccCurrencyName, 
                    string coaDetailAccDestAccDest, 
                    string coaDetailAccDestCompanyTypeDescription, 
                    string coaDetailAccFundAccFundName, 
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
                    string coaDetailCoaMainAccFundAccFundName, 
                    string coaDetailCoaMainAccTypeAccType, 
                    string coaDetailCoaMainCoaControlAccName, 
                    string coaDetailCoaSubAccName, 
                    string coaDetailCoaSubAccBalTypeAccBalType, 
                    string coaDetailCoaSubAccDestAccDest, 
                    string coaDetailCoaSubAccFundAccFundName, 
                    string coaDetailCoaSubAccTypeAccType, 
                    string coaDetailCoaSubCoaControlAccName, 
                    string coaDetailCoaSubCoaMainAccName, 
                    decimal? amount, 
                    int? isCashCheque, 
                    int? isPayReceived, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(impFundTranID, impresstFundID, impresstFundReference, impresstFundAccSubAccSubName, impresstFundAccSubAccSubTypeAccSubType, impresstFundAccSubTypeAccSubType, impresstFundCoaDetailAccName, impresstFundCoaDetailAccBalTypeAccBalType, impresstFundCoaDetailAccCurrencyAccCurrencyName, impresstFundCoaDetailAccDestAccDest, impresstFundCoaDetailAccFundAccFundName, impresstFundCoaDetailAccSubTypeAccSubType, impresstFundCoaDetailAccTypeAccType, impresstFundCoaDetailCoaControlAccName, impresstFundCoaDetailCoaMainAccName, impresstFundCoaDetailCoaSubAccName, accFundID, accFundAccFundName, tranDate, slipNo, coaDetailID, coaDetailAccName, coaDetailAccBalTypeAccBalType, coaDetailAccCurrencyAccCurrencyName, coaDetailAccDestAccDest, coaDetailAccDestCompanyTypeDescription, coaDetailAccFundAccFundName, coaDetailAccSubTypeAccSubType, coaDetailAccTypeAccType, coaDetailCoaControlAccName, coaDetailCoaControlAccBalTypeAccBalType, coaDetailCoaControlAccDestAccDest, coaDetailCoaControlAccTypeAccType, coaDetailCoaControlCompTypeDescription, coaDetailCoaMainAccName, coaDetailCoaMainAccBalTypeAccBalType, coaDetailCoaMainAccDestAccDest, coaDetailCoaMainAccFundAccFundName, coaDetailCoaMainAccTypeAccType, coaDetailCoaMainCoaControlAccName, coaDetailCoaSubAccName, coaDetailCoaSubAccBalTypeAccBalType, coaDetailCoaSubAccDestAccDest, coaDetailCoaSubAccFundAccFundName, coaDetailCoaSubAccTypeAccType, coaDetailCoaSubCoaControlAccName, coaDetailCoaSubCoaMainAccName, amount, isCashCheque, isPayReceived, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("ImpresstFundTrans", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.ImpresstFundTrans> Select(
                    int? impFundTranID, 
                    int? impresstFundID, 
                    string impresstFundReference, 
                    string impresstFundAccSubAccSubName, 
                    string impresstFundAccSubAccSubTypeAccSubType, 
                    string impresstFundAccSubTypeAccSubType, 
                    string impresstFundCoaDetailAccName, 
                    string impresstFundCoaDetailAccBalTypeAccBalType, 
                    string impresstFundCoaDetailAccCurrencyAccCurrencyName, 
                    string impresstFundCoaDetailAccDestAccDest, 
                    string impresstFundCoaDetailAccFundAccFundName, 
                    string impresstFundCoaDetailAccSubTypeAccSubType, 
                    string impresstFundCoaDetailAccTypeAccType, 
                    string impresstFundCoaDetailCoaControlAccName, 
                    string impresstFundCoaDetailCoaMainAccName, 
                    string impresstFundCoaDetailCoaSubAccName, 
                    int? accFundID, 
                    string accFundAccFundName, 
                    DateTime? tranDate, 
                    int? slipNo, 
                    int? coaDetailID, 
                    string coaDetailAccName, 
                    string coaDetailAccBalTypeAccBalType, 
                    string coaDetailAccCurrencyAccCurrencyName, 
                    string coaDetailAccDestAccDest, 
                    string coaDetailAccDestCompanyTypeDescription, 
                    string coaDetailAccFundAccFundName, 
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
                    string coaDetailCoaMainAccFundAccFundName, 
                    string coaDetailCoaMainAccTypeAccType, 
                    string coaDetailCoaMainCoaControlAccName, 
                    string coaDetailCoaSubAccName, 
                    string coaDetailCoaSubAccBalTypeAccBalType, 
                    string coaDetailCoaSubAccDestAccDest, 
                    string coaDetailCoaSubAccFundAccFundName, 
                    string coaDetailCoaSubAccTypeAccType, 
                    string coaDetailCoaSubCoaControlAccName, 
                    string coaDetailCoaSubCoaMainAccName, 
                    decimal? amount, 
                    int? isCashCheque, 
                    int? isPayReceived)
        {
            return Select(impFundTranID, impresstFundID, impresstFundReference, impresstFundAccSubAccSubName, impresstFundAccSubAccSubTypeAccSubType, impresstFundAccSubTypeAccSubType, impresstFundCoaDetailAccName, impresstFundCoaDetailAccBalTypeAccBalType, impresstFundCoaDetailAccCurrencyAccCurrencyName, impresstFundCoaDetailAccDestAccDest, impresstFundCoaDetailAccFundAccFundName, impresstFundCoaDetailAccSubTypeAccSubType, impresstFundCoaDetailAccTypeAccType, impresstFundCoaDetailCoaControlAccName, impresstFundCoaDetailCoaMainAccName, impresstFundCoaDetailCoaSubAccName, accFundID, accFundAccFundName, tranDate, slipNo, coaDetailID, coaDetailAccName, coaDetailAccBalTypeAccBalType, coaDetailAccCurrencyAccCurrencyName, coaDetailAccDestAccDest, coaDetailAccDestCompanyTypeDescription, coaDetailAccFundAccFundName, coaDetailAccSubTypeAccSubType, coaDetailAccTypeAccType, coaDetailCoaControlAccName, coaDetailCoaControlAccBalTypeAccBalType, coaDetailCoaControlAccDestAccDest, coaDetailCoaControlAccTypeAccType, coaDetailCoaControlCompTypeDescription, coaDetailCoaMainAccName, coaDetailCoaMainAccBalTypeAccBalType, coaDetailCoaMainAccDestAccDest, coaDetailCoaMainAccFundAccFundName, coaDetailCoaMainAccTypeAccType, coaDetailCoaMainCoaControlAccName, coaDetailCoaSubAccName, coaDetailCoaSubAccBalTypeAccBalType, coaDetailCoaSubAccDestAccDest, coaDetailCoaSubAccFundAccFundName, coaDetailCoaSubAccTypeAccType, coaDetailCoaSubCoaControlAccName, coaDetailCoaSubCoaMainAccName, amount, isCashCheque, isPayReceived, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.ImpresstFundTrans SelectSingle(int? impFundTranID)
        {
            List<MyCompany.Data.Objects.ImpresstFundTrans> list = Select(impFundTranID, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.ImpresstFundTrans> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("ImpresstFundTrans", dataView, request);
            return page.ToList<MyCompany.Data.Objects.ImpresstFundTrans>();
        }
        
        public List<MyCompany.Data.Objects.ImpresstFundTrans> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.ImpresstFundTrans> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.ImpresstFundTrans SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.ImpresstFundTrans> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.ImpresstFundTrans theImpresstFundTrans, MyCompany.Data.Objects.ImpresstFundTrans original_ImpresstFundTrans)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("ImpFundTranID", original_ImpresstFundTrans.ImpFundTranID, theImpresstFundTrans.ImpFundTranID, true));
            values.Add(new FieldValue("ImpresstFundID", original_ImpresstFundTrans.ImpresstFundID, theImpresstFundTrans.ImpresstFundID));
            values.Add(new FieldValue("ImpresstFundReference", original_ImpresstFundTrans.ImpresstFundReference, theImpresstFundTrans.ImpresstFundReference, true));
            values.Add(new FieldValue("ImpresstFundAccSubAccSubName", original_ImpresstFundTrans.ImpresstFundAccSubAccSubName, theImpresstFundTrans.ImpresstFundAccSubAccSubName, true));
            values.Add(new FieldValue("ImpresstFundAccSubAccSubTypeAccSubType", original_ImpresstFundTrans.ImpresstFundAccSubAccSubTypeAccSubType, theImpresstFundTrans.ImpresstFundAccSubAccSubTypeAccSubType, true));
            values.Add(new FieldValue("ImpresstFundAccSubTypeAccSubType", original_ImpresstFundTrans.ImpresstFundAccSubTypeAccSubType, theImpresstFundTrans.ImpresstFundAccSubTypeAccSubType, true));
            values.Add(new FieldValue("ImpresstFundCoaDetailAccName", original_ImpresstFundTrans.ImpresstFundCoaDetailAccName, theImpresstFundTrans.ImpresstFundCoaDetailAccName, true));
            values.Add(new FieldValue("ImpresstFundCoaDetailAccBalTypeAccBalType", original_ImpresstFundTrans.ImpresstFundCoaDetailAccBalTypeAccBalType, theImpresstFundTrans.ImpresstFundCoaDetailAccBalTypeAccBalType, true));
            values.Add(new FieldValue("ImpresstFundCoaDetailAccCurrencyAccCurrencyName", original_ImpresstFundTrans.ImpresstFundCoaDetailAccCurrencyAccCurrencyName, theImpresstFundTrans.ImpresstFundCoaDetailAccCurrencyAccCurrencyName, true));
            values.Add(new FieldValue("ImpresstFundCoaDetailAccDestAccDest", original_ImpresstFundTrans.ImpresstFundCoaDetailAccDestAccDest, theImpresstFundTrans.ImpresstFundCoaDetailAccDestAccDest, true));
            values.Add(new FieldValue("ImpresstFundCoaDetailAccFundAccFundName", original_ImpresstFundTrans.ImpresstFundCoaDetailAccFundAccFundName, theImpresstFundTrans.ImpresstFundCoaDetailAccFundAccFundName, true));
            values.Add(new FieldValue("ImpresstFundCoaDetailAccSubTypeAccSubType", original_ImpresstFundTrans.ImpresstFundCoaDetailAccSubTypeAccSubType, theImpresstFundTrans.ImpresstFundCoaDetailAccSubTypeAccSubType, true));
            values.Add(new FieldValue("ImpresstFundCoaDetailAccTypeAccType", original_ImpresstFundTrans.ImpresstFundCoaDetailAccTypeAccType, theImpresstFundTrans.ImpresstFundCoaDetailAccTypeAccType, true));
            values.Add(new FieldValue("ImpresstFundCoaDetailCoaControlAccName", original_ImpresstFundTrans.ImpresstFundCoaDetailCoaControlAccName, theImpresstFundTrans.ImpresstFundCoaDetailCoaControlAccName, true));
            values.Add(new FieldValue("ImpresstFundCoaDetailCoaMainAccName", original_ImpresstFundTrans.ImpresstFundCoaDetailCoaMainAccName, theImpresstFundTrans.ImpresstFundCoaDetailCoaMainAccName, true));
            values.Add(new FieldValue("ImpresstFundCoaDetailCoaSubAccName", original_ImpresstFundTrans.ImpresstFundCoaDetailCoaSubAccName, theImpresstFundTrans.ImpresstFundCoaDetailCoaSubAccName, true));
            values.Add(new FieldValue("AccFundID", original_ImpresstFundTrans.AccFundID, theImpresstFundTrans.AccFundID));
            values.Add(new FieldValue("AccFundAccFundName", original_ImpresstFundTrans.AccFundAccFundName, theImpresstFundTrans.AccFundAccFundName, true));
            values.Add(new FieldValue("TranDate", original_ImpresstFundTrans.TranDate, theImpresstFundTrans.TranDate));
            values.Add(new FieldValue("SlipNo", original_ImpresstFundTrans.SlipNo, theImpresstFundTrans.SlipNo));
            values.Add(new FieldValue("CoaDetailID", original_ImpresstFundTrans.CoaDetailID, theImpresstFundTrans.CoaDetailID));
            values.Add(new FieldValue("CoaDetailAccName", original_ImpresstFundTrans.CoaDetailAccName, theImpresstFundTrans.CoaDetailAccName, true));
            values.Add(new FieldValue("CoaDetailAccBalTypeAccBalType", original_ImpresstFundTrans.CoaDetailAccBalTypeAccBalType, theImpresstFundTrans.CoaDetailAccBalTypeAccBalType, true));
            values.Add(new FieldValue("CoaDetailAccCurrencyAccCurrencyName", original_ImpresstFundTrans.CoaDetailAccCurrencyAccCurrencyName, theImpresstFundTrans.CoaDetailAccCurrencyAccCurrencyName, true));
            values.Add(new FieldValue("CoaDetailAccDestAccDest", original_ImpresstFundTrans.CoaDetailAccDestAccDest, theImpresstFundTrans.CoaDetailAccDestAccDest, true));
            values.Add(new FieldValue("CoaDetailAccDestCompanyTypeDescription", original_ImpresstFundTrans.CoaDetailAccDestCompanyTypeDescription, theImpresstFundTrans.CoaDetailAccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("CoaDetailAccFundAccFundName", original_ImpresstFundTrans.CoaDetailAccFundAccFundName, theImpresstFundTrans.CoaDetailAccFundAccFundName, true));
            values.Add(new FieldValue("CoaDetailAccSubTypeAccSubType", original_ImpresstFundTrans.CoaDetailAccSubTypeAccSubType, theImpresstFundTrans.CoaDetailAccSubTypeAccSubType, true));
            values.Add(new FieldValue("CoaDetailAccTypeAccType", original_ImpresstFundTrans.CoaDetailAccTypeAccType, theImpresstFundTrans.CoaDetailAccTypeAccType, true));
            values.Add(new FieldValue("CoaDetailCoaControlAccName", original_ImpresstFundTrans.CoaDetailCoaControlAccName, theImpresstFundTrans.CoaDetailCoaControlAccName, true));
            values.Add(new FieldValue("CoaDetailCoaControlAccBalTypeAccBalType", original_ImpresstFundTrans.CoaDetailCoaControlAccBalTypeAccBalType, theImpresstFundTrans.CoaDetailCoaControlAccBalTypeAccBalType, true));
            values.Add(new FieldValue("CoaDetailCoaControlAccDestAccDest", original_ImpresstFundTrans.CoaDetailCoaControlAccDestAccDest, theImpresstFundTrans.CoaDetailCoaControlAccDestAccDest, true));
            values.Add(new FieldValue("CoaDetailCoaControlAccTypeAccType", original_ImpresstFundTrans.CoaDetailCoaControlAccTypeAccType, theImpresstFundTrans.CoaDetailCoaControlAccTypeAccType, true));
            values.Add(new FieldValue("CoaDetailCoaControlCompTypeDescription", original_ImpresstFundTrans.CoaDetailCoaControlCompTypeDescription, theImpresstFundTrans.CoaDetailCoaControlCompTypeDescription, true));
            values.Add(new FieldValue("CoaDetailCoaMainAccName", original_ImpresstFundTrans.CoaDetailCoaMainAccName, theImpresstFundTrans.CoaDetailCoaMainAccName, true));
            values.Add(new FieldValue("CoaDetailCoaMainAccBalTypeAccBalType", original_ImpresstFundTrans.CoaDetailCoaMainAccBalTypeAccBalType, theImpresstFundTrans.CoaDetailCoaMainAccBalTypeAccBalType, true));
            values.Add(new FieldValue("CoaDetailCoaMainAccDestAccDest", original_ImpresstFundTrans.CoaDetailCoaMainAccDestAccDest, theImpresstFundTrans.CoaDetailCoaMainAccDestAccDest, true));
            values.Add(new FieldValue("CoaDetailCoaMainAccFundAccFundName", original_ImpresstFundTrans.CoaDetailCoaMainAccFundAccFundName, theImpresstFundTrans.CoaDetailCoaMainAccFundAccFundName, true));
            values.Add(new FieldValue("CoaDetailCoaMainAccTypeAccType", original_ImpresstFundTrans.CoaDetailCoaMainAccTypeAccType, theImpresstFundTrans.CoaDetailCoaMainAccTypeAccType, true));
            values.Add(new FieldValue("CoaDetailCoaMainCoaControlAccName", original_ImpresstFundTrans.CoaDetailCoaMainCoaControlAccName, theImpresstFundTrans.CoaDetailCoaMainCoaControlAccName, true));
            values.Add(new FieldValue("CoaDetailCoaSubAccName", original_ImpresstFundTrans.CoaDetailCoaSubAccName, theImpresstFundTrans.CoaDetailCoaSubAccName, true));
            values.Add(new FieldValue("CoaDetailCoaSubAccBalTypeAccBalType", original_ImpresstFundTrans.CoaDetailCoaSubAccBalTypeAccBalType, theImpresstFundTrans.CoaDetailCoaSubAccBalTypeAccBalType, true));
            values.Add(new FieldValue("CoaDetailCoaSubAccDestAccDest", original_ImpresstFundTrans.CoaDetailCoaSubAccDestAccDest, theImpresstFundTrans.CoaDetailCoaSubAccDestAccDest, true));
            values.Add(new FieldValue("CoaDetailCoaSubAccFundAccFundName", original_ImpresstFundTrans.CoaDetailCoaSubAccFundAccFundName, theImpresstFundTrans.CoaDetailCoaSubAccFundAccFundName, true));
            values.Add(new FieldValue("CoaDetailCoaSubAccTypeAccType", original_ImpresstFundTrans.CoaDetailCoaSubAccTypeAccType, theImpresstFundTrans.CoaDetailCoaSubAccTypeAccType, true));
            values.Add(new FieldValue("CoaDetailCoaSubCoaControlAccName", original_ImpresstFundTrans.CoaDetailCoaSubCoaControlAccName, theImpresstFundTrans.CoaDetailCoaSubCoaControlAccName, true));
            values.Add(new FieldValue("CoaDetailCoaSubCoaMainAccName", original_ImpresstFundTrans.CoaDetailCoaSubCoaMainAccName, theImpresstFundTrans.CoaDetailCoaSubCoaMainAccName, true));
            values.Add(new FieldValue("Amount", original_ImpresstFundTrans.Amount, theImpresstFundTrans.Amount));
            values.Add(new FieldValue("IsCashCheque", original_ImpresstFundTrans.IsCashCheque, theImpresstFundTrans.IsCashCheque));
            values.Add(new FieldValue("IsPayReceived", original_ImpresstFundTrans.IsPayReceived, theImpresstFundTrans.IsPayReceived));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.ImpresstFundTrans theImpresstFundTrans, MyCompany.Data.Objects.ImpresstFundTrans original_ImpresstFundTrans, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "ImpresstFundTrans";
            args.View = dataView;
            args.Values = CreateFieldValues(theImpresstFundTrans, original_ImpresstFundTrans);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("ImpresstFundTrans", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theImpresstFundTrans);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.ImpresstFundTrans theImpresstFundTrans, MyCompany.Data.Objects.ImpresstFundTrans original_ImpresstFundTrans)
        {
            return ExecuteAction(theImpresstFundTrans, original_ImpresstFundTrans, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.ImpresstFundTrans theImpresstFundTrans)
        {
            return Update(theImpresstFundTrans, SelectSingle(theImpresstFundTrans.ImpFundTranID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.ImpresstFundTrans theImpresstFundTrans)
        {
            return ExecuteAction(theImpresstFundTrans, new ImpresstFundTrans(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.ImpresstFundTrans theImpresstFundTrans)
        {
            return ExecuteAction(theImpresstFundTrans, theImpresstFundTrans, "Select", "Delete", DeleteView);
        }
    }
}
