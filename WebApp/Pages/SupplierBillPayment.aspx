<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="SupplierBillPayment.aspx.cs" Inherits="Pages_SupplierBillPayment"  Title="Supplier Bill Payment" %>
<%@ Register Src="../Controls/BillPay.ascx" TagName="BillPay"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Supplier Bill Payment</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:BillPay ID="control1" runat="server"></uc:BillPay></div>
</asp:Content>