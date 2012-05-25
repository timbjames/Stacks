<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="button-clicks.aspx.cs" Inherits="WebApp.Controls.Buttons.button_clicks" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Literal ID="ltStatus" runat="server" />
        <asp:Button ID="btnOne" runat="server" Text="Button One" OnClick="button1_Click" ClientIDMode="Static" />
        <br />
        <asp:Button ID="btnTwo" runat="server" Text="Button Two" onclick="Button3_Click" />        
    </div>
    </form>
</body>
</html>
