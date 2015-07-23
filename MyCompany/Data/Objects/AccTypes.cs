using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class AccTypes
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accTypeID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accTypeName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accType;
        
        public AccTypes()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
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
        public string AccTypeName
        {
            get
            {
                return _accTypeName;
            }
            set
            {
                _accTypeName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string AccType
        {
            get
            {
                return _accType;
            }
            set
            {
                _accType = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.AccTypes> Select(int? accTypeID, string accTypeName, string accType)
        {
            return new AccTypesFactory().Select(accTypeID, accTypeName, accType);
        }
        
        public static List<MyCompany.Data.Objects.AccTypes> Select(MyCompany.Data.Objects.AccTypes qbe)
        {
            return new AccTypesFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.AccTypes> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new AccTypesFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccTypes> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new AccTypesFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.AccTypes> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new AccTypesFactory().Select(filter, sort, AccTypesFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccTypes> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new AccTypesFactory().Select(filter, sort, AccTypesFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.AccTypes> Select(string filter, BusinessObjectParameters parameters)
        {
            return new AccTypesFactory().Select(filter, null, AccTypesFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccTypes> Select(string filter, params FieldValue[] parameters)
        {
            return new AccTypesFactory().Select(filter, null, AccTypesFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.AccTypes SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new AccTypesFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.AccTypes SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new AccTypesFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.AccTypes SelectSingle(int? accTypeID)
        {
            return new AccTypesFactory().SelectSingle(accTypeID);
        }
        
        public int Insert()
        {
            return new AccTypesFactory().Insert(this);
        }
        
        public int Update()
        {
            return new AccTypesFactory().Update(this);
        }
        
        public int Delete()
        {
            return new AccTypesFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("AccTypeID: {0}", this.AccTypeID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class AccTypesFactory
    {
        
        public AccTypesFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("AccTypes");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("AccTypes");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("AccTypes");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("AccTypes");
            }
        }
        
        public static AccTypesFactory Create()
        {
            return new AccTypesFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? accTypeID, string accTypeName, string accType, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (accTypeID.HasValue)
            	filter.Add(("AccTypeID:=" + accTypeID.Value.ToString()));
            if (!(String.IsNullOrEmpty(accTypeName)))
            	filter.Add(("AccTypeName:*" + accTypeName));
            if (!(String.IsNullOrEmpty(accType)))
            	filter.Add(("AccType:*" + accType));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.AccTypes> Select(int? accTypeID, string accTypeName, string accType, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(accTypeID, accTypeName, accType, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("AccTypes", dataView, request);
            return page.ToList<MyCompany.Data.Objects.AccTypes>();
        }
        
        public List<MyCompany.Data.Objects.AccTypes> Select(MyCompany.Data.Objects.AccTypes qbe)
        {
            return Select(qbe.AccTypeID, qbe.AccTypeName, qbe.AccType);
        }
        
        public int SelectCount(int? accTypeID, string accTypeName, string accType, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(accTypeID, accTypeName, accType, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("AccTypes", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.AccTypes> Select(int? accTypeID, string accTypeName, string accType)
        {
            return Select(accTypeID, accTypeName, accType, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.AccTypes SelectSingle(int? accTypeID)
        {
            string emptyAccTypeName = null;
            string emptyAccType = null;
            List<MyCompany.Data.Objects.AccTypes> list = Select(accTypeID, emptyAccTypeName, emptyAccType);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.AccTypes> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("AccTypes", dataView, request);
            return page.ToList<MyCompany.Data.Objects.AccTypes>();
        }
        
        public List<MyCompany.Data.Objects.AccTypes> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.AccTypes> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.AccTypes SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.AccTypes> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.AccTypes theAccTypes, MyCompany.Data.Objects.AccTypes original_AccTypes)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("AccTypeID", original_AccTypes.AccTypeID, theAccTypes.AccTypeID, true));
            values.Add(new FieldValue("AccTypeName", original_AccTypes.AccTypeName, theAccTypes.AccTypeName));
            values.Add(new FieldValue("AccType", original_AccTypes.AccType, theAccTypes.AccType));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.AccTypes theAccTypes, MyCompany.Data.Objects.AccTypes original_AccTypes, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "AccTypes";
            args.View = dataView;
            args.Values = CreateFieldValues(theAccTypes, original_AccTypes);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("AccTypes", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theAccTypes);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.AccTypes theAccTypes, MyCompany.Data.Objects.AccTypes original_AccTypes)
        {
            return ExecuteAction(theAccTypes, original_AccTypes, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.AccTypes theAccTypes)
        {
            return Update(theAccTypes, SelectSingle(theAccTypes.AccTypeID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.AccTypes theAccTypes)
        {
            return ExecuteAction(theAccTypes, new AccTypes(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.AccTypes theAccTypes)
        {
            return ExecuteAction(theAccTypes, theAccTypes, "Select", "Delete", DeleteView);
        }
    }
}
