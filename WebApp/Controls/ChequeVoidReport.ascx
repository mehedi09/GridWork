<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ChequeVoidReport.ascx.cs" Inherits="Controls_ChequeVoidReport" %>
<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<script src="http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.7.js" type="text/javascript"></script>
<script src="http://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.16/jquery-ui.js" type="text/javascript"></script>
<link href="http://ajax.aspnetcdn.com/ajax/jquery.ui/1.8.16/themes/humanity/jquery-ui.css" rel="stylesheet" type="text/css" />
<script type="text/javascript">
    $(function () {
        $("[id$=txtFrmDate]").datepicker({
            changeMonth: true,
            changeYear: true
        });

        $("[id$=txtTodate]").datepicker({
            changeMonth: true,
            changeYear: true
        });
    });


    var prm = Sys.WebForms.PageRequestManager.getInstance();

    prm.add_endRequest(function () {
        $("[id$=txtFrmDate]").datepicker({
            changeMonth: true,
            changeYear: true
        });

        $("[id$=txtTodate]").datepicker({
            changeMonth: true,
            changeYear: true
        });
    });


    <%--        function validate() {

            var txtFromDate = document.getElementById('<%=txtFrmDate.ClientID %>').value;
            var txtToDate = document.getElementById('<%=txtTodate.ClientID %>').value;

            if (ddlCoaDetail == "Select") {
                  alert("Pleace select a Company");
                  return false;
              }

            if (txtFrmDate == "") {
                  alert("Pleace a Date");
                  return false;
              }
            if (txtTodate == "") {
                  alert("Pleace a Date");
                  return false;
              }

          }--%>


</script>


<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <div style="margin: 2px; padding: 8px;">
            <div id="PagesHeader" runat="server">
                <div>
                    <asp:Label ID="lblerror" runat="server" Text="" ForeColor="Red"></asp:Label>
                </div>

                <div style="border: 1px solid #cccccc; width: 350px; padding-left: 5px;">
                    <div style="clear: both; height: 10px;"></div>
                    <div style="float: left; position: relative; width: 110px; font-family: Arial Unicode MS;" class="auto-style1">Bank Name </div>
                    <div style="float: left; position: relative; width: 200px; padding-left: 10px;">
                        <asp:DropDownList ID="ddlCoaDetail" Width="200px" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlCoaDetail_SelectedIndexChanged"></asp:DropDownList>

                    </div>
                    <div style="float: left; position: relative;">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="ddlCoaDetail" InitialValue="--Select One--" ToolTip="Please Select a Bank" ForeColor="Red">*</asp:RequiredFieldValidator>

                    </div>
                    <div style="clear: both; height: 10px;"></div>
                    <div style="float: left; position: relative; width: 110px; font-family: Arial Unicode MS;" class="auto-style1">Cheque Book</div>
                    <div style="float: left; position: relative; width: 200px; padding-left: 10px;">
                        <asp:DropDownList ID="ddlCheckBook" Width="200px" runat="server" AutoPostBack="True"></asp:DropDownList>

                    </div>
                    <div style="float: left; position: relative;">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="ddlCheckBook" InitialValue="--Select One--" ToolTip="Please Select a Cheque Book " ForeColor="Red">*</asp:RequiredFieldValidator>

                    </div>

                    <div style="clear: both; height: 10px;"></div>

                    <div style="float: left; position: relative; width: 110px; font-family: Arial Unicode MS;" class="auto-style1">
                        From Date

                    </div>
                    <div style="float: left; position: relative; width: 200px; padding-left: 10px;">

                        <asp:TextBox ID="txtFrmDate" Width="195px" runat="server"></asp:TextBox>
                    </div>
                    <div style="float: left; position: relative;">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" ControlToValidate="txtFrmDate" ToolTip="Please Select From Date " ForeColor="Red">*</asp:RequiredFieldValidator>

                    </div>



                    <div style="clear: both; height: 10px;"></div>
                    <div style="float: left; position: relative; width: 110px; font-family: Arial Unicode MS;" class="auto-style1">To Date </div>
                    <div style="float: left; position: relative; width: 200px; padding-left: 10px;">

                        <asp:TextBox ID="txtTodate" Width="195px" runat="server"></asp:TextBox>
                    </div>
                    <div style="float: left; position: relative;">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*" ControlToValidate="txtTodate" ToolTip="Please Select To Date " ForeColor="Red">*</asp:RequiredFieldValidator>

                    </div>
                    <div style="clear: both; height: 10px;"></div>

                    <div style="float: left; position: relative; padding-left: 100px;">
                        <asp:Button ID="btn_ShowReport" runat="server" Text="Show Report" OnClick="btn_ShowReport_Click" />
                    </div>
                    <div style="clear: both; height: 10px;"></div>

                </div>
            </div>
            <div class="ParaHeader" id="rptHeader" runat="server">
                <asp:LinkButton ID="return_ChequeVoidReport" runat="server" CssClass="btn btn-info" Style="margin-left: 40%" OnClick="return_ChequeVoidReport_Click">
                <i class="icon-ok icon-white"></i>Return Cheque Void

                </asp:LinkButton>
            </div>
            <div id="ReportForm" runat="server">

                <table style="width: 100%; height: 406px;">
                    <tr>
                        <td style="vertical-align: top;">
                            <div style="align-content: center">
                                <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" SizeToReportContent="True" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" AsyncRendering="false" Visible="false">
                                    <LocalReport>
                                        <DataSources>
                                            <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSet1" />
                                        </DataSources>
                                    </LocalReport>
                                </rsweb:ReportViewer>
                            </div>

                        </td>
                        <td>
                            <embed runat="server" id="report" style="width: 100%;" height="550" name="whatever" type='application/pdf' />
                        </td>
                    </tr>
                </table>

            </div>

        </div>
    </ContentTemplate>
</asp:UpdatePanel>
<!-- 
    This section provides a sample markup for Touch UI user interface. 
-->


