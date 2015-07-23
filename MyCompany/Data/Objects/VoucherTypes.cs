using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class VoucherTypes
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _vchrTypeID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _vchrTypeDesc;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _vchrType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isDisplay;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _preFixStyle;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isReset;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _voucherNature;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accFundID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isResetMonthend;
        
        public VoucherTypes()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? VchrTypeID
        {
            get
            {
                return _vchrTypeID;
            }
            set
            {
                _vchrTypeID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string VchrTypeDesc
        {
            get
            {
                return _vchrTypeDesc;
            }
            set
            {
                _vchrTypeDesc = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string vchrType
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
        public bool? IsDisplay
        {
            get
            {
                return _isDisplay;
            }
            set
            {
                _isDisplay = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PreFixStyle
        {
            get
            {
                return _preFixStyle;
            }
            set
            {
                _preFixStyle = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? IsReset
        {
            get
            {
                return _isReset;
            }
            set
            {
                _isReset = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string VoucherNature
        {
            get
            {
                return _voucherNature;
            }
            set
            {
                _voucherNature = value;
            }
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
        public bool? IsResetMonthend
        {
            get
            {
                return _isResetMonthend;
            }
            set
            {
                _isResetMonthend = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.VoucherTypes> Select(int? vchrTypeID, string vchrTypeDesc, string vchrType, bool? isDisplay, string preFixStyle, bool? isReset, string voucherNature, int? accFundID, bool? isResetMonthend)
        {
            return new VoucherTypesFactory().Select(vchrTypeID, vchrTypeDesc, vchrType, isDisplay, preFixStyle, isReset, voucherNature, accFundID, isResetMonthend);
        }
        
        public static List<MyCompany.Data.Objects.VoucherTypes> Select(MyCompany.Data.Objects.VoucherTypes qbe)
        {
            return new VoucherTypesFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.VoucherTypes> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new VoucherTypesFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.VoucherTypes> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new VoucherTypesFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.VoucherTypes> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new VoucherTypesFactory().Select(filter, sort, VoucherTypesFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.VoucherTypes> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new VoucherTypesFactory().Select(filter, sort, VoucherTypesFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.VoucherTypes> Select(string filter, BusinessObjectParameters parameters)
        {
            return new VoucherTypesFactory().Select(filter, null, VoucherTypesFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.VoucherTypes> Select(string filter, params FieldValue[] parameters)
        {
            return new VoucherTypesFactory().Select(filter, null, VoucherTypesFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.VoucherTypes SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new VoucherTypesFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.VoucherTypes SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new VoucherTypesFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.VoucherTypes SelectSingle(int? vchrTypeID)
        {
            return new VoucherTypesFactory().SelectSingle(vchrTypeID);
        }
        
        public int Insert()
        {
            return new VoucherTypesFactory().Insert(this);
        }
        
        public int Update()
        {
            return new VoucherTypesFactory().Update(this);
        }
        
        public int Delete()
        {
            return new VoucherTypesFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("VchrTypeID: {0}", this.VchrTypeID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class VoucherTypesFactory
    {
        
        public VoucherTypesFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("VoucherTypes");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("VoucherTypes");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("VoucherTypes");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("VoucherTypes");
            }
        }
        
        public static VoucherTypesFactory Create()
        {
            return new VoucherTypesFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? vchrTypeID, string vchrTypeDesc, string vchrType, bool? isDisplay, string preFixStyle, bool? isReset, string voucherNature, int? accFundID, bool? isResetMonthend, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (vchrTypeID.HasValue)
            	filter.Add(("VchrTypeID:=" + vchrTypeID.Value.ToString()));
            if (!(String.IsNullOrEmpty(vchrTypeDesc)))
            	filter.Add(("VchrTypeDesc:*" + vchrTypeDesc));
            if (!(String.IsNullOrEmpty(vchrType)))
            	filter.Add(("vchrType:*" + vchrType));
            if (isDisplay.HasValue)
            	filter.Add(("IsDisplay:=" + isDisplay.Value.ToString()));
            if (!(String.IsNullOrEmpty(preFixStyle)))
            	filter.Add(("PreFixStyle:*" + preFixStyle));
            if (isReset.HasValue)
            	filter.Add(("IsReset:=" + isReset.Value.ToString()));
            if (!(String.IsNullOrEmpty(voucherNature)))
            	filter.Add(("VoucherNature:*" + voucherNature));
            if (accFundID.HasValue)
            	filter.Add(("AccFundID:=" + accFundID.Value.ToString()));
            if (isResetMonthend.HasValue)
            	filter.Add(("IsResetMonthend:=" + isResetMonthend.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.VoucherTypes> Select(int? vchrTypeID, string vchrTypeDesc, string vchrType, bool? isDisplay, string preFixStyle, bool? isReset, string voucherNature, int? accFundID, bool? isResetMonthend, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(vchrTypeID, vchrTypeDesc, vchrType, isDisplay, preFixStyle, isReset, voucherNature, accFundID, isResetMonthend, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("VoucherTypes", dataView, request);
            return page.ToList<MyCompany.Data.Objects.VoucherTypes>();
        }
        
        public List<MyCompany.Data.Objects.VoucherTypes> Select(MyCompany.Data.Objects.VoucherTypes qbe)
        {
            return Select(qbe.VchrTypeID, qbe.VchrTypeDesc, qbe.vchrType, qbe.IsDisplay, qbe.PreFixStyle, qbe.IsReset, qbe.VoucherNature, qbe.AccFundID, qbe.IsResetMonthend);
        }
        
        public int SelectCount(int? vchrTypeID, string vchrTypeDesc, string vchrType, bool? isDisplay, string preFixStyle, bool? isReset, string voucherNature, int? accFundID, bool? isResetMonthend, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(vchrTypeID, vchrTypeDesc, vchrType, isDisplay, preFixStyle, isReset, voucherNature, accFundID, isResetMonthend, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("VoucherTypes", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.VoucherTypes> Select(int? vchrTypeID, string vchrTypeDesc, string vchrType, bool? isDisplay, string preFixStyle, bool? isReset, string voucherNature, int? accFundID, bool? isResetMonthend)
        {
            return Select(vchrTypeID, vchrTypeDesc, vchrType, isDisplay, preFixStyle, isReset, voucherNature, accFundID, isResetMonthend, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.VoucherTypes SelectSingle(int? vchrTypeID)
        {
            List<MyCompany.Data.Objects.VoucherTypes> list = Select(vchrTypeID, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.VoucherTypes> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("VoucherTypes", dataView, request);
            return page.ToList<MyCompany.Data.Objects.VoucherTypes>();
        }
        
        public List<MyCompany.Data.Objects.VoucherTypes> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.VoucherTypes> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.VoucherTypes SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.VoucherTypes> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.VoucherTypes theVoucherTypes, MyCompany.Data.Objects.VoucherTypes original_VoucherTypes)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("VchrTypeID", original_VoucherTypes.VchrTypeID, theVoucherTypes.VchrTypeID, true));
            values.Add(new FieldValue("VchrTypeDesc", original_VoucherTypes.VchrTypeDesc, theVoucherTypes.VchrTypeDesc));
            values.Add(new FieldValue("vchrType", original_VoucherTypes.vchrType, theVoucherTypes.vchrType));
            values.Add(new FieldValue("IsDisplay", original_VoucherTypes.IsDisplay, theVoucherTypes.IsDisplay));
            values.Add(new FieldValue("PreFixStyle", original_VoucherTypes.PreFixStyle, theVoucherTypes.PreFixStyle));
            values.Add(new FieldValue("IsReset", original_VoucherTypes.IsReset, theVoucherTypes.IsReset));
            values.Add(new FieldValue("VoucherNature", original_VoucherTypes.VoucherNature, theVoucherTypes.VoucherNature));
            values.Add(new FieldValue("AccFundID", original_VoucherTypes.AccFundID, theVoucherTypes.AccFundID));
            values.Add(new FieldValue("IsResetMonthend", original_VoucherTypes.IsResetMonthend, theVoucherTypes.IsResetMonthend));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.VoucherTypes theVoucherTypes, MyCompany.Data.Objects.VoucherTypes original_VoucherTypes, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "VoucherTypes";
            args.View = dataView;
            args.Values = CreateFieldValues(theVoucherTypes, original_VoucherTypes);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("VoucherTypes", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theVoucherTypes);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.VoucherTypes theVoucherTypes, MyCompany.Data.Objects.VoucherTypes original_VoucherTypes)
        {
            return ExecuteAction(theVoucherTypes, original_VoucherTypes, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.VoucherTypes theVoucherTypes)
        {
            return Update(theVoucherTypes, SelectSingle(theVoucherTypes.VchrTypeID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.VoucherTypes theVoucherTypes)
        {
            return ExecuteAction(theVoucherTypes, new VoucherTypes(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.VoucherTypes theVoucherTypes)
        {
            return ExecuteAction(theVoucherTypes, theVoucherTypes, "Select", "Delete", DeleteView);
        }
    }
}
