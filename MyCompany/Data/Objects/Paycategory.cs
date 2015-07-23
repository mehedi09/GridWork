using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class Paycategory
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _payCatID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _category;
        
        public Paycategory()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? PayCatID
        {
            get
            {
                return _payCatID;
            }
            set
            {
                _payCatID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.Paycategory> Select(int? payCatID, string category)
        {
            return new PaycategoryFactory().Select(payCatID, category);
        }
        
        public static List<MyCompany.Data.Objects.Paycategory> Select(MyCompany.Data.Objects.Paycategory qbe)
        {
            return new PaycategoryFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.Paycategory> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new PaycategoryFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.Paycategory> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new PaycategoryFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.Paycategory> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new PaycategoryFactory().Select(filter, sort, PaycategoryFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.Paycategory> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new PaycategoryFactory().Select(filter, sort, PaycategoryFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.Paycategory> Select(string filter, BusinessObjectParameters parameters)
        {
            return new PaycategoryFactory().Select(filter, null, PaycategoryFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.Paycategory> Select(string filter, params FieldValue[] parameters)
        {
            return new PaycategoryFactory().Select(filter, null, PaycategoryFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.Paycategory SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new PaycategoryFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.Paycategory SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new PaycategoryFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.Paycategory SelectSingle(int? payCatID)
        {
            return new PaycategoryFactory().SelectSingle(payCatID);
        }
        
        public int Insert()
        {
            return new PaycategoryFactory().Insert(this);
        }
        
        public int Update()
        {
            return new PaycategoryFactory().Update(this);
        }
        
        public int Delete()
        {
            return new PaycategoryFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("PayCatID: {0}", this.PayCatID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class PaycategoryFactory
    {
        
        public PaycategoryFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Paycategory");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Paycategory");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Paycategory");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Paycategory");
            }
        }
        
        public static PaycategoryFactory Create()
        {
            return new PaycategoryFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? payCatID, string category, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (payCatID.HasValue)
            	filter.Add(("PayCatID:=" + payCatID.Value.ToString()));
            if (!(String.IsNullOrEmpty(category)))
            	filter.Add(("Category:*" + category));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.Paycategory> Select(int? payCatID, string category, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(payCatID, category, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Paycategory", dataView, request);
            return page.ToList<MyCompany.Data.Objects.Paycategory>();
        }
        
        public List<MyCompany.Data.Objects.Paycategory> Select(MyCompany.Data.Objects.Paycategory qbe)
        {
            return Select(qbe.PayCatID, qbe.Category);
        }
        
        public int SelectCount(int? payCatID, string category, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(payCatID, category, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Paycategory", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.Paycategory> Select(int? payCatID, string category)
        {
            return Select(payCatID, category, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.Paycategory SelectSingle(int? payCatID)
        {
            string emptyCategory = null;
            List<MyCompany.Data.Objects.Paycategory> list = Select(payCatID, emptyCategory);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.Paycategory> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("Paycategory", dataView, request);
            return page.ToList<MyCompany.Data.Objects.Paycategory>();
        }
        
        public List<MyCompany.Data.Objects.Paycategory> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.Paycategory> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.Paycategory SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.Paycategory> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.Paycategory thePaycategory, MyCompany.Data.Objects.Paycategory original_Paycategory)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("PayCatID", original_Paycategory.PayCatID, thePaycategory.PayCatID, true));
            values.Add(new FieldValue("Category", original_Paycategory.Category, thePaycategory.Category));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.Paycategory thePaycategory, MyCompany.Data.Objects.Paycategory original_Paycategory, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "Paycategory";
            args.View = dataView;
            args.Values = CreateFieldValues(thePaycategory, original_Paycategory);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("Paycategory", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(thePaycategory);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.Paycategory thePaycategory, MyCompany.Data.Objects.Paycategory original_Paycategory)
        {
            return ExecuteAction(thePaycategory, original_Paycategory, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.Paycategory thePaycategory)
        {
            return Update(thePaycategory, SelectSingle(thePaycategory.PayCatID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.Paycategory thePaycategory)
        {
            return ExecuteAction(thePaycategory, new Paycategory(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.Paycategory thePaycategory)
        {
            return ExecuteAction(thePaycategory, thePaycategory, "Select", "Delete", DeleteView);
        }
    }
}
