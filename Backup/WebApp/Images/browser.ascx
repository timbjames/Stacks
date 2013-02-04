<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="browser.ascx.cs" Inherits="ImageBrowser.browser" %>

<asp:PlaceHolder ID="phStyles" runat="server">
    <style>
        div.img{ position: relative; float: left; width: 80px; display: inline; padding: 2px; }
        div.img span{ width: 80px; display: block; overflow: hidden; white-space: nowrap; text-overflow: ellipsis;  }
        div.img img{ width: 80px; }
        div.chk{ position: absolute; top: 0; left: 0; } 
        div.err{ width: 100%; color: Red; font-weight: bold; border: 1px solid red; }
    </style>
</asp:PlaceHolder>

<asp:PlaceHolder ID="phError" runat="server" />

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