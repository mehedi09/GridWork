<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BillRegHeader.ascx.cs" Inherits="Controls_BillRegHeader" %>
<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<script type="text/javascript">
    $(function () {
        $("#<%= txtRegDate.ClientID %>").datepicker({
            changeMonth: true,
            changeYear: true
        });

      <%--  $("#<%= txttodate.ClientID %>").datepicker({
            changeMonth: true,
            changeYear: true
        });--%>
    });
    var prm = Sys.WebForms.PageRequestManager.getInstance();

    prm.add_endRequest(function () {
        $("#<%= txtRegDate.ClientID %>").datepicker({
            changeMonth: true,
            changeYear: true
        });

       <%-- $("#<%= txttodate.ClientID %>").datepicker({
            changeMonth: true,
            changeYear: true
        });--%>
    });
</script>


<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
</style>
<table class="auto-style1">
    <tr>
        <td>
            <table class="auto-style1">
                <tr>
                    <td style="width:40%;vertical-align:top">
                        <table class="auto-style1">
                             <tr>
                                <td colspan="2">
                                    <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
                                 </td>
                            </tr> 
                            <tr>
                                <td style="width:35%">Prefix Setting</td>
                                <td style="width:65%">
                                    <asp:DropDownList ID="ddlPrefix" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlPrefix_SelectedIndexChanged" Width="140px">
                                    </asp:DropDownList>
                                 </td>
                            </tr>
                            <tr>
                                <td style="width:35%">Register No.</td>
                                <td style="width:65%">
                                    <asp:TextBox ID="txtRegNo" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="width:35%">Register Date</td>
                                <td style="width:65%">
                                    <asp:TextBox ID="txtRegDate" runat="server"></asp:TextBox>
                                     
                                </td>
                            </tr>
                            <tr>
                                <td style="width:35%">Employee </td>
                                <td style="width:65%">
                                    <asp:DropDownList ID="ddlemployee" runat="server">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td style="width:35%">Account Voucher No.</td>
                                <td style="width:65%">
                                    <asp:Label ID="AccVoucherNo" runat="server"></asp:Label>
                                </td>
                            </tr>
                             <tr>
                                <td style="width:35%;vertical-align:top;text-align:left">Remarks</td>
                                <td style="width:65%">
                                    <asp:TextBox ID="txtRemarks" runat="server" TextMode="MultiLine" Width="220px"></asp:TextBox>
                                 </td>
                            </tr>   
                               <tr>
                                <td style="width:35%">Status</td>
                                <td style="width:65%">
                                    <asp:Label ID="Label1" runat="server"></asp:Label>
                                </td>
                            </tr>
                             <tr>
                                <td colspan="2">
                                    <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
                                    <asp:Button ID="Button2" runat="server" Text="Update" OnClick="Button2_Click" />
                                    <asp:Button ID="Button3" runat="server" Text="Details" />
                                    <asp:Button ID="Button4" runat="server" Text="Approve" />
                                 </td>
                            </tr>                       
                        </table>
                    </td>
                    <td style="width:60%;vertical-align:top">
                        <table class="auto-style1">
                            <tr>
                                <td style="text-align:center;background-color:green">Details Information</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="100%" CellPadding="4" ForeColor="#333333" GridLines="None">
                                        <AlternatingRowStyle BackColor="White" />
                                        <Columns>
                                            <asp:BoundField DataField="RegisterNo" HeaderText="Register No." />
                                            <asp:BoundField DataField="Row" HeaderText="Row" />
                                            <asp:BoundField DataField="Perpose" HeaderText="Perpose" />
                                            <asp:BoundField DataField="Amount" HeaderText="Amount" />
                                        </Columns>
                                        <EditRowStyle BackColor="#2461BF" />
                                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                        <RowStyle BackColor="#EFF3FB" />
                                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                                        <SortedDescendingHeaderStyle BackColor="#4870BE" />
                                    </asp:GridView>
                                </td>
                            </tr>
                            <tr>
                                <td style="text-align:center;background-color:green">Register Header</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" Width="100%" CellPadding="4" ForeColor="#333333" GridLines="None">
                                        <AlternatingRowStyle BackColor="White" />
                                        <Columns>
                                            <asp:TemplateField HeaderText="RegNo">
                                                <ItemTemplate>
                                                    <asp:Button ID="Button5" runat="server" CommandArgument='<%# Bind("RegID") %>' CommandName="_select" Text="Select" />
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:BoundField DataField="RegisterNo" HeaderText="Register No." />
                                            <asp:BoundField DataField="RegisterDate" HeaderText="Register Date" />
                                            <asp:BoundField DataField="BillEmployee" HeaderText="Employee" />
                                        </Columns>
                                        <EditRowStyle BackColor="#2461BF" />
                                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                        <RowStyle BackColor="#EFF3FB" />
                                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                                        <SortedDescendingHeaderStyle BackColor="#4870BE" />
                                    </asp:GridView>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
    </tr>
</table>

