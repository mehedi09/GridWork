﻿<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="trnInvoice.aspx.cs" Inherits="Pages_trnInvoice"  Title="Invoice" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Invoice</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" ShowStartingNode="false" StartFromCurrentNode="true" />
  <asp:TreeView ID="TreeView1" runat="server" DataSourceID="SiteMapDataSource1" CssClass="TreeView" ImageSet="Simple" />
</asp:Content>