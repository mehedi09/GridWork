using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class ChequeBooksLeaf
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _leafID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _leafNumber;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _chequeBookID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _chequeBookCoaDetailCoaDetailID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _chequeBookChequeBookNo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _chequeBookAccFundAccFundName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _chequeBookCoaDetailAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _chequeBookCoaDetailAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _chequeBookCoaDetailAccCurrencyAccCurrencyName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _chequeBookCoaDetailAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _chequeBookCoaDetailAccFundAccFundName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _chequeBookCoaDetailAccSubTypeAccSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _chequeBookCoaDetailAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _chequeBookCoaDetailCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _chequeBookCoaDetailCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _chequeBookCoaDetailCoaSubAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isUsed;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isHonour;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isVoid;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _chequeHonourDT;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _chequeVoidDT;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _updatedBY;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _updateDT;
        
        public ChequeBooksLeaf()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? LeafID
        {
            get
            {
                return _leafID;
            }
            set
            {
                _leafID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? LeafNumber
        {
            get
            {
                return _leafNumber;
            }
            set
            {
                _leafNumber = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public int? ChequeBookCoaDetailCoaDetailID
        {
            get
            {
                return _chequeBookCoaDetailCoaDetailID;
            }
            set
            {
                _chequeBookCoaDetailCoaDetailID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ChequeBookChequeBookNo
        {
            get
            {
                return _chequeBookChequeBookNo;
            }
            set
            {
                _chequeBookChequeBookNo = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ChequeBookAccFundAccFundName
        {
            get
            {
                return _chequeBookAccFundAccFundName;
            }
            set
            {
                _chequeBookAccFundAccFundName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ChequeBookCoaDetailAccName
        {
            get
            {
                return _chequeBookCoaDetailAccName;
            }
            set
            {
                _chequeBookCoaDetailAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ChequeBookCoaDetailAccBalTypeAccBalType
        {
            get
            {
                return _chequeBookCoaDetailAccBalTypeAccBalType;
            }
            set
            {
                _chequeBookCoaDetailAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ChequeBookCoaDetailAccCurrencyAccCurrencyName
        {
            get
            {
                return _chequeBookCoaDetailAccCurrencyAccCurrencyName;
            }
            set
            {
                _chequeBookCoaDetailAccCurrencyAccCurrencyName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ChequeBookCoaDetailAccDestAccDest
        {
            get
            {
                return _chequeBookCoaDetailAccDestAccDest;
            }
            set
            {
                _chequeBookCoaDetailAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ChequeBookCoaDetailAccFundAccFundName
        {
            get
            {
                return _chequeBookCoaDetailAccFundAccFundName;
            }
            set
            {
                _chequeBookCoaDetailAccFundAccFundName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ChequeBookCoaDetailAccSubTypeAccSubType
        {
            get
            {
                return _chequeBookCoaDetailAccSubTypeAccSubType;
            }
            set
            {
                _chequeBookCoaDetailAccSubTypeAccSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ChequeBookCoaDetailAccTypeAccType
        {
            get
            {
                return _chequeBookCoaDetailAccTypeAccType;
            }
            set
            {
                _chequeBookCoaDetailAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ChequeBookCoaDetailCoaControlAccName
        {
            get
            {
                return _chequeBookCoaDetailCoaControlAccName;
            }
            set
            {
                _chequeBookCoaDetailCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ChequeBookCoaDetailCoaMainAccName
        {
            get
            {
                return _chequeBookCoaDetailCoaMainAccName;
            }
            set
            {
                _chequeBookCoaDetailCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ChequeBookCoaDetailCoaSubAccName
        {
            get
            {
                return _chequeBookCoaDetailCoaSubAccName;
            }
            set
            {
                _chequeBookCoaDetailCoaSubAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? IsUsed
        {
            get
            {
                return _isUsed;
            }
            set
            {
                _isUsed = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? IsHonour
        {
            get
            {
                return _isHonour;
            }
            set
            {
                _isHonour = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? IsVoid
        {
            get
            {
                return _isVoid;
            }
            set
            {
                _isVoid = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? ChequeHonourDT
        {
            get
            {
                return _chequeHonourDT;
            }
            set
            {
                _chequeHonourDT = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? ChequeVoidDT
        {
            get
            {
                return _chequeVoidDT;
            }
            set
            {
                _chequeVoidDT = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string UpdatedBY
        {
            get
            {
                return _updatedBY;
            }
            set
            {
                _updatedBY = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? UpdateDT
        {
            get
            {
                return _updateDT;
            }
            set
            {
                _updateDT = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.ChequeBooksLeaf> Select(
                    int? leafID, 
                    int? leafNumber, 
                    int? chequeBookID, 
                    string chequeBookChequeBookNo, 
                    string chequeBookAccFundAccFundName, 
                    string chequeBookCoaDetailAccName, 
                    string chequeBookCoaDetailAccBalTypeAccBalType, 
                    string chequeBookCoaDetailAccCurrencyAccCurrencyName, 
                    string chequeBookCoaDetailAccDestAccDest, 
                    string chequeBookCoaDetailAccFundAccFundName, 
                    string chequeBookCoaDetailAccSubTypeAccSubType, 
                    string chequeBookCoaDetailAccTypeAccType, 
                    string chequeBookCoaDetailCoaControlAccName, 
                    string chequeBookCoaDetailCoaMainAccName, 
                    string chequeBookCoaDetailCoaSubAccName, 
                    bool? isUsed, 
                    bool? isHonour, 
                    bool? isVoid, 
                    DateTime? chequeHonourDT, 
                    DateTime? chequeVoidDT, 
                    string updatedBY, 
                    DateTime? updateDT)
        {
            return new ChequeBooksLeafFactory().Select(leafID, leafNumber, chequeBookID, chequeBookChequeBookNo, chequeBookAccFundAccFundName, chequeBookCoaDetailAccName, chequeBookCoaDetailAccBalTypeAccBalType, chequeBookCoaDetailAccCurrencyAccCurrencyName, chequeBookCoaDetailAccDestAccDest, chequeBookCoaDetailAccFundAccFundName, chequeBookCoaDetailAccSubTypeAccSubType, chequeBookCoaDetailAccTypeAccType, chequeBookCoaDetailCoaControlAccName, chequeBookCoaDetailCoaMainAccName, chequeBookCoaDetailCoaSubAccName, isUsed, isHonour, isVoid, chequeHonourDT, chequeVoidDT, updatedBY, updateDT);
        }
        
        public static List<MyCompany.Data.Objects.ChequeBooksLeaf> Select(MyCompany.Data.Objects.ChequeBooksLeaf qbe)
        {
            return new ChequeBooksLeafFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.ChequeBooksLeaf> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new ChequeBooksLeafFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.ChequeBooksLeaf> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new ChequeBooksLeafFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.ChequeBooksLeaf> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new ChequeBooksLeafFactory().Select(filter, sort, ChequeBooksLeafFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.ChequeBooksLeaf> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new ChequeBooksLeafFactory().Select(filter, sort, ChequeBooksLeafFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.ChequeBooksLeaf> Select(string filter, BusinessObjectParameters parameters)
        {
            return new ChequeBooksLeafFactory().Select(filter, null, ChequeBooksLeafFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.ChequeBooksLeaf> Select(string filter, params FieldValue[] parameters)
        {
            return new ChequeBooksLeafFactory().Select(filter, null, ChequeBooksLeafFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.ChequeBooksLeaf SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new ChequeBooksLeafFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.ChequeBooksLeaf SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new ChequeBooksLeafFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.ChequeBooksLeaf SelectSingle(int? leafID)
        {
            return new ChequeBooksLeafFactory().SelectSingle(leafID);
        }
        
        public int Insert()
        {
            return new ChequeBooksLeafFactory().Insert(this);
        }
        
        public int Update()
        {
            return new ChequeBooksLeafFactory().Update(this);
        }
        
        public int Delete()
        {
            return new ChequeBooksLeafFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("LeafID: {0}", this.LeafID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class ChequeBooksLeafFactory
    {
        
        public ChequeBooksLeafFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("ChequeBooksLeaf");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("ChequeBooksLeaf");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("ChequeBooksLeaf");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("ChequeBooksLeaf");
            }
        }
        
        public static ChequeBooksLeafFactory Create()
        {
            return new ChequeBooksLeafFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    int? leafID, 
                    int? leafNumber, 
                    int? chequeBookID, 
                    string chequeBookChequeBookNo, 
                    string chequeBookAccFundAccFundName, 
                    string chequeBookCoaDetailAccName, 
                    string chequeBookCoaDetailAccBalTypeAccBalType, 
                    string chequeBookCoaDetailAccCurrencyAccCurrencyName, 
                    string chequeBookCoaDetailAccDestAccDest, 
                    string chequeBookCoaDetailAccFundAccFundName, 
                    string chequeBookCoaDetailAccSubTypeAccSubType, 
                    string chequeBookCoaDetailAccTypeAccType, 
                    string chequeBookCoaDetailCoaControlAccName, 
                    string chequeBookCoaDetailCoaMainAccName, 
                    string chequeBookCoaDetailCoaSubAccName, 
                    bool? isUsed, 
                    bool? isHonour, 
                    bool? isVoid, 
                    DateTime? chequeHonourDT, 
                    DateTime? chequeVoidDT, 
                    string updatedBY, 
                    DateTime? updateDT, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (leafID.HasValue)
            	filter.Add(("LeafID:=" + leafID.Value.ToString()));
            if (leafNumber.HasValue)
            	filter.Add(("LeafNumber:=" + leafNumber.Value.ToString()));
            if (chequeBookID.HasValue)
            	filter.Add(("ChequeBookID:=" + chequeBookID.Value.ToString()));
            if (!(String.IsNullOrEmpty(chequeBookChequeBookNo)))
            	filter.Add(("ChequeBookChequeBookNo:*" + chequeBookChequeBookNo));
            if (!(String.IsNullOrEmpty(chequeBookAccFundAccFundName)))
            	filter.Add(("ChequeBookAccFundAccFundName:*" + chequeBookAccFundAccFundName));
            if (!(String.IsNullOrEmpty(chequeBookCoaDetailAccName)))
            	filter.Add(("ChequeBookCoaDetailAccName:*" + chequeBookCoaDetailAccName));
            if (!(String.IsNullOrEmpty(chequeBookCoaDetailAccBalTypeAccBalType)))
            	filter.Add(("ChequeBookCoaDetailAccBalTypeAccBalType:*" + chequeBookCoaDetailAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(chequeBookCoaDetailAccCurrencyAccCurrencyName)))
            	filter.Add(("ChequeBookCoaDetailAccCurrencyAccCurrencyName:*" + chequeBookCoaDetailAccCurrencyAccCurrencyName));
            if (!(String.IsNullOrEmpty(chequeBookCoaDetailAccDestAccDest)))
            	filter.Add(("ChequeBookCoaDetailAccDestAccDest:*" + chequeBookCoaDetailAccDestAccDest));
            if (!(String.IsNullOrEmpty(chequeBookCoaDetailAccFundAccFundName)))
            	filter.Add(("ChequeBookCoaDetailAccFundAccFundName:*" + chequeBookCoaDetailAccFundAccFundName));
            if (!(String.IsNullOrEmpty(chequeBookCoaDetailAccSubTypeAccSubType)))
            	filter.Add(("ChequeBookCoaDetailAccSubTypeAccSubType:*" + chequeBookCoaDetailAccSubTypeAccSubType));
            if (!(String.IsNullOrEmpty(chequeBookCoaDetailAccTypeAccType)))
            	filter.Add(("ChequeBookCoaDetailAccTypeAccType:*" + chequeBookCoaDetailAccTypeAccType));
            if (!(String.IsNullOrEmpty(chequeBookCoaDetailCoaControlAccName)))
            	filter.Add(("ChequeBookCoaDetailCoaControlAccName:*" + chequeBookCoaDetailCoaControlAccName));
            if (!(String.IsNullOrEmpty(chequeBookCoaDetailCoaMainAccName)))
            	filter.Add(("ChequeBookCoaDetailCoaMainAccName:*" + chequeBookCoaDetailCoaMainAccName));
            if (!(String.IsNullOrEmpty(chequeBookCoaDetailCoaSubAccName)))
            	filter.Add(("ChequeBookCoaDetailCoaSubAccName:*" + chequeBookCoaDetailCoaSubAccName));
            if (isUsed.HasValue)
            	filter.Add(("IsUsed:=" + isUsed.Value.ToString()));
            if (isHonour.HasValue)
            	filter.Add(("IsHonour:=" + isHonour.Value.ToString()));
            if (isVoid.HasValue)
            	filter.Add(("IsVoid:=" + isVoid.Value.ToString()));
            if (chequeHonourDT.HasValue)
            	filter.Add(("ChequeHonourDT:=" + chequeHonourDT.Value.ToString()));
            if (chequeVoidDT.HasValue)
            	filter.Add(("ChequeVoidDT:=" + chequeVoidDT.Value.ToString()));
            if (!(String.IsNullOrEmpty(updatedBY)))
            	filter.Add(("UpdatedBY:*" + updatedBY));
            if (updateDT.HasValue)
            	filter.Add(("UpdateDT:=" + updateDT.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.ChequeBooksLeaf> Select(
                    int? leafID, 
                    int? leafNumber, 
                    int? chequeBookID, 
                    string chequeBookChequeBookNo, 
                    string chequeBookAccFundAccFundName, 
                    string chequeBookCoaDetailAccName, 
                    string chequeBookCoaDetailAccBalTypeAccBalType, 
                    string chequeBookCoaDetailAccCurrencyAccCurrencyName, 
                    string chequeBookCoaDetailAccDestAccDest, 
                    string chequeBookCoaDetailAccFundAccFundName, 
                    string chequeBookCoaDetailAccSubTypeAccSubType, 
                    string chequeBookCoaDetailAccTypeAccType, 
                    string chequeBookCoaDetailCoaControlAccName, 
                    string chequeBookCoaDetailCoaMainAccName, 
                    string chequeBookCoaDetailCoaSubAccName, 
                    bool? isUsed, 
                    bool? isHonour, 
                    bool? isVoid, 
                    DateTime? chequeHonourDT, 
                    DateTime? chequeVoidDT, 
                    string updatedBY, 
                    DateTime? updateDT, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(leafID, leafNumber, chequeBookID, chequeBookChequeBookNo, chequeBookAccFundAccFundName, chequeBookCoaDetailAccName, chequeBookCoaDetailAccBalTypeAccBalType, chequeBookCoaDetailAccCurrencyAccCurrencyName, chequeBookCoaDetailAccDestAccDest, chequeBookCoaDetailAccFundAccFundName, chequeBookCoaDetailAccSubTypeAccSubType, chequeBookCoaDetailAccTypeAccType, chequeBookCoaDetailCoaControlAccName, chequeBookCoaDetailCoaMainAccName, chequeBookCoaDetailCoaSubAccName, isUsed, isHonour, isVoid, chequeHonourDT, chequeVoidDT, updatedBY, updateDT, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("ChequeBooksLeaf", dataView, request);
            return page.ToList<MyCompany.Data.Objects.ChequeBooksLeaf>();
        }
        
        public List<MyCompany.Data.Objects.ChequeBooksLeaf> Select(MyCompany.Data.Objects.ChequeBooksLeaf qbe)
        {
            return Select(qbe.LeafID, qbe.LeafNumber, qbe.ChequeBookID, qbe.ChequeBookChequeBookNo, qbe.ChequeBookAccFundAccFundName, qbe.ChequeBookCoaDetailAccName, qbe.ChequeBookCoaDetailAccBalTypeAccBalType, qbe.ChequeBookCoaDetailAccCurrencyAccCurrencyName, qbe.ChequeBookCoaDetailAccDestAccDest, qbe.ChequeBookCoaDetailAccFundAccFundName, qbe.ChequeBookCoaDetailAccSubTypeAccSubType, qbe.ChequeBookCoaDetailAccTypeAccType, qbe.ChequeBookCoaDetailCoaControlAccName, qbe.ChequeBookCoaDetailCoaMainAccName, qbe.ChequeBookCoaDetailCoaSubAccName, qbe.IsUsed, qbe.IsHonour, qbe.IsVoid, qbe.ChequeHonourDT, qbe.ChequeVoidDT, qbe.UpdatedBY, qbe.UpdateDT);
        }
        
        public int SelectCount(
                    int? leafID, 
                    int? leafNumber, 
                    int? chequeBookID, 
                    string chequeBookChequeBookNo, 
                    string chequeBookAccFundAccFundName, 
                    string chequeBookCoaDetailAccName, 
                    string chequeBookCoaDetailAccBalTypeAccBalType, 
                    string chequeBookCoaDetailAccCurrencyAccCurrencyName, 
                    string chequeBookCoaDetailAccDestAccDest, 
                    string chequeBookCoaDetailAccFundAccFundName, 
                    string chequeBookCoaDetailAccSubTypeAccSubType, 
                    string chequeBookCoaDetailAccTypeAccType, 
                    string chequeBookCoaDetailCoaControlAccName, 
                    string chequeBookCoaDetailCoaMainAccName, 
                    string chequeBookCoaDetailCoaSubAccName, 
                    bool? isUsed, 
                    bool? isHonour, 
                    bool? isVoid, 
                    DateTime? chequeHonourDT, 
                    DateTime? chequeVoidDT, 
                    string updatedBY, 
                    DateTime? updateDT, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(leafID, leafNumber, chequeBookID, chequeBookChequeBookNo, chequeBookAccFundAccFundName, chequeBookCoaDetailAccName, chequeBookCoaDetailAccBalTypeAccBalType, chequeBookCoaDetailAccCurrencyAccCurrencyName, chequeBookCoaDetailAccDestAccDest, chequeBookCoaDetailAccFundAccFundName, chequeBookCoaDetailAccSubTypeAccSubType, chequeBookCoaDetailAccTypeAccType, chequeBookCoaDetailCoaControlAccName, chequeBookCoaDetailCoaMainAccName, chequeBookCoaDetailCoaSubAccName, isUsed, isHonour, isVoid, chequeHonourDT, chequeVoidDT, updatedBY, updateDT, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("ChequeBooksLeaf", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.ChequeBooksLeaf> Select(
                    int? leafID, 
                    int? leafNumber, 
                    int? chequeBookID, 
                    string chequeBookChequeBookNo, 
                    string chequeBookAccFundAccFundName, 
                    string chequeBookCoaDetailAccName, 
                    string chequeBookCoaDetailAccBalTypeAccBalType, 
                    string chequeBookCoaDetailAccCurrencyAccCurrencyName, 
                    string chequeBookCoaDetailAccDestAccDest, 
                    string chequeBookCoaDetailAccFundAccFundName, 
                    string chequeBookCoaDetailAccSubTypeAccSubType, 
                    string chequeBookCoaDetailAccTypeAccType, 
                    string chequeBookCoaDetailCoaControlAccName, 
                    string chequeBookCoaDetailCoaMainAccName, 
                    string chequeBookCoaDetailCoaSubAccName, 
                    bool? isUsed, 
                    bool? isHonour, 
                    bool? isVoid, 
                    DateTime? chequeHonourDT, 
                    DateTime? chequeVoidDT, 
                    string updatedBY, 
                    DateTime? updateDT)
        {
            return Select(leafID, leafNumber, chequeBookID, chequeBookChequeBookNo, chequeBookAccFundAccFundName, chequeBookCoaDetailAccName, chequeBookCoaDetailAccBalTypeAccBalType, chequeBookCoaDetailAccCurrencyAccCurrencyName, chequeBookCoaDetailAccDestAccDest, chequeBookCoaDetailAccFundAccFundName, chequeBookCoaDetailAccSubTypeAccSubType, chequeBookCoaDetailAccTypeAccType, chequeBookCoaDetailCoaControlAccName, chequeBookCoaDetailCoaMainAccName, chequeBookCoaDetailCoaSubAccName, isUsed, isHonour, isVoid, chequeHonourDT, chequeVoidDT, updatedBY, updateDT, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.ChequeBooksLeaf SelectSingle(int? leafID)
        {
            List<MyCompany.Data.Objects.ChequeBooksLeaf> list = Select(leafID, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.ChequeBooksLeaf> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("ChequeBooksLeaf", dataView, request);
            return page.ToList<MyCompany.Data.Objects.ChequeBooksLeaf>();
        }
        
        public List<MyCompany.Data.Objects.ChequeBooksLeaf> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.ChequeBooksLeaf> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.ChequeBooksLeaf SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.ChequeBooksLeaf> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.ChequeBooksLeaf theChequeBooksLeaf, MyCompany.Data.Objects.ChequeBooksLeaf original_ChequeBooksLeaf)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("LeafID", original_ChequeBooksLeaf.LeafID, theChequeBooksLeaf.LeafID, true));
            values.Add(new FieldValue("LeafNumber", original_ChequeBooksLeaf.LeafNumber, theChequeBooksLeaf.LeafNumber));
            values.Add(new FieldValue("ChequeBookID", original_ChequeBooksLeaf.ChequeBookID, theChequeBooksLeaf.ChequeBookID));
            values.Add(new FieldValue("ChequeBookCoaDetailCoaDetailID", original_ChequeBooksLeaf.ChequeBookCoaDetailCoaDetailID, theChequeBooksLeaf.ChequeBookCoaDetailCoaDetailID));
            values.Add(new FieldValue("ChequeBookChequeBookNo", original_ChequeBooksLeaf.ChequeBookChequeBookNo, theChequeBooksLeaf.ChequeBookChequeBookNo, true));
            values.Add(new FieldValue("ChequeBookAccFundAccFundName", original_ChequeBooksLeaf.ChequeBookAccFundAccFundName, theChequeBooksLeaf.ChequeBookAccFundAccFundName, true));
            values.Add(new FieldValue("ChequeBookCoaDetailAccName", original_ChequeBooksLeaf.ChequeBookCoaDetailAccName, theChequeBooksLeaf.ChequeBookCoaDetailAccName, true));
            values.Add(new FieldValue("ChequeBookCoaDetailAccBalTypeAccBalType", original_ChequeBooksLeaf.ChequeBookCoaDetailAccBalTypeAccBalType, theChequeBooksLeaf.ChequeBookCoaDetailAccBalTypeAccBalType, true));
            values.Add(new FieldValue("ChequeBookCoaDetailAccCurrencyAccCurrencyName", original_ChequeBooksLeaf.ChequeBookCoaDetailAccCurrencyAccCurrencyName, theChequeBooksLeaf.ChequeBookCoaDetailAccCurrencyAccCurrencyName, true));
            values.Add(new FieldValue("ChequeBookCoaDetailAccDestAccDest", original_ChequeBooksLeaf.ChequeBookCoaDetailAccDestAccDest, theChequeBooksLeaf.ChequeBookCoaDetailAccDestAccDest, true));
            values.Add(new FieldValue("ChequeBookCoaDetailAccFundAccFundName", original_ChequeBooksLeaf.ChequeBookCoaDetailAccFundAccFundName, theChequeBooksLeaf.ChequeBookCoaDetailAccFundAccFundName, true));
            values.Add(new FieldValue("ChequeBookCoaDetailAccSubTypeAccSubType", original_ChequeBooksLeaf.ChequeBookCoaDetailAccSubTypeAccSubType, theChequeBooksLeaf.ChequeBookCoaDetailAccSubTypeAccSubType, true));
            values.Add(new FieldValue("ChequeBookCoaDetailAccTypeAccType", original_ChequeBooksLeaf.ChequeBookCoaDetailAccTypeAccType, theChequeBooksLeaf.ChequeBookCoaDetailAccTypeAccType, true));
            values.Add(new FieldValue("ChequeBookCoaDetailCoaControlAccName", original_ChequeBooksLeaf.ChequeBookCoaDetailCoaControlAccName, theChequeBooksLeaf.ChequeBookCoaDetailCoaControlAccName, true));
            values.Add(new FieldValue("ChequeBookCoaDetailCoaMainAccName", original_ChequeBooksLeaf.ChequeBookCoaDetailCoaMainAccName, theChequeBooksLeaf.ChequeBookCoaDetailCoaMainAccName, true));
            values.Add(new FieldValue("ChequeBookCoaDetailCoaSubAccName", original_ChequeBooksLeaf.ChequeBookCoaDetailCoaSubAccName, theChequeBooksLeaf.ChequeBookCoaDetailCoaSubAccName, true));
            values.Add(new FieldValue("IsUsed", original_ChequeBooksLeaf.IsUsed, theChequeBooksLeaf.IsUsed));
            values.Add(new FieldValue("IsHonour", original_ChequeBooksLeaf.IsHonour, theChequeBooksLeaf.IsHonour));
            values.Add(new FieldValue("IsVoid", original_ChequeBooksLeaf.IsVoid, theChequeBooksLeaf.IsVoid));
            values.Add(new FieldValue("ChequeHonourDT", original_ChequeBooksLeaf.ChequeHonourDT, theChequeBooksLeaf.ChequeHonourDT));
            values.Add(new FieldValue("ChequeVoidDT", original_ChequeBooksLeaf.ChequeVoidDT, theChequeBooksLeaf.ChequeVoidDT));
            values.Add(new FieldValue("UpdatedBY", original_ChequeBooksLeaf.UpdatedBY, theChequeBooksLeaf.UpdatedBY));
            values.Add(new FieldValue("UpdateDT", original_ChequeBooksLeaf.UpdateDT, theChequeBooksLeaf.UpdateDT));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.ChequeBooksLeaf theChequeBooksLeaf, MyCompany.Data.Objects.ChequeBooksLeaf original_ChequeBooksLeaf, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "ChequeBooksLeaf";
            args.View = dataView;
            args.Values = CreateFieldValues(theChequeBooksLeaf, original_ChequeBooksLeaf);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("ChequeBooksLeaf", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theChequeBooksLeaf);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.ChequeBooksLeaf theChequeBooksLeaf, MyCompany.Data.Objects.ChequeBooksLeaf original_ChequeBooksLeaf)
        {
            return ExecuteAction(theChequeBooksLeaf, original_ChequeBooksLeaf, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.ChequeBooksLeaf theChequeBooksLeaf)
        {
            return Update(theChequeBooksLeaf, SelectSingle(theChequeBooksLeaf.LeafID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.ChequeBooksLeaf theChequeBooksLeaf)
        {
            return ExecuteAction(theChequeBooksLeaf, new ChequeBooksLeaf(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.ChequeBooksLeaf theChequeBooksLeaf)
        {
            return ExecuteAction(theChequeBooksLeaf, theChequeBooksLeaf, "Select", "Delete", DeleteView);
        }
    }
}
