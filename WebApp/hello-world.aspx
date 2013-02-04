<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hello-world.aspx.cs" Inherits="WebApp.hello_world" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1 id="hell1">Hello World</h1>
        <p>
            O Hai!
        </p>   
        <asp:Panel ID="pnlOne" runat="server">        
            <asp:Button ID="btnClick" runat="server" OnClick="ClickedMe" />     
        </asp:Panel>  
        <asp:PlaceHolder ID="phOne" runat="server">
            <input type="text" id="tbOne" runat="server" />
        </asp:PlaceHolder>      
    </div>
    </form>

     <script src="//ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js"></script>
    <script>        window.jQuery || document.write('<script src="/js/libs/jquery-1.7.1.min.js"><\/script>')</script>
<script>
    $(function () {
        //$('[id$="btnClick"]').click();
        document.getElementById('hell1').style.display = '<%Response.Write((Request.ServerVariables["HTTP_USER_AGENT"].Contains("Chrome") ? "block": "none")); %>';
    });
</script>

</body>
</html>
