<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MoneyReceiptView.ascx.cs" Inherits="Controls_MoneyReceiptView"  %>
<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!-- 
    This section provides a sample markup for Desktop user inteface.
-->
<asp:UpdatePanel ID="UpdatePanel1" runat="server"><ContentTemplate><div style="margin:2px;border: solid 1px silver;padding:8px;">
    <asp:Button ID="Button1" runat="server" Text="Return To Money Receipt" OnClick="Button1_Click" />
    <asp:HiddenField ID="hdmoney" runat="server" />
    <asp:HiddenField ID="hdapplicant" runat="server" />
    <asp:HiddenField ID="hdType" runat="server" />
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" SizeToReportContent="True"></rsweb:ReportViewer>
   </div></ContentTemplate></asp:UpdatePanel>
