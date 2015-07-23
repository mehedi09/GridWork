using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class ImpresstFundCoinsview
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
        
        public ImpresstFundCoinsview()
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
        
        public static List<MyCompany.Data.Objects.ImpresstFundCoinsview> Select(DateTime? tranDate, int? impFundNoteCntID, string coinName, int? cointAmt, int? quantity)
        {
            return new ImpresstFundCoinsviewFactory().Select(tranDate, impFundNoteCntID, coinName, cointAmt, quantity);
        }
        
        public static List<MyCompany.Data.Objects.ImpresstFundCoinsview> Select(MyCompany.Data.Objects.ImpresstFundCoinsview qbe)
        {
            return new ImpresstFundCoinsviewFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.ImpresstFundCoinsview> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new ImpresstFundCoinsviewFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.ImpresstFundCoinsview> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new ImpresstFundCoinsviewFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.ImpresstFundCoinsview> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new ImpresstFundCoinsviewFactory().Select(filter, sort, ImpresstFundCoinsviewFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.ImpresstFundCoinsview> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new ImpresstFundCoinsviewFactory().Select(filter, sort, ImpresstFundCoinsviewFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.ImpresstFundCoinsview> Select(string filter, BusinessObjectParameters parameters)
        {
            return new ImpresstFundCoinsviewFactory().Select(filter, null, ImpresstFundCoinsviewFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.ImpresstFundCoinsview> Select(string filter, params FieldValue[] parameters)
        {
            return new ImpresstFundCoinsviewFactory().Select(filter, null, ImpresstFundCoinsviewFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.ImpresstFundCoinsview SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new ImpresstFundCoinsviewFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.ImpresstFundCoinsview SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new ImpresstFundCoinsviewFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.ImpresstFundCoinsview SelectSingle(int? impFundNoteCntID)
        {
            return new ImpresstFundCoinsviewFactory().SelectSingle(impFundNoteCntID);
        }
        
        public int Insert()
        {
            return new ImpresstFundCoinsviewFactory().Insert(this);
        }
        
        public int Update()
        {
            return new ImpresstFundCoinsviewFactory().Update(this);
        }
        
        public int Delete()
        {
            return new ImpresstFundCoinsviewFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("ImpFundNoteCntID: {0}", this.ImpFundNoteCntID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class ImpresstFundCoinsviewFactory
    {
        
        public ImpresstFundCoinsviewFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("ImpresstFundCoinsview");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("ImpresstFundCoinsview");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("ImpresstFundCoinsview");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("ImpresstFundCoinsview");
            }
        }
        
        public static ImpresstFundCoinsviewFactory Create()
        {
            return new ImpresstFundCoinsviewFactory();
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
        public List<MyCompany.Data.Objects.ImpresstFundCoinsview> Select(DateTime? tranDate, int? impFundNoteCntID, string coinName, int? cointAmt, int? quantity, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(tranDate, impFundNoteCntID, coinName, cointAmt, quantity, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("ImpresstFundCoinsview", dataView, request);
            return page.ToList<MyCompany.Data.Objects.ImpresstFundCoinsview>();
        }
        
        public List<MyCompany.Data.Objects.ImpresstFundCoinsview> Select(MyCompany.Data.Objects.ImpresstFundCoinsview qbe)
        {
            return Select(qbe.TranDate, qbe.ImpFundNoteCntID, qbe.CoinName, qbe.CointAmt, qbe.Quantity);
        }
        
        public int SelectCount(DateTime? tranDate, int? impFundNoteCntID, string coinName, int? cointAmt, int? quantity, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(tranDate, impFundNoteCntID, coinName, cointAmt, quantity, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("ImpresstFundCoinsview", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.ImpresstFundCoinsview> Select(DateTime? tranDate, int? impFundNoteCntID, string coinName, int? cointAmt, int? quantity)
        {
            return Select(tranDate, impFundNoteCntID, coinName, cointAmt, quantity, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.ImpresstFundCoinsview SelectSingle(int? impFundNoteCntID)
        {
            List<MyCompany.Data.Objects.ImpresstFundCoinsview> list = Select(null, impFundNoteCntID, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.ImpresstFundCoinsview> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("ImpresstFundCoinsview", dataView, request);
            return page.ToList<MyCompany.Data.Objects.ImpresstFundCoinsview>();
        }
        
        public List<MyCompany.Data.Objects.ImpresstFundCoinsview> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.ImpresstFundCoinsview> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.ImpresstFundCoinsview SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.ImpresstFundCoinsview> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.ImpresstFundCoinsview theImpresstFundCoinsview, MyCompany.Data.Objects.ImpresstFundCoinsview original_ImpresstFundCoinsview)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("TranDate", original_ImpresstFundCoinsview.TranDate, theImpresstFundCoinsview.TranDate));
            values.Add(new FieldValue("ImpFundNoteCntID", original_ImpresstFundCoinsview.ImpFundNoteCntID, theImpresstFundCoinsview.ImpFundNoteCntID, true));
            values.Add(new FieldValue("CoinName", original_ImpresstFundCoinsview.CoinName, theImpresstFundCoinsview.CoinName));
            values.Add(new FieldValue("CointAmt", original_ImpresstFundCoinsview.CointAmt, theImpresstFundCoinsview.CointAmt));
            values.Add(new FieldValue("Quantity", original_ImpresstFundCoinsview.Quantity, theImpresstFundCoinsview.Quantity));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.ImpresstFundCoinsview theImpresstFundCoinsview, MyCompany.Data.Objects.ImpresstFundCoinsview original_ImpresstFundCoinsview, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "ImpresstFundCoinsview";
            args.View = dataView;
            args.Values = CreateFieldValues(theImpresstFundCoinsview, original_ImpresstFundCoinsview);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("ImpresstFundCoinsview", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theImpresstFundCoinsview);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.ImpresstFundCoinsview theImpresstFundCoinsview, MyCompany.Data.Objects.ImpresstFundCoinsview original_ImpresstFundCoinsview)
        {
            return ExecuteAction(theImpresstFundCoinsview, original_ImpresstFundCoinsview, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.ImpresstFundCoinsview theImpresstFundCoinsview)
        {
            return Update(theImpresstFundCoinsview, SelectSingle(theImpresstFundCoinsview.ImpFundNoteCntID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.ImpresstFundCoinsview theImpresstFundCoinsview)
        {
            return ExecuteAction(theImpresstFundCoinsview, new ImpresstFundCoinsview(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.ImpresstFundCoinsview theImpresstFundCoinsview)
        {
            return ExecuteAction(theImpresstFundCoinsview, theImpresstFundCoinsview, "Select", "Delete", DeleteView);
        }
    }
}
