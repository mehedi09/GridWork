<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="LCLedgerReport.aspx.cs" Inherits="Pages_LCLedgerReport"  Title="Ledger Report" %>
<%@ Register Src="../Controls/LCLedgerReport.ascx" TagName="LCLedgerReport"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Ledger Report</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row" data-width="100%"><uc:LCLedgerReport ID="control1" runat="server"></uc:LCLedgerReport></div>
</asp:Content>