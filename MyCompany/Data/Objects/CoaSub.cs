using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class CoaSub
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _coaSubID;
        
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
        private decimal? _accCurrencyRate;
        
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
        
        public CoaSub()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
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
        
        public static List<MyCompany.Data.Objects.CoaSub> Select(
                    int? coaSubID, 
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
                    decimal? accCurrencyRate, 
                    string consTranCode, 
                    int? coaControlID, 
                    string coaControlAccName, 
                    string coaControlAccBalTypeAccBalType, 
                    string coaControlAccDestAccDest, 
                    string coaControlAccDestCompanyTypeDescription, 
                    string coaControlAccTypeAccType, 
                    string coaControlCompTypeDescription, 
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
                    string coaMainCoaControlCompTypeDescription)
        {
            return new CoaSubFactory().Select(coaSubID, accFundID, accFundAccFundName, accFundCode, acccode, accName, accDesc, accTypeID, accTypeAccType, accDestID, accDestAccDest, accDestCompanyTypeDescription, accBalTypeID, accBalTypeAccBalType, accCurrency, accCurrencyRate, consTranCode, coaControlID, coaControlAccName, coaControlAccBalTypeAccBalType, coaControlAccDestAccDest, coaControlAccDestCompanyTypeDescription, coaControlAccTypeAccType, coaControlCompTypeDescription, coaMainID, coaMainAccName, coaMainAccBalTypeAccBalType, coaMainAccDestAccDest, coaMainAccDestCompanyTypeDescription, coaMainAccFundAccFundName, coaMainAccTypeAccType, coaMainCoaControlAccName, coaMainCoaControlAccBalTypeAccBalType, coaMainCoaControlAccDestAccDest, coaMainCoaControlAccTypeAccType, coaMainCoaControlCompTypeDescription);
        }
        
        public static List<MyCompany.Data.Objects.CoaSub> Select(MyCompany.Data.Objects.CoaSub qbe)
        {
            return new CoaSubFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.CoaSub> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new CoaSubFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.CoaSub> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new CoaSubFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.CoaSub> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new CoaSubFactory().Select(filter, sort, CoaSubFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.CoaSub> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new CoaSubFactory().Select(filter, sort, CoaSubFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.CoaSub> Select(string filter, BusinessObjectParameters parameters)
        {
            return new CoaSubFactory().Select(filter, null, CoaSubFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.CoaSub> Select(string filter, params FieldValue[] parameters)
        {
            return new CoaSubFactory().Select(filter, null, CoaSubFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.CoaSub SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new CoaSubFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.CoaSub SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new CoaSubFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.CoaSub SelectSingle(int? coaSubID)
        {
            return new CoaSubFactory().SelectSingle(coaSubID);
        }
        
        public int Insert()
        {
            return new CoaSubFactory().Insert(this);
        }
        
        public int Update()
        {
            return new CoaSubFactory().Update(this);
        }
        
        public int Delete()
        {
            return new CoaSubFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("CoaSubID: {0}", this.CoaSubID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class CoaSubFactory
    {
        
        public CoaSubFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("CoaSub");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("CoaSub");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("CoaSub");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("CoaSub");
            }
        }
        
        public static CoaSubFactory Create()
        {
            return new CoaSubFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    int? coaSubID, 
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
                    decimal? accCurrencyRate, 
                    string consTranCode, 
                    int? coaControlID, 
                    string coaControlAccName, 
                    string coaControlAccBalTypeAccBalType, 
                    string coaControlAccDestAccDest, 
                    string coaControlAccDestCompanyTypeDescription, 
                    string coaControlAccTypeAccType, 
                    string coaControlCompTypeDescription, 
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
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (coaSubID.HasValue)
            	filter.Add(("CoaSubID:=" + coaSubID.Value.ToString()));
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
            if (accCurrencyRate.HasValue)
            	filter.Add(("AccCurrencyRate:=" + accCurrencyRate.Value.ToString()));
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
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.CoaSub> Select(
                    int? coaSubID, 
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
                    decimal? accCurrencyRate, 
                    string consTranCode, 
                    int? coaControlID, 
                    string coaControlAccName, 
                    string coaControlAccBalTypeAccBalType, 
                    string coaControlAccDestAccDest, 
                    string coaControlAccDestCompanyTypeDescription, 
                    string coaControlAccTypeAccType, 
                    string coaControlCompTypeDescription, 
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
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(coaSubID, accFundID, accFundAccFundName, accFundCode, acccode, accName, accDesc, accTypeID, accTypeAccType, accDestID, accDestAccDest, accDestCompanyTypeDescription, accBalTypeID, accBalTypeAccBalType, accCurrency, accCurrencyRate, consTranCode, coaControlID, coaControlAccName, coaControlAccBalTypeAccBalType, coaControlAccDestAccDest, coaControlAccDestCompanyTypeDescription, coaControlAccTypeAccType, coaControlCompTypeDescription, coaMainID, coaMainAccName, coaMainAccBalTypeAccBalType, coaMainAccDestAccDest, coaMainAccDestCompanyTypeDescription, coaMainAccFundAccFundName, coaMainAccTypeAccType, coaMainCoaControlAccName, coaMainCoaControlAccBalTypeAccBalType, coaMainCoaControlAccDestAccDest, coaMainCoaControlAccTypeAccType, coaMainCoaControlCompTypeDescription, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("CoaSub", dataView, request);
            return page.ToList<MyCompany.Data.Objects.CoaSub>();
        }
        
        public List<MyCompany.Data.Objects.CoaSub> Select(MyCompany.Data.Objects.CoaSub qbe)
        {
            return Select(qbe.CoaSubID, qbe.AccFundID, qbe.AccFundAccFundName, qbe.AccFundCode, qbe.Acccode, qbe.AccName, qbe.AccDesc, qbe.AccTypeID, qbe.AccTypeAccType, qbe.AccDestID, qbe.AccDestAccDest, qbe.AccDestCompanyTypeDescription, qbe.AccBalTypeID, qbe.AccBalTypeAccBalType, qbe.AccCurrency, qbe.AccCurrencyRate, qbe.ConsTranCode, qbe.CoaControlID, qbe.CoaControlAccName, qbe.CoaControlAccBalTypeAccBalType, qbe.CoaControlAccDestAccDest, qbe.CoaControlAccDestCompanyTypeDescription, qbe.CoaControlAccTypeAccType, qbe.CoaControlCompTypeDescription, qbe.CoaMainID, qbe.CoaMainAccName, qbe.CoaMainAccBalTypeAccBalType, qbe.CoaMainAccDestAccDest, qbe.CoaMainAccDestCompanyTypeDescription, qbe.CoaMainAccFundAccFundName, qbe.CoaMainAccTypeAccType, qbe.CoaMainCoaControlAccName, qbe.CoaMainCoaControlAccBalTypeAccBalType, qbe.CoaMainCoaControlAccDestAccDest, qbe.CoaMainCoaControlAccTypeAccType, qbe.CoaMainCoaControlCompTypeDescription);
        }
        
        public int SelectCount(
                    int? coaSubID, 
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
                    decimal? accCurrencyRate, 
                    string consTranCode, 
                    int? coaControlID, 
                    string coaControlAccName, 
                    string coaControlAccBalTypeAccBalType, 
                    string coaControlAccDestAccDest, 
                    string coaControlAccDestCompanyTypeDescription, 
                    string coaControlAccTypeAccType, 
                    string coaControlCompTypeDescription, 
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
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(coaSubID, accFundID, accFundAccFundName, accFundCode, acccode, accName, accDesc, accTypeID, accTypeAccType, accDestID, accDestAccDest, accDestCompanyTypeDescription, accBalTypeID, accBalTypeAccBalType, accCurrency, accCurrencyRate, consTranCode, coaControlID, coaControlAccName, coaControlAccBalTypeAccBalType, coaControlAccDestAccDest, coaControlAccDestCompanyTypeDescription, coaControlAccTypeAccType, coaControlCompTypeDescription, coaMainID, coaMainAccName, coaMainAccBalTypeAccBalType, coaMainAccDestAccDest, coaMainAccDestCompanyTypeDescription, coaMainAccFundAccFundName, coaMainAccTypeAccType, coaMainCoaControlAccName, coaMainCoaControlAccBalTypeAccBalType, coaMainCoaControlAccDestAccDest, coaMainCoaControlAccTypeAccType, coaMainCoaControlCompTypeDescription, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("CoaSub", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.CoaSub> Select(
                    int? coaSubID, 
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
                    decimal? accCurrencyRate, 
                    string consTranCode, 
                    int? coaControlID, 
                    string coaControlAccName, 
                    string coaControlAccBalTypeAccBalType, 
                    string coaControlAccDestAccDest, 
                    string coaControlAccDestCompanyTypeDescription, 
                    string coaControlAccTypeAccType, 
                    string coaControlCompTypeDescription, 
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
                    string coaMainCoaControlCompTypeDescription)
        {
            return Select(coaSubID, accFundID, accFundAccFundName, accFundCode, acccode, accName, accDesc, accTypeID, accTypeAccType, accDestID, accDestAccDest, accDestCompanyTypeDescription, accBalTypeID, accBalTypeAccBalType, accCurrency, accCurrencyRate, consTranCode, coaControlID, coaControlAccName, coaControlAccBalTypeAccBalType, coaControlAccDestAccDest, coaControlAccDestCompanyTypeDescription, coaControlAccTypeAccType, coaControlCompTypeDescription, coaMainID, coaMainAccName, coaMainAccBalTypeAccBalType, coaMainAccDestAccDest, coaMainAccDestCompanyTypeDescription, coaMainAccFundAccFundName, coaMainAccTypeAccType, coaMainCoaControlAccName, coaMainCoaControlAccBalTypeAccBalType, coaMainCoaControlAccDestAccDest, coaMainCoaControlAccTypeAccType, coaMainCoaControlCompTypeDescription, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.CoaSub SelectSingle(int? coaSubID)
        {
            List<MyCompany.Data.Objects.CoaSub> list = Select(coaSubID, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.CoaSub> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("CoaSub", dataView, request);
            return page.ToList<MyCompany.Data.Objects.CoaSub>();
        }
        
        public List<MyCompany.Data.Objects.CoaSub> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.CoaSub> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.CoaSub SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.CoaSub> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.CoaSub theCoaSub, MyCompany.Data.Objects.CoaSub original_CoaSub)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("CoaSubID", original_CoaSub.CoaSubID, theCoaSub.CoaSubID, true));
            values.Add(new FieldValue("AccFundID", original_CoaSub.AccFundID, theCoaSub.AccFundID));
            values.Add(new FieldValue("AccFundAccFundName", original_CoaSub.AccFundAccFundName, theCoaSub.AccFundAccFundName, true));
            values.Add(new FieldValue("AccFundCode", original_CoaSub.AccFundCode, theCoaSub.AccFundCode));
            values.Add(new FieldValue("Acccode", original_CoaSub.Acccode, theCoaSub.Acccode));
            values.Add(new FieldValue("AccName", original_CoaSub.AccName, theCoaSub.AccName));
            values.Add(new FieldValue("AccDesc", original_CoaSub.AccDesc, theCoaSub.AccDesc));
            values.Add(new FieldValue("AccTypeID", original_CoaSub.AccTypeID, theCoaSub.AccTypeID));
            values.Add(new FieldValue("AccTypeAccType", original_CoaSub.AccTypeAccType, theCoaSub.AccTypeAccType, true));
            values.Add(new FieldValue("AccDestID", original_CoaSub.AccDestID, theCoaSub.AccDestID));
            values.Add(new FieldValue("AccDestAccDest", original_CoaSub.AccDestAccDest, theCoaSub.AccDestAccDest, true));
            values.Add(new FieldValue("AccDestCompanyTypeDescription", original_CoaSub.AccDestCompanyTypeDescription, theCoaSub.AccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("AccBalTypeID", original_CoaSub.AccBalTypeID, theCoaSub.AccBalTypeID));
            values.Add(new FieldValue("AccBalTypeAccBalType", original_CoaSub.AccBalTypeAccBalType, theCoaSub.AccBalTypeAccBalType, true));
            values.Add(new FieldValue("AccCurrency", original_CoaSub.AccCurrency, theCoaSub.AccCurrency));
            values.Add(new FieldValue("AccCurrencyRate", original_CoaSub.AccCurrencyRate, theCoaSub.AccCurrencyRate));
            values.Add(new FieldValue("ConsTranCode", original_CoaSub.ConsTranCode, theCoaSub.ConsTranCode));
            values.Add(new FieldValue("CoaControlID", original_CoaSub.CoaControlID, theCoaSub.CoaControlID));
            values.Add(new FieldValue("CoaControlAccName", original_CoaSub.CoaControlAccName, theCoaSub.CoaControlAccName, true));
            values.Add(new FieldValue("CoaControlAccBalTypeAccBalType", original_CoaSub.CoaControlAccBalTypeAccBalType, theCoaSub.CoaControlAccBalTypeAccBalType, true));
            values.Add(new FieldValue("CoaControlAccDestAccDest", original_CoaSub.CoaControlAccDestAccDest, theCoaSub.CoaControlAccDestAccDest, true));
            values.Add(new FieldValue("CoaControlAccDestCompanyTypeDescription", original_CoaSub.CoaControlAccDestCompanyTypeDescription, theCoaSub.CoaControlAccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("CoaControlAccTypeAccType", original_CoaSub.CoaControlAccTypeAccType, theCoaSub.CoaControlAccTypeAccType, true));
            values.Add(new FieldValue("CoaControlCompTypeDescription", original_CoaSub.CoaControlCompTypeDescription, theCoaSub.CoaControlCompTypeDescription, true));
            values.Add(new FieldValue("CoaMainID", original_CoaSub.CoaMainID, theCoaSub.CoaMainID));
            values.Add(new FieldValue("CoaMainAccName", original_CoaSub.CoaMainAccName, theCoaSub.CoaMainAccName, true));
            values.Add(new FieldValue("CoaMainAccBalTypeAccBalType", original_CoaSub.CoaMainAccBalTypeAccBalType, theCoaSub.CoaMainAccBalTypeAccBalType, true));
            values.Add(new FieldValue("CoaMainAccDestAccDest", original_CoaSub.CoaMainAccDestAccDest, theCoaSub.CoaMainAccDestAccDest, true));
            values.Add(new FieldValue("CoaMainAccDestCompanyTypeDescription", original_CoaSub.CoaMainAccDestCompanyTypeDescription, theCoaSub.CoaMainAccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("CoaMainAccFundAccFundName", original_CoaSub.CoaMainAccFundAccFundName, theCoaSub.CoaMainAccFundAccFundName, true));
            values.Add(new FieldValue("CoaMainAccTypeAccType", original_CoaSub.CoaMainAccTypeAccType, theCoaSub.CoaMainAccTypeAccType, true));
            values.Add(new FieldValue("CoaMainCoaControlAccName", original_CoaSub.CoaMainCoaControlAccName, theCoaSub.CoaMainCoaControlAccName, true));
            values.Add(new FieldValue("CoaMainCoaControlAccBalTypeAccBalType", original_CoaSub.CoaMainCoaControlAccBalTypeAccBalType, theCoaSub.CoaMainCoaControlAccBalTypeAccBalType, true));
            values.Add(new FieldValue("CoaMainCoaControlAccDestAccDest", original_CoaSub.CoaMainCoaControlAccDestAccDest, theCoaSub.CoaMainCoaControlAccDestAccDest, true));
            values.Add(new FieldValue("CoaMainCoaControlAccTypeAccType", original_CoaSub.CoaMainCoaControlAccTypeAccType, theCoaSub.CoaMainCoaControlAccTypeAccType, true));
            values.Add(new FieldValue("CoaMainCoaControlCompTypeDescription", original_CoaSub.CoaMainCoaControlCompTypeDescription, theCoaSub.CoaMainCoaControlCompTypeDescription, true));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.CoaSub theCoaSub, MyCompany.Data.Objects.CoaSub original_CoaSub, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "CoaSub";
            args.View = dataView;
            args.Values = CreateFieldValues(theCoaSub, original_CoaSub);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("CoaSub", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theCoaSub);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.CoaSub theCoaSub, MyCompany.Data.Objects.CoaSub original_CoaSub)
        {
            return ExecuteAction(theCoaSub, original_CoaSub, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.CoaSub theCoaSub)
        {
            return Update(theCoaSub, SelectSingle(theCoaSub.CoaSubID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.CoaSub theCoaSub)
        {
            return ExecuteAction(theCoaSub, new CoaSub(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.CoaSub theCoaSub)
        {
            return ExecuteAction(theCoaSub, theCoaSub, "Select", "Delete", DeleteView);
        }
    }
}
