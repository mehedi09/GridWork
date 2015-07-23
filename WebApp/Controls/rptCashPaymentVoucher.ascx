<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="rptCashPaymentVoucher.ascx.cs" Inherits="Controls_rptCashPaymentVoucher" %>
<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<!-- 
    This section provides a sample markup for Desktop user inteface.
-->
<script type="text/javascript">
    $(function () {
        $("#<%= Voucher_Date.ClientID %>").datepicker({
            changeMonth: true,
            changeYear: true,
        });
    });
    var prm = Sys.WebForms.PageRequestManager.getInstance();

    prm.add_endRequest(function () {
        $("#<%= Voucher_Date.ClientID %>").datepicker({
            changeMonth: true,
            changeYear: true
        });

    });


</script>
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
       <ContentTemplate>
        <div class="ParaInfo">
            Report || Cash Payment Voucher Report. 
            <br class="Apple-interchange-newline" />
        </div>
        <div class="ParaHeader">
            &nbsp;Cash Payment Voucher Report
        </div>
        <div id="report_form">
            <table style="width: 100%">
                <tr>
                    <td valign="top">
                        <table>
                            <tr class="FieldWrapper">
                                <td class="Header" valign="top">Company Name:
                                </td>
                                <td class="auto-style1">
                                    <div class="FieldPlaceholder DataOnly">
                                        <asp:DropDownList ID="DDLCompany_Name" runat="server" Style="width: 150px" OnSelectedIndexChanged="DDLCompany_Name_SelectedIndexChanged" AutoPostBack="true">
                                        </asp:DropDownList>

                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2"></td>
                            </tr>

                            <tr runat="server" id="tr_voucherType_find">
                                <td class="Header" valign="top">Voucher Type :
                                </td>
                                <td class="auto-style1">
                                    <div class="FieldPlaceholder DataOnly">
                                        <asp:DropDownList ID="DDLVoucherType" runat="server" Style="width: 150px" AutoPostBack="true" OnSelectedIndexChanged="DDLVoucherType_SelectedIndexChanged">
                                        </asp:DropDownList>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2"></td>
                            </tr>
                            <tr>
                                <td class="Header" valign="top">Cash Bank Source:
                                </td>
                                <td class="Header" valign="top">
                                    <asp:DropDownList ID="DDLCashBankSource" runat="server" Style="width: 150px" AutoPostBack="true" OnSelectedIndexChanged="DDLCashBankSource_SelectedIndexChanged"></asp:DropDownList>
                                </td>
                            </tr>

                            <tr>
                                <td colspan="2"></td>
                            </tr>

                            <tr runat="server" id="tr2">
                                <td class="Header" valign="top">Voucher No:
                                </td>
                                <td class="auto-style1">
                                    <div class="FieldPlaceholder DataOnly">
                                        <asp:DropDownList ID="DDLVoucherNo" runat="server" Style="width: 150px">
                                        </asp:DropDownList>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2"></td>
                            </tr>
                            <tr runat="server" ID="date_time">
                                <td class="Header" valign="top">Date:
                                </td>
                                <td class="Header" valign="top">
                                    <asp:TextBox runat="server" ID="Voucher_Date" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2"><asp:Label runat="server" ID="lblMsg" Visible="false"></asp:Label></td>
                            </tr>




                        </table>
                    </td>

                </tr>
            </table>
        </div>
        <div class="ParaHeader" align="center">
            <asp:Button ID="btn_Show_Report" runat="server" Text="Show Report" CssClass="btn" OnClick="Show_Report"
                Height="23px" Width="87px" />
            <%--<button onclick="myFunction()">Click me</button>--%>
        </div>

        <div id="BankPaymentVoucher_Report">
            <table style="width: 100%">
                <tr>
                    <td valign="top">
                        <div style="align-content: center">
                            <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" SizeToReportContent="True" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt">
                                <LocalReport>
                                    <DataSources>
                                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSet1" />
                                    </DataSources>
                                </LocalReport>
                            </rsweb:ReportViewer>
                        </div>

                    </td>
                </tr>
            </table>

        </div>

    </ContentTemplate>
    </ContentTemplate>
</asp:UpdatePanel>
<!-- 
    This section provides a sample markup for Touch UI user interface. 
-->
<div id="rptCashPaymentVoucher" data-app-role="page" data-activator="Button|rptCashPaymentVoucher">
    <p>
        Markup of <i>rptCashPaymentVoucher</i> custom user control for Touch UI.
    </p>
</div>

<script type="text/javascript">
    (function () {
        if ($app.touch)
            $(document).one('start.app', function () {
                // The page of Touch UI application is ready to be configured
            });
    })();
</script>
