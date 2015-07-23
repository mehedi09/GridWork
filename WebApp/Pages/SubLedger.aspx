<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="SubLedger.aspx.cs" Inherits="Pages_SubLedger"  Title="Sub Ledger Item" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Sub Ledger Item</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row">
    <div id="view1" data-controller="AccSubTypes" data-view="grid1" data-show-in-summary="true"></div>
  </div>
</asp:Content>