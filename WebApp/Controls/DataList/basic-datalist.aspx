<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="basic-datalist.aspx.cs" Inherits="WebApp.Controls.DataList.basic_datalist" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DataList ID="dl1" runat="server">
            <ItemTemplate>
                <asp:Button ID="btnOne" runat="server" Text="Click" CommandName="Click" />
            </ItemTemplate>
        </asp:DataList>
    </div>
    </form>
</body>
</html>
