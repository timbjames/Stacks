<%@ Page Title="" Language="C#" MasterPageFile="~/skin/global.Master" AutoEventWireup="true" CodeBehind="DeleteMe.aspx.cs" Inherits="WebApp.DeleteMe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Button ID="btnOne" runat="server" Text="Hello" />

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Javascript" runat="server">
<script>
    $(function () {
        console.log($('[id$="btnOne"]'));
    });
</script>
</asp:Content>
