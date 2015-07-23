<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ControlLedger.ascx.cs" Inherits="Controls_ControlLedger" %>
<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<script src="http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.7.js" type="text/javascript"></script>
    <script src="http://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.16/jquery-ui.js" type="text/javascript"></script>
    <link href="http://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.16/themes/humanity/jquery-ui.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
        $(function () {
            $("[id$=txtFrmDate]").datepicker({
                changeMonth: true,
                changeYear: true
            });

            $("[id$=txtTodate]").datepicker({
                changeMonth: true,
                changeYear: true
            });
        });


        var prm = Sys.WebForms.PageRequestManager.getInstance();

        prm.add_endRequest(function () {
            $("[id$=txtFrmDate]").datepicker({
                changeMonth: true,
                changeYear: true
            });

            $("[id$=txtTodate]").datepicker({
                changeMonth: true,
                changeYear: true
            });
        });
        </script>
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
<div style="margin: 2px; border: solid 1px silver; padding: 8px;">
     <div id="PagesHeader" runat="server">
             <div style="clear: both; height: 10px;"></div>

          
            
            
            <div style="clear: both; height: 10px;"></div>
            <div style="float: left; position: relative; width: 150px;" class="auto-style1"><strong>Control Ledger :</strong></div>
            <div style="float: left; position: relative; width: 200px; padding-left: 10px;">

                <asp:DropDownList ID="ddlAccCode" Width="200px" runat="server" AutoPostBack="True" ></asp:DropDownList> 
            </div>
            <div style="float: left; position: relative;">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="ddlAccCode" InitialValue="--Select Company Name--" ToolTip="Please Select Account code " ForeColor="Red">*</asp:RequiredFieldValidator>        
                     
            </div>
            
            <div style="clear: both; height: 10px;"></div>
            <div style="float: left; position: relative; width: 150px;" class="auto-style1"><strong>From Date :</strong></div>
            <div style="float: left; position: relative; width: 200px; padding-left: 10px;">

                <asp:TextBox ID="txtFrmDate" Width="195px" runat="server"></asp:TextBox>
            </div>
            <div style="float: left; position: relative;">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" ControlToValidate="txtFrmDate" ToolTip="Please Select From Date " ForeColor="Red">*</asp:RequiredFieldValidator>        
                     
            </div>
            <div style="clear: both; height: 10px;"></div>

            <div style="clear: both; height: 10px;"></div>
            <div style="float: left; position: relative; width: 150px;" class="auto-style1"><strong>To Date :</strong></div>
            <div style="float: left; position: relative; width: 200px; padding-left: 10px;">

                <asp:TextBox ID="txtTodate" Width="195px" runat="server"></asp:TextBox>
            </div>
            <div style="float: left; position: relative;">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*" ControlToValidate="txtTodate" ToolTip="Please Select To Date " ForeColor="Red">*</asp:RequiredFieldValidator>        
                     
            </div>
            <div style="clear: both; height: 10px;"></div>           

            <div style="float: left; position: relative; width: 3600px;">
                <asp:Button ID="Button1" runat="server" Width="360px" Text="Show Report" OnClick="Button1_Click" />
            </div>
         </div>
     <div class="ParaHeader" id="rptHeader" runat="server">
             <asp:LinkButton ID="return_BalancheRptForm" runat="server" CssClass="btn btn-info" Style="margin-left:40%" OnClick="return_BalancheRptForm_Click">
                <i class="icon-ok icon-white"></i>Return G/L Report
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
