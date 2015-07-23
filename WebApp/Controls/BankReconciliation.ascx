<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BankReconciliation.ascx.cs" Inherits="Controls_BankReconciliation" %>
<script src="http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.7.js" type="text/javascript"></script>
    <script src="http://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.16/jquery-ui.js" type="text/javascript"></script>
    <link href="http://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.16/themes/humanity/jquery-ui.css" rel="stylesheet" type="text/css" />
<script type="text/javascript">
    $(document).ready(function () {

        $("[id$=txtToDate]").datepicker({
            changeMonth: true,
            changeYear: true
        });
        $("[id$=txtVoucherdate]").datepicker({
            changeMonth: true,
            changeYear: true
        });
        

    

    })
    
    function CheckAllEmp(Checkbox) {
        var GridVwHeaderChckbox = document.getElementById("<%=grdLedger.ClientID %>");
        for (i = 1; i < GridVwHeaderChckbox.rows.length; i++) {
            GridVwHeaderChckbox.rows[i].cells[0].getElementsByTagName("INPUT")[0].checked = Checkbox.checked;
        }
    }

    var prm = Sys.WebForms.PageRequestManager.getInstance();

    prm.add_endRequest(function () {


        $("[id$=txtToDate]").datepicker({
            changeMonth: true,
            changeYear: true
        });
        $("[id$=txtVoucherdate]").datepicker({
            changeMonth: true,
            changeYear: true
        });
        function CheckAllEmp(Checkbox) {
            var GridVwHeaderChckbox = document.getElementById("<%=grdLedger.ClientID %>");
            for (i = 1; i < GridVwHeaderChckbox.rows.length; i++) {
                GridVwHeaderChckbox.rows[i].cells[0].getElementsByTagName("INPUT")[0].checked = Checkbox.checked;
            }
        }


        
    });

</script>
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <div style="margin: 2px; border: solid 1px silver; padding: 8px;">
            <table style="width:100%">
                <tr><td colspan="4">
                    <asp:Label ID="lblError" ForeColor="Red" runat="server" Text=""></asp:Label></td></tr>
                <tr>
                    <td style="width:18%">Bank Account Ledger </td>
                    <td style="width:32%">
                        <asp:DropDownList ID="ddlBankLedger" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlBankLedger_SelectedIndexChanged"></asp:DropDownList></td>
                    <td style="width:18%">Current Ledger Balance </td>
                    <td style="width:32%">
                        <%--<asp:Label ID="lblCurrentLedgerBalance" runat="server" Text=""></asp:Label>--%>
                        <asp:TextBox ID="txtCurrentLedgerBalance" runat="server"></asp:TextBox>
                    </td>
                    
                </tr>
                 <tr>
                    <td style="width:18%">Last Reconciliation Date</td>
                    <td style="width:32%">
                        <asp:Label ID="lblLastReconciliationDate" runat="server" Text=""></asp:Label></td>
                    <td style="width:18%">Enter Bank Balance</td>
                    <td style="width:32%">
                        <asp:TextBox ID="txtEnterBankBalance" runat="server" AutoPostBack="True" OnTextChanged="txtEnterBankBalance_TextChanged"></asp:TextBox></td>
                    
                </tr>
                 <tr>
                    <td style="width:18%">To Date</td>
                    <td style="width:32%">
                        <asp:TextBox ID="txtToDate" runat="server"></asp:TextBox></td>
                    <td style="width:18%">Difference Amount</td>
                    <td style="width:32%">
                        <asp:TextBox ID="txtDifferenceAmount" runat="server" Text="0"></asp:TextBox></td>
                    
                </tr>
                 <tr>
                     <td style="width:18%">
                         <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" /></td>
                    <td style="width:32%">
                        <asp:Button ID="btnMatched" runat="server" Text="Match" OnClick="btnMatched_Click" />
                        <%--<asp:Button runat="server" ID="BtnSubmit"  OnClientClick="this.disabled = true; this.value = 'Submitting...';"   UseSubmitBehavior="false"  OnClick="BtnSubmit_Click"  Text="Submit Me!" />--%>
                    </td>
                    <td style="width:18%"></td>
                    <td style="width:32%"></td>
                    
                </tr>
                <tr>
                     <td style="width:18%">Voucher Date
                         </td>
                    <td style="width:32%">
                       <asp:TextBox ID="txtVoucherdate" runat="server"></asp:TextBox>
                    </td>
                    <td style="width:18%"></td>
                    <td style="width:32%"></td>
                    
                </tr>
                 <tr>
                     <td colspan="4">
                        <asp:GridView ID="grdLedger" runat="server" AllowPaging="True" AlternatingRowStyle-BackColor="White"
                             AlternatingRowStyle-ForeColor="Black" AutoGenerateColumns="False" CellPadding="1" CellSpacing="2" 
                             EmptyDataText="No match data found!" HeaderStyle-BackColor="#B8DD68" HeaderStyle-ForeColor="Black"
                              PageSize="8" RowStyle-BackColor="#B8DD68"  Width="100%">
