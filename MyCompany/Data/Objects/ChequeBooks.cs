using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class ChequeBooks
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _chequeBookID;
        
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
        private string _chequeBookNo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _leafStart;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _leafEnd;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _createdBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _createdDate;
        
        public ChequeBooks()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? ChequeBookID
        {
            get
            {
                return _chequeBookID;
            }
            set
            {
                _chequeBookID = value;
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
        public string ChequeBookNo
        {
            get
            {
                return _chequeBookNo;
            }
            set
            {
                _chequeBookNo = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? LeafStart
        {
            get
            {
                return _leafStart;
            }
            set
            {
                _leafStart = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? LeafEnd
        {
            get
            {
                return _leafEnd;
            }
            set
            {
                _leafEnd = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CreatedBy
        {
            get
            {
                return _createdBy;
            }
            set
            {
                _createdBy = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? CreatedDate
        {
            get
            {
                return _createdDate;
            }
            set
            {
                _createdDate = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.ChequeBooks> Select(
                    int? chequeBookID, 
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
                    string chequeBookNo, 
                    int? leafStart, 
                    int? leafEnd, 
                    string createdBy, 
                    DateTime? createdDate)
        {
            return new ChequeBooksFactory().Select(chequeBookID, accFundID, accFundAccFundName, coaDetailID, coaDetailAccName, coaDetailAccBalTypeAccBalType, coaDetailAccCurrencyAccCurrencyName, coaDetailAccDestAccDest, coaDetailAccDestCompanyTypeDescription, coaDetailAccFundAccFundName, coaDetailAccSubTypeAccSubType, coaDetailAccTypeAccType, coaDetailCoaControlAccName, coaDetailCoaControlAccBalTypeAccBalType, coaDetailCoaControlAccDestAccDest, coaDetailCoaControlAccTypeAccType, coaDetailCoaControlCompTypeDescription, coaDetailCoaMainAccName, coaDetailCoaMainAccBalTypeAccBalType, coaDetailCoaMainAccDestAccDest, coaDetailCoaMainAccFundAccFundName, coaDetailCoaMainAccTypeAccType, coaDetailCoaMainCoaControlAccName, coaDetailCoaSubAccName, coaDetailCoaSubAccBalTypeAccBalType, coaDetailCoaSubAccDestAccDest, coaDetailCoaSubAccFundAccFundName, coaDetailCoaSubAccTypeAccType, coaDetailCoaSubCoaControlAccName, coaDetailCoaSubCoaMainAccName, chequeBookNo, leafStart, leafEnd, createdBy, createdDate);
        }
        
        public static List<MyCompany.Data.Objects.ChequeBooks> Select(MyCompany.Data.Objects.ChequeBooks qbe)
        {
            return new ChequeBooksFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.ChequeBooks> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new ChequeBooksFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.ChequeBooks> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new ChequeBooksFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.ChequeBooks> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new ChequeBooksFactory().Select(filter, sort, ChequeBooksFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.ChequeBooks> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new ChequeBooksFactory().Select(filter, sort, ChequeBooksFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.ChequeBooks> Select(string filter, BusinessObjectParameters parameters)
        {
            return new ChequeBooksFactory().Select(filter, null, ChequeBooksFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.ChequeBooks> Select(string filter, params FieldValue[] parameters)
        {
            return new ChequeBooksFactory().Select(filter, null, ChequeBooksFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.ChequeBooks SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new ChequeBooksFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.ChequeBooks SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new ChequeBooksFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.ChequeBooks SelectSingle(int? chequeBookID)
        {
            return new ChequeBooksFactory().SelectSingle(chequeBookID);
        }
        
        public int Insert()
        {
            return new ChequeBooksFactory().Insert(this);
        }
        
        public int Update()
        {
            return new ChequeBooksFactory().Update(this);
        }
        
        public int Delete()
        {
            return new ChequeBooksFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("ChequeBookID: {0}", this.ChequeBookID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class ChequeBooksFactory
    {
        
        public ChequeBooksFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("ChequeBooks");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("ChequeBooks");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("ChequeBooks");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("ChequeBooks");
            }
        }
        
        public static ChequeBooksFactory Create()
        {
            return new ChequeBooksFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    int? chequeBookID, 
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
                    string chequeBookNo, 
                    int? leafStart, 
                    int? leafEnd, 
                    string createdBy, 
                    DateTime? createdDate, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (chequeBookID.HasValue)
            	filter.Add(("ChequeBookID:=" + chequeBookID.Value.ToString()));
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
            if (!(String.IsNullOrEmpty(chequeBookNo)))
            	filter.Add(("ChequeBookNo:*" + chequeBookNo));
            if (leafStart.HasValue)
            	filter.Add(("LeafStart:=" + leafStart.Value.ToString()));
            if (leafEnd.HasValue)
            	filter.Add(("LeafEnd:=" + leafEnd.Value.ToString()));
            if (!(String.IsNullOrEmpty(createdBy)))
            	filter.Add(("CreatedBy:*" + createdBy));
            if (createdDate.HasValue)
            	filter.Add(("CreatedDate:=" + createdDate.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.ChequeBooks> Select(
                    int? chequeBookID, 
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
                    string chequeBookNo, 
                    int? leafStart, 
                    int? leafEnd, 
                    string createdBy, 
                    DateTime? createdDate, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(chequeBookID, accFundID, accFundAccFundName, coaDetailID, coaDetailAccName, coaDetailAccBalTypeAccBalType, coaDetailAccCurrencyAccCurrencyName, coaDetailAccDestAccDest, coaDetailAccDestCompanyTypeDescription, coaDetailAccFundAccFundName, coaDetailAccSubTypeAccSubType, coaDetailAccTypeAccType, coaDetailCoaControlAccName, coaDetailCoaControlAccBalTypeAccBalType, coaDetailCoaControlAccDestAccDest, coaDetailCoaControlAccTypeAccType, coaDetailCoaControlCompTypeDescription, coaDetailCoaMainAccName, coaDetailCoaMainAccBalTypeAccBalType, coaDetailCoaMainAccDestAccDest, coaDetailCoaMainAccFundAccFundName, coaDetailCoaMainAccTypeAccType, coaDetailCoaMainCoaControlAccName, coaDetailCoaSubAccName, coaDetailCoaSubAccBalTypeAccBalType, coaDetailCoaSubAccDestAccDest, coaDetailCoaSubAccFundAccFundName, coaDetailCoaSubAccTypeAccType, coaDetailCoaSubCoaControlAccName, coaDetailCoaSubCoaMainAccName, chequeBookNo, leafStart, leafEnd, createdBy, createdDate, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("ChequeBooks", dataView, request);
            return page.ToList<MyCompany.Data.Objects.ChequeBooks>();
        }
        
        public List<MyCompany.Data.Objects.ChequeBooks> Select(MyCompany.Data.Objects.ChequeBooks qbe)
        {
            return Select(qbe.ChequeBookID, qbe.AccFundID, qbe.AccFundAccFundName, qbe.CoaDetailID, qbe.CoaDetailAccName, qbe.CoaDetailAccBalTypeAccBalType, qbe.CoaDetailAccCurrencyAccCurrencyName, qbe.CoaDetailAccDestAccDest, qbe.CoaDetailAccDestCompanyTypeDescription, qbe.CoaDetailAccFundAccFundName, qbe.CoaDetailAccSubTypeAccSubType, qbe.CoaDetailAccTypeAccType, qbe.CoaDetailCoaControlAccName, qbe.CoaDetailCoaControlAccBalTypeAccBalType, qbe.CoaDetailCoaControlAccDestAccDest, qbe.CoaDetailCoaControlAccTypeAccType, qbe.CoaDetailCoaControlCompTypeDescription, qbe.CoaDetailCoaMainAccName, qbe.CoaDetailCoaMainAccBalTypeAccBalType, qbe.CoaDetailCoaMainAccDestAccDest, qbe.CoaDetailCoaMainAccFundAccFundName, qbe.CoaDetailCoaMainAccTypeAccType, qbe.CoaDetailCoaMainCoaControlAccName, qbe.CoaDetailCoaSubAccName, qbe.CoaDetailCoaSubAccBalTypeAccBalType, qbe.CoaDetailCoaSubAccDestAccDest, qbe.CoaDetailCoaSubAccFundAccFundName, qbe.CoaDetailCoaSubAccTypeAccType, qbe.CoaDetailCoaSubCoaControlAccName, qbe.CoaDetailCoaSubCoaMainAccName, qbe.ChequeBookNo, qbe.LeafStart, qbe.LeafEnd, qbe.CreatedBy, qbe.CreatedDate);
        }
        
        public int SelectCount(
                    int? chequeBookID, 
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
                    string chequeBookNo, 
                    int? leafStart, 
                    int? leafEnd, 
                    string createdBy, 
                    DateTime? createdDate, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(chequeBookID, accFundID, accFundAccFundName, coaDetailID, coaDetailAccName, coaDetailAccBalTypeAccBalType, coaDetailAccCurrencyAccCurrencyName, coaDetailAccDestAccDest, coaDetailAccDestCompanyTypeDescription, coaDetailAccFundAccFundName, coaDetailAccSubTypeAccSubType, coaDetailAccTypeAccType, coaDetailCoaControlAccName, coaDetailCoaControlAccBalTypeAccBalType, coaDetailCoaControlAccDestAccDest, coaDetailCoaControlAccTypeAccType, coaDetailCoaControlCompTypeDescription, coaDetailCoaMainAccName, coaDetailCoaMainAccBalTypeAccBalType, coaDetailCoaMainAccDestAccDest, coaDetailCoaMainAccFundAccFundName, coaDetailCoaMainAccTypeAccType, coaDetailCoaMainCoaControlAccName, coaDetailCoaSubAccName, coaDetailCoaSubAccBalTypeAccBalType, coaDetailCoaSubAccDestAccDest, coaDetailCoaSubAccFundAccFundName, coaDetailCoaSubAccTypeAccType, coaDetailCoaSubCoaControlAccName, coaDetailCoaSubCoaMainAccName, chequeBookNo, leafStart, leafEnd, createdBy, createdDate, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("ChequeBooks", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.ChequeBooks> Select(
                    int? chequeBookID, 
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
                    string chequeBookNo, 
                    int? leafStart, 
                    int? leafEnd, 
                    string createdBy, 
                    DateTime? createdDate)
        {
            return Select(chequeBookID, accFundID, accFundAccFundName, coaDetailID, coaDetailAccName, coaDetailAccBalTypeAccBalType, coaDetailAccCurrencyAccCurrencyName, coaDetailAccDestAccDest, coaDetailAccDestCompanyTypeDescription, coaDetailAccFundAccFundName, coaDetailAccSubTypeAccSubType, coaDetailAccTypeAccType, coaDetailCoaControlAccName, coaDetailCoaControlAccBalTypeAccBalType, coaDetailCoaControlAccDestAccDest, coaDetailCoaControlAccTypeAccType, coaDetailCoaControlCompTypeDescription, coaDetailCoaMainAccName, coaDetailCoaMainAccBalTypeAccBalType, coaDetailCoaMainAccDestAccDest, coaDetailCoaMainAccFundAccFundName, coaDetailCoaMainAccTypeAccType, coaDetailCoaMainCoaControlAccName, coaDetailCoaSubAccName, coaDetailCoaSubAccBalTypeAccBalType, coaDetailCoaSubAccDestAccDest, coaDetailCoaSubAccFundAccFundName, coaDetailCoaSubAccTypeAccType, coaDetailCoaSubCoaControlAccName, coaDetailCoaSubCoaMainAccName, chequeBookNo, leafStart, leafEnd, createdBy, createdDate, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.ChequeBooks SelectSingle(int? chequeBookID)
        {
            List<MyCompany.Data.Objects.ChequeBooks> list = Select(chequeBookID, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.ChequeBooks> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("ChequeBooks", dataView, request);
            return page.ToList<MyCompany.Data.Objects.ChequeBooks>();
        }
        
        public List<MyCompany.Data.Objects.ChequeBooks> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.ChequeBooks> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.ChequeBooks SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.ChequeBooks> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.ChequeBooks theChequeBooks, MyCompany.Data.Objects.ChequeBooks original_ChequeBooks)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("ChequeBookID", original_ChequeBooks.ChequeBookID, theChequeBooks.ChequeBookID, true));
            values.Add(new FieldValue("AccFundID", original_ChequeBooks.AccFundID, theChequeBooks.AccFundID));
            values.Add(new FieldValue("AccFundAccFundName", original_ChequeBooks.AccFundAccFundName, theChequeBooks.AccFundAccFundName, true));
            values.Add(new FieldValue("CoaDetailID", original_ChequeBooks.CoaDetailID, theChequeBooks.CoaDetailID));
            values.Add(new FieldValue("CoaDetailAccName", original_ChequeBooks.CoaDetailAccName, theChequeBooks.CoaDetailAccName, true));
            values.Add(new FieldValue("CoaDetailAccBalTypeAccBalType", original_ChequeBooks.CoaDetailAccBalTypeAccBalType, theChequeBooks.CoaDetailAccBalTypeAccBalType, true));
            values.Add(new FieldValue("CoaDetailAccCurrencyAccCurrencyName", original_ChequeBooks.CoaDetailAccCurrencyAccCurrencyName, theChequeBooks.CoaDetailAccCurrencyAccCurrencyName, true));
            values.Add(new FieldValue("CoaDetailAccDestAccDest", original_ChequeBooks.CoaDetailAccDestAccDest, theChequeBooks.CoaDetailAccDestAccDest, true));
            values.Add(new FieldValue("CoaDetailAccDestCompanyTypeDescription", original_ChequeBooks.CoaDetailAccDestCompanyTypeDescription, theChequeBooks.CoaDetailAccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("CoaDetailAccFundAccFundName", original_ChequeBooks.CoaDetailAccFundAccFundName, theChequeBooks.CoaDetailAccFundAccFundName, true));
            values.Add(new FieldValue("CoaDetailAccSubTypeAccSubType", original_ChequeBooks.CoaDetailAccSubTypeAccSubType, theChequeBooks.CoaDetailAccSubTypeAccSubType, true));
            values.Add(new FieldValue("CoaDetailAccTypeAccType", original_ChequeBooks.CoaDetailAccTypeAccType, theChequeBooks.CoaDetailAccTypeAccType, true));
            values.Add(new FieldValue("CoaDetailCoaControlAccName", original_ChequeBooks.CoaDetailCoaControlAccName, theChequeBooks.CoaDetailCoaControlAccName, true));
            values.Add(new FieldValue("CoaDetailCoaControlAccBalTypeAccBalType", original_ChequeBooks.CoaDetailCoaControlAccBalTypeAccBalType, theChequeBooks.CoaDetailCoaControlAccBalTypeAccBalType, true));
            values.Add(new FieldValue("CoaDetailCoaControlAccDestAccDest", original_ChequeBooks.CoaDetailCoaControlAccDestAccDest, theChequeBooks.CoaDetailCoaControlAccDestAccDest, true));
            values.Add(new FieldValue("CoaDetailCoaControlAccTypeAccType", original_ChequeBooks.CoaDetailCoaControlAccTypeAccType, theChequeBooks.CoaDetailCoaControlAccTypeAccType, true));
            values.Add(new FieldValue("CoaDetailCoaControlCompTypeDescription", original_ChequeBooks.CoaDetailCoaControlCompTypeDescription, theChequeBooks.CoaDetailCoaControlCompTypeDescription, true));
            values.Add(new FieldValue("CoaDetailCoaMainAccName", original_ChequeBooks.CoaDetailCoaMainAccName, theChequeBooks.CoaDetailCoaMainAccName, true));
            values.Add(new FieldValue("CoaDetailCoaMainAccBalTypeAccBalType", original_ChequeBooks.CoaDetailCoaMainAccBalTypeAccBalType, theChequeBooks.CoaDetailCoaMainAccBalTypeAccBalType, true));
            values.Add(new FieldValue("CoaDetailCoaMainAccDestAccDest", original_ChequeBooks.CoaDetailCoaMainAccDestAccDest, theChequeBooks.CoaDetailCoaMainAccDestAccDest, true));
            values.Add(new FieldValue("CoaDetailCoaMainAccFundAccFundName", original_ChequeBooks.CoaDetailCoaMainAccFundAccFundName, theChequeBooks.CoaDetailCoaMainAccFundAccFundName, true));
            values.Add(new FieldValue("CoaDetailCoaMainAccTypeAccType", original_ChequeBooks.CoaDetailCoaMainAccTypeAccType, theChequeBooks.CoaDetailCoaMainAccTypeAccType, true));
            values.Add(new FieldValue("CoaDetailCoaMainCoaControlAccName", original_ChequeBooks.CoaDetailCoaMainCoaControlAccName, theChequeBooks.CoaDetailCoaMainCoaControlAccName, true));
            values.Add(new FieldValue("CoaDetailCoaSubAccName", original_ChequeBooks.CoaDetailCoaSubAccName, theChequeBooks.CoaDetailCoaSubAccName, true));
            values.Add(new FieldValue("CoaDetailCoaSubAccBalTypeAccBalType", original_ChequeBooks.CoaDetailCoaSubAccBalTypeAccBalType, theChequeBooks.CoaDetailCoaSubAccBalTypeAccBalType, true));
            values.Add(new FieldValue("CoaDetailCoaSubAccDestAccDest", original_ChequeBooks.CoaDetailCoaSubAccDestAccDest, theChequeBooks.CoaDetailCoaSubAccDestAccDest, true));
            values.Add(new FieldValue("CoaDetailCoaSubAccFundAccFundName", original_ChequeBooks.CoaDetailCoaSubAccFundAccFundName, theChequeBooks.CoaDetailCoaSubAccFundAccFundName, true));
            values.Add(new FieldValue("CoaDetailCoaSubAccTypeAccType", original_ChequeBooks.CoaDetailCoaSubAccTypeAccType, theChequeBooks.CoaDetailCoaSubAccTypeAccType, true));
            values.Add(new FieldValue("CoaDetailCoaSubCoaControlAccName", original_ChequeBooks.CoaDetailCoaSubCoaControlAccName, theChequeBooks.CoaDetailCoaSubCoaControlAccName, true));
            values.Add(new FieldValue("CoaDetailCoaSubCoaMainAccName", original_ChequeBooks.CoaDetailCoaSubCoaMainAccName, theChequeBooks.CoaDetailCoaSubCoaMainAccName, true));
            values.Add(new FieldValue("ChequeBookNo", original_ChequeBooks.ChequeBookNo, theChequeBooks.ChequeBookNo));
            values.Add(new FieldValue("LeafStart", original_ChequeBooks.LeafStart, theChequeBooks.LeafStart));
            values.Add(new FieldValue("LeafEnd", original_ChequeBooks.LeafEnd, theChequeBooks.LeafEnd));
            values.Add(new FieldValue("CreatedBy", original_ChequeBooks.CreatedBy, theChequeBooks.CreatedBy));
            values.Add(new FieldValue("CreatedDate", original_ChequeBooks.CreatedDate, theChequeBooks.CreatedDate));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.ChequeBooks theChequeBooks, MyCompany.Data.Objects.ChequeBooks original_ChequeBooks, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "ChequeBooks";
            args.View = dataView;
            args.Values = CreateFieldValues(theChequeBooks, original_ChequeBooks);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("ChequeBooks", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theChequeBooks);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.ChequeBooks theChequeBooks, MyCompany.Data.Objects.ChequeBooks original_ChequeBooks)
        {
            return ExecuteAction(theChequeBooks, original_ChequeBooks, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.ChequeBooks theChequeBooks)
        {
            return Update(theChequeBooks, SelectSingle(theChequeBooks.ChequeBookID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.ChequeBooks theChequeBooks)
        {
            return ExecuteAction(theChequeBooks, new ChequeBooks(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.ChequeBooks theChequeBooks)
        {
            return ExecuteAction(theChequeBooks, theChequeBooks, "Select", "Delete", DeleteView);
        }
    }
}
