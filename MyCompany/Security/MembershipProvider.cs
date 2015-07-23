using System;
using System.Configuration;
using System.Configuration.Provider;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.XPath;
using System.Web;
using System.Web.Configuration;
using System.Web.Security;
using MyCompany.Data;

namespace MyCompany.Security
{
	public partial class ApplicationMembershipProvider : ApplicationMembershipProviderBase
    {
    }
    
    public enum MembershipProviderSqlStatement
    {
        
        ChangePassword,
        
        ChangePasswordQuestionAndAnswer,
        
        CreateUser,
        
        DeleteUser,
        
        CountAllUsers,
        
        GetAllUsers,
        
        GetNumberOfUsersOnline,
        
        GetPassword,
        
        GetUser,
        
        UpdateLastUserActivity,
        
        GetUserByProviderKey,
        
        UpdateUserLockStatus,
        
        GetUserNameByEmail,
        
        ResetPassword,
        
        UpdateUser,
        
        UpdateLastLoginDate,
        
        UpdateFailedPasswordAttempt,
        
        UpdateFailedPasswordAnswerAttempt,
        
        LockUser,
        
        CountUsersByName,
        
        FindUsersByName,
        
        CountUsersByEmail,
        
        FindUsersByEmail,
    }
    
    public class ApplicationMembershipProviderBase : MembershipProvider
    {
        
        protected static SortedDictionary<MembershipProviderSqlStatement, string> Statements = new SortedDictionary<MembershipProviderSqlStatement, string>();
        
        private int _newPasswordLength = 8;
        
        private string _validationKey;
        
        private ConnectionStringSettings _connectionStringSettings;
        
        private bool _writeExceptionsToEventLog;
        
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        private string _applicationName;
        
        private bool _enablePasswordReset;
        
        private bool _enablePasswordRetrieval;
        
        private bool _requiresQuestionAndAnswer;
        
        private bool _requiresUniqueEmail;
        
        private int _maxInvalidPasswordAttempts;
        
        private int _passwordAttemptWindow;
        
        private MembershipPasswordFormat _passwordFormat;
        
        private int _minRequiredNonAlphanumericCharacters;
        
        private int _minRequiredPasswordLength;
        
        private string _passwordStrengthRegularExpression;
        
