<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ChequeIssuRegister.aspx.cs" Inherits="Pages_ChequeIssuRegister"  Title="Cheque Issue Register" %>
<%@ Register Src="../Controls/ChequeIssueRegister.ascx" TagName="ChequeIssueRegister"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Cheque Issue Register</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row" data-width="100%"><uc:ChequeIssueRegister ID="control1" runat="server"></uc:ChequeIssueRegister></div>
</asp:Content>