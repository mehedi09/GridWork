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



public partial class Controls_ControlLedger : System.Web.UI.UserControl
{
    string conr = ConfigurationManager.ConnectionStrings["MyCompany"].ConnectionString;
    SqlConnection con;
    static string fileName;
    static string PdfLocation;
    MyCompany.Rules.SharedBusinessRules ad = new MyCompany.Rules.SharedBusinessRules();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GetFisclaEndDate();
            GetFisclaStartDate();
           // getCompany();
            int accfund = 3;
            if (!string.IsNullOrEmpty(ad.CompanyID.ToString()))
            {
                accfund = int.Parse(ad.CompanyID.ToString());
            }
            getAccCode(accfund);
            PagesHeader.Visible = true;
            rptHeader.Visible = false;
        }
    }
    public void GetFisclaStartDate()
    {
        con = new SqlConnection(conr);
        SqlDataAdapter adpt = new SqlDataAdapter("select  convert (varchar(12),  [dbo].[GetFiscalStartDate]('" + System.DateTime.Now.ToString("MM/dd/yyyy") + "'),101)  as 'StartDate'  ", con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            txtFrmDate.Text = dt.Rows[0]["StartDate"].ToString();
        }

    }
    public void GetFisclaEndDate()
    {
        con = new SqlConnection(conr);
        SqlDataAdapter adpt = new SqlDataAdapter("select  convert (varchar(12),  [dbo].[GetFiscalEndDate]('" + System.DateTime.Now.ToString("MM/dd/yyyy") + "'),101)  as 'EndDate'  ", con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            txtTodate.Text = dt.Rows[0]["EndDate"].ToString();
        }

    }
    //public void getCompany()
    //{
    //    con = new SqlConnection(conr);
    //    SqlDataAdapter adpt = new SqlDataAdapter("SELECT [AccFundID] ,[AccFundName] FROM [dbo].[AccFunds]", con);
    //    DataTable dt = new DataTable();
    //    adpt.Fill(dt);
    //    ddlCom.DataSource = dt;
    //    ddlCom.DataTextField = "AccFundName";
    //    ddlCom.DataValueField = "AccFundID";
    //    ddlCom.DataBind();
    //    ddlCom.Items.Insert(0, new ListItem("--Select Company Name--", ""));
    //    ddlCom.SelectedValue = "3";
    //}
    public void getAccCode(int AccFundID)
    {

        con = new SqlConnection(conr);
        SqlDataAdapter adpt = new SqlDataAdapter("select CoaSubID, AccName  FROM CoaSub where AccFundID=" + AccFundID + " Order by AccName", con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        ddlAccCode.DataSource = dt;
        ddlAccCode.DataTextField = "AccName";
        ddlAccCode.DataValueField = "CoaSubID";
        ddlAccCode.DataBind();
        ddlAccCode.Items.Insert(0, new ListItem("--Select Account Name--", ""));
    }
    private DataTable getLedgerControlFund(int compId, int accFund,  DateTime frmDate, DateTime toDate)
    {
        DataTable dt = new DataTable();

        con = new SqlConnection(conr);
        {
            SqlCommand cmd = new SqlCommand("USP_LedgerControlFund", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@AccFundCode", SqlDbType.Int).Value = compId;
            cmd.Parameters.Add("@LedAccCode", SqlDbType.Int).Value = accFund;
           
            cmd.Parameters.Add("@Start_date", SqlDbType.DateTime).Value = frmDate;
            cmd.Parameters.Add("@To_Date", SqlDbType.DateTime).Value = toDate;


            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.Fill(dt);
        }


        return dt;
    }

    private void showReport()
    {

        int accfund = 3;
        if (!string.IsNullOrEmpty(ad.CompanyID.ToString()))
        {
            accfund = int.Parse(ad.CompanyID.ToString());
        }
        ReportViewer1.Reset();
        DataTable dt = new DataTable();
        
      
            dt = getLedgerControlFund(accfund, int.Parse( ddlAccCode.SelectedValue), Convert.ToDateTime(txtFrmDate.Text), Convert.ToDateTime(txtTodate.Text));
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);

            ReportViewer1.LocalReport.DataSources.Add(rds);

            ReportViewer1.LocalReport.ReportPath = Server.MapPath("/Controls/") + "LedgerControlFund.rdlc";

            ReportParameter[] rptParametter = new ReportParameter[]
            {
                new ReportParameter("frmDate",txtFrmDate.Text),
                new ReportParameter("toDate",txtTodate.Text)
            };
            ReportViewer1.LocalReport.SetParameters(rptParametter);
            ReportViewer1.LocalReport.Refresh();
      

    }

   

    protected void Button1_Click(object sender, EventArgs e)
    {
        showReport();
    }
    protected void clear()
    {

        // ddlCom.SelectedIndex = 0;
        ddlAccCode.SelectedIndex = 0;
        txtFrmDate.Text = "";
        txtTodate.Text = "";
        // ddlCom.Enabled = true;
        ddlAccCode.Enabled = true;
        // ReportForm.Visible = false;
        ReportViewer1.LocalReport.DataSources.Clear();
        PdfLocation = "";
        fileName = "";

        //txt_Check_Date.Text = "";
        ///////////////////////

        // txt_CheckNo.Text = "";
        // txt_Branch_Name.Text = "";


    }
    protected void return_BalancheRptForm_Click(object sender, EventArgs e)
    {
        string PDFPath = new DirectoryInfo(HttpContext.Current.Server.MapPath("~/")).Parent.FullName + "\\WebApp\\PDF\\";
        bool IsExitsPDF = File.Exists(PDFPath + fileName);

        if (IsExitsPDF)
        {
            File.Delete(PdfLocation);
        }
        // ReportForm.Visible = false;
        PagesHeader.Visible = true;
        rptHeader.Visible = false;
        clear();
        Response.Redirect("~/Pages/LedgerReport.aspx");
    }
}