        static ApplicationMembershipProviderBase()
        {
            Statements[MembershipProviderSqlStatement.ChangePassword] = "update Users set Password = @Password, LastPasswordChangedDate = @LastPasswordCha" +
                "ngedDate where UserName = @UserName";
            Statements[MembershipProviderSqlStatement.ChangePasswordQuestionAndAnswer] = "update Users set PasswordQuestion = @PasswordQuestion, PasswordAnswer = @Password" +
                "Answer where UserName = @UserName";
            Statements[MembershipProviderSqlStatement.CreateUser] = @"
insert into Users
(
   UserName
  ,Password
  ,Email
  ,PasswordQuestion
  ,PasswordAnswer
  ,IsApproved
  ,Comment
  ,CreationDate
  ,LastPasswordChangedDate
  ,LastActivityDate
  ,LastLoginDate
  ,IsLockedOut
  ,LastLockedOutDate
  ,FailedPasswordAttemptCount
  ,FailedPasswordAttemptWindowStart
  ,FailedPasswordAnswerAttemptCount
  ,FailedPasswordAnswerAttemptWindowStart
)
values(
   @UserName
  ,@Password
  ,@Email
  ,@PasswordQuestion
  ,@PasswordAnswer
  ,@IsApproved
  ,@Comments
  ,@CreationDate
  ,@LastPasswordChangedDate
  ,@LastActivityDate
  ,@LastLoginDate
  ,@IsLockedOut
  ,@LastLockedOutDate
  ,@FailedPwdAttemptCount
  ,@FailedPwdAttemptWindowStart
  ,@FailedPwdAnsAttemptCount
  ,@FailedPwdAnsAttemptWindowStart
)";
            Statements[MembershipProviderSqlStatement.DeleteUser] = "delete from Users where UserName = @UserName";
            Statements[MembershipProviderSqlStatement.CountAllUsers] = "select count(*) from Users";
            Statements[MembershipProviderSqlStatement.GetAllUsers] = @"
select 
   UserID UserID
  ,UserName UserName
  ,Email Email
  ,PasswordQuestion PasswordQuestion
  ,Comment Comments
  ,IsApproved IsApproved
  ,IsLockedOut IsLockedOut
  ,CreationDate CreationDate
  ,LastLoginDate LastLoginDate
  ,LastActivityDate LastActivityDate
  ,LastPasswordChangedDate LastPasswordChangedDate
  ,LastLockedOutDate LastLockedOutDate
from Users 
order by UserName asc";
            Statements[MembershipProviderSqlStatement.GetNumberOfUsersOnline] = "select count(*) from Users where LastActivityDate >= @CompareDate";
            Statements[MembershipProviderSqlStatement.GetPassword] = @"select Password Password, PasswordAnswer PasswordAnswer, IsLockedOut IsLockedOut, IsApproved IsApproved, IsLockedOut IsLockedOut, FailedPasswordAttemptWindowStart FailedPwdAttemptWindowStart, FailedPasswordAnswerAttemptWindowStart FailedPwdAnsAttemptWindowStart from Users where UserName = @UserName";
            Statements[MembershipProviderSqlStatement.GetUser] = @"
select 
   UserID UserID
  ,UserName UserName
  ,Email Email
  ,PasswordQuestion PasswordQuestion
  ,Comment Comments
  ,IsApproved IsApproved
  ,IsLockedOut IsLockedOut
  ,CreationDate CreationDate
  ,LastLoginDate LastLoginDate
  ,LastActivityDate LastActivityDate
  ,LastPasswordChangedDate LastPasswordChangedDate
  ,LastLockedOutDate LastLockedOutDate
  ,FailedPasswordAttemptCount FailedPwdAttemptCount
  ,FailedPasswordAttemptWindowStart FailedPwdAttemptWindowStart
  ,FailedPasswordAnswerAttemptCount FailedPwdAnsAttemptCount
  ,FailedPasswordAnswerAttemptWindowStart FailedPwdAnsAttemptWindowStart
from Users 
where UserName = @UserName";
            Statements[MembershipProviderSqlStatement.UpdateLastUserActivity] = "update Users set LastActivityDate = @LastActivityDate where UserName = @UserName";
            Statements[MembershipProviderSqlStatement.GetUserByProviderKey] = @"
select 
   UserID UserID
  ,UserName Username
  ,Email Email
  ,PasswordQuestion PasswordQuestion
  ,Comment Comments
  ,IsApproved IsApproved
  ,IsLockedOut IsLockedOut
  ,CreationDate CreationDate
  ,LastLoginDate LastLoginDate
  ,LastActivityDate LastActivityDate
  ,LastPasswordChangedDate LastPasswordChangedDate
  ,LastLockedOutDate LastLockedOutDate
from Users 
where UserID = @UserID";
            Statements[MembershipProviderSqlStatement.UpdateUserLockStatus] = "update Users set IsLockedOut = @IsLockedOut, LastLockedOutDate = @LastLockedOutDa" +
                "te where UserName = @UserName";
            Statements[MembershipProviderSqlStatement.GetUserNameByEmail] = "select UserName Username from Users where Email = @Email";
            Statements[MembershipProviderSqlStatement.ResetPassword] = "update Users set Password = @Password, LastPasswordChangedDate = @LastPasswordCha" +
                "ngedDate where UserName = @UserName and IsLockedOut = @IsLockedOut";
            Statements[MembershipProviderSqlStatement.UpdateUser] = "update Users set Email = @Email, Comment = @Comments, IsApproved = @IsApproved wh" +
                "ere UserName = @UserName";
            Statements[MembershipProviderSqlStatement.UpdateLastLoginDate] = "update Users set LastLoginDate = @LastLoginDate, IsLockedOut = @IsLockedOut where" +
                " UserName = @UserName";
            Statements[MembershipProviderSqlStatement.UpdateFailedPasswordAttempt] = "update Users set FailedPasswordAttemptCount = @FailedPwdAttemptCount, FailedPassw" +
                "ordAttemptWindowStart = @FailedPwdAttemptWindowStart where UserName = @UserName";
            Statements[MembershipProviderSqlStatement.UpdateFailedPasswordAnswerAttempt] = "update Users set FailedPasswordAnswerAttemptCount = @FailedPwdAnsAttemptCount whe" +
                "re UserName = @UserName";
            Statements[MembershipProviderSqlStatement.CountUsersByName] = "select count(*) from Users where UserName like @UserName";
            Statements[MembershipProviderSqlStatement.FindUsersByName] = @"
select 
   UserID UserID
  ,UserName Username
  ,Email Email
  ,PasswordQuestion PasswordQuestion
  ,Comment Comments
  ,IsApproved IsApproved
  ,IsLockedOut IsLockedOut
  ,CreationDate CreationDate
  ,LastLoginDate LastLoginDate
  ,LastActivityDate LastActivityDate
  ,LastPasswordChangedDate LastPasswordChangedDate
  ,LastLockedOutDate LastLockedOutDate
from Users 
where UserName like @UserName
order by UserName asc";
            Statements[MembershipProviderSqlStatement.CountUsersByEmail] = "select count(*) from Users where Email like @Email";
            Statements[MembershipProviderSqlStatement.FindUsersByEmail] = @"
select 
   UserID UserID
  ,UserName Username
  ,Email Email
  ,PasswordQuestion PasswordQuestion
  ,Comment Comments
  ,IsApproved IsApproved
  ,IsLockedOut IsLockedOut
  ,CreationDate CreationDate
  ,LastLoginDate LastLoginDate
  ,LastActivityDate LastActivityDate
  ,LastPasswordChangedDate LastPasswordChangedDate
  ,LastLockedOutDate LastLockedOutDate
from Users 
where Email like @Email
order by UserName asc";
        }
        
