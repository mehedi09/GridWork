using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class UserRoles
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _userID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _userUserName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _roleID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _roleRoleName;
        
        public UserRoles()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public int? UserID
        {
            get
            {
                return _userID;
            }
            set
            {
                _userID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string UserUserName
        {
            get
            {
                return _userUserName;
            }
            set
            {
                _userUserName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(true, false, false)]
        public int? RoleID
        {
            get
            {
                return _roleID;
            }
            set
            {
                _roleID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RoleRoleName
        {
            get
            {
                return _roleRoleName;
            }
            set
            {
                _roleRoleName = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.UserRoles> Select(int? userID, string userUserName, int? roleID, string roleRoleName)
        {
            return new UserRolesFactory().Select(userID, userUserName, roleID, roleRoleName);
        }
        
        public static List<MyCompany.Data.Objects.UserRoles> Select(MyCompany.Data.Objects.UserRoles qbe)
        {
            return new UserRolesFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.UserRoles> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new UserRolesFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.UserRoles> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new UserRolesFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.UserRoles> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new UserRolesFactory().Select(filter, sort, UserRolesFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.UserRoles> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new UserRolesFactory().Select(filter, sort, UserRolesFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.UserRoles> Select(string filter, BusinessObjectParameters parameters)
        {
            return new UserRolesFactory().Select(filter, null, UserRolesFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.UserRoles> Select(string filter, params FieldValue[] parameters)
        {
            return new UserRolesFactory().Select(filter, null, UserRolesFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.UserRoles SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new UserRolesFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.UserRoles SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new UserRolesFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.UserRoles SelectSingle(int? userID, int? roleID)
        {
            return new UserRolesFactory().SelectSingle(userID, roleID);
        }
        
        public int Insert()
        {
            return new UserRolesFactory().Insert(this);
        }
        
        public int Update()
        {
            return new UserRolesFactory().Update(this);
        }
        
        public int Delete()
        {
            return new UserRolesFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("UserID: {0}; RoleID: {1}", this.UserID, this.RoleID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class UserRolesFactory
    {
        
        public UserRolesFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("UserRoles");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("UserRoles");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("UserRoles");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("UserRoles");
            }
        }
        
        public static UserRolesFactory Create()
        {
            return new UserRolesFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? userID, string userUserName, int? roleID, string roleRoleName, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (userID.HasValue)
            	filter.Add(("UserID:=" + userID.Value.ToString()));
            if (!(String.IsNullOrEmpty(userUserName)))
            	filter.Add(("UserUserName:*" + userUserName));
            if (roleID.HasValue)
            	filter.Add(("RoleID:=" + roleID.Value.ToString()));
            if (!(String.IsNullOrEmpty(roleRoleName)))
            	filter.Add(("RoleRoleName:*" + roleRoleName));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.UserRoles> Select(int? userID, string userUserName, int? roleID, string roleRoleName, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(userID, userUserName, roleID, roleRoleName, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("UserRoles", dataView, request);
            return page.ToList<MyCompany.Data.Objects.UserRoles>();
        }
        
        public List<MyCompany.Data.Objects.UserRoles> Select(MyCompany.Data.Objects.UserRoles qbe)
        {
            return Select(qbe.UserID, qbe.UserUserName, qbe.RoleID, qbe.RoleRoleName);
        }
        
        public int SelectCount(int? userID, string userUserName, int? roleID, string roleRoleName, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(userID, userUserName, roleID, roleRoleName, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("UserRoles", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.UserRoles> Select(int? userID, string userUserName, int? roleID, string roleRoleName)
        {
            return Select(userID, userUserName, roleID, roleRoleName, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.UserRoles SelectSingle(int? userID, int? roleID)
        {
            string emptyUserUserName = null;
            string emptyRoleRoleName = null;
            List<MyCompany.Data.Objects.UserRoles> list = Select(userID, emptyUserUserName, roleID, emptyRoleRoleName);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.UserRoles> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("UserRoles", dataView, request);
            return page.ToList<MyCompany.Data.Objects.UserRoles>();
        }
        
        public List<MyCompany.Data.Objects.UserRoles> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.UserRoles> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.UserRoles SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.UserRoles> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.UserRoles theUserRoles, MyCompany.Data.Objects.UserRoles original_UserRoles)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("UserID", original_UserRoles.UserID, theUserRoles.UserID));
            values.Add(new FieldValue("UserUserName", original_UserRoles.UserUserName, theUserRoles.UserUserName, true));
            values.Add(new FieldValue("RoleID", original_UserRoles.RoleID, theUserRoles.RoleID));
            values.Add(new FieldValue("RoleRoleName", original_UserRoles.RoleRoleName, theUserRoles.RoleRoleName, true));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.UserRoles theUserRoles, MyCompany.Data.Objects.UserRoles original_UserRoles, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "UserRoles";
            args.View = dataView;
            args.Values = CreateFieldValues(theUserRoles, original_UserRoles);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("UserRoles", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theUserRoles);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.UserRoles theUserRoles, MyCompany.Data.Objects.UserRoles original_UserRoles)
        {
            return ExecuteAction(theUserRoles, original_UserRoles, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.UserRoles theUserRoles)
        {
            return Update(theUserRoles, SelectSingle(theUserRoles.UserID, theUserRoles.RoleID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.UserRoles theUserRoles)
        {
            return ExecuteAction(theUserRoles, new UserRoles(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.UserRoles theUserRoles)
        {
            return ExecuteAction(theUserRoles, theUserRoles, "Select", "Delete", DeleteView);
        }
    }
}
