using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class AccSubTypes
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accSubTypeID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accSubTypeName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _display;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _integrateOutSystemYN;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _dataSource;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _displayAcc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _displayInv;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _displayPay;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _displayFsm;
        
        public AccSubTypes()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string AccSubType
        {
            get
            {
                return _accSubType;
            }
            set
            {
                _accSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccSubTypeName
        {
            get
            {
                return _accSubTypeName;
            }
            set
            {
                _accSubTypeName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public bool? Display
        {
            get
            {
                return _display;
            }
            set
            {
                _display = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string IntegrateOutSystemYN
        {
            get
            {
                return _integrateOutSystemYN;
            }
            set
            {
                _integrateOutSystemYN = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string DataSource
        {
            get
            {
                return _dataSource;
            }
            set
            {
                _dataSource = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? DisplayAcc
        {
            get
            {
                return _displayAcc;
            }
            set
            {
                _displayAcc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? DisplayInv
        {
            get
            {
                return _displayInv;
            }
            set
            {
                _displayInv = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? DisplayPay
        {
            get
            {
                return _displayPay;
            }
            set
            {
                _displayPay = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? DisplayFsm
        {
            get
            {
                return _displayFsm;
            }
            set
            {
                _displayFsm = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.AccSubTypes> Select(int? accSubTypeID, string accSubType, string accSubTypeName, bool? display, string integrateOutSystemYN, string dataSource, bool? displayAcc, bool? displayInv, bool? displayPay, bool? displayFsm)
        {
            return new AccSubTypesFactory().Select(accSubTypeID, accSubType, accSubTypeName, display, integrateOutSystemYN, dataSource, displayAcc, displayInv, displayPay, displayFsm);
        }
        
        public static List<MyCompany.Data.Objects.AccSubTypes> Select(MyCompany.Data.Objects.AccSubTypes qbe)
        {
            return new AccSubTypesFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.AccSubTypes> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new AccSubTypesFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccSubTypes> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new AccSubTypesFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.AccSubTypes> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new AccSubTypesFactory().Select(filter, sort, AccSubTypesFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccSubTypes> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new AccSubTypesFactory().Select(filter, sort, AccSubTypesFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.AccSubTypes> Select(string filter, BusinessObjectParameters parameters)
        {
            return new AccSubTypesFactory().Select(filter, null, AccSubTypesFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccSubTypes> Select(string filter, params FieldValue[] parameters)
        {
            return new AccSubTypesFactory().Select(filter, null, AccSubTypesFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.AccSubTypes SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new AccSubTypesFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.AccSubTypes SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new AccSubTypesFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.AccSubTypes SelectSingle(int? accSubTypeID)
        {
            return new AccSubTypesFactory().SelectSingle(accSubTypeID);
        }
        
        public int Insert()
        {
            return new AccSubTypesFactory().Insert(this);
        }
        
        public int Update()
        {
            return new AccSubTypesFactory().Update(this);
        }
        
        public int Delete()
        {
            return new AccSubTypesFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("AccSubTypeID: {0}", this.AccSubTypeID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class AccSubTypesFactory
    {
        
        public AccSubTypesFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("AccSubTypes");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("AccSubTypes");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("AccSubTypes");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("AccSubTypes");
            }
        }
        
        public static AccSubTypesFactory Create()
        {
            return new AccSubTypesFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? accSubTypeID, string accSubType, string accSubTypeName, bool? display, string integrateOutSystemYN, string dataSource, bool? displayAcc, bool? displayInv, bool? displayPay, bool? displayFsm, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (accSubTypeID.HasValue)
            	filter.Add(("AccSubTypeID:=" + accSubTypeID.Value.ToString()));
            if (!(String.IsNullOrEmpty(accSubType)))
            	filter.Add(("AccSubType:*" + accSubType));
            if (!(String.IsNullOrEmpty(accSubTypeName)))
            	filter.Add(("AccSubTypeName:*" + accSubTypeName));
            if (display.HasValue)
            	filter.Add(("Display:=" + display.Value.ToString()));
            if (!(String.IsNullOrEmpty(integrateOutSystemYN)))
            	filter.Add(("IntegrateOutSystemYN:*" + integrateOutSystemYN));
            if (!(String.IsNullOrEmpty(dataSource)))
            	filter.Add(("DataSource:*" + dataSource));
            if (displayAcc.HasValue)
            	filter.Add(("DisplayAcc:=" + displayAcc.Value.ToString()));
            if (displayInv.HasValue)
            	filter.Add(("DisplayInv:=" + displayInv.Value.ToString()));
            if (displayPay.HasValue)
            	filter.Add(("DisplayPay:=" + displayPay.Value.ToString()));
            if (displayFsm.HasValue)
            	filter.Add(("DisplayFsm:=" + displayFsm.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.AccSubTypes> Select(int? accSubTypeID, string accSubType, string accSubTypeName, bool? display, string integrateOutSystemYN, string dataSource, bool? displayAcc, bool? displayInv, bool? displayPay, bool? displayFsm, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(accSubTypeID, accSubType, accSubTypeName, display, integrateOutSystemYN, dataSource, displayAcc, displayInv, displayPay, displayFsm, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("AccSubTypes", dataView, request);
            return page.ToList<MyCompany.Data.Objects.AccSubTypes>();
        }
        
        public List<MyCompany.Data.Objects.AccSubTypes> Select(MyCompany.Data.Objects.AccSubTypes qbe)
        {
            return Select(qbe.AccSubTypeID, qbe.AccSubType, qbe.AccSubTypeName, qbe.Display, qbe.IntegrateOutSystemYN, qbe.DataSource, qbe.DisplayAcc, qbe.DisplayInv, qbe.DisplayPay, qbe.DisplayFsm);
        }
        
        public int SelectCount(int? accSubTypeID, string accSubType, string accSubTypeName, bool? display, string integrateOutSystemYN, string dataSource, bool? displayAcc, bool? displayInv, bool? displayPay, bool? displayFsm, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(accSubTypeID, accSubType, accSubTypeName, display, integrateOutSystemYN, dataSource, displayAcc, displayInv, displayPay, displayFsm, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("AccSubTypes", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.AccSubTypes> Select(int? accSubTypeID, string accSubType, string accSubTypeName, bool? display, string integrateOutSystemYN, string dataSource, bool? displayAcc, bool? displayInv, bool? displayPay, bool? displayFsm)
        {
            return Select(accSubTypeID, accSubType, accSubTypeName, display, integrateOutSystemYN, dataSource, displayAcc, displayInv, displayPay, displayFsm, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.AccSubTypes SelectSingle(int? accSubTypeID)
        {
            List<MyCompany.Data.Objects.AccSubTypes> list = Select(accSubTypeID, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.AccSubTypes> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("AccSubTypes", dataView, request);
            return page.ToList<MyCompany.Data.Objects.AccSubTypes>();
        }
        
        public List<MyCompany.Data.Objects.AccSubTypes> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.AccSubTypes> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.AccSubTypes SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.AccSubTypes> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.AccSubTypes theAccSubTypes, MyCompany.Data.Objects.AccSubTypes original_AccSubTypes)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("AccSubTypeID", original_AccSubTypes.AccSubTypeID, theAccSubTypes.AccSubTypeID, true));
            values.Add(new FieldValue("AccSubType", original_AccSubTypes.AccSubType, theAccSubTypes.AccSubType));
            values.Add(new FieldValue("AccSubTypeName", original_AccSubTypes.AccSubTypeName, theAccSubTypes.AccSubTypeName));
            values.Add(new FieldValue("Display", original_AccSubTypes.Display, theAccSubTypes.Display));
            values.Add(new FieldValue("IntegrateOutSystemYN", original_AccSubTypes.IntegrateOutSystemYN, theAccSubTypes.IntegrateOutSystemYN));
            values.Add(new FieldValue("DataSource", original_AccSubTypes.DataSource, theAccSubTypes.DataSource));
            values.Add(new FieldValue("DisplayAcc", original_AccSubTypes.DisplayAcc, theAccSubTypes.DisplayAcc));
            values.Add(new FieldValue("DisplayInv", original_AccSubTypes.DisplayInv, theAccSubTypes.DisplayInv));
            values.Add(new FieldValue("DisplayPay", original_AccSubTypes.DisplayPay, theAccSubTypes.DisplayPay));
            values.Add(new FieldValue("DisplayFsm", original_AccSubTypes.DisplayFsm, theAccSubTypes.DisplayFsm));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.AccSubTypes theAccSubTypes, MyCompany.Data.Objects.AccSubTypes original_AccSubTypes, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "AccSubTypes";
            args.View = dataView;
            args.Values = CreateFieldValues(theAccSubTypes, original_AccSubTypes);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("AccSubTypes", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theAccSubTypes);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.AccSubTypes theAccSubTypes, MyCompany.Data.Objects.AccSubTypes original_AccSubTypes)
        {
            return ExecuteAction(theAccSubTypes, original_AccSubTypes, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.AccSubTypes theAccSubTypes)
        {
            return Update(theAccSubTypes, SelectSingle(theAccSubTypes.AccSubTypeID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.AccSubTypes theAccSubTypes)
        {
            return ExecuteAction(theAccSubTypes, new AccSubTypes(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.AccSubTypes theAccSubTypes)
        {
            return ExecuteAction(theAccSubTypes, theAccSubTypes, "Select", "Delete", DeleteView);
        }
    }
}
