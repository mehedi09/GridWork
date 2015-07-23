<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="CustomerLedger.aspx.cs" Inherits="Pages_CustomerLedger"  Title="Customer Ledger" %>
<%@ Register Src="../Controls/CustomerLedger.ascx" TagName="CustomerLedger"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Customer Ledger</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:CustomerLedger ID="control1" runat="server"></uc:CustomerLedger></div>
</asp:Content>