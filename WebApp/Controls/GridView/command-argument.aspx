<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="command-argument.aspx.cs" Inherits="WebApp.Controls.GridView.command_argument" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="gv1" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="btnOne" runat="server" CommandName="Click" CommandArgument='<%#Eval("item") %>' Text="Click" />
                        <%--<asp:Button ID="btnOne" runat="server" Text="Click" />--%>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
