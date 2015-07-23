<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ChequeBooks.aspx.cs" Inherits="Pages_ChequeBooks"  Title="Cheque Book Receive" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Cheque Book Receive</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row">
    <div id="view1" data-controller="ChequeBooks" data-view="grid1" data-show-in-summary="true"></div>
    <div id="view2" data-controller="ChequeBooksLeaf" data-view="grid1" data-filter-source="view1" data-filter-fields="ChequeBookID" data-page-size="5" data-auto-hide="self" data-show-modal-forms="true"></div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows cheque books management.</div>
    </div>
  </div>
</asp:Content>