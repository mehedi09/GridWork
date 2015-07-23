<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ImprestFundReimbursmentBill.ascx.cs" Inherits="Controls_ImprestFundReimbursmentBill" %>
<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>


<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
</style>


<script type="text/javascript">
    $(function () {
        $("#<%= txtFrDate.ClientID %>").datepicker({
            changeMonth: true,
            changeYear: true
        });

      $("#<%= txtToDate.ClientID %>").datepicker({
            changeMonth: true,
            changeYear: true
        });
    });
    var prm = Sys.WebForms.PageRequestManager.getInstance();

    prm.add_endRequest(function () {
        $("#<%= txtFrDate.ClientID %>").datepicker({
            changeMonth: true,
            changeYear: true
        });

        $("#<%= txtToDate.ClientID %>").datepicker({
            changeMonth: true,
            changeYear: true
        });
    });
</script>
<asp:UpdatePanel ID="UpdatePanel2" runat="server">
    <ContentTemplate>

         <div style ="border:1px solid #cccccc;width:450px;padding-left:5px;">               

                <div style="float: left; position: relative;  top: 0px; left: 0px;" class="auto-style1">
                    <asp:Label ID="lblmsg" runat="server" ForeColor="#CC3300"></asp:Label>
                </div>

                     <div style="clear: both; height: 10px;"></div>

                <div style="float: left; position: relative; width: 100px; top: 0px; left: 0px; height: 18px;" class="auto-style1">
                   Imprest Fund
                </div>
                <div style="float: left; position: relative; padding-left: 10px;">
                     <asp:DropDownList ID="ddlImprestFund" runat="server" Width="220px">
                        </asp:DropDownList>                   
                </div>

              
                  
                  <div style="clear: both; height: 10px;"></div>
            <div style="float: left; position: relative; width: 100px;" class="auto-style1">From Date </div>
            <div style="float: left; position: relative; padding-left: 10px;">
                 <asp:TextBox ID="txtFrDate" runat="server"></asp:TextBox>

            </div>

                    <div style="clear: both; height: 10px;"></div>
            <div style="float: left; position: relative; width: 100px;" class="auto-style1">To Date</div>
            <div style="float: left; position: relative; padding-left: 10px;">
             
                 <asp:TextBox ID="txtToDate" runat="server"></asp:TextBox>

            </div>

              <div style="clear: both; height: 10px;"></div>

             
              <div style="float: left; position: relative; width: 100px;" class="auto-style1"></div>
            <div style="float: left; position: relative; padding-left: 110px;">
           
                 <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Show Report" />
            </div>

               <div style="clear: both; height: 10px;"></div>







         </div>


<table class="auto-style1">
    <tr>
        <td style="width:50%">
          
        </td>
        <td style="width:50%">&nbsp;</td>
    </tr>
    <tr>
       <td style="width:50%;padding-left:20%">
          
        </td>
        <td style="width:50%">&nbsp;</td>
    </tr>
      <tr>
       <td colspan="2">
           <%--<asp:LinkButton ID="return_BalancheRptForm" runat="server" CssClass="btn btn-info" OnClick="return_BalancheRptForm_Click" Style="margin-left:40%">
                <i class="icon-ok icon-white"></i>Return Cash Book
            </asp:LinkButton>--%>
        </td>
    </tr>
    <tr>
       <td colspan="2"style="vertical-align:top">
           <rsweb:ReportViewer ID="ReportViewer1" runat="server" SizeToReportContent="True">
           </rsweb:ReportViewer>
        </td>

        </tr><tr>











           <td >
                  <%--<embed runat="server" id="report" style="width:100%;" height="550" name="whatever" type='application/pdf'/>--%>
                    </td>
    </tr>
</table>

    </ContentTemplate>
</asp:UpdatePanel>


<script type="text/javascript">
    (function () {
        if ($app.touch)
            $(document).one('start.app', function () {
                // The page of Touch UI application is ready to be configured
            });
    })();
</script>
