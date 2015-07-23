<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="rptBankVoucher.ascx.cs" Inherits="Controls_rptBankVoucher" %>
<!-- 
    This section provides a sample markup for Desktop user inteface.
-->
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>

        <div>
            <rsweb:ReportViewer ID="ReportViewer1" runat="server" SizeToReportContent="True"></rsweb:ReportViewer>
        </div>

    </ContentTemplate>
</asp:UpdatePanel>

<div id="rptBankVoucher" data-app-role="page" data-activator="Button|rptBankVoucher">
    <p>
        Markup of <i>rptBankVoucher</i> custom user control for Touch UI.
    </p>
</div>

<script type="text/javascript">
    (function () {
        if ($app.touch)
            $(document).one('start.app', function () {
                // The page of Touch UI application is ready to be configured
            });
    })();
</script>
