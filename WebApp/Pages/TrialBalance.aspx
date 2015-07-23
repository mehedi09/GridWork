<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="TrialBalance.aspx.cs" Inherits="Pages_TrialBalance"  Title="Trial Balance" %>
<%@ Register Src="../Controls/TrialBalance.ascx" TagName="TrialBalance"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Trial Balance</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:TrialBalance ID="control1" runat="server"></uc:TrialBalance></div>
</asp:Content>