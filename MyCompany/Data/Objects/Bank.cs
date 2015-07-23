using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class Bank
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _bankID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _shortName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _address;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _phoneNo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _faxNo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _swiftNo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _telexNo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _contactPerson;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _branchName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _officeCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nature;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isMaintainScroll;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isMaintainDepSlip;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _thanaCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _thanaName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _districtID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _districtName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _dlt;
        
        public Bank()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? BankID
        {
            get
            {
                return _bankID;
            }
            set
            {
                _bankID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankName
        {
            get
            {
                return _bankName;
            }
            set
            {
                _bankName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ShortName
        {
            get
            {
                return _shortName;
            }
            set
            {
                _shortName = value;
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
        public string PhoneNo
        {
            get
            {
                return _phoneNo;
            }
            set
            {
                _phoneNo = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string FaxNo
        {
            get
            {
                return _faxNo;
            }
            set
            {
                _faxNo = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SwiftNo
        {
            get
            {
                return _swiftNo;
            }
            set
            {
                _swiftNo = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string TelexNo
        {
            get
            {
                return _telexNo;
            }
            set
            {
                _telexNo = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ContactPerson
        {
            get
            {
                return _contactPerson;
            }
            set
            {
                _contactPerson = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BankCode
        {
            get
            {
                return _bankCode;
            }
            set
            {
                _bankCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BranchName
        {
            get
            {
                return _branchName;
            }
            set
            {
                _branchName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccCode
        {
            get
            {
                return _accCode;
            }
            set
            {
                _accCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string OfficeCode
        {
            get
            {
                return _officeCode;
            }
            set
            {
                _officeCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Nature
        {
            get
            {
                return _nature;
            }
            set
            {
                _nature = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? IsMaintainScroll
        {
            get
            {
                return _isMaintainScroll;
            }
            set
            {
                _isMaintainScroll = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? IsMaintainDepSlip
        {
            get
            {
                return _isMaintainDepSlip;
            }
            set
            {
                _isMaintainDepSlip = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ThanaCode
        {
            get
            {
                return _thanaCode;
            }
            set
            {
                _thanaCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ThanaName
        {
            get
            {
                return _thanaName;
            }
            set
            {
                _thanaName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string DistrictID
        {
            get
            {
                return _districtID;
            }
            set
            {
                _districtID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string DistrictName
        {
            get
            {
                return _districtName;
            }
            set
            {
                _districtName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? Dlt
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
        
        public static List<MyCompany.Data.Objects.Bank> Select(
                    int? bankID, 
                    string bankName, 
                    string shortName, 
                    string address, 
                    string phoneNo, 
                    string faxNo, 
                    string swiftNo, 
                    string telexNo, 
                    string contactPerson, 
                    string bankCode, 
                    string branchName, 
                    string accCode, 
                    string officeCode, 
                    string nature, 
                    bool? isMaintainScroll, 
                    bool? isMaintainDepSlip, 
                    string thanaCode, 
                    string thanaName, 
                    string districtID, 
                    string districtName, 
                    bool? dlt)
        {
            return new BankFactory().Select(bankID, bankName, shortName, address, phoneNo, faxNo, swiftNo, telexNo, contactPerson, bankCode, branchName, accCode, officeCode, nature, isMaintainScroll, isMaintainDepSlip, thanaCode, thanaName, districtID, districtName, dlt);
        }
        
        public static List<MyCompany.Data.Objects.Bank> Select(MyCompany.Data.Objects.Bank qbe)
        {
            return new BankFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.Bank> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new BankFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.Bank> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new BankFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.Bank> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new BankFactory().Select(filter, sort, BankFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.Bank> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new BankFactory().Select(filter, sort, BankFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.Bank> Select(string filter, BusinessObjectParameters parameters)
        {
            return new BankFactory().Select(filter, null, BankFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.Bank> Select(string filter, params FieldValue[] parameters)
        {
            return new BankFactory().Select(filter, null, BankFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.Bank SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new BankFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.Bank SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new BankFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.Bank SelectSingle(int? bankID)
        {
            return new BankFactory().SelectSingle(bankID);
        }
        
        public int Insert()
        {
            return new BankFactory().Insert(this);
        }
        
        public int Update()
        {
            return new BankFactory().Update(this);
        }
        
        public int Delete()
        {
            return new BankFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("BankID: {0}", this.BankID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class BankFactory
    {
        
        public BankFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Bank");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Bank");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Bank");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Bank");
            }
        }
        
        public static BankFactory Create()
        {
            return new BankFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    int? bankID, 
                    string bankName, 
                    string shortName, 
                    string address, 
                    string phoneNo, 
                    string faxNo, 
                    string swiftNo, 
                    string telexNo, 
                    string contactPerson, 
                    string bankCode, 
                    string branchName, 
                    string accCode, 
                    string officeCode, 
                    string nature, 
                    bool? isMaintainScroll, 
                    bool? isMaintainDepSlip, 
                    string thanaCode, 
                    string thanaName, 
                    string districtID, 
                    string districtName, 
                    bool? dlt, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (bankID.HasValue)
            	filter.Add(("BankID:=" + bankID.Value.ToString()));
            if (!(String.IsNullOrEmpty(bankName)))
            	filter.Add(("BankName:*" + bankName));
            if (!(String.IsNullOrEmpty(shortName)))
            	filter.Add(("ShortName:*" + shortName));
            if (!(String.IsNullOrEmpty(address)))
            	filter.Add(("Address:*" + address));
            if (!(String.IsNullOrEmpty(phoneNo)))
            	filter.Add(("PhoneNo:*" + phoneNo));
            if (!(String.IsNullOrEmpty(faxNo)))
            	filter.Add(("FaxNo:*" + faxNo));
            if (!(String.IsNullOrEmpty(swiftNo)))
            	filter.Add(("SwiftNo:*" + swiftNo));
            if (!(String.IsNullOrEmpty(telexNo)))
            	filter.Add(("TelexNo:*" + telexNo));
            if (!(String.IsNullOrEmpty(contactPerson)))
            	filter.Add(("ContactPerson:*" + contactPerson));
            if (!(String.IsNullOrEmpty(bankCode)))
            	filter.Add(("BankCode:*" + bankCode));
            if (!(String.IsNullOrEmpty(branchName)))
            	filter.Add(("BranchName:*" + branchName));
            if (!(String.IsNullOrEmpty(accCode)))
            	filter.Add(("AccCode:*" + accCode));
            if (!(String.IsNullOrEmpty(officeCode)))
            	filter.Add(("OfficeCode:*" + officeCode));
            if (!(String.IsNullOrEmpty(nature)))
            	filter.Add(("Nature:*" + nature));
            if (isMaintainScroll.HasValue)
            	filter.Add(("IsMaintainScroll:=" + isMaintainScroll.Value.ToString()));
            if (isMaintainDepSlip.HasValue)
            	filter.Add(("IsMaintainDepSlip:=" + isMaintainDepSlip.Value.ToString()));
            if (!(String.IsNullOrEmpty(thanaCode)))
            	filter.Add(("ThanaCode:*" + thanaCode));
            if (!(String.IsNullOrEmpty(thanaName)))
            	filter.Add(("ThanaName:*" + thanaName));
            if (!(String.IsNullOrEmpty(districtID)))
            	filter.Add(("DistrictID:*" + districtID));
            if (!(String.IsNullOrEmpty(districtName)))
            	filter.Add(("DistrictName:*" + districtName));
            if (dlt.HasValue)
            	filter.Add(("Dlt:=" + dlt.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.Bank> Select(
                    int? bankID, 
                    string bankName, 
                    string shortName, 
                    string address, 
                    string phoneNo, 
                    string faxNo, 
                    string swiftNo, 
                    string telexNo, 
                    string contactPerson, 
                    string bankCode, 
                    string branchName, 
                    string accCode, 
                    string officeCode, 
                    string nature, 
                    bool? isMaintainScroll, 
                    bool? isMaintainDepSlip, 
                    string thanaCode, 
                    string thanaName, 
                    string districtID, 
                    string districtName, 
                    bool? dlt, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(bankID, bankName, shortName, address, phoneNo, faxNo, swiftNo, telexNo, contactPerson, bankCode, branchName, accCode, officeCode, nature, isMaintainScroll, isMaintainDepSlip, thanaCode, thanaName, districtID, districtName, dlt, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Bank", dataView, request);
            return page.ToList<MyCompany.Data.Objects.Bank>();
        }
        
        public List<MyCompany.Data.Objects.Bank> Select(MyCompany.Data.Objects.Bank qbe)
        {
            return Select(qbe.BankID, qbe.BankName, qbe.ShortName, qbe.Address, qbe.PhoneNo, qbe.FaxNo, qbe.SwiftNo, qbe.TelexNo, qbe.ContactPerson, qbe.BankCode, qbe.BranchName, qbe.AccCode, qbe.OfficeCode, qbe.Nature, qbe.IsMaintainScroll, qbe.IsMaintainDepSlip, qbe.ThanaCode, qbe.ThanaName, qbe.DistrictID, qbe.DistrictName, qbe.Dlt);
        }
        
        public int SelectCount(
                    int? bankID, 
                    string bankName, 
                    string shortName, 
                    string address, 
                    string phoneNo, 
                    string faxNo, 
                    string swiftNo, 
                    string telexNo, 
                    string contactPerson, 
                    string bankCode, 
                    string branchName, 
                    string accCode, 
                    string officeCode, 
                    string nature, 
                    bool? isMaintainScroll, 
                    bool? isMaintainDepSlip, 
                    string thanaCode, 
                    string thanaName, 
                    string districtID, 
                    string districtName, 
                    bool? dlt, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(bankID, bankName, shortName, address, phoneNo, faxNo, swiftNo, telexNo, contactPerson, bankCode, branchName, accCode, officeCode, nature, isMaintainScroll, isMaintainDepSlip, thanaCode, thanaName, districtID, districtName, dlt, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Bank", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.Bank> Select(
                    int? bankID, 
                    string bankName, 
                    string shortName, 
                    string address, 
                    string phoneNo, 
                    string faxNo, 
                    string swiftNo, 
                    string telexNo, 
                    string contactPerson, 
                    string bankCode, 
                    string branchName, 
                    string accCode, 
                    string officeCode, 
                    string nature, 
                    bool? isMaintainScroll, 
                    bool? isMaintainDepSlip, 
                    string thanaCode, 
                    string thanaName, 
                    string districtID, 
                    string districtName, 
                    bool? dlt)
        {
            return Select(bankID, bankName, shortName, address, phoneNo, faxNo, swiftNo, telexNo, contactPerson, bankCode, branchName, accCode, officeCode, nature, isMaintainScroll, isMaintainDepSlip, thanaCode, thanaName, districtID, districtName, dlt, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.Bank SelectSingle(int? bankID)
        {
            List<MyCompany.Data.Objects.Bank> list = Select(bankID, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.Bank> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("Bank", dataView, request);
            return page.ToList<MyCompany.Data.Objects.Bank>();
        }
        
        public List<MyCompany.Data.Objects.Bank> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.Bank> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.Bank SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.Bank> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.Bank theBank, MyCompany.Data.Objects.Bank original_Bank)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("BankID", original_Bank.BankID, theBank.BankID, true));
            values.Add(new FieldValue("BankName", original_Bank.BankName, theBank.BankName));
            values.Add(new FieldValue("ShortName", original_Bank.ShortName, theBank.ShortName));
            values.Add(new FieldValue("Address", original_Bank.Address, theBank.Address));
            values.Add(new FieldValue("PhoneNo", original_Bank.PhoneNo, theBank.PhoneNo));
            values.Add(new FieldValue("FaxNo", original_Bank.FaxNo, theBank.FaxNo));
            values.Add(new FieldValue("SwiftNo", original_Bank.SwiftNo, theBank.SwiftNo));
            values.Add(new FieldValue("TelexNo", original_Bank.TelexNo, theBank.TelexNo));
            values.Add(new FieldValue("ContactPerson", original_Bank.ContactPerson, theBank.ContactPerson));
            values.Add(new FieldValue("BankCode", original_Bank.BankCode, theBank.BankCode));
            values.Add(new FieldValue("BranchName", original_Bank.BranchName, theBank.BranchName));
            values.Add(new FieldValue("AccCode", original_Bank.AccCode, theBank.AccCode));
            values.Add(new FieldValue("OfficeCode", original_Bank.OfficeCode, theBank.OfficeCode));
            values.Add(new FieldValue("Nature", original_Bank.Nature, theBank.Nature));
            values.Add(new FieldValue("IsMaintainScroll", original_Bank.IsMaintainScroll, theBank.IsMaintainScroll));
            values.Add(new FieldValue("IsMaintainDepSlip", original_Bank.IsMaintainDepSlip, theBank.IsMaintainDepSlip));
            values.Add(new FieldValue("ThanaCode", original_Bank.ThanaCode, theBank.ThanaCode));
            values.Add(new FieldValue("ThanaName", original_Bank.ThanaName, theBank.ThanaName));
            values.Add(new FieldValue("DistrictID", original_Bank.DistrictID, theBank.DistrictID));
            values.Add(new FieldValue("DistrictName", original_Bank.DistrictName, theBank.DistrictName));
            values.Add(new FieldValue("Dlt", original_Bank.Dlt, theBank.Dlt));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.Bank theBank, MyCompany.Data.Objects.Bank original_Bank, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "Bank";
            args.View = dataView;
            args.Values = CreateFieldValues(theBank, original_Bank);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("Bank", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theBank);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.Bank theBank, MyCompany.Data.Objects.Bank original_Bank)
        {
            return ExecuteAction(theBank, original_Bank, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.Bank theBank)
        {
            return Update(theBank, SelectSingle(theBank.BankID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.Bank theBank)
        {
            return ExecuteAction(theBank, new Bank(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.Bank theBank)
        {
            return ExecuteAction(theBank, theBank, "Select", "Delete", DeleteView);
        }
    }
}
