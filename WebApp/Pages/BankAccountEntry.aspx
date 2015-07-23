<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="BankAccountEntry.aspx.cs" Inherits="Pages_BankAccountEntry"  Title="Bank Account Entry" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Bank Account Entry</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row">
    <div id="view1" data-controller="BankAccountEntry" data-view="grid1"></div>
  </div>
</asp:Content>