        public virtual ConnectionStringSettings ConnectionStringSettings
        {
            get
            {
                return _connectionStringSettings;
            }
        }
        
        public bool WriteExceptionsToEventLog
        {
            get
            {
                return _writeExceptionsToEventLog;
            }
        }
        
        public override string ApplicationName
        {
            get
            {
                return this._applicationName;
            }
            set
            {
                this._applicationName = value;
            }
        }
        
        public override bool EnablePasswordReset
        {
            get
            {
                return _enablePasswordReset;
            }
        }
        
        public override bool EnablePasswordRetrieval
        {
            get
            {
                return _enablePasswordRetrieval;
            }
        }
        
        public override bool RequiresQuestionAndAnswer
        {
            get
            {
                return _requiresQuestionAndAnswer;
            }
        }
        
        public override bool RequiresUniqueEmail
        {
            get
            {
                return _requiresUniqueEmail;
            }
        }
        
        public override int MaxInvalidPasswordAttempts
        {
            get
            {
                return _maxInvalidPasswordAttempts;
            }
        }
        
        public override int PasswordAttemptWindow
        {
            get
            {
                return _passwordAttemptWindow;
            }
        }
        
        public override MembershipPasswordFormat PasswordFormat
        {
            get
            {
                return _passwordFormat;
            }
        }
        
        public override int MinRequiredNonAlphanumericCharacters
        {
            get
            {
                return _minRequiredNonAlphanumericCharacters;
            }
        }
        
        public override int MinRequiredPasswordLength
        {
            get
            {
                return _minRequiredPasswordLength;
            }
        }
        
        public override string PasswordStrengthRegularExpression
        {
            get
            {
                return _passwordStrengthRegularExpression;
            }
        }
        
        public virtual MembershipPasswordFormat DefaultPasswordFormat
        {
            get
            {
                return MembershipPasswordFormat.Hashed;
            }
        }
        
        protected virtual SqlStatement CreateSqlStatement(MembershipProviderSqlStatement command)
        {
            SqlText sql = new SqlText(Statements[command], ConnectionStringSettings.Name);
            sql.Command.CommandText = sql.Command.CommandText.Replace("@", sql.ParameterMarker);
            if (sql.Command.CommandText.Contains((sql.ParameterMarker + "ApplicationName")))
            	sql.AssignParameter("ApplicationName", ApplicationName);
            sql.Name = ("MyCompany Application Membership Provider - " + command.ToString());
            sql.WriteExceptionsToEventLog = WriteExceptionsToEventLog;
            return sql;
        }
        
        private string GetConfigValue(string configValue, string defaultValue)
        {
            if (String.IsNullOrEmpty(configValue))
            	return defaultValue;
            return configValue;
        }
        
        public override void Initialize(string name, NameValueCollection config)
        {
            if (config == null)
            	throw new ArgumentNullException("config");
            if (String.IsNullOrEmpty(name))
            	name = "MyCompanyApplicationMembershipProvider";
            if (String.IsNullOrEmpty(config["description"]))
            {
                config.Remove("description");
                config.Add("description", "MyCompany application membership provider");
            }
            base.Initialize(name, config);
            _applicationName = config["applicationName"];
            if (String.IsNullOrEmpty(_applicationName))
            	_applicationName = System.Web.Hosting.HostingEnvironment.ApplicationVirtualPath;
            _maxInvalidPasswordAttempts = Convert.ToInt32(GetConfigValue(config["maxInvalidPasswordAttempts"], "5"));
            _passwordAttemptWindow = Convert.ToInt32(GetConfigValue(config["passwordAttemptWindow"], "10"));
            _minRequiredNonAlphanumericCharacters = Convert.ToInt32(GetConfigValue(config["minRequiredNonAlphanumericCharacters"], "1"));
            _minRequiredPasswordLength = Convert.ToInt32(GetConfigValue(config["minRequiredPasswordLength"], "7"));
            _passwordStrengthRegularExpression = Convert.ToString(GetConfigValue(config["passwordStrengthRegularExpression"], String.Empty));
            _enablePasswordReset = Convert.ToBoolean(GetConfigValue(config["enablePasswordReset"], "true"));
            _enablePasswordRetrieval = Convert.ToBoolean(GetConfigValue(config["enablePasswordRetrieval"], "true"));
            _requiresQuestionAndAnswer = Convert.ToBoolean(GetConfigValue(config["requiresQuestionAndAnswer"], "false"));
            _requiresUniqueEmail = Convert.ToBoolean(GetConfigValue(config["requiresUniqueEmail"], "true"));
            _writeExceptionsToEventLog = Convert.ToBoolean(GetConfigValue(config["writeExceptionsToEventLog"], "false"));
            string pwdFormat = config["passwordFormat"];
            if (String.IsNullOrEmpty(pwdFormat))
            	pwdFormat = DefaultPasswordFormat.ToString();
            if (pwdFormat == "Hashed")
            	_passwordFormat = MembershipPasswordFormat.Hashed;
            else
            	if (pwdFormat == "Encrypted")
                	_passwordFormat = MembershipPasswordFormat.Encrypted;
                else
                	if (pwdFormat == "Clear")
                    	_passwordFormat = MembershipPasswordFormat.Clear;
                    else
                    	throw new ProviderException("Password format is not supported.");
            _connectionStringSettings = ConfigurationManager.ConnectionStrings[config["connectionStringName"]];
            if ((_connectionStringSettings == null) || String.IsNullOrEmpty(_connectionStringSettings.ConnectionString))
            	throw new ProviderException("Connection string cannot be blank.");
            _validationKey = ConfigurationManager.AppSettings["MembershipProviderValidationKey"];
            if (String.IsNullOrEmpty(_validationKey) || _validationKey.Contains("AutoGenerate"))
            	_validationKey = "93E9A93A23D20E15894D6AF003F0976C8778D9371B26ED2A2D392E84EC93A53F1CFAA7EC06BC01EAE" +
                    "E6208BA3BEADD595AF8A4567D798437574BDE09C71F954C";
        }
        
