using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class ImpresstFund
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _impresstFundID;
        
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
        private DateTime? _openDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _openAmount;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _reference;
        
        public ImpresstFund()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
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
        public decimal? OpenAmount
        {
            get
            {
                return _openAmount;
            }
            set
            {
                _openAmount = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Reference
        {
            get
            {
                return _reference;
            }
            set
            {
                _reference = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.ImpresstFund> Select(
                    int? impresstFundID, 
                    int? accSubTypeID, 
                    string accSubTypeAccSubType, 
                    int? accSubCode, 
                    string accSubAccSubName, 
                    string accSubAccSubTypeAccSubType, 
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
                    DateTime? openDate, 
                    decimal? openAmount, 
                    string reference)
        {
            return new ImpresstFundFactory().Select(impresstFundID, accSubTypeID, accSubTypeAccSubType, accSubCode, accSubAccSubName, accSubAccSubTypeAccSubType, coaDetailID, coaDetailAccName, coaDetailAccBalTypeAccBalType, coaDetailAccCurrencyAccCurrencyName, coaDetailAccDestAccDest, coaDetailAccDestCompanyTypeDescription, coaDetailAccFundAccFundName, coaDetailAccSubTypeAccSubType, coaDetailAccTypeAccType, coaDetailCoaControlAccName, coaDetailCoaControlAccBalTypeAccBalType, coaDetailCoaControlAccDestAccDest, coaDetailCoaControlAccTypeAccType, coaDetailCoaControlCompTypeDescription, coaDetailCoaMainAccName, coaDetailCoaMainAccBalTypeAccBalType, coaDetailCoaMainAccDestAccDest, coaDetailCoaMainAccFundAccFundName, coaDetailCoaMainAccTypeAccType, coaDetailCoaMainCoaControlAccName, coaDetailCoaSubAccName, coaDetailCoaSubAccBalTypeAccBalType, coaDetailCoaSubAccDestAccDest, coaDetailCoaSubAccFundAccFundName, coaDetailCoaSubAccTypeAccType, coaDetailCoaSubCoaControlAccName, coaDetailCoaSubCoaMainAccName, openDate, openAmount, reference);
        }
        
        public static List<MyCompany.Data.Objects.ImpresstFund> Select(MyCompany.Data.Objects.ImpresstFund qbe)
        {
            return new ImpresstFundFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.ImpresstFund> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new ImpresstFundFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.ImpresstFund> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new ImpresstFundFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.ImpresstFund> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new ImpresstFundFactory().Select(filter, sort, ImpresstFundFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.ImpresstFund> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new ImpresstFundFactory().Select(filter, sort, ImpresstFundFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.ImpresstFund> Select(string filter, BusinessObjectParameters parameters)
        {
            return new ImpresstFundFactory().Select(filter, null, ImpresstFundFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.ImpresstFund> Select(string filter, params FieldValue[] parameters)
        {
            return new ImpresstFundFactory().Select(filter, null, ImpresstFundFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.ImpresstFund SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new ImpresstFundFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.ImpresstFund SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new ImpresstFundFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.ImpresstFund SelectSingle(int? impresstFundID)
        {
            return new ImpresstFundFactory().SelectSingle(impresstFundID);
        }
        
        public int Insert()
        {
            return new ImpresstFundFactory().Insert(this);
        }
        
        public int Update()
        {
            return new ImpresstFundFactory().Update(this);
        }
        
        public int Delete()
        {
            return new ImpresstFundFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("ImpresstFundID: {0}", this.ImpresstFundID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class ImpresstFundFactory
    {
        
        public ImpresstFundFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("ImpresstFund");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("ImpresstFund");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("ImpresstFund");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("ImpresstFund");
            }
        }
        
        public static ImpresstFundFactory Create()
        {
            return new ImpresstFundFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    int? impresstFundID, 
                    int? accSubTypeID, 
                    string accSubTypeAccSubType, 
                    int? accSubCode, 
                    string accSubAccSubName, 
                    string accSubAccSubTypeAccSubType, 
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
                    DateTime? openDate, 
                    decimal? openAmount, 
                    string reference, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (impresstFundID.HasValue)
            	filter.Add(("ImpresstFundID:=" + impresstFundID.Value.ToString()));
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
            if (openDate.HasValue)
            	filter.Add(("OpenDate:=" + openDate.Value.ToString()));
            if (openAmount.HasValue)
            	filter.Add(("OpenAmount:=" + openAmount.Value.ToString()));
            if (!(String.IsNullOrEmpty(reference)))
            	filter.Add(("Reference:*" + reference));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.ImpresstFund> Select(
                    int? impresstFundID, 
                    int? accSubTypeID, 
                    string accSubTypeAccSubType, 
                    int? accSubCode, 
                    string accSubAccSubName, 
                    string accSubAccSubTypeAccSubType, 
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
                    DateTime? openDate, 
                    decimal? openAmount, 
                    string reference, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(impresstFundID, accSubTypeID, accSubTypeAccSubType, accSubCode, accSubAccSubName, accSubAccSubTypeAccSubType, coaDetailID, coaDetailAccName, coaDetailAccBalTypeAccBalType, coaDetailAccCurrencyAccCurrencyName, coaDetailAccDestAccDest, coaDetailAccDestCompanyTypeDescription, coaDetailAccFundAccFundName, coaDetailAccSubTypeAccSubType, coaDetailAccTypeAccType, coaDetailCoaControlAccName, coaDetailCoaControlAccBalTypeAccBalType, coaDetailCoaControlAccDestAccDest, coaDetailCoaControlAccTypeAccType, coaDetailCoaControlCompTypeDescription, coaDetailCoaMainAccName, coaDetailCoaMainAccBalTypeAccBalType, coaDetailCoaMainAccDestAccDest, coaDetailCoaMainAccFundAccFundName, coaDetailCoaMainAccTypeAccType, coaDetailCoaMainCoaControlAccName, coaDetailCoaSubAccName, coaDetailCoaSubAccBalTypeAccBalType, coaDetailCoaSubAccDestAccDest, coaDetailCoaSubAccFundAccFundName, coaDetailCoaSubAccTypeAccType, coaDetailCoaSubCoaControlAccName, coaDetailCoaSubCoaMainAccName, openDate, openAmount, reference, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("ImpresstFund", dataView, request);
            return page.ToList<MyCompany.Data.Objects.ImpresstFund>();
        }
        
        public List<MyCompany.Data.Objects.ImpresstFund> Select(MyCompany.Data.Objects.ImpresstFund qbe)
        {
            return Select(qbe.ImpresstFundID, qbe.AccSubTypeID, qbe.AccSubTypeAccSubType, qbe.AccSubCode, qbe.AccSubAccSubName, qbe.AccSubAccSubTypeAccSubType, qbe.CoaDetailID, qbe.CoaDetailAccName, qbe.CoaDetailAccBalTypeAccBalType, qbe.CoaDetailAccCurrencyAccCurrencyName, qbe.CoaDetailAccDestAccDest, qbe.CoaDetailAccDestCompanyTypeDescription, qbe.CoaDetailAccFundAccFundName, qbe.CoaDetailAccSubTypeAccSubType, qbe.CoaDetailAccTypeAccType, qbe.CoaDetailCoaControlAccName, qbe.CoaDetailCoaControlAccBalTypeAccBalType, qbe.CoaDetailCoaControlAccDestAccDest, qbe.CoaDetailCoaControlAccTypeAccType, qbe.CoaDetailCoaControlCompTypeDescription, qbe.CoaDetailCoaMainAccName, qbe.CoaDetailCoaMainAccBalTypeAccBalType, qbe.CoaDetailCoaMainAccDestAccDest, qbe.CoaDetailCoaMainAccFundAccFundName, qbe.CoaDetailCoaMainAccTypeAccType, qbe.CoaDetailCoaMainCoaControlAccName, qbe.CoaDetailCoaSubAccName, qbe.CoaDetailCoaSubAccBalTypeAccBalType, qbe.CoaDetailCoaSubAccDestAccDest, qbe.CoaDetailCoaSubAccFundAccFundName, qbe.CoaDetailCoaSubAccTypeAccType, qbe.CoaDetailCoaSubCoaControlAccName, qbe.CoaDetailCoaSubCoaMainAccName, qbe.OpenDate, qbe.OpenAmount, qbe.Reference);
        }
        
        public int SelectCount(
                    int? impresstFundID, 
                    int? accSubTypeID, 
                    string accSubTypeAccSubType, 
                    int? accSubCode, 
                    string accSubAccSubName, 
                    string accSubAccSubTypeAccSubType, 
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
                    DateTime? openDate, 
                    decimal? openAmount, 
                    string reference, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(impresstFundID, accSubTypeID, accSubTypeAccSubType, accSubCode, accSubAccSubName, accSubAccSubTypeAccSubType, coaDetailID, coaDetailAccName, coaDetailAccBalTypeAccBalType, coaDetailAccCurrencyAccCurrencyName, coaDetailAccDestAccDest, coaDetailAccDestCompanyTypeDescription, coaDetailAccFundAccFundName, coaDetailAccSubTypeAccSubType, coaDetailAccTypeAccType, coaDetailCoaControlAccName, coaDetailCoaControlAccBalTypeAccBalType, coaDetailCoaControlAccDestAccDest, coaDetailCoaControlAccTypeAccType, coaDetailCoaControlCompTypeDescription, coaDetailCoaMainAccName, coaDetailCoaMainAccBalTypeAccBalType, coaDetailCoaMainAccDestAccDest, coaDetailCoaMainAccFundAccFundName, coaDetailCoaMainAccTypeAccType, coaDetailCoaMainCoaControlAccName, coaDetailCoaSubAccName, coaDetailCoaSubAccBalTypeAccBalType, coaDetailCoaSubAccDestAccDest, coaDetailCoaSubAccFundAccFundName, coaDetailCoaSubAccTypeAccType, coaDetailCoaSubCoaControlAccName, coaDetailCoaSubCoaMainAccName, openDate, openAmount, reference, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("ImpresstFund", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.ImpresstFund> Select(
                    int? impresstFundID, 
                    int? accSubTypeID, 
                    string accSubTypeAccSubType, 
                    int? accSubCode, 
                    string accSubAccSubName, 
                    string accSubAccSubTypeAccSubType, 
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
                    DateTime? openDate, 
                    decimal? openAmount, 
                    string reference)
        {
            return Select(impresstFundID, accSubTypeID, accSubTypeAccSubType, accSubCode, accSubAccSubName, accSubAccSubTypeAccSubType, coaDetailID, coaDetailAccName, coaDetailAccBalTypeAccBalType, coaDetailAccCurrencyAccCurrencyName, coaDetailAccDestAccDest, coaDetailAccDestCompanyTypeDescription, coaDetailAccFundAccFundName, coaDetailAccSubTypeAccSubType, coaDetailAccTypeAccType, coaDetailCoaControlAccName, coaDetailCoaControlAccBalTypeAccBalType, coaDetailCoaControlAccDestAccDest, coaDetailCoaControlAccTypeAccType, coaDetailCoaControlCompTypeDescription, coaDetailCoaMainAccName, coaDetailCoaMainAccBalTypeAccBalType, coaDetailCoaMainAccDestAccDest, coaDetailCoaMainAccFundAccFundName, coaDetailCoaMainAccTypeAccType, coaDetailCoaMainCoaControlAccName, coaDetailCoaSubAccName, coaDetailCoaSubAccBalTypeAccBalType, coaDetailCoaSubAccDestAccDest, coaDetailCoaSubAccFundAccFundName, coaDetailCoaSubAccTypeAccType, coaDetailCoaSubCoaControlAccName, coaDetailCoaSubCoaMainAccName, openDate, openAmount, reference, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.ImpresstFund SelectSingle(int? impresstFundID)
        {
            List<MyCompany.Data.Objects.ImpresstFund> list = Select(impresstFundID, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.ImpresstFund> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("ImpresstFund", dataView, request);
            return page.ToList<MyCompany.Data.Objects.ImpresstFund>();
        }
        
        public List<MyCompany.Data.Objects.ImpresstFund> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.ImpresstFund> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.ImpresstFund SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.ImpresstFund> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.ImpresstFund theImpresstFund, MyCompany.Data.Objects.ImpresstFund original_ImpresstFund)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("ImpresstFundID", original_ImpresstFund.ImpresstFundID, theImpresstFund.ImpresstFundID, true));
            values.Add(new FieldValue("AccSubTypeID", original_ImpresstFund.AccSubTypeID, theImpresstFund.AccSubTypeID));
            values.Add(new FieldValue("AccSubTypeAccSubType", original_ImpresstFund.AccSubTypeAccSubType, theImpresstFund.AccSubTypeAccSubType, true));
            values.Add(new FieldValue("AccSubCode", original_ImpresstFund.AccSubCode, theImpresstFund.AccSubCode));
            values.Add(new FieldValue("AccSubAccSubName", original_ImpresstFund.AccSubAccSubName, theImpresstFund.AccSubAccSubName, true));
            values.Add(new FieldValue("AccSubAccSubTypeAccSubType", original_ImpresstFund.AccSubAccSubTypeAccSubType, theImpresstFund.AccSubAccSubTypeAccSubType, true));
            values.Add(new FieldValue("CoaDetailID", original_ImpresstFund.CoaDetailID, theImpresstFund.CoaDetailID));
            values.Add(new FieldValue("CoaDetailAccName", original_ImpresstFund.CoaDetailAccName, theImpresstFund.CoaDetailAccName, true));
            values.Add(new FieldValue("CoaDetailAccBalTypeAccBalType", original_ImpresstFund.CoaDetailAccBalTypeAccBalType, theImpresstFund.CoaDetailAccBalTypeAccBalType, true));
            values.Add(new FieldValue("CoaDetailAccCurrencyAccCurrencyName", original_ImpresstFund.CoaDetailAccCurrencyAccCurrencyName, theImpresstFund.CoaDetailAccCurrencyAccCurrencyName, true));
            values.Add(new FieldValue("CoaDetailAccDestAccDest", original_ImpresstFund.CoaDetailAccDestAccDest, theImpresstFund.CoaDetailAccDestAccDest, true));
            values.Add(new FieldValue("CoaDetailAccDestCompanyTypeDescription", original_ImpresstFund.CoaDetailAccDestCompanyTypeDescription, theImpresstFund.CoaDetailAccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("CoaDetailAccFundAccFundName", original_ImpresstFund.CoaDetailAccFundAccFundName, theImpresstFund.CoaDetailAccFundAccFundName, true));
            values.Add(new FieldValue("CoaDetailAccSubTypeAccSubType", original_ImpresstFund.CoaDetailAccSubTypeAccSubType, theImpresstFund.CoaDetailAccSubTypeAccSubType, true));
            values.Add(new FieldValue("CoaDetailAccTypeAccType", original_ImpresstFund.CoaDetailAccTypeAccType, theImpresstFund.CoaDetailAccTypeAccType, true));
            values.Add(new FieldValue("CoaDetailCoaControlAccName", original_ImpresstFund.CoaDetailCoaControlAccName, theImpresstFund.CoaDetailCoaControlAccName, true));
            values.Add(new FieldValue("CoaDetailCoaControlAccBalTypeAccBalType", original_ImpresstFund.CoaDetailCoaControlAccBalTypeAccBalType, theImpresstFund.CoaDetailCoaControlAccBalTypeAccBalType, true));
            values.Add(new FieldValue("CoaDetailCoaControlAccDestAccDest", original_ImpresstFund.CoaDetailCoaControlAccDestAccDest, theImpresstFund.CoaDetailCoaControlAccDestAccDest, true));
            values.Add(new FieldValue("CoaDetailCoaControlAccTypeAccType", original_ImpresstFund.CoaDetailCoaControlAccTypeAccType, theImpresstFund.CoaDetailCoaControlAccTypeAccType, true));
            values.Add(new FieldValue("CoaDetailCoaControlCompTypeDescription", original_ImpresstFund.CoaDetailCoaControlCompTypeDescription, theImpresstFund.CoaDetailCoaControlCompTypeDescription, true));
            values.Add(new FieldValue("CoaDetailCoaMainAccName", original_ImpresstFund.CoaDetailCoaMainAccName, theImpresstFund.CoaDetailCoaMainAccName, true));
            values.Add(new FieldValue("CoaDetailCoaMainAccBalTypeAccBalType", original_ImpresstFund.CoaDetailCoaMainAccBalTypeAccBalType, theImpresstFund.CoaDetailCoaMainAccBalTypeAccBalType, true));
            values.Add(new FieldValue("CoaDetailCoaMainAccDestAccDest", original_ImpresstFund.CoaDetailCoaMainAccDestAccDest, theImpresstFund.CoaDetailCoaMainAccDestAccDest, true));
            values.Add(new FieldValue("CoaDetailCoaMainAccFundAccFundName", original_ImpresstFund.CoaDetailCoaMainAccFundAccFundName, theImpresstFund.CoaDetailCoaMainAccFundAccFundName, true));
            values.Add(new FieldValue("CoaDetailCoaMainAccTypeAccType", original_ImpresstFund.CoaDetailCoaMainAccTypeAccType, theImpresstFund.CoaDetailCoaMainAccTypeAccType, true));
            values.Add(new FieldValue("CoaDetailCoaMainCoaControlAccName", original_ImpresstFund.CoaDetailCoaMainCoaControlAccName, theImpresstFund.CoaDetailCoaMainCoaControlAccName, true));
            values.Add(new FieldValue("CoaDetailCoaSubAccName", original_ImpresstFund.CoaDetailCoaSubAccName, theImpresstFund.CoaDetailCoaSubAccName, true));
            values.Add(new FieldValue("CoaDetailCoaSubAccBalTypeAccBalType", original_ImpresstFund.CoaDetailCoaSubAccBalTypeAccBalType, theImpresstFund.CoaDetailCoaSubAccBalTypeAccBalType, true));
            values.Add(new FieldValue("CoaDetailCoaSubAccDestAccDest", original_ImpresstFund.CoaDetailCoaSubAccDestAccDest, theImpresstFund.CoaDetailCoaSubAccDestAccDest, true));
            values.Add(new FieldValue("CoaDetailCoaSubAccFundAccFundName", original_ImpresstFund.CoaDetailCoaSubAccFundAccFundName, theImpresstFund.CoaDetailCoaSubAccFundAccFundName, true));
            values.Add(new FieldValue("CoaDetailCoaSubAccTypeAccType", original_ImpresstFund.CoaDetailCoaSubAccTypeAccType, theImpresstFund.CoaDetailCoaSubAccTypeAccType, true));
            values.Add(new FieldValue("CoaDetailCoaSubCoaControlAccName", original_ImpresstFund.CoaDetailCoaSubCoaControlAccName, theImpresstFund.CoaDetailCoaSubCoaControlAccName, true));
            values.Add(new FieldValue("CoaDetailCoaSubCoaMainAccName", original_ImpresstFund.CoaDetailCoaSubCoaMainAccName, theImpresstFund.CoaDetailCoaSubCoaMainAccName, true));
            values.Add(new FieldValue("OpenDate", original_ImpresstFund.OpenDate, theImpresstFund.OpenDate));
            values.Add(new FieldValue("OpenAmount", original_ImpresstFund.OpenAmount, theImpresstFund.OpenAmount));
            values.Add(new FieldValue("Reference", original_ImpresstFund.Reference, theImpresstFund.Reference));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.ImpresstFund theImpresstFund, MyCompany.Data.Objects.ImpresstFund original_ImpresstFund, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "ImpresstFund";
            args.View = dataView;
            args.Values = CreateFieldValues(theImpresstFund, original_ImpresstFund);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("ImpresstFund", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theImpresstFund);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.ImpresstFund theImpresstFund, MyCompany.Data.Objects.ImpresstFund original_ImpresstFund)
        {
            return ExecuteAction(theImpresstFund, original_ImpresstFund, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.ImpresstFund theImpresstFund)
        {
            return Update(theImpresstFund, SelectSingle(theImpresstFund.ImpresstFundID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.ImpresstFund theImpresstFund)
        {
            return ExecuteAction(theImpresstFund, new ImpresstFund(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.ImpresstFund theImpresstFund)
        {
            return ExecuteAction(theImpresstFund, theImpresstFund, "Select", "Delete", DeleteView);
        }
    }
}
