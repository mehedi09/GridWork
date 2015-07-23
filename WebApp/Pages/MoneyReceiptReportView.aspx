<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="MoneyReceiptReportView.aspx.cs" Inherits="Pages_MoneyReceiptReportView"  Title="MoneyReceiptReportView" %>
<%@ Register Src="../Controls/MoneyReceiptView.ascx" TagName="MoneyReceiptView"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">MoneyReceiptReportView</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:MoneyReceiptView ID="control1" runat="server"></uc:MoneyReceiptView></div>
</asp:Content>