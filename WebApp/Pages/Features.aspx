<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Features.aspx.cs" Inherits="Pages_Features"  Title="Features" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Features</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row">
    <div id="view1" data-controller="CompFeature" data-view="grid1" data-show-in-summary="true" data-search-on-start="true"></div>
  </div>
</asp:Content>