<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Payee_wiseReport.aspx.cs" Inherits="Pages_Payee_wiseReport"  Title="Payee-wise Report" %>
<%@ Register Src="../Controls/PayeeWiseChequeRegister.ascx" TagName="PayeeWiseChequeRegister"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Payee-wise Report</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:PayeeWiseChequeRegister ID="control1" runat="server"></uc:PayeeWiseChequeRegister></div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">Cheque Book-wise Report</div>
    </div>
  </div>
</asp:Content>