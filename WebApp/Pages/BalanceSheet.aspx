<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="BalanceSheet.aspx.cs" Inherits="Pages_BalanceSheet"  Title="Balance Sheet" %>
<%@ Register Src="../Controls/balancesheet1.ascx" TagName="balancesheet1"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Balance Sheet</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:balancesheet1 ID="control1" runat="server"></uc:balancesheet1></div>
</asp:Content>