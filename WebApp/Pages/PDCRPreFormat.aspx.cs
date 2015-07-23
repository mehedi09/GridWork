using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class Pages_PDCRPreFormat : MyCompany.Web.PageBase
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
            //string applicant = string.Empty;
            //bool type = false;
            if (Request.QueryString["PDCRID"] != null)
                id = int.Parse(Request.QueryString["PDCRID"].ToString());
            //if (Request.QueryString["allotmentNo"] != null)
            //    applicant = Request.QueryString["allotmentNo"].ToString();
            //if (Request.QueryString["PDCType"] != null)
            //    type = Convert.ToBoolean(Request.QueryString["PDCType"].ToString());

            //control1. objTestControl = (Controls_moneyreceiptview2)Page.FindControl("control1");
            //HiddenField hdType = (HiddenField)control1.FindControl("hdType");
            //hdType.Value = type.ToString();

            //HiddenField hdapplicant = (HiddenField)control1.FindControl("hdapplicant");
            //hdapplicant.Value = applicant;

            HiddenField hdmoney = (HiddenField)control1.FindControl("hdmoney");
            hdmoney.Value = id.ToString();

        }
    }
}
