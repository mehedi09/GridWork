<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ChequeHonour.aspx.cs" Inherits="Pages_ChequeHonour"  Title="Customer Cheque Management" %>
<%@ Register Src="../Controls/ChequeHonour.ascx" TagName="ChequeHonour"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Customer Cheque Management</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:ChequeHonour ID="control1" runat="server"></uc:ChequeHonour></div>
</asp:Content>