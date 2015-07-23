<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ProfitAndLoss.aspx.cs" Inherits="Pages_ProfitAndLoss"  Title="Profit and Loss" %>
<%@ Register Src="../Controls/ProfitAndLoss.ascx" TagName="ProfitAndLoss"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Profit and Loss</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row" style="padding-top:8px"><uc:ProfitAndLoss ID="control1" runat="server"></uc:ProfitAndLoss></div>
</asp:Content>