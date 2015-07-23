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



public partial class Controls_SubLedgerByGroup : System.Web.UI.UserControl
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
            getAnalysisGroup();
          
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
        Response.Redirect("~/Pages/SubLedgerByGroup.aspx");
    }
    public void getAnalysisGroup()
    {
        int accfund = 3;
        if (!string.IsNullOrEmpty(ad.CompanyID.ToString()))
        {
            accfund = int.Parse(ad.CompanyID.ToString());
        }
        con = new SqlConnection(conr);
        SqlDataAdapter adpt = new SqlDataAdapter("SELECT  [AccSubTypeID],[AccSubTypeName]FROM [dbo].[AccSubTypes] where Display=1", con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        ddlAnalysis.DataSource = dt;
        ddlAnalysis.DataTextField = "AccSubTypeName";
        ddlAnalysis.DataValueField = "AccSubTypeID";
        ddlAnalysis.DataBind();
        ddlAnalysis.Items.Insert(0, new ListItem("--Select Analysis Group--", ""));

    }
    public void getACCCode(int subtype)
    {
        int accfund = 3;
        if (!string.IsNullOrEmpty(ad.CompanyID.ToString()))
        {
            accfund = int.Parse(ad.CompanyID.ToString());
        }
        con = new SqlConnection(conr);
        SqlDataAdapter adpt = new SqlDataAdapter("SELECT  [CoaDetailID],[AccName] FROM [dbo].[CoaDetail] where SubsYN=1 and AccSubTypeID="+subtype+" and AccFundID=" + accfund, con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        ddlACCCode.DataSource = dt;
        ddlACCCode.DataTextField = "AccName";
        ddlACCCode.DataValueField = "CoaDetailID";
        ddlACCCode.DataBind();
        ddlACCCode.Items.Insert(0, new ListItem("--Select Ledger Account--", ""));

    }
    protected void clear()
    {
        //txtfrmDate.Text = "";
        //txtTodate.Text = "";
        //ddlcompany.Enabled = true;
        // ReportForm.Visible = false;
        ReportViewer1.LocalReport.DataSources.Clear();
        PdfLocation = "";
        fileName = "";
    }

    protected void ddlAnalysis_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(ddlAnalysis.SelectedValue))
            getACCCode(int.Parse(ddlAnalysis.SelectedValue));
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        showReport();
    }
    private DataTable getdata(int com,  int code, DateTime start, DateTime end, int accfund)
    {
        DataTable dt = new DataTable();
        string conr = System.Configuration.ConfigurationManager.ConnectionStrings["MyCompany"].ConnectionString;
        SqlConnection con = new SqlConnection(conr);
        {
            SqlCommand cmd = new SqlCommand("USP_Subsidiary_LedgerDetail", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@AccSubTypeID", SqlDbType.Int).Value = com;
           
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
        if (string.IsNullOrEmpty(ddlAnalysis.SelectedValue))
        {
            lblerror.Text = "Please Select Analysis Group ";
            return;
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
            int com = int.Parse( ddlAnalysis.SelectedValue);
            
            int code = Convert.ToInt32(ddlACCCode.SelectedValue.ToString());
            DateTime start = Convert.ToDateTime(txtfrmDate.Text);
            DateTime year = Convert.ToDateTime(txtTodate.Text);
            int accfund = 3;
            if (!string.IsNullOrEmpty(ad.CompanyID.ToString()))
            {
                accfund = int.Parse(ad.CompanyID.ToString());
            }



            DataTable dt = getdata(com,  code, start, year, accfund);
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);

            ReportViewer1.LocalReport.DataSources.Add(rds);
            ReportViewer1.LocalReport.ReportPath = new DirectoryInfo(Server.MapPath("/Controls/")) + "SubLedgerBYGroup.rdlc";
            // ReportViewer1.LocalReport.ReportPath = new DirectoryInfo(HttpContext.Current.Server.MapPath("~/")).Parent.FullName + "\\MyCompany\\Reports\\UspSubsidiaryLedgerSchuldule.rdlc";


            ReportViewer1.LocalReport.Refresh();
            ReportParameter[] rptparameter = new ReportParameter[]
            {
                   new ReportParameter("Start_Date",start.ToString()),
                new ReportParameter("End_Date",year.ToString())
          
             
                                
            };
            ReportViewer1.LocalReport.SetParameters(rptparameter);
            ReportViewer1.LocalReport.Refresh();
            string PDFPath = new DirectoryInfo(HttpContext.Current.Server.MapPath("~/")) + "PDF\\";
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

}
