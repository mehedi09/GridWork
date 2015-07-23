<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="AccBillRegisterD.aspx.cs" Inherits="Pages_AccBillRegisterD"  Title="Acc Bill Register D" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Acc Bill Register D</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row">
    <div id="view1" data-controller="AccBillRegisterD" data-view="grid1" data-show-in-summary="true"></div>
  </div>
  <div data-flow="row">
    <div data-activator="Tab|Acc Bill Register D">
      <div id="view2" data-controller="AccBillRegisterD" data-view="grid1" data-filter-source="view1" data-filter-fields="RegDetailsID" data-page-size="5" data-auto-hide="container"></div>
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows acc bill register d management.</div>
    </div>
  </div>
</asp:Content>