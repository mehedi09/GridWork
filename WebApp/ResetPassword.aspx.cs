using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyCompany;

namespace WebApp
{
    public partial class ResetPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
            string username="shahinoor";
            if (!string.IsNullOrEmpty(Request.QueryString["userid"].ToString()))
                username = Request.QueryString["userid"].ToString();
           HiddenField1.Value = username;
           
        }
        MyCompany.Security.ApplicationMembershipProvider ad = new MyCompany.Security.ApplicationMembershipProvider();
        protected void Button1_Click(object sender, EventArgs e)
        {
            string x = string.Empty;
            ad.ResetPassword(HiddenField1.Value, "");

            if (!string.IsNullOrEmpty(x))
            {
                MultiView1.ActiveViewIndex = 1;
            }
            else
            {
                MultiView1.ActiveViewIndex = 2;
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }
    }
}