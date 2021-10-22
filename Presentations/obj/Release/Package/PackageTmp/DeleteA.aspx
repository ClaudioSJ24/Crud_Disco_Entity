<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteA.aspx.cs" Inherits="Presentations.DeleteA" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>DELETE ALBUM</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <h1>DELETE ALBUM</h1>
                <h2>SELECT ID_ALBUM</h2>
                <asp:Label ID="Label2" runat="server" Text="Id_Album &amp;nbsp&amp;nbsp&amp;nbsp&amp;nbsp"></asp:Label>
                <asp:DropDownList ID="DropDownListA" runat="server" AutoPostBack="True" Height="20px" style="margin-left: 0px" Width="127px" OnSelectedIndexChanged="DropDownListA_SelectedIndexChanged">
                </asp:DropDownList>
                <br />
                <br />
                <asp:Label ID="Label4" runat="server" Text="Name &amp;nbsp&amp;nbsp&amp;nbsp&amp;nbsp&amp;nbsp&amp;nbsp&amp;nbsp&amp;nbsp"></asp:Label>
                <asp:TextBox ID="TextBoxName" runat="server" ReadOnly="True"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label1" runat="server" Text="Author    &amp;nbsp&amp;nbsp&amp;nbsp&amp;nbsp&amp;nbsp&amp;nbsp"></asp:Label>
                <asp:TextBox ID="TextBoxAuthor" runat="server" ReadOnly="True"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label3" runat="server" Text="Id_Gen &amp;nbsp&amp;nbsp&amp;nbsp&amp;nbsp&amp;nbsp"></asp:Label>
                <asp:TextBox ID="TextBoxGenre" runat="server" ReadOnly="True"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="ButtonDeleteA" runat="server" Text="Delete" OnClick="ButtonDeleteA_Click" />
                <br />
                <br />
                <asp:Label ID="LabelResul" runat="server"></asp:Label>
                
                <br />
                <br />
                
                <asp:Button ID="ButtonShowTA" runat="server"  Text="Show Table Albums" OnClick="ButtonShowTA_Click" />
              
                <br />
                <br />
                <asp:GridView ID="GridViewSA" runat="server" Visible="False">
                </asp:GridView>

            </center>
        </div>
    </form>
</body>
</html>
