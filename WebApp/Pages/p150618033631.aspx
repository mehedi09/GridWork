﻿<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="p150618033631.aspx.cs" Inherits="Pages_p150618033631"  Title="New Pages" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">New Pages</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" ShowStartingNode="false" StartFromCurrentNode="true" />
  <asp:TreeView ID="TreeView1" runat="server" DataSourceID="SiteMapDataSource1" CssClass="TreeView" ImageSet="Simple" />
</asp:Content>