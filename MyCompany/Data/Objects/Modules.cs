using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class Modules
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _iD;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _moduleName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _displayName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isModuleActive;
        
        public Modules()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? ID
        {
            get
            {
                return _iD;
            }
            set
            {
                _iD = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ModuleName
        {
            get
            {
                return _moduleName;
            }
            set
            {
                _moduleName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string DisplayName
        {
            get
            {
                return _displayName;
            }
            set
            {
                _displayName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? IsModuleActive
        {
            get
            {
                return _isModuleActive;
            }
            set
            {
                _isModuleActive = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.Modules> Select(int? iD, string moduleName, string displayName, bool? isModuleActive)
        {
            return new ModulesFactory().Select(iD, moduleName, displayName, isModuleActive);
        }
        
        public static List<MyCompany.Data.Objects.Modules> Select(MyCompany.Data.Objects.Modules qbe)
        {
            return new ModulesFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.Modules> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new ModulesFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.Modules> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new ModulesFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.Modules> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new ModulesFactory().Select(filter, sort, ModulesFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.Modules> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new ModulesFactory().Select(filter, sort, ModulesFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.Modules> Select(string filter, BusinessObjectParameters parameters)
        {
            return new ModulesFactory().Select(filter, null, ModulesFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.Modules> Select(string filter, params FieldValue[] parameters)
        {
            return new ModulesFactory().Select(filter, null, ModulesFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.Modules SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new ModulesFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.Modules SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new ModulesFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.Modules SelectSingle(int? iD)
        {
            return new ModulesFactory().SelectSingle(iD);
        }
        
        public int Insert()
        {
            return new ModulesFactory().Insert(this);
        }
        
        public int Update()
        {
            return new ModulesFactory().Update(this);
        }
        
        public int Delete()
        {
            return new ModulesFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("ID: {0}", this.ID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class ModulesFactory
    {
        
        public ModulesFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Modules");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Modules");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Modules");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Modules");
            }
        }
        
        public static ModulesFactory Create()
        {
            return new ModulesFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? iD, string moduleName, string displayName, bool? isModuleActive, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (iD.HasValue)
            	filter.Add(("ID:=" + iD.Value.ToString()));
            if (!(String.IsNullOrEmpty(moduleName)))
            	filter.Add(("ModuleName:*" + moduleName));
            if (!(String.IsNullOrEmpty(displayName)))
            	filter.Add(("DisplayName:*" + displayName));
            if (isModuleActive.HasValue)
            	filter.Add(("IsModuleActive:=" + isModuleActive.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.Modules> Select(int? iD, string moduleName, string displayName, bool? isModuleActive, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(iD, moduleName, displayName, isModuleActive, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Modules", dataView, request);
            return page.ToList<MyCompany.Data.Objects.Modules>();
        }
        
        public List<MyCompany.Data.Objects.Modules> Select(MyCompany.Data.Objects.Modules qbe)
        {
            return Select(qbe.ID, qbe.ModuleName, qbe.DisplayName, qbe.IsModuleActive);
        }
        
        public int SelectCount(int? iD, string moduleName, string displayName, bool? isModuleActive, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(iD, moduleName, displayName, isModuleActive, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Modules", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.Modules> Select(int? iD, string moduleName, string displayName, bool? isModuleActive)
        {
            return Select(iD, moduleName, displayName, isModuleActive, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.Modules SelectSingle(int? iD)
        {
            string emptyModuleName = null;
            string emptyDisplayName = null;
            bool? emptyIsModuleActive = null;
            List<MyCompany.Data.Objects.Modules> list = Select(iD, emptyModuleName, emptyDisplayName, emptyIsModuleActive);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.Modules> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("Modules", dataView, request);
            return page.ToList<MyCompany.Data.Objects.Modules>();
        }
        
        public List<MyCompany.Data.Objects.Modules> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.Modules> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.Modules SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.Modules> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.Modules theModules, MyCompany.Data.Objects.Modules original_Modules)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("ID", original_Modules.ID, theModules.ID, true));
            values.Add(new FieldValue("ModuleName", original_Modules.ModuleName, theModules.ModuleName));
            values.Add(new FieldValue("DisplayName", original_Modules.DisplayName, theModules.DisplayName));
            values.Add(new FieldValue("IsModuleActive", original_Modules.IsModuleActive, theModules.IsModuleActive));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.Modules theModules, MyCompany.Data.Objects.Modules original_Modules, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "Modules";
            args.View = dataView;
            args.Values = CreateFieldValues(theModules, original_Modules);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("Modules", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theModules);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.Modules theModules, MyCompany.Data.Objects.Modules original_Modules)
        {
            return ExecuteAction(theModules, original_Modules, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.Modules theModules)
        {
            return Update(theModules, SelectSingle(theModules.ID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.Modules theModules)
        {
            return ExecuteAction(theModules, new Modules(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.Modules theModules)
        {
            return ExecuteAction(theModules, theModules, "Select", "Delete", DeleteView);
        }
    }
}
