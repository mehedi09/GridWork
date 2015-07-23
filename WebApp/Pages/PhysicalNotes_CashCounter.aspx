<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="PhysicalNotes_CashCounter.aspx.cs" Inherits="Pages_PhysicalNotes_CashCounter"  Title="Notes/Cash Counter" %>
<%@ Register Src="../Controls/CashCounter.ascx" TagName="CashCounter"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Notes/Cash Counter</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:CashCounter ID="control1" runat="server"></uc:CashCounter></div>
</asp:Content>