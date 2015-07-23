using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class AccBillRegisterH
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _regID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _registerPrefix;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _registerNo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _registerDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _billEmployee;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accVoucherTranID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _preparedBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _preparedDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _approvedBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _approvedDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _remarks;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _status;
        
        public AccBillRegisterH()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
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
        public string RegisterPrefix
        {
            get
            {
                return _registerPrefix;
            }
            set
            {
                _registerPrefix = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
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
        public DateTime? RegisterDate
        {
            get
            {
                return _registerDate;
            }
            set
            {
                _registerDate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? BillEmployee
        {
            get
            {
                return _billEmployee;
            }
            set
            {
                _billEmployee = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? AccVoucherTranID
        {
            get
            {
                return _accVoucherTranID;
            }
            set
            {
                _accVoucherTranID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? PreparedBy
        {
            get
            {
                return _preparedBy;
            }
            set
            {
                _preparedBy = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? PreparedDate
        {
            get
            {
                return _preparedDate;
            }
            set
            {
                _preparedDate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? ApprovedBy
        {
            get
            {
                return _approvedBy;
            }
            set
            {
                _approvedBy = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? ApprovedDate
        {
            get
            {
                return _approvedDate;
            }
            set
            {
                _approvedDate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Remarks
        {
            get
            {
                return _remarks;
            }
            set
            {
                _remarks = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.AccBillRegisterH> Select(int? regID, string registerPrefix, string registerNo, DateTime? registerDate, int? billEmployee, int? accVoucherTranID, int? preparedBy, DateTime? preparedDate, int? approvedBy, DateTime? approvedDate, string remarks, string status)
        {
            return new AccBillRegisterHFactory().Select(regID, registerPrefix, registerNo, registerDate, billEmployee, accVoucherTranID, preparedBy, preparedDate, approvedBy, approvedDate, remarks, status);
        }
        
        public static List<MyCompany.Data.Objects.AccBillRegisterH> Select(MyCompany.Data.Objects.AccBillRegisterH qbe)
        {
            return new AccBillRegisterHFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.AccBillRegisterH> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new AccBillRegisterHFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccBillRegisterH> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new AccBillRegisterHFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.AccBillRegisterH> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new AccBillRegisterHFactory().Select(filter, sort, AccBillRegisterHFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccBillRegisterH> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new AccBillRegisterHFactory().Select(filter, sort, AccBillRegisterHFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.AccBillRegisterH> Select(string filter, BusinessObjectParameters parameters)
        {
            return new AccBillRegisterHFactory().Select(filter, null, AccBillRegisterHFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccBillRegisterH> Select(string filter, params FieldValue[] parameters)
        {
            return new AccBillRegisterHFactory().Select(filter, null, AccBillRegisterHFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.AccBillRegisterH SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new AccBillRegisterHFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.AccBillRegisterH SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new AccBillRegisterHFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.AccBillRegisterH SelectSingle(int? regID)
        {
            return new AccBillRegisterHFactory().SelectSingle(regID);
        }
        
        public int Insert()
        {
            return new AccBillRegisterHFactory().Insert(this);
        }
        
        public int Update()
        {
            return new AccBillRegisterHFactory().Update(this);
        }
        
        public int Delete()
        {
            return new AccBillRegisterHFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("RegID: {0}", this.RegID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class AccBillRegisterHFactory
    {
        
        public AccBillRegisterHFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("AccBillRegisterH");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("AccBillRegisterH");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("AccBillRegisterH");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("AccBillRegisterH");
            }
        }
        
        public static AccBillRegisterHFactory Create()
        {
            return new AccBillRegisterHFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? regID, string registerPrefix, string registerNo, DateTime? registerDate, int? billEmployee, int? accVoucherTranID, int? preparedBy, DateTime? preparedDate, int? approvedBy, DateTime? approvedDate, string remarks, string status, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (regID.HasValue)
            	filter.Add(("RegID:=" + regID.Value.ToString()));
            if (!(String.IsNullOrEmpty(registerPrefix)))
            	filter.Add(("RegisterPrefix:*" + registerPrefix));
            if (!(String.IsNullOrEmpty(registerNo)))
            	filter.Add(("RegisterNo:*" + registerNo));
            if (registerDate.HasValue)
            	filter.Add(("RegisterDate:=" + registerDate.Value.ToString()));
            if (billEmployee.HasValue)
            	filter.Add(("BillEmployee:=" + billEmployee.Value.ToString()));
            if (accVoucherTranID.HasValue)
            	filter.Add(("AccVoucherTranID:=" + accVoucherTranID.Value.ToString()));
            if (preparedBy.HasValue)
            	filter.Add(("PreparedBy:=" + preparedBy.Value.ToString()));
            if (preparedDate.HasValue)
            	filter.Add(("PreparedDate:=" + preparedDate.Value.ToString()));
            if (approvedBy.HasValue)
            	filter.Add(("ApprovedBy:=" + approvedBy.Value.ToString()));
            if (approvedDate.HasValue)
            	filter.Add(("ApprovedDate:=" + approvedDate.Value.ToString()));
            if (!(String.IsNullOrEmpty(remarks)))
            	filter.Add(("Remarks:*" + remarks));
            if (!(String.IsNullOrEmpty(status)))
            	filter.Add(("Status:*" + status));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.AccBillRegisterH> Select(
                    int? regID, 
                    string registerPrefix, 
                    string registerNo, 
                    DateTime? registerDate, 
                    int? billEmployee, 
                    int? accVoucherTranID, 
                    int? preparedBy, 
                    DateTime? preparedDate, 
                    int? approvedBy, 
                    DateTime? approvedDate, 
                    string remarks, 
                    string status, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(regID, registerPrefix, registerNo, registerDate, billEmployee, accVoucherTranID, preparedBy, preparedDate, approvedBy, approvedDate, remarks, status, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("AccBillRegisterH", dataView, request);
            return page.ToList<MyCompany.Data.Objects.AccBillRegisterH>();
        }
        
        public List<MyCompany.Data.Objects.AccBillRegisterH> Select(MyCompany.Data.Objects.AccBillRegisterH qbe)
        {
            return Select(qbe.RegID, qbe.RegisterPrefix, qbe.RegisterNo, qbe.RegisterDate, qbe.BillEmployee, qbe.AccVoucherTranID, qbe.PreparedBy, qbe.PreparedDate, qbe.ApprovedBy, qbe.ApprovedDate, qbe.Remarks, qbe.Status);
        }
        
        public int SelectCount(
                    int? regID, 
                    string registerPrefix, 
                    string registerNo, 
                    DateTime? registerDate, 
                    int? billEmployee, 
                    int? accVoucherTranID, 
                    int? preparedBy, 
                    DateTime? preparedDate, 
                    int? approvedBy, 
                    DateTime? approvedDate, 
                    string remarks, 
                    string status, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(regID, registerPrefix, registerNo, registerDate, billEmployee, accVoucherTranID, preparedBy, preparedDate, approvedBy, approvedDate, remarks, status, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("AccBillRegisterH", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.AccBillRegisterH> Select(int? regID, string registerPrefix, string registerNo, DateTime? registerDate, int? billEmployee, int? accVoucherTranID, int? preparedBy, DateTime? preparedDate, int? approvedBy, DateTime? approvedDate, string remarks, string status)
        {
            return Select(regID, registerPrefix, registerNo, registerDate, billEmployee, accVoucherTranID, preparedBy, preparedDate, approvedBy, approvedDate, remarks, status, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.AccBillRegisterH SelectSingle(int? regID)
        {
            List<MyCompany.Data.Objects.AccBillRegisterH> list = Select(regID, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.AccBillRegisterH> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("AccBillRegisterH", dataView, request);
            return page.ToList<MyCompany.Data.Objects.AccBillRegisterH>();
        }
        
        public List<MyCompany.Data.Objects.AccBillRegisterH> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.AccBillRegisterH> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.AccBillRegisterH SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.AccBillRegisterH> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.AccBillRegisterH theAccBillRegisterH, MyCompany.Data.Objects.AccBillRegisterH original_AccBillRegisterH)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("RegID", original_AccBillRegisterH.RegID, theAccBillRegisterH.RegID, true));
            values.Add(new FieldValue("RegisterPrefix", original_AccBillRegisterH.RegisterPrefix, theAccBillRegisterH.RegisterPrefix));
            values.Add(new FieldValue("RegisterNo", original_AccBillRegisterH.RegisterNo, theAccBillRegisterH.RegisterNo));
            values.Add(new FieldValue("RegisterDate", original_AccBillRegisterH.RegisterDate, theAccBillRegisterH.RegisterDate));
            values.Add(new FieldValue("BillEmployee", original_AccBillRegisterH.BillEmployee, theAccBillRegisterH.BillEmployee));
            values.Add(new FieldValue("AccVoucherTranID", original_AccBillRegisterH.AccVoucherTranID, theAccBillRegisterH.AccVoucherTranID));
            values.Add(new FieldValue("PreparedBy", original_AccBillRegisterH.PreparedBy, theAccBillRegisterH.PreparedBy));
            values.Add(new FieldValue("PreparedDate", original_AccBillRegisterH.PreparedDate, theAccBillRegisterH.PreparedDate));
            values.Add(new FieldValue("ApprovedBy", original_AccBillRegisterH.ApprovedBy, theAccBillRegisterH.ApprovedBy));
            values.Add(new FieldValue("ApprovedDate", original_AccBillRegisterH.ApprovedDate, theAccBillRegisterH.ApprovedDate));
            values.Add(new FieldValue("Remarks", original_AccBillRegisterH.Remarks, theAccBillRegisterH.Remarks));
            values.Add(new FieldValue("Status", original_AccBillRegisterH.Status, theAccBillRegisterH.Status));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.AccBillRegisterH theAccBillRegisterH, MyCompany.Data.Objects.AccBillRegisterH original_AccBillRegisterH, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "AccBillRegisterH";
            args.View = dataView;
            args.Values = CreateFieldValues(theAccBillRegisterH, original_AccBillRegisterH);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("AccBillRegisterH", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theAccBillRegisterH);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.AccBillRegisterH theAccBillRegisterH, MyCompany.Data.Objects.AccBillRegisterH original_AccBillRegisterH)
        {
            return ExecuteAction(theAccBillRegisterH, original_AccBillRegisterH, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.AccBillRegisterH theAccBillRegisterH)
        {
            return Update(theAccBillRegisterH, SelectSingle(theAccBillRegisterH.RegID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.AccBillRegisterH theAccBillRegisterH)
        {
            return ExecuteAction(theAccBillRegisterH, new AccBillRegisterH(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.AccBillRegisterH theAccBillRegisterH)
        {
            return ExecuteAction(theAccBillRegisterH, theAccBillRegisterH, "Select", "Delete", DeleteView);
        }
    }
}
