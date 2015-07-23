<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="trnDepositCash.aspx.cs" Inherits="Pages_trnDepositCash"  Title="Deposit Cash" %>
<%@ Register Src="../Controls/BankReceipt.ascx" TagName="BankReceipt"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Deposit Cash</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:BankReceipt ID="control1" runat="server"></uc:BankReceipt></div>
</asp:Content>