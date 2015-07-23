<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="JournalVoucher.aspx.cs" Inherits="Pages_JournalVoucher"  Title="Journal Voucher" %>
<%@ Register Src="../Controls/JournalVoucher.ascx" TagName="JournalVoucher"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Journal Voucher</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row" data-width="100%"><uc:JournalVoucher ID="control1" runat="server"></uc:JournalVoucher></div>
</asp:Content>