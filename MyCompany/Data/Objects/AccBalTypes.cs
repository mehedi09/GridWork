using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class AccBalTypes
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accBalTypeID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accBalTypeName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accBalType;
        
        public AccBalTypes()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
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
        public string AccBalTypeName
        {
            get
            {
                return _accBalTypeName;
            }
            set
            {
                _accBalTypeName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string AccBalType
        {
            get
            {
                return _accBalType;
            }
            set
            {
                _accBalType = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.AccBalTypes> Select(int? accBalTypeID, string accBalTypeName, string accBalType)
        {
            return new AccBalTypesFactory().Select(accBalTypeID, accBalTypeName, accBalType);
        }
        
        public static List<MyCompany.Data.Objects.AccBalTypes> Select(MyCompany.Data.Objects.AccBalTypes qbe)
        {
            return new AccBalTypesFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.AccBalTypes> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new AccBalTypesFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccBalTypes> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new AccBalTypesFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.AccBalTypes> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new AccBalTypesFactory().Select(filter, sort, AccBalTypesFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccBalTypes> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new AccBalTypesFactory().Select(filter, sort, AccBalTypesFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.AccBalTypes> Select(string filter, BusinessObjectParameters parameters)
        {
            return new AccBalTypesFactory().Select(filter, null, AccBalTypesFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccBalTypes> Select(string filter, params FieldValue[] parameters)
        {
            return new AccBalTypesFactory().Select(filter, null, AccBalTypesFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.AccBalTypes SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new AccBalTypesFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.AccBalTypes SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new AccBalTypesFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.AccBalTypes SelectSingle(int? accBalTypeID)
        {
            return new AccBalTypesFactory().SelectSingle(accBalTypeID);
        }
        
        public int Insert()
        {
            return new AccBalTypesFactory().Insert(this);
        }
        
        public int Update()
        {
            return new AccBalTypesFactory().Update(this);
        }
        
        public int Delete()
        {
            return new AccBalTypesFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("AccBalTypeID: {0}", this.AccBalTypeID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class AccBalTypesFactory
    {
        
        public AccBalTypesFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("AccBalTypes");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("AccBalTypes");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("AccBalTypes");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("AccBalTypes");
            }
        }
        
        public static AccBalTypesFactory Create()
        {
            return new AccBalTypesFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? accBalTypeID, string accBalTypeName, string accBalType, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (accBalTypeID.HasValue)
            	filter.Add(("AccBalTypeID:=" + accBalTypeID.Value.ToString()));
            if (!(String.IsNullOrEmpty(accBalTypeName)))
            	filter.Add(("AccBalTypeName:*" + accBalTypeName));
            if (!(String.IsNullOrEmpty(accBalType)))
            	filter.Add(("AccBalType:*" + accBalType));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.AccBalTypes> Select(int? accBalTypeID, string accBalTypeName, string accBalType, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(accBalTypeID, accBalTypeName, accBalType, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("AccBalTypes", dataView, request);
            return page.ToList<MyCompany.Data.Objects.AccBalTypes>();
        }
        
        public List<MyCompany.Data.Objects.AccBalTypes> Select(MyCompany.Data.Objects.AccBalTypes qbe)
        {
            return Select(qbe.AccBalTypeID, qbe.AccBalTypeName, qbe.AccBalType);
        }
        
        public int SelectCount(int? accBalTypeID, string accBalTypeName, string accBalType, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(accBalTypeID, accBalTypeName, accBalType, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("AccBalTypes", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.AccBalTypes> Select(int? accBalTypeID, string accBalTypeName, string accBalType)
        {
            return Select(accBalTypeID, accBalTypeName, accBalType, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.AccBalTypes SelectSingle(int? accBalTypeID)
        {
            string emptyAccBalTypeName = null;
            string emptyAccBalType = null;
            List<MyCompany.Data.Objects.AccBalTypes> list = Select(accBalTypeID, emptyAccBalTypeName, emptyAccBalType);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.AccBalTypes> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("AccBalTypes", dataView, request);
            return page.ToList<MyCompany.Data.Objects.AccBalTypes>();
        }
        
        public List<MyCompany.Data.Objects.AccBalTypes> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.AccBalTypes> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.AccBalTypes SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.AccBalTypes> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.AccBalTypes theAccBalTypes, MyCompany.Data.Objects.AccBalTypes original_AccBalTypes)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("AccBalTypeID", original_AccBalTypes.AccBalTypeID, theAccBalTypes.AccBalTypeID, true));
            values.Add(new FieldValue("AccBalTypeName", original_AccBalTypes.AccBalTypeName, theAccBalTypes.AccBalTypeName));
            values.Add(new FieldValue("AccBalType", original_AccBalTypes.AccBalType, theAccBalTypes.AccBalType));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.AccBalTypes theAccBalTypes, MyCompany.Data.Objects.AccBalTypes original_AccBalTypes, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "AccBalTypes";
            args.View = dataView;
            args.Values = CreateFieldValues(theAccBalTypes, original_AccBalTypes);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("AccBalTypes", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theAccBalTypes);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.AccBalTypes theAccBalTypes, MyCompany.Data.Objects.AccBalTypes original_AccBalTypes)
        {
            return ExecuteAction(theAccBalTypes, original_AccBalTypes, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.AccBalTypes theAccBalTypes)
        {
            return Update(theAccBalTypes, SelectSingle(theAccBalTypes.AccBalTypeID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.AccBalTypes theAccBalTypes)
        {
            return ExecuteAction(theAccBalTypes, new AccBalTypes(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.AccBalTypes theAccBalTypes)
        {
            return ExecuteAction(theAccBalTypes, theAccBalTypes, "Select", "Delete", DeleteView);
        }
    }
}
