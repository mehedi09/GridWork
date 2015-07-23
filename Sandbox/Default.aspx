<%@ Page Language="C#" AutoEventWireup="true"  %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
  <head runat="server">
    <title>Sandbox</title>
    <script runat="server">
protected void Page_Load(object sender, EventArgs e)
{
    Extender1.Controller = ControllerDropDown.SelectedValue;
}
</script>
  </head>
  <body style="margin:0px;">
    <form id="form1" runat="server">
      <div style="padding:8px">
        <asp:ScriptManager ID="sm" runat="server" ScriptMode="Release" />
        <asp:DropDownList ID="ControllerDropDown" runat="server" AutoPostBack="true" Font-Names="Tahoma" Style="margin-bottom: 8px" Font-Size="8.5pt">
          <asp:ListItem Text="AccBalTypes" Value="AccBalTypes" />
          <asp:ListItem Text="AccBillRegisterD" Value="AccBillRegisterD" />
          <asp:ListItem Text="AccBillRegisterH" Value="AccBillRegisterH" />
          <asp:ListItem Text="AccCurrencys" Value="AccCurrencys" />
          <asp:ListItem Text="AccDests" Value="AccDests" />
          <asp:ListItem Text="AccFundAccs" Value="AccFundAccs" Selected="true" />
          <asp:ListItem Text="AccFunds" Value="AccFunds" />
          <asp:ListItem Text="AccountTransactions" Value="AccountTransactions" />
          <asp:ListItem Text="AccSubNames" Value="AccSubNames" />
          <asp:ListItem Text="AccSubTypes" Value="AccSubTypes" />
          <asp:ListItem Text="AccTrnDetail" Value="AccTrnDetail" />
          <asp:ListItem Text="AccTrnHeader" Value="AccTrnHeader" />
          <asp:ListItem Text="AccTypes" Value="AccTypes" />
          <asp:ListItem Text="Bank" Value="Bank" />
          <asp:ListItem Text="BillRegister" Value="BillRegister" />
          <asp:ListItem Text="ChequeBooks" Value="ChequeBooks" />
          <asp:ListItem Text="ChequeBooksLeaf" Value="ChequeBooksLeaf" />
          <asp:ListItem Text="CoaControl" Value="CoaControl" />
          <asp:ListItem Text="CoaDetail" Value="CoaDetail" />
          <asp:ListItem Text="CoaMain" Value="CoaMain" />
          <asp:ListItem Text="CoaSub" Value="CoaSub" />
          <asp:ListItem Text="CoinEntry" Value="CoinEntry" />
          <asp:ListItem Text="Company" Value="Company" />
          <asp:ListItem Text="CompanyTypes" Value="CompanyTypes" />
          <asp:ListItem Text="CompFeature" Value="CompFeature" />
          <asp:ListItem Text="Employees" Value="Employees" />
          <asp:ListItem Text="FinancialYear" Value="FinancialYear" />
          <asp:ListItem Text="ImpresstFund" Value="ImpresstFund" />
          <asp:ListItem Text="ImpresstFundCoins" Value="ImpresstFundCoins" />
          <asp:ListItem Text="ImpresstFundIOU" Value="ImpresstFundIOU" />
          <asp:ListItem Text="ImpresstFundTrans" Value="ImpresstFundTrans" />
          <asp:ListItem Text="MenuInRule" Value="MenuInRule" />
          <asp:ListItem Text="MenuInUser" Value="MenuInUser" />
          <asp:ListItem Text="ModeofReceipts" Value="ModeofReceipts" />
          <asp:ListItem Text="Modules" Value="Modules" />
          <asp:ListItem Text="MoneyReceipts" Value="MoneyReceipts" />
          <asp:ListItem Text="Paycategory" Value="Paycategory" />
          <asp:ListItem Text="PDCIssue" Value="PDCIssue" />
          <asp:ListItem Text="PDCIssueDetails" Value="PDCIssueDetails" />
          <asp:ListItem Text="PDCReceive" Value="PDCReceive" />
          <asp:ListItem Text="PDCReceiveDetails" Value="PDCReceiveDetails" />
          <asp:ListItem Text="Prefix" Value="Prefix" />
          <asp:ListItem Text="PreFixSetting" Value="PreFixSetting" />
          <asp:ListItem Text="Roles" Value="Roles" />
          <asp:ListItem Text="Subsidiary_Accounts" Value="Subsidiary_Accounts" />
          <asp:ListItem Text="UserRoles" Value="UserRoles" />
          <asp:ListItem Text="Users" Value="Users" />
          <asp:ListItem Text="VoucherTypes" Value="VoucherTypes" />
          <asp:ListItem Text="MonthlyLedgerReport" Value="MonthlyLedgerReport" />
          <asp:ListItem Text="GeneralLedgers" Value="GeneralLedgers" />
          <asp:ListItem Text="FilterLedgers" Value="FilterLedgers" />
          <asp:ListItem Text="GeneralLedgerReport" Value="GeneralLedgerReport" />
          <asp:ListItem Text="TrialBalance" Value="TrialBalance" />
          <asp:ListItem Text="TrailBalanceParam" Value="TrailBalanceParam" />
          <asp:ListItem Text="ProfitLossStatement" Value="ProfitLossStatement" />
          <asp:ListItem Text="YearMonthParam" Value="YearMonthParam" />
          <asp:ListItem Text="AccTrnHeaderChart" Value="AccTrnHeaderChart" />
          <asp:ListItem Text="AccountsPayable" Value="AccountsPayable" />
          <asp:ListItem Text="AccountsReceivable" Value="AccountsReceivable" />
          <asp:ListItem Text="OpeningTrialBalance" Value="OpeningTrialBalance" />
          <asp:ListItem Text="BillRegisterPayment" Value="BillRegisterPayment" />
          <asp:ListItem Text="ReceipsAndPayments" Value="ReceipsAndPayments" />
          <asp:ListItem Text="BillRegisterSearch" Value="BillRegisterSearch" />
          <asp:ListItem Text="CoaDetailOpenBalance" Value="CoaDetailOpenBalance" />
          <asp:ListItem Text="ChartOfAccountReport" Value="ChartOfAccountReport" />
          <asp:ListItem Text="BankAccountEntry" Value="BankAccountEntry" />
          <asp:ListItem Text="CoaControl1" Value="CoaControl1" />
          <asp:ListItem Text="CoaMain1" Value="CoaMain1" />
          <asp:ListItem Text="CoaSub1" Value="CoaSub1" />
          <asp:ListItem Text="Users1" Value="Users1" />
          <asp:ListItem Text="MoneyReceiptsGeneral" Value="MoneyReceiptsGeneral" />
          <asp:ListItem Text="ImpresstFundCoinsview" Value="ImpresstFundCoinsview" />
          <asp:ListItem Text="ChequePrint" Value="ChequePrint" />
          <asp:ListItem Text="AccTrnHeaderForChequeVoid" Value="AccTrnHeaderForChequeVoid" />
          <asp:ListItem Text="AccTrnDetailForChequeVoid" Value="AccTrnDetailForChequeVoid" />
        </asp:DropDownList>
        <div id="Div1" runat="server" />
        <aquarium:DataViewExtender ID="Extender1" runat="server" TargetControlID="Div1" />
      </div>
    </form>
  </body>
</html>