<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Paycategory.aspx.cs" Inherits="Pages_Paycategory"  Title="Paycategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Paycategory</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row">
    <div id="view1" data-controller="Paycategory" data-view="grid1" data-show-in-summary="true"></div>
  </div>
  <div data-flow="row">
    <div data-activator="Tab|Money Receipts">
      <div id="view2" data-controller="MoneyReceipts" data-view="grid1" data-filter-source="view1" data-filter-fields="PayCatID" data-page-size="5" data-auto-hide="container"></div>
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows paycategory management.</div>
    </div>
  </div>
</asp:Content>