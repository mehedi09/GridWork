using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class MenuInUser
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _menuInUserID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _sysMenuID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _userId;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isActive;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isInsert;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isUpdate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isDelete;
        
        public MenuInUser()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public long? MenuInUserID
        {
            get
            {
                return _menuInUserID;
            }
            set
            {
                _menuInUserID = value;
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
        public string UserId
        {
            get
            {
                return _userId;
            }
            set
            {
                _userId = value;
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
        
        public static List<MyCompany.Data.Objects.MenuInUser> Select(long? menuInUserID, int? sysMenuID, string userId, bool? isActive, bool? isInsert, bool? isUpdate, bool? isDelete)
        {
            return new MenuInUserFactory().Select(menuInUserID, sysMenuID, userId, isActive, isInsert, isUpdate, isDelete);
        }
        
        public static List<MyCompany.Data.Objects.MenuInUser> Select(MyCompany.Data.Objects.MenuInUser qbe)
        {
            return new MenuInUserFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.MenuInUser> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new MenuInUserFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.MenuInUser> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new MenuInUserFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.MenuInUser> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new MenuInUserFactory().Select(filter, sort, MenuInUserFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.MenuInUser> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new MenuInUserFactory().Select(filter, sort, MenuInUserFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.MenuInUser> Select(string filter, BusinessObjectParameters parameters)
        {
            return new MenuInUserFactory().Select(filter, null, MenuInUserFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.MenuInUser> Select(string filter, params FieldValue[] parameters)
        {
            return new MenuInUserFactory().Select(filter, null, MenuInUserFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.MenuInUser SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new MenuInUserFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.MenuInUser SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new MenuInUserFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.MenuInUser SelectSingle(long? menuInUserID)
        {
            return new MenuInUserFactory().SelectSingle(menuInUserID);
        }
        
        public int Insert()
        {
            return new MenuInUserFactory().Insert(this);
        }
        
        public int Update()
        {
            return new MenuInUserFactory().Update(this);
        }
        
        public int Delete()
        {
            return new MenuInUserFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("MenuInUserID: {0}", this.MenuInUserID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class MenuInUserFactory
    {
        
        public MenuInUserFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("MenuInUser");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("MenuInUser");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("MenuInUser");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("MenuInUser");
            }
        }
        
        public static MenuInUserFactory Create()
        {
            return new MenuInUserFactory();
        }
        
        protected virtual PageRequest CreateRequest(long? menuInUserID, int? sysMenuID, string userId, bool? isActive, bool? isInsert, bool? isUpdate, bool? isDelete, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (menuInUserID.HasValue)
            	filter.Add(("MenuInUserID:=" + menuInUserID.Value.ToString()));
            if (sysMenuID.HasValue)
            	filter.Add(("SysMenuID:=" + sysMenuID.Value.ToString()));
            if (!(String.IsNullOrEmpty(userId)))
            	filter.Add(("UserId:*" + userId));
            if (isActive.HasValue)
            	filter.Add(("IsActive:=" + isActive.Value.ToString()));
            if (isInsert.HasValue)
            	filter.Add(("IsInsert:=" + isInsert.Value.ToString()));
            if (isUpdate.HasValue)
            	filter.Add(("IsUpdate:=" + isUpdate.Value.ToString()));
            if (isDelete.HasValue)
            	filter.Add(("IsDelete:=" + isDelete.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.MenuInUser> Select(long? menuInUserID, int? sysMenuID, string userId, bool? isActive, bool? isInsert, bool? isUpdate, bool? isDelete, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(menuInUserID, sysMenuID, userId, isActive, isInsert, isUpdate, isDelete, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("MenuInUser", dataView, request);
            return page.ToList<MyCompany.Data.Objects.MenuInUser>();
        }
        
        public List<MyCompany.Data.Objects.MenuInUser> Select(MyCompany.Data.Objects.MenuInUser qbe)
        {
            return Select(qbe.MenuInUserID, qbe.SysMenuID, qbe.UserId, qbe.IsActive, qbe.IsInsert, qbe.IsUpdate, qbe.IsDelete);
        }
        
        public int SelectCount(long? menuInUserID, int? sysMenuID, string userId, bool? isActive, bool? isInsert, bool? isUpdate, bool? isDelete, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(menuInUserID, sysMenuID, userId, isActive, isInsert, isUpdate, isDelete, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("MenuInUser", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.MenuInUser> Select(long? menuInUserID, int? sysMenuID, string userId, bool? isActive, bool? isInsert, bool? isUpdate, bool? isDelete)
        {
            return Select(menuInUserID, sysMenuID, userId, isActive, isInsert, isUpdate, isDelete, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.MenuInUser SelectSingle(long? menuInUserID)
        {
            List<MyCompany.Data.Objects.MenuInUser> list = Select(menuInUserID, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.MenuInUser> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("MenuInUser", dataView, request);
            return page.ToList<MyCompany.Data.Objects.MenuInUser>();
        }
        
        public List<MyCompany.Data.Objects.MenuInUser> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.MenuInUser> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.MenuInUser SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.MenuInUser> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.MenuInUser theMenuInUser, MyCompany.Data.Objects.MenuInUser original_MenuInUser)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("MenuInUserID", original_MenuInUser.MenuInUserID, theMenuInUser.MenuInUserID, true));
            values.Add(new FieldValue("SysMenuID", original_MenuInUser.SysMenuID, theMenuInUser.SysMenuID));
            values.Add(new FieldValue("UserId", original_MenuInUser.UserId, theMenuInUser.UserId));
            values.Add(new FieldValue("IsActive", original_MenuInUser.IsActive, theMenuInUser.IsActive));
            values.Add(new FieldValue("IsInsert", original_MenuInUser.IsInsert, theMenuInUser.IsInsert));
            values.Add(new FieldValue("IsUpdate", original_MenuInUser.IsUpdate, theMenuInUser.IsUpdate));
            values.Add(new FieldValue("IsDelete", original_MenuInUser.IsDelete, theMenuInUser.IsDelete));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.MenuInUser theMenuInUser, MyCompany.Data.Objects.MenuInUser original_MenuInUser, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "MenuInUser";
            args.View = dataView;
            args.Values = CreateFieldValues(theMenuInUser, original_MenuInUser);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("MenuInUser", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theMenuInUser);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.MenuInUser theMenuInUser, MyCompany.Data.Objects.MenuInUser original_MenuInUser)
        {
            return ExecuteAction(theMenuInUser, original_MenuInUser, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.MenuInUser theMenuInUser)
        {
            return Update(theMenuInUser, SelectSingle(theMenuInUser.MenuInUserID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.MenuInUser theMenuInUser)
        {
            return ExecuteAction(theMenuInUser, new MenuInUser(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.MenuInUser theMenuInUser)
        {
            return ExecuteAction(theMenuInUser, theMenuInUser, "Select", "Delete", DeleteView);
        }
    }
}
