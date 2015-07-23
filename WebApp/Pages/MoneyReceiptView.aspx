<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="MoneyReceiptView.aspx.cs" Inherits="Pages_MoneyReceiptView"  Title="Money Receipt View" %>
<%@ Register Src="../Controls/MoneyReceiptView.ascx" TagName="MoneyReceiptView"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Money Receipt View</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:MoneyReceiptView ID="control1" runat="server"></uc:MoneyReceiptView></div>
</asp:Content>