<AlternatingRowStyle BackColor="White" ForeColor="Black"></AlternatingRowStyle>
                <Columns>
                    <asp:TemplateField >
                        <ItemStyle HorizontalAlign="Center" />
                        <HeaderTemplate>
                            <asp:CheckBox ID="chkHeader" runat="server" onclick="CheckAllEmp(this);" />
                        </HeaderTemplate>
                        <ItemTemplate >
                            <asp:CheckBox ID="chkCheck" runat="server"   />
                        </ItemTemplate>

                    </asp:TemplateField>
                    <asp:BoundField DataField="AccVoucherTranID" ItemStyle-CssClass="hidden" HeaderStyle-CssClass="hidden" >
                    <HeaderStyle CssClass="hidden" />
                    <ItemStyle CssClass="hidden" />
                    </asp:BoundField>
                     <asp:BoundField DataField="AccFundID" ItemStyle-CssClass="hidden" HeaderStyle-CssClass="hidden" >
                    <HeaderStyle CssClass="hidden" />
                    <ItemStyle CssClass="hidden" />
                    </asp:BoundField>
                    <asp:BoundField DataField="VchrTypeID" ItemStyle-CssClass="hidden" HeaderStyle-CssClass="hidden" >
                    <HeaderStyle CssClass="hidden" />
                    <ItemStyle CssClass="hidden" />
                    </asp:BoundField>
                     <asp:BoundField DataField="RevAcc" ItemStyle-CssClass="hidden" HeaderStyle-CssClass="hidden" >
                    <HeaderStyle CssClass="hidden" />
                    <ItemStyle CssClass="hidden" />
                    </asp:BoundField>
                    <asp:BoundField DataField="AccName" HeaderText="Ledger Name"  >
                    
                    </asp:BoundField>
                     <asp:BoundField DataField="VchrNo" HeaderText="Voucher No" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center"  >
                    
                    </asp:BoundField>
                    <asp:BoundField DataField="Debit" HeaderText="Debit" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Right" >
                    
                    </asp:BoundField>
                    <asp:BoundField DataField="Credit" HeaderText="Credit" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Right" >
                   
                    </asp:BoundField>
                </Columns>
                <HeaderStyle BackColor="#F3E2A9" BorderColor="Gray" />

