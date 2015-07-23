<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="PDCIssueReport.aspx.cs" Inherits="Pages_PDCIssueReport"  Title="PDC Issue Report" %>
<%@ Register Src="../Controls/ChequeIssueRegister.ascx" TagName="ChequeIssueRegister"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">PDC Issue Report</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:ChequeIssueRegister ID="control1" runat="server"></uc:ChequeIssueRegister></div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">PDC Issue Report</div>
    </div>
  </div>
</asp:Content>