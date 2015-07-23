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



public partial class Controls_SubsidiaryLedger : System.Web.UI.UserControl
{
    string conr = ConfigurationManager.ConnectionStrings["MyCompany"].ConnectionString;
    SqlConnection con;
    static string fileName;
    static string PdfLocation;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            txtfrmDate.Text = System.DateTime.Now.ToString("MM/dd/yyyy");
            txtTodate.Text = System.DateTime.Now.ToString("MM/dd/yyyy");
            getCompany();
            getSubTypeID();
            PagesHeader.Visible = true;
            rptHeader.Visible = false;
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
        ddlcompany.SelectedValue = "3";
    }
    public void getSubTypeID()
    {
        con = new SqlConnection(conr);
        SqlDataAdapter adpt = new SqlDataAdapter("SELECT  [AccSubTypeID] ,[AccSubTypeName] FROM [dbo].[AccSubTypes] where Display=1 and DisplayAcc=1", con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        ddlSubTypeID.DataSource = dt;
        ddlSubTypeID.DataTextField = "AccSubTypeName";
        ddlSubTypeID.DataValueField = "AccSubTypeID";
        ddlSubTypeID.DataBind();
        ddlSubTypeID.Items.Insert(0, new ListItem("--Select SubType--", ""));
    }

    public void getACCsubCode()
    {
        con = new SqlConnection(conr);
        SqlDataAdapter adpt = new SqlDataAdapter("SELECT   [AccSubCode], AccSubName FROM [dbo].[AccSubNames] where AccSubTypeID=" + int.Parse(ddlSubTypeID.SelectedValue) + " and AccFundID=" + int.Parse(ddlcompany.SelectedValue) + " Order by AccSubName ", con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        ddlAccSubCode.DataSource = dt;
        ddlAccSubCode.DataTextField = "AccSubName";
        ddlAccSubCode.DataValueField = "AccSubCode";
        ddlAccSubCode.DataBind();
        ddlAccSubCode.Items.Insert(0, new ListItem("--Select Subsidiary Code--", ""));
        
    }

    public void getACCCode()
    {
        con = new SqlConnection(conr);
        SqlDataAdapter adpt = new SqlDataAdapter("SELECT  [CoaDetailID],[AccName] FROM [dbo].[CoaDetail] where SubsYN=1 and AccSubTypeID=" + int.Parse(ddlSubTypeID.SelectedValue), con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        ddlACCCode.DataSource = dt;
        ddlACCCode.DataTextField = "AccName";
        ddlACCCode.DataValueField = "CoaDetailID";
        ddlACCCode.DataBind();
        ddlACCCode.Items.Insert(0, new ListItem("--Select Acc  Code--", ""));

    }

    protected void ddlSubTypeID_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(!string.IsNullOrEmpty(ddlSubTypeID.SelectedValue) && !string.IsNullOrEmpty(ddlcompany.SelectedValue))
        {
            getACCsubCode();
            getACCCode();
        }
    }
     static int Accsubcode1 = 0;
   static int Accsubcode2 = 0;
    protected void chkAll_CheckedChanged(object sender, EventArgs e)
    {
        if(chkAll.Checked==true)
        {
            ddlAccSubCode.SelectedIndex = 1;
            ListItem IstItem = ddlAccSubCode.Items[ddlAccSubCode.SelectedIndex];
            Accsubcode1 =int.Parse( IstItem.Value);
            ListItem lastItem = ddlAccSubCode.Items[ddlAccSubCode.Items.Count - 1];
            Accsubcode2 = int.Parse( lastItem.Value);
           
        }
        else
        {
            if (!string.IsNullOrEmpty(ddlAccSubCode.SelectedValue) )
            {
                Accsubcode1 = int.Parse(ddlAccSubCode.SelectedValue);
                Accsubcode2 = int.Parse(ddlAccSubCode.SelectedValue);
            }
            else
            {
                Label1.Text = "Please select ACC sub code";
            }
        }

    }
    private DataTable getdata(int com, int sub, int sub2, int code, DateTime start, DateTime end, int accfund)
    {
        DataTable dt = new DataTable();
        string conr = System.Configuration.ConfigurationManager.ConnectionStrings["MyCompany"].ConnectionString;
        SqlConnection con = new SqlConnection(conr);
        {
            SqlCommand cmd = new SqlCommand("USP_Subsidiary_LedgerSup", con);
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
        //DateTime dtDate = Convert.ToDateTime(txtDate.Text.Trim());
        int com = Convert.ToInt32(ddlSubTypeID.SelectedValue.ToString());
        int sub =int.Parse( ddlAccSubCode.SelectedValue);
        int sub2 = int.Parse(ddlAccSubCode.SelectedValue);
        int code = Convert.ToInt32(ddlACCCode.SelectedValue.ToString());
        DateTime start = Convert.ToDateTime(txtfrmDate.Text);
        DateTime year = Convert.ToDateTime(txtTodate.Text);
        int accfund = Convert.ToInt32(ddlcompany.SelectedValue.ToString());



        DataTable dt = getdata(com, sub, sub2, code, start, year, accfund);
        ReportDataSource rds = new ReportDataSource("DataSet1", dt);

        ReportViewer1.LocalReport.DataSources.Add(rds);
        ReportViewer1.LocalReport.ReportPath = new DirectoryInfo(HttpContext.Current.Server.MapPath("~/")).Parent.FullName + "\\MyCompany\\Reports\\USPSUBSIDIARY_Ledger.rdlc";
            
            //Server.MapPath("/Controls/") + "USPSUBSIDIARY_Ledger.rdlc";
        //ReportViewer1.LocalReport.ReportPath = Server.MapPath("../Controls/") + "SalarySheet.rdlc";
        //string ReportPath = new DirectoryInfo(HttpContext.Current.Server.MapPath("~/")).Parent.FullName + "\\IPACSOFT\\Reports\\SalarySheet.rdlc";

        //ReportViewer1.LocalReport.ReportPath = ReportPath;
        ReportViewer1.LocalReport.Refresh();
        ReportParameter[] rptparameter = new ReportParameter[]
            {
                   new ReportParameter("Start_Date",start.ToString()),
                new ReportParameter("End_Date",year.ToString())
          
             
                                
            };
        ReportViewer1.LocalReport.SetParameters(rptparameter);
        ReportViewer1.LocalReport.Refresh();
        string PDFPath = new DirectoryInfo(HttpContext.Current.Server.MapPath("~/")).Parent.FullName + "\\WebApp\\PDF\\";
        Microsoft.Reporting.WebForms.Warning[] warnings = null;
        string[] streamids = null;
        String mimeType = null;
        String encoding = null;
        String extension = null;
        Byte[] bytes = null;

        //  string fileName = string.Format("{0:yyyy-MM-dd_hh-mm-ss-tt}", DateTime.Now);

        fileName = "USPSUBSIDIARY_Ledger" + DateTime.Now.ToFileTime() + ".pdf";


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
    protected void Button1_Click1(object sender, EventArgs e)
    {
        showReport();
    }
    protected void clear()
    {

        ddlcompany.SelectedIndex = 0;
        txtfrmDate.Text = "";
        txtTodate.Text = "";
        ddlcompany.Enabled = true;
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
    }
   
}
