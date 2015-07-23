using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class Controls_BillPay : System.Web.UI.UserControl
{
    MyCompany.Rules.SharedBusinessRules ad = new MyCompany.Rules.SharedBusinessRules();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ddlBankLedger.SelectedIndex = -1;
            txtchequeNumber.Value = "";
            txtChaqueDate.Text = "";
            GetBank();
        }
    }
    public void GetBank()
    {
        int accfund = 3;
        if (!string.IsNullOrEmpty(ad.CompanyID.ToString()))
        {
            accfund = int.Parse(ad.CompanyID.ToString());
        }
        string conr = System.Configuration.ConfigurationManager.ConnectionStrings["MyCompany"].ConnectionString;
        SqlConnection con = new SqlConnection(conr);
        SqlDataAdapter da = new SqlDataAdapter("SELECT [CoaDetailID] ,[AccName] FROM [dbo].[CoaDetail] where IsBankNature=1 and AccFundID= "+accfund, con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        ddlBankLedger.DataSource = dt;
        ddlBankLedger.DataTextField = "AccName";
        ddlBankLedger.DataValueField = "CoaDetailID";
        ddlBankLedger.DataBind();
        ddlBankLedger.Items.Insert(0, new ListItem("--Select Bank Ledger--", ""));
    }
    public static string CreateBill(string serialno, string bank, string chequeno, string chequedate, string leafID)
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
        cmd.CommandText = "USP_SupplierBIlllPayment";
        cmd.CommandType = CommandType.StoredProcedure;
        if (string.IsNullOrEmpty(serialno))
        {
            cmd.Parameters.Add(new SqlParameter("@serialno", DBNull.Value));
        }
        else
        {
            cmd.Parameters.Add(new SqlParameter("@serialno", serialno));
        }
        if (string.IsNullOrEmpty(bank))
        {
            cmd.Parameters.Add(new SqlParameter("@CoaDetailID", DBNull.Value));
        }
        else
        {
            cmd.Parameters.Add(new SqlParameter("@CoaDetailID", int.Parse(bank)));
        }

        if (string.IsNullOrEmpty(chequeno))
        {
            cmd.Parameters.Add(new SqlParameter("@chequeno", DBNull.Value));
        }
        else
        {
            cmd.Parameters.Add(new SqlParameter("@chequeno", chequeno));
        }

        if (string.IsNullOrEmpty(chequedate))
        {
            cmd.Parameters.Add(new SqlParameter("@chequedate", DBNull.Value));
        }
        else
        {
            cmd.Parameters.Add(new SqlParameter("@chequedate", chequedate));
        }
        if (string.IsNullOrEmpty(accfund.ToString()))
        {
            cmd.Parameters.Add(new SqlParameter("@AccFundID", DBNull.Value));
        }
        else
        {
            cmd.Parameters.Add(new SqlParameter("@AccFundID", accfund));
        }
        if (string.IsNullOrEmpty(leafID))
        {
            cmd.Parameters.Add(new SqlParameter("@LeafID", DBNull.Value));
        }
        else
        {
            cmd.Parameters.Add(new SqlParameter("@LeafID",int.Parse( leafID)));
        }

        cmd.Connection = con;
        con.Open();
      int re=  cmd.ExecuteNonQuery();
        if( re>0)
        result = "save";
        
        return result;
    }
}
