<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="PDCRReportVeiw.aspx.cs" Inherits="Pages_PDCRReportVeiw"  Title="PDCRReport Veiw" %>
<%@ Register Src="../Controls/PDCRReportVeiw.ascx" TagName="PDCRReportVeiw"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">PDCRReport Veiw</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><uc:PDCRReportVeiw ID="control1" runat="server"></uc:PDCRReportVeiw></div>
</asp:Content>