<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="browse-and-delete.aspx.cs" Inherits="WebApp.Images.browse_and_delete" EnableEventValidation="false" %>
<%@ Register src="browser.ascx" tagname="browser" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

</head>
<body>
    <form id="form1" runat="server">
        <div>            
            <uc1:browser ID="browser1" runat="server" mediaFolder="/images/media/" />            
        </div>
    </form>
</body>
</html>
