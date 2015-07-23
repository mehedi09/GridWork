<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ChequeVoidReport.aspx.cs" Inherits="Pages_ChequeVoidReport"  Title="Cheque Void Report" %>
<%@ Register Src="../Controls/ChequeVoidReport.ascx" TagName="ChequeVoidReport"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Cheque Void Report</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row" data-width="100%"><uc:ChequeVoidReport ID="control1" runat="server"></uc:ChequeVoidReport></div>
</asp:Content>