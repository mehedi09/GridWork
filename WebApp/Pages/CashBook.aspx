<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="CashBook.aspx.cs" Inherits="Pages_CashBook"  Title="Cash Book" %>
<%@ Register Src="../Controls/CashBook.ascx" TagName="CashBook"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Cash Book</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:CashBook ID="control1" runat="server"></uc:CashBook></div>
</asp:Content>