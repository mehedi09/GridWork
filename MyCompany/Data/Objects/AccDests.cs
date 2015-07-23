using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class AccDests
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accDestID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accDestName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _companyType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _companyTypeDescription;
        
        public AccDests()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
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
        public string AccDestName
        {
            get
            {
                return _accDestName;
            }
            set
            {
                _accDestName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string AccDest
        {
            get
            {
                return _accDest;
            }
            set
            {
                _accDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? CompanyType
        {
            get
            {
                return _companyType;
            }
            set
            {
                _companyType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CompanyTypeDescription
        {
            get
            {
                return _companyTypeDescription;
            }
            set
            {
                _companyTypeDescription = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.AccDests> Select(int? accDestID, string accDestName, string accDest, int? companyType, string companyTypeDescription)
        {
            return new AccDestsFactory().Select(accDestID, accDestName, accDest, companyType, companyTypeDescription);
        }
        
        public static List<MyCompany.Data.Objects.AccDests> Select(MyCompany.Data.Objects.AccDests qbe)
        {
            return new AccDestsFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.AccDests> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new AccDestsFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccDests> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new AccDestsFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.AccDests> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new AccDestsFactory().Select(filter, sort, AccDestsFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccDests> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new AccDestsFactory().Select(filter, sort, AccDestsFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.AccDests> Select(string filter, BusinessObjectParameters parameters)
        {
            return new AccDestsFactory().Select(filter, null, AccDestsFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccDests> Select(string filter, params FieldValue[] parameters)
        {
            return new AccDestsFactory().Select(filter, null, AccDestsFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.AccDests SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new AccDestsFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.AccDests SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new AccDestsFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.AccDests SelectSingle(int? accDestID)
        {
            return new AccDestsFactory().SelectSingle(accDestID);
        }
        
        public int Insert()
        {
            return new AccDestsFactory().Insert(this);
        }
        
        public int Update()
        {
            return new AccDestsFactory().Update(this);
        }
        
        public int Delete()
        {
            return new AccDestsFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("AccDestID: {0}", this.AccDestID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class AccDestsFactory
    {
        
        public AccDestsFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("AccDests");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("AccDests");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("AccDests");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("AccDests");
            }
        }
        
        public static AccDestsFactory Create()
        {
            return new AccDestsFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? accDestID, string accDestName, string accDest, int? companyType, string companyTypeDescription, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (accDestID.HasValue)
            	filter.Add(("AccDestID:=" + accDestID.Value.ToString()));
            if (!(String.IsNullOrEmpty(accDestName)))
            	filter.Add(("AccDestName:*" + accDestName));
            if (!(String.IsNullOrEmpty(accDest)))
            	filter.Add(("AccDest:*" + accDest));
            if (companyType.HasValue)
            	filter.Add(("CompanyType:=" + companyType.Value.ToString()));
            if (!(String.IsNullOrEmpty(companyTypeDescription)))
            	filter.Add(("CompanyTypeDescription:*" + companyTypeDescription));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.AccDests> Select(int? accDestID, string accDestName, string accDest, int? companyType, string companyTypeDescription, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(accDestID, accDestName, accDest, companyType, companyTypeDescription, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("AccDests", dataView, request);
            return page.ToList<MyCompany.Data.Objects.AccDests>();
        }
        
        public List<MyCompany.Data.Objects.AccDests> Select(MyCompany.Data.Objects.AccDests qbe)
        {
            return Select(qbe.AccDestID, qbe.AccDestName, qbe.AccDest, qbe.CompanyType, qbe.CompanyTypeDescription);
        }
        
        public int SelectCount(int? accDestID, string accDestName, string accDest, int? companyType, string companyTypeDescription, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(accDestID, accDestName, accDest, companyType, companyTypeDescription, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("AccDests", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.AccDests> Select(int? accDestID, string accDestName, string accDest, int? companyType, string companyTypeDescription)
        {
            return Select(accDestID, accDestName, accDest, companyType, companyTypeDescription, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.AccDests SelectSingle(int? accDestID)
        {
            List<MyCompany.Data.Objects.AccDests> list = Select(accDestID, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.AccDests> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("AccDests", dataView, request);
            return page.ToList<MyCompany.Data.Objects.AccDests>();
        }
        
        public List<MyCompany.Data.Objects.AccDests> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.AccDests> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.AccDests SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.AccDests> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.AccDests theAccDests, MyCompany.Data.Objects.AccDests original_AccDests)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("AccDestID", original_AccDests.AccDestID, theAccDests.AccDestID, true));
            values.Add(new FieldValue("AccDestName", original_AccDests.AccDestName, theAccDests.AccDestName));
            values.Add(new FieldValue("AccDest", original_AccDests.AccDest, theAccDests.AccDest));
            values.Add(new FieldValue("CompanyType", original_AccDests.CompanyType, theAccDests.CompanyType));
            values.Add(new FieldValue("CompanyTypeDescription", original_AccDests.CompanyTypeDescription, theAccDests.CompanyTypeDescription, true));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.AccDests theAccDests, MyCompany.Data.Objects.AccDests original_AccDests, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "AccDests";
            args.View = dataView;
            args.Values = CreateFieldValues(theAccDests, original_AccDests);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("AccDests", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theAccDests);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.AccDests theAccDests, MyCompany.Data.Objects.AccDests original_AccDests)
        {
            return ExecuteAction(theAccDests, original_AccDests, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.AccDests theAccDests)
        {
            return Update(theAccDests, SelectSingle(theAccDests.AccDestID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.AccDests theAccDests)
        {
            return ExecuteAction(theAccDests, new AccDests(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.AccDests theAccDests)
        {
            return ExecuteAction(theAccDests, theAccDests, "Select", "Delete", DeleteView);
        }
    }
}
