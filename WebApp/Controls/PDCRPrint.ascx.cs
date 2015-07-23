using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Controls_PDCRPrint : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            showReport();
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        showReport();
    }
    private void showReport()
    {
        ReportViewer1.Reset();
        //bool ckmrtype = Convert.ToBoolean(hdType.Value);
        //if (ckmrtype == false)
        //{
            DataTable dt = getdata(int.Parse(hdmoney.Value));
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            ReportViewer1.LocalReport.DataSources.Add(rds);
        //}
        //else
        //{
        //    DataTable dt = getdata(ckmrtype, hdapplicant.Value, int.Parse(hdmoney.Value));
        //    ReportDataSource rds = new ReportDataSource("DataSet1", dt);
        //    ReportViewer1.LocalReport.DataSources.Add(rds);
        //}

        ReportViewer1.LocalReport.ReportPath = Server.MapPath("/Controls/") + "PDCReportPrint.rdlc";
        ReportViewer1.LocalReport.Refresh();
    }

    private DataTable getdata(int moneyreceiptid)
    {

        DataTable dt = new DataTable();
        string conr = System.Configuration.ConfigurationManager.ConnectionStrings["MyCompany"].ConnectionString;
        SqlConnection con = new SqlConnection(conr);
        {
            SqlCommand cmd = new SqlCommand("USP_PDCR_Report_Accounts_GMR", con);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@type ", SqlDbType.Int).Value = type;
            //cmd.Parameters.Add("@fileno", SqlDbType.VarChar).Value = emp;
            cmd.Parameters.Add("@PDCRId ", SqlDbType.Int).Value = moneyreceiptid;

            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.Fill(dt);
        }
        return dt;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Pages/PDCReceive.aspx");
    }
    //private void showReport()
    //{
    //    ReportViewer1.Reset();
    //    if (ckmrtype.Checked == false)
    //    {
    //        DataTable dt = getdata(ckmrtype.Checked, cmbapplicationid.Text, int.Parse(cmbmonre.SelectedValue));
    //        ReportDataSource rds = new ReportDataSource("DataSet1", dt);
    //        ReportViewer1.LocalReport.DataSources.Add(rds);
    //    }
    //    else
    //    {
    //        DataTable dtt = getdata(ckmrtype.Checked, cmbpaymentname.SelectedValue, int.Parse(DropDownList1.SelectedValue));
    //        ReportDataSource rds = new ReportDataSource("DataSet1", dtt);
    //        ReportViewer1.LocalReport.DataSources.Add(rds);
    //    }
    //    ReportViewer1.LocalReport.ReportPath = Server.MapPath("/Controls/") + "PDCReportPrint.rdlc";


    //    ReportViewer1.LocalReport.Refresh();
    //}

    //private DataTable getdata(bool type, string emp, int moneyreceiptid)
    //{

    //    DataTable dt = new DataTable();
    //    string conr = System.Configuration.ConfigurationManager.ConnectionStrings["MyCompany"].ConnectionString;
    //    SqlConnection con = new SqlConnection(conr);
    //    {
    //        SqlCommand cmd = new SqlCommand("USP_PDCR_Report", con);
    //        cmd.CommandType = CommandType.StoredProcedure;
    //        cmd.Parameters.Add("@type ", SqlDbType.Int).Value = type;
    //        cmd.Parameters.Add("@fileno", SqlDbType.VarChar).Value = emp;
    //        cmd.Parameters.Add("@PDCRId ", SqlDbType.Int).Value = moneyreceiptid;

    //        SqlDataAdapter adpt = new SqlDataAdapter(cmd);
    //        adpt.Fill(dt);
    //    }
    //    return dt;
    //}

    //public void getmrn(string  fileno)
    //{
    //    string conr = System.Configuration.ConfigurationManager.ConnectionStrings["MyCompany"].ConnectionString;
    //    SqlConnection con = new SqlConnection(conr);
    //    SqlDataAdapter da = new SqlDataAdapter("select PDCRID,PDCNO from PDCReceive where allotmentNo='" + fileno + "' and pdctype=0", con);
    //    DataTable dt = new DataTable();
    //    da.Fill(dt);
    //    cmbmonre.DataSource = dt;
    //    cmbmonre.DataTextField = "PDCNO";
    //    cmbmonre.DataValueField = "PDCRID";
    //    cmbmonre.DataBind();
    //    cmbmonre.Items.Insert(0,new ListItem( "--Select--",""));
    //}
    //public void getname()
    //{
    //    string conr = System.Configuration.ConfigurationManager.ConnectionStrings["MyCompany"].ConnectionString;
    //    SqlConnection con = new SqlConnection(conr);
    //    SqlDataAdapter da = new SqlDataAdapter("select PDCNO,(PDCNO+'-'+GName)as PDCNAME from dbo.PDCReceive where PDCType=1", con);
    //    DataTable dt = new DataTable();
    //    da.Fill(dt);
    //    cmbpaymentname.DataSource = dt;
    //    cmbpaymentname.DataTextField = "PDCNAME";
    //    cmbpaymentname.DataValueField = "PDCNO";
    //    cmbpaymentname.DataBind();
    //    cmbpaymentname.Items.Insert(0,new ListItem( "--Select--",""));
    //}
    //public void getMRNOG(string MRNOG)
    //{
    //    string conr = System.Configuration.ConfigurationManager.ConnectionStrings["MyCompany"].ConnectionString;
    //    SqlConnection con = new SqlConnection(conr);
    //    SqlDataAdapter da = new SqlDataAdapter("select PDCNO,PDCRID from PDCReceive where PDCNO='" + MRNOG + "'", con);
    //    DataTable dt = new DataTable();
    //    da.Fill(dt);
    //    DropDownList1.DataSource = dt;
    //    DropDownList1.DataTextField = "PDCNO";
    //    DropDownList1.DataValueField = "PDCRID";
    //    DropDownList1.DataBind();
    //    DropDownList1.Items.Insert(0,new ListItem( "--Select--",""));
    //}


    //protected void txtEmpNO_TextChanged(object sender, EventArgs e)
    //{
    //   // getmrn(mbapplicationid.SelectedValue);
    //}

    //protected void ckmrtype_CheckedChanged(object sender, EventArgs e)
    //{
    //    if (ckmrtype.Checked == false)
    //    {
    //        ckpanel.Visible = true;
    //        ckPanel1.Visible = false;
    //    }
    //    else
    //    {
    //        getname();
    //        ckpanel.Visible = false;
    //        ckPanel1.Visible = true;
    //    }
    //}

    //protected void cmbpaymentname_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    getMRNOG(cmbpaymentname.SelectedValue);
    //}
    //public void getproject()
    //{
    //    string conr = System.Configuration.ConfigurationManager.ConnectionStrings["MyCompany"].ConnectionString;
    //    SqlConnection con = new SqlConnection(conr);
    //    SqlDataAdapter da = new SqlDataAdapter("select LndProjectID,ProjectName from LandProjects", con);
    //    DataTable dt = new DataTable();
    //    da.Fill(dt);
    //    cmbproject.DataSource = dt;
    //    cmbproject.DataTextField = "ProjectName";
    //    cmbproject.DataValueField = "LndProjectID";
    //    cmbproject.DataBind();
    //    cmbproject.Items.Insert(0, new ListItem( "--Select Project--",""));
    //}

    //public void getblock(int project)
    //{
    //    string conr = System.Configuration.ConfigurationManager.ConnectionStrings["MyCompany"].ConnectionString;
    //    SqlConnection con = new SqlConnection(conr);
    //    SqlDataAdapter da = new SqlDataAdapter("select LndBlockID,Blockname from LandBlocks where LndProjectID='" + project + "'", con);
    //    DataTable dt = new DataTable();
    //    da.Fill(dt);
    //    cmbblock.DataSource = dt;
    //    cmbblock.DataTextField = "Blockname";
    //    cmbblock.DataValueField = "LndBlockID";
    //    cmbblock.DataBind();
    //    cmbblock.Items.Insert(0, new ListItem( "--Select Block--",""));
    //}
    //public void getapplicant(int block)
    //{
    //    string conr = System.Configuration.ConfigurationManager.ConnectionStrings["MyCompany"].ConnectionString;
    //    SqlConnection con = new SqlConnection(conr);
    //    SqlDataAdapter da = new SqlDataAdapter("select AllotmentNo, (ApplicantName+'-'+AllotmentNo)as AppName  from MasterApplication where  BlockID='" + block + "'", con);
    //    DataTable dt = new DataTable();
    //    da.Fill(dt);
    //    cmbapplicationid.DataSource = dt;
    //    cmbapplicationid.DataTextField = "AppName";
    //    cmbapplicationid.DataValueField = "AllotmentNo";
    //    cmbapplicationid.DataBind();
    //    cmbapplicationid.Items.Insert(0, new ListItem( "--Select Applicant--",""));
    //}

    //protected void cmbproject_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    if (cmbproject.SelectedIndex == 0)
    //    {
    //        int test = 0;
    //        getblock(test);
    //    }
    //    else
    //    {
    //        getblock(int.Parse(cmbproject.SelectedValue));

    //    }
    //}

    //protected void cmbblock_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    if (cmbblock.SelectedIndex == 0)
    //    {
    //        int test1 = 0;
    //        getapplicant(test1);
    //    }
    //    else
    //    {
    //        getapplicant(int.Parse(cmbblock.SelectedValue));
    //    }
    //}

    //protected void cmbapplicationid_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    if (!string.IsNullOrEmpty(cmbapplicationid.SelectedValue))
    //        getmrn(cmbapplicationid.SelectedValue);

    //}
}
