<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SalesJournal.ascx.cs" Inherits="Controls_SalesJournal" %>
<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<script src="http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.7.js" type="text/javascript"></script>

<script src="http://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.16/jquery-ui.js" type="text/javascript"></script>

<link href="http://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.16/themes/humanity/jquery-ui.css" rel="stylesheet" type="text/css" />

<script type="text/javascript">
    function ValidateNmber(obj, evt) {
        var charCode = (evt.which) ? evt.which : event.keyCode
        /*First decimal allowed*/
        if (charCode == 46 && isDecimal) {
            isDecimal = false;
            return true;
        }
            /*Dont allow more*/
        else if (charCode == 46 && !isDecimal) {
            return false;
        }
        if (charCode > 31 && (charCode < 48 || charCode > 57) || !isSubmit) {
            return false;
        }
        else {
            isDecimal = true;
            return true;
        }
    }
    $(function () {
        $("#<%= EditVoucher_Date.ClientID %>").datepicker({
            dateFormat: 'dd/mm/yy',
            changeMonth: true,
            changeYear: true
        });

    });
    var prm = Sys.WebForms.PageRequestManager.getInstance();

    prm.add_endRequest(function () {
        $("#<%= EditVoucher_Date.ClientID %>").datepicker({
            dateFormat: 'dd/mm/yy',
            changeMonth: true,
            changeYear: true

        });

    });
</script>
<link href="~/App_Themes/MyCompany/StyleSheet.css" rel="stylesheet" />

