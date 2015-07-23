using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class AccFunds
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accFundID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accFundName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _address;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _startDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _endDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _res_Person;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _projYN;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _consolidated;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _headOffice;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _factoryOffice;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private byte[] _companyLOGO;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _companyTypeID;
        
        public AccFunds()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string AccFundName
        {
            get
            {
                return _accFundName;
            }
            set
            {
                _accFundName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
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
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Res_Person
        {
            get
            {
                return _res_Person;
            }
            set
            {
                _res_Person = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? ProjYN
        {
            get
            {
                return _projYN;
            }
            set
            {
                _projYN = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? Consolidated
        {
            get
            {
                return _consolidated;
            }
            set
            {
                _consolidated = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? HeadOffice
        {
            get
            {
                return _headOffice;
            }
            set
            {
                _headOffice = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? FactoryOffice
        {
            get
            {
                return _factoryOffice;
            }
            set
            {
                _factoryOffice = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public byte[] CompanyLOGO
        {
            get
            {
                return _companyLOGO;
            }
            set
            {
                _companyLOGO = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? CompanyTypeID
        {
            get
            {
                return _companyTypeID;
            }
            set
            {
                _companyTypeID = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.AccFunds> Select(int? accFundID, string accFundName, string accFundCode, string address, DateTime? startDate, DateTime? endDate, string res_Person, bool? projYN, bool? consolidated, bool? headOffice, bool? factoryOffice, int? companyTypeID)
        {
            return new AccFundsFactory().Select(accFundID, accFundName, accFundCode, address, startDate, endDate, res_Person, projYN, consolidated, headOffice, factoryOffice, companyTypeID);
        }
        
        public static List<MyCompany.Data.Objects.AccFunds> Select(MyCompany.Data.Objects.AccFunds qbe)
        {
            return new AccFundsFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.AccFunds> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new AccFundsFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccFunds> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new AccFundsFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.AccFunds> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new AccFundsFactory().Select(filter, sort, AccFundsFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccFunds> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new AccFundsFactory().Select(filter, sort, AccFundsFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.AccFunds> Select(string filter, BusinessObjectParameters parameters)
        {
            return new AccFundsFactory().Select(filter, null, AccFundsFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccFunds> Select(string filter, params FieldValue[] parameters)
        {
            return new AccFundsFactory().Select(filter, null, AccFundsFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.AccFunds SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new AccFundsFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.AccFunds SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new AccFundsFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.AccFunds SelectSingle(int? accFundID)
        {
            return new AccFundsFactory().SelectSingle(accFundID);
        }
        
        public int Insert()
        {
            return new AccFundsFactory().Insert(this);
        }
        
        public int Update()
        {
            return new AccFundsFactory().Update(this);
        }
        
        public int Delete()
        {
            return new AccFundsFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("AccFundID: {0}", this.AccFundID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class AccFundsFactory
    {
        
        public AccFundsFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("AccFunds");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("AccFunds");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("AccFunds");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("AccFunds");
            }
        }
        
        public static AccFundsFactory Create()
        {
            return new AccFundsFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? accFundID, string accFundName, string accFundCode, string address, DateTime? startDate, DateTime? endDate, string res_Person, bool? projYN, bool? consolidated, bool? headOffice, bool? factoryOffice, int? companyTypeID, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (accFundID.HasValue)
            	filter.Add(("AccFundID:=" + accFundID.Value.ToString()));
            if (!(String.IsNullOrEmpty(accFundName)))
            	filter.Add(("AccFundName:*" + accFundName));
            if (!(String.IsNullOrEmpty(accFundCode)))
            	filter.Add(("AccFundCode:*" + accFundCode));
            if (!(String.IsNullOrEmpty(address)))
            	filter.Add(("Address:*" + address));
            if (startDate.HasValue)
            	filter.Add(("StartDate:=" + startDate.Value.ToString()));
            if (endDate.HasValue)
            	filter.Add(("EndDate:=" + endDate.Value.ToString()));
            if (!(String.IsNullOrEmpty(res_Person)))
            	filter.Add(("Res_Person:*" + res_Person));
            if (projYN.HasValue)
            	filter.Add(("ProjYN:=" + projYN.Value.ToString()));
            if (consolidated.HasValue)
            	filter.Add(("Consolidated:=" + consolidated.Value.ToString()));
            if (headOffice.HasValue)
            	filter.Add(("HeadOffice:=" + headOffice.Value.ToString()));
            if (factoryOffice.HasValue)
            	filter.Add(("FactoryOffice:=" + factoryOffice.Value.ToString()));
            if (companyTypeID.HasValue)
            	filter.Add(("CompanyTypeID:=" + companyTypeID.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.AccFunds> Select(
                    int? accFundID, 
                    string accFundName, 
                    string accFundCode, 
                    string address, 
                    DateTime? startDate, 
                    DateTime? endDate, 
                    string res_Person, 
                    bool? projYN, 
                    bool? consolidated, 
                    bool? headOffice, 
                    bool? factoryOffice, 
                    int? companyTypeID, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(accFundID, accFundName, accFundCode, address, startDate, endDate, res_Person, projYN, consolidated, headOffice, factoryOffice, companyTypeID, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("AccFunds", dataView, request);
            return page.ToList<MyCompany.Data.Objects.AccFunds>();
        }
        
        public List<MyCompany.Data.Objects.AccFunds> Select(MyCompany.Data.Objects.AccFunds qbe)
        {
            return Select(qbe.AccFundID, qbe.AccFundName, qbe.AccFundCode, qbe.Address, qbe.StartDate, qbe.EndDate, qbe.Res_Person, qbe.ProjYN, qbe.Consolidated, qbe.HeadOffice, qbe.FactoryOffice, qbe.CompanyTypeID);
        }
        
        public int SelectCount(
                    int? accFundID, 
                    string accFundName, 
                    string accFundCode, 
                    string address, 
                    DateTime? startDate, 
                    DateTime? endDate, 
                    string res_Person, 
                    bool? projYN, 
                    bool? consolidated, 
                    bool? headOffice, 
                    bool? factoryOffice, 
                    int? companyTypeID, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(accFundID, accFundName, accFundCode, address, startDate, endDate, res_Person, projYN, consolidated, headOffice, factoryOffice, companyTypeID, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("AccFunds", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.AccFunds> Select(int? accFundID, string accFundName, string accFundCode, string address, DateTime? startDate, DateTime? endDate, string res_Person, bool? projYN, bool? consolidated, bool? headOffice, bool? factoryOffice, int? companyTypeID)
        {
            return Select(accFundID, accFundName, accFundCode, address, startDate, endDate, res_Person, projYN, consolidated, headOffice, factoryOffice, companyTypeID, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.AccFunds SelectSingle(int? accFundID)
        {
            List<MyCompany.Data.Objects.AccFunds> list = Select(accFundID, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.AccFunds> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("AccFunds", dataView, request);
            return page.ToList<MyCompany.Data.Objects.AccFunds>();
        }
        
        public List<MyCompany.Data.Objects.AccFunds> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.AccFunds> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.AccFunds SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.AccFunds> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.AccFunds theAccFunds, MyCompany.Data.Objects.AccFunds original_AccFunds)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("AccFundID", original_AccFunds.AccFundID, theAccFunds.AccFundID, true));
            values.Add(new FieldValue("AccFundName", original_AccFunds.AccFundName, theAccFunds.AccFundName));
            values.Add(new FieldValue("AccFundCode", original_AccFunds.AccFundCode, theAccFunds.AccFundCode));
            values.Add(new FieldValue("Address", original_AccFunds.Address, theAccFunds.Address));
            values.Add(new FieldValue("StartDate", original_AccFunds.StartDate, theAccFunds.StartDate));
            values.Add(new FieldValue("EndDate", original_AccFunds.EndDate, theAccFunds.EndDate));
            values.Add(new FieldValue("Res_Person", original_AccFunds.Res_Person, theAccFunds.Res_Person));
            values.Add(new FieldValue("ProjYN", original_AccFunds.ProjYN, theAccFunds.ProjYN));
            values.Add(new FieldValue("Consolidated", original_AccFunds.Consolidated, theAccFunds.Consolidated));
            values.Add(new FieldValue("HeadOffice", original_AccFunds.HeadOffice, theAccFunds.HeadOffice));
            values.Add(new FieldValue("FactoryOffice", original_AccFunds.FactoryOffice, theAccFunds.FactoryOffice));
            values.Add(new FieldValue("CompanyLOGO", original_AccFunds.CompanyLOGO, theAccFunds.CompanyLOGO));
            values.Add(new FieldValue("CompanyTypeID", original_AccFunds.CompanyTypeID, theAccFunds.CompanyTypeID));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.AccFunds theAccFunds, MyCompany.Data.Objects.AccFunds original_AccFunds, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "AccFunds";
            args.View = dataView;
            args.Values = CreateFieldValues(theAccFunds, original_AccFunds);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("AccFunds", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theAccFunds);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.AccFunds theAccFunds, MyCompany.Data.Objects.AccFunds original_AccFunds)
        {
            return ExecuteAction(theAccFunds, original_AccFunds, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.AccFunds theAccFunds)
        {
            return Update(theAccFunds, SelectSingle(theAccFunds.AccFundID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.AccFunds theAccFunds)
        {
            return ExecuteAction(theAccFunds, new AccFunds(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.AccFunds theAccFunds)
        {
            return ExecuteAction(theAccFunds, theAccFunds, "Select", "Delete", DeleteView);
        }
    }
}
