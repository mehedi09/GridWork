<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ChartOfAccounts.aspx.cs" Inherits="Pages_ChartOfAccounts"  Title="Chart Of Accounts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Chart Of Accounts</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row" data-width="100%">
    <div id="view2" data-controller="AccFunds" data-view="grid1" data-show-in-summary="true" data-page-size="2"></div>
    <div data-activator="Tab|1st Account Group">
      <div id="view4" data-controller="CoaControl" data-page-size="5" data-show-row-number="true"></div>
    </div>
    <div data-activator="Tab|2nd Account Group">
      <div id="view1" data-controller="CoaMain" data-view="grid1" data-show-in-summary="true" data-filter-source="view2" data-filter-fields="AccFundID" data-page-size="5" data-refresh-interval="60" data-show-row-number="true"></div>
    </div>
    <div data-activator="Tab|3rd Account Group">
      <div id="view3" data-controller="CoaSub" data-view="grid1" data-filter-source="view2" data-filter-fields="AccFundID" data-page-size="5" data-show-row-number="true"></div>
    </div>
    <div data-activator="Tab|G/L Accounts">
      <div id="view5" data-controller="CoaDetail" data-view="grid1" data-filter-source="view3" data-filter-fields="AccFundID" data-page-size="5" data-show-row-number="true"></div>
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">Group Ledger - e.g. Fixed Assets, Current Assets, Liabilities, Non-Current Assets, Investment, Inventory, Long Term Loan, Short Term Loan, Provisions.</div>
    </div>
  </div>
</asp:Content>