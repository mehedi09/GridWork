<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="GLAccounts.aspx.cs" Inherits="Pages_GLAccounts"  Title="G/L Accounts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">G/L Accounts</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row">
    <div id="view1" data-controller="AccFunds" data-view="grid1" data-show-in-summary="true" data-page-size="3"></div>
  </div>
</asp:Content>