        public override bool ChangePassword(string username, string oldPwd, string newPwd)
        {
            if (!(ValidateUser(username, oldPwd)))
            	return false;
            ValidatePasswordEventArgs args = new ValidatePasswordEventArgs(username, newPwd, false);
            OnValidatingPassword(args);
            if (args.Cancel)
            	if (args.FailureInformation != null)
                	throw args.FailureInformation;
                else
                	throw new MembershipPasswordException("Change of password canceled due to new password validation failure.");
            using (SqlStatement sql = CreateSqlStatement(MembershipProviderSqlStatement.ChangePassword))
            {
                sql.AssignParameter("Password", EncodePassword(newPwd));
                sql.AssignParameter("LastPasswordChangedDate", DateTime.Now);
                sql.AssignParameter("UserName", username);
                return (sql.ExecuteNonQuery() == 1);
            }
        }
        
        public override bool ChangePasswordQuestionAndAnswer(string username, string password, string newPwdQuestion, string newPwdAnswer)
        {
            if (!(ValidateUser(username, password)))
            	return false;
            using (SqlStatement sql = CreateSqlStatement(MembershipProviderSqlStatement.ChangePasswordQuestionAndAnswer))
            {
                sql.AssignParameter("PasswordQuestion", newPwdQuestion);
                sql.AssignParameter("PasswordAnswer", EncodePassword(newPwdAnswer));
                sql.AssignParameter("UserName", username);
                return (sql.ExecuteNonQuery() == 1);
            }
        }
        
        public static string EncodeUserPassword(string password)
        {
            return ((ApplicationMembershipProviderBase)(Membership.Provider)).EncodePassword(password);
        }
        
        public static void ValidateUserPassword(string username, string password)
        {
            ValidateUserPassword(username, password, true);
        }
        
        public static void ValidateUserPassword(string username, string password, bool isNewUser)
        {
            ValidatePasswordEventArgs args = new ValidatePasswordEventArgs(username, password, isNewUser);
            ((ApplicationMembershipProviderBase)(Membership.Provider)).OnValidatingPassword(args);
            if (args.Cancel)
            {
                if (args.FailureInformation != null)
                	throw args.FailureInformation;
            }
        }
        
        public override MembershipUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer, bool isApproved, object providerUserKey, out MembershipCreateStatus status)
        {
            ValidatePasswordEventArgs args = new ValidatePasswordEventArgs(username, password, true);
            OnValidatingPassword(args);
            if (args.Cancel)
            {
                status = MembershipCreateStatus.InvalidPassword;
                return null;
            }
            if (RequiresUniqueEmail && !(String.IsNullOrEmpty(GetUserNameByEmail(email))))
            {
                status = MembershipCreateStatus.DuplicateEmail;
                return null;
            }
            if (GetUser(username, false) != null)
            	status = MembershipCreateStatus.DuplicateUserName;
            else
            {
                DateTime creationDate = DateTime.Now;
                using (SqlStatement sql = CreateSqlStatement(MembershipProviderSqlStatement.CreateUser))
                {
                    sql.AssignParameter("UserName", username);
                    sql.AssignParameter("Password", EncodePassword(password));
                    sql.AssignParameter("Email", email);
                    sql.AssignParameter("PasswordQuestion", passwordQuestion);
                    sql.AssignParameter("PasswordAnswer", EncodePassword(passwordAnswer));
                    sql.AssignParameter("IsApproved", isApproved);
                    sql.AssignParameter("Comments", String.Empty);
                    sql.AssignParameter("CreationDate", creationDate);
                    sql.AssignParameter("LastPasswordChangedDate", creationDate);
                    sql.AssignParameter("LastActivityDate", creationDate);
                    sql.AssignParameter("LastLoginDate", creationDate);
                    sql.AssignParameter("IsLockedOut", false);
                    sql.AssignParameter("LastLockedOutDate", creationDate);
                    sql.AssignParameter("FailedPwdAttemptCount", 0);
                    sql.AssignParameter("FailedPwdAttemptWindowStart", creationDate);
                    sql.AssignParameter("FailedPwdAnsAttemptCount", 0);
                    sql.AssignParameter("FailedPwdAnsAttemptWindowStart", creationDate);
                    if (sql.ExecuteNonQuery() > 0)
                    {
                        status = MembershipCreateStatus.Success;
                        return GetUser(username, false);
                    }
                    else
                    	status = MembershipCreateStatus.UserRejected;
                }
            }
            return null;
        }
        
