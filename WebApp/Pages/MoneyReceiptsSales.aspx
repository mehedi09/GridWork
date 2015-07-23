<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="MoneyReceiptsSales.aspx.cs" Inherits="Pages_MoneyReceiptsSales"  Title="Money Receipts (General)" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Money Receipts (General)</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row">
    <div id="view1" data-controller="MoneyReceiptsGeneral"></div>
  </div>
</asp:Content>