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



public partial class Controls_ChequeIssueRegister : System.Web.UI.UserControl
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
            txtfrmDate.Text = System.DateTime.Now.ToString("MM/dd/yyyy");
            txtTodate.Text = System.DateTime.Now.ToString("MM/dd/yyyy");


            getBankName();
            PagesHeader.Visible = true;
            rptHeader.Visible = false;
        }
    }
    public void getBankName()
    {
        int accfund = 3;
        if (!string.IsNullOrEmpty(ad.CompanyID.ToString()))
        {
            accfund = int.Parse(ad.CompanyID.ToString());
        }
        con = new SqlConnection(conr);
        SqlDataAdapter adpt = new SqlDataAdapter("  Select CoaDetailID,AccName From [CoaDetail] where IsBankNature=1 and AccFundID=" + accfund, con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        ddlBankName.DataSource = dt;
        ddlBankName.DataTextField = "AccName";
        ddlBankName.DataValueField = "CoaDetailID";
        ddlBankName.DataBind();
        ddlBankName.Items.Insert(0, new ListItem("--Select Bank Name--", ""));
    }


    private DataTable getdata(int Bankcode, DateTime start, DateTime end, int accfund)
    {
        DataTable dt = new DataTable();
        string conr = System.Configuration.ConfigurationManager.ConnectionStrings["MyCompany"].ConnectionString;
        SqlConnection con = new SqlConnection(conr);
        {
            SqlCommand cmd = new SqlCommand("USP_Chequelist", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@BankCode", SqlDbType.Int).Value = Bankcode;
            cmd.Parameters.Add("@FrDate", SqlDbType.DateTime).Value = start;
            cmd.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = end;
            cmd.Parameters.Add("@AccFundID", SqlDbType.Int).Value = accfund;
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.Fill(dt);
        }
        return dt;
    }
    private void showReport()
    {
        if (string.IsNullOrEmpty(ddlBankName.SelectedValue))
        {
            lblerror.Text = "Please select Bank Name.";
            return;
        }
        if (string.IsNullOrEmpty(txtfrmDate.Text))
        {
            lblerror.Text = "Please select From Date.";
            return;
        }
        if (string.IsNullOrEmpty(txtTodate.Text))
        {
            lblerror.Text = "Please select To Date.";
            return;
        }
        PagesHeader.Visible = false;
        rptHeader.Visible = true;
        ReportForm.Visible = true;
        try
        {
            ReportViewer1.Reset();

            int Bankcode = Convert.ToInt32(ddlBankName.SelectedValue.ToString());
            DateTime start = Convert.ToDateTime(txtfrmDate.Text);
            DateTime year = Convert.ToDateTime(txtTodate.Text);
            int accfund = 3;
            if (!string.IsNullOrEmpty(ad.CompanyID.ToString()))
            {
                accfund = int.Parse(ad.CompanyID.ToString());
            }

            DataTable dt = getdata(Bankcode, start, year, accfund);
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);

            ReportViewer1.LocalReport.DataSources.Add(rds);
            ReportViewer1.LocalReport.ReportPath = new DirectoryInfo(Server.MapPath("/Controls/")) + "BankWiseChequeList.rdlc";

            ReportViewer1.LocalReport.Refresh();
            ReportParameter[] rptparameter = new ReportParameter[]
            {
                 new ReportParameter("FrDate",start.ToString()),
                new ReportParameter("ToDate",year.ToString())     
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

            fileName = "BankWiseChequeList" + DateTime.Now.ToFileTime() + ".pdf";


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
    protected void clear()
    {

        txtfrmDate.Text = "";
        txtTodate.Text = "";

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
        Response.Redirect("~/Pages/ChequeIssuRegister.aspx");
    }
}
