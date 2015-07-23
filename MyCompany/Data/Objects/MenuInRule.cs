using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class MenuInRule
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _menuInRuleID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _sysMenuID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private System.Guid? _roleId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isActive;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isInsert;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isUpdate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isDelete;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isPosting;
        
        public MenuInRule()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? MenuInRuleID
        {
            get
            {
                return _menuInRuleID;
            }
            set
            {
                _menuInRuleID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public int? SysMenuID
        {
            get
            {
                return _sysMenuID;
            }
            set
            {
                _sysMenuID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public System.Guid? RoleId
        {
            get
            {
                return _roleId;
            }
            set
            {
                _roleId = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? IsActive
        {
            get
            {
                return _isActive;
            }
            set
            {
                _isActive = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? IsInsert
        {
            get
            {
                return _isInsert;
            }
            set
            {
                _isInsert = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? IsUpdate
        {
            get
            {
                return _isUpdate;
            }
            set
            {
                _isUpdate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? IsDelete
        {
            get
            {
                return _isDelete;
            }
            set
            {
                _isDelete = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? IsPosting
        {
            get
            {
                return _isPosting;
            }
            set
            {
                _isPosting = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.MenuInRule> Select(int? menuInRuleID, int? sysMenuID, System.Guid? roleId, bool? isActive, bool? isInsert, bool? isUpdate, bool? isDelete, bool? isPosting)
        {
            return new MenuInRuleFactory().Select(menuInRuleID, sysMenuID, roleId, isActive, isInsert, isUpdate, isDelete, isPosting);
        }
        
        public static List<MyCompany.Data.Objects.MenuInRule> Select(MyCompany.Data.Objects.MenuInRule qbe)
        {
            return new MenuInRuleFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.MenuInRule> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new MenuInRuleFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.MenuInRule> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new MenuInRuleFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.MenuInRule> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new MenuInRuleFactory().Select(filter, sort, MenuInRuleFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.MenuInRule> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new MenuInRuleFactory().Select(filter, sort, MenuInRuleFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.MenuInRule> Select(string filter, BusinessObjectParameters parameters)
        {
            return new MenuInRuleFactory().Select(filter, null, MenuInRuleFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.MenuInRule> Select(string filter, params FieldValue[] parameters)
        {
            return new MenuInRuleFactory().Select(filter, null, MenuInRuleFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.MenuInRule SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new MenuInRuleFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.MenuInRule SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new MenuInRuleFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.MenuInRule SelectSingle(int? menuInRuleID)
        {
            return new MenuInRuleFactory().SelectSingle(menuInRuleID);
        }
        
        public int Insert()
        {
            return new MenuInRuleFactory().Insert(this);
        }
        
        public int Update()
        {
            return new MenuInRuleFactory().Update(this);
        }
        
        public int Delete()
        {
            return new MenuInRuleFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("MenuInRuleID: {0}", this.MenuInRuleID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class MenuInRuleFactory
    {
        
        public MenuInRuleFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("MenuInRule");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("MenuInRule");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("MenuInRule");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("MenuInRule");
            }
        }
        
        public static MenuInRuleFactory Create()
        {
            return new MenuInRuleFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? menuInRuleID, int? sysMenuID, System.Guid? roleId, bool? isActive, bool? isInsert, bool? isUpdate, bool? isDelete, bool? isPosting, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (menuInRuleID.HasValue)
            	filter.Add(("MenuInRuleID:=" + menuInRuleID.Value.ToString()));
            if (sysMenuID.HasValue)
            	filter.Add(("SysMenuID:=" + sysMenuID.Value.ToString()));
            if (roleId.HasValue)
            	filter.Add(("RoleId:=" + roleId.Value.ToString()));
            if (isActive.HasValue)
            	filter.Add(("IsActive:=" + isActive.Value.ToString()));
            if (isInsert.HasValue)
            	filter.Add(("IsInsert:=" + isInsert.Value.ToString()));
            if (isUpdate.HasValue)
            	filter.Add(("IsUpdate:=" + isUpdate.Value.ToString()));
            if (isDelete.HasValue)
            	filter.Add(("IsDelete:=" + isDelete.Value.ToString()));
            if (isPosting.HasValue)
            	filter.Add(("IsPosting:=" + isPosting.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.MenuInRule> Select(int? menuInRuleID, int? sysMenuID, System.Guid? roleId, bool? isActive, bool? isInsert, bool? isUpdate, bool? isDelete, bool? isPosting, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(menuInRuleID, sysMenuID, roleId, isActive, isInsert, isUpdate, isDelete, isPosting, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("MenuInRule", dataView, request);
            return page.ToList<MyCompany.Data.Objects.MenuInRule>();
        }
        
        public List<MyCompany.Data.Objects.MenuInRule> Select(MyCompany.Data.Objects.MenuInRule qbe)
        {
            return Select(qbe.MenuInRuleID, qbe.SysMenuID, qbe.RoleId, qbe.IsActive, qbe.IsInsert, qbe.IsUpdate, qbe.IsDelete, qbe.IsPosting);
        }
        
        public int SelectCount(int? menuInRuleID, int? sysMenuID, System.Guid? roleId, bool? isActive, bool? isInsert, bool? isUpdate, bool? isDelete, bool? isPosting, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(menuInRuleID, sysMenuID, roleId, isActive, isInsert, isUpdate, isDelete, isPosting, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("MenuInRule", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.MenuInRule> Select(int? menuInRuleID, int? sysMenuID, System.Guid? roleId, bool? isActive, bool? isInsert, bool? isUpdate, bool? isDelete, bool? isPosting)
        {
            return Select(menuInRuleID, sysMenuID, roleId, isActive, isInsert, isUpdate, isDelete, isPosting, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.MenuInRule SelectSingle(int? menuInRuleID)
        {
            List<MyCompany.Data.Objects.MenuInRule> list = Select(menuInRuleID, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.MenuInRule> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("MenuInRule", dataView, request);
            return page.ToList<MyCompany.Data.Objects.MenuInRule>();
        }
        
        public List<MyCompany.Data.Objects.MenuInRule> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.MenuInRule> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.MenuInRule SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.MenuInRule> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.MenuInRule theMenuInRule, MyCompany.Data.Objects.MenuInRule original_MenuInRule)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("MenuInRuleID", original_MenuInRule.MenuInRuleID, theMenuInRule.MenuInRuleID, true));
            values.Add(new FieldValue("SysMenuID", original_MenuInRule.SysMenuID, theMenuInRule.SysMenuID));
            values.Add(new FieldValue("RoleId", original_MenuInRule.RoleId, theMenuInRule.RoleId));
            values.Add(new FieldValue("IsActive", original_MenuInRule.IsActive, theMenuInRule.IsActive));
            values.Add(new FieldValue("IsInsert", original_MenuInRule.IsInsert, theMenuInRule.IsInsert));
            values.Add(new FieldValue("IsUpdate", original_MenuInRule.IsUpdate, theMenuInRule.IsUpdate));
            values.Add(new FieldValue("IsDelete", original_MenuInRule.IsDelete, theMenuInRule.IsDelete));
            values.Add(new FieldValue("IsPosting", original_MenuInRule.IsPosting, theMenuInRule.IsPosting));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.MenuInRule theMenuInRule, MyCompany.Data.Objects.MenuInRule original_MenuInRule, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "MenuInRule";
            args.View = dataView;
            args.Values = CreateFieldValues(theMenuInRule, original_MenuInRule);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("MenuInRule", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theMenuInRule);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.MenuInRule theMenuInRule, MyCompany.Data.Objects.MenuInRule original_MenuInRule)
        {
            return ExecuteAction(theMenuInRule, original_MenuInRule, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.MenuInRule theMenuInRule)
        {
            return Update(theMenuInRule, SelectSingle(theMenuInRule.MenuInRuleID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.MenuInRule theMenuInRule)
        {
            return ExecuteAction(theMenuInRule, new MenuInRule(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.MenuInRule theMenuInRule)
        {
            return ExecuteAction(theMenuInRule, theMenuInRule, "Select", "Delete", DeleteView);
        }
    }
}
