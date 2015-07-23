<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="rptBankBook.aspx.cs" Inherits="Pages_rptBankBook"  Title="Bank Book" %>
<%@ Register Src="../Controls/BankBook.ascx" TagName="BankBook"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Bank Book</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:BankBook ID="control1" runat="server"></uc:BankBook></div>
</asp:Content>