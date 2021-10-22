<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertG.aspx.cs" Inherits="Presentations.InsertG" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>INSERT GENRE</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <h1>INSERT GENRE</h1>
                <asp:Label ID="Label1" runat="server" Text="Genre"></asp:Label>
                <asp:TextBox ID="TextBoxGenre" runat="server"></asp:TextBox>
                <asp:Button ID="ButtonSaveG" runat="server" OnClick="ButtonSaveG_Click" Text="Save" />
                <br />
                <asp:Label ID="LabelResul" runat="server"></asp:Label>
                <br />
                <br />
                <asp:Button ID="ButtonShowTG" runat="server" OnClick="ButtonShowTG_Click" Text="Show Table Genres" />
                <br />
                <br />
                <asp:GridView ID="GridViewSG" runat="server" Visible="False">
                </asp:GridView>

            </center>
        </div>
    </form>
</body>
</html>
