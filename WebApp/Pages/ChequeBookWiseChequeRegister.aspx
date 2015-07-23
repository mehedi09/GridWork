<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ChequeBookWiseChequeRegister.aspx.cs" Inherits="Pages_ChequeBookWiseChequeRegister"  Title="Cheque Book Wise Cheque Register" %>
<%@ Register Src="../Controls/ChequeBookWiseChequeRegister.ascx" TagName="ChequeBookWiseChequeRegister"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Cheque Book Wise Cheque Register</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:ChequeBookWiseChequeRegister ID="control1" runat="server"></uc:ChequeBookWiseChequeRegister></div>
</asp:Content>