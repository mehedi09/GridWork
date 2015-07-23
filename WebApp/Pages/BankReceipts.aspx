<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="BankReceipts.aspx.cs" Inherits="Pages_BankReceipts"  Title="Bank Receipts" %>
<%@ Register Src="../Controls/BankReceipt.ascx" TagName="BankReceipt"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Bank Receipts</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:BankReceipt ID="control1" runat="server"></uc:BankReceipt></div>
</asp:Content>