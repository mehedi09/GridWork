<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="UserManagement.aspx.cs" Inherits="Pages_UserManagement"  Title="User Management" %>
<%@ Register Src="../Controls/MembershipManager.ascx" TagName="MembershipManager"  TagPrefix="" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">User Management</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="row"><:MembershipManager ID="control1" runat="server"></:MembershipManager></div>
</asp:Content>