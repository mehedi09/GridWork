using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class Prefix
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _prefixID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _prefix;
        
        public Prefix()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? PrefixID
        {
            get
            {
                return _prefixID;
            }
            set
            {
                _prefixID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Prefix_
        {
            get
            {
                return _prefix;
            }
            set
            {
                _prefix = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.Prefix> Select(int? prefixID, string prefix)
        {
            return new PrefixFactory().Select(prefixID, prefix);
        }
        
        public static List<MyCompany.Data.Objects.Prefix> Select(MyCompany.Data.Objects.Prefix qbe)
        {
            return new PrefixFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.Prefix> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new PrefixFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.Prefix> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new PrefixFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.Prefix> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new PrefixFactory().Select(filter, sort, PrefixFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.Prefix> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new PrefixFactory().Select(filter, sort, PrefixFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.Prefix> Select(string filter, BusinessObjectParameters parameters)
        {
            return new PrefixFactory().Select(filter, null, PrefixFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.Prefix> Select(string filter, params FieldValue[] parameters)
        {
            return new PrefixFactory().Select(filter, null, PrefixFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.Prefix SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new PrefixFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.Prefix SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new PrefixFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.Prefix SelectSingle(int? prefixID)
        {
            return new PrefixFactory().SelectSingle(prefixID);
        }
        
        public int Insert()
        {
            return new PrefixFactory().Insert(this);
        }
        
        public int Update()
        {
            return new PrefixFactory().Update(this);
        }
        
        public int Delete()
        {
            return new PrefixFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("PrefixID: {0}", this.PrefixID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class PrefixFactory
    {
        
        public PrefixFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Prefix");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Prefix");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Prefix");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Prefix");
            }
        }
        
        public static PrefixFactory Create()
        {
            return new PrefixFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? prefixID, string prefix, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (prefixID.HasValue)
            	filter.Add(("PrefixID:=" + prefixID.Value.ToString()));
            if (!(String.IsNullOrEmpty(prefix)))
            	filter.Add(("Prefix:*" + prefix));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.Prefix> Select(int? prefixID, string prefix, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(prefixID, prefix, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Prefix", dataView, request);
            return page.ToList<MyCompany.Data.Objects.Prefix>();
        }
        
        public List<MyCompany.Data.Objects.Prefix> Select(MyCompany.Data.Objects.Prefix qbe)
        {
            return Select(qbe.PrefixID, qbe.Prefix_);
        }
        
        public int SelectCount(int? prefixID, string prefix, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(prefixID, prefix, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Prefix", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.Prefix> Select(int? prefixID, string prefix)
        {
            return Select(prefixID, prefix, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.Prefix SelectSingle(int? prefixID)
        {
            string emptyPrefix = null;
            List<MyCompany.Data.Objects.Prefix> list = Select(prefixID, emptyPrefix);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.Prefix> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("Prefix", dataView, request);
            return page.ToList<MyCompany.Data.Objects.Prefix>();
        }
        
        public List<MyCompany.Data.Objects.Prefix> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.Prefix> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.Prefix SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.Prefix> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.Prefix thePrefix, MyCompany.Data.Objects.Prefix original_Prefix)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("PrefixID", original_Prefix.PrefixID, thePrefix.PrefixID, true));
            values.Add(new FieldValue("Prefix", original_Prefix.Prefix_, thePrefix.Prefix_));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.Prefix thePrefix, MyCompany.Data.Objects.Prefix original_Prefix, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "Prefix";
            args.View = dataView;
            args.Values = CreateFieldValues(thePrefix, original_Prefix);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("Prefix", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(thePrefix);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.Prefix thePrefix, MyCompany.Data.Objects.Prefix original_Prefix)
        {
            return ExecuteAction(thePrefix, original_Prefix, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.Prefix thePrefix)
        {
            return Update(thePrefix, SelectSingle(thePrefix.PrefixID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.Prefix thePrefix)
        {
            return ExecuteAction(thePrefix, new Prefix(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.Prefix thePrefix)
        {
            return ExecuteAction(thePrefix, thePrefix, "Select", "Delete", DeleteView);
        }
    }
}
