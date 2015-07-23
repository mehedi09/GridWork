<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ImpresstFundTrans.aspx.cs" Inherits="Pages_ImpresstFundTrans"  Title="Impresst Fund Transaction" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Impresst Fund Transaction</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"></div>
  <div data-flow="row">
    <div id="view2" data-controller="ImpresstFundTrans" data-view="grid1" data-show-in-summary="true"></div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows impresst fund transaction management.</div>
    </div>
  </div>
</asp:Content>