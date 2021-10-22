<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertA.aspx.cs" Inherits="Presentations.InsertA" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>INSERT ALBUM</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <center>
                <h1>INSERT ALBUM</h1>

                <asp:Label ID="Label2" runat="server" Text="Name &nbsp"></asp:Label>
                <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label1" runat="server" Text="Author    "></asp:Label>
                <asp:TextBox ID="TextBoxAuthor" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label3" runat="server" Text="Genre &nbsp"></asp:Label>
                <asp:DropDownList ID="DropDownListG" runat="server" AutoPostBack="True" Height="20px" style="margin-left: 0px" Width="127px">
                </asp:DropDownList>
                <br />
                <br />
                <asp:Button ID="ButtonInsertA" runat="server" Text="Save" OnClick="ButtonInsertA_Click" />
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
