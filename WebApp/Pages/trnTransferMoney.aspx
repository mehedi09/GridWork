<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="trnTransferMoney.aspx.cs" Inherits="Pages_trnTransferMoney"  Title="Transfer Money" %>
<%@ Register Src="../Controls/BankPayment.ascx" TagName="BankPayment"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Transfer Money</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:BankPayment ID="control1" runat="server"></uc:BankPayment></div>
</asp:Content>