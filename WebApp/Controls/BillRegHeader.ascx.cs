using Microsoft.Reporting.WebForms;
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


public partial class Controls_BillRegHeader : System.Web.UI.UserControl
{
    string conr = ConfigurationManager.ConnectionStrings["MyCompany"].ConnectionString;
    SqlConnection con;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection(conr);
        if (!IsPostBack)
        {
            getPrefix();
            getEmployee();
            getBillHeader();
        }
    }
    public void getPrefix()
    {      
        SqlDataAdapter adpt = new SqlDataAdapter("Select* from Prefix", con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        ddlPrefix.DataSource = dt;
        ddlPrefix.DataTextField = "Prefix";
        ddlPrefix.DataValueField = "Prefix";
        ddlPrefix.DataBind();
        ddlPrefix.Items.Insert(0, new ListItem("--Select Prefix--", ""));
    }

    public void getBillHeader()
    {
        SqlDataAdapter adpt = new SqlDataAdapter("Select* from AccBillRegisterH", con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        GridView2.DataSource = dt;
        GridView2.DataBind();       
    }

    public void getEmployee()
    {
        SqlDataAdapter adpt = new SqlDataAdapter("Select EmployeeID,EmpName from Employees", con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        ddlemployee.DataSource = dt;
        ddlemployee.DataTextField = "EmpName";
        ddlemployee.DataValueField = "EmployeeID";
        ddlemployee.DataBind();
        ddlemployee.Items.Insert(0, new ListItem("--Select Prefix--", ""));
    }

    public void create_RegNo(string preno)
    {     
        SqlDataAdapter da=new SqlDataAdapter ("USP_BILLREG_CREATE",con);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.AddWithValue("@PreFix",preno);
        DataTable dt=new DataTable ();
        da.Fill(dt);
        if(dt.Rows.Count>0)
        {
            txtRegNo.Text=dt.Rows[0]["FileNumber"].ToString();
        }  
    }

    protected void ddlPrefix_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlPrefix.SelectedIndex == 0)
        {
            txtRegNo.Text = "";
            return;            
        }
        else
        {          
            //create_RegNo(ddlPrefix.SelectedValue);
        }
    }

    public void AddData()
    {
        try
        {
            SqlCommand cmd = new SqlCommand("Insert Into AccBillRegisterH(RegisterPrefix, RegisterNo, RegisterDate, BillEmployee,Remarks)values(@RegisterPrefix, @RegisterNo, @RegisterDate, @BillEmployee,@Remarks)", con);
            cmd.Parameters.AddWithValue("@RegisterPrefix", ddlPrefix.SelectedValue);
            cmd.Parameters.AddWithValue("@RegisterNo", txtRegNo.Text);
            cmd.Parameters.AddWithValue("@RegisterDate", txtRegDate.Text);
            cmd.Parameters.AddWithValue("@BillEmployee", int.Parse(ddlemployee.SelectedValue));
            cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        catch(Exception ex)
        {
            throw ex;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if(ddlPrefix.SelectedIndex==0)
        {
            lblmsg.Text = "Please Select Prefix.";
        }
        else if(txtRegNo.Text==""||txtRegNo.Text==null)
        {
            lblmsg.Text = "Please Insert Register No.";
        }
        else if (txtRegDate.Text == "" || txtRegDate.Text == null)
        {
            lblmsg.Text = "Please Select Date.";
        }
        else
        {
            AddData();
        }
    }

    public void UpdateData()
    {
        try
        {
            SqlCommand cmd = new SqlCommand("Update AccBillRegisterH Set RegisterDate=@RegisterDate, BillEmployee=@BillEmployee,Remarks=@Remarks where RegisterNo=@RegisterNo)", con);            
            cmd.Parameters.AddWithValue("@RegisterNo", txtRegNo.Text);
            cmd.Parameters.AddWithValue("@RegisterDate", txtRegDate.Text);
            cmd.Parameters.AddWithValue("@BillEmployee", int.Parse(ddlemployee.SelectedValue));
            cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        if(ddlPrefix.SelectedIndex==0)
        {
            lblmsg.Text = "Please Select Prefix.";
        }
        else if(txtRegNo.Text==""||txtRegNo.Text==null)
        {
            lblmsg.Text = "Please Insert Register No.";
        }
    else if (txtRegDate.Text == "" || txtRegDate.Text == null)
    {
        lblmsg.Text = "Please Select Date.";
    }
    else
    {
        UpdateData();
    }
    }
}
