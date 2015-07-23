using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class Employees
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _employeeID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _empCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _empName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _accFundID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accBranchCode;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _desigID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _departmentID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _joinDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _gradeID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _empGroupID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _card_id;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _empGenderID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _empTypeID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _empStatusID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private long? _staffTypeID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private byte[] _photo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _pF_JoinDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _fName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _mName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _sName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _lastEdu;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _birthDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _pAddress;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cAddress;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _cellNumber;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _bloodGrpID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _prodLineNo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private byte[] _degitalSign;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _nationalID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _tIN;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _rCNO;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _empGarantor;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _empGarantorRel;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _empGarantorAddress;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _empGarantorCell;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _confirmationDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _empLeft;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _userID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _lastUpdate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _offDay;
        
        public Employees()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public long? EmployeeID
        {
            get
            {
                return _employeeID;
            }
            set
            {
                _employeeID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string EmpCode
        {
            get
            {
                return _empCode;
            }
            set
            {
                _empCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string EmpName
        {
            get
            {
                return _empName;
            }
            set
            {
                _empName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public long? AccFundID
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? AccBranchCode
        {
            get
            {
                return _accBranchCode;
            }
            set
            {
                _accBranchCode = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public long? DesigID
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
        public long? DepartmentID
        {
            get
            {
                return _departmentID;
            }
            set
            {
                _departmentID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? JoinDate
        {
            get
            {
                return _joinDate;
            }
            set
            {
                _joinDate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? GradeID
        {
            get
            {
                return _gradeID;
            }
            set
            {
                _gradeID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? EmpGroupID
        {
            get
            {
                return _empGroupID;
            }
            set
            {
                _empGroupID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Card_id
        {
            get
            {
                return _card_id;
            }
            set
            {
                _card_id = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? EmpGenderID
        {
            get
            {
                return _empGenderID;
            }
            set
            {
                _empGenderID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? EmpTypeID
        {
            get
            {
                return _empTypeID;
            }
            set
            {
                _empTypeID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? EmpStatusID
        {
            get
            {
                return _empStatusID;
            }
            set
            {
                _empStatusID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public long? StaffTypeID
        {
            get
            {
                return _staffTypeID;
            }
            set
            {
                _staffTypeID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public byte[] Photo
        {
            get
            {
                return _photo;
            }
            set
            {
                _photo = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? PF_JoinDate
        {
            get
            {
                return _pF_JoinDate;
            }
            set
            {
                _pF_JoinDate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string FName
        {
            get
            {
                return _fName;
            }
            set
            {
                _fName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string MName
        {
            get
            {
                return _mName;
            }
            set
            {
                _mName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SName
        {
            get
            {
                return _sName;
            }
            set
            {
                _sName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string LastEdu
        {
            get
            {
                return _lastEdu;
            }
            set
            {
                _lastEdu = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? BirthDate
        {
            get
            {
                return _birthDate;
            }
            set
            {
                _birthDate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PAddress
        {
            get
            {
                return _pAddress;
            }
            set
            {
                _pAddress = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CAddress
        {
            get
            {
                return _cAddress;
            }
            set
            {
                _cAddress = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string CellNumber
        {
            get
            {
                return _cellNumber;
            }
            set
            {
                _cellNumber = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? BloodGrpID
        {
            get
            {
                return _bloodGrpID;
            }
            set
            {
                _bloodGrpID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? ProdLineNo
        {
            get
            {
                return _prodLineNo;
            }
            set
            {
                _prodLineNo = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public byte[] DegitalSign
        {
            get
            {
                return _degitalSign;
            }
            set
            {
                _degitalSign = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string NationalID
        {
            get
            {
                return _nationalID;
            }
            set
            {
                _nationalID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string TIN
        {
            get
            {
                return _tIN;
            }
            set
            {
                _tIN = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string RCNO
        {
            get
            {
                return _rCNO;
            }
            set
            {
                _rCNO = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string EmpGarantor
        {
            get
            {
                return _empGarantor;
            }
            set
            {
                _empGarantor = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string EmpGarantorRel
        {
            get
            {
                return _empGarantorRel;
            }
            set
            {
                _empGarantorRel = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string EmpGarantorAddress
        {
            get
            {
                return _empGarantorAddress;
            }
            set
            {
                _empGarantorAddress = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string EmpGarantorCell
        {
            get
            {
                return _empGarantorCell;
            }
            set
            {
                _empGarantorCell = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? ConfirmationDate
        {
            get
            {
                return _confirmationDate;
            }
            set
            {
                _confirmationDate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? EmpLeft
        {
            get
            {
                return _empLeft;
            }
            set
            {
                _empLeft = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string UserID
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
        public DateTime? LastUpdate
        {
            get
            {
                return _lastUpdate;
            }
            set
            {
                _lastUpdate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? OffDay
        {
            get
            {
                return _offDay;
            }
            set
            {
                _offDay = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.Employees> Select(
                    long? employeeID, 
                    string empCode, 
                    string empName, 
                    long? accFundID, 
                    int? accBranchCode, 
                    long? desigID, 
                    long? departmentID, 
                    DateTime? joinDate, 
                    int? gradeID, 
                    int? empGroupID, 
                    string card_id, 
                    int? empGenderID, 
                    int? empTypeID, 
                    int? empStatusID, 
                    long? staffTypeID, 
                    DateTime? pF_JoinDate, 
                    string fName, 
                    string mName, 
                    string sName, 
                    string lastEdu, 
                    DateTime? birthDate, 
                    string pAddress, 
                    string cAddress, 
                    string cellNumber, 
                    int? bloodGrpID, 
                    int? prodLineNo, 
                    string nationalID, 
                    string tIN, 
                    string rCNO, 
                    string empGarantor, 
                    string empGarantorRel, 
                    string empGarantorAddress, 
                    string empGarantorCell, 
                    DateTime? confirmationDate, 
                    bool? empLeft, 
                    string userID, 
                    DateTime? lastUpdate, 
                    DateTime? offDay)
        {
            return new EmployeesFactory().Select(employeeID, empCode, empName, accFundID, accBranchCode, desigID, departmentID, joinDate, gradeID, empGroupID, card_id, empGenderID, empTypeID, empStatusID, staffTypeID, pF_JoinDate, fName, mName, sName, lastEdu, birthDate, pAddress, cAddress, cellNumber, bloodGrpID, prodLineNo, nationalID, tIN, rCNO, empGarantor, empGarantorRel, empGarantorAddress, empGarantorCell, confirmationDate, empLeft, userID, lastUpdate, offDay);
        }
        
        public static List<MyCompany.Data.Objects.Employees> Select(MyCompany.Data.Objects.Employees qbe)
        {
            return new EmployeesFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.Employees> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new EmployeesFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.Employees> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new EmployeesFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.Employees> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new EmployeesFactory().Select(filter, sort, EmployeesFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.Employees> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new EmployeesFactory().Select(filter, sort, EmployeesFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.Employees> Select(string filter, BusinessObjectParameters parameters)
        {
            return new EmployeesFactory().Select(filter, null, EmployeesFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.Employees> Select(string filter, params FieldValue[] parameters)
        {
            return new EmployeesFactory().Select(filter, null, EmployeesFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.Employees SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new EmployeesFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.Employees SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new EmployeesFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.Employees SelectSingle(long? employeeID)
        {
            return new EmployeesFactory().SelectSingle(employeeID);
        }
        
        public int Insert()
        {
            return new EmployeesFactory().Insert(this);
        }
        
        public int Update()
        {
            return new EmployeesFactory().Update(this);
        }
        
        public int Delete()
        {
            return new EmployeesFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("EmployeeID: {0}", this.EmployeeID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class EmployeesFactory
    {
        
        public EmployeesFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Employees");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Employees");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Employees");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Employees");
            }
        }
        
        public static EmployeesFactory Create()
        {
            return new EmployeesFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    long? employeeID, 
                    string empCode, 
                    string empName, 
                    long? accFundID, 
                    int? accBranchCode, 
                    long? desigID, 
                    long? departmentID, 
                    DateTime? joinDate, 
                    int? gradeID, 
                    int? empGroupID, 
                    string card_id, 
                    int? empGenderID, 
                    int? empTypeID, 
                    int? empStatusID, 
                    long? staffTypeID, 
                    DateTime? pF_JoinDate, 
                    string fName, 
                    string mName, 
                    string sName, 
                    string lastEdu, 
                    DateTime? birthDate, 
                    string pAddress, 
                    string cAddress, 
                    string cellNumber, 
                    int? bloodGrpID, 
                    int? prodLineNo, 
                    string nationalID, 
                    string tIN, 
                    string rCNO, 
                    string empGarantor, 
                    string empGarantorRel, 
                    string empGarantorAddress, 
                    string empGarantorCell, 
                    DateTime? confirmationDate, 
                    bool? empLeft, 
                    string userID, 
                    DateTime? lastUpdate, 
                    DateTime? offDay, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (employeeID.HasValue)
            	filter.Add(("EmployeeID:=" + employeeID.Value.ToString()));
            if (!(String.IsNullOrEmpty(empCode)))
            	filter.Add(("EmpCode:*" + empCode));
            if (!(String.IsNullOrEmpty(empName)))
            	filter.Add(("EmpName:*" + empName));
            if (accFundID.HasValue)
            	filter.Add(("AccFundID:=" + accFundID.Value.ToString()));
            if (accBranchCode.HasValue)
            	filter.Add(("AccBranchCode:=" + accBranchCode.Value.ToString()));
            if (desigID.HasValue)
            	filter.Add(("DesigID:=" + desigID.Value.ToString()));
            if (departmentID.HasValue)
            	filter.Add(("DepartmentID:=" + departmentID.Value.ToString()));
            if (joinDate.HasValue)
            	filter.Add(("JoinDate:=" + joinDate.Value.ToString()));
            if (gradeID.HasValue)
            	filter.Add(("GradeID:=" + gradeID.Value.ToString()));
            if (empGroupID.HasValue)
            	filter.Add(("EmpGroupID:=" + empGroupID.Value.ToString()));
            if (!(String.IsNullOrEmpty(card_id)))
            	filter.Add(("Card_id:*" + card_id));
            if (empGenderID.HasValue)
            	filter.Add(("EmpGenderID:=" + empGenderID.Value.ToString()));
            if (empTypeID.HasValue)
            	filter.Add(("EmpTypeID:=" + empTypeID.Value.ToString()));
            if (empStatusID.HasValue)
            	filter.Add(("EmpStatusID:=" + empStatusID.Value.ToString()));
            if (staffTypeID.HasValue)
            	filter.Add(("StaffTypeID:=" + staffTypeID.Value.ToString()));
            if (pF_JoinDate.HasValue)
            	filter.Add(("PF_JoinDate:=" + pF_JoinDate.Value.ToString()));
            if (!(String.IsNullOrEmpty(fName)))
            	filter.Add(("FName:*" + fName));
            if (!(String.IsNullOrEmpty(mName)))
            	filter.Add(("MName:*" + mName));
            if (!(String.IsNullOrEmpty(sName)))
            	filter.Add(("SName:*" + sName));
            if (!(String.IsNullOrEmpty(lastEdu)))
            	filter.Add(("LastEdu:*" + lastEdu));
            if (birthDate.HasValue)
            	filter.Add(("BirthDate:=" + birthDate.Value.ToString()));
            if (!(String.IsNullOrEmpty(pAddress)))
            	filter.Add(("PAddress:*" + pAddress));
            if (!(String.IsNullOrEmpty(cAddress)))
            	filter.Add(("CAddress:*" + cAddress));
            if (!(String.IsNullOrEmpty(cellNumber)))
            	filter.Add(("CellNumber:*" + cellNumber));
            if (bloodGrpID.HasValue)
            	filter.Add(("BloodGrpID:=" + bloodGrpID.Value.ToString()));
            if (prodLineNo.HasValue)
            	filter.Add(("ProdLineNo:=" + prodLineNo.Value.ToString()));
            if (!(String.IsNullOrEmpty(nationalID)))
            	filter.Add(("NationalID:*" + nationalID));
            if (!(String.IsNullOrEmpty(tIN)))
            	filter.Add(("TIN:*" + tIN));
            if (!(String.IsNullOrEmpty(rCNO)))
            	filter.Add(("RCNO:*" + rCNO));
            if (!(String.IsNullOrEmpty(empGarantor)))
            	filter.Add(("EmpGarantor:*" + empGarantor));
            if (!(String.IsNullOrEmpty(empGarantorRel)))
            	filter.Add(("EmpGarantorRel:*" + empGarantorRel));
            if (!(String.IsNullOrEmpty(empGarantorAddress)))
            	filter.Add(("EmpGarantorAddress:*" + empGarantorAddress));
            if (!(String.IsNullOrEmpty(empGarantorCell)))
            	filter.Add(("EmpGarantorCell:*" + empGarantorCell));
            if (confirmationDate.HasValue)
            	filter.Add(("ConfirmationDate:=" + confirmationDate.Value.ToString()));
            if (empLeft.HasValue)
            	filter.Add(("EmpLeft:=" + empLeft.Value.ToString()));
            if (!(String.IsNullOrEmpty(userID)))
            	filter.Add(("UserID:*" + userID));
            if (lastUpdate.HasValue)
            	filter.Add(("LastUpdate:=" + lastUpdate.Value.ToString()));
            if (offDay.HasValue)
            	filter.Add(("OffDay:=" + offDay.Value.ToString()));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.Employees> Select(
                    long? employeeID, 
                    string empCode, 
                    string empName, 
                    long? accFundID, 
                    int? accBranchCode, 
                    long? desigID, 
                    long? departmentID, 
                    DateTime? joinDate, 
                    int? gradeID, 
                    int? empGroupID, 
                    string card_id, 
                    int? empGenderID, 
                    int? empTypeID, 
                    int? empStatusID, 
                    long? staffTypeID, 
                    DateTime? pF_JoinDate, 
                    string fName, 
                    string mName, 
                    string sName, 
                    string lastEdu, 
                    DateTime? birthDate, 
                    string pAddress, 
                    string cAddress, 
                    string cellNumber, 
                    int? bloodGrpID, 
                    int? prodLineNo, 
                    string nationalID, 
                    string tIN, 
                    string rCNO, 
                    string empGarantor, 
                    string empGarantorRel, 
                    string empGarantorAddress, 
                    string empGarantorCell, 
                    DateTime? confirmationDate, 
                    bool? empLeft, 
                    string userID, 
                    DateTime? lastUpdate, 
                    DateTime? offDay, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(employeeID, empCode, empName, accFundID, accBranchCode, desigID, departmentID, joinDate, gradeID, empGroupID, card_id, empGenderID, empTypeID, empStatusID, staffTypeID, pF_JoinDate, fName, mName, sName, lastEdu, birthDate, pAddress, cAddress, cellNumber, bloodGrpID, prodLineNo, nationalID, tIN, rCNO, empGarantor, empGarantorRel, empGarantorAddress, empGarantorCell, confirmationDate, empLeft, userID, lastUpdate, offDay, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Employees", dataView, request);
            return page.ToList<MyCompany.Data.Objects.Employees>();
        }
        
        public List<MyCompany.Data.Objects.Employees> Select(MyCompany.Data.Objects.Employees qbe)
        {
            return Select(qbe.EmployeeID, qbe.EmpCode, qbe.EmpName, qbe.AccFundID, qbe.AccBranchCode, qbe.DesigID, qbe.DepartmentID, qbe.JoinDate, qbe.GradeID, qbe.EmpGroupID, qbe.Card_id, qbe.EmpGenderID, qbe.EmpTypeID, qbe.EmpStatusID, qbe.StaffTypeID, qbe.PF_JoinDate, qbe.FName, qbe.MName, qbe.SName, qbe.LastEdu, qbe.BirthDate, qbe.PAddress, qbe.CAddress, qbe.CellNumber, qbe.BloodGrpID, qbe.ProdLineNo, qbe.NationalID, qbe.TIN, qbe.RCNO, qbe.EmpGarantor, qbe.EmpGarantorRel, qbe.EmpGarantorAddress, qbe.EmpGarantorCell, qbe.ConfirmationDate, qbe.EmpLeft, qbe.UserID, qbe.LastUpdate, qbe.OffDay);
        }
        
        public int SelectCount(
                    long? employeeID, 
                    string empCode, 
                    string empName, 
                    long? accFundID, 
                    int? accBranchCode, 
                    long? desigID, 
                    long? departmentID, 
                    DateTime? joinDate, 
                    int? gradeID, 
                    int? empGroupID, 
                    string card_id, 
                    int? empGenderID, 
                    int? empTypeID, 
                    int? empStatusID, 
                    long? staffTypeID, 
                    DateTime? pF_JoinDate, 
                    string fName, 
                    string mName, 
                    string sName, 
                    string lastEdu, 
                    DateTime? birthDate, 
                    string pAddress, 
                    string cAddress, 
                    string cellNumber, 
                    int? bloodGrpID, 
                    int? prodLineNo, 
                    string nationalID, 
                    string tIN, 
                    string rCNO, 
                    string empGarantor, 
                    string empGarantorRel, 
                    string empGarantorAddress, 
                    string empGarantorCell, 
                    DateTime? confirmationDate, 
                    bool? empLeft, 
                    string userID, 
                    DateTime? lastUpdate, 
                    DateTime? offDay, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(employeeID, empCode, empName, accFundID, accBranchCode, desigID, departmentID, joinDate, gradeID, empGroupID, card_id, empGenderID, empTypeID, empStatusID, staffTypeID, pF_JoinDate, fName, mName, sName, lastEdu, birthDate, pAddress, cAddress, cellNumber, bloodGrpID, prodLineNo, nationalID, tIN, rCNO, empGarantor, empGarantorRel, empGarantorAddress, empGarantorCell, confirmationDate, empLeft, userID, lastUpdate, offDay, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Employees", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.Employees> Select(
                    long? employeeID, 
                    string empCode, 
                    string empName, 
                    long? accFundID, 
                    int? accBranchCode, 
                    long? desigID, 
                    long? departmentID, 
                    DateTime? joinDate, 
                    int? gradeID, 
                    int? empGroupID, 
                    string card_id, 
                    int? empGenderID, 
                    int? empTypeID, 
                    int? empStatusID, 
                    long? staffTypeID, 
                    DateTime? pF_JoinDate, 
                    string fName, 
                    string mName, 
                    string sName, 
                    string lastEdu, 
                    DateTime? birthDate, 
                    string pAddress, 
                    string cAddress, 
                    string cellNumber, 
                    int? bloodGrpID, 
                    int? prodLineNo, 
                    string nationalID, 
                    string tIN, 
                    string rCNO, 
                    string empGarantor, 
                    string empGarantorRel, 
                    string empGarantorAddress, 
                    string empGarantorCell, 
                    DateTime? confirmationDate, 
                    bool? empLeft, 
                    string userID, 
                    DateTime? lastUpdate, 
                    DateTime? offDay)
        {
            return Select(employeeID, empCode, empName, accFundID, accBranchCode, desigID, departmentID, joinDate, gradeID, empGroupID, card_id, empGenderID, empTypeID, empStatusID, staffTypeID, pF_JoinDate, fName, mName, sName, lastEdu, birthDate, pAddress, cAddress, cellNumber, bloodGrpID, prodLineNo, nationalID, tIN, rCNO, empGarantor, empGarantorRel, empGarantorAddress, empGarantorCell, confirmationDate, empLeft, userID, lastUpdate, offDay, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.Employees SelectSingle(long? employeeID)
        {
            List<MyCompany.Data.Objects.Employees> list = Select(employeeID, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.Employees> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("Employees", dataView, request);
            return page.ToList<MyCompany.Data.Objects.Employees>();
        }
        
        public List<MyCompany.Data.Objects.Employees> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.Employees> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.Employees SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.Employees> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.Employees theEmployees, MyCompany.Data.Objects.Employees original_Employees)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("EmployeeID", original_Employees.EmployeeID, theEmployees.EmployeeID, true));
            values.Add(new FieldValue("EmpCode", original_Employees.EmpCode, theEmployees.EmpCode));
            values.Add(new FieldValue("EmpName", original_Employees.EmpName, theEmployees.EmpName));
            values.Add(new FieldValue("AccFundID", original_Employees.AccFundID, theEmployees.AccFundID));
            values.Add(new FieldValue("AccBranchCode", original_Employees.AccBranchCode, theEmployees.AccBranchCode));
            values.Add(new FieldValue("DesigID", original_Employees.DesigID, theEmployees.DesigID));
            values.Add(new FieldValue("DepartmentID", original_Employees.DepartmentID, theEmployees.DepartmentID));
            values.Add(new FieldValue("JoinDate", original_Employees.JoinDate, theEmployees.JoinDate));
            values.Add(new FieldValue("GradeID", original_Employees.GradeID, theEmployees.GradeID));
            values.Add(new FieldValue("EmpGroupID", original_Employees.EmpGroupID, theEmployees.EmpGroupID));
            values.Add(new FieldValue("Card_id", original_Employees.Card_id, theEmployees.Card_id));
            values.Add(new FieldValue("EmpGenderID", original_Employees.EmpGenderID, theEmployees.EmpGenderID));
            values.Add(new FieldValue("EmpTypeID", original_Employees.EmpTypeID, theEmployees.EmpTypeID));
            values.Add(new FieldValue("EmpStatusID", original_Employees.EmpStatusID, theEmployees.EmpStatusID));
            values.Add(new FieldValue("StaffTypeID", original_Employees.StaffTypeID, theEmployees.StaffTypeID));
            values.Add(new FieldValue("Photo", original_Employees.Photo, theEmployees.Photo));
            values.Add(new FieldValue("PF_JoinDate", original_Employees.PF_JoinDate, theEmployees.PF_JoinDate));
            values.Add(new FieldValue("FName", original_Employees.FName, theEmployees.FName));
            values.Add(new FieldValue("MName", original_Employees.MName, theEmployees.MName));
            values.Add(new FieldValue("SName", original_Employees.SName, theEmployees.SName));
            values.Add(new FieldValue("LastEdu", original_Employees.LastEdu, theEmployees.LastEdu));
            values.Add(new FieldValue("BirthDate", original_Employees.BirthDate, theEmployees.BirthDate));
            values.Add(new FieldValue("PAddress", original_Employees.PAddress, theEmployees.PAddress));
            values.Add(new FieldValue("CAddress", original_Employees.CAddress, theEmployees.CAddress));
            values.Add(new FieldValue("CellNumber", original_Employees.CellNumber, theEmployees.CellNumber));
            values.Add(new FieldValue("BloodGrpID", original_Employees.BloodGrpID, theEmployees.BloodGrpID));
            values.Add(new FieldValue("ProdLineNo", original_Employees.ProdLineNo, theEmployees.ProdLineNo));
            values.Add(new FieldValue("DegitalSign", original_Employees.DegitalSign, theEmployees.DegitalSign));
            values.Add(new FieldValue("NationalID", original_Employees.NationalID, theEmployees.NationalID));
            values.Add(new FieldValue("TIN", original_Employees.TIN, theEmployees.TIN));
            values.Add(new FieldValue("RCNO", original_Employees.RCNO, theEmployees.RCNO));
            values.Add(new FieldValue("EmpGarantor", original_Employees.EmpGarantor, theEmployees.EmpGarantor));
            values.Add(new FieldValue("EmpGarantorRel", original_Employees.EmpGarantorRel, theEmployees.EmpGarantorRel));
            values.Add(new FieldValue("EmpGarantorAddress", original_Employees.EmpGarantorAddress, theEmployees.EmpGarantorAddress));
            values.Add(new FieldValue("EmpGarantorCell", original_Employees.EmpGarantorCell, theEmployees.EmpGarantorCell));
            values.Add(new FieldValue("ConfirmationDate", original_Employees.ConfirmationDate, theEmployees.ConfirmationDate));
            values.Add(new FieldValue("EmpLeft", original_Employees.EmpLeft, theEmployees.EmpLeft));
            values.Add(new FieldValue("UserID", original_Employees.UserID, theEmployees.UserID));
            values.Add(new FieldValue("LastUpdate", original_Employees.LastUpdate, theEmployees.LastUpdate));
            values.Add(new FieldValue("OffDay", original_Employees.OffDay, theEmployees.OffDay));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.Employees theEmployees, MyCompany.Data.Objects.Employees original_Employees, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "Employees";
            args.View = dataView;
            args.Values = CreateFieldValues(theEmployees, original_Employees);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("Employees", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theEmployees);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.Employees theEmployees, MyCompany.Data.Objects.Employees original_Employees)
        {
            return ExecuteAction(theEmployees, original_Employees, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.Employees theEmployees)
        {
            return Update(theEmployees, SelectSingle(theEmployees.EmployeeID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.Employees theEmployees)
        {
            return ExecuteAction(theEmployees, new Employees(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.Employees theEmployees)
        {
            return ExecuteAction(theEmployees, theEmployees, "Select", "Delete", DeleteView);
        }
    }
}
