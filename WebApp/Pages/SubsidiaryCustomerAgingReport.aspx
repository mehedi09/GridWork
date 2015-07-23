<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="SubsidiaryCustomerAgingReport.aspx.cs" Inherits="Pages_SubsidiaryCustomerAgingReport"  Title="Customer Aging Report" %>
<%@ Register Src="../Controls/SubsidiaryCustomerAgingReport.ascx" TagName="SubsidiaryCustomerAgingReport"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Customer Aging Report</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:SubsidiaryCustomerAgingReport ID="control1" runat="server"></uc:SubsidiaryCustomerAgingReport></div>
</asp:Content>