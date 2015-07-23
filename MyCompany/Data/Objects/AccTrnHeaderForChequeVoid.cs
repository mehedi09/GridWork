using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class AccTrnHeaderForChequeVoid
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _accVoucherTranID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accFundAccFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _vchrTypesID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _vchrNumber;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accTranRef;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _refNo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _accTranDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _paidTo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accRemarks;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _yrClosing;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _voucher_Check;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _voucher_EditBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _voucher_EditTime;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _voucher_InstBy;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _voucher_InstTime;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private byte? _dLT;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _vchrType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accUnitCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _vchrPreFix;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _vNO;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _costCenterID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _financialYearID;
        
        public AccTrnHeaderForChequeVoid()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public long? AccVoucherTranID
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
        public string AccFundAccFundCode
        {
            get
            {
                return _accFundAccFundCode;
            }
            set
            {
                _accFundAccFundCode = value;
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
        public string AccTranRef
        {
            get
            {
                return _accTranRef;
            }
            set
            {
                _accTranRef = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RefNo
        {
            get
            {
                return _refNo;
            }
            set
            {
                _refNo = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public DateTime? AccTranDate
        {
            get
            {
                return _accTranDate;
            }
            set
            {
                _accTranDate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PaidTo
        {
            get
            {
                return _paidTo;
            }
            set
            {
                _paidTo = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccRemarks
        {
            get
            {
                return _accRemarks;
            }
            set
            {
                _accRemarks = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? YrClosing
        {
            get
            {
                return _yrClosing;
            }
            set
            {
                _yrClosing = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? Voucher_Check
        {
            get
            {
                return _voucher_Check;
            }
            set
            {
                _voucher_Check = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Voucher_EditBy
        {
            get
            {
                return _voucher_EditBy;
            }
            set
            {
                _voucher_EditBy = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? Voucher_EditTime
        {
            get
            {
                return _voucher_EditTime;
            }
            set
            {
                _voucher_EditTime = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Voucher_InstBy
        {
            get
            {
                return _voucher_InstBy;
            }
            set
            {
                _voucher_InstBy = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? Voucher_InstTime
        {
            get
            {
                return _voucher_InstTime;
            }
            set
            {
                _voucher_InstTime = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public byte? DLT
        {
            get
            {
                return _dLT;
            }
            set
            {
                _dLT = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string VchrType
        {
            get
            {
                return _vchrType;
            }
            set
            {
                _vchrType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? AccUnitCode
        {
            get
            {
                return _accUnitCode;
            }
            set
            {
                _accUnitCode = value;
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public long? VNO
        {
            get
            {
                return _vNO;
            }
            set
            {
                _vNO = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? CostCenterID
        {
            get
            {
                return _costCenterID;
            }
            set
            {
                _costCenterID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? FinancialYearID
        {
            get
            {
                return _financialYearID;
            }
            set
            {
                _financialYearID = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.AccTrnHeaderForChequeVoid> Select(
                    long? accVoucherTranID, 
                    int? accFundCode, 
                    string accFundAccFundCode, 
                    int? vchrTypesID, 
                    string vchrNumber, 
                    string accTranRef, 
                    string refNo, 
                    DateTime? accTranDate, 
                    string paidTo, 
                    string accRemarks, 
                    int? yrClosing, 
                    bool? voucher_Check, 
                    string voucher_EditBy, 
                    DateTime? voucher_EditTime, 
                    string voucher_InstBy, 
                    DateTime? voucher_InstTime, 
                    byte? dLT, 
                    string vchrType, 
                    int? accUnitCode, 
                    string vchrPreFix, 
                    long? vNO, 
                    int? costCenterID, 
                    int? financialYearID)
        {
            return new AccTrnHeaderForChequeVoidFactory().Select(accVoucherTranID, accFundCode, accFundAccFundCode, vchrTypesID, vchrNumber, accTranRef, refNo, accTranDate, paidTo, accRemarks, yrClosing, voucher_Check, voucher_EditBy, voucher_EditTime, voucher_InstBy, voucher_InstTime, dLT, vchrType, accUnitCode, vchrPreFix, vNO, costCenterID, financialYearID);
        }
        
        public static List<MyCompany.Data.Objects.AccTrnHeaderForChequeVoid> Select(MyCompany.Data.Objects.AccTrnHeaderForChequeVoid qbe)
        {
            return new AccTrnHeaderForChequeVoidFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.AccTrnHeaderForChequeVoid> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new AccTrnHeaderForChequeVoidFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccTrnHeaderForChequeVoid> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new AccTrnHeaderForChequeVoidFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.AccTrnHeaderForChequeVoid> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new AccTrnHeaderForChequeVoidFactory().Select(filter, sort, AccTrnHeaderForChequeVoidFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccTrnHeaderForChequeVoid> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new AccTrnHeaderForChequeVoidFactory().Select(filter, sort, AccTrnHeaderForChequeVoidFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.AccTrnHeaderForChequeVoid> Select(string filter, BusinessObjectParameters parameters)
        {
            return new AccTrnHeaderForChequeVoidFactory().Select(filter, null, AccTrnHeaderForChequeVoidFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccTrnHeaderForChequeVoid> Select(string filter, params FieldValue[] parameters)
        {
            return new AccTrnHeaderForChequeVoidFactory().Select(filter, null, AccTrnHeaderForChequeVoidFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.AccTrnHeaderForChequeVoid SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new AccTrnHeaderForChequeVoidFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.AccTrnHeaderForChequeVoid SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new AccTrnHeaderForChequeVoidFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.AccTrnHeaderForChequeVoid SelectSingle(long? accVoucherTranID)
        {
            return new AccTrnHeaderForChequeVoidFactory().SelectSingle(accVoucherTranID);
        }
        
        public int Insert()
        {
            return new AccTrnHeaderForChequeVoidFactory().Insert(this);
        }
        
        public int Update()
        {
            return new AccTrnHeaderForChequeVoidFactory().Update(this);
        }
        
        public int Delete()
        {
            return new AccTrnHeaderForChequeVoidFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("AccVoucherTranID: {0}", this.AccVoucherTranID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class AccTrnHeaderForChequeVoidFactory
    {
        
        public AccTrnHeaderForChequeVoidFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("AccTrnHeaderForChequeVoid");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("AccTrnHeaderForChequeVoid");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("AccTrnHeaderForChequeVoid");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("AccTrnHeaderForChequeVoid");
            }
        }
        
        public static AccTrnHeaderForChequeVoidFactory Create()
        {
            return new AccTrnHeaderForChequeVoidFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    long? accVoucherTranID, 
                    int? accFundCode, 
                    string accFundAccFundCode, 
                    int? vchrTypesID, 
                    string vchrNumber, 
                    string accTranRef, 
                    string refNo, 
                    DateTime? accTranDate, 
                    string paidTo, 
                    string accRemarks, 
                    int? yrClosing, 
                    bool? voucher_Check, 
                    string voucher_EditBy, 
                    DateTime? voucher_EditTime, 
                    string voucher_InstBy, 
                    DateTime? voucher_InstTime, 
                    byte? dLT, 
                    string vchrType, 
                    int? accUnitCode, 
                    string vchrPreFix, 
                    long? vNO, 
                    int? costCenterID, 
                    int? financialYearID, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (accVoucherTranID.HasValue)
            	filter.Add(("AccVoucherTranID:=" + accVoucherTranID.Value.ToString()));
            if (accFundCode.HasValue)
            	filter.Add(("AccFundCode:=" + accFundCode.Value.ToString()));
            if (!(String.IsNullOrEmpty(accFundAccFundCode)))
            	filter.Add(("AccFundAccFundCode:*" + accFundAccFundCode));
            if (vchrTypesID.HasValue)
            	filter.Add(("VchrTypesID:=" + vchrTypesID.Value.ToString()));
            if (!(String.IsNullOrEmpty(vchrNumber)))
            	filter.Add(("VchrNumber:*" + vchrNumber));
            if (!(String.IsNullOrEmpty(accTranRef)))
            	filter.Add(("AccTranRef:*" + accTranRef));
            if (!(String.IsNullOrEmpty(refNo)))
            	filter.Add(("RefNo:*" + refNo));
            if (accTranDate.HasValue)
            	filter.Add(("AccTranDate:=" + accTranDate.Value.ToString()));
            if (!(String.IsNullOrEmpty(paidTo)))
            	filter.Add(("PaidTo:*" + paidTo));
            if (!(String.IsNullOrEmpty(accRemarks)))
            	filter.Add(("AccRemarks:*" + accRemarks));
            if (yrClosing.HasValue)
            	filter.Add(("YrClosing:=" + yrClosing.Value.ToString()));
            if (voucher_Check.HasValue)
            	filter.Add(("Voucher_Check:=" + voucher_Check.Value.ToString()));
            if (!(String.IsNullOrEmpty(voucher_EditBy)))
            	filter.Add(("Voucher_EditBy:*" + voucher_EditBy));
            if (voucher_EditTime.HasValue)
            	filter.Add(("Voucher_EditTime:=" + voucher_EditTime.Value.ToString()));
            if (!(String.IsNullOrEmpty(voucher_InstBy)))
            	filter.Add(("Voucher_InstBy:*" + voucher_InstBy));
            if (voucher_InstTime.HasValue)
            	filter.Add(("Voucher_InstTime:=" + voucher_InstTime.Value.ToString()));
            if (dLT.HasValue)
            	filter.Add(("DLT:=" + dLT.Value.ToString()));
            if (!(String.IsNullOrEmpty(vchrType)))
            	filter.Add(("VchrType:*" + vchrType));
            if (accUnitCode.HasValue)
            	filter.Add(("AccUnitCode:=" + accUnitCode.Value.ToString()));
            if (!(String.IsNullOrEmpty(vchrPreFix)))
            	filter.Add(("VchrPreFix:*" + vchrPreFix));
            if (vNO.HasValue)
            	filter.Add(("VNO:=" + vNO.Value.ToString()));
            if (costCenterID.HasValue)
            	filter.Add(("CostCenterID:=" + costCenterID.Value.ToString()));
            if (financialYearID.HasValue)
            	filter.Add(("FinancialYearID:=" + financialYearID.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.AccTrnHeaderForChequeVoid> Select(
                    long? accVoucherTranID, 
                    int? accFundCode, 
                    string accFundAccFundCode, 
                    int? vchrTypesID, 
                    string vchrNumber, 
                    string accTranRef, 
                    string refNo, 
                    DateTime? accTranDate, 
                    string paidTo, 
                    string accRemarks, 
                    int? yrClosing, 
                    bool? voucher_Check, 
                    string voucher_EditBy, 
                    DateTime? voucher_EditTime, 
                    string voucher_InstBy, 
                    DateTime? voucher_InstTime, 
                    byte? dLT, 
                    string vchrType, 
                    int? accUnitCode, 
                    string vchrPreFix, 
                    long? vNO, 
                    int? costCenterID, 
                    int? financialYearID, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(accVoucherTranID, accFundCode, accFundAccFundCode, vchrTypesID, vchrNumber, accTranRef, refNo, accTranDate, paidTo, accRemarks, yrClosing, voucher_Check, voucher_EditBy, voucher_EditTime, voucher_InstBy, voucher_InstTime, dLT, vchrType, accUnitCode, vchrPreFix, vNO, costCenterID, financialYearID, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("AccTrnHeaderForChequeVoid", dataView, request);
            return page.ToList<MyCompany.Data.Objects.AccTrnHeaderForChequeVoid>();
        }
        
        public List<MyCompany.Data.Objects.AccTrnHeaderForChequeVoid> Select(MyCompany.Data.Objects.AccTrnHeaderForChequeVoid qbe)
        {
            return Select(qbe.AccVoucherTranID, qbe.AccFundCode, qbe.AccFundAccFundCode, qbe.VchrTypesID, qbe.VchrNumber, qbe.AccTranRef, qbe.RefNo, qbe.AccTranDate, qbe.PaidTo, qbe.AccRemarks, qbe.YrClosing, qbe.Voucher_Check, qbe.Voucher_EditBy, qbe.Voucher_EditTime, qbe.Voucher_InstBy, qbe.Voucher_InstTime, qbe.DLT, qbe.VchrType, qbe.AccUnitCode, qbe.VchrPreFix, qbe.VNO, qbe.CostCenterID, qbe.FinancialYearID);
        }
        
        public int SelectCount(
                    long? accVoucherTranID, 
                    int? accFundCode, 
                    string accFundAccFundCode, 
                    int? vchrTypesID, 
                    string vchrNumber, 
                    string accTranRef, 
                    string refNo, 
                    DateTime? accTranDate, 
                    string paidTo, 
                    string accRemarks, 
                    int? yrClosing, 
                    bool? voucher_Check, 
                    string voucher_EditBy, 
                    DateTime? voucher_EditTime, 
                    string voucher_InstBy, 
                    DateTime? voucher_InstTime, 
                    byte? dLT, 
                    string vchrType, 
                    int? accUnitCode, 
                    string vchrPreFix, 
                    long? vNO, 
                    int? costCenterID, 
                    int? financialYearID, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(accVoucherTranID, accFundCode, accFundAccFundCode, vchrTypesID, vchrNumber, accTranRef, refNo, accTranDate, paidTo, accRemarks, yrClosing, voucher_Check, voucher_EditBy, voucher_EditTime, voucher_InstBy, voucher_InstTime, dLT, vchrType, accUnitCode, vchrPreFix, vNO, costCenterID, financialYearID, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("AccTrnHeaderForChequeVoid", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.AccTrnHeaderForChequeVoid> Select(
                    long? accVoucherTranID, 
                    int? accFundCode, 
                    string accFundAccFundCode, 
                    int? vchrTypesID, 
                    string vchrNumber, 
                    string accTranRef, 
                    string refNo, 
                    DateTime? accTranDate, 
                    string paidTo, 
                    string accRemarks, 
                    int? yrClosing, 
                    bool? voucher_Check, 
                    string voucher_EditBy, 
                    DateTime? voucher_EditTime, 
                    string voucher_InstBy, 
                    DateTime? voucher_InstTime, 
                    byte? dLT, 
                    string vchrType, 
                    int? accUnitCode, 
                    string vchrPreFix, 
                    long? vNO, 
                    int? costCenterID, 
                    int? financialYearID)
        {
            return Select(accVoucherTranID, accFundCode, accFundAccFundCode, vchrTypesID, vchrNumber, accTranRef, refNo, accTranDate, paidTo, accRemarks, yrClosing, voucher_Check, voucher_EditBy, voucher_EditTime, voucher_InstBy, voucher_InstTime, dLT, vchrType, accUnitCode, vchrPreFix, vNO, costCenterID, financialYearID, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.AccTrnHeaderForChequeVoid SelectSingle(long? accVoucherTranID)
        {
            List<MyCompany.Data.Objects.AccTrnHeaderForChequeVoid> list = Select(accVoucherTranID, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.AccTrnHeaderForChequeVoid> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("AccTrnHeaderForChequeVoid", dataView, request);
            return page.ToList<MyCompany.Data.Objects.AccTrnHeaderForChequeVoid>();
        }
        
        public List<MyCompany.Data.Objects.AccTrnHeaderForChequeVoid> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.AccTrnHeaderForChequeVoid> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.AccTrnHeaderForChequeVoid SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.AccTrnHeaderForChequeVoid> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.AccTrnHeaderForChequeVoid theAccTrnHeaderForChequeVoid, MyCompany.Data.Objects.AccTrnHeaderForChequeVoid original_AccTrnHeaderForChequeVoid)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("AccVoucherTranID", original_AccTrnHeaderForChequeVoid.AccVoucherTranID, theAccTrnHeaderForChequeVoid.AccVoucherTranID, true));
            values.Add(new FieldValue("AccFundCode", original_AccTrnHeaderForChequeVoid.AccFundCode, theAccTrnHeaderForChequeVoid.AccFundCode));
            values.Add(new FieldValue("AccFundAccFundCode", original_AccTrnHeaderForChequeVoid.AccFundAccFundCode, theAccTrnHeaderForChequeVoid.AccFundAccFundCode, true));
            values.Add(new FieldValue("VchrTypesID", original_AccTrnHeaderForChequeVoid.VchrTypesID, theAccTrnHeaderForChequeVoid.VchrTypesID));
            values.Add(new FieldValue("VchrNumber", original_AccTrnHeaderForChequeVoid.VchrNumber, theAccTrnHeaderForChequeVoid.VchrNumber));
            values.Add(new FieldValue("AccTranRef", original_AccTrnHeaderForChequeVoid.AccTranRef, theAccTrnHeaderForChequeVoid.AccTranRef));
            values.Add(new FieldValue("RefNo", original_AccTrnHeaderForChequeVoid.RefNo, theAccTrnHeaderForChequeVoid.RefNo));
            values.Add(new FieldValue("AccTranDate", original_AccTrnHeaderForChequeVoid.AccTranDate, theAccTrnHeaderForChequeVoid.AccTranDate));
            values.Add(new FieldValue("PaidTo", original_AccTrnHeaderForChequeVoid.PaidTo, theAccTrnHeaderForChequeVoid.PaidTo));
            values.Add(new FieldValue("AccRemarks", original_AccTrnHeaderForChequeVoid.AccRemarks, theAccTrnHeaderForChequeVoid.AccRemarks));
            values.Add(new FieldValue("YrClosing", original_AccTrnHeaderForChequeVoid.YrClosing, theAccTrnHeaderForChequeVoid.YrClosing));
            values.Add(new FieldValue("Voucher_Check", original_AccTrnHeaderForChequeVoid.Voucher_Check, theAccTrnHeaderForChequeVoid.Voucher_Check));
            values.Add(new FieldValue("Voucher_EditBy", original_AccTrnHeaderForChequeVoid.Voucher_EditBy, theAccTrnHeaderForChequeVoid.Voucher_EditBy));
            values.Add(new FieldValue("Voucher_EditTime", original_AccTrnHeaderForChequeVoid.Voucher_EditTime, theAccTrnHeaderForChequeVoid.Voucher_EditTime));
            values.Add(new FieldValue("Voucher_InstBy", original_AccTrnHeaderForChequeVoid.Voucher_InstBy, theAccTrnHeaderForChequeVoid.Voucher_InstBy));
            values.Add(new FieldValue("Voucher_InstTime", original_AccTrnHeaderForChequeVoid.Voucher_InstTime, theAccTrnHeaderForChequeVoid.Voucher_InstTime));
            values.Add(new FieldValue("DLT", original_AccTrnHeaderForChequeVoid.DLT, theAccTrnHeaderForChequeVoid.DLT));
            values.Add(new FieldValue("VchrType", original_AccTrnHeaderForChequeVoid.VchrType, theAccTrnHeaderForChequeVoid.VchrType));
            values.Add(new FieldValue("AccUnitCode", original_AccTrnHeaderForChequeVoid.AccUnitCode, theAccTrnHeaderForChequeVoid.AccUnitCode));
            values.Add(new FieldValue("VchrPreFix", original_AccTrnHeaderForChequeVoid.VchrPreFix, theAccTrnHeaderForChequeVoid.VchrPreFix));
            values.Add(new FieldValue("VNO", original_AccTrnHeaderForChequeVoid.VNO, theAccTrnHeaderForChequeVoid.VNO));
            values.Add(new FieldValue("CostCenterID", original_AccTrnHeaderForChequeVoid.CostCenterID, theAccTrnHeaderForChequeVoid.CostCenterID));
            values.Add(new FieldValue("FinancialYearID", original_AccTrnHeaderForChequeVoid.FinancialYearID, theAccTrnHeaderForChequeVoid.FinancialYearID));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.AccTrnHeaderForChequeVoid theAccTrnHeaderForChequeVoid, MyCompany.Data.Objects.AccTrnHeaderForChequeVoid original_AccTrnHeaderForChequeVoid, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "AccTrnHeaderForChequeVoid";
            args.View = dataView;
            args.Values = CreateFieldValues(theAccTrnHeaderForChequeVoid, original_AccTrnHeaderForChequeVoid);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("AccTrnHeaderForChequeVoid", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theAccTrnHeaderForChequeVoid);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.AccTrnHeaderForChequeVoid theAccTrnHeaderForChequeVoid, MyCompany.Data.Objects.AccTrnHeaderForChequeVoid original_AccTrnHeaderForChequeVoid)
        {
            return ExecuteAction(theAccTrnHeaderForChequeVoid, original_AccTrnHeaderForChequeVoid, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.AccTrnHeaderForChequeVoid theAccTrnHeaderForChequeVoid)
        {
            return Update(theAccTrnHeaderForChequeVoid, SelectSingle(theAccTrnHeaderForChequeVoid.AccVoucherTranID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.AccTrnHeaderForChequeVoid theAccTrnHeaderForChequeVoid)
        {
            return ExecuteAction(theAccTrnHeaderForChequeVoid, new AccTrnHeaderForChequeVoid(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.AccTrnHeaderForChequeVoid theAccTrnHeaderForChequeVoid)
        {
            return ExecuteAction(theAccTrnHeaderForChequeVoid, theAccTrnHeaderForChequeVoid, "Select", "Delete", DeleteView);
        }
    }
}
