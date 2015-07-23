using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class CoaControl
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _coaControlID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accDescription;
        
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
        private bool? _isSystem;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private byte? _isInventoryItem;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _rptSlno;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _compType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _compTypeDescription;
        
        public CoaControl()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
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
        public string AccCode
        {
            get
            {
                return _accCode;
            }
            set
            {
                _accCode = value;
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
        public string AccDescription
        {
            get
            {
                return _accDescription;
            }
            set
            {
                _accDescription = value;
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
        public bool? IsSystem
        {
            get
            {
                return _isSystem;
            }
            set
            {
                _isSystem = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public byte? IsInventoryItem
        {
            get
            {
                return _isInventoryItem;
            }
            set
            {
                _isInventoryItem = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? RptSlno
        {
            get
            {
                return _rptSlno;
            }
            set
            {
                _rptSlno = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? CompType
        {
            get
            {
                return _compType;
            }
            set
            {
                _compType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CompTypeDescription
        {
            get
            {
                return _compTypeDescription;
            }
            set
            {
                _compTypeDescription = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.CoaControl> Select(
                    int? coaControlID, 
                    string accCode, 
                    string accName, 
                    string accDescription, 
                    int? accTypeID, 
                    string accTypeAccTypeName, 
                    int? accDestID, 
                    string accDestAccDestName, 
                    string accDestCompanyTypeDescription, 
                    int? accBalTypeID, 
                    string accBalTypeAccBalTypeName, 
                    bool? isSystem, 
                    byte? isInventoryItem, 
                    int? rptSlno, 
                    int? compType, 
                    string compTypeDescription)
        {
            return new CoaControlFactory().Select(coaControlID, accCode, accName, accDescription, accTypeID, accTypeAccTypeName, accDestID, accDestAccDestName, accDestCompanyTypeDescription, accBalTypeID, accBalTypeAccBalTypeName, isSystem, isInventoryItem, rptSlno, compType, compTypeDescription);
        }
        
        public static List<MyCompany.Data.Objects.CoaControl> Select(MyCompany.Data.Objects.CoaControl qbe)
        {
            return new CoaControlFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.CoaControl> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new CoaControlFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.CoaControl> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new CoaControlFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.CoaControl> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new CoaControlFactory().Select(filter, sort, CoaControlFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.CoaControl> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new CoaControlFactory().Select(filter, sort, CoaControlFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.CoaControl> Select(string filter, BusinessObjectParameters parameters)
        {
            return new CoaControlFactory().Select(filter, null, CoaControlFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.CoaControl> Select(string filter, params FieldValue[] parameters)
        {
            return new CoaControlFactory().Select(filter, null, CoaControlFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.CoaControl SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new CoaControlFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.CoaControl SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new CoaControlFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.CoaControl SelectSingle(int? coaControlID)
        {
            return new CoaControlFactory().SelectSingle(coaControlID);
        }
        
        public int Insert()
        {
            return new CoaControlFactory().Insert(this);
        }
        
        public int Update()
        {
            return new CoaControlFactory().Update(this);
        }
        
        public int Delete()
        {
            return new CoaControlFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("CoaControlID: {0}", this.CoaControlID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class CoaControlFactory
    {
        
        public CoaControlFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("CoaControl");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("CoaControl");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("CoaControl");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("CoaControl");
            }
        }
        
        public static CoaControlFactory Create()
        {
            return new CoaControlFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    int? coaControlID, 
                    string accCode, 
                    string accName, 
                    string accDescription, 
                    int? accTypeID, 
                    string accTypeAccTypeName, 
                    int? accDestID, 
                    string accDestAccDestName, 
                    string accDestCompanyTypeDescription, 
                    int? accBalTypeID, 
                    string accBalTypeAccBalTypeName, 
                    bool? isSystem, 
                    byte? isInventoryItem, 
                    int? rptSlno, 
                    int? compType, 
                    string compTypeDescription, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (coaControlID.HasValue)
            	filter.Add(("CoaControlID:=" + coaControlID.Value.ToString()));
            if (!(String.IsNullOrEmpty(accCode)))
            	filter.Add(("AccCode:*" + accCode));
            if (!(String.IsNullOrEmpty(accName)))
            	filter.Add(("AccName:*" + accName));
            if (!(String.IsNullOrEmpty(accDescription)))
            	filter.Add(("AccDescription:*" + accDescription));
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
            if (isSystem.HasValue)
            	filter.Add(("IsSystem:=" + isSystem.Value.ToString()));
            if (isInventoryItem.HasValue)
            	filter.Add(("IsInventoryItem:=" + isInventoryItem.Value.ToString()));
            if (rptSlno.HasValue)
            	filter.Add(("RptSlno:=" + rptSlno.Value.ToString()));
            if (compType.HasValue)
            	filter.Add(("CompType:=" + compType.Value.ToString()));
            if (!(String.IsNullOrEmpty(compTypeDescription)))
            	filter.Add(("CompTypeDescription:*" + compTypeDescription));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.CoaControl> Select(
                    int? coaControlID, 
                    string accCode, 
                    string accName, 
                    string accDescription, 
                    int? accTypeID, 
                    string accTypeAccTypeName, 
                    int? accDestID, 
                    string accDestAccDestName, 
                    string accDestCompanyTypeDescription, 
                    int? accBalTypeID, 
                    string accBalTypeAccBalTypeName, 
                    bool? isSystem, 
                    byte? isInventoryItem, 
                    int? rptSlno, 
                    int? compType, 
                    string compTypeDescription, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(coaControlID, accCode, accName, accDescription, accTypeID, accTypeAccTypeName, accDestID, accDestAccDestName, accDestCompanyTypeDescription, accBalTypeID, accBalTypeAccBalTypeName, isSystem, isInventoryItem, rptSlno, compType, compTypeDescription, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("CoaControl", dataView, request);
            return page.ToList<MyCompany.Data.Objects.CoaControl>();
        }
        
        public List<MyCompany.Data.Objects.CoaControl> Select(MyCompany.Data.Objects.CoaControl qbe)
        {
            return Select(qbe.CoaControlID, qbe.AccCode, qbe.AccName, qbe.AccDescription, qbe.AccTypeID, qbe.AccTypeAccTypeName, qbe.AccDestID, qbe.AccDestAccDestName, qbe.AccDestCompanyTypeDescription, qbe.AccBalTypeID, qbe.AccBalTypeAccBalTypeName, qbe.IsSystem, qbe.IsInventoryItem, qbe.RptSlno, qbe.CompType, qbe.CompTypeDescription);
        }
        
        public int SelectCount(
                    int? coaControlID, 
                    string accCode, 
                    string accName, 
                    string accDescription, 
                    int? accTypeID, 
                    string accTypeAccTypeName, 
                    int? accDestID, 
                    string accDestAccDestName, 
                    string accDestCompanyTypeDescription, 
                    int? accBalTypeID, 
                    string accBalTypeAccBalTypeName, 
                    bool? isSystem, 
                    byte? isInventoryItem, 
                    int? rptSlno, 
                    int? compType, 
                    string compTypeDescription, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(coaControlID, accCode, accName, accDescription, accTypeID, accTypeAccTypeName, accDestID, accDestAccDestName, accDestCompanyTypeDescription, accBalTypeID, accBalTypeAccBalTypeName, isSystem, isInventoryItem, rptSlno, compType, compTypeDescription, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("CoaControl", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.CoaControl> Select(
                    int? coaControlID, 
                    string accCode, 
                    string accName, 
                    string accDescription, 
                    int? accTypeID, 
                    string accTypeAccTypeName, 
                    int? accDestID, 
                    string accDestAccDestName, 
                    string accDestCompanyTypeDescription, 
                    int? accBalTypeID, 
                    string accBalTypeAccBalTypeName, 
                    bool? isSystem, 
                    byte? isInventoryItem, 
                    int? rptSlno, 
                    int? compType, 
                    string compTypeDescription)
        {
            return Select(coaControlID, accCode, accName, accDescription, accTypeID, accTypeAccTypeName, accDestID, accDestAccDestName, accDestCompanyTypeDescription, accBalTypeID, accBalTypeAccBalTypeName, isSystem, isInventoryItem, rptSlno, compType, compTypeDescription, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.CoaControl SelectSingle(int? coaControlID)
        {
            List<MyCompany.Data.Objects.CoaControl> list = Select(coaControlID, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.CoaControl> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("CoaControl", dataView, request);
            return page.ToList<MyCompany.Data.Objects.CoaControl>();
        }
        
        public List<MyCompany.Data.Objects.CoaControl> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.CoaControl> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.CoaControl SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.CoaControl> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.CoaControl theCoaControl, MyCompany.Data.Objects.CoaControl original_CoaControl)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("CoaControlID", original_CoaControl.CoaControlID, theCoaControl.CoaControlID, true));
            values.Add(new FieldValue("AccCode", original_CoaControl.AccCode, theCoaControl.AccCode));
            values.Add(new FieldValue("AccName", original_CoaControl.AccName, theCoaControl.AccName));
            values.Add(new FieldValue("AccDescription", original_CoaControl.AccDescription, theCoaControl.AccDescription));
            values.Add(new FieldValue("AccTypeID", original_CoaControl.AccTypeID, theCoaControl.AccTypeID));
            values.Add(new FieldValue("AccTypeAccTypeName", original_CoaControl.AccTypeAccTypeName, theCoaControl.AccTypeAccTypeName, true));
            values.Add(new FieldValue("AccDestID", original_CoaControl.AccDestID, theCoaControl.AccDestID));
            values.Add(new FieldValue("AccDestAccDestName", original_CoaControl.AccDestAccDestName, theCoaControl.AccDestAccDestName, true));
            values.Add(new FieldValue("AccDestCompanyTypeDescription", original_CoaControl.AccDestCompanyTypeDescription, theCoaControl.AccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("AccBalTypeID", original_CoaControl.AccBalTypeID, theCoaControl.AccBalTypeID));
            values.Add(new FieldValue("AccBalTypeAccBalTypeName", original_CoaControl.AccBalTypeAccBalTypeName, theCoaControl.AccBalTypeAccBalTypeName, true));
            values.Add(new FieldValue("IsSystem", original_CoaControl.IsSystem, theCoaControl.IsSystem));
            values.Add(new FieldValue("IsInventoryItem", original_CoaControl.IsInventoryItem, theCoaControl.IsInventoryItem));
            values.Add(new FieldValue("RptSlno", original_CoaControl.RptSlno, theCoaControl.RptSlno));
            values.Add(new FieldValue("CompType", original_CoaControl.CompType, theCoaControl.CompType));
            values.Add(new FieldValue("CompTypeDescription", original_CoaControl.CompTypeDescription, theCoaControl.CompTypeDescription, true));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.CoaControl theCoaControl, MyCompany.Data.Objects.CoaControl original_CoaControl, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "CoaControl";
            args.View = dataView;
            args.Values = CreateFieldValues(theCoaControl, original_CoaControl);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("CoaControl", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theCoaControl);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.CoaControl theCoaControl, MyCompany.Data.Objects.CoaControl original_CoaControl)
        {
            return ExecuteAction(theCoaControl, original_CoaControl, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.CoaControl theCoaControl)
        {
            return Update(theCoaControl, SelectSingle(theCoaControl.CoaControlID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.CoaControl theCoaControl)
        {
            return ExecuteAction(theCoaControl, new CoaControl(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.CoaControl theCoaControl)
        {
            return ExecuteAction(theCoaControl, theCoaControl, "Select", "Delete", DeleteView);
        }
    }
}
