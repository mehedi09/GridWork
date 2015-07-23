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



public partial class Controls_MoneyReceiptView : System.Web.UI.UserControl
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            showReport();
    }
    private void showReport()
    {
        ReportViewer1.Reset();
        bool ckmrtype = Convert.ToBoolean(hdType.Value);
        if (ckmrtype == false)
        {
            DataTable dt = getdata(ckmrtype, hdapplicant.Value, int.Parse(hdmoney.Value));
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            ReportViewer1.LocalReport.DataSources.Add(rds);
        }
        else
        {
            DataTable dt = getdata(ckmrtype, hdapplicant.Value, int.Parse(hdmoney.Value));
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            ReportViewer1.LocalReport.DataSources.Add(rds);
        }

        ReportViewer1.LocalReport.ReportPath = Server.MapPath("/Controls/") + "MoneyReceiptView.rdlc";
        ReportViewer1.LocalReport.Refresh();
    }

    private DataTable getdata(bool type, string emp, int moneyreceiptid)
    {

        DataTable dt = new DataTable();
        string conr = System.Configuration.ConfigurationManager.ConnectionStrings["MyCompany"].ConnectionString;
        SqlConnection con = new SqlConnection(conr);
        {
            SqlCommand cmd = new SqlCommand("USP_Money_Receipt_Acc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@type ", SqlDbType.Int).Value = type;
            cmd.Parameters.Add("@applicatintid ", SqlDbType.VarChar).Value = emp;
            cmd.Parameters.Add("@moneyreceiptId ", SqlDbType.Int).Value = moneyreceiptid;

            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.Fill(dt);
        }
        return dt;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (hdType.Value == "True")
        {
            Response.Redirect("~/Pages/MoneyReceiptsSales.aspx");
        }
        else
        {
            Response.Redirect("~/Pages/MoneyReceipts.aspx");
        }
    }
}
