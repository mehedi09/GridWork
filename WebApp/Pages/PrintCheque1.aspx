<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="PrintCheque1.aspx.cs" Inherits="Pages_PrintCheque1"  Title="Print Cheque 1" %>
<%@ Register Src="../Controls/ChequePrint.ascx" TagName="ChequePrint"  TagPrefix="uc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Print Cheque 1</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:ChequePrint ID="control1" runat="server"></uc:ChequePrint></div>
</asp:Content>