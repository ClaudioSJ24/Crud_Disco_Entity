<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteG.aspx.cs" Inherits="Presentations.DeleteG" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>DELETE GENRE</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <h1>DELETE GENRE</h1>
                <h2>SELECT ID_GENRE</h2>
                Id_Genre<asp:DropDownList ID="DropDownListGen" runat="server" OnSelectedIndexChanged="DropDownListGen_SelectedIndexChanged" AutoPostBack="True">
                </asp:DropDownList>

                <asp:Label ID="Label2" runat="server" Text="Genre"></asp:Label>
                <asp:TextBox ID="TextBoxGenreD" runat="server" ReadOnly="True"></asp:TextBox>
                <asp:Button ID="ButtonDeleteG" runat="server" Text="Delete" OnClick="ButtonDeleteG_Click" />
                <br />
                <br />
                <asp:Label ID="LabelResul" runat="server"></asp:Label>
                
                <br />
                <br />
                
                <asp:Button ID="ButtonShowTG" runat="server"  Text="Show Table Genres" OnClick="ButtonShowTG_Click" />
              
                <br />
                <br />
                <asp:GridView ID="GridViewDG" runat="server" Visible="False">
                </asp:GridView>

            </center>
        </div>
    </form>
</body>
</html>
