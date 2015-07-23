<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="BillRegisterDetails.aspx.cs" Inherits="Pages_BillRegisterDetails"  Title="Bill Register Details" %>
<%@ Register Src="../Controls/BillRegDetails.ascx" TagName="BillRegDetails"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Bill Register Details</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:BillRegDetails ID="control1" runat="server"></uc:BillRegDetails></div>
</asp:Content>