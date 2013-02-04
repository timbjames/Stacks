<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="custom.aspx.cs" Inherits="WebApp.cookie_compliance.custom" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>    
    <script src="/js/libs/jquery-1.7.1.min.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>    
        <asp:TextBox ID="tbCustom" runat="server" /> <asp:Button ID="btnSave" runat="server" Text="Go" />
    </div>
    </form>
</body>
</html>
