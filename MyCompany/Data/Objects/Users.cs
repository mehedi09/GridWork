using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyCompany.Data.Objects
{
	[System.ComponentModel.DataObject(false)]
    public partial class Users
    {
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _userID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _userName;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _password;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _email;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _comment;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _passwordQuestion;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _passwordAnswer;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isApproved;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _lastActivityDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _lastLoginDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _lastPasswordChangeddate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _creationDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private bool? _isLockedOut;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _lastLockedOutDate;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _failedPasswordAttemptCount;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _failedPasswordAttemptWindowStart;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _failedPasswordAnswerAttemptCount;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private DateTime? _failedPasswordAnswerAttemptWindowStart;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private int? _accFundID;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _accFundAccFundName;
        
        public Users()
        {
        }
        
        [System.ComponentModel.DataObjectField(true, true, false)]
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
        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
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
        public string Comment
        {
            get
            {
                return _comment;
            }
            set
            {
                _comment = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PasswordQuestion
        {
            get
            {
                return _passwordQuestion;
            }
            set
            {
                _passwordQuestion = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public string PasswordAnswer
        {
            get
            {
                return _passwordAnswer;
            }
            set
            {
                _passwordAnswer = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? IsApproved
        {
            get
            {
                return _isApproved;
            }
            set
            {
                _isApproved = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? LastActivityDate
        {
            get
            {
                return _lastActivityDate;
            }
            set
            {
                _lastActivityDate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? LastLoginDate
        {
            get
            {
                return _lastLoginDate;
            }
            set
            {
                _lastLoginDate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? LastPasswordChangeddate
        {
            get
            {
                return _lastPasswordChangeddate;
            }
            set
            {
                _lastPasswordChangeddate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? CreationDate
        {
            get
            {
                return _creationDate;
            }
            set
            {
                _creationDate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public bool? IsLockedOut
        {
            get
            {
                return _isLockedOut;
            }
            set
            {
                _isLockedOut = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? LastLockedOutDate
        {
            get
            {
                return _lastLockedOutDate;
            }
            set
            {
                _lastLockedOutDate = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? FailedPasswordAttemptCount
        {
            get
            {
                return _failedPasswordAttemptCount;
            }
            set
            {
                _failedPasswordAttemptCount = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? FailedPasswordAttemptWindowStart
        {
            get
            {
                return _failedPasswordAttemptWindowStart;
            }
            set
            {
                _failedPasswordAttemptWindowStart = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public int? FailedPasswordAnswerAttemptCount
        {
            get
            {
                return _failedPasswordAnswerAttemptCount;
            }
            set
            {
                _failedPasswordAnswerAttemptCount = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, true)]
        public DateTime? FailedPasswordAnswerAttemptWindowStart
        {
            get
            {
                return _failedPasswordAnswerAttemptWindowStart;
            }
            set
            {
                _failedPasswordAnswerAttemptWindowStart = value;
            }
        }
        
        [System.ComponentModel.DataObjectField(false, false, false)]
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
        
        public static List<MyCompany.Data.Objects.Users> Select(
                    int? userID, 
                    string userName, 
                    string password, 
                    string email, 
                    string passwordQuestion, 
                    string passwordAnswer, 
                    bool? isApproved, 
                    DateTime? lastActivityDate, 
                    DateTime? lastLoginDate, 
                    DateTime? lastPasswordChangeddate, 
                    DateTime? creationDate, 
                    bool? isLockedOut, 
                    DateTime? lastLockedOutDate, 
                    int? failedPasswordAttemptCount, 
                    DateTime? failedPasswordAttemptWindowStart, 
                    int? failedPasswordAnswerAttemptCount, 
                    DateTime? failedPasswordAnswerAttemptWindowStart, 
                    int? accFundID, 
                    string accFundAccFundName)
        {
            return new UsersFactory().Select(userID, userName, password, email, passwordQuestion, passwordAnswer, isApproved, lastActivityDate, lastLoginDate, lastPasswordChangeddate, creationDate, isLockedOut, lastLockedOutDate, failedPasswordAttemptCount, failedPasswordAttemptWindowStart, failedPasswordAnswerAttemptCount, failedPasswordAnswerAttemptWindowStart, accFundID, accFundAccFundName);
        }
        
        public static List<MyCompany.Data.Objects.Users> Select(MyCompany.Data.Objects.Users qbe)
        {
            return new UsersFactory().Select(qbe);
        }
        
        public static List<MyCompany.Data.Objects.Users> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            return new UsersFactory().Select(filter, sort, dataView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.Users> Select(string filter, string sort, string dataView, params FieldValue[] parameters)
        {
            return new UsersFactory().Select(filter, sort, dataView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.Users> Select(string filter, string sort, BusinessObjectParameters parameters)
        {
            return new UsersFactory().Select(filter, sort, UsersFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.Users> Select(string filter, string sort, params FieldValue[] parameters)
        {
            return new UsersFactory().Select(filter, sort, UsersFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static List<MyCompany.Data.Objects.Users> Select(string filter, BusinessObjectParameters parameters)
        {
            return new UsersFactory().Select(filter, null, UsersFactory.SelectView, parameters);
        }
        
        public static List<MyCompany.Data.Objects.Users> Select(string filter, params FieldValue[] parameters)
        {
            return new UsersFactory().Select(filter, null, UsersFactory.SelectView, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.Users SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            return new UsersFactory().SelectSingle(filter, parameters);
        }
        
        public static MyCompany.Data.Objects.Users SelectSingle(string filter, params FieldValue[] parameters)
        {
            return new UsersFactory().SelectSingle(filter, new BusinessObjectParameters(parameters));
        }
        
        public static MyCompany.Data.Objects.Users SelectSingle(int? userID)
        {
            return new UsersFactory().SelectSingle(userID);
        }
        
        public int Insert()
        {
            return new UsersFactory().Insert(this);
        }
        
        public int Update()
        {
            return new UsersFactory().Update(this);
        }
        
        public int Delete()
        {
            return new UsersFactory().Delete(this);
        }
        
        public override string ToString()
        {
            return String.Format("UserID: {0}", this.UserID);
        }
    }
    
    [System.ComponentModel.DataObject(true)]
    public partial class UsersFactory
    {
        
        public UsersFactory()
        {
        }
        
        public static string SelectView
        {
            get
            {
                return Controller.GetSelectView("Users");
            }
        }
        
        public static string InsertView
        {
            get
            {
                return Controller.GetInsertView("Users");
            }
        }
        
        public static string UpdateView
        {
            get
            {
                return Controller.GetUpdateView("Users");
            }
        }
        
        public static string DeleteView
        {
            get
            {
                return Controller.GetDeleteView("Users");
            }
        }
        
        public static UsersFactory Create()
        {
            return new UsersFactory();
        }
        
        protected virtual PageRequest CreateRequest(
                    int? userID, 
                    string userName, 
                    string password, 
                    string email, 
                    string passwordQuestion, 
                    string passwordAnswer, 
                    bool? isApproved, 
                    DateTime? lastActivityDate, 
                    DateTime? lastLoginDate, 
                    DateTime? lastPasswordChangeddate, 
                    DateTime? creationDate, 
                    bool? isLockedOut, 
                    DateTime? lastLockedOutDate, 
                    int? failedPasswordAttemptCount, 
                    DateTime? failedPasswordAttemptWindowStart, 
                    int? failedPasswordAnswerAttemptCount, 
                    DateTime? failedPasswordAnswerAttemptWindowStart, 
                    int? accFundID, 
                    string accFundAccFundName, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex)
        {
            List<string> filter = new List<string>();
            if (userID.HasValue)
            	filter.Add(("UserID:=" + userID.Value.ToString()));
            if (!(String.IsNullOrEmpty(userName)))
            	filter.Add(("UserName:*" + userName));
            if (!(String.IsNullOrEmpty(password)))
            	filter.Add(("Password:*" + password));
            if (!(String.IsNullOrEmpty(email)))
            	filter.Add(("Email:*" + email));
            if (!(String.IsNullOrEmpty(passwordQuestion)))
            	filter.Add(("PasswordQuestion:*" + passwordQuestion));
            if (!(String.IsNullOrEmpty(passwordAnswer)))
            	filter.Add(("PasswordAnswer:*" + passwordAnswer));
            if (isApproved.HasValue)
            	filter.Add(("IsApproved:=" + isApproved.Value.ToString()));
            if (lastActivityDate.HasValue)
            	filter.Add(("LastActivityDate:=" + lastActivityDate.Value.ToString()));
            if (lastLoginDate.HasValue)
            	filter.Add(("LastLoginDate:=" + lastLoginDate.Value.ToString()));
            if (lastPasswordChangeddate.HasValue)
            	filter.Add(("LastPasswordChangeddate:=" + lastPasswordChangeddate.Value.ToString()));
            if (creationDate.HasValue)
            	filter.Add(("CreationDate:=" + creationDate.Value.ToString()));
            if (isLockedOut.HasValue)
            	filter.Add(("IsLockedOut:=" + isLockedOut.Value.ToString()));
            if (lastLockedOutDate.HasValue)
            	filter.Add(("LastLockedOutDate:=" + lastLockedOutDate.Value.ToString()));
            if (failedPasswordAttemptCount.HasValue)
            	filter.Add(("FailedPasswordAttemptCount:=" + failedPasswordAttemptCount.Value.ToString()));
            if (failedPasswordAttemptWindowStart.HasValue)
            	filter.Add(("FailedPasswordAttemptWindowStart:=" + failedPasswordAttemptWindowStart.Value.ToString()));
            if (failedPasswordAnswerAttemptCount.HasValue)
            	filter.Add(("FailedPasswordAnswerAttemptCount:=" + failedPasswordAnswerAttemptCount.Value.ToString()));
            if (failedPasswordAnswerAttemptWindowStart.HasValue)
            	filter.Add(("FailedPasswordAnswerAttemptWindowStart:=" + failedPasswordAnswerAttemptWindowStart.Value.ToString()));
            if (accFundID.HasValue)
            	filter.Add(("AccFundID:=" + accFundID.Value.ToString()));
            if (!(String.IsNullOrEmpty(accFundAccFundName)))
            	filter.Add(("AccFundAccFundName:*" + accFundAccFundName));
            return new PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray());
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)]
        public List<MyCompany.Data.Objects.Users> Select(
                    int? userID, 
                    string userName, 
                    string password, 
                    string email, 
                    string passwordQuestion, 
                    string passwordAnswer, 
                    bool? isApproved, 
                    DateTime? lastActivityDate, 
                    DateTime? lastLoginDate, 
                    DateTime? lastPasswordChangeddate, 
                    DateTime? creationDate, 
                    bool? isLockedOut, 
                    DateTime? lastLockedOutDate, 
                    int? failedPasswordAttemptCount, 
                    DateTime? failedPasswordAttemptWindowStart, 
                    int? failedPasswordAnswerAttemptCount, 
                    DateTime? failedPasswordAnswerAttemptWindowStart, 
                    int? accFundID, 
                    string accFundAccFundName, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(userID, userName, password, email, passwordQuestion, passwordAnswer, isApproved, lastActivityDate, lastLoginDate, lastPasswordChangeddate, creationDate, isLockedOut, lastLockedOutDate, failedPasswordAttemptCount, failedPasswordAttemptWindowStart, failedPasswordAnswerAttemptCount, failedPasswordAnswerAttemptWindowStart, accFundID, accFundAccFundName, sort, maximumRows, startRowIndex);
            request.RequiresMetaData = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Users", dataView, request);
            return page.ToList<MyCompany.Data.Objects.Users>();
        }
        
        public List<MyCompany.Data.Objects.Users> Select(MyCompany.Data.Objects.Users qbe)
        {
            return Select(qbe.UserID, qbe.UserName, qbe.Password, qbe.Email, qbe.PasswordQuestion, qbe.PasswordAnswer, qbe.IsApproved, qbe.LastActivityDate, qbe.LastLoginDate, qbe.LastPasswordChangeddate, qbe.CreationDate, qbe.IsLockedOut, qbe.LastLockedOutDate, qbe.FailedPasswordAttemptCount, qbe.FailedPasswordAttemptWindowStart, qbe.FailedPasswordAnswerAttemptCount, qbe.FailedPasswordAnswerAttemptWindowStart, qbe.AccFundID, qbe.AccFundAccFundName);
        }
        
        public int SelectCount(
                    int? userID, 
                    string userName, 
                    string password, 
                    string email, 
                    string passwordQuestion, 
                    string passwordAnswer, 
                    bool? isApproved, 
                    DateTime? lastActivityDate, 
                    DateTime? lastLoginDate, 
                    DateTime? lastPasswordChangeddate, 
                    DateTime? creationDate, 
                    bool? isLockedOut, 
                    DateTime? lastLockedOutDate, 
                    int? failedPasswordAttemptCount, 
                    DateTime? failedPasswordAttemptWindowStart, 
                    int? failedPasswordAnswerAttemptCount, 
                    DateTime? failedPasswordAnswerAttemptWindowStart, 
                    int? accFundID, 
                    string accFundAccFundName, 
                    string sort, 
                    int maximumRows, 
                    int startRowIndex, 
                    string dataView)
        {
            PageRequest request = CreateRequest(userID, userName, password, email, passwordQuestion, passwordAnswer, isApproved, lastActivityDate, lastLoginDate, lastPasswordChangeddate, creationDate, isLockedOut, lastLockedOutDate, failedPasswordAttemptCount, failedPasswordAttemptWindowStart, failedPasswordAnswerAttemptCount, failedPasswordAnswerAttemptWindowStart, accFundID, accFundAccFundName, sort, -1, startRowIndex);
            request.RequiresMetaData = false;
            request.RequiresRowCount = true;
            ViewPage page = ControllerFactory.CreateDataController().GetPage("Users", dataView, request);
            return page.TotalRowCount;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public List<MyCompany.Data.Objects.Users> Select(
                    int? userID, 
                    string userName, 
                    string password, 
                    string email, 
                    string passwordQuestion, 
                    string passwordAnswer, 
                    bool? isApproved, 
                    DateTime? lastActivityDate, 
                    DateTime? lastLoginDate, 
                    DateTime? lastPasswordChangeddate, 
                    DateTime? creationDate, 
                    bool? isLockedOut, 
                    DateTime? lastLockedOutDate, 
                    int? failedPasswordAttemptCount, 
                    DateTime? failedPasswordAttemptWindowStart, 
                    int? failedPasswordAnswerAttemptCount, 
                    DateTime? failedPasswordAnswerAttemptWindowStart, 
                    int? accFundID, 
                    string accFundAccFundName)
        {
            return Select(userID, userName, password, email, passwordQuestion, passwordAnswer, isApproved, lastActivityDate, lastLoginDate, lastPasswordChangeddate, creationDate, isLockedOut, lastLockedOutDate, failedPasswordAttemptCount, failedPasswordAttemptWindowStart, failedPasswordAnswerAttemptCount, failedPasswordAnswerAttemptWindowStart, accFundID, accFundAccFundName, null, Int32.MaxValue, 0, SelectView);
        }
        
        public MyCompany.Data.Objects.Users SelectSingle(int? userID)
        {
            List<MyCompany.Data.Objects.Users> list = Select(userID, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            if (list.Count == 0)
            	return null;
            return list[0];
        }
        
        public List<MyCompany.Data.Objects.Users> Select(string filter, string sort, string dataView, BusinessObjectParameters parameters)
        {
            PageRequest request = new PageRequest(0, Int32.MaxValue, sort, new string[0]);
            request.RequiresMetaData = true;
            IDataController c = ControllerFactory.CreateDataController();
            IBusinessObject bo = ((IBusinessObject)(c));
            bo.AssignFilter(filter, parameters);
            ViewPage page = c.GetPage("Users", dataView, request);
            return page.ToList<MyCompany.Data.Objects.Users>();
        }
        
        public List<MyCompany.Data.Objects.Users> SelectSingle(string filter, string sort, BusinessObjectParameters parameters)
        {
            return Select(filter, sort, SelectView, parameters);
        }
        
        public List<MyCompany.Data.Objects.Users> Select(string filter, BusinessObjectParameters parameters)
        {
            return Select(filter, null, SelectView, parameters);
        }
        
        public MyCompany.Data.Objects.Users SelectSingle(string filter, BusinessObjectParameters parameters)
        {
            List<MyCompany.Data.Objects.Users> list = Select(filter, parameters);
            if (list.Count > 0)
            	return list[0];
            return null;
        }
        
        protected virtual FieldValue[] CreateFieldValues(MyCompany.Data.Objects.Users theUsers, MyCompany.Data.Objects.Users original_Users)
        {
            List<FieldValue> values = new List<FieldValue>();
            values.Add(new FieldValue("UserID", original_Users.UserID, theUsers.UserID, true));
            values.Add(new FieldValue("UserName", original_Users.UserName, theUsers.UserName));
            values.Add(new FieldValue("Password", original_Users.Password, theUsers.Password));
            values.Add(new FieldValue("Email", original_Users.Email, theUsers.Email));
            values.Add(new FieldValue("Comment", original_Users.Comment, theUsers.Comment));
            values.Add(new FieldValue("PasswordQuestion", original_Users.PasswordQuestion, theUsers.PasswordQuestion));
            values.Add(new FieldValue("PasswordAnswer", original_Users.PasswordAnswer, theUsers.PasswordAnswer));
            values.Add(new FieldValue("IsApproved", original_Users.IsApproved, theUsers.IsApproved));
            values.Add(new FieldValue("LastActivityDate", original_Users.LastActivityDate, theUsers.LastActivityDate));
            values.Add(new FieldValue("LastLoginDate", original_Users.LastLoginDate, theUsers.LastLoginDate));
            values.Add(new FieldValue("LastPasswordChangeddate", original_Users.LastPasswordChangeddate, theUsers.LastPasswordChangeddate));
            values.Add(new FieldValue("CreationDate", original_Users.CreationDate, theUsers.CreationDate));
            values.Add(new FieldValue("IsLockedOut", original_Users.IsLockedOut, theUsers.IsLockedOut));
            values.Add(new FieldValue("LastLockedOutDate", original_Users.LastLockedOutDate, theUsers.LastLockedOutDate));
            values.Add(new FieldValue("FailedPasswordAttemptCount", original_Users.FailedPasswordAttemptCount, theUsers.FailedPasswordAttemptCount));
            values.Add(new FieldValue("FailedPasswordAttemptWindowStart", original_Users.FailedPasswordAttemptWindowStart, theUsers.FailedPasswordAttemptWindowStart));
            values.Add(new FieldValue("FailedPasswordAnswerAttemptCount", original_Users.FailedPasswordAnswerAttemptCount, theUsers.FailedPasswordAnswerAttemptCount));
            values.Add(new FieldValue("FailedPasswordAnswerAttemptWindowStart", original_Users.FailedPasswordAnswerAttemptWindowStart, theUsers.FailedPasswordAnswerAttemptWindowStart));
            values.Add(new FieldValue("AccFundID", original_Users.AccFundID, theUsers.AccFundID));
            values.Add(new FieldValue("AccFundAccFundName", original_Users.AccFundAccFundName, theUsers.AccFundAccFundName, true));
            return values.ToArray();
        }
        
        protected virtual int ExecuteAction(MyCompany.Data.Objects.Users theUsers, MyCompany.Data.Objects.Users original_Users, string lastCommandName, string commandName, string dataView)
        {
            ActionArgs args = new ActionArgs();
            args.Controller = "Users";
            args.View = dataView;
            args.Values = CreateFieldValues(theUsers, original_Users);
            args.LastCommandName = lastCommandName;
            args.CommandName = commandName;
            ActionResult result = ControllerFactory.CreateDataController().Execute("Users", dataView, args);
            result.RaiseExceptionIfErrors();
            result.AssignTo(theUsers);
            return result.RowsAffected;
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)]
        public virtual int Update(MyCompany.Data.Objects.Users theUsers, MyCompany.Data.Objects.Users original_Users)
        {
            return ExecuteAction(theUsers, original_Users, "Edit", "Update", UpdateView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public virtual int Update(MyCompany.Data.Objects.Users theUsers)
        {
            return Update(theUsers, SelectSingle(theUsers.UserID));
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public virtual int Insert(MyCompany.Data.Objects.Users theUsers)
        {
            return ExecuteAction(theUsers, new Users(), "New", "Insert", InsertView);
        }
        
        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public virtual int Delete(MyCompany.Data.Objects.Users theUsers)
        {
            return ExecuteAction(theUsers, theUsers, "Select", "Delete", DeleteView);
        }
    }
}
