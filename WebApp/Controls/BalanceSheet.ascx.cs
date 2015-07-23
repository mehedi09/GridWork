using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class Controls_BalanceSheet : System.Web.UI.UserControl
{
    string conr = ConfigurationManager.ConnectionStrings["MyCompany"].ConnectionString;
    SqlConnection con;
    static string fileName;
    static string PdfLocation;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            getCompany();

        }
    }
    public void getCompany()
    {
        con = new SqlConnection(conr);
        SqlDataAdapter adpt = new SqlDataAdapter("SELECT [AccFundID] ,[AccFundName] FROM [dbo].[AccFunds]", con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        ddlcompany.DataSource = dt;
        ddlcompany.DataTextField = "AccFundName";
        ddlcompany.DataValueField = "AccFundID";
        ddlcompany.DataBind();
        ddlcompany.Items.Insert(0, new ListItem("--Select Company Name--", ""));
    }
    private void showReport()
    {
        ReportForm.Visible = true;

        #region Viewing Rdlc Report
        try
        {
            ReportViewer1.Reset();
            int accfund = Convert.ToInt32(ddlcompany.SelectedValue.ToString());
            DateTime startdate = Convert.ToDateTime(txtfrmDate.Text);
            DateTime enddate = Convert.ToDateTime(txtTodate.Text);


            DataTable dt = getdata(accfund, startdate, enddate);
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);

            ReportViewer1.LocalReport.DataSources.Add(rds);
            //ReportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(BalanceShetDebitamount);
            //ReportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(BalanceShetCreditamount);
            //ReportViewer1.LocalReport.SubreportProcessing   += new SubreportProcessingEventHandler() ;

            ReportViewer1.LocalReport.ReportPath = Server.MapPath("/Controls/") + "BalanceSheetDetAccFund.rdlc";
            //ReportViewer1.LocalReport.ReportPath = Server.MapPath("../Controls/") + "SalarySheet.rdlc";
            //string ReportPath = new DirectoryInfo(HttpContext.Current.Server.MapPath("~/")).Parent.FullName + "\\IPACSOFT\\Reports\\SalarySheet.rdlc";

            //ReportViewer1.LocalReport.ReportPath = ReportPath;
            ReportViewer1.LocalReport.Refresh();
            ReportParameter[] rptparameter = new ReportParameter[]
            {               
                new ReportParameter("Date",enddate.ToString()),               
            };
            ReportViewer1.LocalReport.SetParameters(rptparameter);
            ReportViewer1.LocalReport.Refresh();
        }

        catch 
        {
            return;
        }

        #endregion


      



        //UpdatePanel1.Update();
    }
    private DataTable getdata( int accfund,DateTime startdate, DateTime enddate)
    {
        DataTable dt = new DataTable();        
        con = new SqlConnection(conr);
        {
            SqlCommand cmd = new SqlCommand("USP_BalanceSheetDetAccFund", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@AccFundCode", SqlDbType.Int).Value = accfund;
            cmd.Parameters.Add("@FrDate", SqlDbType.DateTime).Value = startdate;
            cmd.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = enddate;            
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.Fill(dt);
        }
        return dt;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        showReport();
    }
}
