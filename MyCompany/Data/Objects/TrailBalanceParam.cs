using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class TrailBalanceParam
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _frDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _toDate;
        
        public TrailBalanceParam()
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public DateTime? FrDate
        {
            get
            {
                return _frDate;
            }
            set
            {
                _frDate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public DateTime? ToDate
        {
            get
            {
                return _toDate;
            }
            set
            {
                _toDate = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.TrailBalanceParam> Select(int? accFundCode)
        {
            return new TrailBalanceParamFactory().Select(accFundCode);
        }
        
        public static List<MyCompany.Data.Objects.TrailBalanceParam> Select(MyCompany.Data.Objects.TrailBalanceParam qbe)
        {
            return new TrailBalanceParamFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.TrailBalanceParam> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new TrailBalanceParamFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.TrailBalanceParam> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new TrailBalanceParamFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.TrailBalanceParam> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new TrailBalanceParamFactory().Select(filter, sort, TrailBalanceParamFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.TrailBalanceParam> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new TrailBalanceParamFactory().Select(filter, sort, TrailBalanceParamFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.TrailBalanceParam> Select(string filter, BusinessObjectParameters parameters)
        {
            return new TrailBalanceParamFactory().Select(filter, null, TrailBalanceParamFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.TrailBalanceParam> Select(string filter, params FieldValue[] parameters)
        {
            return new TrailBalanceParamFactory().Select(filter, null, TrailBalanceParamFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.TrailBalanceParam SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new TrailBalanceParamFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.TrailBalanceParam SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new TrailBalanceParamFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public override string ToString()
        {
            return String.Format("");
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class TrailBalanceParamFactory
    {
        
        public TrailBalanceParamFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("TrailBalanceParam");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("TrailBalanceParam");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("TrailBalanceParam");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("TrailBalanceParam");
            }
        }
        
        public static TrailBalanceParamFactory Create()
        {
            return new TrailBalanceParamFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? accFundCode, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (accFundCode.HasValue)
            	filter.Add(("AccFundCode:=" + accFundCode.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.TrailBalanceParam> Select(int? accFundCode, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(accFundCode, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("TrailBalanceParam", dataView, request);
            return page.ToList<MyCompany.Data.Objects.TrailBalanceParam>();
        }
        
        public List<MyCompany.Data.Objects.TrailBalanceParam> Select(MyCompany.Data.Objects.TrailBalanceParam qbe)
        {
            return Select(qbe.AccFundCode);
        }
        
        public int SelectCount(int? accFundCode, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(accFundCode, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("TrailBalanceParam", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.TrailBalanceParam> Select(int? accFundCode)
        {
            return Select(accFundCode, null, Int32.MaxValue, 0, SelectView);
        }
        
        public List<MyCompany.Data.Objects.TrailBalanceParam> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("TrailBalanceParam", dataView, request);
            return page.ToList<MyCompany.Data.Objects.TrailBalanceParam>();
        }
        
        public List<MyCompany.Data.Objects.TrailBalanceParam> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.TrailBalanceParam> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.TrailBalanceParam SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.TrailBalanceParam> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
    }
}
