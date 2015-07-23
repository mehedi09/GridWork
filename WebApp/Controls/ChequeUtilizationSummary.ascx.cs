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




public partial class Controls_ChequeUtilizationSummary : System.Web.UI.UserControl
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
            PagesHeader.Visible = true;
            rptHeader.Visible = false;
            int accfund = 3;
            if (!string.IsNullOrEmpty(ad.CompanyID.ToString()))
            {
                accfund = int.Parse(ad.CompanyID.ToString());
            }

            getBankbook(accfund);
        }
    }

    public void getBankbook(int accfund)
    {
        try
        {
            con = new SqlConnection(conr);
            SqlDataAdapter adpt = new SqlDataAdapter("select CoaDetailID, AccName FROM CoaDetail where IsBankNature=1 and AccFundID=" + accfund + "", con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            ddlCoaDetail.DataSource = dt;
            ddlCoaDetail.DataTextField = "AccName";
            ddlCoaDetail.DataValueField = "CoaDetailID";
            ddlCoaDetail.DataBind();
            ddlCoaDetail.Items.Insert(0, new ListItem("Select", ""));
        }
        catch(Exception  ex)
        {
            lblerror.Text = ex.Message;
        }
    }
    
   
    protected void Button1_Click1(object sender, EventArgs e)
    {
        showReport();
    }


    private DataTable getBankBookdata(int AccFundID, int BankBookID)
    {
        
            DataTable dt = new DataTable();

            con = new SqlConnection(conr);
            {
                SqlCommand cmd = new SqlCommand("USP_Cheque_Utilization_Summary", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@AccFundID", SqlDbType.Int).Value = AccFundID;
                cmd.Parameters.Add("@BankBookID", SqlDbType.Int).Value = BankBookID;
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(dt);
            }
            return dt;
       
           
       
    }  
      
    private void showReport()
    {
        if (string.IsNullOrEmpty(ddlCoaDetail.SelectedValue))
        {
            lblerror.Text = "Please Select Bank Name. ";
            return;
        }       
        PagesHeader.Visible = false;
        rptHeader.Visible = true;
        ReportForm.Visible = true;
        try
        {
            ReportViewer1.Reset();
            DataTable dt = new DataTable();

            int accfund = 3;
            if (!string.IsNullOrEmpty(ad.CompanyID.ToString()))
            {
                accfund = int.Parse(ad.CompanyID.ToString());
            }
            dt = getBankBookdata(accfund,Convert.ToInt32(ddlCoaDetail.SelectedValue));
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);

            ReportViewer1.LocalReport.DataSources.Add(rds);
            ReportViewer1.LocalReport.ReportPath = new DirectoryInfo(HttpContext.Current.Server.MapPath("/Controls/")) + "ChequeUtilizationSummary.rdlc";

           

            ReportParameter[] rptParametter = new ReportParameter[]
            {
                new ReportParameter("BankName",ddlCoaDetail.SelectedValue),                
            };
            ReportViewer1.LocalReport.SetParameters(rptParametter);
            ReportViewer1.LocalReport.Refresh();


            string PDFPath = new DirectoryInfo(HttpContext.Current.Server.MapPath("~/")) + "PDF\\";
            Microsoft.Reporting.WebForms.Warning[] warnings = null;
            string[] streamids = null;
            String mimeType = null;
            String encoding = null;
            String extension = null;
            Byte[] bytes = null;

            //  string fileName = string.Format("{0:yyyy-MM-dd_hh-mm-ss-tt}", DateTime.Now);

            fileName = "ChequeUtilizationSummary" + DateTime.Now.ToFileTime() + ".pdf";


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
            lblerror.Text = ex.Message;
        }

    }

    protected void clear()
    {
        try
        {
            ddlCoaDetail.Enabled = true;

            ReportViewer1.LocalReport.DataSources.Clear();
            PdfLocation = "";
            fileName = "";
        }
        catch (Exception ex)
        {
            lblerror.Text = ex.Message;
        }
    }
    protected void return_BalancheRptForm_Click(object sender, EventArgs e)
    {
        try
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
            Response.Redirect("~/Pages/ChequeUtilizationSummary.aspx");
        }
        catch (Exception ex)
        {
            lblerror.Text = ex.Message;
        }
    }
}
