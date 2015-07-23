using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class Pages_PrintCheque1 : MyCompany.Web.PageBase
{
    
    public string CssClass
    {
        get
        {
            return "";
        }
    }
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int AccFundID = 0;
            int VchrTypeID = 0;
            decimal RevAcc = 0;
            string VchrNo = string.Empty;
            string ChequeDT = string.Empty;
            if (Request.QueryString["AccFundID"] != null)
                AccFundID = int.Parse(Request.QueryString["AccFundID"].ToString());
            if (Request.QueryString["VchrTypeID"] != null)
                VchrTypeID =Convert.ToInt32( Request.QueryString["VchrTypeID"].ToString());
            if (Request.QueryString["RevAcc"] != null)
                RevAcc = Convert.ToDecimal(Request.QueryString["RevAcc"].ToString());
            if (Request.QueryString["VchrNo"] != null)
                VchrNo =Request.QueryString["VchrNo"].ToString();
            //if (Request.QueryString["ChequeDT"] != null)
            //    ChequeDT = Request.QueryString["ChequeDT"].ToString();

            HiddenField hdAccFundID = (HiddenField)control1.FindControl("AccFundID");
            hdAccFundID.Value = AccFundID.ToString();

            HiddenField hdVchrTypeID = (HiddenField)control1.FindControl("VchrTypeID");
            hdVchrTypeID.Value = VchrTypeID.ToString();

            HiddenField hdRevAcc = (HiddenField)control1.FindControl("RevAcc");
            hdRevAcc.Value = RevAcc.ToString();
            HiddenField hdVchrNo = (HiddenField)control1.FindControl("VchrNo");
            hdVchrNo.Value = VchrNo.ToString();

            //HiddenField hdChequeDT = (HiddenField)control1.FindControl("ChequeDT");
            //hdChequeDT.Value = ChequeDT;

        }
    }
}
