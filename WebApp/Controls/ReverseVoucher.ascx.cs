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
using System.Globalization;

/// <summary>
/// Author:         Mehedi Hasan
/// Created Date:   23-JUNE-2015
/// Complete Date : June-2015
/// </summary>
public partial class Controls_ReverseVoucher : System.Web.UI.UserControl
{
    private SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyCompany"].ConnectionString);
    static string VoucherTypeCodeFind;
    static int EditVoucherID;
    static DataTable dtCurrentTable;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Companny_find();
            VoucherTypes_find();
            ReverseHeader.Visible = false;
            lbl_SMsgg.Visible = false;
        }


    }
    MyCompany.Rules.SharedBusinessRules ad = new MyCompany.Rules.SharedBusinessRules();
    private void Companny_find()
    {
        int accfund = 3;
        if (!string.IsNullOrEmpty(ad.CompanyID.ToString()))
        {
            accfund = int.Parse(ad.CompanyID.ToString());
        }
     
        SqlDataAdapter da = new SqlDataAdapter("USP_AccFundsbyKey", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.Add("@AccFundID", SqlDbType.Int).Value = 0;
        DataTable dt = new DataTable();
        da.Fill(dt);
        DDLCompany_Name_Find.DataSource = dt;
        DDLCompany_Name_Find.DataTextField = "AccFundName";
        DDLCompany_Name_Find.DataValueField = "AccFundID";
        DDLCompany_Name_Find.DataBind();

        DDLCompany_Name_Find.Items.Insert(0, new ListItem("Select", "0"));
        DDLCompany_Name_Find.SelectedValue = accfund.ToString();
       

    }
    private void VoucherTypes_find()
    {
        string SQL1 = "SELECT * FROM VoucherTypes";// WHERE VchrTypeID= 1";
        SqlDataAdapter adpt1 = new SqlDataAdapter(SQL1, conn);
        DataTable dt1 = new DataTable();
        adpt1.Fill(dt1);
        DDLVoucherType_Find.DataSource = dt1;
        DDLVoucherType_Find.DataTextField = "VchrTypeDesc";
        DDLVoucherType_Find.DataValueField = "vchrTypeID";//
        DDLVoucherType_Find.DataBind();
        DDLVoucherType_Find.Items.Insert(0, new ListItem("Select Voucher Types", "0"));
                

    }
    protected void Find_Voucher_Data(object sender, EventArgs e)
    {
        lbl_SMsgg.Visible = false;
        GV_VoucherFind_bind();
    }
    private void GV_VoucherFind_bind()
    {
        try
        {
            conn.Open();
            string SQL_VoucherType = "SELECT * FROM VoucherTypes WHERE VchrTypeID=" + DDLVoucherType_Find.SelectedValue;
            SqlDataAdapter data_VoucherType = new SqlDataAdapter(SQL_VoucherType, conn);
            data_VoucherType.SelectCommand.CommandType = CommandType.Text;
            DataTable VoucherType = new DataTable();
            data_VoucherType.Fill(VoucherType);
            VoucherTypeCodeFind = "";
            VoucherTypeCodeFind = Convert.ToString(VoucherType.Rows[0]["vchrType"]);


            string SQL = "SELECT [AccVoucherTranID],[AccFundCode],[VchrTypesID],[VchrNumber],[AccTranRef],[RefNo],[AccTranDate],[PaidTo],[AccRemarks],[YrClosing],[Voucher_Check],[Voucher_EditBy],[Voucher_EditTime],[Voucher_InstBy],[Voucher_InstTime],[DLT],[VchrType],[AccUnitCode],[VchrPreFix],[VNO],[CostCenterID] ,[FinancialYearID]  FROM [dbo].[AccTrnHeader] WHERE ";

            if (txt_CVoucher_No_Find.Text != "")
            {
                SQL += " [VchrNumber] LIKE '%" + txt_CVoucher_No_Find.Text + "%' AND [AccFundCode]= " + DDLCompany_Name_Find.SelectedValue + "  AND VchrTypesID=" + DDLVoucherType_Find.SelectedValue + "";
            }
            else
            {
                SQL += " VchrTypesID=" + DDLVoucherType_Find.SelectedValue + " AND [AccFundCode] = " + DDLCompany_Name_Find.SelectedValue + "";
            }

            SQL += " ORDER BY [VchrNumber] DESC";
            SqlDataAdapter da = new SqlDataAdapter(SQL, conn);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);

            GV_VoucherFind.DataSource = dt;
            GV_VoucherFind.DataBind();
        }
        catch (Exception ex)
        {
            PopUp("Please check your input" + ex.Message.ToString());
        }

    }

    protected void GV_VoucherFind_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GV_VoucherFind.PageIndex = e.NewPageIndex;
        GV_VoucherFind_bind();
    }
    protected void GV_VoucherFind_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
            e.Row.Attributes.Add("onClick", Page.ClientScript.GetPostBackEventReference(sender as GridView, "Select$" + e.Row.RowIndex.ToString()));
        //Add CSS class on header row.
        if (e.Row.RowType == DataControlRowType.Header)
            e.Row.CssClass = "header";

        //Add CSS class on normal row.
        if (e.Row.RowType == DataControlRowType.DataRow &&
                  e.Row.RowState == DataControlRowState.Normal)
            e.Row.CssClass = "normal";

        //Add CSS class on alternate row.
        if (e.Row.RowType == DataControlRowType.DataRow &&
                  e.Row.RowState == DataControlRowState.Alternate)
            e.Row.CssClass = "alternate";
    }
    protected void GV_VoucherFind_SelectedIndexChanged(object sender, EventArgs e)
    {

        Find_Voucher_Form.Visible = false;
        Find_Details.Visible = true;

        EditVoucherID = 0;
        EditVoucherID = Convert.ToInt32(GV_VoucherFind.SelectedDataKey["AccVoucherTranID"].ToString());
        GV_Voucher_Details_bind();
        ReverseHeader.Visible = true;

    }

    public void PopUp(string sMsg)
    {
        ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), Guid.NewGuid().ToString(), "alert('" + sMsg + "');", true);
    }


    private void GV_Voucher_Details_bind()
    {
        try
        {
            conn.Open();
            string SQL = "SELECT [VchrNo], [AccTrnDetailID],[AccVoucherTranID],[AccFundID],[Tran_Comment],[Chequeno],[VchrTypeID],[AccTranDate],[AccCode],(Select Accname from dbo.Coadetail where CoaDetailID = D.AccCode) as HeadAccount,[Debit],[Credit],[RevAcc],[IsPosted],[IsRevtran],[IsTransitReceived] FROM [dbo].[AccTrnDetail] D where IsPosted = 0 AND";

            SQL += " AccVoucherTranID='" + EditVoucherID + "' AND AccFundID='" + DDLCompany_Name_Find.SelectedValue + "' AND VchrTypeID='" + DDLVoucherType_Find.SelectedValue + "'";

            SQL += " ORDER BY [VchrNo] DESC";

            SqlDataAdapter da = new SqlDataAdapter(SQL, conn);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            GV_Voucher_Details_Find.DataSource = dt;
            dtCurrentTable = dt;
            GV_Voucher_Details_Find.DataBind();
        }
        catch (Exception ex)
        {
            //   lblMsg.Text = "";
            //  lblMsg.Text = "Please Select Again ";
            PopUp("Please Select Again" + ex.Message.ToString());

        }

    }
    protected void GV_Voucher_Details_Find_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GV_Voucher_Details_Find.PageIndex = e.NewPageIndex;
        GV_Voucher_Details_bind();
    }
    protected void GV_Voucher_Details_Find_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
            e.Row.Attributes.Add("onClick", Page.ClientScript.GetPostBackEventReference(sender as GridView, "Select$" + e.Row.RowIndex.ToString()));
        //Add CSS class on header row.
        if (e.Row.RowType == DataControlRowType.Header)
            e.Row.CssClass = "header";

        //Add CSS class on normal row.
        if (e.Row.RowType == DataControlRowType.DataRow &&
                  e.Row.RowState == DataControlRowState.Normal)
            e.Row.CssClass = "normal";

        //Add CSS class on alternate row.
        if (e.Row.RowType == DataControlRowType.DataRow &&
                  e.Row.RowState == DataControlRowState.Alternate)
            e.Row.CssClass = "alternate";
    }
    protected void GV_Voucher_Details_Find_SelectedIndexChanged(object sender, EventArgs e)
    {


        Find_Voucher_Form.Visible = false;



    }

    protected void Reverse_Voucher(object sender, EventArgs e)
    {

        Find_Voucher_Form.Visible = true;
        Find_Details.Visible = false;
        string[] headerinfo = new string[5];
        headerinfo[0] = DDLCompany_Name_Find.SelectedValue;
        headerinfo[1] = DDLVoucherType_Find.SelectedValue;
        headerinfo[2] = VoucherTypeCodeFind;
        headerinfo[3] = "Reverse";
        try
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            SqlTransaction Transection = conn.BeginTransaction();
            for (int irows = 1; dtCurrentTable.Rows.Count >= irows; irows++)
            {
                cmd = new SqlCommand();
                //EXEC USP_Reverse_Voucher 100,0,6,'JV',319,'Reverse'

                cmd.Parameters.Add("@AccTrnDetailID", SqlDbType.Money).Value = dtCurrentTable.Rows[irows - 1]["AccTrnDetailID"];

                cmd.Parameters.Add("@Debit", SqlDbType.Money).Value = dtCurrentTable.Rows[irows - 1]["Credit"];

                cmd.Parameters.Add("@Credit", SqlDbType.Money).Value = dtCurrentTable.Rows[irows - 1]["Debit"];


                if (headerinfo[2] == "CP")
                {
                    cmd.Parameters.Add("@VchrTypeID", SqlDbType.Int).Value = 2;
                    cmd.Parameters.Add("@VchrType", SqlDbType.VarChar).Value = "CR";
                }
                else if (headerinfo[2] == "BP")
                {
                    cmd.Parameters.Add("@VchrTypeID", SqlDbType.Int).Value = 4;
                    cmd.Parameters.Add("@VchrType", SqlDbType.VarChar).Value = "BR";
                }
                else if (headerinfo[2] == "CR")
                {
                    cmd.Parameters.Add("@VchrTypeID", SqlDbType.Int).Value = 1;
                    cmd.Parameters.Add("@VchrType", SqlDbType.VarChar).Value = "CP";
                }
                else if (headerinfo[2] == "BR")
                {
                    cmd.Parameters.Add("@VchrTypeID", SqlDbType.Int).Value = 3;
                    cmd.Parameters.Add("@VchrType", SqlDbType.VarChar).Value = "BP";
                }
                else if (headerinfo[2] == "JV")
                {
                    cmd.Parameters.Add("@VchrTypeID", SqlDbType.Int).Value = 6;
                    cmd.Parameters.Add("@VchrType", SqlDbType.VarChar).Value = "JV";
                }
                else
                {
                    cmd.Parameters.Add("@VchrTypeID", SqlDbType.Int).Value = 0;
                    cmd.Parameters.Add("@VchrType", SqlDbType.VarChar).Value = headerinfo[2];

                }

                cmd.Parameters.Add("@AccVoucherTranID", SqlDbType.Int).Value = EditVoucherID;
                cmd.Parameters.Add("@RefNo", SqlDbType.VarChar).Value = headerinfo[3];
                cmd.Transaction = Transection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "USP_Reverse_Voucher";
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();

            }



            Transection.Commit();
        }

        catch (Exception ex)
        {
            PopUp("Voucher Reverse is NOT Sucessfull for intrenal Prosses. Please Try again.  " + ex.Message.ToString());

        }
        lblMsg.Text = "";
        lblMsg.Text = "Reverse Is Sucessfull";
        conn.Close();
        lbl_SMsgg.Text = lblMsg.Text;
        lbl_SMsgg.Visible = true;
        Clear();



    }
    protected void Clear()
    {

        txt_CVoucher_No_Find.Text = "";
        dtCurrentTable = null;
        EditVoucherID = 0;
        ReverseHeader.Visible = false;
        GV_VoucherFind.DataSource = null;

        GV_VoucherFind_bind();
        GV_Voucher_Details_Find.DataSource = null;
    }
    protected void Return_Back(object sender, EventArgs e)
    {
        Clear();
        Response.Redirect("~/Pages/ReverseVoucher.aspx");
    }

}
