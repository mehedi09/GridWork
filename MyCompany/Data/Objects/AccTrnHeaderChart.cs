using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class AccTrnHeaderChart
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
        
        public AccTrnHeaderChart()
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
        
        public static List<MyCompany.Data.Objects.AccTrnHeaderChart> Select(
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
            return new AccTrnHeaderChartFactory().Select(accVoucherTranID, accFundCode, accFundAccFundCode, vchrTypesID, vchrNumber, accTranRef, refNo, accTranDate, paidTo, accRemarks, yrClosing, voucher_Check, voucher_EditBy, voucher_EditTime, voucher_InstBy, voucher_InstTime, dLT, vchrType, accUnitCode, vchrPreFix, vNO, costCenterID, financialYearID);
        }
        
        public static List<MyCompany.Data.Objects.AccTrnHeaderChart> Select(MyCompany.Data.Objects.AccTrnHeaderChart qbe)
        {
            return new AccTrnHeaderChartFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.AccTrnHeaderChart> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new AccTrnHeaderChartFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccTrnHeaderChart> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new AccTrnHeaderChartFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.AccTrnHeaderChart> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new AccTrnHeaderChartFactory().Select(filter, sort, AccTrnHeaderChartFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccTrnHeaderChart> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new AccTrnHeaderChartFactory().Select(filter, sort, AccTrnHeaderChartFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.AccTrnHeaderChart> Select(string filter, BusinessObjectParameters parameters)
        {
            return new AccTrnHeaderChartFactory().Select(filter, null, AccTrnHeaderChartFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccTrnHeaderChart> Select(string filter, params FieldValue[] parameters)
        {
            return new AccTrnHeaderChartFactory().Select(filter, null, AccTrnHeaderChartFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.AccTrnHeaderChart SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new AccTrnHeaderChartFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.AccTrnHeaderChart SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new AccTrnHeaderChartFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.AccTrnHeaderChart SelectSingle(long? accVoucherTranID)
        {
            return new AccTrnHeaderChartFactory().SelectSingle(accVoucherTranID);
        }
        
        public int Insert()
        {
            return new AccTrnHeaderChartFactory().Insert(this);
        }
        
        public int Update()
        {
            return new AccTrnHeaderChartFactory().Update(this);
        }
        
        public int Delete()
        {
            return new AccTrnHeaderChartFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("AccVoucherTranID: {0}", this.AccVoucherTranID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class AccTrnHeaderChartFactory
    {
        
        public AccTrnHeaderChartFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("AccTrnHeaderChart");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("AccTrnHeaderChart");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("AccTrnHeaderChart");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("AccTrnHeaderChart");
            }
        }
        
        public static AccTrnHeaderChartFactory Create()
        {
            return new AccTrnHeaderChartFactory();
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
        public List<MyCompany.Data.Objects.AccTrnHeaderChart> Select(
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
            ViewPage page = ControllerFactory.CreateDataController().GetPage("AccTrnHeaderChart", dataView, request);
            return page.ToList<MyCompany.Data.Objects.AccTrnHeaderChart>();
        }
        
        public List<MyCompany.Data.Objects.AccTrnHeaderChart> Select(MyCompany.Data.Objects.AccTrnHeaderChart qbe)
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
            ViewPage page = ControllerFactory.CreateDataController().GetPage("AccTrnHeaderChart", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.AccTrnHeaderChart> Select(
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
        
        public MyCompany.Data.Objects.AccTrnHeaderChart SelectSingle(long? accVoucherTranID)
        {
            List<MyCompany.Data.Objects.AccTrnHeaderChart> list = Select(accVoucherTranID, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.AccTrnHeaderChart> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("AccTrnHeaderChart", dataView, request);
            return page.ToList<MyCompany.Data.Objects.AccTrnHeaderChart>();
        }
        
        public List<MyCompany.Data.Objects.AccTrnHeaderChart> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.AccTrnHeaderChart> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.AccTrnHeaderChart SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.AccTrnHeaderChart> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.AccTrnHeaderChart theAccTrnHeaderChart, MyCompany.Data.Objects.AccTrnHeaderChart original_AccTrnHeaderChart)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("AccVoucherTranID", original_AccTrnHeaderChart.AccVoucherTranID, theAccTrnHeaderChart.AccVoucherTranID, true));
            values.Add(new FieldValue("AccFundCode", original_AccTrnHeaderChart.AccFundCode, theAccTrnHeaderChart.AccFundCode));
            values.Add(new FieldValue("AccFundAccFundCode", original_AccTrnHeaderChart.AccFundAccFundCode, theAccTrnHeaderChart.AccFundAccFundCode, true));
            values.Add(new FieldValue("VchrTypesID", original_AccTrnHeaderChart.VchrTypesID, theAccTrnHeaderChart.VchrTypesID));
            values.Add(new FieldValue("VchrNumber", original_AccTrnHeaderChart.VchrNumber, theAccTrnHeaderChart.VchrNumber));
            values.Add(new FieldValue("AccTranRef", original_AccTrnHeaderChart.AccTranRef, theAccTrnHeaderChart.AccTranRef));
            values.Add(new FieldValue("RefNo", original_AccTrnHeaderChart.RefNo, theAccTrnHeaderChart.RefNo));
            values.Add(new FieldValue("AccTranDate", original_AccTrnHeaderChart.AccTranDate, theAccTrnHeaderChart.AccTranDate));
            values.Add(new FieldValue("PaidTo", original_AccTrnHeaderChart.PaidTo, theAccTrnHeaderChart.PaidTo));
            values.Add(new FieldValue("AccRemarks", original_AccTrnHeaderChart.AccRemarks, theAccTrnHeaderChart.AccRemarks));
            values.Add(new FieldValue("YrClosing", original_AccTrnHeaderChart.YrClosing, theAccTrnHeaderChart.YrClosing));
            values.Add(new FieldValue("Voucher_Check", original_AccTrnHeaderChart.Voucher_Check, theAccTrnHeaderChart.Voucher_Check));
            values.Add(new FieldValue("Voucher_EditBy", original_AccTrnHeaderChart.Voucher_EditBy, theAccTrnHeaderChart.Voucher_EditBy));
            values.Add(new FieldValue("Voucher_EditTime", original_AccTrnHeaderChart.Voucher_EditTime, theAccTrnHeaderChart.Voucher_EditTime));
            values.Add(new FieldValue("Voucher_InstBy", original_AccTrnHeaderChart.Voucher_InstBy, theAccTrnHeaderChart.Voucher_InstBy));
            values.Add(new FieldValue("Voucher_InstTime", original_AccTrnHeaderChart.Voucher_InstTime, theAccTrnHeaderChart.Voucher_InstTime));
            values.Add(new FieldValue("DLT", original_AccTrnHeaderChart.DLT, theAccTrnHeaderChart.DLT));
            values.Add(new FieldValue("VchrType", original_AccTrnHeaderChart.VchrType, theAccTrnHeaderChart.VchrType));
            values.Add(new FieldValue("AccUnitCode", original_AccTrnHeaderChart.AccUnitCode, theAccTrnHeaderChart.AccUnitCode));
            values.Add(new FieldValue("VchrPreFix", original_AccTrnHeaderChart.VchrPreFix, theAccTrnHeaderChart.VchrPreFix));
            values.Add(new FieldValue("VNO", original_AccTrnHeaderChart.VNO, theAccTrnHeaderChart.VNO));
            values.Add(new FieldValue("CostCenterID", original_AccTrnHeaderChart.CostCenterID, theAccTrnHeaderChart.CostCenterID));
            values.Add(new FieldValue("FinancialYearID", original_AccTrnHeaderChart.FinancialYearID, theAccTrnHeaderChart.FinancialYearID));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.AccTrnHeaderChart theAccTrnHeaderChart, MyCompany.Data.Objects.AccTrnHeaderChart original_AccTrnHeaderChart, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "AccTrnHeaderChart";
            args.View = dataView;
            args.Values = CreateFieldValues(theAccTrnHeaderChart, original_AccTrnHeaderChart);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("AccTrnHeaderChart", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theAccTrnHeaderChart);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.AccTrnHeaderChart theAccTrnHeaderChart, MyCompany.Data.Objects.AccTrnHeaderChart original_AccTrnHeaderChart)
        {
            return ExecuteAction(theAccTrnHeaderChart, original_AccTrnHeaderChart, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.AccTrnHeaderChart theAccTrnHeaderChart)
        {
            return Update(theAccTrnHeaderChart, SelectSingle(theAccTrnHeaderChart.AccVoucherTranID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.AccTrnHeaderChart theAccTrnHeaderChart)
        {
            return ExecuteAction(theAccTrnHeaderChart, new AccTrnHeaderChart(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.AccTrnHeaderChart theAccTrnHeaderChart)
        {
            return ExecuteAction(theAccTrnHeaderChart, theAccTrnHeaderChart, "Select", "Delete", DeleteView);
        }
    }
}
