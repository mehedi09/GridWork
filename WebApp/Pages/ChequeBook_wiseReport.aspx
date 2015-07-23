<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ChequeBook_wiseReport.aspx.cs" Inherits="Pages_ChequeBook_wiseReport"  Title="Cheque Book-wise Report" %>
<%@ Register Src="../Controls/ChequeBookWiseChequeRegister.ascx" TagName="ChequeBookWiseChequeRegister"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Cheque Book-wise Report</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:ChequeBookWiseChequeRegister ID="control1" runat="server"></uc:ChequeBookWiseChequeRegister></div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">Cheque Book-wise Report</div>
    </div>
  </div>
</asp:Content>