using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;
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
/// Created Date:   April-2015
/// Complete Date : 15-June-2015
/// </summary>

public partial class Controls_CashPayment : System.Web.UI.UserControl
{
    private SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyCompany"].ConnectionString);
    DataTable dtTransactions = new DataTable();
    static DataTable dtCurrentTable;
    static DataTable dtOldTable;
    static int irows = 1;
    static DataTable SDTDelete;
    static int EditVoucherID;
    static int SaveNprintAccVoucherTranID;
    static string VoucherTypeCodeFind;
    static int EditAccVoucherTranID;
    static string VoucherTypeCode;
    static double Total_Sum;
    static DataTable dtreport;
    static int pVchrTypeID;
    static string fileName;
    static string PdfLocation;
    static int accfundID;
    static Boolean IsAddEditMode = true;
    static DataTable dtVchrTypes;
    static string sCashBankSource;

    MyCompany.Rules.SharedBusinessRules ad = new MyCompany.Rules.SharedBusinessRules();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            #region [Default Set]
            accfundID = 3;
            pVchrTypeID = 1;
            //dtVchrTypes = new DataTable();
            Gridview1.Visible = false;
            FromNSearch.Visible = true;
            ReportForm.Visible = false;
            LB_Voucher_Print.Visible = false;
            SaveNprintAccVoucherTranID = 0;
            Return_Voucher_btn.Visible = false;
            VC_Form.Visible = true;
            CP_Header.Visible = false;
            Find_Voucher_Form.Visible = false;
            lblDate.Text = DateTime.Now.ToString("dd,MMMM,yyyy");
            //FundSource();
            IsAddEditMode = true;

            txt_CheckNo.Visible = false;
            DDL_CheckNo.Visible = true;
            EditVoucher_Date.Text = DateTime.Now.ToString("dd/MM/yyyy");
            dtreport = new DataTable();
            SDTDelete = new DataTable();
            dtOldTable = new DataTable();
            dtCurrentTable = new DataTable();
            #endregion

            Companny();
            VoucherTypes();
            CashBankSourceLoad();
            Lbl_Last_VoucherNo.Text = "";

