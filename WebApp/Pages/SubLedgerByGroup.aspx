<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="SubLedgerByGroup.aspx.cs" Inherits="Pages_SubLedgerByGroup"  Title="Sub Ledger By Group" %>
<%@ Register Src="../Controls/SubLedgerByGroup.ascx" TagName="SubLedgerByGroup"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Sub Ledger By Group</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row" data-width="100%"><uc:SubLedgerByGroup ID="control1" runat="server"></uc:SubLedgerByGroup></div>
</asp:Content>