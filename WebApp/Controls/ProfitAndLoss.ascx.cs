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



public partial class Controls_ProfitAndLoss : System.Web.UI.UserControl
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
            RadioButtonList2.SelectedValue = "1";
            divFrmDate.Visible = true;
            divToDate.Visible = true;
            GetFisclaEndDate();
            GetFisclaStartDate();

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
    public void getCompany()
    {
        con = new SqlConnection(conr);
        SqlDataAdapter adpt = new SqlDataAdapter("SELECT [AccFundID] ,[AccFundName] FROM [dbo].[AccFunds]", con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        //ddlcompany.DataSource = dt;
        //ddlcompany.DataTextField = "AccFundName";
        //ddlcompany.DataValueField = "AccFundID";
        //ddlcompany.DataBind();
        //ddlcompany.Items.Insert(0, new ListItem("--Select Company Name--", ""));
    }
    private void showReport()
    {
        if (RadioButtonList2.SelectedValue == "2")
        {
            if (string.IsNullOrEmpty(txtTodate.Text))
            {
                Label1.Text = "Please Select To Date ";
                return;
            }


        }
        else if (RadioButtonList2.SelectedValue == "1")
        {
            if (string.IsNullOrEmpty(txtfrmDate.Text))
            {
                Label1.Text = "Please Select From Date ";
                return;
            }

            if (string.IsNullOrEmpty(txtTodate.Text))
            {
                Label1.Text = "Please Select To Date ";
                return;
            }


        }
        PagesHeader.Visible = false;
        rptHeader.Visible = true;
        ReportForm.Visible = true;
        try
        {
            ReportViewer1.Reset();
            DateTime startdate = Convert.ToDateTime(txtfrmDate.Text);
            DateTime enddate = Convert.ToDateTime(txtTodate.Text);

            int seperate = Convert.ToInt32(RadioButtonList1.SelectedValue);
            int accfund = 3;
            if (!string.IsNullOrEmpty(ad.CompanyID.ToString()))
            {
                accfund = int.Parse(ad.CompanyID.ToString());
            }

            DataTable dt = getdata(startdate, enddate, accfund, seperate);
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);

            ReportViewer1.LocalReport.DataSources.Add(rds);
           
            ReportViewer1.LocalReport.ReportPath = Server.MapPath("/Controls/") + "ProfitAndLoss.rdlc";

            ReportViewer1.LocalReport.Refresh();

            ReportParameter[] rptparameter = new ReportParameter[]
            {
                new ReportParameter("AccFundCode",accfund.ToString()),
                new ReportParameter("FrDate",startdate.ToString()),
                new ReportParameter("ToDate",enddate.ToString())  
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

            fileName = "ProfitAndLoss" + DateTime.Now.ToFileTime() + ".pdf";


            bytes = ReportViewer1.LocalReport.Render("PDF", "", out mimeType, out encoding, out extension, out streamids, out warnings);
            bool IsExitsPDF = File.Exists(PDFPath + fileName);

            FileStream fs = new FileStream(PDFPath + fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            byte[] data = new byte[fs.Length];
            fs.Write(bytes, 0, bytes.Length);
            fs.Close();
            PdfLocation = PDFPath + fileName;

            report.Attributes.Add("src", "../PDF/" + fileName);


        }
        catch(Exception ex)
        {
            throw;
            //Label1.Text = ex.Message;
        }

       
    }
    private DataTable getdata(DateTime startdate, DateTime enddate, int accfund, int seperate)
    {
        DataTable dt = new DataTable();
        string conr = System.Configuration.ConfigurationManager.ConnectionStrings["MyCompany"].ConnectionString;
        SqlConnection con = new SqlConnection(conr);
        {
            SqlCommand cmd = new SqlCommand("USP_ProfitLossACCNew", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@AccFundCode", SqlDbType.Int).Value = accfund;
            cmd.Parameters.Add("@FrDate", SqlDbType.DateTime).Value = startdate;
            cmd.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = enddate;
            cmd.Parameters.Add("@Seperate", SqlDbType.Int).Value = seperate;
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

        // ddlCom.SelectedIndex = 0;
        txtfrmDate.Text = "";
        txtTodate.Text = "";
        // ddlCom.Enabled = true;
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
        Response.Redirect("~/Pages/ProfitAndLoss.aspx");
    }

    protected void RadioButtonList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (RadioButtonList2.SelectedValue == "1")
        {

            divFrmDate.Visible = true;
            divToDate.Visible = true;

        }
        else if (RadioButtonList2.SelectedValue == "2")
        {
            
            divFrmDate.Visible = false;
            
        }
        
    }
}
