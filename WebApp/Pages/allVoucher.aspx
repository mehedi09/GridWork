<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="allVoucher.aspx.cs" Inherits="Pages_allVoucher"  Title="Voucher Entry (One Form)" %>
<%@ Register Src="../Controls/ContraVoucher.ascx" TagName="ContraVoucher"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Voucher Entry (One Form)</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:ContraVoucher ID="control1" runat="server"></uc:ContraVoucher></div>
</asp:Content>