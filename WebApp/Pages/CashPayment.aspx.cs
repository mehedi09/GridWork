using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Reporting.WebForms;



public partial class Pages_CashPayment : MyCompany.Web.PageBase
{
    static string con = System.Configuration.ConfigurationManager.ConnectionStrings["MyCompany"].ConnectionString;
    
    public string CssClass
    {
        get
        {
            return "";
        }
    }
    
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public static string[] GetPaidToName(string keyword)
    {

        string sql = "SELECT AccSubcode,AccSubName FROM DBO.AccSubNames WHERE AccSubTypeID in (2,3,4) AND AccSubName like @keyword";

        SqlDataAdapter da = new SqlDataAdapter(sql, con);
        da.SelectCommand.Parameters.Add("@keyword", System.Data.SqlDbType.VarChar, 50).Value = "%" + keyword + "%";
        DataTable DTLocal = new DataTable();
        da.Fill(DTLocal);

        string[] items = new string[DTLocal.Rows.Count];
        int i = 0;
        foreach (DataRow dr in DTLocal.Rows)
        {
            items.SetValue(dr["AccSubName"].ToString(), i);
            i++;
        }
        return items;
    }


}