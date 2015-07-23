using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class PDCReceiveDetails
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _slNO;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _pDCRNO;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _pDCRPDCNO;
        
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
        private int? _applicantId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _status;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _newButton;
        
        public PDCReceiveDetails()
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
        public int? ApplicantId
        {
            get
            {
                return _applicantId;
            }
            set
            {
                _applicantId = value;
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
        
        public static List<MyCompany.Data.Objects.PDCReceiveDetails> Select(
                    int? slNO, 
                    int? pDCRNO, 
                    string pDCRPDCNO, 
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
                    int? applicantId, 
                    bool? status, 
                    bool? newButton)
        {
            return new PDCReceiveDetailsFactory().Select(slNO, pDCRNO, pDCRPDCNO, pDCRPayeeAccSubName, pDCRPayeeAccSubTypeAccSubType, pDCRModeofReceiptDescription, pDCRPayCatCategory, chequeNo, chequeDate, amount, bankName, branchName, accountName, accountNumber, isCleared, applicantId, status, newButton);
        }
        
        public static List<MyCompany.Data.Objects.PDCReceiveDetails> Select(MyCompany.Data.Objects.PDCReceiveDetails qbe)
        {
            return new PDCReceiveDetailsFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.PDCReceiveDetails> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new PDCReceiveDetailsFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.PDCReceiveDetails> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new PDCReceiveDetailsFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.PDCReceiveDetails> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new PDCReceiveDetailsFactory().Select(filter, sort, PDCReceiveDetailsFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.PDCReceiveDetails> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new PDCReceiveDetailsFactory().Select(filter, sort, PDCReceiveDetailsFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.PDCReceiveDetails> Select(string filter, BusinessObjectParameters parameters)
        {
            return new PDCReceiveDetailsFactory().Select(filter, null, PDCReceiveDetailsFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.PDCReceiveDetails> Select(string filter, params FieldValue[] parameters)
        {
            return new PDCReceiveDetailsFactory().Select(filter, null, PDCReceiveDetailsFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.PDCReceiveDetails SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new PDCReceiveDetailsFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.PDCReceiveDetails SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new PDCReceiveDetailsFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.PDCReceiveDetails SelectSingle(int? slNO)
        {
            return new PDCReceiveDetailsFactory().SelectSingle(slNO);
        }
        
        public int Insert()
        {
            return new PDCReceiveDetailsFactory().Insert(this);
        }
        
        public int Update()
        {
            return new PDCReceiveDetailsFactory().Update(this);
        }
        
        public int Delete()
        {
            return new PDCReceiveDetailsFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("SlNO: {0}", this.SlNO);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class PDCReceiveDetailsFactory
    {
        
        public PDCReceiveDetailsFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("PDCReceiveDetails");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("PDCReceiveDetails");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("PDCReceiveDetails");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("PDCReceiveDetails");
            }
        }
        
        public static PDCReceiveDetailsFactory Create()
        {
            return new PDCReceiveDetailsFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    int? slNO, 
                    int? pDCRNO, 
                    string pDCRPDCNO, 
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
                    int? applicantId, 
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
            if (applicantId.HasValue)
            	filter.Add(("ApplicantId:=" + applicantId.Value.ToString()));
            if (status.HasValue)
            	filter.Add(("Status:=" + status.Value.ToString()));
            if (newButton.HasValue)
            	filter.Add(("NewButton:=" + newButton.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.PDCReceiveDetails> Select(
                    int? slNO, 
                    int? pDCRNO, 
                    string pDCRPDCNO, 
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
                    int? applicantId, 
                    bool? status, 
                    bool? newButton, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(slNO, pDCRNO, pDCRPDCNO, pDCRPayeeAccSubName, pDCRPayeeAccSubTypeAccSubType, pDCRModeofReceiptDescription, pDCRPayCatCategory, chequeNo, chequeDate, amount, bankName, branchName, accountName, accountNumber, isCleared, applicantId, status, newButton, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("PDCReceiveDetails", dataView, request);
            return page.ToList<MyCompany.Data.Objects.PDCReceiveDetails>();
        }
        
        public List<MyCompany.Data.Objects.PDCReceiveDetails> Select(MyCompany.Data.Objects.PDCReceiveDetails qbe)
        {
            return Select(qbe.SlNO, qbe.PDCRNO, qbe.PDCRPDCNO, qbe.PDCRPayeeAccSubName, qbe.PDCRPayeeAccSubTypeAccSubType, qbe.PDCRModeofReceiptDescription, qbe.PDCRPayCatCategory, qbe.ChequeNo, qbe.ChequeDate, qbe.Amount, qbe.BankName, qbe.BranchName, qbe.AccountName, qbe.AccountNumber, qbe.IsCleared, qbe.ApplicantId, qbe.Status, qbe.NewButton);
        }
        
        public int SelectCount(
                    int? slNO, 
                    int? pDCRNO, 
                    string pDCRPDCNO, 
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
                    int? applicantId, 
                    bool? status, 
                    bool? newButton, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(slNO, pDCRNO, pDCRPDCNO, pDCRPayeeAccSubName, pDCRPayeeAccSubTypeAccSubType, pDCRModeofReceiptDescription, pDCRPayCatCategory, chequeNo, chequeDate, amount, bankName, branchName, accountName, accountNumber, isCleared, applicantId, status, newButton, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("PDCReceiveDetails", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.PDCReceiveDetails> Select(
                    int? slNO, 
                    int? pDCRNO, 
                    string pDCRPDCNO, 
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
                    int? applicantId, 
                    bool? status, 
                    bool? newButton)
        {
            return Select(slNO, pDCRNO, pDCRPDCNO, pDCRPayeeAccSubName, pDCRPayeeAccSubTypeAccSubType, pDCRModeofReceiptDescription, pDCRPayCatCategory, chequeNo, chequeDate, amount, bankName, branchName, accountName, accountNumber, isCleared, applicantId, status, newButton, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.PDCReceiveDetails SelectSingle(int? slNO)
        {
            List<MyCompany.Data.Objects.PDCReceiveDetails> list = Select(slNO, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.PDCReceiveDetails> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("PDCReceiveDetails", dataView, request);
            return page.ToList<MyCompany.Data.Objects.PDCReceiveDetails>();
        }
        
        public List<MyCompany.Data.Objects.PDCReceiveDetails> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.PDCReceiveDetails> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.PDCReceiveDetails SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.PDCReceiveDetails> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.PDCReceiveDetails thePDCReceiveDetails, MyCompany.Data.Objects.PDCReceiveDetails original_PDCReceiveDetails)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("SlNO", original_PDCReceiveDetails.SlNO, thePDCReceiveDetails.SlNO, true));
            values.Add(new FieldValue("PDCRNO", original_PDCReceiveDetails.PDCRNO, thePDCReceiveDetails.PDCRNO));
            values.Add(new FieldValue("PDCRPDCNO", original_PDCReceiveDetails.PDCRPDCNO, thePDCReceiveDetails.PDCRPDCNO, true));
            values.Add(new FieldValue("PDCRPayeeAccSubName", original_PDCReceiveDetails.PDCRPayeeAccSubName, thePDCReceiveDetails.PDCRPayeeAccSubName, true));
            values.Add(new FieldValue("PDCRPayeeAccSubTypeAccSubType", original_PDCReceiveDetails.PDCRPayeeAccSubTypeAccSubType, thePDCReceiveDetails.PDCRPayeeAccSubTypeAccSubType, true));
            values.Add(new FieldValue("PDCRModeofReceiptDescription", original_PDCReceiveDetails.PDCRModeofReceiptDescription, thePDCReceiveDetails.PDCRModeofReceiptDescription, true));
            values.Add(new FieldValue("PDCRPayCatCategory", original_PDCReceiveDetails.PDCRPayCatCategory, thePDCReceiveDetails.PDCRPayCatCategory, true));
            values.Add(new FieldValue("ChequeNo", original_PDCReceiveDetails.ChequeNo, thePDCReceiveDetails.ChequeNo));
            values.Add(new FieldValue("ChequeDate", original_PDCReceiveDetails.ChequeDate, thePDCReceiveDetails.ChequeDate));
            values.Add(new FieldValue("Amount", original_PDCReceiveDetails.Amount, thePDCReceiveDetails.Amount));
            values.Add(new FieldValue("BankName", original_PDCReceiveDetails.BankName, thePDCReceiveDetails.BankName));
            values.Add(new FieldValue("BranchName", original_PDCReceiveDetails.BranchName, thePDCReceiveDetails.BranchName));
            values.Add(new FieldValue("AccountName", original_PDCReceiveDetails.AccountName, thePDCReceiveDetails.AccountName));
            values.Add(new FieldValue("AccountNumber", original_PDCReceiveDetails.AccountNumber, thePDCReceiveDetails.AccountNumber));
            values.Add(new FieldValue("IsCleared", original_PDCReceiveDetails.IsCleared, thePDCReceiveDetails.IsCleared));
            values.Add(new FieldValue("ApplicantId", original_PDCReceiveDetails.ApplicantId, thePDCReceiveDetails.ApplicantId));
            values.Add(new FieldValue("Status", original_PDCReceiveDetails.Status, thePDCReceiveDetails.Status));
            values.Add(new FieldValue("NewButton", original_PDCReceiveDetails.NewButton, thePDCReceiveDetails.NewButton));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.PDCReceiveDetails thePDCReceiveDetails, MyCompany.Data.Objects.PDCReceiveDetails original_PDCReceiveDetails, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "PDCReceiveDetails";
            args.View = dataView;
            args.Values = CreateFieldValues(thePDCReceiveDetails, original_PDCReceiveDetails);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("PDCReceiveDetails", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(thePDCReceiveDetails);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.PDCReceiveDetails thePDCReceiveDetails, MyCompany.Data.Objects.PDCReceiveDetails original_PDCReceiveDetails)
        {
            return ExecuteAction(thePDCReceiveDetails, original_PDCReceiveDetails, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.PDCReceiveDetails thePDCReceiveDetails)
        {
            return Update(thePDCReceiveDetails, SelectSingle(thePDCReceiveDetails.SlNO));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.PDCReceiveDetails thePDCReceiveDetails)
        {
            return ExecuteAction(thePDCReceiveDetails, new PDCReceiveDetails(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.PDCReceiveDetails thePDCReceiveDetails)
        {
            return ExecuteAction(thePDCReceiveDetails, thePDCReceiveDetails, "Select", "Delete", DeleteView);
        }
    }
}
