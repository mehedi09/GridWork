<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="BillRegister2.aspx.cs" Inherits="Pages_BillRegister2"  Title="Bill Register 2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Bill Register 2</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row">
    <div id="view1" data-controller="AccBillRegisterH"></div>
    <div id="view2" data-controller="AccBillRegisterD" data-view="grid1" data-filter-source="view1" data-filter-fields="RegID" data-page-size="5" data-auto-hide="self" data-show-modal-forms="true"></div>
  </div>
</asp:Content>