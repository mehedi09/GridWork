using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class Pages_MoneyReceiptReportView : MyCompany.Web.PageBase
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
            int id = 0;
            string applicant = string.Empty;
            bool type = false;
            if (Request.QueryString["MoneyReceiptsID"] != null)
                id = int.Parse(Request.QueryString["MoneyReceiptsID"].ToString());
            if (Request.QueryString["AccSubNameID"] != null)
                applicant = Request.QueryString["AccSubNameID"].ToString();
            if (Request.QueryString["ReceiptType"] != null)
                type = Convert.ToBoolean(Request.QueryString["ReceiptType"].ToString());
           
            //control1. objTestControl = (Controls_moneyreceiptview2)Page.FindControl("control1");
            HiddenField hdType = (HiddenField)control1.FindControl("hdType");
            hdType.Value = type.ToString();

            HiddenField hdapplicant = (HiddenField)control1.FindControl("hdapplicant");
            hdapplicant.Value = applicant;

            HiddenField hdmoney = (HiddenField)control1.FindControl("hdmoney");
            hdmoney.Value = id.ToString();

        }
    }
}
