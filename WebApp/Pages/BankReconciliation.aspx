<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="BankReconciliation.aspx.cs" Inherits="Pages_BankReconciliation"  Title="Bank Reconciliation" %>
<%@ Register Src="../Controls/BankReconciliation.ascx" TagName="BankReconciliation"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Bank Reconciliation</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:BankReconciliation ID="control1" runat="server"></uc:BankReconciliation></div>
</asp:Content>