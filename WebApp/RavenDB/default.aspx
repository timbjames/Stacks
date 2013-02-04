<%@ Page Title="" Language="C#" MasterPageFile="~/RavenDB/RavenDB.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApp.RavenDB._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:TextBox ID="tbProdId" runat="server" /> <asp:Button ID="btnDisc" runat="server" Text="Discontinue Product" />

    <br />

    <asp:Button ID="btnLoadDisc" runat="server" Text="Load Discontinued Products" />

    <br />

    <asp:GridView ID="gvDiscontinued" runat="server" />

</asp:Content>
