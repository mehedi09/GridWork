<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="SalesJournal.aspx.cs" Inherits="Pages_SalesJournal"  Title="Sales Journal" %>
<%@ Register Src="../Controls/SalesJournal.ascx" TagName="SalesJournal"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Sales Journal</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row" data-width="100%"><uc:SalesJournal ID="control1" runat="server"></uc:SalesJournal></div>
</asp:Content>