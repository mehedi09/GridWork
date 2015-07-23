<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ChequePrint.ascx.cs" Inherits="Controls_ChequePrint"  %>
<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!-- 
    This section provides a sample markup for Desktop user inteface.
-->
<asp:UpdatePanel ID="UpdatePanel1" runat="server"><ContentTemplate><div style="margin:2px;border: solid 1px silver;padding:8px;">
    <asp:Button ID="Button1" runat="server" Text="Return To Cheque Print" OnClick="Button1_Click" />
    <asp:HiddenField ID="AccFundID" runat="server" />
    <asp:HiddenField ID="VchrTypeID" runat="server" />
    <asp:HiddenField ID="RevAcc" runat="server" />
     <asp:HiddenField ID="VchrNo" runat="server" />
    <asp:HiddenField ID="ChequeDT" runat="server" />
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" SizeToReportContent="True"></rsweb:ReportViewer>
   </div></ContentTemplate></asp:UpdatePanel>