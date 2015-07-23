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


public partial class Controls_PDCRReportVeiw : System.Web.UI.UserControl
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

        ReportViewer1.LocalReport.ReportPath = Server.MapPath("/Controls/") + "PDCReportView.rdlc";
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
}
