<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Presentations._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>CRUD DISCO ENTITY</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
            <br />
        </div>
        <div>
            <br />
        </div>
        </div>
            <center>
                <h1>CRUD MUSIC</h1>
                 <asp:Menu ID="Menu1" target="_blank" runat="server" BackColor="Red" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="Aqua" Height="20px" Orientation="Horizontal" StaticSubMenuIndent="20px" Width="350px">
                <DynamicHoverStyle BackColor="Black" BorderColor="#66FF33" Font-Bold="True" ForeColor="White" />
                <DynamicMenuItemStyle BackColor="#0080C0" BorderColor="#660033" HorizontalPadding="20px" VerticalPadding="2px" />
                <DynamicMenuStyle BackColor="#FFFBD6" />
                <DynamicSelectedStyle BackColor="#FFCC66" />
                <Items>
                    <asp:MenuItem Text="GENRES" Value="GENRES">
                        <asp:MenuItem Text="InsertG" Value="InsertG" target="_blank" NavigateUrl="~/InsertG.aspx"></asp:MenuItem>
                        <asp:MenuItem Text="UpdateG" Value="UpdateG" target="_blank" NavigateUrl="~/UpdateG.aspx"></asp:MenuItem>
                        <asp:MenuItem Text="DeleteG" Value="DeleteG" target="_blank" NavigateUrl="~/DeleteG.aspx"></asp:MenuItem>
                    </asp:MenuItem>
                    <asp:MenuItem Text="ALBUMS" Value="ALBUMS">
                        <asp:MenuItem Text="InsertA" Value="InsertA" target="_blank" NavigateUrl="~/InsertA.aspx"></asp:MenuItem>
                        <asp:MenuItem Text="UpdateA" Value="UpdateA" target="_blank" NavigateUrl="~/UpdateA.aspx"></asp:MenuItem>
                        <asp:MenuItem Text="DeleteA" Value="DeleteA" target="_blank" NavigateUrl="~/DeleteA.aspx"></asp:MenuItem>
                    </asp:MenuItem>
                </Items>
                <StaticHoverStyle BackColor="#990000" ForeColor="White" />
                <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                <StaticSelectedStyle BackColor="#FFCC66" />
                <StaticItemTemplate>
                    <%# Eval("Text") %>
                </StaticItemTemplate>
            </asp:Menu>
            </center>
    </form>
</body>
</html>
