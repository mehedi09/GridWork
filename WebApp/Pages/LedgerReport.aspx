<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="LedgerReport.aspx.cs" Inherits="Pages_LedgerReport"  Title="Ledger Report" %>
<%@ Register Src="../Controls/LedgerControl.ascx" TagName="LedgerControl"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Ledger Report</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:LedgerControl ID="control1" runat="server"></uc:LedgerControl></div>
</asp:Content>