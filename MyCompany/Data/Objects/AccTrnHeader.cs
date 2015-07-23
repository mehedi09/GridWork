using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class AccTrnHeader
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
        
        public AccTrnHeader()
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
        
        public static List<MyCompany.Data.Objects.AccTrnHeader> Select(
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
            return new AccTrnHeaderFactory().Select(accVoucherTranID, accFundCode, accFundAccFundCode, vchrTypesID, vchrNumber, accTranRef, refNo, accTranDate, paidTo, accRemarks, yrClosing, voucher_Check, voucher_EditBy, voucher_EditTime, voucher_InstBy, voucher_InstTime, dLT, vchrType, accUnitCode, vchrPreFix, vNO, costCenterID, financialYearID);
        }
        
        public static List<MyCompany.Data.Objects.AccTrnHeader> Select(MyCompany.Data.Objects.AccTrnHeader qbe)
        {
            return new AccTrnHeaderFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.AccTrnHeader> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new AccTrnHeaderFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccTrnHeader> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new AccTrnHeaderFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.AccTrnHeader> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new AccTrnHeaderFactory().Select(filter, sort, AccTrnHeaderFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccTrnHeader> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new AccTrnHeaderFactory().Select(filter, sort, AccTrnHeaderFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.AccTrnHeader> Select(string filter, BusinessObjectParameters parameters)
        {
            return new AccTrnHeaderFactory().Select(filter, null, AccTrnHeaderFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccTrnHeader> Select(string filter, params FieldValue[] parameters)
        {
            return new AccTrnHeaderFactory().Select(filter, null, AccTrnHeaderFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.AccTrnHeader SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new AccTrnHeaderFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.AccTrnHeader SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new AccTrnHeaderFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.AccTrnHeader SelectSingle(long? accVoucherTranID)
        {
            return new AccTrnHeaderFactory().SelectSingle(accVoucherTranID);
        }
        
        public int Insert()
        {
            return new AccTrnHeaderFactory().Insert(this);
        }
        
        public int Update()
        {
            return new AccTrnHeaderFactory().Update(this);
        }
        
        public int Delete()
        {
            return new AccTrnHeaderFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("AccVoucherTranID: {0}", this.AccVoucherTranID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class AccTrnHeaderFactory
    {
        
        public AccTrnHeaderFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("AccTrnHeader");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("AccTrnHeader");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("AccTrnHeader");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("AccTrnHeader");
            }
        }
        
        public static AccTrnHeaderFactory Create()
        {
            return new AccTrnHeaderFactory();
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
        public List<MyCompany.Data.Objects.AccTrnHeader> Select(
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
            ViewPage page = ControllerFactory.CreateDataController().GetPage("AccTrnHeader", dataView, request);
            return page.ToList<MyCompany.Data.Objects.AccTrnHeader>();
        }
        
        public List<MyCompany.Data.Objects.AccTrnHeader> Select(MyCompany.Data.Objects.AccTrnHeader qbe)
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
            ViewPage page = ControllerFactory.CreateDataController().GetPage("AccTrnHeader", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.AccTrnHeader> Select(
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
        
        public MyCompany.Data.Objects.AccTrnHeader SelectSingle(long? accVoucherTranID)
        {
            List<MyCompany.Data.Objects.AccTrnHeader> list = Select(accVoucherTranID, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.AccTrnHeader> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("AccTrnHeader", dataView, request);
            return page.ToList<MyCompany.Data.Objects.AccTrnHeader>();
        }
        
        public List<MyCompany.Data.Objects.AccTrnHeader> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.AccTrnHeader> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.AccTrnHeader SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.AccTrnHeader> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.AccTrnHeader theAccTrnHeader, MyCompany.Data.Objects.AccTrnHeader original_AccTrnHeader)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("AccVoucherTranID", original_AccTrnHeader.AccVoucherTranID, theAccTrnHeader.AccVoucherTranID, true));
            values.Add(new FieldValue("AccFundCode", original_AccTrnHeader.AccFundCode, theAccTrnHeader.AccFundCode));
            values.Add(new FieldValue("AccFundAccFundCode", original_AccTrnHeader.AccFundAccFundCode, theAccTrnHeader.AccFundAccFundCode, true));
            values.Add(new FieldValue("VchrTypesID", original_AccTrnHeader.VchrTypesID, theAccTrnHeader.VchrTypesID));
            values.Add(new FieldValue("VchrNumber", original_AccTrnHeader.VchrNumber, theAccTrnHeader.VchrNumber));
            values.Add(new FieldValue("AccTranRef", original_AccTrnHeader.AccTranRef, theAccTrnHeader.AccTranRef));
            values.Add(new FieldValue("RefNo", original_AccTrnHeader.RefNo, theAccTrnHeader.RefNo));
            values.Add(new FieldValue("AccTranDate", original_AccTrnHeader.AccTranDate, theAccTrnHeader.AccTranDate));
            values.Add(new FieldValue("PaidTo", original_AccTrnHeader.PaidTo, theAccTrnHeader.PaidTo));
            values.Add(new FieldValue("AccRemarks", original_AccTrnHeader.AccRemarks, theAccTrnHeader.AccRemarks));
            values.Add(new FieldValue("YrClosing", original_AccTrnHeader.YrClosing, theAccTrnHeader.YrClosing));
            values.Add(new FieldValue("Voucher_Check", original_AccTrnHeader.Voucher_Check, theAccTrnHeader.Voucher_Check));
            values.Add(new FieldValue("Voucher_EditBy", original_AccTrnHeader.Voucher_EditBy, theAccTrnHeader.Voucher_EditBy));
            values.Add(new FieldValue("Voucher_EditTime", original_AccTrnHeader.Voucher_EditTime, theAccTrnHeader.Voucher_EditTime));
            values.Add(new FieldValue("Voucher_InstBy", original_AccTrnHeader.Voucher_InstBy, theAccTrnHeader.Voucher_InstBy));
            values.Add(new FieldValue("Voucher_InstTime", original_AccTrnHeader.Voucher_InstTime, theAccTrnHeader.Voucher_InstTime));
            values.Add(new FieldValue("DLT", original_AccTrnHeader.DLT, theAccTrnHeader.DLT));
            values.Add(new FieldValue("VchrType", original_AccTrnHeader.VchrType, theAccTrnHeader.VchrType));
            values.Add(new FieldValue("AccUnitCode", original_AccTrnHeader.AccUnitCode, theAccTrnHeader.AccUnitCode));
            values.Add(new FieldValue("VchrPreFix", original_AccTrnHeader.VchrPreFix, theAccTrnHeader.VchrPreFix));
            values.Add(new FieldValue("VNO", original_AccTrnHeader.VNO, theAccTrnHeader.VNO));
            values.Add(new FieldValue("CostCenterID", original_AccTrnHeader.CostCenterID, theAccTrnHeader.CostCenterID));
            values.Add(new FieldValue("FinancialYearID", original_AccTrnHeader.FinancialYearID, theAccTrnHeader.FinancialYearID));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.AccTrnHeader theAccTrnHeader, MyCompany.Data.Objects.AccTrnHeader original_AccTrnHeader, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "AccTrnHeader";
            args.View = dataView;
            args.Values = CreateFieldValues(theAccTrnHeader, original_AccTrnHeader);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("AccTrnHeader", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theAccTrnHeader);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.AccTrnHeader theAccTrnHeader, MyCompany.Data.Objects.AccTrnHeader original_AccTrnHeader)
        {
            return ExecuteAction(theAccTrnHeader, original_AccTrnHeader, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.AccTrnHeader theAccTrnHeader)
        {
            return Update(theAccTrnHeader, SelectSingle(theAccTrnHeader.AccVoucherTranID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.AccTrnHeader theAccTrnHeader)
        {
            return ExecuteAction(theAccTrnHeader, new AccTrnHeader(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.AccTrnHeader theAccTrnHeader)
        {
            return ExecuteAction(theAccTrnHeader, theAccTrnHeader, "Select", "Delete", DeleteView);
        }
    }
}
