using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class PDCReceive
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _pDCRID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _pDCType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _pDCNO;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _pDCPreFix;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _pDCDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _applicantId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _address;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _plotSaleID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _payCatID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _payCatCategory;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _modeofReceiptID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _modeofReceiptDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _chequeNo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _branchName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _amount;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isSameAmount;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _noOfPdc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _allotmentNo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _gname;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _gFathersname;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _gAddress;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _otherRemarks;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _displayAction;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accFundID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _payeeCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _payeeAccSubName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _payeeAccSubTypeAccSubType;
        
        public PDCReceive()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? PDCRID
        {
            get
            {
                return _pDCRID;
            }
            set
            {
                _pDCRID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? PDCType
        {
            get
            {
                return _pDCType;
            }
            set
            {
                _pDCType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PDCNO
        {
            get
            {
                return _pDCNO;
            }
            set
            {
                _pDCNO = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PDCPreFix
        {
            get
            {
                return _pDCPreFix;
            }
            set
            {
                _pDCPreFix = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? PDCDate
        {
            get
            {
                return _pDCDate;
            }
            set
            {
                _pDCDate = value;
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
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public long? PlotSaleID
        {
            get
            {
                return _plotSaleID;
            }
            set
            {
                _plotSaleID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? PayCatID
        {
            get
            {
                return _payCatID;
            }
            set
            {
                _payCatID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PayCatCategory
        {
            get
            {
                return _payCatCategory;
            }
            set
            {
                _payCatCategory = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? ModeofReceiptID
        {
            get
            {
                return _modeofReceiptID;
            }
            set
            {
                _modeofReceiptID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ModeofReceiptDescription
        {
            get
            {
                return _modeofReceiptDescription;
            }
            set
            {
                _modeofReceiptDescription = value;
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public bool? IsSameAmount
        {
            get
            {
                return _isSameAmount;
            }
            set
            {
                _isSameAmount = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NoOfPdc
        {
            get
            {
                return _noOfPdc;
            }
            set
            {
                _noOfPdc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string allotmentNo
        {
            get
            {
                return _allotmentNo;
            }
            set
            {
                _allotmentNo = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Gname
        {
            get
            {
                return _gname;
            }
            set
            {
                _gname = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string GFathersname
        {
            get
            {
                return _gFathersname;
            }
            set
            {
                _gFathersname = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string GAddress
        {
            get
            {
                return _gAddress;
            }
            set
            {
                _gAddress = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OtherRemarks
        {
            get
            {
                return _otherRemarks;
            }
            set
            {
                _otherRemarks = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? DisplayAction
        {
            get
            {
                return _displayAction;
            }
            set
            {
                _displayAction = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? AccFundID
        {
            get
            {
                return _accFundID;
            }
            set
            {
                _accFundID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? PayeeCode
        {
            get
            {
                return _payeeCode;
            }
            set
            {
                _payeeCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PayeeAccSubName
        {
            get
            {
                return _payeeAccSubName;
            }
            set
            {
                _payeeAccSubName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PayeeAccSubTypeAccSubType
        {
            get
            {
                return _payeeAccSubTypeAccSubType;
            }
            set
            {
                _payeeAccSubTypeAccSubType = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.PDCReceive> Select(
                    int? pDCRID, 
                    bool? pDCType, 
                    string pDCNO, 
                    string pDCPreFix, 
                    DateTime? pDCDate, 
                    int? applicantId, 
                    string address, 
                    long? plotSaleID, 
                    int? payCatID, 
                    string payCatCategory, 
                    int? modeofReceiptID, 
                    string modeofReceiptDescription, 
                    string chequeNo, 
                    string bankName, 
                    string branchName, 
                    decimal? amount, 
                    bool? isSameAmount, 
                    string noOfPdc, 
                    string allotmentNo, 
                    string gname, 
                    string gFathersname, 
                    string gAddress, 
                    string otherRemarks, 
                    bool? displayAction, 
                    int? accFundID, 
                    int? payeeCode, 
                    string payeeAccSubName, 
                    string payeeAccSubTypeAccSubType)
        {
            return new PDCReceiveFactory().Select(pDCRID, pDCType, pDCNO, pDCPreFix, pDCDate, applicantId, address, plotSaleID, payCatID, payCatCategory, modeofReceiptID, modeofReceiptDescription, chequeNo, bankName, branchName, amount, isSameAmount, noOfPdc, allotmentNo, gname, gFathersname, gAddress, otherRemarks, displayAction, accFundID, payeeCode, payeeAccSubName, payeeAccSubTypeAccSubType);
        }
        
        public static List<MyCompany.Data.Objects.PDCReceive> Select(MyCompany.Data.Objects.PDCReceive qbe)
        {
            return new PDCReceiveFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.PDCReceive> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new PDCReceiveFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.PDCReceive> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new PDCReceiveFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.PDCReceive> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new PDCReceiveFactory().Select(filter, sort, PDCReceiveFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.PDCReceive> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new PDCReceiveFactory().Select(filter, sort, PDCReceiveFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.PDCReceive> Select(string filter, BusinessObjectParameters parameters)
        {
            return new PDCReceiveFactory().Select(filter, null, PDCReceiveFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.PDCReceive> Select(string filter, params FieldValue[] parameters)
        {
            return new PDCReceiveFactory().Select(filter, null, PDCReceiveFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.PDCReceive SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new PDCReceiveFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.PDCReceive SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new PDCReceiveFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.PDCReceive SelectSingle(int? pDCRID)
        {
            return new PDCReceiveFactory().SelectSingle(pDCRID);
        }
        
        public int Insert()
        {
            return new PDCReceiveFactory().Insert(this);
        }
        
        public int Update()
        {
            return new PDCReceiveFactory().Update(this);
        }
        
        public int Delete()
        {
            return new PDCReceiveFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("PDCRID: {0}", this.PDCRID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class PDCReceiveFactory
    {
        
        public PDCReceiveFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("PDCReceive");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("PDCReceive");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("PDCReceive");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("PDCReceive");
            }
        }
        
        public static PDCReceiveFactory Create()
        {
            return new PDCReceiveFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    int? pDCRID, 
                    bool? pDCType, 
                    string pDCNO, 
                    string pDCPreFix, 
                    DateTime? pDCDate, 
                    int? applicantId, 
                    string address, 
                    long? plotSaleID, 
                    int? payCatID, 
                    string payCatCategory, 
                    int? modeofReceiptID, 
                    string modeofReceiptDescription, 
                    string chequeNo, 
                    string bankName, 
                    string branchName, 
                    decimal? amount, 
                    bool? isSameAmount, 
                    string noOfPdc, 
                    string allotmentNo, 
                    string gname, 
                    string gFathersname, 
                    string gAddress, 
                    string otherRemarks, 
                    bool? displayAction, 
                    int? accFundID, 
                    int? payeeCode, 
                    string payeeAccSubName, 
                    string payeeAccSubTypeAccSubType, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (pDCRID.HasValue)
            	filter.Add(("PDCRID:=" + pDCRID.Value.ToString()));
            if (pDCType.HasValue)
            	filter.Add(("PDCType:=" + pDCType.Value.ToString()));
            if (!(String.IsNullOrEmpty(pDCNO)))
            	filter.Add(("PDCNO:*" + pDCNO));
            if (!(String.IsNullOrEmpty(pDCPreFix)))
            	filter.Add(("PDCPreFix:*" + pDCPreFix));
            if (pDCDate.HasValue)
            	filter.Add(("PDCDate:=" + pDCDate.Value.ToString()));
            if (applicantId.HasValue)
            	filter.Add(("ApplicantId:=" + applicantId.Value.ToString()));
            if (!(String.IsNullOrEmpty(address)))
            	filter.Add(("Address:*" + address));
            if (plotSaleID.HasValue)
            	filter.Add(("PlotSaleID:=" + plotSaleID.Value.ToString()));
            if (payCatID.HasValue)
            	filter.Add(("PayCatID:=" + payCatID.Value.ToString()));
            if (!(String.IsNullOrEmpty(payCatCategory)))
            	filter.Add(("PayCatCategory:*" + payCatCategory));
            if (modeofReceiptID.HasValue)
            	filter.Add(("ModeofReceiptID:=" + modeofReceiptID.Value.ToString()));
            if (!(String.IsNullOrEmpty(modeofReceiptDescription)))
            	filter.Add(("ModeofReceiptDescription:*" + modeofReceiptDescription));
            if (!(String.IsNullOrEmpty(chequeNo)))
            	filter.Add(("ChequeNo:*" + chequeNo));
            if (!(String.IsNullOrEmpty(bankName)))
            	filter.Add(("BankName:*" + bankName));
            if (!(String.IsNullOrEmpty(branchName)))
            	filter.Add(("BranchName:*" + branchName));
            if (amount.HasValue)
            	filter.Add(("Amount:=" + amount.Value.ToString()));
            if (isSameAmount.HasValue)
            	filter.Add(("IsSameAmount:=" + isSameAmount.Value.ToString()));
            if (!(String.IsNullOrEmpty(noOfPdc)))
            	filter.Add(("NoOfPdc:*" + noOfPdc));
            if (!(String.IsNullOrEmpty(allotmentNo)))
            	filter.Add(("allotmentNo:*" + allotmentNo));
            if (!(String.IsNullOrEmpty(gname)))
            	filter.Add(("Gname:*" + gname));
            if (!(String.IsNullOrEmpty(gFathersname)))
            	filter.Add(("GFathersname:*" + gFathersname));
            if (!(String.IsNullOrEmpty(gAddress)))
            	filter.Add(("GAddress:*" + gAddress));
            if (!(String.IsNullOrEmpty(otherRemarks)))
            	filter.Add(("OtherRemarks:*" + otherRemarks));
            if (displayAction.HasValue)
            	filter.Add(("DisplayAction:=" + displayAction.Value.ToString()));
            if (accFundID.HasValue)
            	filter.Add(("AccFundID:=" + accFundID.Value.ToString()));
            if (payeeCode.HasValue)
            	filter.Add(("PayeeCode:=" + payeeCode.Value.ToString()));
            if (!(String.IsNullOrEmpty(payeeAccSubName)))
            	filter.Add(("PayeeAccSubName:*" + payeeAccSubName));
            if (!(String.IsNullOrEmpty(payeeAccSubTypeAccSubType)))
            	filter.Add(("PayeeAccSubTypeAccSubType:*" + payeeAccSubTypeAccSubType));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.PDCReceive> Select(
                    int? pDCRID, 
                    bool? pDCType, 
                    string pDCNO, 
                    string pDCPreFix, 
                    DateTime? pDCDate, 
                    int? applicantId, 
                    string address, 
                    long? plotSaleID, 
                    int? payCatID, 
                    string payCatCategory, 
                    int? modeofReceiptID, 
                    string modeofReceiptDescription, 
                    string chequeNo, 
                    string bankName, 
                    string branchName, 
                    decimal? amount, 
                    bool? isSameAmount, 
                    string noOfPdc, 
                    string allotmentNo, 
                    string gname, 
                    string gFathersname, 
                    string gAddress, 
                    string otherRemarks, 
                    bool? displayAction, 
                    int? accFundID, 
                    int? payeeCode, 
                    string payeeAccSubName, 
                    string payeeAccSubTypeAccSubType, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(pDCRID, pDCType, pDCNO, pDCPreFix, pDCDate, applicantId, address, plotSaleID, payCatID, payCatCategory, modeofReceiptID, modeofReceiptDescription, chequeNo, bankName, branchName, amount, isSameAmount, noOfPdc, allotmentNo, gname, gFathersname, gAddress, otherRemarks, displayAction, accFundID, payeeCode, payeeAccSubName, payeeAccSubTypeAccSubType, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("PDCReceive", dataView, request);
            return page.ToList<MyCompany.Data.Objects.PDCReceive>();
        }
        
        public List<MyCompany.Data.Objects.PDCReceive> Select(MyCompany.Data.Objects.PDCReceive qbe)
        {
            return Select(qbe.PDCRID, qbe.PDCType, qbe.PDCNO, qbe.PDCPreFix, qbe.PDCDate, qbe.ApplicantId, qbe.Address, qbe.PlotSaleID, qbe.PayCatID, qbe.PayCatCategory, qbe.ModeofReceiptID, qbe.ModeofReceiptDescription, qbe.ChequeNo, qbe.BankName, qbe.BranchName, qbe.Amount, qbe.IsSameAmount, qbe.NoOfPdc, qbe.allotmentNo, qbe.Gname, qbe.GFathersname, qbe.GAddress, qbe.OtherRemarks, qbe.DisplayAction, qbe.AccFundID, qbe.PayeeCode, qbe.PayeeAccSubName, qbe.PayeeAccSubTypeAccSubType);
        }
        
        public int SelectCount(
                    int? pDCRID, 
                    bool? pDCType, 
                    string pDCNO, 
                    string pDCPreFix, 
                    DateTime? pDCDate, 
                    int? applicantId, 
                    string address, 
                    long? plotSaleID, 
                    int? payCatID, 
                    string payCatCategory, 
                    int? modeofReceiptID, 
                    string modeofReceiptDescription, 
                    string chequeNo, 
                    string bankName, 
                    string branchName, 
                    decimal? amount, 
                    bool? isSameAmount, 
                    string noOfPdc, 
                    string allotmentNo, 
                    string gname, 
                    string gFathersname, 
                    string gAddress, 
                    string otherRemarks, 
                    bool? displayAction, 
                    int? accFundID, 
                    int? payeeCode, 
                    string payeeAccSubName, 
                    string payeeAccSubTypeAccSubType, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(pDCRID, pDCType, pDCNO, pDCPreFix, pDCDate, applicantId, address, plotSaleID, payCatID, payCatCategory, modeofReceiptID, modeofReceiptDescription, chequeNo, bankName, branchName, amount, isSameAmount, noOfPdc, allotmentNo, gname, gFathersname, gAddress, otherRemarks, displayAction, accFundID, payeeCode, payeeAccSubName, payeeAccSubTypeAccSubType, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("PDCReceive", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.PDCReceive> Select(
                    int? pDCRID, 
                    bool? pDCType, 
                    string pDCNO, 
                    string pDCPreFix, 
                    DateTime? pDCDate, 
                    int? applicantId, 
                    string address, 
                    long? plotSaleID, 
                    int? payCatID, 
                    string payCatCategory, 
                    int? modeofReceiptID, 
                    string modeofReceiptDescription, 
                    string chequeNo, 
                    string bankName, 
                    string branchName, 
                    decimal? amount, 
                    bool? isSameAmount, 
                    string noOfPdc, 
                    string allotmentNo, 
                    string gname, 
                    string gFathersname, 
                    string gAddress, 
                    string otherRemarks, 
                    bool? displayAction, 
                    int? accFundID, 
                    int? payeeCode, 
                    string payeeAccSubName, 
                    string payeeAccSubTypeAccSubType)
        {
            return Select(pDCRID, pDCType, pDCNO, pDCPreFix, pDCDate, applicantId, address, plotSaleID, payCatID, payCatCategory, modeofReceiptID, modeofReceiptDescription, chequeNo, bankName, branchName, amount, isSameAmount, noOfPdc, allotmentNo, gname, gFathersname, gAddress, otherRemarks, displayAction, accFundID, payeeCode, payeeAccSubName, payeeAccSubTypeAccSubType, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.PDCReceive SelectSingle(int? pDCRID)
        {
            List<MyCompany.Data.Objects.PDCReceive> list = Select(pDCRID, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.PDCReceive> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("PDCReceive", dataView, request);
            return page.ToList<MyCompany.Data.Objects.PDCReceive>();
        }
        
        public List<MyCompany.Data.Objects.PDCReceive> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.PDCReceive> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.PDCReceive SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.PDCReceive> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.PDCReceive thePDCReceive, MyCompany.Data.Objects.PDCReceive original_PDCReceive)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("PDCRID", original_PDCReceive.PDCRID, thePDCReceive.PDCRID, true));
            values.Add(new FieldValue("PDCType", original_PDCReceive.PDCType, thePDCReceive.PDCType));
            values.Add(new FieldValue("PDCNO", original_PDCReceive.PDCNO, thePDCReceive.PDCNO));
            values.Add(new FieldValue("PDCPreFix", original_PDCReceive.PDCPreFix, thePDCReceive.PDCPreFix));
            values.Add(new FieldValue("PDCDate", original_PDCReceive.PDCDate, thePDCReceive.PDCDate));
            values.Add(new FieldValue("ApplicantId", original_PDCReceive.ApplicantId, thePDCReceive.ApplicantId));
            values.Add(new FieldValue("Address", original_PDCReceive.Address, thePDCReceive.Address));
            values.Add(new FieldValue("PlotSaleID", original_PDCReceive.PlotSaleID, thePDCReceive.PlotSaleID));
            values.Add(new FieldValue("PayCatID", original_PDCReceive.PayCatID, thePDCReceive.PayCatID));
            values.Add(new FieldValue("PayCatCategory", original_PDCReceive.PayCatCategory, thePDCReceive.PayCatCategory, true));
            values.Add(new FieldValue("ModeofReceiptID", original_PDCReceive.ModeofReceiptID, thePDCReceive.ModeofReceiptID));
            values.Add(new FieldValue("ModeofReceiptDescription", original_PDCReceive.ModeofReceiptDescription, thePDCReceive.ModeofReceiptDescription, true));
            values.Add(new FieldValue("ChequeNo", original_PDCReceive.ChequeNo, thePDCReceive.ChequeNo));
            values.Add(new FieldValue("BankName", original_PDCReceive.BankName, thePDCReceive.BankName));
            values.Add(new FieldValue("BranchName", original_PDCReceive.BranchName, thePDCReceive.BranchName));
            values.Add(new FieldValue("Amount", original_PDCReceive.Amount, thePDCReceive.Amount));
            values.Add(new FieldValue("IsSameAmount", original_PDCReceive.IsSameAmount, thePDCReceive.IsSameAmount));
            values.Add(new FieldValue("NoOfPdc", original_PDCReceive.NoOfPdc, thePDCReceive.NoOfPdc));
            values.Add(new FieldValue("allotmentNo", original_PDCReceive.allotmentNo, thePDCReceive.allotmentNo));
            values.Add(new FieldValue("Gname", original_PDCReceive.Gname, thePDCReceive.Gname));
            values.Add(new FieldValue("GFathersname", original_PDCReceive.GFathersname, thePDCReceive.GFathersname));
            values.Add(new FieldValue("GAddress", original_PDCReceive.GAddress, thePDCReceive.GAddress));
            values.Add(new FieldValue("OtherRemarks", original_PDCReceive.OtherRemarks, thePDCReceive.OtherRemarks));
            values.Add(new FieldValue("DisplayAction", original_PDCReceive.DisplayAction, thePDCReceive.DisplayAction));
            values.Add(new FieldValue("AccFundID", original_PDCReceive.AccFundID, thePDCReceive.AccFundID));
            values.Add(new FieldValue("PayeeCode", original_PDCReceive.PayeeCode, thePDCReceive.PayeeCode));
            values.Add(new FieldValue("PayeeAccSubName", original_PDCReceive.PayeeAccSubName, thePDCReceive.PayeeAccSubName, true));
            values.Add(new FieldValue("PayeeAccSubTypeAccSubType", original_PDCReceive.PayeeAccSubTypeAccSubType, thePDCReceive.PayeeAccSubTypeAccSubType, true));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.PDCReceive thePDCReceive, MyCompany.Data.Objects.PDCReceive original_PDCReceive, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "PDCReceive";
            args.View = dataView;
            args.Values = CreateFieldValues(thePDCReceive, original_PDCReceive);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("PDCReceive", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(thePDCReceive);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.PDCReceive thePDCReceive, MyCompany.Data.Objects.PDCReceive original_PDCReceive)
        {
            return ExecuteAction(thePDCReceive, original_PDCReceive, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.PDCReceive thePDCReceive)
        {
            return Update(thePDCReceive, SelectSingle(thePDCReceive.PDCRID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.PDCReceive thePDCReceive)
        {
            return ExecuteAction(thePDCReceive, new PDCReceive(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.PDCReceive thePDCReceive)
        {
            return ExecuteAction(thePDCReceive, thePDCReceive, "Select", "Delete", DeleteView);
        }
    }
}
