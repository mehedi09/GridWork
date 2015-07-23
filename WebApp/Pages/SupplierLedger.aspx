<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="SupplierLedger.aspx.cs" Inherits="Pages_SupplierLedger"  Title="Supplier Ledger" %>
<%@ Register Src="../Controls/SupplierLedger.ascx" TagName="SupplierLedger"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Supplier Ledger</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:SupplierLedger ID="control1" runat="server"></uc:SupplierLedger></div>
</asp:Content>