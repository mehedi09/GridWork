<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="CompanyInformation.aspx.cs" Inherits="Pages_CompanyInformation"  Title="Company Information" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Company Information</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row">
    <div id="view1" data-controller="AccFunds" data-view="grid1" data-show-in-summary="true"></div>
  </div>
</asp:Content>