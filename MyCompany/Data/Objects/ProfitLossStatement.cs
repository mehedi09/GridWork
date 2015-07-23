using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class ProfitLossStatement
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _coaDetailID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accBalTypeID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accTypeID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _natureAcc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _natureAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _natureAccDesc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _openBalance;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _debit;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _credit;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _balance;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _coaControlID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _pAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _coaSubID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _coaMainID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _mAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _rptSlno;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _currencyName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _company;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _address;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _fundName;
        
        public ProfitLossStatement()
        {
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
        public int? CoaDetailID
        {
            get
            {
                return _coaDetailID;
            }
            set
            {
                _coaDetailID = value;
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? AccBalTypeID
        {
            get
            {
                return _accBalTypeID;
            }
            set
            {
                _accBalTypeID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? AccTypeID
        {
            get
            {
                return _accTypeID;
            }
            set
            {
                _accTypeID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? NatureAcc
        {
            get
            {
                return _natureAcc;
            }
            set
            {
                _natureAcc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NatureAccName
        {
            get
            {
                return _natureAccName;
            }
            set
            {
                _natureAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NatureAccDesc
        {
            get
            {
                return _natureAccDesc;
            }
            set
            {
                _natureAccDesc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public decimal? OpenBalance
        {
            get
            {
                return _openBalance;
            }
            set
            {
                _openBalance = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
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
        public decimal? Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? CoaControlID
        {
            get
            {
                return _coaControlID;
            }
            set
            {
                _coaControlID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PAccName
        {
            get
            {
                return _pAccName;
            }
            set
            {
                _pAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? CoaSubID
        {
            get
            {
                return _coaSubID;
            }
            set
            {
                _coaSubID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SAccName
        {
            get
            {
                return _sAccName;
            }
            set
            {
                _sAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? CoaMainID
        {
            get
            {
                return _coaMainID;
            }
            set
            {
                _coaMainID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string MAccName
        {
            get
            {
                return _mAccName;
            }
            set
            {
                _mAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? RptSlno
        {
            get
            {
                return _rptSlno;
            }
            set
            {
                _rptSlno = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CurrencyName
        {
            get
            {
                return _currencyName;
            }
            set
            {
                _currencyName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Company
        {
            get
            {
                return _company;
            }
            set
            {
                _company = value;
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
        
        public static List<MyCompany.Data.Objects.ProfitLossStatement> Select(
                    int? accFundCode, 
                    int? coaDetailID, 
                    string accName, 
                    int? accBalTypeID, 
                    int? accTypeID, 
                    int? natureAcc, 
                    string natureAccName, 
                    string natureAccDesc, 
                    decimal? openBalance, 
                    decimal? debit, 
                    decimal? credit, 
                    decimal? balance, 
                    int? coaControlID, 
                    string pAccName, 
                    int? coaSubID, 
                    string sAccName, 
                    int? coaMainID, 
                    string mAccName, 
                    int? rptSlno, 
                    string currencyName, 
                    string company, 
                    string address, 
                    string fundName)
        {
            return new ProfitLossStatementFactory().Select(accFundCode, coaDetailID, accName, accBalTypeID, accTypeID, natureAcc, natureAccName, natureAccDesc, openBalance, debit, credit, balance, coaControlID, pAccName, coaSubID, sAccName, coaMainID, mAccName, rptSlno, currencyName, company, address, fundName);
        }
        
        public static List<MyCompany.Data.Objects.ProfitLossStatement> Select(MyCompany.Data.Objects.ProfitLossStatement qbe)
        {
            return new ProfitLossStatementFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.ProfitLossStatement> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new ProfitLossStatementFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.ProfitLossStatement> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new ProfitLossStatementFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.ProfitLossStatement> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new ProfitLossStatementFactory().Select(filter, sort, ProfitLossStatementFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.ProfitLossStatement> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new ProfitLossStatementFactory().Select(filter, sort, ProfitLossStatementFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.ProfitLossStatement> Select(string filter, BusinessObjectParameters parameters)
        {
            return new ProfitLossStatementFactory().Select(filter, null, ProfitLossStatementFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.ProfitLossStatement> Select(string filter, params FieldValue[] parameters)
        {
            return new ProfitLossStatementFactory().Select(filter, null, ProfitLossStatementFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.ProfitLossStatement SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new ProfitLossStatementFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.ProfitLossStatement SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new ProfitLossStatementFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public override string ToString()
        {
            return String.Format("");
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class ProfitLossStatementFactory
    {
        
        public ProfitLossStatementFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("ProfitLossStatement");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("ProfitLossStatement");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("ProfitLossStatement");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("ProfitLossStatement");
            }
        }
        
        public static ProfitLossStatementFactory Create()
        {
            return new ProfitLossStatementFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    int? accFundCode, 
                    int? coaDetailID, 
                    string accName, 
                    int? accBalTypeID, 
                    int? accTypeID, 
                    int? natureAcc, 
                    string natureAccName, 
                    string natureAccDesc, 
                    decimal? openBalance, 
                    decimal? debit, 
                    decimal? credit, 
                    decimal? balance, 
                    int? coaControlID, 
                    string pAccName, 
                    int? coaSubID, 
                    string sAccName, 
                    int? coaMainID, 
                    string mAccName, 
                    int? rptSlno, 
                    string currencyName, 
                    string company, 
                    string address, 
                    string fundName, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (accFundCode.HasValue)
            	filter.Add(("AccFundCode:=" + accFundCode.Value.ToString()));
            if (coaDetailID.HasValue)
            	filter.Add(("CoaDetailID:=" + coaDetailID.Value.ToString()));
            if (!(String.IsNullOrEmpty(accName)))
            	filter.Add(("AccName:*" + accName));
            if (accBalTypeID.HasValue)
            	filter.Add(("AccBalTypeID:=" + accBalTypeID.Value.ToString()));
            if (accTypeID.HasValue)
            	filter.Add(("AccTypeID:=" + accTypeID.Value.ToString()));
            if (natureAcc.HasValue)
            	filter.Add(("NatureAcc:=" + natureAcc.Value.ToString()));
            if (!(String.IsNullOrEmpty(natureAccName)))
            	filter.Add(("NatureAccName:*" + natureAccName));
            if (!(String.IsNullOrEmpty(natureAccDesc)))
            	filter.Add(("NatureAccDesc:*" + natureAccDesc));
            if (openBalance.HasValue)
            	filter.Add(("OpenBalance:=" + openBalance.Value.ToString()));
            if (debit.HasValue)
            	filter.Add(("Debit:=" + debit.Value.ToString()));
            if (credit.HasValue)
            	filter.Add(("Credit:=" + credit.Value.ToString()));
            if (balance.HasValue)
            	filter.Add(("Balance:=" + balance.Value.ToString()));
            if (coaControlID.HasValue)
            	filter.Add(("CoaControlID:=" + coaControlID.Value.ToString()));
            if (!(String.IsNullOrEmpty(pAccName)))
            	filter.Add(("PAccName:*" + pAccName));
            if (coaSubID.HasValue)
            	filter.Add(("CoaSubID:=" + coaSubID.Value.ToString()));
            if (!(String.IsNullOrEmpty(sAccName)))
            	filter.Add(("SAccName:*" + sAccName));
            if (coaMainID.HasValue)
            	filter.Add(("CoaMainID:=" + coaMainID.Value.ToString()));
            if (!(String.IsNullOrEmpty(mAccName)))
            	filter.Add(("MAccName:*" + mAccName));
            if (rptSlno.HasValue)
            	filter.Add(("RptSlno:=" + rptSlno.Value.ToString()));
            if (!(String.IsNullOrEmpty(currencyName)))
            	filter.Add(("CurrencyName:*" + currencyName));
            if (!(String.IsNullOrEmpty(company)))
            	filter.Add(("Company:*" + company));
            if (!(String.IsNullOrEmpty(address)))
            	filter.Add(("Address:*" + address));
            if (!(String.IsNullOrEmpty(fundName)))
            	filter.Add(("FundName:*" + fundName));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.ProfitLossStatement> Select(
                    int? accFundCode, 
                    int? coaDetailID, 
                    string accName, 
                    int? accBalTypeID, 
                    int? accTypeID, 
                    int? natureAcc, 
                    string natureAccName, 
                    string natureAccDesc, 
                    decimal? openBalance, 
                    decimal? debit, 
                    decimal? credit, 
                    decimal? balance, 
                    int? coaControlID, 
                    string pAccName, 
                    int? coaSubID, 
                    string sAccName, 
                    int? coaMainID, 
                    string mAccName, 
                    int? rptSlno, 
                    string currencyName, 
                    string company, 
                    string address, 
                    string fundName, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(accFundCode, coaDetailID, accName, accBalTypeID, accTypeID, natureAcc, natureAccName, natureAccDesc, openBalance, debit, credit, balance, coaControlID, pAccName, coaSubID, sAccName, coaMainID, mAccName, rptSlno, currencyName, company, address, fundName, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("ProfitLossStatement", dataView, request);
            return page.ToList<MyCompany.Data.Objects.ProfitLossStatement>();
        }
        
        public List<MyCompany.Data.Objects.ProfitLossStatement> Select(MyCompany.Data.Objects.ProfitLossStatement qbe)
        {
            return Select(qbe.AccFundCode, qbe.CoaDetailID, qbe.AccName, qbe.AccBalTypeID, qbe.AccTypeID, qbe.NatureAcc, qbe.NatureAccName, qbe.NatureAccDesc, qbe.OpenBalance, qbe.Debit, qbe.Credit, qbe.Balance, qbe.CoaControlID, qbe.PAccName, qbe.CoaSubID, qbe.SAccName, qbe.CoaMainID, qbe.MAccName, qbe.RptSlno, qbe.CurrencyName, qbe.Company, qbe.Address, qbe.FundName);
        }
        
        public int SelectCount(
                    int? accFundCode, 
                    int? coaDetailID, 
                    string accName, 
                    int? accBalTypeID, 
                    int? accTypeID, 
                    int? natureAcc, 
                    string natureAccName, 
                    string natureAccDesc, 
                    decimal? openBalance, 
                    decimal? debit, 
                    decimal? credit, 
                    decimal? balance, 
                    int? coaControlID, 
                    string pAccName, 
                    int? coaSubID, 
                    string sAccName, 
                    int? coaMainID, 
                    string mAccName, 
                    int? rptSlno, 
                    string currencyName, 
                    string company, 
                    string address, 
                    string fundName, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(accFundCode, coaDetailID, accName, accBalTypeID, accTypeID, natureAcc, natureAccName, natureAccDesc, openBalance, debit, credit, balance, coaControlID, pAccName, coaSubID, sAccName, coaMainID, mAccName, rptSlno, currencyName, company, address, fundName, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("ProfitLossStatement", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.ProfitLossStatement> Select(
                    int? accFundCode, 
                    int? coaDetailID, 
                    string accName, 
                    int? accBalTypeID, 
                    int? accTypeID, 
                    int? natureAcc, 
                    string natureAccName, 
                    string natureAccDesc, 
                    decimal? openBalance, 
                    decimal? debit, 
                    decimal? credit, 
                    decimal? balance, 
                    int? coaControlID, 
                    string pAccName, 
                    int? coaSubID, 
                    string sAccName, 
                    int? coaMainID, 
                    string mAccName, 
                    int? rptSlno, 
                    string currencyName, 
                    string company, 
                    string address, 
                    string fundName)
        {
            return Select(accFundCode, coaDetailID, accName, accBalTypeID, accTypeID, natureAcc, natureAccName, natureAccDesc, openBalance, debit, credit, balance, coaControlID, pAccName, coaSubID, sAccName, coaMainID, mAccName, rptSlno, currencyName, company, address, fundName, null, Int32.MaxValue, 0, SelectView);
        }
        
        public List<MyCompany.Data.Objects.ProfitLossStatement> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("ProfitLossStatement", dataView, request);
            return page.ToList<MyCompany.Data.Objects.ProfitLossStatement>();
        }
        
        public List<MyCompany.Data.Objects.ProfitLossStatement> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.ProfitLossStatement> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.ProfitLossStatement SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.ProfitLossStatement> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
    }
}
