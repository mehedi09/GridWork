using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class AccBillRegisterD
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _regDetailsID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _regID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _regRegisterPrefix;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _registerNo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _perpose;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _remaks;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _amount;
        
        public AccBillRegisterD()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? RegDetailsID
        {
            get
            {
                return _regDetailsID;
            }
            set
            {
                _regDetailsID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? RegID
        {
            get
            {
                return _regID;
            }
            set
            {
                _regID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RegRegisterPrefix
        {
            get
            {
                return _regRegisterPrefix;
            }
            set
            {
                _regRegisterPrefix = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string RegisterNo
        {
            get
            {
                return _registerNo;
            }
            set
            {
                _registerNo = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Perpose
        {
            get
            {
                return _perpose;
            }
            set
            {
                _perpose = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Remaks
        {
            get
            {
                return _remaks;
            }
            set
            {
                _remaks = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public decimal? Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.AccBillRegisterD> Select(int? regDetailsID, int? regID, string regRegisterPrefix, string registerNo, string perpose, string remaks, decimal? amount)
        {
            return new AccBillRegisterDFactory().Select(regDetailsID, regID, regRegisterPrefix, registerNo, perpose, remaks, amount);
        }
        
        public static List<MyCompany.Data.Objects.AccBillRegisterD> Select(MyCompany.Data.Objects.AccBillRegisterD qbe)
        {
            return new AccBillRegisterDFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.AccBillRegisterD> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new AccBillRegisterDFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccBillRegisterD> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new AccBillRegisterDFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.AccBillRegisterD> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new AccBillRegisterDFactory().Select(filter, sort, AccBillRegisterDFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccBillRegisterD> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new AccBillRegisterDFactory().Select(filter, sort, AccBillRegisterDFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.AccBillRegisterD> Select(string filter, BusinessObjectParameters parameters)
        {
            return new AccBillRegisterDFactory().Select(filter, null, AccBillRegisterDFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccBillRegisterD> Select(string filter, params FieldValue[] parameters)
        {
            return new AccBillRegisterDFactory().Select(filter, null, AccBillRegisterDFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.AccBillRegisterD SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new AccBillRegisterDFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.AccBillRegisterD SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new AccBillRegisterDFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.AccBillRegisterD SelectSingle(int? regDetailsID)
        {
            return new AccBillRegisterDFactory().SelectSingle(regDetailsID);
        }
        
        public int Insert()
        {
            return new AccBillRegisterDFactory().Insert(this);
        }
        
        public int Update()
        {
            return new AccBillRegisterDFactory().Update(this);
        }
        
        public int Delete()
        {
            return new AccBillRegisterDFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("RegDetailsID: {0}", this.RegDetailsID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class AccBillRegisterDFactory
    {
        
        public AccBillRegisterDFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("AccBillRegisterD");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("AccBillRegisterD");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("AccBillRegisterD");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("AccBillRegisterD");
            }
        }
        
        public static AccBillRegisterDFactory Create()
        {
            return new AccBillRegisterDFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? regDetailsID, int? regID, string regRegisterPrefix, string registerNo, string perpose, string remaks, decimal? amount, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (regDetailsID.HasValue)
            	filter.Add(("RegDetailsID:=" + regDetailsID.Value.ToString()));
            if (regID.HasValue)
            	filter.Add(("RegID:=" + regID.Value.ToString()));
            if (!(String.IsNullOrEmpty(regRegisterPrefix)))
            	filter.Add(("RegRegisterPrefix:*" + regRegisterPrefix));
            if (!(String.IsNullOrEmpty(registerNo)))
            	filter.Add(("RegisterNo:*" + registerNo));
            if (!(String.IsNullOrEmpty(perpose)))
            	filter.Add(("Perpose:*" + perpose));
            if (!(String.IsNullOrEmpty(remaks)))
            	filter.Add(("Remaks:*" + remaks));
            if (amount.HasValue)
            	filter.Add(("Amount:=" + amount.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.AccBillRegisterD> Select(int? regDetailsID, int? regID, string regRegisterPrefix, string registerNo, string perpose, string remaks, decimal? amount, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(regDetailsID, regID, regRegisterPrefix, registerNo, perpose, remaks, amount, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("AccBillRegisterD", dataView, request);
            return page.ToList<MyCompany.Data.Objects.AccBillRegisterD>();
        }
        
        public List<MyCompany.Data.Objects.AccBillRegisterD> Select(MyCompany.Data.Objects.AccBillRegisterD qbe)
        {
            return Select(qbe.RegDetailsID, qbe.RegID, qbe.RegRegisterPrefix, qbe.RegisterNo, qbe.Perpose, qbe.Remaks, qbe.Amount);
        }
        
        public int SelectCount(int? regDetailsID, int? regID, string regRegisterPrefix, string registerNo, string perpose, string remaks, decimal? amount, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(regDetailsID, regID, regRegisterPrefix, registerNo, perpose, remaks, amount, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("AccBillRegisterD", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.AccBillRegisterD> Select(int? regDetailsID, int? regID, string regRegisterPrefix, string registerNo, string perpose, string remaks, decimal? amount)
        {
            return Select(regDetailsID, regID, regRegisterPrefix, registerNo, perpose, remaks, amount, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.AccBillRegisterD SelectSingle(int? regDetailsID)
        {
            List<MyCompany.Data.Objects.AccBillRegisterD> list = Select(regDetailsID, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.AccBillRegisterD> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("AccBillRegisterD", dataView, request);
            return page.ToList<MyCompany.Data.Objects.AccBillRegisterD>();
        }
        
        public List<MyCompany.Data.Objects.AccBillRegisterD> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.AccBillRegisterD> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.AccBillRegisterD SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.AccBillRegisterD> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.AccBillRegisterD theAccBillRegisterD, MyCompany.Data.Objects.AccBillRegisterD original_AccBillRegisterD)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("RegDetailsID", original_AccBillRegisterD.RegDetailsID, theAccBillRegisterD.RegDetailsID, true));
            values.Add(new FieldValue("RegID", original_AccBillRegisterD.RegID, theAccBillRegisterD.RegID));
            values.Add(new FieldValue("RegRegisterPrefix", original_AccBillRegisterD.RegRegisterPrefix, theAccBillRegisterD.RegRegisterPrefix, true));
            values.Add(new FieldValue("RegisterNo", original_AccBillRegisterD.RegisterNo, theAccBillRegisterD.RegisterNo));
            values.Add(new FieldValue("Perpose", original_AccBillRegisterD.Perpose, theAccBillRegisterD.Perpose));
            values.Add(new FieldValue("Remaks", original_AccBillRegisterD.Remaks, theAccBillRegisterD.Remaks));
            values.Add(new FieldValue("Amount", original_AccBillRegisterD.Amount, theAccBillRegisterD.Amount));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.AccBillRegisterD theAccBillRegisterD, MyCompany.Data.Objects.AccBillRegisterD original_AccBillRegisterD, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "AccBillRegisterD";
            args.View = dataView;
            args.Values = CreateFieldValues(theAccBillRegisterD, original_AccBillRegisterD);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("AccBillRegisterD", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theAccBillRegisterD);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.AccBillRegisterD theAccBillRegisterD, MyCompany.Data.Objects.AccBillRegisterD original_AccBillRegisterD)
        {
            return ExecuteAction(theAccBillRegisterD, original_AccBillRegisterD, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.AccBillRegisterD theAccBillRegisterD)
        {
            return Update(theAccBillRegisterD, SelectSingle(theAccBillRegisterD.RegDetailsID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.AccBillRegisterD theAccBillRegisterD)
        {
            return ExecuteAction(theAccBillRegisterD, new AccBillRegisterD(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.AccBillRegisterD theAccBillRegisterD)
        {
            return ExecuteAction(theAccBillRegisterD, theAccBillRegisterD, "Select", "Delete", DeleteView);
        }
    }
}
