<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ChartOFAccounts2nd.ascx.cs" Inherits="Controls_ChartOFAccounts2nd" %>
<script type="text/javascript" src="http://code.jquery.com/jquery.js"></script>

<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <div style="margin-bottom: 4px">
           <input type='radio' name='rd1' id="rd1" value='1' checked="checked">  <asp:Label ID="Label1" runat="server" Text="Ist Group Ledger"></asp:Label>   
          <input type='radio' name='rd2' id="rd2" value='2'> <asp:Label ID="Label2" runat="server" Text="2nd Group Ledger"></asp:Label>  
        <input type='radio' name='rd3' id="rd3" value='3'>   <asp:Label ID="Label3" runat="server" Text="3rd Group Ledger"></asp:Label>  

         <input type='radio' name='rd4' id="rd4" value='4'>   <asp:Label ID="Label4" runat="server" Text="G/L Accounts"></asp:Label> 
           
            <%-- <asp:Button ID="Button2" runat="server" Text="Cheque dishonour"  />--%>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
<!-- 
    This section provides a sample markup for Touch UI user interface. 
-->
<div id="Istdiv" runat="server">
</div>
<aquarium:DataViewExtender ID="grid1" runat="server" TargetControlID="Istdiv"
    Controller="CoaControl1"  ShowActionBar="true" ShowDescription="false" ShowQuickFind="false"  ShowViewSelector="false"  />
<div id="Seconddiv" runat="server" >
</div>
<aquarium:DataViewExtender ID="grid2" runat="server" TargetControlID="Seconddiv" 
    Controller="CoaMain1"  ShowActionBar="true" ShowDescription="false" ShowQuickFind="false"  ShowViewSelector="false" />
<div id="ThirdDiv" runat="server" >
</div>
<aquarium:DataViewExtender ID="grid3" runat="server" TargetControlID="ThirdDiv" 
    Controller="CoaSub1"  ShowActionBar="true" ShowDescription="false" ShowQuickFind="false"  ShowViewSelector="false" />
<div id="ForthDiv" runat="server" >
</div>
<aquarium:DataViewExtender ID="grid4" runat="server" TargetControlID="ForthDiv"  
    Controller="CoaDetail"  ShowActionBar="true" ShowDescription="false" ShowQuickFind="false"  ShowViewSelector="false" />
<script type="text/javascript">

    $(document).ready(function () {

        $("#<%=Istdiv.ClientID%>").show();
        $("#<%=Seconddiv.ClientID%>").hide();
        $("#<%=ThirdDiv.ClientID%>").hide();
        $("#<%=ForthDiv.ClientID%>").hide();
        $('#rd1').attr('checked', true);
        $('#rd2').attr('checked', false);
        $('#rd3').attr('checked', false);
        $('#rd4').attr('checked', false);

        $('input[type="radio"]').click(function () {

            if ($(this).attr("value") == "1") {

                $("#<%=Istdiv.ClientID%>").show();
                $("#<%=Seconddiv.ClientID%>").hide();
                $("#<%=ThirdDiv.ClientID%>").hide();
                $("#<%=ForthDiv.ClientID%>").hide();
                $('#rd1').attr('checked', true);
                $('#rd2').attr('checked', false);
                $('#rd3').attr('checked', false);
                $('#rd4').attr('checked', false);
               

            }

            if ($(this).attr("value") == "2") {
                $("#<%=Istdiv.ClientID%>").hide();
                $("#<%=Seconddiv.ClientID%>").show();
                $("#<%=ThirdDiv.ClientID%>").hide();
                $("#<%=ForthDiv.ClientID%>").hide();
                $('#rd1').attr('checked', false);
                $('#rd2').attr('checked', true);
                $('#rd3').attr('checked', false);
                $('#rd4').attr('checked', false);
            }

            if ($(this).attr("value") == "3") {
                $("#<%=Istdiv.ClientID%>").hide();
                $("#<%=Seconddiv.ClientID%>").hide();
                $("#<%=ThirdDiv.ClientID%>").show();
                $("#<%=ForthDiv.ClientID%>").hide();
                $('#rd1').attr('checked', false);
                $('#rd2').attr('checked', false);
                $('#rd3').attr('checked', true);
                $('#rd4').attr('checked', false);

            }
            if ($(this).attr("value") == "4") {
                $("#<%=Istdiv.ClientID%>").hide();
                 $("#<%=Seconddiv.ClientID%>").hide();
                 $("#<%=ThirdDiv.ClientID%>").hide();
                $("#<%=ForthDiv.ClientID%>").show();
                $('#rd1').attr('checked', false);
                $('#rd2').attr('checked', false);
                $('#rd3').attr('checked', false);
                $('#rd4').attr('checked', true);

             }

        });

    });

    var prm = Sys.WebForms.PageRequestManager.getInstance();

    prm.add_endRequest(function () {

        $("#<%=Istdiv.ClientID%>").show();
        $("#<%=Seconddiv.ClientID%>").hide();
        $("#<%=ThirdDiv.ClientID%>").hide();
        $("#<%=ForthDiv.ClientID%>").hide();
        $('#rd1').attr('checked', true);
        $('#rd2').attr('checked', false);
        $('#rd3').attr('checked', false);
        $('#rd4').attr('checked', false);
        $('input[type="radio"]').click(function () {

            if ($(this).attr("value") == "1") {

                $("#<%=Istdiv.ClientID%>").show();
                $("#<%=Seconddiv.ClientID%>").hide();
                $("#<%=ThirdDiv.ClientID%>").hide();
                $("#<%=ForthDiv.ClientID%>").hide();
                $('#rd1').attr('checked', true);
                $('#rd2').attr('checked', false);
                $('#rd3').attr('checked', false);
                $('#rd4').attr('checked', false);


            }

                if ($(this).attr("value") == "2") {
                    $("#<%=Istdiv.ClientID%>").hide();
                $("#<%=Seconddiv.ClientID%>").show();
                $("#<%=ThirdDiv.ClientID%>").hide();
                $("#<%=ForthDiv.ClientID%>").hide();
                $('#rd1').attr('checked', false);
                $('#rd2').attr('checked', true);
                $('#rd3').attr('checked', false);
                $('#rd4').attr('checked', false);
            }

                if ($(this).attr("value") == "3") {
                    $("#<%=Istdiv.ClientID%>").hide();
                $("#<%=Seconddiv.ClientID%>").hide();
                $("#<%=ThirdDiv.ClientID%>").show();
                $("#<%=ForthDiv.ClientID%>").hide();
                $('#rd1').attr('checked', false);
                $('#rd2').attr('checked', false);
                $('#rd3').attr('checked', true);
                $('#rd4').attr('checked', false);

            }
                if ($(this).attr("value") == "4") {
                    $("#<%=Istdiv.ClientID%>").hide();
                $("#<%=Seconddiv.ClientID%>").hide();
                $("#<%=ThirdDiv.ClientID%>").hide();
                $("#<%=ForthDiv.ClientID%>").show();
                $('#rd1').attr('checked', false);
                $('#rd2').attr('checked', false);
                $('#rd3').attr('checked', false);
                $('#rd4').attr('checked', true);

            }

            });

    });

</script>
