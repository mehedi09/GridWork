<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ChequeHonour.ascx.cs" Inherits="Controls_ChequeHonour"  %>
<script src="http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.7.js" type="text/javascript"></script>
    <script src="http://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.16/jquery-ui.js" type="text/javascript"></script>
    <link href="http://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.16/themes/humanity/jquery-ui.css" rel="stylesheet" type="text/css" />
<script type="text/javascript">
    $(document).ready(function () {

       
    })

    function CheckAllEmp(Checkbox) {
        var GridVwHeaderChckbox = document.getElementById("<%=grdLedger.ClientID %>");
        for (i = 1; i < GridVwHeaderChckbox.rows.length; i++) {
            GridVwHeaderChckbox.rows[i].cells[0].getElementsByTagName("INPUT")[0].checked = Checkbox.checked;
        }
    }

    var prm = Sys.WebForms.PageRequestManager.getInstance();

    prm.add_endRequest(function () {


      

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
                        <asp:DropDownList ID="ddlBankLedger" runat="server"></asp:DropDownList></td>
                    <td style="width:18%"> </td>
                    <td style="width:32%">
                        
                    </td>
                    
                </tr>
                 
                 <tr>
                     <td style="width:18%">
                         <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" /></td>
                    <td style="width:32%">
                        <asp:Button ID="btnMatched" runat="server" Text="Cheque Honour" OnClick="btnMatched_Click"  />
                        <%--<asp:Button runat="server" ID="BtnSubmit"  OnClientClick="this.disabled = true; this.value = 'Submitting...';"   UseSubmitBehavior="false"  OnClick="BtnSubmit_Click"  Text="Submit Me!" />--%>
                    </td>
                    <td style="width:18%"></td>
                    <td style="width:32%"></td>
                    
                </tr>
                 <tr>
                     <td colspan="4">
                        <asp:GridView ID="grdLedger" runat="server" AllowPaging="True" AlternatingRowStyle-BackColor="White"
                             AlternatingRowStyle-ForeColor="Black" AutoGenerateColumns="False" CellPadding="1" CellSpacing="2" 
                             EmptyDataText="No data in the data source.!" HeaderStyle-BackColor="#B8DD68" HeaderStyle-ForeColor="Black"
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
                    <asp:BoundField DataField="AccTrnDetailID" ItemStyle-CssClass="hidden" HeaderStyle-CssClass="hidden" >
                    <HeaderStyle CssClass="hidden" />
                    <ItemStyle CssClass="hidden" />
                    </asp:BoundField>
                     
                   
                     <asp:BoundField DataField="VchrNumber" HeaderText="Voucher No" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center"  >
                    
                    </asp:BoundField>
                    <asp:BoundField DataField="Chequeno" HeaderText="Cheque no" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="center" >
                    
                    </asp:BoundField>
                    <asp:BoundField DataField="Amount" HeaderText="Amount" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Right" >
                   
                    </asp:BoundField>
                    <asp:BoundField DataField="ChequeDT" HeaderText="Cheque Date" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" >
                   
                    </asp:BoundField>
                    <asp:BoundField DataField="ChequeBankBranch" HeaderText="Cheque BankB ranch" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Left" >
                   
                    </asp:BoundField>
                    <asp:BoundField DataField="LedgerName" HeaderText="Ledger Name" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Left" >
                   
                    </asp:BoundField>
                    
                </Columns>
                <HeaderStyle BackColor="#F3E2A9" BorderColor="Gray" />

<RowStyle BackColor="#B8DD68"></RowStyle>
            </asp:GridView>
                     </td>
                   
                   
                </tr>
                 
                 <tr>
                     <td style="width:18%"></td>
                    <td style="width:32%"></td>
                    <td style="width:18%"></td>
                    <td style="width:32%"></td>
                   
                </tr>
            </table>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
