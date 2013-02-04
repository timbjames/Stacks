<%@ Page Title="" Language="C#" MasterPageFile="~/skin/global.Master" AutoEventWireup="true" CodeBehind="item-databound.aspx.cs" Inherits="WebApp.Controls.Repeater.item_databound" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Repeater ID="rptr1" runat="server">
        <HeaderTemplate>
            <h2>This is the Repeater control</h2>
            <ul>
        </HeaderTemplate>
        <AlternatingItemTemplate>
            <li>
                Alternating Item
                <asp:PlaceHolder ID="placeHolder1" runat="server" />
            </li>
        </AlternatingItemTemplate>
        <ItemTemplate>
            <li>
                Item
                <asp:PlaceHolder ID="placeHolder1" runat="server" />
            </li>
        </ItemTemplate>
        <SeparatorTemplate>
            <li>Separator</li>
        </SeparatorTemplate>
        <FooterTemplate>
            </ul>
        </FooterTemplate>
    </asp:Repeater>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Javascript" runat="server"></asp:Content>
