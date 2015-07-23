<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="GroupLedgers2.aspx.cs" Inherits="Pages_GroupLedgers2"  Title="2nd Account Group " %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">2nd Account Group </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row">
    <div id="view2" data-controller="AccFunds" data-view="grid1" data-show-in-summary="true"></div>
    <div id="view1" data-controller="CoaMain" data-view="grid1" data-show-in-summary="true" data-filter-source="view2" data-filter-fields="AccFundID" data-page-size="30" data-refresh-interval="60" data-auto-hide="self" data-show-modal-forms="true" data-show-row-number="true"></div>
  </div>
</asp:Content>