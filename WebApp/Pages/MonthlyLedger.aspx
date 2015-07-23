<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="MonthlyLedger.aspx.cs" Inherits="Pages_MonthlyLedger"  Title="Monthly Ledger" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Monthly Ledger</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row">
    <div id="view1" data-controller="MonthlyLedgerReport"></div>
  </div>
</asp:Content>