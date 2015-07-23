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



public partial class Controls_SubsidiaryAgingReport : System.Web.UI.UserControl
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
            txtfrmDate.Text = System.DateTime.Now.AddYears(-14).ToString("MM/dd/yyyy");
            txtTodate.Text = System.DateTime.Now.ToString("MM/dd/yyyy");

            getACCsubCode();
            getACCCode();
            PagesHeader.Visible = true;
            rptHeader.Visible = false;
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
        SqlDataAdapter adpt = new SqlDataAdapter("SELECT   [AccSubCode], AccSubName FROM [dbo].[AccSubNames] where AccSubTypeID=4 and AccFundID=" + accfund, con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        ddlAccSubCode.DataSource = dt;
        ddlAccSubCode.DataTextField = "AccSubName";
        ddlAccSubCode.DataValueField = "AccSubCode";
        ddlAccSubCode.DataBind();
        ddlAccSubCode.Items.Insert(0, new ListItem("--Select Supplier Ledger--", ""));
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
        SqlDataAdapter adpt = new SqlDataAdapter("SELECT  [CoaDetailID],[AccName] FROM [dbo].[CoaDetail] where SubsYN=1 and AccSubTypeID=4 and AccFundID=" + accfund, con);
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
            SqlCommand cmd = new SqlCommand("USP_Subsidiary_Aging", con);
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
        PagesHeader.Visible = false;
        rptHeader.Visible = true;
        ReportForm.Visible = true;
        try
        {
            ReportViewer1.Reset();       
            int com = 4;
            int sub = Accsubcode1;
            int sub2 = Accsubcode2;
            int code = Convert.ToInt32(ddlACCCode.SelectedValue.ToString());
            DateTime start = Convert.ToDateTime(txtfrmDate.Text);
            DateTime end = Convert.ToDateTime(txtTodate.Text);
            int accfund = 3;
            if (!string.IsNullOrEmpty(ad.CompanyID.ToString()))
            {
                accfund = int.Parse(ad.CompanyID.ToString());
            }



            DataTable dt = getdata(com, sub, sub2, code, start, end, accfund);
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);

            ReportViewer1.LocalReport.DataSources.Add(rds);
            ReportViewer1.LocalReport.ReportPath = new DirectoryInfo(Server.MapPath("/Controls/")) + "SubsidiarySupplierAgingReport.rdlc";
            
            ReportViewer1.LocalReport.Refresh();
            ReportParameter[] rptparameter = new ReportParameter[]
            {
                  // new ReportParameter("Start_Date",start.ToString()),
                new ReportParameter("ToDate",end.ToString("dd-MM-yyyy"))
          
             
                                
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

            fileName = "SubsidiarySupplierAgingReport" + DateTime.Now.ToFileTime() + ".pdf";


            bytes = ReportViewer1.LocalReport.Render("PDF", "", out mimeType, out encoding, out extension, out streamids, out warnings);
            bool IsExitsPDF = File.Exists(PDFPath + fileName);

            FileStream fs = new FileStream(PDFPath + fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            byte[] data = new byte[fs.Length];
            fs.Write(bytes, 0, bytes.Length);
            fs.Close();
            PdfLocation = PDFPath + fileName;

            report.Attributes.Add("src", "../PDF/" + fileName);

        }

        catch (Exception ex)
        {

            throw ex;
        }

    }



    protected void Button1_Click1(object sender, EventArgs e)
    {
        showReport();
    }

    protected void ddlAccSubCode_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(ddlAccSubCode.SelectedValue))
        {
            Accsubcode1 = int.Parse(ddlAccSubCode.SelectedValue);
            Accsubcode2 = int.Parse(ddlAccSubCode.SelectedValue);
        }
    }

    protected void clear()
    {

        // ddlcompany.SelectedIndex = 0;
        txtfrmDate.Text = "";
        txtTodate.Text = "";
        // ddlcompany.Enabled = true;
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
        Response.Redirect("~/Pages/SubsidiaryAgingReport.aspx");

    }
}
