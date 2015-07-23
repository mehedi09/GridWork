<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ControlLedgerReport.aspx.cs" Inherits="Pages_ControlLedgerReport"  Title="Control Ledger" %>
<%@ Register Src="../Controls/ControlLedger.ascx" TagName="ControlLedger"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Control Ledger</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:ControlLedger ID="control1" runat="server"></uc:ControlLedger></div>
</asp:Content>