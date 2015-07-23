using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class CoaControl1
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
        
        public CoaControl1()
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
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
        
        public static List<MyCompany.Data.Objects.CoaControl1> Select(
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
            return new CoaControl1Factory().Select(coaControlID, accCode, accName, accDescription, accTypeID, accTypeAccTypeName, accDestID, accDestAccDestName, accDestCompanyTypeDescription, accBalTypeID, accBalTypeAccBalTypeName, isSystem, isInventoryItem, rptSlno, compType, compTypeDescription);
        }
        
        public static List<MyCompany.Data.Objects.CoaControl1> Select(MyCompany.Data.Objects.CoaControl1 qbe)
        {
            return new CoaControl1Factory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.CoaControl1> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new CoaControl1Factory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.CoaControl1> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new CoaControl1Factory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.CoaControl1> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new CoaControl1Factory().Select(filter, sort, CoaControl1Factory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.CoaControl1> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new CoaControl1Factory().Select(filter, sort, CoaControl1Factory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.CoaControl1> Select(string filter, BusinessObjectParameters parameters)
        {
            return new CoaControl1Factory().Select(filter, null, CoaControl1Factory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.CoaControl1> Select(string filter, params FieldValue[] parameters)
        {
            return new CoaControl1Factory().Select(filter, null, CoaControl1Factory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.CoaControl1 SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new CoaControl1Factory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.CoaControl1 SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new CoaControl1Factory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.CoaControl1 SelectSingle(int? coaControlID)
        {
            return new CoaControl1Factory().SelectSingle(coaControlID);
        }
        
        public int Insert()
        {
            return new CoaControl1Factory().Insert(this);
        }
        
        public int Update()
        {
            return new CoaControl1Factory().Update(this);
        }
        
        public int Delete()
        {
            return new CoaControl1Factory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("CoaControlID: {0}", this.CoaControlID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class CoaControl1Factory
    {
        
        public CoaControl1Factory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("CoaControl1");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("CoaControl1");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("CoaControl1");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("CoaControl1");
            }
        }
        
        public static CoaControl1Factory Create()
        {
            return new CoaControl1Factory();
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
        public List<MyCompany.Data.Objects.CoaControl1> Select(
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
            ViewPage page = ControllerFactory.CreateDataController().GetPage("CoaControl1", dataView, request);
            return page.ToList<MyCompany.Data.Objects.CoaControl1>();
        }
        
        public List<MyCompany.Data.Objects.CoaControl1> Select(MyCompany.Data.Objects.CoaControl1 qbe)
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
            ViewPage page = ControllerFactory.CreateDataController().GetPage("CoaControl1", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.CoaControl1> Select(
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
        
        public MyCompany.Data.Objects.CoaControl1 SelectSingle(int? coaControlID)
        {
            List<MyCompany.Data.Objects.CoaControl1> list = Select(coaControlID, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.CoaControl1> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("CoaControl1", dataView, request);
            return page.ToList<MyCompany.Data.Objects.CoaControl1>();
        }
        
        public List<MyCompany.Data.Objects.CoaControl1> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.CoaControl1> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.CoaControl1 SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.CoaControl1> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.CoaControl1 theCoaControl1, MyCompany.Data.Objects.CoaControl1 original_CoaControl1)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("CoaControlID", original_CoaControl1.CoaControlID, theCoaControl1.CoaControlID, true));
            values.Add(new FieldValue("AccCode", original_CoaControl1.AccCode, theCoaControl1.AccCode));
            values.Add(new FieldValue("AccName", original_CoaControl1.AccName, theCoaControl1.AccName));
            values.Add(new FieldValue("AccDescription", original_CoaControl1.AccDescription, theCoaControl1.AccDescription));
            values.Add(new FieldValue("AccTypeID", original_CoaControl1.AccTypeID, theCoaControl1.AccTypeID));
            values.Add(new FieldValue("AccTypeAccTypeName", original_CoaControl1.AccTypeAccTypeName, theCoaControl1.AccTypeAccTypeName, true));
            values.Add(new FieldValue("AccDestID", original_CoaControl1.AccDestID, theCoaControl1.AccDestID));
            values.Add(new FieldValue("AccDestAccDestName", original_CoaControl1.AccDestAccDestName, theCoaControl1.AccDestAccDestName, true));
            values.Add(new FieldValue("AccDestCompanyTypeDescription", original_CoaControl1.AccDestCompanyTypeDescription, theCoaControl1.AccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("AccBalTypeID", original_CoaControl1.AccBalTypeID, theCoaControl1.AccBalTypeID));
            values.Add(new FieldValue("AccBalTypeAccBalTypeName", original_CoaControl1.AccBalTypeAccBalTypeName, theCoaControl1.AccBalTypeAccBalTypeName, true));
            values.Add(new FieldValue("IsSystem", original_CoaControl1.IsSystem, theCoaControl1.IsSystem));
            values.Add(new FieldValue("IsInventoryItem", original_CoaControl1.IsInventoryItem, theCoaControl1.IsInventoryItem));
            values.Add(new FieldValue("RptSlno", original_CoaControl1.RptSlno, theCoaControl1.RptSlno));
            values.Add(new FieldValue("CompType", original_CoaControl1.CompType, theCoaControl1.CompType));
            values.Add(new FieldValue("CompTypeDescription", original_CoaControl1.CompTypeDescription, theCoaControl1.CompTypeDescription, true));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.CoaControl1 theCoaControl1, MyCompany.Data.Objects.CoaControl1 original_CoaControl1, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "CoaControl1";
            args.View = dataView;
            args.Values = CreateFieldValues(theCoaControl1, original_CoaControl1);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("CoaControl1", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theCoaControl1);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.CoaControl1 theCoaControl1, MyCompany.Data.Objects.CoaControl1 original_CoaControl1)
        {
            return ExecuteAction(theCoaControl1, original_CoaControl1, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.CoaControl1 theCoaControl1)
        {
            return Update(theCoaControl1, SelectSingle(theCoaControl1.CoaControlID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.CoaControl1 theCoaControl1)
        {
            return ExecuteAction(theCoaControl1, new CoaControl1(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.CoaControl1 theCoaControl1)
        {
            return ExecuteAction(theCoaControl1, theCoaControl1, "Select", "Delete", DeleteView);
        }
    }
}
