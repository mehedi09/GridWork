<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="OpenningBalanceEntry.aspx.cs" Inherits="Pages_OpenningBalanceEntry"  Title="Openning Balance Entry" %>
<%@ Register Src="../Controls/OpeningBalanceEntry.ascx" TagName="OpeningBalanceEntry"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Openning Balance Entry</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:OpeningBalanceEntry ID="control1" runat="server"></uc:OpeningBalanceEntry></div>
</asp:Content>