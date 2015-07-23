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



public partial class Controls_ImprestFundReimbursmentBill : System.Web.UI.UserControl
{
    string conr = ConfigurationManager.ConnectionStrings["MyCompany"].ConnectionString;
    SqlConnection con;
    private ReportParameter rptparameter;
    static string fileName;
    static string PdfLocation;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection(conr);
        if (!IsPostBack)
        {
            getImprestFund();
            txtFrDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
            txtToDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }
    }
    public void getImprestFund()
    {
        try
        {
            SqlDataAdapter adpt = new SqlDataAdapter(" Select ImpresstFundID, a.AccSubName from ImpresstFund i inner join AccSubNames a on i.AccSubCode=a.AccSubCode", con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            ddlImprestFund.DataSource = dt;
            ddlImprestFund.DataTextField = "AccSubName";
            ddlImprestFund.DataValueField = "ImpresstFundID";
            ddlImprestFund.DataBind();
            ddlImprestFund.Items.Insert(0, new ListItem("Select", ""));
        }
        catch (Exception  ex)
        {
            lblmsg.Text = ex.Message;
        }
    }


    private void showReport()
    {
        try
        {
            ReportViewer1.Reset();
            DataTable dt = getdata(int.Parse(ddlImprestFund.SelectedValue), DateTime.Parse(txtFrDate.Text), DateTime.Parse(txtToDate.Text));
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);

            ReportViewer1.LocalReport.DataSources.Add(rds);
            ReportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(ImprestFundPosition);
            ReportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(CoinCounting);
            //ReportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(costingPreCostingValue);

            ReportViewer1.LocalReport.ReportPath = Server.MapPath("/Controls/") + "ImprestFundReimbursmentBill.rdlc";

            ReportParameter[] rptparameter = new ReportParameter[]
                {
                     new ReportParameter("ImprestFundID",ddlImprestFund.Text),
                     new ReportParameter("FrDate",txtFrDate.Text),
                     new ReportParameter("ToDate",txtToDate.Text)

                };
            ReportViewer1.LocalReport.SetParameters(rptparameter);
            ReportViewer1.LocalReport.Refresh();





        //    string PDFPath = new DirectoryInfo(HttpContext.Current.Server.MapPath("~/")) + "PDF\\";
          //  Microsoft.Reporting.WebForms.Warning[] warnings = null;
        //    string[] streamids = null;
        //    String mimeType = null;
     //       String encoding = null;
         //   String extension = null;
         //   Byte[] bytes = null;

         //   //  string fileName = string.Format("{0:yyyy-MM-dd_hh-mm-ss-tt}", DateTime.Now);

       //     fileName = "ImprestFundReimbursmentBill" + DateTime.Now.ToFileTime() + ".pdf";


      //      bytes = ReportViewer1.LocalReport.Render("PDF", "", out mimeType, out encoding, out extension, out streamids, out warnings);
        //    bool IsExitsPDF = File.Exists(PDFPath + fileName);
//
      //      FileStream fs = new FileStream(PDFPath + fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
       //     byte[] data = new byte[fs.Length];
       //     fs.Write(bytes, 0, bytes.Length);
         //   fs.Close();
         //   PdfLocation = PDFPath + fileName;

         //   report.Attributes.Add("src", "../PDF/" + fileName);
        }
        catch (Exception ex)
        {
            lblmsg.Text = ex.Message;
        }
    }

    void ImprestFundPosition(object sender, SubreportProcessingEventArgs e)
    {
        try
        {
            int ImprestFundID = int.Parse(ddlImprestFund.SelectedValue);
            DateTime FrDate = DateTime.Parse(txtFrDate.Text);
            DateTime ToDate = DateTime.Parse(txtToDate.Text);
            DataTable dts = getFundPosition(ImprestFundID, FrDate, ToDate);
            ReportDataSource ds = new ReportDataSource("DataSet2", dts);
            e.DataSources.Add(ds);
        }
        catch (Exception ex)
        {
            lblmsg.Text = ex.Message;
        }

    }

    private DataTable getFundPosition(int ImprestFundID, DateTime FrDate, DateTime ToDate)
    {
       
            DataTable dt = new DataTable();

            con = new SqlConnection(conr);
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("USP_ImprestFundPosition", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@ImprestFundID", SqlDbType.Int).Value = ImprestFundID;
                    cmd.Parameters.Add("@FrDate", SqlDbType.DateTime).Value = FrDate;
                    cmd.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = ToDate;
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    adpt.Fill(dt);
                }
                catch (Exception ex)
                {
                    lblmsg.Text = ex.Message;
                }
            }
            return dt;
       
    }

    void CoinCounting(object sender, SubreportProcessingEventArgs e)
    {
        try
        {           
            DateTime ToDate = DateTime.Parse(txtToDate.Text);
            int ImprestFundID = int.Parse(ddlImprestFund.SelectedValue);
            DataTable dts = GetCoinCounting(ImprestFundID,ToDate);
            ReportDataSource ds = new ReportDataSource("DataSet3", dts);
            e.DataSources.Add(ds);
        }
        catch (Exception ex)
        {
            lblmsg.Text = ex.Message;
        }
    }


    private DataTable GetCoinCounting(int ImprestFundID,DateTime ToDate)
    {
       
            DataTable dt = new DataTable();

            con = new SqlConnection(conr);
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("USP_Coin_Calculation", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@ImprestFundID", SqlDbType.Int).Value = ImprestFundID;
                    cmd.Parameters.Add("@CalDate", SqlDbType.DateTime).Value = ToDate;
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    adpt.Fill(dt);
                
                 }
                catch(Exception  ex)
                {
                    lblmsg.Text = ex.Message;
                }
            }
            return dt;
        
        
    }
    private DataTable getdata(int imprestID, DateTime FrDate,DateTime ToDate)
    {
          DataTable dt = new DataTable();
            con = new SqlConnection(conr);
            {
                try
                {
                SqlCommand cmd = new SqlCommand("USP_Imprest_Fund_Reimbursment_Bill", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ImprestFundID", SqlDbType.Int).Value = imprestID;
                cmd.Parameters.Add("@FrDate", SqlDbType.DateTime).Value = FrDate;
                cmd.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = ToDate;


                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(dt);
                }
                catch(Exception  ex)
                {
                    lblmsg.Text = ex.Message;
                }
            }
            return dt;        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if(string.IsNullOrEmpty(ddlImprestFund.SelectedValue.Trim()))
        {
            lblmsg.Text = "Please Select Imprest Fund.";
            return;
        }
        else if (string.IsNullOrEmpty(txtFrDate.Text.Trim()))
        {
            lblmsg.Text = "Please Select From Date.";
            return;
        }
        else if (string.IsNullOrEmpty(txtToDate.Text.Trim()))
        {
            lblmsg.Text = "Please Select To Date.";
            return;
        }
        else
        {
            showReport();
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
            //PagesHeader.Visible = true;
            //rptHeader.Visible = false;
            clear();
            Response.Redirect("~/Pages/ImprestFundReimbursmentBill.aspx");
        }
        catch (Exception ex)
        {
            lblmsg.Text = ex.Message;
        }
    }

    protected void clear()
    {
        try
        {

            // ddlCom.SelectedIndex = 0;
            //txtFrmDate.Text = "";
            //txtTodate.Text = "";
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
        catch (Exception ex)
        {
            lblmsg.Text = ex.Message;
        }


    }
}
