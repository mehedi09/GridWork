<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="BillRegister.aspx.cs" Inherits="Pages_BillRegister"  Title="Bill Receive" %>
<%@ Register Src="../Controls/BillEntry.ascx" TagName="BillEntry"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Bill Receive</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row" data-width="100%"><uc:BillEntry ID="control1" runat="server"></uc:BillEntry></div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows bill register management.</div>
    </div>
  </div>
</asp:Content>