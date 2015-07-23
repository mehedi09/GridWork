using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class Controls_ChequeVoid : System.Web.UI.UserControl
{
    MyCompany.Rules.SharedBusinessRules ad = new MyCompany.Rules.SharedBusinessRules();
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    public static string CreateVoid(string serialno)
    {

        MyCompany.Rules.SharedBusinessRules ad = new MyCompany.Rules.SharedBusinessRules();
        int accfund = 3;
        if (!string.IsNullOrEmpty(ad.CompanyID.ToString()))
        {
            accfund = int.Parse(ad.CompanyID.ToString());
        }
        string result = string.Empty;
        string conr = System.Configuration.ConfigurationManager.ConnectionStrings["MyCompany"].ConnectionString;
        string sql = string.Empty;
        //int AccfundID = 3;
        DataTable dt = new DataTable();
        SqlConnection con = new SqlConnection(conr);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "USP_ChequeVoid";
        cmd.CommandType = CommandType.StoredProcedure;
        if (string.IsNullOrEmpty(serialno))
        {
            cmd.Parameters.Add(new SqlParameter("@serialno", DBNull.Value));
        }
        else
        {
            cmd.Parameters.Add(new SqlParameter("@serialno", serialno));
        }
        

        cmd.Connection = con;
        con.Open();
        int re = cmd.ExecuteNonQuery();
        if (re > 0)
            result = "save";

        return result;
    }
}
