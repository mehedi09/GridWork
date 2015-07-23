using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class Controls_OpeningBalanceEntry : System.Web.UI.UserControl
{
    string conr = System.Configuration.ConfigurationManager.ConnectionStrings["MyCompany"].ConnectionString;
    SqlConnection con;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection(conr);
        if (!IsPostBack)
        {
            txtdate.Text = DateTime.Now.ToShortDateString();
            GetSubTypeID();         
        }
    }

    public void GetSubTypeID()
    {
        con = new SqlConnection(conr);
        SqlDataAdapter adpt = new SqlDataAdapter("select AccSubTypeID,AccSubTypeName from AccsubTypes where AccSubTypeID in(1,3,4)", con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        ddlAccSubTypeID.DataSource = dt;
        ddlAccSubTypeID.DataTextField = "AccSubTypeName";
        ddlAccSubTypeID.DataValueField = "AccSubTypeID";
        ddlAccSubTypeID.DataBind();
        ddlAccSubTypeID.Items.Insert(0, new ListItem("Please select ..", ""));
    }

    public void getGridData(int SubTypeID)
    {
        if(SubTypeID==1)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select CoaDetailID,AccName,ISNULL(OpenDebit,0)OpenDebit,ISNULL(OpenCredit,0)OpenCredit from [CoaDetail] where AccSubTypeID=1 and AccTypeID IN(1,2)", con);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            GVOpeningLedger.DataSource = dt;
            GVOpeningLedger.DataBind();
        }
        else if (SubTypeID == 3)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select CoaDetailID,AccName,ISNULL(OpenDebit,0)OpenDebit,ISNULL(OpenCredit,0)OpenCredit from [CoaDetail] where AccSubTypeID=3", con);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            GVOpeningLedger.DataSource = dt;
            GVOpeningLedger.DataBind();
        }
        else
        {
            SqlDataAdapter da = new SqlDataAdapter("Select CoaDetailID,AccName,ISNULL(OpenDebit,0)OpenDebit,ISNULL(OpenCredit,0)OpenCredit from [CoaDetail] where AccSubTypeID=4", con);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            GVOpeningLedger.DataSource = dt;
            GVOpeningLedger.DataBind();
        }       
       
    }

    protected void ddlAccSubTypeID_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(ddlAccSubTypeID.SelectedValue.Trim()))
        {
            lblmsg.Text = "Please select Account Sub Type ID.";
            return;
        }
        else
        {
            getGridData(int.Parse(ddlAccSubTypeID.SelectedValue));
        }
    }

    protected void ckHeader_CheckedChanged(object sender, EventArgs e)
    {
        CheckBox ChkBoxHeader = (CheckBox)GVOpeningLedger.HeaderRow.FindControl("ckHeader");
        foreach (GridViewRow row in GVOpeningLedger.Rows)
        {
            CheckBox ChkBoxRows = (CheckBox)row.FindControl("CkCoaDetails");
            if (ChkBoxHeader.Checked == true)
            {
                ChkBoxRows.Checked = true;
            }
            else
            {
                ChkBoxRows.Checked = false;
            }
        }
    }


    private void SaveOpeningBalance()
    {
        try
        {
            if (string.IsNullOrEmpty(ddlAccSubTypeID.SelectedValue.Trim()))
            {
                lblmsg.Text = "Please select Account Sub Type.";
                return;
            }
            else if (string.IsNullOrEmpty(txtdate.Text))
            {
                lblmsg.Text = "Please select Date.";
                return;
            }            
            else
            {
                if (GVOpeningLedger.Rows.Count > 0)
                {
                    for (int k = 0; k < GVOpeningLedger.Rows.Count; k++)
                    {
                        CheckBox cb = (CheckBox)GVOpeningLedger.Rows[k].Cells[0].FindControl("CkCoaDetails");

                        if (cb != null)
                        {
                            if (cb.Checked)
                            {
                                SqlCommand cmd = new SqlCommand();
                                cmd.Connection = con;
                                cmd.CommandText = "USP_Update_Opening_Balance_Entry";
                                cmd.CommandType = CommandType.StoredProcedure;
                                if (string.IsNullOrEmpty(ddlAccSubTypeID.SelectedValue.Trim()))
                                {
                                    cmd.Parameters.Add(new SqlParameter("@AccSubTypeID", DBNull.Value));
                                }
                                else
                                {
                                    cmd.Parameters.Add(new SqlParameter("@AccSubTypeID", int.Parse(ddlAccSubTypeID.SelectedValue.Trim())));
                                }
                                if (string.IsNullOrEmpty(txtdate.Text.Trim()))
                                {
                                    cmd.Parameters.Add(new SqlParameter("@OpenDate", DBNull.Value));
                                }
                                else
                                {
                                    cmd.Parameters.Add(new SqlParameter("@OpenDate", DateTime.Parse(txtdate.Text.Trim())));
                                }                               
                                if (string.IsNullOrEmpty(GVOpeningLedger.Rows[k].Cells[1].Text.Trim()))
                                {
                                    cmd.Parameters.Add(new SqlParameter("@CoaDetailID", DBNull.Value));
                                }
                                else
                                {
                                    cmd.Parameters.Add(new SqlParameter("@CoaDetailID", GVOpeningLedger.Rows[k].Cells[1].Text.Trim()));
                                }
                                TextBox OpenDebit = (TextBox)GVOpeningLedger.Rows[k].FindControl("txtOpenDebit");

                                if (string.IsNullOrEmpty(OpenDebit.Text.Trim()))
                                {
                                    cmd.Parameters.Add(new SqlParameter("@OpenDebit", Convert.ToDecimal("0")));
                                }
                                else
                                {
                                    cmd.Parameters.Add(new SqlParameter("@OpenDebit", decimal.Parse(OpenDebit.Text.Trim())));
                                }

                                TextBox OpenCredit = (TextBox)GVOpeningLedger.Rows[k].FindControl("txtOpenCredit");

                                if (string.IsNullOrEmpty(OpenCredit.Text.Trim()))
                                {
                                    cmd.Parameters.Add(new SqlParameter("@OpenCredit", Convert.ToDecimal("0")));
                                }
                                else
                                {
                                    cmd.Parameters.Add(new SqlParameter("@OpenCredit", decimal.Parse(OpenCredit.Text.Trim())));
                                }
                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                               // getGridDataAfterInsert(int.Parse(ddlbpono.SelectedValue), int.Parse(ddlstyle.SelectedValue));
                                lblmsg.Text = "Data Added Successfully.";
                            }
                        }
                    }
                }
            }
        }

        catch (System.Exception ex)
        {
            throw ex;
        }
        finally
        {
            lblmsg.Focus();
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        SaveOpeningBalance();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SaveOpeningBalance();
    }

    
}
