using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using MyCompany.Data;
using System.Data.SqlClient;

namespace MyCompany.Rules
{
	public partial class SharedBusinessRules : MyCompany.Data.BusinessRules
    {
        
        public SharedBusinessRules()
        {

            //string userName = "admin";
            //if (!string.IsNullOrEmpty(Context.User.Identity.Name))
            //{
            //    userName = Context.User.Identity.Name;
            //    SessionInput(userName);
            //}
            //else
            //{
            //    SessionInput(userName);
            //}
                
        }
        
        public void SessionInput(string username)
        {

            string conr = System.Configuration.ConfigurationManager.ConnectionStrings["MyCompany"].ConnectionString;
            SqlConnection con = new SqlConnection(conr);
            SqlDataAdapter da = new SqlDataAdapter("select *  from Users where UserName='" + username + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                this.SetProperty("Session_UserID", dt.Rows[0]["UserName"].ToString());
                this.SetProperty("Session_CompanyID", dt.Rows[0]["AccFundID"].ToString());
                
            }

        }
        public string UserID
        {
            get
            {
                EnsureSessionVariables();
                return Context.Session["UserID"].ToString();
            }
            set
            {
                Context.Session["UserID"] = value;
            }
        }
        public int CompanyID
        {
            get
            {
                EnsureSessionVariables();
                return (int)Context.Session["CompanyID"];
            }
            set
            {
                Context.Session["CompanyID"] = value;
            }
        }
        public int ImprestFundID
        {
            get
            {
                EnsureSessionVariables();
                return (int)Context.Session["ImprestFundID"];
            }
            set
            {
                Context.Session["ImprestFundID"] = value;
            }
        }
        private void EnsureSessionVariables()
        {
            object o = Context.Session["_initialized"];
            if (o == null)
            {
                Context.Session["_initialized"] = DateTime.Now;
                // we are making an assumption that about IDs of "admin" and "user" accounts
                Context.Session["UserID"] = string.Empty;
                if (!string.IsNullOrEmpty(Context.User.Identity.Name))
                    Context.Session["UserID"] = Context.User.Identity.Name;
                // initialize the ID of the last order placed by employee
                Context.Session["CompanyID"] = SqlText.ExecuteScalar(
                    "select AccFundID  from Users where UserName= @UserName",
                    UserID);
                Context.Session["ImprestFundID"] = SqlText.ExecuteScalar(
                    "select ImprestFundID  from Users where UserName= @UserName",
                    UserID);
            }
        }
    }
}
