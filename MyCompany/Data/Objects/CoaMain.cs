using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class CoaMain
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _coaMainID;
        
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
        private string _accTypeAccTypeName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accDestID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accDestAccDestName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accDestCompanyTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accBalTypeID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accBalTypeAccBalTypeName;
        
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
        private int? _coaMainParentID;
        
        public CoaMain()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
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
        public string AccTypeAccTypeName
        {
            get
            {
                return _accTypeAccTypeName;
            }
            set
            {
                _accTypeAccTypeName = value;
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
        public string AccDestAccDestName
        {
            get
            {
                return _accDestAccDestName;
            }
            set
            {
                _accDestAccDestName = value;
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
        public string AccBalTypeAccBalTypeName
        {
            get
            {
                return _accBalTypeAccBalTypeName;
            }
            set
            {
                _accBalTypeAccBalTypeName = value;
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? CoaMainParentID
        {
            get
            {
                return _coaMainParentID;
            }
            set
            {
                _coaMainParentID = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.CoaMain> Select(
                    int? coaMainID, 
                    int? accFundID, 
                    string accFundAccFundName, 
                    string accFundCode, 
                    string acccode, 
                    string accName, 
                    string accDesc, 
                    int? accTypeID, 
                    string accTypeAccTypeName, 
                    int? accDestID, 
                    string accDestAccDestName, 
                    string accDestCompanyTypeDescription, 
                    int? accBalTypeID, 
                    string accBalTypeAccBalTypeName, 
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
                    int? coaMainParentID)
        {
            return new CoaMainFactory().Select(coaMainID, accFundID, accFundAccFundName, accFundCode, acccode, accName, accDesc, accTypeID, accTypeAccTypeName, accDestID, accDestAccDestName, accDestCompanyTypeDescription, accBalTypeID, accBalTypeAccBalTypeName, accCurrency, accCurrencyRate, consTranCode, coaControlID, coaControlAccName, coaControlAccBalTypeAccBalType, coaControlAccDestAccDest, coaControlAccDestCompanyTypeDescription, coaControlAccTypeAccType, coaControlCompTypeDescription, coaMainParentID);
        }
        
        public static List<MyCompany.Data.Objects.CoaMain> Select(MyCompany.Data.Objects.CoaMain qbe)
        {
            return new CoaMainFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.CoaMain> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new CoaMainFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.CoaMain> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new CoaMainFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.CoaMain> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new CoaMainFactory().Select(filter, sort, CoaMainFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.CoaMain> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new CoaMainFactory().Select(filter, sort, CoaMainFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.CoaMain> Select(string filter, BusinessObjectParameters parameters)
        {
            return new CoaMainFactory().Select(filter, null, CoaMainFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.CoaMain> Select(string filter, params FieldValue[] parameters)
        {
            return new CoaMainFactory().Select(filter, null, CoaMainFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.CoaMain SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new CoaMainFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.CoaMain SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new CoaMainFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.CoaMain SelectSingle(int? coaMainID)
        {
            return new CoaMainFactory().SelectSingle(coaMainID);
        }
        
        public int Insert()
        {
            return new CoaMainFactory().Insert(this);
        }
        
        public int Update()
        {
            return new CoaMainFactory().Update(this);
        }
        
        public int Delete()
        {
            return new CoaMainFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("CoaMainID: {0}", this.CoaMainID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class CoaMainFactory
    {
        
        public CoaMainFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("CoaMain");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("CoaMain");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("CoaMain");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("CoaMain");
            }
        }
        
        public static CoaMainFactory Create()
        {
            return new CoaMainFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    int? coaMainID, 
                    int? accFundID, 
                    string accFundAccFundName, 
                    string accFundCode, 
                    string acccode, 
                    string accName, 
                    string accDesc, 
                    int? accTypeID, 
                    string accTypeAccTypeName, 
                    int? accDestID, 
                    string accDestAccDestName, 
                    string accDestCompanyTypeDescription, 
                    int? accBalTypeID, 
                    string accBalTypeAccBalTypeName, 
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
                    int? coaMainParentID, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (coaMainID.HasValue)
            	filter.Add(("CoaMainID:=" + coaMainID.Value.ToString()));
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
            if (!(String.IsNullOrEmpty(accTypeAccTypeName)))
            	filter.Add(("AccTypeAccTypeName:*" + accTypeAccTypeName));
            if (accDestID.HasValue)
            	filter.Add(("AccDestID:=" + accDestID.Value.ToString()));
            if (!(String.IsNullOrEmpty(accDestAccDestName)))
            	filter.Add(("AccDestAccDestName:*" + accDestAccDestName));
            if (!(String.IsNullOrEmpty(accDestCompanyTypeDescription)))
            	filter.Add(("AccDestCompanyTypeDescription:*" + accDestCompanyTypeDescription));
            if (accBalTypeID.HasValue)
            	filter.Add(("AccBalTypeID:=" + accBalTypeID.Value.ToString()));
            if (!(String.IsNullOrEmpty(accBalTypeAccBalTypeName)))
            	filter.Add(("AccBalTypeAccBalTypeName:*" + accBalTypeAccBalTypeName));
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
            if (coaMainParentID.HasValue)
            	filter.Add(("CoaMainParentID:=" + coaMainParentID.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.CoaMain> Select(
                    int? coaMainID, 
                    int? accFundID, 
                    string accFundAccFundName, 
                    string accFundCode, 
                    string acccode, 
                    string accName, 
                    string accDesc, 
                    int? accTypeID, 
                    string accTypeAccTypeName, 
                    int? accDestID, 
                    string accDestAccDestName, 
                    string accDestCompanyTypeDescription, 
                    int? accBalTypeID, 
                    string accBalTypeAccBalTypeName, 
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
                    int? coaMainParentID, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(coaMainID, accFundID, accFundAccFundName, accFundCode, acccode, accName, accDesc, accTypeID, accTypeAccTypeName, accDestID, accDestAccDestName, accDestCompanyTypeDescription, accBalTypeID, accBalTypeAccBalTypeName, accCurrency, accCurrencyRate, consTranCode, coaControlID, coaControlAccName, coaControlAccBalTypeAccBalType, coaControlAccDestAccDest, coaControlAccDestCompanyTypeDescription, coaControlAccTypeAccType, coaControlCompTypeDescription, coaMainParentID, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("CoaMain", dataView, request);
            return page.ToList<MyCompany.Data.Objects.CoaMain>();
        }
        
        public List<MyCompany.Data.Objects.CoaMain> Select(MyCompany.Data.Objects.CoaMain qbe)
        {
            return Select(qbe.CoaMainID, qbe.AccFundID, qbe.AccFundAccFundName, qbe.AccFundCode, qbe.Acccode, qbe.AccName, qbe.AccDesc, qbe.AccTypeID, qbe.AccTypeAccTypeName, qbe.AccDestID, qbe.AccDestAccDestName, qbe.AccDestCompanyTypeDescription, qbe.AccBalTypeID, qbe.AccBalTypeAccBalTypeName, qbe.AccCurrency, qbe.AccCurrencyRate, qbe.ConsTranCode, qbe.CoaControlID, qbe.CoaControlAccName, qbe.CoaControlAccBalTypeAccBalType, qbe.CoaControlAccDestAccDest, qbe.CoaControlAccDestCompanyTypeDescription, qbe.CoaControlAccTypeAccType, qbe.CoaControlCompTypeDescription, qbe.CoaMainParentID);
        }
        
        public int SelectCount(
                    int? coaMainID, 
                    int? accFundID, 
                    string accFundAccFundName, 
                    string accFundCode, 
                    string acccode, 
                    string accName, 
                    string accDesc, 
                    int? accTypeID, 
                    string accTypeAccTypeName, 
                    int? accDestID, 
                    string accDestAccDestName, 
                    string accDestCompanyTypeDescription, 
                    int? accBalTypeID, 
                    string accBalTypeAccBalTypeName, 
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
                    int? coaMainParentID, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(coaMainID, accFundID, accFundAccFundName, accFundCode, acccode, accName, accDesc, accTypeID, accTypeAccTypeName, accDestID, accDestAccDestName, accDestCompanyTypeDescription, accBalTypeID, accBalTypeAccBalTypeName, accCurrency, accCurrencyRate, consTranCode, coaControlID, coaControlAccName, coaControlAccBalTypeAccBalType, coaControlAccDestAccDest, coaControlAccDestCompanyTypeDescription, coaControlAccTypeAccType, coaControlCompTypeDescription, coaMainParentID, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("CoaMain", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.CoaMain> Select(
                    int? coaMainID, 
                    int? accFundID, 
                    string accFundAccFundName, 
                    string accFundCode, 
                    string acccode, 
                    string accName, 
                    string accDesc, 
                    int? accTypeID, 
                    string accTypeAccTypeName, 
                    int? accDestID, 
                    string accDestAccDestName, 
                    string accDestCompanyTypeDescription, 
                    int? accBalTypeID, 
                    string accBalTypeAccBalTypeName, 
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
                    int? coaMainParentID)
        {
            return Select(coaMainID, accFundID, accFundAccFundName, accFundCode, acccode, accName, accDesc, accTypeID, accTypeAccTypeName, accDestID, accDestAccDestName, accDestCompanyTypeDescription, accBalTypeID, accBalTypeAccBalTypeName, accCurrency, accCurrencyRate, consTranCode, coaControlID, coaControlAccName, coaControlAccBalTypeAccBalType, coaControlAccDestAccDest, coaControlAccDestCompanyTypeDescription, coaControlAccTypeAccType, coaControlCompTypeDescription, coaMainParentID, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.CoaMain SelectSingle(int? coaMainID)
        {
            List<MyCompany.Data.Objects.CoaMain> list = Select(coaMainID, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.CoaMain> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("CoaMain", dataView, request);
            return page.ToList<MyCompany.Data.Objects.CoaMain>();
        }
        
        public List<MyCompany.Data.Objects.CoaMain> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.CoaMain> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.CoaMain SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.CoaMain> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.CoaMain theCoaMain, MyCompany.Data.Objects.CoaMain original_CoaMain)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("CoaMainID", original_CoaMain.CoaMainID, theCoaMain.CoaMainID, true));
            values.Add(new FieldValue("AccFundID", original_CoaMain.AccFundID, theCoaMain.AccFundID));
            values.Add(new FieldValue("AccFundAccFundName", original_CoaMain.AccFundAccFundName, theCoaMain.AccFundAccFundName, true));
            values.Add(new FieldValue("AccFundCode", original_CoaMain.AccFundCode, theCoaMain.AccFundCode));
            values.Add(new FieldValue("Acccode", original_CoaMain.Acccode, theCoaMain.Acccode));
            values.Add(new FieldValue("AccName", original_CoaMain.AccName, theCoaMain.AccName));
            values.Add(new FieldValue("AccDesc", original_CoaMain.AccDesc, theCoaMain.AccDesc));
            values.Add(new FieldValue("AccTypeID", original_CoaMain.AccTypeID, theCoaMain.AccTypeID));
            values.Add(new FieldValue("AccTypeAccTypeName", original_CoaMain.AccTypeAccTypeName, theCoaMain.AccTypeAccTypeName, true));
            values.Add(new FieldValue("AccDestID", original_CoaMain.AccDestID, theCoaMain.AccDestID));
            values.Add(new FieldValue("AccDestAccDestName", original_CoaMain.AccDestAccDestName, theCoaMain.AccDestAccDestName, true));
            values.Add(new FieldValue("AccDestCompanyTypeDescription", original_CoaMain.AccDestCompanyTypeDescription, theCoaMain.AccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("AccBalTypeID", original_CoaMain.AccBalTypeID, theCoaMain.AccBalTypeID));
            values.Add(new FieldValue("AccBalTypeAccBalTypeName", original_CoaMain.AccBalTypeAccBalTypeName, theCoaMain.AccBalTypeAccBalTypeName, true));
            values.Add(new FieldValue("AccCurrency", original_CoaMain.AccCurrency, theCoaMain.AccCurrency));
            values.Add(new FieldValue("AccCurrencyRate", original_CoaMain.AccCurrencyRate, theCoaMain.AccCurrencyRate));
            values.Add(new FieldValue("ConsTranCode", original_CoaMain.ConsTranCode, theCoaMain.ConsTranCode));
            values.Add(new FieldValue("CoaControlID", original_CoaMain.CoaControlID, theCoaMain.CoaControlID));
            values.Add(new FieldValue("CoaControlAccName", original_CoaMain.CoaControlAccName, theCoaMain.CoaControlAccName, true));
            values.Add(new FieldValue("CoaControlAccBalTypeAccBalType", original_CoaMain.CoaControlAccBalTypeAccBalType, theCoaMain.CoaControlAccBalTypeAccBalType, true));
            values.Add(new FieldValue("CoaControlAccDestAccDest", original_CoaMain.CoaControlAccDestAccDest, theCoaMain.CoaControlAccDestAccDest, true));
            values.Add(new FieldValue("CoaControlAccDestCompanyTypeDescription", original_CoaMain.CoaControlAccDestCompanyTypeDescription, theCoaMain.CoaControlAccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("CoaControlAccTypeAccType", original_CoaMain.CoaControlAccTypeAccType, theCoaMain.CoaControlAccTypeAccType, true));
            values.Add(new FieldValue("CoaControlCompTypeDescription", original_CoaMain.CoaControlCompTypeDescription, theCoaMain.CoaControlCompTypeDescription, true));
            values.Add(new FieldValue("CoaMainParentID", original_CoaMain.CoaMainParentID, theCoaMain.CoaMainParentID));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.CoaMain theCoaMain, MyCompany.Data.Objects.CoaMain original_CoaMain, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "CoaMain";
            args.View = dataView;
            args.Values = CreateFieldValues(theCoaMain, original_CoaMain);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("CoaMain", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theCoaMain);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.CoaMain theCoaMain, MyCompany.Data.Objects.CoaMain original_CoaMain)
        {
            return ExecuteAction(theCoaMain, original_CoaMain, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.CoaMain theCoaMain)
        {
            return Update(theCoaMain, SelectSingle(theCoaMain.CoaMainID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.CoaMain theCoaMain)
        {
            return ExecuteAction(theCoaMain, new CoaMain(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.CoaMain theCoaMain)
        {
            return ExecuteAction(theCoaMain, theCoaMain, "Select", "Delete", DeleteView);
        }
    }
}
