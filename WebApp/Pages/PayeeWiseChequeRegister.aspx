<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="PayeeWiseChequeRegister.aspx.cs" Inherits="Pages_PayeeWiseChequeRegister"  Title="Payee Wise Cheque Register" %>
<%@ Register Src="../Controls/PayeeWiseChequeRegister.ascx" TagName="PayeeWiseChequeRegister"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Payee Wise Cheque Register</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:PayeeWiseChequeRegister ID="control1" runat="server"></uc:PayeeWiseChequeRegister></div>
</asp:Content>