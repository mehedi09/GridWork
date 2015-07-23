using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class ReceipsAndPayments
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _slno;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _fundName;
        
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
        
        public ReceipsAndPayments()
        {
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string Slno
        {
            get
            {
                return _slno;
            }
            set
            {
                _slno = value;
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
        
        public static List<MyCompany.Data.Objects.ReceipsAndPayments> Select(string slno, int? accCode, string fundName, string accName, decimal? openBalance, decimal? debit, decimal? credit, decimal? balance)
        {
            return new ReceipsAndPaymentsFactory().Select(slno, accCode, fundName, accName, openBalance, debit, credit, balance);
        }
        
        public static List<MyCompany.Data.Objects.ReceipsAndPayments> Select(MyCompany.Data.Objects.ReceipsAndPayments qbe)
        {
            return new ReceipsAndPaymentsFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.ReceipsAndPayments> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new ReceipsAndPaymentsFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.ReceipsAndPayments> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new ReceipsAndPaymentsFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.ReceipsAndPayments> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new ReceipsAndPaymentsFactory().Select(filter, sort, ReceipsAndPaymentsFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.ReceipsAndPayments> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new ReceipsAndPaymentsFactory().Select(filter, sort, ReceipsAndPaymentsFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.ReceipsAndPayments> Select(string filter, BusinessObjectParameters parameters)
        {
            return new ReceipsAndPaymentsFactory().Select(filter, null, ReceipsAndPaymentsFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.ReceipsAndPayments> Select(string filter, params FieldValue[] parameters)
        {
            return new ReceipsAndPaymentsFactory().Select(filter, null, ReceipsAndPaymentsFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.ReceipsAndPayments SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new ReceipsAndPaymentsFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.ReceipsAndPayments SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new ReceipsAndPaymentsFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public override string ToString()
        {
            return String.Format("");
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class ReceipsAndPaymentsFactory
    {
        
        public ReceipsAndPaymentsFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("ReceipsAndPayments");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("ReceipsAndPayments");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("ReceipsAndPayments");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("ReceipsAndPayments");
            }
        }
        
        public static ReceipsAndPaymentsFactory Create()
        {
            return new ReceipsAndPaymentsFactory();
        }
        
        protected virtual PageRequest CreateRequest(string slno, int? accCode, string fundName, string accName, decimal? openBalance, decimal? debit, decimal? credit, decimal? balance, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (!(String.IsNullOrEmpty(slno)))
            	filter.Add(("Slno:*" + slno));
            if (accCode.HasValue)
            	filter.Add(("AccCode:=" + accCode.Value.ToString()));
            if (!(String.IsNullOrEmpty(fundName)))
            	filter.Add(("FundName:*" + fundName));
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
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.ReceipsAndPayments> Select(string slno, int? accCode, string fundName, string accName, decimal? openBalance, decimal? debit, decimal? credit, decimal? balance, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(slno, accCode, fundName, accName, openBalance, debit, credit, balance, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("ReceipsAndPayments", dataView, request);
            return page.ToList<MyCompany.Data.Objects.ReceipsAndPayments>();
        }
        
        public List<MyCompany.Data.Objects.ReceipsAndPayments> Select(MyCompany.Data.Objects.ReceipsAndPayments qbe)
        {
            return Select(qbe.Slno, qbe.AccCode, qbe.FundName, qbe.AccName, qbe.OpenBalance, qbe.Debit, qbe.Credit, qbe.Balance);
        }
        
        public int SelectCount(string slno, int? accCode, string fundName, string accName, decimal? openBalance, decimal? debit, decimal? credit, decimal? balance, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(slno, accCode, fundName, accName, openBalance, debit, credit, balance, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("ReceipsAndPayments", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.ReceipsAndPayments> Select(string slno, int? accCode, string fundName, string accName, decimal? openBalance, decimal? debit, decimal? credit, decimal? balance)
        {
            return Select(slno, accCode, fundName, accName, openBalance, debit, credit, balance, null, Int32.MaxValue, 0, SelectView);
        }
        
        public List<MyCompany.Data.Objects.ReceipsAndPayments> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("ReceipsAndPayments", dataView, request);
            return page.ToList<MyCompany.Data.Objects.ReceipsAndPayments>();
        }
        
        public List<MyCompany.Data.Objects.ReceipsAndPayments> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.ReceipsAndPayments> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.ReceipsAndPayments SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.ReceipsAndPayments> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
    }
}
