<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="SupplierLedgerShedule.aspx.cs" Inherits="Pages_SupplierLedgerShedule"  Title="Supplier Trial Balance" %>
<%@ Register Src="../Controls/SubsidiaryLedgerShedule.ascx" TagName="SubsidiaryLedgerShedule"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Supplier Trial Balance</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:SubsidiaryLedgerShedule ID="control1" runat="server"></uc:SubsidiaryLedgerShedule></div>
</asp:Content>