using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class GeneralLedgerReport
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _status;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _openbal;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _tranDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _vchr_no;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _trnSL_no;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _refno;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _v_Type;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _remarks;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _debit;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _trnDebit;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _drcur;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _credit;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _trnCredit;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _crCur;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accCompany;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _ledCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _ledgerName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _balType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _ledCurrency;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private byte? _accNature;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _fundName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accSubTypeID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accSubCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _subName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _voucher;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tran_Comment;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _trStat;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _paidTo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _mainName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _ledAccCodeName;
        
        public GeneralLedgerReport()
        {
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccCode
        {
            get
            {
                return _accCode;
            }
            set
            {
                _accCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccName
        {
            get
            {
                return _accName;
            }
            set
            {
                _accName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public decimal? Openbal
        {
            get
            {
                return _openbal;
            }
            set
            {
                _openbal = value;
            }
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string Vchr_no
        {
            get
            {
                return _vchr_no;
            }
            set
            {
                _vchr_no = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public int? TrnSL_no
        {
            get
            {
                return _trnSL_no;
            }
            set
            {
                _trnSL_no = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Refno
        {
            get
            {
                return _refno;
            }
            set
            {
                _refno = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string v_Type
        {
            get
            {
                return _v_Type;
            }
            set
            {
                _v_Type = value;
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public decimal? Debit
        {
            get
            {
                return _debit;
            }
            set
            {
                _debit = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public decimal? TrnDebit
        {
            get
            {
                return _trnDebit;
            }
            set
            {
                _trnDebit = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Drcur
        {
            get
            {
                return _drcur;
            }
            set
            {
                _drcur = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public decimal? Credit
        {
            get
            {
                return _credit;
            }
            set
            {
                _credit = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public decimal? TrnCredit
        {
            get
            {
                return _trnCredit;
            }
            set
            {
                _trnCredit = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CrCur
        {
            get
            {
                return _crCur;
            }
            set
            {
                _crCur = value;
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
        public string AccCompany
        {
            get
            {
                return _accCompany;
            }
            set
            {
                _accCompany = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? LedCode
        {
            get
            {
                return _ledCode;
            }
            set
            {
                _ledCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LedgerName
        {
            get
            {
                return _ledgerName;
            }
            set
            {
                _ledgerName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? BalType
        {
            get
            {
                return _balType;
            }
            set
            {
                _balType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LedCurrency
        {
            get
            {
                return _ledCurrency;
            }
            set
            {
                _ledCurrency = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public byte? AccNature
        {
            get
            {
                return _accNature;
            }
            set
            {
                _accNature = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string FundName
        {
            get
            {
                return _fundName;
            }
            set
            {
                _fundName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? AccSubTypeID
        {
            get
            {
                return _accSubTypeID;
            }
            set
            {
                _accSubTypeID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? AccSubCode
        {
            get
            {
                return _accSubCode;
            }
            set
            {
                _accSubCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SubName
        {
            get
            {
                return _subName;
            }
            set
            {
                _subName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Voucher
        {
            get
            {
                return _voucher;
            }
            set
            {
                _voucher = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Tran_Comment
        {
            get
            {
                return _tran_Comment;
            }
            set
            {
                _tran_Comment = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string TrStat
        {
            get
            {
                return _trStat;
            }
            set
            {
                _trStat = value;
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
        public string MainName
        {
            get
            {
                return _mainName;
            }
            set
            {
                _mainName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LedAccCodeName
        {
            get
            {
                return _ledAccCodeName;
            }
            set
            {
                _ledAccCodeName = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.GeneralLedgerReport> Select(
                    string status, 
                    string accCode, 
                    string accName, 
                    decimal? openbal, 
                    DateTime? tranDate, 
                    string vchr_no, 
                    int? trnSL_no, 
                    string refno, 
                    string v_Type, 
                    string remarks, 
                    decimal? debit, 
                    decimal? trnDebit, 
                    string drcur, 
                    decimal? credit, 
                    decimal? trnCredit, 
                    string crCur, 
                    int? accFundCode, 
                    string accCompany, 
                    int? ledCode, 
                    string ledgerName, 
                    int? balType, 
                    string ledCurrency, 
                    byte? accNature, 
                    string fundName, 
                    int? accSubTypeID, 
                    int? accSubCode, 
                    string subName, 
                    string voucher, 
                    string tran_Comment, 
                    string trStat, 
                    string paidTo, 
                    string mainName, 
                    string ledAccCodeName)
        {
            return new GeneralLedgerReportFactory().Select(status, accCode, accName, openbal, tranDate, vchr_no, trnSL_no, refno, v_Type, remarks, debit, trnDebit, drcur, credit, trnCredit, crCur, accFundCode, accCompany, ledCode, ledgerName, balType, ledCurrency, accNature, fundName, accSubTypeID, accSubCode, subName, voucher, tran_Comment, trStat, paidTo, mainName, ledAccCodeName);
        }
        
        public static List<MyCompany.Data.Objects.GeneralLedgerReport> Select(MyCompany.Data.Objects.GeneralLedgerReport qbe)
        {
            return new GeneralLedgerReportFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.GeneralLedgerReport> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new GeneralLedgerReportFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.GeneralLedgerReport> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new GeneralLedgerReportFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.GeneralLedgerReport> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new GeneralLedgerReportFactory().Select(filter, sort, GeneralLedgerReportFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.GeneralLedgerReport> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new GeneralLedgerReportFactory().Select(filter, sort, GeneralLedgerReportFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.GeneralLedgerReport> Select(string filter, BusinessObjectParameters parameters)
        {
            return new GeneralLedgerReportFactory().Select(filter, null, GeneralLedgerReportFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.GeneralLedgerReport> Select(string filter, params FieldValue[] parameters)
        {
            return new GeneralLedgerReportFactory().Select(filter, null, GeneralLedgerReportFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.GeneralLedgerReport SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new GeneralLedgerReportFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.GeneralLedgerReport SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new GeneralLedgerReportFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public override string ToString()
        {
            return String.Format("");
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class GeneralLedgerReportFactory
    {
        
        public GeneralLedgerReportFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("GeneralLedgerReport");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("GeneralLedgerReport");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("GeneralLedgerReport");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("GeneralLedgerReport");
            }
        }
        
        public static GeneralLedgerReportFactory Create()
        {
            return new GeneralLedgerReportFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    string status, 
                    string accCode, 
                    string accName, 
                    decimal? openbal, 
                    DateTime? tranDate, 
                    string vchr_no, 
                    int? trnSL_no, 
                    string refno, 
                    string v_Type, 
                    string remarks, 
                    decimal? debit, 
                    decimal? trnDebit, 
                    string drcur, 
                    decimal? credit, 
                    decimal? trnCredit, 
                    string crCur, 
                    int? accFundCode, 
                    string accCompany, 
                    int? ledCode, 
                    string ledgerName, 
                    int? balType, 
                    string ledCurrency, 
                    byte? accNature, 
                    string fundName, 
                    int? accSubTypeID, 
                    int? accSubCode, 
                    string subName, 
                    string voucher, 
                    string tran_Comment, 
                    string trStat, 
                    string paidTo, 
                    string mainName, 
                    string ledAccCodeName, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (!(String.IsNullOrEmpty(status)))
            	filter.Add(("Status:*" + status));
            if (!(String.IsNullOrEmpty(accCode)))
            	filter.Add(("AccCode:*" + accCode));
            if (!(String.IsNullOrEmpty(accName)))
            	filter.Add(("AccName:*" + accName));
            if (openbal.HasValue)
            	filter.Add(("Openbal:=" + openbal.Value.ToString()));
            if (tranDate.HasValue)
            	filter.Add(("TranDate:=" + tranDate.Value.ToString()));
            if (!(String.IsNullOrEmpty(vchr_no)))
            	filter.Add(("Vchr_no:*" + vchr_no));
            if (trnSL_no.HasValue)
            	filter.Add(("TrnSL_no:=" + trnSL_no.Value.ToString()));
            if (!(String.IsNullOrEmpty(refno)))
            	filter.Add(("Refno:*" + refno));
            if (!(String.IsNullOrEmpty(v_Type)))
            	filter.Add(("v_Type:*" + v_Type));
            if (!(String.IsNullOrEmpty(remarks)))
            	filter.Add(("Remarks:*" + remarks));
            if (debit.HasValue)
            	filter.Add(("Debit:=" + debit.Value.ToString()));
            if (trnDebit.HasValue)
            	filter.Add(("TrnDebit:=" + trnDebit.Value.ToString()));
            if (!(String.IsNullOrEmpty(drcur)))
            	filter.Add(("Drcur:*" + drcur));
            if (credit.HasValue)
            	filter.Add(("Credit:=" + credit.Value.ToString()));
            if (trnCredit.HasValue)
            	filter.Add(("TrnCredit:=" + trnCredit.Value.ToString()));
            if (!(String.IsNullOrEmpty(crCur)))
            	filter.Add(("CrCur:*" + crCur));
            if (accFundCode.HasValue)
            	filter.Add(("AccFundCode:=" + accFundCode.Value.ToString()));
            if (!(String.IsNullOrEmpty(accCompany)))
            	filter.Add(("AccCompany:*" + accCompany));
            if (ledCode.HasValue)
            	filter.Add(("LedCode:=" + ledCode.Value.ToString()));
            if (!(String.IsNullOrEmpty(ledgerName)))
            	filter.Add(("LedgerName:*" + ledgerName));
            if (balType.HasValue)
            	filter.Add(("BalType:=" + balType.Value.ToString()));
            if (!(String.IsNullOrEmpty(ledCurrency)))
            	filter.Add(("LedCurrency:*" + ledCurrency));
            if (accNature.HasValue)
            	filter.Add(("AccNature:=" + accNature.Value.ToString()));
            if (!(String.IsNullOrEmpty(fundName)))
            	filter.Add(("FundName:*" + fundName));
            if (accSubTypeID.HasValue)
            	filter.Add(("AccSubTypeID:=" + accSubTypeID.Value.ToString()));
            if (accSubCode.HasValue)
            	filter.Add(("AccSubCode:=" + accSubCode.Value.ToString()));
            if (!(String.IsNullOrEmpty(subName)))
            	filter.Add(("SubName:*" + subName));
            if (!(String.IsNullOrEmpty(voucher)))
            	filter.Add(("Voucher:*" + voucher));
            if (!(String.IsNullOrEmpty(tran_Comment)))
            	filter.Add(("Tran_Comment:*" + tran_Comment));
            if (!(String.IsNullOrEmpty(trStat)))
            	filter.Add(("TrStat:*" + trStat));
            if (!(String.IsNullOrEmpty(paidTo)))
            	filter.Add(("PaidTo:*" + paidTo));
            if (!(String.IsNullOrEmpty(mainName)))
            	filter.Add(("MainName:*" + mainName));
            if (!(String.IsNullOrEmpty(ledAccCodeName)))
            	filter.Add(("LedAccCodeName:*" + ledAccCodeName));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.GeneralLedgerReport> Select(
                    string status, 
                    string accCode, 
                    string accName, 
                    decimal? openbal, 
                    DateTime? tranDate, 
                    string vchr_no, 
                    int? trnSL_no, 
                    string refno, 
                    string v_Type, 
                    string remarks, 
                    decimal? debit, 
                    decimal? trnDebit, 
                    string drcur, 
                    decimal? credit, 
                    decimal? trnCredit, 
                    string crCur, 
                    int? accFundCode, 
                    string accCompany, 
                    int? ledCode, 
                    string ledgerName, 
                    int? balType, 
                    string ledCurrency, 
                    byte? accNature, 
                    string fundName, 
                    int? accSubTypeID, 
                    int? accSubCode, 
                    string subName, 
                    string voucher, 
                    string tran_Comment, 
                    string trStat, 
                    string paidTo, 
                    string mainName, 
                    string ledAccCodeName, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(status, accCode, accName, openbal, tranDate, vchr_no, trnSL_no, refno, v_Type, remarks, debit, trnDebit, drcur, credit, trnCredit, crCur, accFundCode, accCompany, ledCode, ledgerName, balType, ledCurrency, accNature, fundName, accSubTypeID, accSubCode, subName, voucher, tran_Comment, trStat, paidTo, mainName, ledAccCodeName, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("GeneralLedgerReport", dataView, request);
            return page.ToList<MyCompany.Data.Objects.GeneralLedgerReport>();
        }
        
        public List<MyCompany.Data.Objects.GeneralLedgerReport> Select(MyCompany.Data.Objects.GeneralLedgerReport qbe)
        {
            return Select(qbe.Status, qbe.AccCode, qbe.AccName, qbe.Openbal, qbe.TranDate, qbe.Vchr_no, qbe.TrnSL_no, qbe.Refno, qbe.v_Type, qbe.Remarks, qbe.Debit, qbe.TrnDebit, qbe.Drcur, qbe.Credit, qbe.TrnCredit, qbe.CrCur, qbe.AccFundCode, qbe.AccCompany, qbe.LedCode, qbe.LedgerName, qbe.BalType, qbe.LedCurrency, qbe.AccNature, qbe.FundName, qbe.AccSubTypeID, qbe.AccSubCode, qbe.SubName, qbe.Voucher, qbe.Tran_Comment, qbe.TrStat, qbe.PaidTo, qbe.MainName, qbe.LedAccCodeName);
        }
        
        public int SelectCount(
                    string status, 
                    string accCode, 
                    string accName, 
                    decimal? openbal, 
                    DateTime? tranDate, 
                    string vchr_no, 
                    int? trnSL_no, 
                    string refno, 
                    string v_Type, 
                    string remarks, 
                    decimal? debit, 
                    decimal? trnDebit, 
                    string drcur, 
                    decimal? credit, 
                    decimal? trnCredit, 
                    string crCur, 
                    int? accFundCode, 
                    string accCompany, 
                    int? ledCode, 
                    string ledgerName, 
                    int? balType, 
                    string ledCurrency, 
                    byte? accNature, 
                    string fundName, 
                    int? accSubTypeID, 
                    int? accSubCode, 
                    string subName, 
                    string voucher, 
                    string tran_Comment, 
                    string trStat, 
                    string paidTo, 
                    string mainName, 
                    string ledAccCodeName, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(status, accCode, accName, openbal, tranDate, vchr_no, trnSL_no, refno, v_Type, remarks, debit, trnDebit, drcur, credit, trnCredit, crCur, accFundCode, accCompany, ledCode, ledgerName, balType, ledCurrency, accNature, fundName, accSubTypeID, accSubCode, subName, voucher, tran_Comment, trStat, paidTo, mainName, ledAccCodeName, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("GeneralLedgerReport", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.GeneralLedgerReport> Select(
                    string status, 
                    string accCode, 
                    string accName, 
                    decimal? openbal, 
                    DateTime? tranDate, 
                    string vchr_no, 
                    int? trnSL_no, 
                    string refno, 
                    string v_Type, 
                    string remarks, 
                    decimal? debit, 
                    decimal? trnDebit, 
                    string drcur, 
                    decimal? credit, 
                    decimal? trnCredit, 
                    string crCur, 
                    int? accFundCode, 
                    string accCompany, 
                    int? ledCode, 
                    string ledgerName, 
                    int? balType, 
                    string ledCurrency, 
                    byte? accNature, 
                    string fundName, 
                    int? accSubTypeID, 
                    int? accSubCode, 
                    string subName, 
                    string voucher, 
                    string tran_Comment, 
                    string trStat, 
                    string paidTo, 
                    string mainName, 
                    string ledAccCodeName)
        {
            return Select(status, accCode, accName, openbal, tranDate, vchr_no, trnSL_no, refno, v_Type, remarks, debit, trnDebit, drcur, credit, trnCredit, crCur, accFundCode, accCompany, ledCode, ledgerName, balType, ledCurrency, accNature, fundName, accSubTypeID, accSubCode, subName, voucher, tran_Comment, trStat, paidTo, mainName, ledAccCodeName, null, Int32.MaxValue, 0, SelectView);
        }
        
        public List<MyCompany.Data.Objects.GeneralLedgerReport> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("GeneralLedgerReport", dataView, request);
            return page.ToList<MyCompany.Data.Objects.GeneralLedgerReport>();
        }
        
        public List<MyCompany.Data.Objects.GeneralLedgerReport> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.GeneralLedgerReport> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.GeneralLedgerReport SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.GeneralLedgerReport> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
    }
}
