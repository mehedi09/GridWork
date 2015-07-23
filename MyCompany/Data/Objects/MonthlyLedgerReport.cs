using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class MonthlyLedgerReport
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accFundID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _openBalance;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _debit;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _credit;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _balance;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accBalTypeID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sYear;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sMonth;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _acctypeID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _revenue;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sMonthName;
        
        public MonthlyLedgerReport()
        {
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
        public int? AccCode
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
        public string sYear
        {
            get
            {
                return _sYear;
            }
            set
            {
                _sYear = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string sMonth
        {
            get
            {
                return _sMonth;
            }
            set
            {
                _sMonth = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? AcctypeID
        {
            get
            {
                return _acctypeID;
            }
            set
            {
                _acctypeID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? Revenue
        {
            get
            {
                return _revenue;
            }
            set
            {
                _revenue = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string sMonthName
        {
            get
            {
                return _sMonthName;
            }
            set
            {
                _sMonthName = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.MonthlyLedgerReport> Select(int? accFundID, int? accCode, string accName, decimal? openBalance, decimal? debit, decimal? credit, decimal? balance, int? accBalTypeID, string sYear, string sMonth, int? acctypeID, int? revenue, string sMonthName)
        {
            return new MonthlyLedgerReportFactory().Select(accFundID, accCode, accName, openBalance, debit, credit, balance, accBalTypeID, sYear, sMonth, acctypeID, revenue, sMonthName);
        }
        
        public static List<MyCompany.Data.Objects.MonthlyLedgerReport> Select(MyCompany.Data.Objects.MonthlyLedgerReport qbe)
        {
            return new MonthlyLedgerReportFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.MonthlyLedgerReport> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new MonthlyLedgerReportFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.MonthlyLedgerReport> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new MonthlyLedgerReportFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.MonthlyLedgerReport> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new MonthlyLedgerReportFactory().Select(filter, sort, MonthlyLedgerReportFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.MonthlyLedgerReport> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new MonthlyLedgerReportFactory().Select(filter, sort, MonthlyLedgerReportFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.MonthlyLedgerReport> Select(string filter, BusinessObjectParameters parameters)
        {
            return new MonthlyLedgerReportFactory().Select(filter, null, MonthlyLedgerReportFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.MonthlyLedgerReport> Select(string filter, params FieldValue[] parameters)
        {
            return new MonthlyLedgerReportFactory().Select(filter, null, MonthlyLedgerReportFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.MonthlyLedgerReport SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new MonthlyLedgerReportFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.MonthlyLedgerReport SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new MonthlyLedgerReportFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public override string ToString()
        {
            return String.Format("");
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class MonthlyLedgerReportFactory
    {
        
        public MonthlyLedgerReportFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("MonthlyLedgerReport");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("MonthlyLedgerReport");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("MonthlyLedgerReport");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("MonthlyLedgerReport");
            }
        }
        
        public static MonthlyLedgerReportFactory Create()
        {
            return new MonthlyLedgerReportFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    int? accFundID, 
                    int? accCode, 
                    string accName, 
                    decimal? openBalance, 
                    decimal? debit, 
                    decimal? credit, 
                    decimal? balance, 
                    int? accBalTypeID, 
                    string sYear, 
                    string sMonth, 
                    int? acctypeID, 
                    int? revenue, 
                    string sMonthName, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (accFundID.HasValue)
            	filter.Add(("AccFundID:=" + accFundID.Value.ToString()));
            if (accCode.HasValue)
            	filter.Add(("AccCode:=" + accCode.Value.ToString()));
            if (!(String.IsNullOrEmpty(accName)))
            	filter.Add(("AccName:*" + accName));
            if (openBalance.HasValue)
            	filter.Add(("OpenBalance:=" + openBalance.Value.ToString()));
            if (debit.HasValue)
            	filter.Add(("Debit:=" + debit.Value.ToString()));
            if (credit.HasValue)
            	filter.Add(("Credit:=" + credit.Value.ToString()));
            if (balance.HasValue)
            	filter.Add(("Balance:=" + balance.Value.ToString()));
            if (accBalTypeID.HasValue)
            	filter.Add(("AccBalTypeID:=" + accBalTypeID.Value.ToString()));
            if (!(String.IsNullOrEmpty(sYear)))
            	filter.Add(("sYear:*" + sYear));
            if (!(String.IsNullOrEmpty(sMonth)))
            	filter.Add(("sMonth:*" + sMonth));
            if (acctypeID.HasValue)
            	filter.Add(("AcctypeID:=" + acctypeID.Value.ToString()));
            if (revenue.HasValue)
            	filter.Add(("Revenue:=" + revenue.Value.ToString()));
            if (!(String.IsNullOrEmpty(sMonthName)))
            	filter.Add(("sMonthName:*" + sMonthName));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.MonthlyLedgerReport> Select(
                    int? accFundID, 
                    int? accCode, 
                    string accName, 
                    decimal? openBalance, 
                    decimal? debit, 
                    decimal? credit, 
                    decimal? balance, 
                    int? accBalTypeID, 
                    string sYear, 
                    string sMonth, 
                    int? acctypeID, 
                    int? revenue, 
                    string sMonthName, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(accFundID, accCode, accName, openBalance, debit, credit, balance, accBalTypeID, sYear, sMonth, acctypeID, revenue, sMonthName, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("MonthlyLedgerReport", dataView, request);
            return page.ToList<MyCompany.Data.Objects.MonthlyLedgerReport>();
        }
        
        public List<MyCompany.Data.Objects.MonthlyLedgerReport> Select(MyCompany.Data.Objects.MonthlyLedgerReport qbe)
        {
            return Select(qbe.AccFundID, qbe.AccCode, qbe.AccName, qbe.OpenBalance, qbe.Debit, qbe.Credit, qbe.Balance, qbe.AccBalTypeID, qbe.sYear, qbe.sMonth, qbe.AcctypeID, qbe.Revenue, qbe.sMonthName);
        }
        
        public int SelectCount(
                    int? accFundID, 
                    int? accCode, 
                    string accName, 
                    decimal? openBalance, 
                    decimal? debit, 
                    decimal? credit, 
                    decimal? balance, 
                    int? accBalTypeID, 
                    string sYear, 
                    string sMonth, 
                    int? acctypeID, 
                    int? revenue, 
                    string sMonthName, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(accFundID, accCode, accName, openBalance, debit, credit, balance, accBalTypeID, sYear, sMonth, acctypeID, revenue, sMonthName, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("MonthlyLedgerReport", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.MonthlyLedgerReport> Select(int? accFundID, int? accCode, string accName, decimal? openBalance, decimal? debit, decimal? credit, decimal? balance, int? accBalTypeID, string sYear, string sMonth, int? acctypeID, int? revenue, string sMonthName)
        {
            return Select(accFundID, accCode, accName, openBalance, debit, credit, balance, accBalTypeID, sYear, sMonth, acctypeID, revenue, sMonthName, null, Int32.MaxValue, 0, SelectView);
        }
        
        public List<MyCompany.Data.Objects.MonthlyLedgerReport> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("MonthlyLedgerReport", dataView, request);
            return page.ToList<MyCompany.Data.Objects.MonthlyLedgerReport>();
        }
        
        public List<MyCompany.Data.Objects.MonthlyLedgerReport> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.MonthlyLedgerReport> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.MonthlyLedgerReport SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.MonthlyLedgerReport> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
    }
}
