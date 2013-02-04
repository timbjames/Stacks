<%@ Page Title="" Language="C#" MasterPageFile="~/master-pages/default.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApp.master_pages._default1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        $(function () {
            alert("<%=(btnSearch.ClientID) %>");
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Button ID="btnSearch" runat="server" Text="Search" />

</asp:Content>
