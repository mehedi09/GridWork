using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class CoinEntry
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _coinID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coinName;
        
        public CoinEntry()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? CoinID
        {
            get
            {
                return _coinID;
            }
            set
            {
                _coinID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CoinName
        {
            get
            {
                return _coinName;
            }
            set
            {
                _coinName = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.CoinEntry> Select(int? coinID, string coinName)
        {
            return new CoinEntryFactory().Select(coinID, coinName);
        }
        
        public static List<MyCompany.Data.Objects.CoinEntry> Select(MyCompany.Data.Objects.CoinEntry qbe)
        {
            return new CoinEntryFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.CoinEntry> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new CoinEntryFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.CoinEntry> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new CoinEntryFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.CoinEntry> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new CoinEntryFactory().Select(filter, sort, CoinEntryFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.CoinEntry> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new CoinEntryFactory().Select(filter, sort, CoinEntryFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.CoinEntry> Select(string filter, BusinessObjectParameters parameters)
        {
            return new CoinEntryFactory().Select(filter, null, CoinEntryFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.CoinEntry> Select(string filter, params FieldValue[] parameters)
        {
            return new CoinEntryFactory().Select(filter, null, CoinEntryFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.CoinEntry SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new CoinEntryFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.CoinEntry SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new CoinEntryFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.CoinEntry SelectSingle(int? coinID)
        {
            return new CoinEntryFactory().SelectSingle(coinID);
        }
        
        public int Insert()
        {
            return new CoinEntryFactory().Insert(this);
        }
        
        public int Update()
        {
            return new CoinEntryFactory().Update(this);
        }
        
        public int Delete()
        {
            return new CoinEntryFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("CoinID: {0}", this.CoinID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class CoinEntryFactory
    {
        
        public CoinEntryFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("CoinEntry");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("CoinEntry");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("CoinEntry");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("CoinEntry");
            }
        }
        
        public static CoinEntryFactory Create()
        {
            return new CoinEntryFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? coinID, string coinName, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (coinID.HasValue)
            	filter.Add(("CoinID:=" + coinID.Value.ToString()));
            if (!(String.IsNullOrEmpty(coinName)))
            	filter.Add(("CoinName:*" + coinName));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.CoinEntry> Select(int? coinID, string coinName, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(coinID, coinName, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("CoinEntry", dataView, request);
            return page.ToList<MyCompany.Data.Objects.CoinEntry>();
        }
        
        public List<MyCompany.Data.Objects.CoinEntry> Select(MyCompany.Data.Objects.CoinEntry qbe)
        {
            return Select(qbe.CoinID, qbe.CoinName);
        }
        
        public int SelectCount(int? coinID, string coinName, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(coinID, coinName, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("CoinEntry", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.CoinEntry> Select(int? coinID, string coinName)
        {
            return Select(coinID, coinName, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.CoinEntry SelectSingle(int? coinID)
        {
            string emptyCoinName = null;
            List<MyCompany.Data.Objects.CoinEntry> list = Select(coinID, emptyCoinName);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.CoinEntry> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("CoinEntry", dataView, request);
            return page.ToList<MyCompany.Data.Objects.CoinEntry>();
        }
        
        public List<MyCompany.Data.Objects.CoinEntry> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.CoinEntry> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.CoinEntry SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.CoinEntry> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.CoinEntry theCoinEntry, MyCompany.Data.Objects.CoinEntry original_CoinEntry)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("CoinID", original_CoinEntry.CoinID, theCoinEntry.CoinID, true));
            values.Add(new FieldValue("CoinName", original_CoinEntry.CoinName, theCoinEntry.CoinName));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.CoinEntry theCoinEntry, MyCompany.Data.Objects.CoinEntry original_CoinEntry, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "CoinEntry";
            args.View = dataView;
            args.Values = CreateFieldValues(theCoinEntry, original_CoinEntry);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("CoinEntry", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theCoinEntry);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.CoinEntry theCoinEntry, MyCompany.Data.Objects.CoinEntry original_CoinEntry)
        {
            return ExecuteAction(theCoinEntry, original_CoinEntry, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.CoinEntry theCoinEntry)
        {
            return Update(theCoinEntry, SelectSingle(theCoinEntry.CoinID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.CoinEntry theCoinEntry)
        {
            return ExecuteAction(theCoinEntry, new CoinEntry(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.CoinEntry theCoinEntry)
        {
            return ExecuteAction(theCoinEntry, theCoinEntry, "Select", "Delete", DeleteView);
        }
    }
}
