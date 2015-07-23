<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="CustomerLedgerSchedule_1.aspx.cs" Inherits="Pages_CustomerLedgerSchedule_1"  Title="Customer Trial Balance" %>
<%@ Register Src="../Controls/CustomerLedgerSchedule.ascx" TagName="CustomerLedgerSchedule"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Customer Trial Balance</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:CustomerLedgerSchedule ID="control1" runat="server"></uc:CustomerLedgerSchedule></div>
</asp:Content>