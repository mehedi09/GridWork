<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ReverseVoucher.ascx.cs" Inherits="Controls_ReverseVoucher" %>
<!-- 
    This section provides a sample markup for Desktop user inteface.
-->
<link href="~/App_Themes/MyCompany/StyleSheet.css" rel="stylesheet" />
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <div class="ParaInfo">
            Reverse Voucher Form.
            <br class="Apple-interchange-newline" />
        </div>
        <div class="ParaHeader">

            <asp:Label runat="server" ID="CP_Header"></asp:Label>&nbsp;Reverse Voucher From 
            <b style="margin-left: 30%">
                <asp:Label runat="server" ID="lbl_SMsgg" ForeColor="Green"></asp:Label></b>
        </div>
        <div id="FromNSearch" runat="server">
            <div id="Find_Voucher_Form" runat="server">
                <div>
                    <table style="width: 100%">
                        <tr>
                            <td valign="top">
                                <table>
                                    <tr class="FieldWrapper" runat="server" visible="false">
                                        <td class="Header" valign="top">Company Name:
                                        </td>
                                        <td class="auto-style1">
                                            <div class="FieldPlaceholder DataOnly">
                                                <asp:DropDownList ID="DDLCompany_Name_Find" runat="server" Style="width: 210px">
                                                </asp:DropDownList>

                                                <%-- <asp:Label ID="lblCompany_Name" runat="server" Visible="false"></asp:Label>--%>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2"></td>
                                    </tr>

                                    <tr runat="server" id="tr_voucherType_find">
                                        <td class="Header" valign="top">Voucher Type :
                                        </td>
                                        <td class="auto-style1" runat="server">
                                            <div>
                                                <asp:DropDownList ID="DDLVoucherType_Find" runat="server" Style="width: 210px">
                                                </asp:DropDownList>
                                            </div>
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
                                                <asp:TextBox ID="txt_CVoucher_No_Find" runat="server" Style="width: 210px"></asp:TextBox>
                                            </div>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td colspan="2"></td>
                                    </tr>

                                    <tr>
                                        <td colspan="2">
                                            <asp:Label runat="server" ID="lblMsg" Visible="false"></asp:Label></td>
                                    </tr>

                                    <tr>
                                        <td colspan="2"></td>
                                    </tr>

                                </table>
                            </td>
                        </tr>
                    </table>
                </div>
                <div id="Find_GridView" runat="server">
                    <asp:GridView ID="GV_VoucherFind" Width="100%" runat="server" AllowPaging="true" PageSize="8"
                        CellPadding="1" CellSpacing="2" DataKeyNames="AccVoucherTranID"
                        ShowFooter="true" AutoGenerateColumns="false"
                       BorderColor="Transparent" CssClass="grid-view"
                        OnSelectedIndexChanged="GV_VoucherFind_SelectedIndexChanged"
                        OnPageIndexChanging="GV_VoucherFind_PageIndexChanging"
                        OnRowDataBound="GV_VoucherFind_RowDataBound">


                        <Columns>
                            <asp:BoundField DataField="AccVoucherTranID" HeaderText="ID" Visible="false" ItemStyle-Width="100%">
                                <ItemStyle Width="10%" HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="VchrNumber" HeaderText="Voucher Number" ItemStyle-Width="100%">
                                <ItemStyle Width="10%" HorizontalAlign="Center"/>
                            </asp:BoundField>
                            <asp:BoundField DataField="PaidTo" HeaderText="Paid To" ItemStyle-Width="100%">
                                <ItemStyle Width="10%" HorizontalAlign="Center"/>
                            </asp:BoundField>
                            <asp:BoundField DataField="AccRemarks" HeaderText="Remarks" ItemStyle-Width="100%">
                                <ItemStyle Width="20%" HorizontalAlign="Center"/>
                            </asp:BoundField>
                            <asp:BoundField DataField="RefNo" HeaderText="Reference No" ItemStyle-Width="100%">
                                <ItemStyle Width="20%" HorizontalAlign="Center"/>
                            </asp:BoundField>
                            <asp:BoundField DataField="AccTranDate" HeaderText="Transection Date" ItemStyle-Width="100%">
                                <ItemStyle Width="20%" HorizontalAlign="Center"/>
                            </asp:BoundField>
                            <asp:CommandField ItemStyle-HorizontalAlign="Center" ButtonType="Image" HeaderText="Click to Edit" SelectImageUrl="../App_Themes/MyCompany/edit.png" ShowSelectButton="True" />
                        </Columns>
                    <%--    <HeaderStyle BackColor="#F3E2A9" BorderColor="Gray" />--%>

                    </asp:GridView>
                </div>


                <div class="ParaHeader" align="center">
                    <asp:Button ID="btn_find" runat="server" Text="Find" CssClass="btn" OnClick="Find_Voucher_Data"
                        Height="23px" Width="87px" />
                </div>
            </div>
            <br />
            <div id="Find_Details" runat="server">
                <div class="ParaHeader" id="ReverseHeader" runat="server">
                    <b style="margin-left: 40%">
                        <asp:LinkButton ID="LinkButton1" runat="server" CssClass="btn btn-info" OnClick="Return_Back">
                <i class="icon-ok icon-white"></i>&nbsp;Return Back
                        </asp:LinkButton>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="Return_Voucher_btn" runat="server" CssClass="btn btn-info" OnClick="Reverse_Voucher">
                <i class="icon-ok icon-white"></i>&nbsp;Reverse This Voucher
                    </asp:LinkButton></b>
                </div>
                <br />

                <div id="Find_Details_GridView">
                    <asp:GridView ID="GV_Voucher_Details_Find" Width="100%" runat="server" AllowPaging="true" PageSize="8"
                        CellPadding="1" CellSpacing="2" DataKeyNames="AccVoucherTranID"
                        ShowFooter="true" AutoGenerateColumns="false"
                          BorderColor="Transparent" CssClass="grid-view"
                        OnSelectedIndexChanged="GV_Voucher_Details_Find_SelectedIndexChanged"
                        OnPageIndexChanging="GV_Voucher_Details_Find_PageIndexChanging"
                        OnRowDataBound="GV_Voucher_Details_Find_RowDataBound">


                        <Columns>
                            <asp:BoundField DataField="AccVoucherTranID" HeaderText="ID" Visible="false" ItemStyle-Width="100%">
                                <ItemStyle Width="10%" HorizontalAlign="Center"/>
                            </asp:BoundField>
                            <asp:BoundField DataField="VchrNo" HeaderText="Voucher Number" ItemStyle-Width="100%">
                                <ItemStyle Width="10%" HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="HeadAccount" HeaderText="Head Account" ItemStyle-Width="100%">
                                <ItemStyle Width="30%" HorizontalAlign="Center"/>
                            </asp:BoundField>
                            <asp:BoundField DataField="Tran_Comment" HeaderText="Transection Comment" ItemStyle-Width="100%">
                                <ItemStyle Width="20%" HorizontalAlign="Center"/>
                            </asp:BoundField>
                            <asp:BoundField DataField="AccTranDate" HeaderText="Transection Date" ItemStyle-Width="100%">
                                <ItemStyle Width="10%" HorizontalAlign="Center"/>
                            </asp:BoundField>
                            <asp:BoundField DataField="Debit" HeaderText="Debit Amount" ItemStyle-Width="100%">
                                <ItemStyle Width="10%" HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Credit" HeaderText="Credit Amount" ItemStyle-Width="100%">
                                <ItemStyle Width="10%" HorizontalAlign="Center" />
                            </asp:BoundField>

                            <asp:CommandField ItemStyle-HorizontalAlign="Center" ButtonType="Image" HeaderText="Click to Edit" SelectImageUrl="../App_Themes/MyCompany/edit.png" ShowSelectButton="True" />
                        </Columns>
                       <%-- <HeaderStyle BackColor="#F3E2A9" BorderColor="Gray" />--%>

                    </asp:GridView>
                </div>
            </div>



        </div>
    </ContentTemplate>
</asp:UpdatePanel>
<!-- 
    This section provides a sample markup for Touch UI user interface. 
-->
<div id="ReverseVoucher" data-app-role="page" data-activator="Button|ReverseVoucher">
    <p>
        Markup of <i>ReverseVoucher</i> custom user control for Touch UI.
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
