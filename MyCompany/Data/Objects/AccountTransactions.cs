using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class AccountTransactions
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _transactionID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _vchrTypesID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _vchrNumber;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _vchrPreFix;
        
        public AccountTransactions()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public int? TransactionID
        {
            get
            {
                return _transactionID;
            }
            set
            {
                _transactionID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? AccFundCode
        {
            get
            {
                return _accFundCode;
            }
            set
            {
                _accFundCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? VchrTypesID
        {
            get
            {
                return _vchrTypesID;
            }
            set
            {
                _vchrTypesID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string VchrNumber
        {
            get
            {
                return _vchrNumber;
            }
            set
            {
                _vchrNumber = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string VchrPreFix
        {
            get
            {
                return _vchrPreFix;
            }
            set
            {
                _vchrPreFix = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.AccountTransactions> Select(int? transactionID, int? accFundCode, int? vchrTypesID, string vchrNumber, string vchrPreFix)
        {
            return new AccountTransactionsFactory().Select(transactionID, accFundCode, vchrTypesID, vchrNumber, vchrPreFix);
        }
        
        public static List<MyCompany.Data.Objects.AccountTransactions> Select(MyCompany.Data.Objects.AccountTransactions qbe)
        {
            return new AccountTransactionsFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.AccountTransactions> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new AccountTransactionsFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccountTransactions> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new AccountTransactionsFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.AccountTransactions> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new AccountTransactionsFactory().Select(filter, sort, AccountTransactionsFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccountTransactions> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new AccountTransactionsFactory().Select(filter, sort, AccountTransactionsFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.AccountTransactions> Select(string filter, BusinessObjectParameters parameters)
        {
            return new AccountTransactionsFactory().Select(filter, null, AccountTransactionsFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccountTransactions> Select(string filter, params FieldValue[] parameters)
        {
            return new AccountTransactionsFactory().Select(filter, null, AccountTransactionsFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.AccountTransactions SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new AccountTransactionsFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.AccountTransactions SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new AccountTransactionsFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.AccountTransactions SelectSingle(int? transactionID)
        {
            return new AccountTransactionsFactory().SelectSingle(transactionID);
        }
        
        public int Insert()
        {
            return new AccountTransactionsFactory().Insert(this);
        }
        
        public int Update()
        {
            return new AccountTransactionsFactory().Update(this);
        }
        
        public int Delete()
        {
            return new AccountTransactionsFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("TransactionID: {0}", this.TransactionID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class AccountTransactionsFactory
    {
        
        public AccountTransactionsFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("AccountTransactions");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("AccountTransactions");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("AccountTransactions");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("AccountTransactions");
            }
        }
        
        public static AccountTransactionsFactory Create()
        {
            return new AccountTransactionsFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? transactionID, int? accFundCode, int? vchrTypesID, string vchrNumber, string vchrPreFix, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (transactionID.HasValue)
            	filter.Add(("TransactionID:=" + transactionID.Value.ToString()));
            if (accFundCode.HasValue)
            	filter.Add(("AccFundCode:=" + accFundCode.Value.ToString()));
            if (vchrTypesID.HasValue)
            	filter.Add(("VchrTypesID:=" + vchrTypesID.Value.ToString()));
            if (!(String.IsNullOrEmpty(vchrNumber)))
            	filter.Add(("VchrNumber:*" + vchrNumber));
            if (!(String.IsNullOrEmpty(vchrPreFix)))
            	filter.Add(("VchrPreFix:*" + vchrPreFix));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.AccountTransactions> Select(int? transactionID, int? accFundCode, int? vchrTypesID, string vchrNumber, string vchrPreFix, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(transactionID, accFundCode, vchrTypesID, vchrNumber, vchrPreFix, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("AccountTransactions", dataView, request);
            return page.ToList<MyCompany.Data.Objects.AccountTransactions>();
        }
        
        public List<MyCompany.Data.Objects.AccountTransactions> Select(MyCompany.Data.Objects.AccountTransactions qbe)
        {
            return Select(qbe.TransactionID, qbe.AccFundCode, qbe.VchrTypesID, qbe.VchrNumber, qbe.VchrPreFix);
        }
        
        public int SelectCount(int? transactionID, int? accFundCode, int? vchrTypesID, string vchrNumber, string vchrPreFix, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(transactionID, accFundCode, vchrTypesID, vchrNumber, vchrPreFix, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("AccountTransactions", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.AccountTransactions> Select(int? transactionID, int? accFundCode, int? vchrTypesID, string vchrNumber, string vchrPreFix)
        {
            return Select(transactionID, accFundCode, vchrTypesID, vchrNumber, vchrPreFix, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.AccountTransactions SelectSingle(int? transactionID)
        {
            List<MyCompany.Data.Objects.AccountTransactions> list = Select(transactionID, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.AccountTransactions> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("AccountTransactions", dataView, request);
            return page.ToList<MyCompany.Data.Objects.AccountTransactions>();
        }
        
        public List<MyCompany.Data.Objects.AccountTransactions> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.AccountTransactions> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.AccountTransactions SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.AccountTransactions> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.AccountTransactions theAccountTransactions, MyCompany.Data.Objects.AccountTransactions original_AccountTransactions)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("TransactionID", original_AccountTransactions.TransactionID, theAccountTransactions.TransactionID));
            values.Add(new FieldValue("AccFundCode", original_AccountTransactions.AccFundCode, theAccountTransactions.AccFundCode));
            values.Add(new FieldValue("VchrTypesID", original_AccountTransactions.VchrTypesID, theAccountTransactions.VchrTypesID));
            values.Add(new FieldValue("VchrNumber", original_AccountTransactions.VchrNumber, theAccountTransactions.VchrNumber));
            values.Add(new FieldValue("VchrPreFix", original_AccountTransactions.VchrPreFix, theAccountTransactions.VchrPreFix));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.AccountTransactions theAccountTransactions, MyCompany.Data.Objects.AccountTransactions original_AccountTransactions, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "AccountTransactions";
            args.View = dataView;
            args.Values = CreateFieldValues(theAccountTransactions, original_AccountTransactions);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("AccountTransactions", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theAccountTransactions);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.AccountTransactions theAccountTransactions, MyCompany.Data.Objects.AccountTransactions original_AccountTransactions)
        {
            return ExecuteAction(theAccountTransactions, original_AccountTransactions, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.AccountTransactions theAccountTransactions)
        {
            return Update(theAccountTransactions, SelectSingle(theAccountTransactions.TransactionID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.AccountTransactions theAccountTransactions)
        {
            return ExecuteAction(theAccountTransactions, new AccountTransactions(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.AccountTransactions theAccountTransactions)
        {
            return ExecuteAction(theAccountTransactions, theAccountTransactions, "Select", "Delete", DeleteView);
        }
    }
}
