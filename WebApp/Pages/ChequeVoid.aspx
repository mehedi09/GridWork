<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ChequeVoid.aspx.cs" Inherits="Pages_ChequeVoid"  Title="Cheque Void / Cancellation" %>
<%@ Register Src="../Controls/ChequeVoid.ascx" TagName="ChequeVoid"  TagPrefix="uc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Cheque Void / Cancellation</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
    <div data-flow="row"><uc:ChequeVoid ID="control1" runat="server"></uc:ChequeVoid></div>
</asp:Content>