using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class ImpresstFundCoins
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _tranDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _impFundNoteCntID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _coinName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _cointAmt;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _quantity;
        
        public ImpresstFundCoins()
        {
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? TranDate
        {
            get
            {
                return _tranDate;
            }
            set
            {
                _tranDate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? ImpFundNoteCntID
        {
            get
            {
                return _impFundNoteCntID;
            }
            set
            {
                _impFundNoteCntID = value;
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? CointAmt
        {
            get
            {
                return _cointAmt;
            }
            set
            {
                _cointAmt = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.ImpresstFundCoins> Select(DateTime? tranDate, int? impFundNoteCntID, string coinName, int? cointAmt, int? quantity)
        {
            return new ImpresstFundCoinsFactory().Select(tranDate, impFundNoteCntID, coinName, cointAmt, quantity);
        }
        
        public static List<MyCompany.Data.Objects.ImpresstFundCoins> Select(MyCompany.Data.Objects.ImpresstFundCoins qbe)
        {
            return new ImpresstFundCoinsFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.ImpresstFundCoins> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new ImpresstFundCoinsFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.ImpresstFundCoins> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new ImpresstFundCoinsFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.ImpresstFundCoins> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new ImpresstFundCoinsFactory().Select(filter, sort, ImpresstFundCoinsFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.ImpresstFundCoins> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new ImpresstFundCoinsFactory().Select(filter, sort, ImpresstFundCoinsFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.ImpresstFundCoins> Select(string filter, BusinessObjectParameters parameters)
        {
            return new ImpresstFundCoinsFactory().Select(filter, null, ImpresstFundCoinsFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.ImpresstFundCoins> Select(string filter, params FieldValue[] parameters)
        {
            return new ImpresstFundCoinsFactory().Select(filter, null, ImpresstFundCoinsFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.ImpresstFundCoins SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new ImpresstFundCoinsFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.ImpresstFundCoins SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new ImpresstFundCoinsFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.ImpresstFundCoins SelectSingle(int? impFundNoteCntID)
        {
            return new ImpresstFundCoinsFactory().SelectSingle(impFundNoteCntID);
        }
        
        public int Insert()
        {
            return new ImpresstFundCoinsFactory().Insert(this);
        }
        
        public int Update()
        {
            return new ImpresstFundCoinsFactory().Update(this);
        }
        
        public int Delete()
        {
            return new ImpresstFundCoinsFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("ImpFundNoteCntID: {0}", this.ImpFundNoteCntID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class ImpresstFundCoinsFactory
    {
        
        public ImpresstFundCoinsFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("ImpresstFundCoins");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("ImpresstFundCoins");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("ImpresstFundCoins");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("ImpresstFundCoins");
            }
        }
        
        public static ImpresstFundCoinsFactory Create()
        {
            return new ImpresstFundCoinsFactory();
        }
        
        protected virtual PageRequest CreateRequest(DateTime? tranDate, int? impFundNoteCntID, string coinName, int? cointAmt, int? quantity, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (tranDate.HasValue)
            	filter.Add(("TranDate:=" + tranDate.Value.ToString()));
            if (impFundNoteCntID.HasValue)
            	filter.Add(("ImpFundNoteCntID:=" + impFundNoteCntID.Value.ToString()));
            if (!(String.IsNullOrEmpty(coinName)))
            	filter.Add(("CoinName:*" + coinName));
            if (cointAmt.HasValue)
            	filter.Add(("CointAmt:=" + cointAmt.Value.ToString()));
            if (quantity.HasValue)
            	filter.Add(("Quantity:=" + quantity.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.ImpresstFundCoins> Select(DateTime? tranDate, int? impFundNoteCntID, string coinName, int? cointAmt, int? quantity, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(tranDate, impFundNoteCntID, coinName, cointAmt, quantity, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("ImpresstFundCoins", dataView, request);
            return page.ToList<MyCompany.Data.Objects.ImpresstFundCoins>();
        }
        
        public List<MyCompany.Data.Objects.ImpresstFundCoins> Select(MyCompany.Data.Objects.ImpresstFundCoins qbe)
        {
            return Select(qbe.TranDate, qbe.ImpFundNoteCntID, qbe.CoinName, qbe.CointAmt, qbe.Quantity);
        }
        
        public int SelectCount(DateTime? tranDate, int? impFundNoteCntID, string coinName, int? cointAmt, int? quantity, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(tranDate, impFundNoteCntID, coinName, cointAmt, quantity, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("ImpresstFundCoins", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.ImpresstFundCoins> Select(DateTime? tranDate, int? impFundNoteCntID, string coinName, int? cointAmt, int? quantity)
        {
            return Select(tranDate, impFundNoteCntID, coinName, cointAmt, quantity, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.ImpresstFundCoins SelectSingle(int? impFundNoteCntID)
        {
            List<MyCompany.Data.Objects.ImpresstFundCoins> list = Select(null, impFundNoteCntID, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.ImpresstFundCoins> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("ImpresstFundCoins", dataView, request);
            return page.ToList<MyCompany.Data.Objects.ImpresstFundCoins>();
        }
        
        public List<MyCompany.Data.Objects.ImpresstFundCoins> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.ImpresstFundCoins> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.ImpresstFundCoins SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.ImpresstFundCoins> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.ImpresstFundCoins theImpresstFundCoins, MyCompany.Data.Objects.ImpresstFundCoins original_ImpresstFundCoins)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("TranDate", original_ImpresstFundCoins.TranDate, theImpresstFundCoins.TranDate));
            values.Add(new FieldValue("ImpFundNoteCntID", original_ImpresstFundCoins.ImpFundNoteCntID, theImpresstFundCoins.ImpFundNoteCntID, true));
            values.Add(new FieldValue("CoinName", original_ImpresstFundCoins.CoinName, theImpresstFundCoins.CoinName));
            values.Add(new FieldValue("CointAmt", original_ImpresstFundCoins.CointAmt, theImpresstFundCoins.CointAmt));
            values.Add(new FieldValue("Quantity", original_ImpresstFundCoins.Quantity, theImpresstFundCoins.Quantity));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.ImpresstFundCoins theImpresstFundCoins, MyCompany.Data.Objects.ImpresstFundCoins original_ImpresstFundCoins, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "ImpresstFundCoins";
            args.View = dataView;
            args.Values = CreateFieldValues(theImpresstFundCoins, original_ImpresstFundCoins);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("ImpresstFundCoins", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theImpresstFundCoins);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.ImpresstFundCoins theImpresstFundCoins, MyCompany.Data.Objects.ImpresstFundCoins original_ImpresstFundCoins)
        {
            return ExecuteAction(theImpresstFundCoins, original_ImpresstFundCoins, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.ImpresstFundCoins theImpresstFundCoins)
        {
            return Update(theImpresstFundCoins, SelectSingle(theImpresstFundCoins.ImpFundNoteCntID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.ImpresstFundCoins theImpresstFundCoins)
        {
            return ExecuteAction(theImpresstFundCoins, new ImpresstFundCoins(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.ImpresstFundCoins theImpresstFundCoins)
        {
            return ExecuteAction(theImpresstFundCoins, theImpresstFundCoins, "Select", "Delete", DeleteView);
        }
    }
}
