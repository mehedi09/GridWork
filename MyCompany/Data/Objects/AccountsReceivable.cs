using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class AccountsReceivable
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accSubCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accSubTypeID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accSubTypeAccSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accSubID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accSubName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _address;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _officeAdd;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _offPhone;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _hmPhone;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _mobile;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _fax;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _email;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cPerson;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _licenseNum;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _licenseExpDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private byte? _dlt;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _desigID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _deptID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _custType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accFundID;
        
        public AccountsReceivable()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? AccSubCode
        {
            get
            {
                return _accSubCode;
            }
            set
            {
                _accSubCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? AccSubTypeID
        {
            get
            {
                return _accSubTypeID;
            }
            set
            {
                _accSubTypeID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccSubTypeAccSubType
        {
            get
            {
                return _accSubTypeAccSubType;
            }
            set
            {
                _accSubTypeAccSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccSubID
        {
            get
            {
                return _accSubID;
            }
            set
            {
                _accSubID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccSubType
        {
            get
            {
                return _accSubType;
            }
            set
            {
                _accSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
        public string AccSubName
        {
            get
            {
                return _accSubName;
            }
            set
            {
                _accSubName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OfficeAdd
        {
            get
            {
                return _officeAdd;
            }
            set
            {
                _officeAdd = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OffPhone
        {
            get
            {
                return _offPhone;
            }
            set
            {
                _offPhone = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HmPhone
        {
            get
            {
                return _hmPhone;
            }
            set
            {
                _hmPhone = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Mobile
        {
            get
            {
                return _mobile;
            }
            set
            {
                _mobile = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Fax
        {
            get
            {
                return _fax;
            }
            set
            {
                _fax = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CPerson
        {
            get
            {
                return _cPerson;
            }
            set
            {
                _cPerson = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LicenseNum
        {
            get
            {
                return _licenseNum;
            }
            set
            {
                _licenseNum = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? LicenseExpDate
        {
            get
            {
                return _licenseExpDate;
            }
            set
            {
                _licenseExpDate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public byte? Dlt
        {
            get
            {
                return _dlt;
            }
            set
            {
                _dlt = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string DesigID
        {
            get
            {
                return _desigID;
            }
            set
            {
                _desigID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string DeptID
        {
            get
            {
                return _deptID;
            }
            set
            {
                _deptID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CustType
        {
            get
            {
                return _custType;
            }
            set
            {
                _custType = value;
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
        
        public static List<MyCompany.Data.Objects.AccountsReceivable> Select(
                    int? accSubCode, 
                    int? accSubTypeID, 
                    string accSubTypeAccSubType, 
                    string accSubID, 
                    string accSubType, 
                    string accSubName, 
                    string address, 
                    string officeAdd, 
                    string offPhone, 
                    string hmPhone, 
                    string mobile, 
                    string fax, 
                    string email, 
                    string cPerson, 
                    string licenseNum, 
                    DateTime? licenseExpDate, 
                    byte? dlt, 
                    string desigID, 
                    string deptID, 
                    string custType, 
                    int? accFundID)
        {
            return new AccountsReceivableFactory().Select(accSubCode, accSubTypeID, accSubTypeAccSubType, accSubID, accSubType, accSubName, address, officeAdd, offPhone, hmPhone, mobile, fax, email, cPerson, licenseNum, licenseExpDate, dlt, desigID, deptID, custType, accFundID);
        }
        
        public static List<MyCompany.Data.Objects.AccountsReceivable> Select(MyCompany.Data.Objects.AccountsReceivable qbe)
        {
            return new AccountsReceivableFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.AccountsReceivable> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new AccountsReceivableFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccountsReceivable> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new AccountsReceivableFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.AccountsReceivable> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new AccountsReceivableFactory().Select(filter, sort, AccountsReceivableFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccountsReceivable> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new AccountsReceivableFactory().Select(filter, sort, AccountsReceivableFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.AccountsReceivable> Select(string filter, BusinessObjectParameters parameters)
        {
            return new AccountsReceivableFactory().Select(filter, null, AccountsReceivableFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.AccountsReceivable> Select(string filter, params FieldValue[] parameters)
        {
            return new AccountsReceivableFactory().Select(filter, null, AccountsReceivableFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.AccountsReceivable SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new AccountsReceivableFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.AccountsReceivable SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new AccountsReceivableFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.AccountsReceivable SelectSingle(int? accSubCode)
        {
            return new AccountsReceivableFactory().SelectSingle(accSubCode);
        }
        
        public int Insert()
        {
            return new AccountsReceivableFactory().Insert(this);
        }
        
        public int Update()
        {
            return new AccountsReceivableFactory().Update(this);
        }
        
        public int Delete()
        {
            return new AccountsReceivableFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("AccSubCode: {0}", this.AccSubCode);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class AccountsReceivableFactory
    {
        
        public AccountsReceivableFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("AccountsReceivable");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("AccountsReceivable");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("AccountsReceivable");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("AccountsReceivable");
            }
        }
        
        public static AccountsReceivableFactory Create()
        {
            return new AccountsReceivableFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    int? accSubCode, 
                    int? accSubTypeID, 
                    string accSubTypeAccSubType, 
                    string accSubID, 
                    string accSubType, 
                    string accSubName, 
                    string address, 
                    string officeAdd, 
                    string offPhone, 
                    string hmPhone, 
                    string mobile, 
                    string fax, 
                    string email, 
                    string cPerson, 
                    string licenseNum, 
                    DateTime? licenseExpDate, 
                    byte? dlt, 
                    string desigID, 
                    string deptID, 
                    string custType, 
                    int? accFundID, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (accSubCode.HasValue)
            	filter.Add(("AccSubCode:=" + accSubCode.Value.ToString()));
            if (accSubTypeID.HasValue)
            	filter.Add(("AccSubTypeID:=" + accSubTypeID.Value.ToString()));
            if (!(String.IsNullOrEmpty(accSubTypeAccSubType)))
            	filter.Add(("AccSubTypeAccSubType:*" + accSubTypeAccSubType));
            if (!(String.IsNullOrEmpty(accSubID)))
            	filter.Add(("AccSubID:*" + accSubID));
            if (!(String.IsNullOrEmpty(accSubType)))
            	filter.Add(("AccSubType:*" + accSubType));
            if (!(String.IsNullOrEmpty(accSubName)))
            	filter.Add(("AccSubName:*" + accSubName));
            if (!(String.IsNullOrEmpty(address)))
            	filter.Add(("Address:*" + address));
            if (!(String.IsNullOrEmpty(officeAdd)))
            	filter.Add(("OfficeAdd:*" + officeAdd));
            if (!(String.IsNullOrEmpty(offPhone)))
            	filter.Add(("OffPhone:*" + offPhone));
            if (!(String.IsNullOrEmpty(hmPhone)))
            	filter.Add(("HmPhone:*" + hmPhone));
            if (!(String.IsNullOrEmpty(mobile)))
            	filter.Add(("Mobile:*" + mobile));
            if (!(String.IsNullOrEmpty(fax)))
            	filter.Add(("Fax:*" + fax));
            if (!(String.IsNullOrEmpty(email)))
            	filter.Add(("Email:*" + email));
            if (!(String.IsNullOrEmpty(cPerson)))
            	filter.Add(("CPerson:*" + cPerson));
            if (!(String.IsNullOrEmpty(licenseNum)))
            	filter.Add(("LicenseNum:*" + licenseNum));
            if (licenseExpDate.HasValue)
            	filter.Add(("LicenseExpDate:=" + licenseExpDate.Value.ToString()));
            if (dlt.HasValue)
            	filter.Add(("Dlt:=" + dlt.Value.ToString()));
            if (!(String.IsNullOrEmpty(desigID)))
            	filter.Add(("DesigID:*" + desigID));
            if (!(String.IsNullOrEmpty(deptID)))
            	filter.Add(("DeptID:*" + deptID));
            if (!(String.IsNullOrEmpty(custType)))
            	filter.Add(("CustType:*" + custType));
            if (accFundID.HasValue)
            	filter.Add(("AccFundID:=" + accFundID.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.AccountsReceivable> Select(
                    int? accSubCode, 
                    int? accSubTypeID, 
                    string accSubTypeAccSubType, 
                    string accSubID, 
                    string accSubType, 
                    string accSubName, 
                    string address, 
                    string officeAdd, 
                    string offPhone, 
                    string hmPhone, 
                    string mobile, 
                    string fax, 
                    string email, 
                    string cPerson, 
                    string licenseNum, 
                    DateTime? licenseExpDate, 
                    byte? dlt, 
                    string desigID, 
                    string deptID, 
                    string custType, 
                    int? accFundID, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(accSubCode, accSubTypeID, accSubTypeAccSubType, accSubID, accSubType, accSubName, address, officeAdd, offPhone, hmPhone, mobile, fax, email, cPerson, licenseNum, licenseExpDate, dlt, desigID, deptID, custType, accFundID, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("AccountsReceivable", dataView, request);
            return page.ToList<MyCompany.Data.Objects.AccountsReceivable>();
        }
        
        public List<MyCompany.Data.Objects.AccountsReceivable> Select(MyCompany.Data.Objects.AccountsReceivable qbe)
        {
            return Select(qbe.AccSubCode, qbe.AccSubTypeID, qbe.AccSubTypeAccSubType, qbe.AccSubID, qbe.AccSubType, qbe.AccSubName, qbe.Address, qbe.OfficeAdd, qbe.OffPhone, qbe.HmPhone, qbe.Mobile, qbe.Fax, qbe.Email, qbe.CPerson, qbe.LicenseNum, qbe.LicenseExpDate, qbe.Dlt, qbe.DesigID, qbe.DeptID, qbe.CustType, qbe.AccFundID);
        }
        
        public int SelectCount(
                    int? accSubCode, 
                    int? accSubTypeID, 
                    string accSubTypeAccSubType, 
                    string accSubID, 
                    string accSubType, 
                    string accSubName, 
                    string address, 
                    string officeAdd, 
                    string offPhone, 
                    string hmPhone, 
                    string mobile, 
                    string fax, 
                    string email, 
                    string cPerson, 
                    string licenseNum, 
                    DateTime? licenseExpDate, 
                    byte? dlt, 
                    string desigID, 
                    string deptID, 
                    string custType, 
                    int? accFundID, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(accSubCode, accSubTypeID, accSubTypeAccSubType, accSubID, accSubType, accSubName, address, officeAdd, offPhone, hmPhone, mobile, fax, email, cPerson, licenseNum, licenseExpDate, dlt, desigID, deptID, custType, accFundID, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("AccountsReceivable", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.AccountsReceivable> Select(
                    int? accSubCode, 
                    int? accSubTypeID, 
                    string accSubTypeAccSubType, 
                    string accSubID, 
                    string accSubType, 
                    string accSubName, 
                    string address, 
                    string officeAdd, 
                    string offPhone, 
                    string hmPhone, 
                    string mobile, 
                    string fax, 
                    string email, 
                    string cPerson, 
                    string licenseNum, 
                    DateTime? licenseExpDate, 
                    byte? dlt, 
                    string desigID, 
                    string deptID, 
                    string custType, 
                    int? accFundID)
        {
            return Select(accSubCode, accSubTypeID, accSubTypeAccSubType, accSubID, accSubType, accSubName, address, officeAdd, offPhone, hmPhone, mobile, fax, email, cPerson, licenseNum, licenseExpDate, dlt, desigID, deptID, custType, accFundID, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.AccountsReceivable SelectSingle(int? accSubCode)
        {
            List<MyCompany.Data.Objects.AccountsReceivable> list = Select(accSubCode, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.AccountsReceivable> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("AccountsReceivable", dataView, request);
            return page.ToList<MyCompany.Data.Objects.AccountsReceivable>();
        }
        
        public List<MyCompany.Data.Objects.AccountsReceivable> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.AccountsReceivable> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.AccountsReceivable SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.AccountsReceivable> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.AccountsReceivable theAccountsReceivable, MyCompany.Data.Objects.AccountsReceivable original_AccountsReceivable)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("AccSubCode", original_AccountsReceivable.AccSubCode, theAccountsReceivable.AccSubCode, true));
            values.Add(new FieldValue("AccSubTypeID", original_AccountsReceivable.AccSubTypeID, theAccountsReceivable.AccSubTypeID));
            values.Add(new FieldValue("AccSubTypeAccSubType", original_AccountsReceivable.AccSubTypeAccSubType, theAccountsReceivable.AccSubTypeAccSubType, true));
            values.Add(new FieldValue("AccSubID", original_AccountsReceivable.AccSubID, theAccountsReceivable.AccSubID));
            values.Add(new FieldValue("AccSubType", original_AccountsReceivable.AccSubType, theAccountsReceivable.AccSubType));
            values.Add(new FieldValue("AccSubName", original_AccountsReceivable.AccSubName, theAccountsReceivable.AccSubName));
            values.Add(new FieldValue("Address", original_AccountsReceivable.Address, theAccountsReceivable.Address));
            values.Add(new FieldValue("OfficeAdd", original_AccountsReceivable.OfficeAdd, theAccountsReceivable.OfficeAdd));
            values.Add(new FieldValue("OffPhone", original_AccountsReceivable.OffPhone, theAccountsReceivable.OffPhone));
            values.Add(new FieldValue("HmPhone", original_AccountsReceivable.HmPhone, theAccountsReceivable.HmPhone));
            values.Add(new FieldValue("Mobile", original_AccountsReceivable.Mobile, theAccountsReceivable.Mobile));
            values.Add(new FieldValue("Fax", original_AccountsReceivable.Fax, theAccountsReceivable.Fax));
            values.Add(new FieldValue("Email", original_AccountsReceivable.Email, theAccountsReceivable.Email));
            values.Add(new FieldValue("CPerson", original_AccountsReceivable.CPerson, theAccountsReceivable.CPerson));
            values.Add(new FieldValue("LicenseNum", original_AccountsReceivable.LicenseNum, theAccountsReceivable.LicenseNum));
            values.Add(new FieldValue("LicenseExpDate", original_AccountsReceivable.LicenseExpDate, theAccountsReceivable.LicenseExpDate));
            values.Add(new FieldValue("Dlt", original_AccountsReceivable.Dlt, theAccountsReceivable.Dlt));
            values.Add(new FieldValue("DesigID", original_AccountsReceivable.DesigID, theAccountsReceivable.DesigID));
            values.Add(new FieldValue("DeptID", original_AccountsReceivable.DeptID, theAccountsReceivable.DeptID));
            values.Add(new FieldValue("CustType", original_AccountsReceivable.CustType, theAccountsReceivable.CustType));
            values.Add(new FieldValue("AccFundID", original_AccountsReceivable.AccFundID, theAccountsReceivable.AccFundID));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.AccountsReceivable theAccountsReceivable, MyCompany.Data.Objects.AccountsReceivable original_AccountsReceivable, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "AccountsReceivable";
            args.View = dataView;
            args.Values = CreateFieldValues(theAccountsReceivable, original_AccountsReceivable);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("AccountsReceivable", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theAccountsReceivable);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.AccountsReceivable theAccountsReceivable, MyCompany.Data.Objects.AccountsReceivable original_AccountsReceivable)
        {
            return ExecuteAction(theAccountsReceivable, original_AccountsReceivable, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.AccountsReceivable theAccountsReceivable)
        {
            return Update(theAccountsReceivable, SelectSingle(theAccountsReceivable.AccSubCode));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.AccountsReceivable theAccountsReceivable)
        {
            return ExecuteAction(theAccountsReceivable, new AccountsReceivable(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.AccountsReceivable theAccountsReceivable)
        {
            return ExecuteAction(theAccountsReceivable, theAccountsReceivable, "Select", "Delete", DeleteView);
        }
    }
}
