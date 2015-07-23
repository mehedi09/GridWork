using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class Controls_BankReconciliation : System.Web.UI.UserControl
{
    string conr = ConfigurationManager.ConnectionStrings["MyCompany"].ConnectionString;
    SqlConnection con;
    MyCompany.Rules.SharedBusinessRules ad = new MyCompany.Rules.SharedBusinessRules();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            getBankLedger();
            GetLastReconciliationDate();
            
        }
    }
    public void getBankLedger()
    {
        int accfund = 3;
        if (!string.IsNullOrEmpty(ad.CompanyID.ToString()))
        {
            accfund = int.Parse(ad.CompanyID.ToString());
        }
        con = new SqlConnection(conr);
        SqlDataAdapter adpt = new SqlDataAdapter("SELECT  [CoaDetailID],[AccName]  FROM [dbo].[CoaDetail] where IsBankNature='True' and AccFundID="+accfund, con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        ddlBankLedger.DataSource = dt;
        ddlBankLedger.DataTextField = "AccName";
        ddlBankLedger.DataValueField = "CoaDetailID";
        ddlBankLedger.DataBind();
        ddlBankLedger.Items.Insert(0, new ListItem("--Select Bank Ledger--", ""));
       
    }
    
    public void GetLastReconciliationDate()
    {

        con = new SqlConnection(conr);
        SqlDataAdapter adpt = new SqlDataAdapter("SELECT top 1 [Todate]FROM [dbo].[BankReconcilTrans] order by Todate desc", con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
       if(dt.Rows.Count>0)
       {
           lblLastReconciliationDate.Text = Convert.ToDateTime(dt.Rows[0]["Todate"].ToString()).ToString("MM/dd/yyyy");
       }
       else
       {
           //lblLastReconciliationDate.Text = System.DateTime.Now.ToString("MM/dd/yyyy");
           lblLastReconciliationDate.Text = "06/17/2015" ;
       }

    }
    private void GetLedgerBalance(int LedgerID)
    {
        decimal ledgervalue = 0;
        int accfund = 3;
        if (!string.IsNullOrEmpty(ad.CompanyID.ToString()))
        {
            accfund = int.Parse(ad.CompanyID.ToString());
        }
        DataTable dt = new DataTable();

        con = new SqlConnection(conr);
        {
            SqlCommand cmd = new SqlCommand("GetLedgerBalance", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@AccFundID", SqlDbType.Int).Value = accfund;
            cmd.Parameters.Add("@LedgerID", SqlDbType.Int).Value = LedgerID;
            
            SqlParameter ReturnParameter = new SqlParameter("@LedBalance", SqlDbType.Decimal);
            ReturnParameter.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(ReturnParameter);
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            adpt.Fill(dt);
        }
        if(dt.Rows.Count>0)
        {
            txtCurrentLedgerBalance.Text = dt.Rows[0]["LedBalance"].ToString();
        }


        
    }

    protected void txtEnterBankBalance_TextChanged(object sender, EventArgs e)
    {
       
        if(!string.IsNullOrEmpty(txtCurrentLedgerBalance.Text.Trim()))
        {
            if (!string.IsNullOrEmpty(txtEnterBankBalance.Text.Trim()))
            {
                txtDifferenceAmount.Text=( decimal.Parse( txtEnterBankBalance.Text.Trim())-decimal.Parse( txtCurrentLedgerBalance.Text.Trim())).ToString();
            }
            else
            {
                lblError.Text = "Please enter Bank Amount";
            }
        }
        else
        {
            lblError.Text = "Please enter ledger balance";
        }
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        GetGriddata();
    }
    public void GetGriddata()
    {
        grdLedger.DataSource = null;
        grdLedger.DataBind();
        if(string.IsNullOrEmpty( ddlBankLedger.SelectedValue))
        {
            lblError.Text = "Please select Bank ledger";
            return;
        }
        if (string.IsNullOrEmpty(lblLastReconciliationDate.Text.Trim()))
        {
            lblError.Text = "Please input last reconciliation date ";
            return;
        }
        if (string.IsNullOrEmpty(txtToDate.Text.Trim()))
        {
            lblError.Text = "Please select to date";
            return;
        }
        con = new SqlConnection(conr);
        string sql = "SELECT ad.AccVoucherTranID ,ad.AccFundID,ad.VchrTypeID,ad.AccTranDate,ad.Debit,"+
                    " ad.Credit,ad.RevAcc ,ad.VchrNo, cd.AccName FROM [dbo].[AccTrnDetail] ad inner join dbo.CoaDetail cd on cd.CoaDetailID=ad.RevAcc"+
                    " where ad.RevAcc="+ddlBankLedger.SelectedValue+" and ad.AccTranDate between'" + lblLastReconciliationDate.Text + "' and '" + txtToDate.Text + "'";
        SqlDataAdapter adpt = new SqlDataAdapter(sql, con);
        DataTable dt = new DataTable();
        adpt.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            grdLedger.DataSource = dt;
            grdLedger.DataBind();
        }
        else
        {
            lblError.Text = "No match data found";
        }

    }

    protected void btnMatched_Click(object sender, EventArgs e)
    {
        int accfund = 3;
        if (!string.IsNullOrEmpty(ad.CompanyID.ToString()))
        {
            accfund = int.Parse(ad.CompanyID.ToString());
        }
        int i=0;
        foreach (GridViewRow gvrow in grdLedger.Rows)
        {
            CheckBox chk = (CheckBox)gvrow.FindControl("chkCheck");
            if (chk.Checked)
            {
                string sql = "insert into BankReconcilTrans (ReconTranDate,Todate,AccVoucherTranID,AccFundCode,VchrTypeID)"+
                " values ('" +Convert.ToDateTime( lblLastReconciliationDate.Text) + "', '"+Convert.ToDateTime(txtToDate.Text.Trim())+"',"+int.Parse( gvrow.Cells[1].Text.Trim())+","+
                " "+accfund+", "+int.Parse( gvrow.Cells[3].Text.Trim())+")";
                SqlCommand cmd = new SqlCommand();
                con = new SqlConnection(conr);
                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
               
                lblError.Text = "Transaction Matched Successfully.";
               
                //Response.Redirect("/Pages/BankReconciliation.aspx");
                i = 0;
            }
            else
            {
                i = i + 1;
            }
        }
        GetGriddata();
        if(i>0)
        {
            
            lblError.Text = "Please select checkbox  from table ";
            return;
        }

    }

    protected void ddlBankLedger_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(ddlBankLedger.SelectedValue))
        { 
            GetLedgerBalance(int.Parse(ddlBankLedger.SelectedValue));
            string a = "";

            a = Convert.ToString(ddlBankLedger.SelectedValue);

            //////////Gridview DataBind/////////////////////
            grdVoucher.DataSource = null;
            dtCurrentTable = null;
            SetInitialRow();
            grdVoucher.Visible = true;
            //Total_Amount.Visible = true;
            //Sum_amount.Visible = true;
        }
            
    }
    static DataTable dtCurrentTable; // DataTable();
    static int irows = 1;
    static DataTable SDTDelete;
    static double Total_Sum;
    static int SaveNprintAccVoucherTranID;
    //protected void ddlDebitLedger_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    string a = "";

    //    a = Convert.ToString(ddlDebitLedger.SelectedValue);
       
    //    //////////Gridview DataBind/////////////////////
    //    grdVoucher.DataSource = null;
    //    dtCurrentTable = null;
    //    SetInitialRow();
    //    grdVoucher.Visible = true;
    //    Total_Amount.Visible = true;
    //    Sum_amount.Visible = true;
    //}
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
                grdVoucher.DataSource = dtCurrentTable;
                grdVoucher.DataBind();
            }
            else
            {
            }

        }
        catch
        {
        }
    }
    protected void Gridview_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Total_Sum = 0;
        SDTDelete = dtCurrentTable;
        SDTDelete.Rows[e.RowIndex].Delete();
        dtCurrentTable = SDTDelete;
        grdVoucher.DataSource = SDTDelete;
        grdVoucher.DataBind();
    }
    public void Gridview_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        int accfund = 3;
        if (!string.IsNullOrEmpty(ad.CompanyID.ToString()))
        {
            accfund = int.Parse(ad.CompanyID.ToString());
        }
        try
        {

            e.Row.Cells[9].Visible = false;
            e.Row.Cells[10].Visible = false;
            string sSubTypeID;
            con = new SqlConnection(conr);
            con.Open();
            string SQL_VoucherType = "SELECT * FROM VoucherTypes WHERE VchrTypeID=3";
            SqlDataAdapter data_VoucherType = new SqlDataAdapter(SQL_VoucherType, con);
            data_VoucherType.SelectCommand.CommandType = CommandType.Text;
            DataTable VoucherType = new DataTable();
            data_VoucherType.Fill(VoucherType);
            con.Close();
            string VoucherTypeCode = Convert.ToString(VoucherType.Rows[0]["vchrType"]);

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                #region  GreadView Dropdown List Currency
                DropDownList Currency = (DropDownList)e.Row.FindControl("DDLCurrency");
                string SQLCurrency = "SELECT * FROM AccCurrencys";
                SqlDataAdapter adptCurrency = new SqlDataAdapter(SQLCurrency, con);
                DataTable dtCurrency = new DataTable();
                adptCurrency.Fill(dtCurrency);
                Currency.DataSource = dtCurrency;
                Currency.DataTextField = "AccCurrencySymble";
                Currency.DataValueField = "AccCurrencyID";
                Currency.DataBind();
                #endregion

                //////////////////////////////////////////////////////// 
               
                    //if (VoucherTypeCode == "CP" || VoucherTypeCode == "BP")//1 CP, 3 BP
                    //{
                        DropDownList DDLTransection_Ledger = (DropDownList)e.Row.FindControl("DDLTransection_Ledger");
                        SqlDataAdapter da1 = new SqlDataAdapter("Usp_Vchr_ChartofAccFund", con);
                        da1.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da1.SelectCommand.Parameters.Add("@AccFundCode", SqlDbType.Int).Value = accfund;//3
                        da1.SelectCommand.Parameters.Add("@Vchr_Type", SqlDbType.Char).Value = "S";
                        DataTable Vchr_ChartofAccFund = new DataTable();
                        da1.Fill(Vchr_ChartofAccFund);
                        DDLTransection_Ledger.DataSource = Vchr_ChartofAccFund;
                        DDLTransection_Ledger.DataTextField = "AccName";
                        DDLTransection_Ledger.DataValueField = "CoaDetailID";
                        DDLTransection_Ledger.DataBind();

                    //}

                    DropDownList DDLT_Ledger = (DropDownList)e.Row.Cells[1].FindControl("DDLTransection_Ledger");

                    DropDownList DDLS_Type = (DropDownList)e.Row.Cells[2].FindControl("DDLSub_Type");
                    DropDownList DDLS_Ledger = (DropDownList)e.Row.Cells[3].FindControl("DDLSub_Ledger");

                    DropDownList DDLS_Type1 = (DropDownList)e.Row.Cells[4].FindControl("DDLSub_Type1");
                    DropDownList DDLS_Ledger1 = (DropDownList)e.Row.Cells[5].FindControl("DDLSub_Ledger1");

                    DropDownList DDLS_Type2 = (DropDownList)e.Row.Cells[6].FindControl("DDLSub_Type2");
                    DropDownList DDLS_Ledger2 = (DropDownList)e.Row.Cells[7].FindControl("DDLSub_Ledger2");


                    TextBox txt_Dr_Amount = (TextBox)e.Row.Cells[8].FindControl("txt_Amount");
                    //Label lblTotal = (Label)e.Row.Cells[8].FindControl("lblTotal");
                    DropDownList DDLCurr = (DropDownList)e.Row.Cells[9].FindControl("DDLCurrency");
                    TextBox txt_Exc_Rate = (TextBox)e.Row.Cells[10].FindControl("txt_Exchange_Rate");
                    TextBox txt_Transection_Memo = (TextBox)e.Row.Cells[11].FindControl("txt_Transection_Memo");

                    if (dtCurrentTable.Rows[e.Row.RowIndex]["Transection_Ledger"] != DBNull.Value)
                        DDLT_Ledger.SelectedValue = dtCurrentTable.Rows[e.Row.RowIndex]["Transection_Ledger"].ToString();

                    string SQLSubTypeID = "SELECT CoaDetailID, AccSubTypeID,AccSubTypeID1,AccSubTypeID2 FROM CoaDetail where  CoaDetailID=" + DDLT_Ledger.SelectedValue + " AND AccFundID =" + accfund;


                    SqlDataAdapter daa = new SqlDataAdapter(SQLSubTypeID, con);
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
                    string sql = "SELECT  [AccSubCode],[AccSubTypeID],[AccSubName],[AccFundID] FROM dbo.AccSubNames where AccSubTypeID=" + sSubTypeID + " AND AccFundID =" + accfund + "ORDER BY [AccSubName] ASC";
                    SqlDataAdapter da = new SqlDataAdapter(sql, con);
                    da.SelectCommand.CommandType = CommandType.Text;
                    DataTable dtsubledger = new DataTable();
                    da.Fill(dtsubledger);

                    DDLS_Ledger.DataSource = dtsubledger;
                    DDLS_Ledger.DataTextField = "AccSubName";
                    DDLS_Ledger.DataValueField = "AccSubCode";
                    DDLS_Ledger.DataBind();
                    /////////////////////////

                    // string Sub_Type2 = DDLS_Type.SelectedValue;
                    if (dtCurrentTable.Rows[e.Row.RowIndex]["Sub_Ledger"] != DBNull.Value)
                    {
                        DDLS_Ledger.SelectedValue = dtCurrentTable.Rows[e.Row.RowIndex]["Sub_Ledger"].ToString();
                    }
                    /////////////////////
                    string sql1 = "SELECT  [AccSubCode],[AccSubTypeID],[AccSubName],[AccFundID] FROM dbo.AccSubNames where AccSubTypeID=" + sSubTypeID1 + "AND AccFundID =" + accfund + "ORDER BY [AccSubName] ASC";
                    SqlDataAdapter data1 = new SqlDataAdapter(sql1, con);
                    data1.SelectCommand.CommandType = CommandType.Text;
                    DataTable dtsubledger1 = new DataTable();
                    data1.Fill(dtsubledger1);

                    DDLS_Ledger1.DataSource = dtsubledger1;
                    DDLS_Ledger1.DataTextField = "AccSubName";
                    DDLS_Ledger1.DataValueField = "AccSubCode";
                    DDLS_Ledger1.DataBind();
                    ////
                    if (dtCurrentTable.Rows[e.Row.RowIndex]["Sub_Ledger1"] != DBNull.Value)
                    {
                        DDLS_Ledger1.SelectedValue = dtCurrentTable.Rows[e.Row.RowIndex]["Sub_Ledger1"].ToString();
                    }
                    ///////////////////////////////
                    string sql2 = "SELECT  [AccSubCode],[AccSubTypeID],[AccSubName],[AccFundID] FROM dbo.AccSubNames where AccSubTypeID= " + sSubTypeID2 + " AND AccFundID =" + accfund + "ORDER BY [AccSubName] ASC";
                    SqlDataAdapter data2 = new SqlDataAdapter(sql2, con);
                    data2.SelectCommand.CommandType = CommandType.Text;
                    DataTable dtsubledger2 = new DataTable();
                    data2.Fill(dtsubledger2);

                    DDLS_Ledger2.DataSource = dtsubledger2;
                    DDLS_Ledger2.DataTextField = "AccSubName";
                    DDLS_Ledger2.DataValueField = "AccSubCode";
                    DDLS_Ledger2.DataBind();
                    ///////////////////////////////////
                    if (dtCurrentTable.Rows[e.Row.RowIndex]["Sub_Ledger2"] != DBNull.Value)
                    {
                        DDLS_Ledger2.SelectedValue = dtCurrentTable.Rows[e.Row.RowIndex]["Sub_Ledger2"].ToString();
                    }
                    if (dtCurrentTable.Rows[e.Row.RowIndex]["Amount"] != DBNull.Value)
                    {
                        txt_Dr_Amount.Text = dtCurrentTable.Rows[e.Row.RowIndex]["Amount"].ToString();

                        Total_Sum = (Total_Sum + Convert.ToDouble(txt_Dr_Amount.Text));
                       // lblTotal.Text ="Total : "+ Convert.ToString(Total_Sum);
                    }


                    if (dtCurrentTable.Rows[e.Row.RowIndex]["Currency"] != DBNull.Value)
                    {
                        DDLCurr.SelectedValue = dtCurrentTable.Rows[e.Row.RowIndex]["Currency"].ToString();
                    }

                    if (dtCurrentTable.Rows[e.Row.RowIndex]["Exchange_Rate"] != DBNull.Value)
                    {
                        txt_Exc_Rate.Text = dtCurrentTable.Rows[e.Row.RowIndex]["Exchange_Rate"].ToString();
                    }

                    /////
                    if (dtCurrentTable.Rows[e.Row.RowIndex]["Transection_Memo"] != DBNull.Value)
                    {
                        txt_Transection_Memo.Text = dtCurrentTable.Rows[e.Row.RowIndex]["Transection_Memo"].ToString();
                    }


                    if (dtCurrentTable.Rows[e.Row.RowIndex]["Old_Data"].ToString() == "1")
                    {
                        DDLT_Ledger.Enabled = false;
                        txt_Dr_Amount.Enabled = false;
                        e.Row.Cells[11].Enabled = false;
                    }
                    e.Row.Cells[9].Visible = false;
                    e.Row.Cells[10].Visible = false;
                

            }

            // e.Row.Cells[9].Visible = false;
            // e.Row.Cells[10].Visible = false;


        }
        catch { }
    }

    protected void DDLTransection_Ledger_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            int accfund = 3;
            if (!string.IsNullOrEmpty(ad.CompanyID.ToString()))
            {
                accfund = int.Parse(ad.CompanyID.ToString());
            }
            string a = string.Empty;
            string sSubTypeID = string.Empty;
            string sSubTypeID1 = string.Empty;
            string sSubTypeID2 = string.Empty;
            con = new SqlConnection(conr);
            DropDownList DDLTransection_Ledger = (DropDownList)sender;
            DropDownList DDLSub_Type = (DropDownList)sender;
            DropDownList DDLSub_Type1 = (DropDownList)sender;
            DropDownList DDLSub_Type2 = (DropDownList)sender;

            a = DDLTransection_Ledger.SelectedValue;

            GridViewRow rowT_Ledger = (GridViewRow)DDLTransection_Ledger.NamingContainer;
            GridViewRow rowSType = (GridViewRow)DDLSub_Type.NamingContainer;
            GridViewRow rowSType1 = (GridViewRow)DDLSub_Type1.NamingContainer;
            GridViewRow rowSType2 = (GridViewRow)DDLSub_Type2.NamingContainer;

            DropDownList DDL_SType = (DropDownList)rowSType.FindControl("DDLSub_Type");
            DropDownList DDL_SType1 = (DropDownList)rowSType1.FindControl("DDLSub_Type1");
            DropDownList DDL_SType2 = (DropDownList)rowSType2.FindControl("DDLSub_Type2");

            string SQLSubTypeID = "SELECT CoaDetailID, AccSubTypeID,AccSubTypeID1,AccSubTypeID2 FROM CoaDetail where  CoaDetailID=" + DDLTransection_Ledger.SelectedValue + " AND AccFundID =" + accfund;

            SqlDataAdapter daa = new SqlDataAdapter(SQLSubTypeID, con);
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
            string sql = "SELECT  [AccSubCode],[AccSubTypeID],[AccSubName],[AccFundID] FROM dbo.AccSubNames where AccSubTypeID=" + sSubTypeID + " AND AccFundID =" + accfund + "ORDER BY [AccSubName] ASC";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
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
            string sql1 = "SELECT  [AccSubCode],[AccSubTypeID],[AccSubName],[AccFundID] FROM dbo.AccSubNames where AccSubTypeID=" + sSubTypeID1 + " AND AccFundID =" + accfund + "ORDER BY [AccSubName] ASC";
            SqlDataAdapter data1 = new SqlDataAdapter(sql1, con);
            data1.SelectCommand.CommandType = CommandType.Text;
            DataTable dtsubledger1 = new DataTable();
            data1.Fill(dtsubledger1);

            DDLSub_Ledger1.DataSource = dtsubledger1;
            DDLSub_Ledger1.DataTextField = "AccSubName";
            DDLSub_Ledger1.DataValueField = "AccSubCode";
            DDLSub_Ledger1.DataBind();
            ///////////////////////////////
            DropDownList DDLSub_Ledger2 = (DropDownList)rowT_Ledger.FindControl("DDLSub_Ledger2");
            string sql2 = "SELECT  [AccSubCode],[AccSubTypeID],[AccSubName],[AccFundID] FROM dbo.AccSubNames where AccSubTypeID= " + sSubTypeID2 + " AND AccFundID =" + accfund + "ORDER BY [AccSubName] ASC";
            SqlDataAdapter data2 = new SqlDataAdapter(sql2, con);
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

            // DataRow drCurrentRow = null;
            for (int irow = 1; grdVoucher.Rows.Count >= irow; irow++)
            {
                DropDownList RDDLT_Ledger = (DropDownList)grdVoucher.Rows[irow - 1].Cells[1].FindControl("DDLTransection_Ledger");
                DropDownList RDDLSub_Type = (DropDownList)grdVoucher.Rows[irow - 1].Cells[2].FindControl("DDLSub_Type");
                DropDownList RDDLSub_Ledger = (DropDownList)grdVoucher.Rows[irow - 1].Cells[3].FindControl("DDLSub_Ledger");

                DropDownList RDDLSub_Type1 = (DropDownList)grdVoucher.Rows[irow - 1].Cells[4].FindControl("DDLSub_Type1");
                DropDownList RDDLSub_Ledger1 = (DropDownList)grdVoucher.Rows[irow - 1].Cells[5].FindControl("DDLSub_Ledger1");

                DropDownList RDDLSub_Type2 = (DropDownList)grdVoucher.Rows[irow - 1].Cells[6].FindControl("DDLSub_Type2");
                DropDownList RDDLSub_Ledger2 = (DropDownList)grdVoucher.Rows[irow - 1].Cells[7].FindControl("DDLSub_Ledger2");
                TextBox txt_Amount = (TextBox)grdVoucher.Rows[irow - 1].Cells[8].FindControl("txt_Amount");
                DropDownList DDLCurrency = (DropDownList)grdVoucher.Rows[irow - 1].Cells[9].FindControl("DDLCurrency");
                TextBox txt_Exchange_Rate = (TextBox)grdVoucher.Rows[irow - 1].Cells[10].FindControl("txt_Exchange_Rate");
                TextBox txt_Transection_Memo = (TextBox)grdVoucher.Rows[irow - 1].Cells[11].FindControl("txt_Transection_Memo");

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

            grdVoucher.DataSource = dtCurrentTable;
            grdVoucher.DataBind();

        }
        catch { }
    }
    private void AddNewRowToGrid()
    {
        try
        {
            DataRow drCurrentRow = null;
            Total_Sum = 0;
            for (int irow = 1; grdVoucher.Rows.Count >= irow; irow++)
            {
                DropDownList DDLTransection_Ledger = (DropDownList)grdVoucher.Rows[irow - 1].Cells[1].FindControl("DDLTransection_Ledger");
                DropDownList DDLSub_Type = (DropDownList)grdVoucher.Rows[irow - 1].Cells[2].FindControl("DDLSub_Type");
                DropDownList DDLSub_Ledger = (DropDownList)grdVoucher.Rows[irow - 1].Cells[3].FindControl("DDLSub_Ledger");
                DropDownList DDLSub_Type1 = (DropDownList)grdVoucher.Rows[irow - 1].Cells[4].FindControl("DDLSub_Type1");
                DropDownList DDLSub_Ledger1 = (DropDownList)grdVoucher.Rows[irow - 1].Cells[5].FindControl("DDLSub_Ledger1");
                DropDownList DDLSub_Type2 = (DropDownList)grdVoucher.Rows[irow - 1].Cells[6].FindControl("DDLSub_Type2");
                DropDownList DDLSub_Ledger2 = (DropDownList)grdVoucher.Rows[irow - 1].Cells[7].FindControl("DDLSub_Ledger2");
                TextBox txt_Amount = (TextBox)grdVoucher.Rows[irow - 1].Cells[8].FindControl("txt_Amount");
                DropDownList DDLCurrency = (DropDownList)grdVoucher.Rows[irow - 1].Cells[9].FindControl("DDLCurrency");
                TextBox txt_Exchange_Rate = (TextBox)grdVoucher.Rows[irow - 1].Cells[10].FindControl("txt_Exchange_Rate");

                TextBox txt_Transection_Memo = (TextBox)grdVoucher.Rows[irow - 1].Cells[11].FindControl("txt_Transection_Memo");
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
            int Count = grdVoucher.Rows.Count;
            irows = Count + 1;
            drCurrentRow = dtCurrentTable.NewRow();
            drCurrentRow["RowNumber"] = irows;
            dtCurrentTable.Rows.Add(drCurrentRow);
            grdVoucher.DataSource = dtCurrentTable;
            grdVoucher.DataBind();

        }
        catch { }
    }
    protected void ButtonAdd_Click(object sender, EventArgs e)
    {
        AddNewRowToGrid();
    }

    protected void Save_Deatis(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(ddlBankLedger.SelectedValue))
        {
            lblError.Text = "Please select Bank ledger";
            return;
        }
        if (string.IsNullOrEmpty(txtVoucherdate.Text))
        {
            lblError.Text = "Please select voucher date";
            return;
        }
        double a, Result = 0;
        con = new SqlConnection(conr);
        int accfund = 3;
        if (!string.IsNullOrEmpty(ad.CompanyID.ToString()))
        {
            accfund = int.Parse(ad.CompanyID.ToString());
        }
        if (dtCurrentTable != null )
        {
            int AccVoucherTranID = 0;
            

            string[] headerinfo = new string[12];
            headerinfo[0] = accfund.ToString();//Companny Name
            headerinfo[1] = "3";//Voucher Type
            headerinfo[2] = "";//Fund Source
            headerinfo[3] = "Generate from bank Reconciliation";//Mamo

            
                DateTime VchrDate =Convert.ToDateTime(txtVoucherdate.Text.Trim());
                CultureInfo cultureinfo = new CultureInfo("en-GB");

                string Date = VchrDate.Month.ToString() + "/" + VchrDate.Day.ToString() + "/" + VchrDate.Year.ToString();
                string time = System.DateTime.Now.ToString("HH:mm:ss tt");
                string EditedDate = Date + " " + time;

                headerinfo[4] = "";

                headerinfo[10] = "";

           

            headerinfo[5] = ddlBankLedger.SelectedValue; //CashBankSource
            headerinfo[6] = "";//Paid_To
            headerinfo[7] = "";

            string sql2 = "SELECT * FROM VoucherTypes WHERE VchrTypeID=" + headerinfo[1];
            SqlDataAdapter data2 = new SqlDataAdapter(sql2, con);
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
                headerinfo[9] = "";//txt_CheckNo.Text;
                headerinfo[11] = ddlBankLedger.SelectedItem.Text;

            }
            else
            {
                headerinfo[9] = "";
                headerinfo[11] = "";
            }


            /////////// VoucherCreateUpdateSingle -StoredProcedure -Diclear  //////
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            SqlTransaction Transection = con.BeginTransaction();

            #region Transection_Ledger Loop wise save

            for (int irows = 1; grdVoucher.Rows.Count >= irows; irows++)
            {
                DropDownList DDLTransection_Ledger = (DropDownList)grdVoucher.Rows[irows - 1].Cells[1].FindControl("DDLTransection_Ledger");
                DropDownList DDLSub_Type = (DropDownList)grdVoucher.Rows[irows - 1].Cells[2].FindControl("DDLSub_Type");
                DropDownList DDLSub_Ledger = (DropDownList)grdVoucher.Rows[irows - 1].Cells[3].FindControl("DDLSub_Ledger");

                DropDownList DDLSub_Type1 = (DropDownList)grdVoucher.Rows[irows - 1].Cells[4].FindControl("DDLSub_Type1");
                DropDownList DDLSub_Ledger1 = (DropDownList)grdVoucher.Rows[irows - 1].Cells[5].FindControl("DDLSub_Ledger1");
                DropDownList DDLSub_Type2 = (DropDownList)grdVoucher.Rows[irows - 1].Cells[6].FindControl("DDLSub_Type2");
                DropDownList DDLSub_Ledger2 = (DropDownList)grdVoucher.Rows[irows - 1].Cells[7].FindControl("DDLSub_Ledger2");

                TextBox txt_Amount = (TextBox)grdVoucher.Rows[irows - 1].Cells[8].FindControl("txt_Amount");
                DropDownList DDLCurrency = (DropDownList)grdVoucher.Rows[irows - 1].Cells[9].FindControl("DDLCurrency");
                TextBox txt_Exchange_Rate = (TextBox)grdVoucher.Rows[irows - 1].Cells[10].FindControl("txt_Exchange_Rate");
                TextBox txt_Transection_Memo = (TextBox)grdVoucher.Rows[irows - 1].Cells[11].FindControl("txt_Transection_Memo");

                dtCurrentTable.Rows[irows - 1]["Transection_Ledger"] = DDLTransection_Ledger.SelectedValue;
                dtCurrentTable.Rows[irows - 1]["Sub_Type"] = DDLSub_Type.SelectedValue;
                dtCurrentTable.Rows[irows - 1]["Sub_Ledger"] = DDLSub_Ledger.SelectedValue;

                dtCurrentTable.Rows[irows - 1]["Sub_Type1"] = DDLSub_Type1.SelectedValue;
                dtCurrentTable.Rows[irows - 1]["Sub_Ledger1"] = DDLSub_Ledger1.SelectedValue;
                dtCurrentTable.Rows[irows - 1]["Sub_Type2"] = DDLSub_Type2.SelectedValue;
                dtCurrentTable.Rows[irows - 1]["Sub_Ledger2"] = DDLSub_Ledger2.SelectedValue;

                dtCurrentTable.Rows[irows - 1]["Amount"] = txt_Amount.Text;
                dtCurrentTable.Rows[irows - 1]["Currency"] = DDLCurrency.SelectedValue;
                dtCurrentTable.Rows[irows - 1]["Exchange_Rate"] = txt_Exchange_Rate.Text;
                dtCurrentTable.Rows[irows - 1]["Transection_Memo"] = txt_Transection_Memo.Text;
                dtCurrentTable.Rows[irows - 1]["RowNumber"] = irows;
                /////////////////////////////////////////////////

                try
                {
                    if (AccVoucherTranID == 0)
                    {
                        cmd.Parameters.Add("@AccVoucherTranID", SqlDbType.Int).Value = Convert.ToInt64(AccVoucherTranID);// @AccVoucherTranID int,--0
                        cmd.Parameters.Add("@AccFundID", SqlDbType.Int).Value = Convert.ToInt64(headerinfo[0]);  //@AccFundID int,--3
                        cmd.Parameters.Add("@AccBranchCode", SqlDbType.Int).Value = DBNull.Value;  //@AccBranchCode int,--1 by def
                        cmd.Parameters.Add("@VchrTypeID", SqlDbType.Int).Value = Convert.ToInt64(headerinfo[1]); //@VchrTypeID int,--2
                        cmd.Parameters.Add("@PayDate", SqlDbType.DateTime).Value = EditedDate;

                        //Convert.ToDateTime(EditVoucher_Date.Text).ToString("mm/dd/yyyy hh:mm:ss tt");
                        cmd.Parameters.Add("@RefNo", SqlDbType.NVarChar).Value = headerinfo[7];  //@RefNo Nvarchar(50),--null
                        cmd.Parameters.Add("@PaidTo", SqlDbType.NVarChar).Value = headerinfo[6];  //@PaidTo Nvarchar(50),--

                        cmd.Parameters.Add("@HeadAcc", SqlDbType.Int).Value = Convert.ToInt64(dtCurrentTable.Rows[irows - 1]["Transection_Ledger"]); //@HeadAcc int,--Transec Ledger No
                        cmd.Parameters.Add("@RevAcc", SqlDbType.Int).Value = Convert.ToInt64(headerinfo[5]);  //@RevAcc int,--Cash Bank sours code
                        cmd.Parameters.Add("@AccSubTypeID", SqlDbType.Int).Value = Convert.ToInt64(dtCurrentTable.Rows[irows - 1]["Sub_Type"]); //@AccSubTypeID int,-- Sub type mo

                        int abc = Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Type"]);

                        if (abc == 1)
                        {
                            cmd.Parameters.Add("@AccSubCode", SqlDbType.Int).Value = 0;//@AccSubCode int,
                        }
                        else
                        {
                            cmd.Parameters.Add("@AccSubCode", SqlDbType.Int).Value = Convert.ToInt64(dtCurrentTable.Rows[irows - 1]["Sub_Ledger"]);//@AccSubCode int,
                        }
                        cmd.Parameters.Add("@AccSubTypeID1", SqlDbType.Int).Value = 0;//Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Type1"]);//@AccSubTypeID1 int,-- Sub type1 mo
                        cmd.Parameters.Add("@AccSubCode1", SqlDbType.Int).Value = 0;//Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Ledger1"]); //@AccSubCode1 int,
                        cmd.Parameters.Add("@AccSubTypeID2", SqlDbType.Int).Value = 0;//Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Type2"]);  //@AccSubTypeID2 int,-- Sub type2 mo
                        cmd.Parameters.Add("@AccSubCode2", SqlDbType.Int).Value = 0;// Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Ledger2"]);  //@AccSubCode2 int,

                        if (headerinfo[8] == "CP" || headerinfo[8] == "BP")// Cash or Bank Payment
                        {
                            cmd.Parameters.Add("@DebitAmt", SqlDbType.Money).Value = dtCurrentTable.Rows[irows - 1]["Amount"];//@DebitAmt Money,--
                            cmd.Parameters.Add("@CreditAmt", SqlDbType.Money).Value = 0;
                            a = Convert.ToDouble(dtCurrentTable.Rows[irows - 1]["Amount"]);
                            Result = (a + Result);
                            
                        }
                        cmd.Parameters.Add("@DepartmentsID", SqlDbType.Int).Value = 0;   //@DepartmentsID int,-- Null
                        cmd.Parameters.Add("@AccRemarks", SqlDbType.NVarChar).Value = headerinfo[3]; //@AccRemarks Nvarchar(500),--memo
                        if (headerinfo[8] == "CP" || headerinfo[8] == "BP")// Cash or Bank Payment
                        {
                           
                            cmd.Parameters.Add("@IsRevtran", SqlDbType.Int).Value = 0;      //@IsRevtran int,--0
                        }
                        
                       
                      
                        
                        cmd.Parameters.Add("@IsPosted", SqlDbType.Int).Value = 0;  //@IsPosted int,--0
                       
                            /////
                            cmd.Parameters.Add("@Chequeno", SqlDbType.NVarChar).Value = DBNull.Value;                            // @Chequeno Nvarchar(50),
                            cmd.Parameters.Add("@ChequeDT", SqlDbType.DateTime).Value = DBNull.Value; //headerinfo[4];       //	@ChequeDT Datetime,
                            cmd.Parameters.Add("@ChequeBankBranch", SqlDbType.NVarChar).Value = DBNull.Value; //             //@ChequeBankBranch Nvarchar(50),
                            ////// 
                            cmd.Parameters.Add("@TranComments", SqlDbType.NVarChar).Value = dtCurrentTable.Rows[irows - 1]["Transection_Memo"]; // dtCurrentTable.Rows[irows - 1]["Transection_Memo"]
                       


                        cmd.Parameters.Add("@AccVoucherTranIDRef", SqlDbType.Int).Value = 0;
                        cmd.Parameters["@AccVoucherTranIDRef"].Direction = ParameterDirection.Output;

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "VoucherCreateUpdateSingleAccounts";// "VoucherCreateUpdateSingle";
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
                        cmd.Parameters.Add("@PayDate", SqlDbType.DateTime).Value = EditedDate;

                        //Convert.ToDateTime(EditVoucher_Date.Text).ToString("mm/dd/yyyy hh:mm:ss tt");
                        cmd.Parameters.Add("@RefNo", SqlDbType.NVarChar).Value = headerinfo[7];  //@RefNo Nvarchar(50),--null
                        cmd.Parameters.Add("@PaidTo", SqlDbType.NVarChar).Value = headerinfo[6];  //@PaidTo Nvarchar(50),--

                        cmd.Parameters.Add("@HeadAcc", SqlDbType.Int).Value = Convert.ToInt64(dtCurrentTable.Rows[irows - 1]["Transection_Ledger"]); //@HeadAcc int,--Transec Ledger No
                        cmd.Parameters.Add("@RevAcc", SqlDbType.Int).Value = Convert.ToInt64(headerinfo[5]);  //@RevAcc int,--Cash Bank sours code
                        cmd.Parameters.Add("@AccSubTypeID", SqlDbType.Int).Value = Convert.ToInt64(dtCurrentTable.Rows[irows - 1]["Sub_Type"]); //@AccSubTypeID int,-- Sub type mo

                        int abc = Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Type"]);

                        if (abc == 1)
                        {
                            cmd.Parameters.Add("@AccSubCode", SqlDbType.Int).Value = 0;//@AccSubCode int,
                        }
                        else
                        {
                            cmd.Parameters.Add("@AccSubCode", SqlDbType.Int).Value = Convert.ToInt64(dtCurrentTable.Rows[irows - 1]["Sub_Ledger"]);//@AccSubCode int,
                        }
                        cmd.Parameters.Add("@AccSubTypeID1", SqlDbType.Int).Value = 0;//Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Type1"]);//@AccSubTypeID1 int,-- Sub type1 mo
                        cmd.Parameters.Add("@AccSubCode1", SqlDbType.Int).Value = 0;//Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Ledger1"]); //@AccSubCode1 int,
                        cmd.Parameters.Add("@AccSubTypeID2", SqlDbType.Int).Value = 0;//Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Type2"]);  //@AccSubTypeID2 int,-- Sub type2 mo
                        cmd.Parameters.Add("@AccSubCode2", SqlDbType.Int).Value = 0;// Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Ledger2"]);  //@AccSubCode2 int,

                        if (headerinfo[8] == "CP" || headerinfo[8] == "BP")// Cash or Bank Payment
                        {
                            cmd.Parameters.Add("@DebitAmt", SqlDbType.Money).Value = dtCurrentTable.Rows[irows - 1]["Amount"];//@DebitAmt Money,--
                            cmd.Parameters.Add("@CreditAmt", SqlDbType.Money).Value = 0;
                            a = Convert.ToDouble(dtCurrentTable.Rows[irows - 1]["Amount"]);
                            Result = (a + Result);

                        }
                        cmd.Parameters.Add("@DepartmentsID", SqlDbType.Int).Value = 0;   //@DepartmentsID int,-- Null
                        cmd.Parameters.Add("@AccRemarks", SqlDbType.NVarChar).Value = headerinfo[3]; //@AccRemarks Nvarchar(500),--memo
                        if (headerinfo[8] == "CP" || headerinfo[8] == "BP")// Cash or Bank Payment
                        {

                            cmd.Parameters.Add("@IsRevtran", SqlDbType.Int).Value = 0;      //@IsRevtran int,--0
                        }




                        cmd.Parameters.Add("@IsPosted", SqlDbType.Int).Value = 0;  //@IsPosted int,--0

                        /////
                        cmd.Parameters.Add("@Chequeno", SqlDbType.NVarChar).Value = DBNull.Value;                            // @Chequeno Nvarchar(50),
                        cmd.Parameters.Add("@ChequeDT", SqlDbType.DateTime).Value = DBNull.Value; //headerinfo[4];       //	@ChequeDT Datetime,
                        cmd.Parameters.Add("@ChequeBankBranch", SqlDbType.NVarChar).Value = DBNull.Value; //             //@ChequeBankBranch Nvarchar(50),
                        ////// 
                        cmd.Parameters.Add("@TranComments", SqlDbType.NVarChar).Value = dtCurrentTable.Rows[irows - 1]["Transection_Memo"]; // dtCurrentTable.Rows[irows - 1]["Transection_Memo"]



                        cmd.Parameters.Add("@AccVoucherTranIDRef", SqlDbType.Int).Value = 0;
                        cmd.Parameters["@AccVoucherTranIDRef"].Direction = ParameterDirection.Output;
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "VoucherCreateUpdateSingleAccounts";// "VoucherCreateUpdateSingle";
                        cmd.Transaction = Transection;
                        cmd.ExecuteNonQuery();
                        //AccVoucherTranID = (int)cmd.Parameters["@AccVoucherTranIDRef"].Value;
                    }
       
                    #region Last Transection Debit or credit Row save
                    int LastRow = grdVoucher.Rows.Count;
                    if (irows == LastRow)
                    {
                        cmd = new SqlCommand();
                        //exec VoucherCreateUpdateSingle 0,3,null,2,'5/1/2015','ref','paid to Dipu',373, 164,  10,  1159, 0,0,0,0 ,777,0,0,   'HASAN MEHEDI',0,0,@AccVoucherTranIDRef Outpu
                        cmd.Parameters.Add("@AccVoucherTranID", SqlDbType.Int).Value = AccVoucherTranID;// @AccVoucherTranID int,--0
                        cmd.Parameters.Add("@AccFundID", SqlDbType.Int).Value = Convert.ToInt64(headerinfo[0]);  //@AccFundID int,--3
                        cmd.Parameters.Add("@AccBranchCode", SqlDbType.Int).Value = DBNull.Value;  //@AccBranchCode int,--1 by def
                        cmd.Parameters.Add("@VchrTypeID", SqlDbType.Int).Value = Convert.ToInt64(headerinfo[1]); //@VchrTypeID int,--2
                        cmd.Parameters.Add("@PayDate", SqlDbType.DateTime).Value = EditedDate;// Convert.ToDateTime(headerinfo[4]).ToString("MM/dd/yyyy hh:mm:ss tt");//PayDate

                        cmd.Parameters.Add("@RefNo", SqlDbType.NVarChar).Value = headerinfo[7];  //@RefNo Nvarchar(50),--null
                        cmd.Parameters.Add("@PaidTo", SqlDbType.NVarChar).Value = headerinfo[6];  //@PaidTo Nvarchar(50),--

                        cmd.Parameters.Add("@HeadAcc", SqlDbType.Int).Value = Convert.ToInt64(headerinfo[5]); //@HeadAcc int,--Transec Ledger No
                        cmd.Parameters.Add("@RevAcc", SqlDbType.Int).Value = Convert.ToInt64(dtCurrentTable.Rows[LastRow - 1]["Transection_Ledger"]);  //@RevAcc int,--Cash Bank sours code
                        
                        cmd.Parameters.Add("@AccSubTypeID", SqlDbType.Int).Value = 1;// Convert.ToInt64(dtCurrentTable.Rows[LastRow - 1]["Sub_Type"]);   @AccSubTypeID int,-- Sub type mo
                       

                        int SubType = Convert.ToInt32(dtCurrentTable.Rows[LastRow - 1]["Sub_Type"]);
                        if (SubType == 1)
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
                        cmd.Parameters.Add("@AccSubTypeID1", SqlDbType.Int).Value = 0;//Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Type1"]);//@AccSubTypeID1 int,-- Sub type1 mo
                        cmd.Parameters.Add("@AccSubCode1", SqlDbType.Int).Value = 0;//Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Ledger1"]); //@AccSubCode1 int,
                        cmd.Parameters.Add("@AccSubTypeID2", SqlDbType.Int).Value = 0;//Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Type2"]);  //@AccSubTypeID2 int,-- Sub type2 mo
                        cmd.Parameters.Add("@AccSubCode2", SqlDbType.Int).Value = 0;// Convert.ToInt32(dtCurrentTable.Rows[irows - 1]["Sub_Ledger2"]);  //@AccSubCode2 int,

                        if (headerinfo[8] == "CP" || headerinfo[8] == "BP") //cash/ bank
                        {
                            cmd.Parameters.Add("@DebitAmt", SqlDbType.Money).Value = 0;//@DebitAmt Money,--
                            cmd.Parameters.Add("@CreditAmt", SqlDbType.Money).Value = Result;//dtCurrentTable.Rows[LastRow]["Amount"];//CreditAmt
                                 //@IsRevtran int,--0
                        }
                        
                        cmd.Parameters.Add("@DepartmentsID", SqlDbType.Int).Value = 0;   //@DepartmentsID int,-- Null
                        cmd.Parameters.Add("@AccRemarks", SqlDbType.NVarChar).Value = headerinfo[3]; //@AccRemarks Nvarchar(500),--memo
                        if (headerinfo[8] == "CP" || headerinfo[8] == "BP") //cash/ bank
                        {
                            
                            cmd.Parameters.Add("@IsRevtran", SqlDbType.Int).Value = 1;      //@IsRevtran int,--0
                        }
                        cmd.Parameters.Add("@IsPosted", SqlDbType.Int).Value = 0;  //@IsPosted int,--0

                       
                            cmd.Parameters.Add("@Chequeno", SqlDbType.NVarChar).Value = DBNull.Value;                            // @Chequeno Nvarchar(50),
                            cmd.Parameters.Add("@ChequeDT", SqlDbType.DateTime).Value = DBNull.Value; //headerinfo[4];       //	@ChequeDT Datetime,
                            cmd.Parameters.Add("@ChequeBankBranch", SqlDbType.NVarChar).Value = DBNull.Value; //             //@ChequeBankBranch Nvarchar(50),
                            cmd.Parameters.Add("@TranComments", SqlDbType.NVarChar).Value = dtCurrentTable.Rows[irows - 1]["Transection_Memo"];
                        cmd.Parameters.Add("@AccVoucherTranIDRef", SqlDbType.Int).Value = 0;
                        cmd.Parameters["@AccVoucherTranIDRef"].Direction = ParameterDirection.Output;

                        cmd.Transaction = Transection;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "VoucherCreateUpdateSingleAccounts";
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();

                        SaveNprintAccVoucherTranID = AccVoucherTranID;

                        Transection.Commit();
                        lblMsg.Text = "";
                        lblMsg.Text = "Transaction Complete\n";
                        con.Close();

                    #endregion
                    }
                    else
                    {

                    }
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    Transection.Rollback();
                    lblMsg.Text = "";
                    lblMsg.Text = "Error - TRANSACTION ROLLED BACK\n" + ex.Message;

                }



            }
            clear();
           

            lblMsg.Text = " Save Successfully ";
            lblMsg.Visible = true;
            #endregion
        }
        else
        {
            lblMsg.Text = "";
            
            PopUp();
            clear();
        }
    }
    public void PopUp()
    {
        ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), Guid.NewGuid().ToString(), "alert('" + lblMsg.Text + "');", true);
    }
    protected void clear()
    {
        dtCurrentTable = null;
        ddlBankLedger.SelectedIndex = 0;
        grdVoucher.Visible = false;
        
        btn_save.Text = "Save";
        //Total_Amount.Visible = false;
        //Sum_amount.Visible = false;
        Total_Sum = 0;
      

    }
    protected void Cancel_Voucher(object sender, EventArgs e)
    {
        Response.Redirect("~/Pages/BankReconciliation.aspx");
    }
}
