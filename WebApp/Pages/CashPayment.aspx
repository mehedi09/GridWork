<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="CashPayment.aspx.cs" Inherits="Pages_CashPayment"  Title="Cash Voucher" %>
<%@ Register Src="../Controls/CashPayment.ascx" TagName="CashPayment"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Cash Voucher</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row" data-width="100%"><uc:CashPayment ID="control1" runat="server"></uc:CashPayment></div>
</asp:Content>