using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class PreFixSetting
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _preFixID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accFundID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _prefixGRN;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _prefixISS;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _prefixPO;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _preFixMRGEN;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _preFixMRSALE;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _preFixPDCGEN;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _preFixPDCSALE;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _preFixAppl;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _prefixDeposit;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _prefixBillReg;
        
        public PreFixSetting()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? PreFixID
        {
            get
            {
                return _preFixID;
            }
            set
            {
                _preFixID = value;
            }
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PrefixGRN
        {
            get
            {
                return _prefixGRN;
            }
            set
            {
                _prefixGRN = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PrefixISS
        {
            get
            {
                return _prefixISS;
            }
            set
            {
                _prefixISS = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PrefixPO
        {
            get
            {
                return _prefixPO;
            }
            set
            {
                _prefixPO = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PreFixMRGEN
        {
            get
            {
                return _preFixMRGEN;
            }
            set
            {
                _preFixMRGEN = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PreFixMRSALE
        {
            get
            {
                return _preFixMRSALE;
            }
            set
            {
                _preFixMRSALE = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PreFixPDCGEN
        {
            get
            {
                return _preFixPDCGEN;
            }
            set
            {
                _preFixPDCGEN = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PreFixPDCSALE
        {
            get
            {
                return _preFixPDCSALE;
            }
            set
            {
                _preFixPDCSALE = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PreFixAppl
        {
            get
            {
                return _preFixAppl;
            }
            set
            {
                _preFixAppl = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PrefixDeposit
        {
            get
            {
                return _prefixDeposit;
            }
            set
            {
                _prefixDeposit = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PrefixBillReg
        {
            get
            {
                return _prefixBillReg;
            }
            set
            {
                _prefixBillReg = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.PreFixSetting> Select(int? preFixID, int? accFundID, string prefixGRN, string prefixISS, string prefixPO, string preFixMRGEN, string preFixMRSALE, string preFixPDCGEN, string preFixPDCSALE, string preFixAppl, string prefixDeposit, string prefixBillReg)
        {
            return new PreFixSettingFactory().Select(preFixID, accFundID, prefixGRN, prefixISS, prefixPO, preFixMRGEN, preFixMRSALE, preFixPDCGEN, preFixPDCSALE, preFixAppl, prefixDeposit, prefixBillReg);
        }
        
        public static List<MyCompany.Data.Objects.PreFixSetting> Select(MyCompany.Data.Objects.PreFixSetting qbe)
        {
            return new PreFixSettingFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.PreFixSetting> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new PreFixSettingFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.PreFixSetting> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new PreFixSettingFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.PreFixSetting> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new PreFixSettingFactory().Select(filter, sort, PreFixSettingFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.PreFixSetting> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new PreFixSettingFactory().Select(filter, sort, PreFixSettingFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.PreFixSetting> Select(string filter, BusinessObjectParameters parameters)
        {
            return new PreFixSettingFactory().Select(filter, null, PreFixSettingFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.PreFixSetting> Select(string filter, params FieldValue[] parameters)
        {
            return new PreFixSettingFactory().Select(filter, null, PreFixSettingFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.PreFixSetting SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new PreFixSettingFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.PreFixSetting SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new PreFixSettingFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.PreFixSetting SelectSingle(int? preFixID)
        {
            return new PreFixSettingFactory().SelectSingle(preFixID);
        }
        
        public int Insert()
        {
            return new PreFixSettingFactory().Insert(this);
        }
        
        public int Update()
        {
            return new PreFixSettingFactory().Update(this);
        }
        
        public int Delete()
        {
            return new PreFixSettingFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("PreFixID: {0}", this.PreFixID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class PreFixSettingFactory
    {
        
        public PreFixSettingFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("PreFixSetting");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("PreFixSetting");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("PreFixSetting");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("PreFixSetting");
            }
        }
        
        public static PreFixSettingFactory Create()
        {
            return new PreFixSettingFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? preFixID, int? accFundID, string prefixGRN, string prefixISS, string prefixPO, string preFixMRGEN, string preFixMRSALE, string preFixPDCGEN, string preFixPDCSALE, string preFixAppl, string prefixDeposit, string prefixBillReg, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (preFixID.HasValue)
            	filter.Add(("PreFixID:=" + preFixID.Value.ToString()));
            if (accFundID.HasValue)
            	filter.Add(("AccFundID:=" + accFundID.Value.ToString()));
            if (!(String.IsNullOrEmpty(prefixGRN)))
            	filter.Add(("PrefixGRN:*" + prefixGRN));
            if (!(String.IsNullOrEmpty(prefixISS)))
            	filter.Add(("PrefixISS:*" + prefixISS));
            if (!(String.IsNullOrEmpty(prefixPO)))
            	filter.Add(("PrefixPO:*" + prefixPO));
            if (!(String.IsNullOrEmpty(preFixMRGEN)))
            	filter.Add(("PreFixMRGEN:*" + preFixMRGEN));
            if (!(String.IsNullOrEmpty(preFixMRSALE)))
            	filter.Add(("PreFixMRSALE:*" + preFixMRSALE));
            if (!(String.IsNullOrEmpty(preFixPDCGEN)))
            	filter.Add(("PreFixPDCGEN:*" + preFixPDCGEN));
            if (!(String.IsNullOrEmpty(preFixPDCSALE)))
            	filter.Add(("PreFixPDCSALE:*" + preFixPDCSALE));
            if (!(String.IsNullOrEmpty(preFixAppl)))
            	filter.Add(("PreFixAppl:*" + preFixAppl));
            if (!(String.IsNullOrEmpty(prefixDeposit)))
            	filter.Add(("PrefixDeposit:*" + prefixDeposit));
            if (!(String.IsNullOrEmpty(prefixBillReg)))
            	filter.Add(("PrefixBillReg:*" + prefixBillReg));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.PreFixSetting> Select(
                    int? preFixID, 
                    int? accFundID, 
                    string prefixGRN, 
                    string prefixISS, 
                    string prefixPO, 
                    string preFixMRGEN, 
                    string preFixMRSALE, 
                    string preFixPDCGEN, 
                    string preFixPDCSALE, 
                    string preFixAppl, 
                    string prefixDeposit, 
                    string prefixBillReg, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(preFixID, accFundID, prefixGRN, prefixISS, prefixPO, preFixMRGEN, preFixMRSALE, preFixPDCGEN, preFixPDCSALE, preFixAppl, prefixDeposit, prefixBillReg, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("PreFixSetting", dataView, request);
            return page.ToList<MyCompany.Data.Objects.PreFixSetting>();
        }
        
        public List<MyCompany.Data.Objects.PreFixSetting> Select(MyCompany.Data.Objects.PreFixSetting qbe)
        {
            return Select(qbe.PreFixID, qbe.AccFundID, qbe.PrefixGRN, qbe.PrefixISS, qbe.PrefixPO, qbe.PreFixMRGEN, qbe.PreFixMRSALE, qbe.PreFixPDCGEN, qbe.PreFixPDCSALE, qbe.PreFixAppl, qbe.PrefixDeposit, qbe.PrefixBillReg);
        }
        
        public int SelectCount(
                    int? preFixID, 
                    int? accFundID, 
                    string prefixGRN, 
                    string prefixISS, 
                    string prefixPO, 
                    string preFixMRGEN, 
                    string preFixMRSALE, 
                    string preFixPDCGEN, 
                    string preFixPDCSALE, 
                    string preFixAppl, 
                    string prefixDeposit, 
                    string prefixBillReg, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(preFixID, accFundID, prefixGRN, prefixISS, prefixPO, preFixMRGEN, preFixMRSALE, preFixPDCGEN, preFixPDCSALE, preFixAppl, prefixDeposit, prefixBillReg, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("PreFixSetting", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.PreFixSetting> Select(int? preFixID, int? accFundID, string prefixGRN, string prefixISS, string prefixPO, string preFixMRGEN, string preFixMRSALE, string preFixPDCGEN, string preFixPDCSALE, string preFixAppl, string prefixDeposit, string prefixBillReg)
        {
            return Select(preFixID, accFundID, prefixGRN, prefixISS, prefixPO, preFixMRGEN, preFixMRSALE, preFixPDCGEN, preFixPDCSALE, preFixAppl, prefixDeposit, prefixBillReg, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.PreFixSetting SelectSingle(int? preFixID)
        {
            List<MyCompany.Data.Objects.PreFixSetting> list = Select(preFixID, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.PreFixSetting> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("PreFixSetting", dataView, request);
            return page.ToList<MyCompany.Data.Objects.PreFixSetting>();
        }
        
        public List<MyCompany.Data.Objects.PreFixSetting> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.PreFixSetting> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.PreFixSetting SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.PreFixSetting> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.PreFixSetting thePreFixSetting, MyCompany.Data.Objects.PreFixSetting original_PreFixSetting)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("PreFixID", original_PreFixSetting.PreFixID, thePreFixSetting.PreFixID, true));
            values.Add(new FieldValue("AccFundID", original_PreFixSetting.AccFundID, thePreFixSetting.AccFundID));
            values.Add(new FieldValue("PrefixGRN", original_PreFixSetting.PrefixGRN, thePreFixSetting.PrefixGRN));
            values.Add(new FieldValue("PrefixISS", original_PreFixSetting.PrefixISS, thePreFixSetting.PrefixISS));
            values.Add(new FieldValue("PrefixPO", original_PreFixSetting.PrefixPO, thePreFixSetting.PrefixPO));
            values.Add(new FieldValue("PreFixMRGEN", original_PreFixSetting.PreFixMRGEN, thePreFixSetting.PreFixMRGEN));
            values.Add(new FieldValue("PreFixMRSALE", original_PreFixSetting.PreFixMRSALE, thePreFixSetting.PreFixMRSALE));
            values.Add(new FieldValue("PreFixPDCGEN", original_PreFixSetting.PreFixPDCGEN, thePreFixSetting.PreFixPDCGEN));
            values.Add(new FieldValue("PreFixPDCSALE", original_PreFixSetting.PreFixPDCSALE, thePreFixSetting.PreFixPDCSALE));
            values.Add(new FieldValue("PreFixAppl", original_PreFixSetting.PreFixAppl, thePreFixSetting.PreFixAppl));
            values.Add(new FieldValue("PrefixDeposit", original_PreFixSetting.PrefixDeposit, thePreFixSetting.PrefixDeposit));
            values.Add(new FieldValue("PrefixBillReg", original_PreFixSetting.PrefixBillReg, thePreFixSetting.PrefixBillReg));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.PreFixSetting thePreFixSetting, MyCompany.Data.Objects.PreFixSetting original_PreFixSetting, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "PreFixSetting";
            args.View = dataView;
            args.Values = CreateFieldValues(thePreFixSetting, original_PreFixSetting);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("PreFixSetting", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(thePreFixSetting);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.PreFixSetting thePreFixSetting, MyCompany.Data.Objects.PreFixSetting original_PreFixSetting)
        {
            return ExecuteAction(thePreFixSetting, original_PreFixSetting, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.PreFixSetting thePreFixSetting)
        {
            return Update(thePreFixSetting, SelectSingle(thePreFixSetting.PreFixID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.PreFixSetting thePreFixSetting)
        {
            return ExecuteAction(thePreFixSetting, new PreFixSetting(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.PreFixSetting thePreFixSetting)
        {
            return ExecuteAction(thePreFixSetting, thePreFixSetting, "Select", "Delete", DeleteView);
        }
    }
}
