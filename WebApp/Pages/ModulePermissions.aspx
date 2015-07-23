<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ModulePermissions.aspx.cs" Inherits="Pages_ModulePermissions"  Title="Module Permissions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Module Permissions</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row">
    <div id="view3" data-controller="Modules" data-view="grid1" data-show-in-summary="true"></div>
    <div id="view2" data-controller="MenuInRule" data-view="grid1" data-show-in-summary="true"></div>
    <div id="view1" data-controller="MenuInUser" data-view="grid1" data-show-in-summary="true"></div>
  </div>
</asp:Content>