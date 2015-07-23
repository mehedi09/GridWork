using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class PDCIssueDetails
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _slNO;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _pDCRNO;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _pDCRPDCNO;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _pDCRAccFundAccFundName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _pDCRPayeeAccSubName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _pDCRPayeeAccSubTypeAccSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _pDCRModeofReceiptDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _pDCRPayCatCategory;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _chequeNo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _chequeDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _amount;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _branchName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accountName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accountNumber;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isCleared;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _status;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _newButton;
        
        public PDCIssueDetails()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? SlNO
        {
            get
            {
                return _slNO;
            }
            set
            {
                _slNO = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? PDCRNO
        {
            get
            {
                return _pDCRNO;
            }
            set
            {
                _pDCRNO = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PDCRPDCNO
        {
            get
            {
                return _pDCRPDCNO;
            }
            set
            {
                _pDCRPDCNO = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PDCRAccFundAccFundName
        {
            get
            {
                return _pDCRAccFundAccFundName;
            }
            set
            {
                _pDCRAccFundAccFundName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PDCRPayeeAccSubName
        {
            get
            {
                return _pDCRPayeeAccSubName;
            }
            set
            {
                _pDCRPayeeAccSubName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PDCRPayeeAccSubTypeAccSubType
        {
            get
            {
                return _pDCRPayeeAccSubTypeAccSubType;
            }
            set
            {
                _pDCRPayeeAccSubTypeAccSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PDCRModeofReceiptDescription
        {
            get
            {
                return _pDCRModeofReceiptDescription;
            }
            set
            {
                _pDCRModeofReceiptDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PDCRPayCatCategory
        {
            get
            {
                return _pDCRPayCatCategory;
            }
            set
            {
                _pDCRPayCatCategory = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ChequeNo
        {
            get
            {
                return _chequeNo;
            }
            set
            {
                _chequeNo = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? ChequeDate
        {
            get
            {
                return _chequeDate;
            }
            set
            {
                _chequeDate = value;
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankName
        {
            get
            {
                return _bankName;
            }
            set
            {
                _bankName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BranchName
        {
            get
            {
                return _branchName;
            }
            set
            {
                _branchName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccountName
        {
            get
            {
                return _accountName;
            }
            set
            {
                _accountName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccountNumber
        {
            get
            {
                return _accountNumber;
            }
            set
            {
                _accountNumber = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public bool? IsCleared
        {
            get
            {
                return _isCleared;
            }
            set
            {
                _isCleared = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? Status
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? NewButton
        {
            get
            {
                return _newButton;
            }
            set
            {
                _newButton = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.PDCIssueDetails> Select(
                    int? slNO, 
                    int? pDCRNO, 
                    string pDCRPDCNO, 
                    string pDCRAccFundAccFundName, 
                    string pDCRPayeeAccSubName, 
                    string pDCRPayeeAccSubTypeAccSubType, 
                    string pDCRModeofReceiptDescription, 
                    string pDCRPayCatCategory, 
                    string chequeNo, 
                    DateTime? chequeDate, 
                    decimal? amount, 
                    string bankName, 
                    string branchName, 
                    string accountName, 
                    string accountNumber, 
                    bool? isCleared, 
                    bool? status, 
                    bool? newButton)
        {
            return new PDCIssueDetailsFactory().Select(slNO, pDCRNO, pDCRPDCNO, pDCRAccFundAccFundName, pDCRPayeeAccSubName, pDCRPayeeAccSubTypeAccSubType, pDCRModeofReceiptDescription, pDCRPayCatCategory, chequeNo, chequeDate, amount, bankName, branchName, accountName, accountNumber, isCleared, status, newButton);
        }
        
        public static List<MyCompany.Data.Objects.PDCIssueDetails> Select(MyCompany.Data.Objects.PDCIssueDetails qbe)
        {
            return new PDCIssueDetailsFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.PDCIssueDetails> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new PDCIssueDetailsFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.PDCIssueDetails> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new PDCIssueDetailsFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.PDCIssueDetails> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new PDCIssueDetailsFactory().Select(filter, sort, PDCIssueDetailsFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.PDCIssueDetails> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new PDCIssueDetailsFactory().Select(filter, sort, PDCIssueDetailsFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.PDCIssueDetails> Select(string filter, BusinessObjectParameters parameters)
        {
            return new PDCIssueDetailsFactory().Select(filter, null, PDCIssueDetailsFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.PDCIssueDetails> Select(string filter, params FieldValue[] parameters)
        {
            return new PDCIssueDetailsFactory().Select(filter, null, PDCIssueDetailsFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.PDCIssueDetails SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new PDCIssueDetailsFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.PDCIssueDetails SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new PDCIssueDetailsFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.PDCIssueDetails SelectSingle(int? slNO)
        {
            return new PDCIssueDetailsFactory().SelectSingle(slNO);
        }
        
        public int Insert()
        {
            return new PDCIssueDetailsFactory().Insert(this);
        }
        
        public int Update()
        {
            return new PDCIssueDetailsFactory().Update(this);
        }
        
        public int Delete()
        {
            return new PDCIssueDetailsFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("SlNO: {0}", this.SlNO);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class PDCIssueDetailsFactory
    {
        
        public PDCIssueDetailsFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("PDCIssueDetails");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("PDCIssueDetails");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("PDCIssueDetails");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("PDCIssueDetails");
            }
        }
        
        public static PDCIssueDetailsFactory Create()
        {
            return new PDCIssueDetailsFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    int? slNO, 
                    int? pDCRNO, 
                    string pDCRPDCNO, 
                    string pDCRAccFundAccFundName, 
                    string pDCRPayeeAccSubName, 
                    string pDCRPayeeAccSubTypeAccSubType, 
                    string pDCRModeofReceiptDescription, 
                    string pDCRPayCatCategory, 
                    string chequeNo, 
                    DateTime? chequeDate, 
                    decimal? amount, 
                    string bankName, 
                    string branchName, 
                    string accountName, 
                    string accountNumber, 
                    bool? isCleared, 
                    bool? status, 
                    bool? newButton, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (slNO.HasValue)
            	filter.Add(("SlNO:=" + slNO.Value.ToString()));
            if (pDCRNO.HasValue)
            	filter.Add(("PDCRNO:=" + pDCRNO.Value.ToString()));
            if (!(String.IsNullOrEmpty(pDCRPDCNO)))
            	filter.Add(("PDCRPDCNO:*" + pDCRPDCNO));
            if (!(String.IsNullOrEmpty(pDCRAccFundAccFundName)))
            	filter.Add(("PDCRAccFundAccFundName:*" + pDCRAccFundAccFundName));
            if (!(String.IsNullOrEmpty(pDCRPayeeAccSubName)))
            	filter.Add(("PDCRPayeeAccSubName:*" + pDCRPayeeAccSubName));
            if (!(String.IsNullOrEmpty(pDCRPayeeAccSubTypeAccSubType)))
            	filter.Add(("PDCRPayeeAccSubTypeAccSubType:*" + pDCRPayeeAccSubTypeAccSubType));
            if (!(String.IsNullOrEmpty(pDCRModeofReceiptDescription)))
            	filter.Add(("PDCRModeofReceiptDescription:*" + pDCRModeofReceiptDescription));
            if (!(String.IsNullOrEmpty(pDCRPayCatCategory)))
            	filter.Add(("PDCRPayCatCategory:*" + pDCRPayCatCategory));
            if (!(String.IsNullOrEmpty(chequeNo)))
            	filter.Add(("ChequeNo:*" + chequeNo));
            if (chequeDate.HasValue)
            	filter.Add(("ChequeDate:=" + chequeDate.Value.ToString()));
            if (amount.HasValue)
            	filter.Add(("Amount:=" + amount.Value.ToString()));
            if (!(String.IsNullOrEmpty(bankName)))
            	filter.Add(("BankName:*" + bankName));
            if (!(String.IsNullOrEmpty(branchName)))
            	filter.Add(("BranchName:*" + branchName));
            if (!(String.IsNullOrEmpty(accountName)))
            	filter.Add(("AccountName:*" + accountName));
            if (!(String.IsNullOrEmpty(accountNumber)))
            	filter.Add(("AccountNumber:*" + accountNumber));
            if (isCleared.HasValue)
            	filter.Add(("IsCleared:=" + isCleared.Value.ToString()));
            if (status.HasValue)
            	filter.Add(("Status:=" + status.Value.ToString()));
            if (newButton.HasValue)
            	filter.Add(("NewButton:=" + newButton.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.PDCIssueDetails> Select(
                    int? slNO, 
                    int? pDCRNO, 
                    string pDCRPDCNO, 
                    string pDCRAccFundAccFundName, 
                    string pDCRPayeeAccSubName, 
                    string pDCRPayeeAccSubTypeAccSubType, 
                    string pDCRModeofReceiptDescription, 
                    string pDCRPayCatCategory, 
                    string chequeNo, 
                    DateTime? chequeDate, 
                    decimal? amount, 
                    string bankName, 
                    string branchName, 
                    string accountName, 
                    string accountNumber, 
                    bool? isCleared, 
                    bool? status, 
                    bool? newButton, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(slNO, pDCRNO, pDCRPDCNO, pDCRAccFundAccFundName, pDCRPayeeAccSubName, pDCRPayeeAccSubTypeAccSubType, pDCRModeofReceiptDescription, pDCRPayCatCategory, chequeNo, chequeDate, amount, bankName, branchName, accountName, accountNumber, isCleared, status, newButton, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("PDCIssueDetails", dataView, request);
            return page.ToList<MyCompany.Data.Objects.PDCIssueDetails>();
        }
        
        public List<MyCompany.Data.Objects.PDCIssueDetails> Select(MyCompany.Data.Objects.PDCIssueDetails qbe)
        {
            return Select(qbe.SlNO, qbe.PDCRNO, qbe.PDCRPDCNO, qbe.PDCRAccFundAccFundName, qbe.PDCRPayeeAccSubName, qbe.PDCRPayeeAccSubTypeAccSubType, qbe.PDCRModeofReceiptDescription, qbe.PDCRPayCatCategory, qbe.ChequeNo, qbe.ChequeDate, qbe.Amount, qbe.BankName, qbe.BranchName, qbe.AccountName, qbe.AccountNumber, qbe.IsCleared, qbe.Status, qbe.NewButton);
        }
        
        public int SelectCount(
                    int? slNO, 
                    int? pDCRNO, 
                    string pDCRPDCNO, 
                    string pDCRAccFundAccFundName, 
                    string pDCRPayeeAccSubName, 
                    string pDCRPayeeAccSubTypeAccSubType, 
                    string pDCRModeofReceiptDescription, 
                    string pDCRPayCatCategory, 
                    string chequeNo, 
                    DateTime? chequeDate, 
                    decimal? amount, 
                    string bankName, 
                    string branchName, 
                    string accountName, 
                    string accountNumber, 
                    bool? isCleared, 
                    bool? status, 
                    bool? newButton, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(slNO, pDCRNO, pDCRPDCNO, pDCRAccFundAccFundName, pDCRPayeeAccSubName, pDCRPayeeAccSubTypeAccSubType, pDCRModeofReceiptDescription, pDCRPayCatCategory, chequeNo, chequeDate, amount, bankName, branchName, accountName, accountNumber, isCleared, status, newButton, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("PDCIssueDetails", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.PDCIssueDetails> Select(
                    int? slNO, 
                    int? pDCRNO, 
                    string pDCRPDCNO, 
                    string pDCRAccFundAccFundName, 
                    string pDCRPayeeAccSubName, 
                    string pDCRPayeeAccSubTypeAccSubType, 
                    string pDCRModeofReceiptDescription, 
                    string pDCRPayCatCategory, 
                    string chequeNo, 
                    DateTime? chequeDate, 
                    decimal? amount, 
                    string bankName, 
                    string branchName, 
                    string accountName, 
                    string accountNumber, 
                    bool? isCleared, 
                    bool? status, 
                    bool? newButton)
        {
            return Select(slNO, pDCRNO, pDCRPDCNO, pDCRAccFundAccFundName, pDCRPayeeAccSubName, pDCRPayeeAccSubTypeAccSubType, pDCRModeofReceiptDescription, pDCRPayCatCategory, chequeNo, chequeDate, amount, bankName, branchName, accountName, accountNumber, isCleared, status, newButton, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.PDCIssueDetails SelectSingle(int? slNO)
        {
            List<MyCompany.Data.Objects.PDCIssueDetails> list = Select(slNO, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.PDCIssueDetails> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("PDCIssueDetails", dataView, request);
            return page.ToList<MyCompany.Data.Objects.PDCIssueDetails>();
        }
        
        public List<MyCompany.Data.Objects.PDCIssueDetails> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.PDCIssueDetails> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.PDCIssueDetails SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.PDCIssueDetails> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.PDCIssueDetails thePDCIssueDetails, MyCompany.Data.Objects.PDCIssueDetails original_PDCIssueDetails)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("SlNO", original_PDCIssueDetails.SlNO, thePDCIssueDetails.SlNO, true));
            values.Add(new FieldValue("PDCRNO", original_PDCIssueDetails.PDCRNO, thePDCIssueDetails.PDCRNO));
            values.Add(new FieldValue("PDCRPDCNO", original_PDCIssueDetails.PDCRPDCNO, thePDCIssueDetails.PDCRPDCNO, true));
            values.Add(new FieldValue("PDCRAccFundAccFundName", original_PDCIssueDetails.PDCRAccFundAccFundName, thePDCIssueDetails.PDCRAccFundAccFundName, true));
            values.Add(new FieldValue("PDCRPayeeAccSubName", original_PDCIssueDetails.PDCRPayeeAccSubName, thePDCIssueDetails.PDCRPayeeAccSubName, true));
            values.Add(new FieldValue("PDCRPayeeAccSubTypeAccSubType", original_PDCIssueDetails.PDCRPayeeAccSubTypeAccSubType, thePDCIssueDetails.PDCRPayeeAccSubTypeAccSubType, true));
            values.Add(new FieldValue("PDCRModeofReceiptDescription", original_PDCIssueDetails.PDCRModeofReceiptDescription, thePDCIssueDetails.PDCRModeofReceiptDescription, true));
            values.Add(new FieldValue("PDCRPayCatCategory", original_PDCIssueDetails.PDCRPayCatCategory, thePDCIssueDetails.PDCRPayCatCategory, true));
            values.Add(new FieldValue("ChequeNo", original_PDCIssueDetails.ChequeNo, thePDCIssueDetails.ChequeNo));
            values.Add(new FieldValue("ChequeDate", original_PDCIssueDetails.ChequeDate, thePDCIssueDetails.ChequeDate));
            values.Add(new FieldValue("Amount", original_PDCIssueDetails.Amount, thePDCIssueDetails.Amount));
            values.Add(new FieldValue("BankName", original_PDCIssueDetails.BankName, thePDCIssueDetails.BankName));
            values.Add(new FieldValue("BranchName", original_PDCIssueDetails.BranchName, thePDCIssueDetails.BranchName));
            values.Add(new FieldValue("AccountName", original_PDCIssueDetails.AccountName, thePDCIssueDetails.AccountName));
            values.Add(new FieldValue("AccountNumber", original_PDCIssueDetails.AccountNumber, thePDCIssueDetails.AccountNumber));
            values.Add(new FieldValue("IsCleared", original_PDCIssueDetails.IsCleared, thePDCIssueDetails.IsCleared));
            values.Add(new FieldValue("Status", original_PDCIssueDetails.Status, thePDCIssueDetails.Status));
            values.Add(new FieldValue("NewButton", original_PDCIssueDetails.NewButton, thePDCIssueDetails.NewButton));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.PDCIssueDetails thePDCIssueDetails, MyCompany.Data.Objects.PDCIssueDetails original_PDCIssueDetails, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "PDCIssueDetails";
            args.View = dataView;
            args.Values = CreateFieldValues(thePDCIssueDetails, original_PDCIssueDetails);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("PDCIssueDetails", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(thePDCIssueDetails);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.PDCIssueDetails thePDCIssueDetails, MyCompany.Data.Objects.PDCIssueDetails original_PDCIssueDetails)
        {
            return ExecuteAction(thePDCIssueDetails, original_PDCIssueDetails, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.PDCIssueDetails thePDCIssueDetails)
        {
            return Update(thePDCIssueDetails, SelectSingle(thePDCIssueDetails.SlNO));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.PDCIssueDetails thePDCIssueDetails)
        {
            return ExecuteAction(thePDCIssueDetails, new PDCIssueDetails(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.PDCIssueDetails thePDCIssueDetails)
        {
            return ExecuteAction(thePDCIssueDetails, thePDCIssueDetails, "Select", "Delete", DeleteView);
        }
    }
}
