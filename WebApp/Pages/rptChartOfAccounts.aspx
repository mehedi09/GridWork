<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="rptChartOfAccounts.aspx.cs" Inherits="Pages_rptChartOfAccounts"  Title="Chart Of Accounts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Chart Of Accounts</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row">
    <div data-activator="Tab|G/L Accounts">
      <div id="view2" data-controller="ChartOfAccountReport" data-view="grid1" data-page-size="20" data-auto-hide="self" data-show-modal-forms="true"></div>
    </div>
  </div>
</asp:Content>