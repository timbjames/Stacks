<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApp.Controls.TreeView.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TreeView ID="TreeView1" runat="server">
            <Nodes>
                <asp:TreeNode Text="Table of Contents" Expanded="true">
                    <%--<asp:TreeNode Text="Chapter One"></asp:TreeNode>
                    <asp:TreeNode Text="Chapter Two"></asp:TreeNode>
                    <asp:TreeNode Text="Chapter Three"></asp:TreeNode>
                    <asp:TreeNode Text="Chapter Four"></asp:TreeNode>--%>
                </asp:TreeNode>
            </Nodes>
        </asp:TreeView>

    </div>
    </form>
</body>
</html>
