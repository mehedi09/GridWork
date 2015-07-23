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



public partial class Controls_SalesJournal : System.Web.UI.UserControl
{

    private SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyCompany"].ConnectionString);
    static DataTable SDTDelete;
    static DataTable dtCurrentTable;
    static DataTable dtOldTable;
    static int irows = 1;
    static double Total_Sum;
    
    static int EditAccVoucherTranID;
    static int SaveNprintAccVoucherTranID;
    static int EditVoucherID;
    static DataTable dtreport;
    static Boolean IsAddEditMode = true;
    static string fileName;
    static string PdfLocation;

    static string VoucherTypeCode;
    static int pVchrTypeID;
    static int accfundID;
    static DataTable dtVchrTypes;
    MyCompany.Rules.SharedBusinessRules ad = new MyCompany.Rules.SharedBusinessRules();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GV_JournalVoucher.DataSource = null;
            dtCurrentTable = null;
            dtOldTable = null;
            lblDateTime();
            Companny();
            VoucherTypes();
            VC_Form.Visible = true;
            CP_Header.Visible = false;
            Find_Voucher_Form.Visible = false;

            FromNSearch.Visible = true;
            ReportForm.Visible = false;
            LB_Voucher_Print.Visible = false;
            SaveNprintAccVoucherTranID = 0;
            Return_Voucher_btn.Visible = false;
            Tran_Ledger();
            AdjFrm_Ledger();
            IsAddEditMode = true;
            LastVoucherNo();


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
        try
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.Parameters.Add("@AccFundCode", SqlDbType.Int).Value = accfundID;
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
        catch (Exception ex)
        {
            PopUp("Last Voucher Number Creating Problem. Please Try Again" + ex.Message.ToString());
        }
    }
    private void lblDateTime()
    {
        lblDate.Text = DateTime.Now.ToString("dd,MMMM,yyyy");
        EditVoucher_Date.Text = DateTime.Now.ToString("dd/MM/yyyy");
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
    private void Tran_Ledger()
    {

        conn.Open();
        SqlDataAdapter da1 = new SqlDataAdapter("Usp_Vchr_ChartofAccFund", conn);
        da1.SelectCommand.CommandType = CommandType.StoredProcedure;
        da1.SelectCommand.Parameters.Add("@AccFundCode", SqlDbType.Int).Value = accfundID;//3
        da1.SelectCommand.Parameters.Add("@Vchr_Type", SqlDbType.Char).Value = "T";
        DataTable dt1 = new DataTable();
        da1.Fill(dt1);
        DDLTranLedger.DataSource = dt1;
        DDLTranLedger.DataTextField = "AccName";
        DDLTranLedger.DataValueField = "CoaDetailID";
        DDLTranLedger.DataBind();
        DDLTranLedger.Items.Insert(0, "Select");
        conn.Close();

    }
    private void AdjFrm_Ledger()
    {


        conn.Open();
        SqlDataAdapter da = new SqlDataAdapter("Usp_Vchr_ChartofAccFund", conn);
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        da.SelectCommand.Parameters.Add("@AccFundCode", SqlDbType.Int).Value = accfundID;//3
        da.SelectCommand.Parameters.Add("@Vchr_Type", SqlDbType.Char).Value = "SJ";
        DataTable dt = new DataTable();
        da.Fill(dt);
        DDLAdjFrmLedger.DataSource = dt;
        DDLAdjFrmLedger.DataTextField = "AccName";
        DDLAdjFrmLedger.DataValueField = "CoaDetailID";
        DDLAdjFrmLedger.DataBind();
        DDLAdjFrmLedger.Items.Insert(0, "Select");
        conn.Close();

    }
    protected void GV_JournalVoucher_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Total_Sum = 0;
        SDTDelete = dtCurrentTable;
        SDTDelete.Rows[e.RowIndex].Delete();
        dtCurrentTable = SDTDelete;
        GV_JournalVoucher.DataSource = SDTDelete;
        GV_JournalVoucher.DataBind();
        Total_Ammount_Calculation();
    }
    public void GV_JournalVoucher_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                DropDownList DDLTransection_Ledger = (DropDownList)e.Row.FindControl("DDLTransection_Ledger");
                conn.Open();
                SqlDataAdapter da1 = new SqlDataAdapter("Usp_Vchr_ChartofAccFund", conn);
                da1.SelectCommand.CommandType = CommandType.StoredProcedure;
                da1.SelectCommand.Parameters.Add("@AccFundCode", SqlDbType.Int).Value = accfundID;//3
                da1.SelectCommand.Parameters.Add("@Vchr_Type", SqlDbType.Char).Value = "T";
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                DDLTransection_Ledger.DataSource = dt1;
                DDLTransection_Ledger.DataTextField = "AccName";
                DDLTransection_Ledger.DataValueField = "CoaDetailID";
                DDLTransection_Ledger.DataBind();
                DDLTransection_Ledger.Items.Insert(0, "Select");
                conn.Close();

                DropDownList DDLAdjustment_From = (DropDownList)e.Row.FindControl("DDLAdjustment_From");
                conn.Open();
                SqlDataAdapter daa1 = new SqlDataAdapter("Usp_Vchr_ChartofAccFund", conn);
                daa1.SelectCommand.CommandType = CommandType.StoredProcedure;
                daa1.SelectCommand.Parameters.Add("@AccFundCode", SqlDbType.Int).Value = accfundID;//3
                daa1.SelectCommand.Parameters.Add("@Vchr_Type", SqlDbType.Char).Value = "SJ";
                DataTable dat1 = new DataTable();
                daa1.Fill(dat1);
                DDLAdjustment_From.DataSource = dat1;
                DDLAdjustment_From.DataTextField = "AccName";
                DDLAdjustment_From.DataValueField = "CoaDetailID";
                DDLAdjustment_From.DataBind();
                DDLAdjustment_From.Items.Insert(0, "Select");
                conn.Close();
                TextBox txt_Amount = (TextBox)e.Row.Cells[3].FindControl("txt_Amount");
                TextBox txt_Transection_Memo = (TextBox)e.Row.Cells[4].FindControl("txt_Transection_Memo");

                if (dtCurrentTable.Rows[e.Row.RowIndex]["Transection_Ledger"] != DBNull.Value)
                {
                    DDLTransection_Ledger.SelectedValue = dtCurrentTable.Rows[e.Row.RowIndex]["Transection_Ledger"].ToString();
                }
                if (dtCurrentTable.Rows[e.Row.RowIndex]["Adjustment_From"] != DBNull.Value)
                {
                    DDLAdjustment_From.SelectedValue = dtCurrentTable.Rows[e.Row.RowIndex]["Adjustment_From"].ToString();
                }

                if (dtCurrentTable.Rows[e.Row.RowIndex]["Amount"] != DBNull.Value)
                {
                    txt_Amount.Text = dtCurrentTable.Rows[e.Row.RowIndex]["Amount"].ToString();
                    Total_Sum = (Total_Sum + Convert.ToDouble(txt_Amount.Text));
                    // Sum_amount.Text = Convert.ToString(Total_Sum);
                    // Sum_amount.Text = string.Format("{0:c0}", Total_Sum);
                    Sum_amount.Text = Convert.ToDecimal(Total_Sum).ToString("#,##0.00");
                }
                if (dtCurrentTable.Rows[e.Row.RowIndex]["Transection_Memo"] != DBNull.Value)
                {
                    txt_Transection_Memo.Text = dtCurrentTable.Rows[e.Row.RowIndex]["Transection_Memo"].ToString();
                }

                if (dtCurrentTable.Rows[e.Row.RowIndex]["Old_Data"] == "1")
                {
                    DDLTransection_Ledger.Enabled = false;
                    DDLAdjustment_From.Enabled = false;
                    e.Row.Cells[3].Enabled = false;
                }
                // e.Row.Cells[9].Visible = false;
                // e.Row.Cells[10].Visible = false;

            }
            else
            {

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
        catch (Exception ex)
        {
            PopUp(" Grid View Row Data Bound Problem. Please Contract Our Devolopment team. " + ex.Message.ToString());
        }
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
        GV_VoucherFind.DataSource = null;
        GV_VoucherFind.DataBind();

        ///////////////////////
        Find_VoucherButton.Visible = false;

    }
    protected void Gridview_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        SDTDelete = dtCurrentTable;
        SDTDelete.Rows[e.RowIndex].Delete();
        dtCurrentTable = SDTDelete;
        GV_JournalVoucher.DataSource = SDTDelete;
        GV_JournalVoucher.DataBind();
    }
    public void PopUp(string sMsg)
    {
        ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), Guid.NewGuid().ToString(), "alert('" + sMsg + "');", true);
    }

    protected void clear()
    {
        dtCurrentTable = null;
        dtOldTable = null;

        Total_Sum = 0;
        Total_Amount.Visible = false;
        Sum_amount.Visible = false;
        DDLTranLedger.SelectedIndex = 0;
        DDLAdjFrmLedger.SelectedIndex = 0;
        DDLCompany_Name.SelectedIndex = 0;
        DDLVoucherType.SelectedIndex = 0;
        txt_amount.Text = "";

        GV_JournalVoucher.DataSource = null;
        GV_JournalVoucher.Visible = false;
        LB_Voucher_Print.Visible = false;
        FromNSearch.Visible = true;
        ReportForm.Visible = false;
        ReportViewer1.LocalReport.DataSources.Clear();
        PdfLocation = "";
        fileName = "";
        ///////////////////////
        Find_VoucherButton.Visible = true;
        EditVoucherID = 0;
        SaveNprintAccVoucherTranID = 0;
        EditVoucher_Date.Visible = false;
        lblDate.Visible = false;
        txt_Voucher_Narration.Text = "";
    }
    protected void DDLVoucherType_SelectedIndexChanged(object sender, EventArgs e)
    {
        Tran_Ledger();
        AdjFrm_Ledger();
    }
    private void VoucherTypes()
    {
        if (dtVchrTypes == null)
        {
            dtVchrTypes = new DataTable();
            string SQL1 = "SELECT * FROM VoucherTypes WHERE VchrTypeID = 6 ORDER BY VchrTypeDesc ASC";
            SqlDataAdapter adpt1 = new SqlDataAdapter(SQL1, conn);
            adpt1.Fill(dtVchrTypes);
            DDLVoucherType.DataSource = dtVchrTypes;
            DDLVoucherType.DataTextField = "VchrTypeDesc";
            DDLVoucherType.DataValueField = "vchrTypeID";//

            DDLVoucherType.DataBind();
            DDLVoucherType.Items.Insert(0, new ListItem("Select", "0"));
            DDLVoucherType.SelectedValue = "6";
        }
        else
        {
            DDLVoucherType.DataSource = dtVchrTypes;
            DDLVoucherType.DataTextField = "VchrTypeDesc";
            DDLVoucherType.DataValueField = "vchrTypeID";//
            //  conn.Close();
            DDLVoucherType.DataBind();

            DDLVoucherType.Items.Insert(0, new ListItem("Select", "0"));
            DDLVoucherType.SelectedValue = "6";

        }
        VoucherTypeRead();

    }
    private void VoucherTypeRead()
    {

        if (DDLVoucherType.SelectedValue != null)
            pVchrTypeID = Convert.ToInt32(DDLVoucherType.SelectedValue);

        if (dtVchrTypes.Rows.Count > 0)
        {
            for (int i = 1; dtVchrTypes.Rows.Count >= i; i++)
            {
                if (pVchrTypeID == Convert.ToInt32(dtVchrTypes.Rows[i - 1]["VchrTypeID"]))
                {
                    VoucherTypeCode = Convert.ToString(dtVchrTypes.Rows[i - 1]["vchrType"]);
                }

            }

        }





    }

    protected void Save_Deatis(object sender, EventArgs e)
    {
        if (txt_ref_no.Text != "")
        {
            //  lblDateTime();

            if (dtCurrentTable != null)
            {

                for (int irow = 1; GV_JournalVoucher.Rows.Count >= irow; irow++)
                {
                    DropDownList DDLTransection_Ledger = (DropDownList)GV_JournalVoucher.Rows[irow - 1].Cells[1].FindControl("DDLTransection_Ledger");
                    DropDownList DDLAdjustment_From = (DropDownList)GV_JournalVoucher.Rows[irow - 1].Cells[2].FindControl("DDLAdjustment_From");
                    TextBox txt_Amount = (TextBox)GV_JournalVoucher.Rows[irow - 1].Cells[3].FindControl("txt_Amount");
                    TextBox txt_Transection_Memo = (TextBox)GV_JournalVoucher.Rows[irow - 1].Cells[4].FindControl("txt_Transection_Memo");

                    dtCurrentTable.Rows[irow - 1]["Transection_Ledger"] = DDLTransection_Ledger.SelectedValue;
                    dtCurrentTable.Rows[irow - 1]["Adjustment_From"] = DDLAdjustment_From.SelectedValue;
                    dtCurrentTable.Rows[irow - 1]["Amount"] = txt_Amount.Text;
                    dtCurrentTable.Rows[irow - 1]["Transection_Memo"] = txt_Transection_Memo.Text;

                    dtCurrentTable.Rows[irow - 1]["RowNumber"] = irow;
                }


                int AccVoucherTranID = 0;

                if (EditAccVoucherTranID != 0)
                {
                    AccVoucherTranID = EditAccVoucherTranID;
                }
                else { }

                int amount = 0;

                string[] headerinfo = new string[7];
                headerinfo[0] = accfundID.ToString();
                headerinfo[1] = DDLVoucherType.SelectedValue;
                //if (btn_save.Text == "Edit")
                //{

                if (!IsAddEditMode)
                {
                    CultureInfo cultureinfo = new CultureInfo("en-GB");
                    DateTime dt = DateTime.Parse(EditVoucher_Date.Text, cultureinfo);
                    string VchrDate = dt.Month.ToString() + "/" + dt.Day.ToString() + "/" + dt.Year.ToString();

                    string Date = VchrDate;
                    string time = System.DateTime.Now.ToString("HH:mm:ss tt");
                    string EditedDate = Date + " " + time;

                    headerinfo[2] = EditedDate;

                }
                else
                {

                    CultureInfo cultureinfo = new CultureInfo("en-GB");
                    DateTime dt = DateTime.Parse(EditVoucher_Date.Text, cultureinfo);
                    string VchrDate = dt.Month.ToString() + "/" + dt.Day.ToString() + "/" + dt.Year.ToString();

                    string Date = VchrDate;
                    string time = System.DateTime.Now.ToString("HH:mm:ss tt");
                    string EditedDate = Date + " " + time;

                    headerinfo[2] = EditedDate;

                }
                headerinfo[3] = txt_Voucher_Narration.Text.Trim();
                headerinfo[4] = txt_ref_no.Text.Trim();


                #region  VoucherCreateUpdateSingle -StoredProcedure -Diclear
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                conn.Open();
                SqlTransaction Transection = conn.BeginTransaction();
                #endregion

                try
                {
                    for (int irow = 1; GV_JournalVoucher.Rows.Count >= irow; irow++)
                    {
                        for (int count = 1; count <= 2; count++)
                        {
                            if (AccVoucherTranID == 0)
                            {
                                cmd.Parameters.Add("@AccVoucherTranID", SqlDbType.Int).Value = Convert.ToInt64(AccVoucherTranID);// @AccVoucherTranID int,--0
                                cmd.Parameters.Add("@AccFundID", SqlDbType.Int).Value = Convert.ToInt64(headerinfo[0]);  //@AccFundID int,--3
                                cmd.Parameters.Add("@AccBranchCode", SqlDbType.Int).Value = DBNull.Value;  //@AccBranchCode int,--1 by def
                                cmd.Parameters.Add("@VchrTypeID", SqlDbType.Int).Value = Convert.ToInt64(headerinfo[1]); //@VchrTypeID int,--2



                                cmd.Parameters.Add("@PayDate", SqlDbType.DateTime).Value = headerinfo[2];//.ToString("MMMM/dd/yyyy");//PayDate

                                cmd.Parameters.Add("@RefNo", SqlDbType.NVarChar).Value = headerinfo[4]; //@RefNo Nvarchar(50),--null
                                cmd.Parameters.Add("@PaidTo", SqlDbType.NVarChar).Value = DBNull.Value;   //@PaidTo Nvarchar(50),--
                                //cmd.Parameters.Add("@HeadAcc", SqlDbType.Int).Value = Convert.ToInt64(dtCurrentTable.Rows[irow - 1]["Transection_Ledger"]);

                                // cmd.Parameters.Add("@RevAcc", SqlDbType.Int).Value = DBNull.Value;  //@RevAcc int,--Cash Bank sou
                                cmd.Parameters.Add("@AccSubTypeID", SqlDbType.Int).Value = DBNull.Value; //@AccSubTypeID int,-- Sub type mo
                                cmd.Parameters.Add("@AccSubCode", SqlDbType.Int).Value = DBNull.Value;//@AccSubCode int,
                                cmd.Parameters.Add("@AccSubTypeID1", SqlDbType.Int).Value = DBNull.Value;//Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Type1"]);//@AccSubTypeID1 int,-- Sub type1 mo
                                cmd.Parameters.Add("@AccSubCode1", SqlDbType.Int).Value = DBNull.Value;//Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Ledger1"]); //@AccSubCode1 int,
                                cmd.Parameters.Add("@AccSubTypeID2", SqlDbType.Int).Value = DBNull.Value;//Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Type2"]);  //@AccSubTypeID2 int,-- Sub type2 mo
                                cmd.Parameters.Add("@AccSubCode2", SqlDbType.Int).Value = DBNull.Value;// Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Ledger2"]);  //@AccSubCode2 int,

                                cmd.Parameters.Add("@Chequeno", SqlDbType.NVarChar).Value = DBNull.Value;                            // @Chequeno Nvarchar(50),
                                cmd.Parameters.Add("@ChequeDT", SqlDbType.DateTime).Value = DBNull.Value; //headerinfo[4];       //	@ChequeDT Datetime,
                                cmd.Parameters.Add("@ChequeBankBranch", SqlDbType.NVarChar).Value = DBNull.Value; // 

                                if (amount == 0)
                                {
                                    cmd.Parameters.Add("@HeadAcc", SqlDbType.Int).Value = Convert.ToInt64(dtCurrentTable.Rows[irow - 1]["Transection_Ledger"]);
                                    cmd.Parameters.Add("@RevAcc", SqlDbType.Int).Value = Convert.ToInt64(dtCurrentTable.Rows[irow - 1]["Adjustment_From"]);
                                    cmd.Parameters.Add("@DebitAmt", SqlDbType.Money).Value = dtCurrentTable.Rows[irow - 1]["Amount"];//@DebitAmt Money,--
                                    cmd.Parameters.Add("@CreditAmt", SqlDbType.Money).Value = 0;
                                    cmd.Parameters.Add("@IsRevtran", SqlDbType.Int).Value = 0;
                                    count--;
                                    amount = 1;

                                }
                                else
                                {
                                    cmd.Parameters.Add("@RevAcc", SqlDbType.Int).Value = Convert.ToInt64(dtCurrentTable.Rows[irow - 1]["Transection_Ledger"]);
                                    cmd.Parameters.Add("@HeadAcc", SqlDbType.Int).Value = Convert.ToInt64(dtCurrentTable.Rows[irow - 1]["Adjustment_From"]);
                                    cmd.Parameters.Add("@DebitAmt", SqlDbType.Money).Value = 0;
                                    cmd.Parameters.Add("@CreditAmt", SqlDbType.Money).Value = dtCurrentTable.Rows[irow - 1]["Amount"];//@DebitAmt Money,--
                                    cmd.Parameters.Add("@IsRevtran", SqlDbType.Int).Value = 1;
                                    amount = 0;
                                }
                                //cmd.Parameters.Add("@IsRevtran", SqlDbType.Int).Value = DBNull.Value;
                                cmd.Parameters.Add("@DepartmentsID", SqlDbType.Int).Value = 0;   //@DepartmentsID int,-- Null
                                cmd.Parameters.Add("@AccRemarks", SqlDbType.NVarChar).Value = headerinfo[3];//@AccRemarks Nvarchar(500),--memo
                                cmd.Parameters.Add("@TranComments", SqlDbType.NVarChar).Value = dtCurrentTable.Rows[irow - 1]["Transection_Memo"];

                                //cmd.Parameters.Add("@IsRevtran", SqlDbType.Int).Value = 0;     //@IsRevtran int,--0
                                cmd.Parameters.Add("@IsPosted", SqlDbType.Int).Value = 0; //@IsPosted int,--0
                                cmd.Parameters.Add("@AccVoucherTranIDRef", SqlDbType.Int).Value = 0;
                                cmd.Parameters["@AccVoucherTranIDRef"].Direction = ParameterDirection.Output;


                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.CommandText = "VoucherCreateUpdateSingleAccounts";//"VoucherCreateUpdateSingle";
                                cmd.Transaction = Transection;
                                AccVoucherTranID = cmd.ExecuteNonQuery();
                                AccVoucherTranID = (int)cmd.Parameters["@AccVoucherTranIDRef"].Value;

                            }
                            else
                            {
                                cmd = new SqlCommand();

                                cmd.Parameters.Add("@AccVoucherTranID", SqlDbType.Int).Value = Convert.ToInt64(AccVoucherTranID);// @AccVoucherTranID int,--0
                                cmd.Parameters.Add("@AccFundID", SqlDbType.Int).Value = Convert.ToInt64(headerinfo[0]);  //@AccFundID int,--3
                                cmd.Parameters.Add("@AccBranchCode", SqlDbType.Int).Value = DBNull.Value;  //@AccBranchCode int,--1 by def
                                cmd.Parameters.Add("@VchrTypeID", SqlDbType.Int).Value = Convert.ToInt64(headerinfo[1]); //@VchrTypeID int,--2
                                if (headerinfo[2] != null)
                                {
                                    cmd.Parameters.Add("@PayDate", SqlDbType.DateTime).Value = headerinfo[2];//.ToString("MMMM/dd/yyyy");//PayDate
                                }
                                else
                                {
                                    cmd.Parameters.Add("@PayDate", SqlDbType.DateTime).Value = DBNull.Value;//.ToString("MMMM/dd/yyyy");//PayDate

                                }
                                cmd.Parameters.Add("@RefNo", SqlDbType.NVarChar).Value = headerinfo[4]; //@RefNo Nvarchar(50),--null
                                cmd.Parameters.Add("@PaidTo", SqlDbType.NVarChar).Value = DBNull.Value;   //@PaidTo Nvarchar(50),--
                                cmd.Parameters.Add("@AccSubTypeID", SqlDbType.Int).Value = DBNull.Value; //@AccSubTypeID int,-- Sub type mo
                                cmd.Parameters.Add("@AccSubCode", SqlDbType.Int).Value = DBNull.Value;//@AccSubCode int,
                                cmd.Parameters.Add("@AccSubTypeID1", SqlDbType.Int).Value = DBNull.Value;//Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Type1"]);//@AccSubTypeID1 int,-- Sub type1 mo
                                cmd.Parameters.Add("@AccSubCode1", SqlDbType.Int).Value = DBNull.Value;//Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Ledger1"]); //@AccSubCode1 int,
                                cmd.Parameters.Add("@AccSubTypeID2", SqlDbType.Int).Value = DBNull.Value;//Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Type2"]);  //@AccSubTypeID2 int,-- Sub type2 mo
                                cmd.Parameters.Add("@AccSubCode2", SqlDbType.Int).Value = DBNull.Value;// Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Ledger2"]);  //@AccSubCode2 int,

                                cmd.Parameters.Add("@Chequeno", SqlDbType.NVarChar).Value = DBNull.Value;                            // @Chequeno Nvarchar(50),
                                cmd.Parameters.Add("@ChequeDT", SqlDbType.DateTime).Value = DBNull.Value; //headerinfo[4];       //	@ChequeDT Datetime,
                                cmd.Parameters.Add("@ChequeBankBranch", SqlDbType.NVarChar).Value = DBNull.Value; // 


                                if (amount == 0)
                                {
                                    cmd.Parameters.Add("@HeadAcc", SqlDbType.Int).Value = Convert.ToInt64(dtCurrentTable.Rows[irow - 1]["Transection_Ledger"]);
                                    cmd.Parameters.Add("@RevAcc", SqlDbType.Int).Value = Convert.ToInt64(dtCurrentTable.Rows[irow - 1]["Adjustment_From"]);

                                    cmd.Parameters.Add("@DebitAmt", SqlDbType.Money).Value = dtCurrentTable.Rows[irow - 1]["Amount"];//@DebitAmt Money,--
                                    cmd.Parameters.Add("@CreditAmt", SqlDbType.Money).Value = 0;
                                    cmd.Parameters.Add("@IsRevtran", SqlDbType.Int).Value = 0;
                                    count--;
                                    amount = 1;

                                }
                                else
                                {
                                    cmd.Parameters.Add("@RevAcc", SqlDbType.Int).Value = Convert.ToInt64(dtCurrentTable.Rows[irow - 1]["Transection_Ledger"]);
                                    cmd.Parameters.Add("@HeadAcc", SqlDbType.Int).Value = Convert.ToInt64(dtCurrentTable.Rows[irow - 1]["Adjustment_From"]);
                                    cmd.Parameters.Add("@DebitAmt", SqlDbType.Money).Value = 0;
                                    cmd.Parameters.Add("@CreditAmt", SqlDbType.Money).Value = dtCurrentTable.Rows[irow - 1]["Amount"];//@DebitAmt Money,--
                                    cmd.Parameters.Add("@IsRevtran", SqlDbType.Int).Value = 1;
                                    amount = 0;
                                }
                                cmd.Parameters.Add("@DepartmentsID", SqlDbType.Int).Value = 0;   //@DepartmentsID int,-- 0
                                cmd.Parameters.Add("@AccRemarks", SqlDbType.NVarChar).Value = headerinfo[3];//@AccRemarks Nvarchar(500),--memo

                                cmd.Parameters.Add("@TranComments", SqlDbType.NVarChar).Value = dtCurrentTable.Rows[irow - 1]["Transection_Memo"];
                                // cmd.Parameters.Add("@IsRevtran", SqlDbType.Int).Value = 1;     //@IsRevtran int,--0
                                cmd.Parameters.Add("@IsPosted", SqlDbType.Int).Value = 0; //@IsPosted int,--0
                                cmd.Parameters.Add("@AccVoucherTranIDRef", SqlDbType.Int).Value = 0;
                                cmd.Parameters["@AccVoucherTranIDRef"].Direction = ParameterDirection.Output;


                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.CommandText = "VoucherCreateUpdateSingleAccounts";
                                cmd.Connection = conn;
                                cmd.Transaction = Transection;
                                cmd.ExecuteNonQuery();
                                AccVoucherTranID = cmd.ExecuteNonQuery();
                                AccVoucherTranID = (int)cmd.Parameters["@AccVoucherTranIDRef"].Value;
                            }
                        }
                    }
                    SaveNprintAccVoucherTranID = AccVoucherTranID;

                    Transection.Commit();
                    lblMsg.Text = "";
                    lblMsg.Text = "Transaction Complete\n";
                    conn.Close();
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    Transection.Rollback();
                    PopUp("Journal in not Save. Please try Again" + ex.Message.ToString());
                }


            }
            else
            { }
            clear();
            EditVoucher();

            btn_save.Visible = false;
            IsAddEditMode = true;


            lbl_SMsgg.Text = " Save Successfully ";
            lbl_SMsgg.Visible = true;

        }
        else
        {
            // lblMsg.Text = "Please Give A Peference Number";
            PopUp("Please Give A Peference Number");


        }


    }
    protected void Add_Deatis(object sender, EventArgs e)
    {
        GV_JournalVoucher.Visible = true;
        if (txt_amount.Text != "" && DDLAdjFrmLedger.SelectedIndex != 0 && DDLTranLedger.SelectedIndex != 0)
        {
            Total_Sum = 0;
            SetInitialRow();
            GV_JournalVoucher.Visible = true;

            DDLTranLedger.SelectedIndex = 0;
            DDLAdjFrmLedger.SelectedIndex = 0;
            txt_amount.Text = "";
            Total_Amount.Visible = true;
            Sum_amount.Visible = true;
        }
        else
        {
            PopUp("Please Select Head Of Account, Adjustment From and  Amount");

        }

    }
    private void SetInitialRow()
    {
        if (dtCurrentTable == null)
        {
            irows = 1;
            dtCurrentTable = new DataTable();
            DataRow dr = null;
            dtCurrentTable.Columns.Add(new DataColumn("RowNumber", typeof(string)));
            dtCurrentTable.Columns.Add(new DataColumn("Transection_Ledger", typeof(string)));
            dtCurrentTable.Columns.Add(new DataColumn("Adjustment_From", typeof(string)));
            dtCurrentTable.Columns.Add(new DataColumn("Amount", typeof(string)));
            dtCurrentTable.Columns.Add(new DataColumn("Transection_Memo", typeof(string)));
            dtCurrentTable.Columns.Add(new DataColumn("Old_Data", typeof(string)));
            dr = dtCurrentTable.NewRow();
            dr["RowNumber"] = irows;

            dr["Transection_Ledger"] = DDLTranLedger.SelectedValue;
            dr["Adjustment_From"] = DDLAdjFrmLedger.SelectedValue;//string.Empty;
            dr["Amount"] = Convert.ToDecimal(txt_amount.Text).ToString("#,##0.00"); //dr["Amount"] = txt_amount.Text;//string.Empty;
            dr["Transection_Memo"] = string.Empty;
            dr["Old_Data"] = string.Empty;
            dtCurrentTable.Rows.Add(dr);
            irows++;
            GV_JournalVoucher.DataSource = dtCurrentTable;
            GV_JournalVoucher.DataBind();

        }
        else
        {
            // dtCurrentTable = null;
            for (int irow = 1; GV_JournalVoucher.Rows.Count >= irow; irow++)
            {
                DropDownList DDLTransection_Ledger = (DropDownList)GV_JournalVoucher.Rows[irow - 1].Cells[1].FindControl("DDLTransection_Ledger");
                DropDownList DDLAdjustment_From = (DropDownList)GV_JournalVoucher.Rows[irow - 1].Cells[2].FindControl("DDLAdjustment_From");
                TextBox txt_Amount = (TextBox)GV_JournalVoucher.Rows[irow - 1].Cells[3].FindControl("txt_Amount");
                TextBox txt_Transection_Memo = (TextBox)GV_JournalVoucher.Rows[irow - 1].Cells[4].FindControl("txt_Transection_Memo");

                dtCurrentTable.Rows[irow - 1]["Transection_Ledger"] = DDLTransection_Ledger.SelectedValue;
                dtCurrentTable.Rows[irow - 1]["Adjustment_From"] = DDLAdjustment_From.SelectedValue;
                dtCurrentTable.Rows[irow - 1]["Amount"] = txt_Amount.Text;
                dtCurrentTable.Rows[irow - 1]["Transection_Memo"] = txt_Transection_Memo.Text;

                dtCurrentTable.Rows[irow - 1]["RowNumber"] = irow;
            }
            DataRow dr = null;
            dr = dtCurrentTable.NewRow();
            dr["RowNumber"] = irows;
            dr["Transection_Ledger"] = DDLTranLedger.SelectedValue;
            dr["Adjustment_From"] = DDLAdjFrmLedger.SelectedValue;//string.Empty;
            dr["Amount"] = Convert.ToDecimal(txt_amount.Text).ToString("#,##0.00"); //dr["Amount"] = txt_amount.Text;//string.Empty;

            dr["Transection_Memo"] = string.Empty;
            dr["Old_Data"] = string.Empty;
            dtCurrentTable.Rows.Add(dr);
            irows++;

            GV_JournalVoucher.DataSource = dtCurrentTable;
            GV_JournalVoucher.DataBind();
        }

    }
    protected void Cancel_Voucher(object sender, EventArgs e)
    {
        clear();
        Response.Redirect("~/Pages/JournalVoucher.aspx");
    }

    protected void Find_Voucher_Data(object sender, EventArgs e)
    {
        GV_VoucherFind_bind();
        ///////////////////////
        Find_VoucherButton.Visible = false;
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
    private void VoucherTypes_find()
    {

        conn.Open();
        string SQL1 = "SELECT * FROM VoucherTypes WHERE VchrTypeID = 6 ORDER BY VchrTypeDesc ASC";// WHERE VchrTypeID= 1";
        SqlDataAdapter adpt1 = new SqlDataAdapter(SQL1, conn);
        DataTable dt1 = new DataTable();
        adpt1.Fill(dt1);
        DDLVoucherType_Find.DataSource = dt1;
        DDLVoucherType_Find.DataTextField = "VchrTypeDesc";
        DDLVoucherType_Find.DataValueField = "vchrTypeID";//
        DDLVoucherType_Find.DataBind();
        DDLVoucherType_Find.Items.Insert(0, new ListItem("Select", "0"));
        DDLVoucherType_Find.SelectedValue = "6";
        conn.Close();

    }

    private void GV_VoucherFind_bind()
    {
        try
        {

            string SQL = "SELECT [AccVoucherTranID], [VchrNumber],[RefNo],Convert(Varchar (11),[AccTranDate],106) as [AccTranDate],[PaidTo],[AccRemarks] FROM [AccTrnHeader] WHERE ";

            if (txt_CVoucher_No_Find.Text != "")
            {
                SQL += "VchrNumber LIKE '%" + txt_CVoucher_No_Find.Text + "%' AND AccFundCode='" + accfundID.ToString() + "' AND VchrType='" + VoucherTypeCode + "'";
            }
            else
            {
                SQL += " VchrType='" + VoucherTypeCode + "'AND AccFundCode='" + accfundID.ToString() + "'";

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
            PopUp("Please Select Voucher Type" + ex.Message.ToString());

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
        EditVoucher_Date.Visible = true;
        lblDate.Visible = false;
        Total_Sum = 0;
        Total_Amount.Visible = true;
        Sum_amount.Visible = true;
        ///////////
    }
    private void EditVoucher()
    {
        LB_Voucher_Print.Visible = true;

        CP_Header.Text = "";
        CP_Header.Text = "Edit";
        CP_Header.Visible = true;
        dtOldTable = null;
        Find_VoucherButton.Visible = true;

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
        string SQL = "SELECT VchrNo,[AccTrnDetailID],[AccTranSLNO],[RevAcc] as Adjustment_From,[AccVoucherTranID],Tran_Comment,[AccFundID],[VchrTypeID],[AccCode] as Transection_Ledger,[Debit] as Amount ,[Credit],[AccCurrency] as Currency ,[AccCurrencyRate] as Exchange_Rate,[AccSubTypeID] as Sub_Type ,[AccSubCode] as Sub_Ledger,[AccSubTypeID1] as Sub_Type1,[AccSubCode1] as Sub_Ledger1,[AccSubTypeID2] as Sub_Type2,[AccSubCode2] as Sub_Ledger2 FROM [AccTrnDetail] Where AccVoucherTranID=" + EditVoucherID + " AND IsRevtran !=1";

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
        EditAccVoucherTranID = Convert.ToInt32(dtHeader.Rows[0]["AccVoucherTranID"]);


        DateTime VchrDate = Convert.ToDateTime(dtHeader.Rows[0]["AccTranDate"]);

        string Date = VchrDate.Day.ToString() + "/" + VchrDate.Month.ToString() + "/" + VchrDate.Year.ToString();// Convert.ToDateTime(EditVoucher_Date.Text).ToString("MM/dd/yyyy");// EditVoucher_Date.Text;

        EditVoucher_Date.Text = Date;

        lblDate.Text = Date;

        Lbl_Last_VoucherNo.Text = Convert.ToString(dtHeader.Rows[0]["VchrNumber"]);

        //EditVoucher_Date.Text = Convert.ToDateTime(dtHeader.Rows[0]["AccTranDate"]).ToString("MMMM/dd/yyyy");//Convert.ToInt32(GV_VoucherFind.SelectedDataKey["AccVoucherTranID"].ToString());

        if (dtOldTable == null)
        {

            dtOldTable = new DataTable();
            DataRow dr = null;


            dtOldTable.Columns.Add(new DataColumn("RowNumber", typeof(string)));
            dtOldTable.Columns.Add(new DataColumn("Transection_Ledger", typeof(string)));
            dtOldTable.Columns.Add(new DataColumn("Adjustment_From", typeof(string)));
            dtOldTable.Columns.Add(new DataColumn("Amount", typeof(string)));
            dtOldTable.Columns.Add(new DataColumn("Transection_Memo", typeof(string)));
            dtOldTable.Columns.Add(new DataColumn("Old_Data", typeof(string)));
            dr = dtOldTable.NewRow();

            for (int rnow = 1; dtTranDetails.Rows.Count >= rnow; rnow++)
            {
                dr = dtOldTable.NewRow();
                dr["RowNumber"] = rnow; // tran details ID
                dr["Transection_Ledger"] = dtTranDetails.Rows[rnow - 1]["Transection_Ledger"];//string.Empty;Convert.ToInt64(dtCurrentTable.Rows[LastRow - 1]["Transection_Ledger"]);
                dr["Adjustment_From"] = dtTranDetails.Rows[rnow - 1]["Adjustment_From"];//string.Empty;
                dr["Amount"] = Convert.ToDecimal(dtTranDetails.Rows[rnow - 1]["Amount"]).ToString("#,##0.00");// dr["Amount"] = dtTranDetails.Rows[rnow - 1]["Amount"];// string.Empty;
                dr["Transection_Memo"] = dtTranDetails.Rows[rnow - 1]["Tran_Comment"];// string.Empty;

                dr["Old_Data"] = "1"; // string.Empty;
                dtOldTable.Rows.Add(dr);

            }

        }
        else { }

        //////////////

        string[] VoucherInfo = new string[10];
        VoucherInfo[0] = dtHeader.Rows[0]["AccFundCode"].ToString();// Company Name
        VoucherInfo[1] = dtHeader.Rows[0]["VchrTypesID"].ToString();
        VoucherInfo[2] = dtHeader.Rows[0]["AccRemarks"].ToString();
        VoucherInfo[3] = dtHeader.Rows[0]["RefNo"].ToString();

        DDLCompany_Name.SelectedValue = VoucherInfo[0];
        DDLVoucherType.SelectedValue = VoucherInfo[1];
        txt_Voucher_Narration.Text = VoucherInfo[2];
        txt_ref_no.Text = VoucherInfo[3];

        VoucherTypes();
        Tran_Ledger();
        AdjFrm_Ledger();


        dtCurrentTable = null;
        dtCurrentTable = dtOldTable;
        GV_JournalVoucher.DataSource = null;
        GV_JournalVoucher.DataSource = dtCurrentTable;

        GV_JournalVoucher.DataBind();
        GV_JournalVoucher.Visible = true;
        DDLCompany_Name.Enabled = false;
        DDLVoucherType.Enabled = false;
        IsAddEditMode = false;

    }
    protected void Print_Voucher(object sender, EventArgs e)
    {

        string PDFPath = new DirectoryInfo(HttpContext.Current.Server.MapPath("~/")) + "PDF\\";
        bool IsExitsPDF = File.Exists(PDFPath + fileName);

        if (IsExitsPDF)
        {
            File.Delete(PdfLocation);
            //
            Return_Voucher_btn.Visible = true;
            CP_Header.Text = "";
            CP_Header.Text = "Report";
            FromNSearch.Visible = false;
            ReportForm.Visible = true;
            //
            lbl_SMsgg.Text = null;
            lbl_SMsgg.Visible = false;

            #region Viewing Rdlc Report
            try
            {
                string[] perameter = new string[5];
                perameter[0] = dtreport.Rows[0]["AccFundID"].ToString();//DDLCompany_Name.SelectedValue;
                perameter[1] = dtreport.Rows[0]["VchrTypeID"].ToString();// DDLVoucherType.SelectedValue;
                perameter[2] = "0";
                // DDLCashBankSource.SelectedValue;
                perameter[3] = dtreport.Rows[0]["VchrNo"].ToString();// DDLVoucherNo.SelectedValue;
                string a = DateTime.Now.ToString();
                perameter[4] = Convert.ToDateTime(a).ToString();


                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.Reset();
                DataTable dt = getdata(Convert.ToInt32(perameter[0]), Convert.ToInt32(perameter[1]), Convert.ToInt32(perameter[2]), Convert.ToString(perameter[3]), perameter[4]);//, perameter[1], perameter[2], perameter[3], perameter[4]);
                ReportDataSource rds = new ReportDataSource("CP_Data_GetVoucherPrintIpac", dt);
                ReportViewer1.LocalReport.DataSources.Add(rds);

                string ReportPath = new DirectoryInfo(HttpContext.Current.Server.MapPath("/Controls/")) + "SalesJournal.rdlc";
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


            }

            catch (Exception ex)
            {
                PopUp("Rdlc Creating Problem. Please Try Again" + ex.Message.ToString());
            }
            #endregion

            try
            {
                // string PDFPath = new DirectoryInfo(HttpContext.Current.Server.MapPath("~/")).Parent.FullName + "\\WebApp\\PDF\\";
                Microsoft.Reporting.WebForms.Warning[] warnings = null;
                string[] streamids = null;
                String mimeType = null;
                String encoding = null;
                String extension = null;
                Byte[] bytes = null;

                //  string fileName = string.Format("{0:yyyy-MM-dd_hh-mm-ss-tt}", DateTime.Now);

                fileName = "SalesJournal" + DateTime.Now.ToFileTime() + ".pdf";


                bytes = ReportViewer1.LocalReport.Render("PDF", "", out mimeType, out encoding, out extension, out streamids, out warnings);
                // bool IsExitsPDF = File.Exists(PDFPath + fileName);

                FileStream fs = new FileStream(PDFPath + fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                byte[] data = new byte[fs.Length];
                fs.Write(bytes, 0, bytes.Length);
                fs.Close();
                PdfLocation = PDFPath + fileName;

                report.Attributes.Add("src", "../PDF/" + fileName);

            }

            catch (Exception ex)
            {

                PopUp("PDF Creating Prblem Please Try Again" + ex.Message.ToString());    //throw;
            }
        }
        else
        {
            Return_Voucher_btn.Visible = true;
            CP_Header.Text = "";
            CP_Header.Text = "Report";
            FromNSearch.Visible = false;
            ReportForm.Visible = true;
            //
            lbl_SMsgg.Text = null;
            lbl_SMsgg.Visible = false;

            #region Viewing Rdlc Report
            try
            {
                string[] perameter = new string[5];
                perameter[0] = dtreport.Rows[0]["AccFundID"].ToString();//DDLCompany_Name.SelectedValue;
                perameter[1] = dtreport.Rows[0]["VchrTypeID"].ToString();// DDLVoucherType.SelectedValue;
                perameter[2] = "0";
                // DDLCashBankSource.SelectedValue;
                perameter[3] = dtreport.Rows[0]["VchrNo"].ToString();// DDLVoucherNo.SelectedValue;
                string a = DateTime.Now.ToString();
                perameter[4] = Convert.ToDateTime(a).ToString();


                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.Reset();
                DataTable dt = getdata(Convert.ToInt32(perameter[0]), Convert.ToInt32(perameter[1]), Convert.ToInt32(perameter[2]), Convert.ToString(perameter[3]), perameter[4]);//, perameter[1], perameter[2], perameter[3], perameter[4]);
                ReportDataSource rds = new ReportDataSource("CP_Data_GetVoucherPrintIpac", dt);
                ReportViewer1.LocalReport.DataSources.Add(rds);

                string ReportPath = new DirectoryInfo(HttpContext.Current.Server.MapPath("/Controls/")) + "SalesJournal.rdlc";
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


            }

            catch (Exception ex)
            {
                PopUp("Rdlc Creating Problem. Please Try Again" + ex.Message.ToString());
            }
            #endregion

            try
            {
                // string PDFPath = new DirectoryInfo(HttpContext.Current.Server.MapPath("~/")).Parent.FullName + "\\WebApp\\PDF\\";
                Microsoft.Reporting.WebForms.Warning[] warnings = null;
                string[] streamids = null;
                String mimeType = null;
                String encoding = null;
                String extension = null;
                Byte[] bytes = null;

                //  string fileName = string.Format("{0:yyyy-MM-dd_hh-mm-ss-tt}", DateTime.Now);

                fileName = "SalesJournal" + DateTime.Now.ToFileTime() + ".pdf";


                bytes = ReportViewer1.LocalReport.Render("PDF", "", out mimeType, out encoding, out extension, out streamids, out warnings);
                //bool IsExitsPDF = File.Exists(PDFPath + fileName);

                FileStream fs = new FileStream(PDFPath + fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                byte[] data = new byte[fs.Length];
                fs.Write(bytes, 0, bytes.Length);
                fs.Close();
                PdfLocation = PDFPath + fileName;

                report.Attributes.Add("src", "../PDF/" + fileName);

            }

            catch (Exception ex)
            {

                PopUp("PDF Creating Problem. Please Try Again" + ex.Message.ToString());
            }

        }




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
        Response.Redirect("~/Pages/SalesJournal.aspx");
    }

    protected void txt_Amount_TextChanged(object sender, EventArgs e)
    {
        Total_Ammount_Calculation();

    }

    private void Total_Ammount_Calculation()
    {
        Decimal Total = 0m;
        Decimal Sum_Total = 0m;

        for (int irow = 1; GV_JournalVoucher.Rows.Count >= irow; irow++)
        {
            TextBox txt_Amount = (TextBox)GV_JournalVoucher.Rows[irow - 1].Cells[3].FindControl("txt_Amount");
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

}
