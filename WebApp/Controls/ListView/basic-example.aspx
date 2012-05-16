<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="basic-example.aspx.cs" Inherits="WebApp.Controls.ListView.basic_example" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <asp:ListView ID="ListView1" runat="server">
            <LayoutTemplate>
                <ul>
                    <asp:PlaceHolder ID="itemPlaceholder" runat="server" />    
                </ul>                
            </LayoutTemplate>
            <ItemTemplate>
                <li>Item</li>
            </ItemTemplate>
            <EmptyDataTemplate>
                <p>Nothing here.</p>
            </EmptyDataTemplate>
        </asp:ListView>
        
    </div>
    </form>
</body>
</html>
