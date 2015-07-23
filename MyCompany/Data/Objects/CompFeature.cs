using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class CompFeature
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _compFeatureID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _compID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _accFundID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _allowMultiCurrency;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _allowBudget;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _allowBudgetControl;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _allowSubsidiaryLed;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _allowMultiGodowns;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _allowProject;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _allowConsLedgerAuto;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nextCodeStart;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isQualityControl;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isOrderControl;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _defaultCurrency;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isSectorYN;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isVoucherPosted;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _chequeHonourControl;
        
        public CompFeature()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? CompFeatureID
        {
            get
            {
                return _compFeatureID;
            }
            set
            {
                _compFeatureID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? CompID
        {
            get
            {
                return _compID;
            }
            set
            {
                _compID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public long? AccFundID
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
        public bool? AllowMultiCurrency
        {
            get
            {
                return _allowMultiCurrency;
            }
            set
            {
                _allowMultiCurrency = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? AllowBudget
        {
            get
            {
                return _allowBudget;
            }
            set
            {
                _allowBudget = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? AllowBudgetControl
        {
            get
            {
                return _allowBudgetControl;
            }
            set
            {
                _allowBudgetControl = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? AllowSubsidiaryLed
        {
            get
            {
                return _allowSubsidiaryLed;
            }
            set
            {
                _allowSubsidiaryLed = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? AllowMultiGodowns
        {
            get
            {
                return _allowMultiGodowns;
            }
            set
            {
                _allowMultiGodowns = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? AllowProject
        {
            get
            {
                return _allowProject;
            }
            set
            {
                _allowProject = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? AllowConsLedgerAuto
        {
            get
            {
                return _allowConsLedgerAuto;
            }
            set
            {
                _allowConsLedgerAuto = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NextCodeStart
        {
            get
            {
                return _nextCodeStart;
            }
            set
            {
                _nextCodeStart = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? IsQualityControl
        {
            get
            {
                return _isQualityControl;
            }
            set
            {
                _isQualityControl = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? IsOrderControl
        {
            get
            {
                return _isOrderControl;
            }
            set
            {
                _isOrderControl = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? DefaultCurrency
        {
            get
            {
                return _defaultCurrency;
            }
            set
            {
                _defaultCurrency = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? IsSectorYN
        {
            get
            {
                return _isSectorYN;
            }
            set
            {
                _isSectorYN = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? IsVoucherPosted
        {
            get
            {
                return _isVoucherPosted;
            }
            set
            {
                _isVoucherPosted = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? ChequeHonourControl
        {
            get
            {
                return _chequeHonourControl;
            }
            set
            {
                _chequeHonourControl = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.CompFeature> Select(
                    int? compFeatureID, 
                    int? compID, 
                    long? accFundID, 
                    bool? allowMultiCurrency, 
                    bool? allowBudget, 
                    bool? allowBudgetControl, 
                    bool? allowSubsidiaryLed, 
                    bool? allowMultiGodowns, 
                    bool? allowProject, 
                    bool? allowConsLedgerAuto, 
                    string nextCodeStart, 
                    bool? isQualityControl, 
                    bool? isOrderControl, 
                    int? defaultCurrency, 
                    bool? isSectorYN, 
                    bool? isVoucherPosted, 
                    bool? chequeHonourControl)
        {
            return new CompFeatureFactory().Select(compFeatureID, compID, accFundID, allowMultiCurrency, allowBudget, allowBudgetControl, allowSubsidiaryLed, allowMultiGodowns, allowProject, allowConsLedgerAuto, nextCodeStart, isQualityControl, isOrderControl, defaultCurrency, isSectorYN, isVoucherPosted, chequeHonourControl);
        }
        
        public static List<MyCompany.Data.Objects.CompFeature> Select(MyCompany.Data.Objects.CompFeature qbe)
        {
            return new CompFeatureFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.CompFeature> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new CompFeatureFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.CompFeature> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new CompFeatureFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.CompFeature> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new CompFeatureFactory().Select(filter, sort, CompFeatureFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.CompFeature> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new CompFeatureFactory().Select(filter, sort, CompFeatureFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.CompFeature> Select(string filter, BusinessObjectParameters parameters)
        {
            return new CompFeatureFactory().Select(filter, null, CompFeatureFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.CompFeature> Select(string filter, params FieldValue[] parameters)
        {
            return new CompFeatureFactory().Select(filter, null, CompFeatureFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.CompFeature SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new CompFeatureFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.CompFeature SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new CompFeatureFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.CompFeature SelectSingle(int? compFeatureID)
        {
            return new CompFeatureFactory().SelectSingle(compFeatureID);
        }
        
        public int Insert()
        {
            return new CompFeatureFactory().Insert(this);
        }
        
        public int Update()
        {
            return new CompFeatureFactory().Update(this);
        }
        
        public int Delete()
        {
            return new CompFeatureFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("CompFeatureID: {0}", this.CompFeatureID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class CompFeatureFactory
    {
        
        public CompFeatureFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("CompFeature");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("CompFeature");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("CompFeature");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("CompFeature");
            }
        }
        
        public static CompFeatureFactory Create()
        {
            return new CompFeatureFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    int? compFeatureID, 
                    int? compID, 
                    long? accFundID, 
                    bool? allowMultiCurrency, 
                    bool? allowBudget, 
                    bool? allowBudgetControl, 
                    bool? allowSubsidiaryLed, 
                    bool? allowMultiGodowns, 
                    bool? allowProject, 
                    bool? allowConsLedgerAuto, 
                    string nextCodeStart, 
                    bool? isQualityControl, 
                    bool? isOrderControl, 
                    int? defaultCurrency, 
                    bool? isSectorYN, 
                    bool? isVoucherPosted, 
                    bool? chequeHonourControl, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (compFeatureID.HasValue)
            	filter.Add(("CompFeatureID:=" + compFeatureID.Value.ToString()));
            if (compID.HasValue)
            	filter.Add(("CompID:=" + compID.Value.ToString()));
            if (accFundID.HasValue)
            	filter.Add(("AccFundID:=" + accFundID.Value.ToString()));
            if (allowMultiCurrency.HasValue)
            	filter.Add(("AllowMultiCurrency:=" + allowMultiCurrency.Value.ToString()));
            if (allowBudget.HasValue)
            	filter.Add(("AllowBudget:=" + allowBudget.Value.ToString()));
            if (allowBudgetControl.HasValue)
            	filter.Add(("AllowBudgetControl:=" + allowBudgetControl.Value.ToString()));
            if (allowSubsidiaryLed.HasValue)
            	filter.Add(("AllowSubsidiaryLed:=" + allowSubsidiaryLed.Value.ToString()));
            if (allowMultiGodowns.HasValue)
            	filter.Add(("AllowMultiGodowns:=" + allowMultiGodowns.Value.ToString()));
            if (allowProject.HasValue)
            	filter.Add(("AllowProject:=" + allowProject.Value.ToString()));
            if (allowConsLedgerAuto.HasValue)
            	filter.Add(("AllowConsLedgerAuto:=" + allowConsLedgerAuto.Value.ToString()));
            if (!(String.IsNullOrEmpty(nextCodeStart)))
            	filter.Add(("NextCodeStart:*" + nextCodeStart));
            if (isQualityControl.HasValue)
            	filter.Add(("IsQualityControl:=" + isQualityControl.Value.ToString()));
            if (isOrderControl.HasValue)
            	filter.Add(("IsOrderControl:=" + isOrderControl.Value.ToString()));
            if (defaultCurrency.HasValue)
            	filter.Add(("DefaultCurrency:=" + defaultCurrency.Value.ToString()));
            if (isSectorYN.HasValue)
            	filter.Add(("IsSectorYN:=" + isSectorYN.Value.ToString()));
            if (isVoucherPosted.HasValue)
            	filter.Add(("IsVoucherPosted:=" + isVoucherPosted.Value.ToString()));
            if (chequeHonourControl.HasValue)
            	filter.Add(("ChequeHonourControl:=" + chequeHonourControl.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.CompFeature> Select(
                    int? compFeatureID, 
                    int? compID, 
                    long? accFundID, 
                    bool? allowMultiCurrency, 
                    bool? allowBudget, 
                    bool? allowBudgetControl, 
                    bool? allowSubsidiaryLed, 
                    bool? allowMultiGodowns, 
                    bool? allowProject, 
                    bool? allowConsLedgerAuto, 
                    string nextCodeStart, 
                    bool? isQualityControl, 
                    bool? isOrderControl, 
                    int? defaultCurrency, 
                    bool? isSectorYN, 
                    bool? isVoucherPosted, 
                    bool? chequeHonourControl, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(compFeatureID, compID, accFundID, allowMultiCurrency, allowBudget, allowBudgetControl, allowSubsidiaryLed, allowMultiGodowns, allowProject, allowConsLedgerAuto, nextCodeStart, isQualityControl, isOrderControl, defaultCurrency, isSectorYN, isVoucherPosted, chequeHonourControl, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("CompFeature", dataView, request);
            return page.ToList<MyCompany.Data.Objects.CompFeature>();
        }
        
        public List<MyCompany.Data.Objects.CompFeature> Select(MyCompany.Data.Objects.CompFeature qbe)
        {
            return Select(qbe.CompFeatureID, qbe.CompID, qbe.AccFundID, qbe.AllowMultiCurrency, qbe.AllowBudget, qbe.AllowBudgetControl, qbe.AllowSubsidiaryLed, qbe.AllowMultiGodowns, qbe.AllowProject, qbe.AllowConsLedgerAuto, qbe.NextCodeStart, qbe.IsQualityControl, qbe.IsOrderControl, qbe.DefaultCurrency, qbe.IsSectorYN, qbe.IsVoucherPosted, qbe.ChequeHonourControl);
        }
        
        public int SelectCount(
                    int? compFeatureID, 
                    int? compID, 
                    long? accFundID, 
                    bool? allowMultiCurrency, 
                    bool? allowBudget, 
                    bool? allowBudgetControl, 
                    bool? allowSubsidiaryLed, 
                    bool? allowMultiGodowns, 
                    bool? allowProject, 
                    bool? allowConsLedgerAuto, 
                    string nextCodeStart, 
                    bool? isQualityControl, 
                    bool? isOrderControl, 
                    int? defaultCurrency, 
                    bool? isSectorYN, 
                    bool? isVoucherPosted, 
                    bool? chequeHonourControl, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(compFeatureID, compID, accFundID, allowMultiCurrency, allowBudget, allowBudgetControl, allowSubsidiaryLed, allowMultiGodowns, allowProject, allowConsLedgerAuto, nextCodeStart, isQualityControl, isOrderControl, defaultCurrency, isSectorYN, isVoucherPosted, chequeHonourControl, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("CompFeature", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.CompFeature> Select(
                    int? compFeatureID, 
                    int? compID, 
                    long? accFundID, 
                    bool? allowMultiCurrency, 
                    bool? allowBudget, 
                    bool? allowBudgetControl, 
                    bool? allowSubsidiaryLed, 
                    bool? allowMultiGodowns, 
                    bool? allowProject, 
                    bool? allowConsLedgerAuto, 
                    string nextCodeStart, 
                    bool? isQualityControl, 
                    bool? isOrderControl, 
                    int? defaultCurrency, 
                    bool? isSectorYN, 
                    bool? isVoucherPosted, 
                    bool? chequeHonourControl)
        {
            return Select(compFeatureID, compID, accFundID, allowMultiCurrency, allowBudget, allowBudgetControl, allowSubsidiaryLed, allowMultiGodowns, allowProject, allowConsLedgerAuto, nextCodeStart, isQualityControl, isOrderControl, defaultCurrency, isSectorYN, isVoucherPosted, chequeHonourControl, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.CompFeature SelectSingle(int? compFeatureID)
        {
            List<MyCompany.Data.Objects.CompFeature> list = Select(compFeatureID, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.CompFeature> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("CompFeature", dataView, request);
            return page.ToList<MyCompany.Data.Objects.CompFeature>();
        }
        
        public List<MyCompany.Data.Objects.CompFeature> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.CompFeature> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.CompFeature SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.CompFeature> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.CompFeature theCompFeature, MyCompany.Data.Objects.CompFeature original_CompFeature)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("CompFeatureID", original_CompFeature.CompFeatureID, theCompFeature.CompFeatureID, true));
            values.Add(new FieldValue("CompID", original_CompFeature.CompID, theCompFeature.CompID));
            values.Add(new FieldValue("AccFundID", original_CompFeature.AccFundID, theCompFeature.AccFundID));
            values.Add(new FieldValue("AllowMultiCurrency", original_CompFeature.AllowMultiCurrency, theCompFeature.AllowMultiCurrency));
            values.Add(new FieldValue("AllowBudget", original_CompFeature.AllowBudget, theCompFeature.AllowBudget));
            values.Add(new FieldValue("AllowBudgetControl", original_CompFeature.AllowBudgetControl, theCompFeature.AllowBudgetControl));
            values.Add(new FieldValue("AllowSubsidiaryLed", original_CompFeature.AllowSubsidiaryLed, theCompFeature.AllowSubsidiaryLed));
            values.Add(new FieldValue("AllowMultiGodowns", original_CompFeature.AllowMultiGodowns, theCompFeature.AllowMultiGodowns));
            values.Add(new FieldValue("AllowProject", original_CompFeature.AllowProject, theCompFeature.AllowProject));
            values.Add(new FieldValue("AllowConsLedgerAuto", original_CompFeature.AllowConsLedgerAuto, theCompFeature.AllowConsLedgerAuto));
            values.Add(new FieldValue("NextCodeStart", original_CompFeature.NextCodeStart, theCompFeature.NextCodeStart));
            values.Add(new FieldValue("IsQualityControl", original_CompFeature.IsQualityControl, theCompFeature.IsQualityControl));
            values.Add(new FieldValue("IsOrderControl", original_CompFeature.IsOrderControl, theCompFeature.IsOrderControl));
            values.Add(new FieldValue("DefaultCurrency", original_CompFeature.DefaultCurrency, theCompFeature.DefaultCurrency));
            values.Add(new FieldValue("IsSectorYN", original_CompFeature.IsSectorYN, theCompFeature.IsSectorYN));
            values.Add(new FieldValue("IsVoucherPosted", original_CompFeature.IsVoucherPosted, theCompFeature.IsVoucherPosted));
            values.Add(new FieldValue("ChequeHonourControl", original_CompFeature.ChequeHonourControl, theCompFeature.ChequeHonourControl));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.CompFeature theCompFeature, MyCompany.Data.Objects.CompFeature original_CompFeature, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "CompFeature";
            args.View = dataView;
            args.Values = CreateFieldValues(theCompFeature, original_CompFeature);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("CompFeature", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theCompFeature);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.CompFeature theCompFeature, MyCompany.Data.Objects.CompFeature original_CompFeature)
        {
            return ExecuteAction(theCompFeature, original_CompFeature, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.CompFeature theCompFeature)
        {
            return Update(theCompFeature, SelectSingle(theCompFeature.CompFeatureID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.CompFeature theCompFeature)
        {
            return ExecuteAction(theCompFeature, new CompFeature(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.CompFeature theCompFeature)
        {
            return ExecuteAction(theCompFeature, theCompFeature, "Select", "Delete", DeleteView);
        }
    }
}
