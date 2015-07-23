using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class ModeofReceipts
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _modeofReceiptID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _description;
        
        public ModeofReceipts()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? ModeofReceiptID
        {
            get
            {
                return _modeofReceiptID;
            }
            set
            {
                _modeofReceiptID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
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
        
        public static List<MyCompany.Data.Objects.ModeofReceipts> Select(int? modeofReceiptID, string description)
        {
            return new ModeofReceiptsFactory().Select(modeofReceiptID, description);
        }
        
        public static List<MyCompany.Data.Objects.ModeofReceipts> Select(MyCompany.Data.Objects.ModeofReceipts qbe)
        {
            return new ModeofReceiptsFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.ModeofReceipts> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new ModeofReceiptsFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.ModeofReceipts> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new ModeofReceiptsFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.ModeofReceipts> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new ModeofReceiptsFactory().Select(filter, sort, ModeofReceiptsFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.ModeofReceipts> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new ModeofReceiptsFactory().Select(filter, sort, ModeofReceiptsFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.ModeofReceipts> Select(string filter, BusinessObjectParameters parameters)
        {
            return new ModeofReceiptsFactory().Select(filter, null, ModeofReceiptsFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.ModeofReceipts> Select(string filter, params FieldValue[] parameters)
        {
            return new ModeofReceiptsFactory().Select(filter, null, ModeofReceiptsFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.ModeofReceipts SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new ModeofReceiptsFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.ModeofReceipts SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new ModeofReceiptsFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.ModeofReceipts SelectSingle(int? modeofReceiptID)
        {
            return new ModeofReceiptsFactory().SelectSingle(modeofReceiptID);
        }
        
        public int Insert()
        {
            return new ModeofReceiptsFactory().Insert(this);
        }
        
        public int Update()
        {
            return new ModeofReceiptsFactory().Update(this);
        }
        
        public int Delete()
        {
            return new ModeofReceiptsFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("ModeofReceiptID: {0}", this.ModeofReceiptID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class ModeofReceiptsFactory
    {
        
        public ModeofReceiptsFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("ModeofReceipts");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("ModeofReceipts");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("ModeofReceipts");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("ModeofReceipts");
            }
        }
        
        public static ModeofReceiptsFactory Create()
        {
            return new ModeofReceiptsFactory();
        }
        
        protected virtual PageRequest CreateRequest(int? modeofReceiptID, string description, string sort, int maximumRows, int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (modeofReceiptID.HasValue)
            	filter.Add(("ModeofReceiptID:=" + modeofReceiptID.Value.ToString()));
            if (!(String.IsNullOrEmpty(description)))
            	filter.Add(("Description:*" + description));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.ModeofReceipts> Select(int? modeofReceiptID, string description, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(modeofReceiptID, description, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("ModeofReceipts", dataView, request);
            return page.ToList<MyCompany.Data.Objects.ModeofReceipts>();
        }
        
        public List<MyCompany.Data.Objects.ModeofReceipts> Select(MyCompany.Data.Objects.ModeofReceipts qbe)
        {
            return Select(qbe.ModeofReceiptID, qbe.Description);
        }
        
        public int SelectCount(int? modeofReceiptID, string description, string sort, int maximumRows, int startRowIndex, string dataView)
        {
            PageRequest request = CreateRequest(modeofReceiptID, description, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("ModeofReceipts", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.ModeofReceipts> Select(int? modeofReceiptID, string description)
        {
            return Select(modeofReceiptID, description, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.ModeofReceipts SelectSingle(int? modeofReceiptID)
        {
            string emptyDescription = null;
            List<MyCompany.Data.Objects.ModeofReceipts> list = Select(modeofReceiptID, emptyDescription);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.ModeofReceipts> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("ModeofReceipts", dataView, request);
            return page.ToList<MyCompany.Data.Objects.ModeofReceipts>();
        }
        
        public List<MyCompany.Data.Objects.ModeofReceipts> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.ModeofReceipts> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.ModeofReceipts SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.ModeofReceipts> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.ModeofReceipts theModeofReceipts, MyCompany.Data.Objects.ModeofReceipts original_ModeofReceipts)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("ModeofReceiptID", original_ModeofReceipts.ModeofReceiptID, theModeofReceipts.ModeofReceiptID, true));
            values.Add(new FieldValue("Description", original_ModeofReceipts.Description, theModeofReceipts.Description));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.ModeofReceipts theModeofReceipts, MyCompany.Data.Objects.ModeofReceipts original_ModeofReceipts, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "ModeofReceipts";
            args.View = dataView;
            args.Values = CreateFieldValues(theModeofReceipts, original_ModeofReceipts);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("ModeofReceipts", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theModeofReceipts);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.ModeofReceipts theModeofReceipts, MyCompany.Data.Objects.ModeofReceipts original_ModeofReceipts)
        {
            return ExecuteAction(theModeofReceipts, original_ModeofReceipts, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.ModeofReceipts theModeofReceipts)
        {
            return Update(theModeofReceipts, SelectSingle(theModeofReceipts.ModeofReceiptID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.ModeofReceipts theModeofReceipts)
        {
            return ExecuteAction(theModeofReceipts, new ModeofReceipts(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.ModeofReceipts theModeofReceipts)
        {
            return ExecuteAction(theModeofReceipts, theModeofReceipts, "Select", "Delete", DeleteView);
        }
    }
}
