<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="OpeningBalanceEntryOther.aspx.cs" Inherits="Pages_OpeningBalanceEntryOther"  Title="Opening Balance Entry(Other)" %>
<%@ Register Src="../Controls/OpeningBalanceEntryOther.ascx" TagName="OpeningBalanceEntryOther"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Opening Balance Entry(Other)</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:OpeningBalanceEntryOther ID="control1" runat="server"></uc:OpeningBalanceEntryOther></div>
</asp:Content>