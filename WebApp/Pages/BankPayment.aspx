<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="BankPayment.aspx.cs" Inherits="Pages_BankPayment"  Title="Bank Payment" %>
<%@ Register Src="../Controls/BankPayment.ascx" TagName="BankPayment"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Bank Payment</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:BankPayment ID="control1" runat="server"></uc:BankPayment></div>
</asp:Content>