<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BalanceSheet.ascx.cs" Inherits="Controls_BalanceSheet" %>
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
</script>
<!-- 
    This section provides a sample markup for Desktop user inteface.
-->
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <div style="margin: 2px; border: solid 1px silver; padding: 8px;">
         <div> <asp:Label ID="Label1" runat="server" Text="" ForeColor="Red"></asp:Label></div>   
             <div style="clear: both; height: 10px;"></div>
            <div style="float: left; position: relative; width: 125px;" class="auto-style1"><strong>Company </strong></div>
            <div style="float: left; position: relative; padding-left: 10px;">
                <asp:DropDownList ID="ddlcompany" runat="server" Width="200px"  >
                  
                </asp:DropDownList>
            </div>       
      
          
            <div style="clear: both; height: 10px;"></div>
            <div style="float: left; position: relative; width: 125px;" class="auto-style1"><strong>Start_Date</strong></div>
            <div style="float: left; position: relative; padding-left: 10px;">
              <%--  <asp:DropDownList ID="cmdemployeeid" runat="server" Width="200px"  AutoPostBack="True"></asp:DropDownList>--%>
                <asp:TextBox ID="txtfrmDate" runat="server" Width="200px"></asp:TextBox>

            </div>

              <div style="clear: both; height: 10px;"></div>
            <div style="float: left; position: relative; width: 125px;" class="auto-style1"><strong>End_Date</strong></div>
            <div style="float: left; position: relative; padding-left: 10px;">
               <%-- <asp:DropDownList ID="DropDownList1" runat="server" Width="200px"  AutoPostBack="True"></asp:DropDownList>--%>
                   <asp:TextBox ID="txtTodate" runat="server" Width="200px"></asp:TextBox>
            </div>

             

      



            <div style="clear: both; height: 10px;"></div>
            <div style="float: left; position: relative; width: 240px;">
                <asp:Button ID="Button1" runat="server" Text="Show Report" OnClick="Button1_Click" />
            </div>

        <div>
          
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

                        <embed runat="server" id="report" width="100%" height="550" name="whatever" type='application/pdf'></embed>
                    </td>
                </tr>
            </table>
            
        </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>