        public override bool DeleteUser(string username, bool deleteAllRelatedData)
        {
            using (SqlStatement sql = CreateSqlStatement(MembershipProviderSqlStatement.DeleteUser))
            {
                sql.AssignParameter("UserName", username);
                return (sql.ExecuteNonQuery() > 0);
            }
        }
        
        public override MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords)
        {
            totalRecords = 0;
            MembershipUserCollection users = new MembershipUserCollection();
            using (SqlStatement sql = CreateSqlStatement(MembershipProviderSqlStatement.CountAllUsers))
            {
                totalRecords = Convert.ToInt32(sql.ExecuteScalar());
                if (totalRecords <= 0)
                	return users;
            }
            using (SqlStatement sql = CreateSqlStatement(MembershipProviderSqlStatement.GetAllUsers))
            {
                int counter = 0;
                int startIndex = (pageSize * pageIndex);
                int endIndex = ((startIndex + pageSize) 
                            - 1);
                while (sql.Read())
                {
                    if (counter >= startIndex)
                    	users.Add(GetUser(sql));
                    if (counter >= endIndex)
                    	break;
                    counter++;
                }
            }
            return users;
        }
        
        public override int GetNumberOfUsersOnline()
        {
            TimeSpan onlineSpan = new TimeSpan(0, Membership.UserIsOnlineTimeWindow, 0);
            DateTime compareDate = DateTime.Now.Subtract(onlineSpan);
            using (SqlStatement sql = CreateSqlStatement(MembershipProviderSqlStatement.GetNumberOfUsersOnline))
            {
                sql.AssignParameter("CompareDate", compareDate);
                return Convert.ToInt32(sql.ExecuteScalar());
            }
        }
        
        public override string GetPassword(string username, string answer)
        {
            if (!(EnablePasswordRetrieval))
            	throw new ProviderException("Password retrieval is not enabled.");
            if (PasswordFormat == MembershipPasswordFormat.Hashed)
            	throw new ProviderException("Cannot retrieve hashed passwords.");
            string password = String.Empty;
            string passwordAnswer = String.Empty;
            using (SqlStatement sql = CreateSqlStatement(MembershipProviderSqlStatement.GetPassword))
            {
                sql.AssignParameter("UserName", username);
                if (sql.Read())
                {
                    if (Convert.ToBoolean(sql["IsLockedOut"]))
                    	throw new MembershipPasswordException("User is locked out.");
                    password = Convert.ToString(sql["Password"]);
                    passwordAnswer = Convert.ToString(sql["PasswordAnswer"]);
                }
                else
                	throw new MembershipPasswordException("User name is not found.");
            }
            if (RequiresQuestionAndAnswer && !(CheckPassword(answer, passwordAnswer)))
            {
                UpdateFailureCount(username, "PasswordAnswer");
                throw new MembershipPasswordException("Incorrect password answer.");
            }
            if (PasswordFormat == MembershipPasswordFormat.Encrypted)
            	password = DecodePassword(password);
            return password;
        }
        
        public override MembershipUser GetUser(string username, bool userIsOnline)
        {
            MembershipUser u = null;
            using (SqlStatement sql = CreateSqlStatement(MembershipProviderSqlStatement.GetUser))
            {
                sql.AssignParameter("UserName", username);
                if (sql.Read())
                	u = GetUser(sql);
            }
            if (userIsOnline && (u != null))
            	using (SqlStatement sql = CreateSqlStatement(MembershipProviderSqlStatement.UpdateLastUserActivity))
                {
                    sql.AssignParameter("LastActivityDate", DateTime.Now);
                    sql.AssignParameter("UserName", username);
                    sql.ExecuteNonQuery();
                }
            return u;
        }
        
        public override MembershipUser GetUser(object providerUserKey, bool userIsOnline)
        {
            MembershipUser u = null;
            using (SqlStatement sql = CreateSqlStatement(MembershipProviderSqlStatement.GetUserByProviderKey))
            {
                sql.AssignParameter("UserID", providerUserKey);
                if (sql.Read())
                	u = GetUser(sql);
            }
            if (userIsOnline && (u != null))
            	using (SqlStatement sql = CreateSqlStatement(MembershipProviderSqlStatement.UpdateLastUserActivity))
                {
                    sql.AssignParameter("LastActivityDate", DateTime.Now);
                    sql.AssignParameter("UserName", u.UserName);
                    sql.ExecuteNonQuery();
                }
            return u;
        }
        
        private MembershipUser GetUser(SqlStatement sql)
        {
            object providerUserKey = sql["UserID"];
            string username = Convert.ToString(sql["UserName"]);
            string email = Convert.ToString(sql["Email"]);
            string passwordQuestion = Convert.ToString(sql["PasswordQuestion"]);
            string comment = Convert.ToString(sql["Comments"]);
            bool isApproved = Convert.ToBoolean(sql["IsApproved"]);
            bool isLockedOut = Convert.ToBoolean(sql["IsLockedOut"]);
            DateTime creationDate = Convert.ToDateTime(sql["CreationDate"]);
            DateTime lastLoginDate = Convert.ToDateTime(sql["LastLoginDate"]);
            DateTime lastActivityDate = Convert.ToDateTime(sql["LastActivityDate"]);
            DateTime lastPasswordChangedDate = Convert.ToDateTime(sql["LastPasswordChangedDate"]);
            DateTime lastLockedOutDate = Convert.ToDateTime(sql["LastLockedOutDate"]);
            return new MembershipUser(this.Name, username, providerUserKey, email, passwordQuestion, comment, isApproved, isLockedOut, creationDate, lastLoginDate, lastActivityDate, lastPasswordChangedDate, lastLockedOutDate);
        }
        
        public override bool UnlockUser(string username)
        {
            using (SqlStatement sql = CreateSqlStatement(MembershipProviderSqlStatement.UpdateUserLockStatus))
            {
                sql.AssignParameter("IsLockedOut", false);
                sql.AssignParameter("LastLockedOutDate", DateTime.Now);
                sql.AssignParameter("UserName", username);
                return (sql.ExecuteNonQuery() > 0);
            }
        }
        
        public override string GetUserNameByEmail(string email)
        {
            using (SqlStatement sql = CreateSqlStatement(MembershipProviderSqlStatement.GetUserNameByEmail))
            {
                sql.AssignParameter("Email", email);
                return Convert.ToString(sql.ExecuteScalar());
            }
        }
        
        public override string ResetPassword(string username, string answer)
        {
            if (!(EnablePasswordReset))
            	throw new NotSupportedException("Password reset is not enabled.");
            if (String.IsNullOrEmpty(answer) && RequiresQuestionAndAnswer)
            {
                UpdateFailureCount(username, "PasswordAnswer");
                throw new ProviderException("Password answer required for password reset.");
            }
            string newPassword = Membership.GeneratePassword(this._newPasswordLength, MinRequiredNonAlphanumericCharacters);
            ValidatePasswordEventArgs args = new ValidatePasswordEventArgs(username, newPassword, false);
            OnValidatingPassword(args);
            if (args.Cancel)
            	if (args.FailureInformation != null)
                	throw args.FailureInformation;
                else
                	throw new MembershipPasswordException("Reset password canceled due to password validation failure.");
            string passwordAnswer = String.Empty;
            using (SqlStatement sql = CreateSqlStatement(MembershipProviderSqlStatement.GetPassword))
            {
                sql.AssignParameter("UserName", username);
                if (sql.Read())
                {
                    if (Convert.ToBoolean(sql["IsLockedOut"]))
                    	throw new MembershipPasswordException("User is locked out.");
                    if (((DateTime)(sql["FailedPwdAnsAttemptWindowStart"])).AddMinutes(PasswordAttemptWindow) > DateTime.Now)
                    	throw new MembershipPasswordException("Password answer attempt is not yet allowed.");
                    passwordAnswer = Convert.ToString(sql["PasswordAnswer"]);
                }
                else
                	throw new MembershipPasswordException("User is not found.");
            }
            if (RequiresQuestionAndAnswer && !(CheckPassword(answer, passwordAnswer)))
            {
                UpdateFailureCount(username, "PasswordAnswer");
                throw new MembershipPasswordException("Incorrect password answer.");
            }
            using (SqlStatement sql = CreateSqlStatement(MembershipProviderSqlStatement.ResetPassword))
            {
                sql.AssignParameter("Password", EncodePassword(newPassword));
                sql.AssignParameter("LastPasswordChangedDate", DateTime.Now);
                sql.AssignParameter("UserName", username);
                sql.AssignParameter("IsLockedOut", false);
                if (sql.ExecuteNonQuery() > 0)
                	return newPassword;
                else
                	throw new MembershipPasswordException("User is not found or locked out. Password has not been reset.");
            }
        }
        
        public override void UpdateUser(MembershipUser user)
        {
            using (SqlStatement sql = CreateSqlStatement(MembershipProviderSqlStatement.UpdateUser))
            {
                sql.AssignParameter("Email", user.Email);
                sql.AssignParameter("Comments", user.Comment);
                sql.AssignParameter("IsApproved", user.IsApproved);
                sql.AssignParameter("UserName", user.UserName);
                sql.ExecuteNonQuery();
            }
        }
        
        public override bool ValidateUser(string username, string password)
        {
            bool isValid = false;
            string pwd = null;
            bool isApproved = true;
            username = username.Trim();
            password = password.Trim();
            using (SqlStatement sql = CreateSqlStatement(MembershipProviderSqlStatement.GetPassword))
            {
                sql.AssignParameter("UserName", username);
                if (sql.Read())
                {
                    if (Convert.ToBoolean(sql["IsLockedOut"]))
                    {
                        if (((DateTime)(sql["FailedPwdAttemptWindowStart"])).AddMinutes(PasswordAttemptWindow) > DateTime.Now)
                        	return false;
                    }
                    pwd = Convert.ToString(sql["Password"]);
                    isApproved = Convert.ToBoolean(sql["IsApproved"]);
                }
                else
                	return false;
            }
            if (CheckPassword(password, pwd))
            {
                if (isApproved)
                {
                    isValid = true;
                    using (SqlStatement sql = CreateSqlStatement(MembershipProviderSqlStatement.UpdateLastLoginDate))
                    {
                        sql.AssignParameter("LastLoginDate", DateTime.Now);
                        sql.AssignParameter("IsLockedOut", false);
                        sql.AssignParameter("UserName", username);
                        sql.ExecuteNonQuery();
                    }
                }
            }
            else
            	UpdateFailureCount(username, "Password");
            return isValid;
        }
        
        private void UpdateFailureCount(string username, string failureType)
        {
            int failureCount = 0;
            DateTime windowStart = DateTime.Now;
            using (SqlStatement sql = CreateSqlStatement(MembershipProviderSqlStatement.GetUser))
            {
                sql.AssignParameter("UserName", username);
                if (!(sql.Read()))
                	return;
                if (failureType == "Password")
                {
                    failureCount = Convert.ToInt32(sql["FailedPwdAttemptCount"]);
                    if (!(DBNull.Value.Equals(sql["FailedPwdAttemptWindowStart"])))
                    	windowStart = Convert.ToDateTime(sql["FailedPwdAttemptWindowStart"]);
                }
                if (failureType == "PasswordAnswer")
                {
                    failureCount = Convert.ToInt32(sql["FailedPwdAnsAttemptCount"]);
                    if (!(DBNull.Value.Equals(sql["FailedPwdAnsAttemptWindowStart"])))
                    	windowStart = Convert.ToDateTime(sql["FailedPwdAnsAttemptWindowStart"]);
                }
            }
            DateTime windowEnd = windowStart.AddMinutes(PasswordAttemptWindow);
            if ((failureCount == 0) || (DateTime.Now > windowEnd))
            {
                if (failureType == "Password")
                	using (SqlStatement sql = CreateSqlStatement(MembershipProviderSqlStatement.UpdateFailedPasswordAttempt))
                    {
                        sql.AssignParameter("FailedPwdAttemptCount", 1);
                        sql.AssignParameter("FailedPwdAttemptWindowStart", DateTime.Now);
                        sql.AssignParameter("UserName", username);
                        if (sql.ExecuteNonQuery() == 0)
                        	throw new ProviderException("Unable to update password failure count and window start.");
                    }
                if (failureType == "PasswordAnswer")
                	using (SqlStatement sql = CreateSqlStatement(MembershipProviderSqlStatement.UpdateFailedPasswordAnswerAttempt))
                    {
                        sql.AssignParameter("FailedPwdAnsAttemptCount", 1);
                        sql.AssignParameter("FailedPwdAnsAttemptWindowStart", DateTime.Now);
                        sql.AssignParameter("UserName", username);
                        if (sql.ExecuteNonQuery() == 0)
                        	throw new ProviderException("Unable to update password answer failure count and window start.");
                    }
            }
            else
            {
                failureCount++;
                if (failureCount > MaxInvalidPasswordAttempts)
                	using (SqlStatement sql = CreateSqlStatement(MembershipProviderSqlStatement.UpdateUserLockStatus))
                    {
                        sql.AssignParameter("IsLockedOut", true);
                        sql.AssignParameter("LastLockedOutDate", DateTime.Now);
                        sql.AssignParameter("UserName", username);
                        if (sql.ExecuteNonQuery() < 1)
                        	throw new ProviderException("Unable to lock out user.");
                    }
                else
                {
                    if (failureType == "Password")
                    	using (SqlStatement sql = CreateSqlStatement(MembershipProviderSqlStatement.UpdateFailedPasswordAttempt))
                        {
                            sql.AssignParameter("FailedPwdAttemptCount", failureCount);
                            sql.AssignParameter("FailedPwdAttemptWindowStart", windowStart);
                            sql.AssignParameter("UserName", username);
                            if (sql.ExecuteNonQuery() == 0)
                            	throw new ProviderException("Unable to update password failure count and window start.");
                        }
                    if (failureType == "PasswordAnswer")
                    	using (SqlStatement sql = CreateSqlStatement(MembershipProviderSqlStatement.UpdateFailedPasswordAnswerAttempt))
                        {
                            sql.AssignParameter("FailedPwdAnsAttemptCount", failureCount);
                            sql.AssignParameter("FailedPwdAnsAttemptWindowStart", windowStart);
                            sql.AssignParameter("UserName", username);
                            if (sql.ExecuteNonQuery() == 0)
                            	throw new ProviderException("Unable to update password answer failure count and window start.");
                        }
                }
            }
        }
        
        private bool CheckPassword(string password, string currentPassword)
        {
            string pass1 = password;
            string pass2 = currentPassword;
            if (PasswordFormat == MembershipPasswordFormat.Encrypted)
            	pass2 = DecodePassword(currentPassword);
            else
            	if (PasswordFormat == MembershipPasswordFormat.Hashed)
                	pass1 = EncodePassword(password);
            return (pass1 == pass2);
        }
        
        public virtual string EncodePassword(string password)
        {
            string encodedPassword = password;
            if (PasswordFormat == MembershipPasswordFormat.Encrypted)
            	encodedPassword = Convert.ToBase64String(EncryptPassword(Encoding.Unicode.GetBytes(password)));
            else
            	if (PasswordFormat == MembershipPasswordFormat.Hashed)
                {
                    HMACSHA1 hash = new HMACSHA1();
                    hash.Key = HexToByte(_validationKey);
                    encodedPassword = Convert.ToBase64String(hash.ComputeHash(Encoding.Unicode.GetBytes(password)));
                }
            return encodedPassword;
        }
        
        public virtual string DecodePassword(string encodedPassword)
        {
            string password = encodedPassword;
            if (PasswordFormat == MembershipPasswordFormat.Encrypted)
            	password = Encoding.Unicode.GetString(DecryptPassword(Convert.FromBase64String(encodedPassword)));
            else
            	if (PasswordFormat == MembershipPasswordFormat.Hashed)
                	throw new ProviderException("Cannot decode a hashed password.");
            return password;
        }
        
        public static byte[] HexToByte(string hexString)
        {
            byte[] returnBytes = new byte[(hexString.Length / 2)];
            for (int i = 0; (i < returnBytes.Length); i++)
            	returnBytes[i] = Convert.ToByte(hexString.Substring((i * 2), 2), 16);
            return returnBytes;
        }
        
        public override MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSize, out int totalRecords)
        {
            MembershipUserCollection users = new MembershipUserCollection();
            using (SqlStatement sql = CreateSqlStatement(MembershipProviderSqlStatement.CountUsersByName))
            {
                sql.AssignParameter("UserName", usernameToMatch);
                totalRecords = Convert.ToInt32(sql.ExecuteScalar());
            }
            if (totalRecords > 0)
            {
                int counter = 0;
                int startIndex = (pageSize * pageIndex);
                int endIndex = ((startIndex + pageSize) 
                            - 1);
                using (SqlStatement sql = CreateSqlStatement(MembershipProviderSqlStatement.FindUsersByName))
                {
                    sql.AssignParameter("UserName", usernameToMatch);
                    while (sql.Read())
                    {
                        if (counter >= startIndex)
                        	users.Add(GetUser(sql));
                        if (counter >= endIndex)
                        	break;
                        counter++;
                    }
                }
            }
            return users;
        }
        
        public override MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize, out int totalRecords)
        {
            MembershipUserCollection users = new MembershipUserCollection();
            using (SqlStatement sql = CreateSqlStatement(MembershipProviderSqlStatement.CountUsersByEmail))
            {
                sql.AssignParameter("UserName", emailToMatch);
                totalRecords = Convert.ToInt32(sql.ExecuteScalar());
            }
            if (totalRecords > 0)
            {
                int counter = 0;
                int startIndex = (pageSize * pageIndex);
                int endIndex = ((startIndex + pageSize) 
                            - 1);
                using (SqlStatement sql = CreateSqlStatement(MembershipProviderSqlStatement.FindUsersByEmail))
                {
                    sql.AssignParameter("Email", emailToMatch);
                    while (sql.Read())
                    {
                        if (counter >= startIndex)
                        	users.Add(GetUser(sql));
                        if (counter >= endIndex)
                        	break;
                        counter++;
                    }
                }
            }
            return users;
        }
        
        protected override void OnValidatingPassword(ValidatePasswordEventArgs e)
        {
            try
            {
                string password = e.Password;
                if (password.Length < MinRequiredPasswordLength)
                	throw new ArgumentException("Invalid password length.");
                int count = 0;
                for (int i = 0; (i < password.Length); i++)
                	if (!(Char.IsLetterOrDigit(password, i)))
                    	count++;
                if (count < MinRequiredNonAlphanumericCharacters)
                	throw new ArgumentException("Password needs more non-alphanumeric characters.");
                if (!(String.IsNullOrEmpty(PasswordStrengthRegularExpression)))
                {
                    if (!(Regex.IsMatch(password, PasswordStrengthRegularExpression)))
                    	throw new ArgumentException("Password does not match regular expression.");
                }
                base.OnValidatingPassword(e);
                if (e.Cancel)
                	if (e.FailureInformation != null)
                    	throw e.FailureInformation;
                    else
                    	throw new ArgumentException("Custom password validation failure.");
            }
            catch (Exception ex)
            {
                e.FailureInformation = ex;
                e.Cancel = true;
            }
        }
    }
}