            LastVoucherNo();
            btn_delete.Visible = false;
        }
        else
        {
            //UpdatePanel1.Update();
        }
    }
    private void LastVoucherNo()
    {

        int LastVNo;
        CultureInfo cultureinfo = new CultureInfo("en-GB");
        DateTime data = DateTime.Parse(lblDate.Text, cultureinfo);
        string VchrDate = data.Month.ToString() + "/" + data.Day.ToString() + "/" + data.Year.ToString();

        string Date = VchrDate;
        string time = System.DateTime.Now.ToString("HH:mm:ss tt");
        string EditedDate = Date + " " + time;

        if (conn.State == 0)
        {
            conn.Open();
        }
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;

        cmd.Parameters.Add("@AccFundCode", SqlDbType.Int).Value = accfundID;
        cmd.Parameters.Add("@VDate", SqlDbType.DateTime).Value = EditedDate;
        cmd.Parameters.Add("@VTypeID", SqlDbType.Int).Value = pVchrTypeID;


        cmd.Parameters.Add("@GenVNo", SqlDbType.NVarChar, 50).Value = "0";
        cmd.Parameters["@GenVNo"].Direction = ParameterDirection.Output;

        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "GetLastVoucherNumber";

        LastVNo = cmd.ExecuteNonQuery();

        string LastVoucherNo = (string)cmd.Parameters["@GenVNo"].Value;
        Lbl_Last_VoucherNo.Text = LastVoucherNo;
    }
    private void VoucherTypes()
    {

        dtVchrTypes = new DataTable();
        string SQL1 = "SELECT * FROM VoucherTypes WHERE VchrTypeID = 1 ORDER BY VchrTypeDesc ASC";
        if (conn.State == 0)
        {
            conn.Open();
        }
        SqlDataAdapter adpt1 = new SqlDataAdapter(SQL1, conn);
        adpt1.Fill(dtVchrTypes);
        DDLVoucherType.DataSource = dtVchrTypes;
        DDLVoucherType.DataTextField = "VchrTypeDesc";
        DDLVoucherType.DataValueField = "vchrTypeID";//

        DDLVoucherType.DataBind();
        DDLVoucherType.Items.Insert(0, new ListItem("Select", ""));
        DDLVoucherType.SelectedValue = "1";


        VoucherTypeRead();
        Voucher_Type_Wise_Design();

    }

    private void VoucherTypeRead()
    {

        if (DDLVoucherType.SelectedValue != null)
            pVchrTypeID = Convert.ToInt32(DDLVoucherType.SelectedValue);

        if (dtVchrTypes.Rows.Count > 0)
        {
            for (int i = 1; dtVchrTypes.Rows.Count >= i; i++)
            {
                if (dtVchrTypes.Rows[i - 1]["VchrTypeID"] != DBNull.Value)
                {
                    int iVchrTypeID = Convert.ToInt32(dtVchrTypes.Rows[i - 1]["VchrTypeID"]);
                    if (iVchrTypeID == pVchrTypeID)
                    {
                        VoucherTypeCode = Convert.ToString(dtVchrTypes.Rows[i - 1]["vchrType"]);
                    }
                }
            }
        }
    }
    private void Companny()
    {

        if (!string.IsNullOrEmpty(ad.CompanyID.ToString()))
        {
            accfundID = int.Parse(ad.CompanyID.ToString());
        }
        if (conn.State == 0)
        {
            conn.Open();
        }
        SqlDataAdapter da = new SqlDataAdapter("USP_AccFundsbyKey", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.Add("@AccFundID", SqlDbType.Int).Value = 0;
        DataTable dt = new DataTable();
        try
        {
            da.Fill(dt);
        }
        catch (Exception ex)
        {
            PopUp("Company Data Load Problem......." + ex.Message);
            return;
        }

        DDLCompany_Name.DataSource = dt;
        DDLCompany_Name.DataTextField = "AccFundName";
        DDLCompany_Name.DataValueField = "AccFundID";

        DDLCompany_Name.DataBind();
        DDLCompany_Name.Items.Insert(0, new ListItem("Select", ""));
        DDLCompany_Name.SelectedValue = accfundID.ToString();
    }

    private void CheckNo()
    {
        sCashBankSource = Convert.ToString(DDLCashBankSource.SelectedValue);
        if (conn.State == 0)
        {
            conn.Open();
        }
        SqlDataAdapter da = new SqlDataAdapter("GetChequeBookLeaf", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.Add("@AccFundID", SqlDbType.Int).Value = accfundID;
        da.SelectCommand.Parameters.Add("@CoaDetailID", SqlDbType.Int).Value = sCashBankSource;
        DataTable dt = new DataTable();
        da.Fill(dt);
        DDL_CheckNo.DataSource = dt;
        DDL_CheckNo.DataTextField = "LeafNumber";
        DDL_CheckNo.DataValueField = "LeafID";
        DDL_CheckNo.DataBind();
        DDL_CheckNo.Items.Insert(0, new ListItem("Select", ""));

    }

    private void SetInitialRow()
    {
        if (dtCurrentTable == null)
        {
            dtCurrentTable = new DataTable();
            DataRow dr = null;
            dtCurrentTable.Columns.Add(new DataColumn("RowNumber", typeof(string)));
            dtCurrentTable.Columns.Add(new DataColumn("Transection_Ledger", typeof(string)));
            dtCurrentTable.Columns.Add(new DataColumn("Sub_Type", typeof(string)));
            dtCurrentTable.Columns.Add(new DataColumn("Sub_Ledger", typeof(string)));
            dtCurrentTable.Columns.Add(new DataColumn("Sub_Type1", typeof(string)));
            dtCurrentTable.Columns.Add(new DataColumn("Sub_Ledger1", typeof(string)));
            dtCurrentTable.Columns.Add(new DataColumn("Sub_Type2", typeof(string)));
            dtCurrentTable.Columns.Add(new DataColumn("Sub_Ledger2", typeof(string)));
            dtCurrentTable.Columns.Add(new DataColumn("Amount", typeof(string)));
            dtCurrentTable.Columns.Add(new DataColumn("Currency", typeof(string)));
            dtCurrentTable.Columns.Add(new DataColumn("Exchange_Rate", typeof(string)));
            dtCurrentTable.Columns.Add(new DataColumn("Transection_Memo", typeof(string)));

            dtCurrentTable.Columns.Add(new DataColumn("Old_Data", typeof(string)));
            dr = dtCurrentTable.NewRow();
            dr["RowNumber"] = irows;
            dr["Transection_Ledger"] = string.Empty;
            dr["Sub_Type"] = string.Empty;
            dr["Sub_Ledger"] = string.Empty;
            dr["Sub_Type1"] = string.Empty;
            dr["Sub_Ledger1"] = string.Empty;
            dr["Sub_Type2"] = string.Empty;
            dr["Sub_Ledger2"] = string.Empty;
            dr["Amount"] = string.Empty;
            dr["Currency"] = string.Empty;
            dr["Exchange_Rate"] = string.Empty;
            dr["Transection_Memo"] = string.Empty;
            dr["Old_Data"] = string.Empty;
            dtCurrentTable.Rows.Add(dr);
            Gridview1.DataSource = dtCurrentTable;
            Gridview1.DataBind();

            if (Gridview1.Rows.Count > 0)
            {
                for (int i = 0; i < Gridview1.Rows.Count; i++)
                {
                    if (!string.IsNullOrEmpty(DDLVoucherType.SelectedValue))
                    {
                        DropDownList DDLTransection_Ledger = (DropDownList)Gridview1.Rows[i].FindControl("DDLTransection_Ledger");
                        if (conn.State == 0)
                        {
                            conn.Open();
                        }
                        SqlDataAdapter da1 = new SqlDataAdapter("Usp_Vchr_ChartofAccFund", conn);
                        da1.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da1.SelectCommand.Parameters.Add("@AccFundCode", SqlDbType.Int).Value = accfundID.ToString();//3
                        da1.SelectCommand.Parameters.Add("@Vchr_Type", SqlDbType.Char).Value = "T";
                        DataTable Vchr_ChartofAccFund = new DataTable();
                        da1.Fill(Vchr_ChartofAccFund);
                        DDLTransection_Ledger.DataSource = Vchr_ChartofAccFund;
                        DDLTransection_Ledger.DataTextField = "AccName";
                        DDLTransection_Ledger.DataValueField = "CoaDetailID";
                        DDLTransection_Ledger.DataBind();
                        DDLTransection_Ledger.Items.Insert(0, new ListItem("--Select--", ""));
                    }
                }
            }

        }


    }

    private void SetInitialRowforEdit()
    {
        Gridview1.DataSource = dtCurrentTable;
        Gridview1.DataBind();

        if (Gridview1.Rows.Count > 0)
        {
            for (int rowIndex = 0; rowIndex < Gridview1.Rows.Count; rowIndex++)
            {
                DropDownList DDLTransection_Ledger = (DropDownList)Gridview1.Rows[rowIndex].Cells[1].FindControl("DDLTransection_Ledger");
                DropDownList DDLSub_Type = (DropDownList)Gridview1.Rows[rowIndex].Cells[2].FindControl("DDLSub_Type");
                DropDownList DDLSub_Ledger = (DropDownList)Gridview1.Rows[rowIndex].Cells[3].FindControl("DDLSub_Ledger");
                DropDownList DDLSub_Type1 = (DropDownList)Gridview1.Rows[rowIndex].Cells[4].FindControl("DDLSub_Type1");
                DropDownList DDLSub_Ledger1 = (DropDownList)Gridview1.Rows[rowIndex].Cells[5].FindControl("DDLSub_Ledger1");
                DropDownList DDLSub_Type2 = (DropDownList)Gridview1.Rows[rowIndex].Cells[6].FindControl("DDLSub_Type2");
                DropDownList DDLSub_Ledger2 = (DropDownList)Gridview1.Rows[rowIndex].Cells[7].FindControl("DDLSub_Ledger2");
                TextBox txt_Amount = (TextBox)Gridview1.Rows[rowIndex].Cells[8].FindControl("txt_Amount");
                DropDownList DDLCurrency = (DropDownList)Gridview1.Rows[rowIndex].Cells[9].FindControl("DDLCurrency");
                TextBox txt_Exchange_Rate = (TextBox)Gridview1.Rows[rowIndex].Cells[10].FindControl("txt_Exchange_Rate");

                TextBox txt_Transection_Memo = (TextBox)Gridview1.Rows[rowIndex].Cells[11].FindControl("txt_Transection_Memo");

                if (conn.State == 0)
                {
                    conn.Open();
                }
                SqlDataAdapter da1 = new SqlDataAdapter("Usp_Vchr_ChartofAccFund", conn);
                da1.SelectCommand.CommandType = CommandType.StoredProcedure;
                da1.SelectCommand.Parameters.Add("@AccFundCode", SqlDbType.Int).Value = accfundID.ToString();//3
                da1.SelectCommand.Parameters.Add("@Vchr_Type", SqlDbType.Char).Value = "D";
                DataTable Vchr_ChartofAccFund = new DataTable();
                da1.Fill(Vchr_ChartofAccFund);
                DDLTransection_Ledger.DataSource = Vchr_ChartofAccFund;
                DDLTransection_Ledger.DataTextField = "AccName";
                DDLTransection_Ledger.DataValueField = "CoaDetailID";
                DDLTransection_Ledger.DataBind();
                DDLTransection_Ledger.Items.Insert(0, new ListItem("--Select--", ""));

                DDLTransection_Ledger.SelectedValue = dtCurrentTable.Rows[rowIndex]["Transection_Ledger"].ToString();
                txt_Amount.Text = dtCurrentTable.Rows[rowIndex]["Amount"].ToString();
                DDLCurrency.SelectedValue = dtCurrentTable.Rows[rowIndex]["Currency"].ToString();
                txt_Exchange_Rate.Text = dtCurrentTable.Rows[rowIndex]["Exchange_Rate"].ToString();
                txt_Transection_Memo.Text = dtCurrentTable.Rows[rowIndex]["Transection_Memo"].ToString();


                string a = string.Empty;
                string sSubTypeID = "1";
                string sSubTypeID1 = "1";
                string sSubTypeID2 = "1";
                if (!string.IsNullOrEmpty(DDLTransection_Ledger.SelectedValue))
                {
                    string SQLSubTypeID = "SELECT CoaDetailID, AccSubTypeID,AccSubTypeID1,AccSubTypeID2 FROM CoaDetail where  CoaDetailID=" + DDLTransection_Ledger.SelectedValue + " AND AccFundID =" + DDLCompany_Name.SelectedValue;
                    if (conn.State == 0)
                    {
                        conn.Open();
                    }
                    SqlDataAdapter daa = new SqlDataAdapter(SQLSubTypeID, conn);
                    daa.SelectCommand.CommandType = CommandType.Text;
                    DataTable dtAccSubTypeID = new DataTable();
                    daa.Fill(dtAccSubTypeID);
                    DDLSub_Type.Enabled = true;
                    DDLSub_Type1.Enabled = true;
                    DDLSub_Type2.Enabled = true;


                    if (dtAccSubTypeID.Rows.Count > 0)
                    {
                        sSubTypeID = dtAccSubTypeID.Rows[0]["AccSubTypeID"].ToString();
                        if (sSubTypeID == "")
                        {
                            sSubTypeID = "1";
                        }
                        sSubTypeID1 = dtAccSubTypeID.Rows[0]["AccSubTypeID1"].ToString();
                        if (sSubTypeID1 == "")
                        {
                            sSubTypeID1 = "1";
                        }
                        sSubTypeID2 = dtAccSubTypeID.Rows[0]["AccSubTypeID2"].ToString();
                        if (sSubTypeID2 == "")
                        {
                            sSubTypeID2 = "1";
                        }

                        DDLSub_Type.DataSource = dtAccSubTypeID;
                        DDLSub_Type.DataTextField = "CoaDetailID";
                        DDLSub_Type.DataValueField = "AccSubTypeID";
                        DDLSub_Type.DataBind();
                        DDLSub_Type.Items.Insert(0, new ListItem("Select", ""));
                        DDLSub_Type.SelectedValue = dtCurrentTable.Rows[rowIndex]["Sub_Type"].ToString();
                        ///////////
                        DDLSub_Type1.DataSource = dtAccSubTypeID;
                        DDLSub_Type1.DataTextField = "CoaDetailID";
                        DDLSub_Type1.DataValueField = "AccSubTypeID1";
                        DDLSub_Type1.DataBind();
                        DDLSub_Type1.Items.Insert(0, new ListItem("Select", ""));
                        DDLSub_Type1.SelectedValue = dtCurrentTable.Rows[rowIndex]["Sub_Type1"].ToString();
                        ///////////////
                        DDLSub_Type2.DataSource = dtAccSubTypeID;
                        DDLSub_Type2.DataTextField = "CoaDetailID";
                        DDLSub_Type2.DataValueField = "AccSubTypeID2";
                        DDLSub_Type2.DataBind();
                        DDLSub_Type2.Items.Insert(0, new ListItem("Select", ""));
                        DDLSub_Type2.SelectedValue = dtCurrentTable.Rows[rowIndex]["Sub_Type2"].ToString();
                    }
                    //////////////////////////////////////////

                    string sql = "SELECT  [AccSubCode],[AccSubTypeID],[AccSubName],[AccFundID] FROM dbo.AccSubNames where AccSubTypeID=" + sSubTypeID + " AND AccFundID =" + accfundID.ToString() + " ORDER BY [AccSubName] ASC";
                    if (conn.State == 0)
                    {
                        conn.Open();
                    }
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    da.SelectCommand.CommandType = CommandType.Text;
                    DataTable dtsubledger = new DataTable();
                    da.Fill(dtsubledger);
                    if (dtsubledger.Rows.Count > 0)
                    {
                        DDLSub_Ledger.DataSource = dtsubledger;
                        DDLSub_Ledger.DataTextField = "AccSubName";
                        DDLSub_Ledger.DataValueField = "AccSubCode";
                        DDLSub_Ledger.DataBind();
                        DDLSub_Ledger.Items.Insert(0, new ListItem("Select", ""));
                        DDLSub_Ledger.SelectedValue = dtCurrentTable.Rows[rowIndex]["Sub_Ledger"].ToString();
                    }

                    ///////////////////

                    string sql1 = "SELECT  [AccSubCode],[AccSubTypeID],[AccSubName],[AccFundID] FROM dbo.AccSubNames where AccSubTypeID=" + sSubTypeID1 + " AND AccFundID =" + accfundID.ToString() + " ORDER BY [AccSubName] ASC";
                    if (conn.State == 0)
                    {
                        conn.Open();
                    }
                    SqlDataAdapter data1 = new SqlDataAdapter(sql1, conn);
                    data1.SelectCommand.CommandType = CommandType.Text;
                    DataTable dtsubledger1 = new DataTable();
                    data1.Fill(dtsubledger1);

                    if (dtsubledger1.Rows.Count > 0)
                    {
                        DDLSub_Ledger1.DataSource = dtsubledger1;
                        DDLSub_Ledger1.DataTextField = "AccSubName";
                        DDLSub_Ledger1.DataValueField = "AccSubCode";
                        DDLSub_Ledger1.DataBind();
                        DDLSub_Ledger1.Items.Insert(0, new ListItem("Select", ""));
                        DDLSub_Ledger1.SelectedValue = dtCurrentTable.Rows[rowIndex]["Sub_Ledger1"].ToString();
                    }

                    ///////////////////////////////

                    string sql2 = "SELECT  [AccSubCode],[AccSubTypeID],[AccSubName],[AccFundID] FROM dbo.AccSubNames where AccSubTypeID= " + sSubTypeID2 + " AND AccFundID =" + accfundID.ToString() + " ORDER BY [AccSubName] ASC";
                    if (conn.State == 0)
                    {
                        conn.Open();
                    }
                    SqlDataAdapter data2 = new SqlDataAdapter(sql2, conn);
                    data2.SelectCommand.CommandType = CommandType.Text;
                    DataTable dtsubledger2 = new DataTable();
                    data2.Fill(dtsubledger2);
                    if (dtsubledger2.Rows.Count > 0)
                    {
                        DDLSub_Ledger2.DataSource = dtsubledger2;
                        DDLSub_Ledger2.DataTextField = "AccSubName";
                        DDLSub_Ledger2.DataValueField = "AccSubCode";
                        DDLSub_Ledger2.DataBind();
                        DDLSub_Ledger2.Items.Insert(0, new ListItem("Select", ""));
                        DDLSub_Ledger2.SelectedValue = dtCurrentTable.Rows[rowIndex]["Sub_Ledger2"].ToString();
                    }
                    ///////////////////////////////////
                    if (sSubTypeID == "1" || sSubTypeID == null)
                    {
                        DDLSub_Type.Enabled = false;
                        DDLSub_Type1.Enabled = false;
                        DDLSub_Type2.Enabled = false;

                    }
                }
                else
                {
                    DDLSub_Type.SelectedValue = dtCurrentTable.Rows[rowIndex]["Sub_Type"].ToString();
                    DDLSub_Type1.SelectedValue = dtCurrentTable.Rows[rowIndex]["Sub_Type1"].ToString();
                    DDLSub_Type2.SelectedValue = dtCurrentTable.Rows[rowIndex]["Sub_Type2"].ToString();
                    DDLSub_Ledger.SelectedValue = dtCurrentTable.Rows[rowIndex]["Sub_Ledger"].ToString();
                    DDLSub_Ledger1.SelectedValue = dtCurrentTable.Rows[rowIndex]["Sub_Ledger1"].ToString();
                    DDLSub_Ledger2.SelectedValue = dtCurrentTable.Rows[rowIndex]["Sub_Ledger2"].ToString();
                }
            }
        }

    }

    private void SetInitialRowforDlete(int index)
    {
        if (conn.State == 0)
        {
            conn.Open();
        }
        dtCurrentTable = new DataTable();
        DataRow dr = null;
        dtCurrentTable.Columns.Add(new DataColumn("RowNumber", typeof(string)));
        dtCurrentTable.Columns.Add(new DataColumn("Transection_Ledger", typeof(string)));
        dtCurrentTable.Columns.Add(new DataColumn("Sub_Type", typeof(string)));
        dtCurrentTable.Columns.Add(new DataColumn("Sub_Ledger", typeof(string)));
        dtCurrentTable.Columns.Add(new DataColumn("Sub_Type1", typeof(string)));
        dtCurrentTable.Columns.Add(new DataColumn("Sub_Ledger1", typeof(string)));
        dtCurrentTable.Columns.Add(new DataColumn("Sub_Type2", typeof(string)));
        dtCurrentTable.Columns.Add(new DataColumn("Sub_Ledger2", typeof(string)));
        dtCurrentTable.Columns.Add(new DataColumn("Amount", typeof(string)));
        dtCurrentTable.Columns.Add(new DataColumn("Currency", typeof(string)));
        dtCurrentTable.Columns.Add(new DataColumn("Exchange_Rate", typeof(string)));
        dtCurrentTable.Columns.Add(new DataColumn("Transection_Memo", typeof(string)));

        dtCurrentTable.Columns.Add(new DataColumn("Old_Data", typeof(string)));

        for (int i = 0; i < Gridview1.Rows.Count; i++)
        {
            DropDownList DDLTransection_Ledger = (DropDownList)Gridview1.Rows[i].Cells[1].FindControl("DDLTransection_Ledger");
            DropDownList DDLSub_Type = (DropDownList)Gridview1.Rows[i].Cells[2].FindControl("DDLSub_Type");
            DropDownList DDLSub_Ledger = (DropDownList)Gridview1.Rows[i].Cells[3].FindControl("DDLSub_Ledger");
            DropDownList DDLSub_Type1 = (DropDownList)Gridview1.Rows[i].Cells[4].FindControl("DDLSub_Type1");
            DropDownList DDLSub_Ledger1 = (DropDownList)Gridview1.Rows[i].Cells[5].FindControl("DDLSub_Ledger1");
            DropDownList DDLSub_Type2 = (DropDownList)Gridview1.Rows[i].Cells[6].FindControl("DDLSub_Type2");
            DropDownList DDLSub_Ledger2 = (DropDownList)Gridview1.Rows[i].Cells[7].FindControl("DDLSub_Ledger2");
            TextBox txt_Amount = (TextBox)Gridview1.Rows[i].Cells[8].FindControl("txt_Amount");
            DropDownList DDLCurrency = (DropDownList)Gridview1.Rows[i].Cells[9].FindControl("DDLCurrency");
            TextBox txt_Exchange_Rate = (TextBox)Gridview1.Rows[i].Cells[10].FindControl("txt_Exchange_Rate");

            TextBox txt_Transection_Memo = (TextBox)Gridview1.Rows[i].Cells[11].FindControl("txt_Transection_Memo");
            dr = dtCurrentTable.NewRow();
            dr["RowNumber"] = Gridview1.Rows[i].Cells[0].Text;
            dr["Transection_Ledger"] = DDLTransection_Ledger.SelectedValue;
            dr["Sub_Type"] = DDLSub_Type.SelectedValue;
            dr["Sub_Ledger"] = DDLSub_Ledger.SelectedValue;
            dr["Sub_Type1"] = DDLSub_Type1.SelectedValue;
            dr["Sub_Ledger1"] = DDLSub_Ledger1.SelectedValue;
            dr["Sub_Type2"] = DDLSub_Type2.SelectedValue;
            dr["Sub_Ledger2"] = DDLSub_Ledger2.SelectedValue;
            dr["Amount"] = txt_Amount.Text;
            dr["Currency"] = DDLCurrency.SelectedValue;
            dr["Exchange_Rate"] = txt_Exchange_Rate.Text;
            dr["Transection_Memo"] = txt_Transection_Memo.Text;
            dr["Old_Data"] = string.Empty;
            dtCurrentTable.Rows.Add(dr);
        }

        Gridview1.DataSource = null;
        dtCurrentTable.Rows[index].Delete();
        if (dtCurrentTable.Rows.Count > 0)
        {
            this.Gridview1.DataSource = dtCurrentTable.DefaultView;
            this.Gridview1.DataBind();
            if (dtCurrentTable.Rows.Count > 0)
            {
                for (int rowIndex = 0; rowIndex < Gridview1.Rows.Count; rowIndex++)
                {

                    DropDownList DDLTransection_Ledger = (DropDownList)Gridview1.Rows[rowIndex].Cells[1].FindControl("DDLTransection_Ledger");
                    DropDownList DDLSub_Type = (DropDownList)Gridview1.Rows[rowIndex].Cells[2].FindControl("DDLSub_Type");
                    DropDownList DDLSub_Ledger = (DropDownList)Gridview1.Rows[rowIndex].Cells[3].FindControl("DDLSub_Ledger");
                    DropDownList DDLSub_Type1 = (DropDownList)Gridview1.Rows[rowIndex].Cells[4].FindControl("DDLSub_Type1");
                    DropDownList DDLSub_Ledger1 = (DropDownList)Gridview1.Rows[rowIndex].Cells[5].FindControl("DDLSub_Ledger1");
                    DropDownList DDLSub_Type2 = (DropDownList)Gridview1.Rows[rowIndex].Cells[6].FindControl("DDLSub_Type2");
                    DropDownList DDLSub_Ledger2 = (DropDownList)Gridview1.Rows[rowIndex].Cells[7].FindControl("DDLSub_Ledger2");
                    TextBox txt_Amount = (TextBox)Gridview1.Rows[rowIndex].Cells[8].FindControl("txt_Amount");
                    DropDownList DDLCurrency = (DropDownList)Gridview1.Rows[rowIndex].Cells[9].FindControl("DDLCurrency");
                    TextBox txt_Exchange_Rate = (TextBox)Gridview1.Rows[rowIndex].Cells[10].FindControl("txt_Exchange_Rate");

                    TextBox txt_Transection_Memo = (TextBox)Gridview1.Rows[rowIndex].Cells[11].FindControl("txt_Transection_Memo");

                    if (conn.State == 0)
                    {
                        conn.Open();
                    }
                    SqlDataAdapter da1 = new SqlDataAdapter("Usp_Vchr_ChartofAccFund", conn);
                    da1.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da1.SelectCommand.Parameters.Add("@AccFundCode", SqlDbType.Int).Value = accfundID.ToString();//3
                    da1.SelectCommand.Parameters.Add("@Vchr_Type", SqlDbType.Char).Value = "T";
                    DataTable Vchr_ChartofAccFund = new DataTable();
                    da1.Fill(Vchr_ChartofAccFund);
                    DDLTransection_Ledger.DataSource = Vchr_ChartofAccFund;
                    DDLTransection_Ledger.DataTextField = "AccName";
                    DDLTransection_Ledger.DataValueField = "CoaDetailID";
                    DDLTransection_Ledger.DataBind();
                    DDLTransection_Ledger.Items.Insert(0, new ListItem("--Select--", ""));

                    DDLTransection_Ledger.SelectedValue = dtCurrentTable.Rows[rowIndex]["Transection_Ledger"].ToString();


                    txt_Amount.Text = dtCurrentTable.Rows[rowIndex]["Amount"].ToString();
                    DDLCurrency.SelectedValue = dtCurrentTable.Rows[rowIndex]["Currency"].ToString();
                    txt_Exchange_Rate.Text = dtCurrentTable.Rows[rowIndex]["Exchange_Rate"].ToString();
                    txt_Transection_Memo.Text = dtCurrentTable.Rows[rowIndex]["Transection_Memo"].ToString();


                    string a = string.Empty;
                    string sSubTypeID = "1";
                    string sSubTypeID1 = "1";
                    string sSubTypeID2 = "1";


                    if (!string.IsNullOrEmpty(DDLTransection_Ledger.SelectedValue))
                    {
                        string SQLSubTypeID = "SELECT CoaDetailID, AccSubTypeID,AccSubTypeID1,AccSubTypeID2 FROM CoaDetail where  CoaDetailID=" + DDLTransection_Ledger.SelectedValue + " AND AccFundID =" + DDLCompany_Name.SelectedValue;
                        if (conn.State == 0)
                        {
                            conn.Open();
                        }
                        SqlDataAdapter daa = new SqlDataAdapter(SQLSubTypeID, conn);
                        daa.SelectCommand.CommandType = CommandType.Text;
                        DataTable dtAccSubTypeID = new DataTable();
                        daa.Fill(dtAccSubTypeID);
                        DDLSub_Type.Enabled = true;
                        DDLSub_Type1.Enabled = true;
                        DDLSub_Type2.Enabled = true;


                        if (dtAccSubTypeID.Rows.Count > 0)
                        {
                            sSubTypeID = dtAccSubTypeID.Rows[0]["AccSubTypeID"].ToString();
                            if (sSubTypeID == "")
                            {
                                sSubTypeID = "1";
                            }
                            sSubTypeID1 = dtAccSubTypeID.Rows[0]["AccSubTypeID1"].ToString();
                            if (sSubTypeID1 == "")
                            {
                                sSubTypeID1 = "1";
                            }
                            sSubTypeID2 = dtAccSubTypeID.Rows[0]["AccSubTypeID2"].ToString();
                            if (sSubTypeID2 == "")
                            {
                                sSubTypeID2 = "1";
                            }

                            DDLSub_Type.DataSource = dtAccSubTypeID;
                            DDLSub_Type.DataTextField = "CoaDetailID";
                            DDLSub_Type.DataValueField = "AccSubTypeID";
                            DDLSub_Type.DataBind();
                            DDLSub_Type.Items.Insert(0, new ListItem("Select", ""));
                            DDLSub_Type.SelectedValue = dtCurrentTable.Rows[rowIndex]["Sub_Type"].ToString();
                            ///////////
                            DDLSub_Type1.DataSource = dtAccSubTypeID;
                            DDLSub_Type1.DataTextField = "CoaDetailID";
                            DDLSub_Type1.DataValueField = "AccSubTypeID1";
                            DDLSub_Type1.DataBind();
                            DDLSub_Type1.Items.Insert(0, new ListItem("Select", ""));
                            DDLSub_Type1.SelectedValue = dtCurrentTable.Rows[rowIndex]["Sub_Type1"].ToString();
                            ///////////////
                            DDLSub_Type2.DataSource = dtAccSubTypeID;
                            DDLSub_Type2.DataTextField = "CoaDetailID";
                            DDLSub_Type2.DataValueField = "AccSubTypeID2";
                            DDLSub_Type2.DataBind();
                            DDLSub_Type2.Items.Insert(0, new ListItem("Select", ""));
                            DDLSub_Type2.SelectedValue = dtCurrentTable.Rows[rowIndex]["Sub_Type2"].ToString();
                        }
                        //////////////////////////////////////////

                        string sql = "SELECT  [AccSubCode],[AccSubTypeID],[AccSubName],[AccFundID] FROM dbo.AccSubNames where AccSubTypeID=" + sSubTypeID + " AND AccFundID =" + accfundID.ToString() + " ORDER BY [AccSubName] ASC";
                        if (conn.State == 0)
                        {
                            conn.Open();
                        }
                        SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                        da.SelectCommand.CommandType = CommandType.Text;
                        DataTable dtsubledger = new DataTable();
                        da.Fill(dtsubledger);
                        if (dtsubledger.Rows.Count > 0)
                        {
                            DDLSub_Ledger.DataSource = dtsubledger;
                            DDLSub_Ledger.DataTextField = "AccSubName";
                            DDLSub_Ledger.DataValueField = "AccSubCode";
                            DDLSub_Ledger.DataBind();
                            DDLSub_Ledger.Items.Insert(0, new ListItem("Select", ""));
                            DDLSub_Ledger.SelectedValue = dtCurrentTable.Rows[rowIndex]["Sub_Ledger"].ToString();
                        }

                        ///////////////////

                        string sql1 = "SELECT  [AccSubCode],[AccSubTypeID],[AccSubName],[AccFundID] FROM dbo.AccSubNames where AccSubTypeID=" + sSubTypeID1 + " AND AccFundID =" + accfundID.ToString() + " ORDER BY [AccSubName] ASC";
                        if (conn.State == 0)
                        {
                            conn.Open();
                        }
                        SqlDataAdapter data1 = new SqlDataAdapter(sql1, conn);
                        data1.SelectCommand.CommandType = CommandType.Text;
                        DataTable dtsubledger1 = new DataTable();
                        data1.Fill(dtsubledger1);

                        if (dtsubledger1.Rows.Count > 0)
                        {
                            DDLSub_Ledger1.DataSource = dtsubledger1;
                            DDLSub_Ledger1.DataTextField = "AccSubName";
                            DDLSub_Ledger1.DataValueField = "AccSubCode";
                            DDLSub_Ledger1.DataBind();
                            DDLSub_Ledger1.Items.Insert(0, new ListItem("Select", ""));
                            DDLSub_Ledger1.SelectedValue = dtCurrentTable.Rows[rowIndex]["Sub_Ledger1"].ToString();
                        }

                        ///////////////////////////////

                        string sql2 = "SELECT  [AccSubCode],[AccSubTypeID],[AccSubName],[AccFundID] FROM dbo.AccSubNames where AccSubTypeID= " + sSubTypeID2 + " AND AccFundID =" + accfundID.ToString() + " ORDER BY [AccSubName] ASC";
                        if (conn.State == 0)
                        {
                            conn.Open();
                        }
                        SqlDataAdapter data2 = new SqlDataAdapter(sql2, conn);
                        data2.SelectCommand.CommandType = CommandType.Text;
                        DataTable dtsubledger2 = new DataTable();
                        data2.Fill(dtsubledger2);
                        if (dtsubledger2.Rows.Count > 0)
                        {
                            DDLSub_Ledger2.DataSource = dtsubledger2;
                            DDLSub_Ledger2.DataTextField = "AccSubName";
                            DDLSub_Ledger2.DataValueField = "AccSubCode";
                            DDLSub_Ledger2.DataBind();
                            DDLSub_Ledger2.Items.Insert(0, new ListItem("Select", ""));
                            DDLSub_Ledger2.SelectedValue = dtCurrentTable.Rows[rowIndex]["Sub_Ledger2"].ToString();
                        }
                        ///////////////////////////////////
                        if (sSubTypeID == "1" || sSubTypeID == null)
                        {
                            DDLSub_Type.Enabled = false;
                            DDLSub_Type1.Enabled = false;
                            DDLSub_Type2.Enabled = false;

                        }
                    }
                    else
                    {
                        DDLSub_Type.SelectedValue = dtCurrentTable.Rows[rowIndex]["Sub_Type"].ToString();
                        DDLSub_Type1.SelectedValue = dtCurrentTable.Rows[rowIndex]["Sub_Type1"].ToString();
                        DDLSub_Type2.SelectedValue = dtCurrentTable.Rows[rowIndex]["Sub_Type2"].ToString();
                        DDLSub_Ledger.SelectedValue = dtCurrentTable.Rows[rowIndex]["Sub_Ledger"].ToString();
                        DDLSub_Ledger1.SelectedValue = dtCurrentTable.Rows[rowIndex]["Sub_Ledger1"].ToString();
                        DDLSub_Ledger2.SelectedValue = dtCurrentTable.Rows[rowIndex]["Sub_Ledger2"].ToString();
                    }
                }
            }
        }
        else
        {
            SetInitialRow();
        }

    }
    protected void ButtonAdd_Click(object sender, EventArgs e)
    {
        AddNewRowToGrid();
    }
    private void AddNewRowToGrid()
    {

        int rowIndex = 0;
        if (dtCurrentTable != null)
        {
            DataRow drCurrentRow = null;

            if (dtCurrentTable.Rows.Count > 0)
            {

                for (int i = 0; i < dtCurrentTable.Rows.Count; i++)
                {

                    DropDownList DDLTransection_Ledger = (DropDownList)Gridview1.Rows[i].Cells[1].FindControl("DDLTransection_Ledger");
                    DropDownList DDLSub_Type = (DropDownList)Gridview1.Rows[i].Cells[2].FindControl("DDLSub_Type");
                    DropDownList DDLSub_Ledger = (DropDownList)Gridview1.Rows[i].Cells[3].FindControl("DDLSub_Ledger");
                    DropDownList DDLSub_Type1 = (DropDownList)Gridview1.Rows[i].Cells[4].FindControl("DDLSub_Type1");
                    DropDownList DDLSub_Ledger1 = (DropDownList)Gridview1.Rows[i].Cells[5].FindControl("DDLSub_Ledger1");
                    DropDownList DDLSub_Type2 = (DropDownList)Gridview1.Rows[i].Cells[6].FindControl("DDLSub_Type2");
                    DropDownList DDLSub_Ledger2 = (DropDownList)Gridview1.Rows[i].Cells[7].FindControl("DDLSub_Ledger2");
                    TextBox txt_Amount = (TextBox)Gridview1.Rows[i].Cells[8].FindControl("txt_Amount");
                    DropDownList DDLCurrency = (DropDownList)Gridview1.Rows[i].Cells[9].FindControl("DDLCurrency");
                    TextBox txt_Exchange_Rate = (TextBox)Gridview1.Rows[i].Cells[10].FindControl("txt_Exchange_Rate");

                    TextBox txt_Transection_Memo = (TextBox)Gridview1.Rows[i].Cells[11].FindControl("txt_Transection_Memo");


                    drCurrentRow = dtCurrentTable.NewRow();

                    drCurrentRow["RowNumber"] = i + 1;
                    dtCurrentTable.Rows[i]["Transection_Ledger"] = DDLTransection_Ledger.SelectedValue;
                    dtCurrentTable.Rows[i]["Sub_Type"] = DDLSub_Type.SelectedValue;
                    dtCurrentTable.Rows[i]["Sub_Ledger"] = DDLSub_Ledger.SelectedValue;
                    dtCurrentTable.Rows[i]["Sub_Type1"] = DDLSub_Type1.SelectedValue;
                    dtCurrentTable.Rows[i]["Sub_Ledger1"] = DDLSub_Ledger1.SelectedValue;
                    dtCurrentTable.Rows[i]["Sub_Type2"] = DDLSub_Type2.SelectedValue;
                    dtCurrentTable.Rows[i]["Sub_Ledger2"] = DDLSub_Ledger2.SelectedValue;
                    dtCurrentTable.Rows[i]["Amount"] = txt_Amount.Text;
                    dtCurrentTable.Rows[i]["Currency"] = DDLCurrency.SelectedValue;
                    dtCurrentTable.Rows[i]["Exchange_Rate"] = txt_Exchange_Rate.Text;
                    dtCurrentTable.Rows[i]["Transection_Memo"] = txt_Transection_Memo.Text;
                    rowIndex++;

                }

                dtCurrentTable.Rows.Add(drCurrentRow);

                Gridview1.DataSource = dtCurrentTable;

                Gridview1.DataBind();
                if (Gridview1.Rows.Count > 0)
                {
                    for (int i = 0; i < Gridview1.Rows.Count; i++)
                    {

                        if (!string.IsNullOrEmpty(DDLVoucherType.SelectedValue))
                        {
                            // CP= Cash Payment BP= Bank Payment Voucher type selection Check 

                            DropDownList DDLTransection_Ledger = (DropDownList)Gridview1.Rows[i].FindControl("DDLTransection_Ledger");
                            if (conn.State == 0)
                            {
                                conn.Open();
                            }
                            SqlDataAdapter da1 = new SqlDataAdapter("Usp_Vchr_ChartofAccFund", conn);
                            da1.SelectCommand.CommandType = CommandType.StoredProcedure;
                            da1.SelectCommand.Parameters.Add("@AccFundCode", SqlDbType.Int).Value = accfundID.ToString();//3
                            da1.SelectCommand.Parameters.Add("@Vchr_Type", SqlDbType.Char).Value = "D";
                            DataTable Vchr_ChartofAccFund = new DataTable();
                            da1.Fill(Vchr_ChartofAccFund);
                            DDLTransection_Ledger.DataSource = Vchr_ChartofAccFund;
                            DDLTransection_Ledger.DataTextField = "AccName";
                            DDLTransection_Ledger.DataValueField = "CoaDetailID";
                            DDLTransection_Ledger.DataBind();
                            DDLTransection_Ledger.Items.Insert(0, new ListItem("--Select--", ""));

                        }
                    }
                }

            }

        }

        else
        {

            Response.Write("ViewState is null");

        }
        SetPreviousData();

    }
    private void SetPreviousData()
    {

        int rowIndex = 0;

        if (dtCurrentTable != null)
        {
            if (dtCurrentTable.Rows.Count > 0)
            {

                for (int i = 0; i < dtCurrentTable.Rows.Count; i++)
                {

                    DropDownList DDLTransection_Ledger = (DropDownList)Gridview1.Rows[rowIndex].Cells[1].FindControl("DDLTransection_Ledger");
                    DropDownList DDLSub_Type = (DropDownList)Gridview1.Rows[rowIndex].Cells[2].FindControl("DDLSub_Type");
                    DropDownList DDLSub_Ledger = (DropDownList)Gridview1.Rows[rowIndex].Cells[3].FindControl("DDLSub_Ledger");
                    DropDownList DDLSub_Type1 = (DropDownList)Gridview1.Rows[rowIndex].Cells[4].FindControl("DDLSub_Type1");
                    DropDownList DDLSub_Ledger1 = (DropDownList)Gridview1.Rows[rowIndex].Cells[5].FindControl("DDLSub_Ledger1");
                    DropDownList DDLSub_Type2 = (DropDownList)Gridview1.Rows[rowIndex].Cells[6].FindControl("DDLSub_Type2");
                    DropDownList DDLSub_Ledger2 = (DropDownList)Gridview1.Rows[rowIndex].Cells[7].FindControl("DDLSub_Ledger2");
                    TextBox txt_Amount = (TextBox)Gridview1.Rows[rowIndex].Cells[8].FindControl("txt_Amount");
                    DropDownList DDLCurrency = (DropDownList)Gridview1.Rows[rowIndex].Cells[9].FindControl("DDLCurrency");
                    TextBox txt_Exchange_Rate = (TextBox)Gridview1.Rows[rowIndex].Cells[10].FindControl("txt_Exchange_Rate");

                    TextBox txt_Transection_Memo = (TextBox)Gridview1.Rows[rowIndex].Cells[11].FindControl("txt_Transection_Memo");

                    DDLTransection_Ledger.SelectedValue = dtCurrentTable.Rows[i]["Transection_Ledger"].ToString();
                    txt_Amount.Text = dtCurrentTable.Rows[i]["Amount"].ToString();
                    DDLCurrency.SelectedValue = dtCurrentTable.Rows[i]["Currency"].ToString();
                    txt_Exchange_Rate.Text = dtCurrentTable.Rows[i]["Exchange_Rate"].ToString();
                    txt_Transection_Memo.Text = dtCurrentTable.Rows[i]["Transection_Memo"].ToString();


                    string a = string.Empty;
                    string sSubTypeID = "1";
                    string sSubTypeID1 = "1";
                    string sSubTypeID2 = "1";


                    if (!string.IsNullOrEmpty(DDLTransection_Ledger.SelectedValue))
                    {
                        string SQLSubTypeID = "SELECT CoaDetailID, AccSubTypeID,AccSubTypeID1,AccSubTypeID2 FROM CoaDetail where  CoaDetailID=" + DDLTransection_Ledger.SelectedValue + " AND AccFundID =" + DDLCompany_Name.SelectedValue;

                        if (conn.State == 0)
                        {
                            conn.Open();
                        }
                        SqlDataAdapter daa = new SqlDataAdapter(SQLSubTypeID, conn);
                        daa.SelectCommand.CommandType = CommandType.Text;
                        DataTable dtAccSubTypeID = new DataTable();
                        daa.Fill(dtAccSubTypeID);

                        DDLSub_Type.Enabled = true;
                        DDLSub_Type1.Enabled = true;
                        DDLSub_Type2.Enabled = true;


                        if (dtAccSubTypeID.Rows.Count > 0)
                        {
                            sSubTypeID = dtAccSubTypeID.Rows[0]["AccSubTypeID"].ToString();
                            if (sSubTypeID == "")
                            {
                                sSubTypeID = "1";
                            }
                            sSubTypeID1 = dtAccSubTypeID.Rows[0]["AccSubTypeID1"].ToString();
                            if (sSubTypeID1 == "")
                            {
                                sSubTypeID1 = "1";
                            }
                            sSubTypeID2 = dtAccSubTypeID.Rows[0]["AccSubTypeID2"].ToString();
                            if (sSubTypeID2 == "")
                            {
                                sSubTypeID2 = "1";
                            }

                            DDLSub_Type.DataSource = dtAccSubTypeID;
                            DDLSub_Type.DataTextField = "CoaDetailID";
                            DDLSub_Type.DataValueField = "AccSubTypeID";
                            DDLSub_Type.DataBind();
                            DDLSub_Type.Items.Insert(0, new ListItem("Select", ""));
                            DDLSub_Type.SelectedValue = dtCurrentTable.Rows[i]["Sub_Type"].ToString();
                            ///////////
                            DDLSub_Type1.DataSource = dtAccSubTypeID;
                            DDLSub_Type1.DataTextField = "CoaDetailID";
                            DDLSub_Type1.DataValueField = "AccSubTypeID1";
                            DDLSub_Type1.DataBind();
                            DDLSub_Type1.Items.Insert(0, new ListItem("Select", ""));
                            DDLSub_Type1.SelectedValue = dtCurrentTable.Rows[i]["Sub_Type1"].ToString();
                            ///////////////
                            DDLSub_Type2.DataSource = dtAccSubTypeID;
                            DDLSub_Type2.DataTextField = "CoaDetailID";
                            DDLSub_Type2.DataValueField = "AccSubTypeID2";
                            DDLSub_Type2.DataBind();
                            DDLSub_Type2.Items.Insert(0, new ListItem("Select", ""));
                            DDLSub_Type2.SelectedValue = dtCurrentTable.Rows[i]["Sub_Type2"].ToString();
                        }

                        //////////////////////////////////////////

                        string sql = "SELECT  [AccSubCode],[AccSubTypeID],[AccSubName],[AccFundID] FROM dbo.AccSubNames where AccSubTypeID=" + sSubTypeID + " AND AccFundID =" + accfundID.ToString() + " ORDER BY [AccSubName] ASC";
                        if (conn.State == 0)
                        {
                            conn.Open();
                        }
                        SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                        da.SelectCommand.CommandType = CommandType.Text;
                        DataTable dtsubledger = new DataTable();
                        da.Fill(dtsubledger);
                        if (dtsubledger.Rows.Count > 0)
                        {
                            DDLSub_Ledger.DataSource = dtsubledger;
                            DDLSub_Ledger.DataTextField = "AccSubName";
                            DDLSub_Ledger.DataValueField = "AccSubCode";
                            DDLSub_Ledger.DataBind();
                            DDLSub_Ledger.Items.Insert(0, new ListItem("Select", ""));
                            DDLSub_Ledger.SelectedValue = dtCurrentTable.Rows[i]["Sub_Ledger"].ToString();
                        }

                        ///////////////////

                        string sql1 = "SELECT  [AccSubCode],[AccSubTypeID],[AccSubName],[AccFundID] FROM dbo.AccSubNames where AccSubTypeID=" + sSubTypeID1 + " AND AccFundID =" + accfundID.ToString() + " ORDER BY [AccSubName] ASC";
                        if (conn.State == 0)
                        {
                            conn.Open();
                        }
                        SqlDataAdapter data1 = new SqlDataAdapter(sql1, conn);
                        data1.SelectCommand.CommandType = CommandType.Text;
                        DataTable dtsubledger1 = new DataTable();
                        data1.Fill(dtsubledger1);

                        if (dtsubledger1.Rows.Count > 0)
                        {
                            DDLSub_Ledger1.DataSource = dtsubledger1;
                            DDLSub_Ledger1.DataTextField = "AccSubName";
                            DDLSub_Ledger1.DataValueField = "AccSubCode";
                            DDLSub_Ledger1.DataBind();
                            DDLSub_Ledger1.Items.Insert(0, new ListItem("Select", ""));
                            DDLSub_Ledger1.SelectedValue = dtCurrentTable.Rows[i]["Sub_Ledger1"].ToString();
                        }

                        ///////////////////////////////

                        string sql2 = "SELECT  [AccSubCode],[AccSubTypeID],[AccSubName],[AccFundID] FROM dbo.AccSubNames where AccSubTypeID= " + sSubTypeID2 + " AND AccFundID =" + accfundID.ToString() + " ORDER BY [AccSubName] ASC";
                        if (conn.State == 0)
                        {
                            conn.Open();
                        }
                        SqlDataAdapter data2 = new SqlDataAdapter(sql2, conn);
                        data2.SelectCommand.CommandType = CommandType.Text;
                        DataTable dtsubledger2 = new DataTable();
                        data2.Fill(dtsubledger2);
                        if (dtsubledger2.Rows.Count > 0)
                        {
                            DDLSub_Ledger2.DataSource = dtsubledger2;
                            DDLSub_Ledger2.DataTextField = "AccSubName";
                            DDLSub_Ledger2.DataValueField = "AccSubCode";
                            DDLSub_Ledger2.DataBind();
                            DDLSub_Ledger2.Items.Insert(0, new ListItem("Select", ""));
                            DDLSub_Ledger2.SelectedValue = dtCurrentTable.Rows[i]["Sub_Ledger2"].ToString();
                        }
                        ///////////////////////////////////
                        if (sSubTypeID == "1" || sSubTypeID == null)
                        {
                            DDLSub_Type.Enabled = false;
                            DDLSub_Type1.Enabled = false;
                            DDLSub_Type2.Enabled = false;

                        }
                    }
                    else
                    {
                        DDLSub_Type.SelectedValue = dtCurrentTable.Rows[i]["Sub_Type"].ToString();
                        DDLSub_Type1.SelectedValue = dtCurrentTable.Rows[i]["Sub_Type1"].ToString();
                        DDLSub_Type2.SelectedValue = dtCurrentTable.Rows[i]["Sub_Type2"].ToString();
                        DDLSub_Ledger.SelectedValue = dtCurrentTable.Rows[i]["Sub_Ledger"].ToString();
                        DDLSub_Ledger1.SelectedValue = dtCurrentTable.Rows[i]["Sub_Ledger1"].ToString();
                        DDLSub_Ledger2.SelectedValue = dtCurrentTable.Rows[i]["Sub_Ledger2"].ToString();
                    }


                    rowIndex++;

                }

            }
        }

    }
    protected void DDLVoucherType_SelectedIndexChanged(object sender, EventArgs e)
    {
        VoucherTypeRead();
        Voucher_Type_Wise_Design();

    }

    private void Voucher_Type_Wise_Design()
    {
        tr_for_CashPayment.Visible = false;
        tr_for_CashPayment1.Visible = false;
        tr_for_CashPayment2.Visible = false;
        tr_for_CashPayment3.Visible = false;
        tr_for_CashPayment4.Visible = false;
        tr_for_CashPayment5.Visible = false;

        if (VoucherTypeCode == "BP" || VoucherTypeCode == "BR")
        {
            tr_for_CashPayment.Visible = true;
            tr_for_CashPayment1.Visible = true;
            tr_for_CashPayment2.Visible = true;
            tr_for_CashPayment3.Visible = true;
            tr_for_CashPayment4.Visible = true;
            tr_for_CashPayment5.Visible = true;
        }

    }

    private void CashBankSourceLoad()
    {

        if (VoucherTypeCode == "CP" || VoucherTypeCode == "CR")//CP,BP
        {

            tr_Cash_Bank.Visible = true;


            if (conn.State == 0)
            {
                conn.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter("BBLCashAccounts", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            DDLCashBankSource.DataSource = dt;
            DDLCashBankSource.DataTextField = "AccName";
            DDLCashBankSource.DataValueField = "CoaDetailID";
            DDLCashBankSource.DataBind();
            DDLCashBankSource.Items.Insert(0, new ListItem("Select", ""));



        }
        else if (VoucherTypeCode == "BP" || VoucherTypeCode == "BR")//CR BR
        {
            //   tr_FundSourse.Visible = true;
            tr_Cash_Bank.Visible = true;

            if (conn.State == 0)
            {
                conn.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter("BBLBankAccounts", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            DDLCashBankSource.DataSource = dt;
            DDLCashBankSource.DataTextField = "AccName";
            DDLCashBankSource.DataValueField = "CoaDetailID";
            DDLCashBankSource.DataBind();

            DDLCashBankSource.Items.Insert(0, new ListItem("Select", ""));

        }
        else if (VoucherTypeCode == "TV")//5TV
        {

            //tr_FundSourse.Visible = true;
            tr_Cash_Bank.Visible = true;

            if (conn.State == 0)
            {
                conn.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter("BBL_Cash_Bank_Account", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            DDLCashBankSource.DataSource = dt;
            DDLCashBankSource.DataTextField = "AccName";
            DDLCashBankSource.DataValueField = "CoaDetailID";
            DDLCashBankSource.DataBind();
            DDLCashBankSource.Items.Insert(0, new ListItem("Select", ""));

        }
        else if (VoucherTypeCode == "JV")//6JV
        {
            //tr_FundSourse.Visible = false;
            tr_Cash_Bank.Visible = false;
        }
        else if (VoucherTypeCode == "TS")//7TS
        {

        }
        else
        {

        }


    }
    protected void DDLCashBankSource_SelectedIndexChanged(object sender, EventArgs e)
    {

        lblCashBankSource.Text = "";
        sCashBankSource = Convert.ToString(DDLCashBankSource.SelectedValue);
        Gridview1.DataSource = null;
        dtCurrentTable = null;
        SetInitialRow();
        Gridview1.Visible = true;
        Total_Amount.Visible = true;

        if ((VoucherTypeCode == "BP") || (VoucherTypeCode == "BR") || (VoucherTypeCode == "TV"))
        {
            if ((VoucherTypeCode == "BP"))
            {
                CheckNo();
            }
            if (!string.IsNullOrEmpty(DDLCashBankSource.SelectedValue))
                BranchName();

        }

    }

    private void BranchName()
    {

        string sql = "SELECT [BranchName] FROM [dbo].[CoaDetail] where CoaDetailID=" + sCashBankSource;
        if (conn.State == 0)
        {
            conn.Open();
        }
        SqlDataAdapter da = new SqlDataAdapter(sql, conn);
        da.SelectCommand.CommandType = CommandType.Text;

        DataTable dt = new DataTable();
        da.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            txt_Branch_Name.Text = dt.Rows[0]["BranchName"].ToString();
        }
        else
            txt_Branch_Name.Text = "";


    }
    protected void txt_Amount_TextChanged(object sender, EventArgs e)
    {
        Total_Ammount_Calculation();

    }

    private void Total_Ammount_Calculation()
    {
        Decimal Total = 0m;
        Decimal Sum_Total = 0m;

        for (int irow = 1; Gridview1.Rows.Count >= irow; irow++)
        {
            TextBox txt_Amount = (TextBox)Gridview1.Rows[irow - 1].Cells[8].FindControl("txt_Amount");
            TextBox txt_Transection_Memo = (TextBox)Gridview1.Rows[irow - 1].Cells[8].FindControl("txt_Transection_Memo");

            if (txt_Amount.Text == "")
            {
                Total = 0;
                Sum_Total = Sum_Total + Total;
            }
            else
            {
                Total = Convert.ToDecimal(txt_Amount.Text.Trim());
                Sum_Total = Sum_Total + Total;
            }

            txt_Transection_Memo.Focus();
            txtVchrTotal.Text = Convert.ToDecimal(Sum_Total).ToString("#,##0.00");
        }
    }
    protected void DDLTransection_Ledger_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            string a = string.Empty;
            string sSubTypeID = "1";
            string sSubTypeID1 = "1";
            string sSubTypeID2 = "1";


            GridViewRow rowT_Ledger = (GridViewRow)(((Control)sender).NamingContainer);
            DropDownList DDLTransection_Ledger = (DropDownList)rowT_Ledger.FindControl("DDLTransection_Ledger");
            DropDownList DDL_SType = (DropDownList)rowT_Ledger.FindControl("DDLSub_Type");
            DropDownList DDL_SType1 = (DropDownList)rowT_Ledger.FindControl("DDLSub_Type1");
            DropDownList DDL_SType2 = (DropDownList)rowT_Ledger.FindControl("DDLSub_Type2");
            a = DDLTransection_Ledger.SelectedValue;
            string SQLSubTypeID = "SELECT CoaDetailID, AccSubTypeID,AccSubTypeID1,AccSubTypeID2 FROM CoaDetail where  CoaDetailID=" + DDLTransection_Ledger.SelectedValue + " AND AccFundID =" + DDLCompany_Name.SelectedValue;

            if (conn.State == 0)
            {
                conn.Open();
            }
            SqlDataAdapter daa = new SqlDataAdapter(SQLSubTypeID, conn);
            daa.SelectCommand.CommandType = CommandType.Text;
            DataTable dtAccSubTypeID = new DataTable();
            daa.Fill(dtAccSubTypeID);

            DDL_SType.Enabled = true;
            DDL_SType1.Enabled = true;
            DDL_SType2.Enabled = true;


            if (dtAccSubTypeID.Rows.Count > 0)
            {
                sSubTypeID = dtAccSubTypeID.Rows[0]["AccSubTypeID"].ToString();
                if ((sSubTypeID == "") || (sSubTypeID == null))
                {
                    sSubTypeID = "1";
                }
                sSubTypeID1 = dtAccSubTypeID.Rows[0]["AccSubTypeID1"].ToString();
                if (sSubTypeID1 == "")
                {
                    sSubTypeID1 = "1";
                }
                sSubTypeID2 = dtAccSubTypeID.Rows[0]["AccSubTypeID2"].ToString();
                if (sSubTypeID2 == "")
                {
                    sSubTypeID2 = "1";
                }

                DDL_SType.DataSource = dtAccSubTypeID;
                DDL_SType.DataTextField = "CoaDetailID";
                DDL_SType.DataValueField = "AccSubTypeID";
                DDL_SType.DataBind();
                //DDL_SType.Items.Insert(0, new ListItem("Select", ""));
                ///////////
                DDL_SType1.DataSource = dtAccSubTypeID;
                DDL_SType1.DataTextField = "CoaDetailID";
                DDL_SType1.DataValueField = "AccSubTypeID1";
                DDL_SType1.DataBind();
                //DDL_SType1.Items.Insert(0, new ListItem("Select", ""));
                ///////////////
                DDL_SType2.DataSource = dtAccSubTypeID;
                DDL_SType2.DataTextField = "CoaDetailID";
                DDL_SType2.DataValueField = "AccSubTypeID2";
                DDL_SType2.DataBind();
                //DDL_SType2.Items.Insert(0, new ListItem("Select", ""));
            }



            //////////////////////////////////////////
            DropDownList DDLSub_Ledger = (DropDownList)rowT_Ledger.FindControl("DDLSub_Ledger");
            string sql = "SELECT  [AccSubCode],[AccSubTypeID],[AccSubName],[AccFundID] FROM dbo.AccSubNames where AccSubTypeID=" + sSubTypeID + " AND AccFundID =" + accfundID.ToString() + " ORDER BY [AccSubName] ASC";
            if (conn.State == 0)
            {
                conn.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dtsubledger = new DataTable();
            da.Fill(dtsubledger);
            if (dtsubledger.Rows.Count > 0)
            {
                DDLSub_Ledger.DataSource = dtsubledger;
                DDLSub_Ledger.DataTextField = "AccSubName";
                DDLSub_Ledger.DataValueField = "AccSubCode";
                DDLSub_Ledger.DataBind();
                DDLSub_Ledger.Items.Insert(0, new ListItem("Select", ""));
            }

            // sSubTypeID = DDL_SType.SelectedValue;
            ////////////////////


            ///////////////////
            DropDownList DDLSub_Ledger1 = (DropDownList)rowT_Ledger.FindControl("DDLSub_Ledger1");
            string sql1 = "SELECT  [AccSubCode],[AccSubTypeID],[AccSubName],[AccFundID] FROM dbo.AccSubNames where AccSubTypeID=" + sSubTypeID1 + " AND AccFundID =" + accfundID.ToString() + " ORDER BY [AccSubName] ASC";
            if (conn.State == 0)
            {
                conn.Open();
            }
            SqlDataAdapter data1 = new SqlDataAdapter(sql1, conn);
            data1.SelectCommand.CommandType = CommandType.Text;
            DataTable dtsubledger1 = new DataTable();
            data1.Fill(dtsubledger1);

            if (dtsubledger1.Rows.Count > 0)
            {
                DDLSub_Ledger1.DataSource = dtsubledger1;
                DDLSub_Ledger1.DataTextField = "AccSubName";
                DDLSub_Ledger1.DataValueField = "AccSubCode";
                DDLSub_Ledger1.DataBind();
                DDLSub_Ledger1.Items.Insert(0, new ListItem("Select", ""));
            }

            ///////////////////////////////
            DropDownList DDLSub_Ledger2 = (DropDownList)rowT_Ledger.FindControl("DDLSub_Ledger2");
            string sql2 = "SELECT  [AccSubCode],[AccSubTypeID],[AccSubName],[AccFundID] FROM dbo.AccSubNames where AccSubTypeID= " + sSubTypeID2 + " AND AccFundID =" + accfundID.ToString() + " ORDER BY [AccSubName] ASC";
            if (conn.State == 0)
            {
                conn.Open();
            }
            SqlDataAdapter data2 = new SqlDataAdapter(sql2, conn);
            data2.SelectCommand.CommandType = CommandType.Text;
            DataTable dtsubledger2 = new DataTable();
            data2.Fill(dtsubledger2);
            if (dtsubledger2.Rows.Count > 0)
            {
                DDLSub_Ledger2.DataSource = dtsubledger2;
                DDLSub_Ledger2.DataTextField = "AccSubName";
                DDLSub_Ledger2.DataValueField = "AccSubCode";
                DDLSub_Ledger2.DataBind();
                DDLSub_Ledger2.Items.Insert(0, new ListItem("Select", ""));
            }
            ///////////////////////////////////
            if (sSubTypeID == "1" || sSubTypeID == null)
            {
                DDL_SType.Enabled = false;
                DDL_SType1.Enabled = false;
                DDL_SType2.Enabled = false;

            }




        }
        catch (Exception ex)
        {
            PopUp("Transection Ledger Data Load Problem. Please Try Again. " + ex.InnerException);
        }
    }
    public void PopUp(string sMsg)
    {
        ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), Guid.NewGuid().ToString(), "alert('" + sMsg + "');", true);
    }

    protected void clear()
    {
        dtreport = null;
        SDTDelete = null;
        dtOldTable = null;
        dtCurrentTable = null;

        lbl_SMsgg.Text = null;
        txt_Voucher_Narration.Text = "";
        txt_Paid_To.Text = "";
        txtRefNo.Text = "";
        Gridview1.Visible = false;
        EditVoucherID = 0;
        CP_Header.Text = "";
        CP_Header.Visible = false;
        EditAccVoucherTranID = 0;
        DDLCompany_Name.Enabled = true;
        DDLVoucherType.Enabled = true;
        DDLCashBankSource.Enabled = true;
        btn_save.Text = "Save";
        Total_Amount.Visible = false;
        Total_Sum = 0;
        LB_Voucher_Print.Visible = false;
        FromNSearch.Visible = true;
        ReportForm.Visible = false;
        ReportViewer1.LocalReport.DataSources.Clear();
        PdfLocation = "";
        fileName = "";
        Find_VoucherButton.Visible = true;
        EditVoucher_Date.Visible = true;

        txt_Check_Date.Text = "";
        DDL_CheckNo.DataSource = null;
        txt_Branch_Name.Text = "";
        txt_CheckNo.Visible = false;
        DDL_CheckNo.Visible = true;
        btn_delete.Visible = false;
    }
    protected void DDLCompany_Name_SelectedIndexChanged(object sender, EventArgs e)
    {
        //FundSource();
    }
    protected void Save_Deatis(object sender, EventArgs e)
    {

        double a, Result = 0;
        if (DDLCashBankSource.SelectedValue == "0")
        {
            lblMsg.Text = "Please Select Bank Account ";
            PopUp("Please Select Bank Account ");
            return;
        }
        if ((VoucherTypeCode == "BP") || (VoucherTypeCode == "BR") || (VoucherTypeCode == "TV"))
        {
            if (VoucherTypeCode == "BP")
            {
                if (!string.IsNullOrEmpty(DDL_CheckNo.SelectedItem.Value))
                {
                    if (string.IsNullOrEmpty(txt_Check_Date.Text))
                    {

                        PopUp("Please select cheque date");
                        return;
                    }
                }
            }

        }


        if (string.IsNullOrEmpty(txtVchrTotal.Text))
        {
            PopUp("Please Check Transection Amount");
            return;
        }

        btn_delete.Visible = false;
        int AccVoucherTranID = 0;
        if (dtCurrentTable != null)
        {

            if (EditAccVoucherTranID != 0)
            {
                AccVoucherTranID = EditAccVoucherTranID;
            }
            else
            {

            }

            string[] headerinfo = new string[12];
            headerinfo[0] = DDLCompany_Name.SelectedValue;//Companny Name
            headerinfo[1] = DDLVoucherType.SelectedValue;//Voucher Type
            headerinfo[3] = txt_Voucher_Narration.Text;//Mamo

            if (!IsAddEditMode)
            {
                #region [Date Check]
                CultureInfo cultureinfo = new CultureInfo("en-GB");
                DateTime dt = DateTime.Parse(EditVoucher_Date.Text, cultureinfo);
                string VchrDate = dt.Month.ToString() + "/" + dt.Day.ToString() + "/" + dt.Year.ToString();

                string Date = VchrDate;
                string time = System.DateTime.Now.ToString("HH:mm:ss tt");
                string EditedDate = Date + " " + time;
                headerinfo[4] = EditedDate;

                if (txt_Check_Date.Text.Trim().Length > 0)
                {
                    DateTime ChkVchrDate = DateTime.Parse(txt_Check_Date.Text, cultureinfo);
                    string ChequeDate = ChkVchrDate.Month.ToString() + "/" + ChkVchrDate.Day.ToString() + "/" + ChkVchrDate.Year.ToString();
                    string FinalChequeDate = ChequeDate + " " + time;

                    headerinfo[10] = FinalChequeDate;
                }
                #endregion
            }
            else
            {
                #region [Date Update]
                CultureInfo cultureinfo = new CultureInfo("en-GB");
                DateTime dt = DateTime.Parse(EditVoucher_Date.Text, cultureinfo);
                string VchrDate = dt.Month.ToString() + "/" + dt.Day.ToString() + "/" + dt.Year.ToString();

                string Date = VchrDate;
                string time = System.DateTime.Now.ToString("HH:mm:ss tt");
                string EditedDate = Date + " " + time;
                headerinfo[4] = EditedDate;

                if (txt_Check_Date.Text == "")
                {
                    headerinfo[10] = null;
                }
                else
                {
                    DateTime ChkVchrDate = DateTime.Parse(txt_Check_Date.Text, cultureinfo);
                    string ChequeDate = ChkVchrDate.Month.ToString() + "/" + ChkVchrDate.Day.ToString() + "/" + ChkVchrDate.Year.ToString();


                    string FinalChequeDate = ChequeDate + " " + time;

                    headerinfo[10] = FinalChequeDate;

                }
                #endregion

            }

            headerinfo[5] = DDLCashBankSource.SelectedValue; //CashBankSource
            headerinfo[6] = txt_Paid_To.Text;//Paid_To
            headerinfo[7] = txtRefNo.Text;
            headerinfo[8] = VoucherTypeCode; //@HeadAcc int,--Transec Ledger No

            if (VoucherTypeCode == "CP" || VoucherTypeCode == "CR")
            {
                headerinfo[9] = "";
                headerinfo[11] = "";
            }
            else if (VoucherTypeCode == "BP" || VoucherTypeCode == "BR")
            {
                if (VoucherTypeCode == "BP")
                {
                    headerinfo[9] = DDL_CheckNo.SelectedItem.Text;//txt_CheckNo.Text;
                }
                else
                {
                    headerinfo[9] = txt_CheckNo.Text;//txt_CheckNo.Text;
                }
                headerinfo[11] = txt_Branch_Name.Text;

            }
            else
            {
                headerinfo[9] = "";
                headerinfo[11] = "";
            }


            /////////// VoucherCreateUpdateSingle -StoredProcedure -Diclear  //////
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
          


            //conn.set setTransactionIsolation(Connection.TRANSACTION_READ_COMMITTED + 4094);


            if (conn.State == 0)
            {
                conn.Open();
            }
            SqlTransaction Transection = conn.BeginTransaction(IsolationLevel.ReadCommitted);
            
            try
            {
                #region Transection_Ledger Loop wise save


                for (int irows = 1; Gridview1.Rows.Count >= irows; irows++)
                {
                    #region [ Read Grid ]
                    DropDownList DDLTransection_Ledger = (DropDownList)Gridview1.Rows[irows - 1].Cells[1].FindControl("DDLTransection_Ledger");
                    DropDownList DDLSub_Type = (DropDownList)Gridview1.Rows[irows - 1].Cells[2].FindControl("DDLSub_Type");
                    DropDownList DDLSub_Ledger = (DropDownList)Gridview1.Rows[irows - 1].Cells[3].FindControl("DDLSub_Ledger");

                    DropDownList DDLSub_Type1 = (DropDownList)Gridview1.Rows[irows - 1].Cells[4].FindControl("DDLSub_Type1");
                    DropDownList DDLSub_Ledger1 = (DropDownList)Gridview1.Rows[irows - 1].Cells[5].FindControl("DDLSub_Ledger1");
                    DropDownList DDLSub_Type2 = (DropDownList)Gridview1.Rows[irows - 1].Cells[6].FindControl("DDLSub_Type2");
                    DropDownList DDLSub_Ledger2 = (DropDownList)Gridview1.Rows[irows - 1].Cells[7].FindControl("DDLSub_Ledger2");

                    TextBox txt_Amount = (TextBox)Gridview1.Rows[irows - 1].Cells[8].FindControl("txt_Amount");
                    DropDownList DDLCurrency = (DropDownList)Gridview1.Rows[irows - 1].Cells[9].FindControl("DDLCurrency");
                    TextBox txt_Exchange_Rate = (TextBox)Gridview1.Rows[irows - 1].Cells[10].FindControl("txt_Exchange_Rate");
                    TextBox txt_Transection_Memo = (TextBox)Gridview1.Rows[irows - 1].Cells[11].FindControl("txt_Transection_Memo");
                    #endregion

                    dtCurrentTable.Rows[irows - 1]["Transection_Ledger"] = DDLTransection_Ledger.SelectedValue;
                    if (DDLSub_Type.SelectedValue == "")
                    {
                        dtCurrentTable.Rows[irows - 1]["Sub_Type"] = "1";
                    }
                    else
                    {
                        dtCurrentTable.Rows[irows - 1]["Sub_Type"] = DDLSub_Type.SelectedValue;
                    }
                    if (!string.IsNullOrEmpty(DDLSub_Ledger.SelectedValue))
                    {
                        dtCurrentTable.Rows[irows - 1]["Sub_Ledger"] = DDLSub_Ledger.SelectedValue;
                    }
                    if (DDLSub_Type1.SelectedValue == "")
                    {
                        dtCurrentTable.Rows[irows - 1]["Sub_Type1"] = "1";
                    }
                    else
                    {
                        dtCurrentTable.Rows[irows - 1]["Sub_Type1"] = DDLSub_Type1.SelectedValue;
                    }
                    if (DDLSub_Type2.SelectedValue == "")
                    {
                        dtCurrentTable.Rows[irows - 1]["Sub_Type2"] = "1";
                    }
                    else
                    {
                        dtCurrentTable.Rows[irows - 1]["Sub_Type2"] = DDLSub_Type2.SelectedValue;
                    }
                    if (!string.IsNullOrEmpty(DDLSub_Ledger1.SelectedValue))
                    {
                        dtCurrentTable.Rows[irows - 1]["Sub_Ledger1"] = DDLSub_Ledger1.SelectedValue;
                    }
                    if (!string.IsNullOrEmpty(DDLSub_Ledger2.SelectedValue))
                    {
                        dtCurrentTable.Rows[irows - 1]["Sub_Ledger2"] = DDLSub_Ledger2.SelectedValue;
                    }
                    dtCurrentTable.Rows[irows - 1]["Amount"] = txt_Amount.Text;
                    dtCurrentTable.Rows[irows - 1]["Currency"] = DDLCurrency.SelectedValue;
                    dtCurrentTable.Rows[irows - 1]["Exchange_Rate"] = txt_Exchange_Rate.Text;
                    dtCurrentTable.Rows[irows - 1]["Transection_Memo"] = txt_Transection_Memo.Text;
                    dtCurrentTable.Rows[irows - 1]["RowNumber"] = irows;

                    /////////////////////////////////////////////////
                   
                    if (AccVoucherTranID == 0)
                    {
                        //--exec VoucherCreateUpdateSingleAccounts 0,3,null,1,'5/18/2015','','',426,407,4,'',1,null,1,null,5000,0,0,'tedfdf',
                        //--0,0,null,null,null,'',@acc output
                        #region [Transaction Start]
                        cmd.Parameters.Add("@AccVoucherTranID", SqlDbType.Int).Value = Convert.ToInt64(AccVoucherTranID);// @AccVoucherTranID int,--0
                        cmd.Parameters.Add("@AccFundID", SqlDbType.Int).Value = Convert.ToInt64(headerinfo[0]);  //@AccFundID int,--3
                        cmd.Parameters.Add("@AccBranchCode", SqlDbType.Int).Value = DBNull.Value;  //@AccBranchCode int,--1 by def
                        cmd.Parameters.Add("@VchrTypeID", SqlDbType.Int).Value = Convert.ToInt64(headerinfo[1]); //@VchrTypeID int,--2
                        cmd.Parameters.Add("@PayDate", SqlDbType.DateTime).Value = headerinfo[4];

                        cmd.Parameters.Add("@RefNo", SqlDbType.NVarChar).Value = headerinfo[7];  //@RefNo Nvarchar(50),--null
                        cmd.Parameters.Add("@PaidTo", SqlDbType.NVarChar).Value = headerinfo[6];  //@PaidTo Nvarchar(50),--

                        cmd.Parameters.Add("@HeadAcc", SqlDbType.Int).Value = Convert.ToInt64(dtCurrentTable.Rows[irows - 1]["Transection_Ledger"]); //@HeadAcc int,--Transec Ledger No
                        cmd.Parameters.Add("@RevAcc", SqlDbType.Int).Value = Convert.ToInt64(headerinfo[5]);
                        int AccSubTypeID = 0;//@RevAcc int,--Cash Bank sours code
                        if (string.IsNullOrEmpty(dtCurrentTable.Rows[irows - 1]["Sub_Type"].ToString()))
                        {
                            cmd.Parameters.Add("@AccSubTypeID", SqlDbType.Int).Value = 1;
                            AccSubTypeID = 1;//@AccSubTypeID int,-- Sub type mo
                        }
                        else
                        {
                            cmd.Parameters.Add("@AccSubTypeID", SqlDbType.Int).Value = Convert.ToInt64(dtCurrentTable.Rows[irows - 1]["Sub_Type"]); //@AccSubTypeID int,-- Sub type mo
                            AccSubTypeID = Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Type"]);
                        }
                        if (AccSubTypeID == 1 || AccSubTypeID == 0)
                        {
                            cmd.Parameters.Add("@AccSubCode", SqlDbType.Int).Value = DBNull.Value;//@AccSubCode int,
                        }
                        else
                        {
                            cmd.Parameters.Add("@AccSubCode", SqlDbType.Int).Value = Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Ledger"]);//@AccSubCode int,
                        }
                        int AccSubTypeID1 = 0;
                        if (string.IsNullOrEmpty(dtCurrentTable.Rows[irows - 1]["Sub_Type1"].ToString()))
                        {
                            cmd.Parameters.Add("@AccSubTypeID1", SqlDbType.Int).Value = 1;//Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Type1"]);//@AccSubTypeID1 int,-- Sub type1 mo
                            AccSubTypeID1 = 1;
                        }
                        else
                        {
                            cmd.Parameters.Add("@AccSubTypeID1", SqlDbType.Int).Value = Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Type1"]);
                            AccSubTypeID1 = Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Type1"]);
                        }
                        if (AccSubTypeID1 == 1 || AccSubTypeID1 == 0)
                        {
                            cmd.Parameters.Add("@AccSubCode1", SqlDbType.Int).Value = DBNull.Value;
                        }
                        else
                        {
                            cmd.Parameters.Add("@AccSubCode1", SqlDbType.Int).Value = Convert.ToInt32((dtCurrentTable.Rows[irows - 1]["Sub_Ledger1"]));
                        }
                        int AccSubTypeID2 = 0;
                        if (string.IsNullOrEmpty(dtCurrentTable.Rows[irows - 1]["Sub_Type1"].ToString()))
                        {
                            cmd.Parameters.Add("@AccSubTypeID2", SqlDbType.Int).Value = 1;
                            AccSubTypeID2 = 1;
                        }
                        else
                        {
                            cmd.Parameters.Add("@AccSubTypeID2", SqlDbType.Int).Value = Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Type2"]);
                            AccSubTypeID2 = Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Type2"]);
                        }
                        if (AccSubTypeID2 == 1 || AccSubTypeID2 == 0)
                        {
                            cmd.Parameters.Add("@AccSubCode2", SqlDbType.Int).Value = DBNull.Value;
                        }
                        else
                        {
                            cmd.Parameters.Add("@AccSubCode2", SqlDbType.Int).Value = Convert.ToInt32((dtCurrentTable.Rows[irows - 1]["Sub_Ledger2"]));
                        }

                        if (headerinfo[8] == "CP" || headerinfo[8] == "BP")// Cash or Bank Payment
                        {
                            cmd.Parameters.Add("@DebitAmt", SqlDbType.Money).Value = dtCurrentTable.Rows[irows - 1]["Amount"];//@DebitAmt Money,--
                            cmd.Parameters.Add("@CreditAmt", SqlDbType.Money).Value = 0;

                            a = Convert.ToDouble(dtCurrentTable.Rows[irows - 1]["Amount"]);
                            Result = (a + Result);
                            cmd.Parameters.Add("@IsRevtran", SqlDbType.Int).Value = 0;      //@IsRevtran int,--0
                        }
                        else if (headerinfo[8] == "CR" || headerinfo[8] == "BR" || headerinfo[8] == "TV")
                        {
                            cmd.Parameters.Add("@DebitAmt", SqlDbType.Money).Value = 0; //@DebitAmt Money,--
                            cmd.Parameters.Add("@CreditAmt", SqlDbType.Money).Value = dtCurrentTable.Rows[irows - 1]["Amount"];//dtCurrentTable.Rows[irows - 1]["Amount"];  //@DebitAmt Money,--
                            a = Convert.ToDouble(dtCurrentTable.Rows[irows - 1]["Amount"]);
                            Result = (a + Result);
                            cmd.Parameters.Add("@IsRevtran", SqlDbType.Int).Value = 0;      //@IsRevtran int,--0
                        }
                        else
                        {
                            cmd.Parameters.Add("@DebitAmt", SqlDbType.Money).Value = dtCurrentTable.Rows[irows - 1]["Amount"];//@DebitAmt Money,--
                            cmd.Parameters.Add("@CreditAmt", SqlDbType.Money).Value = 0;  //@DebitAmt Money,--

                            a = Convert.ToDouble(dtCurrentTable.Rows[irows - 1]["Amount"]);
                            Result = (a + Result);
                        }
                        cmd.Parameters.Add("@DepartmentsID", SqlDbType.Int).Value = 0;   //@DepartmentsID int,-- Null
                        cmd.Parameters.Add("@AccRemarks", SqlDbType.NVarChar).Value = headerinfo[3]; //@AccRemarks Nvarchar(500),--memo
                        cmd.Parameters.Add("@TranComments", SqlDbType.NVarChar).Value = dtCurrentTable.Rows[irows - 1]["Transection_Memo"]; // dtCurrentTable.Rows[irows - 1]["Transection_Memo"]
                        cmd.Parameters.Add("@IsPosted", SqlDbType.Int).Value = 0;  //@IsPosted int,--0
                        if (headerinfo[8] == "CP" || headerinfo[8] == "CR")
                        {
                            /////
                            cmd.Parameters.Add("@Chequeno", SqlDbType.NVarChar).Value = DBNull.Value;                            // @Chequeno Nvarchar(50),
                            cmd.Parameters.Add("@ChequeDT", SqlDbType.DateTime).Value = DBNull.Value; //headerinfo[4];       //	@ChequeDT Datetime,
                            cmd.Parameters.Add("@ChequeBankBranch", SqlDbType.NVarChar).Value = DBNull.Value; //             //@ChequeBankBranch Nvarchar(50),
                            ////// 

                        }
                        else if (headerinfo[8] == "BP" || headerinfo[8] == "BR")
                        {
                            /////
                            cmd.Parameters.Add("@Chequeno", SqlDbType.NVarChar).Value = headerinfo[9];                      // @Chequeno Nvarchar(50),
                            if (headerinfo[10] == null)
                            {
                                cmd.Parameters.Add("@ChequeDT", SqlDbType.DateTime).Value = DBNull.Value;
                            }
                            else
                            {
                                cmd.Parameters.Add("@ChequeDT", SqlDbType.DateTime).Value = headerinfo[10];
                            }

                            cmd.Parameters.Add("@ChequeBankBranch", SqlDbType.NVarChar).Value = headerinfo[11];             //@ChequeBankBranch Nvarchar(50),
                        }
                        else
                        {
                            cmd.Parameters.Add("@Chequeno", SqlDbType.NVarChar).Value = DBNull.Value;                            // @Chequeno Nvarchar(50),
                            cmd.Parameters.Add("@ChequeDT", SqlDbType.DateTime).Value = DBNull.Value; //headerinfo[4];       //	@ChequeDT Datetime,
                            cmd.Parameters.Add("@ChequeBankBranch", SqlDbType.NVarChar).Value = DBNull.Value; //             //@ChequeBankBranch Nvarchar(50),

                        }

                        cmd.Parameters.Add("@AccVoucherTranIDRef", SqlDbType.Int).Value = 0;
                        cmd.Parameters["@AccVoucherTranIDRef"].Direction = ParameterDirection.Output;

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "VoucherCreateUpdateSingleAccounts";// "VoucherCreateUpdateSingle";
                        cmd.Transaction = Transection;
                        AccVoucherTranID = cmd.ExecuteNonQuery();
                        AccVoucherTranID = (int)cmd.Parameters["@AccVoucherTranIDRef"].Value;
                        #endregion
                    }
                    else
                    {
                        #region 2nd Transection Debit or credit Row save
                        cmd = new SqlCommand();
                        cmd.Parameters.Add("@AccVoucherTranID", SqlDbType.Int).Value = Convert.ToInt64(AccVoucherTranID);// @AccVoucherTranID int,--0
                        cmd.Parameters.Add("@AccFundID", SqlDbType.Int).Value = Convert.ToInt64(headerinfo[0]);  //@AccFundID int,--3
                        cmd.Parameters.Add("@AccBranchCode", SqlDbType.Int).Value = DBNull.Value;  //@AccBranchCode int,--1 by def
                        cmd.Parameters.Add("@VchrTypeID", SqlDbType.Int).Value = Convert.ToInt64(headerinfo[1]); //@VchrTypeID int,--2
                        cmd.Parameters.Add("@PayDate", SqlDbType.DateTime).Value = headerinfo[4];

                        //Convert.ToDateTime(EditVoucher_Date.Text).ToString("mm/dd/yyyy hh:mm:ss tt");
                        cmd.Parameters.Add("@RefNo", SqlDbType.NVarChar).Value = headerinfo[7];  //@RefNo Nvarchar(50),--null
                        cmd.Parameters.Add("@PaidTo", SqlDbType.NVarChar).Value = headerinfo[6];  //@PaidTo Nvarchar(50),--

                        cmd.Parameters.Add("@HeadAcc", SqlDbType.Int).Value = Convert.ToInt64(dtCurrentTable.Rows[irows - 1]["Transection_Ledger"]); //@HeadAcc int,--Transec Ledger No
                        cmd.Parameters.Add("@RevAcc", SqlDbType.Int).Value = Convert.ToInt64(headerinfo[5]);
                        int AccSubTypeID = 0;
                        if (string.IsNullOrEmpty(dtCurrentTable.Rows[irows - 1]["Sub_Type"].ToString()))
                        {
                            cmd.Parameters.Add("@AccSubTypeID", SqlDbType.Int).Value = 1;
                            AccSubTypeID = 1;
                        }
                        else
                        {
                            cmd.Parameters.Add("@AccSubTypeID", SqlDbType.Int).Value = Convert.ToInt64(dtCurrentTable.Rows[irows - 1]["Sub_Type"]); //@AccSubTypeID int,-- Sub type mo
                            AccSubTypeID = Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Type"]);
                        }
                        //int abc = Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Type"]);

                        if (AccSubTypeID == 1 || AccSubTypeID == 0)
                        {
                            cmd.Parameters.Add("@AccSubCode", SqlDbType.Int).Value = DBNull.Value;//@AccSubCode int,
                        }
                        else
                        {
                            cmd.Parameters.Add("@AccSubCode", SqlDbType.Int).Value = (dtCurrentTable.Rows[irows - 1]["Sub_Ledger"]);//@AccSubCode int,
                        }

                        /////////////////////////////////////////
                        int AccSubTypeID1 = 0;
                        if (string.IsNullOrEmpty(dtCurrentTable.Rows[irows - 1]["Sub_Type1"].ToString()))
                        {

                            cmd.Parameters.Add("@AccSubTypeID1", SqlDbType.Int).Value = 1;//Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Type1"]);//@AccSubTypeID1 int,-- Sub type1 mo
                            AccSubTypeID1 = 1;
                        }
                        else
                        {
                            cmd.Parameters.Add("@AccSubTypeID1", SqlDbType.Int).Value = Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Type1"]);
                            AccSubTypeID1 = Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Type1"]);
                        }
                        if (AccSubTypeID1 == 1 || AccSubTypeID1 == 0)
                        {
                            cmd.Parameters.Add("@AccSubCode1", SqlDbType.Int).Value = DBNull.Value;

                        }
                        else
                        {
                            cmd.Parameters.Add("@AccSubCode1", SqlDbType.Int).Value = Convert.ToInt32((dtCurrentTable.Rows[irows - 1]["Sub_Ledger1"]));
                        }
                        int AccSubTypeID2 = 0;

                        if (string.IsNullOrEmpty(dtCurrentTable.Rows[irows - 1]["Sub_Type2"].ToString()))
                        {
                            cmd.Parameters.Add("@AccSubTypeID2", SqlDbType.Int).Value = 1;
                            AccSubTypeID2 = 1;
                        }
                        else
                        {
                            cmd.Parameters.Add("@AccSubTypeID2", SqlDbType.Int).Value = Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Type2"]);
                            AccSubTypeID2 = Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Type2"]);
                        }
                        if (AccSubTypeID2 == 1 || AccSubTypeID2 == 0)
                        {
                            cmd.Parameters.Add("@AccSubCode2", SqlDbType.Int).Value = DBNull.Value;
                        }
                        else
                        {
                            cmd.Parameters.Add("@AccSubCode2", SqlDbType.Int).Value = Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Ledger2"]);
                        }
                        if (headerinfo[8] == "CP" || headerinfo[8] == "BP")// Cash or Bank Payment
                        {
                            cmd.Parameters.Add("@DebitAmt", SqlDbType.Money).Value = dtCurrentTable.Rows[irows - 1]["Amount"];//@DebitAmt Money,--
                            cmd.Parameters.Add("@CreditAmt", SqlDbType.Money).Value = 0;

                            a = Convert.ToDouble(dtCurrentTable.Rows[irows - 1]["Amount"]);
                            Result = (a + Result);
                            cmd.Parameters.Add("@IsRevtran", SqlDbType.Int).Value = 0;      //@IsRevtran int,--0
                        }
                        else if (headerinfo[8] == "CR" || headerinfo[8] == "BR" || headerinfo[8] == "TV")
                        {
                            cmd.Parameters.Add("@DebitAmt", SqlDbType.Money).Value = 0; //@DebitAmt Money,--
                            cmd.Parameters.Add("@CreditAmt", SqlDbType.Money).Value = dtCurrentTable.Rows[irows - 1]["Amount"];  //@DebitAmt Money,--
                            a = Convert.ToDouble(dtCurrentTable.Rows[irows - 1]["Amount"]);
                            Result = (a + Result);
                            cmd.Parameters.Add("@IsRevtran", SqlDbType.Int).Value = 0;      //@IsRevtran int,--0
                        }
                        else
                        {
                            cmd.Parameters.Add("@DebitAmt", SqlDbType.Money).Value = dtCurrentTable.Rows[irows - 1]["Amount"];//@DebitAmt Money,--
                            cmd.Parameters.Add("@CreditAmt", SqlDbType.Money).Value = 0;  //@DebitAmt Money,--

                            a = Convert.ToDouble(dtCurrentTable.Rows[irows - 1]["Amount"]);
                            Result = (a + Result);
                        }
                        cmd.Parameters.Add("@DepartmentsID", SqlDbType.Int).Value = 0;   //@DepartmentsID int,-- Null
                        cmd.Parameters.Add("@AccRemarks", SqlDbType.NVarChar).Value = headerinfo[3]; //@AccRemarks Nvarchar(500),--memo
                        cmd.Parameters.Add("@TranComments", SqlDbType.NVarChar).Value = dtCurrentTable.Rows[irows - 1]["Transection_Memo"]; // dtCurrentTable.Rows[irows - 1]["Transection_Memo"]
                        cmd.Parameters.Add("@IsPosted", SqlDbType.Int).Value = 0;  //@IsPosted int,--0
                        if (headerinfo[8] == "CP" || headerinfo[8] == "CR")
                        {
                            cmd.Parameters.Add("@Chequeno", SqlDbType.NVarChar).Value = DBNull.Value;                            // @Chequeno Nvarchar(50),
                            cmd.Parameters.Add("@ChequeDT", SqlDbType.DateTime).Value = DBNull.Value; //headerinfo[4];       //	@ChequeDT Datetime,
                            cmd.Parameters.Add("@ChequeBankBranch", SqlDbType.NVarChar).Value = DBNull.Value; //             //@ChequeBankBranch Nvarchar(50),
                        }
                        else if (headerinfo[8] == "BP" || headerinfo[8] == "BR")
                        {
                            /////
                            cmd.Parameters.Add("@Chequeno", SqlDbType.NVarChar).Value = headerinfo[9];                      // @Chequeno Nvarchar(50),
                            if (headerinfo[10] == null)
                            {
                                cmd.Parameters.Add("@ChequeDT", SqlDbType.DateTime).Value = DBNull.Value;
                            }
                            else
                            {
                                cmd.Parameters.Add("@ChequeDT", SqlDbType.DateTime).Value = headerinfo[10];
                            }

                            cmd.Parameters.Add("@ChequeBankBranch", SqlDbType.NVarChar).Value = headerinfo[11];             //@ChequeBankBranch Nvarchar(50),
                            ////// 
                        }
                        else
                        {
                            /////
                            cmd.Parameters.Add("@Chequeno", SqlDbType.NVarChar).Value = DBNull.Value;                            // @Chequeno Nvarchar(50),
                            cmd.Parameters.Add("@ChequeDT", SqlDbType.DateTime).Value = DBNull.Value; //headerinfo[4];       //	@ChequeDT Datetime,
                            cmd.Parameters.Add("@ChequeBankBranch", SqlDbType.NVarChar).Value = DBNull.Value; //             //@ChequeBankBranch Nvarchar(50),
                            ////// 

                        }
                        cmd.Parameters.Add("@AccVoucherTranIDRef", SqlDbType.Int).Value = 0;
                        cmd.Parameters["@AccVoucherTranIDRef"].Direction = ParameterDirection.Output;
                        #endregion

                        if (conn.State == 0)
                        {
                            conn.Open();
                        }
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "VoucherCreateUpdateSingleAccounts";
                        cmd.Connection = conn;
                        cmd.Transaction = Transection;
                        cmd.ExecuteNonQuery();

                    }
                    #region Last Transection Debit or credit Row save
                    int LastRow = Gridview1.Rows.Count;
                    if (irows == LastRow)
                    {
                        #region [Last Row Insert]
                        cmd = new SqlCommand();
                        //exec VoucherCreateUpdateSingle 0,3,null,2,'5/1/2015','ref','paid to Dipu',373, 164,  10,  1159, 0,0,0,0 ,777,0,0,   'HASAN MEHEDI',0,0,@AccVoucherTranIDRef Outpu
                        cmd.Parameters.Add("@AccVoucherTranID", SqlDbType.Int).Value = AccVoucherTranID;// @AccVoucherTranID int,--0
                        cmd.Parameters.Add("@AccFundID", SqlDbType.Int).Value = Convert.ToInt64(headerinfo[0]);  //@AccFundID int,--3
                        cmd.Parameters.Add("@AccBranchCode", SqlDbType.Int).Value = DBNull.Value;  //@AccBranchCode int,--1 by def
                        cmd.Parameters.Add("@VchrTypeID", SqlDbType.Int).Value = Convert.ToInt64(headerinfo[1]); //@VchrTypeID int,--2
                        cmd.Parameters.Add("@PayDate", SqlDbType.DateTime).Value = headerinfo[4];// Convert.ToDateTime(headerinfo[4]).ToString("MM/dd/yyyy hh:mm:ss tt");//PayDate

                        cmd.Parameters.Add("@RefNo", SqlDbType.NVarChar).Value = headerinfo[7];  //@RefNo Nvarchar(50),--null
                        cmd.Parameters.Add("@PaidTo", SqlDbType.NVarChar).Value = headerinfo[6];  //@PaidTo Nvarchar(50),--

                        cmd.Parameters.Add("@HeadAcc", SqlDbType.Int).Value = Convert.ToInt64(headerinfo[5]); //@HeadAcc int,--Transec Ledger No
                        cmd.Parameters.Add("@RevAcc", SqlDbType.Int).Value = Convert.ToInt64(dtCurrentTable.Rows[LastRow - 1]["Transection_Ledger"]);  //@RevAcc int,--Cash Bank sours code

                        ///////////////////////
                        int SubType = 0;
                        if (string.IsNullOrEmpty(dtCurrentTable.Rows[LastRow - 1]["Sub_Type"].ToString()))
                        {
                            SubType = Convert.ToInt32("1");
                        }
                        else
                        {
                            SubType = Convert.ToInt32(dtCurrentTable.Rows[LastRow - 1]["Sub_Type"]);
                        }
                        if (headerinfo[8] == "JV")
                        {
                            cmd.Parameters.Add("@AccSubTypeID", SqlDbType.Int).Value = SubType;  // @AccSubTypeID int,-- Sub type mo
                        }
                        else
                        {
                            cmd.Parameters.Add("@AccSubTypeID", SqlDbType.Int).Value = 1;// Convert.ToInt64(dtCurrentTable.Rows[LastRow - 1]["Sub_Type"]);   @AccSubTypeID int,-- Sub type mo
                        }


                        if (SubType == 1 || SubType == 0)
                        {
                            cmd.Parameters.Add("@AccSubCode", SqlDbType.Int).Value = DBNull.Value;//@AccSubCode int,
                        }
                        else if (headerinfo[8] == "JV")
                        {
                            cmd.Parameters.Add("@AccSubCode", SqlDbType.Int).Value = Convert.ToInt32((dtCurrentTable.Rows[LastRow - 1]["Sub_Ledger"]));//@AccSubCode int,
                        }
                        else
                        {
                            cmd.Parameters.Add("@AccSubCode", SqlDbType.Int).Value = DBNull.Value;//Convert.ToInt64(dtCurrentTable.Rows[LastRow - 1]["Sub_Ledger"]);//@AccSubCode int,
                        }
                        //////////////////////////

                        int SubType1 = 0;
                        if (string.IsNullOrEmpty(dtCurrentTable.Rows[LastRow - 1]["Sub_Type1"].ToString()))
                        {
                            SubType1 = Convert.ToInt32("1");
                        }
                        else
                        {
                            SubType1 = Convert.ToInt32(dtCurrentTable.Rows[LastRow - 1]["Sub_Type1"]);
                        }


                        if (headerinfo[8] == "JV")
                        {
                            cmd.Parameters.Add("@AccSubTypeID1", SqlDbType.Int).Value = SubType;  // @AccSubTypeID int,-- Sub type mo
                        }
                        else
                        {
                            cmd.Parameters.Add("@AccSubTypeID1", SqlDbType.Int).Value = 0;// Convert.ToInt64(dtCurrentTable.Rows[LastRow - 1]["Sub_Type"]);   @AccSubTypeID int,-- Sub type mo
                        }


                        if (SubType1 == 1 || SubType1 == 0)
                        {
                            cmd.Parameters.Add("@AccSubCode1", SqlDbType.Int).Value = DBNull.Value;//@AccSubCode int,
                        }
                        else if (headerinfo[8] == "JV")
                        {
                            cmd.Parameters.Add("@AccSubCode1", SqlDbType.Int).Value = Convert.ToInt32((dtCurrentTable.Rows[LastRow - 1]["Sub_Ledger1"]));//@AccSubCode int,
                        }
                        else
                        {
                            cmd.Parameters.Add("@AccSubCode1", SqlDbType.Int).Value = DBNull.Value;//Convert.ToInt64(dtCurrentTable.Rows[LastRow - 1]["Sub_Ledger"]);//@AccSubCode int,
                        }


                        /////////////////

                        //////////////////////////

                        int SubType2 = 0;
                        if (string.IsNullOrEmpty(dtCurrentTable.Rows[LastRow - 1]["Sub_Type2"].ToString()))
                        {
                            SubType2 = Convert.ToInt32("1");
                        }
                        else
                        {
                            SubType2 = Convert.ToInt32(dtCurrentTable.Rows[LastRow - 1]["Sub_Type2"]);
                        }


                        if (headerinfo[8] == "JV")
                        {
                            cmd.Parameters.Add("@AccSubTypeID2", SqlDbType.Int).Value = SubType2;  // @AccSubTypeID int,-- Sub type mo

                        }
                        else
                        {
                            cmd.Parameters.Add("@AccSubTypeID2", SqlDbType.Int).Value = 1;// Convert.ToInt64(dtCurrentTable.Rows[LastRow - 1]["Sub_Type"]);   @AccSubTypeID int,-- Sub type mo
                        }


                        if (SubType1 == 1 || SubType1 == 0)
                        {
                            cmd.Parameters.Add("@AccSubCode2", SqlDbType.Int).Value = 0;//@AccSubCode int,
                        }
                        else if (headerinfo[8] == "JV")
                        {
                            cmd.Parameters.Add("@AccSubCode2", SqlDbType.Int).Value = Convert.ToInt32((dtCurrentTable.Rows[LastRow - 1]["Sub_Ledger2"]));//@AccSubCode int,
                        }
                        else
                        {
                            cmd.Parameters.Add("@AccSubCode2", SqlDbType.Int).Value = DBNull.Value;//Convert.ToInt64(dtCurrentTable.Rows[LastRow - 1]["Sub_Ledger"]);//@AccSubCode int,
                        }

                        if (headerinfo[8] == "CP" || headerinfo[8] == "BP") //cash/ bank
                        {
                            cmd.Parameters.Add("@DebitAmt", SqlDbType.Money).Value = 0;//@DebitAmt Money,--
                            cmd.Parameters.Add("@CreditAmt", SqlDbType.Money).Value = Result;//dtCurrentTable.Rows[LastRow]["Amount"];//CreditAmt
                            cmd.Parameters.Add("@IsRevtran", SqlDbType.Int).Value = 1;      //@IsRevtran int,--0
                        }
                        else if (headerinfo[8] == "CR" || headerinfo[8] == "BR" || headerinfo[8] == "TV")
                        {
                            cmd.Parameters.Add("@DebitAmt", SqlDbType.Money).Value = Result;//dtCurrentTable.Rows[LastRow]["Amount"];//@DebitAmt Money,--
                            cmd.Parameters.Add("@CreditAmt", SqlDbType.Money).Value = 0;  //@CreditAmt Money,- -
                            cmd.Parameters.Add("@IsRevtran", SqlDbType.Int).Value = 1;
                        }
                        else // Need To change
                        {
                            cmd.Parameters.Add("@DebitAmt", SqlDbType.Money).Value = 0;//dtCurrentTable.Rows[LastRow]["Amount"];//@DebitAmt Money,--
                            cmd.Parameters.Add("@CreditAmt", SqlDbType.Money).Value = Result;  //@CreditAmt Money,- -
                            cmd.Parameters.Add("@IsRevtran", SqlDbType.Int).Value = 1;
                        }
                        cmd.Parameters.Add("@DepartmentsID", SqlDbType.Int).Value = 0;   //@DepartmentsID int,-- Null
                        cmd.Parameters.Add("@AccRemarks", SqlDbType.NVarChar).Value = headerinfo[3]; //@AccRemarks Nvarchar(500),--memo
                        cmd.Parameters.Add("@TranComments", SqlDbType.NVarChar).Value = dtCurrentTable.Rows[irows - 1]["Transection_Memo"];
                        cmd.Parameters.Add("@IsPosted", SqlDbType.Int).Value = 0;  //@IsPosted int,--0

                        if (headerinfo[8] == "CP" || headerinfo[8] == "CR")
                        {
                            /////
                            cmd.Parameters.Add("@Chequeno", SqlDbType.NVarChar).Value = DBNull.Value;                            // @Chequeno Nvarchar(50),
                            cmd.Parameters.Add("@ChequeDT", SqlDbType.DateTime).Value = DBNull.Value; //headerinfo[4];       //	@ChequeDT Datetime,
                            cmd.Parameters.Add("@ChequeBankBranch", SqlDbType.NVarChar).Value = DBNull.Value; //             //@ChequeBankBranch Nvarchar(50),
                            ////// 

                        }
                        else if (headerinfo[8] == "BP" || headerinfo[8] == "BR")
                        {
                            /////
                            cmd.Parameters.Add("@Chequeno", SqlDbType.NVarChar).Value = headerinfo[9];
                            // @Chequeno Nvarchar(50),
                            if (headerinfo[10] == null)
                            {
                                cmd.Parameters.Add("@ChequeDT", SqlDbType.DateTime).Value = DBNull.Value;
                            }
                            else
                            {
                                cmd.Parameters.Add("@ChequeDT", SqlDbType.DateTime).Value = headerinfo[10];
                            }

                            cmd.Parameters.Add("@ChequeBankBranch", SqlDbType.NVarChar).Value = headerinfo[11];             //@ChequeBankBranch Nvarchar(50),
                            ////// 
                        }
                        else
                        {
                            /////
                            cmd.Parameters.Add("@Chequeno", SqlDbType.NVarChar).Value = DBNull.Value;                            // @Chequeno Nvarchar(50),
                            cmd.Parameters.Add("@ChequeDT", SqlDbType.DateTime).Value = DBNull.Value; //headerinfo[4];       //	@ChequeDT Datetime,
                            cmd.Parameters.Add("@ChequeBankBranch", SqlDbType.NVarChar).Value = DBNull.Value; //             //@ChequeBankBranch Nvarchar(50),
                            ////// 

                        }

                        cmd.Parameters.Add("@AccVoucherTranIDRef", SqlDbType.Int).Value = 0;
                        cmd.Parameters["@AccVoucherTranIDRef"].Direction = ParameterDirection.Output;

                        cmd.Transaction = Transection;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "VoucherCreateUpdateSingleAccounts";
                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery();
                        SaveNprintAccVoucherTranID = AccVoucherTranID;

                        Transection.Commit();

                        #endregion

                    }
                    #endregion


                }

                lblMsg.Text = "";
                lblMsg.Text = "Transaction Complete\n";
                PopUp("Transaction Complete\n");


            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Transection.Rollback();
                //lblMsg.Text = "";
                lblMsg.Text = "Error - TRANSACTION ROLLED BACK\n" + ex.InnerException.ToString();
                PopUp("Error - TRANSACTION ROLLED BACK\n" + ex.InnerException.ToString());
                return;
            }

            clear();

            btn_save.Visible = true;
            IsAddEditMode = true;

            LastVoucherNo();

            lbl_SMsgg.Text = " Save Successfully ";
            lbl_SMsgg.Visible = true;

            EditVoucher();

                #endregion
        }
        else
        {
            PopUp("Internal saving error, Please contact to our development team ");
            return;
        }
    }

    protected void Cancel_Voucher(object sender, EventArgs e)
    {

        clear();

        Gridview1.Visible = false;
        FromNSearch.Visible = true;
        ReportForm.Visible = false;
        LB_Voucher_Print.Visible = false;
        SaveNprintAccVoucherTranID = 0;
        Return_Voucher_btn.Visible = false;
        VC_Form.Visible = true;
        CP_Header.Visible = false;
        Find_Voucher_Form.Visible = false;
        lblDate.Text = DateTime.Now.ToString("dd,MMMM,yyyy");
        txtVchrTotal.Text = "0";
        txtVchrTotal.Visible = false;
        IsAddEditMode = true;

        txt_CheckNo.Visible = false;
        DDL_CheckNo.Visible = true;
        EditVoucher_Date.Text = DateTime.Now.ToString("dd/MM/yyyy");
        dtreport = new DataTable();
        SDTDelete = new DataTable();
        dtOldTable = new DataTable();
        dtCurrentTable = new DataTable();


        Companny();
        VoucherTypes();
        CashBankSourceLoad();
        LastVoucherNo();


    }
    protected bool Is_VoucherValid_Delete(int pDelVchrtranID)
    {

        bool bRet = false;
        try
        {
            if (conn.State == 0)
            {
                conn.Open();
            }

            string SQL = "SELECT  case when A.[AccVoucherTranID] > 0 and IsNull(d.IsPosted,0) = 0 then A.[AccVoucherTranID] else 0 end AccVoucherTranID FROM dbo.AccTrnHeader A left outer join dbo.AccTrnDetail  D ON A.AccVoucherTranID = D.AccVoucherTranID where  A.YrClosing = 0 and A.AccVoucherTranID=" + pDelVchrtranID;
            SqlDataAdapter da = new SqlDataAdapter(SQL, conn);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][0] != DBNull.Value)
                {
                    int ID = Convert.ToInt32(dt.Rows[0][0]);
                    if (ID > 0)
                    {
                        bRet = true;
                    }
                }
            }

        }
        catch (Exception ex)
        {
            PopUp("Please Select Voucher Type" + ex.InnerException);
            bRet = false;
        }
        return bRet;
    }
    protected void Delete_Voucher(object sender, EventArgs e)
    {


        if (EditVoucherID > 0)
        {
            if (Is_VoucherValid_Delete(EditVoucherID))
            {
                DeleteVoucher(EditVoucherID);
            }
            else
            {
                PopUp("Not Valid Voucher ID....Please Fund Voucher Again.");
            }
        }
        else
        {
            PopUp("Not Valid Voucher ID....Please Fund Voucher Again.");
        }


    }
    protected void DeleteVoucher(int pvchrTranID)
    {

        try
        {

            string SQL_VoucherDel = "Delete FROM dbo.AccTrnHeader where YrClosing = 0 and AccVoucherTranID=" + pvchrTranID;
            if (conn.State == 0)
            {
                conn.Open();
            }

            SqlCommand delete = new SqlCommand(SQL_VoucherDel, conn);

            try
            {

                int retint = delete.ExecuteNonQuery();
                if (retint > 0)
                {
                    PopUp(" Voucher Delete Confirmed....");
                    Cancel_Voucher(null, null);
                }
                else
                {
                    PopUp(" Posted Voucher Cannot Delete....");
                }

            }
            catch (Exception ex)
            {
                lblMsg.Text = "Error when saving on database" + ex.Message;
                //LMsg.Text = "Error when saving on database";
                return;
            }
            finally
            {
                conn.Close();
            }

        }
        catch (Exception ex)
        {
            PopUp(" Voucher Delete Process Error..Please Try it Later...." + ex.InnerException);

        }


    }

    protected void Find_Voucher(object sender, EventArgs e)
    {
        btn_delete.Visible = false;
        VC_Form.Visible = false;
        Total_Sum = 0;
        Find_Voucher_Form.Visible = true;
        CP_Header.Text = "Find";
        CP_Header.Visible = true;
        Companny_find();
        VoucherTypes_find();
        DDLCashBankSource.Enabled = false;
        GV_VoucherFind.DataSource = null;
        GV_VoucherFind.DataBind();
        Find_VoucherButton.Visible = false;
        lbl_SMsgg.Text = null;


    }
    private void VoucherTypes_find()
    {

        string SQL1 = "SELECT * FROM VoucherTypes ORDER BY VchrTypeDesc ASC";// WHERE VchrTypeID= 1";
        if (conn.State == 0)
        {
            conn.Open();
        }
        SqlDataAdapter adpt1 = new SqlDataAdapter(SQL1, conn);
        DataTable dt1 = new DataTable();
        adpt1.Fill(dt1);
        DDLVoucherType_Find.DataSource = dt1;
        DDLVoucherType_Find.DataTextField = "VchrTypeDesc";
        DDLVoucherType_Find.DataValueField = "vchrTypeID";//
        DDLVoucherType_Find.DataBind();
        DDLVoucherType_Find.Items.Insert(0, new ListItem("Select", "0"));
        DDLVoucherType_Find.SelectedValue = pVchrTypeID.ToString();


    }
    private void Companny_find()
    {
        accfundID = 3;
        if (!string.IsNullOrEmpty(ad.CompanyID.ToString()))
        {
            accfundID = int.Parse(ad.CompanyID.ToString());
        }
        if (conn.State == 0)
        {
            conn.Open();
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
        DDLCompany_Name_Find.SelectedValue = accfundID.ToString();

    }
    protected void DDLCompany_Name_Find_SelectedIndexChanged(object sender, EventArgs e)
    {
        //FundSource_Find();
    }
    protected void Find_Voucher_Data(object sender, EventArgs e)
    {
        try
        {
            if (conn.State == 0)
            {
                conn.Open();
            }
            string SQL_VoucherType = "SELECT * FROM VoucherTypes WHERE VchrTypeID=" + pVchrTypeID;
            SqlDataAdapter data_VoucherType = new SqlDataAdapter(SQL_VoucherType, conn);
            data_VoucherType.SelectCommand.CommandType = CommandType.Text;
            DataTable VoucherType = new DataTable();
            data_VoucherType.Fill(VoucherType);
            VoucherTypeCodeFind = "";
            VoucherTypeCodeFind = Convert.ToString(VoucherTypeCode);


            string SQL = "SELECT [AccVoucherTranID], [VchrNumber],[RefNo],Convert(Varchar (11),[AccTranDate],106) as [AccTranDate],[PaidTo],[AccRemarks] FROM [AccTrnHeader] WHERE ";

            if (txt_CVoucher_No_Find.Text != "")
            {
                SQL += " VchrType='" + VoucherTypeCodeFind + "' AND substring(VchrNumber,9,6) LIKE '%" + txt_CVoucher_No_Find.Text.PadLeft(6, '0') + "%' AND AccFundCode='" + DDLCompany_Name_Find.SelectedValue + "'";
            }
            else
            {
                SQL += " VchrType='" + VoucherTypeCodeFind + "'AND AccFundCode='" + DDLCompany_Name_Find.SelectedValue + "'";

            }

            SQL += " ORDER BY [VchrNumber] DESC";

            if (conn.State == 0)
            {
                conn.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter(SQL, conn);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);

            GV_VoucherFind.DataSource = dt;
            GV_VoucherFind.DataBind();
        }
        catch (Exception ex)
        {
            PopUp("Please Select Voucher Type" + ex.InnerException);

        }

    }
    private void GV_VoucherFind_bind()
    {
        try
        {

            VoucherTypeCode = VoucherTypeCodeFind;// = VoucherTypeCode;
            string SQL = "SELECT [AccVoucherTranID], [VchrNumber],[RefNo],Convert(Varchar (11),[AccTranDate],106) as [AccTranDate],[PaidTo],[AccRemarks] FROM [AccTrnHeader] WHERE ";

            if (txt_CVoucher_No_Find.Text != "")
            {
                SQL += "VchrNumber LIKE '%" + txt_CVoucher_No_Find.Text + "%' AND AccFundCode='" + accfundID.ToString() + "' AND VchrType='" + VoucherTypeCodeFind + "'";
            }
            else
            {
                SQL += " VchrType='" + VoucherTypeCodeFind + "'AND AccFundCode='" + accfundID.ToString() + "'";

            }

            SQL += " ORDER BY [VchrNumber] DESC";

            if (conn.State == 0)
            {
                conn.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter(SQL, conn);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);

            GV_VoucherFind.DataSource = dt;
            GV_VoucherFind.DataBind();
        }
        catch
        {
            PopUp("Please Select Voucher Type");

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

        EditVoucher();
        Find_Voucher_Form.Visible = false;
        VC_Form.Visible = true;
        btn_delete.Visible = true;
        EditVoucher_Date.Visible = true;
        lblDate.Visible = false;
        Total_Sum = 0;
        Total_Amount.Visible = true;
    }
    private void EditVoucher()
    {
        Total_Amount.Visible = true;
        LB_Voucher_Print.Visible = true;
        CP_Header.Text = "";
        CP_Header.Text = "Edit";
        CP_Header.Visible = true;
        dtOldTable = null;
        Find_VoucherButton.Visible = true;
        txt_CheckNo.Visible = false;
        DDL_CheckNo.Visible = true;

        if (SaveNprintAccVoucherTranID != 0)
        {
            EditVoucherID = SaveNprintAccVoucherTranID;
        }
        else
        {
            EditVoucherID = 0;
            EditVoucherID = Convert.ToInt32(GV_VoucherFind.SelectedDataKey["AccVoucherTranID"].ToString());

        }

        if (conn.State == 0)
        {
            conn.Open();
        }

        string SQL = "SELECT VchrNo,[AccTrnDetailID],[AccTranSLNO],[RevAcc],[AccVoucherTranID],[AccFundID],[VchrTypeID],[AccCode] as Transection_Ledger,[Debit],[Credit],[AccCurrency] as Currency ,[AccCurrencyRate] as Exchange_Rate,[AccSubTypeID] as Sub_Type ,[AccSubCode] as Sub_Ledger,[AccSubTypeID1] as Sub_Type1,[AccSubCode1] as Sub_Ledger1,[AccSubTypeID2] as Sub_Type2,[AccSubCode2] as Sub_Ledger2,ChequeDT,ChequeBankBranch,Chequeno,Tran_Comment FROM [AccTrnDetail] Where AccVoucherTranID=" + EditVoucherID + " AND IsRevtran !=1";

        SqlDataAdapter da = new SqlDataAdapter(SQL, conn);
        da.SelectCommand.CommandType = CommandType.Text;
        DataTable dtTranDetails = new DataTable();
        da.Fill(dtTranDetails);
        dtreport = dtTranDetails;

        /////////////
        string SQLHeader = "Select * from [AccTrnHeader] Where  AccVoucherTranID=" + EditVoucherID + "";
        SqlDataAdapter daHeader = new SqlDataAdapter(SQLHeader, conn);
        daHeader.SelectCommand.CommandType = CommandType.Text;
        DataTable dtHeader = new DataTable();
        daHeader.Fill(dtHeader);
        /////////////////

        string VTypeCode = Convert.ToString(dtHeader.Rows[0]["vchrType"]);
        EditAccVoucherTranID = 0;
        EditAccVoucherTranID = Convert.ToInt32(EditVoucherID);


        DateTime VchrDate = Convert.ToDateTime(dtHeader.Rows[0]["AccTranDate"]);

        string Date = VchrDate.Day.ToString() + "/" + VchrDate.Month.ToString() + "/" + VchrDate.Year.ToString();// Convert.ToDateTime(EditVoucher_Date.Text).ToString("MM/dd/yyyy");// EditVoucher_Date.Text;

        EditVoucher_Date.Text = Date;// Convert.ToDateTime(dtHeader.Rows[0]["AccTranDate"]).ToString("dd/mm/yyyy");//Convert.ToInt32(GV_VoucherFind.SelectedDataKey["AccVoucherTranID"].ToString());

        lblDate.Text = Date;
        Lbl_Last_VoucherNo.Text = Convert.ToString(dtHeader.Rows[0]["VchrNumber"]);



        if (dtOldTable == null)
        {
            dtOldTable = new DataTable();
            DataRow dr = null;
            dtOldTable.Columns.Add(new DataColumn("RowNumber", typeof(string)));
            dtOldTable.Columns.Add(new DataColumn("Transection_Ledger", typeof(string)));
            dtOldTable.Columns.Add(new DataColumn("Sub_Type", typeof(string)));
            dtOldTable.Columns.Add(new DataColumn("Sub_Ledger", typeof(string)));
            dtOldTable.Columns.Add(new DataColumn("Sub_Type1", typeof(string)));
            dtOldTable.Columns.Add(new DataColumn("Sub_Ledger1", typeof(string)));
            dtOldTable.Columns.Add(new DataColumn("Sub_Type2", typeof(string)));
            dtOldTable.Columns.Add(new DataColumn("Sub_Ledger2", typeof(string)));
            dtOldTable.Columns.Add(new DataColumn("Amount", typeof(string)));
            dtOldTable.Columns.Add(new DataColumn("Currency", typeof(string)));
            dtOldTable.Columns.Add(new DataColumn("Exchange_Rate", typeof(string)));
            dtOldTable.Columns.Add(new DataColumn("Old_Data", typeof(string)));
            dtOldTable.Columns.Add(new DataColumn("Transection_Memo", typeof(string)));

            for (int rnow = 1; dtTranDetails.Rows.Count >= rnow; rnow++)
            {
                dr = dtOldTable.NewRow();
                dr["RowNumber"] = rnow; // tran details ID
                dr["Transection_Ledger"] = dtTranDetails.Rows[rnow - 1]["Transection_Ledger"];//string.Empty;Convert.ToInt64(dtCurrentTable.Rows[LastRow - 1]["Transection_Ledger"]);
                dr["Sub_Type"] = dtTranDetails.Rows[rnow - 1]["Sub_Type"];//string.Empty;
                dr["Sub_Ledger"] = dtTranDetails.Rows[rnow - 1]["Sub_Ledger"];// string.Empty;

                dr["Sub_Type1"] = dtTranDetails.Rows[rnow - 1]["Sub_Type1"];//string.Empty;
                dr["Sub_Ledger1"] = dtTranDetails.Rows[rnow - 1]["Sub_Ledger1"];// string.Empty;
                dr["Sub_Type2"] = dtTranDetails.Rows[rnow - 1]["Sub_Type2"];// string.Empty;
                dr["Sub_Ledger2"] = dtTranDetails.Rows[rnow - 1]["Sub_Ledger2"];// string.Empty;
                if (VTypeCode == "CP" || VTypeCode == "BP")
                {
                    dr["Amount"] = Convert.ToDecimal(dtTranDetails.Rows[rnow - 1]["Debit"]).ToString("#,##0.00");// dtTranDetails.Rows[rnow - 1]["Debit"];//string.Empty;
                }
                else if (VTypeCode == "CR" || VTypeCode == "BR")
                {
                    dr["Amount"] = Convert.ToDecimal(dtTranDetails.Rows[rnow - 1]["Credit"]).ToString("#,##0.00"); //dtTranDetails.Rows[rnow - 1]["Credit"];//string.Empty;
                }
                else
                {
                    dr["Amount"] = Convert.ToDecimal(dtTranDetails.Rows[rnow - 1]["Debit"]).ToString("#,##0.00");//dtTranDetails.Rows[rnow - 1]["Debit"];//string.Empty;
                }

                dr["Currency"] = dtTranDetails.Rows[rnow - 1]["Currency"];// string.Empty;
                dr["Exchange_Rate"] = dtTranDetails.Rows[rnow - 1]["Exchange_Rate"]; // string.Empty;
                dr["Old_Data"] = "1"; // string.Empty;
                dr["Transection_Memo"] = dtTranDetails.Rows[rnow - 1]["Tran_Comment"];
                dtOldTable.Rows.Add(dr);

            }

        }

        string ChkDate = "";
        string[] VoucherInfo = new string[11];
        VoucherInfo[0] = dtHeader.Rows[0]["AccFundCode"].ToString();// Company Name
        VoucherInfo[1] = dtHeader.Rows[0]["VchrTypesID"].ToString();
        VoucherInfo[2] = dtHeader.Rows[0]["PaidTo"].ToString();
        VoucherInfo[3] = dtHeader.Rows[0]["AccRemarks"].ToString();
        VoucherInfo[4] = dtHeader.Rows[0]["RefNo"].ToString();
        VoucherInfo[8] = string.Empty;
        VoucherInfo[7] = string.Empty;

        if (dtTranDetails.Rows.Count > 0)
        {
            if (dtTranDetails.Rows[0]["RevAcc"] != DBNull.Value)
            {
                VoucherInfo[5] = dtTranDetails.Rows[0]["RevAcc"].ToString();
            }
            if (dtTranDetails.Rows[0]["RevAcc"] != DBNull.Value)
            {
                VoucherInfo[6] = dtTranDetails.Rows[0]["Chequeno"].ToString();
            }
            if (dtTranDetails.Rows[0]["ChequeDT"] != DBNull.Value)
            {
                // Read from Database
                DateTime ChkVchrDate = Convert.ToDateTime(dtTranDetails.Rows[0]["ChequeDT"]);
                ChkDate = ChkVchrDate.Day.ToString() + "/" + ChkVchrDate.Month.ToString() + "/" + ChkVchrDate.Year.ToString();// Convert.ToDateTime(EditVoucher_Date.Text).ToString("MM/dd/yyyy");// EditVoucher_Date.Text;
            }
            VoucherInfo[8] = dtTranDetails.Rows[0]["ChequeBankBranch"].ToString();
            VoucherInfo[7] = ChkDate;// Convert.ToDateTime(dtTranDetails.Rows[0]["ChequeDT"]).ToString("dd/mm/yyyy");//Convert.ToDateTime(dtHeader.Rows[0]["AccTranDate"]).ToString("MMMM/dd/yyyy")
        }

        //VoucherInfo[9] = dtTranDetails.Rows[0]["Chequeno"].ToString();
        DDLCompany_Name.SelectedValue = VoucherInfo[0];
        DDLVoucherType.SelectedValue = VoucherInfo[1];

        txt_Paid_To.Text = VoucherInfo[2];
        txt_Voucher_Narration.Text = VoucherInfo[3];
        txtRefNo.Text = VoucherInfo[4];



        txt_Check_Date.Text = VoucherInfo[7];
        txt_Branch_Name.Text = VoucherInfo[8];
        VoucherTypeRead();
        DDLCashBankSource.DataSource = null;
        CashBankSourceLoad();
        DDLCashBankSource.SelectedValue = VoucherInfo[5];
        DDL_CheckNo.DataSource = null;
        if ((pVchrTypeID == 3) || (pVchrTypeID == 4))
        {
            if (pVchrTypeID == 3)
            {
                CheckNo();
                DDL_CheckNo.SelectedItem.Text = VoucherInfo[6];
                DDL_CheckNo.Enabled = false;
                txt_CheckNo.Visible = false;
            }
            if (pVchrTypeID == 4)
            {
                txt_CheckNo.Text = VoucherInfo[6];
                DDL_CheckNo.Visible = false;
                txt_CheckNo.Visible = true;
            }

        }

        dtCurrentTable = null;
        dtCurrentTable = dtOldTable;
        SetInitialRowforEdit();
        Total_Ammount_Calculation();

        Gridview1.Visible = true;
        DDLCompany_Name.Enabled = false;
        DDLVoucherType.Enabled = false;
        DDLCashBankSource.Enabled = false;
        IsAddEditMode = false;

        tr_for_CashPayment.Visible = false;
        tr_for_CashPayment1.Visible = false;
        tr_for_CashPayment2.Visible = false;
        tr_for_CashPayment3.Visible = false;
        tr_for_CashPayment4.Visible = false;
        tr_for_CashPayment5.Visible = false;
        if (VoucherTypeCode == "BP" || VoucherTypeCode == "BR")
        {
            tr_for_CashPayment.Visible = true;
            tr_for_CashPayment1.Visible = true;
            tr_for_CashPayment2.Visible = true;
            tr_for_CashPayment3.Visible = true;
            tr_for_CashPayment4.Visible = true;
            tr_for_CashPayment5.Visible = true;
        }
    }
    protected void Add_PaidTo(object sender, EventArgs e)
    {
        clear();
        Response.Redirect("~/Pages/CostCenters.aspx");
    }

    private DataTable getdata(int prm, int prm1, int prm2, string prm3, string prm4)
    {
        DataTable dt = new DataTable();
        {
            if (conn.State == 0)
            {
                conn.Open();
            }
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
    protected void OK_Report(object sender, EventArgs e)
    {
        string PDFPath = new DirectoryInfo(HttpContext.Current.Server.MapPath("~/")).Parent.FullName + "\\WebApp\\PDF\\";
        bool IsExitsPDF = File.Exists(PDFPath + fileName);

        if (IsExitsPDF)
        {
            File.Delete(PdfLocation);
        }
        FromNSearch.Visible = true;
        ReportForm.Visible = false;
        clear();
        SaveNprintAccVoucherTranID = 0;
        Return_Voucher_btn.Visible = false;
        if (pVchrTypeID == 1)
        {
            Response.Redirect("~/Pages/CashPayment.aspx");
        }
        if (pVchrTypeID == 2)
        {
            Response.Redirect("~/Pages/CashReceipt.aspx");
        }
        if (pVchrTypeID == 3)
        {
            Response.Redirect("~/Pages/BankPayment.aspx");
        }
        if (pVchrTypeID == 4)
        {
            Response.Redirect("~/Pages/BankReceipt.aspx");
        }
        if (pVchrTypeID == 5)
        {
            Response.Redirect("~/Pages/CashReceipt.aspx");
        }
        if (pVchrTypeID == 6)
        {
            Response.Redirect("~/Pages/Voucher.aspx");
        }

    }

    protected void Gridview1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        //if (e.CommandName == "Delete")
        //{
        //    int rowIndex1 = Convert.ToInt32(e.CommandArgument);

        //    SetInitialRowforDlete(rowIndex1);

        //}
    }

    protected void Gridview1_RowDataBound(object sender, GridViewRowEventArgs e)
    {

        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            DropDownList DDLT_Ledger = (DropDownList)e.Row.FindControl("DDLTransection_Ledger");
            //DropDownList DDLS_Ledger = (DropDownList)e.Row.FindControl("DDLS_Ledger");
            //DropDownList DDLS_Ledger1 = (DropDownList)e.Row.FindControl("DDLS_Ledger1");
            //DropDownList DDLS_Ledger2 = (DropDownList)e.Row.FindControl("DDLS_Ledger2");
            TextBox txt_Amount = (TextBox)e.Row.FindControl("txt_Amount");
            if (dtCurrentTable.Rows[e.Row.RowIndex]["Old_Data"] == "1")
            {
                DDLT_Ledger.Enabled = false;
                //DDLS_Ledger.Enabled = false;
                txt_Amount.Enabled = false;
                e.Row.Cells[11].Enabled = false;
            }
            e.Row.Attributes.Add("onClick", Page.ClientScript.GetPostBackEventReference(sender as GridView, "Select$" + e.Row.RowIndex.ToString()));
        }

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

    protected void ButtonDlt_Click(object sender, EventArgs e)
    {
        GridViewRow rowT_Ledger = (GridViewRow)(((Control)sender).NamingContainer);

        int rowIndex1 = Convert.ToInt32(rowT_Ledger.RowIndex);

        SetInitialRowforDlete(rowIndex1);
        Total_Ammount_Calculation();
        // ScriptManager ad = new ScriptManager();

        //ad.FindControl("Gridview1").DataBind();

    }

    protected void Print_Voucher(object sender, EventArgs e)
    {
        string PDFPath = new DirectoryInfo(HttpContext.Current.Server.MapPath("~/")) + "PDF\\";
        bool IsExitsPDF = File.Exists(PDFPath + fileName);

        if (IsExitsPDF)
        {
            File.Delete(PdfLocation);

            Return_Voucher_btn.Visible = true;
            CP_Header.Text = "";
            CP_Header.Text = "Report";
            FromNSearch.Visible = false;
            ReportForm.Visible = true;
            ////
            lbl_SMsgg.Text = null;
            lbl_SMsgg.Visible = false;


            try
            {
                string[] perameter = new string[5];
                perameter[0] = dtreport.Rows[0]["AccFundID"].ToString();//DDLCompany_Name.SelectedValue;
                perameter[1] = dtreport.Rows[0]["VchrTypeID"].ToString();// DDLVoucherType.SelectedValue;
                perameter[2] = dtreport.Rows[0]["RevAcc"].ToString();// DDLVoucherType.SelectedValue;
                // DDLCashBankSource.SelectedValue;
                perameter[3] = dtreport.Rows[0]["VchrNo"].ToString();// DDLVoucherNo.SelectedValue;
                string a = DateTime.Now.ToString();
                perameter[4] = Convert.ToDateTime(a).ToString();


                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.Reset();
                DataTable dt = getdata(Convert.ToInt32(perameter[0]), Convert.ToInt32(perameter[1]), Convert.ToInt32(perameter[2]), Convert.ToString(perameter[3]), perameter[4]);//, perameter[1], perameter[2], perameter[3], perameter[4]);
                ReportDataSource rds = new ReportDataSource("CP_Data_GetVoucherPrintIpac", dt);
                ReportViewer1.LocalReport.DataSources.Add(rds);

                string ReportPath = new DirectoryInfo(HttpContext.Current.Server.MapPath("/Controls/")) + "CashPaymentVoucher.rdlc";
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



                //  string PDFPath = new DirectoryInfo(HttpContext.Current.Server.MapPath("~/")).Parent.FullName + "\\WebApp\\PDF\\";
                Microsoft.Reporting.WebForms.Warning[] warnings = null;
                string[] streamids = null;
                String mimeType = null;
                String encoding = null;
                String extension = null;
                Byte[] bytes = null;

                fileName = "CashPaymentVoucher" + DateTime.Now.ToFileTime() + ".pdf";

                bytes = ReportViewer1.LocalReport.Render("PDF", "", out mimeType, out encoding, out extension, out streamids, out warnings);
                //  bool IsExitsPDF = File.Exists(PDFPath + fileName);

                FileStream fs = new FileStream(PDFPath + fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                byte[] data = new byte[fs.Length];
                fs.Write(bytes, 0, bytes.Length);
                fs.Close();
                PdfLocation = PDFPath + fileName;

                report.Attributes.Add("src", "../PDF/" + fileName);

            }

            catch (Exception ex)
            {

                PopUp("Printing Voucher Problem. Please Try Again. " + ex.InnerException);
            }
        }
        else
        {
            Return_Voucher_btn.Visible = true;
            CP_Header.Text = "";
            CP_Header.Text = "Report";
            FromNSearch.Visible = false;
            ReportForm.Visible = true;
            ////
            lbl_SMsgg.Text = null;
            lbl_SMsgg.Visible = false;


            try
            {
                string[] perameter = new string[5];
                perameter[0] = dtreport.Rows[0]["AccFundID"].ToString();//DDLCompany_Name.SelectedValue;
                perameter[1] = dtreport.Rows[0]["VchrTypeID"].ToString();// DDLVoucherType.SelectedValue;
                perameter[2] = dtreport.Rows[0]["RevAcc"].ToString();// DDLVoucherType.SelectedValue;
                // DDLCashBankSource.SelectedValue;
                perameter[3] = dtreport.Rows[0]["VchrNo"].ToString();// DDLVoucherNo.SelectedValue;
                string a = DateTime.Now.ToString();
                perameter[4] = Convert.ToDateTime(a).ToString();


                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.Reset();
                DataTable dt = getdata(Convert.ToInt32(perameter[0]), Convert.ToInt32(perameter[1]), Convert.ToInt32(perameter[2]), Convert.ToString(perameter[3]), perameter[4]);//, perameter[1], perameter[2], perameter[3], perameter[4]);
                ReportDataSource rds = new ReportDataSource("CP_Data_GetVoucherPrintIpac", dt);
                ReportViewer1.LocalReport.DataSources.Add(rds);

                string ReportPath = new DirectoryInfo(HttpContext.Current.Server.MapPath("/Controls/")) + "CashPaymentVoucher.rdlc";
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



                Microsoft.Reporting.WebForms.Warning[] warnings = null;
                string[] streamids = null;
                String mimeType = null;
                String encoding = null;
                String extension = null;
                Byte[] bytes = null;

                fileName = "CashPaymentVoucher" + DateTime.Now.ToFileTime() + ".pdf";

                bytes = ReportViewer1.LocalReport.Render("PDF", "", out mimeType, out encoding, out extension, out streamids, out warnings);
                //  bool IsExitsPDF = File.Exists(PDFPath + fileName);

                FileStream fs = new FileStream(PDFPath + fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                byte[] data = new byte[fs.Length];
                fs.Write(bytes, 0, bytes.Length);
                fs.Close();
                PdfLocation = PDFPath + fileName;

                report.Attributes.Add("src", "../PDF/" + fileName);

            }

            catch (Exception ex)
            {

                PopUp("Printing Voucher Problem. Please Try Again. " + ex.InnerException);
            }
        }


    }
}