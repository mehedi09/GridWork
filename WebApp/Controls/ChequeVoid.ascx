<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ChequeVoid.ascx.cs" Inherits="Controls_ChequeVoid"  %>
<script src="http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.7.js" type="text/javascript"></script>
    <script src="http://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.16/jquery-ui.js" type="text/javascript"></script>
    <link href="http://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.16/themes/humanity/jquery-ui.css" rel="stylesheet" type="text/css" />
 <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.4/jquery.min.js"
type = "text/javascript"></script>
<script src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8/jquery-ui.min.js"
type = "text/javascript"></script>
<link href="../Scripts/jquery_ui.css" rel="stylesheet" />
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <%--   <div style="margin: 2px; border: solid 1px silver; padding: 8px;">uc:FilterDropdown</div>--%>
        <div style="margin-bottom: 4px">
            <asp:HiddenField ID="hd1" runat="server" /> 
            <asp:Button ID="Button1" runat="server" Text="Void Cheque"  />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
  <div id="ChequeVoid" runat="server">
</div>
<aquarium:DataViewExtender ID="grid1" runat="server" TargetControlID="ChequeVoid"
    Controller="AccTrnDetailForChequeVoid" SelectionMode="Multiple" ShowActionBar="false" ShowDescription="false" ShowQuickFind="false" ShowSearchBar="false" ShowViewSelector="false" />      
<script type="text/javascript">
    $(document).ready(function () {

               $('#<%=Button1.ClientID %>').click(function () {

                       var selectedItems = "";

    $(".AccTrnDetailForChequeVoid_grid1 input[type=checkbox]:checked").each(function () {
        
        selectedItems += $(this).closest('tr').find('td:last').prev().text() + ",";
    });
    //alert(selectedItems);
    var removeLastChar = function (value, char) {
                var lastChar = value.slice(-1);
                if (lastChar == char) {
                    value = value.slice(1, -1);
                }
                return value;
            }


            var result = removeLastChar(selectedItems, ',');
           
            if (result == "") {
                alert("Please select checkbox  from table ");
                return;
            }
            $.ajax({
                type: "POST",
                url: "../Pages/ChequeVoid.aspx/CreateVoid",
                data: '{serialno: "' + result + '"}',
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function OnSuccess(response) {
                    alert('Cheque void successfully');
                    
                    location.reload();
                },
                failure: function (response) {

                    //alert(response.d);
                }
            });



        });


       

    })


    var prm = Sys.WebForms.PageRequestManager.getInstance();

    prm.add_endRequest(function () {



        $('#<%=Button1.ClientID %>').click(function () {

            var selectedItems = "";

            $(".AccTrnDetailForChequeVoid_grid1 input[type=checkbox]:checked").each(function () {
               
                selectedItems += $(this).closest('tr').find('td:last').prev().text() + ",";
            });
            //alert(selectedItems);
            var removeLastChar = function (value, char) {
                var lastChar = value.slice(-1);
                if (lastChar == char) {
                    value = value.slice(1, -1);
                }
                return value;
            }


            var result = removeLastChar(selectedItems, ',');
            
            if (result == "") {
                alert("Please select checkbox  from table ");
                return;
            }
            $.ajax({
                type: "POST",
                url: "../Pages/ChequeVoid.aspx/CreateVoid",
                data: '{serialno: "' + result + '"}',
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function OnSuccess(response) {
                    alert('Cheque void successfully');

                    location.reload();
                },
                failure: function (response) {

                    //alert(response.d);
                }
            });



        });



    });

</script>