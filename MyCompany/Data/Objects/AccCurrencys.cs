using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class AccCurrencys
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accCurrencyID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accCurrency;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accCurrencyName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accCurrencySymble;
        
        public AccCurrencys()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? AccCurrencyID
        {
            get
            {
                return _accCurrencyID;
            }
            set
            {
                _accCurrencyID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public int? AccCurrency
        {
            get
            {
                return _accCurrency;
            }
            set
            {
                _accCurrency = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccCurrencyName
        {
            get
            {
                return _accCurrencyName;
            }
            set
            {
                _accCurrencyName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccCurrencySymble
        {
            get
            {
                return _accCurrencySymble;
            }
            set
            {
                _accCurrencySymble = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.AccCurrencys> Select(int? accCurrencyID, int? accCurrency, string accCurrencyName, string accCurrencySymble)
        {
            return new AccCurrencysFactory().Select(accCurrencyID, accCurrency, accCurrencyName, accCurrencySymble);
        }
        
        public static List<MyCompany.Data.Objects.AccCurrencys> Select(MyCompany.Data.Objects.AccCurrencys qbe)
        {
            return new AccCurrencysFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.AccCurrencys> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new AccCurrencysFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccCurrencys> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new AccCurrencysFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.AccCurrencys> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new AccCurrencysFactory().Select(filter, sort, AccCurrencysFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccCurrencys> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new AccCurrencysFactory().Select(filter, sort, AccCurrencysFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.AccCurrencys> Select(string filter, BusinessObjectParameters parameters)
        {
            return new AccCurrencysFactory().Select(filter, null, AccCurrencysFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccCurrencys> Select(string filter, params FieldValue[] parameters)
        {
            return new AccCurrencysFactory().Select(filter, null, AccCurrencysFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.AccCurrencys SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new AccCurrencysFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.AccCurrencys SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new AccCurrencysFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.AccCurrencys SelectSingle(int? accCurrencyID)
        {
            return new AccCurrencysFactory().SelectSingle(accCurrencyID);
        }
        
        public int Insert()
        {
            return new AccCurrencysFactory().Insert(this);
        }
        
        public int Update()
        {
            return new AccCurrencysFactory().Update(this);
        }
        
        public int Delete()
        {
            return new AccCurrencysFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("AccCurrencyID: {0}", this.AccCurrencyID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class AccCurrencysFactory
    {
        
        public AccCurrencysFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("AccCurrencys");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("AccCurrencys");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("AccCurrencys");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("AccCurrencys");
            }
        }
        
        public static AccCurrencysFactory Create()
        {
            return new AccCurrencysFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? accCurrencyID, int? accCurrency, string accCurrencyName, string accCurrencySymble, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (accCurrencyID.HasValue)
            	filter.Add(("AccCurrencyID:=" + accCurrencyID.Value.ToString()));
            if (accCurrency.HasValue)
            	filter.Add(("AccCurrency:=" + accCurrency.Value.ToString()));
            if (!(String.IsNullOrEmpty(accCurrencyName)))
            	filter.Add(("AccCurrencyName:*" + accCurrencyName));
            if (!(String.IsNullOrEmpty(accCurrencySymble)))
            	filter.Add(("AccCurrencySymble:*" + accCurrencySymble));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.AccCurrencys> Select(int? accCurrencyID, int? accCurrency, string accCurrencyName, string accCurrencySymble, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(accCurrencyID, accCurrency, accCurrencyName, accCurrencySymble, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("AccCurrencys", dataView, request);
            return page.ToList<MyCompany.Data.Objects.AccCurrencys>();
        }
        
        public List<MyCompany.Data.Objects.AccCurrencys> Select(MyCompany.Data.Objects.AccCurrencys qbe)
        {
            return Select(qbe.AccCurrencyID, qbe.AccCurrency, qbe.AccCurrencyName, qbe.AccCurrencySymble);
        }
        
        public int SelectCount(int? accCurrencyID, int? accCurrency, string accCurrencyName, string accCurrencySymble, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(accCurrencyID, accCurrency, accCurrencyName, accCurrencySymble, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("AccCurrencys", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.AccCurrencys> Select(int? accCurrencyID, int? accCurrency, string accCurrencyName, string accCurrencySymble)
        {
            return Select(accCurrencyID, accCurrency, accCurrencyName, accCurrencySymble, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.AccCurrencys SelectSingle(int? accCurrencyID)
        {
            int? emptyAccCurrency = null;
            string emptyAccCurrencyName = null;
            string emptyAccCurrencySymble = null;
            List<MyCompany.Data.Objects.AccCurrencys> list = Select(accCurrencyID, emptyAccCurrency, emptyAccCurrencyName, emptyAccCurrencySymble);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.AccCurrencys> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("AccCurrencys", dataView, request);
            return page.ToList<MyCompany.Data.Objects.AccCurrencys>();
        }
        
        public List<MyCompany.Data.Objects.AccCurrencys> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.AccCurrencys> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.AccCurrencys SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.AccCurrencys> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.AccCurrencys theAccCurrencys, MyCompany.Data.Objects.AccCurrencys original_AccCurrencys)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("AccCurrencyID", original_AccCurrencys.AccCurrencyID, theAccCurrencys.AccCurrencyID, true));
            values.Add(new FieldValue("AccCurrency", original_AccCurrencys.AccCurrency, theAccCurrencys.AccCurrency));
            values.Add(new FieldValue("AccCurrencyName", original_AccCurrencys.AccCurrencyName, theAccCurrencys.AccCurrencyName));
            values.Add(new FieldValue("AccCurrencySymble", original_AccCurrencys.AccCurrencySymble, theAccCurrencys.AccCurrencySymble));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.AccCurrencys theAccCurrencys, MyCompany.Data.Objects.AccCurrencys original_AccCurrencys, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "AccCurrencys";
            args.View = dataView;
            args.Values = CreateFieldValues(theAccCurrencys, original_AccCurrencys);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("AccCurrencys", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theAccCurrencys);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.AccCurrencys theAccCurrencys, MyCompany.Data.Objects.AccCurrencys original_AccCurrencys)
        {
            return ExecuteAction(theAccCurrencys, original_AccCurrencys, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.AccCurrencys theAccCurrencys)
        {
            return Update(theAccCurrencys, SelectSingle(theAccCurrencys.AccCurrencyID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.AccCurrencys theAccCurrencys)
        {
            return ExecuteAction(theAccCurrencys, new AccCurrencys(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.AccCurrencys theAccCurrencys)
        {
            return ExecuteAction(theAccCurrencys, theAccCurrencys, "Select", "Delete", DeleteView);
        }
    }
}
