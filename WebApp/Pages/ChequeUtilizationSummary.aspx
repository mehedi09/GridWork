<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ChequeUtilizationSummary.aspx.cs" Inherits="Pages_ChequeUtilizationSummary"  Title="Cheque Utilization Summary" %>
<%@ Register Src="../Controls/ChequeUtilizationSummary.ascx" TagName="ChequeUtilizationSummary"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Cheque Utilization Summary</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row" data-width="100%"><uc:ChequeUtilizationSummary ID="control1" runat="server"></uc:ChequeUtilizationSummary></div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">Cheque Utilization Summary</div>
    </div>
  </div>
</asp:Content>