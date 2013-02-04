<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApp.Controls.With_JS._default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblOne" runat="server" Text="Hello World" style="display: none;" />
        <script>
            var lbl = document.getElementById('<%= lblOne.ClientID %>');
            var lblText = lbl.innerText;
            alert(lblText);
        </script>
    </div>

        <!-- JavaScript at the bottom for fast page loading -->
        <!-- Grab Google CDN's jQuery, with a protocol relative URL; fall back to local if offline -->
        <script src="//ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js"></script>
        <script>        window.jQuery || document.write('<script src="/js/libs/jquery-1.7.1.min.js"><\/script>')</script>
        <script>
            $(function () {
                var a = document.getElementById('<%=(this.lblOne.ClientID) %>');                
                //alert(a.innerText);
            });
        </script>
    </form>

</body>
</html>
