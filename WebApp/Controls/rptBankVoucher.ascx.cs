using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Controls_rptBankVoucher : System.Web.UI.UserControl
{
    private SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyCompany"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ReportViewer1.Reset();

            SqlDataAdapter da = new SqlDataAdapter(" select  AccDestID,AccDest from AccDests", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            ReportDataSource rdc = new ReportDataSource("IPACERPDataSet", dt);

            ReportViewer1.LocalReport.DataSources.Add(rdc);
            // SqlDataAdapter adpt = new SqlDataAdapter("", conn);

            //           DataSet ds = new DataSet();
            //         adpt.Fill(ds);

            

            string ReportPath = new DirectoryInfo(HttpContext.Current.Server.MapPath("~/")).Parent.FullName + "\\MyCompany\\Reports\\BankVoucher.rdlc";
            ReportViewer1.LocalReport.ReportPath = ReportPath;
            ReportViewer1.LocalReport.Refresh();


        }


    }
    //private DataTable getdata()
    //{ }
}
