using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class Pages_SupplierBillPayment : MyCompany.Web.PageBase
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
    public static string CreateBill(string serialno, string bank, string chequeno, string chequedate, string leafID)
    {
        return Controls_BillPay.CreateBill(serialno, bank, chequeno, chequedate, leafID);
    }
    [System.Web.Services.WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public static string[] GetChequeLeaf(string keyword, string contextKey)
    {
        MyCompany.Rules.SharedBusinessRules ad = new MyCompany.Rules.SharedBusinessRules();

        int accfund = 3;
        if (!string.IsNullOrEmpty(ad.GetProperty("Session_CompanyID").ToString()))
        {
            accfund = int.Parse(ad.GetProperty("Session_CompanyID").ToString());
        }
        int contextValue = int.Parse(contextKey);
        string sql = "SELECT  (CONVERT(nvarchar, cl.LeafID)+':'+convert(nvarchar, cl.LeafNumber)) as LeafNumber  FROM [dbo].[ChequeBooksLeaf] cl inner join dbo.ChequeBooks cb on cl.ChequeBookID=cb.ChequeBookID " +
                    " where cl.IsUsed=0 and cb.AccFundID=" + accfund + " and cb.CoaDetailID=" + contextKey + " and cl.LeafNumber like @keyword  ";
        // string sql = "Select StyleTrandId  + ':' +  StyleNo as StyleNo from tblStyleInformation where IndependentStyle='false' and StyleNo like @prefixText"; //"select ItemCode, ItemName from tblItemListInfo where ItemName like @prefixText"; 
        SqlDataAdapter da = new SqlDataAdapter(sql, conr);
        da.SelectCommand.Parameters.Add("@keyword", System.Data.SqlDbType.VarChar, 50).Value = "%" + keyword + "%";
        DataTable DTLocal = new DataTable();
        da.Fill(DTLocal);

        string[] items = new string[DTLocal.Rows.Count];
        int i = 0;
        foreach (DataRow dr in DTLocal.Rows)
        {
            items.SetValue(dr["LeafNumber"].ToString(), i);
            i++;
        }
        return items;
    }
}
