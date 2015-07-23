using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class ImpresstFundIOU
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _impFundIOUID;
        
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
        private DateTime? _iUODate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _iUOName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _amount;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _transactionType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _paymentMode;
        
        public ImpresstFundIOU()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? ImpFundIOUID
        {
            get
            {
                return _impFundIOUID;
            }
            set
            {
                _impFundIOUID = value;
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
        public DateTime? IUODate
        {
            get
            {
                return _iUODate;
            }
            set
            {
                _iUODate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string IUOName
        {
            get
            {
                return _iUOName;
            }
            set
            {
                _iUOName = value;
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? TransactionType
        {
            get
            {
                return _transactionType;
            }
            set
            {
                _transactionType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? PaymentMode
        {
            get
            {
                return _paymentMode;
            }
            set
            {
                _paymentMode = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.ImpresstFundIOU> Select(
                    int? impFundIOUID, 
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
                    int? accSubTypeID, 
                    string accSubTypeAccSubType, 
                    int? accSubCode, 
                    string accSubAccSubName, 
                    string accSubAccSubTypeAccSubType, 
                    DateTime? iUODate, 
                    string iUOName, 
                    decimal? amount, 
                    int? transactionType, 
                    int? paymentMode)
        {
            return new ImpresstFundIOUFactory().Select(impFundIOUID, impresstFundID, impresstFundReference, impresstFundAccSubAccSubName, impresstFundAccSubAccSubTypeAccSubType, impresstFundAccSubTypeAccSubType, impresstFundCoaDetailAccName, impresstFundCoaDetailAccBalTypeAccBalType, impresstFundCoaDetailAccCurrencyAccCurrencyName, impresstFundCoaDetailAccDestAccDest, impresstFundCoaDetailAccFundAccFundName, impresstFundCoaDetailAccSubTypeAccSubType, impresstFundCoaDetailAccTypeAccType, impresstFundCoaDetailCoaControlAccName, impresstFundCoaDetailCoaMainAccName, impresstFundCoaDetailCoaSubAccName, accSubTypeID, accSubTypeAccSubType, accSubCode, accSubAccSubName, accSubAccSubTypeAccSubType, iUODate, iUOName, amount, transactionType, paymentMode);
        }
        
        public static List<MyCompany.Data.Objects.ImpresstFundIOU> Select(MyCompany.Data.Objects.ImpresstFundIOU qbe)
        {
            return new ImpresstFundIOUFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.ImpresstFundIOU> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new ImpresstFundIOUFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.ImpresstFundIOU> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new ImpresstFundIOUFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.ImpresstFundIOU> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new ImpresstFundIOUFactory().Select(filter, sort, ImpresstFundIOUFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.ImpresstFundIOU> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new ImpresstFundIOUFactory().Select(filter, sort, ImpresstFundIOUFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.ImpresstFundIOU> Select(string filter, BusinessObjectParameters parameters)
        {
            return new ImpresstFundIOUFactory().Select(filter, null, ImpresstFundIOUFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.ImpresstFundIOU> Select(string filter, params FieldValue[] parameters)
        {
            return new ImpresstFundIOUFactory().Select(filter, null, ImpresstFundIOUFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.ImpresstFundIOU SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new ImpresstFundIOUFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.ImpresstFundIOU SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new ImpresstFundIOUFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.ImpresstFundIOU SelectSingle(int? impFundIOUID)
        {
            return new ImpresstFundIOUFactory().SelectSingle(impFundIOUID);
        }
        
        public int Insert()
        {
            return new ImpresstFundIOUFactory().Insert(this);
        }
        
        public int Update()
        {
            return new ImpresstFundIOUFactory().Update(this);
        }
        
        public int Delete()
        {
            return new ImpresstFundIOUFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("ImpFundIOUID: {0}", this.ImpFundIOUID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class ImpresstFundIOUFactory
    {
        
        public ImpresstFundIOUFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("ImpresstFundIOU");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("ImpresstFundIOU");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("ImpresstFundIOU");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("ImpresstFundIOU");
            }
        }
        
        public static ImpresstFundIOUFactory Create()
        {
            return new ImpresstFundIOUFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    int? impFundIOUID, 
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
                    int? accSubTypeID, 
                    string accSubTypeAccSubType, 
                    int? accSubCode, 
                    string accSubAccSubName, 
                    string accSubAccSubTypeAccSubType, 
                    DateTime? iUODate, 
                    string iUOName, 
                    decimal? amount, 
                    int? transactionType, 
                    int? paymentMode, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (impFundIOUID.HasValue)
            	filter.Add(("ImpFundIOUID:=" + impFundIOUID.Value.ToString()));
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
            if (iUODate.HasValue)
            	filter.Add(("IUODate:=" + iUODate.Value.ToString()));
            if (!(String.IsNullOrEmpty(iUOName)))
            	filter.Add(("IUOName:*" + iUOName));
            if (amount.HasValue)
            	filter.Add(("Amount:=" + amount.Value.ToString()));
            if (transactionType.HasValue)
            	filter.Add(("TransactionType:=" + transactionType.Value.ToString()));
            if (paymentMode.HasValue)
            	filter.Add(("PaymentMode:=" + paymentMode.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.ImpresstFundIOU> Select(
                    int? impFundIOUID, 
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
                    int? accSubTypeID, 
                    string accSubTypeAccSubType, 
                    int? accSubCode, 
                    string accSubAccSubName, 
                    string accSubAccSubTypeAccSubType, 
                    DateTime? iUODate, 
                    string iUOName, 
                    decimal? amount, 
                    int? transactionType, 
                    int? paymentMode, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(impFundIOUID, impresstFundID, impresstFundReference, impresstFundAccSubAccSubName, impresstFundAccSubAccSubTypeAccSubType, impresstFundAccSubTypeAccSubType, impresstFundCoaDetailAccName, impresstFundCoaDetailAccBalTypeAccBalType, impresstFundCoaDetailAccCurrencyAccCurrencyName, impresstFundCoaDetailAccDestAccDest, impresstFundCoaDetailAccFundAccFundName, impresstFundCoaDetailAccSubTypeAccSubType, impresstFundCoaDetailAccTypeAccType, impresstFundCoaDetailCoaControlAccName, impresstFundCoaDetailCoaMainAccName, impresstFundCoaDetailCoaSubAccName, accSubTypeID, accSubTypeAccSubType, accSubCode, accSubAccSubName, accSubAccSubTypeAccSubType, iUODate, iUOName, amount, transactionType, paymentMode, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("ImpresstFundIOU", dataView, request);
            return page.ToList<MyCompany.Data.Objects.ImpresstFundIOU>();
        }
        
        public List<MyCompany.Data.Objects.ImpresstFundIOU> Select(MyCompany.Data.Objects.ImpresstFundIOU qbe)
        {
            return Select(qbe.ImpFundIOUID, qbe.ImpresstFundID, qbe.ImpresstFundReference, qbe.ImpresstFundAccSubAccSubName, qbe.ImpresstFundAccSubAccSubTypeAccSubType, qbe.ImpresstFundAccSubTypeAccSubType, qbe.ImpresstFundCoaDetailAccName, qbe.ImpresstFundCoaDetailAccBalTypeAccBalType, qbe.ImpresstFundCoaDetailAccCurrencyAccCurrencyName, qbe.ImpresstFundCoaDetailAccDestAccDest, qbe.ImpresstFundCoaDetailAccFundAccFundName, qbe.ImpresstFundCoaDetailAccSubTypeAccSubType, qbe.ImpresstFundCoaDetailAccTypeAccType, qbe.ImpresstFundCoaDetailCoaControlAccName, qbe.ImpresstFundCoaDetailCoaMainAccName, qbe.ImpresstFundCoaDetailCoaSubAccName, qbe.AccSubTypeID, qbe.AccSubTypeAccSubType, qbe.AccSubCode, qbe.AccSubAccSubName, qbe.AccSubAccSubTypeAccSubType, qbe.IUODate, qbe.IUOName, qbe.Amount, qbe.TransactionType, qbe.PaymentMode);
        }
        
        public int SelectCount(
                    int? impFundIOUID, 
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
                    int? accSubTypeID, 
                    string accSubTypeAccSubType, 
                    int? accSubCode, 
                    string accSubAccSubName, 
                    string accSubAccSubTypeAccSubType, 
                    DateTime? iUODate, 
                    string iUOName, 
                    decimal? amount, 
                    int? transactionType, 
                    int? paymentMode, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(impFundIOUID, impresstFundID, impresstFundReference, impresstFundAccSubAccSubName, impresstFundAccSubAccSubTypeAccSubType, impresstFundAccSubTypeAccSubType, impresstFundCoaDetailAccName, impresstFundCoaDetailAccBalTypeAccBalType, impresstFundCoaDetailAccCurrencyAccCurrencyName, impresstFundCoaDetailAccDestAccDest, impresstFundCoaDetailAccFundAccFundName, impresstFundCoaDetailAccSubTypeAccSubType, impresstFundCoaDetailAccTypeAccType, impresstFundCoaDetailCoaControlAccName, impresstFundCoaDetailCoaMainAccName, impresstFundCoaDetailCoaSubAccName, accSubTypeID, accSubTypeAccSubType, accSubCode, accSubAccSubName, accSubAccSubTypeAccSubType, iUODate, iUOName, amount, transactionType, paymentMode, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("ImpresstFundIOU", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.ImpresstFundIOU> Select(
                    int? impFundIOUID, 
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
                    int? accSubTypeID, 
                    string accSubTypeAccSubType, 
                    int? accSubCode, 
                    string accSubAccSubName, 
                    string accSubAccSubTypeAccSubType, 
                    DateTime? iUODate, 
                    string iUOName, 
                    decimal? amount, 
                    int? transactionType, 
                    int? paymentMode)
        {
            return Select(impFundIOUID, impresstFundID, impresstFundReference, impresstFundAccSubAccSubName, impresstFundAccSubAccSubTypeAccSubType, impresstFundAccSubTypeAccSubType, impresstFundCoaDetailAccName, impresstFundCoaDetailAccBalTypeAccBalType, impresstFundCoaDetailAccCurrencyAccCurrencyName, impresstFundCoaDetailAccDestAccDest, impresstFundCoaDetailAccFundAccFundName, impresstFundCoaDetailAccSubTypeAccSubType, impresstFundCoaDetailAccTypeAccType, impresstFundCoaDetailCoaControlAccName, impresstFundCoaDetailCoaMainAccName, impresstFundCoaDetailCoaSubAccName, accSubTypeID, accSubTypeAccSubType, accSubCode, accSubAccSubName, accSubAccSubTypeAccSubType, iUODate, iUOName, amount, transactionType, paymentMode, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.ImpresstFundIOU SelectSingle(int? impFundIOUID)
        {
            List<MyCompany.Data.Objects.ImpresstFundIOU> list = Select(impFundIOUID, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.ImpresstFundIOU> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("ImpresstFundIOU", dataView, request);
            return page.ToList<MyCompany.Data.Objects.ImpresstFundIOU>();
        }
        
        public List<MyCompany.Data.Objects.ImpresstFundIOU> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.ImpresstFundIOU> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.ImpresstFundIOU SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.ImpresstFundIOU> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.ImpresstFundIOU theImpresstFundIOU, MyCompany.Data.Objects.ImpresstFundIOU original_ImpresstFundIOU)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("ImpFundIOUID", original_ImpresstFundIOU.ImpFundIOUID, theImpresstFundIOU.ImpFundIOUID, true));
            values.Add(new FieldValue("ImpresstFundID", original_ImpresstFundIOU.ImpresstFundID, theImpresstFundIOU.ImpresstFundID));
            values.Add(new FieldValue("ImpresstFundReference", original_ImpresstFundIOU.ImpresstFundReference, theImpresstFundIOU.ImpresstFundReference, true));
            values.Add(new FieldValue("ImpresstFundAccSubAccSubName", original_ImpresstFundIOU.ImpresstFundAccSubAccSubName, theImpresstFundIOU.ImpresstFundAccSubAccSubName, true));
            values.Add(new FieldValue("ImpresstFundAccSubAccSubTypeAccSubType", original_ImpresstFundIOU.ImpresstFundAccSubAccSubTypeAccSubType, theImpresstFundIOU.ImpresstFundAccSubAccSubTypeAccSubType, true));
            values.Add(new FieldValue("ImpresstFundAccSubTypeAccSubType", original_ImpresstFundIOU.ImpresstFundAccSubTypeAccSubType, theImpresstFundIOU.ImpresstFundAccSubTypeAccSubType, true));
            values.Add(new FieldValue("ImpresstFundCoaDetailAccName", original_ImpresstFundIOU.ImpresstFundCoaDetailAccName, theImpresstFundIOU.ImpresstFundCoaDetailAccName, true));
            values.Add(new FieldValue("ImpresstFundCoaDetailAccBalTypeAccBalType", original_ImpresstFundIOU.ImpresstFundCoaDetailAccBalTypeAccBalType, theImpresstFundIOU.ImpresstFundCoaDetailAccBalTypeAccBalType, true));
            values.Add(new FieldValue("ImpresstFundCoaDetailAccCurrencyAccCurrencyName", original_ImpresstFundIOU.ImpresstFundCoaDetailAccCurrencyAccCurrencyName, theImpresstFundIOU.ImpresstFundCoaDetailAccCurrencyAccCurrencyName, true));
            values.Add(new FieldValue("ImpresstFundCoaDetailAccDestAccDest", original_ImpresstFundIOU.ImpresstFundCoaDetailAccDestAccDest, theImpresstFundIOU.ImpresstFundCoaDetailAccDestAccDest, true));
            values.Add(new FieldValue("ImpresstFundCoaDetailAccFundAccFundName", original_ImpresstFundIOU.ImpresstFundCoaDetailAccFundAccFundName, theImpresstFundIOU.ImpresstFundCoaDetailAccFundAccFundName, true));
            values.Add(new FieldValue("ImpresstFundCoaDetailAccSubTypeAccSubType", original_ImpresstFundIOU.ImpresstFundCoaDetailAccSubTypeAccSubType, theImpresstFundIOU.ImpresstFundCoaDetailAccSubTypeAccSubType, true));
            values.Add(new FieldValue("ImpresstFundCoaDetailAccTypeAccType", original_ImpresstFundIOU.ImpresstFundCoaDetailAccTypeAccType, theImpresstFundIOU.ImpresstFundCoaDetailAccTypeAccType, true));
            values.Add(new FieldValue("ImpresstFundCoaDetailCoaControlAccName", original_ImpresstFundIOU.ImpresstFundCoaDetailCoaControlAccName, theImpresstFundIOU.ImpresstFundCoaDetailCoaControlAccName, true));
            values.Add(new FieldValue("ImpresstFundCoaDetailCoaMainAccName", original_ImpresstFundIOU.ImpresstFundCoaDetailCoaMainAccName, theImpresstFundIOU.ImpresstFundCoaDetailCoaMainAccName, true));
            values.Add(new FieldValue("ImpresstFundCoaDetailCoaSubAccName", original_ImpresstFundIOU.ImpresstFundCoaDetailCoaSubAccName, theImpresstFundIOU.ImpresstFundCoaDetailCoaSubAccName, true));
            values.Add(new FieldValue("AccSubTypeID", original_ImpresstFundIOU.AccSubTypeID, theImpresstFundIOU.AccSubTypeID));
            values.Add(new FieldValue("AccSubTypeAccSubType", original_ImpresstFundIOU.AccSubTypeAccSubType, theImpresstFundIOU.AccSubTypeAccSubType, true));
            values.Add(new FieldValue("AccSubCode", original_ImpresstFundIOU.AccSubCode, theImpresstFundIOU.AccSubCode));
            values.Add(new FieldValue("AccSubAccSubName", original_ImpresstFundIOU.AccSubAccSubName, theImpresstFundIOU.AccSubAccSubName, true));
            values.Add(new FieldValue("AccSubAccSubTypeAccSubType", original_ImpresstFundIOU.AccSubAccSubTypeAccSubType, theImpresstFundIOU.AccSubAccSubTypeAccSubType, true));
            values.Add(new FieldValue("IUODate", original_ImpresstFundIOU.IUODate, theImpresstFundIOU.IUODate));
            values.Add(new FieldValue("IUOName", original_ImpresstFundIOU.IUOName, theImpresstFundIOU.IUOName));
            values.Add(new FieldValue("Amount", original_ImpresstFundIOU.Amount, theImpresstFundIOU.Amount));
            values.Add(new FieldValue("TransactionType", original_ImpresstFundIOU.TransactionType, theImpresstFundIOU.TransactionType));
            values.Add(new FieldValue("PaymentMode", original_ImpresstFundIOU.PaymentMode, theImpresstFundIOU.PaymentMode));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.ImpresstFundIOU theImpresstFundIOU, MyCompany.Data.Objects.ImpresstFundIOU original_ImpresstFundIOU, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "ImpresstFundIOU";
            args.View = dataView;
            args.Values = CreateFieldValues(theImpresstFundIOU, original_ImpresstFundIOU);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("ImpresstFundIOU", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theImpresstFundIOU);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.ImpresstFundIOU theImpresstFundIOU, MyCompany.Data.Objects.ImpresstFundIOU original_ImpresstFundIOU)
        {
            return ExecuteAction(theImpresstFundIOU, original_ImpresstFundIOU, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.ImpresstFundIOU theImpresstFundIOU)
        {
            return Update(theImpresstFundIOU, SelectSingle(theImpresstFundIOU.ImpFundIOUID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.ImpresstFundIOU theImpresstFundIOU)
        {
            return ExecuteAction(theImpresstFundIOU, new ImpresstFundIOU(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.ImpresstFundIOU theImpresstFundIOU)
        {
            return ExecuteAction(theImpresstFundIOU, theImpresstFundIOU, "Select", "Delete", DeleteView);
        }
    }
}
