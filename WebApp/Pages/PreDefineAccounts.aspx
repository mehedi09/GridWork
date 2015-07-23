<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="PreDefineAccounts.aspx.cs" Inherits="Pages_PreDefineAccounts"  Title="Ledger Interface Setup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Ledger Interface Setup</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row">
    <div data-activator="Tab|Ledger Interface Setup">
      <div id="view6" data-controller="AccFundAccs" data-view="grid1" data-filter-fields="AccFundID" data-page-size="5" data-auto-hide="self"></div>
    </div>
  </div>
</asp:Content>