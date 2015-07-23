<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="SubsidiaryLedgerShedule_1.aspx.cs" Inherits="Pages_SubsidiaryLedgerShedule_1"  Title="Subsidiary Ledger Shedule" %>
<%@ Register Src="../Controls/SubsidiaryLedgerShedule.ascx" TagName="SubsidiaryLedgerShedule"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Subsidiary Ledger Shedule</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:SubsidiaryLedgerShedule ID="control1" runat="server"></uc:SubsidiaryLedgerShedule></div>
</asp:Content>