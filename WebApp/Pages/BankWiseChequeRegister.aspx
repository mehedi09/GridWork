<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="BankWiseChequeRegister.aspx.cs" Inherits="Pages_BankWiseChequeRegister"  Title="Bank Wise Cheque Register" %>
<%@ Register Src="../Controls/BankWiseChequeRegister.ascx" TagName="BankWiseChequeRegister"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Bank Wise Cheque Register</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:BankWiseChequeRegister ID="control1" runat="server"></uc:BankWiseChequeRegister></div>
</asp:Content>