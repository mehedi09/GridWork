using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;



public partial class Controls_Chart_AccTrnHeaderChart_VoucherByQuarter : System.Web.UI.UserControl
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    
    public override void DataBind()
    {
        base.DataBind();
        Chart1.DataManipulator.Group("Count, X:Center", 1, IntervalType.Days, "AccVoucherTranID");
    }
}
