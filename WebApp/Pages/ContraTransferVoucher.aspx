<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ContraTransferVoucher.aspx.cs" Inherits="Pages_ContraTransferVoucher"  Title="Contra/Transfer Voucher" %>
<%@ Register Src="../Controls/CashPayment.ascx" TagName="CashPayment"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Contra/Transfer Voucher</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:CashPayment ID="control1" runat="server"></uc:CashPayment></div>
</asp:Content>