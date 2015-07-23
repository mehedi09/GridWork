<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="WebApp.ForgotPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Forgot Password</title>
</head>
<body>
    <form id="form1" runat="server">
    
    <asp:ScriptManager ID="sm" runat="server" EnableScriptGlobalization="true" ScriptMode="Release" />
         <div id="PageHeader">
          <div id="PageHeaderBar">
            <asp:Label ID="PageHeaderContentPlaceHolder" runat="server">IPAC ERP - Financial Management Module</asp:Label>
          </div>
          <div id="PageMenuBar" runat="server" class="PageMenuBar"></div>
        </div>
         <table id="PageBody">
          <tr>
            <td id="PageHeaderSideBar">
              <%--<asp:Image ID="Image5" runat="server" SkinID="PageLogo" CssClass="PageLogo" />--%>
            </td>
            <td id="PageHeaderLeftSide"><span class="placeholder"> </span></td>
            <td id="PageHeaderContent">
              <div class="Header">
                <asp:SiteMapPath ID="SiteMapPath1" runat="server" SkinID="SiteMapPath" />
                <div class="Title">
                  <asp:Label ID="PageTitleContentPlaceHolder" runat="server">Forgot Password</asp:Label>
                </div>
              </div>
            </td>
            <td id="PageHeaderRightSide"><span class="placeholder"> </span></td>
          </tr>
          <tr>
            <td id="PageContentSideBar">
              <div class="SideBarBody">
                <asp:Label ID="SideBarPlaceHolder" runat="server" /><span class="placeholder"> </span></div>
            </td>
            <td id="PageContentLeftSide"><span class="placeholder"> </span></td>
            <td id="PageContent">
             <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
            <asp:View ID="View1" runat="server">
    <table style="width: 339px; position: static">
        <tr>
            <td colspan="3">
                <strong><span style="font-size: 16pt; color: #007fd6; font-family: Arial Narrow"></span></strong></td>
        </tr>
        <tr>
            <td style="width: 86px">
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td style="width: 86px">
                <asp:Label ID="Label1" runat="server" Text="Email Address:" Width="97px"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server" Style="position: static"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtEmail"
                    Display="Dynamic" ErrorMessage="RequiredFieldValidator" Style="position: static">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail"
                    ErrorMessage="RegularExpressionValidator" Style="position: static" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator></td>
        </tr>
        <tr>
            <td style="width: 86px">
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td style="width: 86px">
            </td>
            <td>
                &nbsp;<asp:Button ID="Button1" runat="server" CssClass="SubmitBtn" Font-Bold="True"
                    OnClick="Button1_Click" Style="position: static" Text="Send Password" /></td>
            <td>
            </td>
        </tr>
        <tr>
            <td style="width: 86px">
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblNotFound" runat="server" Font-Bold="True" ForeColor="#FF0033" Style="position: static"></asp:Label></td>
            <td>
            </td>
        </tr>
    </table>
            </asp:View>
            <asp:View ID="View2" runat="server">
                <br />
                <strong>Thank you<br />
                    <br />
                    Your Password has been sent to you<br />
                    <br />
                    Please check your email<br />
                </strong>
            </asp:View>
            <asp:View ID="View3" runat="server">
                <br />
                <strong>An error accured during sending email<br />
                    <br />
                    Please try again
                    <br />
                    <br />
                    Click
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">here</asp:LinkButton>
                    to try
                    <br />
                </strong>
            </asp:View>
        </asp:MultiView>
            </td>
            <td id="PageContentRightSide"><span class="placeholder"> </span></td>
          </tr>
          <tr>
            <td id="PageFooterSideBar"><span class="placeholder"> </span></td>
            <td id="PageFooterLeftSide"><span class="placeholder"> </span></td>
            <td id="PageFooterContent"><span class="placeholder"> </span></td>
            <td id="PageFooterRightSide"><span class="placeholder"> </span></td>
          </tr>
        </table>
        <div id="PageFooterBar">
          <asp:Label ID="PageFooterContentPlaceHolder" runat="server">&copy;  2015 MyCompany. ^Copyright^All rights reserved.^Copyright^</asp:Label>
        </div>
   
    </form>
</body>
</html>
