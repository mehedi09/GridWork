using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class YearMonthParam
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accFundCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _frDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _toDate;
        
        public YearMonthParam()
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
        
        public static List<MyCompany.Data.Objects.YearMonthParam> Select()
        {
            return new YearMonthParamFactory().Select();
        }
        
        public static List<MyCompany.Data.Objects.YearMonthParam> Select(MyCompany.Data.Objects.YearMonthParam qbe)
        {
            return new YearMonthParamFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.YearMonthParam> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new YearMonthParamFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.YearMonthParam> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new YearMonthParamFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.YearMonthParam> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new YearMonthParamFactory().Select(filter, sort, YearMonthParamFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.YearMonthParam> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new YearMonthParamFactory().Select(filter, sort, YearMonthParamFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.YearMonthParam> Select(string filter, BusinessObjectParameters parameters)
        {
            return new YearMonthParamFactory().Select(filter, null, YearMonthParamFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.YearMonthParam> Select(string filter, params FieldValue[] parameters)
        {
            return new YearMonthParamFactory().Select(filter, null, YearMonthParamFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.YearMonthParam SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new YearMonthParamFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.YearMonthParam SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new YearMonthParamFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public override string ToString()
        {
            return String.Format("");
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class YearMonthParamFactory
    {
        
        public YearMonthParamFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("YearMonthParam");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("YearMonthParam");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("YearMonthParam");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("YearMonthParam");
            }
        }
        
        public static YearMonthParamFactory Create()
        {
            return new YearMonthParamFactory();
        }
        
        protected virtual PageRequest CreateRequest(string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.YearMonthParam> Select(string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("YearMonthParam", dataView, request);
            return page.ToList<MyCompany.Data.Objects.YearMonthParam>();
        }
        
        public List<MyCompany.Data.Objects.YearMonthParam> Select(MyCompany.Data.Objects.YearMonthParam qbe)
        {
            return Select();
        }
        
        public int SelectCount(string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("YearMonthParam", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.YearMonthParam> Select()
        {
            return Select(null, Int32.MaxValue, 0, SelectView);
        }
        
        public List<MyCompany.Data.Objects.YearMonthParam> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("YearMonthParam", dataView, request);
            return page.ToList<MyCompany.Data.Objects.YearMonthParam>();
        }
        
        public List<MyCompany.Data.Objects.YearMonthParam> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.YearMonthParam> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.YearMonthParam SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.YearMonthParam> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
    }
}
