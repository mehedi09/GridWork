using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Drawing;
using System.Web.Security;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using Microsoft.Reporting.WebForms;
using System.IO;
using System.Web.Script.Serialization;

public partial class Controls_rptBankPaymentVoucher : System.Web.UI.UserControl
{
    private SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyCompany"].ConnectionString);


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            date_time.Visible = false;// table row visiable for system date if need you can visible it true
            Companny();

        }
    }
    MyCompany.Rules.SharedBusinessRules ad = new MyCompany.Rules.SharedBusinessRules();
    private void Companny()
    {
        int accfund = 3;
        if (!string.IsNullOrEmpty(ad.CompanyID.ToString()))
        {
            accfund = int.Parse(ad.CompanyID.ToString());
        }
        #region Dropdown of Companny
        conn.Open();
        SqlDataAdapter da = new SqlDataAdapter("USP_AccFundsbyKey", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.Add("@AccFundID", SqlDbType.Int).Value = 0;
        DataTable dt = new DataTable();
        da.Fill(dt);
        DDLCompany_Name.DataSource = dt;
        DDLCompany_Name.DataTextField = "AccFundName";
        DDLCompany_Name.DataValueField = "AccFundID";
        conn.Close();
        DDLCompany_Name.DataBind();
        DDLCompany_Name.Items.Insert(0, new System.Web.UI.WebControls.ListItem("Select", "0"));
        DDLCompany_Name.SelectedValue = accfund.ToString();
        #endregion
    }

    protected void DDLCompany_Name_SelectedIndexChanged(object sender, EventArgs e)
    {
        VoucherTypes();

    }

    private void VoucherTypes()
    {
        #region Dropdown of VoucherTypes
        conn.Open();
        string SQL1 = "SELECT * FROM VoucherTypes WHERE VchrTypeID = 3 ORDER BY VchrTypeDesc ASC";
        SqlDataAdapter adpt1 = new SqlDataAdapter(SQL1, conn);
        DataTable dt1 = new DataTable();
        adpt1.Fill(dt1);
        DDLVoucherType.DataSource = dt1;
        DDLVoucherType.DataTextField = "VchrTypeDesc";
        DDLVoucherType.DataValueField = "vchrTypeID";//
        conn.Close();
        DDLVoucherType.DataBind();

        DDLVoucherType.Items.Insert(0, new System.Web.UI.WebControls.ListItem("Select", "0"));
        #endregion
    }

    protected void DDLVoucherType_SelectedIndexChanged(object sender, EventArgs e)
    {
        CashBankSourceLoad();

    }


    private void CashBankSourceLoad()
    {
        string sql2 = "SELECT * FROM VoucherTypes WHERE VchrTypeID=" + DDLVoucherType.SelectedValue;
        SqlDataAdapter data2 = new SqlDataAdapter(sql2, conn);
        data2.SelectCommand.CommandType = CommandType.Text;
        DataTable VoucherType = new DataTable();
        data2.Fill(VoucherType);
        string VoucherTypeCode = Convert.ToString(VoucherType.Rows[0]["vchrType"]);

        if (VoucherTypeCode == "CP" || VoucherTypeCode == "CR")//CP,BP
        {
            // tr_FundSourse.Visible = true;
            //tr_Cash_Bank.Visible = true;


            SqlDataAdapter da = new SqlDataAdapter("BBLCashAccounts", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            DDLCashBankSource.DataSource = dt;
            DDLCashBankSource.DataTextField = "AccName";
            DDLCashBankSource.DataValueField = "CoaDetailID";
            DDLCashBankSource.DataBind();
            // DDLCashBankSource.Items.Insert(0, "Select");
            DDLCashBankSource.Items.Insert(0, new System.Web.UI.WebControls.ListItem("Select", "0"));

        }
        else if (VoucherTypeCode == "BP" || VoucherTypeCode == "BR")//CR BR
        {


            SqlDataAdapter da = new SqlDataAdapter("BBLBankAccounts", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            DDLCashBankSource.DataSource = dt;
            DDLCashBankSource.DataTextField = "AccName";
            DDLCashBankSource.DataValueField = "CoaDetailID";
            DDLCashBankSource.DataBind();
            //DDLCashBankSource.Items.Insert(0, "Select");
            DDLCashBankSource.Items.Insert(0, new System.Web.UI.WebControls.ListItem("Select", "0"));

        }
        else if (VoucherTypeCode == "TV")//5TV
        {

            // tr_FundSourse.Visible = true;
            // tr_Cash_Bank.Visible = true;

            SqlDataAdapter da = new SqlDataAdapter("BBL_Cash_Bank_Account", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            DDLCashBankSource.DataSource = dt;
            DDLCashBankSource.DataTextField = "AccName";
            DDLCashBankSource.DataValueField = "CoaDetailID";
            DDLCashBankSource.DataBind();
            //DDLCashBankSource.Items.Insert(0, "Select");
            DDLCashBankSource.Items.Insert(0, new System.Web.UI.WebControls.ListItem("Select", "0"));
        }
        else if (VoucherTypeCode == "JV")//6JV
        {
            //tr_FundSourse.Visible = false;
            // tr_Cash_Bank.Visible = false;
        }
        else if (VoucherTypeCode == "TS")//7TS
        {

        }
        else
        {

        }


    }


    private void VoucherNo()
    {
        #region Dropdown of VoucherNo
        conn.Open();
        //SELECT  Distinct[VchrNo],[AccTranRef],[AccVoucherTranID],AccFundID,[RevAcc],VchrTypeID FROM [AccTrnDetail] Where RevAcc=129 AND AccFundID = 3 AND VchrTypeID=1
        string SQL1 = "SELECT Distinct[VchrNo],[AccTranRef],[AccVoucherTranID],AccFundID,[RevAcc],VchrTypeID FROM [AccTrnDetail] Where RevAcc=" + DDLCashBankSource.SelectedValue + " AND AccFundID = " + DDLCompany_Name.SelectedValue + " AND VchrTypeID=" + DDLVoucherType.SelectedValue + "";
        SqlDataAdapter adpt1 = new SqlDataAdapter(SQL1, conn);
        DataTable dt1 = new DataTable();
        adpt1.Fill(dt1);
        DDLVoucherNo.DataSource = dt1;
        DDLVoucherNo.DataTextField = "VchrNo";
        DDLVoucherNo.DataValueField = "VchrNo";//AccTranRef
        conn.Close();
        DDLVoucherNo.DataBind();
        DDLVoucherNo.Items.Insert(0, new System.Web.UI.WebControls.ListItem("Select", "0"));
        #endregion
    }
    protected void DDLCashBankSource_SelectedIndexChanged(object sender, EventArgs e)
    {
        VoucherNo();
    }
    protected void Show_Report(object sender, EventArgs e)
    {
        #region Viewing Rdlc Report PorformaInvoice
        try
        {
            string[] perameter = new string[5];
            perameter[0] = DDLCompany_Name.SelectedValue;
            perameter[1] = DDLVoucherType.SelectedValue;
            perameter[2] = DDLCashBankSource.SelectedValue;
            perameter[3] = DDLVoucherNo.SelectedValue;
            Voucher_Date.Text = DateTime.Now.ToString();
            perameter[4] = Convert.ToDateTime(Voucher_Date.Text).ToString();



            ReportViewer1.Reset();
            DataTable dt = getdata(Convert.ToInt32(perameter[0]), Convert.ToInt32(perameter[1]), Convert.ToInt32(perameter[2]), Convert.ToString(perameter[3]), Convert.ToString(perameter[4]));//, perameter[1], perameter[2], perameter[3], perameter[4]);
            ReportDataSource rds = new ReportDataSource("DataGetVoucherPrintIPAC", dt);
            ReportViewer1.LocalReport.DataSources.Add(rds);

            string ReportPath = new DirectoryInfo(HttpContext.Current.Server.MapPath("~/")).Parent.FullName + "\\MyCompany\\Reports\\BankPaymentVoucher.rdlc";
            ReportViewer1.LocalReport.ReportPath = ReportPath;
            ReportParameter[] rptparameter = new ReportParameter[]
            {
                new ReportParameter("AccFundID",perameter[0]),
                new ReportParameter("VchrTypeID",perameter[1]),
                new ReportParameter("CashBookAcc",perameter[2]),
                new ReportParameter("VchrNumber",perameter[3]),
                new ReportParameter("Date", perameter[4])
            };

            ReportViewer1.LocalReport.SetParameters(rptparameter);
            ReportViewer1.LocalReport.Refresh();

            lblMsg.Text = null;
            lblMsg.Text = "If you want a Soft Copy of this report Please Download it";
            PopUp();
            
        }

        catch
        {
            return;
        }
        #endregion
    }
    public void PopUp()
    {
        ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), Guid.NewGuid().ToString(), "alert('" + lblMsg.Text + "');", true);
    }
    private DataTable getdata(int prm, int prm1, int prm2, string prm3, string prm4)
    {
        DataTable dt = new DataTable();
        {
            SqlCommand cmd = new SqlCommand("GetVoucherPrintIPAC", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@AccFundID", SqlDbType.Int).Value = Convert.ToInt32(prm);//companny Name
            cmd.Parameters.Add("@VchrTypeID", SqlDbType.Int).Value = Convert.ToInt32(prm1);
            cmd.Parameters.Add("@CashBookAcc", SqlDbType.Int).Value = Convert.ToInt32(prm2);
            cmd.Parameters.Add("@VchrNumber", SqlDbType.NVarChar).Value = prm3;
            cmd.Parameters.Add("@Date", SqlDbType.DateTime).Value = prm4;

            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.Fill(dt);
        }
        return dt;
    }


}
