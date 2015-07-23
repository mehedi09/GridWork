using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class FilterLedgers
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accFundID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _ledAccCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _start_date;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _to_Date;
        
        public FilterLedgers()
        {
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
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
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public int? LedAccCode
        {
            get
            {
                return _ledAccCode;
            }
            set
            {
                _ledAccCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public DateTime? Start_date
        {
            get
            {
                return _start_date;
            }
            set
            {
                _start_date = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public DateTime? To_Date
        {
            get
            {
                return _to_Date;
            }
            set
            {
                _to_Date = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.FilterLedgers> Select()
        {
            return new FilterLedgersFactory().Select();
        }
        
        public static List<MyCompany.Data.Objects.FilterLedgers> Select(MyCompany.Data.Objects.FilterLedgers qbe)
        {
            return new FilterLedgersFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.FilterLedgers> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new FilterLedgersFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.FilterLedgers> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new FilterLedgersFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.FilterLedgers> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new FilterLedgersFactory().Select(filter, sort, FilterLedgersFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.FilterLedgers> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new FilterLedgersFactory().Select(filter, sort, FilterLedgersFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.FilterLedgers> Select(string filter, BusinessObjectParameters parameters)
        {
            return new FilterLedgersFactory().Select(filter, null, FilterLedgersFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.FilterLedgers> Select(string filter, params FieldValue[] parameters)
        {
            return new FilterLedgersFactory().Select(filter, null, FilterLedgersFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.FilterLedgers SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new FilterLedgersFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.FilterLedgers SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new FilterLedgersFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public override string ToString()
        {
            return String.Format("");
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class FilterLedgersFactory
    {
        
        public FilterLedgersFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("FilterLedgers");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("FilterLedgers");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("FilterLedgers");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("FilterLedgers");
            }
        }
        
        public static FilterLedgersFactory Create()
        {
            return new FilterLedgersFactory();
        }
        
        protected virtual PageRequest CreateRequest(string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.FilterLedgers> Select(string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("FilterLedgers", dataView, request);
            return page.ToList<MyCompany.Data.Objects.FilterLedgers>();
        }
        
        public List<MyCompany.Data.Objects.FilterLedgers> Select(MyCompany.Data.Objects.FilterLedgers qbe)
        {
            return Select();
        }
        
        public int SelectCount(string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("FilterLedgers", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.FilterLedgers> Select()
        {
            return Select(null, Int32.MaxValue, 0, SelectView);
        }
        
        public List<MyCompany.Data.Objects.FilterLedgers> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("FilterLedgers", dataView, request);
            return page.ToList<MyCompany.Data.Objects.FilterLedgers>();
        }
        
        public List<MyCompany.Data.Objects.FilterLedgers> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.FilterLedgers> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.FilterLedgers SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.FilterLedgers> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
    }
}
