<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ImpresstFundReport.aspx.cs" Inherits="Pages_ImpresstFundReport"  Title="Impresst Fund" %>
<%@ Register Src="../Controls/ImprestFundReimbursmentBill.ascx" TagName="ImprestFundReimbursmentBill"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Impresst Fund</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:ImprestFundReimbursmentBill ID="control1" runat="server"></uc:ImprestFundReimbursmentBill></div>
</asp:Content>