<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="PDCReceive.aspx.cs" Inherits="Pages_PDCReceive"  Title="PDC Receive" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">PDC Receive</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row">
    <div id="view1" data-controller="PDCReceive" data-view="grid1" data-show-in-summary="true"></div>
  </div>
  <div data-flow="row">
    <div class="DataViewHeader">PDCReceive Details</div>
    <div id="view2" data-controller="PDCReceiveDetails" data-view="grid1" data-filter-source="view1" data-filter-fields="PDCRNO" data-page-size="5" data-auto-hide="container" data-show-modal-forms="true"></div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows pdc receipt management.</div>
    </div>
  </div>
</asp:Content>