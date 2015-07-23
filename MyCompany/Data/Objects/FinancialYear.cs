using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class FinancialYear
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _financialYearID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accFundAccFundName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _startDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _endDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _fiscalYear;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _qtr1;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _qtr2;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _qtr3;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _qtr4;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _activateYear;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private byte? _activeQtr;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _yearIsClosed;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _yearCloseControl;
        
        public FinancialYear()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? FinancialYearID
        {
            get
            {
                return _financialYearID;
            }
            set
            {
                _financialYearID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? AccFundCode
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
        public DateTime? StartDate
        {
            get
            {
                return _startDate;
            }
            set
            {
                _startDate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public DateTime? EndDate
        {
            get
            {
                return _endDate;
            }
            set
            {
                _endDate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string FiscalYear
        {
            get
            {
                return _fiscalYear;
            }
            set
            {
                _fiscalYear = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? Qtr1
        {
            get
            {
                return _qtr1;
            }
            set
            {
                _qtr1 = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? Qtr2
        {
            get
            {
                return _qtr2;
            }
            set
            {
                _qtr2 = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? Qtr3
        {
            get
            {
                return _qtr3;
            }
            set
            {
                _qtr3 = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? Qtr4
        {
            get
            {
                return _qtr4;
            }
            set
            {
                _qtr4 = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public bool? ActivateYear
        {
            get
            {
                return _activateYear;
            }
            set
            {
                _activateYear = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public byte? ActiveQtr
        {
            get
            {
                return _activeQtr;
            }
            set
            {
                _activeQtr = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? YearIsClosed
        {
            get
            {
                return _yearIsClosed;
            }
            set
            {
                _yearIsClosed = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? YearCloseControl
        {
            get
            {
                return _yearCloseControl;
            }
            set
            {
                _yearCloseControl = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.FinancialYear> Select(int? financialYearID, int? accFundCode, string accFundAccFundName, DateTime? startDate, DateTime? endDate, string fiscalYear, DateTime? qtr1, DateTime? qtr2, DateTime? qtr3, DateTime? qtr4, bool? activateYear, byte? activeQtr, bool? yearIsClosed, bool? yearCloseControl)
        {
            return new FinancialYearFactory().Select(financialYearID, accFundCode, accFundAccFundName, startDate, endDate, fiscalYear, qtr1, qtr2, qtr3, qtr4, activateYear, activeQtr, yearIsClosed, yearCloseControl);
        }
        
        public static List<MyCompany.Data.Objects.FinancialYear> Select(MyCompany.Data.Objects.FinancialYear qbe)
        {
            return new FinancialYearFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.FinancialYear> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new FinancialYearFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.FinancialYear> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new FinancialYearFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.FinancialYear> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new FinancialYearFactory().Select(filter, sort, FinancialYearFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.FinancialYear> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new FinancialYearFactory().Select(filter, sort, FinancialYearFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.FinancialYear> Select(string filter, BusinessObjectParameters parameters)
        {
            return new FinancialYearFactory().Select(filter, null, FinancialYearFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.FinancialYear> Select(string filter, params FieldValue[] parameters)
        {
            return new FinancialYearFactory().Select(filter, null, FinancialYearFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.FinancialYear SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new FinancialYearFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.FinancialYear SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new FinancialYearFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.FinancialYear SelectSingle(int? financialYearID)
        {
            return new FinancialYearFactory().SelectSingle(financialYearID);
        }
        
        public int Insert()
        {
            return new FinancialYearFactory().Insert(this);
        }
        
        public int Update()
        {
            return new FinancialYearFactory().Update(this);
        }
        
        public int Delete()
        {
            return new FinancialYearFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("FinancialYearID: {0}", this.FinancialYearID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class FinancialYearFactory
    {
        
        public FinancialYearFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("FinancialYear");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("FinancialYear");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("FinancialYear");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("FinancialYear");
            }
        }
        
        public static FinancialYearFactory Create()
        {
            return new FinancialYearFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    int? financialYearID, 
                    int? accFundCode, 
                    string accFundAccFundName, 
                    DateTime? startDate, 
                    DateTime? endDate, 
                    string fiscalYear, 
                    DateTime? qtr1, 
                    DateTime? qtr2, 
                    DateTime? qtr3, 
                    DateTime? qtr4, 
                    bool? activateYear, 
                    byte? activeQtr, 
                    bool? yearIsClosed, 
                    bool? yearCloseControl, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (financialYearID.HasValue)
            	filter.Add(("FinancialYearID:=" + financialYearID.Value.ToString()));
            if (accFundCode.HasValue)
            	filter.Add(("AccFundCode:=" + accFundCode.Value.ToString()));
            if (!(String.IsNullOrEmpty(accFundAccFundName)))
            	filter.Add(("AccFundAccFundName:*" + accFundAccFundName));
            if (startDate.HasValue)
            	filter.Add(("StartDate:=" + startDate.Value.ToString()));
            if (endDate.HasValue)
            	filter.Add(("EndDate:=" + endDate.Value.ToString()));
            if (!(String.IsNullOrEmpty(fiscalYear)))
            	filter.Add(("FiscalYear:*" + fiscalYear));
            if (qtr1.HasValue)
            	filter.Add(("Qtr1:=" + qtr1.Value.ToString()));
            if (qtr2.HasValue)
            	filter.Add(("Qtr2:=" + qtr2.Value.ToString()));
            if (qtr3.HasValue)
            	filter.Add(("Qtr3:=" + qtr3.Value.ToString()));
            if (qtr4.HasValue)
            	filter.Add(("Qtr4:=" + qtr4.Value.ToString()));
            if (activateYear.HasValue)
            	filter.Add(("ActivateYear:=" + activateYear.Value.ToString()));
            if (activeQtr.HasValue)
            	filter.Add(("ActiveQtr:=" + activeQtr.Value.ToString()));
            if (yearIsClosed.HasValue)
            	filter.Add(("YearIsClosed:=" + yearIsClosed.Value.ToString()));
            if (yearCloseControl.HasValue)
            	filter.Add(("YearCloseControl:=" + yearCloseControl.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.FinancialYear> Select(
                    int? financialYearID, 
                    int? accFundCode, 
                    string accFundAccFundName, 
                    DateTime? startDate, 
                    DateTime? endDate, 
                    string fiscalYear, 
                    DateTime? qtr1, 
                    DateTime? qtr2, 
                    DateTime? qtr3, 
                    DateTime? qtr4, 
                    bool? activateYear, 
                    byte? activeQtr, 
                    bool? yearIsClosed, 
                    bool? yearCloseControl, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(financialYearID, accFundCode, accFundAccFundName, startDate, endDate, fiscalYear, qtr1, qtr2, qtr3, qtr4, activateYear, activeQtr, yearIsClosed, yearCloseControl, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("FinancialYear", dataView, request);
            return page.ToList<MyCompany.Data.Objects.FinancialYear>();
        }
        
        public List<MyCompany.Data.Objects.FinancialYear> Select(MyCompany.Data.Objects.FinancialYear qbe)
        {
            return Select(qbe.FinancialYearID, qbe.AccFundCode, qbe.AccFundAccFundName, qbe.StartDate, qbe.EndDate, qbe.FiscalYear, qbe.Qtr1, qbe.Qtr2, qbe.Qtr3, qbe.Qtr4, qbe.ActivateYear, qbe.ActiveQtr, qbe.YearIsClosed, qbe.YearCloseControl);
        }
        
        public int SelectCount(
                    int? financialYearID, 
                    int? accFundCode, 
                    string accFundAccFundName, 
                    DateTime? startDate, 
                    DateTime? endDate, 
                    string fiscalYear, 
                    DateTime? qtr1, 
                    DateTime? qtr2, 
                    DateTime? qtr3, 
                    DateTime? qtr4, 
                    bool? activateYear, 
                    byte? activeQtr, 
                    bool? yearIsClosed, 
                    bool? yearCloseControl, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(financialYearID, accFundCode, accFundAccFundName, startDate, endDate, fiscalYear, qtr1, qtr2, qtr3, qtr4, activateYear, activeQtr, yearIsClosed, yearCloseControl, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("FinancialYear", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.FinancialYear> Select(int? financialYearID, int? accFundCode, string accFundAccFundName, DateTime? startDate, DateTime? endDate, string fiscalYear, DateTime? qtr1, DateTime? qtr2, DateTime? qtr3, DateTime? qtr4, bool? activateYear, byte? activeQtr, bool? yearIsClosed, bool? yearCloseControl)
        {
            return Select(financialYearID, accFundCode, accFundAccFundName, startDate, endDate, fiscalYear, qtr1, qtr2, qtr3, qtr4, activateYear, activeQtr, yearIsClosed, yearCloseControl, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.FinancialYear SelectSingle(int? financialYearID)
        {
            List<MyCompany.Data.Objects.FinancialYear> list = Select(financialYearID, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.FinancialYear> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("FinancialYear", dataView, request);
            return page.ToList<MyCompany.Data.Objects.FinancialYear>();
        }
        
        public List<MyCompany.Data.Objects.FinancialYear> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.FinancialYear> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.FinancialYear SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.FinancialYear> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.FinancialYear theFinancialYear, MyCompany.Data.Objects.FinancialYear original_FinancialYear)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("FinancialYearID", original_FinancialYear.FinancialYearID, theFinancialYear.FinancialYearID, true));
            values.Add(new FieldValue("AccFundCode", original_FinancialYear.AccFundCode, theFinancialYear.AccFundCode));
            values.Add(new FieldValue("AccFundAccFundName", original_FinancialYear.AccFundAccFundName, theFinancialYear.AccFundAccFundName, true));
            values.Add(new FieldValue("StartDate", original_FinancialYear.StartDate, theFinancialYear.StartDate));
            values.Add(new FieldValue("EndDate", original_FinancialYear.EndDate, theFinancialYear.EndDate));
            values.Add(new FieldValue("FiscalYear", original_FinancialYear.FiscalYear, theFinancialYear.FiscalYear));
            values.Add(new FieldValue("Qtr1", original_FinancialYear.Qtr1, theFinancialYear.Qtr1));
            values.Add(new FieldValue("Qtr2", original_FinancialYear.Qtr2, theFinancialYear.Qtr2));
            values.Add(new FieldValue("Qtr3", original_FinancialYear.Qtr3, theFinancialYear.Qtr3));
            values.Add(new FieldValue("Qtr4", original_FinancialYear.Qtr4, theFinancialYear.Qtr4));
            values.Add(new FieldValue("ActivateYear", original_FinancialYear.ActivateYear, theFinancialYear.ActivateYear));
            values.Add(new FieldValue("ActiveQtr", original_FinancialYear.ActiveQtr, theFinancialYear.ActiveQtr));
            values.Add(new FieldValue("YearIsClosed", original_FinancialYear.YearIsClosed, theFinancialYear.YearIsClosed));
            values.Add(new FieldValue("YearCloseControl", original_FinancialYear.YearCloseControl, theFinancialYear.YearCloseControl));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.FinancialYear theFinancialYear, MyCompany.Data.Objects.FinancialYear original_FinancialYear, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "FinancialYear";
            args.View = dataView;
            args.Values = CreateFieldValues(theFinancialYear, original_FinancialYear);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("FinancialYear", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theFinancialYear);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.FinancialYear theFinancialYear, MyCompany.Data.Objects.FinancialYear original_FinancialYear)
        {
            return ExecuteAction(theFinancialYear, original_FinancialYear, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.FinancialYear theFinancialYear)
        {
            return Update(theFinancialYear, SelectSingle(theFinancialYear.FinancialYearID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.FinancialYear theFinancialYear)
        {
            return ExecuteAction(theFinancialYear, new FinancialYear(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.FinancialYear theFinancialYear)
        {
            return ExecuteAction(theFinancialYear, theFinancialYear, "Select", "Delete", DeleteView);
        }
    }
}