<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>


        <div class="ParaInfo">
            Sales Journal Voucher Form, Here You Create Sales Journal Voucher.
            <br class="Apple-interchange-newline" />
        </div>
        <div class="ParaHeader">
            <asp:Label runat="server" ID="CP_Header"></asp:Label>&nbsp;Voucher From
            <b style="margin-left: 40%">
                <asp:Label runat="server" ID="lbl_SMsgg" ForeColor="Green"></asp:Label>
                <asp:LinkButton ID="Return_Voucher_btn" runat="server" CssClass="btn btn-info" OnClick="OK_Report">
                <i class="icon-ok icon-white"></i>&nbsp;Return Voucher
                </asp:LinkButton>
            </b>


            <asp:LinkButton ID="Find_VoucherButton" runat="server" CssClass="btn btn-info" Style="float: right" OnClick="Find_Voucher">
                <i class="icon-ok icon-white"></i>&nbsp;Find Voucher
            </asp:LinkButton>
            <asp:LinkButton ID="LB_Voucher_Print" runat="server" CssClass="btn btn-info" Style="float: right" OnClick="Print_Voucher">
                <i class="icon-ok icon-white"></i>&nbsp;Print Voucher
            </asp:LinkButton>

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
                                                <asp:DropDownList ID="DDLCompany_Name_Find" runat="server" Style="width: 150px">
                                                </asp:DropDownList>

                                                <%-- <asp:Label ID="lblCompany_Name" runat="server" Visible="false"></asp:Label>--%>
                                            </div>
                                        </td>
                                        <td class="Header" valign="top">Voucher Type :
                                        </td>
                                        <td class="auto-style1">
                                            <div class="FieldPlaceholder DataOnly">
                                                <asp:DropDownList ID="DDLVoucherType_Find" runat="server" Style="width: 150px">
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
                                                <asp:TextBox ID="txt_CVoucher_No_Find" runat="server" Style="width: 150px"></asp:TextBox>
                                            </div>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td colspan="2"></td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </div>
                <div id="Find_GridView">
                    <asp:GridView ID="GV_VoucherFind" Width="100%" runat="server" AllowPaging="true" PageSize="8"
                        CellPadding="1" CellSpacing="2" DataKeyNames="AccVoucherTranID"
                        ShowFooter="true" AutoGenerateColumns="false"
                       BorderColor="Transparent" CssClass="grid-view"
                        OnSelectedIndexChanged="GV_VoucherFind_SelectedIndexChanged"
                        OnPageIndexChanging="GV_VoucherFind_PageIndexChanging"
                        OnRowDataBound="GV_VoucherFind_RowDataBound">
                        <Columns>
                            <asp:BoundField DataField="AccVoucherTranID" HeaderText="ID" Visible="false" ItemStyle-Width="100%">
                                <ItemStyle Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField DataField="VchrNumber" HeaderText="Voucher Number" ItemStyle-Width="100%">
                                <ItemStyle Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField DataField="PaidTo" HeaderText="Paid To" ItemStyle-Width="100%">
                                <ItemStyle Width="10%" />
                            </asp:BoundField>
                            <asp:BoundField DataField="AccRemarks" HeaderText="Remarks" ItemStyle-Width="100%">
                                <ItemStyle Width="20%" />
                            </asp:BoundField>
                            <asp:BoundField DataField="RefNo" HeaderText="Reference No" ItemStyle-Width="100%">
                                <ItemStyle Width="20%" />
                            </asp:BoundField>
                            <asp:BoundField DataField="AccTranDate" HeaderText="Transection Date" ItemStyle-Width="100%">
                                <ItemStyle Width="20%" />
                            </asp:BoundField>
                            <asp:CommandField ButtonType="Image" HeaderText="Click to Edit" SelectImageUrl="../App_Themes/MyCompany/edit.png" ShowSelectButton="True" />
                        </Columns>
                       <%-- <HeaderStyle BackColor="#F3E2A9" BorderColor="Gray" />--%>
                    </asp:GridView>
                </div>
                <div class="ParaHeader" align="center">
                    <asp:Button ID="btn_find" runat="server" Text="Find" CssClass="btn" OnClick="Find_Voucher_Data"
                        Height="23px" Width="87px" />
                </div>

            </div>
            <div id="VC_Form" runat="server">

                <div id="Voucher_form">
                    <table style="width: 100%">
                        <tr>
                            <td valign="top">
                                <table>
                                      <tr>
                                        <td>Voucher No :
                                        </td>
                                        <td>
                                            <b>
                                                <asp:Label ID="Lbl_Last_VoucherNo" runat="server"></asp:Label>
                                            </b>
                                        </td>
                                       
                                    </tr>
                                    <tr>
                                        <td colspan="2"></td>
                                    </tr>
                                    <tr>

                                        <td class="Header" valign="top">Voucher Date:
                                        </td>
                                        <td>
                                            <div class="FieldPlaceholder DataOnly">
                                                <asp:TextBox runat="server" ID="EditVoucher_Date" Width="100px"></asp:TextBox>
                                                <asp:Label ID="lblDate" runat="server" Visible="false"><%--<%= System.DateTime.Now %>--%></asp:Label>
                                            </div>
                                        </td>
                                      
                                    </tr>

                                     <tr>
                                        <td colspan="2"></td>
                                    </tr>

                                    <tr class="FieldWrapper" runat="server" visible="false">
                                        <td class="Header" valign="top">Company Name:
                                        </td>
                                        <td class="auto-style1">
                                           
                                                <asp:DropDownList ID="DDLCompany_Name" runat="server" Style="width: 150px">
                                                </asp:DropDownList>

                                          
                                        </td>
                                        <td class="Header" valign="top">Voucher Type :
                                        </td>
                                        <td class="auto-style1">
                                            <div class="FieldPlaceholder DataOnly">
                                                <asp:DropDownList ID="DDLVoucherType" OnSelectedIndexChanged="DDLVoucherType_SelectedIndexChanged" AutoPostBack="true" runat="server" Style="width: 150px">
                                                </asp:DropDownList>
                                            </div>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td colspan="2"></td>
                                    </tr>

                                    <tr>
                                        <td class="Header" valign="top">Head of Account :
                                        </td>
                                        <td class="auto-style1">
                                            <div class="FieldPlaceholder DataOnly">
                                                <asp:DropDownList ID="DDLTranLedger" runat="server" Style="width: 220px">
                                                </asp:DropDownList>


                                            </div>
                                        </td>

                                    </tr>
                                    <tr>
                                        <td colspan="2"></td>
                                    </tr>
                                    <tr>
                                        <td>Adjustment From:</td>
                                        <td class="auto-style1">
                                            <div class="FieldPlaceholder DataOnly">
                                                <asp:DropDownList ID="DDLAdjFrmLedger" runat="server" Style="width: 220px">
                                                </asp:DropDownList>
                                                <%--<asp:Label ID="lblVoucherType" runat="server" Visible="false"></asp:Label>--%>
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2"></td>
                                    </tr>
                                    <tr>
                                        <td>Amount :</td>
                                        <td>
                                            <asp:TextBox ID="txt_amount" runat="server" Style="width: 220px" onkeypress = "javascript:return ValidateNmber(this,event);"></asp:TextBox></td>
                                    </tr>
                                    <tr>
                                        <td colspan="2"></td>
                                    </tr>
                                       <tr>
                                        <td>Reference No :</td>
                                           <td><asp:TextBox ID="txt_ref_no" runat="server" Style="width: 220px"></asp:TextBox></td>
                                    </tr>
                                       <tr>
                                        <td colspan="2"></td>
                                    </tr>
                                    <tr>
                                        <td class="Header" valign="top">Voucher Narration / Memo :
                                        </td>
                                        <td colspan="3">
                                            <asp:TextBox ID="txt_Voucher_Narration" runat="server" Style="width: 220px" TextMode="MultiLine" Height="70px"></asp:TextBox>
                                        </td>
                                    </tr>


                                    <tr>
                                        <td colspan="2">

                                            <asp:Label runat="server" ID="lblMsg" Visible="false"></asp:Label>
                                        </td>
                                    </tr>


                                    <tr>
                                        <td colspan="2"></td>
                                    </tr>


                                </table>
                            </td>


                            <td valign="top">
                                <table style="float: right">
                                  






                                </table>
                            </td>
                        </tr>
                    </table>
                </div>
                <br />
                <div class="ParaHeader" align="center">
                    <asp:Button ID="Button1" runat="server" Text="Add" CssClass="btn" OnClick="Add_Deatis"
                        Height="22px" Width="87px" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btn_save" runat="server" Text="Save" CssClass="btn" OnClick="Save_Deatis"
                        Height="22px" Width="87px" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <asp:Button ID="btn_Cancel" runat="server" Text="New" CssClass="btn" OnClick="Cancel_Voucher"
                     Height="23px" Width="87px" />
                </div>
                <div align="center">

                    <asp:GridView ID="GV_JournalVoucher" runat="server" ShowFooter="true" AutoGenerateColumns="false"
                        OnRowDeleting="GV_JournalVoucher_RowDeleting"
                        OnRowDataBound="GV_JournalVoucher_RowDataBound"
                         BorderColor="Transparent" CssClass="grid-view"
                        Visible="false" Width="100%">
                        <Columns>
                            <asp:BoundField DataField="RowNumber" HeaderText="Row Number" Visible="false" />
                            <asp:TemplateField HeaderText="Head of Account">
                                <ItemTemplate>
                                    <div>
                                        <asp:DropDownList ID="DDLTransection_Ledger" runat="server" Style="width: 100%">
                                        </asp:DropDownList>
                                    </div>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField HeaderText="Adjustment From">
                                <ItemTemplate>
                                    <div>
                                        <asp:DropDownList ID="DDLAdjustment_From" runat="server" Style="width: 100%">
                                        </asp:DropDownList>
                                    </div>
                                </ItemTemplate>
                            </asp:TemplateField>


                            <asp:TemplateField HeaderText="Amount">
                                <ItemTemplate>
                                    <div class="RightAlignedInputs" align="center">
                                        <asp:TextBox ID="txt_Amount" runat="server" Style="width: 90%" AutoPostBack="true" OnTextChanged="txt_Amount_TextChanged" onkeypress = "javascript:return ValidateNmber(this,event);"></asp:TextBox>
                                    </div>
                                </ItemTemplate>
                            </asp:TemplateField>


                            <asp:TemplateField HeaderText="Memo">
                                <ItemTemplate>
                                    <div>
                                        <asp:TextBox ID="txt_Transection_Memo" runat="server" Style="width: 90%"></asp:TextBox>
                                    </div>
                                </ItemTemplate>
                            </asp:TemplateField>





                            <asp:TemplateField HeaderText="">
                                <ItemTemplate>
                                    <div align="center">
                                        <asp:Button ID="ButtonDlt" Text="Delete" CausesValidation="False" CommandName="Delete" runat="server" Style="width: 90%"
                                            meta:resourcekey="BtnUserDeleteResource1"
                                            OnClientClick="if ( !confirm('Are you sure to Delete this Row ?')) return false;"></asp:Button>
                                    </div>
                                </ItemTemplate>
                                <FooterStyle HorizontalAlign="Right" />
                                <FooterTemplate>
                                    <%--<asp:Button ID="ButtonAdd" runat="server" Text="Add New Row" OnClick="ButtonAdd_Click" />--%>
                                </FooterTemplate>
                            </asp:TemplateField>

                        </Columns>
                        <%--<HeaderStyle BackColor="Silver" BorderColor="Gray" />--%>
                    </asp:GridView>
                </div>
                <div class="ParaHeader" align="center">



                    <b style="margin-left: 50%">
                        <asp:Label runat="server" ID="Total_Amount" Text="TOTAL =" Visible="false"></asp:Label>
                        <asp:Label runat="server" ID="Sum_amount" Visible="false"></asp:Label></b>

                </div>

            </div>

        </div>
        <div id="ReportForm" runat="server">

            <table style="width: 100%">
                <tr>
                    <td valign="top">
                        <div style="align-content: center">
                            <rsweb:ReportViewer ID="ReportViewer1" runat="server" AsyncRendering="false" Font-Names="Verdana" Font-Size="8pt" SizeToReportContent="True" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Visible="false">
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
            <div class="ParaHeader">
                * - indicates a required field
               <%-- <asp:Button ID="Button2" runat="server" Text="OK" CssClass="btn" OnClick="OK_Report" Height="22px" Width="87px" />--%>
            </div>
        </div>
        <div class="Instruction" id="view1_Wait" align="left">
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
<!-- 
    This section provides a sample markup for Touch UI user interface. 
-->
<div data-app-role="page" data-activator="Button|JournalVoucher">
    <p>
        Markup of <i>JournalVoucher</i> custom user control for Touch UI.
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
