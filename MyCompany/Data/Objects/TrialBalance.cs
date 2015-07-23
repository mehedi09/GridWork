using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class TrialBalance
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _coaDetailID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accbalTypeID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accTypeID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _openBalance;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _debit;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _credit;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _clsDebit;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _clsCredit;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _balance;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tranCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _natureAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _groupLedgerName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _controlLedgerName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _company;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _address;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _fundName;
        
        public TrialBalance()
        {
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
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
        public int? AccbalTypeID
        {
            get
            {
                return _accbalTypeID;
            }
            set
            {
                _accbalTypeID = value;
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
        public decimal? ClsDebit
        {
            get
            {
                return _clsDebit;
            }
            set
            {
                _clsDebit = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public decimal? ClsCredit
        {
            get
            {
                return _clsCredit;
            }
            set
            {
                _clsCredit = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public decimal? balance
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
        public string TranCode
        {
            get
            {
                return _tranCode;
            }
            set
            {
                _tranCode = value;
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
        public string GroupLedgerName
        {
            get
            {
                return _groupLedgerName;
            }
            set
            {
                _groupLedgerName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ControlLedgerName
        {
            get
            {
                return _controlLedgerName;
            }
            set
            {
                _controlLedgerName = value;
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
        
        public static List<MyCompany.Data.Objects.TrialBalance> Select(
                    int? coaDetailID, 
                    string accName, 
                    int? accbalTypeID, 
                    int? accTypeID, 
                    decimal? openBalance, 
                    decimal? debit, 
                    decimal? credit, 
                    decimal? clsDebit, 
                    decimal? clsCredit, 
                    decimal? balance, 
                    string tranCode, 
                    string natureAccName, 
                    string groupLedgerName, 
                    string controlLedgerName, 
                    string company, 
                    string address, 
                    string fundName)
        {
            return new TrialBalanceFactory().Select(coaDetailID, accName, accbalTypeID, accTypeID, openBalance, debit, credit, clsDebit, clsCredit, balance, tranCode, natureAccName, groupLedgerName, controlLedgerName, company, address, fundName);
        }
        
        public static List<MyCompany.Data.Objects.TrialBalance> Select(MyCompany.Data.Objects.TrialBalance qbe)
        {
            return new TrialBalanceFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.TrialBalance> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new TrialBalanceFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.TrialBalance> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new TrialBalanceFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.TrialBalance> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new TrialBalanceFactory().Select(filter, sort, TrialBalanceFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.TrialBalance> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new TrialBalanceFactory().Select(filter, sort, TrialBalanceFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.TrialBalance> Select(string filter, BusinessObjectParameters parameters)
        {
            return new TrialBalanceFactory().Select(filter, null, TrialBalanceFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.TrialBalance> Select(string filter, params FieldValue[] parameters)
        {
            return new TrialBalanceFactory().Select(filter, null, TrialBalanceFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.TrialBalance SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new TrialBalanceFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.TrialBalance SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new TrialBalanceFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public override string ToString()
        {
            return String.Format("");
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class TrialBalanceFactory
    {
        
        public TrialBalanceFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("TrialBalance");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("TrialBalance");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("TrialBalance");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("TrialBalance");
            }
        }
        
        public static TrialBalanceFactory Create()
        {
            return new TrialBalanceFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    int? coaDetailID, 
                    string accName, 
                    int? accbalTypeID, 
                    int? accTypeID, 
                    decimal? openBalance, 
                    decimal? debit, 
                    decimal? credit, 
                    decimal? clsDebit, 
                    decimal? clsCredit, 
                    decimal? balance, 
                    string tranCode, 
                    string natureAccName, 
                    string groupLedgerName, 
                    string controlLedgerName, 
                    string company, 
                    string address, 
                    string fundName, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (coaDetailID.HasValue)
            	filter.Add(("CoaDetailID:=" + coaDetailID.Value.ToString()));
            if (!(String.IsNullOrEmpty(accName)))
            	filter.Add(("AccName:*" + accName));
            if (accbalTypeID.HasValue)
            	filter.Add(("AccbalTypeID:=" + accbalTypeID.Value.ToString()));
            if (accTypeID.HasValue)
            	filter.Add(("AccTypeID:=" + accTypeID.Value.ToString()));
            if (openBalance.HasValue)
            	filter.Add(("OpenBalance:=" + openBalance.Value.ToString()));
            if (debit.HasValue)
            	filter.Add(("Debit:=" + debit.Value.ToString()));
            if (credit.HasValue)
            	filter.Add(("Credit:=" + credit.Value.ToString()));
            if (clsDebit.HasValue)
            	filter.Add(("ClsDebit:=" + clsDebit.Value.ToString()));
            if (clsCredit.HasValue)
            	filter.Add(("ClsCredit:=" + clsCredit.Value.ToString()));
            if (balance.HasValue)
            	filter.Add(("balance:=" + balance.Value.ToString()));
            if (!(String.IsNullOrEmpty(tranCode)))
            	filter.Add(("TranCode:*" + tranCode));
            if (!(String.IsNullOrEmpty(natureAccName)))
            	filter.Add(("NatureAccName:*" + natureAccName));
            if (!(String.IsNullOrEmpty(groupLedgerName)))
            	filter.Add(("GroupLedgerName:*" + groupLedgerName));
            if (!(String.IsNullOrEmpty(controlLedgerName)))
            	filter.Add(("ControlLedgerName:*" + controlLedgerName));
            if (!(String.IsNullOrEmpty(company)))
            	filter.Add(("Company:*" + company));
            if (!(String.IsNullOrEmpty(address)))
            	filter.Add(("Address:*" + address));
            if (!(String.IsNullOrEmpty(fundName)))
            	filter.Add(("FundName:*" + fundName));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.TrialBalance> Select(
                    int? coaDetailID, 
                    string accName, 
                    int? accbalTypeID, 
                    int? accTypeID, 
                    decimal? openBalance, 
                    decimal? debit, 
                    decimal? credit, 
                    decimal? clsDebit, 
                    decimal? clsCredit, 
                    decimal? balance, 
                    string tranCode, 
                    string natureAccName, 
                    string groupLedgerName, 
                    string controlLedgerName, 
                    string company, 
                    string address, 
                    string fundName, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(coaDetailID, accName, accbalTypeID, accTypeID, openBalance, debit, credit, clsDebit, clsCredit, balance, tranCode, natureAccName, groupLedgerName, controlLedgerName, company, address, fundName, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("TrialBalance", dataView, request);
            return page.ToList<MyCompany.Data.Objects.TrialBalance>();
        }
        
        public List<MyCompany.Data.Objects.TrialBalance> Select(MyCompany.Data.Objects.TrialBalance qbe)
        {
            return Select(qbe.CoaDetailID, qbe.AccName, qbe.AccbalTypeID, qbe.AccTypeID, qbe.OpenBalance, qbe.Debit, qbe.Credit, qbe.ClsDebit, qbe.ClsCredit, qbe.balance, qbe.TranCode, qbe.NatureAccName, qbe.GroupLedgerName, qbe.ControlLedgerName, qbe.Company, qbe.Address, qbe.FundName);
        }
        
        public int SelectCount(
                    int? coaDetailID, 
                    string accName, 
                    int? accbalTypeID, 
                    int? accTypeID, 
                    decimal? openBalance, 
                    decimal? debit, 
                    decimal? credit, 
                    decimal? clsDebit, 
                    decimal? clsCredit, 
                    decimal? balance, 
                    string tranCode, 
                    string natureAccName, 
                    string groupLedgerName, 
                    string controlLedgerName, 
                    string company, 
                    string address, 
                    string fundName, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(coaDetailID, accName, accbalTypeID, accTypeID, openBalance, debit, credit, clsDebit, clsCredit, balance, tranCode, natureAccName, groupLedgerName, controlLedgerName, company, address, fundName, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("TrialBalance", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.TrialBalance> Select(
                    int? coaDetailID, 
                    string accName, 
                    int? accbalTypeID, 
                    int? accTypeID, 
                    decimal? openBalance, 
                    decimal? debit, 
                    decimal? credit, 
                    decimal? clsDebit, 
                    decimal? clsCredit, 
                    decimal? balance, 
                    string tranCode, 
                    string natureAccName, 
                    string groupLedgerName, 
                    string controlLedgerName, 
                    string company, 
                    string address, 
                    string fundName)
        {
            return Select(coaDetailID, accName, accbalTypeID, accTypeID, openBalance, debit, credit, clsDebit, clsCredit, balance, tranCode, natureAccName, groupLedgerName, controlLedgerName, company, address, fundName, null, Int32.MaxValue, 0, SelectView);
        }
        
        public List<MyCompany.Data.Objects.TrialBalance> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("TrialBalance", dataView, request);
            return page.ToList<MyCompany.Data.Objects.TrialBalance>();
        }
        
        public List<MyCompany.Data.Objects.TrialBalance> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.TrialBalance> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.TrialBalance SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.TrialBalance> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
    }
}
