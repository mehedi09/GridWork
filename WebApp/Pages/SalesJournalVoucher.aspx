<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="SalesJournalVoucher.aspx.cs" Inherits="Pages_SalesJournalVoucher"  Title="Sales Journal Voucher" %>
<%@ Register Src="../Controls/SalesJournal.ascx" TagName="SalesJournal"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Sales Journal Voucher</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:SalesJournal ID="control1" runat="server"></uc:SalesJournal></div>
</asp:Content>