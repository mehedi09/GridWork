using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class BillRegisterSearch
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _billRegisterID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _billRegisterNo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _billDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _supplierID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _supplierAccSubName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _supplierAccSubTypeAccSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _productDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _reference;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _quantity;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _unitPrice;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _billAmount;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accFundID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accFundAccFundName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _projectID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private decimal? _paidAmount;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _vchrTranID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _vchrTypeID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _expenseHeadAccID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _headAccID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headAccAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headAccAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headAccAccCurrencyAccCurrencyName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headAccAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headAccAccDestCompanyTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headAccAccFundAccFundName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headAccAccSubTypeAccSubType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headAccAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headAccCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headAccCoaControlAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headAccCoaControlAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headAccCoaControlAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headAccCoaControlCompTypeDescription;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headAccCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headAccCoaMainAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headAccCoaMainAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headAccCoaMainAccFundAccFundName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headAccCoaMainAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headAccCoaMainCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headAccCoaSubAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headAccCoaSubAccBalTypeAccBalType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headAccCoaSubAccDestAccDest;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headAccCoaSubAccFundAccFundName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headAccCoaSubAccTypeAccType;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headAccCoaSubCoaControlAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _headAccCoaSubCoaMainAccName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _revAccID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _bankname;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _chequeNo;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _chequeDT;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isPost;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _postDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _isPartialPay;
        
        public BillRegisterSearch()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
        public int? BillRegisterID
        {
            get
            {
                return _billRegisterID;
            }
            set
            {
                _billRegisterID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string BillRegisterNo
        {
            get
            {
                return _billRegisterNo;
            }
            set
            {
                _billRegisterNo = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? BillDate
        {
            get
            {
                return _billDate;
            }
            set
            {
                _billDate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? SupplierID
        {
            get
            {
                return _supplierID;
            }
            set
            {
                _supplierID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SupplierAccSubName
        {
            get
            {
                return _supplierAccSubName;
            }
            set
            {
                _supplierAccSubName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string SupplierAccSubTypeAccSubType
        {
            get
            {
                return _supplierAccSubTypeAccSubType;
            }
            set
            {
                _supplierAccSubTypeAccSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ProductDescription
        {
            get
            {
                return _productDescription;
            }
            set
            {
                _productDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Reference
        {
            get
            {
                return _reference;
            }
            set
            {
                _reference = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public decimal? Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public decimal? UnitPrice
        {
            get
            {
                return _unitPrice;
            }
            set
            {
                _unitPrice = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public decimal? BillAmount
        {
            get
            {
                return _billAmount;
            }
            set
            {
                _billAmount = value;
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
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string AccFundAccFundName
        {
            get
            {
                return _accFundAccFundName;
            }
            set
            {
                _accFundAccFundName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? ProjectID
        {
            get
            {
                return _projectID;
            }
            set
            {
                _projectID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public decimal? PaidAmount
        {
            get
            {
                return _paidAmount;
            }
            set
            {
                _paidAmount = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? VchrTranID
        {
            get
            {
                return _vchrTranID;
            }
            set
            {
                _vchrTranID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? VchrTypeID
        {
            get
            {
                return _vchrTypeID;
            }
            set
            {
                _vchrTypeID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? ExpenseHeadAccID
        {
            get
            {
                return _expenseHeadAccID;
            }
            set
            {
                _expenseHeadAccID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? HeadAccID
        {
            get
            {
                return _headAccID;
            }
            set
            {
                _headAccID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadAccAccName
        {
            get
            {
                return _headAccAccName;
            }
            set
            {
                _headAccAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadAccAccBalTypeAccBalType
        {
            get
            {
                return _headAccAccBalTypeAccBalType;
            }
            set
            {
                _headAccAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadAccAccCurrencyAccCurrencyName
        {
            get
            {
                return _headAccAccCurrencyAccCurrencyName;
            }
            set
            {
                _headAccAccCurrencyAccCurrencyName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadAccAccDestAccDest
        {
            get
            {
                return _headAccAccDestAccDest;
            }
            set
            {
                _headAccAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadAccAccDestCompanyTypeDescription
        {
            get
            {
                return _headAccAccDestCompanyTypeDescription;
            }
            set
            {
                _headAccAccDestCompanyTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadAccAccFundAccFundName
        {
            get
            {
                return _headAccAccFundAccFundName;
            }
            set
            {
                _headAccAccFundAccFundName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadAccAccSubTypeAccSubType
        {
            get
            {
                return _headAccAccSubTypeAccSubType;
            }
            set
            {
                _headAccAccSubTypeAccSubType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadAccAccTypeAccType
        {
            get
            {
                return _headAccAccTypeAccType;
            }
            set
            {
                _headAccAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadAccCoaControlAccName
        {
            get
            {
                return _headAccCoaControlAccName;
            }
            set
            {
                _headAccCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadAccCoaControlAccBalTypeAccBalType
        {
            get
            {
                return _headAccCoaControlAccBalTypeAccBalType;
            }
            set
            {
                _headAccCoaControlAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadAccCoaControlAccDestAccDest
        {
            get
            {
                return _headAccCoaControlAccDestAccDest;
            }
            set
            {
                _headAccCoaControlAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadAccCoaControlAccTypeAccType
        {
            get
            {
                return _headAccCoaControlAccTypeAccType;
            }
            set
            {
                _headAccCoaControlAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadAccCoaControlCompTypeDescription
        {
            get
            {
                return _headAccCoaControlCompTypeDescription;
            }
            set
            {
                _headAccCoaControlCompTypeDescription = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadAccCoaMainAccName
        {
            get
            {
                return _headAccCoaMainAccName;
            }
            set
            {
                _headAccCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadAccCoaMainAccBalTypeAccBalType
        {
            get
            {
                return _headAccCoaMainAccBalTypeAccBalType;
            }
            set
            {
                _headAccCoaMainAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadAccCoaMainAccDestAccDest
        {
            get
            {
                return _headAccCoaMainAccDestAccDest;
            }
            set
            {
                _headAccCoaMainAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadAccCoaMainAccFundAccFundName
        {
            get
            {
                return _headAccCoaMainAccFundAccFundName;
            }
            set
            {
                _headAccCoaMainAccFundAccFundName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadAccCoaMainAccTypeAccType
        {
            get
            {
                return _headAccCoaMainAccTypeAccType;
            }
            set
            {
                _headAccCoaMainAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadAccCoaMainCoaControlAccName
        {
            get
            {
                return _headAccCoaMainCoaControlAccName;
            }
            set
            {
                _headAccCoaMainCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadAccCoaSubAccName
        {
            get
            {
                return _headAccCoaSubAccName;
            }
            set
            {
                _headAccCoaSubAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadAccCoaSubAccBalTypeAccBalType
        {
            get
            {
                return _headAccCoaSubAccBalTypeAccBalType;
            }
            set
            {
                _headAccCoaSubAccBalTypeAccBalType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadAccCoaSubAccDestAccDest
        {
            get
            {
                return _headAccCoaSubAccDestAccDest;
            }
            set
            {
                _headAccCoaSubAccDestAccDest = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadAccCoaSubAccFundAccFundName
        {
            get
            {
                return _headAccCoaSubAccFundAccFundName;
            }
            set
            {
                _headAccCoaSubAccFundAccFundName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadAccCoaSubAccTypeAccType
        {
            get
            {
                return _headAccCoaSubAccTypeAccType;
            }
            set
            {
                _headAccCoaSubAccTypeAccType = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadAccCoaSubCoaControlAccName
        {
            get
            {
                return _headAccCoaSubCoaControlAccName;
            }
            set
            {
                _headAccCoaSubCoaControlAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string HeadAccCoaSubCoaMainAccName
        {
            get
            {
                return _headAccCoaSubCoaMainAccName;
            }
            set
            {
                _headAccCoaSubCoaMainAccName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? RevAccID
        {
            get
            {
                return _revAccID;
            }
            set
            {
                _revAccID = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Bankname
        {
            get
            {
                return _bankname;
            }
            set
            {
                _bankname = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string ChequeNo
        {
            get
            {
                return _chequeNo;
            }
            set
            {
                _chequeNo = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? ChequeDT
        {
            get
            {
                return _chequeDT;
            }
            set
            {
                _chequeDT = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? IsPost
        {
            get
            {
                return _isPost;
            }
            set
            {
                _isPost = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? PostDate
        {
            get
            {
                return _postDate;
            }
            set
            {
                _postDate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string IsPartialPay
        {
            get
            {
                return _isPartialPay;
            }
            set
            {
                _isPartialPay = value;
            }
        }
        
        public static List<MyCompany.Data.Objects.BillRegisterSearch> Select(
                    int? billRegisterID, 
                    string billRegisterNo, 
                    DateTime? billDate, 
                    int? supplierID, 
                    string supplierAccSubName, 
                    string supplierAccSubTypeAccSubType, 
                    string productDescription, 
                    string reference, 
                    decimal? quantity, 
                    decimal? unitPrice, 
                    decimal? billAmount, 
                    int? accFundID, 
                    string accFundAccFundName, 
                    int? projectID, 
                    decimal? paidAmount, 
                    int? vchrTranID, 
                    int? vchrTypeID, 
                    int? expenseHeadAccID, 
                    int? headAccID, 
                    string headAccAccName, 
                    string headAccAccBalTypeAccBalType, 
                    string headAccAccCurrencyAccCurrencyName, 
                    string headAccAccDestAccDest, 
                    string headAccAccDestCompanyTypeDescription, 
                    string headAccAccFundAccFundName, 
                    string headAccAccSubTypeAccSubType, 
                    string headAccAccTypeAccType, 
                    string headAccCoaControlAccName, 
                    string headAccCoaControlAccBalTypeAccBalType, 
                    string headAccCoaControlAccDestAccDest, 
                    string headAccCoaControlAccTypeAccType, 
                    string headAccCoaControlCompTypeDescription, 
                    string headAccCoaMainAccName, 
                    string headAccCoaMainAccBalTypeAccBalType, 
                    string headAccCoaMainAccDestAccDest, 
                    string headAccCoaMainAccFundAccFundName, 
                    string headAccCoaMainAccTypeAccType, 
                    string headAccCoaMainCoaControlAccName, 
                    string headAccCoaSubAccName, 
                    string headAccCoaSubAccBalTypeAccBalType, 
                    string headAccCoaSubAccDestAccDest, 
                    string headAccCoaSubAccFundAccFundName, 
                    string headAccCoaSubAccTypeAccType, 
                    string headAccCoaSubCoaControlAccName, 
                    string headAccCoaSubCoaMainAccName, 
                    int? revAccID, 
                    string bankname, 
                    string chequeNo, 
                    DateTime? chequeDT, 
                    bool? isPost, 
                    DateTime? postDate, 
                    string isPartialPay)
        {
            return new BillRegisterSearchFactory().Select(billRegisterID, billRegisterNo, billDate, supplierID, supplierAccSubName, supplierAccSubTypeAccSubType, productDescription, reference, quantity, unitPrice, billAmount, accFundID, accFundAccFundName, projectID, paidAmount, vchrTranID, vchrTypeID, expenseHeadAccID, headAccID, headAccAccName, headAccAccBalTypeAccBalType, headAccAccCurrencyAccCurrencyName, headAccAccDestAccDest, headAccAccDestCompanyTypeDescription, headAccAccFundAccFundName, headAccAccSubTypeAccSubType, headAccAccTypeAccType, headAccCoaControlAccName, headAccCoaControlAccBalTypeAccBalType, headAccCoaControlAccDestAccDest, headAccCoaControlAccTypeAccType, headAccCoaControlCompTypeDescription, headAccCoaMainAccName, headAccCoaMainAccBalTypeAccBalType, headAccCoaMainAccDestAccDest, headAccCoaMainAccFundAccFundName, headAccCoaMainAccTypeAccType, headAccCoaMainCoaControlAccName, headAccCoaSubAccName, headAccCoaSubAccBalTypeAccBalType, headAccCoaSubAccDestAccDest, headAccCoaSubAccFundAccFundName, headAccCoaSubAccTypeAccType, headAccCoaSubCoaControlAccName, headAccCoaSubCoaMainAccName, revAccID, bankname, chequeNo, chequeDT, isPost, postDate, isPartialPay);
        }
        
        public static List<MyCompany.Data.Objects.BillRegisterSearch> Select(MyCompany.Data.Objects.BillRegisterSearch qbe)
        {
            return new BillRegisterSearchFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.BillRegisterSearch> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new BillRegisterSearchFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.BillRegisterSearch> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new BillRegisterSearchFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.BillRegisterSearch> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new BillRegisterSearchFactory().Select(filter, sort, BillRegisterSearchFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.BillRegisterSearch> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new BillRegisterSearchFactory().Select(filter, sort, BillRegisterSearchFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.BillRegisterSearch> Select(string filter, BusinessObjectParameters parameters)
        {
            return new BillRegisterSearchFactory().Select(filter, null, BillRegisterSearchFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.BillRegisterSearch> Select(string filter, params FieldValue[] parameters)
        {
            return new BillRegisterSearchFactory().Select(filter, null, BillRegisterSearchFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.BillRegisterSearch SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new BillRegisterSearchFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.BillRegisterSearch SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new BillRegisterSearchFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.BillRegisterSearch SelectSingle(int? billRegisterID)
        {
            return new BillRegisterSearchFactory().SelectSingle(billRegisterID);
        }
        
        public int Insert()
        {
            return new BillRegisterSearchFactory().Insert(this);
        }
        
        public int Update()
        {
            return new BillRegisterSearchFactory().Update(this);
        }
        
        public int Delete()
        {
            return new BillRegisterSearchFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("BillRegisterID: {0}", this.BillRegisterID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class BillRegisterSearchFactory
    {
        
        public BillRegisterSearchFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("BillRegisterSearch");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("BillRegisterSearch");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("BillRegisterSearch");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("BillRegisterSearch");
            }
        }
        
        public static BillRegisterSearchFactory Create()
        {
            return new BillRegisterSearchFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    int? billRegisterID, 
                    string billRegisterNo, 
                    DateTime? billDate, 
                    int? supplierID, 
                    string supplierAccSubName, 
                    string supplierAccSubTypeAccSubType, 
                    string productDescription, 
                    string reference, 
                    decimal? quantity, 
                    decimal? unitPrice, 
                    decimal? billAmount, 
                    int? accFundID, 
                    string accFundAccFundName, 
                    int? projectID, 
                    decimal? paidAmount, 
                    int? vchrTranID, 
                    int? vchrTypeID, 
                    int? expenseHeadAccID, 
                    int? headAccID, 
                    string headAccAccName, 
                    string headAccAccBalTypeAccBalType, 
                    string headAccAccCurrencyAccCurrencyName, 
                    string headAccAccDestAccDest, 
                    string headAccAccDestCompanyTypeDescription, 
                    string headAccAccFundAccFundName, 
                    string headAccAccSubTypeAccSubType, 
                    string headAccAccTypeAccType, 
                    string headAccCoaControlAccName, 
                    string headAccCoaControlAccBalTypeAccBalType, 
                    string headAccCoaControlAccDestAccDest, 
                    string headAccCoaControlAccTypeAccType, 
                    string headAccCoaControlCompTypeDescription, 
                    string headAccCoaMainAccName, 
                    string headAccCoaMainAccBalTypeAccBalType, 
                    string headAccCoaMainAccDestAccDest, 
                    string headAccCoaMainAccFundAccFundName, 
                    string headAccCoaMainAccTypeAccType, 
                    string headAccCoaMainCoaControlAccName, 
                    string headAccCoaSubAccName, 
                    string headAccCoaSubAccBalTypeAccBalType, 
                    string headAccCoaSubAccDestAccDest, 
                    string headAccCoaSubAccFundAccFundName, 
                    string headAccCoaSubAccTypeAccType, 
                    string headAccCoaSubCoaControlAccName, 
                    string headAccCoaSubCoaMainAccName, 
                    int? revAccID, 
                    string bankname, 
                    string chequeNo, 
                    DateTime? chequeDT, 
                    bool? isPost, 
                    DateTime? postDate, 
                    string isPartialPay, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (billRegisterID.HasValue)
            	filter.Add(("BillRegisterID:=" + billRegisterID.Value.ToString()));
            if (!(String.IsNullOrEmpty(billRegisterNo)))
            	filter.Add(("BillRegisterNo:*" + billRegisterNo));
            if (billDate.HasValue)
            	filter.Add(("BillDate:=" + billDate.Value.ToString()));
            if (supplierID.HasValue)
            	filter.Add(("SupplierID:=" + supplierID.Value.ToString()));
            if (!(String.IsNullOrEmpty(supplierAccSubName)))
            	filter.Add(("SupplierAccSubName:*" + supplierAccSubName));
            if (!(String.IsNullOrEmpty(supplierAccSubTypeAccSubType)))
            	filter.Add(("SupplierAccSubTypeAccSubType:*" + supplierAccSubTypeAccSubType));
            if (!(String.IsNullOrEmpty(productDescription)))
            	filter.Add(("ProductDescription:*" + productDescription));
            if (!(String.IsNullOrEmpty(reference)))
            	filter.Add(("Reference:*" + reference));
            if (quantity.HasValue)
            	filter.Add(("Quantity:=" + quantity.Value.ToString()));
            if (unitPrice.HasValue)
            	filter.Add(("UnitPrice:=" + unitPrice.Value.ToString()));
            if (billAmount.HasValue)
            	filter.Add(("BillAmount:=" + billAmount.Value.ToString()));
            if (accFundID.HasValue)
            	filter.Add(("AccFundID:=" + accFundID.Value.ToString()));
            if (!(String.IsNullOrEmpty(accFundAccFundName)))
            	filter.Add(("AccFundAccFundName:*" + accFundAccFundName));
            if (projectID.HasValue)
            	filter.Add(("ProjectID:=" + projectID.Value.ToString()));
            if (paidAmount.HasValue)
            	filter.Add(("PaidAmount:=" + paidAmount.Value.ToString()));
            if (vchrTranID.HasValue)
            	filter.Add(("VchrTranID:=" + vchrTranID.Value.ToString()));
            if (vchrTypeID.HasValue)
            	filter.Add(("VchrTypeID:=" + vchrTypeID.Value.ToString()));
            if (expenseHeadAccID.HasValue)
            	filter.Add(("ExpenseHeadAccID:=" + expenseHeadAccID.Value.ToString()));
            if (headAccID.HasValue)
            	filter.Add(("HeadAccID:=" + headAccID.Value.ToString()));
            if (!(String.IsNullOrEmpty(headAccAccName)))
            	filter.Add(("HeadAccAccName:*" + headAccAccName));
            if (!(String.IsNullOrEmpty(headAccAccBalTypeAccBalType)))
            	filter.Add(("HeadAccAccBalTypeAccBalType:*" + headAccAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(headAccAccCurrencyAccCurrencyName)))
            	filter.Add(("HeadAccAccCurrencyAccCurrencyName:*" + headAccAccCurrencyAccCurrencyName));
            if (!(String.IsNullOrEmpty(headAccAccDestAccDest)))
            	filter.Add(("HeadAccAccDestAccDest:*" + headAccAccDestAccDest));
            if (!(String.IsNullOrEmpty(headAccAccDestCompanyTypeDescription)))
            	filter.Add(("HeadAccAccDestCompanyTypeDescription:*" + headAccAccDestCompanyTypeDescription));
            if (!(String.IsNullOrEmpty(headAccAccFundAccFundName)))
            	filter.Add(("HeadAccAccFundAccFundName:*" + headAccAccFundAccFundName));
            if (!(String.IsNullOrEmpty(headAccAccSubTypeAccSubType)))
            	filter.Add(("HeadAccAccSubTypeAccSubType:*" + headAccAccSubTypeAccSubType));
            if (!(String.IsNullOrEmpty(headAccAccTypeAccType)))
            	filter.Add(("HeadAccAccTypeAccType:*" + headAccAccTypeAccType));
            if (!(String.IsNullOrEmpty(headAccCoaControlAccName)))
            	filter.Add(("HeadAccCoaControlAccName:*" + headAccCoaControlAccName));
            if (!(String.IsNullOrEmpty(headAccCoaControlAccBalTypeAccBalType)))
            	filter.Add(("HeadAccCoaControlAccBalTypeAccBalType:*" + headAccCoaControlAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(headAccCoaControlAccDestAccDest)))
            	filter.Add(("HeadAccCoaControlAccDestAccDest:*" + headAccCoaControlAccDestAccDest));
            if (!(String.IsNullOrEmpty(headAccCoaControlAccTypeAccType)))
            	filter.Add(("HeadAccCoaControlAccTypeAccType:*" + headAccCoaControlAccTypeAccType));
            if (!(String.IsNullOrEmpty(headAccCoaControlCompTypeDescription)))
            	filter.Add(("HeadAccCoaControlCompTypeDescription:*" + headAccCoaControlCompTypeDescription));
            if (!(String.IsNullOrEmpty(headAccCoaMainAccName)))
            	filter.Add(("HeadAccCoaMainAccName:*" + headAccCoaMainAccName));
            if (!(String.IsNullOrEmpty(headAccCoaMainAccBalTypeAccBalType)))
            	filter.Add(("HeadAccCoaMainAccBalTypeAccBalType:*" + headAccCoaMainAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(headAccCoaMainAccDestAccDest)))
            	filter.Add(("HeadAccCoaMainAccDestAccDest:*" + headAccCoaMainAccDestAccDest));
            if (!(String.IsNullOrEmpty(headAccCoaMainAccFundAccFundName)))
            	filter.Add(("HeadAccCoaMainAccFundAccFundName:*" + headAccCoaMainAccFundAccFundName));
            if (!(String.IsNullOrEmpty(headAccCoaMainAccTypeAccType)))
            	filter.Add(("HeadAccCoaMainAccTypeAccType:*" + headAccCoaMainAccTypeAccType));
            if (!(String.IsNullOrEmpty(headAccCoaMainCoaControlAccName)))
            	filter.Add(("HeadAccCoaMainCoaControlAccName:*" + headAccCoaMainCoaControlAccName));
            if (!(String.IsNullOrEmpty(headAccCoaSubAccName)))
            	filter.Add(("HeadAccCoaSubAccName:*" + headAccCoaSubAccName));
            if (!(String.IsNullOrEmpty(headAccCoaSubAccBalTypeAccBalType)))
            	filter.Add(("HeadAccCoaSubAccBalTypeAccBalType:*" + headAccCoaSubAccBalTypeAccBalType));
            if (!(String.IsNullOrEmpty(headAccCoaSubAccDestAccDest)))
            	filter.Add(("HeadAccCoaSubAccDestAccDest:*" + headAccCoaSubAccDestAccDest));
            if (!(String.IsNullOrEmpty(headAccCoaSubAccFundAccFundName)))
            	filter.Add(("HeadAccCoaSubAccFundAccFundName:*" + headAccCoaSubAccFundAccFundName));
            if (!(String.IsNullOrEmpty(headAccCoaSubAccTypeAccType)))
            	filter.Add(("HeadAccCoaSubAccTypeAccType:*" + headAccCoaSubAccTypeAccType));
            if (!(String.IsNullOrEmpty(headAccCoaSubCoaControlAccName)))
            	filter.Add(("HeadAccCoaSubCoaControlAccName:*" + headAccCoaSubCoaControlAccName));
            if (!(String.IsNullOrEmpty(headAccCoaSubCoaMainAccName)))
            	filter.Add(("HeadAccCoaSubCoaMainAccName:*" + headAccCoaSubCoaMainAccName));
            if (revAccID.HasValue)
            	filter.Add(("RevAccID:=" + revAccID.Value.ToString()));
            if (!(String.IsNullOrEmpty(bankname)))
            	filter.Add(("Bankname:*" + bankname));
            if (!(String.IsNullOrEmpty(chequeNo)))
            	filter.Add(("ChequeNo:*" + chequeNo));
            if (chequeDT.HasValue)
            	filter.Add(("ChequeDT:=" + chequeDT.Value.ToString()));
            if (isPost.HasValue)
            	filter.Add(("IsPost:=" + isPost.Value.ToString()));
            if (postDate.HasValue)
            	filter.Add(("PostDate:=" + postDate.Value.ToString()));
            if (!(String.IsNullOrEmpty(isPartialPay)))
            	filter.Add(("IsPartialPay:*" + isPartialPay));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.BillRegisterSearch> Select(
                    int? billRegisterID, 
                    string billRegisterNo, 
                    DateTime? billDate, 
                    int? supplierID, 
                    string supplierAccSubName, 
                    string supplierAccSubTypeAccSubType, 
                    string productDescription, 
                    string reference, 
                    decimal? quantity, 
                    decimal? unitPrice, 
                    decimal? billAmount, 
                    int? accFundID, 
                    string accFundAccFundName, 
                    int? projectID, 
                    decimal? paidAmount, 
                    int? vchrTranID, 
                    int? vchrTypeID, 
                    int? expenseHeadAccID, 
                    int? headAccID, 
                    string headAccAccName, 
                    string headAccAccBalTypeAccBalType, 
                    string headAccAccCurrencyAccCurrencyName, 
                    string headAccAccDestAccDest, 
                    string headAccAccDestCompanyTypeDescription, 
                    string headAccAccFundAccFundName, 
                    string headAccAccSubTypeAccSubType, 
                    string headAccAccTypeAccType, 
                    string headAccCoaControlAccName, 
                    string headAccCoaControlAccBalTypeAccBalType, 
                    string headAccCoaControlAccDestAccDest, 
                    string headAccCoaControlAccTypeAccType, 
                    string headAccCoaControlCompTypeDescription, 
                    string headAccCoaMainAccName, 
                    string headAccCoaMainAccBalTypeAccBalType, 
                    string headAccCoaMainAccDestAccDest, 
                    string headAccCoaMainAccFundAccFundName, 
                    string headAccCoaMainAccTypeAccType, 
                    string headAccCoaMainCoaControlAccName, 
                    string headAccCoaSubAccName, 
                    string headAccCoaSubAccBalTypeAccBalType, 
                    string headAccCoaSubAccDestAccDest, 
                    string headAccCoaSubAccFundAccFundName, 
                    string headAccCoaSubAccTypeAccType, 
                    string headAccCoaSubCoaControlAccName, 
                    string headAccCoaSubCoaMainAccName, 
                    int? revAccID, 
                    string bankname, 
                    string chequeNo, 
                    DateTime? chequeDT, 
                    bool? isPost, 
                    DateTime? postDate, 
                    string isPartialPay, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(billRegisterID, billRegisterNo, billDate, supplierID, supplierAccSubName, supplierAccSubTypeAccSubType, productDescription, reference, quantity, unitPrice, billAmount, accFundID, accFundAccFundName, projectID, paidAmount, vchrTranID, vchrTypeID, expenseHeadAccID, headAccID, headAccAccName, headAccAccBalTypeAccBalType, headAccAccCurrencyAccCurrencyName, headAccAccDestAccDest, headAccAccDestCompanyTypeDescription, headAccAccFundAccFundName, headAccAccSubTypeAccSubType, headAccAccTypeAccType, headAccCoaControlAccName, headAccCoaControlAccBalTypeAccBalType, headAccCoaControlAccDestAccDest, headAccCoaControlAccTypeAccType, headAccCoaControlCompTypeDescription, headAccCoaMainAccName, headAccCoaMainAccBalTypeAccBalType, headAccCoaMainAccDestAccDest, headAccCoaMainAccFundAccFundName, headAccCoaMainAccTypeAccType, headAccCoaMainCoaControlAccName, headAccCoaSubAccName, headAccCoaSubAccBalTypeAccBalType, headAccCoaSubAccDestAccDest, headAccCoaSubAccFundAccFundName, headAccCoaSubAccTypeAccType, headAccCoaSubCoaControlAccName, headAccCoaSubCoaMainAccName, revAccID, bankname, chequeNo, chequeDT, isPost, postDate, isPartialPay, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("BillRegisterSearch", dataView, request);
            return page.ToList<MyCompany.Data.Objects.BillRegisterSearch>();
        }
        
        public List<MyCompany.Data.Objects.BillRegisterSearch> Select(MyCompany.Data.Objects.BillRegisterSearch qbe)
        {
            return Select(qbe.BillRegisterID, qbe.BillRegisterNo, qbe.BillDate, qbe.SupplierID, qbe.SupplierAccSubName, qbe.SupplierAccSubTypeAccSubType, qbe.ProductDescription, qbe.Reference, qbe.Quantity, qbe.UnitPrice, qbe.BillAmount, qbe.AccFundID, qbe.AccFundAccFundName, qbe.ProjectID, qbe.PaidAmount, qbe.VchrTranID, qbe.VchrTypeID, qbe.ExpenseHeadAccID, qbe.HeadAccID, qbe.HeadAccAccName, qbe.HeadAccAccBalTypeAccBalType, qbe.HeadAccAccCurrencyAccCurrencyName, qbe.HeadAccAccDestAccDest, qbe.HeadAccAccDestCompanyTypeDescription, qbe.HeadAccAccFundAccFundName, qbe.HeadAccAccSubTypeAccSubType, qbe.HeadAccAccTypeAccType, qbe.HeadAccCoaControlAccName, qbe.HeadAccCoaControlAccBalTypeAccBalType, qbe.HeadAccCoaControlAccDestAccDest, qbe.HeadAccCoaControlAccTypeAccType, qbe.HeadAccCoaControlCompTypeDescription, qbe.HeadAccCoaMainAccName, qbe.HeadAccCoaMainAccBalTypeAccBalType, qbe.HeadAccCoaMainAccDestAccDest, qbe.HeadAccCoaMainAccFundAccFundName, qbe.HeadAccCoaMainAccTypeAccType, qbe.HeadAccCoaMainCoaControlAccName, qbe.HeadAccCoaSubAccName, qbe.HeadAccCoaSubAccBalTypeAccBalType, qbe.HeadAccCoaSubAccDestAccDest, qbe.HeadAccCoaSubAccFundAccFundName, qbe.HeadAccCoaSubAccTypeAccType, qbe.HeadAccCoaSubCoaControlAccName, qbe.HeadAccCoaSubCoaMainAccName, qbe.RevAccID, qbe.Bankname, qbe.ChequeNo, qbe.ChequeDT, qbe.IsPost, qbe.PostDate, qbe.IsPartialPay);
        }
        
        public int SelectCount(
                    int? billRegisterID, 
                    string billRegisterNo, 
                    DateTime? billDate, 
                    int? supplierID, 
                    string supplierAccSubName, 
                    string supplierAccSubTypeAccSubType, 
                    string productDescription, 
                    string reference, 
                    decimal? quantity, 
                    decimal? unitPrice, 
                    decimal? billAmount, 
                    int? accFundID, 
                    string accFundAccFundName, 
                    int? projectID, 
                    decimal? paidAmount, 
                    int? vchrTranID, 
                    int? vchrTypeID, 
                    int? expenseHeadAccID, 
                    int? headAccID, 
                    string headAccAccName, 
                    string headAccAccBalTypeAccBalType, 
                    string headAccAccCurrencyAccCurrencyName, 
                    string headAccAccDestAccDest, 
                    string headAccAccDestCompanyTypeDescription, 
                    string headAccAccFundAccFundName, 
                    string headAccAccSubTypeAccSubType, 
                    string headAccAccTypeAccType, 
                    string headAccCoaControlAccName, 
                    string headAccCoaControlAccBalTypeAccBalType, 
                    string headAccCoaControlAccDestAccDest, 
                    string headAccCoaControlAccTypeAccType, 
                    string headAccCoaControlCompTypeDescription, 
                    string headAccCoaMainAccName, 
                    string headAccCoaMainAccBalTypeAccBalType, 
                    string headAccCoaMainAccDestAccDest, 
                    string headAccCoaMainAccFundAccFundName, 
                    string headAccCoaMainAccTypeAccType, 
                    string headAccCoaMainCoaControlAccName, 
                    string headAccCoaSubAccName, 
                    string headAccCoaSubAccBalTypeAccBalType, 
                    string headAccCoaSubAccDestAccDest, 
                    string headAccCoaSubAccFundAccFundName, 
                    string headAccCoaSubAccTypeAccType, 
                    string headAccCoaSubCoaControlAccName, 
                    string headAccCoaSubCoaMainAccName, 
                    int? revAccID, 
                    string bankname, 
                    string chequeNo, 
                    DateTime? chequeDT, 
                    bool? isPost, 
                    DateTime? postDate, 
                    string isPartialPay, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(billRegisterID, billRegisterNo, billDate, supplierID, supplierAccSubName, supplierAccSubTypeAccSubType, productDescription, reference, quantity, unitPrice, billAmount, accFundID, accFundAccFundName, projectID, paidAmount, vchrTranID, vchrTypeID, expenseHeadAccID, headAccID, headAccAccName, headAccAccBalTypeAccBalType, headAccAccCurrencyAccCurrencyName, headAccAccDestAccDest, headAccAccDestCompanyTypeDescription, headAccAccFundAccFundName, headAccAccSubTypeAccSubType, headAccAccTypeAccType, headAccCoaControlAccName, headAccCoaControlAccBalTypeAccBalType, headAccCoaControlAccDestAccDest, headAccCoaControlAccTypeAccType, headAccCoaControlCompTypeDescription, headAccCoaMainAccName, headAccCoaMainAccBalTypeAccBalType, headAccCoaMainAccDestAccDest, headAccCoaMainAccFundAccFundName, headAccCoaMainAccTypeAccType, headAccCoaMainCoaControlAccName, headAccCoaSubAccName, headAccCoaSubAccBalTypeAccBalType, headAccCoaSubAccDestAccDest, headAccCoaSubAccFundAccFundName, headAccCoaSubAccTypeAccType, headAccCoaSubCoaControlAccName, headAccCoaSubCoaMainAccName, revAccID, bankname, chequeNo, chequeDT, isPost, postDate, isPartialPay, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("BillRegisterSearch", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.BillRegisterSearch> Select(
                    int? billRegisterID, 
                    string billRegisterNo, 
                    DateTime? billDate, 
                    int? supplierID, 
                    string supplierAccSubName, 
                    string supplierAccSubTypeAccSubType, 
                    string productDescription, 
                    string reference, 
                    decimal? quantity, 
                    decimal? unitPrice, 
                    decimal? billAmount, 
                    int? accFundID, 
                    string accFundAccFundName, 
                    int? projectID, 
                    decimal? paidAmount, 
                    int? vchrTranID, 
                    int? vchrTypeID, 
                    int? expenseHeadAccID, 
                    int? headAccID, 
                    string headAccAccName, 
                    string headAccAccBalTypeAccBalType, 
                    string headAccAccCurrencyAccCurrencyName, 
                    string headAccAccDestAccDest, 
                    string headAccAccDestCompanyTypeDescription, 
                    string headAccAccFundAccFundName, 
                    string headAccAccSubTypeAccSubType, 
                    string headAccAccTypeAccType, 
                    string headAccCoaControlAccName, 
                    string headAccCoaControlAccBalTypeAccBalType, 
                    string headAccCoaControlAccDestAccDest, 
                    string headAccCoaControlAccTypeAccType, 
                    string headAccCoaControlCompTypeDescription, 
                    string headAccCoaMainAccName, 
                    string headAccCoaMainAccBalTypeAccBalType, 
                    string headAccCoaMainAccDestAccDest, 
                    string headAccCoaMainAccFundAccFundName, 
                    string headAccCoaMainAccTypeAccType, 
                    string headAccCoaMainCoaControlAccName, 
                    string headAccCoaSubAccName, 
                    string headAccCoaSubAccBalTypeAccBalType, 
                    string headAccCoaSubAccDestAccDest, 
                    string headAccCoaSubAccFundAccFundName, 
                    string headAccCoaSubAccTypeAccType, 
                    string headAccCoaSubCoaControlAccName, 
                    string headAccCoaSubCoaMainAccName, 
                    int? revAccID, 
                    string bankname, 
                    string chequeNo, 
                    DateTime? chequeDT, 
                    bool? isPost, 
                    DateTime? postDate, 
                    string isPartialPay)
        {
            return Select(billRegisterID, billRegisterNo, billDate, supplierID, supplierAccSubName, supplierAccSubTypeAccSubType, productDescription, reference, quantity, unitPrice, billAmount, accFundID, accFundAccFundName, projectID, paidAmount, vchrTranID, vchrTypeID, expenseHeadAccID, headAccID, headAccAccName, headAccAccBalTypeAccBalType, headAccAccCurrencyAccCurrencyName, headAccAccDestAccDest, headAccAccDestCompanyTypeDescription, headAccAccFundAccFundName, headAccAccSubTypeAccSubType, headAccAccTypeAccType, headAccCoaControlAccName, headAccCoaControlAccBalTypeAccBalType, headAccCoaControlAccDestAccDest, headAccCoaControlAccTypeAccType, headAccCoaControlCompTypeDescription, headAccCoaMainAccName, headAccCoaMainAccBalTypeAccBalType, headAccCoaMainAccDestAccDest, headAccCoaMainAccFundAccFundName, headAccCoaMainAccTypeAccType, headAccCoaMainCoaControlAccName, headAccCoaSubAccName, headAccCoaSubAccBalTypeAccBalType, headAccCoaSubAccDestAccDest, headAccCoaSubAccFundAccFundName, headAccCoaSubAccTypeAccType, headAccCoaSubCoaControlAccName, headAccCoaSubCoaMainAccName, revAccID, bankname, chequeNo, chequeDT, isPost, postDate, isPartialPay, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.BillRegisterSearch SelectSingle(int? billRegisterID)
        {
            List<MyCompany.Data.Objects.BillRegisterSearch> list = Select(billRegisterID, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.BillRegisterSearch> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("BillRegisterSearch", dataView, request);
            return page.ToList<MyCompany.Data.Objects.BillRegisterSearch>();
        }
        
        public List<MyCompany.Data.Objects.BillRegisterSearch> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.BillRegisterSearch> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.BillRegisterSearch SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.BillRegisterSearch> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.BillRegisterSearch theBillRegisterSearch, MyCompany.Data.Objects.BillRegisterSearch original_BillRegisterSearch)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("BillRegisterID", original_BillRegisterSearch.BillRegisterID, theBillRegisterSearch.BillRegisterID, true));
            values.Add(new FieldValue("BillRegisterNo", original_BillRegisterSearch.BillRegisterNo, theBillRegisterSearch.BillRegisterNo));
            values.Add(new FieldValue("BillDate", original_BillRegisterSearch.BillDate, theBillRegisterSearch.BillDate));
            values.Add(new FieldValue("SupplierID", original_BillRegisterSearch.SupplierID, theBillRegisterSearch.SupplierID));
            values.Add(new FieldValue("SupplierAccSubName", original_BillRegisterSearch.SupplierAccSubName, theBillRegisterSearch.SupplierAccSubName, true));
            values.Add(new FieldValue("SupplierAccSubTypeAccSubType", original_BillRegisterSearch.SupplierAccSubTypeAccSubType, theBillRegisterSearch.SupplierAccSubTypeAccSubType, true));
            values.Add(new FieldValue("ProductDescription", original_BillRegisterSearch.ProductDescription, theBillRegisterSearch.ProductDescription));
            values.Add(new FieldValue("Reference", original_BillRegisterSearch.Reference, theBillRegisterSearch.Reference));
            values.Add(new FieldValue("Quantity", original_BillRegisterSearch.Quantity, theBillRegisterSearch.Quantity));
            values.Add(new FieldValue("UnitPrice", original_BillRegisterSearch.UnitPrice, theBillRegisterSearch.UnitPrice));
            values.Add(new FieldValue("BillAmount", original_BillRegisterSearch.BillAmount, theBillRegisterSearch.BillAmount));
            values.Add(new FieldValue("AccFundID", original_BillRegisterSearch.AccFundID, theBillRegisterSearch.AccFundID));
            values.Add(new FieldValue("AccFundAccFundName", original_BillRegisterSearch.AccFundAccFundName, theBillRegisterSearch.AccFundAccFundName, true));
            values.Add(new FieldValue("ProjectID", original_BillRegisterSearch.ProjectID, theBillRegisterSearch.ProjectID));
            values.Add(new FieldValue("PaidAmount", original_BillRegisterSearch.PaidAmount, theBillRegisterSearch.PaidAmount));
            values.Add(new FieldValue("VchrTranID", original_BillRegisterSearch.VchrTranID, theBillRegisterSearch.VchrTranID));
            values.Add(new FieldValue("VchrTypeID", original_BillRegisterSearch.VchrTypeID, theBillRegisterSearch.VchrTypeID));
            values.Add(new FieldValue("ExpenseHeadAccID", original_BillRegisterSearch.ExpenseHeadAccID, theBillRegisterSearch.ExpenseHeadAccID));
            values.Add(new FieldValue("HeadAccID", original_BillRegisterSearch.HeadAccID, theBillRegisterSearch.HeadAccID));
            values.Add(new FieldValue("HeadAccAccName", original_BillRegisterSearch.HeadAccAccName, theBillRegisterSearch.HeadAccAccName, true));
            values.Add(new FieldValue("HeadAccAccBalTypeAccBalType", original_BillRegisterSearch.HeadAccAccBalTypeAccBalType, theBillRegisterSearch.HeadAccAccBalTypeAccBalType, true));
            values.Add(new FieldValue("HeadAccAccCurrencyAccCurrencyName", original_BillRegisterSearch.HeadAccAccCurrencyAccCurrencyName, theBillRegisterSearch.HeadAccAccCurrencyAccCurrencyName, true));
            values.Add(new FieldValue("HeadAccAccDestAccDest", original_BillRegisterSearch.HeadAccAccDestAccDest, theBillRegisterSearch.HeadAccAccDestAccDest, true));
            values.Add(new FieldValue("HeadAccAccDestCompanyTypeDescription", original_BillRegisterSearch.HeadAccAccDestCompanyTypeDescription, theBillRegisterSearch.HeadAccAccDestCompanyTypeDescription, true));
            values.Add(new FieldValue("HeadAccAccFundAccFundName", original_BillRegisterSearch.HeadAccAccFundAccFundName, theBillRegisterSearch.HeadAccAccFundAccFundName, true));
            values.Add(new FieldValue("HeadAccAccSubTypeAccSubType", original_BillRegisterSearch.HeadAccAccSubTypeAccSubType, theBillRegisterSearch.HeadAccAccSubTypeAccSubType, true));
            values.Add(new FieldValue("HeadAccAccTypeAccType", original_BillRegisterSearch.HeadAccAccTypeAccType, theBillRegisterSearch.HeadAccAccTypeAccType, true));
            values.Add(new FieldValue("HeadAccCoaControlAccName", original_BillRegisterSearch.HeadAccCoaControlAccName, theBillRegisterSearch.HeadAccCoaControlAccName, true));
            values.Add(new FieldValue("HeadAccCoaControlAccBalTypeAccBalType", original_BillRegisterSearch.HeadAccCoaControlAccBalTypeAccBalType, theBillRegisterSearch.HeadAccCoaControlAccBalTypeAccBalType, true));
            values.Add(new FieldValue("HeadAccCoaControlAccDestAccDest", original_BillRegisterSearch.HeadAccCoaControlAccDestAccDest, theBillRegisterSearch.HeadAccCoaControlAccDestAccDest, true));
            values.Add(new FieldValue("HeadAccCoaControlAccTypeAccType", original_BillRegisterSearch.HeadAccCoaControlAccTypeAccType, theBillRegisterSearch.HeadAccCoaControlAccTypeAccType, true));
            values.Add(new FieldValue("HeadAccCoaControlCompTypeDescription", original_BillRegisterSearch.HeadAccCoaControlCompTypeDescription, theBillRegisterSearch.HeadAccCoaControlCompTypeDescription, true));
            values.Add(new FieldValue("HeadAccCoaMainAccName", original_BillRegisterSearch.HeadAccCoaMainAccName, theBillRegisterSearch.HeadAccCoaMainAccName, true));
            values.Add(new FieldValue("HeadAccCoaMainAccBalTypeAccBalType", original_BillRegisterSearch.HeadAccCoaMainAccBalTypeAccBalType, theBillRegisterSearch.HeadAccCoaMainAccBalTypeAccBalType, true));
            values.Add(new FieldValue("HeadAccCoaMainAccDestAccDest", original_BillRegisterSearch.HeadAccCoaMainAccDestAccDest, theBillRegisterSearch.HeadAccCoaMainAccDestAccDest, true));
            values.Add(new FieldValue("HeadAccCoaMainAccFundAccFundName", original_BillRegisterSearch.HeadAccCoaMainAccFundAccFundName, theBillRegisterSearch.HeadAccCoaMainAccFundAccFundName, true));
            values.Add(new FieldValue("HeadAccCoaMainAccTypeAccType", original_BillRegisterSearch.HeadAccCoaMainAccTypeAccType, theBillRegisterSearch.HeadAccCoaMainAccTypeAccType, true));
            values.Add(new FieldValue("HeadAccCoaMainCoaControlAccName", original_BillRegisterSearch.HeadAccCoaMainCoaControlAccName, theBillRegisterSearch.HeadAccCoaMainCoaControlAccName, true));
            values.Add(new FieldValue("HeadAccCoaSubAccName", original_BillRegisterSearch.HeadAccCoaSubAccName, theBillRegisterSearch.HeadAccCoaSubAccName, true));
            values.Add(new FieldValue("HeadAccCoaSubAccBalTypeAccBalType", original_BillRegisterSearch.HeadAccCoaSubAccBalTypeAccBalType, theBillRegisterSearch.HeadAccCoaSubAccBalTypeAccBalType, true));
            values.Add(new FieldValue("HeadAccCoaSubAccDestAccDest", original_BillRegisterSearch.HeadAccCoaSubAccDestAccDest, theBillRegisterSearch.HeadAccCoaSubAccDestAccDest, true));
            values.Add(new FieldValue("HeadAccCoaSubAccFundAccFundName", original_BillRegisterSearch.HeadAccCoaSubAccFundAccFundName, theBillRegisterSearch.HeadAccCoaSubAccFundAccFundName, true));
            values.Add(new FieldValue("HeadAccCoaSubAccTypeAccType", original_BillRegisterSearch.HeadAccCoaSubAccTypeAccType, theBillRegisterSearch.HeadAccCoaSubAccTypeAccType, true));
            values.Add(new FieldValue("HeadAccCoaSubCoaControlAccName", original_BillRegisterSearch.HeadAccCoaSubCoaControlAccName, theBillRegisterSearch.HeadAccCoaSubCoaControlAccName, true));
            values.Add(new FieldValue("HeadAccCoaSubCoaMainAccName", original_BillRegisterSearch.HeadAccCoaSubCoaMainAccName, theBillRegisterSearch.HeadAccCoaSubCoaMainAccName, true));
            values.Add(new FieldValue("RevAccID", original_BillRegisterSearch.RevAccID, theBillRegisterSearch.RevAccID));
            values.Add(new FieldValue("Bankname", original_BillRegisterSearch.Bankname, theBillRegisterSearch.Bankname));
            values.Add(new FieldValue("ChequeNo", original_BillRegisterSearch.ChequeNo, theBillRegisterSearch.ChequeNo));
            values.Add(new FieldValue("ChequeDT", original_BillRegisterSearch.ChequeDT, theBillRegisterSearch.ChequeDT));
            values.Add(new FieldValue("IsPost", original_BillRegisterSearch.IsPost, theBillRegisterSearch.IsPost));
            values.Add(new FieldValue("PostDate", original_BillRegisterSearch.PostDate, theBillRegisterSearch.PostDate));
            values.Add(new FieldValue("IsPartialPay", original_BillRegisterSearch.IsPartialPay, theBillRegisterSearch.IsPartialPay));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.BillRegisterSearch theBillRegisterSearch, MyCompany.Data.Objects.BillRegisterSearch original_BillRegisterSearch, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "BillRegisterSearch";
            args.View = dataView;
            args.Values = CreateFieldValues(theBillRegisterSearch, original_BillRegisterSearch);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("BillRegisterSearch", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theBillRegisterSearch);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.BillRegisterSearch theBillRegisterSearch, MyCompany.Data.Objects.BillRegisterSearch original_BillRegisterSearch)
        {
            return ExecuteAction(theBillRegisterSearch, original_BillRegisterSearch, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.BillRegisterSearch theBillRegisterSearch)
        {
            return Update(theBillRegisterSearch, SelectSingle(theBillRegisterSearch.BillRegisterID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.BillRegisterSearch theBillRegisterSearch)
        {
            return ExecuteAction(theBillRegisterSearch, new BillRegisterSearch(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.BillRegisterSearch theBillRegisterSearch)
        {
            return ExecuteAction(theBillRegisterSearch, theBillRegisterSearch, "Select", "Delete", DeleteView);
        }
    }
}
