﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ReceiptPayment.ascx.cs" Inherits="Controls_ReceiptPayment" %>
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
        <div style="margin: 2px; padding: 8px;">
            <div id="PagesHeader" runat="server">
                <div>
                    <asp:Label ID="lblerror" runat="server" Text="" ForeColor="Red"></asp:Label>
                </div>
                <div style="border: 1px solid #cccccc; width: 350px; padding-left: 5px;">
                    <div style="clear: both; height: 10px;"></div>


                    <div style="float: left; position: relative; width: 125px;" class="auto-style1">From Date </div>
                    <div style="float: left; position: relative; padding-left: 10px;">

                        <asp:TextBox ID="txtFrmDate" Width="100px" runat="server"></asp:TextBox>
                    </div>                    
                    <div style="clear: both; height: 10px;"></div>

                    <div style="clear: both; height: 10px;"></div>
                    <div style="float: left; position: relative; width: 125px;" class="auto-style1">To Date </div>
                    <div style="float: left; position: relative;padding-left: 10px;">

                        <asp:TextBox ID="txtTodate" Width="100px" runat="server"></asp:TextBox>
                    </div>                    
                    <div style="clear: both; height: 10px;"></div>                 
                    <div style="float: left; position: relative; width: 90px;" class="auto-style1"><strong></strong></div>
                    <div style="float: left; position: relative; padding-left: 130px;">
                        <asp:Button ID="Button1" runat="server" Text="Show Report" OnClick="Button1_Click" />
                    </div>
                    <div style="clear: both; height: 10px;"></div>
                </div>
            </div>
            <div class="ParaHeader" id="rptHeader" runat="server">
                <asp:LinkButton ID="return_BalancheRptForm" runat="server" CssClass="btn btn-info" Style="margin-left: 40%" OnClick="return_BalancheRptForm_Click1">
                <i class="icon-ok icon-white"></i>Return Receipt & Payment

                </asp:LinkButton>
            </div>
            <div id="ReportForm" runat="server">

                <table style="width: 100%; height: 406px;">
                    <tr>
                        <td style="vertical-align: top;">
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
                            <embed runat="server" id="report" style="width: 100%;" height="550" name="whatever" type='application/pdf' />
                        </td>
                    </tr>
                </table>

            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
<!-- 
    This section provides a sample markup for Touch UI user interface. 
-->
<%--<div id="ReceiptPayment" data-app-role="page" data-activator="Button|ReceiptPayment">
    <p>
        Markup of <i>ReceiptPayment</i> custom user control for Touch UI.
    </p>
</div>--%>

