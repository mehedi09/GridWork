﻿<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ChequeBooksLeaf.aspx.cs" Inherits="Pages_ChequeBooksLeaf"  Title="Cheque Books Leaf" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Cheque Books Leaf</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row">
    <div id="view1" data-controller="ChequeBooksLeaf" data-view="grid1" data-show-in-summary="true"></div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows cheque books leaf management.</div>
    </div>
  </div>
</asp:Content>