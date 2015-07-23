<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ReceiptsAndPayments.aspx.cs" Inherits="Pages_ReceiptsAndPayments"  Title="Receipts and Payments" %>
<%@ Register Src="../Controls/ReceiptPayment.ascx" TagName="ReceiptPayment"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Receipts and Payments</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:ReceiptPayment ID="control1" runat="server"></uc:ReceiptPayment></div>
</asp:Content>