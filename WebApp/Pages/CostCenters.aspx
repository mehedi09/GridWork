<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="CostCenters.aspx.cs" Inherits="Pages_CostCenters"  Title="Sub Ledger Accounts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Sub Ledger Accounts</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row">
    <div data-activator="Tab|Sub Ledger Accounts">
      <div id="view3" data-controller="AccSubNames" data-view="grid1" data-filter-fields="AccSubTypeID" data-page-size="5" data-auto-hide="self" data-show-modal-forms="true"></div>
    </div>
  </div>
</asp:Content>