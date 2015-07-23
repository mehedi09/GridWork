using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class Controls_ChequeHonour : System.Web.UI.UserControl
{
    string conr = ConfigurationManager.ConnectionStrings["MyCompany"].ConnectionString;
    SqlConnection con;
    MyCompany.Rules.SharedBusinessRules ad = new MyCompany.Rules.SharedBusinessRules();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            getBankLedger();
            
        }
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        SerachGrid();
    }
    private void SerachGrid()
    {
        grdLedger.DataSource = null;
        grdLedger.DataBind();
        if (string.IsNullOrEmpty(ddlBankLedger.SelectedValue))
        {
            lblError.Text = "Please select Bank ledger";
            return;
        }
        int accfund = 3;
        if (!string.IsNullOrEmpty(ad.CompanyID.ToString()))
        {
            accfund = int.Parse(ad.CompanyID.ToString());
        }
        DataTable dt = new DataTable();

        con = new SqlConnection(conr);
        {
            SqlCommand cmd = new SqlCommand("GetChequeList", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@AccFundID", SqlDbType.Int).Value = accfund;
            cmd.Parameters.Add("@BankLedgerID", SqlDbType.Int).Value = ddlBankLedger.SelectedValue;

            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.Fill(dt);
        }
        if (dt.Rows.Count > 0)
        {
            grdLedger.DataSource = dt;
            grdLedger.DataBind();
        }
    }
    public void getBankLedger()
    {
        int accfund = 3;
        if (!string.IsNullOrEmpty(ad.CompanyID.ToString()))
        {
            accfund = int.Parse(ad.CompanyID.ToString());
        }
        con = new SqlConnection(conr);
        SqlDataAdapter adpt = new SqlDataAdapter("SELECT  [CoaDetailID],[AccName]  FROM [dbo].[CoaDetail] where IsBankNature='True' and AccFundID=" + accfund, con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        ddlBankLedger.DataSource = dt;
        ddlBankLedger.DataTextField = "AccName";
        ddlBankLedger.DataValueField = "CoaDetailID";
        ddlBankLedger.DataBind();
        ddlBankLedger.Items.Insert(0, new ListItem("--Select Bank Ledger--", ""));

    }

    protected void btnMatched_Click(object sender, EventArgs e)
    {
      
        string userName = string.Empty;
        int accfund = 3;
        if (!string.IsNullOrEmpty(ad.CompanyID.ToString()))
        {
            accfund = int.Parse(ad.CompanyID.ToString());
        }
        if (!string.IsNullOrEmpty(ad.UserID.ToString()))
        {
            userName =ad.UserID.ToString();
        }
        int i = 0;
        foreach (GridViewRow gvrow in grdLedger.Rows)
        {
            CheckBox chk = (CheckBox)gvrow.FindControl("chkCheck");
            if (chk.Checked)
            {
                SqlConnection con = new SqlConnection(conr);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "USP_CheckHonour";
                cmd.CommandType = CommandType.StoredProcedure;
                if (string.IsNullOrEmpty(gvrow.Cells[1].Text.Trim()))
                {
                    cmd.Parameters.Add(new SqlParameter("@AccTrnDetailID", DBNull.Value));
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@AccTrnDetailID", int.Parse(gvrow.Cells[1].Text.Trim())));
                }
                if (string.IsNullOrEmpty(gvrow.Cells[3].Text.Trim()))
                {
                    cmd.Parameters.Add(new SqlParameter("@Chequeno", DBNull.Value));
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@Chequeno", gvrow.Cells[3].Text.Trim()));
                }

                if (string.IsNullOrEmpty(gvrow.Cells[5].Text.Trim()))
                {
                    cmd.Parameters.Add(new SqlParameter("@ChequeHonourDT", DBNull.Value));
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@ChequeHonourDT", DateTime.Parse( gvrow.Cells[5].Text.Trim())));
                }

                if (string.IsNullOrEmpty(userName))
                {
                    cmd.Parameters.Add(new SqlParameter("@UpdatedBY", DBNull.Value));
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter("@UpdatedBY", userName));
                }
                
                cmd.Parameters.Add(new SqlParameter("@UpdateDT", DateTime.Now));
              
                cmd.Connection = con;
                con.Open();
                int re = cmd.ExecuteNonQuery();
                if (re > 0)
                    SerachGrid();
                
            }
            else
            {
                i = i + 1;
            }
        }
        if (i > 0)
        {
            lblError.Text = "Please select checkbox  from table ";
            return;
        }

    }
}
