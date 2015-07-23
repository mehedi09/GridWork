<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Pages_Home"  Title="^HomeTitle^Start^HomeTitle^" %>
<%@ Register Src="../Controls/TableOfContents.ascx" TagName="TableOfContents"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">^HomeTitle^Start^HomeTitle^</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="column" data-width="50%">
    <div class="DataViewHeader">Voucher Created</div>
    <div id="view1" data-controller="AccTrnHeaderChart"></div>
  </div>
  <div data-flow="column" data-width="50%"><uc:TableOfContents ID="control1" runat="server"></uc:TableOfContents></div>
</asp:Content>