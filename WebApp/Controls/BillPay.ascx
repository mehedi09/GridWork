<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BillPay.ascx.cs" Inherits="Controls_BillPay"  %>
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
            <asp:Label ID="Label2" runat="server" Text="Select Ledger : "></asp:Label>
            <asp:DropDownList ID="ddlBankLedger" runat="server"></asp:DropDownList> 
            <asp:Label ID="Label3" runat="server" Text="Cheque Number : "></asp:Label>
             <input  placeholder="Cheque No" type="text" id="txtchequeNumber" runat="server" role="textbox" aria-autocomplete="list" aria-haspopup="true" style="width: 195px" />
           
            <asp:Label ID="Label4" runat="server" Text="Cheque date: "></asp:Label>
            <asp:TextBox runat="server" ID="txtChaqueDate"></asp:TextBox> 
             <asp:Label ID="Label1" runat="server" Text="Total Amount: "></asp:Label>
            <asp:Label ID="lblTotalAmount" runat="server" Text=""></asp:Label> <asp:HiddenField ID="hd1" runat="server" /> 
            <asp:Button ID="Button1" runat="server" Text="Bil payment"  />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>

<div id="PDCDetailsReceive" runat="server">
</div>
<aquarium:DataViewExtender ID="grid1" runat="server" TargetControlID="PDCDetailsReceive"
    Controller="BillRegisterPayment" SelectionMode="Multiple" ShowActionBar="false" ShowDescription="false" ShowQuickFind="false" ShowSearchBar="false" ShowViewSelector="false" />

