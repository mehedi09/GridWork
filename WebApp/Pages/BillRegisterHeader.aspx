<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="BillRegisterHeader.aspx.cs" Inherits="Pages_BillRegisterHeader"  Title="Bill Register Header" %>
<%@ Register Src="../Controls/BillRegHeader.ascx" TagName="BillRegHeader"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Bill Register Header</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:BillRegHeader ID="control1" runat="server"></uc:BillRegHeader></div>
</asp:Content>