using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class Roles
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _roleID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _roleName;
        
        public Roles()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
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
        public string RoleName
        {
            get
            {
                return _roleName;
            }
            set
            {
                _roleName = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.Roles> Select(int? roleID, string roleName)
        {
            return new RolesFactory().Select(roleID, roleName);
        }
        
        public static List<MyCompany.Data.Objects.Roles> Select(MyCompany.Data.Objects.Roles qbe)
        {
            return new RolesFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.Roles> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new RolesFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.Roles> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new RolesFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.Roles> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new RolesFactory().Select(filter, sort, RolesFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.Roles> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new RolesFactory().Select(filter, sort, RolesFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.Roles> Select(string filter, BusinessObjectParameters parameters)
        {
            return new RolesFactory().Select(filter, null, RolesFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.Roles> Select(string filter, params FieldValue[] parameters)
        {
            return new RolesFactory().Select(filter, null, RolesFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.Roles SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new RolesFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.Roles SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new RolesFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.Roles SelectSingle(int? roleID)
        {
            return new RolesFactory().SelectSingle(roleID);
        }
        
        public int Insert()
        {
            return new RolesFactory().Insert(this);
        }
        
        public int Update()
        {
            return new RolesFactory().Update(this);
        }
        
        public int Delete()
        {
            return new RolesFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("RoleID: {0}", this.RoleID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class RolesFactory
    {
        
        public RolesFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Roles");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Roles");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Roles");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Roles");
            }
        }
        
        public static RolesFactory Create()
        {
            return new RolesFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? roleID, string roleName, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (roleID.HasValue)
            	filter.Add(("RoleID:=" + roleID.Value.ToString()));
            if (!(String.IsNullOrEmpty(roleName)))
            	filter.Add(("RoleName:*" + roleName));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.Roles> Select(int? roleID, string roleName, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(roleID, roleName, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Roles", dataView, request);
            return page.ToList<MyCompany.Data.Objects.Roles>();
        }
        
        public List<MyCompany.Data.Objects.Roles> Select(MyCompany.Data.Objects.Roles qbe)
        {
            return Select(qbe.RoleID, qbe.RoleName);
        }
        
        public int SelectCount(int? roleID, string roleName, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(roleID, roleName, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Roles", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.Roles> Select(int? roleID, string roleName)
        {
            return Select(roleID, roleName, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.Roles SelectSingle(int? roleID)
        {
            string emptyRoleName = null;
            List<MyCompany.Data.Objects.Roles> list = Select(roleID, emptyRoleName);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.Roles> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("Roles", dataView, request);
            return page.ToList<MyCompany.Data.Objects.Roles>();
        }
        
        public List<MyCompany.Data.Objects.Roles> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.Roles> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.Roles SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.Roles> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.Roles theRoles, MyCompany.Data.Objects.Roles original_Roles)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("RoleID", original_Roles.RoleID, theRoles.RoleID, true));
            values.Add(new FieldValue("RoleName", original_Roles.RoleName, theRoles.RoleName));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.Roles theRoles, MyCompany.Data.Objects.Roles original_Roles, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "Roles";
            args.View = dataView;
            args.Values = CreateFieldValues(theRoles, original_Roles);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("Roles", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theRoles);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.Roles theRoles, MyCompany.Data.Objects.Roles original_Roles)
        {
            return ExecuteAction(theRoles, original_Roles, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.Roles theRoles)
        {
            return Update(theRoles, SelectSingle(theRoles.RoleID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.Roles theRoles)
        {
            return ExecuteAction(theRoles, new Roles(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.Roles theRoles)
        {
            return ExecuteAction(theRoles, theRoles, "Select", "Delete", DeleteView);
        }
    }
}
