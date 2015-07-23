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



public partial class Controls_ChequeIssue : System.Web.UI.UserControl
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
    DataTable dtVchrTypes;
    //  static string addflag = "";
    MyCompany.Rules.SharedBusinessRules ad = new MyCompany.Rules.SharedBusinessRules();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            accfundID = 0;
            dtVchrTypes = new DataTable();
            VC_Form.Visible = true;
            CP_Header.Visible = false;
            Find_Voucher_Form.Visible = false;
            Companny();
            VoucherTypes();
            Gridview1.Visible = false;

            FromNSearch.Visible = true;
            ReportForm.Visible = false;
            LB_Voucher_Print.Visible = false;
            SaveNprintAccVoucherTranID = 0;
            Return_Voucher_btn.Visible = false;
            CashBankSourceLoad();
            lblDate.Text = DateTime.Now.ToString("dd,MMMM,yyyy");
            FundSource();
            IsAddEditMode = true;
            LastVoucherNo();
            txt_CheckNo.Visible = false;
            DDL_CheckNo.Visible = true;
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

        conn.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;

        cmd.Parameters.Add("@AccFundCode", SqlDbType.Int).Value = DDLCompany_Name.SelectedValue;
        cmd.Parameters.Add("@VDate", SqlDbType.DateTime).Value = EditedDate;
        cmd.Parameters.Add("@VTypeID", SqlDbType.Int).Value = DDLVoucherType.SelectedValue;


        cmd.Parameters.Add("@GenVNo", SqlDbType.NVarChar, 50).Value = "0";
        cmd.Parameters["@GenVNo"].Direction = ParameterDirection.Output;

        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "GenerateVoucherNumberIPAC";

        LastVNo = cmd.ExecuteNonQuery();

        string LastVoucherNo = (string)cmd.Parameters["@GenVNo"].Value;
        Lbl_Last_VoucherNo.Text = LastVoucherNo;
    }
    private void VoucherTypeRead()
    {
        if (DDLVoucherType.SelectedValue != null)
            pVchrTypeID = Convert.ToInt32(DDLVoucherType.SelectedValue);

        if (dtVchrTypes.Rows.Count > 0)
        {
            VoucherTypeCode = Convert.ToString(dtVchrTypes.Rows[0]["vchrType"]);
        }
    }
    private void CashBankSourceLoad()
    {
        if (VoucherTypeCode == "CP" || VoucherTypeCode == "CR")//CP,BP
        {
            tr_Cash_Bank.Visible = true;
            tr_Cash_Bank1.Visible = true;

            SqlDataAdapter da = new SqlDataAdapter("BBLCashAccounts", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            DDLCashBankSource.DataSource = dt;
            DDLCashBankSource.DataTextField = "AccName";
            DDLCashBankSource.DataValueField = "CoaDetailID";
            DDLCashBankSource.DataBind();

            DDLCashBankSource.Items.Insert(0, new ListItem("Select", "0"));


        }
        else if (VoucherTypeCode == "BP" || VoucherTypeCode == "BR")//CR BR
        {

            tr_Cash_Bank.Visible = true;
            tr_Cash_Bank1.Visible = true;

            SqlDataAdapter da = new SqlDataAdapter("BBLBankAccounts", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            DDLCashBankSource.DataSource = dt;
            DDLCashBankSource.DataTextField = "AccName";
            DDLCashBankSource.DataValueField = "CoaDetailID";
            DDLCashBankSource.DataBind();
            DDLCashBankSource.Items.Insert(0, new ListItem("Select", "0"));

        }
        else if (VoucherTypeCode == "TV")//5TV
        {


            tr_Cash_Bank.Visible = true;
            tr_Cash_Bank1.Visible = true;

            SqlDataAdapter da = new SqlDataAdapter("BBL_Cash_Bank_Account", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            DDLCashBankSource.DataSource = dt;
            DDLCashBankSource.DataTextField = "AccName";
            DDLCashBankSource.DataValueField = "CoaDetailID";
            DDLCashBankSource.DataBind();
            DDLCashBankSource.Items.Insert(0, new ListItem("Select", "0"));

        }
        else if (VoucherTypeCode == "JV")//6JV
        {

            tr_Cash_Bank.Visible = false;
            tr_Cash_Bank1.Visible = false;
        }
        else if (VoucherTypeCode == "TS")//7TS
        {

        }
        else
        {

        }


    }
    private void VoucherTypes()
    {

        conn.Open();
        string SQL1 = "SELECT * FROM VoucherTypes WHERE VchrTypeID = 3 ORDER BY VchrTypeDesc ASC";
        SqlDataAdapter adpt1 = new SqlDataAdapter(SQL1, conn);

        adpt1.Fill(dtVchrTypes);
        DDLVoucherType.DataSource = dtVchrTypes;
        DDLVoucherType.DataTextField = "VchrTypeDesc";
        DDLVoucherType.DataValueField = "vchrTypeID";//
        conn.Close();
        DDLVoucherType.DataBind();

        DDLVoucherType.Items.Insert(0, new ListItem("Select", "0"));
        DDLVoucherType.SelectedValue = "3";
        VoucherTypeRead();
    }

    private void Companny()
    {
        accfundID = 3;
        if (!string.IsNullOrEmpty(ad.CompanyID.ToString()))
        {
            accfundID = int.Parse(ad.CompanyID.ToString());
        }
        conn.Open();
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
        conn.Close();
        DDLCompany_Name.DataBind();
        DDLCompany_Name.Items.Insert(0, new ListItem("Select", "0"));
        DDLCompany_Name.SelectedValue = accfundID.ToString();

    }
    private void FundSource()
    {

        //string SQL = "SELECT [BankID],[BankCode],[BankName],[BranchName],[AccCode] FROM [BanksInfo] WHERE [AccCode]=" + DDLCompany_Name.SelectedValue + " ORDER BY [BankName] ASC";
        //conn.Open();
        //SqlDataAdapter da = new SqlDataAdapter(SQL, conn);
        //da.SelectCommand.CommandType = CommandType.Text;
        //DataTable dtFundSource = new DataTable();
        //da.Fill(dtFundSource);
        //DDLFund_Source.DataSource = dtFundSource;
        //DDLFund_Source.DataTextField = "BankName";
        //DDLFund_Source.DataValueField = "BankID";
        //DDLFund_Source.DataBind();
        //DDLFund_Source.Items.Insert(0, new ListItem("Select", "0"));
        //conn.Close();




    }
    protected void Gridview_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Total_Sum = 0;
        SDTDelete = dtCurrentTable;
        SDTDelete.Rows[e.RowIndex].Delete();
        dtCurrentTable = SDTDelete;
        Gridview1.DataSource = SDTDelete;
        Gridview1.DataBind();


        Decimal Total = 0m;
        Decimal Sum_Total = 0m;

        for (int irow = 1; dtCurrentTable.Rows.Count >= irow; irow++)
        {
            Total = Convert.ToDecimal(dtCurrentTable.Rows[irow - 1]["Amount"].ToString());
            Sum_Total = Sum_Total + Total;
        }


        Sum_amount.Text = Convert.ToDecimal(Sum_Total).ToString("#,##0.00");//string.Format("{0:c0}", Sum_Total);

    }
    private void SetInitialRow()
    {
        try
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
            }
            else
            {
            }

        }
        catch
        {
        }
    }
    protected void ButtonAdd_Click(object sender, EventArgs e)
    {
        AddNewRowToGrid();
    }
    private void AddNewRowToGrid()
    {
        try
        {
            DataRow drCurrentRow = null;
            Total_Sum = 0;
            for (int irow = 1; Gridview1.Rows.Count >= irow; irow++)
            {
                DropDownList DDLTransection_Ledger = (DropDownList)Gridview1.Rows[irow - 1].Cells[1].FindControl("DDLTransection_Ledger");
                DropDownList DDLSub_Type = (DropDownList)Gridview1.Rows[irow - 1].Cells[2].FindControl("DDLSub_Type");
                DropDownList DDLSub_Ledger = (DropDownList)Gridview1.Rows[irow - 1].Cells[3].FindControl("DDLSub_Ledger");
                DropDownList DDLSub_Type1 = (DropDownList)Gridview1.Rows[irow - 1].Cells[4].FindControl("DDLSub_Type1");
                DropDownList DDLSub_Ledger1 = (DropDownList)Gridview1.Rows[irow - 1].Cells[5].FindControl("DDLSub_Ledger1");
                DropDownList DDLSub_Type2 = (DropDownList)Gridview1.Rows[irow - 1].Cells[6].FindControl("DDLSub_Type2");
                DropDownList DDLSub_Ledger2 = (DropDownList)Gridview1.Rows[irow - 1].Cells[7].FindControl("DDLSub_Ledger2");
                TextBox txt_Amount = (TextBox)Gridview1.Rows[irow - 1].Cells[8].FindControl("txt_Amount");
                DropDownList DDLCurrency = (DropDownList)Gridview1.Rows[irow - 1].Cells[9].FindControl("DDLCurrency");
                TextBox txt_Exchange_Rate = (TextBox)Gridview1.Rows[irow - 1].Cells[10].FindControl("txt_Exchange_Rate");

                TextBox txt_Transection_Memo = (TextBox)Gridview1.Rows[irow - 1].Cells[11].FindControl("txt_Transection_Memo");

                dtCurrentTable.Rows[irow - 1]["Transection_Ledger"] = DDLTransection_Ledger.SelectedValue;
                dtCurrentTable.Rows[irow - 1]["Sub_Type"] = DDLSub_Type.SelectedValue;
                dtCurrentTable.Rows[irow - 1]["Sub_Ledger"] = DDLSub_Ledger.SelectedValue;
                dtCurrentTable.Rows[irow - 1]["Sub_Type1"] = DDLSub_Type1.SelectedValue;
                dtCurrentTable.Rows[irow - 1]["Sub_Ledger1"] = DDLSub_Ledger1.SelectedValue;
                dtCurrentTable.Rows[irow - 1]["Sub_Type2"] = DDLSub_Type2.SelectedValue;
                dtCurrentTable.Rows[irow - 1]["Sub_Ledger2"] = DDLSub_Ledger2.SelectedValue;
                dtCurrentTable.Rows[irow - 1]["Amount"] = txt_Amount.Text;
                dtCurrentTable.Rows[irow - 1]["Currency"] = DDLCurrency.SelectedValue;
                dtCurrentTable.Rows[irow - 1]["Exchange_Rate"] = txt_Exchange_Rate.Text;
                dtCurrentTable.Rows[irow - 1]["Transection_Memo"] = txt_Transection_Memo.Text;
            }
            int Count = Gridview1.Rows.Count;
            irows = Count + 1;
            drCurrentRow = dtCurrentTable.NewRow();
            drCurrentRow["RowNumber"] = irows;
            dtCurrentTable.Rows.Add(drCurrentRow);
            Gridview1.DataSource = dtCurrentTable;
            Gridview1.DataBind();

        }
        catch (Exception ex)
        {
            PopUp(ex.Message.ToString());
            lblMsg.Text = "Grid Data Load Error" + ex.Message.ToString();
        }
    }
    public void Gridview_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {

            e.Row.Cells[9].Visible = false;
            e.Row.Cells[10].Visible = false;
            string sSubTypeID;
            // Total_Sum = 0;

            if (e.Row.RowType == DataControlRowType.DataRow)
            {


                #region  GreadView Dropdown List Currency
                DropDownList Currency = (DropDownList)e.Row.FindControl("DDLCurrency");
                string SQLCurrency = "SELECT * FROM AccCurrencys";
                SqlDataAdapter adptCurrency = new SqlDataAdapter(SQLCurrency, conn);
                DataTable dtCurrency = new DataTable();
                adptCurrency.Fill(dtCurrency);
                Currency.DataSource = dtCurrency;
                Currency.DataTextField = "AccCurrencySymble";
                Currency.DataValueField = "AccCurrencyID";
                Currency.DataBind();
                #endregion

                ////////////////////////////////////////////////////////
                if (DDLVoucherType.SelectedValue != "0")
                {
                    // CP= Cash Payment BP= Bank Payment Voucher type selection Check 
                    if (VoucherTypeCode == "CP" || VoucherTypeCode == "BP")//1 CP, 3 BP
                    {
                        DropDownList DDLTransection_Ledger = (DropDownList)e.Row.FindControl("DDLTransection_Ledger");
                        SqlDataAdapter da1 = new SqlDataAdapter("Usp_Vchr_ChartofAccFund", conn);
                        da1.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da1.SelectCommand.Parameters.Add("@AccFundCode", SqlDbType.Int).Value = DDLCompany_Name.SelectedValue;//3
                        da1.SelectCommand.Parameters.Add("@Vchr_Type", SqlDbType.Char).Value = "D";
                        DataTable Vchr_ChartofAccFund = new DataTable();
                        da1.Fill(Vchr_ChartofAccFund);
                        DDLTransection_Ledger.DataSource = Vchr_ChartofAccFund;
                        DDLTransection_Ledger.DataTextField = "AccName";
                        DDLTransection_Ledger.DataValueField = "CoaDetailID";
                        DDLTransection_Ledger.DataBind();

                    }
                    // CR= Cash Recive BR= Bank Recive Voucher type selection Check
                    else if (VoucherTypeCode == "CR" || VoucherTypeCode == "BR")//2 CR, 4 BR
                    {
                        DropDownList DDLTransection_Ledger = (DropDownList)e.Row.FindControl("DDLTransection_Ledger");
                        SqlDataAdapter da1 = new SqlDataAdapter("Usp_Vchr_ChartofAccFund", conn);
                        da1.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da1.SelectCommand.Parameters.Add("@AccFundCode", SqlDbType.Int).Value = DDLCompany_Name.SelectedValue;//3
                        da1.SelectCommand.Parameters.Add("@Vchr_Type", SqlDbType.Char).Value = "R";
                        DataTable Vchr_ChartofAccFund = new DataTable();
                        da1.Fill(Vchr_ChartofAccFund);
                        DDLTransection_Ledger.DataSource = Vchr_ChartofAccFund;
                        DDLTransection_Ledger.DataTextField = "AccName";
                        DDLTransection_Ledger.DataValueField = "CoaDetailID";
                        DDLTransection_Ledger.DataBind();

                    }
                    else if (VoucherTypeCode == "TV")// 5 TV
                    {
                        string lbLCBS = "";
                        lbLCBS = lblCashBankSource.Text;

                        SqlDataAdapter da1 = new SqlDataAdapter("BBLCashAccounts", conn);
                        da1.SelectCommand.CommandType = CommandType.StoredProcedure;
                        DataTable Vchr_ChartofAccFund = new DataTable();
                        da1.Fill(Vchr_ChartofAccFund);

                        bool exists = Vchr_ChartofAccFund.Select().ToList().Exists(row => row["CoaDetailID"].ToString().ToUpper() == lbLCBS);

                        if (exists)
                        {
                            DropDownList DDLTransection_Ledger = (DropDownList)e.Row.FindControl("DDLTransection_Ledger");
                            SqlDataAdapter daa1 = new SqlDataAdapter("Usp_Vchr_ChartofAccFund", conn);
                            daa1.SelectCommand.CommandType = CommandType.StoredProcedure;
                            daa1.SelectCommand.Parameters.Add("@AccFundCode", SqlDbType.Int).Value = DDLCompany_Name.SelectedValue;//3
                            daa1.SelectCommand.Parameters.Add("@Vchr_Type", SqlDbType.Char).Value = "B";
                            DataTable Vchr_ChartofAccFund1 = new DataTable();
                            daa1.Fill(Vchr_ChartofAccFund1);
                            DDLTransection_Ledger.DataSource = Vchr_ChartofAccFund1;
                            DDLTransection_Ledger.DataTextField = "AccName";
                            DDLTransection_Ledger.DataValueField = "CoaDetailID";
                            DDLTransection_Ledger.DataBind();
                        }
                        else
                        {
                            DropDownList DDLTransection_Ledger = (DropDownList)e.Row.FindControl("DDLTransection_Ledger");
                            SqlDataAdapter daa1 = new SqlDataAdapter("Usp_Vchr_ChartofAccFund", conn);
                            daa1.SelectCommand.CommandType = CommandType.StoredProcedure;
                            daa1.SelectCommand.Parameters.Add("@AccFundCode", SqlDbType.Int).Value = DDLCompany_Name.SelectedValue;//3
                            daa1.SelectCommand.Parameters.Add("@Vchr_Type", SqlDbType.Char).Value = "C";
                            DataTable Vchr_ChartofAccFund1 = new DataTable();
                            daa1.Fill(Vchr_ChartofAccFund1);
                            DDLTransection_Ledger.DataSource = Vchr_ChartofAccFund1;
                            DDLTransection_Ledger.DataTextField = "AccName";
                            DDLTransection_Ledger.DataValueField = "CoaDetailID";
                            DDLTransection_Ledger.DataBind();
                        }
                    }
                    else if (VoucherTypeCode == "JV")//6 jv
                    {
                        DropDownList DDLTransection_Ledger = (DropDownList)e.Row.FindControl("DDLTransection_Ledger");
                        SqlDataAdapter da1 = new SqlDataAdapter("Usp_Vchr_ChartofAccFund", conn);
                        da1.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da1.SelectCommand.Parameters.Add("@AccFundCode", SqlDbType.Int).Value = DDLCompany_Name.SelectedValue;//3
                        da1.SelectCommand.Parameters.Add("@Vchr_Type", SqlDbType.Char).Value = "T";
                        DataTable Vchr_ChartofAccFund = new DataTable();
                        da1.Fill(Vchr_ChartofAccFund);
                        DDLTransection_Ledger.DataSource = Vchr_ChartofAccFund;
                        DDLTransection_Ledger.DataTextField = "AccName";
                        DDLTransection_Ledger.DataValueField = "CoaDetailID";
                        DDLTransection_Ledger.DataBind();
                    }
                    else if (VoucherTypeCode == "TS")//7 TS
                    {

                    }
                    else
                    {

                    }
                    DropDownList DDLT_Ledger = (DropDownList)e.Row.Cells[1].FindControl("DDLTransection_Ledger");

                    DropDownList DDLS_Type = (DropDownList)e.Row.Cells[2].FindControl("DDLSub_Type");
                    DropDownList DDLS_Ledger = (DropDownList)e.Row.Cells[3].FindControl("DDLSub_Ledger");

                    DropDownList DDLS_Type1 = (DropDownList)e.Row.Cells[4].FindControl("DDLSub_Type1");
                    DropDownList DDLS_Ledger1 = (DropDownList)e.Row.Cells[5].FindControl("DDLSub_Ledger1");

                    DropDownList DDLS_Type2 = (DropDownList)e.Row.Cells[6].FindControl("DDLSub_Type2");
                    DropDownList DDLS_Ledger2 = (DropDownList)e.Row.Cells[7].FindControl("DDLSub_Ledger2");


                    TextBox txt_Amount = (TextBox)e.Row.Cells[8].FindControl("txt_Amount");
                    DropDownList DDLCurr = (DropDownList)e.Row.Cells[9].FindControl("DDLCurrency");
                    TextBox txt_Exc_Rate = (TextBox)e.Row.Cells[10].FindControl("txt_Exchange_Rate");
                    TextBox txt_Transection_Memo = (TextBox)e.Row.Cells[11].FindControl("txt_Transection_Memo");



                    if (dtCurrentTable.Rows[e.Row.RowIndex]["Transection_Ledger"] != DBNull.Value)
                        DDLT_Ledger.SelectedValue = dtCurrentTable.Rows[e.Row.RowIndex]["Transection_Ledger"].ToString();

                    string SQLSubTypeID = "SELECT CoaDetailID, AccSubTypeID,AccSubTypeID1,AccSubTypeID2 FROM CoaDetail where  CoaDetailID=" + DDLT_Ledger.SelectedValue + " AND AccFundID =" + accfundID;


                    SqlDataAdapter daa = new SqlDataAdapter(SQLSubTypeID, conn);
                    daa.SelectCommand.CommandType = CommandType.Text;
                    DataTable dtt = new DataTable();
                    daa.Fill(dtt);

                    sSubTypeID = dtt.Rows[0]["AccSubTypeID"].ToString();
                    DDLS_Ledger.Enabled = true;
                    DDLS_Ledger1.Enabled = true;
                    DDLS_Ledger2.Enabled = true;

                    if (sSubTypeID == "1" || sSubTypeID == null)
                    {
                        DDLS_Ledger.Enabled = false;
                        DDLS_Ledger1.Enabled = false;
                        DDLS_Ledger2.Enabled = false;

                    }
                    string sSubTypeID1 = dtt.Rows[0]["AccSubTypeID1"].ToString();
                    if (sSubTypeID1 == "")
                    {
                        sSubTypeID1 = "1";
                    }
                    string sSubTypeID2 = dtt.Rows[0]["AccSubTypeID2"].ToString();
                    if (sSubTypeID2 == "")
                    {
                        sSubTypeID2 = "1";
                    }
                    DDLS_Type.DataSource = dtt;
                    DDLS_Type.DataTextField = "CoaDetailID";
                    DDLS_Type.DataValueField = "AccSubTypeID";
                    DDLS_Type.DataBind();
                    ///////////
                    DDLS_Type1.DataSource = dtt;
                    DDLS_Type1.DataTextField = "CoaDetailID";
                    DDLS_Type1.DataValueField = "AccSubTypeID2";
                    DDLS_Type1.DataBind();
                    ///////////////
                    DDLS_Type2.DataSource = dtt;
                    DDLS_Type2.DataTextField = "CoaDetailID";
                    DDLS_Type2.DataValueField = "AccSubTypeID2";
                    DDLS_Type2.DataBind();
                    // string Sub_Type = DDLS_Type.SelectedValue;
                    if (dtCurrentTable.Rows[e.Row.RowIndex]["Sub_Type"] != DBNull.Value)
                    {
                        DDLS_Type.SelectedValue = dtCurrentTable.Rows[e.Row.RowIndex]["Sub_Type"].ToString();
                    }
                    //string Sub_Type1 = DDLS_Type.SelectedValue;
                    if (dtCurrentTable.Rows[e.Row.RowIndex]["Sub_Type1"] != DBNull.Value)
                    {
                        DDLS_Type1.SelectedValue = dtCurrentTable.Rows[e.Row.RowIndex]["Sub_Type1"].ToString();
                    }
                    // string Sub_Type2 = DDLS_Type.SelectedValue;
                    if (dtCurrentTable.Rows[e.Row.RowIndex]["Sub_Type2"] != DBNull.Value)
                    {
                        DDLS_Type2.SelectedValue = dtCurrentTable.Rows[e.Row.RowIndex]["Sub_Type2"].ToString();
                    }
                    if (sSubTypeID != "")
                    {
                        string sql = "SELECT  [AccSubCode],[AccSubTypeID],[AccSubName],[AccFundID] FROM dbo.AccSubNames where AccSubTypeID=" + sSubTypeID + " AND AccFundID =" + DDLCompany_Name.SelectedValue + " ORDER BY [AccSubName] ASC";
                        SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                        da.SelectCommand.CommandType = CommandType.Text;
                        DataTable dtsubledger = new DataTable();
                        da.Fill(dtsubledger);

                        DDLS_Ledger.DataSource = dtsubledger;
                        DDLS_Ledger.DataTextField = "AccSubName";
                        DDLS_Ledger.DataValueField = "AccSubCode";
                        DDLS_Ledger.DataBind();

                    }

                    /////////////////////////


                    if (dtCurrentTable.Rows[e.Row.RowIndex]["Sub_Ledger"] != DBNull.Value)
                    {
                        DDLS_Ledger.SelectedValue = dtCurrentTable.Rows[e.Row.RowIndex]["Sub_Ledger"].ToString();
                    }
                    /////////////////////
                    if (sSubTypeID1 != "")
                    {
                        string sql1 = "SELECT  [AccSubCode],[AccSubTypeID],[AccSubName],[AccFundID] FROM dbo.AccSubNames where AccSubTypeID=" + sSubTypeID1 + "AND AccFundID =" + accfundID + "ORDER BY [AccSubName] ASC";
                        SqlDataAdapter data1 = new SqlDataAdapter(sql1, conn);
                        data1.SelectCommand.CommandType = CommandType.Text;
                        DataTable dtsubledger1 = new DataTable();
                        data1.Fill(dtsubledger1);

                        DDLS_Ledger1.DataSource = dtsubledger1;
                        DDLS_Ledger1.DataTextField = "AccSubName";
                        DDLS_Ledger1.DataValueField = "AccSubCode";
                        DDLS_Ledger1.DataBind();
                    }

                    ////
                    if (dtCurrentTable.Rows[e.Row.RowIndex]["Sub_Ledger1"] != DBNull.Value)
                    {
                        DDLS_Ledger1.SelectedValue = dtCurrentTable.Rows[e.Row.RowIndex]["Sub_Ledger1"].ToString();
                    }
                    ///////////////////////////////

                    if (sSubTypeID2 != "")
                    {

                        string sql2 = "SELECT  [AccSubCode],[AccSubTypeID],[AccSubName],[AccFundID] FROM dbo.AccSubNames where AccSubTypeID= " + sSubTypeID2 + " AND AccFundID =" + accfundID + "ORDER BY [AccSubName] ASC";
                        SqlDataAdapter data2 = new SqlDataAdapter(sql2, conn);
                        data2.SelectCommand.CommandType = CommandType.Text;
                        DataTable dtsubledger2 = new DataTable();
                        data2.Fill(dtsubledger2);

                        DDLS_Ledger2.DataSource = dtsubledger2;
                        DDLS_Ledger2.DataTextField = "AccSubName";
                        DDLS_Ledger2.DataValueField = "AccSubCode";
                        DDLS_Ledger2.DataBind();
                    }
                    ///////////////////////////////////
                    if (dtCurrentTable.Rows[e.Row.RowIndex]["Sub_Ledger2"] != DBNull.Value)
                    {
                        DDLS_Ledger2.SelectedValue = dtCurrentTable.Rows[e.Row.RowIndex]["Sub_Ledger2"].ToString();
                    }

                    if (dtCurrentTable.Rows[e.Row.RowIndex]["Amount"] != DBNull.Value)
                    {
                        txt_Amount.Text = dtCurrentTable.Rows[e.Row.RowIndex]["Amount"].ToString();
                    }
                    if (dtCurrentTable.Rows[e.Row.RowIndex]["Currency"] != DBNull.Value)
                    {
                        DDLCurr.SelectedValue = dtCurrentTable.Rows[e.Row.RowIndex]["Currency"].ToString();
                    }
                    if (dtCurrentTable.Rows[e.Row.RowIndex]["Exchange_Rate"] != DBNull.Value)
                    {
                        txt_Exc_Rate.Text = dtCurrentTable.Rows[e.Row.RowIndex]["Exchange_Rate"].ToString();
                    }
                    if (dtCurrentTable.Rows[e.Row.RowIndex]["Transection_Memo"] != DBNull.Value)
                    {
                        txt_Transection_Memo.Text = dtCurrentTable.Rows[e.Row.RowIndex]["Transection_Memo"].ToString();
                    }


                    if (dtCurrentTable.Rows[e.Row.RowIndex]["Old_Data"] == "1")
                    {
                        DDLT_Ledger.Enabled = false;
                        txt_Amount.Enabled = false;
                        e.Row.Cells[11].Enabled = false;
                    }
                    e.Row.Cells[9].Visible = false;
                    e.Row.Cells[10].Visible = false;
                }
                else
                {

                }

            }

            // e.Row.Cells[9].Visible = false;
            // e.Row.Cells[10].Visible = false;


        }
        catch (Exception ex)
        {
            PopUp("Grid View Data Bind Problem. Please contact to our development team" + ex.InnerException);
        }
    }

    protected void DDLVoucherType_SelectedIndexChanged(object sender, EventArgs e)
    {


        Gridview1.Visible = false;
        VoucherTypeRead();
        CashBankSourceLoad();

    }

    protected void DDLCashBankSource_SelectedIndexChanged(object sender, EventArgs e)
    {

        string a = "";
        lblCashBankSource.Text = "";
        a = Convert.ToString(DDLCashBankSource.SelectedValue);
        lblCashBankSource.Text = a;
        //////////Gridview DataBind/////////////////////
        Gridview1.DataSource = null;
        dtCurrentTable = null;
        SetInitialRow();
        Gridview1.Visible = true;
        Total_Amount.Visible = true;
        Sum_amount.Visible = true;
        DDL_CheckNo.DataSource = null;
        CheckNo();

    }
    private void CheckNo()
    {

        conn.Open();
        SqlDataAdapter da = new SqlDataAdapter("GetChequeBookLeaf", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.Add("@AccFundID", SqlDbType.Int).Value = accfundID;
        da.SelectCommand.Parameters.Add("@CoaDetailID", SqlDbType.Int).Value = DDLCashBankSource.SelectedValue;
        DataTable dt = new DataTable();
        da.Fill(dt);
        DDL_CheckNo.DataSource = dt;
        DDL_CheckNo.DataTextField = "LeafNumber";
        DDL_CheckNo.DataValueField = "LeafID";
        conn.Close();
        DDL_CheckNo.DataBind();
        DDL_CheckNo.Items.Insert(0, new ListItem("Select", "0"));

    }
    protected void DDLTransection_Ledger_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            // addflag = "";
            string tranLedger = string.Empty;
            string sSubTypeID = string.Empty;
            string sSubTypeID1 = string.Empty;
            string sSubTypeID2 = string.Empty;

            DropDownList DDLTransection_Ledger = (DropDownList)sender;
            DropDownList DDLSub_Type = (DropDownList)sender;
            DropDownList DDLSub_Type1 = (DropDownList)sender;
            DropDownList DDLSub_Type2 = (DropDownList)sender;

            tranLedger = DDLTransection_Ledger.SelectedValue;

            GridViewRow rowT_Ledger = (GridViewRow)DDLTransection_Ledger.NamingContainer;
            GridViewRow rowSType = (GridViewRow)DDLSub_Type.NamingContainer;
            GridViewRow rowSType1 = (GridViewRow)DDLSub_Type1.NamingContainer;
            GridViewRow rowSType2 = (GridViewRow)DDLSub_Type2.NamingContainer;

            DropDownList DDL_SType = (DropDownList)rowSType.FindControl("DDLSub_Type");
            DropDownList DDL_SType1 = (DropDownList)rowSType1.FindControl("DDLSub_Type1");
            DropDownList DDL_SType2 = (DropDownList)rowSType2.FindControl("DDLSub_Type2");

            string SQLSubTypeID = "SELECT CoaDetailID, AccSubTypeID,AccSubTypeID1,AccSubTypeID2 FROM CoaDetail where  CoaDetailID=" + tranLedger + " AND AccFundID =" + accfundID;

            SqlDataAdapter daa = new SqlDataAdapter(SQLSubTypeID, conn);
            daa.SelectCommand.CommandType = CommandType.Text;
            DataTable dtt = new DataTable();
            daa.Fill(dtt);

            DDL_SType.Enabled = true;
            DDL_SType1.Enabled = true;
            DDL_SType2.Enabled = true;

            sSubTypeID = dtt.Rows[0]["AccSubTypeID"].ToString();

            sSubTypeID1 = dtt.Rows[0]["AccSubTypeID1"].ToString();
            if (sSubTypeID1 == "")
            {
                sSubTypeID1 = "1";
            }
            sSubTypeID2 = dtt.Rows[0]["AccSubTypeID2"].ToString();
            if (sSubTypeID2 == "")
            {
                sSubTypeID2 = "1";
            }
            DDL_SType.DataSource = dtt;
            DDL_SType.DataTextField = "CoaDetailID";
            DDL_SType.DataValueField = "AccSubTypeID";
            DDL_SType.DataBind();
            ///////////
            DDL_SType1.DataSource = dtt;
            DDL_SType1.DataTextField = "CoaDetailID";
            DDL_SType1.DataValueField = "AccSubTypeID1";
            DDL_SType1.DataBind();
            ///////////////
            DDL_SType2.DataSource = dtt;
            DDL_SType2.DataTextField = "CoaDetailID";
            DDL_SType2.DataValueField = "AccSubTypeID2";
            DDL_SType2.DataBind();

            //////////////////////////////////////////
            DropDownList DDLSub_Ledger = (DropDownList)rowT_Ledger.FindControl("DDLSub_Ledger");
            string sql = "SELECT  [AccSubCode],[AccSubTypeID],[AccSubName],[AccFundID] FROM dbo.AccSubNames where AccSubTypeID=" + sSubTypeID + " AND AccFundID =" + accfundID.ToString() + "ORDER BY [AccSubName] ASC";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dtsubledger = new DataTable();
            da.Fill(dtsubledger);

            DDLSub_Ledger.DataSource = dtsubledger;
            DDLSub_Ledger.DataTextField = "AccSubName";
            DDLSub_Ledger.DataValueField = "AccSubCode";
            DDLSub_Ledger.DataBind();
            // sSubTypeID = DDL_SType.SelectedValue;
            ////////////////////


            ///////////////////
            DropDownList DDLSub_Ledger1 = (DropDownList)rowT_Ledger.FindControl("DDLSub_Ledger1");
            string sql1 = "SELECT  [AccSubCode],[AccSubTypeID],[AccSubName],[AccFundID] FROM dbo.AccSubNames where AccSubTypeID=" + sSubTypeID1 + " AND AccFundID =" + accfundID.ToString() + "ORDER BY [AccSubName] ASC";
            SqlDataAdapter data1 = new SqlDataAdapter(sql1, conn);
            data1.SelectCommand.CommandType = CommandType.Text;
            DataTable dtsubledger1 = new DataTable();
            data1.Fill(dtsubledger1);

            DDLSub_Ledger1.DataSource = dtsubledger1;
            DDLSub_Ledger1.DataTextField = "AccSubName";
            DDLSub_Ledger1.DataValueField = "AccSubCode";
            DDLSub_Ledger1.DataBind();
            ///////////////////////////////
            DropDownList DDLSub_Ledger2 = (DropDownList)rowT_Ledger.FindControl("DDLSub_Ledger2");
            string sql2 = "SELECT  [AccSubCode],[AccSubTypeID],[AccSubName],[AccFundID] FROM dbo.AccSubNames where AccSubTypeID= " + sSubTypeID2 + " AND AccFundID =" + accfundID.ToString() + "ORDER BY [AccSubName] ASC";
            SqlDataAdapter data2 = new SqlDataAdapter(sql2, conn);
            data2.SelectCommand.CommandType = CommandType.Text;
            DataTable dtsubledger2 = new DataTable();
            data2.Fill(dtsubledger2);

            DDLSub_Ledger2.DataSource = dtsubledger2;
            DDLSub_Ledger2.DataTextField = "AccSubName";
            DDLSub_Ledger2.DataValueField = "AccSubCode";
            DDLSub_Ledger2.DataBind();
            ///////////////////////////////////
            if (sSubTypeID == "1" || sSubTypeID == null)
            {
                DDL_SType.Enabled = false;
                DDL_SType1.Enabled = false;
                DDL_SType2.Enabled = false;

            }


            for (int irow = 1; Gridview1.Rows.Count >= irow; irow++)
            {
                DropDownList RDDLT_Ledger = (DropDownList)Gridview1.Rows[irow - 1].Cells[1].FindControl("DDLTransection_Ledger");
                DropDownList RDDLSub_Type = (DropDownList)Gridview1.Rows[irow - 1].Cells[2].FindControl("DDLSub_Type");
                DropDownList RDDLSub_Ledger = (DropDownList)Gridview1.Rows[irow - 1].Cells[3].FindControl("DDLSub_Ledger");

                DropDownList RDDLSub_Type1 = (DropDownList)Gridview1.Rows[irow - 1].Cells[4].FindControl("DDLSub_Type1");
                DropDownList RDDLSub_Ledger1 = (DropDownList)Gridview1.Rows[irow - 1].Cells[5].FindControl("DDLSub_Ledger1");

                DropDownList RDDLSub_Type2 = (DropDownList)Gridview1.Rows[irow - 1].Cells[6].FindControl("DDLSub_Type2");
                DropDownList RDDLSub_Ledger2 = (DropDownList)Gridview1.Rows[irow - 1].Cells[7].FindControl("DDLSub_Ledger2");
                TextBox txt_Amount = (TextBox)Gridview1.Rows[irow - 1].Cells[8].FindControl("txt_Amount");
                DropDownList DDLCurrency = (DropDownList)Gridview1.Rows[irow - 1].Cells[9].FindControl("DDLCurrency");
                TextBox txt_Exchange_Rate = (TextBox)Gridview1.Rows[irow - 1].Cells[10].FindControl("txt_Exchange_Rate");
                TextBox txt_Transection_Memo = (TextBox)Gridview1.Rows[irow - 1].Cells[11].FindControl("txt_Transection_Memo");

                dtCurrentTable.Rows[irow - 1]["Transection_Ledger"] = RDDLT_Ledger.SelectedValue;
                dtCurrentTable.Rows[irow - 1]["Sub_Type"] = RDDLSub_Type.SelectedValue;
                dtCurrentTable.Rows[irow - 1]["Sub_Ledger"] = RDDLSub_Ledger.SelectedValue;


                dtCurrentTable.Rows[irow - 1]["Sub_Type1"] = RDDLSub_Type1.SelectedValue;
                dtCurrentTable.Rows[irow - 1]["Sub_Ledger1"] = RDDLSub_Ledger1.SelectedValue;
                dtCurrentTable.Rows[irow - 1]["Sub_Type2"] = RDDLSub_Type2.SelectedValue;
                dtCurrentTable.Rows[irow - 1]["Sub_Ledger2"] = RDDLSub_Ledger2.SelectedValue;

                dtCurrentTable.Rows[irow - 1]["Amount"] = txt_Amount.Text;
                dtCurrentTable.Rows[irow - 1]["Currency"] = DDLCurrency.SelectedValue;
                dtCurrentTable.Rows[irow - 1]["Exchange_Rate"] = txt_Exchange_Rate.Text;
                dtCurrentTable.Rows[irow - 1]["Transection_Memo"] = txt_Transection_Memo.Text;
                dtCurrentTable.Rows[irow - 1]["RowNumber"] = irow;
                //  drCurrentRow["RowNumber"] = irow;
            }

            Gridview1.DataSource = dtCurrentTable;
            Gridview1.DataBind();

        }
        catch (Exception ex)
        {
            PopUp("Transection Ledger Data Load Problem. Please Try Again. " + ex.InnerException);
        }
    }
    protected void txt_Amount_TextChanged(object sender, EventArgs e)
    {
        Decimal Total = 0m;
        Decimal Sum_Total = 0m;

        for (int irow = 1; Gridview1.Rows.Count >= irow; irow++)
        {
            TextBox txt_Amount = (TextBox)Gridview1.Rows[irow - 1].Cells[8].FindControl("txt_Amount");
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

        }
        Sum_amount.Text = Convert.ToDecimal(Sum_Total).ToString("#,##0.00");
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
        // dtCurrentTable = null;
        dtCurrentTable = null;
        DDLCompany_Name.SelectedIndex = 0;
        DDLVoucherType.SelectedIndex = 0;
        DDLCashBankSource.DataSource = null;
        //DDLFund_Source.SelectedIndex = 0;
        DDLCashBankSource.SelectedIndex = 0;
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
        Sum_amount.Visible = false;
        Total_Sum = 0;
        LB_Voucher_Print.Visible = false;
        FromNSearch.Visible = true;
        ReportForm.Visible = false;
        ReportViewer1.LocalReport.DataSources.Clear();
        PdfLocation = "";
        fileName = "";
        Find_VoucherButton.Visible = true;
        EditVoucher_Date.Visible = false;
        lblDate.Visible = true;
        txt_Check_Date.Text = "";
        DDL_CheckNo.DataSource = null;
        DDL_CheckNo.SelectedIndex = 0;

        txt_Branch_Name.Text = "";
        txt_CheckNo.Visible = false;
        DDL_CheckNo.Visible = true;
    }
    protected void DDLCompany_Name_SelectedIndexChanged(object sender, EventArgs e)
    {
        //  FundSource();
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

        if (DDL_CheckNo.SelectedItem.Value == "0")
        {
            lblMsg.Text = "Please Select Cheque Number ";
            PopUp("Please Select Cheque Number ");
            return;
        }

        if (string.IsNullOrEmpty(Sum_amount.Text))
        {
            lblMsg.Text = "Please Check Transection Amount";
            PopUp("Please Check Transection Amount");
            return;
        }


        int AccVoucherTranID = 0;
        if (dtCurrentTable != null)
        {

            if (EditAccVoucherTranID != 0)
            {
                AccVoucherTranID = EditAccVoucherTranID;
            }
            // else { }

            string[] headerinfo = new string[12];
            headerinfo[0] = DDLCompany_Name.SelectedValue;//Companny Name
            headerinfo[1] = DDLVoucherType.SelectedValue;//Voucher Type
            headerinfo[2] = DDLFund_Source.SelectedValue;//Fund Source
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
                DateTime VchrDate = DateTime.Now;
                CultureInfo cultureinfo = new CultureInfo("en-GB");

                string Date = VchrDate.Month.ToString() + "/" + VchrDate.Day.ToString() + "/" + VchrDate.Year.ToString();
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

            string sql2 = "SELECT * FROM VoucherTypes WHERE VchrTypeID=" + headerinfo[1];
            SqlDataAdapter data2 = new SqlDataAdapter(sql2, conn);
            data2.SelectCommand.CommandType = CommandType.Text;
            DataTable VoucherType = new DataTable();
            data2.Fill(VoucherType);
            headerinfo[8] = Convert.ToString(VoucherType.Rows[0]["vchrType"]); //@HeadAcc int,--Transec Ledger No

            if (headerinfo[8] == "CP" || headerinfo[8] == "CR")
            {
                headerinfo[9] = "";
                headerinfo[11] = "";
            }
            else if (headerinfo[8] == "BP" || headerinfo[8] == "BR")
            {
                headerinfo[9] = DDL_CheckNo.SelectedItem.Text;//txt_CheckNo.Text;
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
            conn.Open();
            SqlTransaction Transection = conn.BeginTransaction();
            try
            {
                #region Transection_Ledger Loop wise save


                for (int irows = 1; Gridview1.Rows.Count >= irows; irows++)
                {
                    #region [Read Grid]
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
                    //dtCurrentTable.Rows[irows - 1]["Sub_Type"] = DDLSub_Type.SelectedValue;
                    dtCurrentTable.Rows[irows - 1]["Sub_Ledger"] = DDLSub_Ledger.SelectedValue;
                    if (DDLSub_Type.SelectedValue == "")
                    {
                        dtCurrentTable.Rows[irows - 1]["Sub_Type1"] = "1";
                    }
                    else
                    {
                        dtCurrentTable.Rows[irows - 1]["Sub_Type1"] = DDLSub_Type1.SelectedValue;
                    }
                    if (DDLSub_Type.SelectedValue == "")
                    {
                        dtCurrentTable.Rows[irows - 1]["Sub_Type2"] = "1";
                    }
                    else
                    {
                        dtCurrentTable.Rows[irows - 1]["Sub_Type2"] = DDLSub_Type2.SelectedValue;
                    }

                    dtCurrentTable.Rows[irows - 1]["Sub_Ledger1"] = DDLSub_Ledger1.SelectedValue;
                    dtCurrentTable.Rows[irows - 1]["Sub_Ledger2"] = DDLSub_Ledger2.SelectedValue;
                    dtCurrentTable.Rows[irows - 1]["Amount"] = txt_Amount.Text;
                    dtCurrentTable.Rows[irows - 1]["Currency"] = DDLCurrency.SelectedValue;
                    dtCurrentTable.Rows[irows - 1]["Exchange_Rate"] = txt_Exchange_Rate.Text;
                    dtCurrentTable.Rows[irows - 1]["Transection_Memo"] = txt_Transection_Memo.Text;
                    dtCurrentTable.Rows[irows - 1]["RowNumber"] = irows;
                    /////////////////////////////////////////////////

                    #region Saveing peramiter check



                    #endregion




                    if (AccVoucherTranID == 0)
                    {
                        #region [Transaction Start]
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
                            cmd.Parameters.Add("@AccSubCode", SqlDbType.Int).Value = 0;//@AccSubCode int,
                        }
                        else
                        {
                            cmd.Parameters.Add("@AccSubCode", SqlDbType.Int).Value = Convert.ToInt64(dtCurrentTable.Rows[irows - 1]["Sub_Ledger"]);//@AccSubCode int,
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
                            cmd.Parameters.Add("@AccSubCode1", SqlDbType.Int).Value = 0;
                        }
                        else
                        {
                            cmd.Parameters.Add("@AccSubCode1", SqlDbType.Int).Value = Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Ledger1"]);
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
                            cmd.Parameters.Add("@AccSubCode2", SqlDbType.Int).Value = 0;
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
                        else if (headerinfo[8] == "CR" || headerinfo[8] == "BR")
                        {
                            cmd.Parameters.Add("@DebitAmt", SqlDbType.Money).Value = 0;//@DebitAmt Money,--
                            cmd.Parameters.Add("@CreditAmt", SqlDbType.Money).Value = dtCurrentTable.Rows[irows - 1]["Amount"];  //@DebitAmt Money,--
                            a = Convert.ToDouble(dtCurrentTable.Rows[irows - 1]["Amount"]);
                            Result = (a + Result);
                            cmd.Parameters.Add("@IsRevtran", SqlDbType.Int).Value = 0;      //@IsRevtran int,--0
                        }
                        else
                        {
                            cmd.Parameters.Add("@DebitAmt", SqlDbType.Money).Value = 0;//@DebitAmt Money,--
                            cmd.Parameters.Add("@CreditAmt", SqlDbType.Money).Value = dtCurrentTable.Rows[irows - 1]["Amount"];  //@DebitAmt Money,--

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
                        //int abc = Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Type"]);

                        if (AccSubTypeID == 1 || AccSubTypeID == 0)
                        {
                            cmd.Parameters.Add("@AccSubCode", SqlDbType.Int).Value = 0;//@AccSubCode int,
                        }
                        else
                        {
                            cmd.Parameters.Add("@AccSubCode", SqlDbType.Int).Value = Convert.ToInt64(dtCurrentTable.Rows[irows - 1]["Sub_Ledger"]);//@AccSubCode int,
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
                            cmd.Parameters.Add("@AccSubCode1", SqlDbType.Int).Value = 0;

                        }
                        else
                        {
                            cmd.Parameters.Add("@AccSubCode1", SqlDbType.Int).Value = Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Ledger1"]);
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
                            cmd.Parameters.Add("@AccSubCode2", SqlDbType.Int).Value = 0;
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
                        else if (headerinfo[8] == "CR" || headerinfo[8] == "BR")
                        {
                            cmd.Parameters.Add("@DebitAmt", SqlDbType.Money).Value = 0;//@DebitAmt Money,--
                            cmd.Parameters.Add("@CreditAmt", SqlDbType.Money).Value = dtCurrentTable.Rows[irows - 1]["Amount"];  //@DebitAmt Money,--
                            a = Convert.ToDouble(dtCurrentTable.Rows[irows - 1]["Amount"]);
                            Result = (a + Result);
                            cmd.Parameters.Add("@IsRevtran", SqlDbType.Int).Value = 0;      //@IsRevtran int,--0
                        }
                        else
                        {
                            cmd.Parameters.Add("@DebitAmt", SqlDbType.Money).Value = 0;//@DebitAmt Money,--
                            cmd.Parameters.Add("@CreditAmt", SqlDbType.Money).Value = dtCurrentTable.Rows[irows - 1]["Amount"];  //@DebitAmt Money,--

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
                            cmd.Parameters.Add("@AccSubCode", SqlDbType.Int).Value = 0;//@AccSubCode int,
                        }
                        else if (headerinfo[8] == "JV")
                        {
                            cmd.Parameters.Add("@AccSubCode", SqlDbType.Int).Value = Convert.ToInt64(dtCurrentTable.Rows[LastRow - 1]["Sub_Ledger"]);//@AccSubCode int,
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
                            cmd.Parameters.Add("@AccSubCode1", SqlDbType.Int).Value = 0;//@AccSubCode int,
                        }
                        else if (headerinfo[8] == "JV")
                        {
                            cmd.Parameters.Add("@AccSubCode1", SqlDbType.Int).Value = Convert.ToInt64(dtCurrentTable.Rows[LastRow - 1]["Sub_Ledger1"]);//@AccSubCode int,
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
                            cmd.Parameters.Add("@AccSubCode2", SqlDbType.Int).Value = Convert.ToInt64(dtCurrentTable.Rows[LastRow - 1]["Sub_Ledger2"]);//@AccSubCode int,
                        }
                        else
                        {
                            cmd.Parameters.Add("@AccSubCode2", SqlDbType.Int).Value = DBNull.Value;//Convert.ToInt64(dtCurrentTable.Rows[LastRow - 1]["Sub_Ledger"]);//@AccSubCode int,
                        }


                        /////////////////



                        //  cmd.Parameters.Add("@AccSubTypeID1", SqlDbType.Int).Value = 0;//Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Type1"]);//@AccSubTypeID1 int,-- Sub type1 mo
                        //  cmd.Parameters.Add("@AccSubCode1", SqlDbType.Int).Value = 0;//Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Ledger1"]); //@AccSubCode1 int,
                        //cmd.Parameters.Add("@AccSubTypeID2", SqlDbType.Int).Value = 0;//Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Type2"]);  //@AccSubTypeID2 int,-- Sub type2 mo
                        // cmd.Parameters.Add("@AccSubCode2", SqlDbType.Int).Value = 0;// Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Ledger2"]);  //@AccSubCode2 int,

                        if (headerinfo[8] == "CP" || headerinfo[8] == "BP") //cash/ bank
                        {
                            cmd.Parameters.Add("@DebitAmt", SqlDbType.Money).Value = 0;//@DebitAmt Money,--
                            cmd.Parameters.Add("@CreditAmt", SqlDbType.Money).Value = Result;//dtCurrentTable.Rows[LastRow]["Amount"];//CreditAmt
                            cmd.Parameters.Add("@IsRevtran", SqlDbType.Int).Value = 1;      //@IsRevtran int,--0
                        }
                        else if (headerinfo[8] == "CR" || headerinfo[8] == "BR")
                        {
                            cmd.Parameters.Add("@DebitAmt", SqlDbType.Money).Value = Result;//dtCurrentTable.Rows[LastRow]["Amount"];//@DebitAmt Money,--
                            cmd.Parameters.Add("@CreditAmt", SqlDbType.Money).Value = 0;  //@CreditAmt Money,- -
                            cmd.Parameters.Add("@IsRevtran", SqlDbType.Int).Value = 1;
                        }
                        else // Need To change
                        {
                            cmd.Parameters.Add("@DebitAmt", SqlDbType.Money).Value = Result;//dtCurrentTable.Rows[LastRow]["Amount"];//@DebitAmt Money,--
                            cmd.Parameters.Add("@CreditAmt", SqlDbType.Money).Value = 0;  //@CreditAmt Money,- -
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
                conn.Close();
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

            btn_save.Visible = false;
            IsAddEditMode = true;


            lbl_SMsgg.Text = " Save Successfully ";
            lbl_SMsgg.Visible = true;
            EditVoucher();

                #endregion
        }
        else
        {
            // lblMsg.Text = "";
            //  lblMsg.Text = "Internal saving error, contact to development team ";
            PopUp("Internal saving error, Please contact to our development team ");
            return;
            //clear();
        }
    }
    protected void Add_PaidTo(object sender, EventArgs e)
    {
        clear();
        Response.Redirect("~/Pages/CostCenters.aspx");
    }
    protected void Cancel_Voucher(object sender, EventArgs e)
    {
        clear();
        Response.Redirect("~/Pages/ChequeIssue.aspx");
    }
    protected void Find_Voucher(object sender, EventArgs e)
    {

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

    }
    private void VoucherTypes_find()
    {

        conn.Open();
        string SQL1 = "SELECT * FROM VoucherTypes WHERE VchrTypeID = 3 ORDER BY VchrTypeDesc ASC";// WHERE VchrTypeID= 1";
        SqlDataAdapter adpt1 = new SqlDataAdapter(SQL1, conn);
        DataTable dt1 = new DataTable();
        adpt1.Fill(dt1);
        DDLVoucherType_Find.DataSource = dt1;
        DDLVoucherType_Find.DataTextField = "VchrTypeDesc";
        DDLVoucherType_Find.DataValueField = "vchrTypeID";//
        DDLVoucherType_Find.DataBind();
        DDLVoucherType_Find.Items.Insert(0, new ListItem("Select", "0"));
        //DDLVoucherType_Find.Items.Insert(0, "Select");
        DDLVoucherType_Find.SelectedValue = "3";
        conn.Close();

    }
    private void Companny_find()
    {
        accfundID = 3;
        if (!string.IsNullOrEmpty(ad.CompanyID.ToString()))
        {
            accfundID = int.Parse(ad.CompanyID.ToString());
        }

        conn.Open();
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
        conn.Close();

    }
    protected void DDLCompany_Name_Find_SelectedIndexChanged(object sender, EventArgs e)
    {
        //FundSource_Find();
    }
    protected void Find_Voucher_Data(object sender, EventArgs e)
    {
        GV_VoucherFind_bind();
    }
    private void GV_VoucherFind_bind()
    {
        try
        {

            VoucherTypeCodeFind = VoucherTypeCode;
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

            SqlDataAdapter da = new SqlDataAdapter(SQL, conn);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);

            GV_VoucherFind.DataSource = dt;
            GV_VoucherFind.DataBind();
        }
        catch
        {
            lblMsg.Text = "";
            lblMsg.Text = "Please Select Voucher Type";
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
    }
    protected void GV_VoucherFind_SelectedIndexChanged(object sender, EventArgs e)
    {

        EditVoucher();
        Find_Voucher_Form.Visible = false;
        VC_Form.Visible = true;

        EditVoucher_Date.Visible = true;
        lblDate.Visible = false;
        Total_Sum = 0;
        Total_Amount.Visible = true;
        Sum_amount.Visible = true;
    }
    private void EditVoucher()
    {
        LB_Voucher_Print.Visible = true;
        CP_Header.Text = "";
        CP_Header.Text = "Edit";
        CP_Header.Visible = true;
        dtOldTable = null;
        Find_VoucherButton.Visible = false;
        txt_CheckNo.Visible = true;
        DDL_CheckNo.Visible = false;

        if (SaveNprintAccVoucherTranID != 0)
        {
            EditVoucherID = SaveNprintAccVoucherTranID;
        }
        else
        {
            EditVoucherID = 0;
            EditVoucherID = Convert.ToInt32(GV_VoucherFind.SelectedDataKey["AccVoucherTranID"].ToString());

        }

        conn.Open();
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
        conn.Close();

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

        string[] VoucherInfo = new string[11];
        VoucherInfo[0] = dtHeader.Rows[0]["AccFundCode"].ToString();// Company Name
        VoucherInfo[1] = dtHeader.Rows[0]["VchrTypesID"].ToString();
        VoucherInfo[2] = dtHeader.Rows[0]["PaidTo"].ToString();
        VoucherInfo[3] = dtHeader.Rows[0]["AccRemarks"].ToString();
        VoucherInfo[4] = dtHeader.Rows[0]["RefNo"].ToString();
        VoucherInfo[5] = dtTranDetails.Rows[0]["RevAcc"].ToString();
        VoucherInfo[6] = dtTranDetails.Rows[0]["Chequeno"].ToString();

        string ChkDate = "";
        if (dtTranDetails.Rows[0]["ChequeDT"] != DBNull.Value)
        {
            DateTime ChkVchrDate = Convert.ToDateTime(dtTranDetails.Rows[0]["ChequeDT"]);
            ChkDate = ChkVchrDate.Day.ToString() + "/" + ChkVchrDate.Month.ToString() + "/" + ChkVchrDate.Year.ToString();// Convert.ToDateTime(EditVoucher_Date.Text).ToString("MM/dd/yyyy");// EditVoucher_Date.Text;
        }

        VoucherInfo[7] = ChkDate;// Convert.ToDateTime(dtTranDetails.Rows[0]["ChequeDT"]).ToString("dd/mm/yyyy");//Convert.ToDateTime(dtHeader.Rows[0]["AccTranDate"]).ToString("MMMM/dd/yyyy")
        VoucherInfo[8] = dtTranDetails.Rows[0]["ChequeBankBranch"].ToString();

        VoucherInfo[9] = dtTranDetails.Rows[0]["Chequeno"].ToString();
        DDLCompany_Name.SelectedValue = VoucherInfo[0];
        DDLVoucherType.SelectedValue = VoucherInfo[1];

        txt_Paid_To.Text = VoucherInfo[2];
        txt_Voucher_Narration.Text = VoucherInfo[3];
        txtRefNo.Text = VoucherInfo[4];



        txt_Check_Date.Text = VoucherInfo[7];
        txt_Branch_Name.Text = VoucherInfo[8];
        DDLCashBankSource.DataSource = null;
        CashBankSourceLoad();
        DDLCashBankSource.SelectedValue = VoucherInfo[5];
        DDL_CheckNo.DataSource = null;
        txt_CheckNo.Text = VoucherInfo[9];

        Decimal Total = 0m;
        Decimal Sum_Total = 0m;

        for (int irow = 1; dtTranDetails.Rows.Count >= irow; irow++)
        {

            Total = Convert.ToDecimal(dtTranDetails.Rows[irow - 1]["Debit"].ToString());

            Sum_Total = Sum_Total + Total;


        }
        Sum_amount.Text = Convert.ToDecimal(Sum_Total).ToString("#,##0.00");

        dtCurrentTable = null;
        dtCurrentTable = dtOldTable;
        Gridview1.DataSource = null;
        Gridview1.DataSource = dtCurrentTable;

        Gridview1.DataBind();
        Gridview1.Visible = true;
        DDLCompany_Name.Enabled = false;
        DDLVoucherType.Enabled = false;
        DDLCashBankSource.Enabled = false;
        IsAddEditMode = false;

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
                ReportDataSource rds = new ReportDataSource("Dataset1", dt);
                ReportViewer1.LocalReport.DataSources.Add(rds);

                string ReportPath = new DirectoryInfo(HttpContext.Current.Server.MapPath("/Controls/")) + "ChequeBook.rdlc";
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

                fileName = "BankPaymentVoucher" + DateTime.Now.ToFileTime() + ".pdf";

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
                ReportDataSource rds = new ReportDataSource("Dataset1", dt);
                ReportViewer1.LocalReport.DataSources.Add(rds);

                string ReportPath = new DirectoryInfo(HttpContext.Current.Server.MapPath("/Controls/")) + "ChequeBook.rdlc";
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

                fileName = "Cheque" + DateTime.Now.ToFileTime() + ".pdf";

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
    private DataTable getdata(int prm, int prm1, int prm2, string prm3, string prm4)
    {
        DataTable dt = new DataTable();
        {
            SqlCommand cmd = new SqlCommand("GetChequePrintIPAC", conn);
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
        Response.Redirect("~/Pages/ChequeIssue.aspx");

    }

}
