using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class Pages_ChequeVoid : MyCompany.Web.PageBase
{
    static string conr = ConfigurationManager.ConnectionStrings["MyCompany"].ConnectionString;

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
    public static string CreateVoid(string serialno)
    {
        return Controls_ChequeVoid.CreateVoid(serialno);
    }
}
