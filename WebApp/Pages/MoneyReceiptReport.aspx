<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="MoneyReceiptReport.aspx.cs" Inherits="Pages_MoneyReceiptReport"  Title="Money Receipt Report" %>
<%@ Register Src="../Controls/MoneyReceiptReport.ascx" TagName="MoneyReceiptReport"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Money Receipt Report</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row" data-width="100%"><uc:MoneyReceiptReport ID="control1" runat="server"></uc:MoneyReceiptReport></div>
</asp:Content>