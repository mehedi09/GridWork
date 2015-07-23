<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Currencys.aspx.cs" Inherits="Pages_Currencys"  Title="Currency Setup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Currency Setup</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row">
    <div id="view1" data-controller="AccCurrencys" data-view="grid1" data-show-in-summary="true"></div>
  </div>
</asp:Content>