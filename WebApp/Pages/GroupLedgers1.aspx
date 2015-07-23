<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="GroupLedgers1.aspx.cs" Inherits="Pages_GroupLedgers1"  Title="1st Account Group " %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">1st Account Group </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row">
    <div id="view1" data-controller="CoaControl"></div>
  </div>
</asp:Content>