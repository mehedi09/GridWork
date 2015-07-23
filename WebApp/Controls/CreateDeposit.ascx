<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CreateDeposit.ascx.cs" Inherits="Controls_CreateDeposit"  %>
<!-- 
    This section provides a sample markup for Desktop user inteface.
-->
<asp:UpdatePanel ID="UpdatePanel1" runat="server"><ContentTemplate><div style="margin:2px;border: solid 1px silver;padding:8px;">uc:CreateDeposit</div></ContentTemplate></asp:UpdatePanel>
<!-- 
    This section provides a sample markup for Touch UI user interface. 
-->
<div id="CreateDeposit" data-app-role="page" data-activator="Button|CreateDeposit">
  <p>
            Markup of <i>CreateDeposit</i> custom user control for Touch UI.
          </p>
</div>
        
<script type="text/javascript">
    (function() {
        if ($app.touch)
            $(document).one('start.app', function () {
                // The page of Touch UI application is ready to be configured
        });
    })();
</script>
