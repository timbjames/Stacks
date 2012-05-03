<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="browse-and-delete.aspx.cs" Inherits="WebApp.Images.browse_and_delete" EnableEventValidation="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style>
        div.img{ position: relative; float: left; width: 80px; display: inline; padding: 2px; }
        div.img span{ width: 80px; display: block; overflow: hidden; white-space: nowrap; text-overflow: ellipsis;  }
        div.img img{ width: 80px; }
        div.chk{ position: absolute; top: 0; left: 0; } 
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:Repeater ID="rptr" runat="server">
                <ItemTemplate>
                    <div class="img">
                        <img src='<%#Eval("img_src") %>' alt='<%#Eval("img_name") %>' />
                        <asp:Label ID="lblFileName" runat="server" ToolTip='<%#Eval("img_name") %>' Text='<%#Eval("img_name") %>' />
                        <div class="chk">
                            <asp:CheckBox ID="chkDelete" runat="server" />
                        </div>
                    </div>                    
                </ItemTemplate>
                <FooterTemplate>
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="Button_OnClick" />
                </FooterTemplate>
            </asp:Repeater>

        </div>
    </form>
</body>
</html>
