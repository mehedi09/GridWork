<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="SubsidiaryLedger_1.aspx.cs" Inherits="Pages_SubsidiaryLedger_1"  Title="Subsidiary Ledger" %>
<%@ Register Src="../Controls/SubsidiaryLedger.ascx" TagName="SubsidiaryLedger"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Subsidiary Ledger</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:SubsidiaryLedger ID="control1" runat="server"></uc:SubsidiaryLedger></div>
</asp:Content>