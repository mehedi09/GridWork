<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ChartsOfAccounts2nd.aspx.cs" Inherits="Pages_ChartsOfAccounts2nd"  Title="Charts Of Accounts" %>
<%@ Register Src="../Controls/ChartOFAccounts2nd.ascx" TagName="ChartOFAccounts2nd"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Charts Of Accounts</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:ChartOFAccounts2nd ID="control1" runat="server"></uc:ChartOFAccounts2nd></div>
</asp:Content>