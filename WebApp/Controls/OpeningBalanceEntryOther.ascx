<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="OpeningBalanceEntryOther.ascx.cs" Inherits="Controls_OpeningBalanceEntryOther" %>
<script type="text/javascript">
    $(function () {
        $("#<%= txtdate.ClientID %>").datepicker({
            dateFormat: 'mm/dd/yy',
            changeMonth: true,
            changeYear: true
        });

    });
    var prm = Sys.WebForms.PageRequestManager.getInstance();

    prm.add_endRequest(function () {
        $("#<%= txtdate.ClientID %>").datepicker({
            dateFormat: 'mm/dd/yy',
            changeMonth: true,
            changeYear: true
        });

    });

</script>

<style type="text/css">
    .auto-style1 {
        width: 100%;
    }
</style>

<asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
    <ContentTemplate>

        <table class="auto-style1">
            <tr>
                <td style="background-color: #4df78f">
                    <asp:Label ID="lblmsg" runat="server" Font-Bold="True" ForeColor="#990000"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="background-color: #4df78f; font-size: 18px; color: black; font-weight: bold; text-align: center">Opening Balance Entry</td>
            </tr>
            <tr>
                <td>
                    <table class="auto-style1">
                        <tr>
                            <td style="border: 1px solid #cccccc; width: 60%">
                                <table class="auto-style1">
                                    <tr>
                                        <td style="width: 25%">Sub Ledger </td>
                                        <td style="width: 30%">
                                            <asp:DropDownList ID="ddlAccSubTypeID" runat="server" Width="160px" AutoPostBack="True" OnSelectedIndexChanged="ddlAccSubTypeID_SelectedIndexChanged">
                                            </asp:DropDownList>
                                        </td>
                                        <td style="width: 15%">Date</td>
                                        <td style="width: 25%">
                                            <asp:TextBox ID="txtdate" runat="server"></asp:TextBox>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td style="width: 40%"></td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td style="text-align: left">

                    <asp:Button ID="Button2" runat="server" Text="Balance Update" OnClick="Button2_Click" />

                </td>
            </tr>
            <tr>
                <td>
                    <asp:GridView ID="GVOpeningLedger" runat="server" AlternatingRowStyle-BackColor="White" AlternatingRowStyle-ForeColor="Black" AutoGenerateColumns="False" CellPadding="1" CellSpacing="2" EmptyDataText="No data in the data source.!" HeaderStyle-BackColor="#B8DD68" HeaderStyle-ForeColor="Black" PageSize="12" RowStyle-BackColor="#B8DD68" ShowFooter="True" Width="100%">
                        <AlternatingRowStyle BackColor="White" ForeColor="Black"></AlternatingRowStyle>
                        <Columns>
                            <asp:TemplateField>
                                <HeaderTemplate>
                                    <asp:CheckBox ID="ckHeader" runat="server" OnCheckedChanged="ckHeader_CheckedChanged" AutoPostBack="True" />
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <asp:CheckBox ID="CkCoaDetails" runat="server" />
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:TemplateField>
                            <asp:BoundField DataField="CoaDetailID" HeaderText="LedgerID" ItemStyle-Width="10%"></asp:BoundField>
                            <asp:BoundField DataField="AccName" HeaderText="Ledger Name"></asp:BoundField>
                            <asp:TemplateField HeaderText="Debit">
                                <ItemTemplate>
                                    <asp:TextBox ID="txtOpenDebit" runat="server" Text='<%# Bind("OpenDebit") %>'></asp:TextBox>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Credit">
                                <ItemTemplate>
                                    <asp:TextBox ID="txtOpenCredit" runat="server" Text='<%# Bind("OpenCredit") %>'></asp:TextBox>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:TemplateField>
                        </Columns>
                        <HeaderStyle BackColor="#F3E2A9" BorderColor="Gray" />
                        <RowStyle BackColor="#B8DD68"></RowStyle>
                    </asp:GridView>
                </td>
            </tr>
        </table>

    </ContentTemplate>
</asp:UpdatePanel>


