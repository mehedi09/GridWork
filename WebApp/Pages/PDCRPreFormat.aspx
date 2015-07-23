<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="PDCRPreFormat.aspx.cs" Inherits="Pages_PDCRPreFormat"  Title="PDCR Pre Format" %>
<%@ Register Src="../Controls/PDCRPrint.ascx" TagName="PDCRPrint"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">PDCR Pre Format</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:PDCRPrint ID="control1" runat="server"></uc:PDCRPrint></div>
</asp:Content>