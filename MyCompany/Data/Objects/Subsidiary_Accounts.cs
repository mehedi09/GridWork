using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class Subsidiary_Accounts
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _subsAccountsID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accFundID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accFundAccFundName;
        
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
        private DateTime? _openDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _openDebit;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _openCredit;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accCurrency;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accCurrencyAccCurrencyName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _accCurrencyRate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _lastUpdateBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _lastUpdate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private byte? _dlt;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accBranchCode;
        
        public Subsidiary_Accounts()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? SubsAccountsID
        {
            get
            {
                return _subsAccountsID;
            }
            set
            {
                _subsAccountsID = value;
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
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
        public string LastUpdateBy
        {
            get
            {
                return _lastUpdateBy;
            }
            set
            {
                _lastUpdateBy = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? LastUpdate
        {
            get
            {
                return _lastUpdate;
            }
            set
            {
                _lastUpdate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public byte? Dlt
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
        
        public static List<MyCompany.Data.Objects.Subsidiary_Accounts> Select(
                    int? subsAccountsID, 
                    int? accFundID, 
                    string accFundAccFundName, 
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
                    int? accSubTypeID, 
                    string accSubTypeAccSubType, 
                    int? accSubCode, 
                    string accSubAccSubName, 
                    string accSubAccSubTypeAccSubType, 
                    DateTime? openDate, 
                    decimal? openDebit, 
                    decimal? openCredit, 
                    int? accCurrency, 
                    string accCurrencyAccCurrencyName, 
                    decimal? accCurrencyRate, 
                    string lastUpdateBy, 
                    DateTime? lastUpdate, 
                    byte? dlt, 
                    int? accBranchCode)
        {
            return new Subsidiary_AccountsFactory().Select(subsAccountsID, accFundID, accFundAccFundName, coaDetailID, coaDetailAccName, coaDetailAccBalTypeAccBalType, coaDetailAccCurrencyAccCurrencyName, coaDetailAccDestAccDest, coaDetailAccDestCompanyTypeDescription, coaDetailAccFundAccFundName, coaDetailAccSubTypeAccSubType, coaDetailAccTypeAccType, coaDetailCoaControlAccName, coaDetailCoaControlAccBalTypeAccBalType, coaDetailCoaControlAccDestAccDest, coaDetailCoaControlAccTypeAccType, coaDetailCoaControlCompTypeDescription, coaDetailCoaMainAccName, coaDetailCoaMainAccBalTypeAccBalType, coaDetailCoaMainAccDestAccDest, coaDetailCoaMainAccFundAccFundName, coaDetailCoaMainAccTypeAccType, coaDetailCoaMainCoaControlAccName, coaDetailCoaSubAccName, coaDetailCoaSubAccBalTypeAccBalType, coaDetailCoaSubAccDestAccDest, coaDetailCoaSubAccFundAccFundName, coaDetailCoaSubAccTypeAccType, coaDetailCoaSubCoaControlAccName, coaDetailCoaSubCoaMainAccName, accSubTypeID, accSubTypeAccSubType, accSubCode, accSubAccSubName, accSubAccSubTypeAccSubType, openDate, openDebit, openCredit, accCurrency, accCurrencyAccCurrencyName, accCurrencyRate, lastUpdateBy, lastUpdate, dlt, accBranchCode);
        }
        
        public static List<MyCompany.Data.Objects.Subsidiary_Accounts> Select(MyCompany.Data.Objects.Subsidiary_Accounts qbe)
        {
            return new Subsidiary_AccountsFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.Subsidiary_Accounts> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new Subsidiary_AccountsFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.Subsidiary_Accounts> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new Subsidiary_AccountsFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.Subsidiary_Accounts> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new Subsidiary_AccountsFactory().Select(filter, sort, Subsidiary_AccountsFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.Subsidiary_Accounts> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new Subsidiary_AccountsFactory().Select(filter, sort, Subsidiary_AccountsFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.Subsidiary_Accounts> Select(string filter, BusinessObjectParameters parameters)
        {
            return new Subsidiary_AccountsFactory().Select(filter, null, Subsidiary_AccountsFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.Subsidiary_Accounts> Select(string filter, params FieldValue[] parameters)
        {
            return new Subsidiary_AccountsFactory().Select(filter, null, Subsidiary_AccountsFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.Subsidiary_Accounts SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new Subsidiary_AccountsFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.Subsidiary_Accounts SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new Subsidiary_AccountsFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.Subsidiary_Accounts SelectSingle(int? subsAccountsID)
        {
            return new Subsidiary_AccountsFactory().SelectSingle(subsAccountsID);
        }
        
        public int Insert()
        {
            return new Subsidiary_AccountsFactory().Insert(this);
        }
        
        public int Update()
        {
            return new Subsidiary_AccountsFactory().Update(this);
        }
        
        public int Delete()
        {
            return new Subsidiary_AccountsFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("SubsAccountsID: {0}", this.SubsAccountsID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class Subsidiary_AccountsFactory
    {
        
        public Subsidiary_AccountsFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Subsidiary_Accounts");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Subsidiary_Accounts");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Subsidiary_Accounts");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Subsidiary_Accounts");
            }
        }
        
        public static Subsidiary_AccountsFactory Create()
        {
            return new Subsidiary_AccountsFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    int? subsAccountsID, 
                    int? accFundID, 
                    string accFundAccFundName, 
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
                    int? accSubTypeID, 
                    string accSubTypeAccSubType, 
                    int? accSubCode, 
                    string accSubAccSubName, 
                    string accSubAccSubTypeAccSubType, 
                    DateTime? openDate, 
                    decimal? openDebit, 
                    decimal? openCredit, 
                    int? accCurrency, 
                    string accCurrencyAccCurrencyName, 
                    decimal? accCurrencyRate, 
                    string lastUpdateBy, 
                    DateTime? lastUpdate, 
                    byte? dlt, 
                    int? accBranchCode, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (subsAccountsID.HasValue)
            	filter.Add(("SubsAccountsID:=" + subsAccountsID.Value.ToString()));
            if (accFundID.HasValue)
            	filter.Add(("AccFundID:=" + accFundID.Value.ToString()));
            if (!(String.IsNullOrEmpty(accFundAccFundName)))
            	filter.Add(("AccFundAccFundName:*" + accFundAccFundName));
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
            if (openDate.HasValue)
            	filter.Add(("OpenDate:=" + openDate.Value.ToString()));
            if (openDebit.HasValue)
            	filter.Add(("OpenDebit:=" + openDebit.Value.ToString()));
            if (openCredit.HasValue)
            	filter.Add(("OpenCredit:=" + openCredit.Value.ToString()));
            if (accCurrency.HasValue)
            	filter.Add(("AccCurrency:=" + accCurrency.Value.ToString()));
            if (!(String.IsNullOrEmpty(accCurrencyAccCurrencyName)))
            	filter.Add(("AccCurrencyAccCurrencyName:*" + accCurrencyAccCurrencyName));
            if (accCurrencyRate.HasValue)
            	filter.Add(("AccCurrencyRate:=" + accCurrencyRate.Value.ToString()));
            if (!(String.IsNullOrEmpty(lastUpdateBy)))
            	filter.Add(("LastUpdateBy:*" + lastUpdateBy));
            if (lastUpdate.HasValue)
            	filter.Add(("LastUpdate:=" + lastUpdate.Value.ToString()));
            if (dlt.HasValue)
            	filter.Add(("Dlt:=" + dlt.Value.ToString()));
            if (accBranchCode.HasValue)
            	filter.Add(("AccBranchCode:=" + accBranchCode.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.Subsidiary_Accounts> Select(
                    int? subsAccountsID, 
                    int? accFundID, 
                    string accFundAccFundName, 
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
                    int? accSubTypeID, 
                    string accSubTypeAccSubType, 
                    int? accSubCode, 
                    string accSubAccSubName, 
                    string accSubAccSubTypeAccSubType, 
                    DateTime? openDate, 
                    decimal? openDebit, 
                    decimal? openCredit, 
                    int? accCurrency, 
                    string accCurrencyAccCurrencyName, 
                    decimal? accCurrencyRate, 
                    string lastUpdateBy, 
                    DateTime? lastUpdate, 
                    byte? dlt, 
                    int? accBranchCode, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(subsAccountsID, accFundID, accFundAccFundName, coaDetailID, coaDetailAccName, coaDetailAccBalTypeAccBalType, coaDetailAccCurrencyAccCurrencyName, coaDetailAccDestAccDest, coaDetailAccDestCompanyTypeDescription, coaDetailAccFundAccFundName, coaDetailAccSubTypeAccSubType, coaDetailAccTypeAccType, coaDetailCoaControlAccName, coaDetailCoaControlAccBalTypeAccBalType, coaDetailCoaControlAccDestAccDest, coaDetailCoaControlAccTypeAccType, coaDetailCoaControlCompTypeDescription, coaDetailCoaMainAccName, coaDetailCoaMainAccBalTypeAccBalType, coaDetailCoaMainAccDestAccDest, coaDetailCoaMainAccFundAccFundName, coaDetailCoaMainAccTypeAccType, coaDetailCoaMainCoaControlAccName, coaDetailCoaSubAccName, coaDetailCoaSubAccBalTypeAccBalType, coaDetailCoaSubAccDestAccDest, coaDetailCoaSubAccFundAccFundName, coaDetailCoaSubAccTypeAccType, coaDetailCoaSubCoaControlAccName, coaDetailCoaSubCoaMainAccName, accSubTypeID, accSubTypeAccSubType, accSubCode, accSubAccSubName, accSubAccSubTypeAccSubType, openDate, openDebit, openCredit, accCurrency, accCurrencyAccCurrencyName, accCurrencyRate, lastUpdateBy, lastUpdate, dlt, accBranchCode, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Subsidiary_Accounts", dataView, request);
            return page.ToList<MyCompany.Data.Objects.Subsidiary_Accounts>();
        }
        
        public List<MyCompany.Data.Objects.Subsidiary_Accounts> Select(MyCompany.Data.Objects.Subsidiary_Accounts qbe)
        {
            return Select(qbe.SubsAccountsID, qbe.AccFundID, qbe.AccFundAccFundName, qbe.CoaDetailID, qbe.CoaDetailAccName, qbe.CoaDetailAccBalTypeAccBalType, qbe.CoaDetailAccCurrencyAccCurrencyName, qbe.CoaDetailAccDestAccDest, qbe.CoaDetailAccDestCompanyTypeDescription, qbe.CoaDetailAccFundAccFundName, qbe.CoaDetailAccSubTypeAccSubType, qbe.CoaDetailAccTypeAccType, qbe.CoaDetailCoaControlAccName, qbe.CoaDetailCoaControlAccBalTypeAccBalType, qbe.CoaDetailCoaControlAccDestAccDest, qbe.CoaDetailCoaControlAccTypeAccType, qbe.CoaDetailCoaControlCompTypeDescription, qbe.CoaDetailCoaMainAccName, qbe.CoaDetailCoaMainAccBalTypeAccBalType, qbe.CoaDetailCoaMainAccDestAccDest, qbe.CoaDetailCoaMainAccFundAccFundName, qbe.CoaDetailCoaMainAccTypeAccType, qbe.CoaDetailCoaMainCoaControlAccName, qbe.CoaDetailCoaSubAccName, qbe.CoaDetailCoaSubAccBalTypeAccBalType, qbe.CoaDetailCoaSubAccDestAccDest, qbe.CoaDetailCoaSubAccFundAccFundName, qbe.CoaDetailCoaSubAccTypeAccType, qbe.CoaDetailCoaSubCoaControlAccName, qbe.CoaDetailCoaSubCoaMainAccName, qbe.AccSubTypeID, qbe.AccSubTypeAccSubType, qbe.AccSubCode, qbe.AccSubAccSubName, qbe.AccSubAccSubTypeAccSubType, qbe.OpenDate, qbe.OpenDebit, qbe.OpenCredit, qbe.AccCurrency, qbe.AccCurrencyAccCurrencyName, qbe.AccCurrencyRate, qbe.LastUpdateBy, qbe.LastUpdate, qbe.Dlt, qbe.AccBranchCode);
        }
        
        public int SelectCount(
                    int? subsAccountsID, 
                    int? accFundID, 
                    string accFundAccFundName, 
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
                    int? accSubTypeID, 
                    string accSubTypeAccSubType, 
                    int? accSubCode, 
                    string accSubAccSubName, 
                    string accSubAccSubTypeAccSubType, 
                    DateTime? openDate, 
                    decimal? openDebit, 
                    decimal? openCredit, 
                    int? accCurrency, 
                    string accCurrencyAccCurrencyName, 
                    decimal? accCurrencyRate, 
                    string lastUpdateBy, 
                    DateTime? lastUpdate, 
                    byte? dlt, 
                    int? accBranchCode, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(subsAccountsID, accFundID, accFundAccFundName, coaDetailID, coaDetailAccName, coaDetailAccBalTypeAccBalType, coaDetailAccCurrencyAccCurrencyName, coaDetailAccDestAccDest, coaDetailAccDestCompanyTypeDescription, coaDetailAccFundAccFundName, coaDetailAccSubTypeAccSubType, coaDetailAccTypeAccType, coaDetailCoaControlAccName, coaDetailCoaControlAccBalTypeAccBalType, coaDetailCoaControlAccDestAccDest, coaDetailCoaControlAccTypeAccType, coaDetailCoaControlCompTypeDescription, coaDetailCoaMainAccName, coaDetailCoaMainAccBalTypeAccBalType, coaDetailCoaMainAccDestAccDest, coaDetailCoaMainAccFundAccFundName, coaDetailCoaMainAccTypeAccType, coaDetailCoaMainCoaControlAccName, coaDetailCoaSubAccName, coaDetailCoaSubAccBalTypeAccBalType, coaDetailCoaSubAccDestAccDest, coaDetailCoaSubAccFundAccFundName, coaDetailCoaSubAccTypeAccType, coaDetailCoaSubCoaControlAccName, coaDetailCoaSubCoaMainAccName, accSubTypeID, accSubTypeAccSubType, accSubCode, accSubAccSubName, accSubAccSubTypeAccSubType, openDate, openDebit, openCredit, accCurrency, accCurrencyAccCurrencyName, accCurrencyRate, lastUpdateBy, lastUpdate, dlt, accBranchCode, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Subsidiary_Accounts", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.Subsidiary_Accounts> Select(
                    int? subsAccountsID, 
                    int? accFundID, 
                    string accFundAccFundName, 
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
                    int? accSubTypeID, 
                    string accSubTypeAccSubType, 
                    int? accSubCode, 
                    string accSubAccSubName, 
                    string accSubAccSubTypeAccSubType, 
                    DateTime? openDate, 
                    decimal? openDebit, 
                    decimal? openCredit, 
                    int? accCurrency, 
                    string accCurrencyAccCurrencyName, 
                    decimal? accCurrencyRate, 
                    string lastUpdateBy, 
                    DateTime? lastUpdate, 
                    byte? dlt, 
                    int? accBranchCode)
        {
            return Select(subsAccountsID, accFundID, accFundAccFundName, coaDetailID, coaDetailAccName, coaDetailAccBalTypeAccBalType, coaDetailAccCurrencyAccCurrencyName, coaDetailAccDestAccDest, coaDetailAccDestCompanyTypeDescription, coaDetailAccFundAccFundName, coaDetailAccSubTypeAccSubType, coaDetailAccTypeAccType, coaDetailCoaControlAccName, coaDetailCoaControlAccBalTypeAccBalType, coaDetailCoaControlAccDestAccDest, coaDetailCoaControlAccTypeAccType, coaDetailCoaControlCompTypeDescription, coaDetailCoaMainAccName, coaDetailCoaMainAccBalTypeAccBalType, coaDetailCoaMainAccDestAccDest, coaDetailCoaMainAccFundAccFundName, coaDetailCoaMainAccTypeAccType, coaDetailCoaMainCoaControlAccName, coaDetailCoaSubAccName, coaDetailCoaSubAccBalTypeAccBalType, coaDetailCoaSubAccDestAccDest, coaDetailCoaSubAccFundAccFundName, coaDetailCoaSubAccTypeAccType, coaDetailCoaSubCoaControlAccName, coaDetailCoaSubCoaMainAccName, accSubTypeID, accSubTypeAccSubType, accSubCode, accSubAccSubName, accSubAccSubTypeAccSubType, openDate, openDebit, openCredit, accCurrency, accCurrencyAccCurrencyName, accCurrencyRate, lastUpdateBy, lastUpdate, dlt, accBranchCode, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.Subsidiary_Accounts SelectSingle(int? subsAccountsID)
        {
            List<MyCompany.Data.Objects.Subsidiary_Accounts> list = Select(subsAccountsID, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.Subsidiary_Accounts> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("Subsidiary_Accounts", dataView, request);
            return page.ToList<MyCompany.Data.Objects.Subsidiary_Accounts>();
        }
        
        public List<MyCompany.Data.Objects.Subsidiary_Accounts> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.Subsidiary_Accounts> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.Subsidiary_Accounts SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.Subsidiary_Accounts> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.Subsidiary_Accounts theSubsidiary_Accounts, MyCompany.Data.Objects.Subsidiary_Accounts original_Subsidiary_Accounts)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("SubsAccountsID", original_Subsidiary_Accounts.SubsAccountsID, theSubsidiary_Accounts.SubsAccountsID, true));
            values.Add(new FieldValue("AccFundID", original_Subsidiary_Accounts.AccFundID, theSubsidiary_Accounts.AccFundID));
            values.Add(new FieldValue("AccFundAccFundName", original_Subsidiary_Accounts.AccFundAccFundName, theSubsidiary_Accounts.AccFundAccFundName, true));
            values.Add(new FieldValue("CoaDetailID", original_Subsidiary_Accounts.CoaDetailID, theSubsidiary_Accounts.CoaDetailID));
            values.Add(new FieldValue("CoaDetailAccName", original_Subsidiary_Accounts.CoaDetailAccName, theSubsidiary_Accounts.CoaDetailAccName, true));
            values.Add(new FieldValue("CoaDetailAccBalTypeAccBalType", original_Subsidiary_Accounts.CoaDetailAccBalTypeAccBalType, theSubsidiary_Accounts.CoaDetailAccBalTypeAccBalType, true));
            values.Add(new FieldValue("CoaDetailAccCurrencyAccCurrencyName", original_Subsidiary_Accounts.CoaDetailAccCurrencyAccCurrencyName, theSubsidiary_Accounts.CoaDetailAccCurrencyAccCurrencyName, true));
            values.Add(new FieldValue("CoaDetailAccDestAccDest", original_Subsidiary_Accounts.CoaDetailAccDestAccDest, theSubsidiary_Accounts.CoaDetailAccDestAccDest, true));
            values.Add(new FieldValue("CoaDetailAccDestCompanyTypeDescription", original_Subsidiary_Accounts.CoaDetailAccDestCompanyTypeDescription, theSubsidiary_Accounts.CoaDetailAccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("CoaDetailAccFundAccFundName", original_Subsidiary_Accounts.CoaDetailAccFundAccFundName, theSubsidiary_Accounts.CoaDetailAccFundAccFundName, true));
            values.Add(new FieldValue("CoaDetailAccSubTypeAccSubType", original_Subsidiary_Accounts.CoaDetailAccSubTypeAccSubType, theSubsidiary_Accounts.CoaDetailAccSubTypeAccSubType, true));
            values.Add(new FieldValue("CoaDetailAccTypeAccType", original_Subsidiary_Accounts.CoaDetailAccTypeAccType, theSubsidiary_Accounts.CoaDetailAccTypeAccType, true));
            values.Add(new FieldValue("CoaDetailCoaControlAccName", original_Subsidiary_Accounts.CoaDetailCoaControlAccName, theSubsidiary_Accounts.CoaDetailCoaControlAccName, true));
            values.Add(new FieldValue("CoaDetailCoaControlAccBalTypeAccBalType", original_Subsidiary_Accounts.CoaDetailCoaControlAccBalTypeAccBalType, theSubsidiary_Accounts.CoaDetailCoaControlAccBalTypeAccBalType, true));
            values.Add(new FieldValue("CoaDetailCoaControlAccDestAccDest", original_Subsidiary_Accounts.CoaDetailCoaControlAccDestAccDest, theSubsidiary_Accounts.CoaDetailCoaControlAccDestAccDest, true));
            values.Add(new FieldValue("CoaDetailCoaControlAccTypeAccType", original_Subsidiary_Accounts.CoaDetailCoaControlAccTypeAccType, theSubsidiary_Accounts.CoaDetailCoaControlAccTypeAccType, true));
            values.Add(new FieldValue("CoaDetailCoaControlCompTypeDescription", original_Subsidiary_Accounts.CoaDetailCoaControlCompTypeDescription, theSubsidiary_Accounts.CoaDetailCoaControlCompTypeDescription, true));
            values.Add(new FieldValue("CoaDetailCoaMainAccName", original_Subsidiary_Accounts.CoaDetailCoaMainAccName, theSubsidiary_Accounts.CoaDetailCoaMainAccName, true));
            values.Add(new FieldValue("CoaDetailCoaMainAccBalTypeAccBalType", original_Subsidiary_Accounts.CoaDetailCoaMainAccBalTypeAccBalType, theSubsidiary_Accounts.CoaDetailCoaMainAccBalTypeAccBalType, true));
            values.Add(new FieldValue("CoaDetailCoaMainAccDestAccDest", original_Subsidiary_Accounts.CoaDetailCoaMainAccDestAccDest, theSubsidiary_Accounts.CoaDetailCoaMainAccDestAccDest, true));
            values.Add(new FieldValue("CoaDetailCoaMainAccFundAccFundName", original_Subsidiary_Accounts.CoaDetailCoaMainAccFundAccFundName, theSubsidiary_Accounts.CoaDetailCoaMainAccFundAccFundName, true));
            values.Add(new FieldValue("CoaDetailCoaMainAccTypeAccType", original_Subsidiary_Accounts.CoaDetailCoaMainAccTypeAccType, theSubsidiary_Accounts.CoaDetailCoaMainAccTypeAccType, true));
            values.Add(new FieldValue("CoaDetailCoaMainCoaControlAccName", original_Subsidiary_Accounts.CoaDetailCoaMainCoaControlAccName, theSubsidiary_Accounts.CoaDetailCoaMainCoaControlAccName, true));
            values.Add(new FieldValue("CoaDetailCoaSubAccName", original_Subsidiary_Accounts.CoaDetailCoaSubAccName, theSubsidiary_Accounts.CoaDetailCoaSubAccName, true));
            values.Add(new FieldValue("CoaDetailCoaSubAccBalTypeAccBalType", original_Subsidiary_Accounts.CoaDetailCoaSubAccBalTypeAccBalType, theSubsidiary_Accounts.CoaDetailCoaSubAccBalTypeAccBalType, true));
            values.Add(new FieldValue("CoaDetailCoaSubAccDestAccDest", original_Subsidiary_Accounts.CoaDetailCoaSubAccDestAccDest, theSubsidiary_Accounts.CoaDetailCoaSubAccDestAccDest, true));
            values.Add(new FieldValue("CoaDetailCoaSubAccFundAccFundName", original_Subsidiary_Accounts.CoaDetailCoaSubAccFundAccFundName, theSubsidiary_Accounts.CoaDetailCoaSubAccFundAccFundName, true));
            values.Add(new FieldValue("CoaDetailCoaSubAccTypeAccType", original_Subsidiary_Accounts.CoaDetailCoaSubAccTypeAccType, theSubsidiary_Accounts.CoaDetailCoaSubAccTypeAccType, true));
            values.Add(new FieldValue("CoaDetailCoaSubCoaControlAccName", original_Subsidiary_Accounts.CoaDetailCoaSubCoaControlAccName, theSubsidiary_Accounts.CoaDetailCoaSubCoaControlAccName, true));
            values.Add(new FieldValue("CoaDetailCoaSubCoaMainAccName", original_Subsidiary_Accounts.CoaDetailCoaSubCoaMainAccName, theSubsidiary_Accounts.CoaDetailCoaSubCoaMainAccName, true));
            values.Add(new FieldValue("AccSubTypeID", original_Subsidiary_Accounts.AccSubTypeID, theSubsidiary_Accounts.AccSubTypeID));
            values.Add(new FieldValue("AccSubTypeAccSubType", original_Subsidiary_Accounts.AccSubTypeAccSubType, theSubsidiary_Accounts.AccSubTypeAccSubType, true));
            values.Add(new FieldValue("AccSubCode", original_Subsidiary_Accounts.AccSubCode, theSubsidiary_Accounts.AccSubCode));
            values.Add(new FieldValue("AccSubAccSubName", original_Subsidiary_Accounts.AccSubAccSubName, theSubsidiary_Accounts.AccSubAccSubName, true));
            values.Add(new FieldValue("AccSubAccSubTypeAccSubType", original_Subsidiary_Accounts.AccSubAccSubTypeAccSubType, theSubsidiary_Accounts.AccSubAccSubTypeAccSubType, true));
            values.Add(new FieldValue("OpenDate", original_Subsidiary_Accounts.OpenDate, theSubsidiary_Accounts.OpenDate));
            values.Add(new FieldValue("OpenDebit", original_Subsidiary_Accounts.OpenDebit, theSubsidiary_Accounts.OpenDebit));
            values.Add(new FieldValue("OpenCredit", original_Subsidiary_Accounts.OpenCredit, theSubsidiary_Accounts.OpenCredit));
            values.Add(new FieldValue("AccCurrency", original_Subsidiary_Accounts.AccCurrency, theSubsidiary_Accounts.AccCurrency));
            values.Add(new FieldValue("AccCurrencyAccCurrencyName", original_Subsidiary_Accounts.AccCurrencyAccCurrencyName, theSubsidiary_Accounts.AccCurrencyAccCurrencyName, true));
            values.Add(new FieldValue("AccCurrencyRate", original_Subsidiary_Accounts.AccCurrencyRate, theSubsidiary_Accounts.AccCurrencyRate));
            values.Add(new FieldValue("LastUpdateBy", original_Subsidiary_Accounts.LastUpdateBy, theSubsidiary_Accounts.LastUpdateBy));
            values.Add(new FieldValue("LastUpdate", original_Subsidiary_Accounts.LastUpdate, theSubsidiary_Accounts.LastUpdate));
            values.Add(new FieldValue("Dlt", original_Subsidiary_Accounts.Dlt, theSubsidiary_Accounts.Dlt));
            values.Add(new FieldValue("AccBranchCode", original_Subsidiary_Accounts.AccBranchCode, theSubsidiary_Accounts.AccBranchCode));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.Subsidiary_Accounts theSubsidiary_Accounts, MyCompany.Data.Objects.Subsidiary_Accounts original_Subsidiary_Accounts, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "Subsidiary_Accounts";
            args.View = dataView;
            args.Values = CreateFieldValues(theSubsidiary_Accounts, original_Subsidiary_Accounts);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("Subsidiary_Accounts", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theSubsidiary_Accounts);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.Subsidiary_Accounts theSubsidiary_Accounts, MyCompany.Data.Objects.Subsidiary_Accounts original_Subsidiary_Accounts)
        {
            return ExecuteAction(theSubsidiary_Accounts, original_Subsidiary_Accounts, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.Subsidiary_Accounts theSubsidiary_Accounts)
        {
            return Update(theSubsidiary_Accounts, SelectSingle(theSubsidiary_Accounts.SubsAccountsID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.Subsidiary_Accounts theSubsidiary_Accounts)
        {
            return ExecuteAction(theSubsidiary_Accounts, new Subsidiary_Accounts(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.Subsidiary_Accounts theSubsidiary_Accounts)
        {
            return ExecuteAction(theSubsidiary_Accounts, theSubsidiary_Accounts, "Select", "Delete", DeleteView);
        }
    }
}
