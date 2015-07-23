﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="balancesheet1.ascx.cs" Inherits="Controls_balancesheet1" %>
<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<script src="http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.7.js" type="text/javascript"></script>

<script src="http://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.16/jquery-ui.js" type="text/javascript"></script>

<link href="http://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.16/themes/humanity/jquery-ui.css" rel="stylesheet" type="text/css" />

<script type="text/javascript">
    $(function () {
        $("#<%= txtfrmDate.ClientID %>").datepicker({
            changeMonth: true,
            changeYear: true
        });

        $("#<%= txtTodate.ClientID %>").datepicker({
            changeMonth: true,
            changeYear: true
        });
    });
    var prm = Sys.WebForms.PageRequestManager.getInstance();

    prm.add_endRequest(function () {
        $("#<%= txtfrmDate.ClientID %>").datepicker({
            changeMonth: true,
            changeYear: true
        });

        $("#<%= txtTodate.ClientID %>").datepicker({
            changeMonth: true,
            changeYear: true
        });
    });

    function validate() {
   
        var txtFromDate = document.getElementById('<%=txtfrmDate.ClientID %>').value;
         var txtToDate = document.getElementById('<%=txtTodate.ClientID %>').value;
        if (ddlcompany == "Select") {
             alert("Pleace select a Company");
             return false;
         }

        if (txtfrmDate == "") {
             alert("Pleace a Date");
             return false;
         }
        if (txtTodate == "") {
             alert("Pleace a Date");
             return false;
         }

     }
</script>


<!-- 
    This section provides a sample markup for Desktop user inteface.
-->
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <div style="margin: 2px; padding: 8px;">
           <div id="PagesHeader" runat="server">
               <asp:Label ID="lblerror" ForeColor="Red" runat="server" Text=""></asp:Label>
            <%-- <div style="clear: both; height: 10px;"></div>
            <div style="float: left; position: relative; width: 125px;" class="auto-style1"><strong>Company Name</strong></div>
            <div style="float: left; position: relative; padding-left: 10px;">
                <asp:DropDownList ID="ddlcompany" runat="server" Width="200px"  >
                  
                </asp:DropDownList>
            </div> --%>      
      
          
            <div style="clear: both; height: 10px;"></div>
            <div style="float: left; position: relative; width: 125px;" class="auto-style1"><strong>From Date</strong></div>
            <div style="float: left; position: relative; padding-left: 10px;">
              <%--  <asp:DropDownList ID="cmdemployeeid" runat="server" Width="200px"  AutoPostBack="True"></asp:DropDownList>--%>
                <asp:TextBox ID="txtfrmDate" runat="server" Width="200px"></asp:TextBox>

            </div>

              <div style="clear: both; height: 10px;"></div>
            <div style="float: left; position: relative; width: 125px;" class="auto-style1"><strong>TO Date</strong></div>
            <div style="float: left; position: relative; padding-left: 10px;">
               <%-- <asp:DropDownList ID="DropDownList1" runat="server" Width="200px"  AutoPostBack="True"></asp:DropDownList>--%>
                   <asp:TextBox ID="txtTodate" runat="server" Width="200px"></asp:TextBox>
                
            </div>

                <div style="clear: both; height: 10px;"></div>
            <div style="float: left; position: relative; width: 125px;" class="auto-style1"><strong>Select Ledger Group</strong></div>
            <div style="float: left; position: relative; padding-left: 10px;">
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Text="Ist Group Ledger" Value="4" Selected="True"></asp:ListItem>
                     <asp:ListItem Text="2nd Group Ledger" Value="3"></asp:ListItem>
                     <asp:ListItem Text="3rd Group Ledger" Value="2"></asp:ListItem>
                     <asp:ListItem Text="G/L Accounts" Value="1"></asp:ListItem>
                </asp:RadioButtonList>
              

            </div>
                  <div style="clear: both; height: 10px;"></div>
                
                <div style="float:left;">
                       <asp:Button ID="Button1" runat="server" Width="345px" Text="Show Report" OnClientClick="return validate()" OnClick="Button1_Click"  />
                </div>
            <div style="clear: both; height: 10px;"></div>
            <div style="float: left; position: relative;">
             
            </div>
                </div>
           <div class="ParaHeader" id="rptHeader" runat="server">
             <asp:LinkButton ID="return_BalancheRptForm" runat="server" CssClass="btn btn-info" Style="margin-left:40%" OnClick="return_BalancheRptForm_Click">
                <i class="icon-ok icon-white"></i>Return Balance Sheet 
            </asp:LinkButton>
           </div>
           <div id="ReportForm" runat="server">

            <table style="width: 100%; height: 406px;">
                <tr>
                    <td style="vertical-align:top;">
                        <div style="align-content: center">
                            <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" SizeToReportContent="True" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" AsyncRendering="false" Visible="false">
                                <LocalReport>
                                    <DataSources>
                                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSet1" />
                                    </DataSources>
                                </LocalReport>
                            </rsweb:ReportViewer>
                        </div>

                    </td>
                    <td>
                  <embed runat="server" id="report" style="width:100%;" height="550" name="whatever" type='application/pdf'/>
                    </td>
                </tr>
            </table>
            
        </div>
        </div>
    
    </ContentTemplate>
</asp:UpdatePanel>

