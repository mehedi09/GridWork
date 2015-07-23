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



public partial class Controls_ChequePrint : System.Web.UI.UserControl
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        showReport();
    }
    private void showReport()
    {
        ReportViewer1.Reset();
        
            DataTable dt = getdata(int.Parse(AccFundID.Value.ToString()),int.Parse(VchrTypeID.Value.ToString()), int.Parse(RevAcc.Value.ToString()), VchrNo.Value,ChequeDT.Value);
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            ReportViewer1.LocalReport.DataSources.Add(rds);


            ReportViewer1.LocalReport.ReportPath = Server.MapPath("/Controls/") + "ChequeBook.rdlc";
        ReportViewer1.LocalReport.Refresh();
    }

    private DataTable getdata(int prm, int prm1, int prm2, string prm3, string prm4)
    {
              
        SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyCompany"].ConnectionString);
        string sql = "SELECT distinct convert (varchar(12),  [ChequeDT],101 ) as 'ChequeDT'  FROM [dbo].[AccTrnDetail] where VchrNo='"+prm3+"'";
        
        SqlDataAdapter adpt1 = new SqlDataAdapter(sql, conn);
        DataTable dt1 = new DataTable();
        adpt1.Fill(dt1);
        if (dt1.Rows.Count > 0)
        {
            prm4 = dt1.Rows[0]["ChequeDT"].ToString();
        }


        DataTable dt = new DataTable();
        {
            SqlCommand cmd = new SqlCommand("GetChequePrintIPAC", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@AccFundID", SqlDbType.Int).Value = Convert.ToInt32(prm);//companny Name
            cmd.Parameters.Add("@VchrTypeID", SqlDbType.Int).Value = Convert.ToInt32(prm1);
            cmd.Parameters.Add("@CashBookAcc", SqlDbType.Int).Value = Convert.ToInt32(prm2);
            cmd.Parameters.Add("@VchrNumber", SqlDbType.NVarChar).Value = prm3;
            cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value =prm4;

            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.Fill(dt);
        }
        return dt;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        Response.Redirect("~/Pages/ChequePrint.aspx");
        
    }
}
