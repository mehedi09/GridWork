<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="InwardPDCEntry.aspx.cs" Inherits="Pages_InwardPDCEntry"  Title="Inward PDC Entry" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Inward PDC Entry</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row">
    <div id="view1" data-controller="PDCIssue"></div>
    <div id="view2" data-controller="PDCIssueDetails" data-view="grid1" data-filter-source="view1" data-filter-fields="PDCRNO" data-page-size="5" data-auto-hide="self" data-show-modal-forms="true"></div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">Inward PDC Entry</div>
    </div>
  </div>
</asp:Content>