<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ChequeIssue.aspx.cs" Inherits="Pages_ChequeIssue"  Title="Cheque Issue" %>
<%@ Register Src="../Controls/ChequeIssue.ascx" TagName="ChequeIssue"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Cheque Issue</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row" data-width="100%"><uc:ChequeIssue ID="control1" runat="server"></uc:ChequeIssue></div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">Cheque Issue</div>
    </div>
  </div>
</asp:Content>