<%@ Page Title="" Language="C#" MasterPageFile="~/skin/global.Master" AutoEventWireup="true" CodeBehind="row-databound.aspx.cs" Inherits="WebApp.Controls.GridView.row_databound" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="gv1" runat="server">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    Item
                    <asp:Literal ID="literal1" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    Item
                    <asp:PlaceHolder ID="placeHolder1" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Javascript" runat="server"></asp:Content>
