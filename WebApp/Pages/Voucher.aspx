<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Voucher.aspx.cs" Inherits="Pages_Voucher"  Title="Voucher" %>
<%@ Register Src="../Controls/VoucherForm.ascx" TagName="VoucherForm"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Voucher</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:VoucherForm ID="control1" runat="server"></uc:VoucherForm></div>
</asp:Content>