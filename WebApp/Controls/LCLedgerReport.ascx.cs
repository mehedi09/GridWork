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



public partial class Controls_LCLedgerReport : System.Web.UI.UserControl
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
            int accfund = 3;
            if (!string.IsNullOrEmpty(ad.CompanyID.ToString()))
            {
                accfund = int.Parse(ad.CompanyID.ToString());
            }
            getLedgerCode(accfund);
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
    public void getLedgerCode(int AccFundID)
    {

        con = new SqlConnection(conr);
        SqlDataAdapter adpt = new SqlDataAdapter("SELECT  [AccSubCode] ,[AccSubName] FROM [dbo].[AccSubNames] where AccFundID=" + AccFundID + " and AccSubTypeID=16 Order by AccName", con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        ddlLedger.DataSource = dt;
        ddlLedger.DataTextField = "AccSubName";
        ddlLedger.DataValueField = "AccSubCode";
        ddlLedger.DataBind();
        ddlLedger.Items.Insert(0, new ListItem("--Select Ledger Account--", ""));
    }
    private void showReport()
    {
        if (string.IsNullOrEmpty(txtFrmDate.Text))
        {
            lblerror.Text = "Please Select From Date ";
            return;
        }
        if (string.IsNullOrEmpty(txtTodate.Text))
        {
            lblerror.Text = "Please Select To Date ";
            return;
        }
        if (string.IsNullOrEmpty(ddlLedger.SelectedValue))
        {
            lblerror.Text = "Please Select Ledger ";
            return;
        }
        int accfund = 3;
        if (!string.IsNullOrEmpty(ad.CompanyID.ToString()))
        {
            accfund = int.Parse(ad.CompanyID.ToString());
        }
        PagesHeader.Visible = false;
        rptHeader.Visible = true;
        ReportForm.Visible = true;
        try
        {
            ReportViewer1.Reset();
            DataTable dt = new DataTable();

            dt = getdata(accfund, int.Parse(ddlLedger.SelectedValue), Convert.ToDateTime(txtFrmDate.Text), Convert.ToDateTime(txtTodate.Text));
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);

            ReportViewer1.LocalReport.DataSources.Add(rds);

            ReportViewer1.LocalReport.ReportPath = new DirectoryInfo(HttpContext.Current.Server.MapPath("/Controls/")) + "LCLedger.rdlc";

            // Server.MapPath("/Controls/") + "Ledger.rdlc";

            ReportParameter[] rptParametter = new ReportParameter[]
            {
                new ReportParameter("frmDate",txtFrmDate.Text),
                new ReportParameter("toDate",txtTodate.Text)
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

            fileName = "Ledger" + DateTime.Now.ToFileTime() + ".pdf";


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
    private DataTable getdata(int compId, int coamainID,  DateTime frmDate, DateTime toDate)
    {
        DataTable dt = new DataTable();

        con = new SqlConnection(conr);
        {
            SqlCommand cmd = new SqlCommand("sp_GetLedegerReport", con);
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.Add("@FrmDate", SqlDbType.DateTime).Value = frmDate;
            cmd.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = toDate;
            cmd.Parameters.Add("@AccFundID", SqlDbType.Int).Value = compId;
            if (string.IsNullOrEmpty(coamainID.ToString()))
            {
                cmd.Parameters.Add("@AccSubCode", SqlDbType.Int).Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters.Add("@AccSubCode", SqlDbType.Int).Value = coamainID;
            }
            


            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.Fill(dt);
        }


        return dt;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        showReport();
    }
    protected void clear()
    {

        ddlLedger.SelectedIndex = 0;
        txtFrmDate.Text = "";
        txtTodate.Text = "";
        //ddlCom.Enabled = true;
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
        Response.Redirect("~/Pages/LCLedgerReport.aspx");
    }
}
