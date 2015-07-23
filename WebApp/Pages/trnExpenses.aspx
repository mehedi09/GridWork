<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="trnExpenses.aspx.cs" Inherits="Pages_trnExpenses"  Title="Expenses" %>
<%@ Register Src="../Controls/CashPayment.ascx" TagName="CashPayment"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Expenses</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:CashPayment ID="control1" runat="server"></uc:CashPayment></div>
</asp:Content>