<RowStyle BackColor="#B8DD68"></RowStyle>
            </asp:GridView>
                     </td>
                   
                   
                </tr>
                 
                <tr>
                     <td style="width: 18%">
                         <asp:Label runat="server" ID="lblMsg" ></asp:Label>
                     </td>
                   
                   
                     <td style="width: 32%">
                        <%-- <asp:DropDownList ID="ddlDebitLedger" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlDebitLedger_SelectedIndexChanged">
                         </asp:DropDownList>--%>
                     </td>
                     <td style="width: 18%"></td>
                     <td style="width: 32%"></td></tr>
                <tr>
                    <td colspan="4">
                         <div class="ParaHeader" align="center">
                    <asp:Button ID="btn_save" runat="server" Text="Save" CssClass="btn" OnClick="Save_Deatis"
                        Height="22px" Width="87px" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <asp:Button ID="btn_Cancel" runat="server" Text="New" CssClass="btn" OnClick="Cancel_Voucher"
                     Height="23px" Width="87px" />

                </div>
                    </td>

                </tr>
                     <tr>
                         <td colspan="4">
                             <asp:GridView ID="grdVoucher" runat="server" AlternatingRowStyle-BackColor="#B8DD68" AlternatingRowStyle-ForeColor="Black"
                                  AutoGenerateColumns="false" HeaderStyle-BackColor="#B8DD68" HeaderStyle-ForeColor="Black" OnRowDeleting="Gridview_RowDeleting"
                        OnRowDataBound="Gridview_RowDataBound"
                                  RowStyle-BackColor="#B8DD68" ShowFooter="true" Visible="false" Width="100%">
                                 <AlternatingRowStyle BackColor="#B8DD68" ForeColor="Black" />
                                 <Columns>
                                     <asp:BoundField DataField="RowNumber" HeaderText="Row Number" Visible="false" />
                                     <asp:TemplateField HeaderText="Transection Ledger">
                                         <ItemTemplate>
                                             <div>
                                                 <asp:DropDownList ID="DDLTransection_Ledger" runat="server" AutoPostBack="true" Style="width: 100%" OnSelectedIndexChanged="DDLTransection_Ledger_SelectedIndexChanged">
                                                 </asp:DropDownList>
                                             </div>
                                         </ItemTemplate>
                                     </asp:TemplateField>
                                     <asp:TemplateField HeaderText="Sub Type 1" Visible="false">
                                         <ItemTemplate>
                                             <div>
                                                 <asp:DropDownList ID="DDLSub_Type" runat="server">
                                                 </asp:DropDownList>
                                             </div>
                                         </ItemTemplate>
                                     </asp:TemplateField>
                                     <asp:TemplateField HeaderText="Subledger 1" Visible="false">
                                         <ItemTemplate>
                                             <asp:DropDownList ID="DDLSub_Ledger" runat="server" Style="width: 100%">
                                             </asp:DropDownList>
                                         </ItemTemplate>
                                     </asp:TemplateField>
                                     <asp:TemplateField HeaderText="Sub Type 2" Visible="false">
                                         <ItemTemplate>
                                             <div>
                                                 <asp:DropDownList ID="DDLSub_Type1" runat="server">
                                                 </asp:DropDownList>
                                             </div>
                                         </ItemTemplate>
                                     </asp:TemplateField>
                                     <asp:TemplateField HeaderText="Subledger 2" Visible="false">
                                         <ItemTemplate>
                                             <asp:DropDownList ID="DDLSub_Ledger1" runat="server" Style="width: 100%">
                                             </asp:DropDownList>
                                         </ItemTemplate>
                                     </asp:TemplateField>
                                     <asp:TemplateField HeaderText="Sub Type 2" Visible="false">
                                         <ItemTemplate>
                                             <div>
                                                 <asp:DropDownList ID="DDLSub_Type2" runat="server" >
                                                 </asp:DropDownList>
                                             </div>
                                         </ItemTemplate>
                                     </asp:TemplateField>
                                     <asp:TemplateField HeaderText="Subledger 3" Visible="false">
                                         <ItemTemplate>
                                             <asp:DropDownList ID="DDLSub_Ledger2" runat="server" Style="width: 100%">
                                             </asp:DropDownList>
                                         </ItemTemplate>
                                     </asp:TemplateField>
                                     <asp:TemplateField HeaderText="Amount">
                                        
                                         <ItemTemplate>
                                             <div align="center" class="RightAlignedInputs">
                                                 <asp:TextBox ID="txt_Amount" runat="server" Style="width: 90%"></asp:TextBox>
                                             </div>
                                         </ItemTemplate>
                                     </asp:TemplateField>
                                     <asp:TemplateField HeaderText="Currency">
                                         <ItemTemplate>
                                             <asp:DropDownList ID="DDLCurrency" runat="server" Style="width: 100%">
                                             </asp:DropDownList>
                                         </ItemTemplate>
                                     </asp:TemplateField>
                                     <asp:TemplateField HeaderText="Exchange Rate">
                                         <ItemTemplate>
                                             <div class="RightAlignedInputs">
                                                 <asp:TextBox ID="txt_Exchange_Rate" runat="server" Style="width: 100%"></asp:TextBox>
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
                                                 <asp:Button ID="ButtonDlt" runat="server" CausesValidation="False" CommandName="Delete" meta:resourcekey="BtnUserDeleteResource1" OnClientClick="if ( !confirm('Are you sure to Delete this Row ?')) return false;" Style="width: 60%" Text="Delete" />
                                             </div>
                                         </ItemTemplate>
                                         <FooterStyle HorizontalAlign="Right" />
                                         <FooterTemplate>
                                             <asp:Button ID="ButtonAdd" runat="server" Text="Add New Row" OnClick="ButtonAdd_Click" />
                                         </FooterTemplate>
                                     </asp:TemplateField>
                                 </Columns>
                                 <HeaderStyle BackColor="#F3E2A9" BorderColor="Gray" />
                                 <RowStyle BackColor="#B8DD68" />
                             </asp:GridView>
                         </td>
                     </tr>
                   <tr>
                       <td style="width: 18%"></td>
                       <td style="width: 32%"></td>
                       <td style="width: 18%"></td>
                       <td style="width: 32%"><%--<asp:Label runat="server" ID="Total_Amount" Text="TOTAL =" Visible="false"></asp:Label>
                            <asp:Label runat="server" ID="Sum_amount" Visible="false"></asp:Label>--%></td>
                   </tr>
                   
                </tr>
            </table>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
<!-- 
    This section provides a sample markup for Touch UI user interface. 
-->