<script type="text/javascript">
    $(document).ready(function () {

        $("[id$=txtChaqueDate]").datepicker({
            changeMonth: true,
            changeYear: true
        });
        var sum = 0;
        
        $(".BillRegisterPayment_grid1 input:checkbox").live("click", function () {
            if ($(this).is(':checked')) {
                sum = parseInt(sum) + parseInt($(this).closest('tr').find('td:last').prev().text());
            } else {
                sum = parseInt(sum) - parseInt($(this).closest('tr').find('td:last').prev().text());
            }
            $("#<%=lblTotalAmount.ClientID%>").html(sum);
            
        });

        $('#<%=Button1.ClientID %>').click(function () {

            if ($("#<%=ddlBankLedger.ClientID%>")[0].value == "") {
                alert('Please select  Bank Ledger');
                return;
            }
            if ($("#<%=txtchequeNumber.ClientID%>")[0].value == "") {
                alert('Please input cheque number');
                return;
            }
            if ($("#<%=txtChaqueDate.ClientID%>")[0].value == "") {
                alert('Please select  date');
                return;
            }
            

            var selectedItems = "";
            
            $(".BillRegisterPayment_grid1 input[type=checkbox]:checked").each(function () {

                //  selectedItems += $(this).next().html() + ",";
                selectedItems += $(this).closest('tr').find('td:last').text() + ",";
            });
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
                url: "../Pages/SupplierBillPayment.aspx/CreateBill",
                data: '{serialno: "' + result + '", bank: "' + $("#<%=ddlBankLedger.ClientID%>")[0].value + '", chequeno:"' + $("#<%=txtchequeNumber.ClientID%>")[0].value + '", chequedate:"' + $("#<%=txtChaqueDate.ClientID%>")[0].value + '",leafID:"' + $("#<%=hd1.ClientID%>")[0].value + '"}',
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function OnSuccess(response) {
                    alert('Bill payment successfully');
                    $("#<%=ddlBankLedger.ClientID%>")[0].value == "";
                    $("#<%=txtchequeNumber.ClientID%>")[0].value == "";
                    $("#<%=txtChaqueDate.ClientID%>")[0].value == "";
                    location.reload();
                },
                failure: function (response) {

                    //alert(response.d);
                }
            });



        });


        $("#ctl00_PageContentPlaceHolder_control1_txtchequeNumber").autocomplete({
            source: function (request, response) {
                //alert(request.term);
                $.ajax({
                    url: "/Pages/SupplierBillPayment.aspx/GetChequeLeaf",
                    data: "{ 'keyword': '" + request.term + "', 'contextKey' :'" + $("#<%=ddlBankLedger.ClientID%>")[0].value + "'}",
                    dataType: "json",
                    type: "POST",
                    contentType: "application/json; charset=utf-8",
                    success: function (data) {

                        response($.map(data.d, function (item) {
                            return {
                                val: item.split(':')[0],
                                label: item.split(':')[1]
                            }

                            //return {
                            //    value: item
                            //}
                        }));
                    },
                    error: function (XMLHttpRequest, textStatus, errorThrown) {
                        alert(textStatus);
                    }
                });
            },
             select: function (e, i) {
                 $("#<%=hd1.ClientID %>").val(i.item.val);
                       <%--alert( $("#<%=hd1.ClientID %>").val(i.item.val));--%>


                   },
             minLength: 1
         });





    })
   

    var prm = Sys.WebForms.PageRequestManager.getInstance();

    prm.add_endRequest(function () {
        

        $("[id$=txtChaqueDate]").datepicker({
            changeMonth: true,
            changeYear: true
        });
        var sum = 0;

        $(".BillRegisterPayment_grid1 input:checkbox").live("click", function () {
            if($(this).is(':checked')){
                sum = parseInt(sum) + parseInt( $(this).closest('tr').find('td:last').prev().text());
            }else{
                sum = parseInt(sum) - parseInt($(this).closest('tr').find('td:last').prev().text());
            }
          
            //alert(sum);
            $("#<%=lblTotalAmount.ClientID%>").html(sum);

        });
        $('#<%=Button1.ClientID %>').click(function () {

            if ($("#<%=ddlBankLedger.ClientID%>")[0].value == "") {
                 alert('Please select  Bank Ledger');
                 return;
             }
             if ($("#<%=txtchequeNumber.ClientID%>")[0].value == "") {
                 alert('Please input cheque number');
                 return;
             }
             if ($("#<%=txtChaqueDate.ClientID%>")[0].value == "") {
                 alert('Please select  date');
                 return;
             }


             var selectedItems = "";

             $(".BillRegisterPayment_grid1 input[type=checkbox]:checked").each(function () {

                 //  selectedItems += $(this).next().html() + ",";
                 selectedItems += $(this).closest('tr').find('td:last').text() + ",";
             });
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
                 url: "../Pages/SupplierBillPayment.aspx/CreateBill",
                 data: '{serialno: "' + result + '", bank: "' + $("#<%=ddlBankLedger.ClientID%>")[0].value + '", chequeno:"' + $("#<%=txtchequeNumber.ClientID%>")[0].value + '", chequedate:"' + $("#<%=txtChaqueDate.ClientID%>")[0].value + '",leafID:"' + $("#<%=hd1.ClientID%>")[0].value + '"}',
                 contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function OnSuccess(response) {
                    alert('Bill payment successfully');
                    $("#<%=ddlBankLedger.ClientID%>")[0].value == "";
                    $("#<%=txtchequeNumber.ClientID%>")[0].value == "";
                    $("#<%=txtChaqueDate.ClientID%>")[0].value == "";
                    location.reload();
                },
                failure: function (response) {

                    //alert(response.d);
                }
            });



        });


        $("#ctl00_PageContentPlaceHolder_control1_txtchequeNumber").autocomplete({
            source: function (request, response) {
                //alert(request.term);
                $.ajax({
                    url: "/Pages/SupplierBillPayment.aspx/GetChequeLeaf",
                    data: "{ 'keyword': '" + request.term + "', 'contextKey' :'" + $("#<%=ddlBankLedger.ClientID%>")[0].value + "'}",
                    dataType: "json",
                    type: "POST",
                    contentType: "application/json; charset=utf-8",
                    success: function (data) {

                        response($.map(data.d, function (item) {
                            return {
                                val: item.split(':')[0],
                                label: item.split(':')[1]
                            }

                            //return {
                            //    value: item
                            //}
                        }));
                    },
                    error: function (XMLHttpRequest, textStatus, errorThrown) {
                        alert(textStatus);
                    }
                });
            },
            select: function (e, i) {
                $("#<%=hd1.ClientID %>").val(i.item.val);
                       <%--alert( $("#<%=hd1.ClientID %>").val(i.item.val));--%>


             },
            minLength: 1
        });



    });

</script>

