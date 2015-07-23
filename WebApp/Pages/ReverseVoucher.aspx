<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ReverseVoucher.aspx.cs" Inherits="Pages_ReverseVoucher"  Title="Reverse Voucher" %>
<%@ Register Src="../Controls/ReverseVoucher.ascx" TagName="ReverseVoucher"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Reverse Voucher</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row" data-width="100%"><uc:ReverseVoucher ID="control1" runat="server"></uc:ReverseVoucher></div>
</asp:Content>