﻿using Microsoft.Reporting.WebForms;
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



public partial class Controls_ChequeVoidReport : System.Web.UI.UserControl
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
            PagesHeader.Visible = true;
            rptHeader.Visible = false;
            int accfund = 3;
            if (!string.IsNullOrEmpty(ad.CompanyID.ToString()))
            {
                accfund = int.Parse(ad.CompanyID.ToString());
            }

            getBankName(accfund);
        }
    }



    public void getBankName(int coaDetailID)
    {

        con = new SqlConnection(conr);
        SqlDataAdapter adpt = new SqlDataAdapter("select CoaDetailID, BankName FROM CoaDetail where IsBankNature=1 and BankName is Not null and AccFundID=" + coaDetailID + "", con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        ddlCoaDetail.DataSource = dt;
        ddlCoaDetail.DataTextField = "BankName";
        ddlCoaDetail.DataValueField = "CoaDetailID";
        ddlCoaDetail.DataBind();
        ddlCoaDetail.Items.Insert(0, new ListItem("Select", ""));
    }

    public void GetCheckBook(int CodetailID)
    {
       
        con = new SqlConnection(conr);
        SqlDataAdapter Sdr = new SqlDataAdapter("select distinct C.ChequeBookID as CbookID, ChequeBookNo FROM ChequeBooks C join [ChequeBooksLeaf] L on" +
        " C.[ChequeBookID]=L.[ChequeBookID]  where  [IsVoid]=1 and  C.CoaDetailID=" + CodetailID + "", con);
        DataTable dat = new DataTable();
        Sdr.Fill(dat);
        ddlCheckBook.DataSource = dat;
        ddlCheckBook.DataTextField = "ChequeBookNo";
        ddlCheckBook.DataValueField = "CbookID";
        ddlCheckBook.DataBind();
        ddlCheckBook.Items.Insert(0, new ListItem("Select", ""));


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

  

    private DataTable getCashBookdata(int accFund, DateTime frmDate, DateTime toDate,int BankName,int ChecqueNo)
    {
        DataTable dt = new DataTable();

        con = new SqlConnection(conr);
        {
            SqlCommand cmd = new SqlCommand("RPT_ChequeVoidCancellation", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@AccFundID", SqlDbType.Int).Value = accFund;
            cmd.Parameters.Add("@FromDate", SqlDbType.DateTime).Value = frmDate;
            cmd.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = toDate;
            cmd.Parameters.Add("@BankID", SqlDbType.Int).Value = BankName;
            cmd.Parameters.Add("@ChequeBookID", SqlDbType.Int).Value = ChecqueNo;


            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.Fill(dt);
        }


        return dt;
    }
    private void showReport()
    {

        if (string.IsNullOrEmpty(ddlCoaDetail.SelectedValue))
        {
            lblerror.Text = "Please Select Bank Name ";
            return;
        }

        if (string.IsNullOrEmpty(ddlCheckBook.SelectedValue))
        {
            lblerror.Text = "Please Select Cheque Book NO";
            return;
        }

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

            int BankName = int.Parse(ddlCoaDetail.SelectedValue);
            int ChecqueNo = int.Parse(ddlCheckBook.SelectedValue);

            dt = getCashBookdata(accfund, Convert.ToDateTime(txtFrmDate.Text), Convert.ToDateTime(txtTodate.Text),BankName,ChecqueNo);
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);

            ReportViewer1.LocalReport.DataSources.Add(rds);

            ReportViewer1.LocalReport.ReportPath = new DirectoryInfo(HttpContext.Current.Server.MapPath("/Controls/")) + "ChequeVoide.rdlc";
            //Server.MapPath("/Controls/") + "CashBook.rdlc";

            ReportParameter[] rptParametter = new ReportParameter[]
            {
                new ReportParameter("FromDate",txtFrmDate.Text),
                new ReportParameter("ToDate",txtTodate.Text)
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

            fileName = "CashBook" + DateTime.Now.ToFileTime() + ".pdf";


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
    protected void btn_ShowReport_Click(object sender, EventArgs e)
    {
        showReport();
    }

    protected void clear()
    {

        // ddlCom.SelectedIndex = 0;
        txtFrmDate.Text = "";
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
    protected void return_ChequeVoidReport_Click(object sender, EventArgs e)
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
        Response.Redirect("~/Pages/ChequeVoidReport.aspx");
    }

    protected void ddlCoaDetail_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(ddlCoaDetail.SelectedValue))
            GetCheckBook(int.Parse(ddlCoaDetail.SelectedValue));
    }
}
