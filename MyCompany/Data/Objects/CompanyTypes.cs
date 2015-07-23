using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class CompanyTypes
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _compTypeID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _description;
        
        public CompanyTypes()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? CompTypeID
        {
            get
            {
                return _compTypeID;
            }
            set
            {
                _compTypeID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.CompanyTypes> Select(int? compTypeID, string description)
        {
            return new CompanyTypesFactory().Select(compTypeID, description);
        }
        
        public static List<MyCompany.Data.Objects.CompanyTypes> Select(MyCompany.Data.Objects.CompanyTypes qbe)
        {
            return new CompanyTypesFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.CompanyTypes> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new CompanyTypesFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.CompanyTypes> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new CompanyTypesFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.CompanyTypes> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new CompanyTypesFactory().Select(filter, sort, CompanyTypesFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.CompanyTypes> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new CompanyTypesFactory().Select(filter, sort, CompanyTypesFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.CompanyTypes> Select(string filter, BusinessObjectParameters parameters)
        {
            return new CompanyTypesFactory().Select(filter, null, CompanyTypesFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.CompanyTypes> Select(string filter, params FieldValue[] parameters)
        {
            return new CompanyTypesFactory().Select(filter, null, CompanyTypesFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.CompanyTypes SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new CompanyTypesFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.CompanyTypes SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new CompanyTypesFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.CompanyTypes SelectSingle(int? compTypeID)
        {
            return new CompanyTypesFactory().SelectSingle(compTypeID);
        }
        
        public int Insert()
        {
            return new CompanyTypesFactory().Insert(this);
        }
        
        public int Update()
        {
            return new CompanyTypesFactory().Update(this);
        }
        
        public int Delete()
        {
            return new CompanyTypesFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("CompTypeID: {0}", this.CompTypeID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class CompanyTypesFactory
    {
        
        public CompanyTypesFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("CompanyTypes");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("CompanyTypes");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("CompanyTypes");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("CompanyTypes");
            }
        }
        
        public static CompanyTypesFactory Create()
        {
            return new CompanyTypesFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? compTypeID, string description, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (compTypeID.HasValue)
            	filter.Add(("CompTypeID:=" + compTypeID.Value.ToString()));
            if (!(String.IsNullOrEmpty(description)))
            	filter.Add(("Description:*" + description));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.CompanyTypes> Select(int? compTypeID, string description, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(compTypeID, description, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("CompanyTypes", dataView, request);
            return page.ToList<MyCompany.Data.Objects.CompanyTypes>();
        }
        
        public List<MyCompany.Data.Objects.CompanyTypes> Select(MyCompany.Data.Objects.CompanyTypes qbe)
        {
            return Select(qbe.CompTypeID, qbe.Description);
        }
        
        public int SelectCount(int? compTypeID, string description, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(compTypeID, description, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("CompanyTypes", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.CompanyTypes> Select(int? compTypeID, string description)
        {
            return Select(compTypeID, description, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.CompanyTypes SelectSingle(int? compTypeID)
        {
            string emptyDescription = null;
            List<MyCompany.Data.Objects.CompanyTypes> list = Select(compTypeID, emptyDescription);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.CompanyTypes> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("CompanyTypes", dataView, request);
            return page.ToList<MyCompany.Data.Objects.CompanyTypes>();
        }
        
        public List<MyCompany.Data.Objects.CompanyTypes> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.CompanyTypes> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.CompanyTypes SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.CompanyTypes> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.CompanyTypes theCompanyTypes, MyCompany.Data.Objects.CompanyTypes original_CompanyTypes)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("CompTypeID", original_CompanyTypes.CompTypeID, theCompanyTypes.CompTypeID, true));
            values.Add(new FieldValue("Description", original_CompanyTypes.Description, theCompanyTypes.Description));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.CompanyTypes theCompanyTypes, MyCompany.Data.Objects.CompanyTypes original_CompanyTypes, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "CompanyTypes";
            args.View = dataView;
            args.Values = CreateFieldValues(theCompanyTypes, original_CompanyTypes);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("CompanyTypes", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theCompanyTypes);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.CompanyTypes theCompanyTypes, MyCompany.Data.Objects.CompanyTypes original_CompanyTypes)
        {
            return ExecuteAction(theCompanyTypes, original_CompanyTypes, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.CompanyTypes theCompanyTypes)
        {
            return Update(theCompanyTypes, SelectSingle(theCompanyTypes.CompTypeID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.CompanyTypes theCompanyTypes)
        {
            return ExecuteAction(theCompanyTypes, new CompanyTypes(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.CompanyTypes theCompanyTypes)
        {
            return ExecuteAction(theCompanyTypes, theCompanyTypes, "Select", "Delete", DeleteView);
        }
    }
}
