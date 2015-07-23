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



public partial class Controls_CustomerLedgerSchedule : System.Web.UI.UserControl
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

            getACCsubCode();
            getACCCode();
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
            txtfrmDate.Text = dt.Rows[0]["StartDate"].ToString();
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
    public void getACCsubCode()
    {
        int accfund = 3;
        if (!string.IsNullOrEmpty(ad.CompanyID.ToString()))
        {
            accfund = int.Parse(ad.CompanyID.ToString());
        }
        con = new SqlConnection(conr);
        SqlDataAdapter adpt = new SqlDataAdapter("SELECT   [AccSubCode], AccSubName FROM [dbo].[AccSubNames] where AccSubTypeID=3 and AccFundID="+accfund , con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        ddlAccSubCode.DataSource = dt;
        ddlAccSubCode.DataTextField = "AccSubName";
        ddlAccSubCode.DataValueField = "AccSubCode";
        ddlAccSubCode.DataBind();
        ddlAccSubCode.Items.Insert(0, new ListItem("--Select Customer Ledger--", ""));
        if (dt.Rows.Count > 0)
        {
            Accsubcode1 = int.Parse(dt.Rows[0]["AccSubCode"].ToString());
            Accsubcode2 = int.Parse(dt.Rows[dt.Rows.Count - 1]["AccSubCode"].ToString());
        }
       

    }
    
    public void getACCCode()
    {
        int accfund = 3;
        if (!string.IsNullOrEmpty(ad.CompanyID.ToString()))
        {
            accfund = int.Parse(ad.CompanyID.ToString());
        }
        con = new SqlConnection(conr);
        SqlDataAdapter adpt = new SqlDataAdapter("SELECT  [CoaDetailID],[AccName] FROM [dbo].[CoaDetail] where SubsYN=1 and AccSubTypeID=3 and AccFundID="+accfund, con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        ddlACCCode.DataSource = dt;
        ddlACCCode.DataTextField = "AccName";
        ddlACCCode.DataValueField = "CoaDetailID";
        ddlACCCode.DataBind();
        ddlACCCode.Items.Insert(0, new ListItem("--Select Ledger Account--", ""));

    }
    static int Accsubcode1 = 0;
    static int Accsubcode2 = 0;

    protected void ddlAccSubCode_SelectedIndexChanged(object sender, EventArgs e)
    {
         if (!string.IsNullOrEmpty(ddlAccSubCode.SelectedValue))
            {
                Accsubcode1 = int.Parse(ddlAccSubCode.SelectedValue);
                Accsubcode2 = int.Parse(ddlAccSubCode.SelectedValue);
            }
       
    }

    protected void chkAll_CheckedChanged(object sender, EventArgs e)
    {
        if (chkAll.Checked == true)
        {


        }
        else
        {
            ddlAccSubCode.Enabled = true;


        }
    }
    private DataTable getdata(int com, int sub, int sub2, int code, DateTime start, DateTime end, int accfund)
    {
        DataTable dt = new DataTable();
        string conr = System.Configuration.ConfigurationManager.ConnectionStrings["MyCompany"].ConnectionString;
        SqlConnection con = new SqlConnection(conr);
        {
            SqlCommand cmd = new SqlCommand("USP_Subsidiary_Ledger_ScheduleSup", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@AccSubTypeID", SqlDbType.Int).Value = com;
            cmd.Parameters.Add("@AccSubCode1", SqlDbType.Int).Value = sub;
            cmd.Parameters.Add("@AccSubCode2", SqlDbType.Int).Value = sub2;
            cmd.Parameters.Add("@AccCode", SqlDbType.Int).Value = code;
            cmd.Parameters.Add("@Start_Date", SqlDbType.DateTime).Value = start;
            cmd.Parameters.Add("@End_Date", SqlDbType.DateTime).Value = end;
            cmd.Parameters.Add("@AccFundID", SqlDbType.Int).Value = accfund;



            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.Fill(dt);

        }
        return dt;
    }
    private void showReport()
    {
        if (string.IsNullOrEmpty(txtfrmDate.Text))
        {
            lblerror.Text = "Please Select From Date ";
            return;
        }
        if (string.IsNullOrEmpty(txtTodate.Text))
        {
            lblerror.Text = "Please Select To Date ";
            return;
        }
        if(chkAll.Checked==false)
        {
            if (string.IsNullOrEmpty(ddlAccSubCode.SelectedValue))
            {
                lblerror.Text = "Please Select Customer Ledger ";
                return;
            }
        }
        
        if (string.IsNullOrEmpty(ddlACCCode.SelectedValue))
        {
            lblerror.Text = "Please Select Ledger Account ";
            return;
        }
        PagesHeader.Visible = false;
        rptHeader.Visible = true;
        ReportForm.Visible = true;
        try
        {
            ReportViewer1.Reset();
            //DateTime dtDate = Convert.ToDateTime(txtDate.Text.Trim());
            int com = 3;
            int sub = Accsubcode1;
            int sub2 = Accsubcode2;
            int code = Convert.ToInt32(ddlACCCode.SelectedValue.ToString());
            DateTime start = Convert.ToDateTime(txtfrmDate.Text);
            DateTime year = Convert.ToDateTime(txtTodate.Text);
            int accfund = 3;
            if (!string.IsNullOrEmpty(ad.CompanyID.ToString()))
            {
                accfund = int.Parse(ad.CompanyID.ToString());
            }



            DataTable dt = getdata(com, sub, sub2, code, start, year, accfund);
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);

            ReportViewer1.LocalReport.DataSources.Add(rds);
            ReportViewer1.LocalReport.ReportPath = new DirectoryInfo(Server.MapPath("/Controls/")) + "UspSubsidiaryLedgerSchuldule.rdlc";
           // ReportViewer1.LocalReport.ReportPath = new DirectoryInfo(HttpContext.Current.Server.MapPath("~/")).Parent.FullName + "\\MyCompany\\Reports\\UspSubsidiaryLedgerSchuldule.rdlc";

            
            ReportViewer1.LocalReport.Refresh();
            ReportParameter[] rptparameter = new ReportParameter[]
            {
                   new ReportParameter("Start_Date",start.ToString()),
                new ReportParameter("End_Date",year.ToString())
          
             
                                
            };
            ReportViewer1.LocalReport.SetParameters(rptparameter);
            ReportViewer1.LocalReport.Refresh();
            string PDFPath = new DirectoryInfo(HttpContext.Current.Server.MapPath("~/"))+ "PDF\\";
            Microsoft.Reporting.WebForms.Warning[] warnings = null;
            string[] streamids = null;
            String mimeType = null;
            String encoding = null;
            String extension = null;
            Byte[] bytes = null;

            //  string fileName = string.Format("{0:yyyy-MM-dd_hh-mm-ss-tt}", DateTime.Now);

            fileName = "CustomerLedgerSchuldule" + DateTime.Now.ToFileTime() + ".pdf";


            bytes = ReportViewer1.LocalReport.Render("PDF", "", out mimeType, out encoding, out extension, out streamids, out warnings);
            bool IsExitsPDF = File.Exists(PDFPath + fileName);

            FileStream fs = new FileStream(PDFPath + fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            byte[] data = new byte[fs.Length];
            fs.Write(bytes, 0, bytes.Length);
            fs.Close();
            PdfLocation = PDFPath + fileName;

            report.Attributes.Add("src", "../PDF/" + fileName);

        }

        catch (Exception)
        {

            throw;
        }

    }
    protected void clear()
    {
        txtfrmDate.Text = "";
        txtTodate.Text = "";
        //ddlcompany.Enabled = true;
        // ReportForm.Visible = false;
        ReportViewer1.LocalReport.DataSources.Clear();
        PdfLocation = "";
        fileName = "";
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
        Response.Redirect("~/Pages/CustomerLedgerSchedule.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
       
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        showReport();
    }
}
