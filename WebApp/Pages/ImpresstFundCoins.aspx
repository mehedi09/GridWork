<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ImpresstFundCoins.aspx.cs" Inherits="Pages_ImpresstFundCoins"  Title="Impresst Fund Coins" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Impresst Fund Coins</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="column" data-width="50%">
    <div id="view5" data-controller="ImpresstFundCoinsview" data-refresh-interval="3"></div>
  </div>
  <div data-flow="column" data-width="50%">
    <div id="view4" data-controller="ImpresstFundCoins" data-view="grid1" data-show-in-summary="true" data-start-command-name="New"></div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows impresst fund coins management.</div>
    </div>
  </div>
</asp:Content>