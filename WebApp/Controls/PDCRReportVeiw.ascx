<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PDCRReportVeiw.ascx.cs" Inherits="Controls_PDCRReportVeiw"  %>
<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!-- 
    This section provides a sample markup for Desktop user inteface.
-->
<asp:UpdatePanel ID="UpdatePanel1" runat="server"><ContentTemplate><div style="margin:2px;border: solid 1px silver;padding:8px;">
    <asp:HiddenField ID="hdmoney" runat="server" />
    <asp:Button ID="Button1" runat="server" Text="Return to PDCR" OnClick="Button1_Click" />
<%--    <asp:HiddenField ID="hdapplicant" runat="server" />
    <asp:HiddenField ID="hdType" runat="server" />--%>
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" SizeToReportContent="True"></rsweb:ReportViewer>
   </div></ContentTemplate></asp:UpdatePanel>
<%--<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
      <div>
            <div style="clear: both; height: 10px;">
            </div>
            <div style="float: left; position: relative; width: 150px;" class="auto-style1"><strong></strong></div>
            <div style="float: left; position: relative; padding-left: 10px;">
                <asp:CheckBox ID="ckmrtype" runat="server" Text="Sales/General" AutoPostBack="True" OnCheckedChanged="ckmrtype_CheckedChanged" />
            </div>
            <div style="clear: both; height: 10px;"></div>
            <asp:Panel ID="ckpanel" runat="server">
                 <div style="float: left; position: relative; width: 150px;" class="auto-style">
                <strong>Project</strong>
            </div>
             <div style="float: left; position: relative; padding-left: 10px;">
                <asp:DropDownList ID="cmbproject" runat="server" Font-Bold="True" Width="200px" Height="22px" TextMode="Date" AutoPostBack="True" OnSelectedIndexChanged="cmbproject_SelectedIndexChanged"></asp:DropDownList>              
            </div>
             <div style="clear:both"></div>
               <div style="float: left; position: relative; width: 150px;" class="auto-style">
                <strong>Block</strong>
            </div>
             <div style="float: left; position: relative; padding-left: 10px;">
                <asp:DropDownList ID="cmbblock" runat="server" Font-Bold="True" Width="200px" Height="22px" TextMode="Date" AutoPostBack="True" OnSelectedIndexChanged="cmbblock_SelectedIndexChanged"></asp:DropDownList>              
            </div>
             <div style="clear:both"></div>
            <div style="float: left; position: relative; width: 150px;" class="auto-style">
                <strong>File No</strong>
            </div>             
            <div style="float: left; position: relative; padding-left: 10px;">
                  <asp:DropDownList ID="cmbapplicationid" runat="server" Font-Bold="True" Width="200px" Height="22px" TextMode="Date" AutoPostBack="True" OnSelectedIndexChanged="cmbapplicationid_SelectedIndexChanged"></asp:DropDownList> 
            </div>   
                 
                <div style="clear:both"></div>
               
                <div style="float: left; position: relative; width: 150px;" class="auto-style1"><strong>PDCR No. :</strong></div>
                <div style="float: left; position: relative; padding-left: 10px;">
                    <asp:DropDownList ID="cmbmonre" runat="server" Width="194px">
                    </asp:DropDownList>
                </div>
            <div style="clear: both; height: 10px;">
                
            </div>
            </asp:Panel>
             <asp:Panel ID="ckPanel1" runat="server">
                <div style="float: left; position: relative; width: 150px;" class="auto-style1"><strong>Payment Name :</strong></div>
                <div style="float: left; position: relative; padding-left: 10px;">
                    <asp:DropDownList ID="cmbpaymentname" runat="server" Width="208px" AutoPostBack="True" OnSelectedIndexChanged="cmbpaymentname_SelectedIndexChanged">
                </asp:DropDownList>
                </div>
                <div style="clear: both; height: 10px;"></div>
                <div style="float: left; position: relative; width: 150px;" class="auto-style1"><strong>PDC Receipt No. :</strong></div>
                <div style="float: left; position: relative; padding-left: 10px;">
                    <asp:DropDownList ID="DropDownList1" runat="server" Width="208px">
                    </asp:DropDownList>
                </div>
            </asp:Panel>

            <div style="clear: both; height: 10px;">
            </div>
            <div style="float: left; position: relative; padding-left: 10px;">
            </div>
            <div style="float: left; position: relative; width: 240px;">
                <asp:Button ID="Button1" runat="server" Width="240px" Text="Show Report" OnClick="Button1_Click1" />
            </div>
        </div>
        <div style="clear: both; height: 10px;"></div>
        <rsweb:ReportViewer ID="ReportViewer1" runat="server" SizeToReportContent="True"></rsweb:ReportViewer>    </ContentTemplate>
</asp:UpdatePanel>--%>