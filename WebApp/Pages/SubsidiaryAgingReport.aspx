<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="SubsidiaryAgingReport.aspx.cs" Inherits="Pages_SubsidiaryAgingReport"  Title="Supplier Aging Report" %>
<%@ Register Src="../Controls/SubsidiaryAgingReport.ascx" TagName="SubsidiaryAgingReport"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Supplier Aging Report</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row" data-width="100%"><uc:SubsidiaryAgingReport ID="control1" runat="server"></uc:SubsidiaryAgingReport></div>
</asp:Content>