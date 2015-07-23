<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="CashReceipt.aspx.cs" Inherits="Pages_CashReceipt"  Title="Cash Receipt" %>
<%@ Register Src="../Controls/CashReceipts.ascx" TagName="CashReceipts"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Cash Receipt</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:CashReceipts ID="control1" runat="server"></uc:CashReceipts></div>
</asp:Content>